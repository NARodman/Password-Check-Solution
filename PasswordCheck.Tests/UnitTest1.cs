using Xunit;
using PasswordCheck;
using System.Threading.Channels;


namespace PasswordCheck.Tests
{


    public class UnitTest1
    {
        [Fact]
        public void EmptyPassword_ReturnsInvalid()
        {
            var check = new Password();
            Assert.Equal("INELIGABLE", check.StrengthCheck(""));
        }

        [Fact]

        public void OnlyLowercase_ReturnsWeak()
        {
            var check = new Password();
            Assert.Equal("WEAK", check.StrengthCheck("abc"));
        }
        [Fact]
        public void OnlyUppercase_ReturnsWeak()
        {
            var check = new Password();
            Assert.Equal("WEAK", check.StrengthCheck("ABC"));
        }
        [Fact]
        public void OnlyDigits_ReturnsWeak()
        {
            var check = new Password();
            Assert.Equal("WEAK", check.StrengthCheck("123"));
        }
        [Fact]
        public void OnlySymbols_ReturnsWeak()
        {
            var check = new Password();
            Assert.Equal("WEAK", check.StrengthCheck("@#$"));
        }
        [Fact]
        public void LowercaseAndUppercase_ReturnsMedium()
        {
            var check = new Password();
            Assert.Equal("MEDIUM", check.StrengthCheck("aBc"));
        }
        [Fact]
        public void LowercaseAndDigits_ReturnsMedium()
        {
            var check = new Password();
            Assert.Equal("MEDIUM", check.StrengthCheck("a1b2c3"));
        }
        [Fact]
        public void LowercaseAndSymbols_ReturnsMedium()
        {
            var check = new Password();
            Assert.Equal("MEDIUM", check.StrengthCheck("a@b#c$"));
        }
        [Fact]
        public void UppercaseAndDigits_ReturnsMedium()
        {
            var check = new Password();
            Assert.Equal("MEDIUM", check.StrengthCheck("A1B2C3"));
        }
        [Fact]
        public void UppercaseAndSymbols_ReturnsMedium()
        {
            var check = new Password();
            Assert.Equal("MEDIUM", check.StrengthCheck("A@B#C$"));
        }

        [Fact]
        public void AllCriteriaMet_ReturnsStrong()
        {
            var check = new Password();
            Assert.Equal("STRONG", check.StrengthCheck("Abcdef1!"));
        }

        



    }
}

