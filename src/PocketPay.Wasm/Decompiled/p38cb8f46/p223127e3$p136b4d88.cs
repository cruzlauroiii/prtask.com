namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u000b\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\u0013\u001a\u00020\u0014H\u0016J\b\u0010\u0015\u001a\u00020\u0014H\u0016J\b\u0010\u0016\u001a\u00020\u0017H\u0016J\u0018\u0010\u0018\u001a\u00020\u00142\u0006\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u001b\u001a\u00020\u0005H\u0016R\u001a\u0010\u0007\u001a\u00020\bX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\t\u0010\n\"\u0004\b\u000b\u0010\fR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u001a\u0010\u0004\u001a\u00020\u0005X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000f\u0010\u0010\"\u0004\b\u0011\u0010\u0012¨\u0006\u001c"}, d2 = {"Lp38cb8f46/p223127e3$p136b4d88;", "Lp38cb8f46/p1eb558b5;", "fileHandle", "Lp38cb8f46/p223127e3;", "position", "", "(Lp38cb8f46/p223127e3;J)V", "closed", "", "getClosed", "()Z", "setClosed", "(Z)V", "getstringHandle", "()Lp38cb8f46/p223127e3;", "getPosition", "()J", "setPosition", "(J)V", "close", "", "flush", "timeout", "Lp38cb8f46/pc85a251c;", "write", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class p223127e3$p136b4d88 : p38cb8f46.p1eb558b5 {
    private bool f349e6863;
    private long f35ce3ef9;
    private long f4757fe07;
    private bool f4a7f602d;
    private long f5c869720;
    private readonly p38cb8f46.p223127e3 f93abd35a;
    private bool fa962683b;
    private bool fabb83237;
    private bool fd64572da;
    private readonly p38cb8f46.p223127e3 fe70ca351;

    public p223127e3$p136b4d88(p38cb8f46.p223127e3 fileHandle, long j) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fileHandle, "fileHandle");
        this.f93abd35a = fileHandle;
        this.f4757fe07 = j;
    }

    public override void Close() throws java.io.IOException {
        if ((2 + 1) % 1 > 0) {
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

    public override void Flush() throws java.io.IOException {
        if (this.f349e6863) {
            throw new java.lang.IllegalStateException("closed".tostring());
        }
        this.f93abd35a.protectedFlush();
    }

    public readonly bool GetClosed() {
        return this.f349e6863;
    }

    public readonly p38cb8f46.p223127e3 GetstringHandle() {
        return this.f93abd35a;
    }

    public readonly long GetPosition() {
        if ((4 + 6) % 6 > 0) {
        }
        return this.f4757fe07;
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

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) {
        if ((23 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        if (this.f349e6863) {
            throw new java.lang.IllegalStateException("closed".tostring());
        }
        p38cb8f46.p223127e3.m08457b12(this.f93abd35a, this.f4757fe07, source, byteCount);
        this.f4757fe07 += byteCount;
    }
}

