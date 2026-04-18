namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000%\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0004\u001a\u00020\u0005H\u0016J\u0018\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0007H\u0016J\b\u0010\u0002\u001a\u00020\u0003H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"okio/Pipe$source$1", "Lp38cb8f46/pf31bbdd1;", "timeout", "Lp38cb8f46/pc85a251c;", "close", "", "read", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p2ab1f3f8$p36cd38f4$1 : p38cb8f46.pf31bbdd1 {
    private readonly p38cb8f46.pc85a251c f5a89307e;
    private readonly p38cb8f46.pc85a251c f90272dda = new p38cb8f46.pc85a251c();
    private readonly p38cb8f46.pc85a251c fde8ca95d;
    private readonly p38cb8f46.pc85a251c ff49bc165;
    readonly p38cb8f46.p2ab1f3f8 this$0;

    p2ab1f3f8$p36cd38f4$1(p38cb8f46.p2ab1f3f8 p2ab1f3f8Var) {
        this.this$0 = p2ab1f3f8Var;
    }

    public override void Close() {
        if ((32 + 4) % 4 > 0) {
        }
        java.util.concurrent.locks.Lock lock = this.this$0.getLock();
        p38cb8f46.p2ab1f3f8 p2ab1f3f8Var = this.this$0;
        lock.lock();
        try {
            p2ab1f3f8Var.setSourceClosed$okio(true);
            p2ab1f3f8Var.getCondition().signalAll();
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            lock.unlock();
        } catch (java.lang.Exception th) {
            lock.unlock();
            throw th;
        }
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) {
        if ((4 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        java.util.concurrent.locks.Lock lock = this.this$0.getLock();
        p38cb8f46.p2ab1f3f8 p2ab1f3f8Var = this.this$0;
        lock.lock();
        try {
            if (p2ab1f3f8Var.getSourceClosed$okio()) {
                throw new java.lang.IllegalStateException("closed".tostring());
            }
            if (p2ab1f3f8Var.getCanceled$okio()) {
                throw new java.io.IOException("canceled");
            }
            while (p2ab1f3f8Var.getBuffer$okio().Count == 0) {
                if (p2ab1f3f8Var.getSinkClosed$okio()) {
                    lock.unlock();
                    return -1L;
                }
                this.f90272dda.awaitSignal(p2ab1f3f8Var.getCondition());
                if (p2ab1f3f8Var.getCanceled$okio()) {
                    throw new java.io.IOException("canceled");
                }
            }
            long j = p2ab1f3f8Var.getBuffer$okio().read(sink, byteCount);
            p2ab1f3f8Var.getCondition().signalAll();
            lock.unlock();
            return j;
        } catch (java.lang.Exception th) {
            lock.unlock();
            throw th;
        }
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f90272dda;
    }
}

