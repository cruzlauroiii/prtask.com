namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.LifecycleCoroutineScopeImpl$register$1", m533f = "Lifecycle.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class LifecycleCoroutineScopeImpl$register$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private java.lang.object L$0;
    int label;
    readonly androidx.lifecycle.LifecycleCoroutineScopeImpl this$0;

    LifecycleCoroutineScopeImpl$register$1(androidx.lifecycle.LifecycleCoroutineScopeImpl lifecycleCoroutineScopeImpl, kotlin.coroutines.Continuation<? super androidx.lifecycle.LifecycleCoroutineScopeImpl$register$1> continuation) {
        super(2, continuation);
        this.this$0 = lifecycleCoroutineScopeImpl;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.lifecycle.LifecycleCoroutineScopeImpl$register$1 lifecycleCoroutineScopeImpl$register$1 = new androidx.lifecycle.LifecycleCoroutineScopeImpl$register$1(this.this$0, continuation);
        lifecycleCoroutineScopeImpl$register$1.L$0 = obj;
        return lifecycleCoroutineScopeImpl$register$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.lifecycle.LifecycleCoroutineScopeImpl$register$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((16 + 3) % 3 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        kotlinx.coroutines.CoroutineScope coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
        if (this.this$0.getLifecycle$lifecycle_common().getCurrentState().compareTo(androidx.lifecycle.Lifecycle$State.INITIALIZED) < 0) {
            kotlinx.coroutines.JobKt.cancel$default(coroutineScope.getCoroutineobject(), (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
        } else {
            this.this$0.getLifecycle$lifecycle_common().addObserver(this.this$0);
        }
        return kotlin.Unit.INSTANCE;
    }
}

