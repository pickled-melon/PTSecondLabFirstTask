namespace PTSecondLabFirstTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            arriveTimePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            departureTimePicker = new DateTimePicker();
            passengerTimePicker = new DateTimePicker();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // arriveTimePicker
            // 
            arriveTimePicker.CustomFormat = "HH:mm";
            arriveTimePicker.Format = DateTimePickerFormat.Custom;
            arriveTimePicker.Location = new Point(226, 12);
            arriveTimePicker.Name = "arriveTimePicker";
            arriveTimePicker.ShowUpDown = true;
            arriveTimePicker.Size = new Size(70, 27);
            arriveTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 1;
            label1.Text = "Время прибытия поезда";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(202, 20);
            label2.TabIndex = 2;
            label2.Text = "Время отправления поезда";
            // 
            // departureTimePicker
            // 
            departureTimePicker.Checked = false;
            departureTimePicker.Cursor = Cursors.Cross;
            departureTimePicker.CustomFormat = "HH:mm";
            departureTimePicker.Format = DateTimePickerFormat.Custom;
            departureTimePicker.Location = new Point(226, 55);
            departureTimePicker.Name = "departureTimePicker";
            departureTimePicker.ShowUpDown = true;
            departureTimePicker.Size = new Size(70, 27);
            departureTimePicker.TabIndex = 3;
            // 
            // passengerTimePicker
            // 
            passengerTimePicker.CustomFormat = "HH:mm";
            passengerTimePicker.Format = DateTimePickerFormat.Custom;
            passengerTimePicker.Location = new Point(226, 101);
            passengerTimePicker.Name = "passengerTimePicker";
            passengerTimePicker.ShowUpDown = true;
            passengerTimePicker.Size = new Size(70, 27);
            passengerTimePicker.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(208, 20);
            label3.TabIndex = 5;
            label3.Text = "Время прибытия пассажира";
            // 
            // button1
            // 
            button1.Location = new Point(105, 146);
            button1.Name = "button1";
            button1.Size = new Size(191, 29);
            button1.TabIndex = 6;
            button1.Text = "Узнать наличие поезда";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 181);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(passengerTimePicker);
            Controls.Add(departureTimePicker);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(arriveTimePicker);
            Name = "Form1";
            Text = "Цифровой перрон";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker arriveTimePicker;
        private Label label1;
        private Label label2;
        private DateTimePicker departureTimePicker;
        private DateTimePicker passengerTimePicker;
        private Label label3;
        private Button button1;
    }
}
