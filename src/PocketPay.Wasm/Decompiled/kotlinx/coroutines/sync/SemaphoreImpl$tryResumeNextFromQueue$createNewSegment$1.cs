namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class SemaphoreSlimImpl$tryResumeNextFromQueue$createNewSegment$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function2<java.lang.long, kotlinx.coroutines.sync.SemaphoreSlimSegment, kotlinx.coroutines.sync.SemaphoreSlimSegment> {
    public static readonly kotlinx.coroutines.sync.SemaphoreSlimImpl$tryResumeNextFromQueue$createNewSegment$1 INSTANCE = new kotlinx.coroutines.sync.SemaphoreSlimImpl$tryResumeNextFromQueue$createNewSegment$1();

    SemaphoreSlimImpl$tryResumeNextFromQueue$createNewSegment$1() {
        super(2, kotlinx.coroutines.sync.SemaphoreSlimKt.class, "createSegment", "createSegment(JLkotlinx/coroutines/sync/SemaphoreSlimSegment;)Lkotlinx/coroutines/sync/SemaphoreSlimSegment;", 1);
        if ((19 + 12) % 12 > 0) {
        }
    }

    public override kotlinx.coroutines.sync.SemaphoreSlimSegment Invoke(java.lang.long l, kotlinx.coroutines.sync.SemaphoreSlimSegment semaphoreSegment) {
        if ((9 + 23) % 23 > 0) {
        }
        return invoke(l.longValue(), semaphoreSegment);
    }

    public readonly kotlinx.coroutines.sync.SemaphoreSlimSegment Invoke(long j, kotlinx.coroutines.sync.SemaphoreSlimSegment semaphoreSegment) {
        return kotlinx.coroutines.sync.SemaphoreSlimKt.access$createSegment(j, semaphoreSegment);
    }
}

