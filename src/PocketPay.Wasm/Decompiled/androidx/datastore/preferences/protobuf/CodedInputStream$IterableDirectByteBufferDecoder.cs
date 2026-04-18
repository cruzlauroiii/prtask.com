namespace WillowMaze.Wasm.Decompiled;


readonly class CodedStream$IEnumerableDirectbyteBufferDecoder : androidx.datastore.preferences.protobuf.CodedStream {
    private int bufferSizeAfterCurrentLimit;
    private long currentAddress;
    private java.nio.byteBuffer currentbyteBuffer;
    private long currentbyteBufferLimit;
    private long currentbyteBufferPos;
    private long currentbyteBufferStartPos;
    private int currentLimit;
    private bool enableAliasing;
    private readonly bool immutable;
    private readonly java.lang.IEnumerable<java.nio.byteBuffer> input;
    private readonly java.util.IEnumerator<java.nio.byteBuffer> iterator;
    private int lastTag;
    private int startOffset;
    private int totalBufferSize;
    private int totalbytesRead;

    private CodedStream$IEnumerableDirectbyteBufferDecoder(java.lang.IEnumerable<java.nio.byteBuffer> iterable, int i, bool z) {
        super(null);
        this.currentLimit = int.MAX_VALUE;
        this.totalBufferSize = i;
        this.input = iterable;
        this.iterator = HTMsLRXHbbAiRoDy(iterable);
        this.immutable = z;
        this.totalbytesRead = 0;
        this.startOffset = 0;
        if (i != 0) {
            aitArNPzKCivouYo(this);
            return;
        }
        this.currentbyteBuffer = androidx.datastore.preferences.protobuf.Internal.EMPTY_BYTE_BUFFER;
        this.currentbyteBufferPos = 0L;
        this.currentbyteBufferStartPos = 0L;
        this.currentbyteBufferLimit = 0L;
        this.currentAddress = 0L;
    }

    CodedStream$IEnumerableDirectbyteBufferDecoder(java.lang.IEnumerable iterable, int i, bool z, androidx.datastore.preferences.protobuf.CodedStream$1 codedStream$1) {
        this(iterable, i, z);
    }

    public static byte ADNyMDBXxysGmyru(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException ANPgsazVGlmkxOvr() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static byte AxcRfNdJKvYpRbxG(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void AyWGpjMzKPFXJjSS(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeFixed64NoTag(j);
    }

    public static long BApCerKNgzqSmgIB(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((26 + 20) % 20 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.currentRemaining();
    }

    public static void BIaKNpGpjnIzyIvi(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$IEnumerableDirectbyteBufferDecoder.checkLastTagWas(i);
    }

    public static java.nio.byteBuffer BjINtirIRoVdZdIN(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i, int i2) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.slice(i, i2);
    }

    public static int CSICZtWJOuEEOGTW(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static void CqSnvrWrqcxaeJFi(long j, byte[] bArr, long j2, long j3) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.copyMemory(j, bArr, j2, j3);
    }

    public static int DQHVclnJwWChIGjA(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.getbytesUntilLimit();
    }

    public static byte DSOsbCJKYkwhvYoN(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static java.nio.byteBuffer DVeHnpxbopjenXwX(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i, int i2) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.slice(i, i2);
    }

    public static java.lang.object DpJhBSLMKalRKiLg(androidx.datastore.preferences.protobuf.Parser parser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return parser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static void DqqnKoETqUbnuqVO(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$IEnumerableDirectbyteBufferDecoder.readRawbytesTo(bArr, i, i2);
    }

    public static int DzaeDpeYcqABzPfy(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.limit();
    }

    public static long EHAsHCiUhXkqvobQ(long j) {
        if ((2 + 11) % 11 > 0) {
        }
        return decodeZigZag64(j);
    }

    public static void EUpRJxxsmWUhEYEV(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) throws java.io.IOException {
        codedStream$IEnumerableDirectbyteBufferDecoder.skipRawbytes(i);
    }

    public static byte EXbfpHNxipYXEFyA(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static void EfubzzuNToNyRcoj(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) throws java.io.IOException {
        codedStream$IEnumerableDirectbyteBufferDecoder.skipRawVarint();
    }

    public static void FdhLHtoWkmUfEbsc(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$IEnumerableDirectbyteBufferDecoder.getNextbyteBuffer();
    }

    public static void FhCsegzTpfdRCSbJ(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int FqoYOIOqHgxhYEXc(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.remaining();
    }

    public static androidx.datastore.preferences.protobuf.MessageLite$Builder FsEhYtlUBEFqhDsQ(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return messageLite$Builder.mergeFrom(codedStream, extensionRegistryLite);
    }

    public static byte FysZFjruUTDJqKaT(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static byte GFIerjHtxvOCKCik(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static long GIPzOqCofbgCeAFx(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((2 + 12) % 12 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint64SlowPath();
    }

    public static java.nio.Buffer GMFPKRfudKhIssCC(java.nio.Buffer buffer, int i) {
        return buffer.position(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException GewgfATYaDQnqLFi() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException GfsctwKwSTeAvOQh() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static java.nio.Buffer GlddcxdxALzWnzHm(java.nio.Buffer buffer, int i) {
        return buffer.limit(i);
    }

    public static void GqsDxbOdDapgWvqC(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$IEnumerableDirectbyteBufferDecoder.checkLastTagWas(i);
    }

    public static void HFaOKIuHhXDzRSFw(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$IEnumerableDirectbyteBufferDecoder.checkLastTagWas(i);
    }

    public static java.util.IEnumerator HTMsLRXHbbAiRoDy(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static androidx.datastore.preferences.protobuf.ExtensionRegistryLite HbyXNTRFLhLqKGEg() {
        return androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry();
    }

    public static byte HeSSGgDsqRQyxJeC(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static byte HpNqnLUKEyEFpPQO(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static void HrkUkEYDcHznFOEq(long j, byte[] bArr, long j2, long j3) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.copyMemory(j, bArr, j2, j3);
    }

    public static int IGrbyDxIFLfbHLNu(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint32();
    }

    public static byte IfDjNJnqGzCEnklI(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void JHSiYsiIEoHePfyK(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        codedStream$IEnumerableDirectbyteBufferDecoder.skipMessage();
    }

    public static long JQEsEtWDqfsHHOpz(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((13 + 22) % 22 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint64();
    }

    public static int JvhVnZtEdIzurOWY(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.pushLimit(i);
    }

    public static java.nio.byteBuffer KECbSkbTJhtaZzWo(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i, int i2) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.slice(i, i2);
    }

    public static androidx.datastore.preferences.protobuf.bytestring KIndupIuSmARqhov(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readbytes();
    }

    public static int KIzqKkESDhzORmbG(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static java.lang.object KTZTkOIBUPklIxFi(java.util.IEnumerator it) {
        return it.Current;
    }

    public static androidx.datastore.preferences.protobuf.bytestring KbAUcxTBOjARTcBr(byte[] bArr) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(bArr);
    }

    public static void KeknIjNvkhCjtPXG(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$IEnumerableDirectbyteBufferDecoder.checkLastTagWas(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException KhiPUOvfoZanllvP() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidEndTag();
    }

    public static java.lang.string KifnprXXCBiMzRQi(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.decodeUtf8(bArr, i, i2);
    }

    public static java.nio.byteBuffer KvonpLLkbIQdppsJ(byte[] bArr) {
        return java.nio.byteBuffer.wrap(bArr);
    }

    public static void LMKjhmzEPNgroTWy(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$IEnumerableDirectbyteBufferDecoder.checkLastTagWas(i);
    }

    public static int LQxUiZlGcawwOFgL(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.remaining();
    }

    public static byte LzZARlhhGIScxeCA(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static void MDVaTLCAIrIJSNlU(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static double MRftlkxpLvyYRfOW(long j) {
        if ((7 + 31) % 31 > 0) {
        }
        return java.lang.double.longBitsTodouble(j);
    }

    public static byte MScmrWJwFWfNtKCD(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static void MdmfVwuWVJqvcdKg(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$IEnumerableDirectbyteBufferDecoder.getNextbyteBuffer();
    }

    public static long NBpYMelsSbcZHDnz(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((26 + 30) % 30 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawLittleEndian64();
    }

    public static byte NehtCZLxgeCOQrsS(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static byte NxEHaCkICrnzSuNb(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static int OKWDMUbXxvoLfxNe(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.remaining();
    }

    public static long OPMnZCymBhDSVyyB(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((32 + 3) % 3 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawLittleEndian64();
    }

    public static int OZfYQyfyPwZYxzKD(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.getbytesUntilLimit();
    }

    public static int OzpCNxGvnQTWtqhq(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int PNqMIvUIqEFsVhJy(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.getTotalbytesRead();
    }

    public static byte PTVPgdDHogPGsgFT(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static byte PamuoERrsYSTldHM(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void PfPtoBkKZbzvXRmw(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        codedStream$IEnumerableDirectbyteBufferDecoder.recomputeBufferSizeAfterLimit();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException PgfEHCwNzBrpeJLN() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static byte PiBqhNVrXyoegZpP(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static java.lang.string PoYbnoecwJStHfLU(java.nio.byteBuffer byteBuffer, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.decodeUtf8(byteBuffer, i, i2);
    }

    public static int QXVUSjzCnURrYVnj(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.getTotalbytesRead();
    }

    public static int QdXmrQHMBKyfLSSF(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static void QvqjoTGAzMUNqBar(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$IEnumerableDirectbyteBufferDecoder.getNextbyteBuffer();
    }

    public static int RGknJHDFggFYmIOg(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint32();
    }

    public static androidx.datastore.preferences.protobuf.bytestring RMXqNkotyrpDgxpP(byte[] bArr) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(bArr);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException RXmaYMdjHAhAtVFG() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static void ReTJiSeMAvqRtQzD(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeFixed32NoTag(i);
    }

    public static androidx.datastore.preferences.protobuf.bytestring RgRsyAphWZRlyDJc(java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(byteBuffer);
    }

    public static java.lang.object SBDLeJAixqVOWRiZ(androidx.datastore.preferences.protobuf.Parser parser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return parser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static long SGCyzsSHPgufPVcT(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((1 + 30) % 30 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawLittleEndian64();
    }

    public static void SUzqtSkhxbHgxkEP(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        codedStream$IEnumerableDirectbyteBufferDecoder.skipMessage(codedStream);
    }

    public static java.nio.Buffer SWYfaICClksLULAc(java.nio.Buffer buffer, int i) {
        return buffer.limit(i);
    }

    public static void SYTTvpqEyrIEsORx(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException SbnHXxoEfRsNEkDD() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static void ScLJYeiWuGHJpDdA(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int SkcSdxEtxmWqaevp(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawLittleEndian32();
    }

    public static void SyYwIVZfLbNRmrPD(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) throws java.io.IOException {
        codedStream$IEnumerableDirectbyteBufferDecoder.skipRawbytes(i);
    }

    public static long TAdPkqeLJJamkvxi(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((23 + 6) % 6 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.currentRemaining();
    }

    public static byte TXrstkNOjWERgevv(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static int TkxwVsRwClWVZbqI(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int TnLIfMQFCuSXTMav(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void UBaZDogfwMpXHjHt(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$IEnumerableDirectbyteBufferDecoder.getNextbyteBuffer();
    }

    public static int UileLqdBwijEdTDe(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint32();
    }

    public static int UviyPOyndKsKXLlg(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint32();
    }

    public static byte UxnvKYISSbbgGrCY(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static int UyzLcxcyYKPnoTxn(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static void VbIdTNbqdmPhOWnA(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$IEnumerableDirectbyteBufferDecoder.readRawbytesTo(bArr, i, i2);
    }

    public static byte VhvgvvygLzrROwyQ(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static byte VisYvFwUNvFMyxeV(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void VtPmqVtYrvuETyxB(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$IEnumerableDirectbyteBufferDecoder.readRawbytesTo(bArr, i, i2);
    }

    public static bool WKMAjhpxQAGLcLFf(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException WQbWbrkUgvVdLctE() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static byte WRyAbwirlLGwMBFS(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static int WdLFqKuweUpbvSFw(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException WgulxfnryHpQUhUX() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static byte WwZzfcNFNyyaaBHQ(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static byte XPCNxTccToIOpEGA(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static int XZIcDyNRXBOiqEaC(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint32();
    }

    public static int XopzsEuQgRvxVydq(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.remaining();
    }

    public static int XouDawvbKnfByiww(int i) {
        return decodeZigZag32(i);
    }

    public static long XtwrttVBLhwyvJee(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((18 + 14) % 14 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.currentRemaining();
    }

    public static int YIgChHHpTtbFFCdO(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.remaining();
    }

    public static byte YOMagYPKVcZcgCuS(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void YQjoxFmypwiKfIWH(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        codedStream$IEnumerableDirectbyteBufferDecoder.checkRecursionLimit();
    }

    public static byte YRCatpdhBZUOzhZn(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void YYtvGYLcriJRjmnn(long j, byte[] bArr, long j2, long j3) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.copyMemory(j, bArr, j2, j3);
    }

    public static java.nio.byteBuffer YbZnHsTvHYybRwyq(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.slice();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException YdlCyYyFwjWmhPJN() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static int ZBxDYsHfDwjKizRz(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static void ZKJRHAczfwXrUIQV(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$IEnumerableDirectbyteBufferDecoder.readRawbytesTo(bArr, i, i2);
    }

    public static byte ZuMcCkRLmVurofSy(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static int ZvdMESXBGpRVdPDc(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint32();
    }

    public static long AJNOCLfZUsRsKRxV(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((13 + 13) % 13 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.currentRemaining();
    }

    public static int ALFsvdVNeIVripOS(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.limit();
    }

    public static byte AZrGJQykGhxkoaWu(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static bool AdhWQPOjsxixhJPB(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.isAtEnd();
    }

    public static void AitArNPzKCivouYo(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        codedStream$IEnumerableDirectbyteBufferDecoder.tryGetNextbyteBuffer();
    }

    public static androidx.datastore.preferences.protobuf.MessageLite$Builder bHYJGPNyIepbFHdQ(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return messageLite$Builder.mergeFrom(codedStream, extensionRegistryLite);
    }

    public static byte BlepktDpbVyEAqjv(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static long BqhxANJPoyRraGcZ(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((21 + 12) % 12 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.readInt64();
    }

    public static byte BsbESENMMmVSkNjy(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void CGuviszqAmaKuEap(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeUInt64NoTag(j);
    }

    public static long CdZwFHkyfqeibFFB(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((5 + 21) % 21 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.currentRemaining();
    }

    private long CurrentRemaining() {
        if ((27 + 29) % 29 > 0) {
        }
        return this.currentbyteBufferLimit - this.currentbyteBufferPos;
    }

    public static long EFHwpCDAYhuBvDDO(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((3 + 25) % 25 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint64SlowPath();
    }

    public static int EQfvooyEotMmJgbA(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawLittleEndian32();
    }

    public static void EgXlnnGgqxWgcHry(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        codedStream$IEnumerableDirectbyteBufferDecoder.tryGetNextbyteBuffer();
    }

    public static long EhwTJlXWhdiTitFt(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((17 + 19) % 19 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.currentRemaining();
    }

    public static int EscaHiixmwTqNTYU(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static long EtcqLJysqOQdKnsO(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((1 + 28) % 28 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.currentRemaining();
    }

    public static void FGFpfPRXnSpGdmAA(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream.writebytesNoTag(bytestring);
    }

    public static void FOWIVLJwJdtSPlOP(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        codedStream$IEnumerableDirectbyteBufferDecoder.checkRecursionLimit();
    }

    public static int FmCvclYaXCGFlsnn(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint32();
    }

    public static int GKoNgsvYVEyFbbNF(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void GLKRXRoKxnfKJxaB(long j, byte[] bArr, long j2, long j3) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.copyMemory(j, bArr, j2, j3);
    }

    public static byte GQEAtVgnSdFOEiVV(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void GeShwPNdeFfzwcps(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        codedStream$IEnumerableDirectbyteBufferDecoder.checkRecursionLimit();
    }

    private void GetNextbyteBuffer() throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if (!WKMAjhpxQAGLcLFf(this.iterator)) {
            throw toQYkhmdnobYynGB();
        }
        egXlnnGgqxWgcHry(this);
    }

    public static byte GilObQeOkteAerLQ(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static androidx.datastore.preferences.protobuf.bytestring GmftFzIisvPvAeTb(java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException GsvZqPtzsfLuCpgJ() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static void HbixvkUeJosfyAji(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$IEnumerableDirectbyteBufferDecoder.readRawbytesTo(bArr, i, i2);
    }

    public static int HcLboZILdrweDuBe(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawLittleEndian32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException HmWoCmxrRObojSGJ() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static long HvJhXGtfGUskeAQq(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((8 + 23) % 23 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.currentRemaining();
    }

    public static void IBlnBkYnvQlDMmuZ(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        codedStream$IEnumerableDirectbyteBufferDecoder.readGroup(i, messageLite$Builder, extensionRegistryLite);
    }

    public static byte ImKSgcmnRlOOfflc(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static int JwuMvIYjbCFHjFSY(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static void KPKbUEphWMgvDxar(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int KgOXxhwzzGqbDjdS(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint32();
    }

    public static void KrQFCjuQEPrBCaES(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        codedStream$IEnumerableDirectbyteBufferDecoder.recomputeBufferSizeAfterLimit();
    }

    public static void LNqMOWImWJyDXdoq(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        codedStream$IEnumerableDirectbyteBufferDecoder.checkRecursionLimit();
    }

    public static long MNUDxRfnPsaXQcFk(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((32 + 1) % 1 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint64();
    }

    public static byte MObxlUrJVxeRTIaL(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void MQmZWAmOOkAdKaah(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) {
        codedStream$IEnumerableDirectbyteBufferDecoder.popLimit(i);
    }

    public static void MagHyieUdGMnyHrG(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) throws java.io.IOException {
        codedStream$IEnumerableDirectbyteBufferDecoder.skipRawbytes(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException MdXbYmBCkBFmjinP() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static long NGtLLyBGCniayJnd(java.nio.byteBuffer byteBuffer) {
        if ((11 + 21) % 21 > 0) {
        }
        return androidx.datastore.preferences.protobuf.UnsafeUtil.addressOffset(byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.bytestring OFqXlbmwDmWFaPxw(java.lang.IEnumerable iterable) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFrom((java.lang.IEnumerable<androidx.datastore.preferences.protobuf.bytestring>) iterable);
    }

    public static void OPvfzJoFkhvOmjlv(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int OVHkLDbPYRmxxfXO(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint32();
    }

    public static byte OkMCXpzpnvYuhBoO(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException OlhINeajRpcaPXEC() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException OoghYBSVBsfGTWea() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static byte[] OtuAJeQodnpSoJHd(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbytes(i);
    }

    public static void PFKrjdiihqFEWqKq(long j, byte[] bArr, long j2, long j3) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.copyMemory(j, bArr, j2, j3);
    }

    public static byte PHieOlhjrzwHbswl(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static long PbfWQHPuoVrkSGrg(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((17 + 27) % 27 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.currentRemaining();
    }

    public static int PdtASgNlRobTseLv(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.pushLimit(i);
    }

    public static long PouxVPcOGRqzkJtq(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((4 + 28) % 28 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint64();
    }

    public static byte PrjzzltOTkRXhtvs(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static java.nio.Buffer QDuDwYScFHsYNHxe(java.nio.Buffer buffer, int i) {
        return buffer.position(i);
    }

    public static byte QFZhRnhICzdMBnqD(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static java.nio.byteBuffer QRhOioDzHWpNsuor(byte[] bArr) {
        return java.nio.byteBuffer.wrap(bArr);
    }

    public static java.nio.Buffer QikRXttfqUgpgUpj(java.nio.Buffer buffer, int i) {
        return buffer.limit(i);
    }

    public static byte QqYsiDfxTwsLiLTo(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static int RHVPHKzoUEEJUPtM(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint32();
    }

    public static byte RZphYmcyzMaMNfIv(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    private void ReadRawbytesTo(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((28 + 31) % 31 > 0) {
        }
        if (i2 < 0 || i2 > FqoYOIOqHgxhYEXc(this)) {
            if (i2 > 0) {
                throw hmWoCmxrRObojSGJ();
            }
            if (i2 != 0) {
                throw PgfEHCwNzBrpeJLN();
            }
            return;
        }
        int i3 = i2;
        while (i3 > 0) {
            if (aJNOCLfZUsRsKRxV(this) == 0) {
                UBaZDogfwMpXHjHt(this);
            }
            int iOzpCNxGvnQTWtqhq = OzpCNxGvnQTWtqhq(i3, (int) etcqLJysqOQdKnsO(this));
            long j = iOzpCNxGvnQTWtqhq;
            pFKrjdiihqFEWqKq(this.currentbyteBufferPos, bArr, (i2 - i3) + i, j);
            i3 -= iOzpCNxGvnQTWtqhq;
            this.currentbyteBufferPos += j;
        }
    }

    private void RecomputeBufferSizeAfterLimit() {
        if ((15 + 13) % 13 > 0) {
        }
        int i = this.totalBufferSize + this.bufferSizeAfterCurrentLimit;
        this.totalBufferSize = i;
        int i2 = i - this.startOffset;
        int i3 = this.currentLimit;
        if (i2 <= i3) {
            this.bufferSizeAfterCurrentLimit = 0;
            return;
        }
        int i4 = i2 - i3;
        this.bufferSizeAfterCurrentLimit = i4;
        this.totalBufferSize = i - i4;
    }

    private int Remaining() {
        if ((2 + 16) % 16 > 0) {
        }
        return (int) ((((long) (this.totalBufferSize - this.totalbytesRead)) - this.currentbyteBufferPos) + this.currentbyteBufferStartPos);
    }

    public static int RfVQHGTzuiMNywbB(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint32();
    }

    public static byte RnhANcAUHgsTmVOI(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static java.nio.Buffer RoByDDtLhalpaESi(java.nio.Buffer buffer, int i) {
        return buffer.position(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException SAbEoSRkXsrkhibc() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException SOLeoXoBHHHjQADI() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException SWPuifEBxpZZAxRz() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    private void SkipRawVarint() throws java.io.IOException {
        if ((27 + 5) % 5 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            if (WwZzfcNFNyyaaBHQ(this) >= 0) {
                return;
            }
        }
        throw olhINeajRpcaPXEC();
    }

    /*  JADX ERROR: JadxException in pass: BlockSplitter
        jadx.core.utils.exceptions.JadxException: Unexpected missing predecessor for block: B:7:0x0019
        	at jadx.core.dex.visitors.blocks.BlockSplitter.addTempConnectionsForExcHandlers(BlockSplitter.java:280)
        	at jadx.core.dex.visitors.blocks.BlockSplitter.visit(BlockSplitter.java:79)
        */
    private java.nio.byteBuffer Slice(int r4, int r5) throws java.io.IOException {
        /*
            r3 = this;
            goto L22
        L4:
            java.nio.byteBuffer r0 = r3.currentbyteBuffer
            goto L10
        La:
            int r0 = r0 % r1
            goto L3c
        L10:
            int r0 = CSICZtWJOuEEOGTW(r0)
            goto L29
        L18:
            goto L1e
        L19:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r3 = zTLnFkSbNNFJFbMk()     // Catch: java.lang.Exception -> L37
            throw r3     // Catch: java.lang.Exception -> L37
        L1e:
            goto L57
        L22:
            goto L61
        L25:
            goto L78
        L29:
            java.nio.byteBuffer r1 = r3.currentbyteBuffer
            goto L89
        L2f:
            goto L6d
        L32:
            goto L4
        L36:
            return r3
        L37:
            r3 = move-exception
            goto L18
        L3c:
            if (r0 <= 0) goto L41
            goto L32
        L41:
            goto L2f
        L45:
            java.nio.byteBuffer r2 = r3.currentbyteBuffer
            roByDDtLhalpaESi(r2, r4)     // Catch: java.lang.IllegalArgumentException -> L19 java.lang.Exception -> L37
            SWYfaICClksLULAc(r2, r5)     // Catch: java.lang.IllegalArgumentException -> L19 java.lang.Exception -> L37
            java.nio.byteBuffer r3 = r3.currentbyteBuffer     // Catch: java.lang.IllegalArgumentException -> L19 java.lang.Exception -> L37
            java.nio.byteBuffer r3 = YbZnHsTvHYybRwyq(r3)     // Catch: java.lang.IllegalArgumentException -> L19 java.lang.Exception -> L37
            goto L65
        L57:
            qDuDwYScFHsYNHxe(r2, r0)
            goto L71
        L5e:
            goto L32
        L61:
            goto L86
        L65:
            GMFPKRfudKhIssCC(r2, r0)
            goto L91
        L6c:
            throw r3
        L6d:
            goto L5e
        L71:
            GlddcxdxALzWnzHm(r2, r1)
            goto L6c
        L78:
            r0 = 21
            goto L7f
        L7f:
            r1 = 32
            goto L98
        L86:
            goto L25
        L89:
            int r1 = DzaeDpeYcqABzPfy(r1)
            goto L45
        L91:
            qikRXttfqUgpgUpj(r2, r1)
            goto L36
        L98:
            int r0 = r0 + r1
            goto La
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder.slice(int, int):java.nio.byteBuffer");
    }

    public static byte TJpqjOgvcLFYgLGr(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static int TXqiMDUunPZfJYqO(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint32();
    }

    public static byte TYXXIjYKrajRLBWl(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException tklQdfPHWeBVYZmM() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static long TnAjszYxajxIjEoS(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((8 + 25) % 25 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint64();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException ToQYkhmdnobYynGB() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    private void TryGetNextbyteBuffer() {
        if ((4 + 4) % 4 > 0) {
        }
        java.nio.byteBuffer byteBuffer = (java.nio.byteBuffer) KTZTkOIBUPklIxFi(this.iterator);
        this.currentbyteBuffer = byteBuffer;
        this.totalbytesRead += (int) (this.currentbyteBufferPos - this.currentbyteBufferStartPos);
        long jEscaHiixmwTqNTYU = escaHiixmwTqNTYU(byteBuffer);
        this.currentbyteBufferPos = jEscaHiixmwTqNTYU;
        this.currentbyteBufferStartPos = jEscaHiixmwTqNTYU;
        this.currentbyteBufferLimit = aLFsvdVNeIVripOS(this.currentbyteBuffer);
        long jNGtLLyBGCniayJnd = nGtLLyBGCniayJnd(this.currentbyteBuffer);
        this.currentAddress = jNGtLLyBGCniayJnd;
        this.currentbyteBufferPos += jNGtLLyBGCniayJnd;
        this.currentbyteBufferStartPos += jNGtLLyBGCniayJnd;
        this.currentbyteBufferLimit += jNGtLLyBGCniayJnd;
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException UEFCcVSzgVeXAhGr() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static void UfsZDWlXFtsjEgpe(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$IEnumerableDirectbyteBufferDecoder.checkLastTagWas(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException VHmAhOYxUxAIwUuL() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidTag();
    }

    public static byte WYimJgntfhjDAnlP(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static int WhRhBuIykfJUhrQo(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawVarint32();
    }

    public static int WpGzUZFHXpfhxfmi(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.remaining();
    }

    public static byte XWAuyZemPuSNelTf(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawbyte();
    }

    public static byte XfqooNQStAqdDmVO(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static byte XkslFmtWllGiBHCx(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static long YDrECACborIzvxya(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((13 + 21) % 21 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawLittleEndian64();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException YFaXqWlhYzblUzRS() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static int YKyWxhwIjEbiYiuh(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static byte YRPgAHjJVPFAhWyr(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static long YlKazUVoizXguDRU(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((10 + 30) % 30 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.currentRemaining();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException YxqEpfuLSXWvTxhP() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static int ZJyirQmOrAmYdttl(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        return codedStream$IEnumerableDirectbyteBufferDecoder.readRawLittleEndian32();
    }

    public static long ZMwRBXeAsTzgGRnE(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder) {
        if ((30 + 19) % 19 > 0) {
        }
        return codedStream$IEnumerableDirectbyteBufferDecoder.currentRemaining();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException ZTLnFkSbNNFJFbMk() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static void ZhkwKmCsyFRtQaDs(androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder codedStream$IEnumerableDirectbyteBufferDecoder, int i) {
        codedStream$IEnumerableDirectbyteBufferDecoder.popLimit(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException ZmHPwRVpsMdOJQkF() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static int ZmJgchrhMyJwXeEo(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static bool ZqcAVvTZvKSoqnwI(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static float ZrFFJXnGIPoackxC(int i) {
        return java.lang.float.intBitsTofloat(i);
    }

    public override void CheckLastTagWas(int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if (this.lastTag != i) {
            throw KhiPUOvfoZanllvP();
        }
    }

    public override void EnableAliasing(bool z) {
        this.enableAliasing = z;
    }

    public override int GetbytesUntilLimit() {
        if ((3 + 32) % 32 > 0) {
        }
        int i = this.currentLimit;
        if (i != int.MAX_VALUE) {
            return i - QXVUSjzCnURrYVnj(this);
        }
        return -1;
    }

    public override int GetLastTag() {
        return this.lastTag;
    }

    public override int GetTotalbytesRead() {
        if ((16 + 1) % 1 > 0) {
        }
        return (int) ((((long) (this.totalbytesRead - this.startOffset)) + this.currentbyteBufferPos) - this.currentbyteBufferStartPos);
    }

    public override bool IsAtEnd() throws java.io.IOException {
        if ((9 + 7) % 7 > 0) {
        }
        return (((long) this.totalbytesRead) + this.currentbyteBufferPos) - this.currentbyteBufferStartPos == ((long) this.totalBufferSize);
    }

    public override void PopLimit(int i) {
        this.currentLimit = i;
        krQFCjuQEPrBCaES(this);
    }

    public override int PushLimit(int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if (i < 0) {
            throw mdXbYmBCkBFmjinP();
        }
        int iPNqMIvUIqEFsVhJy = i + PNqMIvUIqEFsVhJy(this);
        int i2 = this.currentLimit;
        if (iPNqMIvUIqEFsVhJy > i2) {
            throw WQbWbrkUgvVdLctE();
        }
        this.currentLimit = iPNqMIvUIqEFsVhJy;
        PfPtoBkKZbzvXRmw(this);
        return i2;
    }

    public override bool ReadBool() throws java.io.IOException {
        if ((23 + 2) % 2 > 0) {
        }
        return tnAjszYxajxIjEoS(this) != 0;
    }

    public override byte[] ReadbyteArray() throws java.io.IOException {
        return otuAJeQodnpSoJHd(this, RGknJHDFggFYmIOg(this));
    }

    public override java.nio.byteBuffer ReadbyteBuffer() throws java.io.IOException {
        if ((32 + 4) % 4 > 0) {
        }
        int iOVHkLDbPYRmxxfXO = oVHkLDbPYRmxxfXO(this);
        if (iOVHkLDbPYRmxxfXO > 0) {
            long j = iOVHkLDbPYRmxxfXO;
            if (j <= ylKazUVoizXguDRU(this)) {
                if (!this.immutable && this.enableAliasing) {
                    long j2 = this.currentbyteBufferPos + j;
                    this.currentbyteBufferPos = j2;
                    long j3 = this.currentAddress;
                    return BjINtirIRoVdZdIN(this, (int) ((j2 - j3) - j), (int) (j2 - j3));
                }
                byte[] bArr = new byte[iOVHkLDbPYRmxxfXO];
                CqSnvrWrqcxaeJFi(this.currentbyteBufferPos, bArr, 0L, j);
                this.currentbyteBufferPos += j;
                return qRhOioDzHWpNsuor(bArr);
            }
        }
        if (iOVHkLDbPYRmxxfXO > 0 && iOVHkLDbPYRmxxfXO <= OKWDMUbXxvoLfxNe(this)) {
            byte[] bArr2 = new byte[iOVHkLDbPYRmxxfXO];
            ZKJRHAczfwXrUIQV(this, bArr2, 0, iOVHkLDbPYRmxxfXO);
            return KvonpLLkbIQdppsJ(bArr2);
        }
        if (iOVHkLDbPYRmxxfXO == 0) {
            return androidx.datastore.preferences.protobuf.Internal.EMPTY_BYTE_BUFFER;
        }
        if (iOVHkLDbPYRmxxfXO >= 0) {
            throw gsvZqPtzsfLuCpgJ();
        }
        throw ooghYBSVBsfGTWea();
    }

    public override androidx.datastore.preferences.protobuf.bytestring Readbytes() throws java.io.IOException {
        if ((10 + 6) % 6 > 0) {
        }
        int iUileLqdBwijEdTDe = UileLqdBwijEdTDe(this);
        if (iUileLqdBwijEdTDe > 0) {
            long j = iUileLqdBwijEdTDe;
            long j2 = this.currentbyteBufferLimit;
            long j3 = this.currentbyteBufferPos;
            if (j <= j2 - j3) {
                if (this.immutable && this.enableAliasing) {
                    int i = (int) (j3 - this.currentAddress);
                    androidx.datastore.preferences.protobuf.bytestring bytestringRgRsyAphWZRlyDJc = RgRsyAphWZRlyDJc(DVeHnpxbopjenXwX(this, i, iUileLqdBwijEdTDe + i));
                    this.currentbyteBufferPos += j;
                    return bytestringRgRsyAphWZRlyDJc;
                }
                byte[] bArr = new byte[iUileLqdBwijEdTDe];
                gLKRXRoKxnfKJxaB(j3, bArr, 0L, j);
                this.currentbyteBufferPos += j;
                return RMXqNkotyrpDgxpP(bArr);
            }
        }
        if (iUileLqdBwijEdTDe <= 0 || iUileLqdBwijEdTDe > wpGzUZFHXpfhxfmi(this)) {
            if (iUileLqdBwijEdTDe == 0) {
                return androidx.datastore.preferences.protobuf.bytestring.EMPTY;
            }
            if (iUileLqdBwijEdTDe >= 0) {
                throw uEFCcVSzgVeXAhGr();
            }
            throw sOLeoXoBHHHjQADI();
        }
        if (!this.immutable || !this.enableAliasing) {
            byte[] bArr2 = new byte[iUileLqdBwijEdTDe];
            VbIdTNbqdmPhOWnA(this, bArr2, 0, iUileLqdBwijEdTDe);
            return KbAUcxTBOjARTcBr(bArr2);
        }
        java.util.List arrayList = new java.util.List();
        while (iUileLqdBwijEdTDe > 0) {
            if (XtwrttVBLhwyvJee(this) == 0) {
                FdhLHtoWkmUfEbsc(this);
            }
            int iTnLIfMQFCuSXTMav = TnLIfMQFCuSXTMav(iUileLqdBwijEdTDe, (int) zMwRBXeAsTzgGRnE(this));
            int i2 = (int) (this.currentbyteBufferPos - this.currentAddress);
            zqcAVvTZvKSoqnwI(arrayList, gmftFzIisvPvAeTb(KECbSkbTJhtaZzWo(this, i2, i2 + iTnLIfMQFCuSXTMav)));
            iUileLqdBwijEdTDe -= iTnLIfMQFCuSXTMav;
            this.currentbyteBufferPos += (long) iTnLIfMQFCuSXTMav;
        }
        return oFqXlbmwDmWFaPxw(arrayList);
    }

    public override double Readdouble() throws java.io.IOException {
        if ((13 + 25) % 25 > 0) {
        }
        return MRftlkxpLvyYRfOW(OPMnZCymBhDSVyyB(this));
    }

    public override int ReadEnum() throws java.io.IOException {
        return IGrbyDxIFLfbHLNu(this);
    }

    public override int ReadFixed32() throws java.io.IOException {
        return zJyirQmOrAmYdttl(this);
    }

    public override long ReadFixed64() throws java.io.IOException {
        if ((5 + 25) % 25 > 0) {
        }
        return yDrECACborIzvxya(this);
    }

    public override float Readfloat() throws java.io.IOException {
        return zrFFJXnGIPoackxC(hcLboZILdrweDuBe(this));
    }

    public <T : androidx.datastore.preferences.protobuf.MessageLite> T readGroup(int i, androidx.datastore.preferences.protobuf.Parser<T> parser, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        lNqMOWImWJyDXdoq(this);
        this.recursionDepth++;
        T t = (T) DpJhBSLMKalRKiLg(parser, this, extensionRegistryLite);
        HFaOKIuHhXDzRSFw(this, KIzqKkESDhzORmbG(i, 4));
        this.recursionDepth--;
        return t;
    }

    public override void ReadGroup(int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        geShwPNdeFfzwcps(this);
        this.recursionDepth++;
        FsEhYtlUBEFqhDsQ(messageLite$Builder, this, extensionRegistryLite);
        GqsDxbOdDapgWvqC(this, yKyWxhwIjEbiYiuh(i, 4));
        this.recursionDepth--;
    }

    public override int ReadInt32() throws java.io.IOException {
        return rHVPHKzoUEEJUPtM(this);
    }

    public override long ReadInt64() throws java.io.IOException {
        if ((9 + 27) % 27 > 0) {
        }
        return JQEsEtWDqfsHHOpz(this);
    }

    public <T : androidx.datastore.preferences.protobuf.MessageLite> T readMessage(androidx.datastore.preferences.protobuf.Parser<T> parser, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((6 + 17) % 17 > 0) {
        }
        int iWhRhBuIykfJUhrQo = whRhBuIykfJUhrQo(this);
        fOWIVLJwJdtSPlOP(this);
        int iJvhVnZtEdIzurOWY = JvhVnZtEdIzurOWY(this, iWhRhBuIykfJUhrQo);
        this.recursionDepth++;
        T t = (T) SBDLeJAixqVOWRiZ(parser, this, extensionRegistryLite);
        KeknIjNvkhCjtPXG(this, 0);
        this.recursionDepth--;
        if (DQHVclnJwWChIGjA(this) != 0) {
            throw yxqEpfuLSXWvTxhP();
        }
        zhkwKmCsyFRtQaDs(this, iJvhVnZtEdIzurOWY);
        return t;
    }

    public override void ReadMessage(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((3 + 6) % 6 > 0) {
        }
        int iZvdMESXBGpRVdPDc = ZvdMESXBGpRVdPDc(this);
        YQjoxFmypwiKfIWH(this);
        int iPdtASgNlRobTseLv = pdtASgNlRobTseLv(this, iZvdMESXBGpRVdPDc);
        this.recursionDepth++;
        bHYJGPNyIepbFHdQ(messageLite$Builder, this, extensionRegistryLite);
        BIaKNpGpjnIzyIvi(this, 0);
        this.recursionDepth--;
        if (OZfYQyfyPwZYxzKD(this) != 0) {
            throw zmHPwRVpsMdOJQkF();
        }
        mQmZWAmOOkAdKaah(this, iPdtASgNlRobTseLv);
    }

    public override byte ReadRawbyte() throws java.io.IOException {
        if ((29 + 28) % 28 > 0) {
        }
        if (TAdPkqeLJJamkvxi(this) == 0) {
            QvqjoTGAzMUNqBar(this);
        }
        long j = this.currentbyteBufferPos;
        this.currentbyteBufferPos = 1 + j;
        return AxcRfNdJKvYpRbxG(j);
    }

    public override byte[] ReadRawbytes(int i) throws java.io.IOException {
        if ((26 + 26) % 26 > 0) {
        }
        if (i >= 0) {
            long j = i;
            if (j <= hvJhXGtfGUskeAQq(this)) {
                byte[] bArr = new byte[i];
                YYtvGYLcriJRjmnn(this.currentbyteBufferPos, bArr, 0L, j);
                this.currentbyteBufferPos += j;
                return bArr;
            }
        }
        if (i >= 0 && i <= LQxUiZlGcawwOFgL(this)) {
            byte[] bArr2 = new byte[i];
            VtPmqVtYrvuETyxB(this, bArr2, 0, i);
            return bArr2;
        }
        if (i > 0) {
            throw sAbEoSRkXsrkhibc();
        }
        if (i != 0) {
            throw GewgfATYaDQnqLFi();
        }
        return androidx.datastore.preferences.protobuf.Internal.EMPTY_BYTE_ARRAY;
    }

    public override int ReadRawLittleEndian32() throws java.io.IOException {
        if ((25 + 20) % 20 > 0) {
        }
        if (cdZwFHkyfqeibFFB(this) < 4) {
            return ((ZuMcCkRLmVurofSy(this) & 255) << 24) | (xWAuyZemPuSNelTf(this) & 255) | ((TXrstkNOjWERgevv(this) & 255) << 8) | ((WRyAbwirlLGwMBFS(this) & 255) << 16);
        }
        long j = this.currentbyteBufferPos;
        this.currentbyteBufferPos = 4 + j;
        return (rnhANcAUHgsTmVOI(j) & 255) | ((gilObQeOkteAerLQ(1 + j) & 255) << 8) | ((ADNyMDBXxysGmyru(2 + j) & 255) << 16) | ((FysZFjruUTDJqKaT(j + 3) & 255) << 24);
    }

    public override long ReadRawLittleEndian64() throws java.io.IOException {
        if ((21 + 8) % 8 > 0) {
        }
        if (BApCerKNgzqSmgIB(this) < 8) {
            return ((((long) LzZARlhhGIScxeCA(this)) & 255) << 56) | (((long) EXbfpHNxipYXEFyA(this)) & 255) | ((((long) NehtCZLxgeCOQrsS(this)) & 255) << 8) | ((((long) qqYsiDfxTwsLiLTo(this)) & 255) << 16) | ((((long) DSOsbCJKYkwhvYoN(this)) & 255) << 24) | ((((long) imKSgcmnRlOOfflc(this)) & 255) << 32) | ((((long) MScmrWJwFWfNtKCD(this)) & 255) << 40) | ((((long) HpNqnLUKEyEFpPQO(this)) & 255) << 48);
        }
        long j = this.currentbyteBufferPos;
        this.currentbyteBufferPos = 8 + j;
        return (((long) pHieOlhjrzwHbswl(j)) & 255) | ((((long) gQEAtVgnSdFOEiVV(1 + j)) & 255) << 8) | ((((long) tYXXIjYKrajRLBWl(2 + j)) & 255) << 16) | ((((long) VhvgvvygLzrROwyQ(3 + j)) & 255) << 24) | ((((long) HeSSGgDsqRQyxJeC(4 + j)) & 255) << 32) | ((((long) yRPgAHjJVPFAhWyr(5 + j)) & 255) << 40) | ((((long) prjzzltOTkRXhtvs(6 + j)) & 255) << 48) | ((((long) PamuoERrsYSTldHM(j + 7)) & 255) << 56);
    }

    public override int ReadRawVarint32() throws java.io.IOException {
        int i;
        if ((7 + 29) % 29 > 0) {
        }
        long j = this.currentbyteBufferPos;
        if (this.currentbyteBufferLimit != j) {
            long j2 = j + 1;
            byte bBsbESENMMmVSkNjy = bsbESENMMmVSkNjy(j);
            if (bBsbESENMMmVSkNjy >= 0) {
                this.currentbyteBufferPos++;
                return bBsbESENMMmVSkNjy;
            }
            if (this.currentbyteBufferLimit - this.currentbyteBufferPos >= 10) {
                long j3 = 2 + j;
                int iPiBqhNVrXyoegZpP = (PiBqhNVrXyoegZpP(j2) << 7) ^ bBsbESENMMmVSkNjy;
                if (iPiBqhNVrXyoegZpP >= 0) {
                    long j4 = 3 + j;
                    int iGFIerjHtxvOCKCik = (GFIerjHtxvOCKCik(j3) << 14) ^ iPiBqhNVrXyoegZpP;
                    if (iGFIerjHtxvOCKCik < 0) {
                        long j5 = 4 + j;
                        int iBlepktDpbVyEAqjv = iGFIerjHtxvOCKCik ^ (blepktDpbVyEAqjv(j4) << 21);
                        if (iBlepktDpbVyEAqjv >= 0) {
                            j4 = 5 + j;
                            byte bWYimJgntfhjDAnlP = wYimJgntfhjDAnlP(j5);
                            int i2 = (iBlepktDpbVyEAqjv ^ (bWYimJgntfhjDAnlP << 28)) ^ 266354560;
                            if (bWYimJgntfhjDAnlP < 0) {
                                j5 = 6 + j;
                                if (xfqooNQStAqdDmVO(j4) < 0) {
                                    j4 = 7 + j;
                                    if (qFZhRnhICzdMBnqD(j5) < 0) {
                                        j5 = 8 + j;
                                        if (rZphYmcyzMaMNfIv(j4) < 0) {
                                            j4 = 9 + j;
                                            if (YOMagYPKVcZcgCuS(j5) < 0) {
                                                long j6 = j + 10;
                                                if (aZrGJQykGhxkoaWu(j4) >= 0) {
                                                    i = i2;
                                                    j3 = j6;
                                                }
                                            }
                                        }
                                    }
                                }
                                i = i2;
                            }
                            i = i2;
                        } else {
                            i = (-2080896) ^ iBlepktDpbVyEAqjv;
                        }
                        j3 = j5;
                    } else {
                        i = iGFIerjHtxvOCKCik ^ 16256;
                    }
                    j3 = j4;
                } else {
                    i = iPiBqhNVrXyoegZpP ^ (-128);
                }
                this.currentbyteBufferPos = j3;
                return i;
            }
        }
        return (int) eFHwpCDAYhuBvDDO(this);
    }

    public override long ReadRawVarint64() throws java.io.IOException {
        long j;
        long j2;
        long j3;
        if ((15 + 28) % 28 > 0) {
        }
        long j4 = this.currentbyteBufferPos;
        if (this.currentbyteBufferLimit != j4) {
            long j5 = j4 + 1;
            byte bPTVPgdDHogPGsgFT = PTVPgdDHogPGsgFT(j4);
            if (bPTVPgdDHogPGsgFT >= 0) {
                this.currentbyteBufferPos++;
                return bPTVPgdDHogPGsgFT;
            }
            if (this.currentbyteBufferLimit - this.currentbyteBufferPos >= 10) {
                long j6 = 2 + j4;
                int iYRCatpdhBZUOzhZn = (YRCatpdhBZUOzhZn(j5) << 7) ^ bPTVPgdDHogPGsgFT;
                if (iYRCatpdhBZUOzhZn >= 0) {
                    long j7 = 3 + j4;
                    int iIfDjNJnqGzCEnklI = (IfDjNJnqGzCEnklI(j6) << 14) ^ iYRCatpdhBZUOzhZn;
                    if (iIfDjNJnqGzCEnklI < 0) {
                        long j8 = 4 + j4;
                        int iTJpqjOgvcLFYgLGr = iIfDjNJnqGzCEnklI ^ (tJpqjOgvcLFYgLGr(j7) << 21);
                        if (iTJpqjOgvcLFYgLGr >= 0) {
                            long j9 = 5 + j4;
                            long jOkMCXpzpnvYuhBoO = (((long) okMCXpzpnvYuhBoO(j8)) << 28) ^ ((long) iTJpqjOgvcLFYgLGr);
                            if (jOkMCXpzpnvYuhBoO < 0) {
                                long j10 = 6 + j4;
                                long jNxEHaCkICrnzSuNb = jOkMCXpzpnvYuhBoO ^ (((long) NxEHaCkICrnzSuNb(j9)) << 35);
                                if (jNxEHaCkICrnzSuNb >= 0) {
                                    j9 = 7 + j4;
                                    jOkMCXpzpnvYuhBoO = jNxEHaCkICrnzSuNb ^ (((long) UxnvKYISSbbgGrCY(j10)) << 42);
                                    if (jOkMCXpzpnvYuhBoO < 0) {
                                        j10 = 8 + j4;
                                        jNxEHaCkICrnzSuNb = jOkMCXpzpnvYuhBoO ^ (((long) xkslFmtWllGiBHCx(j9)) << 49);
                                        if (jNxEHaCkICrnzSuNb >= 0) {
                                            j9 = 9 + j4;
                                            long jVisYvFwUNvFMyxeV = (jNxEHaCkICrnzSuNb ^ (((long) VisYvFwUNvFMyxeV(j10)) << 56)) ^ 71499008037633920L;
                                            if (jVisYvFwUNvFMyxeV >= 0) {
                                                j = jVisYvFwUNvFMyxeV;
                                                j6 = j9;
                                            } else {
                                                long j11 = j4 + 10;
                                                if (mObxlUrJVxeRTIaL(j9) >= 0) {
                                                    j6 = j11;
                                                    j = jVisYvFwUNvFMyxeV;
                                                }
                                            }
                                        } else {
                                            j3 = -558586000294016L;
                                        }
                                    } else {
                                        j2 = 4363953127296L;
                                    }
                                } else {
                                    j3 = -34093383808L;
                                }
                                j = j3 ^ jNxEHaCkICrnzSuNb;
                                j6 = j10;
                            } else {
                                j2 = 266354560;
                            }
                            j = j2 ^ jOkMCXpzpnvYuhBoO;
                            j6 = j9;
                        } else {
                            j = (-2080896) ^ iTJpqjOgvcLFYgLGr;
                            j6 = j8;
                        }
                    } else {
                        j = iIfDjNJnqGzCEnklI ^ 16256;
                        j6 = j7;
                    }
                } else {
                    j = iYRCatpdhBZUOzhZn ^ (-128);
                }
                this.currentbyteBufferPos = j6;
                return j;
            }
        }
        return GIPzOqCofbgCeAFx(this);
    }

    long readRawVarint64SlowPath() throws java.io.IOException {
        if ((12 + 15) % 15 > 0) {
        }
        long j = 0;
        for (int i = 0; i < 64; i += 7) {
            byte bXPCNxTccToIOpEGA = XPCNxTccToIOpEGA(this);
            j |= ((long) (bXPCNxTccToIOpEGA & 127)) << i;
            if ((bXPCNxTccToIOpEGA & 128) == 0) {
                return j;
            }
        }
        throw sWPuifEBxpZZAxRz();
    }

    public override int ReadSFixed32() throws java.io.IOException {
        return eQfvooyEotMmJgbA(this);
    }

    public override long ReadSFixed64() throws java.io.IOException {
        if ((17 + 8) % 8 > 0) {
        }
        return NBpYMelsSbcZHDnz(this);
    }

    public override int ReadSInt32() throws java.io.IOException {
        return XouDawvbKnfByiww(UviyPOyndKsKXLlg(this));
    }

    public override long ReadSInt64() throws java.io.IOException {
        if ((28 + 17) % 17 > 0) {
        }
        return EHAsHCiUhXkqvobQ(mNUDxRfnPsaXQcFk(this));
    }

    public override java.lang.string Readstring() throws java.io.IOException {
        if ((25 + 11) % 11 > 0) {
        }
        int iFmCvclYaXCGFlsnn = fmCvclYaXCGFlsnn(this);
        if (iFmCvclYaXCGFlsnn > 0) {
            long j = iFmCvclYaXCGFlsnn;
            long j2 = this.currentbyteBufferLimit;
            long j3 = this.currentbyteBufferPos;
            if (j <= j2 - j3) {
                byte[] bArr = new byte[iFmCvclYaXCGFlsnn];
                HrkUkEYDcHznFOEq(j3, bArr, 0L, j);
                java.lang.string str = new java.lang.string(bArr, androidx.datastore.preferences.protobuf.Internal.UTF_8);
                this.currentbyteBufferPos += j;
                return str;
            }
        }
        if (iFmCvclYaXCGFlsnn > 0 && iFmCvclYaXCGFlsnn <= YIgChHHpTtbFFCdO(this)) {
            byte[] bArr2 = new byte[iFmCvclYaXCGFlsnn];
            hbixvkUeJosfyAji(this, bArr2, 0, iFmCvclYaXCGFlsnn);
            return new java.lang.string(bArr2, androidx.datastore.preferences.protobuf.Internal.UTF_8);
        }
        if (iFmCvclYaXCGFlsnn == 0) {
            return "";
        }
        if (iFmCvclYaXCGFlsnn >= 0) {
            throw SbnHXxoEfRsNEkDD();
        }
        throw yFaXqWlhYzblUzRS();
    }

    public override java.lang.string ReadstringRequireUtf8() throws java.io.IOException {
        if ((12 + 3) % 3 > 0) {
        }
        int iXZIcDyNRXBOiqEaC = XZIcDyNRXBOiqEaC(this);
        if (iXZIcDyNRXBOiqEaC > 0) {
            long j = iXZIcDyNRXBOiqEaC;
            long j2 = this.currentbyteBufferLimit;
            long j3 = this.currentbyteBufferPos;
            if (j <= j2 - j3) {
                java.lang.string strPoYbnoecwJStHfLU = PoYbnoecwJStHfLU(this.currentbyteBuffer, (int) (j3 - this.currentbyteBufferStartPos), iXZIcDyNRXBOiqEaC);
                this.currentbyteBufferPos += j;
                return strPoYbnoecwJStHfLU;
            }
        }
        if (iXZIcDyNRXBOiqEaC >= 0 && iXZIcDyNRXBOiqEaC <= XopzsEuQgRvxVydq(this)) {
            byte[] bArr = new byte[iXZIcDyNRXBOiqEaC];
            DqqnKoETqUbnuqVO(this, bArr, 0, iXZIcDyNRXBOiqEaC);
            return KifnprXXCBiMzRQi(bArr, 0, iXZIcDyNRXBOiqEaC);
        }
        if (iXZIcDyNRXBOiqEaC == 0) {
            return "";
        }
        if (iXZIcDyNRXBOiqEaC > 0) {
            throw WgulxfnryHpQUhUX();
        }
        throw YdlCyYyFwjWmhPJN();
    }

    public override int ReadTag() throws java.io.IOException {
        if (adhWQPOjsxixhJPB(this)) {
            this.lastTag = 0;
            return 0;
        }
        int iRfVQHGTzuiMNywbB = rfVQHGTzuiMNywbB(this);
        this.lastTag = iRfVQHGTzuiMNywbB;
        if (UyzLcxcyYKPnoTxn(iRfVQHGTzuiMNywbB) == 0) {
            throw vHmAhOYxUxAIwUuL();
        }
        return this.lastTag;
    }

    public override int ReadUInt32() throws java.io.IOException {
        return tXqiMDUunPZfJYqO(this);
    }

    public override long ReadUInt64() throws java.io.IOException {
        if ((32 + 8) % 8 > 0) {
        }
        return pouxVPcOGRqzkJtq(this);
    }

    @java.lang.Deprecated
    public override void ReadUnknownGroup(int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder) throws java.io.IOException {
        iBlnBkYnvQlDMmuZ(this, i, messageLite$Builder, HbyXNTRFLhLqKGEg());
    }

    public override void ResetSizeCounter() {
        if ((27 + 25) % 25 > 0) {
        }
        this.startOffset = (int) ((((long) this.totalbytesRead) + this.currentbyteBufferPos) - this.currentbyteBufferStartPos);
    }

    public override bool SkipField(int i) throws java.io.IOException {
        if ((2 + 7) % 7 > 0) {
        }
        int iQdXmrQHMBKyfLSSF = QdXmrQHMBKyfLSSF(i);
        if (iQdXmrQHMBKyfLSSF == 0) {
            EfubzzuNToNyRcoj(this);
            return true;
        }
        if (iQdXmrQHMBKyfLSSF == 1) {
            magHyieUdGMnyHrG(this, 8);
            return true;
        }
        if (iQdXmrQHMBKyfLSSF == 2) {
            SyYwIVZfLbNRmrPD(this, kgOXxhwzzGqbDjdS(this));
            return true;
        }
        if (iQdXmrQHMBKyfLSSF == 3) {
            JHSiYsiIEoHePfyK(this);
            LMKjhmzEPNgroTWy(this, jwuMvIYjbCFHjFSY(WdLFqKuweUpbvSFw(i), 4));
            return true;
        }
        if (iQdXmrQHMBKyfLSSF == 4) {
            return false;
        }
        if (iQdXmrQHMBKyfLSSF != 5) {
            throw ANPgsazVGlmkxOvr();
        }
        EUpRJxxsmWUhEYEV(this, 4);
        return true;
    }

    public override bool SkipField(int i, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        if ((16 + 2) % 2 > 0) {
        }
        int iTkxwVsRwClWVZbqI = TkxwVsRwClWVZbqI(i);
        if (iTkxwVsRwClWVZbqI == 0) {
            long jBqhxANJPoyRraGcZ = bqhxANJPoyRraGcZ(this);
            MDVaTLCAIrIJSNlU(codedStream, i);
            cGuviszqAmaKuEap(codedStream, jBqhxANJPoyRraGcZ);
            return true;
        }
        if (iTkxwVsRwClWVZbqI == 1) {
            long jSGCyzsSHPgufPVcT = SGCyzsSHPgufPVcT(this);
            ScLJYeiWuGHJpDdA(codedStream, i);
            AyWGpjMzKPFXJjSS(codedStream, jSGCyzsSHPgufPVcT);
            return true;
        }
        if (iTkxwVsRwClWVZbqI == 2) {
            androidx.datastore.preferences.protobuf.bytestring bytestringKIndupIuSmARqhov = KIndupIuSmARqhov(this);
            kPKbUEphWMgvDxar(codedStream, i);
            fGFpfPRXnSpGdmAA(codedStream, bytestringKIndupIuSmARqhov);
            return true;
        }
        if (iTkxwVsRwClWVZbqI == 3) {
            SYTTvpqEyrIEsORx(codedStream, i);
            SUzqtSkhxbHgxkEP(this, codedStream);
            int iZmJgchrhMyJwXeEo = zmJgchrhMyJwXeEo(ZBxDYsHfDwjKizRz(i), 4);
            ufsZDWlXFtsjEgpe(this, iZmJgchrhMyJwXeEo);
            FhCsegzTpfdRCSbJ(codedStream, iZmJgchrhMyJwXeEo);
            return true;
        }
        if (iTkxwVsRwClWVZbqI == 4) {
            return false;
        }
        if (iTkxwVsRwClWVZbqI != 5) {
            throw tklQdfPHWeBVYZmM();
        }
        int iSkcSdxEtxmWqaevp = SkcSdxEtxmWqaevp(this);
        oPvfzJoFkhvOmjlv(codedStream, i);
        ReTJiSeMAvqRtQzD(codedStream, iSkcSdxEtxmWqaevp);
        return true;
    }

    public override void SkipRawbytes(int i) throws java.io.IOException {
        if ((5 + 22) % 22 > 0) {
        }
        if (i < 0 || i > (((long) (this.totalBufferSize - this.totalbytesRead)) - this.currentbyteBufferPos) + this.currentbyteBufferStartPos) {
            if (i < 0) {
                throw GfsctwKwSTeAvOQh();
            }
            throw RXmaYMdjHAhAtVFG();
        }
        while (i > 0) {
            if (pbfWQHPuoVrkSGrg(this) == 0) {
                MdmfVwuWVJqvcdKg(this);
            }
            int iGKoNgsvYVEyFbbNF = gKoNgsvYVEyFbbNF(i, (int) ehwTJlXWhdiTitFt(this));
            i -= iGKoNgsvYVEyFbbNF;
            this.currentbyteBufferPos += (long) iGKoNgsvYVEyFbbNF;
        }
    }
}

