
namespace EpicPotato_Game2
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btt_Options = new System.Windows.Forms.Button();
            this.btt_Meditar = new System.Windows.Forms.Button();
            this.btt_Defesa = new System.Windows.Forms.Button();
            this.btt_Ataque3 = new System.Windows.Forms.Button();
            this.btt_Ataque2 = new System.Windows.Forms.Button();
            this.btt_Ataque1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Defesa_Oponente = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_Vida_Oponente = new System.Windows.Forms.ProgressBar();
            this.pb_Defesa_Jogador = new System.Windows.Forms.ProgressBar();
            this.pb_Vida_jogador = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(718, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(204, 458);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(196, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pontuações";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(28, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 130);
            this.panel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Maior Pontuação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pontuação atual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Player,
            this.dgv_Points});
            this.dataGridView1.Location = new System.Drawing.Point(3, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(190, 260);
            this.dataGridView1.TabIndex = 10;
            // 
            // dgv_Player
            // 
            this.dgv_Player.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_Player.HeaderText = "Jogador";
            this.dgv_Player.Name = "dgv_Player";
            this.dgv_Player.ReadOnly = true;
            // 
            // dgv_Points
            // 
            this.dgv_Points.HeaderText = "Pontuação";
            this.dgv_Points.Name = "dgv_Points";
            this.dgv_Points.ReadOnly = true;
            this.dgv_Points.Width = 80;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(196, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Defesa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Defesa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Ataque 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ataque 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ataque 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Vida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Atributos do Jogador";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(196, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Upgrades";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btt_Options);
            this.panel2.Controls.Add(this.btt_Meditar);
            this.panel2.Controls.Add(this.btt_Defesa);
            this.panel2.Controls.Add(this.btt_Ataque3);
            this.panel2.Controls.Add(this.btt_Ataque2);
            this.panel2.Controls.Add(this.btt_Ataque1);
            this.panel2.Location = new System.Drawing.Point(12, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 80);
            this.panel2.TabIndex = 7;
            // 
            // btt_Options
            // 
            this.btt_Options.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Options.Location = new System.Drawing.Point(608, 3);
            this.btt_Options.Name = "btt_Options";
            this.btt_Options.Size = new System.Drawing.Size(87, 72);
            this.btt_Options.TabIndex = 5;
            this.btt_Options.Text = "Opções";
            this.btt_Options.UseVisualStyleBackColor = true;
            this.btt_Options.Click += new System.EventHandler(this.btt_Options_Click);
            // 
            // btt_Meditar
            // 
            this.btt_Meditar.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Meditar.Location = new System.Drawing.Point(487, 25);
            this.btt_Meditar.Name = "btt_Meditar";
            this.btt_Meditar.Size = new System.Drawing.Size(115, 50);
            this.btt_Meditar.TabIndex = 4;
            this.btt_Meditar.Text = "Meditar";
            this.btt_Meditar.UseVisualStyleBackColor = true;
            this.btt_Meditar.Click += new System.EventHandler(this.btt_Meditar_Click);
            // 
            // btt_Defesa
            // 
            this.btt_Defesa.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Defesa.Location = new System.Drawing.Point(366, 25);
            this.btt_Defesa.Name = "btt_Defesa";
            this.btt_Defesa.Size = new System.Drawing.Size(115, 50);
            this.btt_Defesa.TabIndex = 3;
            this.btt_Defesa.Text = "Defesa";
            this.btt_Defesa.UseVisualStyleBackColor = true;
            this.btt_Defesa.Click += new System.EventHandler(this.btt_Defesa_Click);
            // 
            // btt_Ataque3
            // 
            this.btt_Ataque3.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Ataque3.Location = new System.Drawing.Point(245, 25);
            this.btt_Ataque3.Name = "btt_Ataque3";
            this.btt_Ataque3.Size = new System.Drawing.Size(115, 50);
            this.btt_Ataque3.TabIndex = 2;
            this.btt_Ataque3.Text = "Soco sério\r\nSuper sério";
            this.btt_Ataque3.UseVisualStyleBackColor = true;
            this.btt_Ataque3.Click += new System.EventHandler(this.btt_Ataque3_Click);
            // 
            // btt_Ataque2
            // 
            this.btt_Ataque2.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Ataque2.Location = new System.Drawing.Point(124, 25);
            this.btt_Ataque2.Name = "btt_Ataque2";
            this.btt_Ataque2.Size = new System.Drawing.Size(115, 50);
            this.btt_Ataque2.TabIndex = 1;
            this.btt_Ataque2.Text = "Socos normais\r\nconsecutivos";
            this.btt_Ataque2.UseVisualStyleBackColor = true;
            this.btt_Ataque2.Click += new System.EventHandler(this.btt_Ataque2_Click);
            // 
            // btt_Ataque1
            // 
            this.btt_Ataque1.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Ataque1.Location = new System.Drawing.Point(3, 25);
            this.btt_Ataque1.Name = "btt_Ataque1";
            this.btt_Ataque1.Size = new System.Drawing.Size(115, 50);
            this.btt_Ataque1.TabIndex = 0;
            this.btt_Ataque1.Text = "Apenas um\r\nsoco";
            this.btt_Ataque1.UseVisualStyleBackColor = true;
            this.btt_Ataque1.Click += new System.EventHandler(this.btt_Ataque1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pb_Defesa_Oponente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_Vida_Oponente);
            this.panel1.Controls.Add(this.pb_Defesa_Jogador);
            this.panel1.Controls.Add(this.pb_Vida_jogador);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 360);
            this.panel1.TabIndex = 6;
            // 
            // pb_Defesa_Oponente
            // 
            this.pb_Defesa_Oponente.Location = new System.Drawing.Point(409, 26);
            this.pb_Defesa_Oponente.Name = "pb_Defesa_Oponente";
            this.pb_Defesa_Oponente.Size = new System.Drawing.Size(200, 8);
            this.pb_Defesa_Oponente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "0 / 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "0 / 0";
            // 
            // pb_Vida_Oponente
            // 
            this.pb_Vida_Oponente.Location = new System.Drawing.Point(409, 3);
            this.pb_Vida_Oponente.Name = "pb_Vida_Oponente";
            this.pb_Vida_Oponente.Size = new System.Drawing.Size(200, 20);
            this.pb_Vida_Oponente.TabIndex = 3;
            // 
            // pb_Defesa_Jogador
            // 
            this.pb_Defesa_Jogador.Location = new System.Drawing.Point(89, 347);
            this.pb_Defesa_Jogador.Name = "pb_Defesa_Jogador";
            this.pb_Defesa_Jogador.Size = new System.Drawing.Size(200, 8);
            this.pb_Defesa_Jogador.TabIndex = 2;
            // 
            // pb_Vida_jogador
            // 
            this.pb_Vida_jogador.Location = new System.Drawing.Point(89, 324);
            this.pb_Vida_jogador.Name = "pb_Vida_jogador";
            this.pb_Vida_jogador.Size = new System.Drawing.Size(200, 20);
            this.pb_Vida_jogador.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 470);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Points;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btt_Options;
        private System.Windows.Forms.Button btt_Meditar;
        private System.Windows.Forms.Button btt_Defesa;
        private System.Windows.Forms.Button btt_Ataque3;
        private System.Windows.Forms.Button btt_Ataque2;
        private System.Windows.Forms.Button btt_Ataque1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ProgressBar pb_Vida_Oponente;
        public System.Windows.Forms.ProgressBar pb_Defesa_Jogador;
        public System.Windows.Forms.ProgressBar pb_Vida_jogador;
        public System.Windows.Forms.ProgressBar pb_Defesa_Oponente;
    }
}

