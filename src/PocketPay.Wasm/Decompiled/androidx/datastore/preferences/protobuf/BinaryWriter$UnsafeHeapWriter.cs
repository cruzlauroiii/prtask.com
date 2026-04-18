namespace WillowMaze.Wasm.Decompiled;


readonly class BinaryWriter$UnsafeHeapWriter : androidx.datastore.preferences.protobuf.BinaryWriter {
    private androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer;
    private byte[] buffer;
    private long limit;
    private long limitMinusOne;
    private long offset;
    private long offsetMinusOne;
    private long pos;

    BinaryWriter$UnsafeHeapWriter(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        super(bufferAllocator, i, null);
        IdFFSdVUxJJAISkC(this);
    }

    public static java.lang.int ATEUrWVKyzcFJEnl(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int ApnbTYKOYVkEsiSw(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.bytesWrittenToCurrentBuffer();
    }

    public static void BekFkvyxQJhWLthc(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void CBfLTshfDfiBLXEb(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void CXWcQbbiVdHVACCu(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeVarint64Sevenbytes(j);
    }

    public static void CuCkBwCQUinkHvro(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void DRcAcvCJABAAYAwT(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schema.writeTo(obj, writer);
    }

    public static int DXSnAjJmYTZmYVpB(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.bytesWrittenToCurrentBuffer();
    }

    public static bool DqRfFrJdKqieLAHd(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.hasArray();
    }

    public static void EJCrLSqBBIUILncE(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void ENsNjTfKmJDCAcFw(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeVarint32(i);
    }

    public static void ETOheJPnzhhtwtkM(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void EUOLxHbqFwhBuFqp(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void EisbyTcsoTifcxKi(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeVarint32(i);
    }

    public static void EtymegFWmYSFtbZZ(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void FCfsZjofAMnGbpJF(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        binaryWriter$UnsafeHeapWriter.nextBuffer();
    }

    public static void FItlrijCkEbUfFoo(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static int FpXzFqoYNBUobbZa(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.arrayPos();
    }

    public static void GNhfhfMovcyJNmvK(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void GcKVjEVefwWbFMSw(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeVarint64Fourbytes(j);
    }

    public static void GvkpuBaGxewbPaFu(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void HCRHnYOhkqpMDBtd(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static char HHxOGMyLouwjFJBQ(java.lang.string str, int i) {
        return str[i);
    }

    public static void IPmMDrMyzGowdbTD(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void IcvgeiDtxWzbmJfd(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void IdFFSdVUxJJAISkC(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        binaryWriter$UnsafeHeapWriter.nextBuffer();
    }

    public static void IiyZkgvHpSpuaQrE(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void ImquWkqasGBRSiWq(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeVarint32Onebyte(i);
    }

    public static void JJvTRRjyRFHEffFn(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void JbRWGShQNRDzbgnd(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void JhEsSVcrxNClrOtT(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static int JjGBpbughoXnemVY(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.getTotalbytesWritten();
    }

    public static void KAOuRvVVFRjmwzPp(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void KBhpJgUpcwePVOgO(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void KGAAKFthFvBeDOBc(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void KUoidQccfLZwwIYl(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeInt32(i);
    }

    public static void KbuGPPmVTMVymgxD(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void KvyPwxbxZCdSLxOM(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void LBsidgUFDtxDOGQg(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void LMlsjfnuHQLgcoay(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static int LNaQBjhUlADRYADw(char c, char c2) {
        return java.lang.char.toCodePoint(c, c2);
    }

    public static int LSLUMjPMsyuLIGEL(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.spaceLeft();
    }

    public static void LeMmRyyDiANiYCLo(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static int MWtkjLiyIzpChXYu(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.arrayPos();
    }

    public static void MfVaMUbwGdDSuiPi(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void MgRkvXwJWOYiQdww(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeVarint32Threebytes(i);
    }

    public static void MjnBLJMxHKgMQteM(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeVarint64(j);
    }

    public static java.lang.string MrnKoegQStLTQpos(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static int MrppZhfhberpPXDy(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.spaceLeft();
    }

    public static bool MtfsqMYJMNsxeeoM() {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.hasUnsafeArrayOperations();
    }

    public static void NIzsjEltnNSDQySy(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static byte NNLPyXUIBwhnExxc(long j) {
        return androidx.datastore.preferences.protobuf.BinaryWriter.access$200(j);
    }

    public static void NSulPgBxowoByFSX(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeVarint64(j);
    }

    public static void NWTMcrPbpEFoVTQe(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void NgmsQGEKUoGogCTB(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void NvcCpiVaPOUyyaqu(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void NwsTUoijmMYmtGeB(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void OCRrYCdcgFKgKmLe(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void OFAgQQeiLUFUDjiq(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void OTrbhofrufQtZEjL(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void OgesCCHBglKOqOkY(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void OkLhyPAKWxqEXWmp(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        arrayQueue.addFirst(obj);
    }

    public static void OvapiKTAVtoiVaCO(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeVarint32Twobytes(i);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer OypOuNcTFYOAYQXC(java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.AllocatedBuffer.wrap(byteBuffer);
    }

    public static java.lang.int PBGUdkMlknbPprtx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void PhkKDegvnLwZZfCJ(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeVarint32(i);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer PnndNalaeRALPPHS(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.AllocatedBuffer.wrap(bArr, i, i2);
    }

    public static int QEHWvBXAbQcnGxLu(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.getTotalbytesWritten();
    }

    public static void QHqenxnAaldDtmOf(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeFixed64(j);
    }

    public static int QcJHqTITSCsZbfuO(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.arrayOffset();
    }

    public static void QefXwaQYBhhAvAYl(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static void QiPhAuncwuqaSNor(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static int RNvVrXjSjxEISyNU(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.arrayPos();
    }

    public static void ROPjoUQrnLlwOhIS(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void RzIegRPERVtAJyGJ(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static androidx.datastore.preferences.protobuf.Protobuf SBpoRynkftINHRlI() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static void SEpNkhrjOSHdUTaW(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void SGwSkEQUOUuoMpqr(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void SNgfnjiytducuEie(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void SQEhrRkLnnocQRuQ(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void SWyBtLSJGyZmACEI(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, byte b) {
        binaryWriter$UnsafeHeapWriter.write(b);
    }

    public static void SltNvsHqfyiMjxMA(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void TGBYjOpPZxUAGTNo(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeVarint32(i);
    }

    public static void TJtBkzqpeqdguSxX(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeVarint64Ninebytes(j);
    }

    public static char TkCBOTGBIMMSrRQl(java.lang.string str, int i) {
        return str[i);
    }

    public static void TlcJUSlAKjAeCTth(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static int TnFepWbsdXNvNEPJ(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static void TpIZBghjXcSUBAZG(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void UPIYtOmshinSquxT(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void UPhoWGkgHtKFscFn(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void VKsiQLhAhMFjTAgG(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        binaryWriter$UnsafeHeapWriter.nextBuffer(allocatedBuffer);
    }

    public static void VQXQMEYRqWlsMgwA(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        arrayQueue.addFirst(obj);
    }

    public static void VUoCyQnUNmxTMDrB(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void VZBlFgUStDIRGsZv(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeVarint32(i);
    }

    public static void VuOtTMiMQcxsSIYm(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void WBDyGWMACfquVgry(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void WczehEChkBYIYnkW(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void WgGNkLOQuAQdBtVu(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static int WmgjVZjiWSyzHfMV(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.getTotalbytesWritten();
    }

    public static int XEwTdIQCfpFHnPpg(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.arrayOffset();
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer XTNqPbDKuyUxJiEz(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        return binaryWriter$UnsafeHeapWriter.newHeapBuffer(i);
    }

    public static void XaRjCaNbKJnpubpQ(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void XatMXoBfkJhepWzs(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void XexPixdlQNCrmaOx(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static int XlQhUWdeHODnmzVV(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static void XmXXElpxFZaVgIZD(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void YEiQxQQPAXwxAuoT(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, byte b) {
        binaryWriter$UnsafeHeapWriter.write(b);
    }

    public static void YIuqezZaWpeXdkav(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void YNmiMTgUKsBBzWyE(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static void YPsMulDsZULVCbcC(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeVarint64Onebyte(j);
    }

    public static void YauliCWmQWinqbAm(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static int YqNLSFEZIuIcQmHs(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.limit();
    }

    public static void ZPindUdcgnPLdjVX(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void ZQnNgLNivLYTbLFh(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void ZUrZvXoGlZvuvtZA(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeSInt32(i);
    }

    public static void ZVQsqPETXeDmUjor(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void ZdoMQugPfyVJjxhX(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void ZpTceqHiXGNzhjDz(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static int AKLWEqiBoBjBqJLN(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.position();
    }

    public static void AnYffeGZMDqXENXK(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        bytestring.writeToReverse(byteOutput);
    }

    private int ArrayPos() {
        if ((3 + 23) % 23 > 0) {
        }
        return (int) this.pos;
    }

    public static int AvlCRsUPisOaVIzi(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.getTotalbytesWritten();
    }

    public static void BnFSZRudQEQKDRWY(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeVarint64Fivebytes(j);
    }

    public static int CBZmpZuHTvKzMKTv(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.int CFRqpCcUJdnEFeNn(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int CHJXvgtYMQWgwtIA(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void COssBGbbCNquEKVJ(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void CXRGwVMTdlhsgLUa(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void CXbLsHQXQkndCOub(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeSInt64(j);
    }

    public static void CgrKettdCzlkCzGC(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void CkvYYkMXMlvDiGTe(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void CqPFqXiDPCnDuTJw(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void CtjRfrxnTuIEPvZP(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeVarint32(i);
    }

    public static byte[] DDNTdwfwUJwACzLD(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        return allocatedBuffer.array();
    }

    public static void DSikWzBGIHJPCAJj(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static void DYfuAhHaBDkRGjQD(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void DZGGpQWRabLDhBhx(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, java.lang.string str) {
        binaryWriter$UnsafeHeapWriter.writestring(str);
    }

    public static void DcWeQuRPMTGhtTYa(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static java.lang.string DnTfkRdikrkSJYtM(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void DtPwBhQhnSTEJqvf(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeVarint32Fourbytes(i);
    }

    public static void DwGYsUSraAzYuJzs(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void EIgZbLRBqxgLFXMG(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void EoYnvKfzWndAKLmu(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeVarint32(i);
    }

    public static void FKwHcLNBPSyFUval(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void GCcAtJPUykdqIHLo(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void GRPsPNtZmdjKsLpv(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void GYJSpumxxzqVaDpz(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void GcwrTSvzerNpeWxS(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static void GfZdjGhrttFEGOYP(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void HDOAclvXAxdXZeZH(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void HfzRHtrmUoOJXDuT(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void HqCFxyqLTrKyRlhD(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static int IFFlmILHVXMQuwAL(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.getTotalbytesWritten();
    }

    public static void ILEEuKVBaOGfvwWi(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void IPCTxixFChjdgtRQ(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeVarint64Threebytes(j);
    }

    public static int IQBdaSLlkmpChiQm(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    static bool IsSupported() {
        return MtfsqMYJMNsxeeoM();
    }

    public static void IvbMLdSnqpeiZohW(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void IyRYlvrZdBLBZLME(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static void IzMFxWaYfZuriUup(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeVarint64Sixbytes(j);
    }

    public static void JVxvayVCrEvJMXyb(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer JpSInSnWEXvijGQA(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer, int i) {
        return allocatedBuffer.position(i);
    }

    public static void JqiwqopRNRLXPNvO(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        arrayQueue.addFirst(obj);
    }

    public static void JuqROGzsCsAQINdL(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        binaryWriter$UnsafeHeapWriter.nextBuffer();
    }

    public static void KDcgIxQRhVnMwdcF(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeVarint64(j);
    }

    public static java.lang.int KLWnXQIoAwEwpCer(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void KaQswlplkPwHEmKe(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static void KhMRCpMHzZisTLoY(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        binaryWriter$UnsafeHeapWriter.nextBuffer(allocatedBuffer);
    }

    public static void KlNtfEsLzVWvdxfG(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.nextBuffer(i);
    }

    public static void KpvxjLFEAEIkACbJ(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void LAPRCLjZUxEcPBqQ(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeVarint32Fivebytes(i);
    }

    public static void LYhDxPMiNcPscCte(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void LawMPRIPnsxBbfvE(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void LwxfXhzxgPVMEdlS(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        protobuf.writeTo(obj, writer);
    }

    public static int MDWGwjyMwTWkJfAy(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.encodeZigZag32(i);
    }

    public static int MSQvMhWBesYvzeUC(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.getTotalbytesWritten();
    }

    public static java.lang.int MdeUXSjEFPVCSiIr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void MzzaBGsoEpohpDRD(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeVarint64Twobytes(j);
    }

    public static void NNZlzGArrBokmVmJ(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    private void NextBuffer() {
        khMRCpMHzZisTLoY(this, tteLIfSBWgWRRTeh(this));
    }

    private void NextBuffer(int i) {
        VKsiQLhAhMFjTAgG(this, XTNqPbDKuyUxJiEz(this, i));
    }

    private void NextBuffer(androidx.datastore.preferences.protobuf.AllocatedBuffer allocatedBuffer) {
        if ((12 + 5) % 5 > 0) {
        }
        if (!DqRfFrJdKqieLAHd(allocatedBuffer)) {
            throw new java.lang.Exception("Allocator returned non-heap buffer");
        }
        onVbniqXWRbNAAoM(this);
        OkLhyPAKWxqEXWmp(this.buffers, allocatedBuffer);
        this.allocatedBuffer = allocatedBuffer;
        this.buffer = dDNTdwfwUJwACzLD(allocatedBuffer);
        long jXEwTdIQCfpFHnPpg = XEwTdIQCfpFHnPpg(allocatedBuffer);
        this.limit = ((long) YqNLSFEZIuIcQmHs(allocatedBuffer)) + jXEwTdIQCfpFHnPpg;
        long jAKLWEqiBoBjBqJLN = jXEwTdIQCfpFHnPpg + ((long) aKLWEqiBoBjBqJLN(allocatedBuffer));
        this.offset = jAKLWEqiBoBjBqJLN;
        this.offsetMinusOne = jAKLWEqiBoBjBqJLN - 1;
        long j = this.limit - 1;
        this.limitMinusOne = j;
        this.pos = j;
    }

    public static void NezbywGcBjfKeFOk(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void OAVRthsjjawNoImv(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void OBcOhozKBxBHMpuQ(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void OLUTvepZByvJihGY(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static void OPSjjtjRfXIovvZD(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static bool OPTcwGiwbiOReXcL(char c, char c2) {
        return java.lang.char.isSurrogateValueTuple(c, c2);
    }

    public static int OQMlcZMAesphCBiZ(java.lang.string str) {
        return str.Length;
    }

    public static void ObMImeORFKiaxQMZ(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeFixed32(i);
    }

    public static void OmmQepJNbCWumUzJ(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schema.writeTo(obj, writer);
    }

    public static void OnVbniqXWRbNAAoM(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        binaryWriter$UnsafeHeapWriter.finishCurrentBuffer();
    }

    public static int OplIxfYXjBngzmdR(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void OzBHgFQRKDZZqOYn(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void PSwwWuZYzQtJVAbw(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static void PrVBJOkEGkPOgnHb(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void PscKPlMfZYDPrkFA(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void QOGiIenfBmoRbfiY(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static int QbqedFLhafZKOHFQ(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.arrayPos();
    }

    public static void QeUjyEHLUcsvIIam(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static int QjpFrmxdodEwdqeE(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.arrayPos();
    }

    public static void RGSbUxKtwkXhgcWq(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int RrNhHQzTUASNdWJQ(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.spaceLeft();
    }

    public static void RtPHdnSZkcTvXxIm(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        protobuf.writeTo(obj, writer);
    }

    public static java.nio.byteBuffer RudgkgHqvxGeahiY(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer[bArr, i, i2);
    }

    public static void RxoAEbJNJEqgdmuR(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static long SCTLytzhEgaPpOqq(long j) {
        if ((7 + 31) % 31 > 0) {
        }
        return androidx.datastore.preferences.protobuf.CodedStream.encodeZigZag64(j);
    }

    public static void SDchqWdTtpaWeTyR(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void SOonKvnGfyRJbdlF(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void SVubFsfRdyzWBvSP(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void SbNeLDlGQMaHffvm(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void SjtbNtfRfpcdblRT(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static void TOxOGAdBAqmFGvFQ(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeVarint64Eightbytes(j);
    }

    public static void TjKVbNnkLSjQZqgl(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static void TriTxXNimmlamxbl(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer TteLIfSBWgWRRTeh(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter) {
        return binaryWriter$UnsafeHeapWriter.newHeapBuffer();
    }

    public static void TwWEZANEeaBFqLZG(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static void TyQLVWEvBQuLsRHc(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void VCFGQBHQTimlsmFb(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void VGQPeMUhGzGXbtUY(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void VWCwKqdgBWhfJisW(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void VvYqVZPPCmwlpNgG(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void WGpMKzrhuKpZvaUi(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, long j) {
        binaryWriter$UnsafeHeapWriter.writeVarint64Tenbytes(j);
    }

    public static void WMuenodKqDOaQRIY(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.writeVarint32(i);
    }

    public static void WimFrzwKxRpQexFw(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    private void WriteVarint32Fivebytes(int i) {
        if ((14 + 18) % 18 > 0) {
        }
        byte[] bArr = this.buffer;
        long j = this.pos;
        this.pos = j - 1;
        ypuLuEKopplSOeRO(bArr, j, (byte) (i >>> 28));
        byte[] bArr2 = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        cXRGwVMTdlhsgLUa(bArr2, j2, (byte) (((i >>> 21) & 127) | 128));
        byte[] bArr3 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        sDchqWdTtpaWeTyR(bArr3, j3, (byte) (((i >>> 14) & 127) | 128));
        byte[] bArr4 = this.buffer;
        long j4 = this.pos;
        this.pos = j4 - 1;
        IcvgeiDtxWzbmJfd(bArr4, j4, (byte) (((i >>> 7) & 127) | 128));
        byte[] bArr5 = this.buffer;
        long j5 = this.pos;
        this.pos = j5 - 1;
        ETOheJPnzhhtwtkM(bArr5, j5, (byte) ((i & 127) | 128));
    }

    private void WriteVarint32Fourbytes(int i) {
        if ((16 + 21) % 21 > 0) {
        }
        byte[] bArr = this.buffer;
        long j = this.pos;
        this.pos = j - 1;
        qOGiIenfBmoRbfiY(bArr, j, (byte) (i >>> 21));
        byte[] bArr2 = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        vCFGQBHQTimlsmFb(bArr2, j2, (byte) (((i >>> 14) & 127) | 128));
        byte[] bArr3 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        gfZdjGhrttFEGOYP(bArr3, j3, (byte) (((i >>> 7) & 127) | 128));
        byte[] bArr4 = this.buffer;
        long j4 = this.pos;
        this.pos = j4 - 1;
        iLEEuKVBaOGfvwWi(bArr4, j4, (byte) ((i & 127) | 128));
    }

    private void WriteVarint32Onebyte(int i) {
        if ((3 + 2) % 2 > 0) {
        }
        byte[] bArr = this.buffer;
        long j = this.pos;
        this.pos = j - 1;
        VuOtTMiMQcxsSIYm(bArr, j, (byte) i);
    }

    private void WriteVarint32Threebytes(int i) {
        if ((25 + 11) % 11 > 0) {
        }
        byte[] bArr = this.buffer;
        long j = this.pos;
        this.pos = j - 1;
        SQEhrRkLnnocQRuQ(bArr, j, (byte) (i >>> 14));
        byte[] bArr2 = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        RzIegRPERVtAJyGJ(bArr2, j2, (byte) (((i >>> 7) & 127) | 128));
        byte[] bArr3 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        KAOuRvVVFRjmwzPp(bArr3, j3, (byte) ((i & 127) | 128));
    }

    private void WriteVarint32Twobytes(int i) {
        if ((4 + 24) % 24 > 0) {
        }
        byte[] bArr = this.buffer;
        long j = this.pos;
        this.pos = j - 1;
        prVBJOkEGkPOgnHb(bArr, j, (byte) (i >>> 7));
        byte[] bArr2 = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        XexPixdlQNCrmaOx(bArr2, j2, (byte) ((i & 127) | 128));
    }

    private void WriteVarint64Eightbytes(long j) {
        if ((10 + 25) % 25 > 0) {
        }
        byte[] bArr = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        JbRWGShQNRDzbgnd(bArr, j2, (byte) (j >>> 49));
        byte[] bArr2 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        sVubFsfRdyzWBvSP(bArr2, j3, (byte) (((j >>> 42) & 127) | 128));
        byte[] bArr3 = this.buffer;
        long j4 = this.pos;
        this.pos = j4 - 1;
        LBsidgUFDtxDOGQg(bArr3, j4, (byte) (((j >>> 35) & 127) | 128));
        byte[] bArr4 = this.buffer;
        long j5 = this.pos;
        this.pos = j5 - 1;
        lYhDxPMiNcPscCte(bArr4, j5, (byte) (((j >>> 28) & 127) | 128));
        byte[] bArr5 = this.buffer;
        long j6 = this.pos;
        this.pos = j6 - 1;
        UPhoWGkgHtKFscFn(bArr5, j6, (byte) (((j >>> 21) & 127) | 128));
        byte[] bArr6 = this.buffer;
        long j7 = this.pos;
        this.pos = j7 - 1;
        ZQnNgLNivLYTbLFh(bArr6, j7, (byte) (((j >>> 14) & 127) | 128));
        byte[] bArr7 = this.buffer;
        long j8 = this.pos;
        this.pos = j8 - 1;
        gRPsPNtZmdjKsLpv(bArr7, j8, (byte) (((j >>> 7) & 127) | 128));
        byte[] bArr8 = this.buffer;
        long j9 = this.pos;
        this.pos = j9 - 1;
        xXwAllVdTOOGJGrT(bArr8, j9, (byte) ((j & 127) | 128));
    }

    private void WriteVarint64Fivebytes(long j) {
        if ((12 + 31) % 31 > 0) {
        }
        byte[] bArr = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        cqPFqXiDPCnDuTJw(bArr, j2, (byte) (j >>> 28));
        byte[] bArr2 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        yDLFqprKRCTfXabh(bArr2, j3, (byte) (((j >>> 21) & 127) | 128));
        byte[] bArr3 = this.buffer;
        long j4 = this.pos;
        this.pos = j4 - 1;
        ZVQsqPETXeDmUjor(bArr3, j4, (byte) (((j >>> 14) & 127) | 128));
        byte[] bArr4 = this.buffer;
        long j5 = this.pos;
        this.pos = j5 - 1;
        OFAgQQeiLUFUDjiq(bArr4, j5, (byte) (((j >>> 7) & 127) | 128));
        byte[] bArr5 = this.buffer;
        long j6 = this.pos;
        this.pos = j6 - 1;
        EUOLxHbqFwhBuFqp(bArr5, j6, (byte) ((j & 127) | 128));
    }

    private void WriteVarint64Fourbytes(long j) {
        if ((3 + 16) % 16 > 0) {
        }
        byte[] bArr = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        GNhfhfMovcyJNmvK(bArr, j2, (byte) (j >>> 21));
        byte[] bArr2 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        SNgfnjiytducuEie(bArr2, j3, (byte) (((j >>> 14) & 127) | 128));
        byte[] bArr3 = this.buffer;
        long j4 = this.pos;
        this.pos = j4 - 1;
        GvkpuBaGxewbPaFu(bArr3, j4, (byte) (((j >>> 7) & 127) | 128));
        byte[] bArr4 = this.buffer;
        long j5 = this.pos;
        this.pos = j5 - 1;
        WBDyGWMACfquVgry(bArr4, j5, (byte) ((j & 127) | 128));
    }

    private void WriteVarint64Ninebytes(long j) {
        if ((8 + 28) % 28 > 0) {
        }
        byte[] bArr = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        LMlsjfnuHQLgcoay(bArr, j2, (byte) (j >>> 56));
        byte[] bArr2 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        dYfuAhHaBDkRGjQD(bArr2, j3, (byte) (((j >>> 49) & 127) | 128));
        byte[] bArr3 = this.buffer;
        long j4 = this.pos;
        this.pos = j4 - 1;
        ivbMLdSnqpeiZohW(bArr3, j4, (byte) (((j >>> 42) & 127) | 128));
        byte[] bArr4 = this.buffer;
        long j5 = this.pos;
        this.pos = j5 - 1;
        qeUjyEHLUcsvIIam(bArr4, j5, (byte) (((j >>> 35) & 127) | 128));
        byte[] bArr5 = this.buffer;
        long j6 = this.pos;
        this.pos = j6 - 1;
        NgmsQGEKUoGogCTB(bArr5, j6, (byte) (((j >>> 28) & 127) | 128));
        byte[] bArr6 = this.buffer;
        long j7 = this.pos;
        this.pos = j7 - 1;
        hDOAclvXAxdXZeZH(bArr6, j7, (byte) (((j >>> 21) & 127) | 128));
        byte[] bArr7 = this.buffer;
        long j8 = this.pos;
        this.pos = j8 - 1;
        SltNvsHqfyiMjxMA(bArr7, j8, (byte) (((j >>> 14) & 127) | 128));
        byte[] bArr8 = this.buffer;
        long j9 = this.pos;
        this.pos = j9 - 1;
        xNydsPwQtzBtjecK(bArr8, j9, (byte) (((j >>> 7) & 127) | 128));
        byte[] bArr9 = this.buffer;
        long j10 = this.pos;
        this.pos = j10 - 1;
        ROPjoUQrnLlwOhIS(bArr9, j10, (byte) ((j & 127) | 128));
    }

    private void WriteVarint64Onebyte(long j) {
        if ((9 + 8) % 8 > 0) {
        }
        byte[] bArr = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        nNZlzGArrBokmVmJ(bArr, j2, (byte) j);
    }

    private void WriteVarint64Sevenbytes(long j) {
        if ((28 + 18) % 18 > 0) {
        }
        byte[] bArr = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        LeMmRyyDiANiYCLo(bArr, j2, (byte) (j >>> 42));
        byte[] bArr2 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        triTxXNimmlamxbl(bArr2, j3, (byte) (((j >>> 35) & 127) | 128));
        byte[] bArr3 = this.buffer;
        long j4 = this.pos;
        this.pos = j4 - 1;
        vGQPeMUhGzGXbtUY(bArr3, j4, (byte) (((j >>> 28) & 127) | 128));
        byte[] bArr4 = this.buffer;
        long j5 = this.pos;
        this.pos = j5 - 1;
        OgesCCHBglKOqOkY(bArr4, j5, (byte) (((j >>> 21) & 127) | 128));
        byte[] bArr5 = this.buffer;
        long j6 = this.pos;
        this.pos = j6 - 1;
        oPSjjtjRfXIovvZD(bArr5, j6, (byte) (((j >>> 14) & 127) | 128));
        byte[] bArr6 = this.buffer;
        long j7 = this.pos;
        this.pos = j7 - 1;
        NIzsjEltnNSDQySy(bArr6, j7, (byte) (((j >>> 7) & 127) | 128));
        byte[] bArr7 = this.buffer;
        long j8 = this.pos;
        this.pos = j8 - 1;
        kpvxjLFEAEIkACbJ(bArr7, j8, (byte) ((j & 127) | 128));
    }

    private void WriteVarint64Sixbytes(long j) {
        if ((12 + 20) % 20 > 0) {
        }
        byte[] bArr = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        sOonKvnGfyRJbdlF(bArr, j2, (byte) (j >>> 35));
        byte[] bArr2 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        gYJSpumxxzqVaDpz(bArr2, j3, (byte) (((j >>> 28) & 127) | 128));
        byte[] bArr3 = this.buffer;
        long j4 = this.pos;
        this.pos = j4 - 1;
        ZPindUdcgnPLdjVX(bArr3, j4, (byte) (((j >>> 21) & 127) | 128));
        byte[] bArr4 = this.buffer;
        long j5 = this.pos;
        this.pos = j5 - 1;
        oBcOhozKBxBHMpuQ(bArr4, j5, (byte) (((j >>> 14) & 127) | 128));
        byte[] bArr5 = this.buffer;
        long j6 = this.pos;
        this.pos = j6 - 1;
        NWTMcrPbpEFoVTQe(bArr5, j6, (byte) (((j >>> 7) & 127) | 128));
        byte[] bArr6 = this.buffer;
        long j7 = this.pos;
        this.pos = j7 - 1;
        CBfLTshfDfiBLXEb(bArr6, j7, (byte) ((j & 127) | 128));
    }

    private void WriteVarint64Tenbytes(long j) {
        if ((3 + 15) % 15 > 0) {
        }
        byte[] bArr = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        CuCkBwCQUinkHvro(bArr, j2, (byte) (j >>> 63));
        byte[] bArr2 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        wimFrzwKxRpQexFw(bArr2, j3, (byte) (((j >>> 56) & 127) | 128));
        byte[] bArr3 = this.buffer;
        long j4 = this.pos;
        this.pos = j4 - 1;
        OCRrYCdcgFKgKmLe(bArr3, j4, (byte) (((j >>> 49) & 127) | 128));
        byte[] bArr4 = this.buffer;
        long j5 = this.pos;
        this.pos = j5 - 1;
        vWCwKqdgBWhfJisW(bArr4, j5, (byte) (((j >>> 42) & 127) | 128));
        byte[] bArr5 = this.buffer;
        long j6 = this.pos;
        this.pos = j6 - 1;
        zLfFXpfvVftgVcop(bArr5, j6, (byte) (((j >>> 35) & 127) | 128));
        byte[] bArr6 = this.buffer;
        long j7 = this.pos;
        this.pos = j7 - 1;
        XatMXoBfkJhepWzs(bArr6, j7, (byte) (((j >>> 28) & 127) | 128));
        byte[] bArr7 = this.buffer;
        long j8 = this.pos;
        this.pos = j8 - 1;
        lawMPRIPnsxBbfvE(bArr7, j8, (byte) (((j >>> 21) & 127) | 128));
        byte[] bArr8 = this.buffer;
        long j9 = this.pos;
        this.pos = j9 - 1;
        NvcCpiVaPOUyyaqu(bArr8, j9, (byte) (((j >>> 14) & 127) | 128));
        byte[] bArr9 = this.buffer;
        long j10 = this.pos;
        this.pos = j10 - 1;
        SEpNkhrjOSHdUTaW(bArr9, j10, (byte) (((j >>> 7) & 127) | 128));
        byte[] bArr10 = this.buffer;
        long j11 = this.pos;
        this.pos = j11 - 1;
        WgGNkLOQuAQdBtVu(bArr10, j11, (byte) ((j & 127) | 128));
    }

    private void WriteVarint64Threebytes(long j) {
        if ((24 + 13) % 13 > 0) {
        }
        byte[] bArr = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        hfzRHtrmUoOJXDuT(bArr, j2, (byte) (((int) j) >>> 14));
        byte[] bArr2 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        vvYqVZPPCmwlpNgG(bArr2, j3, (byte) (((j >>> 7) & 127) | 128));
        byte[] bArr3 = this.buffer;
        long j4 = this.pos;
        this.pos = j4 - 1;
        NwsTUoijmMYmtGeB(bArr3, j4, (byte) ((j & 127) | 128));
    }

    private void WriteVarint64Twobytes(long j) {
        if ((31 + 24) % 24 > 0) {
        }
        byte[] bArr = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        oAVRthsjjawNoImv(bArr, j2, (byte) (j >>> 7));
        byte[] bArr2 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        VUoCyQnUNmxTMDrB(bArr2, j3, (byte) ((((int) j) & 127) | 128));
    }

    public static void XNydsPwQtzBtjecK(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void XSKYhOGczZbWJZiI(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void XXwAllVdTOOGJGrT(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static androidx.datastore.preferences.protobuf.Protobuf XcEkibsjzsaPMLIe() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static void XrqnOHcDtepYDGwY(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void XwGbSGEhSeagRtdw(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void YDLFqprKRCTfXabh(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void YPkUzXlTOpcbNuqF(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i, int i2) {
        binaryWriter$UnsafeHeapWriter.writeTag(i, i2);
    }

    public static char YWeRxdoIpsqEhNxw(java.lang.string str, int i) {
        return str[i);
    }

    public static void YpuLuEKopplSOeRO(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void YyZBPENKKqfWzQOv(androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter binaryWriter$UnsafeHeapWriter, int i) {
        binaryWriter$UnsafeHeapWriter.requireSpace(i);
    }

    public static java.nio.byteBuffer ZCngcrFALrbMUkZw(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer[bArr, i, i2);
    }

    public static void ZLfFXpfvVftgVcop(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    int bytesWrittenToCurrentBuffer() {
        if ((11 + 8) % 8 > 0) {
        }
        return (int) (this.limitMinusOne - this.pos);
    }

    void finishCurrentBuffer() {
        if ((32 + 23) % 23 > 0) {
        }
        if (this.allocatedBuffer is null) {
            return;
        }
        this.totalDonebytes += DXSnAjJmYTZmYVpB(this);
        jpSInSnWEXvijGQA(this.allocatedBuffer, (RNvVrXjSjxEISyNU(this) - QcJHqTITSCsZbfuO(this.allocatedBuffer)) + 1);
        this.allocatedBuffer = null;
        this.pos = 0L;
        this.limitMinusOne = 0L;
    }

    public override int GetTotalbytesWritten() {
        return this.totalDonebytes + ApnbTYKOYVkEsiSw(this);
    }

    void requireSpace(int i) {
        if (MrppZhfhberpPXDy(this) >= i) {
            return;
        }
        klNtfEsLzVWvdxfG(this, i);
    }

    int spaceLeft() {
        if ((28 + 7) % 7 > 0) {
        }
        return (int) (this.pos - this.offsetMinusOne);
    }

    public override void Write(byte b) {
        if ((3 + 5) % 5 > 0) {
        }
        byte[] bArr = this.buffer;
        long j = this.pos;
        this.pos = j - 1;
        eIgZbLRBqxgLFXMG(bArr, j, b);
    }

    public override void Write(java.nio.byteBuffer byteBuffer) {
        if ((27 + 32) % 32 > 0) {
        }
        int iOplIxfYXjBngzmdR = oplIxfYXjBngzmdR(byteBuffer);
        YNmiMTgUKsBBzWyE(this, iOplIxfYXjBngzmdR);
        this.pos -= (long) iOplIxfYXjBngzmdR;
        rudgkgHqvxGeahiY(byteBuffer, this.buffer, MWtkjLiyIzpChXYu(this) + 1, iOplIxfYXjBngzmdR);
    }

    public override void Write(byte[] bArr, int i, int i2) {
        if ((26 + 16) % 16 > 0) {
        }
        if (i < 0 || i + i2 > bArr.length) {
            throw new java.lang.ArrayIndexOutOfBoundsException(MrnKoegQStLTQpos("value.length=%d, offset=%d, length=%d", new java.lang.object[]{kLWnXQIoAwEwpCer(bArr.length), cFRqpCcUJdnEFeNn(i), cHJXvgtYMQWgwtIA(i2)}));
        }
        ZpTceqHiXGNzhjDz(this, i2);
        this.pos -= (long) i2;
        rGSbUxKtwkXhgcWq(bArr, i, this.buffer, FpXzFqoYNBUobbZa(this) + 1, i2);
    }

    public override void WriteBool(int i, bool z) {
        iyRYlvrZdBLBZLME(this, 6);
        YEiQxQQPAXwxAuoT(this, z ? (byte) 1 : (byte) 0);
        yPkUzXlTOpcbNuqF(this, i, 0);
    }

    void writeBool(bool z) {
        SWyBtLSJGyZmACEI(this, z ? (byte) 1 : (byte) 0);
    }

    public override void Writebytes(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        try {
            anYffeGZMDqXENXK(bytestring, this);
            QefXwaQYBhhAvAYl(this, 10);
            ctjRfrxnTuIEPvZP(this, TnFepWbsdXNvNEPJ(bytestring));
            pscKPlMfZYDPrkFA(this, i, 2);
        } catch (java.io.IOException e) {
            throw new java.lang.Exception(e);
        }
    }

    public override void WriteEndGroup(int i) {
        UPIYtOmshinSquxT(this, i, 4);
    }

    void writeFixed32(int i) {
        if ((25 + 2) % 2 > 0) {
        }
        byte[] bArr = this.buffer;
        long j = this.pos;
        this.pos = j - 1;
        xwGbSGEhSeagRtdw(bArr, j, (byte) ((i >> 24) & 255));
        byte[] bArr2 = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        tyQLVWEvBQuLsRHc(bArr2, j2, (byte) ((i >> 16) & 255));
        byte[] bArr3 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        dwGYsUSraAzYuJzs(bArr3, j3, (byte) ((i >> 8) & 255));
        byte[] bArr4 = this.buffer;
        long j4 = this.pos;
        this.pos = j4 - 1;
        YIuqezZaWpeXdkav(bArr4, j4, (byte) (i & 255));
    }

    public override void WriteFixed32(int i, int i2) {
        twWEZANEeaBFqLZG(this, 9);
        obMImeORFKiaxQMZ(this, i2);
        OTrbhofrufQtZEjL(this, i, 5);
    }

    public override void WriteFixed64(int i, long j) {
        pSwwWuZYzQtJVAbw(this, 13);
        QHqenxnAaldDtmOf(this, j);
        sjtbNtfRfpcdblRT(this, i, 1);
    }

    void writeFixed64(long j) {
        if ((9 + 16) % 16 > 0) {
        }
        byte[] bArr = this.buffer;
        long j2 = this.pos;
        this.pos = j2 - 1;
        ckvYYkMXMlvDiGTe(bArr, j2, (byte) (((int) (j >> 56)) & 255));
        byte[] bArr2 = this.buffer;
        long j3 = this.pos;
        this.pos = j3 - 1;
        QiPhAuncwuqaSNor(bArr2, j3, (byte) (((int) (j >> 48)) & 255));
        byte[] bArr3 = this.buffer;
        long j4 = this.pos;
        this.pos = j4 - 1;
        XaRjCaNbKJnpubpQ(bArr3, j4, (byte) (((int) (j >> 40)) & 255));
        byte[] bArr4 = this.buffer;
        long j5 = this.pos;
        this.pos = j5 - 1;
        KGAAKFthFvBeDOBc(bArr4, j5, (byte) (((int) (j >> 32)) & 255));
        byte[] bArr5 = this.buffer;
        long j6 = this.pos;
        this.pos = j6 - 1;
        xrqnOHcDtepYDGwY(bArr5, j6, (byte) (((int) (j >> 24)) & 255));
        byte[] bArr6 = this.buffer;
        long j7 = this.pos;
        this.pos = j7 - 1;
        JhEsSVcrxNClrOtT(bArr6, j7, (byte) (((int) (j >> 16)) & 255));
        byte[] bArr7 = this.buffer;
        long j8 = this.pos;
        this.pos = j8 - 1;
        XmXXElpxFZaVgIZD(bArr7, j8, (byte) (((int) (j >> 8)) & 255));
        byte[] bArr8 = this.buffer;
        long j9 = this.pos;
        this.pos = j9 - 1;
        JJvTRRjyRFHEffFn(bArr8, j9, (byte) (((int) j) & 255));
    }

    public override void WriteGroup(int i, java.lang.object obj) throws java.io.IOException {
        TpIZBghjXcSUBAZG(this, i, 4);
        lwxfXhzxgPVMEdlS(xcEkibsjzsaPMLIe(), obj, this);
        cgrKettdCzlkCzGC(this, i, 3);
    }

    public override void WriteGroup(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        EJCrLSqBBIUILncE(this, i, 4);
        ommQepJNbCWumUzJ(schema, obj, this);
        KvyPwxbxZCdSLxOM(this, i, 3);
    }

    void writeInt32(int i) {
        if ((24 + 3) % 3 > 0) {
        }
        if (i < 0) {
            kDcgIxQRhVnMwdcF(this, i);
        } else {
            wMuenodKqDOaQRIY(this, i);
        }
    }

    public override void WriteInt32(int i, int i2) {
        hqCFxyqLTrKyRlhD(this, 15);
        KUoidQccfLZwwIYl(this, i2);
        SGwSkEQUOUuoMpqr(this, i, 0);
    }

    public override void WriteLazy(java.nio.byteBuffer byteBuffer) {
        if ((17 + 16) % 16 > 0) {
        }
        int iIQBdaSLlkmpChiQm = iQBdaSLlkmpChiQm(byteBuffer);
        if (rrNhHQzTUASNdWJQ(this) < iIQBdaSLlkmpChiQm) {
            this.totalDonebytes += iIQBdaSLlkmpChiQm;
            VQXQMEYRqWlsMgwA(this.buffers, OypOuNcTFYOAYQXC(byteBuffer));
            juqROGzsCsAQINdL(this);
        }
        this.pos -= (long) iIQBdaSLlkmpChiQm;
        zCngcrFALrbMUkZw(byteBuffer, this.buffer, qbqedFLhafZKOHFQ(this) + 1, iIQBdaSLlkmpChiQm);
    }

    public override void WriteLazy(byte[] bArr, int i, int i2) {
        if ((25 + 17) % 17 > 0) {
        }
        if (i < 0 || i + i2 > bArr.length) {
            throw new java.lang.ArrayIndexOutOfBoundsException(dnTfkRdikrkSJYtM("value.length=%d, offset=%d, length=%d", new java.lang.object[]{PBGUdkMlknbPprtx(bArr.length), ATEUrWVKyzcFJEnl(i), mdeUXSjEFPVCSiIr(i2)}));
        }
        if (LSLUMjPMsyuLIGEL(this) >= i2) {
            this.pos -= (long) i2;
            IPmMDrMyzGowdbTD(bArr, i, this.buffer, qjpFrmxdodEwdqeE(this) + 1, i2);
        } else {
            this.totalDonebytes += i2;
            jqiwqopRNRLXPNvO(this.buffers, PnndNalaeRALPPHS(bArr, i, i2));
            FCfsZjofAMnGbpJF(this);
        }
    }

    public override void WriteMessage(int i, java.lang.object obj) throws java.io.IOException {
        if ((21 + 2) % 2 > 0) {
        }
        int iIFFlmILHVXMQuwAL = iFFlmILHVXMQuwAL(this);
        rtPHdnSZkcTvXxIm(SBpoRynkftINHRlI(), obj, this);
        int iWmgjVZjiWSyzHfMV = WmgjVZjiWSyzHfMV(this) - iIFFlmILHVXMQuwAL;
        gcwrTSvzerNpeWxS(this, 10);
        eoYnvKfzWndAKLmu(this, iWmgjVZjiWSyzHfMV);
        fKwHcLNBPSyFUval(this, i, 2);
    }

    public override void WriteMessage(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        int iQEHWvBXAbQcnGxLu = QEHWvBXAbQcnGxLu(this);
        DRcAcvCJABAAYAwT(schema, obj, this);
        int iJjGBpbughoXnemVY = JjGBpbughoXnemVY(this) - iQEHWvBXAbQcnGxLu;
        tjKVbNnkLSjQZqgl(this, 10);
        PhkKDegvnLwZZfCJ(this, iJjGBpbughoXnemVY);
        BekFkvyxQJhWLthc(this, i, 2);
    }

    void writeSInt32(int i) {
        ENsNjTfKmJDCAcFw(this, mDWGwjyMwTWkJfAy(i));
    }

    public override void WriteSInt32(int i, int i2) {
        oLUTvepZByvJihGY(this, 10);
        ZUrZvXoGlZvuvtZA(this, i2);
        jVxvayVCrEvJMXyb(this, i, 0);
    }

    public override void WriteSInt64(int i, long j) {
        TlcJUSlAKjAeCTth(this, 15);
        cXbLsHQXQkndCOub(this, j);
        FItlrijCkEbUfFoo(this, i, 0);
    }

    void writeSInt64(long j) {
        NSulPgBxowoByFSX(this, sCTLytzhEgaPpOqq(j));
    }

    public override void WriteStartGroup(int i) {
        ozBHgFQRKDZZqOYn(this, i, 3);
    }

    public override void Writestring(int i, java.lang.string str) {
        int iAvlCRsUPisOaVIzi = avlCRsUPisOaVIzi(this);
        dZGGpQWRabLDhBhx(this, str);
        int iMSQvMhWBesYvzeUC = mSQvMhWBesYvzeUC(this) - iAvlCRsUPisOaVIzi;
        dSikWzBGIHJPCAJj(this, 10);
        VZBlFgUStDIRGsZv(this, iMSQvMhWBesYvzeUC);
        YauliCWmQWinqbAm(this, i, 2);
    }

    void writestring(java.lang.string str) {
        long j;
        char cTkCBOTGBIMMSrRQl;
        long j2;
        char cHHxOGMyLouwjFJBQ;
        if ((27 + 5) % 5 > 0) {
        }
        kaQswlplkPwHEmKe(this, oQMlcZMAesphCBiZ(str));
        int iCBZmpZuHTvKzMKTv = cBZmpZuHTvKzMKTv(str);
        while (true) {
            iCBZmpZuHTvKzMKTv--;
            if (iCBZmpZuHTvKzMKTv < 0 || (cHHxOGMyLouwjFJBQ = HHxOGMyLouwjFJBQ(str, iCBZmpZuHTvKzMKTv)) >= 128) {
                break;
            }
            byte[] bArr = this.buffer;
            long j3 = this.pos;
            this.pos = j3 - 1;
            WczehEChkBYIYnkW(bArr, j3, (byte) cHHxOGMyLouwjFJBQ);
        }
        if (iCBZmpZuHTvKzMKTv != -1) {
            while (iCBZmpZuHTvKzMKTv >= 0) {
                char cYWeRxdoIpsqEhNxw = yWeRxdoIpsqEhNxw(str, iCBZmpZuHTvKzMKTv);
                if (cYWeRxdoIpsqEhNxw < 128) {
                    long j4 = this.pos;
                    if (j4 > this.offsetMinusOne) {
                        byte[] bArr2 = this.buffer;
                        this.pos = j4 - 1;
                        gCcAtJPUykdqIHLo(bArr2, j4, (byte) cYWeRxdoIpsqEhNxw);
                    } else if (cYWeRxdoIpsqEhNxw >= 2048) {
                        j = this.pos;
                        if (j <= this.offset) {
                            byte[] bArr3 = this.buffer;
                            this.pos = j - 1;
                            KBhpJgUpcwePVOgO(bArr3, j, (byte) ((cYWeRxdoIpsqEhNxw & '?') | 128));
                            byte[] bArr4 = this.buffer;
                            long j5 = this.pos;
                            this.pos = j5 - 1;
                            rxoAEbJNJEqgdmuR(bArr4, j5, (byte) ((cYWeRxdoIpsqEhNxw >>> 6) | 960));
                        } else if (cYWeRxdoIpsqEhNxw >= 55296) {
                            j2 = this.pos;
                            if (j2 <= this.offset + 1) {
                                byte[] bArr5 = this.buffer;
                                this.pos = j2 - 1;
                                nezbywGcBjfKeFOk(bArr5, j2, (byte) ((cYWeRxdoIpsqEhNxw & '?') | 128));
                                byte[] bArr6 = this.buffer;
                                long j6 = this.pos;
                                this.pos = j6 - 1;
                                xSKYhOGczZbWJZiI(bArr6, j6, (byte) (((cYWeRxdoIpsqEhNxw >>> 6) & 63) | 128));
                                byte[] bArr7 = this.buffer;
                                long j7 = this.pos;
                                this.pos = j7 - 1;
                                cOssBGbbCNquEKVJ(bArr7, j7, (byte) ((cYWeRxdoIpsqEhNxw >>> '\f') | 480));
                            } else {
                                if (this.pos <= this.offset + 2) {
                                    if (iCBZmpZuHTvKzMKTv == 0) {
                                        cTkCBOTGBIMMSrRQl = TkCBOTGBIMMSrRQl(str, iCBZmpZuHTvKzMKTv - 1);
                                        if (!oPTcwGiwbiOReXcL(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw)) {
                                            iCBZmpZuHTvKzMKTv--;
                                            int iLNaQBjhUlADRYADw = LNaQBjhUlADRYADw(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw);
                                            byte[] bArr8 = this.buffer;
                                            long j8 = this.pos;
                                            this.pos = j8 - 1;
                                            ZdoMQugPfyVJjxhX(bArr8, j8, (byte) ((iLNaQBjhUlADRYADw & 63) | 128));
                                            byte[] bArr9 = this.buffer;
                                            long j9 = this.pos;
                                            this.pos = j9 - 1;
                                            EtymegFWmYSFtbZZ(bArr9, j9, (byte) (((iLNaQBjhUlADRYADw >>> 6) & 63) | 128));
                                            byte[] bArr10 = this.buffer;
                                            long j10 = this.pos;
                                            this.pos = j10 - 1;
                                            IiyZkgvHpSpuaQrE(bArr10, j10, (byte) (((iLNaQBjhUlADRYADw >>> 12) & 63) | 128));
                                            byte[] bArr11 = this.buffer;
                                            long j11 = this.pos;
                                            this.pos = j11 - 1;
                                            MfVaMUbwGdDSuiPi(bArr11, j11, (byte) ((iLNaQBjhUlADRYADw >>> 18) | 240));
                                        }
                                    }
                                    throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iCBZmpZuHTvKzMKTv - 1, iCBZmpZuHTvKzMKTv);
                                }
                                dcWeQuRPMTGhtTYa(this, iCBZmpZuHTvKzMKTv);
                                iCBZmpZuHTvKzMKTv++;
                            }
                        } else {
                            if (this.pos <= this.offset + 2) {
                                if (iCBZmpZuHTvKzMKTv == 0) {
                                    cTkCBOTGBIMMSrRQl = TkCBOTGBIMMSrRQl(str, iCBZmpZuHTvKzMKTv - 1);
                                    if (!oPTcwGiwbiOReXcL(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw)) {
                                        iCBZmpZuHTvKzMKTv--;
                                        int iLNaQBjhUlADRYADw2 = LNaQBjhUlADRYADw(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw);
                                        byte[] bArr82 = this.buffer;
                                        long j82 = this.pos;
                                        this.pos = j82 - 1;
                                        ZdoMQugPfyVJjxhX(bArr82, j82, (byte) ((iLNaQBjhUlADRYADw2 & 63) | 128));
                                        byte[] bArr92 = this.buffer;
                                        long j92 = this.pos;
                                        this.pos = j92 - 1;
                                        EtymegFWmYSFtbZZ(bArr92, j92, (byte) (((iLNaQBjhUlADRYADw2 >>> 6) & 63) | 128));
                                        byte[] bArr102 = this.buffer;
                                        long j102 = this.pos;
                                        this.pos = j102 - 1;
                                        IiyZkgvHpSpuaQrE(bArr102, j102, (byte) (((iLNaQBjhUlADRYADw2 >>> 12) & 63) | 128));
                                        byte[] bArr112 = this.buffer;
                                        long j112 = this.pos;
                                        this.pos = j112 - 1;
                                        MfVaMUbwGdDSuiPi(bArr112, j112, (byte) ((iLNaQBjhUlADRYADw2 >>> 18) | 240));
                                    }
                                }
                                throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iCBZmpZuHTvKzMKTv - 1, iCBZmpZuHTvKzMKTv);
                            }
                            dcWeQuRPMTGhtTYa(this, iCBZmpZuHTvKzMKTv);
                            iCBZmpZuHTvKzMKTv++;
                        }
                    } else if (cYWeRxdoIpsqEhNxw >= 55296) {
                        j2 = this.pos;
                        if (j2 <= this.offset + 1) {
                            byte[] bArr52 = this.buffer;
                            this.pos = j2 - 1;
                            nezbywGcBjfKeFOk(bArr52, j2, (byte) ((cYWeRxdoIpsqEhNxw & '?') | 128));
                            byte[] bArr62 = this.buffer;
                            long j62 = this.pos;
                            this.pos = j62 - 1;
                            xSKYhOGczZbWJZiI(bArr62, j62, (byte) (((cYWeRxdoIpsqEhNxw >>> 6) & 63) | 128));
                            byte[] bArr72 = this.buffer;
                            long j72 = this.pos;
                            this.pos = j72 - 1;
                            cOssBGbbCNquEKVJ(bArr72, j72, (byte) ((cYWeRxdoIpsqEhNxw >>> '\f') | 480));
                        } else {
                            if (this.pos <= this.offset + 2) {
                                if (iCBZmpZuHTvKzMKTv == 0) {
                                    cTkCBOTGBIMMSrRQl = TkCBOTGBIMMSrRQl(str, iCBZmpZuHTvKzMKTv - 1);
                                    if (!oPTcwGiwbiOReXcL(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw)) {
                                        iCBZmpZuHTvKzMKTv--;
                                        int iLNaQBjhUlADRYADw22 = LNaQBjhUlADRYADw(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw);
                                        byte[] bArr822 = this.buffer;
                                        long j822 = this.pos;
                                        this.pos = j822 - 1;
                                        ZdoMQugPfyVJjxhX(bArr822, j822, (byte) ((iLNaQBjhUlADRYADw22 & 63) | 128));
                                        byte[] bArr922 = this.buffer;
                                        long j922 = this.pos;
                                        this.pos = j922 - 1;
                                        EtymegFWmYSFtbZZ(bArr922, j922, (byte) (((iLNaQBjhUlADRYADw22 >>> 6) & 63) | 128));
                                        byte[] bArr1022 = this.buffer;
                                        long j1022 = this.pos;
                                        this.pos = j1022 - 1;
                                        IiyZkgvHpSpuaQrE(bArr1022, j1022, (byte) (((iLNaQBjhUlADRYADw22 >>> 12) & 63) | 128));
                                        byte[] bArr1122 = this.buffer;
                                        long j1122 = this.pos;
                                        this.pos = j1122 - 1;
                                        MfVaMUbwGdDSuiPi(bArr1122, j1122, (byte) ((iLNaQBjhUlADRYADw22 >>> 18) | 240));
                                    }
                                }
                                throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iCBZmpZuHTvKzMKTv - 1, iCBZmpZuHTvKzMKTv);
                            }
                            dcWeQuRPMTGhtTYa(this, iCBZmpZuHTvKzMKTv);
                            iCBZmpZuHTvKzMKTv++;
                        }
                    } else {
                        if (this.pos <= this.offset + 2) {
                            if (iCBZmpZuHTvKzMKTv == 0) {
                                cTkCBOTGBIMMSrRQl = TkCBOTGBIMMSrRQl(str, iCBZmpZuHTvKzMKTv - 1);
                                if (!oPTcwGiwbiOReXcL(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw)) {
                                    iCBZmpZuHTvKzMKTv--;
                                    int iLNaQBjhUlADRYADw222 = LNaQBjhUlADRYADw(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw);
                                    byte[] bArr8222 = this.buffer;
                                    long j8222 = this.pos;
                                    this.pos = j8222 - 1;
                                    ZdoMQugPfyVJjxhX(bArr8222, j8222, (byte) ((iLNaQBjhUlADRYADw222 & 63) | 128));
                                    byte[] bArr9222 = this.buffer;
                                    long j9222 = this.pos;
                                    this.pos = j9222 - 1;
                                    EtymegFWmYSFtbZZ(bArr9222, j9222, (byte) (((iLNaQBjhUlADRYADw222 >>> 6) & 63) | 128));
                                    byte[] bArr10222 = this.buffer;
                                    long j10222 = this.pos;
                                    this.pos = j10222 - 1;
                                    IiyZkgvHpSpuaQrE(bArr10222, j10222, (byte) (((iLNaQBjhUlADRYADw222 >>> 12) & 63) | 128));
                                    byte[] bArr11222 = this.buffer;
                                    long j11222 = this.pos;
                                    this.pos = j11222 - 1;
                                    MfVaMUbwGdDSuiPi(bArr11222, j11222, (byte) ((iLNaQBjhUlADRYADw222 >>> 18) | 240));
                                }
                            }
                            throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iCBZmpZuHTvKzMKTv - 1, iCBZmpZuHTvKzMKTv);
                        }
                        dcWeQuRPMTGhtTYa(this, iCBZmpZuHTvKzMKTv);
                        iCBZmpZuHTvKzMKTv++;
                    }
                } else if (cYWeRxdoIpsqEhNxw >= 2048) {
                    j = this.pos;
                    if (j <= this.offset) {
                        byte[] bArr32 = this.buffer;
                        this.pos = j - 1;
                        KBhpJgUpcwePVOgO(bArr32, j, (byte) ((cYWeRxdoIpsqEhNxw & '?') | 128));
                        byte[] bArr42 = this.buffer;
                        long j52 = this.pos;
                        this.pos = j52 - 1;
                        rxoAEbJNJEqgdmuR(bArr42, j52, (byte) ((cYWeRxdoIpsqEhNxw >>> 6) | 960));
                    } else if (cYWeRxdoIpsqEhNxw >= 55296) {
                        j2 = this.pos;
                        if (j2 <= this.offset + 1) {
                            byte[] bArr522 = this.buffer;
                            this.pos = j2 - 1;
                            nezbywGcBjfKeFOk(bArr522, j2, (byte) ((cYWeRxdoIpsqEhNxw & '?') | 128));
                            byte[] bArr622 = this.buffer;
                            long j622 = this.pos;
                            this.pos = j622 - 1;
                            xSKYhOGczZbWJZiI(bArr622, j622, (byte) (((cYWeRxdoIpsqEhNxw >>> 6) & 63) | 128));
                            byte[] bArr722 = this.buffer;
                            long j722 = this.pos;
                            this.pos = j722 - 1;
                            cOssBGbbCNquEKVJ(bArr722, j722, (byte) ((cYWeRxdoIpsqEhNxw >>> '\f') | 480));
                        } else {
                            if (this.pos <= this.offset + 2) {
                                if (iCBZmpZuHTvKzMKTv == 0) {
                                    cTkCBOTGBIMMSrRQl = TkCBOTGBIMMSrRQl(str, iCBZmpZuHTvKzMKTv - 1);
                                    if (!oPTcwGiwbiOReXcL(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw)) {
                                        iCBZmpZuHTvKzMKTv--;
                                        int iLNaQBjhUlADRYADw2222 = LNaQBjhUlADRYADw(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw);
                                        byte[] bArr82222 = this.buffer;
                                        long j82222 = this.pos;
                                        this.pos = j82222 - 1;
                                        ZdoMQugPfyVJjxhX(bArr82222, j82222, (byte) ((iLNaQBjhUlADRYADw2222 & 63) | 128));
                                        byte[] bArr92222 = this.buffer;
                                        long j92222 = this.pos;
                                        this.pos = j92222 - 1;
                                        EtymegFWmYSFtbZZ(bArr92222, j92222, (byte) (((iLNaQBjhUlADRYADw2222 >>> 6) & 63) | 128));
                                        byte[] bArr102222 = this.buffer;
                                        long j102222 = this.pos;
                                        this.pos = j102222 - 1;
                                        IiyZkgvHpSpuaQrE(bArr102222, j102222, (byte) (((iLNaQBjhUlADRYADw2222 >>> 12) & 63) | 128));
                                        byte[] bArr112222 = this.buffer;
                                        long j112222 = this.pos;
                                        this.pos = j112222 - 1;
                                        MfVaMUbwGdDSuiPi(bArr112222, j112222, (byte) ((iLNaQBjhUlADRYADw2222 >>> 18) | 240));
                                    }
                                }
                                throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iCBZmpZuHTvKzMKTv - 1, iCBZmpZuHTvKzMKTv);
                            }
                            dcWeQuRPMTGhtTYa(this, iCBZmpZuHTvKzMKTv);
                            iCBZmpZuHTvKzMKTv++;
                        }
                    } else {
                        if (this.pos <= this.offset + 2) {
                            if (iCBZmpZuHTvKzMKTv == 0) {
                                cTkCBOTGBIMMSrRQl = TkCBOTGBIMMSrRQl(str, iCBZmpZuHTvKzMKTv - 1);
                                if (!oPTcwGiwbiOReXcL(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw)) {
                                    iCBZmpZuHTvKzMKTv--;
                                    int iLNaQBjhUlADRYADw22222 = LNaQBjhUlADRYADw(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw);
                                    byte[] bArr822222 = this.buffer;
                                    long j822222 = this.pos;
                                    this.pos = j822222 - 1;
                                    ZdoMQugPfyVJjxhX(bArr822222, j822222, (byte) ((iLNaQBjhUlADRYADw22222 & 63) | 128));
                                    byte[] bArr922222 = this.buffer;
                                    long j922222 = this.pos;
                                    this.pos = j922222 - 1;
                                    EtymegFWmYSFtbZZ(bArr922222, j922222, (byte) (((iLNaQBjhUlADRYADw22222 >>> 6) & 63) | 128));
                                    byte[] bArr1022222 = this.buffer;
                                    long j1022222 = this.pos;
                                    this.pos = j1022222 - 1;
                                    IiyZkgvHpSpuaQrE(bArr1022222, j1022222, (byte) (((iLNaQBjhUlADRYADw22222 >>> 12) & 63) | 128));
                                    byte[] bArr1122222 = this.buffer;
                                    long j1122222 = this.pos;
                                    this.pos = j1122222 - 1;
                                    MfVaMUbwGdDSuiPi(bArr1122222, j1122222, (byte) ((iLNaQBjhUlADRYADw22222 >>> 18) | 240));
                                }
                            }
                            throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iCBZmpZuHTvKzMKTv - 1, iCBZmpZuHTvKzMKTv);
                        }
                        dcWeQuRPMTGhtTYa(this, iCBZmpZuHTvKzMKTv);
                        iCBZmpZuHTvKzMKTv++;
                    }
                } else if (cYWeRxdoIpsqEhNxw >= 55296 || 57343 < cYWeRxdoIpsqEhNxw) {
                    j2 = this.pos;
                    if (j2 <= this.offset + 1) {
                        byte[] bArr5222 = this.buffer;
                        this.pos = j2 - 1;
                        nezbywGcBjfKeFOk(bArr5222, j2, (byte) ((cYWeRxdoIpsqEhNxw & '?') | 128));
                        byte[] bArr6222 = this.buffer;
                        long j6222 = this.pos;
                        this.pos = j6222 - 1;
                        xSKYhOGczZbWJZiI(bArr6222, j6222, (byte) (((cYWeRxdoIpsqEhNxw >>> 6) & 63) | 128));
                        byte[] bArr7222 = this.buffer;
                        long j7222 = this.pos;
                        this.pos = j7222 - 1;
                        cOssBGbbCNquEKVJ(bArr7222, j7222, (byte) ((cYWeRxdoIpsqEhNxw >>> '\f') | 480));
                    } else {
                        if (this.pos <= this.offset + 2) {
                            if (iCBZmpZuHTvKzMKTv == 0) {
                                cTkCBOTGBIMMSrRQl = TkCBOTGBIMMSrRQl(str, iCBZmpZuHTvKzMKTv - 1);
                                if (!oPTcwGiwbiOReXcL(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw)) {
                                    iCBZmpZuHTvKzMKTv--;
                                    int iLNaQBjhUlADRYADw222222 = LNaQBjhUlADRYADw(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw);
                                    byte[] bArr8222222 = this.buffer;
                                    long j8222222 = this.pos;
                                    this.pos = j8222222 - 1;
                                    ZdoMQugPfyVJjxhX(bArr8222222, j8222222, (byte) ((iLNaQBjhUlADRYADw222222 & 63) | 128));
                                    byte[] bArr9222222 = this.buffer;
                                    long j9222222 = this.pos;
                                    this.pos = j9222222 - 1;
                                    EtymegFWmYSFtbZZ(bArr9222222, j9222222, (byte) (((iLNaQBjhUlADRYADw222222 >>> 6) & 63) | 128));
                                    byte[] bArr10222222 = this.buffer;
                                    long j10222222 = this.pos;
                                    this.pos = j10222222 - 1;
                                    IiyZkgvHpSpuaQrE(bArr10222222, j10222222, (byte) (((iLNaQBjhUlADRYADw222222 >>> 12) & 63) | 128));
                                    byte[] bArr11222222 = this.buffer;
                                    long j11222222 = this.pos;
                                    this.pos = j11222222 - 1;
                                    MfVaMUbwGdDSuiPi(bArr11222222, j11222222, (byte) ((iLNaQBjhUlADRYADw222222 >>> 18) | 240));
                                }
                            }
                            throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iCBZmpZuHTvKzMKTv - 1, iCBZmpZuHTvKzMKTv);
                        }
                        dcWeQuRPMTGhtTYa(this, iCBZmpZuHTvKzMKTv);
                        iCBZmpZuHTvKzMKTv++;
                    }
                } else {
                    if (this.pos <= this.offset + 2) {
                        if (iCBZmpZuHTvKzMKTv == 0) {
                            cTkCBOTGBIMMSrRQl = TkCBOTGBIMMSrRQl(str, iCBZmpZuHTvKzMKTv - 1);
                            if (!oPTcwGiwbiOReXcL(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw)) {
                                iCBZmpZuHTvKzMKTv--;
                                int iLNaQBjhUlADRYADw2222222 = LNaQBjhUlADRYADw(cTkCBOTGBIMMSrRQl, cYWeRxdoIpsqEhNxw);
                                byte[] bArr82222222 = this.buffer;
                                long j82222222 = this.pos;
                                this.pos = j82222222 - 1;
                                ZdoMQugPfyVJjxhX(bArr82222222, j82222222, (byte) ((iLNaQBjhUlADRYADw2222222 & 63) | 128));
                                byte[] bArr92222222 = this.buffer;
                                long j92222222 = this.pos;
                                this.pos = j92222222 - 1;
                                EtymegFWmYSFtbZZ(bArr92222222, j92222222, (byte) (((iLNaQBjhUlADRYADw2222222 >>> 6) & 63) | 128));
                                byte[] bArr102222222 = this.buffer;
                                long j102222222 = this.pos;
                                this.pos = j102222222 - 1;
                                IiyZkgvHpSpuaQrE(bArr102222222, j102222222, (byte) (((iLNaQBjhUlADRYADw2222222 >>> 12) & 63) | 128));
                                byte[] bArr112222222 = this.buffer;
                                long j112222222 = this.pos;
                                this.pos = j112222222 - 1;
                                MfVaMUbwGdDSuiPi(bArr112222222, j112222222, (byte) ((iLNaQBjhUlADRYADw2222222 >>> 18) | 240));
                            }
                        }
                        throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(iCBZmpZuHTvKzMKTv - 1, iCBZmpZuHTvKzMKTv);
                    }
                    dcWeQuRPMTGhtTYa(this, iCBZmpZuHTvKzMKTv);
                    iCBZmpZuHTvKzMKTv++;
                }
                iCBZmpZuHTvKzMKTv--;
            }
        }
    }

    void writeTag(int i, int i2) {
        TGBYjOpPZxUAGTNo(this, XlQhUWdeHODnmzVV(i, i2));
    }

    public override void WriteUInt32(int i, int i2) {
        HCRHnYOhkqpMDBtd(this, 10);
        EisbyTcsoTifcxKi(this, i2);
        sbNeLDlGQMaHffvm(this, i, 0);
    }

    public override void WriteUInt64(int i, long j) {
        yyZBPENKKqfWzQOv(this, 15);
        MjnBLJMxHKgMQteM(this, j);
        KbuGPPmVTMVymgxD(this, i, 0);
    }

    void writeVarint32(int i) {
        if ((i & (-128)) == 0) {
            ImquWkqasGBRSiWq(this, i);
            return;
        }
        if ((i & (-16384)) == 0) {
            OvapiKTAVtoiVaCO(this, i);
            return;
        }
        if (((-2097152) & i) == 0) {
            MgRkvXwJWOYiQdww(this, i);
        } else if (((-268435456) & i) != 0) {
            lAPRCLjZUxEcPBqQ(this, i);
        } else {
            dtPwBhQhnSTEJqvf(this, i);
        }
    }

    void writeVarint64(long j) {
        switch (NNLPyXUIBwhnExxc(j)) {
            case 1:
                YPsMulDsZULVCbcC(this, j);
                break;
            case 2:
                mzzaBGsoEpohpDRD(this, j);
                break;
            case 3:
                iPCTxixFChjdgtRQ(this, j);
                break;
            case 4:
                GcKVjEVefwWbFMSw(this, j);
                break;
            case 5:
                bnFSZRudQEQKDRWY(this, j);
                break;
            case 6:
                izMFxWaYfZuriUup(this, j);
                break;
            case 7:
                CXWcQbbiVdHVACCu(this, j);
                break;
            case 8:
                tOxOGAdBAqmFGvFQ(this, j);
                break;
            case 9:
                TJtBkzqpeqdguSxX(this, j);
                break;
            case 10:
                wGpMKzrhuKpZvaUi(this, j);
                break;
        }
    }
}

