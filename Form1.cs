using System;
using System.Runtime.InteropServices; // Needed for mouse move
using System.Windows.Forms;

namespace DrgCalc
{
    public partial class Form1 : Form
    {
        #region Constants

        //Form Move data members
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        //Job constants
        private const int DRG_WEAPONDAMAGE_VALUE = 9349;

        private const int DRG_DETERMINATION_VALUE = 327;
        private const int DRG_CRITICAL_VALUE = 233;
        private const int DRG_SKILLSPEED_VALUE = 198;

        private const int MNK_WEAPONDAMAGE_VALUE = 9338;
        private const int MNK_DETERMINATION_VALUE = 336;
        private const int MNK_CRITICAL_VALUE = 214;
        private const int MNK_SKILLSPEED_VALUE = 206;

        private const int NIN_WEAPONDAMAGE_VALUE = 9132;
        private const int NIN_DETERMINATION_VALUE = 325;
        private const int NIN_CRITICAL_VALUE = 226;
        private const int NIN_SKILLSPEED_VALUE = 215;

        private const int BRD_WEAPON_DAMAGE_VALUE = 9429;
        private const int BRD_DETERMINATION_VALUE = 320;
        private const int BRD_CRITICAL_VALUE = 339;
        private const int BRD_SKILLSPEED_VALUE = 161;

        private const int BLM_WEAPONDAMAGE_VALUE = 6726;
        private const int BLM_DETERMINATION_VALUE = 234;
        private const int BLM_CRITICAL_VALUE = 246;
        private const int BLM_SKILLSPEED_VALUE = 281;

        private const int SMN_WEAPONDAMAGE_VALUE = 6911;
        private const int SMN_DETERMINATION_VALUE = 284;
        private const int SMN_CRITICAL_VALUE = 232;
        private const int SMN_SKILLSPEED_VALUE = 98;

        private const int WAR_WEAPONDAMAGE_VALUE = 8732;
        private const int WAR_DETERMINATION_VALUE = 325;
        private const int WAR_CRITICAL_VALUE = 204;
        private const int WAR_SKILLSPEED_VALUE = 178;

        private const int PLD_WEAPONDAMAGE_VALUE = 8732;
        private const int PLD_DETERMINATION_VALUE = 325;
        private const int PLD_CRITICAL_VALUE = 204;
        private const int PLD_SKILLSPEED_VALUE = 178;

        private const double DIVISOR = .001;

        //Message Constants
        private const string BLM_MESSAGE =
                @"Notice: BLM stat weights do not work similar to other jobs.

                  BLM stat weights change based on gear combinations.
                  For more information on BLM gear sets, click 'YES'.";

        private const string BLM_MESSAGE_TITLE = "{Please check it.}";
        private const string BLM_THEORY_HYPERLINK = "https://docs.google.com/spreadsheet/lv?key=0AqG_cUArVwt5dExEVEJIRmJHd2lrczg4cnZxTDVkM1E&toomany=true";

        private const string HELP_MESSAGE = @"Purpose: Using stat weights discovered through testing, this calculator translates secondary stat values into a total primary stat value. For example, if Determination was discovered to be worth .25 STR for DRG, 4 determination would equal 1 STR." + Environment.NewLine +
                 "This allows for simple comparison between different items or gear sets." + Environment.NewLine + Environment.NewLine +
                 "Weapon Damage: The value for your weapon damage." + Environment.NewLine +
                 "STR/DEX/INT: The primary stat of the desired job." + Environment.NewLine +
                 "Determination: The determination stat." + Environment.NewLine +
                 "Critical: The critical chance stat." + Environment.NewLine +
                 "Skill speed: The spell/skill speed stat." + Environment.NewLine + Environment.NewLine +
                 "Damage value: The resulting value of the secondary stats translated into the primary stat.";

        private const string HELP_MESSAGE_TITLE = "{Help me out!}";

        #endregion Constants

        #region Properties

        //Stat Values
        private int weapondamage_value;
        private int determination_value;
        private int critical_value;
        private int skillspeed_value;

        //ToolTips
        private ToolTip weaponDamageToolTip = new ToolTip();
        private ToolTip primaryToolTip = new ToolTip();
        private ToolTip determinationToolTip = new ToolTip();
        private ToolTip criticalToolTip = new ToolTip();
        private ToolTip skillspeedToolTip = new ToolTip();

