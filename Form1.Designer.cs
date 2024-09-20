namespace ProgrammaticControlPanel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            inputs_tp = new TabPage();
            common_tp = new TabPage();
            analysis_tp = new TabPage();
            final_tp = new TabPage();
            load_tp = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(inputs_tp);
            tabControl1.Controls.Add(common_tp);
            tabControl1.Controls.Add(analysis_tp);
            tabControl1.Controls.Add(load_tp);
            tabControl1.Controls.Add(final_tp);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1709, 800);
            tabControl1.TabIndex = 0;
            // 
            // inputs_tp
            // 
            inputs_tp.BackColor = Color.Gray;
            inputs_tp.Location = new Point(4, 29);
            inputs_tp.Name = "inputs_tp";
            inputs_tp.Padding = new Padding(3);
            inputs_tp.Size = new Size(1701, 767);
            inputs_tp.TabIndex = 0;
            inputs_tp.Text = "Вводные";
            // 
            // common_tp
            // 
            common_tp.BackColor = Color.Gray;
            common_tp.Location = new Point(4, 29);
            common_tp.Name = "common_tp";
            common_tp.Padding = new Padding(3);
            common_tp.Size = new Size(1701, 767);
            common_tp.TabIndex = 1;
            common_tp.Text = "Общее";
            // 
            // analysis_tp
            // 
            analysis_tp.Location = new Point(4, 29);
            analysis_tp.Name = "analysis_tp";
            analysis_tp.Size = new Size(1701, 767);
            analysis_tp.TabIndex = 2;
            analysis_tp.Text = "Разбор";
            analysis_tp.UseVisualStyleBackColor = true;
            // 
            // final_tp
            // 
            final_tp.Location = new Point(4, 29);
            final_tp.Name = "final_tp";
            final_tp.Size = new Size(1701, 767);
            final_tp.TabIndex = 3;
            final_tp.Text = "Готово";
            final_tp.UseVisualStyleBackColor = true;
            // 
            // load_tp
            // 
            load_tp.Location = new Point(4, 29);
            load_tp.Name = "load_tp";
            load_tp.Size = new Size(1701, 767);
            load_tp.TabIndex = 4;
            load_tp.Text = "Нагрузка";
            load_tp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1709, 800);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage inputs_tp;
        private TabPage common_tp;
        private TabPage analysis_tp;
        private TabPage final_tp;
        private TabPage load_tp;
    }
}