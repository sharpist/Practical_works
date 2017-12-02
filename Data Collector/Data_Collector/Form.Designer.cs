namespace Data_Collector
{
    partial class Form
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
            this.goWalker_button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.useFilter_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goWalker_button
            // 
            this.goWalker_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goWalker_button.Location = new System.Drawing.Point(481, 476);
            this.goWalker_button.Name = "goWalker_button";
            this.goWalker_button.Size = new System.Drawing.Size(86, 36);
            this.goWalker_button.TabIndex = 0;
            this.goWalker_button.Text = "Get";
            this.goWalker_button.UseVisualStyleBackColor = true;
            this.goWalker_button.Click += new System.EventHandler(this.goWalker_button_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(12, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 20);
            this.label.TabIndex = 1;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(5, 59);
            this.textBox.MaximumSize = new System.Drawing.Size(570, 400);
            this.textBox.MinimumSize = new System.Drawing.Size(570, 400);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(570, 400);
            this.textBox.TabIndex = 2;
            // 
            // useFilter_button
            // 
            this.useFilter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useFilter_button.Location = new System.Drawing.Point(369, 476);
            this.useFilter_button.Name = "useFilter_button";
            this.useFilter_button.Size = new System.Drawing.Size(86, 36);
            this.useFilter_button.TabIndex = 3;
            this.useFilter_button.Text = "Filter";
            this.useFilter_button.UseVisualStyleBackColor = true;
            this.useFilter_button.Click += new System.EventHandler(this.useFilter_button_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 561);
            this.Controls.Add(this.useFilter_button);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.goWalker_button);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Data Collector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goWalker_button;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button useFilter_button;
    }
}

