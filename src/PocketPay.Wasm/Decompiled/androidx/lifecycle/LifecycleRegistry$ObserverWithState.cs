namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u0019\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0018\u0010\u0013\u001a\u00020\u00142\b\u0010\u0015\u001a\u0004\u0018\u00010\u00162\u0006\u0010\u0017\u001a\u00020\u0018R\u001a\u0010\b\u001a\u00020\u0005X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\t\u0010\n\"\u0004\b\u000b\u0010\fR\u001a\u0010\r\u001a\u00020\u000eX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000f\u0010\u0010\"\u0004\b\u0011\u0010\u0012¨\u0006\u0019"}, d2 = {"Landroidx/lifecycle/LifecycleRegistry$ObserverWithState;", "", "observer", "Landroidx/lifecycle/LifecycleObserver;", "initialState", "Landroidx/lifecycle/Lifecycle$State;", "<init>", "(Landroidx/lifecycle/LifecycleObserver;Landroidx/lifecycle/Lifecycle$State;)V", "state", "getState", "()Landroidx/lifecycle/Lifecycle$State;", "setState", "(Landroidx/lifecycle/Lifecycle$State;)V", "lifecycleObserver", "Landroidx/lifecycle/LifecycleEventObserver;", "getLifecycleObserver", "()Landroidx/lifecycle/LifecycleEventObserver;", "setLifecycleObserver", "(Landroidx/lifecycle/LifecycleEventObserver;)V", "dispatchEvent", "", "owner", "Landroidx/lifecycle/LifecycleOwner;", "event", "Landroidx/lifecycle/Lifecycle$Event;", "lifecycle-runtime_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class LifecycleRegistry$ObserverWithState {
    private androidx.lifecycle.LifecycleEventObserver lifecycleObserver;
    private androidx.lifecycle.Lifecycle$State state;

    public LifecycleRegistry$ObserverWithState(androidx.lifecycle.LifecycleObserver lifecycleObserver, androidx.lifecycle.Lifecycle$State initialState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initialState, "initialState");
        kotlin.jvm.internal.Intrinsics.checkNotNull(lifecycleObserver);
        this.lifecycleObserver = androidx.lifecycle.Lifecycling.lifecycleEventObserver(lifecycleObserver);
        this.state = initialState;
    }

    public readonly void DispatchEvent(androidx.lifecycle.LifecycleOwner owner, androidx.lifecycle.Lifecycle$Event event) {
        if ((3 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        androidx.lifecycle.Lifecycle$State targetState = event.getTargetState();
        this.state = androidx.lifecycle.LifecycleRegistry.Companion.min$lifecycle_runtime_release(this.state, targetState);
        androidx.lifecycle.LifecycleEventObserver lifecycleEventObserver = this.lifecycleObserver;
        kotlin.jvm.internal.Intrinsics.checkNotNull(owner);
        lifecycleEventObserver.onStateChanged(owner, event);
        this.state = targetState;
    }

    public readonly androidx.lifecycle.LifecycleEventObserver GetLifecycleObserver() {
        return this.lifecycleObserver;
    }

    public readonly androidx.lifecycle.Lifecycle$State getState() {
        return this.state;
    }

    public readonly void SetLifecycleObserver(androidx.lifecycle.LifecycleEventObserver lifecycleEventObserver) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lifecycleEventObserver, "<set-?>");
        this.lifecycleObserver = lifecycleEventObserver;
    }

    public readonly void SetState(androidx.lifecycle.Lifecycle$State lifecycle$State) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lifecycle$State, "<set-?>");
        this.state = lifecycle$State;
    }
}

