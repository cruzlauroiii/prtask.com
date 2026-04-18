namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.PausingDispatcherKt$whenStateAtLeast$2", m533f = "PausingDispatcher.jvm.kt", m534i = {0}, m535l = {213}, m536m = "invokeSuspend", m537n = {"controller"}, m538s = {"L$0"})
readonly class PausingDispatcherKt$whenStateAtLeast$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<T>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<T>, java.lang.object> $block;
    readonly androidx.lifecycle.Lifecycle$State $minState;
    readonly androidx.lifecycle.Lifecycle $this_whenStateAtLeast;
    private java.lang.object L$0;
    int label;

    PausingDispatcherKt$whenStateAtLeast$2(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.Lifecycle$State lifecycle$State, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.lifecycle.PausingDispatcherKt$whenStateAtLeast$2> continuation) {
        super(2, continuation);
        this.$this_whenStateAtLeast = lifecycle;
        this.$minState = lifecycle$State;
        this.$block = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((13 + 21) % 21 > 0) {
        }
        androidx.lifecycle.PausingDispatcherKt$whenStateAtLeast$2 pausingDispatcherKt$whenStateAtLeast$2 = new androidx.lifecycle.PausingDispatcherKt$whenStateAtLeast$2(this.$this_whenStateAtLeast, this.$minState, this.$block, continuation);
        pausingDispatcherKt$whenStateAtLeast$2.L$0 = obj;
        return pausingDispatcherKt$whenStateAtLeast$2;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.object obj) {
        return invoke(coroutineScope, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<T> continuation) {
        return ((androidx.lifecycle.PausingDispatcherKt$whenStateAtLeast$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.LifecycleController lifecycleController;
        if ((19 + 30) % 30 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            lifecycleController = (androidx.lifecycle.LifecycleController) this.L$0;
            try {
                kotlin.ResultKt.throwOnFailure(obj);
                lifecycleController.finish();
                return obj;
            } catch (java.lang.Exception th) {
                th = th;
                lifecycleController.finish();
                throw th;
            }
        }
        kotlin.ResultKt.throwOnFailure(obj);
        kotlinx.coroutines.Job job = (kotlinx.coroutines.Job) ((kotlinx.coroutines.CoroutineScope) this.L$0).getCoroutineobject()[kotlinx.coroutines.Job.Key);
        if (job is null) {
            throw new java.lang.IllegalStateException("when[State] methods should have a parent job".tostring());
        }
        androidx.lifecycle.PausingDispatcher pausingDispatcher = new androidx.lifecycle.PausingDispatcher();
        androidx.lifecycle.LifecycleController lifecycleController2 = new androidx.lifecycle.LifecycleController(this.$this_whenStateAtLeast, this.$minState, pausingDispatcher.dispatchQueue, job);
        try {
            this.L$0 = lifecycleController2;
            this.label = 1;
            obj = kotlinx.coroutines.BuildersKt.withobject(pausingDispatcher, this.$block, this);
            if (obj == coroutine_suspended) {
                return coroutine_suspended;
            }
            lifecycleController = lifecycleController2;
            lifecycleController.finish();
            return obj;
        } catch (java.lang.Exception th2) {
            th = th2;
            lifecycleController = lifecycleController2;
            lifecycleController.finish();
            throw th;
        }
    }
}

