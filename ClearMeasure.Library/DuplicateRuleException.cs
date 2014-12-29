using System;

namespace ClearMeasure.Library
{
    public class DuplicateRuleException : ArgumentException
    {
        public DuplicateRuleException(int duplicateValue)
            : base("A rule for value " + duplicateValue.ToString() + " was already defined.") 
        { }
    }
}
