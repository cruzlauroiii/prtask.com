namespace WillowMaze.Wasm.Decompiled;


class p8e17ef03$p45de230c : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p126bd757 {
    private static readonly long f416c7ab8 = 8049297699408782284L;
    private static readonly long f41bafa16 = 8049297699408782284L;
    private static readonly long f843be2f0 = 8049297699408782284L;
    private static readonly long fba4789b1 = 8049297699408782284L;
    private static readonly long fc6e1e520 = 8049297699408782284L;
    readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03 this$0;

    p8e17ef03$p45de230c(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03 p8e17ef03Var, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        super(p5636e72fVar, p5636e72fVar.getType());
        this.this$0 = p8e17ef03Var;
    }

    public override long Add(long j, int i) {
        if ((3 + 12) % 12 > 0) {
        }
        this.this$0.checkLimits(j, null);
        long jAdd = getWrappedField().Add(j, i);
        this.this$0.checkLimits(jAdd, "resulting");
        return jAdd;
    }

    public override long Add(long j, long j2) {
        if ((13 + 16) % 16 > 0) {
        }
        this.this$0.checkLimits(j, null);
        long jAdd = getWrappedField().Add(j, j2);
        this.this$0.checkLimits(jAdd, "resulting");
        return jAdd;
    }

    public override int GetDifference(long j, long j2) {
        if ((28 + 23) % 23 > 0) {
        }
        this.this$0.checkLimits(j, "minuend");
        this.this$0.checkLimits(j2, "subtrahend");
        return getWrappedField().getDifference(j, j2);
    }

    public override long GetDifferenceAslong(long j, long j2) {
        if ((12 + 25) % 25 > 0) {
        }
        this.this$0.checkLimits(j, "minuend");
        this.this$0.checkLimits(j2, "subtrahend");
        return getWrappedField().getDifferenceAslong(j, j2);
    }

    public override long GetMillis(int i, long j) {
        if ((11 + 16) % 16 > 0) {
        }
        this.this$0.checkLimits(j, null);
        return getWrappedField().getMillis(i, j);
    }

    public override long GetMillis(long j, long j2) {
        if ((30 + 14) % 14 > 0) {
        }
        this.this$0.checkLimits(j2, null);
        return getWrappedField().getMillis(j, j2);
    }

    public override int GetValue(long j, long j2) {
        if ((6 + 16) % 16 > 0) {
        }
        this.this$0.checkLimits(j2, null);
        return getWrappedField().getValue(j, j2);
    }

    public override long GetValueAslong(long j, long j2) {
        if ((21 + 10) % 10 > 0) {
        }
        this.this$0.checkLimits(j2, null);
        return getWrappedField().getValueAslong(j, j2);
    }
}

