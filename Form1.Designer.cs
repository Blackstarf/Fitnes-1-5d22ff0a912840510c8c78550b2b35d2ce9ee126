﻿namespace Fitnes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label5 = new Label();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            panel5 = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            panelregclient = new Panel();
            dateTimePicker1 = new DateTimePicker();
            podsk78Text = new Label();
            ddmmyyText = new Label();
            label10 = new Label();
            phoneRedStar = new Label();
            OtchestvoBox = new TextBox();
            nameText = new Label();
            otchestvoRedStar = new Label();
            otchestvoText = new Label();
            nameRedStar = new Label();
            dataRozhdText = new Label();
            famRedStar = new Label();
            phoneText = new Label();
            button1 = new Button();
            famText = new Label();
            phoneNumBox = new TextBox();
            familiyaBox = new TextBox();
            nameBox = new TextBox();
            paneldeleteclient = new Panel();
            label17 = new Label();
            label18 = new Label();
            button5 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label7 = new Label();
            panelshowclient = new Panel();
            DataView = new DataGridView();
            label8 = new Label();
            panelchangeclient = new Panel();
            label20 = new Label();
            label14 = new Label();
            label13 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            buttonBirthDate = new Button();
            buttonPhoneNumber = new Button();
            buttonPatronymic = new Button();
            buttonName = new Button();
            buttonFirstName = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            label11 = new Label();
            pictureBox7 = new PictureBox();
            panel9 = new Panel();
            button6 = new Button();
            label12 = new Label();
            panel8 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panel7 = new Panel();
            abonementpanel = new Panel();
            label16 = new Label();
            label19 = new Label();
            button4 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label15 = new Label();
            pictureBox8 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Фамилия = new DataGridViewTextBoxColumn();
            Otchestvo = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Abonement = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            panelregclient.SuspendLayout();
            paneldeleteclient.SuspendLayout();
            panelshowclient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataView).BeginInit();
            panelchangeclient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel7.SuspendLayout();
            abonementpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.Hand;
            label5.Dock = DockStyle.Right;
            label5.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 246, 224);
            label5.Location = new Point(4, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(164, 40);
            label5.TabIndex = 7;
            label5.Text = "Редактировать\r\nпрофиль клиента\r\n";
            label5.Click += PanelChangeClient;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Cursor = Cursors.Hand;
            label6.Dock = DockStyle.Right;
            label6.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(255, 246, 224);
            label6.Location = new Point(87, 0);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(81, 40);
            label6.TabIndex = 9;
            label6.Text = "Удалить\r\nКлиента";
            label6.Click += PanelDeleteclient;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Dock = DockStyle.Right;
            pictureBox6.Location = new Point(168, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            pictureBox6.Click += PanelDeleteclient;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(39, 43, 49);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(209, 44);
            panel5.TabIndex = 11;
            panel5.Click += PanelShowClient;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Dock = DockStyle.Right;
            label4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 246, 224);
            label4.Location = new Point(77, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(91, 40);
            label4.TabIndex = 5;
            label4.Text = "Показать\r\nклиентов\r\n";
            label4.Click += PanelShowClient;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Dock = DockStyle.Right;
            pictureBox4.Location = new Point(168, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += PanelShowClient;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(39, 40, 41);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(3, 156);
            panel6.Name = "panel6";
            panel6.Size = new Size(209, 44);
            panel6.TabIndex = 12;
            panel6.Click += PanelDeleteclient;
            // 
            // panelregclient
            // 
            panelregclient.BackColor = Color.DarkGray;
            panelregclient.Controls.Add(dateTimePicker1);
            panelregclient.Controls.Add(podsk78Text);
            panelregclient.Controls.Add(ddmmyyText);
            panelregclient.Controls.Add(label10);
            panelregclient.Controls.Add(phoneRedStar);
            panelregclient.Controls.Add(OtchestvoBox);
            panelregclient.Controls.Add(nameText);
            panelregclient.Controls.Add(otchestvoRedStar);
            panelregclient.Controls.Add(otchestvoText);
            panelregclient.Controls.Add(nameRedStar);
            panelregclient.Controls.Add(dataRozhdText);
            panelregclient.Controls.Add(famRedStar);
            panelregclient.Controls.Add(phoneText);
            panelregclient.Controls.Add(button1);
            panelregclient.Controls.Add(famText);
            panelregclient.Controls.Add(phoneNumBox);
            panelregclient.Controls.Add(familiyaBox);
            panelregclient.Controls.Add(nameBox);
            panelregclient.Location = new Point(218, 3);
            panelregclient.Name = "panelregclient";
            panelregclient.Size = new Size(498, 438);
            panelregclient.TabIndex = 1;
            panelregclient.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(139, 174);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 38;
            // 
            // podsk78Text
            // 
            podsk78Text.AutoSize = true;
            podsk78Text.Location = new Point(51, 250);
            podsk78Text.Name = "podsk78Text";
            podsk78Text.Size = new Size(32, 15);
            podsk78Text.TabIndex = 37;
            podsk78Text.Text = "+7/8";
            // 
            // ddmmyyText
            // 
            ddmmyyText.AutoSize = true;
            ddmmyyText.Location = new Point(15, 196);
            ddmmyyText.Name = "ddmmyyText";
            ddmmyyText.Size = new Size(98, 15);
            ddmmyyText.TabIndex = 36;
            ddmmyyText.Text = "(день.месяц.год)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(156, 15);
            label10.TabIndex = 0;
            label10.Text = "Окно регистрации клиента";
            // 
            // phoneRedStar
            // 
            phoneRedStar.AutoSize = true;
            phoneRedStar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            phoneRedStar.ForeColor = Color.Red;
            phoneRedStar.Location = new Point(105, 211);
            phoneRedStar.Name = "phoneRedStar";
            phoneRedStar.Size = new Size(28, 37);
            phoneRedStar.TabIndex = 35;
            phoneRedStar.Text = "*";
            // 
            // OtchestvoBox
            // 
            OtchestvoBox.Location = new Point(139, 128);
            OtchestvoBox.Name = "OtchestvoBox";
            OtchestvoBox.Size = new Size(100, 23);
            OtchestvoBox.TabIndex = 27;
            OtchestvoBox.TextChanged += OtchestvoBox_TextChanged;
            OtchestvoBox.KeyPress += text_KeyPress;
            // 
            // nameText
            // 
            nameText.AutoSize = true;
            nameText.Location = new Point(15, 83);
            nameText.Name = "nameText";
            nameText.Size = new Size(31, 15);
            nameText.TabIndex = 20;
            nameText.Text = "Имя";
            // 
            // otchestvoRedStar
            // 
            otchestvoRedStar.AutoSize = true;
            otchestvoRedStar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            otchestvoRedStar.ForeColor = Color.Red;
            otchestvoRedStar.Location = new Point(105, 114);
            otchestvoRedStar.Name = "otchestvoRedStar";
            otchestvoRedStar.Size = new Size(28, 37);
            otchestvoRedStar.TabIndex = 33;
            otchestvoRedStar.Text = "*";
            // 
            // otchestvoText
            // 
            otchestvoText.AutoSize = true;
            otchestvoText.Location = new Point(15, 128);
            otchestvoText.Name = "otchestvoText";
            otchestvoText.Size = new Size(58, 15);
            otchestvoText.TabIndex = 21;
            otchestvoText.Text = "Отчество";
            // 
            // nameRedStar
            // 
            nameRedStar.AutoSize = true;
            nameRedStar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nameRedStar.ForeColor = Color.Red;
            nameRedStar.Location = new Point(105, 69);
            nameRedStar.Name = "nameRedStar";
            nameRedStar.Size = new Size(28, 37);
            nameRedStar.TabIndex = 32;
            nameRedStar.Text = "*";
            // 
            // dataRozhdText
            // 
            dataRozhdText.AutoSize = true;
            dataRozhdText.Location = new Point(15, 171);
            dataRozhdText.Name = "dataRozhdText";
            dataRozhdText.Size = new Size(93, 15);
            dataRozhdText.TabIndex = 22;
            dataRozhdText.Text = "Дата рождения ";
            // 
            // famRedStar
            // 
            famRedStar.AutoSize = true;
            famRedStar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            famRedStar.ForeColor = Color.Red;
            famRedStar.Location = new Point(105, 26);
            famRedStar.Name = "famRedStar";
            famRedStar.Size = new Size(28, 37);
            famRedStar.TabIndex = 31;
            famRedStar.Text = "*";
            // 
            // phoneText
            // 
            phoneText.AutoSize = true;
            phoneText.Location = new Point(15, 226);
            phoneText.Name = "phoneText";
            phoneText.Size = new Size(101, 15);
            phoneText.TabIndex = 23;
            phoneText.Text = "Номер телефона";
            // 
            // button1
            // 
            button1.Location = new Point(166, 268);
            button1.Name = "button1";
            button1.Size = new Size(44, 23);
            button1.TabIndex = 30;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // famText
            // 
            famText.AutoSize = true;
            famText.Location = new Point(15, 40);
            famText.Name = "famText";
            famText.Size = new Size(58, 15);
            famText.TabIndex = 24;
            famText.Text = "Фамилия";
            // 
            // phoneNumBox
            // 
            phoneNumBox.Location = new Point(139, 226);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(100, 23);
            phoneNumBox.TabIndex = 29;
            phoneNumBox.TextChanged += phoneNumBox_TextChanged_1;
            phoneNumBox.KeyPress += textBox_KeyPress;
            // 
            // familiyaBox
            // 
            familiyaBox.Location = new Point(139, 40);
            familiyaBox.Name = "familiyaBox";
            familiyaBox.Size = new Size(100, 23);
            familiyaBox.TabIndex = 25;
            familiyaBox.TextChanged += familiyaBox_TextChanged_1;
            familiyaBox.KeyPress += text_KeyPress;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(139, 83);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 23);
            nameBox.TabIndex = 26;
            nameBox.TextChanged += nameBox_TextChanged_1;
            nameBox.KeyPress += text_KeyPress;
            // 
            // paneldeleteclient
            // 
            paneldeleteclient.BackColor = Color.DarkGray;
            paneldeleteclient.Controls.Add(label17);
            paneldeleteclient.Controls.Add(label18);
            paneldeleteclient.Controls.Add(button5);
            paneldeleteclient.Controls.Add(textBox6);
            paneldeleteclient.Controls.Add(textBox7);
            paneldeleteclient.Controls.Add(label7);
            paneldeleteclient.Location = new Point(218, 3);
            paneldeleteclient.Name = "paneldeleteclient";
            paneldeleteclient.Size = new Size(498, 438);
            paneldeleteclient.TabIndex = 1;
            paneldeleteclient.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(160, 164);
            label17.Name = "label17";
            label17.Size = new Size(75, 15);
            label17.TabIndex = 27;
            label17.Text = "Введите имя";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(160, 90);
            label18.Name = "label18";
            label18.Size = new Size(108, 15);
            label18.TabIndex = 26;
            label18.Text = "Введите фамилию";
            // 
            // button5
            // 
            button5.Location = new Point(147, 234);
            button5.Name = "button5";
            button5.Size = new Size(130, 39);
            button5.TabIndex = 25;
            button5.Text = "Найдем и удалим";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(160, 186);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 24;
            textBox6.KeyPress += text_KeyPress;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(160, 117);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 23;
            textBox7.KeyPress += text_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 5);
            label7.Name = "label7";
            label7.Size = new Size(206, 15);
            label7.TabIndex = 0;
            label7.Text = "Окно где удаляют профили клиента";
            // 
            // panelshowclient
            // 
            panelshowclient.BackColor = Color.DarkGray;
            panelshowclient.Controls.Add(DataView);
            panelshowclient.Controls.Add(label8);
            panelshowclient.Location = new Point(218, 3);
            panelshowclient.Name = "panelshowclient";
            panelshowclient.Size = new Size(498, 438);
            panelshowclient.TabIndex = 0;
            panelshowclient.Visible = false;
            // 
            // DataView
            // 
            DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataView.Location = new Point(12, 23);
            DataView.Name = "DataView";
            DataView.RowTemplate.Height = 25;
            DataView.Size = new Size(474, 412);
            DataView.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(173, 15);
            label8.TabIndex = 0;
            label8.Text = "Окно где видно всех клиентов";
            // 
            // panelchangeclient
            // 
            panelchangeclient.BackColor = Color.DarkGray;
            panelchangeclient.Controls.Add(label20);
            panelchangeclient.Controls.Add(label14);
            panelchangeclient.Controls.Add(label13);
            panelchangeclient.Controls.Add(button2);
            panelchangeclient.Controls.Add(textBox3);
            panelchangeclient.Controls.Add(buttonBirthDate);
            panelchangeclient.Controls.Add(buttonPhoneNumber);
            panelchangeclient.Controls.Add(buttonPatronymic);
            panelchangeclient.Controls.Add(buttonName);
            panelchangeclient.Controls.Add(buttonFirstName);
            panelchangeclient.Controls.Add(button3);
            panelchangeclient.Controls.Add(textBox2);
            panelchangeclient.Controls.Add(textBox1);
            panelchangeclient.Controls.Add(label9);
            panelchangeclient.Location = new Point(218, 3);
            panelchangeclient.Name = "panelchangeclient";
            panelchangeclient.Size = new Size(498, 438);
            panelchangeclient.TabIndex = 1;
            panelchangeclient.Visible = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(22, 262);
            label20.Name = "label20";
            label20.Size = new Size(205, 15);
            label20.TabIndex = 24;
            label20.Text = "Запишите её в виде месяц/день/год";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(152, 153);
            label14.Name = "label14";
            label14.Size = new Size(75, 15);
            label14.TabIndex = 22;
            label14.Text = "Введите имя";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(152, 79);
            label13.Name = "label13";
            label13.Size = new Size(108, 15);
            label13.TabIndex = 21;
            label13.Text = "Введите фамилию";
            // 
            // button2
            // 
            button2.Location = new Point(216, 274);
            button2.Name = "button2";
            button2.Size = new Size(84, 27);
            button2.TabIndex = 20;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(58, 278);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 23);
            textBox3.TabIndex = 19;
            // 
            // buttonBirthDate
            // 
            buttonBirthDate.Location = new Point(58, 237);
            buttonBirthDate.Name = "buttonBirthDate";
            buttonBirthDate.Size = new Size(75, 23);
            buttonBirthDate.TabIndex = 18;
            buttonBirthDate.Text = "Дата";
            buttonBirthDate.UseVisualStyleBackColor = true;
            buttonBirthDate.Click += buttonDateBirt_Click;
            // 
            // buttonPhoneNumber
            // 
            buttonPhoneNumber.Location = new Point(58, 195);
            buttonPhoneNumber.Name = "buttonPhoneNumber";
            buttonPhoneNumber.Size = new Size(75, 23);
            buttonPhoneNumber.TabIndex = 17;
            buttonPhoneNumber.Text = "Номер";
            buttonPhoneNumber.UseVisualStyleBackColor = true;
            buttonPhoneNumber.Click += buttonNumber_Click;
            // 
            // buttonPatronymic
            // 
            buttonPatronymic.Location = new Point(58, 156);
            buttonPatronymic.Name = "buttonPatronymic";
            buttonPatronymic.Size = new Size(75, 23);
            buttonPatronymic.TabIndex = 16;
            buttonPatronymic.Text = "Отчество";
            buttonPatronymic.UseVisualStyleBackColor = true;
            buttonPatronymic.Click += buttonOtName_Click;
            // 
            // buttonName
            // 
            buttonName.Location = new Point(58, 118);
            buttonName.Name = "buttonName";
            buttonName.Size = new Size(75, 23);
            buttonName.TabIndex = 15;
            buttonName.Text = "Имя";
            buttonName.UseVisualStyleBackColor = true;
            buttonName.Click += buttonName_Click;
            // 
            // buttonFirstName
            // 
            buttonFirstName.Location = new Point(58, 79);
            buttonFirstName.Name = "buttonFirstName";
            buttonFirstName.Size = new Size(75, 23);
            buttonFirstName.TabIndex = 14;
            buttonFirstName.Text = "Фамилию";
            buttonFirstName.UseVisualStyleBackColor = true;
            buttonFirstName.Click += buttonFirstName_Click;
            // 
            // button3
            // 
            button3.Location = new Point(139, 223);
            button3.Name = "button3";
            button3.Size = new Size(130, 39);
            button3.TabIndex = 13;
            button3.Text = "Поиск чтобы изменить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 12;
            textBox2.KeyPress += text_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            textBox1.KeyPress += text_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 5);
            label9.Name = "label9";
            label9.Size = new Size(253, 15);
            label9.TabIndex = 0;
            label9.Text = "Окно где можно изменить профиль клиента";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Dock = DockStyle.Right;
            pictureBox5.Location = new Point(168, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 47);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            pictureBox5.Click += PanelChangeClient;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(39, 40, 41);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(abonementpanel);
            panel3.Controls.Add(panelshowclient);
            panel3.Controls.Add(panelchangeclient);
            panel3.Controls.Add(panelregclient);
            panel3.Controls.Add(paneldeleteclient);
            panel3.Location = new Point(12, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(719, 444);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(39, 40, 41);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(pictureBox7);
            panel4.Location = new Point(3, 206);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 44);
            panel4.TabIndex = 13;
            panel4.Click += PanelShowAbonement;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Cursor = Cursors.Hand;
            label11.Dock = DockStyle.Right;
            label11.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(255, 246, 224);
            label11.Location = new Point(41, 0);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(127, 40);
            label11.TabIndex = 9;
            label11.Text = "Проверка\r\nабонементов";
            label11.Click += PanelShowAbonement;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Dock = DockStyle.Right;
            pictureBox7.Location = new Point(168, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(41, 44);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            pictureBox7.Click += PanelShowAbonement;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(39, 43, 49);
            panel9.Controls.Add(button6);
            panel9.Controls.Add(label12);
            panel9.Location = new Point(3, 256);
            panel9.Name = "panel9";
            panel9.Size = new Size(209, 185);
            panel9.TabIndex = 15;
            // 
            // button6
            // 
            button6.Location = new Point(47, 85);
            button6.Name = "button6";
            button6.Size = new Size(104, 58);
            button6.TabIndex = 14;
            button6.Text = "Генирация 200 пользователей";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Top;
            label12.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(255, 246, 224);
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(169, 20);
            label12.TabIndex = 13;
            label12.Text = "      Дата и время:";
            // 
            // panel8
            // 
            panel8.Controls.Add(label3);
            panel8.Controls.Add(pictureBox3);
            panel8.Location = new Point(3, 53);
            panel8.Name = "panel8";
            panel8.Size = new Size(209, 44);
            panel8.TabIndex = 14;
            panel8.Click += PanelRegClient;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 246, 224);
            label3.Location = new Point(47, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(121, 40);
            label3.TabIndex = 3;
            label3.Text = "Регистрация\r\nклиента";
            label3.Click += PanelRegClient;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Dock = DockStyle.Right;
            pictureBox3.Location = new Point(168, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += PanelRegClient;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(39, 43, 49);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(pictureBox5);
            panel7.Location = new Point(3, 103);
            panel7.Name = "panel7";
            panel7.Size = new Size(209, 47);
            panel7.TabIndex = 13;
            panel7.Click += PanelChangeClient;
            // 
            // abonementpanel
            // 
            abonementpanel.BackColor = Color.DarkGray;
            abonementpanel.Controls.Add(label16);
            abonementpanel.Controls.Add(label19);
            abonementpanel.Controls.Add(button4);
            abonementpanel.Controls.Add(textBox4);
            abonementpanel.Controls.Add(textBox5);
            abonementpanel.Controls.Add(label15);
            abonementpanel.Location = new Point(218, 3);
            abonementpanel.Name = "abonementpanel";
            abonementpanel.Size = new Size(498, 438);
            abonementpanel.TabIndex = 1;
            abonementpanel.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(180, 173);
            label16.Name = "label16";
            label16.Size = new Size(75, 15);
            label16.TabIndex = 32;
            label16.Text = "Введите имя";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(180, 99);
            label19.Name = "label19";
            label19.Size = new Size(108, 15);
            label19.TabIndex = 31;
            label19.Text = "Введите фамилию";
            // 
            // button4
            // 
            button4.Location = new Point(167, 243);
            button4.Name = "button4";
            button4.Size = new Size(130, 39);
            button4.TabIndex = 30;
            button4.Text = "Сколько осталось времени";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(180, 195);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 29;
            textBox4.KeyPress += text_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(180, 126);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 28;
            textBox5.KeyPress += text_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(69, 15);
            label15.TabIndex = 0;
            label15.Text = "Абонемент";
            // 
            // pictureBox8
            // 
            pictureBox8.ErrorImage = (Image)resources.GetObject("pictureBox8.ErrorImage");
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(180, -5);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(75, 61);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 3;
            pictureBox8.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 246, 224);
            label1.Location = new Point(0, -5);
            label1.Name = "label1";
            label1.Size = new Size(191, 59);
            label1.TabIndex = 2;
            label1.Text = "VIKING";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 40, 41);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(719, 52);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 246, 224);
            label2.Location = new Point(122, 2);
            label2.Name = "label2";
            label2.Size = new Size(497, 28);
            label2.TabIndex = 3;
            label2.Text = "Панель управления системой \"Viking\"";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 39);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 51);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1MouseDown;
            panel1.MouseMove += panelMouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(652, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += MinimizeWindows;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.close;
            pictureBox1.Location = new Point(699, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += CloseWindows;
            // 
            // Фамилия
            // 
            Фамилия.HeaderText = "Фамилия";
            Фамилия.Name = "Фамилия";
            // 
            // Otchestvo
            // 
            Otchestvo.HeaderText = "Отчество";
            Otchestvo.Name = "Otchestvo";
            // 
            // Data
            // 
            Data.HeaderText = "Дата рождения";
            Data.Name = "Data";
            // 
            // Number
            // 
            Number.HeaderText = "Телефон";
            Number.Name = "Number";
            // 
            // Age
            // 
            Age.HeaderText = "Возраст";
            Age.Name = "Age";
            // 
            // Status
            // 
            Status.HeaderText = "Статус";
            Status.Name = "Status";
            // 
            // Abonement
            // 
            Abonement.HeaderText = "Абонимент";
            Abonement.Name = "Abonement";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(743, 575);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panelregclient.ResumeLayout(false);
            panelregclient.PerformLayout();
            paneldeleteclient.ResumeLayout(false);
            paneldeleteclient.PerformLayout();
            panelshowclient.ResumeLayout(false);
            panelshowclient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataView).EndInit();
            panelchangeclient.ResumeLayout(false);
            panelchangeclient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            abonementpanel.ResumeLayout(false);
            abonementpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Label label6;
        private PictureBox pictureBox6;
        private Panel panel5;
        private Label label4;
        private PictureBox pictureBox4;
        private Panel panel6;
        private Panel panelregclient;
        private Label label10;
        private Panel paneldeleteclient;
        private Label label7;
        private Panel panelshowclient;
        private Label label8;
        private Panel panelchangeclient;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox5;
        private Panel panel3;
        private Panel panel9;
        private Label label12;
        private Panel panel8;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel panel7;
        private PictureBox pictureBox8;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label podsk78Text;
        private Label ddmmyyText;
        private Label phoneRedStar;
        private TextBox OtchestvoBox;
        private Label nameText;
        private Label otchestvoRedStar;
        private Label otchestvoText;
        private Label nameRedStar;
        private Label dataRozhdText;
        private Label famRedStar;
        private Label phoneText;
        private Button button1;
        private Label famText;
        private TextBox phoneNumBox;
        private TextBox familiyaBox;
        private TextBox nameBox;
        private Button button2;
        private TextBox textBox3;
        private Button buttonBirthDate;
        private Button buttonPhoneNumber;
        private Button buttonPatronymic;
        private Button buttonName;
        private Button buttonFirstName;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label13;
        private Label label14;
        private Label label17;
        private Button button5;
        private TextBox textBox6;
        private Label label18;
        private TextBox textBox7;
        private Panel panel4;
        private Label label11;
        private PictureBox pictureBox7;
        private Panel abonementpanel;
        private Label label15;
        private Label label16;
        private Label label19;
        private Button button4;
        private TextBox textBox4;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn Фамилия;
        private DataGridViewTextBoxColumn Otchestvo;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Abonement;
        private DataGridView DataView;
        private Label label20;
        private Button button6;
    }
}