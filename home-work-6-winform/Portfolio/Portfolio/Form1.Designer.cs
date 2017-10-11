namespace Portfolio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.ThirdName = new System.Windows.Forms.TextBox();
            this.FamilyStatus = new System.Windows.Forms.TextBox();
            this.AddInformation = new System.Windows.Forms.TextBox();
            this.Man = new System.Windows.Forms.RadioButton();
            this.Women = new System.Windows.Forms.RadioButton();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(34, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Год и Дата Рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(34, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Семейный статус";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(34, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дополнительная информация";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(472, 18);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(135, 32);
            this.FirstName.TabIndex = 7;
            // 
            // SecondName
            // 
            this.SecondName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondName.Location = new System.Drawing.Point(472, 59);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(135, 32);
            this.SecondName.TabIndex = 8;
            // 
            // ThirdName
            // 
            this.ThirdName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdName.Location = new System.Drawing.Point(472, 110);
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.Size = new System.Drawing.Size(135, 32);
            this.ThirdName.TabIndex = 9;
            // 
            // FamilyStatus
            // 
            this.FamilyStatus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamilyStatus.Location = new System.Drawing.Point(472, 225);
            this.FamilyStatus.Name = "FamilyStatus";
            this.FamilyStatus.Size = new System.Drawing.Size(135, 32);
            this.FamilyStatus.TabIndex = 12;
            // 
            // AddInformation
            // 
            this.AddInformation.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddInformation.Location = new System.Drawing.Point(472, 279);
            this.AddInformation.Name = "AddInformation";
            this.AddInformation.Size = new System.Drawing.Size(135, 32);
            this.AddInformation.TabIndex = 13;
            // 
            // Man
            // 
            this.Man.AutoSize = true;
            this.Man.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Man.Location = new System.Drawing.Point(395, 148);
            this.Man.Name = "Man";
            this.Man.Size = new System.Drawing.Size(117, 28);
            this.Man.TabIndex = 14;
            this.Man.TabStop = true;
            this.Man.Text = "Мужской";
            this.Man.UseVisualStyleBackColor = true;
            // 
            // Women
            // 
            this.Women.AutoSize = true;
            this.Women.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Women.Location = new System.Drawing.Point(562, 148);
            this.Women.Name = "Women";
            this.Women.Size = new System.Drawing.Size(116, 28);
            this.Women.TabIndex = 15;
            this.Women.TabStop = true;
            this.Women.Text = "Женский";
            this.Women.UseVisualStyleBackColor = true;
            // 
            // DateTime
            // 
            this.DateTime.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTime.Location = new System.Drawing.Point(395, 182);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(212, 32);
            this.DateTime.TabIndex = 16;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(277, 360);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 17;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.Women);
            this.Controls.Add(this.Man);
            this.Controls.Add(this.AddInformation);
            this.Controls.Add(this.FamilyStatus);
            this.Controls.Add(this.ThirdName);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.TextBox ThirdName;
        private System.Windows.Forms.TextBox FamilyStatus;
        private System.Windows.Forms.TextBox AddInformation;
        private System.Windows.Forms.RadioButton Man;
        private System.Windows.Forms.RadioButton Women;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Button Save;
    }
}

