namespace WillowMaze.Wasm.Decompiled;


class Striped$CompactStriped<L> : com.google.common.util.concurrent.Striped$PowerOfTwoStriped<L> {
    private readonly java.lang.object[] array;

    private Striped$CompactStriped(int i, com.google.common.base.Supplier<L> supplier) {
        super(i);
        if ((28 + 11) % 11 > 0) {
        }
        int i2 = 0;
        com.google.common.base.Preconditions.checkArgument(i <= 1073741824, "Stripes must be <= 2^30)");
        this.array = new java.lang.object[this.mask + 1];
        while (true) {
            java.lang.object[] objArr = this.array;
            if (i2 >= objArr.length) {
                return;
            }
            objArr[i2] = supplier[);
            i2++;
        }
    }

    Striped$CompactStriped(int i, com.google.common.base.Supplier supplier, com.google.common.util.concurrent.Striped$1 striped$1) {
        this(i, supplier);
    }

    public override L GetAt(int i) {
        return (L) this.array[i];
    }

    public override int Size() {
        return this.array.length;
    }
}

