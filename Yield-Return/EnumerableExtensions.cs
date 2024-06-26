using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Yield_Return;

// Класс с методами расширения
public static class EnumerableExtensions
{
    public static void Print<T>(this IEnumerable<T> collection)
    {
        foreach (T item in collection)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    public static int MyCount<T>(this IEnumerable<T> collection)
    {
        int count = 0;
        foreach (T item in collection)
        {
            count++;
        }
        return count;
    }

    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> collection, Func<T, bool> func)
    {
        foreach (T item in collection)
        {
            if (func.Invoke(item))
            {
                yield return item;
            }
        }
    }

    public static T MyFirst<T>(this IEnumerable<T> collection, Func<T, bool> func)
    {
        foreach (T item in collection)
        {
            if (func.Invoke(item))
            {
                return item;
            }
        }

        throw new InvalidOperationException("Sequence contains no matching element.");
    }

    public static bool MyAny<T>(this IEnumerable<T> collection, Func<T, bool> func)
    {
        foreach (T item in collection)
        {
            if (func.Invoke(item))
            {
                return true;
            }
        }
        return false;

    }

    public static bool MyAll<T>(this IEnumerable<T> collection, Func<T, bool> func)
    {
        foreach (T item in collection)
        {
            if (!func.Invoke(item))
            {
                return false;
            }
        }
        return true;
    }
    public static int MyCountOf<T>(this IEnumerable<T> collection, Func<T, bool> func)
    {
        int count = 0;
        foreach (T item in collection) 
        {
            if (func.Invoke(item))
            {
                count++;
            }
        }
        return count;
    }

    public static T MyLast<T>(this IEnumerable<T> collection, Func<T, bool> func)
    {
        T lastItem = default;
        bool isFound = default;
        foreach (T item in collection)
        {
            if (func.Invoke(item))
            {
                lastItem = item;
                isFound = true;
            }
        }
        if (!isFound)
        {
            throw new InvalidOperationException("Sequence contains no matching element.");
        }
        else
        {
            return lastItem;
        }
    }

}