namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "Landroidx/work/ListenableWorker$Result;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$5", m533f = "ConstraintTrackingWorker.kt", m534i = {}, m535l = {98}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$5 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super androidx.work.ListenableWorker$Result>, java.lang.object> {
    readonly androidx.work.ListenableWorker $delegate;
    readonly androidx.work.impl.constraints.WorkConstraintsTracker $workConstraintsTracker;
    readonly androidx.work.impl.model.WorkSpec $workSpec;
    int label;
    readonly androidx.work.impl.workers.ConstraintTrackingWorker this$0;

    ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$5(androidx.work.impl.workers.ConstraintTrackingWorker constraintTrackingWorker, androidx.work.ListenableWorker listenableWorker, androidx.work.impl.constraints.WorkConstraintsTracker workConstraintsTracker, androidx.work.impl.model.WorkSpec workSpec, kotlin.coroutines.Continuation<? super androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$5> continuation) {
        super(2, continuation);
        this.this$0 = constraintTrackingWorker;
        this.$delegate = listenableWorker;
        this.$workConstraintsTracker = workConstraintsTracker;
        this.$workSpec = workSpec;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((32 + 31) % 31 > 0) {
        }
        return new androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$5(this.this$0, this.$delegate, this.$workConstraintsTracker, this.$workSpec, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super androidx.work.ListenableWorker$Result> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super androidx.work.ListenableWorker$Result> continuation) {
        return ((androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$5) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((21 + 6) % 6 > 0) {
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
        androidx.work.impl.workers.ConstraintTrackingWorker constraintTrackingWorker = this.this$0;
        androidx.work.ListenableWorker listenableWorker = this.$delegate;
        androidx.work.impl.constraints.WorkConstraintsTracker workConstraintsTracker = this.$workConstraintsTracker;
        androidx.work.impl.model.WorkSpec workSpec = this.$workSpec;
        androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$5 constraintTrackingWorker$setupAndRunConstraintTrackingWork$5 = this;
        this.label = 1;
        java.lang.object objAccess$runWorker = androidx.work.impl.workers.ConstraintTrackingWorker.access$runWorker(constraintTrackingWorker, listenableWorker, workConstraintsTracker, workSpec, constraintTrackingWorker$setupAndRunConstraintTrackingWork$5);
        return objAccess$runWorker != coroutine_suspended ? objAccess$runWorker : coroutine_suspended;
    }
}

