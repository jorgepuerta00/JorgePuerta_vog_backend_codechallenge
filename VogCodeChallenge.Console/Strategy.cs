using System;

namespace VogCodeChallenge.Console
{
    public interface IOperation
    {
        string Name { get; }
    }

    public interface IIntegerOperation : IOperation
    {
        int Calculate(int number);
    }

    public interface IFloatOperation : IOperation
    {
        float Calculate(float number);
    }

    public interface IStringOperation : IOperation
    {
        string Calculate(string value);
    }

    internal class NumberBetween : IIntegerOperation
    {
        public string Name
        {
            get { return "Exercise A";  }
        }

        public int Calculate(int number)
        {
            return number * 2;
        }
    }

    internal class NumberBiggerThan : IIntegerOperation
    {
        public string Name
        {
            get { return "Exercise B"; }
        }

        public int Calculate(int number)
        {
            return number * 3;
        }
    }

    internal class NumberBellow : IIntegerOperation
    {
        public string Name
        {
            get { return "Exercise C"; }
        }

        public int Calculate(int number)
        {
            throw new Exception("Integer value velow than 1");
        }
    }

    internal class FloatValue : IFloatOperation
    {
        public string Name
        {
            get { return "Exercise D"; }
        }

        public float Calculate(float number)
        {
            if (number == 1.0f || number == 2.0f)
                return 3.0f;
            return number;
        }
    }

    internal class StringValue : IStringOperation
    {
        public string Name
        {
            get { return "Exercise E"; }
        }

        public string Calculate(string value)
        {
            return value.ToUpper();
        }
    }

    internal class DefaultResult : IStringOperation
    {
        public string Name
        {
            get { return "Exercise F"; }
        }

        public string Calculate(string value)
        {
            return value;
        }
    }
}
