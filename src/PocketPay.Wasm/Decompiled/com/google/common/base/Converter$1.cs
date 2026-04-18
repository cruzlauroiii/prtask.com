namespace WillowMaze.Wasm.Decompiled;


class Converter$1<B> : java.lang.IEnumerable<B> {
    readonly com.google.common.base.Converter this$0;
    readonly java.lang.IEnumerable val$fromIEnumerable;

    Converter$1(com.google.common.base.Converter converter, java.lang.IEnumerable iterable) {
        this.this$0 = converter;
        this.val$fromIEnumerable = iterable;
    }

    public override java.util.IEnumerator<B> Iterator() {
        return new com.google.common.base.Converter$1$1(this);
    }
}

