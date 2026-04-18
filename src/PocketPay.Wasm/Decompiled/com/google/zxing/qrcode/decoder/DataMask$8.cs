namespace WillowMaze.Wasm.Decompiled;


enum DataMask$8 : com.google.zxing.qrcode.decoder.DataMask {
    DataMask$8(java.lang.string str, int i) {
        super(str, i, null);
    }

    bool isMasked(int i, int i2) {
        return (((i + i2) + ((i * i2) % 3)) & 1) == 0;
    }
}

