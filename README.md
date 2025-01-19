# Unexpected Behavior with Reference Types in C#

This repository demonstrates a subtle but common issue in C# related to reference types.  The example shows how modifying a variable that references an object can unexpectedly change the original object's state.

## Bug Description
The `ExampleClass` has a property `MyProperty`. When we create `instance2` and assign `instance1` to it, both variables point to the same object in memory. Modifying `MyProperty` through `instance2` also alters the value accessible through `instance1`. This behavior might be unexpected for those unfamiliar with C#'s reference type semantics.

## Solution
The solution involves understanding and handling reference types appropriately.  Creating a deep copy (clone) if necessary, or using value types for scenarios where immutability is desired, prevents this kind of side effect.