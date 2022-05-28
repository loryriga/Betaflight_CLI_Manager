using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class PIDs : Form
    {
        // Tags Declaration
            
            // Pids
            int p_roll = 45;
            int i_roll = 80;
            int dmax_roll = 38;
            int dmin_roll = 21;
            int f_roll = 120;

            int p_pitch = 47;
            int i_pitch = 85;
            int dmax_pitch = 42;
            int dmin_pitch = 24;
            int f_pitch = 125;

            int p_yaw = 45;
            int i_yaw = 80;
            int dmax_yaw = 0;
            int dmin_yaw = 0;
            int f_yaw = 120;

            //Gyro Filters
            int gyro_dyn_lpf1_min = 250;
            int gyro_dyn_lpf1_max = 500;
            int gyro_static1 = 200;

            int gyro_static2 = 500;

            // D-Term Filters
            int dterm_dyn_lpf1_min = 70;
            int dterm_dyn_lpf1_max = 150;
            int dterm_static1_lpf = 70;
            int dterm_static2_lpf = 70;
            
            // Pids Sliders
            double master;
            double damping;
            double dyn_damping;
            double tracking;
            double whobble;
            double stick_resp;
            double iterm;
            
            // Flags

                // Gyro FIletrs
                bool gyro_static1_lpf_changed = false;
                bool gyro_dyn_lpf_min_changed = false;
                bool gyro_dyn_lpf_max_changed = false;
                
                // D-Term Filters
                bool dterm_static1_lpf_changed = false;
                bool dterm_dyn_lpf_min_changed = false;
                bool dterm_dyn_lpf_max_changed = false;
      
        public PIDs()
        {
            InitializeComponent();

            initializeControls();
            // Setting startup values
            StartupValues();

            // Generating ComboBoxes
            FillAndSelect();
        }
        private void initializeControls()
        {
            // Trackbars
            damping_trk.Value = 10;
            label9.Text = "1";
            iterm_trk.Value = 10;
            label10.Text = "1";
            stick_resp_trk.Value = 10;
            label11.Text = "1";
            trackBar4.Value = 10;
            label12.Text = "1";
            tracking_trk.Value = 10;
            label13.Text = "1";
            master_trk.Value = 10;
            label14.Text = "1";
            gyro_trk.Value = 10;
            gyro_slider_value_lbl.Text = "1";
            dterm_trk.Value = 10;
            dterm_slider_value_lbl.Text = "1";

            // CheckBoxes

                // Gyro Filters

                    // Gyro Lpf1
                    gyro_lpf1_ckbx.Checked      = true;
                                            
                    // Gyro Lpf2
                    gyro_lpf2_ckbx.Checked      = true;

                    // Rpm Notches
                    rpm_notches_ckbx.Checked    = false;
                
                    //Static Notches
                    gyro_notch1_ckbx.Checked    = false ;
                    gyro_notch2_ckbx.Checked    = false ;
            
                    // Dynamic Notches
                    dyn_notches_ckbx.Checked    = true;
                
                // D-Term Filters

                    // D-Term Lpf1
                    dterm_lpf1_ckbx.Checked     = true;
                    dterm_lpf2_ckbx.Checked     = true;

                    //Static Notches
                    dterm_notch1_ckbx.Checked   = false;
                    dterm_notch2_ckbx.Checked   = false;
                    
                    //Yaw Filters
                    yaw_lpf_ckbx.Checked        = true ;

            // GroupBoxes

                // Gyro Filters 

                        // Gyro Lpf1
                        gyro_lpf1_gpbx.Enabled      = true;
                        gyro_dyn_lpf1_gpbx.Enabled  = true;
                        gyro_static1_gpbx.Enabled   = false;
            
                        //gyro Lpf2
                        gyro_static2_gpbx.Enabled   = true;

                        //Rpm Notches
                        rpm_notches_gpbx.Enabled    = false;
                
                        //Static Notches
                        gyro_notch1_gpbx.Enabled    = false ;
                        gyro_notch2_gpbx.Enabled    = false ;
            
                        // Dynamic Notches
                        gyro_dyn_notch_gpbx.Enabled = true;

                // D-Term Filters

                        //dterm Lpf1
                        dterm_lpf1_gpbx.Enabled     = true;
                        dterm_dyn_lpf1_gpbx.Enabled = true;
                        dterm_static1_gpbx.Enabled  = false;

                        //dterm Lpf2
                        dterm_static2_gpbx.Enabled  = true;

                        //Static Notches
                        dterm_notch1_gpbx.Enabled   = false;
                        dterm_notch2_gpbx.Enabled   = false;

                        //Yaw Filters
                        yaw_lpf_gpbx.Enabled        = true ;

        }
       
        // Startup
        private void StartupValues()    // Sets all the startup values (Betaflight defaults)
        {

            // Pids

                //Pid Controller

                    // Roll Axis
                    p_roll_updn.Value = 45;
                    i_roll_updn.Value = 80;
                    dmax_roll_updn.Value = 38;
                    dmin_roll_updn.Value = 21;
                    f_roll_updn.Value = 120;

                    // Pitch Axis
                    p_pitch_updn.Value = 47;
                    i_pitch_updn.Value = 85;
                    dmax_pitch_updn.Value = 42;
                    dmin_pitch_updn.Value = 24;
                    f_pitch_updn.Value = 125;

                    // Yaw Axis
                    p_yaw_updn.Value = 45;
                    i_yaw_updn.Value = 80;
                    dmax_yaw_updn.Value = 0;
                    dmin_yaw_updn.Value = 0;
                    f_yaw_updn.Value = 120;

                    // Feedforward
                    f_jit_updn.Value = 7;
                    f_smooth_updn.Value = 20;
                    f_boost_updn.Value = 15;
                    f_max_rate_updn.Value = 100;
                    f_transition_updn.Value = 0;

                // Advanced Tuning

                    // I-Term Relax
                    irel_cutoff_updn.Value = 15;

                    // Anti Gravity
                    antig_gain_updn.Value = (decimal)3.5;

                    // Trust Linearization
                    thrlin_updn.Value = 0;

                    // Vbat Sag Compensation
                    vbat_comp_updn.Value = 0;


            // Rates

                // TPA
                tpa_brkpt_updn.Value = 1350;
                tpa_att_updn.Value = (decimal)0.65;

            // Throttle Limit
            thr_lim_updn.Value = 100;

            // Gyro Filters

                // Gyro Lowpass
                gyro_dyn_lpf1_min_updn.Value = 250;
                gyro_dyn_lpf1_max_updn.Value = 500;
                gyro_static1_lpf_updn.Value = 0;
                gyro_static2_lpf_updn.Value = 500;

                // Gyro Static Notches
                gyro_notch1_cntr_updn.Value = 0;
                gyro_notch1_min_updn.Value = 0;
                gyro_notch2_cntr_updn.Value = 0;
                gyro_notch1_min_updn.Value = 0;

                // RPM Notches
                gyro_rpm_cnt_updn.Value = 0;
                gyro_rpm_min_updn.Value = 0;

                // Gyro Dynamic Notches
                gyro_dyn_notch_cnt_updn.Value = 3;
                gyro_dyn_notch_wid_updn.Value = 500;
                gyro_dyn_notch_min_updn.Value = 150;
                gyro_dyn_notch_max_updn.Value = 600;


            // D-Term Filters

                // D-Term Lowpass
                dterm_dyn_lpf1_min_updn.Value = 250;
                dterm_dyn_lpf1_max_updn.Value = 500;
                dterm_static1_lpf_updn.Value = 0;
                dterm_static2_lpf_updn.Value = 500;

                // D-Term Static Notches
                dterm_notch1_cntr_updn.Value = 0;
                dterm_notch1_min_updn.Value = 0;
                dterm_notch2_cntr_updn.Value = 0;
                dterm_notch1_min_updn.Value = 0;

            // Yaw
            yaw_lpf_updn.Value = 100;

            // Extras
            pidsum_lim_updn.Value = 500;
            pidsum_lim_yaw_updn.Value = 500;
            iterm_lim_updn.Value = 500;
        }
        private void FillAndSelect()    // Populates all ComboBoxes and selects startup items (Betaflight defaults)
        {
            // Pid

            // Simplyfied Tuning
            pid_simplyfied_tuning_cmbx.Items.Add("OFF");
            pid_simplyfied_tuning_cmbx.Items.Add("RP");
            pid_simplyfied_tuning_cmbx.SelectedIndex = gyro_simplyfied_cmbx.FindStringExact("RPY");

            // FeedForward
            f_avg_cmbx.Items.Add("OFF");
            f_avg_cmbx.Items.Add("1 POINT");
            f_avg_cmbx.Items.Add("2 POINTS");
            f_avg_cmbx.SelectedIndex = f_avg_cmbx.FindStringExact("OFF");

            // I-Term Relax
            irel_axis_cmbx.Items.Add("OFF");
            irel_axis_cmbx.Items.Add("RP");
            irel_axis_cmbx.Items.Add("RPY");
            irel_axis_cmbx.SelectedIndex = irel_axis_cmbx.FindStringExact("RP");

            irel_type_cmbx.Items.Add("Setpoint");
            irel_type_cmbx.Items.Add("Gyro");
            irel_type_cmbx.SelectedIndex = irel_type_cmbx.FindStringExact("Setpoint");

            // Anti Gravity
            antig_mode_cmbx.Items.Add("Smooth");
            antig_mode_cmbx.Items.Add("???");
            antig_mode_cmbx.SelectedIndex = antig_mode_cmbx.FindStringExact("Smooth");

            // Rates

            // Throttle Limit Type
            thr_lim_type_cmbx.Items.Add("OFF");
            thr_lim_type_cmbx.Items.Add("CUT");
            thr_lim_type_cmbx.Items.Add("SCALE");
            thr_lim_type_cmbx.SelectedIndex = thr_lim_type_cmbx.FindStringExact("OFF");

            // Filters

            // Gyro Simplyfied Tuning
            gyro_simplyfied_cmbx.Items.Add("ON");
            gyro_simplyfied_cmbx.Items.Add("OFF");
            gyro_simplyfied_cmbx.SelectedIndex = gyro_simplyfied_cmbx.FindStringExact("ON");

            // D-Term Simplyfied Tuning
            dterm_simplyfied_cmbx.Items.Add("ON");
            dterm_simplyfied_cmbx.Items.Add("OFF");
            dterm_simplyfied_cmbx.SelectedIndex = dterm_simplyfied_cmbx.FindStringExact("ON");



            // Gyro Lpf1 Mode
            gyro_lpf1_mode_cmbx.Items.Add("STATIC");
            gyro_lpf1_mode_cmbx.Items.Add("DYNAMIC");
            gyro_lpf1_mode_cmbx.SelectedIndex = gyro_lpf1_mode_cmbx.FindStringExact("DYNAMIC");

            // Gyro Lpf1 Type
            gyro_lpf1_type_cmbx.Items.Add("PT1");
            gyro_lpf1_type_cmbx.Items.Add("PT2");
            gyro_lpf1_type_cmbx.Items.Add("BIQUAD");
            gyro_lpf1_type_cmbx.SelectedIndex = gyro_lpf1_type_cmbx.FindStringExact("PT1");

            // Gyro Lpf2 Type
            dterm_static2_type_cmbx.Items.Add("PT1");
            dterm_static2_type_cmbx.Items.Add("PT2");
            dterm_static2_type_cmbx.Items.Add("BIQUAD");
            dterm_static2_type_cmbx.SelectedIndex = dterm_static2_type_cmbx.FindStringExact("PT1");

            // D-Term Lpf1 Mode
            dterm_lpf1_mode_cmbx.Items.Add("STATIC");
            dterm_lpf1_mode_cmbx.Items.Add("DYNAMIC");
            dterm_lpf1_mode_cmbx.SelectedIndex = dterm_lpf1_mode_cmbx.FindStringExact("DYNAMIC");

            // D-Term Lpf1 Type
            dterm_lpf1_type_cmbx.Items.Add("PT1");
            dterm_lpf1_type_cmbx.Items.Add("PT2");
            dterm_lpf1_type_cmbx.Items.Add("BIQUAD");
            dterm_lpf1_type_cmbx.SelectedIndex = gyro_lpf1_type_cmbx.FindStringExact("PT1");

            // D-Term Lpf2 Type
            gyro_static2_type_cmbx.Items.Add("PT1");
            gyro_static2_type_cmbx.Items.Add("PT2");
            gyro_static2_type_cmbx.Items.Add("BIQUAD");
            gyro_static2_type_cmbx.SelectedIndex = gyro_static2_type_cmbx.FindStringExact("PT1");
        }

        // Pids

            // Pids Sliders Handling
            private void DampingSlider_Scroll(object sender, EventArgs e)
            {
                damping = (double)damping_trk.Value / 10.0;
                label9.Text = damping.ToString();

            }
            private void ItermSlider_Scroll(object sender, EventArgs e)
            {
                iterm = (double)iterm_trk.Value / 10.0;
                label10.Text = iterm.ToString();
            }
            private void StickRespSlider_Scroll(object sender, EventArgs e)
            {
                stick_resp = (double)stick_resp_trk.Value / 10.0;
                label11.Text = stick_resp.ToString();
            }
            private void TrackingSlider_Scroll(object sender, EventArgs e)
            {
                tracking = (double)tracking_trk.Value / 10.0;
                label13.Text = tracking.ToString();
            }
            private void PidMasterSlider_Sroll(object sender, EventArgs e)
            {
                master = (double)master_trk.Value / 10.0;
                label14.Text = master.ToString();

                i_roll_updn.Text = CalculateI(i_roll).ToString();
                i_pitch_updn.Text = CalculateI(i_pitch).ToString();
                i_yaw_updn.Text = CalculateI(i_yaw).ToString();

                p_roll_updn.Text = CalculateP(p_roll).ToString();
                p_pitch_updn.Text = CalculateP(p_pitch).ToString();
                p_yaw_updn.Text = CalculateP(p_yaw).ToString();

                dmax_roll_updn.Text = CalculateDmax(dmax_roll).ToString();
                dmax_pitch_updn.Text = CalculateDmax(dmax_pitch).ToString();
                dmax_yaw_updn.Text = CalculateDmax(dmax_yaw).ToString();

                dmin_roll_updn.Text = CalculateDmin(dmin_roll).ToString();
                dmin_pitch_updn.Text = CalculateDmin(dmin_pitch).ToString();
                dmin_yaw_updn.Text = CalculateDmin(dmin_yaw).ToString();

                f_roll_updn.Text = CalculateFF(f_roll).ToString();
                f_pitch_updn.Text = CalculateFF(f_pitch).ToString();
                f_yaw_updn.Text = CalculateFF(f_yaw).ToString();

            }
            private void DynDampyngSlider_Scroll(object sender, EventArgs e)
            {
                dyn_damping = (double)trackBar4.Value / 10.0;
                label12.Text = dyn_damping.ToString();
            }

            // Pid Calcs
            private int CalculateP(double param)
            {
                int Dmax = (int)Math.Round(param * master_trk.Value * tracking_trk.Value);
                return Dmax;
            }
            private int CalculateI(double param)
            {
                int Dmax = (int)Math.Round(param * master_trk.Value * tracking_trk.Value * iterm_trk.Value);
                return Dmax;
            }
            private int CalculateFF(double param)
            {
                int Dmax = (int)Math.Round(param * master_trk.Value * stick_resp_trk.Value);
                return Dmax;
            }
            private int CalculateDmax(double param)
            {
                int Dmax = (int)Math.Round(param * master_trk.Value * damping_trk.Value * dyn_damping_trk.Value);
                return Dmax;
            }
            private int CalculateDmin(double param)
            {
                int Dmax = (int)Math.Round(param * master_trk.Value * damping_trk.Value);
                return Dmax;
            }

            // Pids Changed Values Tracking

        // FIlters
    
            // Filters Switches Handling
            private void LpfSwitchHandler(string ctrlname)
            {
                switch (ctrlname)
                {
                    // Gyro Lpf1 Switch
                    case "gyro_lpf1_ckbx":
                        if (!gyro_lpf1_ckbx.Checked)
                        {
                            gyro_dyn_lpf1_min_updn.Value = 0;
                            gyro_dyn_lpf1_max_updn.Value = 0;
                            gyro_static1_lpf_updn.Value = 0;
                            gyro_lpf1_gpbx.Enabled = false;
                        }
                        else
                        {
                            master = (double)master_trk.Value / 10.0;
                            if (gyro_lpf1_mode_cmbx.SelectedIndex == 1) //dynamic
                            {                            
                                gyro_dyn_lpf1_min_updn.Value = (decimal)(gyro_dyn_lpf1_min * gyro_trk.Value / 10.0);
                                gyro_dyn_lpf1_max_updn.Value = (decimal)(gyro_dyn_lpf1_max * gyro_trk.Value / 10.0);
                                gyro_static1_lpf_updn.Value = 0;
                                gyro_static1_gpbx.Enabled = false;
                                gyro_dyn_lpf1_gpbx.Enabled = true;
                            }
                            else
                            {
                                gyro_static1_lpf_updn.Value = (decimal)(gyro_static1 * gyro_trk.Value / 10.0);
                                gyro_dyn_lpf1_min_updn.Value = 0;
                                gyro_dyn_lpf1_max_updn.Value = 0;
                                gyro_dyn_lpf1_gpbx.Enabled = false;
                                gyro_static1_gpbx.Enabled = true;
                            }
                            gyro_lpf1_gpbx.Enabled = true;
                        }
                        break;

                    // Gyro Lpf2 Switch
                    case "gyro_lpf2_ckbx":
                        if (!gyro_lpf2_ckbx.Checked)
                        {
                            gyro_static2_lpf_updn.Value = 0;
                            gyro_static2_gpbx.Enabled = false;
                        }
                        else
                        {
                            gyro_static2_lpf_updn.Value = (decimal)(gyro_static2 * gyro_trk.Value / 10.0);
                            gyro_static2_gpbx.Enabled = true;
                        }
                    break;

                    case "dterm_lpf1_ckbx":
                        if (!dterm_lpf1_ckbx.Checked)
                        {
                            dterm_dyn_lpf1_min_updn.Value = 0;
                            dterm_dyn_lpf1_max_updn.Value = 0;
                            dterm_static1_lpf_updn.Value = 0;
                            dterm_lpf1_gpbx.Enabled = false;
                        }
                        else
                        {
                            master = (double)master_trk.Value / 10.0;
                            if (dterm_lpf1_mode_cmbx.SelectedIndex == 1) //dynamic
                            {
                                dterm_dyn_lpf1_min_updn.Value = (decimal)(dterm_dyn_lpf1_min * dterm_trk.Value / 10.0);
                                dterm_dyn_lpf1_max_updn.Value = (decimal)(dterm_dyn_lpf1_max * dterm_trk.Value / 10.0);
                                dterm_static1_lpf_updn.Value = 0;
                                dterm_static1_gpbx.Enabled = false;
                                dterm_dyn_lpf1_gpbx.Enabled = true;
                            }
                            else
                            {
                                dterm_static1_lpf_updn.Value = (decimal)(dterm_static1_lpf * dterm_trk.Value / 10.0);
                                dterm_dyn_lpf1_min_updn.Value = 0;
                                dterm_dyn_lpf1_max_updn.Value = 0;
                                dterm_dyn_lpf1_gpbx.Enabled = false;
                                dterm_static1_gpbx.Enabled = true;
                            }
                            dterm_lpf1_gpbx.Enabled = true;
                        }
                        break;

                    // D-Term Lpf2 Switch
                    case "dterm_lpf2_ckbx":
                        if (!dterm_lpf2_ckbx.Checked)
                        {
                            dterm_static2_lpf_updn.Value = 0;
                            dterm_static2_gpbx.Enabled = false;
                        }
                        else
                        {
                            dterm_static2_lpf_updn.Value = (decimal)(dterm_static2_lpf * dterm_trk.Value / 10.0);
                            dterm_static2_gpbx.Enabled = true;
                        }
                        break;

                    // Yaw Lpf
                    case " yaw_lpf_ckbx":
                        if (!yaw_lpf_ckbx.Checked)
                        {
                            yaw_lpf_updn.Value = 0;
                            yaw_lpf_gpbx.Enabled = false;
                        }
                        else yaw_lpf_gpbx.Enabled = true;
                        break;
                }
            }
            private void StaticNotchesSwitchHandler(string ctrlname)
            {
                switch (ctrlname)
                {

                    // Gyro Static Notches

                    // Gyro Notch1 Switch
                    case "gyro_notch1_ckbx":
                        if (!gyro_notch1_ckbx.Checked)
                        {
                            gyro_notch1_min_updn.Value = 0;
                            gyro_notch1_cntr_updn.Value = 0;
                            gyro_notch1_gpbx.Enabled = false;
                        }
                        else
                        {
                            gyro_notch1_min_updn.Value = 100;
                            gyro_notch1_cntr_updn.Value = 400;
                            gyro_notch1_gpbx.Enabled = true;
                        }
                        break;

                    // Gyro Notch2 Switch
                    case "gyro_notch2_ckbx":
                        if (!gyro_notch2_ckbx.Checked)
                        {
                            gyro_notch2_min_updn.Value = 0;
                            gyro_notch2_cntr_updn.Value = 0;
                            gyro_notch2_gpbx.Enabled = false;
                        }
                        else
                        {
                            gyro_notch2_min_updn.Value = 100;
                            gyro_notch2_cntr_updn.Value = 200;
                            gyro_notch2_gpbx.Enabled = true;
                        }
                        break;

                    // D-Term Static Notches

                    // D-Term Notch1 Switch
                    case "dterm_notch1_ckbx":
                        if (!dterm_notch1_ckbx.Checked)
                        {
                            dterm_notch1_min_updn.Value = 0;
                            dterm_notch1_cntr_updn.Value = 0;
                            dterm_notch1_gpbx.Enabled = false;
                        }
                        else
                        {
                            dterm_notch1_min_updn.Value = 100;
                            dterm_notch1_cntr_updn.Value = 400;
                            dterm_notch1_gpbx.Enabled = true;
                        }
                        break;

                    // D-Term Notch2 Switch
                    case "dterm_notch2_ckbx":
                        if (!dterm_notch2_ckbx.Checked)
                        {
                            dterm_notch2_min_updn.Value = 0;
                            dterm_notch2_cntr_updn.Value = 0;
                            dterm_notch2_gpbx.Enabled = false;
                        }
                        else
                        {
                            dterm_notch2_min_updn.Value = 100;
                            dterm_notch2_cntr_updn.Value = 200;
                            dterm_notch2_gpbx.Enabled = true;
                        }
                        break;
                }

            }

            // Filters Calc
            private void FiltersSliderCalc(string type)
            {
                switch (type)
                {
                    case "gyro":
                        if (gyro_simplyfied_cmbx.SelectedIndex == 0) //ON
                        {
                            double mult = gyro_trk.Value / 10.0;

                            if (gyro_lpf1_ckbx.Checked && gyro_lpf1_mode_cmbx.SelectedIndex == 1 && gyro_simplyfied_cmbx.SelectedIndex == 0)
                            {
                                gyro_dyn_lpf1_min_updn.Value = (int)((int)gyro_dyn_lpf1_min * mult);
                                gyro_dyn_lpf1_max_updn.Value = (int)((int)gyro_dyn_lpf1_max * mult);
                            }
                            else if (gyro_lpf1_ckbx.Checked && gyro_lpf1_mode_cmbx.SelectedIndex == 0 && gyro_simplyfied_cmbx.SelectedIndex == 0)
                            {
                                gyro_static1_lpf_updn.Value = (int)((int)gyro_static1 * mult);
                            }

                            if (gyro_lpf2_ckbx.Checked && gyro_simplyfied_cmbx.SelectedIndex == 0)
                            {
                                gyro_static2_lpf_updn.Value = (int)((int)gyro_static2 * mult);
                            }

                        }
                        break;

                    case "dterm":
                        if (dterm_simplyfied_cmbx.SelectedIndex == 0) //ON
                        {
                            double mult = dterm_trk.Value / 10.0;

                            if (dterm_lpf1_ckbx.Checked && dterm_lpf1_mode_cmbx.SelectedIndex == 1 && dterm_simplyfied_cmbx.SelectedIndex == 0)
                            {
                                dterm_dyn_lpf1_min_updn.Value = (int)((int)dterm_dyn_lpf1_min * mult);
                                dterm_dyn_lpf1_max_updn.Value = (int)((int)dterm_dyn_lpf1_max * mult);
                            }
                            else if (dterm_lpf1_ckbx.Checked && dterm_lpf1_mode_cmbx.SelectedIndex == 0 && dterm_simplyfied_cmbx.SelectedIndex == 0)
                            {
                                dterm_static1_lpf_updn.Value = (int)((int)dterm_static1_lpf * mult);
                            }

                            if (dterm_lpf2_ckbx.Checked && dterm_simplyfied_cmbx.SelectedIndex == 0)
                            {
                                dterm_static2_lpf_updn.Value = (int)((int)dterm_static2_lpf * mult);
                            }

                        }
                        break;
                }
            }

            // Filters Changed Values Tracking
            private void MasterSlider_Scroll_ChangedValues()
            {
                // Gyro lpf1
                if (gyro_lpf1_ckbx.Checked)
                {
                    switch (gyro_lpf1_mode_cmbx.SelectedIndex)
                    {
                        case 0:
                            gyro_static1_lpf_changed = true;
                            break;
                        case 1:
                            gyro_dyn_lpf_min_changed = true;
                            gyro_dyn_lpf_max_changed = true;
                            break;
                    }
                }

                // Gyro lpf2
                if (gyro_lpf2_ckbx.Checked) gyro_static1_lpf_changed = true;
            }
            private void DtermSlider_Scroll_ChangedValues()
            {
                // D-Term lpf1
                if (dterm_lpf1_ckbx.Checked)
                {
                    switch (dterm_lpf1_mode_cmbx.SelectedIndex)
                    {
                        case 0:
                            dterm_static1_lpf_changed = true;
                            break;
                        case 1:
                            dterm_dyn_lpf_min_changed = true;
                            dterm_dyn_lpf_max_changed = true;
                            break;
                    }
                }

                // D-Term lpf2
                if (dterm_lpf2_ckbx.Checked) dterm_static1_lpf_changed = true;
            }
        
        //Events
     
            // Filters Sliders
            private void gyro_trk_Scroll(object sender, EventArgs e)
            {
                double val = gyro_trk.Value / 10.0;
                gyro_slider_value_lbl.Text = "" + val;

                FiltersSliderCalc("gyro");
                MasterSlider_Scroll_ChangedValues();
            }
            private void DtermSliderScroll(object sender, EventArgs e)
            {
                double val = dterm_trk.Value / 10.0;
                dterm_slider_value_lbl.Text = "" + val;

                FiltersSliderCalc("dterm");
                DtermSlider_Scroll_ChangedValues();
            }

            // Gyro Filters Checkboxes
            private void gyro_lpf1_ckbx_CheckedChanged(object sender, EventArgs e)
            {
                LpfSwitchHandler("gyro_lpf1_ckbx");
            }
            private void gyro_lpf2_ckbx_CheckedChanged(object sender, EventArgs e)
            {
                LpfSwitchHandler("gyro_lpf2_ckbx");
            }
            private void gyro_notch1_ckbx_CheckedChanged(object sender, EventArgs e)
            {
                StaticNotchesSwitchHandler("gyro_notch1_ckbx");
            }
            private void gyro_notch2_ckbx_CheckedChanged(object sender, EventArgs e)
            {
                StaticNotchesSwitchHandler("gyro_notch2_ckbx");
            }
            private void rpm_notches_ckbx_CheckedChanged(object sender, EventArgs e)
            {
                if (!rpm_notches_ckbx.Checked)
                {
                    gyro_rpm_min_updn.Value = 0;
                    gyro_rpm_cnt_updn.Value = 0;
                    rpm_notches_gpbx.Enabled = false;
                }
                else
                {
                    rpm_notches_gpbx.Enabled = true;
                    gyro_rpm_min_updn.Value = 100;
                    gyro_rpm_cnt_updn.Value = 3;
                }
            }
            private void dyn_notches_ckbx_CheckedChanged(object sender, EventArgs e)
            {
                if (!dyn_notches_ckbx.Checked)
                {
                    gyro_dyn_notch_cnt_updn.Value = 0;
                    gyro_dyn_notch_wid_updn.Value = 0;
                    gyro_dyn_notch_min_updn.Value = 0;
                    gyro_dyn_notch_max_updn.Value = 0;
                    gyro_dyn_notch_gpbx.Enabled = false;
                }
                else
                {
                    gyro_dyn_notch_gpbx.Enabled = true;
                    gyro_dyn_notch_cnt_updn.Value = 5;//gyro_dyn_notch_cnt;
                    gyro_dyn_notch_min_updn.Value = 150;//gyro_dyn_notch_min;
                    gyro_dyn_notch_max_updn.Value = 600;//gyro_dyn_notch_max;
                    gyro_dyn_notch_wid_updn.Value = 500;//gyro_dyn_notch_width;
                }
            }
            private void yaw_lpf_ckbx_CheckedChanged(object sender, EventArgs e)
            {
                LpfSwitchHandler(" yaw_lpf_ckbx");
            }
        


            // D-Term Filters Checkboxes
            private void dterm_notch1_ckbx_CheckedChanged(object sender, EventArgs e)
            {
                StaticNotchesSwitchHandler("dterm_notch1_ckbx");
            }
            private void dterm_notch2_ckbx_CheckedChanged(object sender, EventArgs e)
            {
                StaticNotchesSwitchHandler("dterm_notch2_ckbx");
            }
            private void dterm_lpf1_ckbx_CheckedChanged(object sender, EventArgs e)
            {
                LpfSwitchHandler("dterm_lpf1_ckbx");
            }
            private void dterm_lpf2_ckbx_CheckedChanged(object sender, EventArgs e)
            {
                LpfSwitchHandler("dterm_lpf2_ckbx");
            }
       
            // Gyro FIlters ComboBoxes
            private void gyro_lpf1_mode_cmbx_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (gyro_lpf1_mode_cmbx.SelectedIndex == 1) //dynamic
                {
                    gyro_dyn_lpf1_min_updn.Value = (decimal)(gyro_dyn_lpf1_min * gyro_trk.Value / 10.0);
                    gyro_dyn_lpf1_max_updn.Value = (decimal)(gyro_dyn_lpf1_max * gyro_trk.Value / 10.0);
                    gyro_static1_lpf_updn.Value = 0;
                    gyro_static1_gpbx.Enabled = false;
                    gyro_dyn_lpf1_gpbx.Enabled = true;
                }
                else
                {
                    gyro_static1_lpf_updn.Value = (decimal)(gyro_static1 * gyro_trk.Value / 10.0);
                    gyro_dyn_lpf1_min_updn.Value = 0;
                    gyro_dyn_lpf1_max_updn.Value = 0;
                    gyro_dyn_lpf1_gpbx.Enabled = false;
                    gyro_static1_gpbx.Enabled = true;
                }
            }
            private void gyro_simplyfied_cmbx_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (gyro_simplyfied_cmbx.SelectedIndex == 1) gyro_trk.Enabled = false; //ON
                else gyro_trk.Enabled = true;
            }

            // D-Term FIlters ComboBoxes
            private void dterm_lpf1_mode_cmbx_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (dterm_lpf1_mode_cmbx.SelectedIndex == 1) //dynamic
                {
                    dterm_dyn_lpf1_min_updn.Value = (decimal)(dterm_dyn_lpf1_min * dterm_trk.Value / 10.0);
                    dterm_dyn_lpf1_max_updn.Value = (decimal)(dterm_dyn_lpf1_max * dterm_trk.Value / 10.0);
                    dterm_static1_lpf_updn.Value = 0;
                    dterm_static1_gpbx.Enabled = false;
                    dterm_dyn_lpf1_gpbx.Enabled = true;
                }
                else
                {
                    dterm_static1_lpf_updn.Value = (decimal)(dterm_static1_lpf * dterm_trk.Value / 10.0);
                    dterm_dyn_lpf1_min_updn.Value = 0;
                    dterm_dyn_lpf1_max_updn.Value = 0;
                    dterm_dyn_lpf1_gpbx.Enabled = false;
                    dterm_static1_gpbx.Enabled = true;
                }
            }
            private void dterm_simplyfied_cmbx_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (dterm_simplyfied_cmbx.SelectedIndex == 1) dterm_trk.Enabled = false; //ON
                else dterm_trk.Enabled = true;
            }
    }
}
