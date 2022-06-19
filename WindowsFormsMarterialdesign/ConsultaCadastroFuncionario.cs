using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMarterialdesign
{
    public partial class ConsultaCadastroFuncionario : MaterialForm
    {
        public ConsultaCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void ConsultaCadastroFuncionario_Load(object sender, EventArgs e)
        {
            this.FormClosed += ConsultaCadastroFuncionario_FormClosed;
        }

        private void ConsultaCadastroFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is MainWindow)
                {
                    MainWindow mainWindow = (MainWindow)oForm;
                    mainWindow.Show();
                    break;
                }
            }
        }
    }
}
