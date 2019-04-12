namespace Demo.Vs2019Lunch
{
    public interface IDataDemo1
    {
        OtherDataDemo Data { get; set; }
        int Test { get; set; }

        void ChangeValue(string value);
    }
}