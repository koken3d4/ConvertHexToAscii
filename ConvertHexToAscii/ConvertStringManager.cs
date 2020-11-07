﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertHexToAscii
{
    public class ConvertStringManager
    {
        List<string> strList = new List<string>();

        public List<string> SingleStringList = new List<string>();
        public List<string> DoubleStringList = new List<string>();

        public ConvertStringManager(string _str)
        {
            ConvertHexASCII conv = new ConvertHexToAscii.ConvertHexASCII();
            strList = conv.ConvertStringToASCIIList(_str);
        }

        public void ConvertSingle()
        {
            //1倍超の時の変換を行う。
            //ストリングになったものを上から順に入れてこむ。
            //奇数の時は最後に00を入れる。
            if (strList.Count == 0) return;

            while (true)
            {
                if (strList.Count == 1)
                {
                    SingleStringList.Add(strList[0] + "00");
                    break;
                }
                else if (strList.Count == 2)
                {
                    SingleStringList.Add(strList[0] + strList[1]);
                    break;
                }
                else
                {
                    SingleStringList.Add(strList[0] + strList[1]);
                    strList.RemoveAt(0);
                    strList.RemoveAt(0);//最初の要素二つを消去する。
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
        { }

    }
}