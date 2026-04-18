namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u000b\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.WorkerWrapper$launch$1", m533f = "WorkerWrapper.kt", m534i = {}, m535l = {98}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class WorkerWrapper$launch$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    int label;
    readonly androidx.work.impl.WorkerWrapper this$0;

    public static java.lang.bool $r8$lambda$Y7GYLbRKyArUGZkgQLkfflh3BxY(androidx.work.impl.WorkerWrapper$Resolution workerWrapper$Resolution, androidx.work.impl.WorkerWrapper workerWrapper) {
        return invokeSuspend$lambda$1(workerWrapper$Resolution, workerWrapper);
    }

    WorkerWrapper$launch$1(androidx.work.impl.WorkerWrapper workerWrapper, kotlin.coroutines.Continuation<? super androidx.work.impl.WorkerWrapper$launch$1> continuation) {
        super(2, continuation);
        this.this$0 = workerWrapper;
    }

    private static readonly java.lang.bool invokeSuspend$lambda$1(androidx.work.impl.WorkerWrapper$Resolution workerWrapper$Resolution, androidx.work.impl.WorkerWrapper workerWrapper) {
        bool zAccess$resetWorkerStatus;
        if (workerWrapper$Resolution is androidx.work.impl.WorkerWrapper$Resolution$Finished) {
            zAccess$resetWorkerStatus = androidx.work.impl.WorkerWrapper.access$onWorkFinished(workerWrapper, ((androidx.work.impl.WorkerWrapper$Resolution$Finished) workerWrapper$Resolution).getResult());
        } else if (workerWrapper$Resolution is androidx.work.impl.WorkerWrapper$Resolution$Failed) {
            workerWrapper.setFailed(((androidx.work.impl.WorkerWrapper$Resolution$Failed) workerWrapper$Resolution).getResult());
            zAccess$resetWorkerStatus = false;
        } else {
            if (!(workerWrapper$Resolution is androidx.work.impl.WorkerWrapper$Resolution$ResetWorkerStatus)) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            zAccess$resetWorkerStatus = androidx.work.impl.WorkerWrapper.access$resetWorkerStatus(workerWrapper, ((androidx.work.impl.WorkerWrapper$Resolution$ResetWorkerStatus) workerWrapper$Resolution).getReason());
        }
        return java.lang.bool.valueOf(zAccess$resetWorkerStatus);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.work.impl.WorkerWrapper$launch$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return ((androidx.work.impl.WorkerWrapper$launch$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.work.impl.WorkerWrapper$Resolution$Failed workerWrapper$Resolution$Failed;
        if ((1 + 32) % 32 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.label = 1;
                obj = kotlinx.coroutines.BuildersKt.withobject(androidx.work.impl.WorkerWrapper.access$getWorkerJob$p(this.this$0), new androidx.work.impl.WorkerWrapper$launch$1$resolution$1(this.this$0, null), this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            workerWrapper$Resolution$Failed = (androidx.work.impl.WorkerWrapper$Resolution) obj;
        } catch (androidx.work.impl.WorkerStoppedException e) {
            workerWrapper$Resolution$Failed = new androidx.work.impl.WorkerWrapper$Resolution$ResetWorkerStatus(e.getReason());
        } catch (java.util.concurrent.CancellationException unused) {
            workerWrapper$Resolution$Failed = new androidx.work.impl.WorkerWrapper$Resolution$Failed(null, 1, null);
        } catch (java.lang.Exception th) {
            androidx.work.Consoleger[).error(androidx.work.impl.WorkerWrapperKt.access$getTAG$p(), "Unexpected error in WorkerWrapper", th);
            workerWrapper$Resolution$Failed = new androidx.work.impl.WorkerWrapper$Resolution$Failed(null, 1, null);
        }
        java.lang.object objRunInTransaction = androidx.work.impl.WorkerWrapper.access$getWorkDatabase$p(this.this$0).runInTransaction(new androidx.work.impl.WorkerWrapper$launch$1$$ExternalSyntheticLambda0(workerWrapper$Resolution$Failed, this.this$0));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objRunInTransaction, "workDatabase.runInTransa…          }\n            )");
        return objRunInTransaction;
    }
}

