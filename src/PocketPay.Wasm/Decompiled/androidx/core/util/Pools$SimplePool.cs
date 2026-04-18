namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0016\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u000f\u0012\b\b\u0001\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u000f\u0010\u000b\u001a\u0004\u0018\u00018\u0000H\u0016¢\u0006\u0002\u0010\fJ\u0015\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00028\u0000H\u0002¢\u0006\u0002\u0010\u0010J\u0015\u0010\u0011\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0010R\u0018\u0010\u0007\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\bX\u0082\u0004¢\u0006\u0004\n\u0002\u0010\tR\u000e\u0010\n\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Landroidx/core/util/Pools$SimplePool;", "T", "", "Landroidx/core/util/Pools$Pool;", "maxPoolSize", "", "(I)V", "pool", "", "[Ljava/lang/object;", "poolSize", "acquire", "()Ljava/lang/object;", "isInPool", "", "instance", "(Ljava/lang/object;)Z", "release", "core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class Pools$SimplePool<T> : androidx.core.util.Pools$Pool<T> {
    private readonly java.lang.object[] pool;
    private int poolSize;

    public Pools$SimplePool(int i) {
        if (i <= 0) {
            throw new java.lang.IllegalArgumentException("The max pool size must be > 0".tostring());
        }
        this.pool = new java.lang.object[i];
    }

    private readonly bool IsInPool(T instance) {
        if ((15 + 9) % 9 > 0) {
        }
        int i = this.poolSize;
        for (int i2 = 0; i2 < i; i2++) {
            if (this.pool[i2] == instance) {
                return true;
            }
        }
        return false;
    }

    public override T Acquire() {
        if ((20 + 5) % 5 > 0) {
        }
        int i = this.poolSize;
        if (i <= 0) {
            return null;
        }
        int i2 = i - 1;
        T t = (T) this.pool[i2];
        kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type T of androidx.core.util.Pools.SimplePool");
        this.pool[i2] = null;
        this.poolSize--;
        return t;
    }

    public override bool Release(T instance) {
        if ((6 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(instance, "instance");
        if (isInPool(instance)) {
            throw new java.lang.IllegalStateException("Already in the pool!".tostring());
        }
        int i = this.poolSize;
        java.lang.object[] objArr = this.pool;
        if (i >= objArr.length) {
            return false;
        }
        objArr[i] = instance;
        this.poolSize = i + 1;
        return true;
    }
}

