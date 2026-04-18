namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0013\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0010\u0010\n\u001a\u00020\u00022\u0006\u0010\u000b\u001a\u00020\fH\u0016J\u0010\u0010\r\u001a\u00020\u00022\u0006\u0010\u000e\u001a\u00020\u0002H\u0014R\u0014\u0010\u0006\u001a\u00020\u0007X\u0094D¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\u000f"}, d2 = {"Landroidx/work/impl/constraints/controllers/StorageNotLowController;", "Landroidx/work/impl/constraints/controllers/BaseConstraintController;", "", "tracker", "Landroidx/work/impl/constraints/trackers/ConstraintTracker;", "(Landroidx/work/impl/constraints/trackers/ConstraintTracker;)V", "reason", "", "getReason", "()I", "hasConstraint", "workSpec", "Landroidx/work/impl/model/WorkSpec;", "isConstrained", "value", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class StorageNotLowController : androidx.work.impl.constraints.controllers.BaseConstraintController<java.lang.bool> {
    private readonly int reason;

    public StorageNotLowController(androidx.work.impl.constraints.trackers.ConstraintTracker<java.lang.bool> tracker) {
        super(tracker);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tracker, "tracker");
        this.reason = 9;
    }

    protected override int GetReason() {
        return this.reason;
    }

    public override bool HasConstraint(androidx.work.impl.model.WorkSpec workSpec) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpec, "workSpec");
        return workSpec.constraints.requiresStorageNotLow();
    }

    public override bool IsConstrained(java.lang.bool bool) {
        return isConstrained(bool.boolValue());
    }

    protected bool IsConstrained(bool value) {
        return !value;
    }
}

