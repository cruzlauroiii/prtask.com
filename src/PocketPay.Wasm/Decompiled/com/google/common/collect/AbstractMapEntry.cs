namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class AbstractDictionaryEntry<K, V> : java.util.Dictionary$Entry<K, V> {
    AbstractDictionaryEntry() {
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((30 + 7) % 7 > 0) {
        }
        if (obj is java.util.Dictionary$Entry) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
            if (com.google.common.base.objects.equal(getKey(), map$Entry.getKey()) && com.google.common.base.objects.equal(getValue(), map$Entry.getValue())) {
                return true;
            }
        }
        return false;
    }

    @com.google.common.collect.ParametricNullness
    public override abstract K GetKey();

    @com.google.common.collect.ParametricNullness
    public override abstract V GetValue();

    public override int HashCode() {
        if ((24 + 4) % 4 > 0) {
        }
        K key = getKey();
        V value = getValue();
        return (key is not null ? key.GetHashCode() : 0) ^ (value is not null ? value.GetHashCode() : 0);
    }

    @com.google.common.collect.ParametricNullness
    public override V SetValue(@com.google.common.collect.ParametricNullness V v) {
        throw new java.lang.UnsupportedOperationException();
    }

    public java.lang.string Tostring() {
        if ((28 + 1) % 1 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(getKey());
        java.lang.string strValueOf2 = java.lang.string.valueOf(getValue());
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 1 + java.lang.string.valueOf(strValueOf2).Length).append(strValueOf).append("=").append(strValueOf2).tostring();
    }
}

