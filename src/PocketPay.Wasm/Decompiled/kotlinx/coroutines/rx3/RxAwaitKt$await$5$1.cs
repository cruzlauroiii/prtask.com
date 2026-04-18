namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\n\u0012\u0006\u0012\u0004\b\u00028\u00000\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0007\u001a\u00020\bH\u0016J\u001a\u0010\t\u001a\u00020\u00032\b\u0010\n\u001a\u0004\b\u00028\u0000H\u0016ø\u0001\u0000¢\u0006\u0002\u0010\u000bø\u0001\u0000\u0082\u0002\u0004\n\u0002\b9¨\u0006\f"}, d2 = {"kotlinx/coroutines/rx3/RxAwaitKt$await$5$1", "Lio/reactivex/rxjava3/core/SingleObserver;", "onError", "", "error", "", "onSubscribe", "d", "Lpf98ed07a/pa30d0e7f/p90676d7c/p52905679/p7beea252;", "onSuccess", "t", "(Ljava/lang/object;)V", "kotlinx-coroutines-rx3"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RxAwaitKt$await$5$1<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    readonly kotlinx.coroutines.CancellableContinuation<T> $cont;

    RxAwaitKt$await$5$1(kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation) {
        this.$cont = cancellableContinuation;
    }

    public override void OnError(java.lang.Exception error) {
        kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation = this.$cont;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(error)));
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 d) {
        kotlinx.coroutines.rx3.RxAwaitKt.disposeOnCancellation(this.$cont, d);
    }

    public override void OnSuccess(T t) {
        kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation = this.$cont;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(t));
    }
}

