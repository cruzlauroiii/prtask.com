namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016J\u0010\u0010\u0004\u001a\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\u0010\u0010\u0007\u001a\u00020\u00032\u0006\u0010\b\u001a\u00020\tH\u0016¨\u0006\n"}, d2 = {"kotlinx/coroutines/rx3/RxAwaitKt$await$2$1", "Lio/reactivex/rxjava3/core/CompletableObserver;", "onComplete", "", "onError", "e", "", "onSubscribe", "d", "Lpf98ed07a/pa30d0e7f/p90676d7c/p52905679/p7beea252;", "kotlinx-coroutines-rx3"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RxAwaitKt$await$2$1 : io.reactivex.rxjava3.core.CompletableObserver {
    readonly kotlinx.coroutines.CancellableContinuation<kotlin.Unit> $cont;

    RxAwaitKt$await$2$1(kotlinx.coroutines.CancellableContinuation<kotlin.Unit> cancellableContinuation) {
        this.$cont = cancellableContinuation;
    }

    public override void OnComplete() {
        kotlinx.coroutines.CancellableContinuation<kotlin.Unit> cancellableContinuation = this.$cont;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE));
    }

    public override void OnError(java.lang.Exception e) {
        kotlinx.coroutines.CancellableContinuation<kotlin.Unit> cancellableContinuation = this.$cont;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(e)));
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 d) {
        kotlinx.coroutines.rx3.RxAwaitKt.disposeOnCancellation(this.$cont, d);
    }
}

