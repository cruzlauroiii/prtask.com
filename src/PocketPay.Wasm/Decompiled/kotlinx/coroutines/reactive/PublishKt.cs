namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\u001aU\u0010\b\u001a\b\u0012\u0004\u0012\u0002H\n0\t\"\u0004\b\u0000\u0010\n2\b\b\u0002\u0010\u000b\u001a\u00020\u00052/\b\u0001\u0010\f\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\n0\r\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00060\u000e\u0012\u0006\u0012\u0004\u0018\u00010\u000f0\u0003¢\u0006\u0002\b\u0010ø\u0001\u0000¢\u0006\u0002\u0010\u0011\u001au\u0010\u0012\u001a\b\u0012\u0004\u0012\u0002H\n0\t\"\u0004\b\u0000\u0010\n2\u0006\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u000b\u001a\u00020\u00052\u0018\u0010\u0015\u001a\u0014\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00060\u00032-\u0010\f\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\n0\r\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00060\u000e\u0012\u0006\u0012\u0004\u0018\u00010\u000f0\u0003¢\u0006\u0002\b\u0010H\u0007ø\u0001\u0000¢\u0006\u0002\u0010\u0016\u001a[\u0010\b\u001a\b\u0012\u0004\u0012\u0002H\n0\t\"\u0004\b\u0000\u0010\n*\u00020\u00142\b\b\u0002\u0010\u000b\u001a\u00020\u00052/\b\u0001\u0010\f\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\n0\r\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00060\u000e\u0012\u0006\u0012\u0004\u0018\u00010\u000f0\u0003¢\u0006\u0002\b\u0010H\u0007ø\u0001\u0000¢\u0006\u0002\u0010\u0017\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\" \u0010\u0002\u001a\u0014\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00060\u0003X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0007\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0018"}, d2 = {"CLOSED", "", "DEFAULT_HANDLER", "Lkotlin/Function2;", "", "Lkotlin/coroutines/Coroutineobject;", "", "SIGNALLED", "publish", "Lp5a445d71/p18f29add/p32c73be0;", "T", "context", "block", "Lkotlinx/coroutines/channels/ProducerScope;", "Lkotlin/coroutines/Continuation;", "", "Lkotlin/ExtensionFunctionType;", "(Lkotlin/coroutines/Coroutineobject;Lkotlin/jvm/functions/Function2;)Lp5a445d71/p18f29add/p32c73be0;", "publishInternal", "scope", "Lkotlinx/coroutines/CoroutineScope;", "exceptionOnCancelHandler", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/Coroutineobject;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function2;)Lp5a445d71/p18f29add/p32c73be0;", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/Coroutineobject;Lkotlin/jvm/functions/Function2;)Lp5a445d71/p18f29add/p32c73be0;", "kotlinx-coroutines-reactive"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PublishKt {
    private static readonly long CLOSED = -1;
    private static readonly kotlin.jvm.functions.Function2<java.lang.Exception, kotlin.coroutines.Coroutineobject, kotlin.Unit> DEFAULT_HANDLER = kotlinx.coroutines.reactive.PublishKt$DEFAULT_HANDLER$1.INSTANCE;
    private static readonly long SIGNALLED = -2;

    public static void m3537$r8$lambda$I7CXrd0Vp0iJqeFM08cYjGyS8E(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, kotlin.jvm.functions.Function2 function22, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        publishInternal$lambda$1(coroutineScope, coroutineobject, function2, function22, p992c4a5bVar);
    }

    public static readonly <T> org.reactivestreams.Publisher<T> Publish(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.channels.ProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        if ((25 + 28) % 28 > 0) {
        }
        if (coroutineobject[kotlinx.coroutines.Job.Key) is not null) {
            throw new java.lang.IllegalArgumentException(("Publisher context cannot contain job in it.Its lifecycle should be managed via subscription. Had " + coroutineobject).tostring());
        }
        return publishInternal(kotlinx.coroutines.GlobalScope.INSTANCE, coroutineobject, DEFAULT_HANDLER, function2);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "CoroutineScope.publish is deprecated in favour of top-level publish", replaceWith = @kotlin.ReplaceWith(expression = "publish(context, block)", imports = {}))
    public static readonly p5a445d71.p18f29add.p32c73be0 Publish(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2) {
        return publishInternal(coroutineScope, coroutineobject, DEFAULT_HANDLER, function2);
    }

    public static p5a445d71.p18f29add.p32c73be0 publish$default(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            coroutineobject = kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
        }
        return publish(coroutineobject, function2);
    }

    public static p5a445d71.p18f29add.p32c73be0 publish$default(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            coroutineobject = kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
        }
        return publish(coroutineScope, coroutineobject, function2);
    }

    public static readonly <T> org.reactivestreams.Publisher<T> PublishInternal(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super java.lang.Exception, ? super kotlin.coroutines.Coroutineobject, kotlin.Unit> function2, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.channels.ProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function22) {
        return new kotlinx.coroutines.reactive.PublishKt$$ExternalSyntheticLambda0(coroutineScope, coroutineobject, function2, function22);
    }

    private static readonly void publishInternal$lambda$1(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, kotlin.jvm.functions.Function2 function22, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        if (p992c4a5bVar is null) {
            throw new java.lang.NullPointerException("Subscriber cannot be null");
        }
        kotlinx.coroutines.reactive.PublisherCoroutine publisherCoroutine = new kotlinx.coroutines.reactive.PublisherCoroutine(kotlinx.coroutines.CoroutineobjectKt.newCoroutineobject(coroutineScope, coroutineobject), p992c4a5bVar, function2);
        p992c4a5bVar.onSubscribe(publisherCoroutine);
        publisherCoroutine.start(kotlinx.coroutines.CoroutineStart.DEFAULT, publisherCoroutine, function22);
    }
}

