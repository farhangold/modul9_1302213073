﻿namespace MOD9_1302213073
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string Description { get; set; }

        public Movie(string title, string director, List<string> starts, string description)
        {
            Title = title;
            Director = director;
            Stars = starts;
            Description = description;
        }
    }
}
