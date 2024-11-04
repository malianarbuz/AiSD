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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.AddElement = new System.Windows.Forms.Button();
            this.InputNumber = new System.Windows.Forms.MaskedTextBox();
            this.RemoveElement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(337, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(451, 426);
            this.treeView1.TabIndex = 0;
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
            // RemoveElement
            // 
            this.RemoveElement.Location = new System.Drawing.Point(88, 261);
            this.RemoveElement.Name = "RemoveElement";
            this.RemoveElement.Size = new System.Drawing.Size(100, 44);
            this.RemoveElement.TabIndex = 3;
            this.RemoveElement.Text = "Usuń Element";
            this.RemoveElement.UseVisualStyleBackColor = true;
            this.RemoveElement.Click += new System.EventHandler(this.RemoveElement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveElement);
            this.Controls.Add(this.InputNumber);
            this.Controls.Add(this.AddElement);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button AddElement;
        private System.Windows.Forms.MaskedTextBox InputNumber;
        private System.Windows.Forms.Button RemoveElement;
    }
}

