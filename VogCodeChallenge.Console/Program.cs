namespace VogCodeChallenge.Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class QuestionClass
    {
        public static readonly List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John"
        };

        public static void Fetch(List<string> list)
        {
            if (list.Count > 0)
            {
                var name = list.First();
                Console.WriteLine(name);
                list.Remove(name);
                Fetch(list);
            }
        }

        public static void Main(string[] args)
        {
            Fetch(NamesList);
            Console.WriteLine();
        }
    }
}
