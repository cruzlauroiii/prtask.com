namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\u001aQ\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00052'\u0010\u0006\u001a#\b\u0001\u0012\u0004\u0012\u00020\b\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\t\u0012\u0006\u0012\u0004\u0018\u00010\u00030\u0007¢\u0006\u0002\b\nø\u0001\u0000¢\u0006\u0002\u0010\u000b\u001aY\u0010\f\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\u0006\u0010\r\u001a\u00020\b2\u0006\u0010\u0004\u001a\u00020\u00052'\u0010\u0006\u001a#\b\u0001\u0012\u0004\u0012\u00020\b\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\t\u0012\u0006\u0012\u0004\u0018\u00010\u00030\u0007¢\u0006\u0002\b\nH\u0002ø\u0001\u0000¢\u0006\u0002\u0010\u000e\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u000f"}, d2 = {"rxSingle", "Lio/reactivex/rxjava3/core/Single;", "T", "", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "Lkotlin/Function2;", "Lkotlinx/coroutines/CoroutineScope;", "Lkotlin/coroutines/Continuation;", "Lkotlin/ExtensionFunctionType;", "(Lkotlin/coroutines/Coroutineobject;Lkotlin/jvm/functions/Function2;)Lio/reactivex/rxjava3/core/Single;", "rxSingleInternal", "scope", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/Coroutineobject;Lkotlin/jvm/functions/Function2;)Lio/reactivex/rxjava3/core/Single;", "kotlinx-coroutines-rx3"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RxSingleKt {
    public static void $r8$lambda$aooUUSTin_oF3tMfQ1LtIJl7aMI(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        rxSingleInternal$lambda$1(coroutineScope, coroutineobject, function2, singleEmitter);
    }

    public static readonly <T> io.reactivex.rxjava3.core.Single<T> RxSingle(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2) {
        if (coroutineobject[kotlinx.coroutines.Job.Key) is not null) {
            throw new java.lang.IllegalArgumentException(("Single context cannot contain job in it.Its lifecycle should be managed via Disposable handle. Had " + coroutineobject).tostring());
        }
        return rxSingleInternal(kotlinx.coroutines.GlobalScope.INSTANCE, coroutineobject, function2);
    }

    public static io.reactivex.rxjava3.core.Single rxSingle$default(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            coroutineobject = kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
        }
        return rxSingle(coroutineobject, function2);
    }

    private static readonly <T> io.reactivex.rxjava3.core.Single<T> RxSingleInternal(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2) {
        return io.reactivex.rxjava3.core.Single.m76ea0beb(new kotlinx.coroutines.rx3.RxSingleKt$$ExternalSyntheticLambda0(coroutineScope, coroutineobject, function2));
    }

    private static readonly void rxSingleInternal$lambda$1(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        kotlinx.coroutines.rx3.RxSingleCoroutine rxSingleCoroutine = new kotlinx.coroutines.rx3.RxSingleCoroutine(kotlinx.coroutines.CoroutineobjectKt.newCoroutineobject(coroutineScope, coroutineobject), singleEmitter);
        singleEmitter.setCancellable(new kotlinx.coroutines.rx3.RxCancellable(rxSingleCoroutine));
        rxSingleCoroutine.start(kotlinx.coroutines.CoroutineStart.DEFAULT, rxSingleCoroutine, function2);
    }
}

