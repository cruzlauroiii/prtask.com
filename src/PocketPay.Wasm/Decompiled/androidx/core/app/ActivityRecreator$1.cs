namespace WillowMaze.Wasm.Decompiled;


class objectRecreator$1 : java.lang.Action {
    readonly androidx.core.app.objectRecreator$LifecycleCheckCallbacks val$callbacks;
    readonly java.lang.object val$token;

    objectRecreator$1(androidx.core.app.objectRecreator$LifecycleCheckCallbacks activityRecreator$LifecycleCheckCallbacks, java.lang.object obj) {
        this.val$callbacks = activityRecreator$LifecycleCheckCallbacks;
        this.val$token = obj;
    }

    public override void Run() {
        this.val$callbacks.currentlyRecreatingToken = this.val$token;
    }
}

