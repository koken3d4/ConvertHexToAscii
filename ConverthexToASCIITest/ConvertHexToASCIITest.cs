using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConverthexToASCIITest
{
    public class ConvertHexToASCIITest
    {
        [Fact]
        public void  checkConvert()
        {
            ConvertHexToAscii.ConvertHexASCII cha = new ConvertHexToAscii.ConvertHexASCII();
            Assert.Equal(6, cha.ConvertHex("asf,da").Count);
            Assert.Equal(4, cha.ConvertHex("TEST").Count);            
        }
    }
}
