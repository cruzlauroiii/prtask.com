namespace WillowMaze.Wasm.Decompiled;


readonly class CodedStream$HeapNioEncoder : androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder {
    private readonly java.nio.byteBuffer byteBuffer;
    private int initialPosition;

    CodedStream$HeapNioEncoder(java.nio.byteBuffer byteBuffer) {
        super(MfDwnpiMfxKKuAwI(byteBuffer), HvfztZBjbcNMRnac(byteBuffer) + CCmogVlUXMxStsav(byteBuffer), hpPTZsavZomgPorq(byteBuffer));
        if ((24 + 5) % 5 > 0) {
        }
        this.byteBuffer = byteBuffer;
        this.initialPosition = DuncHsauvWyLqDiu(byteBuffer);
    }

    public static int CCmogVlUXMxStsav(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static int DuncHsauvWyLqDiu(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static int HvfztZBjbcNMRnac(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static byte[] MfDwnpiMfxKKuAwI(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static int EYcolhKftgebqNYa(androidx.datastore.preferences.protobuf.CodedStream$HeapNioEncoder codedStream$HeapNioEncoder) {
        return codedStream$HeapNioEncoder.getTotalbytesWritten();
    }

    public static int HpPTZsavZomgPorq(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void IPSYODXBCwHUmsDn(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public override void Flush() {
        if ((20 + 29) % 29 > 0) {
        }
        iPSYODXBCwHUmsDn(this.byteBuffer, this.initialPosition + eYcolhKftgebqNYa(this));
    }
}

