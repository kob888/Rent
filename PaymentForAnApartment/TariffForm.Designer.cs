namespace PaymentForAnApartment
{
    partial class TariffForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tariffButton = new System.Windows.Forms.Button();
            this.hotWaterTariff = new System.Windows.Forms.TextBox();
            this.coldWaterTariff = new System.Windows.Forms.TextBox();
            this.drainageTariff = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тариф на воду";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тариф на горячую воду";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тариф на холодную воду";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тариф на водоотвод";
            // 
            // tariffButton
            // 
            this.tariffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tariffButton.Location = new System.Drawing.Point(99, 195);
            this.tariffButton.Name = "tariffButton";
            this.tariffButton.Size = new System.Drawing.Size(130, 40);
            this.tariffButton.TabIndex = 4;
            this.tariffButton.Text = "Сохранить";
            this.tariffButton.UseVisualStyleBackColor = true;
            this.tariffButton.Click += new System.EventHandler(this.tariffButton_Click);
            // 
            // hotWaterTariff
            // 
            this.hotWaterTariff.Location = new System.Drawing.Point(209, 70);
            this.hotWaterTariff.Name = "hotWaterTariff";
            this.hotWaterTariff.Size = new System.Drawing.Size(116, 20);
            this.hotWaterTariff.TabIndex = 5;
            // 
            // coldWaterTariff
            // 
            this.coldWaterTariff.Location = new System.Drawing.Point(209, 112);
            this.coldWaterTariff.Name = "coldWaterTariff";
            this.coldWaterTariff.Size = new System.Drawing.Size(116, 20);
            this.coldWaterTariff.TabIndex = 6;
            // 
            // drainageTariff
            // 
            this.drainageTariff.Location = new System.Drawing.Point(209, 154);
            this.drainageTariff.Name = "drainageTariff";
            this.drainageTariff.Size = new System.Drawing.Size(116, 20);
            this.drainageTariff.TabIndex = 7;
            // 
            // TariffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 259);
            this.Controls.Add(this.drainageTariff);
            this.Controls.Add(this.coldWaterTariff);
            this.Controls.Add(this.hotWaterTariff);
            this.Controls.Add(this.tariffButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TariffForm";
            this.Text = "TariffForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tariffButton;
        private System.Windows.Forms.TextBox hotWaterTariff;
        private System.Windows.Forms.TextBox coldWaterTariff;
        private System.Windows.Forms.TextBox drainageTariff;
    }
}