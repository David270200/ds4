namespace Laboratorio11
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
            btnClickthis = new Button();
            lblHelloWorld = new Label();
            SuspendLayout();
            // 
            // btnClickthis
            // 
            btnClickthis.Location = new Point(158, 91);
            btnClickthis.Name = "btnClickthis";
            btnClickthis.Size = new Size(75, 23);
            btnClickthis.TabIndex = 0;
            btnClickthis.Text = "Click this";
            btnClickthis.UseVisualStyleBackColor = true;
            btnClickthis.Click += btnClickthis_Click;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Location = new Point(158, 130);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(0, 15);
            lblHelloWorld.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHelloWorld);
            Controls.Add(btnClickthis);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickthis;
        private Label lblHelloWorld;
    }
}
