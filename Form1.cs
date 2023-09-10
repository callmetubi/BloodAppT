using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodApp
{
    public partial class Form1 : Form
    {
        public Form1()
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
        private void button1_Click(object sender, EventArgs e)
        {
            DonateForm form = new DonateForm();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Records form = new Records();
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
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
