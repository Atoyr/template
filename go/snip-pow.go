func pow(a, b {{_input_:type}}) {{_input_:type}} {
  ret := a
  for i := 0; i < b-1; i++ {
    ret *= a
  }
  return ret
}

