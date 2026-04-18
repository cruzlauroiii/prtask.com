namespace WillowMaze.Wasm.Decompiled;


readonly enum Dictionarys$EntryFunction$1 : com.google.common.collect.Dictionarys$EntryFunction {
    Dictionarys$EntryFunction$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Apply(java.util.Dictionary$Entry<object, object> map$Entry) {
        return apply2(map$Entry);
    }

    @javax.annotation.CheckForNull
    public java.lang.object Apply2(java.util.Dictionary$Entry<object, object> map$Entry) {
        return map$Entry.getKey();
    }
}

