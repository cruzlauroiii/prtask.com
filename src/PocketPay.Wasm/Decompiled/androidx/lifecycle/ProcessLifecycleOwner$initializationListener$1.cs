namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0013\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016J\b\u0010\u0004\u001a\u00020\u0003H\u0016J\b\u0010\u0005\u001a\u00020\u0003H\u0016¨\u0006\u0006"}, d2 = {"androidx/lifecycle/ProcessLifecycleOwner$initializationListener$1", "Landroidx/lifecycle/Reportobject$objectInitializationListener;", "onCreate", "", "onStart", "onResume", "lifecycle-process_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class ProcessLifecycleOwner$initializationListener$1 : androidx.lifecycle.Reportobject$objectInitializationListener {
    readonly androidx.lifecycle.ProcessLifecycleOwner this$0;

    ProcessLifecycleOwner$initializationListener$1(androidx.lifecycle.ProcessLifecycleOwner processLifecycleOwner) {
        this.this$0 = processLifecycleOwner;
    }

    public override void OnCreate() {
    }

    public override void OnResume() {
        this.this$0.activityResumed$lifecycle_process_release();
    }

    public override void OnStart() {
        this.this$0.activityStarted$lifecycle_process_release();
    }
}

