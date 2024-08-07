namespace LenovoUI
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
            mainPanel = new TableLayoutPanel();
            leftPanel = new TableLayoutPanel();
            gpuPanel = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            label3 = new Label();
            firstLeftPanel = new Panel();
            button8 = new Button();
            label2 = new Label();
            label1 = new Label();
            gpuLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            cpuButton = new Button();
            systemToolsLabel = new Label();
            panel1 = new Panel();
            label4 = new Label();
            mainPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            gpuPanel.SuspendLayout();
            firstLeftPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.AutoSize = true;
            mainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainPanel.ColumnCount = 3;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            mainPanel.Controls.Add(leftPanel, 0, 0);
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.RowCount = 1;
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainPanel.Size = new Size(1846, 1152);
            mainPanel.TabIndex = 1;
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            leftPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            leftPanel.ColumnCount = 1;
            leftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            leftPanel.Controls.Add(gpuPanel, 0, 2);
            leftPanel.Controls.Add(firstLeftPanel, 0, 0);
            leftPanel.Controls.Add(systemToolsLabel, 0, 1);
            leftPanel.Controls.Add(panel1, 0, 3);
            leftPanel.Location = new Point(3, 3);
            leftPanel.Name = "leftPanel";
            leftPanel.RowCount = 4;
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            leftPanel.Size = new Size(1101, 1146);
            leftPanel.TabIndex = 0;
            // 
            // gpuPanel
            // 
            gpuPanel.BackColor = Color.DarkSlateGray;
            gpuPanel.Controls.Add(button7);
            gpuPanel.Controls.Add(button6);
            gpuPanel.Controls.Add(button5);
            gpuPanel.Controls.Add(button4);
            gpuPanel.Controls.Add(button3);
            gpuPanel.Controls.Add(label3);
            gpuPanel.Location = new Point(3, 575);
            gpuPanel.Name = "gpuPanel";
            gpuPanel.Size = new Size(1095, 280);
            gpuPanel.TabIndex = 6;
            // 
            // button7
            // 
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Transparent;
            button7.Location = new Point(906, 75);
            button7.Name = "button7";
            button7.Size = new Size(130, 101);
            button7.TabIndex = 10;
            button7.Text = "Hardware Scan";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Transparent;
            button6.Location = new Point(698, 75);
            button6.Name = "button6";
            button6.Size = new Size(130, 101);
            button6.TabIndex = 9;
            button6.Text = "Media";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(483, 75);
            button5.Name = "button5";
            button5.Size = new Size(130, 101);
            button5.TabIndex = 8;
            button5.Text = "Power";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(273, 75);
            button4.Name = "button4";
            button4.Size = new Size(130, 101);
            button4.TabIndex = 7;
            button4.Text = "Macro Key";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(65, 75);
            button3.Name = "button3";
            button3.Size = new Size(130, 101);
            button3.TabIndex = 6;
            button3.Text = "System Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateGray;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(152, 280);
            label3.Name = "label3";
            label3.Size = new Size(57, 32);
            label3.TabIndex = 5;
            label3.Text = "SSD";
            // 
            // firstLeftPanel
            // 
            firstLeftPanel.BackColor = Color.DarkSlateGray;
            firstLeftPanel.Controls.Add(button8);
            firstLeftPanel.Controls.Add(label2);
            firstLeftPanel.Controls.Add(label1);
            firstLeftPanel.Controls.Add(gpuLabel);
            firstLeftPanel.Controls.Add(button1);
            firstLeftPanel.Controls.Add(button2);
            firstLeftPanel.Controls.Add(cpuButton);
            firstLeftPanel.Location = new Point(3, 3);
            firstLeftPanel.Name = "firstLeftPanel";
            firstLeftPanel.Size = new Size(1095, 452);
            firstLeftPanel.TabIndex = 5;
            // 
            // button8
            // 
            button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button8.BackColor = Color.DarkSlateGray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Transparent;
            button8.Location = new Point(724, 69);
            button8.Name = "button8";
            button8.Size = new Size(204, 161);
            button8.TabIndex = 9;
            button8.Text = "100%";
            button8.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(791, 254);
            label2.Name = "label2";
            label2.Size = new Size(57, 32);
            label2.TabIndex = 8;
            label2.Text = "SSD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(444, 254);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 7;
            label1.Text = "VRAM";
            // 
            // gpuLabel
            // 
            gpuLabel.AutoSize = true;
            gpuLabel.BackColor = Color.DarkSlateGray;
            gpuLabel.FlatStyle = FlatStyle.Flat;
            gpuLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpuLabel.ForeColor = Color.Transparent;
            gpuLabel.Location = new Point(65, 254);
            gpuLabel.Name = "gpuLabel";
            gpuLabel.Size = new Size(59, 32);
            gpuLabel.TabIndex = 6;
            gpuLabel.Text = "GPU";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(454, 69);
            button1.Name = "button1";
            button1.Size = new Size(51, 161);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(65, 69);
            button2.Name = "button2";
            button2.Size = new Size(51, 161);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            // 
            // cpuButton
            // 
            cpuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cpuButton.BackColor = Color.DarkSlateGray;
            cpuButton.FlatStyle = FlatStyle.Flat;
            cpuButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cpuButton.ForeColor = Color.Transparent;
            cpuButton.Location = new Point(187, 69);
            cpuButton.Name = "cpuButton";
            cpuButton.Size = new Size(204, 161);
            cpuButton.TabIndex = 4;
            cpuButton.Text = "CPU";
            cpuButton.UseVisualStyleBackColor = false;
            // 
            // systemToolsLabel
            // 
            systemToolsLabel.AutoSize = true;
            systemToolsLabel.BackColor = Color.Transparent;
            systemToolsLabel.Dock = DockStyle.Bottom;
            systemToolsLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemToolsLabel.ForeColor = Color.Transparent;
            systemToolsLabel.Location = new Point(3, 527);
            systemToolsLabel.Name = "systemToolsLabel";
            systemToolsLabel.Size = new Size(1095, 45);
            systemToolsLabel.TabIndex = 7;
            systemToolsLabel.Text = "System Tools";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 861);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 282);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(204, 45);
            label4.TabIndex = 8;
            label4.Text = "System Tools";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1873, 1176);
            Controls.Add(mainPanel);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            mainPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            gpuPanel.ResumeLayout(false);
            gpuPanel.PerformLayout();
            firstLeftPanel.ResumeLayout(false);
            firstLeftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ssdLabel;
        private TableLayoutPanel mainPanel;
        private Panel cpuPanel;
        private Label label1;
        private Button button1;
        private Button cpuButton;
        private Panel gpuPanel;
        private Label label3;
        private Panel rightPanel;
        private Panel firstLeftPanel;
        private Label label2;
        private Label gpuLabel;
        private Panel secondLeftPanel;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label systemToolsLabel;
        private Button button7;
        private TableLayoutPanel leftPanel;
        private Button button2;
        private Panel panel1;
        private Label label4;
        private Button button8;
    }
}
