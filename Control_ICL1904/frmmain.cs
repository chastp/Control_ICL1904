﻿using System;
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
            ExecPro(process1, arg,"ICL");
        }
       private void ExecPro(string ProcessName, string args , string Computer_system)
        {
            try
            {
                string drive1 = Properties.Settings.Default.Drive1;
                string drive2 = Properties.Settings.Default.Drive2;
                string wkdir1 = Properties.Settings.Default.Wkdir1;
                string wkdir2 = Properties.Settings.Default.Wkdir2;
                string wkdir3 = Properties.Settings.Default.Wkdir3;
                string wkdir4 = Properties.Settings.Default.Wkdir4;

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

                if (Computer_system == "Dec")
                {
                    arg1 = prog1arg + " " + drive2 + wkdir4 + "\\" + args;
                }

                if (Computer_system == "Telnet")
                {
                    arg1 = prog1arg + " " + "c:\\windows\\system32\\" + args;
                }
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
            ExecPro(process1, arg, "ICL");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtmessage.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "printdrdump.bat ";
            ExecPro(process1, arg, "ICL");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "lookmt.bat ";
            ExecPro(process1, arg, "ICL");

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "lookmt.list ";
            ExecPro(process1, arg, "ICL");
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_term.bat";
            ExecPro(process1, arg, "ICL");
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
            ExecPro(process1, arg, "ICL");
 
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
            ExecPro(process1, arg, "ICL");

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "cardedit.exe ";
            ExecPro(process1, arg, "ICL");
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "CardViewer.exe ";
            ExecPro(process1, arg, "ICL");
        }

        private void RunICL1904G3SystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe";
            string arg = "run_george.bat ";
            ExecPro(process1, arg, "ICL");
        }

        private void RunICL1904G6SystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe";
            string arg = "run_e6rm.bat ";
            ExecPro(process1, arg, "ICL");
        }

        private void RunICL1904G3EESystemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoadVDUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe";
            string arg = "run_term.bat ";
            ExecPro(process1, arg, "ICL");
        }

        private void CreateCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = " cardedit.bat";
            ExecPro(process1, arg, "ICL");
        }

        private void CreateCardsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string process1 = "cmd.exe  ";
            string arg = "run_cardedit.bat";
            ExecPro(process1, arg, "ICL");
        }

        private void ViewCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_cardview.bat ";
            ExecPro(process1, arg, "ICL");
        }

        private void ProgrammingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_pdf.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\TPS_Manuals\\TPS_Programming_Part_1.pdf";
            ExecPro(process1, arg, "ICL");

        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_pdf.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\IDMS_Manuals\\AA-0899C-TB_DBMS-10admin.pdf";
            ExecPro(process1, arg, "ICL");

        }

        private void CobolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_pdf.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\IDMS_Manuals\\AA-0901C-TB_DBMS-10prog.pdf";
            ExecPro(process1, arg, "ICL");

        }

        private void EmulateSystemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenCOBOLIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_Opencobide.bat ";
            ExecPro(process1, arg, "ICL");
        }

        private void TelnetOn1900ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "telnet.exe localhost 10007 ";
            ExecPro(process1, arg, "Telnet");
        }

        private void InstalationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nimms  Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\NIMMs\\tp4248_MIMMS_Implementation.djvu";
            ExecPro(process1, arg, "ICL");

        }

        private void InstalationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Datafeed Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\Datafeed\\tp4395_Datafeed_Systems.djvu";
            ExecPro(process1, arg, "ICL");

        }

        private void FileHandlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nimms  Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\NIMMs\\tp4243_NIMMS_File_Handler.djvu";
            ExecPro(process1, arg, "ICL");
            frmDocs frm1 = new frmDocs("C:\\em1904s\\ICL_1900_Manuals\\NIMMs\\tp4243_NIMMS_File_Handler.djvu");
            frm1.Show();
        }

        private void DataManagementSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nimms  Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\NIMMs\\tp4250_NIMMS_Data_Management_System.djvu";
            ExecPro(process1, arg, "ICL");

        }

        private void IntroductionToCOBOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\COBOL\\tp4118_Introduction_COBOL.djvu";
            ExecPro(process1, arg, "ICL");


        }

        private void COBOLAncilliriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\COBOL\\tp4217_COBOL_Ancilliries.djvu";
            ExecPro(process1, arg, "ICL");

        }

        private void COBOLExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\COBOL\\tp4436_Cobol_Extras.djvu";
            ExecPro(process1, arg, "ICL");

        }

        private void BasicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // BASIC
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\BASIC\\tp4281_Basic.djvu";
            ExecPro(process1, arg, "ICL");

        }

        private void CityAndGuildsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // City and Guilds
            string process1 = "cmd.exe ";
            string arg = "run_pdf.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\City_Guilds\\City and Guilds Mnemonic Manual.docx";
            ExecPro(process1, arg, "ICL");

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
            ExecPro(process1, arg, "ICL");
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

        private void findEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Find Enquiry  Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\FIND\\tp4155_find_Enquiry.djvu";
            ExecPro(process1, arg, "ICL");
        }

        private void onlineEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Find Online Enquiry  Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\FIND\\tp4282_Online_Find.djvu";
            ExecPro(process1, arg, "ICL");
        }

        private void find2EnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Find 2 Enquiry  Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\FIND\\tp4450_Find2_Enquiry_System.djvu";
            ExecPro(process1, arg, "ICL");
        }


        private void dataManagementDataValidatingEdittingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Data Management Data Validating Editting  Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\Data_Management\\tp4127_Data_Management_Data_Validating_Editting.djvu";
            ExecPro(process1, arg, "ICL");
        }

        private void dataManagementDataUpdating2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Data Management Data Updating 2  Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\Data_Management\\tp4128_Data_Management_Data_Updating (2).djvu";
            ExecPro(process1, arg, "ICL");
        }

        private void dataManagementIntroductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Data Management Introduction Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\Data_Management\\tp4375_data_Management_Introduction.djvu";
            ExecPro(process1, arg, "ICL");
        }

        private void dataManagementDataValidationEdittingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Data Management Data Validation and Editting Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\Data_Management\\tp4376_Data_Management_Data_Validation_Editting.djvu";
            ExecPro(process1, arg, "ICL");
        }

        private void dataManagementDataUpdatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Data Management Data Validation and Editting Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\Data_Management\\tp4376_Data_Management_Data_Validation_Editting.djvu";
            ExecPro(process1, arg, "ICL");
        }

        private void dataManagementDataSoftwareReportingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Data Management Data Software Reporting Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\Data_Management\\tp4378_Data_Management_Data_Software_Reporting.djvu";
            ExecPro(process1, arg, "ICL");
        }

        private void dataManagementDataFilearrangementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Data Management Data File Arrangement Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\Data_Management\\tp4379_Data_Management_Data_File_arrangement.djvu";
            ExecPro(process1, arg, "ICL");
        }

        private void dataManagementDataFrameworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Data Management Data framework Installation
            string process1 = "cmd.exe ";
            string arg = "run_manual.bat";
            arg = arg + " " + "C:\\em1900\\ICL_1900_Manuals\\Data_Management\\tp4380_Data_Management_Data_Framework.djvu";
            ExecPro(process1, arg, "ICL");
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void basicToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Dec Basic
            string process1 = "cmd.exe ";
            string arg = "run_pdf.bat";
            arg = arg + " " + "C:\\SIMH\\simh - master\\PDP10\\exe\\AA-5059B-TK_COBOL-74_Language_Manual_Oct85.pdf";
            ExecPro(process1, arg, "ICL");
        }

        private void runDecPDP10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "Run_PHP10.exe";
            arg = arg + " " + " x ";
            ExecPro(process1, arg, "Dec");
        }

        private void decAlterSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "notepad.exe ";
            arg = arg + " " + "tops10.cfg";
            ExecPro(process1, arg, "Dec");
        }

        private void telnetOnPDP10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "cmd.exe ";
            string arg = "telnet.exe  -t vt100 localhost 2020 ";
            ExecPro(process1, arg, "Telnet");
        }
    }
}