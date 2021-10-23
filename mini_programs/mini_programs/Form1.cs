using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_programs
{
    public partial class MainForm : Form
    {
        int count = 0; // исходная переменная
        Random rnd;
        char[] spec_chars = new char[] {'%','*',')', '?', '#', '$', '^', '&', '~'};

        //обобщенный класс - ключ-значение (ключем является значение(mm, cm и т.д))
        Dictionary<string, double> metrica;

        //конструктор 
        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
            metrica = new Dictionary<string, double>(); // создали объект метрика
            // создаем конструктор и заполняем его (словарь)
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1000000);
            metrica.Add("mile", 1609344);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotepad();
            clbPassword.SetItemChecked(0, true); // метод для выбора необходимых строк при загрузке
            clbPassword.SetItemChecked(1, true);
            clbPassword.SetItemChecked(2, true);
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close(); // метод закрытия формы
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            // выводим сообщение с помощью данного метода
            MessageBox.Show("Программа мои утилиты, \nсодержит ряд небольших программ, \nкоторые могут пригодится в жизни. \nАвтор: Ростокин С.И.", "О программе");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = Convert.ToString(count);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString(); // добавляем переменную и преобразовываем её с помощью метода ToString

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblRandom_Click(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
            lblRandom.Text = n.ToString();
            if (cbRandom.Checked == true)
            {
                // условие исключающее повторение случайных чисел
                // Метод IndexOf ищет числа в строке. Создаем строку.

                int i = 0;

                while (tbRandom.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
                    i++;

                    if (i > 1000)
                        break;
                }
                if (i <= 1000)
                    tbRandom.AppendText(n + "\n");
            }
            else tbRandom.AppendText(n + "\n");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRandom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear(); // метод для очищения
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text); // Класс для работы с буфером обмена
        }

        private void cbRandom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsmilnsertDate_Click(object sender, EventArgs e)
        {
            rtbNotPack.AppendText(DateTime.Now.ToShortDateString() + "\n"); // метод для работы с временем
        }

        private void tsmilnsertTime_Click(object sender, EventArgs e)
        {
            rtbNotPack.AppendText(DateTime.Now.ToShortTimeString() + "\n"); // метод для работы с временем
        }

        private void rtbNotPack_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            // отлавливаем ошибки при сохранении
            try
            {
                rtbNotPack.SaveFile("notepad.rtf"); // сохранить файл
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении");
            }
        }
        void LoadNotepad()
        {
            try
            {
                rtbNotPack.LoadFile("notepad.rtf"); // загрузить файл
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке");
            }
        }
            private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }


        private void nudPassLeng_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clbPassword_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbPassworld_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;
            string password = "";
            for(int i = 0; i<nudPassLeng.Value; i++)
            {
                int n = rnd.Next(0, clbPassword.CheckedItems.Count); // CheckedItems список выбранных элементов
                string s = clbPassword.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры": password += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += spec_chars[rnd.Next(spec_chars.Length)];
                            break;
                }
                tbPassworld.Text = password;
                Clipboard.SetText(password);// скопировать пароль в буфер обмена
            }
        }

        private void cbFrom(object sender, EventArgs e)
        {

        }

        private void cbTo(object sender, EventArgs e)
        {

        }

        private void tbFrom(object sender, EventArgs e)
        {

        }

        private void tbTo(object sender, EventArgs e)
        {

        }

        private void btnConverter(object sender, EventArgs e)
        {
            double m1 = metrica[cbFrom111.Text];
            double m2 = metrica[cbTogg.Text];
            double n = Convert.ToDouble(textBox1.Text);
            textBox2.Text = (n * m1 / m2).ToString();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string t = cbFrom111.Text;
            cbFrom111.Text = cbTogg.Text;
            cbTogg.Text = t;

        }

        private void cbMetric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetric.Text)
            {
                case "длина":
                    metrica.Clear();// очищаем словарь
                    metrica.Add("mm", 1);
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1000);
                    metrica.Add("km", 1000000);
                    metrica.Add("mile", 1609344);
                    cbFrom111.Items.Clear();
                    cbFrom111.Items.Add("mm");
                    cbFrom111.Items.Add("cm");
                    cbFrom111.Items.Add("dm");
                    cbFrom111.Items.Add("m");
                    cbFrom111.Items.Add("km");
                    cbFrom111.Items.Add("mile");
                    cbTogg.Items.Clear();
                    cbTogg.Items.Add("mm");
                    cbTogg.Items.Add("cm");
                    cbTogg.Items.Add("dm");
                    cbTogg.Items.Add("m");
                    cbTogg.Items.Add("km");
                    cbTogg.Items.Add("mile");
                    cbFrom111.Text = "mm";
                    cbTogg.Text = "mm";
                    break;
                case "вес":
                    metrica.Clear();// очищаем словарь
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1000000);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 283);
                    cbFrom111.Items.Clear();
                    cbFrom111.Items.Add("g");
                    cbFrom111.Items.Add("kg");
                    cbFrom111.Items.Add("t");
                    cbFrom111.Items.Add("lb");
                    cbFrom111.Items.Add("oz");
                    cbTogg.Items.Clear();
                    cbTogg.Items.Add("g");
                    cbTogg.Items.Add("kg");
                    cbTogg.Items.Add("t");
                    cbTogg.Items.Add("lb");
                    cbTogg.Items.Add("oz");
                    cbFrom111.Text = "g";
                    cbTogg.Text = "g";
                    break;
                default:
                    break;
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
 }




