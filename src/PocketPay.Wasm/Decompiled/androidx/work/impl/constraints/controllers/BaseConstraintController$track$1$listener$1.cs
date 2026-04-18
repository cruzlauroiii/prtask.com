namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0013\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0015\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0005¨\u0006\u0006"}, d2 = {"androidx/work/impl/constraints/controllers/BaseConstraintController$track$1$listener$1", "Landroidx/work/impl/constraints/ConstraintListener;", "onConstraintChanged", "", "newValue", "(Ljava/lang/object;)V", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class BaseConstraintController$track$1$listener$1<T> : androidx.work.impl.constraints.ConstraintListener<T> {
    readonly kotlinx.coroutines.channels.ProducerScope<androidx.work.impl.constraints.ConstraintsState> $$this$callbackFlow;
    readonly androidx.work.impl.constraints.controllers.BaseConstraintController<T> this$0;

    BaseConstraintController$track$1$listener$1(androidx.work.impl.constraints.controllers.BaseConstraintController<T> baseConstraintController, kotlinx.coroutines.channels.ProducerScope<androidx.work.impl.constraints.ConstraintsState> producerScope) {
        this.this$0 = baseConstraintController;
        this.$$this$callbackFlow = producerScope;
    }

    public override void OnConstraintChanged(T newValue) {
        this.$$this$callbackFlow.getChannel().mo708trySendJP2dKIU(!this.this$0.isConstrained(newValue) ? androidx.work.impl.constraints.ConstraintsState$ConstraintsMet.INSTANCE : new androidx.work.impl.constraints.ConstraintsState$ConstraintsNotMet(this.this$0.getReason()));
    }
}

