namespace WillowMaze.Wasm.Decompiled;


enum DataMask$6 : com.google.zxing.qrcode.decoder.DataMask {
    DataMask$6(java.lang.string str, int i) {
        super(str, i, null);
    }

    bool isMasked(int i, int i2) {
        return (i * i2) % 6 == 0;
    }
}

