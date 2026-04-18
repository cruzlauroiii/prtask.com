namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000-\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016J\b\u0010\u0004\u001a\u00020\u0003H\u0016J\b\u0010\u0005\u001a\u00020\u0006H\u0016J\b\u0010\u0007\u001a\u00020\bH\u0016J\u0018\u0010\t\u001a\u00020\u00032\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0016¨\u0006\u000e"}, d2 = {"okio/AsyncTimeout$sink$1", "Lp38cb8f46/p1eb558b5;", "close", "", "flush", "timeout", "Lp38cb8f46/p65e25ac1;", "tostring", "", "write", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p65e25ac1$pf6e04117$1 : p38cb8f46.p1eb558b5 {
    readonly p38cb8f46.p1eb558b5 $sink;
    readonly p38cb8f46.p65e25ac1 this$0;

    p65e25ac1$pf6e04117$1(p38cb8f46.p65e25ac1 p65e25ac1Var, p38cb8f46.p1eb558b5 p1eb558b5Var) {
        this.this$0 = p65e25ac1Var;
        this.$sink = p1eb558b5Var;
    }

    public override void Close() throws java.io.IOException {
        if ((10 + 4) % 4 > 0) {
        }
        p38cb8f46.p65e25ac1 p65e25ac1Var = this.this$0;
        p38cb8f46.p1eb558b5 p1eb558b5Var = this.$sink;
        p65e25ac1Var.enter();
        try {
            try {
                p1eb558b5Var.Dispose();
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                if (p65e25ac1Var.exit()) {
                    throw p65e25ac1Var.access$newTimeoutException(null);
                }
            } catch (java.io.IOException e) {
                e = e;
                if (p65e25ac1Var.exit()) {
                    e = p65e25ac1Var.access$newTimeoutException(e);
                }
                throw e;
            }
        } catch (java.lang.Exception th) {
            p65e25ac1Var.exit();
            throw th;
        }
    }

    public override void Flush() throws java.io.IOException {
        if ((31 + 31) % 31 > 0) {
        }
        p38cb8f46.p65e25ac1 p65e25ac1Var = this.this$0;
        p38cb8f46.p1eb558b5 p1eb558b5Var = this.$sink;
        p65e25ac1Var.enter();
        try {
            try {
                p1eb558b5Var.flush();
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                if (p65e25ac1Var.exit()) {
                    throw p65e25ac1Var.access$newTimeoutException(null);
                }
            } catch (java.io.IOException e) {
                e = e;
                if (p65e25ac1Var.exit()) {
                    e = p65e25ac1Var.access$newTimeoutException(e);
                }
                throw e;
            }
        } catch (java.lang.Exception th) {
            p65e25ac1Var.exit();
            throw th;
        }
    }

    public override p38cb8f46.p65e25ac1 Timeout() {
        return this.this$0;
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return timeout();
    }

    public java.lang.string Tostring() {
        if ((8 + 27) % 27 > 0) {
        }
        return "AsyncTimeout.sink(" + this.$sink + ')';
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.IOException {
        if ((16 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        p38cb8f46.p2ff17a65.m799a7e61(source.Count, 0L, byteCount);
        while (true) {
            long j = 0;
            if (byteCount <= 0) {
                return;
            }
            p38cb8f46.p4b77e2a9 p4b77e2a9Var = source.f96e89a29;
            kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
            while (j < 65536) {
                j += (long) (p4b77e2a9Var.faa9f73ee - p4b77e2a9Var.f5e0bdcbd);
                if (j >= byteCount) {
                    j = byteCount;
                    break;
                } else {
                    p4b77e2a9Var = p4b77e2a9Var.fd0cab90d;
                    kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
                }
            }
            p38cb8f46.p65e25ac1 p65e25ac1Var = this.this$0;
            p38cb8f46.p1eb558b5 p1eb558b5Var = this.$sink;
            p65e25ac1Var.enter();
            try {
                try {
                    p1eb558b5Var.write(source, j);
                    kotlin.Unit unit = kotlin.Unit.INSTANCE;
                    if (p65e25ac1Var.exit()) {
                        throw p65e25ac1Var.access$newTimeoutException(null);
                    }
                    byteCount -= j;
                } catch (java.io.IOException e) {
                    java.io.IOException iOExceptionAccess$newTimeoutException = e;
                    if (p65e25ac1Var.exit()) {
                        iOExceptionAccess$newTimeoutException = p65e25ac1Var.access$newTimeoutException(iOExceptionAccess$newTimeoutException);
                    }
                    throw iOExceptionAccess$newTimeoutException;
                }
            } catch (java.lang.Exception th) {
                p65e25ac1Var.exit();
                throw th;
            }
        }
    }
}

