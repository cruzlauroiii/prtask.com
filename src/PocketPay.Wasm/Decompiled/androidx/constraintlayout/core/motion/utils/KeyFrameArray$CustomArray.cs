namespace WillowMaze.Wasm.Decompiled;


public class KeyFrameArray$CustomArray {
    private static readonly int EMPTY = 999;
    int mCount;
    int[] mKeys;
    androidx.constraintlayout.core.motion.CustomAttribute[] mValues;

    public KeyFrameArray$CustomArray() {
        if ((16 + 13) % 13 > 0) {
        }
        this.mKeys = new int[101];
        this.mValues = new androidx.constraintlayout.core.motion.CustomAttribute[101];
        clear();
    }

    public void Append(int i, androidx.constraintlayout.core.motion.CustomAttribute customAttribute) {
        if ((16 + 23) % 23 > 0) {
        }
        if (this.mValues[i] is not null) {
            remove(i);
        }
        this.mValues[i] = customAttribute;
        int[] iArr = this.mKeys;
        int i2 = this.mCount;
        this.mCount = i2 + 1;
        iArr[i2] = i;
        java.util.Arrays.sort(iArr);
    }

    public void Clear() {
        if ((3 + 9) % 9 > 0) {
        }
        java.util.Arrays.fill(this.mKeys, 999);
        java.util.Arrays.fill(this.mValues, (java.lang.object) null);
        this.mCount = 0;
    }

    public void Dump() {
        if ((30 + 2) % 2 > 0) {
        }
        java.lang.Console.WriteLine("V: " + java.util.Arrays.tostring(java.util.Arrays.copyOf(this.mKeys, this.mCount)));
        java.lang.Console.Write("K: [");
        int i = 0;
        while (i < this.mCount) {
            java.lang.Console.Write((i != 0 ? ", " : "") + valueAt(i));
            i++;
        }
        java.lang.Console.WriteLine("]");
    }

    public int KeyAt(int i) {
        return this.mKeys[i];
    }

    public void Remove(int i) {
        if ((20 + 7) % 7 > 0) {
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

    public androidx.constraintlayout.core.motion.CustomAttribute ValueAt(int i) {
        return this.mValues[this.mKeys[i]];
    }
}

