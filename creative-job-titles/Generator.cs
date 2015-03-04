/* This program is free software. It comes without any warranty, to
 * the extent permitted by applicable law. You can redistribute it
 * and/or modify it under the terms of the Do What The Fuck You Want
 * To Public License, Version 2, as published by Sam Hocevar. See
 * http://www.wtfpl.net/ for more details. */

using System;

namespace creative_job_titles
{
    /// <summary>
    /// class that provides a method to generate job titles
    /// </summary>
    class Generator
    {
        /// <summary>
        /// available first parts of the job titles
        /// </summary>
        private static string[] first = { "Acting", 
                                          "Central",
                                          "Corporate",
                                          "District",
                                          "Dynamic",
                                          "Executive",
                                          "External",
                                          "First",
                                          "Global",
                                          "Homeless",
                                          "Internal",
                                          "International",
                                          "Junior",
                                          "Lead",
                                          "National",
                                          "Primary",
                                          "Principal",
                                          "Second",
                                          "Senior",
                                          "Team",
                                          "Useless",
                                          "Vice"
                                        };

        
        /// <summary>
        /// array of available second parts for job titles
        /// </summary>
        private static string[] second = { "Accountant for",
                                           "Administrator of",
                                           "Agent of",
                                           "Architect of",
                                           "Associate of",
                                           "Chief of",
                                           "Clerk for",
                                           "Consultant for",
                                           "Deputy for", 
                                           "Designer of",
                                           "Developer of",
                                           "Director of", 
                                           "Engineer for",
                                           "Head of",
                                           "Jerk of",
                                           "Manager of",
                                           "Officer for",
                                           "Planner of",
                                           "Supervisor of",
                                           "Trainee for"
                                         };

        
        /// <summary>
        /// available areas of expertise in job titles
        /// </summary>
        private static string[] areas = { "Big Data",
                                          "Bullcrap Controlling",
                                          "Coffee Benchmarking",
                                          "Coffee Concepts",
                                          "Content Synergies",
                                          "Creative Recruting",
                                          "Creative Solutions",
                                          "Data Warehousing",
                                          "Export Resources",
                                          "Financial Things",
                                          "Hypnotic Operations",
                                          "Information Branding",
                                          "Inhouse Detonation",
                                          "Inhouse Operations",
                                          "Intergalactic Jobs",
                                          "Mindblowing Stuff",
                                          "NextGen Innovations",
                                          "Office Tactics",
                                          "Playing Solitaire",
                                          "Project Markets",
                                          "Project Resources",
                                          "Real-Time Drinking",
                                          "Sales Solutions",
                                          "Sales Technologies",
                                          "Sexy Development",
                                          "Sexy Networking",
                                          "Some Creative Stuff",
                                          "Viral Enterprises",
                                          "Virtual Management",
                                          "Visionary Networking",
                                          "Web Relationships"
                                        };
        
        
        /// <summary>
        /// generates a random job title from the pool
        /// </summary>
        /// <returns>job title</returns>
        public static string Generate()
        {
            System.Random rand = new Random();
            return first[rand.Next(first.Length)] + " " + second[rand.Next(second.Length)] + " " + areas[rand.Next(areas.Length)];
        }
    } //class
} //namespace
