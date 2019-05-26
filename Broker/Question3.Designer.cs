namespace Broker
{
    partial class Question3
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
            this.feature2 = new System.Windows.Forms.Label();
            this.feature3 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heading.Location = new System.Drawing.Point(161, 33);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(263, 20);
            this.heading.TabIndex = 2;
            this.heading.Text = "Отметьте правдивые о Вас утверждения";
            // 
            // feature2
            // 
            this.feature2.AutoSize = true;
            this.feature2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feature2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feature2.Location = new System.Drawing.Point(25, 133);
            this.feature2.Name = "feature2";
            this.feature2.Size = new System.Drawing.Size(408, 20);
            this.feature2.TabIndex = 4;
            this.feature2.Text = "Я хочу, чтобы чтобы ко мне относились с особой вежливостью";
            // 
            // feature3
            // 
            this.feature3.AutoSize = true;
            this.feature3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feature3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feature3.Location = new System.Drawing.Point(25, 213);
            this.feature3.Name = "feature3";
            this.feature3.Size = new System.Drawing.Size(484, 20);
            this.feature3.TabIndex = 5;
            this.feature3.Text = "Если я встречу холодное отношение, я перестану быть клиентом этой организации";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(246, 313);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Далее";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(532, 138);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(532, 218);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Question3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 376);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.feature3);
            this.Controls.Add(this.feature2);
            this.Controls.Add(this.heading);
            this.Name = "Question3";
            this.Text = "BrokerDBO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label feature2;
        private System.Windows.Forms.Label feature3;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}