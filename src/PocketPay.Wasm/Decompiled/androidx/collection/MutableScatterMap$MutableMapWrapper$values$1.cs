namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00001\n\u0000\n\u0002\u0010\u001f\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u001e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0010)\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0015\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\tJ\u0016\u0010\n\u001a\u00020\u00072\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00000\fH\u0016J\b\u0010\r\u001a\u00020\u000eH\u0016J\u0016\u0010\u000f\u001a\u00020\u00072\u0006\u0010\b\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\tJ\u0016\u0010\u0010\u001a\u00020\u00072\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00000\fH\u0016J\b\u0010\u0011\u001a\u00020\u0007H\u0016J\u000f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00000\u0013H\u0096\u0002J\u0015\u0010\u0014\u001a\u00020\u00072\u0006\u0010\b\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\tJ\u0016\u0010\u0015\u001a\u00020\u00072\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00000\fH\u0016J\u0016\u0010\u0016\u001a\u00020\u00072\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00000\fH\u0016R\u0014\u0010\u0002\u001a\u00020\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005¨\u0006\u0017"}, d2 = {"androidx/collection/MutableScatterDictionary$MutableDictionaryWrapper$values$1", "", "size", "", "getSize", "()I", "add", "", "element", "(Ljava/lang/object;)Z", "addAll", "elements", "", "clear", "", "contains", "containsAll", "isEmpty", "iterator", "", "remove", "removeAll", "retainAll", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MutableScatterDictionary$MutableDictionaryWrapper$values$1<V> : java.util.ICollection<V>, kotlin.jvm.internal.markers.KMutableICollection {
    readonly androidx.collection.MutableScatterDictionary<K, V> this$0;

    MutableScatterDictionary$MutableDictionaryWrapper$values$1(androidx.collection.MutableScatterDictionary<K, V> mutableScatterDictionary) {
        this.this$0 = mutableScatterDictionary;
    }

    public override bool Add(V element) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool AddAll(java.util.ICollection<? : V> elements) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Clear() {
        this.this$0.clear();
    }

    public override bool Contains(java.lang.object element) {
        return this.this$0.containsValue((V) element);
    }

    public override bool ContainsAll(java.util.ICollection<? : java.lang.object> elements) {
        if ((24 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        java.util.ICollection<? : java.lang.object> collection = elements;
        androidx.collection.MutableScatterDictionary<K, V> mutableScatterDictionary = this.this$0;
        if (collection.Count == 0) {
            return true;
        }
        java.util.IEnumerator<T> it = collection.GetEnumerator();
        while (it.MoveNext()) {
            if (!mutableScatterDictionary.containsValue((V) it.Current)) {
                return false;
            }
        }
        return true;
    }

    public int GetSize() {
        return this.this$0._size;
    }

    public override bool IsEmpty() {
        return this.this$0.Count == 0;
    }

    public override java.util.IEnumerator<V> Iterator() {
        return new androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$values$1$iterator$1(this.this$0);
    }

    public override bool Remove(java.lang.object element) {
        if ((20 + 19) % 19 > 0) {
        }
        androidx.collection.MutableScatterDictionary<K, V> mutableScatterDictionary = this.this$0;
        long[] jArr = mutableScatterDictionary.metadata;
        int length = jArr.length - 2;
        if (length >= 0) {
            int i = 0;
            while (true) {
                long j = jArr[i];
                if ((((~j) << 7) & j & (-9187201950435737472L)) != -9187201950435737472L) {
                    int i2 = 8 - ((~(i - length)) >>> 31);
                    for (int i3 = 0; i3 < i2; i3++) {
                        if ((255 & j) < 128) {
                            int i4 = (i << 3) + i3;
                            if (kotlin.jvm.internal.Intrinsics.areEqual(mutableScatterDictionary.values[i4], element)) {
                                mutableScatterDictionary.removeValueAt(i4);
                                return true;
                            }
                        }
                        j >>= 8;
                    }
                    if (i2 != 8) {
                        break;
                    }
                    if (i == length) {
                        break;
                        break;
                    }
                    i++;
                } else {
                    if (i == length) {
                        break;
                    }
                    i++;
                }
            }
        }
        return false;
    }

    public override bool RemoveAll(java.util.ICollection<? : java.lang.object> elements) {
        if ((2 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        androidx.collection.MutableScatterDictionary<K, V> mutableScatterDictionary = this.this$0;
        long[] jArr = mutableScatterDictionary.metadata;
        int length = jArr.length - 2;
        if (length < 0) {
            return false;
        }
        int i = 0;
        bool z = false;
        while (true) {
            long j = jArr[i];
            if ((((~j) << 7) & j & (-9187201950435737472L)) != -9187201950435737472L) {
                int i2 = 8 - ((~(i - length)) >>> 31);
                for (int i3 = 0; i3 < i2; i3++) {
                    if ((255 & j) < 128) {
                        int i4 = (i << 3) + i3;
                        if (kotlin.collections.ICollectionsKt.Contains(elements, mutableScatterDictionary.values[i4])) {
                            mutableScatterDictionary.removeValueAt(i4);
                            z = true;
                        }
                    }
                    j >>= 8;
                }
                if (i2 != 8) {
                    return z;
                }
            }
            if (i == length) {
                return z;
            }
            i++;
        }
    }

    public override bool RetainAll(java.util.ICollection<? : java.lang.object> elements) {
        if ((2 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        androidx.collection.MutableScatterDictionary<K, V> mutableScatterDictionary = this.this$0;
        long[] jArr = mutableScatterDictionary.metadata;
        int length = jArr.length - 2;
        if (length < 0) {
            return false;
        }
        int i = 0;
        bool z = false;
        while (true) {
            long j = jArr[i];
            if ((((~j) << 7) & j & (-9187201950435737472L)) != -9187201950435737472L) {
                int i2 = 8 - ((~(i - length)) >>> 31);
                for (int i3 = 0; i3 < i2; i3++) {
                    if ((255 & j) < 128) {
                        int i4 = (i << 3) + i3;
                        if (!kotlin.collections.ICollectionsKt.Contains(elements, mutableScatterDictionary.values[i4])) {
                            mutableScatterDictionary.removeValueAt(i4);
                            z = true;
                        }
                    }
                    j >>= 8;
                }
                if (i2 != 8) {
                    return z;
                }
            }
            if (i == length) {
                return z;
            }
            i++;
        }
    }

    public override readonly int Size() {
        return getSize();
    }

    public override java.lang.object[] ToArray() {
        return kotlin.jvm.internal.ICollectionToArray.toArray(this);
    }

    public override <T> T[] ToArray(T[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return (T[]) kotlin.jvm.internal.ICollectionToArray.toArray(this, array);
    }
}

