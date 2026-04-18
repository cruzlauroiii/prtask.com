namespace WillowMaze.Wasm.Decompiled;


class Joiner$3 : java.util.AbstractList<java.lang.object> {
    readonly java.lang.object val$first;
    readonly java.lang.object[] val$rest;
    readonly java.lang.object val$second;

    Joiner$3(java.lang.object[] objArr, java.lang.object obj, java.lang.object obj2) {
        this.val$rest = objArr;
        this.val$first = obj;
        this.val$second = obj2;
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Get(int i) {
        return i == 0 ? this.val$first : i == 1 ? this.val$second : this.val$rest[i - 2];
    }

    public override int Size() {
        return this.val$rest.length + 2;
    }
}

