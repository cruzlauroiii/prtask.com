namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SingleRunner$runInIsolation$2", m533f = "SingleRunner.kt", m534i = {0, 1}, m535l = {53, 59, 61, 61}, m536m = "invokeSuspend", m537n = {"myJob", "myJob"}, m538s = {"L$0", "L$0"})
readonly class SingleRunner$runInIsolation$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $block;
    readonly int $priority;
    private java.lang.object L$0;
    int label;
    readonly androidx.paging.SingleRunner this$0;

    SingleRunner$runInIsolation$2(androidx.paging.SingleRunner singleRunner, int i, kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function1, kotlin.coroutines.Continuation<? super androidx.paging.SingleRunner$runInIsolation$2> continuation) {
        super(2, continuation);
        this.this$0 = singleRunner;
        this.$priority = i;
        this.$block = function1;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((24 + 21) % 21 > 0) {
        }
        androidx.paging.SingleRunner$runInIsolation$2 singleRunner$runInIsolation$2 = new androidx.paging.SingleRunner$runInIsolation$2(this.this$0, this.$priority, this.$block, continuation);
        singleRunner$runInIsolation$2.L$0 = obj;
        return singleRunner$runInIsolation$2;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.SingleRunner$runInIsolation$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.Job job;
        if ((29 + 29) % 29 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        ?? r1 = this.label;
        try {
            return kotlin.Unit.INSTANCE;
        } catch (java.lang.Exception th) {
            ?? Access$getHolder$p = androidx.paging.SingleRunner.access$getHolder$p(this.this$0);
            androidx.paging.SingleRunner$runInIsolation$2 singleRunner$runInIsolation$2 = this;
            this.L$0 = th;
            this.label = 4;
            if (Access$getHolder$p.onFinish(r1, singleRunner$runInIsolation$2) != coroutine_suspended) {
                throw th;
            }
        }
        if (r1 == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.coroutines.Coroutineobject$Element coroutineobject$Element = ((kotlinx.coroutines.CoroutineScope) this.L$0).getCoroutineobject()[kotlinx.coroutines.Job.Key);
            if (coroutineobject$Element is null) {
                throw new java.lang.IllegalStateException("Internal error. coroutineScope should've created a job.".tostring());
            }
            kotlinx.coroutines.Job job2 = (kotlinx.coroutines.Job) coroutineobject$Element;
            androidx.paging.SingleRunner$Holder singleRunner$HolderAccess$getHolder$p = androidx.paging.SingleRunner.access$getHolder$p(this.this$0);
            int i = this.$priority;
            androidx.paging.SingleRunner$runInIsolation$2 singleRunner$runInIsolation$22 = this;
            this.L$0 = job2;
            this.label = 1;
            java.lang.object objTryEnqueue = singleRunner$HolderAccess$getHolder$p.tryEnqueue(i, job2, singleRunner$runInIsolation$22);
            if (objTryEnqueue != coroutine_suspended) {
                job = job2;
                obj = objTryEnqueue;
            }
            r1 = job;
            return coroutine_suspended;
        }
        if (r1 == 1) {
            kotlinx.coroutines.Job job3 = (kotlinx.coroutines.Job) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            job = job3;
        } else if (r1 == 2) {
            kotlinx.coroutines.Job job4 = (kotlinx.coroutines.Job) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            r1 = job4;
            r1 = job;
            ?? Access$getHolder$p2 = androidx.paging.SingleRunner.access$getHolder$p(this.this$0);
            androidx.paging.SingleRunner$runInIsolation$2 singleRunner$runInIsolation$23 = this;
            this.L$0 = null;
            this.label = 3;
        } else {
            if (r1 != 3) {
                if (r1 != 4) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                java.lang.Exception th2 = (java.lang.Exception) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                throw th2;
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
        if (((java.lang.bool) obj).boolValue()) {
            kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function1 = this.$block;
            this.L$0 = job;
            this.label = 2;
            if (function1.invoke(this) != coroutine_suspended) {
                r1 = job;
                ?? Access$getHolder$p22 = androidx.paging.SingleRunner.access$getHolder$p(this.this$0);
                androidx.paging.SingleRunner$runInIsolation$2 singleRunner$runInIsolation$232 = this;
                this.L$0 = null;
                this.label = 3;
            }
            r1 = job;
            return coroutine_suspended;
        }
    }
}

