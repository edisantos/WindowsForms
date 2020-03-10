namespace samsung.refacco.ApplicationSystem
{
    partial class Registros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitleMenuLateral = new System.Windows.Forms.Label();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.pctMenuRetratio = new System.Windows.Forms.PictureBox();
            this.IconAbrirMenuLateral = new System.Windows.Forms.PictureBox();
            this.btnMonitoring = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenuRetratio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconAbrirMenuLateral)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MenuVertical.Controls.Add(this.lblTitleMenuLateral);
            this.MenuVertical.Controls.Add(this.IconAbrirMenuLateral);
            this.MenuVertical.Controls.Add(this.btnMonitoring);
            this.MenuVertical.Controls.Add(this.btnRegistro);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 611);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.pcbSair);
            this.panel2.Controls.Add(this.pctMenuRetratio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 61);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.GridProdutos);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(250, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 550);
            this.panel3.TabIndex = 2;
            // 
            // GridProdutos
            // 
            this.GridProdutos.AllowUserToAddRows = false;
            this.GridProdutos.AllowUserToOrderColumns = true;
            this.GridProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Data,
            this.Protudo,
            this.Valor});
            this.GridProdutos.Location = new System.Drawing.Point(28, 104);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.ReadOnly = true;
            this.GridProdutos.Size = new System.Drawing.Size(695, 371);
            this.GridProdutos.TabIndex = 1;
            this.GridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProdutos_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Protudo
            // 
            this.Protudo.DataPropertyName = "Produto";
            this.Protudo.HeaderText = "Produto";
            this.Protudo.Name = "Protudo";
            this.Protudo.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 508);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(735, 42);
            this.panel4.TabIndex = 0;
            // 
            // lblTitleMenuLateral
            // 
            this.lblTitleMenuLateral.AutoSize = true;
            this.lblTitleMenuLateral.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleMenuLateral.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMenuLateral.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleMenuLateral.Location = new System.Drawing.Point(7, 80);
            this.lblTitleMenuLateral.Name = "lblTitleMenuLateral";
            this.lblTitleMenuLateral.Size = new System.Drawing.Size(208, 45);
            this.lblTitleMenuLateral.TabIndex = 4;
            this.lblTitleMenuLateral.Text = "Refacco V4.0";
            // 
            // pcbSair
            // 
            this.pcbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbSair.BackColor = System.Drawing.Color.Transparent;
            this.pcbSair.Image = ((System.Drawing.Image)(resources.GetObject("pcbSair.Image")));
            this.pcbSair.Location = new System.Drawing.Point(693, 17);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(30, 30);
            this.pcbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSair.TabIndex = 1;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.pcbSair_Click);
            // 
            // pctMenuRetratio
            // 
            this.pctMenuRetratio.BackColor = System.Drawing.Color.Transparent;
            this.pctMenuRetratio.Image = ((System.Drawing.Image)(resources.GetObject("pctMenuRetratio.Image")));
            this.pctMenuRetratio.Location = new System.Drawing.Point(8, 7);
            this.pctMenuRetratio.Name = "pctMenuRetratio";
            this.pctMenuRetratio.Size = new System.Drawing.Size(50, 50);
            this.pctMenuRetratio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMenuRetratio.TabIndex = 0;
            this.pctMenuRetratio.TabStop = false;
            this.pctMenuRetratio.Click += new System.EventHandler(this.pctMenuRetratio_Click);
            // 
            // IconAbrirMenuLateral
            // 
            this.IconAbrirMenuLateral.BackColor = System.Drawing.Color.Transparent;
            this.IconAbrirMenuLateral.Image = global::samsung.refacco.ApplicationSystem.Properties.Resources.MenuMobile1;
            this.IconAbrirMenuLateral.Location = new System.Drawing.Point(12, 7);
            this.IconAbrirMenuLateral.Name = "IconAbrirMenuLateral";
            this.IconAbrirMenuLateral.Size = new System.Drawing.Size(50, 50);
            this.IconAbrirMenuLateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconAbrirMenuLateral.TabIndex = 3;
            this.IconAbrirMenuLateral.TabStop = false;
            this.IconAbrirMenuLateral.Click += new System.EventHandler(this.IconAbrirMenuLateral_Click);
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.BackColor = System.Drawing.Color.Transparent;
            this.btnMonitoring.BackgroundImage = global::samsung.refacco.ApplicationSystem.Properties.Resources.IconMonitoring;
            this.btnMonitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMonitoring.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnMonitoring.FlatAppearance.BorderSize = 0;
            this.btnMonitoring.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnMonitoring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitoring.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitoring.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMonitoring.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitoring.Location = new System.Drawing.Point(0, 243);
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.Size = new System.Drawing.Size(250, 58);
            this.btnMonitoring.TabIndex = 2;
            this.btnMonitoring.Text = "Monitoring";
            this.btnMonitoring.UseVisualStyleBackColor = false;
            this.btnMonitoring.Click += new System.EventHandler(this.btnMonitoring_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistro.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistro.Image = global::samsung.refacco.ApplicationSystem.Properties.Resources.IconPartilhar;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(0, 165);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(250, 58);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Tracking";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(985, 611);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuVertical);
            this.Name = "Registros";
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Registros_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenuRetratio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconAbrirMenuLateral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pctMenuRetratio;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.PictureBox pcbSair;
        private System.Windows.Forms.Button btnMonitoring;
        private System.Windows.Forms.PictureBox IconAbrirMenuLateral;
        private System.Windows.Forms.Label lblTitleMenuLateral;
    }
}