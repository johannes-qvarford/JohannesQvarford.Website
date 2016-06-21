namespace JohannesQvarford.Website.Models
{
    using System.Collections.Generic;

    public class ProjectUtility
    {
        private static readonly string[] projects =
            {
                "Case-Based Reasoning",
                "Winter Dreams",
                "Lunch Lady Simulator",
                "Tiny Tricky Tiles"
            };

        public static IReadOnlyCollection<string> Projects => projects;
    }
}