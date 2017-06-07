using System;

namespace OOP3
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
            this.labelEnterpriseName = new System.Windows.Forms.Label();
            this.labelWorkmans = new System.Windows.Forms.Label();
            this.labelPaymentPerHour = new System.Windows.Forms.Label();
            this.labelBestWorker = new System.Windows.Forms.Label();
            this.labelHoursPerMonth = new System.Windows.Forms.Label();
            this.labelImposing = new System.Windows.Forms.Label();
            this.labelSuperior = new System.Windows.Forms.Label();
            this.tbEnterpriseName = new System.Windows.Forms.TextBox();
            this.tbWorkmans = new System.Windows.Forms.TextBox();
            this.tbPaymentPerHour = new System.Windows.Forms.TextBox();
            this.tbBestWorker = new System.Windows.Forms.TextBox();
            this.tbHoursPerMonth = new System.Windows.Forms.TextBox();
            this.tbImposing = new System.Windows.Forms.TextBox();
            this.tbSuperior = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnterpriseName
            // 
            this.labelEnterpriseName.AutoEllipsis = true;
            this.labelEnterpriseName.AutoSize = true;
            this.labelEnterpriseName.Location = new System.Drawing.Point(10, 10);
            this.labelEnterpriseName.MaximumSize = new System.Drawing.Size(125, 15);
            this.labelEnterpriseName.Name = "labelEnterpriseName";
            this.labelEnterpriseName.Size = new System.Drawing.Size(125, 13);
            this.labelEnterpriseName.TabIndex = 0;
            this.labelEnterpriseName.Text = "Название предприятия";
            // 
            // labelWorkmans
            // 
            this.labelWorkmans.AutoEllipsis = true;
            this.labelWorkmans.AutoSize = true;
            this.labelWorkmans.Location = new System.Drawing.Point(10, 40);
            this.labelWorkmans.Name = "labelWorkmans";
            this.labelWorkmans.Size = new System.Drawing.Size(128, 13);
            this.labelWorkmans.TabIndex = 1;
            this.labelWorkmans.Text = "Количество работников";
            // 
            // labelPaymentPerHour
            // 
            this.labelPaymentPerHour.AutoEllipsis = true;
            this.labelPaymentPerHour.AutoSize = true;
            this.labelPaymentPerHour.Location = new System.Drawing.Point(10, 70);
            this.labelPaymentPerHour.Name = "labelPaymentPerHour";
            this.labelPaymentPerHour.Size = new System.Drawing.Size(51, 13);
            this.labelPaymentPerHour.TabIndex = 2;
            this.labelPaymentPerHour.Text = "ЗП в час";
            // 
            // labelBestWorker
            // 
            this.labelBestWorker.AutoEllipsis = true;
            this.labelBestWorker.AutoSize = true;
            this.labelBestWorker.Location = new System.Drawing.Point(10, 100);
            this.labelBestWorker.Name = "labelBestWorker";
            this.labelBestWorker.Size = new System.Drawing.Size(95, 13);
            this.labelBestWorker.TabIndex = 3;
            this.labelBestWorker.Text = "Лучший работник";
            // 
            // labelHoursPerMonth
            // 
            this.labelHoursPerMonth.AutoEllipsis = true;
            this.labelHoursPerMonth.AutoSize = true;
            this.labelHoursPerMonth.Location = new System.Drawing.Point(10, 130);
            this.labelHoursPerMonth.Name = "labelHoursPerMonth";
            this.labelHoursPerMonth.Size = new System.Drawing.Size(124, 13);
            this.labelHoursPerMonth.TabIndex = 4;
            this.labelHoursPerMonth.Text = "Рабочих часов в месяц";
            // 
            // labelImposing
            // 
            this.labelImposing.AutoEllipsis = true;
            this.labelImposing.AutoSize = true;
            this.labelImposing.Location = new System.Drawing.Point(10, 160);
            this.labelImposing.Name = "labelImposing";
            this.labelImposing.Size = new System.Drawing.Size(84, 13);
            this.labelImposing.TabIndex = 5;
            this.labelImposing.Text = "Размер налога";
            // 
            // labelSuperior
            // 
            this.labelSuperior.AutoEllipsis = true;
            this.labelSuperior.AutoSize = true;
            this.labelSuperior.Location = new System.Drawing.Point(10, 190);
            this.labelSuperior.Name = "labelSuperior";
            this.labelSuperior.Size = new System.Drawing.Size(93, 13);
            this.labelSuperior.TabIndex = 6;
            this.labelSuperior.Text = "Глава отделения";
            // 
            // tbEnterpriseName
            // 
            this.tbEnterpriseName.Location = new System.Drawing.Point(156, 10);
            this.tbEnterpriseName.Name = "tbEnterpriseName";
            this.tbEnterpriseName.Size = new System.Drawing.Size(100, 20);
            this.tbEnterpriseName.TabIndex = 7;
            // 
            // tbWorkmans
            // 
            this.tbWorkmans.Location = new System.Drawing.Point(156, 40);
            this.tbWorkmans.Name = "tbWorkmans";
            this.tbWorkmans.Size = new System.Drawing.Size(100, 20);
            this.tbWorkmans.TabIndex = 8;
            // 
            // tbPaymentPerHour
            // 
            this.tbPaymentPerHour.Location = new System.Drawing.Point(156, 70);
            this.tbPaymentPerHour.Name = "tbPaymentPerHour";
            this.tbPaymentPerHour.Size = new System.Drawing.Size(100, 20);
            this.tbPaymentPerHour.TabIndex = 9;
            // 
            // tbBestWorker
            // 
            this.tbBestWorker.Location = new System.Drawing.Point(156, 100);
            this.tbBestWorker.Name = "tbBestWorker";
            this.tbBestWorker.Size = new System.Drawing.Size(100, 20);
            this.tbBestWorker.TabIndex = 10;
            // 
            // tbHoursPerMonth
            // 
            this.tbHoursPerMonth.Location = new System.Drawing.Point(156, 130);
            this.tbHoursPerMonth.Name = "tbHoursPerMonth";
            this.tbHoursPerMonth.Size = new System.Drawing.Size(100, 20);
            this.tbHoursPerMonth.TabIndex = 11;
            // 
            // tbImposing
            // 
            this.tbImposing.Location = new System.Drawing.Point(156, 160);
            this.tbImposing.Name = "tbImposing";
            this.tbImposing.Size = new System.Drawing.Size(100, 20);
            this.tbImposing.TabIndex = 12;
            // 
            // tbSuperior
            // 
            this.tbSuperior.Location = new System.Drawing.Point(156, 190);
            this.tbSuperior.Name = "tbSuperior";
            this.tbSuperior.Size = new System.Drawing.Size(100, 20);
            this.tbSuperior.TabIndex = 13;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(13, 217);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(156, 217);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 23);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.AcceptsTab = true;
            this.tbOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbOutput.Location = new System.Drawing.Point(274, 10);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ShortcutsEnabled = false;
            this.tbOutput.Size = new System.Drawing.Size(224, 193);
            this.tbOutput.TabIndex = 14;
            this.tbOutput.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(10, 243);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(80, 13);
            this.labelError.TabIndex = 17;
            this.labelError.Text = "Ошибка ввода";
            this.labelError.Visible = false;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(156, 246);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(100, 23);
            this.buttonShow.TabIndex = 18;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 273);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tbSuperior);
            this.Controls.Add(this.tbImposing);
            this.Controls.Add(this.tbHoursPerMonth);
            this.Controls.Add(this.tbBestWorker);
            this.Controls.Add(this.tbPaymentPerHour);
            this.Controls.Add(this.tbWorkmans);
            this.Controls.Add(this.tbEnterpriseName);
            this.Controls.Add(this.labelSuperior);
            this.Controls.Add(this.labelImposing);
            this.Controls.Add(this.labelHoursPerMonth);
            this.Controls.Add(this.labelBestWorker);
            this.Controls.Add(this.labelPaymentPerHour);
            this.Controls.Add(this.labelWorkmans);
            this.Controls.Add(this.labelEnterpriseName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (Program.CheckingTBs())
            {
                labelError.Visible = false;
                Program.CreateEnterprise();
            }
            else
            {
                labelError.Visible = true;
            }
        }

        private void buttonShow_Click(object sender, System.EventArgs e)
        {
            Program.ShowAllEnterprises();
        }

        #endregion

        public System.Windows.Forms.Label labelEnterpriseName;
        public System.Windows.Forms.Label labelWorkmans;
        public System.Windows.Forms.Label labelPaymentPerHour;
        public System.Windows.Forms.Label labelBestWorker;
        public System.Windows.Forms.Label labelHoursPerMonth;
        public System.Windows.Forms.Label labelImposing;
        public System.Windows.Forms.Label labelSuperior;
        public System.Windows.Forms.TextBox tbEnterpriseName;
        public System.Windows.Forms.TextBox tbWorkmans;
        public System.Windows.Forms.TextBox tbPaymentPerHour;
        public System.Windows.Forms.TextBox tbBestWorker;
        public System.Windows.Forms.TextBox tbHoursPerMonth;
        public System.Windows.Forms.TextBox tbImposing;
        public System.Windows.Forms.TextBox tbSuperior;
        public System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.Button buttonCreate;
        public System.Windows.Forms.TextBox tbOutput;
        public System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonShow;
    }
}

