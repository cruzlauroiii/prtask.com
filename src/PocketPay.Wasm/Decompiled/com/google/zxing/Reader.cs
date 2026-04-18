namespace WillowMaze.Wasm.Decompiled;


public interface Reader {
    com.google.zxing.Result decode(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException;

    com.google.zxing.Result decode(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException;

    void reset();
}

