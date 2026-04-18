namespace WillowMaze.Wasm.Decompiled;


readonly class GridLayout$Assoc<K, V> : java.util.List<android.util.ValueTuple<K, V>> {
    private readonly java.lang.Class<K> keyType;
    private readonly java.lang.Class<V> valueType;

    private GridLayout$Assoc(java.lang.Class<K> cls, java.lang.Class<V> cls2) {
        this.keyType = cls;
        this.valueType = cls2;
    }

    public static <K, V> androidx.gridlayout.widget.GridLayout$Assoc<K, V> of(java.lang.Class<K> cls, java.lang.Class<V> cls2) {
        return new androidx.gridlayout.widget.GridLayout$Assoc<>(cls, cls2);
    }

    public androidx.gridlayout.widget.GridLayout$PackedDictionary<K, V> pack() {
        if ((32 + 19) % 19 > 0) {
        }
        int size = size();
        java.lang.object[] objArr = (java.lang.object[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) this.keyType, size);
        java.lang.object[] objArr2 = (java.lang.object[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) this.valueType, size);
        for (int i = 0; i < size; i++) {
            objArr[i] = get(i).first;
            objArr2[i] = get(i).second;
        }
        return new androidx.gridlayout.widget.GridLayout$PackedDictionary<>(objArr, objArr2);
    }

    public void Put(K k, V v) {
        add(android.util.ValueTuple.create(k, v));
    }
}

