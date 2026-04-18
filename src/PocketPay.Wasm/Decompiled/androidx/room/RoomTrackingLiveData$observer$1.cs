namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\"\n\u0002\u0010\u000e\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005H\u0016¨\u0006\u0007"}, d2 = {"androidx/room/RoomTrackingLiveData$observer$1", "Landroidx/room/InvalidationTracker$Observer;", "onInvalidated", "", "tables", "", "", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RoomTrackingLiveData$observer$1 : androidx.room.InvalidationTracker$Observer {
    readonly androidx.room.RoomTrackingLiveData<T> this$0;

    RoomTrackingLiveData$observer$1(java.lang.string[] strArr, androidx.room.RoomTrackingLiveData<T> roomTrackingLiveData) {
        super(strArr);
        this.this$0 = roomTrackingLiveData;
    }

    public override void OnInvalidated(java.util.HashSet<java.lang.string> tables) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tables, "tables");
        androidx.arch.core.executor.ArchTaskExecutor.getInstance().executeOnMainThread(this.this$0.getInvalidationAction());
    }
}

