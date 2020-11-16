namespace VKI_Drone_UI
{
    partial class Devices
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
            this.AddDevice = new System.Windows.Forms.Button();
            this.RemoveDevice = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddDevice
            // 
            this.AddDevice.Font = new System.Drawing.Font("Space Age Cyrillic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDevice.Location = new System.Drawing.Point(12, 12);
            this.AddDevice.Name = "AddDevice";
            this.AddDevice.Size = new System.Drawing.Size(256, 47);
            this.AddDevice.TabIndex = 0;
            this.AddDevice.Text = "Добавить устройство";
            this.AddDevice.UseVisualStyleBackColor = true;
            this.AddDevice.Click += new System.EventHandler(this.AddDevice_Click);
            // 
            // RemoveDevice
            // 
            this.RemoveDevice.Font = new System.Drawing.Font("Space Age Cyrillic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveDevice.Location = new System.Drawing.Point(12, 65);
            this.RemoveDevice.Name = "RemoveDevice";
            this.RemoveDevice.Size = new System.Drawing.Size(256, 47);
            this.RemoveDevice.TabIndex = 1;
            this.RemoveDevice.Text = "Удалить устройство";
            this.RemoveDevice.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Space Age Cyrillic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(213, 124);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(55, 27);
            this.Back.TabIndex = 7;
            this.Back.Text = "<--";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 160);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.RemoveDevice);
            this.Controls.Add(this.AddDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Devices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Devices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDevice;
        private System.Windows.Forms.Button RemoveDevice;
        private System.Windows.Forms.Label Back;
    }
}