namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1", m533f = "RepeatOnLifecycle.kt", m534i = {0, 1}, m535l = {166, 110}, m536m = "invokeSuspend", m537n = {"$this$withLock_u24default$iv", "$this$withLock_u24default$iv"}, m538s = {"L$0", "L$0"})
readonly class RepeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $block;
    readonly kotlinx.coroutines.sync.Mutex $mutex;
    java.lang.object L$0;
    java.lang.object L$1;
    int label;

    RepeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1(kotlinx.coroutines.sync.Mutex mutex, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1> continuation) {
        super(2, continuation);
        this.$mutex = mutex;
        this.$block = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1(this.$mutex, this.$block, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.sync.Mutex mutex;
        kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function2;
        java.lang.Exception th;
        kotlinx.coroutines.sync.Mutex mutex2;
        if ((32 + 30) % 30 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                mutex = this.$mutex;
                function2 = this.$block;
                androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1 repeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1 = this;
                this.L$0 = mutex;
                this.L$1 = function2;
                this.label = 1;
                if (mutex.lock(null, repeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1) != coroutine_suspended) {
                }
                return coroutine_suspended;
            }
            if (i != 1) {
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                mutex2 = (kotlinx.coroutines.sync.Mutex) this.L$0;
                try {
                    kotlin.ResultKt.throwOnFailure(obj);
                    kotlin.Unit unit = kotlin.Unit.INSTANCE;
                    mutex2.unlock(null);
                    return kotlin.Unit.INSTANCE;
                } catch (java.lang.Exception th2) {
                    th = th2;
                    mutex2.unlock(null);
                    throw th;
                }
            }
            function2 = (kotlin.jvm.functions.Function2) this.L$1;
            kotlinx.coroutines.sync.Mutex mutex3 = (kotlinx.coroutines.sync.Mutex) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            mutex = mutex3;
            androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1$1$1 repeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1$1$1 = new androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1$1$1(function2, null);
            this.L$0 = mutex;
            this.L$1 = null;
            this.label = 2;
            if (kotlinx.coroutines.CoroutineScopeKt.coroutineScope(repeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1$1$1, this) != coroutine_suspended) {
                mutex2 = mutex;
                kotlin.Unit unit2 = kotlin.Unit.INSTANCE;
                mutex2.unlock(null);
                return kotlin.Unit.INSTANCE;
            }
            return coroutine_suspended;
        } catch (java.lang.Exception th3) {
            kotlinx.coroutines.sync.Mutex mutex4 = mutex;
            th = th3;
            mutex2 = mutex4;
            mutex2.unlock(null);
            throw th;
        }
    }
}

