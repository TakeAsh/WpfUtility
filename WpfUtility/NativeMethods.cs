﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WpfUtility.Native {

    class NativeMethods {

        [DllImport("user32.dll")]
        public static extern bool SetWindowPlacement(
            IntPtr hWnd,
            [In] ref WINDOWPLACEMENT lpwndpl
        );

        [DllImport("user32.dll")]
        public static extern bool GetWindowPlacement(
            IntPtr hWnd,
            out WINDOWPLACEMENT lpwndpl
        );
    }
}
