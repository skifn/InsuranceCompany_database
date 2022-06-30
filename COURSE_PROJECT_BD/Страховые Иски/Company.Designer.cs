
namespace Страховые_Иски
{
    partial class Company
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Company));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_Ins = new System.Windows.Forms.TextBox();
            this.Set_Status_Insurance = new System.Windows.Forms.Button();
            this.Status_Ins = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Table_Insurance = new System.Windows.Forms.DataGridView();
            this.Back_Insurance = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_Claims = new System.Windows.Forms.TextBox();
            this.Set_Status_Claims = new System.Windows.Forms.Button();
            this.Status_Claims = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Table_Claims = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Insurance)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Claims)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 643);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ID_Ins);
            this.tabPage1.Controls.Add(this.Set_Status_Insurance);
            this.tabPage1.Controls.Add(this.Status_Ins);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Table_Insurance);
            this.tabPage1.Controls.Add(this.Back_Insurance);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(959, 617);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заявки на страхование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 497);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "ID заявки:";
            // 
            // ID_Ins
            // 
            this.ID_Ins.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ID_Ins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Ins.Location = new System.Drawing.Point(10, 520);
            this.ID_Ins.Margin = new System.Windows.Forms.Padding(2);
            this.ID_Ins.Name = "ID_Ins";
            this.ID_Ins.Size = new System.Drawing.Size(236, 24);
            this.ID_Ins.TabIndex = 24;
            // 
            // Set_Status_Insurance
            // 
            this.Set_Status_Insurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Set_Status_Insurance.Location = new System.Drawing.Point(375, 520);
            this.Set_Status_Insurance.Margin = new System.Windows.Forms.Padding(2);
            this.Set_Status_Insurance.Name = "Set_Status_Insurance";
            this.Set_Status_Insurance.Size = new System.Drawing.Size(236, 37);
            this.Set_Status_Insurance.TabIndex = 21;
            this.Set_Status_Insurance.Text = "Установить статус";
            this.Set_Status_Insurance.UseVisualStyleBackColor = true;
            this.Set_Status_Insurance.Click += new System.EventHandler(this.Set_Status_Insurance_Click);
            // 
            // Status_Ins
            // 
            this.Status_Ins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status_Ins.FormattingEnabled = true;
            this.Status_Ins.Items.AddRange(new object[] {
            "Одобрено",
            "Отклонено"});
            this.Status_Ins.Location = new System.Drawing.Point(375, 492);
            this.Status_Ins.Margin = new System.Windows.Forms.Padding(2);
            this.Status_Ins.Name = "Status_Ins";
            this.Status_Ins.Size = new System.Drawing.Size(236, 25);
            this.Status_Ins.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 497);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Статус:";
            // 
            // Table_Insurance
            // 
            this.Table_Insurance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Insurance.Location = new System.Drawing.Point(10, 5);
            this.Table_Insurance.Margin = new System.Windows.Forms.Padding(2);
            this.Table_Insurance.Name = "Table_Insurance";
            this.Table_Insurance.RowHeadersWidth = 51;
            this.Table_Insurance.RowTemplate.Height = 24;
            this.Table_Insurance.Size = new System.Drawing.Size(803, 477);
            this.Table_Insurance.TabIndex = 17;
            this.Table_Insurance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_Insurance_CellContentClick);
            // 
            // Back_Insurance
            // 
            this.Back_Insurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Back_Insurance.Location = new System.Drawing.Point(375, 573);
            this.Back_Insurance.Margin = new System.Windows.Forms.Padding(2);
            this.Back_Insurance.Name = "Back_Insurance";
            this.Back_Insurance.Size = new System.Drawing.Size(236, 37);
            this.Back_Insurance.TabIndex = 16;
            this.Back_Insurance.Text = "Назад";
            this.Back_Insurance.UseVisualStyleBackColor = true;
            this.Back_Insurance.Click += new System.EventHandler(this.Back_Insurance_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ID_Claims);
            this.tabPage2.Controls.Add(this.Set_Status_Claims);
            this.tabPage2.Controls.Add(this.Status_Claims);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Table_Claims);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(959, 617);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поданые иски";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 496);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID заявки:";
            // 
            // ID_Claims
            // 
            this.ID_Claims.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Claims.Location = new System.Drawing.Point(8, 519);
            this.ID_Claims.Margin = new System.Windows.Forms.Padding(2);
            this.ID_Claims.Name = "ID_Claims";
            this.ID_Claims.Size = new System.Drawing.Size(236, 24);
            this.ID_Claims.TabIndex = 34;
            // 
            // Set_Status_Claims
            // 
            this.Set_Status_Claims.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Set_Status_Claims.Location = new System.Drawing.Point(571, 512);
            this.Set_Status_Claims.Margin = new System.Windows.Forms.Padding(2);
            this.Set_Status_Claims.Name = "Set_Status_Claims";
            this.Set_Status_Claims.Size = new System.Drawing.Size(236, 37);
            this.Set_Status_Claims.TabIndex = 33;
            this.Set_Status_Claims.Text = "Установить статус";
            this.Set_Status_Claims.UseVisualStyleBackColor = true;
            this.Set_Status_Claims.Click += new System.EventHandler(this.Set_Status_Claim_Click);
            // 
            // Status_Claims
            // 
            this.Status_Claims.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status_Claims.FormattingEnabled = true;
            this.Status_Claims.Items.AddRange(new object[] {
            "Одобрено",
            "Отклонено"});
            this.Status_Claims.Location = new System.Drawing.Point(313, 519);
            this.Status_Claims.Margin = new System.Windows.Forms.Padding(2);
            this.Status_Claims.Name = "Status_Claims";
            this.Status_Claims.Size = new System.Drawing.Size(236, 25);
            this.Status_Claims.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(309, 496);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Статус:";
            // 
            // Table_Claims
            // 
            this.Table_Claims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Claims.Location = new System.Drawing.Point(4, 5);
            this.Table_Claims.Margin = new System.Windows.Forms.Padding(2);
            this.Table_Claims.Name = "Table_Claims";
            this.Table_Claims.RowHeadersWidth = 51;
            this.Table_Claims.RowTemplate.Height = 24;
            this.Table_Claims.Size = new System.Drawing.Size(897, 477);
            this.Table_Claims.TabIndex = 30;
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 665);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Company";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Insurance)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Claims)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID_Ins;
        private System.Windows.Forms.Button Set_Status_Insurance;
        private System.Windows.Forms.ComboBox Status_Ins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Table_Insurance;
        private System.Windows.Forms.Button Back_Insurance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_Claims;
        private System.Windows.Forms.Button Set_Status_Claims;
        private System.Windows.Forms.ComboBox Status_Claims;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Table_Claims;
    }
}