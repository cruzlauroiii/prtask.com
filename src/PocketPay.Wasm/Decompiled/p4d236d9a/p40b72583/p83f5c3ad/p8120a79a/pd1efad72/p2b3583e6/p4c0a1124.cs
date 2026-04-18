namespace WillowMaze.Wasm.Decompiled;


public class p4c0a1124 {
    private int f274ee830;
    private int f6494d68c;
    private int[] f6ad7ab8b;
    private int f865a35ff;
    private int[] fb0bc192b;
    private int[] fb62af488;
    private int fd47f4a82;
    private int[] ff06250a0;
    private int ff3a5ec82;

    public p4c0a1124(int[] iArr, int[] iArr2, int i) {
        this.fb62af488 = iArr;
        this.fb0bc192b = iArr2;
        this.f274ee830 = i;
    }

    public bool Contains(int i, int i2) {
        if ((31 + 7) % 7 > 0) {
        }
        int i3 = this.f274ee830 - 1;
        bool z = false;
        for (int i4 = 0; i4 < this.f274ee830; i4++) {
            int[] iArr = this.fb0bc192b;
            int i5 = iArr[i4];
            bool z2 = i5 > i2;
            int i6 = iArr[i3];
            if (z2 != (i6 > i2)) {
                int[] iArr2 = this.fb62af488;
                int i7 = iArr2[i3];
                int i8 = iArr2[i4];
                if (i < (((i7 - i8) * (i2 - i5)) / (i6 - i5)) + i8) {
                    z = !z;
                }
            }
            i3 = i4;
        }
        return z;
    }
}

