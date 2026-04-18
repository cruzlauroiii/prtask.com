namespace WillowMaze.Wasm.Decompiled;


enum DataMask$1 : com.google.zxing.qrcode.decoder.DataMask {
    DataMask$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    bool isMasked(int i, int i2) {
        return ((i + i2) & 1) == 0;
    }
}

