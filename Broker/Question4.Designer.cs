namespace Broker
{
    partial class Question4
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
            this.heading = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.feature = new System.Windows.Forms.Label();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heading.Location = new System.Drawing.Point(158, 61);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(276, 20);
            this.heading.TabIndex = 0;
            this.heading.Text = "Отметьте, важна ли для Вас данная услуга";
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(142, 236);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 23);
            this.yesButton.TabIndex = 7;
            this.yesButton.Text = "Да";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // feature
            // 
            this.feature.AutoSize = true;
            this.feature.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feature.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feature.Location = new System.Drawing.Point(181, 149);
            this.feature.Name = "feature";
            this.feature.Size = new System.Drawing.Size(217, 20);
            this.feature.TabIndex = 12;
            this.feature.Text = "Мне важно наличие офиса в городе";
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(359, 236);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 23);
            this.noButton.TabIndex = 13;
            this.noButton.Text = "Нет";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // Question4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 376);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.feature);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.heading);
            this.Name = "Question4";
            this.Text = "BrokerDBO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Label feature;
        private System.Windows.Forms.Button noButton;
    }
}