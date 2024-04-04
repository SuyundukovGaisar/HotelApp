namespace HotelApp
{
    partial class HotelForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkoutRadioButton = new System.Windows.Forms.RadioButton();
            this.occupiedRadioButton = new System.Windows.Forms.RadioButton();
            this.freeRadioButton = new System.Windows.Forms.RadioButton();
            this.reserveRadioButton = new System.Windows.Forms.RadioButton();
            this.statusLabel = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.guestsGridView = new System.Windows.Forms.DataGridView();
            this.guestListLabel = new System.Windows.Forms.Label();
            this.InfoCardbutton = new System.Windows.Forms.Button();
            this.departure_dateTextBox = new System.Windows.Forms.RichTextBox();
            this.check_in_dateTextBox = new System.Windows.Forms.RichTextBox();
            this.FIOtextBox = new System.Windows.Forms.TextBox();
            this.statusInfotextBox = new System.Windows.Forms.TextBox();
            this.statusguestLabel = new System.Windows.Forms.Label();
            this.guestpictureBox = new System.Windows.Forms.PictureBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.searchtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.checkoutRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.occupiedRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.freeRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.reserveRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.statusLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 400);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // checkoutRadioButton
            // 
            this.checkoutRadioButton.AutoSize = true;
            this.checkoutRadioButton.Location = new System.Drawing.Point(12, 135);
            this.checkoutRadioButton.Name = "checkoutRadioButton";
            this.checkoutRadioButton.Size = new System.Drawing.Size(125, 20);
            this.checkoutRadioButton.TabIndex = 4;
            this.checkoutRadioButton.Text = "Выписываются";
            this.checkoutRadioButton.UseVisualStyleBackColor = true;
            // 
            // occupiedRadioButton
            // 
            this.occupiedRadioButton.AutoSize = true;
            this.occupiedRadioButton.Location = new System.Drawing.Point(12, 108);
            this.occupiedRadioButton.Name = "occupiedRadioButton";
            this.occupiedRadioButton.Size = new System.Drawing.Size(76, 20);
            this.occupiedRadioButton.TabIndex = 3;
            this.occupiedRadioButton.Text = "Заняты";
            this.occupiedRadioButton.UseVisualStyleBackColor = true;
            // 
            // freeRadioButton
            // 
            this.freeRadioButton.AutoSize = true;
            this.freeRadioButton.Location = new System.Drawing.Point(12, 80);
            this.freeRadioButton.Name = "freeRadioButton";
            this.freeRadioButton.Size = new System.Drawing.Size(102, 20);
            this.freeRadioButton.TabIndex = 2;
            this.freeRadioButton.Text = "Свободные";
            this.freeRadioButton.UseVisualStyleBackColor = true;
            this.freeRadioButton.CheckedChanged += new System.EventHandler(this.ReserveRadioButton_CheckedChanged);
            // 
            // reserveRadioButton
            // 
            this.reserveRadioButton.AutoSize = true;
            this.reserveRadioButton.Location = new System.Drawing.Point(12, 54);
            this.reserveRadioButton.Name = "reserveRadioButton";
            this.reserveRadioButton.Size = new System.Drawing.Size(149, 20);
            this.reserveRadioButton.TabIndex = 1;
            this.reserveRadioButton.Text = "Зарезервировано";
            this.reserveRadioButton.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(12, 10);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(106, 34);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Статус";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer2.Panel1.Controls.Add(this.guestsGridView);
            this.splitContainer2.Panel1.Controls.Add(this.guestListLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer2.Panel2.Controls.Add(this.InfoCardbutton);
            this.splitContainer2.Panel2.Controls.Add(this.departure_dateTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.check_in_dateTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.FIOtextBox);
            this.splitContainer2.Panel2.Controls.Add(this.statusInfotextBox);
            this.splitContainer2.Panel2.Controls.Add(this.statusguestLabel);
            this.splitContainer2.Panel2.Controls.Add(this.guestpictureBox);
            this.splitContainer2.Panel2.Controls.Add(this.numberLabel);
            this.splitContainer2.Size = new System.Drawing.Size(627, 400);
            this.splitContainer2.SplitterDistance = 224;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // guestsGridView
            // 
            this.guestsGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.guestsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestsGridView.Location = new System.Drawing.Point(3, 54);
            this.guestsGridView.Name = "guestsGridView";
            this.guestsGridView.RowHeadersWidth = 51;
            this.guestsGridView.RowTemplate.Height = 24;
            this.guestsGridView.Size = new System.Drawing.Size(291, 343);
            this.guestsGridView.TabIndex = 1;
            this.guestsGridView.DoubleClick += new System.EventHandler(this.guestsGridView_DoubleClick);
            // 
            // guestListLabel
            // 
            this.guestListLabel.AutoSize = true;
            this.guestListLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guestListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestListLabel.Location = new System.Drawing.Point(3, 10);
            this.guestListLabel.Name = "guestListLabel";
            this.guestListLabel.Size = new System.Drawing.Size(205, 34);
            this.guestListLabel.TabIndex = 0;
            this.guestListLabel.Text = "Список гостей";
            // 
            // InfoCardbutton
            // 
            this.InfoCardbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfoCardbutton.Location = new System.Drawing.Point(14, 365);
            this.InfoCardbutton.Name = "InfoCardbutton";
            this.InfoCardbutton.Size = new System.Drawing.Size(168, 30);
            this.InfoCardbutton.TabIndex = 7;
            this.InfoCardbutton.Text = "Просмотр карточки";
            this.InfoCardbutton.UseVisualStyleBackColor = false;
            this.InfoCardbutton.Click += new System.EventHandler(this.InfoCardbutton_Click);
            // 
            // departure_dateTextBox
            // 
            this.departure_dateTextBox.Location = new System.Drawing.Point(14, 309);
            this.departure_dateTextBox.Name = "departure_dateTextBox";
            this.departure_dateTextBox.Size = new System.Drawing.Size(195, 50);
            this.departure_dateTextBox.TabIndex = 6;
            this.departure_dateTextBox.Text = "";
            // 
            // check_in_dateTextBox
            // 
            this.check_in_dateTextBox.Location = new System.Drawing.Point(14, 250);
            this.check_in_dateTextBox.Name = "check_in_dateTextBox";
            this.check_in_dateTextBox.Size = new System.Drawing.Size(195, 53);
            this.check_in_dateTextBox.TabIndex = 5;
            this.check_in_dateTextBox.Text = "";
            // 
            // FIOtextBox
            // 
            this.FIOtextBox.Location = new System.Drawing.Point(14, 214);
            this.FIOtextBox.Name = "FIOtextBox";
            this.FIOtextBox.Size = new System.Drawing.Size(292, 22);
            this.FIOtextBox.TabIndex = 4;
            // 
            // statusInfotextBox
            // 
            this.statusInfotextBox.Location = new System.Drawing.Point(123, 175);
            this.statusInfotextBox.Name = "statusInfotextBox";
            this.statusInfotextBox.Size = new System.Drawing.Size(200, 22);
            this.statusInfotextBox.TabIndex = 3;
            // 
            // statusguestLabel
            // 
            this.statusguestLabel.AutoSize = true;
            this.statusguestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusguestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusguestLabel.Location = new System.Drawing.Point(14, 166);
            this.statusguestLabel.Name = "statusguestLabel";
            this.statusguestLabel.Size = new System.Drawing.Size(92, 31);
            this.statusguestLabel.TabIndex = 2;
            this.statusguestLabel.Text = "Статус";
            // 
            // guestpictureBox
            // 
            this.guestpictureBox.Location = new System.Drawing.Point(14, 47);
            this.guestpictureBox.Name = "guestpictureBox";
            this.guestpictureBox.Size = new System.Drawing.Size(243, 116);
            this.guestpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guestpictureBox.TabIndex = 1;
            this.guestpictureBox.TabStop = false;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(14, 10);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(139, 34);
            this.numberLabel.TabIndex = 0;
            this.numberLabel.Text = "Номер №";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(9, 8);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(73, 31);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "00:00";
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("searchPictureBox.Image")));
            this.searchPictureBox.Location = new System.Drawing.Point(746, 8);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(34, 32);
            this.searchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchPictureBox.TabIndex = 3;
            this.searchPictureBox.TabStop = false;
            this.searchPictureBox.Click += new System.EventHandler(this.searchPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(176, 13);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(564, 22);
            this.searchtextBox.TabIndex = 5;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchPictureBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HotelForm";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.HotelForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guestsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label guestListLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.RadioButton freeRadioButton;
        private System.Windows.Forms.RadioButton checkoutRadioButton;
        private System.Windows.Forms.RadioButton occupiedRadioButton;
        private System.Windows.Forms.Label statusguestLabel;
        private System.Windows.Forms.PictureBox guestpictureBox;
        private System.Windows.Forms.Button InfoCardbutton;
        private System.Windows.Forms.RichTextBox departure_dateTextBox;
        private System.Windows.Forms.RichTextBox check_in_dateTextBox;
        private System.Windows.Forms.DataGridView guestsGridView;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox searchtextBox;
        public System.Windows.Forms.RadioButton reserveRadioButton;
        private System.Windows.Forms.TextBox FIOtextBox;
        private System.Windows.Forms.TextBox statusInfotextBox;
    }
}

