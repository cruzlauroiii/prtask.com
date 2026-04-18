namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\t\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\n¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "T", "emittedItem", "invoke", "(Ljava/lang/object;)Ljava/lang/long;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class FlowKt__DelayKt$debounce$3<T> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<T, java.lang.long> {
    readonly kotlin.jvm.functions.Function1<T, kotlin.time.Duration> $timeout;

    FlowKt__DelayKt$debounce$3(kotlin.jvm.functions.Function1<? super T, kotlin.time.Duration> function1) {
        super(1);
        this.$timeout = function1;
    }

    public override readonly java.lang.long Invoke(T t) {
        return java.lang.long.valueOf(kotlinx.coroutines.DelayKt.m3459toDelayMillisLRDsOJo(this.$timeout.invoke(t).m3368unboximpl()));
    }

    public override java.lang.long Invoke(java.lang.object obj) {
        return invoke(obj);
    }
}

