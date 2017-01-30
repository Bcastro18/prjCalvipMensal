namespace prjSistemaMensal_UniaoEnc
{
    partial class Mensal
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
            this.btnAdc = new System.Windows.Forms.Button();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.txtRemetente = new System.Windows.Forms.TextBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.txtDestinatário = new System.Windows.Forms.TextBox();
            this.cmbCidades = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPagamentoApagar = new System.Windows.Forms.RadioButton();
            this.rdbPagamentoPago = new System.Windows.Forms.RadioButton();
            this.txtNCTE = new System.Windows.Forms.TextBox();
            this.dgvCtes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnFechamento = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTipoResp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdc
            // 
            this.btnAdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdc.Location = new System.Drawing.Point(64, 471);
            this.btnAdc.Name = "btnAdc";
            this.btnAdc.Size = new System.Drawing.Size(106, 40);
            this.btnAdc.TabIndex = 12;
            this.btnAdc.Text = "Adicionar";
            this.btnAdc.UseVisualStyleBackColor = true;
            this.btnAdc.Click += new System.EventHandler(this.btnAdc_Click);
            // 
            // cmbDia
            // 
            this.cmbDia.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDia.Location = new System.Drawing.Point(35, 71);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(50, 26);
            this.cmbDia.TabIndex = 1;
            this.cmbDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDia_KeyPress);
            // 
            // txtRemetente
            // 
            this.txtRemetente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRemetente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemetente.Location = new System.Drawing.Point(33, 180);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.Size = new System.Drawing.Size(211, 24);
            this.txtRemetente.TabIndex = 5;
            // 
            // cmbMes
            // 
            this.cmbMes.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMes.Location = new System.Drawing.Point(91, 71);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(50, 26);
            this.cmbMes.TabIndex = 2;
            this.cmbMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMes_KeyPress);
            // 
            // cmbAno
            // 
            this.cmbAno.AutoCompleteCustomSource.AddRange(new string[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2017"});
            this.cmbAno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031"});
            this.cmbAno.Location = new System.Drawing.Point(147, 71);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(63, 26);
            this.cmbAno.TabIndex = 3;
            this.cmbAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAno_KeyPress);
            // 
            // txtDestinatário
            // 
            this.txtDestinatário.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDestinatário.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinatário.Location = new System.Drawing.Point(33, 224);
            this.txtDestinatário.Name = "txtDestinatário";
            this.txtDestinatário.Size = new System.Drawing.Size(211, 24);
            this.txtDestinatário.TabIndex = 6;
            // 
            // cmbCidades
            // 
            this.cmbCidades.AutoCompleteCustomSource.AddRange(new string[] {
            "Boituva",
            "Cerquilho",
            "Conchas",
            "Laranjal Paulista",
            "Tietê"});
            this.cmbCidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cmbCidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCidades.FormattingEnabled = true;
            this.cmbCidades.Items.AddRange(new object[] {
            "Boituva",
            "Cerquilho",
            "Conchas",
            "Laranjal Paulista",
            "Tietê"});
            this.cmbCidades.Location = new System.Drawing.Point(60, 272);
            this.cmbCidades.Name = "cmbCidades";
            this.cmbCidades.Size = new System.Drawing.Size(121, 26);
            this.cmbCidades.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(70, 401);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(85, 24);
            this.txtValor.TabIndex = 11;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPagamentoApagar);
            this.groupBox1.Controls.Add(this.rdbPagamentoPago);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamento";
            // 
            // rdbPagamentoApagar
            // 
            this.rdbPagamentoApagar.AutoSize = true;
            this.rdbPagamentoApagar.Location = new System.Drawing.Point(112, 20);
            this.rdbPagamentoApagar.Name = "rdbPagamentoApagar";
            this.rdbPagamentoApagar.Size = new System.Drawing.Size(57, 22);
            this.rdbPagamentoApagar.TabIndex = 10;
            this.rdbPagamentoApagar.Text = "FOB";
            this.rdbPagamentoApagar.UseVisualStyleBackColor = true;
            // 
            // rdbPagamentoPago
            // 
            this.rdbPagamentoPago.AutoSize = true;
            this.rdbPagamentoPago.Checked = true;
            this.rdbPagamentoPago.Location = new System.Drawing.Point(7, 20);
            this.rdbPagamentoPago.Name = "rdbPagamentoPago";
            this.rdbPagamentoPago.Size = new System.Drawing.Size(49, 22);
            this.rdbPagamentoPago.TabIndex = 9;
            this.rdbPagamentoPago.TabStop = true;
            this.rdbPagamentoPago.Text = "CIF";
            this.rdbPagamentoPago.UseVisualStyleBackColor = true;
            // 
            // txtNCTE
            // 
            this.txtNCTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCTE.Location = new System.Drawing.Point(35, 121);
            this.txtNCTE.Name = "txtNCTE";
            this.txtNCTE.Size = new System.Drawing.Size(75, 24);
            this.txtNCTE.TabIndex = 4;
            this.txtNCTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNCTE_KeyPress);
            // 
            // dgvCtes
            // 
            this.dgvCtes.AllowUserToAddRows = false;
            this.dgvCtes.AllowUserToDeleteRows = false;
            this.dgvCtes.BackgroundColor = System.Drawing.Color.White;
            this.dgvCtes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtes.GridColor = System.Drawing.Color.White;
            this.dgvCtes.Location = new System.Drawing.Point(265, 27);
            this.dgvCtes.Name = "dgvCtes";
            this.dgvCtes.Size = new System.Drawing.Size(759, 484);
            this.dgvCtes.TabIndex = 14;
            this.dgvCtes.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cidades:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Destinatário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Remetente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Número CTE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mês:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(144, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ano:";
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(925, 517);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(99, 23);
            this.btnGerar.TabIndex = 13;
            this.btnGerar.TabStop = false;
            this.btnGerar.Text = "Gerar XLS";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnFechamento
            // 
            this.btnFechamento.BackColor = System.Drawing.SystemColors.Control;
            this.btnFechamento.Location = new System.Drawing.Point(804, 518);
            this.btnFechamento.Name = "btnFechamento";
            this.btnFechamento.Size = new System.Drawing.Size(100, 23);
            this.btnFechamento.TabIndex = 15;
            this.btnFechamento.Text = "Fechamento";
            this.btnFechamento.UseVisualStyleBackColor = false;
            this.btnFechamento.Visible = false;
            this.btnFechamento.Click += new System.EventHandler(this.btnFechamento_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(620, 518);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(58, 24);
            this.lblTipo.TabIndex = 16;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblTipoResp
            // 
            this.lblTipoResp.AutoSize = true;
            this.lblTipoResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoResp.Location = new System.Drawing.Point(678, 517);
            this.lblTipoResp.Name = "lblTipoResp";
            this.lblTipoResp.Size = new System.Drawing.Size(102, 24);
            this.lblTipoResp.TabIndex = 16;
            this.lblTipoResp.Text = "EMISSÃO";
            // 
            // Mensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1042, 551);
            this.Controls.Add(this.lblTipoResp);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnFechamento);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCtes);
            this.Controls.Add(this.txtNCTE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cmbCidades);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.txtDestinatário);
            this.Controls.Add(this.txtRemetente);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.btnAdc);
            this.Name = "Mensal";
            this.Text = "Controle Mensal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdc;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.TextBox txtRemetente;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.TextBox txtDestinatário;
        private System.Windows.Forms.ComboBox cmbCidades;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPagamentoApagar;
        private System.Windows.Forms.RadioButton rdbPagamentoPago;
        private System.Windows.Forms.TextBox txtNCTE;
        private System.Windows.Forms.DataGridView dgvCtes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnFechamento;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTipoResp;
    }
}

