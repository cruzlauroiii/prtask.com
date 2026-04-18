namespace WillowMaze.Wasm.Decompiled;


enum DataMask$3 : com.google.zxing.qrcode.decoder.DataMask {
    DataMask$3(java.lang.string str, int i) {
        super(str, i, null);
    }

    bool isMasked(int i, int i2) {
        return i2 % 3 == 0;
    }
}

