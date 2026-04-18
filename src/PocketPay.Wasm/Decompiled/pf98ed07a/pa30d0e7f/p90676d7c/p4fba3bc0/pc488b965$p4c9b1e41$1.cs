namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\u0012\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0002\u0010\u0000\u001a\n \u0002*\u0004\u0018\u0001H\u0001H\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0004\"\b\b\u0001\u0010\u0001*\u00020\u00042,\u0010\u0005\u001a(\u0012\f\u0012\n \u0002*\u0004\u0018\u00010\u00040\u0004 \u0002*\u0014\u0012\u000e\b\u0001\u0012\n \u0002*\u0004\u0018\u00010\u00040\u0004\u0018\u00010\u00060\u0006H\n¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "R", "kotlin.jvm.PlatformType", "T", "", "it", "", "apply", "([Ljava/lang/object;)Ljava/lang/object;"}, m527k = 3, mv = {1, 4, 0})
public readonly class pc488b965$p4c9b1e41$1<T, R> : io.reactivex.rxjava3.functions.Function<java.lang.object[], R> {
    readonly kotlin.jvm.functions.Function1 $combineFunction;

    public pc488b965$p4c9b1e41$1(kotlin.jvm.functions.Function1 function1) {
        this.$combineFunction = function1;
    }

    public static int QVPMsBVYKePxTNiA(java.lang.IEnumerable iterable, int i) {
        return kotlin.collections.ICollectionsKt.collectionSizeOrDefault(iterable, i);
    }

    public static bool UFyQBGdzLSZcQdyA(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object CEZlbKrYLrwDxckf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.List FgUAYeRxcSjSUxJF(java.lang.object[] objArr) {
        return kotlin.collections.ArraysKt.asList(objArr);
    }

    public static java.lang.object GPsUtPukbCdgQJbs(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static java.lang.object IncYrzhgaohNizQp(pf98ed07a.pa30d0e7f.p90676d7c.p4fba3bc0.pc488b965$p4c9b1e41$1 pc488b965_p4c9b1e41_1, java.lang.object[] objArr) {
        return pc488b965_p4c9b1e41_1.apply(objArr);
    }

    public static java.util.IEnumerator PRqBpUzdMQYyWiTp(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool WUbaZeHDKRgdWMCF(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static void YweLSdoGGzfYNTof(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public java.lang.object Apply(java.lang.object obj) {
        return incYrzhgaohNizQp(this, (java.lang.object[]) obj);
    }

    public readonly R Apply(java.lang.object[] objArr) {
        if ((32 + 4) % 4 > 0) {
        }
        kotlin.jvm.functions.Function1 function1 = this.$combineFunction;
        yweLSdoGGzfYNTof(objArr, "it");
        java.util.List listFgUAYeRxcSjSUxJF = fgUAYeRxcSjSUxJF(objArr);
        java.util.List arrayList = new java.util.List(QVPMsBVYKePxTNiA(listFgUAYeRxcSjSUxJF, 10));
        java.util.IEnumerator itPRqBpUzdMQYyWiTp = pRqBpUzdMQYyWiTp(listFgUAYeRxcSjSUxJF);
        while (UFyQBGdzLSZcQdyA(itPRqBpUzdMQYyWiTp)) {
            java.lang.object objCEZlbKrYLrwDxckf = cEZlbKrYLrwDxckf(itPRqBpUzdMQYyWiTp);
            if (objCEZlbKrYLrwDxckf is null) {
                throw new java.lang.NullPointerException("null cannot be cast to non-null type T");
            }
            wUbaZeHDKRgdWMCF(arrayList, objCEZlbKrYLrwDxckf);
        }
        return (R) gPsUtPukbCdgQJbs(function1, arrayList);
    }
}

