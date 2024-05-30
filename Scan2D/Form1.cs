using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scan2D {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            
        }

        public Customer customer = new Customer();
        public TeamSN teamSN = new TeamSN();
        public Global global = new Global();
        public Config config = new Config();
        private ResizeAuto resizeAuto;
        private Stopwatch focusTime = new Stopwatch();

        private void Form1_Load(object sender, EventArgs e) {
            GetConfig();
            SetStatus();
            SetGui();
            SetVisable();
            ClearFile();
            ClearStatus();
            FocusTextBoxFirst();
            resizeAuto = new ResizeAuto(this);
            resizeAuto.Initial();
        }

        #region =============================================== Function ===============================================
        private void GetConfig() {
            cb_head1.Checked = Convert.ToBoolean(GetValueInFileConfig(config.head1));
            cb_head2.Checked = Convert.ToBoolean(GetValueInFileConfig(config.head2));
            cb_head3.Checked = Convert.ToBoolean(GetValueInFileConfig(config.head3));
            cb_head4.Checked = Convert.ToBoolean(GetValueInFileConfig(config.head4));
            cb_head5.Checked = Convert.ToBoolean(GetValueInFileConfig(config.head5));
            global.digit = Convert.ToInt32(GetValueInFileConfig(config.digit));
            digit_sn.Text = global.digit.ToString();
            global.customer = Convert.ToBoolean(GetValueInFileConfig(config.customer));
            ctms_customer.Checked = global.customer;
            global.setFocusType = GetValueInFileConfig(config.setFocus);
            if (global.setFocusType == Config.SetFocus.firstHeadBig) {
                ctms_firstHeadBig.Checked = true;
            }
            if (global.setFocusType == Config.SetFocus.nextHeadBig) {
                ctms_nextHeadBig.Checked = true;
            }

            if (!cb_head1.Checked && !cb_head2.Checked && !cb_head3.Checked && !cb_head4.Checked && !cb_head5.Checked)
            {
                cb_head1.Checked = true;
                SetValueInFileConfig(config.head1, cb_head1.Checked.ToString());
            }
        }
        private void SetStatus() {
            if (cb_head1.Checked) {
                tb_teamSn1.MaxLength = global.digit;
                teamSN.sn1 = false;
                if (global.customer) {
                    customer.sn1 = false;
                }
            } else {
                tb_teamSn1.Enabled = false;
                tb_teamSn1.Visible = false;
                tb_customerSn1.Enabled = false;
                tb_customerSn1.Visible = false;
            }

            if (cb_head2.Checked) {
                tb_teamSn2.MaxLength = global.digit;
                teamSN.sn2 = false;
                if (global.customer) {
                    customer.sn2 = false;
                }
            } else {
                tb_teamSn2.Enabled = false;
                tb_teamSn2.Visible = false;
                tb_customerSn2.Enabled = false;
                tb_customerSn2.Visible = false;
            }

            if (cb_head3.Checked) {
                tb_teamSn3.MaxLength = global.digit;
                teamSN.sn3 = false;
                if (global.customer) {
                    customer.sn3 = false;
                }
            } else {
                tb_teamSn3.Enabled = false;
                tb_teamSn3.Visible = false;
                tb_customerSn3.Enabled = false;
                tb_customerSn3.Visible = false;
            }

            if (cb_head4.Checked) {
                tb_teamSn4.MaxLength = global.digit;
                teamSN.sn4 = false;
                if (global.customer) {
                    customer.sn4 = false;
                }
            } else {
                tb_teamSn4.Enabled = false;
                tb_teamSn4.Visible = false;
                tb_customerSn4.Enabled = false;
                tb_customerSn4.Visible = false;
            }

            if (cb_head5.Checked)
            {
                tb_teamSn5.MaxLength = global.digit;
                teamSN.sn5 = false;
                if (global.customer)
                {
                    customer.sn5 = false;
                }
            }
            else
            {
                tb_teamSn5.Enabled = false;
                tb_teamSn5.Visible = false;
                tb_customerSn5.Enabled = false;
                tb_customerSn5.Visible = false;
            }
        }
        private void SetGui() {
            if (cb_head5.Checked)
            {
                if (global.customer)
                {
                    this.Size = new Size(1335, 288);
                    cb_focus.Location = new Point(1250, 225);
                }
                else
                {
                    this.Size = new Size(1335, 147);
                    cb_focus.Location = new Point(1250, 84);
                }
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                return;
            }

            if (cb_head4.Checked) {
                if (global.customer) {
                    this.Size = new Size(1057, 288);
                    cb_focus.Location = new Point(968, 225);
                } else {
                    this.Size = new Size(1057, 147);
                    cb_focus.Location = new Point(968, 84);
                }
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                return;
            }

            if (cb_head3.Checked) {
                if (global.customer) {
                    this.Size = new Size(789, 288);
                    cb_focus.Location = new Point(697, 225);
                } else {
                    this.Size = new Size(789, 147);
                    cb_focus.Location = new Point(697, 84);
                }
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                return;
            }

            if (cb_head2.Checked) {
                if (global.customer) {
                    this.Size = new Size(510, 288);
                    cb_focus.Location = new Point(419, 225);
                } else {
                    this.Size = new Size(510, 147);
                    cb_focus.Location = new Point(419, 84);
                }
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                return;
            }

            if (cb_head1.Checked) {
                if (global.customer) {
                    this.Size = new Size(244, 288);
                    cb_focus.Location = new Point(152, 225);
                } else {
                    this.Size = new Size(244, 147);
                    cb_focus.Location = new Point(152, 84);
                }
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                return;
            }
        }
        private void SetVisable() {
            if (!cb_head1.Checked)
            {
                cb_head1.Visible = false;
                lb_status1.Visible = false;
                tb_teamSn1.Visible = false;
                label1.Visible = false;
                tb_customerSn1.Visible = false;
            }
            if (!cb_head2.Checked)
            {
                cb_head2.Visible = false;
                lb_status2.Visible = false;
                tb_teamSn2.Visible = false;
                label2.Visible = false;
                tb_customerSn2.Visible = false;
            }
            if (!cb_head3.Checked)
            {
                cb_head3.Visible = false;
                lb_status3.Visible = false;
                tb_teamSn3.Visible = false;
                label3.Visible = false;
                tb_customerSn3.Visible = false;
            }
            if (!cb_head4.Checked)
            {
                cb_head4.Visible = false;
                lb_status4.Visible = false;
                tb_teamSn4.Visible = false;
                label4.Visible = false;
                tb_customerSn4.Visible = false;
            }
            if (!cb_head5.Checked)
            {
                cb_head5.Visible = false;
                lb_status5.Visible = false;
                tb_teamSn5.Visible = false;
                label5.Visible = false;
                tb_customerSn5.Visible = false;
            }
            if (!global.customer)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                tb_customerSn1.Visible = false;
                tb_customerSn2.Visible = false;
                tb_customerSn3.Visible = false;
                tb_customerSn4.Visible = false;
                tb_customerSn5.Visible = false;
            }
        }
        private string GetValueInFileConfig(string row) {
            string result = string.Empty;
            string[] dataConfig = File.ReadAllLines(config.path);

            foreach (string data in dataConfig) {
                string[] dataSplit = data.Split(',');

                if (row != dataSplit[0]) {
                    continue;
                }

                result = dataSplit[1];
                break;
            }

            return result;
        }
        private void SetValueInFileConfig(string row, string dataSave) {
            string[] dataConfig = File.ReadAllLines(config.path);

            for (int loop = 0; loop < dataConfig.Length; loop++) {
                string[] dataSplit = dataConfig[loop].Split(',');

                if (row != dataSplit[0]) {
                    continue;
                }

                dataConfig[loop] = dataSplit[0] + "," + dataSave;
                break;
            }

            File.WriteAllLines(config.path, dataConfig);
        }
        private void ClearFile() {
            File.Delete(Path.sn1);
            File.Delete(Path.sn2);
            File.Delete(Path.sn3);
            File.Delete(Path.sn4);
            File.Delete(Path.sn5);
            File.Delete(Path.clearSn1);
            File.Delete(Path.clearSn2);
            File.Delete(Path.clearSn3);
            File.Delete(Path.clearSn4);
            File.Delete(Path.clearSn5);
        }
        private void ClearStatus() {
            lb_status1.Text = string.Empty;
            lb_status2.Text = string.Empty;
            lb_status3.Text = string.Empty;
            lb_status4.Text = string.Empty;
            lb_status5.Text = string.Empty;
            tb_customerSn1.Text = string.Empty;
            tb_customerSn2.Text = string.Empty;
            tb_customerSn3.Text = string.Empty;
            tb_customerSn4.Text = string.Empty;
            tb_customerSn5.Text = string.Empty;
            lb_status1.Text = string.Empty;
            lb_status2.Text = string.Empty;
            lb_status3.Text = string.Empty;
            lb_status4.Text = string.Empty;
            lb_status5.Text = string.Empty;
        }

        private bool CheckDigit(TextBox textBox) {
            if (textBox.Text.Length != global.digit) {
                cb_focus.Checked = false;
                MessageBox.Show("Digit Not " + global.digit);
                cb_focus.Checked = true;
                textBox.Text = string.Empty;
                return false;
            }

            return true;
        }
        private void FocusTextBoxFirst() {
            tb_teamSn1.BackColor = Color.White;
            tb_teamSn2.BackColor = Color.White;
            tb_teamSn3.BackColor = Color.White;
            tb_teamSn4.BackColor = Color.White;
            tb_teamSn5.BackColor = Color.White;

            if (global.customer) {
                tb_customerSn1.BackColor = Color.White;
                tb_customerSn2.BackColor = Color.White;
                tb_customerSn3.BackColor = Color.White;
                tb_customerSn4.BackColor = Color.White;
                tb_customerSn5.BackColor = Color.White;
            }

            if (!teamSN.sn1 && global.lockFocusCustomer == 0 && cb_head1.Checked) {
                tb_teamSn1.Focus();
                tb_teamSn1.BackColor = Color.Aqua;
                FocusTextBoxSup(1);
                return;
            }

            if (!customer.sn1 && global.lockFocusCustomer == 1) {
                tb_customerSn1.Focus();
                tb_customerSn1.BackColor = Color.Aqua;
                global.lockFocusCustomer = 0;
                return;
            }

            if (!teamSN.sn2 && global.lockFocusCustomer == 0 && cb_head2.Checked) {
                tb_teamSn2.Focus();
                tb_teamSn2.BackColor = Color.Aqua;
                FocusTextBoxSup(2);
                return;
            }

            if (!customer.sn2 && global.lockFocusCustomer == 2) {
                tb_customerSn2.Focus();
                tb_customerSn2.BackColor = Color.Aqua;
                global.lockFocusCustomer = 0;
                return;
            }

            if (!teamSN.sn3 && global.lockFocusCustomer == 0 && cb_head3.Checked) {
                tb_teamSn3.Focus();
                tb_teamSn3.BackColor = Color.Aqua;
                FocusTextBoxSup(3);
                return;
            }

            if (!customer.sn3 && global.lockFocusCustomer == 3) {
                tb_customerSn3.Focus();
                tb_customerSn3.BackColor = Color.Aqua;
                global.lockFocusCustomer = 0;
                return;
            }

            if (!teamSN.sn4 && global.lockFocusCustomer == 0 && cb_head4.Checked) {
                tb_teamSn4.Focus();
                tb_teamSn4.BackColor = Color.Aqua;
                FocusTextBoxSup(4);
                return;
            }

            if (!customer.sn4 && global.lockFocusCustomer == 4) {
                tb_customerSn4.Focus();
                tb_customerSn4.BackColor = Color.Aqua;
                global.lockFocusCustomer = 0;
                return;
            }

            if (!teamSN.sn5 && global.lockFocusCustomer == 0 && cb_head5.Checked)
            {
                tb_teamSn5.Focus();
                tb_teamSn5.BackColor = Color.Aqua;
                FocusTextBoxSup(5);
                return;
            }

            if (!customer.sn5 && global.lockFocusCustomer == 5)
            {
                tb_customerSn5.Focus();
                tb_customerSn5.BackColor = Color.Aqua;
                global.lockFocusCustomer = 0;
                return;
            }
        }
        private void FocusTextBoxSup(int head) {
            if (!global.customer) {
                global.lockFocusCustomer = 0;
            } else {
                switch (head) {
                    case 1:
                        global.lockFocusCustomer = 1;
                        break;
                    case 2:
                        global.lockFocusCustomer = 2;
                        break;
                    case 3:
                        global.lockFocusCustomer = 3;
                        break;
                    case 4:
                        global.lockFocusCustomer = 4;
                        break;
                    case 5:
                        global.lockFocusCustomer = 5;
                        break;
                }
            }
        }
        private void FocusTextBoxNext(int head) {
            FocusTextBoxClear();

            switch (head) {
                case 1:
                    if (FocusTextBoxHead1()) return;
                    if (FocusTextBoxHead2()) return;
                    if (FocusTextBoxHead3()) return;
                    if (FocusTextBoxHead4()) return;
                    if (FocusTextBoxHead5()) return;
                    break;
                case 2:
                    if (FocusTextBoxHead2()) return;
                    if (FocusTextBoxHead3()) return;
                    if (FocusTextBoxHead4()) return;
                    if (FocusTextBoxHead5()) return;
                    if (FocusTextBoxHead1()) return;
                    break;
                case 3:
                    if (FocusTextBoxHead3()) return;
                    if (FocusTextBoxHead4()) return;
                    if (FocusTextBoxHead5()) return;
                    if (FocusTextBoxHead1()) return;
                    if (FocusTextBoxHead2()) return;
                    break;
                case 4:
                    if (FocusTextBoxHead4()) return;
                    if (FocusTextBoxHead5()) return;
                    if (FocusTextBoxHead1()) return;
                    if (FocusTextBoxHead2()) return;
                    if (FocusTextBoxHead3()) return;
                    break;
                case 5:
                    if (FocusTextBoxHead5()) return;
                    if (FocusTextBoxHead1()) return;
                    if (FocusTextBoxHead2()) return;
                    if (FocusTextBoxHead3()) return;
                    if (FocusTextBoxHead4()) return;
                    break;
            }
            
        }
        private void FocusTextBoxClear() {
            tb_teamSn1.BackColor = Color.White;
            tb_teamSn2.BackColor = Color.White;
            tb_teamSn3.BackColor = Color.White;
            tb_teamSn4.BackColor = Color.White;
            tb_teamSn5.BackColor = Color.White;

            if (global.customer) {
                tb_customerSn1.BackColor = Color.White;
                tb_customerSn2.BackColor = Color.White;
                tb_customerSn3.BackColor = Color.White;
                tb_customerSn4.BackColor = Color.White;
                tb_customerSn5.BackColor = Color.White;
            }
        }
        private bool FocusTextBoxHead1() {
            if (!teamSN.sn1 && global.lockFocusCustomer == 0 && cb_head1.Checked) {
                tb_teamSn1.Focus();
                tb_teamSn1.BackColor = Color.Aqua;
                FocusTextBoxSup(1);
                return true;
            }

            if (!customer.sn1 && global.lockFocusCustomer == 1) {
                tb_customerSn1.Focus();
                tb_customerSn1.BackColor = Color.Aqua;
                global.lockFocusCustomer = 0;
                return true;
            }

            return false;
        }
        private bool FocusTextBoxHead2() {
            if (!teamSN.sn2 && global.lockFocusCustomer == 0 && cb_head2.Checked) {
                tb_teamSn2.Focus();
                tb_teamSn2.BackColor = Color.Aqua;
                FocusTextBoxSup(2);
                return true;
            }

            if (!customer.sn2 && global.lockFocusCustomer == 2) {
                tb_customerSn2.Focus();
                tb_customerSn2.BackColor = Color.Aqua;
                global.lockFocusCustomer = 0;
                return true;
            }

            return false;
        }
        private bool FocusTextBoxHead3() {
            if (!teamSN.sn3 && global.lockFocusCustomer == 0 && cb_head3.Checked) {
                tb_teamSn3.Focus();
                tb_teamSn3.BackColor = Color.Aqua;
                FocusTextBoxSup(3);
                return true;
            }

            if (!customer.sn3 && global.lockFocusCustomer == 3) {
                tb_customerSn3.Focus();
                tb_customerSn3.BackColor = Color.Aqua;
                global.lockFocusCustomer = 0;
                return true;
            }

            return false;
        }
        private bool FocusTextBoxHead4() {
            if (!teamSN.sn4 && global.lockFocusCustomer == 0 && cb_head4.Checked) {
                tb_teamSn4.Focus();
                tb_teamSn4.BackColor = Color.Aqua;
                FocusTextBoxSup(4);
                return true;
            }

            if (!customer.sn4 && global.lockFocusCustomer == 4) {
                tb_customerSn4.Focus();
                tb_customerSn4.BackColor = Color.Aqua;
                global.lockFocusCustomer = 0;
                return true;
            }

            return false;
        }
        private bool FocusTextBoxHead5() {
            if (!teamSN.sn5 && global.lockFocusCustomer == 0 && cb_head5.Checked)
            {
                tb_teamSn5.Focus();
                tb_teamSn5.BackColor = Color.Aqua;
                FocusTextBoxSup(5);
                return true;
            }

            if (!customer.sn5 && global.lockFocusCustomer == 5)
            {
                tb_customerSn5.Focus();
                tb_customerSn5.BackColor = Color.Aqua;
                global.lockFocusCustomer = 0;
                return true;
            }

            return false;
        }

        private void ReadFile() {
            if (focusTime.ElapsedMilliseconds >= 50000)
            {
                focusTime.Stop();
                try
                {
                    File.ReadAllText(Path.focusTrue);
                    File.Delete(Path.focusTrue);
                    cb_focus.Checked = true;
                    this.WindowState = FormWindowState.Normal;
                } catch { }
            }

            try
            {
                File.ReadAllText(Path.focusFalse);
                File.Delete(Path.focusFalse);
                cb_focus.Checked = false;
                this.WindowState = FormWindowState.Minimized;
                focusTime.Restart();
            } catch { }

            if (cb_head1.Checked) {
                try {
                    File.ReadAllText(Path.clearSn1);
                    File.Delete(Path.clearSn1);
                    tb_teamSn1.Text = string.Empty;
                    lb_status1.Text = string.Empty;
                    tb_customerSn1.Text = string.Empty;
                    tb_teamSn1.Enabled = true;
                    tb_customerSn1.Enabled = true;
                    //if (CheckFocusTextBox()) {
                    //    teamSN.sn1 = false;
                    //    customer.sn1 = false;
                    //    FocusTextBoxFirst();
                    //}
                    teamSN.sn1 = false;
                    customer.sn1 = false;
                    if (CheckFocusTextBoxNew(1))
                    {
                        if (global.setFocusType == Config.SetFocus.firstHeadBig)
                        {
                            FocusTextBoxFirst();
                        }
                        else
                        {
                            FocusTextBoxNext(1);
                        }
                    }
                } catch { }
            }

            if (cb_head2.Checked) {
                try {
                    File.ReadAllText(Path.clearSn2);
                    File.Delete(Path.clearSn2);
                    tb_teamSn2.Text = string.Empty;
                    lb_status2.Text = string.Empty;
                    tb_customerSn2.Text = string.Empty;
                    tb_teamSn2.Enabled = true;
                    tb_customerSn2.Enabled = true;
                    //if (CheckFocusTextBox()) {
                    //    teamSN.sn2 = false;
                    //    customer.sn2 = false;
                    //    FocusTextBoxFirst();
                    //}
                    teamSN.sn2 = false;
                    customer.sn2 = false;
                    if (CheckFocusTextBoxNew(2))
                    {
                        if (global.setFocusType == Config.SetFocus.firstHeadBig)
                        {
                            FocusTextBoxFirst();
                        }
                        else
                        {
                            FocusTextBoxNext(2);
                        }
                    }
                } catch { }
            }

            if (cb_head3.Checked) {
                try {
                    File.ReadAllText(Path.clearSn3);
                    File.Delete(Path.clearSn3);
                    tb_teamSn3.Text = string.Empty;
                    lb_status3.Text = string.Empty;
                    tb_customerSn3.Text = string.Empty;
                    tb_teamSn3.Enabled = true;
                    tb_customerSn3.Enabled = true;
                    //if (CheckFocusTextBox()) {
                    //    teamSN.sn3 = false;
                    //    customer.sn3 = false;
                    //    FocusTextBoxFirst();
                    //}
                    teamSN.sn3 = false;
                    customer.sn3 = false;
                    if (CheckFocusTextBoxNew(3))
                    {
                        if (global.setFocusType == Config.SetFocus.firstHeadBig)
                        {
                            FocusTextBoxFirst();
                        }
                        else
                        {
                            FocusTextBoxNext(3);
                        }
                    }
                } catch { }
            }
            
            if (cb_head4.Checked) {
                try {
                    File.ReadAllText(Path.clearSn4);
                    File.Delete(Path.clearSn4);
                    tb_teamSn4.Text = string.Empty;
                    lb_status4.Text = string.Empty;
                    tb_customerSn4.Text = string.Empty;
                    tb_teamSn4.Enabled = true;
                    tb_customerSn4.Enabled = true;
                    //if (CheckFocusTextBox()) {
                    //    teamSN.sn4 = false;
                    //    customer.sn4 = false;
                    //    FocusTextBoxFirst();
                    //}
                    teamSN.sn4 = false;
                    customer.sn4 = false;
                    if (CheckFocusTextBoxNew(4))
                    {
                        if (global.setFocusType == Config.SetFocus.firstHeadBig)
                        {
                            FocusTextBoxFirst();
                        }
                        else
                        {
                            FocusTextBoxNext(4);
                        }
                    }
                } catch { }
            }

            if (cb_head5.Checked)
            {
                try
                {
                    File.ReadAllText(Path.clearSn5);
                    File.Delete(Path.clearSn5);
                    tb_teamSn5.Text = string.Empty;
                    lb_status5.Text = string.Empty;
                    tb_customerSn5.Text = string.Empty;
                    tb_teamSn5.Enabled = true;
                    tb_customerSn5.Enabled = true;
                    //if (CheckFocusTextBox()) {
                    //    teamSN.sn5 = false;
                    //    customer.sn5 = false;
                    //    FocusTextBoxFirst();
                    //}
                    teamSN.sn5 = false;
                    customer.sn5 = false;
                    if (CheckFocusTextBoxNew(5))
                    {
                        if (global.setFocusType == Config.SetFocus.firstHeadBig)
                        {
                            FocusTextBoxFirst();
                        }
                        else
                        {
                            FocusTextBoxNext(5);
                        }
                    }
                } catch { }
            }

            if (cb_head1.Checked) {
                try {
                    string status = File.ReadAllText(Path.tested1);
                    File.Delete(Path.tested1);

                    if (!cb_head2.Checked && !cb_head3.Checked && !cb_head4.Checked && !cb_head5.Checked)
                    {
                        cb_focus.Checked = true;
                        this.WindowState = FormWindowState.Normal;
                    }

                    if (status == "PASS") {
                        lb_status1.ForeColor = Color.Blue;
                    } else {
                        lb_status1.ForeColor = Color.Red;
                    }
                    lb_status1.Text = status;
                } catch { }
            }

            if (cb_head2.Checked) {
                try {
                    string status = File.ReadAllText(Path.tested2);
                    File.Delete(Path.tested2);
                    if (status == "PASS") {
                        lb_status2.ForeColor = Color.Blue;
                    } else {
                        lb_status2.ForeColor = Color.Red;
                    }
                    lb_status2.Text = status;
                } catch { }
            }

            if (cb_head3.Checked) {
                try {
                    string status = File.ReadAllText(Path.tested3);
                    File.Delete(Path.tested3);
                    if (status == "PASS") {
                        lb_status3.ForeColor = Color.Blue;
                    } else {
                        lb_status3.ForeColor = Color.Red;
                    }
                    lb_status3.Text = status;
                } catch { }
            }
            
            if (cb_head4.Checked) {
                try {
                    string status = File.ReadAllText(Path.tested4);
                    File.Delete(Path.tested4);
                    if (status == "PASS") {
                        lb_status4.ForeColor = Color.Blue;
                    } else {
                        lb_status4.ForeColor = Color.Red;
                    }
                    lb_status4.Text = status;
                } catch { }
            }

            if (cb_head5.Checked)
            {
                try
                {
                    string status = File.ReadAllText(Path.tested5);
                    File.Delete(Path.tested5);
                    if (status == "PASS")
                    {
                        lb_status5.ForeColor = Color.Blue;
                    }
                    else
                    {
                        lb_status5.ForeColor = Color.Red;
                    }
                    lb_status5.Text = status;
                } catch { }
            }
        }
        private bool CheckFocusTextBox() {
            if (!teamSN.sn1) {
                return false;
            }
            if (!teamSN.sn2) {
                return false;
            }
            if (!teamSN.sn3) {
                return false;
            }
            if (!teamSN.sn4) {
                return false;
            }
            if (!teamSN.sn5)
            {
                return false;
            }

            if (!customer.sn1) {
                return false;
            }
            if (!customer.sn2) {
                return false;
            }
            if (!customer.sn3) {
                return false;
            }
            if (!customer.sn4) {
                return false;
            }
            if (!customer.sn5)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// เช็คว่ามีการโฟกัส textBox อันอื่นอยู่หรือเปล่านอกจาก head ที่ส่งเข้ามา
        /// เช่นส่ง 1 เข้ามา มันจะไปเช็คหัวอื่นที่เหลือ 2 - 5 ว่าถูกโฟกัสอยู่ไหม ถ้าใช่ return false
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        private bool CheckFocusTextBoxNew(int head) {
            if (!teamSN.sn1 | (!customer.sn1 & global.customer))
            {
                if (head != 1)
                {
                    return false;
                }
            }

            if (!teamSN.sn2 | (!customer.sn2 & global.customer))
            {
                if (head != 2)
                {
                    return false;
                }
            }

            if (!teamSN.sn3 | (!customer.sn3 & global.customer))
            {
                if (head != 3)
                {
                    return false;
                }
            }

            if (!teamSN.sn4 | (!customer.sn4 & global.customer))
            {
                if (head != 4)
                {
                    return false;
                }
            }

            if (!teamSN.sn5 | (!customer.sn5 & global.customer))
            {
                if (head != 5)
                {
                    return false;
                }
            }

            return true;
        }

        public static void DelaymS(int mS) {
            Stopwatch stopwatchDelaymS = new Stopwatch();
            stopwatchDelaymS.Restart();
            while (mS > stopwatchDelaymS.ElapsedMilliseconds) {
                if (!stopwatchDelaymS.IsRunning)
                    stopwatchDelaymS.Start();
                Application.DoEvents();
            }
            stopwatchDelaymS.Stop();
        }
        private char keyboardThaiToEnglish(char keyThai) {
            char keyEnglish = new char();

            switch (keyThai) {
                case 'ๅ': keyEnglish = '1'; break;
                case '/': keyEnglish = '2'; break;
                case '-': keyEnglish = '3'; break;
                case 'ภ': keyEnglish = '4'; break;
                case 'ถ': keyEnglish = '5'; break;
                case 'ุ': keyEnglish = '6'; break;
                case 'ึ': keyEnglish = '7'; break;
                case 'ค': keyEnglish = '8'; break;
                case 'ต': keyEnglish = '9'; break;
                case 'จ': keyEnglish = '0'; break;

                case 'ข': keyEnglish = '-'; break;
                case 'ช': keyEnglish = '='; break;
                case 'ๆ': keyEnglish = 'q'; break;
                case 'ไ': keyEnglish = 'w'; break;
                case 'ำ': keyEnglish = 'e'; break;
                case 'พ': keyEnglish = 'r'; break;
                case 'ะ': keyEnglish = 't'; break;
                case 'ั': keyEnglish = 'y'; break;
                case 'ี': keyEnglish = 'u'; break;
                case 'ร': keyEnglish = 'i'; break;
                case 'น': keyEnglish = 'o'; break;
                case 'ย': keyEnglish = 'p'; break;
                case 'บ': keyEnglish = '['; break;
                case 'ล': keyEnglish = ']'; break;
                case 'ฃ': keyEnglish = '\\'; break;
                case 'ฟ': keyEnglish = 'a'; break;
                case 'ห': keyEnglish = 's'; break;
                case 'ก': keyEnglish = 'd'; break;
                case 'ด': keyEnglish = 'f'; break;
                case 'เ': keyEnglish = 'g'; break;
                case '้': keyEnglish = 'h'; break;
                case '่': keyEnglish = 'j'; break;
                case 'า': keyEnglish = 'k'; break;
                case 'ส': keyEnglish = 'l'; break;
                case 'ว': keyEnglish = ';'; break;
                case 'ง': keyEnglish = '\''; break;
                case 'ผ': keyEnglish = 'z'; break;
                case 'ป': keyEnglish = 'x'; break;
                case 'แ': keyEnglish = 'c'; break;
                case 'อ': keyEnglish = 'v'; break;
                case 'ิ': keyEnglish = 'b'; break;
                case 'ื': keyEnglish = 'n'; break;
                case 'ท': keyEnglish = 'm'; break;
                case 'ม': keyEnglish = ','; break;
                case 'ใ': keyEnglish = '.'; break;
                case 'ฝ': keyEnglish = '/'; break;

                case '+': keyEnglish = '!'; break;
                case '๑': keyEnglish = '@'; break;
                case '๒': keyEnglish = '#'; break;
                case '๓': keyEnglish = '$'; break;
                case '๔': keyEnglish = '%'; break;
                case 'ู': keyEnglish = '^'; break;
                case '฿': keyEnglish = '&'; break;
                case '๕': keyEnglish = '*'; break;
                case '๖': keyEnglish = '('; break;
                case '๗': keyEnglish = ')'; break;
                case '๘': keyEnglish = '_'; break;
                case '๙': keyEnglish = '+'; break;
                case '๐': keyEnglish = 'Q'; break;
                case '"': keyEnglish = 'W'; break;
                case 'ฎ': keyEnglish = 'E'; break;
                case 'ฑ': keyEnglish = 'R'; break;
                case 'ธ': keyEnglish = 'T'; break;
                case 'ํ': keyEnglish = 'Y'; break;
                case '๊': keyEnglish = 'U'; break;
                case 'ณ': keyEnglish = 'I'; break;
                case 'ฯ': keyEnglish = 'O'; break;
                case 'ญ': keyEnglish = 'P'; break;
                case 'ฐ': keyEnglish = '['; break;
                case ',': keyEnglish = ']'; break;
                case 'ฅ': keyEnglish = '|'; break;
                case 'ฤ': keyEnglish = 'A'; break;
                case 'ฆ': keyEnglish = 'S'; break;
                case 'ฏ': keyEnglish = 'D'; break;
                case 'โ': keyEnglish = 'F'; break;
                case 'ฌ': keyEnglish = 'G'; break;
                case '็': keyEnglish = 'H'; break;
                case '๋': keyEnglish = 'J'; break;
                case 'ษ': keyEnglish = 'K'; break;
                case 'ศ': keyEnglish = 'L'; break;
                case 'ซ': keyEnglish = ':'; break;
                case '.': keyEnglish = '"'; break;
                case '(': keyEnglish = 'Z'; break;
                case ')': keyEnglish = 'X'; break;
                case 'ฉ': keyEnglish = 'C'; break;
                case 'ฮ': keyEnglish = 'V'; break;
                case 'ฺ': keyEnglish = 'B'; break;
                case '์': keyEnglish = 'N'; break;
                case '?': keyEnglish = 'M'; break;
                case 'ฒ': keyEnglish = '<'; break;
                case 'ฬ': keyEnglish = '>'; break;
                case 'ฦ': keyEnglish = '?'; break;
            }

            return keyEnglish;
        }
        #endregion

        #region =============================================== Event ===============================================
        private void tb_teamSn1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            if (!CheckDigit(tb_teamSn1)) {
                return;
            }

            DelaymS(25);
            teamSN.sn1 = true;
            if (global.setFocusType == Config.SetFocus.firstHeadBig) {
                FocusTextBoxFirst();
            } else {
                FocusTextBoxNext(1);
            }

            File.WriteAllText(Path.sn1, tb_teamSn1.Text);
            tb_teamSn1.Enabled = false;

            if (cb_head1.Checked && !cb_head2.Checked && !cb_head3.Checked && !cb_head4.Checked && !cb_head5.Checked)
            {
                cb_focus.Checked = false;
                this.WindowState = FormWindowState.Minimized;
            }

            if (!global.customer) {
                lb_status1.Text = StatusLabel.test;
                lb_status1.ForeColor = Color.Orange;
            }
        }
        private void tb_teamSn2_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            if (!CheckDigit(tb_teamSn2)) {
                return;
            }

            DelaymS(25);
            teamSN.sn2 = true;
            if (global.setFocusType == Config.SetFocus.firstHeadBig) {
                FocusTextBoxFirst();
            } else {
                FocusTextBoxNext(2);
            }

            File.WriteAllText(Path.sn2, tb_teamSn2.Text);
            tb_teamSn2.Enabled = false;

            if (!global.customer) {
                lb_status2.Text = StatusLabel.test;
                lb_status2.ForeColor = Color.Orange;
            }
        }
        private void tb_teamSn3_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            if (!CheckDigit(tb_teamSn3)) {
                return;
            }

            DelaymS(25);
            teamSN.sn3 = true;
            if (global.setFocusType == Config.SetFocus.firstHeadBig) {
                FocusTextBoxFirst();
            } else {
                FocusTextBoxNext(3);
            }

            File.WriteAllText(Path.sn3, tb_teamSn3.Text);
            tb_teamSn3.Enabled = false;

            if (!global.customer) {
                lb_status3.Text = StatusLabel.test;
                lb_status3.ForeColor = Color.Orange;
            }
        }
        private void tb_teamSn4_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            if (!CheckDigit(tb_teamSn4)) {
                return;
            }

            DelaymS(25);
            teamSN.sn4 = true;
            if (global.setFocusType == Config.SetFocus.firstHeadBig) {
                FocusTextBoxFirst();
            } else {
                FocusTextBoxNext(4);
            }

            File.WriteAllText(Path.sn4, tb_teamSn4.Text);
            tb_teamSn4.Enabled = false;

            if (!global.customer) {
                lb_status4.Text = StatusLabel.test;
                lb_status4.ForeColor = Color.Orange;
            }
        }
        private void tb_teamSn5_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter)
                return;

            if (!CheckDigit(tb_teamSn5))
            {
                return;
            }

            DelaymS(25);
            teamSN.sn5 = true;
            if (global.setFocusType == Config.SetFocus.firstHeadBig)
            {
                FocusTextBoxFirst();
            }
            else
            {
                FocusTextBoxNext(5);
            }

            File.WriteAllText(Path.sn5, tb_teamSn5.Text);
            tb_teamSn5.Enabled = false;

            if (!global.customer)
            {
                lb_status5.Text = StatusLabel.test;
                lb_status5.ForeColor = Color.Orange;
            }
        }
        private void tb_teamSn1_KeyPress(object sender, KeyPressEventArgs e) {
            if (InputLanguage.CurrentInputLanguage.LayoutName != "US") {
                e.KeyChar = keyboardThaiToEnglish(e.KeyChar);
            }
        }
        private void tb_teamSn2_KeyPress(object sender, KeyPressEventArgs e) {
            if (InputLanguage.CurrentInputLanguage.LayoutName != "US") {
                e.KeyChar = keyboardThaiToEnglish(e.KeyChar);
            }
        }
        private void tb_teamSn3_KeyPress(object sender, KeyPressEventArgs e) {
            if (InputLanguage.CurrentInputLanguage.LayoutName != "US") {
                e.KeyChar = keyboardThaiToEnglish(e.KeyChar);
            }
        }
        private void tb_teamSn4_KeyPress(object sender, KeyPressEventArgs e) {
            if (InputLanguage.CurrentInputLanguage.LayoutName != "US") {
                e.KeyChar = keyboardThaiToEnglish(e.KeyChar);
            }
        }
        private void tb_teamSn5_KeyPress(object sender, KeyPressEventArgs e) {
            if (InputLanguage.CurrentInputLanguage.LayoutName != "US")
            {
                e.KeyChar = keyboardThaiToEnglish(e.KeyChar);
            }
        }

        private void tb_customerSn1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            DelaymS(25);
            customer.sn1 = true;
            if (global.setFocusType == Config.SetFocus.firstHeadBig) {
                FocusTextBoxFirst();
            } else {
                FocusTextBoxNext(1);
            }

            File.WriteAllText(Path.customer1, tb_customerSn1.Text);
            tb_customerSn1.Enabled = false;

            lb_status1.Text = StatusLabel.test;
            lb_status1.ForeColor = Color.Orange;
        }
        private void tb_customerSn2_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            DelaymS(25);
            customer.sn2 = true;
            if (global.setFocusType == Config.SetFocus.firstHeadBig) {
                FocusTextBoxFirst();
            } else {
                FocusTextBoxNext(2);
            }

            File.WriteAllText(Path.customer2, tb_customerSn2.Text);
            tb_customerSn2.Enabled = false;

            lb_status2.Text = StatusLabel.test;
            lb_status2.ForeColor = Color.Orange;
        }
        private void tb_customerSn3_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            DelaymS(25);
            customer.sn3 = true;
            if (global.setFocusType == Config.SetFocus.firstHeadBig) {
                FocusTextBoxFirst();
            } else {
                FocusTextBoxNext(3);
            }

            File.WriteAllText(Path.customer3, tb_customerSn3.Text);
            tb_customerSn3.Enabled = false;

            lb_status3.Text = StatusLabel.test;
            lb_status3.ForeColor = Color.Orange;
        }
        private void tb_customerSn4_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            DelaymS(25);
            customer.sn4 = true;
            if (global.setFocusType == Config.SetFocus.firstHeadBig) {
                FocusTextBoxFirst();
            } else {
                FocusTextBoxNext(4);
            }

            File.WriteAllText(Path.customer4, tb_customerSn4.Text);
            tb_customerSn4.Enabled = false;

            lb_status4.Text = StatusLabel.test;
            lb_status4.ForeColor = Color.Orange;
        }
        private void tb_customerSn5_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter)
                return;

            DelaymS(25);
            customer.sn5 = true;
            if (global.setFocusType == Config.SetFocus.firstHeadBig)
            {
                FocusTextBoxFirst();
            }
            else
            {
                FocusTextBoxNext(5);
            }

            File.WriteAllText(Path.customer5, tb_customerSn5.Text);
            tb_customerSn5.Enabled = false;

            lb_status5.Text = StatusLabel.test;
            lb_status5.ForeColor = Color.Orange;
        }
        private void tb_customerSn1_KeyPress(object sender, KeyPressEventArgs e) {
            if (InputLanguage.CurrentInputLanguage.LayoutName != "US") {
                e.KeyChar = keyboardThaiToEnglish(e.KeyChar);
            }
        }
        private void tb_customerSn2_KeyPress(object sender, KeyPressEventArgs e) {
            if (InputLanguage.CurrentInputLanguage.LayoutName != "US") {
                e.KeyChar = keyboardThaiToEnglish(e.KeyChar);
            }
        }
        private void tb_customerSn3_KeyPress(object sender, KeyPressEventArgs e) {
            if (InputLanguage.CurrentInputLanguage.LayoutName != "US") {
                e.KeyChar = keyboardThaiToEnglish(e.KeyChar);
            }
        }
        private void tb_customerSn4_KeyPress(object sender, KeyPressEventArgs e) {
            if (InputLanguage.CurrentInputLanguage.LayoutName != "US") {
                e.KeyChar = keyboardThaiToEnglish(e.KeyChar);
            }
        }
        private void tb_customerSn5_KeyPress(object sender, KeyPressEventArgs e) {
            if (InputLanguage.CurrentInputLanguage.LayoutName != "US")
            {
                e.KeyChar = keyboardThaiToEnglish(e.KeyChar);
            }
        }

        private void FocusTextBox_Click(object sender, EventArgs e) {
            if (tb_teamSn1.BackColor == Color.Aqua) {
                tb_teamSn1.Focus();
                return;
            }
            if (tb_customerSn1.BackColor == Color.Aqua) {
                tb_customerSn1.Focus();
                return;
            }

            if (tb_teamSn2.BackColor == Color.Aqua) {
                tb_teamSn2.Focus();
                return;
            }
            if (tb_customerSn2.BackColor == Color.Aqua) {
                tb_customerSn2.Focus();
                return;
            }

            if (tb_teamSn3.BackColor == Color.Aqua) {
                tb_teamSn3.Focus();
                return;
            }
            if (tb_customerSn3.BackColor == Color.Aqua) {
                tb_customerSn3.Focus();
                return;
            }

            if (tb_teamSn4.BackColor == Color.Aqua) {
                tb_teamSn4.Focus();
                return;
            }
            if (tb_customerSn4.BackColor == Color.Aqua) {
                tb_customerSn4.Focus();
                return;
            }

            if (tb_teamSn5.BackColor == Color.Aqua)
            {
                tb_teamSn5.Focus();
                return;
            }
            if (tb_customerSn5.BackColor == Color.Aqua)
            {
                tb_customerSn5.Focus();
                return;
            }
        }

        private void cb_head1_Click(object sender, EventArgs e) {
            SetValueInFileConfig(config.head1, cb_head1.Checked.ToString());
            this.BackColor = Color.Red;
        }
        private void cb_head2_Click(object sender, EventArgs e) {
            SetValueInFileConfig(config.head2, cb_head2.Checked.ToString());
            this.BackColor = Color.Red;
        }
        private void cb_head3_Click(object sender, EventArgs e) {
            SetValueInFileConfig(config.head3, cb_head3.Checked.ToString());
            this.BackColor = Color.Red;
        }
        private void cb_head4_Click(object sender, EventArgs e) {
            SetValueInFileConfig(config.head4, cb_head4.Checked.ToString());
            this.BackColor = Color.Red;
        }
        private void cb_head5_Click(object sender, EventArgs e) {
            SetValueInFileConfig(config.head5, cb_head5.Checked.ToString());
            this.BackColor = Color.Red;
        }

        private void ctms_firstHeadBig_Click(object sender, EventArgs e) {
            ctms_firstHeadBig.Checked = true;
            ctms_nextHeadBig.Checked = false;
            SetValueInFileConfig(config.setFocus, Config.SetFocus.firstHeadBig);
            global.setFocusType = Config.SetFocus.firstHeadBig;
        }
        private void ctms_nextHeadBig_Click(object sender, EventArgs e) {
            ctms_firstHeadBig.Checked = false;
            ctms_nextHeadBig.Checked = true;
            SetValueInFileConfig(config.setFocus, Config.SetFocus.nextHeadBig);
            global.setFocusType = Config.SetFocus.nextHeadBig;
        }

        private void digit_sn_Click(object sender, EventArgs e) {
            cb_focus.Checked = false;
            int data = 0;

            while (true) {
                string input = Microsoft.VisualBasic.Interaction.InputBox("_ใส่ digit ของ sn", "digit", digit_sn.Text, 500, 300);
                if (input == string.Empty) {
                    cb_focus.Checked = true;
                    return;
                }

                try {
                    data = Convert.ToInt32(input);
                } catch {
                    MessageBox.Show("not format");
                    continue;
                }

                break;
            }

            global.digit = data;
            digit_sn.Text = data.ToString();
            SetValueInFileConfig(config.digit, data.ToString());
            cb_focus.Checked = true;
        }
        private void ctms_customer_Click(object sender, EventArgs e) {
            SetValueInFileConfig(config.customer, ctms_customer.Checked.ToString());
            global.customer = ctms_customer.Checked;
            this.BackColor = Color.Red;
        }
        private void ctms_guiFull_Click(object sender, EventArgs e) {
            SetGui();

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            tb_customerSn1.Visible = true;
            tb_customerSn2.Visible = true;
            tb_customerSn3.Visible = true;
            tb_customerSn4.Visible = true;
            tb_customerSn5.Visible = true;
            cb_head1.Visible = true;
            cb_head2.Visible = true;
            cb_head3.Visible = true;
            cb_head4.Visible = true;
            cb_head5.Visible = true;
            tb_teamSn1.Visible = true;
            tb_teamSn2.Visible = true;
            tb_teamSn3.Visible = true;
            tb_teamSn4.Visible = true;
            tb_teamSn5.Visible = true;

            resizeAutoFrist = 0;

            this.Size = new Size(1335, 288);
            cb_focus.Location = new Point(1250, 225);

            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
        private void tm_activeForm_Tick(object sender, EventArgs e) {
            ReadFile();

            if (!cb_focus.Checked) {
                return;
            }
                
            this.Activate();
            if (Form.ActiveForm != this) {
                this.WindowState = FormWindowState.Minimized;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private int resizeAutoFrist = 0;
        private void Form1_Resize(object sender, EventArgs e) {
            if (resizeAutoFrist < 2)
            {
                resizeAutoFrist++;
                return;
            }
            resizeAuto.Resize();
        }

        #endregion

        public class TeamSN {
            public bool sn1 { get; set; }
            public bool sn2 { get; set; }
            public bool sn3 { get; set; }
            public bool sn4 { get; set; }
            public bool sn5 { get; set; }
            public int digit { get; set; }

            public TeamSN() {
                sn1 = true;
                sn2 = true;
                sn3 = true;
                sn4 = true;
                sn5 = true;
            }
        }
        public class Customer {
            public bool sn1 { get; set; }
            public bool sn2 { get; set; }
            public bool sn3 { get; set; }
            public bool sn4 { get; set; }
            public bool sn5 { get; set; }
            public bool flagUse { get; set; }

            public Customer() {
                sn1 = true;
                sn2 = true;
                sn3 = true;
                sn4 = true;
                sn5 = true;
                flagUse = true;
            }
        }
        public class Global {
            public int digit { get; set; }
            public bool customer { get; set; }
            public int lockFocusCustomer { get; set; }
            public string setFocusType { get; set; }
        }
        public class Config {
            /// <summary>Value = "../../config/Scan2dConfig.txt"</summary>
            public string path { get; set; }
            public string digit { get; set; }
            public string head1 { get; set; }
            public string head2 { get; set; }
            public string head3 { get; set; }
            public string head4 { get; set; }
            public string head5 { get; set; }
            public string customer { get; set; }
            public string setFocus { get; set; }

            public Config() {
                path = "../../config/Scan2dConfig.txt";
                digit = "Digit";
                head1 = "Head1";
                head2 = "Head2";
                head3 = "Head3";
                head4 = "Head4";
                head5 = "Head5";
                customer = "Customer";
                setFocus = "SetFocus";
            }

            public static class SetFocus {
                public static readonly string firstHeadBig = "FirstHeadBig";
                public static readonly string nextHeadBig = "NextHeadBig";
            }
        }
        public class Path {
            public static string sn1 = "dryice_scan2d_sn_header_1.txt";
            public static string sn2 = "dryice_scan2d_sn_header_2.txt";
            public static string sn3 = "dryice_scan2d_sn_header_3.txt";
            public static string sn4 = "dryice_scan2d_sn_header_4.txt";
            public static string sn5 = "dryice_scan2d_sn_header_5.txt";
            public static string clearSn1 = "dryice_scan2d_clear_sn_1.txt";
            public static string clearSn2 = "dryice_scan2d_clear_sn_2.txt";
            public static string clearSn3 = "dryice_scan2d_clear_sn_3.txt";
            public static string clearSn4 = "dryice_scan2d_clear_sn_4.txt";
            public static string clearSn5 = "dryice_scan2d_clear_sn_5.txt";
            public static string customer1 = "ScanSnCustomer1.txt";
            public static string customer2 = "ScanSnCustomer2.txt";
            public static string customer3 = "ScanSnCustomer3.txt";
            public static string customer4 = "ScanSnCustomer4.txt";
            public static string customer5 = "ScanSnCustomer5.txt";
            public static string tested1 = "dryice_scan2d_tested_1.txt";
            public static string tested2 = "dryice_scan2d_tested_2.txt";
            public static string tested3 = "dryice_scan2d_tested_3.txt";
            public static string tested4 = "dryice_scan2d_tested_4.txt";
            public static string tested5 = "dryice_scan2d_tested_5.txt";
            public static string focusTrue = "ScanSnFocusTrue.txt";
            public static string focusFalse = "ScanSnFocusFalse.txt";
        }
        public static class StatusLabel {
            public static readonly string test = "TEST";
            public static readonly string pass = "PASS";
            public static readonly string fail = "FAIL";
        }

        
    }
}
