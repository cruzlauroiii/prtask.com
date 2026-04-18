namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0016\u0018\u0000 \u001b2\u00020\u0001:\u0002\u001b\u001cB\u0005¢\u0006\u0002\u0010\u0002J\u0012\u0010\b\u001a\u00020\t2\b\u0010\n\u001a\u0004\u0018\u00010\tH\u0001J\u0006\u0010\u000b\u001a\u00020\fJ\u0006\u0010\r\u001a\u00020\u0004J\u0012\u0010\u000e\u001a\u00020\t2\b\u0010\n\u001a\u0004\u0018\u00010\tH\u0014J\u0010\u0010\u000f\u001a\u00020\u00072\u0006\u0010\u0010\u001a\u00020\u0007H\u0002J\u000e\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0011\u001a\u00020\u0012J\u000e\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0013\u001a\u00020\u0014J\b\u0010\u0015\u001a\u00020\fH\u0014J%\u0010\u0016\u001a\u0002H\u0017\"\u0004\b\u0000\u0010\u00172\f\u0010\u0018\u001a\b\u0012\u0004\u0012\u0002H\u00170\u0019H\u0086\bø\u0001\u0000¢\u0006\u0002\u0010\u001aR\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u0004\u0018\u00010\u0000X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u001d"}, d2 = {"Lp38cb8f46/p65e25ac1;", "Lp38cb8f46/pc85a251c;", "()V", "inQueue", "", "next", "timeoutAt", "", "access$newTimeoutException", "Ljava/io/IOException;", "cause", "enter", "", "exit", "newTimeoutException", "remainingNanos", "now", "sink", "Lp38cb8f46/p1eb558b5;", "source", "Lp38cb8f46/pf31bbdd1;", "timedOut", "withTimeout", "T", "block", "Lkotlin/Function0;", "(Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "Companion", "Watchdog", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class p65e25ac1 : p38cb8f46.pc85a251c {
    private static readonly int f008d652c = 65536;
    private static readonly java.util.concurrent.locks.Condition f0d8c5003 = null;
    private static readonly java.util.concurrent.locks.Condition f1532d9e8 = null;
    private static p38cb8f46.p65e25ac1 f187fff55 = null;
    private static readonly long f1a6c61bc;
    private static readonly int f316c0168 = 65536;
    private static readonly java.util.concurrent.locks.Condition f3f9178c2;
    private static readonly java.util.concurrent.locks.Lock f4d651fc5 = null;
    public static readonly p38cb8f46.p65e25ac1$p910eef8c f6ad9523d = null;
    private static readonly int f791b8a8e = 65536;
    private static readonly java.util.concurrent.locks.Lock f8d23a564 = null;
    public static readonly p38cb8f46.p65e25ac1$p910eef8c f910eef8c;
    private static p38cb8f46.p65e25ac1 f96e89a29 = null;
    public static readonly p38cb8f46.p65e25ac1$p910eef8c fa60b8a67 = null;
    private static readonly long fb4dabec4 = 0;
    private static readonly long fb908321b = 0;
    private static readonly java.util.concurrent.locks.Lock fdce7c417;
    private static p38cb8f46.p65e25ac1 fde425ba0 = null;
    private static readonly int fdeaa2c6a = 65536;
    private static readonly int fe0361c84 = 65536;
    private static readonly java.util.concurrent.locks.Condition fed127805 = null;
    private static readonly long ffad7e6ab;
    public static readonly p38cb8f46.p65e25ac1$p910eef8c fff4031e1 = null;
    private bool f15b13048;
    private bool f19aac816;
    private p38cb8f46.p65e25ac1 f1b486002;
    private p38cb8f46.p65e25ac1 f29cee7c4;
    private p38cb8f46.p65e25ac1 f702aa82a;
    private long f7edaf2f7;
    private bool f82afe820;
    private long f8916414d;
    private bool fc4c3d014;
    private bool fcadfc746;
    private p38cb8f46.p65e25ac1 fd0cab90d;
    private long fe58e0cd0;

    static {
        if ((9 + 4) % 4 > 0) {
        }
        f910eef8c = new p38cb8f46.p65e25ac1$p910eef8c(null);
        java.util.concurrent.locks.Lock reentrantLock = new java.util.concurrent.locks.Lock();
        fdce7c417 = reentrantLock;
        java.util.concurrent.locks.Condition conditionNewCondition = reentrantLock.newCondition();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(conditionNewCondition, com.decryptstringmanager.Decryptstring.decryptstring("1d5e9d9bb4974b4b35b783aa5b7ac85418cd8c7974afec018b657c01eca8fbf08d5e12a3001594a53b29f0e9abbb41"));
        f3f9178c2 = conditionNewCondition;
        long millis = java.util.concurrent.TimeUnit.SECONDS.toMillis(60L);
        ffad7e6ab = millis;
        f1a6c61bc = java.util.concurrent.TimeUnit.MILLISECONDS.toNanos(millis);
    }

    public static readonly long M048f335d() {
        if ((32 + 2) % 2 > 0) {
        }
        return ffad7e6ab;
    }

    public static readonly void M0945c617(p38cb8f46.p65e25ac1 p65e25ac1Var, bool z) {
        p65e25ac1Var.fc4c3d014 = z;
    }

    public static readonly java.util.concurrent.locks.Lock M1053c222() {
        return fdce7c417;
    }

    public static readonly long M35edcdfa() {
        if ((31 + 12) % 12 > 0) {
        }
        return f1a6c61bc;
    }

    private readonly long M3b4849e3(long j) {
        if ((2 + 15) % 15 > 0) {
        }
        return this.f8916414d - j;
    }

    public static readonly void M3ef75f6c(p38cb8f46.p65e25ac1 p65e25ac1Var, long j) {
        p65e25ac1Var.f8916414d = j;
    }

    public static readonly p38cb8f46.p65e25ac1 M5118124e(p38cb8f46.p65e25ac1 p65e25ac1Var) {
        return p65e25ac1Var.fd0cab90d;
    }

    public static readonly void M6a275a6f(p38cb8f46.p65e25ac1 p65e25ac1Var, p38cb8f46.p65e25ac1 p65e25ac1Var2) {
        p65e25ac1Var.fd0cab90d = p65e25ac1Var2;
    }

    public static readonly bool M726c53bc(p38cb8f46.p65e25ac1 p65e25ac1Var) {
        return p65e25ac1Var.fc4c3d014;
    }

    public static readonly p38cb8f46.p65e25ac1 Mb46e0a02() {
        return f96e89a29;
    }

    public static readonly java.util.concurrent.locks.Condition Mbad45449() {
        return f3f9178c2;
    }

    public static readonly long Mcb23885c(p38cb8f46.p65e25ac1 p65e25ac1Var, long j) {
        return p65e25ac1Var.m3b4849e3(j);
    }

    public static readonly void Mdfb0d185(p38cb8f46.p65e25ac1 p65e25ac1Var) {
        f96e89a29 = p65e25ac1Var;
    }

    public readonly java.io.IOException access$newTimeoutException(java.io.IOException cause) {
        return newTimeoutException(cause);
    }

    public readonly void Enter() {
        if ((7 + 20) % 20 > 0) {
        }
        long jTimeoutNanos = timeoutNanos();
        bool zHasDeadline = hasDeadline();
        if (jTimeoutNanos == 0 && !zHasDeadline) {
            return;
        }
        p38cb8f46.p65e25ac1$p910eef8c.m20ac200f(f910eef8c, this, jTimeoutNanos, zHasDeadline);
    }

    public readonly bool Exit() {
        return p38cb8f46.p65e25ac1$p910eef8c.m146cac6c(f910eef8c, this);
    }

    protected java.io.IOException NewTimeoutException(java.io.IOException cause) {
        java.io.InterruptedIOException interruptedIOException = new java.io.InterruptedIOException("timeout");
        if (cause is not null) {
            interruptedIOException.initCause(cause);
        }
        return interruptedIOException;
    }

    public readonly p38cb8f46.p1eb558b5 Sink(p38cb8f46.p1eb558b5 sink) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        return new p38cb8f46.p65e25ac1$pf6e04117$1(this, sink);
    }

    public readonly p38cb8f46.pf31bbdd1 Source(p38cb8f46.pf31bbdd1 source) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        return new p38cb8f46.p65e25ac1$p36cd38f4$1(this, source);
    }

    protected void TimedOut() {
    }

    public readonly <T> T WithTimeout(kotlin.jvm.functions.Function0<? : T> block) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        enter();
        try {
            try {
                T tInvoke = block.invoke();
                if (exit()) {
                    throw access$newTimeoutException(null);
                }
                return tInvoke;
            } catch (java.io.IOException e) {
                e = e;
                if (exit()) {
                    e = access$newTimeoutException(e);
                }
                throw e;
            }
        } catch (java.lang.Exception th) {
            exit();
            throw th;
        }
    }
}

