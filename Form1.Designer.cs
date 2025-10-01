namespace Change_Counter
{
    partial class changeCounterForm
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
            this.fiftyCentsPicture = new System.Windows.Forms.PictureBox();
            this.twentyFivePicture = new System.Windows.Forms.PictureBox();
            this.tenCentsPicture = new System.Windows.Forms.PictureBox();
            this.fiveCentsPicture = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFivePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // fiftyCentsPicture
            // 
            this.fiftyCentsPicture.Image = global::Change_Counter.Properties.Resources._50cents;
            this.fiftyCentsPicture.Location = new System.Drawing.Point(214, 254);
            this.fiftyCentsPicture.Name = "fiftyCentsPicture";
            this.fiftyCentsPicture.Size = new System.Drawing.Size(164, 175);
            this.fiftyCentsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fiftyCentsPicture.TabIndex = 3;
            this.fiftyCentsPicture.TabStop = false;
            this.fiftyCentsPicture.Click += new System.EventHandler(this.fiftyCentsPicture_Click);
            // 
            // twentyFivePicture
            // 
            this.twentyFivePicture.Image = global::Change_Counter.Properties.Resources._25cents;
            this.twentyFivePicture.Location = new System.Drawing.Point(23, 254);
            this.twentyFivePicture.Name = "twentyFivePicture";
            this.twentyFivePicture.Size = new System.Drawing.Size(173, 175);
            this.twentyFivePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.twentyFivePicture.TabIndex = 2;
            this.twentyFivePicture.TabStop = false;
            this.twentyFivePicture.Click += new System.EventHandler(this.twentyFivePicture_Click);
            // 
            // tenCentsPicture
            // 
            this.tenCentsPicture.Image = global::Change_Counter.Properties.Resources._10cents;
            this.tenCentsPicture.Location = new System.Drawing.Point(214, 61);
            this.tenCentsPicture.Name = "tenCentsPicture";
            this.tenCentsPicture.Size = new System.Drawing.Size(164, 175);
            this.tenCentsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tenCentsPicture.TabIndex = 1;
            this.tenCentsPicture.TabStop = false;
            this.tenCentsPicture.Click += new System.EventHandler(this.tenCentsPicture_Click);
            // 
            // fiveCentsPicture
            // 
            this.fiveCentsPicture.Image = global::Change_Counter.Properties.Resources._5cents;
            this.fiveCentsPicture.Location = new System.Drawing.Point(23, 61);
            this.fiveCentsPicture.Name = "fiveCentsPicture";
            this.fiveCentsPicture.Size = new System.Drawing.Size(173, 175);
            this.fiveCentsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fiveCentsPicture.TabIndex = 0;
            this.fiveCentsPicture.TabStop = false;
            this.fiveCentsPicture.Click += new System.EventHandler(this.fiveCentsPicture_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.instructionLabel.Location = new System.Drawing.Point(135, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(168, 29);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Click the coins";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(424, 121);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(68, 29);
            this.outputDescriptionLabel.TabIndex = 5;
            this.outputDescriptionLabel.Text = "Total";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalLabel.Location = new System.Drawing.Point(395, 150);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(127, 34);
            this.totalLabel.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitButton.Location = new System.Drawing.Point(395, 369);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 50);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // changeCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.fiftyCentsPicture);
            this.Controls.Add(this.twentyFivePicture);
            this.Controls.Add(this.tenCentsPicture);
            this.Controls.Add(this.fiveCentsPicture);
            this.Name = "changeCounterForm";
            this.Text = "Change Counter";
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFivePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fiveCentsPicture;
        private System.Windows.Forms.PictureBox tenCentsPicture;
        private System.Windows.Forms.PictureBox twentyFivePicture;
        private System.Windows.Forms.PictureBox fiftyCentsPicture;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

