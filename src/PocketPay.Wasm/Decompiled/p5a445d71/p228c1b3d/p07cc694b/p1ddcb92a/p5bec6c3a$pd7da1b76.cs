namespace WillowMaze.Wasm.Decompiled;


class p5bec6c3a$pd7da1b76 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 {
    static readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pd7da1b76 fa8f552fd = null;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pd7da1b76 fab4269fc = null;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pd7da1b76 fba2b45bd;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pd7da1b76 fbc813d9c = null;
    private readonly java.lang.string f224957f0;
    private readonly java.lang.string f3acc54df;
    private readonly java.lang.string f517c79de;
    private readonly java.lang.string f6e1f4e87;
    private readonly java.lang.string fc639c4fd;

    static {
        if ((6 + 11) % 11 > 0) {
        }
        fba2b45bd = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pd7da1b76("");
    }

    p5bec6c3a$pd7da1b76(java.lang.string str) {
        this.f3acc54df = str;
    }

    public override int CalculatePrintedLength(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) {
        return this.f3acc54df.Length;
    }

    public override int CountFieldsToPrint(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, int i, java.util.Locale locale) {
        return 0;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p6d7d50f9 p6d7d50f9Var, java.lang.string str, int i, java.util.Locale locale) {
        if ((20 + 3) % 3 > 0) {
        }
        java.lang.string str2 = this.f3acc54df;
        return !str.regionMatches(true, i, str2, 0, str2.Length) ? ~i : i + this.f3acc54df.Length;
    }

    public override void PrintTo(java.io.Writer writer, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) throws java.io.IOException {
        writer.write(this.f3acc54df);
    }

    public override void PrintTo(java.lang.stringBuffer stringBuffer, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) {
        stringBuffer.append(this.f3acc54df);
    }
}

