using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConvertHexToAscii;
using Xunit;

namespace ConverthexToASCIITest
{
    public class ConvertStringManagerTest
    {
        [Theory]
        [InlineData(0, "3031")]
        [InlineData(1, "3233")]
        [InlineData(2, "3400")]
        public void ConvertSingleTestAtOdd(int _index, string converted)
        {
            ConvertStringManager manager = new ConvertStringManager("01234");
            manager.ConvertSingle();
            Assert.Equal(converted, manager.StringList[_index]);            
        }

        [Theory]
        [InlineData(0, "3031")]
        [InlineData(1, "3233")]
        [InlineData(2, "3435")]
        public void ConvertSingleTestAtEven(int _index, string converted)
        {
            ConvertStringManager manager = new ConvertStringManager("012345");
            manager.ConvertSingle();
            Assert.Equal(converted, manager.StringList[_index]);
        }

        [Theory]
        [InlineData(0, "32333031")]
        [InlineData(1, "00003400")]
        public void ConverrtDoubleTestAtOdd(int _index, string converted)
        {
            ConvertStringManager manager = new ConvertStringManager("01234");
            manager.ConvertDouble();
            Assert.Equal(converted, manager.StringList[_index]);
        }

        [Theory]
        [InlineData(0, "32333031")]
        [InlineData(1, "00003435")]
        public void ConverrtDoubleTestAtEven(int _index, string converted)
        {
            ConvertStringManager manager = new ConvertStringManager("012345");
            manager.ConvertDouble();
            Assert.Equal(converted, manager.StringList[_index]);
        }
    }
}
