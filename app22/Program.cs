using System;
using System.Reflection;
using Point;
using validate;

static class Program
{
    static void Main()
    {
        Assembly thisAssem = typeof(Program).Assembly;
        AssemblyName thisAssemName = thisAssem.GetName();
        Version ver = thisAssemName.Version;

        Console.WriteLine("This is version {0} of {1}.", ver, thisAssemName.Name);

        /*Point3D a = new Point3D(4, 6, 7);
        Point3D b = new Point3D(1, 2, -5);

        Console.WriteLine(Distance.CalculateDistance(a, b));*/

        /*try
         {
             string path = Validate.CanString();
             List<string> load = PathStorage.loadPaths(path);
             PathStorage.savePaths(@"C:\programs\C#\app22\test4.txt", load);
         }
         catch (Exception e)
         {
             Console.WriteLine(e.Message);
         }*/

        /*try
        {
            GenericList<int> generic = new GenericList<int>();
            generic.AddElement(1);
            generic.AddElement(2);
            generic.AddElement(3);
            generic.AddElement(4);
            generic.AddElement(5);
            generic.DeleteByIndex(2);
            generic.InsertIn(2, 8);
            Console.WriteLine(generic.Max());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }*/

        try
        {
            Matrix<int> matrix1 = new Matrix<int>(4, 4, true);
            Matrix<int> matrix2 = new Matrix<int>(4, 4, true);

            string output = (matrix1 + matrix2).ToString() + "\n";
            output += (matrix1 - matrix2).ToString() + "\n";
            output += (matrix1 * matrix2).ToString() + "\n";

            Console.WriteLine(output);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
