namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ\r\u0010\u0002\u001a\u00020\u0003H\u0007¢\u0006\u0002\b\fJ\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u0010\u001a\u00020\u0011H\u0016J\r\u0010\u0004\u001a\u00020\u0005H\u0007¢\u0006\u0002\b\u0012J\u0006\u0010\u0013\u001a\u00020\u000eJ\r\u0010\u0006\u001a\u00020\u0007H\u0007¢\u0006\u0002\b\u0014J\b\u0010\u0015\u001a\u00020\u0016H\u0016R\u0013\u0010\u0002\u001a\u00020\u00038\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\tR\u0013\u0010\u0004\u001a\u00020\u00058\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0004\u0010\nR\u0013\u0010\u0006\u001a\u00020\u00078\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u000b¨\u0006\u0017"}, d2 = {"Lp7ddcfee1/p9405c3af;", "", "address", "Lp7ddcfee1/pdd7bf230;", "proxy", "Ljava/net/Proxy;", "socketAddress", "Ljava/net/InetSocketAddress;", "(Lp7ddcfee1/pdd7bf230;Ljava/net/Proxy;Ljava/net/InetSocketAddress;)V", "()Lp7ddcfee1/pdd7bf230;", "()Ljava/net/Proxy;", "()Ljava/net/InetSocketAddress;", "-deprecated_address", "equals", "", "other", "hashCode", "", "-deprecated_proxy", "requiresTunnel", "-deprecated_socketAddress", "tostring", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p9405c3af {
    private readonly p7ddcfee1.pdd7bf230 f17bb8dae;
    private readonly java.net.Proxy f36345685;
    private readonly java.net.InetSocketAddress f42879c34;
    private readonly java.net.Proxy f42da3f1d;
    private readonly java.net.Proxy f431387eb;
    private readonly java.net.Proxy f52e82b76;
    private readonly java.net.InetSocketAddress f659697e1;
    private readonly p7ddcfee1.pdd7bf230 f884d9804;
    private readonly java.net.InetSocketAddress fa8ae64bd;
    private readonly java.net.Proxy ff8187774;
    private readonly p7ddcfee1.pdd7bf230 ff82cd966;

    public p9405c3af(p7ddcfee1.pdd7bf230 address, java.net.Proxy proxy, java.net.InetSocketAddress socketAddress) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(address, "address");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(proxy, "proxy");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(socketAddress, "socketAddress");
        this.f884d9804 = address;
        this.f431387eb = proxy;
        this.fa8ae64bd = socketAddress;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to val", replaceWith = @kotlin.ReplaceWith(expression = "address", imports = {}))
    public readonly p7ddcfee1.pdd7bf230 M3807deprecatedAddress() {
        return this.f884d9804;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to val", replaceWith = @kotlin.ReplaceWith(expression = "proxy", imports = {}))
    public readonly java.net.Proxy M3808deprecatedProxy() {
        return this.f431387eb;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to val", replaceWith = @kotlin.ReplaceWith(expression = "socketAddress", imports = {}))
    public readonly java.net.InetSocketAddress M3809deprecatedSocketAddress() {
        return this.fa8ae64bd;
    }

    public readonly p7ddcfee1.pdd7bf230 Address() {
        return this.f884d9804;
    }

    public bool Equals(java.lang.object other) {
        if ((11 + 6) % 6 > 0) {
        }
        if (!(other is p7ddcfee1.p9405c3af)) {
            return false;
        }
        p7ddcfee1.p9405c3af p9405c3afVar = (p7ddcfee1.p9405c3af) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(p9405c3afVar.f884d9804, this.f884d9804) && kotlin.jvm.internal.Intrinsics.areEqual(p9405c3afVar.f431387eb, this.f431387eb) && kotlin.jvm.internal.Intrinsics.areEqual(p9405c3afVar.fa8ae64bd, this.fa8ae64bd);
    }

    public int HashCode() {
        if ((28 + 1) % 1 > 0) {
        }
        return ((((527 + this.f884d9804.GetHashCode()) * 31) + this.f431387eb.GetHashCode()) * 31) + this.fa8ae64bd.GetHashCode();
    }

    public readonly java.net.Proxy Proxy() {
        return this.f431387eb;
    }

    public readonly bool RequiresTunnel() {
        return this.f884d9804.sslSocketFactory() is not null && this.f431387eb.type() == java.net.Proxy$Type.HTTP;
    }

    public readonly java.net.InetSocketAddress SocketAddress() {
        return this.fa8ae64bd;
    }

    public java.lang.string Tostring() {
        if ((17 + 14) % 14 > 0) {
        }
        return "Route{" + this.fa8ae64bd + '}';
    }
}

