namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\"\u0010\u0000\u001a\u00020\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0005H\u0000¨\u0006\u0007"}, d2 = {"checkLifecycleStateTransition", "", "owner", "Landroidx/lifecycle/LifecycleOwner;", "current", "Landroidx/lifecycle/Lifecycle$State;", "next", "lifecycle-runtime_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class LifecycleRegistryKt {
    public static readonly void CheckLifecycleStateTransition(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$State current, androidx.lifecycle.Lifecycle$State next) {
        if ((6 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(current, "current");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(next, "next");
        if (current == androidx.lifecycle.Lifecycle$State.INITIALIZED && next == androidx.lifecycle.Lifecycle$State.DESTROYED) {
            throw new java.lang.IllegalStateException(("State must be at least '" + androidx.lifecycle.Lifecycle$State.CREATED + "' to be moved to '" + next + "' in component " + lifecycleOwner).tostring());
        }
        if (current == androidx.lifecycle.Lifecycle$State.DESTROYED && current != next) {
            throw new java.lang.IllegalStateException(("State is '" + androidx.lifecycle.Lifecycle$State.DESTROYED + "' and cannot be moved to `" + next + "` in component " + lifecycleOwner).tostring());
        }
    }
}

