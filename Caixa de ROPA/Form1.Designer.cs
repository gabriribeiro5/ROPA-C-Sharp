namespace Caixa_de_ROPA
{
    partial class Tela_TAB2
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
            this.QtdTela = new System.Windows.Forms.NumericUpDown();
            this.lblDescProd = new System.Windows.Forms.Label();
            this.lblQTD = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAvançar = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.lblCarrinho = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblSubtot = new System.Windows.Forms.Label();
            this.lblImp = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.txtValorSub = new System.Windows.Forms.TextBox();
            this.txtImp = new System.Windows.Forms.TextBox();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.listCarrinho = new System.Windows.Forms.ListBox();
            this.btnProdA = new System.Windows.Forms.Button();
            this.btnProdJ = new System.Windows.Forms.Button();
            this.btnProdI = new System.Windows.Forms.Button();
            this.btnProdH = new System.Windows.Forms.Button();
            this.btnProdG = new System.Windows.Forms.Button();
            this.btnProdF = new System.Windows.Forms.Button();
            this.btnProdE = new System.Windows.Forms.Button();
            this.btnProdD = new System.Windows.Forms.Button();
            this.btnProdC = new System.Windows.Forms.Button();
            this.btnProdB = new System.Windows.Forms.Button();
            this.LOGO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QtdTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // QtdTela
            // 
            this.QtdTela.Location = new System.Drawing.Point(962, 502);
            this.QtdTela.Name = "QtdTela";
            this.QtdTela.Size = new System.Drawing.Size(51, 20);
            this.QtdTela.TabIndex = 1;
            this.QtdTela.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.Location = new System.Drawing.Point(297, 489);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(61, 26);
            this.lblDescProd.TabIndex = 22;
            this.lblDescProd.Text = "Descrição\r\ndo produto:";
            // 
            // lblQTD
            // 
            this.lblQTD.AutoSize = true;
            this.lblQTD.Location = new System.Drawing.Point(959, 486);
            this.lblQTD.Name = "lblQTD";
            this.lblQTD.Size = new System.Drawing.Size(62, 13);
            this.lblQTD.TabIndex = 23;
            this.lblQTD.Text = "Quantidade";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(962, 524);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(89, 25);
            this.btnAdicionar.TabIndex = 24;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAvançar
            // 
            this.btnAvançar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAvançar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvançar.Location = new System.Drawing.Point(1111, 523);
            this.btnAvançar.Name = "btnAvançar";
            this.btnAvançar.Size = new System.Drawing.Size(78, 25);
            this.btnAvançar.TabIndex = 25;
            this.btnAvançar.Text = "AVANÇAR";
            this.btnAvançar.UseVisualStyleBackColor = false;
            this.btnAvançar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(364, 486);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(589, 63);
            this.txtDesc.TabIndex = 26;
            this.txtDesc.Text = "";
            // 
            // lblCarrinho
            // 
            this.lblCarrinho.AutoSize = true;
            this.lblCarrinho.Location = new System.Drawing.Point(1062, 36);
            this.lblCarrinho.Name = "lblCarrinho";
            this.lblCarrinho.Size = new System.Drawing.Size(104, 13);
            this.lblCarrinho.TabIndex = 28;
            this.lblCarrinho.Text = "Carrinho de compras";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(104, 491);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(99, 39);
            this.btnIniciar.TabIndex = 29;
            this.btnIniciar.Text = "INICIAR ORÇAMENTO";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblSubtot
            // 
            this.lblSubtot.AutoSize = true;
            this.lblSubtot.Location = new System.Drawing.Point(1040, 447);
            this.lblSubtot.Name = "lblSubtot";
            this.lblSubtot.Size = new System.Drawing.Size(93, 13);
            this.lblSubtot.TabIndex = 30;
            this.lblSubtot.Text = "Subtotal           R$";
            this.lblSubtot.Click += new System.EventHandler(this.lblSubtot_Click);
            // 
            // lblImp
            // 
            this.lblImp.AutoSize = true;
            this.lblImp.Location = new System.Drawing.Point(1040, 470);
            this.lblImp.Name = "lblImp";
            this.lblImp.Size = new System.Drawing.Size(93, 13);
            this.lblImp.TabIndex = 31;
            this.lblImp.Text = "Impostos          R$";
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Location = new System.Drawing.Point(1040, 494);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(93, 13);
            this.lblTot.TabIndex = 32;
            this.lblTot.Text = "Total                R$";
            // 
            // txtValorSub
            // 
            this.txtValorSub.Location = new System.Drawing.Point(1135, 440);
            this.txtValorSub.Name = "txtValorSub";
            this.txtValorSub.Size = new System.Drawing.Size(53, 20);
            this.txtValorSub.TabIndex = 37;
            this.txtValorSub.TextChanged += new System.EventHandler(this.txtValorSub_TextChanged);
            // 
            // txtImp
            // 
            this.txtImp.Location = new System.Drawing.Point(1135, 465);
            this.txtImp.Name = "txtImp";
            this.txtImp.Size = new System.Drawing.Size(53, 20);
            this.txtImp.TabIndex = 38;
            this.txtImp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(1135, 491);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(53, 20);
            this.txtTot.TabIndex = 39;
            this.txtTot.TextChanged += new System.EventHandler(this.txtTot_TextChanged);
            // 
            // listCarrinho
            // 
            this.listCarrinho.FormattingEnabled = true;
            this.listCarrinho.Location = new System.Drawing.Point(1043, 49);
            this.listCarrinho.Name = "listCarrinho";
            this.listCarrinho.Size = new System.Drawing.Size(159, 381);
            this.listCarrinho.TabIndex = 40;
            // 
            // btnProdA
            // 
            this.btnProdA.BackgroundImage = global::Caixa_de_ROPA.Properties.Resources.LOGO2_2png;
            this.btnProdA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdA.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdA.Image = global::Caixa_de_ROPA.Properties.Resources.ProdA___Armadura_de_Wakanda;
            this.btnProdA.Location = new System.Drawing.Point(300, 51);
            this.btnProdA.Name = "btnProdA";
            this.btnProdA.Size = new System.Drawing.Size(142, 186);
            this.btnProdA.TabIndex = 50;
            this.btnProdA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnProdA.UseVisualStyleBackColor = true;
            this.btnProdA.Visible = false;
            this.btnProdA.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProdJ
            // 
            this.btnProdJ.BackgroundImage = global::Caixa_de_ROPA.Properties.Resources.LOGO2_2png;
            this.btnProdJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdJ.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdJ.Image = global::Caixa_de_ROPA.Properties.Resources.ProdJYellowBoot;
            this.btnProdJ.Location = new System.Drawing.Point(895, 258);
            this.btnProdJ.Name = "btnProdJ";
            this.btnProdJ.Size = new System.Drawing.Size(142, 186);
            this.btnProdJ.TabIndex = 49;
            this.btnProdJ.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProdJ.UseVisualStyleBackColor = true;
            this.btnProdJ.Visible = false;
            this.btnProdJ.Click += new System.EventHandler(this.btnProdJ_Click);
            // 
            // btnProdI
            // 
            this.btnProdI.BackgroundImage = global::Caixa_de_ROPA.Properties.Resources.LOGO2_2png;
            this.btnProdI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdI.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdI.Image = global::Caixa_de_ROPA.Properties.Resources.ProdIKingSpring;
            this.btnProdI.Location = new System.Drawing.Point(744, 274);
            this.btnProdI.Name = "btnProdI";
            this.btnProdI.Size = new System.Drawing.Size(142, 186);
            this.btnProdI.TabIndex = 48;
            this.btnProdI.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProdI.UseVisualStyleBackColor = true;
            this.btnProdI.Visible = false;
            this.btnProdI.Click += new System.EventHandler(this.btnProdI_Click);
            // 
            // btnProdH
            // 
            this.btnProdH.BackgroundImage = global::Caixa_de_ROPA.Properties.Resources.LOGO2_2png;
            this.btnProdH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdH.Image = global::Caixa_de_ROPA.Properties.Resources.ProdH___Atemporal;
            this.btnProdH.Location = new System.Drawing.Point(596, 294);
            this.btnProdH.Name = "btnProdH";
            this.btnProdH.Size = new System.Drawing.Size(142, 186);
            this.btnProdH.TabIndex = 47;
            this.btnProdH.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProdH.UseVisualStyleBackColor = true;
            this.btnProdH.Visible = false;
            this.btnProdH.Click += new System.EventHandler(this.btnProdH_Click);
            // 
            // btnProdG
            // 
            this.btnProdG.BackgroundImage = global::Caixa_de_ROPA.Properties.Resources.LOGO2_2png;
            this.btnProdG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdG.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdG.Image = global::Caixa_de_ROPA.Properties.Resources.ProdG___Golden_Bird;
            this.btnProdG.Location = new System.Drawing.Point(448, 244);
            this.btnProdG.Name = "btnProdG";
            this.btnProdG.Size = new System.Drawing.Size(142, 186);
            this.btnProdG.TabIndex = 46;
            this.btnProdG.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProdG.UseVisualStyleBackColor = true;
            this.btnProdG.Visible = false;
            this.btnProdG.Click += new System.EventHandler(this.btnProdG_Click);
            // 
            // btnProdF
            // 
            this.btnProdF.BackgroundImage = global::Caixa_de_ROPA.Properties.Resources.LOGO2_2png;
            this.btnProdF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdF.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdF.Image = global::Caixa_de_ROPA.Properties.Resources.ProdF___Naruto;
            this.btnProdF.Location = new System.Drawing.Point(300, 260);
            this.btnProdF.Name = "btnProdF";
            this.btnProdF.Size = new System.Drawing.Size(142, 186);
            this.btnProdF.TabIndex = 45;
            this.btnProdF.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProdF.UseVisualStyleBackColor = true;
            this.btnProdF.Visible = false;
            this.btnProdF.Click += new System.EventHandler(this.btnProdF_Click);
            // 
            // btnProdE
            // 
            this.btnProdE.BackgroundImage = global::Caixa_de_ROPA.Properties.Resources.LOGO2_2png;
            this.btnProdE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdE.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdE.Image = global::Caixa_de_ROPA.Properties.Resources.ProdE_Chapeu_Isã;
            this.btnProdE.Location = new System.Drawing.Point(892, 36);
            this.btnProdE.Name = "btnProdE";
            this.btnProdE.Size = new System.Drawing.Size(142, 186);
            this.btnProdE.TabIndex = 44;
            this.btnProdE.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProdE.UseVisualStyleBackColor = true;
            this.btnProdE.Visible = false;
            this.btnProdE.Click += new System.EventHandler(this.btnProdE_Click);
            // 
            // btnProdD
            // 
            this.btnProdD.BackgroundImage = global::Caixa_de_ROPA.Properties.Resources.LOGO2_2png;
            this.btnProdD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdD.Image = global::Caixa_de_ROPA.Properties.Resources.ProdD___Esù;
            this.btnProdD.Location = new System.Drawing.Point(744, 66);
            this.btnProdD.Name = "btnProdD";
            this.btnProdD.Size = new System.Drawing.Size(142, 186);
            this.btnProdD.TabIndex = 43;
            this.btnProdD.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProdD.UseVisualStyleBackColor = true;
            this.btnProdD.Visible = false;
            this.btnProdD.Click += new System.EventHandler(this.btnProdD_Click);
            // 
            // btnProdC
            // 
            this.btnProdC.BackgroundImage = global::Caixa_de_ROPA.Properties.Resources.LOGO2_2png;
            this.btnProdC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdC.Image = global::Caixa_de_ROPA.Properties.Resources.ProdC___Kobe_Briant;
            this.btnProdC.Location = new System.Drawing.Point(596, 51);
            this.btnProdC.Name = "btnProdC";
            this.btnProdC.Size = new System.Drawing.Size(142, 186);
            this.btnProdC.TabIndex = 42;
            this.btnProdC.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProdC.UseVisualStyleBackColor = true;
            this.btnProdC.Visible = false;
            this.btnProdC.Click += new System.EventHandler(this.btnProdC_Click);
            // 
            // btnProdB
            // 
            this.btnProdB.BackgroundImage = global::Caixa_de_ROPA.Properties.Resources.LOGO2_2png;
            this.btnProdB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdB.Image = global::Caixa_de_ROPA.Properties.Resources.ProdB___Regata_Afro;
            this.btnProdB.Location = new System.Drawing.Point(448, 36);
            this.btnProdB.Name = "btnProdB";
            this.btnProdB.Size = new System.Drawing.Size(142, 186);
            this.btnProdB.TabIndex = 41;
            this.btnProdB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProdB.UseVisualStyleBackColor = true;
            this.btnProdB.Visible = false;
            this.btnProdB.Click += new System.EventHandler(this.btnProdB_Click);
            // 
            // LOGO
            // 
            this.LOGO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LOGO.Image = global::Caixa_de_ROPA.Properties.Resources.LOGO2_2png;
            this.LOGO.Location = new System.Drawing.Point(9, 20);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(285, 466);
            this.LOGO.TabIndex = 0;
            this.LOGO.TabStop = false;
            // 
            // Tela_TAB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Caixa_de_ROPA.Properties.Resources.imgFundo;
            this.ClientSize = new System.Drawing.Size(1214, 568);
            this.Controls.Add(this.btnProdA);
            this.Controls.Add(this.btnProdJ);
            this.Controls.Add(this.btnProdI);
            this.Controls.Add(this.btnProdH);
            this.Controls.Add(this.btnProdG);
            this.Controls.Add(this.btnProdF);
            this.Controls.Add(this.btnProdE);
            this.Controls.Add(this.btnProdD);
            this.Controls.Add(this.btnProdC);
            this.Controls.Add(this.btnProdB);
            this.Controls.Add(this.listCarrinho);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.txtImp);
            this.Controls.Add(this.txtValorSub);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.lblImp);
            this.Controls.Add(this.lblSubtot);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblCarrinho);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnAvançar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblQTD);
            this.Controls.Add(this.lblDescProd);
            this.Controls.Add(this.QtdTela);
            this.Controls.Add(this.LOGO);
            this.KeyPreview = true;
            this.Name = "Tela_TAB2";
            this.Text = "SELEÇÃO DE PRODUTOS          ";
            this.Load += new System.EventHandler(this.Tela_TAB2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QtdTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LOGO;
        private System.Windows.Forms.NumericUpDown QtdTela;
        private System.Windows.Forms.Label lblDescProd;
        private System.Windows.Forms.Label lblQTD;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAvançar;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label lblCarrinho;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblSubtot;
        private System.Windows.Forms.Label lblImp;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.TextBox txtValorSub;
        private System.Windows.Forms.TextBox txtImp;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.ListBox listCarrinho;
        private System.Windows.Forms.Button btnProdB;
        private System.Windows.Forms.Button btnProdC;
        private System.Windows.Forms.Button btnProdD;
        private System.Windows.Forms.Button btnProdE;
        private System.Windows.Forms.Button btnProdF;
        private System.Windows.Forms.Button btnProdG;
        private System.Windows.Forms.Button btnProdH;
        private System.Windows.Forms.Button btnProdI;
        private System.Windows.Forms.Button btnProdJ;
        private System.Windows.Forms.Button btnProdA;
    }
}

