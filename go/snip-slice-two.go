{{_input_:var}} := make([][]{{_input_:type}},{{_input_:Y}})

for i := 0; i < {{_input_:Y}}; i++ {
  {{_input_:var}}[i] = make([]int,{{_input_:X}})
  for j := 0; j < {{_input_:X}}; j++ {
    sh[i][j] = {{_input_:init-value}}
  }
}

