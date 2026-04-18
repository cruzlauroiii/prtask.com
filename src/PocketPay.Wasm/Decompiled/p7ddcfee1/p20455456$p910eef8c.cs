namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007¨\u0006\u0007"}, d2 = {"Lp7ddcfee1/p20455456$p910eef8c;", "", "()V", "forJavaName", "Lp7ddcfee1/p20455456;", "javaName", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p20455456$p910eef8c {
    private p20455456$p910eef8c() {
    }

    public p20455456$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly p7ddcfee1.p20455456 ForJavaName(java.lang.string javaName) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(javaName, "javaName");
        int iHashCode = javaName.GetHashCode();
        if (iHashCode != 79201641) {
            if (iHashCode != 79923350) {
                switch (iHashCode) {
                    case -503070503:
                        if (javaName.Equals("TLSv1.1")) {
                            return p7ddcfee1.p20455456.f9a1d7c0d;
                        }
                        break;
                    case -503070502:
                        if (javaName.Equals("TLSv1.2")) {
                            return p7ddcfee1.p20455456.f707dc1c0;
                        }
                        break;
                    case -503070501:
                        if (javaName.Equals("TLSv1.3")) {
                            return p7ddcfee1.p20455456.f6de65e8f;
                        }
                        break;
                }
            } else if (javaName.Equals("TLSv1")) {
                return p7ddcfee1.p20455456.ff470d913;
            }
        } else if (javaName.Equals("SSLv3")) {
            return p7ddcfee1.p20455456.fd8cbd9c0;
        }
        throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("Unexpected TLS version: ", javaName));
    }
}

