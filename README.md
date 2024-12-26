# Unexpected Mutability with References in F#

This example demonstrates a potential issue when working with mutable variables and references in F#.  Assigning a mutable variable to a reference does not create a copy; therefore, changes to the original variable are reflected in the reference, but changes to the reference may not always update the original variable.

## Bug Description
The bug occurs when modifying a mutable variable after it's been assigned to a reference. The reference will point to the old value of the mutable variable, not its updated value.

## Solution
The most straightforward solution is to avoid this type of behavior by modifying the reference directly, or by copying the contents of the mutable variable to a new location, ensuring that modifications to the copy don't impact the original.