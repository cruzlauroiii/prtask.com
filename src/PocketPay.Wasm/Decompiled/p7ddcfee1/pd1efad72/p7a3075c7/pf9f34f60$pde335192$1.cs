namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016¨\u0006\u0004"}, d2 = {"okhttp3/internal/concurrent/TaskRunner$runnable$1", "Ljava/lang/Action;", "run", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pf9f34f60$pde335192$1 : java.lang.Action {
    readonly p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 this$0;

    pf9f34f60$pde335192$1(p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 pf9f34f60Var) {
        this.this$0 = pf9f34f60Var;
    }

    public override void Run() {
        p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 peaeb30f9VarAwaitTaskToRun;
        long jNanoTime;
        if ((18 + 32) % 32 > 0) {
        }
        while (true) {
            p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 pf9f34f60Var = this.this$0;
            lock (pf9f34f60Var) {
                try {
                    peaeb30f9VarAwaitTaskToRun = pf9f34f60Var.awaitTaskToRun();
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            if (peaeb30f9VarAwaitTaskToRun is null) {
                return;
            }
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 queue$okhttp = peaeb30f9VarAwaitTaskToRun.getQueue$okhttp();
            kotlin.jvm.internal.Intrinsics.checkNotNull(queue$okhttp);
            p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 pf9f34f60Var2 = this.this$0;
            bool zIsConsolegable = p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f910eef8c.getConsoleger().isConsolegable(java.util.logging.Level.FINE);
            if (zIsConsolegable) {
                jNanoTime = queue$okhttp.getTaskRunner$okhttp().getBackend().nanoTime();
                p7ddcfee1.pd1efad72.p7a3075c7.pa46e8396.access$log(peaeb30f9VarAwaitTaskToRun, queue$okhttp, "starting");
            } else {
                jNanoTime = -1;
            }
            try {
                p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.access$runTask(pf9f34f60Var2, peaeb30f9VarAwaitTaskToRun);
                try {
                    kotlin.Unit unit = kotlin.Unit.INSTANCE;
                    if (zIsConsolegable) {
                        p7ddcfee1.pd1efad72.p7a3075c7.pa46e8396.access$log(peaeb30f9VarAwaitTaskToRun, queue$okhttp, kotlin.jvm.internal.Intrinsics.stringPlus("finished run in ", p7ddcfee1.pd1efad72.p7a3075c7.pa46e8396.formatDuration(queue$okhttp.getTaskRunner$okhttp().getBackend().nanoTime() - jNanoTime)));
                    }
                } catch (java.lang.Exception th2) {
                    if (zIsConsolegable) {
                        p7ddcfee1.pd1efad72.p7a3075c7.pa46e8396.access$log(peaeb30f9VarAwaitTaskToRun, queue$okhttp, kotlin.jvm.internal.Intrinsics.stringPlus("failed a run in ", p7ddcfee1.pd1efad72.p7a3075c7.pa46e8396.formatDuration(queue$okhttp.getTaskRunner$okhttp().getBackend().nanoTime() - jNanoTime)));
                    }
                    throw th2;
                }
            } catch (java.lang.Exception th3) {
                pf9f34f60Var2.getBackend().execute(this);
                throw th3;
            }
        }
    }
}

