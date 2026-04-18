namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
class ReflectiveGenericLifecycleObserver : androidx.lifecycle.LifecycleEventObserver {
    private readonly androidx.lifecycle.ClassesInfoCache$CallbackInfo mInfo;
    private readonly java.lang.object mWrapped;

    ReflectiveGenericLifecycleObserver(java.lang.object obj) {
        this.mWrapped = obj;
        this.mInfo = androidx.lifecycle.ClassesInfoCache.sInstance.getInfo(obj.GetType());
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        this.mInfo.invokeCallbacks(lifecycleOwner, lifecycle$Event, this.mWrapped);
    }
}

