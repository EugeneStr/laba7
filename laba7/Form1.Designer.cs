
namespace laba7
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
            this.NameListBox = new System.Windows.Forms.ListBox();
            this.MassaListBox = new System.Windows.Forms.ListBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MassaLabel = new System.Windows.Forms.Label();
            this.AddGroupBox = new System.Windows.Forms.GroupBox();
            this.CancelButton2 = new System.Windows.Forms.Button();
            this.OKButton2 = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.FileLabel = new System.Windows.Forms.Label();
            this.MassaLab = new System.Windows.Forms.Label();
            this.SubstanceLabel = new System.Windows.Forms.Label();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.MassaTextBox = new System.Windows.Forms.TextBox();
            this.SubstanceTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.AddGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameListBox
            // 
            this.NameListBox.FormattingEnabled = true;
            this.NameListBox.ItemHeight = 15;
            this.NameListBox.Location = new System.Drawing.Point(10, 47);
            this.NameListBox.Name = "NameListBox";
            this.NameListBox.Size = new System.Drawing.Size(188, 169);
            this.NameListBox.TabIndex = 0;
            this.NameListBox.SelectedIndexChanged += new System.EventHandler(this.NameListBox_SelectedIndexChanged);
            // 
            // MassaListBox
            // 
            this.MassaListBox.BackColor = System.Drawing.SystemColors.Window;
            this.MassaListBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MassaListBox.FormattingEnabled = true;
            this.MassaListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MassaListBox.ItemHeight = 15;
            this.MassaListBox.Location = new System.Drawing.Point(219, 47);
            this.MassaListBox.Name = "MassaListBox";
            this.MassaListBox.Size = new System.Drawing.Size(198, 169);
            this.MassaListBox.TabIndex = 1;
            this.MassaListBox.SelectedIndexChanged += new System.EventHandler(this.MassaListBox_SelectedIndexChanged);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(439, 47);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(192, 169);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(653, 60);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(133, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить...";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(653, 90);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(133, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(653, 119);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(133, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(653, 148);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(133, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(653, 178);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(133, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 26);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(108, 15);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Названия веществ";
            // 
            // MassaLabel
            // 
            this.MassaLabel.AutoSize = true;
            this.MassaLabel.Location = new System.Drawing.Point(219, 26);
            this.MassaLabel.Name = "MassaLabel";
            this.MassaLabel.Size = new System.Drawing.Size(170, 15);
            this.MassaLabel.TabIndex = 9;
            this.MassaLabel.Text = "Молекулярная масса, г/моль";
            // 
            // AddGroupBox
            // 
            this.AddGroupBox.Controls.Add(this.CancelButton2);
            this.AddGroupBox.Controls.Add(this.OKButton2);
            this.AddGroupBox.Controls.Add(this.FindButton);
            this.AddGroupBox.Controls.Add(this.FileLabel);
            this.AddGroupBox.Controls.Add(this.MassaLab);
            this.AddGroupBox.Controls.Add(this.SubstanceLabel);
            this.AddGroupBox.Controls.Add(this.FileTextBox);
            this.AddGroupBox.Controls.Add(this.MassaTextBox);
            this.AddGroupBox.Controls.Add(this.SubstanceTextBox);
            this.AddGroupBox.Location = new System.Drawing.Point(10, 254);
            this.AddGroupBox.Name = "AddGroupBox";
            this.AddGroupBox.Size = new System.Drawing.Size(621, 179);
            this.AddGroupBox.TabIndex = 11;
            this.AddGroupBox.TabStop = false;
            this.AddGroupBox.Text = "Добавить вещество";
            this.AddGroupBox.Visible = false;
            // 
            // CancelButton2
            // 
            this.CancelButton2.Location = new System.Drawing.Point(489, 109);
            this.CancelButton2.Name = "CancelButton2";
            this.CancelButton2.Size = new System.Drawing.Size(107, 23);
            this.CancelButton2.TabIndex = 8;
            this.CancelButton2.Text = "Отмена";
            this.CancelButton2.UseVisualStyleBackColor = true;
            this.CancelButton2.Click += new System.EventHandler(this.CancelButton2_Click);
            // 
            // OKButton2
            // 
            this.OKButton2.Enabled = false;
            this.OKButton2.Location = new System.Drawing.Point(489, 68);
            this.OKButton2.Name = "OKButton2";
            this.OKButton2.Size = new System.Drawing.Size(107, 23);
            this.OKButton2.TabIndex = 7;
            this.OKButton2.Text = "ОК";
            this.OKButton2.UseVisualStyleBackColor = true;
            this.OKButton2.Click += new System.EventHandler(this.OKButton2_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(383, 129);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(73, 24);
            this.FindButton.TabIndex = 6;
            this.FindButton.Text = "Обзор...";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(7, 129);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(96, 15);
            this.FileLabel.TabIndex = 5;
            this.FileLabel.Text = "Файл структуры";
            // 
            // MassaLab
            // 
            this.MassaLab.AutoSize = true;
            this.MassaLab.Location = new System.Drawing.Point(7, 88);
            this.MassaLab.Name = "MassaLab";
            this.MassaLab.Size = new System.Drawing.Size(170, 15);
            this.MassaLab.TabIndex = 4;
            this.MassaLab.Text = "Молекулярная масса, г/моль";
            // 
            // SubstanceLabel
            // 
            this.SubstanceLabel.AutoSize = true;
            this.SubstanceLabel.Location = new System.Drawing.Point(7, 46);
            this.SubstanceLabel.Name = "SubstanceLabel";
            this.SubstanceLabel.Size = new System.Drawing.Size(61, 15);
            this.SubstanceLabel.TabIndex = 3;
            this.SubstanceLabel.Text = "Вещество";
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(209, 129);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(247, 23);
            this.FileTextBox.TabIndex = 2;
            this.FileTextBox.TextChanged += new System.EventHandler(this.FileTextBox_TextChanged);
            // 
            // MassaTextBox
            // 
            this.MassaTextBox.Location = new System.Drawing.Point(209, 88);
            this.MassaTextBox.Name = "MassaTextBox";
            this.MassaTextBox.Size = new System.Drawing.Size(247, 23);
            this.MassaTextBox.TabIndex = 1;
            this.MassaTextBox.TextChanged += new System.EventHandler(this.MassaTextBox_TextChanged);
            // 
            // SubstanceTextBox
            // 
            this.SubstanceTextBox.Location = new System.Drawing.Point(209, 46);
            this.SubstanceTextBox.Name = "SubstanceTextBox";
            this.SubstanceTextBox.Size = new System.Drawing.Size(247, 23);
            this.SubstanceTextBox.TabIndex = 0;
            this.SubstanceTextBox.TextChanged += new System.EventHandler(this.SubstanceTextBox_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.AddGroupBox);
            this.Controls.Add(this.MassaLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.MassaListBox);
            this.Controls.Add(this.NameListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.AddGroupBox.ResumeLayout(false);
            this.AddGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NameListBox;
        private System.Windows.Forms.ListBox MassaListBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MassaLabel;
        private System.Windows.Forms.GroupBox AddGroupBox;
        private System.Windows.Forms.Button CancelButton2;
        private System.Windows.Forms.Button OKButton2;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Label MassaLab;
        private System.Windows.Forms.Label SubstanceLabel;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.TextBox MassaTextBox;
        private System.Windows.Forms.TextBox SubstanceTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

