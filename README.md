# G42.Mandate

Syntactic sugar to be able to require something to be true, otherwise throws and exception of your choosing.

This is also known as a guard clause.

## Basic Usage

```
Mandate.That<TException>(<bool expression>, "Optional Custom exception message goes in here.");
Mandate.IsNotNull<TException>(object, "Optional Custom exception message goes in here.");
```

```
var someVar = -1;

Mandate.That<InvalidOperationException>(someVar > 0, $"{someVar} must be greater than zero!"); //throws an InvalidOperationException

//we'll never get here
```

```
var someVar = 1;

Mandate.That<InvalidOperationException>(someVar > 0, $"{someVar} must be greater than zero!"); //will not throw

//more code that will execute
```

```
decimal? someVar = null;

Mandate.That<InvalidOperationException>(someVar != null, $"{someVar} must not be null!"); //will throw

//we won't get here
```

```
decimal? someVar = null;

Mandate.IsNotNull<InvalidOperationException>(someVar, $"{someVar} was null!"); //will throw

//we won't get here
```

# Nuget
https://www.nuget.org/packages/G42.Mandate/
