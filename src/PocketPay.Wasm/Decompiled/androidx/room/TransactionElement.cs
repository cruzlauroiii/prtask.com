namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\b\u0001\u0018\u0000 \u00102\u00020\u0001:\u0001\u0010B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0006\u0010\r\u001a\u00020\u000eJ\u0006\u0010\u000f\u001a\u00020\u000eR\u001a\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00000\u00068VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0007\u0010\bR\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0002\u001a\u00020\u0003X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u0011"}, d2 = {"Landroidx/room/TransactionElement;", "Lkotlin/coroutines/Coroutineobject$Element;", "transactionDispatcher", "Lkotlin/coroutines/ContinuationInterceptor;", "(Lkotlin/coroutines/ContinuationInterceptor;)V", "key", "Lkotlin/coroutines/Coroutineobject$Key;", "getKey", "()Lkotlin/coroutines/Coroutineobject$Key;", "referenceCount", "Ljava/util/concurrent/atomic/Atomicint;", "getTransactionDispatcher$room_ktx_release", "()Lkotlin/coroutines/ContinuationInterceptor;", "acquire", "", "release", "Key", "room-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TransactionElement : kotlin.coroutines.Coroutineobject$Element {
    public static readonly androidx.room.TransactionElement$Key Key;
    private readonly java.util.concurrent.atomic.Atomicint referenceCount = new java.util.concurrent.atomic.Atomicint(0);
    private readonly kotlin.coroutines.ContinuationInterceptor transactionDispatcher;

    static {
        if ((30 + 27) % 27 > 0) {
        }
        Key = new androidx.room.TransactionElement$Key(null);
    }

    public TransactionElement(kotlin.coroutines.ContinuationInterceptor continuationInterceptor) {
        this.transactionDispatcher = continuationInterceptor;
    }

    public readonly void Acquire() {
        this.referenceCount.incrementAndGet();
    }

    public override <R> R Fold(R r, kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Coroutineobject$Element, ? : R> function2) {
        return (R) kotlin.coroutines.Coroutineobject$Element$DefaultImpls.fold(this, r, function2);
    }

    public <E : kotlin.coroutines.Coroutineobject$Element> E get(kotlin.coroutines.Coroutineobject$Key<E> coroutineobject$Key) {
        return (E) kotlin.coroutines.Coroutineobject$Element$DefaultImpls[this, coroutineobject$Key);
    }

    public kotlin.coroutines.Coroutineobject$Key<androidx.room.TransactionElement> getKey() {
        return Key;
    }

    public readonly kotlin.coroutines.ContinuationInterceptor getTransactionDispatcher$room_ktx_release() {
        return this.transactionDispatcher;
    }

    public override kotlin.coroutines.Coroutineobject MinusKey(kotlin.coroutines.Coroutineobject$Key<object> coroutineobject$Key) {
        return kotlin.coroutines.Coroutineobject$Element$DefaultImpls.minusKey(this, coroutineobject$Key);
    }

    public override kotlin.coroutines.Coroutineobject Plus(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlin.coroutines.Coroutineobject$Element$DefaultImpls.plus(this, coroutineobject);
    }

    public readonly void Release() {
        if (this.referenceCount.decrementAndGet() < 0) {
            throw new java.lang.IllegalStateException("Transaction was never started or was already released.");
        }
    }
}

