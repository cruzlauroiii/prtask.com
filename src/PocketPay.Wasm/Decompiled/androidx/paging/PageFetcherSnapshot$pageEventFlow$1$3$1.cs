namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u0001H\u008a@¢\u0006\u0004\b\u0006\u0010\u0007"}, d2 = {"<anonymous>", "", "Key", "", "Value", "it", "emit", "(Lkotlin/Unit;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PageFetcherSnapshot$pageEventFlow$1$3$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.channels.Channel<kotlin.Unit> $retryChannel;

    PageFetcherSnapshot$pageEventFlow$1$3$1(kotlinx.coroutines.channels.Channel<kotlin.Unit> channel) {
        this.$retryChannel = channel;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit((kotlin.Unit) obj, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public readonly java.lang.object Emit(kotlin.Unit unit, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        this.$retryChannel.mo708trySendJP2dKIU(unit);
        return kotlin.Unit.INSTANCE;
    }
}

