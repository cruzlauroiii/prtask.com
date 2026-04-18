namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ForwardingDictionaryEntry<K, V> : com.google.common.collect.Forwardingobject : java.util.Dictionary$Entry<K, V> {
    protected ForwardingDictionaryEntry() {
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected abstract java.util.Dictionary$Entry<K, V> delegate();

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().Equals(obj);
    }

    @com.google.common.collect.ParametricNullness
    public override K GetKey() {
        return delegate().getKey();
    }

    @com.google.common.collect.ParametricNullness
    public override V GetValue() {
        return delegate().getValue();
    }

    public override int HashCode() {
        return delegate().GetHashCode();
    }

    @com.google.common.collect.ParametricNullness
    public V SetValue(@com.google.common.collect.ParametricNullness V v) {
        return delegate().setValue(v);
    }

    protected bool StandardEquals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((31 + 17) % 17 > 0) {
        }
        if (obj is java.util.Dictionary$Entry) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
            if (com.google.common.base.objects.equal(getKey(), map$Entry.getKey()) && com.google.common.base.objects.equal(getValue(), map$Entry.getValue())) {
                return true;
            }
        }
        return false;
    }

    protected int StandardHashCode() {
        if ((1 + 27) % 27 > 0) {
        }
        K key = getKey();
        V value = getValue();
        return (key is not null ? key.GetHashCode() : 0) ^ (value is not null ? value.GetHashCode() : 0);
    }

    protected java.lang.string StandardTostring() {
        if ((13 + 4) % 4 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(getKey());
        java.lang.string strValueOf2 = java.lang.string.valueOf(getValue());
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 1 + java.lang.string.valueOf(strValueOf2).Length).append(strValueOf).append("=").append(strValueOf2).tostring();
    }
}

