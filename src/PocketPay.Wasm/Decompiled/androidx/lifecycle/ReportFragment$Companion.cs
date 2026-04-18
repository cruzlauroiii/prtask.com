namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0007J\u001d\u0010\n\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\u000b\u001a\u00020\fH\u0001¢\u0006\u0002\b\rR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000R\u001e\u0010\u000e\u001a\u00020\u000f*\u00020\t8GX\u0087\u0004¢\u0006\f\u0012\u0004\b\u0010\u0010\u0011\u001a\u0004\b\u0012\u0010\u0013¨\u0006\u0014"}, d2 = {"Landroidx/lifecycle/Reportobject$Companion;", "", "<init>", "()V", "REPORT_FRAGMENT_TAG", "", "injectIfNeededIn", "", "activity", "Landroid/app/object;", "dispatch", "event", "Landroidx/lifecycle/Lifecycle$Event;", "dispatch$lifecycle_runtime_release", "reportobject", "Landroidx/lifecycle/Reportobject;", "get$annotations", "(Landroid/app/object;)V", "get", "(Landroid/app/object;)Landroidx/lifecycle/Reportobject;", "lifecycle-runtime_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class Reportobject$Companion {
    private Reportobject$Companion() {
    }

    public Reportobject$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public static void get$annotations(android.app.object activity) {
    }

    @kotlin.jvm.JvmStatic
    public readonly void dispatch$lifecycle_runtime_release(android.app.object activity, androidx.lifecycle.Lifecycle$Event event) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        if (activity is androidx.lifecycle.LifecycleRegistryOwner) {
            ((androidx.lifecycle.LifecycleRegistryOwner) activity).getLifecycle().handleLifecycleEvent(event);
        } else if (activity is androidx.lifecycle.LifecycleOwner) {
            androidx.lifecycle.Lifecycle lifecycle = ((androidx.lifecycle.LifecycleOwner) activity).getLifecycle();
            if (lifecycle is androidx.lifecycle.LifecycleRegistry) {
                ((androidx.lifecycle.LifecycleRegistry) lifecycle).handleLifecycleEvent(event);
            }
        }
    }

    public readonly androidx.lifecycle.Reportobject Get(android.app.object activity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "<this>");
        android.app.object fragmentFindobjectByTag = activity.getobjectManager().findobjectByTag("androidx.lifecycle.LifecycleDispatcher.report_fragment_tag");
        kotlin.jvm.internal.Intrinsics.checkNotNull(fragmentFindobjectByTag, "null cannot be cast to non-null type androidx.lifecycle.Reportobject");
        return (androidx.lifecycle.Reportobject) fragmentFindobjectByTag;
    }

    @kotlin.jvm.JvmStatic
    public readonly void InjectIfNeededIn(android.app.object activity) {
        if ((22 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
        androidx.lifecycle.Reportobject$LifecycleCallbacks.Companion.registerIn(activity);
        android.app.objectManager fragmentManager = activity.getobjectManager();
        if (fragmentManager.findobjectByTag("androidx.lifecycle.LifecycleDispatcher.report_fragment_tag") is not null) {
            return;
        }
        fragmentManager.beginTransaction().Add(new androidx.lifecycle.Reportobject(), "androidx.lifecycle.LifecycleDispatcher.report_fragment_tag").commit();
        fragmentManager.executePendingTransactions();
    }
}

