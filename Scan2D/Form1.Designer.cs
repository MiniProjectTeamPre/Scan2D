namespace Scan2D {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_teamSn1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.digitSnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digit_sn = new System.Windows.Forms.ToolStripMenuItem();
            this.ctms_customer = new System.Windows.Forms.ToolStripMenuItem();
            this.setFocusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctms_firstHeadBig = new System.Windows.Forms.ToolStripMenuItem();
            this.ctms_nextHeadBig = new System.Windows.Forms.ToolStripMenuItem();
            this.ctms_guiFull = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_teamSn2 = new System.Windows.Forms.TextBox();
            this.tb_teamSn3 = new System.Windows.Forms.TextBox();
            this.tb_teamSn4 = new System.Windows.Forms.TextBox();
            this.cb_head1 = new System.Windows.Forms.CheckBox();
            this.cb_head2 = new System.Windows.Forms.CheckBox();
            this.cb_head3 = new System.Windows.Forms.CheckBox();
            this.cb_head4 = new System.Windows.Forms.CheckBox();
            this.tm_activeForm = new System.Windows.Forms.Timer(this.components);
            this.cb_focus = new System.Windows.Forms.CheckBox();
            this.lb_status1 = new System.Windows.Forms.Label();
            this.lb_status2 = new System.Windows.Forms.Label();
            this.lb_status3 = new System.Windows.Forms.Label();
            this.lb_status4 = new System.Windows.Forms.Label();
            this.tb_nullSup = new System.Windows.Forms.TextBox();
            this.tb_customerSn1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_customerSn2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_customerSn3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_customerSn4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_customerSn5 = new System.Windows.Forms.TextBox();
            this.lb_status5 = new System.Windows.Forms.Label();
            this.cb_head5 = new System.Windows.Forms.CheckBox();
            this.tb_teamSn5 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_teamSn1
            // 
            this.tb_teamSn1.BackColor = System.Drawing.Color.White;
            this.tb_teamSn1.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_teamSn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_teamSn1.Location = new System.Drawing.Point(12, 47);
            this.tb_teamSn1.Name = "tb_teamSn1";
            this.tb_teamSn1.Size = new System.Drawing.Size(204, 31);
            this.tb_teamSn1.TabIndex = 0;
            this.tb_teamSn1.Click += new System.EventHandler(this.FocusTextBox_Click);
            this.tb_teamSn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_teamSn1_KeyDown);
            this.tb_teamSn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_teamSn1_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.digitSnToolStripMenuItem,
            this.ctms_customer,
            this.setFocusToolStripMenuItem,
            this.ctms_guiFull});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 92);
            // 
            // digitSnToolStripMenuItem
            // 
            this.digitSnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.digit_sn});
            this.digitSnToolStripMenuItem.Name = "digitSnToolStripMenuItem";
            this.digitSnToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.digitSnToolStripMenuItem.Text = "digit sn";
            // 
            // digit_sn
            // 
            this.digit_sn.Name = "digit_sn";
            this.digit_sn.Size = new System.Drawing.Size(86, 22);
            this.digit_sn.Text = "15";
            this.digit_sn.Click += new System.EventHandler(this.digit_sn_Click);
            // 
            // ctms_customer
            // 
            this.ctms_customer.CheckOnClick = true;
            this.ctms_customer.Name = "ctms_customer";
            this.ctms_customer.Size = new System.Drawing.Size(126, 22);
            this.ctms_customer.Text = "Customer";
            this.ctms_customer.Click += new System.EventHandler(this.ctms_customer_Click);
            // 
            // setFocusToolStripMenuItem
            // 
            this.setFocusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctms_firstHeadBig,
            this.ctms_nextHeadBig});
            this.setFocusToolStripMenuItem.Name = "setFocusToolStripMenuItem";
            this.setFocusToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.setFocusToolStripMenuItem.Text = "Set Focus";
            // 
            // ctms_firstHeadBig
            // 
            this.ctms_firstHeadBig.Name = "ctms_firstHeadBig";
            this.ctms_firstHeadBig.Size = new System.Drawing.Size(144, 22);
            this.ctms_firstHeadBig.Text = "FirstHeadBig";
            this.ctms_firstHeadBig.Click += new System.EventHandler(this.ctms_firstHeadBig_Click);
            // 
            // ctms_nextHeadBig
            // 
            this.ctms_nextHeadBig.Name = "ctms_nextHeadBig";
            this.ctms_nextHeadBig.Size = new System.Drawing.Size(144, 22);
            this.ctms_nextHeadBig.Text = "NextHeadBig";
            this.ctms_nextHeadBig.Click += new System.EventHandler(this.ctms_nextHeadBig_Click);
            // 
            // ctms_guiFull
            // 
            this.ctms_guiFull.Name = "ctms_guiFull";
            this.ctms_guiFull.Size = new System.Drawing.Size(126, 22);
            this.ctms_guiFull.Text = "Gui Full";
            this.ctms_guiFull.Click += new System.EventHandler(this.ctms_guiFull_Click);
            // 
            // tb_teamSn2
            // 
            this.tb_teamSn2.BackColor = System.Drawing.Color.White;
            this.tb_teamSn2.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_teamSn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_teamSn2.Location = new System.Drawing.Point(279, 47);
            this.tb_teamSn2.Name = "tb_teamSn2";
            this.tb_teamSn2.Size = new System.Drawing.Size(204, 31);
            this.tb_teamSn2.TabIndex = 1;
            this.tb_teamSn2.Click += new System.EventHandler(this.FocusTextBox_Click);
            this.tb_teamSn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_teamSn2_KeyDown);
            this.tb_teamSn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_teamSn2_KeyPress);
            // 
            // tb_teamSn3
            // 
            this.tb_teamSn3.BackColor = System.Drawing.Color.White;
            this.tb_teamSn3.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_teamSn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_teamSn3.Location = new System.Drawing.Point(557, 47);
            this.tb_teamSn3.Name = "tb_teamSn3";
            this.tb_teamSn3.Size = new System.Drawing.Size(204, 31);
            this.tb_teamSn3.TabIndex = 2;
            this.tb_teamSn3.Click += new System.EventHandler(this.FocusTextBox_Click);
            this.tb_teamSn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_teamSn3_KeyDown);
            this.tb_teamSn3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_teamSn3_KeyPress);
            // 
            // tb_teamSn4
            // 
            this.tb_teamSn4.BackColor = System.Drawing.Color.White;
            this.tb_teamSn4.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_teamSn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_teamSn4.Location = new System.Drawing.Point(828, 47);
            this.tb_teamSn4.Name = "tb_teamSn4";
            this.tb_teamSn4.Size = new System.Drawing.Size(204, 31);
            this.tb_teamSn4.TabIndex = 3;
            this.tb_teamSn4.Click += new System.EventHandler(this.FocusTextBox_Click);
            this.tb_teamSn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_teamSn4_KeyDown);
            this.tb_teamSn4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_teamSn4_KeyPress);
            // 
            // cb_head1
            // 
            this.cb_head1.AutoSize = true;
            this.cb_head1.Checked = true;
            this.cb_head1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_head1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_head1.ForeColor = System.Drawing.Color.Black;
            this.cb_head1.Location = new System.Drawing.Point(12, 12);
            this.cb_head1.Name = "cb_head1";
            this.cb_head1.Size = new System.Drawing.Size(118, 28);
            this.cb_head1.TabIndex = 4;
            this.cb_head1.Text = "TeamSn1";
            this.cb_head1.UseVisualStyleBackColor = true;
            this.cb_head1.Click += new System.EventHandler(this.cb_head1_Click);
            // 
            // cb_head2
            // 
            this.cb_head2.AutoSize = true;
            this.cb_head2.Checked = true;
            this.cb_head2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_head2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_head2.ForeColor = System.Drawing.Color.Black;
            this.cb_head2.Location = new System.Drawing.Point(279, 12);
            this.cb_head2.Name = "cb_head2";
            this.cb_head2.Size = new System.Drawing.Size(118, 28);
            this.cb_head2.TabIndex = 5;
            this.cb_head2.Text = "TeamSn2";
            this.cb_head2.UseVisualStyleBackColor = true;
            this.cb_head2.Click += new System.EventHandler(this.cb_head2_Click);
            // 
            // cb_head3
            // 
            this.cb_head3.AutoSize = true;
            this.cb_head3.Checked = true;
            this.cb_head3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_head3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_head3.ForeColor = System.Drawing.Color.Black;
            this.cb_head3.Location = new System.Drawing.Point(557, 12);
            this.cb_head3.Name = "cb_head3";
            this.cb_head3.Size = new System.Drawing.Size(118, 28);
            this.cb_head3.TabIndex = 6;
            this.cb_head3.Text = "TeamSn3";
            this.cb_head3.UseVisualStyleBackColor = true;
            this.cb_head3.Click += new System.EventHandler(this.cb_head3_Click);
            // 
            // cb_head4
            // 
            this.cb_head4.AutoSize = true;
            this.cb_head4.Checked = true;
            this.cb_head4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_head4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_head4.ForeColor = System.Drawing.Color.Black;
            this.cb_head4.Location = new System.Drawing.Point(828, 12);
            this.cb_head4.Name = "cb_head4";
            this.cb_head4.Size = new System.Drawing.Size(118, 28);
            this.cb_head4.TabIndex = 7;
            this.cb_head4.Text = "TeamSn4";
            this.cb_head4.UseVisualStyleBackColor = true;
            this.cb_head4.Click += new System.EventHandler(this.cb_head4_Click);
            // 
            // tm_activeForm
            // 
            this.tm_activeForm.Enabled = true;
            this.tm_activeForm.Interval = 250;
            this.tm_activeForm.Tick += new System.EventHandler(this.tm_activeForm_Tick);
            // 
            // cb_focus
            // 
            this.cb_focus.AutoSize = true;
            this.cb_focus.Checked = true;
            this.cb_focus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_focus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_focus.ForeColor = System.Drawing.Color.Black;
            this.cb_focus.Location = new System.Drawing.Point(1244, 225);
            this.cb_focus.Name = "cb_focus";
            this.cb_focus.Size = new System.Drawing.Size(63, 20);
            this.cb_focus.TabIndex = 8;
            this.cb_focus.Text = "Focus";
            this.cb_focus.UseVisualStyleBackColor = true;
            // 
            // lb_status1
            // 
            this.lb_status1.AutoSize = true;
            this.lb_status1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_status1.Location = new System.Drawing.Point(127, 13);
            this.lb_status1.Name = "lb_status1";
            this.lb_status1.Size = new System.Drawing.Size(76, 25);
            this.lb_status1.TabIndex = 9;
            this.lb_status1.Text = "label1";
            // 
            // lb_status2
            // 
            this.lb_status2.AutoSize = true;
            this.lb_status2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_status2.Location = new System.Drawing.Point(394, 13);
            this.lb_status2.Name = "lb_status2";
            this.lb_status2.Size = new System.Drawing.Size(76, 25);
            this.lb_status2.TabIndex = 10;
            this.lb_status2.Text = "label2";
            // 
            // lb_status3
            // 
            this.lb_status3.AutoSize = true;
            this.lb_status3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_status3.Location = new System.Drawing.Point(672, 13);
            this.lb_status3.Name = "lb_status3";
            this.lb_status3.Size = new System.Drawing.Size(76, 25);
            this.lb_status3.TabIndex = 11;
            this.lb_status3.Text = "label3";
            // 
            // lb_status4
            // 
            this.lb_status4.AutoSize = true;
            this.lb_status4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status4.Location = new System.Drawing.Point(941, 13);
            this.lb_status4.Name = "lb_status4";
            this.lb_status4.Size = new System.Drawing.Size(76, 25);
            this.lb_status4.TabIndex = 12;
            this.lb_status4.Text = "label4";
            // 
            // tb_nullSup
            // 
            this.tb_nullSup.BackColor = System.Drawing.Color.White;
            this.tb_nullSup.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_nullSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_nullSup.Location = new System.Drawing.Point(427, 258);
            this.tb_nullSup.Name = "tb_nullSup";
            this.tb_nullSup.Size = new System.Drawing.Size(204, 31);
            this.tb_nullSup.TabIndex = 13;
            // 
            // tb_customerSn1
            // 
            this.tb_customerSn1.BackColor = System.Drawing.Color.White;
            this.tb_customerSn1.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_customerSn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_customerSn1.Location = new System.Drawing.Point(12, 137);
            this.tb_customerSn1.Multiline = true;
            this.tb_customerSn1.Name = "tb_customerSn1";
            this.tb_customerSn1.Size = new System.Drawing.Size(204, 82);
            this.tb_customerSn1.TabIndex = 14;
            this.tb_customerSn1.Text = "7984:20288857-0011;3522;10smiln01-e-0;sw02021033;v1-1;c1063";
            this.tb_customerSn1.Click += new System.EventHandler(this.FocusTextBox_Click);
            this.tb_customerSn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_customerSn1_KeyDown);
            this.tb_customerSn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_customerSn1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "CustomerSn1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(279, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "CustomerSn2";
            // 
            // tb_customerSn2
            // 
            this.tb_customerSn2.BackColor = System.Drawing.Color.White;
            this.tb_customerSn2.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_customerSn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_customerSn2.Location = new System.Drawing.Point(279, 137);
            this.tb_customerSn2.Multiline = true;
            this.tb_customerSn2.Name = "tb_customerSn2";
            this.tb_customerSn2.Size = new System.Drawing.Size(204, 82);
            this.tb_customerSn2.TabIndex = 16;
            this.tb_customerSn2.Click += new System.EventHandler(this.FocusTextBox_Click);
            this.tb_customerSn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_customerSn2_KeyDown);
            this.tb_customerSn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_customerSn2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(557, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "CustomerSn3";
            // 
            // tb_customerSn3
            // 
            this.tb_customerSn3.BackColor = System.Drawing.Color.White;
            this.tb_customerSn3.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_customerSn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_customerSn3.Location = new System.Drawing.Point(557, 137);
            this.tb_customerSn3.Multiline = true;
            this.tb_customerSn3.Name = "tb_customerSn3";
            this.tb_customerSn3.Size = new System.Drawing.Size(204, 82);
            this.tb_customerSn3.TabIndex = 18;
            this.tb_customerSn3.Click += new System.EventHandler(this.FocusTextBox_Click);
            this.tb_customerSn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_customerSn3_KeyDown);
            this.tb_customerSn3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_customerSn3_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(828, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "CustomerSn4";
            // 
            // tb_customerSn4
            // 
            this.tb_customerSn4.BackColor = System.Drawing.Color.White;
            this.tb_customerSn4.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_customerSn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_customerSn4.Location = new System.Drawing.Point(828, 137);
            this.tb_customerSn4.Multiline = true;
            this.tb_customerSn4.Name = "tb_customerSn4";
            this.tb_customerSn4.Size = new System.Drawing.Size(204, 82);
            this.tb_customerSn4.TabIndex = 20;
            this.tb_customerSn4.Click += new System.EventHandler(this.FocusTextBox_Click);
            this.tb_customerSn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_customerSn4_KeyDown);
            this.tb_customerSn4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_customerSn4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(1103, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "CustomerSn5";
            // 
            // tb_customerSn5
            // 
            this.tb_customerSn5.BackColor = System.Drawing.Color.White;
            this.tb_customerSn5.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_customerSn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_customerSn5.Location = new System.Drawing.Point(1103, 137);
            this.tb_customerSn5.Multiline = true;
            this.tb_customerSn5.Name = "tb_customerSn5";
            this.tb_customerSn5.Size = new System.Drawing.Size(204, 82);
            this.tb_customerSn5.TabIndex = 25;
            this.tb_customerSn5.Click += new System.EventHandler(this.FocusTextBox_Click);
            this.tb_customerSn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_customerSn5_KeyDown);
            this.tb_customerSn5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_customerSn5_KeyPress);
            // 
            // lb_status5
            // 
            this.lb_status5.AutoSize = true;
            this.lb_status5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status5.Location = new System.Drawing.Point(1216, 13);
            this.lb_status5.Name = "lb_status5";
            this.lb_status5.Size = new System.Drawing.Size(76, 25);
            this.lb_status5.TabIndex = 24;
            this.lb_status5.Text = "label5";
            // 
            // cb_head5
            // 
            this.cb_head5.AutoSize = true;
            this.cb_head5.Checked = true;
            this.cb_head5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_head5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_head5.ForeColor = System.Drawing.Color.Black;
            this.cb_head5.Location = new System.Drawing.Point(1103, 12);
            this.cb_head5.Name = "cb_head5";
            this.cb_head5.Size = new System.Drawing.Size(118, 28);
            this.cb_head5.TabIndex = 23;
            this.cb_head5.Text = "TeamSn5";
            this.cb_head5.UseVisualStyleBackColor = true;
            this.cb_head5.Click += new System.EventHandler(this.cb_head5_Click);
            // 
            // tb_teamSn5
            // 
            this.tb_teamSn5.BackColor = System.Drawing.Color.White;
            this.tb_teamSn5.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_teamSn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_teamSn5.Location = new System.Drawing.Point(1103, 47);
            this.tb_teamSn5.Name = "tb_teamSn5";
            this.tb_teamSn5.Size = new System.Drawing.Size(204, 31);
            this.tb_teamSn5.TabIndex = 22;
            this.tb_teamSn5.Click += new System.EventHandler(this.FocusTextBox_Click);
            this.tb_teamSn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_teamSn5_KeyDown);
            this.tb_teamSn5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_teamSn5_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1339, 250);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_customerSn5);
            this.Controls.Add(this.lb_status5);
            this.Controls.Add(this.cb_head5);
            this.Controls.Add(this.tb_teamSn5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_customerSn4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_customerSn3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_customerSn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_customerSn1);
            this.Controls.Add(this.tb_nullSup);
            this.Controls.Add(this.lb_status4);
            this.Controls.Add(this.lb_status3);
            this.Controls.Add(this.lb_status2);
            this.Controls.Add(this.lb_status1);
            this.Controls.Add(this.cb_focus);
            this.Controls.Add(this.cb_head4);
            this.Controls.Add(this.cb_head3);
            this.Controls.Add(this.cb_head2);
            this.Controls.Add(this.cb_head1);
            this.Controls.Add(this.tb_teamSn4);
            this.Controls.Add(this.tb_teamSn3);
            this.Controls.Add(this.tb_teamSn2);
            this.Controls.Add(this.tb_teamSn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanSn V2024.01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.FocusTextBox_Click);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_teamSn1;
        private System.Windows.Forms.TextBox tb_teamSn2;
        private System.Windows.Forms.TextBox tb_teamSn3;
        private System.Windows.Forms.TextBox tb_teamSn4;
        private System.Windows.Forms.CheckBox cb_head1;
        private System.Windows.Forms.CheckBox cb_head2;
        private System.Windows.Forms.CheckBox cb_head3;
        private System.Windows.Forms.CheckBox cb_head4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem digitSnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digit_sn;
        private System.Windows.Forms.Timer tm_activeForm;
        private System.Windows.Forms.CheckBox cb_focus;
        private System.Windows.Forms.Label lb_status1;
        private System.Windows.Forms.Label lb_status2;
        private System.Windows.Forms.Label lb_status3;
        private System.Windows.Forms.Label lb_status4;
        private System.Windows.Forms.TextBox tb_nullSup;
        private System.Windows.Forms.TextBox tb_customerSn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_customerSn2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_customerSn3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_customerSn4;
        private System.Windows.Forms.ToolStripMenuItem ctms_customer;
        private System.Windows.Forms.ToolStripMenuItem ctms_guiFull;
        private System.Windows.Forms.ToolStripMenuItem setFocusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctms_firstHeadBig;
        private System.Windows.Forms.ToolStripMenuItem ctms_nextHeadBig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_customerSn5;
        private System.Windows.Forms.Label lb_status5;
        private System.Windows.Forms.CheckBox cb_head5;
        private System.Windows.Forms.TextBox tb_teamSn5;
    }
}

