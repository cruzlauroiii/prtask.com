namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u0000 \u000f2\u00020\u0001:\u0001\u000fB\u000f\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0002\u0010\u0004J\u001a\u0010\u0007\u001a\u00020\b2\b\u0010\t\u001a\u0004\u0018\u00010\n2\u0006\u0010\u000b\u001a\u00020\bH\u0002J\u0010\u0010\f\u001a\u00020\b2\u0006\u0010\r\u001a\u00020\u000eH\u0016R\u0016\u0010\u0002\u001a\u0004\u0018\u00010\u0003X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0010"}, d2 = {"Lp7ddcfee1/pd1efad72/p0fea6a13/pa757ef60;", "Lp7ddcfee1/p06050a91;", "cache", "Lp7ddcfee1/pab0cf104;", "(Lp7ddcfee1/pab0cf104;)V", "getCache$okhttp", "()Lp7ddcfee1/pab0cf104;", "cacheWritingResponse", "Lp7ddcfee1/pd64ed3e9;", "cacheRequest", "Lp7ddcfee1/pd1efad72/p0fea6a13/p1df8d4a4;", "response", "intercept", "chain", "Lp7ddcfee1/p06050a91$p53205501;", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pa757ef60 : p7ddcfee1.p06050a91 {
    public static readonly p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p910eef8c f219cc902 = null;
    public static readonly p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p910eef8c f910eef8c;
    private readonly p7ddcfee1.pab0cf104 f0fea6a13;
    private readonly p7ddcfee1.pab0cf104 f1c3e644d;
    private readonly p7ddcfee1.pab0cf104 fe2635e26;

    static {
        if ((11 + 13) % 13 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p910eef8c(null);
    }

    public pa757ef60(p7ddcfee1.pab0cf104 pab0cf104Var) {
        this.f0fea6a13 = pab0cf104Var;
    }

    private readonly p7ddcfee1.pd64ed3e9 CacheWritingResponse(p7ddcfee1.pd1efad72.p0fea6a13.p1df8d4a4 cacheRequest, p7ddcfee1.pd64ed3e9 response) throws java.io.IOException {
        if ((2 + 30) % 30 > 0) {
        }
        if (cacheRequest is null) {
            return response;
        }
        p38cb8f46.p1eb558b5 p1eb558b5VarBody = cacheRequest.body();
        p7ddcfee1.p42c567ea p42c567eaVarBody = response.body();
        kotlin.jvm.internal.Intrinsics.checkNotNull(p42c567eaVarBody);
        p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p514c12c4$p0c71f417$1 pa757ef60_p514c12c4_p0c71f417_1 = new p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p514c12c4$p0c71f417$1(p42c567eaVarBody.source(), cacheRequest, p38cb8f46.p0af9afa4.m7f2db423(p1eb558b5VarBody));
        return response.newBuilder().body(new p7ddcfee1.pd1efad72.p80791b3a.pb5d3c5d3(p7ddcfee1.pd64ed3e9.m28ab1449(response, com.decryptstringmanager.Decryptstring.decryptstring("83623555d018b8225b45c0a9ace4214a691a43868fee90ab92a89184471594459ea7effb207b5a5b"), null, 2, null), response.body().contentLength(), p38cb8f46.p0af9afa4.m7f2db423(pa757ef60_p514c12c4_p0c71f417_1))).build();
    }

    public readonly p7ddcfee1.pab0cf104 getCache$okhttp() {
        return this.f0fea6a13;
    }

    public override p7ddcfee1.pd64ed3e9 Intercept(p7ddcfee1.p06050a91$p53205501 chain) throws java.io.IOException {
        p7ddcfee1.p42c567ea p42c567eaVarBody;
        p7ddcfee1.p42c567ea p42c567eaVarBody2;
        p7ddcfee1.p42c567ea p42c567eaVarBody3;
        if ((27 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(chain, "chain");
        p7ddcfee1.pc3755e61 pc3755e61VarCall = chain.call();
        p7ddcfee1.pab0cf104 pab0cf104Var = this.f0fea6a13;
        p7ddcfee1.pd64ed3e9 pd64ed3e9Var = pab0cf104Var is not null ? pab0cf104Var.get$okhttp(chain.request()) : null;
        p7ddcfee1.pd1efad72.p0fea6a13.p549b7765 p549b7765VarCompute = new p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e(java.lang.System.currentTimeMillis(), chain.request(), pd64ed3e9Var).compute();
        p7ddcfee1.p15c2d85f networkRequest = p549b7765VarCompute.getNetworkRequest();
        p7ddcfee1.pd64ed3e9 cacheResponse = p549b7765VarCompute.getCacheResponse();
        p7ddcfee1.pab0cf104 pab0cf104Var2 = this.f0fea6a13;
        if (pab0cf104Var2 is not null) {
            pab0cf104Var2.trackResponse$okhttp(p549b7765VarCompute);
        }
        p7ddcfee1.pd1efad72.p4717d53e.p6d310f89 p6d310f89Var = !(pc3755e61VarCall is p7ddcfee1.pd1efad72.p4717d53e.p6d310f89) ? null : (p7ddcfee1.pd1efad72.p4717d53e.p6d310f89) pc3755e61VarCall;
        p7ddcfee1.p4f9a1811 eventListener$okhttp = p6d310f89Var is not null ? p6d310f89Var.getEventListener$okhttp() : null;
        if (eventListener$okhttp is null) {
            eventListener$okhttp = p7ddcfee1.p4f9a1811.fb50339a1;
        }
        if (pd64ed3e9Var is not null && cacheResponse is null && (p42c567eaVarBody3 = pd64ed3e9Var.body()) is not null) {
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(p42c567eaVarBody3);
        }
        if (networkRequest is null && cacheResponse is null) {
            p7ddcfee1.pd64ed3e9 pd64ed3e9VarBuild = new p7ddcfee1.pd64ed3e9$p2bd4a59b().request(chain.request()).protocol(p7ddcfee1.p888a77f5.f5f1f9932).code(504).message("Unsatisfiable Request (only-if-cached)").body(p7ddcfee1.pd1efad72.p23e8a4b4.fafc9db28).sentRequestAtMillis(-1L).receivedResponseAtMillis(java.lang.System.currentTimeMillis()).build();
            eventListener$okhttp.satisfactionFailure(pc3755e61VarCall, pd64ed3e9VarBuild);
            return pd64ed3e9VarBuild;
        }
        if (networkRequest is null) {
            kotlin.jvm.internal.Intrinsics.checkNotNull(cacheResponse);
            p7ddcfee1.pd64ed3e9 pd64ed3e9VarBuild2 = cacheResponse.newBuilder().cacheResponse(p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p910eef8c.access$stripBody(f910eef8c, cacheResponse)).build();
            eventListener$okhttp.cacheHit(pc3755e61VarCall, pd64ed3e9VarBuild2);
            return pd64ed3e9VarBuild2;
        }
        if (cacheResponse is not null) {
            eventListener$okhttp.cacheConditionalHit(pc3755e61VarCall, cacheResponse);
        } else if (this.f0fea6a13 is not null) {
            eventListener$okhttp.cacheMiss(pc3755e61VarCall);
        }
        try {
            p7ddcfee1.pd64ed3e9 pd64ed3e9VarProceed = chain.proceed(networkRequest);
            if (pd64ed3e9VarProceed is null && pd64ed3e9Var is not null && (p42c567eaVarBody2 = pd64ed3e9Var.body()) is not null) {
                p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(p42c567eaVarBody2);
            }
            if (cacheResponse is not null) {
                if (pd64ed3e9VarProceed is not null && pd64ed3e9VarProceed.code() == 304) {
                    p7ddcfee1.pd64ed3e9$p2bd4a59b pd64ed3e9_p2bd4a59bNewBuilder = cacheResponse.newBuilder();
                    p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p910eef8c pa757ef60_p910eef8c = f910eef8c;
                    p7ddcfee1.pd64ed3e9 pd64ed3e9VarBuild3 = pd64ed3e9_p2bd4a59bNewBuilder.headers(p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p910eef8c.access$combine(pa757ef60_p910eef8c, cacheResponse.headers(), pd64ed3e9VarProceed.headers())).sentRequestAtMillis(pd64ed3e9VarProceed.sentRequestAtMillis()).receivedResponseAtMillis(pd64ed3e9VarProceed.receivedResponseAtMillis()).cacheResponse(p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p910eef8c.access$stripBody(pa757ef60_p910eef8c, cacheResponse)).networkResponse(p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p910eef8c.access$stripBody(pa757ef60_p910eef8c, pd64ed3e9VarProceed)).build();
                    p7ddcfee1.p42c567ea p42c567eaVarBody4 = pd64ed3e9VarProceed.body();
                    kotlin.jvm.internal.Intrinsics.checkNotNull(p42c567eaVarBody4);
                    p42c567eaVarBody4.Dispose();
                    p7ddcfee1.pab0cf104 pab0cf104Var3 = this.f0fea6a13;
                    kotlin.jvm.internal.Intrinsics.checkNotNull(pab0cf104Var3);
                    pab0cf104Var3.trackConditionalCacheHit$okhttp();
                    this.f0fea6a13.update$okhttp(cacheResponse, pd64ed3e9VarBuild3);
                    eventListener$okhttp.cacheHit(pc3755e61VarCall, pd64ed3e9VarBuild3);
                    return pd64ed3e9VarBuild3;
                }
                p7ddcfee1.p42c567ea p42c567eaVarBody5 = cacheResponse.body();
                if (p42c567eaVarBody5 is not null) {
                    p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(p42c567eaVarBody5);
                }
            }
            kotlin.jvm.internal.Intrinsics.checkNotNull(pd64ed3e9VarProceed);
            p7ddcfee1.pd64ed3e9$p2bd4a59b pd64ed3e9_p2bd4a59bNewBuilder2 = pd64ed3e9VarProceed.newBuilder();
            p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p910eef8c pa757ef60_p910eef8c2 = f910eef8c;
            p7ddcfee1.pd64ed3e9 pd64ed3e9VarBuild4 = pd64ed3e9_p2bd4a59bNewBuilder2.cacheResponse(p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p910eef8c.access$stripBody(pa757ef60_p910eef8c2, cacheResponse)).networkResponse(p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p910eef8c.access$stripBody(pa757ef60_p910eef8c2, pd64ed3e9VarProceed)).build();
            if (this.f0fea6a13 is not null) {
                if (p7ddcfee1.pd1efad72.p80791b3a.pd896b5e6.promisesBody(pd64ed3e9VarBuild4) && p7ddcfee1.pd1efad72.p0fea6a13.p549b7765.f910eef8c.isCacheable(pd64ed3e9VarBuild4, networkRequest)) {
                    p7ddcfee1.pd64ed3e9 pd64ed3e9VarCacheWritingResponse = cacheWritingResponse(this.f0fea6a13.put$okhttp(pd64ed3e9VarBuild4), pd64ed3e9VarBuild4);
                    if (cacheResponse is not null) {
                        eventListener$okhttp.cacheMiss(pc3755e61VarCall);
                    }
                    return pd64ed3e9VarCacheWritingResponse;
                }
                if (p7ddcfee1.pd1efad72.p80791b3a.pf22e0b0d.f76425f17.invalidatesCache(networkRequest.method())) {
                    try {
                        this.f0fea6a13.remove$okhttp(networkRequest);
                    } catch (java.io.IOException unused) {
                    }
                }
            }
            return pd64ed3e9VarBuild4;
        } catch (java.lang.Exception th) {
            if (pd64ed3e9Var is not null && (p42c567eaVarBody = pd64ed3e9Var.body()) is not null) {
                p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(p42c567eaVarBody);
            }
            throw th;
        }
    }
}

