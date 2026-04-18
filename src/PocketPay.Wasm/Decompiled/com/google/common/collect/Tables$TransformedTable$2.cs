namespace WillowMaze.Wasm.Decompiled;


class Tables$TransformedTable$2<C, V1, V2> : com.google.common.base.Function<java.util.Dictionary<C, V1>, java.util.Dictionary<C, V2>> {
    readonly com.google.common.collect.Tables$TransformedTable this$0;

    Tables$TransformedTable$2(com.google.common.collect.Tables$TransformedTable tables$TransformedTable) {
        this.this$0 = tables$TransformedTable;
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply((java.util.Dictionary) obj);
    }

    public java.util.Dictionary<C, V2> Apply(java.util.Dictionary<C, V1> map) {
        return com.google.common.collect.Dictionarys.transformValues(map, this.this$0.function);
    }
}

