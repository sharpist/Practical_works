namespace cards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.buttonNewSet = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewSet
            // 
            this.buttonNewSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewSet.Location = new System.Drawing.Point(845, 420);
            this.buttonNewSet.Name = "buttonNewSet";
            this.buttonNewSet.Size = new System.Drawing.Size(100, 58);
            this.buttonNewSet.TabIndex = 0;
            this.buttonNewSet.Text = "New Set!";
            this.buttonNewSet.UseVisualStyleBackColor = true;
            this.buttonNewSet.Click += new System.EventHandler(this.buttonNewSet_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label.Location = new System.Drawing.Point(12, 469);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(417, 13);
            this.label.TabIndex = 1;
            this.label.Text = "This program \"Cards\" generates and displays a random set of cards. © Alexander Us" +
    "ov";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(959, 491);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonNewSet);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(975, 530);
            this.MinimumSize = new System.Drawing.Size(975, 530);
            this.Name = "Form";
            this.Text = "Cards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewSet;
        private System.Windows.Forms.Label label;
    }
}

