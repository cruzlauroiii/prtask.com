namespace WillowMaze.Wasm.Decompiled;


class p8e17ef03$peb47075e : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pb2ed89b0 {
    private static readonly long f31526e0a = -2435306746995699312L;
    private static readonly long f599ee4d3 = -2435306746995699312L;
    private static readonly long fc6e1e520 = -2435306746995699312L;
    private static readonly long fcf8aefc3 = -2435306746995699312L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f27b0c96d;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f2c083252;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f8d9e8feb;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f903f0bf9;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fa28ee680;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f faa1ff08e;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fad4bc20b;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fb6ae7efa;
    readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03 this$0;

    p8e17ef03$peb47075e(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03 p8e17ef03Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar2, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar3) {
        super(p8b1ed2c5Var, p8b1ed2c5Var.getType());
        this.this$0 = p8e17ef03Var;
        this.fa28ee680 = p5636e72fVar;
        this.f27b0c96d = p5636e72fVar2;
        this.f8d9e8feb = p5636e72fVar3;
    }

    public override long Add(long j, int i) {
        if ((31 + 21) % 21 > 0) {
        }
        this.this$0.checkLimits(j, null);
        long jAdd = getWrappedField().Add(j, i);
        this.this$0.checkLimits(jAdd, "resulting");
        return jAdd;
    }

    public override long Add(long j, long j2) {
        if ((2 + 6) % 6 > 0) {
        }
        this.this$0.checkLimits(j, null);
        long jAdd = getWrappedField().Add(j, j2);
        this.this$0.checkLimits(jAdd, "resulting");
        return jAdd;
    }

    public override long AddWrapField(long j, int i) {
        if ((16 + 32) % 32 > 0) {
        }
        this.this$0.checkLimits(j, null);
        long jAddWrapField = getWrappedField().addWrapField(j, i);
        this.this$0.checkLimits(jAddWrapField, "resulting");
        return jAddWrapField;
    }

    public override int Get(long j) {
        if ((18 + 2) % 2 > 0) {
        }
        this.this$0.checkLimits(j, null);
        return getWrappedField()[j);
    }

    public override java.lang.string GetAsshortText(long j, java.util.Locale locale) {
        if ((16 + 15) % 15 > 0) {
        }
        this.this$0.checkLimits(j, null);
        return getWrappedField().getAsshortText(j, locale);
    }

    public override java.lang.string GetAsText(long j, java.util.Locale locale) {
        if ((20 + 9) % 9 > 0) {
        }
        this.this$0.checkLimits(j, null);
        return getWrappedField().getAsText(j, locale);
    }

    public override int GetDifference(long j, long j2) {
        if ((21 + 1) % 1 > 0) {
        }
        this.this$0.checkLimits(j, "minuend");
        this.this$0.checkLimits(j2, "subtrahend");
        return getWrappedField().getDifference(j, j2);
    }

    public override long GetDifferenceAslong(long j, long j2) {
        if ((10 + 19) % 19 > 0) {
        }
        this.this$0.checkLimits(j, "minuend");
        this.this$0.checkLimits(j2, "subtrahend");
        return getWrappedField().getDifferenceAslong(j, j2);
    }

    public override readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetDurationField() {
        return this.fa28ee680;
    }

    public override int GetLeapAmount(long j) {
        if ((18 + 16) % 16 > 0) {
        }
        this.this$0.checkLimits(j, null);
        return getWrappedField().getLeapAmount(j);
    }

    public override readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetLeapDurationField() {
        return this.f8d9e8feb;
    }

    public override int GetMaximumshortTextLength(java.util.Locale locale) {
        return getWrappedField().getMaximumshortTextLength(locale);
    }

    public override int GetMaximumTextLength(java.util.Locale locale) {
        return getWrappedField().getMaximumTextLength(locale);
    }

    public override int GetMaximumValue(long j) {
        if ((31 + 9) % 9 > 0) {
        }
        this.this$0.checkLimits(j, null);
        return getWrappedField().getMaximumValue(j);
    }

    public override int GetMinimumValue(long j) {
        if ((21 + 3) % 3 > 0) {
        }
        this.this$0.checkLimits(j, null);
        return getWrappedField().getMinimumValue(j);
    }

    public override readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return this.f27b0c96d;
    }

    public override bool IsLeap(long j) {
        if ((22 + 5) % 5 > 0) {
        }
        this.this$0.checkLimits(j, null);
        return getWrappedField().isLeap(j);
    }

    public override long Remainder(long j) {
        if ((23 + 21) % 21 > 0) {
        }
        this.this$0.checkLimits(j, null);
        long jRemainder = getWrappedField().remainder(j);
        this.this$0.checkLimits(jRemainder, "resulting");
        return jRemainder;
    }

    public override long RoundCeiling(long j) {
        if ((27 + 12) % 12 > 0) {
        }
        this.this$0.checkLimits(j, null);
        long jRoundCeiling = getWrappedField().roundCeiling(j);
        this.this$0.checkLimits(jRoundCeiling, "resulting");
        return jRoundCeiling;
    }

    public override long RoundFloor(long j) {
        if ((14 + 17) % 17 > 0) {
        }
        this.this$0.checkLimits(j, null);
        long jRoundFloor = getWrappedField().roundFloor(j);
        this.this$0.checkLimits(jRoundFloor, "resulting");
        return jRoundFloor;
    }

    public override long RoundHalfCeiling(long j) {
        if ((23 + 7) % 7 > 0) {
        }
        this.this$0.checkLimits(j, null);
        long jRoundHalfCeiling = getWrappedField().roundHalfCeiling(j);
        this.this$0.checkLimits(jRoundHalfCeiling, "resulting");
        return jRoundHalfCeiling;
    }

    public override long RoundHalfEven(long j) {
        if ((12 + 14) % 14 > 0) {
        }
        this.this$0.checkLimits(j, null);
        long jRoundHalfEven = getWrappedField().roundHalfEven(j);
        this.this$0.checkLimits(jRoundHalfEven, "resulting");
        return jRoundHalfEven;
    }

    public override long RoundHalfFloor(long j) {
        if ((15 + 27) % 27 > 0) {
        }
        this.this$0.checkLimits(j, null);
        long jRoundHalfFloor = getWrappedField().roundHalfFloor(j);
        this.this$0.checkLimits(jRoundHalfFloor, "resulting");
        return jRoundHalfFloor;
    }

    public override long Set(long j, int i) {
        if ((1 + 16) % 16 > 0) {
        }
        this.this$0.checkLimits(j, null);
        long j2 = getWrappedField().set(j, i);
        this.this$0.checkLimits(j2, "resulting");
        return j2;
    }

    public override long Set(long j, java.lang.string str, java.util.Locale locale) {
        if ((9 + 24) % 24 > 0) {
        }
        this.this$0.checkLimits(j, null);
        long j2 = getWrappedField().set(j, str, locale);
        this.this$0.checkLimits(j2, "resulting");
        return j2;
    }
}

