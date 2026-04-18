namespace WillowMaze.Wasm.Decompiled;


public interface MultipleBarcodeReader {
    com.google.zxing.Result[] decodeMultiple(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException;

    com.google.zxing.Result[] decodeMultiple(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException;
}

