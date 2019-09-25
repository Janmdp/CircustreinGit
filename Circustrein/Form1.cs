using System;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Form1 : Form
    {
        private Train train = new Train();
        private Type.typeAnimal send = Type.typeAnimal.Herbivore;

        public Form1()
        {
            InitializeComponent();
        }

        public void updateInterfaces()
        {
            listBoxAnimals.Items.Clear();
            listBoxWagons.Items.Clear();
            foreach (Animal animal in train.Animals)
            {
                listBoxAnimals.Items.Add(animal);
            }
            foreach (Wagon wagon in train.Wagons)
            {
                listBoxWagons.Items.Add(wagon);
            }
        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            if (train.AddAnimal(textBoxName.Text, Convert.ToInt32(comboBoxSize.Text.Substring(0, 1)), send))
            {
                updateInterfaces();
            }
            else
            {
                MessageBox.Show("New wagon generated");
                updateInterfaces();
            }
        }

        private void CheckBoxCarnivore_CheckedChanged(object sender, EventArgs e)
        {
            send = Type.typeAnimal.Carnivore;
        }
    }
}