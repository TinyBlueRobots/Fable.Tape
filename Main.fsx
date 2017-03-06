#load "Fable.Tape.fsx"

open Fable.Tape

test "Is true always true?" <| fun t ->
  t.``true`` true
  t.``end``()

test "1 + 1 = 2" <| fun t ->
  let result = 1 + 1
  t.equals(result, 2)
  t.``end``()