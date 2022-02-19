using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webbutton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        
        private void addButton_Click(object sender, EventArgs e)
        {
           Form3 studentForm = new Form3();//окно создания

            if (studentForm.ShowDialog() == DialogResult.OK)
            {
                //Записываем все введённые данные в DataGridView
                TreeNode newNode = new TreeNode(studentForm.nameTextBox.Text);
                MainTreeView.Nodes[studentForm.GroupComboBox.SelectedIndex].Nodes.Add(newNode);

                MainDataGridView.Rows.Add(studentForm.nameTextBox.Text,
                studentForm.AgeNumericUpDown.Value, studentForm.DescriptionRichTextBox.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)//считывание с файла
        {
            OpenFileDialog ofd = new OpenFileDialog();
            byte index;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName);

                for (int i = 0; i < lines.Length; i++)
                {
                    //Деление строки по пробелам на имя-возраст-описание-группа
                    string[] line = lines[i].Split();

                    //Добавление в соответствующие ячейки одно из ряда этих значений
                    MainDataGridView.Rows.Add(line[0], line[1], line[2]);
                    if (line[3].Equals("09-121"))
                    {
                        index = 0;
                    }
                    else
                    {
                        index = 1;
                    }

                    MainTreeView.Nodes[index].Nodes.Add(line[0]);
                }
                File.WriteAllLines(ofd.FileName, lines);
            }
        }

        private void MainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)//редактирование
        {
            Form4 studentEdit = new Form4();

            if (studentEdit.ShowDialog() == DialogResult.OK)
            {
                //Перепись данных в таблице
                MainDataGridView.Rows[e.RowIndex].SetValues(studentEdit.NameTextBox2.Text,
                studentEdit.AgeNumericUpDown2.Value, studentEdit.DescriptionRichTextBox2.Text);

                //создание в TreeView
                TreeNode newNode = new TreeNode(studentEdit.NameTextBox2.Text);

                MainTreeView.Nodes[studentEdit.GroupComboBox2.SelectedIndex].Nodes.Add(newNode);
            }
        }
    }
}
