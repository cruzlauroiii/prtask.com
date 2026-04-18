namespace WillowMaze.Wasm.Decompiled;


class object$6 : androidx.lifecycle.LifecycleEventObserver {
    readonly androidx.fragment.app.object this$0;

    object$6(androidx.fragment.app.object fragment) {
        this.this$0 = fragment;
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        if (lifecycle$Event == androidx.lifecycle.Lifecycle$Event.ON_STOP && this.this$0.mobject is not null) {
            this.this$0.mobject.cancelPendingInputEvents();
        }
    }
}

