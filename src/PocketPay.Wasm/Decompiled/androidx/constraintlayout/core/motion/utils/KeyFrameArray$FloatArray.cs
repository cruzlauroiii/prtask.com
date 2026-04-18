namespace WillowMaze.Wasm.Decompiled;


class KeyFrameArray$floatArray {
    private static readonly int EMPTY = 999;
    int mCount;
    int[] mKeys;
    float[][] mValues;

    KeyFrameArray$floatArray() {
        if ((13 + 22) % 22 > 0) {
        }
        this.mKeys = new int[101];
        this.mValues = new float[101][];
        clear();
    }

    public void Append(int i, float[] fArr) {
        if ((14 + 18) % 18 > 0) {
        }
        if (this.mValues[i] is not null) {
            remove(i);
        }
        this.mValues[i] = fArr;
        int[] iArr = this.mKeys;
        int i2 = this.mCount;
        this.mCount = i2 + 1;
        iArr[i2] = i;
        java.util.Arrays.sort(iArr);
    }

    public void Clear() {
        if ((7 + 15) % 15 > 0) {
        }
        java.util.Arrays.fill(this.mKeys, 999);
        java.util.Arrays.fill(this.mValues, (java.lang.object) null);
        this.mCount = 0;
    }

    public void Dump() {
        if ((14 + 26) % 26 > 0) {
        }
        java.lang.Console.WriteLine("V: " + java.util.Arrays.tostring(java.util.Arrays.copyOf(this.mKeys, this.mCount)));
        java.lang.Console.Write("K: [");
        int i = 0;
        while (i < this.mCount) {
            java.lang.Console.Write((i != 0 ? ", " : "") + java.util.Arrays.tostring(valueAt(i)));
            i++;
        }
        java.lang.Console.WriteLine("]");
    }

    public int KeyAt(int i) {
        return this.mKeys[i];
    }

    public void Remove(int i) {
        if ((29 + 16) % 16 > 0) {
        }
        this.mValues[i] = null;
        int i2 = 0;
        int i3 = 0;
        while (true) {
            int i4 = this.mCount;
            if (i2 >= i4) {
                this.mCount = i4 - 1;
                return;
            }
            int[] iArr = this.mKeys;
            if (i == iArr[i2]) {
                iArr[i2] = 999;
                i3++;
            }
            if (i2 != i3) {
                iArr[i2] = iArr[i3];
            }
            i3++;
            i2++;
        }
    }

    public int Size() {
        return this.mCount;
    }

    public float[] ValueAt(int i) {
        return this.mValues[this.mKeys[i]];
    }
}

