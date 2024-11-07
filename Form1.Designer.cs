namespace formsimthe
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
            Bangsim = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Bangsim).BeginInit();
            SuspendLayout();
            // 
            // Bangsim
            // 
            Bangsim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Bangsim.Location = new Point(179, 101);
            Bangsim.Name = "Bangsim";
            Bangsim.RowHeadersWidth = 51;
            Bangsim.Size = new Size(734, 284);
            Bangsim.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(424, 36);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 1;
            label1.Text = "Bảng thông tin sim";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 565);
            Controls.Add(label1);
            Controls.Add(Bangsim);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Bangsim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Bangsim;
        private Label label1;
    }
}
