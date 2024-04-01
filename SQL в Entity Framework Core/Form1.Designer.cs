namespace SQL_в_Entity_Framework_Core
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            groupBox3 = new GroupBox();
            button13 = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(744, 12);
            button1.Name = "button1";
            button1.Size = new Size(290, 29);
            button1.TabIndex = 1;
            button1.Text = "Все объекты из таблицы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ShowAll;
            // 
            // button2
            // 
            button2.Location = new Point(744, 47);
            button2.Name = "button2";
            button2.Size = new Size(290, 29);
            button2.TabIndex = 2;
            button2.Text = "Показать имена продуктов";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AllByName;
            // 
            // button3
            // 
            button3.Location = new Point(744, 82);
            button3.Name = "button3";
            button3.Size = new Size(290, 29);
            button3.TabIndex = 3;
            button3.Text = "Показать все цвета";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AllByColor;
            // 
            // button4
            // 
            button4.Location = new Point(744, 117);
            button4.Name = "button4";
            button4.Size = new Size(290, 29);
            button4.TabIndex = 4;
            button4.Text = "Показать макс калорий";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ByMaxCal;
            // 
            // button5
            // 
            button5.Location = new Point(744, 152);
            button5.Name = "button5";
            button5.Size = new Size(290, 29);
            button5.TabIndex = 5;
            button5.Text = "Показать мин калорий";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ByMinCal;
            // 
            // button6
            // 
            button6.Location = new Point(744, 187);
            button6.Name = "button6";
            button6.Size = new Size(290, 29);
            button6.TabIndex = 6;
            button6.Text = "Показать сред калорий";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ByAvgCal;
            // 
            // button7
            // 
            button7.Location = new Point(6, 59);
            button7.Name = "button7";
            button7.Size = new Size(278, 29);
            button7.TabIndex = 7;
            button7.Text = "Показать";
            button7.UseVisualStyleBackColor = true;
            button7.Click += ByColor;
            // 
            // button8
            // 
            button8.Location = new Point(744, 329);
            button8.Name = "button8";
            button8.Size = new Size(290, 29);
            button8.TabIndex = 8;
            button8.Text = "Показать кол-во каждого цвета";
            button8.UseVisualStyleBackColor = true;
            button8.Click += ByColorСount;
            // 
            // button9
            // 
            button9.Location = new Point(6, 26);
            button9.Name = "button9";
            button9.Size = new Size(47, 29);
            button9.TabIndex = 9;
            button9.Text = "Min:";
            button9.UseVisualStyleBackColor = true;
            button9.Click += ByCaloriesMin;
            // 
            // button10
            // 
            button10.Location = new Point(140, 26);
            button10.Name = "button10";
            button10.Size = new Size(45, 29);
            button10.TabIndex = 10;
            button10.Text = "Max:";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ByCaloriesMax;
            // 
            // button11
            // 
            button11.Location = new Point(6, 61);
            button11.Name = "button11";
            button11.Size = new Size(270, 29);
            button11.TabIndex = 11;
            button11.Text = "Диапазон min и max";
            button11.UseVisualStyleBackColor = true;
            button11.Click += ByCaloriesMinMax;
            // 
            // button12
            // 
            button12.Location = new Point(1040, 82);
            button12.Name = "button12";
            button12.Size = new Size(290, 29);
            button12.TabIndex = 12;
            button12.Text = "Показать все желтые и красные";
            button12.UseVisualStyleBackColor = true;
            button12.Click += ByYellowRedColor;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button7);
            groupBox1.Location = new Point(744, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 101);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Продукты заданого цвета";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 27);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button11);
            groupBox2.Controls.Add(button10);
            groupBox2.Location = new Point(752, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 104);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск по калориям";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(85, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(59, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 27);
            textBox2.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(724, 444);
            listBox1.TabIndex = 15;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button13);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(1040, 117);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(290, 219);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Добавить";
            // 
            // button13
            // 
            button13.Location = new Point(6, 175);
            button13.Name = "button13";
            button13.Size = new Size(278, 29);
            button13.TabIndex = 17;
            button13.Text = "Добавить";
            button13.UseVisualStyleBackColor = true;
            button13.Click += InsertProduct;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(89, 142);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(195, 27);
            textBox7.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(89, 107);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(195, 27);
            textBox6.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(89, 72);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(195, 27);
            textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(89, 37);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 27);
            textBox4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 149);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Калорий";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 114);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Цвет";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Тип";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // button15
            // 
            button15.Location = new Point(1040, 12);
            button15.Name = "button15";
            button15.Size = new Size(290, 29);
            button15.TabIndex = 17;
            button15.Text = "Показать все фрукты";
            button15.UseVisualStyleBackColor = true;
            button15.Click += OnlyFruits;
            // 
            // button16
            // 
            button16.Location = new Point(1040, 47);
            button16.Name = "button16";
            button16.Size = new Size(290, 29);
            button16.TabIndex = 18;
            button16.Text = "Показать все овощи";
            button16.UseVisualStyleBackColor = true;
            button16.Click += OnlyVegetables;
            // 
            // button17
            // 
            button17.Enabled = false;
            button17.Location = new Point(1040, 342);
            button17.Name = "button17";
            button17.Size = new Size(290, 29);
            button17.TabIndex = 19;
            button17.Text = "Удалить";
            button17.UseVisualStyleBackColor = true;
            button17.Click += DeleteProduct;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 484);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(groupBox3);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button12);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "SQL в Entity Framework Core";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private ListBox listBox1;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button button13;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button15;
        private Button button16;
        private Button button17;
    }
}
