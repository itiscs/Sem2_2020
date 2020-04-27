namespace WindowsFormsApp1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.lblButton = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(301, 129);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(132, 38);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Кнопка";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(313, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Имя";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHello.Location = new System.Drawing.Point(285, 217);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(148, 25);
            this.lblHello.TabIndex = 2;
            this.lblHello.Text = "Hello, World!";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(507, 129);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(96, 38);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Кнопка 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblButton
            // 
            this.lblButton.AutoSize = true;
            this.lblButton.Location = new System.Drawing.Point(313, 282);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(35, 13);
            this.lblButton.TabIndex = 4;
            this.lblButton.Text = "label1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(521, 217);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblButton);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

