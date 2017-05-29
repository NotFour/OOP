using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {

            Size maxSizeComponent = new Size(125, 15);

            this.labelEnterpriseName = new Label();
            this.labelWorkmans = new Label();
            this.labelPaymentPerHour = new Label();
            this.labelBestWorker = new Label();
            this.labelHoursPerMonth = new Label();
            this.labelImposing = new Label();
            this.labelSuperior = new Label();
            this.tbEnterpriseName = new TextBox();
            this.tbWorkmans = new TextBox();
            this.tbPaymentPerHour = new TextBox();
            this.tbBestWorker = new TextBox();
            this.tbHoursPerMonth = new TextBox();
            this.tbImposing = new TextBox();
            this.tbSuperior = new TextBox();
            this.SuspendLayout();
         
            this.labelEnterpriseName.AutoEllipsis = true;
            this.labelEnterpriseName.AutoSize = true;
            this.labelEnterpriseName.Location = new Point(13, 13);
            this.labelEnterpriseName.MaximumSize = maxSizeComponent;
            this.labelEnterpriseName.TabIndex = 0;
            this.labelEnterpriseName.Text = "Название предприятия";
          
            this.labelWorkmans.AutoEllipsis = true;
            this.labelWorkmans.AutoSize = true;
            this.labelWorkmans.Location = new Point(13, 40);
            this.labelEnterpriseName.MaximumSize = maxSizeComponent;
            this.labelWorkmans.TabIndex = 1;
            this.labelWorkmans.Text = "Количество работников";
      
            this.labelPaymentPerHour.AutoEllipsis = true;
            this.labelPaymentPerHour.AutoSize = true;
            this.labelPaymentPerHour.Location = new Point(13, 60);
            this.labelEnterpriseName.MaximumSize = maxSizeComponent;
            this.labelPaymentPerHour.TabIndex = 2;
            this.labelPaymentPerHour.Text = "ЗП в час";
     
            this.labelBestWorker.AutoEllipsis = true;
            this.labelBestWorker.AutoSize = true;
            this.labelBestWorker.Location = new Point(13, 80);
            this.labelEnterpriseName.MaximumSize = maxSizeComponent;
            this.labelBestWorker.TabIndex = 3;
            this.labelBestWorker.Text = "Лучший работник";
        
            this.labelHoursPerMonth.AutoEllipsis = true;
            this.labelHoursPerMonth.AutoSize = true;
            this.labelHoursPerMonth.Location = new Point(13, 100);
            this.labelEnterpriseName.MaximumSize = maxSizeComponent;
            this.labelHoursPerMonth.TabIndex = 4;
            this.labelHoursPerMonth.Text = "Рабочих часов в месяц";
        
            this.labelImposing.AutoEllipsis = true;
            this.labelImposing.AutoSize = true;
            this.labelImposing.Location = new Point(13, 120);
            this.labelEnterpriseName.MaximumSize = maxSizeComponent;
            this.labelImposing.TabIndex = 5;
            this.labelImposing.Text = "Размер налога";
          
            this.labelSuperior.AutoEllipsis = true;
            this.labelSuperior.AutoSize = true;
            this.labelSuperior.Location = new Point(13, 140);
            this.labelEnterpriseName.MaximumSize = maxSizeComponent;
            this.labelSuperior.TabIndex = 6;
            this.labelSuperior.Text = "Глава отделения";
            // 
            // textBox1
            // 
            this.tbEnterpriseName.Location = new Point(160, 40);
            this.tbEnterpriseName.Name = "textBox1";
            this.tbEnterpriseName.Size = new Size(100, 20);
            this.tbEnterpriseName.TabIndex = 7;
            // 
            // textBox2
            // 
            this.tbWorkmans.Location = new Point(156, 38);
            this.tbWorkmans.Name = "textBox2";
            this.tbWorkmans.Size = new Size(100, 20);
            this.tbWorkmans.TabIndex = 8;
            // 
            // textBox3
            // 
            this.tbPaymentPerHour.Location = new Point(156, 60);
            this.tbPaymentPerHour.Name = "textBox3";
            this.tbPaymentPerHour.Size = new Size(100, 20);
            this.tbPaymentPerHour.TabIndex = 9;
            // 
            // textBox4
            // 
            this.tbBestWorker.Location = new Point(156, 84);
            this.tbBestWorker.Name = "textBox4";
            this.tbBestWorker.Size = new Size(100, 20);
            this.tbBestWorker.TabIndex = 10;
            // 
            // textBox5
            // 
            this.tbHoursPerMonth.Location = new Point(156, 107);
            this.tbHoursPerMonth.Name = "textBox5";
            this.tbHoursPerMonth.Size = new Size(100, 20);
            this.tbHoursPerMonth.TabIndex = 11;
            // 
            // textBox6
            // 
            this.tbImposing.Location = new Point(156, 130);
            this.tbImposing.Name = "textBox6";
            this.tbImposing.Size = new Size(100, 20);
            this.tbImposing.TabIndex = 12;
            // 
            // textBox7
            // 
            this.tbSuperior.Location = new Point(156, 153);
            this.tbSuperior.Name = "textBox7";
            this.tbSuperior.Size = new Size(100, 20);
            this.tbSuperior.TabIndex = 13;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 334);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
