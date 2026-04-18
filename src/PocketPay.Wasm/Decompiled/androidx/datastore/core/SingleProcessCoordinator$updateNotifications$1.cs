namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00010\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/flow/FlowCollector;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.SingleProcessCoordinator$updateNotifications$1", m533f = "SingleProcessCoordinator.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class SingleProcessCoordinator$updateNotifications$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<kotlin.Unit>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int label;

    SingleProcessCoordinator$updateNotifications$1(kotlin.coroutines.Continuation<? super androidx.datastore.core.SingleProcessCoordinator$updateNotifications$1> continuation) {
        super(2, continuation);
    }

    public static java.lang.object KmvvCBgNfaxPWMnI(androidx.datastore.core.SingleProcessCoordinator$updateNotifications$1 singleProcessCoordinator$updateNotifications$1, kotlinx.coroutines.flow.FlowCollector flowCollector, kotlin.coroutines.Continuation continuation) {
        return singleProcessCoordinator$updateNotifications$1.invoke2((kotlinx.coroutines.flow.FlowCollector<kotlin.Unit>) flowCollector, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.object UUBAzhUHRssyRueU() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void YTbVXlLaSvXKFgDh(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation ZQdExgzuVJrjqchO(androidx.datastore.core.SingleProcessCoordinator$updateNotifications$1 singleProcessCoordinator$updateNotifications$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return singleProcessCoordinator$updateNotifications$1.create(obj, continuation);
    }

    public static java.lang.object ZbZsoQtDjGXuBGVk(androidx.datastore.core.SingleProcessCoordinator$updateNotifications$1 singleProcessCoordinator$updateNotifications$1, java.lang.object obj) {
        return singleProcessCoordinator$updateNotifications$1.invokeSuspend(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.core.SingleProcessCoordinator$updateNotifications$1(continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<kotlin.Unit> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return KmvvCBgNfaxPWMnI(this, flowCollector, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.flow.FlowCollector<kotlin.Unit> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return zbZsoQtDjGXuBGVk((androidx.datastore.core.SingleProcessCoordinator$updateNotifications$1) zQdExgzuVJrjqchO(this, flowCollector, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        UUBAzhUHRssyRueU();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        yTbVXlLaSvXKFgDh(obj);
        return kotlin.Unit.INSTANCE;
    }
}

