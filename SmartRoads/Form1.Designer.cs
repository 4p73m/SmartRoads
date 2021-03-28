
namespace SmartRoads
{
    partial class MainWindow
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelSpeedLimit = new System.Windows.Forms.Label();
            this.textBoxSpeedLimit = new System.Windows.Forms.TextBox();
            this.textBoxSensorNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(238, 111);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(69, 28);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(19, 119);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(110, 13);
            this.labelSpeed.TabIndex = 1;
            this.labelSpeed.Text = "RecommendedSpeed";
            // 
            // labelSpeedLimit
            // 
            this.labelSpeedLimit.AutoSize = true;
            this.labelSpeedLimit.Location = new System.Drawing.Point(19, 35);
            this.labelSpeedLimit.Name = "labelSpeedLimit";
            this.labelSpeedLimit.Size = new System.Drawing.Size(118, 13);
            this.labelSpeedLimit.TabIndex = 2;
            this.labelSpeedLimit.Text = "Speed limit on the road ";
            // 
            // textBoxSpeedLimit
            // 
            this.textBoxSpeedLimit.Location = new System.Drawing.Point(149, 32);
            this.textBoxSpeedLimit.Name = "textBoxSpeedLimit";
            this.textBoxSpeedLimit.Size = new System.Drawing.Size(141, 20);
            this.textBoxSpeedLimit.TabIndex = 3;
            this.textBoxSpeedLimit.Text = "60";
            // 
            // textBoxSensorNumber
            // 
            this.textBoxSensorNumber.Location = new System.Drawing.Point(149, 6);
            this.textBoxSensorNumber.Name = "textBoxSensorNumber";
            this.textBoxSensorNumber.Size = new System.Drawing.Size(141, 20);
            this.textBoxSensorNumber.TabIndex = 5;
            this.textBoxSensorNumber.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sensor number ";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(22, 75);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(268, 20);
            this.textBoxFile.TabIndex = 7;
            this.textBoxFile.Text = "C:\\Users\\Admin\\Desktop\\smart_road_measurements.csv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "The path to the file";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 151);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSensorNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSpeedLimit);
            this.Controls.Add(this.labelSpeedLimit);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.buttonRefresh);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelSpeedLimit;
        private System.Windows.Forms.TextBox textBoxSpeedLimit;
        private System.Windows.Forms.TextBox textBoxSensorNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label label2;
    }
}

