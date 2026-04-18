namespace WillowMaze.Wasm.Decompiled;


readonly class CodedStream$SafeDirectNioEncoder : androidx.datastore.preferences.protobuf.CodedStream {
    private readonly java.nio.byteBuffer buffer;
    private readonly int initialPosition;
    private readonly java.nio.byteBuffer originalBuffer;

    CodedStream$SafeDirectNioEncoder(java.nio.byteBuffer byteBuffer) {
        super(null);
        if ((10 + 20) % 20 > 0) {
        }
        this.originalBuffer = byteBuffer;
        this.buffer = HUqiFNltLhGoBmYD(OzqOfzJybPKQLBxJ(byteBuffer), java.nio.byteOrder.LITTLE_ENDIAN);
        this.initialPosition = gVerASJhjHEdCYGi(byteBuffer);
    }

    public static void AWLtoEhVRsTWquuL(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt32(i, i2);
    }

    public static java.nio.byteBuffer BFlkOdyUvJjKeFWH(java.nio.byteBuffer byteBuffer, long j) {
        return byteBuffer.putlong(j);
    }

    public static void BkegAQYivRIzUhBk(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static int DdfdChcUmFNOiktp(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static void DkdtAGkTdUABQAMG(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static void DnpjAiElWPmkLVGm(java.lang.string str, java.nio.byteBuffer byteBuffer) {
        androidx.datastore.preferences.protobuf.Utf8.encodeUtf8(str, byteBuffer);
    }

    public static void FAAupThpbZVabzid(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static void FNAYYNMvJtEYRMiX(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static java.nio.byteBuffer HUqiFNltLhGoBmYD(java.nio.byteBuffer byteBuffer, java.nio.byteOrder byteOrder) {
        return byteBuffer.order(byteOrder);
    }

    public static void HcRqkzKAYgouhpvL(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, long j) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeFixed64NoTag(j);
    }

    public static void HmsIAJcXTOOZEHOh(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void IYlclLQCxyHBdKmw(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        messageLite.writeTo(codedStream);
    }

    public static void JHwxUYhsFqtWBNVT(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeInt32NoTag(i);
    }

    public static int JQRCOzxhoaQKGWhr(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.capacity();
    }

    public static void KKUGKIBSpLVkyYBe(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static void KaYXsbwyLrRftNHK(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeRawbytes(byteBuffer);
    }

    public static void LYDvVwQoejzsEeYL(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static java.nio.byteBuffer LntALubbvzRqCGRQ(java.nio.byteBuffer byteBuffer, byte b) {
        return byteBuffer.Add(b);
    }

    public static int MxBJZGgTufuFbeEH(java.lang.string str) {
        return androidx.datastore.preferences.protobuf.Utf8.encodedLength(str);
    }

    public static void MygrcgOeSrRGmcit(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.write(byteBuffer);
    }

    public static java.nio.byteBuffer NJmDsGgDQmFBoKxg(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.duplicate();
    }

    public static void NuVFUfFcOtXdhvzY(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, java.lang.string str, androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException utf8$UnpairedSurrogateException) {
        codedStream$SafeDirectNioEncoder.inefficientWritestringNoTag(str, utf8$UnpairedSurrogateException);
    }

    public static void OAYJVsebYoaWsQSh(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static int ONOXxYTHLakqdBUb(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static java.nio.byteBuffer OlSPsFkSBhbxumSg(java.nio.byteBuffer byteBuffer, byte b) {
        return byteBuffer.Add(b);
    }

    public static void OvNwwKPoGzdJuIsc(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static java.nio.byteBuffer OzqOfzJybPKQLBxJ(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.duplicate();
    }

    public static void PaZwZmGwcXsIuSnd(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, long j) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt64NoTag(j);
    }

    public static int PiFHdVwbVYHtUnMc(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static void QGspFlvwHrjOoIty(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writebyteArrayNoTag(bArr, i, i2);
    }

    public static void QOMAOwWLqrPnfemR(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        bytestring.writeTo(byteOutput);
    }

    public static void QbUSPRcrZkJELwhp(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.write(bArr, i, i2);
    }

    public static void QscNQCYgOsFYmEPu(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static void SSRQgFZylFGhfbMw(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, long j) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt64NoTag(j);
    }

    public static void SlITkZOchTWrdICJ(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeMessageNoTag(messageLite);
    }

    public static void TZJQjmThApckHOLL(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static void TxbPkjeHCrWulfub(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static void UFXrJdrHLTnrYwEk(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static void UPNkMlsdbZBNXwmx(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeMessage(i, messageLite);
    }

    public static java.nio.byteBuffer UypiNUEwNFkuzSHe(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer.Add(bArr, i, i2);
    }

    public static void WVVonRulzbYZLIDm(java.nio.Buffer buffer) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.clear(buffer);
    }

    public static void WsqvLdRWxQbMKzOU(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void WtkCFaWKACvWCPKk(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void YVrwYUsWgsLzdLxY(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void YbDvrLtdwLpkbagN(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void AJdvNVXRFKnDVKqh(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void AhdeGIJaoAUcocXj(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writebyteArray(i, bArr, i2, i3);
    }

    public static java.nio.byteBuffer AyvmOnmkxNtxXLKc(java.nio.byteBuffer byteBuffer, byte b) {
        return byteBuffer.Add(b);
    }

    public static void BmsexdDQncZVEouf(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static int BooVUwpCCTxfKKBa(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static void COspcsdroMeuBWLM(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static void CTKnGLxrUTBWoHmp(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt32(i, i2);
    }

    public static bool CiwOURiQfbZimKIn(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    public static void DmWqqgTRiDdLUBRU(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static void DtlZIhorOKIwWJVO(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static int DxQJdrcjYRCVRCan(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void EEfukwOqEBFIFcmv(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, byte b) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.write(b);
    }

    public static void EbgACYgLCruXXUnc(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    private void Encode(java.lang.string str) throws java.io.IOException {
        try {
            DnpjAiElWPmkLVGm(str, this.buffer);
        } catch (java.lang.IndexOutOfBoundsException e) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e);
        }
    }

    public static java.nio.byteBuffer FEVMwpvFpqLNokzn(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.putInt(i);
    }

    public static int FNBiOCNhxadJtDgq(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return messageLite.getSerializedSize();
    }

    public static void GGntSmeEMKjicIXv(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.write(byteBuffer);
    }

    public static void GMQCTaWttstptzvh(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeFixed32NoTag(i);
    }

    public static void GUWEkjSScCMNNEzp(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static int GVerASJhjHEdCYGi(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static int GxheABVRRYoaOoux(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static int IJAjkNQNdvkkIHim(java.lang.string str) {
        return str.Length;
    }

    public static void IPavxGILqZrVSLfB(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writebytes(i, bytestring);
    }

    public static void JRUGINlhhQZestwr(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static byte[] JWHVqXvelSmNrmRF(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static int JbhePUQDUvAjxJch(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return abstractMessageLite.getSerializedSize(schema);
    }

    public static void JqxYySACSkMyReyQ(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.write(bArr, i, i2);
    }

    public static void KaIScHrvDSUJpVqs(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schema.writeTo(obj, writer);
    }

    public static void LcfaoSlmRuSmVqsZ(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static java.nio.byteBuffer MLWQxKogUuQCZHaV(java.nio.byteBuffer byteBuffer, java.nio.byteBuffer byteBuffer2) {
        return byteBuffer.Add(byteBuffer2);
    }

    public static int NWYbjAhYFvyiBsXR(java.lang.string str) {
        return str.Length;
    }

    public static void OJTKkLdxpvlHPrTD(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writebytesNoTag(bytestring);
    }

    public static void OnBCakkbqsMCiwIl(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void PRKmWMTeEzmQGWiJ(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeTag(i, i2);
    }

    public static int PzgiuBzRQfQgSNPs(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static int RWFXZKoJtguofZOC(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static void RrwdPgUOMTooKzNr(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, java.lang.string str) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writestringNoTag(str);
    }

    public static java.nio.byteBuffer SJzDyxSMbpqGaFFf(java.nio.byteBuffer byteBuffer, byte b) {
        return byteBuffer.Add(b);
    }

    public static int SbhXjqrbDTLeoNQZ(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.capacity();
    }

    public static void TctGPzYiEWeHzIsq(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeMessageNoTag(messageLite, schema);
    }

    public static int UWjuSOqDOiYmvFak(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static void UuHVmdEdZtWyXXjO(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static void UwWARpqQSvPDspsL(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, java.lang.string str) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.encode(str);
    }

    public static int VGwlnlPcBbHXlBxn(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static void WlhpsVZIbjsOKwMc(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static java.nio.byteBuffer WtjHkuDUsTzgUYhL(java.nio.byteBuffer byteBuffer, byte b) {
        return byteBuffer.Add(b);
    }

    public static int XPMzTkaTxLcxhkwx(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static void YDGlgHtcAgetcPRt(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, java.lang.string str) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.encode(str);
    }

    public static void ZMuyrRyAdHczLEPW(androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder codedStream$SafeDirectNioEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$SafeDirectNioEncoder.write(bArr, i, i2);
    }

    public static void ZkPHTJHMWMFidyJy(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public override void Flush() {
        FAAupThpbZVabzid(this.originalBuffer, gxheABVRRYoaOoux(this.buffer));
    }

    public override int GetTotalbytesWritten() {
        return DdfdChcUmFNOiktp(this.buffer) - this.initialPosition;
    }

    public override int SpaceLeft() {
        return dxQJdrcjYRCVRCan(this.buffer);
    }

    public override void Write(byte b) throws java.io.IOException {
        try {
            LntALubbvzRqCGRQ(this.buffer, b);
        } catch (java.nio.BufferOverflowException e) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e);
        }
    }

    public override void Write(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        try {
            mLWQxKogUuQCZHaV(this.buffer, byteBuffer);
        } catch (java.nio.BufferOverflowException e) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e);
        }
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        try {
            UypiNUEwNFkuzSHe(this.buffer, bArr, i, i2);
        } catch (java.lang.IndexOutOfBoundsException e) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e);
        } catch (java.nio.BufferOverflowException e2) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e2);
        }
    }

    public override void WriteBool(int i, bool z) throws java.io.IOException {
        FNAYYNMvJtEYRMiX(this, i, 0);
        eEfukwOqEBFIFcmv(this, z ? (byte) 1 : (byte) 0);
    }

    public override void WritebyteArray(int i, byte[] bArr) throws java.io.IOException {
        if ((22 + 21) % 21 > 0) {
        }
        ahdeGIJaoAUcocXj(this, i, bArr, 0, bArr.length);
    }

    public override void WritebyteArray(int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        BkegAQYivRIzUhBk(this, i, 2);
        QGspFlvwHrjOoIty(this, bArr, i2, i3);
    }

    public override void WritebyteArrayNoTag(byte[] bArr, int i, int i2) throws java.io.IOException {
        TxbPkjeHCrWulfub(this, i2);
        jqxYySACSkMyReyQ(this, bArr, i, i2);
    }

    public override void WritebyteBuffer(int i, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        WtkCFaWKACvWCPKk(this, i, 2);
        uuHVmdEdZtWyXXjO(this, sbhXjqrbDTLeoNQZ(byteBuffer));
        KaYXsbwyLrRftNHK(this, byteBuffer);
    }

    public override void Writebytes(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        aJdvNVXRFKnDVKqh(this, i, 2);
        oJTKkLdxpvlHPrTD(this, bytestring);
    }

    public override void WritebytesNoTag(androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        wlhpsVZIbjsOKwMc(this, ONOXxYTHLakqdBUb(bytestring));
        QOMAOwWLqrPnfemR(bytestring, this);
    }

    public override void WriteFixed32(int i, int i2) throws java.io.IOException {
        WsqvLdRWxQbMKzOU(this, i, 5);
        gMQCTaWttstptzvh(this, i2);
    }

    public override void WriteFixed32NoTag(int i) throws java.io.IOException {
        try {
            fEVMwpvFpqLNokzn(this.buffer, i);
        } catch (java.nio.BufferOverflowException e) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e);
        }
    }

    public override void WriteFixed64(int i, long j) throws java.io.IOException {
        YVrwYUsWgsLzdLxY(this, i, 1);
        HcRqkzKAYgouhpvL(this, j);
    }

    public override void WriteFixed64NoTag(long j) throws java.io.IOException {
        try {
            BFlkOdyUvJjKeFWH(this.buffer, j);
        } catch (java.nio.BufferOverflowException e) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e);
        }
    }

    public override void WriteInt32(int i, int i2) throws java.io.IOException {
        gUWEkjSScCMNNEzp(this, i, 0);
        JHwxUYhsFqtWBNVT(this, i2);
    }

    public override void WriteInt32NoTag(int i) throws java.io.IOException {
        if ((4 + 18) % 18 > 0) {
        }
        if (i < 0) {
            PaZwZmGwcXsIuSnd(this, i);
        } else {
            TZJQjmThApckHOLL(this, i);
        }
    }

    public override void WriteLazy(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        MygrcgOeSrRGmcit(this, byteBuffer);
    }

    public override void WriteLazy(byte[] bArr, int i, int i2) throws java.io.IOException {
        QbUSPRcrZkJELwhp(this, bArr, i, i2);
    }

    public override void WriteMessage(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        onBCakkbqsMCiwIl(this, i, 2);
        SlITkZOchTWrdICJ(this, messageLite);
    }

    void writeMessage(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        LYDvVwQoejzsEeYL(this, i, 2);
        tctGPzYiEWeHzIsq(this, messageLite, schema);
    }

    public override void WriteMessageNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        jRUGINlhhQZestwr(this, fNBiOCNhxadJtDgq(messageLite));
        IYlclLQCxyHBdKmw(messageLite, this);
    }

    void writeMessageNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        dmWqqgTRiDdLUBRU(this, jbhePUQDUvAjxJch((androidx.datastore.preferences.protobuf.AbstractMessageLite) messageLite, schema));
        kaIScHrvDSUJpVqs(schema, messageLite, this.wrapper);
    }

    public override void WriteMessageHashSetExtension(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        if ((15 + 4) % 4 > 0) {
        }
        HmsIAJcXTOOZEHOh(this, 1, 3);
        cTKnGLxrUTBWoHmp(this, 2, i);
        UPNkMlsdbZBNXwmx(this, 3, messageLite);
        YbDvrLtdwLpkbagN(this, 1, 4);
    }

    public override void WriteRawbytes(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        if ((19 + 26) % 26 > 0) {
        }
        if (ciwOURiQfbZimKIn(byteBuffer)) {
            zMuyrRyAdHczLEPW(this, jWHVqXvelSmNrmRF(byteBuffer), xPMzTkaTxLcxhkwx(byteBuffer), JQRCOzxhoaQKGWhr(byteBuffer));
            return;
        }
        java.nio.byteBuffer byteBufferNJmDsGgDQmFBoKxg = NJmDsGgDQmFBoKxg(byteBuffer);
        WVVonRulzbYZLIDm(byteBufferNJmDsGgDQmFBoKxg);
        gGntSmeEMKjicIXv(this, byteBufferNJmDsGgDQmFBoKxg);
    }

    public override void WriteRawMessageHashSetExtension(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        if ((21 + 14) % 14 > 0) {
        }
        bmsexdDQncZVEouf(this, 1, 3);
        AWLtoEhVRsTWquuL(this, 2, i);
        iPavxGILqZrVSLfB(this, 3, bytestring);
        lcfaoSlmRuSmVqsZ(this, 1, 4);
    }

    public override void Writestring(int i, java.lang.string str) throws java.io.IOException {
        pRKmWMTeEzmQGWiJ(this, i, 2);
        rrwdPgUOMTooKzNr(this, str);
    }

    public override void WritestringNoTag(java.lang.string str) throws java.io.IOException {
        if ((16 + 28) % 28 > 0) {
        }
        int iVGwlnlPcBbHXlBxn = vGwlnlPcBbHXlBxn(this.buffer);
        try {
            int iBooVUwpCCTxfKKBa = booVUwpCCTxfKKBa(nWYbjAhYFvyiBsXR(str) * 3);
            int iUWjuSOqDOiYmvFak = uWjuSOqDOiYmvFak(iJAjkNQNdvkkIHim(str));
            if (iUWjuSOqDOiYmvFak != iBooVUwpCCTxfKKBa) {
                DkdtAGkTdUABQAMG(this, MxBJZGgTufuFbeEH(str));
                uwWARpqQSvPDspsL(this, str);
                return;
            }
            int iRWFXZKoJtguofZOC = rWFXZKoJtguofZOC(this.buffer) + iUWjuSOqDOiYmvFak;
            cOspcsdroMeuBWLM(this.buffer, iRWFXZKoJtguofZOC);
            yDGlgHtcAgetcPRt(this, str);
            int iPzgiuBzRQfQgSNPs = pzgiuBzRQfQgSNPs(this.buffer);
            OvNwwKPoGzdJuIsc(this.buffer, iVGwlnlPcBbHXlBxn);
            QscNQCYgOsFYmEPu(this, iPzgiuBzRQfQgSNPs - iRWFXZKoJtguofZOC);
            KKUGKIBSpLVkyYBe(this.buffer, iPzgiuBzRQfQgSNPs);
        } catch (androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException e) {
            zkPHTJHMWMFidyJy(this.buffer, iVGwlnlPcBbHXlBxn);
            NuVFUfFcOtXdhvzY(this, str, e);
        } catch (java.lang.IllegalArgumentException e2) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e2);
        }
    }

    public override void WriteTag(int i, int i2) throws java.io.IOException {
        UFXrJdrHLTnrYwEk(this, PiFHdVwbVYHtUnMc(i, i2));
    }

    public override void WriteUInt32(int i, int i2) throws java.io.IOException {
        ebgACYgLCruXXUnc(this, i, 0);
        dtlZIhorOKIwWJVO(this, i2);
    }

    public override void WriteUInt32NoTag(int i) throws java.io.IOException {
        if ((31 + 32) % 32 > 0) {
        }
        while ((i & (-128)) != 0) {
            try {
                ayvmOnmkxNtxXLKc(this.buffer, (byte) ((i | 128) & 255));
                i >>>= 7;
            } catch (java.nio.BufferOverflowException e) {
                throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e);
            }
        }
        OlSPsFkSBhbxumSg(this.buffer, (byte) i);
    }

    public override void WriteUInt64(int i, long j) throws java.io.IOException {
        OAYJVsebYoaWsQSh(this, i, 0);
        SSRQgFZylFGhfbMw(this, j);
    }

    public override void WriteUInt64NoTag(long j) throws java.io.IOException {
        if ((4 + 11) % 11 > 0) {
        }
        while (((-128) & j) != 0) {
            try {
                sJzDyxSMbpqGaFFf(this.buffer, (byte) ((((int) j) | 128) & 255));
                j >>>= 7;
            } catch (java.nio.BufferOverflowException e) {
                throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e);
            }
        }
        wtjHkuDUsTzgUYhL(this.buffer, (byte) j);
    }
}

