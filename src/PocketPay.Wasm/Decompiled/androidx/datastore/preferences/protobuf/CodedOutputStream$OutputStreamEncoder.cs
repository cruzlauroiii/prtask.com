namespace WillowMaze.Wasm.Decompiled;


readonly class CodedStream$StreamEncoder : androidx.datastore.preferences.protobuf.CodedStream$AbstractBufferedEncoder {
    private readonly java.io.Stream out;

    CodedStream$StreamEncoder(java.io.Stream outputStream, int i) {
        super(i);
        if (outputStream is null) {
            throw new java.lang.NullPointerException("out");
        }
        this.out = outputStream;
    }

    public static int ARjCpMtpZZpCSLdd(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return abstractMessageLite.getSerializedSize(schema);
    }

    public static int ATFiAZztGxXmUjXL(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static void AfsfBviogzqHmDCS(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writeUInt32(i, i2);
    }

    public static void AmfmiLdMaWEauENA(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) {
        codedStream$StreamEncoder.bufferFixed32NoTag(i);
    }

    public static bool BBwqadHABISXxZnf(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    public static void BFgLWLJfWQftwdFY(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, long j) {
        codedStream$StreamEncoder.bufferUInt64NoTag(j);
    }

    public static int BiaVCXytwthwAtNu(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void BqPdCvfgYNmGwiaN(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writeTag(i, i2);
    }

    public static int CRMKxSOIMTZmBDVy(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static int EyDCWRRmHZoZEaWD(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static void FYZOHEnaGQNwZmOs(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void GKrdxYlRdpsiRJzw(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder) throws java.io.IOException {
        codedStream$StreamEncoder.doFlush();
    }

    public static void GYBVESqrGpQnyjxS(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writebyteArrayNoTag(bArr, i, i2);
    }

    public static void GbWwJEjLRzujnBDx(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.write(bArr, i, i2);
    }

    public static void GnxLtNDzUcAdOVkX(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.writeUInt32NoTag(i);
    }

    public static void HDBOCJdetwKpzSRX(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) {
        codedStream$StreamEncoder.bufferUInt32NoTag(i);
    }

    public static void HHYAVmldyzfMhnxC(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writeTag(i, i2);
    }

    public static void HVkPZMTeezrxrdmA(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.flushIfNotAvailable(i);
    }

    public static void IoFGFUlKVmPLkjNn(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) {
        codedStream$StreamEncoder.bufferInt32NoTag(i);
    }

    public static void IoPDHkSHgKMHUhAL(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writeTag(i, i2);
    }

    public static void JBWsAyjZFflReSdH(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writeTag(i, i2);
    }

    public static void KCwDUDKfaPibTLmX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void MLUpeZeIxXKMUtvz(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.flushIfNotAvailable(i);
    }

    public static void MPwENJcmUMNoLiMZ(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.flushIfNotAvailable(i);
    }

    public static void MjdTlecevsjqtUgy(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, byte b) {
        codedStream$StreamEncoder.buffer(b);
    }

    public static void NBZsKqzqoBfcYPBO(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.flushIfNotAvailable(i);
    }

    public static void NZRERSYvKAIKEDWx(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, long j) {
        codedStream$StreamEncoder.bufferFixed64NoTag(j);
    }

    public static void NjESVnPGoMVQjdEb(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream$StreamEncoder.writeMessageNoTag(messageLite);
    }

    public static void OEsLPiiXNUuiYAQY(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.writeUInt32NoTag(i);
    }

    public static void OYQIkxYKdSqodEbS(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) {
        codedStream$StreamEncoder.bufferTag(i, i2);
    }

    public static void PFHGLBePOLCmFeLB(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.writeUInt32NoTag(i);
    }

    public static void PKOynWVhqCkOGEgR(java.io.Stream outputStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        outputStream.write(bArr, i, i2);
    }

    public static void QLBbGdDUOOcTPNVW(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream$StreamEncoder.writebytes(i, bytestring);
    }

    public static void RAhvnYojMIKFIdNF(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writeLazy(bArr, i, i2);
    }

    public static void REOmMTDgSnCCHwjf(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) {
        codedStream$StreamEncoder.bufferUInt32NoTag(i);
    }

    public static void RHKwpRGrShyeUpwH(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, long j) {
        codedStream$StreamEncoder.bufferFixed64NoTag(j);
    }

    public static void RMcdxcaCgDiFtzka(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) {
        codedStream$StreamEncoder.bufferUInt32NoTag(i);
    }

    public static byte[] RVNYbPLgHCFYNDQh(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static void STPRjrTKKXjWHJza(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, java.lang.string str) throws java.io.IOException {
        codedStream$StreamEncoder.writestringNoTag(str);
    }

    public static void TGKpMmPBGEELcGdE(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream$StreamEncoder.writeMessage(i, messageLite);
    }

    public static void TRSYvrCPmlAEKbli(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writeTag(i, i2);
    }

    public static void TZmVBoqhLrSBeAwm(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder) throws java.io.IOException {
        codedStream$StreamEncoder.doFlush();
    }

    public static void TqksobZAZDIHmUap(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writeTag(i, i2);
    }

    public static void TxKIzeBIDSVSsIHC(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        messageLite.writeTo(codedStream);
    }

    public static void UbtpUpkPYdbZZmbL(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.write(bArr, i, i2);
    }

    public static void UpDyWRDxbcCoCGez(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.flushIfNotAvailable(i);
    }

    public static void UtOGUrbeufLLqIeJ(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, byte b) {
        codedStream$StreamEncoder.buffer(b);
    }

    public static void VJoaxfbSIYcxVxBq(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.writeUInt32NoTag(i);
    }

    public static int VNBsGAyrnqBUfVuJ(java.lang.string str) {
        return str.Length;
    }

    public static int VzJiFdKBvqrwxMKW(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.capacity();
    }

    public static void WRubuufCbVhulIGe(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream$StreamEncoder.writebytesNoTag(bytestring);
    }

    public static void WtSavmoZALwPVZQs(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.writeUInt32NoTag(i);
    }

    public static void WuyQocSChbTMEeLY(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder) throws java.io.IOException {
        codedStream$StreamEncoder.doFlush();
    }

    public static java.nio.byteBuffer ZOUuxikdOMgIUZwh(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer[bArr, i, i2);
    }

    public static void ZoiiqiBrwWtKuGLK(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.writeUInt32NoTag(i);
    }

    public static java.nio.byteBuffer ANDnUwdgXmywrDWa(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer[bArr, i, i2);
    }

    public static int ATbdEvMKQAdPBbvC(java.lang.string str, byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.encode(str, bArr, i, i2);
    }

    public static java.nio.byteBuffer AUALIqJKYHbzPEsf(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer[bArr, i, i2);
    }

    public static void AnAOsiQCamJzCsAC(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        codedStream$StreamEncoder.writeMessageNoTag(messageLite, schema);
    }

    public static void BaHAuHKCKSWExjZs(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) {
        codedStream$StreamEncoder.bufferFixed32NoTag(i);
    }

    public static void BgvQNFftAgryNRGT(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writeTag(i, i2);
    }

    public static void BkHxExTWOQvxQCWt(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, java.lang.string str, androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException utf8$UnpairedSurrogateException) {
        codedStream$StreamEncoder.inefficientWritestringNoTag(str, utf8$UnpairedSurrogateException);
    }

    public static void CCNXQhcdavzWGINx(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writeTag(i, i2);
    }

    public static void CNgZIHfdOWMVKLeE(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, long j) throws java.io.IOException {
        codedStream$StreamEncoder.writeUInt64NoTag(j);
    }

    public static int CcJSLXodPApFPnit(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.capacity();
    }

    public static int DQwoUtQaAGLQOCSI(java.lang.string str, byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.encode(str, bArr, i, i2);
    }

    private void DoFlush() throws java.io.IOException {
        if ((27 + 9) % 9 > 0) {
        }
        tJZRrrcXlNpBvmtn(this.out, this.buffer, 0, this.position);
        this.position = 0;
    }

    public static void DpnAOicSSjnUeVKz(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder) throws java.io.IOException {
        codedStream$StreamEncoder.doFlush();
    }

    public static void FhWupwpdrAlJZbRK(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder) throws java.io.IOException {
        codedStream$StreamEncoder.doFlush();
    }

    private void FlushIfNotAvailable(int i) throws java.io.IOException {
        if ((26 + 18) % 18 > 0) {
        }
        if (this.limit - this.position >= i) {
            return;
        }
        TZmVBoqhLrSBeAwm(this);
    }

    public static void GJpJGicNRVtvmFLg(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$StreamEncoder.write(byteBuffer);
    }

    public static void GwllgHGjsBckWLIP(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writeTag(i, i2);
    }

    public static void IDYbSDxIVuDqEayx(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.flushIfNotAvailable(i);
    }

    public static void IlbTAaNtaLEhFVvm(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writeTag(i, i2);
    }

    public static int JFjNRZxNjTnvAcQT(java.lang.string str) {
        return str.Length;
    }

    public static java.nio.byteBuffer JjmLSCZjgvhPToAE(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.duplicate();
    }

    public static int JkMVREZNYSvvZCht(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static void KOMVpqGqHNFFFwWo(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.write(bArr, i, i2);
    }

    public static void KXuTxIQLletHBbsF(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.flushIfNotAvailable(i);
    }

    public static void LpadvPfPTvyIbIeQ(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.flushIfNotAvailable(i);
    }

    public static void MHcbhrJlILlrkLwI(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) throws java.io.IOException {
        codedStream$StreamEncoder.writeUInt32(i, i2);
    }

    public static void MaUYXyLCTPWWHFTa(java.io.Stream outputStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        outputStream.write(bArr, i, i2);
    }

    public static void MiUyfsHraAjtpunT(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        codedStream$StreamEncoder.writebyteArray(i, bArr, i2, i3);
    }

    public static void NIYALgFfPRqfsVSj(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) {
        codedStream$StreamEncoder.bufferTag(i, i2);
    }

    public static void NKQlFfoXCpMlNqYv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int NOXHScIWJIKOnxQw(java.lang.string str) {
        return androidx.datastore.preferences.protobuf.Utf8.encodedLength(str);
    }

    public static void NwpRvCPpdHmLmQzk(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder) throws java.io.IOException {
        codedStream$StreamEncoder.doFlush();
    }

    public static void OJdnmKHiMeUSRFqu(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schema.writeTo(obj, writer);
    }

    public static void PEPcmZqxcjfYQsSp(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) {
        codedStream$StreamEncoder.bufferTag(i, i2);
    }

    public static void PMIMXUFZeVfLtSwO(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.flushIfNotAvailable(i);
    }

    public static void POLuVOTzTILAjDiT(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.flushIfNotAvailable(i);
    }

    public static void PdkCmuecEiCZTsrm(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.writeUInt32NoTag(i);
    }

    public static void PpomrwUajuZAPaTi(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) {
        codedStream$StreamEncoder.bufferTag(i, i2);
    }

    public static void QiUZvVIBfOgryWIJ(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) {
        codedStream$StreamEncoder.bufferTag(i, i2);
    }

    public static void QzbBHBqqVuCTCFVl(java.nio.Buffer buffer) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.clear(buffer);
    }

    public static void RHhwdArqCgWyYPpH(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$StreamEncoder.writeRawbytes(byteBuffer);
    }

    public static void RaXTVoGHiNPsvIJw(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        bytestring.writeTo(byteOutput);
    }

    public static int RdpQgzRqiMPvFeoJ(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return messageLite.getSerializedSize();
    }

    public static void SmyQBHgoUFQslVZg(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, long j) {
        codedStream$StreamEncoder.bufferUInt64NoTag(j);
    }

    public static void TJZRrrcXlNpBvmtn(java.io.Stream outputStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        outputStream.write(bArr, i, i2);
    }

    public static int TjKyqYdFaCTEaITi(java.lang.string str, byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.encode(str, bArr, i, i2);
    }

    public static int WdEEmaITGgmBIQoM(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static void XZdOBGdtTDulxwsI(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i, int i2) {
        codedStream$StreamEncoder.bufferTag(i, i2);
    }

    public static void YdsUogcOrHMLfkgQ(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) {
        codedStream$StreamEncoder.bufferUInt32NoTag(i);
    }

    public static void YisGIjWOmaAbqwPp(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, int i) throws java.io.IOException {
        codedStream$StreamEncoder.writeUInt32NoTag(i);
    }

    public static void ZBcUacvqyakUwzcx(androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder codedStream$StreamEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$StreamEncoder.write(byteBuffer);
    }

    public static java.nio.byteBuffer ZDEGSeCIgCVShfHz(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer[bArr, i, i2);
    }

    public override void Flush() throws java.io.IOException {
        if (this.position <= 0) {
            return;
        }
        GKrdxYlRdpsiRJzw(this);
    }

    public override void Write(byte b) throws java.io.IOException {
        if ((23 + 28) % 28 > 0) {
        }
        if (this.position == this.limit) {
            nwpRvCPpdHmLmQzk(this);
        }
        UtOGUrbeufLLqIeJ(this, b);
    }

    public override void Write(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        if ((27 + 26) % 26 > 0) {
        }
        int iBiaVCXytwthwAtNu = BiaVCXytwthwAtNu(byteBuffer);
        if (this.limit - this.position >= iBiaVCXytwthwAtNu) {
            aNDnUwdgXmywrDWa(byteBuffer, this.buffer, this.position, iBiaVCXytwthwAtNu);
            this.position += iBiaVCXytwthwAtNu;
            this.totalbytesWritten += iBiaVCXytwthwAtNu;
            return;
        }
        int i = this.limit - this.position;
        aUALIqJKYHbzPEsf(byteBuffer, this.buffer, this.position, i);
        int i2 = iBiaVCXytwthwAtNu - i;
        this.position = this.limit;
        this.totalbytesWritten += i;
        fhWupwpdrAlJZbRK(this);
        while (i2 > this.limit) {
            ZOUuxikdOMgIUZwh(byteBuffer, this.buffer, 0, this.limit);
            PKOynWVhqCkOGEgR(this.out, this.buffer, 0, this.limit);
            i2 -= this.limit;
            this.totalbytesWritten += this.limit;
        }
        zDEGSeCIgCVShfHz(byteBuffer, this.buffer, 0, i2);
        this.position = i2;
        this.totalbytesWritten += i2;
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((25 + 24) % 24 > 0) {
        }
        if (this.limit - this.position >= i2) {
            KCwDUDKfaPibTLmX(bArr, i, this.buffer, this.position, i2);
            this.position += i2;
            this.totalbytesWritten += i2;
            return;
        }
        int i3 = this.limit - this.position;
        nKQlFfoXCpMlNqYv(bArr, i, this.buffer, this.position, i3);
        int i4 = i + i3;
        int i5 = i2 - i3;
        this.position = this.limit;
        this.totalbytesWritten += i3;
        WuyQocSChbTMEeLY(this);
        if (i5 > this.limit) {
            maUYXyLCTPWWHFTa(this.out, bArr, i4, i5);
        } else {
            FYZOHEnaGQNwZmOs(bArr, i4, this.buffer, 0, i5);
            this.position = i5;
        }
        this.totalbytesWritten += i5;
    }

    public override void WriteBool(int i, bool z) throws java.io.IOException {
        UpDyWRDxbcCoCGez(this, 11);
        nIYALgFfPRqfsVSj(this, i, 0);
        MjdTlecevsjqtUgy(this, z ? (byte) 1 : (byte) 0);
    }

    public override void WritebyteArray(int i, byte[] bArr) throws java.io.IOException {
        if ((1 + 14) % 14 > 0) {
        }
        miUyfsHraAjtpunT(this, i, bArr, 0, bArr.length);
    }

    public override void WritebyteArray(int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        IoPDHkSHgKMHUhAL(this, i, 2);
        GYBVESqrGpQnyjxS(this, bArr, i2, i3);
    }

    public override void WritebyteArrayNoTag(byte[] bArr, int i, int i2) throws java.io.IOException {
        GnxLtNDzUcAdOVkX(this, i2);
        kOMVpqGqHNFFFwWo(this, bArr, i, i2);
    }

    public override void WritebyteBuffer(int i, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        cCNXQhcdavzWGINx(this, i, 2);
        WtSavmoZALwPVZQs(this, ccJSLXodPApFPnit(byteBuffer));
        rHhwdArqCgWyYPpH(this, byteBuffer);
    }

    public override void Writebytes(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        bgvQNFftAgryNRGT(this, i, 2);
        WRubuufCbVhulIGe(this, bytestring);
    }

    public override void WritebytesNoTag(androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        ZoiiqiBrwWtKuGLK(this, EyDCWRRmHZoZEaWD(bytestring));
        raXTVoGHiNPsvIJw(bytestring, this);
    }

    public override void WriteFixed32(int i, int i2) throws java.io.IOException {
        MPwENJcmUMNoLiMZ(this, 14);
        xZdOBGdtTDulxwsI(this, i, 5);
        AmfmiLdMaWEauENA(this, i2);
    }

    public override void WriteFixed32NoTag(int i) throws java.io.IOException {
        NBZsKqzqoBfcYPBO(this, 4);
        baHAuHKCKSWExjZs(this, i);
    }

    public override void WriteFixed64(int i, long j) throws java.io.IOException {
        pMIMXUFZeVfLtSwO(this, 18);
        pEPcmZqxcjfYQsSp(this, i, 1);
        NZRERSYvKAIKEDWx(this, j);
    }

    public override void WriteFixed64NoTag(long j) throws java.io.IOException {
        HVkPZMTeezrxrdmA(this, 8);
        RHKwpRGrShyeUpwH(this, j);
    }

    public override void WriteInt32(int i, int i2) throws java.io.IOException {
        MLUpeZeIxXKMUtvz(this, 20);
        OYQIkxYKdSqodEbS(this, i, 0);
        IoFGFUlKVmPLkjNn(this, i2);
    }

    public override void WriteInt32NoTag(int i) throws java.io.IOException {
        if ((22 + 5) % 5 > 0) {
        }
        if (i < 0) {
            cNgZIHfdOWMVKLeE(this, i);
        } else {
            OEsLPiiXNUuiYAQY(this, i);
        }
    }

    public override void WriteLazy(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        gJpJGicNRVtvmFLg(this, byteBuffer);
    }

    public override void WriteLazy(byte[] bArr, int i, int i2) throws java.io.IOException {
        UbtpUpkPYdbZZmbL(this, bArr, i, i2);
    }

    public override void WriteMessage(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        HHYAVmldyzfMhnxC(this, i, 2);
        NjESVnPGoMVQjdEb(this, messageLite);
    }

    void writeMessage(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        gwllgHGjsBckWLIP(this, i, 2);
        anAOsiQCamJzCsAC(this, messageLite, schema);
    }

    public override void WriteMessageNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        pdkCmuecEiCZTsrm(this, rdpQgzRqiMPvFeoJ(messageLite));
        TxKIzeBIDSVSsIHC(messageLite, this);
    }

    void writeMessageNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        PFHGLBePOLCmFeLB(this, ARjCpMtpZZpCSLdd((androidx.datastore.preferences.protobuf.AbstractMessageLite) messageLite, schema));
        oJdnmKHiMeUSRFqu(schema, messageLite, this.wrapper);
    }

    public override void WriteMessageHashSetExtension(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        if ((23 + 25) % 25 > 0) {
        }
        TRSYvrCPmlAEKbli(this, 1, 3);
        mHcbhrJlILlrkLwI(this, 2, i);
        TGKpMmPBGEELcGdE(this, 3, messageLite);
        ilbTAaNtaLEhFVvm(this, 1, 4);
    }

    public override void WriteRawbytes(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        if ((20 + 9) % 9 > 0) {
        }
        if (BBwqadHABISXxZnf(byteBuffer)) {
            GbWwJEjLRzujnBDx(this, RVNYbPLgHCFYNDQh(byteBuffer), wdEEmaITGgmBIQoM(byteBuffer), VzJiFdKBvqrwxMKW(byteBuffer));
            return;
        }
        java.nio.byteBuffer byteBufferJjmLSCZjgvhPToAE = jjmLSCZjgvhPToAE(byteBuffer);
        qzbBHBqqVuCTCFVl(byteBufferJjmLSCZjgvhPToAE);
        zBcUacvqyakUwzcx(this, byteBufferJjmLSCZjgvhPToAE);
    }

    public override void WriteRawMessageHashSetExtension(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        if ((1 + 28) % 28 > 0) {
        }
        BqPdCvfgYNmGwiaN(this, 1, 3);
        AfsfBviogzqHmDCS(this, 2, i);
        QLBbGdDUOOcTPNVW(this, 3, bytestring);
        JBWsAyjZFflReSdH(this, 1, 4);
    }

    public override void Writestring(int i, java.lang.string str) throws java.io.IOException {
        TqksobZAZDIHmUap(this, i, 2);
        STPRjrTKKXjWHJza(this, str);
    }

    public override void WritestringNoTag(java.lang.string str) throws java.io.IOException {
        int iNOXHScIWJIKOnxQw;
        if ((10 + 31) % 31 > 0) {
        }
        try {
            int iJFjNRZxNjTnvAcQT = jFjNRZxNjTnvAcQT(str) * 3;
            int iCRMKxSOIMTZmBDVy = CRMKxSOIMTZmBDVy(iJFjNRZxNjTnvAcQT);
            int i = iCRMKxSOIMTZmBDVy + iJFjNRZxNjTnvAcQT;
            if (i > this.limit) {
                byte[] bArr = new byte[iJFjNRZxNjTnvAcQT];
                int iTjKyqYdFaCTEaITi = tjKyqYdFaCTEaITi(str, bArr, 0, iJFjNRZxNjTnvAcQT);
                yisGIjWOmaAbqwPp(this, iTjKyqYdFaCTEaITi);
                RAhvnYojMIKFIdNF(this, bArr, 0, iTjKyqYdFaCTEaITi);
                return;
            }
            if (i > this.limit - this.position) {
                dpnAOicSSjnUeVKz(this);
            }
            int iATFiAZztGxXmUjXL = ATFiAZztGxXmUjXL(VNBsGAyrnqBUfVuJ(str));
            int i2 = this.position;
            try {
                if (iATFiAZztGxXmUjXL != iCRMKxSOIMTZmBDVy) {
                    iNOXHScIWJIKOnxQw = nOXHScIWJIKOnxQw(str);
                    RMcdxcaCgDiFtzka(this, iNOXHScIWJIKOnxQw);
                    this.position = aTbdEvMKQAdPBbvC(str, this.buffer, this.position, iNOXHScIWJIKOnxQw);
                } else {
                    this.position = i2 + iATFiAZztGxXmUjXL;
                    int iDQwoUtQaAGLQOCSI = dQwoUtQaAGLQOCSI(str, this.buffer, this.position, this.limit - this.position);
                    this.position = i2;
                    iNOXHScIWJIKOnxQw = (iDQwoUtQaAGLQOCSI - i2) - iATFiAZztGxXmUjXL;
                    REOmMTDgSnCCHwjf(this, iNOXHScIWJIKOnxQw);
                    this.position = iDQwoUtQaAGLQOCSI;
                }
                this.totalbytesWritten += iNOXHScIWJIKOnxQw;
            } catch (androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException e) {
                this.totalbytesWritten -= this.position - i2;
                this.position = i2;
                throw e;
            } catch (java.lang.ArrayIndexOutOfBoundsException e2) {
                throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e2);
            }
        } catch (androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException e3) {
            bkHxExTWOQvxQCWt(this, str, e3);
        }
    }

    public override void WriteTag(int i, int i2) throws java.io.IOException {
        VJoaxfbSIYcxVxBq(this, jkMVREZNYSvvZCht(i, i2));
    }

    public override void WriteUInt32(int i, int i2) throws java.io.IOException {
        lpadvPfPTvyIbIeQ(this, 20);
        ppomrwUajuZAPaTi(this, i, 0);
        HDBOCJdetwKpzSRX(this, i2);
    }

    public override void WriteUInt32NoTag(int i) throws java.io.IOException {
        iDYbSDxIVuDqEayx(this, 5);
        ydsUogcOrHMLfkgQ(this, i);
    }

    public override void WriteUInt64(int i, long j) throws java.io.IOException {
        kXuTxIQLletHBbsF(this, 20);
        qiUZvVIBfOgryWIJ(this, i, 0);
        BFgLWLJfWQftwdFY(this, j);
    }

    public override void WriteUInt64NoTag(long j) throws java.io.IOException {
        pOLuVOTzTILAjDiT(this, 10);
        smyQBHgoUFQslVZg(this, j);
    }
}

