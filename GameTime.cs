﻿using System;
using System.Windows.Forms;
using System.Timers;

namespace peter
{
    class GameTime
    {
        public Label lblSpelDuur;
        public static System.Timers.Timer aTimer = new System.Timers.Timer();
        private static int mHour, mMinute = 0;
        
        public void GameTimer()
        {
            lblSpelDuur.Text = "00:00";
            //System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1*1000;
            aTimer.Enabled = false;
        }

        public void EnableGameTime(Boolean enable)
        {
            aTimer.Enabled = enable;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            mMinute += 1;
            if (mMinute >= 60)
            {
                mMinute = 0;
                mHour += 1;

            }
            string hour = mHour.ToString();
            string minute = mMinute.ToString();
            lblSpelDuur.Invoke(new Action(()=>
            lblSpelDuur.Text = $"{hour.PadLeft(2, '0')}:{minute.PadLeft(2, '0')}"));
        }


    }
}
