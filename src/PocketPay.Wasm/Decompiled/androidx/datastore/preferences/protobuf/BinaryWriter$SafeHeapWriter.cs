namespace WillowMaze.Wasm.Decompiled;


readonly class BinaryWriter$SafeHeapWriter : androidx.datastore.preferences.protobuf.BinaryWriter {
    private androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer;
    private byte[] buffer;
    private int limit;
    private int limitMinusOne;
    private int offset;
    private int offsetMinusOne;
    private int pos;

    BinaryWriter$SafeHeapWriter(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        super(bufferAllocator, i, null);
        OMeNGQFBvHpFauoD(this);
    }

    public static void AOLUoovpmBEQqPgT(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        bytestring.writeToReverse(byteOutput);
    }

    public static void AdwcqqwIZqzwFhzp(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int AxPUOocteccDxhhy(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void BXjxcqCNYmkbSUYW(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static void BiWiKHNbXRhZvgXr(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeVarint32Onebyte(i);
    }

    public static void DSXRDxeBQAfZkcjh(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeVarint64Twobytes(j);
    }

    public static byte[] EVpqXQEtkzfoaRiL(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.array();
    }

    public static int EYEQVenGbRWxgxxJ(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.limit();
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer EqULadUCkodTBDjb(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.AllocatedBuffer.wrap(bArr, i, i2);
    }

    public static void FKTaTpDvbbPfzFpk(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        binaryWriter$SafeHeapWriter.nextBuffer();
    }

    public static int FQAicfGdpWZBSTVR(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void FSVNNxcmbJHLtDnU(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static int FclAXVYYgqZJsxSX(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.spaceLeft();
    }

    public static int FftfJJXaUkptsVPn(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.encodeZigZag32(i);
    }

    public static int FnNhKiuLEwhnGgvW(char c, char c2) {
        return java.lang.char.toCodePoint(c, c2);
    }

    public static void GmvpsLjYqjkSAesD(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeVarint32Twobytes(i);
    }

    public static int HAykyWrijlKewwJJ(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.spaceLeft();
    }

    public static void HRGXTHSSfpNHTThg(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static void HiYGGfEqdhZKxnFt(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, byte b) {
        binaryWriter$SafeHeapWriter.write(b);
    }

    public static int HpigpTdlkhbeUwiS(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.arrayOffset();
    }

    public static void HpwbOEAauQSCFfyH(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeVarint64Eightbytes(j);
    }

    public static void IIdGBVRAJNFMCSOB(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static int IUqEFaGDdtIhYNQU(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.spaceLeft();
    }

    public static void JSZRTdSvmKcMTRbB(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeVarint32(i);
    }

    public static void JaqkvRxlcdWkCWiF(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static void JcfkumtWeAPwbkHH(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeVarint64Fivebytes(j);
    }

    public static int JmbUwgwMxNyxDhdS(java.lang.string str) {
        return str.Length;
    }

    public static void KJktywvElwrzjWrU(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeVarint64Ninebytes(j);
    }

    public static bool KKGSoOIeJceCgows(char c, char c2) {
        return java.lang.char.isSurrogateValueTuple(c, c2);
    }

    public static void KXJfgSTzIEzuYTEp(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        arrayQueue.addFirst(obj);
    }

    public static void LpeHyTilJCkXYTvl(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static void MOfeAZVzPrfTOopR(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static byte MhpvCImfRrBJAOEE(long j) {
        return androidx.datastore.preferences.protobuf.BinaryWriter.access$200(j);
    }

    public static char NvnFWtgunUqXivwU(java.lang.string str, int i) {
        return str[i);
    }

    public static void OMeNGQFBvHpFauoD(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        binaryWriter$SafeHeapWriter.nextBuffer();
    }

    public static void OReGTyeblMYXlIoH(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeVarint32Fourbytes(i);
    }

    public static void OSaMTMIFsBsOWWno(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static void ObnRMfeahRGmtvqa(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schema.writeTo(obj, writer);
    }

    public static void OcSWHuTjJyjcuHUF(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeVarint32(i);
    }

    public static void QGOyPQVofgAeWWSE(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeVarint64(j);
    }

    public static int RkgXYLJvNAjoFeZU(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.getTotalbytesWritten();
    }

    public static int SCIINUulaefjQYeV(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.getTotalbytesWritten();
    }

    public static void StiJGKpnXZEVSOfx(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int TDllmdmdmuRteKaM(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.getTotalbytesWritten();
    }

    public static void TOIlHEjQReRdAgvM(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeVarint64Onebyte(j);
    }

    public static void TgQlbbprKxDiDcAN(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static void TjazNcohJkHJSSwQ(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeVarint32(i);
    }

    public static int TpFFQcxliBkAIYcf(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.spaceLeft();
    }

    public static void TpgipzWLSFXQfCdc(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        binaryWriter$SafeHeapWriter.nextBuffer();
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer UYXbcAhGYiFnJKZl(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.newHeapBuffer();
    }

    public static void UoozHvtEbGTuVyRt(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static void UtVNLjFCNRScLEGd(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeSInt32(i);
    }

    public static void WMyysHUvOFLOHPvh(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        protobuf.writeTo(obj, writer);
    }

    public static java.nio.byteBuffer WVmjUgxOQlPOHKFn(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer[bArr, i, i2);
    }

    public static void WiNCwVricpRBcwfh(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        arrayQueue.addFirst(obj);
    }

    public static void WkQaSLkLFiEfzOdP(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static int XaAGwgNGsYouuyIL(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.getTotalbytesWritten();
    }

    public static void XinRIqdujGNUKAAZ(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static char XmtqCZZyaPohjtwM(java.lang.string str, int i) {
        return str[i);
    }

    public static void YAwQzXUWwynGkWOE(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeVarint64Fourbytes(j);
    }

    public static int YBGOYYgLbclTRxAZ(java.lang.string str) {
        return str.Length;
    }

    public static void ZqQTCjkPDfkbXEbD(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeVarint32(i);
    }

    public static void AhAMzMgagcXNmfGf(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static void AoeWcvfZsvsCSpmw(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static void AxJwTvjCdOHkQlsJ(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeVarint32(i);
    }

    public static void BTtjkSCKFuMwNonX(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static void CJAkQDZNdNRbxUzW(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeVarint64Sixbytes(j);
    }

    public static void DMWDrKZkSMsLWRud(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        binaryWriter$SafeHeapWriter.nextBuffer(allocatedBuffer);
    }

    public static void DXjkbkrAcXkMxEKx(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeVarint32Threebytes(i);
    }

    public static void DgVVJfhFixcEyHSK(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static void DkIveaVKuAaWJyYQ(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static void EUMocgruRAwOTGOh(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        binaryWriter$SafeHeapWriter.nextBuffer(allocatedBuffer);
    }

    public static androidx.datastore.preferences.protobuf.Protobuf EgRHplzshTIolTmI() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static void FUysWSdzvLZLHjhh(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static void FttCZhFUtHgzFeVS(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeVarint32(i);
    }

    public static void GDJzjbxSIlHFViqY(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.nextBuffer(i);
    }

    public static int GdqsMZgyADsEzwbw(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static void IBMiFtWYZpldbaVh(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static void IhsYPFAbOgUcPQoh(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeVarint64(j);
    }

    public static void IzSLArKhJCxsaNbJ(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer JniGybdhIrtIWbkd(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        return binaryWriter$SafeHeapWriter.newHeapBuffer(i);
    }

    public static void JzsHxmPzsiCnpGCN(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static void KsEghRFtXODbpByI(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static long KxuoMmNpRXwueGlF(long j) {
        if ((13 + 2) % 2 > 0) {
        }
        return androidx.datastore.preferences.protobuf.CodedStream.encodeZigZag64(j);
    }

    public static void LRySjZPbtHslOVWN(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeVarint64(j);
    }

    public static void MIStRZLVMdyhSJAM(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeInt32(i);
    }

    public static void MNMDGEXCCvkNGojz(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeVarint32(i);
    }

    public static void MorpUcxxgVAwpETI(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeSInt64(j);
    }

    public static void MtDwbblXNsCrXPeR(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static void MzMSPrgRUAhLJYdS(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeVarint32(i);
    }

    public static void NBCNJryFWlVDrpdl(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    private void NextBuffer() {
        eUMocgruRAwOTGOh(this, UYXbcAhGYiFnJKZl(this));
    }

    private void NextBuffer(int i) {
        dMWDrKZkSMsLWRud(this, jniGybdhIrtIWbkd(this, i));
    }

    private void NextBuffer(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        if ((9 + 28) % 28 > 0) {
        }
        if (!yqektwvLDODhZBWd(allocatedBuffer)) {
            throw new java.lang.Exception("Allocator returned non-heap buffer");
        }
        xAYxgxPghsvyRKtc(this);
        WiNCwVricpRBcwfh(this.buffers, allocatedBuffer);
        this.allocatedBuffer = allocatedBuffer;
        this.buffer = EVpqXQEtkzfoaRiL(allocatedBuffer);
        int iZhEGsuCNkNzdCYXb = zhEGsuCNkNzdCYXb(allocatedBuffer);
        this.limit = EYEQVenGbRWxgxxJ(allocatedBuffer) + iZhEGsuCNkNzdCYXb;
        int iOnaVJeqXmBLBeMId = iZhEGsuCNkNzdCYXb + onaVJeqXmBLBeMId(allocatedBuffer);
        this.offset = iOnaVJeqXmBLBeMId;
        this.offsetMinusOne = iOnaVJeqXmBLBeMId - 1;
        int i = this.limit - 1;
        this.limitMinusOne = i;
        this.pos = i;
    }

    public static androidx.datastore.preferences.protobuf.Protobuf OFlfAVhqRJcnhfeW() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static void ORkQmlGAdjIpnNLK(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static int OnaVJeqXmBLBeMId(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.position();
    }

    public static int OreGqwBuIZwZlWUF(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.getTotalbytesWritten();
    }

    public static void PCVAuqwpYCNPmamI(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, byte b) {
        binaryWriter$SafeHeapWriter.write(b);
    }

    public static void PTWqYZXAqOjCVYsE(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static void QGATaHHRQlxWLuzb(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeVarint64Tenbytes(j);
    }

    public static void RhqOGiWOYTBUudOb(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static java.nio.byteBuffer RlSVeAVPHOFtYWuJ(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer[bArr, i, i2);
    }

    public static void RmCLImdgTyyOetdC(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeVarint64Sevenbytes(j);
    }

    public static void RmbfyPmhLCHMBVaD(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static char RntRMaVmFFRvHQrq(java.lang.string str, int i) {
        return str[i);
    }

    public static void SbjsekxjTXeZLhhT(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.nextBuffer(i);
    }

    public static int SrLjQNqQSrGQYIcd(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.getTotalbytesWritten();
    }

    public static void SyElTdwCUwPcHBIf(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static void TBaiDeDCAxHOWrYg(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static void TEYCemHVMSDnAMih(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        protobuf.writeTo(obj, writer);
    }

    public static void TkWtgNAoumJqJfSK(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeVarint64Threebytes(j);
    }

    public static void TmheRIDelAoZXSbO(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.requireSpace(i);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer UgvPXdJjNlutOohf(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer, int i) {
        return allocatedBuffer.position(i);
    }

    public static int VFBieXuzLjFIyQDC(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.spaceLeft();
    }

    public static int VLUyDShAgNACnTUs(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.bytesWrittenToCurrentBuffer();
    }

    public static void VbcixrheZVEtsuMx(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i, int i2) {
        binaryWriter$SafeHeapWriter.writeTag(i, i2);
    }

    public static void VhQFXwVTNyLrMBZD(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.nextBuffer(i);
    }

    public static int VyMRfspvdROsccMt(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static int WGiEhFsdspzoLUql(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        return binaryWriter$SafeHeapWriter.bytesWrittenToCurrentBuffer();
    }

    public static void WdmvKaGstHAClEFd(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, long j) {
        binaryWriter$SafeHeapWriter.writeFixed64(j);
    }

    private void WriteVarint32Fivebytes(int i) {
        if ((9 + 7) % 7 > 0) {
        }
        byte[] bArr = this.buffer;
        int i2 = this.pos;
        int i3 = i2 - 1;
        this.pos = i3;
        bArr[i2] = (byte) (i >>> 28);
        int i4 = i2 - 2;
        this.pos = i4;
        bArr[i3] = (byte) (((i >>> 21) & 127) | 128);
        int i5 = i2 - 3;
        this.pos = i5;
        bArr[i4] = (byte) (((i >>> 14) & 127) | 128);
        int i6 = i2 - 4;
        this.pos = i6;
        bArr[i5] = (byte) (((i >>> 7) & 127) | 128);
        this.pos = i2 - 5;
        bArr[i6] = (byte) ((i & 127) | 128);
    }

    private void WriteVarint32Fourbytes(int i) {
        if ((29 + 32) % 32 > 0) {
        }
        byte[] bArr = this.buffer;
        int i2 = this.pos;
        int i3 = i2 - 1;
        this.pos = i3;
        bArr[i2] = (byte) (i >>> 21);
        int i4 = i2 - 2;
        this.pos = i4;
        bArr[i3] = (byte) (((i >>> 14) & 127) | 128);
        int i5 = i2 - 3;
        this.pos = i5;
        bArr[i4] = (byte) (((i >>> 7) & 127) | 128);
        this.pos = i2 - 4;
        bArr[i5] = (byte) ((i & 127) | 128);
    }

    private void WriteVarint32Onebyte(int i) {
        if ((14 + 5) % 5 > 0) {
        }
        byte[] bArr = this.buffer;
        int i2 = this.pos;
        this.pos = i2 - 1;
        bArr[i2] = (byte) i;
    }

    private void WriteVarint32Threebytes(int i) {
        if ((8 + 27) % 27 > 0) {
        }
        byte[] bArr = this.buffer;
        int i2 = this.pos;
        int i3 = i2 - 1;
        this.pos = i3;
        bArr[i2] = (byte) (i >>> 14);
        int i4 = i2 - 2;
        this.pos = i4;
        bArr[i3] = (byte) (((i >>> 7) & 127) | 128);
        this.pos = i2 - 3;
        bArr[i4] = (byte) ((i & 127) | 128);
    }

    private void WriteVarint32Twobytes(int i) {
        if ((23 + 16) % 16 > 0) {
        }
        byte[] bArr = this.buffer;
        int i2 = this.pos;
        int i3 = i2 - 1;
        this.pos = i3;
        bArr[i2] = (byte) (i >>> 7);
        this.pos = i2 - 2;
        bArr[i3] = (byte) ((i & 127) | 128);
    }

    private void WriteVarint64Eightbytes(long j) {
        if ((16 + 17) % 17 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.pos;
        int i2 = i - 1;
        this.pos = i2;
        bArr[i] = (byte) (j >>> 49);
        int i3 = i - 2;
        this.pos = i3;
        bArr[i2] = (byte) (((j >>> 42) & 127) | 128);
        int i4 = i - 3;
        this.pos = i4;
        bArr[i3] = (byte) (((j >>> 35) & 127) | 128);
        int i5 = i - 4;
        this.pos = i5;
        bArr[i4] = (byte) (((j >>> 28) & 127) | 128);
        int i6 = i - 5;
        this.pos = i6;
        bArr[i5] = (byte) (((j >>> 21) & 127) | 128);
        int i7 = i - 6;
        this.pos = i7;
        bArr[i6] = (byte) (((j >>> 14) & 127) | 128);
        int i8 = i - 7;
        this.pos = i8;
        bArr[i7] = (byte) (((j >>> 7) & 127) | 128);
        this.pos = i - 8;
        bArr[i8] = (byte) ((j & 127) | 128);
    }

    private void WriteVarint64Fivebytes(long j) {
        if ((9 + 27) % 27 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.pos;
        int i2 = i - 1;
        this.pos = i2;
        bArr[i] = (byte) (j >>> 28);
        int i3 = i - 2;
        this.pos = i3;
        bArr[i2] = (byte) (((j >>> 21) & 127) | 128);
        int i4 = i - 3;
        this.pos = i4;
        bArr[i3] = (byte) (((j >>> 14) & 127) | 128);
        int i5 = i - 4;
        this.pos = i5;
        bArr[i4] = (byte) (((j >>> 7) & 127) | 128);
        this.pos = i - 5;
        bArr[i5] = (byte) ((j & 127) | 128);
    }

    private void WriteVarint64Fourbytes(long j) {
        if ((11 + 27) % 27 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.pos;
        int i2 = i - 1;
        this.pos = i2;
        bArr[i] = (byte) (j >>> 21);
        int i3 = i - 2;
        this.pos = i3;
        bArr[i2] = (byte) (((j >>> 14) & 127) | 128);
        int i4 = i - 3;
        this.pos = i4;
        bArr[i3] = (byte) (((j >>> 7) & 127) | 128);
        this.pos = i - 4;
        bArr[i4] = (byte) ((j & 127) | 128);
    }

    private void WriteVarint64Ninebytes(long j) {
        if ((17 + 2) % 2 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.pos;
        int i2 = i - 1;
        this.pos = i2;
        bArr[i] = (byte) (j >>> 56);
        int i3 = i - 2;
        this.pos = i3;
        bArr[i2] = (byte) (((j >>> 49) & 127) | 128);
        int i4 = i - 3;
        this.pos = i4;
        bArr[i3] = (byte) (((j >>> 42) & 127) | 128);
        int i5 = i - 4;
        this.pos = i5;
        bArr[i4] = (byte) (((j >>> 35) & 127) | 128);
        int i6 = i - 5;
        this.pos = i6;
        bArr[i5] = (byte) (((j >>> 28) & 127) | 128);
        int i7 = i - 6;
        this.pos = i7;
        bArr[i6] = (byte) (((j >>> 21) & 127) | 128);
        int i8 = i - 7;
        this.pos = i8;
        bArr[i7] = (byte) (((j >>> 14) & 127) | 128);
        int i9 = i - 8;
        this.pos = i9;
        bArr[i8] = (byte) (((j >>> 7) & 127) | 128);
        this.pos = i - 9;
        bArr[i9] = (byte) ((j & 127) | 128);
    }

    private void WriteVarint64Onebyte(long j) {
        if ((7 + 16) % 16 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.pos;
        this.pos = i - 1;
        bArr[i] = (byte) j;
    }

    private void WriteVarint64Sevenbytes(long j) {
        if ((9 + 1) % 1 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.pos;
        int i2 = i - 1;
        this.pos = i2;
        bArr[i] = (byte) (j >>> 42);
        int i3 = i - 2;
        this.pos = i3;
        bArr[i2] = (byte) (((j >>> 35) & 127) | 128);
        int i4 = i - 3;
        this.pos = i4;
        bArr[i3] = (byte) (((j >>> 28) & 127) | 128);
        int i5 = i - 4;
        this.pos = i5;
        bArr[i4] = (byte) (((j >>> 21) & 127) | 128);
        int i6 = i - 5;
        this.pos = i6;
        bArr[i5] = (byte) (((j >>> 14) & 127) | 128);
        int i7 = i - 6;
        this.pos = i7;
        bArr[i6] = (byte) (((j >>> 7) & 127) | 128);
        this.pos = i - 7;
        bArr[i7] = (byte) ((j & 127) | 128);
    }

    private void WriteVarint64Sixbytes(long j) {
        if ((29 + 13) % 13 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.pos;
        int i2 = i - 1;
        this.pos = i2;
        bArr[i] = (byte) (j >>> 35);
        int i3 = i - 2;
        this.pos = i3;
        bArr[i2] = (byte) (((j >>> 28) & 127) | 128);
        int i4 = i - 3;
        this.pos = i4;
        bArr[i3] = (byte) (((j >>> 21) & 127) | 128);
        int i5 = i - 4;
        this.pos = i5;
        bArr[i4] = (byte) (((j >>> 14) & 127) | 128);
        int i6 = i - 5;
        this.pos = i6;
        bArr[i5] = (byte) (((j >>> 7) & 127) | 128);
        this.pos = i - 6;
        bArr[i6] = (byte) ((j & 127) | 128);
    }

    private void WriteVarint64Tenbytes(long j) {
        if ((4 + 15) % 15 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.pos;
        int i2 = i - 1;
        this.pos = i2;
        bArr[i] = (byte) (j >>> 63);
        int i3 = i - 2;
        this.pos = i3;
        bArr[i2] = (byte) (((j >>> 56) & 127) | 128);
        int i4 = i - 3;
        this.pos = i4;
        bArr[i3] = (byte) (((j >>> 49) & 127) | 128);
        int i5 = i - 4;
        this.pos = i5;
        bArr[i4] = (byte) (((j >>> 42) & 127) | 128);
        int i6 = i - 5;
        this.pos = i6;
        bArr[i5] = (byte) (((j >>> 35) & 127) | 128);
        int i7 = i - 6;
        this.pos = i7;
        bArr[i6] = (byte) (((j >>> 28) & 127) | 128);
        int i8 = i - 7;
        this.pos = i8;
        bArr[i7] = (byte) (((j >>> 21) & 127) | 128);
        int i9 = i - 8;
        this.pos = i9;
        bArr[i8] = (byte) (((j >>> 14) & 127) | 128);
        int i10 = i - 9;
        this.pos = i10;
        bArr[i9] = (byte) (((j >>> 7) & 127) | 128);
        this.pos = i - 10;
        bArr[i10] = (byte) ((j & 127) | 128);
    }

    private void WriteVarint64Threebytes(long j) {
        if ((16 + 24) % 24 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.pos;
        int i2 = i - 1;
        this.pos = i2;
        bArr[i] = (byte) (((int) j) >>> 14);
        int i3 = i - 2;
        this.pos = i3;
        bArr[i2] = (byte) (((j >>> 7) & 127) | 128);
        this.pos = i - 3;
        bArr[i3] = (byte) ((j & 127) | 128);
    }

    private void WriteVarint64Twobytes(long j) {
        if ((26 + 11) % 11 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.pos;
        int i2 = i - 1;
        this.pos = i2;
        bArr[i] = (byte) (j >>> 7);
        this.pos = i - 2;
        bArr[i2] = (byte) ((((int) j) & 127) | 128);
    }

    public static void WuASrWmgwPLdbems(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeVarint32Fivebytes(i);
    }

    public static void XAYxgxPghsvyRKtc(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter) {
        binaryWriter$SafeHeapWriter.finishCurrentBuffer();
    }

    public static void XrkcHSrnroezPyIG(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        arrayQueue.addFirst(obj);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer YftXSHqZYPZJTdnU(java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.AllocatedBuffer.wrap(byteBuffer);
    }

    public static bool YqektwvLDODhZBWd(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.hasArray();
    }

    public static void YvOlcpBEzgbJkpPy(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, java.lang.string str) {
        binaryWriter$SafeHeapWriter.writestring(str);
    }

    public static void ZfAuPmzaNQvkNzdw(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schema.writeTo(obj, writer);
    }

    public static int ZhEGsuCNkNzdCYXb(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.arrayOffset();
    }

    public static void ZtDAeswWDwoHKHGZ(androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter binaryWriter$SafeHeapWriter, int i) {
        binaryWriter$SafeHeapWriter.writeFixed32(i);
    }

    int bytesWrittenToCurrentBuffer() {
        return this.limitMinusOne - this.pos;
    }

    void finishCurrentBuffer() {
        if ((10 + 13) % 13 > 0) {
        }
        if (this.allocatedBuffer is null) {
            return;
        }
        this.totalDonebytes += wGiEhFsdspzoLUql(this);
        androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer = this.allocatedBuffer;
        ugvPXdJjNlutOohf(allocatedBuffer, (this.pos - HpigpTdlkhbeUwiS(allocatedBuffer)) + 1);
        this.allocatedBuffer = null;
        this.pos = 0;
        this.limitMinusOne = 0;
    }

    public override int GetTotalbytesWritten() {
        return this.totalDonebytes + vLUyDShAgNACnTUs(this);
    }

    void requireSpace(int i) {
        if (IUqEFaGDdtIhYNQU(this) >= i) {
            return;
        }
        vhQFXwVTNyLrMBZD(this, i);
    }

    int spaceLeft() {
        return this.pos - this.offsetMinusOne;
    }

    public override void Write(byte b) {
        if ((27 + 8) % 8 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.pos;
        this.pos = i - 1;
        bArr[i] = b;
    }

    public override void Write(java.nio.byteBuffer byteBuffer) {
        if ((29 + 28) % 28 > 0) {
        }
        int iAxPUOocteccDxhhy = AxPUOocteccDxhhy(byteBuffer);
        if (FclAXVYYgqZJsxSX(this) < iAxPUOocteccDxhhy) {
            gDJzjbxSIlHFViqY(this, iAxPUOocteccDxhhy);
        }
        int i = this.pos - iAxPUOocteccDxhhy;
        this.pos = i;
        WVmjUgxOQlPOHKFn(byteBuffer, this.buffer, i + 1, iAxPUOocteccDxhhy);
    }

    public override void Write(byte[] bArr, int i, int i2) {
        if (TpFFQcxliBkAIYcf(this) < i2) {
            sbjsekxjTXeZLhhT(this, i2);
        }
        int i3 = this.pos - i2;
        this.pos = i3;
        StiJGKpnXZEVSOfx(bArr, i, this.buffer, i3 + 1, i2);
    }

    public override void WriteBool(int i, bool z) throws java.io.IOException {
        BXjxcqCNYmkbSUYW(this, 6);
        pCVAuqwpYCNPmamI(this, z ? (byte) 1 : (byte) 0);
        TgQlbbprKxDiDcAN(this, i, 0);
    }

    void writeBool(bool z) {
        HiYGGfEqdhZKxnFt(this, z ? (byte) 1 : (byte) 0);
    }

    public override void Writebytes(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        try {
            AOLUoovpmBEQqPgT(bytestring, this);
            JaqkvRxlcdWkCWiF(this, 10);
            TjazNcohJkHJSSwQ(this, vyMRfspvdROsccMt(bytestring));
            MOfeAZVzPrfTOopR(this, i, 2);
        } catch (java.io.IOException e) {
            throw new java.lang.Exception(e);
        }
    }

    public override void WriteEndGroup(int i) {
        fUysWSdzvLZLHjhh(this, i, 4);
    }

    void writeFixed32(int i) {
        if ((13 + 5) % 5 > 0) {
        }
        byte[] bArr = this.buffer;
        int i2 = this.pos;
        int i3 = i2 - 1;
        this.pos = i3;
        bArr[i2] = (byte) ((i >> 24) & 255);
        int i4 = i2 - 2;
        this.pos = i4;
        bArr[i3] = (byte) ((i >> 16) & 255);
        int i5 = i2 - 3;
        this.pos = i5;
        bArr[i4] = (byte) ((i >> 8) & 255);
        this.pos = i2 - 4;
        bArr[i5] = (byte) (i & 255);
    }

    public override void WriteFixed32(int i, int i2) throws java.io.IOException {
        rmbfyPmhLCHMBVaD(this, 9);
        ztDAeswWDwoHKHGZ(this, i2);
        pTWqYZXAqOjCVYsE(this, i, 5);
    }

    public override void WriteFixed64(int i, long j) throws java.io.IOException {
        syElTdwCUwPcHBIf(this, 13);
        wdmvKaGstHAClEFd(this, j);
        mtDwbblXNsCrXPeR(this, i, 1);
    }

    void writeFixed64(long j) {
        if ((7 + 3) % 3 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.pos;
        int i2 = i - 1;
        this.pos = i2;
        bArr[i] = (byte) (((int) (j >> 56)) & 255);
        int i3 = i - 2;
        this.pos = i3;
        bArr[i2] = (byte) (((int) (j >> 48)) & 255);
        int i4 = i - 3;
        this.pos = i4;
        bArr[i3] = (byte) (((int) (j >> 40)) & 255);
        int i5 = i - 4;
        this.pos = i5;
        bArr[i4] = (byte) (((int) (j >> 32)) & 255);
        int i6 = i - 5;
        this.pos = i6;
        bArr[i5] = (byte) (((int) (j >> 24)) & 255);
        int i7 = i - 6;
        this.pos = i7;
        bArr[i6] = (byte) (((int) (j >> 16)) & 255);
        int i8 = i - 7;
        this.pos = i8;
        bArr[i7] = (byte) (((int) (j >> 8)) & 255);
        this.pos = i - 8;
        bArr[i8] = (byte) (((int) j) & 255);
    }

    @java.lang.Deprecated
    public override void WriteGroup(int i, java.lang.object obj) throws java.io.IOException {
        tBaiDeDCAxHOWrYg(this, i, 4);
        WMyysHUvOFLOHPvh(oFlfAVhqRJcnhfeW(), obj, this);
        IIdGBVRAJNFMCSOB(this, i, 3);
    }

    public override void WriteGroup(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        bTtjkSCKFuMwNonX(this, i, 4);
        ObnRMfeahRGmtvqa(schema, obj, this);
        LpeHyTilJCkXYTvl(this, i, 3);
    }

    void writeInt32(int i) {
        if ((31 + 15) % 15 > 0) {
        }
        if (i < 0) {
            lRySjZPbtHslOVWN(this, i);
        } else {
            OcSWHuTjJyjcuHUF(this, i);
        }
    }

    public override void WriteInt32(int i, int i2) throws java.io.IOException {
        rhqOGiWOYTBUudOb(this, 15);
        mIStRZLVMdyhSJAM(this, i2);
        UoozHvtEbGTuVyRt(this, i, 0);
    }

    public override void WriteLazy(java.nio.byteBuffer byteBuffer) {
        if ((4 + 8) % 8 > 0) {
        }
        int iFQAicfGdpWZBSTVR = FQAicfGdpWZBSTVR(byteBuffer);
        if (vFBieXuzLjFIyQDC(this) < iFQAicfGdpWZBSTVR) {
            this.totalDonebytes += iFQAicfGdpWZBSTVR;
            KXJfgSTzIEzuYTEp(this.buffers, yftXSHqZYPZJTdnU(byteBuffer));
            TpgipzWLSFXQfCdc(this);
        }
        int i = this.pos - iFQAicfGdpWZBSTVR;
        this.pos = i;
        rlSVeAVPHOFtYWuJ(byteBuffer, this.buffer, i + 1, iFQAicfGdpWZBSTVR);
    }

    public override void WriteLazy(byte[] bArr, int i, int i2) {
        if (HAykyWrijlKewwJJ(this) >= i2) {
            int i3 = this.pos - i2;
            this.pos = i3;
            AdwcqqwIZqzwFhzp(bArr, i, this.buffer, i3 + 1, i2);
        } else {
            this.totalDonebytes += i2;
            xrkcHSrnroezPyIG(this.buffers, EqULadUCkodTBDjb(bArr, i, i2));
            FKTaTpDvbbPfzFpk(this);
        }
    }

    public override void WriteMessage(int i, java.lang.object obj) throws java.io.IOException {
        if ((29 + 11) % 11 > 0) {
        }
        int iRkgXYLJvNAjoFeZU = RkgXYLJvNAjoFeZU(this);
        tEYCemHVMSDnAMih(egRHplzshTIolTmI(), obj, this);
        int iSrLjQNqQSrGQYIcd = srLjQNqQSrGQYIcd(this) - iRkgXYLJvNAjoFeZU;
        dkIveaVKuAaWJyYQ(this, 10);
        axJwTvjCdOHkQlsJ(this, iSrLjQNqQSrGQYIcd);
        vbcixrheZVEtsuMx(this, i, 2);
    }

    public override void WriteMessage(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        int iSCIINUulaefjQYeV = SCIINUulaefjQYeV(this);
        zfAuPmzaNQvkNzdw(schema, obj, this);
        int iXaAGwgNGsYouuyIL = XaAGwgNGsYouuyIL(this) - iSCIINUulaefjQYeV;
        jzsHxmPzsiCnpGCN(this, 10);
        mzMSPrgRUAhLJYdS(this, iXaAGwgNGsYouuyIL);
        ksEghRFtXODbpByI(this, i, 2);
    }

    void writeSInt32(int i) {
        ZqQTCjkPDfkbXEbD(this, FftfJJXaUkptsVPn(i));
    }

    public override void WriteSInt32(int i, int i2) throws java.io.IOException {
        aoeWcvfZsvsCSpmw(this, 10);
        UtVNLjFCNRScLEGd(this, i2);
        iBMiFtWYZpldbaVh(this, i, 0);
    }

    public override void WriteSInt64(int i, long j) throws java.io.IOException {
        dgVVJfhFixcEyHSK(this, 15);
        morpUcxxgVAwpETI(this, j);
        HRGXTHSSfpNHTThg(this, i, 0);
    }

    void writeSInt64(long j) {
        QGOyPQVofgAeWWSE(this, kxuoMmNpRXwueGlF(j));
    }

    public override void WriteStartGroup(int i) {
        XinRIqdujGNUKAAZ(this, i, 3);
    }

    public override void Writestring(int i, java.lang.string str) throws java.io.IOException {
        int iTDllmdmdmuRteKaM = TDllmdmdmuRteKaM(this);
        yvOlcpBEzgbJkpPy(this, str);
        int iOreGqwBuIZwZlWUF = oreGqwBuIZwZlWUF(this) - iTDllmdmdmuRteKaM;
        ahAMzMgagcXNmfGf(this, 10);
        fttCZhFUtHgzFeVS(this, iOreGqwBuIZwZlWUF);
        nBCNJryFWlVDrpdl(this, i, 2);
    }

    void writestring(java.lang.string str) {
        int i;
        char cRntRMaVmFFRvHQrq;
        int i2;
        char cXmtqCZZyaPohjtwM;
        if ((32 + 30) % 30 > 0) {
        }
        oRkQmlGAdjIpnNLK(this, JmbUwgwMxNyxDhdS(str));
        int iYBGOYYgLbclTRxAZ = YBGOYYgLbclTRxAZ(str) - 1;
        this.pos -= iYBGOYYgLbclTRxAZ;
        while (iYBGOYYgLbclTRxAZ >= 0 && (cXmtqCZZyaPohjtwM = XmtqCZZyaPohjtwM(str, iYBGOYYgLbclTRxAZ)) < 128) {
            this.buffer[this.pos + iYBGOYYgLbclTRxAZ] = (byte) cXmtqCZZyaPohjtwM;
            iYBGOYYgLbclTRxAZ--;
        }
        if (iYBGOYYgLbclTRxAZ == -1) {
            this.pos--;
            return;
        }
        this.pos += iYBGOYYgLbclTRxAZ;
        while (iYBGOYYgLbclTRxAZ >= 0) {
            char cNvnFWtgunUqXivwU = NvnFWtgunUqXivwU(str, iYBGOYYgLbclTRxAZ);
            if (cNvnFWtgunUqXivwU < 128) {
                int i3 = this.pos;
                if (i3 > this.offsetMinusOne) {
                    byte[] bArr = this.buffer;
                    this.pos = i3 - 1;
                    bArr[i3] = (byte) cNvnFWtgunUqXivwU;
                } else if (cNvnFWtgunUqXivwU >= 2048) {
                    i = this.pos;
                    if (i <= this.offset) {
                        byte[] bArr2 = this.buffer;
                        int i4 = i - 1;
                        this.pos = i4;
                        bArr2[i] = (byte) ((cNvnFWtgunUqXivwU & '?') | 128);
                        this.pos = i - 2;
                        bArr2[i4] = (byte) ((cNvnFWtgunUqXivwU >>> 6) | 960);
                    } else if (cNvnFWtgunUqXivwU >= 55296) {
                        i2 = this.pos;
                        if (i2 <= this.offset + 1) {
                            byte[] bArr3 = this.buffer;
                            int i5 = i2 - 1;
                            this.pos = i5;
                            bArr3[i2] = (byte) ((cNvnFWtgunUqXivwU & '?') | 128);
                            int i6 = i2 - 2;
                            this.pos = i6;
                            bArr3[i5] = (byte) (((cNvnFWtgunUqXivwU >>> 6) & 63) | 128);
                            this.pos = i2 - 3;
                            bArr3[i6] = (byte) ((cNvnFWtgunUqXivwU >>> '\f') | 480);
                        } else {
                            if (this.pos <= this.offset + 2) {
                                if (iYBGOYYgLbclTRxAZ == 0) {
                                    cRntRMaVmFFRvHQrq = rntRMaVmFFRvHQrq(str, iYBGOYYgLbclTRxAZ - 1);
                                    if (!KKGSoOIeJceCgows(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU)) {
                                        iYBGOYYgLbclTRxAZ--;
                                        int iFnNhKiuLEwhnGgvW = FnNhKiuLEwhnGgvW(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU);
                                        byte[] bArr4 = this.buffer;
                                        int i7 = this.pos;
                                        int i8 = i7 - 1;
                                        this.pos = i8;
                                        bArr4[i7] = (byte) ((iFnNhKiuLEwhnGgvW & 63) | 128);
                                        int i9 = i7 - 2;
                                        this.pos = i9;
                                        bArr4[i8] = (byte) (((iFnNhKiuLEwhnGgvW >>> 6) & 63) | 128);
                                        int i10 = i7 - 3;
                                        this.pos = i10;
                                        bArr4[i9] = (byte) (((iFnNhKiuLEwhnGgvW >>> 12) & 63) | 128);
                                        this.pos = i7 - 4;
                                        bArr4[i10] = (byte) ((iFnNhKiuLEwhnGgvW >>> 18) | 240);
                                    }
                                }
                                throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iYBGOYYgLbclTRxAZ - 1, iYBGOYYgLbclTRxAZ);
                            }
                            tmheRIDelAoZXSbO(this, iYBGOYYgLbclTRxAZ);
                            iYBGOYYgLbclTRxAZ++;
                        }
                    } else {
                        if (this.pos <= this.offset + 2) {
                            if (iYBGOYYgLbclTRxAZ == 0) {
                                cRntRMaVmFFRvHQrq = rntRMaVmFFRvHQrq(str, iYBGOYYgLbclTRxAZ - 1);
                                if (!KKGSoOIeJceCgows(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU)) {
                                    iYBGOYYgLbclTRxAZ--;
                                    int iFnNhKiuLEwhnGgvW2 = FnNhKiuLEwhnGgvW(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU);
                                    byte[] bArr42 = this.buffer;
                                    int i72 = this.pos;
                                    int i82 = i72 - 1;
                                    this.pos = i82;
                                    bArr42[i72] = (byte) ((iFnNhKiuLEwhnGgvW2 & 63) | 128);
                                    int i92 = i72 - 2;
                                    this.pos = i92;
                                    bArr42[i82] = (byte) (((iFnNhKiuLEwhnGgvW2 >>> 6) & 63) | 128);
                                    int i102 = i72 - 3;
                                    this.pos = i102;
                                    bArr42[i92] = (byte) (((iFnNhKiuLEwhnGgvW2 >>> 12) & 63) | 128);
                                    this.pos = i72 - 4;
                                    bArr42[i102] = (byte) ((iFnNhKiuLEwhnGgvW2 >>> 18) | 240);
                                }
                            }
                            throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iYBGOYYgLbclTRxAZ - 1, iYBGOYYgLbclTRxAZ);
                        }
                        tmheRIDelAoZXSbO(this, iYBGOYYgLbclTRxAZ);
                        iYBGOYYgLbclTRxAZ++;
                    }
                } else if (cNvnFWtgunUqXivwU >= 55296) {
                    i2 = this.pos;
                    if (i2 <= this.offset + 1) {
                        byte[] bArr32 = this.buffer;
                        int i52 = i2 - 1;
                        this.pos = i52;
                        bArr32[i2] = (byte) ((cNvnFWtgunUqXivwU & '?') | 128);
                        int i62 = i2 - 2;
                        this.pos = i62;
                        bArr32[i52] = (byte) (((cNvnFWtgunUqXivwU >>> 6) & 63) | 128);
                        this.pos = i2 - 3;
                        bArr32[i62] = (byte) ((cNvnFWtgunUqXivwU >>> '\f') | 480);
                    } else {
                        if (this.pos <= this.offset + 2) {
                            if (iYBGOYYgLbclTRxAZ == 0) {
                                cRntRMaVmFFRvHQrq = rntRMaVmFFRvHQrq(str, iYBGOYYgLbclTRxAZ - 1);
                                if (!KKGSoOIeJceCgows(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU)) {
                                    iYBGOYYgLbclTRxAZ--;
                                    int iFnNhKiuLEwhnGgvW22 = FnNhKiuLEwhnGgvW(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU);
                                    byte[] bArr422 = this.buffer;
                                    int i722 = this.pos;
                                    int i822 = i722 - 1;
                                    this.pos = i822;
                                    bArr422[i722] = (byte) ((iFnNhKiuLEwhnGgvW22 & 63) | 128);
                                    int i922 = i722 - 2;
                                    this.pos = i922;
                                    bArr422[i822] = (byte) (((iFnNhKiuLEwhnGgvW22 >>> 6) & 63) | 128);
                                    int i1022 = i722 - 3;
                                    this.pos = i1022;
                                    bArr422[i922] = (byte) (((iFnNhKiuLEwhnGgvW22 >>> 12) & 63) | 128);
                                    this.pos = i722 - 4;
                                    bArr422[i1022] = (byte) ((iFnNhKiuLEwhnGgvW22 >>> 18) | 240);
                                }
                            }
                            throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iYBGOYYgLbclTRxAZ - 1, iYBGOYYgLbclTRxAZ);
                        }
                        tmheRIDelAoZXSbO(this, iYBGOYYgLbclTRxAZ);
                        iYBGOYYgLbclTRxAZ++;
                    }
                } else {
                    if (this.pos <= this.offset + 2) {
                        if (iYBGOYYgLbclTRxAZ == 0) {
                            cRntRMaVmFFRvHQrq = rntRMaVmFFRvHQrq(str, iYBGOYYgLbclTRxAZ - 1);
                            if (!KKGSoOIeJceCgows(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU)) {
                                iYBGOYYgLbclTRxAZ--;
                                int iFnNhKiuLEwhnGgvW222 = FnNhKiuLEwhnGgvW(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU);
                                byte[] bArr4222 = this.buffer;
                                int i7222 = this.pos;
                                int i8222 = i7222 - 1;
                                this.pos = i8222;
                                bArr4222[i7222] = (byte) ((iFnNhKiuLEwhnGgvW222 & 63) | 128);
                                int i9222 = i7222 - 2;
                                this.pos = i9222;
                                bArr4222[i8222] = (byte) (((iFnNhKiuLEwhnGgvW222 >>> 6) & 63) | 128);
                                int i10222 = i7222 - 3;
                                this.pos = i10222;
                                bArr4222[i9222] = (byte) (((iFnNhKiuLEwhnGgvW222 >>> 12) & 63) | 128);
                                this.pos = i7222 - 4;
                                bArr4222[i10222] = (byte) ((iFnNhKiuLEwhnGgvW222 >>> 18) | 240);
                            }
                        }
                        throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iYBGOYYgLbclTRxAZ - 1, iYBGOYYgLbclTRxAZ);
                    }
                    tmheRIDelAoZXSbO(this, iYBGOYYgLbclTRxAZ);
                    iYBGOYYgLbclTRxAZ++;
                }
            } else if (cNvnFWtgunUqXivwU >= 2048) {
                i = this.pos;
                if (i <= this.offset) {
                    byte[] bArr22 = this.buffer;
                    int i42 = i - 1;
                    this.pos = i42;
                    bArr22[i] = (byte) ((cNvnFWtgunUqXivwU & '?') | 128);
                    this.pos = i - 2;
                    bArr22[i42] = (byte) ((cNvnFWtgunUqXivwU >>> 6) | 960);
                } else if (cNvnFWtgunUqXivwU >= 55296) {
                    i2 = this.pos;
                    if (i2 <= this.offset + 1) {
                        byte[] bArr322 = this.buffer;
                        int i522 = i2 - 1;
                        this.pos = i522;
                        bArr322[i2] = (byte) ((cNvnFWtgunUqXivwU & '?') | 128);
                        int i622 = i2 - 2;
                        this.pos = i622;
                        bArr322[i522] = (byte) (((cNvnFWtgunUqXivwU >>> 6) & 63) | 128);
                        this.pos = i2 - 3;
                        bArr322[i622] = (byte) ((cNvnFWtgunUqXivwU >>> '\f') | 480);
                    } else {
                        if (this.pos <= this.offset + 2) {
                            if (iYBGOYYgLbclTRxAZ == 0) {
                                cRntRMaVmFFRvHQrq = rntRMaVmFFRvHQrq(str, iYBGOYYgLbclTRxAZ - 1);
                                if (!KKGSoOIeJceCgows(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU)) {
                                    iYBGOYYgLbclTRxAZ--;
                                    int iFnNhKiuLEwhnGgvW2222 = FnNhKiuLEwhnGgvW(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU);
                                    byte[] bArr42222 = this.buffer;
                                    int i72222 = this.pos;
                                    int i82222 = i72222 - 1;
                                    this.pos = i82222;
                                    bArr42222[i72222] = (byte) ((iFnNhKiuLEwhnGgvW2222 & 63) | 128);
                                    int i92222 = i72222 - 2;
                                    this.pos = i92222;
                                    bArr42222[i82222] = (byte) (((iFnNhKiuLEwhnGgvW2222 >>> 6) & 63) | 128);
                                    int i102222 = i72222 - 3;
                                    this.pos = i102222;
                                    bArr42222[i92222] = (byte) (((iFnNhKiuLEwhnGgvW2222 >>> 12) & 63) | 128);
                                    this.pos = i72222 - 4;
                                    bArr42222[i102222] = (byte) ((iFnNhKiuLEwhnGgvW2222 >>> 18) | 240);
                                }
                            }
                            throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iYBGOYYgLbclTRxAZ - 1, iYBGOYYgLbclTRxAZ);
                        }
                        tmheRIDelAoZXSbO(this, iYBGOYYgLbclTRxAZ);
                        iYBGOYYgLbclTRxAZ++;
                    }
                } else {
                    if (this.pos <= this.offset + 2) {
                        if (iYBGOYYgLbclTRxAZ == 0) {
                            cRntRMaVmFFRvHQrq = rntRMaVmFFRvHQrq(str, iYBGOYYgLbclTRxAZ - 1);
                            if (!KKGSoOIeJceCgows(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU)) {
                                iYBGOYYgLbclTRxAZ--;
                                int iFnNhKiuLEwhnGgvW22222 = FnNhKiuLEwhnGgvW(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU);
                                byte[] bArr422222 = this.buffer;
                                int i722222 = this.pos;
                                int i822222 = i722222 - 1;
                                this.pos = i822222;
                                bArr422222[i722222] = (byte) ((iFnNhKiuLEwhnGgvW22222 & 63) | 128);
                                int i922222 = i722222 - 2;
                                this.pos = i922222;
                                bArr422222[i822222] = (byte) (((iFnNhKiuLEwhnGgvW22222 >>> 6) & 63) | 128);
                                int i1022222 = i722222 - 3;
                                this.pos = i1022222;
                                bArr422222[i922222] = (byte) (((iFnNhKiuLEwhnGgvW22222 >>> 12) & 63) | 128);
                                this.pos = i722222 - 4;
                                bArr422222[i1022222] = (byte) ((iFnNhKiuLEwhnGgvW22222 >>> 18) | 240);
                            }
                        }
                        throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iYBGOYYgLbclTRxAZ - 1, iYBGOYYgLbclTRxAZ);
                    }
                    tmheRIDelAoZXSbO(this, iYBGOYYgLbclTRxAZ);
                    iYBGOYYgLbclTRxAZ++;
                }
            } else if (cNvnFWtgunUqXivwU >= 55296 || 57343 < cNvnFWtgunUqXivwU) {
                i2 = this.pos;
                if (i2 <= this.offset + 1) {
                    byte[] bArr3222 = this.buffer;
                    int i5222 = i2 - 1;
                    this.pos = i5222;
                    bArr3222[i2] = (byte) ((cNvnFWtgunUqXivwU & '?') | 128);
                    int i6222 = i2 - 2;
                    this.pos = i6222;
                    bArr3222[i5222] = (byte) (((cNvnFWtgunUqXivwU >>> 6) & 63) | 128);
                    this.pos = i2 - 3;
                    bArr3222[i6222] = (byte) ((cNvnFWtgunUqXivwU >>> '\f') | 480);
                } else {
                    if (this.pos <= this.offset + 2) {
                        if (iYBGOYYgLbclTRxAZ == 0) {
                            cRntRMaVmFFRvHQrq = rntRMaVmFFRvHQrq(str, iYBGOYYgLbclTRxAZ - 1);
                            if (!KKGSoOIeJceCgows(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU)) {
                                iYBGOYYgLbclTRxAZ--;
                                int iFnNhKiuLEwhnGgvW222222 = FnNhKiuLEwhnGgvW(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU);
                                byte[] bArr4222222 = this.buffer;
                                int i7222222 = this.pos;
                                int i8222222 = i7222222 - 1;
                                this.pos = i8222222;
                                bArr4222222[i7222222] = (byte) ((iFnNhKiuLEwhnGgvW222222 & 63) | 128);
                                int i9222222 = i7222222 - 2;
                                this.pos = i9222222;
                                bArr4222222[i8222222] = (byte) (((iFnNhKiuLEwhnGgvW222222 >>> 6) & 63) | 128);
                                int i10222222 = i7222222 - 3;
                                this.pos = i10222222;
                                bArr4222222[i9222222] = (byte) (((iFnNhKiuLEwhnGgvW222222 >>> 12) & 63) | 128);
                                this.pos = i7222222 - 4;
                                bArr4222222[i10222222] = (byte) ((iFnNhKiuLEwhnGgvW222222 >>> 18) | 240);
                            }
                        }
                        throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iYBGOYYgLbclTRxAZ - 1, iYBGOYYgLbclTRxAZ);
                    }
                    tmheRIDelAoZXSbO(this, iYBGOYYgLbclTRxAZ);
                    iYBGOYYgLbclTRxAZ++;
                }
            } else {
                if (this.pos <= this.offset + 2) {
                    if (iYBGOYYgLbclTRxAZ == 0) {
                        cRntRMaVmFFRvHQrq = rntRMaVmFFRvHQrq(str, iYBGOYYgLbclTRxAZ - 1);
                        if (!KKGSoOIeJceCgows(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU)) {
                            iYBGOYYgLbclTRxAZ--;
                            int iFnNhKiuLEwhnGgvW2222222 = FnNhKiuLEwhnGgvW(cRntRMaVmFFRvHQrq, cNvnFWtgunUqXivwU);
                            byte[] bArr42222222 = this.buffer;
                            int i72222222 = this.pos;
                            int i82222222 = i72222222 - 1;
                            this.pos = i82222222;
                            bArr42222222[i72222222] = (byte) ((iFnNhKiuLEwhnGgvW2222222 & 63) | 128);
                            int i92222222 = i72222222 - 2;
                            this.pos = i92222222;
                            bArr42222222[i82222222] = (byte) (((iFnNhKiuLEwhnGgvW2222222 >>> 6) & 63) | 128);
                            int i102222222 = i72222222 - 3;
                            this.pos = i102222222;
                            bArr42222222[i92222222] = (byte) (((iFnNhKiuLEwhnGgvW2222222 >>> 12) & 63) | 128);
                            this.pos = i72222222 - 4;
                            bArr42222222[i102222222] = (byte) ((iFnNhKiuLEwhnGgvW2222222 >>> 18) | 240);
                        }
                    }
                    throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iYBGOYYgLbclTRxAZ - 1, iYBGOYYgLbclTRxAZ);
                }
                tmheRIDelAoZXSbO(this, iYBGOYYgLbclTRxAZ);
                iYBGOYYgLbclTRxAZ++;
            }
            iYBGOYYgLbclTRxAZ--;
        }
    }

    void writeTag(int i, int i2) {
        JSZRTdSvmKcMTRbB(this, gdqsMZgyADsEzwbw(i, i2));
    }

    public override void WriteUInt32(int i, int i2) throws java.io.IOException {
        FSVNNxcmbJHLtDnU(this, 10);
        mNMDGEXCCvkNGojz(this, i2);
        WkQaSLkLFiEfzOdP(this, i, 0);
    }

    public override void WriteUInt64(int i, long j) throws java.io.IOException {
        OSaMTMIFsBsOWWno(this, 15);
        ihsYPFAbOgUcPQoh(this, j);
        izSLArKhJCxsaNbJ(this, i, 0);
    }

    void writeVarint32(int i) {
        if ((i & (-128)) == 0) {
            BiWiKHNbXRhZvgXr(this, i);
            return;
        }
        if ((i & (-16384)) == 0) {
            GmvpsLjYqjkSAesD(this, i);
            return;
        }
        if (((-2097152) & i) == 0) {
            dXjkbkrAcXkMxEKx(this, i);
        } else if (((-268435456) & i) != 0) {
            wuASrWmgwPLdbems(this, i);
        } else {
            OReGTyeblMYXlIoH(this, i);
        }
    }

    void writeVarint64(long j) {
        switch (MhpvCImfRrBJAOEE(j)) {
            case 1:
                TOIlHEjQReRdAgvM(this, j);
                break;
            case 2:
                DSXRDxeBQAfZkcjh(this, j);
                break;
            case 3:
                tkWtgNAoumJqJfSK(this, j);
                break;
            case 4:
                YAwQzXUWwynGkWOE(this, j);
                break;
            case 5:
                JcfkumtWeAPwbkHH(this, j);
                break;
            case 6:
                cJAkQDZNdNRbxUzW(this, j);
                break;
            case 7:
                rmCLImdgTyyOetdC(this, j);
                break;
            case 8:
                HpwbOEAauQSCFfyH(this, j);
                break;
            case 9:
                KJktywvElwrzjWrU(this, j);
                break;
            case 10:
                qGATaHHRQlxWLuzb(this, j);
                break;
        }
    }
}

