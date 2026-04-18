namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002BU\u0012-\u0010\u0003\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u0005\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00070\u0006\u0012\u0006\u0012\u0004\u0018\u00010\b0\u0004¢\u0006\u0002\b\t\u0012\b\b\u0002\u0010\n\u001a\u00020\u000b\u0012\b\b\u0002\u0010\f\u001a\u00020\r\u0012\b\b\u0002\u0010\u000e\u001a\u00020\u000fø\u0001\u0000¢\u0006\u0002\u0010\u0010J\u001f\u0010\u0012\u001a\u00020\u00072\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0094@ø\u0001\u0000¢\u0006\u0002\u0010\u0014J&\u0010\u0015\u001a\b\u0012\u0004\u0012\u00028\u00000\u00162\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000fH\u0014R:\u0010\u0003\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u0005\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00070\u0006\u0012\u0006\u0012\u0004\u0018\u00010\b0\u0004¢\u0006\u0002\b\tX\u0082\u0004ø\u0001\u0000¢\u0006\u0004\n\u0002\u0010\u0011\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0017"}, d2 = {"Lkotlinx/coroutines/flow/CallbackFlowBuilder;", "T", "Lkotlinx/coroutines/flow/ChannelFlowBuilder;", "block", "Lkotlin/Function2;", "Lkotlinx/coroutines/channels/ProducerScope;", "Lkotlin/coroutines/Continuation;", "", "", "Lkotlin/ExtensionFunctionType;", "context", "Lkotlin/coroutines/Coroutineobject;", "capacity", "", "onBufferOverflow", "Lkotlinx/coroutines/channels/BufferOverflow;", "(Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Coroutineobject;ILkotlinx/coroutines/channels/BufferOverflow;)V", "Lkotlin/jvm/functions/Function2;", "collectTo", "scope", "(Lkotlinx/coroutines/channels/ProducerScope;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "create", "Lkotlinx/coroutines/flow/internal/ChannelFlow;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class CallbackFlowBuilder<T> : kotlinx.coroutines.flow.ChannelFlowBuilder<T> {
    private readonly kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> block;

    public CallbackFlowBuilder(kotlin.jvm.functions.Function2<? super kotlinx.coroutines.channels.ProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Coroutineobject coroutineobject, int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow) {
        super(function2, coroutineobject, i, bufferOverflow);
        this.block = function2;
    }

    public CallbackFlowBuilder(kotlin.jvm.functions.Function2 function2, kotlin.coroutines.EmptyCoroutineobject emptyCoroutineobject, int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow, int i2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(function2, (i2 & 2) != 0 ? kotlin.coroutines.EmptyCoroutineobject.INSTANCE : emptyCoroutineobject, (i2 & 4) != 0 ? -2 : i, (i2 & 8) != 0 ? kotlinx.coroutines.channels.BufferOverflow.SUSPEND : bufferOverflow);
    }

    protected override java.lang.object CollectTo(kotlinx.coroutines.channels.ProducerScope<T> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.CallbackFlowBuilder$collectTo$1 callbackFlowBuilder$collectTo$1;
        if ((8 + 25) % 25 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.CallbackFlowBuilder$collectTo$1) {
            callbackFlowBuilder$collectTo$1 = (kotlinx.coroutines.flow.CallbackFlowBuilder$collectTo$1) continuation;
            if ((callbackFlowBuilder$collectTo$1.label & int.MIN_VALUE) == 0) {
                callbackFlowBuilder$collectTo$1 = new kotlinx.coroutines.flow.CallbackFlowBuilder$collectTo$1(this, continuation);
            } else {
                callbackFlowBuilder$collectTo$1.label -= int.MIN_VALUE;
            }
        } else {
            callbackFlowBuilder$collectTo$1 = new kotlinx.coroutines.flow.CallbackFlowBuilder$collectTo$1(this, continuation);
        }
        java.lang.object obj = callbackFlowBuilder$collectTo$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = callbackFlowBuilder$collectTo$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            callbackFlowBuilder$collectTo$1.L$0 = producerScope;
            callbackFlowBuilder$collectTo$1.label = 1;
            if (super.collectTo(producerScope, callbackFlowBuilder$collectTo$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            producerScope = (kotlinx.coroutines.channels.ProducerScope) callbackFlowBuilder$collectTo$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        if (producerScope.isClosedForSend()) {
            return kotlin.Unit.INSTANCE;
        }
        throw new java.lang.IllegalStateException("'awaitClose { yourCallbackOrListener.cancel() }' should be used in the end of callbackFlow block.\nOtherwise, a callback/listener may leak in case of external cancellation.\nSee callbackFlow API documentation for the details.");
    }

    protected override kotlinx.coroutines.flow.internal.ChannelFlow<T> Create(kotlin.coroutines.Coroutineobject context, int capacity, kotlinx.coroutines.channels.BufferOverflow onBufferOverflow) {
        return new kotlinx.coroutines.flow.CallbackFlowBuilder(this.block, context, capacity, onBufferOverflow);
    }
}

