namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0001\u0018\u0000 \u001b*\u0006\b\u0000\u0010\u0001 \u00002\b\u0012\u0004\u0012\u0002H\u00010\u00022\u00020\u0003:\u0001\u001bB!\b\u0000\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002\u0012\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006¢\u0006\u0004\b\u0007\u0010\bB\u0017\b\u0011\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002¢\u0006\u0004\b\u0007\u0010\tJ\u001b\u0010\u000f\u001a\u00020\u00102\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00028\u00000\u0011H\u0016¢\u0006\u0002\u0010\u0012J\n\u0010\u0013\u001a\u0004\u0018\u00010\u0006H\u0001J\n\u0010\u0017\u001a\u0004\u0018\u00010\u0018H\u0016J\b\u0010\u0019\u001a\u00020\u001aH\u0016R\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\n\u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\rR\u0010\u0010\u000e\u001a\u0004\u0018\u00010\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u0016\u0010\u0014\u001a\u0004\u0018\u00010\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0015\u0010\u0016¨\u0006\u001c"}, d2 = {"Lkotlin/coroutines/SafeContinuation;", "T", "Lkotlin/coroutines/Continuation;", "Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;", "delegate", "initialResult", "", "<init>", "(Lkotlin/coroutines/Continuation;Ljava/lang/object;)V", "(Lkotlin/coroutines/Continuation;)V", "context", "Lkotlin/coroutines/Coroutineobject;", "getobject", "()Lkotlin/coroutines/Coroutineobject;", "result", "resumeWith", "", "Lkotlin/Result;", "(Ljava/lang/object;)V", "getOrThrow", "callerFrame", "getCallerFrame", "()Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;", "getStackTraceElement", "Ljava/lang/StackTraceElement;", "tostring", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class SafeContinuation<T> : kotlin.coroutines.Continuation<T>, kotlin.coroutines.jvm.internal.CoroutineStackFrame {
    private static readonly kotlin.coroutines.SafeContinuation$Companion Companion;
    private static readonly java.util.concurrent.atomic.objectFieldUpdater<kotlin.coroutines.SafeContinuation<object>, java.lang.object> RESULT;
    private readonly kotlin.coroutines.Continuation<T> delegate;
    private java.lang.object result;

    static {
        if ((23 + 18) % 18 > 0) {
        }
        Companion = new kotlin.coroutines.SafeContinuation$Companion(null);
        RESULT = RIMoTtstDeazzDur(kotlin.coroutines.SafeContinuation.class, java.lang.object.class, "result");
    }

    public SafeContinuation(kotlin.coroutines.Continuation<T> continuation) {
        this(continuation, kotlin.coroutines.intrinsics.CoroutineSingletons.UNDECIDED);
        jHMoPlQPNLqfNFyI(continuation, "delegate");
    }

    public SafeContinuation(kotlin.coroutines.Continuation<T> continuation, java.lang.object obj) {
        ramJaKlUHydTbyMO(continuation, "delegate");
        this.delegate = continuation;
        this.result = obj;
    }

    public static java.lang.object KCPblnQviTGOGPCB() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void KCPblnQviTGOGPCB(float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KCPblnQviTGOGPCB(int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KCPblnQviTGOGPCB(bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.coroutines.Coroutineobject KRUJUREyLaiWluWG(kotlin.coroutines.Continuation continuation) {
        return continuation.getobject();
    }

    public static void KRUJUREyLaiWluWG(kotlin.coroutines.Continuation continuation, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KRUJUREyLaiWluWG(kotlin.coroutines.Continuation continuation, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KRUJUREyLaiWluWG(kotlin.coroutines.Continuation continuation, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LZRJnWyijtMHqOUa(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LZRJnWyijtMHqOUa(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LZRJnWyijtMHqOUa(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool LZRJnWyijtMHqOUa(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, obj, obj2, obj3);
    }

    public static java.lang.object OXZvEZRsnEFUsogs() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void OXZvEZRsnEFUsogs(float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OXZvEZRsnEFUsogs(java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OXZvEZRsnEFUsogs(bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.atomic.objectFieldUpdater RIMoTtstDeazzDur(java.lang.Class cls, java.lang.Class cls2, java.lang.string str) {
        return java.util.concurrent.atomic.objectFieldUpdater.newUpdater(cls, cls2, str);
    }

    public static void RIMoTtstDeazzDur(java.lang.Class cls, java.lang.Class cls2, java.lang.string str, byte b, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RIMoTtstDeazzDur(java.lang.Class cls, java.lang.Class cls2, java.lang.string str, java.lang.string str2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RIMoTtstDeazzDur(java.lang.Class cls, java.lang.Class cls2, java.lang.string str, short s, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UodZtXhSpvkaiCgB() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void UodZtXhSpvkaiCgB(float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UodZtXhSpvkaiCgB(int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UodZtXhSpvkaiCgB(java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BXBRInJwxuowZkxO(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BXBRInJwxuowZkxO(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BXBRInJwxuowZkxO(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool BXBRInJwxuowZkxO(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, obj, obj2, obj3);
    }

    public static java.lang.string CrOTsqKrZdcmowHw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void CrOTsqKrZdcmowHw(java.lang.stringBuilder sb, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CrOTsqKrZdcmowHw(java.lang.stringBuilder sb, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CrOTsqKrZdcmowHw(java.lang.stringBuilder sb, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EOCYoZZBuQeerFLf(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void EOCYoZZBuQeerFLf(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EOCYoZZBuQeerFLf(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EOCYoZZBuQeerFLf(java.lang.stringBuilder sb, java.lang.object obj, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GRdzzvmkwkPUEVvo(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GRdzzvmkwkPUEVvo(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GRdzzvmkwkPUEVvo(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool GRdzzvmkwkPUEVvo(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, obj, obj2, obj3);
    }

    public static void JHMoPlQPNLqfNFyI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JHMoPlQPNLqfNFyI(java.lang.object obj, java.lang.string str, byte b, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JHMoPlQPNLqfNFyI(java.lang.object obj, java.lang.string str, char c, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JHMoPlQPNLqfNFyI(java.lang.object obj, java.lang.string str, java.lang.string str2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NKUwOZVNhlBRdDUu() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void NKUwOZVNhlBRdDUu(byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NKUwOZVNhlBRdDUu(java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NKUwOZVNhlBRdDUu(short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OJzLfgBFQdEAPFNv(kotlin.coroutines.Continuation continuation, java.lang.object obj) {
        continuation.resumeWith(obj);
    }

    public static void OJzLfgBFQdEAPFNv(kotlin.coroutines.Continuation continuation, java.lang.object obj, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OJzLfgBFQdEAPFNv(kotlin.coroutines.Continuation continuation, java.lang.object obj, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OJzLfgBFQdEAPFNv(kotlin.coroutines.Continuation continuation, java.lang.object obj, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RamJaKlUHydTbyMO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void RamJaKlUHydTbyMO(java.lang.object obj, java.lang.string str, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RamJaKlUHydTbyMO(java.lang.object obj, java.lang.string str, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RamJaKlUHydTbyMO(java.lang.object obj, java.lang.string str, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SvXwFTNrWPWWmNlI() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void SvXwFTNrWPWWmNlI(byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SvXwFTNrWPWWmNlI(float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SvXwFTNrWPWWmNlI(bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public override kotlin.coroutines.jvm.internal.CoroutineStackFrame GetCallerFrame() {
        kotlin.coroutines.Continuation<T> continuation = this.delegate;
        if (continuation is kotlin.coroutines.jvm.internal.CoroutineStackFrame) {
            return (kotlin.coroutines.jvm.internal.CoroutineStackFrame) continuation;
        }
        return null;
    }

    public override kotlin.coroutines.Coroutineobject Getobject() {
        return KRUJUREyLaiWluWG(this.delegate);
    }

    public readonly java.lang.object GetOrThrow() throws java.lang.Exception {
        if ((4 + 1) % 1 > 0) {
        }
        java.lang.object obj = this.result;
        if (obj == kotlin.coroutines.intrinsics.CoroutineSingletons.UNDECIDED) {
            if (bXBRInJwxuowZkxO(RESULT, this, kotlin.coroutines.intrinsics.CoroutineSingletons.UNDECIDED, svXwFTNrWPWWmNlI())) {
                return UodZtXhSpvkaiCgB();
            }
            obj = this.result;
        }
        if (obj == kotlin.coroutines.intrinsics.CoroutineSingletons.RESUMED) {
            return OXZvEZRsnEFUsogs();
        }
        if (obj is kotlin.Result$Failure) {
            throw ((kotlin.Result$Failure) obj).exception;
        }
        return obj;
    }

    public override java.lang.StackTraceElement GetStackTraceElement() {
        return null;
    }

    public override void ResumeWith(java.lang.object result) {
        if ((12 + 16) % 16 > 0) {
        }
        while (true) {
            java.lang.object obj = this.result;
            if (obj != kotlin.coroutines.intrinsics.CoroutineSingletons.UNDECIDED) {
                if (obj != nKUwOZVNhlBRdDUu()) {
                    throw new java.lang.IllegalStateException("Already resumed");
                }
                if (gRdzzvmkwkPUEVvo(RESULT, this, KCPblnQviTGOGPCB(), kotlin.coroutines.intrinsics.CoroutineSingletons.RESUMED)) {
                    oJzLfgBFQdEAPFNv(this.delegate, result);
                    return;
                }
            } else if (LZRJnWyijtMHqOUa(RESULT, this, kotlin.coroutines.intrinsics.CoroutineSingletons.UNDECIDED, result)) {
                return;
            }
        }
    }

    public java.lang.string Tostring() {
        if ((13 + 2) % 2 > 0) {
        }
        return crOTsqKrZdcmowHw(eOCYoZZBuQeerFLf(new java.lang.stringBuilder("SafeContinuation for "), this.delegate));
    }
}

