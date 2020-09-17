type queue []{{_input_:type}}

func newQueue() queue{
  return make([]{{_input_:type}},0)
}

func(q *queue) push(v {{_input_:type}}) {
  *q = append(*q,v)
}

func(q *queue) pop() {{_input_:type}} {
  v := (*q)[0]
  *q = (*q)[1:]
  return v
}

func(q *queue) size() int {
  return len(q)
}

func(q *queue) isEmpty() bool {
  return len(q) == 0
}
