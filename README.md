# Mutuple
Mutable tuple class library for those times when you need mutable, reference-type tuples

- .NET 4.0 and up
- .NET Standard 1.3 and up

| Package Name | Link |
|--------------|------|
| Mutuple      | [![NuGet Status](http://img.shields.io/nuget/v/Mutuple.svg?style=flat)](https://www.nuget.org/packages/Mutuple/) |

## Usage

Mutuple has the same naming scheme as `System.Tuple` so your `TX`es exist as properties named `ItemX`.

```csharp
var x = new Mutuple<int, string, object>(42, "woop", null);
var n = x.Item1;
var s = x.Item2;
var o = x.Item3;

// The only point of interest in this whole library is that the properties are mutable 🤗
x.Item1 = 709;
x.Item3 = 13.37m;
```

## But why, though?

TLDR; Sometimes things are needed.

I have a rule for myself: any code I write which lends itself to a general purpose means I have/get to put it in a public GitHub repo and NuGet package.

Mutable reference-type tuples seem like a terrible idea to anyone who espouses functional-style programming. After all, tuples are supposed to facilitate the quick passage of small and simple data structures; especially those with no obvious name. The possibily of changing that data while its being passed around increases the complexity of your system.

The reason I created mutuples was to solve a very specific puzzle in one of my projects. I needed to build a LINQ expression at run-time for Entity Framework. EF is very particular about what counts as an acceptable result selector in a group join.

It must...

1. be a `new` expression of a reference type's default constructor
2. have an initializer list which sets the same properties everywhere the type is initialized in the resulting `IQueryable`
3. initialize properties to an instance (no `null`s)

Usually LINQ group joins will just use anonymous types. This is great when the expression is known at compile time. The compiler just whips up a bunch of anonymous types and we're ready to go. But as I stated above, I needed to build a chain of group joins at run-time. The type returned by the result selector doesn't technically need to exist at compile time, but I try to reserve run-time type generation to extreme cases. Cue a generic tuple class. `System.Tuple`'s can't be instantiated with an initializer list (properties must have a visible setter in order to be set in an initializer list). [`System.ValueTuple`](https://github.com/dotnet/corefx/tree/master/src/System.ValueTuple) can, but it's a value type. When you're left high and dry, DIY.

If you're curious, the feature is a "[ToSnapshot](https://github.com/NickStrupat/EntityFramework.VersionedProperties/search?utf8=%E2%9C%93&q=ToSnapshots&type=Code)" method in my [VersionedProperties](https://github.com/NickStrupat/EntityFramework.VersionedProperties/) project. You pass in your `IQueryable<T>` and a `DateTime` and you get back an `ICollection<T>` of the state of your entities at that time in the past.