namespace Eloadas6
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
            menuStrip1 = new MenuStrip();
            elsőAblakToolStripMenuItem = new ToolStripMenuItem();
            másodikToolStripMenuItem = new ToolStripMenuItem();
            megnyitásToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { elsőAblakToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(818, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // elsőAblakToolStripMenuItem
            // 
            elsőAblakToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { másodikToolStripMenuItem, megnyitásToolStripMenuItem });
            elsőAblakToolStripMenuItem.Name = "elsőAblakToolStripMenuItem";
            elsőAblakToolStripMenuItem.Size = new Size(45, 24);
            elsőAblakToolStripMenuItem.Text = "&Fájl&";
            // 
            // másodikToolStripMenuItem
            // 
            másodikToolStripMenuItem.Name = "másodikToolStripMenuItem";
            másodikToolStripMenuItem.Size = new Size(160, 26);
            másodikToolStripMenuItem.Text = " Második";
            másodikToolStripMenuItem.Click += másodikToolStripMenuItem_Click;
            // 
            // megnyitásToolStripMenuItem
            // 
            megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            megnyitásToolStripMenuItem.Size = new Size(160, 26);
            megnyitásToolStripMenuItem.Text = "Megnyitás";
            megnyitásToolStripMenuItem.Click += megnyitásToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(94, 258);
            button1.Name = "button1";
            button1.Size = new Size(78, 58);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(94, 338);
            button2.Name = "button2";
            button2.Size = new Size(93, 69);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(242, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 371);
            panel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 450);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem elsőAblakToolStripMenuItem;
        private ToolStripMenuItem másodikToolStripMenuItem;
        private ToolStripMenuItem megnyitásToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}
