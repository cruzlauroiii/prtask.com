namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "it", "Landroidx/work/impl/constraints/ConstraintsState;", "emit", "(Landroidx/work/impl/constraints/ConstraintsState;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class WorkConstraintsTrackerKt$listen$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly androidx.work.impl.constraints.OnConstraintsStateChangedListener $listener;
    readonly androidx.work.impl.model.WorkSpec $spec;

    WorkConstraintsTrackerKt$listen$1$1(androidx.work.impl.constraints.OnConstraintsStateChangedListener onConstraintsStateChangedListener, androidx.work.impl.model.WorkSpec workSpec) {
        this.$listener = onConstraintsStateChangedListener;
        this.$spec = workSpec;
    }

    public readonly java.lang.object Emit(androidx.work.impl.constraints.ConstraintsState constraintsState, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        this.$listener.onConstraintsStateChanged(this.$spec, constraintsState);
        return kotlin.Unit.INSTANCE;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit((androidx.work.impl.constraints.ConstraintsState) obj, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }
}

