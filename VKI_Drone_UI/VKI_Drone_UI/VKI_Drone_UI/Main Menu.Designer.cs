namespace VKI_Drone_UI
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
            this.Order = new System.Windows.Forms.Button();
            this.CheckDrone = new System.Windows.Forms.Button();
            this.DeviceControl = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Order
            // 
            this.Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order.Font = new System.Drawing.Font("Space Age Cyrillic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.Location = new System.Drawing.Point(528, 12);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(244, 87);
            this.Order.TabIndex = 1;
            this.Order.Text = "Вызвать дрон";
            this.Order.UseVisualStyleBackColor = true;
            // 
            // CheckDrone
            // 
            this.CheckDrone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckDrone.Font = new System.Drawing.Font("Space Age Cyrillic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckDrone.Location = new System.Drawing.Point(528, 105);
            this.CheckDrone.Name = "CheckDrone";
            this.CheckDrone.Size = new System.Drawing.Size(244, 87);
            this.CheckDrone.TabIndex = 2;
            this.CheckDrone.Text = "Проверить статус дрона";
            this.CheckDrone.UseVisualStyleBackColor = true;
            this.CheckDrone.Click += new System.EventHandler(this.CheckDrone_Click);
            // 
            // DeviceControl
            // 
            this.DeviceControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeviceControl.Font = new System.Drawing.Font("Space Age Cyrillic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceControl.Location = new System.Drawing.Point(528, 228);
            this.DeviceControl.Name = "DeviceControl";
            this.DeviceControl.Size = new System.Drawing.Size(244, 76);
            this.DeviceControl.TabIndex = 3;
            this.DeviceControl.Text = "Управление устройствами";
            this.DeviceControl.UseVisualStyleBackColor = true;
            this.DeviceControl.Click += new System.EventHandler(this.DeviceControl_Click);
            // 
            // Logo
            // 
            this.Logo.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::VKI_Drone_UI.Properties.Resources.drone_PNG116;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.InitialImage = global::VKI_Drone_UI.Properties.Resources.drone_PNG116;
            this.Logo.Location = new System.Drawing.Point(30, 250);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 200);
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            this.Logo.WaitOnLoad = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.DeviceControl);
            this.Controls.Add(this.CheckDrone);
            this.Controls.Add(this.Order);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button CheckDrone;
        private System.Windows.Forms.Button DeviceControl;
        private System.Windows.Forms.PictureBox Logo;
    }
}

