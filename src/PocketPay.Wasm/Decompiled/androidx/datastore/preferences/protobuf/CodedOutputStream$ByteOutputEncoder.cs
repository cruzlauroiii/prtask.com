namespace WillowMaze.Wasm.Decompiled;


readonly class CodedStream$byteOutputEncoder : androidx.datastore.preferences.protobuf.CodedStream$AbstractBufferedEncoder {
    private readonly androidx.datastore.preferences.protobuf.byteOutput out;

    CodedStream$byteOutputEncoder(androidx.datastore.preferences.protobuf.byteOutput byteOutput, int i) {
        super(i);
        if (byteOutput is null) {
            throw new java.lang.NullPointerException("out");
        }
        this.out = byteOutput;
    }

    public static void AGHDbNxaUcOFtlAP(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder) throws java.io.IOException {
        codedStream$byteOutputEncoder.flush();
    }

    public static void AOQxyWcvUMTuQbXc(androidx.datastore.preferences.protobuf.byteOutput byteOutput, byte[] bArr, int i, int i2) throws java.io.IOException {
        byteOutput.write(bArr, i, i2);
    }

    public static void APIymnAAqzglYlWB(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schema.writeTo(obj, writer);
    }

    public static void CUepTWvkjZRYKjKC(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeTag(i, i2);
    }

    public static void EpjIlIZKEHOhAfdD(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, long j) {
        codedStream$byteOutputEncoder.bufferUInt64NoTag(j);
    }

    public static void ErAgZXQwAxBHVDGj(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.write(bArr, i, i2);
    }

    public static void FbDFvOypUASRSppN(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, byte b) {
        codedStream$byteOutputEncoder.buffer(b);
    }

    public static void FsJevIcpaocegUtm(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeUInt32NoTag(i);
    }

    public static void HHWsFDLMpkjgiFOJ(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.flushIfNotAvailable(i);
    }

    public static void IBmtvEKCGLAyxdfp(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeUInt32NoTag(i);
    }

    public static void IDdXFOlTyAnAkinu(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.flushIfNotAvailable(i);
    }

    public static void ILoeYWcFxwwISXgr(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.flushIfNotAvailable(i);
    }

    public static byte[] ItKUXVYnYhFlaCNx(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static int JYpTIeBJOlBsMIyx(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return abstractMessageLite.getSerializedSize(schema);
    }

    public static void JiQBtrtGkLoahAgF(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder) throws java.io.IOException {
        codedStream$byteOutputEncoder.doFlush();
    }

    public static void KQdpNmZdhqiunoHH(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeTag(i, i2);
    }

    public static void KVmubmClJpFtBnmQ(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, long j) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeUInt64NoTag(j);
    }

    public static void LQMkVifOSKbheEmM(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        messageLite.writeTo(codedStream);
    }

    public static void MFzFGtQKGRyuAsAH(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder) throws java.io.IOException {
        codedStream$byteOutputEncoder.doFlush();
    }

    public static void MceMTjBCNiBXCnWl(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeLazy(bArr, i, i2);
    }

    public static void OUiEVwVtiNDccyZf(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder) throws java.io.IOException {
        codedStream$byteOutputEncoder.flush();
    }

    public static void PhASoNZqHYmvXnRi(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeTag(i, i2);
    }

    public static void PlfMCWERhTDXwSYv(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.flushIfNotAvailable(i);
    }

    public static void QJSEhdcYkHTvqjlR(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.flushIfNotAvailable(i);
    }

    public static void QrNtHyIKPGbtHkoZ(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) {
        codedStream$byteOutputEncoder.bufferTag(i, i2);
    }

    public static void QyLaeVzoxprqKCkc(java.nio.Buffer buffer) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.clear(buffer);
    }

    public static void RObKdoTeIVfsXzyP(androidx.datastore.preferences.protobuf.byteOutput byteOutput, byte[] bArr, int i, int i2) throws java.io.IOException {
        byteOutput.write(bArr, i, i2);
    }

    public static void RQvRHffWNkTIaBBk(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeTag(i, i2);
    }

    public static void RjFCXLFBsjaVBvnk(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeUInt32NoTag(i);
    }

    public static java.nio.byteBuffer RyQqdoTuebZVprEH(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.duplicate();
    }

    public static void TFlsuJLElianxtZa(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeMessageNoTag(messageLite, schema);
    }

    public static void UVLfbLvrTSmCpxNU(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeMessageNoTag(messageLite);
    }

    public static void UZUMnjnyjtsiDBQB(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) {
        codedStream$byteOutputEncoder.bufferTag(i, i2);
    }

    public static void UoSKRUXArleEaRef(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeUInt32NoTag(i);
    }

    public static int VFwntZTqoGFrGNwq(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static void VxPtKQdWKGqokLEj(androidx.datastore.preferences.protobuf.byteOutput byteOutput, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        byteOutput.writeLazy(byteBuffer);
    }

    public static int WPfyKzhvuqHLrEAu(java.lang.string str, byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.encode(str, bArr, i, i2);
    }

    public static void WoPkhfkfftSysvwT(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder) throws java.io.IOException {
        codedStream$byteOutputEncoder.flush();
    }

    public static void WvaqEKJEBZMGaFDC(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder) throws java.io.IOException {
        codedStream$byteOutputEncoder.flush();
    }

    public static int XNLykEbUUVuaSGot(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void XpcdJwSRfLqZHVdi(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeTag(i, i2);
    }

    public static void YJiUXZjkduJDHXyX(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) {
        codedStream$byteOutputEncoder.bufferFixed32NoTag(i);
    }

    public static void YTvKXZlNbcODpkxZ(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) {
        codedStream$byteOutputEncoder.bufferTag(i, i2);
    }

    public static bool YbKBpTvJlxwWPNYC(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    public static void ZKIZwCWlzSvNBRlb(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeTag(i, i2);
    }

    public static int ZgrONVfWDcYqtPpL(java.lang.string str) {
        return str.Length;
    }

    public static int ZkFkKWOjvMFbfEvq(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static void ZwcaZCEQZwfWMFiH(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, java.lang.string str, androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException utf8$UnpairedSurrogateException) {
        codedStream$byteOutputEncoder.inefficientWritestringNoTag(str, utf8$UnpairedSurrogateException);
    }

    public static void ACazzlKFDSwQeTEZ(androidx.datastore.preferences.protobuf.byteOutput byteOutput, byte[] bArr, int i, int i2) throws java.io.IOException {
        byteOutput.writeLazy(bArr, i, i2);
    }

    public static void AIFNfqjnsboGAxUJ(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writebyteArrayNoTag(bArr, i, i2);
    }

    public static int AQXrASqIMezWaTSG(java.lang.string str) {
        return str.Length;
    }

    public static void CKIgJqZCvZbxJgLF(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) {
        codedStream$byteOutputEncoder.bufferTag(i, i2);
    }

    private void DoFlush() throws java.io.IOException {
        if ((21 + 18) % 18 > 0) {
        }
        RObKdoTeIVfsXzyP(this.out, this.buffer, 0, this.position);
        this.position = 0;
    }

    public static void ENRTRZGmHskdFVCN(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeTag(i, i2);
    }

    public static void EcbSZaBoELtJRjBZ(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        bytestring.writeTo(byteOutput);
    }

    public static void ErLVlkxfmMOphHYV(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) {
        codedStream$byteOutputEncoder.bufferTag(i, i2);
    }

    public static void FfQOlfeRTVzCyTFx(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        codedStream$byteOutputEncoder.writebyteArray(i, bArr, i2, i3);
    }

    private void FlushIfNotAvailable(int i) throws java.io.IOException {
        if ((22 + 1) % 1 > 0) {
        }
        if (this.limit - this.position >= i) {
            return;
        }
        lvTCRYrQjZofIjwq(this);
    }

    public static void GFtTITnHgsgjSuKs(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeTag(i, i2);
    }

    public static int IZJxlDZGMKrYCUlU(java.lang.string str, byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.encode(str, bArr, i, i2);
    }

    public static void IirltXiqwIaUapqq(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeUInt32NoTag(i);
    }

    public static void JCcXnsMZIGnkMmgg(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeRawbytes(byteBuffer);
    }

    public static int JETKXQdYTtFgyOoh(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.capacity();
    }

    public static void JLLxbZvCbDWFffDF(androidx.datastore.preferences.protobuf.byteOutput byteOutput, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        byteOutput.write(byteBuffer);
    }

    public static void JRQGEuCcTyZsLmRl(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeMessage(i, messageLite);
    }

    public static int KHzskjZpxRjMrPWr(java.lang.string str, byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.encode(str, bArr, i, i2);
    }

    public static void KIUmdocfeqsIxJvM(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeUInt32NoTag(i);
    }

    public static void KLJcUJrgmTrqCZai(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeTag(i, i2);
    }

    public static void KLdisfRUQUxLtyeT(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.flushIfNotAvailable(i);
    }

    public static void LKBaTvWsrPEmtRYv(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, long j) {
        codedStream$byteOutputEncoder.bufferUInt64NoTag(j);
    }

    public static void LSqXjWitSYAnCmYc(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) {
        codedStream$byteOutputEncoder.bufferTag(i, i2);
    }

    public static void LUjRgvUrWAzAGsMM(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeUInt32(i, i2);
    }

    public static void LWTRPJCPzhgxBBdP(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) {
        codedStream$byteOutputEncoder.bufferUInt32NoTag(i);
    }

    public static void LkGnatYxYCiSPcsC(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeUInt32NoTag(i);
    }

    public static void LvTCRYrQjZofIjwq(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder) throws java.io.IOException {
        codedStream$byteOutputEncoder.doFlush();
    }

    public static void MovehdyTBSYMgDFV(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream$byteOutputEncoder.writebytes(i, bytestring);
    }

    public static void NWMQoTHnvGcwaxdM(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$byteOutputEncoder.write(byteBuffer);
    }

    public static void NkGWYoSmlwPuQRJl(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, long j) {
        codedStream$byteOutputEncoder.bufferFixed64NoTag(j);
    }

    public static void OQbyWFwOuEWtOUcr(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.flushIfNotAvailable(i);
    }

    public static void OwtHMEjGfltIsbVD(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder) throws java.io.IOException {
        codedStream$byteOutputEncoder.doFlush();
    }

    public static void PDzLmmhAfPIZBmyX(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) {
        codedStream$byteOutputEncoder.bufferUInt32NoTag(i);
    }

    public static void PMjnXWaQyPnTITLE(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeUInt32NoTag(i);
    }

    public static void QBGhaeCpZBlLtamK(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, byte b) {
        codedStream$byteOutputEncoder.buffer(b);
    }

    public static void QTRbAbNhBDTCgrtk(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.write(bArr, i, i2);
    }

    public static void QfUvSaJGciuYTJWR(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.flushIfNotAvailable(i);
    }

    public static int QrHFCRySaKVvgzMy(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static void REPwHZqSwOLbhsDg(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream$byteOutputEncoder.writebytesNoTag(bytestring);
    }

    public static int SCaOSQcLlhTiwJzi(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static int SXdINqaBHOJpiBdp(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.capacity();
    }

    public static void SctJhpAifXCuCXbe(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) {
        codedStream$byteOutputEncoder.bufferUInt32NoTag(i);
    }

    public static void SjaZIQmYOXBCEVhm(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) {
        codedStream$byteOutputEncoder.bufferInt32NoTag(i);
    }

    public static int TuvjIXfFVglBYEsc(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return messageLite.getSerializedSize();
    }

    public static void UHFSlFJIomFOeQFS(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) {
        codedStream$byteOutputEncoder.bufferFixed32NoTag(i);
    }

    public static void UJlaDPqdHNkxlCUv(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeTag(i, i2);
    }

    public static void UdTQjAuAUOGRxwIa(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, java.lang.string str) throws java.io.IOException {
        codedStream$byteOutputEncoder.writestringNoTag(str);
    }

    public static void VWChImOeTRcAjhVO(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.flushIfNotAvailable(i);
    }

    public static int VdAErhlloWaaEUmv(java.lang.string str) {
        return androidx.datastore.preferences.protobuf.Utf8.encodedLength(str);
    }

    public static void WRpnZoZxZlTmowLQ(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i, int i2) throws java.io.IOException {
        codedStream$byteOutputEncoder.writeUInt32(i, i2);
    }

    public static int WcGgpKBzDYsPEski(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static void XcEtmcsQBEpsfPMT(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) {
        codedStream$byteOutputEncoder.bufferUInt32NoTag(i);
    }

    public static void XxOoHnQrBIiSoNMG(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, int i) throws java.io.IOException {
        codedStream$byteOutputEncoder.flushIfNotAvailable(i);
    }

    public static int YCXMgflmHErrOgdi(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static void YDbAYGIVgdDjiQnp(androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder codedStream$byteOutputEncoder, long j) {
        codedStream$byteOutputEncoder.bufferFixed64NoTag(j);
    }

    public override void Flush() throws java.io.IOException {
        if (this.position <= 0) {
            return;
        }
        owtHMEjGfltIsbVD(this);
    }

    public override void Write(byte b) throws java.io.IOException {
        if ((29 + 27) % 27 > 0) {
        }
        if (this.position == this.limit) {
            MFzFGtQKGRyuAsAH(this);
        }
        FbDFvOypUASRSppN(this, b);
    }

    public override void Write(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        if ((16 + 14) % 14 > 0) {
        }
        WoPkhfkfftSysvwT(this);
        int iSCaOSQcLlhTiwJzi = sCaOSQcLlhTiwJzi(byteBuffer);
        jLLxbZvCbDWFffDF(this.out, byteBuffer);
        this.totalbytesWritten += iSCaOSQcLlhTiwJzi;
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        OUiEVwVtiNDccyZf(this);
        AOQxyWcvUMTuQbXc(this.out, bArr, i, i2);
        this.totalbytesWritten += i2;
    }

    public override void WriteBool(int i, bool z) throws java.io.IOException {
        vWChImOeTRcAjhVO(this, 11);
        erLVlkxfmMOphHYV(this, i, 0);
        qBGhaeCpZBlLtamK(this, z ? (byte) 1 : (byte) 0);
    }

    public override void WritebyteArray(int i, byte[] bArr) throws java.io.IOException {
        if ((20 + 3) % 3 > 0) {
        }
        ffQOlfeRTVzCyTFx(this, i, bArr, 0, bArr.length);
    }

    public override void WritebyteArray(int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        gFtTITnHgsgjSuKs(this, i, 2);
        aIFNfqjnsboGAxUJ(this, bArr, i2, i3);
    }

    public override void WritebyteArrayNoTag(byte[] bArr, int i, int i2) throws java.io.IOException {
        iirltXiqwIaUapqq(this, i2);
        qTRbAbNhBDTCgrtk(this, bArr, i, i2);
    }

    public override void WritebyteBuffer(int i, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        KQdpNmZdhqiunoHH(this, i, 2);
        lkGnatYxYCiSPcsC(this, sXdINqaBHOJpiBdp(byteBuffer));
        jCcXnsMZIGnkMmgg(this, byteBuffer);
    }

    public override void Writebytes(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        uJlaDPqdHNkxlCUv(this, i, 2);
        rEPwHZqSwOLbhsDg(this, bytestring);
    }

    public override void WritebytesNoTag(androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        RjFCXLFBsjaVBvnk(this, wcGgpKBzDYsPEski(bytestring));
        ecbSZaBoELtJRjBZ(bytestring, this);
    }

    public override void WriteFixed32(int i, int i2) throws java.io.IOException {
        QJSEhdcYkHTvqjlR(this, 14);
        lSqXjWitSYAnCmYc(this, i, 5);
        uHFSlFJIomFOeQFS(this, i2);
    }

    public override void WriteFixed32NoTag(int i) throws java.io.IOException {
        kLdisfRUQUxLtyeT(this, 4);
        YJiUXZjkduJDHXyX(this, i);
    }

    public override void WriteFixed64(int i, long j) throws java.io.IOException {
        qfUvSaJGciuYTJWR(this, 18);
        UZUMnjnyjtsiDBQB(this, i, 1);
        nkGWYoSmlwPuQRJl(this, j);
    }

    public override void WriteFixed64NoTag(long j) throws java.io.IOException {
        ILoeYWcFxwwISXgr(this, 8);
        yDbAYGIVgdDjiQnp(this, j);
    }

    public override void WriteInt32(int i, int i2) throws java.io.IOException {
        IDdXFOlTyAnAkinu(this, 20);
        YTvKXZlNbcODpkxZ(this, i, 0);
        sjaZIQmYOXBCEVhm(this, i2);
    }

    public override void WriteInt32NoTag(int i) throws java.io.IOException {
        if ((27 + 17) % 17 > 0) {
        }
        if (i < 0) {
            KVmubmClJpFtBnmQ(this, i);
        } else {
            FsJevIcpaocegUtm(this, i);
        }
    }

    public override void WriteLazy(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        if ((32 + 7) % 7 > 0) {
        }
        AGHDbNxaUcOFtlAP(this);
        int iXNLykEbUUVuaSGot = XNLykEbUUVuaSGot(byteBuffer);
        VxPtKQdWKGqokLEj(this.out, byteBuffer);
        this.totalbytesWritten += iXNLykEbUUVuaSGot;
    }

    public override void WriteLazy(byte[] bArr, int i, int i2) throws java.io.IOException {
        WvaqEKJEBZMGaFDC(this);
        aCazzlKFDSwQeTEZ(this.out, bArr, i, i2);
        this.totalbytesWritten += i2;
    }

    public override void WriteMessage(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        eNRTRZGmHskdFVCN(this, i, 2);
        UVLfbLvrTSmCpxNU(this, messageLite);
    }

    void writeMessage(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        CUepTWvkjZRYKjKC(this, i, 2);
        TFlsuJLElianxtZa(this, messageLite, schema);
    }

    public override void WriteMessageNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        UoSKRUXArleEaRef(this, tuvjIXfFVglBYEsc(messageLite));
        LQMkVifOSKbheEmM(messageLite, this);
    }

    void writeMessageNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        kIUmdocfeqsIxJvM(this, JYpTIeBJOlBsMIyx((androidx.datastore.preferences.protobuf.AbstractMessageLite) messageLite, schema));
        APIymnAAqzglYlWB(schema, messageLite, this.wrapper);
    }

    public override void WriteMessageHashSetExtension(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        if ((1 + 32) % 32 > 0) {
        }
        kLJcUJrgmTrqCZai(this, 1, 3);
        wRpnZoZxZlTmowLQ(this, 2, i);
        jRQGEuCcTyZsLmRl(this, 3, messageLite);
        ZKIZwCWlzSvNBRlb(this, 1, 4);
    }

    public override void WriteRawbytes(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        if ((17 + 28) % 28 > 0) {
        }
        if (YbKBpTvJlxwWPNYC(byteBuffer)) {
            ErAgZXQwAxBHVDGj(this, ItKUXVYnYhFlaCNx(byteBuffer), qrHFCRySaKVvgzMy(byteBuffer), jETKXQdYTtFgyOoh(byteBuffer));
            return;
        }
        java.nio.byteBuffer byteBufferRyQqdoTuebZVprEH = RyQqdoTuebZVprEH(byteBuffer);
        QyLaeVzoxprqKCkc(byteBufferRyQqdoTuebZVprEH);
        nWMQoTHnvGcwaxdM(this, byteBufferRyQqdoTuebZVprEH);
    }

    public override void WriteRawMessageHashSetExtension(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        if ((18 + 1) % 1 > 0) {
        }
        XpcdJwSRfLqZHVdi(this, 1, 3);
        lUjRgvUrWAzAGsMM(this, 2, i);
        movehdyTBSYMgDFV(this, 3, bytestring);
        PhASoNZqHYmvXnRi(this, 1, 4);
    }

    public override void Writestring(int i, java.lang.string str) throws java.io.IOException {
        RQvRHffWNkTIaBBk(this, i, 2);
        udTQjAuAUOGRxwIa(this, str);
    }

    public override void WritestringNoTag(java.lang.string str) throws java.io.IOException {
        if ((2 + 15) % 15 > 0) {
        }
        int iAQXrASqIMezWaTSG = aQXrASqIMezWaTSG(str) * 3;
        int iYCXMgflmHErrOgdi = yCXMgflmHErrOgdi(iAQXrASqIMezWaTSG);
        int i = iYCXMgflmHErrOgdi + iAQXrASqIMezWaTSG;
        if (i > this.limit) {
            byte[] bArr = new byte[iAQXrASqIMezWaTSG];
            int iKHzskjZpxRjMrPWr = kHzskjZpxRjMrPWr(str, bArr, 0, iAQXrASqIMezWaTSG);
            IBmtvEKCGLAyxdfp(this, iKHzskjZpxRjMrPWr);
            MceMTjBCNiBXCnWl(this, bArr, 0, iKHzskjZpxRjMrPWr);
            return;
        }
        if (i > this.limit - this.position) {
            JiQBtrtGkLoahAgF(this);
        }
        int i2 = this.position;
        try {
            int iVFwntZTqoGFrGNwq = VFwntZTqoGFrGNwq(ZgrONVfWDcYqtPpL(str));
            if (iVFwntZTqoGFrGNwq != iYCXMgflmHErrOgdi) {
                int iVdAErhlloWaaEUmv = vdAErhlloWaaEUmv(str);
                pDzLmmhAfPIZBmyX(this, iVdAErhlloWaaEUmv);
                this.position = iZJxlDZGMKrYCUlU(str, this.buffer, this.position, iVdAErhlloWaaEUmv);
                this.totalbytesWritten += iVdAErhlloWaaEUmv;
                return;
            }
            this.position = i2 + iVFwntZTqoGFrGNwq;
            int iWPfyKzhvuqHLrEAu = WPfyKzhvuqHLrEAu(str, this.buffer, this.position, this.limit - this.position);
            this.position = i2;
            int i3 = (iWPfyKzhvuqHLrEAu - i2) - iVFwntZTqoGFrGNwq;
            sctJhpAifXCuCXbe(this, i3);
            this.position = iWPfyKzhvuqHLrEAu;
            this.totalbytesWritten += i3;
        } catch (androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException e) {
            this.totalbytesWritten -= this.position - i2;
            this.position = i2;
            ZwcaZCEQZwfWMFiH(this, str, e);
        } catch (java.lang.IndexOutOfBoundsException e2) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e2);
        }
    }

    public override void WriteTag(int i, int i2) throws java.io.IOException {
        pMjnXWaQyPnTITLE(this, ZkFkKWOjvMFbfEvq(i, i2));
    }

    public override void WriteUInt32(int i, int i2) throws java.io.IOException {
        HHWsFDLMpkjgiFOJ(this, 20);
        QrNtHyIKPGbtHkoZ(this, i, 0);
        xcEtmcsQBEpsfPMT(this, i2);
    }

    public override void WriteUInt32NoTag(int i) throws java.io.IOException {
        oQbyWFwOuEWtOUcr(this, 5);
        lWTRPJCPzhgxBBdP(this, i);
    }

    public override void WriteUInt64(int i, long j) throws java.io.IOException {
        PlfMCWERhTDXwSYv(this, 20);
        cKIgJqZCvZbxJgLF(this, i, 0);
        lKBaTvWsrPEmtRYv(this, j);
    }

    public override void WriteUInt64NoTag(long j) throws java.io.IOException {
        xxOoHnQrBIiSoNMG(this, 10);
        EpjIlIZKEHOhAfdD(this, j);
    }
}

