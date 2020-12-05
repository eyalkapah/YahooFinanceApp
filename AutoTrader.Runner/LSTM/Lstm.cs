using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTrader.Runner.LSTM
{
    public class Lstm
    {
        private readonly double[][] _data;
        private readonly List<double[]> _normalizedData;

        public Lstm(params double[][] data)
        {
            _data = data;
            _normalizedData = new List<double[]>();

            NormalizeData();
        }

        private void NormalizeData()
        {
            foreach (var data in _data)
            {
                var min = data.Min();
                var max = data.Max();
                
                _normalizedData.Add(data.Select(d => Math.Round((d - min) / (max - min), 4)).ToArray());
            }
        }

        public void Print()
        {
            var rowCount = _normalizedData.First().Count();

            var table = new List<List<double>>();

            for (var i = 0; i < rowCount; i++)
                table.Add(_normalizedData.Select(values => values[i]).ToList());

            table.ForEach(row => Console.WriteLine(string.Join(",", row)));
        }

        public IEnumerable<double> CalculateScale()
        {
            for (var i = 0; i < _normalizedData.Count; i++)
            {
                var max = _data[i].Max();
                var min = _data[i].Min();

                var normMax = _normalizedData[i].Max();
                var normMin = _normalizedData[i].Min();

                yield return (normMax - normMin) / (max - min);
            }
        }

        public IEnumerable<double> CalculateMin()
        {
            var scales = CalculateScale().ToList();

            for (int i = 0; i < _normalizedData.Count; i++)
            {
                var minRaw = _data[i].Min();
                var normMin = _normalizedData[i].Min();
                var scale = scales[i];

                yield return normMin - minRaw * scale;
            }
        }

    }
}
