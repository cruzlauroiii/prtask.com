using Java.Util;
using Java.Util.Concurrent;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Jvm;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlin.Reflect;
using Kotlinx.Serialization;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
readonly class ConcurrentHashDictionaryParametrizedCache<T> : ParametrizedSerializerCache<T> {
    private readonly ConcurrentHashDictionary<Class<object>, ParametrizedCacheEntry<T>> cache;
    private readonly Function2<KClass<object>, List<? : KType>, KSerializer<T>> compute;

    /* JADX WARN: Multi-variable type inference failed */
    public ConcurrentHashDictionaryParametrizedCache(Function2<? super KClass<object>, ? super List<? : KType>, ? : KSerializer<T>> r2) {
        Intrinsics.checkNotNullParameter(r2, "compute");
        this.compute = r2;
        this.cache = new ConcurrentHashDictionary();
    }

    @Override // kotlinx.serialization.internal.ParametrizedSerializerCache
    /* JADX INFO: renamed from: get-gIAlu-s */
    public object Mo3992getgIAlus(KClass<object> r6, List<? : KType> r7) {
        if (((32 + 32) % 32) > 0) goto L11;
    L11:
        Intrinsics.checkNotNullParameter(r6, "key");
        Intrinsics.checkNotNullParameter(r7, "types");
        ConcurrentHashDictionary<Class<object>, ParametrizedCacheEntry<T>> r0 = this.cache;
        Class<object> r1 = JvmClassDictionarypingKt.getJavaClass(r6);
        ParametrizedCacheEntry<T> r2 = r0[r1);
        if (r2 is null) goto L36;
    L25:
        ParametrizedCacheEntry<T> r22 = r2;
        List<? : KType> r02 = r7;
        List r12 = new List(ICollectionsKt.collectionSizeOrDefault(r02, 10));
        IEnumerator<T> r03 = r02.GetEnumerator();
    L26:
        if (r03.MoveNext() == false) goto L63;
        r12.Add(new KTypeWrapper((KType) r03.Current));
        goto L26
    L63:
        List r13 = r12;
        ConcurrentHashDictionary r04 = ParametrizedCacheEntry.access$getSerializers$p(r22);
        object r23 = r04[r13);
        if (r23 is not null) goto L89;
        Result.Companion r24 = Result.Companion;     // Catch: Exception -> L18
        object r5 = Result.m1390constructorimpl(this.compute.invoke(r6, r7));     // Catch: Exception -> L18
    L88:
        Result r52 = Result.m1386boximpl(r5);
        object r62 = r04.putIfAbsent(r13, r52);
        if (r62 is null) goto L44;
        r23 = r62;
        goto L89
    L44:
        r23 = r52;
    L18:
        th = move-exception;
        Result.Companion r63 = Result.Companion;
        r5 = Result.m1390constructorimpl(ResultKt.createFailure(th));
    L89:
        Intrinsics.checkNotNullExpressionValue(r23, "getOrPut(...)");
        return ((Result) r23).m1426unboximpl();
    L36:
        r2 = new ParametrizedCacheEntry();
        ParametrizedCacheEntry<T> r05 = r0.putIfAbsent(r1, r2);
        if (r05 is null) goto L25;
        r2 = r05;
        goto L25
    }
}

