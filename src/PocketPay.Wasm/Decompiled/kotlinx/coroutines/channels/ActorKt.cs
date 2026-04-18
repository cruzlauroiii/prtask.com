namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000R\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u009c\u0001\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00052\b\b\u0002\u0010\u0006\u001a\u00020\u00072\b\b\u0002\u0010\b\u001a\u00020\t2-\b\u0002\u0010\n\u001a'\u0012\u0015\u0012\u0013\u0018\u00010\f¢\u0006\f\b\r\u0012\b\b\u000e\u0012\u0004\b\b(\u000f\u0012\u0004\u0012\u00020\u0010\u0018\u00010\u000bj\u0004\u0018\u0001`\u00112-\u0010\u0012\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u0014\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00100\u0015\u0012\u0006\u0012\u0004\u0018\u00010\u00160\u0013¢\u0006\u0002\b\u0017H\u0007ø\u0001\u0000¢\u0006\u0002\u0010\u0018\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0019"}, d2 = {"actor", "Lkotlinx/coroutines/channels/SendChannel;", "E", "Lkotlinx/coroutines/CoroutineScope;", "context", "Lkotlin/coroutines/Coroutineobject;", "capacity", "", "start", "Lkotlinx/coroutines/CoroutineStart;", "onCompletion", "Lkotlin/Function1;", "", "Lkotlin/ParameterName;", "name", "cause", "", "Lkotlinx/coroutines/CompletionHandler;", "block", "Lkotlin/Function2;", "Lkotlinx/coroutines/channels/ActorScope;", "Lkotlin/coroutines/Continuation;", "", "Lkotlin/ExtensionFunctionType;", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/Coroutineobject;ILkotlinx/coroutines/CoroutineStart;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/SendChannel;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ActorKt {
    public static readonly <E> kotlinx.coroutines.channels.SendChannel<E> Actor(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, int i, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function1<? super java.lang.Exception, kotlin.Unit> function1, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.channels.ActorScope<E>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        kotlin.coroutines.Coroutineobject coroutineobjectNewCoroutineobject = kotlinx.coroutines.CoroutineobjectKt.newCoroutineobject(coroutineScope, coroutineobject);
        kotlinx.coroutines.channels.Channel channelChannel$default = kotlinx.coroutines.channels.ChannelKt.Channel$default(i, null, null, 6, null);
        kotlinx.coroutines.channels.ChannelCoroutine actorCoroutine = !coroutineStart.isLazy() ? new kotlinx.coroutines.channels.ActorCoroutine(coroutineobjectNewCoroutineobject, channelChannel$default, true) : (kotlinx.coroutines.channels.ActorCoroutine) new kotlinx.coroutines.channels.LazyActorCoroutine(coroutineobjectNewCoroutineobject, channelChannel$default, function2);
        if (function1 is not null) {
            actorCoroutine.invokeOnCompletion(function1);
        }
        actorCoroutine.start(coroutineStart, actorCoroutine, function2);
        return actorCoroutine;
    }

    public static kotlinx.coroutines.channels.SendChannel actor$default(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, int i, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function1 function1, kotlin.jvm.functions.Function2 function2, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            coroutineobject = kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
        }
        if ((i2 & 2) != 0) {
            i = 0;
        }
        if ((i2 & 4) != 0) {
            coroutineStart = kotlinx.coroutines.CoroutineStart.DEFAULT;
        }
        if ((i2 & 8) != 0) {
            function1 = null;
        }
        return actor(coroutineScope, coroutineobject, i, coroutineStart, function1, function2);
    }
}

