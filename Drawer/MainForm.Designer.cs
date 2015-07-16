namespace Drawer
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FormLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.SqareButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.RectungleButton = new System.Windows.Forms.Button();
            this.FigureTree = new System.Windows.Forms.TreeView();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.FormLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormLayoutPanel
            // 
            this.FormLayoutPanel.ColumnCount = 7;
            this.FormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.FormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.FormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.FormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.FormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.FormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.FormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 372F));
            this.FormLayoutPanel.Controls.Add(this.TriangleButton, 1, 0);
            this.FormLayoutPanel.Controls.Add(this.SqareButton, 2, 0);
            this.FormLayoutPanel.Controls.Add(this.CircleButton, 3, 0);
            this.FormLayoutPanel.Controls.Add(this.RectungleButton, 4, 0);
            this.FormLayoutPanel.Controls.Add(this.FigureTree, 0, 1);
            this.FormLayoutPanel.Controls.Add(this.PictureBox, 1, 1);
            this.FormLayoutPanel.Controls.Add(this.pauseButton, 5, 0);
            this.FormLayoutPanel.Controls.Add(this.menuStrip1, 0, 0);
            this.FormLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.FormLayoutPanel.Name = "FormLayoutPanel";
            this.FormLayoutPanel.RowCount = 3;
            this.FormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.FormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FormLayoutPanel.Size = new System.Drawing.Size(986, 473);
            this.FormLayoutPanel.TabIndex = 0;
            // 
            // TriangleButton
            // 
            this.TriangleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TriangleButton.BackgroundImage")));
            this.TriangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TriangleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TriangleButton.Location = new System.Drawing.Point(203, 3);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(54, 54);
            this.TriangleButton.TabIndex = 1;
            this.TriangleButton.UseVisualStyleBackColor = true;
            this.TriangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // SqareButton
            // 
            this.SqareButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SqareButton.BackgroundImage")));
            this.SqareButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SqareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SqareButton.Location = new System.Drawing.Point(263, 3);
            this.SqareButton.Name = "SqareButton";
            this.SqareButton.Size = new System.Drawing.Size(54, 54);
            this.SqareButton.TabIndex = 0;
            this.SqareButton.UseVisualStyleBackColor = true;
            this.SqareButton.Click += new System.EventHandler(this.SqareButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircleButton.BackgroundImage")));
            this.CircleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CircleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CircleButton.Location = new System.Drawing.Point(323, 3);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(54, 54);
            this.CircleButton.TabIndex = 2;
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // RectungleButton
            // 
            this.RectungleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RectungleButton.BackgroundImage")));
            this.RectungleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RectungleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectungleButton.Location = new System.Drawing.Point(383, 3);
            this.RectungleButton.Name = "RectungleButton";
            this.RectungleButton.Size = new System.Drawing.Size(54, 54);
            this.RectungleButton.TabIndex = 3;
            this.RectungleButton.UseVisualStyleBackColor = true;
            this.RectungleButton.Click += new System.EventHandler(this.RectungleButton_Click);
            // 
            // FigureTree
            // 
            this.FigureTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FigureTree.Location = new System.Drawing.Point(3, 63);
            this.FigureTree.Name = "FigureTree";
            this.FigureTree.Size = new System.Drawing.Size(194, 387);
            this.FigureTree.TabIndex = 4;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FormLayoutPanel.SetColumnSpan(this.PictureBox, 6);
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(203, 63);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(780, 387);
            this.PictureBox.TabIndex = 5;
            this.PictureBox.TabStop = false;
            this.PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.BackgroundImage")));
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pauseButton.Location = new System.Drawing.Point(443, 3);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(54, 54);
            this.pauseButton.TabIndex = 6;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "File.bin";
            this.saveFileDialog.Filter = "BIN|*.bin|Json|*.json|XML|*.xml";
            this.saveFileDialog.InitialDirectory = "D:\\";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "File.bin";
            this.openFileDialog.Filter = "BIN|*.bin|Json|*.json|XML|*.xml";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 473);
            this.Controls.Add(this.FormLayoutPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Drawer";
            this.FormLayoutPanel.ResumeLayout(false);
            this.FormLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FormLayoutPanel;
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.Button SqareButton;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button RectungleButton;
        private System.Windows.Forms.TreeView FigureTree;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer;
    }
}

