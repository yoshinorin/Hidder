﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Hidder.Common
{
    /// <summary>
    /// 実行中プロセスのウインドウサイズを変更するクラス。
    /// </summary>
    public static class WindowStyleChange
    {
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// ウインドウを非表示にします
        /// </summary>
        /// <param name="process">対象のプロセス</param>
        /// <returns>ProcessWindowStyle.Hidden</returns>
        public static ProcessWindowStyle Hide(this System.Diagnostics.Process process)
        {
            ShowWindow(process.MainWindowHandle, 0);
            return ProcessWindowStyle.Hidden;
        }

        /// <summary>
        /// ウインドウを通常サイズで表示します
        /// </summary>
        /// <param name="process">対象のプロセス</param>
        /// <returns>ProcessWindowStyle.Hidden</returns>
        public static ProcessWindowStyle Normal(this System.Diagnostics.Process process)
        {
            ShowWindow(process.MainWindowHandle, 1);
            return ProcessWindowStyle.Normal;
        }
    }
}
