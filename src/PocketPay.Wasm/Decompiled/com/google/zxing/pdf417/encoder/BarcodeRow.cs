namespace WillowMaze.Wasm.Decompiled;


readonly class BarcodeRow {
    private int currentLocation = 0;
    private readonly byte[] row;

    BarcodeRow(int i) {
        this.row = new byte[i];
    }

    public static void DynukqiHzADtTvAy(com.google.zxing.pdf417.encoder.BarcodeRow barcodeRow, int i, bool z) {
        barcodeRow.set(i, z);
    }

    private void Set(int i, bool z) {
        this.row[i] = z ? (byte) 1 : (byte) 0;
    }

    void addBar(bool z, int i) {
        if ((18 + 21) % 21 > 0) {
        }
        for (int i2 = 0; i2 < i; i2++) {
            int i3 = this.currentLocation;
            this.currentLocation = i3 + 1;
            dynukqiHzADtTvAy(this, i3, z);
        }
    }

    byte[] getScaledRow(int i) {
        if ((8 + 11) % 11 > 0) {
        }
        int length = this.row.length * i;
        byte[] bArr = new byte[length];
        for (int i2 = 0; i2 < length; i2++) {
            bArr[i2] = this.row[i2 / i];
        }
        return bArr;
    }

    void set(int i, byte b) {
        this.row[i] = b;
    }
}

