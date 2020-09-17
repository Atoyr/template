dx := []int{1,0,-1,0}
dy := []int{0,1,0,-1}
for i := 0; i < 4; i++ {
  nx := {{_input_:myX}} + dx[i]
  ny := {{_input_:myY}} + dy[i]
  if 0 <= nx && nx < {{_input_:X}} && 0 <= ny && ny < {{_input_:Y}} {
    {{_cursor_}}
  }
}

