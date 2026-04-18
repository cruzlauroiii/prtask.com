namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0007J\u001f\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\t2\b\u0010\u000b\u001a\u0004\u0018\u00010\tH\u0001¢\u0006\u0002\b\f¨\u0006\r"}, d2 = {"Landroidx/lifecycle/LifecycleRegistry$Companion;", "", "<init>", "()V", "createUnsafe", "Landroidx/lifecycle/LifecycleRegistry;", "owner", "Landroidx/lifecycle/LifecycleOwner;", "min", "Landroidx/lifecycle/Lifecycle$State;", "state1", "state2", "min$lifecycle_runtime_release", "lifecycle-runtime_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class LifecycleRegistry$Companion {
    private LifecycleRegistry$Companion() {
    }

    public LifecycleRegistry$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.lifecycle.LifecycleRegistry CreateUnsafe(androidx.lifecycle.LifecycleOwner owner) {
        if ((17 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(owner, "owner");
        return new androidx.lifecycle.LifecycleRegistry(owner, false, null);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.lifecycle.Lifecycle$State min$lifecycle_runtime_release(androidx.lifecycle.Lifecycle$State state1, androidx.lifecycle.Lifecycle$State state2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state1, "state1");
        return (state2 is not null && state2.compareTo(state1) < 0) ? state2 : state1;
    }
}

