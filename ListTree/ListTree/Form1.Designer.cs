
namespace ListTree
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNode = new System.Windows.Forms.Button();
            this.DeleteNode = new System.Windows.Forms.Button();
            this.FindNode = new System.Windows.Forms.Button();
            this.textBoxNode = new System.Windows.Forms.TextBox();
            this.ViewTree = new System.Windows.Forms.RichTextBox();
            this.CleanTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNode
            // 
            this.AddNode.Location = new System.Drawing.Point(39, 73);
            this.AddNode.Name = "AddNode";
            this.AddNode.Size = new System.Drawing.Size(127, 50);
            this.AddNode.TabIndex = 0;
            this.AddNode.Text = "Add";
            this.AddNode.UseVisualStyleBackColor = true;
            this.AddNode.Click += new System.EventHandler(this.AddNode_Click);
            // 
            // DeleteNode
            // 
            this.DeleteNode.Location = new System.Drawing.Point(39, 129);
            this.DeleteNode.Name = "DeleteNode";
            this.DeleteNode.Size = new System.Drawing.Size(127, 50);
            this.DeleteNode.TabIndex = 1;
            this.DeleteNode.Text = "Delete";
            this.DeleteNode.UseVisualStyleBackColor = true;
            this.DeleteNode.Click += new System.EventHandler(this.DeleteNode_Click);
            // 
            // FindNode
            // 
            this.FindNode.Location = new System.Drawing.Point(39, 185);
            this.FindNode.Name = "FindNode";
            this.FindNode.Size = new System.Drawing.Size(127, 50);
            this.FindNode.TabIndex = 2;
            this.FindNode.Text = "Find";
            this.FindNode.UseVisualStyleBackColor = true;
            this.FindNode.Click += new System.EventHandler(this.FindNode_Click);
            // 
            // textBoxNode
            // 
            this.textBoxNode.Location = new System.Drawing.Point(39, 22);
            this.textBoxNode.Name = "textBoxNode";
            this.textBoxNode.Size = new System.Drawing.Size(127, 22);
            this.textBoxNode.TabIndex = 3;
            // 
            // ViewTree
            // 
            this.ViewTree.Location = new System.Drawing.Point(219, 22);
            this.ViewTree.Name = "ViewTree";
            this.ViewTree.Size = new System.Drawing.Size(418, 269);
            this.ViewTree.TabIndex = 4;
            this.ViewTree.Text = "";
            // 
            // CleanTree
            // 
            this.CleanTree.Location = new System.Drawing.Point(39, 241);
            this.CleanTree.Name = "CleanTree";
            this.CleanTree.Size = new System.Drawing.Size(127, 50);
            this.CleanTree.TabIndex = 5;
            this.CleanTree.Text = "Clean";
            this.CleanTree.UseVisualStyleBackColor = true;
            this.CleanTree.Click += new System.EventHandler(this.CleanTree_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 346);
            this.Controls.Add(this.CleanTree);
            this.Controls.Add(this.ViewTree);
            this.Controls.Add(this.textBoxNode);
            this.Controls.Add(this.FindNode);
            this.Controls.Add(this.DeleteNode);
            this.Controls.Add(this.AddNode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNode;
        private System.Windows.Forms.Button DeleteNode;
        private System.Windows.Forms.Button FindNode;
        private System.Windows.Forms.TextBox textBoxNode;
        private System.Windows.Forms.RichTextBox ViewTree;
        private System.Windows.Forms.Button CleanTree;
    }
}

