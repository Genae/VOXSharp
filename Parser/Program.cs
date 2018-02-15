using System;

namespace Parser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var reader = new Reader();
            reader.ReadFile(@"C:\Users\Stefan Stark\Desktop\Wine\stage1.vox");
            Console.ReadLine();
        }
    }
}
