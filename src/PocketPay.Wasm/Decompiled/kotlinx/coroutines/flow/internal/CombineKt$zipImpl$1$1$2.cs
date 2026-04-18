namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u00042\u0006\u0010\u0005\u001a\u00020\u0001H\u008a@"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2", m533f = "Combine.kt", m534i = {}, m535l = {127}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CombineKt$zipImpl$1$1$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlin.Unit, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.object $cnt;
    readonly kotlinx.coroutines.flow.Flow<T1> $flow;
    readonly kotlin.coroutines.Coroutineobject $scopeobject;
    readonly kotlinx.coroutines.channels.ReceiveChannel<java.lang.object> $second;
    readonly kotlinx.coroutines.flow.FlowCollector<R> $this_unsafeFlow;
    readonly kotlin.jvm.functions.Function3<T1, T2, kotlin.coroutines.Continuation<R>, java.lang.object> $transform;
    int label;

    CombineKt$zipImpl$1$1$2(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlin.coroutines.Coroutineobject coroutineobject, java.lang.object obj, kotlinx.coroutines.channels.ReceiveChannel<? : java.lang.object> receiveChannel, kotlinx.coroutines.flow.FlowCollector<R> flowCollector, kotlin.jvm.functions.Function3<? super T1, ? super T2, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2> continuation) {
        super(2, continuation);
        this.$flow = flow;
        this.$scopeobject = coroutineobject;
        this.$cnt = obj;
        this.$second = receiveChannel;
        this.$this_unsafeFlow = flowCollector;
        this.$transform = function3;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((21 + 27) % 27 > 0) {
        }
        return new kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2(this.$flow, this.$scopeobject, this.$cnt, this.$second, this.$this_unsafeFlow, this.$transform, continuation);
    }

    public override java.lang.object Invoke(kotlin.Unit unit, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(unit, continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.Unit unit, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2) create(unit, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((10 + 28) % 28 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.Flow<T1> flow = this.$flow;
            kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2$1 combineKt$zipImpl$1$1$2$1 = new kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2$1(this.$scopeobject, this.$cnt, this.$second, this.$this_unsafeFlow, this.$transform);
            kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2 combineKt$zipImpl$1$1$2 = this;
            this.label = 1;
            if (flow.collect(combineKt$zipImpl$1$1$2$1, combineKt$zipImpl$1$1$2) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

