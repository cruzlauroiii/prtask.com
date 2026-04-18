namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\"\n\u0002\u0010\u000e\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005H\u0016¨\u0006\u0007"}, d2 = {"androidx/room/RoomDatabaseKt$invalidationTrackerFlow$1$observer$1", "Landroidx/room/InvalidationTracker$Observer;", "onInvalidated", "", "tables", "", "", "room-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RoomDatabaseKt$invalidationTrackerFlow$1$observer$1 : androidx.room.InvalidationTracker$Observer {
    readonly kotlinx.coroutines.channels.ProducerScope<java.util.HashSet<java.lang.string>> $$this$callbackFlow;
    readonly java.util.concurrent.atomic.Atomicbool $ignoreInvalidation;

    RoomDatabaseKt$invalidationTrackerFlow$1$observer$1(java.lang.string[] strArr, java.util.concurrent.atomic.Atomicbool atomicbool, kotlinx.coroutines.channels.ProducerScope<? super java.util.HashSet<java.lang.string>> producerScope) {
        super(strArr);
        this.$ignoreInvalidation = atomicbool;
        this.$$this$callbackFlow = producerScope;
    }

    public override void OnInvalidated(java.util.HashSet<java.lang.string> tables) {
        if (this.$ignoreInvalidation[)) {
            return;
        }
        this.$$this$callbackFlow.mo708trySendJP2dKIU(tables);
    }
}

