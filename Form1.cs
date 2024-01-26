using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__sharp__ASSESSMENT_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add item to listbox from textbox
            string newItem = textBox1.Text;
            if (!
                string.IsNullOrEmpty(newItem)) ;
            {
                listBox1.Items.Add(newItem);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //remove selected items  from ListBox
            if (listBox1.SelectedIndex!= -1) ;
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //change selected items in ListBox based on TextBox input
            if (listBox1.SelectedIndex != -1) ;
            {
                string updatedItem = textBox1.Text;
                if (!string.IsNullOrEmpty(updatedItem)) ;
                {
                    listBox1.Items[listBox1.SelectedIndex] = updatedItem;
                    textBox1.Clear();
                }
            }
                }

        private void button4_Click(object sender, EventArgs e)
        {
            //Clear items from ListBox
            listBox1.Items.Clear();
        }
    }
        }
          
        
    

