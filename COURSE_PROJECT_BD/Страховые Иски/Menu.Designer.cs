
namespace Страховые_Иски
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.come_on = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать!\r\nПожалуйста, авторизуйтесь\r\n";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(355, 215);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(259, 28);
            this.mail.TabIndex = 1;
            this.mail.TextChanged += new System.EventHandler(this.mail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(350, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(350, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(355, 294);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(259, 28);
            this.pass.TabIndex = 3;
            // 
            // come_on
            // 
            this.come_on.BackColor = System.Drawing.Color.BurlyWood;
            this.come_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.come_on.Location = new System.Drawing.Point(354, 346);
            this.come_on.Name = "come_on";
            this.come_on.Size = new System.Drawing.Size(259, 48);
            this.come_on.TabIndex = 5;
            this.come_on.Text = "Войти";
            this.come_on.UseVisualStyleBackColor = false;
            this.come_on.Click += new System.EventHandler(this.come_on_Click);
            // 
            // registration
            // 
            this.registration.AutoSize = true;
            this.registration.BackColor = System.Drawing.Color.BurlyWood;
            this.registration.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registration.Location = new System.Drawing.Point(505, 427);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(109, 26);
            this.registration.TabIndex = 6;
            this.registration.Text = "Регистрация";
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(327, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Впервые у нас? ->";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1029, 597);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.come_on);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button come_on;
        private System.Windows.Forms.Label registration;
        private System.Windows.Forms.Label label4;
    }
}

