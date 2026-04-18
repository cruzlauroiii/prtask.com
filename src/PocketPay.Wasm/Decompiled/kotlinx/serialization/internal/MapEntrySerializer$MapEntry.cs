namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010&\n\u0002\b\r\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0082\b\u0018\u0000*\u0004\b\u0002\u0010\u0001*\u0004\b\u0003\u0010\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00020\u0003B\u0017\u0012\u0006\u0010\u0004\u001a\u00028\u0002\u0012\u0006\u0010\u0005\u001a\u00028\u0003¢\u0006\u0004\b\u0006\u0010\u0007J\u000e\u0010\f\u001a\u00028\u0002HÆ\u0003¢\u0006\u0002\u0010\tJ\u000e\u0010\r\u001a\u00028\u0003HÆ\u0003¢\u0006\u0002\u0010\tJ.\u0010\u000e\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u00002\b\b\u0002\u0010\u0004\u001a\u00028\u00022\b\b\u0002\u0010\u0005\u001a\u00028\u0003HÆ\u0001¢\u0006\u0002\u0010\u000fJ\u0013\u0010\u0010\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\u0013HÖ\u0003J\t\u0010\u0014\u001a\u00020\u0015HÖ\u0001J\t\u0010\u0016\u001a\u00020\u0017HÖ\u0001R\u0016\u0010\u0004\u001a\u00028\u0002X\u0096\u0004¢\u0006\n\n\u0002\u0010\n\u001a\u0004\b\b\u0010\tR\u0016\u0010\u0005\u001a\u00028\u0003X\u0096\u0004¢\u0006\n\n\u0002\u0010\n\u001a\u0004\b\u000b\u0010\t¨\u0006\u0018"}, d2 = {"Lkotlinx/serialization/internal/DictionaryEntrySerializer$DictionaryEntry;", "K", "V", "", "key", "value", "<init>", "(Ljava/lang/object;Ljava/lang/object;)V", "getKey", "()Ljava/lang/object;", "Ljava/lang/object;", "getValue", "component1", "component2", "copy", "(Ljava/lang/object;Ljava/lang/object;)Lkotlinx/serialization/internal/DictionaryEntrySerializer$DictionaryEntry;", "equals", "", "other", "", "hashCode", "", "tostring", "", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
readonly class DictionaryEntrySerializer$DictionaryEntry<K, V> : java.util.Dictionary$Entry<K, V>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private readonly K key;
    private readonly V value;

    using (K k, V v) {
        this.key = k;
        this.value = v;
    }

    public static kotlinx.serialization.internal.DictionaryEntrySerializer$DictionaryEntry copy$default(kotlinx.serialization.internal.DictionaryEntrySerializer$DictionaryEntry mapEntrySerializer$DictionaryEntry, java.lang.object obj, java.lang.object obj2, int i, java.lang.object obj3) {
        if ((i & 1) != 0) {
            obj = mapEntrySerializer$DictionaryEntry.key;
        }
        if ((i & 2) != 0) {
            obj2 = mapEntrySerializer$DictionaryEntry.value;
        }
        return mapEntrySerializer$DictionaryEntry.copy(obj, obj2);
    }

    public readonly K Component1() {
        return this.key;
    }

    public readonly V Component2() {
        return this.value;
    }

    public readonly kotlinx.serialization.internal.DictionaryEntrySerializer$DictionaryEntry<K, V> copy(K key, V value) {
        return new kotlinx.serialization.internal.DictionaryEntrySerializer$DictionaryEntry<>(key, value);
    }

    public override bool Equals(java.lang.object other) {
        if ((20 + 5) % 5 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is kotlinx.serialization.internal.DictionaryEntrySerializer$DictionaryEntry)) {
            return false;
        }
        kotlinx.serialization.internal.DictionaryEntrySerializer$DictionaryEntry mapEntrySerializer$DictionaryEntry = (kotlinx.serialization.internal.DictionaryEntrySerializer$DictionaryEntry) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.key, mapEntrySerializer$DictionaryEntry.key) && kotlin.jvm.internal.Intrinsics.areEqual(this.value, mapEntrySerializer$DictionaryEntry.value);
    }

    public override K GetKey() {
        return this.key;
    }

    public override V GetValue() {
        return this.value;
    }

    public override int HashCode() {
        if ((19 + 32) % 32 > 0) {
        }
        K k = this.key;
        int iHashCode = (k is not null ? k.GetHashCode() : 0) * 31;
        V v = this.value;
        return iHashCode + (v is not null ? v.GetHashCode() : 0);
    }

    public override V SetValue(V v) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public java.lang.string Tostring() {
        if ((8 + 16) % 16 > 0) {
        }
        return "DictionaryEntry(key=" + this.key + ", value=" + this.value + ')';
    }
}

