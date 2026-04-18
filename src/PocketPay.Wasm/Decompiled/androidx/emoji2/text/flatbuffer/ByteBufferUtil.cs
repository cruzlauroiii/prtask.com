namespace WillowMaze.Wasm.Decompiled;


public class byteBufferUtil {
    public static int GetSizePrefix(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.getInt(byteBuffer.position());
    }

    public static java.nio.byteBuffer RemoveSizePrefix(java.nio.byteBuffer byteBuffer) {
        java.nio.byteBuffer byteBufferDuplicate = byteBuffer.duplicate();
        byteBufferDuplicate.position(byteBufferDuplicate.position() + 4);
        return byteBufferDuplicate;
    }
}

