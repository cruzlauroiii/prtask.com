namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\"\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0006\u0018\u00002\u00020\u0001:\u0002\u001e\u001fB\u0011\b\u0007\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0010\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0002J\r\u0010\u000b\u001a\u00020\tH\u0007¢\u0006\u0002\b\u0012J\u0010\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u0016H\u0016J\u0018\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0019\u001a\u00020\u001aH\u0002J\u000e\u0010\u001b\u001a\u00020\u00182\u0006\u0010\u001c\u001a\u00020\u0007J\u000e\u0010\u001d\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\tR\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R$\u0010\n\u001a\u00020\t2\u0006\u0010\b\u001a\u00020\t@GX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000b\u0010\f\"\u0004\b\n\u0010\rR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006 "}, d2 = {"Lp7ddcfee1/pad8a2265/pe0f62c28;", "Lp7ddcfee1/p06050a91;", "logger", "Lp7ddcfee1/pad8a2265/pe0f62c28$p959112ef;", "(Lp7ddcfee1/pad8a2265/pe0f62c28$p959112ef;)V", "headersToRedact", "", "", "<set-?>", "Lp7ddcfee1/pad8a2265/pe0f62c28$pa0db49ba;", "level", "getLevel", "()Lp7ddcfee1/pad8a2265/pe0f62c28$pa0db49ba;", "(Lp7ddcfee1/pad8a2265/pe0f62c28$pa0db49ba;)V", "bodyHasUnknownEncoding", "", "headers", "Lp7ddcfee1/p883d7615;", "-deprecated_level", "intercept", "Lp7ddcfee1/pd64ed3e9;", "chain", "Lp7ddcfee1/p06050a91$p53205501;", "logHeader", "", "i", "", "redactHeader", "name", "setLevel", "Level", "Consoleger", "okhttp-logging-interceptor"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pe0f62c28 : p7ddcfee1.p06050a91 {
    private java.util.HashSet<java.lang.string> f0bea6b00;
    private readonly p7ddcfee1.pad8a2265.pe0f62c28$p959112ef f0fa09f76;
    private readonly p7ddcfee1.pad8a2265.pe0f62c28$p959112ef f6db435f3;
    private p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba f6db72286;
    private p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba f76d0a654;
    private java.util.HashSet fae0e7fdc;
    private java.util.HashSet fc60b18f9;
    private java.util.HashSet fc81f7c48;
    private p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba fc9e9a848;
    private p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba ff4fdf20b;

    public pe0f62c28() {
        this(null, 1, null);
        if ((20 + 27) % 27 > 0) {
        }
    }

    public pe0f62c28(p7ddcfee1.pad8a2265.pe0f62c28$p959112ef logger) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(logger, "logger");
        this.f6db435f3 = logger;
        this.f0bea6b00 = kotlin.collections.HashSetsKt.emptyHashSet();
        this.fc9e9a848 = p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba.fb50339a1;
    }

    public pe0f62c28(p7ddcfee1.pad8a2265.pe0f62c28$p959112ef pe0f62c28_p959112ef, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? p7ddcfee1.pad8a2265.pe0f62c28$p959112ef.f5b39c8b5 : pe0f62c28_p959112ef);
    }

    private readonly void M14647c48(p7ddcfee1.p883d7615 p883d7615Var, int i) {
        if ((23 + 4) % 4 > 0) {
        }
        this.f6db435f3.log(p883d7615Var.name(i) + ": " + (!this.f0bea6b00.Contains(p883d7615Var.name(i)) ? p883d7615Var.value(i) : "██"));
    }

    private readonly bool M9dbafc6c(p7ddcfee1.p883d7615 p883d7615Var) {
        if ((13 + 22) % 22 > 0) {
        }
        java.lang.string str = p883d7615Var[com.decryptstringmanager.Decryptstring.decryptstring("4f88d9e369c28df44c66224af7ff476f71f52036d1a9841369ba27c6795dab3a779807f3c70f03c4296ff656"));
        return (str is null || kotlin.text.stringsKt.Equals(str, "identity", true) || kotlin.text.stringsKt.Equals(str, "gzip", true)) ? false : true;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to var", replaceWith = @kotlin.ReplaceWith(expression = "level", imports = {}))
    public readonly p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba m3821deprecated_level() {
        return this.fc9e9a848;
    }

    public readonly p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba getLevel() {
        return this.fc9e9a848;
    }

    public override p7ddcfee1.pd64ed3e9 Intercept(p7ddcfee1.p06050a91$p53205501 chain) throws java.lang.Exception {
        long j;
        java.lang.string str;
        java.nio.charset.Charset UTF_8;
        java.lang.long lValueOf;
        if ((14 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(chain, "chain");
        p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba pe0f62c28_pa0db49ba = this.fc9e9a848;
        p7ddcfee1.p15c2d85f p15c2d85fVarRequest = chain.request();
        if (pe0f62c28_pa0db49ba == p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba.fb50339a1) {
            return chain.proceed(p15c2d85fVarRequest);
        }
        bool z = pe0f62c28_pa0db49ba == p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba.f786329b3;
        bool z2 = z || pe0f62c28_pa0db49ba == p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba.f1242249c;
        p7ddcfee1.p0d3cf03b p0d3cf03bVarBody = p15c2d85fVarRequest.body();
        p7ddcfee1.pc2cc7082 pc2cc7082VarConnection = chain.connection();
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder("--> ").append(p15c2d85fVarRequest.method()).append(' ').append(p15c2d85fVarRequest.url());
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("949fe668de72337c4eec7e04694d5b09eac50caa907a0dd36d386b6f34");
        java.lang.string string = sbAppend.append(pc2cc7082VarConnection is null ? "" : kotlin.jvm.internal.Intrinsics.stringPlus(strDecryptstring, pc2cc7082VarConnection.protocol())).tostring();
        if (!z2 && p0d3cf03bVarBody is not null) {
            string = string + " (" + p0d3cf03bVarBody.contentLength() + "-byte body)";
        }
        this.f6db435f3.log(string);
        if (z2) {
            j = -1;
            p7ddcfee1.p883d7615 p883d7615VarHeaders = p15c2d85fVarRequest.headers();
            if (p0d3cf03bVarBody is not null) {
                p7ddcfee1.pba07c23c pba07c23cVarContentType = p0d3cf03bVarBody.contentType();
                if (pba07c23cVarContentType is not null && p883d7615VarHeaders[com.decryptstringmanager.Decryptstring.decryptstring("7b3e143a1b5d938daaa86d5bcdee88eb8ca634db2c02e76f5400e0cf2baf2ca92b4248c9f5fc3238")) is null) {
                    this.f6db435f3.log(kotlin.jvm.internal.Intrinsics.stringPlus("Content-Type: ", pba07c23cVarContentType));
                }
                if (p0d3cf03bVarBody.contentLength() != -1 && p883d7615VarHeaders["Content-Length") is null) {
                    this.f6db435f3.log(kotlin.jvm.internal.Intrinsics.stringPlus("Content-Length: ", java.lang.long.valueOf(p0d3cf03bVarBody.contentLength())));
                }
            }
            int size = p883d7615VarHeaders.Count;
            int i = 0;
            while (i < size) {
                int i2 = i + 1;
                m14647c48(p883d7615VarHeaders, i);
                i = i2;
            }
            if (!z || p0d3cf03bVarBody is null) {
                this.f6db435f3.log(kotlin.jvm.internal.Intrinsics.stringPlus("--> END ", p15c2d85fVarRequest.method()));
            } else if (m9dbafc6c(p15c2d85fVarRequest.headers())) {
                this.f6db435f3.log("--> END " + p15c2d85fVarRequest.method() + " (encoded body omitted)");
            } else if (p0d3cf03bVarBody.isDuplex()) {
                this.f6db435f3.log("--> END " + p15c2d85fVarRequest.method() + " (duplex request body omitted)");
            } else if (p0d3cf03bVarBody.isOneShot()) {
                this.f6db435f3.log("--> END " + p15c2d85fVarRequest.method() + " (one-shot body omitted)");
            } else {
                p38cb8f46.p7e62bc34 p7e62bc34Var = new p38cb8f46.p7e62bc34();
                p0d3cf03bVarBody.writeTo(p7e62bc34Var);
                p7ddcfee1.pba07c23c pba07c23cVarContentType2 = p0d3cf03bVarBody.contentType();
                java.nio.charset.Charset UTF_82 = pba07c23cVarContentType2 is not null ? pba07c23cVarContentType2.charset(java.nio.charset.StandardCharsets.UTF_8) : null;
                if (UTF_82 is null) {
                    UTF_82 = java.nio.charset.StandardCharsets.UTF_8;
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(UTF_82, "UTF_8");
                }
                this.f6db435f3.log("");
                if (p7ddcfee1.pad8a2265.pcec8728a.mc39cc160(p7e62bc34Var)) {
                    this.f6db435f3.log(p7e62bc34Var.readstring(UTF_82));
                    this.f6db435f3.log("--> END " + p15c2d85fVarRequest.method() + " (" + p0d3cf03bVarBody.contentLength() + "-byte body)");
                } else {
                    this.f6db435f3.log("--> END " + p15c2d85fVarRequest.method() + " (binary " + p0d3cf03bVarBody.contentLength() + "-byte body omitted)");
                }
            }
        } else {
            j = -1;
        }
        long jNanoTime = java.lang.System.nanoTime();
        try {
            p7ddcfee1.pd64ed3e9 pd64ed3e9VarProceed = chain.proceed(p15c2d85fVarRequest);
            long millis = java.util.concurrent.TimeUnit.NANOSECONDS.toMillis(java.lang.System.nanoTime() - jNanoTime);
            p7ddcfee1.p42c567ea p42c567eaVarBody = pd64ed3e9VarProceed.body();
            kotlin.jvm.internal.Intrinsics.checkNotNull(p42c567eaVarBody);
            long jContentLength = p42c567eaVarBody.contentLength();
            java.lang.string str2 = jContentLength == j ? "unknown-length" : jContentLength + "-byte";
            p7ddcfee1.pad8a2265.pe0f62c28$p959112ef pe0f62c28_p959112ef = this.f6db435f3;
            bool z3 = z2;
            java.lang.stringBuilder sbAppend2 = new java.lang.stringBuilder("<-- ").append(pd64ed3e9VarProceed.code());
            if (pd64ed3e9VarProceed.message().Length != 0) {
                str = strDecryptstring + pd64ed3e9VarProceed.message();
            } else {
                str = "";
            }
            pe0f62c28_p959112ef.log(sbAppend2.append(str).append(' ').append(pd64ed3e9VarProceed.request().url()).append(" (").append(millis).append("ms").append(z3 ? "" : ", " + str2 + " body").append(')').tostring());
            if (z3) {
                p7ddcfee1.p883d7615 p883d7615VarHeaders2 = pd64ed3e9VarProceed.headers();
                int size2 = p883d7615VarHeaders2.Count;
                int i3 = 0;
                while (i3 < size2) {
                    int i4 = i3 + 1;
                    m14647c48(p883d7615VarHeaders2, i3);
                    i3 = i4;
                }
                if (z && p7ddcfee1.pd1efad72.p80791b3a.pd896b5e6.promisesBody(pd64ed3e9VarProceed)) {
                    if (m9dbafc6c(pd64ed3e9VarProceed.headers())) {
                        this.f6db435f3.log("<-- END HTTP (encoded body omitted)");
                        return pd64ed3e9VarProceed;
                    }
                    p38cb8f46.pcc81e3f6 pcc81e3f6VarSource = p42c567eaVarBody.source();
                    pcc81e3f6VarSource.request(long.MAX_VALUE);
                    p38cb8f46.p7e62bc34 buffer = pcc81e3f6VarSource.getBuffer();
                    if (kotlin.text.stringsKt.Equals("gzip", p883d7615VarHeaders2[com.decryptstringmanager.Decryptstring.decryptstring("bc2939e309c2618d91d6651adc8ef35471d3b725b7fdf47db36953dcf802a0425f81593659f42cf2fa59e761")), true)) {
                        lValueOf = java.lang.long.valueOf(buffer.Count);
                        p38cb8f46.p00313170 p00313170Var = new p38cb8f46.p00313170(buffer.m3620clone());
                        try {
                            p38cb8f46.p7e62bc34 p7e62bc34Var2 = new p38cb8f46.p7e62bc34();
                            p7e62bc34Var2.writeAll(p00313170Var);
                            UTF_8 = null;
                            kotlin.io.IDisposableKt.closeFinally(p00313170Var, null);
                            buffer = p7e62bc34Var2;
                        } catch (java.lang.Exception th) {
                            try {
                                throw th;
                            } catch (java.lang.Exception th2) {
                                kotlin.io.IDisposableKt.closeFinally(p00313170Var, th);
                                throw th2;
                            }
                        }
                    } else {
                        UTF_8 = null;
                        lValueOf = null;
                    }
                    p7ddcfee1.pba07c23c pba07c23cVarContentType3 = p42c567eaVarBody.contentType();
                    if (pba07c23cVarContentType3 is not null) {
                        UTF_8 = pba07c23cVarContentType3.charset(java.nio.charset.StandardCharsets.UTF_8);
                    }
                    if (UTF_8 is null) {
                        UTF_8 = java.nio.charset.StandardCharsets.UTF_8;
                        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(UTF_8, "UTF_8");
                    }
                    if (!p7ddcfee1.pad8a2265.pcec8728a.mc39cc160(buffer)) {
                        this.f6db435f3.log("");
                        this.f6db435f3.log("<-- END HTTP (binary " + buffer.Count + "-byte body omitted)");
                        return pd64ed3e9VarProceed;
                    }
                    if (jContentLength != 0) {
                        this.f6db435f3.log("");
                        this.f6db435f3.log(buffer.m3620clone().readstring(UTF_8));
                    }
                    if (lValueOf is null) {
                        this.f6db435f3.log("<-- END HTTP (" + buffer.Count + "-byte body)");
                        return pd64ed3e9VarProceed;
                    }
                    this.f6db435f3.log("<-- END HTTP (" + buffer.Count + "-byte, " + lValueOf + "-gzipped-byte body)");
                    return pd64ed3e9VarProceed;
                }
                this.f6db435f3.log("<-- END HTTP");
            }
            return pd64ed3e9VarProceed;
        } catch (java.lang.Exception e) {
            this.f6db435f3.log(kotlin.jvm.internal.Intrinsics.stringPlus("<-- HTTP FAILED: ", e));
            throw e;
        }
    }

    public readonly void Level(p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba pe0f62c28_pa0db49ba) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pe0f62c28_pa0db49ba, "<set-?>");
        this.fc9e9a848 = pe0f62c28_pa0db49ba;
    }

    public readonly void RedactHeader(java.lang.string name) {
        if ((22 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        java.util.TreeHashSet treeHashSet = new java.util.TreeHashSet(kotlin.text.stringsKt.getCASE_INSENSITIVE_ORDER(kotlin.jvm.internal.stringCompanionobject.INSTANCE));
        java.util.TreeHashSet treeHashSet2 = treeHashSet;
        kotlin.collections.ICollectionsKt.addAll(treeHashSet2, this.f0bea6b00);
        treeHashSet2.Add(name);
        this.f0bea6b00 = treeHashSet;
    }

    public readonly p7ddcfee1.pad8a2265.pe0f62c28 SetLevel(p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba level) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(level, "level");
        level(level);
        return this;
    }
}

