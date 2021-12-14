using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using AutoHotkey.Interop;


namespace AntiAFK
{
    class Globals
    {
        public static AutoHotkeyEngine ahk = AutoHotkeyEngine.Instance;
        public static bool isRunning = false;
        public static Logger logger;

        public static void SafeSleep(uint time)
        {
            if (time > 120000)
            {
                // 2 minutes is too long...
                return;
            }

            //System.Threading.Thread.Sleep((int)time);

            //Sleep for 500ms intervals
            for (uint itx = 0; itx < time; itx += 500)
            {
                System.Threading.Thread.Sleep(500);
                if (!isRunning)
                {
                    //Perhaps send log message?
                    Globals.logger.Log("Program Stopped inside sleep");
                    break;
                }
            }
        }
        public static int GetProcessID(String pname)
        {
            //Process p = Process.GetCurrentProcess();
            Process[] p = Process.GetProcessesByName(pname);
            if (p.Length == 1)
            {
                return p[0].Id;
            }
            return -1;
        }
        public static String GetProcessName(String pname)
        {
            Process[] p = Process.GetProcessesByName(pname);
            if (p.Length == 1)
            {
                return p[0].ProcessName;
            }
            return "";
        }

    }
}
