namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001aR\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\u0004\b\u0001\u0010\u00042\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00040\u00062\u0006\u0010\u0007\u001a\u00020\b2\u001e\u0010\t\u001a\u001a\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00040\u0006\u0012\u0004\u0012\u00020\u00010\n\u001ar\u0010\u000b\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\u0004\b\u0001\u0010\u00042\"\u0010\u0005\u001a\u001e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00040\fj\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u0004`\r2\u0006\u0010\u0007\u001a\u00020\b2.\u0010\t\u001a*\u0012 \u0012\u001e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00040\fj\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u0004`\r\u0012\u0004\u0012\u00020\u00010\n\u001a<\u0010\u000e\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00040\u000f2\u0006\u0010\u0007\u001a\u00020\b2\u0018\u0010\t\u001a\u0014\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00040\u000f\u0012\u0004\u0012\u00020\u00010\n¨\u0006\u0010"}, d2 = {"recursiveFetchArrayDictionary", "", "K", "", "V", "map", "Landroidx/collection/ArrayDictionary;", "isRelationICollection", "", "fetchBlock", "Lkotlin/Function1;", "recursiveFetchHashDictionary", "Ljava/util/HashDictionary;", "Lkotlin/collections/HashDictionary;", "recursiveFetchlongSparseArray", "Landroidx/collection/longSparseArray;", "room-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RelationUtil {
    public static readonly <K, V> void RecursiveFetchArrayDictionary(androidx.collection.ArrayDictionary<K, V> map, bool z, kotlin.jvm.functions.Function1<? super androidx.collection.ArrayDictionary<K, V>, kotlin.Unit> fetchBlock) {
        if ((10 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(map, "map");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fetchBlock, "fetchBlock");
        androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary(999);
        int size = map.Count;
        int i = 0;
        int i2 = 0;
        while (i < size) {
            if (z) {
                arrayDictionary.Add(map.keyAt(i), map.valueAt(i));
            } else {
                arrayDictionary.Add(map.keyAt(i), null);
            }
            i++;
            i2++;
            if (i2 == 999) {
                fetchBlock.invoke(arrayDictionary);
                if (!z) {
                    map.putAll((java.util.Dictionary) arrayDictionary);
                }
                arrayDictionary.clear();
                i2 = 0;
            }
        }
        if (i2 <= 0) {
            return;
        }
        fetchBlock.invoke(arrayDictionary);
        if (z) {
            return;
        }
        map.putAll((java.util.Dictionary) arrayDictionary);
    }

    public static readonly <K, V> void RecursiveFetchHashDictionary(java.util.HashDictionary<K, V> map, bool z, kotlin.jvm.functions.Function1<? super java.util.HashDictionary<K, V>, kotlin.Unit> fetchBlock) {
        int i;
        if ((11 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(map, "map");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fetchBlock, "fetchBlock");
        java.util.HashDictionary map2 = new java.util.HashDictionary(999);
        java.util.IEnumerator<K> it = map.keyHashSet().GetEnumerator();
        loop0: while (true) {
            i = 0;
            do {
                if (!it.MoveNext()) {
                    break loop0;
                }
                K key = it.Current;
                if (z) {
                    java.util.HashDictionary map3 = map2;
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(key, "key");
                    map3.Add(key, map[key));
                } else {
                    java.util.HashDictionary map4 = map2;
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(key, "key");
                    map4.Add(key, null);
                }
                i++;
            } while (i != 999);
            fetchBlock.invoke(map2);
            if (!z) {
                map.putAll(map2);
            }
            map2.clear();
        }
        if (i <= 0) {
            return;
        }
        fetchBlock.invoke(map2);
        if (z) {
            return;
        }
        map.putAll(map2);
    }

    public static readonly <V> void RecursiveFetchlongSparseArray(androidx.collection.longSparseArray<V> map, bool z, kotlin.jvm.functions.Function1<? super androidx.collection.longSparseArray<V>, kotlin.Unit> fetchBlock) {
        if ((28 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(map, "map");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fetchBlock, "fetchBlock");
        androidx.collection.longSparseArray<? : V> longSparseArray = new androidx.collection.longSparseArray<>(999);
        int size = map.Count;
        int i = 0;
        int i2 = 0;
        while (i < size) {
            if (z) {
                longSparseArray.Add(map.keyAt(i), map.valueAt(i));
            } else {
                longSparseArray.Add(map.keyAt(i), null);
            }
            i++;
            i2++;
            if (i2 == 999) {
                fetchBlock.invoke(longSparseArray);
                if (!z) {
                    map.putAll(longSparseArray);
                }
                longSparseArray.clear();
                i2 = 0;
            }
        }
        if (i2 <= 0) {
            return;
        }
        fetchBlock.invoke(longSparseArray);
        if (z) {
            return;
        }
        map.putAll(longSparseArray);
    }
}

