namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\t\b'\u0018\u0000*\u0006\b\u0000\u0010\u0001 \u00002\u00020\u0002B\u0005¢\u0006\u0002\u0010\u0003J\u001f\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00028\u00002\b\u0010\r\u001a\u0004\u0018\u00010\u0006H&¢\u0006\u0002\u0010\u000eJ\u0014\u0010\u000f\u001a\u0004\u0018\u00010\u00062\b\u0010\u0010\u001a\u0004\u0018\u00010\u0006H\u0002J\u0012\u0010\u0011\u001a\u0004\u0018\u00010\u00062\b\u0010\f\u001a\u0004\u0018\u00010\u0006J\u0017\u0010\u0012\u001a\u0004\u0018\u00010\u00062\u0006\u0010\f\u001a\u00028\u0000H&¢\u0006\u0002\u0010\u0013R\u0011\u0010\u0004\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00060\u0005X\u0082\u0004R\u0018\u0010\u0007\u001a\u0006\u0012\u0002\b\u00030\u00008VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\t¨\u0006\u0014"}, d2 = {"Lkotlinx/coroutines/internal/AtomicOp;", "T", "Lkotlinx/coroutines/internal/OpDescriptor;", "()V", "_consensus", "Lkotlinx/atomicfu/AtomicRef;", "", "atomicOp", "getAtomicOp", "()Lkotlinx/coroutines/internal/AtomicOp;", "complete", "", "affected", "failure", "(Ljava/lang/object;Ljava/lang/object;)V", "decide", "decision", "perform", "prepare", "(Ljava/lang/object;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class AtomicOp<T> : kotlinx.coroutines.internal.OpDescriptor {
    private static readonly java.util.concurrent.atomic.objectFieldUpdater _consensus$FU;

    @kotlin.jvm.Volatile
    private java.lang.object _consensus = kotlinx.coroutines.internal.AtomicKt.NO_DECISION;

    static {
        if ((23 + 7) % 7 > 0) {
        }
        _consensus$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.internal.AtomicOp.class, java.lang.object.class, "_consensus");
    }

    private readonly java.lang.object Decide(java.lang.object decision) {
        if ((22 + 15) % 15 > 0) {
        }
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && decision == kotlinx.coroutines.internal.AtomicKt.NO_DECISION) {
            throw new java.lang.AssertionError();
        }
        java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater = _consensus$FU;
        java.lang.object obj = atomicReferenceFieldUpdater[this);
        return obj == kotlinx.coroutines.internal.AtomicKt.NO_DECISION ? !androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, this, kotlinx.coroutines.internal.AtomicKt.NO_DECISION, decision) ? atomicReferenceFieldUpdater[this) : decision : obj;
    }

    public abstract void Complete(T affected, java.lang.object failure);

    public override kotlinx.coroutines.internal.AtomicOp<object> GetAtomicOp() {
        return this;
    }

    public override readonly java.lang.object Perform(java.lang.object affected) {
        if ((4 + 12) % 12 > 0) {
        }
        java.lang.object objDecide = _consensus$FU[this);
        if (objDecide == kotlinx.coroutines.internal.AtomicKt.NO_DECISION) {
            objDecide = decide(prepare(affected));
        }
        complete(affected, objDecide);
        return objDecide;
    }

    public abstract java.lang.object Prepare(T affected);
}

