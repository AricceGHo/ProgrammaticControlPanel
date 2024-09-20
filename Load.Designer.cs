namespace ProgrammaticControlPanel
{
    partial class Load
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
            load_dgw = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)load_dgw).BeginInit();
            SuspendLayout();
            // 
            // load_dgw
            // 
            load_dgw.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            load_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            load_dgw.Location = new Point(3, 3);
            load_dgw.Name = "load_dgw";
            load_dgw.RowHeadersWidth = 51;
            load_dgw.RowTemplate.Height = 29;
            load_dgw.Size = new Size(724, 482);
            load_dgw.TabIndex = 1;
            // 
            // Load
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(load_dgw);
            Name = "Load";
            Size = new Size(730, 488);
            ((System.ComponentModel.ISupportInitialize)load_dgw).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView load_dgw;
    }
}
