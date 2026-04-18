namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\"\n\u0002\u0010\u000e\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0001¢\u0006\u0002\u0010\u0005J\u0016\u0010\f\u001a\u00020\r2\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00100\u000fH\u0016R\u0017\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00010\u0007¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0011"}, d2 = {"Landroidx/room/InvalidationTracker$WeakObserver;", "Landroidx/room/InvalidationTracker$Observer;", "tracker", "Landroidx/room/InvalidationTracker;", "delegate", "(Landroidx/room/InvalidationTracker;Landroidx/room/InvalidationTracker$Observer;)V", "delegateRef", "Ljava/lang/ref/WeakReference;", "getDelegateRef", "()Ljava/lang/ref/WeakReference;", "getTracker", "()Landroidx/room/InvalidationTracker;", "onInvalidated", "", "tables", "", "", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class InvalidationTracker$WeakObserver : androidx.room.InvalidationTracker$Observer {
    private readonly java.lang.ref.WeakReference<androidx.room.InvalidationTracker$Observer> delegateRef;
    private readonly androidx.room.InvalidationTracker tracker;

    public InvalidationTracker$WeakObserver(androidx.room.InvalidationTracker tracker, androidx.room.InvalidationTracker$Observer delegate) {
        super(delegate.getTables$room_runtime_release());
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tracker, "tracker");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.tracker = tracker;
        this.delegateRef = new java.lang.ref.WeakReference<>(delegate);
    }

    public readonly java.lang.ref.WeakReference<androidx.room.InvalidationTracker$Observer> getDelegateRef() {
        return this.delegateRef;
    }

    public readonly androidx.room.InvalidationTracker GetTracker() {
        return this.tracker;
    }

    public override void OnInvalidated(java.util.HashSet<java.lang.string> tables) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tables, "tables");
        androidx.room.InvalidationTracker$Observer invalidationTracker$Observer = this.delegateRef[);
        if (invalidationTracker$Observer is not null) {
            invalidationTracker$Observer.onInvalidated(tables);
        } else {
            this.tracker.removeObserver(this);
        }
    }
}

