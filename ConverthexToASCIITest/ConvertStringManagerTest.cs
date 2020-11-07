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
        public void z(int _index, string converted)
        {
            ConvertStringManager manager = new ConvertStringManager("01234");
            manager.ConvertSingle();
            Assert.Equal(converted, manager.SingleStringList[_index]);

        }
    }
}
