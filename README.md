# Yield_Return

## Overview

The `Yield_Return` project is a C# library that extends the functionality of `IEnumerable<T>` with custom extension methods. This project demonstrates how to create and use these methods, including implementations of common LINQ operations such as `Where`, `First`, `Any`, `All`, `Count`, and others using the `yield return` statement for deferred execution.

## Features

- **Print**: Prints the elements of a collection to the console.
- **MyCount**: Returns the number of elements in a collection.
- **MyWhere**: Filters elements of a collection based on a predicate.
- **MyFirst**: Returns the first element in a collection that satisfies a specified condition.
- **MyAny**: Checks if any element in a collection satisfies a specified condition.
- **MyAll**: Checks if all elements in a collection satisfy a specified condition.
- **MyCountOf**: Returns the number of elements in a collection that satisfy a specified condition.
- **MyLast**: Returns the last element in a collection that satisfies a specified condition.

## Getting Started

### Prerequisites

- .NET SDK

### Installation

Clone the repository:

```bash
git clone https://github.com/yourusername/Yield_Return.git
cd Yield_Return
```

### Usage

Create a new C# project or open an existing one. Add a reference to the `Yield_Return` library. 

Here is an example demonstrating how to use the custom extension methods:

```csharp
using System;
using System.Collections.Generic;
using Yield_Return;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "adsad", "sdasdsa", "qqqqe" };
            Console.WriteLine(words.MyCount());

            Console.WriteLine("----------------");

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int num in nums.MyWhere(i => i % 2 == 0))
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("----------------");

            Console.WriteLine(nums.MyFirst(i => i % 2 == 0));

            Console.WriteLine("----------------");

            Console.WriteLine(nums.MyCountOf(i => i % 2 == 0));

            Console.WriteLine("----------------");

            Console.WriteLine(nums.MyLast(i => i % 2 == 0));
        }
    }
}
```

### Methods

#### `Print<T>(this IEnumerable<T> collection)`

Prints the elements of the collection to the console.

```csharp
public static void Print<T>(this IEnumerable<T> collection)
```

#### `MyCount<T>(this IEnumerable<T> collection)`

Returns the number of elements in the collection.

```csharp
public static int MyCount<T>(this IEnumerable<T> collection)
```

#### `MyWhere<T>(this IEnumerable<T> collection, Func<T, bool> func)`

Filters elements of the collection based on a predicate.

```csharp
public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> collection, Func<T, bool> func)
```

#### `MyFirst<T>(this IEnumerable<T> collection, Func<T, bool> func)`

Returns the first element in the collection that satisfies a specified condition.

```csharp
public static T MyFirst<T>(this IEnumerable<T> collection, Func<T, bool> func)
```

#### `MyAny<T>(this IEnumerable<T> collection, Func<T, bool> func)`

Checks if any element in the collection satisfies a specified condition.

```csharp
public static bool MyAny<T>(this IEnumerable<T> collection, Func<T, bool> func)
```

#### `MyAll<T>(this IEnumerable<T> collection, Func<T, bool> func)`

Checks if all elements in the collection satisfy a specified condition.

```csharp
public static bool MyAll<T>(this IEnumerable<T> collection, Func<T, bool> func)
```

#### `MyCountOf<T>(this IEnumerable<T> collection, Func<T, bool> func)`

Returns the number of elements in the collection that satisfy a specified condition.

```csharp
public static int MyCountOf<T>(this IEnumerable<T> collection, Func<T, bool> func)
```

#### `MyLast<T>(this IEnumerable<T> collection, Func<T, bool> func)`

Returns the last element in the collection that satisfies a specified condition.

```csharp
public static T MyLast<T>(this IEnumerable<T> collection, Func<T, bool> func)
```

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
