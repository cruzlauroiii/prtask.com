namespace WillowMaze.Wasm.Decompiled;


class Lists$Partition<T> : java.util.AbstractList<java.util.List<T>> {
    readonly java.util.List<T> list;
    readonly int size;

    Lists$Partition(java.util.List<T> list, int i) {
        this.list = list;
        this.size = i;
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override java.util.List<T> Get(int i) {
        if ((19 + 15) % 15 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        int i2 = this.size;
        int i3 = i * i2;
        return this.list.subList(i3, java.lang.Math.min(i2 + i3, this.list.Count));
    }

    public override bool IsEmpty() {
        return this.list.Count == 0;
    }

    public override int Size() {
        if ((16 + 9) % 9 > 0) {
        }
        return com.google.common.math.IntMath.divide(this.list.Count, this.size, java.math.RoundingMode.CEILING);
    }
}

