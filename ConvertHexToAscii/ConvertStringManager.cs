using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertHexToAscii
{
    public class ConvertStringManager
    {
        List<string> strList = new List<string>();

        public List<string> StringList = new List<string>();

        public ConvertStringManager(string _str)
        {
            ConvertHexASCII conv = new ConvertHexToAscii.ConvertHexASCII();
            strList = conv.ConvertStringToASCIIList(_str);
        }

        public void Convert(object obj)
        {
            var item = (System.Windows.Forms.RadioButton)obj;
            if (item.Name.Contains("Single"))
                ConvertSingle();
            else if (item.Name.Contains("Double"))
                ConvertDouble();
        }

        public void ConvertSingle()
        {
            //1倍超の時の変換を行う。
            //ストリングになったものを上から順に入れこむ。
            //奇数の時は最後に00を入れる。
            if (strList.Count == 0) return;

            //Listをハードコピーする。
            //かなり悪い方法だが、そこまで要素数が多い事もないので当面はこれでいく。
            List<string> hardCopy = new List<string>();
            hardCopy.AddRange(strList);
            StringList.Clear();

            while (true)
            {
                if (hardCopy.Count == 1)
                {
                    StringList.Add(hardCopy[0] + "00");
                    break;
                }
                else if (hardCopy.Count == 2)
                {
                    StringList.Add(hardCopy[0] + hardCopy[1]);
                    break;
                }
                else
                {
                    StringList.Add(hardCopy[0] + hardCopy[1]);
                    hardCopy.RemoveAt(0);
                    hardCopy.RemoveAt(0);//最初の要素二つを消去する。
                }
            }

            //int count = (int)(strList.Count / 2) + 1;
            //for (int i = 0; i < count; i++)
            //{
            //    if (i == strList.Count - 1)
            //        SingleStringList.Add(strList[2 * i] + "00");
            //    else
            //        SingleStringList.Add(strList[2 * i] + strList[2 * i + 1]);
            //}
        }

        public void ConvertDouble()
        {
            //倍超の時の変換を行う。
            //ストリングになったものをテキストボックスに2,3,0,1の順に入れこむ。
            // 0123->30,31,32,33-> 32,33,30,31  となる。        
            //そのため、余剰の文字が1，2，3、4で場合分けをする。
            //文字列がないときは奇数の時は最後に00を入れる。
            if (strList.Count == 0) return;

            //Listをハードコピーする。
            //かなり悪い方法だが、そこまで要素数が多い事もないので当面はこれでいく。
            List<string> hardCopy = new List<string>();
            hardCopy.AddRange(strList);
            StringList.Clear();

            while (true)
            {
                if (hardCopy.Count == 1)
                {
                    StringList.Add("00" + "00" + hardCopy[0] + "00");
                    break;
                }
                else if (hardCopy.Count == 2)
                {
                    StringList.Add("00" + "00" + hardCopy[0] + hardCopy[1]);
                    break;
                }
                else if (hardCopy.Count == 3)
                {
                    StringList.Add(hardCopy[2] + "00" + hardCopy[0] + hardCopy[1]);
                    break;
                }
                else if (hardCopy.Count == 4)
                {
                    StringList.Add(hardCopy[2] + hardCopy[3] + hardCopy[0] + hardCopy[1]);
                    break;
                }
                else
                {
                    StringList.Add(hardCopy[2] + hardCopy[3] + hardCopy[0] + hardCopy[1]);

                    //最初の4つの様子を削除する。
                    hardCopy.RemoveAt(0);
                    hardCopy.RemoveAt(0);
                    hardCopy.RemoveAt(0);
                    hardCopy.RemoveAt(0);
                }
            }

        }

    }
}
