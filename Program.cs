using System;
using System.Collections.Generic;
using System.Linq;

namespace FlashQuiz
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // QUESTIONS*****************************************************************************************************
            // Chapter 10 QUESTIONS (25)
            Dictionary<string, string> Questions10 = new Dictionary<string, string>()
            {
                {"10.1","What question is this?" },
                {"10.2","What question is this?" },
                {"10.3","What question is this?" },
                {"10.4","What question is this?" },
                {"10.5","What question is this?" },
                {"10.6","What question is this?" },
                {"10.7","What question is this?" },
                {"10.8","What question is this?" },
                {"10.9","What question is this?" },
                {"10.10","What question is this?" },
                {"10.11","What question is this?" },
                {"10.12","What question is this?" },
                {"10.13","What question is this?" },
                {"10.14","What question is this?" },
                {"10.15","What question is this?" },
                {"10.16","What question is this?" },
                {"10.17","What question is this?" },
                {"10.18","What question is this?" },
                {"10.19","What question is this?" },
                {"10.20","What question is this?" },
                {"10.21","What question is this?" },
                {"10.22","What question is this?" },
                {"10.23","What question is this?" },
                {"10.24","What question is this?" },
                {"10.25","What question is this?" },


            };

            // Chapter 11 QUESTIONS (25)
            Dictionary<string, string> Questions11 = new Dictionary<string, string>()
            {
                {"11.1","What question is this?" },
                {"11.2","What question is this?" },
                {"11.3","What question is this?" },
                {"11.4","What question is this?" },
                {"11.5","What question is this?" },
                {"11.6","What question is this?" },
                {"11.7","What question is this?" },
                {"11.8","What question is this?" },
                {"11.9","What question is this?" },
                {"11.10","What question is this?" },
                {"11.11","What question is this?" },
                {"11.12","What question is this?" },
                {"11.13","What question is this?" },
                {"11.14","What question is this?" },
                {"11.15","What question is this?" },
                {"11.16","What question is this?" },
                {"11.17","What question is this?" },
                {"11.18","What question is this?" },
                {"11.19","What question is this?" },
                {"11.20","What question is this?" },
                {"11.21","What question is this?" },
                {"11.22","What question is this?" },
                {"11.23","What question is this?" },
                {"11.24","What question is this?" },
                {"11.25","What question is this?" },

            };

            // Chapter 12 QUESTIONS (25)
            Dictionary<string, string> Questions12 = new Dictionary<string, string>()
            {
                {"12.1","What question is this?" },
                {"12.2","What question is this?" },
                {"12.3","What question is this?" },
                {"12.4","What question is this?" },
                {"12.5","What question is this?" },
                {"12.6","What question is this?" },
                {"12.7","What question is this?" },
                {"12.8","What question is this?" },
                {"12.9","What question is this?" },
                {"12.10","What question is this?" },
                {"12.11","What question is this?" },
                {"12.12","What question is this?" },
                {"12.13","What question is this?" },
                {"12.14","What question is this?" },
                {"12.15","What question is this?" },
                {"12.16","What question is this?" },
                {"12.17","What question is this?" },
                {"12.18","What question is this?" },
                {"12.19","What question is this?" },
                {"12.20","What question is this?" },
                {"12.21","What question is this?" },
                {"12.22","What question is this?" },
                {"12.23","What question is this?" },
                {"12.24","What question is this?" },
                {"12.25","What question is this?" },

            };

            // Chapter 13 QUESTIONS (25)
            Dictionary<string, string> Questions13 = new Dictionary<string, string>()
            {
                {"13.1","What question is this?" },
                {"13.2","What question is this?" },
                {"13.3","What question is this?" },
                {"13.4","What question is this?" },
                {"13.5","What question is this?" },
                {"13.6","What question is this?" },
                {"13.7","What question is this?" },
                {"13.8","What question is this?" },
                {"13.9","What question is this?" },
                {"13.10","What question is this?" },
                {"13.11","What question is this?" },
                {"13.12","What question is this?" },
                {"13.13","What question is this?" },
                {"13.14","What question is this?" },
                {"13.15","What question is this?" },
                {"13.16","What question is this?" },
                {"13.17","What question is this?" },
                {"13.18","What question is this?" },
                {"13.19","What question is this?" },
                {"13.20","What question is this?" },
                {"13.21","What question is this?" },
                {"13.22","What question is this?" },
                {"13.23","What question is this?" },
                {"13.24","What question is this?" },
                {"13.25","What question is this?" },

            };

            // Chapter 16 QUESTIONS (25)
            Dictionary<string, string> Questions16 = new Dictionary<string, string>()
            {
                {"16.1","What question is this?" },
                {"16.2","What question is this?" },
                {"16.3","What question is this?" },
                {"16.4","What question is this?" },
                {"16.5","What question is this?" },
                {"16.6","What question is this?" },
                {"16.7","What question is this?" },
                {"16.8","What question is this?" },
                {"16.9","What question is this?" },
                {"16.10","What question is this?" },
                {"16.11","What question is this?" },
                {"16.12","What question is this?" },
                {"16.13","What question is this?" },
                {"16.14","What question is this?" },
                {"16.15","What question is this?" },
                {"16.16","What question is this?" },
                {"16.17","What question is this?" },
                {"16.18","What question is this?" },
                {"16.19","What question is this?" },
                {"16.20","What question is this?" },
                {"16.21","What question is this?" },
                {"16.22","What question is this?" },
                {"16.23","What question is this?" },
                {"16.24","What question is this?" },
                {"16.25","What question is this?" },

            };

            // Chapter 17 QUESTIONS (25)
            Dictionary<string, string> Questions17 = new Dictionary<string, string>()
            {
                {"17.1","What question is this?" },
                {"17.2","What question is this?" },
                {"17.3","What question is this?" },
                {"17.4","What question is this?" },
                {"17.5","What question is this?" },
                {"17.6","What question is this?" },
                {"17.7","What question is this?" },
                {"17.8","What question is this?" },
                {"17.9","What question is this?" },
                {"17.10","What question is this?" },
                {"17.11","What question is this?" },
                {"17.12","What question is this?" },
                {"17.13","What question is this?" },
                {"17.14","What question is this?" },
                {"17.15","What question is this?" },
                {"17.16","What question is this?" },
                {"17.17","What question is this?" },
                {"17.18","What question is this?" },
                {"17.19","What question is this?" },
                {"17.20","What question is this?" },
                {"17.21","What question is this?" },
                {"17.22","What question is this?" },
                {"17.23","What question is this?" },
                {"17.24","What question is this?" },
                {"17.25","What question is this?" },

            };

            // OPTIONS*******************************************************************************************************
            Dictionary<string, string> Options = new Dictionary<string, string>()
            {
            // Chapter 10 OPTIONS (25)
                {"10.1", "\r\n\ta. 10.1"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.2", "\r\n\ta. 10.1"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.3", "\r\n\ta. 10.1"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.4", "\r\n\ta. 10.1"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.5", "\r\n\ta. 10.5"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.6", "\r\n\ta. 10.1"+
                         "\r\n\tb. 10.6" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.7", "\r\n\ta. 10.1"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.7"+
                         "\r\n\td. 10.4"},
                {"10.8", "\r\n\ta. 10.1"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.8"},
                {"10.9", "\r\n\ta. 10.9"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.10","\r\n\ta. 10.10"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.11","\r\n\ta. 10.11"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.12","\r\n\ta. 10.12"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.13","\r\n\ta. 10.13"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.14","\r\n\ta. 10.14"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.15","\r\n\ta. 10.15"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.16","\r\n\ta. 10.16"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.17","\r\n\ta. 10.17"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.18","\r\n\ta. 10.18"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.19","\r\n\ta. 10.19"+
                         "\r\n\tb. 10.2" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.20","\r\n\ta. 10.1"+
                         "\r\n\tb. 10.20" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.21","\r\n\ta. 10.1"+
                         "\r\n\tb. 10.21" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.22","\r\n\ta. 10.1"+
                         "\r\n\tb. 10.22" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.23","\r\n\ta. 10.1"+
                         "\r\n\tb. 10.23" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.24","\r\n\ta. 10.1"+
                         "\r\n\tb. 10.24" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},
                {"10.25","\r\n\ta. 10.1"+
                         "\r\n\tb. 10.25" +
                         "\r\n\tc. 10.3"+
                         "\r\n\td. 10.4"},

            
            // Chapter 11 OPTIONS (25)
                {"11.1", "\r\n\ta. 11.1"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.2", "\r\n\ta. 11.1"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.3", "\r\n\ta. 11.1"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.4", "\r\n\ta. 11.1"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.5", "\r\n\ta. 11.5"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.6", "\r\n\ta. 11.1"+
                         "\r\n\tb. 11.6" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.7", "\r\n\ta. 11.1"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.7"+
                         "\r\n\td. 11.4"},
                {"11.8", "\r\n\ta. 11.1"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.8"},
                {"11.9", "\r\n\ta. 11.9"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.10","\r\n\ta. 11.10"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.11","\r\n\ta. 11.11"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.12","\r\n\ta. 11.12"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.13","\r\n\ta. 11.13"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.14","\r\n\ta. 11.14"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.15","\r\n\ta. 11.15"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.16","\r\n\ta. 11.16"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.17","\r\n\ta. 11.17"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.18","\r\n\ta. 11.18"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.19","\r\n\ta. 11.19"+
                         "\r\n\tb. 11.2" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.20","\r\n\ta. 11.1"+
                         "\r\n\tb. 11.20" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.21","\r\n\ta. 11.1"+
                         "\r\n\tb. 11.21" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.22","\r\n\ta. 11.1"+
                         "\r\n\tb. 11.22" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.23","\r\n\ta. 11.1"+
                         "\r\n\tb. 11.23" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.24","\r\n\ta. 11.1"+
                         "\r\n\tb. 11.24" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},
                {"11.25","\r\n\ta. 11.1"+
                         "\r\n\tb. 11.25" +
                         "\r\n\tc. 11.3"+
                         "\r\n\td. 11.4"},

                
            // Chapter 12 OPTIONS (25)
                {"12.1", "\r\n\ta. 12.1"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.2", "\r\n\ta. 12.1"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.3", "\r\n\ta. 12.1"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.4", "\r\n\ta. 12.1"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.5", "\r\n\ta. 12.5"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.6", "\r\n\ta. 12.1"+
                         "\r\n\tb. 12.6" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.7", "\r\n\ta. 12.1"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.7"+
                         "\r\n\td. 12.4"},
                {"12.8", "\r\n\ta. 12.1"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.8"},
                {"12.9", "\r\n\ta. 12.9"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.10","\r\n\ta. 12.10"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.11","\r\n\ta. 12.11"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.12","\r\n\ta. 12.12"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.13","\r\n\ta. 12.13"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.14","\r\n\ta. 12.14"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.15","\r\n\ta. 12.15"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.16","\r\n\ta. 12.16"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.17","\r\n\ta. 12.17"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.18","\r\n\ta. 12.18"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.19","\r\n\ta. 12.19"+
                         "\r\n\tb. 12.2" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.20","\r\n\ta. 12.1"+
                         "\r\n\tb. 12.20" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.21","\r\n\ta. 12.1"+
                         "\r\n\tb. 12.21" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.22","\r\n\ta. 12.1"+
                         "\r\n\tb. 12.22" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.23","\r\n\ta. 12.1"+
                         "\r\n\tb. 12.23" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.24","\r\n\ta. 12.1"+
                         "\r\n\tb. 12.24" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},
                {"12.25","\r\n\ta. 12.1"+
                         "\r\n\tb. 12.25" +
                         "\r\n\tc. 12.3"+
                         "\r\n\td. 12.4"},

            
            // Chapter 13 OPTIONS (25)
                {"13.1", "\r\n\ta. 13.1"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.2", "\r\n\ta. 13.1"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.3", "\r\n\ta. 13.1"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.4", "\r\n\ta. 13.1"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.5", "\r\n\ta. 13.5"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.6", "\r\n\ta. 13.1"+
                         "\r\n\tb. 13.6" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.7", "\r\n\ta. 13.1"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.7"+
                         "\r\n\td. 13.4"},
                {"13.8", "\r\n\ta. 13.1"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.8"},
                {"13.9", "\r\n\ta. 13.9"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.10","\r\n\ta. 13.10"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.11","\r\n\ta. 13.11"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.12","\r\n\ta. 13.12"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.13","\r\n\ta. 13.13"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.14","\r\n\ta. 13.14"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.15","\r\n\ta. 13.15"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.16","\r\n\ta. 13.16"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.17","\r\n\ta. 13.17"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.18","\r\n\ta. 13.18"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.19","\r\n\ta. 13.19"+
                         "\r\n\tb. 13.2" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.20","\r\n\ta. 13.1"+
                         "\r\n\tb. 13.20" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.21","\r\n\ta. 13.1"+
                         "\r\n\tb. 13.21" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.22","\r\n\ta. 13.1"+
                         "\r\n\tb. 13.22" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.23","\r\n\ta. 13.1"+
                         "\r\n\tb. 13.23" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.24","\r\n\ta. 13.1"+
                         "\r\n\tb. 13.24" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},
                {"13.25","\r\n\ta. 13.1"+
                         "\r\n\tb. 13.25" +
                         "\r\n\tc. 13.3"+
                         "\r\n\td. 13.4"},


            // Chapter 16 OPTIONS (25)
                {"16.1", "\r\n\ta. 16.1"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.2", "\r\n\ta. 16.1"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.3", "\r\n\ta. 16.1"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.4", "\r\n\ta. 16.1"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.5", "\r\n\ta. 16.5"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.6", "\r\n\ta. 16.1"+
                         "\r\n\tb. 16.6" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.7", "\r\n\ta. 16.1"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.7"+
                         "\r\n\td. 16.4"},
                {"16.8", "\r\n\ta. 16.1"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.8"},
                {"16.9", "\r\n\ta. 16.9"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.10","\r\n\ta. 16.10"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.11","\r\n\ta. 16.11"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.12","\r\n\ta. 16.12"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.13","\r\n\ta. 16.13"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.14","\r\n\ta. 16.14"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.15","\r\n\ta. 16.15"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.16","\r\n\ta. 16.16"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.17","\r\n\ta. 16.17"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.18","\r\n\ta. 16.18"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.19","\r\n\ta. 16.19"+
                         "\r\n\tb. 16.2" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.20","\r\n\ta. 16.1"+
                         "\r\n\tb. 16.20" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.21","\r\n\ta. 16.1"+
                         "\r\n\tb. 16.21" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.22","\r\n\ta. 16.1"+
                         "\r\n\tb. 16.22" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.23","\r\n\ta. 16.1"+
                         "\r\n\tb. 16.23" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.24","\r\n\ta. 16.1"+
                         "\r\n\tb. 16.24" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
                {"16.25","\r\n\ta. 16.1"+
                         "\r\n\tb. 16.25" +
                         "\r\n\tc. 16.3"+
                         "\r\n\td. 16.4"},
            
            // Chapter 17 OPTIONS (25)
                {"17.1", "\r\n\ta. 17.1"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.2", "\r\n\ta. 17.1"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.3", "\r\n\ta. 17.1"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.4", "\r\n\ta. 17.1"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.5", "\r\n\ta. 17.5"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.6", "\r\n\ta. 17.1"+
                         "\r\n\tb. 17.6" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.7", "\r\n\ta. 17.1"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.7"+
                         "\r\n\td. 17.4"},
                {"17.8", "\r\n\ta. 17.1"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.8"},
                {"17.9", "\r\n\ta. 17.9"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.10","\r\n\ta. 17.10"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.11","\r\n\ta. 17.11"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.12","\r\n\ta. 17.12"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.13","\r\n\ta. 17.13"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.14","\r\n\ta. 17.14"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.15","\r\n\ta. 17.15"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.16","\r\n\ta. 17.16"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.17","\r\n\ta. 17.17"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.18","\r\n\ta. 17.18"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.19","\r\n\ta. 17.19"+
                         "\r\n\tb. 17.2" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.20","\r\n\ta. 17.1"+
                         "\r\n\tb. 17.20" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.21","\r\n\ta. 17.1"+
                         "\r\n\tb. 17.21" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.22","\r\n\ta. 17.1"+
                         "\r\n\tb. 17.22" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.23","\r\n\ta. 17.1"+
                         "\r\n\tb. 17.23" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.24","\r\n\ta. 17.1"+
                         "\r\n\tb. 17.24" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                {"17.25","\r\n\ta. 17.1"+
                         "\r\n\tb. 17.25" +
                         "\r\n\tc. 17.3"+
                         "\r\n\td. 17.4"},
                
            };

            // ANSWERS*******************************************************************************************************
            Dictionary<string, string> Answers = new Dictionary<string, string>()
            {
            // Chapter 10 ANSWERS (25)
                {"10.1","A" },
                {"10.2","B" },
                {"10.3","C" },
                {"10.4","D" },
                {"10.5","A" },
                {"10.6","B" },
                {"10.7","C" },
                {"10.8","D" },
                {"10.9","A" },
                {"10.10","A" },
                {"10.11","A" },
                {"10.12","A" },
                {"10.13","A" },
                {"10.14","A" },
                {"10.15","A" },
                {"10.16","A" },
                {"10.17","A" },
                {"10.18","A" },
                {"10.19","A" },
                {"10.20","B" },
                {"10.21","B" },
                {"10.22","B" },
                {"10.23","B" },
                {"10.24","B" },
                {"10.25","B" },
                
            
            // Chapter 11 ANSWERS (25)
                {"11.1","A" },
                {"11.2","B" },
                {"11.3","C" },
                {"11.4","D" },
                {"11.5","A" },
                {"11.6","B" },
                {"11.7","C" },
                {"11.8","D" },
                {"11.9","A" },
                {"11.10","A" },
                {"11.11","A" },
                {"11.12","A" },
                {"11.13","A" },
                {"11.14","A" },
                {"11.15","A" },
                {"11.16","A" },
                {"11.17","A" },
                {"11.18","A" },
                {"11.19","A" },
                {"11.20","B" },
                {"11.21","B" },
                {"11.22","B" },
                {"11.23","B" },
                {"11.24","B" },
                {"11.25","B" },
                
            
            // Chapter 12 ANSWERS (25)
                {"12.1","A" },
                {"12.2","B" },
                {"12.3","C" },
                {"12.4","D" },
                {"12.5","A" },
                {"12.6","B" },
                {"12.7","C" },
                {"12.8","D" },
                {"12.9","A" },
                {"12.10","A" },
                {"12.11","A" },
                {"12.12","A" },
                {"12.13","A" },
                {"12.14","A" },
                {"12.15","A" },
                {"12.16","A" },
                {"12.17","A" },
                {"12.18","A" },
                {"12.19","A" },
                {"12.20","C" },
                {"12.21","B" },
                {"12.22","B" },
                {"12.23","B" },
                {"12.24","B" },
                {"12.25","B" },
                
            
            // Chapter 13 ANSWERS (25)
                {"13.1","A" },
                {"13.2","B" },
                {"13.3","C" },
                {"13.4","D" },
                {"13.5","A" },
                {"13.6","B" },
                {"13.7","C" },
                {"13.8","D" },
                {"13.9","A" },
                {"13.10","A" },
                {"13.11","A" },
                {"13.12","A" },
                {"13.13","A" },
                {"13.14","A" },
                {"13.15","A" },
                {"13.16","A" },
                {"13.17","A" },
                {"13.18","A" },
                {"13.19","A" },
                {"13.20","B },
                {"13.21","B" },
                {"13.22","B" },
                {"13.23","B" },
                {"13.24","B" },
                {"13.25","B" },
                

            // Chapter 16 ANSWERS (25)
                {"16.1","A" },
                {"16.2","B" },
                {"16.3","C" },
                {"16.4","D" },
                {"16.5","A" },
                {"16.6","B" },
                {"16.7","C" },
                {"16.8","D" },
                {"16.9","A" },
                {"16.10","A" },
                {"16.11","A" },
                {"16.12","A" },
                {"16.13","A" },
                {"16.14","A" },
                {"16.15","A" },
                {"16.16","A" },
                {"16.17","A" },
                {"16.18","A" },
                {"16.19","A" },
                {"16.20","B" },
                {"16.21","B" },
                {"16.22","B" },
                {"16.23","B" },
                {"16.24","B" },
                {"16.25","B" },
                
            
            // Chapter 17 ANSWERS (25)
                {"17.1","A" },
                {"17.2","B" },
                {"17.3","C" },
                {"17.4","D" },
                {"17.5","A" },
                {"17.6","B" },
                {"17.7","C" },
                {"17.8","D" },
                {"17.9","A" },
                {"17.10","A" },
                {"17.11","A" },
                {"17.12","A" },
                {"17.13","A" },
                {"17.14","A" },
                {"17.15","A" },
                {"17.16","A" },
                {"17.17","A" },
                {"17.18","A" },
                {"17.19","A" },
                {"17.20","B" },
                {"17.21","B" },
                {"17.22","B" },
                {"17.23","B" },
                {"17.24","B" },
                {"17.25","B" },

            };

            // Sets looping condition for taking exam repeatedly
            bool testMe = true;
            while (testMe)
            {
                Console.Clear();

                // Creates 2-dimensional exam array for exam questions where
                // each row designates the chapter
                string[,] examQuestions = new string[6, 10];

                // Creates lists of dictionaru keys for each chapter
                List<string> chapter10 = new List<string>(Questions10.Keys);
                List<string> chapter11 = new List<string>(Questions11.Keys);
                List<string> chapter12 = new List<string>(Questions12.Keys);
                List<string> chapter13 = new List<string>(Questions13.Keys);
                List<string> chapter16 = new List<string>(Questions16.Keys);
                List<string> chapter17 = new List<string>(Questions17.Keys);

                // Creates a 2-dimensional list for the dictionary keys of each chapter
                // This makes it easier to controll the Shuffle method
                List<List<string>> questions = new List<List<string>>()
                {
                    chapter10,
                    chapter11,
                    chapter12,
                    chapter13,
                    chapter16,
                    chapter17
                };

                // Creates a list of Dictionaries containing the questions for each chapter
                // This makes it easier to pull the actual questions
                List<Dictionary<string, string>> questionBank = new List<Dictionary<string, string>>()
                {
                    Questions10,
                    Questions11,
                    Questions12,
                    Questions13,
                    Questions16,
                    Questions17
                };
                // populates the examQuestions 2D array with 50 questions.
                MakeQuiz(examQuestions, questions); // shuffle each new exam

                // Prints each question in the 2D array, its possible answers, 
                // and then accepts input from the user as an answer and checks
                // the answer against the correct answers.
                int examNum = 1;
                int correct = 0;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine(examNum + ".)");
                        Console.Write(examQuestions[i, j] + ": ");
                        Console.WriteLine(questionBank[i][examQuestions[i, j]]);
                        Console.WriteLine(Options[examQuestions[i, j]]);
                        string input = Console.ReadLine();

                        if (input.ToUpper() == Answers[examQuestions[i, j]])
                        {
                            Console.WriteLine("Good job!\n\n");
                            correct++;
                        }
                        else
                        {
                            Console.WriteLine($"Incorrect!\n The correct answer is: {Answers[examQuestions[i, j]]}\n\n");
                        }
                        examNum++;
                    }
                }

                // Asks the user if they want to take the exam again.
                // It continues to ask until a valid answer is porvided
                string again = "";
                while (again != "y" && again != "n")
                {
                    Console.WriteLine($"Good job! You scored {Math.Round(correct / 0.6, 2)}%");
                    Console.WriteLine("Would you like to try again? (y/n)");
                    again = Console.ReadLine();
                    if (again == "y")
                    {
                        testMe = true;
                    }
                    else if (again == "n")
                    {
                        testMe = false;
                    }
                    else
                    {
                        Console.WriteLine("Please only enter 'y' for yes, or 'n' for no!");
                    }
                }
            }
        }

        // function: Populates the examQuestion array with 10 random question keys from each
        //           of the question dicitonaries for each chapter.
        // preconditions: A 2D array with 5 rows must exist and a nested list with rows as chapters
        //                and column values as the string values of every key in the Questions[10,11,12,16,17] dictionaries
        // input: empty 2D array of the exam, nested list of dictionary keys. 
        // output: 2D exam array randomly populated with 50 non-duplicated questions
        // postconditions: The user can iterate through 10 unique questions from each chapter.
        private static void MakeQuiz(string[,] examQuestions, List<List<string>> chapters)
        {
            Random rdm = new Random();
            // Creates a local nested list to track available questions for each chapter
            List<List<string>> unusedQuestions = new List<List<string>>
            {
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>()
            };
            for (int i = 0; i < chapters.Count; i++)
            {
                foreach (var question in chapters[i])
                {
                    unusedQuestions[i].Add(question);
                }

            }
            for (var row = 0; row < examQuestions.GetLength(0); ++row)
            {
                examQuestions = Shuffle(unusedQuestions[row], examQuestions, row);
            }
        }

        // function: Shuffles the lists of dictionary keys for each chapter's questions.
        //           This method is part of MakeQuiz, but I seperated to show more clearly
        //           how the shuffle function works to eliminate duplicate results.
        // preconditions: A 2D array with 5 rows must exist and a nested list with rows as chapters
        //                and column values as the string values of every key in the Questions[10,11,12,16,17] dictionaries
        // input: empty 2D array of the exam, nested list of dictionary keys. 
        // output: 2D exam array randomly populated with 50 non-duplicated questions
        // postconditions: The user can iterate through 10 unique questions from each chapter.
        public static string[,] Shuffle(List<string> unusedQuestions, string[,] examQuestions, int row)
        {
            Random rdm = new Random();
            int max = unusedQuestions.Count();
            List<string> temp = new List<string>();
            while (temp.Count < max)
            {
                int random = rdm.Next(0, max);
                temp.Add(unusedQuestions[random]);
                unusedQuestions.RemoveAt(random);
                max--;
            }
            for (int c = 0; c < 10; c++)
            {
                examQuestions[row, c] = temp[c];
            }
            return examQuestions;
        }
    }
}


