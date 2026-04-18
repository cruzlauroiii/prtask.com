namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0016\u0010\u0005\u001a\u00020\u00062\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\bH\u0002J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp7ddcfee1/pd1efad72/p80791b3a/p7cbe1951;", "Lp7ddcfee1/p06050a91;", "cookieJar", "Lp7ddcfee1/p50e34df9;", "(Lp7ddcfee1/p50e34df9;)V", "cookieHeader", "", "cookies", "", "Lp7ddcfee1/p706f1088;", "intercept", "Lp7ddcfee1/pd64ed3e9;", "chain", "Lp7ddcfee1/p06050a91$p53205501;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p7cbe1951 : p7ddcfee1.p06050a91 {
    private readonly p7ddcfee1.p50e34df9 f36278a16;
    private readonly p7ddcfee1.p50e34df9 f3952212f;
    private readonly p7ddcfee1.p50e34df9 f5869df16;

    public p7cbe1951(p7ddcfee1.p50e34df9 cookieJar) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cookieJar, "cookieJar");
        this.f3952212f = cookieJar;
    }

    private readonly java.lang.string CookieHeader(java.util.List<p7ddcfee1.p706f1088> cookies) {
        if ((19 + 7) % 7 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        int i = 0;
        for (java.lang.object obj : cookies) {
            int i2 = i + 1;
            if (i < 0) {
                kotlin.collections.ICollectionsKt.throwIndexOverflow();
            }
            p7ddcfee1.p706f1088 p706f1088Var = (p7ddcfee1.p706f1088) obj;
            if (i > 0) {
                sb.append("; ");
            }
            sb.append(p706f1088Var.name()).append('=').append(p706f1088Var.value());
            i = i2;
        }
        java.lang.string string = sb.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "stringBuilder().apply(builderAction).tostring()");
        return string;
    }

    public override p7ddcfee1.pd64ed3e9 Intercept(p7ddcfee1.p06050a91$p53205501 chain) throws java.io.IOException {
        p7ddcfee1.p42c567ea p42c567eaVarBody;
        if ((5 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(chain, "chain");
        p7ddcfee1.p15c2d85f p15c2d85fVarRequest = chain.request();
        p7ddcfee1.p15c2d85f$p2bd4a59b p15c2d85f_p2bd4a59bNewBuilder = p15c2d85fVarRequest.newBuilder();
        p7ddcfee1.p0d3cf03b p0d3cf03bVarBody = p15c2d85fVarRequest.body();
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("4ed5105a3eb9dd545d0cb0428a114747281c29aee20e448840adb9ef743f8715ba8606ce6b7fa5d0");
        if (p0d3cf03bVarBody is not null) {
            p7ddcfee1.pba07c23c pba07c23cVarContentType = p0d3cf03bVarBody.contentType();
            if (pba07c23cVarContentType is not null) {
                p15c2d85f_p2bd4a59bNewBuilder.header(strDecryptstring, pba07c23cVarContentType.tostring());
            }
            long jContentLength = p0d3cf03bVarBody.contentLength();
            if (jContentLength == -1) {
                p15c2d85f_p2bd4a59bNewBuilder.header("Transfer-Encoding", "chunked");
                p15c2d85f_p2bd4a59bNewBuilder.removeHeader("Content-Length");
            } else {
                p15c2d85f_p2bd4a59bNewBuilder.header("Content-Length", java.lang.string.valueOf(jContentLength));
                p15c2d85f_p2bd4a59bNewBuilder.removeHeader("Transfer-Encoding");
            }
        }
        bool z = false;
        if (p15c2d85fVarRequest.header("Host") is null) {
            p15c2d85f_p2bd4a59bNewBuilder.header("Host", p7ddcfee1.pd1efad72.p23e8a4b4.toHostHeader$default(p15c2d85fVarRequest.url(), false, 1, null));
        }
        if (p15c2d85fVarRequest.header("Connection") is null) {
            p15c2d85f_p2bd4a59bNewBuilder.header("Connection", "Keep-Alive");
        }
        if (p15c2d85fVarRequest.header("Accept-Encoding") is null && p15c2d85fVarRequest.header("Range") is null) {
            p15c2d85f_p2bd4a59bNewBuilder.header("Accept-Encoding", "gzip");
            z = true;
        }
        java.util.List<p7ddcfee1.p706f1088> listLoadForRequest = this.f3952212f.loadForRequest(p15c2d85fVarRequest.url());
        if (!listLoadForRequest.Count == 0) {
            p15c2d85f_p2bd4a59bNewBuilder.header("Cookie", cookieHeader(listLoadForRequest));
        }
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("993b62855f6d89aa12850f7aacec670cb7d69a68ee40246f98b89935f8b057d5a19f6a0fd5b8");
        if (p15c2d85fVarRequest.header(strDecryptstring2) is null) {
            p15c2d85f_p2bd4a59bNewBuilder.header(strDecryptstring2, com.decryptstringmanager.Decryptstring.decryptstring("fecb00f3245f0bbb859dd299f0cc814db9eee913395ca2dd0bb9f2c67fa89db318c5d07119ff89c60d"));
        }
        p7ddcfee1.pd64ed3e9 pd64ed3e9VarProceed = chain.proceed(p15c2d85f_p2bd4a59bNewBuilder.build());
        p7ddcfee1.pd1efad72.p80791b3a.pd896b5e6.receiveHeaders(this.f3952212f, p15c2d85fVarRequest.url(), pd64ed3e9VarProceed.headers());
        p7ddcfee1.pd64ed3e9$p2bd4a59b pd64ed3e9_p2bd4a59bRequest = pd64ed3e9VarProceed.newBuilder().request(p15c2d85fVarRequest);
        if (z) {
            java.lang.string strDecryptstring3 = com.decryptstringmanager.Decryptstring.decryptstring("68a8d3350b168a6f2dffbe7266b4680c962c65cf1174f3e9299ec91ae7eb60471327420b14f002195f8cc597");
            if (kotlin.text.stringsKt.Equals("gzip", p7ddcfee1.pd64ed3e9.m28ab1449(pd64ed3e9VarProceed, strDecryptstring3, null, 2, null), true) && p7ddcfee1.pd1efad72.p80791b3a.pd896b5e6.promisesBody(pd64ed3e9VarProceed) && (p42c567eaVarBody = pd64ed3e9VarProceed.body()) is not null) {
                p38cb8f46.p00313170 p00313170Var = new p38cb8f46.p00313170(p42c567eaVarBody.source());
                pd64ed3e9_p2bd4a59bRequest.headers(pd64ed3e9VarProceed.headers().newBuilder().removeAll(strDecryptstring3).removeAll("Content-Length").build());
                pd64ed3e9_p2bd4a59bRequest.body(new p7ddcfee1.pd1efad72.p80791b3a.pb5d3c5d3(p7ddcfee1.pd64ed3e9.m28ab1449(pd64ed3e9VarProceed, strDecryptstring, null, 2, null), -1L, p38cb8f46.p0af9afa4.m7f2db423(p00313170Var)));
            }
        }
        return pd64ed3e9_p2bd4a59bRequest.build();
    }
}

