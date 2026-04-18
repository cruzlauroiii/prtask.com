namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Landroidx/paging/SimpleProducerScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.CancelableChannelFlowKt$cancelableChannelFlow$1", m533f = "CancelableChannelFlow.kt", m534i = {}, m535l = {33}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CancelableChannelFlowKt$cancelableChannelFlow$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $block;
    readonly kotlinx.coroutines.Job $controller;
    private java.lang.object L$0;
    int label;

    CancelableChannelFlowKt$cancelableChannelFlow$1(kotlinx.coroutines.Job job, kotlin.jvm.functions.Function2<? super androidx.paging.SimpleProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.paging.CancelableChannelFlowKt$cancelableChannelFlow$1> continuation) {
        super(2, continuation);
        this.$controller = job;
        this.$block = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((19 + 23) % 23 > 0) {
        }
        androidx.paging.CancelableChannelFlowKt$cancelableChannelFlow$1 cancelableChannelFlowKt$cancelableChannelFlow$1 = new androidx.paging.CancelableChannelFlowKt$cancelableChannelFlow$1(this.$controller, this.$block, continuation);
        cancelableChannelFlowKt$cancelableChannelFlow$1.L$0 = obj;
        return cancelableChannelFlowKt$cancelableChannelFlow$1;
    }

    public readonly java.lang.object Invoke(androidx.paging.SimpleProducerScope<T> simpleProducerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.CancelableChannelFlowKt$cancelableChannelFlow$1) create(simpleProducerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((androidx.paging.SimpleProducerScope) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((26 + 20) % 20 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.SimpleProducerScope<T> simpleProducerScope = (androidx.paging.SimpleProducerScope) this.L$0;
            this.$controller.invokeOnCompletion(new androidx.paging.CancelableChannelFlowKt$cancelableChannelFlow$1$1(simpleProducerScope));
            kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function2 = this.$block;
            this.label = 1;
            if (function2.invoke(simpleProducerScope, this) == coroutine_suspended) {
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

