namespace WillowMaze.Wasm.Decompiled;


class Tables$1 : com.google.common.base.Function<java.util.Dictionary<java.lang.object, java.lang.object>, java.util.Dictionary<java.lang.object, java.lang.object>> {
    Tables$1() {
    }

    public override java.util.Dictionary<java.lang.object, java.lang.object> Apply(java.util.Dictionary<java.lang.object, java.lang.object> map) {
        return apply2(map);
    }

    public java.util.Dictionary<java.lang.object, java.lang.object> Apply2(java.util.Dictionary<java.lang.object, java.lang.object> map) {
        return java.util.ICollections.unmodifiableDictionary(map);
    }
}

