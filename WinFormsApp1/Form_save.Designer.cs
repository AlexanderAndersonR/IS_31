namespace WinFormsApp1
{
    partial class Form_save
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
            textBox1 = new TextBox();
            button_save = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label_name = new Label();
            button_add = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(710, 121);
            textBox1.TabIndex = 0;
            // 
            // button_save
            // 
            button_save.Location = new Point(647, 151);
            button_save.Name = "button_save";
            button_save.Size = new Size(75, 23);
            button_save.TabIndex = 1;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(397, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(57, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(12, 155);
            label_name.Name = "label_name";
            label_name.Size = new Size(39, 15);
            label_name.TabIndex = 4;
            label_name.Text = "Name";
            // 
            // button_add
            // 
            button_add.Location = new Point(566, 151);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 23);
            button_add.TabIndex = 5;
            button_add.Text = "Adress";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // Form_save
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 186);
            Controls.Add(button_add);
            Controls.Add(label_name);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button_save);
            Controls.Add(textBox1);
            Name = "Form_save";
            Text = "Form_save";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button_save;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label_name;
        private Button button_add;
    }
}