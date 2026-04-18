namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0080\u0004\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\b\u0010\t\u001a\u00020\nH\u0016J\u0018\u0010\u000b\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u0006H\u0016J\b\u0010\u0007\u001a\u00020\bH\u0016R\u0010\u0010\u0003\u001a\u0004\u0018\u00010\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp7ddcfee1/pd1efad72/p5837d419/p34c4c50f$p8a348876;", "Lp38cb8f46/pf31bbdd1;", "(Lp7ddcfee1/pd1efad72/p5837d419/p34c4c50f;)V", "fileOperator", "Lp7ddcfee1/pd1efad72/p5837d419/p9efefad6;", "sourcePos", "", "timeout", "Lp38cb8f46/pc85a251c;", "close", "", "read", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p34c4c50f$p8a348876 : p38cb8f46.pf31bbdd1 {
    private p7ddcfee1.pd1efad72.p5837d419.p9efefad6 f046346f0;
    private readonly p38cb8f46.pc85a251c f3b76dd98;
    private p7ddcfee1.pd1efad72.p5837d419.p9efefad6 f5940fdde;
    private readonly p38cb8f46.pc85a251c f6264cb21;
    private p7ddcfee1.pd1efad72.p5837d419.p9efefad6 f6f789cd5;
    private long f742d90ac;
    private long f8ff1ef25;
    private readonly p38cb8f46.pc85a251c f90272dda;
    private p7ddcfee1.pd1efad72.p5837d419.p9efefad6 fc0a4d634;
    private long feb837aa5;
    private long ff494d2c1;
    readonly p7ddcfee1.pd1efad72.p5837d419.p34c4c50f this$0;

    public p34c4c50f$p8a348876(p7ddcfee1.pd1efad72.p5837d419.p34c4c50f this$0) {
        if ((18 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this.this$0 = this$0;
        this.f90272dda = new p38cb8f46.pc85a251c();
        java.io.RandomAccessstring file = this$0.getstring();
        kotlin.jvm.internal.Intrinsics.checkNotNull(file);
        java.nio.channels.stringChannel channel = file.getChannel();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(channel, "file!!.channel");
        this.f6f789cd5 = new p7ddcfee1.pd1efad72.p5837d419.p9efefad6(channel);
    }

    public override void Close() throws java.io.IOException {
        if ((12 + 24) % 24 > 0) {
        }
        if (this.f6f789cd5 is not null) {
            java.io.RandomAccessstring randomAccessstring = null;
            this.f6f789cd5 = null;
            p7ddcfee1.pd1efad72.p5837d419.p34c4c50f p34c4c50fVar = this.this$0;
            lock (p34c4c50fVar) {
                try {
                    p34c4c50fVar.setSourceCount(p34c4c50fVar.getSourceCount() - 1);
                    if (p34c4c50fVar.getSourceCount() == 0) {
                        java.io.RandomAccessstring file = p34c4c50fVar.getstring();
                        p34c4c50fVar.setstring(null);
                        randomAccessstring = file;
                    }
                    kotlin.Unit unit = kotlin.Unit.INSTANCE;
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            if (randomAccessstring is not null) {
                p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(randomAccessstring);
            }
        }
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        char c;
        if ((17 + 23) % 23 > 0) {
        }
        p38cb8f46.p7e62bc34 sink2 = sink;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink2, "sink");
        if (this.f6f789cd5 is null) {
            throw new java.lang.IllegalStateException("Check failed.".tostring());
        }
        p7ddcfee1.pd1efad72.p5837d419.p34c4c50f p34c4c50fVar = this.this$0;
        lock (p34c4c50fVar) {
            while (true) {
                try {
                    if (this.ff494d2c1 != p34c4c50fVar.getUpstreamPos()) {
                        long upstreamPos = p34c4c50fVar.getUpstreamPos() - p34c4c50fVar.getBuffer().Count;
                        if (this.ff494d2c1 < upstreamPos) {
                            c = 2;
                            break;
                        }
                        long jMin = java.lang.Math.min(byteCount, p34c4c50fVar.getUpstreamPos() - this.ff494d2c1);
                        p34c4c50fVar.getBuffer().copyTo(sink2, this.ff494d2c1 - upstreamPos, jMin);
                        this.ff494d2c1 += jMin;
                        return jMin;
                    }
                    if (!p34c4c50fVar.getComplete()) {
                        if (p34c4c50fVar.getUpstreamReader() is null) {
                            p34c4c50fVar.setUpstreamReader(java.lang.Thread.currentThread());
                            c = 1;
                            break;
                        }
                        this.f90272dda.waitUntilNotified(p34c4c50fVar);
                        sink2 = sink;
                    } else {
                        return -1L;
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            if (c == 2) {
                long jMin2 = java.lang.Math.min(byteCount, this.this$0.getUpstreamPos() - this.ff494d2c1);
                p7ddcfee1.pd1efad72.p5837d419.p9efefad6 p9efefad6Var = this.f6f789cd5;
                kotlin.jvm.internal.Intrinsics.checkNotNull(p9efefad6Var);
                p9efefad6Var.read(this.ff494d2c1 + 32, sink, jMin2);
                this.ff494d2c1 += jMin2;
                return jMin2;
            }
            try {
                p38cb8f46.pf31bbdd1 upstream = this.this$0.getUpstream();
                kotlin.jvm.internal.Intrinsics.checkNotNull(upstream);
                long j = upstream.read(this.this$0.getUpstreamBuffer(), this.this$0.getBufferMaxSize());
                if (j == -1) {
                    p7ddcfee1.pd1efad72.p5837d419.p34c4c50f p34c4c50fVar2 = this.this$0;
                    p34c4c50fVar2.commit(p34c4c50fVar2.getUpstreamPos());
                    p7ddcfee1.pd1efad72.p5837d419.p34c4c50f p34c4c50fVar3 = this.this$0;
                    lock (p34c4c50fVar3) {
                        try {
                            p34c4c50fVar3.setUpstreamReader(null);
                            p34c4c50fVar3.notifyAll();
                            kotlin.Unit unit = kotlin.Unit.INSTANCE;
                        } catch (java.lang.Exception th2) {
                            throw th2;
                        }
                    }
                    return -1L;
                }
                long jMin3 = java.lang.Math.min(j, byteCount);
                this.this$0.getUpstreamBuffer().copyTo(sink, 0L, jMin3);
                this.ff494d2c1 += jMin3;
                p7ddcfee1.pd1efad72.p5837d419.p9efefad6 p9efefad6Var2 = this.f6f789cd5;
                kotlin.jvm.internal.Intrinsics.checkNotNull(p9efefad6Var2);
                p9efefad6Var2.write(this.this$0.getUpstreamPos() + 32, this.this$0.getUpstreamBuffer().m3620clone(), j);
                p7ddcfee1.pd1efad72.p5837d419.p34c4c50f p34c4c50fVar4 = this.this$0;
                lock (p34c4c50fVar4) {
                    try {
                        p34c4c50fVar4.getBuffer().write(p34c4c50fVar4.getUpstreamBuffer(), j);
                        if (p34c4c50fVar4.getBuffer().Count > p34c4c50fVar4.getBufferMaxSize()) {
                            p34c4c50fVar4.getBuffer().skip(p34c4c50fVar4.getBuffer().Count - p34c4c50fVar4.getBufferMaxSize());
                        }
                        p34c4c50fVar4.setUpstreamPos(p34c4c50fVar4.getUpstreamPos() + j);
                        kotlin.Unit unit2 = kotlin.Unit.INSTANCE;
                    } catch (java.lang.Exception th3) {
                        throw th3;
                    }
                }
                p7ddcfee1.pd1efad72.p5837d419.p34c4c50f p34c4c50fVar5 = this.this$0;
                lock (p34c4c50fVar5) {
                    try {
                        p34c4c50fVar5.setUpstreamReader(null);
                        p34c4c50fVar5.notifyAll();
                        kotlin.Unit unit3 = kotlin.Unit.INSTANCE;
                    } catch (java.lang.Exception th4) {
                        throw th4;
                    }
                }
                return jMin3;
            } catch (java.lang.Exception th5) {
                p7ddcfee1.pd1efad72.p5837d419.p34c4c50f p34c4c50fVar6 = this.this$0;
                lock (p34c4c50fVar6) {
                    try {
                        p34c4c50fVar6.setUpstreamReader(null);
                        p34c4c50fVar6.notifyAll();
                        kotlin.Unit unit4 = kotlin.Unit.INSTANCE;
                        throw th5;
                    } catch (java.lang.Exception th6) {
                        throw th6;
                    }
                }
            }
        }
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f90272dda;
    }
}

