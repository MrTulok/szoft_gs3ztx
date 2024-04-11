namespace Eloadas6
{
    partial class Form2
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
            menuStrip1 = new MenuStrip();
            elsőAblakToolStripMenuItem = new ToolStripMenuItem();
            sziaToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { elsőAblakToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // elsőAblakToolStripMenuItem
            // 
            elsőAblakToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sziaToolStripMenuItem });
            elsőAblakToolStripMenuItem.Name = "elsőAblakToolStripMenuItem";
            elsőAblakToolStripMenuItem.Size = new Size(90, 24);
            elsőAblakToolStripMenuItem.Text = "&Első ablak&";
            // 
            // sziaToolStripMenuItem
            // 
            sziaToolStripMenuItem.Name = "sziaToolStripMenuItem";
            sziaToolStripMenuItem.Size = new Size(224, 26);
            sziaToolStripMenuItem.Text = "Szia";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(122, 239);
            button1.Name = "button1";
            button1.Size = new Size(164, 44);
            button1.TabIndex = 1;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(342, 233);
            button2.Name = "button2";
            button2.Size = new Size(183, 56);
            button2.TabIndex = 2;
            button2.Text = "Ok";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem elsőAblakToolStripMenuItem;
        private ToolStripMenuItem sziaToolStripMenuItem;
        private Button button1;
        private Button button2;
    }
}