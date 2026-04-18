namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u001c\u0010\u0005\u001a\u0004\u0018\u00010\u00062\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\nH\u0016J\u001c\u0010\u000b\u001a\u00020\f*\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0003H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp7ddcfee1/pd1efad72/p725d9197/p2d7dd516;", "Lp7ddcfee1/p3948d67c;", "defaultDns", "Lp7ddcfee1/p4d3cc87f;", "(Lp7ddcfee1/p4d3cc87f;)V", "authenticate", "Lp7ddcfee1/p15c2d85f;", "route", "Lp7ddcfee1/p9405c3af;", "response", "Lp7ddcfee1/pd64ed3e9;", "connectToInetAddress", "Ljava/net/InetAddress;", "Ljava/net/Proxy;", "url", "Lp7ddcfee1/pdfadebdd;", "dns", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p2d7dd516 : p7ddcfee1.p3948d67c {
    private readonly p7ddcfee1.p4d3cc87f f0b1bda14;
    private readonly p7ddcfee1.p4d3cc87f f273263ff;
    private readonly p7ddcfee1.p4d3cc87f f4c6d25ba;
    private readonly p7ddcfee1.p4d3cc87f f6f839eb5;
    private readonly p7ddcfee1.p4d3cc87f feb0b39e7;

    public p2d7dd516() {
        this(null, 1, null);
        if ((19 + 28) % 28 > 0) {
        }
    }

    public p2d7dd516(p7ddcfee1.p4d3cc87f defaultDns) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(defaultDns, "defaultDns");
        this.feb0b39e7 = defaultDns;
    }

    public p2d7dd516(p7ddcfee1.p4d3cc87f p4d3cc87fVar, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? p7ddcfee1.p4d3cc87f.ffa177138 : p4d3cc87fVar);
    }

    private readonly java.net.InetAddress ConnectToInetAddress(java.net.Proxy proxy, p7ddcfee1.pdfadebdd pdfadebddVar, p7ddcfee1.p4d3cc87f p4d3cc87fVar) throws java.io.IOException {
        java.net.Proxy$Type proxy$TypeType = proxy.type();
        if ((proxy$TypeType is not null ? p7ddcfee1.pd1efad72.p725d9197.p2d7dd516$p12c674ac.$EnumSwitchDictionaryping$0[proxy$TypeType.ordinal()] : -1) == 1) {
            return (java.net.InetAddress) kotlin.collections.ICollectionsKt.first((java.util.List) p4d3cc87fVar.lookup(pdfadebddVar.host()));
        }
        java.net.SocketAddress socketAddressAddress = proxy.address();
        if (socketAddressAddress is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type java.net.InetSocketAddress");
        }
        java.net.InetAddress address = ((java.net.InetSocketAddress) socketAddressAddress).getAddress();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(address, "address() as InetSocketAddress).address");
        return address;
    }

    public override p7ddcfee1.p15c2d85f Authenticate(p7ddcfee1.p9405c3af route, p7ddcfee1.pd64ed3e9 response) throws java.io.IOException {
        java.net.PasswordAuthentication passwordAuthenticationRequestPasswordAuthentication;
        p7ddcfee1.pdd7bf230 pdd7bf230VarAddress;
        if ((22 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(response, "response");
        java.util.List<p7ddcfee1.pb5f5623b> listChallenges = response.challenges();
        p7ddcfee1.p15c2d85f p15c2d85fVarRequest = response.request();
        p7ddcfee1.pdfadebdd pdfadebddVarUrl = p15c2d85fVarRequest.url();
        bool z = response.code() == 407;
        java.net.Proxy proxy = route is not null ? route.proxy() : null;
        if (proxy is null) {
            proxy = java.net.Proxy.NO_PROXY;
        }
        for (p7ddcfee1.pb5f5623b pb5f5623bVar : listChallenges) {
            if (kotlin.text.stringsKt.Equals("Basic", pb5f5623bVar.scheme(), true)) {
                p7ddcfee1.p4d3cc87f p4d3cc87fVarDns = (route is null || (pdd7bf230VarAddress = route.address()) is null) ? null : pdd7bf230VarAddress.dns();
                if (p4d3cc87fVarDns is null) {
                    p4d3cc87fVarDns = this.feb0b39e7;
                }
                if (z) {
                    java.net.SocketAddress socketAddressAddress = proxy.address();
                    if (socketAddressAddress is null) {
                        throw new java.lang.NullPointerException("null cannot be cast to non-null type java.net.InetSocketAddress");
                    }
                    java.net.InetSocketAddress inetSocketAddress = (java.net.InetSocketAddress) socketAddressAddress;
                    java.lang.string hostName = inetSocketAddress.getHostName();
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(proxy, "proxy");
                    passwordAuthenticationRequestPasswordAuthentication = java.net.Authenticator.requestPasswordAuthentication(hostName, connectToInetAddress(proxy, pdfadebddVarUrl, p4d3cc87fVarDns), inetSocketAddress.getPort(), pdfadebddVarUrl.scheme(), pb5f5623bVar.realm(), pb5f5623bVar.scheme(), pdfadebddVarUrl.url(), java.net.Authenticator$RequestorType.PROXY);
                } else {
                    java.lang.string strHost = pdfadebddVarUrl.host();
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(proxy, "proxy");
                    passwordAuthenticationRequestPasswordAuthentication = java.net.Authenticator.requestPasswordAuthentication(strHost, connectToInetAddress(proxy, pdfadebddVarUrl, p4d3cc87fVarDns), pdfadebddVarUrl.port(), pdfadebddVarUrl.scheme(), pb5f5623bVar.realm(), pb5f5623bVar.scheme(), pdfadebddVarUrl.url(), java.net.Authenticator$RequestorType.SERVER);
                }
                if (passwordAuthenticationRequestPasswordAuthentication is not null) {
                    java.lang.string strDecryptstring = !z ? com.decryptstringmanager.Decryptstring.decryptstring("06a7e99cbae1ce6d315e512e1be1641e3ba61edde8ae4fdb0acd26e79c40bfb494d0350d358248833a") : "Proxy-Authorization";
                    java.lang.string userName = passwordAuthenticationRequestPasswordAuthentication.getUserName();
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(userName, "auth.userName");
                    char[] password = passwordAuthenticationRequestPasswordAuthentication.getPassword();
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(password, "auth.password");
                    return p15c2d85fVarRequest.newBuilder().header(strDecryptstring, p7ddcfee1.p2daf1cb5.mf17aaabc(userName, new java.lang.string(password), pb5f5623bVar.charset())).build();
                }
            }
        }
        return null;
    }
}

