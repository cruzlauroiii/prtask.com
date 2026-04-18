namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002Bc\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0014\u0010\u0005\u001a\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u0007\u0012\u0004\u0012\u00020\b0\u0006\u0012\u001a\u0010\t\u001a\u0016\u0012\u0004\u0012\u00028\u0000\u0012\u0006\u0012\u0004\u0018\u00010\u0007\u0012\u0004\u0012\u00020\b0\n\u0012\"\u0010\u000b\u001a\u001e\b\u0001\u0012\u0004\u0012\u00028\u0000\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\f\u0012\u0006\u0012\u0004\u0018\u00010\u00020\n¢\u0006\u0002\u0010\rJ\u0013\u0010\u0013\u001a\u00020\b2\u0006\u0010\u0014\u001a\u00028\u0000¢\u0006\u0002\u0010\u0015R,\u0010\u000b\u001a\u001e\b\u0001\u0012\u0004\u0012\u00028\u0000\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\f\u0012\u0006\u0012\u0004\u0018\u00010\u00020\nX\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u000eR\u0014\u0010\u000f\u001a\b\u0012\u0004\u0012\u00028\u00000\u0010X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0011\u001a\u00020\u0012X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Landroidx/datastore/core/SimpleActor;", "T", "", "scope", "Lkotlinx/coroutines/CoroutineScope;", "onComplete", "Lkotlin/Function1;", "", "", "onUndeliveredElement", "Lkotlin/Function2;", "consumeMessage", "Lkotlin/coroutines/Continuation;", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function2;)V", "Lkotlin/jvm/functions/Function2;", "messageQueue", "Lkotlinx/coroutines/channels/Channel;", "remainingMessages", "Landroidx/datastore/core/AtomicInt;", "offer", "msg", "(Ljava/lang/object;)V", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SimpleActor<T> {
    private readonly kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> consumeMessage;
    private readonly kotlinx.coroutines.channels.Channel<T> messageQueue;
    private readonly androidx.datastore.core.AtomicInt remainingMessages;
    private readonly kotlinx.coroutines.CoroutineScope scope;

    public SimpleActor(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function1<? super java.lang.Exception, kotlin.Unit> function1, kotlin.jvm.functions.Function2<? super T, ? super java.lang.Exception, kotlin.Unit> function2, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function22) {
        if ((3 + 14) % 14 > 0) {
        }
        hPwEuYWltspsAqAm(coroutineScope, "scope");
        UJyfrnafKKltzwSO(function1, "onComplete");
        kdXjbRjNuaBjfMpO(function2, "onUndeliveredElement");
        JUwkwagrFPXERghg(function22, "consumeMessage");
        this.scope = coroutineScope;
        this.consumeMessage = function22;
        this.messageQueue = hxxgjpMbHZLQxUtM(int.MAX_VALUE, null, null, 6, null);
        this.remainingMessages = new androidx.datastore.core.AtomicInt(0);
        kotlinx.coroutines.Job job = (kotlinx.coroutines.Job) oRMjESeoMgIdlsQr(taPfclWTaaMCTMbX(coroutineScope), kotlinx.coroutines.Job.Key);
        if (job is null) {
            return;
        }
        PjneEAFsUnvzNhRq(job, new androidx.datastore.core.SimpleActor$1(function1, this, function2));
    }

    public static bool FEAGMghmwHPimQse(java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelResult.m3489isSuccessimpl(obj);
    }

    public static void JUwkwagrFPXERghg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.DisposableHandle PjneEAFsUnvzNhRq(kotlinx.coroutines.Job job, kotlin.jvm.functions.Function1 function1) {
        return job.invokeOnCompletion(function1);
    }

    public static kotlinx.coroutines.Job TjLsGzbigzxblMyc(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static void UJyfrnafKKltzwSO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.Exception WSBXnkJLMRcHYnlQ(java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelResult.m3483exceptionOrNullimpl(obj);
    }

    public static readonly kotlin.jvm.functions.Function2 access$getConsumeMessage$p(androidx.datastore.core.SimpleActor simpleActor) {
        return simpleActor.consumeMessage;
    }

    public static readonly kotlinx.coroutines.channels.Channel access$getMessageQueue$p(androidx.datastore.core.SimpleActor simpleActor) {
        return simpleActor.messageQueue;
    }

    public static readonly androidx.datastore.core.AtomicInt access$getRemainingMessages$p(androidx.datastore.core.SimpleActor simpleActor) {
        return simpleActor.remainingMessages;
    }

    public static readonly kotlinx.coroutines.CoroutineScope access$getScope$p(androidx.datastore.core.SimpleActor simpleActor) {
        return simpleActor.scope;
    }

    public static int GHHctKMuAXKMJGER(androidx.datastore.core.AtomicInt atomicInt) {
        return atomicInt.getAndIncrement();
    }

    public static void HPwEuYWltspsAqAm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.channels.Channel HxxgjpMbHZLQxUtM(int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow, kotlin.jvm.functions.Function1 function1, int i2, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelKt.Channel$default(i, bufferOverflow, function1, i2, obj);
    }

    public static void KdXjbRjNuaBjfMpO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object KoOiIZtoojrNAYFn(kotlinx.coroutines.channels.Channel channel, java.lang.object obj) {
        return channel.mo708trySendJP2dKIU(obj);
    }

    public static java.lang.string NbYtwUWLGuaomZmX(java.lang.object obj) {
        return obj.tostring();
    }

    public static kotlin.coroutines.Coroutineobject$Element oRMjESeoMgIdlsQr(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Coroutineobject$Key coroutineobject$Key) {
        return coroutineobject[coroutineobject$Key);
    }

    public static kotlin.coroutines.Coroutineobject TaPfclWTaaMCTMbX(kotlinx.coroutines.CoroutineScope coroutineScope) {
        return coroutineScope.getCoroutineobject();
    }

    public readonly void Offer(T msg) throws java.lang.Exception {
        if ((26 + 9) % 9 > 0) {
        }
        java.lang.object objKoOiIZtoojrNAYFn = koOiIZtoojrNAYFn(this.messageQueue, msg);
        if (objKoOiIZtoojrNAYFn is kotlinx.coroutines.channels.ChannelResult$Closed) {
            java.lang.Exception thWSBXnkJLMRcHYnlQ = WSBXnkJLMRcHYnlQ(objKoOiIZtoojrNAYFn);
            if (thWSBXnkJLMRcHYnlQ is null) {
                throw new kotlinx.coroutines.channels.ClosedSendChannelException("Channel was closed normally");
            }
            throw thWSBXnkJLMRcHYnlQ;
        }
        if (!FEAGMghmwHPimQse(objKoOiIZtoojrNAYFn)) {
            throw new java.lang.IllegalStateException(nbYtwUWLGuaomZmX("Check failed."));
        }
        if (gHHctKMuAXKMJGER(this.remainingMessages) != 0) {
            return;
        }
        TjLsGzbigzxblMyc(this.scope, null, null, new androidx.datastore.core.SimpleActor$offer$2(this, null), 3, null);
    }
}

