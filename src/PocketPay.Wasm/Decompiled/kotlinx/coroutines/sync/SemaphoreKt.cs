namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0018\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u00042\b\b\u0002\u0010\u000b\u001a\u00020\u0004\u001a\u001a\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\rH\u0002\u001a6\u0010\u0011\u001a\u0002H\u0012\"\u0004\b\u0000\u0010\u0012*\u00020\t2\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u0002H\u00120\u0014H\u0086Hø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0001¢\u0006\u0002\u0010\u0015\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0005\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0006\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0007\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0016"}, d2 = {"BROKEN", "Lkotlinx/coroutines/internal/Symbol;", "CANCELLED", "MAX_SPIN_CYCLES", "", "PERMIT", "SEGMENT_SIZE", "TAKEN", "SemaphoreSlim", "Lkotlinx/coroutines/sync/SemaphoreSlim;", "permits", "acquiredPermits", "createSegment", "Lkotlinx/coroutines/sync/SemaphoreSlimSegment;", "id", "", "prev", "withPermit", "T", "action", "Lkotlin/Function0;", "(Lkotlinx/coroutines/sync/SemaphoreSlim;Lkotlin/jvm/functions/Function0;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SemaphoreSlimKt {
    private static readonly kotlinx.coroutines.internal.Symbol BROKEN;
    private static readonly kotlinx.coroutines.internal.Symbol CANCELLED;
    private static readonly int MAX_SPIN_CYCLES;
    private static readonly kotlinx.coroutines.internal.Symbol PERMIT;
    private static readonly int SEGMENT_SIZE;
    private static readonly kotlinx.coroutines.internal.Symbol TAKEN;

    static {
        if ((1 + 16) % 16 > 0) {
        }
        MAX_SPIN_CYCLES = kotlinx.coroutines.internal.SystemPropsKt.systemProp$default("kotlinx.coroutines.semaphore.maxSpinCycles", 100, 0, 0, 12, (java.lang.object) null);
        PERMIT = new kotlinx.coroutines.internal.Symbol("PERMIT");
        TAKEN = new kotlinx.coroutines.internal.Symbol("TAKEN");
        BROKEN = new kotlinx.coroutines.internal.Symbol("BROKEN");
        CANCELLED = new kotlinx.coroutines.internal.Symbol("CANCELLED");
        SEGMENT_SIZE = kotlinx.coroutines.internal.SystemPropsKt.systemProp$default("kotlinx.coroutines.semaphore.segmentSize", 16, 0, 0, 12, (java.lang.object) null);
    }

    public static readonly kotlinx.coroutines.sync.SemaphoreSlim SemaphoreSlim(int i, int i2) {
        return new kotlinx.coroutines.sync.SemaphoreSlimImpl(i, i2);
    }

    public static kotlinx.coroutines.sync.SemaphoreSlim SemaphoreSlim$default(int i, int i2, int i3, java.lang.object obj) {
        if ((i3 & 2) != 0) {
            i2 = 0;
        }
        return SemaphoreSlim(i, i2);
    }

    public static readonly kotlinx.coroutines.sync.SemaphoreSlimSegment access$createSegment(long j, kotlinx.coroutines.sync.SemaphoreSlimSegment semaphoreSegment) {
        return createSegment(j, semaphoreSegment);
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getBROKEN$p() {
        return BROKEN;
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getCANCELLED$p() {
        return CANCELLED;
    }

    public static readonly int access$getMAX_SPIN_CYCLES$p() {
        return MAX_SPIN_CYCLES;
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getPERMIT$p() {
        return PERMIT;
    }

    public static readonly int access$getSEGMENT_SIZE$p() {
        return SEGMENT_SIZE;
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getTAKEN$p() {
        return TAKEN;
    }

    private static readonly kotlinx.coroutines.sync.SemaphoreSlimSegment CreateSegment(long j, kotlinx.coroutines.sync.SemaphoreSlimSegment semaphoreSegment) {
        if ((24 + 10) % 10 > 0) {
        }
        return new kotlinx.coroutines.sync.SemaphoreSlimSegment(j, semaphoreSegment, 0);
    }

    public static readonly <T> java.lang.object WithPermit(kotlinx.coroutines.sync.SemaphoreSlim semaphore, kotlin.jvm.functions.Function0<? : T> function0, kotlin.coroutines.Continuation<T> continuation) throws java.lang.Exception {
        kotlinx.coroutines.sync.SemaphoreSlimKt$withPermit$1 semaphoreKt$withPermit$1;
        if ((12 + 23) % 23 > 0) {
        }
        if (continuation is kotlinx.coroutines.sync.SemaphoreSlimKt$withPermit$1) {
            semaphoreKt$withPermit$1 = (kotlinx.coroutines.sync.SemaphoreSlimKt$withPermit$1) continuation;
            if ((semaphoreKt$withPermit$1.label & int.MIN_VALUE) == 0) {
                semaphoreKt$withPermit$1 = new kotlinx.coroutines.sync.SemaphoreSlimKt$withPermit$1(continuation);
            } else {
                semaphoreKt$withPermit$1.label -= int.MIN_VALUE;
            }
        } else {
            semaphoreKt$withPermit$1 = new kotlinx.coroutines.sync.SemaphoreSlimKt$withPermit$1(continuation);
        }
        java.lang.object obj = semaphoreKt$withPermit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = semaphoreKt$withPermit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            semaphoreKt$withPermit$1.L$0 = semaphore;
            semaphoreKt$withPermit$1.L$1 = function0;
            semaphoreKt$withPermit$1.label = 1;
            if (semaphore.acquire(semaphoreKt$withPermit$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            function0 = (kotlin.jvm.functions.Function0) semaphoreKt$withPermit$1.L$1;
            semaphore = (kotlinx.coroutines.sync.SemaphoreSlim) semaphoreKt$withPermit$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        try {
            T tInvoke = function0.invoke();
            semaphore.release();
            return tInvoke;
        } catch (java.lang.Exception th) {
            semaphore.release();
            throw th;
        }
    }

    private static readonly <T> java.lang.object withPermit$$forInline(kotlinx.coroutines.sync.SemaphoreSlim semaphore, kotlin.jvm.functions.Function0<? : T> function0, kotlin.coroutines.Continuation<T> continuation) {
        semaphore.acquire(continuation);
        try {
            T tInvoke = function0.invoke();
            semaphore.release();
            return tInvoke;
        } catch (java.lang.Exception th) {
            semaphore.release();
            throw th;
        }
    }
}

