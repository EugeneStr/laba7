using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> Picture = new Dictionary<string, string>();

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int count = NameListBox.SelectedIndex;
            MassaListBox.ClearSelected();
            NameListBox.ClearSelected();
            if (count != -1)
            {
                NameListBox.Items.RemoveAt(count);
                MassaListBox.Items.RemoveAt(count);
                PictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("Не выбрано название вещества", "ERROR");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameListBox.Items.Clear();
            MassaListBox.Items.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddGroupBox.Visible = true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OKButton2_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(FileTextBox.Text))
            {
                MessageBox.Show("Неверно указан путь к файлу", "ERROR");
            }
            else
            {
                MassaListBox.Items.Add(MassaTextBox.Text);
                NameListBox.Items.Add(SubstanceTextBox.Text);
                Picture.Add(SubstanceTextBox.Text, FileTextBox.Text);

                SubstanceTextBox.Text = "";
                MassaTextBox.Text = "";
                FileTextBox.Text = "";
                AddGroupBox.Visible = false;
            }
            
        }

        private void CancelButton2_Click(object sender, EventArgs e)
        {
            SubstanceTextBox.Text = "";
            MassaTextBox.Text = "";
            AddGroupBox.Visible = false;
        }

        private void NameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NameListBox.SelectedIndex != -1)
            {
                MassaListBox.SetSelected(NameListBox.SelectedIndex, true);
                PictureBox.Load(Picture[NameListBox.SelectedItem.ToString()]);
            }  
        }

        private void MassaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            var source = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                source = openFileDialog.FileName;
            }
            FileTextBox.Text = source;
        }

        private void MassaTextBox_TextChanged(object sender, EventArgs e)
        {
            Error();
        }

        private void SubstanceTextBox_TextChanged(object sender, EventArgs e)
        {
            Error();
        }

        private void FileTextBox_TextChanged(object sender, EventArgs e)
        {
            Error();
        }

        void Error()
        {
            if (SubstanceTextBox.Text != "" && MassaTextBox.Text != "" && FileTextBox.Text != "" && double.TryParse(MassaTextBox.Text, out var parsedNumber))
            {
                OKButton2.Enabled = true;
            }
            else
            {
                OKButton2.Enabled = false;
            }
        }
    }
}
