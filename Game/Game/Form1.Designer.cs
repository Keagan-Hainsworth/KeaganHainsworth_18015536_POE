namespace Game
{
    partial class Form1
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
            this.grpMap = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Left = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // grpMap
            // 
            this.grpMap.Location = new System.Drawing.Point(16, 41);
            this.grpMap.Margin = new System.Windows.Forms.Padding(4);
            this.grpMap.Name = "grpMap";
            this.grpMap.Padding = new System.Windows.Forms.Padding(4);
            this.grpMap.Size = new System.Drawing.Size(451, 543);
            this.grpMap.TabIndex = 0;
            this.grpMap.TabStop = false;
            this.grpMap.Text = "Map";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 407);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(482, 73);
            this.Left.Margin = new System.Windows.Forms.Padding(4);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(39, 28);
            this.Left.TabIndex = 3;
            this.Left.Text = "<";
            this.Left.UseVisualStyleBackColor = true;
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(518, 109);
            this.Down.Margin = new System.Windows.Forms.Padding(4);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(39, 28);
            this.Down.TabIndex = 5;
            this.Down.Text = "v";
            this.Down.UseVisualStyleBackColor = true;
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(518, 37);
            this.Up.Margin = new System.Windows.Forms.Padding(4);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(39, 28);
            this.Up.TabIndex = 2;
            this.Up.Text = "^";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.button1_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(555, 73);
            this.Right.Margin = new System.Windows.Forms.Padding(4);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(39, 28);
            this.Right.TabIndex = 4;
            this.Right.Text = ">";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(482, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 164);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 614);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpMap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.ListBox listBox1;
    }
}

