namespace Pokemon
{
    partial class Battle
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
            this.baseLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.playingFieldTable = new System.Windows.Forms.TableLayoutPanel();
            this.baseLayoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseLayoutTable
            // 
            this.baseLayoutTable.ColumnCount = 1;
            this.baseLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.baseLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.baseLayoutTable.Controls.Add(this.playingFieldTable, 0, 0);
            this.baseLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseLayoutTable.Location = new System.Drawing.Point(0, 0);
            this.baseLayoutTable.Name = "baseLayoutTable";
            this.baseLayoutTable.RowCount = 2;
            this.baseLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.07111F));
            this.baseLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.9289F));
            this.baseLayoutTable.Size = new System.Drawing.Size(979, 661);
            this.baseLayoutTable.TabIndex = 0;
            // 
            // playingFieldTable
            // 
            this.playingFieldTable.ColumnCount = 2;
            this.playingFieldTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playingFieldTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playingFieldTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playingFieldTable.Location = new System.Drawing.Point(3, 3);
            this.playingFieldTable.Name = "playingFieldTable";
            this.playingFieldTable.RowCount = 2;
            this.playingFieldTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playingFieldTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playingFieldTable.Size = new System.Drawing.Size(973, 477);
            this.playingFieldTable.TabIndex = 0;
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 661);
            this.Controls.Add(this.baseLayoutTable);
            this.Name = "Battle";
            this.Text = "Form2";
            this.baseLayoutTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel baseLayoutTable;
        private System.Windows.Forms.TableLayoutPanel playingFieldTable;
    }
}