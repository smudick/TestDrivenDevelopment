using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    //name the class for the things we're testing
    public class TranslateNumbersToRomanNumerals // translate_numbers_to_roman_numerals
    {
        [Fact] //this method is a test
        public void when_the_number_1_is_passed_I_should_be_returned() //must be public, and return void, and take no parameters
        {
            //Arrange -- context creation
            var numberToConvert = 1;
            var translator = new RomanNumeralTranslator();

            //Act -- the action being taken in a given context
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert  -- an empty test is a passing test, make sure to not leave empty tests in production
            Assert.Equal("I", result);
        }

        [Fact]
        public void when_the_number_5_is_passed_V_should_be_returned()
        {
            //Arrange
            var numberToConvert = 5;
            var translator = new RomanNumeralTranslator();
            var expectedResult = "V";

            //Act
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert
            Assert.Equal(expectedResult, result);
        }  
        [Fact]
        public void when_the_number_9_is_passed_IX_should_be_returned()
        {
            //Arrange
            var numberToConvert = 9;
            var translator = new RomanNumeralTranslator();
            var expectedResult = "IX";

            //Act
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert
            Assert.Equal(expectedResult, result);
        }

    }
}
