namespace PrTask.Git.Generated;

internal static partial class ColumnH
{
    internal const int COL_LAYOUT_MASK = 0x000F;
    internal const int COL_ENABLE_MASK = 0x0030   /* always, never or auto */;
    internal const int COL_PARSEOPT = 0x0040   /* --column is given from cmdline */;
    internal const int COL_DENSE = 0x0080   /* Shrink columns when possible,;
    internal const int COL_DISABLED = 0x0000   /* must be zero */;
    internal const int COL_ENABLED = 0x0010;
    internal const int COL_AUTO = 0x0020;
    internal const int COL_COLUMN = 0   /* Fill columns before rows */;
    internal const int COL_ROW = 1   /* Fill rows before columns */;
    internal const int COL_PLAIN = 15   /* one column */;
}
