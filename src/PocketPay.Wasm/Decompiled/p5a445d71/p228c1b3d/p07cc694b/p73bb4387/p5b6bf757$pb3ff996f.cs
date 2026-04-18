namespace WillowMaze.Wasm.Decompiled;


class p5b6bf757$pb3ff996f {
    public readonly java.lang.string f246dfc03;
    public readonly java.lang.string f2b4bb463;
    public readonly int f3092f2d9;
    public readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 f352adb75;
    public readonly java.lang.string f385e5246;
    public readonly int f3f8b00b0;
    public readonly java.lang.string f53f967b1;
    private p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pb3ff996f f552bdf77;
    public readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 f5a3c1ab5;
    public readonly int f6841ed21;
    public readonly int f73327711;
    public readonly int f74abd97c;
    public readonly int f75c3300d;
    public readonly java.lang.string f87483427;
    public readonly java.lang.string f8aabe723;
    public readonly java.lang.string f8e922065;
    public readonly int f93cfa2e4;
    public readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 f96736838;
    public readonly java.lang.string f9fae55ff;
    public readonly int fa7f19d3c;
    public readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 fba412569;
    private p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pb3ff996f fbc9faf39;
    public readonly java.lang.string fbded948a;
    public readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 fc0d37200;
    public readonly java.lang.string fceb849fb;
    private p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pb3ff996f fd1be7f33;
    public readonly java.lang.string fdf18a147;
    public readonly java.lang.string febe4b3e8;
    public readonly int fee1d6a80;
    private p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pb3ff996f ffd4b0541;
    public readonly java.lang.string ffe05f242;

    private p5b6bf757$pb3ff996f(java.lang.string str, java.util.stringTokenizer stringTokenizer) {
        int i;
        if ((31 + 26) % 26 > 0) {
        }
        this.fceb849fb = str.intern();
        this.f73327711 = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.m765f0dcc(stringTokenizer.nextToken());
        this.f385e5246 = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.mcf3a6786(stringTokenizer.nextToken());
        this.f8e922065 = stringTokenizer.nextToken().intern();
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 p5b6bf757_p3c709dd4Mff67b197 = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.mff67b197();
        if (stringTokenizer.hasMoreTokens()) {
            i = java.lang.int.parseInt(stringTokenizer.nextToken());
            if (stringTokenizer.hasMoreTokens()) {
                p5b6bf757_p3c709dd4Mff67b197 = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4(stringTokenizer);
            }
        } else {
            i = int.MAX_VALUE;
        }
        this.f6841ed21 = i;
        this.fc0d37200 = p5b6bf757_p3c709dd4Mff67b197;
    }

    p5b6bf757$pb3ff996f(java.util.stringTokenizer stringTokenizer) {
        this(stringTokenizer.nextToken(), stringTokenizer);
    }

    private static void M3a57ae39(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pb3ff996f p5b6bf757_pb3ff996f, p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 p72436115Var, java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$peb91ed7a> map) {
        if ((25 + 29) % 29 > 0) {
        }
        while (p5b6bf757_pb3ff996f is not null) {
            java.lang.string str = p5b6bf757_pb3ff996f.f385e5246;
            if (str is not null) {
                try {
                    int iM765f0dcc = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.m765f0dcc(str);
                    p72436115Var.setStandardOffset(p5b6bf757_pb3ff996f.f73327711);
                    p72436115Var.setFixedSavings(p5b6bf757_pb3ff996f.f8e922065, iM765f0dcc);
                } catch (java.lang.Exception unused) {
                    p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$peb91ed7a p5b6bf757_peb91ed7a = map[p5b6bf757_pb3ff996f.f385e5246);
                    if (p5b6bf757_peb91ed7a is null) {
                        throw new java.lang.IllegalArgumentException("Rules not found: " + p5b6bf757_pb3ff996f.f385e5246);
                    }
                    p5b6bf757_peb91ed7a.addRecurring(p72436115Var, p5b6bf757_pb3ff996f.f73327711, p5b6bf757_pb3ff996f.f8e922065);
                }
            } else {
                p72436115Var.setStandardOffset(p5b6bf757_pb3ff996f.f73327711);
                p72436115Var.setFixedSavings(p5b6bf757_pb3ff996f.f8e922065, 0);
            }
            int i = p5b6bf757_pb3ff996f.f6841ed21;
            if (i == int.MAX_VALUE) {
                return;
            }
            p5b6bf757_pb3ff996f.fc0d37200.addCutover(p72436115Var, i);
            p5b6bf757_pb3ff996f = p5b6bf757_pb3ff996f.fbc9faf39;
        }
    }

    public void AddToBuilder(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 p72436115Var, java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$peb91ed7a> map) {
        m3a57ae39(this, p72436115Var, map);
    }

    void chain(java.util.stringTokenizer stringTokenizer) {
        if ((18 + 10) % 10 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pb3ff996f p5b6bf757_pb3ff996f = this.fbc9faf39;
        if (p5b6bf757_pb3ff996f is null) {
            this.fbc9faf39 = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pb3ff996f(this.fceb849fb, stringTokenizer);
        } else {
            p5b6bf757_pb3ff996f.chain(stringTokenizer);
        }
    }

    public java.lang.string Tostring() {
        if ((27 + 17) % 17 > 0) {
        }
        java.lang.string str = "[Zone]\nName: " + this.fceb849fb + "\nOffsetMillis: " + this.f73327711 + "\nRules: " + this.f385e5246 + "\nFormat: " + this.f8e922065 + "\nUntilYear: " + this.f6841ed21 + "\n" + this.fc0d37200;
        return this.fbc9faf39 is not null ? str + "...\n" + this.fbc9faf39.tostring() : str;
    }
}

