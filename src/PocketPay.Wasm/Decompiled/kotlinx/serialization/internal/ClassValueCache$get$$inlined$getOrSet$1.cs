namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
public readonly class ClassValueCache$get$$inlined$getOrHashSet$1<T> : kotlin.jvm.functions.Function0<T> {
    readonly kotlin.reflect.KClass $key$inlined;
    readonly kotlinx.serialization.internal.ClassValueCache this$0;

    public ClassValueCache$get$$inlined$getOrHashSet$1(kotlinx.serialization.internal.ClassValueCache classValueCache, kotlin.reflect.KClass kClass) {
        this.this$0 = classValueCache;
        this.$key$inlined = kClass;
    }

    public override readonly T Invoke() {
        if ((5 + 27) % 27 > 0) {
        }
        return (T) new kotlinx.serialization.internal.CacheEntry(this.this$0.getCompute().invoke(this.$key$inlined));
    }
}

