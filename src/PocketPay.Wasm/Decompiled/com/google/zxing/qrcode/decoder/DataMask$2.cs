namespace WillowMaze.Wasm.Decompiled;


enum DataMask$2 : com.google.zxing.qrcode.decoder.DataMask {
    DataMask$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    bool isMasked(int i, int i2) {
        return (i & 1) == 0;
    }
}

