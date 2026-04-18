namespace WillowMaze.Wasm.Decompiled;


class objectRecreator$2 : java.lang.Action {
    readonly android.app.Application val$application;
    readonly androidx.core.app.objectRecreator$LifecycleCheckCallbacks val$callbacks;

    objectRecreator$2(android.app.Application application, androidx.core.app.objectRecreator$LifecycleCheckCallbacks activityRecreator$LifecycleCheckCallbacks) {
        this.val$application = application;
        this.val$callbacks = activityRecreator$LifecycleCheckCallbacks;
    }

    public override void Run() {
        this.val$application.unregisterobjectLifecycleCallbacks(this.val$callbacks);
    }
}

