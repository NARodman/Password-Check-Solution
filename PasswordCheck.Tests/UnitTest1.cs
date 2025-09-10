using Xunit;
using PasswordCheck;
using Xunit.Sdk;


namespace PasswordCheck.Tests
{


    public class UnitTest1
    {

        //Strength Check Tests

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
            Assert.Equal("WEAK", check.StrengthCheck("abcdefgh"));
        }
        [Fact]
        public void OnlyUppercase_ReturnsWeak()
        {
            var check = new Password();
            Assert.Equal("WEAK", check.StrengthCheck("ABCDEFGH"));
        }
        [Fact]
        public void OnlyDigits_ReturnsWeak()
        {
            var check = new Password();
            Assert.Equal("WEAK", check.StrengthCheck("12345678"));
        }
        [Fact]
        public void OnlySymbols_ReturnsWeak()
        {
            var check = new Password();
            Assert.Equal("WEAK", check.StrengthCheck("@#$%^&*!"));
        }
        [Fact]
        public void LowercaseAndUppercase_ReturnsMedium()
        {
            var check = new Password();
            Assert.Equal("MEDIUM", check.StrengthCheck("abcdEFGH"));
        }
        [Fact]
        public void LowercaseAndDigits_ReturnsMedium()
        {
            var check = new Password();
            Assert.Equal("MEDIUM", check.StrengthCheck("abcd1234"));
        }
        [Fact]
        public void LowercaseAndSymbols_ReturnsMedium()
        {
            var check = new Password();
            Assert.Equal("MEDIUM", check.StrengthCheck("abcd!@#$"));
        }
        [Fact]
        public void UppercaseAndDigits_ReturnsMedium()
        {
            var check = new Password();
            Assert.Equal("MEDIUM", check.StrengthCheck("ABCD1234"));
        }
        [Fact]
        public void UppercaseAndSymbols_ReturnsMedium()
        {
            var check = new Password();
            Assert.Equal("MEDIUM", check.StrengthCheck("ABCD!@#$"));
        }

        [Fact]
        public void AllCriteriaMet_ReturnsStrong()
        {
            var check = new Password();
            Assert.Equal("STRONG", check.StrengthCheck("Abc123!@"));
        }

        // GenerateUUIDv4 tests
        [Fact]
        public void GenerateUUID_ReturnsValid()
        {
            var check = new Password();
            string uuid = check.GenerateUUID();

            Assert.True(Guid.TryParse(uuid, out Guid result));
        }

        [Fact]
        public void GenerateUUID_ReturnsDifferent()
        {
            var check = new Password();
            string uuid1 = check.GenerateUUID();
            string uuid2 = check.GenerateUUID();

            Assert.NotEqual(uuid1, uuid2);
        }



    }
}

