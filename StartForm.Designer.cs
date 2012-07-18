namespace take_a_break
{
    partial class StartForm
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
            this._workTimeSeconds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._breakTimeSeconds = new System.Windows.Forms.NumericUpDown();
            this._breakTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._workTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this._okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._workTimeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._breakTimeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._breakTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._workTimeMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // _workTimeSeconds
            // 
            this._workTimeSeconds.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._workTimeSeconds.Location = new System.Drawing.Point(173, 12);
            this._workTimeSeconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._workTimeSeconds.Name = "_workTimeSeconds";
            this._workTimeSeconds.Size = new System.Drawing.Size(59, 22);
            this._workTimeSeconds.TabIndex = 0;
            this._workTimeSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._workTimeSeconds.ValueChanged += new System.EventHandler(this.UpdateSettings);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Work Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "sec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "sec";
            // 
            // _breakTimeSeconds
            // 
            this._breakTimeSeconds.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._breakTimeSeconds.Location = new System.Drawing.Point(173, 40);
            this._breakTimeSeconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._breakTimeSeconds.Name = "_breakTimeSeconds";
            this._breakTimeSeconds.Size = new System.Drawing.Size(59, 22);
            this._breakTimeSeconds.TabIndex = 4;
            this._breakTimeSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._breakTimeSeconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._breakTimeSeconds.ValueChanged += new System.EventHandler(this.UpdateSettings);
            // 
            // _breakTimeMinutes
            // 
            this._breakTimeMinutes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._breakTimeMinutes.Location = new System.Drawing.Point(76, 40);
            this._breakTimeMinutes.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._breakTimeMinutes.Name = "_breakTimeMinutes";
            this._breakTimeMinutes.Size = new System.Drawing.Size(59, 22);
            this._breakTimeMinutes.TabIndex = 8;
            this._breakTimeMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._breakTimeMinutes.ValueChanged += new System.EventHandler(this.UpdateSettings);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "min";
            // 
            // _workTimeMinutes
            // 
            this._workTimeMinutes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._workTimeMinutes.Location = new System.Drawing.Point(76, 12);
            this._workTimeMinutes.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._workTimeMinutes.Name = "_workTimeMinutes";
            this._workTimeMinutes.Size = new System.Drawing.Size(59, 22);
            this._workTimeMinutes.TabIndex = 5;
            this._workTimeMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._workTimeMinutes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._workTimeMinutes.ValueChanged += new System.EventHandler(this.UpdateSettings);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(8, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Break Time";
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(183, 68);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 10;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 98);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._breakTimeMinutes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._workTimeMinutes);
            this.Controls.Add(this._breakTimeSeconds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._workTimeSeconds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartForm";
            this.Text = "take a break";
            ((System.ComponentModel.ISupportInitialize)(this._workTimeSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._breakTimeSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._breakTimeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._workTimeMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _workTimeSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _breakTimeSeconds;
        private System.Windows.Forms.NumericUpDown _breakTimeMinutes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown _workTimeMinutes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _okButton;
    }
}

