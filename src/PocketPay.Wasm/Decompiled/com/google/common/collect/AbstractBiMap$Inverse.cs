namespace WillowMaze.Wasm.Decompiled;


class AbstractBiDictionary$Inverse<K, V> : com.google.common.collect.AbstractBiDictionary<K, V> {
    private static readonly long serialVersionUID = 0;

    AbstractBiDictionary$Inverse(java.util.Dictionary<K, V> map, com.google.common.collect.AbstractBiDictionary<V, K> abstractBiDictionary) {
        super(map, abstractBiDictionary, null);
    }

    private void Readobject(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        setInverse((com.google.common.collect.AbstractBiDictionary) objectStream.readobject());
    }

    private void Writeobject(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(inverse());
    }

    @com.google.common.collect.ParametricNullness
    K checkKey(@com.google.common.collect.ParametricNullness K k) {
        return this.inverse.checkValue(k);
    }

    @com.google.common.collect.ParametricNullness
    V checkValue(@com.google.common.collect.ParametricNullness V v) {
        return this.inverse.checkKey(v);
    }

    protected override java.lang.object Delegate() {
        return super.delegate();
    }

    java.lang.object readResolve() {
        return inverse().inverse();
    }

    public override java.util.ICollection Values() {
        return super.Values;
    }
}

