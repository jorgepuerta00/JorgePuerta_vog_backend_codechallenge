namespace VogCodeChallenge.Test
{
    using System;
    using Xunit;

    public class TestModule
    {
        private readonly Context context = new Context();

        [Fact]
        public void TESTModule_NumberBewteen()
        {
            // Arrange
            int value = 2;
            // Act
            var result = context.Execute(value);
            // Assert
            Assert.True(int.Parse(result.Result) == value * 2);
        }

        [Fact]
        public void TESTModule_NumberBiggerThan()
        {
            // Arrange
            int value = 5;
            // Act
            var result = context.Execute(value);
            // Assert
            Assert.True(int.Parse(result.Result) == value * 3);
        }

        [Fact]
        public void TESTModule_NumberBellow()
        {
            // Arrange
            int value = 0;
            // Act
            var ex = Assert.Throws<Exception>(() => context.Execute(value));
            // Assert
            Assert.Matches(ex.Message, "Integer value below than 1");
        }

        [Fact]
        public void TESTModule_FloatValue()
        {
            // Arrange
            float value = 2;
            // Act
            var result = context.Execute(value);
            // Assert
            Assert.True(float.Parse(result.Result) == 3.0f || float.Parse(result.Result) == value);
        }

        [Fact]
        public void TESTModule_StringValue()
        {
            // Arrange
            string value = "hello world";
            // Act
            var result = context.Execute(value);
            // Assert
            Assert.Matches(result.Result, value.ToUpper());
        }

        [Fact]
        public void TESTModule_DefultResult()
        {
            // Arrange
            DateTime value = new DateTime();
            // Act
            var result = context.Execute(value);
            // Assert
            Assert.Matches(result.Result, value.ToString());
        }
    }
}
