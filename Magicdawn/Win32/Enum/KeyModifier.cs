﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn.Win32
{
    /// <summary>
    /// 定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举使用数值）
    /// </summary>
    [Flags]
    public enum KeyModifier : int
    {
        None = 0,
        Alt = 1,
        Ctrl = 2,
        Shift = 4,
        WindowsKey = 8
    }
}
