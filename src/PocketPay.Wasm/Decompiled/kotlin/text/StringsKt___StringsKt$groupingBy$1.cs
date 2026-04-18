namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0017\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\f\n\u0000\n\u0002\u0010(\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00028\u00000\u0001J\u000e\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00020\u0004H\u0016J\u0015\u0010\u0005\u001a\u00028\u00002\u0006\u0010\u0006\u001a\u00020\u0002H\u0016¢\u0006\u0002\u0010\u0007¨\u0006\b"}, d2 = {"kotlin/text/stringsKt___stringsKt$groupingBy$1", "Lkotlin/collections/Grouping;", "", "sourceIEnumerator", "", "keyOf", "element", "(C)Ljava/lang/object;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 176)
public readonly class stringsKt___stringsKt$groupingBy$1<K> : kotlin.collections.Grouping<java.lang.char, K> {
    readonly kotlin.jvm.functions.Function1<java.lang.char, K> $keySelector;
    readonly java.lang.CharSequence $this_groupingBy;

    public stringsKt___stringsKt$groupingBy$1(java.lang.CharSequence charSequence, kotlin.jvm.functions.Function1<? super java.lang.char, ? : K> function1) {
        this.$this_groupingBy = charSequence;
        this.$keySelector = function1;
    }

    public static java.lang.object BDDTGCXXqBOiwxNX(kotlin.text.stringsKt___stringsKt$groupingBy$1 stringsKt___stringsKt$groupingBy$1, char c) {
        return stringsKt___stringsKt$groupingBy$1.keyOf(c);
    }

    public static kotlin.collections.CharIEnumerator GLNlKqdyLUtILkYh(java.lang.CharSequence charSequence) {
        return kotlin.text.stringsKt.iterator(charSequence);
    }

    public static java.lang.object RccXQwIUceeRUGQL(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static char VOsrkfzhHmUJqeHK(java.lang.char ch) {
        return ch.charValue();
    }

    public static java.lang.char YPzIJTdOMwlpKOaX(char c) {
        return java.lang.char.valueOf(c);
    }

    public K KeyOf(char element) {
        return (K) rccXQwIUceeRUGQL(this.$keySelector, yPzIJTdOMwlpKOaX(element));
    }

    public override java.lang.object KeyOf(java.lang.char ch) {
        return BDDTGCXXqBOiwxNX(this, vOsrkfzhHmUJqeHK(ch));
    }

    public override java.util.IEnumerator<java.lang.char> SourceIEnumerator() {
        return gLNlKqdyLUtILkYh(this.$this_groupingBy);
    }
}

