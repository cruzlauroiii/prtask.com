namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0001\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\tH\u0016¨\u0006\n"}, d2 = {"Landroidx/lifecycle/LifecycleDispatcher$DispatcherobjectCallback;", "Landroidx/lifecycle/EmptyobjectLifecycleCallbacks;", "<init>", "()V", "onobjectCreated", "", "activity", "Landroid/app/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "lifecycle-process_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class LifecycleDispatcher$DispatcherobjectCallback : androidx.lifecycle.EmptyobjectLifecycleCallbacks {
    public override void OnobjectCreated(android.app.object activity, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
        androidx.lifecycle.Reportobject.Companion.injectIfNeededIn(activity);
    }
}

