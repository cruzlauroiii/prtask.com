namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0012\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\t\n\u0002\u0010\u0002\n\u0002\b\u000b\b\u0003\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0001\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\b\u0010\u0014\u001a\u00020\u000fH\u0016J \u0010\u0014\u001a\u00020\u000f2\u0006\u0010\u0015\u001a\u00020\u000b2\u0006\u0010\u0016\u001a\u00020\u000f2\u0006\u0010\u0017\u001a\u00020\u000fH\u0016J\b\u0010\u0018\u001a\u00020\u0019H\u0016J(\u0010\u001a\u001a\u00020\u000f2\u0006\u0010\u001b\u001a\u00020\u000b2\u0006\u0010\u001c\u001a\u00020\u000f2\u0006\u0010\u001d\u001a\u00020\u000f2\u0006\u0010\u001e\u001a\u00020\u000fH\u0002J \u0010\u001f\u001a\u00020\u00192\u0006\u0010\u001b\u001a\u00020\u000b2\u0006\u0010\u001c\u001a\u00020\u000f2\u0006\u0010\u0017\u001a\u00020\u000fH\u0002J\b\u0010 \u001a\u00020\u0019H\u0002J\b\u0010!\u001a\u00020\u0019H\u0002J\u0010\u0010\"\u001a\u00020\u000f2\u0006\u0010\u001e\u001a\u00020\u000fH\u0002J\b\u0010#\u001a\u00020\u000fH\u0002R\u000e\u0010\u0002\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\bX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000e\u001a\u00020\u000fX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0010\u001a\u00020\u000fX\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u0011\u001a\u00020\u000f8BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0013¨\u0006$"}, d2 = {"Lkotlin/io/encoding/DecodeStream;", "Ljava/io/Stream;", "input", "base64", "Lkotlin/io/encoding/Base64;", "<init>", "(Ljava/io/Stream;Lkotlin/io/encoding/Base64;)V", "isClosed", "", "isEOF", "singlebyteBuffer", "", "symbolBuffer", "byteBuffer", "byteBufferStartIndex", "", "byteBufferEndIndex", "byteBufferLength", "getbyteBufferLength", "()I", "read", "destination", "offset", "length", "close", "", "decodeSymbolBufferInto", "dst", "dstOffset", "dstEndIndex", "symbolBufferLength", "copybyteBufferInto", "resetbyteBufferIfEmpty", "shiftbyteBufferToStartIfNeeded", "handlePaddingSymbol", "readNextSymbol", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class DecodeStream : java.io.Stream {
    private readonly kotlin.io.encoding.Base64 base64;
    private readonly byte[] byteBuffer;
    private int byteBufferEndIndex;
    private int byteBufferStartIndex;
    private readonly java.io.Stream input;
    private bool isClosed;
    private bool isEOF;
    private readonly byte[] singlebyteBuffer;
    private readonly byte[] symbolBuffer;

    public DecodeStream(java.io.Stream inputStream, kotlin.io.encoding.Base64 base64) {
        GluKxUFwqTUAoUQA(inputStream, "input");
        zhWjgHJnDPBVpNGr(base64, "base64");
        this.input = inputStream;
        this.base64 = base64;
        this.singlebyteBuffer = new byte[1];
        this.symbolBuffer = new byte[1024];
        this.byteBuffer = new byte[1024];
    }

    public static int AyBmxoDHyNruRNyu(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void AyBmxoDHyNruRNyu(int i, int i2, byte b, int i3, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AyBmxoDHyNruRNyu(int i, int i2, byte b, java.lang.string str, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void AyBmxoDHyNruRNyu(int i, int i2, java.lang.string str, byte b, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BEpwhoAMbTQHhywK(kotlin.io.encoding.DecodeStream decodeStream) {
        decodeStream.resetbyteBufferIfEmpty();
    }

    public static void BEpwhoAMbTQHhywK(kotlin.io.encoding.DecodeStream decodeStream, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BEpwhoAMbTQHhywK(kotlin.io.encoding.DecodeStream decodeStream, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BEpwhoAMbTQHhywK(kotlin.io.encoding.DecodeStream decodeStream, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int BpsIeWCvOOILmJPy(kotlin.io.encoding.DecodeStream decodeStream) {
        return decodeStream.readNextSymbol();
    }

    public static void BpsIeWCvOOILmJPy(kotlin.io.encoding.DecodeStream decodeStream, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BpsIeWCvOOILmJPy(kotlin.io.encoding.DecodeStream decodeStream, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BpsIeWCvOOILmJPy(kotlin.io.encoding.DecodeStream decodeStream, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DtQRJTgwPIWPaynj(kotlin.io.encoding.DecodeStream decodeStream) {
        return decodeStream.getbyteBufferLength();
    }

    public static void DtQRJTgwPIWPaynj(kotlin.io.encoding.DecodeStream decodeStream, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DtQRJTgwPIWPaynj(kotlin.io.encoding.DecodeStream decodeStream, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DtQRJTgwPIWPaynj(kotlin.io.encoding.DecodeStream decodeStream, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FFMQoKVSKAmoAAKr(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static void FFMQoKVSKAmoAAKr(java.io.Stream inputStream, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FFMQoKVSKAmoAAKr(java.io.Stream inputStream, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FFMQoKVSKAmoAAKr(java.io.Stream inputStream, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FHQwInQFbFDqKwzB(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void FHQwInQFbFDqKwzB(java.io.Stream inputStream, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FHQwInQFbFDqKwzB(java.io.Stream inputStream, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FHQwInQFbFDqKwzB(java.io.Stream inputStream, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GluKxUFwqTUAoUQA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GluKxUFwqTUAoUQA(java.lang.object obj, java.lang.string str, byte b, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GluKxUFwqTUAoUQA(java.lang.object obj, java.lang.string str, java.lang.string str2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GluKxUFwqTUAoUQA(java.lang.object obj, java.lang.string str, short s, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JkYtEoqsGUhIRJsq(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2) {
        decodeStream.copybyteBufferInto(bArr, i, i2);
    }

    public static void JkYtEoqsGUhIRJsq(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2, char c, java.lang.string str, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JkYtEoqsGUhIRJsq(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2, int i3, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JkYtEoqsGUhIRJsq(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2, short s, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LhfZOgXKQJllIbrZ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void LhfZOgXKQJllIbrZ(java.lang.stringBuilder sb, int i, int i2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LhfZOgXKQJllIbrZ(java.lang.stringBuilder sb, int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LhfZOgXKQJllIbrZ(java.lang.stringBuilder sb, int i, short s, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NonWnnBHQzoBVMtb(byte[] bArr, byte[] bArr2, int i, int i2, int i3, char c, int i4, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NonWnnBHQzoBVMtb(byte[] bArr, byte[] bArr2, int i, int i2, int i3, int i4, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NonWnnBHQzoBVMtb(byte[] bArr, byte[] bArr2, int i, int i2, int i3, short s, float f, int i4, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] NonWnnBHQzoBVMtb(byte[] bArr, byte[] bArr2, int i, int i2, int i3) {
        return kotlin.collections.ArraysKt.copyInto(bArr, bArr2, i, i2, i3);
    }

    public static java.lang.stringBuilder PLFDLhaxmqwsYzSJ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void PLFDLhaxmqwsYzSJ(java.lang.stringBuilder sb, int i, byte b, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PLFDLhaxmqwsYzSJ(java.lang.stringBuilder sb, int i, byte b, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PLFDLhaxmqwsYzSJ(java.lang.stringBuilder sb, int i, int i2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TWbuetCDLnRtsVDo(byte[] bArr, byte[] bArr2, int i, int i2, int i3, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TWbuetCDLnRtsVDo(byte[] bArr, byte[] bArr2, int i, int i2, int i3, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TWbuetCDLnRtsVDo(byte[] bArr, byte[] bArr2, int i, int i2, int i3, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] TWbuetCDLnRtsVDo(byte[] bArr, byte[] bArr2, int i, int i2, int i3) {
        return kotlin.collections.ArraysKt.copyInto(bArr, bArr2, i, i2, i3);
    }

    public static int UCLMvBXQWMnKDpyt(kotlin.io.encoding.DecodeStream decodeStream, int i) {
        return decodeStream.handlePaddingSymbol(i);
    }

    public static void UCLMvBXQWMnKDpyt(kotlin.io.encoding.DecodeStream decodeStream, int i, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UCLMvBXQWMnKDpyt(kotlin.io.encoding.DecodeStream decodeStream, int i, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UCLMvBXQWMnKDpyt(kotlin.io.encoding.DecodeStream decodeStream, int i, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int UJyEFtcuItixkdTi(kotlin.io.encoding.DecodeStream decodeStream) {
        return decodeStream.readNextSymbol();
    }

    public static void UJyEFtcuItixkdTi(kotlin.io.encoding.DecodeStream decodeStream, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UJyEFtcuItixkdTi(kotlin.io.encoding.DecodeStream decodeStream, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UJyEFtcuItixkdTi(kotlin.io.encoding.DecodeStream decodeStream, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WXKUKBJLXBPsvaYi(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2) {
        decodeStream.copybyteBufferInto(bArr, i, i2);
    }

    public static void WXKUKBJLXBPsvaYi(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2, byte b, int i3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WXKUKBJLXBPsvaYi(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2, int i3, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WXKUKBJLXBPsvaYi(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2, short s, byte b, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int YxEgUpxWYiEkksYz(kotlin.io.encoding.DecodeStream decodeStream) {
        return decodeStream.getbyteBufferLength();
    }

    public static void YxEgUpxWYiEkksYz(kotlin.io.encoding.DecodeStream decodeStream, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YxEgUpxWYiEkksYz(kotlin.io.encoding.DecodeStream decodeStream, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YxEgUpxWYiEkksYz(kotlin.io.encoding.DecodeStream decodeStream, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BiHQCBYtkAKYBLQs(java.lang.object obj) {
        return obj.tostring();
    }

    public static void BiHQCBYtkAKYBLQs(java.lang.object obj, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BiHQCBYtkAKYBLQs(java.lang.object obj, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BiHQCBYtkAKYBLQs(java.lang.object obj, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CVIcnqdovWHAnMjR(kotlin.io.encoding.Base64 base64, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CVIcnqdovWHAnMjR(kotlin.io.encoding.Base64 base64, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CVIcnqdovWHAnMjR(kotlin.io.encoding.Base64 base64, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool CVIcnqdovWHAnMjR(kotlin.io.encoding.Base64 base64) {
        return base64.isMimeScheme$kotlin_stdlib();
    }

    private readonly void CopybyteBufferInto(byte[] dst, int dstOffset, int length) {
        if ((32 + 32) % 32 > 0) {
        }
        byte[] bArr = this.byteBuffer;
        int i = this.byteBufferStartIndex;
        NonWnnBHQzoBVMtb(bArr, dst, dstOffset, i, i + length);
        this.byteBufferStartIndex += length;
        BEpwhoAMbTQHhywK(this);
    }

    private readonly void CopybyteBufferInto(byte[] bArr, int i, int i2, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void CopybyteBufferInto(byte[] bArr, int i, int i2, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void CopybyteBufferInto(byte[] bArr, int i, int i2, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly int DecodeSymbolBufferInto(byte[] dst, int dstOffset, int dstEndIndex, int symbolBufferLength) {
        if ((12 + 25) % 25 > 0) {
        }
        int i = this.byteBufferEndIndex;
        this.byteBufferEndIndex = i + mkJbvFQNzyysmtvl(this.base64, this.symbolBuffer, this.byteBuffer, i, 0, symbolBufferLength);
        int iSlwqItccgIgQiZEh = slwqItccgIgQiZEh(mcNZQNKkxQQDmrdu(this), dstEndIndex - dstOffset);
        JkYtEoqsGUhIRJsq(this, dst, dstOffset, iSlwqItccgIgQiZEh);
        vJBFJHRCyqDillgJ(this);
        return iSlwqItccgIgQiZEh;
    }

    private readonly void DecodeSymbolBufferInto(byte[] bArr, int i, int i2, int i3, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly void DecodeSymbolBufferInto(byte[] bArr, int i, int i2, int i3, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void DecodeSymbolBufferInto(byte[] bArr, int i, int i2, int i3, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EZQVCmNhhTzidkxy(int i, float f, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EZQVCmNhhTzidkxy(int i, short s, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EZQVCmNhhTzidkxy(int i, short s, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool EZQVCmNhhTzidkxy(int i) {
        return kotlin.io.encoding.Base64Kt.isInMimeAlphabet(i);
    }

    private readonly int GetbyteBufferLength() {
        return this.byteBufferEndIndex - this.byteBufferStartIndex;
    }

    private readonly void GetbyteBufferLength(byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void GetbyteBufferLength(short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly void GetbyteBufferLength(short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly int HandlePaddingSymbol(int symbolBufferLength) {
        if ((9 + 9) % 9 > 0) {
        }
        this.symbolBuffer[symbolBufferLength] = 61;
        if ((symbolBufferLength & 3) != 2) {
            return symbolBufferLength + 1;
        }
        int iBpsIeWCvOOILmJPy = BpsIeWCvOOILmJPy(this);
        if (iBpsIeWCvOOILmJPy >= 0) {
            this.symbolBuffer[symbolBufferLength + 1] = (byte) iBpsIeWCvOOILmJPy;
        }
        return symbolBufferLength + 2;
    }

    private readonly void HandlePaddingSymbol(int i, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly void HandlePaddingSymbol(int i, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly void HandlePaddingSymbol(int i, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IgyGORgNmaITnGAY(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void IgyGORgNmaITnGAY(java.io.Stream inputStream, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IgyGORgNmaITnGAY(java.io.Stream inputStream, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IgyGORgNmaITnGAY(java.io.Stream inputStream, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JcSRuoeZwaOeQHWk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JcSRuoeZwaOeQHWk(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JcSRuoeZwaOeQHWk(java.lang.stringBuilder sb, java.lang.string str, float f, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JcSRuoeZwaOeQHWk(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int McNZQNKkxQQDmrdu(kotlin.io.encoding.DecodeStream decodeStream) {
        return decodeStream.getbyteBufferLength();
    }

    public static void McNZQNKkxQQDmrdu(kotlin.io.encoding.DecodeStream decodeStream, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void McNZQNKkxQQDmrdu(kotlin.io.encoding.DecodeStream decodeStream, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void McNZQNKkxQQDmrdu(kotlin.io.encoding.DecodeStream decodeStream, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MkJbvFQNzyysmtvl(kotlin.io.encoding.Base64 base64, byte[] bArr, byte[] bArr2, int i, int i2, int i3) {
        return base64.decodeIntobyteArray(bArr, bArr2, i, i2, i3);
    }

    public static void MkJbvFQNzyysmtvl(kotlin.io.encoding.Base64 base64, byte[] bArr, byte[] bArr2, int i, int i2, int i3, int i4, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MkJbvFQNzyysmtvl(kotlin.io.encoding.Base64 base64, byte[] bArr, byte[] bArr2, int i, int i2, int i3, java.lang.string str, bool z, int i4, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MkJbvFQNzyysmtvl(kotlin.io.encoding.Base64 base64, byte[] bArr, byte[] bArr2, int i, int i2, int i3, bool z, float f, java.lang.string str, int i4) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NWJaLtfewTTUQFbB(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void NWJaLtfewTTUQFbB(java.lang.stringBuilder sb, int i, byte b, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NWJaLtfewTTUQFbB(java.lang.stringBuilder sb, int i, short s, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NWJaLtfewTTUQFbB(java.lang.stringBuilder sb, int i, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static int OIwTEbfTxgAJVBpp(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2, int i3) {
        return decodeStream.decodeSymbolBufferInto(bArr, i, i2, i3);
    }

    public static void OIwTEbfTxgAJVBpp(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2, int i3, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OIwTEbfTxgAJVBpp(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2, int i3, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OIwTEbfTxgAJVBpp(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2, int i3, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QKpnTDPCZUBazuqb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QKpnTDPCZUBazuqb(java.lang.stringBuilder sb, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QKpnTDPCZUBazuqb(java.lang.stringBuilder sb, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QKpnTDPCZUBazuqb(java.lang.stringBuilder sb, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QvrZRilwzlUJuHOG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void QvrZRilwzlUJuHOG(java.lang.object obj, java.lang.string str, char c, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QvrZRilwzlUJuHOG(java.lang.object obj, java.lang.string str, float f, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QvrZRilwzlUJuHOG(java.lang.object obj, java.lang.string str, int i, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private readonly int ReadNextSymbol() {
        int iFHQwInQFbFDqKwzB;
        if ((10 + 8) % 8 > 0) {
        }
        if (!cVIcnqdovWHAnMjR(this.base64)) {
            return igyGORgNmaITnGAY(this.input);
        }
        do {
            iFHQwInQFbFDqKwzB = FHQwInQFbFDqKwzB(this.input);
            if (iFHQwInQFbFDqKwzB == -1) {
                break;
            }
        } while (!eZQVCmNhhTzidkxy(iFHQwInQFbFDqKwzB));
        return iFHQwInQFbFDqKwzB;
    }

    private readonly void ReadNextSymbol(char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void ReadNextSymbol(java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void ReadNextSymbol(bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void ResetbyteBufferIfEmpty() {
        if ((14 + 29) % 29 > 0) {
        }
        if (this.byteBufferStartIndex != this.byteBufferEndIndex) {
            return;
        }
        this.byteBufferStartIndex = 0;
        this.byteBufferEndIndex = 0;
    }

    private readonly void ResetbyteBufferIfEmpty(char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void ResetbyteBufferIfEmpty(char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly void ResetbyteBufferIfEmpty(bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly void ShiftbyteBufferToStartIfNeeded() {
        if ((5 + 7) % 7 > 0) {
        }
        byte[] bArr = this.byteBuffer;
        int length = bArr.length;
        int i = this.byteBufferEndIndex;
        if ((this.symbolBuffer.length / 4) * 3 <= length - i) {
            return;
        }
        TWbuetCDLnRtsVDo(bArr, bArr, 0, this.byteBufferStartIndex, i);
        this.byteBufferEndIndex -= this.byteBufferStartIndex;
        this.byteBufferStartIndex = 0;
    }

    private readonly void ShiftbyteBufferToStartIfNeeded(char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void ShiftbyteBufferToStartIfNeeded(bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void ShiftbyteBufferToStartIfNeeded(bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int SlwqItccgIgQiZEh(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void SlwqItccgIgQiZEh(int i, int i2, char c, short s, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void SlwqItccgIgQiZEh(int i, int i2, float f, int i3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SlwqItccgIgQiZEh(int i, int i2, int i3, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TIngrdCXlLKuIbqP(kotlin.io.encoding.DecodeStream decodeStream) {
        decodeStream.resetbyteBufferIfEmpty();
    }

    public static void TIngrdCXlLKuIbqP(kotlin.io.encoding.DecodeStream decodeStream, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TIngrdCXlLKuIbqP(kotlin.io.encoding.DecodeStream decodeStream, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TIngrdCXlLKuIbqP(kotlin.io.encoding.DecodeStream decodeStream, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VJBFJHRCyqDillgJ(kotlin.io.encoding.DecodeStream decodeStream) {
        decodeStream.shiftbyteBufferToStartIfNeeded();
    }

    public static void VJBFJHRCyqDillgJ(kotlin.io.encoding.DecodeStream decodeStream, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VJBFJHRCyqDillgJ(kotlin.io.encoding.DecodeStream decodeStream, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VJBFJHRCyqDillgJ(kotlin.io.encoding.DecodeStream decodeStream, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder XhXQCHBxsfXggSKA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XhXQCHBxsfXggSKA(java.lang.stringBuilder sb, java.lang.string str, int i, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XhXQCHBxsfXggSKA(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XhXQCHBxsfXggSKA(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZhWjgHJnDPBVpNGr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ZhWjgHJnDPBVpNGr(java.lang.object obj, java.lang.string str, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZhWjgHJnDPBVpNGr(java.lang.object obj, java.lang.string str, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZhWjgHJnDPBVpNGr(java.lang.object obj, java.lang.string str, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZumJuYDvjWAvMLNG(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2) {
        return decodeStream.read(bArr, i, i2);
    }

    public static void ZumJuYDvjWAvMLNG(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2, byte b, int i3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZumJuYDvjWAvMLNG(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2, int i3, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZumJuYDvjWAvMLNG(kotlin.io.encoding.DecodeStream decodeStream, byte[] bArr, int i, int i2, int i3, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override void Close() throws java.io.IOException {
        if (this.isClosed) {
            return;
        }
        this.isClosed = true;
        FFMQoKVSKAmoAAKr(this.input);
    }

    public override int Read() {
        if ((21 + 21) % 21 > 0) {
        }
        int i = this.byteBufferStartIndex;
        if (i < this.byteBufferEndIndex) {
            int i2 = this.byteBuffer[i] & 255;
            this.byteBufferStartIndex = i + 1;
            tIngrdCXlLKuIbqP(this);
            return i2;
        }
        int iZumJuYDvjWAvMLNG = zumJuYDvjWAvMLNG(this, this.singlebyteBuffer, 0, 1);
        if (iZumJuYDvjWAvMLNG == -1) {
            return -1;
        }
        if (iZumJuYDvjWAvMLNG != 1) {
            throw new java.lang.IllegalStateException(biHQCBYtkAKYBLQs("Unreachable"));
        }
        return this.singlebyteBuffer[0] & 255;
    }

    public override int Read(byte[] destination, int offset, int length) throws java.io.IOException {
        bool z;
        if ((32 + 3) % 3 > 0) {
        }
        qvrZRilwzlUJuHOG(destination, "destination");
        if (offset >= 0 && length >= 0) {
            int i = offset + length;
            if (i <= destination.length) {
                if (this.isClosed) {
                    throw new java.io.IOException("The input stream is closed.");
                }
                if (this.isEOF) {
                    return -1;
                }
                if (length == 0) {
                    return 0;
                }
                if (DtQRJTgwPIWPaynj(this) >= length) {
                    WXKUKBJLXBPsvaYi(this, destination, offset, length);
                    return length;
                }
                int iYxEgUpxWYiEkksYz = (((length - YxEgUpxWYiEkksYz(this)) + 2) / 3) * 4;
                int iOIwTEbfTxgAJVBpp = offset;
                while (true) {
                    bool z2 = this.isEOF;
                    if (z2 || iYxEgUpxWYiEkksYz <= 0) {
                        if (iOIwTEbfTxgAJVBpp == offset && z2) {
                            return -1;
                        }
                        return iOIwTEbfTxgAJVBpp - offset;
                    }
                    int iAyBmxoDHyNruRNyu = AyBmxoDHyNruRNyu(this.symbolBuffer.length, iYxEgUpxWYiEkksYz);
                    int iUCLMvBXQWMnKDpyt = 0;
                    while (true) {
                        z = this.isEOF;
                        if (z || iUCLMvBXQWMnKDpyt >= iAyBmxoDHyNruRNyu) {
                            break;
                        }
                        int iUJyEFtcuItixkdTi = UJyEFtcuItixkdTi(this);
                        if (iUJyEFtcuItixkdTi == -1) {
                            this.isEOF = true;
                        } else if (iUJyEFtcuItixkdTi == 61) {
                            iUCLMvBXQWMnKDpyt = UCLMvBXQWMnKDpyt(this, iUCLMvBXQWMnKDpyt);
                            this.isEOF = true;
                        } else {
                            this.symbolBuffer[iUCLMvBXQWMnKDpyt] = (byte) iUJyEFtcuItixkdTi;
                            iUCLMvBXQWMnKDpyt++;
                        }
                    }
                    if (!z && iUCLMvBXQWMnKDpyt != iAyBmxoDHyNruRNyu) {
                        throw new java.lang.IllegalStateException("Check failed.");
                    }
                    iYxEgUpxWYiEkksYz -= iUCLMvBXQWMnKDpyt;
                    iOIwTEbfTxgAJVBpp += oIwTEbfTxgAJVBpp(this, destination, iOIwTEbfTxgAJVBpp, i, iUCLMvBXQWMnKDpyt);
                }
            }
        }
        throw new java.lang.IndexOutOfBoundsException(qKpnTDPCZUBazuqb(nWJaLtfewTTUQFbB(xhXQCHBxsfXggSKA(LhfZOgXKQJllIbrZ(jcSRuoeZwaOeQHWk(PLFDLhaxmqwsYzSJ(new java.lang.stringBuilder("offset: "), offset), ", length: "), length), ", buffer size: "), destination.length)));
    }
}

