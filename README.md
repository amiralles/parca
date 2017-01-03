# Parca
This library provides a handful of *die helper methods* for .NET.

### How it works

```c
using System;
using static Parca;

// Just throws an exception.
Die("Foo Error.");

// Throws an exception if the given condition is TRUE.
DieIf(1 == 1, "Foo Error.");

// Throws an exception if the given condition is FALSE.
DieUnless(1 == 2, "Foo Error.");

// Throws a typeof T exception.
DieWith<NullReferenceException>("Foo can't be null.");

// Throws a type of T exception if the given condition is TRUE.
DieWith<NullReferenceException>(If(1==1), "Foo can't be null.");

// Throws a type of T exception if the given condition is FALSE.
DieWith<NullReferenceException>(Unless(1==2), "Foo can't be null.");

// For more use cases, take a look at the test project.
```


### How to build
On UNIX systems.
```
# RELEASE build.
make -s

# DEBUG build.
make dbgbuild
```

On Windows
```
// TODO:
```

### How to run the test suite
On UNIX systems.
```
make test
```

On Windows
```
// TODO:
```

### Don't want to build from sources?
If you don't wanna build the code by yourself you can grab a built copy from the bin folder.


### About the name
> Parca (Atropos in greek) was the oldest of the Three Fates, and was known as the "inflexible" or "inevitable." 
**It was Atropos who chose the mechanism of death and ended the life of mortals by cutting their thread** 
with her "abhorred shears."

Making an analogy with greek mythology, this library decide how to finish the life  of a given execution thread.
