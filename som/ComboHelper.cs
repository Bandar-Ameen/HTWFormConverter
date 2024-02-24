using System;
using System.Collections.Generic;
using System.Text;

namespace ControlSystem
{
    public class ComboHelper<T>
    {
        protected string displayName;
        protected T settingValue;

        public ComboHelper(string paramName, T paramValue)
        {
            displayName = paramName;
            settingValue = paramValue;
        }

        public override string ToString()
        {
            return displayName;
        }

        public string DisplayName { get { return displayName; } set { displayName = value; } }
        public T Value { get { return settingValue; } set { settingValue = value; } }
    }
}
