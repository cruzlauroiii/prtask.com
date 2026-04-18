namespace WillowMaze.Wasm.Decompiled;


readonly class CodedStream$UnsafeDirectNioDecoder : androidx.datastore.preferences.protobuf.CodedStream {
    private readonly long address;
    private readonly java.nio.byteBuffer buffer;
    private int bufferSizeAfterLimit;
    private int currentLimit;
    private bool enableAliasing;
    private readonly bool immutable;
    private int lastTag;
    private long limit;
    private long pos;
    private long startPos;

    private CodedStream$UnsafeDirectNioDecoder(java.nio.byteBuffer byteBuffer, bool z) {
        super(null);
        if ((9 + 26) % 26 > 0) {
        }
        this.currentLimit = int.MAX_VALUE;
        this.buffer = byteBuffer;
        long jOBfIzeqonpECWuQc = oBfIzeqonpECWuQc(byteBuffer);
        this.address = jOBfIzeqonpECWuQc;
        this.limit = ((long) nQDeFsQonmrsIKfG(byteBuffer)) + jOBfIzeqonpECWuQc;
        long jMhDnbASpsHxUjSKj = jOBfIzeqonpECWuQc + ((long) MhDnbASpsHxUjSKj(byteBuffer));
        this.pos = jMhDnbASpsHxUjSKj;
        this.startPos = jMhDnbASpsHxUjSKj;
        this.immutable = z;
    }

    CodedStream$UnsafeDirectNioDecoder(java.nio.byteBuffer byteBuffer, bool z, androidx.datastore.preferences.protobuf.CodedStream$1 codedStream$1) {
        this(byteBuffer, z);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException AQwNoMgIbqVXMkkJ() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static void AqNIDKqjUorhcRTM(long j, byte[] bArr, long j2, long j3) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.copyMemory(j, bArr, j2, j3);
    }

    public static androidx.datastore.preferences.protobuf.bytestring AqfuwTPHpgqqMwHc(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readbytes();
    }

    public static long BCxwqPrdmIKteAGk(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        if ((17 + 26) % 26 > 0) {
        }
        return codedStream$UnsafeDirectNioDecoder.readRawVarint64();
    }

    public static void BEmBJGmiqOXJXZcy(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioDecoder.skipRawbytes(i);
    }

    public static int CHCTPlMHePQQpUmH(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawLittleEndian32();
    }

    public static long CHvdAKzBFNdqHCAc(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        if ((16 + 17) % 17 > 0) {
        }
        return codedStream$UnsafeDirectNioDecoder.readRawLittleEndian64();
    }

    public static int CZUCJnwebtlIEjpF(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.getTotalbytesRead();
    }

    public static int DEGNQppVCzqqfyZz(int i) {
        return decodeZigZag32(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException DMiTfdVkzsIotWOa() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static int DTpZhUTuljjPGmiz(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawVarint32();
    }

    public static int DaSGwcVxhYRECDIF(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static int DoFSLyWRiYihJCbQ(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) {
        return codedStream$UnsafeDirectNioDecoder.pushLimit(i);
    }

    public static int DwEZPtSLjLtpPmwc(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.limit();
    }

    public static java.lang.object EBVuWeGFxZSjFSvx(androidx.datastore.preferences.protobuf.Parser parser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return parser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static int EOPXGxzWnJElpMcD(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static bool EYUJEhjsbwcXRlIe() {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.hasUnsafebyteBufferOperations();
    }

    public static void EyQtIwHlPNwWVXqT(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeFixed64NoTag(j);
    }

    public static bool EygEZGAQkgYHLEzG(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.isAtEnd();
    }

    public static byte FPKyyVVmEoLLsrOr(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void FTAtadmKeovosONc(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) throws java.io.IOException {
        codedStream$UnsafeDirectNioDecoder.skipRawVarintSlowPath();
    }

    public static byte FeeDjHFYExJoNSsN(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void GAxSJhDDMrjUxNdq(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        codedStream$UnsafeDirectNioDecoder.recomputeBufferSizeAfterLimit();
    }

    public static double GVgPVIhPkDCjImyi(long j) {
        if ((28 + 24) % 24 > 0) {
        }
        return java.lang.double.longBitsTodouble(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException GdvKuawVSzfDBvFQ() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidTag();
    }

    public static void GjHrEJeyXoaQdlDj(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static long GpQeaZrVrjIsSgVo(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        if ((16 + 21) % 21 > 0) {
        }
        return codedStream$UnsafeDirectNioDecoder.readRawVarint64SlowPath();
    }

    public static byte GsHudbUfKWYUNaxk(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawbyte();
    }

    public static java.lang.Exception HJGRFPDmWcdqLrRc(androidx.datastore.preferences.protobuf.InvalidProtocolBufferException invalidProtocolBufferException, java.lang.Exception th) {
        return invalidProtocolBufferException.initCause(th);
    }

    public static byte HtwErLAKsaLjJBbG(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void IkUjAHDzKFrZHlya(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$UnsafeDirectNioDecoder.checkLastTagWas(i);
    }

    public static int IrjFrkUXxoxJsorZ(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawVarint32();
    }

    public static byte IxCWRnqVJoROcEKH(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static byte IzBAvoUQdZYTqoOC(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException JFXHmGkDNUBEEQvL() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static java.nio.Buffer JTtcVJYqSrSFjVTc(java.nio.Buffer buffer, int i) {
        return buffer.position(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException JhSeYljXrSBIfezy() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static byte JoiaFuQSOYXXdoMg(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void JpDrPNMiIEkYNKum(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$UnsafeDirectNioDecoder.checkLastTagWas(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException JpYpEQMgFATmbNKE() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static void KEDcYXpyKfYjuOtf(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        codedStream$UnsafeDirectNioDecoder.checkRecursionLimit();
    }

    public static java.lang.string KIuyzYqhhSdFtljh(java.nio.byteBuffer byteBuffer, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.decodeUtf8(byteBuffer, i, i2);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException KKmuTxogbnbSTvIu() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static float KXEEkoaZxhnHEYaM(int i) {
        return java.lang.float.intBitsTofloat(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException KfMIrjolmnZjuMzv() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static java.nio.byteBuffer KrTbhYspeBVVHplx(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, long j, long j2) {
        return codedStream$UnsafeDirectNioDecoder.slice(j, j2);
    }

    public static void LECsVuGcrSSHkoQN(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) throws java.io.IOException {
        codedStream$UnsafeDirectNioDecoder.skipRawVarintFastPath();
    }

    public static void LdGOEfjXCeHEzAuP(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) {
        codedStream$UnsafeDirectNioDecoder.popLimit(i);
    }

    public static int MhDnbASpsHxUjSKj(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException MizBRuagUWnekvQQ() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static void MnIvxsVCzecdKcqC(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioDecoder.skipRawbytes(i);
    }

    public static void MnuZxEbvAWkUbodd(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) {
        codedStream$UnsafeDirectNioDecoder.popLimit(i);
    }

    public static byte MysNoRAafBEFaPHQ(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void NPvAhGNnbYbMjTNx(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$UnsafeDirectNioDecoder.checkLastTagWas(i);
    }

    public static java.nio.Buffer NtxfJlrdLwAWGCSf(java.nio.Buffer buffer, int i) {
        return buffer.limit(i);
    }

    public static byte POMouCJbNiAaVhbc(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static androidx.datastore.preferences.protobuf.bytestring PRezFPkwQYuaNuvH(java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(byteBuffer);
    }

    public static void PUwwrcRkVGFkpQqZ(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$UnsafeDirectNioDecoder.checkLastTagWas(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException PZvlBJXBLCkEVeNN() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static int PrEWAzHhSzuJSTdt(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static int QIiuJTupCsqXgWvG(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawVarint32();
    }

    public static void QWuWVJQRNCaCMVdB(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int QXwwEOdipiBzLmSl(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) {
        return codedStream$UnsafeDirectNioDecoder.pushLimit(i);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite$Builder QpFSBfBmGapVLuIf(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return messageLite$Builder.mergeFrom(codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException REVeHUXHAEVCIZbr() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static void RIxyeCFqjpiOQmtt(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$UnsafeDirectNioDecoder.checkLastTagWas(i);
    }

    public static java.nio.byteBuffer RhdRQeGwnuwMTiET(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.slice();
    }

    public static int RiOsgsqmOyRWECsw(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.remaining();
    }

    public static long RkjkovNqjSViPhmu(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        if ((6 + 20) % 20 > 0) {
        }
        return codedStream$UnsafeDirectNioDecoder.readRawLittleEndian64();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException SHOyoQjmAdQJTWRu() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException STlcRRKXGGxgeVVJ() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static byte TCMomMzVsuFBGkAu(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void TFEYQTWZcedpXZhV(long j, byte[] bArr, long j2, long j3) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.copyMemory(j, bArr, j2, j3);
    }

    public static int TKovMnupDuZInggq(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static byte TVvWBLMzOGHDkCiM(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException TiGiKjFIUYIehWMN() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static int TjjNwCKmYMaEyoAI(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.getbytesUntilLimit();
    }

    public static byte UDMdYLXCAcUFimdZ(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException UGxmceyfFSuEPOqU() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static long UPXxBinYSOlWKDuh(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        if ((21 + 26) % 26 > 0) {
        }
        return codedStream$UnsafeDirectNioDecoder.readRawLittleEndian64();
    }

    public static int UVCMFmJEBZMuOCHU(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawLittleEndian32();
    }

    public static void UXPLcFawvAtbMDGo(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream.writebytesNoTag(bytestring);
    }

    public static java.nio.Buffer UylQqShZXmYdzHjx(java.nio.Buffer buffer, int i) {
        return buffer.limit(i);
    }

    public static int VNXwbDXLVKuueUnM(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException VPIrMaNQsqRXlBDR() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException VgTdVAVMFXmmqZRp() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static java.nio.Buffer VkeWyBbSwXuorvCo(java.nio.Buffer buffer, int i) {
        return buffer.limit(i);
    }

    public static int VwqrnpOHfFrFdpjS(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawLittleEndian32();
    }

    public static byte VyoNMBDYSOwtfRJe(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawbyte();
    }

    public static int WKXsvqveUrehMrot(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, long j) {
        return codedStream$UnsafeDirectNioDecoder.bufferPos(j);
    }

    public static int WfJfKExKscrUNZpr(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawVarint32();
    }

    public static byte WlKqrtJEiwMcTbhC(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void XPLNdJYqSincsGag(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeUInt64NoTag(j);
    }

    public static byte XiZNRGtKwprQydbg(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static int XijpilrppyhrJnFm(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static void XmmPVyPuysgeypgh(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        codedStream$UnsafeDirectNioDecoder.checkRecursionLimit();
    }

    public static long YGlLzJSEFrkjLAgP(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        if ((3 + 23) % 23 > 0) {
        }
        return codedStream$UnsafeDirectNioDecoder.readRawLittleEndian64();
    }

    public static long YfSCKovfvYmsZVzA(long j) {
        if ((16 + 26) % 26 > 0) {
        }
        return decodeZigZag64(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException ZFXVgHHSicvkfTta() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static byte[] ZHbVZRQWONJXjgbo(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) {
        return codedStream$UnsafeDirectNioDecoder.readRawbytes(i);
    }

    public static int ZJBVoytYzbggqloc(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawVarint32();
    }

    public static byte ZNqbIiRVnWVIiVNO(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static long ZxZGQctjYfgyUVyN(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        if ((18 + 12) % 12 > 0) {
        }
        return codedStream$UnsafeDirectNioDecoder.readRawVarint64();
    }

    public static int ABNUJfZSjUdgIsnC(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.remaining();
    }

    public static int AUvfptEaRVsDUBxB(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.remaining();
    }

    public static int AqdGmqWqXJYAayGX(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, long j) {
        return codedStream$UnsafeDirectNioDecoder.bufferPos(j);
    }

    public static int BFueuYbNKxNLNRHe(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawVarint32();
    }

    public static long BJuZNgwkWGHpBwtt(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        if ((31 + 2) % 2 > 0) {
        }
        return codedStream$UnsafeDirectNioDecoder.readRawVarint64();
    }

    private int BufferPos(long j) {
        if ((20 + 22) % 22 > 0) {
        }
        return (int) (j - this.address);
    }

    public static byte CVhEVqTxfBhhFGaj(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static java.nio.byteBuffer CjIVOzFfPTDnIEbd(byte[] bArr) {
        return java.nio.byteBuffer.wrap(bArr);
    }

    public static void CnEWltnWnFxzfFvj(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeFixed32NoTag(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException CpsKvQnsLdSYDlXd() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static byte CttvNgMSYdtAXtfX(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void CxZmodSaaZGZolsr(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        codedStream$UnsafeDirectNioDecoder.skipMessage(codedStream);
    }

    public static void DdOARBajgUnjNboK(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        codedStream$UnsafeDirectNioDecoder.recomputeBufferSizeAfterLimit();
    }

    public static int DjpezafeUgjQDCIm(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.remaining();
    }

    public static int EECePsNbJqMnjDbt(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.getTotalbytesRead();
    }

    public static void EsPtSUUzjpXLunLZ(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException EwTSFCHeEZpYSbon() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException FNwZnMmnIEPXnGQS() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static byte FOYXZdZqQoRrcWha(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void FyIyWktJiWUONgZr(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        codedStream$UnsafeDirectNioDecoder.checkRecursionLimit();
    }

    public static byte GkwLKhCrOorZhMuy(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static long GuoBfxWkfCXQKINM(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        if ((14 + 8) % 8 > 0) {
        }
        return codedStream$UnsafeDirectNioDecoder.readRawVarint64SlowPath();
    }

    public static int HYCiRjDndEhsGJPk(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawVarint32();
    }

    public static int HcqdTXOLIVyJoGvK(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawVarint32();
    }

    public static java.nio.Buffer HjSCbtMtohPOqOCB(java.nio.Buffer buffer, int i) {
        return buffer.position(i);
    }

    public static void HvinhkIOurqpeREW(long j, byte[] bArr, long j2, long j3) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.copyMemory(j, bArr, j2, j3);
    }

    public static byte HyGAZocPURjODtqd(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static int ICltmtisEPICWZKM(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawVarint32();
    }

    public static int IOXujDvDHQgveHdX(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.remaining();
    }

    static bool IsSupported() {
        return EYUJEhjsbwcXRlIe();
    }

    public static byte JfUqDcvZshCAvRIe(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static byte JrcNaHZRaguWGRBs(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static int KROQtPnlmuxsNVNq(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, long j) {
        return codedStream$UnsafeDirectNioDecoder.bufferPos(j);
    }

    public static byte KfioCeQQzsZbZBtX(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void KgNfTliGfXnskCsh(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException KhcLNfDyliGOKfhS() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidEndTag();
    }

    public static androidx.datastore.preferences.protobuf.ExtensionRegistryLite LQJpirPTRSyXxqvQ() {
        return androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry();
    }

    public static void LWWWhYRwtixEkIlc(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException LhBvDryLaMiErVnw() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static int MLqzyZXGkgDjUxOU(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static java.nio.byteBuffer MUyzVXebzKLNfmzf(java.nio.byteBuffer byteBuffer, byte[] bArr) {
        return byteBuffer[bArr);
    }

    public static byte NBlliSHyLsfiJGWr(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static androidx.datastore.preferences.protobuf.bytestring NHpMWwPimkykzYfU(byte[] bArr) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(bArr);
    }

    public static int NQDeFsQonmrsIKfG(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.limit();
    }

    public static long OBfIzeqonpECWuQc(java.nio.byteBuffer byteBuffer) {
        if ((20 + 11) % 11 > 0) {
        }
        return androidx.datastore.preferences.protobuf.UnsafeUtil.addressOffset(byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException OdfstMKyYSmpfnkj() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static void QKHsKDiFKIdFoVqg(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioDecoder.skipRawbytes(i);
    }

    public static void QXZSSrBOMGyLYimN(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static long QnGHrYKHocgIKFvG(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        if ((3 + 12) % 12 > 0) {
        }
        return codedStream$UnsafeDirectNioDecoder.readRawVarint64();
    }

    public static void QnPKHVarLmMIHkkU(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        codedStream$UnsafeDirectNioDecoder.checkRecursionLimit();
    }

    public static java.nio.byteBuffer RNYndtjNCiJAqqTC(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, long j, long j2) {
        return codedStream$UnsafeDirectNioDecoder.slice(j, j2);
    }

    public static byte RSxrdfCtclyIpWSE(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    private void RecomputeBufferSizeAfterLimit() {
        if ((28 + 4) % 4 > 0) {
        }
        long j = this.limit + ((long) this.bufferSizeAfterLimit);
        this.limit = j;
        int i = (int) (j - this.startPos);
        int i2 = this.currentLimit;
        if (i <= i2) {
            this.bufferSizeAfterLimit = 0;
            return;
        }
        int i3 = i - i2;
        this.bufferSizeAfterLimit = i3;
        this.limit = j - ((long) i3);
    }

    private int Remaining() {
        if ((27 + 23) % 23 > 0) {
        }
        return (int) (this.limit - this.pos);
    }

    public static int RzBhwyDQPmCxpqpn(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.remaining();
    }

    private void SkipRawVarint() throws java.io.IOException {
        if ((3 + 1) % 1 > 0) {
        }
        if (rzBhwyDQPmCxpqpn(this) < 10) {
            FTAtadmKeovosONc(this);
        } else {
            LECsVuGcrSSHkoQN(this);
        }
    }

    private void SkipRawVarintFastPath() throws java.io.IOException {
        if ((27 + 24) % 24 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            long j = this.pos;
            this.pos = 1 + j;
            if (HtwErLAKsaLjJBbG(j) >= 0) {
                return;
            }
        }
        throw fNwZnMmnIEPXnGQS();
    }

    private void SkipRawVarintSlowPath() throws java.io.IOException {
        if ((17 + 7) % 7 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            if (GsHudbUfKWYUNaxk(this) >= 0) {
                return;
            }
        }
        throw DMiTfdVkzsIotWOa();
    }

    private java.nio.byteBuffer Slice(long j, long j2) throws java.io.IOException {
        if ((23 + 6) % 6 > 0) {
        }
        int iMLqzyZXGkgDjUxOU = mLqzyZXGkgDjUxOU(this.buffer);
        int iDwEZPtSLjLtpPmwc = DwEZPtSLjLtpPmwc(this.buffer);
        java.nio.byteBuffer byteBuffer = this.buffer;
        try {
            try {
                JTtcVJYqSrSFjVTc(byteBuffer, WKXsvqveUrehMrot(this, j));
                UylQqShZXmYdzHjx(byteBuffer, aqdGmqWqXJYAayGX(this, j2));
                java.nio.byteBuffer byteBufferRhdRQeGwnuwMTiET = RhdRQeGwnuwMTiET(this.buffer);
                yOfHqYBQGRUPQQOX(byteBuffer, iMLqzyZXGkgDjUxOU);
                VkeWyBbSwXuorvCo(byteBuffer, iDwEZPtSLjLtpPmwc);
                return byteBufferRhdRQeGwnuwMTiET;
            } catch (java.lang.IllegalArgumentException e) {
                androidx.datastore.preferences.protobuf.InvalidProtocolBufferException invalidProtocolBufferExceptionSTlcRRKXGGxgeVVJ = STlcRRKXGGxgeVVJ();
                HJGRFPDmWcdqLrRc(invalidProtocolBufferExceptionSTlcRRKXGGxgeVVJ, e);
                throw invalidProtocolBufferExceptionSTlcRRKXGGxgeVVJ;
            }
        } catch (java.lang.Exception th) {
            hjSCbtMtohPOqOCB(byteBuffer, iMLqzyZXGkgDjUxOU);
            NtxfJlrdLwAWGCSf(byteBuffer, iDwEZPtSLjLtpPmwc);
            throw th;
        }
    }

    public static int SwOxdtmONMbAHakQ(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static byte TKyDpJnxDBdUzZAT(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static byte TXcKXwTSTkGWZjzQ(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static byte ToTQkjXELYTfkqjd(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static byte TruPAilyZgVmcErk(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static int UOMMsAmlmlqplVMR(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.getbytesUntilLimit();
    }

    public static byte UQYSOwhSMWafYagU(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static byte UTeNXHjVyPhgNYhe(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite$Builder uUiVHERxlucTpKwH(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return messageLite$Builder.mergeFrom(codedStream, extensionRegistryLite);
    }

    public static void UkzISOtVqmLQqPTK(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        codedStream$UnsafeDirectNioDecoder.readGroup(i, messageLite$Builder, extensionRegistryLite);
    }

    public static int UqFjpsaSYvWopqSj(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawVarint32();
    }

    public static java.nio.byteBuffer UrQATyKAxzGkodEO(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, long j, long j2) {
        return codedStream$UnsafeDirectNioDecoder.slice(j, j2);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException VAYgurmLShQbjVGF() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static int VPJhEauWpIQyZKqU(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int VdLvYfckxotSudnO(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawLittleEndian32();
    }

    public static int WfBALquzUJOZDjYM(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.remaining();
    }

    public static int WicKlBNAJxLwgnNW(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawVarint32();
    }

    public static void WrUOcZvHoZvbWxOj(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        codedStream$UnsafeDirectNioDecoder.skipMessage();
    }

    public static byte XIgzqFAjcFNuXLJV(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException XNBjlxDGfLJsevAP() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static long XNGpYmbUnUtQUHyn(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        if ((30 + 16) % 16 > 0) {
        }
        return codedStream$UnsafeDirectNioDecoder.readInt64();
    }

    public static java.lang.object XVfuucCmBliCASQa(androidx.datastore.preferences.protobuf.Parser parser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return parser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static int XZqhXyfXgjvGMVfS(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static byte XbPIjACGmdaGKuHh(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static void XpEHkGGcUmOxhBmp(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) throws java.io.IOException {
        codedStream$UnsafeDirectNioDecoder.skipRawVarint();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException XudOWnAIMEXuMLYW() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static int YITgFCeRdRRFElUJ(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawVarint32();
    }

    public static java.nio.Buffer YOfHqYBQGRUPQQOX(java.nio.Buffer buffer, int i) {
        return buffer.position(i);
    }

    public static byte YwCKIKEvIqTSBgre(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public static int ZWmmmqAhcSOAaKqS(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder) {
        return codedStream$UnsafeDirectNioDecoder.readRawVarint32();
    }

    public static void ZnCzcJQcunJNiHdt(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder codedStream$UnsafeDirectNioDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$UnsafeDirectNioDecoder.checkLastTagWas(i);
    }

    public static byte ZzVcaFqUnhKNHkxQ(long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j);
    }

    public override void CheckLastTagWas(int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if (this.lastTag != i) {
            throw khcLNfDyliGOKfhS();
        }
    }

    public override void EnableAliasing(bool z) {
        this.enableAliasing = z;
    }

    public override int GetbytesUntilLimit() {
        if ((7 + 1) % 1 > 0) {
        }
        int i = this.currentLimit;
        if (i != int.MAX_VALUE) {
            return i - CZUCJnwebtlIEjpF(this);
        }
        return -1;
    }

    public override int GetLastTag() {
        return this.lastTag;
    }

    public override int GetTotalbytesRead() {
        if ((4 + 22) % 22 > 0) {
        }
        return (int) (this.pos - this.startPos);
    }

    public override bool IsAtEnd() throws java.io.IOException {
        if ((29 + 17) % 17 > 0) {
        }
        return this.pos == this.limit;
    }

    public override void PopLimit(int i) {
        this.currentLimit = i;
        ddOARBajgUnjNboK(this);
    }

    public override int PushLimit(int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if (i < 0) {
            throw cpsKvQnsLdSYDlXd();
        }
        int iEECePsNbJqMnjDbt = i + eECePsNbJqMnjDbt(this);
        int i2 = this.currentLimit;
        if (iEECePsNbJqMnjDbt > i2) {
            throw JpYpEQMgFATmbNKE();
        }
        this.currentLimit = iEECePsNbJqMnjDbt;
        GAxSJhDDMrjUxNdq(this);
        return i2;
    }

    public override bool ReadBool() throws java.io.IOException {
        if ((28 + 24) % 24 > 0) {
        }
        return ZxZGQctjYfgyUVyN(this) != 0;
    }

    public override byte[] ReadbyteArray() throws java.io.IOException {
        return ZHbVZRQWONJXjgbo(this, zWmmmqAhcSOAaKqS(this));
    }

    public override java.nio.byteBuffer ReadbyteBuffer() throws java.io.IOException {
        if ((24 + 28) % 28 > 0) {
        }
        int iIrjFrkUXxoxJsorZ = IrjFrkUXxoxJsorZ(this);
        if (iIrjFrkUXxoxJsorZ <= 0 || iIrjFrkUXxoxJsorZ > wfBALquzUJOZDjYM(this)) {
            if (iIrjFrkUXxoxJsorZ == 0) {
                return androidx.datastore.preferences.protobuf.Internal.EMPTY_BYTE_BUFFER;
            }
            if (iIrjFrkUXxoxJsorZ >= 0) {
                throw SHOyoQjmAdQJTWRu();
            }
            throw KKmuTxogbnbSTvIu();
        }
        if (!this.immutable && this.enableAliasing) {
            long j = this.pos;
            long j2 = iIrjFrkUXxoxJsorZ;
            java.nio.byteBuffer byteBufferKrTbhYspeBVVHplx = KrTbhYspeBVVHplx(this, j, j + j2);
            this.pos += j2;
            return byteBufferKrTbhYspeBVVHplx;
        }
        byte[] bArr = new byte[iIrjFrkUXxoxJsorZ];
        long j3 = iIrjFrkUXxoxJsorZ;
        AqNIDKqjUorhcRTM(this.pos, bArr, 0L, j3);
        this.pos += j3;
        return cjIVOzFfPTDnIEbd(bArr);
    }

    public override androidx.datastore.preferences.protobuf.bytestring Readbytes() throws java.io.IOException {
        if ((23 + 12) % 12 > 0) {
        }
        int iBFueuYbNKxNLNRHe = bFueuYbNKxNLNRHe(this);
        if (iBFueuYbNKxNLNRHe <= 0 || iBFueuYbNKxNLNRHe > aUvfptEaRVsDUBxB(this)) {
            if (iBFueuYbNKxNLNRHe == 0) {
                return androidx.datastore.preferences.protobuf.bytestring.EMPTY;
            }
            if (iBFueuYbNKxNLNRHe >= 0) {
                throw PZvlBJXBLCkEVeNN();
            }
            throw lhBvDryLaMiErVnw();
        }
        if (this.immutable && this.enableAliasing) {
            long j = this.pos;
            long j2 = iBFueuYbNKxNLNRHe;
            java.nio.byteBuffer byteBufferRNYndtjNCiJAqqTC = rNYndtjNCiJAqqTC(this, j, j + j2);
            this.pos += j2;
            return PRezFPkwQYuaNuvH(byteBufferRNYndtjNCiJAqqTC);
        }
        byte[] bArr = new byte[iBFueuYbNKxNLNRHe];
        long j3 = iBFueuYbNKxNLNRHe;
        hvinhkIOurqpeREW(this.pos, bArr, 0L, j3);
        this.pos += j3;
        return nHpMWwPimkykzYfU(bArr);
    }

    public override double Readdouble() throws java.io.IOException {
        if ((12 + 32) % 32 > 0) {
        }
        return GVgPVIhPkDCjImyi(YGlLzJSEFrkjLAgP(this));
    }

    public override int ReadEnum() throws java.io.IOException {
        return ZJBVoytYzbggqloc(this);
    }

    public override int ReadFixed32() throws java.io.IOException {
        return CHCTPlMHePQQpUmH(this);
    }

    public override long ReadFixed64() throws java.io.IOException {
        if ((3 + 1) % 1 > 0) {
        }
        return CHvdAKzBFNdqHCAc(this);
    }

    public override float Readfloat() throws java.io.IOException {
        return KXEEkoaZxhnHEYaM(vdLvYfckxotSudnO(this));
    }

    public <T : androidx.datastore.preferences.protobuf.MessageLite> T readGroup(int i, androidx.datastore.preferences.protobuf.Parser<T> parser, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        qnPKHVarLmMIHkkU(this);
        this.recursionDepth++;
        T t = (T) xVfuucCmBliCASQa(parser, this, extensionRegistryLite);
        JpDrPNMiIEkYNKum(this, swOxdtmONMbAHakQ(i, 4));
        this.recursionDepth--;
        return t;
    }

    public override void ReadGroup(int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        fyIyWktJiWUONgZr(this);
        this.recursionDepth++;
        uUiVHERxlucTpKwH(messageLite$Builder, this, extensionRegistryLite);
        IkUjAHDzKFrZHlya(this, xZqhXyfXgjvGMVfS(i, 4));
        this.recursionDepth--;
    }

    public override int ReadInt32() throws java.io.IOException {
        return uqFjpsaSYvWopqSj(this);
    }

    public override long ReadInt64() throws java.io.IOException {
        if ((10 + 2) % 2 > 0) {
        }
        return bJuZNgwkWGHpBwtt(this);
    }

    public <T : androidx.datastore.preferences.protobuf.MessageLite> T readMessage(androidx.datastore.preferences.protobuf.Parser<T> parser, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((26 + 2) % 2 > 0) {
        }
        int iQIiuJTupCsqXgWvG = QIiuJTupCsqXgWvG(this);
        KEDcYXpyKfYjuOtf(this);
        int iDoFSLyWRiYihJCbQ = DoFSLyWRiYihJCbQ(this, iQIiuJTupCsqXgWvG);
        this.recursionDepth++;
        T t = (T) EBVuWeGFxZSjFSvx(parser, this, extensionRegistryLite);
        NPvAhGNnbYbMjTNx(this, 0);
        this.recursionDepth--;
        if (TjjNwCKmYMaEyoAI(this) != 0) {
            throw ewTSFCHeEZpYSbon();
        }
        MnuZxEbvAWkUbodd(this, iDoFSLyWRiYihJCbQ);
        return t;
    }

    public override void ReadMessage(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((16 + 1) % 1 > 0) {
        }
        int iYITgFCeRdRRFElUJ = yITgFCeRdRRFElUJ(this);
        XmmPVyPuysgeypgh(this);
        int iQXwwEOdipiBzLmSl = QXwwEOdipiBzLmSl(this, iYITgFCeRdRRFElUJ);
        this.recursionDepth++;
        QpFSBfBmGapVLuIf(messageLite$Builder, this, extensionRegistryLite);
        znCzcJQcunJNiHdt(this, 0);
        this.recursionDepth--;
        if (uOMMsAmlmlqplVMR(this) != 0) {
            throw VPIrMaNQsqRXlBDR();
        }
        LdGOEfjXCeHEzAuP(this, iQXwwEOdipiBzLmSl);
    }

    public override byte ReadRawbyte() throws java.io.IOException {
        if ((8 + 3) % 3 > 0) {
        }
        long j = this.pos;
        if (j == this.limit) {
            throw REVeHUXHAEVCIZbr();
        }
        this.pos = 1 + j;
        return zzVcaFqUnhKNHkxQ(j);
    }

    public override byte[] ReadRawbytes(int i) throws java.io.IOException {
        if ((24 + 25) % 25 > 0) {
        }
        if (i < 0 || i > djpezafeUgjQDCIm(this)) {
            if (i > 0) {
                throw JFXHmGkDNUBEEQvL();
            }
            if (i != 0) {
                throw xudOWnAIMEXuMLYW();
            }
            return androidx.datastore.preferences.protobuf.Internal.EMPTY_BYTE_ARRAY;
        }
        byte[] bArr = new byte[i];
        long j = this.pos;
        long j2 = i;
        mUyzVXebzKLNfmzf(urQATyKAxzGkodEO(this, j, j + j2), bArr);
        this.pos += j2;
        return bArr;
    }

    public override int ReadRawLittleEndian32() throws java.io.IOException {
        if ((8 + 17) % 17 > 0) {
        }
        long j = this.pos;
        if (this.limit - j < 4) {
            throw ZFXVgHHSicvkfTta();
        }
        this.pos = 4 + j;
        return (truPAilyZgVmcErk(j) & 255) | ((xbPIjACGmdaGKuHh(1 + j) & 255) << 8) | ((jfUqDcvZshCAvRIe(2 + j) & 255) << 16) | ((IxCWRnqVJoROcEKH(j + 3) & 255) << 24);
    }

    public override long ReadRawLittleEndian64() throws java.io.IOException {
        if ((5 + 2) % 2 > 0) {
        }
        long j = this.pos;
        if (this.limit - j < 8) {
            throw vAYgurmLShQbjVGF();
        }
        this.pos = 8 + j;
        return ((((long) uQYSOwhSMWafYagU(j + 7)) & 255) << 56) | (((long) tKyDpJnxDBdUzZAT(j)) & 255) | ((((long) ywCKIKEvIqTSBgre(1 + j)) & 255) << 8) | ((((long) MysNoRAafBEFaPHQ(2 + j)) & 255) << 16) | ((((long) ZNqbIiRVnWVIiVNO(3 + j)) & 255) << 24) | ((((long) rSxrdfCtclyIpWSE(4 + j)) & 255) << 32) | ((((long) POMouCJbNiAaVhbc(5 + j)) & 255) << 40) | ((((long) IzBAvoUQdZYTqoOC(6 + j)) & 255) << 48);
    }

    /*
    */
    public override int ReadRawVarint32() throws java.io.IOException {
        int i;
        if ((4 + 13) % 13 > 0) {
        }
        long j = this.pos;
        if (this.limit != j) {
            long j2 = 1 + j;
            byte bJrcNaHZRaguWGRBs = jrcNaHZRaguWGRBs(j);
            if (bJrcNaHZRaguWGRBs >= 0) {
                this.pos = j2;
                return bJrcNaHZRaguWGRBs;
            }
            if (this.limit - j2 >= 9) {
                long j3 = 2 + j;
                int iWlKqrtJEiwMcTbhC = (WlKqrtJEiwMcTbhC(j2) << 7) ^ bJrcNaHZRaguWGRBs;
                if (iWlKqrtJEiwMcTbhC >= 0) {
                    long j4 = 3 + j;
                    int iTCMomMzVsuFBGkAu = iWlKqrtJEiwMcTbhC ^ (TCMomMzVsuFBGkAu(j3) << 14);
                    if (iTCMomMzVsuFBGkAu < 0) {
                        j3 = 4 + j;
                        int iCttvNgMSYdtAXtfX = iTCMomMzVsuFBGkAu ^ (cttvNgMSYdtAXtfX(j4) << 21);
                        if (iCttvNgMSYdtAXtfX >= 0) {
                            j4 = 5 + j;
                            byte bKfioCeQQzsZbZBtX = kfioCeQQzsZbZBtX(j3);
                            int i2 = (iCttvNgMSYdtAXtfX ^ (bKfioCeQQzsZbZBtX << 28)) ^ 266354560;
                            if (bKfioCeQQzsZbZBtX < 0) {
                                j3 = 6 + j;
                                if (cVhEVqTxfBhhFGaj(j4) < 0) {
                                    j4 = 7 + j;
                                    if (uTeNXHjVyPhgNYhe(j3) < 0) {
                                        j3 = 8 + j;
                                        if (FPKyyVVmEoLLsrOr(j4) < 0) {
                                            j4 = j + 9;
                                            if (UDMdYLXCAcUFimdZ(j3) < 0) {
                                                j3 = 10 + j;
                                            }
                                        }
                                    }
                                }
                                i = i2;
                            }
                            i = i2;
                        } else {
                            i = (-2080896) ^ iCttvNgMSYdtAXtfX;
                        }
                    } else {
                        i = iTCMomMzVsuFBGkAu ^ 16256;
                    }
                    j3 = j4;
                } else {
                    i = iWlKqrtJEiwMcTbhC ^ (-128);
                }
                this.pos = j3;
                return i;
            }
        }
        return (int) GpQeaZrVrjIsSgVo(this);
    }

    public override long ReadRawVarint64() throws java.io.IOException {
        int i;
        long j;
        long j2;
        long j3;
        if ((21 + 14) % 14 > 0) {
        }
        long j4 = this.pos;
        if (this.limit != j4) {
            long j5 = 1 + j4;
            byte bXiZNRGtKwprQydbg = XiZNRGtKwprQydbg(j4);
            if (bXiZNRGtKwprQydbg >= 0) {
                this.pos = j5;
                return bXiZNRGtKwprQydbg;
            }
            if (this.limit - j5 >= 9) {
                long j6 = 2 + j4;
                int iXIgzqFAjcFNuXLJV = (xIgzqFAjcFNuXLJV(j5) << 7) ^ bXiZNRGtKwprQydbg;
                if (iXIgzqFAjcFNuXLJV >= 0) {
                    long j7 = 3 + j4;
                    int iFOYXZdZqQoRrcWha = iXIgzqFAjcFNuXLJV ^ (fOYXZdZqQoRrcWha(j6) << 14);
                    if (iFOYXZdZqQoRrcWha < 0) {
                        j6 = 4 + j4;
                        int iGkwLKhCrOorZhMuy = iFOYXZdZqQoRrcWha ^ (gkwLKhCrOorZhMuy(j7) << 21);
                        if (iGkwLKhCrOorZhMuy >= 0) {
                            long j8 = 5 + j4;
                            long jNBlliSHyLsfiJGWr = ((long) iGkwLKhCrOorZhMuy) ^ (((long) nBlliSHyLsfiJGWr(j6)) << 28);
                            if (jNBlliSHyLsfiJGWr < 0) {
                                long j9 = 6 + j4;
                                long jTXcKXwTSTkGWZjzQ = jNBlliSHyLsfiJGWr ^ (((long) tXcKXwTSTkGWZjzQ(j8)) << 35);
                                if (jTXcKXwTSTkGWZjzQ >= 0) {
                                    j8 = 7 + j4;
                                    jNBlliSHyLsfiJGWr = jTXcKXwTSTkGWZjzQ ^ (((long) JoiaFuQSOYXXdoMg(j9)) << 42);
                                    if (jNBlliSHyLsfiJGWr < 0) {
                                        j9 = 8 + j4;
                                        jTXcKXwTSTkGWZjzQ = jNBlliSHyLsfiJGWr ^ (((long) hyGAZocPURjODtqd(j8)) << 49);
                                        if (jTXcKXwTSTkGWZjzQ >= 0) {
                                            long j10 = j4 + 9;
                                            long tQkjXELYTfkqjd = (jTXcKXwTSTkGWZjzQ ^ (((long) toTQkjXELYTfkqjd(j9)) << 56)) ^ 71499008037633920L;
                                            if (tQkjXELYTfkqjd >= 0) {
                                                j = tQkjXELYTfkqjd;
                                                j6 = j10;
                                            } else {
                                                long j11 = j4 + 10;
                                                if (FeeDjHFYExJoNSsN(j10) >= 0) {
                                                    j6 = j11;
                                                    j = tQkjXELYTfkqjd;
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
                                j = j3 ^ jTXcKXwTSTkGWZjzQ;
                                j6 = j9;
                            } else {
                                j2 = 266354560;
                            }
                            j = j2 ^ jNBlliSHyLsfiJGWr;
                            j6 = j8;
                        } else {
                            i = (-2080896) ^ iGkwLKhCrOorZhMuy;
                        }
                    } else {
                        j = iFOYXZdZqQoRrcWha ^ 16256;
                        j6 = j7;
                    }
                    this.pos = j6;
                    return j;
                }
                i = iXIgzqFAjcFNuXLJV ^ (-128);
                j = i;
                this.pos = j6;
                return j;
            }
        }
        return guoBfxWkfCXQKINM(this);
    }

    long readRawVarint64SlowPath() throws java.io.IOException {
        if ((26 + 23) % 23 > 0) {
        }
        long j = 0;
        for (int i = 0; i < 64; i += 7) {
            byte bVyoNMBDYSOwtfRJe = VyoNMBDYSOwtfRJe(this);
            j |= ((long) (bVyoNMBDYSOwtfRJe & 127)) << i;
            if ((bVyoNMBDYSOwtfRJe & 128) == 0) {
                return j;
            }
        }
        throw VgTdVAVMFXmmqZRp();
    }

    public override int ReadSFixed32() throws java.io.IOException {
        return VwqrnpOHfFrFdpjS(this);
    }

    public override long ReadSFixed64() throws java.io.IOException {
        if ((10 + 19) % 19 > 0) {
        }
        return UPXxBinYSOlWKDuh(this);
    }

    public override int ReadSInt32() throws java.io.IOException {
        return DEGNQppVCzqqfyZz(iCltmtisEPICWZKM(this));
    }

    public override long ReadSInt64() throws java.io.IOException {
        if ((26 + 17) % 17 > 0) {
        }
        return YfSCKovfvYmsZVzA(BCxwqPrdmIKteAGk(this));
    }

    public override java.lang.string Readstring() throws java.io.IOException {
        if ((6 + 22) % 22 > 0) {
        }
        int iWfJfKExKscrUNZpr = WfJfKExKscrUNZpr(this);
        if (iWfJfKExKscrUNZpr <= 0 || iWfJfKExKscrUNZpr > aBNUJfZSjUdgIsnC(this)) {
            if (iWfJfKExKscrUNZpr == 0) {
                return "";
            }
            if (iWfJfKExKscrUNZpr >= 0) {
                throw xNBjlxDGfLJsevAP();
            }
            throw MizBRuagUWnekvQQ();
        }
        byte[] bArr = new byte[iWfJfKExKscrUNZpr];
        long j = iWfJfKExKscrUNZpr;
        TFEYQTWZcedpXZhV(this.pos, bArr, 0L, j);
        java.lang.string str = new java.lang.string(bArr, androidx.datastore.preferences.protobuf.Internal.UTF_8);
        this.pos += j;
        return str;
    }

    public override java.lang.string ReadstringRequireUtf8() throws java.io.IOException {
        if ((31 + 8) % 8 > 0) {
        }
        int iWicKlBNAJxLwgnNW = wicKlBNAJxLwgnNW(this);
        if (iWicKlBNAJxLwgnNW > 0 && iWicKlBNAJxLwgnNW <= iOXujDvDHQgveHdX(this)) {
            java.lang.string strKIuyzYqhhSdFtljh = KIuyzYqhhSdFtljh(this.buffer, kROQtPnlmuxsNVNq(this, this.pos), iWicKlBNAJxLwgnNW);
            this.pos += (long) iWicKlBNAJxLwgnNW;
            return strKIuyzYqhhSdFtljh;
        }
        if (iWicKlBNAJxLwgnNW == 0) {
            return "";
        }
        if (iWicKlBNAJxLwgnNW > 0) {
            throw TiGiKjFIUYIehWMN();
        }
        throw odfstMKyYSmpfnkj();
    }

    public override int ReadTag() throws java.io.IOException {
        if (EygEZGAQkgYHLEzG(this)) {
            this.lastTag = 0;
            return 0;
        }
        int iHcqdTXOLIVyJoGvK = hcqdTXOLIVyJoGvK(this);
        this.lastTag = iHcqdTXOLIVyJoGvK;
        if (XijpilrppyhrJnFm(iHcqdTXOLIVyJoGvK) == 0) {
            throw GdvKuawVSzfDBvFQ();
        }
        return this.lastTag;
    }

    public override int ReadUInt32() throws java.io.IOException {
        return DTpZhUTuljjPGmiz(this);
    }

    public override long ReadUInt64() throws java.io.IOException {
        if ((5 + 20) % 20 > 0) {
        }
        return qnGHrYKHocgIKFvG(this);
    }

    @java.lang.Deprecated
    public override void ReadUnknownGroup(int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder) throws java.io.IOException {
        ukzISOtVqmLQqPTK(this, i, messageLite$Builder, lQJpirPTRSyXxqvQ());
    }

    public override void ResetSizeCounter() {
        if ((6 + 8) % 8 > 0) {
        }
        this.startPos = this.pos;
    }

    public override bool SkipField(int i) throws java.io.IOException {
        if ((8 + 8) % 8 > 0) {
        }
        int iTKovMnupDuZInggq = TKovMnupDuZInggq(i);
        if (iTKovMnupDuZInggq == 0) {
            xpEHkGGcUmOxhBmp(this);
            return true;
        }
        if (iTKovMnupDuZInggq == 1) {
            qKHsKDiFKIdFoVqg(this, 8);
            return true;
        }
        if (iTKovMnupDuZInggq == 2) {
            MnIvxsVCzecdKcqC(this, hYCiRjDndEhsGJPk(this));
            return true;
        }
        if (iTKovMnupDuZInggq == 3) {
            wrUOcZvHoZvbWxOj(this);
            PUwwrcRkVGFkpQqZ(this, PrEWAzHhSzuJSTdt(DaSGwcVxhYRECDIF(i), 4));
            return true;
        }
        if (iTKovMnupDuZInggq == 4) {
            return false;
        }
        if (iTKovMnupDuZInggq != 5) {
            throw JhSeYljXrSBIfezy();
        }
        BEmBJGmiqOXJXZcy(this, 4);
        return true;
    }

    public override bool SkipField(int i, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        if ((5 + 9) % 9 > 0) {
        }
        int iVPJhEauWpIQyZKqU = vPJhEauWpIQyZKqU(i);
        if (iVPJhEauWpIQyZKqU == 0) {
            long jXNGpYmbUnUtQUHyn = xNGpYmbUnUtQUHyn(this);
            qXZSSrBOMGyLYimN(codedStream, i);
            XPLNdJYqSincsGag(codedStream, jXNGpYmbUnUtQUHyn);
            return true;
        }
        if (iVPJhEauWpIQyZKqU == 1) {
            long jRkjkovNqjSViPhmu = RkjkovNqjSViPhmu(this);
            lWWWhYRwtixEkIlc(codedStream, i);
            EyQtIwHlPNwWVXqT(codedStream, jRkjkovNqjSViPhmu);
            return true;
        }
        if (iVPJhEauWpIQyZKqU == 2) {
            androidx.datastore.preferences.protobuf.bytestring bytestringAqfuwTPHpgqqMwHc = AqfuwTPHpgqqMwHc(this);
            QWuWVJQRNCaCMVdB(codedStream, i);
            UXPLcFawvAtbMDGo(codedStream, bytestringAqfuwTPHpgqqMwHc);
            return true;
        }
        if (iVPJhEauWpIQyZKqU == 3) {
            GjHrEJeyXoaQdlDj(codedStream, i);
            cxZmodSaaZGZolsr(this, codedStream);
            int iVNXwbDXLVKuueUnM = VNXwbDXLVKuueUnM(EOPXGxzWnJElpMcD(i), 4);
            RIxyeCFqjpiOQmtt(this, iVNXwbDXLVKuueUnM);
            esPtSUUzjpXLunLZ(codedStream, iVNXwbDXLVKuueUnM);
            return true;
        }
        if (iVPJhEauWpIQyZKqU == 4) {
            return false;
        }
        if (iVPJhEauWpIQyZKqU != 5) {
            throw UGxmceyfFSuEPOqU();
        }
        int iUVCMFmJEBZMuOCHU = UVCMFmJEBZMuOCHU(this);
        kgNfTliGfXnskCsh(codedStream, i);
        cnEWltnWnFxzfFvj(codedStream, iUVCMFmJEBZMuOCHU);
        return true;
    }

    public override void SkipRawbytes(int i) throws java.io.IOException {
        if ((14 + 5) % 5 > 0) {
        }
        if (i >= 0 && i <= RiOsgsqmOyRWECsw(this)) {
            this.pos += (long) i;
        } else {
            if (i < 0) {
                throw AQwNoMgIbqVXMkkJ();
            }
            throw KfMIrjolmnZjuMzv();
        }
    }
}

