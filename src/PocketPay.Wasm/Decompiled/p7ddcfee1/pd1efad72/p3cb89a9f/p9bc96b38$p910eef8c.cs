namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u0004\u0018\u00010\u00042\u0006\u0010\u0005\u001a\u00020\u0006¨\u0006\u0007"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p9bc96b38$p910eef8c;", "", "()V", "fromHttp2", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p9bc96b38;", "code", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p9bc96b38$p910eef8c {
    private p9bc96b38$p910eef8c() {
    }

    public p9bc96b38$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 FromHttp2(int code) {
        if ((9 + 8) % 8 > 0) {
        }
        for (p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 p9bc96b38Var : p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.Values) {
            if (p9bc96b38Var.getHttpCode() == code) {
                return p9bc96b38Var;
            }
        }
        return null;
    }
}

