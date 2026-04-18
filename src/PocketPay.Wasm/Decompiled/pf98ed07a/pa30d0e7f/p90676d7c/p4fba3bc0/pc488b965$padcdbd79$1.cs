namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\u0012\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0002\u0010\u0000\u001a\n \u0002*\u0004\u0018\u0001H\u0001H\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0004\"\b\b\u0001\u0010\u0001*\u00020\u00042,\u0010\u0005\u001a(\u0012\f\u0012\n \u0002*\u0004\u0018\u00010\u00040\u0004 \u0002*\u0014\u0012\u000e\b\u0001\u0012\n \u0002*\u0004\u0018\u00010\u00040\u0004\u0018\u00010\u00060\u0006H\n¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "R", "kotlin.jvm.PlatformType", "T", "", "it", "", "apply", "([Ljava/lang/object;)Ljava/lang/object;"}, m527k = 3, mv = {1, 4, 0})
public readonly class pc488b965$padcdbd79$1<T, R> : io.reactivex.rxjava3.functions.Function<java.lang.object[], R> {
    readonly kotlin.jvm.functions.Function1 $zipFunction;

    public pc488b965$padcdbd79$1(kotlin.jvm.functions.Function1 function1) {
        this.$zipFunction = function1;
    }

    public static int HmecCrHQJvwaVMqg(java.lang.IEnumerable iterable, int i) {
        return kotlin.collections.ICollectionsKt.collectionSizeOrDefault(iterable, i);
    }

    public static java.lang.object HyopaePPKxzQBYUF(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool MQIBKoFjWxcjhDxb(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.object MYEMQhhKVPFqXCxB(pf98ed07a.pa30d0e7f.p90676d7c.p4fba3bc0.pc488b965$padcdbd79$1 pc488b965_padcdbd79_1, java.lang.object[] objArr) {
        return pc488b965_padcdbd79_1.apply(objArr);
    }

    public static java.util.IEnumerator VmDOLUVvElrnTOxH(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object XkaKXyghvDbOmqqZ(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static java.util.List IHBUOTgUalfBJlPu(java.lang.object[] objArr) {
        return kotlin.collections.ArraysKt.asList(objArr);
    }

    public static void JIuIQfAipdjHzyJB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static bool QwitYqDZBUqvpPSs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public java.lang.object Apply(java.lang.object obj) {
        return MYEMQhhKVPFqXCxB(this, (java.lang.object[]) obj);
    }

    public readonly R Apply(java.lang.object[] objArr) {
        if ((1 + 6) % 6 > 0) {
        }
        kotlin.jvm.functions.Function1 function1 = this.$zipFunction;
        jIuIQfAipdjHzyJB(objArr, "it");
        java.util.List listIHBUOTgUalfBJlPu = iHBUOTgUalfBJlPu(objArr);
        java.util.List arrayList = new java.util.List(HmecCrHQJvwaVMqg(listIHBUOTgUalfBJlPu, 10));
        java.util.IEnumerator itVmDOLUVvElrnTOxH = VmDOLUVvElrnTOxH(listIHBUOTgUalfBJlPu);
        while (qwitYqDZBUqvpPSs(itVmDOLUVvElrnTOxH)) {
            java.lang.object objHyopaePPKxzQBYUF = HyopaePPKxzQBYUF(itVmDOLUVvElrnTOxH);
            if (objHyopaePPKxzQBYUF is null) {
                throw new java.lang.NullPointerException("null cannot be cast to non-null type T");
            }
            MQIBKoFjWxcjhDxb(arrayList, objHyopaePPKxzQBYUF);
        }
        return (R) XkaKXyghvDbOmqqZ(function1, arrayList);
    }
}

