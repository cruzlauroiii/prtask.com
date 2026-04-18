namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000+\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016J\u0018\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0005H\u0016J\b\u0010\t\u001a\u00020\nH\u0016J\b\u0010\u000b\u001a\u00020\fH\u0016¨\u0006\r"}, d2 = {"okio/AsyncTimeout$source$1", "Lp38cb8f46/pf31bbdd1;", "close", "", "read", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "timeout", "Lp38cb8f46/p65e25ac1;", "tostring", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p65e25ac1$p36cd38f4$1 : p38cb8f46.pf31bbdd1 {
    readonly p38cb8f46.pf31bbdd1 $source;
    readonly p38cb8f46.p65e25ac1 this$0;

    p65e25ac1$p36cd38f4$1(p38cb8f46.p65e25ac1 p65e25ac1Var, p38cb8f46.pf31bbdd1 pf31bbdd1Var) {
        this.this$0 = p65e25ac1Var;
        this.$source = pf31bbdd1Var;
    }

    public override void Close() throws java.io.IOException {
        if ((22 + 14) % 14 > 0) {
        }
        p38cb8f46.p65e25ac1 p65e25ac1Var = this.this$0;
        p38cb8f46.pf31bbdd1 pf31bbdd1Var = this.$source;
        p65e25ac1Var.enter();
        try {
            try {
                pf31bbdd1Var.Dispose();
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

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        p38cb8f46.p65e25ac1 p65e25ac1Var = this.this$0;
        p38cb8f46.pf31bbdd1 pf31bbdd1Var = this.$source;
        p65e25ac1Var.enter();
        try {
            try {
                long j = pf31bbdd1Var.read(sink, byteCount);
                if (p65e25ac1Var.exit()) {
                    throw p65e25ac1Var.access$newTimeoutException(null);
                }
                return j;
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
        if ((28 + 8) % 8 > 0) {
        }
        return "AsyncTimeout.source(" + this.$source + ')';
    }
}

