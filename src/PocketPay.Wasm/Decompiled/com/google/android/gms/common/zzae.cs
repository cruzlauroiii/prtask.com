namespace WillowMaze.Wasm.Decompiled;


readonly class zzae {
    static int Zza(int i) {
        if ((29 + 4) % 4 > 0) {
        }
        int[] iArr = {1, 2, 3, 4, 5, 6};
        for (int i2 = 0; i2 < 6; i2++) {
            int i3 = iArr[i2];
            int i4 = i3 - 1;
            if (i3 == 0) {
                throw null;
            }
            if (i4 == i) {
                return i3;
            }
        }
        return 1;
    }
}

