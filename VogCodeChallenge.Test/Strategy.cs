namespace VogCodeChallenge.Test
{
    using System;
    using System.Collections.Generic;

    public interface IOperationStrategy
    {
        string Name { get; }
    }

    public interface IOperation : IOperationStrategy
    {
        object Solve(object value);
    }

    internal class NumberBetween : IOperation
    {
        public string Name
        {
            get { return "Exercise A"; }
        }

        public object Solve(object value)
        {
            return (int)value * 2;
        }
    }

    internal class NumberBiggerThan : IOperation
    {
        public string Name
        {
            get { return "Exercise B"; }
        }

        public object Solve(object value)
        {
            return (int)value * 3;
        }
    }

    internal class NumberBellow : IOperation
    {
        public string Name
        {
            get { return "Exercise C"; }
        }

        public object Solve(object value)
        {
            throw new Exception("Integer value below than 1");
        }
    }

    internal class FloatValue : IOperation
    {
        public string Name
        {
            get { return "Exercise D"; }
        }

        public object Solve(object value)
        {
            if ((float)value == 1.0f || (float)value == 2.0f)
                return 3.0f;
            return (float)value;
        }
    }

    internal class StringValue : IOperation
    {
        public string Name
        {
            get { return "Exercise E"; }
        }

        public object Solve(object value)
        {
            return value.ToString().ToUpper();
        }
    }

    internal class Default : IOperation
    {
        public string Name
        {
            get { return "Exercise F"; }
        }

        public object Solve(object value)
        {
            return value;
        }
    }

    public class Context
    {
        private readonly Dictionary<string, IOperation> Operations = new Dictionary<string, IOperation>();

        public Context()
        {
            Operations.Add("A", new NumberBetween());
            Operations.Add("B", new NumberBiggerThan());
            Operations.Add("C", new NumberBellow());
            Operations.Add("D", new FloatValue());
            Operations.Add("E", new StringValue());
            Operations.Add("F", new Default());
        }

        public Solution Execute(object value)
        {
            Solution solution = new Solution();
            solution.ValueType = value.GetType().ToString();

            if (value.GetType() == typeof(int))
            {
                if ((int)value >= 1 && (int)value <= 4)
                {
                    solution.Name = Operations["A"].Name;
                    solution.Result = Operations["A"].Solve(value).ToString();
                }
                else if ((int)value > 4)
                {
                    solution.Name = Operations["B"].Name;
                    solution.Result = Operations["B"].Solve(value).ToString();
                }
                else
                {
                    solution.Name = Operations["C"].Name;
                    solution.Result = Operations["C"].Solve(value).ToString();
                }
            }
            else if (value.GetType() == typeof(float))
            {
                solution.Name = Operations["D"].Name;
                solution.Result = Operations["D"].Solve(value).ToString();
            }
            else if (value.GetType() == typeof(string))
            {
                solution.Name = Operations["E"].Name;
                solution.Result = Operations["E"].Solve(value).ToString();
            }
            else
            {
                solution.Name = Operations["F"].Name;
                solution.Result = Operations["F"].Solve(value).ToString();
            }

            return solution;
        }

        public class Solution
        {
            public string Name { get; set; }
            public string ValueType { get; set; }
            public string Result { get; set; }

            public override string ToString()
            {
                return "Excercise: " + Name + ", Result = " + Result + " (" + ValueType + ")";
            }
        }
    }
}
