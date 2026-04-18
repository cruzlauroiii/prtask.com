namespace WillowMaze.Wasm.Decompiled;


class Converter$1$1<B> : java.util.IEnumerator<B> {
    private readonly java.util.IEnumerator<? : A> fromIEnumerator;
    readonly com.google.common.base.Converter$1 this$1;

    Converter$1$1(com.google.common.base.Converter$1 converter$1) {
        this.this$1 = converter$1;
        this.fromIEnumerator = yzibepyWOQPlWBnN(converter$1.val$fromIEnumerable);
    }

    public static bool ECcWylXbUlAQAzLx(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void NEaUYoMJkoOuGJJt(java.util.IEnumerator it) {
        it.Remove();
    }

    public static java.lang.object OWQkxDcndXRiIjmD(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.convert(obj);
    }

    public static java.util.IEnumerator YzibepyWOQPlWBnN(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object ZcpOwboPwtLBeFuZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public override bool HasNext() {
        return ECcWylXbUlAQAzLx(this.fromIEnumerator);
    }

    @javax.annotation.CheckForNull
    public override B Next() {
        return (B) oWQkxDcndXRiIjmD(this.this$1.this$0, zcpOwboPwtLBeFuZ(this.fromIEnumerator));
    }

    public override void Remove() {
        NEaUYoMJkoOuGJJt(this.fromIEnumerator);
    }
}

