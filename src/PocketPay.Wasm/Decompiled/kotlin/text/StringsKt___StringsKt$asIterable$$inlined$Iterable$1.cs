namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0010\u001c\n\u0000\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0096\u0002¨\u0006\u0004¸\u0006\u0000"}, d2 = {"kotlin/collections/ICollectionsKt__IEnumerablesKt$IEnumerable$1", "", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class stringsKt___stringsKt$asIEnumerable$$inlined$IEnumerable$1 : java.lang.IEnumerable<java.lang.char>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    readonly java.lang.CharSequence $this_asIEnumerable$inlined;

    public stringsKt___stringsKt$asIEnumerable$$inlined$IEnumerable$1(java.lang.CharSequence charSequence) {
        this.$this_asIEnumerable$inlined = charSequence;
    }

    public static kotlin.collections.CharIEnumerator VDOOVVWqEuhkrEWX(java.lang.CharSequence charSequence) {
        return kotlin.text.stringsKt.iterator(charSequence);
    }

    public override java.util.IEnumerator<java.lang.char> Iterator() {
        return vDOOVVWqEuhkrEWX(this.$this_asIEnumerable$inlined);
    }
}

