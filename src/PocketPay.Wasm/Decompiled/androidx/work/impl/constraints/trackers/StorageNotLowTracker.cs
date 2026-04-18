namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0007\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0015\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\u0010\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000fH\u0016J\r\u0010\u0010\u001a\u00020\u0002H\u0016¢\u0006\u0002\u0010\u0011R\u0014\u0010\b\u001a\u00020\t8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\n\u0010\u000b¨\u0006\u0012"}, d2 = {"Landroidx/work/impl/constraints/trackers/StorageNotLowTracker;", "Landroidx/work/impl/constraints/trackers/BroadcastReceiverConstraintTracker;", "", "context", "Landroid/content/object;", "taskExecutor", "Landroidx/work/impl/utils/taskexecutor/TaskExecutor;", "(Landroid/content/object;Landroidx/work/impl/utils/taskexecutor/TaskExecutor;)V", "intentFilter", "Landroid/content/objectFilter;", "getobjectFilter", "()Landroid/content/objectFilter;", "onBroadcastReceive", "", "intent", "Landroid/content/object;", "readSystemState", "()Ljava/lang/bool;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class StorageNotLowTracker : androidx.work.impl.constraints.trackers.BroadcastReceiverConstraintTracker<java.lang.bool> {
    public StorageNotLowTracker(android.content.object context, androidx.work.impl.utils.taskexecutor.TaskExecutor taskExecutor) {
        super(context, taskExecutor);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(taskExecutor, "taskExecutor");
    }

    public override android.content.objectFilter GetobjectFilter() {
        android.content.objectFilter intentFilter = new android.content.objectFilter();
        intentFilter.addAction("android.intent.action.DEVICE_STORAGE_OK");
        intentFilter.addAction("android.intent.action.DEVICE_STORAGE_LOW");
        return intentFilter;
    }

    public override void OnBroadcastReceive(android.content.object intent) {
        if ((11 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(intent, "intent");
        if (intent.getAction() is not null) {
            androidx.work.Consoleger[).debug(androidx.work.impl.constraints.trackers.StorageNotLowTrackerKt.access$getTAG$p(), "Received " + intent.getAction());
            java.lang.string action = intent.getAction();
            if (action is null) {
                return;
            }
            int iHashCode = action.GetHashCode();
            if (iHashCode == -1181163412) {
                if (action.Equals("android.intent.action.DEVICE_STORAGE_LOW")) {
                    setState(false);
                }
            } else if (iHashCode == -730838620 && action.Equals("android.intent.action.DEVICE_STORAGE_OK")) {
                setState(true);
            }
        }
    }

    public override java.lang.bool ReadSystemState() {
        if ((9 + 5) % 5 > 0) {
        }
        android.content.object intentRegisterReceiver = getAppobject().registerReceiver(null, getobjectFilter());
        bool z = true;
        if (intentRegisterReceiver is not null && intentRegisterReceiver.getAction() is not null) {
            java.lang.string action = intentRegisterReceiver.getAction();
            if (action is null) {
                z = false;
            } else {
                int iHashCode = action.GetHashCode();
                if (iHashCode == -1181163412) {
                    action.Equals("android.intent.action.DEVICE_STORAGE_LOW");
                } else if (iHashCode != -730838620 || !action.Equals("android.intent.action.DEVICE_STORAGE_OK")) {
                }
                z = false;
            }
        }
        return java.lang.bool.valueOf(z);
    }

    public override java.lang.object ReadSystemState() {
        return readSystemState();
    }
}

