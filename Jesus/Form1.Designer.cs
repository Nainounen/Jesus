namespace Jesus
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtboxName = new TextBox();
            txtboxAdresse = new TextBox();
            txtboxZeit = new TextBox();
            txtboxAufgabe = new TextBox();
            txtboxVollständigkeit = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnAddCol = new Button();
            btnEdit = new Button();
            label10 = new Label();
            label11 = new Label();
            txtboxNameCol = new TextBox();
            txtboxTextCol = new TextBox();
            dgv = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            adresse = new DataGridViewTextBoxColumn();
            abgabe = new DataGridViewTextBoxColumn();
            aufgabe = new DataGridViewTextBoxColumn();
            zeit = new DataGridViewTextBoxColumn();
            Vollständigkeit = new DataGridViewTextBoxColumn();
            label12 = new Label();
            txtboxAbgabe = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Picture;
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 171);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(623, 541);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(631, 549);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(639, 557);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 297);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 215);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 6;
            label6.Text = "Adresse";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(38, 340);
            label7.Name = "label7";
            label7.Size = new Size(142, 28);
            label7.TabIndex = 7;
            label7.Text = "Vollständigkeit";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(38, 297);
            label8.Name = "label8";
            label8.Size = new Size(86, 28);
            label8.TabIndex = 8;
            label8.Text = "Aufgabe";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(39, 255);
            label9.Name = "label9";
            label9.Size = new Size(45, 28);
            label9.TabIndex = 9;
            label9.Text = "Zeit";
            // 
            // txtboxName
            // 
            txtboxName.Location = new Point(224, 175);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(222, 27);
            txtboxName.TabIndex = 10;
            // 
            // txtboxAdresse
            // 
            txtboxAdresse.Location = new Point(224, 219);
            txtboxAdresse.Name = "txtboxAdresse";
            txtboxAdresse.Size = new Size(222, 27);
            txtboxAdresse.TabIndex = 11;
            // 
            // txtboxZeit
            // 
            txtboxZeit.Location = new Point(224, 259);
            txtboxZeit.Name = "txtboxZeit";
            txtboxZeit.Size = new Size(222, 27);
            txtboxZeit.TabIndex = 12;
            // 
            // txtboxAufgabe
            // 
            txtboxAufgabe.Location = new Point(224, 297);
            txtboxAufgabe.Name = "txtboxAufgabe";
            txtboxAufgabe.Size = new Size(222, 27);
            txtboxAufgabe.TabIndex = 13;
            // 
            // txtboxVollständigkeit
            // 
            txtboxVollständigkeit.Location = new Point(224, 340);
            txtboxVollständigkeit.Name = "txtboxVollständigkeit";
            txtboxVollständigkeit.Size = new Size(222, 27);
            txtboxVollständigkeit.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(38, 460);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(211, 57);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(38, 549);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(211, 57);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button2_Click;
            // 
            // btnAddCol
            // 
            btnAddCol.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCol.Location = new Point(265, 549);
            btnAddCol.Name = "btnAddCol";
            btnAddCol.Size = new Size(211, 57);
            btnAddCol.TabIndex = 17;
            btnAddCol.Text = "Add Column";
            btnAddCol.UseVisualStyleBackColor = true;
            btnAddCol.Click += btnAddCol_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(265, 460);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(211, 57);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(38, 637);
            label10.Name = "label10";
            label10.Size = new Size(64, 28);
            label10.TabIndex = 19;
            label10.Text = "Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(38, 683);
            label11.Name = "label11";
            label11.Size = new Size(46, 28);
            label11.TabIndex = 20;
            label11.Text = "Text";
            // 
            // txtboxNameCol
            // 
            txtboxNameCol.Location = new Point(224, 684);
            txtboxNameCol.Name = "txtboxNameCol";
            txtboxNameCol.Size = new Size(222, 27);
            txtboxNameCol.TabIndex = 21;
            // 
            // txtboxTextCol
            // 
            txtboxTextCol.Location = new Point(224, 641);
            txtboxTextCol.Name = "txtboxTextCol";
            txtboxTextCol.Size = new Size(222, 27);
            txtboxTextCol.TabIndex = 22;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { name, adresse, abgabe, aufgabe, zeit, Vollständigkeit });
            dgv.Dock = DockStyle.Right;
            dgv.Location = new Point(548, 0);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(996, 1102);
            dgv.TabIndex = 23;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // adresse
            // 
            adresse.HeaderText = "Adresse";
            adresse.MinimumWidth = 6;
            adresse.Name = "adresse";
            adresse.ReadOnly = true;
            adresse.Width = 125;
            // 
            // abgabe
            // 
            abgabe.HeaderText = "Abgabe";
            abgabe.MinimumWidth = 6;
            abgabe.Name = "abgabe";
            abgabe.ReadOnly = true;
            abgabe.Width = 125;
            // 
            // aufgabe
            // 
            aufgabe.HeaderText = "Aufgabe";
            aufgabe.MinimumWidth = 6;
            aufgabe.Name = "aufgabe";
            aufgabe.ReadOnly = true;
            aufgabe.Width = 125;
            // 
            // zeit
            // 
            zeit.HeaderText = "Zeit";
            zeit.MinimumWidth = 6;
            zeit.Name = "zeit";
            zeit.ReadOnly = true;
            zeit.Width = 125;
            // 
            // Vollständigkeit
            // 
            Vollständigkeit.HeaderText = "Vollständigkeit";
            Vollständigkeit.MinimumWidth = 6;
            Vollständigkeit.Name = "Vollständigkeit";
            Vollständigkeit.ReadOnly = true;
            Vollständigkeit.Width = 125;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(38, 380);
            label12.Name = "label12";
            label12.Size = new Size(81, 28);
            label12.TabIndex = 24;
            label12.Text = "Abgabe";
            // 
            // txtboxAbgabe
            // 
            txtboxAbgabe.Location = new Point(224, 384);
            txtboxAbgabe.Name = "txtboxAbgabe";
            txtboxAbgabe.Size = new Size(222, 27);
            txtboxAbgabe.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1544, 1102);
            Controls.Add(txtboxAbgabe);
            Controls.Add(label12);
            Controls.Add(dgv);
            Controls.Add(txtboxTextCol);
            Controls.Add(txtboxNameCol);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnEdit);
            Controls.Add(btnAddCol);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtboxVollständigkeit);
            Controls.Add(txtboxAufgabe);
            Controls.Add(txtboxZeit);
            Controls.Add(txtboxAdresse);
            Controls.Add(txtboxName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtboxName;
        private TextBox txtboxAdresse;
        private TextBox txtboxZeit;
        private TextBox txtboxAufgabe;
        private TextBox txtboxVollständigkeit;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnAddCol;
        private Button btnEdit;
        private Label label10;
        private Label label11;
        private TextBox txtboxNameCol;
        private TextBox txtboxTextCol;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn adresse;
        private DataGridViewTextBoxColumn abgabe;
        private DataGridViewTextBoxColumn aufgabe;
        private DataGridViewTextBoxColumn zeit;
        private DataGridViewTextBoxColumn Vollständigkeit;
        private Label label12;
        private TextBox txtboxAbgabe;
    }
}