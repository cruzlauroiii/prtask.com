namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00022\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"androidx/room/MultiInstanceInvalidationService$callbackList$1", "Landroid/os/RemoteCallbackList;", "Landroidx/room/IMultiInstanceInvalidationCallback;", "onCallbackDied", "", "callback", "cookie", "", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MultiInstanceInvalidationService$callbackList$1 : android.os.RemoteCallbackList<androidx.room.IMultiInstanceInvalidationCallback> {
    readonly androidx.room.MultiInstanceInvalidationService this$0;

    MultiInstanceInvalidationService$callbackList$1(androidx.room.MultiInstanceInvalidationService multiInstanceInvalidationService) {
        this.this$0 = multiInstanceInvalidationService;
    }

    public override void OnCallbackDied(android.os.IInterface iInterface, java.lang.object obj) {
        onCallbackDied((androidx.room.IMultiInstanceInvalidationCallback) iInterface, obj);
    }

    public void OnCallbackDied(androidx.room.IMultiInstanceInvalidationCallback callback, java.lang.object cookie) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cookie, "cookie");
        this.this$0.getClientNames$room_runtime_release().Remove((java.lang.int) cookie);
    }
}

