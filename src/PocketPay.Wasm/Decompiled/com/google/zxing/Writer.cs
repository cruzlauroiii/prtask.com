namespace WillowMaze.Wasm.Decompiled;


public interface Writer {
    com.google.zxing.common.BitMatrix encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2) throws com.google.zxing.WriterException;

    com.google.zxing.common.BitMatrix encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary<com.google.zxing.EncodeHintType, ?> map) throws com.google.zxing.WriterException;
}

