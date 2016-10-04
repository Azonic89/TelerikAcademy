using System;
using System.Diagnostics;

public class AssertionsHomework
{
    public static void Main()
    {
        var arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); 
        SelectionSort(new int[1]); 

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }

    public static void SelectionSort<T>(T[] arrayToSort) where T : IComparable<T>
    {
        Debug.Assert(arrayToSort != null, "You Cant Sort an Array will null value");

        for (var index = 0; index < arrayToSort.Length - 1; index++)
        {
            var minElementIndex = FindMinElementIndex(arrayToSort, index, arrayToSort.Length - 1);
            Swap(ref arrayToSort[index], ref arrayToSort[minElementIndex]);
        }
    }
  
    public static int BinarySearch<T>(T[] collectionToSort, T value) where T : IComparable<T>
    {
        Debug.Assert(collectionToSort != null, "Parameter is null!!!");
        Debug.Assert(value == null, "value is null!!!");

        var index = BinarySearch(collectionToSort, value, 0, collectionToSort.Length - 1);

        Debug.Assert(index < collectionToSort.Length, "index is larger than the array size!!!");

        return index;
    }

    private static int FindMinElementIndex<T>(T[] elements, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(elements != null, "The passed parameters are null!!!");
        Debug.Assert(startIndex <= endIndex, "startIndex cannot be larger than endIndex!");
        Debug.Assert(endIndex == elements.Length - 1, "endIndex is not the last element in the array!!!");

        var minElementIndex = startIndex;
        for (var i = startIndex + 1; i <= endIndex; i++)
        {
            if (elements[i].CompareTo(elements[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert(0 <= minElementIndex, "minElementIndex cannot be less than a zero!!!");
        Debug.Assert(minElementIndex <= endIndex, "minElementIndex cannot be larger than the array size!!!");

        return minElementIndex;
    }

    private static void Swap<T>(ref T firstItem, ref T secondItem)
    {
        Debug.Assert(firstItem != null, "firstItem cannot be null!!!");
        Debug.Assert(secondItem != null, "secondItem cannot be null!!!");

        var oldX = firstItem;
        firstItem = secondItem;
        secondItem = oldX;
    }

    private static int BinarySearch<T>(T[] collectionToSort, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        while (startIndex <= endIndex)
        {
            Debug.Assert(startIndex >= 0, "startIndex is less than a zero!!!");
            Debug.Assert(endIndex < collectionToSort.Length, "endIndex is larger than the array size!!!");

            var midIndex = (startIndex + endIndex) / 2;
            if (collectionToSort[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (collectionToSort[midIndex].CompareTo(value) < 0)
            {
                startIndex = midIndex + 1;
            }
            else 
            {
                endIndex = midIndex - 1;
            }
        }

        return -1;
    }
}
