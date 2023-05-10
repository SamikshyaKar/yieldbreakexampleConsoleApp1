// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

   
        Myclass myclass = new Myclass();
        foreach (char ch in myclass)
        {
            Console.Write(ch + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    

class Myclass
{
    char chrs = 'A';
    public IEnumerator GetEnumerator()
    {
        for (int i = 20; i >= 0; --i)
        {
            if (i == 10)
            {
                yield break;
            }
            yield return (char)((chrs + i));
        }
    }
}