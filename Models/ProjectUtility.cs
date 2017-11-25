namespace JohannesQvarford.Website.Models
{
    using System.Collections.Generic;

    public class ProjectUtility
    {
        private static readonly string[] projects =
            {
                "Fam",
                "Tiny Tricky Tiles",
                "Case-Based Reasoning",
                "Lunch Lady Simulator",
                "Winter Dreams",
            };

        public static IReadOnlyCollection<string> Projects => projects;
    }
}