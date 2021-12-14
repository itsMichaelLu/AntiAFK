using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoHotkey.Interop;

namespace AntiAFK
{
    class AhkWrapper
    {
        private AutoHotkeyEngine _ahk;
        const string keySendMsg = "ControlSend,, {{{0} {1}}}, ahk_pid {2}";

        public AhkWrapper(AutoHotkeyEngine ahk)
        {
            this._ahk = ahk;
        }

        private string KeyToString(int key)
        {
            switch (key)
            {
                case 0:
                    return "Hello";
                default:
                    return "bad";
            }
        }

        public void KeyDown(int key, int pid)
        {
            string msg = string.Format(keySendMsg, "VK" + key.ToString("X3"), "down", pid);
            this._ahk.ExecRaw(msg);

        }

        public void KeyUp(int key, int pid)
        {
            string msg = string.Format(keySendMsg, "VK" + key.ToString("X3"), "up", pid);
            this._ahk.ExecRaw(msg);
        }

        public void KeyPress(int key, int pid, int delay = 100)
        {
            KeyDown(key, pid);
            System.Threading.Thread.Sleep(delay);
            KeyUp(key, pid);
        }

    }
}
