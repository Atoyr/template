package main

import (
	"io"
	"os"
  "fmt"
  "bufio"
	"strconv"
	"strings"
	"testing"
)

type testValue struct {
	arg []string
	ans []string
}

func getTests() []testValue {
  tvs := make([]testValue,0)
  fp, _ := os.Open("test.txt")
  defer fp.Close()

  c := 0
  i := 0
  ans := false
  scanner := bufio.NewScanner(fp)
  for scanner.Scan() {
    if !ans && i == 0 {
      tvs = append(tvs,testValue{arg:make([]string,0), ans:make([]string,0)})
    }
    s := scanner.Text()
    i = i + 1
    if s == "" {
      i = 0
      ans = !ans
      if !ans {
        c = c + 1
      }
    } else {
      if ans {
        tvs[c].ans = append(tvs[c].ans,s)
      } else {
        tvs[c].arg = append(tvs[c].arg,s)
      }
    }
  }
  for i := range tvs {
    fmt.Printf("case %d\n",i)
    fmt.Println("input")
    for _, in := range tvs[i].arg {
      fmt.Println(in)
    }
    fmt.Println()
    fmt.Println("output")
    for _, out := range tvs[i].ans {
      fmt.Println(out)
    }
    fmt.Println()
  }
	return tvs
}

func stubio(inbuf string, f func()) (string, string) {
	inr, inw, _ := os.Pipe()
	outr, outw, _ := os.Pipe()
	errr, errw, _ := os.Pipe()

	orgStdin := os.Stdin
	orgStdout := os.Stdout
	orgStderr := os.Stderr

	inw.Write([]byte(inbuf))
	inw.Close()

	os.Stdin = inr
	os.Stdout = outw
	os.Stderr = errw

	outC := make(chan string)
	errC := make(chan string)
	defer close(outC)
	defer close(errC)
	go func() {
		var buf strings.Builder
		io.Copy(&buf, outr)
		outr.Close()
		outC <- buf.String()
	}()

	go func() {
		var buf strings.Builder
		io.Copy(&buf, errr)
		errr.Close()
		errC <- buf.String()
	}()

	f()

	os.Stdin = orgStdin
	os.Stdout = orgStdout
	os.Stderr = orgStderr
	outw.Close()
	errw.Close()

	return <-outC, <-errC
}

func Test_main(t *testing.T) {
	tests := getTests()
	for i, tt := range tests {
		si := strconv.Itoa(i)
		t.Run("Case "+si, func(t *testing.T) {
			ret, err := stubio(strings.Join(tt.arg, " "), main)
			if err != "" {
				t.Errorf("error func: %s ", err)
			}
			ans := strings.Join(tt.ans, "\n")
			if ret != ans {
				t.Errorf("Unexpected output: '%s' Need: '%s'", ret, ans)
			}
		})
	}
}

