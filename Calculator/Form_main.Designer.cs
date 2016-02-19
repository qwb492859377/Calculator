namespace Calculator {
    partial class Form_main {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
			this.label_show = new System.Windows.Forms.Label();
			this.menu_show = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.复制结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button19 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.button16 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.menu_show.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_show
			// 
			this.label_show.BackColor = System.Drawing.Color.White;
			this.label_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_show.ContextMenuStrip = this.menu_show;
			this.label_show.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label_show.Location = new System.Drawing.Point(7, 5);
			this.label_show.Name = "label_show";
			this.label_show.Size = new System.Drawing.Size(309, 82);
			this.label_show.TabIndex = 1;
			// 
			// menu_show
			// 
			this.menu_show.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制结果ToolStripMenuItem});
			this.menu_show.Name = "menu_show";
			this.menu_show.Size = new System.Drawing.Size(125, 26);
			// 
			// 复制结果ToolStripMenuItem
			// 
			this.复制结果ToolStripMenuItem.Name = "复制结果ToolStripMenuItem";
			this.复制结果ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.复制结果ToolStripMenuItem.Text = "复制结果";
			this.复制结果ToolStripMenuItem.Click += new System.EventHandler(this.复制结果ToolStripMenuItem_Click);
			// 
			// button19
			// 
			this.button19.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button19.Location = new System.Drawing.Point(237, 159);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(72, 45);
			this.button19.TabIndex = 7;
			this.button19.TabStop = false;
			this.button19.Text = "0";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.button_Click);
			// 
			// button18
			// 
			this.button18.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button18.Location = new System.Drawing.Point(237, 55);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(72, 45);
			this.button18.TabIndex = 6;
			this.button18.TabStop = false;
			this.button18.Text = "CE";
			this.button18.UseVisualStyleBackColor = true;
			this.button18.Click += new System.EventHandler(this.button_Click);
			// 
			// button17
			// 
			this.button17.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button17.Location = new System.Drawing.Point(237, 107);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(72, 45);
			this.button17.TabIndex = 5;
			this.button17.TabStop = false;
			this.button17.Text = "C";
			this.button17.UseVisualStyleBackColor = true;
			this.button17.Click += new System.EventHandler(this.button_Click);
			// 
			// button15
			// 
			this.button15.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button15.Location = new System.Drawing.Point(237, 211);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(73, 45);
			this.button15.TabIndex = 3;
			this.button15.TabStop = false;
			this.button15.Text = "=";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.button_Click);
			// 
			// button14
			// 
			this.button14.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button14.Location = new System.Drawing.Point(3, 211);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(72, 45);
			this.button14.TabIndex = 3;
			this.button14.TabStop = false;
			this.button14.Text = "(";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.button_Click);
			// 
			// button10
			// 
			this.button10.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button10.Location = new System.Drawing.Point(3, 3);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(72, 45);
			this.button10.TabIndex = 4;
			this.button10.TabStop = false;
			this.button10.Text = "+";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button3.Location = new System.Drawing.Point(159, 55);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(72, 45);
			this.button3.TabIndex = 3;
			this.button3.TabStop = false;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.Location = new System.Drawing.Point(81, 55);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 45);
			this.button2.TabIndex = 2;
			this.button2.TabStop = false;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(3, 55);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 45);
			this.button1.TabIndex = 1;
			this.button1.TabStop = false;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button4.Location = new System.Drawing.Point(3, 107);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(72, 45);
			this.button4.TabIndex = 2;
			this.button4.TabStop = false;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button_Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button5.Location = new System.Drawing.Point(81, 107);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(72, 45);
			this.button5.TabIndex = 2;
			this.button5.TabStop = false;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button_Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button6.Location = new System.Drawing.Point(159, 107);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(72, 45);
			this.button6.TabIndex = 2;
			this.button6.TabStop = false;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button_Click);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button7.Location = new System.Drawing.Point(3, 159);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(72, 45);
			this.button7.TabIndex = 2;
			this.button7.TabStop = false;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button_Click);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button8.Location = new System.Drawing.Point(81, 159);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(72, 45);
			this.button8.TabIndex = 2;
			this.button8.TabStop = false;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button_Click);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button9.Location = new System.Drawing.Point(159, 159);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(72, 45);
			this.button9.TabIndex = 2;
			this.button9.TabStop = false;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button_Click);
			// 
			// button11
			// 
			this.button11.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button11.Location = new System.Drawing.Point(81, 3);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(72, 45);
			this.button11.TabIndex = 2;
			this.button11.TabStop = false;
			this.button11.Text = "-";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button_Click);
			// 
			// button12
			// 
			this.button12.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button12.Location = new System.Drawing.Point(159, 3);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(72, 45);
			this.button12.TabIndex = 2;
			this.button12.TabStop = false;
			this.button12.Text = "*";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button_Click);
			// 
			// button13
			// 
			this.button13.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button13.Location = new System.Drawing.Point(237, 3);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(72, 45);
			this.button13.TabIndex = 2;
			this.button13.TabStop = false;
			this.button13.Text = "/";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.button_Click);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 4;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel.Controls.Add(this.button13, 3, 0);
			this.tableLayoutPanel.Controls.Add(this.button12, 2, 0);
			this.tableLayoutPanel.Controls.Add(this.button11, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.button9, 2, 3);
			this.tableLayoutPanel.Controls.Add(this.button8, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.button7, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.button6, 2, 2);
			this.tableLayoutPanel.Controls.Add(this.button5, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.button4, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.button1, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.button2, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.button3, 2, 1);
			this.tableLayoutPanel.Controls.Add(this.button10, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.button14, 0, 4);
			this.tableLayoutPanel.Controls.Add(this.button17, 3, 2);
			this.tableLayoutPanel.Controls.Add(this.button18, 3, 1);
			this.tableLayoutPanel.Controls.Add(this.button19, 3, 3);
			this.tableLayoutPanel.Controls.Add(this.button16, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.button15, 3, 4);
			this.tableLayoutPanel.Controls.Add(this.button20, 2, 4);
			this.tableLayoutPanel.Location = new System.Drawing.Point(4, 91);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 5;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(313, 264);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// button16
			// 
			this.button16.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button16.Location = new System.Drawing.Point(81, 211);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(72, 45);
			this.button16.TabIndex = 8;
			this.button16.TabStop = false;
			this.button16.Text = ")";
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new System.EventHandler(this.button_Click);
			// 
			// button20
			// 
			this.button20.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button20.Location = new System.Drawing.Point(159, 211);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(72, 45);
			this.button20.TabIndex = 9;
			this.button20.TabStop = false;
			this.button20.Text = ".";
			this.button20.UseVisualStyleBackColor = true;
			this.button20.Click += new System.EventHandler(this.button_Click);
			// 
			// Form_main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(327, 363);
			this.Controls.Add(this.label_show);
			this.Controls.Add(this.tableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Form_main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "计算器";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_main_KeyPress);
			this.menu_show.ResumeLayout(false);
			this.tableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Label label_show;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.ContextMenuStrip menu_show;
		private System.Windows.Forms.ToolStripMenuItem 复制结果ToolStripMenuItem;
		private System.Windows.Forms.Button button20;
    }
}

