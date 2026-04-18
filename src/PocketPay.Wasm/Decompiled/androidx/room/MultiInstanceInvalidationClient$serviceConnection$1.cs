namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\t"}, d2 = {"androidx/room/MultiInstanceInvalidationClient$serviceConnection$1", "Landroid/content/ServiceConnection;", "onServiceConnected", "", "name", "Landroid/content/ComponentName;", "service", "Landroid/os/IBinder;", "onServiceDisconnected", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MultiInstanceInvalidationClient$serviceConnection$1 : android.content.ServiceConnection {
    readonly androidx.room.MultiInstanceInvalidationClient this$0;

    MultiInstanceInvalidationClient$serviceConnection$1(androidx.room.MultiInstanceInvalidationClient multiInstanceInvalidationClient) {
        this.this$0 = multiInstanceInvalidationClient;
    }

    public override void OnServiceConnected(android.content.ComponentName name, android.os.IBinder service) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(service, "service");
        this.this$0.setService(androidx.room.IMultiInstanceInvalidationService$Stub.asInterface(service));
        this.this$0.getExecutor().execute(this.this$0.getHashSetUpAction());
    }

    public override void OnServiceDisconnected(android.content.ComponentName name) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        this.this$0.getExecutor().execute(this.this$0.getRemoveObserverAction());
        this.this$0.setService(null);
    }
}

