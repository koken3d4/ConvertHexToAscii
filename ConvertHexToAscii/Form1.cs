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
            makeStringInTextBox(rbSingle.Checked, rbDouble.Checked);
        }

        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSingle.Checked)  //ラジオボタンは変更の時に処理が2回行われてしまう事があるのでその対策
                makeStringInTextBox(rbSingle.Checked, rbDouble.Checked);
        }

        private void rbDouble_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDouble.Checked)  //ラジオボタンは変更の時に処理が2回行われてしまう事があるのでその対策
                makeStringInTextBox(rbSingle.Checked, rbDouble.Checked);
        }

        private void makeStringInTextBox(bool _isSingle, bool _isdouble)
        {
            if (tbInputString.Text == "")
                return;

            //ありえないが両方共falseの時は処理しない。
            if (!_isSingle && !_isdouble)
                return;

            //コンバート後のテキストボックスの初期化
            foreach (var tb in tbList)
                tb.Text = "";

            ConvertStringManager mane = new ConvertStringManager(tbInputString.Text);
            if (_isSingle)
            {
                mane.Convert(rbSingle);
            }

            if (_isdouble)
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
