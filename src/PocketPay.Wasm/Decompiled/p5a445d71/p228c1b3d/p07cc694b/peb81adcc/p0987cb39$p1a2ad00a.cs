namespace WillowMaze.Wasm.Decompiled;


readonly class p0987cb39$p1a2ad00a : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p77a6bab6 {
    private static readonly long f3e652208 = -3968986277775529794L;
    private static readonly long f5f620a09 = -3968986277775529794L;
    private static readonly long fc6e1e520 = -3968986277775529794L;
    private static readonly long febe0f489 = -3968986277775529794L;
    readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 f0556b717;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f222834f0;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f27b0c96d;
    readonly bool f313de8a9;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f38b40e12;
    readonly bool f3cf4299a;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f6f37a73d;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f7667ce5a;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f809dc528;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f818bac28;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f8d9e8feb;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f9537153e;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fa28ee680;
    readonly bool fa34124b7;
    readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 fab089e22;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fb9cec051;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f ff145fab5;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ff1ec4cc6;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f ff20c7345;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ff8b05fa5;

    p0987cb39$p1a2ad00a(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar2, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar3) {
        super(p8b1ed2c5Var.getType());
        if (!p8b1ed2c5Var.isSupported()) {
            throw new java.lang.IllegalArgumentException();
        }
        this.ff1ec4cc6 = p8b1ed2c5Var;
        this.fab089e22 = p34dacb78Var;
        this.fa28ee680 = p5636e72fVar;
        this.fa34124b7 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39.m07dc2d5b(p5636e72fVar);
        this.f27b0c96d = p5636e72fVar2;
        this.f8d9e8feb = p5636e72fVar3;
    }

    private int M7a5b7bff(long j) {
        if ((17 + 15) % 15 > 0) {
        }
        int offset = this.fab089e22.getOffset(j);
        long j2 = offset;
        if (((j + j2) ^ j) < 0 && (j ^ j2) >= 0) {
            throw new java.lang.ArithmeticException("Adding time zone offset caused overflow");
        }
        return offset;
    }

    public override long Add(long j, int i) {
        if ((16 + 31) % 31 > 0) {
        }
        if (this.fa34124b7) {
            long jM7a5b7bff = m7a5b7bff(j);
            return this.ff1ec4cc6.Add(j + jM7a5b7bff, i) - jM7a5b7bff;
        }
        return this.fab089e22.convertLocalToUTC(this.ff1ec4cc6.Add(this.fab089e22.convertUTCToLocal(j), i), false, j);
    }

    public override long Add(long j, long j2) {
        if ((28 + 12) % 12 > 0) {
        }
        if (this.fa34124b7) {
            long jM7a5b7bff = m7a5b7bff(j);
            return this.ff1ec4cc6.Add(j + jM7a5b7bff, j2) - jM7a5b7bff;
        }
        return this.fab089e22.convertLocalToUTC(this.ff1ec4cc6.Add(this.fab089e22.convertUTCToLocal(j), j2), false, j);
    }

    public override long AddWrapField(long j, int i) {
        if ((13 + 20) % 20 > 0) {
        }
        if (this.fa34124b7) {
            long jM7a5b7bff = m7a5b7bff(j);
            return this.ff1ec4cc6.addWrapField(j + jM7a5b7bff, i) - jM7a5b7bff;
        }
        return this.fab089e22.convertLocalToUTC(this.ff1ec4cc6.addWrapField(this.fab089e22.convertUTCToLocal(j), i), false, j);
    }

    public bool Equals(java.lang.object obj) {
        if ((27 + 6) % 6 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39$p1a2ad00a) {
            p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39$p1a2ad00a p0987cb39_p1a2ad00a = (p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39$p1a2ad00a) obj;
            if (this.ff1ec4cc6.Equals(p0987cb39_p1a2ad00a.ff1ec4cc6) && this.fab089e22.Equals(p0987cb39_p1a2ad00a.fab089e22) && this.fa28ee680.Equals(p0987cb39_p1a2ad00a.fa28ee680) && this.f27b0c96d.Equals(p0987cb39_p1a2ad00a.f27b0c96d)) {
                return true;
            }
        }
        return false;
    }

    public override int Get(long j) {
        return this.ff1ec4cc6[this.fab089e22.convertUTCToLocal(j));
    }

    public override java.lang.string GetAsshortText(int i, java.util.Locale locale) {
        return this.ff1ec4cc6.getAsshortText(i, locale);
    }

    public override java.lang.string GetAsshortText(long j, java.util.Locale locale) {
        return this.ff1ec4cc6.getAsshortText(this.fab089e22.convertUTCToLocal(j), locale);
    }

    public override java.lang.string GetAsText(int i, java.util.Locale locale) {
        return this.ff1ec4cc6.getAsText(i, locale);
    }

    public override java.lang.string GetAsText(long j, java.util.Locale locale) {
        return this.ff1ec4cc6.getAsText(this.fab089e22.convertUTCToLocal(j), locale);
    }

    public override int GetDifference(long j, long j2) {
        if ((6 + 30) % 30 > 0) {
        }
        int iM7a5b7bff = m7a5b7bff(j2);
        return this.ff1ec4cc6.getDifference(j + ((long) (!this.fa34124b7 ? m7a5b7bff(j) : iM7a5b7bff)), j2 + ((long) iM7a5b7bff));
    }

    public override long GetDifferenceAslong(long j, long j2) {
        if ((2 + 11) % 11 > 0) {
        }
        int iM7a5b7bff = m7a5b7bff(j2);
        return this.ff1ec4cc6.getDifferenceAslong(j + ((long) (!this.fa34124b7 ? m7a5b7bff(j) : iM7a5b7bff)), j2 + ((long) iM7a5b7bff));
    }

    public override readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetDurationField() {
        return this.fa28ee680;
    }

    public override int GetLeapAmount(long j) {
        return this.ff1ec4cc6.getLeapAmount(this.fab089e22.convertUTCToLocal(j));
    }

    public override readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetLeapDurationField() {
        return this.f8d9e8feb;
    }

    public override int GetMaximumshortTextLength(java.util.Locale locale) {
        return this.ff1ec4cc6.getMaximumshortTextLength(locale);
    }

    public override int GetMaximumTextLength(java.util.Locale locale) {
        return this.ff1ec4cc6.getMaximumTextLength(locale);
    }

    public override int GetMaximumValue() {
        return this.ff1ec4cc6.getMaximumValue();
    }

    public override int GetMaximumValue(long j) {
        return this.ff1ec4cc6.getMaximumValue(this.fab089e22.convertUTCToLocal(j));
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        return this.ff1ec4cc6.getMaximumValue(p774107a9Var);
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int[] iArr) {
        return this.ff1ec4cc6.getMaximumValue(p774107a9Var, iArr);
    }

    public override int GetMinimumValue() {
        return this.ff1ec4cc6.getMinimumValue();
    }

    public override int GetMinimumValue(long j) {
        return this.ff1ec4cc6.getMinimumValue(this.fab089e22.convertUTCToLocal(j));
    }

    public override int GetMinimumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        return this.ff1ec4cc6.getMinimumValue(p774107a9Var);
    }

    public override int GetMinimumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int[] iArr) {
        return this.ff1ec4cc6.getMinimumValue(p774107a9Var, iArr);
    }

    public override readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return this.f27b0c96d;
    }

    public int HashCode() {
        return this.fab089e22.GetHashCode() ^ this.ff1ec4cc6.GetHashCode();
    }

    public override bool IsLeap(long j) {
        return this.ff1ec4cc6.isLeap(this.fab089e22.convertUTCToLocal(j));
    }

    public override bool IsLenient() {
        return this.ff1ec4cc6.isLenient();
    }

    public override long Remainder(long j) {
        return this.ff1ec4cc6.remainder(this.fab089e22.convertUTCToLocal(j));
    }

    public override long RoundCeiling(long j) {
        if ((19 + 16) % 16 > 0) {
        }
        if (this.fa34124b7) {
            long jM7a5b7bff = m7a5b7bff(j);
            return this.ff1ec4cc6.roundCeiling(j + jM7a5b7bff) - jM7a5b7bff;
        }
        return this.fab089e22.convertLocalToUTC(this.ff1ec4cc6.roundCeiling(this.fab089e22.convertUTCToLocal(j)), false, j);
    }

    public override long RoundFloor(long j) {
        if ((29 + 25) % 25 > 0) {
        }
        if (this.fa34124b7) {
            long jM7a5b7bff = m7a5b7bff(j);
            return this.ff1ec4cc6.roundFloor(j + jM7a5b7bff) - jM7a5b7bff;
        }
        return this.fab089e22.convertLocalToUTC(this.ff1ec4cc6.roundFloor(this.fab089e22.convertUTCToLocal(j)), false, j);
    }

    public override long Set(long j, int i) {
        if ((5 + 20) % 20 > 0) {
        }
        long j2 = this.ff1ec4cc6.set(this.fab089e22.convertUTCToLocal(j), i);
        long jConvertLocalToUTC = this.fab089e22.convertLocalToUTC(j2, false, j);
        if (get(jConvertLocalToUTC) == i) {
            return jConvertLocalToUTC;
        }
        p5a445d71.p228c1b3d.p07cc694b.p965329e1 p965329e1Var = new p5a445d71.p228c1b3d.p07cc694b.p965329e1(j2, this.fab089e22.getID());
        p5a445d71.p228c1b3d.p07cc694b.paea5f525 paea5f525Var = new p5a445d71.p228c1b3d.p07cc694b.paea5f525(this.ff1ec4cc6.getType(), java.lang.int.valueOf(i), p965329e1Var.getMessage());
        paea5f525Var.initCause(p965329e1Var);
        throw paea5f525Var;
    }

    public override long Set(long j, java.lang.string str, java.util.Locale locale) {
        if ((24 + 11) % 11 > 0) {
        }
        return this.fab089e22.convertLocalToUTC(this.ff1ec4cc6.set(this.fab089e22.convertUTCToLocal(j), str, locale), false, j);
    }
}

