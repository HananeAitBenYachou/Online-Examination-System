﻿using OnlineExaminationSystem.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Instructor_system
{
    public partial class FrmHome : Form
    {
        private readonly FrmLogin _loginForm;

        public FrmHome(FrmLogin loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }
    }
}
