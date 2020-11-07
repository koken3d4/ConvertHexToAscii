using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertHexToAscii
{
    public partial class Form1 : Form
    {
        //
        private List<TextBox> tbList;

        public Form1()
        {
            InitializeComponent();

            //処理しやすいように配列化する。
            tbList = new List<TextBox>(){
                tbConvertASCII0,
                tbConvertASCII1,
                tbConvertASCII2,
                tbConvertASCII3,
                tbConvertASCII4,
                tbConvertASCII5,
                tbConvertASCII6
            };
        }

        private void btStartConvert_Click(object sender, EventArgs e)
        {
            if (tbInputString.Text == "")
                return;

            //コンバート後のテキストボックスの初期化
            foreach (var tb in tbList)
                tb.Text = "";

            ConvertStringManager mane = new ConvertStringManager(tbInputString.Text);
            if (rbSingle.Checked)
            {
                mane.Convert(rbSingle);
            }

            if (rbDouble.Checked)
            {
                mane.Convert(rbDouble);
            }

            for (int i = 0; i < mane.StringList.Count; i++)
            {
                tbList[i].Text = mane.StringList[i];
            }
        }
    }
}
