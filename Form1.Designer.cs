namespace CalculadoraBasica
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
            Screen = new Label();
            ClearB = new Button();
            resultButtom = new Button();
            SuspendLayout();
            // 
            // Screen
            // 
            Screen.BackColor = SystemColors.ActiveCaption;
            Screen.Location = new Point(0, 0);
            Screen.Name = "Screen";
            Screen.Size = new Size(380, 110);
            Screen.TabIndex = 0;
            Screen.Text = "label1";
            Screen.TextAlign = ContentAlignment.TopRight;
            // 
            // ClearB
            // 
            ClearB.Location = new Point(0, 110);
            ClearB.Name = "ClearB";
            ClearB.Size = new Size(198, 82);
            ClearB.TabIndex = 1;
            ClearB.Text = "Clear";
            ClearB.UseVisualStyleBackColor = true;
            // 
            // resultButtom
            // 
            resultButtom.Location = new Point(293, 413);
            resultButtom.Name = "resultButtom";
            resultButtom.Size = new Size(87, 69);
            resultButtom.TabIndex = 2;
            resultButtom.Text = "Result";
            resultButtom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 481);
            Controls.Add(resultButtom);
            Controls.Add(ClearB);
            Controls.Add(Screen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            ResumeLayout(false);
        }

        #endregion

        private Label Screen;
        private Button ClearB;
        private Button resultButtom;
    }
}