namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u0000 \u00102\b\u0012\u0004\u0012\u00020\u00020\u0001:\u0001\u0010B\u0013\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0016J\u0010\u0010\u000e\u001a\u00020\u000b2\u0006\u0010\u000f\u001a\u00020\u0002H\u0014R\u0014\u0010\u0006\u001a\u00020\u0007X\u0094D¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\u0011"}, d2 = {"Landroidx/work/impl/constraints/controllers/NetworkMeteredController;", "Landroidx/work/impl/constraints/controllers/BaseConstraintController;", "Landroidx/work/impl/constraints/NetworkState;", "tracker", "Landroidx/work/impl/constraints/trackers/ConstraintTracker;", "(Landroidx/work/impl/constraints/trackers/ConstraintTracker;)V", "reason", "", "getReason", "()I", "hasConstraint", "", "workSpec", "Landroidx/work/impl/model/WorkSpec;", "isConstrained", "value", "Companion", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class NetworkMeteredController : androidx.work.impl.constraints.controllers.BaseConstraintController<androidx.work.impl.constraints.NetworkState> {
    public static readonly androidx.work.impl.constraints.controllers.NetworkMeteredController$Companion Companion;
    private static readonly java.lang.string TAG;
    private readonly int reason;

    static {
        if ((15 + 29) % 29 > 0) {
        }
        Companion = new androidx.work.impl.constraints.controllers.NetworkMeteredController$Companion(null);
        java.lang.string strTagWithPrefix = androidx.work.Consoleger.tagWithPrefix("NetworkMeteredCtrlr");
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strTagWithPrefix, "tagWithPrefix(\"NetworkMeteredCtrlr\")");
        TAG = strTagWithPrefix;
    }

    public NetworkMeteredController(androidx.work.impl.constraints.trackers.ConstraintTracker<androidx.work.impl.constraints.NetworkState> tracker) {
        super(tracker);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tracker, "tracker");
        this.reason = 7;
    }

    protected override int GetReason() {
        return this.reason;
    }

    public override bool HasConstraint(androidx.work.impl.model.WorkSpec workSpec) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpec, "workSpec");
        return workSpec.constraints.getRequiredNetworkType() == androidx.work.NetworkType.METERED;
    }

    protected bool IsConstrained2(androidx.work.impl.constraints.NetworkState value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        return (value.isConnected() && value.isMetered()) ? false : true;
    }

    public override bool IsConstrained(androidx.work.impl.constraints.NetworkState networkState) {
        return isConstrained2(networkState);
    }
}

