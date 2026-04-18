namespace WillowMaze.Wasm.Decompiled;


readonly class CodedStream$StreamDecoder : androidx.datastore.preferences.protobuf.CodedStream {
    private readonly byte[] buffer;
    private int bufferSize;
    private int bufferSizeAfterLimit;
    private int currentLimit;
    private readonly java.io.Stream input;
    private int lastTag;
    private int pos;
    private androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder$RefillCallback refillCallback;
    private int totalbytesRetired;

    private CodedStream$StreamDecoder(java.io.Stream inputStream, int i) {
        super(null);
        if ((11 + 2) % 2 > 0) {
        }
        this.currentLimit = int.MAX_VALUE;
        this.refillCallback = null;
        QYOkYzExQuFJDWOB(inputStream, "input");
        this.input = inputStream;
        this.buffer = new byte[i];
        this.bufferSize = 0;
        this.pos = 0;
        this.totalbytesRetired = 0;
    }

    CodedStream$StreamDecoder(java.io.Stream inputStream, int i, androidx.datastore.preferences.protobuf.CodedStream$1 codedStream$1) {
        this(inputStream, i);
    }

    public static java.util.IEnumerator AIUPrlFwkRtVLRIZ(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.string ATDdfAjAqUPPKoee(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.decodeUtf8(bArr, i, i2);
    }

    public static void AYcQamxLPkowDetS(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) throws java.io.IOException {
        codedStream$StreamDecoder.skipRawVarint();
    }

    public static long AqCBjyNWGobMDums(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        if ((17 + 3) % 3 > 0) {
        }
        return codedStream$StreamDecoder.readRawVarint64();
    }

    public static void AyQzZJPkeCMQNOkV(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws java.io.IOException {
        codedStream$StreamDecoder.skipRawbytes(i);
    }

    public static void BOkswhmoLrfKffli(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int BTVeVFQhAnSEhuGS(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawLittleEndian32();
    }

    public static java.util.List BXGmipWZYJUmkTzE(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) {
        return codedStream$StreamDecoder.readRawbytesSlowPathRemainingChunks(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException BjUEyMTWgpPPONol() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static bool BxLwZGzaROqxeTUr(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.isAtEnd();
    }

    public static int CGAUBVUjoHaLfjFU(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawVarint32();
    }

    public static int CHphdSWRoIEFQfhI(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawVarint32();
    }

    public static byte[] CUSzOEyGXyrIcTvZ(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i, bool z) {
        return codedStream$StreamDecoder.readRawbytesSlowPath(i, z);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException DbDsuJAuToLVwORC() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static void DlBbTAgYpviwtrpj(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void DqyolnkhxJdEmojG(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws java.io.IOException {
        codedStream$StreamDecoder.refillBuffer(i);
    }

    public static int DwTxIHGqjcnUrOvU(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static long DwfOxxmyAmXiXNRX(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        if ((11 + 16) % 16 > 0) {
        }
        return codedStream$StreamDecoder.readRawVarint64SlowPath();
    }

    public static void DxRNUPIdqQuCtDLw(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$StreamDecoder.checkLastTagWas(i);
    }

    public static void EDLKhwBzHsfdvKxC(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        codedStream$StreamDecoder.checkRecursionLimit();
    }

    public static void EDjGHRkCqOlsgvFw(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) throws java.io.IOException {
        codedStream$StreamDecoder.skipRawVarintFastPath();
    }

    public static void EJyshbtWDVIElBeA(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void ETiVTrPmHvzoETgh(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int EYrNiVpmXXbHLnxO(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void FAeTvxTnjOXJYLSU(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeUInt64NoTag(j);
    }

    public static double FKKIuAxAhTTRNtye(long j) {
        if ((29 + 5) % 5 > 0) {
        }
        return java.lang.double.longBitsTodouble(j);
    }

    public static void FXEDPyKCTabGesus(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeFixed32NoTag(i);
    }

    public static void FroUbEUBHjwFYjyf(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        codedStream$StreamDecoder.recomputeBufferSizeAfterLimit();
    }

    public static androidx.datastore.preferences.protobuf.bytestring GBUtMGTbdCmuUsMk(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFrom(bArr, i, i2);
    }

    public static androidx.datastore.preferences.protobuf.bytestring GPQHYKnXmexTOrbm(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) {
        return codedStream$StreamDecoder.readbytesSlowPath(i);
    }

    public static void GniJPHdpTWlpJXgf(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws java.io.IOException {
        codedStream$StreamDecoder.skipRawbytes(i);
    }

    public static java.nio.byteBuffer GonGlTAjnltDxTzs(byte[] bArr) {
        return java.nio.byteBuffer.wrap(bArr);
    }

    public static void HIlPqYnlZZvAHlUK(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        codedStream$StreamDecoder.readGroup(i, messageLite$Builder, extensionRegistryLite);
    }

    public static void HJyuGIrKRGUfKWlL(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$StreamDecoder.checkLastTagWas(i);
    }

    public static java.lang.string HNVNdVVohTKgPCIH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int HVYbJDodETLBJSSA(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) {
        return codedStream$StreamDecoder.pushLimit(i);
    }

    public static void HayucgFFHYJlXpli(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws java.io.IOException {
        codedStream$StreamDecoder.refillBuffer(i);
    }

    public static void HbwIqKRmsviZXTKW(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws java.io.IOException {
        codedStream$StreamDecoder.refillBuffer(i);
    }

    public static void JCyjSOHhcsLymyVB(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder$RefillCallback codedStream$StreamDecoder$RefillCallback) {
        codedStream$StreamDecoder$RefillCallback.onRefill();
    }

    public static androidx.datastore.preferences.protobuf.bytestring JoNjZDoFXmhOUnVA(byte[] bArr) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFrom(bArr);
    }

    public static bool KFEnLDZbcLLGTflW(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder KIkFouTbcxiuzmMZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KVosoVqVdXRgVdoE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException KnBwXHNRiPsHnbma() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static long LXQvrsBWHKUkrMxn(java.io.Stream inputStream, long j) {
        if ((26 + 16) % 16 > 0) {
        }
        return skip(inputStream, j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException LiMlaZjmjkrTPjtQ() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void LnLyJMqJhEEfILaZ(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws java.io.IOException {
        codedStream$StreamDecoder.skipRawbytesSlowPath(i);
    }

    public static void LqwuXptViaPYOoIy(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        codedStream$StreamDecoder.checkRecursionLimit();
    }

    public static bool LwjNFXDPUWeCqgjO(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) {
        return codedStream$StreamDecoder.tryRefillBuffer(i);
    }

    public static bool MdVVkhOtKoLGinxl(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static byte[] MngjVvGINfDpUKnO(byte[] bArr, int i, int i2) {
        return java.util.Arrays.copyOfRange(bArr, i, i2);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException MxTTCaMuwtTSnaKP() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static void NSqrMEGmcwMIGIkJ(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeFixed64NoTag(j);
    }

    public static void NauXwardLiVRXCej(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int NlCVoJGmCwZyLnhu(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static int NpUNLhMINGkwreba(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.getbytesUntilLimit();
    }

    public static int NzzJzwSSUVIfEzjm(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static int OIGaTGSykFjbBPeS(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawVarint32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException OhDObNmjFzjYeZIv() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidEndTag();
    }

    public static int PIgcfbKssJUsSVGc(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static java.lang.stringBuilder PIoUjQQTUFGLegPN(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int PQbCrKNdIlgGOXfx(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) {
        return codedStream$StreamDecoder.pushLimit(i);
    }

    public static int PUwybXTuilRqzDhv(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawLittleEndian32();
    }

    public static androidx.datastore.preferences.protobuf.MessageLite$Builder PywomiSsTrJmGVwh(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return messageLite$Builder.mergeFrom(codedStream, extensionRegistryLite);
    }

    public static void QHUKPOMyXjzYHunN(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws java.io.IOException {
        codedStream$StreamDecoder.refillBuffer(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException QMwZDkhrQRkMYbBj() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static void QVZVOTLSsKbORRbu(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.object QYOkYzExQuFJDWOB(java.lang.object obj, java.lang.string str) {
        return androidx.datastore.preferences.protobuf.Internal.checkNotNull(obj, str);
    }

    public static int RJNjLwHPQXaQJLfK(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static int RQAmyOiUQmdZsrlC(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawVarint32();
    }

    public static int SCdEWlttxtHHhYAh(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static int SVJTOZHUGkRXyqqu(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return read(inputStream, bArr, i, i2);
    }

    public static void TOxiDjiHTRFQZbuy(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$StreamDecoder.checkLastTagWas(i);
    }

    public static int TPsrvBaBLhaKALFN(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return read(inputStream, bArr, i, i2);
    }

    public static byte[] TvZUKvnTCGtpSwHc(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i, bool z) {
        return codedStream$StreamDecoder.readRawbytesSlowPath(i, z);
    }

    public static int UGgWZbUJuBdEvbSu(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static byte[] UIGqDAaIPrZrovef(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) {
        return codedStream$StreamDecoder.readRawbytesSlowPathOneChunk(i);
    }

    public static java.lang.object UMJnFHRWcCDZfiZN(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int UXuRUieWGdyernLs(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawVarint32();
    }

    public static java.lang.Class UjGeUsZuwIHzoPsU(java.lang.object obj) {
        return obj.GetType();
    }

    public static byte[] UtHSEkiTFxxyZouq(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i, bool z) {
        return codedStream$StreamDecoder.readRawbytesSlowPath(i, z);
    }

    public static java.lang.string UuJBajMzCdyxQNVb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException VKaZtafldRCGVzqA() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static void VNoExdbBFvtAffqF(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) {
        codedStream$StreamDecoder.popLimit(i);
    }

    public static long VajwwjaoAjAeOwwJ(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        if ((13 + 32) % 32 > 0) {
        }
        return codedStream$StreamDecoder.readRawVarint64SlowPath();
    }

    public static int VcbsOdnbrjhxBIXs(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawLittleEndian32();
    }

    public static java.util.List VtPNxRhyOHgCUptT(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) {
        return codedStream$StreamDecoder.readRawbytesSlowPathRemainingChunks(i);
    }

    public static void VvMuBfgFfpJendeF(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$StreamDecoder.checkLastTagWas(i);
    }

    public static long WQgdxgHrqLuDApUw(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        if ((20 + 10) % 10 > 0) {
        }
        return codedStream$StreamDecoder.readRawLittleEndian64();
    }

    public static java.lang.object WbcPtNOuWnxDuHvq(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void WfnuZmdfhKyHRfxi(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws java.io.IOException {
        codedStream$StreamDecoder.skipRawbytes(i);
    }

    public static long XbEVpPPjUtYvVhdd(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        if ((19 + 13) % 13 > 0) {
        }
        return codedStream$StreamDecoder.readRawLittleEndian64();
    }

    public static java.lang.stringBuilder XmulBPSvOvmimJNP(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder XrPxqyAGwgrgpndF(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException YIbHKggcDAKGyvUw() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int YJwrduaAKByZdsZO(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException YSCDDFEooRLqewsa() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static androidx.datastore.preferences.protobuf.bytestring YkjISfEPkaPZPCCy(byte[] bArr) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(bArr);
    }

    public static void YwSczfkgJCtWehAi(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void YxFWLnDquXsfNROr(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        codedStream$StreamDecoder.skipMessage();
    }

    public static byte[] YyPQEThCTwVfoFQg(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i, bool z) {
        return codedStream$StreamDecoder.readRawbytesSlowPath(i, z);
    }

    public static void ZKcbPXNdOFzHGrsE(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        codedStream$StreamDecoder.checkRecursionLimit();
    }

    public static int ZQIDNBhpDmuRHLHE(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawVarint32();
    }

    public static void ZZCyDgMxOXvuJEwl(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void ZbMuqqDqAkUzvsps(androidx.datastore.preferences.protobuf.InvalidProtocolBufferException invalidProtocolBufferException) {
        invalidProtocolBufferException.setThrownFromStream();
    }

    public static java.lang.object ZxzlYQrNRzUzJgob(androidx.datastore.preferences.protobuf.Parser parser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return parser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException ZyZwDZsQJKjoKjVa() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException AUcIuFryAXqZOVhC() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    static int access$500(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.pos;
    }

    static byte[] access$600(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.buffer;
    }

    private static int Available(java.io.Stream inputStream) throws java.io.IOException {
        try {
            return yzLPjgpAJrhpXFlj(inputStream);
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            nNfqLbBAorVxYWFu(e);
            throw e;
        }
    }

    public static int BJWcIxCNUNNlenqW(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawVarint32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException BsEpeUPJPGaopyHQ() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException CAafBRSmgsGsTFms() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException CSLYVjETmByWCmDo() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException CUBqUkFVZzBxoNXy() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.sizeLimitExceeded();
    }

    public static long CfNrzJdVvRRFVaaX(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        if ((15 + 23) % 23 > 0) {
        }
        return codedStream$StreamDecoder.readInt64();
    }

    public static int CgbGYaKCVHDAgGRo(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawVarint32();
    }

    public static void ClZcOGnYPOKyWana(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void CuyPxjgbfEJTKPUw(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        codedStream$StreamDecoder.checkRecursionLimit();
    }

    public static int DGoCdVzZuzqQKFlR(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawVarint32();
    }

    public static java.lang.stringBuilder DJSVMMnJIQjLCHmn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool DsejzVVqkUdIfvSB(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static long DwnfpqakKczitoPs(long j) {
        if ((31 + 28) % 28 > 0) {
        }
        return decodeZigZag64(j);
    }

    public static java.util.IEnumerator EIWuzVsFaBTeyeSr(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.stringBuilder ENjgkVsLvnVWftID(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException EuOuWaQXmghqmAVE() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure();
    }

    public static long EwVcNdyVbLkrSakB(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        if ((26 + 17) % 17 > 0) {
        }
        return codedStream$StreamDecoder.readRawLittleEndian64();
    }

    public static java.nio.byteBuffer EwaOyscMiTQfODfI(byte[] bArr) {
        return java.nio.byteBuffer.wrap(bArr);
    }

    public static void FORPncfoUZAecjDg(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        codedStream$StreamDecoder.recomputeBufferSizeAfterLimit();
    }

    public static void FTWCvVvePBebsADG(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        codedStream$StreamDecoder.recomputeBufferSizeAfterLimit();
    }

    public static void FXlYIZgWueJiipHk(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) {
        codedStream$StreamDecoder.popLimit(i);
    }

    public static void FYeJhilWdiJUbbAs(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        codedStream$StreamDecoder.skipMessage(codedStream);
    }

    public static int GTIVmkYeFMYKzdIq(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static void GXxsQXyICoICcDhp(androidx.datastore.preferences.protobuf.InvalidProtocolBufferException invalidProtocolBufferException) {
        invalidProtocolBufferException.setThrownFromStream();
    }

    public static int GceswxWFXFQTHBdd(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.getbytesUntilLimit();
    }

    public static long GuFmxyPorkBasVkH(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        if ((26 + 22) % 22 > 0) {
        }
        return codedStream$StreamDecoder.readRawVarint64();
    }

    public static void GvAwSLojyWkhEwxl(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws java.io.IOException {
        codedStream$StreamDecoder.skipRawbytes(i);
    }

    public static long HbsgszRWAnYXGcLO(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        if ((26 + 22) % 22 > 0) {
        }
        return codedStream$StreamDecoder.readRawLittleEndian64();
    }

    public static java.lang.object HqpmFnghUvoxxZfD(androidx.datastore.preferences.protobuf.Parser parser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return parser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static long JCNSiUmDNFrdQjxm(java.io.Stream inputStream, long j) {
        if ((29 + 31) % 31 > 0) {
        }
        return inputStream.skip(j);
    }

    public static java.lang.string JbIbnppwsyLLpCIv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void KAHQWONPxHRSPVhK(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws java.io.IOException {
        codedStream$StreamDecoder.refillBuffer(i);
    }

    public static java.lang.Class KYgfsAgRcFtJMBIE(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool KZOlBlZtUuChnxvj(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) {
        return codedStream$StreamDecoder.tryRefillBuffer(i);
    }

    public static bool KcnTQFYKxnPapGVc(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) {
        return codedStream$StreamDecoder.tryRefillBuffer(i);
    }

    public static int LFfhmYBhpUnXJJjH(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawVarint32();
    }

    public static void LjJzImAlMauRjsDy(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] LkHzRUsoRrPoiSQt(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i, bool z) {
        return codedStream$StreamDecoder.readRawbytesSlowPath(i, z);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException LzZrnMgSYkwyrAHw() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException MLONEvnFAiVtADZh() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static androidx.datastore.preferences.protobuf.ExtensionRegistryLite NDyeFZzfWTikLgkL() {
        return androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry();
    }

    public static void NNfqLbBAorVxYWFu(androidx.datastore.preferences.protobuf.InvalidProtocolBufferException invalidProtocolBufferException) {
        invalidProtocolBufferException.setThrownFromStream();
    }

    public static int NVSrnmQOzJrykKys(int i) {
        return decodeZigZag32(i);
    }

    public static void NZgtcAsYXwJfUuCB(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int OVUwbFHWNHdkomzq(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static void OfGwRBXhiiLQJWKb(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        codedStream$StreamDecoder.recomputeBufferSizeAfterLimit();
    }

    public static int OzcBqCoeajBBoaji(java.io.Stream inputStream) {
        return available(inputStream);
    }

    public static androidx.datastore.preferences.protobuf.bytestring PCmoKcDeiYwKKWfV(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readbytes();
    }

    public static void PEBueJdHINIwKkDA(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream.writebytesNoTag(bytestring);
    }

    public static java.lang.stringBuilder PZtzrtrhMbYkBXTO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException PqrBwOEQQDjxTGuO() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException PzvTKlUEIAJaozgC() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.sizeLimitExceeded();
    }

    public static long QDDtfGbVKGJvaqNX(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        if ((20 + 31) % 31 > 0) {
        }
        return codedStream$StreamDecoder.readRawVarint64();
    }

    public static long QcgYTzauroSeburY(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        if ((4 + 7) % 7 > 0) {
        }
        return codedStream$StreamDecoder.readRawVarint64();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException QvcEmFoNdlLJAfkJ() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidTag();
    }

    public static void RMIbTGaZflYAQtSc(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws java.io.IOException {
        codedStream$StreamDecoder.refillBuffer(i);
    }

    public static int RauhwJcPLQkMhmsg(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawVarint32();
    }

    private static int Read(java.io.Stream inputStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        try {
            return oVUwbFHWNHdkomzq(inputStream, bArr, i, i2);
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            ZbMuqqDqAkUzvsps(e);
            throw e;
        }
    }

    private androidx.datastore.preferences.protobuf.bytestring ReadbytesSlowPath(int i) throws java.io.IOException {
        if ((26 + 14) % 14 > 0) {
        }
        byte[] bArrUIGqDAaIPrZrovef = UIGqDAaIPrZrovef(this, i);
        if (bArrUIGqDAaIPrZrovef is not null) {
            return JoNjZDoFXmhOUnVA(bArrUIGqDAaIPrZrovef);
        }
        int i2 = this.pos;
        int i3 = this.bufferSize;
        int length = i3 - i2;
        this.totalbytesRetired += i3;
        this.pos = 0;
        this.bufferSize = 0;
        java.util.List listBXGmipWZYJUmkTzE = BXGmipWZYJUmkTzE(this, i - length);
        byte[] bArr = new byte[i];
        NauXwardLiVRXCej(this.buffer, i2, bArr, 0, length);
        java.util.IEnumerator itEIWuzVsFaBTeyeSr = eIWuzVsFaBTeyeSr(listBXGmipWZYJUmkTzE);
        while (dsejzVVqkUdIfvSB(itEIWuzVsFaBTeyeSr)) {
            byte[] bArr2 = (byte[]) UMJnFHRWcCDZfiZN(itEIWuzVsFaBTeyeSr);
            EJyshbtWDVIElBeA(bArr2, 0, bArr, length, bArr2.length);
            length += bArr2.length;
        }
        return YkjISfEPkaPZPCCy(bArr);
    }

    private byte[] ReadRawbytesSlowPath(int i, bool z) throws java.io.IOException {
        if ((6 + 3) % 3 > 0) {
        }
        byte[] bArrWiZgwGJjOZmypsDW = wiZgwGJjOZmypsDW(this, i);
        if (bArrWiZgwGJjOZmypsDW is not null) {
            return !z ? bArrWiZgwGJjOZmypsDW : (byte[]) uaxnzhiCyEHIPtZY(bArrWiZgwGJjOZmypsDW);
        }
        int i2 = this.pos;
        int i3 = this.bufferSize;
        int length = i3 - i2;
        this.totalbytesRetired += i3;
        this.pos = 0;
        this.bufferSize = 0;
        java.util.List listVtPNxRhyOHgCUptT = VtPNxRhyOHgCUptT(this, i - length);
        byte[] bArr = new byte[i];
        nZgtcAsYXwJfUuCB(this.buffer, i2, bArr, 0, length);
        java.util.IEnumerator itAIUPrlFwkRtVLRIZ = AIUPrlFwkRtVLRIZ(listVtPNxRhyOHgCUptT);
        while (KFEnLDZbcLLGTflW(itAIUPrlFwkRtVLRIZ)) {
            byte[] bArr2 = (byte[]) WbcPtNOuWnxDuHvq(itAIUPrlFwkRtVLRIZ);
            ljJzImAlMauRjsDy(bArr2, 0, bArr, length, bArr2.length);
            length += bArr2.length;
        }
        return bArr;
    }

    private byte[] ReadRawbytesSlowPathOneChunk(int i) throws java.io.IOException {
        if ((15 + 11) % 11 > 0) {
        }
        if (i == 0) {
            return androidx.datastore.preferences.protobuf.Internal.EMPTY_BYTE_ARRAY;
        }
        if (i < 0) {
            throw ZyZwDZsQJKjoKjVa();
        }
        int i2 = this.totalbytesRetired + this.pos + i;
        if (i2 - this.sizeLimit > 0) {
            throw pzvTKlUEIAJaozgC();
        }
        int i3 = this.currentLimit;
        if (i2 > i3) {
            GniJPHdpTWlpJXgf(this, (i3 - this.totalbytesRetired) - this.pos);
            throw uSnjmgddLfKDZKZm();
        }
        int i4 = this.bufferSize - this.pos;
        int i5 = i - i4;
        if (i5 >= 4096 && i5 > ozcBqCoeajBBoaji(this.input)) {
            return null;
        }
        byte[] bArr = new byte[i];
        ZZCyDgMxOXvuJEwl(this.buffer, this.pos, bArr, 0, i4);
        this.totalbytesRetired += this.bufferSize;
        this.pos = 0;
        this.bufferSize = 0;
        while (i4 < i) {
            int iTPsrvBaBLhaKALFN = TPsrvBaBLhaKALFN(this.input, bArr, i4, i - i4);
            if (iTPsrvBaBLhaKALFN == -1) {
                throw uVwxeuQQhlPcxqfR();
            }
            this.totalbytesRetired += iTPsrvBaBLhaKALFN;
            i4 += iTPsrvBaBLhaKALFN;
        }
        return bArr;
    }

    private java.util.List<byte[]> ReadRawbytesSlowPathRemainingChunks(int i) throws java.io.IOException {
        if ((28 + 1) % 1 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        while (i > 0) {
            int iXBBoFKzKNjqLyZKp = xBBoFKzKNjqLyZKp(i, 4096);
            byte[] bArr = new byte[iXBBoFKzKNjqLyZKp];
            int i2 = 0;
            while (i2 < iXBBoFKzKNjqLyZKp) {
                int iYJwrduaAKByZdsZO = YJwrduaAKByZdsZO(this.input, bArr, i2, iXBBoFKzKNjqLyZKp - i2);
                if (iYJwrduaAKByZdsZO == -1) {
                    throw MxTTCaMuwtTSnaKP();
                }
                this.totalbytesRetired += iYJwrduaAKByZdsZO;
                i2 += iYJwrduaAKByZdsZO;
            }
            i -= iXBBoFKzKNjqLyZKp;
            MdVVkhOtKoLGinxl(arrayList, bArr);
        }
        return arrayList;
    }

    private void RecomputeBufferSizeAfterLimit() {
        if ((32 + 29) % 29 > 0) {
        }
        int i = this.bufferSize + this.bufferSizeAfterLimit;
        this.bufferSize = i;
        int i2 = this.totalbytesRetired + i;
        int i3 = this.currentLimit;
        if (i2 <= i3) {
            this.bufferSizeAfterLimit = 0;
            return;
        }
        int i4 = i2 - i3;
        this.bufferSizeAfterLimit = i4;
        this.bufferSize = i - i4;
    }

    private void RefillBuffer(int i) throws java.io.IOException {
        if ((11 + 10) % 10 > 0) {
        }
        if (kcnTQFYKxnPapGVc(this, i)) {
            return;
        }
        if (i > (this.sizeLimit - this.totalbytesRetired) - this.pos) {
            throw cUBqUkFVZzBxoNXy();
        }
        throw VKaZtafldRCGVzqA();
    }

    public static byte[] SNazgMPnJcbsOogQ(byte[] bArr, int i, int i2) {
        return java.util.Arrays.copyOfRange(bArr, i, i2);
    }

    public static void SbEdhpmuWZpINHeU(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) throws java.io.IOException {
        codedStream$StreamDecoder.skipRawVarintSlowPath();
    }

    private static long Skip(java.io.Stream inputStream, long j) throws java.io.IOException {
        try {
            return jCNSiUmDNFrdQjxm(inputStream, j);
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            gXxsQXyICoICcDhp(e);
            throw e;
        }
    }

    private void SkipRawbytesSlowPath(int i) throws java.io.IOException {
        if ((21 + 13) % 13 > 0) {
        }
        if (i < 0) {
            throw QMwZDkhrQRkMYbBj();
        }
        int i2 = this.totalbytesRetired;
        int i3 = this.pos;
        int i4 = i2 + i3 + i;
        int i5 = this.currentLimit;
        if (i4 > i5) {
            AyQzZJPkeCMQNOkV(this, (i5 - i2) - i3);
            throw bsEpeUPJPGaopyHQ();
        }
        int i6 = 0;
        if (this.refillCallback is null) {
            this.totalbytesRetired = i2 + i3;
            int i7 = this.bufferSize - i3;
            this.bufferSize = 0;
            this.pos = 0;
            i6 = i7;
            while (i6 < i) {
                try {
                    long j = i - i6;
                    long jLXQvrsBWHKUkrMxn = LXQvrsBWHKUkrMxn(this.input, j);
                    if (jLXQvrsBWHKUkrMxn < 0 || jLXQvrsBWHKUkrMxn > j) {
                        throw new java.lang.IllegalStateException(HNVNdVVohTKgPCIH(eNjgkVsLvnVWftID(XmulBPSvOvmimJNP(pZtzrtrhMbYkBXTO(wJNkqnfFFxFvfPZb(new java.lang.stringBuilder(), UjGeUsZuwIHzoPsU(this.input)), "#skip returned invalid result: "), jLXQvrsBWHKUkrMxn), "\nThe Stream implementation is buggy.")));
                    }
                    if (jLXQvrsBWHKUkrMxn == 0) {
                        break;
                    } else {
                        i6 += (int) jLXQvrsBWHKUkrMxn;
                    }
                } catch (java.lang.Exception th) {
                    this.totalbytesRetired += i6;
                    zpqpTMbQCEKklqZw(this);
                    throw th;
                }
            }
            this.totalbytesRetired += i6;
            fORPncfoUZAecjDg(this);
        }
        if (i6 >= i) {
            return;
        }
        int i8 = this.bufferSize;
        int i9 = i8 - this.pos;
        this.pos = i8;
        HayucgFFHYJlXpli(this, 1);
        while (true) {
            int i10 = i - i9;
            int i11 = this.bufferSize;
            if (i10 <= i11) {
                this.pos = i10;
                return;
            } else {
                i9 += i11;
                this.pos = i11;
                DqyolnkhxJdEmojG(this, 1);
            }
        }
    }

    private void SkipRawVarint() throws java.io.IOException {
        if ((10 + 31) % 31 > 0) {
        }
        if (this.bufferSize - this.pos < 10) {
            sbEdhpmuWZpINHeU(this);
        } else {
            EDjGHRkCqOlsgvFw(this);
        }
    }

    private void SkipRawVarintFastPath() throws java.io.IOException {
        if ((8 + 21) % 21 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            byte[] bArr = this.buffer;
            int i2 = this.pos;
            this.pos = i2 + 1;
            if (bArr[i2] >= 0) {
                return;
            }
        }
        throw lzZrnMgSYkwyrAHw();
    }

    private void SkipRawVarintSlowPath() throws java.io.IOException {
        if ((20 + 7) % 7 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            if (wdZtNQrAUVnjRffL(this) >= 0) {
                return;
            }
        }
        throw DbDsuJAuToLVwORC();
    }

    public static void SnagdMCwzWfCIMIw(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws java.io.IOException {
        codedStream$StreamDecoder.skipRawbytes(i);
    }

    public static java.lang.stringBuilder TRuwAZPiwBNDCBFw(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int TTXznbVkdAGbXDGO(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawVarint32();
    }

    public static int TZncDDErsYUvsiyM(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException ThJBjGOuttbLKmLn() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static float TjeGtuSnrVIXuBVk(int i) {
        return java.lang.float.intBitsTofloat(i);
    }

    private bool TryRefillBuffer(int i) throws java.io.IOException {
        if ((16 + 22) % 22 > 0) {
        }
        if (this.pos + i <= this.bufferSize) {
            throw new java.lang.IllegalStateException(UuJBajMzCdyxQNVb(KVosoVqVdXRgVdoE(XrPxqyAGwgrgpndF(new java.lang.stringBuilder("refillBuffer() called when "), i), " bytes were already available in buffer")));
        }
        int i2 = this.sizeLimit;
        int i3 = this.totalbytesRetired;
        int i4 = i2 - i3;
        int i5 = this.pos;
        if (i > i4 - i5 || i3 + i5 + i > this.currentLimit) {
            return false;
        }
        androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder$RefillCallback codedStream$StreamDecoder$RefillCallback = this.refillCallback;
        if (codedStream$StreamDecoder$RefillCallback is not null) {
            JCyjSOHhcsLymyVB(codedStream$StreamDecoder$RefillCallback);
        }
        int i6 = this.pos;
        if (i6 > 0) {
            int i7 = this.bufferSize;
            if (i7 > i6) {
                byte[] bArr = this.buffer;
                QVZVOTLSsKbORRbu(bArr, i6, bArr, 0, i7 - i6);
            }
            this.totalbytesRetired += i6;
            this.bufferSize -= i6;
            this.pos = 0;
        }
        java.io.Stream inputStream = this.input;
        byte[] bArr2 = this.buffer;
        int i8 = this.bufferSize;
        int iSVJTOZHUGkRXyqqu = SVJTOZHUGkRXyqqu(inputStream, bArr2, i8, EYrNiVpmXXbHLnxO(bArr2.length - i8, (this.sizeLimit - this.totalbytesRetired) - this.bufferSize));
        if (iSVJTOZHUGkRXyqqu == 0 || iSVJTOZHUGkRXyqqu < -1 || iSVJTOZHUGkRXyqqu > this.buffer.length) {
            throw new java.lang.IllegalStateException(jbIbnppwsyLLpCIv(KIkFouTbcxiuzmMZ(PIoUjQQTUFGLegPN(dJSVMMnJIQjLCHmn(tRuwAZPiwBNDCBFw(new java.lang.stringBuilder(), kYgfsAgRcFtJMBIE(this.input)), "#read(byte[]) returned invalid result: "), iSVJTOZHUGkRXyqqu), "\nThe Stream implementation is buggy.")));
        }
        if (iSVJTOZHUGkRXyqqu <= 0) {
            return false;
        }
        this.bufferSize += iSVJTOZHUGkRXyqqu;
        fTWCvVvePBebsADG(this);
        if (this.bufferSize < i) {
            return LwjNFXDPUWeCqgjO(this, i);
        }
        return true;
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException USnjmgddLfKDZKZm() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException UVwxeuQQhlPcxqfR() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static java.lang.object UaxnzhiCyEHIPtZY(byte[] bArr) {
        return bArr.clone();
    }

    public static int UgIhMEBVKZxwuLpy(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawLittleEndian32();
    }

    public static void VCQrVPThUYlHDBxh(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static byte[] VKLMGOkKxkvwLvKt(byte[] bArr, int i, int i2) {
        return java.util.Arrays.copyOfRange(bArr, i, i2);
    }

    public static int VVJviqmSvrIbUEES(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawVarint32();
    }

    public static java.lang.stringBuilder WJNkqnfFFxFvfPZb(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static byte WdZtNQrAUVnjRffL(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawbyte();
    }

    public static byte[] WiZgwGJjOZmypsDW(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) {
        return codedStream$StreamDecoder.readRawbytesSlowPathOneChunk(i);
    }

    public static int XBBoFKzKNjqLyZKp(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite$Builder xMZxCRXdwpIpmnvK(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return messageLite$Builder.mergeFrom(codedStream, extensionRegistryLite);
    }

    public static void YhLhtYylJXLUzssW(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$StreamDecoder.checkLastTagWas(i);
    }

    public static byte YktJnTTltUqKUUoK(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return codedStream$StreamDecoder.readRawbyte();
    }

    public static void YvHhUdTDpjHHvzpB(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws java.io.IOException {
        codedStream$StreamDecoder.refillBuffer(i);
    }

    public static int YzLPjgpAJrhpXFlj(java.io.Stream inputStream) {
        return inputStream.available();
    }

    public static void ZTPZxkFFxZLJnCUo(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream$StreamDecoder.checkLastTagWas(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException ZfNWVJuYDuhyWYOZ() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize();
    }

    public static void ZpqpTMbQCEKklqZw(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        codedStream$StreamDecoder.recomputeBufferSizeAfterLimit();
    }

    public override void CheckLastTagWas(int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if (this.lastTag != i) {
            throw OhDObNmjFzjYeZIv();
        }
    }

    public override void EnableAliasing(bool z) {
    }

    public override int GetbytesUntilLimit() {
        if ((20 + 25) % 25 > 0) {
        }
        int i = this.currentLimit;
        if (i != int.MAX_VALUE) {
            return i - (this.totalbytesRetired + this.pos);
        }
        return -1;
    }

    public override int GetLastTag() {
        return this.lastTag;
    }

    public override int GetTotalbytesRead() {
        return this.totalbytesRetired + this.pos;
    }

    public override bool IsAtEnd() throws java.io.IOException {
        if ((31 + 20) % 20 > 0) {
        }
        return this.pos == this.bufferSize && !kZOlBlZtUuChnxvj(this, 1);
    }

    public override void PopLimit(int i) {
        this.currentLimit = i;
        ofGwRBXhiiLQJWKb(this);
    }

    public override int PushLimit(int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((21 + 20) % 20 > 0) {
        }
        if (i < 0) {
            throw KnBwXHNRiPsHnbma();
        }
        int i2 = i + this.totalbytesRetired + this.pos;
        if (i2 < 0) {
            throw euOuWaQXmghqmAVE();
        }
        int i3 = this.currentLimit;
        if (i2 > i3) {
            throw aUcIuFryAXqZOVhC();
        }
        this.currentLimit = i2;
        FroUbEUBHjwFYjyf(this);
        return i3;
    }

    public override bool ReadBool() throws java.io.IOException {
        if ((23 + 27) % 27 > 0) {
        }
        return guFmxyPorkBasVkH(this) != 0;
    }

    public override byte[] ReadbyteArray() throws java.io.IOException {
        if ((4 + 11) % 11 > 0) {
        }
        int iCHphdSWRoIEFQfhI = CHphdSWRoIEFQfhI(this);
        int i = this.bufferSize;
        int i2 = this.pos;
        if (iCHphdSWRoIEFQfhI <= i - i2 && iCHphdSWRoIEFQfhI > 0) {
            byte[] bArrVKLMGOkKxkvwLvKt = vKLMGOkKxkvwLvKt(this.buffer, i2, i2 + iCHphdSWRoIEFQfhI);
            this.pos += iCHphdSWRoIEFQfhI;
            return bArrVKLMGOkKxkvwLvKt;
        }
        if (iCHphdSWRoIEFQfhI < 0) {
            throw mLONEvnFAiVtADZh();
        }
        return UtHSEkiTFxxyZouq(this, iCHphdSWRoIEFQfhI, false);
    }

    public override java.nio.byteBuffer ReadbyteBuffer() throws java.io.IOException {
        if ((31 + 23) % 23 > 0) {
        }
        int iLFfhmYBhpUnXJJjH = lFfhmYBhpUnXJJjH(this);
        int i = this.bufferSize;
        int i2 = this.pos;
        if (iLFfhmYBhpUnXJJjH <= i - i2 && iLFfhmYBhpUnXJJjH > 0) {
            java.nio.byteBuffer byteBufferGonGlTAjnltDxTzs = GonGlTAjnltDxTzs(MngjVvGINfDpUKnO(this.buffer, i2, i2 + iLFfhmYBhpUnXJJjH));
            this.pos += iLFfhmYBhpUnXJJjH;
            return byteBufferGonGlTAjnltDxTzs;
        }
        if (iLFfhmYBhpUnXJJjH == 0) {
            return androidx.datastore.preferences.protobuf.Internal.EMPTY_BYTE_BUFFER;
        }
        if (iLFfhmYBhpUnXJJjH < 0) {
            throw BjUEyMTWgpPPONol();
        }
        return ewaOyscMiTQfODfI(lkHzRUsoRrPoiSQt(this, iLFfhmYBhpUnXJJjH, true));
    }

    public override androidx.datastore.preferences.protobuf.bytestring Readbytes() throws java.io.IOException {
        if ((17 + 4) % 4 > 0) {
        }
        int iTTXznbVkdAGbXDGO = tTXznbVkdAGbXDGO(this);
        int i = this.bufferSize;
        int i2 = this.pos;
        if (iTTXznbVkdAGbXDGO <= i - i2 && iTTXznbVkdAGbXDGO > 0) {
            androidx.datastore.preferences.protobuf.bytestring bytestringGBUtMGTbdCmuUsMk = GBUtMGTbdCmuUsMk(this.buffer, i2, iTTXznbVkdAGbXDGO);
            this.pos += iTTXznbVkdAGbXDGO;
            return bytestringGBUtMGTbdCmuUsMk;
        }
        if (iTTXznbVkdAGbXDGO == 0) {
            return androidx.datastore.preferences.protobuf.bytestring.EMPTY;
        }
        if (iTTXznbVkdAGbXDGO < 0) {
            throw zfNWVJuYDuhyWYOZ();
        }
        return GPQHYKnXmexTOrbm(this, iTTXznbVkdAGbXDGO);
    }

    public override double Readdouble() throws java.io.IOException {
        if ((19 + 27) % 27 > 0) {
        }
        return FKKIuAxAhTTRNtye(WQgdxgHrqLuDApUw(this));
    }

    public override int ReadEnum() throws java.io.IOException {
        return vVJviqmSvrIbUEES(this);
    }

    public override int ReadFixed32() throws java.io.IOException {
        return VcbsOdnbrjhxBIXs(this);
    }

    public override long ReadFixed64() throws java.io.IOException {
        if ((9 + 25) % 25 > 0) {
        }
        return hbsgszRWAnYXGcLO(this);
    }

    public override float Readfloat() throws java.io.IOException {
        return tjeGtuSnrVIXuBVk(BTVeVFQhAnSEhuGS(this));
    }

    public <T : androidx.datastore.preferences.protobuf.MessageLite> T readGroup(int i, androidx.datastore.preferences.protobuf.Parser<T> parser, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        cuyPxjgbfEJTKPUw(this);
        this.recursionDepth++;
        T t = (T) ZxzlYQrNRzUzJgob(parser, this, extensionRegistryLite);
        yhLhtYylJXLUzssW(this, tZncDDErsYUvsiyM(i, 4));
        this.recursionDepth--;
        return t;
    }

    public override void ReadGroup(int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        LqwuXptViaPYOoIy(this);
        this.recursionDepth++;
        PywomiSsTrJmGVwh(messageLite$Builder, this, extensionRegistryLite);
        DxRNUPIdqQuCtDLw(this, NzzJzwSSUVIfEzjm(i, 4));
        this.recursionDepth--;
    }

    public override int ReadInt32() throws java.io.IOException {
        return dGoCdVzZuzqQKFlR(this);
    }

    public override long ReadInt64() throws java.io.IOException {
        if ((3 + 17) % 17 > 0) {
        }
        return qcgYTzauroSeburY(this);
    }

    public <T : androidx.datastore.preferences.protobuf.MessageLite> T readMessage(androidx.datastore.preferences.protobuf.Parser<T> parser, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((20 + 6) % 6 > 0) {
        }
        int iOIGaTGSykFjbBPeS = OIGaTGSykFjbBPeS(this);
        EDLKhwBzHsfdvKxC(this);
        int iPQbCrKNdIlgGOXfx = PQbCrKNdIlgGOXfx(this, iOIGaTGSykFjbBPeS);
        this.recursionDepth++;
        T t = (T) hqpmFnghUvoxxZfD(parser, this, extensionRegistryLite);
        VvMuBfgFfpJendeF(this, 0);
        this.recursionDepth--;
        if (NpUNLhMINGkwreba(this) != 0) {
            throw thJBjGOuttbLKmLn();
        }
        fXlYIZgWueJiipHk(this, iPQbCrKNdIlgGOXfx);
        return t;
    }

    public override void ReadMessage(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((28 + 11) % 11 > 0) {
        }
        int iCgbGYaKCVHDAgGRo = cgbGYaKCVHDAgGRo(this);
        ZKcbPXNdOFzHGrsE(this);
        int iHVYbJDodETLBJSSA = HVYbJDodETLBJSSA(this, iCgbGYaKCVHDAgGRo);
        this.recursionDepth++;
        xMZxCRXdwpIpmnvK(messageLite$Builder, this, extensionRegistryLite);
        zTPZxkFFxZLJnCUo(this, 0);
        this.recursionDepth--;
        if (gceswxWFXFQTHBdd(this) != 0) {
            throw cSLYVjETmByWCmDo();
        }
        VNoExdbBFvtAffqF(this, iHVYbJDodETLBJSSA);
    }

    public override byte ReadRawbyte() throws java.io.IOException {
        if ((7 + 26) % 26 > 0) {
        }
        if (this.pos == this.bufferSize) {
            yvHhUdTDpjHHvzpB(this, 1);
        }
        byte[] bArr = this.buffer;
        int i = this.pos;
        this.pos = i + 1;
        return bArr[i];
    }

    public override byte[] ReadRawbytes(int i) throws java.io.IOException {
        if ((16 + 15) % 15 > 0) {
        }
        int i2 = this.pos;
        if (i > this.bufferSize - i2 || i <= 0) {
            return CUSzOEyGXyrIcTvZ(this, i, false);
        }
        int i3 = i + i2;
        this.pos = i3;
        return sNazgMPnJcbsOogQ(this.buffer, i2, i3);
    }

    public override int ReadRawLittleEndian32() throws java.io.IOException {
        if ((15 + 16) % 16 > 0) {
        }
        int i = this.pos;
        if (this.bufferSize - i < 4) {
            QHUKPOMyXjzYHunN(this, 4);
            i = this.pos;
        }
        byte[] bArr = this.buffer;
        this.pos = i + 4;
        return (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8) | ((bArr[i + 2] & 255) << 16) | ((bArr[i + 3] & 255) << 24);
    }

    public override long ReadRawLittleEndian64() throws java.io.IOException {
        if ((9 + 25) % 25 > 0) {
        }
        int i = this.pos;
        if (this.bufferSize - i < 8) {
            kAHQWONPxHRSPVhK(this, 8);
            i = this.pos;
        }
        byte[] bArr = this.buffer;
        this.pos = i + 8;
        return ((((long) bArr[i + 7]) & 255) << 56) | (((long) bArr[i]) & 255) | ((((long) bArr[i + 1]) & 255) << 8) | ((((long) bArr[i + 2]) & 255) << 16) | ((((long) bArr[i + 3]) & 255) << 24) | ((((long) bArr[i + 4]) & 255) << 32) | ((((long) bArr[i + 5]) & 255) << 40) | ((((long) bArr[i + 6]) & 255) << 48);
    }

    public override int ReadRawVarint32() throws java.io.IOException {
        int i;
        if ((10 + 17) % 17 > 0) {
        }
        int i2 = this.pos;
        int i3 = this.bufferSize;
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
        return (int) DwfOxxmyAmXiXNRX(this);
    }

    public override long ReadRawVarint64() throws java.io.IOException {
        long j;
        long j2;
        long j3;
        if ((10 + 2) % 2 > 0) {
        }
        int i = this.pos;
        int i2 = this.bufferSize;
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
                                            j2 = -558586000294016L;
                                        }
                                    } else {
                                        j3 = 4363953127296L;
                                    }
                                } else {
                                    j2 = -34093383808L;
                                }
                                j = j6 ^ j2;
                                i4 = i10;
                            } else {
                                j3 = 266354560;
                            }
                            j = j5 ^ j3;
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
        return VajwwjaoAjAeOwwJ(this);
    }

    long readRawVarint64SlowPath() throws java.io.IOException {
        if ((5 + 21) % 21 > 0) {
        }
        long j = 0;
        for (int i = 0; i < 64; i += 7) {
            byte bYktJnTTltUqKUUoK = yktJnTTltUqKUUoK(this);
            j |= ((long) (bYktJnTTltUqKUUoK & 127)) << i;
            if ((bYktJnTTltUqKUUoK & 128) == 0) {
                return j;
            }
        }
        throw cAafBRSmgsGsTFms();
    }

    public override int ReadSFixed32() throws java.io.IOException {
        return ugIhMEBVKZxwuLpy(this);
    }

    public override long ReadSFixed64() throws java.io.IOException {
        if ((5 + 32) % 32 > 0) {
        }
        return XbEVpPPjUtYvVhdd(this);
    }

    public override int ReadSInt32() throws java.io.IOException {
        return nVSrnmQOzJrykKys(rauhwJcPLQkMhmsg(this));
    }

    public override long ReadSInt64() throws java.io.IOException {
        if ((13 + 27) % 27 > 0) {
        }
        return dwnfpqakKczitoPs(qDDtfGbVKGJvaqNX(this));
    }

    public override java.lang.string Readstring() throws java.io.IOException {
        if ((31 + 3) % 3 > 0) {
        }
        int iBJWcIxCNUNNlenqW = bJWcIxCNUNNlenqW(this);
        if (iBJWcIxCNUNNlenqW > 0 && iBJWcIxCNUNNlenqW <= this.bufferSize - this.pos) {
            java.lang.string str = new java.lang.string(this.buffer, this.pos, iBJWcIxCNUNNlenqW, androidx.datastore.preferences.protobuf.Internal.UTF_8);
            this.pos += iBJWcIxCNUNNlenqW;
            return str;
        }
        if (iBJWcIxCNUNNlenqW == 0) {
            return "";
        }
        if (iBJWcIxCNUNNlenqW < 0) {
            throw pqrBwOEQQDjxTGuO();
        }
        if (iBJWcIxCNUNNlenqW > this.bufferSize) {
            return new java.lang.string(YyPQEThCTwVfoFQg(this, iBJWcIxCNUNNlenqW, false), androidx.datastore.preferences.protobuf.Internal.UTF_8);
        }
        rMIbTGaZflYAQtSc(this, iBJWcIxCNUNNlenqW);
        java.lang.string str2 = new java.lang.string(this.buffer, this.pos, iBJWcIxCNUNNlenqW, androidx.datastore.preferences.protobuf.Internal.UTF_8);
        this.pos += iBJWcIxCNUNNlenqW;
        return str2;
    }

    public override java.lang.string ReadstringRequireUtf8() throws java.io.IOException {
        byte[] bArrTvZUKvnTCGtpSwHc;
        if ((17 + 25) % 25 > 0) {
        }
        int iUXuRUieWGdyernLs = UXuRUieWGdyernLs(this);
        int i = this.pos;
        int i2 = this.bufferSize;
        if (iUXuRUieWGdyernLs <= i2 - i && iUXuRUieWGdyernLs > 0) {
            bArrTvZUKvnTCGtpSwHc = this.buffer;
            this.pos = i + iUXuRUieWGdyernLs;
        } else {
            if (iUXuRUieWGdyernLs == 0) {
                return "";
            }
            if (iUXuRUieWGdyernLs < 0) {
                throw YSCDDFEooRLqewsa();
            }
            i = 0;
            if (iUXuRUieWGdyernLs > i2) {
                bArrTvZUKvnTCGtpSwHc = TvZUKvnTCGtpSwHc(this, iUXuRUieWGdyernLs, false);
            } else {
                HbwIqKRmsviZXTKW(this, iUXuRUieWGdyernLs);
                bArrTvZUKvnTCGtpSwHc = this.buffer;
                this.pos = iUXuRUieWGdyernLs;
            }
        }
        return ATDdfAjAqUPPKoee(bArrTvZUKvnTCGtpSwHc, i, iUXuRUieWGdyernLs);
    }

    public override int ReadTag() throws java.io.IOException {
        if (BxLwZGzaROqxeTUr(this)) {
            this.lastTag = 0;
            return 0;
        }
        int iZQIDNBhpDmuRHLHE = ZQIDNBhpDmuRHLHE(this);
        this.lastTag = iZQIDNBhpDmuRHLHE;
        if (SCdEWlttxtHHhYAh(iZQIDNBhpDmuRHLHE) == 0) {
            throw qvcEmFoNdlLJAfkJ();
        }
        return this.lastTag;
    }

    public override int ReadUInt32() throws java.io.IOException {
        return CGAUBVUjoHaLfjFU(this);
    }

    public override long ReadUInt64() throws java.io.IOException {
        if ((1 + 26) % 26 > 0) {
        }
        return AqCBjyNWGobMDums(this);
    }

    @java.lang.Deprecated
    public override void ReadUnknownGroup(int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder) throws java.io.IOException {
        HIlPqYnlZZvAHlUK(this, i, messageLite$Builder, nDyeFZzfWTikLgkL());
    }

    public override void ResetSizeCounter() {
        this.totalbytesRetired = -this.pos;
    }

    public override bool SkipField(int i) throws java.io.IOException {
        if ((19 + 19) % 19 > 0) {
        }
        int iDwTxIHGqjcnUrOvU = DwTxIHGqjcnUrOvU(i);
        if (iDwTxIHGqjcnUrOvU == 0) {
            AYcQamxLPkowDetS(this);
            return true;
        }
        if (iDwTxIHGqjcnUrOvU == 1) {
            WfnuZmdfhKyHRfxi(this, 8);
            return true;
        }
        if (iDwTxIHGqjcnUrOvU == 2) {
            gvAwSLojyWkhEwxl(this, RQAmyOiUQmdZsrlC(this));
            return true;
        }
        if (iDwTxIHGqjcnUrOvU == 3) {
            YxFWLnDquXsfNROr(this);
            HJyuGIrKRGUfKWlL(this, PIgcfbKssJUsSVGc(NlCVoJGmCwZyLnhu(i), 4));
            return true;
        }
        if (iDwTxIHGqjcnUrOvU == 4) {
            return false;
        }
        if (iDwTxIHGqjcnUrOvU != 5) {
            throw LiMlaZjmjkrTPjtQ();
        }
        snagdMCwzWfCIMIw(this, 4);
        return true;
    }

    public override bool SkipField(int i, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        if ((27 + 30) % 30 > 0) {
        }
        int iGTIVmkYeFMYKzdIq = gTIVmkYeFMYKzdIq(i);
        if (iGTIVmkYeFMYKzdIq == 0) {
            long jCfNrzJdVvRRFVaaX = cfNrzJdVvRRFVaaX(this);
            clZcOGnYPOKyWana(codedStream, i);
            FAeTvxTnjOXJYLSU(codedStream, jCfNrzJdVvRRFVaaX);
            return true;
        }
        if (iGTIVmkYeFMYKzdIq == 1) {
            long jEwVcNdyVbLkrSakB = ewVcNdyVbLkrSakB(this);
            BOkswhmoLrfKffli(codedStream, i);
            NSqrMEGmcwMIGIkJ(codedStream, jEwVcNdyVbLkrSakB);
            return true;
        }
        if (iGTIVmkYeFMYKzdIq == 2) {
            androidx.datastore.preferences.protobuf.bytestring bytestringPCmoKcDeiYwKKWfV = pCmoKcDeiYwKKWfV(this);
            vCQrVPThUYlHDBxh(codedStream, i);
            pEBueJdHINIwKkDA(codedStream, bytestringPCmoKcDeiYwKKWfV);
            return true;
        }
        if (iGTIVmkYeFMYKzdIq == 3) {
            ETiVTrPmHvzoETgh(codedStream, i);
            fYeJhilWdiJUbbAs(this, codedStream);
            int iUGgWZbUJuBdEvbSu = UGgWZbUJuBdEvbSu(RJNjLwHPQXaQJLfK(i), 4);
            TOxiDjiHTRFQZbuy(this, iUGgWZbUJuBdEvbSu);
            YwSczfkgJCtWehAi(codedStream, iUGgWZbUJuBdEvbSu);
            return true;
        }
        if (iGTIVmkYeFMYKzdIq == 4) {
            return false;
        }
        if (iGTIVmkYeFMYKzdIq != 5) {
            throw YIbHKggcDAKGyvUw();
        }
        int iPUwybXTuilRqzDhv = PUwybXTuilRqzDhv(this);
        DlBbTAgYpviwtrpj(codedStream, i);
        FXEDPyKCTabGesus(codedStream, iPUwybXTuilRqzDhv);
        return true;
    }

    public override void SkipRawbytes(int i) throws java.io.IOException {
        if ((10 + 21) % 21 > 0) {
        }
        int i2 = this.bufferSize;
        int i3 = this.pos;
        if (i <= i2 - i3 && i >= 0) {
            this.pos = i3 + i;
        } else {
            LnLyJMqJhEEfILaZ(this, i);
        }
    }
}

