namespace WF_HW_Module_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_To_Pay = new System.Windows.Forms.GroupBox();
            this.label_Summ_Total = new System.Windows.Forms.Label();
            this.label_grn_3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_To_Pay = new System.Windows.Forms.Label();
            this.label_grn = new System.Windows.Forms.Label();
            this.label_grn_2 = new System.Windows.Forms.Label();
            this.label_litres = new System.Windows.Forms.Label();
            this.textBox_Summ_For_Petrol = new System.Windows.Forms.TextBox();
            this.textBox_Amount_Petrol = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Summ_Petrol = new System.Windows.Forms.RadioButton();
            this.radioButton_Amount = new System.Windows.Forms.RadioButton();
            this.textBox1_Price_Petrol = new System.Windows.Forms.TextBox();
            this.comboBox1_Kind_Petrol = new System.Windows.Forms.ComboBox();
            this.label2_Petrol_Price = new System.Windows.Forms.Label();
            this.label1_Kind_Petrol = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4_grn = new System.Windows.Forms.Label();
            this.label_cafe_Pay = new System.Windows.Forms.Label();
            this.textBox_Amount_Cola = new System.Windows.Forms.TextBox();
            this.textBox_Amount_Potato = new System.Windows.Forms.TextBox();
            this.textBox_Amount_Burger = new System.Windows.Forms.TextBox();
            this.textBox_Amount_HotDog = new System.Windows.Forms.TextBox();
            this.textBox_Price_Cola = new System.Windows.Forms.TextBox();
            this.textBox_Price_Potato = new System.Windows.Forms.TextBox();
            this.textBox_Price_Burger = new System.Windows.Forms.TextBox();
            this.textBox_Price_HotDog = new System.Windows.Forms.TextBox();
            this.checkBox_Cola = new System.Windows.Forms.CheckBox();
            this.checkBox_Potato = new System.Windows.Forms.CheckBox();
            this.checkBox_Burger = new System.Windows.Forms.CheckBox();
            this.checkBox_HotDog = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Button_Total_Cost = new System.Windows.Forms.Button();
            this.label_Total_Summ = new System.Windows.Forms.Label();
            this.label5_grn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox_To_Pay.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox_To_Pay);
            this.groupBox1.Controls.Add(this.label_grn);
            this.groupBox1.Controls.Add(this.label_grn_2);
            this.groupBox1.Controls.Add(this.label_litres);
            this.groupBox1.Controls.Add(this.textBox_Summ_For_Petrol);
            this.groupBox1.Controls.Add(this.textBox_Amount_Petrol);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox1_Price_Petrol);
            this.groupBox1.Controls.Add(this.comboBox1_Kind_Petrol);
            this.groupBox1.Controls.Add(this.label2_Petrol_Price);
            this.groupBox1.Controls.Add(this.label1_Kind_Petrol);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // groupBox_To_Pay
            // 
            this.groupBox_To_Pay.Controls.Add(this.label_Summ_Total);
            this.groupBox_To_Pay.Controls.Add(this.label_grn_3);
            this.groupBox_To_Pay.Controls.Add(this.label1);
            this.groupBox_To_Pay.Controls.Add(this.label_To_Pay);
            this.groupBox_To_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_To_Pay.Location = new System.Drawing.Point(10, 180);
            this.groupBox_To_Pay.Name = "groupBox_To_Pay";
            this.groupBox_To_Pay.Size = new System.Drawing.Size(220, 111);
            this.groupBox_To_Pay.TabIndex = 10;
            this.groupBox_To_Pay.TabStop = false;
            this.groupBox_To_Pay.Text = "К оплате : ";
            // 
            // label_Summ_Total
            // 
            this.label_Summ_Total.AutoSize = true;
            this.label_Summ_Total.Location = new System.Drawing.Point(93, 51);
            this.label_Summ_Total.Name = "label_Summ_Total";
            this.label_Summ_Total.Size = new System.Drawing.Size(38, 15);
            this.label_Summ_Total.TabIndex = 3;
            this.label_Summ_Total.Text = "00.00";
            // 
            // label_grn_3
            // 
            this.label_grn_3.AutoSize = true;
            this.label_grn_3.Location = new System.Drawing.Point(156, 51);
            this.label_grn_3.Name = "label_grn_3";
            this.label_grn_3.Size = new System.Drawing.Size(29, 15);
            this.label_grn_3.TabIndex = 2;
            this.label_grn_3.Text = "грн.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 1;
            // 
            // label_To_Pay
            // 
            this.label_To_Pay.AutoSize = true;
            this.label_To_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_To_Pay.Location = new System.Drawing.Point(54, 33);
            this.label_To_Pay.Name = "label_To_Pay";
            this.label_To_Pay.Size = new System.Drawing.Size(0, 39);
            this.label_To_Pay.TabIndex = 0;
            // 
            // label_grn
            // 
            this.label_grn.AutoSize = true;
            this.label_grn.Location = new System.Drawing.Point(192, 64);
            this.label_grn.Name = "label_grn";
            this.label_grn.Size = new System.Drawing.Size(27, 13);
            this.label_grn.TabIndex = 9;
            this.label_grn.Text = "грн.";
            // 
            // label_grn_2
            // 
            this.label_grn_2.AutoSize = true;
            this.label_grn_2.Location = new System.Drawing.Point(213, 153);
            this.label_grn_2.Name = "label_grn_2";
            this.label_grn_2.Size = new System.Drawing.Size(27, 13);
            this.label_grn_2.TabIndex = 8;
            this.label_grn_2.Text = "грн.";
            // 
            // label_litres
            // 
            this.label_litres.AutoSize = true;
            this.label_litres.Location = new System.Drawing.Point(214, 130);
            this.label_litres.Name = "label_litres";
            this.label_litres.Size = new System.Drawing.Size(16, 13);
            this.label_litres.TabIndex = 7;
            this.label_litres.Text = "л.";
            // 
            // textBox_Summ_For_Petrol
            // 
            this.textBox_Summ_For_Petrol.Location = new System.Drawing.Point(106, 147);
            this.textBox_Summ_For_Petrol.Name = "textBox_Summ_For_Petrol";
            this.textBox_Summ_For_Petrol.Size = new System.Drawing.Size(100, 20);
            this.textBox_Summ_For_Petrol.TabIndex = 6;
            this.textBox_Summ_For_Petrol.TextChanged += new System.EventHandler(this.textBox_Summ_For_Petrol_TextChanged);
            // 
            // textBox_Amount_Petrol
            // 
            this.textBox_Amount_Petrol.Location = new System.Drawing.Point(108, 121);
            this.textBox_Amount_Petrol.Name = "textBox_Amount_Petrol";
            this.textBox_Amount_Petrol.Size = new System.Drawing.Size(100, 20);
            this.textBox_Amount_Petrol.TabIndex = 5;
            this.textBox_Amount_Petrol.TextChanged += new System.EventHandler(this.textBox_Amount_Petrol_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Summ_Petrol);
            this.groupBox2.Controls.Add(this.radioButton_Amount);
            this.groupBox2.Location = new System.Drawing.Point(10, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButton_Summ_Petrol
            // 
            this.radioButton_Summ_Petrol.AutoSize = true;
            this.radioButton_Summ_Petrol.Location = new System.Drawing.Point(7, 45);
            this.radioButton_Summ_Petrol.Name = "radioButton_Summ_Petrol";
            this.radioButton_Summ_Petrol.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Summ_Petrol.TabIndex = 1;
            this.radioButton_Summ_Petrol.TabStop = true;
            this.radioButton_Summ_Petrol.Text = "Сумма";
            this.radioButton_Summ_Petrol.UseVisualStyleBackColor = true;
            this.radioButton_Summ_Petrol.CheckedChanged += new System.EventHandler(this.radioButton_Amount_CheckedChanged);
            // 
            // radioButton_Amount
            // 
            this.radioButton_Amount.AutoSize = true;
            this.radioButton_Amount.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Amount.Name = "radioButton_Amount";
            this.radioButton_Amount.Size = new System.Drawing.Size(84, 17);
            this.radioButton_Amount.TabIndex = 0;
            this.radioButton_Amount.TabStop = true;
            this.radioButton_Amount.Text = "Количество";
            this.radioButton_Amount.UseVisualStyleBackColor = true;
            this.radioButton_Amount.CheckedChanged += new System.EventHandler(this.radioButton_Amount_CheckedChanged);
            // 
            // textBox1_Price_Petrol
            // 
            this.textBox1_Price_Petrol.Location = new System.Drawing.Point(64, 61);
            this.textBox1_Price_Petrol.Name = "textBox1_Price_Petrol";
            this.textBox1_Price_Petrol.ReadOnly = true;
            this.textBox1_Price_Petrol.Size = new System.Drawing.Size(121, 20);
            this.textBox1_Price_Petrol.TabIndex = 3;
            // 
            // comboBox1_Kind_Petrol
            // 
            this.comboBox1_Kind_Petrol.FormattingEnabled = true;
            this.comboBox1_Kind_Petrol.Location = new System.Drawing.Point(64, 38);
            this.comboBox1_Kind_Petrol.Name = "comboBox1_Kind_Petrol";
            this.comboBox1_Kind_Petrol.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_Kind_Petrol.TabIndex = 2;
            this.comboBox1_Kind_Petrol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_Kind_Petrol_SelectedIndexChanged);
            // 
            // label2_Petrol_Price
            // 
            this.label2_Petrol_Price.AutoSize = true;
            this.label2_Petrol_Price.Location = new System.Drawing.Point(7, 64);
            this.label2_Petrol_Price.Name = "label2_Petrol_Price";
            this.label2_Petrol_Price.Size = new System.Drawing.Size(33, 13);
            this.label2_Petrol_Price.TabIndex = 1;
            this.label2_Petrol_Price.Text = "Цена";
            // 
            // label1_Kind_Petrol
            // 
            this.label1_Kind_Petrol.AutoSize = true;
            this.label1_Kind_Petrol.Location = new System.Drawing.Point(7, 38);
            this.label1_Kind_Petrol.Name = "label1_Kind_Petrol";
            this.label1_Kind_Petrol.Size = new System.Drawing.Size(50, 13);
            this.label1_Kind_Petrol.TabIndex = 0;
            this.label1_Kind_Petrol.Text = "Топливо";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.textBox_Amount_Cola);
            this.groupBox3.Controls.Add(this.textBox_Amount_Potato);
            this.groupBox3.Controls.Add(this.textBox_Amount_Burger);
            this.groupBox3.Controls.Add(this.textBox_Amount_HotDog);
            this.groupBox3.Controls.Add(this.textBox_Price_Cola);
            this.groupBox3.Controls.Add(this.textBox_Price_Potato);
            this.groupBox3.Controls.Add(this.textBox_Price_Burger);
            this.groupBox3.Controls.Add(this.textBox_Price_HotDog);
            this.groupBox3.Controls.Add(this.checkBox_Cola);
            this.groupBox3.Controls.Add(this.checkBox_Potato);
            this.groupBox3.Controls.Add(this.checkBox_Burger);
            this.groupBox3.Controls.Add(this.checkBox_HotDog);
            this.groupBox3.Location = new System.Drawing.Point(401, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 297);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Меню Кафе";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4_grn);
            this.groupBox4.Controls.Add(this.label_cafe_Pay);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(16, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 111);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "К оплате :";
            // 
            // label4_grn
            // 
            this.label4_grn.AutoSize = true;
            this.label4_grn.Location = new System.Drawing.Point(232, 56);
            this.label4_grn.Name = "label4_grn";
            this.label4_grn.Size = new System.Drawing.Size(29, 15);
            this.label4_grn.TabIndex = 1;
            this.label4_grn.Text = "грн.";
            // 
            // label_cafe_Pay
            // 
            this.label_cafe_Pay.AutoSize = true;
            this.label_cafe_Pay.Location = new System.Drawing.Point(188, 56);
            this.label_cafe_Pay.Name = "label_cafe_Pay";
            this.label_cafe_Pay.Size = new System.Drawing.Size(38, 15);
            this.label_cafe_Pay.TabIndex = 0;
            this.label_cafe_Pay.Text = "00.00";
            // 
            // textBox_Amount_Cola
            // 
            this.textBox_Amount_Cola.Location = new System.Drawing.Point(262, 109);
            this.textBox_Amount_Cola.Name = "textBox_Amount_Cola";
            this.textBox_Amount_Cola.Size = new System.Drawing.Size(100, 20);
            this.textBox_Amount_Cola.TabIndex = 11;
            this.textBox_Amount_Cola.Text = "0";
            this.textBox_Amount_Cola.TextChanged += new System.EventHandler(this.textBox_cafe_TextChanged);
            // 
            // textBox_Amount_Potato
            // 
            this.textBox_Amount_Potato.Location = new System.Drawing.Point(262, 83);
            this.textBox_Amount_Potato.Name = "textBox_Amount_Potato";
            this.textBox_Amount_Potato.Size = new System.Drawing.Size(100, 20);
            this.textBox_Amount_Potato.TabIndex = 10;
            this.textBox_Amount_Potato.Text = "0";
            this.textBox_Amount_Potato.TextChanged += new System.EventHandler(this.textBox_cafe_TextChanged);
            // 
            // textBox_Amount_Burger
            // 
            this.textBox_Amount_Burger.Location = new System.Drawing.Point(262, 56);
            this.textBox_Amount_Burger.Name = "textBox_Amount_Burger";
            this.textBox_Amount_Burger.Size = new System.Drawing.Size(100, 20);
            this.textBox_Amount_Burger.TabIndex = 9;
            this.textBox_Amount_Burger.Text = "0";
            this.textBox_Amount_Burger.TextChanged += new System.EventHandler(this.textBox_cafe_TextChanged);
            // 
            // textBox_Amount_HotDog
            // 
            this.textBox_Amount_HotDog.Location = new System.Drawing.Point(262, 30);
            this.textBox_Amount_HotDog.Name = "textBox_Amount_HotDog";
            this.textBox_Amount_HotDog.Size = new System.Drawing.Size(100, 20);
            this.textBox_Amount_HotDog.TabIndex = 8;
            this.textBox_Amount_HotDog.Text = "0";
            this.textBox_Amount_HotDog.TextChanged += new System.EventHandler(this.textBox_cafe_TextChanged);
            // 
            // textBox_Price_Cola
            // 
            this.textBox_Price_Cola.Location = new System.Drawing.Point(155, 110);
            this.textBox_Price_Cola.Name = "textBox_Price_Cola";
            this.textBox_Price_Cola.ReadOnly = true;
            this.textBox_Price_Cola.Size = new System.Drawing.Size(100, 20);
            this.textBox_Price_Cola.TabIndex = 7;
            // 
            // textBox_Price_Potato
            // 
            this.textBox_Price_Potato.Location = new System.Drawing.Point(155, 83);
            this.textBox_Price_Potato.Name = "textBox_Price_Potato";
            this.textBox_Price_Potato.ReadOnly = true;
            this.textBox_Price_Potato.Size = new System.Drawing.Size(100, 20);
            this.textBox_Price_Potato.TabIndex = 6;
            // 
            // textBox_Price_Burger
            // 
            this.textBox_Price_Burger.Location = new System.Drawing.Point(155, 57);
            this.textBox_Price_Burger.Name = "textBox_Price_Burger";
            this.textBox_Price_Burger.ReadOnly = true;
            this.textBox_Price_Burger.Size = new System.Drawing.Size(100, 20);
            this.textBox_Price_Burger.TabIndex = 5;
            // 
            // textBox_Price_HotDog
            // 
            this.textBox_Price_HotDog.Location = new System.Drawing.Point(155, 31);
            this.textBox_Price_HotDog.Name = "textBox_Price_HotDog";
            this.textBox_Price_HotDog.ReadOnly = true;
            this.textBox_Price_HotDog.Size = new System.Drawing.Size(100, 20);
            this.textBox_Price_HotDog.TabIndex = 4;
            // 
            // checkBox_Cola
            // 
            this.checkBox_Cola.AutoSize = true;
            this.checkBox_Cola.Location = new System.Drawing.Point(16, 112);
            this.checkBox_Cola.Name = "checkBox_Cola";
            this.checkBox_Cola.Size = new System.Drawing.Size(51, 17);
            this.checkBox_Cola.TabIndex = 3;
            this.checkBox_Cola.Text = "Кола";
            this.checkBox_Cola.UseVisualStyleBackColor = true;
            this.checkBox_Cola.CheckedChanged += new System.EventHandler(this.checkBox_Cola_CheckedChanged);
            // 
            // checkBox_Potato
            // 
            this.checkBox_Potato.AutoSize = true;
            this.checkBox_Potato.Location = new System.Drawing.Point(16, 88);
            this.checkBox_Potato.Name = "checkBox_Potato";
            this.checkBox_Potato.Size = new System.Drawing.Size(102, 17);
            this.checkBox_Potato.TabIndex = 2;
            this.checkBox_Potato.Text = "Картошка-Фри";
            this.checkBox_Potato.UseVisualStyleBackColor = true;
            this.checkBox_Potato.CheckedChanged += new System.EventHandler(this.checkBox_Potato_CheckedChanged);
            // 
            // checkBox_Burger
            // 
            this.checkBox_Burger.AutoSize = true;
            this.checkBox_Burger.Location = new System.Drawing.Point(16, 64);
            this.checkBox_Burger.Name = "checkBox_Burger";
            this.checkBox_Burger.Size = new System.Drawing.Size(61, 17);
            this.checkBox_Burger.TabIndex = 1;
            this.checkBox_Burger.Text = "Бургер";
            this.checkBox_Burger.UseVisualStyleBackColor = true;
            this.checkBox_Burger.CheckedChanged += new System.EventHandler(this.checkBox_Burger_CheckedChanged);
            // 
            // checkBox_HotDog
            // 
            this.checkBox_HotDog.AutoSize = true;
            this.checkBox_HotDog.Location = new System.Drawing.Point(16, 38);
            this.checkBox_HotDog.Name = "checkBox_HotDog";
            this.checkBox_HotDog.Size = new System.Drawing.Size(67, 17);
            this.checkBox_HotDog.TabIndex = 0;
            this.checkBox_HotDog.Text = "Хот-Дог";
            this.checkBox_HotDog.UseVisualStyleBackColor = true;
            this.checkBox_HotDog.CheckedChanged += new System.EventHandler(this.checkBox_HotDog_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5_grn);
            this.groupBox5.Controls.Add(this.label_Total_Summ);
            this.groupBox5.Controls.Add(this.Button_Total_Cost);
            this.groupBox5.Location = new System.Drawing.Point(25, 338);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(744, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Всего  к оплате";
            // 
            // Button_Total_Cost
            // 
            this.Button_Total_Cost.Location = new System.Drawing.Point(130, 9);
            this.Button_Total_Cost.Name = "Button_Total_Cost";
            this.Button_Total_Cost.Size = new System.Drawing.Size(250, 74);
            this.Button_Total_Cost.TabIndex = 0;
            this.Button_Total_Cost.Text = "Посчитать";
            this.Button_Total_Cost.UseVisualStyleBackColor = true;
            this.Button_Total_Cost.Click += new System.EventHandler(this.Button_Total_Cost_Click);
            // 
            // label_Total_Summ
            // 
            this.label_Total_Summ.AutoSize = true;
            this.label_Total_Summ.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Total_Summ.Location = new System.Drawing.Point(472, 24);
            this.label_Total_Summ.Name = "label_Total_Summ";
            this.label_Total_Summ.Size = new System.Drawing.Size(91, 36);
            this.label_Total_Summ.TabIndex = 1;
            this.label_Total_Summ.Text = "00.00";
            // 
            // label5_grn
            // 
            this.label5_grn.AutoSize = true;
            this.label5_grn.Location = new System.Drawing.Point(617, 46);
            this.label5_grn.Name = "label5_grn";
            this.label5_grn.Size = new System.Drawing.Size(27, 13);
            this.label5_grn.TabIndex = 2;
            this.label5_grn.Text = "грн.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_To_Pay.ResumeLayout(false);
            this.groupBox_To_Pay.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_To_Pay;
        private System.Windows.Forms.Label label_grn_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_To_Pay;
        private System.Windows.Forms.Label label_grn;
        private System.Windows.Forms.Label label_grn_2;
        private System.Windows.Forms.Label label_litres;
        private System.Windows.Forms.TextBox textBox_Summ_For_Petrol;
        private System.Windows.Forms.TextBox textBox_Amount_Petrol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Summ_Petrol;
        private System.Windows.Forms.RadioButton radioButton_Amount;
        private System.Windows.Forms.TextBox textBox1_Price_Petrol;
        private System.Windows.Forms.ComboBox comboBox1_Kind_Petrol;
        private System.Windows.Forms.Label label2_Petrol_Price;
        private System.Windows.Forms.Label label1_Kind_Petrol;
        private System.Windows.Forms.Label label_Summ_Total;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_Amount_Cola;
        private System.Windows.Forms.TextBox textBox_Amount_Potato;
        private System.Windows.Forms.TextBox textBox_Amount_Burger;
        private System.Windows.Forms.TextBox textBox_Amount_HotDog;
        private System.Windows.Forms.TextBox textBox_Price_Cola;
        private System.Windows.Forms.TextBox textBox_Price_Potato;
        private System.Windows.Forms.TextBox textBox_Price_Burger;
        private System.Windows.Forms.TextBox textBox_Price_HotDog;
        private System.Windows.Forms.CheckBox checkBox_Cola;
        private System.Windows.Forms.CheckBox checkBox_Potato;
        private System.Windows.Forms.CheckBox checkBox_Burger;
        private System.Windows.Forms.CheckBox checkBox_HotDog;
        private System.Windows.Forms.Label label4_grn;
        private System.Windows.Forms.Label label_cafe_Pay;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5_grn;
        private System.Windows.Forms.Label label_Total_Summ;
        private System.Windows.Forms.Button Button_Total_Cost;
    }
}

