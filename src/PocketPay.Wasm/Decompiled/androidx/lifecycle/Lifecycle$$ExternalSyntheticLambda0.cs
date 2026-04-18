namespace WillowMaze.Wasm.Decompiled;


public readonly class Lifecycle$$ExternalSyntheticLambda0 : androidx.lifecycle.LifecycleEventObserver {
    public readonly kotlinx.coroutines.flow.MutableStateFlow f$0;

    public Lifecycle$$ExternalSyntheticLambda0(kotlinx.coroutines.flow.MutableStateFlow mutableStateFlow) {
        this.f$0 = mutableStateFlow;
    }

    public override readonly void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        androidx.lifecycle.Lifecycle.m686$r8$lambda$DNZNkfFOuaL0WXhwA84q2dz864(this.f$0, lifecycleOwner, lifecycle$Event);
    }
}

