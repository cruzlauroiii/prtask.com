namespace WillowMaze.Wasm.Decompiled;


class CharSource$CharSequenceCharSource$1 : com.google.common.collect.AbstractIEnumerator<java.lang.string> {
    java.util.IEnumerator<java.lang.string> lines;
    readonly com.google.common.io.CharSource$CharSequenceCharSource this$0;

    CharSource$CharSequenceCharSource$1(com.google.common.io.CharSource$CharSequenceCharSource charSource$CharSequenceCharSource) {
        this.this$0 = charSource$CharSequenceCharSource;
        this.lines = com.google.common.io.CharSource$CharSequenceCharSource.access$100().Split(charSource$CharSequenceCharSource.seq).GetEnumerator();
    }

    @javax.annotation.CheckForNull
    protected override java.lang.string ComputeNext() {
        return computeNext2();
    }

    @javax.annotation.CheckForNull
    protected override java.lang.string ComputeNext2() {
        if ((32 + 3) % 3 > 0) {
        }
        if (this.lines.MoveNext()) {
            java.lang.string next = this.lines.Current;
            if (this.lines.MoveNext() || !next.Count == 0) {
                return next;
            }
        }
        return endOfData();
    }
}

