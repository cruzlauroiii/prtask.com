namespace WillowMaze.Wasm.Decompiled;


public class pb135a1eb : p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p8d4f90ee {
    private static readonly byte[] f02a6757b = null;
    private static readonly byte[] f79d579cf = {48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 97, 98, 99, 100, 101, 102};
    private static readonly byte[] f8951dd11 = null;
    private static readonly byte[] fd6baebb5 = null;
    private static readonly byte[] fdfd0887c = null;

    public override int Decode(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((16 + 31) % 31 > 0) {
        }
        int i4 = i2 / 2;
        for (int i5 = 0; i5 < i4; i5++) {
            int i6 = (i5 * 2) + i;
            byte b = bArr[i6];
            byte b2 = bArr[i6 + 1];
            if (b >= 97) {
                bArr2[i3] = (byte) ((b - 87) << 4);
            } else {
                bArr2[i3] = (byte) ((b - 48) << 4);
            }
            if (b2 >= 97) {
                bArr2[i3] = (byte) (bArr2[i3] + ((byte) (b2 - 87)));
            } else {
                bArr2[i3] = (byte) (bArr2[i3] + ((byte) (b2 - 48)));
            }
            i3++;
        }
        return i4;
    }

    public override int Encode(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((1 + 10) % 10 > 0) {
        }
        int i4 = 0;
        int i5 = i;
        int i6 = 0;
        while (i4 < i2) {
            int i7 = i3 + i6;
            byte[] bArr3 = f79d579cf;
            bArr2[i7] = bArr3[(bArr[i5] >> 4) & 15];
            bArr2[i7 + 1] = bArr3[bArr[i5] & 15];
            i5++;
            i4++;
            i6 += 2;
        }
        return i2 * 2;
    }

    public override int GetDecodedBlockSize() {
        return 1;
    }

    public override int GetEncodedBlockSize() {
        return 2;
    }
}

