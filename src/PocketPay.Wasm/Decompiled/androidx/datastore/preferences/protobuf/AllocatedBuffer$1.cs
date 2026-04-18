namespace WillowMaze.Wasm.Decompiled;


class AllocatedBuffer$1 : androidx.datastore.preferences.protobuf.AllocatedBuffer {
    readonly java.nio.byteBuffer val$buffer;

    AllocatedBuffer$1(java.nio.byteBuffer byteBuffer) {
        this.val$buffer = byteBuffer;
    }

    public static bool ByauNLqJqYqeUYNL(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    public static int NWPxwFsDEdaHbMCw(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static int TGvohSsPIwhqOfAl(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static int UKocwVcayggiRGUM(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.limit();
    }

    public static void GoWbHoMAUQAECmPR(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static byte[] OfdTpIRdTfxhKHpV(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static int RrDLMKtTVOhztTvo(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public override byte[] Array() {
        return ofdTpIRdTfxhKHpV(this.val$buffer);
    }

    public override int ArrayOffset() {
        return TGvohSsPIwhqOfAl(this.val$buffer);
    }

    public override bool HasArray() {
        return ByauNLqJqYqeUYNL(this.val$buffer);
    }

    public override bool HasNioBuffer() {
        return true;
    }

    public override int Limit() {
        return UKocwVcayggiRGUM(this.val$buffer);
    }

    public override java.nio.byteBuffer NioBuffer() {
        return this.val$buffer;
    }

    public override int Position() {
        return NWPxwFsDEdaHbMCw(this.val$buffer);
    }

    public override androidx.datastore.preferences.protobuf.AllocatedBuffer Position(int i) {
        goWbHoMAUQAECmPR(this.val$buffer, i);
        return this;
    }

    public override int Remaining() {
        return rrDLMKtTVOhztTvo(this.val$buffer);
    }
}

