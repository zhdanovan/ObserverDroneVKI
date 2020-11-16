namespace VKI_Drone_UI
{
    partial class Drone_status
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
            this.OnTheWay = new System.Windows.Forms.Label();
            this.Waiting = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OnTheWay
            // 
            this.OnTheWay.AutoSize = true;
            this.OnTheWay.Font = new System.Drawing.Font("Space Age Cyrillic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnTheWay.Location = new System.Drawing.Point(36, 9);
            this.OnTheWay.Name = "OnTheWay";
            this.OnTheWay.Size = new System.Drawing.Size(112, 21);
            this.OnTheWay.TabIndex = 0;
            this.OnTheWay.Text = "В пути";
            // 
            // Waiting
            // 
            this.Waiting.AutoSize = true;
            this.Waiting.Font = new System.Drawing.Font("Space Age Cyrillic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Waiting.Location = new System.Drawing.Point(36, 52);
            this.Waiting.Name = "Waiting";
            this.Waiting.Size = new System.Drawing.Size(159, 21);
            this.Waiting.TabIndex = 1;
            this.Waiting.Text = "Ожидание";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Space Age Cyrillic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(36, 95);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(123, 21);
            this.Error.TabIndex = 2;
            this.Error.Text = "Ошибка";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(16, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(16, 103);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(16, 17);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Space Age Cyrillic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(163, 119);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(55, 27);
            this.Back.TabIndex = 6;
            this.Back.Text = "<--";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Drone_status
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(230, 160);
            this.ControlBox = false;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Waiting);
            this.Controls.Add(this.OnTheWay);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Drone_status";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Drone_status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OnTheWay;
        private System.Windows.Forms.Label Waiting;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label Back;
    }
}