namespace CATraking
{
    partial class FrmMain
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
            this.btnEmployee = new System.Windows.Forms.Button();
            this.mnMenu = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnPermission = new System.Windows.Forms.Button();
            this.mnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEmployee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployee.Location = new System.Drawing.Point(18, 37);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(240, 177);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.UseVisualStyleBackColor = false;
            // 
            // mnMenu
            // 
            this.mnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.mnMenu.Location = new System.Drawing.Point(0, 0);
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnMenu.Size = new System.Drawing.Size(772, 25);
            this.mnMenu.TabIndex = 6;
            this.mnMenu.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.salirToolStripMenuItem.Text = "Logout";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTasks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTasks.Location = new System.Drawing.Point(267, 37);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(4);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(240, 177);
            this.btnTasks.TabIndex = 1;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTasks.UseVisualStyleBackColor = false;
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSalary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalary.Location = new System.Drawing.Point(516, 37);
            this.btnSalary.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(240, 177);
            this.btnSalary.TabIndex = 2;
            this.btnSalary.Text = "Salary";
            this.btnSalary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalary.UseVisualStyleBackColor = false;
            // 
            // btnPosition
            // 
            this.btnPosition.BackColor = System.Drawing.Color.Thistle;
            this.btnPosition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosition.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPosition.Location = new System.Drawing.Point(516, 223);
            this.btnPosition.Margin = new System.Windows.Forms.Padding(4);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(240, 177);
            this.btnPosition.TabIndex = 5;
            this.btnPosition.Text = "Position";
            this.btnPosition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPosition.UseVisualStyleBackColor = false;
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.LightPink;
            this.btnDepartment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartment.Location = new System.Drawing.Point(267, 223);
            this.btnDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(240, 177);
            this.btnDepartment.TabIndex = 4;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartment.UseVisualStyleBackColor = false;
            // 
            // btnPermission
            // 
            this.btnPermission.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPermission.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermission.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPermission.Location = new System.Drawing.Point(18, 223);
            this.btnPermission.Margin = new System.Windows.Forms.Padding(4);
            this.btnPermission.Name = "btnPermission";
            this.btnPermission.Size = new System.Drawing.Size(240, 177);
            this.btnPermission.TabIndex = 3;
            this.btnPermission.Text = "Permission";
            this.btnPermission.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPermission.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 415);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnPermission);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.mnMenu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATraking";
            this.mnMenu.ResumeLayout(false);
            this.mnMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.MenuStrip mnMenu;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnPermission;
    }
}