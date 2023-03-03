﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.strategy
{
    class ContextClassMoreCSharpLike
    {
        private ICollection<String> _collection;

        // C# statregy benytter delegate
        private Func<String, String> _strategyMethod;

        public Func<string, string> StrategyMethod
        {
            private get => _strategyMethod;
            set => _strategyMethod = value;
        }

        public ContextClassMoreCSharpLike()
        {
            _collection = new List<string>();
        }


        public void InsertStrategyMethod(ICollection<String> strings)
        {
            foreach (string s in strings)
            {
                // the strategy method use a delegate method
                // todo check if not null
                String str = _strategyMethod(s);
                _collection.Add(str);
            }
        }


        public override string ToString()
        {
            return $"Info: [{String.Join(", ", _collection)}]";
        }
    }
}
