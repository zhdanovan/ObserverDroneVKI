namespace VKI_Drone_UI
{
    partial class Adding_Info
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
            this.Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Поднесите определяющую NFC-метку к подключаемому\r\nустройству\r\n2. Нажмите кнопк" +
    "у на определяющей NFC-метке и дождитесь\r\nсветового сигнала\r\n3. Нажмите кнопку \"П" +
    "одключить\" в данном окне.";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Space Age Cyrillic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(116, 146);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(357, 64);
            this.Add.TabIndex = 1;
            this.Add.Text = "Подключить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Space Age Cyrillic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(249, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отменить подключение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adding_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Adding_Info";
            this.Text = "Adding_Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button1;
    }
}