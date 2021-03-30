using System;
using System.Data;
using System.IO;
using NUnit.Framework;

namespace Exercise07
{
    public class ExceptionsTests
    {
        [Test]
        public void Exception01Test()
        {
            using (var fs = new FileStream("text.txt", FileMode.Open))
            {
                try
                {
                    throw new DateTimeException();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    fs.Dispose();
                }
            }


            Assert.Pass();
        }
    }
}