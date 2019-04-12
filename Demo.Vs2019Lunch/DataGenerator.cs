using System.Collections.Generic;
using System.Linq;

namespace Demo.Vs2019Lunch
{
    class DataGenerator
    {
        public List<DataDemo> Generate(int count) =>
            Enumerable.Range(0, count)
                .ToList()
                .Select(x => new DataDemo(x, $"Value {x}"))
                .ToList();
    }
}