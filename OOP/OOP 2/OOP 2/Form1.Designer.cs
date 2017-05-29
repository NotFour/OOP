using System.Windows.Forms;

namespace OOP_2
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


        private Label labelEnterpriseName;
        private Label labelWorkmans;
        private Label labelPaymentPerHour;
        private Label labelBestWorker;
        private Label labelHoursPerMonth;
        private Label labelImposing;
        private Label labelSuperior;
        private TextBox tbEnterpriseName;
        private TextBox tbWorkmans;
        private TextBox tbPaymentPerHour;
        private TextBox tbBestWorker;
        private TextBox tbHoursPerMonth;
        private TextBox tbImposing;
        private TextBox tbSuperior;
    }
}

