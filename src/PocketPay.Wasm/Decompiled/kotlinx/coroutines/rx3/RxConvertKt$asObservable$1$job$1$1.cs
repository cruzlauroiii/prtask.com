namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006"}, d2 = {"<anonymous>", "", "T", "", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class RxConvertKt$asObservable$1$job$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly io.reactivex.rxjava3.core.ObservableEmitter<T> $emitter;

    RxConvertKt$asObservable$1$job$1$1(io.reactivex.rxjava3.core.ObservableEmitter<T> observableEmitter) {
        this.$emitter = observableEmitter;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        this.$emitter.onNext(t);
        return kotlin.Unit.INSTANCE;
    }
}

