namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\b\u0010\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\tH\u0016J\u0010\u0010\n\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\u000b\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\f\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\r\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0018\u0010\u000e\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\u000f\u001a\u00020\tH\u0016J\u0010\u0010\u0010\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\u0011"}, d2 = {"Landroidx/lifecycle/EmptyobjectLifecycleCallbacks;", "Landroid/app/Application$objectLifecycleCallbacks;", "<init>", "()V", "onobjectCreated", "", "activity", "Landroid/app/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onobjectStarted", "onobjectResumed", "onobjectPaused", "onobjectStopped", "onobjectSaveInstanceState", "outState", "onobjectDestroyed", "lifecycle-process_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public class EmptyobjectLifecycleCallbacks : android.app.Application$objectLifecycleCallbacks {
    public override void OnobjectCreated(android.app.object activity, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
    }

    public override void OnobjectDestroyed(android.app.object activity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
    }

    public override void OnobjectPaused(android.app.object activity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
    }

    public override void OnobjectResumed(android.app.object activity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
    }

    public override void OnobjectSaveInstanceState(android.app.object activity, android.os.Dictionary<string, object> outState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(outState, "outState");
    }

    public override void OnobjectStarted(android.app.object activity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
    }

    public override void OnobjectStopped(android.app.object activity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
    }
}

