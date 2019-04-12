using System.Collections.Generic;

namespace Demo.Vs2019Lunch
{
    public class DataDemo : IDataDemo
    {
        public List<string> Text { get; set; } = new List<string> { "Text 1", "Text 3", "Text 3", "Text 5", "Text 123", "Text 112321", "Text 423421", "Text 2342341", "Text 1", "Text 1", "Text 1", "Text 1", "Text 1", "Text 1", "Text 1", "Text 1", "Text 1", "Text 1" };
        private const string DefaultValue = "Default";
        public  int Key;
        public string Value;
        public OtherDataDemo Data { get; set; }
        public DataDemo(int key, string value)
        {
            this.Key = key;
            Value = value;
            Data = new OtherDataDemo(key * key + 2);
        }

        public void ChangeValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                Value = value;
            }
        }
        public void NextValue() {
            Key = Key + Key;
        }
    }
}