namespace LenovoUI
{
    partial class LenovoUI
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
            components = new System.ComponentModel.Container();
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
            button2 = new Button();
            button8 = new Button();
            label2 = new Label();
            label1 = new Label();
            gpuLabel = new Label();
            button1 = new Button();
            cpuButton = new Button();
            systemToolsLabel = new Label();
            panel1 = new Panel();
            label4 = new Label();
            rightPanel = new TableLayoutPanel();
            firstRightPanel = new TableLayoutPanel();
            panel9 = new Panel();
            checkBox8 = new CheckBox();
            label12 = new Label();
            panel8 = new Panel();
            checkBox7 = new CheckBox();
            label11 = new Label();
            panel7 = new Panel();
            checkBox6 = new CheckBox();
            label10 = new Label();
            panel6 = new Panel();
            checkBox5 = new CheckBox();
            label9 = new Label();
            panel5 = new Panel();
            checkBox4 = new CheckBox();
            label8 = new Label();
            panel4 = new Panel();
            checkBox3 = new CheckBox();
            label7 = new Label();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            label5 = new Label();
            panel3 = new Panel();
            checkBox2 = new CheckBox();
            label6 = new Label();
            label13 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel11 = new Panel();
            checkBox11 = new CheckBox();
            label16 = new Label();
            panel10 = new Panel();
            checkBox9 = new CheckBox();
            label14 = new Label();
            panel12 = new Panel();
            checkBox10 = new CheckBox();
            label15 = new Label();
            toolTip1 = new ToolTip(components);
            mainPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            gpuPanel.SuspendLayout();
            firstLeftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            firstRightPanel.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
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
            mainPanel.Controls.Add(rightPanel, 2, 0);
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.RowCount = 1;
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainPanel.Size = new Size(1840, 1152);
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
            leftPanel.Size = new Size(1098, 1146);
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
            gpuPanel.Size = new Size(1092, 280);
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
            firstLeftPanel.Controls.Add(button2);
            firstLeftPanel.Controls.Add(button8);
            firstLeftPanel.Controls.Add(label2);
            firstLeftPanel.Controls.Add(label1);
            firstLeftPanel.Controls.Add(gpuLabel);
            firstLeftPanel.Controls.Add(button1);
            firstLeftPanel.Controls.Add(cpuButton);
            firstLeftPanel.Location = new Point(3, 3);
            firstLeftPanel.Name = "firstLeftPanel";
            firstLeftPanel.Size = new Size(1092, 452);
            firstLeftPanel.TabIndex = 5;
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
            button2.TabIndex = 10;
            toolTip1.SetToolTip(button2, "GPU usage");
            button2.UseVisualStyleBackColor = false;
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
            toolTip1.SetToolTip(button8, "SSD usage");
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
            toolTip1.SetToolTip(button1, "VRAM usage");
            button1.UseVisualStyleBackColor = false;
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
            toolTip1.SetToolTip(cpuButton, "CPU usage");
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
            systemToolsLabel.Size = new Size(1092, 45);
            systemToolsLabel.TabIndex = 7;
            systemToolsLabel.Text = "System Tools";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 861);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 282);
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
            label4.Size = new Size(223, 45);
            label4.TabIndex = 8;
            label4.Text = "System Health";
            // 
            // rightPanel
            // 
            rightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            rightPanel.ColumnCount = 1;
            rightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            rightPanel.Controls.Add(firstRightPanel, 0, 0);
            rightPanel.Controls.Add(label13, 0, 1);
            rightPanel.Controls.Add(tableLayoutPanel1, 0, 2);
            rightPanel.Location = new Point(1199, 3);
            rightPanel.Name = "rightPanel";
            rightPanel.RowCount = 3;
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            rightPanel.Size = new Size(638, 1146);
            rightPanel.TabIndex = 1;
            // 
            // firstRightPanel
            // 
            firstRightPanel.BackColor = Color.DarkSlateGray;
            firstRightPanel.ColumnCount = 1;
            firstRightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            firstRightPanel.Controls.Add(panel9, 0, 7);
            firstRightPanel.Controls.Add(panel8, 0, 6);
            firstRightPanel.Controls.Add(panel7, 0, 5);
            firstRightPanel.Controls.Add(panel6, 0, 4);
            firstRightPanel.Controls.Add(panel5, 0, 3);
            firstRightPanel.Controls.Add(panel4, 0, 2);
            firstRightPanel.Controls.Add(panel2, 0, 0);
            firstRightPanel.Controls.Add(panel3, 0, 1);
            firstRightPanel.Location = new Point(3, 3);
            firstRightPanel.Name = "firstRightPanel";
            firstRightPanel.RowCount = 8;
            firstRightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            firstRightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            firstRightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            firstRightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            firstRightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            firstRightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            firstRightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            firstRightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            firstRightPanel.Size = new Size(632, 681);
            firstRightPanel.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(checkBox8);
            panel9.Controls.Add(label12);
            panel9.Location = new Point(3, 598);
            panel9.Name = "panel9";
            panel9.Size = new Size(626, 80);
            panel9.TabIndex = 13;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(502, 51);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(121, 29);
            checkBox8.TabIndex = 17;
            checkBox8.Text = "checkBox8";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Dock = DockStyle.Bottom;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(0, 42);
            label12.Name = "label12";
            label12.Size = new Size(200, 38);
            label12.TabIndex = 15;
            label12.Text = "Touchpad Lock";
            // 
            // panel8
            // 
            panel8.Controls.Add(checkBox7);
            panel8.Controls.Add(label11);
            panel8.Location = new Point(3, 513);
            panel8.Name = "panel8";
            panel8.Size = new Size(626, 79);
            panel8.TabIndex = 11;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(502, 51);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(121, 29);
            checkBox7.TabIndex = 16;
            checkBox7.Text = "checkBox7";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Dock = DockStyle.Bottom;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(0, 41);
            label11.Name = "label11";
            label11.Size = new Size(149, 38);
            label11.TabIndex = 14;
            label11.Text = "Over Drive";
            // 
            // panel7
            // 
            panel7.Controls.Add(checkBox6);
            panel7.Controls.Add(label10);
            panel7.Location = new Point(3, 428);
            panel7.Name = "panel7";
            panel7.Size = new Size(626, 79);
            panel7.TabIndex = 9;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(502, 51);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(121, 29);
            checkBox6.TabIndex = 15;
            checkBox6.Text = "checkBox6";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Dock = DockStyle.Bottom;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(0, 41);
            label10.Name = "label10";
            label10.Size = new Size(263, 38);
            label10.TabIndex = 13;
            label10.Text = "GPU Working Mode";
            // 
            // panel6
            // 
            panel6.Controls.Add(checkBox5);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(3, 343);
            panel6.Name = "panel6";
            panel6.Size = new Size(626, 79);
            panel6.TabIndex = 7;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(502, 51);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(121, 29);
            checkBox5.TabIndex = 14;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Dock = DockStyle.Bottom;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(0, 41);
            label9.Name = "label9";
            label9.Size = new Size(151, 38);
            label9.TabIndex = 12;
            label9.Text = "Auto Close";
            // 
            // panel5
            // 
            panel5.Controls.Add(checkBox4);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(3, 258);
            panel5.Name = "panel5";
            panel5.Size = new Size(626, 79);
            panel5.TabIndex = 5;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(502, 51);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(121, 29);
            checkBox4.TabIndex = 13;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Dock = DockStyle.Bottom;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(0, 41);
            label8.Name = "label8";
            label8.Size = new Size(199, 38);
            label8.TabIndex = 11;
            label8.Text = "Network Boost";
            // 
            // panel4
            // 
            panel4.Controls.Add(checkBox3);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(3, 173);
            panel4.Name = "panel4";
            panel4.Size = new Size(626, 79);
            panel4.TabIndex = 3;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(502, 51);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(121, 29);
            checkBox3.TabIndex = 12;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Dock = DockStyle.Bottom;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(0, 41);
            label7.Name = "label7";
            label7.Size = new Size(201, 38);
            label7.TabIndex = 10;
            label7.Text = "GPU Overclock";
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(626, 79);
            panel2.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(502, 51);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(0, 34);
            label5.Name = "label5";
            label5.Size = new Size(196, 45);
            label5.TabIndex = 8;
            label5.Text = "Legion Edge";
            // 
            // panel3
            // 
            panel3.Controls.Add(checkBox2);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(3, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(626, 79);
            panel3.TabIndex = 1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(502, 51);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 29);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(0, 41);
            label6.Name = "label6";
            label6.Size = new Size(198, 38);
            label6.TabIndex = 9;
            label6.Text = "Thermal Mode";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Bottom;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Transparent;
            label13.Location = new Point(3, 756);
            label13.Name = "label13";
            label13.Size = new Size(632, 45);
            label13.TabIndex = 1;
            label13.Text = "Quick Settings";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.DarkSlateGray;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel11, 0, 2);
            tableLayoutPanel1.Controls.Add(panel10, 0, 0);
            tableLayoutPanel1.Controls.Add(panel12, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 804);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(632, 339);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel11
            // 
            panel11.Controls.Add(checkBox11);
            panel11.Controls.Add(label16);
            panel11.Location = new Point(3, 228);
            panel11.Name = "panel11";
            panel11.Size = new Size(626, 100);
            panel11.TabIndex = 3;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(502, 77);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(131, 29);
            checkBox11.TabIndex = 18;
            checkBox11.Text = "checkBox11";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Dock = DockStyle.Bottom;
            label16.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Transparent;
            label16.Location = new Point(0, 62);
            label16.Name = "label16";
            label16.Size = new Size(276, 38);
            label16.TabIndex = 16;
            label16.Text = "Adaptive refresh rate";
            // 
            // panel10
            // 
            panel10.Controls.Add(checkBox9);
            panel10.Controls.Add(label14);
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(626, 106);
            panel10.TabIndex = 1;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(502, 77);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(121, 29);
            checkBox9.TabIndex = 18;
            checkBox9.Text = "checkBox9";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Dock = DockStyle.Bottom;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(0, 68);
            label14.Name = "label14";
            label14.Size = new Size(175, 38);
            label14.TabIndex = 16;
            label14.Text = "RapidCharge";
            // 
            // panel12
            // 
            panel12.Controls.Add(checkBox10);
            panel12.Controls.Add(label15);
            panel12.Location = new Point(3, 115);
            panel12.Name = "panel12";
            panel12.Size = new Size(626, 107);
            panel12.TabIndex = 4;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(502, 77);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(131, 29);
            checkBox10.TabIndex = 18;
            checkBox10.Text = "checkBox10";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Dock = DockStyle.Bottom;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(0, 69);
            label15.Name = "label15";
            label15.Size = new Size(178, 38);
            label15.TabIndex = 16;
            label15.Text = "WiFi Security";
            // 
            // LenovoUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1873, 1176);
            Controls.Add(mainPanel);
            ForeColor = SystemColors.ControlText;
            Name = "LenovoUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LenovoUI";
            mainPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            gpuPanel.ResumeLayout(false);
            gpuPanel.PerformLayout();
            firstLeftPanel.ResumeLayout(false);
            firstLeftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            firstRightPanel.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
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
        private Panel panel1;
        private Label label4;
        private Button button8;
        private TableLayoutPanel firstRightPanel;
        private TableLayoutPanel rightPanel;
        private Label label5;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel11;
        private Label label16;
        private Panel panel10;
        private Label label14;
        private Panel panel12;
        private Label label15;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox11;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private Button button2;
        private ToolTip toolTip1;
    }
}
