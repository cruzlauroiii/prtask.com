namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\b\u0087\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004J\u0006\u0010\u0005\u001a\u00020\u0006¨\u0006\u0007"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p2446c0bf$p910eef8c;", "", "()V", "buildIfSupported", "Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p7e5d37b6;", "isSupported", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p2446c0bf$p910eef8c {
    private p2446c0bf$p910eef8c() {
    }

    public p2446c0bf$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 BuildIfSupported() {
        if (isSupported()) {
            return new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p2446c0bf();
        }
        return null;
    }

    public readonly bool IsSupported() {
        return p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c.isAndroid();
    }
}

