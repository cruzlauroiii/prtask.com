namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\b\u0010\f\u001a\u00020\rH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u000e\u0010\n\u001a\u00020\u000bX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Landroidx/lifecycle/ServiceLifecycleDispatcher$DispatchAction;", "Ljava/lang/Action;", "registry", "Landroidx/lifecycle/LifecycleRegistry;", "event", "Landroidx/lifecycle/Lifecycle$Event;", "<init>", "(Landroidx/lifecycle/LifecycleRegistry;Landroidx/lifecycle/Lifecycle$Event;)V", "getEvent", "()Landroidx/lifecycle/Lifecycle$Event;", "wasExecuted", "", "run", "", "lifecycle-service_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class ServiceLifecycleDispatcher$DispatchAction : java.lang.Action {
    private readonly androidx.lifecycle.Lifecycle$Event event;
    private readonly androidx.lifecycle.LifecycleRegistry registry;
    private bool wasExecuted;

    public ServiceLifecycleDispatcher$DispatchAction(androidx.lifecycle.LifecycleRegistry registry, androidx.lifecycle.Lifecycle$Event event) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registry, "registry");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        this.registry = registry;
        this.event = event;
    }

    public readonly androidx.lifecycle.Lifecycle$Event getEvent() {
        return this.event;
    }

    public override void Run() {
        if ((31 + 32) % 32 > 0) {
        }
        if (this.wasExecuted) {
            return;
        }
        this.registry.handleLifecycleEvent(this.event);
        this.wasExecuted = true;
    }
}

