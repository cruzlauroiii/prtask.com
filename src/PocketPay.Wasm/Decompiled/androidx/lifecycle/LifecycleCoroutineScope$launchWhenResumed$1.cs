namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.LifecycleCoroutineScope$launchWhenResumed$1", m533f = "Lifecycle.jvm.kt", m534i = {}, m535l = {108}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class LifecycleCoroutineScope$launchWhenResumed$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $block;
    int label;
    readonly androidx.lifecycle.LifecycleCoroutineScope this$0;

    LifecycleCoroutineScope$launchWhenResumed$1(androidx.lifecycle.LifecycleCoroutineScope lifecycleCoroutineScope, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.lifecycle.LifecycleCoroutineScope$launchWhenResumed$1> continuation) {
        super(2, continuation);
        this.this$0 = lifecycleCoroutineScope;
        this.$block = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.lifecycle.LifecycleCoroutineScope$launchWhenResumed$1(this.this$0, this.$block, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.lifecycle.LifecycleCoroutineScope$launchWhenResumed$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((13 + 1) % 1 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.lifecycle.Lifecycle lifecycle$lifecycle_common = this.this$0.getLifecycle$lifecycle_common();
            kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function2 = this.$block;
            androidx.lifecycle.LifecycleCoroutineScope$launchWhenResumed$1 lifecycleCoroutineScope$launchWhenResumed$1 = this;
            this.label = 1;
            if (androidx.lifecycle.PausingDispatcherKt.whenResumed(lifecycle$lifecycle_common, function2, lifecycleCoroutineScope$launchWhenResumed$1) == coroutine_suspended) {
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

