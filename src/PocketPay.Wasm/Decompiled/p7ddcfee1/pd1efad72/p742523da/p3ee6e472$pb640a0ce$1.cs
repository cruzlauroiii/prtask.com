namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000%\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0018\u0010\b\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\t\u001a\u00020\nH\u0016¨\u0006\u000b"}, d2 = {"okhttp3/internal/ws/RealWebSocket$connect$1", "Lp7ddcfee1/p406c70d6;", "onFailure", "", "call", "Lp7ddcfee1/pc3755e61;", "e", "Ljava/io/IOException;", "onResponse", "response", "Lp7ddcfee1/pd64ed3e9;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p3ee6e472$pb640a0ce$1 : p7ddcfee1.p406c70d6 {
    readonly p7ddcfee1.p15c2d85f $request;
    readonly p7ddcfee1.pd1efad72.p742523da.p3ee6e472 this$0;

    p3ee6e472$pb640a0ce$1(p7ddcfee1.pd1efad72.p742523da.p3ee6e472 p3ee6e472Var, p7ddcfee1.p15c2d85f p15c2d85fVar) {
        this.this$0 = p3ee6e472Var;
        this.$request = p15c2d85fVar;
    }

    public override void OnFailure(p7ddcfee1.pc3755e61 call, java.io.IOException e) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(call, "call");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(e, "e");
        this.this$0.failWebSocket(e, null);
    }

    public override void OnResponse(p7ddcfee1.pc3755e61 call, p7ddcfee1.pd64ed3e9 response) throws java.io.IOException {
        if ((4 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(call, "call");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(response, "response");
        p7ddcfee1.pd1efad72.p4717d53e.p992374d8 p992374d8VarExchange = response.exchange();
        try {
            this.this$0.checkUpgradeSuccess$okhttp(response, p992374d8VarExchange);
            kotlin.jvm.internal.Intrinsics.checkNotNull(p992374d8VarExchange);
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p21b3cb64 p3ee6e472_p21b3cb64NewWebSocketStreams = p992374d8VarExchange.newWebSocketStreams();
            p7ddcfee1.pd1efad72.p742523da.p495b756f p495b756fVar = p7ddcfee1.pd1efad72.p742523da.p495b756f.f910eef8c.parse(response.headers());
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472.access$setExtensions$p(this.this$0, p495b756fVar);
            if (!p7ddcfee1.pd1efad72.p742523da.p3ee6e472.access$isValid(this.this$0, p495b756fVar)) {
                p7ddcfee1.pd1efad72.p742523da.p3ee6e472 p3ee6e472Var = this.this$0;
                lock (p3ee6e472Var) {
                    try {
                        p7ddcfee1.pd1efad72.p742523da.p3ee6e472.access$getMessageAndCloseQueue$p(p3ee6e472Var).clear();
                        p3ee6e472Var.close(1010, "unexpected Sec-WebSocket-Extensions in response header");
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
            }
            try {
                this.this$0.initReaderAndWriter(p7ddcfee1.pd1efad72.p23e8a4b4.ffcd12e30 + " WebSocket " + this.$request.url().redact(), p3ee6e472_p21b3cb64NewWebSocketStreams);
                this.this$0.getListener$okhttp().onOpen(this.this$0, response);
                this.this$0.loopReader();
            } catch (java.lang.Exception e) {
                this.this$0.failWebSocket(e, null);
            }
        } catch (java.io.IOException e2) {
            if (p992374d8VarExchange is not null) {
                p992374d8VarExchange.webSocketUpgradeFailed();
            }
            this.this$0.failWebSocket(e2, response);
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(response);
        }
    }
}

