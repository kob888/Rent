namespace PaymentForAnApartment
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
            this.hotWaterConst = new System.Windows.Forms.Label();
            this.coldWaterLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hotWaterInvoiceSum = new System.Windows.Forms.TextBox();
            this.coldWaterInvoiceSum = new System.Windows.Forms.TextBox();
            this.totalInvoiceSum = new System.Windows.Forms.TextBox();
            this.changeValueCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.coldWaterIndicator = new System.Windows.Forms.TextBox();
            this.hotWaterIndicator = new System.Windows.Forms.TextBox();
            this.lastHotWaterIndicator = new System.Windows.Forms.TextBox();
            this.lastColdWaterIndicator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.totalSumForWater = new System.Windows.Forms.Label();
            this.drainageTotal = new System.Windows.Forms.Label();
            this.hotWaterTotal = new System.Windows.Forms.Label();
            this.coldWaterTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalPayment = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.numberOfMonth = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // hotWaterConst
            // 
            this.hotWaterConst.AutoSize = true;
            this.hotWaterConst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotWaterConst.Location = new System.Drawing.Point(11, 51);
            this.hotWaterConst.Name = "hotWaterConst";
            this.hotWaterConst.Size = new System.Drawing.Size(99, 17);
            this.hotWaterConst.TabIndex = 1;
            this.hotWaterConst.Text = "Горячая вода";
            // 
            // coldWaterLabel
            // 
            this.coldWaterLabel.AutoSize = true;
            this.coldWaterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coldWaterLabel.Location = new System.Drawing.Point(11, 85);
            this.coldWaterLabel.Name = "coldWaterLabel";
            this.coldWaterLabel.Size = new System.Drawing.Size(108, 17);
            this.coldWaterLabel.TabIndex = 2;
            this.coldWaterLabel.Text = "Холодная вода";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(306, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Всего к оплате:";
            // 
            // hotWaterInvoiceSum
            // 
            this.hotWaterInvoiceSum.Enabled = false;
            this.hotWaterInvoiceSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotWaterInvoiceSum.Location = new System.Drawing.Point(129, 47);
            this.hotWaterInvoiceSum.Name = "hotWaterInvoiceSum";
            this.hotWaterInvoiceSum.Size = new System.Drawing.Size(118, 24);
            this.hotWaterInvoiceSum.TabIndex = 4;
            // 
            // coldWaterInvoiceSum
            // 
            this.coldWaterInvoiceSum.Enabled = false;
            this.coldWaterInvoiceSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coldWaterInvoiceSum.Location = new System.Drawing.Point(129, 85);
            this.coldWaterInvoiceSum.Name = "coldWaterInvoiceSum";
            this.coldWaterInvoiceSum.Size = new System.Drawing.Size(118, 24);
            this.coldWaterInvoiceSum.TabIndex = 5;
            // 
            // totalInvoiceSum
            // 
            this.totalInvoiceSum.Enabled = false;
            this.totalInvoiceSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalInvoiceSum.Location = new System.Drawing.Point(438, 85);
            this.totalInvoiceSum.Name = "totalInvoiceSum";
            this.totalInvoiceSum.Size = new System.Drawing.Size(141, 24);
            this.totalInvoiceSum.TabIndex = 6;
            // 
            // changeValueCheckBox
            // 
            this.changeValueCheckBox.AutoSize = true;
            this.changeValueCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeValueCheckBox.Location = new System.Drawing.Point(358, 28);
            this.changeValueCheckBox.Name = "changeValueCheckBox";
            this.changeValueCheckBox.Size = new System.Drawing.Size(221, 19);
            this.changeValueCheckBox.TabIndex = 7;
            this.changeValueCheckBox.Text = "Изменить показатели квитанции";
            this.changeValueCheckBox.UseVisualStyleBackColor = true;
            this.changeValueCheckBox.CheckedChanged += new System.EventHandler(this.changeValueCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hotWaterConst);
            this.groupBox1.Controls.Add(this.changeValueCheckBox);
            this.groupBox1.Controls.Add(this.hotWaterInvoiceSum);
            this.groupBox1.Controls.Add(this.totalInvoiceSum);
            this.groupBox1.Controls.Add(this.coldWaterLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.coldWaterInvoiceSum);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 131);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Квитанция";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.coldWaterIndicator);
            this.groupBox2.Controls.Add(this.hotWaterIndicator);
            this.groupBox2.Controls.Add(this.lastHotWaterIndicator);
            this.groupBox2.Controls.Add(this.lastColdWaterIndicator);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 126);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод показателей";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(339, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Стало:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(16, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Стало:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(339, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Было:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Было:";
            // 
            // coldWaterIndicator
            // 
            this.coldWaterIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coldWaterIndicator.Location = new System.Drawing.Point(68, 93);
            this.coldWaterIndicator.Name = "coldWaterIndicator";
            this.coldWaterIndicator.Size = new System.Drawing.Size(155, 23);
            this.coldWaterIndicator.TabIndex = 5;
            this.coldWaterIndicator.Text = "0";
            // 
            // hotWaterIndicator
            // 
            this.hotWaterIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotWaterIndicator.Location = new System.Drawing.Point(391, 93);
            this.hotWaterIndicator.Name = "hotWaterIndicator";
            this.hotWaterIndicator.Size = new System.Drawing.Size(155, 23);
            this.hotWaterIndicator.TabIndex = 4;
            this.hotWaterIndicator.Text = "0";
            // 
            // lastHotWaterIndicator
            // 
            this.lastHotWaterIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastHotWaterIndicator.Location = new System.Drawing.Point(391, 64);
            this.lastHotWaterIndicator.Name = "lastHotWaterIndicator";
            this.lastHotWaterIndicator.Size = new System.Drawing.Size(155, 23);
            this.lastHotWaterIndicator.TabIndex = 3;
            this.lastHotWaterIndicator.Text = "0";
            // 
            // lastColdWaterIndicator
            // 
            this.lastColdWaterIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastColdWaterIndicator.Location = new System.Drawing.Point(68, 64);
            this.lastColdWaterIndicator.Name = "lastColdWaterIndicator";
            this.lastColdWaterIndicator.Size = new System.Drawing.Size(155, 23);
            this.lastColdWaterIndicator.TabIndex = 2;
            this.lastColdWaterIndicator.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(355, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Показатели горячей воды";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Показатели холодной воды";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totalSumForWater);
            this.groupBox3.Controls.Add(this.drainageTotal);
            this.groupBox3.Controls.Add(this.hotWaterTotal);
            this.groupBox3.Controls.Add(this.coldWaterTotal);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(597, 147);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод";
            // 
            // totalSumForWater
            // 
            this.totalSumForWater.AutoSize = true;
            this.totalSumForWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalSumForWater.Location = new System.Drawing.Point(296, 110);
            this.totalSumForWater.Name = "totalSumForWater";
            this.totalSumForWater.Size = new System.Drawing.Size(0, 24);
            this.totalSumForWater.TabIndex = 7;
            // 
            // drainageTotal
            // 
            this.drainageTotal.AutoSize = true;
            this.drainageTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drainageTotal.Location = new System.Drawing.Point(486, 39);
            this.drainageTotal.Name = "drainageTotal";
            this.drainageTotal.Size = new System.Drawing.Size(0, 18);
            this.drainageTotal.TabIndex = 6;
            // 
            // hotWaterTotal
            // 
            this.hotWaterTotal.AutoSize = true;
            this.hotWaterTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotWaterTotal.Location = new System.Drawing.Point(191, 72);
            this.hotWaterTotal.Name = "hotWaterTotal";
            this.hotWaterTotal.Size = new System.Drawing.Size(0, 18);
            this.hotWaterTotal.TabIndex = 5;
            // 
            // coldWaterTotal
            // 
            this.coldWaterTotal.AutoSize = true;
            this.coldWaterTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coldWaterTotal.Location = new System.Drawing.Point(191, 39);
            this.coldWaterTotal.Name = "coldWaterTotal";
            this.coldWaterTotal.Size = new System.Drawing.Size(0, 18);
            this.coldWaterTotal.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Итого за воду:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(334, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Сумма за водоотвод:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Сумма за горячую воду:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Сумма за холодную воду:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(192, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Итого к оплате за месяц:";
            // 
            // totalPayment
            // 
            this.totalPayment.AutoSize = true;
            this.totalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPayment.Location = new System.Drawing.Point(467, 518);
            this.totalPayment.Name = "totalPayment";
            this.totalPayment.Size = new System.Drawing.Size(21, 24);
            this.totalPayment.TabIndex = 12;
            this.totalPayment.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(12, 510);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(139, 40);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(28, 464);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(247, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Количество месяцев в расчете";
            // 
            // numberOfMonth
            // 
            this.numberOfMonth.Location = new System.Drawing.Point(301, 464);
            this.numberOfMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numberOfMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfMonth.Name = "numberOfMonth";
            this.numberOfMonth.Size = new System.Drawing.Size(120, 20);
            this.numberOfMonth.TabIndex = 15;
            this.numberOfMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 562);
            this.Controls.Add(this.numberOfMonth);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalPayment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hotWaterConst;
        private System.Windows.Forms.Label coldWaterLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hotWaterInvoiceSum;
        private System.Windows.Forms.TextBox coldWaterInvoiceSum;
        private System.Windows.Forms.TextBox totalInvoiceSum;
        private System.Windows.Forms.CheckBox changeValueCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lastHotWaterIndicator;
        private System.Windows.Forms.TextBox lastColdWaterIndicator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label totalSumForWater;
        private System.Windows.Forms.Label drainageTotal;
        private System.Windows.Forms.Label hotWaterTotal;
        private System.Windows.Forms.Label coldWaterTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalPayment;
        private System.Windows.Forms.TextBox hotWaterIndicator;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox coldWaterIndicator;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numberOfMonth;
    }
}

