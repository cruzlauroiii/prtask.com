namespace WillowMaze.Wasm.Decompiled;


class CodedStream$ArrayEncoder : androidx.datastore.preferences.protobuf.CodedStream {
    private readonly byte[] buffer;
    private readonly int limit;
    private readonly int offset;
    private int position;

    CodedStream$ArrayEncoder(byte[] bArr, int i, int i2) {
        super(null);
        if ((29 + 31) % 31 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("buffer");
        }
        int i3 = i + i2;
        if ((i | i2 | (bArr.length - i3)) < 0) {
            throw new java.lang.IllegalArgumentException(fbbbdTUsLBvFKroA("Array range is invalid. Buffer.length=%d, offset=%d, length=%d", new java.lang.object[]{LnpbmanJmQfjQrZP(bArr.length), zipQGzRSSdbrsLXF(i), RtygVuqCvxgeHadK(i2)}));
        }
        this.buffer = bArr;
        this.offset = i;
        this.position = i;
        this.limit = i3;
    }

    public static void ANmfoepfUstuQhbS(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt32NoTag(i);
    }

    public static java.lang.int AQduwZQGROuAOZOe(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void AbVYPwJSvaRgaEGn(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static void BPmzjFGPNAfCqGaH(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt32NoTag(i);
    }

    public static void BQlzoLiryfzSktAL(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writebyteArrayNoTag(bArr, i, i2);
    }

    public static java.lang.string BRFxAIXtMlOjXYmb(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void BRpimEYjofNxdauD(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream$ArrayEncoder.writeMessage(i, messageLite);
    }

    public static bool DQEWFyjOvjjKdlzt() {
        return androidx.datastore.preferences.protobuf.CodedStream.access$100();
    }

    public static void DgMwuopnaZhPufXk(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static java.lang.int DygIQUVSsTJLrtKM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int ESSCoESVRhtScxXr(java.lang.string str) {
        return str.Length;
    }

    public static void EqGQYmbyVmXMHBYt(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static java.lang.int FGcJAuuzlrkDcYYi(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void FHbWRmeWfAYZALTL(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schema.writeTo(obj, writer);
    }

    public static void FczZNAOrJpYWAgrx(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, long j) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt64NoTag(j);
    }

    public static java.lang.int GblobSjhOINbJUEl(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string GrEKlzjnWTKDJRsd(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static int HqerTaoxJNkfzUwM(java.lang.string str, byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.encode(str, bArr, i, i2);
    }

    public static java.lang.int JNRLewMjRPSOvatV(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string KQafcDAHldMiRfaQ(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static int KQwmKFURSGtSOcuy(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.capacity();
    }

    public static void KcVXOINBpZunHUUE(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i) throws java.io.IOException {
        codedStream$ArrayEncoder.writeFixed32NoTag(i);
    }

    public static void LgvSNStgfxczppCM(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static java.lang.int LnpbmanJmQfjQrZP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static byte[] MlWDETIFJwiTUycc(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static void NOFzJgEbkDwfLGWx(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static int NzGiQNQrjFMxlUwH(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return messageLite.getSerializedSize();
    }

    public static int OWTeoKLjQbNefPMl(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static java.lang.string OgOkTomcxTQFjVPE(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void PDYOjTJMEEsCXSME(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static java.lang.int PcAElbddToIZTTds(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string QSAYghvWiWUbQAkd(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.int QgsMcTXNCkvlSMtq(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int QvdWmndGQVvkpCds(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder) {
        return codedStream$ArrayEncoder.spaceLeft();
    }

    public static void RDPvLZvIbEpmUsUt(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, java.lang.string str, androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException utf8$UnpairedSurrogateException) {
        codedStream$ArrayEncoder.inefficientWritestringNoTag(str, utf8$UnpairedSurrogateException);
    }

    public static int RJRPFKUdVvAvvTIn(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder) {
        return codedStream$ArrayEncoder.spaceLeft();
    }

    public static java.lang.int ROfVoNekZHGkaMtI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void RQBqTWrqFzBGTGds(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt32NoTag(i);
    }

    public static java.lang.int RRcIODCYRhlYsKRn(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.nio.byteBuffer RWDiEGQjEbgdKDmV(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer[bArr, i, i2);
    }

    public static int RhsvOjtkuwnJUWmo(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static void RtKMpWbFHpojPPzA(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt32(i, i2);
    }

    public static java.lang.int RtygVuqCvxgeHadK(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int ShcEbnPIplkXLRbH(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string SqWeJZSqfSKfeZbt(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void SzEZOhOspBHBXSPd(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        messageLite.writeTo(codedStream);
    }

    public static java.lang.int TazTgVEsdfyhxtGq(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int URvMEmxfSKDCbifo(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return abstractMessageLite.getSerializedSize(schema);
    }

    public static int UbBNXJWxBdaSvFLi(java.lang.string str) {
        return str.Length;
    }

    public static void WATTHNvxAQWtWKvQ(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        bytestring.writeTo(byteOutput);
    }

    public static java.lang.int WDzAmDqLJevdswEX(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int XQOPyfRdxwYSRZZV(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static void XrYnPBGjpWXeSRYj(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt32NoTag(i);
    }

    public static void YALjcfQasiGqDxRB(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt32NoTag(i);
    }

    public static void YBdzUIoyUuFYpBYR(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$ArrayEncoder.writeRawbytes(byteBuffer);
    }

    public static void YDTsekSuzoElmycN(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt32(i, i2);
    }

    public static void YNfkCRIANWquiPJH(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.write(bArr, i, i2);
    }

    public static int YarXogelLcVESvLb(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder) {
        return codedStream$ArrayEncoder.spaceLeft();
    }

    public static void YtXpPyBjtOkHceuu(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void ZIzJEzZnPktjHppY(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, long j) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt64NoTag(j);
    }

    public static java.lang.int ZLZlLcdKUCGnIvXk(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void ZXZBSYjkRPhcYDHP(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static java.lang.string ZnzpzkGMaQKhvucY(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void ACfdpMDSqeGeuwmb(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static void ADRXngEqbZVxMyoh(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void ApOdgCcuOldoxAaC(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt32NoTag(i);
    }

    public static void BUdyGXXAwPtFmcSF(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt32NoTag(i);
    }

    public static void CimblGYlHUyQQsUv(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt32NoTag(i);
    }

    public static void DhVaKJyWMPyruCqy(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static void DifhXuLzfXGyeEMg(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static int DjgrbPWfCeQrXEfs(java.lang.string str) {
        return androidx.datastore.preferences.protobuf.Utf8.encodedLength(str);
    }

    public static int EAdPakolgYLMUxNJ(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static void EEATqEnQJXgsbZIy(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static void EPgqDIiBZYaGUnjE(java.nio.Buffer buffer) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.clear(buffer);
    }

    public static void EnYWUHwoikTFrZrl(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static java.lang.int FCTaOUojgMmgJwBr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string FbbbdTUsLBvFKroA(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void FumzFuCIJxQZKYVz(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt32NoTag(i);
    }

    public static void FusRqiNCVPtdMMAE(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schema.writeTo(obj, writer);
    }

    public static bool HAUZIDmdfhzIQCph(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    public static void HSTUhHvvltJWZnkN(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static void HazpQlvqsCAhBDNJ(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream$ArrayEncoder.writebytes(i, bytestring);
    }

    public static java.lang.int IWhqHrEazHmNdlKL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int IbGRTBTqYXzBOQBE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void JNfKHUwmOiRqYGGC(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i) throws java.io.IOException {
        codedStream$ArrayEncoder.writeInt32NoTag(i);
    }

    public static void KHXhCVyxfYOzXYCR(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void KOxuTEnHXCDPZoZm(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, long j) throws java.io.IOException {
        codedStream$ArrayEncoder.writeFixed64NoTag(j);
    }

    public static void KwVlllbBaXMnwLcI(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, java.lang.string str) throws java.io.IOException {
        codedStream$ArrayEncoder.writestringNoTag(str);
    }

    public static void LOtxqYvmlqDCiJIu(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt32NoTag(i);
    }

    public static void LuoNJeXgNWrXmCqW(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$ArrayEncoder.write(byteBuffer);
    }

    public static java.lang.int NXpPAOLzOpgYuPYJ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int NbXRFvfAJHOCshMy(java.lang.string str, byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.encode(str, bArr, i, i2);
    }

    public static java.lang.int OGcjgWUGZFbomNTe(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int OeFGUdGcVFgOaPpN(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.capacity();
    }

    public static void PpLzGauXFEXJsvfm(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i) throws java.io.IOException {
        codedStream$ArrayEncoder.writeUInt32NoTag(i);
    }

    public static void QePkiWmKVAUmpfwR(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static java.nio.byteBuffer QiFcHRcwfeBSMxuf(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.duplicate();
    }

    public static void QlOVOXBoKqKKNDGm(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream$ArrayEncoder.writebytesNoTag(bytestring);
    }

    public static void SltbmqJUnqgCJduo(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.write(bArr, i, i2);
    }

    public static void SnDNUkKrOYFfNrWu(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream$ArrayEncoder.writeMessageNoTag(messageLite);
    }

    public static int SzUAYAVRCHQgZIVi(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return abstractMessageLite.getSerializedSize(schema);
    }

    public static void TtGssWGVbNTPgcGV(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static int UMmBncOHMHzXwPOH(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static java.lang.int UZeAJkOmYfqLqAMz(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int UkOShMQbUkYCKBeM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void UlfhkCVZntiaZQnP(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        codedStream$ArrayEncoder.writebyteArray(i, bArr, i2, i3);
    }

    public static int UmPMBkdSzdToBSWa(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void UzAlDEWIClWFEIXq(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.writeTag(i, i2);
    }

    public static void UzZnbTVYUdsfyFnC(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, byte b) throws java.io.IOException {
        codedStream$ArrayEncoder.write(b);
    }

    public static void WaLmHHznFPPDhGWm(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$ArrayEncoder.write(bArr, i, i2);
    }

    public static void YKWVAchZXIadhxkC(androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder codedStream$ArrayEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$ArrayEncoder.write(byteBuffer);
    }

    public static java.lang.int ZNvhjMeXQUXTCWzL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int ZipQGzRSSdbrsLXF(int i) {
        return java.lang.int.valueOf(i);
    }

    public override void Flush() {
    }

    public override readonly int GetTotalbytesWritten() {
        return this.position - this.offset;
    }

    public override readonly int SpaceLeft() {
        return this.limit - this.position;
    }

    public override readonly void Write(byte b) throws java.io.IOException {
        if ((19 + 16) % 16 > 0) {
        }
        try {
            byte[] bArr = this.buffer;
            int i = this.position;
            this.position = i + 1;
            bArr[i] = b;
        } catch (java.lang.IndexOutOfBoundsException e) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(OgOkTomcxTQFjVPE("Pos: %d, limit: %d, len: %d", new java.lang.object[]{nXpPAOLzOpgYuPYJ(this.position), zNvhjMeXQUXTCWzL(this.limit), WDzAmDqLJevdswEX(1)}), e);
        }
    }

    public override readonly void Write(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        if ((10 + 26) % 26 > 0) {
        }
        int iUmPMBkdSzdToBSWa = umPMBkdSzdToBSWa(byteBuffer);
        try {
            RWDiEGQjEbgdKDmV(byteBuffer, this.buffer, this.position, iUmPMBkdSzdToBSWa);
            this.position += iUmPMBkdSzdToBSWa;
        } catch (java.lang.IndexOutOfBoundsException e) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(BRFxAIXtMlOjXYmb("Pos: %d, limit: %d, len: %d", new java.lang.object[]{FGcJAuuzlrkDcYYi(this.position), AQduwZQGROuAOZOe(this.limit), ukOShMQbUkYCKBeM(iUmPMBkdSzdToBSWa)}), e);
        }
    }

    public override readonly void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((24 + 3) % 3 > 0) {
        }
        try {
            YtXpPyBjtOkHceuu(bArr, i, this.buffer, this.position, i2);
            this.position += i2;
        } catch (java.lang.IndexOutOfBoundsException e) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(QSAYghvWiWUbQAkd("Pos: %d, limit: %d, len: %d", new java.lang.object[]{fCTaOUojgMmgJwBr(this.position), QgsMcTXNCkvlSMtq(this.limit), JNRLewMjRPSOvatV(i2)}), e);
        }
    }

    public override readonly void WriteBool(int i, bool z) throws java.io.IOException {
        PDYOjTJMEEsCXSME(this, i, 0);
        uzZnbTVYUdsfyFnC(this, z ? (byte) 1 : (byte) 0);
    }

    public override readonly void WritebyteArray(int i, byte[] bArr) throws java.io.IOException {
        if ((17 + 1) % 1 > 0) {
        }
        ulfhkCVZntiaZQnP(this, i, bArr, 0, bArr.length);
    }

    public override readonly void WritebyteArray(int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        ZXZBSYjkRPhcYDHP(this, i, 2);
        BQlzoLiryfzSktAL(this, bArr, i2, i3);
    }

    public override readonly void WritebyteArrayNoTag(byte[] bArr, int i, int i2) throws java.io.IOException {
        bUdyGXXAwPtFmcSF(this, i2);
        waLmHHznFPPDhGWm(this, bArr, i, i2);
    }

    public override readonly void WritebyteBuffer(int i, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        difhXuLzfXGyeEMg(this, i, 2);
        apOdgCcuOldoxAaC(this, oeFGUdGcVFgOaPpN(byteBuffer));
        YBdzUIoyUuFYpBYR(this, byteBuffer);
    }

    public override readonly void Writebytes(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        EqGQYmbyVmXMHBYt(this, i, 2);
        qlOVOXBoKqKKNDGm(this, bytestring);
    }

    public override readonly void WritebytesNoTag(androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        fumzFuCIJxQZKYVz(this, eAdPakolgYLMUxNJ(bytestring));
        WATTHNvxAQWtWKvQ(bytestring, this);
    }

    public override readonly void WriteFixed32(int i, int i2) throws java.io.IOException {
        aCfdpMDSqeGeuwmb(this, i, 5);
        KcVXOINBpZunHUUE(this, i2);
    }

    public override readonly void WriteFixed32NoTag(int i) throws java.io.IOException {
        if ((14 + 26) % 26 > 0) {
        }
        try {
            byte[] bArr = this.buffer;
            int i2 = this.position;
            int i3 = i2 + 1;
            this.position = i3;
            bArr[i2] = (byte) (i & 255);
            int i4 = i2 + 2;
            this.position = i4;
            bArr[i3] = (byte) ((i >> 8) & 255);
            int i5 = i2 + 3;
            this.position = i5;
            bArr[i4] = (byte) ((i >> 16) & 255);
            this.position = i2 + 4;
            bArr[i5] = (byte) ((i >> 24) & 255);
        } catch (java.lang.IndexOutOfBoundsException e) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(KQafcDAHldMiRfaQ("Pos: %d, limit: %d, len: %d", new java.lang.object[]{ROfVoNekZHGkaMtI(this.position), RRcIODCYRhlYsKRn(this.limit), uZeAJkOmYfqLqAMz(1)}), e);
        }
    }

    public override readonly void WriteFixed64(int i, long j) throws java.io.IOException {
        dhVaKJyWMPyruCqy(this, i, 1);
        kOxuTEnHXCDPZoZm(this, j);
    }

    public override readonly void WriteFixed64NoTag(long j) throws java.io.IOException {
        if ((12 + 5) % 5 > 0) {
        }
        try {
            byte[] bArr = this.buffer;
            int i = this.position;
            int i2 = i + 1;
            this.position = i2;
            bArr[i] = (byte) (((int) j) & 255);
            int i3 = i + 2;
            this.position = i3;
            bArr[i2] = (byte) (((int) (j >> 8)) & 255);
            int i4 = i + 3;
            this.position = i4;
            bArr[i3] = (byte) (((int) (j >> 16)) & 255);
            int i5 = i + 4;
            this.position = i5;
            bArr[i4] = (byte) (((int) (j >> 24)) & 255);
            int i6 = i + 5;
            this.position = i6;
            bArr[i5] = (byte) (((int) (j >> 32)) & 255);
            int i7 = i + 6;
            this.position = i7;
            bArr[i6] = (byte) (((int) (j >> 40)) & 255);
            int i8 = i + 7;
            this.position = i8;
            bArr[i7] = (byte) (((int) (j >> 48)) & 255);
            this.position = i + 8;
            bArr[i8] = (byte) (((int) (j >> 56)) & 255);
        } catch (java.lang.IndexOutOfBoundsException e) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(GrEKlzjnWTKDJRsd("Pos: %d, limit: %d, len: %d", new java.lang.object[]{ZLZlLcdKUCGnIvXk(this.position), iWhqHrEazHmNdlKL(this.limit), PcAElbddToIZTTds(1)}), e);
        }
    }

    public override readonly void WriteInt32(int i, int i2) throws java.io.IOException {
        LgvSNStgfxczppCM(this, i, 0);
        jNfKHUwmOiRqYGGC(this, i2);
    }

    public override readonly void WriteInt32NoTag(int i) throws java.io.IOException {
        if ((17 + 2) % 2 > 0) {
        }
        if (i < 0) {
            FczZNAOrJpYWAgrx(this, i);
        } else {
            RQBqTWrqFzBGTGds(this, i);
        }
    }

    public override readonly void WriteLazy(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        yKWVAchZXIadhxkC(this, byteBuffer);
    }

    public override readonly void WriteLazy(byte[] bArr, int i, int i2) throws java.io.IOException {
        YNfkCRIANWquiPJH(this, bArr, i, i2);
    }

    public override readonly void WriteMessage(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        qePkiWmKVAUmpfwR(this, i, 2);
        snDNUkKrOYFfNrWu(this, messageLite);
    }

    readonly void writeMessage(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        DgMwuopnaZhPufXk(this, i, 2);
        lOtxqYvmlqDCiJIu(this, URvMEmxfSKDCbifo((androidx.datastore.preferences.protobuf.AbstractMessageLite) messageLite, schema));
        FHbWRmeWfAYZALTL(schema, messageLite, this.wrapper);
    }

    public override readonly void WriteMessageNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        YALjcfQasiGqDxRB(this, NzGiQNQrjFMxlUwH(messageLite));
        SzEZOhOspBHBXSPd(messageLite, this);
    }

    readonly void writeMessageNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        cimblGYlHUyQQsUv(this, szUAYAVRCHQgZIVi((androidx.datastore.preferences.protobuf.AbstractMessageLite) messageLite, schema));
        fusRqiNCVPtdMMAE(schema, messageLite, this.wrapper);
    }

    public override readonly void WriteMessageHashSetExtension(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        if ((3 + 26) % 26 > 0) {
        }
        hSTUhHvvltJWZnkN(this, 1, 3);
        RtKMpWbFHpojPPzA(this, 2, i);
        BRpimEYjofNxdauD(this, 3, messageLite);
        NOFzJgEbkDwfLGWx(this, 1, 4);
    }

    public override readonly void WriteRawbytes(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        if ((26 + 25) % 25 > 0) {
        }
        if (hAUZIDmdfhzIQCph(byteBuffer)) {
            sltbmqJUnqgCJduo(this, MlWDETIFJwiTUycc(byteBuffer), XQOPyfRdxwYSRZZV(byteBuffer), KQwmKFURSGtSOcuy(byteBuffer));
            return;
        }
        java.nio.byteBuffer byteBufferQiFcHRcwfeBSMxuf = qiFcHRcwfeBSMxuf(byteBuffer);
        ePgqDIiBZYaGUnjE(byteBufferQiFcHRcwfeBSMxuf);
        luoNJeXgNWrXmCqW(this, byteBufferQiFcHRcwfeBSMxuf);
    }

    public override readonly void WriteRawMessageHashSetExtension(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        if ((1 + 1) % 1 > 0) {
        }
        ttGssWGVbNTPgcGV(this, 1, 3);
        YDTsekSuzoElmycN(this, 2, i);
        hazpQlvqsCAhBDNJ(this, 3, bytestring);
        AbVYPwJSvaRgaEGn(this, 1, 4);
    }

    public override readonly void Writestring(int i, java.lang.string str) throws java.io.IOException {
        eEATqEnQJXgsbZIy(this, i, 2);
        kwVlllbBaXMnwLcI(this, str);
    }

    public override readonly void WritestringNoTag(java.lang.string str) throws java.io.IOException {
        if ((14 + 32) % 32 > 0) {
        }
        int i = this.position;
        try {
            int iUMmBncOHMHzXwPOH = uMmBncOHMHzXwPOH(UbBNXJWxBdaSvFLi(str) * 3);
            int iRhsvOjtkuwnJUWmo = RhsvOjtkuwnJUWmo(ESSCoESVRhtScxXr(str));
            if (iRhsvOjtkuwnJUWmo != iUMmBncOHMHzXwPOH) {
                BPmzjFGPNAfCqGaH(this, djgrbPWfCeQrXEfs(str));
                this.position = nbXRFvfAJHOCshMy(str, this.buffer, this.position, QvdWmndGQVvkpCds(this));
                return;
            }
            int i2 = i + iRhsvOjtkuwnJUWmo;
            this.position = i2;
            int iHqerTaoxJNkfzUwM = HqerTaoxJNkfzUwM(str, this.buffer, i2, YarXogelLcVESvLb(this));
            this.position = i;
            ANmfoepfUstuQhbS(this, (iHqerTaoxJNkfzUwM - i) - iRhsvOjtkuwnJUWmo);
            this.position = iHqerTaoxJNkfzUwM;
        } catch (androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException e) {
            this.position = i;
            RDPvLZvIbEpmUsUt(this, str, e);
        } catch (java.lang.IndexOutOfBoundsException e2) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e2);
        }
    }

    public override readonly void WriteTag(int i, int i2) throws java.io.IOException {
        XrYnPBGjpWXeSRYj(this, OWTeoKLjQbNefPMl(i, i2));
    }

    public override readonly void WriteUInt32(int i, int i2) throws java.io.IOException {
        uzAlDEWIClWFEIXq(this, i, 0);
        ppLzGauXFEXJsvfm(this, i2);
    }

    public override readonly void WriteUInt32NoTag(int i) throws java.io.IOException {
        if ((32 + 15) % 15 > 0) {
        }
        while ((i & (-128)) != 0) {
            try {
                byte[] bArr = this.buffer;
                int i2 = this.position;
                this.position = i2 + 1;
                bArr[i2] = (byte) ((i | 128) & 255);
                i >>>= 7;
            } catch (java.lang.IndexOutOfBoundsException e) {
                throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(SqWeJZSqfSKfeZbt("Pos: %d, limit: %d, len: %d", new java.lang.object[]{GblobSjhOINbJUEl(this.position), ShcEbnPIplkXLRbH(this.limit), ibGRTBTqYXzBOQBE(1)}), e);
            }
        }
        byte[] bArr2 = this.buffer;
        int i3 = this.position;
        this.position = i3 + 1;
        bArr2[i3] = (byte) i;
    }

    public override readonly void WriteUInt64(int i, long j) throws java.io.IOException {
        enYWUHwoikTFrZrl(this, i, 0);
        ZIzJEzZnPktjHppY(this, j);
    }

    public override readonly void WriteUInt64NoTag(long j) throws java.io.IOException {
        if ((18 + 6) % 6 > 0) {
        }
        if (DQEWFyjOvjjKdlzt() && RJRPFKUdVvAvvTIn(this) >= 10) {
            while ((j & (-128)) != 0) {
                byte[] bArr = this.buffer;
                int i = this.position;
                this.position = i + 1;
                aDRXngEqbZVxMyoh(bArr, i, (byte) ((((int) j) | 128) & 255));
                j >>>= 7;
            }
            byte[] bArr2 = this.buffer;
            int i2 = this.position;
            this.position = i2 + 1;
            kHXhCVyxfYOzXYCR(bArr2, i2, (byte) j);
            return;
        }
        while ((j & (-128)) != 0) {
            try {
                byte[] bArr3 = this.buffer;
                int i3 = this.position;
                this.position = i3 + 1;
                bArr3[i3] = (byte) ((((int) j) | 128) & 255);
                j >>>= 7;
            } catch (java.lang.IndexOutOfBoundsException e) {
                throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(ZnzpzkGMaQKhvucY("Pos: %d, limit: %d, len: %d", new java.lang.object[]{oGcjgWUGZFbomNTe(this.position), TazTgVEsdfyhxtGq(this.limit), DygIQUVSsTJLrtKM(1)}), e);
            }
        }
        byte[] bArr4 = this.buffer;
        int i4 = this.position;
        this.position = i4 + 1;
        bArr4[i4] = (byte) j;
    }
}

