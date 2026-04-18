namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u000b\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\u0013\u001a\u00020\u0014H\u0016J\u0018\u0010\u0015\u001a\u00020\u00052\u0006\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u0005H\u0016J\b\u0010\u0019\u001a\u00020\u001aH\u0016R\u001a\u0010\u0007\u001a\u00020\bX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\t\u0010\n\"\u0004\b\u000b\u0010\fR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u001a\u0010\u0004\u001a\u00020\u0005X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000f\u0010\u0010\"\u0004\b\u0011\u0010\u0012¨\u0006\u001b"}, d2 = {"Lp38cb8f46/p223127e3$p6cee4383;", "Lp38cb8f46/pf31bbdd1;", "fileHandle", "Lp38cb8f46/p223127e3;", "position", "", "(Lp38cb8f46/p223127e3;J)V", "closed", "", "getClosed", "()Z", "setClosed", "(Z)V", "getstringHandle", "()Lp38cb8f46/p223127e3;", "getPosition", "()J", "setPosition", "(J)V", "close", "", "read", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "timeout", "Lp38cb8f46/pc85a251c;", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class p223127e3$p6cee4383 : p38cb8f46.pf31bbdd1 {
    private bool f14e8fd57;
    private long f159aea43;
    private bool f349e6863;
    private bool f4005169b;
    private long f4757fe07;
    private readonly p38cb8f46.p223127e3 f532b7695;
    private readonly p38cb8f46.p223127e3 f5673ae88;
    private readonly p38cb8f46.p223127e3 f93abd35a;
    private readonly p38cb8f46.p223127e3 fbb764c49;
    private bool fd98118f9;
    private bool fe6b18c1a;
    private readonly p38cb8f46.p223127e3 fe7716eb7;
    private long ff8463cc3;

    public p223127e3$p6cee4383(p38cb8f46.p223127e3 fileHandle, long j) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fileHandle, "fileHandle");
        this.f93abd35a = fileHandle;
        this.f4757fe07 = j;
    }

    public override void Close() throws java.io.IOException {
        if ((29 + 15) % 15 > 0) {
        }
        if (this.f349e6863) {
            return;
        }
        this.f349e6863 = true;
        java.util.concurrent.locks.Lock lock = this.f93abd35a.getLock();
        lock.lock();
        try {
            p38cb8f46.p223127e3.m85b60549(this.f93abd35a, p38cb8f46.p223127e3.m6880f43e(r1) - 1);
            if (p38cb8f46.p223127e3.m6880f43e(this.f93abd35a) == 0 && p38cb8f46.p223127e3.mb6adc4cd(this.f93abd35a)) {
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                lock.unlock();
                this.f93abd35a.protectedClose();
                return;
            }
            lock.unlock();
        } catch (java.lang.Exception th) {
            lock.unlock();
            throw th;
        }
    }

    public readonly bool GetClosed() {
        return this.f349e6863;
    }

    public readonly p38cb8f46.p223127e3 GetstringHandle() {
        return this.f93abd35a;
    }

    public readonly long GetPosition() {
        if ((18 + 24) % 24 > 0) {
        }
        return this.f4757fe07;
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) {
        if ((12 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        if (this.f349e6863) {
            throw new java.lang.IllegalStateException("closed".tostring());
        }
        long jM490a646e = p38cb8f46.p223127e3.m490a646e(this.f93abd35a, this.f4757fe07, sink, byteCount);
        if (jM490a646e != -1) {
            this.f4757fe07 += jM490a646e;
        }
        return jM490a646e;
    }

    public readonly void SetClosed(bool z) {
        this.f349e6863 = z;
    }

    public readonly void SetPosition(long j) {
        this.f4757fe07 = j;
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return p38cb8f46.pc85a251c.fb50339a1;
    }
}

