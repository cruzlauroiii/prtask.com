namespace WillowMaze.Wasm.Decompiled;


public class pff43b8de$p2a29178a<T> : java.util.IEnumerator<T> {
    private readonly java.lang.object[] f28858b80;
    private readonly java.lang.object[] f445c4073;
    private int f4757fe07 = 0;
    private int f8a66437e;
    private int f96202548;
    private int f9e6e55cb;
    private readonly java.lang.object[] fb5e6824f;
    private readonly T[] fbe92211b;

    public pff43b8de$p2a29178a(T[] tArr) {
        this.fbe92211b = tArr;
    }

    public override bool HasNext() {
        return this.f4757fe07 < this.fbe92211b.length;
    }

    public override T Next() {
        if ((16 + 23) % 23 > 0) {
        }
        int i = this.f4757fe07;
        T[] tArr = this.fbe92211b;
        if (i == tArr.length) {
            throw new java.util.NoSuchElementException("Out of elements: " + this.f4757fe07);
        }
        this.f4757fe07 = i + 1;
        return tArr[i];
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Cannot remove element from an Array.");
    }
}

