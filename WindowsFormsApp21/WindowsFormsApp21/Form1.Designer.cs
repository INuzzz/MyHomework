namespace WindowsFormsApp21
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
            this.ItemValue = new System.Windows.Forms.TextBox();
            this.Prepend = new System.Windows.Forms.Button();
            this.Qppend = new System.Windows.Forms.Button();
            this.RemoveAt = new System.Windows.Forms.Button();
            this.ItemAt = new System.Windows.Forms.Button();
            this.ViewMyList = new System.Windows.Forms.RichTextBox();
            this.ClearnButton = new System.Windows.Forms.Button();
            this.Index = new System.Windows.Forms.TextBox();
            this.Sort = new System.Windows.Forms.Button();
            this.ViewSortMyList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ItemValue
            // 
            this.ItemValue.Location = new System.Drawing.Point(58, 29);
            this.ItemValue.Name = "ItemValue";
            this.ItemValue.Size = new System.Drawing.Size(105, 22);
            this.ItemValue.TabIndex = 0;
            this.ItemValue.Text = "Value";
            // 
            // Prepend
            // 
            this.Prepend.Location = new System.Drawing.Point(58, 106);
            this.Prepend.Name = "Prepend";
            this.Prepend.Size = new System.Drawing.Size(105, 40);
            this.Prepend.TabIndex = 1;
            this.Prepend.Text = "Prepend";
            this.Prepend.UseVisualStyleBackColor = true;
            this.Prepend.Click += new System.EventHandler(this.Prepend_Click);
            // 
            // Qppend
            // 
            this.Qppend.Location = new System.Drawing.Point(58, 152);
            this.Qppend.Name = "Qppend";
            this.Qppend.Size = new System.Drawing.Size(105, 40);
            this.Qppend.TabIndex = 2;
            this.Qppend.Text = "Qppend";
            this.Qppend.UseVisualStyleBackColor = true;
            this.Qppend.Click += new System.EventHandler(this.Qppend_Click);
            // 
            // RemoveAt
            // 
            this.RemoveAt.Location = new System.Drawing.Point(58, 198);
            this.RemoveAt.Name = "RemoveAt";
            this.RemoveAt.Size = new System.Drawing.Size(105, 40);
            this.RemoveAt.TabIndex = 3;
            this.RemoveAt.Text = "Remove At";
            this.RemoveAt.UseVisualStyleBackColor = true;
            this.RemoveAt.Click += new System.EventHandler(this.RemoveAt_Click);
            // 
            // ItemAt
            // 
            this.ItemAt.Location = new System.Drawing.Point(58, 244);
            this.ItemAt.Name = "ItemAt";
            this.ItemAt.Size = new System.Drawing.Size(105, 40);
            this.ItemAt.TabIndex = 4;
            this.ItemAt.Text = "Item At";
            this.ItemAt.UseVisualStyleBackColor = true;
            this.ItemAt.Click += new System.EventHandler(this.ItemAt_Click);
            // 
            // ViewMyList
            // 
            this.ViewMyList.Location = new System.Drawing.Point(211, 29);
            this.ViewMyList.Name = "ViewMyList";
            this.ViewMyList.Size = new System.Drawing.Size(177, 301);
            this.ViewMyList.TabIndex = 5;
            this.ViewMyList.Text = "";
            // 
            // ClearnButton
            // 
            this.ClearnButton.Location = new System.Drawing.Point(58, 357);
            this.ClearnButton.Name = "ClearnButton";
            this.ClearnButton.Size = new System.Drawing.Size(105, 40);
            this.ClearnButton.TabIndex = 6;
            this.ClearnButton.Text = "Clearn";
            this.ClearnButton.UseVisualStyleBackColor = true;
            this.ClearnButton.Click += new System.EventHandler(this.ClearnButton_Click);
            // 
            // Index
            // 
            this.Index.Location = new System.Drawing.Point(58, 57);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(105, 22);
            this.Index.TabIndex = 7;
            this.Index.Text = "Index";
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(58, 290);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(105, 40);
            this.Sort.TabIndex = 8;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // ViewSortMyList
            // 
            this.ViewSortMyList.Location = new System.Drawing.Point(434, 29);
            this.ViewSortMyList.Name = "ViewSortMyList";
            this.ViewSortMyList.Size = new System.Drawing.Size(177, 301);
            this.ViewSortMyList.TabIndex = 9;
            this.ViewSortMyList.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewSortMyList);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.ClearnButton);
            this.Controls.Add(this.ViewMyList);
            this.Controls.Add(this.ItemAt);
            this.Controls.Add(this.RemoveAt);
            this.Controls.Add(this.Qppend);
            this.Controls.Add(this.Prepend);
            this.Controls.Add(this.ItemValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemValue;
        private System.Windows.Forms.Button Prepend;
        private System.Windows.Forms.Button Qppend;
        private System.Windows.Forms.Button RemoveAt;
        private System.Windows.Forms.Button ItemAt;
        private System.Windows.Forms.RichTextBox ViewMyList;
        private System.Windows.Forms.Button ClearnButton;
        private System.Windows.Forms.TextBox Index;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.RichTextBox ViewSortMyList;
    }
}

