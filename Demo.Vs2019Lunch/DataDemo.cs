namespace Demo.Vs2019Lunch
{
    class DataDemo
    {
        public readonly int Key;
        public string Value;
        public OtherDataDemo Data { get; set; }
        public DataDemo(int key, string value)
        {
            Key = key;
            Value = value;
            Data = new OtherDataDemo(key * key + 2);
        }

        public void ChangeValue(string value) =>
            Value = value;
    }
}