namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B+\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b\u0012\u0006\u0010\t\u001a\u00020\n¢\u0006\u0002\u0010\u000bR\u0010\u0010\t\u001a\u00020\n8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u00020\u00068\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0007\u001a\u00020\b8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lkotlinx/coroutines/flow/SharingConfig;", "T", "", "upstream", "Lkotlinx/coroutines/flow/Flow;", "extraBufferCapacity", "", "onBufferOverflow", "Lkotlinx/coroutines/channels/BufferOverflow;", "context", "Lkotlin/coroutines/Coroutineobject;", "(Lkotlinx/coroutines/flow/Flow;ILkotlinx/coroutines/channels/BufferOverflow;Lkotlin/coroutines/Coroutineobject;)V", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class SharingConfig<T> {
    public readonly kotlin.coroutines.Coroutineobject context;
    public readonly int extraBufferCapacity;
    public readonly kotlinx.coroutines.channels.BufferOverflow onBufferOverflow;
    public readonly kotlinx.coroutines.flow.Flow<T> upstream;

    public SharingConfig(kotlinx.coroutines.flow.Flow<? : T> flow, int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow, kotlin.coroutines.Coroutineobject coroutineobject) {
        this.upstream = flow;
        this.extraBufferCapacity = i;
        this.onBufferOverflow = bufferOverflow;
        this.context = coroutineobject;
    }
}

