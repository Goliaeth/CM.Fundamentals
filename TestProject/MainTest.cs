using System;
using ConsoleCalculator;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;

namespace TestProject
{
    public class MainTest
    {

        [Fact]
        public void ShouldReturnResultOfSubstracting()
        {

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("15");
            stringBuilder.AppendLine("10");
            stringBuilder.AppendLine("s");
            stringBuilder.AppendLine("n");
            var stringReader = new StringReader(stringBuilder.ToString());
            Console.SetIn(stringReader);



            ConsoleCalculator.Program.Main(new string[0]);
            var expectedResult = "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "Type another number, and then press Enter: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "Your result: 5" +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedResult, Regex.Replace(stringWriter.ToString(), @"[\r\t\n]+", string.Empty));

        }

        [Fact]
        public void ShouldReturnResultOfMultWithIncorrectInput()
        {

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("dsf");
            stringBuilder.AppendLine("15");
            stringBuilder.AppendLine("3rwer");
            stringBuilder.AppendLine("7");
            stringBuilder.AppendLine("m");
            stringBuilder.AppendLine("n");
            var stringReader = new StringReader(stringBuilder.ToString());
            Console.SetIn(stringReader);



            ConsoleCalculator.Program.Main(new string[0]);
            var expectedResult = "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "This is not valid input. Please enter an integer value: " +
                                 "Type another number, and then press Enter: " +
                                 "This is not valid input. Please enter an integer value: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "Your result: 105" +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedResult, Regex.Replace(stringWriter.ToString(), @"[\r\t\n]+", string.Empty));

        }

        [Fact]
        public void ShouldReturnMathError()
        {

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("4");
            stringBuilder.AppendLine("0");
            stringBuilder.AppendLine("d");
            stringBuilder.AppendLine("n");
            var stringReader = new StringReader(stringBuilder.ToString());
            Console.SetIn(stringReader);



            ConsoleCalculator.Program.Main(new string[0]);
            var expectedResult = "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "Type another number, and then press Enter: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "This operation will result in a mathematical error." +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedResult, Regex.Replace(stringWriter.ToString(), @"[\r\t\n]+", string.Empty));

        }

    }
}
