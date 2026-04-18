namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0016\u0018\u00002\u00020\u0001:\u0001\u0018B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000fH\u0002J\b\u0010\u0010\u001a\u00020\rH\u0016J\b\u0010\u0011\u001a\u00020\rH\u0016J\b\u0010\u0012\u001a\u00020\rH\u0016J\b\u0010\u0013\u001a\u00020\rH\u0016R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\n\u001a\u0004\u0018\u00010\u000bX\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u0014\u001a\u00020\u00158VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0016\u0010\u0017¨\u0006\u0019"}, d2 = {"Landroidx/lifecycle/ServiceLifecycleDispatcher;", "", "provider", "Landroidx/lifecycle/LifecycleOwner;", "<init>", "(Landroidx/lifecycle/LifecycleOwner;)V", "registry", "Landroidx/lifecycle/LifecycleRegistry;", "handler", "Landroid/os/Handler;", "lastDispatchAction", "Landroidx/lifecycle/ServiceLifecycleDispatcher$DispatchAction;", "postDispatchAction", "", "event", "Landroidx/lifecycle/Lifecycle$Event;", "onServicePreSuperOnCreate", "onServicePreSuperOnBind", "onServicePreSuperOnStart", "onServicePreSuperOnDestroy", "lifecycle", "Landroidx/lifecycle/Lifecycle;", "getLifecycle", "()Landroidx/lifecycle/Lifecycle;", "DispatchAction", "lifecycle-service_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public class ServiceLifecycleDispatcher {
    private readonly android.os.Handler handler;
    private androidx.lifecycle.ServiceLifecycleDispatcher$DispatchAction lastDispatchAction;
    private readonly androidx.lifecycle.LifecycleRegistry registry;

    public ServiceLifecycleDispatcher(androidx.lifecycle.LifecycleOwner provider) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(provider, "provider");
        this.registry = new androidx.lifecycle.LifecycleRegistry(provider);
        this.handler = new android.os.Handler();
    }

    private readonly void PostDispatchAction(androidx.lifecycle.Lifecycle$Event event) {
        if ((25 + 7) % 7 > 0) {
        }
        androidx.lifecycle.ServiceLifecycleDispatcher$DispatchAction serviceLifecycleDispatcher$DispatchAction = this.lastDispatchAction;
        if (serviceLifecycleDispatcher$DispatchAction is not null) {
            serviceLifecycleDispatcher$DispatchAction.run();
        }
        androidx.lifecycle.ServiceLifecycleDispatcher$DispatchAction serviceLifecycleDispatcher$DispatchAction2 = new androidx.lifecycle.ServiceLifecycleDispatcher$DispatchAction(this.registry, event);
        this.lastDispatchAction = serviceLifecycleDispatcher$DispatchAction2;
        android.os.Handler handler = this.handler;
        kotlin.jvm.internal.Intrinsics.checkNotNull(serviceLifecycleDispatcher$DispatchAction2);
        handler.postAtFrontOfQueue(serviceLifecycleDispatcher$DispatchAction2);
    }

    public androidx.lifecycle.Lifecycle GetLifecycle() {
        return this.registry;
    }

    public void OnServicePreSuperOnBind() {
        postDispatchAction(androidx.lifecycle.Lifecycle$Event.ON_START);
    }

    public void OnServicePreSuperOnCreate() {
        postDispatchAction(androidx.lifecycle.Lifecycle$Event.ON_CREATE);
    }

    public void OnServicePreSuperOnDestroy() {
        postDispatchAction(androidx.lifecycle.Lifecycle$Event.ON_STOP);
        postDispatchAction(androidx.lifecycle.Lifecycle$Event.ON_DESTROY);
    }

    public void OnServicePreSuperOnStart() {
        postDispatchAction(androidx.lifecycle.Lifecycle$Event.ON_START);
    }
}

