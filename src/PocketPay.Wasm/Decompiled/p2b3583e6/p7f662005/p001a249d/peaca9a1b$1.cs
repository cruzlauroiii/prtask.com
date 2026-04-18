namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0004H\u0016J\u0010\u0010\n\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0004H\u0016R\u0019\u0010\u0002\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u000b"}, d2 = {"utils/delegate/binding/objectobjectBindingDelegate$1", "Landroidx/lifecycle/DefaultLifecycleObserver;", "viewLifecycleOwnerLiveDataObserver", "Landroidx/lifecycle/Observer;", "Landroidx/lifecycle/LifecycleOwner;", "getobjectLifecycleOwnerLiveDataObserver", "()Landroidx/lifecycle/Observer;", "onCreate", "", "owner", "onDestroy", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class peaca9a1b$1 : androidx.lifecycle.DefaultLifecycleObserver {
    private readonly androidx.lifecycle.Observer<androidx.lifecycle.LifecycleOwner> f0bed3cb6;
    private readonly androidx.lifecycle.Observer fd8275c46;
    readonly utils.delegate.binding.objectobjectBindingDelegate<T> this$0;

    peaca9a1b$1(utils.delegate.binding.objectobjectBindingDelegate<T> fragmentobjectBindingDelegate) {
        this.this$0 = fragmentobjectBindingDelegate;
        this.f0bed3cb6 = new p2b3583e6.p7f662005.p001a249d.peaca9a1b$1$pd41d8cd9$p95263d50(fragmentobjectBindingDelegate);
    }

    public static void M1634d1a4(p2b3583e6.p7f662005.p001a249d.peaca9a1b peaca9a1bVar, androidx.lifecycle.LifecycleOwner lifecycleOwner) {
        m78982db2(peaca9a1bVar, lifecycleOwner);
    }

    private static readonly void M78982db2(p2b3583e6.p7f662005.p001a249d.peaca9a1b peaca9a1bVar, androidx.lifecycle.LifecycleOwner lifecycleOwner) {
        if (lifecycleOwner is not null) {
            lifecycleOwner.getLifecycle().addObserver(new p2b3583e6.p7f662005.p001a249d.peaca9a1b$1$p0bed3cb6$1$1(peaca9a1bVar));
        }
    }

    public readonly androidx.lifecycle.Observer<androidx.lifecycle.LifecycleOwner> GetobjectLifecycleOwnerLiveDataObserver() {
        return this.f0bed3cb6;
    }

    public override void OnCreate(androidx.lifecycle.LifecycleOwner owner) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(owner, "owner");
        p2b3583e6.p7f662005.p001a249d.peaca9a1b.m7b72fb5a(this.this$0).getobjectLifecycleOwnerLiveData().observeForever(this.f0bed3cb6);
    }

    public override void OnDestroy(androidx.lifecycle.LifecycleOwner owner) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(owner, "owner");
        p2b3583e6.p7f662005.p001a249d.peaca9a1b.m7b72fb5a(this.this$0).getobjectLifecycleOwnerLiveData().removeObserver(this.f0bed3cb6);
    }
}

