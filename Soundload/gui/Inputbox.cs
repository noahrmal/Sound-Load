using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoundCloudDownloader
{
    public partial class form_Inputbox : Form
    {

        private string name;
        
        public form_Inputbox()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            this.name = textBox1.Text;
        }

        public string getName{
            get { return name; } 
        }

        private void form_Inputbox_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

    }
}
