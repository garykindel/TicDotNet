﻿using System;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        tic m_tic;

        bool m_conected = false;
        bool m_moving=false;
        bool m_homing = false;
        private bool m_decelerating;

        Timer drcTimer;

        public Form1()
        {
            InitializeComponent();
            buttonGoto.Enabled = m_conected;
            buttonHome.Enabled = m_conected;
            checkBoxJogLeft.Enabled = m_conected;
            checkBoxJogRigth.Enabled = m_conected;
            buttonEnergize.Enabled = m_conected;
            m_tic = new tic();
            LoadControllers();


        }

        private void LoadControllers()
        {
            foreach (tic.PRODUCT_ID type in Enum.GetValues(typeof(tic.PRODUCT_ID)))
            {
                cboDevice.Items.Add(type);
            }
        }

        private void bn_Conect_Click(object sender, EventArgs e)
        {

            try
            {
                if (!m_conected)
                {
                    tic.PRODUCT_ID type = (tic.PRODUCT_ID)cboDevice.SelectedItem;

                    m_conected = m_tic.open(type);
                    m_tic.reinitialize();
                    
//                    m_tic.reset();
                    m_tic.energize();
                    m_tic.clear_driver_error();

                    //m_tic.set_max_accel(100000);
                    //m_tic.set_max_decel(100000);
                    //m_tic.set_max_speed(50000000);
                    //m_tic.set_starting_speed(2000000);
                    m_tic.exit_safe_start();
                    m_tic.wait_for_device_ready();
                    bn_Conect.Text = "Disconnect";
                    labelConection.Text = "YES";
                }
                else
                {
                    m_tic.deenergize();
                    m_tic.close();
                    bn_Conect.Text="Connect";
                    labelConection.Text = "NO";
                    m_conected = false;
                }

                buttonGoto.Enabled = m_conected;
                buttonHome.Enabled = m_conected;
                checkBoxJogLeft.Enabled = m_conected;
                checkBoxJogRigth.Enabled = m_conected;
                buttonEnergize.Enabled = m_conected;
            }
            catch (Exception ex)
            {
                m_conected = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m_conected)
            {
                m_tic.reset_command_timeout();
                m_tic.get_variables();
                m_tic.get_status_variables();
                labelPosition.Text = m_tic.vars.current_position.ToString();


                string status = "";

                foreach (var prop in m_tic.status_vars.GetType().GetProperties())
                {
                    status = status + string.Format("{0}={1}\n\r", prop.Name, prop.GetValue(m_tic.status_vars, null));
                }

                string vars = "";


                foreach (var prop in m_tic.vars.GetType().GetProperties())
                {
                    vars = vars + string.Format("{0}={1}\n\r", prop.Name, prop.GetValue(m_tic.vars, null));
                }

                labelStatus.Text = status;
                labelVars.Text = vars;
                if (m_moving && m_tic.in_position())
                {
                    m_moving = false;
                    buttonGoto.Text = "GOTO";
                    buttonHome.Enabled = !m_moving;
                    checkBoxJogLeft.Enabled = !m_moving;
                    checkBoxJogRigth.Enabled = !m_moving;
                }
                if (m_homing && m_tic.in_home())
                {
                    m_homing = false;
                    buttonHome.Text = "HOME";
                    buttonGoto.Enabled = !m_homing;
                    checkBoxJogLeft.Enabled = !m_homing;
                    checkBoxJogRigth.Enabled = !m_homing;
                }

                if(m_decelerating&&m_tic.vars.current_velocity==0)
                {
                    m_decelerating = false;
                    buttonGoto.Enabled = true;
                    buttonHome.Enabled = true;
                }

            }

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (m_homing == false)
            {
                m_tic.go_home(tic.GO_HOME.REVERSE);
                buttonHome.Text = "STOP";
                m_homing = true;
            }
            else
            {
                m_tic.halt_and_hold();
                buttonHome.Text = "HOME";
                m_homing = false;

            }
            buttonGoto.Enabled = !m_homing;
            checkBoxJogLeft.Enabled = !m_homing;
            checkBoxJogRigth.Enabled = !m_homing;
        }


        private void buttonGoto_Click(object sender, EventArgs e)
        {
            if (m_moving == false)
            {
                //m_tic.set_step_mode(2);
                m_tic.set_max_speed((int)numericUpDownSpeed.Value);
                m_tic.set_target_position((int)numericUpDownPosition.Value);
                m_moving = true;
                buttonGoto.Text = "STOP";
            }
            else
            {
                m_tic.halt_and_hold();
                buttonGoto.Text = "GOTO";
                m_moving = true;
            }
            buttonHome.Enabled = !m_moving;
            checkBoxJogLeft.Enabled = !m_moving;
            checkBoxJogRigth.Enabled = !m_moving;

        }

        private void checkBoxJogLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJogLeft.CheckState==CheckState.Checked)
            {
                m_tic.set_max_speed((int)numericUpDownJogSpeed.Value);
                m_tic.set_target_position((int)numericUpDownPosition.Minimum);

                buttonGoto.Enabled = false;
                buttonHome.Enabled = false;
            }
            else
            {
                m_tic.set_target_velocity(0);
                m_decelerating=true;
            }

        }

        private void checkBoxJogRigth_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJogRigth.CheckState == CheckState.Checked)
            {
                m_tic.set_max_speed((int)numericUpDownJogSpeed.Value);
                m_tic.set_target_position((int)numericUpDownPosition.Maximum);
                buttonGoto.Enabled = false;
                buttonHome.Enabled = false;
            }
            else
            {
                m_tic.set_target_velocity(0);
                m_decelerating = true;
            }

        }

        private void buttonEnergize_Click(object sender, EventArgs e)
        {
            if (m_tic.status_vars.energized)
            {
                m_tic.deenergize();
                buttonEnergize.Text="ENERGIZE";
            }
            else
            {
                m_tic.clear_driver_error();
                m_tic.energize();
                m_tic.exit_safe_start();
                buttonEnergize.Text = "DEENERGIZE";
            }
        }

        private void RESET_POS_Click(object sender, EventArgs e)
        {
            m_tic.halt_and_set_position(0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            drcTimer = new Timer();
            drcTimer.Tick += DrcTimer_Tick;          
            drcTimer.Interval = (int)numericUpDownDelay.Value;            
            drcTimer.Start();          
        }

        private void DrcTimer_Tick(object sender, EventArgs e)
        {
            //m_moving = true;
            //m_tic.set_step_mode(2);
            m_tic.set_max_speed((int)numericUpDownSpeed.Value);

            if (cbxDown.Checked)
            {
                m_tic.set_target_position(m_tic.vars.current_position - (int)numericUpDownInterval.Value);
            }
            else
            {
                m_tic.set_target_position(m_tic.vars.current_position + (int)numericUpDownInterval.Value);
            }

            //m_tic.set_target_velocity(0);
            //m_moving = false;

            if (Math.Abs(m_tic.vars.current_position) >= (int)numericUpDownStop.Value)
            {
                drcTimer.Stop();
                drcTimer.Tick -= DrcTimer_Tick;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            drcTimer.Stop();
            drcTimer.Tick -= DrcTimer_Tick;
        }

        private void gbStepMode_Validated(object sender, EventArgs e)
        {
            object wStepMode = gbStepMode.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Tag;    
            if (wStepMode != null)
            {
                m_tic.set_step_mode(Convert.ToInt32(wStepMode));
            }
        }
    }
}
