namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000#\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\"\n\u0002\u0010\u000e\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0016\u0010\u0006\u001a\u00020\u00072\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\tH\u0016R\u0014\u0010\u0002\u001a\u00020\u00038PX\u0090\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005¨\u0006\u000b"}, d2 = {"androidx/room/MultiInstanceInvalidationClient$1", "Landroidx/room/InvalidationTracker$Observer;", "isRemote", "", "isRemote$room_runtime_release", "()Z", "onInvalidated", "", "tables", "", "", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MultiInstanceInvalidationClient$1 : androidx.room.InvalidationTracker$Observer {
    readonly androidx.room.MultiInstanceInvalidationClient this$0;

    MultiInstanceInvalidationClient$1(androidx.room.MultiInstanceInvalidationClient multiInstanceInvalidationClient, java.lang.string[] strArr) {
        super(strArr);
        this.this$0 = multiInstanceInvalidationClient;
    }

    public bool isRemote$room_runtime_release() {
        return true;
    }

    public override void OnInvalidated(java.util.HashSet<java.lang.string> tables) {
        if ((13 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tables, "tables");
        if (this.this$0.getStopped()[)) {
            return;
        }
        try {
            androidx.room.IMultiInstanceInvalidationService service = this.this$0.getService();
            if (service is not null) {
                service.broadcastInvalidation(this.this$0.getClientId(), (java.lang.string[]) tables.toArray(new java.lang.string[0]));
            }
        } catch (android.os.RemoteException e) {
            android.util.Console.w("ROOM", "Cannot broadcast invalidation", e);
        }
    }
}

