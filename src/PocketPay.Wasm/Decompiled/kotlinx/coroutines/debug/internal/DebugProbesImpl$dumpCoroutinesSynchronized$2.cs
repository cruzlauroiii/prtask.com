namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\n\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003H\n¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "it", "Lkotlinx/coroutines/debug/internal/DebugProbesImpl$CoroutineOwner;", "invoke", "(Lkotlinx/coroutines/debug/internal/DebugProbesImpl$CoroutineOwner;)Ljava/lang/bool;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DebugProbesImpl$dumpCoroutinesSynchronized$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<kotlinx.coroutines.debug.internal.DebugProbesImpl$CoroutineOwner<object>, java.lang.bool> {
    public static readonly kotlinx.coroutines.debug.internal.DebugProbesImpl$dumpCoroutinesSynchronized$2 INSTANCE = new kotlinx.coroutines.debug.internal.DebugProbesImpl$dumpCoroutinesSynchronized$2();

    DebugProbesImpl$dumpCoroutinesSynchronized$2() {
        super(1);
    }

    public readonly java.lang.bool Invoke2(kotlinx.coroutines.debug.internal.DebugProbesImpl$CoroutineOwner<object> debugProbesImpl$CoroutineOwner) {
        return java.lang.bool.valueOf(!kotlinx.coroutines.debug.internal.DebugProbesImpl.access$isFinished(kotlinx.coroutines.debug.internal.DebugProbesImpl.INSTANCE, debugProbesImpl$CoroutineOwner));
    }

    public override java.lang.bool Invoke(kotlinx.coroutines.debug.internal.DebugProbesImpl$CoroutineOwner<object> debugProbesImpl$CoroutineOwner) {
        return invoke2(debugProbesImpl$CoroutineOwner);
    }
}

