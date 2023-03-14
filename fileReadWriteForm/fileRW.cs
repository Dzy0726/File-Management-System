using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManageSystem
{
    public partial class fileRW : Form
    {
        public static bool changed;
        public Form1 par;
        public string filename;
        public fileRW(string Name,Form1 parent)
        {
            par = parent;
            filename = Name;
            changed = false;
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (changed == true)
            {
                DialogResult result = MessageBox.Show("是否进行保存？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    FCB nowFCB = par.category.search(par.category.root, filename, 0).fcb;
                    int oldSize = nowFCB.size;
                    int oldStart = nowFCB.start;
                    string content = textBox1.Text.Trim();
                    if (content != "")
                        MessageBox.Show("保存成功！");
                    string modifyTime = DateTime.Now.ToLocalTime().ToString();
                    nowFCB.size = textBox1.Text.Trim().Length;
                    nowFCB.lastModify = modifyTime;
                    //在内存上给文件分配空间
                    if(nowFCB.size>0)
                    {
                        if(par.MyDisk.remain<=textBox1.Text.Trim().Length)
                        {
                            MessageBox.Show("磁盘空间不足！");
                        }
                        else
                        {
                            if(oldStart==-1)
                            {
                                par.MyDisk.giveSpace(nowFCB, textBox1.Text.Trim());
                            }
                            else
                            {
                                par.MyDisk.fileUpdate(oldStart, oldSize,nowFCB, textBox1.Text.Trim());
                            }
                        }
                        
                            
                    }
                    par.fileFormInit(par.currentRoot);
                }
                else
                {
                    e.Cancel = false;  //不保存直接退出
                }
            }
            else
                e.Cancel = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void fileRW_Load(object sender, EventArgs e)
        {
            this.Text = filename + ".txt";
            FCB nowFCB = par.category.search(par.category.root, filename, 0).fcb;
            if (par.MyDisk.getFileContent(nowFCB) != "")
            {
                textBox1.AppendText(par.MyDisk.getFileContent(nowFCB));
            }
            changed = false;
        }
    }
}
