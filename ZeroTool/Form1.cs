using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO.Compression;
using System.IO;


namespace ZeroTool
{
    public partial class Form1 : Form
    {

        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStringW", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern short GetKeyState(int nVirtKey);



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pacagetxt.Text = Properties.Settings.Default.package;
            minimetxt.Text = Properties.Settings.Default.minime;
            TPtxt.Text = Properties.Settings.Default.TP;

            timer1.Interval = 100;
            timer1.Enabled = true;
            DBG_ESC.Text = "OFF";
            SEAT.SelectedIndex = 0;
            RIG.SelectedIndex = 0;
            ZT_REV.Text = "Zero Tool Ver."+ Properties.Settings.Default.Ver;


        }

        private void timer1_Tick(object sender, EventArgs e)
{
bool Key_State = IsKeyLocked(System.Windows.Forms.Keys.Escape);

            if (Key_State == true)
{

                if (Process.GetProcessesByName("ForceExit").Length > 0)
{               }
                else
{
if (DBG_ESC.Text == "OFF")
                    {
button4.PerformClick();
button2.PerformClick();
DBG_ESC.Text = "ON";
                    }
                }


}
            else
            {

                if (Process.GetProcessesByName("ForceExit").Length > 0)
                { }
                else
                {
                    if (DBG_ESC.Text == "ON")
                    {
                        button4.PerformClick();
                        button2.PerformClick();
                        DBG_ESC.Text = "OFF";
                    }
                }

            }

        }



        public new bool IsKeyLocked(System.Windows.Forms.Keys Key_Value)
{
bool Key_State = (GetKeyState((int) Key_Value) & 0x1B) != 0;
return Key_State;
        }

        private void Filesel_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();


            folderBrowserDialog.Description = "フォルダを選択してください。";


            folderBrowserDialog.SelectedPath = @"C:";


