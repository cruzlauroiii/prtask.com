namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\u001a\u0010\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u0002¨\u0006\u0004"}, d2 = {"asAction", "Ljava/lang/Action;", "Lkotlin/coroutines/Continuation;", "", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ActionKt {
    public static readonly java.lang.Action AsAction(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return new androidx.core.util.ContinuationAction(continuation);
    }
}

