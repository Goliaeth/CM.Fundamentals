using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using Program = ConsoleCalculator.Program;

namespace TestProject
{
    public class MainTest
    {
        [Fact]
        public void ShouldReturnResultOfSubstracting()
        {

            MockConsole mockConsole = new MockConsole();
            Program program = new Program();
            program.MyConsole = mockConsole;
            mockConsole.Outputs.Enqueue("15");
            mockConsole.Outputs.Enqueue("10");
            mockConsole.Outputs.Enqueue("s");
            mockConsole.Outputs.Enqueue("n");

            program.RunCalculator();

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

            Assert.Equal(expectedResult, Regex.Replace(mockConsole.Inputs.ToString(), @"[\r\t\n]+", string.Empty));

        }

        [Fact]
        public void ShouldReturnResultOfMultWithIncorrectInput()
        {

            MockConsole mockConsole = new MockConsole();
            Program program = new Program();
            program.MyConsole = mockConsole;
            mockConsole.Outputs.Enqueue("dsf");
            mockConsole.Outputs.Enqueue("15");
            mockConsole.Outputs.Enqueue("3rwer");
            mockConsole.Outputs.Enqueue("7");
            mockConsole.Outputs.Enqueue("m");
            mockConsole.Outputs.Enqueue("n");

            program.RunCalculator();

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

            Assert.Equal(expectedResult, Regex.Replace(mockConsole.Inputs.ToString(), @"[\r\t\n]+", string.Empty));

        }

        [Fact]
        public void ShouldReturnMathError()
        {

            MockConsole mockConsole = new MockConsole();
            Program program = new Program();
            program.MyConsole = mockConsole;
            mockConsole.Outputs.Enqueue("4");
            mockConsole.Outputs.Enqueue("0");
            mockConsole.Outputs.Enqueue("d");
            mockConsole.Outputs.Enqueue("n");

            program.RunCalculator();

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

            Assert.Equal(expectedResult, Regex.Replace(mockConsole.Inputs.ToString(), @"[\r\t\n]+", string.Empty));

        }

    }
}
