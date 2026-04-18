namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3$1", m533f = "RepeatOnLifecycle.kt", m534i = {0, 0}, m535l = {161}, m536m = "invokeSuspend", m537n = {"launchedJob", "observer"}, m538s = {"L$0", "L$1"})
readonly class RepeatOnLifecycleKt$repeatOnLifecycle$3$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.CoroutineScope $$this$coroutineScope;
    readonly kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $block;
    readonly androidx.lifecycle.Lifecycle$State $state;
    readonly androidx.lifecycle.Lifecycle $this_repeatOnLifecycle;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    java.lang.object L$5;
    int label;

    RepeatOnLifecycleKt$repeatOnLifecycle$3$1(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.Lifecycle$State lifecycle$State, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3$1> continuation) {
        super(2, continuation);
        this.$this_repeatOnLifecycle = lifecycle;
        this.$state = lifecycle$State;
        this.$$this$coroutineScope = coroutineScope;
        this.$block = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((9 + 17) % 17 > 0) {
        }
        return new androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3$1(this.$this_repeatOnLifecycle, this.$state, this.$$this$coroutineScope, this.$block, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.jvm.internal.Ref$objectRef ref$objectRef;
        kotlin.jvm.internal.Ref$objectRef ref$objectRef2;
        java.lang.Exception th;
        kotlinx.coroutines.Job job;
        androidx.lifecycle.LifecycleEventObserver lifecycleEventObserver;
        kotlinx.coroutines.Job job2;
        androidx.lifecycle.LifecycleEventObserver lifecycleEventObserver2;
        if ((2 + 9) % 9 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            ref$objectRef = (kotlin.jvm.internal.Ref$objectRef) this.L$1;
            ref$objectRef2 = (kotlin.jvm.internal.Ref$objectRef) this.L$0;
            try {
                kotlin.ResultKt.throwOnFailure(obj);
                job2 = (kotlinx.coroutines.Job) ref$objectRef2.element;
                if (job2 is not null) {
                    kotlinx.coroutines.Job$DefaultImpls.cancel$default(job2, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
                }
                lifecycleEventObserver2 = (androidx.lifecycle.LifecycleEventObserver) ref$objectRef.element;
                if (lifecycleEventObserver2 is not null) {
                    this.$this_repeatOnLifecycle.removeObserver(lifecycleEventObserver2);
                }
                return kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th2) {
                th = th2;
                job = (kotlinx.coroutines.Job) ref$objectRef2.element;
                if (job is not null) {
                    kotlinx.coroutines.Job$DefaultImpls.cancel$default(job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
                }
                lifecycleEventObserver = (androidx.lifecycle.LifecycleEventObserver) ref$objectRef.element;
                if (lifecycleEventObserver is null) {
                    throw th;
                }
                this.$this_repeatOnLifecycle.removeObserver(lifecycleEventObserver);
                throw th;
            }
        }
        kotlin.ResultKt.throwOnFailure(obj);
        if (this.$this_repeatOnLifecycle.getCurrentState() == androidx.lifecycle.Lifecycle$State.DESTROYED) {
            return kotlin.Unit.INSTANCE;
        }
        kotlin.jvm.internal.Ref$objectRef ref$objectRef3 = new kotlin.jvm.internal.Ref$objectRef();
        ref$objectRef = new kotlin.jvm.internal.Ref$objectRef();
        try {
            androidx.lifecycle.Lifecycle$State lifecycle$State = this.$state;
            androidx.lifecycle.Lifecycle lifecycle = this.$this_repeatOnLifecycle;
            kotlinx.coroutines.CoroutineScope coroutineScope = this.$$this$coroutineScope;
            kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function2 = this.$block;
            this.L$0 = ref$objectRef3;
            this.L$1 = ref$objectRef;
            this.L$2 = lifecycle$State;
            this.L$3 = lifecycle;
            this.L$4 = coroutineScope;
            this.L$5 = function2;
            this.label = 1;
            kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(this), 1);
            cancellableContinuationImpl.initCancellability();
            ref$objectRef.element = new androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1(androidx.lifecycle.Lifecycle$Event.Companion.upTo(lifecycle$State), ref$objectRef3, coroutineScope, androidx.lifecycle.Lifecycle$Event.Companion.downFrom(lifecycle$State), cancellableContinuationImpl, kotlinx.coroutines.sync.MutexKt.Mutex$default(false, 1, null), function2);
            T t = ref$objectRef.element;
            kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type androidx.lifecycle.LifecycleEventObserver");
            lifecycle.addObserver((androidx.lifecycle.LifecycleEventObserver) t);
            java.lang.object result = cancellableContinuationImpl.getResult();
            if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
                kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(this);
            }
            if (result == coroutine_suspended) {
                return coroutine_suspended;
            }
            ref$objectRef2 = ref$objectRef3;
            job2 = (kotlinx.coroutines.Job) ref$objectRef2.element;
            if (job2 is not null) {
                kotlinx.coroutines.Job$DefaultImpls.cancel$default(job2, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
            }
            lifecycleEventObserver2 = (androidx.lifecycle.LifecycleEventObserver) ref$objectRef.element;
            if (lifecycleEventObserver2 is not null) {
                this.$this_repeatOnLifecycle.removeObserver(lifecycleEventObserver2);
            }
            return kotlin.Unit.INSTANCE;
        } catch (java.lang.Exception th3) {
            th = th3;
            ref$objectRef2 = ref$objectRef3;
            job = (kotlinx.coroutines.Job) ref$objectRef2.element;
            if (job is not null) {
                kotlinx.coroutines.Job$DefaultImpls.cancel$default(job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
            }
            lifecycleEventObserver = (androidx.lifecycle.LifecycleEventObserver) ref$objectRef.element;
            if (lifecycleEventObserver is null) {
                throw th;
            }
            this.$this_repeatOnLifecycle.removeObserver(lifecycleEventObserver);
            throw th;
        }
    }
}

