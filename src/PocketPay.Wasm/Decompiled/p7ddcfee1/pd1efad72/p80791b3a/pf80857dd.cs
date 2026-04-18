namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0010\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lp7ddcfee1/pd1efad72/p80791b3a/pf80857dd;", "Lp7ddcfee1/p06050a91;", "forWebSocket", "", "(Z)V", "intercept", "Lp7ddcfee1/pd64ed3e9;", "chain", "Lp7ddcfee1/p06050a91$p53205501;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pf80857dd : p7ddcfee1.p06050a91 {
    private readonly bool f0815b072;
    private readonly bool f25528b85;
    private readonly bool f384a59fe;
    private readonly bool f578c56f2;

    public pf80857dd(bool z) {
        this.f578c56f2 = z;
    }

    public override p7ddcfee1.pd64ed3e9 Intercept(p7ddcfee1.p06050a91$p53205501 chain) throws java.io.IOException {
        bool z;
        p7ddcfee1.pd64ed3e9$p2bd4a59b responseHeaders;
        if ((7 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(chain, "chain");
        p7ddcfee1.pd1efad72.p80791b3a.pf1d5187f pf1d5187fVar = (p7ddcfee1.pd1efad72.p80791b3a.pf1d5187f) chain;
        p7ddcfee1.pd1efad72.p4717d53e.p992374d8 exchange$okhttp = pf1d5187fVar.getExchange$okhttp();
        kotlin.jvm.internal.Intrinsics.checkNotNull(exchange$okhttp);
        p7ddcfee1.p15c2d85f request$okhttp = pf1d5187fVar.getRequest$okhttp();
        p7ddcfee1.p0d3cf03b p0d3cf03bVarBody = request$okhttp.body();
        long jCurrentTimeMillis = java.lang.System.currentTimeMillis();
        exchange$okhttp.writeRequestHeaders(request$okhttp);
        if (p7ddcfee1.pd1efad72.p80791b3a.pf22e0b0d.permitsRequestBody(request$okhttp.method()) && p0d3cf03bVarBody is not null) {
            if (kotlin.text.stringsKt.Equals("100-continue", request$okhttp.header("Expect"), true)) {
                exchange$okhttp.flushRequest();
                responseHeaders = exchange$okhttp.readResponseHeaders(true);
                exchange$okhttp.responseHeadersStart();
                z = false;
            } else {
                z = true;
                responseHeaders = null;
            }
            if (responseHeaders is not null) {
                exchange$okhttp.noRequestBody();
                if (!exchange$okhttp.getConnection$okhttp().isMultiplexed$okhttp()) {
                    exchange$okhttp.noNewExchangesOnConnection();
                }
            } else if (p0d3cf03bVarBody.isDuplex()) {
                exchange$okhttp.flushRequest();
                p0d3cf03bVarBody.writeTo(p38cb8f46.p0af9afa4.m7f2db423(exchange$okhttp.createRequestBody(request$okhttp, true)));
            } else {
                p38cb8f46.p08d84bc6 p08d84bc6VarM7f2db423 = p38cb8f46.p0af9afa4.m7f2db423(exchange$okhttp.createRequestBody(request$okhttp, false));
                p0d3cf03bVarBody.writeTo(p08d84bc6VarM7f2db423);
                p08d84bc6VarM7f2db423.Dispose();
            }
        } else {
            exchange$okhttp.noRequestBody();
            z = true;
            responseHeaders = null;
        }
        if (p0d3cf03bVarBody is null || !p0d3cf03bVarBody.isDuplex()) {
            exchange$okhttp.finishRequest();
        }
        if (responseHeaders is null) {
            responseHeaders = exchange$okhttp.readResponseHeaders(false);
            kotlin.jvm.internal.Intrinsics.checkNotNull(responseHeaders);
            if (z) {
                exchange$okhttp.responseHeadersStart();
                z = false;
            }
        }
        p7ddcfee1.pd64ed3e9 pd64ed3e9VarBuild = responseHeaders.request(request$okhttp).handshake(exchange$okhttp.getConnection$okhttp().handshake()).sentRequestAtMillis(jCurrentTimeMillis).receivedResponseAtMillis(java.lang.System.currentTimeMillis()).build();
        int iCode = pd64ed3e9VarBuild.code();
        if (iCode == 100) {
            p7ddcfee1.pd64ed3e9$p2bd4a59b responseHeaders2 = exchange$okhttp.readResponseHeaders(false);
            kotlin.jvm.internal.Intrinsics.checkNotNull(responseHeaders2);
            if (z) {
                exchange$okhttp.responseHeadersStart();
            }
            pd64ed3e9VarBuild = responseHeaders2.request(request$okhttp).handshake(exchange$okhttp.getConnection$okhttp().handshake()).sentRequestAtMillis(jCurrentTimeMillis).receivedResponseAtMillis(java.lang.System.currentTimeMillis()).build();
            iCode = pd64ed3e9VarBuild.code();
        }
        exchange$okhttp.responseHeadersEnd(pd64ed3e9VarBuild);
        p7ddcfee1.pd64ed3e9 pd64ed3e9VarBuild2 = (this.f578c56f2 && iCode == 101) ? pd64ed3e9VarBuild.newBuilder().body(p7ddcfee1.pd1efad72.p23e8a4b4.fafc9db28).build() : pd64ed3e9VarBuild.newBuilder().body(exchange$okhttp.openResponseBody(pd64ed3e9VarBuild)).build();
        if (kotlin.text.stringsKt.Equals("close", pd64ed3e9VarBuild2.request().header("Connection"), true) || kotlin.text.stringsKt.Equals("close", p7ddcfee1.pd64ed3e9.m28ab1449(pd64ed3e9VarBuild2, "Connection", null, 2, null), true)) {
            exchange$okhttp.noNewExchangesOnConnection();
        }
        if (iCode == 204 || iCode == 205) {
            p7ddcfee1.p42c567ea p42c567eaVarBody = pd64ed3e9VarBuild2.body();
            if ((p42c567eaVarBody is not null ? p42c567eaVarBody.contentLength() : -1L) > 0) {
                java.lang.stringBuilder sbAppend = new java.lang.stringBuilder("HTTP ").append(iCode).append(" had non-zero Content-Length: ");
                p7ddcfee1.p42c567ea p42c567eaVarBody2 = pd64ed3e9VarBuild2.body();
                throw new java.net.ProtocolException(sbAppend.append(p42c567eaVarBody2 is not null ? java.lang.long.valueOf(p42c567eaVarBody2.contentLength()) : null).tostring());
            }
        }
        return pd64ed3e9VarBuild2;
    }
}

