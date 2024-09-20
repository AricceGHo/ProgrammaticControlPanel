namespace ProgrammaticControlPanel
{
    partial class LessionsEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            cancel_btn = new Button();
            save_btn = new Button();
            lessionsEdit_dgw = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lessionsEdit_dgw).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cancel_btn);
            panel1.Controls.Add(save_btn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 940);
            panel1.Name = "panel1";
            panel1.Size = new Size(1246, 48);
            panel1.TabIndex = 0;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(126, 9);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(94, 29);
            cancel_btn.TabIndex = 1;
            cancel_btn.Text = "Отмена";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(15, 9);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(94, 29);
            save_btn.TabIndex = 0;
            save_btn.Text = "Сохранить";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // lessionsEdit_dgw
            // 
            lessionsEdit_dgw.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lessionsEdit_dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            lessionsEdit_dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            lessionsEdit_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lessionsEdit_dgw.Location = new Point(0, 0);
            lessionsEdit_dgw.Name = "lessionsEdit_dgw";
            lessionsEdit_dgw.RowHeadersWidth = 51;
            lessionsEdit_dgw.RowTemplate.Height = 29;
            lessionsEdit_dgw.Size = new Size(1246, 910);
            lessionsEdit_dgw.TabIndex = 1;
            // 
            // LessionsEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 988);
            Controls.Add(lessionsEdit_dgw);
            Controls.Add(panel1);
            Name = "LessionsEdit";
            Text = "LessionsEdit";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lessionsEdit_dgw).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button save_btn;
        private DataGridView lessionsEdit_dgw;
        private Button cancel_btn;
    }
}