using System;
using validate;

namespace Point
{
    public class Path
    {
        private List<Point3D> points;

        public Path()
        {
            points = new List<Point3D>();
        }

        public void addPoints(Point3D newPoint)
        {
            points.Add(newPoint);
        }

        public void addPoints(double x, double y, double z)
        {
            points.Add(new Point3D(x, y, z));
        }

        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < points.Count; i++)
            {
                output += points[i].ToString() + "\n";
            }

            return output;
        }
    }

    static class PathStorage
    {
        public static void savePaths(string path, List<string> paths)
        {
            try
            {
                Validate.FileExist(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string output = "";

            for (int i = 0; i < paths.Count; i++)
            {
                output += paths[i] + "\n";
            }

            File.WriteAllText(path, output);
        }

        public static List<string> loadPaths(string path)
        {
            List<string> paths = new List<string>();

            try
            {
                Validate.FileExist(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string[] readText = File.ReadAllLines(path);

            for (int i = 0; i < readText.Length; i++)
            {
                paths.Add(readText[i]);
            }
            return paths;
        }
    }
}