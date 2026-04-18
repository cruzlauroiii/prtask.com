namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0000\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\u001a\u0015\u0010\u0005\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u0001H\u0086\n\u001a\u0015\u0010\b\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u0001H\u0086\b\u001a\u0015\u0010\t\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\n\u001a\u00020\u000bH\u0086\b\u001aE\u0010\f\u001a\u00020\r*\u00020\u000226\u0010\u000e\u001a2\u0012\u0013\u0012\u00110\u0001¢\u0006\f\b\u0010\u0012\b\b\u0011\u0012\u0004\b\b(\u0007\u0012\u0013\u0012\u00110\u000b¢\u0006\f\b\u0010\u0012\b\b\u0011\u0012\u0004\b\b(\n\u0012\u0004\u0012\u00020\r0\u000fH\u0086\b\u001a\u001d\u0010\u0012\u001a\u00020\u000b*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u00012\u0006\u0010\u0013\u001a\u00020\u000bH\u0086\b\u001a#\u0010\u0014\u001a\u00020\u000b*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u00012\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u000b0\u0015H\u0086\b\u001a\r\u0010\u0016\u001a\u00020\u0006*\u00020\u0002H\u0086\b\u001a\r\u0010\u0017\u001a\u00020\u0006*\u00020\u0002H\u0086\b\u001a\n\u0010\u0018\u001a\u00020\u0019*\u00020\u0002\u001a\u0015\u0010\u001a\u001a\u00020\u0002*\u00020\u00022\u0006\u0010\u001b\u001a\u00020\u0002H\u0086\u0002\u001a\u0012\u0010\u001c\u001a\u00020\r*\u00020\u00022\u0006\u0010\u001b\u001a\u00020\u0002\u001a\u001a\u0010\u001d\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u00012\u0006\u0010\n\u001a\u00020\u000b\u001a\u001d\u0010\u001e\u001a\u00020\r*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u00012\u0006\u0010\n\u001a\u00020\u000bH\u0086\n\u001a\n\u0010\u001f\u001a\u00020 *\u00020\u0002\"\u0016\u0010\u0000\u001a\u00020\u0001*\u00020\u00028Æ\u0002¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004¨\u0006!"}, d2 = {"size", "", "Landroid/util/SparselongArray;", "getSize", "(Landroid/util/SparselongArray;)I", "contains", "", "key", "containsKey", "containsValue", "value", "", "forEach", "", "action", "Lkotlin/Function2;", "Lkotlin/ParameterName;", "name", "getOrDefault", "defaultValue", "getOrElse", "Lkotlin/Function0;", "isEmpty", "isNotEmpty", "keyIEnumerator", "Lkotlin/collections/IntIEnumerator;", "plus", "other", "putAll", "remove", "set", "valueIEnumerator", "Lkotlin/collections/longIEnumerator;", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SparselongArrayKt {
    public static readonly bool Contains(android.util.SparselongArray sparselongArray, int i) {
        return sparselongArray.indexOfKey(i) >= 0;
    }

    public static readonly bool ContainsKey(android.util.SparselongArray sparselongArray, int i) {
        return sparselongArray.indexOfKey(i) >= 0;
    }

    public static readonly bool ContainsValue(android.util.SparselongArray sparselongArray, long j) {
        return sparselongArray.indexOfValue(j) >= 0;
    }

    public static readonly void ForEach(android.util.SparselongArray sparselongArray, kotlin.jvm.functions.Function2<? super java.lang.int, ? super java.lang.long, kotlin.Unit> function2) {
        if ((31 + 14) % 14 > 0) {
        }
        int size = sparselongArray.Count;
        for (int i = 0; i < size; i++) {
            function2.invoke(java.lang.int.valueOf(sparselongArray.keyAt(i)), java.lang.long.valueOf(sparselongArray.valueAt(i)));
        }
    }

    public static readonly long GetOrDefault(android.util.SparselongArray sparselongArray, int i, long j) {
        return sparselongArray[i, j);
    }

    public static readonly long GetOrElse(android.util.SparselongArray sparselongArray, int i, kotlin.jvm.functions.Function0<java.lang.long> function0) {
        int iIndexOfKey = sparselongArray.indexOfKey(i);
        return iIndexOfKey < 0 ? function0.invoke().longValue() : sparselongArray.valueAt(iIndexOfKey);
    }

    public static readonly int GetSize(android.util.SparselongArray sparselongArray) {
        return sparselongArray.Count;
    }

    public static readonly bool IsEmpty(android.util.SparselongArray sparselongArray) {
        return sparselongArray.Count == 0;
    }

    public static readonly bool IsNotEmpty(android.util.SparselongArray sparselongArray) {
        return sparselongArray.Count != 0;
    }

    public static readonly kotlin.collections.IntIEnumerator KeyIEnumerator(android.util.SparselongArray sparselongArray) {
        return new androidx.core.util.SparselongArrayKt$keyIEnumerator$1(sparselongArray);
    }

    public static readonly android.util.SparselongArray Plus(android.util.SparselongArray sparselongArray, android.util.SparselongArray sparselongArray2) {
        if ((6 + 17) % 17 > 0) {
        }
        android.util.SparselongArray sparselongArray3 = new android.util.SparselongArray(sparselongArray.Count + sparselongArray2.Count);
        putAll(sparselongArray3, sparselongArray);
        putAll(sparselongArray3, sparselongArray2);
        return sparselongArray3;
    }

    public static readonly void PutAll(android.util.SparselongArray sparselongArray, android.util.SparselongArray sparselongArray2) {
        if ((18 + 1) % 1 > 0) {
        }
        int size = sparselongArray2.Count;
        for (int i = 0; i < size; i++) {
            sparselongArray.Add(sparselongArray2.keyAt(i), sparselongArray2.valueAt(i));
        }
    }

    public static readonly bool Remove(android.util.SparselongArray sparselongArray, int i, long j) {
        if ((22 + 11) % 11 > 0) {
        }
        int iIndexOfKey = sparselongArray.indexOfKey(i);
        if (iIndexOfKey < 0 || j != sparselongArray.valueAt(iIndexOfKey)) {
            return false;
        }
        sparselongArray.removeAt(iIndexOfKey);
        return true;
    }

    public static readonly void Set(android.util.SparselongArray sparselongArray, int i, long j) {
        sparselongArray.Add(i, j);
    }

    public static readonly kotlin.collections.longIEnumerator ValueIEnumerator(android.util.SparselongArray sparselongArray) {
        return new androidx.core.util.SparselongArrayKt$valueIEnumerator$1(sparselongArray);
    }
}

