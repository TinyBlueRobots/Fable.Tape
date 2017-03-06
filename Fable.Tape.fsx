#r "node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Core.JsInterop
open System.Text.RegularExpressions
open System

type Test =
  [<Emit("$0($1...)")>] abstract Create: name: string * (Test -> unit) -> unit
  abstract ``end``: ?err: obj -> unit
  abstract fail: ?msg: string -> unit
  abstract pass: ?msg: string -> unit
  abstract timeoutAfter: ms: float -> unit
  abstract skip: ?msg: string -> unit
  abstract ok: value: obj * ?msg: string -> unit
  abstract ``true``: value: obj * ?msg: string -> unit
  abstract ``assert``: value: obj * ?msg: string -> unit
  abstract notOk: value: obj * ?msg: string -> unit
  abstract ``false``: value: obj * ?msg: string -> unit
  abstract notok: value: obj * ?msg: string -> unit
  abstract error: err: obj * ?msg: string -> unit
  abstract ifError: err: obj * ?msg: string -> unit
  abstract ifErr: err: obj * ?msg: string -> unit
  abstract iferror: err: obj * ?msg: string -> unit
  abstract equal: actual: obj * expected: obj * ?msg: string -> unit
  abstract equals: actual: obj * expected: obj * ?msg: string -> unit
  abstract isEqual: actual: obj * expected: obj * ?msg: string -> unit
  abstract is: actual: obj * expected: obj * ?msg: string -> unit
  abstract strictEqual: actual: obj * expected: obj * ?msg: string -> unit
  abstract strictEquals: actual: obj * expected: obj * ?msg: string -> unit
  abstract notEqual: actual: obj * expected: obj * ?msg: string -> unit
  abstract notEquals: actual: obj * expected: obj * ?msg: string -> unit
  abstract notStrictEqual: actual: obj * expected: obj * ?msg: string -> unit
  abstract notStrictEquals: actual: obj * expected: obj * ?msg: string -> unit
  abstract isNotEqual: actual: obj * expected: obj * ?msg: string -> unit
  abstract isNot: actual: obj * expected: obj * ?msg: string -> unit
  abstract not: actual: obj * expected: obj * ?msg: string -> unit
  abstract doesNotEqual: actual: obj * expected: obj * ?msg: string -> unit
  abstract isInequal: actual: obj * expected: obj * ?msg: string -> unit
  abstract deepEqual: actual: obj * expected: obj * ?msg: string -> unit
  abstract deepEquals: actual: obj * expected: obj * ?msg: string -> unit
  abstract isEquivalent: actual: obj * expected: obj * ?msg: string -> unit
  abstract same: actual: obj * expected: obj * ?msg: string -> unit
  abstract notDeepEqual: actual: obj * expected: obj * ?msg: string -> unit
  abstract notEquivalent: actual: obj * expected: obj * ?msg: string -> unit
  abstract notDeeply: actual: obj * expected: obj * ?msg: string -> unit
  abstract notSame: actual: obj * expected: obj * ?msg: string -> unit
  abstract isNotDeepEqual: actual: obj * expected: obj * ?msg: string -> unit
  abstract isNotDeeply: actual: obj * expected: obj * ?msg: string -> unit
  abstract isNotEquivalent: actual: obj * expected: obj * ?msg: string -> unit
  abstract isInequivalent: actual: obj * expected: obj * ?msg: string -> unit
  abstract deepLooseEqual: actual: obj * expected: obj * ?msg: string -> unit
  abstract looseEqual: actual: obj * expected: obj * ?msg: string -> unit
  abstract looseEquals: actual: obj * expected: obj * ?msg: string -> unit
  abstract notDeepLooseEqual: actual: obj * expected: obj * ?msg: string -> unit
  abstract notLooseEqual: actual: obj * expected: obj * ?msg: string -> unit
  abstract notLooseEquals: actual: obj * expected: obj * ?msg: string -> unit
  abstract throws: fn: Func<unit, unit> * ?msg: string -> unit
  abstract throws: fn: Func<unit, unit> * exceptionExpected: U2<Regex, Func<unit, unit>> * ?msg: string -> unit
  abstract doesNotThrow: fn: Func<unit, unit> * ?msg: string -> unit
  abstract doesNotThrow: fn: Func<unit, unit> * exceptionExpected: U2<Regex, Func<unit, unit>> * ?msg: string -> unit
  abstract comment: msg: string -> unit

let tape: Test = importDefault "tape"

let test name fn = tape.Create(name, fn)