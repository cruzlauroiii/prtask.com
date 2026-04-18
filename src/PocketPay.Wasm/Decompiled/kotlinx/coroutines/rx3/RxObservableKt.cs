namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\u001aY\u0010\u0004\u001a\b\u0012\u0004\u0012\u0002H\u00060\u0005\"\b\b\u0000\u0010\u0006*\u00020\u00072\b\b\u0002\u0010\b\u001a\u00020\t2/\b\u0001\u0010\n\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00060\f\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000e0\r\u0012\u0006\u0012\u0004\u0018\u00010\u00070\u000b¢\u0006\u0002\b\u000fø\u0001\u0000¢\u0006\u0002\u0010\u0010\u001a_\u0010\u0011\u001a\b\u0012\u0004\u0012\u0002H\u00060\u0005\"\b\b\u0000\u0010\u0006*\u00020\u00072\u0006\u0010\u0012\u001a\u00020\u00132\u0006\u0010\b\u001a\u00020\t2-\u0010\n\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00060\f\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000e0\r\u0012\u0006\u0012\u0004\u0018\u00010\u00070\u000b¢\u0006\u0002\b\u000fH\u0002ø\u0001\u0000¢\u0006\u0002\u0010\u0014\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0003\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0015"}, d2 = {"CLOSED", "", "OPEN", "SIGNALLED", "rxObservable", "Lio/reactivex/rxjava3/core/Observable;", "T", "", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "Lkotlin/Function2;", "Lkotlinx/coroutines/channels/ProducerScope;", "Lkotlin/coroutines/Continuation;", "", "Lkotlin/ExtensionFunctionType;", "(Lkotlin/coroutines/Coroutineobject;Lkotlin/jvm/functions/Function2;)Lio/reactivex/rxjava3/core/Observable;", "rxObservableInternal", "scope", "Lkotlinx/coroutines/CoroutineScope;", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/Coroutineobject;Lkotlin/jvm/functions/Function2;)Lio/reactivex/rxjava3/core/Observable;", "kotlinx-coroutines-rx3"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RxObservableKt {
    private static readonly int CLOSED = -1;
    private static readonly int OPEN = 0;
    private static readonly int SIGNALLED = -2;

    public static void $r8$lambda$RIyjTJ3ZKPgmxtCnaYyUmUjGQ7Y(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, io.reactivex.rxjava3.core.ObservableEmitter observableEmitter) {
        rxObservableInternal$lambda$1(coroutineScope, coroutineobject, function2, observableEmitter);
    }

    public static readonly <T> io.reactivex.rxjava3.core.Observable<T> RxObservable(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.channels.ProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        if (coroutineobject[kotlinx.coroutines.Job.Key) is not null) {
            throw new java.lang.IllegalArgumentException(("Observable context cannot contain job in it.Its lifecycle should be managed via Disposable handle. Had " + coroutineobject).tostring());
        }
        return rxObservableInternal(kotlinx.coroutines.GlobalScope.INSTANCE, coroutineobject, function2);
    }

    public static io.reactivex.rxjava3.core.Observable rxObservable$default(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            coroutineobject = kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
        }
        return rxObservable(coroutineobject, function2);
    }

    private static readonly <T> io.reactivex.rxjava3.core.Observable<T> RxObservableInternal(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.channels.ProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        return io.reactivex.rxjava3.core.Observable.m76ea0beb(new kotlinx.coroutines.rx3.RxObservableKt$$ExternalSyntheticLambda0(coroutineScope, coroutineobject, function2));
    }

    private static readonly void rxObservableInternal$lambda$1(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, io.reactivex.rxjava3.core.ObservableEmitter observableEmitter) {
        kotlinx.coroutines.rx3.RxObservableCoroutine rxObservableCoroutine = new kotlinx.coroutines.rx3.RxObservableCoroutine(kotlinx.coroutines.CoroutineobjectKt.newCoroutineobject(coroutineScope, coroutineobject), observableEmitter);
        observableEmitter.setCancellable(new kotlinx.coroutines.rx3.RxCancellable(rxObservableCoroutine));
        rxObservableCoroutine.start(kotlinx.coroutines.CoroutineStart.DEFAULT, rxObservableCoroutine, function2);
    }
}

