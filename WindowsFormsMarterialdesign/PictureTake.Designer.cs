namespace WindowsFormsMarterialdesign
{
    partial class PictureTake
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureTake));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cameracomboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.camerapictureBox = new System.Windows.Forms.PictureBox();
            this.gravarcamerabtn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.camerapictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Camera";
            // 
            // cameracomboBox
            // 
            this.cameracomboBox.AutoResize = false;
            this.cameracomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cameracomboBox.Depth = 0;
            this.cameracomboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cameracomboBox.DropDownHeight = 118;
            this.cameracomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameracomboBox.DropDownWidth = 121;
            this.cameracomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cameracomboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cameracomboBox.FormattingEnabled = true;
            this.cameracomboBox.IntegralHeight = false;
            this.cameracomboBox.ItemHeight = 29;
            this.cameracomboBox.Location = new System.Drawing.Point(68, 67);
            this.cameracomboBox.MaxDropDownItems = 4;
            this.cameracomboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.cameracomboBox.Name = "cameracomboBox";
            this.cameracomboBox.Size = new System.Drawing.Size(201, 35);
            this.cameracomboBox.StartIndex = 0;
            this.cameracomboBox.TabIndex = 1;
            this.cameracomboBox.UseTallSize = false;
            this.cameracomboBox.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // camerapictureBox
            // 
            this.camerapictureBox.Location = new System.Drawing.Point(103, 105);
            this.camerapictureBox.Name = "camerapictureBox";
            this.camerapictureBox.Size = new System.Drawing.Size(166, 124);
            this.camerapictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.camerapictureBox.TabIndex = 2;
            this.camerapictureBox.TabStop = false;
            // 
            // gravarcamerabtn
            // 
            this.gravarcamerabtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gravarcamerabtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gravarcamerabtn.Depth = 0;
            this.gravarcamerabtn.HighEmphasis = true;
            this.gravarcamerabtn.Icon = null;
            this.gravarcamerabtn.Location = new System.Drawing.Point(9, 190);
            this.gravarcamerabtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gravarcamerabtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.gravarcamerabtn.Name = "gravarcamerabtn";
            this.gravarcamerabtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gravarcamerabtn.Size = new System.Drawing.Size(78, 36);
            this.gravarcamerabtn.TabIndex = 4;
            this.gravarcamerabtn.Text = "Gravar";
            this.gravarcamerabtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gravarcamerabtn.UseAccentColor = false;
            this.gravarcamerabtn.UseVisualStyleBackColor = true;
            this.gravarcamerabtn.Click += new System.EventHandler(this.gravarcamerabtn_Click);
            // 
            // PictureTake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 235);
            this.Controls.Add(this.gravarcamerabtn);
            this.Controls.Add(this.camerapictureBox);
            this.Controls.Add(this.cameracomboBox);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(275, 235);
            this.MinimumSize = new System.Drawing.Size(275, 235);
            this.Name = "PictureTake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tirar Foto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PictureTake_Closing);
            this.Load += new System.EventHandler(this.PictureTake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camerapictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton gravarcamerabtn;
        public MaterialSkin.Controls.MaterialComboBox cameracomboBox;
        public System.Windows.Forms.PictureBox camerapictureBox;
    }
}