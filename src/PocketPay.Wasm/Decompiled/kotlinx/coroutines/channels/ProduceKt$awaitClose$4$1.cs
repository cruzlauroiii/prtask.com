namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "it", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class ProduceKt$awaitClose$4$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly kotlinx.coroutines.CancellableContinuation<kotlin.Unit> $cont;

    ProduceKt$awaitClose$4$1(kotlinx.coroutines.CancellableContinuation<kotlin.Unit> cancellableContinuation) {
        super(1);
        this.$cont = cancellableContinuation;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        kotlinx.coroutines.CancellableContinuation<kotlin.Unit> cancellableContinuation = this.$cont;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE));
    }
}

