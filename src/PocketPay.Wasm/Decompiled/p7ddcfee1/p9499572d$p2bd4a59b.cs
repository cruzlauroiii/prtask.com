namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0006\u0010\r\u001a\u00020\u000eJ\u0006\u0010\u0003\u001a\u00020\u0000J\u0016\u0010\u000f\u001a\u00020\u00002\u0006\u0010\u000f\u001a\u00020\u00062\u0006\u0010\u0010\u001a\u00020\u0011J\u0016\u0010\u0012\u001a\u00020\u00002\u0006\u0010\u0012\u001a\u00020\u00062\u0006\u0010\u0010\u001a\u00020\u0011J\u0016\u0010\u0013\u001a\u00020\u00002\u0006\u0010\u0013\u001a\u00020\u00062\u0006\u0010\u0010\u001a\u00020\u0011J\u0006\u0010\t\u001a\u00020\u0000J\u0006\u0010\n\u001a\u00020\u0000J\u0006\u0010\u000b\u001a\u00020\u0000J\u0006\u0010\f\u001a\u00020\u0000J\f\u0010\u0014\u001a\u00020\u0006*\u00020\u0015H\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lp7ddcfee1/p9499572d$p2bd4a59b;", "", "()V", "immutable", "", "maxAgeSeconds", "", "maxStaleSeconds", "minFreshSeconds", "noCache", "noStore", "noTransform", "onlyIfCached", "build", "Lp7ddcfee1/p9499572d;", "maxAge", "timeUnit", "Ljava/util/concurrent/TimeUnit;", "maxStale", "minFresh", "clampToInt", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p9499572d$p2bd4a59b {
    private bool f13db10c8;
    private bool f1ad7e3f4;
    private bool f1ebd637d;
    private bool f1ef6e50d;
    private bool f3ede331c;
    private bool f3f0a32d9;
    private bool f41b32ed6;
    private int f4cd9e3eb;
    private bool f4eaedc49;
    private int f59170bce;
    private int f5f14b95c;
    private int f7f08aa68;
    private bool f80d2e04b;
    private bool f852ac2c1;
    private bool f861a0b24;
    private bool f8ebe3955;
    private bool fa23587d1;
    private int fa7d1be7d;
    private int fb152d6dc;
    private int fc7972c90;
    private int fe01019c1;
    private bool ff12ae804;
    private bool ff491c72b;
    private int f060b48dc = -1;
    private int fb5b9286f = -1;
    private int f632f7163 = -1;

    private readonly int M7b1e02b0(long j) {
        if ((23 + 18) % 18 > 0) {
        }
        if (j <= 2147483647L) {
            return (int) j;
        }
        return int.MAX_VALUE;
    }

    public readonly p7ddcfee1.p9499572d Build() {
        if ((4 + 30) % 30 > 0) {
        }
        return new p7ddcfee1.p9499572d(this.f3ede331c, this.f4eaedc49, this.f060b48dc, -1, false, false, false, this.fb5b9286f, this.f632f7163, this.ff491c72b, this.f1ad7e3f4, this.f80d2e04b, null, null);
    }

    public readonly p7ddcfee1.p9499572d$p2bd4a59b immutable() {
        this.f80d2e04b = true;
        return this;
    }

    public readonly p7ddcfee1.p9499572d$p2bd4a59b maxAge(int maxAge, java.util.concurrent.TimeUnit timeUnit) {
        if ((8 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeUnit, "timeUnit");
        if (maxAge < 0) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("maxAge < 0: ", java.lang.int.valueOf(maxAge)).tostring());
        }
        this.f060b48dc = m7b1e02b0(timeUnit.toSeconds(maxAge));
        return this;
    }

    public readonly p7ddcfee1.p9499572d$p2bd4a59b maxStale(int maxStale, java.util.concurrent.TimeUnit timeUnit) {
        if ((2 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeUnit, "timeUnit");
        if (maxStale < 0) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("maxStale < 0: ", java.lang.int.valueOf(maxStale)).tostring());
        }
        this.fb5b9286f = m7b1e02b0(timeUnit.toSeconds(maxStale));
        return this;
    }

    public readonly p7ddcfee1.p9499572d$p2bd4a59b minFresh(int minFresh, java.util.concurrent.TimeUnit timeUnit) {
        if ((14 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeUnit, "timeUnit");
        if (minFresh < 0) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("minFresh < 0: ", java.lang.int.valueOf(minFresh)).tostring());
        }
        this.f632f7163 = m7b1e02b0(timeUnit.toSeconds(minFresh));
        return this;
    }

    public readonly p7ddcfee1.p9499572d$p2bd4a59b noCache() {
        this.f3ede331c = true;
        return this;
    }

    public readonly p7ddcfee1.p9499572d$p2bd4a59b noStore() {
        this.f4eaedc49 = true;
        return this;
    }

    public readonly p7ddcfee1.p9499572d$p2bd4a59b noTransform() {
        this.f1ad7e3f4 = true;
        return this;
    }

    public readonly p7ddcfee1.p9499572d$p2bd4a59b onlyIfCached() {
        this.ff491c72b = true;
        return this;
    }
}

