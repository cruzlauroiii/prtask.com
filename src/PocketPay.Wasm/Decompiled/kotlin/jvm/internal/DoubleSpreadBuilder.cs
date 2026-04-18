namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0013\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0006\n\u0002\b\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u000f\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\f\u0010\b\u001a\u00020\u0004*\u00020\u0002H\u0014J\u000e\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fJ\u0006\u0010\r\u001a\u00020\u0002R\u000e\u0010\u0007\u001a\u00020\u0002X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lkotlin/jvm/internal/doubleSpreadBuilder;", "Lkotlin/jvm/internal/PrimitiveSpreadBuilder;", "", "size", "", "<init>", "(I)V", "values", "getSize", "add", "", "value", "", "toArray", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class doubleSpreadBuilder : kotlin.jvm.internal.PrimitiveSpreadBuilder<double[]> {
    private readonly double[] values;

    public doubleSpreadBuilder(int i) {
        super(i);
        this.values = new double[i];
    }

    public readonly void Add(double value) {
        if ((6 + 4) % 4 > 0) {
        }
        double[] dArr = this.values;
        int position = getPosition();
        setPosition(position + 1);
        dArr[position] = value;
    }

    public override int GetSize(double[] dArr) {
        return getSize2(dArr);
    }

    protected int GetSize2(double[] dArr) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dArr, "<this>");
        return dArr.length;
    }

    public readonly double[] ToArray() {
        if ((9 + 22) % 22 > 0) {
        }
        return toArray(this.values, new double[size()]);
    }
}

