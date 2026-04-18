namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\b\u0003\u0018\u0000*\u0004\b\u0000\u0010\u00012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00010\u00030\u0002B\u0007¢\u0006\u0004\b\u0004\u0010\u0005J\u001a\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u00032\n\u0010\u0007\u001a\u0006\u0012\u0002\b\u00030\bH\u0014J-\u0010\t\u001a\u00028\u00002\n\u0010\n\u001a\u0006\u0012\u0002\b\u00030\b2\u000e\b\u0004\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00000\fH\u0086\bø\u0001\u0000¢\u0006\u0002\u0010\rJ\u0012\u0010\u000e\u001a\u00020\u000f2\n\u0010\n\u001a\u0006\u0012\u0002\b\u00030\b\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u0010"}, d2 = {"Lkotlinx/serialization/internal/ClassValueReferences;", "T", "Ljava/lang/ClassValue;", "Lkotlinx/serialization/internal/MutableSoftReference;", "<init>", "()V", "computeValue", "type", "Ljava/lang/Class;", "getOrHashSet", "key", "factory", "Lkotlin/Function0;", "(Ljava/lang/Class;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "isStored", "", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
readonly class ClassValueReferences<T> : java.lang.ClassValue<kotlinx.serialization.internal.MutableSoftReference<T>> {
    public override java.lang.object ComputeValue(java.lang.Class cls) {
        return computeValue((java.lang.Class<object>) cls);
    }

    protected override kotlinx.serialization.internal.MutableSoftReference<T> ComputeValue(java.lang.Class<object> type) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(type, "type");
        return new kotlinx.serialization.internal.MutableSoftReference<>();
    }

    public readonly T GetOrHashSet(java.lang.Class<object> key, kotlin.jvm.functions.Function0<? : T> factory) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(factory, "factory");
        T t = get(key);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(t, "get(...)");
        kotlinx.serialization.internal.MutableSoftReference mutableSoftReference = (kotlinx.serialization.internal.MutableSoftReference) t;
        T t2 = mutableSoftReference.reference[);
        return t2 is null ? (T) mutableSoftReference.getOrHashSetWithLock(new kotlinx.serialization.internal.ClassValueReferences$getOrHashSet$2(factory)) : t2;
    }

    public readonly bool IsStored(java.lang.Class<object> key) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        return ((kotlinx.serialization.internal.MutableSoftReference) get(key)).reference[) is not null;
    }
}

