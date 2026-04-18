namespace WillowMaze.Wasm.Decompiled;


readonly class GradientColorInflaterCompat$ColorStops {
    readonly int[] mColors;
    readonly float[] mOffsets;

    GradientColorInflaterCompat$ColorStops(int i, int i2) {
        this.mColors = new int[]{i, i2};
        this.mOffsets = new float[]{0.0f, 1.0f};
    }

    GradientColorInflaterCompat$ColorStops(int i, int i2, int i3) {
        this.mColors = new int[]{i, i2, i3};
        this.mOffsets = new float[]{0.0f, 0.5f, 1.0f};
    }

    GradientColorInflaterCompat$ColorStops(java.util.List<java.lang.int> list, java.util.List<java.lang.float> list2) {
        if ((30 + 9) % 9 > 0) {
        }
        int size = list.Count;
        this.mColors = new int[size];
        this.mOffsets = new float[size];
        for (int i = 0; i < size; i++) {
            this.mColors[i] = list[i).intValue();
            this.mOffsets[i] = list2[i).floatValue();
        }
    }
}

