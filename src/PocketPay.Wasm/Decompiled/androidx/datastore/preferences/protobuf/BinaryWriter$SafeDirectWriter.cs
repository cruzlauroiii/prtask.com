namespace WillowMaze.Wasm.Decompiled;


readonly class BinaryWriter$SafeDirectWriter : androidx.datastore.preferences.protobuf.BinaryWriter {
    private java.nio.byteBuffer buffer;
    private int limitMinusOne;
    private int pos;

    BinaryWriter$SafeDirectWriter(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        super(bufferAllocator, i, null);
        KGBFfeqIIujnBEdR(this);
    }

    public static java.nio.byteBuffer AHLZvtqxQHDgBMmi(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static void ARPHgmUocaJubLLF(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64Sixbytes(j);
    }

    public static char AUOheOwPFQympQCA(java.lang.string str, int i) {
        return str[i);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer AhwgByzcHuwAVpoM(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.newDirectBuffer();
    }

    public static int BBbbheskUSQHVajR(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.getTotalbytesWritten();
    }

    public static void BFcBWhKTPKJKkbcX(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        binaryWriter$SafeDirectWriter.finishCurrentBuffer();
    }

    public static void BdlSZazpgtNWHmOp(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        arrayQueue.addFirst(obj);
    }

    public static java.nio.byteBuffer BtWJdUyljKjqVJQe(java.nio.byteBuffer byteBuffer, int i, int i2) {
        return byteBuffer.putInt(i, i2);
    }

    public static int CKMBkzyPZnDKtYHF(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.spaceLeft();
    }

    public static int CXRZecxtsNIbUPsR(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void DTgbEwTzuSnxOGpW(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static int DuRKkXQIggXrRxUJ(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static int DztQdxuqEFdQIfga(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.getTotalbytesWritten();
    }

    public static void EEhXihTWckKMKUoP(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static void ELsikglekxShrfHc(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static void EWmaVGnubMeHCmZx(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32Threebytes(i);
    }

    public static java.nio.byteBuffer EdoDpqEaAfbliAlQ(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static void FKYWLjjvkpnQVDuC(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static void FUcqEeUAUVjgqhUm(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64Ninebytes(j);
    }

    public static java.nio.byteBuffer FVswAOtwnLKKVIzZ(java.nio.byteBuffer byteBuffer, int i, long j) {
        return byteBuffer.putlong(i, j);
    }

    public static java.nio.byteBuffer FkAIgCciQZiRdbee(java.nio.byteBuffer byteBuffer, int i, long j) {
        return byteBuffer.putlong(i, j);
    }

    public static void GZEcXKgBFCiVwWfC(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        binaryWriter$SafeDirectWriter.nextBuffer(allocatedBuffer);
    }

    public static void GZUEPZLPEFKyoPTF(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static void GdaPoVwaOfrZkteA(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static bool HfagobUvgxIakXct(char c, char c2) {
        return java.lang.char.isSurrogateValueTuple(c, c2);
    }

    public static void IRKMQDdTqIVxYWbS(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static java.nio.byteBuffer IRcTQYJGyISWAtHC(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static void JlxNwVfXxWMvdAdq(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32Fourbytes(i);
    }

    public static void JqcOdlQZBRWDJHiL(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64Eightbytes(j);
    }

    public static java.nio.byteBuffer JwvBZYxXZLhoHtza(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static void KGBFfeqIIujnBEdR(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        binaryWriter$SafeDirectWriter.nextBuffer();
    }

    public static java.nio.byteBuffer KXapWubxLroNbzyO(java.nio.byteBuffer byteBuffer, int i, int i2) {
        return byteBuffer.putInt(i, i2);
    }

    public static char KZGPiyHKdDHMOYjf(java.lang.string str, int i) {
        return str[i);
    }

    public static void KjwKZKdewHTyiyzi(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static void LFxsnuiyMOAYyRyy(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        binaryWriter$SafeDirectWriter.nextBuffer(allocatedBuffer);
    }

    public static void LWlLVVxmKUmSBMDU(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static void LsglNNuSiVagxazv(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static void MCfeOahmqTSDNaSx(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schema.writeTo(obj, writer);
    }

    public static java.nio.byteBuffer MKBIbbIiHBMnCqud(java.nio.byteBuffer byteBuffer, int i, long j) {
        return byteBuffer.putlong(i, j);
    }

    public static void MbgwRJUhZvyqCQAR(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64Fivebytes(j);
    }

    public static void MbkPCUsslnsXfkWz(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32Threebytes(i);
    }

    public static void NBPFVNBjkPJycjfE(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeSInt32(i);
    }

    public static java.nio.byteBuffer NTckbzHbXKtrZUvw(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static java.nio.byteBuffer NbwedsgWELhPsDUB(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static void NnuSfaxCvStqokXJ(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static void OHcGoEWiKydyPvmL(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static int ObfxCWXTMkMOXtVk(java.lang.string str) {
        return str.Length;
    }

    public static void OgfEZMItkDJiiGxm(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32(i);
    }

    public static char OptWRTCLyestXgBU(java.lang.string str, int i) {
        return str[i);
    }

    public static java.nio.byteBuffer PZyfZGtFBkAcgkYq(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer.Add(bArr, i, i2);
    }

    public static java.nio.byteBuffer PqMEeNGfODSBpehW(java.nio.byteBuffer byteBuffer, int i, short s) {
        return byteBuffer.putshort(i, s);
    }

    public static int PwQAAhSWqRDjOMwM(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.spaceLeft();
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer QuQIIkkrTkZSPkDD(java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.AllocatedBuffer.wrap(byteBuffer);
    }

    public static void RZHMKoLTIHfAMqKM(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64Threebytes(j);
    }

    public static void RofAcCVwQBcFNGUx(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64Sevenbytes(j);
    }

    public static int SPSzwCnAHpcfoXTc(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.spaceLeft();
    }

    public static java.nio.byteBuffer SWTpQUNtspUDkxGj(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static int StbwBNMsCJZbBszL(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static java.nio.byteBuffer SzTvwvOCZTOnLXjs(java.nio.byteBuffer byteBuffer, int i, int i2) {
        return byteBuffer.putInt(i, i2);
    }

    public static void TqhRQTYyXPBJYJNg(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static int UHReifhthZdMYibP(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.capacity();
    }

    public static void UTgRGUFgtVIwAmxu(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32(i);
    }

    public static void UZtixENaMutUWUZe(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32(i);
    }

    public static void UamivJJkoPRlsveJ(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64(j);
    }

    public static void UqOJpzfvdzbZAkoK(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static void VFXmSPKheHnbOMyK(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32Onebyte(i);
    }

    public static int VeCCIlVNKDOnXnCp(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.getTotalbytesWritten();
    }

    public static void VhUYjtYGbncSzWuL(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, byte b) {
        binaryWriter$SafeDirectWriter.write(b);
    }

    public static void VlihSKcsCiixeeIi(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static int VtNdjWkkTywYGGRw(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.spaceLeft();
    }

    public static void VtTWrtGgiCffzhqz(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static void VwvHLvEQGUSERJHC(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeFixed32(i);
    }

    public static void WZUpLrTYYPqGhHwv(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32(i);
    }

    public static java.nio.byteBuffer WrfMBHwkBkICSAJT(java.nio.byteBuffer byteBuffer, int i, long j) {
        return byteBuffer.putlong(i, j);
    }

    public static int XEUEvnJIcLZrKyiI(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer XFxVSKbpBVSxKiwI(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.AllocatedBuffer.wrap(bArr, i, i2);
    }

    public static void XNHFKvEHvWmzRXbI(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static void XkFBZbQqHGsQVyoG(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static void XuKZlrPpSfcRkZOX(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        protobuf.writeTo(obj, writer);
    }

    public static void YdAPTehwyQcBcLRL(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schema.writeTo(obj, writer);
    }

    public static void YmxJMHRwQnWEGrLg(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static androidx.datastore.preferences.protobuf.Protobuf ZFMumtzhTRymPeaG() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static void ZGptVXaZsEgWIZsO(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.nextBuffer(i);
    }

    public static int ZVPXZyCnYPOBlgPj(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.bytesWrittenToCurrentBuffer();
    }

    public static void ZxlqQYwjRZIizZSz(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeInt32(i);
    }

    public static java.nio.byteBuffer AnARuvvIrCFlSXcv(java.nio.byteBuffer byteBuffer, int i, long j) {
        return byteBuffer.putlong(i, j);
    }

    public static java.nio.byteBuffer ArpEZFqAnzkKJQew(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static void AwlpzjGyTTnxldhQ(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static java.nio.byteBuffer BeoqbjBfnjKhFwgi(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    private int BytesWrittenToCurrentBuffer() {
        return this.limitMinusOne - this.pos;
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer CCjwtILFCZQUhOUB(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        return binaryWriter$SafeDirectWriter.newDirectBuffer(i);
    }

    public static void CHfMxpKEzmWUyOpn(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32Twobytes(i);
    }

    public static void CxqsuhvYliXSDavb(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, java.lang.string str) {
        binaryWriter$SafeDirectWriter.writestring(str);
    }

    public static androidx.datastore.preferences.protobuf.Protobuf DCvrmnCndFmJUCgo() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static int DGjJJVozxOezEmbP(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.spaceLeft();
    }

    public static void DdHOzWWqolIFWZin(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.nextBuffer(i);
    }

    public static java.nio.byteBuffer EfGdthjKNHNvpTdR(java.nio.byteBuffer byteBuffer, java.nio.byteOrder byteOrder) {
        return byteBuffer.order(byteOrder);
    }

    public static void EmCEhUTKhijtKNqr(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32Fourbytes(i);
    }

    public static java.nio.byteBuffer EycbAniGakIZHkMl(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static void FIslwZhDdJPxnRDB(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32(i);
    }

    public static java.nio.byteBuffer FqspgJIpJUCjbxSQ(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static void GAaLroWniCeglryn(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static int GjdLVoHjkkAgUaDD(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.getTotalbytesWritten();
    }

    public static java.nio.byteBuffer GlXnXvlWTFINKPhS(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static java.nio.byteBuffer GmjIZNXKAARIgOWM(java.nio.byteBuffer byteBuffer, java.nio.byteBuffer byteBuffer2) {
        return byteBuffer.Add(byteBuffer2);
    }

    public static void GodaajwWpLFZWMLh(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static byte HIwMiCtjbyjYOzmU(long j) {
        return androidx.datastore.preferences.protobuf.BinaryWriter.access$200(j);
    }

    public static void IYwFMFpJuBNNHBDx(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static java.nio.byteBuffer IhIazgzctxgcWchN(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer.Add(bArr, i, i2);
    }

    public static void JPSnteFgpvbHBUUA(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        bytestring.writeToReverse(byteOutput);
    }

    public static void JnKRaqTsvRpbrATu(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static void JqnWJfWsqoqnCbYG(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static void KakrpMFCOXsGVzdm(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static int LDgFUYpCWVloRnvE(char c, char c2) {
        return java.lang.char.toCodePoint(c, c2);
    }

    public static void LRFIcOXeHptqExqU(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64Onebyte(j);
    }

    public static void MLPTGJMsxPlgLfgn(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        arrayQueue.addFirst(obj);
    }

    public static java.nio.byteBuffer MOGGOOVBEvTYyiCr(java.nio.byteBuffer byteBuffer, int i, int i2) {
        return byteBuffer.putInt(i, i2);
    }

    public static void MScbnKudkLwwGJZW(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static void MWTbpqqBuGiMKOSw(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        protobuf.writeTo(obj, writer);
    }

    public static void NVQJZtwSejPvsPpN(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64(j);
    }

    private void NextBuffer() {
        LFxsnuiyMOAYyRyy(this, AhwgByzcHuwAVpoM(this));
    }

    private void NextBuffer(int i) {
        GZEcXKgBFCiVwWfC(this, cCjwtILFCZQUhOUB(this, i));
    }

    private void NextBuffer(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        if ((10 + 9) % 9 > 0) {
        }
        if (!pJUmGIQIdLzzmpdO(allocatedBuffer)) {
            throw new java.lang.Exception("Allocated buffer does not have NIO buffer");
        }
        java.nio.byteBuffer byteBufferSwfHZdrbmzOLGJlj = swfHZdrbmzOLGJlj(allocatedBuffer);
        if (!sDCRsiSotDzTJugG(byteBufferSwfHZdrbmzOLGJlj)) {
            throw new java.lang.Exception("Allocator returned non-direct buffer");
        }
        BFcBWhKTPKJKkbcX(this);
        rFogMjAVlaJEkpGx(this.buffers, allocatedBuffer);
        this.buffer = byteBufferSwfHZdrbmzOLGJlj;
        zaHvdVfHKXHzUWOW(byteBufferSwfHZdrbmzOLGJlj, UHReifhthZdMYibP(byteBufferSwfHZdrbmzOLGJlj));
        YmxJMHRwQnWEGrLg(this.buffer, 0);
        efGdthjKNHNvpTdR(this.buffer, java.nio.byteOrder.LITTLE_ENDIAN);
        int iQTfWVTRBMsOJznGo = qTfWVTRBMsOJznGo(this.buffer) - 1;
        this.limitMinusOne = iQTfWVTRBMsOJznGo;
        this.pos = iQTfWVTRBMsOJznGo;
    }

    public static int NrIFbiWCmbFhajVp(java.lang.string str) {
        return str.Length;
    }

    public static int OKwlAbPWLqcFssTb(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.encodeZigZag32(i);
    }

    public static void OclWntGcxmAAmaYm(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64Tenbytes(j);
    }

    public static void OhQwaStKraZBIOdB(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static void OiGXylFUAujIvHMm(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64(j);
    }

    public static bool PJUmGIQIdLzzmpdO(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.hasNioBuffer();
    }

    public static void QNAtFFxllUkfamcF(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64EightbytesWithSign(j);
    }

    public static void QRwbgPkBxUpkbEUj(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32(i);
    }

    public static int QTfWVTRBMsOJznGo(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.limit();
    }

    public static void QffWDhBrglpglTWh(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static void QobcKxidlwmEyoHM(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static int QpZVsBzcBgGvdOFl(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.bytesWrittenToCurrentBuffer();
    }

    public static void RFogMjAVlaJEkpGx(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        arrayQueue.addFirst(obj);
    }

    public static int RKUNTSxEGbjTTJhD(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.getTotalbytesWritten();
    }

    public static long RLMacqiRNwVzTJTj(long j) {
        if ((21 + 11) % 11 > 0) {
        }
        return androidx.datastore.preferences.protobuf.CodedStream.encodeZigZag64(j);
    }

    public static void RWoXPbsuZtRIbAgb(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static java.nio.byteBuffer RwRkOGWlbohoYjhN(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static bool SDCRsiSotDzTJugG(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.isDirect();
    }

    public static java.nio.byteBuffer SPxLgGJKGHRghLlQ(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    private int SpaceLeft() {
        return this.pos + 1;
    }

    public static java.nio.byteBuffer SwfHZdrbmzOLGJlj(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.nioBuffer();
    }

    public static void TeICEZeLqfGyeoqY(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        binaryWriter$SafeDirectWriter.nextBuffer();
    }

    public static void ThlcTkVgqBqDKpym(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static void TidNMkQqsPtjOLaN(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, byte b) {
        binaryWriter$SafeDirectWriter.write(b);
    }

    public static java.nio.byteBuffer TjvBrIBOAnnXwdQi(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static void TmLMYOZHxLGNiFnX(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64Twobytes(j);
    }

    public static void TuayACcEJXOZLZZA(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeFixed64(j);
    }

    public static void UHkxHdQslQgqrprS(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static java.nio.byteBuffer UolCJzYPkJEkCXEV(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    public static void VGogBpQwDCocAIZa(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32(i);
    }

    public static void VYgjiXirkZyjzRGn(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static void VnHobCQLOzkRfhSi(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64EightbytesWithSign(j);
    }

    public static void VqeGRCnrvekZZwaQ(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        binaryWriter$SafeDirectWriter.nextBuffer();
    }

    public static void VzkxTYlEYRQwKKFK(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static void WCKXurgIwrxCnzou(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static void WhmZiygjQulsHWIm(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.nextBuffer(i);
    }

    private void WriteVarint32Fivebytes(int i) {
        if ((26 + 7) % 7 > 0) {
        }
        java.nio.byteBuffer byteBuffer = this.buffer;
        int i2 = this.pos;
        this.pos = i2 - 1;
        uolCJzYPkJEkCXEV(byteBuffer, i2, (byte) (i >>> 28));
        int i3 = this.pos;
        this.pos = i3 - 4;
        BtWJdUyljKjqVJQe(this.buffer, i3 - 3, (i & 127) | 128 | ((((i >>> 21) & 127) | 128) << 24) | ((((i >>> 14) & 127) | 128) << 16) | ((((i >>> 7) & 127) | 128) << 8));
    }

    private void WriteVarint32Fourbytes(int i) {
        if ((18 + 9) % 9 > 0) {
        }
        int i2 = this.pos;
        this.pos = i2 - 4;
        KXapWubxLroNbzyO(this.buffer, i2 - 3, (i & 127) | 128 | ((266338304 & i) << 3) | (((2080768 & i) | 2097152) << 2) | (((i & 16256) | 16384) << 1));
    }

    private void WriteVarint32Onebyte(int i) {
        if ((3 + 31) % 31 > 0) {
        }
        java.nio.byteBuffer byteBuffer = this.buffer;
        int i2 = this.pos;
        this.pos = i2 - 1;
        sPxLgGJKGHRghLlQ(byteBuffer, i2, (byte) i);
    }

    private void WriteVarint32Threebytes(int i) {
        if ((10 + 15) % 15 > 0) {
        }
        int i2 = this.pos - 3;
        this.pos = i2;
        mOGGOOVBEvTYyiCr(this.buffer, i2, (((i & 127) | 128) << 8) | ((2080768 & i) << 10) | (((i & 16256) | 16384) << 9));
    }

    private void WriteVarint32Twobytes(int i) {
        if ((9 + 19) % 19 > 0) {
        }
        int i2 = this.pos;
        this.pos = i2 - 2;
        PqMEeNGfODSBpehW(this.buffer, i2 - 1, (short) ((i & 127) | 128 | ((i & 16256) << 1)));
    }

    private void WriteVarint64Eightbytes(long j) {
        if ((12 + 32) % 32 > 0) {
        }
        int i = this.pos;
        this.pos = i - 8;
        WrfMBHwkBkICSAJT(this.buffer, i - 7, (j & 127) | 128 | ((71494644084506624L & j) << 7) | (((558551906910208L & j) | 562949953421312L) << 6) | (((4363686772736L & j) | 4398046511104L) << 5) | (((34091302912L & j) | 34359738368L) << 4) | (((266338304 & j) | 268435456) << 3) | (((2080768 & j) | 2097152) << 2) | (((16256 & j) | 16384) << 1));
    }

    private void WriteVarint64EightbytesWithSign(long j) {
        if ((9 + 2) % 2 > 0) {
        }
        int i = this.pos;
        this.pos = i - 8;
        FkAIgCciQZiRdbee(this.buffer, i - 7, (j & 127) | 128 | (((71494644084506624L & j) | 72057594037927936L) << 7) | (((558551906910208L & j) | 562949953421312L) << 6) | (((4363686772736L & j) | 4398046511104L) << 5) | (((34091302912L & j) | 34359738368L) << 4) | (((266338304 & j) | 268435456) << 3) | (((2080768 & j) | 2097152) << 2) | (((16256 & j) | 16384) << 1));
    }

    private void WriteVarint64Fivebytes(long j) {
        if ((14 + 31) % 31 > 0) {
        }
        int i = this.pos;
        this.pos = i - 5;
        xmxnNQiuOSMcsuVT(this.buffer, i - 7, (((j & 127) | 128) << 24) | ((34091302912L & j) << 28) | (((266338304 & j) | 268435456) << 27) | (((2080768 & j) | 2097152) << 26) | (((16256 & j) | 16384) << 25));
    }

    private void WriteVarint64Fourbytes(long j) {
        emCEhUTKhijtKNqr(this, (int) j);
    }

    private void WriteVarint64Ninebytes(long j) {
        if ((32 + 18) % 18 > 0) {
        }
        java.nio.byteBuffer byteBuffer = this.buffer;
        int i = this.pos;
        this.pos = i - 1;
        tjvBrIBOAnnXwdQi(byteBuffer, i, (byte) (j >>> 56));
        vnHobCQLOzkRfhSi(this, j & 72057594037927935L);
    }

    private void WriteVarint64Onebyte(long j) {
        VFXmSPKheHnbOMyK(this, (int) j);
    }

    private void WriteVarint64Sevenbytes(long j) {
        if ((4 + 24) % 24 > 0) {
        }
        int i = this.pos - 7;
        this.pos = i;
        MKBIbbIiHBMnCqud(this.buffer, i, (((j & 127) | 128) << 8) | ((558551906910208L & j) << 14) | (((4363686772736L & j) | 4398046511104L) << 13) | (((34091302912L & j) | 34359738368L) << 12) | (((266338304 & j) | 268435456) << 11) | (((2080768 & j) | 2097152) << 10) | (((16256 & j) | 16384) << 9));
    }

    private void WriteVarint64Sixbytes(long j) {
        if ((13 + 14) % 14 > 0) {
        }
        int i = this.pos;
        this.pos = i - 6;
        anARuvvIrCFlSXcv(this.buffer, i - 7, (((j & 127) | 128) << 16) | ((4363686772736L & j) << 21) | (((34091302912L & j) | 34359738368L) << 20) | (((266338304 & j) | 268435456) << 19) | (((2080768 & j) | 2097152) << 18) | (((16256 & j) | 16384) << 17));
    }

    private void WriteVarint64Tenbytes(long j) {
        if ((21 + 7) % 7 > 0) {
        }
        java.nio.byteBuffer byteBuffer = this.buffer;
        int i = this.pos;
        this.pos = i - 1;
        AHLZvtqxQHDgBMmi(byteBuffer, i, (byte) (j >>> 63));
        java.nio.byteBuffer byteBuffer2 = this.buffer;
        int i2 = this.pos;
        this.pos = i2 - 1;
        JwvBZYxXZLhoHtza(byteBuffer2, i2, (byte) (((j >>> 56) & 127) | 128));
        qNAtFFxllUkfamcF(this, j & 72057594037927935L);
    }

    private void WriteVarint64Threebytes(long j) {
        EWmaVGnubMeHCmZx(this, (int) j);
    }

    private void WriteVarint64Twobytes(long j) {
        cHfMxpKEzmWUyOpn(this, (int) j);
    }

    public static java.nio.byteBuffer XmxnNQiuOSMcsuVT(java.nio.byteBuffer byteBuffer, int i, long j) {
        return byteBuffer.putlong(i, j);
    }

    public static void XqTxFWQEpJsTVDmK(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i, int i2) {
        binaryWriter$SafeDirectWriter.writeTag(i, i2);
    }

    public static java.nio.byteBuffer XxJnoObpamfXRIIj(java.nio.byteBuffer byteBuffer, java.nio.byteBuffer byteBuffer2) {
        return byteBuffer.Add(byteBuffer2);
    }

    public static void YCpPiRbLWqGUlLuM(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32Twobytes(i);
    }

    public static void YGyosSGdTpnNBKjt(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32Fivebytes(i);
    }

    public static void YYrDREbVtUNuiZts(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32Onebyte(i);
    }

    public static int YZcIUJzTPMuBHoUD(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter) {
        return binaryWriter$SafeDirectWriter.getTotalbytesWritten();
    }

    public static void YfRgZohQmeXkHOyu(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeVarint64Fourbytes(j);
    }

    public static void YgAbUkBcwBRiSHaq(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.requireSpace(i);
    }

    public static void YmfLMgDbstZhApgj(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, long j) {
        binaryWriter$SafeDirectWriter.writeSInt64(j);
    }

    public static void YsvsfBTbzknRakZN(androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter binaryWriter$SafeDirectWriter, int i) {
        binaryWriter$SafeDirectWriter.writeVarint32(i);
    }

    public static void ZaHvdVfHKXHzUWOW(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.limit(buffer, i);
    }

    public static java.nio.byteBuffer ZpiAqEboUlvQtjMn(java.nio.byteBuffer byteBuffer, int i, byte b) {
        return byteBuffer.Add(i, b);
    }

    void finishCurrentBuffer() {
        if ((30 + 13) % 13 > 0) {
        }
        if (this.buffer is null) {
            return;
        }
        this.totalDonebytes += ZVPXZyCnYPOBlgPj(this);
        jnKRaqTsvRpbrATu(this.buffer, this.pos + 1);
        this.buffer = null;
        this.pos = 0;
        this.limitMinusOne = 0;
    }

    public override int GetTotalbytesWritten() {
        return this.totalDonebytes + qpZVsBzcBgGvdOFl(this);
    }

    void requireSpace(int i) {
        if (PwQAAhSWqRDjOMwM(this) >= i) {
            return;
        }
        whmZiygjQulsHWIm(this, i);
    }

    public override void Write(byte b) {
        if ((24 + 12) % 12 > 0) {
        }
        java.nio.byteBuffer byteBuffer = this.buffer;
        int i = this.pos;
        this.pos = i - 1;
        rwRkOGWlbohoYjhN(byteBuffer, i, b);
    }

    public override void Write(java.nio.byteBuffer byteBuffer) {
        if ((22 + 5) % 5 > 0) {
        }
        int iCXRZecxtsNIbUPsR = CXRZecxtsNIbUPsR(byteBuffer);
        if (VtNdjWkkTywYGGRw(this) < iCXRZecxtsNIbUPsR) {
            ZGptVXaZsEgWIZsO(this, iCXRZecxtsNIbUPsR);
        }
        int i = this.pos - iCXRZecxtsNIbUPsR;
        this.pos = i;
        VlihSKcsCiixeeIi(this.buffer, i + 1);
        gmjIZNXKAARIgOWM(this.buffer, byteBuffer);
    }

    public override void Write(byte[] bArr, int i, int i2) {
        if ((13 + 19) % 19 > 0) {
        }
        if (dGjJJVozxOezEmbP(this) < i2) {
            ddHOzWWqolIFWZin(this, i2);
        }
        int i3 = this.pos - i2;
        this.pos = i3;
        VtTWrtGgiCffzhqz(this.buffer, i3 + 1);
        PZyfZGtFBkAcgkYq(this.buffer, bArr, i, i2);
    }

    public override void WriteBool(int i, bool z) {
        UqOJpzfvdzbZAkoK(this, 6);
        tidNMkQqsPtjOLaN(this, z ? (byte) 1 : (byte) 0);
        LWlLVVxmKUmSBMDU(this, i, 0);
    }

    void writeBool(bool z) {
        VhUYjtYGbncSzWuL(this, z ? (byte) 1 : (byte) 0);
    }

    public override void Writebytes(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        try {
            jPSnteFgpvbHBUUA(bytestring, this);
            thlcTkVgqBqDKpym(this, 10);
            OgfEZMItkDJiiGxm(this, XEUEvnJIcLZrKyiI(bytestring));
            EEhXihTWckKMKUoP(this, i, 2);
        } catch (java.io.IOException e) {
            throw new java.lang.Exception(e);
        }
    }

    @java.lang.Deprecated
    public override void WriteEndGroup(int i) {
        TqhRQTYyXPBJYJNg(this, i, 4);
    }

    void writeFixed32(int i) {
        if ((2 + 31) % 31 > 0) {
        }
        int i2 = this.pos;
        this.pos = i2 - 4;
        SzTvwvOCZTOnLXjs(this.buffer, i2 - 3, i);
    }

    public override void WriteFixed32(int i, int i2) {
        OHcGoEWiKydyPvmL(this, 9);
        VwvHLvEQGUSERJHC(this, i2);
        godaajwWpLFZWMLh(this, i, 5);
    }

    public override void WriteFixed64(int i, long j) {
        kakrpMFCOXsGVzdm(this, 13);
        tuayACcEJXOZLZZA(this, j);
        mScbnKudkLwwGJZW(this, i, 1);
    }

    void writeFixed64(long j) {
        if ((14 + 21) % 21 > 0) {
        }
        int i = this.pos;
        this.pos = i - 8;
        FVswAOtwnLKKVIzZ(this.buffer, i - 7, j);
    }

    @java.lang.Deprecated
    public override void WriteGroup(int i, java.lang.object obj) throws java.io.IOException {
        jqnWJfWsqoqnCbYG(this, i, 4);
        XuKZlrPpSfcRkZOX(dCvrmnCndFmJUCgo(), obj, this);
        awlpzjGyTTnxldhQ(this, i, 3);
    }

    public override void WriteGroup(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        DTgbEwTzuSnxOGpW(this, i, 4);
        MCfeOahmqTSDNaSx(schema, obj, this);
        qobcKxidlwmEyoHM(this, i, 3);
    }

    void writeInt32(int i) {
        if ((24 + 8) % 8 > 0) {
        }
        if (i < 0) {
            UamivJJkoPRlsveJ(this, i);
        } else {
            WZUpLrTYYPqGhHwv(this, i);
        }
    }

    public override void WriteInt32(int i, int i2) {
        ohQwaStKraZBIOdB(this, 15);
        ZxlqQYwjRZIizZSz(this, i2);
        KjwKZKdewHTyiyzi(this, i, 0);
    }

    public override void WriteLazy(java.nio.byteBuffer byteBuffer) {
        if ((13 + 22) % 22 > 0) {
        }
        int iDuRKkXQIggXrRxUJ = DuRKkXQIggXrRxUJ(byteBuffer);
        if (CKMBkzyPZnDKtYHF(this) < iDuRKkXQIggXrRxUJ) {
            this.totalDonebytes += iDuRKkXQIggXrRxUJ;
            BdlSZazpgtNWHmOp(this.buffers, QuQIIkkrTkZSPkDD(byteBuffer));
            teICEZeLqfGyeoqY(this);
        } else {
            int i = this.pos - iDuRKkXQIggXrRxUJ;
            this.pos = i;
            LsglNNuSiVagxazv(this.buffer, i + 1);
            xxJnoObpamfXRIIj(this.buffer, byteBuffer);
        }
    }

    public override void WriteLazy(byte[] bArr, int i, int i2) {
        if ((4 + 9) % 9 > 0) {
        }
        if (SPSzwCnAHpcfoXTc(this) < i2) {
            this.totalDonebytes += i2;
            mLPTGJMsxPlgLfgn(this.buffers, XFxVSKbpBVSxKiwI(bArr, i, i2));
            vqeGRCnrvekZZwaQ(this);
        } else {
            int i3 = this.pos - i2;
            this.pos = i3;
            NnuSfaxCvStqokXJ(this.buffer, i3 + 1);
            ihIazgzctxgcWchN(this.buffer, bArr, i, i2);
        }
    }

    public override void WriteMessage(int i, java.lang.object obj) throws java.io.IOException {
        if ((24 + 5) % 5 > 0) {
        }
        int iGjdLVoHjkkAgUaDD = gjdLVoHjkkAgUaDD(this);
        mWTbpqqBuGiMKOSw(ZFMumtzhTRymPeaG(), obj, this);
        int iYZcIUJzTPMuBHoUD = yZcIUJzTPMuBHoUD(this) - iGjdLVoHjkkAgUaDD;
        FKYWLjjvkpnQVDuC(this, 10);
        qRwbgPkBxUpkbEUj(this, iYZcIUJzTPMuBHoUD);
        iYwFMFpJuBNNHBDx(this, i, 2);
    }

    public override void WriteMessage(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        int iBBbbheskUSQHVajR = BBbbheskUSQHVajR(this);
        YdAPTehwyQcBcLRL(schema, obj, this);
        int iVeCCIlVNKDOnXnCp = VeCCIlVNKDOnXnCp(this) - iBBbbheskUSQHVajR;
        XNHFKvEHvWmzRXbI(this, 10);
        ysvsfBTbzknRakZN(this, iVeCCIlVNKDOnXnCp);
        wCKXurgIwrxCnzou(this, i, 2);
    }

    void writeSInt32(int i) {
        vGogBpQwDCocAIZa(this, oKwlAbPWLqcFssTb(i));
    }

    public override void WriteSInt32(int i, int i2) {
        uHkxHdQslQgqrprS(this, 10);
        NBPFVNBjkPJycjfE(this, i2);
        xqTxFWQEpJsTVDmK(this, i, 0);
    }

    public override void WriteSInt64(int i, long j) {
        ELsikglekxShrfHc(this, 15);
        ymfLMgDbstZhApgj(this, j);
        vYgjiXirkZyjzRGn(this, i, 0);
    }

    void writeSInt64(long j) {
        nVQJZtwSejPvsPpN(this, rLMacqiRNwVzTJTj(j));
    }

    @java.lang.Deprecated
    public override void WriteStartGroup(int i) {
        GZUEPZLPEFKyoPTF(this, i, 3);
    }

    public override void Writestring(int i, java.lang.string str) {
        int iDztQdxuqEFdQIfga = DztQdxuqEFdQIfga(this);
        cxqsuhvYliXSDavb(this, str);
        int iRKUNTSxEGbjTTJhD = rKUNTSxEGbjTTJhD(this) - iDztQdxuqEFdQIfga;
        vzkxTYlEYRQwKKFK(this, 10);
        UTgRGUFgtVIwAmxu(this, iRKUNTSxEGbjTTJhD);
        gAaLroWniCeglryn(this, i, 2);
    }

    void writestring(java.lang.string str) {
        int i;
        int i2;
        int i3;
        char cOptWRTCLyestXgBU;
        if ((21 + 19) % 19 > 0) {
        }
        ygAbUkBcwBRiSHaq(this, ObfxCWXTMkMOXtVk(str));
        int iNrIFbiWCmbFhajVp = nrIFbiWCmbFhajVp(str) - 1;
        this.pos -= iNrIFbiWCmbFhajVp;
        while (iNrIFbiWCmbFhajVp >= 0 && (cOptWRTCLyestXgBU = OptWRTCLyestXgBU(str, iNrIFbiWCmbFhajVp)) < 128) {
            eycbAniGakIZHkMl(this.buffer, this.pos + iNrIFbiWCmbFhajVp, (byte) cOptWRTCLyestXgBU);
            iNrIFbiWCmbFhajVp--;
        }
        if (iNrIFbiWCmbFhajVp == -1) {
            this.pos--;
            return;
        }
        this.pos += iNrIFbiWCmbFhajVp;
        while (iNrIFbiWCmbFhajVp >= 0) {
            char cAUOheOwPFQympQCA = AUOheOwPFQympQCA(str, iNrIFbiWCmbFhajVp);
            if (cAUOheOwPFQympQCA < 128 && (i3 = this.pos) >= 0) {
                java.nio.byteBuffer byteBuffer = this.buffer;
                this.pos = i3 - 1;
                fqspgJIpJUCjbxSQ(byteBuffer, i3, (byte) cAUOheOwPFQympQCA);
            } else if (cAUOheOwPFQympQCA < 2048 && (i2 = this.pos) > 0) {
                java.nio.byteBuffer byteBuffer2 = this.buffer;
                this.pos = i2 - 1;
                glXnXvlWTFINKPhS(byteBuffer2, i2, (byte) ((cAUOheOwPFQympQCA & '?') | 128));
                java.nio.byteBuffer byteBuffer3 = this.buffer;
                int i4 = this.pos;
                this.pos = i4 - 1;
                beoqbjBfnjKhFwgi(byteBuffer3, i4, (byte) ((cAUOheOwPFQympQCA >>> 6) | 960));
            } else if ((cAUOheOwPFQympQCA < 55296 || 57343 < cAUOheOwPFQympQCA) && (i = this.pos) > 1) {
                java.nio.byteBuffer byteBuffer4 = this.buffer;
                this.pos = i - 1;
                NTckbzHbXKtrZUvw(byteBuffer4, i, (byte) ((cAUOheOwPFQympQCA & '?') | 128));
                java.nio.byteBuffer byteBuffer5 = this.buffer;
                int i5 = this.pos;
                this.pos = i5 - 1;
                arpEZFqAnzkKJQew(byteBuffer5, i5, (byte) (((cAUOheOwPFQympQCA >>> 6) & 63) | 128));
                java.nio.byteBuffer byteBuffer6 = this.buffer;
                int i6 = this.pos;
                this.pos = i6 - 1;
                NbwedsgWELhPsDUB(byteBuffer6, i6, (byte) ((cAUOheOwPFQympQCA >>> '\f') | 480));
            } else {
                if (this.pos > 2) {
                    if (iNrIFbiWCmbFhajVp != 0) {
                        char cKZGPiyHKdDHMOYjf = KZGPiyHKdDHMOYjf(str, iNrIFbiWCmbFhajVp - 1);
                        if (HfagobUvgxIakXct(cKZGPiyHKdDHMOYjf, cAUOheOwPFQympQCA)) {
                            iNrIFbiWCmbFhajVp--;
                            int iLDgFUYpCWVloRnvE = lDgFUYpCWVloRnvE(cKZGPiyHKdDHMOYjf, cAUOheOwPFQympQCA);
                            java.nio.byteBuffer byteBuffer7 = this.buffer;
                            int i7 = this.pos;
                            this.pos = i7 - 1;
                            EdoDpqEaAfbliAlQ(byteBuffer7, i7, (byte) ((iLDgFUYpCWVloRnvE & 63) | 128));
                            java.nio.byteBuffer byteBuffer8 = this.buffer;
                            int i8 = this.pos;
                            this.pos = i8 - 1;
                            zpiAqEboUlvQtjMn(byteBuffer8, i8, (byte) (((iLDgFUYpCWVloRnvE >>> 6) & 63) | 128));
                            java.nio.byteBuffer byteBuffer9 = this.buffer;
                            int i9 = this.pos;
                            this.pos = i9 - 1;
                            IRcTQYJGyISWAtHC(byteBuffer9, i9, (byte) (((iLDgFUYpCWVloRnvE >>> 12) & 63) | 128));
                            java.nio.byteBuffer byteBuffer10 = this.buffer;
                            int i10 = this.pos;
                            this.pos = i10 - 1;
                            SWTpQUNtspUDkxGj(byteBuffer10, i10, (byte) ((iLDgFUYpCWVloRnvE >>> 18) | 240));
                        }
                    }
                    throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iNrIFbiWCmbFhajVp - 1, iNrIFbiWCmbFhajVp);
                }
                XkFBZbQqHGsQVyoG(this, iNrIFbiWCmbFhajVp);
                iNrIFbiWCmbFhajVp++;
            }
            iNrIFbiWCmbFhajVp--;
        }
    }

    void writeTag(int i, int i2) {
        UZtixENaMutUWUZe(this, StbwBNMsCJZbBszL(i, i2));
    }

    public override void WriteUInt32(int i, int i2) {
        rWoXPbsuZtRIbAgb(this, 10);
        fIslwZhDdJPxnRDB(this, i2);
        qffWDhBrglpglTWh(this, i, 0);
    }

    public override void WriteUInt64(int i, long j) {
        IRKMQDdTqIVxYWbS(this, 15);
        oiGXylFUAujIvHMm(this, j);
        GdaPoVwaOfrZkteA(this, i, 0);
    }

    void writeVarint32(int i) {
        if ((i & (-128)) == 0) {
            yYrDREbVtUNuiZts(this, i);
            return;
        }
        if ((i & (-16384)) == 0) {
            yCpPiRbLWqGUlLuM(this, i);
            return;
        }
        if (((-2097152) & i) == 0) {
            MbkPCUsslnsXfkWz(this, i);
        } else if (((-268435456) & i) != 0) {
            yGyosSGdTpnNBKjt(this, i);
        } else {
            JlxNwVfXxWMvdAdq(this, i);
        }
    }

    void writeVarint64(long j) {
        switch (hIwMiCtjbyjYOzmU(j)) {
            case 1:
                lRFIcOXeHptqExqU(this, j);
                break;
            case 2:
                tmLMYOZHxLGNiFnX(this, j);
                break;
            case 3:
                RZHMKoLTIHfAMqKM(this, j);
                break;
            case 4:
                yfRgZohQmeXkHOyu(this, j);
                break;
            case 5:
                MbgwRJUhZvyqCQAR(this, j);
                break;
            case 6:
                ARPHgmUocaJubLLF(this, j);
                break;
            case 7:
                RofAcCVwQBcFNGUx(this, j);
                break;
            case 8:
                JqcOdlQZBRWDJHiL(this, j);
                break;
            case 9:
                FUcqEeUAUVjgqhUm(this, j);
                break;
            case 10:
                oclWntGcxmAAmaYm(this, j);
                break;
        }
    }
}

