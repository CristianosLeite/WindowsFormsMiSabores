namespace WindowsFormsMarterialdesign
{
    partial class MainWindow
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.config_btn = new MaterialSkin.Controls.MaterialTabControl();
            this.home_btn = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cadastros_btn = new System.Windows.Forms.TabPage();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cadastrousuario_btn = new MaterialSkin.Controls.MaterialButton();
            this.consultausuario_btn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cadastrofuncionario_btn = new MaterialSkin.Controls.MaterialButton();
            this.consultafuncionario_btn = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cadastrofornecedor_btn = new MaterialSkin.Controls.MaterialButton();
            this.consultafornecedor_btn = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cadastroproduto_btn = new MaterialSkin.Controls.MaterialButton();
            this.consultaproduto_btn = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cadastrocliente_btn = new MaterialSkin.Controls.MaterialButton();
            this.consultacliente_btn = new MaterialSkin.Controls.MaterialButton();
            this.vendas_btn = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.configuracoes_btn = new System.Windows.Forms.TabPage();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.switchtheme_btn = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.config_btn.SuspendLayout();
            this.home_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cadastros_btn.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.vendas_btn.SuspendLayout();
            this.configuracoes_btn.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.SuspendLayout();
            // 
            // config_btn
            // 
            this.config_btn.Controls.Add(this.home_btn);
            this.config_btn.Controls.Add(this.cadastros_btn);
            this.config_btn.Controls.Add(this.vendas_btn);
            this.config_btn.Controls.Add(this.tabPage6);
            this.config_btn.Controls.Add(this.tabPage5);
            this.config_btn.Controls.Add(this.tabPage7);
            this.config_btn.Controls.Add(this.tabPage8);
            this.config_btn.Controls.Add(this.tabPage9);
            this.config_btn.Controls.Add(this.tabPage10);
            this.config_btn.Controls.Add(this.tabPage11);
            this.config_btn.Controls.Add(this.configuracoes_btn);
            this.config_btn.Depth = 0;
            this.config_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.config_btn.ImageList = this.imageList1;
            this.config_btn.Location = new System.Drawing.Point(3, 64);
            this.config_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.config_btn.Multiline = true;
            this.config_btn.Name = "config_btn";
            this.config_btn.SelectedIndex = 0;
            this.config_btn.Size = new System.Drawing.Size(1204, 533);
            this.config_btn.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.config_btn.TabIndex = 0;
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.Controls.Add(this.pictureBox1);
            this.home_btn.ImageKey = "simboloLogo.png";
            this.home_btn.Location = new System.Drawing.Point(4, 31);
            this.home_btn.Name = "home_btn";
            this.home_btn.Padding = new System.Windows.Forms.Padding(3);
            this.home_btn.Size = new System.Drawing.Size(1196, 498);
            this.home_btn.TabIndex = 0;
            this.home_btn.Text = "Início";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1190, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cadastros_btn
            // 
            this.cadastros_btn.Controls.Add(this.materialCard4);
            this.cadastros_btn.Controls.Add(this.materialLabel7);
            this.cadastros_btn.Controls.Add(this.panel1);
            this.cadastros_btn.ImageKey = "icons8-formato-96.png";
            this.cadastros_btn.Location = new System.Drawing.Point(4, 31);
            this.cadastros_btn.Name = "cadastros_btn";
            this.cadastros_btn.Padding = new System.Windows.Forms.Padding(3);
            this.cadastros_btn.Size = new System.Drawing.Size(1196, 498);
            this.cadastros_btn.TabIndex = 1;
            this.cadastros_btn.Text = "Cadastros";
            this.cadastros_btn.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialLabel4);
            this.materialCard4.Controls.Add(this.cadastrousuario_btn);
            this.materialCard4.Controls.Add(this.consultausuario_btn);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(48, 284);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MaximumSize = new System.Drawing.Size(215, 142);
            this.materialCard4.MinimumSize = new System.Drawing.Size(215, 142);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(215, 142);
            this.materialCard4.TabIndex = 7;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Silver;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(6, 6);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(63, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Usuários";
            // 
            // cadastrousuario_btn
            // 
            this.cadastrousuario_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cadastrousuario_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cadastrousuario_btn.Depth = 0;
            this.cadastrousuario_btn.HighEmphasis = true;
            this.cadastrousuario_btn.Icon = ((System.Drawing.Image)(resources.GetObject("cadastrousuario_btn.Icon")));
            this.cadastrousuario_btn.Location = new System.Drawing.Point(18, 43);
            this.cadastrousuario_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cadastrousuario_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cadastrousuario_btn.Name = "cadastrousuario_btn";
            this.cadastrousuario_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cadastrousuario_btn.Size = new System.Drawing.Size(90, 36);
            this.cadastrousuario_btn.TabIndex = 2;
            this.cadastrousuario_btn.Text = "Novo";
            this.cadastrousuario_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cadastrousuario_btn.UseAccentColor = false;
            this.cadastrousuario_btn.UseVisualStyleBackColor = true;
            this.cadastrousuario_btn.Click += new System.EventHandler(this.CadastroUsuarioBtn_Click);
            // 
            // consultausuario_btn
            // 
            this.consultausuario_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.consultausuario_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.consultausuario_btn.Depth = 0;
            this.consultausuario_btn.HighEmphasis = true;
            this.consultausuario_btn.Icon = ((System.Drawing.Image)(resources.GetObject("consultausuario_btn.Icon")));
            this.consultausuario_btn.Location = new System.Drawing.Point(18, 91);
            this.consultausuario_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.consultausuario_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.consultausuario_btn.Name = "consultausuario_btn";
            this.consultausuario_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.consultausuario_btn.Size = new System.Drawing.Size(134, 36);
            this.consultausuario_btn.TabIndex = 0;
            this.consultausuario_btn.Text = "Consultar";
            this.consultausuario_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.consultausuario_btn.UseAccentColor = false;
            this.consultausuario_btn.UseVisualStyleBackColor = true;
            this.consultausuario_btn.Click += new System.EventHandler(this.ConsultaUsuarioBtn_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel7.Location = new System.Drawing.Point(498, 4);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(158, 41);
            this.materialLabel7.TabIndex = 14;
            this.materialLabel7.Text = "Cadastros";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialCard5);
            this.panel1.Controls.Add(this.materialCard2);
            this.panel1.Controls.Add(this.materialCard3);
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 492);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.materialLabel5);
            this.materialCard5.Controls.Add(this.cadastrofuncionario_btn);
            this.materialCard5.Controls.Add(this.consultafuncionario_btn);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(871, 79);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MaximumSize = new System.Drawing.Size(215, 142);
            this.materialCard5.MinimumSize = new System.Drawing.Size(215, 142);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(215, 142);
            this.materialCard5.TabIndex = 13;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Silver;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(6, 6);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(93, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Funcionários";
            // 
            // cadastrofuncionario_btn
            // 
            this.cadastrofuncionario_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cadastrofuncionario_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cadastrofuncionario_btn.Depth = 0;
            this.cadastrofuncionario_btn.HighEmphasis = true;
            this.cadastrofuncionario_btn.Icon = ((System.Drawing.Image)(resources.GetObject("cadastrofuncionario_btn.Icon")));
            this.cadastrofuncionario_btn.Location = new System.Drawing.Point(18, 43);
            this.cadastrofuncionario_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cadastrofuncionario_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cadastrofuncionario_btn.Name = "cadastrofuncionario_btn";
            this.cadastrofuncionario_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cadastrofuncionario_btn.Size = new System.Drawing.Size(90, 36);
            this.cadastrofuncionario_btn.TabIndex = 2;
            this.cadastrofuncionario_btn.Text = "Novo";
            this.cadastrofuncionario_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cadastrofuncionario_btn.UseAccentColor = false;
            this.cadastrofuncionario_btn.UseVisualStyleBackColor = true;
            this.cadastrofuncionario_btn.Click += new System.EventHandler(this.CadastroFuncionarioBtn_Click);
            // 
            // consultafuncionario_btn
            // 
            this.consultafuncionario_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.consultafuncionario_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.consultafuncionario_btn.Depth = 0;
            this.consultafuncionario_btn.HighEmphasis = true;
            this.consultafuncionario_btn.Icon = ((System.Drawing.Image)(resources.GetObject("consultafuncionario_btn.Icon")));
            this.consultafuncionario_btn.Location = new System.Drawing.Point(18, 91);
            this.consultafuncionario_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.consultafuncionario_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.consultafuncionario_btn.Name = "consultafuncionario_btn";
            this.consultafuncionario_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.consultafuncionario_btn.Size = new System.Drawing.Size(134, 36);
            this.consultafuncionario_btn.TabIndex = 0;
            this.consultafuncionario_btn.Text = "Consultar";
            this.consultafuncionario_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.consultafuncionario_btn.UseAccentColor = false;
            this.consultafuncionario_btn.UseVisualStyleBackColor = true;
            this.consultafuncionario_btn.Click += new System.EventHandler(this.ConsultaFuncionarioBtn_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.cadastrofornecedor_btn);
            this.materialCard2.Controls.Add(this.consultafornecedor_btn);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(594, 79);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MaximumSize = new System.Drawing.Size(215, 142);
            this.materialCard2.MinimumSize = new System.Drawing.Size(215, 142);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(215, 142);
            this.materialCard2.TabIndex = 5;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Silver;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 6);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(96, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Fornecedores";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // cadastrofornecedor_btn
            // 
            this.cadastrofornecedor_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cadastrofornecedor_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cadastrofornecedor_btn.Depth = 0;
            this.cadastrofornecedor_btn.HighEmphasis = true;
            this.cadastrofornecedor_btn.Icon = ((System.Drawing.Image)(resources.GetObject("cadastrofornecedor_btn.Icon")));
            this.cadastrofornecedor_btn.Location = new System.Drawing.Point(18, 43);
            this.cadastrofornecedor_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cadastrofornecedor_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cadastrofornecedor_btn.Name = "cadastrofornecedor_btn";
            this.cadastrofornecedor_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cadastrofornecedor_btn.Size = new System.Drawing.Size(90, 36);
            this.cadastrofornecedor_btn.TabIndex = 2;
            this.cadastrofornecedor_btn.Text = "Novo";
            this.cadastrofornecedor_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cadastrofornecedor_btn.UseAccentColor = false;
            this.cadastrofornecedor_btn.UseVisualStyleBackColor = true;
            this.cadastrofornecedor_btn.Click += new System.EventHandler(this.CadastroFornecedorBtn_Click);
            // 
            // consultafornecedor_btn
            // 
            this.consultafornecedor_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.consultafornecedor_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.consultafornecedor_btn.Depth = 0;
            this.consultafornecedor_btn.HighEmphasis = true;
            this.consultafornecedor_btn.Icon = ((System.Drawing.Image)(resources.GetObject("consultafornecedor_btn.Icon")));
            this.consultafornecedor_btn.Location = new System.Drawing.Point(18, 91);
            this.consultafornecedor_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.consultafornecedor_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.consultafornecedor_btn.Name = "consultafornecedor_btn";
            this.consultafornecedor_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.consultafornecedor_btn.Size = new System.Drawing.Size(134, 36);
            this.consultafornecedor_btn.TabIndex = 0;
            this.consultafornecedor_btn.Text = "Consultar";
            this.consultafornecedor_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.consultafornecedor_btn.UseAccentColor = false;
            this.consultafornecedor_btn.UseVisualStyleBackColor = true;
            this.consultafornecedor_btn.Click += new System.EventHandler(this.ConsultaFornecedorBtn_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel3);
            this.materialCard3.Controls.Add(this.cadastroproduto_btn);
            this.materialCard3.Controls.Add(this.consultaproduto_btn);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(319, 79);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MaximumSize = new System.Drawing.Size(215, 142);
            this.materialCard3.MinimumSize = new System.Drawing.Size(215, 142);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(215, 142);
            this.materialCard3.TabIndex = 6;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Silver;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 6);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(65, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Produtos";
            // 
            // cadastroproduto_btn
            // 
            this.cadastroproduto_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cadastroproduto_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cadastroproduto_btn.Depth = 0;
            this.cadastroproduto_btn.HighEmphasis = true;
            this.cadastroproduto_btn.Icon = ((System.Drawing.Image)(resources.GetObject("cadastroproduto_btn.Icon")));
            this.cadastroproduto_btn.Location = new System.Drawing.Point(18, 43);
            this.cadastroproduto_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cadastroproduto_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cadastroproduto_btn.Name = "cadastroproduto_btn";
            this.cadastroproduto_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cadastroproduto_btn.Size = new System.Drawing.Size(90, 36);
            this.cadastroproduto_btn.TabIndex = 2;
            this.cadastroproduto_btn.Text = "Novo";
            this.cadastroproduto_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cadastroproduto_btn.UseAccentColor = false;
            this.cadastroproduto_btn.UseVisualStyleBackColor = true;
            this.cadastroproduto_btn.Click += new System.EventHandler(this.CadastroProdutoBtn_Click);
            // 
            // consultaproduto_btn
            // 
            this.consultaproduto_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.consultaproduto_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.consultaproduto_btn.Depth = 0;
            this.consultaproduto_btn.HighEmphasis = true;
            this.consultaproduto_btn.Icon = ((System.Drawing.Image)(resources.GetObject("consultaproduto_btn.Icon")));
            this.consultaproduto_btn.Location = new System.Drawing.Point(18, 91);
            this.consultaproduto_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.consultaproduto_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.consultaproduto_btn.Name = "consultaproduto_btn";
            this.consultaproduto_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.consultaproduto_btn.Size = new System.Drawing.Size(134, 36);
            this.consultaproduto_btn.TabIndex = 0;
            this.consultaproduto_btn.Text = "Consultar";
            this.consultaproduto_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.consultaproduto_btn.UseAccentColor = false;
            this.consultaproduto_btn.UseVisualStyleBackColor = true;
            this.consultaproduto_btn.Click += new System.EventHandler(this.ConsultaProdutoBtn_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.cadastrocliente_btn);
            this.materialCard1.Controls.Add(this.consultacliente_btn);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(45, 79);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MaximumSize = new System.Drawing.Size(215, 142);
            this.materialCard1.MinimumSize = new System.Drawing.Size(215, 142);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(215, 142);
            this.materialCard1.TabIndex = 4;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Silver;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Clientes";
            // 
            // cadastrocliente_btn
            // 
            this.cadastrocliente_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cadastrocliente_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cadastrocliente_btn.Depth = 0;
            this.cadastrocliente_btn.HighEmphasis = true;
            this.cadastrocliente_btn.Icon = ((System.Drawing.Image)(resources.GetObject("cadastrocliente_btn.Icon")));
            this.cadastrocliente_btn.Location = new System.Drawing.Point(18, 43);
            this.cadastrocliente_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cadastrocliente_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cadastrocliente_btn.Name = "cadastrocliente_btn";
            this.cadastrocliente_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cadastrocliente_btn.Size = new System.Drawing.Size(90, 36);
            this.cadastrocliente_btn.TabIndex = 2;
            this.cadastrocliente_btn.Text = "Novo";
            this.cadastrocliente_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cadastrocliente_btn.UseAccentColor = false;
            this.cadastrocliente_btn.UseVisualStyleBackColor = true;
            this.cadastrocliente_btn.Click += new System.EventHandler(this.CadastroClienteBtn_Click);
            // 
            // consultacliente_btn
            // 
            this.consultacliente_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.consultacliente_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.consultacliente_btn.Depth = 0;
            this.consultacliente_btn.HighEmphasis = true;
            this.consultacliente_btn.Icon = ((System.Drawing.Image)(resources.GetObject("consultacliente_btn.Icon")));
            this.consultacliente_btn.Location = new System.Drawing.Point(18, 91);
            this.consultacliente_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.consultacliente_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.consultacliente_btn.Name = "consultacliente_btn";
            this.consultacliente_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.consultacliente_btn.Size = new System.Drawing.Size(134, 36);
            this.consultacliente_btn.TabIndex = 0;
            this.consultacliente_btn.Text = "Consultar";
            this.consultacliente_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.consultacliente_btn.UseAccentColor = false;
            this.consultacliente_btn.UseVisualStyleBackColor = true;
            this.consultacliente_btn.Click += new System.EventHandler(this.ConsultaClienteBtn_Click);
            // 
            // vendas_btn
            // 
            this.vendas_btn.Controls.Add(this.materialButton2);
            this.vendas_btn.Controls.Add(this.materialButton1);
            this.vendas_btn.ImageKey = "icons8-finalizar-pedido-96.png";
            this.vendas_btn.Location = new System.Drawing.Point(4, 31);
            this.vendas_btn.Name = "vendas_btn";
            this.vendas_btn.Padding = new System.Windows.Forms.Padding(3);
            this.vendas_btn.Size = new System.Drawing.Size(1196, 498);
            this.vendas_btn.TabIndex = 2;
            this.vendas_btn.Text = "Vendas";
            this.vendas_btn.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(60, 120);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(158, 36);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "materialButton2";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(60, 44);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 31);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1196, 498);
            this.tabPage6.TabIndex = 12;
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1196, 498);
            this.tabPage5.TabIndex = 13;
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 31);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1196, 498);
            this.tabPage7.TabIndex = 14;
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 31);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1196, 498);
            this.tabPage8.TabIndex = 15;
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 31);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1196, 498);
            this.tabPage9.TabIndex = 16;
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 31);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1196, 498);
            this.tabPage10.TabIndex = 17;
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 31);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1196, 498);
            this.tabPage11.TabIndex = 18;
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // configuracoes_btn
            // 
            this.configuracoes_btn.Controls.Add(this.button1);
            this.configuracoes_btn.Controls.Add(this.materialCard6);
            this.configuracoes_btn.ImageKey = "icons8-config-64.png";
            this.configuracoes_btn.Location = new System.Drawing.Point(4, 31);
            this.configuracoes_btn.Name = "configuracoes_btn";
            this.configuracoes_btn.Padding = new System.Windows.Forms.Padding(3);
            this.configuracoes_btn.Size = new System.Drawing.Size(1196, 498);
            this.configuracoes_btn.TabIndex = 3;
            this.configuracoes_btn.Text = "Configurações";
            this.configuracoes_btn.UseVisualStyleBackColor = true;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.switchtheme_btn);
            this.materialCard6.Controls.Add(this.materialLabel6);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(17, 14);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(200, 100);
            this.materialCard6.TabIndex = 0;
            // 
            // switchtheme_btn
            // 
            this.switchtheme_btn.AutoSize = true;
            this.switchtheme_btn.Depth = 0;
            this.switchtheme_btn.Location = new System.Drawing.Point(14, 49);
            this.switchtheme_btn.Margin = new System.Windows.Forms.Padding(0);
            this.switchtheme_btn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchtheme_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchtheme_btn.Name = "switchtheme_btn";
            this.switchtheme_btn.Ripple = true;
            this.switchtheme_btn.Size = new System.Drawing.Size(106, 37);
            this.switchtheme_btn.TabIndex = 1;
            this.switchtheme_btn.Text = "Escuro";
            this.switchtheme_btn.UseVisualStyleBackColor = true;
            this.switchtheme_btn.CheckedChanged += new System.EventHandler(this.SwitchThemeBtn_CheckedChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(6, 6);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(42, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Tema";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cil-3d.png");
            this.imageList1.Images.SetKeyName(1, "cil-4k.png");
            this.imageList1.Images.SetKeyName(2, "cil-account-logout.png");
            this.imageList1.Images.SetKeyName(3, "cil-action-redo.png");
            this.imageList1.Images.SetKeyName(4, "cil-action-undo.png");
            this.imageList1.Images.SetKeyName(5, "cil-airplane-mode.png");
            this.imageList1.Images.SetKeyName(6, "cil-airplane-mode-off.png");
            this.imageList1.Images.SetKeyName(7, "cil-alarm.png");
            this.imageList1.Images.SetKeyName(8, "cil-align-center.png");
            this.imageList1.Images.SetKeyName(9, "cil-align-left.png");
            this.imageList1.Images.SetKeyName(10, "cil-align-right.png");
            this.imageList1.Images.SetKeyName(11, "cil-arrow-bottom.png");
            this.imageList1.Images.SetKeyName(12, "cil-arrow-bottom-2.png");
            this.imageList1.Images.SetKeyName(13, "cil-arrow-circle-bottom.png");
            this.imageList1.Images.SetKeyName(14, "cil-arrow-circle-left.png");
            this.imageList1.Images.SetKeyName(15, "cil-arrow-circle-right.png");
            this.imageList1.Images.SetKeyName(16, "cil-arrow-circle-top.png");
            this.imageList1.Images.SetKeyName(17, "cil-arrow-left.png");
            this.imageList1.Images.SetKeyName(18, "cil-arrow-right.png");
            this.imageList1.Images.SetKeyName(19, "cil-arrow-top.png");
            this.imageList1.Images.SetKeyName(20, "cil-at.png");
            this.imageList1.Images.SetKeyName(21, "cil-av-timer.png");
            this.imageList1.Images.SetKeyName(22, "cil-ban.png");
            this.imageList1.Images.SetKeyName(23, "cil-battery-0.png");
            this.imageList1.Images.SetKeyName(24, "cil-battery-3.png");
            this.imageList1.Images.SetKeyName(25, "cil-battery-5.png");
            this.imageList1.Images.SetKeyName(26, "cil-battery-alert.png");
            this.imageList1.Images.SetKeyName(27, "cil-battery-slash.png");
            this.imageList1.Images.SetKeyName(28, "cil-bell.png");
            this.imageList1.Images.SetKeyName(29, "cil-bluetooth.png");
            this.imageList1.Images.SetKeyName(30, "cil-briefcase.png");
            this.imageList1.Images.SetKeyName(31, "cil-browser.png");
            this.imageList1.Images.SetKeyName(32, "cil-calendar-check.png");
            this.imageList1.Images.SetKeyName(33, "cil-camera.png");
            this.imageList1.Images.SetKeyName(34, "cil-camera-roll.png");
            this.imageList1.Images.SetKeyName(35, "cil-caret-bottom.png");
            this.imageList1.Images.SetKeyName(36, "cil-caret-left.png");
            this.imageList1.Images.SetKeyName(37, "cil-caret-right.png");
            this.imageList1.Images.SetKeyName(38, "cil-caret-top.png");
            this.imageList1.Images.SetKeyName(39, "cil-cart.png");
            this.imageList1.Images.SetKeyName(40, "cil-cast.png");
            this.imageList1.Images.SetKeyName(41, "cil-chart.png");
            this.imageList1.Images.SetKeyName(42, "cil-chart-line.png");
            this.imageList1.Images.SetKeyName(43, "cil-chart-pie.png");
            this.imageList1.Images.SetKeyName(44, "cil-chat-bubble.png");
            this.imageList1.Images.SetKeyName(45, "cil-check.png");
            this.imageList1.Images.SetKeyName(46, "cil-check-alt.png");
            this.imageList1.Images.SetKeyName(47, "cil-check-circle.png");
            this.imageList1.Images.SetKeyName(48, "cil-chevron-bottom.png");
            this.imageList1.Images.SetKeyName(49, "cil-chevron-circle-down-alt.png");
            this.imageList1.Images.SetKeyName(50, "cil-chevron-circle-left-alt.png");
            this.imageList1.Images.SetKeyName(51, "cil-chevron-circle-right-alt.png");
            this.imageList1.Images.SetKeyName(52, "cil-chevron-circle-up-alt.png");
            this.imageList1.Images.SetKeyName(53, "cil-chevron-double-down.png");
            this.imageList1.Images.SetKeyName(54, "cil-chevron-double-left.png");
            this.imageList1.Images.SetKeyName(55, "cil-chevron-double-right.png");
            this.imageList1.Images.SetKeyName(56, "cil-chevron-double-up.png");
            this.imageList1.Images.SetKeyName(57, "cil-chevron-double-up-alt.png");
            this.imageList1.Images.SetKeyName(58, "cil-chevron-left.png");
            this.imageList1.Images.SetKeyName(59, "cil-chevron-right.png");
            this.imageList1.Images.SetKeyName(60, "cil-chevron-top.png");
            this.imageList1.Images.SetKeyName(61, "cil-circle.png");
            this.imageList1.Images.SetKeyName(62, "cil-clipboard.png");
            this.imageList1.Images.SetKeyName(63, "cil-clock.png");
            this.imageList1.Images.SetKeyName(64, "cil-clone.png");
            this.imageList1.Images.SetKeyName(65, "cil-closed-captioning.png");
            this.imageList1.Images.SetKeyName(66, "cil-cloud-download.png");
            this.imageList1.Images.SetKeyName(67, "cil-cloud-upload.png");
            this.imageList1.Images.SetKeyName(68, "cil-cloudy.png");
            this.imageList1.Images.SetKeyName(69, "cil-code.png");
            this.imageList1.Images.SetKeyName(70, "cil-coffee.png");
            this.imageList1.Images.SetKeyName(71, "cil-comment-bubble.png");
            this.imageList1.Images.SetKeyName(72, "cil-comment-square.png");
            this.imageList1.Images.SetKeyName(73, "cil-credit-card.png");
            this.imageList1.Images.SetKeyName(74, "cil-cursor.png");
            this.imageList1.Images.SetKeyName(75, "cil-cursor-move.png");
            this.imageList1.Images.SetKeyName(76, "cil-cut.png");
            this.imageList1.Images.SetKeyName(77, "cil-data-transfer-down.png");
            this.imageList1.Images.SetKeyName(78, "cil-data-transfer-up.png");
            this.imageList1.Images.SetKeyName(79, "cil-deaf.png");
            this.imageList1.Images.SetKeyName(80, "cil-description.png");
            this.imageList1.Images.SetKeyName(81, "cil-devices.png");
            this.imageList1.Images.SetKeyName(82, "cil-dialpad.png");
            this.imageList1.Images.SetKeyName(83, "cil-dog.png");
            this.imageList1.Images.SetKeyName(84, "cil-door.png");
            this.imageList1.Images.SetKeyName(85, "cil-double-quote-sans-left.png");
            this.imageList1.Images.SetKeyName(86, "cil-double-quote-sans-right.png");
            this.imageList1.Images.SetKeyName(87, "cil-drop.png");
            this.imageList1.Images.SetKeyName(88, "cil-envelope-closed.png");
            this.imageList1.Images.SetKeyName(89, "cil-envelope-letter.png");
            this.imageList1.Images.SetKeyName(90, "cil-envelope-open.png");
            this.imageList1.Images.SetKeyName(91, "cil-equalizer.png");
            this.imageList1.Images.SetKeyName(92, "cil-ethernet.png");
            this.imageList1.Images.SetKeyName(93, "cil-exit-to-app.png");
            this.imageList1.Images.SetKeyName(94, "cil-expand-down.png");
            this.imageList1.Images.SetKeyName(95, "cil-expand-left.png");
            this.imageList1.Images.SetKeyName(96, "cil-expand-right.png");
            this.imageList1.Images.SetKeyName(97, "cil-expand-up.png");
            this.imageList1.Images.SetKeyName(98, "cil-exposure.png");
            this.imageList1.Images.SetKeyName(99, "cil-external-link.png");
            this.imageList1.Images.SetKeyName(100, "cil-face-dead.png");
            this.imageList1.Images.SetKeyName(101, "cil-featured-playlist.png");
            this.imageList1.Images.SetKeyName(102, "cil-file.png");
            this.imageList1.Images.SetKeyName(103, "cil-find-in-page.png");
            this.imageList1.Images.SetKeyName(104, "cil-fingerprint.png");
            this.imageList1.Images.SetKeyName(105, "cil-fire.png");
            this.imageList1.Images.SetKeyName(106, "cil-flip-to-back.png");
            this.imageList1.Images.SetKeyName(107, "cil-folder.png");
            this.imageList1.Images.SetKeyName(108, "cil-folder-open.png");
            this.imageList1.Images.SetKeyName(109, "cil-frown.png");
            this.imageList1.Images.SetKeyName(110, "cil-gamepad.png");
            this.imageList1.Images.SetKeyName(111, "cil-hand-point-down.png");
            this.imageList1.Images.SetKeyName(112, "cil-hand-point-left.png");
            this.imageList1.Images.SetKeyName(113, "cil-hand-point-right.png");
            this.imageList1.Images.SetKeyName(114, "cil-hand-point-up.png");
            this.imageList1.Images.SetKeyName(115, "cil-hd.png");
            this.imageList1.Images.SetKeyName(116, "cil-hdr.png");
            this.imageList1.Images.SetKeyName(117, "cil-headphones.png");
            this.imageList1.Images.SetKeyName(118, "cil-heart.png");
            this.imageList1.Images.SetKeyName(119, "cil-highligt.png");
            this.imageList1.Images.SetKeyName(120, "cil-history.png");
            this.imageList1.Images.SetKeyName(121, "cil-home.png");
            this.imageList1.Images.SetKeyName(122, "cil-house.png");
            this.imageList1.Images.SetKeyName(123, "cil-image1.png");
            this.imageList1.Images.SetKeyName(124, "cil-image-plus.png");
            this.imageList1.Images.SetKeyName(125, "cil-infinity.png");
            this.imageList1.Images.SetKeyName(126, "cil-input.png");
            this.imageList1.Images.SetKeyName(127, "cil-input-power.png");
            this.imageList1.Images.SetKeyName(128, "cil-justify-center.png");
            this.imageList1.Images.SetKeyName(129, "cil-justify-left.png");
            this.imageList1.Images.SetKeyName(130, "cil-justify-right.png");
            this.imageList1.Images.SetKeyName(131, "cil-keyboard.png");
            this.imageList1.Images.SetKeyName(132, "cil-laptop.png");
            this.imageList1.Images.SetKeyName(133, "cil-layers.png");
            this.imageList1.Images.SetKeyName(134, "cil-level-down.png");
            this.imageList1.Images.SetKeyName(135, "cil-level-up.png");
            this.imageList1.Images.SetKeyName(136, "cil-library.png");
            this.imageList1.Images.SetKeyName(137, "cil-library-add.png");
            this.imageList1.Images.SetKeyName(138, "cil-lightbulb.png");
            this.imageList1.Images.SetKeyName(139, "cil-link.png");
            this.imageList1.Images.SetKeyName(140, "cil-link-alt.png");
            this.imageList1.Images.SetKeyName(141, "cil-link-broken.png");
            this.imageList1.Images.SetKeyName(142, "cil-location-pin.png");
            this.imageList1.Images.SetKeyName(143, "cil-lock-locked.png");
            this.imageList1.Images.SetKeyName(144, "cil-lock-unlocked.png");
            this.imageList1.Images.SetKeyName(145, "cil-loop.png");
            this.imageList1.Images.SetKeyName(146, "cil-loop-1.png");
            this.imageList1.Images.SetKeyName(147, "cil-loop-circular.png");
            this.imageList1.Images.SetKeyName(148, "cil-low-vision.png");
            this.imageList1.Images.SetKeyName(149, "cil-magnifying-glass.png");
            this.imageList1.Images.SetKeyName(150, "cil-map.png");
            this.imageList1.Images.SetKeyName(151, "cil-media-eject.png");
            this.imageList1.Images.SetKeyName(152, "cil-media-pause.png");
            this.imageList1.Images.SetKeyName(153, "cil-media-play.png");
            this.imageList1.Images.SetKeyName(154, "cil-media-skip-backward.png");
            this.imageList1.Images.SetKeyName(155, "cil-media-skip-forward.png");
            this.imageList1.Images.SetKeyName(156, "cil-media-step-backward.png");
            this.imageList1.Images.SetKeyName(157, "cil-media-step-forward.png");
            this.imageList1.Images.SetKeyName(158, "cil-media-stop.png");
            this.imageList1.Images.SetKeyName(159, "cil-medical-cross.png");
            this.imageList1.Images.SetKeyName(160, "cil-meh.png");
            this.imageList1.Images.SetKeyName(161, "cil-menu.png");
            this.imageList1.Images.SetKeyName(162, "cil-microphone.png");
            this.imageList1.Images.SetKeyName(163, "cil-minus.png");
            this.imageList1.Images.SetKeyName(164, "cil-mobile.png");
            this.imageList1.Images.SetKeyName(165, "cil-mobile-landscape.png");
            this.imageList1.Images.SetKeyName(166, "cil-mood-bad.png");
            this.imageList1.Images.SetKeyName(167, "cil-mood-good.png");
            this.imageList1.Images.SetKeyName(168, "cil-mood-very-bad.png");
            this.imageList1.Images.SetKeyName(169, "cil-mood-very-good.png");
            this.imageList1.Images.SetKeyName(170, "cil-moon.png");
            this.imageList1.Images.SetKeyName(171, "cil-mouse.png");
            this.imageList1.Images.SetKeyName(172, "cil-move.png");
            this.imageList1.Images.SetKeyName(173, "cil-movie.png");
            this.imageList1.Images.SetKeyName(174, "cil-mug.png");
            this.imageList1.Images.SetKeyName(175, "cil-mug-tea.png");
            this.imageList1.Images.SetKeyName(176, "cil-notes.png");
            this.imageList1.Images.SetKeyName(177, "cil-options.png");
            this.imageList1.Images.SetKeyName(178, "cil-options-horizontal.png");
            this.imageList1.Images.SetKeyName(179, "cil-paint-bucket.png");
            this.imageList1.Images.SetKeyName(180, "cil-paperclip.png");
            this.imageList1.Images.SetKeyName(181, "cil-paper-plane.png");
            this.imageList1.Images.SetKeyName(182, "cil-paragraph.png");
            this.imageList1.Images.SetKeyName(183, "cil-pen-alt.png");
            this.imageList1.Images.SetKeyName(184, "cil-pencil.png");
            this.imageList1.Images.SetKeyName(185, "cil-people.png");
            this.imageList1.Images.SetKeyName(186, "cil-phone.png");
            this.imageList1.Images.SetKeyName(187, "cil-pin.png");
            this.imageList1.Images.SetKeyName(188, "cil-plus.png");
            this.imageList1.Images.SetKeyName(189, "cil-power-standby.png");
            this.imageList1.Images.SetKeyName(190, "cil-print.png");
            this.imageList1.Images.SetKeyName(191, "cil-rectangle.png");
            this.imageList1.Images.SetKeyName(192, "cil-reload.png");
            this.imageList1.Images.SetKeyName(193, "cil-remove.png");
            this.imageList1.Images.SetKeyName(194, "cil-rss.png");
            this.imageList1.Images.SetKeyName(195, "cil-satelite.png");
            this.imageList1.Images.SetKeyName(196, "cil-save.png");
            this.imageList1.Images.SetKeyName(197, "cil-screen-desktop.png");
            this.imageList1.Images.SetKeyName(198, "cil-screen-smartphone.png");
            this.imageList1.Images.SetKeyName(199, "cil-settings.png");
            this.imageList1.Images.SetKeyName(200, "cil-share.png");
            this.imageList1.Images.SetKeyName(201, "cil-share-boxed.png");
            this.imageList1.Images.SetKeyName(202, "cil-signal-cellular-0.png");
            this.imageList1.Images.SetKeyName(203, "cil-signal-cellular-3.png");
            this.imageList1.Images.SetKeyName(204, "cil-size-grip.png");
            this.imageList1.Images.SetKeyName(205, "cil-smile.png");
            this.imageList1.Images.SetKeyName(206, "cil-speaker.png");
            this.imageList1.Images.SetKeyName(207, "cil-speech.png");
            this.imageList1.Images.SetKeyName(208, "cil-speedometer.png");
            this.imageList1.Images.SetKeyName(209, "cil-star.png");
            this.imageList1.Images.SetKeyName(210, "cil-tags.png");
            this.imageList1.Images.SetKeyName(211, "cil-task.png");
            this.imageList1.Images.SetKeyName(212, "cil-terminal.png");
            this.imageList1.Images.SetKeyName(213, "cil-text.png");
            this.imageList1.Images.SetKeyName(214, "cil-text-size.png");
            this.imageList1.Images.SetKeyName(215, "cil-text-square.png");
            this.imageList1.Images.SetKeyName(216, "cil-thumb-down.png");
            this.imageList1.Images.SetKeyName(217, "cil-thumb-up.png");
            this.imageList1.Images.SetKeyName(218, "cil-transfer.png");
            this.imageList1.Images.SetKeyName(219, "cil-triangle.png");
            this.imageList1.Images.SetKeyName(220, "cil-truck.png");
            this.imageList1.Images.SetKeyName(221, "cil-user.png");
            this.imageList1.Images.SetKeyName(222, "cil-user-female.png");
            this.imageList1.Images.SetKeyName(223, "cil-user-follow.png");
            this.imageList1.Images.SetKeyName(224, "cil-user-unfollow.png");
            this.imageList1.Images.SetKeyName(225, "cil-vertical-align-bottom.png");
            this.imageList1.Images.SetKeyName(226, "cil-view-column.png");
            this.imageList1.Images.SetKeyName(227, "cil-view-module.png");
            this.imageList1.Images.SetKeyName(228, "cil-view-quilt.png");
            this.imageList1.Images.SetKeyName(229, "cil-view-stream.png");
            this.imageList1.Images.SetKeyName(230, "cil-voice-over-record.png");
            this.imageList1.Images.SetKeyName(231, "cil-volume-high.png");
            this.imageList1.Images.SetKeyName(232, "cil-volume-low.png");
            this.imageList1.Images.SetKeyName(233, "cil-volume-off.png");
            this.imageList1.Images.SetKeyName(234, "cil-wallet.png");
            this.imageList1.Images.SetKeyName(235, "cil-watch.png");
            this.imageList1.Images.SetKeyName(236, "cil-wifi-signal-0.png");
            this.imageList1.Images.SetKeyName(237, "cil-wifi-signal-1.png");
            this.imageList1.Images.SetKeyName(238, "cil-wifi-signal-2.png");
            this.imageList1.Images.SetKeyName(239, "cil-wifi-signal-4.png");
            this.imageList1.Images.SetKeyName(240, "cil-wifi-signal-off.png");
            this.imageList1.Images.SetKeyName(241, "cil-window-maximize.png");
            this.imageList1.Images.SetKeyName(242, "cil-window-minimize.png");
            this.imageList1.Images.SetKeyName(243, "cil-window-restore.png");
            this.imageList1.Images.SetKeyName(244, "cil-wrap-text.png");
            this.imageList1.Images.SetKeyName(245, "cil-x.png");
            this.imageList1.Images.SetKeyName(246, "cil-x-circle.png");
            this.imageList1.Images.SetKeyName(247, "cil-zoom-in.png");
            this.imageList1.Images.SetKeyName(248, "cil-zoom-out.png");
            this.imageList1.Images.SetKeyName(249, "icon_close.png");
            this.imageList1.Images.SetKeyName(250, "icon_maximize.png");
            this.imageList1.Images.SetKeyName(251, "icon_menu.png");
            this.imageList1.Images.SetKeyName(252, "icon_minimize.png");
            this.imageList1.Images.SetKeyName(253, "icon_restore.png");
            this.imageList1.Images.SetKeyName(254, "icon_settings.png");
            this.imageList1.Images.SetKeyName(255, "icons8-casa-96.png");
            this.imageList1.Images.SetKeyName(256, "simboloLogo.png");
            this.imageList1.Images.SetKeyName(257, "icons8-novo-documento-64.png");
            this.imageList1.Images.SetKeyName(258, "icons8-formato-80.png");
            this.imageList1.Images.SetKeyName(259, "icons8-formato-96.png");
            this.imageList1.Images.SetKeyName(260, "icons8-finalizar-pedido-96.png");
            this.imageList1.Images.SetKeyName(261, "icons8-config-64.png");
            this.imageList1.Images.SetKeyName(262, "icons8-usuário-90.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 600);
            this.Controls.Add(this.config_btn);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.config_btn;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1210, 600);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria Mi Sabores";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.config_btn.ResumeLayout(false);
            this.home_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cadastros_btn.ResumeLayout(false);
            this.cadastros_btn.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.vendas_btn.ResumeLayout(false);
            this.vendas_btn.PerformLayout();
            this.configuracoes_btn.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl config_btn;
        private System.Windows.Forms.TabPage home_btn;
        private System.Windows.Forms.TabPage cadastros_btn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage vendas_btn;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton cadastrocliente_btn;
        private MaterialSkin.Controls.MaterialButton consultacliente_btn;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton cadastrofornecedor_btn;
        private MaterialSkin.Controls.MaterialButton consultafornecedor_btn;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton cadastrousuario_btn;
        private MaterialSkin.Controls.MaterialButton consultausuario_btn;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton cadastroproduto_btn;
        private MaterialSkin.Controls.MaterialButton consultaproduto_btn;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton cadastrofuncionario_btn;
        private MaterialSkin.Controls.MaterialButton consultafuncionario_btn;
        private System.Windows.Forms.TabPage configuracoes_btn;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TabPage tabPage6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        public MaterialSkin.Controls.MaterialSwitch switchtheme_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.Button button1;
    }
}

