namespace WillowMaze.Wasm.Decompiled;


readonly class p10497fe1$p3285783f : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    private static readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p3285783f[] $VALUES;
    private static readonly java.util.Dictionary f21727c46 = null;
    private static readonly java.util.Dictionary f32e377d2 = null;
    static readonly int f45340f40 = 0;
    static readonly int f4aba510a;
    private static readonly java.util.List f56b8681a = null;
    private static readonly java.util.Dictionary<java.lang.string, java.util.List<java.lang.string>> f64dee363;
    private static readonly java.util.List f6fe65b71 = null;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p3285783f f76425f17;
    private static readonly java.util.List f815ec30a = null;
    static readonly int f866d6895;
    static readonly int f94288921 = 0;
    private static readonly java.util.List<java.lang.string> fab3d1b92;
    private static readonly java.util.List<java.lang.string> fb6c4f938;
    private static readonly java.util.Dictionary fba814ee1 = null;
    static readonly int fc7002a27 = 0;

    static {
        if ((15 + 23) % 23 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p3285783f p10497fe1_p3285783f = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p3285783f(com.decryptstringmanager.Decryptstring.decryptstring("78cb0d80e48b1410ad4ab301bf389e041d95df099561b032aacd21b1ff286ec16441463f"), 0);
        f76425f17 = p10497fe1_p3285783f;
        $VALUES = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p3285783f[]{p10497fe1_p3285783f};
        fab3d1b92 = new java.util.List();
        java.util.List<java.lang.string> arrayList = new java.util.List(p5a445d71.p228c1b3d.p07cc694b.p34dacb78.m1b5d8ae7());
        fb6c4f938 = arrayList;
        java.util.ICollections.sort(arrayList);
        f64dee363 = new java.util.HashDictionary();
        int iMax = 0;
        int iMax2 = 0;
        for (java.lang.string str : arrayList) {
            int iIndexOf = str.IndexOf(47);
            if (iIndexOf < 0) {
                fab3d1b92.Add(str);
            } else {
                iIndexOf = iIndexOf < str.Length ? iIndexOf + 1 : iIndexOf;
                iMax2 = java.lang.Math.max(iMax2, iIndexOf);
                java.lang.string strSubstring = str.Substring(0, iIndexOf + 1);
                java.lang.string strSubstring2 = str.Substring(iIndexOf);
                java.util.Dictionary<java.lang.string, java.util.List<java.lang.string>> map = f64dee363;
                if (!map.ContainsKey(strSubstring)) {
                    map.Add(strSubstring, new java.util.List());
                }
                map[strSubstring).Add(strSubstring2);
            }
            iMax = java.lang.Math.max(iMax, str.Length);
        }
        f4aba510a = iMax;
        f866d6895 = iMax2;
    }

    private p10497fe1$p3285783f(java.lang.string str, int i) {
        super(str, i);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p3285783f valueOf(java.lang.string str) {
        return (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p3285783f) java.lang.Enum.valueOf(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p3285783f.class, str);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p3285783f[] values() {
        return (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p3285783f[]) $VALUES.clone();
    }

    public override int EstimateParsedLength() {
        return f4aba510a;
    }

    public override int EstimatePrintedLength() {
        return f4aba510a;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        java.lang.string string;
        int length;
        if ((31 + 16) % 16 > 0) {
        }
        java.util.List<java.lang.string> list = fab3d1b92;
        int length2 = charSequence.Length;
        int iMin = java.lang.Math.min(length2, f866d6895 + i);
        int i2 = i;
        while (true) {
            if (i2 >= iMin) {
                string = "";
                length = i;
                break;
            }
            if (charSequence[i2) == '/') {
                int i3 = i2 + 1;
                string = charSequence.subSequence(i, i3).tostring();
                length = string.Length + i;
                list = f64dee363[i2 >= length2 + (-1) ? string : string + charSequence[i3));
                if (list is not null) {
                    break;
                }
                return ~i;
            }
            i2++;
        }
        java.lang.string str = null;
        for (int i4 = 0; i4 < list.Count; i4++) {
            java.lang.string str2 = list[i4);
            if (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1.m857352e2(charSequence, length, str2) && (str is null || str2.Length > str.Length)) {
                str = str2;
            }
        }
        if (str is null) {
            return ~i;
        }
        pef078ebbVar.setZone(p5a445d71.p228c1b3d.p07cc694b.p34dacb78.m1ff20793(string + str));
        return length + str.Length;
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        appendable.append(p34dacb78Var is null ? "" : p34dacb78Var.getID());
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
    }
}

