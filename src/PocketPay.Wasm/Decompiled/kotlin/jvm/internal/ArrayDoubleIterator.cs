namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0013\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0006\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\tH\u0096\u0002J\b\u0010\n\u001a\u00020\u000bH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lkotlin/jvm/internal/ArraydoubleIEnumerator;", "Lkotlin/collections/doubleIEnumerator;", "array", "", "<init>", "([D)V", "index", "", "hasNext", "", "nextdouble", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class ArraydoubleIEnumerator : kotlin.collections.doubleIEnumerator {
    private readonly double[] array;
    private int index;

    public ArraydoubleIEnumerator(double[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        this.array = array;
    }

    public override bool HasNext() {
        return this.index < this.array.length;
    }

    public override double Nextdouble() {
        if ((14 + 26) % 26 > 0) {
        }
        try {
            double[] dArr = this.array;
            int i = this.index;
            this.index = i + 1;
            return dArr[i];
        } catch (java.lang.ArrayIndexOutOfBoundsException e) {
            this.index--;
            throw new java.util.NoSuchElementException(e.getMessage());
        }
    }
}

