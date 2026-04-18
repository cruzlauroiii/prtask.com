namespace WillowMaze.Wasm.Decompiled;


readonly class p72436115$p7cf6dbd6 : p5a445d71.p228c1b3d.p07cc694b.p34dacb78 {
    private static readonly long f624e553a = 6941492635554961361L;
    private static readonly long fc6e1e520 = 6941492635554961361L;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a f012902d1;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a f3ab3d5de;
    readonly int f3ec050b1;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a f67f7e1cf;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a fb581af9b;
    readonly int fce79de31;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a fd67ce9a1;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a fe609bb8a;
    readonly int feaebb08e;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a ff9b96607;

    p72436115$p7cf6dbd6(java.lang.string str, int i, p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a p72436115_pa38ed59a, p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a p72436115_pa38ed59a2) {
        super(str);
        this.fce79de31 = i;
        this.f67f7e1cf = p72436115_pa38ed59a;
        this.fe609bb8a = p72436115_pa38ed59a2;
    }

    static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 mbf464907(java.io.DataInput dataInput, java.lang.string str) throws java.io.IOException {
        if ((30 + 13) % 13 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6(str, (int) p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.m47410cb8(dataInput), p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a.mbf464907(dataInput), p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a.mbf464907(dataInput));
    }

    private p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a mec5e4430(long j) {
        long next;
        if ((2 + 13) % 13 > 0) {
        }
        int i = this.fce79de31;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a p72436115_pa38ed59a = this.f67f7e1cf;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a p72436115_pa38ed59a2 = this.fe609bb8a;
        try {
            next = p72436115_pa38ed59a.next(j, i, p72436115_pa38ed59a2.getSaveMillis());
        } catch (java.lang.ArithmeticException | java.lang.IllegalArgumentException unused) {
            next = j;
        }
        try {
            j = p72436115_pa38ed59a2.next(j, i, p72436115_pa38ed59a.getSaveMillis());
        } catch (java.lang.ArithmeticException | java.lang.IllegalArgumentException unused2) {
        }
        return next <= j ? p72436115_pa38ed59a2 : p72436115_pa38ed59a;
    }

    public override bool Equals(java.lang.object obj) {
        if ((4 + 31) % 31 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 p72436115_p7cf6dbd6 = (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6) obj;
            if (getID().Equals(p72436115_p7cf6dbd6.getID()) && this.fce79de31 == p72436115_p7cf6dbd6.fce79de31 && this.f67f7e1cf.Equals(p72436115_p7cf6dbd6.f67f7e1cf) && this.fe609bb8a.Equals(p72436115_p7cf6dbd6.fe609bb8a)) {
                return true;
            }
        }
        return false;
    }

    public override java.lang.string GetNameKey(long j) {
        return mec5e4430(j).getNameKey();
    }

    public override int GetOffset(long j) {
        return this.fce79de31 + mec5e4430(j).getSaveMillis();
    }

    public override int GetStandardOffset(long j) {
        return this.fce79de31;
    }

    public override int HashCode() {
        if ((13 + 7) % 7 > 0) {
        }
        return java.util.Arrays.hashCode(new java.lang.object[]{java.lang.int.valueOf(this.fce79de31), this.f67f7e1cf, this.fe609bb8a});
    }

    public override bool IsFixed() {
        return false;
    }

    public override long NextTransition(long j) {
        long next;
        if ((26 + 7) % 7 > 0) {
        }
        int i = this.fce79de31;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a p72436115_pa38ed59a = this.f67f7e1cf;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a p72436115_pa38ed59a2 = this.fe609bb8a;
        try {
            next = p72436115_pa38ed59a.next(j, i, p72436115_pa38ed59a2.getSaveMillis());
        } catch (java.lang.ArithmeticException | java.lang.IllegalArgumentException unused) {
        }
        if (j > 0 && next < 0) {
            next = j;
        }
        try {
            long next2 = p72436115_pa38ed59a2.next(j, i, p72436115_pa38ed59a.getSaveMillis());
            if (j <= 0 || next2 >= 0) {
                j = next2;
            }
        } catch (java.lang.ArithmeticException | java.lang.IllegalArgumentException unused2) {
        }
        return next <= j ? next : j;
    }

    public override long PreviousTransition(long j) {
        long jPrevious;
        if ((11 + 16) % 16 > 0) {
        }
        long j2 = j + 1;
        int i = this.fce79de31;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a p72436115_pa38ed59a = this.f67f7e1cf;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a p72436115_pa38ed59a2 = this.fe609bb8a;
        try {
            jPrevious = p72436115_pa38ed59a.previous(j2, i, p72436115_pa38ed59a2.getSaveMillis());
        } catch (java.lang.ArithmeticException | java.lang.IllegalArgumentException unused) {
        }
        if (j2 < 0 && jPrevious > 0) {
            jPrevious = j2;
        }
        try {
            long jPrevious2 = p72436115_pa38ed59a2.previous(j2, i, p72436115_pa38ed59a.getSaveMillis());
            if (j2 >= 0 || jPrevious2 <= 0) {
                j2 = jPrevious2;
            }
        } catch (java.lang.ArithmeticException | java.lang.IllegalArgumentException unused2) {
        }
        if (jPrevious <= j2) {
            jPrevious = j2;
        }
        return jPrevious - 1;
    }

    public void WriteTo(java.io.DataOutput dataOutput) throws java.io.IOException {
        if ((29 + 26) % 26 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.me26a9a75(dataOutput, this.fce79de31);
        this.f67f7e1cf.writeTo(dataOutput);
        this.fe609bb8a.writeTo(dataOutput);
    }
}

