using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConvertHexToAscii
{
    public class ConvertHexASCII
    {
         List<string > strList = new List<string>();

        // コンストラクタ
        public ConvertHexASCII()
        {

        }
        
        public List<string> ConvertHex(string _inputText)
        {
            strList.Clear();

            //charに分解して、バイトに変換できるか確認する。
            //変換に失敗したとき、falseを返す。
            var list = _inputText.ToCharArray();

            foreach (var s in list)
            {
                //charをintに変換する。
                //intを16進にする事で文字列→16進を達成出来る。
                //https://dobon.net/vb/dotnet/programing/converthex.html より。ToString(num,16)で16進に変換できる。2進の時は16→2とする。

                var integerd = (int)s;
                string strASCII = Convert.ToString(integerd, 16);

                //インプットの文字が英数字、記号意外で3桁以上の時はリターンしない。
                if (strASCII.Length > 3)
                    continue;

                else
                    strList.Add(strASCII);
            }

            return strList;
        }
    }
}
