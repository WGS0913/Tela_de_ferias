namespace CalculoDeFerias
{
    partial class Form1
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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTabela = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSalarioHora = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Data de Termino";
            this.Column2.Name = "Column2";
            // 
            // Vencido
            // 
            this.Vencido.HeaderText = "Vencido";
            this.Vencido.Name = "Vencido";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(105, 61);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 107;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // dataTabela
            // 
            this.dataTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Vencido,
            this.Column1,
            this.Column2});
            this.dataTabela.Location = new System.Drawing.Point(469, 48);
            this.dataTabela.Name = "dataTabela";
            this.dataTabela.Size = new System.Drawing.Size(538, 169);
            this.dataTabela.TabIndex = 113;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Data de inicio";
            this.Column1.Name = "Column1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(4, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 106;
            this.label3.Text = "Data do Pagamento:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(648, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 34);
            this.button2.TabIndex = 109;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(13, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 96;
            this.label6.Text = "Funcionário";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 361);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 20);
            this.dateTimePicker1.TabIndex = 105;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(560, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 34);
            this.button1.TabIndex = 108;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblSalarioHora
            // 
            this.lblSalarioHora.AutoSize = true;
            this.lblSalarioHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalarioHora.Location = new System.Drawing.Point(13, 110);
            this.lblSalarioHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalarioHora.Name = "lblSalarioHora";
            this.lblSalarioHora.Size = new System.Drawing.Size(66, 18);
            this.lblSalarioHora.TabIndex = 97;
            this.lblSalarioHora.Text = "Salario ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(850, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 34);
            this.button3.TabIndex = 112;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(228, 228);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(36, 15);
            this.textBox4.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(4, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 111;
            this.label4.Text = "Data do Retorno:";
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioHora.Location = new System.Drawing.Point(105, 108);
            this.txtSalarioHora.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(175, 20);
            this.txtSalarioHora.TabIndex = 95;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(746, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 34);
            this.button4.TabIndex = 110;
            this.button4.Text = "Desfazer Cáculo";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 102;
            this.label1.Text = "Faltas:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(75, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 18);
            this.textBox1.TabIndex = 103;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(152, 165);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(170, 19);
            this.radioButton1.TabIndex = 98;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Adiantar o 13 salário ?";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton2.Location = new System.Drawing.Point(7, 165);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(142, 19);
            this.radioButton2.TabIndex = 100;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Abono Pecuniário ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(117, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "Dias de Férias";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(159, 297);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(264, 20);
            this.dateTimePicker2.TabIndex = 105;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton3.Location = new System.Drawing.Point(347, 165);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(76, 19);
            this.radioButton3.TabIndex = 114;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Vencido";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1062, 481);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataTabela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSalarioHora);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalarioHora);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencido;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView dataTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSalarioHora;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalarioHora;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