        #endregion Properties

        #region Form Movement

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        #endregion Form Movement

        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Helper Methods

        private double GetDamageValue()
        {
            double damageValue = 0;
            double valuePreDivision = 0;

            if (!getStatValuesForSelectedJob())
            {
                return 0;
            }

            //Weapon damage
            int wd;
            string wdText = weaponDamageTextBox.Text.ToString().Trim();
            if (Int32.TryParse(wdText, out wd))
            {
                valuePreDivision += wd * weapondamage_value;
            }

            //Strength
            int str;
            string strText = strengthTextBox.Text.ToString().Trim();
            if (Int32.TryParse(strText, out str))
            {
                damageValue += str;
            }

            //Determination
            int det;
            string detText = determinationTextBox.Text.ToString().Trim();
            if (Int32.TryParse(detText, out det))
            {
                valuePreDivision += det * determination_value;
            }

            //Critical
            int crit;
            string critText = criticalTextBox.Text.ToString().Trim();
            if (Int32.TryParse(critText, out crit))
            {
                valuePreDivision += crit * critical_value;
            }

            //SkillSpeed
            int skillSpeed;
            string skillSpeedText = skillSpeedTextBox.Text.ToString().Trim();
            if (Int32.TryParse(skillSpeedText, out skillSpeed))
            {
                valuePreDivision += skillSpeed * skillspeed_value;
            }

            damageValue += (valuePreDivision * DIVISOR);

            Clipboard.SetText(damageValue.ToString());
            return damageValue;
        }

        private bool getStatValuesForSelectedJob()
        {
            if (drgButton.Checked)
            {
                weapondamage_value = DRG_WEAPONDAMAGE_VALUE;
                determination_value = DRG_DETERMINATION_VALUE;
                critical_value = DRG_CRITICAL_VALUE;
                skillspeed_value = DRG_SKILLSPEED_VALUE;
                return true;
            }
            else if (ninButton.Checked)
            {
                weapondamage_value = NIN_WEAPONDAMAGE_VALUE;
                determination_value = NIN_DETERMINATION_VALUE;
                critical_value = NIN_CRITICAL_VALUE;
                skillspeed_value = NIN_SKILLSPEED_VALUE;
                return true;
            }
            else if (mnkButton.Checked)
            {
                weapondamage_value = MNK_WEAPONDAMAGE_VALUE;
                determination_value = MNK_DETERMINATION_VALUE;
                critical_value = MNK_CRITICAL_VALUE;
                skillspeed_value = MNK_SKILLSPEED_VALUE;
                return true;
            }
            else if (brdButton.Checked)
            {
                weapondamage_value = BRD_WEAPON_DAMAGE_VALUE;
                determination_value = BRD_DETERMINATION_VALUE;
                critical_value = BRD_CRITICAL_VALUE;
                skillspeed_value = BRD_SKILLSPEED_VALUE;
                return true;
            }
            else if (blmButton.Checked)
            {
                weapondamage_value = BLM_WEAPONDAMAGE_VALUE;
                determination_value = BLM_DETERMINATION_VALUE;
                critical_value = BLM_CRITICAL_VALUE;
                skillspeed_value = BLM_SKILLSPEED_VALUE;
                return true;
            }
            else if (smnButton.Checked)
            {
                weapondamage_value = SMN_WEAPONDAMAGE_VALUE;
                determination_value = SMN_DETERMINATION_VALUE;
                critical_value = SMN_CRITICAL_VALUE;
                skillspeed_value = SMN_SKILLSPEED_VALUE;
                return true;
            }
            else if (pldButton.Checked)
            {
                weapondamage_value = PLD_WEAPONDAMAGE_VALUE;
                determination_value = PLD_DETERMINATION_VALUE;
                critical_value = PLD_CRITICAL_VALUE;
                skillspeed_value = PLD_SKILLSPEED_VALUE;
                return true;
            }
            else if (warButton.Checked)
            {
                weapondamage_value = WAR_WEAPONDAMAGE_VALUE;
                determination_value = WAR_DETERMINATION_VALUE;
                critical_value = WAR_CRITICAL_VALUE;
                skillspeed_value = WAR_SKILLSPEED_VALUE;
                return true;
            }

            return false;
        }

