using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_ICL1904
{
    public partial class Form1 : Form
    {
        private string coutext;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtrun.Text = "";
            string cmd = "c:\\em1904s\\bin\\run_ewg3.cmd";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun.Text = ExecPro(process1,arg,wrkdir1,cmd);
        }
        private String ExecPro(string ProcessName, string args, string WrkDir, string cmdtxt)
        {
            try
            {
                Process cmd = new Process();
                 
                cmd.StartInfo.FileName = ProcessName;
                cmd.StartInfo.Arguments = args;
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.WorkingDirectory = WrkDir;
                cmd.StartInfo.CreateNoWindow = false;
                cmd.StartInfo.ErrorDialog = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardError = true;

                cmd.Start();
                StreamWriter cin = cmd.StandardInput;
                StreamReader cout = cmd.StandardOutput;

                cin.WriteLine(cmdtxt);
                cin.Close();
                coutext = cout.ReadToEnd();
                cmd.WaitForExit();
                cmd.Close();
                return coutext;
            }
            catch (Exception ex)
            {
                string commandfile = ProcessName;
                string filename = WrkDir + "\\" + cmdtxt;
                txtmessage.Text = ex.Message + "(" + commandfile + filename + ")";
                return "Error";
            }
 
        }
 
        private void button7_Click(object sender, EventArgs e)
        {
            txtrun.Text = "";
            string cmd = "c:\\em1904s\\bin\\run_e6rm.cmd";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun.Text = ExecPro(process1, arg, wrkdir1, cmd);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtmessage.Text = "";
            txtrun.Text = "";
        }

          private void button5_Click(object sender, EventArgs e)
        {
            txtrun.Text = "";
            string cmd = "c:\\em1904s\\bin\\printicltape.bat";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun.Text = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtrun.Text = "";
            string cmd = "c:\\em1904s\\bin\\printdrdump.bat";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun.Text = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtrun.Text = "";
            string cmd = "Notepad.exe ";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "lookmt.txt";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun.Text = ExecPro(process1, arg, wrkdir1, cmd);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtrun.Text = "";
            string cmd = "Notepad.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "lookmt.list";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun.Text = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtrun.Text = "";
            string cmd = "c:\\em1904s\\bin\\mkeds.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = txtmakedskno.Text;
            string wrkdir1 = "c:\\em1904s\\discs\\";
            txtrun.Text = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtrun.Text = "";
            string cmd = "c:\\em1904s\\discs\\drdump.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = txtdiscno2.Text;
            string wrkdir1 = "c:\\em1904s\\discs\\";
            txtrun.Text = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            txtrun.Text = "";
            string cmd = "c:\\em1904s\\bin\\run_term.cmd";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun.Text = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cOBOLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtrun.Text = "";
            string cmd = "c:\\g3exec\\bin\\run.bat";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "";
            string wrkdir1 = "c:\\g3exec\\bin\\";
            txtrun.Text = ExecPro(process1, arg, wrkdir1, cmd);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocs frm1 = new frmDocs("C:\\em1904s\\ICL_1900_Manuals\\COBOL\\tp4427_Cobol.djvu");
            frm1.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImage frmimage1;
            frmimage1 = new frmImage();
            frmimage1.Show();
        }

        private void compilingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtrun.Text = "";
            string cmd = "c:\\g3exec\\bin\\run.bat";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "";
            string wrkdir1 = "c:\\g3exec\\bin\\";
            //txtrun.Text = ExecPro(process1, arg, wrkdir1, cmd);
        }
    }
}
