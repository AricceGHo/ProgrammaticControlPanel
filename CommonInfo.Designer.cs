namespace ProgrammaticControlPanel
{
    partial class CommonInfo
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
            ((System.ComponentModel.ISupportInitialize)calculatedData_dgw).BeginInit();
            SuspendLayout();
            // 
            // calculatedData_dgw
            // 
            calculatedData_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calculatedData_dgw.Dock = DockStyle.Fill;
            calculatedData_dgw.Location = new Point(0, 0);
            calculatedData_dgw.Name = "calculatedData_dgw";
            calculatedData_dgw.RowHeadersWidth = 51;
            calculatedData_dgw.RowTemplate.Height = 29;
            calculatedData_dgw.Size = new Size(1579, 844);
            calculatedData_dgw.TabIndex = 3;
            // 
            // CommonInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(calculatedData_dgw);
            Name = "CommonInfo";
            Size = new Size(1579, 844);
            ((System.ComponentModel.ISupportInitialize)calculatedData_dgw).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView calculatedData_dgw;
    }
}
