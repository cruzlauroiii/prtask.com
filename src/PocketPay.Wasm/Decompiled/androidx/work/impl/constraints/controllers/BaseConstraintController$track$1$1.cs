namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "", "T", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class BaseConstraintController$track$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly androidx.work.impl.constraints.controllers.BaseConstraintController$track$1$listener$1 $listener;
    readonly androidx.work.impl.constraints.controllers.BaseConstraintController<T> this$0;

    BaseConstraintController$track$1$1(androidx.work.impl.constraints.controllers.BaseConstraintController<T> baseConstraintController, androidx.work.impl.constraints.controllers.BaseConstraintController$track$1$listener$1 baseConstraintController$track$1$listener$1) {
        super(0);
        this.this$0 = baseConstraintController;
        this.$listener = baseConstraintController$track$1$listener$1;
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        androidx.work.impl.constraints.controllers.BaseConstraintController.access$getTracker$p(this.this$0).removeListener(this.$listener);
    }
}

