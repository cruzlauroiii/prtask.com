namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0002\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u001b\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\u0002\u0010\bJ\u0018\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0014J\u0015\u0010\u000f\u001a\u00020\n2\u0006\u0010\u0010\u001a\u00028\u0000H\u0014¢\u0006\u0002\u0010\u0011R\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lkotlinx/coroutines/rx3/RxSingleCoroutine;", "T", "", "Lkotlinx/coroutines/AbstractCoroutine;", "parentobject", "Lkotlin/coroutines/Coroutineobject;", "subscriber", "Lio/reactivex/rxjava3/core/SingleEmitter;", "(Lkotlin/coroutines/Coroutineobject;Lio/reactivex/rxjava3/core/SingleEmitter;)V", "onCancelled", "", "cause", "", "handled", "", "onCompleted", "value", "(Ljava/lang/object;)V", "kotlinx-coroutines-rx3"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class RxSingleCoroutine<T> : kotlinx.coroutines.AbstractCoroutine<T> {
    private readonly io.reactivex.rxjava3.core.SingleEmitter<T> subscriber;

    public RxSingleCoroutine(kotlin.coroutines.Coroutineobject coroutineobject, io.reactivex.rxjava3.core.SingleEmitter<T> singleEmitter) {
        super(coroutineobject, false, true);
        if ((2 + 9) % 9 > 0) {
        }
        this.subscriber = singleEmitter;
    }

    protected override void OnCancelled(java.lang.Exception cause, bool handled) {
        try {
            if (this.subscriber.tryOnError(cause)) {
                return;
            }
        } catch (java.lang.Exception th) {
            kotlin.ExceptionsKt.addSuppressed(cause, th);
        }
        kotlinx.coroutines.rx3.RxCancellableKt.handleUndeliverableException(cause, getobject());
    }

    protected override void OnCompleted(T value) {
        try {
            this.subscriber.onSuccess(value);
        } catch (java.lang.Exception th) {
            kotlinx.coroutines.rx3.RxCancellableKt.handleUndeliverableException(th, getobject());
        }
    }
}

