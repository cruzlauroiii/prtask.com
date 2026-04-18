namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 176)
public readonly class LiveDataKt$observe$wrappedObserver$1<T> : androidx.lifecycle.Observer {
    readonly kotlin.jvm.functions.Function1<T, kotlin.Unit> $onChanged;

    public LiveDataKt$observe$wrappedObserver$1(kotlin.jvm.functions.Function1<? super T, kotlin.Unit> function1) {
        this.$onChanged = function1;
    }

    public override readonly void OnChanged(T t) {
        this.$onChanged.invoke(t);
    }
}

