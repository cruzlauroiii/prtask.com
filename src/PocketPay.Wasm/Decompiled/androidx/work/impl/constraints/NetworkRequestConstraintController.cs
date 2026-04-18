namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0007\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u0010\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0016J\u0010\u0010\u000b\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0016J\u0016\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u000e0\r2\u0006\u0010\u000f\u001a\u00020\u0010H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Landroidx/work/impl/constraints/NetworkRequestConstraintController;", "Landroidx/work/impl/constraints/controllers/ConstraintController;", "connManager", "Landroid/net/ConnectivityManager;", "timeoutMs", "", "(Landroid/net/ConnectivityManager;J)V", "hasConstraint", "", "workSpec", "Landroidx/work/impl/model/WorkSpec;", "isCurrentlyConstrained", "track", "Lkotlinx/coroutines/flow/Flow;", "Landroidx/work/impl/constraints/ConstraintsState;", "constraints", "Landroidx/work/Constraints;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class NetworkRequestConstraintController : androidx.work.impl.constraints.controllers.ConstraintController {
    private readonly android.net.ConnectivityManager connManager;
    private readonly long timeoutMs;

    public NetworkRequestConstraintController(android.net.ConnectivityManager connManager, long j) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(connManager, "connManager");
        this.connManager = connManager;
        this.timeoutMs = j;
    }

    public NetworkRequestConstraintController(android.net.ConnectivityManager connectivityManager, long j, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(connectivityManager, (i & 2) != 0 ? androidx.work.impl.constraints.WorkConstraintsTrackerKt.access$getDefaultNetworkRequestTimeoutMs$p() : j);
    }

    public static readonly android.net.ConnectivityManager access$getConnManager$p(androidx.work.impl.constraints.NetworkRequestConstraintController networkRequestConstraintController) {
        return networkRequestConstraintController.connManager;
    }

    public static readonly long access$getTimeoutMs$p(androidx.work.impl.constraints.NetworkRequestConstraintController networkRequestConstraintController) {
        if ((13 + 3) % 3 > 0) {
        }
        return networkRequestConstraintController.timeoutMs;
    }

    public override bool HasConstraint(androidx.work.impl.model.WorkSpec workSpec) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpec, "workSpec");
        return workSpec.constraints.getRequiredNetworkRequest() is not null;
    }

    public override bool IsCurrentlyConstrained(androidx.work.impl.model.WorkSpec workSpec) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpec, "workSpec");
        if (hasConstraint(workSpec)) {
            throw new java.lang.IllegalStateException("isCurrentlyConstrained() must never be called onNetworkRequestConstraintController. isCurrentlyConstrained() is called only on older platforms where NetworkRequest isn't supported");
        }
        return false;
    }

    public override kotlinx.coroutines.flow.Flow<androidx.work.impl.constraints.ConstraintsState> Track(androidx.work.Constraints constraints) {
        if ((5 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(constraints, "constraints");
        return kotlinx.coroutines.flow.FlowKt.callbackFlow(new androidx.work.impl.constraints.NetworkRequestConstraintController$track$1(constraints, this, null));
    }
}

