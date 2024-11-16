namespace FilmRecommendForm.App
{
    partial class Form1
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
            comboBoxMovieCategories = new ComboBox();
            comboBoxSubCategories = new ComboBox();
            dataGridViewMovies = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSavePdf = new Button();
            groupBox1 = new GroupBox();
            btnChart = new Button();
            btn_sendEmail = new Button();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxMovieCategories
            // 
            comboBoxMovieCategories.FormattingEnabled = true;
            comboBoxMovieCategories.Location = new Point(0, 36);
            comboBoxMovieCategories.Name = "comboBoxMovieCategories";
            comboBoxMovieCategories.Size = new Size(191, 28);
            comboBoxMovieCategories.TabIndex = 0;
            comboBoxMovieCategories.SelectedIndexChanged += comboBoxMovieCategories_SelectedIndexChanged;
            // 
            // comboBoxSubCategories
            // 
            comboBoxSubCategories.FormattingEnabled = true;
            comboBoxSubCategories.Location = new Point(228, 36);
            comboBoxSubCategories.Name = "comboBoxSubCategories";
            comboBoxSubCategories.Size = new Size(191, 28);
            comboBoxSubCategories.TabIndex = 1;
            comboBoxSubCategories.SelectedIndexChanged += comboBoxSubCategories_SelectedIndexChanged;
            // 
            // dataGridViewMovies
            // 
            dataGridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovies.Location = new Point(-9, 423);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.RowHeadersWidth = 51;
            dataGridViewMovies.Size = new Size(1307, 226);
            dataGridViewMovies.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 13);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 3;
            label1.Text = "Üst Kategoriyi Seçiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(228, 13);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 4;
            label2.Text = "Alt Kategoriyi Seçiniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Myanmar Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(399, -4);
            label3.Name = "label3";
            label3.Size = new Size(306, 60);
            label3.TabIndex = 6;
            label3.Text = "Film Seçim Ekranı\r\n";
            // 
            // btnSavePdf
            // 
            btnSavePdf.Location = new Point(200, 91);
            btnSavePdf.Name = "btnSavePdf";
            btnSavePdf.Size = new Size(150, 54);
            btnSavePdf.TabIndex = 7;
            btnSavePdf.Text = "PDF'e dönüştür";
            btnSavePdf.UseVisualStyleBackColor = true;
            btnSavePdf.Click += btnSavePdf_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_sendEmail);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(btnChart);
            groupBox1.Controls.Add(btnSavePdf);
            groupBox1.Controls.Add(comboBoxMovieCategories);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxSubCategories);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(272, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(582, 296);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // btnChart
            // 
            btnChart.Location = new Point(0, 91);
            btnChart.Name = "btnChart";
            btnChart.Size = new Size(135, 54);
            btnChart.TabIndex = 9;
            btnChart.Text = "Puan Grafiği";
            btnChart.UseVisualStyleBackColor = true;
            btnChart.Click += btnChart_Click;
            // 
            // btn_sendEmail
            // 
            btn_sendEmail.Location = new Point(411, 91);
            btn_sendEmail.Name = "btn_sendEmail";
            btn_sendEmail.Size = new Size(152, 54);
            btn_sendEmail.TabIndex = 10;
            btn_sendEmail.Text = "Mail Gönder";
            btn_sendEmail.UseVisualStyleBackColor = true;
            btn_sendEmail.Click += btn_sendEmail_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(438, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 642);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(dataGridViewMovies);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMovieCategories;
        private ComboBox comboBoxSubCategories;
        private DataGridView dataGridViewMovies;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSavePdf;
        private GroupBox groupBox1;
        private Button btnChart;
        private Button btn_sendEmail;
        private TextBox txtEmail;
    }
}