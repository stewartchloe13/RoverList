﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public class Program
    {

        public static void Main(String[] args)
        {
            List<string> genreList = new List<string>()
                               {
                                   "horror",   "comedy",   "romance",
                                   "drama",    "thriller", "family",
                                   "war",      "sci-fi",   "history",
                                   "action",   "crime",    "adventure",
                                   "mystery",  "animation",    "sports",
                                   "documentary"
                               };


            RoverList list = new RoverList();
            foreach (String s in genreList)
            {
                list.Add(s);
            }
            Console.WriteLine(list.Count);
            list.ListNodes();

            // TODO:  Print out the list

            // TODO:  Remove every 3rd word
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list


        }
    }
}
