using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2_for9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //событие нажатия на кнопку
        private void button_solution_Click(object sender, EventArgs e)
        {
            float[] nums;
            try
            {
                nums = textBox_subsequeence.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => float.Parse(x)).ToArray();
                label_MinAnswer.Text = Logic.MinItems(nums);
                label_MaxAnswer.Text = Logic.MaxItems(nums);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы ввели не вверные символы!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //запрет ввода символов
        private void textBox_subsequeence_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '-' || e.KeyChar == ' ')
                return;
            else
            {
                MessageBox.Show("Следует вводить только число", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        //загрузка данных при запуске приложения 
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_subsequeence.Text = Properties.Settings.Default.subsequeence;
        }

        //сохранение данных при закрытии приложения
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.subsequeence = textBox_subsequeence.Text;
            Properties.Settings.Default.Save();
        }
    }
}
