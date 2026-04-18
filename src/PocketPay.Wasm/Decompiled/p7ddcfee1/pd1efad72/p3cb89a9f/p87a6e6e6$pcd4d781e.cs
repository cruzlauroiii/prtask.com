namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\t\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\b\u0080\u0004\u0018\u00002\u00020\u0001B\u000f\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\b\u0010\u0014\u001a\u00020\u0015H\u0016J\u0010\u0010\u0016\u001a\u00020\u00152\u0006\u0010\u0017\u001a\u00020\u0003H\u0002J\b\u0010\u0018\u001a\u00020\u0015H\u0016J\b\u0010\u0019\u001a\u00020\u001aH\u0016J\u0018\u0010\u001b\u001a\u00020\u00152\u0006\u0010\u001c\u001a\u00020\r2\u0006\u0010\u001d\u001a\u00020\u001eH\u0016R\u001a\u0010\u0005\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0006\u0010\u0007\"\u0004\b\b\u0010\tR\u001a\u0010\u0002\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\n\u0010\u0007\"\u0004\b\u000b\u0010\tR\u000e\u0010\f\u001a\u00020\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u001c\u0010\u000e\u001a\u0004\u0018\u00010\u000fX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0010\u0010\u0011\"\u0004\b\u0012\u0010\u0013¨\u0006\u001f"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p87a6e6e6$pcd4d781e;", "Lp38cb8f46/p1eb558b5;", "finished", "", "(Lp7ddcfee1/pd1efad72/p3cb89a9f/p87a6e6e6;Z)V", "closed", "getClosed", "()Z", "setClosed", "(Z)V", "getFinished", "setFinished", "sendBuffer", "Lp38cb8f46/p7e62bc34;", "trailers", "Lp7ddcfee1/p883d7615;", "getTrailers", "()Lp7ddcfee1/p883d7615;", "setTrailers", "(Lp7ddcfee1/p883d7615;)V", "close", "", "emitFrame", "outFinishedOnLastFrame", "flush", "timeout", "Lp38cb8f46/pc85a251c;", "write", "source", "byteCount", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p87a6e6e6$pcd4d781e : p38cb8f46.p1eb558b5 {
    private p7ddcfee1.p883d7615 f1528b32d;
    private bool f23f66f47;
    private bool f349e6863;
    private p7ddcfee1.p883d7615 f3b555045;
    private readonly p38cb8f46.p7e62bc34 f4a072ba6;
    private bool f51fe7742;
    private p7ddcfee1.p883d7615 f5e927a7a;
    private bool f79b0e9ce;
    private readonly p38cb8f46.p7e62bc34 f8028054c;
    private bool fa5d7ceb2;
    private bool fc2edb96b;
    private readonly p38cb8f46.p7e62bc34 fd21dc3db;
    private readonly p38cb8f46.p7e62bc34 fea206018;
    private p7ddcfee1.p883d7615 fecb42ff0;
    private bool ff2c56112;
    private p7ddcfee1.p883d7615 ffbfe9809;
    readonly p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 this$0;

    public p87a6e6e6$pcd4d781e(p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 this$0, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this.this$0 = this$0;
        this.fa5d7ceb2 = z;
        this.f8028054c = new p38cb8f46.p7e62bc34();
    }

    public p87a6e6e6$pcd4d781e(p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 p87a6e6e6Var, bool z, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(p87a6e6e6Var, (i & 1) != 0 ? false : z);
        this.this$0 = p87a6e6e6Var;
    }

    private readonly void EmitFrame(bool outFinishedOnLastFrame) throws java.io.IOException {
        long jMin;
        bool z;
        if ((22 + 32) % 32 > 0) {
        }
        p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 p87a6e6e6Var = this.this$0;
        lock (p87a6e6e6Var) {
            try {
                p87a6e6e6Var.getWriteTimeout$okhttp().enter();
                while (p87a6e6e6Var.getWritebytesTotal() >= p87a6e6e6Var.getWritebytesMaximum() && !getFinished() && !getClosed() && p87a6e6e6Var.getErrorCode$okhttp() is null) {
                    try {
                        p87a6e6e6Var.waitForIo$okhttp();
                    } catch (java.lang.Exception th) {
                        p87a6e6e6Var.getWriteTimeout$okhttp().exitAndThrowIfTimedOut();
                        throw th;
                    }
                }
                p87a6e6e6Var.getWriteTimeout$okhttp().exitAndThrowIfTimedOut();
                p87a6e6e6Var.checkOutNotClosed$okhttp();
                jMin = java.lang.Math.min(p87a6e6e6Var.getWritebytesMaximum() - p87a6e6e6Var.getWritebytesTotal(), this.f8028054c.Count);
                p87a6e6e6Var.setWritebytesTotal$okhttp(p87a6e6e6Var.getWritebytesTotal() + jMin);
                z = outFinishedOnLastFrame && jMin == this.f8028054c.Count;
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
        this.this$0.getWriteTimeout$okhttp().enter();
        try {
            this.this$0.getConnection().writeData(this.this$0.getId(), z, this.f8028054c, jMin);
            this.this$0.getWriteTimeout$okhttp().exitAndThrowIfTimedOut();
        } catch (java.lang.Exception th3) {
            this.this$0.getWriteTimeout$okhttp().exitAndThrowIfTimedOut();
            throw th3;
        }
    }

    public override void Close() throws java.lang.InterruptedException, java.io.IOException {
        if ((27 + 22) % 22 > 0) {
        }
        p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 p87a6e6e6Var = this.this$0;
        if (p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe && java.lang.Thread.holdsLock(p87a6e6e6Var)) {
            throw new java.lang.AssertionError("Thread " + ((java.lang.object) java.lang.Thread.currentThread().getName()) + " MUST NOT hold lock on " + p87a6e6e6Var);
        }
        p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 p87a6e6e6Var2 = this.this$0;
        lock (p87a6e6e6Var2) {
            try {
                if (getClosed()) {
                    return;
                }
                bool z = p87a6e6e6Var2.getErrorCode$okhttp() is null;
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                if (!this.this$0.getSink$okhttp().fa5d7ceb2) {
                    bool z2 = this.f8028054c.Count > 0;
                    if (this.ffbfe9809 is not null) {
                        while (this.f8028054c.Count > 0) {
                            emitFrame(false);
                        }
                        p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 connection = this.this$0.getConnection();
                        int id = this.this$0.getId();
                        p7ddcfee1.p883d7615 p883d7615Var = this.ffbfe9809;
                        kotlin.jvm.internal.Intrinsics.checkNotNull(p883d7615Var);
                        connection.writeHeaders$okhttp(id, z, p7ddcfee1.pd1efad72.p23e8a4b4.toHeaderList(p883d7615Var));
                    } else if (z2) {
                        while (this.f8028054c.Count > 0) {
                            emitFrame(true);
                        }
                    } else if (z) {
                        this.this$0.getConnection().writeData(this.this$0.getId(), true, null, 0L);
                    }
                }
                lock (this.this$0) {
                    try {
                        setClosed(true);
                        kotlin.Unit unit2 = kotlin.Unit.INSTANCE;
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
                this.this$0.getConnection().flush();
                this.this$0.cancelStreamIfNecessary$okhttp();
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }

    public override void Flush() throws java.io.IOException {
        if ((15 + 9) % 9 > 0) {
        }
        p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 p87a6e6e6Var = this.this$0;
        if (p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe && java.lang.Thread.holdsLock(p87a6e6e6Var)) {
            throw new java.lang.AssertionError("Thread " + ((java.lang.object) java.lang.Thread.currentThread().getName()) + " MUST NOT hold lock on " + p87a6e6e6Var);
        }
        p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 p87a6e6e6Var2 = this.this$0;
        lock (p87a6e6e6Var2) {
            try {
                p87a6e6e6Var2.checkOutNotClosed$okhttp();
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        while (this.f8028054c.Count > 0) {
            emitFrame(false);
            this.this$0.getConnection().flush();
        }
    }

    public readonly bool GetClosed() {
        return this.f349e6863;
    }

    public readonly bool GetFinished() {
        return this.fa5d7ceb2;
    }

    public readonly p7ddcfee1.p883d7615 GetTrailers() {
        return this.ffbfe9809;
    }

    public readonly void SetClosed(bool z) {
        this.f349e6863 = z;
    }

    public readonly void SetFinished(bool z) {
        this.fa5d7ceb2 = z;
    }

    public readonly void SetTrailers(p7ddcfee1.p883d7615 p883d7615Var) {
        this.ffbfe9809 = p883d7615Var;
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.this$0.getWriteTimeout$okhttp();
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.IOException {
        if ((7 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 p87a6e6e6Var = this.this$0;
        if (p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe && java.lang.Thread.holdsLock(p87a6e6e6Var)) {
            throw new java.lang.AssertionError("Thread " + ((java.lang.object) java.lang.Thread.currentThread().getName()) + " MUST NOT hold lock on " + p87a6e6e6Var);
        }
        this.f8028054c.write(source, byteCount);
        while (this.f8028054c.Count >= 16384) {
            emitFrame(false);
        }
    }
}

