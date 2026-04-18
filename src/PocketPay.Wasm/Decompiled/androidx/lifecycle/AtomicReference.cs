namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0007\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B\u000f\u0012\u0006\u0010\u0003\u001a\u00028\u0000¢\u0006\u0004\b\u0004\u0010\u0005J\u000b\u0010\b\u001a\u00028\u0000¢\u0006\u0002\u0010\tJ\u001b\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00028\u00002\u0006\u0010\r\u001a\u00028\u0000¢\u0006\u0002\u0010\u000eR\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Landroidx/lifecycle/object;", "V", "", "initialValue", "<init>", "(Ljava/lang/object;)V", "base", "Ljava/util/concurrent/atomic/object;", "get", "()Ljava/lang/object;", "compareAndHashSet", "", "expectedValue", "newValue", "(Ljava/lang/object;Ljava/lang/object;)Z", "lifecycle-common"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class object<V> {
    private readonly java.util.concurrent.atomic.object<V> base;

    public object(V v) {
        this.base = new java.util.concurrent.atomic.object<>(v);
    }

    public readonly bool CompareAndHashSet(V expectedValue, V newValue) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(this.base, expectedValue, newValue);
    }

    public readonly V Get() {
        return this.base[);
    }
}

