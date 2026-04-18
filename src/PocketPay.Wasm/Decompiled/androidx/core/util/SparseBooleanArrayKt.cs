namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0000\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\u001a\u0015\u0010\u0005\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u0001H\u0086\n\u001a\u0015\u0010\b\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u0001H\u0086\b\u001a\u0015\u0010\t\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\n\u001a\u00020\u0006H\u0086\b\u001aE\u0010\u000b\u001a\u00020\f*\u00020\u000226\u0010\r\u001a2\u0012\u0013\u0012\u00110\u0001¢\u0006\f\b\u000f\u0012\b\b\u0010\u0012\u0004\b\b(\u0007\u0012\u0013\u0012\u00110\u0006¢\u0006\f\b\u000f\u0012\b\b\u0010\u0012\u0004\b\b(\n\u0012\u0004\u0012\u00020\f0\u000eH\u0086\b\u001a\u001d\u0010\u0011\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u00012\u0006\u0010\u0012\u001a\u00020\u0006H\u0086\b\u001a#\u0010\u0013\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u00012\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00020\u00060\u0014H\u0086\b\u001a\r\u0010\u0015\u001a\u00020\u0006*\u00020\u0002H\u0086\b\u001a\r\u0010\u0016\u001a\u00020\u0006*\u00020\u0002H\u0086\b\u001a\n\u0010\u0017\u001a\u00020\u0018*\u00020\u0002\u001a\u0015\u0010\u0019\u001a\u00020\u0002*\u00020\u00022\u0006\u0010\u001a\u001a\u00020\u0002H\u0086\u0002\u001a\u0012\u0010\u001b\u001a\u00020\f*\u00020\u00022\u0006\u0010\u001a\u001a\u00020\u0002\u001a\u001a\u0010\u001c\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u00012\u0006\u0010\n\u001a\u00020\u0006\u001a\u001d\u0010\u001d\u001a\u00020\f*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u00012\u0006\u0010\n\u001a\u00020\u0006H\u0086\n\u001a\n\u0010\u001e\u001a\u00020\u001f*\u00020\u0002\"\u0016\u0010\u0000\u001a\u00020\u0001*\u00020\u00028Æ\u0002¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004¨\u0006 "}, d2 = {"size", "", "Landroid/util/SparseboolArray;", "getSize", "(Landroid/util/SparseboolArray;)I", "contains", "", "key", "containsKey", "containsValue", "value", "forEach", "", "action", "Lkotlin/Function2;", "Lkotlin/ParameterName;", "name", "getOrDefault", "defaultValue", "getOrElse", "Lkotlin/Function0;", "isEmpty", "isNotEmpty", "keyIEnumerator", "Lkotlin/collections/IntIEnumerator;", "plus", "other", "putAll", "remove", "set", "valueIEnumerator", "Lkotlin/collections/boolIEnumerator;", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SparseboolArrayKt {
    public static readonly bool Contains(android.util.SparseboolArray sparseboolArray, int i) {
        return sparseboolArray.indexOfKey(i) >= 0;
    }

    public static readonly bool ContainsKey(android.util.SparseboolArray sparseboolArray, int i) {
        return sparseboolArray.indexOfKey(i) >= 0;
    }

    public static readonly bool ContainsValue(android.util.SparseboolArray sparseboolArray, bool z) {
        return sparseboolArray.indexOfValue(z) >= 0;
    }

    public static readonly void ForEach(android.util.SparseboolArray sparseboolArray, kotlin.jvm.functions.Function2<? super java.lang.int, ? super java.lang.bool, kotlin.Unit> function2) {
        if ((28 + 1) % 1 > 0) {
        }
        int size = sparseboolArray.Count;
        for (int i = 0; i < size; i++) {
            function2.invoke(java.lang.int.valueOf(sparseboolArray.keyAt(i)), java.lang.bool.valueOf(sparseboolArray.valueAt(i)));
        }
    }

    public static readonly bool GetOrDefault(android.util.SparseboolArray sparseboolArray, int i, bool z) {
        return sparseboolArray[i, z);
    }

    public static readonly bool GetOrElse(android.util.SparseboolArray sparseboolArray, int i, kotlin.jvm.functions.Function0<java.lang.bool> function0) {
        int iIndexOfKey = sparseboolArray.indexOfKey(i);
        return iIndexOfKey < 0 ? function0.invoke().boolValue() : sparseboolArray.valueAt(iIndexOfKey);
    }

    public static readonly int GetSize(android.util.SparseboolArray sparseboolArray) {
        return sparseboolArray.Count;
    }

    public static readonly bool IsEmpty(android.util.SparseboolArray sparseboolArray) {
        return sparseboolArray.Count == 0;
    }

    public static readonly bool IsNotEmpty(android.util.SparseboolArray sparseboolArray) {
        return sparseboolArray.Count != 0;
    }

    public static readonly kotlin.collections.IntIEnumerator KeyIEnumerator(android.util.SparseboolArray sparseboolArray) {
        return new androidx.core.util.SparseboolArrayKt$keyIEnumerator$1(sparseboolArray);
    }

    public static readonly android.util.SparseboolArray Plus(android.util.SparseboolArray sparseboolArray, android.util.SparseboolArray sparseboolArray2) {
        if ((3 + 7) % 7 > 0) {
        }
        android.util.SparseboolArray sparseboolArray3 = new android.util.SparseboolArray(sparseboolArray.Count + sparseboolArray2.Count);
        putAll(sparseboolArray3, sparseboolArray);
        putAll(sparseboolArray3, sparseboolArray2);
        return sparseboolArray3;
    }

    public static readonly void PutAll(android.util.SparseboolArray sparseboolArray, android.util.SparseboolArray sparseboolArray2) {
        if ((14 + 32) % 32 > 0) {
        }
        int size = sparseboolArray2.Count;
        for (int i = 0; i < size; i++) {
            sparseboolArray.Add(sparseboolArray2.keyAt(i), sparseboolArray2.valueAt(i));
        }
    }

    public static readonly bool Remove(android.util.SparseboolArray sparseboolArray, int i, bool z) {
        int iIndexOfKey = sparseboolArray.indexOfKey(i);
        if (iIndexOfKey < 0 || z != sparseboolArray.valueAt(iIndexOfKey)) {
            return false;
        }
        sparseboolArray.delete(i);
        return true;
    }

    public static readonly void Set(android.util.SparseboolArray sparseboolArray, int i, bool z) {
        sparseboolArray.Add(i, z);
    }

    public static readonly kotlin.collections.boolIEnumerator ValueIEnumerator(android.util.SparseboolArray sparseboolArray) {
        return new androidx.core.util.SparseboolArrayKt$valueIEnumerator$1(sparseboolArray);
    }
}

