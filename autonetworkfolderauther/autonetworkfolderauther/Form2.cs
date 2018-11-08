﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Diagnostics;

namespace autonetworkfolderauther
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 고급 공유 설정 오픈
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("control.exe /name Microsoft.NetworkAndSharingCenter /page Advanced");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 나눔 글꼴 설정
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("NanumBarunGothic.ttf");

            Font NanumFont = new Font(privateFont.Families[0], 10f);

            button1.Font = NanumFont;
            label2.Font = NanumFont;
        }
    }
}
