using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Natives;
using System.Windows.Forms;
using PS4Lib;
using System.Threading;

namespace GTA_Demo
{
    public partial class FrmMain : Form
    {
        PS4API PS4 = new PS4API();
        public FrmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            cmbVehicles.SelectedIndex = 0;
            cmbModels.SelectedIndex = 0;
        }
        private bool EnableMods
        {
            set
            {
                var gBs = Controls.OfType<GroupBox>();
                foreach (GroupBox groupBox in gBs)
                {
                    if (!groupBox.Name.Contains("x1"))
                    groupBox.Enabled = value;
                }
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (PS4.IsConnected)
                return;

            btnConnect.ForeColor = PS4.ConnectTarget(txtIp.Text)  ?  Color.Green : Color.Red;

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            btnAttach.ForeColor = (EnableMods = PS4.AttachProcess()) ? Color.Green : Color.Red;
            RPC.Enable(PS4);
        }

        private void btnVehicleSpawn_Click(object sender, EventArgs e)
        {
            Script.SpawnVehicle(cmbVehicles.Text);
        }
        private void chkVecInvisble_CheckedChanged(object sender, EventArgs e)
        {
            Script.Invisible(VEHICLE.GET_LAST_DRIVEN_VEHICLE(), chkVecInvisble.Checked);
        }
        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            Script.Upgrade_Downgrade(true);
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            Script.Fix();
        }

        private void btnBoost_Click(object sender, EventArgs e)
        {
            Script.Boost((float)numSpeed.Value);
        }

        private void btnNonDamage_Click(object sender, EventArgs e)
        {
            Script.NoDamage(VEHICLE.GET_LAST_DRIVEN_VEHICLE());
        }
        private void btnExplode_Click(object sender, EventArgs e)
        {
            Script.ExplodeVehicle();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            Script.ChangeColor(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Script.DeleteEntity(VEHICLE.GET_LAST_DRIVEN_VEHICLE());
        }

        private void chkRagdoll_CheckedChanged(object sender, EventArgs e)
        {
            Script.RagDoll(chkRagdoll.Checked);
        }

        private void btnSetModel_Click(object sender, EventArgs e)
        {
            Script.SetModel(cmbModels.Text);
        }

        private void chkNightVision_CheckedChanged(object sender, EventArgs e)
        {
            Script.NighVision(chkNightVision.Checked);
        }

        private void chkSeeThrough_CheckedChanged(object sender, EventArgs e)
        {
            Script.SeeThrough(chkSeeThrough.Checked);
        }

        private void chkNoCops_CheckedChanged(object sender, EventArgs e)
        {
            Script.NoCops(chkNoCops.Checked);
        }

        private void chkInvisible_CheckedChanged(object sender, EventArgs e)
        {
            Script.Invisible(PLAYER.PLAYER_PED_ID(), chkPlayerInvisible.Checked);
        }

        private void btnSkyDive_Click(object sender, EventArgs e)
        {
            Script.SkyDive();
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            Script.Clone();
        }

        private void chkGravity_CheckedChanged(object sender, EventArgs e)
        {
            Script.SetGravity(chkGravity.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ENTITY.SET_ENTITY_MAX_SPEED(PLAYER.PLAYER_PED_ID(), 100f);
        }

        private void chkLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkLocation.Checked)
                return;

            Task.Run(delegate {
                int ped = PLAYER.PLAYER_PED_ID();
                while (true)
                {
                    if (!chkLocation.Checked)
                        break;
                    Vector3 vec = ENTITY.GET_ENTITY_COORDS(ped , true);
                    lblLoction.Text = string.Format("X: {0} Y: {1} Z: {2}", vec.X, vec.Y, vec.Z);
                }
            });
        }

        private void btnTeleportWayPoint_Click(object sender, EventArgs e)
        {
            Script.TeleportToWaypoint();
        }

        private void btnRandomPed_Click(object sender, EventArgs e)
        {
            int ped = Script.CreateRandomPed();
            if (ped == 0)
                return;
            Script.MakeHimAsGuard(ped);
        }

        private void chkInfiniteAmmo_CheckedChanged(object sender, EventArgs e)
        {
            Script.InfiniteAmmo(chkInfiniteAmmo.Checked);
        }

        private void btnGiveWeapon_Click(object sender, EventArgs e)
        {
            Script.GiveWeapon((Weapons)Enum.Parse(typeof(Weapons), cmbWeapons.Text));
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            DateTime dt = dtTimePicker.Value;
            Script.SetTime(dt.Hour, dt.Minute, dt.Second);
        }

        private void chkPauseTime_CheckedChanged(object sender, EventArgs e)
        {
            Script.PauseTime(chkPauseTime.Checked);
        }

        private void btnSetWeather_Click(object sender, EventArgs e)
        {
            Script.SetWeather(cmbWeathers.Text);
        }

        private void btnUnlockTrophies_Click(object sender, EventArgs e)
        {
            Script.UnlockTrophies();
        }

        private void chkSwapAimedPed_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSwapAimedPed.Checked)
                return;
            Task.Run(delegate {
                while (chkSwapAimedPed.Checked)
                {
                    Script.SwapToAimedPed();
                    Thread.Sleep(100);
                }
            });
        }
    }
}
