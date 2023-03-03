﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.template
{
    abstract class AbstractTemplateClass
    {
        private ICollection<String> _info;

        protected AbstractTemplateClass()
        {
            _info = new List<string>();
        }


        public void InsertTemplateMethod(ICollection<String> strings)
        {
            foreach (string s in strings)
            {
                //
                // Call - the template method use an abstract method to be overriden in subclass
                //
                String str = MakeString(s);
                _info.Add(str);
            }
        }

        /*
         *
         *  Here is the abstract method to be overriden 
         *
         */
        protected abstract string MakeString(string s);


        public override string ToString()
        {
            return $"Info: [{String.Join(", ", _info)}]";
        }
    }
}
