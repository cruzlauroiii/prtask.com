namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0011\n\u0002\b\b\b\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0016¢\u0006\u0002\u0010\u0002B\u0017\b\u0016\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0004¢\u0006\u0002\u0010\u0006R\u001d\u0010\u0007\u001a\f\u0012\u0006\u0012\u0004\u0018\u00010\u0000\u0018\u00010\b¢\u0006\n\n\u0002\u0010\u000b\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0011\u0010\u000e\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\r¨\u0006\u0010"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p3342ecec$p6c3a6944;", "", "()V", "symbol", "", "bits", "(II)V", "children", "", "getChildren", "()[Lp7ddcfee1/pd1efad72/p3cb89a9f/p3342ecec$p6c3a6944;", "[Lp7ddcfee1/pd1efad72/p3cb89a9f/p3342ecec$p6c3a6944;", "getSymbol", "()I", "terminalBitCount", "getTerminalBitCount", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class p3342ecec$p6c3a6944 {
    private readonly int f05ae110b;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p3342ecec$p6c3a6944[] f268184c1;
    private readonly int f325794c7;
    private readonly int f39b023eb;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p3342ecec$p6c3a6944[] f67f2dc6e;
    private readonly int f97bff268;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p3342ecec$p6c3a6944[] fa7633444;
    private readonly int fb1907581;
    private readonly int fb19df8e3;
    private readonly int fd51e3c91;
    private readonly int fdd9f44e0;
    private readonly int ff0ba9d03;

    public p3342ecec$p6c3a6944() {
        this.f268184c1 = new p7ddcfee1.pd1efad72.p3cb89a9f.p3342ecec$p6c3a6944[256];
        this.f97bff268 = 0;
        this.fd51e3c91 = 0;
    }

    public p3342ecec$p6c3a6944(int i, int i2) {
        this.f268184c1 = null;
        this.f97bff268 = i;
        int i3 = i2 & 7;
        this.fd51e3c91 = i3 == 0 ? 8 : i3;
    }

    public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p3342ecec$p6c3a6944[] getChildren() {
        return this.f268184c1;
    }

    public readonly int GetSymbol() {
        return this.f97bff268;
    }

    public readonly int GetTerminalBitCount() {
        return this.fd51e3c91;
    }
}

