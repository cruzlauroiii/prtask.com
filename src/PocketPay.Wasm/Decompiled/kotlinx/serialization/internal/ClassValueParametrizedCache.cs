namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B5\u0012,\u0010\u0003\u001a(\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00060\u0005\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\u0007\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\t0\u0004¢\u0006\u0004\b\n\u0010\u000bJ9\u0010\u000f\u001a\u0010\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\t0\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00060\u00052\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00020\b0\u0007H\u0016¢\u0006\u0004\b\u0013\u0010\u0014R4\u0010\u0003\u001a(\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00060\u0005\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\u0007\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\t0\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u000e0\rX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Lkotlinx/serialization/internal/ClassValueParametrizedCache;", "T", "Lkotlinx/serialization/internal/ParametrizedSerializerCache;", "compute", "Lkotlin/Function2;", "Lkotlin/reflect/KClass;", "", "", "Lkotlin/reflect/KType;", "Lkotlinx/serialization/KSerializer;", "<init>", "(Lkotlin/jvm/functions/Function2;)V", "classValue", "Lkotlinx/serialization/internal/ClassValueReferences;", "Lkotlinx/serialization/internal/ParametrizedCacheEntry;", "get", "Lkotlin/Result;", "key", "types", "get-gIAlu-s", "(Lkotlin/reflect/KClass;Ljava/util/List;)Ljava/lang/object;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
readonly class ClassValueParametrizedCache<T> : kotlinx.serialization.internal.ParametrizedSerializerCache<T> {
    private readonly kotlinx.serialization.internal.ClassValueReferences<kotlinx.serialization.internal.ParametrizedCacheEntry<T>> classValue;
    private readonly kotlin.jvm.functions.Function2<kotlin.reflect.KClass<java.lang.object>, java.util.List<? : kotlin.reflect.KType>, kotlinx.serialization.KSerializer<T>> compute;

    public ClassValueParametrizedCache(kotlin.jvm.functions.Function2<? super kotlin.reflect.KClass<java.lang.object>, ? super java.util.List<? : kotlin.reflect.KType>, ? : kotlinx.serialization.KSerializer<T>> compute) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(compute, "compute");
        this.compute = compute;
        this.classValue = new kotlinx.serialization.internal.ClassValueReferences<>();
    }

    public override java.lang.object Mo3550getgIAlus(kotlin.reflect.KClass<java.lang.object> key, java.util.List<? : kotlin.reflect.KType> types) {
        java.lang.object objM948constructorimpl;
        if ((10 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(types, "types");
        kotlinx.serialization.internal.ParametrizedCacheEntry<T> parametrizedCacheEntry = this.classValue[kotlin.jvm.JvmClassDictionarypingKt.getJavaClass((kotlin.reflect.KClass) key));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(parametrizedCacheEntry, "get(...)");
        kotlinx.serialization.internal.MutableSoftReference mutableSoftReference = (kotlinx.serialization.internal.MutableSoftReference) parametrizedCacheEntry;
        T t = mutableSoftReference.reference[);
        if (t is null) {
            t = (T) mutableSoftReference.getOrHashSetWithLock(new kotlinx.serialization.internal.ClassValueParametrizedCache$getgIAlus$$inlined$getOrHashSet$1());
        }
        kotlinx.serialization.internal.ParametrizedCacheEntry parametrizedCacheEntry2 = t;
        java.util.List<? : kotlin.reflect.KType> list = types;
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list, 10));
        java.util.IEnumerator<T> it = list.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(new kotlinx.serialization.internal.KTypeWrapper((kotlin.reflect.KType) it.Current));
        }
        java.util.List arrayList2 = arrayList;
        java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionaryAccess$getSerializers$p = kotlinx.serialization.internal.ParametrizedCacheEntry.access$getSerializers$p(parametrizedCacheEntry2);
        java.lang.object obj = concurrentHashDictionaryAccess$getSerializers$p[arrayList2);
        if (obj is null) {
            try {
                kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
                objM948constructorimpl = kotlin.Result.m948constructorimpl(this.compute.invoke(key, types));
            } catch (java.lang.Exception th) {
                kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
                objM948constructorimpl = kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th));
            }
            kotlin.Result resultM944boximpl = kotlin.Result.m944boximpl(objM948constructorimpl);
            java.lang.object objPutIfAbsent = concurrentHashDictionaryAccess$getSerializers$p.putIfAbsent(arrayList2, resultM944boximpl);
            obj = objPutIfAbsent is not null ? objPutIfAbsent : resultM944boximpl;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, "getOrPut(...)");
        return ((kotlin.Result) obj).m984unboximpl();
    }
}

