﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SplashForm form = new SplashForm();
            form.Show();

            this.Close();
            GenerateNameForm form2 = new GenerateNameForm();
            form.Show();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
