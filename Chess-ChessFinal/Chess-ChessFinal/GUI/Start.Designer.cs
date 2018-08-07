namespace Chess.GUI
{
    partial class Start
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
            this.gboxRules = new System.Windows.Forms.GroupBox();
            this.rbtnSandardChess = new System.Windows.Forms.RadioButton();
            this.rbtnChess960 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gboxRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rules";
            // 
            // gboxRules
            // 
            this.gboxRules.Controls.Add(this.rbtnChess960);
            this.gboxRules.Controls.Add(this.rbtnSandardChess);
            this.gboxRules.Location = new System.Drawing.Point(133, 76);
            this.gboxRules.Name = "gboxRules";
            this.gboxRules.Size = new System.Drawing.Size(200, 100);
            this.gboxRules.TabIndex = 3;
            this.gboxRules.TabStop = false;
            // 
            // rbtnSandardChess
            // 
            this.rbtnSandardChess.AutoSize = true;
            this.rbtnSandardChess.Checked = true;
            this.rbtnSandardChess.Location = new System.Drawing.Point(7, 8);
            this.rbtnSandardChess.Name = "rbtnSandardChess";
            this.rbtnSandardChess.Size = new System.Drawing.Size(197, 29);
            this.rbtnSandardChess.TabIndex = 0;
            this.rbtnSandardChess.TabStop = true;
            this.rbtnSandardChess.Text = "Standard Chess";
            this.rbtnSandardChess.UseVisualStyleBackColor = true;
            // 
            // rbtnChess960
            // 
            this.rbtnChess960.AutoSize = true;
            this.rbtnChess960.Location = new System.Drawing.Point(7, 43);
            this.rbtnChess960.Name = "rbtnChess960";
            this.rbtnChess960.Size = new System.Drawing.Size(146, 29);
            this.rbtnChess960.TabIndex = 1;
            this.rbtnChess960.Text = "Chess 960";
            this.rbtnChess960.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(133, 183);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(204, 44);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gboxRules);
            this.Controls.Add(this.label1);
            this.Name = "Start";
            this.Text = "Start";
            this.gboxRules.ResumeLayout(false);
            this.gboxRules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxRules;
        private System.Windows.Forms.RadioButton rbtnChess960;
        private System.Windows.Forms.RadioButton rbtnSandardChess;
        private System.Windows.Forms.Button btnSubmit;
    }
}