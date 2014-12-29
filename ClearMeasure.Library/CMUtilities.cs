using System;
using System.Collections.Generic;
using System.Text;

namespace ClearMeasure.Library
{
    public class CMUtilities
    {
        public static readonly KeyValuePair<int, string>[] DefaultRules = new KeyValuePair<int, string>[]
        {
            new KeyValuePair<int, string>(3, "fizz"),
            new KeyValuePair<int, string>(5, "buzz")
        };

        private readonly IDictionary<int, string> _rules = null;

        public CMUtilities(bool includeDefaults = true, Dictionary<int, string> rules = null)
        {
            _rules = new Dictionary<int, string>();
            
            if (includeDefaults)
            {
                foreach (var rule in CMUtilities.DefaultRules)
                {
                    _rules.Add(rule);
                }
            }

            if (rules != null)
            {
                foreach (var rule in rules)
                {
                    if (_rules.ContainsKey(rule.Key))
                    {
                        throw new DuplicateRuleException(rule.Key);
                    }

                    _rules.Add(rule);
                }
            }
        }

        public string GetOutput(int value)
        {
            string output = null;

            foreach (var rule in _rules)
            {
                if ((value % rule.Key) == 0)
                {
                    output += rule.Value;
                }
            }

            return (output == null)
                ? value.ToString()
                : output;
        }
    }    
}
