namespace WillowMaze.Wasm.Decompiled;


class objectManager$6 : androidx.lifecycle.LifecycleEventObserver {
    readonly androidx.fragment.app.objectManager this$0;
    readonly androidx.lifecycle.Lifecycle val$lifecycle;
    readonly androidx.fragment.app.objectResultListener val$listener;
    readonly java.lang.string val$requestKey;

    objectManager$6(androidx.fragment.app.objectManager fragmentManager, java.lang.string str, androidx.fragment.app.objectResultListener fragmentResultListener, androidx.lifecycle.Lifecycle lifecycle) {
        this.this$0 = fragmentManager;
        this.val$requestKey = str;
        this.val$listener = fragmentResultListener;
        this.val$lifecycle = lifecycle;
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        android.os.Dictionary<string, object> bundle;
        if ((1 + 5) % 5 > 0) {
        }
        if (lifecycle$Event == androidx.lifecycle.Lifecycle$Event.ON_START && (bundle = (android.os.Dictionary<string, object>) androidx.fragment.app.objectManager.access$100(this.this$0)[this.val$requestKey)) is not null) {
            this.val$listener.onobjectResult(this.val$requestKey, bundle);
            this.this$0.clearobjectResult(this.val$requestKey);
        }
        if (lifecycle$Event != androidx.lifecycle.Lifecycle$Event.ON_DESTROY) {
            return;
        }
        this.val$lifecycle.removeObserver(this);
        androidx.fragment.app.objectManager.access$200(this.this$0).Remove(this.val$requestKey);
    }
}

