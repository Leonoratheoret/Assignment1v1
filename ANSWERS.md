Compare the following two methods:

```csharp
int GreaterCount<T, U>(IEnumerable<T> items, T x)
where T : IComparable<T>

int GreaterCount<T, U>(IEnumerable<T> items, T x)
where T : U
where U : IComparable<U>
```

Explanation: In the first method the type T must implement IComparable.
In the second method T must be of type U and therefore both must implement iComparable.