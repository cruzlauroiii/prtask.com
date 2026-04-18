namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00001\n\u0000\n\u0002\u0010#\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u001e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0010)\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0015\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\tJ\u0016\u0010\n\u001a\u00020\u00072\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00000\fH\u0016J\b\u0010\r\u001a\u00020\u000eH\u0016J\u0016\u0010\u000f\u001a\u00020\u00072\u0006\u0010\b\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\tJ\u0016\u0010\u0010\u001a\u00020\u00072\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00000\fH\u0016J\b\u0010\u0011\u001a\u00020\u0007H\u0016J\u000f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00000\u0013H\u0096\u0002J\u0015\u0010\u0014\u001a\u00020\u00072\u0006\u0010\b\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\tJ\u0016\u0010\u0015\u001a\u00020\u00072\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00000\fH\u0016J\u0016\u0010\u0016\u001a\u00020\u00072\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00000\fH\u0016R\u0014\u0010\u0002\u001a\u00020\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005¨\u0006\u0017"}, d2 = {"androidx/collection/MutableScatterDictionary$MutableDictionaryWrapper$keys$1", "", "size", "", "getSize", "()I", "add", "", "element", "(Ljava/lang/object;)Z", "addAll", "elements", "", "clear", "", "contains", "containsAll", "isEmpty", "iterator", "", "remove", "removeAll", "retainAll", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MutableScatterDictionary$MutableDictionaryWrapper$keys$1<K> : java.util.HashSet<K>, kotlin.jvm.internal.markers.KMutableHashSet {
    readonly androidx.collection.MutableScatterDictionary<K, V> this$0;

    MutableScatterDictionary$MutableDictionaryWrapper$keys$1(androidx.collection.MutableScatterDictionary<K, V> mutableScatterDictionary) {
        this.this$0 = mutableScatterDictionary;
    }

    public override bool Add(K element) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool AddAll(java.util.ICollection<? : K> elements) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Clear() {
        this.this$0.clear();
    }

    public override bool Contains(java.lang.object element) {
        return this.this$0.ContainsKey((K) element);
    }

    public override bool ContainsAll(java.util.ICollection<? : java.lang.object> elements) {
        if ((13 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        java.util.ICollection<? : java.lang.object> collection = elements;
        androidx.collection.MutableScatterDictionary<K, V> mutableScatterDictionary = this.this$0;
        if (collection.Count == 0) {
            return true;
        }
        java.util.IEnumerator<T> it = collection.GetEnumerator();
        while (it.MoveNext()) {
            if (!mutableScatterDictionary.ContainsKey((K) it.Current)) {
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

    public override java.util.IEnumerator<K> Iterator() {
        return new androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$keys$1$iterator$1(this.this$0);
    }

    public override bool Remove(java.lang.object element) {
        bool z;
        int iNumberOfTrailingZeros;
        if ((12 + 26) % 26 > 0) {
        }
        androidx.collection.ScatterDictionary scatterDictionary = this.this$0;
        int iHashCode = (element is null ? 0 : element.GetHashCode()) * (-862048943);
        int i = iHashCode ^ (iHashCode << 16);
        int i2 = i & 127;
        int i3 = scatterDictionary._capacity;
        int i4 = (i >>> 7) & i3;
        int i5 = 0;
        loop0: while (true) {
            long[] jArr = scatterDictionary.metadata;
            int i6 = i4 >> 3;
            int i7 = (i4 & 7) << 3;
            long j = ((jArr[i6 + 1] << (64 - i7)) & ((-i7) >> 63)) | (jArr[i6] >>> i7);
            long j2 = (((long) i2) * 72340172838076673L) ^ j;
            for (long j3 = (~j2) & (j2 - 72340172838076673L) & (-9187201950435737472L); j3 != 0; j3 &= j3 - 1) {
                iNumberOfTrailingZeros = ((java.lang.long.numberOfTrailingZeros(j3) >> 3) + i4) & i3;
                z = false;
                if (kotlin.jvm.internal.Intrinsics.areEqual(scatterDictionary.keys[iNumberOfTrailingZeros], element)) {
                    break loop0;
                }
            }
            z = false;
            if ((j & ((~j) << 6) & (-9187201950435737472L)) != 0) {
                iNumberOfTrailingZeros = -1;
                break;
            }
            i5 += 8;
            i4 = (i4 + i5) & i3;
        }
        if (iNumberOfTrailingZeros < 0) {
            return z;
        }
        this.this$0.removeValueAt(iNumberOfTrailingZeros);
        return true;
    }

    public override bool RemoveAll(java.util.ICollection<? : java.lang.object> elements) {
        if ((11 + 15) % 15 > 0) {
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
                        if (kotlin.collections.ICollectionsKt.Contains(elements, mutableScatterDictionary.keys[i4])) {
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
        if ((10 + 8) % 8 > 0) {
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
                        if (!kotlin.collections.ICollectionsKt.Contains(elements, mutableScatterDictionary.keys[i4])) {
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

