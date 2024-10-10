﻿using System.Text.RegularExpressions;


namespace ASIptvServer.Naming
{
    public class NamingRegex
    {
        public NamingRegex() { }

        public static string YearString = @"[-\s()]*\d{4}[-\s()]*";
        public static Regex YearRegex = new Regex(@"\d{4}$");
        public static string RemoveS = @"S\d{2} E\d{2}";
        public static Regex Serie = new Regex(@"S\d{2} E\d{2}");

    }
}
