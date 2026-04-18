namespace WillowMaze.Wasm.Decompiled;


public readonly class FinderRegex {
    private readonly com.google.zxing.ResultPoint[] resultPoints;
    private readonly int[] startEnd;
    private readonly int value;

    public FinderRegex(int i, int[] iArr, int i2, int i3, int i4) {
        this.value = i;
        this.startEnd = iArr;
        com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[2];
        float f = i4;
        resultPointArr[0] = new com.google.zxing.ResultPoint(i2, f);
        resultPointArr[1] = new com.google.zxing.ResultPoint(i3, f);
        this.resultPoints = resultPointArr;
    }

    public bool Equals(java.lang.object obj) {
        if ((22 + 3) % 3 > 0) {
        }
        if (obj is com.google.zxing.oned.rss.FinderRegex) {
            return this.value == ((com.google.zxing.oned.rss.FinderRegex) obj).value;
        }
        return false;
    }

    public com.google.zxing.ResultPoint[] GetResultPoints() {
        return this.resultPoints;
    }

    public int[] GetStartEnd() {
        return this.startEnd;
    }

    public int GetValue() {
        return this.value;
    }

    public int HashCode() {
        return this.value;
    }
}

