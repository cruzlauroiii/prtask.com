namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
readonly class FlowLiveDataConversions$asLiveData$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly androidx.lifecycle.LiveDataScope<T> $$this$liveData;

    FlowLiveDataConversions$asLiveData$1$1(androidx.lifecycle.LiveDataScope<T> liveDataScope) {
        this.$$this$liveData = liveDataScope;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objEmit = this.$$this$liveData.emit(t, continuation);
        return objEmit != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objEmit;
    }
}

