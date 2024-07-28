﻿using OnlineExaminationSystem.Login;
using System.Windows.Forms;

namespace OnlineExaminationSystem
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