            folderBrowserDialog.ShowNewFolderButton = true;


            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                pacagetxt.Text = folderBrowserDialog.SelectedPath;
            }


            folderBrowserDialog.Dispose();

        }

        private void minimesel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();


            folderBrowserDialog.Description = "フォルダを選択してください。";


            folderBrowserDialog.SelectedPath = @"C:";


            folderBrowserDialog.ShowNewFolderButton = true;


            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                minimetxt.Text = folderBrowserDialog.SelectedPath;
            }


            folderBrowserDialog.Dispose();
        }

        private void tpsel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();


            folderBrowserDialog.Description = "フォルダを選択してください。";


            folderBrowserDialog.SelectedPath = @"C:";


            folderBrowserDialog.ShowNewFolderButton = true;


            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TPtxt.Text = folderBrowserDialog.SelectedPath;
            }


            folderBrowserDialog.Dispose();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            TAB.SelectedIndex = 1;
            DNS.Text = Properties.Settings.Default.DNS;
            ADDRS.Text = Properties.Settings.Default.ADDRS;
            SUBNET.Text = Properties.Settings.Default.SUBNET;
            SER.Text = Properties.Settings.Default.SER;
            KEY.Text = Properties.Settings.Default.KEY;
            SEAT.Text = Properties.Settings.Default.SEAT;
            RIG.Text = Properties.Settings.Default.RIG;



            DBG_SAVE.Text = "保存されていません";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (DBG_SAVE.Text == "保存されていません")
            {

                DialogResult result = MessageBox.Show("設定は保存されていません\n設定を保存せずに戻ってもよろしいですか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    TAB.SelectedIndex = 0;

                }
            }
            else
            {
                TAB.SelectedIndex = 0;
            }

            //Properties.Settings.Default.package = pacagetxt.Text;
            //Properties.Settings.Default.minime = minimetxt.Text;
            //Properties.Settings.Default.TP = TPtxt.Text;
            //Properties.Settings.Default.DNS = DNS.Text;
            //Properties.Settings.Default.ADDRS = ADDRS.Text;
            //Properties.Settings.Default.SUBNET = SUBNET.Text;
            //Properties.Settings.Default.SER = SER.Text;
            //Properties.Settings.Default.KEY = KEY.Text;
            //Properties.Settings.Default.Save();

            //bool ret = WritePrivateProfileString("dns", "default", DNS.Text, ".\\segatools.ini");
            //bool ret1 = WritePrivateProfileString("netenv", "addrSuffix", ADDRS.Text, ".\\segatools.ini");
            //bool ret2 = WritePrivateProfileString("keychip", "subnet", SUBNET.Text, ".\\segatools.ini");
            //bool ret3 = WritePrivateProfileString("ds", "serialNo", SER.Text, ".\\segatools.ini");
            //bool ret4 = WritePrivateProfileString("keychip", "id", KEY.Text, ".\\segatools.ini");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.package = pacagetxt.Text;
            Properties.Settings.Default.minime = minimetxt.Text;
            Properties.Settings.Default.TP = TPtxt.Text;
            Properties.Settings.Default.DNS = DNS.Text;
            Properties.Settings.Default.ADDRS = ADDRS.Text;
            Properties.Settings.Default.SUBNET = SUBNET.Text;
            Properties.Settings.Default.SER = SER.Text;
            Properties.Settings.Default.KEY = KEY.Text;
            Properties.Settings.Default.SEAT = SEAT.Text;
            Properties.Settings.Default.RIG = RIG.Text;

            Properties.Settings.Default.Save();

            if (pacagetxt.Text == "")
            {
                MessageBox.Show("packageフォルダが指定されていません", "エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                bool ret = WritePrivateProfileString("dns", "default", DNS.Text, pacagetxt.Text + @"\segatools.ini");
            }

            if (pacagetxt.Text == "")
            {
            }
            else
            {
                bool ret = WritePrivateProfileString("netenv", "addrSuffix", ADDRS.Text, pacagetxt.Text + @"\segatools.ini");

            }

            if (pacagetxt.Text == "")
            {
            }
            else
            {
                bool ret = WritePrivateProfileString("keychip", "subnet", SUBNET.Text, pacagetxt.Text + @"\segatools.ini");

            }

            if (pacagetxt.Text == "")
            {
            }
            else
            {
                bool ret = WritePrivateProfileString("ds", "serialNo", SER.Text, pacagetxt.Text + @"\segatools.ini");
            }

            if (pacagetxt.Text == "")
            {
            }
            else
            {
                bool ret = WritePrivateProfileString("keychip", "id", KEY.Text, pacagetxt.Text + @"\segatools.ini");

            }

            if (pacagetxt.Text == "")
            {
            }
            else
            {

                string selectedItem = SEAT.SelectedItem.ToString();
                if (selectedItem == "S")
                {

                    File.Copy(@".\Data\SEAT\S\eeprom.bin", pacagetxt.Text + @"\DEVICE\eeprom.bin", true);

                }else if(selectedItem == "A1") {

                    File.Copy(@".\Data\SEAT\A1\eeprom.bin", pacagetxt.Text + @"\DEVICE\eeprom.bin", true);

                }else if (selectedItem == "A2"){

                    File.Copy(@".\Data\SEAT\A2\eeprom.bin", pacagetxt.Text + @"\DEVICE\eeprom.bin", true);

                }else if (selectedItem == "B1"){

                    File.Copy(@".\Data\SEAT\B1\eeprom.bin", pacagetxt.Text + @"\DEVICE\eeprom.bin", true);

                }else if (selectedItem == "B2"){

                    File.Copy(@".\Data\SEAT\B2\eeprom.bin", pacagetxt.Text + @"\DEVICE\eeprom.bin", true);
                }


            }

            if (pacagetxt.Text == "")
            {
            }
            else
            {
                string selectedItem = RIG.SelectedItem.ToString();
                if (selectedItem == "JPN")
                {

                    bool ret = WritePrivateProfileString("ds", "region", "1", pacagetxt.Text + @"\segatools.ini");

                }
                else
                {

                    bool ret = WritePrivateProfileString("ds", "region", "4", pacagetxt.Text + @"\segatools.ini");


                }


            }

            MessageBox.Show("設定を保存しました", "保存完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBG_SAVE.Text = "保存完了";

        }

        private void btn_opentp_Click(object sender, EventArgs e)
        {

            if (TPtxt.Text == "") {

                ProcessStartInfo pInfo = new ProcessStartInfo();
                pInfo.FileName = @".\Data\TP\TeknoParrotUi";

                Process p = Process.Start(pInfo);
            }
            else
            {

                ProcessStartInfo pInfo = new ProcessStartInfo();
                pInfo.FileName = TPtxt.Text + @"\TeknoParrotUi.exe";

                Process p = Process.Start(pInfo);

            }


        }


            private void MAIN_Click(object sender, EventArgs e)
        {

        }

        private void DNS_TextChanged(object sender, EventArgs e)
        {
            DBG_SAVE.Text = "保存されていません";

        }

        private void ADDRS_TextChanged(object sender, EventArgs e)
        {
            DBG_SAVE.Text = "保存されていません";

        }

        private void SUBNET_TextChanged(object sender, EventArgs e)
        {
            DBG_SAVE.Text = "保存されていません";

        }

        private void SER_TextChanged(object sender, EventArgs e)
        {
            DBG_SAVE.Text = "保存されていません";

        }

        private void KEY_TextChanged(object sender, EventArgs e)
        {
            DBG_SAVE.Text = "保存されていません";

        }

        private void pacagetxt_TextChanged(object sender, EventArgs e)
        {
            DBG_SAVE.Text = "保存されていません";

        }

        private void minimetxt_TextChanged(object sender, EventArgs e)
        {
            DBG_SAVE.Text = "保存されていません";

        }

        private void TPtxt_TextChanged(object sender, EventArgs e)
        {
            DBG_SAVE.Text = "保存されていません";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBG_SAVE.Text = "保存されていません";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (pacagetxt.Text == "")
            {

                DialogResult result1 = MessageBox.Show("packageフォルダが指定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult result = MessageBox.Show("ServerBOXを起動しますか？", "ServerBOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (minimetxt.Text == "")
                    {
                        ProcessStartInfo pInfo = new ProcessStartInfo();

                        pInfo.FileName = @".\Data\minime\start.bat";

                        Process.Start(pInfo);
                    }
                    else
                    {
                        ProcessStartInfo pInfo = new ProcessStartInfo();

                        pInfo.FileName = minimetxt.Text + @"\start.bat";

                        Process.Start(pInfo);
                    }

                    if (TPtxt.Text == "")
                    {

                        ProcessStartInfo pInfo = new ProcessStartInfo();
                        pInfo.FileName = @".\Data\TP\TeknoParrotUi";
                        pInfo.Arguments = "--emuonly --profile=IDZv2.xml";

                        Process.Start(pInfo);

                    }
                    else
                    {

                        ProcessStartInfo pInfo = new ProcessStartInfo();
                        pInfo.FileName = TPtxt.Text + @"\TeknoParrotUi";
                        pInfo.Arguments = "--emuonly --profile=IDZv2.xml";

                        Process.Start(pInfo);

                    }

                    bool ret = WritePrivateProfileString("gpio", "dipsw1", "1", pacagetxt.Text + @"\segatools.ini");

                    Process.Start(@".\Data\Launch.exe",pacagetxt.Text);




                }
                else
                {


                    if (minimetxt.Text == "")
                    {
                        ProcessStartInfo pInfo = new ProcessStartInfo();

                        pInfo.FileName = @".\Data\minime\start.bat";

                        Process.Start(pInfo);
                    }
                    else
                    {
                        ProcessStartInfo pInfo = new ProcessStartInfo();

                        pInfo.FileName = minimetxt.Text + @"\start.bat";

                        Process.Start(pInfo);
                    }

                    if (TPtxt.Text == "")
                    {

                        ProcessStartInfo pInfo = new ProcessStartInfo();
                        pInfo.FileName = @".\Data\TP\TeknoParrotUi";
                        pInfo.Arguments = "--emuonly --profile=IDZv2.xml";

                        Process.Start(pInfo);

                    }
                    else
                    {

                        ProcessStartInfo pInfo = new ProcessStartInfo();
                        pInfo.FileName = TPtxt.Text + @"\TeknoParrotUi";
                        pInfo.Arguments = "--emuonly --profile=IDZv2.xml";

                        Process.Start(pInfo);

                    }

                    bool ret = WritePrivateProfileString("gpio", "dipsw1", "0", pacagetxt.Text + @"\segatools.ini");

                    Process.Start(@".\Data\Launch.exe", pacagetxt.Text);

                }

                TAB.SelectedIndex = 3;

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

            Process.Start(@".\Data\ForceExit.exe");

            TAB.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

