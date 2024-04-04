namespace HotelApp
{
    partial class GuestInfoForm
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
            this.GuestInfoLabel = new System.Windows.Forms.Label();
            this.nameGuestTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.PaymentInfoLabel = new System.Windows.Forms.Label();
            this.NumberOfDaysLabel = new System.Windows.Forms.Label();
            this.WithAnimalsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // GuestInfoLabel
            // 
            this.GuestInfoLabel.AutoSize = true;
            this.GuestInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuestInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuestInfoLabel.Location = new System.Drawing.Point(75, 9);
            this.GuestInfoLabel.Name = "GuestInfoLabel";
            this.GuestInfoLabel.Size = new System.Drawing.Size(190, 31);
            this.GuestInfoLabel.TabIndex = 0;
            this.GuestInfoLabel.Text = "Карточка гостя";
            // 
            // nameGuestTextBox
            // 
            this.nameGuestTextBox.Location = new System.Drawing.Point(12, 70);
            this.nameGuestTextBox.Name = "nameGuestTextBox";
            this.nameGuestTextBox.Size = new System.Drawing.Size(352, 22);
            this.nameGuestTextBox.TabIndex = 1;
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(12, 130);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(352, 22);
            this.dateOfBirthTextBox.TabIndex = 2;
            // 
            // PaymentInfoLabel
            // 
            this.PaymentInfoLabel.AutoSize = true;
            this.PaymentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentInfoLabel.Location = new System.Drawing.Point(12, 198);
            this.PaymentInfoLabel.Name = "PaymentInfoLabel";
            this.PaymentInfoLabel.Size = new System.Drawing.Size(96, 29);
            this.PaymentInfoLabel.TabIndex = 3;
            this.PaymentInfoLabel.Text = "Оплата";
            // 
            // NumberOfDaysLabel
            // 
            this.NumberOfDaysLabel.AutoSize = true;
            this.NumberOfDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfDaysLabel.Location = new System.Drawing.Point(12, 255);
            this.NumberOfDaysLabel.Name = "NumberOfDaysLabel";
            this.NumberOfDaysLabel.Size = new System.Drawing.Size(209, 29);
            this.NumberOfDaysLabel.TabIndex = 4;
            this.NumberOfDaysLabel.Text = "Количество дней";
            // 
            // WithAnimalsCheckBox
            // 
            this.WithAnimalsCheckBox.AutoSize = true;
            this.WithAnimalsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WithAnimalsCheckBox.Location = new System.Drawing.Point(17, 312);
            this.WithAnimalsCheckBox.Name = "WithAnimalsCheckBox";
            this.WithAnimalsCheckBox.Size = new System.Drawing.Size(348, 33);
            this.WithAnimalsCheckBox.TabIndex = 5;
            this.WithAnimalsCheckBox.Text = "Путешествие с животными";
            this.WithAnimalsCheckBox.UseVisualStyleBackColor = true;
            // 
            // GuestInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(376, 459);
            this.Controls.Add(this.WithAnimalsCheckBox);
            this.Controls.Add(this.NumberOfDaysLabel);
            this.Controls.Add(this.PaymentInfoLabel);
            this.Controls.Add(this.dateOfBirthTextBox);
            this.Controls.Add(this.nameGuestTextBox);
            this.Controls.Add(this.GuestInfoLabel);
            this.Name = "GuestInfoForm";
            this.Text = "Карточка гостя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GuestInfoLabel;
        public System.Windows.Forms.TextBox nameGuestTextBox;
        public System.Windows.Forms.TextBox dateOfBirthTextBox;
        public System.Windows.Forms.Label PaymentInfoLabel;
        public System.Windows.Forms.Label NumberOfDaysLabel;
        public System.Windows.Forms.CheckBox WithAnimalsCheckBox;
    }
}