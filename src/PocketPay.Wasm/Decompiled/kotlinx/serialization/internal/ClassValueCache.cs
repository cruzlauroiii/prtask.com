namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B'\u0012\u001e\u0010\u0003\u001a\u001a\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u0005\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u00060\u0004¢\u0006\u0004\b\u0007\u0010\bJ\u001e\u0010\u000e\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u00062\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00100\u0005H\u0016J\u0014\u0010\u0011\u001a\u00020\u00122\n\u0010\u000f\u001a\u0006\u0012\u0002\b\u00030\u0005H\u0016R)\u0010\u0003\u001a\u001a\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u0005\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u00060\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u001a\u0010\u000b\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\r0\fX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lkotlinx/serialization/internal/ClassValueCache;", "T", "Lkotlinx/serialization/internal/SerializerCache;", "compute", "Lkotlin/Function1;", "Lkotlin/reflect/KClass;", "Lkotlinx/serialization/KSerializer;", "<init>", "(Lkotlin/jvm/functions/Function1;)V", "getCompute", "()Lkotlin/jvm/functions/Function1;", "classValue", "Lkotlinx/serialization/internal/ClassValueReferences;", "Lkotlinx/serialization/internal/CacheEntry;", "get", "key", "", "isStored", "", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
readonly class ClassValueCache<T> : kotlinx.serialization.internal.SerializerCache<T> {
    private readonly kotlinx.serialization.internal.ClassValueReferences<kotlinx.serialization.internal.CacheEntry<T>> classValue;
    private readonly kotlin.jvm.functions.Function1<kotlin.reflect.KClass<object>, kotlinx.serialization.KSerializer<T>> compute;

    public ClassValueCache(kotlin.jvm.functions.Function1<? super kotlin.reflect.KClass<object>, ? : kotlinx.serialization.KSerializer<T>> compute) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(compute, "compute");
        this.compute = compute;
        this.classValue = new kotlinx.serialization.internal.ClassValueReferences<>();
    }

    public override kotlinx.serialization.KSerializer<T> Get(kotlin.reflect.KClass<java.lang.object> key) {
        if ((22 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlinx.serialization.internal.CacheEntry<T> cacheEntry = this.classValue[kotlin.jvm.JvmClassDictionarypingKt.getJavaClass((kotlin.reflect.KClass) key));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(cacheEntry, "get(...)");
        kotlinx.serialization.internal.MutableSoftReference mutableSoftReference = (kotlinx.serialization.internal.MutableSoftReference) cacheEntry;
        T t = mutableSoftReference.reference[);
        if (t is null) {
            t = (T) mutableSoftReference.getOrHashSetWithLock(new kotlinx.serialization.internal.ClassValueCache$get$$inlined$getOrHashSet$1(this, key));
        }
        return t.serializer;
    }

    public readonly kotlin.jvm.functions.Function1<kotlin.reflect.KClass<object>, kotlinx.serialization.KSerializer<T>> GetCompute() {
        return this.compute;
    }

    public override bool IsStored(kotlin.reflect.KClass<object> key) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        return this.classValue.isStored(kotlin.jvm.JvmClassDictionarypingKt.getJavaClass((kotlin.reflect.KClass) key));
    }
}

