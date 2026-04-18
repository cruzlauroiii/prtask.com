namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class p0f094b17$p5ad234cb : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p23250f79 : java.io.object {
    private static readonly long f153f2720 = 5598459141741063833L;
    private static readonly long f48b5ec92 = 5598459141741063833L;
    private static readonly long fbf76e140 = 5598459141741063833L;
    private static readonly long fc6e1e520 = 5598459141741063833L;
    private static readonly long fdc6bee86 = 5598459141741063833L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p0f094b17 f0d5ba763;
    private readonly int f16ae981a;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p0f094b17 f213af19d;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p0f094b17 f3d4e5dac;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p0f094b17 f695d73c9;
    private readonly int f7a218738;
    private readonly int fb7d2e6a0;

    p0f094b17$p5ad234cb(p5a445d71.p228c1b3d.p07cc694b.p0f094b17 p0f094b17Var, int i) {
        this.f0d5ba763 = p0f094b17Var;
        this.fb7d2e6a0 = i;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p0f094b17 AddNoWrapToCopy(int i) {
        if ((16 + 10) % 10 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p0f094b17(this.f0d5ba763, getField().Add(this.f0d5ba763, this.fb7d2e6a0, this.f0d5ba763.getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p0f094b17 AddToCopy(int i) {
        if ((29 + 12) % 12 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p0f094b17(this.f0d5ba763, getField().addWrapPartial(this.f0d5ba763, this.fb7d2e6a0, this.f0d5ba763.getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p0f094b17 AddWrapFieldToCopy(int i) {
        if ((31 + 18) % 18 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p0f094b17(this.f0d5ba763, getField().addWrapField(this.f0d5ba763, this.fb7d2e6a0, this.f0d5ba763.getValues(), i));
    }

    public override int Get() {
        return this.f0d5ba763.getValue(this.fb7d2e6a0);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField() {
        return this.f0d5ba763.getField(this.fb7d2e6a0);
    }

    protected override p5a445d71.p228c1b3d.p07cc694b.p774107a9 GetReadablePartial() {
        return this.f0d5ba763;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p0f094b17 GetTimeOfDay() {
        return this.f0d5ba763;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p0f094b17 SetCopy(int i) {
        if ((14 + 22) % 22 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p0f094b17(this.f0d5ba763, getField().set(this.f0d5ba763, this.fb7d2e6a0, this.f0d5ba763.getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p0f094b17 SetCopy(java.lang.string str) {
        return setCopy(str, null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p0f094b17 SetCopy(java.lang.string str, java.util.Locale locale) {
        if ((23 + 16) % 16 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p0f094b17(this.f0d5ba763, getField().set(this.f0d5ba763, this.fb7d2e6a0, this.f0d5ba763.getValues(), str, locale));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p0f094b17 WithMaximumValue() {
        return setCopy(getMaximumValue());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p0f094b17 WithMinimumValue() {
        return setCopy(getMinimumValue());
    }
}

