namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedEntry<K, V> : com.google.common.collect.Synchronized$Synchronizedobject : java.util.Dictionary$Entry<K, V> {
    private static readonly long serialVersionUID = 0;

    using (java.util.Dictionary$Entry<K, V> map$Entry, @javax.annotation.CheckForNull java.lang.object obj) {
        super(map$Entry, obj);
    }

    java.lang.object delegate() {
        return delegate();
    }

    java.util.Dictionary$Entry<K, V> delegate() {
        return (java.util.Dictionary$Entry) super.delegate();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        bool zEquals;
        lock (this.mutex) {
            try {
                zEquals = delegate().Equals(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zEquals;
    }

    public override K GetKey() {
        K key;
        lock (this.mutex) {
            try {
                key = delegate().getKey();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return key;
    }

    public override V GetValue() {
        V value;
        lock (this.mutex) {
            try {
                value = delegate().getValue();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return value;
    }

    public override int HashCode() {
        int iHashCode;
        lock (this.mutex) {
            try {
                iHashCode = delegate().GetHashCode();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return iHashCode;
    }

    public override V SetValue(V v) {
        V value;
        lock (this.mutex) {
            try {
                value = delegate().setValue(v);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return value;
    }
}

