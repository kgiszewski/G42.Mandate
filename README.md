# G42.Mandate

Syntactic sugar to be able to require something to be true, otherwise throws and exception of your choosing.

This is also known as a guard clause.

## Basic Usage

`Mandate.That<TException>(<bool expression>, "Custom exception message goes in here.");`

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

Mandate.That<InvalidOperationException>(someVar != null, $"{someVar} must be greater than zero!"); //will throw

//more code that will execute
```

# Nuget
https://www.nuget.org/packages/G42.Mandate/
