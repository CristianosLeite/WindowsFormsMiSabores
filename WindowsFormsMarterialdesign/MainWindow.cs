using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMarterialdesign
{
    public partial class MainWindow : MaterialForm
    {


        public MainWindow()
        {
            InitializeComponent();

            var darktheme = MaterialSkinManager.Themes.DARK;
            var lighttheme = MaterialSkinManager.Themes.LIGHT;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            if (switchtheme_btn.Checked == true)
            {
                materialSkinManager.Theme = darktheme;
            }
            else
            {
                materialSkinManager.Theme = lighttheme;
            }
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber100, Primary.Orange500, Primary.BlueGrey500, Accent.Orange100, TextShade.BLACK);
        }

        MaterialSkinManager ThemeMananger = MaterialSkinManager.Instance;

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        public void SwitchThemeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (switchtheme_btn.Checked)
            {
                ThemeMananger.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                ThemeMananger.Theme = MaterialSkinManager.Themes.LIGHT;
            }

        }

        private void CadastroClienteBtn_Click(object sender, EventArgs e)
        {
            Hide();
            NovoCadastroCliente novoCadastroCliente = new NovoCadastroCliente();
            novoCadastroCliente.Show();
        }

        private void ConsultaClienteBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ConsultaCadastroCliente consultaCadastroCliente = new ConsultaCadastroCliente();
            consultaCadastroCliente.Show();
        }

        private void CadastroFornecedorBtn_Click(object sender, EventArgs e)
        {
            Hide();
            NovoCadastroFornecedor novoCadastroFornecedor = new NovoCadastroFornecedor();
            novoCadastroFornecedor.Show();
        }

        private void ConsultaFornecedorBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ConsultaCadastroFornecedor consultaCadastroFornecedor = new ConsultaCadastroFornecedor();
            consultaCadastroFornecedor.Show();
        }

        private void CadastroUsuarioBtn_Click(object sender, EventArgs e)
        {
            Hide();
            NovoCadastroUsuario novoCadastroUsuario = new NovoCadastroUsuario();
            novoCadastroUsuario.Show();
        }

        private void ConsultaUsuarioBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ConsultaCadastroUsuario consultaCadastroUsuario = new ConsultaCadastroUsuario();
            consultaCadastroUsuario.Show();
        }

        private void CadastroProdutoBtn_Click(object sender, EventArgs e)
        {
            Hide();
            NovoCadastroProduto novoCadastroProduto = new NovoCadastroProduto();
            novoCadastroProduto.Show();
        }

        private void ConsultaProdutoBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ConsultaCadastroProduto consultaCadastroProduto = new ConsultaCadastroProduto();
            consultaCadastroProduto.Show();
        }

        private void CadastroFuncionarioBtn_Click(object sender, EventArgs e)
        {
            Hide();
            NovoCadastroFuncionario novoCadastroFuncionario = new NovoCadastroFuncionario();
            novoCadastroFuncionario.Show();
        }

        private void ConsultaFuncionarioBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ConsultaCadastroFuncionario consultaCadastroFuncionario = new ConsultaCadastroFuncionario();
            consultaCadastroFuncionario.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
