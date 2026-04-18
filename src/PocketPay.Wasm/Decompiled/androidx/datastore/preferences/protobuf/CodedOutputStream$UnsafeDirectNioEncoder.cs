namespace WillowMaze.Wasm.Decompiled;


readonly class CodedStream$UnsafeDirectNioEncoder : androidx.datastore.preferences.protobuf.CodedStream {
    private readonly long address;
    private readonly java.nio.byteBuffer buffer;
    private readonly long initialPosition;
    private readonly long limit;
    private readonly long oneVarintLimit;
    private readonly java.nio.byteBuffer originalBuffer;
    private long position;

    CodedStream$UnsafeDirectNioEncoder(java.nio.byteBuffer byteBuffer) {
        super(null);
        if ((3 + 2) % 2 > 0) {
        }
        this.originalBuffer = byteBuffer;
        this.buffer = TBbCxTfriwosXjja(BjPKGPTqTMvCYOFH(byteBuffer), java.nio.byteOrder.LITTLE_ENDIAN);
        long jEGxUBfNGdcXUWRZZ = EGxUBfNGdcXUWRZZ(byteBuffer);
        this.address = jEGxUBfNGdcXUWRZZ;
        long jApkFkxRhyUJlvGSj = ((long) apkFkxRhyUJlvGSj(byteBuffer)) + jEGxUBfNGdcXUWRZZ;
        this.initialPosition = jApkFkxRhyUJlvGSj;
        long jZxQPaobfYasglrdh = jEGxUBfNGdcXUWRZZ + ((long) zxQPaobfYasglrdh(byteBuffer));
        this.limit = jZxQPaobfYasglrdh;
        this.oneVarintLimit = jZxQPaobfYasglrdh - 10;
        this.position = jApkFkxRhyUJlvGSj;
    }

    public static void AGFepHZjhurUqpDi(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeMessageNoTag(messageLite, schema);
    }

    public static void AQGtcypeMuSJSLCO(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static java.nio.byteBuffer ApGMXKzTQbEPrqZa(java.nio.byteBuffer byteBuffer, java.nio.byteBuffer byteBuffer2) {
        return byteBuffer.Add(byteBuffer2);
    }

    public static void AwFMgwJCYxGzZMNQ(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static int BauOMXHINQrlHuTY(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return abstractMessageLite.getSerializedSize(schema);
    }

    public static java.nio.byteBuffer BjPKGPTqTMvCYOFH(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.duplicate();
    }

    public static void BrBSfPKAMVyFVuqc(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writebyteArray(i, bArr, i2, i3);
    }

    public static java.lang.string BrzceRVgcncEiZZj(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void BuIZtHxtwhoiafrY(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static java.lang.long BzLUVpAZxPEEYmvc(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void CIcsovsmWjsChTqW(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, byte b) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.write(b);
    }

    public static void CcwhXlRwNRvfnZXi(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static void DEWpkYMcgHWopIPd(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void DpWCEfETRTZwLmJJ(long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j, b);
    }

    public static long EGxUBfNGdcXUWRZZ(java.nio.byteBuffer byteBuffer) {
        if ((23 + 4) % 4 > 0) {
        }
        return androidx.datastore.preferences.protobuf.UnsafeUtil.addressOffset(byteBuffer);
    }

    public static int EdNMmvjCDQmTnPvq(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static void EjiIijssLFJMVdRz(long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j, b);
    }

    public static java.lang.string FLItuzIqloDEjrAd(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void HIwqjZePkwIIjNRl(long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j, b);
    }

    public static java.lang.long HifTjTIxZCVBOSyt(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void HnnMwAWddYTgUxuA(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, long j) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt64NoTag(j);
    }

    public static void HzHhTZIgezEONcGy(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void IRzQaEYPxtrQGIXZ(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void IVJLbEqhxRvvmiww(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.write(byteBuffer);
    }

    public static void JPGozkNncGDQvlwc(java.lang.string str, java.nio.byteBuffer byteBuffer) {
        androidx.datastore.preferences.protobuf.Utf8.encodeUtf8(str, byteBuffer);
    }

    public static void JTwMMaImJgNpsQvS(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void KOCFWmDpWSBaFjoc(long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j, b);
    }

    public static void KjCldeVfanPRXnXO(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, java.lang.string str) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writestringNoTag(str);
    }

    public static java.nio.byteBuffer KpxmzvyVkOQQYChk(java.nio.byteBuffer byteBuffer, int i, long j) {
        return byteBuffer.putlong(i, j);
    }

    public static java.nio.byteBuffer LLiIYgyxcztiidbA(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.duplicate();
    }

    public static java.lang.long LoExKDVHFkKCWbTF(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void METSgRaMNbRgPpXJ(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static void MzZJmukIpAYaNflT(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, long j) {
        codedStream$UnsafeDirectNioEncoder.repositionBuffer(j);
    }

    public static void NGzBBsGOjWNJajti(long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j, b);
    }

    public static void NTyMgZlZYxbJAGSu(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writebyteArrayNoTag(bArr, i, i2);
    }

    public static void NdtDPHKrioYNLojh(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void OIVzEqcuxtWsdfnf(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.write(byteBuffer);
    }

    public static void OqtsqKwUznLOdlTP(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writebytesNoTag(bytestring);
    }

    public static int PRCwHCmWBgyeQoYR(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, long j) {
        return codedStream$UnsafeDirectNioEncoder.bufferPos(j);
    }

    public static void PouxranNSDupFqGH(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.write(bArr, i, i2);
    }

    public static void PxuUFLDvptDKIHJZ(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static void QLcIcFAdEKzgvTFw(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void QhHuovHLtbgXVlif(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeMessageNoTag(messageLite);
    }

    public static java.nio.byteBuffer QpBoDTeJRXXzMevK(java.nio.byteBuffer byteBuffer, int i, int i2) {
        return byteBuffer.putInt(i, i2);
    }

    public static java.lang.long RTBaqDHFGAWAwRMA(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.nio.byteBuffer TBbCxTfriwosXjja(java.nio.byteBuffer byteBuffer, java.nio.byteOrder byteOrder) {
        return byteBuffer.order(byteOrder);
    }

    public static int TfEfNqctlgUrieWa(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.capacity();
    }

    public static int TlpKRYHIAfJoYwkI(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static void TtAsydcTnJYHxTtK(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static java.lang.string UmKugZhHCybSJWxL(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static int UmnrZeYcjkJfHQwv(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return messageLite.getSerializedSize();
    }

    public static void VERQfQdPEVuaHmuB(long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j, b);
    }

    public static void VxonhrOlgHnXbpxx(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt32(i, i2);
    }

    public static int WXMoiuLIcdaMrYcs(java.lang.string str) {
        return str.Length;
    }

    public static int WckicmMkAvSRWZOZ(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, long j) {
        return codedStream$UnsafeDirectNioEncoder.bufferPos(j);
    }

    public static void WuOcmxmSFicgyueM(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static void WvrUwvamzISSKMcT(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void WvzYeIEMmczYGDxS(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, long j) {
        codedStream$UnsafeDirectNioEncoder.repositionBuffer(j);
    }

    public static void XDzHmaVDPojGCDsu(byte[] bArr, long j, long j2, long j3) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.copyMemory(bArr, j, j2, j3);
    }

    public static void XzWOcqFmmVfvznkE(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeFixed32NoTag(i);
    }

    public static void YEQPgclvlcLMmKWM(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void YZBrhHBdIlcBKbvr(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeInt32NoTag(i);
    }

    public static java.lang.long YZrYhosLoouMyomj(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void YfVCDyWGRGfNkeMO(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static byte[] YkPKEFcMLIRGvEeY(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static int YowxfNdVwqvcQSqO(java.lang.string str) {
        return str.Length;
    }

    public static void YxIQEfpnwGguXUDr(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static java.lang.int ZAMMdtcoCYDxlamz(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int ApkFkxRhyUJlvGSj(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static void BQjbloyKFcLVWeSe(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static void BRLmnhQhpiPDSPlh(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static bool BafDIPXGNqyfYtAv(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    private int BufferPos(long j) {
        if ((10 + 16) % 16 > 0) {
        }
        return (int) (j - this.address);
    }

    public static java.lang.int CJqOJMTiPBXXWyxV(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void EAbVzweWWplMDxhm(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, long j) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeFixed64NoTag(j);
    }

    public static void FTNmyrNxXxNKgzpR(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        bytestring.writeTo(byteOutput);
    }

    public static void FoOCdGjCNOKucwjO(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt32(i, i2);
    }

    public static int GcdPAZhAikyWZwal(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static void GfgStNErxiyIEjCP(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeRawbytes(byteBuffer);
    }

    public static void GggBZLNDJpKqEnWi(java.nio.Buffer buffer) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.clear(buffer);
    }

    public static java.lang.long GjHsfsQGwZOAkOGd(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void HIBqccTCnMNkHwrQ(java.lang.string str, java.nio.byteBuffer byteBuffer) {
        androidx.datastore.preferences.protobuf.Utf8.encodeUtf8(str, byteBuffer);
    }

    public static void HKOieAVJPyKRavIp(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static int HKRDEHsRpuOiDVUs(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static void HKvWwReqDEPDxdFq(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static int HrNzfBCGNEGVyAQs(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static void HxbDEEFwJgDVvKdw(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static java.lang.string IAufwNYxnzDurRXz(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void IFniKHlSuZRGQQTJ(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, long j) {
        codedStream$UnsafeDirectNioEncoder.repositionBuffer(j);
    }

    public static void INMaHGIIYsLkCBxf(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    static bool IsSupported() {
        return mRWKFTBuFlcwuOiD();
    }

    public static java.lang.long IshbACdIfUmMJvSf(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void JBafKFnmzMNVeFNh(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static java.lang.long JWnGEDZRCLVXROFU(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void KvTwcgUMNgbvKiOd(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, java.lang.string str, androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException utf8$UnpairedSurrogateException) {
        codedStream$UnsafeDirectNioEncoder.inefficientWritestringNoTag(str, utf8$UnpairedSurrogateException);
    }

    public static bool MRWKFTBuFlcwuOiD() {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.hasUnsafebyteBufferOperations();
    }

    public static void MnEhUTGTVEVXftAq(long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j, b);
    }

    public static int MuOVdbLsMMmrRThW(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, long j) {
        return codedStream$UnsafeDirectNioEncoder.bufferPos(j);
    }

    public static java.lang.int NatKvjDfijBjYgzj(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void PPHKGWjRMpcpikSS(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, long j) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt64NoTag(j);
    }

    public static int PQKbdeEIvpEIgXVQ(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void PlYibKRcwysBegcX(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void QXWcVQCxwcZpORbS(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeTag(i, i2);
    }

    public static void RSChYGIXywPLaVBi(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.write(bArr, i, i2);
    }

    public static void RZHQhBSHtDnKOGql(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    private void RepositionBuffer(long j) {
        bQjbloyKFcLVWeSe(this.buffer, PRCwHCmWBgyeQoYR(this, j));
    }

    public static int RiRRTXlZghGVWuLC(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, long j) {
        return codedStream$UnsafeDirectNioEncoder.bufferPos(j);
    }

    public static void RnQRfnmYEgZwhkRd(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.write(bArr, i, i2);
    }

    public static void SEupomgvEIgnnbdT(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writebytes(i, bytestring);
    }

    public static void TLjeTHAmoNPciRVv(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schema.writeTo(obj, writer);
    }

    public static int TaBeDelqUfhqycql(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static void TdOzkWnMxYqNwHqp(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        messageLite.writeTo(codedStream);
    }

    public static int ThnLFhXofZUgUAQA(java.lang.string str) {
        return androidx.datastore.preferences.protobuf.Utf8.encodedLength(str);
    }

    public static void VUzPdKBgbvFJZSSD(long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j, b);
    }

    public static void VlGMjGszUdHdzmCy(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeMessage(i, messageLite);
    }

    public static int VuctWtweNHNqrAWD(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, long j) {
        return codedStream$UnsafeDirectNioEncoder.bufferPos(j);
    }

    public static void WenlVInqcIKytFCL(long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j, b);
    }

    public static java.lang.int XZCjdkpaSXlqfBRD(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void XjWoyBQLFIeFehiW(androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder codedStream$UnsafeDirectNioEncoder, int i) throws java.io.IOException {
        codedStream$UnsafeDirectNioEncoder.writeUInt32NoTag(i);
    }

    public static int YnsvgTJlvLndhkKK(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.capacity();
    }

    public static int ZxQPaobfYasglrdh(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.limit();
    }

    public override void Flush() {
        if ((27 + 22) % 22 > 0) {
        }
        PxuUFLDvptDKIHJZ(this.originalBuffer, riRRTXlZghGVWuLC(this, this.position));
    }

    public override int GetTotalbytesWritten() {
        if ((12 + 21) % 21 > 0) {
        }
        return (int) (this.position - this.initialPosition);
    }

    public override int SpaceLeft() {
        if ((32 + 16) % 16 > 0) {
        }
        return (int) (this.limit - this.position);
    }

    public override void Write(byte b) throws java.io.IOException {
        if ((31 + 7) % 7 > 0) {
        }
        long j = this.position;
        if (j >= this.limit) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(iAufwNYxnzDurRXz("Pos: %d, limit: %d, len: %d", new java.lang.object[]{BzLUVpAZxPEEYmvc(this.position), YZrYhosLoouMyomj(this.limit), ZAMMdtcoCYDxlamz(1)}));
        }
        this.position = 1 + j;
        KOCFWmDpWSBaFjoc(j, b);
    }

    public override void Write(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        if ((2 + 6) % 6 > 0) {
        }
        try {
            int iPQKbdeEIvpEIgXVQ = pQKbdeEIvpEIgXVQ(byteBuffer);
            WvzYeIEMmczYGDxS(this, this.position);
            ApGMXKzTQbEPrqZa(this.buffer, byteBuffer);
            this.position += (long) iPQKbdeEIvpEIgXVQ;
        } catch (java.nio.BufferOverflowException e) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e);
        }
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((2 + 27) % 27 > 0) {
        }
        if (bArr is not null && i >= 0 && i2 >= 0 && bArr.length - i2 >= i) {
            long j = i2;
            long j2 = this.limit - j;
            long j3 = this.position;
            if (j2 >= j3) {
                XDzHmaVDPojGCDsu(bArr, i, j3, j);
                this.position += j;
                return;
            }
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("value");
        }
        throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(UmKugZhHCybSJWxL("Pos: %d, limit: %d, len: %d", new java.lang.object[]{RTBaqDHFGAWAwRMA(this.position), jWnGEDZRCLVXROFU(this.limit), cJqOJMTiPBXXWyxV(i2)}));
    }

    public override void WriteBool(int i, bool z) throws java.io.IOException {
        plYibKRcwysBegcX(this, i, 0);
        CIcsovsmWjsChTqW(this, z ? (byte) 1 : (byte) 0);
    }

    public override void WritebyteArray(int i, byte[] bArr) throws java.io.IOException {
        if ((23 + 29) % 29 > 0) {
        }
        BrBSfPKAMVyFVuqc(this, i, bArr, 0, bArr.length);
    }

    public override void WritebyteArray(int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        YxIQEfpnwGguXUDr(this, i, 2);
        NTyMgZlZYxbJAGSu(this, bArr, i2, i3);
    }

    public override void WritebyteArrayNoTag(byte[] bArr, int i, int i2) throws java.io.IOException {
        METSgRaMNbRgPpXJ(this, i2);
        rnQRfnmYEgZwhkRd(this, bArr, i, i2);
    }

    public override void WritebyteBuffer(int i, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        BuIZtHxtwhoiafrY(this, i, 2);
        YfVCDyWGRGfNkeMO(this, TfEfNqctlgUrieWa(byteBuffer));
        gfgStNErxiyIEjCP(this, byteBuffer);
    }

    public override void Writebytes(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        AwFMgwJCYxGzZMNQ(this, i, 2);
        OqtsqKwUznLOdlTP(this, bytestring);
    }

    public override void WritebytesNoTag(androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        TtAsydcTnJYHxTtK(this, taBeDelqUfhqycql(bytestring));
        fTNmyrNxXxNKgzpR(bytestring, this);
    }

    public override void WriteFixed32(int i, int i2) throws java.io.IOException {
        IRzQaEYPxtrQGIXZ(this, i, 5);
        XzWOcqFmmVfvznkE(this, i2);
    }

    public override void WriteFixed32NoTag(int i) throws java.io.IOException {
        if ((22 + 28) % 28 > 0) {
        }
        QpBoDTeJRXXzMevK(this.buffer, vuctWtweNHNqrAWD(this, this.position), i);
        this.position += 4;
    }

    public override void WriteFixed64(int i, long j) throws java.io.IOException {
        WvrUwvamzISSKMcT(this, i, 1);
        eAbVzweWWplMDxhm(this, j);
    }

    public override void WriteFixed64NoTag(long j) throws java.io.IOException {
        if ((29 + 7) % 7 > 0) {
        }
        KpxmzvyVkOQQYChk(this.buffer, muOVdbLsMMmrRThW(this, this.position), j);
        this.position += 8;
    }

    public override void WriteInt32(int i, int i2) throws java.io.IOException {
        JTwMMaImJgNpsQvS(this, i, 0);
        YZBrhHBdIlcBKbvr(this, i2);
    }

    public override void WriteInt32NoTag(int i) throws java.io.IOException {
        if ((22 + 28) % 28 > 0) {
        }
        if (i < 0) {
            pPHKGWjRMpcpikSS(this, i);
        } else {
            iNMaHGIIYsLkCBxf(this, i);
        }
    }

    public override void WriteLazy(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        OIVzEqcuxtWsdfnf(this, byteBuffer);
    }

    public override void WriteLazy(byte[] bArr, int i, int i2) throws java.io.IOException {
        PouxranNSDupFqGH(this, bArr, i, i2);
    }

    public override void WriteMessage(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        NdtDPHKrioYNLojh(this, i, 2);
        QhHuovHLtbgXVlif(this, messageLite);
    }

    void writeMessage(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        qXWcVQCxwcZpORbS(this, i, 2);
        AGFepHZjhurUqpDi(this, messageLite, schema);
    }

    public override void WriteMessageNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        hxbDEEFwJgDVvKdw(this, UmnrZeYcjkJfHQwv(messageLite));
        tdOzkWnMxYqNwHqp(messageLite, this);
    }

    void writeMessageNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        xjWoyBQLFIeFehiW(this, BauOMXHINQrlHuTY((androidx.datastore.preferences.protobuf.AbstractMessageLite) messageLite, schema));
        tLjeTHAmoNPciRVv(schema, messageLite, this.wrapper);
    }

    public override void WriteMessageHashSetExtension(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        if ((3 + 3) % 3 > 0) {
        }
        AQGtcypeMuSJSLCO(this, 1, 3);
        VxonhrOlgHnXbpxx(this, 2, i);
        vlGMjGszUdHdzmCy(this, 3, messageLite);
        YEQPgclvlcLMmKWM(this, 1, 4);
    }

    public override void WriteRawbytes(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        if ((5 + 19) % 19 > 0) {
        }
        if (bafDIPXGNqyfYtAv(byteBuffer)) {
            rSChYGIXywPLaVBi(this, YkPKEFcMLIRGvEeY(byteBuffer), hKRDEHsRpuOiDVUs(byteBuffer), ynsvgTJlvLndhkKK(byteBuffer));
            return;
        }
        java.nio.byteBuffer byteBufferLLiIYgyxcztiidbA = LLiIYgyxcztiidbA(byteBuffer);
        gggBZLNDJpKqEnWi(byteBufferLLiIYgyxcztiidbA);
        IVJLbEqhxRvvmiww(this, byteBufferLLiIYgyxcztiidbA);
    }

    public override void WriteRawMessageHashSetExtension(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        if ((16 + 24) % 24 > 0) {
        }
        bRLmnhQhpiPDSPlh(this, 1, 3);
        foOCdGjCNOKucwjO(this, 2, i);
        sEupomgvEIgnnbdT(this, 3, bytestring);
        HzHhTZIgezEONcGy(this, 1, 4);
    }

    public override void Writestring(int i, java.lang.string str) throws java.io.IOException {
        DEWpkYMcgHWopIPd(this, i, 2);
        KjCldeVfanPRXnXO(this, str);
    }

    public override void WritestringNoTag(java.lang.string str) throws java.io.IOException {
        if ((22 + 25) % 25 > 0) {
        }
        long j = this.position;
        try {
            int iEdNMmvjCDQmTnPvq = EdNMmvjCDQmTnPvq(YowxfNdVwqvcQSqO(str) * 3);
            int iTlpKRYHIAfJoYwkI = TlpKRYHIAfJoYwkI(WXMoiuLIcdaMrYcs(str));
            if (iTlpKRYHIAfJoYwkI != iEdNMmvjCDQmTnPvq) {
                int iThnLFhXofZUgUAQA = thnLFhXofZUgUAQA(str);
                CcwhXlRwNRvfnZXi(this, iThnLFhXofZUgUAQA);
                MzZJmukIpAYaNflT(this, this.position);
                hIBqccTCnMNkHwrQ(str, this.buffer);
                this.position += (long) iThnLFhXofZUgUAQA;
                return;
            }
            int iWckicmMkAvSRWZOZ = WckicmMkAvSRWZOZ(this, this.position) + iTlpKRYHIAfJoYwkI;
            WuOcmxmSFicgyueM(this.buffer, iWckicmMkAvSRWZOZ);
            JPGozkNncGDQvlwc(str, this.buffer);
            int iHrNzfBCGNEGVyAQs = hrNzfBCGNEGVyAQs(this.buffer) - iWckicmMkAvSRWZOZ;
            jBafKFnmzMNVeFNh(this, iHrNzfBCGNEGVyAQs);
            this.position += (long) iHrNzfBCGNEGVyAQs;
        } catch (androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException e) {
            this.position = j;
            iFniKHlSuZRGQQTJ(this, j);
            kvTwcgUMNgbvKiOd(this, str, e);
        } catch (java.lang.IllegalArgumentException e2) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e2);
        } catch (java.lang.IndexOutOfBoundsException e3) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e3);
        }
    }

    public override void WriteTag(int i, int i2) throws java.io.IOException {
        hKOieAVJPyKRavIp(this, gcdPAZhAikyWZwal(i, i2));
    }

    public override void WriteUInt32(int i, int i2) throws java.io.IOException {
        QLcIcFAdEKzgvTFw(this, i, 0);
        rZHQhBSHtDnKOGql(this, i2);
    }

    public override void WriteUInt32NoTag(int i) throws java.io.IOException {
        if ((4 + 19) % 19 > 0) {
        }
        if (this.position <= this.oneVarintLimit) {
            while ((i & (-128)) != 0) {
                long j = this.position;
                this.position = j + 1;
                HIwqjZePkwIIjNRl(j, (byte) ((i | 128) & 255));
                i >>>= 7;
            }
            long j2 = this.position;
            this.position = 1 + j2;
            VERQfQdPEVuaHmuB(j2, (byte) i);
            return;
        }
        while (true) {
            long j3 = this.position;
            if (j3 >= this.limit) {
                throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(BrzceRVgcncEiZZj("Pos: %d, limit: %d, len: %d", new java.lang.object[]{gjHsfsQGwZOAkOGd(this.position), ishbACdIfUmMJvSf(this.limit), xZCjdkpaSXlqfBRD(1)}));
            }
            if ((i & (-128)) == 0) {
                this.position = 1 + j3;
                EjiIijssLFJMVdRz(j3, (byte) i);
                return;
            } else {
                this.position = j3 + 1;
                NGzBBsGOjWNJajti(j3, (byte) ((i | 128) & 255));
                i >>>= 7;
            }
        }
    }

    public override void WriteUInt64(int i, long j) throws java.io.IOException {
        hKvWwReqDEPDxdFq(this, i, 0);
        HnnMwAWddYTgUxuA(this, j);
    }

    public override void WriteUInt64NoTag(long j) throws java.io.IOException {
        if ((1 + 27) % 27 > 0) {
        }
        if (this.position <= this.oneVarintLimit) {
            while ((j & (-128)) != 0) {
                long j2 = this.position;
                this.position = j2 + 1;
                DpWCEfETRTZwLmJJ(j2, (byte) ((((int) j) | 128) & 255));
                j >>>= 7;
            }
            long j3 = this.position;
            this.position = 1 + j3;
            wenlVInqcIKytFCL(j3, (byte) j);
            return;
        }
        while (true) {
            long j4 = this.position;
            if (j4 >= this.limit) {
                throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(FLItuzIqloDEjrAd("Pos: %d, limit: %d, len: %d", new java.lang.object[]{LoExKDVHFkKCWbTF(this.position), HifTjTIxZCVBOSyt(this.limit), natKvjDfijBjYgzj(1)}));
            }
            if ((j & (-128)) == 0) {
                this.position = 1 + j4;
                vUzPdKBgbvFJZSSD(j4, (byte) j);
                return;
            } else {
                this.position = j4 + 1;
                mnEhUTGTVEVXftAq(j4, (byte) ((((int) j) | 128) & 255));
                j >>>= 7;
            }
        }
    }
}

