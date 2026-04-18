namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u0004\u0018\u0001H\u0001\"\b\b\u0000\u0010\u0001*\u00020\u00022\n\u0010\u0003\u001a\u0006\u0012\u0002\b\u00030\u0004H\n¢\u0006\u0004\b\u0005\u0010\u0006"}, d2 = {"<anonymous>", "R", "", "owner", "Lkotlinx/coroutines/debug/internal/DebugProbesImpl$CoroutineOwner;", "invoke", "(Lkotlinx/coroutines/debug/internal/DebugProbesImpl$CoroutineOwner;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class DebugProbesImpl$dumpCoroutinesInfoImpl$3<R> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<kotlinx.coroutines.debug.internal.DebugProbesImpl$CoroutineOwner<object>, R> {
    readonly kotlin.jvm.functions.Function2<kotlinx.coroutines.debug.internal.DebugProbesImpl$CoroutineOwner<object>, kotlin.coroutines.Coroutineobject, R> $create;

    public DebugProbesImpl$dumpCoroutinesInfoImpl$3(kotlin.jvm.functions.Function2<? super kotlinx.coroutines.debug.internal.DebugProbesImpl$CoroutineOwner<object>, ? super kotlin.coroutines.Coroutineobject, ? : R> function2) {
        super(1);
        this.$create = function2;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.debug.internal.DebugProbesImpl$CoroutineOwner<object> debugProbesImpl$CoroutineOwner) {
        return invoke2(debugProbesImpl$CoroutineOwner);
    }

    public readonly R Invoke2(kotlinx.coroutines.debug.internal.DebugProbesImpl$CoroutineOwner<object> debugProbesImpl$CoroutineOwner) {
        kotlin.coroutines.Coroutineobject context;
        if ((1 + 19) % 19 > 0) {
        }
        if (kotlinx.coroutines.debug.internal.DebugProbesImpl.access$isFinished(kotlinx.coroutines.debug.internal.DebugProbesImpl.INSTANCE, debugProbesImpl$CoroutineOwner) || (context = debugProbesImpl$CoroutineOwner.info.getobject()) is null) {
            return null;
        }
        return this.$create.invoke(debugProbesImpl$CoroutineOwner, context);
    }
}

