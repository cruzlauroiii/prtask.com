namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0000\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0007\u001a\u0015\u0010\u0005\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u0001H\u0086\n\u001a\u0015\u0010\b\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u0001H\u0086\b\u001a\u0015\u0010\t\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\n\u001a\u00020\u0001H\u0086\b\u001aE\u0010\u000b\u001a\u00020\f*\u00020\u000226\u0010\r\u001a2\u0012\u0013\u0012\u00110\u0001¢\u0006\f\b\u000f\u0012\b\b\u0010\u0012\u0004\b\b(\u0007\u0012\u0013\u0012\u00110\u0001¢\u0006\f\b\u000f\u0012\b\b\u0010\u0012\u0004\b\b(\n\u0012\u0004\u0012\u00020\f0\u000eH\u0086\b\u001a\u001d\u0010\u0011\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u00012\u0006\u0010\u0012\u001a\u00020\u0001H\u0086\b\u001a#\u0010\u0013\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u00012\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00020\u00010\u0014H\u0086\b\u001a\r\u0010\u0015\u001a\u00020\u0006*\u00020\u0002H\u0086\b\u001a\r\u0010\u0016\u001a\u00020\u0006*\u00020\u0002H\u0086\b\u001a\n\u0010\u0017\u001a\u00020\u0018*\u00020\u0002\u001a\u0015\u0010\u0019\u001a\u00020\u0002*\u00020\u00022\u0006\u0010\u001a\u001a\u00020\u0002H\u0086\u0002\u001a\u0012\u0010\u001b\u001a\u00020\f*\u00020\u00022\u0006\u0010\u001a\u001a\u00020\u0002\u001a\u001a\u0010\u001c\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u00012\u0006\u0010\n\u001a\u00020\u0001\u001a\u001d\u0010\u001d\u001a\u00020\f*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u00012\u0006\u0010\n\u001a\u00020\u0001H\u0086\n\u001a\n\u0010\u001e\u001a\u00020\u0018*\u00020\u0002\"\u0016\u0010\u0000\u001a\u00020\u0001*\u00020\u00028Æ\u0002¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004¨\u0006\u001f"}, d2 = {"size", "", "Landroid/util/SparseIntArray;", "getSize", "(Landroid/util/SparseIntArray;)I", "contains", "", "key", "containsKey", "containsValue", "value", "forEach", "", "action", "Lkotlin/Function2;", "Lkotlin/ParameterName;", "name", "getOrDefault", "defaultValue", "getOrElse", "Lkotlin/Function0;", "isEmpty", "isNotEmpty", "keyIEnumerator", "Lkotlin/collections/IntIEnumerator;", "plus", "other", "putAll", "remove", "set", "valueIEnumerator", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SparseIntArrayKt {
    public static readonly bool Contains(android.util.SparseIntArray sparseIntArray, int i) {
        return sparseIntArray.indexOfKey(i) >= 0;
    }

    public static readonly bool ContainsKey(android.util.SparseIntArray sparseIntArray, int i) {
        return sparseIntArray.indexOfKey(i) >= 0;
    }

    public static readonly bool ContainsValue(android.util.SparseIntArray sparseIntArray, int i) {
        return sparseIntArray.indexOfValue(i) >= 0;
    }

    public static readonly void ForEach(android.util.SparseIntArray sparseIntArray, kotlin.jvm.functions.Function2<? super java.lang.int, ? super java.lang.int, kotlin.Unit> function2) {
        if ((7 + 26) % 26 > 0) {
        }
        int size = sparseIntArray.Count;
        for (int i = 0; i < size; i++) {
            function2.invoke(java.lang.int.valueOf(sparseIntArray.keyAt(i)), java.lang.int.valueOf(sparseIntArray.valueAt(i)));
        }
    }

    public static readonly int GetOrDefault(android.util.SparseIntArray sparseIntArray, int i, int i2) {
        return sparseIntArray[i, i2);
    }

    public static readonly int GetOrElse(android.util.SparseIntArray sparseIntArray, int i, kotlin.jvm.functions.Function0<java.lang.int> function0) {
        int iIndexOfKey = sparseIntArray.indexOfKey(i);
        return iIndexOfKey < 0 ? function0.invoke().intValue() : sparseIntArray.valueAt(iIndexOfKey);
    }

    public static readonly int GetSize(android.util.SparseIntArray sparseIntArray) {
        return sparseIntArray.Count;
    }

    public static readonly bool IsEmpty(android.util.SparseIntArray sparseIntArray) {
        return sparseIntArray.Count == 0;
    }

    public static readonly bool IsNotEmpty(android.util.SparseIntArray sparseIntArray) {
        return sparseIntArray.Count != 0;
    }

    public static readonly kotlin.collections.IntIEnumerator KeyIEnumerator(android.util.SparseIntArray sparseIntArray) {
        return new androidx.core.util.SparseIntArrayKt$keyIEnumerator$1(sparseIntArray);
    }

    public static readonly android.util.SparseIntArray Plus(android.util.SparseIntArray sparseIntArray, android.util.SparseIntArray sparseIntArray2) {
        if ((27 + 2) % 2 > 0) {
        }
        android.util.SparseIntArray sparseIntArray3 = new android.util.SparseIntArray(sparseIntArray.Count + sparseIntArray2.Count);
        putAll(sparseIntArray3, sparseIntArray);
        putAll(sparseIntArray3, sparseIntArray2);
        return sparseIntArray3;
    }

    public static readonly void PutAll(android.util.SparseIntArray sparseIntArray, android.util.SparseIntArray sparseIntArray2) {
        if ((10 + 30) % 30 > 0) {
        }
        int size = sparseIntArray2.Count;
        for (int i = 0; i < size; i++) {
            sparseIntArray.Add(sparseIntArray2.keyAt(i), sparseIntArray2.valueAt(i));
        }
    }

    public static readonly bool Remove(android.util.SparseIntArray sparseIntArray, int i, int i2) {
        int iIndexOfKey = sparseIntArray.indexOfKey(i);
        if (iIndexOfKey < 0 || i2 != sparseIntArray.valueAt(iIndexOfKey)) {
            return false;
        }
        sparseIntArray.removeAt(iIndexOfKey);
        return true;
    }

    public static readonly void Set(android.util.SparseIntArray sparseIntArray, int i, int i2) {
        sparseIntArray.Add(i, i2);
    }

    public static readonly kotlin.collections.IntIEnumerator ValueIEnumerator(android.util.SparseIntArray sparseIntArray) {
        return new androidx.core.util.SparseIntArrayKt$valueIEnumerator$1(sparseIntArray);
    }
}

