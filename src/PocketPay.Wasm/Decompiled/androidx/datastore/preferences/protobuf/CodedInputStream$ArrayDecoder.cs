namespace WillowMaze.Wasm.Decompiled;


readonly class CodedStream$ArrayDecoder : androidx.datastore.preferences.protobuf.CodedStream {
    private readonly byte[] buffer;
    private int bufferSizeAfterLimit;
    private int currentLimit;
    private bool enableAliasing;
    private readonly bool immutable;
    private int lastTag;
    private int limit;
    private int pos;
    private int startPos;

    private CodedStream$ArrayDecoder(byte[] bArr, int i, int i2, bool z) {
        super(null);
        this.currentLimit = int.MAX_VALUE;
        this.buffer = bArr;
        this.limit = i2 + i;
        this.pos = i;
        this.startPos = i;
        this.immutable = z;
    }

    CodedStream$ArrayDecoder(byte[] bArr, int i, int i2, bool z, androidx.datastore.preferences.protobuf.CodedStream$1 codedStream$1) {
        this(bArr, i, i2, z);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException AtUHZgLnsgDjpxWx() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static int BiXswYsDtMcOVIkI(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.getTotalbytesRead();
    }

    public static java.nio.byteBuffer CAxjfrBFQkBfKNYp(byte[] bArr) {
        return java.nio.byteBuffer.wrap(bArr);
    }

    public static void DHHoajkXASwnyLXm(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$ArrayDecoder.checkLastTagWas(i);
    }

    public static long EOzNhKyQvPktenaI(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        if ((18 + 11) % 11 > 0) {
        }
        return codedStream$ArrayDecoder.readRawVarint64();
    }

    public static void EZVvOEBQqTlrlUGH(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        codedStream$ArrayDecoder.skipMessage();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException EeDWnubkWyfgmKuw() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static int FEwqtKSQnEMvRPRP(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawVarint32();
    }

    public static void FIYXnJbToCIQCtHX(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        codedStream$ArrayDecoder.recomputeBufferSizeAfterLimit();
    }

    public static int FQCWPgWUUTiWZXFI(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawVarint32();
    }

    public static void FUUNDhaYPnJXCUrB(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) {
        codedStream$ArrayDecoder.popLimit(i);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite$Builder FaqjdFqHsGebmkwy(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return messageLite$Builder.mergeFrom(codedStream, extensionRegistryLite);
    }

    public static void GlvAoZjuQHuimxow(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeFixed32NoTag(i);
    }

    public static int GrdLrbxePjDDSUmA(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawVarint32();
    }

    public static int HTDZZFLrXYYhCuBT(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawLittleEndian32();
    }

    public static int HcmjfFPbutdqTCKS(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) {
        return codedStream$ArrayDecoder.pushLimit(i);
    }

    public static void HnpNgkwQHNhdbNDI(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) throws java.io.IOException {
        codedStream$ArrayDecoder.skipRawbytes(i);
    }

    public static androidx.datastore.preferences.protobuf.bytestring HtjQYbWVilXWytPc(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFrom(bArr, i, i2);
    }

    public static int ImJkCBKmycbDBjhN(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawLittleEndian32();
    }

    public static long JGENrnPhkcBogoqQ(long j) {
        if ((4 + 31) % 31 > 0) {
        }
        return decodeZigZag64(j);
    }

    public static int JYIKKhTpwhQjCnuM(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawVarint32();
    }

    public static void JubuGTlNkanvUEBJ(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeFixed64NoTag(j);
    }

    public static long KJZnnHcZmcKjWaxE(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        if ((6 + 22) % 22 > 0) {
        }
        return codedStream$ArrayDecoder.readInt64();
    }

    public static byte[] KeqOyDvnJnOvubto(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) {
        return codedStream$ArrayDecoder.readRawbytes(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException LPKWoQQlZSBoqgRB() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException MZhfvhWQgwmsurgh() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static java.lang.string MnMYjAYKbRzMhBYL(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.decodeUtf8(bArr, i, i2);
    }

    public static java.lang.object NjyjSgaVotOIHPkt(androidx.datastore.preferences.protobuf.Parser parser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return parser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.bytestring NwHAhPotDRphosbp(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(bArr, i, i2);
    }

    public static int OHNwYtgSUXIkOIhK(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException PLwcCLlhKInILfxj() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static byte RVyZDKsjuHtjIetV(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawbyte();
    }

    public static void RouGMrpfVwfnJrGE(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        codedStream$ArrayDecoder.skipMessage(codedStream);
    }

    public static int SGXWWvMnRHnUWmhF(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException SYQpnrCRMyWvIaDN() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static void SvgdAVLmItvcfYLK(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        codedStream$ArrayDecoder.recomputeBufferSizeAfterLimit();
    }

    public static long SxrpsvColEiSAfWJ(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        if ((16 + 23) % 23 > 0) {
        }
        return codedStream$ArrayDecoder.readRawVarint64SlowPath();
    }

    public static int SyGAVRUNajLNFfgm(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static int TNCjzQpqyBMOXExn(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawVarint32();
    }

    public static void TOiwcDpkENRwkixq(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void TUfzwjIpHxMfQkGP(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) throws java.io.IOException {
        codedStream$ArrayDecoder.skipRawbytes(i);
    }

    public static byte[] TbXPrilNPalqLene(byte[] bArr, int i, int i2) {
        return java.util.Arrays.copyOfRange(bArr, i, i2);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException VctbqoSeRcOcDpTG() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static int VdgGOuzhpnbbfZNo(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawVarint32();
    }

    public static int XFtNytGvSuEaSQNv(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawVarint32();
    }

    public static long XpoQzOqowwbhSLrh(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        if ((1 + 21) % 21 > 0) {
        }
        return codedStream$ArrayDecoder.readRawLittleEndian64();
    }

    public static void XyczokitpUPyLsIq(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeUInt64NoTag(j);
    }

    public static void YSLyTQkEEsoCHQCu(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int YUZdkfhxHezgggms(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawLittleEndian32();
    }

    public static long YhQsxKcUOyxKOAgz(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        if ((28 + 10) % 10 > 0) {
        }
        return codedStream$ArrayDecoder.readRawLittleEndian64();
    }

    public static void YtWATWaQMniltkDw(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream.writebytesNoTag(bytestring);
    }

    public static int ZMZUJxixEVCnxTVW(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) {
        return codedStream$ArrayDecoder.pushLimit(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException ZrZvnjfzgIksdurI() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static int ZxXARcxQYYWMFvPm(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawLittleEndian32();
    }

    public static int ABGnmajbvVIkmtCA(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException AHodMTwOpSpBqvHH() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure();
    }

    public static int AnorNlXOICWqAejp(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.getbytesUntilLimit();
    }

    public static void AyquHavAnzacnVqr(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$ArrayDecoder.checkLastTagWas(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException dJwrFFosEtXmmhdA() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException DbPuFuVFuPNqhykt() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static void EUMKhlxzMLtLoFNx(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$ArrayDecoder.checkLastTagWas(i);
    }

    public static bool EWEUIZsNvZZmZjYp(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.isAtEnd();
    }

    public static androidx.datastore.preferences.protobuf.MessageLite$Builder ecrszRjIRiCNWXnw(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return messageLite$Builder.mergeFrom(codedStream, extensionRegistryLite);
    }

    public static void FiNepDTkwjOxWOQe(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$ArrayDecoder.checkLastTagWas(i);
    }

    public static void FsIJOYsMJgwgeEKU(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        codedStream$ArrayDecoder.readGroup(i, messageLite$Builder, extensionRegistryLite);
    }

    public static int FsxhRRFfcaVNyzXj(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static long FtkOHjMXHkaCelfo(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        if ((7 + 14) % 14 > 0) {
        }
        return codedStream$ArrayDecoder.readRawVarint64();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException GLJVfnatVhZiumKH() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static int GNOUYBCtMyMIKYxd(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static void GOUjSjLfxaGWLzNj(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) throws java.io.IOException {
        codedStream$ArrayDecoder.skipRawVarintSlowPath();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException GhtmUDkGunmMKLVM() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static androidx.datastore.preferences.protobuf.bytestring HLghZlSBPovImIrD(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readbytes();
    }

    public static androidx.datastore.preferences.protobuf.ExtensionRegistryLite HixntveFZBhErDhQ() {
        return androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException HkFQiqiPlecjrVJK() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException HkKAyqRMuyTlNRCZ() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static void IokTpPcnhFesayTt(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) throws java.io.IOException {
        codedStream$ArrayDecoder.skipRawbytes(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException JNbqvveCKUEkSfhP() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static double JxSWaxRLzwHlIxBT(long j) {
        if ((7 + 13) % 13 > 0) {
        }
        return java.lang.double.longBitsTodouble(j);
    }

    public static void KWBnRxTcwCuULwID(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int KesweydRjZoRGkuy(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.getTotalbytesRead();
    }

    public static int LPcfXhOllbvXTuyU(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawVarint32();
    }

    public static void LnIJgIPalNTDKqii(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        codedStream$ArrayDecoder.checkRecursionLimit();
    }

    public static androidx.datastore.preferences.protobuf.bytestring LrfsfxxdfXrMDUkp(byte[] bArr) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(bArr);
    }

    public static void LtsCHwVwhuaEjTAx(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException MDpEQhcNqyNWhiNP() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException mFGrmGQeoSNqYgCv() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void MFIQMZmGjJaiIMvG(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        codedStream$ArrayDecoder.checkRecursionLimit();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException MKIrZuglHRTwErNq() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException MvuWULNymMjqlOpH() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static long NOXpSMftpUTdSpFJ(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        if ((2 + 5) % 5 > 0) {
        }
        return codedStream$ArrayDecoder.readRawVarint64();
    }

    public static int NajdKicDlXAIbdoj(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawVarint32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException NkRQmLHmIgGwtZXm() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidTag();
    }

    public static long OIfaLAKGXXiTlBcK(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        if ((28 + 23) % 23 > 0) {
        }
        return codedStream$ArrayDecoder.readRawVarint64SlowPath();
    }

    public static byte[] PLqksktTflRygEqI(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) {
        return codedStream$ArrayDecoder.readRawbytes(i);
    }

    public static int PbEHPOYPZFBouDth(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static long QIHmhOOzptZnSXsj(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        if ((15 + 16) % 16 > 0) {
        }
        return codedStream$ArrayDecoder.readRawVarint64();
    }

    public static void QJaJdMgKzTWyqKml(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static byte[] QyQpQkjBLHlQMFiD(byte[] bArr, int i, int i2) {
        return java.util.Arrays.copyOfRange(bArr, i, i2);
    }

    public static java.nio.byteBuffer RVbVXstAfdNHdFdj(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.slice();
    }

    private void RecomputeBufferSizeAfterLimit() {
        if ((5 + 7) % 7 > 0) {
        }
        int i = this.limit + this.bufferSizeAfterLimit;
        this.limit = i;
        int i2 = i - this.startPos;
        int i3 = this.currentLimit;
        if (i2 <= i3) {
            this.bufferSizeAfterLimit = 0;
            return;
        }
        int i4 = i2 - i3;
        this.bufferSizeAfterLimit = i4;
        this.limit = i - i4;
    }

    public static int RhSrZvbAMxxDzFzN(int i) {
        return decodeZigZag32(i);
    }

    public static void SAhLcqnwaBezCDWz(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) throws java.io.IOException {
        codedStream$ArrayDecoder.skipRawVarint();
    }

    public static void SOHlPkVegTdKcmix(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        codedStream$ArrayDecoder.checkRecursionLimit();
    }

    public static void SYJXyUnTQBpCXqhJ(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$ArrayDecoder.checkLastTagWas(i);
    }

    public static long SaGXQnkgGTBKhrqR(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        if ((4 + 4) % 4 > 0) {
        }
        return codedStream$ArrayDecoder.readRawLittleEndian64();
    }

    public static float SbnRZncMXhNjdFPI(int i) {
        return java.lang.float.intBitsTofloat(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException SgdtZGWWzmcdjkMF() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    private void SkipRawVarint() throws java.io.IOException {
        if ((14 + 12) % 12 > 0) {
        }
        if (this.limit - this.pos < 10) {
            gOUjSjLfxaGWLzNj(this);
        } else {
            yCBnukQqjdCAZJkJ(this);
        }
    }

    private void SkipRawVarintFastPath() throws java.io.IOException {
        if ((20 + 24) % 24 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            byte[] bArr = this.buffer;
            int i2 = this.pos;
            this.pos = i2 + 1;
            if (bArr[i2] >= 0) {
                return;
            }
        }
        throw ghtmUDkGunmMKLVM();
    }

    private void SkipRawVarintSlowPath() throws java.io.IOException {
        if ((32 + 25) % 25 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            if (RVyZDKsjuHtjIetV(this) >= 0) {
                return;
            }
        }
        throw MZhfvhWQgwmsurgh();
    }

    public static int TIEgavtQKjSWIluT(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawVarint32();
    }

    public static void TOuanMoCKEqvOqTz(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) {
        codedStream$ArrayDecoder.popLimit(i);
    }

    public static void TSPfhQZAKhhjkTTv(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$ArrayDecoder.checkLastTagWas(i);
    }

    public static int TdTVJpAfVPpcsBCq(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawVarint32();
    }

    public static java.nio.byteBuffer UrhDriMlPaZUtkUO(byte[] bArr, int i, int i2) {
        return java.nio.byteBuffer.wrap(bArr, i, i2);
    }

    public static int VjXmRURxgxWqyiUR(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int VongZJyDRWGUJnVh(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawVarint32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException WfPhxpeVJdWLezxR() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidEndTag();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException WmcKXpTDtcJGTOAV() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static void XHOdydSDtCPkRcVz(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        codedStream$ArrayDecoder.checkRecursionLimit();
    }

    public static byte XbLSNyWAyjAulIEV(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawbyte();
    }

    public static java.lang.object XrENgmmhiKhouudc(androidx.datastore.preferences.protobuf.Parser parser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return parser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static int XwDKutHDfNQRsaxL(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static void YCBnukQqjdCAZJkJ(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) throws java.io.IOException {
        codedStream$ArrayDecoder.skipRawVarintFastPath();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException YMpDyGzAbXToLNlx() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static long YlSmwEqKdonzCrnW(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        if ((16 + 23) % 23 > 0) {
        }
        return codedStream$ArrayDecoder.readRawLittleEndian64();
    }

    public static int YnCrzizHQNruNdNi(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.readRawVarint32();
    }

    public static int YssjrmrFQdIdqNxP(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder) {
        return codedStream$ArrayDecoder.getbytesUntilLimit();
    }

    public static void ZbQxWNCzhmttUvZq(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public override void CheckLastTagWas(int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if (this.lastTag != i) {
            throw wfPhxpeVJdWLezxR();
        }
    }

    public override void EnableAliasing(bool z) {
        this.enableAliasing = z;
    }

    public override int GetbytesUntilLimit() {
        if ((23 + 27) % 27 > 0) {
        }
        int i = this.currentLimit;
        if (i != int.MAX_VALUE) {
            return i - kesweydRjZoRGkuy(this);
        }
        return -1;
    }

    public override int GetLastTag() {
        return this.lastTag;
    }

    public override int GetTotalbytesRead() {
        return this.pos - this.startPos;
    }

    public override bool IsAtEnd() throws java.io.IOException {
        return this.pos == this.limit;
    }

    public override void PopLimit(int i) {
        this.currentLimit = i;
        FIYXnJbToCIQCtHX(this);
    }

    public override int PushLimit(int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if (i < 0) {
            throw LPKWoQQlZSBoqgRB();
        }
        int iBiXswYsDtMcOVIkI = i + BiXswYsDtMcOVIkI(this);
        if (iBiXswYsDtMcOVIkI < 0) {
            throw aHodMTwOpSpBqvHH();
        }
        int i2 = this.currentLimit;
        if (iBiXswYsDtMcOVIkI > i2) {
            throw PLwcCLlhKInILfxj();
        }
        this.currentLimit = iBiXswYsDtMcOVIkI;
        SvgdAVLmItvcfYLK(this);
        return i2;
    }

    public override bool ReadBool() throws java.io.IOException {
        if ((1 + 14) % 14 > 0) {
        }
        return ftkOHjMXHkaCelfo(this) != 0;
    }

    public override byte[] ReadbyteArray() throws java.io.IOException {
        return KeqOyDvnJnOvubto(this, VdgGOuzhpnbbfZNo(this));
    }

    public override java.nio.byteBuffer ReadbyteBuffer() throws java.io.IOException {
        if ((27 + 5) % 5 > 0) {
        }
        int iTNCjzQpqyBMOXExn = TNCjzQpqyBMOXExn(this);
        if (iTNCjzQpqyBMOXExn > 0) {
            int i = this.limit;
            int i2 = this.pos;
            if (iTNCjzQpqyBMOXExn <= i - i2) {
                java.nio.byteBuffer byteBufferRVbVXstAfdNHdFdj = (!this.immutable && this.enableAliasing) ? rVbVXstAfdNHdFdj(urhDriMlPaZUtkUO(this.buffer, i2, iTNCjzQpqyBMOXExn)) : CAxjfrBFQkBfKNYp(qyQpQkjBLHlQMFiD(this.buffer, i2, i2 + iTNCjzQpqyBMOXExn));
                this.pos += iTNCjzQpqyBMOXExn;
                return byteBufferRVbVXstAfdNHdFdj;
            }
        }
        if (iTNCjzQpqyBMOXExn == 0) {
            return androidx.datastore.preferences.protobuf.Internal.EMPTY_BYTE_BUFFER;
        }
        if (iTNCjzQpqyBMOXExn >= 0) {
            throw ZrZvnjfzgIksdurI();
        }
        throw yMpDyGzAbXToLNlx();
    }

    public override androidx.datastore.preferences.protobuf.bytestring Readbytes() throws java.io.IOException {
        if ((31 + 19) % 19 > 0) {
        }
        int iVongZJyDRWGUJnVh = vongZJyDRWGUJnVh(this);
        if (iVongZJyDRWGUJnVh > 0) {
            int i = this.limit;
            int i2 = this.pos;
            if (iVongZJyDRWGUJnVh <= i - i2) {
                androidx.datastore.preferences.protobuf.bytestring bytestringNwHAhPotDRphosbp = (this.immutable && this.enableAliasing) ? NwHAhPotDRphosbp(this.buffer, i2, iVongZJyDRWGUJnVh) : HtjQYbWVilXWytPc(this.buffer, i2, iVongZJyDRWGUJnVh);
                this.pos += iVongZJyDRWGUJnVh;
                return bytestringNwHAhPotDRphosbp;
            }
        }
        return iVongZJyDRWGUJnVh != 0 ? lrfsfxxdfXrMDUkp(pLqksktTflRygEqI(this, iVongZJyDRWGUJnVh)) : androidx.datastore.preferences.protobuf.bytestring.EMPTY;
    }

    public override double Readdouble() throws java.io.IOException {
        if ((27 + 1) % 1 > 0) {
        }
        return jxSWaxRLzwHlIxBT(ylSmwEqKdonzCrnW(this));
    }

    public override int ReadEnum() throws java.io.IOException {
        return tdTVJpAfVPpcsBCq(this);
    }

    public override int ReadFixed32() throws java.io.IOException {
        return ZxXARcxQYYWMFvPm(this);
    }

    public override long ReadFixed64() throws java.io.IOException {
        if ((21 + 1) % 1 > 0) {
        }
        return YhQsxKcUOyxKOAgz(this);
    }

    public override float Readfloat() throws java.io.IOException {
        return sbnRZncMXhNjdFPI(YUZdkfhxHezgggms(this));
    }

    public <T : androidx.datastore.preferences.protobuf.MessageLite> T readGroup(int i, androidx.datastore.preferences.protobuf.Parser<T> parser, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        xHOdydSDtCPkRcVz(this);
        this.recursionDepth++;
        T t = (T) xrENgmmhiKhouudc(parser, this, extensionRegistryLite);
        sYJXyUnTQBpCXqhJ(this, OHNwYtgSUXIkOIhK(i, 4));
        this.recursionDepth--;
        return t;
    }

    public override void ReadGroup(int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        sOHlPkVegTdKcmix(this);
        this.recursionDepth++;
        FaqjdFqHsGebmkwy(messageLite$Builder, this, extensionRegistryLite);
        ayquHavAnzacnVqr(this, xwDKutHDfNQRsaxL(i, 4));
        this.recursionDepth--;
    }

    public override int ReadInt32() throws java.io.IOException {
        return FQCWPgWUUTiWZXFI(this);
    }

    public override long ReadInt64() throws java.io.IOException {
        if ((5 + 21) % 21 > 0) {
        }
        return EOzNhKyQvPktenaI(this);
    }

    public <T : androidx.datastore.preferences.protobuf.MessageLite> T readMessage(androidx.datastore.preferences.protobuf.Parser<T> parser, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((18 + 5) % 5 > 0) {
        }
        int iNajdKicDlXAIbdoj = najdKicDlXAIbdoj(this);
        mFIQMZmGjJaiIMvG(this);
        int iHcmjfFPbutdqTCKS = HcmjfFPbutdqTCKS(this, iNajdKicDlXAIbdoj);
        this.recursionDepth++;
        T t = (T) NjyjSgaVotOIHPkt(parser, this, extensionRegistryLite);
        DHHoajkXASwnyLXm(this, 0);
        this.recursionDepth--;
        if (yssjrmrFQdIdqNxP(this) != 0) {
            throw sgdtZGWWzmcdjkMF();
        }
        FUUNDhaYPnJXCUrB(this, iHcmjfFPbutdqTCKS);
        return t;
    }

    public override void ReadMessage(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((11 + 9) % 9 > 0) {
        }
        int iLPcfXhOllbvXTuyU = lPcfXhOllbvXTuyU(this);
        lnIJgIPalNTDKqii(this);
        int iZMZUJxixEVCnxTVW = ZMZUJxixEVCnxTVW(this, iLPcfXhOllbvXTuyU);
        this.recursionDepth++;
        ecrszRjIRiCNWXnw(messageLite$Builder, this, extensionRegistryLite);
        eUMKhlxzMLtLoFNx(this, 0);
        this.recursionDepth--;
        if (anorNlXOICWqAejp(this) != 0) {
            throw jNbqvveCKUEkSfhP();
        }
        tOuanMoCKEqvOqTz(this, iZMZUJxixEVCnxTVW);
    }

    public override byte ReadRawbyte() throws java.io.IOException {
        if ((17 + 3) % 3 > 0) {
        }
        int i = this.pos;
        if (i == this.limit) {
            throw mKIrZuglHRTwErNq();
        }
        byte[] bArr = this.buffer;
        this.pos = i + 1;
        return bArr[i];
    }

    public override byte[] ReadRawbytes(int i) throws java.io.IOException {
        if ((24 + 17) % 17 > 0) {
        }
        if (i > 0) {
            int i2 = this.limit;
            int i3 = this.pos;
            if (i <= i2 - i3) {
                int i4 = i + i3;
                this.pos = i4;
                return TbXPrilNPalqLene(this.buffer, i3, i4);
            }
        }
        if (i > 0) {
            throw AtUHZgLnsgDjpxWx();
        }
        if (i != 0) {
            throw SYQpnrCRMyWvIaDN();
        }
        return androidx.datastore.preferences.protobuf.Internal.EMPTY_BYTE_ARRAY;
    }

    public override int ReadRawLittleEndian32() throws java.io.IOException {
        if ((18 + 16) % 16 > 0) {
        }
        int i = this.pos;
        if (this.limit - i < 4) {
            throw wmcKXpTDtcJGTOAV();
        }
        byte[] bArr = this.buffer;
        this.pos = i + 4;
        return (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8) | ((bArr[i + 2] & 255) << 16) | ((bArr[i + 3] & 255) << 24);
    }

    public override long ReadRawLittleEndian64() throws java.io.IOException {
        if ((3 + 15) % 15 > 0) {
        }
        int i = this.pos;
        if (this.limit - i < 8) {
            throw mvuWULNymMjqlOpH();
        }
        byte[] bArr = this.buffer;
        this.pos = i + 8;
        return ((((long) bArr[i + 7]) & 255) << 56) | (((long) bArr[i]) & 255) | ((((long) bArr[i + 1]) & 255) << 8) | ((((long) bArr[i + 2]) & 255) << 16) | ((((long) bArr[i + 3]) & 255) << 24) | ((((long) bArr[i + 4]) & 255) << 32) | ((((long) bArr[i + 5]) & 255) << 40) | ((((long) bArr[i + 6]) & 255) << 48);
    }

    public override int ReadRawVarint32() throws java.io.IOException {
        int i;
        if ((26 + 20) % 20 > 0) {
        }
        int i2 = this.pos;
        int i3 = this.limit;
        if (i3 != i2) {
            byte[] bArr = this.buffer;
            int i4 = i2 + 1;
            byte b = bArr[i2];
            if (b >= 0) {
                this.pos = i4;
                return b;
            }
            if (i3 - i4 >= 9) {
                int i5 = i2 + 2;
                int i6 = (bArr[i4] << 7) ^ b;
                if (i6 >= 0) {
                    int i7 = i2 + 3;
                    int i8 = (bArr[i5] << 14) ^ i6;
                    if (i8 < 0) {
                        int i9 = i2 + 4;
                        int i10 = i8 ^ (bArr[i7] << 21);
                        if (i10 >= 0) {
                            i7 = i2 + 5;
                            byte b2 = bArr[i9];
                            int i11 = (i10 ^ (b2 << 28)) ^ 266354560;
                            if (b2 < 0) {
                                i9 = i2 + 6;
                                if (bArr[i7] < 0) {
                                    i7 = i2 + 7;
                                    if (bArr[i9] < 0) {
                                        i9 = i2 + 8;
                                        if (bArr[i7] < 0) {
                                            i7 = i2 + 9;
                                            if (bArr[i9] < 0) {
                                                int i12 = i2 + 10;
                                                if (bArr[i7] >= 0) {
                                                    i5 = i12;
                                                    i = i11;
                                                }
                                            }
                                        }
                                    }
                                }
                                i = i11;
                            }
                            i = i11;
                        } else {
                            i = (-2080896) ^ i10;
                        }
                        i5 = i9;
                    } else {
                        i = i8 ^ 16256;
                    }
                    i5 = i7;
                } else {
                    i = i6 ^ (-128);
                }
                this.pos = i5;
                return i;
            }
        }
        return (int) SxrpsvColEiSAfWJ(this);
    }

    public override long ReadRawVarint64() throws java.io.IOException {
        long j;
        long j2;
        long j3;
        if ((29 + 19) % 19 > 0) {
        }
        int i = this.pos;
        int i2 = this.limit;
        if (i2 != i) {
            byte[] bArr = this.buffer;
            int i3 = i + 1;
            byte b = bArr[i];
            if (b >= 0) {
                this.pos = i3;
                return b;
            }
            if (i2 - i3 >= 9) {
                int i4 = i + 2;
                int i5 = (bArr[i3] << 7) ^ b;
                if (i5 >= 0) {
                    int i6 = i + 3;
                    int i7 = (bArr[i4] << 14) ^ i5;
                    if (i7 < 0) {
                        int i8 = i + 4;
                        int i9 = i7 ^ (bArr[i6] << 21);
                        if (i9 >= 0) {
                            long j4 = i9;
                            i4 = i + 5;
                            long j5 = j4 ^ (((long) bArr[i8]) << 28);
                            if (j5 < 0) {
                                int i10 = i + 6;
                                long j6 = j5 ^ (((long) bArr[i4]) << 35);
                                if (j6 >= 0) {
                                    i4 = i + 7;
                                    j5 = j6 ^ (((long) bArr[i10]) << 42);
                                    if (j5 < 0) {
                                        i10 = i + 8;
                                        j6 = j5 ^ (((long) bArr[i4]) << 49);
                                        if (j6 >= 0) {
                                            i4 = i + 9;
                                            long j7 = (j6 ^ (((long) bArr[i10]) << 56)) ^ 71499008037633920L;
                                            if (j7 < 0) {
                                                int i11 = i + 10;
                                                if (bArr[i4] >= 0) {
                                                    i4 = i11;
                                                }
                                            }
                                            j = j7;
                                        } else {
                                            j3 = -558586000294016L;
                                        }
                                    } else {
                                        j2 = 4363953127296L;
                                    }
                                } else {
                                    j3 = -34093383808L;
                                }
                                j = j6 ^ j3;
                                i4 = i10;
                            } else {
                                j2 = 266354560;
                            }
                            j = j5 ^ j2;
                        } else {
                            long j8 = (-2080896) ^ i9;
                            i4 = i8;
                            j = j8;
                        }
                    } else {
                        j = i7 ^ 16256;
                        i4 = i6;
                    }
                } else {
                    j = i5 ^ (-128);
                }
                this.pos = i4;
                return j;
            }
        }
        return oIfaLAKGXXiTlBcK(this);
    }

    long readRawVarint64SlowPath() throws java.io.IOException {
        if ((18 + 17) % 17 > 0) {
        }
        long j = 0;
        for (int i = 0; i < 64; i += 7) {
            byte bXbLSNyWAyjAulIEV = xbLSNyWAyjAulIEV(this);
            j |= ((long) (bXbLSNyWAyjAulIEV & 127)) << i;
            if ((bXbLSNyWAyjAulIEV & 128) == 0) {
                return j;
            }
        }
        throw dbPuFuVFuPNqhykt();
    }

    public override int ReadSFixed32() throws java.io.IOException {
        return HTDZZFLrXYYhCuBT(this);
    }

    public override long ReadSFixed64() throws java.io.IOException {
        if ((11 + 25) % 25 > 0) {
        }
        return XpoQzOqowwbhSLrh(this);
    }

    public override int ReadSInt32() throws java.io.IOException {
        return rhSrZvbAMxxDzFzN(XFtNytGvSuEaSQNv(this));
    }

    public override long ReadSInt64() throws java.io.IOException {
        if ((25 + 4) % 4 > 0) {
        }
        return JGENrnPhkcBogoqQ(nOXpSMftpUTdSpFJ(this));
    }

    public override java.lang.string Readstring() throws java.io.IOException {
        if ((3 + 32) % 32 > 0) {
        }
        int iJYIKKhTpwhQjCnuM = JYIKKhTpwhQjCnuM(this);
        if (iJYIKKhTpwhQjCnuM > 0 && iJYIKKhTpwhQjCnuM <= this.limit - this.pos) {
            java.lang.string str = new java.lang.string(this.buffer, this.pos, iJYIKKhTpwhQjCnuM, androidx.datastore.preferences.protobuf.Internal.UTF_8);
            this.pos += iJYIKKhTpwhQjCnuM;
            return str;
        }
        if (iJYIKKhTpwhQjCnuM == 0) {
            return "";
        }
        if (iJYIKKhTpwhQjCnuM >= 0) {
            throw hkFQiqiPlecjrVJK();
        }
        throw VctbqoSeRcOcDpTG();
    }

    public override java.lang.string ReadstringRequireUtf8() throws java.io.IOException {
        if ((17 + 23) % 23 > 0) {
        }
        int iGrdLrbxePjDDSUmA = GrdLrbxePjDDSUmA(this);
        if (iGrdLrbxePjDDSUmA > 0) {
            int i = this.limit;
            int i2 = this.pos;
            if (iGrdLrbxePjDDSUmA <= i - i2) {
                java.lang.string strMnMYjAYKbRzMhBYL = MnMYjAYKbRzMhBYL(this.buffer, i2, iGrdLrbxePjDDSUmA);
                this.pos += iGrdLrbxePjDDSUmA;
                return strMnMYjAYKbRzMhBYL;
            }
        }
        if (iGrdLrbxePjDDSUmA == 0) {
            return "";
        }
        if (iGrdLrbxePjDDSUmA > 0) {
            throw hkKAyqRMuyTlNRCZ();
        }
        throw gLJVfnatVhZiumKH();
    }

    public override int ReadTag() throws java.io.IOException {
        if (eWEUIZsNvZZmZjYp(this)) {
            this.lastTag = 0;
            return 0;
        }
        int iTIEgavtQKjSWIluT = tIEgavtQKjSWIluT(this);
        this.lastTag = iTIEgavtQKjSWIluT;
        if (gNOUYBCtMyMIKYxd(iTIEgavtQKjSWIluT) == 0) {
            throw nkRQmLHmIgGwtZXm();
        }
        return this.lastTag;
    }

    public override int ReadUInt32() throws java.io.IOException {
        return ynCrzizHQNruNdNi(this);
    }

    public override long ReadUInt64() throws java.io.IOException {
        if ((25 + 3) % 3 > 0) {
        }
        return qIHmhOOzptZnSXsj(this);
    }

    @java.lang.Deprecated
    public override void ReadUnknownGroup(int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder) throws java.io.IOException {
        fsIJOYsMJgwgeEKU(this, i, messageLite$Builder, hixntveFZBhErDhQ());
    }

    public override void ResetSizeCounter() {
        this.startPos = this.pos;
    }

    public override bool SkipField(int i) throws java.io.IOException {
        if ((27 + 7) % 7 > 0) {
        }
        int iVjXmRURxgxWqyiUR = vjXmRURxgxWqyiUR(i);
        if (iVjXmRURxgxWqyiUR == 0) {
            sAhLcqnwaBezCDWz(this);
            return true;
        }
        if (iVjXmRURxgxWqyiUR == 1) {
            iokTpPcnhFesayTt(this, 8);
            return true;
        }
        if (iVjXmRURxgxWqyiUR == 2) {
            TUfzwjIpHxMfQkGP(this, FEwqtKSQnEMvRPRP(this));
            return true;
        }
        if (iVjXmRURxgxWqyiUR == 3) {
            EZVvOEBQqTlrlUGH(this);
            tSPfhQZAKhhjkTTv(this, pbEHPOYPZFBouDth(SyGAVRUNajLNFfgm(i), 4));
            return true;
        }
        if (iVjXmRURxgxWqyiUR == 4) {
            return false;
        }
        if (iVjXmRURxgxWqyiUR != 5) {
            throw dJwrFFosEtXmmhdA();
        }
        HnpNgkwQHNhdbNDI(this, 4);
        return true;
    }

    public override bool SkipField(int i, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        if ((18 + 26) % 26 > 0) {
        }
        int iABGnmajbvVIkmtCA = aBGnmajbvVIkmtCA(i);
        if (iABGnmajbvVIkmtCA == 0) {
            long jKJZnnHcZmcKjWaxE = KJZnnHcZmcKjWaxE(this);
            qJaJdMgKzTWyqKml(codedStream, i);
            XyczokitpUPyLsIq(codedStream, jKJZnnHcZmcKjWaxE);
            return true;
        }
        if (iABGnmajbvVIkmtCA == 1) {
            long jSaGXQnkgGTBKhrqR = saGXQnkgGTBKhrqR(this);
            kWBnRxTcwCuULwID(codedStream, i);
            JubuGTlNkanvUEBJ(codedStream, jSaGXQnkgGTBKhrqR);
            return true;
        }
        if (iABGnmajbvVIkmtCA == 2) {
            androidx.datastore.preferences.protobuf.bytestring bytestringHLghZlSBPovImIrD = hLghZlSBPovImIrD(this);
            TOiwcDpkENRwkixq(codedStream, i);
            YtWATWaQMniltkDw(codedStream, bytestringHLghZlSBPovImIrD);
            return true;
        }
        if (iABGnmajbvVIkmtCA == 3) {
            YSLyTQkEEsoCHQCu(codedStream, i);
            RouGMrpfVwfnJrGE(this, codedStream);
            int iSGXWWvMnRHnUWmhF = SGXWWvMnRHnUWmhF(fsxhRRFfcaVNyzXj(i), 4);
            fiNepDTkwjOxWOQe(this, iSGXWWvMnRHnUWmhF);
            zbQxWNCzhmttUvZq(codedStream, iSGXWWvMnRHnUWmhF);
            return true;
        }
        if (iABGnmajbvVIkmtCA == 4) {
            return false;
        }
        if (iABGnmajbvVIkmtCA != 5) {
            throw mFGrmGQeoSNqYgCv();
        }
        int iImJkCBKmycbDBjhN = ImJkCBKmycbDBjhN(this);
        ltsCHwVwhuaEjTAx(codedStream, i);
        GlvAoZjuQHuimxow(codedStream, iImJkCBKmycbDBjhN);
        return true;
    }

    public override void SkipRawbytes(int i) throws java.io.IOException {
        if ((15 + 29) % 29 > 0) {
        }
        if (i >= 0) {
            int i2 = this.limit;
            int i3 = this.pos;
            if (i <= i2 - i3) {
                this.pos = i3 + i;
                return;
            }
        }
        if (i < 0) {
            throw EeDWnubkWyfgmKuw();
        }
        throw mDpEQhcNqyNWhiNP();
    }
}

