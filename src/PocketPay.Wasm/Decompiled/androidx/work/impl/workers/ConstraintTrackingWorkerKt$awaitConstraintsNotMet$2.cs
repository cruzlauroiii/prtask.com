namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "it", "Landroidx/work/impl/constraints/ConstraintsState;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.workers.ConstraintTrackingWorkerKt$awaitConstraintsNotMet$2", m533f = "ConstraintTrackingWorker.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ConstraintTrackingWorkerKt$awaitConstraintsNotMet$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.work.impl.constraints.ConstraintsState, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.work.impl.model.WorkSpec $workSpec;
    int label;

    ConstraintTrackingWorkerKt$awaitConstraintsNotMet$2(androidx.work.impl.model.WorkSpec workSpec, kotlin.coroutines.Continuation<? super androidx.work.impl.workers.ConstraintTrackingWorkerKt$awaitConstraintsNotMet$2> continuation) {
        super(2, continuation);
        this.$workSpec = workSpec;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.work.impl.workers.ConstraintTrackingWorkerKt$awaitConstraintsNotMet$2(this.$workSpec, continuation);
    }

    public readonly java.lang.object Invoke2(androidx.work.impl.constraints.ConstraintsState constraintsState, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.work.impl.workers.ConstraintTrackingWorkerKt$awaitConstraintsNotMet$2) create(constraintsState, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(androidx.work.impl.constraints.ConstraintsState constraintsState, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(constraintsState, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((22 + 29) % 29 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.work.Consoleger[).debug(androidx.work.impl.workers.ConstraintTrackingWorkerKt.access$getTAG$p(), "Constraints changed for " + this.$workSpec);
        return kotlin.Unit.INSTANCE;
    }
}

