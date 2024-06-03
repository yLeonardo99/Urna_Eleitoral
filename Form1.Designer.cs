namespace UrnaEletronica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            listBox1 = new ListBox();
            lbl_nome = new Label();
            lbl_partido = new Label();
            txt_5 = new TextBox();
            txt_2 = new TextBox();
            txt_3 = new TextBox();
            txt_4 = new TextBox();
            txt_1 = new TextBox();
            lbl_numero = new Label();
            pb_img = new PictureBox();
            lbl_info = new Label();
            btn_corrige = new Button();
            btn_confirma = new Button();
            btn_branco = new Button();
            btn_0 = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            candidateBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)candidateBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBox1);
            splitContainer1.Panel1.Controls.Add(lbl_nome);
            splitContainer1.Panel1.Controls.Add(lbl_partido);
            splitContainer1.Panel1.Controls.Add(txt_5);
            splitContainer1.Panel1.Controls.Add(txt_2);
            splitContainer1.Panel1.Controls.Add(txt_3);
            splitContainer1.Panel1.Controls.Add(txt_4);
            splitContainer1.Panel1.Controls.Add(txt_1);
            splitContainer1.Panel1.Controls.Add(lbl_numero);
            splitContainer1.Panel1.Controls.Add(pb_img);
            splitContainer1.Panel1.Controls.Add(lbl_info);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Black;
            splitContainer1.Panel2.Controls.Add(btn_corrige);
            splitContainer1.Panel2.Controls.Add(btn_confirma);
            splitContainer1.Panel2.Controls.Add(btn_branco);
            splitContainer1.Panel2.Controls.Add(btn_0);
            splitContainer1.Panel2.Controls.Add(btn_9);
            splitContainer1.Panel2.Controls.Add(btn_8);
            splitContainer1.Panel2.Controls.Add(btn_7);
            splitContainer1.Panel2.Controls.Add(btn_6);
            splitContainer1.Panel2.Controls.Add(btn_5);
            splitContainer1.Panel2.Controls.Add(btn_4);
            splitContainer1.Panel2.Controls.Add(btn_3);
            splitContainer1.Panel2.Controls.Add(btn_2);
            splitContainer1.Panel2.Controls.Add(btn_1);
            splitContainer1.Panel2.ForeColor = SystemColors.ButtonHighlight;
            splitContainer1.Size = new Size(1154, 816);
            splitContainer1.SplitterDistance = 690;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "\t\t\tLISTA DE CANDIDATOS", "", "{DEPUTADO FEDERAL}\t\t", "", "* PAULO SANGES = 6666\t\t", "* EDUARDO MARCIAL = 2424  \t", "\t\t\t\t", "{DEPUTADO ESTADUAL}\t\t\t", "", "* PABLO MARÇAL = 28288 \t\t", "* KELL = 77777", "", "{SENADOR}", "", "* CARAMELO = 321", "* VICTOR = 212\t\t  ", "* KENAN = 215 \t", "", "{GOVERNADOR}", "", "* CHICO MOEDAS = 21", "", "{PRESIDENTE}", "", "* LEONARDO = 25", "* PAULO         = 66" });
            listBox1.Location = new Point(37, 671);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(571, 104);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome.Location = new Point(37, 583);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(94, 35);
            lbl_nome.TabIndex = 9;
            lbl_nome.Text = "Nome:";
            // 
            // lbl_partido
            // 
            lbl_partido.AutoSize = true;
            lbl_partido.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_partido.Location = new Point(37, 633);
            lbl_partido.Name = "lbl_partido";
            lbl_partido.Size = new Size(107, 35);
            lbl_partido.TabIndex = 8;
            lbl_partido.Text = "Partido:";
            // 
            // txt_5
            // 
            txt_5.Enabled = false;
            txt_5.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            txt_5.Location = new Point(397, 421);
            txt_5.Margin = new Padding(3, 4, 3, 4);
            txt_5.Multiline = true;
            txt_5.Name = "txt_5";
            txt_5.Size = new Size(51, 79);
            txt_5.TabIndex = 7;
            txt_5.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_2
            // 
            txt_2.Enabled = false;
            txt_2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            txt_2.Location = new Point(222, 421);
            txt_2.Margin = new Padding(3, 4, 3, 4);
            txt_2.Multiline = true;
            txt_2.Name = "txt_2";
            txt_2.Size = new Size(51, 79);
            txt_2.TabIndex = 6;
            txt_2.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_3
            // 
            txt_3.Enabled = false;
            txt_3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            txt_3.Location = new Point(280, 421);
            txt_3.Margin = new Padding(3, 4, 3, 4);
            txt_3.Multiline = true;
            txt_3.Name = "txt_3";
            txt_3.Size = new Size(51, 79);
            txt_3.TabIndex = 5;
            txt_3.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_4
            // 
            txt_4.Enabled = false;
            txt_4.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            txt_4.Location = new Point(338, 421);
            txt_4.Margin = new Padding(3, 4, 3, 4);
            txt_4.Multiline = true;
            txt_4.Name = "txt_4";
            txt_4.Size = new Size(51, 79);
            txt_4.TabIndex = 4;
            txt_4.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_1
            // 
            txt_1.Enabled = false;
            txt_1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            txt_1.Location = new Point(163, 421);
            txt_1.Margin = new Padding(3, 4, 3, 4);
            txt_1.Multiline = true;
            txt_1.Name = "txt_1";
            txt_1.Size = new Size(51, 79);
            txt_1.TabIndex = 3;
            txt_1.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_numero
            // 
            lbl_numero.AutoSize = true;
            lbl_numero.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_numero.Location = new Point(37, 436);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(119, 35);
            lbl_numero.TabIndex = 2;
            lbl_numero.Text = "Número:";
            // 
            // pb_img
            // 
            pb_img.BorderStyle = BorderStyle.FixedSingle;
            pb_img.Location = new Point(434, 48);
            pb_img.Margin = new Padding(3, 4, 3, 4);
            pb_img.Name = "pb_img";
            pb_img.Size = new Size(200, 274);
            pb_img.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_img.TabIndex = 1;
            pb_img.TabStop = false;
            // 
            // lbl_info
            // 
            lbl_info.AutoSize = true;
            lbl_info.BorderStyle = BorderStyle.Fixed3D;
            lbl_info.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_info.Location = new Point(37, 65);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(186, 48);
            lbl_info.TabIndex = 0;
            lbl_info.Text = "SEU VOTO";
            // 
            // btn_corrige
            // 
            btn_corrige.BackColor = Color.Orange;
            btn_corrige.FlatAppearance.BorderColor = Color.Black;
            btn_corrige.FlatAppearance.BorderSize = 0;
            btn_corrige.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_corrige.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_corrige.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_corrige.ForeColor = Color.Black;
            btn_corrige.Location = new Point(142, 633);
            btn_corrige.Margin = new Padding(3, 4, 3, 4);
            btn_corrige.Name = "btn_corrige";
            btn_corrige.Size = new Size(139, 72);
            btn_corrige.TabIndex = 12;
            btn_corrige.Text = "CORRIGE";
            btn_corrige.UseVisualStyleBackColor = false;
            btn_corrige.Click += btn_corrige_Click;
            // 
            // btn_confirma
            // 
            btn_confirma.BackColor = Color.Lime;
            btn_confirma.FlatAppearance.BorderColor = Color.Black;
            btn_confirma.FlatAppearance.BorderSize = 0;
            btn_confirma.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_confirma.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_confirma.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_confirma.ForeColor = Color.Black;
            btn_confirma.Location = new Point(288, 633);
            btn_confirma.Margin = new Padding(3, 4, 3, 4);
            btn_confirma.Name = "btn_confirma";
            btn_confirma.Size = new Size(159, 72);
            btn_confirma.TabIndex = 11;
            btn_confirma.Text = "CONFIRMA";
            btn_confirma.UseVisualStyleBackColor = false;
            btn_confirma.Click += btn_confirma_Click;
            // 
            // btn_branco
            // 
            btn_branco.BackColor = Color.White;
            btn_branco.FlatAppearance.BorderColor = Color.Black;
            btn_branco.FlatAppearance.BorderSize = 0;
            btn_branco.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_branco.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_branco.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_branco.ForeColor = Color.Black;
            btn_branco.Location = new Point(14, 633);
            btn_branco.Margin = new Padding(3, 4, 3, 4);
            btn_branco.Name = "btn_branco";
            btn_branco.Size = new Size(122, 72);
            btn_branco.TabIndex = 10;
            btn_branco.Text = "BRANCO";
            btn_branco.UseVisualStyleBackColor = false;
            btn_branco.Click += btn_branco_Click;
            // 
            // btn_0
            // 
            btn_0.BackColor = Color.FromArgb(64, 64, 64);
            btn_0.FlatAppearance.BorderColor = Color.Black;
            btn_0.FlatAppearance.BorderSize = 0;
            btn_0.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_0.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_0.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_0.ForeColor = SystemColors.ButtonHighlight;
            btn_0.Location = new Point(175, 532);
            btn_0.Margin = new Padding(3, 4, 3, 4);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(91, 72);
            btn_0.TabIndex = 9;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = false;
            btn_0.Click += btn_0_Click;
            // 
            // btn_9
            // 
            btn_9.BackColor = Color.FromArgb(64, 64, 64);
            btn_9.FlatAppearance.BorderColor = Color.Black;
            btn_9.FlatAppearance.BorderSize = 0;
            btn_9.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_9.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_9.ForeColor = SystemColors.ButtonHighlight;
            btn_9.Location = new Point(288, 436);
            btn_9.Margin = new Padding(3, 4, 3, 4);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(91, 72);
            btn_9.TabIndex = 8;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = false;
            btn_9.Click += btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.BackColor = Color.FromArgb(64, 64, 64);
            btn_8.FlatAppearance.BorderColor = Color.Black;
            btn_8.FlatAppearance.BorderSize = 0;
            btn_8.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_8.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_8.ForeColor = SystemColors.ButtonHighlight;
            btn_8.Location = new Point(175, 436);
            btn_8.Margin = new Padding(3, 4, 3, 4);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(91, 72);
            btn_8.TabIndex = 7;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += btn_8_Click;
            // 
            // btn_7
            // 
            btn_7.BackColor = Color.FromArgb(64, 64, 64);
            btn_7.FlatAppearance.BorderColor = Color.Black;
            btn_7.FlatAppearance.BorderSize = 0;
            btn_7.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_7.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_7.ForeColor = SystemColors.ButtonHighlight;
            btn_7.Location = new Point(62, 436);
            btn_7.Margin = new Padding(3, 4, 3, 4);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(91, 72);
            btn_7.TabIndex = 6;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += btn_7_Click;
            // 
            // btn_6
            // 
            btn_6.BackColor = Color.FromArgb(64, 64, 64);
            btn_6.FlatAppearance.BorderColor = Color.Black;
            btn_6.FlatAppearance.BorderSize = 0;
            btn_6.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_6.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_6.ForeColor = SystemColors.ButtonHighlight;
            btn_6.Location = new Point(288, 344);
            btn_6.Margin = new Padding(3, 4, 3, 4);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(91, 72);
            btn_6.TabIndex = 5;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.BackColor = Color.FromArgb(64, 64, 64);
            btn_5.FlatAppearance.BorderColor = Color.Black;
            btn_5.FlatAppearance.BorderSize = 0;
            btn_5.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_5.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_5.ForeColor = SystemColors.ButtonHighlight;
            btn_5.Location = new Point(175, 344);
            btn_5.Margin = new Padding(3, 4, 3, 4);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(91, 72);
            btn_5.TabIndex = 4;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.BackColor = Color.FromArgb(64, 64, 64);
            btn_4.FlatAppearance.BorderColor = Color.Black;
            btn_4.FlatAppearance.BorderSize = 0;
            btn_4.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_4.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_4.ForeColor = SystemColors.ButtonHighlight;
            btn_4.Location = new Point(62, 344);
            btn_4.Margin = new Padding(3, 4, 3, 4);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(91, 72);
            btn_4.TabIndex = 3;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += btn_4_Click;
            // 
            // btn_3
            // 
            btn_3.BackColor = Color.FromArgb(64, 64, 64);
            btn_3.FlatAppearance.BorderColor = Color.Black;
            btn_3.FlatAppearance.BorderSize = 0;
            btn_3.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_3.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_3.ForeColor = SystemColors.ButtonHighlight;
            btn_3.Location = new Point(288, 251);
            btn_3.Margin = new Padding(3, 4, 3, 4);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(91, 72);
            btn_3.TabIndex = 2;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += btn_3_Click;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.FromArgb(64, 64, 64);
            btn_2.FlatAppearance.BorderColor = Color.Black;
            btn_2.FlatAppearance.BorderSize = 0;
            btn_2.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_2.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_2.ForeColor = SystemColors.ButtonHighlight;
            btn_2.Location = new Point(175, 251);
            btn_2.Margin = new Padding(3, 4, 3, 4);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(91, 72);
            btn_2.TabIndex = 1;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += btn_2_Click;
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.FromArgb(64, 64, 64);
            btn_1.FlatAppearance.BorderColor = Color.Black;
            btn_1.FlatAppearance.BorderSize = 0;
            btn_1.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_1.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_1.ForeColor = SystemColors.ButtonHighlight;
            btn_1.Location = new Point(62, 251);
            btn_1.Margin = new Padding(3, 4, 3, 4);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(91, 72);
            btn_1.TabIndex = 0;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += btn_1_Click;
            // 
            // candidateBindingSource
            // 
            candidateBindingSource.DataSource = typeof(Candidate);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1154, 816);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Urna Eletrônica";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)candidateBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btn_1;
        private Button btn_3;
        private Button btn_2;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_corrige;
        private Button btn_confirma;
        private Button btn_branco;
        private Button btn_0;
        private TextBox txt_1;
        private Label lbl_numero;
        private PictureBox pb_img;
        private Label lbl_info;
        private Label lbl_nome;
        private Label lbl_partido;
        private TextBox txt_5;
        private TextBox txt_2;
        private TextBox txt_3;
        private TextBox txt_4;
        private ListBox listBox1;
        private BindingSource candidateBindingSource;
    }
}