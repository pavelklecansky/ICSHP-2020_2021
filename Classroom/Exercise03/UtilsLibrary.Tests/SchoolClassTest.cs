using System;
using Xunit;

namespace UtilsLibrary.Tests
{
    public class SchoolClassTest
    {
        [Fact]
        public void PrintEachStudentNameDoesntThrowExecption()
        {
            SchoolClass.OperationDelagate operationDelagate = name => Console.WriteLine(name);
            SchoolClass schoolClass = new SchoolClass(2017);

            var ex = Record.Exception(() => schoolClass.ProcessOperation(operationDelagate));

            Assert.Null(ex);
        }

        [Fact]
        public void CreateSchoolClassByConvertOperatorHasCorrectYear()
        {
            int year = 1983;
            SchoolClass schoolClass = year;
            Assert.Equal(year, schoolClass.Year);
        }
        
        [Fact]
        public void CreateSchoolClassByConvertFromStringOperatorHasCorrectYear()
        {
            string yearAsString = "1983";
            SchoolClass schoolClass = (SchoolClass) yearAsString;
            Assert.Equal(int.Parse(yearAsString), schoolClass.Year);
        }
    }
}