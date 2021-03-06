/*******************************************************************************
 * Copyright © 2010-2020  陈恩点版权所有
 * 初版作者: 陈恩点
 * 创建时间: 2012/8/21 11:49:53
 * 联系方式: 18115503914
 * 简单描述: MyRapid快速开发框架
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScintillaNET
{
    /// <summary>
    /// The visual indicator used on a wrapped line.
    /// </summary>
    [Flags]
    public enum WrapVisualFlags
    {
        /// <summary>
        /// No visual indicator is displayed. This the default.
        /// </summary>
        None = NativeMethods.SC_WRAPVISUALFLAG_NONE,

        /// <summary>
        /// A visual indicator is displayed at th end of a wrapped subline.
        /// </summary>
        End = NativeMethods.SC_WRAPVISUALFLAG_END,

        /// <summary>
        /// A visual indicator is displayed at the beginning of a subline.
        /// The subline is indented by 1 pixel to make room for the display.
        /// </summary>
        Start = NativeMethods.SC_WRAPVISUALFLAG_START,

        /// <summary>
        /// A visual indicator is displayed in the number margin.
        /// </summary>
        Margin = NativeMethods.SC_WRAPVISUALFLAG_MARGIN
    }
}