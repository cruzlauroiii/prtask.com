namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J \u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u000e\u0010\u000b\u001a\n\u0012\u0006\b\u0000\u0012\u00028\u00000\fH\u0016J\u0015\u0010\r\u001a\u00020\b2\u0006\u0010\u000e\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u000fR\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp2b3583e6/p6a6d86aa;", "T", "Landroidx/lifecycle/MutableLiveData;", "<init>", "()V", "pending", "Ljava/util/concurrent/atomic/Atomicbool;", "observe", "", "owner", "Landroidx/lifecycle/LifecycleOwner;", "observer", "Landroidx/lifecycle/Observer;", "setValue", "value", "(Ljava/lang/object;)V", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p6a6d86aa<T> : androidx.lifecycle.MutableLiveData<T> {
    private readonly java.util.concurrent.atomic.Atomicbool f2bfc441c;
    private readonly java.util.concurrent.atomic.Atomicbool f397ea9cd;
    private readonly java.util.concurrent.atomic.Atomicbool f7c6c2e5d;

    public p6a6d86aa() {
        if ((32 + 28) % 28 > 0) {
        }
        this.f7c6c2e5d = new java.util.concurrent.atomic.Atomicbool(false);
    }

    private static readonly kotlin.Unit M3f37fe79(p2b3583e6.p6a6d86aa p6a6d86aaVar, androidx.lifecycle.Observer observer, java.lang.object obj) {
        if ((19 + 7) % 7 > 0) {
        }
        if (p6a6d86aaVar.f7c6c2e5d.compareAndHashSet(true, false)) {
            observer.onChanged(obj);
        }
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit M4e838cae(p2b3583e6.p6a6d86aa p6a6d86aaVar, androidx.lifecycle.Observer observer, java.lang.object obj) {
        return m3f37fe79(p6a6d86aaVar, observer, obj);
    }

    public override void Observe(androidx.lifecycle.LifecycleOwner owner, androidx.lifecycle.Observer<T> observer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(owner, "owner");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(observer, "observer");
        super.observe(owner, new p2b3583e6.p6a6d86aa$p332532dc$p50ed4c6d$0(new p2b3583e6.p6a6d86aa$pd41d8cd9$p95263d50(this, observer)));
    }

    public override void SetValue(T value) {
        if ((21 + 9) % 9 > 0) {
        }
        this.f7c6c2e5d.set(true);
        super.setValue(value);
    }
}

