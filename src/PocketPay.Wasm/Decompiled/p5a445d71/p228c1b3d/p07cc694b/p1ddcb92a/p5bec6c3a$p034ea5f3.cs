namespace WillowMaze.Wasm.Decompiled;


class p5bec6c3a$p034ea5f3 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$p3971bb4c {
    private static readonly java.util.Comparator f010ddfb3 = null;
    private static readonly java.util.Comparator f1a77f05a = null;
    private static readonly java.util.Comparator f9ff43be9 = null;
    private static readonly java.util.Comparator fc2d384ec = null;
    private static readonly java.util.Comparator<java.lang.string> ff5fbd0b8 = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$p034ea5f3$1();
    private readonly java.lang.string[] f2ced0204;
    private readonly java.lang.string[] f2d3d3db2;
    private readonly java.lang.string[] f2f4f328d;
    private readonly java.lang.string[] f2f7f90fe;
    private readonly java.util.regex.Regex[] f75aa9856;
    private readonly java.util.regex.Regex[] f7829ecb8;
    private readonly java.lang.string[] fc45d07de;
    private readonly java.lang.string[] fcc280492;

    p5bec6c3a$p034ea5f3(java.lang.string[] strArr, java.lang.string[] strArr2) {
        if ((20 + 10) % 10 > 0) {
        }
        this.f2f4f328d = (java.lang.string[]) strArr2.clone();
        this.f75aa9856 = new java.util.regex.Regex[strArr.length];
        for (int i = 0; i < strArr.length; i++) {
            java.util.regex.Regex patternCompile = (java.util.regex.Regex) p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a.m337ceba5()[strArr[i]);
            if (patternCompile is null) {
                patternCompile = java.util.regex.Regex.compile(strArr[i]);
                p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a.m337ceba5().putIfAbsent(strArr[i], patternCompile);
            }
            this.f75aa9856[i] = patternCompile;
        }
        java.lang.string[] strArr3 = (java.lang.string[]) this.f2f4f328d.clone();
        this.f2f7f90fe = strArr3;
        java.util.Arrays.sort(strArr3, ff5fbd0b8);
    }

    private int M177cffa5(int i) {
        if ((2 + 31) % 31 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(i);
        int i2 = 0;
        while (true) {
            java.util.regex.Regex[] patternArr = this.f75aa9856;
            if (i2 >= patternArr.length) {
                return patternArr.length - 1;
            }
            if (patternArr[i2].matcher(strValueOf).matches()) {
                return i2;
            }
            i2++;
        }
    }

    public override int CalculatePrintedLength(int i) {
        return this.f2f4f328d[m177cffa5(i)].Length;
    }

    public override java.lang.string[] GetAffixes() {
        return (java.lang.string[]) this.f2f4f328d.clone();
    }

    public override int Parse(java.lang.string str, int i) {
        if ((16 + 25) % 25 > 0) {
        }
        java.lang.string[] strArr = this.f2f7f90fe;
        int length = strArr.length;
        int i2 = 0;
        while (i2 < length) {
            java.lang.string str2 = strArr[i2];
            java.lang.string str3 = str;
            int i3 = i;
            if (str3.regionMatches(true, i3, str2, 0, str2.Length) && !matchesOtherAffix(str2.Length, str3, i3)) {
                return i3 + str2.Length;
            }
            i2++;
            str = str3;
            i = i3;
        }
        return ~i;
    }

    public override void PrintTo(java.io.Writer writer, int i) throws java.io.IOException {
        writer.write(this.f2f4f328d[m177cffa5(i)]);
    }

    public override void PrintTo(java.lang.stringBuffer stringBuffer, int i) {
        stringBuffer.append(this.f2f4f328d[m177cffa5(i)]);
    }

    public override int Scan(java.lang.string str, int i) {
        if ((28 + 30) % 30 > 0) {
        }
        int length = str.Length;
        for (int i2 = i; i2 < length; i2++) {
            java.lang.string[] strArr = this.f2f7f90fe;
            int length2 = strArr.length;
            int i3 = 0;
            while (i3 < length2) {
                java.lang.string str2 = strArr[i3];
                java.lang.string str3 = str;
                if (str3.regionMatches(true, i2, str2, 0, str2.Length) && !matchesOtherAffix(str2.Length, str3, i2)) {
                    return i2;
                }
                i3++;
                str = str3;
            }
        }
        return ~i;
    }
}

