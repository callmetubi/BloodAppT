using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BloodApp
{
    public partial class DonateForm : Form
    {
        public DonateForm()
        {
            InitializeComponent();
        }
        public Dictionary<int, string> bloodDic = new Dictionary<int, string>();
        public List<int> uniqueId = new List<int>();
        public List<string> date = new List<string>();
        public List<string> Name = new List<string>();
        public List<string> Surname = new List<string>();
        public List<string> SocialId = new List<string>();
        public List<string> PhoneNumber = new List<string>();
        public List<string> Email = new List<string>();
        public List<string> BloodType = new List<string>();
        public List<string> ImageLoc = new List<string>();
        CheckEmail CheckEmail = new CheckEmail(); 
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckEmail.IsValidEmail(textBox6.Text) == true)
            {
                if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && label10.Text != "")
                {
                    Random random = new Random();
                    int val = random.Next(1, 10000000);
                    string FileLoc= "BloodTxt\\blood.txt";
                    if (File.Exists(FileLoc)) //if the file exists
                    {
                        FileStream fs = new FileStream("BloodTxt\\blood.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.Write("\n" + val.ToString() + ";");
                        sw.Write(DateTime.Now.ToString() + ";");
                        sw.Write(textBox2.Text + ";");
                        sw.Write(textBox3.Text + ";");
                        sw.Write(textBox4.Text + ";");
                        sw.Write(textBox5.Text + ";");
                        sw.Write(textBox6.Text + ";");
                        sw.Write(comboBox1.SelectedItem + ";");
                        sw.Write(label10.Text + ";");
                        sw.Close();
                        MessageBox.Show("Added");
                        uniqueId.Add(val);
                        bloodDic.Add(val, textBox2.Text);
                        Name.Add(textBox2.Text);
                        Surname.Add(textBox3.Text);
                        date.Add(DateTime.Now.ToString());
                        SocialId.Add(textBox4.Text);
                        PhoneNumber.Add(textBox5.Text);
                        Email.Add(textBox6.Text);
                        BloodType.Add(comboBox1.SelectedItem.ToString());
                        ImageLoc.Add(label10.Text);
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        label10.Text = "";
                        pictureBox1.ImageLocation = @"Images\indir.png";
                    }
                    else
                    {
                        MessageBox.Show("blood.txt file not found!!");
                    }
                }
                else
                {
                    MessageBox.Show("Unexpected Data!!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Email Format!");
            }
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            string dir = System.IO.Path.GetFullPath("Images");//getting the path of the folder
            dlg.InitialDirectory = dir;
            using (dlg)
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);//an object used to work with images defined by pixel data
                    string s = System.IO.Path.GetFullPath(dlg.FileName);//getting the path of the Image
                    string sourceFile = s;
                    string destinationFile = dir+"\\"+textBox2.Text+".jpg";
                    staticClass.İmageF(sourceFile, destinationFile);
                    label10.Text = destinationFile;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            form.bloodDic = bloodDic;
            form.uniqueId = uniqueId;
            form.date = date;
            form.Name = Name;
            form.Surname = Surname;
            form.SocialId = SocialId;
            form.PhoneNumber = PhoneNumber;
            form.Email = Email;
            form.BloodType = BloodType;
            form.ImageLoc = ImageLoc;
            this.Hide();
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&//checking to enter correct data from the keyboard
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))//checking to enter correct data from the keyboard
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&//checking to enter correct data from the keyboard
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))//checking to enter correct data from the keyboard
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);//checking to enter correct data from the keyboard
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);//checking to enter correct data from the keyboard
        }

        private void DonateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
