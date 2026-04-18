namespace WillowMaze.Wasm.Decompiled;


public class p44ffd38a$p5ad234cb : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p23250f79 : java.io.object {
    private static readonly long f1677fbd2 = 53278362873888L;
    private static readonly long f9daca07c = 53278362873888L;
    private static readonly long fc6e1e520 = 53278362873888L;
    private static readonly long fe7d031a7 = 53278362873888L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p44ffd38a f1eb7c9cc;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p44ffd38a f2954e73c;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p44ffd38a f355ae1ed;
    private readonly int f5ae78f47;
    private readonly int f601c3d15;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p44ffd38a f8f5b43af;
    private readonly int f98edc775;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p44ffd38a fa5bae66e;
    private readonly int fb7d2e6a0;
    private readonly int fdb44c88c;

    p44ffd38a$p5ad234cb(p5a445d71.p228c1b3d.p07cc694b.p44ffd38a p44ffd38aVar, int i) {
        this.f2954e73c = p44ffd38aVar;
        this.fb7d2e6a0 = i;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a AddToCopy(int i) {
        if ((8 + 25) % 25 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p44ffd38a(this.f2954e73c, getField().Add(this.f2954e73c, this.fb7d2e6a0, this.f2954e73c.getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a AddWrapFieldToCopy(int i) {
        if ((32 + 23) % 23 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p44ffd38a(this.f2954e73c, getField().addWrapField(this.f2954e73c, this.fb7d2e6a0, this.f2954e73c.getValues(), i));
    }

    public override int Get() {
        return this.f2954e73c.getValue(this.fb7d2e6a0);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField() {
        return this.f2954e73c.getField(this.fb7d2e6a0);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a GetPartial() {
        return this.f2954e73c;
    }

    protected override p5a445d71.p228c1b3d.p07cc694b.p774107a9 GetReadablePartial() {
        return this.f2954e73c;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a SetCopy(int i) {
        if ((4 + 32) % 32 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p44ffd38a(this.f2954e73c, getField().set(this.f2954e73c, this.fb7d2e6a0, this.f2954e73c.getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a SetCopy(java.lang.string str) {
        return setCopy(str, null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a SetCopy(java.lang.string str, java.util.Locale locale) {
        if ((25 + 13) % 13 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p44ffd38a(this.f2954e73c, getField().set(this.f2954e73c, this.fb7d2e6a0, this.f2954e73c.getValues(), str, locale));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a WithMaximumValue() {
        return setCopy(getMaximumValue());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a WithMinimumValue() {
        return setCopy(getMinimumValue());
    }
}

