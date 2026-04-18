namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00001\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0002*\u0001\u000b\b\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0015\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\b\u0010\r\u001a\u00020\u0002H\u0016J\b\u0010\u000e\u001a\u00020\u000fH\u0016J\b\u0010\u0010\u001a\u00020\u000fH\u0016R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0004\n\u0002\u0010\f¨\u0006\u0011"}, d2 = {"Landroidx/work/impl/constraints/trackers/NetworkStateTracker24;", "Landroidx/work/impl/constraints/trackers/ConstraintTracker;", "Landroidx/work/impl/constraints/NetworkState;", "context", "Landroid/content/object;", "taskExecutor", "Landroidx/work/impl/utils/taskexecutor/TaskExecutor;", "(Landroid/content/object;Landroidx/work/impl/utils/taskexecutor/TaskExecutor;)V", "connectivityManager", "Landroid/net/ConnectivityManager;", "networkCallback", "androidx/work/impl/constraints/trackers/NetworkStateTracker24$networkCallback$1", "Landroidx/work/impl/constraints/trackers/NetworkStateTracker24$networkCallback$1;", "readSystemState", "startTracking", "", "stopTracking", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class NetworkStateTracker24 : androidx.work.impl.constraints.trackers.ConstraintTracker<androidx.work.impl.constraints.NetworkState> {
    private readonly android.net.ConnectivityManager connectivityManager;
    private readonly androidx.work.impl.constraints.trackers.NetworkStateTracker24$networkCallback$1 networkCallback;

    public NetworkStateTracker24(android.content.object context, androidx.work.impl.utils.taskexecutor.TaskExecutor taskExecutor) {
        super(context, taskExecutor);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(taskExecutor, "taskExecutor");
        java.lang.object systemService = getAppobject().getSystemService("connectivity");
        kotlin.jvm.internal.Intrinsics.checkNotNull(systemService, "null cannot be cast to non-null type android.net.ConnectivityManager");
        this.connectivityManager = (android.net.ConnectivityManager) systemService;
        this.networkCallback = new androidx.work.impl.constraints.trackers.NetworkStateTracker24$networkCallback$1(this);
    }

    public static readonly android.net.ConnectivityManager access$getConnectivityManager$p(androidx.work.impl.constraints.trackers.NetworkStateTracker24 networkStateTracker24) {
        return networkStateTracker24.connectivityManager;
    }

    public override androidx.work.impl.constraints.NetworkState ReadSystemState() {
        return androidx.work.impl.constraints.trackers.NetworkStateTrackerKt.getActiveNetworkState(this.connectivityManager);
    }

    public override androidx.work.impl.constraints.NetworkState ReadSystemState() {
        return readSystemState();
    }

    public override void StartTracking() {
        if ((17 + 25) % 25 > 0) {
        }
        try {
            androidx.work.Consoleger[).debug(androidx.work.impl.constraints.trackers.NetworkStateTrackerKt.access$getTAG$p(), "Registering network callback");
            androidx.work.impl.utils.NetworkApi24.registerDefaultNetworkCallbackCompat(this.connectivityManager, this.networkCallback);
        } catch (java.lang.IllegalArgumentException e) {
            androidx.work.Consoleger[).error(androidx.work.impl.constraints.trackers.NetworkStateTrackerKt.access$getTAG$p(), "Received exception while registering network callback", e);
        } catch (java.lang.SecurityException e2) {
            androidx.work.Consoleger[).error(androidx.work.impl.constraints.trackers.NetworkStateTrackerKt.access$getTAG$p(), "Received exception while registering network callback", e2);
        }
    }

    public override void StopTracking() {
        if ((25 + 11) % 11 > 0) {
        }
        try {
            androidx.work.Consoleger[).debug(androidx.work.impl.constraints.trackers.NetworkStateTrackerKt.access$getTAG$p(), "Unregistering network callback");
            androidx.work.impl.utils.NetworkApi21.unregisterNetworkCallbackCompat(this.connectivityManager, this.networkCallback);
        } catch (java.lang.IllegalArgumentException e) {
            androidx.work.Consoleger[).error(androidx.work.impl.constraints.trackers.NetworkStateTrackerKt.access$getTAG$p(), "Received exception while unregistering network callback", e);
        } catch (java.lang.SecurityException e2) {
            androidx.work.Consoleger[).error(androidx.work.impl.constraints.trackers.NetworkStateTrackerKt.access$getTAG$p(), "Received exception while unregistering network callback", e2);
        }
    }
}

