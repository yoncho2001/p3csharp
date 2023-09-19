using System;
using System.Linq;
using validate;

static class Program
{
    static void Main()
    {
        /*Person person1 = new Person();
        Console.WriteLine(person1.ToString());

        Person person2 = new Person("Pesho", 30);
        Console.WriteLine(person2.ToString());

        Person person3 = new Person("Hasancho");
        Console.WriteLine(person3.ToString());

        person3.Grow();
        Console.WriteLine(person2.ToString());

        try
        {
            Person person4 = new Person("Charlie", -10);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            Person person5 = new Person("", 30);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }*/

        /*BitArray64 bits = new BitArray64();
        bits[0] = true;
        bits[60] = true;

        foreach (int bit in bits)
        {
            Console.Write(bit);
        }

        Console.WriteLine();

        BitArray64 bits2 = new BitArray64();
        bits2[0] = true;
        bits2[63] = false;

        Console.WriteLine(bits == bits2);
        Console.WriteLine(bits != bits2); */

        BinaryTree tree = new BinaryTree();
        tree.Add(6);
        tree.Add(3);
        tree.Add(7);
        tree.Add(5);
        tree.Add(4);
        tree.Add(8);
        tree.Add(9);
        tree.Add(1);
        
        Console.WriteLine(tree.Search(2));  
        Console.WriteLine(tree.Search(4));  
        tree.Delete(3);
        
        BinaryTree tree2 = (BinaryTree)tree.Clone();
        Console.WriteLine(tree.ToString());
        Console.WriteLine(tree2.ToString());
        Console.WriteLine(tree == tree2);
    }
}