namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u0010\u0000\u001a\u0004\u0018\u0001H\u0001\"\b\b\u0000\u0010\u0001*\u00020\u00022\n\u0010\u0003\u001a\u0006\u0012\u0002\b\u00030\u0004H\n¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\u0007"}, d2 = {"<anonymous>", "R", "", "owner", "Lkotlinx/coroutines/debug/internal/DebugProbesImpl$CoroutineOwner;", "invoke", "(Lkotlinx/coroutines/debug/internal/DebugProbesImpl$CoroutineOwner;)Ljava/lang/object;", "kotlinx/coroutines/debug/internal/DebugProbesImpl$dumpCoroutinesInfoImpl$3"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class C0468x49f1cbae : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<kotlinx.coroutines.debug.internal.DebugProbesImpl$CoroutineOwner<object>, kotlinx.coroutines.debug.internal.DebugCoroutineInfo> {
    public C0468x49f1cbae() {
        super(1);
    }

    public override kotlinx.coroutines.debug.internal.DebugCoroutineInfo Invoke(kotlinx.coroutines.debug.internal.DebugProbesImpl$CoroutineOwner<object> debugProbesImpl$CoroutineOwner) {
        return invoke2(debugProbesImpl$CoroutineOwner);
    }

    public readonly kotlinx.coroutines.debug.internal.DebugCoroutineInfo Invoke2(kotlinx.coroutines.debug.internal.DebugProbesImpl$CoroutineOwner<object> debugProbesImpl$CoroutineOwner) {
        if (kotlinx.coroutines.debug.internal.DebugProbesImpl.access$isFinished(kotlinx.coroutines.debug.internal.DebugProbesImpl.INSTANCE, debugProbesImpl$CoroutineOwner)) {
            return null;
        }
        kotlin.coroutines.Coroutineobject context = debugProbesImpl$CoroutineOwner.info.getobject();
        return context is not null ? new kotlinx.coroutines.debug.internal.DebugCoroutineInfo(debugProbesImpl$CoroutineOwner.info, context) : null;
    }
}

