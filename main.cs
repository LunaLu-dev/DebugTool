using System;
using System.Windows.Forms;

namespace myform
{
    class Program
    {
        static void Main(string[] args)
        {
            bool SfcC = false;
            bool DismC = false;

            Form myform = new Form();
            Button SFC = new Button()
            {
                Height = 100,
                Width = 100,
                Text = "SFC",
                Location = new System.Drawing.Point(10, 10)
            };
            SFC.Click += (o, s) =>
            {
                if(SfcC == false){
                    SfcC = true;
                    SFC.Text = "SFC ✓";
                }else if(SfcC == true){
                    SfcC = false;
                    SFC.Text = "SFC";
                }
            };

            Button DISM = new Button()
            {
                Height = 100,
                Width = 100,
                Text = "DISM",
                Location = new System.Drawing.Point(120, 10)
            };
            DISM.Click += (o ,s) =>
            {
                if(DismC == false){
                    DismC = true;
                    DISM.Text = "DISM ✓";
                }else if(DismC == true){
                    DismC = false;
                    DISM.Text = "DISM";
                }





                /*var process = System.Diagnostics.Process.Start("CMD.exe", "/C sfc /scannow");
                process.WaitForExit();
                Console.WriteLine("System File Checker - Done");*/
            };


            myform.Controls.Add(SFC);
            myform.Controls.Add(DISM);
            myform.ShowDialog();

            while (myform.Created)
            {

            }
        }
    }
}