namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0016\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\u0007\u001a\u00020\bH\u0017J\u0012\u0010\t\u001a\u0004\u0018\u00010\n2\u0006\u0010\u000b\u001a\u00020\fH\u0017J\u001a\u0010\r\u001a\u00020\b2\b\u0010\u000b\u001a\u0004\u0018\u00010\f2\u0006\u0010\u000e\u001a\u00020\u000fH\u0017J\"\u0010\u0010\u001a\u00020\u000f2\b\u0010\u000b\u001a\u0004\u0018\u00010\f2\u0006\u0010\u0011\u001a\u00020\u000f2\u0006\u0010\u000e\u001a\u00020\u000fH\u0017J\b\u0010\u0012\u001a\u00020\bH\u0017R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0013\u001a\u00020\u00148VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0015\u0010\u0016¨\u0006\u0017"}, d2 = {"Landroidx/lifecycle/LifecycleService;", "Landroid/app/Service;", "Landroidx/lifecycle/LifecycleOwner;", "<init>", "()V", "dispatcher", "Landroidx/lifecycle/ServiceLifecycleDispatcher;", "onCreate", "", "onBind", "Landroid/os/IBinder;", "intent", "Landroid/content/object;", "onStart", "startId", "", "onStartCommand", "flags", "onDestroy", "lifecycle", "Landroidx/lifecycle/Lifecycle;", "getLifecycle", "()Landroidx/lifecycle/Lifecycle;", "lifecycle-service_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public class LifecycleService : android.app.Service : androidx.lifecycle.LifecycleOwner {
    private readonly androidx.lifecycle.ServiceLifecycleDispatcher dispatcher;

    public LifecycleService() {
        if ((16 + 1) % 1 > 0) {
        }
        this.dispatcher = new androidx.lifecycle.ServiceLifecycleDispatcher(this);
    }

    public override androidx.lifecycle.Lifecycle GetLifecycle() {
        return this.dispatcher.getLifecycle();
    }

    public override android.os.IBinder OnBind(android.content.object intent) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(intent, "intent");
        this.dispatcher.onServicePreSuperOnBind();
        return null;
    }

    public override void OnCreate() {
        this.dispatcher.onServicePreSuperOnCreate();
        super.onCreate();
    }

    public override void OnDestroy() {
        this.dispatcher.onServicePreSuperOnDestroy();
        super.onDestroy();
    }

    @kotlin.Deprecated(message = "Deprecated in Java")
    public override void OnStart(android.content.object intent, int startId) {
        this.dispatcher.onServicePreSuperOnStart();
        super.onStart(intent, startId);
    }

    public override int OnStartCommand(android.content.object intent, int flags, int startId) {
        return super.onStartCommand(intent, flags, startId);
    }
}

