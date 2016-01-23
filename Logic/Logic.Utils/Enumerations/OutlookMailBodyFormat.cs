﻿namespace s2.s2Utils.Logic.Utils.Enumerations
{
    /// <summary>
    /// Defines possible types of e-mail-body-formats when mails are generated by outlook.
    /// </summary>
    /// <remarks>
    /// We copy this from OlBodyFormat out of Microsoft.Office.Interop because we can't reference this
    /// directly here.
    /// </remarks>
    public enum OutlookMailBodyFormat
    {
        /// <summary>
        /// Type is not specified.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Type is plain text.
        /// </summary>
        Plain = 1,

        /// <summary>
        /// Type is HTML.
        /// </summary>
        Html = 2,

        /// <summary>
        /// Type is RTF.
        /// </summary>
        RichText = 3
    }
}