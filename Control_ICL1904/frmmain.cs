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
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "Run_ICL1904_G3.bat";
            ExecPro(process1, arg);
        }
       private void ExecPro(string ProcessName, string args )
        {
            try
            {
                string drive1 = Properties.Settings.Default.Drive1;
                string drive2 = Properties.Settings.Default.Drive2;
                string wkdir1 = Properties.Settings.Default.Wkdir1;
                string wkdir2 = Properties.Settings.Default.Wkdir2;
                string wkdir3 = Properties.Settings.Default.Wkdir3;
                string prog1 = Properties.Settings.Default.Prog1;
                string prog1arg = Properties.Settings.Default.Prog1arg;

                txtmessage.Text = "";
                string command1;

                if ( prog1 == "cmd.exe")
                {
                    command1 =  "c:\\windows\\system32\\" + prog1 ;
                }
                else
                {
                    command1 = drive1 + wkdir1 + "\\" + prog1 ;
                }
                
                ProcessStartInfo processInfo;
                string arg1 = args;
                int len1 = arg1.Length;
                string ext1 = arg1.Substring(len1 - 4, 3);
                if (prog1 == "cmd.exe")
                {
                    arg1 = prog1arg + " " + drive2 + wkdir3 + "\\" + args;
                }
                else
                {
                    arg1 = drive2 + wkdir3 + "\\" + args;
                }
                arg1 = prog1arg + " " + drive2 + wkdir3 + "\\" + args;

                processInfo = new ProcessStartInfo
                {
                    UseShellExecute = true, // change value to false
                    FileName = command1,
                    Arguments = arg1,
                    RedirectStandardError = false,
                    RedirectStandardOutput = false 
               };
                Process process1;
                process1 = new Process
                {
                    StartInfo = processInfo
                };
                txtcommand.Text = process1.StartInfo.FileName.ToString() + " " + arg1.ToString();
                process1.Start();
                process1.WaitForExit();
            }
            catch (Exception ex)
            {
                txtmessage.Text = ex.Message.ToString();
            }

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "Run_ICL1904_G6.bat ";
            ExecPro(process1, arg );
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtmessage.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "printdrdump.bat ";
            ExecPro(process1, arg);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "lookmt.bat ";
            ExecPro(process1, arg);

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "lookmt.list ";
            ExecPro(process1, arg);
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_term.bat";
            ExecPro(process1, arg);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void COBOLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\COBOL\\tp4427_Cobol.djvu";
            ExecPro(process1, arg);
 
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImage frmimage1;
            frmimage1 = new frmImage();
            frmimage1.Show();
        }
        private void CompilingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\COBOL\\tp4426_Cobol_Compilers.djvu";
            ExecPro(process1, arg);

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "cardedit.exe ";
            ExecPro(process1, arg);
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "CardViewer.exe ";
            ExecPro(process1, arg);
        }

        private void RunICL1904G3SystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe";
            string arg = "run_george.bat ";
            ExecPro(process1, arg);
        }

        private void RunICL1904G6SystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe";
            string arg = "run_e6rm.bat ";
            ExecPro(process1, arg);
        }

        private void RunICL1904G3EESystemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoadVDUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe";
            string arg = "run_term.bat ";
            ExecPro(process1, arg);
        }

        private void CreateCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = " cardedit.bat";
            ExecPro(process1, arg);
        }

        private void CreateCardsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string process1 = "cmd.exe  ";
            string arg = "run_cardedit.bat";
            ExecPro(process1, arg);
        }

        private void ViewCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_cardview.bat ";
            ExecPro(process1, arg);
        }

        private void ProgrammingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_pdf.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\TPS_Manuals\\TPS_Programming_Part_1.pdf";
            ExecPro(process1, arg);

        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_pdf.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\IDMS_Manuals\\AA-0899C-TB_DBMS-10admin.pdf";
            ExecPro(process1, arg);

        }

        private void CobolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_pdf.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\IDMS_Manuals\\AA-0901C-TB_DBMS-10prog.pdf";
            ExecPro(process1, arg);

        }

        private void EmulateSystemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenCOBOLIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_Opencobide.bat ";
            ExecPro(process1, arg);
        }

        private void TelnetOn1900ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "  telnet.exe open localhost 10001 ";
            ExecPro(process1, arg);
        }

        private void InstalationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nimms  Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\NIMMs\\tp4248_MIMMS_Implementation.djvu";
            ExecPro(process1, arg);

        }

        private void InstalationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Datafeed Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\Datafeed\\tp4395_Datafeed_Systems.djvu";
            ExecPro(process1, arg);

        }

        private void FileHandlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nimms  Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\NIMMs\\tp4243_NIMMS_File_Handler.djvu";
            ExecPro(process1, arg);
            frmDocs frm1 = new frmDocs("C:\\em1904s\\ICL_1900_Manuals\\NIMMs\\tp4243_NIMMS_File_Handler.djvu");
            frm1.Show();
        }

        private void DataManagementSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nimms  Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\NIMMs\\tp4250_NIMMS_Data_Management_System.djvu";
            ExecPro(process1, arg);

        }

        private void IntroductionToCOBOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\COBOL\\tp4118_Introduction_COBOL.djvu";
            ExecPro(process1, arg);


        }

        private void COBOLAncilliriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\COBOL\\tp4217_COBOL_Ancilliries.djvu";
            ExecPro(process1, arg);

        }

        private void COBOLExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\COBOL\\tp4436_Cobol_Extras.djvu";
            ExecPro(process1, arg);

        }

        private void BasicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // BASIC
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\BASIC\\tp4281_Basic.djvu";
            ExecPro(process1, arg);

        }

        private void CityAndGuildsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // City and Guilds
            string process1 = "cmd.exe ";
            string arg = "run_pdf.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\City_Guilds\\City and Guilds Mnemonic Manual.docx";
            ExecPro(process1, arg);

        }

        private void AlterSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSettings frms;
            frms = new FrmSettings();
            frms.Show();
        }

        private void openCobolIDEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Open COBOl IDE
            string process1 = "cmd.exe ";
            string arg = "run_Opencobide.bat ";
            ExecPro(process1, arg);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
