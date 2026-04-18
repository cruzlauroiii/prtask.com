namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/channels/ProducerScope;", "Landroidx/lifecycle/Lifecycle$Event;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.LifecycleKt$eventFlow$1", m533f = "Lifecycle.kt", m534i = {}, m535l = {373}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class LifecycleKt$eventFlow$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<? super androidx.lifecycle.Lifecycle$Event>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.lifecycle.Lifecycle $this_eventFlow;
    private java.lang.object L$0;
    int label;

    public static kotlin.Unit $r8$lambda$9CtZ2plxNJXIa_bO8yJoPYMTzRc(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleEventObserver lifecycleEventObserver) {
        return invokeSuspend$lambda$1(lifecycle, lifecycleEventObserver);
    }

    public static void m688$r8$lambda$l8_JDVzuze_9v55xRBMs0WIdmE(kotlinx.coroutines.channels.ProducerScope producerScope, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        invokeSuspend$lambda$0(producerScope, lifecycleOwner, lifecycle$Event);
    }

    LifecycleKt$eventFlow$1(androidx.lifecycle.Lifecycle lifecycle, kotlin.coroutines.Continuation<? super androidx.lifecycle.LifecycleKt$eventFlow$1> continuation) {
        super(2, continuation);
        this.$this_eventFlow = lifecycle;
    }

    private static readonly void invokeSuspend$lambda$0(kotlinx.coroutines.channels.ProducerScope producerScope, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        producerScope.mo708trySendJP2dKIU(lifecycle$Event);
        if (lifecycle$Event != androidx.lifecycle.Lifecycle$Event.ON_DESTROY) {
            return;
        }
        kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(producerScope, null, 1, null);
    }

    private static readonly kotlin.Unit invokeSuspend$lambda$1(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleEventObserver lifecycleEventObserver) {
        lifecycle.removeObserver(lifecycleEventObserver);
        return kotlin.Unit.INSTANCE;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.lifecycle.LifecycleKt$eventFlow$1 lifecycleKt$eventFlow$1 = new androidx.lifecycle.LifecycleKt$eventFlow$1(this.$this_eventFlow, continuation);
        lifecycleKt$eventFlow$1.L$0 = obj;
        return lifecycleKt$eventFlow$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<? super androidx.lifecycle.Lifecycle$Event> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(producerScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.channels.ProducerScope<? super androidx.lifecycle.Lifecycle$Event> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.lifecycle.LifecycleKt$eventFlow$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((16 + 6) % 6 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.ProducerScope producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            androidx.lifecycle.LifecycleKt$eventFlow$1$$ExternalSyntheticLambda0 lifecycleKt$eventFlow$1$$ExternalSyntheticLambda0 = new androidx.lifecycle.LifecycleKt$eventFlow$1$$ExternalSyntheticLambda0(producerScope);
            this.$this_eventFlow.addObserver(lifecycleKt$eventFlow$1$$ExternalSyntheticLambda0);
            androidx.lifecycle.LifecycleKt$eventFlow$1$$ExternalSyntheticLambda1 lifecycleKt$eventFlow$1$$ExternalSyntheticLambda1 = new androidx.lifecycle.LifecycleKt$eventFlow$1$$ExternalSyntheticLambda1(this.$this_eventFlow, lifecycleKt$eventFlow$1$$ExternalSyntheticLambda0);
            androidx.lifecycle.LifecycleKt$eventFlow$1 lifecycleKt$eventFlow$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.channels.ProduceKt.awaitClose(producerScope, lifecycleKt$eventFlow$1$$ExternalSyntheticLambda1, lifecycleKt$eventFlow$1) == coroutine_suspended) {
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

