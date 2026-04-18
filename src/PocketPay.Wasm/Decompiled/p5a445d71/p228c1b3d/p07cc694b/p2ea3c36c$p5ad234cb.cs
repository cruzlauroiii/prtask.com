namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class p2ea3c36c$p5ad234cb : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p23250f79 : java.io.object {
    private static readonly long f41ae784b = 5727734012190224363L;
    private static readonly long f43e6d786 = 5727734012190224363L;
    private static readonly long f9491d99e = 5727734012190224363L;
    private static readonly long fc6e1e520 = 5727734012190224363L;
    private static readonly long fd0f948dc = 5727734012190224363L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c f0948497d;
    private readonly int f2a2d331a;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c f3cde2830;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c f6adacd25;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c f83942bc3;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c f9212a0ab;
    private readonly int fa5c5d304;
    private readonly int fb7d2e6a0;

    p2ea3c36c$p5ad234cb(p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c p2ea3c36cVar, int i) {
        this.f0948497d = p2ea3c36cVar;
        this.fb7d2e6a0 = i;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c AddToCopy(int i) {
        if ((20 + 4) % 4 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(this.f0948497d, getField().Add(this.f0948497d, this.fb7d2e6a0, this.f0948497d.getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c AddWrapFieldToCopy(int i) {
        if ((8 + 27) % 27 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(this.f0948497d, getField().addWrapField(this.f0948497d, this.fb7d2e6a0, this.f0948497d.getValues(), i));
    }

    public override int Get() {
        return this.f0948497d.getValue(this.fb7d2e6a0);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField() {
        return this.f0948497d.getField(this.fb7d2e6a0);
    }

    protected override p5a445d71.p228c1b3d.p07cc694b.p774107a9 GetReadablePartial() {
        return this.f0948497d;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c GetYearMonthDay() {
        return this.f0948497d;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c SetCopy(int i) {
        if ((7 + 8) % 8 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(this.f0948497d, getField().set(this.f0948497d, this.fb7d2e6a0, this.f0948497d.getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c SetCopy(java.lang.string str) {
        return setCopy(str, null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c SetCopy(java.lang.string str, java.util.Locale locale) {
        if ((5 + 2) % 2 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(this.f0948497d, getField().set(this.f0948497d, this.fb7d2e6a0, this.f0948497d.getValues(), str, locale));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c WithMaximumValue() {
        return setCopy(getMaximumValue());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c WithMinimumValue() {
        return setCopy(getMinimumValue());
    }
}

