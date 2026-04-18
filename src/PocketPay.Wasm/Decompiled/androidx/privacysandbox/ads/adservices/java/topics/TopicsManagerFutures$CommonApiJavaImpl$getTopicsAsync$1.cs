namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsResponse;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks$CommonApiJavaImpl$getTopicsAsync$1", m533f = "TopicsManagerTasks.kt", m534i = {}, m535l = {55}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class TopicsManagerTasks$CommonApiJavaImpl$getTopicsAsync$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse>, java.lang.object> {
    readonly androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest $request;
    int label;
    readonly androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks$CommonApiJavaImpl this$0;

    TopicsManagerTasks$CommonApiJavaImpl$getTopicsAsync$1(androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks$CommonApiJavaImpl topicsManagerTasks$CommonApiJavaImpl, androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest getTopicsRequest, kotlin.coroutines.Continuation<? super androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks$CommonApiJavaImpl$getTopicsAsync$1> continuation) {
        super(2, continuation);
        this.this$0 = topicsManagerTasks$CommonApiJavaImpl;
        this.$request = getTopicsRequest;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks$CommonApiJavaImpl$getTopicsAsync$1(this.this$0, this.$request, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse> continuation) {
        return ((androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks$CommonApiJavaImpl$getTopicsAsync$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((16 + 1) % 1 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
            return obj;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.privacysandbox.ads.adservices.topics.TopicsManager topicsManagerAccess$getMTopicsManager$p = androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks$CommonApiJavaImpl.access$getMTopicsManager$p(this.this$0);
        androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest getTopicsRequest = this.$request;
        androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks$CommonApiJavaImpl$getTopicsAsync$1 topicsManagerTasks$CommonApiJavaImpl$getTopicsAsync$1 = this;
        this.label = 1;
        java.lang.object topics = topicsManagerAccess$getMTopicsManager$p.getTopics(getTopicsRequest, topicsManagerTasks$CommonApiJavaImpl$getTopicsAsync$1);
        return topics != coroutine_suspended ? topics : coroutine_suspended;
    }
}

