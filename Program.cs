using System.Collections;
using System.Runtime.CompilerServices;

#region Task
// 2a & 2b
ArrayList list = ["apple"
                , "banana"
                , "cherry"
                , "Wifi pinapplpe"];

Console.WriteLine("\n_______________________\n");
// 2c
foreach (string item2 in list)
{
    Console.WriteLine(item2);
}

Console.WriteLine("\n_______________________\n");
// 3a
list.Insert(2, "orange");

Console.WriteLine("\n_______________________\n");
// 3b
list.Remove(0);

Console.WriteLine("\n_______________________\n");
// 3c
string fruit = "banana";
if (list.Contains(fruit))
{
    Console.WriteLine($"Yes, it contains banana at index {list.IndexOf(fruit)}");
} else Console.WriteLine("No, it does not contain banana");

Console.WriteLine("\n_______________________\n");
// 3d
Console.Write("Enter elemet to find its index: ");
string element = Console.ReadLine();
if (list.Contains(element.ToLower()))
{
    Console.WriteLine($"Element {element} is at index {list.IndexOf(element)}");
}
else Console.WriteLine($"Element {element} not found");

Console.WriteLine("\n_______________________\n");
// 3e
Console.WriteLine(list.Count);

Console.WriteLine("\n_______________________\n");
// 3Bonus
ArrayList filter(ArrayList item, int threshold)
{
    for (int i = 0; i < item.Count; i++)
    {
        if ((int)item[i] < threshold)
        {
            item.RemoveAt(i);
            i++;
        }
    }
    return item;
}

ArrayList item = [23, 9, 7, 4, 1];
Console.Write("\nEnter threshold: ");
int threshold = Convert.ToInt32(Console.ReadLine());

ArrayList filtered = filter(item, threshold);

foreach (int i in filtered)
{
    Console.WriteLine(i);
}
#endregion