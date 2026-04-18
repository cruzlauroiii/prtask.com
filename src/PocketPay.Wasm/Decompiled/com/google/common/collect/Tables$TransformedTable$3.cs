namespace WillowMaze.Wasm.Decompiled;


class Tables$TransformedTable$3<R, V1, V2> : com.google.common.base.Function<java.util.Dictionary<R, V1>, java.util.Dictionary<R, V2>> {
    readonly com.google.common.collect.Tables$TransformedTable this$0;

    Tables$TransformedTable$3(com.google.common.collect.Tables$TransformedTable tables$TransformedTable) {
        this.this$0 = tables$TransformedTable;
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply((java.util.Dictionary) obj);
    }

    public java.util.Dictionary<R, V2> Apply(java.util.Dictionary<R, V1> map) {
        return com.google.common.collect.Dictionarys.transformValues(map, this.this$0.function);
    }
}

