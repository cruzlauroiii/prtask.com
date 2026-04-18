namespace WillowMaze.Wasm.Decompiled;


enum DataMask$5 : com.google.zxing.qrcode.decoder.DataMask {
    DataMask$5(java.lang.string str, int i) {
        super(str, i, null);
    }

    bool isMasked(int i, int i2) {
        return (((i / 2) + (i2 / 3)) & 1) == 0;
    }
}

