namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0080\u0004\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u000e\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u0019J\u0012\u0010\u001a\u001a\u00020\u00172\n\u0010\u001b\u001a\u00060\u0000R\u00020\u0006J\b\u0010\u001c\u001a\u00020\u0017H\u0016R\u0011\u0010\u0005\u001a\u00020\u00068F¢\u0006\u0006\u001a\u0004\b\u0007\u0010\bR\u001e\u0010\u000b\u001a\u00020\n2\u0006\u0010\t\u001a\u00020\n@BX\u0086\u000e¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0011\u0010\u000e\u001a\u00020\u000f8F¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011R\u0011\u0010\u0012\u001a\u00020\u00138F¢\u0006\u0006\u001a\u0004\b\u0014\u0010\u0015R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001d"}, d2 = {"Lp7ddcfee1/pd1efad72/p4717d53e/p6d310f89$p9319e475;", "Ljava/lang/Action;", "responseCallback", "Lp7ddcfee1/p406c70d6;", "(Lp7ddcfee1/pd1efad72/p4717d53e/p6d310f89;Lp7ddcfee1/p406c70d6;)V", "call", "Lp7ddcfee1/pd1efad72/p4717d53e/p6d310f89;", "getCall", "()Lp7ddcfee1/pd1efad72/p4717d53e/p6d310f89;", "<set-?>", "Ljava/util/concurrent/atomic/Atomicint;", "callsPerHost", "getCallsPerHost", "()Ljava/util/concurrent/atomic/Atomicint;", "host", "", "getHost", "()Ljava/lang/string;", "request", "Lp7ddcfee1/p15c2d85f;", "getRequest", "()Lp7ddcfee1/p15c2d85f;", "executeOn", "", "executorService", "Ljava/util/concurrent/TaskScheduler;", "reuseCallsPerHostFrom", "other", "run", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p6d310f89$p9319e475 : java.lang.Action {
    private java.util.concurrent.atomic.Atomicint f145820c5;
    private readonly p7ddcfee1.p406c70d6 f22069ea2;
    private java.util.concurrent.atomic.Atomicint f25baa91d;
    private readonly p7ddcfee1.p406c70d6 f3b0b6b0e;
    private java.util.concurrent.atomic.Atomicint f4a4972b8;
    private java.util.concurrent.atomic.Atomicint f6f911dd4;
    private java.util.concurrent.atomic.Atomicint fa3dbd60c;
    readonly p7ddcfee1.pd1efad72.p4717d53e.p6d310f89 this$0;

    public p6d310f89$p9319e475(p7ddcfee1.pd1efad72.p4717d53e.p6d310f89 this$0, p7ddcfee1.p406c70d6 responseCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(responseCallback, "responseCallback");
        this.this$0 = this$0;
        this.f22069ea2 = responseCallback;
        this.f4a4972b8 = new java.util.concurrent.atomic.Atomicint(0);
    }

    public readonly void ExecuteOn(java.util.concurrent.TaskScheduler executorService) {
        if ((17 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(executorService, "executorService");
        p7ddcfee1.pdbfcc2e9 pdbfcc2e9VarDispatcher = this.this$0.getClient().dispatcher();
        if (p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe && java.lang.Thread.holdsLock(pdbfcc2e9VarDispatcher)) {
            throw new java.lang.AssertionError("Thread " + ((java.lang.object) java.lang.Thread.currentThread().getName()) + " MUST NOT hold lock on " + pdbfcc2e9VarDispatcher);
        }
        try {
            try {
                executorService.execute(this);
            } catch (java.util.concurrent.RejectedExecutionException e) {
                java.io.InterruptedIOException interruptedIOException = new java.io.InterruptedIOException("executor rejected");
                interruptedIOException.initCause(e);
                this.this$0.noMoreExchanges$okhttp(interruptedIOException);
                this.f22069ea2.onFailure(this.this$0, interruptedIOException);
                this.this$0.getClient().dispatcher().finished$okhttp(this);
            }
        } catch (java.lang.Exception th) {
            this.this$0.getClient().dispatcher().finished$okhttp(this);
            throw th;
        }
    }

    public readonly p7ddcfee1.pd1efad72.p4717d53e.p6d310f89 GetCall() {
        return this.this$0;
    }

    public readonly java.util.concurrent.atomic.Atomicint GetCallsPerHost() {
        return this.f4a4972b8;
    }

    public readonly java.lang.string GetHost() {
        return this.this$0.getOriginalRequest().url().host();
    }

    public readonly p7ddcfee1.p15c2d85f GetRequest() {
        return this.this$0.getOriginalRequest();
    }

    public readonly void ReuseCallsPerHostFrom(p7ddcfee1.pd1efad72.p4717d53e.p6d310f89$p9319e475 other) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        this.f4a4972b8 = other.f4a4972b8;
    }

    public override void Run() {
        bool z;
        java.lang.Exception th;
        java.io.IOException e;
        p7ddcfee1.pdbfcc2e9 pdbfcc2e9VarDispatcher;
        if ((13 + 32) % 32 > 0) {
        }
        java.lang.string strstringPlus = kotlin.jvm.internal.Intrinsics.stringPlus("OkHttp ", this.this$0.redactedUrl$okhttp());
        p7ddcfee1.pd1efad72.p4717d53e.p6d310f89 p6d310f89Var = this.this$0;
        java.lang.Thread threadCurrentThread = java.lang.Thread.currentThread();
        java.lang.string name = threadCurrentThread.getName();
        threadCurrentThread.setName(strstringPlus);
        try {
            p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.access$getTimeout$p(p6d310f89Var).enter();
            try {
                try {
                    z = true;
                } catch (java.lang.Exception th2) {
                    p6d310f89Var.getClient().dispatcher().finished$okhttp(this);
                    throw th2;
                }
            } catch (java.io.IOException e2) {
                z = false;
                e = e2;
            } catch (java.lang.Exception th3) {
                z = false;
                th = th3;
            }
            try {
                this.f22069ea2.onResponse(p6d310f89Var, p6d310f89Var.getResponseWithInterceptorChain$okhttp());
                pdbfcc2e9VarDispatcher = p6d310f89Var.getClient().dispatcher();
            } catch (java.io.IOException e3) {
                e = e3;
                if (z) {
                    p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c[).log(kotlin.jvm.internal.Intrinsics.stringPlus("Callback failure for ", p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.access$toConsolegablestring(p6d310f89Var)), 4, e);
                } else {
                    this.f22069ea2.onFailure(p6d310f89Var, e);
                }
                pdbfcc2e9VarDispatcher = p6d310f89Var.getClient().dispatcher();
            } catch (java.lang.Exception th4) {
                th = th4;
                p6d310f89Var.cancel();
                if (!z) {
                    java.io.IOException iOException = new java.io.IOException(kotlin.jvm.internal.Intrinsics.stringPlus("canceled due to ", th));
                    kotlin.ExceptionsKt.addSuppressed(iOException, th);
                    this.f22069ea2.onFailure(p6d310f89Var, iOException);
                }
                throw th;
            }
            pdbfcc2e9VarDispatcher.finished$okhttp(this);
            threadCurrentThread.setName(name);
        } catch (java.lang.Exception th5) {
            threadCurrentThread.setName(name);
            throw th5;
        }
    }
}

