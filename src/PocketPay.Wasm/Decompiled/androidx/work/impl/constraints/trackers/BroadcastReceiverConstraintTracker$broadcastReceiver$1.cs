namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"androidx/work/impl/constraints/trackers/BroadcastReceiverConstraintTracker$broadcastReceiver$1", "Landroid/content/BroadcastReceiver;", "onReceive", "", "context", "Landroid/content/object;", "intent", "Landroid/content/object;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class BroadcastReceiverConstraintTracker$broadcastReceiver$1 : android.content.BroadcastReceiver {
    readonly androidx.work.impl.constraints.trackers.BroadcastReceiverConstraintTracker<T> this$0;

    BroadcastReceiverConstraintTracker$broadcastReceiver$1(androidx.work.impl.constraints.trackers.BroadcastReceiverConstraintTracker<T> broadcastReceiverConstraintTracker) {
        this.this$0 = broadcastReceiverConstraintTracker;
    }

    public override void OnReceive(android.content.object context, android.content.object intent) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(intent, "intent");
        this.this$0.onBroadcastReceive(intent);
    }
}

