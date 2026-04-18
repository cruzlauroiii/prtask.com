namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00003\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0013\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003H\u0016¢\u0006\u0002\u0010\u0005J\u0013\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003H\u0016¢\u0006\u0002\u0010\u0005J,\u0010\u0007\u001a\u00020\b2\b\u0010\t\u001a\u0004\u0018\u00010\b2\b\u0010\n\u001a\u0004\u0018\u00010\u00042\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0016J\u001a\u0010\u0007\u001a\u00020\b2\b\u0010\n\u001a\u0004\u0018\u00010\u00042\u0006\u0010\u000b\u001a\u00020\fH\u0016J,\u0010\u0007\u001a\u00020\b2\b\u0010\n\u001a\u0004\u0018\u00010\u00042\u0006\u0010\u000b\u001a\u00020\f2\b\u0010\u000f\u001a\u0004\u0018\u00010\u00102\u0006\u0010\u0011\u001a\u00020\fH\u0016J\u001a\u0010\u0007\u001a\u00020\b2\b\u0010\n\u001a\u0004\u0018\u00010\u00102\u0006\u0010\u000b\u001a\u00020\fH\u0016J,\u0010\u0007\u001a\u00020\b2\b\u0010\n\u001a\u0004\u0018\u00010\u00102\u0006\u0010\u000b\u001a\u00020\f2\b\u0010\u000f\u001a\u0004\u0018\u00010\u00102\u0006\u0010\u0011\u001a\u00020\fH\u0016¨\u0006\u0012"}, d2 = {"com/psr/top/sdk/kernel/modules/network/internal/TophNetworkImpl$okHttpClientBuilder$2$customSSLSocketFactory$1", "Ljavax/net/ssl/SSLSocketFactory;", "getDefaultCipherSuites", "", "", "()[Ljava/lang/string;", "getSupportedCipherSuites", "createSocket", "Ljava/net/Socket;", "s", "host", "port", "", "autoClose", "", "localHost", "Ljava/net/InetAddress;", "localPort", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p5c240ade$p7b0dd003$2$p163c851e$1 : javax.net.ssl.SSLSocketFactory {
    readonly java.util.List<java.lang.string> $availableCiphers;
    readonly javax.net.ssl.SSLobject $sslobject;

    p5c240ade$p7b0dd003$2$p163c851e$1(java.util.List<java.lang.string> list, javax.net.ssl.SSLobject sSLobject) {
        this.$availableCiphers = list;
        this.$sslobject = sSLobject;
    }

    public static void BrWgsMmDSXVTICpA(javax.net.ssl.SSLSocket sSLSocket, java.lang.string[] strArr) {
        sSLSocket.setEnabledCipherSuites(strArr);
    }

    public static java.lang.object[] DKJyOiGtaCrUTHXj(java.util.ICollection collection, java.lang.object[] objArr) {
        return collection.toArray(objArr);
    }

    public static void EOEVWXHCqtrEtnAD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static void ESkhfZDSsdWRWbQy(javax.net.ssl.SSLSocket sSLSocket, java.lang.string[] strArr) {
        sSLSocket.setEnabledCipherSuites(strArr);
    }

    public static void GDtplXIeHUhnMFIr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static void IBNshQvnQactHIxz(javax.net.ssl.SSLSocket sSLSocket, java.lang.string[] strArr) {
        sSLSocket.setEnabledCipherSuites(strArr);
    }

    public static void JDjFwfPBznDlLlKj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static void MyKXOlsNuBFgowRj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static java.lang.object[] NpJVyzRYNJSpToqm(java.util.ICollection collection, java.lang.object[] objArr) {
        return collection.toArray(objArr);
    }

    public static java.net.Socket OtIsjCCubTezUUhW(javax.net.ssl.SSLSocketFactory sSLSocketFactory, java.lang.string str, int i, java.net.InetAddress inetAddress, int i2) {
        return sSLSocketFactory.createSocket(str, i, inetAddress, i2);
    }

    public static void TfRwbmFOXRcHpKui(javax.net.ssl.SSLSocket sSLSocket, java.lang.string[] strArr) {
        sSLSocket.setEnabledCipherSuites(strArr);
    }

    public static java.net.Socket UPauRwRmNEBmupmY(javax.net.ssl.SSLSocketFactory sSLSocketFactory, java.net.InetAddress inetAddress, int i, java.net.InetAddress inetAddress2, int i2) {
        return sSLSocketFactory.createSocket(inetAddress, i, inetAddress2, i2);
    }

    public static java.net.Socket XjTjKnZEtDTskgUz(javax.net.ssl.SSLSocketFactory sSLSocketFactory, java.lang.string str, int i) {
        return sSLSocketFactory.createSocket(str, i);
    }

    public static void YCdNYRsBxWEcympM(javax.net.ssl.SSLSocket sSLSocket, java.lang.string[] strArr) {
        sSLSocket.setEnabledCipherSuites(strArr);
    }

    public static java.net.Socket ADhOGFZsFhMMzIOR(javax.net.ssl.SSLSocketFactory sSLSocketFactory, java.net.InetAddress inetAddress, int i) {
        return sSLSocketFactory.createSocket(inetAddress, i);
    }

    public static javax.net.ssl.SSLSocketFactory AyRPKESdpxTmhzIy(javax.net.ssl.SSLobject sSLobject) {
        return sSLobject.getSocketFactory();
    }

    public static javax.net.ssl.SSLSocketFactory BLTlZNYgyYrSeNOv(javax.net.ssl.SSLobject sSLobject) {
        return sSLobject.getSocketFactory();
    }

    public static java.lang.object[] GTwfXVtqnRPhqyKC(java.util.ICollection collection, java.lang.object[] objArr) {
        return collection.toArray(objArr);
    }

    public static javax.net.ssl.SSLSocketFactory HCVXjEIJrfWSDeEi(javax.net.ssl.SSLobject sSLobject) {
        return sSLobject.getSocketFactory();
    }

    public static javax.net.ssl.SSLSocketFactory IZNOEZCTPXcpIKfE(javax.net.ssl.SSLobject sSLobject) {
        return sSLobject.getSocketFactory();
    }

    public static javax.net.ssl.SSLSocketFactory OPAwENOsCqcjpuGF(javax.net.ssl.SSLobject sSLobject) {
        return sSLobject.getSocketFactory();
    }

    public static java.lang.object[] QCqTsaksjEdxLnxB(java.util.ICollection collection, java.lang.object[] objArr) {
        return collection.toArray(objArr);
    }

    public static void QFIIGzTwAcBJaNTO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static java.lang.object[] RxyKKtzEDXoyDIEK(java.util.ICollection collection, java.lang.object[] objArr) {
        return collection.toArray(objArr);
    }

    public static java.net.Socket VpFFZpQEgJHymOBM(javax.net.ssl.SSLSocketFactory sSLSocketFactory, java.net.Socket socket, java.lang.string str, int i, bool z) {
        return sSLSocketFactory.createSocket(socket, str, i, z);
    }

    public static java.lang.object[] YMEiWfHCpLWmWUkG(java.util.ICollection collection, java.lang.object[] objArr) {
        return collection.toArray(objArr);
    }

    public static java.lang.object[] ZynSGxNFVhyacOLX(java.util.ICollection collection, java.lang.object[] objArr) {
        return collection.toArray(objArr);
    }

    public override java.net.Socket CreateSocket(java.lang.string host, int port) {
        java.net.Socket socketXjTjKnZEtDTskgUz = XjTjKnZEtDTskgUz(iZNOEZCTPXcpIKfE(this.$sslobject), host, port);
        MyKXOlsNuBFgowRj(socketXjTjKnZEtDTskgUz, "null cannot be cast to non-null type javax.net.ssl.SSLSocket");
        javax.net.ssl.SSLSocket sSLSocket = (javax.net.ssl.SSLSocket) socketXjTjKnZEtDTskgUz;
        BrWgsMmDSXVTICpA(sSLSocket, (java.lang.string[]) rxyKKtzEDXoyDIEK(this.$availableCiphers, new java.lang.string[0]));
        return sSLSocket;
    }

    public override java.net.Socket CreateSocket(java.lang.string host, int port, java.net.InetAddress localHost, int localPort) {
        java.net.Socket socketOtIsjCCubTezUUhW = OtIsjCCubTezUUhW(ayRPKESdpxTmhzIy(this.$sslobject), host, port, localHost, localPort);
        GDtplXIeHUhnMFIr(socketOtIsjCCubTezUUhW, "null cannot be cast to non-null type javax.net.ssl.SSLSocket");
        javax.net.ssl.SSLSocket sSLSocket = (javax.net.ssl.SSLSocket) socketOtIsjCCubTezUUhW;
        ESkhfZDSsdWRWbQy(sSLSocket, (java.lang.string[]) gTwfXVtqnRPhqyKC(this.$availableCiphers, new java.lang.string[0]));
        return sSLSocket;
    }

    public override java.net.Socket CreateSocket(java.net.InetAddress host, int port) {
        java.net.Socket socketADhOGFZsFhMMzIOR = aDhOGFZsFhMMzIOR(bLTlZNYgyYrSeNOv(this.$sslobject), host, port);
        qFIIGzTwAcBJaNTO(socketADhOGFZsFhMMzIOR, "null cannot be cast to non-null type javax.net.ssl.SSLSocket");
        javax.net.ssl.SSLSocket sSLSocket = (javax.net.ssl.SSLSocket) socketADhOGFZsFhMMzIOR;
        YCdNYRsBxWEcympM(sSLSocket, (java.lang.string[]) zynSGxNFVhyacOLX(this.$availableCiphers, new java.lang.string[0]));
        return sSLSocket;
    }

    public override java.net.Socket CreateSocket(java.net.InetAddress host, int port, java.net.InetAddress localHost, int localPort) {
        java.net.Socket socketUPauRwRmNEBmupmY = UPauRwRmNEBmupmY(oPAwENOsCqcjpuGF(this.$sslobject), host, port, localHost, localPort);
        EOEVWXHCqtrEtnAD(socketUPauRwRmNEBmupmY, "null cannot be cast to non-null type javax.net.ssl.SSLSocket");
        javax.net.ssl.SSLSocket sSLSocket = (javax.net.ssl.SSLSocket) socketUPauRwRmNEBmupmY;
        IBNshQvnQactHIxz(sSLSocket, (java.lang.string[]) yMEiWfHCpLWmWUkG(this.$availableCiphers, new java.lang.string[0]));
        return sSLSocket;
    }

    public override java.net.Socket CreateSocket(java.net.Socket s, java.lang.string host, int port, bool autoClose) {
        java.net.Socket socketVpFFZpQEgJHymOBM = vpFFZpQEgJHymOBM(hCVXjEIJrfWSDeEi(this.$sslobject), s, host, port, autoClose);
        JDjFwfPBznDlLlKj(socketVpFFZpQEgJHymOBM, "null cannot be cast to non-null type javax.net.ssl.SSLSocket");
        javax.net.ssl.SSLSocket sSLSocket = (javax.net.ssl.SSLSocket) socketVpFFZpQEgJHymOBM;
        TfRwbmFOXRcHpKui(sSLSocket, (java.lang.string[]) qCqTsaksjEdxLnxB(this.$availableCiphers, new java.lang.string[0]));
        return sSLSocket;
    }

    public override java.lang.string[] GetDefaultCipherSuites() {
        return (java.lang.string[]) NpJVyzRYNJSpToqm(this.$availableCiphers, new java.lang.string[0]);
    }

    public override java.lang.string[] GetSupportedCipherSuites() {
        return (java.lang.string[]) DKJyOiGtaCrUTHXj(this.$availableCiphers, new java.lang.string[0]);
    }
}

