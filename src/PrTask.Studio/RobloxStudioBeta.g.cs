     1→namespace PrTask.Studio;
     2→
     3→internal static partial class RobloxStudioBeta
     4→{
     5→    private const int MemSize = 268435456;
     6→    private static readonly byte[] Mem = new byte[MemSize];
     7→    private const string PePath = @"C:\\Users\\user\\AppData\\Local\\Roblox\\Versions\\version-913142fd943640d2\\RobloxStudioBeta.exe";
     8→    private const ulong ImageBase = 5368709120UL;
     9→
    10→    private static ulong Rax;
    11→    private static ulong Rbx;
    12→    private static ulong Rcx;
    13→    private static ulong Rdx;
    14→    private static ulong Rsi;
    15→    private static ulong Rdi;
    16→    private static ulong Rsp;
    17→    private static ulong Rbp;
    18→    private static ulong R8;
    19→    private static ulong R9;
    20→    private static ulong R10;
    21→    private static ulong R11;
    22→    private static ulong R12;
    23→    private static ulong R13;
    24→    private static ulong R14;
    25→    private static ulong R15;
    26→    private static ulong Rip;
    27→
    28→    private static bool Cf;
    29→    private static bool Zf;
    30→    private static bool Sf;
    31→    private static bool Of;
    32→    private static bool Pf;
    33→    private static bool Initialized;
    34→
    35→    private static void Init()
    36→    {
    37→        if (Initialized) return;
    38→        Initialized = true;
    39→        Rsp = 268369920UL;
    40→        Rbp = Rsp;
    41→        if (!global::System.IO.File.Exists(PePath)) return;
    42→        using var Fs = global::System.IO.File.OpenRead(PePath);
    43→        using var Pe = new global::System.Reflection.PortableExecutable.PEReader(Fs);
    44→        foreach (var Sec in Pe.PEHeaders.SectionHeaders)
    45→        {
    46→            var Data = Pe.GetSectionData(Sec.VirtualAddress);
    47→            if (Data.Length == 0) continue;
    48→            var Content = Data.GetContent();
    49→            var Offset = (int)((ulong)Sec.VirtualAddress);
    50→            var Len = global::System.Math.Min(Content.Length, MemSize - Offset);