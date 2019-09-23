using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Form1 : Form
    {
        Train train = new Train();
        public Form1()
        {
            InitializeComponent();
        }

        public void updateInterfaces()
        {
            listBoxAnimals.Items.Clear();
            listBoxWagons.Items.Clear();
            foreach(Animal animal in train.Animals)
            {
                listBoxAnimals.Items.Add(animal);
            }
            foreach(Wagon wagon in train.Wagons)
            {
                listBoxWagons.Items.Add(wagon);
            }
        }
        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            if (train.AddAnimal(textBoxName.Text, Convert.ToInt32(comboBoxSize.Text.Substring(0, 1)), checkBoxCarnivore.Checked))
            {
                updateInterfaces();
            }
            else
            {
                MessageBox.Show("New wagon generated");
                updateInterfaces();
            }

            
        }
    }
}
