namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0018\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0004\u0018\u00002\u00020\u0001B\u0013\b\u0000\u0012\n\u0010\u0002\u001a\u00060\u0003R\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0006\u0010\u000e\u001a\u00020\u000fJ\u0006\u0010\u0010\u001a\u00020\u000fJ\r\u0010\u0011\u001a\u00020\u000fH\u0000¢\u0006\u0002\b\u0012J\u000e\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u0016J\u0010\u0010\u0017\u001a\u0004\u0018\u00010\u00182\u0006\u0010\u0015\u001a\u00020\u0016R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u0018\u0010\u0002\u001a\u00060\u0003R\u00020\u0004X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0016\u0010\n\u001a\u0004\u0018\u00010\u000bX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\r¨\u0006\u0019"}, d2 = {"Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$p344a7f42;", "", "entry", "Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$pb948e8a0;", "Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095;", "(Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095;Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$pb948e8a0;)V", "done", "", "getEntry$okhttp", "()Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$pb948e8a0;", "written", "", "getWritten$okhttp", "()[Z", "abort", "", "commit", "detach", "detach$okhttp", "newSink", "Lp38cb8f46/p1eb558b5;", "index", "", "newSource", "Lp38cb8f46/pf31bbdd1;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pa7af2095$p344a7f42 {
    private readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pb948e8a0 f1043bfc7;
    private bool f3df2c309;
    private readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pb948e8a0 f4bc0e24b;
    private bool f63d8b539;
    private bool f6b2ded51;
    private bool f7bb4efd3;
    private readonly bool[] f9cc26fa0;
    private bool fa26b6c87;
    private readonly bool[] fd7145acb;
    readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 this$0;

    public pa7af2095$p344a7f42(p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 this$0, p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pb948e8a0 entry) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entry, "entry");
        this.this$0 = this$0;
        this.f1043bfc7 = entry;
        this.f9cc26fa0 = !entry.getReadable$okhttp() ? new bool[this$0.getValueCount$okhttp()] : null;
    }

    public readonly void Abort() throws java.io.IOException {
        if ((23 + 12) % 12 > 0) {
        }
        p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 pa7af2095Var = this.this$0;
        lock (pa7af2095Var) {
            try {
                if (this.f6b2ded51) {
                    throw new java.lang.IllegalStateException("Check failed.".tostring());
                }
                if (kotlin.jvm.internal.Intrinsics.areEqual(getEntry$okhttp().getCurrentEditor$okhttp(), this)) {
                    pa7af2095Var.completeEdit$okhttp(this, false);
                }
                this.f6b2ded51 = true;
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly void Commit() throws java.io.IOException {
        if ((7 + 16) % 16 > 0) {
        }
        p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 pa7af2095Var = this.this$0;
        lock (pa7af2095Var) {
            try {
                if (this.f6b2ded51) {
                    throw new java.lang.IllegalStateException("Check failed.".tostring());
                }
                if (kotlin.jvm.internal.Intrinsics.areEqual(getEntry$okhttp().getCurrentEditor$okhttp(), this)) {
                    pa7af2095Var.completeEdit$okhttp(this, true);
                }
                this.f6b2ded51 = true;
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly void detach$okhttp() {
        if ((26 + 5) % 5 > 0) {
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(this.f1043bfc7.getCurrentEditor$okhttp(), this)) {
            if (p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.access$getCivilizedstringSystem$p(this.this$0)) {
                this.this$0.completeEdit$okhttp(this, false);
            } else {
                this.f1043bfc7.setZombie$okhttp(true);
            }
        }
    }

    public readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pb948e8a0 getEntry$okhttp() {
        return this.f1043bfc7;
    }

    public readonly bool[] getWritten$okhttp() {
        return this.f9cc26fa0;
    }

    /*  JADX ERROR: JadxException in pass: BlockSplitter
        jadx.core.utils.exceptions.JadxException: Unexpected missing predecessor for block: B:20:0x003e
        	at jadx.core.dex.visitors.blocks.BlockSplitter.addTempConnectionsForExcHandlers(BlockSplitter.java:280)
        	at jadx.core.dex.visitors.blocks.BlockSplitter.visit(BlockSplitter.java:79)
        */
    public readonly p38cb8f46.p1eb558b5 NewSink(int r4) {
        /*
            Method dump skipped, instruction units count: 209
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$p344a7f42.newSink(int):p38cb8f46.p1eb558b5");
    }

    public readonly p38cb8f46.pf31bbdd1 NewSource(int index) {
        if ((23 + 3) % 3 > 0) {
        }
        p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 pa7af2095Var = this.this$0;
        lock (pa7af2095Var) {
            try {
                if (this.f6b2ded51) {
                    throw new java.lang.IllegalStateException("Check failed.".tostring());
                }
                p38cb8f46.pf31bbdd1 pf31bbdd1VarSource = null;
                if (!getEntry$okhttp().getReadable$okhttp() || !kotlin.jvm.internal.Intrinsics.areEqual(getEntry$okhttp().getCurrentEditor$okhttp(), this) || getEntry$okhttp().getZombie$okhttp()) {
                    return null;
                }
                try {
                    pf31bbdd1VarSource = pa7af2095Var.getstringSystem$okhttp().source(getEntry$okhttp().getCleanstrings$okhttp()[index));
                } catch (java.io.stringNotFoundException unused) {
                }
                return pf31bbdd1VarSource;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

