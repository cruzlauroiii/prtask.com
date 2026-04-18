namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u001c\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003¨\u0006\u0004"}, d2 = {"consumeAsFlow", "Lkotlinx/coroutines/flow/Flow;", "T", "Ljava/util/stream/Stream;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class StreamKt {
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> ConsumeAsFlow(java.util.stream.Stream<T> stream) {
        return new kotlinx.coroutines.stream.StreamFlow(stream);
    }
}

