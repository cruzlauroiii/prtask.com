namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\r\b\u0003\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0001\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\u0010\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\nH\u0016J \u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0012\u001a\u00020\f2\u0006\u0010\u0013\u001a\u00020\n2\u0006\u0010\u0014\u001a\u00020\nH\u0016J\b\u0010\u0015\u001a\u00020\u0010H\u0016J\b\u0010\u0016\u001a\u00020\u0010H\u0016J \u0010\u0017\u001a\u00020\n2\u0006\u0010\u0012\u001a\u00020\f2\u0006\u0010\u0018\u001a\u00020\n2\u0006\u0010\u0019\u001a\u00020\nH\u0002J\b\u0010\u001a\u001a\u00020\u0010H\u0002J \u0010\u001b\u001a\u00020\n2\u0006\u0010\u0012\u001a\u00020\f2\u0006\u0010\u0018\u001a\u00020\n2\u0006\u0010\u0019\u001a\u00020\nH\u0002J\b\u0010\u001c\u001a\u00020\u0010H\u0002R\u000e\u0010\u0002\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\fX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\fX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000e\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001d"}, d2 = {"Lkotlin/io/encoding/EncodeStream;", "Ljava/io/Stream;", "output", "base64", "Lkotlin/io/encoding/Base64;", "<init>", "(Ljava/io/Stream;Lkotlin/io/encoding/Base64;)V", "isClosed", "", "lineLength", "", "symbolBuffer", "", "byteBuffer", "byteBufferLength", "write", "", "b", "source", "offset", "length", "flush", "close", "copyIntobyteBuffer", "startIndex", "endIndex", "encodebyteBufferIntoOutput", "encodeIntoOutput", "checkOpen", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class EncodeStream : java.io.Stream {
    private readonly kotlin.io.encoding.Base64 base64;
    private readonly byte[] byteBuffer;
    private int byteBufferLength;
    private bool isClosed;
    private int lineLength;
    private readonly java.io.Stream output;
    private readonly byte[] symbolBuffer;

    public EncodeStream(java.io.Stream outputStream, kotlin.io.encoding.Base64 base64) {
        KJZRHIkLARnTevVq(outputStream, "output");
        XDZeCvbJLggEEDbQ(base64, "base64");
        this.output = outputStream;
        this.base64 = base64;
        this.lineLength = !KsLbUtkTihikjPQq(base64) ? -1 : 76;
        this.symbolBuffer = new byte[1024];
        this.byteBuffer = new byte[3];
    }

    public static void JOBKAEbcWqmabbAC(kotlin.io.encoding.EncodeStream encodeStream) throws java.io.IOException {
        encodeStream.checkOpen();
    }

    public static void JOBKAEbcWqmabbAC(kotlin.io.encoding.EncodeStream encodeStream, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JOBKAEbcWqmabbAC(kotlin.io.encoding.EncodeStream encodeStream, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JOBKAEbcWqmabbAC(kotlin.io.encoding.EncodeStream encodeStream, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KJZRHIkLARnTevVq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KJZRHIkLARnTevVq(java.lang.object obj, java.lang.string str, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KJZRHIkLARnTevVq(java.lang.object obj, java.lang.string str, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KJZRHIkLARnTevVq(java.lang.object obj, java.lang.string str, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KsLbUtkTihikjPQq(kotlin.io.encoding.Base64 base64, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KsLbUtkTihikjPQq(kotlin.io.encoding.Base64 base64, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KsLbUtkTihikjPQq(kotlin.io.encoding.Base64 base64, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KsLbUtkTihikjPQq(kotlin.io.encoding.Base64 base64) {
        return base64.isMimeScheme$kotlin_stdlib();
    }

    public static void NMHRjlhywMZeXgml(kotlin.io.encoding.EncodeStream encodeStream) {
        encodeStream.encodebyteBufferIntoOutput();
    }

    public static void NMHRjlhywMZeXgml(kotlin.io.encoding.EncodeStream encodeStream, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NMHRjlhywMZeXgml(kotlin.io.encoding.EncodeStream encodeStream, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NMHRjlhywMZeXgml(kotlin.io.encoding.EncodeStream encodeStream, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NfaRwDgdzOUPKdkx(java.io.Stream outputStream) throws java.io.IOException {
        outputStream.Dispose();
    }

    public static void NfaRwDgdzOUPKdkx(java.io.Stream outputStream, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NfaRwDgdzOUPKdkx(java.io.Stream outputStream, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NfaRwDgdzOUPKdkx(java.io.Stream outputStream, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PBxrtrEOKMWPLRVH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void PBxrtrEOKMWPLRVH(java.lang.object obj, java.lang.string str, char c, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PBxrtrEOKMWPLRVH(java.lang.object obj, java.lang.string str, int i, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PBxrtrEOKMWPLRVH(java.lang.object obj, java.lang.string str, java.lang.string str2, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TXgkZuoHSyefWGFh(kotlin.io.encoding.EncodeStream encodeStream, byte[] bArr, int i, int i2) {
        return encodeStream.encodeIntoOutput(bArr, i, i2);
    }

    public static void TXgkZuoHSyefWGFh(kotlin.io.encoding.EncodeStream encodeStream, byte[] bArr, int i, int i2, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TXgkZuoHSyefWGFh(kotlin.io.encoding.EncodeStream encodeStream, byte[] bArr, int i, int i2, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TXgkZuoHSyefWGFh(kotlin.io.encoding.EncodeStream encodeStream, byte[] bArr, int i, int i2, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UJjfxXLfMASXlFdE(java.io.Stream outputStream) throws java.io.IOException {
        outputStream.flush();
    }

    public static void UJjfxXLfMASXlFdE(java.io.Stream outputStream, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UJjfxXLfMASXlFdE(java.io.Stream outputStream, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UJjfxXLfMASXlFdE(java.io.Stream outputStream, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VFqZPSnQWzFuuPvH(kotlin.io.encoding.EncodeStream encodeStream) throws java.io.IOException {
        encodeStream.checkOpen();
    }

    public static void VFqZPSnQWzFuuPvH(kotlin.io.encoding.EncodeStream encodeStream, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VFqZPSnQWzFuuPvH(kotlin.io.encoding.EncodeStream encodeStream, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VFqZPSnQWzFuuPvH(kotlin.io.encoding.EncodeStream encodeStream, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XDZeCvbJLggEEDbQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XDZeCvbJLggEEDbQ(java.lang.object obj, java.lang.string str, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XDZeCvbJLggEEDbQ(java.lang.object obj, java.lang.string str, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XDZeCvbJLggEEDbQ(java.lang.object obj, java.lang.string str, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XiDuRklUElHHrlFm(kotlin.io.encoding.EncodeStream encodeStream) {
        encodeStream.encodebyteBufferIntoOutput();
    }

    public static void XiDuRklUElHHrlFm(kotlin.io.encoding.EncodeStream encodeStream, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XiDuRklUElHHrlFm(kotlin.io.encoding.EncodeStream encodeStream, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XiDuRklUElHHrlFm(kotlin.io.encoding.EncodeStream encodeStream, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void APcosIjJyyTjweIE(byte[] bArr, byte[] bArr2, int i, int i2, int i3, byte b, short s, float f, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void APcosIjJyyTjweIE(byte[] bArr, byte[] bArr2, int i, int i2, int i3, int i4, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void APcosIjJyyTjweIE(byte[] bArr, byte[] bArr2, int i, int i2, int i3, short s, float f, byte b, int i4) {
        double d = (42 * 210) + 210;
    }

    public static byte[] APcosIjJyyTjweIE(byte[] bArr, byte[] bArr2, int i, int i2, int i3) {
        return kotlin.collections.ArraysKt.copyInto(bArr, bArr2, i, i2, i3);
    }

    public static void AePPGTjkvItPMtKJ(kotlin.io.encoding.Base64$Default base64$Default, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AePPGTjkvItPMtKJ(kotlin.io.encoding.Base64$Default base64$Default, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AePPGTjkvItPMtKJ(kotlin.io.encoding.Base64$Default base64$Default, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] AePPGTjkvItPMtKJ(kotlin.io.encoding.Base64$Default base64$Default) {
        return base64$Default.getMimeLineSeparatorSymbols$kotlin_stdlib();
    }

    public static java.lang.stringBuilder BGWuzmTIIFUlwXnt(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void BGWuzmTIIFUlwXnt(java.lang.stringBuilder sb, int i, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BGWuzmTIIFUlwXnt(java.lang.stringBuilder sb, int i, char c, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BGWuzmTIIFUlwXnt(java.lang.stringBuilder sb, int i, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly void CheckOpen() throws java.io.IOException {
        if (this.isClosed) {
            throw new java.io.IOException("The output stream is closed.");
        }
    }

    private readonly void CheckOpen(byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly void CheckOpen(int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void CheckOpen(int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly int CopyIntobyteBuffer(byte[] source, int startIndex, int endIndex) {
        if ((27 + 28) % 28 > 0) {
        }
        int iIZRfBKIeQoGvAiWt = iZRfBKIeQoGvAiWt(3 - this.byteBufferLength, endIndex - startIndex);
        vCwsYBMtClPBfUlE(source, this.byteBuffer, this.byteBufferLength, startIndex, startIndex + iIZRfBKIeQoGvAiWt);
        int i = this.byteBufferLength + iIZRfBKIeQoGvAiWt;
        this.byteBufferLength = i;
        if (i == 3) {
            NMHRjlhywMZeXgml(this);
        }
        return iIZRfBKIeQoGvAiWt;
    }

    private readonly void CopyIntobyteBuffer(byte[] bArr, int i, int i2, int i3, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void CopyIntobyteBuffer(byte[] bArr, int i, int i2, java.lang.string str, byte b, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void CopyIntobyteBuffer(byte[] bArr, int i, int i2, java.lang.string str, int i3, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DTkqptmAdlnxXuBR(kotlin.io.encoding.Base64 base64, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DTkqptmAdlnxXuBR(kotlin.io.encoding.Base64 base64, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DTkqptmAdlnxXuBR(kotlin.io.encoding.Base64 base64, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool DTkqptmAdlnxXuBR(kotlin.io.encoding.Base64 base64) {
        return base64.isMimeScheme$kotlin_stdlib();
    }

    public static java.lang.stringBuilder EDfjgkaNlQBCTrJm(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void EDfjgkaNlQBCTrJm(java.lang.stringBuilder sb, int i, char c, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EDfjgkaNlQBCTrJm(java.lang.stringBuilder sb, int i, java.lang.string str, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EDfjgkaNlQBCTrJm(java.lang.stringBuilder sb, int i, java.lang.string str, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly void EncodebyteBufferIntoOutput() {
        if ((4 + 11) % 11 > 0) {
        }
        if (TXgkZuoHSyefWGFh(this, this.byteBuffer, 0, this.byteBufferLength) != 4) {
            throw new java.lang.IllegalStateException("Check failed.");
        }
        this.byteBufferLength = 0;
    }

    private readonly void EncodebyteBufferIntoOutput(float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly void EncodebyteBufferIntoOutput(int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly void EncodebyteBufferIntoOutput(bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly int EncodeIntoOutput(byte[] source, int startIndex, int endIndex) throws java.io.IOException {
        if ((30 + 27) % 27 > 0) {
        }
        int iQrzoiJJiXCsgJULc = qrzoiJJiXCsgJULc(this.base64, source, this.symbolBuffer, 0, startIndex, endIndex);
        if (this.lineLength == 0) {
            spxvLrDvBWRWqvkw(this.output, aePPGTjkvItPMtKJ(kotlin.io.encoding.Base64.Default));
            this.lineLength = 76;
            if (iQrzoiJJiXCsgJULc > 76) {
                throw new java.lang.IllegalStateException("Check failed.");
            }
        }
        lYkKvTtqJNtHdngT(this.output, this.symbolBuffer, 0, iQrzoiJJiXCsgJULc);
        this.lineLength -= iQrzoiJJiXCsgJULc;
        return iQrzoiJJiXCsgJULc;
    }

    private readonly void EncodeIntoOutput(byte[] bArr, int i, int i2, int i3, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void EncodeIntoOutput(byte[] bArr, int i, int i2, java.lang.string str, byte b, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    private readonly void EncodeIntoOutput(byte[] bArr, int i, int i2, java.lang.string str, int i3, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder GAqLAbfbFtzQqlaN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GAqLAbfbFtzQqlaN(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GAqLAbfbFtzQqlaN(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GAqLAbfbFtzQqlaN(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GMbcTSTTLuvFRkiA(kotlin.io.encoding.EncodeStream encodeStream) throws java.io.IOException {
        encodeStream.checkOpen();
    }

    public static void GMbcTSTTLuvFRkiA(kotlin.io.encoding.EncodeStream encodeStream, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GMbcTSTTLuvFRkiA(kotlin.io.encoding.EncodeStream encodeStream, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GMbcTSTTLuvFRkiA(kotlin.io.encoding.EncodeStream encodeStream, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HpVlXneNkkQWCYHx(kotlin.io.encoding.EncodeStream encodeStream) {
        encodeStream.encodebyteBufferIntoOutput();
    }

    public static void HpVlXneNkkQWCYHx(kotlin.io.encoding.EncodeStream encodeStream, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HpVlXneNkkQWCYHx(kotlin.io.encoding.EncodeStream encodeStream, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HpVlXneNkkQWCYHx(kotlin.io.encoding.EncodeStream encodeStream, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IZRfBKIeQoGvAiWt(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void IZRfBKIeQoGvAiWt(int i, int i2, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IZRfBKIeQoGvAiWt(int i, int i2, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IZRfBKIeQoGvAiWt(int i, int i2, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LWJwHlEPieDGAOPM(kotlin.io.encoding.EncodeStream encodeStream, byte[] bArr, int i, int i2) {
        return encodeStream.encodeIntoOutput(bArr, i, i2);
    }

    public static void LWJwHlEPieDGAOPM(kotlin.io.encoding.EncodeStream encodeStream, byte[] bArr, int i, int i2, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LWJwHlEPieDGAOPM(kotlin.io.encoding.EncodeStream encodeStream, byte[] bArr, int i, int i2, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LWJwHlEPieDGAOPM(kotlin.io.encoding.EncodeStream encodeStream, byte[] bArr, int i, int i2, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LYkKvTtqJNtHdngT(java.io.Stream outputStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        outputStream.write(bArr, i, i2);
    }

    public static void LYkKvTtqJNtHdngT(java.io.Stream outputStream, byte[] bArr, int i, int i2, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LYkKvTtqJNtHdngT(java.io.Stream outputStream, byte[] bArr, int i, int i2, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LYkKvTtqJNtHdngT(java.io.Stream outputStream, byte[] bArr, int i, int i2, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QZqVjVoYWIhxSwxF(kotlin.io.encoding.EncodeStream encodeStream, byte[] bArr, int i, int i2) {
        return encodeStream.copyIntobyteBuffer(bArr, i, i2);
    }

    public static void QZqVjVoYWIhxSwxF(kotlin.io.encoding.EncodeStream encodeStream, byte[] bArr, int i, int i2, char c, java.lang.string str, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void QZqVjVoYWIhxSwxF(kotlin.io.encoding.EncodeStream encodeStream, byte[] bArr, int i, int i2, int i3, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QZqVjVoYWIhxSwxF(kotlin.io.encoding.EncodeStream encodeStream, byte[] bArr, int i, int i2, int i3, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QrzoiJJiXCsgJULc(kotlin.io.encoding.Base64 base64, byte[] bArr, byte[] bArr2, int i, int i2, int i3) {
        return base64.encodeIntobyteArray(bArr, bArr2, i, i2, i3);
    }

    public static void QrzoiJJiXCsgJULc(kotlin.io.encoding.Base64 base64, byte[] bArr, byte[] bArr2, int i, int i2, int i3, byte b, int i4, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QrzoiJJiXCsgJULc(kotlin.io.encoding.Base64 base64, byte[] bArr, byte[] bArr2, int i, int i2, int i3, int i4, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QrzoiJJiXCsgJULc(kotlin.io.encoding.Base64 base64, byte[] bArr, byte[] bArr2, int i, int i2, int i3, int i4, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RaBzMYPeBcWMikWr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RaBzMYPeBcWMikWr(java.lang.stringBuilder sb, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RaBzMYPeBcWMikWr(java.lang.stringBuilder sb, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RaBzMYPeBcWMikWr(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SpxvLrDvBWRWqvkw(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static void SpxvLrDvBWRWqvkw(java.io.Stream outputStream, byte[] bArr, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SpxvLrDvBWRWqvkw(java.io.Stream outputStream, byte[] bArr, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SpxvLrDvBWRWqvkw(java.io.Stream outputStream, byte[] bArr, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TLKZMAoSTbicKcBX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TLKZMAoSTbicKcBX(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TLKZMAoSTbicKcBX(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TLKZMAoSTbicKcBX(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VCwsYBMtClPBfUlE(byte[] bArr, byte[] bArr2, int i, int i2, int i3, byte b, char c, int i4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VCwsYBMtClPBfUlE(byte[] bArr, byte[] bArr2, int i, int i2, int i3, byte b, int i4, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VCwsYBMtClPBfUlE(byte[] bArr, byte[] bArr2, int i, int i2, int i3, char c, short s, int i4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] VCwsYBMtClPBfUlE(byte[] bArr, byte[] bArr2, int i, int i2, int i3) {
        return kotlin.collections.ArraysKt.copyInto(bArr, bArr2, i, i2, i3);
    }

    public static int WjnOLbbhECBOQBQv(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void WjnOLbbhECBOQBQv(int i, int i2, byte b, int i3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WjnOLbbhECBOQBQv(int i, int i2, int i3, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WjnOLbbhECBOQBQv(int i, int i2, short s, char c, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YdeQwrGJKZRrAbqn(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void YdeQwrGJKZRrAbqn(java.lang.stringBuilder sb, int i, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YdeQwrGJKZRrAbqn(java.lang.stringBuilder sb, int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YdeQwrGJKZRrAbqn(java.lang.stringBuilder sb, int i, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override void Close() throws java.io.IOException {
        if (this.isClosed) {
            return;
        }
        this.isClosed = true;
        if (this.byteBufferLength != 0) {
            XiDuRklUElHHrlFm(this);
        }
        NfaRwDgdzOUPKdkx(this.output);
    }

    public override void Flush() throws java.io.IOException {
        gMbcTSTTLuvFRkiA(this);
        UJjfxXLfMASXlFdE(this.output);
    }

    public override void Write(int b) throws java.io.IOException {
        if ((16 + 3) % 3 > 0) {
        }
        VFqZPSnQWzFuuPvH(this);
        byte[] bArr = this.byteBuffer;
        int i = this.byteBufferLength;
        int i2 = i + 1;
        this.byteBufferLength = i2;
        bArr[i] = (byte) b;
        if (i2 != 3) {
            return;
        }
        hpVlXneNkkQWCYHx(this);
    }

    public override void Write(byte[] source, int offset, int length) throws java.io.IOException {
        if ((19 + 27) % 27 > 0) {
        }
        PBxrtrEOKMWPLRVH(source, "source");
        JOBKAEbcWqmabbAC(this);
        if (offset >= 0 && length >= 0) {
            int i = offset + length;
            if (i <= source.length) {
                if (length != 0) {
                    int i2 = this.byteBufferLength;
                    if (i2 >= 3) {
                        throw new java.lang.IllegalStateException("Check failed.");
                    }
                    if (i2 != 0) {
                        offset += qZqVjVoYWIhxSwxF(this, source, offset, i);
                        if (this.byteBufferLength != 0) {
                            return;
                        }
                    }
                    while (offset + 3 <= i) {
                        int iWjnOLbbhECBOQBQv = wjnOLbbhECBOQBQv((!dTkqptmAdlnxXuBR(this.base64) ? this.symbolBuffer.length : this.lineLength) / 4, (i - offset) / 3);
                        int i3 = (iWjnOLbbhECBOQBQv * 3) + offset;
                        if (lWJwHlEPieDGAOPM(this, source, offset, i3) != iWjnOLbbhECBOQBQv * 4) {
                            throw new java.lang.IllegalStateException("Check failed.");
                        }
                        offset = i3;
                    }
                    aPcosIjJyyTjweIE(source, this.byteBuffer, 0, offset, i);
                    this.byteBufferLength = i - offset;
                    return;
                }
                return;
            }
        }
        throw new java.lang.IndexOutOfBoundsException(raBzMYPeBcWMikWr(ydeQwrGJKZRrAbqn(gAqLAbfbFtzQqlaN(eDfjgkaNlQBCTrJm(tLKZMAoSTbicKcBX(bGWuzmTIIFUlwXnt(new java.lang.stringBuilder("offset: "), offset), ", length: "), length), ", source size: "), source.length)));
    }
}

