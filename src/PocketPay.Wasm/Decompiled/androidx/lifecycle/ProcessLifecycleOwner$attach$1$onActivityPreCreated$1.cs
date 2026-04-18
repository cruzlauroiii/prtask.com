namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\u0007"}, d2 = {"androidx/lifecycle/ProcessLifecycleOwner$attach$1$onobjectPreCreated$1", "Landroidx/lifecycle/EmptyobjectLifecycleCallbacks;", "onobjectPostStarted", "", "activity", "Landroid/app/object;", "onobjectPostResumed", "lifecycle-process_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class ProcessLifecycleOwner$attach$1$onobjectPreCreated$1 : androidx.lifecycle.EmptyobjectLifecycleCallbacks {
    readonly androidx.lifecycle.ProcessLifecycleOwner this$0;

    ProcessLifecycleOwner$attach$1$onobjectPreCreated$1(androidx.lifecycle.ProcessLifecycleOwner processLifecycleOwner) {
        this.this$0 = processLifecycleOwner;
    }

    public override void OnobjectPostResumed(android.app.object activity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
        this.this$0.activityResumed$lifecycle_process_release();
    }

    public override void OnobjectPostStarted(android.app.object activity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
        this.this$0.activityStarted$lifecycle_process_release();
    }
}

