
namespace HashTable
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
            this.N_Value = new System.Windows.Forms.TextBox();
            this.IntKey = new System.Windows.Forms.RadioButton();
            this.StringKey = new System.Windows.Forms.RadioButton();
            this.Add_button = new System.Windows.Forms.Button();
            this.ViewTable = new System.Windows.Forms.RichTextBox();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.KeyValue = new System.Windows.Forms.TextBox();
            this.Create_button = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // N_Value
            // 
            this.N_Value.Location = new System.Drawing.Point(31, 35);
            this.N_Value.Name = "N_Value";
            this.N_Value.Size = new System.Drawing.Size(138, 22);
            this.N_Value.TabIndex = 0;
            this.N_Value.Text = "n value";
            // 
            // IntKey
            // 
            this.IntKey.AutoSize = true;
            this.IntKey.Checked = true;
            this.IntKey.Location = new System.Drawing.Point(31, 115);
            this.IntKey.Name = "IntKey";
            this.IntKey.Size = new System.Drawing.Size(99, 21);
            this.IntKey.TabIndex = 1;
            this.IntKey.TabStop = true;
            this.IntKey.Text = "Integer key";
            this.IntKey.UseVisualStyleBackColor = true;
            // 
            // StringKey
            // 
            this.StringKey.AutoSize = true;
            this.StringKey.Location = new System.Drawing.Point(31, 155);
            this.StringKey.Name = "StringKey";
            this.StringKey.Size = new System.Drawing.Size(92, 21);
            this.StringKey.TabIndex = 2;
            this.StringKey.TabStop = true;
            this.StringKey.Text = "String key";
            this.StringKey.UseVisualStyleBackColor = true;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(231, 203);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(138, 40);
            this.Add_button.TabIndex = 3;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // ViewTable
            // 
            this.ViewTable.Location = new System.Drawing.Point(443, 35);
            this.ViewTable.Name = "ViewTable";
            this.ViewTable.Size = new System.Drawing.Size(450, 384);
            this.ViewTable.TabIndex = 6;
            this.ViewTable.Text = "";
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(231, 266);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(138, 40);
            this.Delete_button.TabIndex = 7;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(231, 379);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(138, 40);
            this.Clear_button.TabIndex = 8;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // KeyValue
            // 
            this.KeyValue.Location = new System.Drawing.Point(31, 235);
            this.KeyValue.Name = "KeyValue";
            this.KeyValue.Size = new System.Drawing.Size(138, 22);
            this.KeyValue.TabIndex = 9;
            this.KeyValue.Text = "key";
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(231, 35);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(138, 40);
            this.Create_button.TabIndex = 10;
            this.Create_button.Text = "Create table";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(31, 263);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(138, 22);
            this.Value.TabIndex = 11;
            this.Value.Text = "value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 502);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Create_button);
            this.Controls.Add(this.KeyValue);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.ViewTable);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.StringKey);
            this.Controls.Add(this.IntKey);
            this.Controls.Add(this.N_Value);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox N_Value;
        private System.Windows.Forms.RadioButton IntKey;
        private System.Windows.Forms.RadioButton StringKey;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.RichTextBox ViewTable;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.TextBox KeyValue;
        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.TextBox Value;
    }
}