        private void ClearBoxes()
        {
            strengthTextBox.Clear();
            determinationTextBox.Clear();
            criticalTextBox.Clear();
            skillSpeedTextBox.Clear();
            damageTextBox.Clear();
        }

        #endregion Helper Methods

        #region KeyPress Handlers

        private void weaponDamageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            damageTextBox.Text = GetDamageValue().ToString();
        }

        private void strengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            damageTextBox.Text = GetDamageValue().ToString();
        }

        private void determinationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            damageTextBox.Text = GetDamageValue().ToString();
        }

        private void criticalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            damageTextBox.Text = GetDamageValue().ToString();
        }

        private void skillSpeedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            damageTextBox.Text = GetDamageValue().ToString();
        }

        #endregion KeyPress Handlers

        #region TextChanged Handlers

        private void weaponDamageTextBox_TextChanged(object sender, EventArgs e)
        {
            damageTextBox.Text = GetDamageValue().ToString();
        }

        private void strengthTextBox_TextChanged(object sender, EventArgs e)
        {
            damageTextBox.Text = GetDamageValue().ToString();
        }

        private void determinationTextBox_TextChanged(object sender, EventArgs e)
        {
            damageTextBox.Text = GetDamageValue().ToString();
        }

        private void criticalTextBox_TextChanged(object sender, EventArgs e)
        {
            damageTextBox.Text = GetDamageValue().ToString();
        }

        private void skillSpeedTextBox_TextChanged(object sender, EventArgs e)
        {
            damageTextBox.Text = GetDamageValue().ToString();
        }

        #endregion TextChanged Handlers

        #region CheckedChanged Handlers

        private void drgButton_CheckedChanged(object sender, EventArgs e)
        {
            if (drgButton.Checked)
                damageTextBox.Text = GetDamageValue().ToString();
        }

        private void ninButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ninButton.Checked)
                damageTextBox.Text = GetDamageValue().ToString();
        }

        private void mnkButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mnkButton.Checked)
                damageTextBox.Text = GetDamageValue().ToString();
        }

        private void brdButton_CheckedChanged(object sender, EventArgs e)
        {
            if (brdButton.Checked)
                damageTextBox.Text = GetDamageValue().ToString();
        }

        private void blmButton_CheckedChanged(object sender, EventArgs e)
        {
            if (blmButton.Checked)
            {
                damageTextBox.Text = GetDamageValue().ToString();

                if (MessageBox.Show(BLM_MESSAGE, BLM_MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(BLM_THEORY_HYPERLINK);
                }
            }
        }

        private void smnButton_CheckedChanged(object sender, EventArgs e)
        {
            if (smnButton.Checked)
                damageTextBox.Text = GetDamageValue().ToString();
        }

        private void pldButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pldButton.Checked)
                damageTextBox.Text = GetDamageValue().ToString();
        }

        private void warButton_CheckedChanged(object sender, EventArgs e)
        {
            if (warButton.Checked)
                damageTextBox.Text = GetDamageValue().ToString();
        }

        #endregion CheckedChanged Handlers

        #region Tool tips

        private void weaponDamageLabel_MouseHover(object sender, EventArgs e)
        {
            weaponDamageToolTip.SetToolTip(weaponDamageLabel, "1 WD = " + (weapondamage_value * DIVISOR).ToString() + " STR/DEX/INT.");
        }

        private void strLabel_MouseHover(object sender, EventArgs e)
        {
            primaryToolTip.SetToolTip(strLabel, "1:1");
        }

        private void determinationLabel_MouseHover(object sender, EventArgs e)
        {
            determinationToolTip.SetToolTip(determinationLabel, "1 DET = " + (determination_value * DIVISOR).ToString() + " STR/DEX/INT.");
        }

        private void criticalLabel_MouseHover(object sender, EventArgs e)
        {
            criticalToolTip.SetToolTip(criticalLabel, "1 CRIT = " + (critical_value * DIVISOR).ToString() + " STR/DEX/INT.");
        }

        private void skillSpeedLabel_MouseHover(object sender, EventArgs e)
        {
            skillspeedToolTip.SetToolTip(skillSpeedLabel, "1 SS = " + (skillspeed_value * DIVISOR).ToString() + " STR/DEX/INT.");
        }

        #endregion Tool tips

        #region Other Handlers

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HELP_MESSAGE, HELP_MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        #endregion Other Handlers
    }
}