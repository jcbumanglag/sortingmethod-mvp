using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sorting.Views;
using Sorting.Presenters;
namespace Sorting
{
    public partial class Form1 : Form,Isortmethod
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public string textbox1
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }


        public string textres1
        {
            get
            {
                var list = new List<string>();
                foreach(var item in label1.Items)
                {
                    list.Add(item.ToString());
                }
                return label1.Text;
            }
            set
            {
                label1.Items.Add("Sorted: "+ value);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Quick Sort";
        }
         
  
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("") || textBox1.Text.Equals(null))
            {

                MessageBox.Show("Invalid Input");

            }
            else 
            {
                sortmethodpresenter presenter = new sortmethodpresenter(this);
                presenter.sorting();
            }
       
        }

    

   





    }
}
