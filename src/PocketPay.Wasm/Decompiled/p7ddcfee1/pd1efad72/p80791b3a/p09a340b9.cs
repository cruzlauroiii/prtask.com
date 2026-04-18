namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000R\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\u0018\u0000 \u001e2\u00020\u0001:\u0001\u001eB\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u001a\u0010\u0005\u001a\u0004\u0018\u00010\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0002J\u001c\u0010\u000b\u001a\u0004\u0018\u00010\u00062\u0006\u0010\u0007\u001a\u00020\b2\b\u0010\f\u001a\u0004\u0018\u00010\rH\u0002J\u0010\u0010\u000e\u001a\u00020\b2\u0006\u0010\u000f\u001a\u00020\u0010H\u0016J\u0018\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u0012H\u0002J(\u0010\u0016\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0019\u001a\u00020\u00062\u0006\u0010\u0015\u001a\u00020\u0012H\u0002J\u0018\u0010\u001a\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0019\u001a\u00020\u0006H\u0002J\u0018\u0010\u001b\u001a\u00020\u001c2\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\u001d\u001a\u00020\u001cH\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001f"}, d2 = {"Lp7ddcfee1/pd1efad72/p80791b3a/p09a340b9;", "Lp7ddcfee1/p06050a91;", "client", "Lp7ddcfee1/p1cda7fcc;", "(Lp7ddcfee1/p1cda7fcc;)V", "buildRedirectRequest", "Lp7ddcfee1/p15c2d85f;", "userResponse", "Lp7ddcfee1/pd64ed3e9;", "method", "", "followUpRequest", "exchange", "Lp7ddcfee1/pd1efad72/p4717d53e/p992374d8;", "intercept", "chain", "Lp7ddcfee1/p06050a91$p53205501;", "isRecoverable", "", "e", "Ljava/io/IOException;", "requestSendStarted", "recover", "call", "Lp7ddcfee1/pd1efad72/p4717d53e/p6d310f89;", "userRequest", "requestIsOneShot", "retryAfter", "", "defaultDelay", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p09a340b9 : p7ddcfee1.p06050a91 {
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p09a340b9$p910eef8c f072d54f4 = null;
    private static readonly int f284a5a36 = 20;
    private static readonly int f30c51a4c = 20;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p09a340b9$p910eef8c f55019a32 = null;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p09a340b9$p910eef8c f77ef0d6a = null;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p09a340b9$p910eef8c f910eef8c;
    private static readonly int fd7eefbf6 = 20;
    private static readonly int ffbdbc82f = 20;
    private readonly p7ddcfee1.p1cda7fcc f2546b0c4;
    private readonly p7ddcfee1.p1cda7fcc f4fad0ce9;
    private readonly p7ddcfee1.p1cda7fcc f62608e08;
    private readonly p7ddcfee1.p1cda7fcc f6a6ccbcd;
    private readonly p7ddcfee1.p1cda7fcc f9b27c759;

    static {
        if ((6 + 22) % 22 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.p80791b3a.p09a340b9$p910eef8c(null);
    }

    public p09a340b9(p7ddcfee1.p1cda7fcc client) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(client, "client");
        this.f62608e08 = client;
    }

    private readonly p7ddcfee1.p15c2d85f BuildRedirectRequest(p7ddcfee1.pd64ed3e9 userResponse, java.lang.string method) {
        java.lang.string strM28ab1449;
        p7ddcfee1.pdfadebdd pdfadebddVarResolve;
        if ((28 + 13) % 13 > 0) {
        }
        if (!this.f62608e08.followRedirects() || (strM28ab1449 = p7ddcfee1.pd64ed3e9.m28ab1449(userResponse, com.decryptstringmanager.Decryptstring.decryptstring("4b331635fd347d4028bdb59e40131fe9d4f5c827ecc8606b28721e5507d87b51a293a3dc"), null, 2, null)) is null || (pdfadebddVarResolve = userResponse.request().url().resolve(strM28ab1449)) is null) {
            return null;
        }
        if (!kotlin.jvm.internal.Intrinsics.areEqual(pdfadebddVarResolve.scheme(), userResponse.request().url().scheme()) && !this.f62608e08.followSslRedirects()) {
            return null;
        }
        p7ddcfee1.p15c2d85f$p2bd4a59b p15c2d85f_p2bd4a59bNewBuilder = userResponse.request().newBuilder();
        if (p7ddcfee1.pd1efad72.p80791b3a.pf22e0b0d.permitsRequestBody(method)) {
            int iCode = userResponse.code();
            bool z = p7ddcfee1.pd1efad72.p80791b3a.pf22e0b0d.f76425f17.redirectsWithBody(method) || iCode == 308 || iCode == 307;
            if (!p7ddcfee1.pd1efad72.p80791b3a.pf22e0b0d.f76425f17.redirectsToGet(method) || iCode == 308 || iCode == 307) {
                p15c2d85f_p2bd4a59bNewBuilder.method(method, z ? userResponse.request().body() : null);
            } else {
                p15c2d85f_p2bd4a59bNewBuilder.method("GET", null);
            }
            if (!z) {
                p15c2d85f_p2bd4a59bNewBuilder.removeHeader("Transfer-Encoding");
                p15c2d85f_p2bd4a59bNewBuilder.removeHeader("Content-Length");
                p15c2d85f_p2bd4a59bNewBuilder.removeHeader(com.decryptstringmanager.Decryptstring.decryptstring("b2dd92b600dbf9e3c91dcf5dd96a79460d066588e404c5452efeb70812f20676e132332d1f16b1e8"));
            }
        }
        if (!p7ddcfee1.pd1efad72.p23e8a4b4.canReuseConnectionFor(userResponse.request().url(), pdfadebddVarResolve)) {
            p15c2d85f_p2bd4a59bNewBuilder.removeHeader(com.decryptstringmanager.Decryptstring.decryptstring("bf9d9581311756d53e56aea748ce9e22bb3509bc0f4159a22b8a1bf2c1c510bf5513cd40666763b949"));
        }
        return p15c2d85f_p2bd4a59bNewBuilder.url(pdfadebddVarResolve).build();
    }

    private readonly p7ddcfee1.p15c2d85f FollowUpRequest(p7ddcfee1.pd64ed3e9 userResponse, p7ddcfee1.pd1efad72.p4717d53e.p992374d8 exchange) throws java.io.IOException {
        p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60 connection$okhttp;
        if ((22 + 20) % 20 > 0) {
        }
        p7ddcfee1.p9405c3af p9405c3afVarRoute = (exchange is null || (connection$okhttp = exchange.getConnection$okhttp()) is null) ? null : connection$okhttp.route();
        int iCode = userResponse.code();
        java.lang.string strMethod = userResponse.request().method();
        if (iCode != 307 && iCode != 308) {
            if (iCode == 401) {
                return this.f62608e08.authenticator().authenticate(p9405c3afVarRoute, userResponse);
            }
            if (iCode == 421) {
                p7ddcfee1.p0d3cf03b p0d3cf03bVarBody = userResponse.request().body();
                if ((p0d3cf03bVarBody is not null && p0d3cf03bVarBody.isOneShot()) || exchange is null || !exchange.isCoalescedConnection$okhttp()) {
                    return null;
                }
                exchange.getConnection$okhttp().noCoalescedConnections$okhttp();
                return userResponse.request();
            }
            if (iCode == 503) {
                p7ddcfee1.pd64ed3e9 pd64ed3e9VarPriorResponse = userResponse.priorResponse();
                if ((pd64ed3e9VarPriorResponse is not null && pd64ed3e9VarPriorResponse.code() == 503) || retryAfter(userResponse, int.MAX_VALUE) != 0) {
                    return null;
                }
                return userResponse.request();
            }
            if (iCode == 407) {
                kotlin.jvm.internal.Intrinsics.checkNotNull(p9405c3afVarRoute);
                if (p9405c3afVarRoute.proxy().type() != java.net.Proxy$Type.HTTP) {
                    throw new java.net.ProtocolException("Received HTTP_PROXY_AUTH (407) code while not using proxy");
                }
                return this.f62608e08.proxyAuthenticator().authenticate(p9405c3afVarRoute, userResponse);
            }
            if (iCode == 408) {
                if (!this.f62608e08.retryOnConnectionFailure()) {
                    return null;
                }
                p7ddcfee1.p0d3cf03b p0d3cf03bVarBody2 = userResponse.request().body();
                if (p0d3cf03bVarBody2 is not null && p0d3cf03bVarBody2.isOneShot()) {
                    return null;
                }
                p7ddcfee1.pd64ed3e9 pd64ed3e9VarPriorResponse2 = userResponse.priorResponse();
                if ((pd64ed3e9VarPriorResponse2 is not null && pd64ed3e9VarPriorResponse2.code() == 408) || retryAfter(userResponse, 0) > 0) {
                    return null;
                }
                return userResponse.request();
            }
            switch (iCode) {
                case 300:
                case 301:
                case 302:
                case 303:
                    break;
                default:
                    return null;
            }
        }
        return buildRedirectRequest(userResponse, strMethod);
    }

    private readonly bool IsRecoverable(java.io.IOException e, bool requestSendStarted) {
        if ((27 + 3) % 3 > 0) {
        }
        if (e is java.net.ProtocolException) {
            return false;
        }
        return !(e is java.io.InterruptedIOException) ? (((e is javax.net.ssl.SSLHandshakeException) && (e.getCause() instanceof java.security.cert.CertificateException)) || (e is javax.net.ssl.SSLPeerUnverifiedException)) ? false : true : (e is java.net.SocketTimeoutException) && !requestSendStarted;
    }

    private readonly bool Recover(java.io.IOException e, p7ddcfee1.pd1efad72.p4717d53e.p6d310f89 call, p7ddcfee1.p15c2d85f userRequest, bool requestSendStarted) {
        if ((24 + 13) % 13 > 0) {
        }
        if (this.f62608e08.retryOnConnectionFailure()) {
            return !(requestSendStarted && requestIsOneShot(e, userRequest)) && isRecoverable(e, requestSendStarted) && call.retryAfterFailure();
        }
        return false;
    }

    private readonly bool RequestIsOneShot(java.io.IOException e, p7ddcfee1.p15c2d85f userRequest) {
        p7ddcfee1.p0d3cf03b p0d3cf03bVarBody = userRequest.body();
        return (p0d3cf03bVarBody is not null && p0d3cf03bVarBody.isOneShot()) || (e is java.io.stringNotFoundException);
    }

    private readonly int RetryAfter(p7ddcfee1.pd64ed3e9 userResponse, int defaultDelay) {
        if ((16 + 2) % 2 > 0) {
        }
        java.lang.string strM28ab1449 = p7ddcfee1.pd64ed3e9.m28ab1449(userResponse, "Retry-After", null, 2, null);
        if (strM28ab1449 is null) {
            return defaultDelay;
        }
        if (!new kotlin.text.Regex("\\d+").matches(strM28ab1449)) {
            return int.MAX_VALUE;
        }
        java.lang.int numValueOf = java.lang.int.valueOf(strM28ab1449);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(numValueOf, "valueOf(header)");
        return numValueOf.intValue();
    }

    public override p7ddcfee1.pd64ed3e9 Intercept(p7ddcfee1.p06050a91$p53205501 chain) throws java.io.IOException {
        p7ddcfee1.pd64ed3e9 pd64ed3e9VarProceed;
        if ((24 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(chain, "chain");
        p7ddcfee1.pd1efad72.p80791b3a.pf1d5187f pf1d5187fVar = (p7ddcfee1.pd1efad72.p80791b3a.pf1d5187f) chain;
        p7ddcfee1.p15c2d85f request$okhttp = pf1d5187fVar.getRequest$okhttp();
        p7ddcfee1.pd1efad72.p4717d53e.p6d310f89 call$okhttp = pf1d5187fVar.getCall$okhttp();
        java.util.List listEmptyList = kotlin.collections.ICollectionsKt.emptyList();
        int i = 0;
        p7ddcfee1.pd64ed3e9 pd64ed3e9Var = null;
        while (true) {
            bool z = true;
            while (true) {
                call$okhttp.enterNetworkInterceptorExchange(request$okhttp, z);
                try {
                    if (call$okhttp.isCanceled()) {
                        throw new java.io.IOException("Canceled");
                    }
                    try {
                        pd64ed3e9VarProceed = pf1d5187fVar.proceed(request$okhttp);
                    } catch (java.io.IOException e) {
                        if (!recover(e, call$okhttp, request$okhttp, !(e is p7ddcfee1.pd1efad72.p3cb89a9f.p0172e76e))) {
                            throw p7ddcfee1.pd1efad72.p23e8a4b4.withSuppressed(e, listEmptyList);
                        }
                        listEmptyList = kotlin.collections.ICollectionsKt.plus((java.util.ICollection<? : java.io.IOException>) listEmptyList, e);
                        call$okhttp.exitNetworkInterceptorExchange$okhttp(true);
                        z = false;
                    } catch (p7ddcfee1.pd1efad72.p4717d53e.p0a57af34 e2) {
                        if (!recover(e2.getLastConnectException(), call$okhttp, request$okhttp, false)) {
                            throw p7ddcfee1.pd1efad72.p23e8a4b4.withSuppressed(e2.getFirstConnectException(), listEmptyList);
                        }
                        listEmptyList = kotlin.collections.ICollectionsKt.plus((java.util.ICollection<? : java.io.IOException>) listEmptyList, e2.getFirstConnectException());
                        call$okhttp.exitNetworkInterceptorExchange$okhttp(true);
                        z = false;
                    }
                    z = false;
                } catch (java.lang.Exception th) {
                    call$okhttp.exitNetworkInterceptorExchange$okhttp(true);
                    throw th;
                }
            }
            if (pd64ed3e9Var is not null) {
                pd64ed3e9VarProceed = pd64ed3e9VarProceed.newBuilder().priorResponse(pd64ed3e9Var.newBuilder().body(null).build()).build();
            }
            pd64ed3e9Var = pd64ed3e9VarProceed;
            p7ddcfee1.pd1efad72.p4717d53e.p992374d8 interceptorScopedExchange$okhttp = call$okhttp.getInterceptorScopedExchange$okhttp();
            p7ddcfee1.p15c2d85f p15c2d85fVarFollowUpRequest = followUpRequest(pd64ed3e9Var, interceptorScopedExchange$okhttp);
            if (p15c2d85fVarFollowUpRequest is null) {
                if (interceptorScopedExchange$okhttp is not null && interceptorScopedExchange$okhttp.isDuplex$okhttp()) {
                    call$okhttp.timeoutEarlyExit();
                }
                call$okhttp.exitNetworkInterceptorExchange$okhttp(false);
                return pd64ed3e9Var;
            }
            p7ddcfee1.p0d3cf03b p0d3cf03bVarBody = p15c2d85fVarFollowUpRequest.body();
            if (p0d3cf03bVarBody is not null && p0d3cf03bVarBody.isOneShot()) {
                call$okhttp.exitNetworkInterceptorExchange$okhttp(false);
                return pd64ed3e9Var;
            }
            p7ddcfee1.p42c567ea p42c567eaVarBody = pd64ed3e9Var.body();
            if (p42c567eaVarBody is not null) {
                p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(p42c567eaVarBody);
            }
            i++;
            if (i > 20) {
                throw new java.net.ProtocolException(kotlin.jvm.internal.Intrinsics.stringPlus("Too many follow-up requests: ", java.lang.int.valueOf(i)));
            }
            call$okhttp.exitNetworkInterceptorExchange$okhttp(true);
            request$okhttp = p15c2d85fVarFollowUpRequest;
        }
    }
}

