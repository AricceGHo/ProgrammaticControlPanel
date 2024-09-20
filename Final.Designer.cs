namespace ProgrammaticControlPanel
{
    partial class Final
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            calculatedData_dgw = new DataGridView();
            save_btn = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)calculatedData_dgw).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // calculatedData_dgw
            // 
            calculatedData_dgw.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calculatedData_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calculatedData_dgw.Location = new Point(0, 53);
            calculatedData_dgw.Name = "calculatedData_dgw";
            calculatedData_dgw.RowHeadersWidth = 51;
            calculatedData_dgw.RowTemplate.Height = 29;
            calculatedData_dgw.Size = new Size(944, 422);
            calculatedData_dgw.TabIndex = 5;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(3, 6);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(94, 29);
            save_btn.TabIndex = 7;
            save_btn.Text = "Сохранить";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(save_btn);
            panel1.Location = new Point(3, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 38);
            panel1.TabIndex = 8;
            // 
            // Final
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(calculatedData_dgw);
            Name = "Final";
            Size = new Size(944, 475);
            ((System.ComponentModel.ISupportInitialize)calculatedData_dgw).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public DataGridView calculatedData_dgw;
        private Button save_btn;
        private Panel panel1;
    }
}
