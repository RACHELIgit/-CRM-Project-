namespace WindowsFormsApp1
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.richTextBoxTanac = new System.Windows.Forms.RichTextBox();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.listBoxLastSearch = new System.Windows.Forms.ListBox();
            this.buttonTocolor = new System.Windows.Forms.Button();
            this.buttonResult2 = new System.Windows.Forms.Button();
            this.labelFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(693, 60);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(275, 22);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(586, 58);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(71, 24);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "חפש";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(663, 59);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(30, 22);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "X";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxTanac
            // 
            this.richTextBoxTanac.Location = new System.Drawing.Point(33, 58);
            this.richTextBoxTanac.Name = "richTextBoxTanac";
            this.richTextBoxTanac.Size = new System.Drawing.Size(418, 660);
            this.richTextBoxTanac.TabIndex = 3;
            this.richTextBoxTanac.Text = "";
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(33, 24);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(96, 28);
            this.buttonBuild.TabIndex = 4;
            this.buttonBuild.Text = "buildIndexer";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 16;
            this.listBoxResult.Location = new System.Drawing.Point(467, 60);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(104, 308);
            this.listBoxResult.TabIndex = 5;
            // 
            // listBoxLastSearch
            // 
            this.listBoxLastSearch.FormattingEnabled = true;
            this.listBoxLastSearch.ItemHeight = 16;
            this.listBoxLastSearch.Location = new System.Drawing.Point(693, 84);
            this.listBoxLastSearch.Name = "listBoxLastSearch";
            this.listBoxLastSearch.Size = new System.Drawing.Size(275, 196);
            this.listBoxLastSearch.TabIndex = 6;
            this.listBoxLastSearch.Visible = false;
            this.listBoxLastSearch.Click += new System.EventHandler(this.listBoxLastSearch_Click);
            // 
            // buttonTocolor
            // 
            this.buttonTocolor.Location = new System.Drawing.Point(467, 428);
            this.buttonTocolor.Name = "buttonTocolor";
            this.buttonTocolor.Size = new System.Drawing.Size(104, 36);
            this.buttonTocolor.TabIndex = 7;
            this.buttonTocolor.Text = "הדגש ";
            this.buttonTocolor.UseVisualStyleBackColor = true;
            this.buttonTocolor.Click += new System.EventHandler(this.buttonTocolor_Click);
            // 
            // buttonResult2
            // 
            this.buttonResult2.AllowDrop = true;
            this.buttonResult2.Location = new System.Drawing.Point(467, 386);
            this.buttonResult2.Name = "buttonResult2";
            this.buttonResult2.Size = new System.Drawing.Size(104, 36);
            this.buttonResult2.TabIndex = 8;
            this.buttonResult2.Text = "מדויק יותר";
            this.buttonResult2.UseVisualStyleBackColor = true;
            this.buttonResult2.Click += new System.EventHandler(this.buttonResult2_Click);
            // 
            // labelFound
            // 
            this.labelFound.AutoSize = true;
            this.labelFound.Location = new System.Drawing.Point(587, 89);
            this.labelFound.Name = "labelFound";
            this.labelFound.Size = new System.Drawing.Size(46, 17);
            this.labelFound.TabIndex = 9;
            this.labelFound.Text = "label1";
            this.labelFound.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 744);
            this.Controls.Add(this.labelFound);
            this.Controls.Add(this.buttonResult2);
            this.Controls.Add(this.buttonTocolor);
            this.Controls.Add(this.listBoxLastSearch);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.richTextBoxTanac);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RichTextBox richTextBoxTanac;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.ListBox listBoxLastSearch;
        private System.Windows.Forms.Button buttonTocolor;
        private System.Windows.Forms.Button buttonResult2;
        private System.Windows.Forms.Label labelFound;
    }
}

