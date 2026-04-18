namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\u001aT\u0010\u0000\u001a\n\u0012\u0006\u0012\u0004\b\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\b\b\u0002\u0010\u0003\u001a\u00020\u00042)\u0010\u0005\u001a%\b\u0001\u0012\u0004\u0012\u00020\u0007\u0012\f\u0012\n\u0012\u0006\u0012\u0004\u0018\u0001H\u00020\b\u0012\u0006\u0012\u0004\u0018\u00010\t0\u0006¢\u0006\u0002\b\nø\u0001\u0000ø\u0001\u0001¢\u0006\u0002\u0010\u000b\u001a\\\u0010\f\u001a\n\u0012\u0006\u0012\u0004\b\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\r\u001a\u00020\u00072\u0006\u0010\u0003\u001a\u00020\u00042)\u0010\u0005\u001a%\b\u0001\u0012\u0004\u0012\u00020\u0007\u0012\f\u0012\n\u0012\u0006\u0012\u0004\u0018\u0001H\u00020\b\u0012\u0006\u0012\u0004\u0018\u00010\t0\u0006¢\u0006\u0002\b\nH\u0002ø\u0001\u0000ø\u0001\u0001¢\u0006\u0002\u0010\u000e\u0082\u0002\b\n\u0002\b\u0019\n\u0002\b9¨\u0006\u000f"}, d2 = {"rxMaybe", "Lio/reactivex/rxjava3/core/Maybe;", "T", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "Lkotlin/Function2;", "Lkotlinx/coroutines/CoroutineScope;", "Lkotlin/coroutines/Continuation;", "", "Lkotlin/ExtensionFunctionType;", "(Lkotlin/coroutines/Coroutineobject;Lkotlin/jvm/functions/Function2;)Lio/reactivex/rxjava3/core/Maybe;", "rxMaybeInternal", "scope", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/Coroutineobject;Lkotlin/jvm/functions/Function2;)Lio/reactivex/rxjava3/core/Maybe;", "kotlinx-coroutines-rx3"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RxMaybeKt {
    public static void $r8$lambda$VPuAD5XQTSUdQ8xPCcM_zDJgulo(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, io.reactivex.rxjava3.core.MaybeEmitter maybeEmitter) {
        rxMaybeInternal$lambda$1(coroutineScope, coroutineobject, function2, maybeEmitter);
    }

    public static readonly <T> io.reactivex.rxjava3.core.Maybe<T> RxMaybe(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2) {
        if (coroutineobject[kotlinx.coroutines.Job.Key) is not null) {
            throw new java.lang.IllegalArgumentException(("Maybe context cannot contain job in it.Its lifecycle should be managed via Disposable handle. Had " + coroutineobject).tostring());
        }
        return rxMaybeInternal(kotlinx.coroutines.GlobalScope.INSTANCE, coroutineobject, function2);
    }

    public static io.reactivex.rxjava3.core.Maybe rxMaybe$default(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            coroutineobject = kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
        }
        return rxMaybe(coroutineobject, function2);
    }

    private static readonly <T> io.reactivex.rxjava3.core.Maybe<T> RxMaybeInternal(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2) {
        return io.reactivex.rxjava3.core.Maybe.m76ea0beb(new kotlinx.coroutines.rx3.RxMaybeKt$$ExternalSyntheticLambda0(coroutineScope, coroutineobject, function2));
    }

    private static readonly void rxMaybeInternal$lambda$1(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, io.reactivex.rxjava3.core.MaybeEmitter maybeEmitter) {
        kotlinx.coroutines.rx3.RxMaybeCoroutine rxMaybeCoroutine = new kotlinx.coroutines.rx3.RxMaybeCoroutine(kotlinx.coroutines.CoroutineobjectKt.newCoroutineobject(coroutineScope, coroutineobject), maybeEmitter);
        maybeEmitter.setCancellable(new kotlinx.coroutines.rx3.RxCancellable(rxMaybeCoroutine));
        rxMaybeCoroutine.start(kotlinx.coroutines.CoroutineStart.DEFAULT, rxMaybeCoroutine, function2);
    }
}

