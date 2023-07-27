public class program
{
    public static int[] FilterArray(object[] arr)
    {
        int a = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] is int)
            {
                a++;
            }
        }

        int[] filteredArr = new int[a];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] is int)
            {
                filteredArr[index] = (int)arr[i];
                index++;
            }
        }

        return filteredArr;
    }

    public static void Main()
    {
        object[] arr1 = { 1, 2, "a", 3, "b" };
        int[] result1 = FilterArray(arr1);
        Console.WriteLine(string.Join(", ", result1));

        object[] arr2 = { 1, "a", "b", 0, 9, "c", 15 };
        int[] result2 = FilterArray(arr2);
        Console.WriteLine(string.Join(", ", result2));

        object[] arr3 = { 1, 2, "aasf", "1", "123", 123 };
        int[] result3 = FilterArray(arr3);
        Console.WriteLine(string.Join(", ", result3));
    }
}
