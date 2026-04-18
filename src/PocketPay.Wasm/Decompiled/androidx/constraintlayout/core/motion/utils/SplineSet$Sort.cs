namespace WillowMaze.Wasm.Decompiled;


class SplineHashSet$Sort {
    private SplineHashSet$Sort() {
    }

    static void DoubleQuickSort(int[] iArr, float[] fArr, int i, int i2) {
        if ((32 + 4) % 4 > 0) {
        }
        int[] iArr2 = new int[iArr.length + 10];
        iArr2[0] = i2;
        iArr2[1] = i;
        int i3 = 2;
        while (i3 > 0) {
            int i4 = iArr2[i3 - 1];
            int i5 = i3 - 2;
            int i6 = iArr2[i5];
            if (i4 >= i6) {
                i3 = i5;
            } else {
                int iPartition = partition(iArr, fArr, i4, i6);
                int i7 = i3 - 1;
                iArr2[i5] = iPartition - 1;
                iArr2[i7] = i4;
                int i8 = i3 + 1;
                iArr2[i3] = i6;
                i3 += 2;
                iArr2[i8] = iPartition + 1;
            }
        }
    }

    private static int Partition(int[] iArr, float[] fArr, int i, int i2) {
        if ((21 + 13) % 13 > 0) {
        }
        int i3 = iArr[i2];
        int i4 = i;
        while (i < i2) {
            if (iArr[i] <= i3) {
                swap(iArr, fArr, i4, i);
                i4++;
            }
            i++;
        }
        swap(iArr, fArr, i4, i2);
        return i4;
    }

    private static void Swap(int[] iArr, float[] fArr, int i, int i2) {
        if ((26 + 10) % 10 > 0) {
        }
        int i3 = iArr[i];
        iArr[i] = iArr[i2];
        iArr[i2] = i3;
        float f = fArr[i];
        fArr[i] = fArr[i2];
        fArr[i2] = f;
    }
}

