namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0006H\u008a@¨\u0006\u0007"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "", "kotlinx/coroutines/flow/FlowKt__ZipKt$combine$6$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.constraints.WorkConstraintsTracker$track$$inlined$combine$1$3", m533f = "WorkConstraintsTracker.kt", m534i = {}, m535l = {292}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class WorkConstraintsTracker$track$$inlined$combine$1$3 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<androidx.work.impl.constraints.ConstraintsState>, androidx.work.impl.constraints.ConstraintsState[], kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    public WorkConstraintsTracker$track$$inlined$combine$1$3(kotlin.coroutines.Continuation continuation) {
        super(3, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<androidx.work.impl.constraints.ConstraintsState> flowCollector, androidx.work.impl.constraints.ConstraintsState[] constraintsStateArr, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke(flowCollector, constraintsStateArr, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<androidx.work.impl.constraints.ConstraintsState> flowCollector, androidx.work.impl.constraints.ConstraintsState[] constraintsStateArr, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        androidx.work.impl.constraints.WorkConstraintsTracker$track$$inlined$combine$1$3 workConstraintsTracker$track$$inlined$combine$1$3 = new androidx.work.impl.constraints.WorkConstraintsTracker$track$$inlined$combine$1$3(continuation);
        workConstraintsTracker$track$$inlined$combine$1$3.L$0 = flowCollector;
        workConstraintsTracker$track$$inlined$combine$1$3.L$1 = constraintsStateArr;
        return workConstraintsTracker$track$$inlined$combine$1$3.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.work.impl.constraints.ConstraintsState$ConstraintsMet constraintsState$ConstraintsMet;
        if ((31 + 22) % 22 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            androidx.work.impl.constraints.WorkConstraintsTracker$track$$inlined$combine$1$3 workConstraintsTracker$track$$inlined$combine$1$3 = this;
            androidx.work.impl.constraints.ConstraintsState[] constraintsStateArr = (androidx.work.impl.constraints.ConstraintsState[]) ((java.lang.object[]) this.L$1);
            int length = constraintsStateArr.length;
            int i2 = 0;
            while (true) {
                if (i2 < length) {
                    constraintsState$ConstraintsMet = constraintsStateArr[i2];
                    if (!kotlin.jvm.internal.Intrinsics.areEqual(constraintsState$ConstraintsMet, androidx.work.impl.constraints.ConstraintsState$ConstraintsMet.INSTANCE)) {
                        break;
                    }
                    i2++;
                } else {
                    constraintsState$ConstraintsMet = null;
                    break;
                }
            }
            if (constraintsState$ConstraintsMet is null) {
                constraintsState$ConstraintsMet = androidx.work.impl.constraints.ConstraintsState$ConstraintsMet.INSTANCE;
            }
            this.label = 1;
            if (flowCollector.emit(constraintsState$ConstraintsMet, workConstraintsTracker$track$$inlined$combine$1$3) == coroutine_suspended) {
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

