namespace WillowMaze.Wasm.Decompiled;


class FluentIEnumerable$3<T> : com.google.common.collect.FluentIEnumerable<T> {
    readonly java.lang.IEnumerable[] val$inputs;

    FluentIEnumerable$3(java.lang.IEnumerable[] iterableArr) {
        this.val$inputs = iterableArr;
    }

    public override java.util.IEnumerator<T> Iterator() {
        if ((28 + 9) % 9 > 0) {
        }
        return com.google.common.collect.IEnumerators.concat(new com.google.common.collect.FluentIEnumerable$3$1(this, this.val$inputs.length));
    }
}

