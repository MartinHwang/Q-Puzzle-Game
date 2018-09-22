namespace IHassignment
{
    partial class MazeDesigner
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnYellowDoor = new System.Windows.Forms.Button();
            this.btnBlueDoor = new System.Windows.Forms.Button();
            this.btnYellowBox = new System.Windows.Forms.Button();
            this.btnBlueBox = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 609);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(784, 54);
            this.label2.TabIndex = 2;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(60, 41);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(92, 20);
            this.txtRows.TabIndex = 3;
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(241, 42);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(97, 20);
            this.txtColumns.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rows";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Columns";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(358, 40);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(118, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnNone
            // 
            this.btnNone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNone.Image = global::IHassignment.Properties.Resources.none;
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.Location = new System.Drawing.Point(12, 117);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(98, 52);
            this.btnNone.TabIndex = 8;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = false;
            this.btnNone.Click += new System.EventHandler(this.Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Toolbox";
            // 
            // btnWall
            // 
            this.btnWall.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWall.Image = global::IHassignment.Properties.Resources.wall;
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.Location = new System.Drawing.Point(12, 173);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(98, 52);
            this.btnWall.TabIndex = 10;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = false;
            this.btnWall.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRedDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRedDoor.Image = global::IHassignment.Properties.Resources.redDoor;
            this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedDoor.Location = new System.Drawing.Point(12, 230);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(98, 52);
            this.btnRedDoor.TabIndex = 11;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = false;
            this.btnRedDoor.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGreenDoor.Image = global::IHassignment.Properties.Resources.greenDoor;
            this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenDoor.Location = new System.Drawing.Point(12, 288);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(98, 52);
            this.btnGreenDoor.TabIndex = 12;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = false;
            this.btnGreenDoor.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGreenBox.Image = global::IHassignment.Properties.Resources.greenBox;
            this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenBox.Location = new System.Drawing.Point(12, 516);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(98, 52);
            this.btnGreenBox.TabIndex = 16;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = false;
            this.btnGreenBox.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnRedBox
            // 
            this.btnRedBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRedBox.Image = global::IHassignment.Properties.Resources.redBox;
            this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedBox.Location = new System.Drawing.Point(12, 459);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(98, 52);
            this.btnRedBox.TabIndex = 15;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = false;
            this.btnRedBox.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnYellowDoor
            // 
            this.btnYellowDoor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnYellowDoor.Image = global::IHassignment.Properties.Resources.yelloowDoor;
            this.btnYellowDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYellowDoor.Location = new System.Drawing.Point(12, 402);
            this.btnYellowDoor.Name = "btnYellowDoor";
            this.btnYellowDoor.Size = new System.Drawing.Size(98, 52);
            this.btnYellowDoor.TabIndex = 14;
            this.btnYellowDoor.Text = "Yellow Door";
            this.btnYellowDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYellowDoor.UseVisualStyleBackColor = false;
            this.btnYellowDoor.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBlueDoor
            // 
            this.btnBlueDoor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBlueDoor.Image = global::IHassignment.Properties.Resources.blueDoor;
            this.btnBlueDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueDoor.Location = new System.Drawing.Point(12, 346);
            this.btnBlueDoor.Name = "btnBlueDoor";
            this.btnBlueDoor.Size = new System.Drawing.Size(98, 52);
            this.btnBlueDoor.TabIndex = 13;
            this.btnBlueDoor.Text = "Blue Door";
            this.btnBlueDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlueDoor.UseVisualStyleBackColor = false;
            this.btnBlueDoor.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnYellowBox
            // 
            this.btnYellowBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnYellowBox.Image = global::IHassignment.Properties.Resources.yellowBox;
            this.btnYellowBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYellowBox.Location = new System.Drawing.Point(12, 632);
            this.btnYellowBox.Name = "btnYellowBox";
            this.btnYellowBox.Size = new System.Drawing.Size(98, 52);
            this.btnYellowBox.TabIndex = 18;
            this.btnYellowBox.Text = "Yellow Box";
            this.btnYellowBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYellowBox.UseVisualStyleBackColor = false;
            this.btnYellowBox.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBlueBox
            // 
            this.btnBlueBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBlueBox.Image = global::IHassignment.Properties.Resources.blueBox;
            this.btnBlueBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueBox.Location = new System.Drawing.Point(12, 574);
            this.btnBlueBox.Name = "btnBlueBox";
            this.btnBlueBox.Size = new System.Drawing.Size(98, 52);
            this.btnBlueBox.TabIndex = 17;
            this.btnBlueBox.Text = "Blue Box";
            this.btnBlueBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlueBox.UseVisualStyleBackColor = false;
            this.btnBlueBox.Click += new System.EventHandler(this.Button_Click);
            // 
            // MazeDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 709);
            this.Controls.Add(this.btnYellowBox);
            this.Controls.Add(this.btnBlueBox);
            this.Controls.Add(this.btnGreenBox);
            this.Controls.Add(this.btnRedBox);
            this.Controls.Add(this.btnYellowDoor);
            this.Controls.Add(this.btnBlueDoor);
            this.Controls.Add(this.btnGreenDoor);
            this.Controls.Add(this.btnRedDoor);
            this.Controls.Add(this.btnWall);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtColumns);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MazeDesigner";
            this.Text = "MazeDesigner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnYellowDoor;
        private System.Windows.Forms.Button btnBlueDoor;
        private System.Windows.Forms.Button btnYellowBox;
        private System.Windows.Forms.Button btnBlueBox;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}