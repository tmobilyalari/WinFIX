using System;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void sfcbtn(object sender, RoutedEventArgs e)
        {
            string strCmdText;
            //For Testing
            strCmdText = "/K sfc /scannow & exit";

            System.Diagnostics.Process.Start("CMD.exe", strCmdText).WaitForExit();
        }

        private void cmdbtn(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\cmd.exe").WaitForExit();
        }

        private void dism1btn(object sender, RoutedEventArgs e)
        {
            string strCmdText;
            //For Testing
            strCmdText = "/K dism /online /Cleanup-Image /Restorehealth & exit";

            System.Diagnostics.Process.Start("CMD.exe", strCmdText).WaitForExit();
        }

        private void ChkdskClick(object sender, RoutedEventArgs e)
        {
            string strCmdText;
            strCmdText = ("/k CHKDSK C: /F /R /X & exit");
            System.Diagnostics.Process.Start("CMD.exe", strCmdText).WaitForExit();
        }

        private void Temp_Delete_Click(object sender, RoutedEventArgs e)
        {
            string strCmdText;
            strCmdText = ("/C del /F /S /Q C:\\Windows\\Temp & exit");
            System.Diagnostics.Process.Start("CMD.exe", strCmdText).WaitForExit();
            string strCmdText1;
            strCmdText1 = ("/C del /F /S /Q %Temp% & exit");
            System.Diagnostics.Process.Start("CMD.exe", strCmdText1).WaitForExit();
            string strCmdText2;
            strCmdText2 = ("/C del /F /S /Q C:\\Windows\\SoftwareDistribution\\Download & exit");
            System.Diagnostics.Process.Start("CMD.exe", strCmdText2).WaitForExit();
            string strCmdText3;
            strCmdText3 = ("/C del /F /S /Q C:\\Windows\\Prefetch & exit");
            System.Diagnostics.Process.Start("CMD.exe", strCmdText3).WaitForExit();
            string strCmdText4;
            strCmdText4 = ("/C RD /S /Q C:\\Windows\\Temp & exit");
            System.Diagnostics.Process.Start("CMD.exe", strCmdText4).WaitForExit();
            string strCmdText5;
            strCmdText5 = ("/C RD /S /Q %Temp% & exit");
            System.Diagnostics.Process.Start("CMD.exe", strCmdText5).WaitForExit();
            string strCmdText6;
            strCmdText6 = ("/C RD /S /Q C:\\Windows\\SoftwareDistribution\\Download & exit");
            System.Diagnostics.Process.Start("CMD.exe", strCmdText6).WaitForExit();
            string strCmdText7;
            strCmdText7 = ("/C RD /S /Q C:\\Windows\\Prefetch & exit");
            System.Diagnostics.Process.Start("CMD.exe", strCmdText7).WaitForExit();

            
        }

        /*private void dism1btn(object sender, RoutedEventArgs e/*, Process plinkProcess)
        {/*
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            if (e is null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            if (plinkProcess is null)
            {
                throw new ArgumentNullException(nameof(plinkProcess));
            }

            switch (plinkProcess)
            {
                case null:
                    throw new ArgumentNullException(nameof(plinkProcess));
                default:
                    {
                        ProcessStartInfo psi = new ProcessStartInfo("cmd")
                        {
                            CreateNoWindow = true,
                            ErrorDialog = false,
                            RedirectStandardError = true,
                            RedirectStandardInput = true,
                            RedirectStandardOutput = true,
                            UseShellExecute = false,

                        };


                        using (Process process = new Process
                        {
                            StartInfo = psi,

                        })
                        {
                            process.StartInfo.Verb = "runas";
                            _ = process.Start();

                            using (System.IO.StreamWriter inputWriter = process.StandardInput)
                            {
                                using (System.IO.StreamReader outputReader = process.StandardOutput)
                                {
                                    inputWriter.WriteLine("dism /online /Cleanup-Image /Restorehealth");
                                    inputWriter.Flush();
                                    process.WaitForExit();

                                    string strOutput = outputReader.ReadToEnd();
                                }
                            }

                            process.Close();
                        }

                        break;
                    }
            }

 Çalışan
        }*/

    }
}
