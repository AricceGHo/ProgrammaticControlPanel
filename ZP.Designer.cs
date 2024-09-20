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
            panel1 = new Panel();
            loadSettings_btn = new Button();
            saveSettings_btn = new Button();
            createLessionList_btn = new Button();
            loadLessions_btn = new Button();
            saveLessions_btn = new Button();
            editLessions_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)raw_dgw).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // raw_dgw
            // 
            raw_dgw.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            raw_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            raw_dgw.Location = new Point(15, 61);
            raw_dgw.Name = "raw_dgw";
            raw_dgw.RowHeadersWidth = 51;
            raw_dgw.RowTemplate.Height = 29;
            raw_dgw.Size = new Size(1876, 811);
            raw_dgw.TabIndex = 0;
            // 
            // load_btn
            // 
            load_btn.Location = new Point(3, 3);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(130, 36);
            load_btn.TabIndex = 1;
            load_btn.Text = "Открыть файл";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.Controls.Add(editLessions_btn);
            panel1.Controls.Add(loadSettings_btn);
            panel1.Controls.Add(saveSettings_btn);
            panel1.Controls.Add(createLessionList_btn);
            panel1.Controls.Add(loadLessions_btn);
            panel1.Controls.Add(saveLessions_btn);
            panel1.Controls.Add(load_btn);
            panel1.Location = new Point(12, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1879, 39);
            panel1.TabIndex = 3;
            // 
            // loadSettings_btn
            // 
            loadSettings_btn.Location = new Point(1236, 5);
            loadSettings_btn.Name = "loadSettings_btn";
            loadSettings_btn.Size = new Size(167, 29);
            loadSettings_btn.TabIndex = 6;
            loadSettings_btn.Text = "Загрузить настройки";
            loadSettings_btn.UseVisualStyleBackColor = true;
            loadSettings_btn.Click += loadSettings_btn_Click;
            // 
            // saveSettings_btn
            // 
            saveSettings_btn.Location = new Point(1058, 5);
            saveSettings_btn.Name = "saveSettings_btn";
            saveSettings_btn.Size = new Size(172, 29);
            saveSettings_btn.TabIndex = 5;
            saveSettings_btn.Text = "Сохранить настройки";
            saveSettings_btn.UseVisualStyleBackColor = true;
            saveSettings_btn.Click += saveSettings_btn_Click;
            // 
            // createLessionList_btn
            // 
            createLessionList_btn.Location = new Point(278, 5);
            createLessionList_btn.Name = "createLessionList_btn";
            createLessionList_btn.Size = new Size(181, 29);
            createLessionList_btn.TabIndex = 4;
            createLessionList_btn.Text = "Создать список уроков";
            createLessionList_btn.UseVisualStyleBackColor = true;
            createLessionList_btn.Click += createLessionList_btn_Click;
            // 
            // loadLessions_btn
            // 
            loadLessions_btn.Location = new Point(617, 5);
            loadLessions_btn.Name = "loadLessions_btn";
            loadLessions_btn.Size = new Size(146, 29);
            loadLessions_btn.TabIndex = 3;
            loadLessions_btn.Text = "Подгрузить уроки";
            loadLessions_btn.UseVisualStyleBackColor = true;
            loadLessions_btn.Click += loadLessions_btn_Click;
            // 
            // saveLessions_btn
            // 
            saveLessions_btn.Location = new Point(465, 5);
            saveLessions_btn.Name = "saveLessions_btn";
            saveLessions_btn.Size = new Size(146, 29);
            saveLessions_btn.TabIndex = 2;
            saveLessions_btn.Text = "Сохранить уроки";
            saveLessions_btn.UseVisualStyleBackColor = true;
            saveLessions_btn.Click += saveLessions_btn_Click;
            // 
            // editLessions_btn
            // 
            editLessions_btn.Location = new Point(769, 7);
            editLessions_btn.Name = "editLessions_btn";
            editLessions_btn.Size = new Size(170, 29);
            editLessions_btn.TabIndex = 7;
            editLessions_btn.Text = "Редактировать уроки";
            editLessions_btn.UseVisualStyleBackColor = true;
            editLessions_btn.Click += editLessions_btn_Click;
            // 
            // ZP
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(raw_dgw);
            Controls.Add(panel1);
            Name = "ZP";
            Size = new Size(1901, 885);
            ((System.ComponentModel.ISupportInitialize)raw_dgw).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView raw_dgw;
        private Button load_btn;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Panel panel1;
        private Button loadLessions_btn;
        private Button saveLessions_btn;
        private Button createLessionList_btn;
        private Button loadSettings_btn;
        private Button saveSettings_btn;
        private Button editLessions_btn;
    }
}
