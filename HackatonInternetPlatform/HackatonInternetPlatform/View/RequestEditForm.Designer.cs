namespace HackatonInternetPlatform.View
{
    partial class RequestEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEditRequestTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxEditRequestCount = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEditRequestType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxEditRequestCurrency = new System.Windows.Forms.ComboBox();
            this.comboBoxEditRequestPayMethod = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // textBoxEditRequestTitle
            // 
            this.textBoxEditRequestTitle.Location = new System.Drawing.Point(12, 41);
            this.textBoxEditRequestTitle.Name = "textBoxEditRequestTitle";
            this.textBoxEditRequestTitle.Size = new System.Drawing.Size(123, 23);
            this.textBoxEditRequestTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Кол-во";
            // 
            // maskedTextBoxEditRequestCount
            // 
            this.maskedTextBoxEditRequestCount.Location = new System.Drawing.Point(12, 96);
            this.maskedTextBoxEditRequestCount.Mask = "0000000";
            this.maskedTextBoxEditRequestCount.Name = "maskedTextBoxEditRequestCount";
            this.maskedTextBoxEditRequestCount.PromptChar = 'ㅤ';
            this.maskedTextBoxEditRequestCount.Size = new System.Drawing.Size(123, 23);
            this.maskedTextBoxEditRequestCount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тип";
            // 
            // textBoxEditRequestType
            // 
            this.textBoxEditRequestType.Location = new System.Drawing.Point(12, 153);
            this.textBoxEditRequestType.Name = "textBoxEditRequestType";
            this.textBoxEditRequestType.Size = new System.Drawing.Size(123, 23);
            this.textBoxEditRequestType.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Валюта";
            // 
            // comboBoxEditRequestCurrency
            // 
            this.comboBoxEditRequestCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditRequestCurrency.FormattingEnabled = true;
            this.comboBoxEditRequestCurrency.Items.AddRange(new object[] {
            "₽",
            "$",
            "€"});
            this.comboBoxEditRequestCurrency.Location = new System.Drawing.Point(12, 212);
            this.comboBoxEditRequestCurrency.Name = "comboBoxEditRequestCurrency";
            this.comboBoxEditRequestCurrency.Size = new System.Drawing.Size(46, 23);
            this.comboBoxEditRequestCurrency.TabIndex = 6;
            // 
            // comboBoxEditRequestPayMethod
            // 
            this.comboBoxEditRequestPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditRequestPayMethod.FormattingEnabled = true;
            this.comboBoxEditRequestPayMethod.Items.AddRange(new object[] {
            "наличные ",
            "карта",
            "онлайн кошелек"});
            this.comboBoxEditRequestPayMethod.Location = new System.Drawing.Point(12, 271);
            this.comboBoxEditRequestPayMethod.Name = "comboBoxEditRequestPayMethod";
            this.comboBoxEditRequestPayMethod.Size = new System.Drawing.Size(123, 23);
            this.comboBoxEditRequestPayMethod.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Способ оплаты";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 329);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 23);
            this.textBox3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Адрес доставки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RequestEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxEditRequestPayMethod);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxEditRequestCurrency);
            this.Controls.Add(this.maskedTextBoxEditRequestCount);
            this.Controls.Add(this.textBoxEditRequestType);
            this.Controls.Add(this.textBoxEditRequestTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RequestEditForm";
            this.Text = "RequestEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxEditRequestTitle;
        private Label label2;
        private MaskedTextBox maskedTextBoxEditRequestCount;
        private Label label3;
        private TextBox textBoxEditRequestType;
        private Label label10;
        private ComboBox comboBoxEditRequestCurrency;
        private ComboBox comboBoxEditRequestPayMethod;
        private Label label14;
        private TextBox textBox3;
        private Label label7;
        private Button button1;
    }
}