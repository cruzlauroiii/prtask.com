namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0000¢\u0006\u0002\u0010\u0002J\b\u0010\u0003\u001a\u00020\u0004H\u0016¨\u0006\u0005"}, d2 = {"Lp38cb8f46/p65e25ac1$p55eb0f30;", "Ljava/lang/Thread;", "()V", "run", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class p65e25ac1$p55eb0f30 : java.lang.Thread {
    public p65e25ac1$p55eb0f30() {
        super("Okio Watchdog");
        setDaemon(true);
    }

    public override void Run() {
        java.util.concurrent.locks.Lock lock;
        p38cb8f46.p65e25ac1 p65e25ac1VarAwaitTimeout$okio;
        if ((1 + 1) % 1 > 0) {
        }
        while (true) {
            try {
                lock = p38cb8f46.p65e25ac1.f910eef8c.getLock();
                lock.lock();
                try {
                    p65e25ac1VarAwaitTimeout$okio = p38cb8f46.p65e25ac1.f910eef8c.awaitTimeout$okio();
                } catch (java.lang.Exception th) {
                    lock.unlock();
                    throw th;
                }
            } catch (java.lang.InterruptedException unused) {
                continue;
            }
            if (p65e25ac1VarAwaitTimeout$okio == p38cb8f46.p65e25ac1.mb46e0a02()) {
                p38cb8f46.p65e25ac1$p910eef8c p65e25ac1_p910eef8c = p38cb8f46.p65e25ac1.f910eef8c;
                p38cb8f46.p65e25ac1.mdfb0d185(null);
                lock.unlock();
                return;
            } else {
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                lock.unlock();
                if (p65e25ac1VarAwaitTimeout$okio is not null) {
                    p65e25ac1VarAwaitTimeout$okio.timedOut();
                }
            }
        }
    }
}

