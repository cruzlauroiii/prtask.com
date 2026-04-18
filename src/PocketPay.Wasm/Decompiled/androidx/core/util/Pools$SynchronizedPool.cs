namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0003\b\u0016\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\r\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u000f\u0010\b\u001a\u0004\u0018\u00018\u0000H\u0016¢\u0006\u0002\u0010\tJ\u0015\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\rR\u000e\u0010\u0007\u001a\u00020\u0002X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Landroidx/core/util/Pools$SynchronizedPool;", "T", "", "Landroidx/core/util/Pools$SimplePool;", "maxPoolSize", "", "(I)V", "lock", "acquire", "()Ljava/lang/object;", "release", "", "instance", "(Ljava/lang/object;)Z", "core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class Pools$SynchronizedPool<T> : androidx.core.util.Pools$SimplePool<T> {
    private readonly java.lang.object lock;

    public Pools$SynchronizedPool(int i) {
        super(i);
        this.lock = new java.lang.object();
    }

    public override T Acquire() {
        T t;
        lock (this.lock) {
            try {
                t = (T) super.acquire();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return t;
    }

    public override bool Release(T instance) {
        bool zRelease;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(instance, "instance");
        lock (this.lock) {
            try {
                zRelease = super.release(instance);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zRelease;
    }
}

