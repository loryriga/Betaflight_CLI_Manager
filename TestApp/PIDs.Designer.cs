
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace TestApp
{
    partial class PIDs
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
            this.dynamicTabControl = new System.Windows.Forms.TabControl();
            this.pid = new System.Windows.Forms.TabPage();
            this.label62 = new System.Windows.Forms.Label();
            this.dyn_damping_trk = new System.Windows.Forms.TrackBar();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.thrlin_updn = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.vbat_comp_updn = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.antig_mode_cmbx = new System.Windows.Forms.ComboBox();
            this.antig_gain_updn = new System.Windows.Forms.NumericUpDown();
            this.Feedforward = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.f_avg_cmbx = new System.Windows.Forms.ComboBox();
            this.f_transition_updn = new System.Windows.Forms.NumericUpDown();
            this.f_max_rate_updn = new System.Windows.Forms.NumericUpDown();
            this.f_boost_updn = new System.Windows.Forms.NumericUpDown();
            this.f_smooth_updn = new System.Windows.Forms.NumericUpDown();
            this.f_jit_updn = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.irel_type_cmbx = new System.Windows.Forms.ComboBox();
            this.irel_axis_cmbx = new System.Windows.Forms.ComboBox();
            this.irel_cutoff_updn = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.Master = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.master_trk = new System.Windows.Forms.TrackBar();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.tracking_trk = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.stick_resp_trk = new System.Windows.Forms.TrackBar();
            this.iterm_trk = new System.Windows.Forms.TrackBar();
            this.damping_trk = new System.Windows.Forms.TrackBar();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.f_yaw_updn = new System.Windows.Forms.NumericUpDown();
            this.dmin_yaw_updn = new System.Windows.Forms.NumericUpDown();
            this.dmax_yaw_updn = new System.Windows.Forms.NumericUpDown();
            this.i_yaw_updn = new System.Windows.Forms.NumericUpDown();
            this.p_yaw_updn = new System.Windows.Forms.NumericUpDown();
            this.f_pitch_updn = new System.Windows.Forms.NumericUpDown();
            this.dmin_pitch_updn = new System.Windows.Forms.NumericUpDown();
            this.dmax_pitch_updn = new System.Windows.Forms.NumericUpDown();
            this.i_pitch_updn = new System.Windows.Forms.NumericUpDown();
            this.p_pitch_updn = new System.Windows.Forms.NumericUpDown();
            this.f_roll_updn = new System.Windows.Forms.NumericUpDown();
            this.dmin_roll_updn = new System.Windows.Forms.NumericUpDown();
            this.dmax_roll_updn = new System.Windows.Forms.NumericUpDown();
            this.i_roll_updn = new System.Windows.Forms.NumericUpDown();
            this.p_roll_updn = new System.Windows.Forms.NumericUpDown();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.pid_simplyfied_tuning_cmbx = new System.Windows.Forms.ComboBox();
            this.rates = new System.Windows.Forms.TabPage();
            this.throttle_limit_type_updwn = new System.Windows.Forms.Label();
            this.thr_lim_type_cmbx = new System.Windows.Forms.ComboBox();
            this.thr_lim_updn = new System.Windows.Forms.NumericUpDown();
            this.tpa_att_updn = new System.Windows.Forms.NumericUpDown();
            this.tpa_brkpt_updn = new System.Windows.Forms.NumericUpDown();
            this.throttle_limit_updwn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filters = new System.Windows.Forms.TabPage();
            this.yaw_lpf_gpbx = new System.Windows.Forms.GroupBox();
            this.yaw_lpf_ckbx = new System.Windows.Forms.CheckBox();
            this.yaw_lpf_updn = new System.Windows.Forms.NumericUpDown();
            this.label65 = new System.Windows.Forms.Label();
            this.dterm_notches_gpbx = new System.Windows.Forms.GroupBox();
            this.dterm_notch2_gpbx = new System.Windows.Forms.GroupBox();
            this.dterm_notch2_ckbx = new System.Windows.Forms.CheckBox();
            this.dterm_notch2_cntr_updn = new System.Windows.Forms.NumericUpDown();
            this.dterm_notch2_min_updn = new System.Windows.Forms.NumericUpDown();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.dterm_notch1_gpbx = new System.Windows.Forms.GroupBox();
            this.dterm_notch1_ckbx = new System.Windows.Forms.CheckBox();
            this.dterm_notch1_cntr_updn = new System.Windows.Forms.NumericUpDown();
            this.dterm_notch1_min_updn = new System.Windows.Forms.NumericUpDown();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.dterm_simplyfied_cmbx = new System.Windows.Forms.ComboBox();
            this.dterm_lpf_gpbx = new System.Windows.Forms.GroupBox();
            this.dterm_lpf1_ckbx = new System.Windows.Forms.CheckBox();
            this.dterm_lpf1_gpbx = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dterm_static1_gpbx = new System.Windows.Forms.GroupBox();
            this.dterm_static1_lpf_updn = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.dterm_dyn_lpf1_gpbx = new System.Windows.Forms.GroupBox();
            this.dterm_dyn_lpf1_max_updn = new System.Windows.Forms.NumericUpDown();
            this.dterm_dyn_lpf1_min_updn = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.dterm_lpf1_type_cmbx = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.dterm_lpf1_mode_cmbx = new System.Windows.Forms.ComboBox();
            this.dterm_static2_gpbx = new System.Windows.Forms.GroupBox();
            this.dterm_static2_lpf_updn = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.dterm_static2_type_cmbx = new System.Windows.Forms.ComboBox();
            this.gyro_dyn_notch_gpbx = new System.Windows.Forms.GroupBox();
            this.dyn_notches_ckbx = new System.Windows.Forms.CheckBox();
            this.gyro_dyn_notch_max_updn = new System.Windows.Forms.NumericUpDown();
            this.label63 = new System.Windows.Forms.Label();
            this.gyro_dyn_notch_min_updn = new System.Windows.Forms.NumericUpDown();
            this.gyro_dyn_notch_wid_updn = new System.Windows.Forms.NumericUpDown();
            this.gyro_dyn_notch_cnt_updn = new System.Windows.Forms.NumericUpDown();
            this.label64 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.gyro_simplyfied_cmbx = new System.Windows.Forms.ComboBox();
            this.gyro_notches_gpbx = new System.Windows.Forms.GroupBox();
            this.gyro_notch2_gpbx = new System.Windows.Forms.GroupBox();
            this.gyro_notch2_ckbx = new System.Windows.Forms.CheckBox();
            this.gyro_notch2_cntr_updn = new System.Windows.Forms.NumericUpDown();
            this.gyro_notch2_min_updn = new System.Windows.Forms.NumericUpDown();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.gyro_notch1_gpbx = new System.Windows.Forms.GroupBox();
            this.gyro_notch1_ckbx = new System.Windows.Forms.CheckBox();
            this.gyro_notch1_cntr_updn = new System.Windows.Forms.NumericUpDown();
            this.gyro_notch1_min_updn = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.rpm_notches_gpbx = new System.Windows.Forms.GroupBox();
            this.rpm_notches_ckbx = new System.Windows.Forms.CheckBox();
            this.gyro_rpm_min_updn = new System.Windows.Forms.NumericUpDown();
            this.gyro_rpm_cnt_updn = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.dterm_slider_value_lbl = new System.Windows.Forms.Label();
            this.dterm_trk = new System.Windows.Forms.TrackBar();
            this.gyro_lpf_gpbx = new System.Windows.Forms.GroupBox();
            this.gyro_lpf1_ckbx = new System.Windows.Forms.CheckBox();
            this.gyro_lpf1_gpbx = new System.Windows.Forms.GroupBox();
            this.gyro_static1_type1 = new System.Windows.Forms.Label();
            this.gyro_static1_gpbx = new System.Windows.Forms.GroupBox();
            this.gyro_static1_lpf_updn = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.gyro_dyn_lpf1_gpbx = new System.Windows.Forms.GroupBox();
            this.gyro_dyn_lpf1_max_updn = new System.Windows.Forms.NumericUpDown();
            this.gyro_dyn_lpf1_min_updn = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gyro_lpf1_type_cmbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gyro_lpf1_mode_cmbx = new System.Windows.Forms.ComboBox();
            this.gyro_static2_gpbx = new System.Windows.Forms.GroupBox();
            this.gyro_lpf2_ckbx = new System.Windows.Forms.CheckBox();
            this.gyro_static2_lpf_updn = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gyro_static2_type_cmbx = new System.Windows.Forms.ComboBox();
            this.gyro_slider_value_lbl = new System.Windows.Forms.Label();
            this.gyro_trk = new System.Windows.Forms.TrackBar();
            this.extras = new System.Windows.Forms.TabPage();
            this.iterm_lim_updn = new System.Windows.Forms.NumericUpDown();
            this.pidsum_lim_yaw_updn = new System.Windows.Forms.NumericUpDown();
            this.pidsum_lim_updn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dterm_lpf2_ckbx = new System.Windows.Forms.CheckBox();
            this.dynamicTabControl.SuspendLayout();
            this.pid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dyn_damping_trk)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thrlin_updn)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vbat_comp_updn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antig_gain_updn)).BeginInit();
            this.Feedforward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_transition_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_max_rate_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_boost_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_smooth_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_jit_updn)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.irel_cutoff_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_trk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracking_trk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stick_resp_trk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterm_trk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damping_trk)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_yaw_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmin_yaw_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmax_yaw_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_yaw_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_yaw_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_pitch_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmin_pitch_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmax_pitch_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_pitch_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_pitch_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_roll_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmin_roll_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmax_roll_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_roll_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_roll_updn)).BeginInit();
            this.rates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thr_lim_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpa_att_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpa_brkpt_updn)).BeginInit();
            this.filters.SuspendLayout();
            this.yaw_lpf_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yaw_lpf_updn)).BeginInit();
            this.dterm_notches_gpbx.SuspendLayout();
            this.dterm_notch2_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_notch2_cntr_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_notch2_min_updn)).BeginInit();
            this.dterm_notch1_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_notch1_cntr_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_notch1_min_updn)).BeginInit();
            this.dterm_lpf_gpbx.SuspendLayout();
            this.dterm_lpf1_gpbx.SuspendLayout();
            this.dterm_static1_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_static1_lpf_updn)).BeginInit();
            this.dterm_dyn_lpf1_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_dyn_lpf1_max_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_dyn_lpf1_min_updn)).BeginInit();
            this.dterm_static2_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_static2_lpf_updn)).BeginInit();
            this.gyro_dyn_notch_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_dyn_notch_max_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_dyn_notch_min_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_dyn_notch_wid_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_dyn_notch_cnt_updn)).BeginInit();
            this.gyro_notches_gpbx.SuspendLayout();
            this.gyro_notch2_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_notch2_cntr_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_notch2_min_updn)).BeginInit();
            this.gyro_notch1_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_notch1_cntr_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_notch1_min_updn)).BeginInit();
            this.rpm_notches_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_rpm_min_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_rpm_cnt_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_trk)).BeginInit();
            this.gyro_lpf_gpbx.SuspendLayout();
            this.gyro_lpf1_gpbx.SuspendLayout();
            this.gyro_static1_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_static1_lpf_updn)).BeginInit();
            this.gyro_dyn_lpf1_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_dyn_lpf1_max_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_dyn_lpf1_min_updn)).BeginInit();
            this.gyro_static2_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_static2_lpf_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_trk)).BeginInit();
            this.extras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterm_lim_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pidsum_lim_yaw_updn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pidsum_lim_updn)).BeginInit();
            this.SuspendLayout();
            // 
            // dynamicTabControl
            // 
            this.dynamicTabControl.Controls.Add(this.pid);
            this.dynamicTabControl.Controls.Add(this.rates);
            this.dynamicTabControl.Controls.Add(this.filters);
            this.dynamicTabControl.Controls.Add(this.extras);
            this.dynamicTabControl.Font = new System.Drawing.Font("Calibri", 11F);
            this.dynamicTabControl.ForeColor = System.Drawing.Color.Black;
            this.dynamicTabControl.Location = new System.Drawing.Point(0, 0);
            this.dynamicTabControl.Name = "dynamicTabControl";
            this.dynamicTabControl.SelectedIndex = 0;
            this.dynamicTabControl.Size = new System.Drawing.Size(934, 906);
            this.dynamicTabControl.TabIndex = 0;
            // 
            // pid
            // 
            this.pid.Controls.Add(this.label62);
            this.pid.Controls.Add(this.dyn_damping_trk);
            this.pid.Controls.Add(this.groupBox10);
            this.pid.Controls.Add(this.label34);
            this.pid.Controls.Add(this.Master);
            this.pid.Controls.Add(this.label35);
            this.pid.Controls.Add(this.label36);
            this.pid.Controls.Add(this.label39);
            this.pid.Controls.Add(this.label40);
            this.pid.Controls.Add(this.label41);
            this.pid.Controls.Add(this.label42);
            this.pid.Controls.Add(this.master_trk);
            this.pid.Controls.Add(this.label43);
            this.pid.Controls.Add(this.label44);
            this.pid.Controls.Add(this.label45);
            this.pid.Controls.Add(this.label46);
            this.pid.Controls.Add(this.label47);
            this.pid.Controls.Add(this.tracking_trk);
            this.pid.Controls.Add(this.trackBar4);
            this.pid.Controls.Add(this.stick_resp_trk);
            this.pid.Controls.Add(this.iterm_trk);
            this.pid.Controls.Add(this.damping_trk);
            this.pid.Controls.Add(this.groupBox9);
            this.pid.Controls.Add(this.pid_simplyfied_tuning_cmbx);
            this.pid.Location = new System.Drawing.Point(4, 27);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(926, 875);
            this.pid.TabIndex = 0;
            this.pid.Text = "PID Tuning";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(15, 487);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(61, 18);
            this.label62.TabIndex = 69;
            this.label62.Text = "dyn dam";
            // 
            // dyn_damping_trk
            // 
            this.dyn_damping_trk.Location = new System.Drawing.Point(85, 487);
            this.dyn_damping_trk.Maximum = 20;
            this.dyn_damping_trk.Name = "dyn_damping_trk";
            this.dyn_damping_trk.Size = new System.Drawing.Size(324, 45);
            this.dyn_damping_trk.TabIndex = 68;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox4);
            this.groupBox10.Controls.Add(this.groupBox3);
            this.groupBox10.Controls.Add(this.groupBox1);
            this.groupBox10.Controls.Add(this.Feedforward);
            this.groupBox10.Controls.Add(this.groupBox2);
            this.groupBox10.Location = new System.Drawing.Point(439, 15);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(255, 701);
            this.groupBox10.TabIndex = 67;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "groupBox10";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.thrlin_updn);
            this.groupBox4.Location = new System.Drawing.Point(16, 613);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 77);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Throttle Linearization";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(102, 30);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 18);
            this.label24.TabIndex = 16;
            this.label24.Text = "Gain";
            // 
            // thrlin_updn
            // 
            this.thrlin_updn.Location = new System.Drawing.Point(39, 28);
            this.thrlin_updn.Name = "thrlin_updn";
            this.thrlin_updn.Size = new System.Drawing.Size(57, 25);
            this.thrlin_updn.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.vbat_comp_updn);
            this.groupBox3.Location = new System.Drawing.Point(16, 530);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 77);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Battery Sag Compensation";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(102, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 18);
            this.label23.TabIndex = 16;
            this.label23.Text = "Gain";
            // 
            // vbat_comp_updn
            // 
            this.vbat_comp_updn.Location = new System.Drawing.Point(39, 27);
            this.vbat_comp_updn.Name = "vbat_comp_updn";
            this.vbat_comp_updn.Size = new System.Drawing.Size(57, 25);
            this.vbat_comp_updn.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.antig_mode_cmbx);
            this.groupBox1.Controls.Add(this.antig_gain_updn);
            this.groupBox1.Location = new System.Drawing.Point(16, 398);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 131);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anty Gravity";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(102, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 18);
            this.label21.TabIndex = 16;
            this.label21.Text = "Gain";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(102, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 18);
            this.label22.TabIndex = 15;
            this.label22.Text = "Mode";
            // 
            // antig_mode_cmbx
            // 
            this.antig_mode_cmbx.FormattingEnabled = true;
            this.antig_mode_cmbx.Location = new System.Drawing.Point(39, 26);
            this.antig_mode_cmbx.Name = "antig_mode_cmbx";
            this.antig_mode_cmbx.Size = new System.Drawing.Size(57, 26);
            this.antig_mode_cmbx.TabIndex = 10;
            // 
            // antig_gain_updn
            // 
            this.antig_gain_updn.Location = new System.Drawing.Point(39, 58);
            this.antig_gain_updn.Name = "antig_gain_updn";
            this.antig_gain_updn.Size = new System.Drawing.Size(57, 25);
            this.antig_gain_updn.TabIndex = 6;
            // 
            // Feedforward
            // 
            this.Feedforward.Controls.Add(this.label17);
            this.Feedforward.Controls.Add(this.label16);
            this.Feedforward.Controls.Add(this.label15);
            this.Feedforward.Controls.Add(this.label14);
            this.Feedforward.Controls.Add(this.label13);
            this.Feedforward.Controls.Add(this.label12);
            this.Feedforward.Controls.Add(this.f_avg_cmbx);
            this.Feedforward.Controls.Add(this.f_transition_updn);
            this.Feedforward.Controls.Add(this.f_max_rate_updn);
            this.Feedforward.Controls.Add(this.f_boost_updn);
            this.Feedforward.Controls.Add(this.f_smooth_updn);
            this.Feedforward.Controls.Add(this.f_jit_updn);
            this.Feedforward.Location = new System.Drawing.Point(16, 24);
            this.Feedforward.Name = "Feedforward";
            this.Feedforward.Size = new System.Drawing.Size(225, 234);
            this.Feedforward.TabIndex = 18;
            this.Feedforward.TabStop = false;
            this.Feedforward.Text = "Feedforward";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(95, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 18);
            this.label17.TabIndex = 17;
            this.label17.Text = "Transition";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(95, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 18);
            this.label16.TabIndex = 16;
            this.label16.Text = "Max Rate Limit";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 18);
            this.label15.TabIndex = 15;
            this.label15.Text = "Boost";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(95, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 18);
            this.label14.TabIndex = 14;
            this.label14.Text = "Averaging";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 18);
            this.label13.TabIndex = 13;
            this.label13.Text = "Smoothness";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(95, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "Jitter Reduction";
            // 
            // f_avg_cmbx
            // 
            this.f_avg_cmbx.FormattingEnabled = true;
            this.f_avg_cmbx.Location = new System.Drawing.Point(32, 86);
            this.f_avg_cmbx.Name = "f_avg_cmbx";
            this.f_avg_cmbx.Size = new System.Drawing.Size(57, 26);
            this.f_avg_cmbx.TabIndex = 7;
            // 
            // f_transition_updn
            // 
            this.f_transition_updn.Location = new System.Drawing.Point(32, 179);
            this.f_transition_updn.Name = "f_transition_updn";
            this.f_transition_updn.Size = new System.Drawing.Size(57, 25);
            this.f_transition_updn.TabIndex = 5;
            // 
            // f_max_rate_updn
            // 
            this.f_max_rate_updn.Location = new System.Drawing.Point(32, 148);
            this.f_max_rate_updn.Name = "f_max_rate_updn";
            this.f_max_rate_updn.Size = new System.Drawing.Size(57, 25);
            this.f_max_rate_updn.TabIndex = 4;
            // 
            // f_boost_updn
            // 
            this.f_boost_updn.Location = new System.Drawing.Point(32, 117);
            this.f_boost_updn.Name = "f_boost_updn";
            this.f_boost_updn.Size = new System.Drawing.Size(57, 25);
            this.f_boost_updn.TabIndex = 3;
            // 
            // f_smooth_updn
            // 
            this.f_smooth_updn.Location = new System.Drawing.Point(32, 55);
            this.f_smooth_updn.Name = "f_smooth_updn";
            this.f_smooth_updn.Size = new System.Drawing.Size(57, 25);
            this.f_smooth_updn.TabIndex = 1;
            // 
            // f_jit_updn
            // 
            this.f_jit_updn.Location = new System.Drawing.Point(32, 24);
            this.f_jit_updn.Name = "f_jit_updn";
            this.f_jit_updn.Size = new System.Drawing.Size(57, 25);
            this.f_jit_updn.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.irel_type_cmbx);
            this.groupBox2.Controls.Add(this.irel_axis_cmbx);
            this.groupBox2.Controls.Add(this.irel_cutoff_updn);
            this.groupBox2.Location = new System.Drawing.Point(16, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 133);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "I-Term Relax";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(95, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 18);
            this.label20.TabIndex = 15;
            this.label20.Text = "Cutoff";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(95, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 18);
            this.label19.TabIndex = 14;
            this.label19.Text = "Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(95, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 18);
            this.label18.TabIndex = 13;
            this.label18.Text = "Axes";
            // 
            // irel_type_cmbx
            // 
            this.irel_type_cmbx.FormattingEnabled = true;
            this.irel_type_cmbx.Location = new System.Drawing.Point(32, 57);
            this.irel_type_cmbx.Name = "irel_type_cmbx";
            this.irel_type_cmbx.Size = new System.Drawing.Size(57, 26);
            this.irel_type_cmbx.TabIndex = 9;
            // 
            // irel_axis_cmbx
            // 
            this.irel_axis_cmbx.FormattingEnabled = true;
            this.irel_axis_cmbx.Location = new System.Drawing.Point(32, 25);
            this.irel_axis_cmbx.Name = "irel_axis_cmbx";
            this.irel_axis_cmbx.Size = new System.Drawing.Size(57, 26);
            this.irel_axis_cmbx.TabIndex = 8;
            // 
            // irel_cutoff_updn
            // 
            this.irel_cutoff_updn.Location = new System.Drawing.Point(32, 89);
            this.irel_cutoff_updn.Name = "irel_cutoff_updn";
            this.irel_cutoff_updn.Size = new System.Drawing.Size(57, 25);
            this.irel_cutoff_updn.TabIndex = 2;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(15, 182);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(53, 18);
            this.label34.TabIndex = 66;
            this.label34.Text = "label34";
            // 
            // Master
            // 
            this.Master.AutoSize = true;
            this.Master.Location = new System.Drawing.Point(15, 552);
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(51, 18);
            this.Master.TabIndex = 64;
            this.Master.Text = "Master";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(13, 273);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(57, 18);
            this.label35.TabIndex = 63;
            this.label35.Text = "tracking";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(15, 375);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(72, 18);
            this.label36.TabIndex = 62;
            this.label36.Text = "pitch track";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(15, 324);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(65, 18);
            this.label39.TabIndex = 61;
            this.label39.Text = "stick resp";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(15, 431);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(62, 18);
            this.label40.TabIndex = 60;
            this.label40.Text = "wobble i";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(11, 222);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(63, 18);
            this.label41.TabIndex = 59;
            this.label41.Text = "Damping";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(227, 466);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(53, 18);
            this.label42.TabIndex = 58;
            this.label42.Text = "label42";
            // 
            // master_trk
            // 
            this.master_trk.Location = new System.Drawing.Point(85, 552);
            this.master_trk.Maximum = 20;
            this.master_trk.Name = "master_trk";
            this.master_trk.Size = new System.Drawing.Size(324, 45);
            this.master_trk.TabIndex = 57;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(227, 415);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(53, 18);
            this.label43.TabIndex = 56;
            this.label43.Text = "label43";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(227, 356);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(53, 18);
            this.label44.TabIndex = 55;
            this.label44.Text = "label44";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(227, 308);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(53, 18);
            this.label45.TabIndex = 54;
            this.label45.Text = "label45";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(227, 254);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(53, 18);
            this.label46.TabIndex = 53;
            this.label46.Text = "label46";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(227, 206);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(53, 18);
            this.label47.TabIndex = 52;
            this.label47.Text = "label47";
            // 
            // tracking_trk
            // 
            this.tracking_trk.Location = new System.Drawing.Point(83, 273);
            this.tracking_trk.Maximum = 20;
            this.tracking_trk.Name = "tracking_trk";
            this.tracking_trk.Size = new System.Drawing.Size(324, 45);
            this.tracking_trk.TabIndex = 51;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(85, 375);
            this.trackBar4.Maximum = 20;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(324, 45);
            this.trackBar4.TabIndex = 50;
            // 
            // stick_resp_trk
            // 
            this.stick_resp_trk.Location = new System.Drawing.Point(85, 324);
            this.stick_resp_trk.Maximum = 20;
            this.stick_resp_trk.Name = "stick_resp_trk";
            this.stick_resp_trk.Size = new System.Drawing.Size(324, 45);
            this.stick_resp_trk.TabIndex = 49;
            // 
            // iterm_trk
            // 
            this.iterm_trk.Location = new System.Drawing.Point(85, 431);
            this.iterm_trk.Maximum = 20;
            this.iterm_trk.Name = "iterm_trk";
            this.iterm_trk.Size = new System.Drawing.Size(324, 45);
            this.iterm_trk.TabIndex = 48;
            // 
            // damping_trk
            // 
            this.damping_trk.Location = new System.Drawing.Point(85, 222);
            this.damping_trk.Maximum = 20;
            this.damping_trk.Name = "damping_trk";
            this.damping_trk.Size = new System.Drawing.Size(324, 45);
            this.damping_trk.TabIndex = 47;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.f_yaw_updn);
            this.groupBox9.Controls.Add(this.dmin_yaw_updn);
            this.groupBox9.Controls.Add(this.dmax_yaw_updn);
            this.groupBox9.Controls.Add(this.i_yaw_updn);
            this.groupBox9.Controls.Add(this.p_yaw_updn);
            this.groupBox9.Controls.Add(this.f_pitch_updn);
            this.groupBox9.Controls.Add(this.dmin_pitch_updn);
            this.groupBox9.Controls.Add(this.dmax_pitch_updn);
            this.groupBox9.Controls.Add(this.i_pitch_updn);
            this.groupBox9.Controls.Add(this.p_pitch_updn);
            this.groupBox9.Controls.Add(this.f_roll_updn);
            this.groupBox9.Controls.Add(this.dmin_roll_updn);
            this.groupBox9.Controls.Add(this.dmax_roll_updn);
            this.groupBox9.Controls.Add(this.i_roll_updn);
            this.groupBox9.Controls.Add(this.p_roll_updn);
            this.groupBox9.Controls.Add(this.label48);
            this.groupBox9.Controls.Add(this.label49);
            this.groupBox9.Controls.Add(this.label50);
            this.groupBox9.Controls.Add(this.label51);
            this.groupBox9.Controls.Add(this.label52);
            this.groupBox9.Controls.Add(this.label53);
            this.groupBox9.Controls.Add(this.label54);
            this.groupBox9.Controls.Add(this.label55);
            this.groupBox9.Location = new System.Drawing.Point(18, 15);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(404, 147);
            this.groupBox9.TabIndex = 46;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "groupBox9";
            // 
            // f_yaw_updn
            // 
            this.f_yaw_updn.Location = new System.Drawing.Point(334, 105);
            this.f_yaw_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.f_yaw_updn.Name = "f_yaw_updn";
            this.f_yaw_updn.Size = new System.Drawing.Size(55, 25);
            this.f_yaw_updn.TabIndex = 81;
            // 
            // dmin_yaw_updn
            // 
            this.dmin_yaw_updn.Location = new System.Drawing.Point(269, 105);
            this.dmin_yaw_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.dmin_yaw_updn.Name = "dmin_yaw_updn";
            this.dmin_yaw_updn.Size = new System.Drawing.Size(55, 25);
            this.dmin_yaw_updn.TabIndex = 80;
            // 
            // dmax_yaw_updn
            // 
            this.dmax_yaw_updn.Location = new System.Drawing.Point(203, 105);
            this.dmax_yaw_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.dmax_yaw_updn.Name = "dmax_yaw_updn";
            this.dmax_yaw_updn.Size = new System.Drawing.Size(55, 25);
            this.dmax_yaw_updn.TabIndex = 79;
            // 
            // i_yaw_updn
            // 
            this.i_yaw_updn.Location = new System.Drawing.Point(137, 105);
            this.i_yaw_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.i_yaw_updn.Name = "i_yaw_updn";
            this.i_yaw_updn.Size = new System.Drawing.Size(55, 25);
            this.i_yaw_updn.TabIndex = 78;
            // 
            // p_yaw_updn
            // 
            this.p_yaw_updn.Location = new System.Drawing.Point(71, 105);
            this.p_yaw_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.p_yaw_updn.Name = "p_yaw_updn";
            this.p_yaw_updn.Size = new System.Drawing.Size(55, 25);
            this.p_yaw_updn.TabIndex = 77;
            // 
            // f_pitch_updn
            // 
            this.f_pitch_updn.Location = new System.Drawing.Point(335, 74);
            this.f_pitch_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.f_pitch_updn.Name = "f_pitch_updn";
            this.f_pitch_updn.Size = new System.Drawing.Size(55, 25);
            this.f_pitch_updn.TabIndex = 76;
            // 
            // dmin_pitch_updn
            // 
            this.dmin_pitch_updn.Location = new System.Drawing.Point(270, 74);
            this.dmin_pitch_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.dmin_pitch_updn.Name = "dmin_pitch_updn";
            this.dmin_pitch_updn.Size = new System.Drawing.Size(55, 25);
            this.dmin_pitch_updn.TabIndex = 75;
            // 
            // dmax_pitch_updn
            // 
            this.dmax_pitch_updn.Location = new System.Drawing.Point(204, 74);
            this.dmax_pitch_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.dmax_pitch_updn.Name = "dmax_pitch_updn";
            this.dmax_pitch_updn.Size = new System.Drawing.Size(55, 25);
            this.dmax_pitch_updn.TabIndex = 74;
            // 
            // i_pitch_updn
            // 
            this.i_pitch_updn.Location = new System.Drawing.Point(138, 74);
            this.i_pitch_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.i_pitch_updn.Name = "i_pitch_updn";
            this.i_pitch_updn.Size = new System.Drawing.Size(55, 25);
            this.i_pitch_updn.TabIndex = 73;
            // 
            // p_pitch_updn
            // 
            this.p_pitch_updn.Location = new System.Drawing.Point(72, 74);
            this.p_pitch_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.p_pitch_updn.Name = "p_pitch_updn";
            this.p_pitch_updn.Size = new System.Drawing.Size(55, 25);
            this.p_pitch_updn.TabIndex = 72;
            // 
            // f_roll_updn
            // 
            this.f_roll_updn.Location = new System.Drawing.Point(335, 40);
            this.f_roll_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.f_roll_updn.Name = "f_roll_updn";
            this.f_roll_updn.Size = new System.Drawing.Size(55, 25);
            this.f_roll_updn.TabIndex = 71;
            // 
            // dmin_roll_updn
            // 
            this.dmin_roll_updn.Location = new System.Drawing.Point(270, 40);
            this.dmin_roll_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.dmin_roll_updn.Name = "dmin_roll_updn";
            this.dmin_roll_updn.Size = new System.Drawing.Size(55, 25);
            this.dmin_roll_updn.TabIndex = 70;
            // 
            // dmax_roll_updn
            // 
            this.dmax_roll_updn.Location = new System.Drawing.Point(204, 40);
            this.dmax_roll_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.dmax_roll_updn.Name = "dmax_roll_updn";
            this.dmax_roll_updn.Size = new System.Drawing.Size(55, 25);
            this.dmax_roll_updn.TabIndex = 69;
            // 
            // i_roll_updn
            // 
            this.i_roll_updn.Location = new System.Drawing.Point(138, 40);
            this.i_roll_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.i_roll_updn.Name = "i_roll_updn";
            this.i_roll_updn.Size = new System.Drawing.Size(55, 25);
            this.i_roll_updn.TabIndex = 68;
            // 
            // p_roll_updn
            // 
            this.p_roll_updn.Location = new System.Drawing.Point(72, 40);
            this.p_roll_updn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.p_roll_updn.Name = "p_roll_updn";
            this.p_roll_updn.Size = new System.Drawing.Size(55, 25);
            this.p_roll_updn.TabIndex = 67;
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(331, 13);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(60, 25);
            this.label48.TabIndex = 23;
            this.label48.Text = "FF";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(6, 103);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(60, 25);
            this.label49.TabIndex = 19;
            this.label49.Text = "Yaw";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label50
            // 
            this.label50.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(6, 72);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(60, 25);
            this.label50.TabIndex = 18;
            this.label50.Text = "Pitch";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label51
            // 
            this.label51.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(6, 40);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(60, 25);
            this.label51.TabIndex = 17;
            this.label51.Text = "Roll";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(265, 13);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(60, 25);
            this.label52.TabIndex = 16;
            this.label52.Text = "Dmin";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(199, 13);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(60, 25);
            this.label53.TabIndex = 15;
            this.label53.Text = "Dmax";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(133, 13);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(60, 25);
            this.label54.TabIndex = 14;
            this.label54.Text = "I";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label55
            // 
            this.label55.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(67, 13);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(60, 25);
            this.label55.TabIndex = 13;
            this.label55.Text = "P";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pid_simplyfied_tuning_cmbx
            // 
            this.pid_simplyfied_tuning_cmbx.FormattingEnabled = true;
            this.pid_simplyfied_tuning_cmbx.Location = new System.Drawing.Point(74, 179);
            this.pid_simplyfied_tuning_cmbx.Name = "pid_simplyfied_tuning_cmbx";
            this.pid_simplyfied_tuning_cmbx.Size = new System.Drawing.Size(57, 26);
            this.pid_simplyfied_tuning_cmbx.TabIndex = 11;
            // 
            // rates
            // 
            this.rates.Controls.Add(this.throttle_limit_type_updwn);
            this.rates.Controls.Add(this.thr_lim_type_cmbx);
            this.rates.Controls.Add(this.thr_lim_updn);
            this.rates.Controls.Add(this.tpa_att_updn);
            this.rates.Controls.Add(this.tpa_brkpt_updn);
            this.rates.Controls.Add(this.throttle_limit_updwn);
            this.rates.Controls.Add(this.label5);
            this.rates.Controls.Add(this.label6);
            this.rates.Location = new System.Drawing.Point(4, 27);
            this.rates.Name = "rates";
            this.rates.Size = new System.Drawing.Size(926, 875);
            this.rates.TabIndex = 1;
            this.rates.Text = "Rates";
            // 
            // throttle_limit_type_updwn
            // 
            this.throttle_limit_type_updwn.AutoSize = true;
            this.throttle_limit_type_updwn.Location = new System.Drawing.Point(30, 145);
            this.throttle_limit_type_updwn.Name = "throttle_limit_type_updwn";
            this.throttle_limit_type_updwn.Size = new System.Drawing.Size(124, 18);
            this.throttle_limit_type_updwn.TabIndex = 13;
            this.throttle_limit_type_updwn.Text = "Throttle Limit Type";
            this.throttle_limit_type_updwn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // thr_lim_type_cmbx
            // 
            this.thr_lim_type_cmbx.FormattingEnabled = true;
            this.thr_lim_type_cmbx.Location = new System.Drawing.Point(197, 142);
            this.thr_lim_type_cmbx.Name = "thr_lim_type_cmbx";
            this.thr_lim_type_cmbx.Size = new System.Drawing.Size(82, 26);
            this.thr_lim_type_cmbx.TabIndex = 12;
            // 
            // thr_lim_updn
            // 
            this.thr_lim_updn.Location = new System.Drawing.Point(197, 106);
            this.thr_lim_updn.Name = "thr_lim_updn";
            this.thr_lim_updn.Size = new System.Drawing.Size(82, 25);
            this.thr_lim_updn.TabIndex = 11;
            // 
            // tpa_att_updn
            // 
            this.tpa_att_updn.Location = new System.Drawing.Point(197, 69);
            this.tpa_att_updn.Name = "tpa_att_updn";
            this.tpa_att_updn.Size = new System.Drawing.Size(82, 25);
            this.tpa_att_updn.TabIndex = 10;
            // 
            // tpa_brkpt_updn
            // 
            this.tpa_brkpt_updn.Location = new System.Drawing.Point(197, 33);
            this.tpa_brkpt_updn.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.tpa_brkpt_updn.Name = "tpa_brkpt_updn";
            this.tpa_brkpt_updn.Size = new System.Drawing.Size(82, 25);
            this.tpa_brkpt_updn.TabIndex = 9;
            // 
            // throttle_limit_updwn
            // 
            this.throttle_limit_updwn.AutoSize = true;
            this.throttle_limit_updwn.Location = new System.Drawing.Point(70, 108);
            this.throttle_limit_updwn.Name = "throttle_limit_updwn";
            this.throttle_limit_updwn.Size = new System.Drawing.Size(92, 18);
            this.throttle_limit_updwn.TabIndex = 8;
            this.throttle_limit_updwn.Text = "Throttle Limit";
            this.throttle_limit_updwn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "TPA Attenuation";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "TPA Breakpoint";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // filters
            // 
            this.filters.Controls.Add(this.yaw_lpf_ckbx);
            this.filters.Controls.Add(this.rpm_notches_ckbx);
            this.filters.Controls.Add(this.dyn_notches_ckbx);
            this.filters.Controls.Add(this.yaw_lpf_gpbx);
            this.filters.Controls.Add(this.dterm_notches_gpbx);
            this.filters.Controls.Add(this.dterm_simplyfied_cmbx);
            this.filters.Controls.Add(this.dterm_lpf_gpbx);
            this.filters.Controls.Add(this.gyro_dyn_notch_gpbx);
            this.filters.Controls.Add(this.gyro_simplyfied_cmbx);
            this.filters.Controls.Add(this.gyro_notches_gpbx);
            this.filters.Controls.Add(this.rpm_notches_gpbx);
            this.filters.Controls.Add(this.dterm_slider_value_lbl);
            this.filters.Controls.Add(this.dterm_trk);
            this.filters.Controls.Add(this.gyro_lpf_gpbx);
            this.filters.Controls.Add(this.gyro_slider_value_lbl);
            this.filters.Controls.Add(this.gyro_trk);
            this.filters.Location = new System.Drawing.Point(4, 27);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(926, 875);
            this.filters.TabIndex = 2;
            this.filters.Text = "Filters";
            // 
            // yaw_lpf_gpbx
            // 
            this.yaw_lpf_gpbx.Controls.Add(this.yaw_lpf_updn);
            this.yaw_lpf_gpbx.Controls.Add(this.label65);
            this.yaw_lpf_gpbx.Location = new System.Drawing.Point(340, 605);
            this.yaw_lpf_gpbx.Name = "yaw_lpf_gpbx";
            this.yaw_lpf_gpbx.Size = new System.Drawing.Size(156, 95);
            this.yaw_lpf_gpbx.TabIndex = 73;
            this.yaw_lpf_gpbx.TabStop = false;
            this.yaw_lpf_gpbx.Text = "groupBox5";
            // 
            // yaw_lpf_ckbx
            // 
            this.yaw_lpf_ckbx.AutoSize = true;
            this.yaw_lpf_ckbx.Location = new System.Drawing.Point(351, 711);
            this.yaw_lpf_ckbx.Name = "yaw_lpf_ckbx";
            this.yaw_lpf_ckbx.Size = new System.Drawing.Size(92, 22);
            this.yaw_lpf_ckbx.TabIndex = 73;
            this.yaw_lpf_ckbx.Text = "checkBox2";
            this.yaw_lpf_ckbx.UseVisualStyleBackColor = true;
            this.yaw_lpf_ckbx.CheckedChanged += new System.EventHandler(this.yaw_lpf_ckbx_CheckedChanged);
            // 
            // yaw_lpf_updn
            // 
            this.yaw_lpf_updn.Location = new System.Drawing.Point(27, 38);
            this.yaw_lpf_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.yaw_lpf_updn.Name = "yaw_lpf_updn";
            this.yaw_lpf_updn.Size = new System.Drawing.Size(49, 25);
            this.yaw_lpf_updn.TabIndex = 72;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(82, 40);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(45, 18);
            this.label65.TabIndex = 71;
            this.label65.Text = "Count";
            // 
            // dterm_notches_gpbx
            // 
            this.dterm_notches_gpbx.Controls.Add(this.dterm_notch2_ckbx);
            this.dterm_notches_gpbx.Controls.Add(this.dterm_notch1_ckbx);
            this.dterm_notches_gpbx.Controls.Add(this.dterm_notch2_gpbx);
            this.dterm_notches_gpbx.Controls.Add(this.dterm_notch1_gpbx);
            this.dterm_notches_gpbx.Location = new System.Drawing.Point(477, 597);
            this.dterm_notches_gpbx.Name = "dterm_notches_gpbx";
            this.dterm_notches_gpbx.Size = new System.Drawing.Size(308, 142);
            this.dterm_notches_gpbx.TabIndex = 58;
            this.dterm_notches_gpbx.TabStop = false;
            this.dterm_notches_gpbx.Text = "Static Notches";
            // 
            // dterm_notch2_gpbx
            // 
            this.dterm_notch2_gpbx.Controls.Add(this.dterm_notch2_cntr_updn);
            this.dterm_notch2_gpbx.Controls.Add(this.dterm_notch2_min_updn);
            this.dterm_notch2_gpbx.Controls.Add(this.label56);
            this.dterm_notch2_gpbx.Controls.Add(this.label57);
            this.dterm_notch2_gpbx.Location = new System.Drawing.Point(146, 24);
            this.dterm_notch2_gpbx.Name = "dterm_notch2_gpbx";
            this.dterm_notch2_gpbx.Size = new System.Drawing.Size(150, 90);
            this.dterm_notch2_gpbx.TabIndex = 55;
            this.dterm_notch2_gpbx.TabStop = false;
            this.dterm_notch2_gpbx.Text = "groupBox13";
            // 
            // dterm_notch2_ckbx
            // 
            this.dterm_notch2_ckbx.AutoSize = true;
            this.dterm_notch2_ckbx.Location = new System.Drawing.Point(165, 113);
            this.dterm_notch2_ckbx.Name = "dterm_notch2_ckbx";
            this.dterm_notch2_ckbx.Size = new System.Drawing.Size(92, 22);
            this.dterm_notch2_ckbx.TabIndex = 58;
            this.dterm_notch2_ckbx.Text = "checkBox2";
            this.dterm_notch2_ckbx.UseVisualStyleBackColor = true;
            this.dterm_notch2_ckbx.CheckedChanged += new System.EventHandler(this.dterm_notch2_ckbx_CheckedChanged);
            // 
            // dterm_notch2_cntr_updn
            // 
            this.dterm_notch2_cntr_updn.Location = new System.Drawing.Point(17, 54);
            this.dterm_notch2_cntr_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.dterm_notch2_cntr_updn.Name = "dterm_notch2_cntr_updn";
            this.dterm_notch2_cntr_updn.Size = new System.Drawing.Size(49, 25);
            this.dterm_notch2_cntr_updn.TabIndex = 53;
            // 
            // dterm_notch2_min_updn
            // 
            this.dterm_notch2_min_updn.Location = new System.Drawing.Point(17, 23);
            this.dterm_notch2_min_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.dterm_notch2_min_updn.Name = "dterm_notch2_min_updn";
            this.dterm_notch2_min_updn.Size = new System.Drawing.Size(49, 25);
            this.dterm_notch2_min_updn.TabIndex = 52;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(72, 56);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(48, 18);
            this.label56.TabIndex = 51;
            this.label56.Text = "center";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(72, 25);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(35, 18);
            this.label57.TabIndex = 50;
            this.label57.Text = " min";
            // 
            // dterm_notch1_gpbx
            // 
            this.dterm_notch1_gpbx.Controls.Add(this.dterm_notch1_cntr_updn);
            this.dterm_notch1_gpbx.Controls.Add(this.dterm_notch1_min_updn);
            this.dterm_notch1_gpbx.Controls.Add(this.label60);
            this.dterm_notch1_gpbx.Controls.Add(this.label61);
            this.dterm_notch1_gpbx.Location = new System.Drawing.Point(9, 24);
            this.dterm_notch1_gpbx.Name = "dterm_notch1_gpbx";
            this.dterm_notch1_gpbx.Size = new System.Drawing.Size(131, 90);
            this.dterm_notch1_gpbx.TabIndex = 54;
            this.dterm_notch1_gpbx.TabStop = false;
            this.dterm_notch1_gpbx.Text = "groupBox7";
            // 
            // dterm_notch1_ckbx
            // 
            this.dterm_notch1_ckbx.AutoSize = true;
            this.dterm_notch1_ckbx.Location = new System.Drawing.Point(36, 113);
            this.dterm_notch1_ckbx.Name = "dterm_notch1_ckbx";
            this.dterm_notch1_ckbx.Size = new System.Drawing.Size(92, 22);
            this.dterm_notch1_ckbx.TabIndex = 57;
            this.dterm_notch1_ckbx.Text = "checkBox2";
            this.dterm_notch1_ckbx.UseVisualStyleBackColor = true;
            this.dterm_notch1_ckbx.CheckedChanged += new System.EventHandler(this.dterm_notch1_ckbx_CheckedChanged);
            // 
            // dterm_notch1_cntr_updn
            // 
            this.dterm_notch1_cntr_updn.Location = new System.Drawing.Point(19, 46);
            this.dterm_notch1_cntr_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.dterm_notch1_cntr_updn.Name = "dterm_notch1_cntr_updn";
            this.dterm_notch1_cntr_updn.Size = new System.Drawing.Size(49, 25);
            this.dterm_notch1_cntr_updn.TabIndex = 49;
            // 
            // dterm_notch1_min_updn
            // 
            this.dterm_notch1_min_updn.Location = new System.Drawing.Point(19, 15);
            this.dterm_notch1_min_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.dterm_notch1_min_updn.Name = "dterm_notch1_min_updn";
            this.dterm_notch1_min_updn.Size = new System.Drawing.Size(49, 25);
            this.dterm_notch1_min_updn.TabIndex = 48;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(74, 48);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(48, 18);
            this.label60.TabIndex = 42;
            this.label60.Text = "center";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(74, 17);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(35, 18);
            this.label61.TabIndex = 41;
            this.label61.Text = " min";
            // 
            // dterm_simplyfied_cmbx
            // 
            this.dterm_simplyfied_cmbx.FormattingEnabled = true;
            this.dterm_simplyfied_cmbx.Location = new System.Drawing.Point(864, 156);
            this.dterm_simplyfied_cmbx.Name = "dterm_simplyfied_cmbx";
            this.dterm_simplyfied_cmbx.Size = new System.Drawing.Size(49, 26);
            this.dterm_simplyfied_cmbx.TabIndex = 70;
            this.dterm_simplyfied_cmbx.SelectedIndexChanged += new System.EventHandler(this.dterm_simplyfied_cmbx_SelectedIndexChanged);
            // 
            // dterm_lpf_gpbx
            // 
            this.dterm_lpf_gpbx.Controls.Add(this.dterm_lpf2_ckbx);
            this.dterm_lpf_gpbx.Controls.Add(this.dterm_lpf1_ckbx);
            this.dterm_lpf_gpbx.Controls.Add(this.dterm_lpf1_gpbx);
            this.dterm_lpf_gpbx.Controls.Add(this.dterm_static2_gpbx);
            this.dterm_lpf_gpbx.Location = new System.Drawing.Point(477, 156);
            this.dterm_lpf_gpbx.Name = "dterm_lpf_gpbx";
            this.dterm_lpf_gpbx.Size = new System.Drawing.Size(398, 443);
            this.dterm_lpf_gpbx.TabIndex = 69;
            this.dterm_lpf_gpbx.TabStop = false;
            this.dterm_lpf_gpbx.Text = "Gyro Lowpass Filters";
            // 
            // dterm_lpf1_ckbx
            // 
            this.dterm_lpf1_ckbx.AutoSize = true;
            this.dterm_lpf1_ckbx.Location = new System.Drawing.Point(263, 23);
            this.dterm_lpf1_ckbx.Name = "dterm_lpf1_ckbx";
            this.dterm_lpf1_ckbx.Size = new System.Drawing.Size(92, 22);
            this.dterm_lpf1_ckbx.TabIndex = 55;
            this.dterm_lpf1_ckbx.Text = "checkBox1";
            this.dterm_lpf1_ckbx.UseVisualStyleBackColor = true;
            this.dterm_lpf1_ckbx.CheckedChanged += new System.EventHandler(this.dterm_lpf1_ckbx_CheckedChanged);
            // 
            // dterm_lpf1_gpbx
            // 
            this.dterm_lpf1_gpbx.Controls.Add(this.label25);
            this.dterm_lpf1_gpbx.Controls.Add(this.dterm_static1_gpbx);
            this.dterm_lpf1_gpbx.Controls.Add(this.dterm_dyn_lpf1_gpbx);
            this.dterm_lpf1_gpbx.Controls.Add(this.dterm_lpf1_type_cmbx);
            this.dterm_lpf1_gpbx.Controls.Add(this.label29);
            this.dterm_lpf1_gpbx.Controls.Add(this.dterm_lpf1_mode_cmbx);
            this.dterm_lpf1_gpbx.Location = new System.Drawing.Point(19, 36);
            this.dterm_lpf1_gpbx.Name = "dterm_lpf1_gpbx";
            this.dterm_lpf1_gpbx.Size = new System.Drawing.Size(342, 294);
            this.dterm_lpf1_gpbx.TabIndex = 55;
            this.dterm_lpf1_gpbx.TabStop = false;
            this.dterm_lpf1_gpbx.Text = "groupBox7";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(253, 153);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 18);
            this.label25.TabIndex = 45;
            this.label25.Text = "type";
            // 
            // dterm_static1_gpbx
            // 
            this.dterm_static1_gpbx.Controls.Add(this.dterm_static1_lpf_updn);
            this.dterm_static1_gpbx.Controls.Add(this.label26);
            this.dterm_static1_gpbx.Location = new System.Drawing.Point(12, 191);
            this.dterm_static1_gpbx.Name = "dterm_static1_gpbx";
            this.dterm_static1_gpbx.Size = new System.Drawing.Size(235, 93);
            this.dterm_static1_gpbx.TabIndex = 54;
            this.dterm_static1_gpbx.TabStop = false;
            this.dterm_static1_gpbx.Text = "groupBox11";
            // 
            // dterm_static1_lpf_updn
            // 
            this.dterm_static1_lpf_updn.Location = new System.Drawing.Point(16, 28);
            this.dterm_static1_lpf_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.dterm_static1_lpf_updn.Name = "dterm_static1_lpf_updn";
            this.dterm_static1_lpf_updn.Size = new System.Drawing.Size(49, 25);
            this.dterm_static1_lpf_updn.TabIndex = 50;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(71, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(155, 18);
            this.label26.TabIndex = 44;
            this.label26.Text = "gyro_static1_lpf_updwn";
            // 
            // dterm_dyn_lpf1_gpbx
            // 
            this.dterm_dyn_lpf1_gpbx.Controls.Add(this.dterm_dyn_lpf1_max_updn);
            this.dterm_dyn_lpf1_gpbx.Controls.Add(this.dterm_dyn_lpf1_min_updn);
            this.dterm_dyn_lpf1_gpbx.Controls.Add(this.label27);
            this.dterm_dyn_lpf1_gpbx.Controls.Add(this.label28);
            this.dterm_dyn_lpf1_gpbx.Location = new System.Drawing.Point(12, 46);
            this.dterm_dyn_lpf1_gpbx.Name = "dterm_dyn_lpf1_gpbx";
            this.dterm_dyn_lpf1_gpbx.Size = new System.Drawing.Size(175, 88);
            this.dterm_dyn_lpf1_gpbx.TabIndex = 53;
            this.dterm_dyn_lpf1_gpbx.TabStop = false;
            this.dterm_dyn_lpf1_gpbx.Text = "groupBox8";
            // 
            // dterm_dyn_lpf1_max_updn
            // 
            this.dterm_dyn_lpf1_max_updn.Location = new System.Drawing.Point(16, 48);
            this.dterm_dyn_lpf1_max_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.dterm_dyn_lpf1_max_updn.Name = "dterm_dyn_lpf1_max_updn";
            this.dterm_dyn_lpf1_max_updn.Size = new System.Drawing.Size(49, 25);
            this.dterm_dyn_lpf1_max_updn.TabIndex = 49;
            // 
            // dterm_dyn_lpf1_min_updn
            // 
            this.dterm_dyn_lpf1_min_updn.Location = new System.Drawing.Point(16, 18);
            this.dterm_dyn_lpf1_min_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.dterm_dyn_lpf1_min_updn.Name = "dterm_dyn_lpf1_min_updn";
            this.dterm_dyn_lpf1_min_updn.Size = new System.Drawing.Size(49, 25);
            this.dterm_dyn_lpf1_min_updn.TabIndex = 48;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(70, 50);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 18);
            this.label27.TabIndex = 42;
            this.label27.Text = "gyro_max";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(71, 20);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(62, 18);
            this.label28.TabIndex = 41;
            this.label28.Text = "gyro min";
            // 
            // dterm_lpf1_type_cmbx
            // 
            this.dterm_lpf1_type_cmbx.FormattingEnabled = true;
            this.dterm_lpf1_type_cmbx.Location = new System.Drawing.Point(198, 150);
            this.dterm_lpf1_type_cmbx.Name = "dterm_lpf1_type_cmbx";
            this.dterm_lpf1_type_cmbx.Size = new System.Drawing.Size(49, 26);
            this.dterm_lpf1_type_cmbx.TabIndex = 39;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(95, 155);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 18);
            this.label29.TabIndex = 43;
            this.label29.Text = "mode";
            // 
            // dterm_lpf1_mode_cmbx
            // 
            this.dterm_lpf1_mode_cmbx.FormattingEnabled = true;
            this.dterm_lpf1_mode_cmbx.Location = new System.Drawing.Point(30, 147);
            this.dterm_lpf1_mode_cmbx.Name = "dterm_lpf1_mode_cmbx";
            this.dterm_lpf1_mode_cmbx.Size = new System.Drawing.Size(49, 26);
            this.dterm_lpf1_mode_cmbx.TabIndex = 38;
            this.dterm_lpf1_mode_cmbx.SelectedIndexChanged += new System.EventHandler(this.dterm_lpf1_mode_cmbx_SelectedIndexChanged);
            // 
            // dterm_static2_gpbx
            // 
            this.dterm_static2_gpbx.Controls.Add(this.dterm_static2_lpf_updn);
            this.dterm_static2_gpbx.Controls.Add(this.label30);
            this.dterm_static2_gpbx.Controls.Add(this.label31);
            this.dterm_static2_gpbx.Controls.Add(this.dterm_static2_type_cmbx);
            this.dterm_static2_gpbx.Location = new System.Drawing.Point(19, 336);
            this.dterm_static2_gpbx.Name = "dterm_static2_gpbx";
            this.dterm_static2_gpbx.Size = new System.Drawing.Size(150, 88);
            this.dterm_static2_gpbx.TabIndex = 52;
            this.dterm_static2_gpbx.TabStop = false;
            this.dterm_static2_gpbx.Text = "groupBox7";
            // 
            // dterm_static2_lpf_updn
            // 
            this.dterm_static2_lpf_updn.Location = new System.Drawing.Point(17, 20);
            this.dterm_static2_lpf_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.dterm_static2_lpf_updn.Name = "dterm_static2_lpf_updn";
            this.dterm_static2_lpf_updn.Size = new System.Drawing.Size(49, 25);
            this.dterm_static2_lpf_updn.TabIndex = 51;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(71, 61);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 18);
            this.label30.TabIndex = 47;
            this.label30.Text = "label30";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(71, 29);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 18);
            this.label31.TabIndex = 46;
            this.label31.Text = "label31";
            // 
            // dterm_static2_type_cmbx
            // 
            this.dterm_static2_type_cmbx.FormattingEnabled = true;
            this.dterm_static2_type_cmbx.Location = new System.Drawing.Point(17, 58);
            this.dterm_static2_type_cmbx.Name = "dterm_static2_type_cmbx";
            this.dterm_static2_type_cmbx.Size = new System.Drawing.Size(49, 26);
            this.dterm_static2_type_cmbx.TabIndex = 40;
            // 
            // gyro_dyn_notch_gpbx
            // 
            this.gyro_dyn_notch_gpbx.Controls.Add(this.gyro_dyn_notch_max_updn);
            this.gyro_dyn_notch_gpbx.Controls.Add(this.label63);
            this.gyro_dyn_notch_gpbx.Controls.Add(this.gyro_dyn_notch_min_updn);
            this.gyro_dyn_notch_gpbx.Controls.Add(this.gyro_dyn_notch_wid_updn);
            this.gyro_dyn_notch_gpbx.Controls.Add(this.gyro_dyn_notch_cnt_updn);
            this.gyro_dyn_notch_gpbx.Controls.Add(this.label64);
            this.gyro_dyn_notch_gpbx.Controls.Add(this.label66);
            this.gyro_dyn_notch_gpbx.Controls.Add(this.label67);
            this.gyro_dyn_notch_gpbx.Location = new System.Drawing.Point(477, 738);
            this.gyro_dyn_notch_gpbx.Name = "gyro_dyn_notch_gpbx";
            this.gyro_dyn_notch_gpbx.Size = new System.Drawing.Size(266, 134);
            this.gyro_dyn_notch_gpbx.TabIndex = 68;
            this.gyro_dyn_notch_gpbx.TabStop = false;
            this.gyro_dyn_notch_gpbx.Text = "groupBox7";
            // 
            // dyn_notches_ckbx
            // 
            this.dyn_notches_ckbx.AutoSize = true;
            this.dyn_notches_ckbx.Location = new System.Drawing.Point(748, 788);
            this.dyn_notches_ckbx.Name = "dyn_notches_ckbx";
            this.dyn_notches_ckbx.Size = new System.Drawing.Size(127, 22);
            this.dyn_notches_ckbx.TabIndex = 68;
            this.dyn_notches_ckbx.Text = "dyn_notch_ckbx";
            this.dyn_notches_ckbx.UseVisualStyleBackColor = true;
            this.dyn_notches_ckbx.CheckedChanged += new System.EventHandler(this.dyn_notches_ckbx_CheckedChanged);
            // 
            // gyro_dyn_notch_max_updn
            // 
            this.gyro_dyn_notch_max_updn.Location = new System.Drawing.Point(173, 109);
            this.gyro_dyn_notch_max_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.gyro_dyn_notch_max_updn.Name = "gyro_dyn_notch_max_updn";
            this.gyro_dyn_notch_max_updn.Size = new System.Drawing.Size(82, 25);
            this.gyro_dyn_notch_max_updn.TabIndex = 67;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(46, 111);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(60, 18);
            this.label63.TabIndex = 66;
            this.label63.Text = "dyn max";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gyro_dyn_notch_min_updn
            // 
            this.gyro_dyn_notch_min_updn.Location = new System.Drawing.Point(173, 78);
            this.gyro_dyn_notch_min_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.gyro_dyn_notch_min_updn.Name = "gyro_dyn_notch_min_updn";
            this.gyro_dyn_notch_min_updn.Size = new System.Drawing.Size(82, 25);
            this.gyro_dyn_notch_min_updn.TabIndex = 65;
            // 
            // gyro_dyn_notch_wid_updn
            // 
            this.gyro_dyn_notch_wid_updn.Location = new System.Drawing.Point(173, 47);
            this.gyro_dyn_notch_wid_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.gyro_dyn_notch_wid_updn.Name = "gyro_dyn_notch_wid_updn";
            this.gyro_dyn_notch_wid_updn.Size = new System.Drawing.Size(82, 25);
            this.gyro_dyn_notch_wid_updn.TabIndex = 64;
            // 
            // gyro_dyn_notch_cnt_updn
            // 
            this.gyro_dyn_notch_cnt_updn.Location = new System.Drawing.Point(173, 16);
            this.gyro_dyn_notch_cnt_updn.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.gyro_dyn_notch_cnt_updn.Name = "gyro_dyn_notch_cnt_updn";
            this.gyro_dyn_notch_cnt_updn.Size = new System.Drawing.Size(82, 25);
            this.gyro_dyn_notch_cnt_updn.TabIndex = 63;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(46, 80);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(58, 18);
            this.label64.TabIndex = 62;
            this.label64.Text = "dyn min";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(42, 49);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(57, 18);
            this.label66.TabIndex = 61;
            this.label66.Text = "dyn wid";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(31, 18);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(66, 18);
            this.label67.TabIndex = 60;
            this.label67.Text = "din count";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gyro_simplyfied_cmbx
            // 
            this.gyro_simplyfied_cmbx.FormattingEnabled = true;
            this.gyro_simplyfied_cmbx.Location = new System.Drawing.Point(422, 179);
            this.gyro_simplyfied_cmbx.Name = "gyro_simplyfied_cmbx";
            this.gyro_simplyfied_cmbx.Size = new System.Drawing.Size(49, 26);
            this.gyro_simplyfied_cmbx.TabIndex = 37;
            this.gyro_simplyfied_cmbx.SelectedIndexChanged += new System.EventHandler(this.gyro_simplyfied_cmbx_SelectedIndexChanged);
            // 
            // gyro_notches_gpbx
            // 
            this.gyro_notches_gpbx.Controls.Add(this.gyro_notch2_ckbx);
            this.gyro_notches_gpbx.Controls.Add(this.gyro_notch1_ckbx);
            this.gyro_notches_gpbx.Controls.Add(this.gyro_notch2_gpbx);
            this.gyro_notches_gpbx.Controls.Add(this.gyro_notch1_gpbx);
            this.gyro_notches_gpbx.Location = new System.Drawing.Point(18, 597);
            this.gyro_notches_gpbx.Name = "gyro_notches_gpbx";
            this.gyro_notches_gpbx.Size = new System.Drawing.Size(308, 142);
            this.gyro_notches_gpbx.TabIndex = 57;
            this.gyro_notches_gpbx.TabStop = false;
            this.gyro_notches_gpbx.Text = "Static Notches";
            // 
            // gyro_notch2_gpbx
            // 
            this.gyro_notch2_gpbx.Controls.Add(this.gyro_notch2_cntr_updn);
            this.gyro_notch2_gpbx.Controls.Add(this.gyro_notch2_min_updn);
            this.gyro_notch2_gpbx.Controls.Add(this.label58);
            this.gyro_notch2_gpbx.Controls.Add(this.label59);
            this.gyro_notch2_gpbx.Location = new System.Drawing.Point(146, 24);
            this.gyro_notch2_gpbx.Name = "gyro_notch2_gpbx";
            this.gyro_notch2_gpbx.Size = new System.Drawing.Size(150, 84);
            this.gyro_notch2_gpbx.TabIndex = 55;
            this.gyro_notch2_gpbx.TabStop = false;
            this.gyro_notch2_gpbx.Text = "groupBox13";
            // 
            // gyro_notch2_ckbx
            // 
            this.gyro_notch2_ckbx.AutoSize = true;
            this.gyro_notch2_ckbx.Location = new System.Drawing.Point(165, 114);
            this.gyro_notch2_ckbx.Name = "gyro_notch2_ckbx";
            this.gyro_notch2_ckbx.Size = new System.Drawing.Size(92, 22);
            this.gyro_notch2_ckbx.TabIndex = 59;
            this.gyro_notch2_ckbx.Text = "checkBox2";
            this.gyro_notch2_ckbx.UseVisualStyleBackColor = true;
            this.gyro_notch2_ckbx.CheckedChanged += new System.EventHandler(this.gyro_notch2_ckbx_CheckedChanged);
            // 
            // gyro_notch2_cntr_updn
            // 
            this.gyro_notch2_cntr_updn.Location = new System.Drawing.Point(17, 54);
            this.gyro_notch2_cntr_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.gyro_notch2_cntr_updn.Name = "gyro_notch2_cntr_updn";
            this.gyro_notch2_cntr_updn.Size = new System.Drawing.Size(49, 25);
            this.gyro_notch2_cntr_updn.TabIndex = 53;
            // 
            // gyro_notch2_min_updn
            // 
            this.gyro_notch2_min_updn.Location = new System.Drawing.Point(17, 23);
            this.gyro_notch2_min_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.gyro_notch2_min_updn.Name = "gyro_notch2_min_updn";
            this.gyro_notch2_min_updn.Size = new System.Drawing.Size(49, 25);
            this.gyro_notch2_min_updn.TabIndex = 52;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(72, 56);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(48, 18);
            this.label58.TabIndex = 51;
            this.label58.Text = "center";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(72, 25);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(35, 18);
            this.label59.TabIndex = 50;
            this.label59.Text = " min";
            // 
            // gyro_notch1_gpbx
            // 
            this.gyro_notch1_gpbx.Controls.Add(this.gyro_notch1_cntr_updn);
            this.gyro_notch1_gpbx.Controls.Add(this.gyro_notch1_min_updn);
            this.gyro_notch1_gpbx.Controls.Add(this.label32);
            this.gyro_notch1_gpbx.Controls.Add(this.label33);
            this.gyro_notch1_gpbx.Location = new System.Drawing.Point(9, 24);
            this.gyro_notch1_gpbx.Name = "gyro_notch1_gpbx";
            this.gyro_notch1_gpbx.Size = new System.Drawing.Size(131, 79);
            this.gyro_notch1_gpbx.TabIndex = 54;
            this.gyro_notch1_gpbx.TabStop = false;
            this.gyro_notch1_gpbx.Text = "groupBox7";
            // 
            // gyro_notch1_ckbx
            // 
            this.gyro_notch1_ckbx.AutoSize = true;
            this.gyro_notch1_ckbx.Location = new System.Drawing.Point(20, 114);
            this.gyro_notch1_ckbx.Name = "gyro_notch1_ckbx";
            this.gyro_notch1_ckbx.Size = new System.Drawing.Size(92, 22);
            this.gyro_notch1_ckbx.TabIndex = 58;
            this.gyro_notch1_ckbx.Text = "checkBox2";
            this.gyro_notch1_ckbx.UseVisualStyleBackColor = true;
            this.gyro_notch1_ckbx.CheckedChanged += new System.EventHandler(this.gyro_notch1_ckbx_CheckedChanged);
            // 
            // gyro_notch1_cntr_updn
            // 
            this.gyro_notch1_cntr_updn.Location = new System.Drawing.Point(19, 46);
            this.gyro_notch1_cntr_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.gyro_notch1_cntr_updn.Name = "gyro_notch1_cntr_updn";
            this.gyro_notch1_cntr_updn.Size = new System.Drawing.Size(49, 25);
            this.gyro_notch1_cntr_updn.TabIndex = 49;
            // 
            // gyro_notch1_min_updn
            // 
            this.gyro_notch1_min_updn.Location = new System.Drawing.Point(19, 15);
            this.gyro_notch1_min_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.gyro_notch1_min_updn.Name = "gyro_notch1_min_updn";
            this.gyro_notch1_min_updn.Size = new System.Drawing.Size(49, 25);
            this.gyro_notch1_min_updn.TabIndex = 48;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(74, 48);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(48, 18);
            this.label32.TabIndex = 42;
            this.label32.Text = "center";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(74, 17);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 18);
            this.label33.TabIndex = 41;
            this.label33.Text = " min";
            // 
            // rpm_notches_gpbx
            // 
            this.rpm_notches_gpbx.Controls.Add(this.gyro_rpm_min_updn);
            this.rpm_notches_gpbx.Controls.Add(this.gyro_rpm_cnt_updn);
            this.rpm_notches_gpbx.Controls.Add(this.label37);
            this.rpm_notches_gpbx.Controls.Add(this.label38);
            this.rpm_notches_gpbx.Location = new System.Drawing.Point(27, 745);
            this.rpm_notches_gpbx.Name = "rpm_notches_gpbx";
            this.rpm_notches_gpbx.Size = new System.Drawing.Size(155, 103);
            this.rpm_notches_gpbx.TabIndex = 56;
            this.rpm_notches_gpbx.TabStop = false;
            this.rpm_notches_gpbx.Text = "Rpm Filters";
            // 
            // rpm_notches_ckbx
            // 
            this.rpm_notches_ckbx.AutoSize = true;
            this.rpm_notches_ckbx.Location = new System.Drawing.Point(196, 788);
            this.rpm_notches_ckbx.Name = "rpm_notches_ckbx";
            this.rpm_notches_ckbx.Size = new System.Drawing.Size(92, 22);
            this.rpm_notches_ckbx.TabIndex = 60;
            this.rpm_notches_ckbx.Text = "checkBox2";
            this.rpm_notches_ckbx.UseVisualStyleBackColor = true;
            this.rpm_notches_ckbx.CheckedChanged += new System.EventHandler(this.rpm_notches_ckbx_CheckedChanged);
            // 
            // gyro_rpm_min_updn
            // 
            this.gyro_rpm_min_updn.Location = new System.Drawing.Point(21, 58);
            this.gyro_rpm_min_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.gyro_rpm_min_updn.Name = "gyro_rpm_min_updn";
            this.gyro_rpm_min_updn.Size = new System.Drawing.Size(49, 25);
            this.gyro_rpm_min_updn.TabIndex = 49;
            // 
            // gyro_rpm_cnt_updn
            // 
            this.gyro_rpm_cnt_updn.Location = new System.Drawing.Point(21, 32);
            this.gyro_rpm_cnt_updn.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.gyro_rpm_cnt_updn.Name = "gyro_rpm_cnt_updn";
            this.gyro_rpm_cnt_updn.Size = new System.Drawing.Size(49, 25);
            this.gyro_rpm_cnt_updn.TabIndex = 48;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(76, 60);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(50, 18);
            this.label37.TabIndex = 42;
            this.label37.Text = "Min Hz";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(76, 34);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(45, 18);
            this.label38.TabIndex = 41;
            this.label38.Text = "Count";
            // 
            // dterm_slider_value_lbl
            // 
            this.dterm_slider_value_lbl.AutoSize = true;
            this.dterm_slider_value_lbl.Location = new System.Drawing.Point(348, 91);
            this.dterm_slider_value_lbl.Name = "dterm_slider_value_lbl";
            this.dterm_slider_value_lbl.Size = new System.Drawing.Size(15, 18);
            this.dterm_slider_value_lbl.TabIndex = 55;
            this.dterm_slider_value_lbl.Text = "0";
            // 
            // dterm_trk
            // 
            this.dterm_trk.Location = new System.Drawing.Point(37, 105);
            this.dterm_trk.Maximum = 20;
            this.dterm_trk.Name = "dterm_trk";
            this.dterm_trk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dterm_trk.Size = new System.Drawing.Size(603, 45);
            this.dterm_trk.TabIndex = 54;
            this.dterm_trk.Scroll += new System.EventHandler(this.DtermSliderScroll);
            // 
            // gyro_lpf_gpbx
            // 
            this.gyro_lpf_gpbx.Controls.Add(this.gyro_lpf2_ckbx);
            this.gyro_lpf_gpbx.Controls.Add(this.gyro_lpf1_ckbx);
            this.gyro_lpf_gpbx.Controls.Add(this.gyro_lpf1_gpbx);
            this.gyro_lpf_gpbx.Controls.Add(this.gyro_static2_gpbx);
            this.gyro_lpf_gpbx.Location = new System.Drawing.Point(18, 156);
            this.gyro_lpf_gpbx.Name = "gyro_lpf_gpbx";
            this.gyro_lpf_gpbx.Size = new System.Drawing.Size(398, 443);
            this.gyro_lpf_gpbx.TabIndex = 52;
            this.gyro_lpf_gpbx.TabStop = false;
            this.gyro_lpf_gpbx.Text = "Gyro Lowpass Filters";
            // 
            // gyro_lpf1_ckbx
            // 
            this.gyro_lpf1_ckbx.AutoSize = true;
            this.gyro_lpf1_ckbx.Location = new System.Drawing.Point(253, 23);
            this.gyro_lpf1_ckbx.Name = "gyro_lpf1_ckbx";
            this.gyro_lpf1_ckbx.Size = new System.Drawing.Size(92, 22);
            this.gyro_lpf1_ckbx.TabIndex = 56;
            this.gyro_lpf1_ckbx.Text = "checkBox2";
            this.gyro_lpf1_ckbx.UseVisualStyleBackColor = true;
            this.gyro_lpf1_ckbx.CheckedChanged += new System.EventHandler(this.gyro_lpf1_ckbx_CheckedChanged);
            // 
            // gyro_lpf1_gpbx
            // 
            this.gyro_lpf1_gpbx.Controls.Add(this.gyro_static1_type1);
            this.gyro_lpf1_gpbx.Controls.Add(this.gyro_static1_gpbx);
            this.gyro_lpf1_gpbx.Controls.Add(this.gyro_dyn_lpf1_gpbx);
            this.gyro_lpf1_gpbx.Controls.Add(this.gyro_lpf1_type_cmbx);
            this.gyro_lpf1_gpbx.Controls.Add(this.label9);
            this.gyro_lpf1_gpbx.Controls.Add(this.gyro_lpf1_mode_cmbx);
            this.gyro_lpf1_gpbx.Location = new System.Drawing.Point(19, 36);
            this.gyro_lpf1_gpbx.Name = "gyro_lpf1_gpbx";
            this.gyro_lpf1_gpbx.Size = new System.Drawing.Size(342, 294);
            this.gyro_lpf1_gpbx.TabIndex = 55;
            this.gyro_lpf1_gpbx.TabStop = false;
            this.gyro_lpf1_gpbx.Text = "gyro_lpf1_gpbx";
            // 
            // gyro_static1_type1
            // 
            this.gyro_static1_type1.AutoSize = true;
            this.gyro_static1_type1.Location = new System.Drawing.Point(257, 153);
            this.gyro_static1_type1.Name = "gyro_static1_type1";
            this.gyro_static1_type1.Size = new System.Drawing.Size(63, 18);
            this.gyro_static1_type1.TabIndex = 45;
            this.gyro_static1_type1.Text = "lpf1 type";
            // 
            // gyro_static1_gpbx
            // 
            this.gyro_static1_gpbx.Controls.Add(this.gyro_static1_lpf_updn);
            this.gyro_static1_gpbx.Controls.Add(this.label8);
            this.gyro_static1_gpbx.Location = new System.Drawing.Point(12, 191);
            this.gyro_static1_gpbx.Name = "gyro_static1_gpbx";
            this.gyro_static1_gpbx.Size = new System.Drawing.Size(235, 93);
            this.gyro_static1_gpbx.TabIndex = 54;
            this.gyro_static1_gpbx.TabStop = false;
            this.gyro_static1_gpbx.Text = "gyro_static1_gpbx";
            // 
            // gyro_static1_lpf_updn
            // 
            this.gyro_static1_lpf_updn.Location = new System.Drawing.Point(16, 28);
            this.gyro_static1_lpf_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.gyro_static1_lpf_updn.Name = "gyro_static1_lpf_updn";
            this.gyro_static1_lpf_updn.Size = new System.Drawing.Size(49, 25);
            this.gyro_static1_lpf_updn.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 18);
            this.label8.TabIndex = 44;
            this.label8.Text = "gyro_static1_lpf_updwn";
            // 
            // gyro_dyn_lpf1_gpbx
            // 
            this.gyro_dyn_lpf1_gpbx.Controls.Add(this.gyro_dyn_lpf1_max_updn);
            this.gyro_dyn_lpf1_gpbx.Controls.Add(this.gyro_dyn_lpf1_min_updn);
            this.gyro_dyn_lpf1_gpbx.Controls.Add(this.label10);
            this.gyro_dyn_lpf1_gpbx.Controls.Add(this.label11);
            this.gyro_dyn_lpf1_gpbx.Location = new System.Drawing.Point(12, 46);
            this.gyro_dyn_lpf1_gpbx.Name = "gyro_dyn_lpf1_gpbx";
            this.gyro_dyn_lpf1_gpbx.Size = new System.Drawing.Size(175, 88);
            this.gyro_dyn_lpf1_gpbx.TabIndex = 53;
            this.gyro_dyn_lpf1_gpbx.TabStop = false;
            this.gyro_dyn_lpf1_gpbx.Text = "gyro_dyn_lpf1_gpbx";
            // 
            // gyro_dyn_lpf1_max_updn
            // 
            this.gyro_dyn_lpf1_max_updn.Location = new System.Drawing.Point(16, 48);
            this.gyro_dyn_lpf1_max_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.gyro_dyn_lpf1_max_updn.Name = "gyro_dyn_lpf1_max_updn";
            this.gyro_dyn_lpf1_max_updn.Size = new System.Drawing.Size(49, 25);
            this.gyro_dyn_lpf1_max_updn.TabIndex = 49;
            // 
            // gyro_dyn_lpf1_min_updn
            // 
            this.gyro_dyn_lpf1_min_updn.Location = new System.Drawing.Point(16, 18);
            this.gyro_dyn_lpf1_min_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.gyro_dyn_lpf1_min_updn.Name = "gyro_dyn_lpf1_min_updn";
            this.gyro_dyn_lpf1_min_updn.Size = new System.Drawing.Size(49, 25);
            this.gyro_dyn_lpf1_min_updn.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 18);
            this.label10.TabIndex = 42;
            this.label10.Text = "gyro_max";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 41;
            this.label11.Text = "gyro min";
            // 
            // gyro_lpf1_type_cmbx
            // 
            this.gyro_lpf1_type_cmbx.FormattingEnabled = true;
            this.gyro_lpf1_type_cmbx.Location = new System.Drawing.Point(202, 150);
            this.gyro_lpf1_type_cmbx.Name = "gyro_lpf1_type_cmbx";
            this.gyro_lpf1_type_cmbx.Size = new System.Drawing.Size(49, 26);
            this.gyro_lpf1_type_cmbx.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 43;
            this.label9.Text = "gyro lpf1 mode";
            // 
            // gyro_lpf1_mode_cmbx
            // 
            this.gyro_lpf1_mode_cmbx.FormattingEnabled = true;
            this.gyro_lpf1_mode_cmbx.Location = new System.Drawing.Point(30, 147);
            this.gyro_lpf1_mode_cmbx.Name = "gyro_lpf1_mode_cmbx";
            this.gyro_lpf1_mode_cmbx.Size = new System.Drawing.Size(49, 26);
            this.gyro_lpf1_mode_cmbx.TabIndex = 38;
            this.gyro_lpf1_mode_cmbx.SelectedIndexChanged += new System.EventHandler(this.gyro_lpf1_mode_cmbx_SelectedIndexChanged);
            // 
            // gyro_static2_gpbx
            // 
            this.gyro_static2_gpbx.Controls.Add(this.gyro_static2_lpf_updn);
            this.gyro_static2_gpbx.Controls.Add(this.label7);
            this.gyro_static2_gpbx.Controls.Add(this.label4);
            this.gyro_static2_gpbx.Controls.Add(this.gyro_static2_type_cmbx);
            this.gyro_static2_gpbx.Location = new System.Drawing.Point(20, 336);
            this.gyro_static2_gpbx.Name = "gyro_static2_gpbx";
            this.gyro_static2_gpbx.Size = new System.Drawing.Size(161, 88);
            this.gyro_static2_gpbx.TabIndex = 52;
            this.gyro_static2_gpbx.TabStop = false;
            this.gyro_static2_gpbx.Text = "gyro_static2_gpbx";
            // 
            // gyro_lpf2_ckbx
            // 
            this.gyro_lpf2_ckbx.AutoSize = true;
            this.gyro_lpf2_ckbx.Location = new System.Drawing.Point(204, 369);
            this.gyro_lpf2_ckbx.Name = "gyro_lpf2_ckbx";
            this.gyro_lpf2_ckbx.Size = new System.Drawing.Size(92, 22);
            this.gyro_lpf2_ckbx.TabIndex = 57;
            this.gyro_lpf2_ckbx.Text = "checkBox2";
            this.gyro_lpf2_ckbx.UseVisualStyleBackColor = true;
            this.gyro_lpf2_ckbx.CheckedChanged += new System.EventHandler(this.gyro_lpf2_ckbx_CheckedChanged);
            // 
            // gyro_static2_lpf_updn
            // 
            this.gyro_static2_lpf_updn.Location = new System.Drawing.Point(17, 27);
            this.gyro_static2_lpf_updn.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.gyro_static2_lpf_updn.Name = "gyro_static2_lpf_updn";
            this.gyro_static2_lpf_updn.Size = new System.Drawing.Size(49, 25);
            this.gyro_static2_lpf_updn.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "label4";
            // 
            // gyro_static2_type_cmbx
            // 
            this.gyro_static2_type_cmbx.FormattingEnabled = true;
            this.gyro_static2_type_cmbx.Location = new System.Drawing.Point(17, 58);
            this.gyro_static2_type_cmbx.Name = "gyro_static2_type_cmbx";
            this.gyro_static2_type_cmbx.Size = new System.Drawing.Size(49, 26);
            this.gyro_static2_type_cmbx.TabIndex = 40;
            // 
            // gyro_slider_value_lbl
            // 
            this.gyro_slider_value_lbl.AutoSize = true;
            this.gyro_slider_value_lbl.Location = new System.Drawing.Point(348, 23);
            this.gyro_slider_value_lbl.Name = "gyro_slider_value_lbl";
            this.gyro_slider_value_lbl.Size = new System.Drawing.Size(15, 18);
            this.gyro_slider_value_lbl.TabIndex = 36;
            this.gyro_slider_value_lbl.Text = "0";
            // 
            // gyro_trk
            // 
            this.gyro_trk.Location = new System.Drawing.Point(37, 44);
            this.gyro_trk.Maximum = 20;
            this.gyro_trk.Name = "gyro_trk";
            this.gyro_trk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gyro_trk.Size = new System.Drawing.Size(603, 45);
            this.gyro_trk.TabIndex = 35;
            this.gyro_trk.Scroll += new System.EventHandler(this.gyro_trk_Scroll);
            // 
            // extras
            // 
            this.extras.Controls.Add(this.iterm_lim_updn);
            this.extras.Controls.Add(this.pidsum_lim_yaw_updn);
            this.extras.Controls.Add(this.pidsum_lim_updn);
            this.extras.Controls.Add(this.label3);
            this.extras.Controls.Add(this.label2);
            this.extras.Controls.Add(this.label1);
            this.extras.Location = new System.Drawing.Point(4, 27);
            this.extras.Name = "extras";
            this.extras.Size = new System.Drawing.Size(926, 875);
            this.extras.TabIndex = 3;
            this.extras.Text = "Extras";
            // 
            // iterm_lim_updn
            // 
            this.iterm_lim_updn.Location = new System.Drawing.Point(178, 116);
            this.iterm_lim_updn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.iterm_lim_updn.Name = "iterm_lim_updn";
            this.iterm_lim_updn.Size = new System.Drawing.Size(82, 25);
            this.iterm_lim_updn.TabIndex = 5;
            // 
            // pidsum_lim_yaw_updn
            // 
            this.pidsum_lim_yaw_updn.Location = new System.Drawing.Point(178, 79);
            this.pidsum_lim_yaw_updn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pidsum_lim_yaw_updn.Name = "pidsum_lim_yaw_updn";
            this.pidsum_lim_yaw_updn.Size = new System.Drawing.Size(82, 25);
            this.pidsum_lim_yaw_updn.TabIndex = 4;
            // 
            // pidsum_lim_updn
            // 
            this.pidsum_lim_updn.Location = new System.Drawing.Point(178, 43);
            this.pidsum_lim_updn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pidsum_lim_updn.Name = "pidsum_lim_updn";
            this.pidsum_lim_updn.Size = new System.Drawing.Size(82, 25);
            this.pidsum_lim_updn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "I-Term Limit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yaw Pidsum Limit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pidsum Limit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dterm_lpf2_ckbx
            // 
            this.dterm_lpf2_ckbx.AutoSize = true;
            this.dterm_lpf2_ckbx.Location = new System.Drawing.Point(175, 369);
            this.dterm_lpf2_ckbx.Name = "dterm_lpf2_ckbx";
            this.dterm_lpf2_ckbx.Size = new System.Drawing.Size(92, 22);
            this.dterm_lpf2_ckbx.TabIndex = 75;
            this.dterm_lpf2_ckbx.Text = "checkBox2";
            this.dterm_lpf2_ckbx.UseVisualStyleBackColor = true;
            this.dterm_lpf2_ckbx.CheckedChanged += new System.EventHandler(this.dterm_lpf2_ckbx_CheckedChanged);
            // 
            // PIDs
            // 
            this.ClientSize = new System.Drawing.Size(946, 910);
            this.Controls.Add(this.dynamicTabControl);
            this.Name = "PIDs";
            this.dynamicTabControl.ResumeLayout(false);
            this.pid.ResumeLayout(false);
            this.pid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dyn_damping_trk)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thrlin_updn)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vbat_comp_updn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antig_gain_updn)).EndInit();
            this.Feedforward.ResumeLayout(false);
            this.Feedforward.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_transition_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_max_rate_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_boost_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_smooth_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_jit_updn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.irel_cutoff_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_trk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracking_trk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stick_resp_trk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterm_trk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damping_trk)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.f_yaw_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmin_yaw_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmax_yaw_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_yaw_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_yaw_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_pitch_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmin_pitch_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmax_pitch_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_pitch_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_pitch_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_roll_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmin_roll_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmax_roll_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_roll_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_roll_updn)).EndInit();
            this.rates.ResumeLayout(false);
            this.rates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thr_lim_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpa_att_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpa_brkpt_updn)).EndInit();
            this.filters.ResumeLayout(false);
            this.filters.PerformLayout();
            this.yaw_lpf_gpbx.ResumeLayout(false);
            this.yaw_lpf_gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yaw_lpf_updn)).EndInit();
            this.dterm_notches_gpbx.ResumeLayout(false);
            this.dterm_notches_gpbx.PerformLayout();
            this.dterm_notch2_gpbx.ResumeLayout(false);
            this.dterm_notch2_gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_notch2_cntr_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_notch2_min_updn)).EndInit();
            this.dterm_notch1_gpbx.ResumeLayout(false);
            this.dterm_notch1_gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_notch1_cntr_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_notch1_min_updn)).EndInit();
            this.dterm_lpf_gpbx.ResumeLayout(false);
            this.dterm_lpf_gpbx.PerformLayout();
            this.dterm_lpf1_gpbx.ResumeLayout(false);
            this.dterm_lpf1_gpbx.PerformLayout();
            this.dterm_static1_gpbx.ResumeLayout(false);
            this.dterm_static1_gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_static1_lpf_updn)).EndInit();
            this.dterm_dyn_lpf1_gpbx.ResumeLayout(false);
            this.dterm_dyn_lpf1_gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_dyn_lpf1_max_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_dyn_lpf1_min_updn)).EndInit();
            this.dterm_static2_gpbx.ResumeLayout(false);
            this.dterm_static2_gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_static2_lpf_updn)).EndInit();
            this.gyro_dyn_notch_gpbx.ResumeLayout(false);
            this.gyro_dyn_notch_gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_dyn_notch_max_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_dyn_notch_min_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_dyn_notch_wid_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_dyn_notch_cnt_updn)).EndInit();
            this.gyro_notches_gpbx.ResumeLayout(false);
            this.gyro_notches_gpbx.PerformLayout();
            this.gyro_notch2_gpbx.ResumeLayout(false);
            this.gyro_notch2_gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_notch2_cntr_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_notch2_min_updn)).EndInit();
            this.gyro_notch1_gpbx.ResumeLayout(false);
            this.gyro_notch1_gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_notch1_cntr_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_notch1_min_updn)).EndInit();
            this.rpm_notches_gpbx.ResumeLayout(false);
            this.rpm_notches_gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_rpm_min_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_rpm_cnt_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dterm_trk)).EndInit();
            this.gyro_lpf_gpbx.ResumeLayout(false);
            this.gyro_lpf_gpbx.PerformLayout();
            this.gyro_lpf1_gpbx.ResumeLayout(false);
            this.gyro_lpf1_gpbx.PerformLayout();
            this.gyro_static1_gpbx.ResumeLayout(false);
            this.gyro_static1_gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_static1_lpf_updn)).EndInit();
            this.gyro_dyn_lpf1_gpbx.ResumeLayout(false);
            this.gyro_dyn_lpf1_gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_dyn_lpf1_max_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_dyn_lpf1_min_updn)).EndInit();
            this.gyro_static2_gpbx.ResumeLayout(false);
            this.gyro_static2_gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_static2_lpf_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyro_trk)).EndInit();
            this.extras.ResumeLayout(false);
            this.extras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterm_lim_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pidsum_lim_yaw_updn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pidsum_lim_updn)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private TabControl dynamicTabControl;
        private TabPage pid;
        private TabPage rates;
        private TabPage filters;
        private TabPage extras;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown iterm_lim_updn;
        private NumericUpDown pidsum_lim_yaw_updn;
        private NumericUpDown pidsum_lim_updn;
        private Label throttle_limit_type_updwn;
        private ComboBox thr_lim_type_cmbx;
        private NumericUpDown thr_lim_updn;
        private NumericUpDown tpa_att_updn;
        private NumericUpDown tpa_brkpt_updn;
        private Label throttle_limit_updwn;
        private Label label5;
        private Label label6;
        private Label gyro_slider_value_lbl;
        private TrackBar gyro_trk;
        private GroupBox Feedforward;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private ComboBox f_avg_cmbx;
        private NumericUpDown f_transition_updn;
        private NumericUpDown f_max_rate_updn;
        private NumericUpDown f_boost_updn;
        private NumericUpDown f_smooth_updn;
        private NumericUpDown f_jit_updn;
        private ComboBox pid_simplyfied_tuning_cmbx;
        private ComboBox antig_mode_cmbx;
        private ComboBox irel_type_cmbx;
        private ComboBox irel_axis_cmbx;
        private NumericUpDown antig_gain_updn;
        private NumericUpDown irel_cutoff_updn;
        private GroupBox groupBox2;
        private Label label20;
        private Label label19;
        private Label label18;
        private GroupBox groupBox1;
        private Label label21;
        private Label label22;
        private GroupBox groupBox3;
        private Label label23;
        private NumericUpDown vbat_comp_updn;
        private GroupBox groupBox4;
        private Label label24;
        private NumericUpDown thrlin_updn;
        private Label dterm_slider_value_lbl;
        private TrackBar dterm_trk;
        private GroupBox rpm_notches_gpbx;
        private NumericUpDown gyro_rpm_min_updn;
        private NumericUpDown gyro_rpm_cnt_updn;
        private Label label37;
        private Label label38;
        private GroupBox gyro_lpf_gpbx;
        private NumericUpDown gyro_static2_lpf_updn;
        private NumericUpDown gyro_static1_lpf_updn;
        private NumericUpDown gyro_dyn_lpf1_max_updn;
        private NumericUpDown gyro_dyn_lpf1_min_updn;
        private Label label7;
        private Label label4;
        private Label gyro_static1_type1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox gyro_static2_type_cmbx;
        private ComboBox gyro_lpf1_type_cmbx;
        private ComboBox gyro_lpf1_mode_cmbx;
        private ComboBox gyro_simplyfied_cmbx;
        private GroupBox gyro_notches_gpbx;
        private NumericUpDown gyro_notch1_cntr_updn;
        private NumericUpDown gyro_notch1_min_updn;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label Master;
        private Label label35;
        private Label label36;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private TrackBar master_trk;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private TrackBar tracking_trk;
        private TrackBar trackBar4;
        private TrackBar stick_resp_trk;
        private TrackBar iterm_trk;
        private TrackBar damping_trk;
        private GroupBox groupBox9;
        private NumericUpDown f_yaw_updn;
        private NumericUpDown dmin_yaw_updn;
        private NumericUpDown dmax_yaw_updn;
        private NumericUpDown i_yaw_updn;
        private NumericUpDown p_yaw_updn;
        private NumericUpDown f_pitch_updn;
        private NumericUpDown dmin_pitch_updn;
        private NumericUpDown dmax_pitch_updn;
        private NumericUpDown i_pitch_updn;
        private NumericUpDown p_pitch_updn;
        private NumericUpDown f_roll_updn;
        private NumericUpDown dmin_roll_updn;
        private NumericUpDown dmax_roll_updn;
        private NumericUpDown i_roll_updn;
        private NumericUpDown p_roll_updn;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label54;
        private Label label55;
        private GroupBox groupBox10;
        private NumericUpDown gyro_notch2_cntr_updn;
        private NumericUpDown gyro_notch2_min_updn;
        private Label label58;
        private Label label59;
        private Label label62;
        private TrackBar dyn_damping_trk;
        private NumericUpDown gyro_dyn_notch_max_updn;
        private Label label63;
        private NumericUpDown gyro_dyn_notch_min_updn;
        private NumericUpDown gyro_dyn_notch_wid_updn;
        private NumericUpDown gyro_dyn_notch_cnt_updn;
        private Label label64;
        private Label label66;
        private Label label67;
        private GroupBox gyro_dyn_notch_gpbx;
        private GroupBox gyro_notch2_gpbx;
        private GroupBox gyro_notch1_gpbx;
        private GroupBox gyro_static2_gpbx;
        private GroupBox gyro_static1_gpbx;
        private GroupBox gyro_dyn_lpf1_gpbx;
        private GroupBox gyro_lpf1_gpbx;
        private ComboBox dterm_simplyfied_cmbx;
        private GroupBox dterm_lpf_gpbx;
        private GroupBox dterm_lpf1_gpbx;
        private GroupBox dterm_static1_gpbx;
        private NumericUpDown dterm_static1_lpf_updn;
        private Label label25;
        private Label label26;
        private ComboBox dterm_lpf1_type_cmbx;
        private GroupBox dterm_dyn_lpf1_gpbx;
        private NumericUpDown dterm_dyn_lpf1_max_updn;
        private NumericUpDown dterm_dyn_lpf1_min_updn;
        private Label label27;
        private Label label28;
        private Label label29;
        private ComboBox dterm_lpf1_mode_cmbx;
        private GroupBox dterm_static2_gpbx;
        private NumericUpDown dterm_static2_lpf_updn;
        private Label label30;
        private Label label31;
        private ComboBox dterm_static2_type_cmbx;
        private GroupBox dterm_notches_gpbx;
        private GroupBox dterm_notch2_gpbx;
        private NumericUpDown dterm_notch2_cntr_updn;
        private NumericUpDown dterm_notch2_min_updn;
        private Label label56;
        private Label label57;
        private GroupBox dterm_notch1_gpbx;
        private NumericUpDown dterm_notch1_cntr_updn;
        private NumericUpDown dterm_notch1_min_updn;
        private Label label60;
        private Label label61;
        private NumericUpDown yaw_lpf_updn;
        private Label label65;
        private GroupBox yaw_lpf_gpbx;
        private CheckBox dterm_lpf1_ckbx;
        private CheckBox gyro_lpf1_ckbx;
        private CheckBox gyro_lpf2_ckbx;
        private CheckBox yaw_lpf_ckbx;
        private CheckBox dterm_notch1_ckbx;
        private CheckBox dterm_notch2_ckbx;
        private CheckBox dyn_notches_ckbx;
        private CheckBox gyro_notch2_ckbx;
        private CheckBox gyro_notch1_ckbx;
        private CheckBox rpm_notches_ckbx;
        private CheckBox dterm_lpf2_ckbx;
    }
}