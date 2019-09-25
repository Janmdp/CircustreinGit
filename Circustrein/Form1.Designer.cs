namespace Circustrein
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxWagons = new System.Windows.Forms.ListBox();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.checkBoxCarnivore = new System.Windows.Forms.CheckBox();
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxWagons
            // 
            this.listBoxWagons.FormattingEnabled = true;
            this.listBoxWagons.ItemHeight = 16;
            this.listBoxWagons.Location = new System.Drawing.Point(130, 33);
            this.listBoxWagons.Name = "listBoxWagons";
            this.listBoxWagons.Size = new System.Drawing.Size(120, 228);
            this.listBoxWagons.TabIndex = 0;
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.ItemHeight = 16;
            this.listBoxAnimals.Location = new System.Drawing.Point(489, 33);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(120, 228);
            this.listBoxAnimals.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(289, 271);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(163, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size:";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "1, Small",
            "3, Medium",
            "5, Large"});
            this.comboBoxSize.Location = new System.Drawing.Point(289, 321);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(163, 24);
            this.comboBoxSize.TabIndex = 5;
            // 
            // checkBoxCarnivore
            // 
            this.checkBoxCarnivore.AutoSize = true;
            this.checkBoxCarnivore.Location = new System.Drawing.Point(292, 352);
            this.checkBoxCarnivore.Name = "checkBoxCarnivore";
            this.checkBoxCarnivore.Size = new System.Drawing.Size(91, 21);
            this.checkBoxCarnivore.TabIndex = 6;
            this.checkBoxCarnivore.Text = "Carnivore";
            this.checkBoxCarnivore.UseVisualStyleBackColor = true;
            this.checkBoxCarnivore.CheckedChanged += new System.EventHandler(this.CheckBoxCarnivore_CheckedChanged);
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Location = new System.Drawing.Point(292, 380);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(160, 23);
            this.buttonAddAnimal.TabIndex = 7;
            this.buttonAddAnimal.Text = "Add animal";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddAnimal);
            this.Controls.Add(this.checkBoxCarnivore);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.listBoxWagons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWagons;
        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.CheckBox checkBoxCarnivore;
        private System.Windows.Forms.Button buttonAddAnimal;
    }
}

