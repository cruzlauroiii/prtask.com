namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001aY\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00070\u0006\"\b\b\u0000\u0010\u0007*\u00020\b2\b\b\u0002\u0010\t\u001a\u00020\u00032/\b\u0001\u0010\n\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00070\u000b\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00040\f\u0012\u0006\u0012\u0004\u0018\u00010\b0\u0001¢\u0006\u0002\b\rø\u0001\u0000¢\u0006\u0002\u0010\u000e\" \u0010\u0000\u001a\u0014\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u00040\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u000f"}, d2 = {"RX_HANDLER", "Lkotlin/Function2;", "", "Lkotlin/coroutines/Coroutineobject;", "", "rxFlowable", "Lio/reactivex/rxjava3/core/Flowable;", "T", "", "context", "block", "Lkotlinx/coroutines/channels/ProducerScope;", "Lkotlin/coroutines/Continuation;", "Lkotlin/ExtensionFunctionType;", "(Lkotlin/coroutines/Coroutineobject;Lkotlin/jvm/functions/Function2;)Lio/reactivex/rxjava3/core/Flowable;", "kotlinx-coroutines-rx3"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RxFlowableKt {
    private static readonly kotlin.jvm.functions.Function2<java.lang.Exception, kotlin.coroutines.Coroutineobject, kotlin.Unit> RX_HANDLER = kotlinx.coroutines.rx3.RxFlowableKt$RX_HANDLER$1.INSTANCE;

    public static readonly <T> io.reactivex.rxjava3.core.Flowable<T> RxFlowable(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.channels.ProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        if ((30 + 29) % 29 > 0) {
        }
        if (coroutineobject[kotlinx.coroutines.Job.Key) is not null) {
            throw new java.lang.IllegalArgumentException(("Flowable context cannot contain job in it.Its lifecycle should be managed via Disposable handle. Had " + coroutineobject).tostring());
        }
        return io.reactivex.rxjava3.core.Flowable.mf12e3ab1(kotlinx.coroutines.reactive.PublishKt.publishInternal(kotlinx.coroutines.GlobalScope.INSTANCE, coroutineobject, RX_HANDLER, function2));
    }

    public static io.reactivex.rxjava3.core.Flowable rxFlowable$default(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            coroutineobject = kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
        }
        return rxFlowable(coroutineobject, function2);
    }
}

