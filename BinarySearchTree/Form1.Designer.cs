namespace BinarySearchTree
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView = new System.Windows.Forms.TreeView();
            this.AddElement = new System.Windows.Forms.Button();
            this.InputNumber = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(480, 113);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(144, 123);
            this.treeView.TabIndex = 0;
            // 
            // AddElement
            // 
            this.AddElement.Location = new System.Drawing.Point(88, 211);
            this.AddElement.Name = "AddElement";
            this.AddElement.Size = new System.Drawing.Size(100, 44);
            this.AddElement.TabIndex = 1;
            this.AddElement.Text = "Dodaj Element";
            this.AddElement.UseVisualStyleBackColor = true;
            this.AddElement.Click += new System.EventHandler(this.AddElement_Click);
            // 
            // InputNumber
            // 
            this.InputNumber.Location = new System.Drawing.Point(88, 164);
            this.InputNumber.Mask = "00000";
            this.InputNumber.Name = "InputNumber";
            this.InputNumber.Size = new System.Drawing.Size(100, 20);
            this.InputNumber.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputNumber);
            this.Controls.Add(this.AddElement);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button AddElement;
        private System.Windows.Forms.MaskedTextBox InputNumber;
    }
}

