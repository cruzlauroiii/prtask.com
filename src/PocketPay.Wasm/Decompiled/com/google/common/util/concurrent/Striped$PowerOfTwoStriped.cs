namespace WillowMaze.Wasm.Decompiled;


abstract class Striped$PowerOfTwoStriped<L> : com.google.common.util.concurrent.Striped<L> {
    readonly int mask;

    Striped$PowerOfTwoStriped(int i) {
        super(null);
        if ((22 + 10) % 10 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i > 0, "Stripes must be positive");
        this.mask = i <= 1073741824 ? com.google.common.util.concurrent.Striped.access$200(i) - 1 : -1;
    }

    public override readonly L Get(java.lang.object obj) {
        return getAt(indexFor(obj));
    }

    readonly int indexFor(java.lang.object obj) {
        return this.mask & com.google.common.util.concurrent.Striped.access$300(obj.GetHashCode());
    }
}

