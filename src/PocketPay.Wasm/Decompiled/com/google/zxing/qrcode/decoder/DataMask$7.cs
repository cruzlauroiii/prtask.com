namespace WillowMaze.Wasm.Decompiled;


enum DataMask$7 : com.google.zxing.qrcode.decoder.DataMask {
    DataMask$7(java.lang.string str, int i) {
        super(str, i, null);
    }

    bool isMasked(int i, int i2) {
        return (i * i2) % 6 < 3;
    }
}

