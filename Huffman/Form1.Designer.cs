namespace Huffman
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
            InputText = new TextBox();
            Tree = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // InputText
            // 
            InputText.Location = new Point(28, 73);
            InputText.Name = "InputText";
            InputText.Size = new Size(318, 23);
            InputText.TabIndex = 0;
            // 
            // Tree
            // 
            Tree.Location = new Point(28, 122);
            Tree.Name = "Tree";
            Tree.Size = new Size(126, 26);
            Tree.TabIndex = 1;
            Tree.Text = "Generuj";
            Tree.UseVisualStyleBackColor = true;
            Tree.Click += Tree_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 2;
            label1.Text = "Wprowadź ciąg znaków:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Tree);
            Controls.Add(InputText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputText;
        private Button Tree;
        private Label label1;
    }
}
