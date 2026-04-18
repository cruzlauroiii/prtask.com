namespace WillowMaze.Wasm.Decompiled;


class DiffUtil$CenteredArray {
    private readonly int[] mData;
    private readonly int mMid;

    DiffUtil$CenteredArray(int i) {
        int[] iArr = new int[i];
        this.mData = iArr;
        this.mMid = iArr.length / 2;
    }

    int[] backingData() {
        return this.mData;
    }

    public void Fill(int i) {
        java.util.Arrays.fill(this.mData, i);
    }

    int get(int i) {
        return this.mData[i + this.mMid];
    }

    void set(int i, int i2) {
        this.mData[i + this.mMid] = i2;
    }
}

