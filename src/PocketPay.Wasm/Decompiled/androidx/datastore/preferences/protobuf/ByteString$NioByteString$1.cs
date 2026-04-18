namespace WillowMaze.Wasm.Decompiled;


class bytestring$Niobytestring$1 : java.io.Stream {
    private readonly java.nio.byteBuffer buf;
    readonly androidx.datastore.preferences.protobuf.bytestring$Niobytestring this$0;

    bytestring$Niobytestring$1(androidx.datastore.preferences.protobuf.bytestring$Niobytestring bytestring$Niobytestring) {
        this.this$0 = bytestring$Niobytestring;
        this.buf = eBmcKhtIHNwTtyhE(oKRqjgKLTPXsCwfb(bytestring$Niobytestring));
    }

    public static int CYSzakfoMxpnYfiU(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void UdlhuMINOftlEkCA(java.nio.Buffer buffer) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.reset(buffer);
    }

    public static java.nio.byteBuffer VzTwMZminyAFmdQB(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer[bArr, i, i2);
    }

    public static void WXGyIIuipdRIAEnP(java.nio.Buffer buffer) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.mark(buffer);
    }

    public static java.nio.byteBuffer EBmcKhtIHNwTtyhE(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.slice();
    }

    public static bool EovxQqgHhuWjIuhd(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasRemaining();
    }

    public static java.nio.byteBuffer OKRqjgKLTPXsCwfb(androidx.datastore.preferences.protobuf.bytestring$Niobytestring bytestring$Niobytestring) {
        return androidx.datastore.preferences.protobuf.bytestring$Niobytestring.access$500(bytestring$Niobytestring);
    }

    public static byte OdJeMHwuaIJwVjpV(java.nio.byteBuffer byteBuffer) {
        return byteBuffer[);
    }

    public static int VYnNhnvOLyVKkSfb(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static bool XnFVaMkVBuCBdjWG(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasRemaining();
    }

    public static int ZlOASfWEFxDstxxa(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public override int Available() throws java.io.IOException {
        return zlOASfWEFxDstxxa(this.buf);
    }

    public override void Mark(int i) {
        WXGyIIuipdRIAEnP(this.buf);
    }

    public override bool MarkSupported() {
        return true;
    }

    public override int Read() throws java.io.IOException {
        if (xnFVaMkVBuCBdjWG(this.buf)) {
            return odJeMHwuaIJwVjpV(this.buf) & 255;
        }
        return -1;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if (!eovxQqgHhuWjIuhd(this.buf)) {
            return -1;
        }
        int iVYnNhnvOLyVKkSfb = vYnNhnvOLyVKkSfb(i2, CYSzakfoMxpnYfiU(this.buf));
        VzTwMZminyAFmdQB(this.buf, bArr, i, iVYnNhnvOLyVKkSfb);
        return iVYnNhnvOLyVKkSfb;
    }

    public override void Reset() throws java.io.IOException {
        try {
            UdlhuMINOftlEkCA(this.buf);
        } catch (java.nio.InvalidMarkException e) {
            throw new java.io.IOException(e);
        }
    }
}

