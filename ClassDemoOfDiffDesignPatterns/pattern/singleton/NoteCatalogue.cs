using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.singleton
{
    class NoteCatalogue
    {
        /*
         * Singleton
         */

        // trin 1 konstruktør private
        private NoteCatalogue()
        {
            this.notes = new List<string>()
            {
                "note1", "note2", "and note3"
            };
        }
        
        // trin 2 lav et objekt af os selv
        private static NoteCatalogue _instance = new NoteCatalogue();

        // trin 3 laver factory metode tilat få det ene objekt
        public static NoteCatalogue Instance { get { return _instance; } }


        /*
         * Slut  singleton
         */


        private List<String> notes;

        public List<string> Notes {  
            get { return new List<string>(notes); } 
        }



        public void Add(string item)
        {
            notes.Add(item);
        }

        public void Clear()
        {
            notes.Clear();
        }


        public override string ToString()
        {
            String strNotes = String.Join("\n", notes);
            return $"Notes are :\n{strNotes}";
        }
    }
}
