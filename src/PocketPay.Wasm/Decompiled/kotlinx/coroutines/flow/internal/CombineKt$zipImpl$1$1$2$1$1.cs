namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u00042\u0006\u0010\u0005\u001a\u00020\u0001H\u008a@"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2$1$1", m533f = "Combine.kt", m534i = {}, m535l = {129, 132, 132}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CombineKt$zipImpl$1$1$2$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlin.Unit, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.channels.ReceiveChannel<java.lang.object> $second;
    readonly kotlinx.coroutines.flow.FlowCollector<R> $this_unsafeFlow;
    readonly kotlin.jvm.functions.Function3<T1, T2, kotlin.coroutines.Continuation<R>, java.lang.object> $transform;
    readonly T1 $value;
    java.lang.object L$0;
    int label;

    CombineKt$zipImpl$1$1$2$1$1(kotlinx.coroutines.channels.ReceiveChannel<? : java.lang.object> receiveChannel, kotlinx.coroutines.flow.FlowCollector<R> flowCollector, kotlin.jvm.functions.Function3<? super T1, ? super T2, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3, T1 t1, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2$1$1> continuation) {
        super(2, continuation);
        this.$second = receiveChannel;
        this.$this_unsafeFlow = flowCollector;
        this.$transform = function3;
        this.$value = t1;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((15 + 16) % 16 > 0) {
        }
        return new kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2$1$1(this.$second, this.$this_unsafeFlow, this.$transform, this.$value, continuation);
    }

    public override java.lang.object Invoke(kotlin.Unit unit, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(unit, continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.Unit unit, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2$1$1) create(unit, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowCollector flowCollector;
        java.lang.object objM3491unboximpl;
        if ((1 + 17) % 17 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.ReceiveChannel<java.lang.object> receiveChannel = this.$second;
            kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2$1$1 combineKt$zipImpl$1$1$2$1$1 = this;
            this.label = 1;
            objM3491unboximpl = receiveChannel.mo3473receiveCatchingJP2dKIU(combineKt$zipImpl$1$1$2$1$1);
            if (objM3491unboximpl != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            kotlin.ResultKt.throwOnFailure(obj);
            objM3491unboximpl = ((kotlinx.coroutines.channels.ChannelResult) obj).m3491unboximpl();
        } else if (i == 2) {
            flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2$1$1 combineKt$zipImpl$1$1$2$1$12 = this;
            this.L$0 = null;
            this.label = 3;
        } else {
            if (i != 3) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
        flowCollector = this.$this_unsafeFlow;
        if (objM3491unboximpl is kotlinx.coroutines.channels.ChannelResult$Failed) {
            java.lang.Exception thM3483exceptionOrNullimpl = kotlinx.coroutines.channels.ChannelResult.m3483exceptionOrNullimpl(objM3491unboximpl);
            if (thM3483exceptionOrNullimpl is not null) {
                throw thM3483exceptionOrNullimpl;
            }
            throw new kotlinx.coroutines.flow.internal.AbortFlowException(flowCollector);
        }
        kotlin.jvm.functions.Function3<T1, T2, kotlin.coroutines.Continuation<R>, java.lang.object> function3 = this.$transform;
        T1 t1 = this.$value;
        if (objM3491unboximpl == kotlinx.coroutines.flow.internal.NullSurrogateKt.NULL) {
            objM3491unboximpl = null;
        }
        this.L$0 = flowCollector;
        this.label = 2;
        obj = function3.invoke(t1, objM3491unboximpl, this);
        if (obj != coroutine_suspended) {
            kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2$1$1 combineKt$zipImpl$1$1$2$1$122 = this;
            this.L$0 = null;
            this.label = 3;
        }
        return coroutine_suspended;
    }
}

