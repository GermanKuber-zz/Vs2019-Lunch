namespace Demo.Vs2019Lunch
{
    public interface IDataDemo
    {
        OtherDataDemo Data { get; set; }

        void ChangeValue(string value);
    }
}