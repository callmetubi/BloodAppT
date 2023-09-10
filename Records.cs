using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodApp
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }
        int counter = 1;
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

        private void Records_Load(object sender, EventArgs e)
        {
            label4.Text = uniqueId.Count.ToString();
            if (uniqueId.Count!=0)
            {
                label2.Text = "1";
                label20.Text = uniqueId[0].ToString();
                label19.Text = Name[0].ToString();
                label18.Text = Surname[0].ToString();
                label17.Text = SocialId[0].ToString();
                label16.Text = PhoneNumber[0].ToString();
                label15.Text = Email[0].ToString();
                label14.Text = BloodType[0].ToString();
                label13.Text = date[0].ToString();
                pictureBox1.ImageLocation = ImageLoc[0].ToString();
            }
            else
            {
                label2.Text = "0";
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(uniqueId.Count != 0)
            {
                if (counter != 0)
                {
                    label2.Text = Convert.ToString(counter);
                    counter--;
                    label20.Text = uniqueId[counter].ToString();
                    label19.Text = Name[counter].ToString();
                    label18.Text = Surname[counter].ToString();
                    label17.Text = SocialId[counter].ToString();
                    label16.Text = PhoneNumber[counter].ToString();
                    label15.Text = Email[counter].ToString();
                    label14.Text = BloodType[counter].ToString();
                    label13.Text = date[counter].ToString();
                    pictureBox1.ImageLocation = ImageLoc[counter].ToString();
                }
            }   
        }
        private void button2_Click(object sender, EventArgs e)
        {    
            if (uniqueId.Count != 0&&counter< uniqueId.Count)
            {
                
                label2.Text = Convert.ToString(counter+1);
                label20.Text = uniqueId[counter].ToString();
                label19.Text = Name[counter].ToString();
                label18.Text = Surname[counter].ToString();
                label17.Text = SocialId[counter].ToString();
                label16.Text = PhoneNumber[counter].ToString();
                label15.Text = Email[counter].ToString();
                label14.Text = BloodType[counter].ToString();
                label13.Text = date[counter].ToString();
                pictureBox1.ImageLocation = ImageLoc[counter].ToString();
                counter++;
            }
            if (counter== uniqueId.Count)
            {
                counter = uniqueId.Count - 1;
            }     
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
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
            form.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (uniqueId.Count != 0)
            {
                bool mv = true;
                while (mv)
                {
                    try
                    {
                        bloodDic.Remove(uniqueId[counter]);
                        uniqueId.RemoveAt(counter);
                        date.RemoveAt(counter);
                        Name.RemoveAt(counter);
                        Surname.RemoveAt(counter);
                        SocialId.RemoveAt(counter);
                        PhoneNumber.RemoveAt(counter);
                        Email.RemoveAt(counter);
                        BloodType.RemoveAt(counter);
                        ImageLoc.RemoveAt(counter);
                        Form1 form = new Form1();
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
                        form.Show();
                        this.Hide();
                        mv = false;
                    }
                    catch
                    {
                        counter--;
                    }
                }
                
            }
        }
    }
}
