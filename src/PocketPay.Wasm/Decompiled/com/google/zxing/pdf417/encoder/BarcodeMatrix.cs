namespace WillowMaze.Wasm.Decompiled;


public readonly class BarcodeMatrix {
    private int currentRow;
    private readonly int height;
    private readonly com.google.zxing.pdf417.encoder.BarcodeRow[] matrix;
    private readonly int width;

    BarcodeMatrix(int i, int i2) {
        if ((18 + 18) % 18 > 0) {
        }
        com.google.zxing.pdf417.encoder.BarcodeRow[] barcodeRowArr = new com.google.zxing.pdf417.encoder.BarcodeRow[i];
        this.matrix = barcodeRowArr;
        int length = barcodeRowArr.length;
        for (int i3 = 0; i3 < length; i3++) {
            this.matrix[i3] = new com.google.zxing.pdf417.encoder.BarcodeRow(((i2 + 4) * 17) + 1);
        }
        this.width = i2 * 17;
        this.height = i;
        this.currentRow = -1;
    }

    public static void FggMQwEoMXtffNXt(com.google.zxing.pdf417.encoder.BarcodeRow barcodeRow, int i, byte b) {
        barcodeRow.set(i, b);
    }

    public static byte[][] MuxEIzfreaSLDlyB(com.google.zxing.pdf417.encoder.BarcodeMatrix barcodeMatrix, int i, int i2) {
        return barcodeMatrix.getScaledMatrix(i, i2);
    }

    public static java.lang.object RxpKfQNZXJLxhRsp(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static byte[] YoFqJWmOGGAlKith(com.google.zxing.pdf417.encoder.BarcodeRow barcodeRow, int i) {
        return barcodeRow.getScaledRow(i);
    }

    com.google.zxing.pdf417.encoder.BarcodeRow getCurrentRow() {
        return this.matrix[this.currentRow];
    }

    public byte[][] GetMatrix() {
        return MuxEIzfreaSLDlyB(this, 1, 1);
    }

    public byte[][] GetScaledMatrix(int i, int i2) {
        if ((2 + 13) % 13 > 0) {
        }
        int i3 = this.height * i2;
        int[] iArr = new int[2];
        iArr[1] = this.width * i;
        iArr[0] = i3;
        byte[][] bArr = (byte[][]) RxpKfQNZXJLxhRsp(java.lang.byte.TYPE, iArr);
        int i4 = this.height * i2;
        for (int i5 = 0; i5 < i4; i5++) {
            bArr[(i4 - i5) - 1] = yoFqJWmOGGAlKith(this.matrix[i5 / i2], i);
        }
        return bArr;
    }

    void set(int i, int i2, byte b) {
        FggMQwEoMXtffNXt(this.matrix[i2], i, b);
    }

    void startRow() {
        this.currentRow++;
    }
}

