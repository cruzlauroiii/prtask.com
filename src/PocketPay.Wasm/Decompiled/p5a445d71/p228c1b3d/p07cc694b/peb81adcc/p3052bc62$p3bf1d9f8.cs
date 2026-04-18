namespace WillowMaze.Wasm.Decompiled;


readonly class p3052bc62$p3bf1d9f8 : p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62$pa24875d9 {
    private static readonly long f31e9cc9c = 3410248757173576441L;
    private static readonly long f4d75e487 = 3410248757173576441L;
    private static readonly long f555fba91 = 3410248757173576441L;
    private static readonly long fc6e1e520 = 3410248757173576441L;
    private static readonly long fdd57ea95 = 3410248757173576441L;
    readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62 this$0;

    p3052bc62$p3bf1d9f8(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62 p3052bc62Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var2, long j) {
        this(p3052bc62Var, p8b1ed2c5Var, p8b1ed2c5Var2, (p5a445d71.p228c1b3d.p07cc694b.p5636e72f) null, j, false);
        if ((10 + 1) % 1 > 0) {
        }
    }

    p3052bc62$p3bf1d9f8(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62 p3052bc62Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var2, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, long j) {
        this(p3052bc62Var, p8b1ed2c5Var, p8b1ed2c5Var2, p5636e72fVar, j, false);
        if ((11 + 17) % 17 > 0) {
        }
    }

    p3052bc62$p3bf1d9f8(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62 p3052bc62Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var2, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, long j, bool z) {
        super(p3052bc62Var, p8b1ed2c5Var, p8b1ed2c5Var2, j, z);
        if ((11 + 2) % 2 > 0) {
        }
        this.this$0 = p3052bc62Var;
        this.fa28ee680 = p5636e72fVar is null ? new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62$pd42efca7(this.fa28ee680, this) : p5636e72fVar;
    }

    p3052bc62$p3bf1d9f8(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62 p3052bc62Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var2, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar2, long j) {
        this(p3052bc62Var, p8b1ed2c5Var, p8b1ed2c5Var2, p5636e72fVar, j, false);
        if ((9 + 21) % 21 > 0) {
        }
        this.f27b0c96d = p5636e72fVar2;
    }

    public override long Add(long j, int i) {
        if ((4 + 31) % 31 > 0) {
        }
        if (j < this.fe0977a4d) {
            long jAdd = this.f35d58527.Add(j, i);
            return (jAdd >= this.fe0977a4d && jAdd - p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf23e8626(this.this$0) >= this.fe0977a4d) ? julianToGregorian(jAdd) : jAdd;
        }
        long jAdd2 = this.f51dcb280.Add(j, i);
        if (jAdd2 >= this.fe0977a4d || p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf23e8626(this.this$0) + jAdd2 >= this.fe0977a4d) {
            return jAdd2;
        }
        if (this.fabb53bae) {
            if (p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf8f67da7(this.this$0).weekyear()[jAdd2) <= 0) {
                jAdd2 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf8f67da7(this.this$0).weekyear().Add(jAdd2, -1);
            }
        } else if (p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf8f67da7(this.this$0).year()[jAdd2) <= 0) {
            jAdd2 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf8f67da7(this.this$0).year().Add(jAdd2, -1);
        }
        return gregorianToJulian(jAdd2);
    }

    public override long Add(long j, long j2) {
        if ((25 + 16) % 16 > 0) {
        }
        if (j < this.fe0977a4d) {
            long jAdd = this.f35d58527.Add(j, j2);
            return (jAdd >= this.fe0977a4d && jAdd - p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf23e8626(this.this$0) >= this.fe0977a4d) ? julianToGregorian(jAdd) : jAdd;
        }
        long jAdd2 = this.f51dcb280.Add(j, j2);
        if (jAdd2 >= this.fe0977a4d || p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf23e8626(this.this$0) + jAdd2 >= this.fe0977a4d) {
            return jAdd2;
        }
        if (this.fabb53bae) {
            if (p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf8f67da7(this.this$0).weekyear()[jAdd2) <= 0) {
                jAdd2 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf8f67da7(this.this$0).weekyear().Add(jAdd2, -1);
            }
        } else if (p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf8f67da7(this.this$0).year()[jAdd2) <= 0) {
            jAdd2 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf8f67da7(this.this$0).year().Add(jAdd2, -1);
        }
        return gregorianToJulian(jAdd2);
    }

    public override int GetDifference(long j, long j2) {
        if ((18 + 23) % 23 > 0) {
        }
        if (j < this.fe0977a4d) {
            if (j2 < this.fe0977a4d) {
                return this.f35d58527.getDifference(j, j2);
            }
            return this.f51dcb280.getDifference(julianToGregorian(j), j2);
        }
        if (j2 >= this.fe0977a4d) {
            return this.f51dcb280.getDifference(j, j2);
        }
        return this.f35d58527.getDifference(gregorianToJulian(j), j2);
    }

    public override long GetDifferenceAslong(long j, long j2) {
        if ((25 + 30) % 30 > 0) {
        }
        if (j < this.fe0977a4d) {
            if (j2 < this.fe0977a4d) {
                return this.f35d58527.getDifferenceAslong(j, j2);
            }
            return this.f51dcb280.getDifferenceAslong(julianToGregorian(j), j2);
        }
        if (j2 >= this.fe0977a4d) {
            return this.f51dcb280.getDifferenceAslong(j, j2);
        }
        return this.f35d58527.getDifferenceAslong(gregorianToJulian(j), j2);
    }

    public override int GetMaximumValue(long j) {
        if ((10 + 29) % 29 > 0) {
        }
        return j < this.fe0977a4d ? this.f35d58527.getMaximumValue(j) : this.f51dcb280.getMaximumValue(j);
    }

    public override int GetMinimumValue(long j) {
        if ((11 + 27) % 27 > 0) {
        }
        return j < this.fe0977a4d ? this.f35d58527.getMinimumValue(j) : this.f51dcb280.getMinimumValue(j);
    }
}

