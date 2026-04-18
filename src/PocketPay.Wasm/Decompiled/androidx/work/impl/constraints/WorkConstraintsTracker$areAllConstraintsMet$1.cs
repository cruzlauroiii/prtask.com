namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\r\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "it", "Landroidx/work/impl/constraints/controllers/ConstraintController;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class WorkConstraintsTracker$areAllConstraintsMet$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.work.impl.constraints.controllers.ConstraintController, java.lang.CharSequence> {
    public static readonly androidx.work.impl.constraints.WorkConstraintsTracker$areAllConstraintsMet$1 INSTANCE = new androidx.work.impl.constraints.WorkConstraintsTracker$areAllConstraintsMet$1();

    WorkConstraintsTracker$areAllConstraintsMet$1() {
        super(1);
    }

    public readonly java.lang.CharSequence Invoke2(androidx.work.impl.constraints.controllers.ConstraintController it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        java.lang.string simpleName = it.GetType().getSimpleName();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(simpleName, "it.javaClass.simpleName");
        return simpleName;
    }

    public override java.lang.CharSequence Invoke(androidx.work.impl.constraints.controllers.ConstraintController constraintController) {
        return invoke2(constraintController);
    }
}

