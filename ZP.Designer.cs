namespace ProgrammaticControlPanel
{
    partial class ZP
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
            raw_dgw = new DataGridView();
            load_btn = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            calculatedData_dgw = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)raw_dgw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calculatedData_dgw).BeginInit();
            SuspendLayout();
            // 
            // raw_dgw
            // 
            raw_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            raw_dgw.Location = new Point(3, 3);
            raw_dgw.Name = "raw_dgw";
            raw_dgw.RowHeadersWidth = 51;
            raw_dgw.RowTemplate.Height = 29;
            raw_dgw.Size = new Size(1558, 272);
            raw_dgw.TabIndex = 0;
            // 
            // load_btn
            // 
            load_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            load_btn.Location = new Point(1567, 3);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(130, 29);
            load_btn.TabIndex = 1;
            load_btn.Text = "Открыть файл";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // calculatedData_dgw
            // 
            calculatedData_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calculatedData_dgw.Location = new Point(3, 281);
            calculatedData_dgw.Name = "calculatedData_dgw";
            calculatedData_dgw.RowHeadersWidth = 51;
            calculatedData_dgw.RowTemplate.Height = 29;
            calculatedData_dgw.Size = new Size(581, 552);
            calculatedData_dgw.TabIndex = 2;
            // 
            // ZP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(calculatedData_dgw);
            Controls.Add(load_btn);
            Controls.Add(raw_dgw);
            Name = "ZP";
            Size = new Size(1700, 844);
            ((System.ComponentModel.ISupportInitialize)raw_dgw).EndInit();
            ((System.ComponentModel.ISupportInitialize)calculatedData_dgw).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView raw_dgw;
        private Button load_btn;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private DataGridView calculatedData_dgw;
    }
}
