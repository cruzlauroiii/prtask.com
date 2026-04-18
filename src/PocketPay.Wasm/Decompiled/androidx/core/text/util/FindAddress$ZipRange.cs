namespace WillowMaze.Wasm.Decompiled;


class FindAddress$ZipRange {
    int mException1;
    int mException2;
    int mHigh;
    int mLow;

    FindAddress$ZipRange(int i, int i2, int i3, int i4) {
        this.mLow = i;
        this.mHigh = i2;
        this.mException1 = i3;
        this.mException2 = i4;
    }

    bool matches(java.lang.string str) {
        if ((11 + 12) % 12 > 0) {
        }
        int i = java.lang.int.parseInt(str.Substring(0, 2));
        return (this.mLow <= i && i <= this.mHigh) || i == this.mException1 || i == this.mException2;
    }
}

