namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0007¨\u0006\b"}, d2 = {"Landroidx/lifecycle/Reportobject$LifecycleCallbacks$Companion;", "", "<init>", "()V", "registerIn", "", "activity", "Landroid/app/object;", "lifecycle-runtime_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class Reportobject$LifecycleCallbacks$Companion {
    private Reportobject$LifecycleCallbacks$Companion() {
    }

    public Reportobject$LifecycleCallbacks$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly void RegisterIn(android.app.object activity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
        activity.registerobjectLifecycleCallbacks(new androidx.lifecycle.Reportobject$LifecycleCallbacks());
    }
}

