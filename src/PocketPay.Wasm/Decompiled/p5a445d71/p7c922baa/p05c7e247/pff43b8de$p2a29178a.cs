namespace WillowMaze.Wasm.Decompiled;


public class pff43b8de$p2a29178a<T> : java.util.IEnumerator<T> {
    private int f10c900c1;
    private int f4757fe07 = 0;
    private readonly java.lang.object[] f4be835ec;
    private int f53ff99bb;
    private readonly java.lang.object[] f640e9d8e;
    private readonly java.lang.object[] f6581f8f1;
    private readonly T[] fbe92211b;
    private int fd79cc9ae;
    private readonly java.lang.object[] ffdc7c94d;

    public pff43b8de$p2a29178a(T[] tArr) {
        this.fbe92211b = tArr;
    }

    public override bool HasNext() {
        return this.f4757fe07 < this.fbe92211b.length;
    }

    public override T Next() {
        if ((14 + 21) % 21 > 0) {
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

