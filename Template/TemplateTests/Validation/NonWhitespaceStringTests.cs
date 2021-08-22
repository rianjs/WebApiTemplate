using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using Template.Validation;

namespace TemplateTests.Validation
{
    public class NonWhitespaceStringTests
    {
        public static IEnumerable<ITestCaseData> IsValidTestCases()
        {
            yield return new TestCaseData("")
                .Returns(false)
                .SetName("Empty string is invalid");
            
            yield return new TestCaseData(" ")
                .Returns(false)
                .SetName("Whitespace string is invalid");

            yield return new TestCaseData(null)
                .Returns(false)
                .SetName("Null string is invalid");
            
            yield return new TestCaseData("foo")
                .Returns(true)
                .SetName("Non-empty string is valid");
        }

        [Test, TestCaseSource(nameof(IsValidTestCases))]
        public bool IsValidTests(string val)
        {
            var validator = new NonWhitespaceStringAttribute();
            return validator.IsValid(val);
        }
    }
}