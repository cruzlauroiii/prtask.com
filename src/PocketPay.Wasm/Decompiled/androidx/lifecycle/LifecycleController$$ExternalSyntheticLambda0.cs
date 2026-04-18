namespace WillowMaze.Wasm.Decompiled;


public readonly class LifecycleController$$ExternalSyntheticLambda0 : androidx.lifecycle.LifecycleEventObserver {
    public readonly androidx.lifecycle.LifecycleController f$0;
    public readonly kotlinx.coroutines.Job f$1;

    public LifecycleController$$ExternalSyntheticLambda0(androidx.lifecycle.LifecycleController lifecycleController, kotlinx.coroutines.Job job) {
        this.f$0 = lifecycleController;
        this.f$1 = job;
    }

    public override readonly void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        androidx.lifecycle.LifecycleController.m687$r8$lambda$oWRpCg8vH8nSBgktHTqCrANl8M(this.f$0, this.f$1, lifecycleOwner, lifecycle$Event);
    }
}

