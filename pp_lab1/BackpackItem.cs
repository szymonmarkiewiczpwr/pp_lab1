using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("pp_lab1_tests")]
namespace pp_lab1
{
    internal class BackpackItem : IComparable
    {
        public int Value { get; private set; }
        public int Weight { get; private set; }

        public float ValueToWeightRatio { 
            get
            {
                return (float)Value / (float)Weight;
            } 
        }

        public bool IsNull => throw new NotImplementedException();

        public BackpackItem(int value, int weight)
        {
            Value = value;
            Weight = weight;

            if (Weight <= 0)
                throw new DivideByZeroException("Setting this value to zero will result in division by zero exceptions");
        }

        public override string ToString()
        {
            return $"Value: {Value}, Weight: {Weight}";
        }

        public int CompareTo(object? obj)
        {
            if (obj is not BackpackItem other)
                throw new NullReferenceException($"Argument {nameof(obj)} has to be of type {nameof(BackpackItem)} cannot be null");

            return other.ValueToWeightRatio.CompareTo(ValueToWeightRatio);
        }
    }
}
