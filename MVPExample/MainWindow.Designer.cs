namespace MVPExample
{
    partial class MainWindow
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
            this.FlightsGridView = new System.Windows.Forms.DataGridView();
            this.PopulateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FlightsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightsGridView
            // 
            this.FlightsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightsGridView.Location = new System.Drawing.Point(12, 12);
            this.FlightsGridView.Name = "FlightsGridView";
            this.FlightsGridView.Size = new System.Drawing.Size(636, 344);
            this.FlightsGridView.TabIndex = 0;
            // 
            // PopulateButton
            // 
            this.PopulateButton.Location = new System.Drawing.Point(12, 362);
            this.PopulateButton.Name = "PopulateButton";
            this.PopulateButton.Size = new System.Drawing.Size(75, 30);
            this.PopulateButton.TabIndex = 1;
            this.PopulateButton.Text = "Populate";
            this.PopulateButton.UseVisualStyleBackColor = true;
            this.PopulateButton.Click += new System.EventHandler(this.PopulateButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PopulateButton);
            this.Controls.Add(this.FlightsGridView);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FlightsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FlightsGridView;
        private System.Windows.Forms.Button PopulateButton;
        private System.Windows.Forms.Button button1;
    }
}

