namespace task4;

public static class Arrayhelper
{
    public static void PrintReverse<T>(this T[] array)
    {
        Array.Reverse(array);
        foreach (T item in array)
        {
            Console.WriteLine(item);
        }
    } 
    
    public static void GetFirstElement<T>(this T[] array){
        T element = array[0];
        Console.WriteLine(element);
    }
    
    public static void GetLastElement<T>(this T[] array){
        T element = array[array.Length - 1];
        Console.WriteLine(element);
    }

    public static bool ContainsElement<T>(this T[] array, T search)
    {
        foreach (var item in array)
        {
            if (item.Equals(search))
            {
                return true;
            }
            
        }
        return false;
    }
    
    public static int CountElements<T>(this T[] array)
    {
        int count = 0;
        
        foreach (T item in array)
        {
            Console.WriteLine(count++);
        }
        
        return count;
    }
    
    public static int FindIndex<T>(this T[] array, T item)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(item))
            {
                return i;
            }
        }
        
        return -1;
    }
}