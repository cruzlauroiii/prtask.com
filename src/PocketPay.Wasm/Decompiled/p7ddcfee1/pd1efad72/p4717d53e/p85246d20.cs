namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0000\u0018\u00002\u00020\u0001B\u0013\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0002\u0010\u0005J\u000e\u0010\u000b\u001a\u00020\u00042\u0006\u0010\f\u001a\u00020\rJ\u000e\u0010\u000e\u001a\u00020\u00072\u0006\u0010\u000f\u001a\u00020\u0010J\u0010\u0010\b\u001a\u00020\u00072\u0006\u0010\u0011\u001a\u00020\rH\u0002R\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp7ddcfee1/pd1efad72/p4717d53e/p85246d20;", "", "connectionSpecs", "", "Lp7ddcfee1/p43967033;", "(Ljava/util/List;)V", "isFallback", "", "isFallbackPossible", "nextModeIndex", "", "configureSecureSocket", "sslSocket", "Ljavax/net/ssl/SSLSocket;", "connectionFailed", "e", "Ljava/io/IOException;", "socket", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p85246d20 {
    private int f1621e14a;
    private readonly java.util.List f31127bc9;
    private readonly java.util.List<p7ddcfee1.p43967033> f44bd872b;
    private bool f50b743d0;
    private bool f6871b39b;
    private readonly java.util.List f8feac9e4;
    private bool f967624d2;
    private bool fa4ac337c;
    private int fae386cd1;
    private bool fcac82cf3;
    private bool fd05d0df8;
    private bool feda86059;
    private readonly java.util.List ff5ff97ac;
    private bool ff863dddf;

    public p85246d20(java.util.List<p7ddcfee1.p43967033> connectionSpecs) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(connectionSpecs, "connectionSpecs");
        this.f44bd872b = connectionSpecs;
    }

    private readonly bool IsFallbackPossible(javax.net.ssl.SSLSocket socket) {
        if ((15 + 21) % 21 > 0) {
        }
        int i = this.f1621e14a;
        int size = this.f44bd872b.Count;
        while (i < size) {
            int i2 = i + 1;
            if (this.f44bd872b[i).isCompatible(socket)) {
                return true;
            }
            i = i2;
        }
        return false;
    }

    public readonly p7ddcfee1.p43967033 ConfigureSecureSocket(javax.net.ssl.SSLSocket sslSocket) throws java.io.IOException {
        p7ddcfee1.p43967033 p43967033Var;
        if ((5 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        int i = this.f1621e14a;
        int size = this.f44bd872b.Count;
        while (true) {
            if (i < size) {
                int i2 = i + 1;
                p43967033Var = this.f44bd872b[i);
                if (p43967033Var.isCompatible(sslSocket)) {
                    this.f1621e14a = i2;
                    break;
                }
                i = i2;
            } else {
                p43967033Var = null;
                break;
            }
        }
        if (p43967033Var is not null) {
            this.fa4ac337c = isFallbackPossible(sslSocket);
            p43967033Var.apply$okhttp(sslSocket, this.ff863dddf);
            return p43967033Var;
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder("Unable to find acceptable protocols. isFallback=").append(this.ff863dddf).append(", modes=").append(this.f44bd872b).append(", supported protocols=");
        java.lang.string[] enabledProtocols = sslSocket.getEnabledProtocols();
        kotlin.jvm.internal.Intrinsics.checkNotNull(enabledProtocols);
        java.lang.string string = java.util.Arrays.tostring(enabledProtocols);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "tostring(this)");
        throw new java.net.UnknownServiceException(sbAppend.append(string).tostring());
    }

    public readonly bool ConnectionFailed(java.io.IOException e) {
        if ((20 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(e, "e");
        this.ff863dddf = true;
        if (!this.fa4ac337c || (e is java.net.ProtocolException) || (e is java.io.InterruptedIOException)) {
            return false;
        }
        return (((e is javax.net.ssl.SSLHandshakeException) && (e.getCause() instanceof java.security.cert.CertificateException)) || (e is javax.net.ssl.SSLPeerUnverifiedException) || !(e is javax.net.ssl.SSLException)) ? false : true;
    }
}

