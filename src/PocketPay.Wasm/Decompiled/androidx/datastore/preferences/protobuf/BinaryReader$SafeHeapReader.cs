namespace WillowMaze.Wasm.Decompiled;


readonly class BinaryReader$SafeHeapReader : androidx.datastore.preferences.protobuf.BinaryReader {
    private readonly byte[] buffer;
    private readonly bool bufferIsImmutable;
    private int endGroupTag;
    private readonly int initialPos;
    private int limit;
    private int pos;
    private int tag;

    public BinaryReader$SafeHeapReader(java.nio.byteBuffer byteBuffer, bool z) {
        super(null);
        this.bufferIsImmutable = z;
        this.buffer = zdUKnhBLXWyIcSUC(byteBuffer);
        int iJpWnvCDzsUiWNJwK = JpWnvCDzsUiWNJwK(byteBuffer) + QOEbWGwOkxGqyBQf(byteBuffer);
        this.pos = iJpWnvCDzsUiWNJwK;
        this.initialPos = iJpWnvCDzsUiWNJwK;
        this.limit = pICsFqZQcxfxBeTp(byteBuffer) + iKacDuEqLXtDiDWA(byteBuffer);
    }

    public static long ACmaqltirFWvMtHM(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((26 + 29) % 29 > 0) {
        }
        return binaryReader$SafeHeapReader.readLittleEndian64_NoCheck();
    }

    public static int ADHfIHLxaFiGPWWG(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void AFToWazWnHsJuYUs(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirebytes(i);
    }

    public static bool AGMsuoLKkXzoLNbi(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static long AGvbNPEraeQejrGP(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((3 + 12) % 12 > 0) {
        }
        return binaryReader$SafeHeapReader.readVarint64();
    }

    public static int AJkpSavFiYDvvBrH(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void AMrSqRPTKtRPmSHI(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static bool ANKhEAFAiWiAEWxh(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int APgCFinkiJzkOWKC(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int AQCZitsYyKNdgNqk(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int AUaJsONhWdSPUwDO(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readSFixed32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException AVGQcjTXYpztRigO() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int AdwlfURAOfvFclox(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static java.lang.long AhvlRrygrdEPSwlQ(long j) {
        return java.lang.long.valueOf(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException AlGJNjbDgNMrdnux() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int AoFmptoWidxzvyaC(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int BFsJedkwQhsKJAJw(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool BIvmcfXrDzNaLYIk(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static androidx.datastore.preferences.protobuf.bytestring BTGNzHqFKslJwdON(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readbytes();
    }

    public static void BXxMmptDgKIPefTp(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirebytes(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException BbhmtacyKgmSFNLF() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static java.lang.object BftjJOZKEozSEpWQ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, java.lang.Class cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return binaryReader$SafeHeapReader.readField(wireFormat$FieldType, cls, extensionRegistryLite);
    }

    public static void BilovfGSaXdkhkum(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static long BjzmOHYaqxgqAJOX(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((24 + 5) % 5 > 0) {
        }
        return binaryReader$SafeHeapReader.readFixed64();
    }

    public static void BmlYLygbwjVzGAuN(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static int BoeRgxDhKhdPSDDj(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readLittleEndian32_NoCheck();
    }

    public static int BueRbusqZbIadGwC(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static java.lang.object ByBHgBUIxlvUyovY(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return binaryReader$SafeHeapReader.readGroup(schema, extensionRegistryLite);
    }

    public static bool CKGwKUsyhbszHgCY(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static void CLSGJmYaTNdLYgOi(androidx.datastore.preferences.protobuf.floatList floatList, float f) {
        floatList.addfloat(f);
    }

    public static java.lang.int CLfEXfYNzuzkwHvz(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long CMZkBoZWHnrABLTZ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((25 + 7) % 7 > 0) {
        }
        return binaryReader$SafeHeapReader.readUInt64();
    }

    public static bool CUIsSuuKTyebqZKE(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException CVvGLJtmrdlWVUYv() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static androidx.datastore.preferences.protobuf.Schema CWInYhJxOkEHivNM(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.Class cls) {
        return protobuf.schemaFor(cls);
    }

    public static void CWvJmEpXSDOTzLPM(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static void CXmhwavGfkrUfKTa(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj) {
        schema.makeImmutable(obj);
    }

    public static bool CaeUJbCuQKzNHsRa(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static long CdqYhzhOHTyWLatu(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((7 + 29) % 29 > 0) {
        }
        return binaryReader$SafeHeapReader.readLittleEndian64_NoCheck();
    }

    public static bool CjeIGvxxngeQwfEi(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int ClIuWxvsKZEXdhvu(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static long CneyQSCWIQgpJfwO(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((12 + 16) % 16 > 0) {
        }
        return binaryReader$SafeHeapReader.readVarint64();
    }

    public static long CtXCwkCnzwlTXxNx(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((30 + 24) % 24 > 0) {
        }
        return binaryReader$SafeHeapReader.readVarint64();
    }

    public static void DJBbPqMeYWbszfvY(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, java.util.List list, bool z) throws java.io.IOException {
        binaryReader$SafeHeapReader.readstringListInternal(list, z);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException DKIigLMjgLksGbWF() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int DKNFXVcTYgGiKNAG(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int DMRiqfSPzmaQBUEI(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool DOXYvXEnrdtPWLjb(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int DguNZKMKTxwFTXBG(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool DlUholrPMHVSJpIb(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void DmqQqqgktIfyudwN(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static int DrkhaHJraFTbCKnf(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag32(i);
    }

    public static int EKzMaZIKzUAKdxVS(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static void ENtHfDbPJsguQRlz(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.skipbytes(i);
    }

    public static java.lang.int ESZzyZtxGEmGDBzk(int i) {
        return java.lang.int.valueOf(i);
    }

    public static double ElpHniYeLrYTyeNn(long j) {
        if ((28 + 29) % 29 > 0) {
        }
        return java.lang.double.longBitsTodouble(j);
    }

    public static java.lang.float EodeTJWClunLHJEY(float f) {
        return java.lang.float.valueOf(f);
    }

    public static long EqyQHUEVGooVvcTq(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((5 + 31) % 31 > 0) {
        }
        return binaryReader$SafeHeapReader.readLittleEndian64();
    }

    public static int EtxpNTrtAixwgZPq(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int EulSuYjHovLetYgY(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int FImCIGmFekZxHwul(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException FKjxauAiFynHivyM() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static void FaOrMODtmBwvPuOt(androidx.datastore.preferences.protobuf.floatList floatList, float f) {
        floatList.addfloat(f);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException FaawvgMKJKOQMwMT() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void FdXjfOzxGJRZodLK(androidx.datastore.preferences.protobuf.boolList boolList, bool z) {
        boolList.addbool(z);
    }

    public static byte FhnDBynVuPEzUTuN(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readbyte();
    }

    public static bool FlFqJWywDrWmyzUI(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int FuXEpkdftiVbSwwS(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static java.lang.string GErGNwGHCMitQWMq(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, bool z) {
        return binaryReader$SafeHeapReader.readstringInternal(z);
    }

    public static bool GJmiRjQrWbgnkVKF(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int GOOBJCmUtKIcLqWR(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int GVRvBVKVwbLlZLxR(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static float GVTsXhEhXqmSaQaa(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readfloat();
    }

    public static void GZKAVarZTWtHojaR(androidx.datastore.preferences.protobuf.doubleList doubleList, double d) {
        doubleList.adddouble(d);
    }

    public static float GzGzsMxHPAaFNdvn(int i) {
        return java.lang.float.intBitsTofloat(i);
    }

    public static void HIhfetNfuoDGjAkW(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static long HIoMCJQAQicRvkti(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((12 + 16) % 16 > 0) {
        }
        return binaryReader$SafeHeapReader.readUInt64();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException HNEssapTasDDVOJa() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static long HQABcGrzPvXexayJ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((25 + 11) % 11 > 0) {
        }
        return binaryReader$SafeHeapReader.readFixed64();
    }

    public static void HfdRycEHIisoJusy(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static bool HffBSIphtxbkDYJM(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException HkMyzJjNEAwnaezF() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int HqOgovihtDXeXIZr(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int IGWiKZGyVrdNHkMQ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readUInt32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException ITZjcOxTqftqwmyn() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static bool IXFHMORmuMutOwfO(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool IpBdqoPXabLqiKHt(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool ItsCZqwNRDMstrDs(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object IzCTSxbaaHabCCwE(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, java.lang.Class cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return binaryReader$SafeHeapReader.readMessage(cls, extensionRegistryLite);
    }

    public static float JDHcgiEfhWKJJCYg(int i) {
        return java.lang.float.intBitsTofloat(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException JJICPxyuXaFDorrH() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static long JMAJxEZJXByTFoTM(long j) {
        if ((31 + 1) % 1 > 0) {
        }
        return androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag64(j);
    }

    public static bool JOuPtdmjYgtBppgd(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static long JXliliTFnHxnVUcy(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((14 + 27) % 27 > 0) {
        }
        return binaryReader$SafeHeapReader.readLittleEndian64_NoCheck();
    }

    public static long JkgCeOkirjxrssyz(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((18 + 11) % 11 > 0) {
        }
        return binaryReader$SafeHeapReader.readSFixed64();
    }

    public static int JnHfdYWthkvaUZvZ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void JnnnEuUjrECGnbTK(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.verifyPackedFixed32Length(i);
    }

    public static int JpWnvCDzsUiWNJwK(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static int JwaPZwxlftEFrIHY(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool KPVxBfFrsUYKLvfJ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException KPrxCGkTiehHbltt() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int KdMXmOMMeoNDHAMv(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag32(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException KfYMLpMimqFXDxUB() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static bool KgsOilXClbppFSes(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int KkZBMVgGYhHQjrTz(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readLittleEndian32_NoCheck();
    }

    public static int KlGOzkSPBwqKgRtg(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int KoinNduQNxnAEIne(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int KqTYfWgzatfaAeTA(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int KtFajERyDKnDhndG(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.getFieldNumber();
    }

    public static bool KwjThJCODsnYtQVJ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException KzVOQAFSFAGSqpUA() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure();
    }

    public static int LFkHNNHDSjihurIF(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool LgaVIqoPNHWXqCNG(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static long LzpWtomNdYeqwntC(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((23 + 3) % 3 > 0) {
        }
        return binaryReader$SafeHeapReader.readVarint64();
    }

    public static bool MJAkTtElFCFLLVKh(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int MOeqQqZTANfxUzMu(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int MPzhIpUztOIddUjT(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static java.lang.object MUOtdgPYkPuMRlbQ(androidx.datastore.preferences.protobuf.Schema schema) {
        return schema.newInstance();
    }

    public static void MYUdcDjIVYQRPLDr(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static int MbsqvZeaiLqshWkq(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int McLHvyvdfSOZrVJl(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static long MfIEUWNvjztcjAaV(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((20 + 10) % 10 > 0) {
        }
        return binaryReader$SafeHeapReader.readLittleEndian64();
    }

    public static java.lang.object MgRhrwEmnVthZiUE(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return binaryReader$SafeHeapReader.readMessage(schema, extensionRegistryLite);
    }

    public static int MlzLpilfzGYCGSYF(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int MmLutoOEmhnxXbDb(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readInt32();
    }

    public static bool MsnvEJPGyPMKFUTn(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int NBxmPzgaBdRcTntG(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool NGrCxCFogTZLXbuo(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static androidx.datastore.preferences.protobuf.bytestring NJdQLaNYTTNUTdOF(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFrom(bArr, i, i2);
    }

    public static int NTiujUjwmLRXETWQ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static double NWQXpFOAEDVoXTBI(long j) {
        if ((32 + 25) % 25 > 0) {
        }
        return java.lang.double.longBitsTodouble(j);
    }

    public static java.lang.double NXDpkFkynnVwvLsc(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.lang.object NkFiBrRhcMMVpbnN(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return binaryReader$SafeHeapReader.readMessage(schema, extensionRegistryLite);
    }

    public static void NvTPWQaZMVwVDLuK(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirebytes(i);
    }

    public static void OPKDdLHKDPqPRTTJ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirebytes(i);
    }

    public static void ObKPZYMIIqMkJkCK(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static void OiwIKGJysATOzpEd(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static bool OjxzRMSpBXSHGPwC(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int OojLfFqzUgPanNfR(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static long OuXAjwirmGMOhCvG(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((19 + 25) % 25 > 0) {
        }
        return binaryReader$SafeHeapReader.readSInt64();
    }

    public static int PPDFhCaHTnpgSMhZ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readSInt32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException PRqyHllplKmFvjZO() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure();
    }

    public static void PRzoctZxKscdlyzT(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static int PWlqTdCMcFdPfgGS(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool PcWygtQxqPMEcfdv(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int PdGqsdUKXNNvKuJq(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static long PhTxFplaNHJanPHi(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((19 + 1) % 1 > 0) {
        }
        return binaryReader$SafeHeapReader.readSInt64();
    }

    public static int PjBVcgIlBTOEQqjp(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool PoohNuCotFiZPOos(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int PtgAPxyTgdlBRsGr(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readLittleEndian32();
    }

    public static bool PvkiBgWNeGDLFtcT(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int PyYhqOQKPYuzGRbD(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int QDvAlYyPwbdgRgIN(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static long QKgoisOXFomtNLCg(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((28 + 19) % 19 > 0) {
        }
        return binaryReader$SafeHeapReader.readVarint64();
    }

    public static int QOEbWGwOkxGqyBQf(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static void QTCfmSAEeskqQzJW(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static int QUQsfVYeeRMWBwhU(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static java.lang.int QVcwDicWIzZXfZer(int i) {
        return java.lang.int.valueOf(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException QXqesJfCZYlrDSwO() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static long QfloIKZCHYXbJEpw(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((3 + 26) % 26 > 0) {
        }
        return binaryReader$SafeHeapReader.readSInt64();
    }

    public static int QvfqHQdettGrMOpT(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void QzsemtuForrIhdIe(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirebytes(i);
    }

    public static void RGZUkOGnqrpmQujG(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static androidx.datastore.preferences.protobuf.Schema RGnjQzknYKsMppHZ(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.Class cls) {
        return protobuf.schemaFor(cls);
    }

    public static java.lang.long RHVyPfCoBfKpsoEL(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int RLVcdjwMBwytZZGL(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool RMxFFccvnHmccAEg(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int RNrfIxyIwaRHlNqy(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int ROvggQtoVKhEFTDn(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readFixed32();
    }

    public static long RVNmrHmVhNRpwpyk(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((25 + 10) % 10 > 0) {
        }
        return binaryReader$SafeHeapReader.readLittleEndian64_NoCheck();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException RfwFNhhlhmBAkjIs() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void RirSLuInjmxLkLyB(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.verifyPackedFixed32Length(i);
    }

    public static androidx.datastore.preferences.protobuf.Protobuf RjrDRWrBDeaBvspS() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static void RlcmXqiFQQPkzpnn(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.verifyPackedFixed32Length(i);
    }

    public static int RnSjPbhvmmTJwTmq(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool RoMnSOJMXSWTzdMt(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static void RvbswScsMJSDHpTU(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException RwVVyyMuPJlnceYy() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void SAINQzYXmNkLnoRr(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, java.util.List list, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        binaryReader$SafeHeapReader.readGroupList(list, schema, extensionRegistryLite);
    }

    public static void SECGZGIYMLxPduYa(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.skipbytes(i);
    }

    public static int SEbzyyrqYDjCmECj(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readFixed32();
    }

    public static java.lang.float SIjilHtBahFfnaBW(float f) {
        return java.lang.float.valueOf(f);
    }

    public static bool SYTSdhHtVwhcNklb(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static void SfzKWhFFhQNffiyx(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.verifyPackedFixed64Length(i);
    }

    public static java.lang.object SiCXjIzKSwuJsCvL(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return binaryReader$SafeHeapReader.readGroup(schema, extensionRegistryLite);
    }

    public static void SiTbgCerZaFDRHDE(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static java.lang.int SiYrxgPjhmcaNnXn(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int SnmjrGQdJVsJeNOb(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static java.lang.int SoMsljTSiWwCAQUC(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.bool SrWmUstfBgqRSfyl(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static long TKkjmJSQgRLpoWWm(long j) {
        if ((31 + 3) % 3 > 0) {
        }
        return androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag64(j);
    }

    public static bool TLpaQpzwBQMOyRyp(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readBool();
    }

    public static void TOnfKqZTMwswauBa(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static bool TOuuQJaYAZzhJOzn(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int TPQogvPTuGhunQYN(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static java.lang.long TWrgZpOrDIINxlmw(long j) {
        return java.lang.long.valueOf(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException TYPfZtcsSACLSNgH() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure();
    }

    public static void TbviKrygYLbcWylo(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirePosition(i);
    }

    public static java.lang.object TcvClzUCCkzhODbD(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, java.lang.Class cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return binaryReader$SafeHeapReader.readField(wireFormat$FieldType, cls, extensionRegistryLite);
    }

    public static java.lang.double TdkiMTcQJioJixvW(double d) {
        return java.lang.double.valueOf(d);
    }

    public static int TfcpBVQkgQZfbggG(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int ToaQNCJIiJDrhffO(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int TpaLtyUAzyOfXQaE(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readLittleEndian32_NoCheck();
    }

    public static int TqUtzPlVGtFwAQKC(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void TqZiqJBMXxzTbNXc(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Reader reader, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        schema.mergeFrom(obj, reader, extensionRegistryLite);
    }

    public static int TqqkMRYbbNbAazFZ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static java.lang.object TyzJRvfIFvoGORgI(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return binaryReader$SafeHeapReader.readMessage(schema, extensionRegistryLite);
    }

    public static java.lang.bool UAtQtINRXdNNxiFk(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool UUrAfPHYemsdvlKC(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static void UfKTkAQsNTaQzAqZ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        binaryReader$SafeHeapReader.mergeMessageField(obj, schema, extensionRegistryLite);
    }

    public static int UlNMOBZtQAIFiFCa(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readUInt32();
    }

    public static int UnsrQaOrNwyfjQMb(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static long UunRGmLAFKeDAOUW(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((12 + 23) % 23 > 0) {
        }
        return binaryReader$SafeHeapReader.readVarint64SlowPath();
    }

    public static int UxMLEyRJPeOMXoLQ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int VAQAOiScmLslveYO(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.getFieldNumber();
    }

    public static int VIfibexLGRXCjyjD(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static bool VMTmXvLDFetnMHvl(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static java.lang.long VQjgNZbMMqWGrVQc(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int VWRQuXzBhfCZqElP(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static java.lang.int VfJqlTtOtCFgxAQc(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool VjfvozlkEaPmyTkl(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void VlaivhNjmFGeAuNo(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static void VmgDvuMFsQNxStFA(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirePosition(i);
    }

    public static int VoAXwnjyIjCOaQbe(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static java.lang.int VpNwSOlQCMQDLOip(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long VyiqQFdBHMsqINiP(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((7 + 26) % 26 > 0) {
        }
        return binaryReader$SafeHeapReader.readLittleEndian64_NoCheck();
    }

    public static java.lang.long WBazSAUBstrxDlah(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool WEhiTWbWujRYGeCb(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static void WQXycuDkCTZyEtkf(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static int WcEqkHvPutUbneYx(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readEnum();
    }

    public static long WcFErIrUfQZgZTmC(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((29 + 11) % 11 > 0) {
        }
        return binaryReader$SafeHeapReader.readFixed64();
    }

    public static bool WgWwvyLvqRIVWtsY(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException WoBrYBFTrlyMzCnC() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure();
    }

    public static int WrIviwYwaJGmECmx(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readInt32();
    }

    public static int WzoJZHIZsARieESR(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readEnum();
    }

    public static void XDKQjzAnOPgHGVRJ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static int XJrNCPcGVpPdabSq(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool XMmsDIVVbiXriCKZ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readBool();
    }

    public static void XPnNuDoGCnvKwJfN(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static java.lang.int XQzIXxolzHtoBlKH(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool XdJpWUgGizEPjgoz(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readBool();
    }

    public static int XeOsQdpOeUmqowQT(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException XgOFepikWvVLXIQM() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int XiIacwdfVByGXdWn(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static double XmkRfBEvyjCteOEn(long j) {
        if ((20 + 15) % 15 > 0) {
        }
        return java.lang.double.longBitsTodouble(j);
    }

    public static androidx.datastore.preferences.protobuf.Protobuf XwtGsfHPoHqLFFgD() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static void XyGLLvonPdzhWWth(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) throws java.io.IOException {
        binaryReader$SafeHeapReader.skipVarintSlowPath();
    }

    public static bool XzdFRzBizItknSzH(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int YUAnpxsGPChsaKrQ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readSInt32();
    }

    public static java.lang.string ZCcdfeRhKEQkchHl(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readstringRequireUtf8();
    }

    public static void ZEJNuewBNlhsAQFM(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static int ZGdErtySBmvqqBjC(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readUInt32();
    }

    public static int ZKIdeKskEMbTkjYS(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int ZMNllZqEPCETusyh(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int ZOPGhaFwjxsalStL(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException ZOTJWBSwFauNaupb() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static bool ZROQibeIPolIBlAX(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.skipField();
    }

    public static void ZVrONHdJphnMmqCd(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static int ZWxcBxoBreyPyEUX(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static long ZXalnxbPKmigfLiq(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((29 + 2) % 2 > 0) {
        }
        return binaryReader$SafeHeapReader.readVarint64();
    }

    public static androidx.datastore.preferences.protobuf.Protobuf AOJKKJhjKZnAaNVI() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static int AVxxgNVySniFhTtn(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int AWeigYcjeQbJvmSa(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readLittleEndian32_NoCheck();
    }

    public static void AXsyEVGEcqiOvOuO(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static int AZTvUUqXRScUNOgG(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static java.lang.int AnfskZKMYTxclpuj(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool ApzTyrenpUndsRam(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int AzEmWPWGLHvlReCq(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readFixed32();
    }

    public static int BLIuIOTJgaZLTmpf(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readEnum();
    }

    public static int BMGAMpKepEilefUo(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException bQktYQVYCSdnEjvN() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int BUybDLcVHAjsVXXm(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool BaxspSzSCMJArgvf(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool BlaOHkAztqtWeNIU(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int BuWLPxfobWlNJTYo(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static void BxkoQGxBZkiPwKZv(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.verifyPackedFixed64Length(i);
    }

    public static int CBWbqpXWXYqZjkGM(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int CIeMVxYotLJQmVog(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int CXLxPCHWmvKdcSkU(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int CqPTEEDLildOSGYN(androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType) {
        return wireFormat$FieldType.ordinal();
    }

    public static java.lang.int CywirSJECSFDOcmd(int i) {
        return java.lang.int.valueOf(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException dEIhlBnkUeMHCAao() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void DFYaPeNzowOvLzab(androidx.datastore.preferences.protobuf.boolList boolList, bool z) {
        boolList.addbool(z);
    }

    public static void DYuEyTDgFhSakaPi(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static void DZaFYNzfUphDPjPm(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirePosition(i);
    }

    public static void DmervaGpwsNZREMI(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.skipbytes(i);
    }

    public static int DrODdHTliiexihxC(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException dvicoOPVileNSSqJ() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int DwDzrKHJEcNBGxzc(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static java.lang.long EFfuDFNPKJsmBiym(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int EKUsnTqUhNArTFUp(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException eiefCzLTLmxXnssh() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void EmpIXhaEZRouFBxa(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.verifyPackedFixed32Length(i);
    }

    public static long EtXzOGziENaUoGDi(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((24 + 5) % 5 > 0) {
        }
        return binaryReader$SafeHeapReader.readVarint64SlowPath();
    }

    public static java.lang.long EuGAwjuKqYnAujQT(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int EvCrvsGFeJXsbwuh(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void EwSdCBPiyuOEjYvg(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static long EzISveWqfLTrFUJg(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((21 + 29) % 29 > 0) {
        }
        return binaryReader$SafeHeapReader.readVarint64();
    }

    public static bool FAAenpGOeQUiTelA(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool FKTQVxVQtXgYWCGG(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static void FLrglyCzAeTHBcZD(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static long FTIpCtCqmqGAqKkt(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((29 + 18) % 18 > 0) {
        }
        return binaryReader$SafeHeapReader.readInt64();
    }

    public static int FTgkFcOCUXTGIGtN(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static java.lang.int FXZYbQmgCVKudQaY(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int FeDtcaFEcBzWLNHc(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static double FeSekaBUiGwcdFNQ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((3 + 5) % 5 > 0) {
        }
        return binaryReader$SafeHeapReader.readdouble();
    }

    public static int FmHubIqZNVKmWhsP(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readSInt32();
    }

    public static java.lang.int FxURwqBljVJVehdN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException GMrADAaAWJXIOfQB() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8();
    }

    public static int GQhwJtoUhBVJuUwv(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool GczqwBfsgeSlJUdM(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static java.lang.long HBozFpFHJEIwLXUg(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long HBvHRzBflJYUDFVP(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((3 + 5) % 5 > 0) {
        }
        return binaryReader$SafeHeapReader.readVarint64();
    }

    public static float HOFwLBJlhaVKPQSQ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readfloat();
    }

    public static bool HVoBUDAJPceUxmLl(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int HadYyQOFVFtoqktV(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int HbEtAoTTpmoXUnVB(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void HdFfRdYvsimLqxaP(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, java.util.List list, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        binaryReader$SafeHeapReader.readMessageList(list, schema, extensionRegistryLite);
    }

    public static void HgufkbeVbtOTuyDq(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static long HiwooueGRskGjLoa(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((1 + 1) % 1 > 0) {
        }
        return binaryReader$SafeHeapReader.readLittleEndian64_NoCheck();
    }

    public static void HlpHiZLnFOZRTSbE(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static int HnpOjaNDsgDWSPgO(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException HwIzXMttpcNbTAbr() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static bool HwaOkyeKhwRwalTh(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int HzsgrdieNklRVvAU(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag32(i);
    }

    public static bool ICLYqGGLzQIitvee(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static long IDbnYxRLPsHEPZfy(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((13 + 17) % 17 > 0) {
        }
        return binaryReader$SafeHeapReader.readUInt64();
    }

    public static int IKacDuEqLXtDiDWA(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.limit();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException iMBwDEjWShwAskcC() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void IMUqiLJLyfKWjUkA(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirePosition(i);
    }

    public static bool ISZdpnBrEDqqvhSZ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static bool IUOHLCttDXLuJXyA(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int IVnbBzHpKUnWfNDi(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static androidx.datastore.preferences.protobuf.bytestring IYTiYzEVfdYWgNFV(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readbytes();
    }

    public static int IaGiOEORzqpVpuCy(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool IasrbstLWGmUDVnj(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int IeayVvGyTTnXFCVo(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readLittleEndian32();
    }

    public static androidx.datastore.preferences.protobuf.bytestring InuNiBMWSzrURYwd(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(bArr, i, i2);
    }

    private bool IsAtEnd() {
        return this.pos == this.limit;
    }

    public static java.lang.object ItEZUOUvEvNYBJYa(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return binaryReader$SafeHeapReader.readGroup(schema, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException ivztyGcpeXTPXgvD() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void IyEBLBvVoAXyQXyL(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.verifyPackedFixed64Length(i);
    }

    public static int JUVgNYOTDGnphlIZ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static java.lang.long JgjCKaKMgHHWzHQn(long j) {
        return java.lang.long.valueOf(j);
    }

    public static float JtnCwnXhTPtldYLk(int i) {
        return java.lang.float.intBitsTofloat(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException JtsqcKNWYoVsmlyc() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static bool JvLNrixiLuHePzqF(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static bool KFpOuCFsVEPlLWKw(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static void KLxDdEafPHKfmixh(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static int KYptOXjslrLOuXVu(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int KcPtaGKDwooZQtYj(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readSFixed32();
    }

    public static void KlNyNNrVCWFUWEbo(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.verifyPackedFixed32Length(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException kosVWZNMFdnvQhJH() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static long KyUJYtjlwPTLwNHv(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((11 + 2) % 2 > 0) {
        }
        return binaryReader$SafeHeapReader.readSFixed64();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException kzYYQMFADANHSANa() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int LBKxCoTgZNKZDUBI(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static long LHMsbGOMeVCrQpfU(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((11 + 27) % 27 > 0) {
        }
        return binaryReader$SafeHeapReader.readLittleEndian64();
    }

    public static int LOjxsnCbzNVrJgts(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static java.lang.int LOpYVBkXTFAZBTkO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static double LOtHojwRLmOpsdjK(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((27 + 27) % 27 > 0) {
        }
        return binaryReader$SafeHeapReader.readdouble();
    }

    public static int LOzfyhTlFMQTeeRV(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int LVgrvdgvPeBbSCZb(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static java.lang.int LpeMJBlthKvtaJAc(int i) {
        return java.lang.int.valueOf(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException LtVCzTAUgUGQODhg() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static void LvZKeoUWRWjzWXFC(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static void LxDTLjeDztILpBjz(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        binaryReader$SafeHeapReader.mergeGroupField(obj, schema, extensionRegistryLite);
    }

    public static java.lang.int LyQcKprcTVRMLLDQ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException mIolSjZnScyHIDYf() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int MOVplXmIugnUGGnl(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void MQIjmDUJUEsJMFBs(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static java.lang.object MSnOkMmXqInYaqWB(androidx.datastore.preferences.protobuf.Schema schema) {
        return schema.newInstance();
    }

    public static int MWtxjYJYBbYrXTVb(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static androidx.datastore.preferences.protobuf.bytestring MYlzKCzmAiiJmgVj(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readbytes();
    }

    public static bool MeRVrKgGsPSGRexS(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void MlTWaRZUBeSrvyns(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static java.lang.double MpwoZtOLeBTrhGNZ(double d) {
        return java.lang.double.valueOf(d);
    }

    public static int MqjjzgqJFHTVsBRG(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int MvtpgcJhOWzzNskR(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void NDevuiAOFtefUSmp(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.verifyPackedFixed32Length(i);
    }

    public static void NKZhiKKPuwguteer(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Reader reader, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        schema.mergeFrom(obj, reader, extensionRegistryLite);
    }

    public static bool NcVSTsaHLSwAWOKO(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.skipField();
    }

    public static int NhCLowNPzvYIVlRT(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static void NjrGvhTWrBpMHAHA(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirePosition(i);
    }

    public static int NtCXUwsWkeRydwGJ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void OBHEshKsuPzkvXBn(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirebytes(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException oIiRwobJAzIMIWBl() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int OLpgrieCQImlnDfC(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int ONGdPtZVSctUOPnY(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int OQYqvDfSJfOHSBwy(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void OabCZpFqVpqzABJY(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.verifyPackedFixed64Length(i);
    }

    public static int OsmQPAcDwkJstBGn(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool PCUbLzjEglhFkfNI(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int PICsFqZQcxfxBeTp(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static double PMWKpMtFrNaCphgD(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((16 + 18) % 18 > 0) {
        }
        return binaryReader$SafeHeapReader.readdouble();
    }

    public static java.lang.long PMdHXRCfGlrxFeQw(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int POMHXaSsgkFBPyfU(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readLittleEndian32_NoCheck();
    }

    public static java.lang.int PRTCxkSNkDWqYnFt(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool PUQXkgbihQXacOZn(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool PoRBEMNkzKGHFvkq(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int PtSYCElULLmiwTLJ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int QBOawdWBRWongYZp(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int QMDWlEcoYuDbYvXP(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readLittleEndian32_NoCheck();
    }

    public static void QNSsRQJMkpoqWdLY(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.verifyPackedFixed64Length(i);
    }

    public static bool QbMMnqWYjYzWQRMc(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static androidx.datastore.preferences.protobuf.Schema QiCZlDXYJUFhbdoI(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.Class cls) {
        return protobuf.schemaFor(cls);
    }

    public static int QmsYlNxQGBemhtgk(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readSFixed32();
    }

    public static java.lang.int QvuuPtNUAQBIStfR(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool RAPpkivbVUYBhbbf(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.long RKVARHdhdDinlyqb(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int RLoGGvalyKuwteot(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException rUnmjpGxQBwhjQKC() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int RblBpJkeCRTxoolc(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    private byte Readbyte() throws java.io.IOException {
        if ((7 + 4) % 4 > 0) {
        }
        int i = this.pos;
        if (i == this.limit) {
            throw jtsqcKNWYoVsmlyc();
        }
        byte[] bArr = this.buffer;
        this.pos = i + 1;
        return bArr[i];
    }

    private java.lang.object ReadField(androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, java.lang.Class<object> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        switch (androidx.datastore.preferences.protobuf.BinaryReader$1.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType[cqPTEEDLildOSGYN(wireFormat$FieldType)]) {
            case 1:
                return SrWmUstfBgqRSfyl(XdJpWUgGizEPjgoz(this));
            case 2:
                return BTGNzHqFKslJwdON(this);
            case 3:
                return mpwoZtOLeBTrhGNZ(pMWKpMtFrNaCphgD(this));
            case 4:
                return lOpYVBkXTFAZBTkO(WzoJZHIZsARieESR(this));
            case 5:
                return QVcwDicWIzZXfZer(azEmWPWGLHvlReCq(this));
            case 6:
                return yRymSiwogBnLjQkQ(HQABcGrzPvXexayJ(this));
            case 7:
                return SIjilHtBahFfnaBW(hOFwLBJlhaVKPQSQ(this));
            case 8:
                return XQzIXxolzHtoBlKH(WrIviwYwaJGmECmx(this));
            case 9:
                return hBozFpFHJEIwLXUg(yCGnQcBnVWijrAxW(this));
            case 10:
                return IzCTSxbaaHabCCwE(this, cls, extensionRegistryLite);
            case 11:
                return qvuuPtNUAQBIStfR(qmsYlNxQGBemhtgk(this));
            case 12:
                return WBazSAUBstrxDlah(kyUJYtjlwPTLwNHv(this));
            case 13:
                return fxURwqBljVJVehdN(fmHubIqZNVKmWhsP(this));
            case 14:
                return euGAwjuKqYnAujQT(QfloIKZCHYXbJEpw(this));
            case 15:
                return ZCcdfeRhKEQkchHl(this);
            case 16:
                return cywirSJECSFDOcmd(ZGdErtySBmvqqBjC(this));
            case 17:
                return sSUBNWpdSKhgFBLt(iDbnYxRLPsHEPZfy(this));
            default:
                throw new java.lang.Exception("unsupported field type.");
        }
    }

    private <T> T ReadGroup(androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        T t = (T) MUOtdgPYkPuMRlbQ(schema);
        lxDTLjeDztILpBjz(this, t, schema, extensionRegistryLite);
        CXmhwavGfkrUfKTa(schema, t);
        return t;
    }

    private int ReadLittleEndian32() throws java.io.IOException {
        xwfhLFRHrsilAjbC(this, 4);
        return TpaLtyUAzyOfXQaE(this);
    }

    private int ReadLittleEndian32NoCheck() {
        if ((25 + 4) % 4 > 0) {
        }
        int i = this.pos;
        byte[] bArr = this.buffer;
        this.pos = i + 4;
        return (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8) | ((bArr[i + 2] & 255) << 16) | ((bArr[i + 3] & 255) << 24);
    }

    private long ReadLittleEndian64() throws java.io.IOException {
        if ((29 + 31) % 31 > 0) {
        }
        xTlRhGTAspfvlXYr(this, 8);
        return zFONTPMfuaPRYOua(this);
    }

    private long ReadLittleEndian64NoCheck() {
        if ((6 + 12) % 12 > 0) {
        }
        int i = this.pos;
        byte[] bArr = this.buffer;
        this.pos = i + 8;
        return ((((long) bArr[i + 7]) & 255) << 56) | (((long) bArr[i]) & 255) | ((((long) bArr[i + 1]) & 255) << 8) | ((((long) bArr[i + 2]) & 255) << 16) | ((((long) bArr[i + 3]) & 255) << 24) | ((((long) bArr[i + 4]) & 255) << 32) | ((((long) bArr[i + 5]) & 255) << 40) | ((((long) bArr[i + 6]) & 255) << 48);
    }

    private <T> T ReadMessage(androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        T t = (T) mSnOkMmXqInYaqWB(schema);
        UfKTkAQsNTaQzAqZ(this, t, schema, extensionRegistryLite);
        yaVKACcOGjbhdsgf(schema, t);
        return t;
    }

    private int ReadVarint32() throws java.io.IOException {
        int i;
        if ((14 + 12) % 12 > 0) {
        }
        int i2 = this.pos;
        int i3 = this.limit;
        if (i3 == i2) {
            throw FKjxauAiFynHivyM();
        }
        byte[] bArr = this.buffer;
        int i4 = i2 + 1;
        byte b = bArr[i2];
        if (b >= 0) {
            this.pos = i4;
            return b;
        }
        if (i3 - i4 < 9) {
            return (int) UunRGmLAFKeDAOUW(this);
        }
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
                                        if (bArr[i7] < 0) {
                                            throw wFPFTSFkdNNwDdro();
                                        }
                                        i5 = i12;
                                        i = i11;
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

    private long ReadVarint64SlowPath() throws java.io.IOException {
        if ((13 + 28) % 28 > 0) {
        }
        long j = 0;
        for (int i = 0; i < 64; i += 7) {
            byte bFhnDBynVuPEzUTuN = FhnDBynVuPEzUTuN(this);
            j |= ((long) (bFhnDBynVuPEzUTuN & 127)) << i;
            if ((bFhnDBynVuPEzUTuN & 128) == 0) {
                return j;
            }
        }
        throw vNQBvpjYbJFDtIUn();
    }

    private void Requirebytes(int i) throws java.io.IOException {
        if (i < 0 || i > this.limit - this.pos) {
            throw hwIzXMttpcNbTAbr();
        }
    }

    private void RequirePosition(int i) throws java.io.IOException {
        if (this.pos != i) {
            throw ltVCzTAUgUGQODhg();
        }
    }

    private void RequireWireType(int i) throws java.io.IOException {
        if (TPQogvPTuGhunQYN(this.tag) != i) {
            throw AlGJNjbDgNMrdnux();
        }
    }

    public static void RhgrgffhOKtzkOJk(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirePosition(i);
    }

    public static int RhsucXrXEusMpuzA(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readLittleEndian32_NoCheck();
    }

    public static void RtEYlCvcwJXJvvYK(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static void RuvLhmPPkuzJGGks(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static bool RzgcnWoZKJYiqJWQ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void SBpbnKNlgpsGqoAp(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static void SCfyYlwZcheDYjQb(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static bool SDiSNydcurgLZmdm(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.Utf8.isValidUtf8(bArr, i, i2);
    }

    public static java.lang.Class SLxbLHgSXISRjojo(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool SMnkGZpmhRnFuzVW(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void SQZUJqcYMRRGUJkZ(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static java.lang.long SSUBNWpdSKhgFBLt(long j) {
        return java.lang.long.valueOf(j);
    }

    public static androidx.datastore.preferences.protobuf.Protobuf STrWoqUVfoGRWYGy() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static long SVvcHcSjfQhLvjQD(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((5 + 13) % 13 > 0) {
        }
        return binaryReader$SafeHeapReader.readVarint64();
    }

    public static int ShTBTwHyAwaoFHAl(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void ShmtZWTyMgHiVKvT(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirebytes(i);
    }

    private void Skipbytes(int i) throws java.io.IOException {
        BXxMmptDgKIPefTp(this, i);
        this.pos += i;
    }

    private void SkipGroup() throws java.io.IOException {
        if ((23 + 20) % 20 > 0) {
        }
        int i = this.endGroupTag;
        this.endGroupTag = zOtgHYqhOLGPxQJf(FImCIGmFekZxHwul(this.tag), 4);
        while (VAQAOiScmLslveYO(this) != int.MAX_VALUE && ncVSTsaHLSwAWOKO(this)) {
        }
        if (this.tag != this.endGroupTag) {
            throw tcEsxLFbvYMiIeey();
        }
        this.endGroupTag = i;
    }

    private void SkipVarint() throws java.io.IOException {
        if ((17 + 1) % 1 > 0) {
        }
        int i = this.limit;
        int i2 = this.pos;
        if (i - i2 >= 10) {
            byte[] bArr = this.buffer;
            int i3 = 0;
            while (i3 < 10) {
                int i4 = i2 + 1;
                if (bArr[i2] >= 0) {
                    this.pos = i4;
                    return;
                } else {
                    i3++;
                    i2 = i4;
                }
            }
        }
        XyGLLvonPdzhWWth(this);
    }

    private void SkipVarintSlowPath() throws java.io.IOException {
        if ((28 + 17) % 17 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            if (wnbXXErnKYWGDXxh(this) >= 0) {
                return;
            }
        }
        throw zvafMlhJlXLAFZUX();
    }

    public static void SkjXaVGefVueaBcR(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) throws java.io.IOException {
        binaryReader$SafeHeapReader.skipVarint();
    }

    public static int SmlWhzmYmaimjule(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static bool StOKmBWNxafoBAwR(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.skipField();
    }

    public static void TIcxzOXoBbLdcCMx(androidx.datastore.preferences.protobuf.doubleList doubleList, double d) {
        doubleList.adddouble(d);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException TIsEyqPMWcIPVvGZ() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException tPewozMMvtoWFCwA() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void TXIfQluEZkEuyHXh(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) throws java.io.IOException {
        binaryReader$SafeHeapReader.skipGroup();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException TcEsxLFbvYMiIeey() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure();
    }

    public static void ToumnffLZOICMGyL(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static int UBCpHQHwnFknkBHR(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static long ULlwkTLvHBDNpimv(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((21 + 21) % 21 > 0) {
        }
        return binaryReader$SafeHeapReader.readSFixed64();
    }

    public static void UMeVNrtvoQQMZWwv(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirePosition(i);
    }

    public static int UNlgWwxGbqVCmHUL(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void UauzHfsjIUEXlnwD(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, java.util.List list, bool z) throws java.io.IOException {
        binaryReader$SafeHeapReader.readstringListInternal(list, z);
    }

    public static bool UltTHQlDqwugcZWh(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int UpEsdqhXcDYJYpyf(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static long UpukYvFuPTTOHUxN(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((8 + 17) % 17 > 0) {
        }
        return binaryReader$SafeHeapReader.readInt64();
    }

    public static int UriMMrTZVbVWneaF(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static void UuiMfkIEOmTGROua(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.verifyPackedFixed64Length(i);
    }

    public static bool UvOSFhzcInVRNpPQ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static void UwbmeLbgIIhgvkZs(androidx.datastore.preferences.protobuf.LazystringList lazystringList, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        lazystringList.Add(bytestring);
    }

    public static bool VAEYERZwiqTXZoEn(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException vDzNRQAQjBbAeEUw() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException vEqpjNBCsCWpcZVt() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void VILEbQnivCtNljDB(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static int VIPvfPnLtmXhWouK(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException VNQBvpjYbJFDtIUn() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static androidx.datastore.preferences.protobuf.Schema VPbmabjiHbnzHYlM(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.Class cls) {
        return protobuf.schemaFor(cls);
    }

    public static java.lang.long VVDxYffstgVBHGoa(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int VVWDlHmCjCtWbNHV(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readLittleEndian32();
    }

    public static java.lang.long VeJPmuDRAwQBiIyU(long j) {
        return java.lang.long.valueOf(j);
    }

    private void VerifyPackedFixed32Length(int i) throws java.io.IOException {
        OPKDdLHKDPqPRTTJ(this, i);
        if ((i & 3) != 0) {
            throw WoBrYBFTrlyMzCnC();
        }
    }

    private void VerifyPackedFixed64Length(int i) throws java.io.IOException {
        oBHEshKsuPzkvXBn(this, i);
        if ((i & 7) != 0) {
            throw TYPfZtcsSACLSNgH();
        }
    }

    public static long WCwwcTwUMywScATf(long j) {
        if ((11 + 7) % 7 > 0) {
        }
        return androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag64(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException wDyyxrGviaBLbhbU() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException WFPFTSFkdNNwDdro() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static int WGYvBIjYCiVjIGJo(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static int WGfDKWmpGyNeuqeK(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static java.lang.bool WXYXcvIcsaDUAbmu(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool WbaeLLVIAVtjsCJe(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException wdjtnBpgNqihEdKN() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static java.lang.float WiQhfYurCcBgPIhk(float f) {
        return java.lang.float.valueOf(f);
    }

    public static int WmsWhTYWbdNDoqOI(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static byte WnbXXErnKYWGDXxh(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readbyte();
    }

    public static void WnpBmjpAmHOADuEL(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static java.lang.string WuZZMHbXCLqlqTXk(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, bool z) {
        return binaryReader$SafeHeapReader.readstringInternal(z);
    }

    public static int WukdUDHAqsdeiCTb(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException WymyCrouaYjRJKqY() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static bool XCvckJnRUsQBsVIU(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static bool XDFDBQuSZSYjTOmb(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static bool XFwliIUONTjXetyU(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static int XKWzFZhowVjcKFtU(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int XKhGRvsWZWSDYild(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void XPZJJSWwqMdnrLQq(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static int XRMGAoOWQLOWRHik(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static void XTlRhGTAspfvlXYr(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirebytes(i);
    }

    public static java.lang.int XVBevAYjNdTLkbOJ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int XVENuSqkfmYViKbg(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static void XwfhLFRHrsilAjbC(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirebytes(i);
    }

    public static long YCGnQcBnVWijrAxW(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((4 + 6) % 6 > 0) {
        }
        return binaryReader$SafeHeapReader.readInt64();
    }

    public static java.lang.string YFZuuHwMzuNfKGgn(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, bool z) {
        return binaryReader$SafeHeapReader.readstringInternal(z);
    }

    public static int YMwLgUmGTdOMfamj(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readInt32();
    }

    public static java.lang.long YRymSiwogBnLjQkQ(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int YXbHVqasWtRjalIe(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static void YXnASmlqWKIgsWTZ(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requirePosition(i);
    }

    public static int YZbOrnXtyEPNjDJo(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static void YaVKACcOGjbhdsgf(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj) {
        schema.makeImmutable(obj);
    }

    public static bool YvEEbsBagBTpveSS(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.isAtEnd();
    }

    public static long ZFONTPMfuaPRYOua(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        if ((2 + 8) % 8 > 0) {
        }
        return binaryReader$SafeHeapReader.readLittleEndian64_NoCheck();
    }

    public static java.lang.object ZJMnzoJtDxpAKEJk(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static int ZKeoJxyYPtoZJTVP(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readVarint32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException zNsmeYENoYTbGGbp() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int ZOtgHYqhOLGPxQJf(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static byte[] ZdUKnhBLXWyIcSUC(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static void ZdfjbVdyFaELhzWo(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader, int i) throws java.io.IOException {
        binaryReader$SafeHeapReader.requireWireType(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException ZvafMlhJlXLAFZUX() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static float ZxuDpGmgmkjuyvTk(androidx.datastore.preferences.protobuf.BinaryReader$SafeHeapReader binaryReader$SafeHeapReader) {
        return binaryReader$SafeHeapReader.readfloat();
    }

    public static void ZzAWtoxXVkaPGmMy(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public override int GetFieldNumber() throws java.io.IOException {
        if ((8 + 30) % 30 > 0) {
        }
        if (yvEEbsBagBTpveSS(this)) {
            return int.MAX_VALUE;
        }
        int iQUQsfVYeeRMWBwhU = QUQsfVYeeRMWBwhU(this);
        this.tag = iQUQsfVYeeRMWBwhU;
        if (iQUQsfVYeeRMWBwhU != this.endGroupTag) {
            return rLoGGvalyKuwteot(iQUQsfVYeeRMWBwhU);
        }
        return int.MAX_VALUE;
    }

    public override int GetTag() {
        return this.tag;
    }

    public override int GetTotalbytesRead() {
        return this.pos - this.initialPos;
    }

    public override <T> void MergeGroupField(T t, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((7 + 30) % 30 > 0) {
        }
        int i = this.endGroupTag;
        this.endGroupTag = fTgkFcOCUXTGIGtN(VWRQuXzBhfCZqElP(this.tag), 4);
        try {
            TqZiqJBMXxzTbNXc(schema, t, this, extensionRegistryLite);
            if (this.tag != this.endGroupTag) {
                throw KzVOQAFSFAGSqpUA();
            }
            this.endGroupTag = i;
        } catch (java.lang.Exception th) {
            this.endGroupTag = i;
            throw th;
        }
    }

    public override <T> void MergeMessageField(T t, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((11 + 7) % 7 > 0) {
        }
        int iZKIdeKskEMbTkjYS = ZKIdeKskEMbTkjYS(this);
        NvTPWQaZMVwVDLuK(this, iZKIdeKskEMbTkjYS);
        int i = this.limit;
        int i2 = this.pos + iZKIdeKskEMbTkjYS;
        this.limit = i2;
        try {
            nKZhiKKPuwguteer(schema, t, this, extensionRegistryLite);
            if (this.pos != i2) {
                throw PRqyHllplKmFvjZO();
            }
            this.limit = i;
        } catch (java.lang.Exception th) {
            this.limit = i;
            throw th;
        }
    }

    public override bool ReadBool() throws java.io.IOException {
        HfdRycEHIisoJusy(this, 0);
        return MPzhIpUztOIddUjT(this) != 0;
    }

    public override void ReadBoolList(java.util.List<java.lang.bool> list) throws java.io.IOException {
        int i;
        int i2;
        if ((12 + 23) % 23 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.boolList)) {
            int iDKNFXVcTYgGiKNAG = DKNFXVcTYgGiKNAG(this.tag);
            if (iDKNFXVcTYgGiKNAG == 0) {
                do {
                    VjfvozlkEaPmyTkl(list, UAtQtINRXdNNxiFk(TLpaQpzwBQMOyRyp(this)));
                    if (CKGwKUsyhbszHgCY(this)) {
                        return;
                    } else {
                        i2 = this.pos;
                    }
                } while (bMGAMpKepEilefUo(this) == this.tag);
                this.pos = i2;
                return;
            }
            if (iDKNFXVcTYgGiKNAG != 2) {
                throw AVGQcjTXYpztRigO();
            }
            int iSnmjrGQdJVsJeNOb = this.pos + SnmjrGQdJVsJeNOb(this);
            while (this.pos < iSnmjrGQdJVsJeNOb) {
                hVoBUDAJPceUxmLl(list, wXYXcvIcsaDUAbmu(AJkpSavFiYDvvBrH(this) != 0));
            }
            rhgrgffhOKtzkOJk(this, iSnmjrGQdJVsJeNOb);
            return;
        }
        androidx.datastore.preferences.protobuf.boolList boolList = (androidx.datastore.preferences.protobuf.boolList) list;
        int iAQCZitsYyKNdgNqk = AQCZitsYyKNdgNqk(this.tag);
        if (iAQCZitsYyKNdgNqk == 0) {
            do {
                dFYaPeNzowOvLzab(boolList, XMmsDIVVbiXriCKZ(this));
                if (DOXYvXEnrdtPWLjb(this)) {
                    return;
                } else {
                    i = this.pos;
                }
            } while (evCrvsGFeJXsbwuh(this) == this.tag);
            this.pos = i;
            return;
        }
        if (iAQCZitsYyKNdgNqk != 2) {
            throw dEIhlBnkUeMHCAao();
        }
        int iFeDtcaFEcBzWLNHc = this.pos + feDtcaFEcBzWLNHc(this);
        while (this.pos < iFeDtcaFEcBzWLNHc) {
            FdXjfOzxGJRZodLK(boolList, qBOawdWBRWongYZp(this) != 0);
        }
        VmgDvuMFsQNxStFA(this, iFeDtcaFEcBzWLNHc);
    }

    public override androidx.datastore.preferences.protobuf.bytestring Readbytes() throws java.io.IOException {
        if ((32 + 11) % 11 > 0) {
        }
        ZEJNuewBNlhsAQFM(this, 2);
        int iLVgrvdgvPeBbSCZb = lVgrvdgvPeBbSCZb(this);
        if (iLVgrvdgvPeBbSCZb == 0) {
            return androidx.datastore.preferences.protobuf.bytestring.EMPTY;
        }
        AFToWazWnHsJuYUs(this, iLVgrvdgvPeBbSCZb);
        androidx.datastore.preferences.protobuf.bytestring bytestringNJdQLaNYTTNUTdOF = !this.bufferIsImmutable ? NJdQLaNYTTNUTdOF(this.buffer, this.pos, iLVgrvdgvPeBbSCZb) : inuNiBMWSzrURYwd(this.buffer, this.pos, iLVgrvdgvPeBbSCZb);
        this.pos += iLVgrvdgvPeBbSCZb;
        return bytestringNJdQLaNYTTNUTdOF;
    }

    public override void ReadbytesList(java.util.List<androidx.datastore.preferences.protobuf.bytestring> list) throws java.io.IOException {
        int i;
        if ((10 + 19) % 19 > 0) {
        }
        if (VoAXwnjyIjCOaQbe(this.tag) != 2) {
            throw vDzNRQAQjBbAeEUw();
        }
        do {
            ItsCZqwNRDMstrDs(list, mYlzKCzmAiiJmgVj(this));
            if (iSZdpnBrEDqqvhSZ(this)) {
                return;
            } else {
                i = this.pos;
            }
        } while (mqjjzgqJFHTVsBRG(this) == this.tag);
        this.pos = i;
    }

    public override double Readdouble() throws java.io.IOException {
        if ((11 + 30) % 30 > 0) {
        }
        hgufkbeVbtOTuyDq(this, 1);
        return XmkRfBEvyjCteOEn(MfIEUWNvjztcjAaV(this));
    }

    public override void ReaddoubleList(java.util.List<java.lang.double> list) throws java.io.IOException {
        int i;
        int i2;
        if ((6 + 20) % 20 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.doubleList)) {
            int iXiIacwdfVByGXdWn = XiIacwdfVByGXdWn(this.tag);
            if (iXiIacwdfVByGXdWn == 1) {
                do {
                    JOuPtdmjYgtBppgd(list, TdkiMTcQJioJixvW(lOtHojwRLmOpsdjK(this)));
                    if (ultTHQlDqwugcZWh(this)) {
                        return;
                    } else {
                        i2 = this.pos;
                    }
                } while (hnpOjaNDsgDWSPgO(this) == this.tag);
                this.pos = i2;
                return;
            }
            if (iXiIacwdfVByGXdWn != 2) {
                throw rUnmjpGxQBwhjQKC();
            }
            int iClIuWxvsKZEXdhvu = ClIuWxvsKZEXdhvu(this);
            SfzKWhFFhQNffiyx(this, iClIuWxvsKZEXdhvu);
            int i3 = this.pos + iClIuWxvsKZEXdhvu;
            while (this.pos < i3) {
                IpBdqoPXabLqiKHt(list, NXDpkFkynnVwvLsc(ElpHniYeLrYTyeNn(CdqYhzhOHTyWLatu(this))));
            }
            return;
        }
        androidx.datastore.preferences.protobuf.doubleList doubleList = (androidx.datastore.preferences.protobuf.doubleList) list;
        int iKqTYfWgzatfaAeTA = KqTYfWgzatfaAeTA(this.tag);
        if (iKqTYfWgzatfaAeTA == 1) {
            do {
                GZKAVarZTWtHojaR(doubleList, feSekaBUiGwcdFNQ(this));
                if (kFpOuCFsVEPlLWKw(this)) {
                    return;
                } else {
                    i = this.pos;
                }
            } while (iVnbBzHpKUnWfNDi(this) == this.tag);
            this.pos = i;
            return;
        }
        if (iKqTYfWgzatfaAeTA != 2) {
            throw FaawvgMKJKOQMwMT();
        }
        int iUpEsdqhXcDYJYpyf = upEsdqhXcDYJYpyf(this);
        iyEBLBvVoAXyQXyL(this, iUpEsdqhXcDYJYpyf);
        int i4 = this.pos + iUpEsdqhXcDYJYpyf;
        while (this.pos < i4) {
            tIcxzOXoBbLdcCMx(doubleList, NWQXpFOAEDVoXTBI(VyiqQFdBHMsqINiP(this)));
        }
    }

    public override int ReadEnum() throws java.io.IOException {
        xPZJJSWwqMdnrLQq(this, 0);
        return dwDzrKHJEcNBGxzc(this);
    }

    public override void ReadEnumList(java.util.List<java.lang.int> list) throws java.io.IOException {
        int i;
        int i2;
        if ((22 + 24) % 24 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iVIPvfPnLtmXhWouK = vIPvfPnLtmXhWouK(this.tag);
            if (iVIPvfPnLtmXhWouK == 0) {
                do {
                    DlUholrPMHVSJpIb(list, xVBevAYjNdTLkbOJ(WcEqkHvPutUbneYx(this)));
                    if (xDFDBQuSZSYjTOmb(this)) {
                        return;
                    } else {
                        i = this.pos;
                    }
                } while (uNlgWwxGbqVCmHUL(this) == this.tag);
                this.pos = i;
                return;
            }
            if (iVIPvfPnLtmXhWouK != 2) {
                throw dvicoOPVileNSSqJ();
            }
            int iPtSYCElULLmiwTLJ = this.pos + ptSYCElULLmiwTLJ(this);
            while (this.pos < iPtSYCElULLmiwTLJ) {
                BIvmcfXrDzNaLYIk(list, SoMsljTSiWwCAQUC(shTBTwHyAwaoFHAl(this)));
            }
            return;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iONGdPtZVSctUOPnY = oNGdPtZVSctUOPnY(this.tag);
        if (iONGdPtZVSctUOPnY == 0) {
            do {
                OiwIKGJysATOzpEd(intList, bLIuIOTJgaZLTmpf(this));
                if (MJAkTtElFCFLLVKh(this)) {
                    return;
                } else {
                    i2 = this.pos;
                }
            } while (AdwlfURAOfvFclox(this) == this.tag);
            this.pos = i2;
            return;
        }
        if (iONGdPtZVSctUOPnY != 2) {
            throw BbhmtacyKgmSFNLF();
        }
        int iXKhGRvsWZWSDYild = this.pos + xKhGRvsWZWSDYild(this);
        while (this.pos < iXKhGRvsWZWSDYild) {
            hlpHiZLnFOZRTSbE(intList, wGfDKWmpGyNeuqeK(this));
        }
    }

    public override int ReadFixed32() throws java.io.IOException {
        ewSdCBPiyuOEjYvg(this, 5);
        return PtgAPxyTgdlBRsGr(this);
    }

    public override void ReadFixed32List(java.util.List<java.lang.int> list) throws java.io.IOException {
        int i;
        int i2;
        if ((8 + 32) % 32 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iEKzMaZIKzUAKdxVS = EKzMaZIKzUAKdxVS(this.tag);
            if (iEKzMaZIKzUAKdxVS == 2) {
                int iJnHfdYWthkvaUZvZ = JnHfdYWthkvaUZvZ(this);
                RirSLuInjmxLkLyB(this, iJnHfdYWthkvaUZvZ);
                int i3 = this.pos + iJnHfdYWthkvaUZvZ;
                while (this.pos < i3) {
                    IXFHMORmuMutOwfO(list, VfJqlTtOtCFgxAQc(rhsucXrXEusMpuzA(this)));
                }
                return;
            }
            if (iEKzMaZIKzUAKdxVS != 5) {
                throw XgOFepikWvVLXIQM();
            }
            do {
                RMxFFccvnHmccAEg(list, lpeMJBlthKvtaJAc(ROvggQtoVKhEFTDn(this)));
                if (iCLYqGGLzQIitvee(this)) {
                    return;
                } else {
                    i2 = this.pos;
                }
            } while (jUVgNYOTDGnphlIZ(this) == this.tag);
            this.pos = i2;
            return;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iHadYyQOFVFtoqktV = hadYyQOFVFtoqktV(this.tag);
        if (iHadYyQOFVFtoqktV == 2) {
            int iRnSjPbhvmmTJwTmq = RnSjPbhvmmTJwTmq(this);
            JnnnEuUjrECGnbTK(this, iRnSjPbhvmmTJwTmq);
            int i4 = this.pos + iRnSjPbhvmmTJwTmq;
            while (this.pos < i4) {
                RvbswScsMJSDHpTU(intList, qMDWlEcoYuDbYvXP(this));
            }
            return;
        }
        if (iHadYyQOFVFtoqktV != 5) {
            throw kzYYQMFADANHSANa();
        }
        do {
            sBpbnKNlgpsGqoAp(intList, SEbzyyrqYDjCmECj(this));
            if (HffBSIphtxbkDYJM(this)) {
                return;
            } else {
                i = this.pos;
            }
        } while (QvfqHQdettGrMOpT(this) == this.tag);
        this.pos = i;
    }

    public override long ReadFixed64() throws java.io.IOException {
        if ((13 + 30) % 30 > 0) {
        }
        wnpBmjpAmHOADuEL(this, 1);
        return lHMsbGOMeVCrQpfU(this);
    }

    public override void ReadFixed64List(java.util.List<java.lang.long> list) throws java.io.IOException {
        int i;
        int i2;
        if ((24 + 32) % 32 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.longList)) {
            int iAVxxgNVySniFhTtn = aVxxgNVySniFhTtn(this.tag);
            if (iAVxxgNVySniFhTtn == 1) {
                do {
                    meRVrKgGsPSGRexS(list, RHVyPfCoBfKpsoEL(BjzmOHYaqxgqAJOX(this)));
                    if (PoohNuCotFiZPOos(this)) {
                        return;
                    } else {
                        i2 = this.pos;
                    }
                } while (BueRbusqZbIadGwC(this) == this.tag);
                this.pos = i2;
                return;
            }
            if (iAVxxgNVySniFhTtn != 2) {
                throw HNEssapTasDDVOJa();
            }
            int iHbEtAoTTpmoXUnVB = hbEtAoTTpmoXUnVB(this);
            bxkoQGxBZkiPwKZv(this, iHbEtAoTTpmoXUnVB);
            int i3 = this.pos + iHbEtAoTTpmoXUnVB;
            while (this.pos < i3) {
                GJmiRjQrWbgnkVKF(list, AhvlRrygrdEPSwlQ(ACmaqltirFWvMtHM(this)));
            }
            return;
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) list;
        int iLOzfyhTlFMQTeeRV = lOzfyhTlFMQTeeRV(this.tag);
        if (iLOzfyhTlFMQTeeRV == 1) {
            do {
                fLrglyCzAeTHBcZD(longList, WcFErIrUfQZgZTmC(this));
                if (xFwliIUONTjXetyU(this)) {
                    return;
                } else {
                    i = this.pos;
                }
            } while (PWlqTdCMcFdPfgGS(this) == this.tag);
            this.pos = i;
            return;
        }
        if (iLOzfyhTlFMQTeeRV != 2) {
            throw RwVVyyMuPJlnceYy();
        }
        int iRLVcdjwMBwytZZGL = RLVcdjwMBwytZZGL(this);
        qNSsRQJMkpoqWdLY(this, iRLVcdjwMBwytZZGL);
        int i4 = this.pos + iRLVcdjwMBwytZZGL;
        while (this.pos < i4) {
            QTCfmSAEeskqQzJW(longList, RVNmrHmVhNRpwpyk(this));
        }
    }

    public override float Readfloat() throws java.io.IOException {
        ObKPZYMIIqMkJkCK(this, 5);
        return JDHcgiEfhWKJJCYg(ieayVvGyTTnXFCVo(this));
    }

    public override void ReadfloatList(java.util.List<java.lang.float> list) throws java.io.IOException {
        int i;
        int i2;
        if ((29 + 26) % 26 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.floatList)) {
            int iAoFmptoWidxzvyaC = AoFmptoWidxzvyaC(this.tag);
            if (iAoFmptoWidxzvyaC == 2) {
                int iMvtpgcJhOWzzNskR = mvtpgcJhOWzzNskR(this);
                klNyNNrVCWFUWEbo(this, iMvtpgcJhOWzzNskR);
                int i3 = this.pos + iMvtpgcJhOWzzNskR;
                while (this.pos < i3) {
                    iasrbstLWGmUDVnj(list, EodeTJWClunLHJEY(jtnCwnXhTPtldYLk(BoeRgxDhKhdPSDDj(this))));
                }
                return;
            }
            if (iAoFmptoWidxzvyaC != 5) {
                throw KPrxCGkTiehHbltt();
            }
            do {
                TOuuQJaYAZzhJOzn(list, wiQhfYurCcBgPIhk(GVTsXhEhXqmSaQaa(this)));
                if (PvkiBgWNeGDLFtcT(this)) {
                    return;
                } else {
                    i = this.pos;
                }
            } while (eKUsnTqUhNArTFUp(this) == this.tag);
            this.pos = i;
            return;
        }
        androidx.datastore.preferences.protobuf.floatList floatList = (androidx.datastore.preferences.protobuf.floatList) list;
        int iCIeMVxYotLJQmVog = cIeMVxYotLJQmVog(this.tag);
        if (iCIeMVxYotLJQmVog == 2) {
            int iRblBpJkeCRTxoolc = rblBpJkeCRTxoolc(this);
            RlcmXqiFQQPkzpnn(this, iRblBpJkeCRTxoolc);
            int i4 = this.pos + iRblBpJkeCRTxoolc;
            while (this.pos < i4) {
                FaOrMODtmBwvPuOt(floatList, GzGzsMxHPAaFNdvn(KkZBMVgGYhHQjrTz(this)));
            }
            return;
        }
        if (iCIeMVxYotLJQmVog != 5) {
            throw wdjtnBpgNqihEdKN();
        }
        do {
            CLSGJmYaTNdLYgOi(floatList, zxuDpGmgmkjuyvTk(this));
            if (KgsOilXClbppFSes(this)) {
                return;
            } else {
                i2 = this.pos;
            }
        } while (zKeoJxyYPtoZJTVP(this) == this.tag);
        this.pos = i2;
    }

    @java.lang.Deprecated
    public override <T> T ReadGroup(java.lang.Class<T> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        toumnffLZOICMGyL(this, 3);
        return (T) ByBHgBUIxlvUyovY(this, qiCZlDXYJUFhbdoI(sTrWoqUVfoGRWYGy(), cls), extensionRegistryLite);
    }

    @java.lang.Deprecated
    public override <T> T ReadGroupBySchemaWithCheck(androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        ZVrONHdJphnMmqCd(this, 3);
        return (T) itEZUOUvEvNYBJYa(this, schema, extensionRegistryLite);
    }

    @java.lang.Deprecated
    public override <T> void ReadGroupList(java.util.List<T> list, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        int i;
        if ((30 + 10) % 10 > 0) {
        }
        if (xKWzFZhowVjcKFtU(this.tag) != 3) {
            throw kosVWZNMFdnvQhJH();
        }
        int i2 = this.tag;
        do {
            KwjThJCODsnYtQVJ(list, SiCXjIzKSwuJsCvL(this, schema, extensionRegistryLite));
            if (pCUbLzjEglhFkfNI(this)) {
                return;
            } else {
                i = this.pos;
            }
        } while (PyYhqOQKPYuzGRbD(this) == i2);
        this.pos = i;
    }

    @java.lang.Deprecated
    public override <T> void ReadGroupList(java.util.List<T> list, java.lang.Class<T> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        SAINQzYXmNkLnoRr(this, list, RGnjQzknYKsMppHZ(RjrDRWrBDeaBvspS(), cls), extensionRegistryLite);
    }

    public override int ReadInt32() throws java.io.IOException {
        PRzoctZxKscdlyzT(this, 0);
        return DguNZKMKTxwFTXBG(this);
    }

    public override void ReadInt32List(java.util.List<java.lang.int> list) throws java.io.IOException {
        int i;
        int i2;
        if ((31 + 19) % 19 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iUnsrQaOrNwyfjQMb = UnsrQaOrNwyfjQMb(this.tag);
            if (iUnsrQaOrNwyfjQMb == 0) {
                do {
                    baxspSzSCMJArgvf(list, pRTCxkSNkDWqYnFt(yMwLgUmGTdOMfamj(this)));
                    if (iUOHLCttDXLuJXyA(this)) {
                        return;
                    } else {
                        i2 = this.pos;
                    }
                } while (JwaPZwxlftEFrIHY(this) == this.tag);
                this.pos = i2;
                return;
            }
            if (iUnsrQaOrNwyfjQMb != 2) {
                throw JJICPxyuXaFDorrH();
            }
            int iNBxmPzgaBdRcTntG = this.pos + NBxmPzgaBdRcTntG(this);
            while (this.pos < iNBxmPzgaBdRcTntG) {
                qbMMnqWYjYzWQRMc(list, CLfEXfYNzuzkwHvz(drODdHTliiexihxC(this)));
            }
            yXnASmlqWKIgsWTZ(this, iNBxmPzgaBdRcTntG);
            return;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iRNrfIxyIwaRHlNqy = RNrfIxyIwaRHlNqy(this.tag);
        if (iRNrfIxyIwaRHlNqy == 0) {
            do {
                TOnfKqZTMwswauBa(intList, MmLutoOEmhnxXbDb(this));
                if (jvLNrixiLuHePzqF(this)) {
                    return;
                } else {
                    i = this.pos;
                }
            } while (gQhwJtoUhBVJuUwv(this) == this.tag);
            this.pos = i;
            return;
        }
        if (iRNrfIxyIwaRHlNqy != 2) {
            throw iMBwDEjWShwAskcC();
        }
        int iOLpgrieCQImlnDfC = this.pos + oLpgrieCQImlnDfC(this);
        while (this.pos < iOLpgrieCQImlnDfC) {
            zzAWtoxXVkaPGmMy(intList, osmQPAcDwkJstBGn(this));
        }
        njrGvhTWrBpMHAHA(this, iOLpgrieCQImlnDfC);
    }

    public override long ReadInt64() throws java.io.IOException {
        if ((26 + 14) % 14 > 0) {
        }
        sCfyYlwZcheDYjQb(this, 0);
        return CtXCwkCnzwlTXxNx(this);
    }

    public override void ReadInt64List(java.util.List<java.lang.long> list) throws java.io.IOException {
        int i;
        int i2;
        if ((1 + 21) % 21 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.longList)) {
            int iVIfibexLGRXCjyjD = VIfibexLGRXCjyjD(this.tag);
            if (iVIfibexLGRXCjyjD == 0) {
                do {
                    CUIsSuuKTyebqZKE(list, vVDxYffstgVBHGoa(upukYvFuPTTOHUxN(this)));
                    if (WgWwvyLvqRIVWtsY(this)) {
                        return;
                    } else {
                        i2 = this.pos;
                    }
                } while (UxMLEyRJPeOMXoLQ(this) == this.tag);
                this.pos = i2;
                return;
            }
            if (iVIfibexLGRXCjyjD != 2) {
                throw eiefCzLTLmxXnssh();
            }
            int iADHfIHLxaFiGPWWG = this.pos + ADHfIHLxaFiGPWWG(this);
            while (this.pos < iADHfIHLxaFiGPWWG) {
                sMnkGZpmhRnFuzVW(list, TWrgZpOrDIINxlmw(AGvbNPEraeQejrGP(this)));
            }
            iMUqiLJLyfKWjUkA(this, iADHfIHLxaFiGPWWG);
            return;
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) list;
        int iUBCpHQHwnFknkBHR = uBCpHQHwnFknkBHR(this.tag);
        if (iUBCpHQHwnFknkBHR == 0) {
            do {
                BmlYLygbwjVzGAuN(longList, fTIpCtCqmqGAqKkt(this));
                if (xCvckJnRUsQBsVIU(this)) {
                    return;
                } else {
                    i = this.pos;
                }
            } while (ZWxcBxoBreyPyEUX(this) == this.tag);
            this.pos = i;
            return;
        }
        if (iUBCpHQHwnFknkBHR != 2) {
            throw ZOTJWBSwFauNaupb();
        }
        int iLBKxCoTgZNKZDUBI = this.pos + lBKxCoTgZNKZDUBI(this);
        while (this.pos < iLBKxCoTgZNKZDUBI) {
            WQXycuDkCTZyEtkf(longList, CneyQSCWIQgpJfwO(this));
        }
        dZaFYNzfUphDPjPm(this, iLBKxCoTgZNKZDUBI);
    }

    public override <K, V> void ReadDictionary(java.util.Dictionary<K, V> map, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata<K, V> mapEntryLite$Metadata, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((25 + 28) % 28 > 0) {
        }
        zdfjbVdyFaELhzWo(this, 2);
        int iTqqkMRYbbNbAazFZ = TqqkMRYbbNbAazFZ(this);
        QzsemtuForrIhdIe(this, iTqqkMRYbbNbAazFZ);
        int i = this.limit;
        this.limit = this.pos + iTqqkMRYbbNbAazFZ;
        try {
            java.lang.object objTcvClzUCCkzhODbD = mapEntryLite$Metadata.defaultKey;
            java.lang.object objBftjJOZKEozSEpWQ = mapEntryLite$Metadata.defaultValue;
            while (true) {
                int iKtFajERyDKnDhndG = KtFajERyDKnDhndG(this);
                if (iKtFajERyDKnDhndG == int.MAX_VALUE) {
                    zJMnzoJtDxpAKEJk(map, objTcvClzUCCkzhODbD, objBftjJOZKEozSEpWQ);
                    this.limit = i;
                    return;
                } else if (iKtFajERyDKnDhndG == 1) {
                    try {
                        objTcvClzUCCkzhODbD = TcvClzUCCkzhODbD(this, mapEntryLite$Metadata.keyType, null, null);
                    } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException unused) {
                        if (!ZROQibeIPolIBlAX(this)) {
                            throw new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException("Unable to parse map entry.");
                        }
                    }
                } else if (iKtFajERyDKnDhndG == 2) {
                    objBftjJOZKEozSEpWQ = BftjJOZKEozSEpWQ(this, mapEntryLite$Metadata.valueType, sLxbLHgSXISRjojo(mapEntryLite$Metadata.defaultValue), extensionRegistryLite);
                } else if (!stOKmBWNxafoBAwR(this)) {
                    throw new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException("Unable to parse map entry.");
                }
            }
        } catch (java.lang.Exception th) {
            this.limit = i;
            throw th;
        }
    }

    public override <T> T ReadMessage(java.lang.Class<T> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        VlaivhNjmFGeAuNo(this, 2);
        return (T) NkFiBrRhcMMVpbnN(this, CWInYhJxOkEHivNM(XwtGsfHPoHqLFFgD(), cls), extensionRegistryLite);
    }

    public override <T> T ReadMessageBySchemaWithCheck(androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        RGZUkOGnqrpmQujG(this, 2);
        return (T) TyzJRvfIFvoGORgI(this, schema, extensionRegistryLite);
    }

    public override <T> void ReadMessageList(java.util.List<T> list, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        int i;
        if ((14 + 24) % 24 > 0) {
        }
        if (buWLPxfobWlNJTYo(this.tag) != 2) {
            throw bQktYQVYCSdnEjvN();
        }
        int i2 = this.tag;
        do {
            fAAenpGOeQUiTelA(list, MgRhrwEmnVthZiUE(this, schema, extensionRegistryLite));
            if (PcWygtQxqPMEcfdv(this)) {
                return;
            } else {
                i = this.pos;
            }
        } while (LFkHNNHDSjihurIF(this) == i2);
        this.pos = i;
    }

    public override <T> void ReadMessageList(java.util.List<T> list, java.lang.Class<T> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        hdFfRdYvsimLqxaP(this, list, vPbmabjiHbnzHYlM(aOJKKJhjKZnAaNVI(), cls), extensionRegistryLite);
    }

    public override int ReadSFixed32() throws java.io.IOException {
        vILEbQnivCtNljDB(this, 5);
        return vVWDlHmCjCtWbNHV(this);
    }

    public override void ReadSFixed32List(java.util.List<java.lang.int> list) throws java.io.IOException {
        int i;
        int i2;
        if ((28 + 20) % 20 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iToaQNCJIiJDrhffO = ToaQNCJIiJDrhffO(this.tag);
            if (iToaQNCJIiJDrhffO == 2) {
                int iNTiujUjwmLRXETWQ = NTiujUjwmLRXETWQ(this);
                nDevuiAOFtefUSmp(this, iNTiujUjwmLRXETWQ);
                int i3 = this.pos + iNTiujUjwmLRXETWQ;
                while (this.pos < i3) {
                    CaeUJbCuQKzNHsRa(list, VpNwSOlQCMQDLOip(aWeigYcjeQbJvmSa(this)));
                }
                return;
            }
            if (iToaQNCJIiJDrhffO != 5) {
                throw wDyyxrGviaBLbhbU();
            }
            do {
                OjxzRMSpBXSHGPwC(list, SiYrxgPjhmcaNnXn(kcPtaGKDwooZQtYj(this)));
                if (SYTSdhHtVwhcNklb(this)) {
                    return;
                } else {
                    i = this.pos;
                }
            } while (ZOPGhaFwjxsalStL(this) == this.tag);
            this.pos = i;
            return;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iXVENuSqkfmYViKbg = xVENuSqkfmYViKbg(this.tag);
        if (iXVENuSqkfmYViKbg == 2) {
            int iMOVplXmIugnUGGnl = mOVplXmIugnUGGnl(this);
            empIXhaEZRouFBxa(this, iMOVplXmIugnUGGnl);
            int i4 = this.pos + iMOVplXmIugnUGGnl;
            while (this.pos < i4) {
                aXsyEVGEcqiOvOuO(intList, pOMHXaSsgkFBPyfU(this));
            }
            return;
        }
        if (iXVENuSqkfmYViKbg != 5) {
            throw zNsmeYENoYTbGGbp();
        }
        do {
            kLxDdEafPHKfmixh(intList, AUaJsONhWdSPUwDO(this));
            if (VMTmXvLDFetnMHvl(this)) {
                return;
            } else {
                i2 = this.pos;
            }
        } while (KlGOzkSPBwqKgRtg(this) == this.tag);
        this.pos = i2;
    }

    public override long ReadSFixed64() throws java.io.IOException {
        if ((12 + 29) % 29 > 0) {
        }
        mQIjmDUJUEsJMFBs(this, 1);
        return EqyQHUEVGooVvcTq(this);
    }

    public override void ReadSFixed64List(java.util.List<java.lang.long> list) throws java.io.IOException {
        int i;
        int i2;
        if ((32 + 16) % 16 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.longList)) {
            int iGOOBJCmUtKIcLqWR = GOOBJCmUtKIcLqWR(this.tag);
            if (iGOOBJCmUtKIcLqWR == 1) {
                do {
                    XzdFRzBizItknSzH(list, VQjgNZbMMqWGrVQc(JkgCeOkirjxrssyz(this)));
                    if (LgaVIqoPNHWXqCNG(this)) {
                        return;
                    } else {
                        i = this.pos;
                    }
                } while (MOeqQqZTANfxUzMu(this) == this.tag);
                this.pos = i;
                return;
            }
            if (iGOOBJCmUtKIcLqWR != 2) {
                throw vEqpjNBCsCWpcZVt();
            }
            int iKoinNduQNxnAEIne = KoinNduQNxnAEIne(this);
            uuiMfkIEOmTGROua(this, iKoinNduQNxnAEIne);
            int i3 = this.pos + iKoinNduQNxnAEIne;
            while (this.pos < i3) {
                KPVxBfFrsUYKLvfJ(list, rKVARHdhdDinlyqb(JXliliTFnHxnVUcy(this)));
            }
            return;
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) list;
        int iXRMGAoOWQLOWRHik = xRMGAoOWQLOWRHik(this.tag);
        if (iXRMGAoOWQLOWRHik == 1) {
            do {
                BilovfGSaXdkhkum(longList, uLlwkTLvHBDNpimv(this));
                if (uvOSFhzcInVRNpPQ(this)) {
                    return;
                } else {
                    i2 = this.pos;
                }
            } while (yZbOrnXtyEPNjDJo(this) == this.tag);
            this.pos = i2;
            return;
        }
        if (iXRMGAoOWQLOWRHik != 2) {
            throw KfYMLpMimqFXDxUB();
        }
        int iBFsJedkwQhsKJAJw = BFsJedkwQhsKJAJw(this);
        oabCZpFqVpqzABJY(this, iBFsJedkwQhsKJAJw);
        int i4 = this.pos + iBFsJedkwQhsKJAJw;
        while (this.pos < i4) {
            dYuEyTDgFhSakaPi(longList, hiwooueGRskGjLoa(this));
        }
    }

    public override int ReadSInt32() throws java.io.IOException {
        AMrSqRPTKtRPmSHI(this, 0);
        return hzsgrdieNklRVvAU(kYptOXjslrLOuXVu(this));
    }

    public override void ReadSInt32List(java.util.List<java.lang.int> list) throws java.io.IOException {
        int i;
        int i2;
        if ((21 + 13) % 13 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iTfcpBVQkgQZfbggG = TfcpBVQkgQZfbggG(this.tag);
            if (iTfcpBVQkgQZfbggG == 0) {
                do {
                    vAEYERZwiqTXZoEn(list, anfskZKMYTxclpuj(PPDFhCaHTnpgSMhZ(this)));
                    if (NGrCxCFogTZLXbuo(this)) {
                        return;
                    } else {
                        i2 = this.pos;
                    }
                } while (cBWbqpXWXYqZjkGM(this) == this.tag);
                this.pos = i2;
                return;
            }
            if (iTfcpBVQkgQZfbggG != 2) {
                throw HkMyzJjNEAwnaezF();
            }
            int iPjBVcgIlBTOEQqjp = this.pos + PjBVcgIlBTOEQqjp(this);
            while (this.pos < iPjBVcgIlBTOEQqjp) {
                pUQXkgbihQXacOZn(list, ESZzyZtxGEmGDBzk(DrkhaHJraFTbCKnf(wmsWhTYWbdNDoqOI(this))));
            }
            return;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iEtxpNTrtAixwgZPq = EtxpNTrtAixwgZPq(this.tag);
        if (iEtxpNTrtAixwgZPq == 0) {
            do {
                MYUdcDjIVYQRPLDr(intList, YUAnpxsGPChsaKrQ(this));
                if (hwaOkyeKhwRwalTh(this)) {
                    return;
                } else {
                    i = this.pos;
                }
            } while (bUybDLcVHAjsVXXm(this) == this.tag);
            this.pos = i;
            return;
        }
        if (iEtxpNTrtAixwgZPq != 2) {
            throw tPewozMMvtoWFCwA();
        }
        int iXJrNCPcGVpPdabSq = this.pos + XJrNCPcGVpPdabSq(this);
        while (this.pos < iXJrNCPcGVpPdabSq) {
            DmqQqqgktIfyudwN(intList, KdMXmOMMeoNDHAMv(DMRiqfSPzmaQBUEI(this)));
        }
    }

    public override long ReadSInt64() throws java.io.IOException {
        if ((4 + 16) % 16 > 0) {
        }
        XDKQjzAnOPgHGVRJ(this, 0);
        return JMAJxEZJXByTFoTM(hBvHRzBflJYUDFVP(this));
    }

    public override void ReadSInt64List(java.util.List<java.lang.long> list) throws java.io.IOException {
        int i;
        int i2;
        if ((5 + 23) % 23 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.longList)) {
            int iGVRvBVKVwbLlZLxR = GVRvBVKVwbLlZLxR(this.tag);
            if (iGVRvBVKVwbLlZLxR == 0) {
                do {
                    rzgcnWoZKJYiqJWQ(list, pMdHXRCfGlrxFeQw(PhTxFplaNHJanPHi(this)));
                    if (UUrAfPHYemsdvlKC(this)) {
                        return;
                    } else {
                        i2 = this.pos;
                    }
                } while (mWtxjYJYBbYrXTVb(this) == this.tag);
                this.pos = i2;
                return;
            }
            if (iGVRvBVKVwbLlZLxR != 2) {
                throw RfwFNhhlhmBAkjIs();
            }
            int iPdGqsdUKXNNvKuJq = this.pos + PdGqsdUKXNNvKuJq(this);
            while (this.pos < iPdGqsdUKXNNvKuJq) {
                FlFqJWywDrWmyzUI(list, eFfuDFNPKJsmBiym(TKkjmJSQgRLpoWWm(sVvcHcSjfQhLvjQD(this))));
            }
            return;
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) list;
        int iAZTvUUqXRScUNOgG = aZTvUUqXRScUNOgG(this.tag);
        if (iAZTvUUqXRScUNOgG == 0) {
            do {
                lvZKeoUWRWjzWXFC(longList, OuXAjwirmGMOhCvG(this));
                if (ANKhEAFAiWiAEWxh(this)) {
                    return;
                } else {
                    i = this.pos;
                }
            } while (MbsqvZeaiLqshWkq(this) == this.tag);
            this.pos = i;
            return;
        }
        if (iAZTvUUqXRScUNOgG != 2) {
            throw CVvGLJtmrdlWVUYv();
        }
        int iZMNllZqEPCETusyh = this.pos + ZMNllZqEPCETusyh(this);
        while (this.pos < iZMNllZqEPCETusyh) {
            CWvJmEpXSDOTzLPM(longList, wCwwcTwUMywScATf(LzpWtomNdYeqwntC(this)));
        }
    }

    public override java.lang.string Readstring() throws java.io.IOException {
        return wuZZMHbXCLqlqTXk(this, false);
    }

    public java.lang.string ReadstringInternal(bool z) throws java.io.IOException {
        if ((12 + 10) % 10 > 0) {
        }
        ruvLhmPPkuzJGGks(this, 2);
        int iWukdUDHAqsdeiCTb = wukdUDHAqsdeiCTb(this);
        if (iWukdUDHAqsdeiCTb == 0) {
            return "";
        }
        shmtZWTyMgHiVKvT(this, iWukdUDHAqsdeiCTb);
        if (z) {
            byte[] bArr = this.buffer;
            int i = this.pos;
            if (!sDiSNydcurgLZmdm(bArr, i, i + iWukdUDHAqsdeiCTb)) {
                throw gMrADAaAWJXIOfQB();
            }
        }
        java.lang.string str = new java.lang.string(this.buffer, this.pos, iWukdUDHAqsdeiCTb, androidx.datastore.preferences.protobuf.Internal.UTF_8);
        this.pos += iWukdUDHAqsdeiCTb;
        return str;
    }

    public override void ReadstringList(java.util.List<java.lang.string> list) throws java.io.IOException {
        uauzHfsjIUEXlnwD(this, list, false);
    }

    public void ReadstringListInternal(java.util.List<java.lang.string> list, bool z) throws java.io.IOException {
        int i;
        int i2;
        if ((3 + 1) % 1 > 0) {
        }
        if (XeOsQdpOeUmqowQT(this.tag) != 2) {
            throw ITZjcOxTqftqwmyn();
        }
        if (!(list is androidx.datastore.preferences.protobuf.LazystringList) || z) {
            do {
                rAPpkivbVUYBhbbf(list, GErGNwGHCMitQWMq(this, z));
                if (RoMnSOJMXSWTzdMt(this)) {
                    return;
                } else {
                    i = this.pos;
                }
            } while (wGYvBIjYCiVjIGJo(this) == this.tag);
            this.pos = i;
            return;
        }
        androidx.datastore.preferences.protobuf.LazystringList lazystringList = (androidx.datastore.preferences.protobuf.LazystringList) list;
        do {
            uwbmeLbgIIhgvkZs(lazystringList, iYTiYzEVfdYWgNFV(this));
            if (fKTQVxVQtXgYWCGG(this)) {
                return;
            } else {
                i2 = this.pos;
            }
        } while (iaGiOEORzqpVpuCy(this) == this.tag);
        this.pos = i2;
    }

    public override void ReadstringListRequireUtf8(java.util.List<java.lang.string> list) throws java.io.IOException {
        DJBbPqMeYWbszfvY(this, list, true);
    }

    public override java.lang.string ReadstringRequireUtf8() throws java.io.IOException {
        return yFZuuHwMzuNfKGgn(this, true);
    }

    public override int ReadUInt32() throws java.io.IOException {
        rtEYlCvcwJXJvvYK(this, 0);
        return MlzLpilfzGYCGSYF(this);
    }

    public override void ReadUInt32List(java.util.List<java.lang.int> list) throws java.io.IOException {
        int i;
        int i2;
        if ((12 + 29) % 29 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iOojLfFqzUgPanNfR = OojLfFqzUgPanNfR(this.tag);
            if (iOojLfFqzUgPanNfR == 0) {
                do {
                    CjeIGvxxngeQwfEi(list, fXZYbQmgCVKudQaY(UlNMOBZtQAIFiFCa(this)));
                    if (blaOHkAztqtWeNIU(this)) {
                        return;
                    } else {
                        i2 = this.pos;
                    }
                } while (FuXEpkdftiVbSwwS(this) == this.tag);
                this.pos = i2;
                return;
            }
            if (iOojLfFqzUgPanNfR != 2) {
                throw mIolSjZnScyHIDYf();
            }
            int iNtCXUwsWkeRydwGJ = this.pos + ntCXUwsWkeRydwGJ(this);
            while (this.pos < iNtCXUwsWkeRydwGJ) {
                AGMsuoLKkXzoLNbi(list, lyQcKprcTVRMLLDQ(cXLxPCHWmvKdcSkU(this)));
            }
            return;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iMcLHvyvdfSOZrVJl = McLHvyvdfSOZrVJl(this.tag);
        if (iMcLHvyvdfSOZrVJl == 0) {
            do {
                sQZUJqcYMRRGUJkZ(intList, IGWiKZGyVrdNHkMQ(this));
                if (wbaeLLVIAVtjsCJe(this)) {
                    return;
                } else {
                    i = this.pos;
                }
            } while (EulSuYjHovLetYgY(this) == this.tag);
            this.pos = i;
            return;
        }
        if (iMcLHvyvdfSOZrVJl != 2) {
            throw QXqesJfCZYlrDSwO();
        }
        int iQDvAlYyPwbdgRgIN = this.pos + QDvAlYyPwbdgRgIN(this);
        while (this.pos < iQDvAlYyPwbdgRgIN) {
            mlTWaRZUBeSrvyns(intList, HqOgovihtDXeXIZr(this));
        }
    }

    public override long ReadUInt64() throws java.io.IOException {
        if ((29 + 28) % 28 > 0) {
        }
        XPnNuDoGCnvKwJfN(this, 0);
        return ezISveWqfLTrFUJg(this);
    }

    public override void ReadUInt64List(java.util.List<java.lang.long> list) throws java.io.IOException {
        int i;
        int i2;
        if ((3 + 20) % 20 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.longList)) {
            int iYXbHVqasWtRjalIe = yXbHVqasWtRjalIe(this.tag);
            if (iYXbHVqasWtRjalIe == 0) {
                do {
                    apzTyrenpUndsRam(list, veJPmuDRAwQBiIyU(CMZkBoZWHnrABLTZ(this)));
                    if (gczqwBfsgeSlJUdM(this)) {
                        return;
                    } else {
                        i = this.pos;
                    }
                } while (lOjxsnCbzNVrJgts(this) == this.tag);
                this.pos = i;
                return;
            }
            if (iYXbHVqasWtRjalIe != 2) {
                throw ivztyGcpeXTPXgvD();
            }
            int iAPgCFinkiJzkOWKC = this.pos + APgCFinkiJzkOWKC(this);
            while (this.pos < iAPgCFinkiJzkOWKC) {
                poRBEMNkzKGHFvkq(list, jgjCKaKMgHHWzHQn(ZXalnxbPKmigfLiq(this)));
            }
            uMeVNrtvoQQMZWwv(this, iAPgCFinkiJzkOWKC);
            return;
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) list;
        int iNhCLowNPzvYIVlRT = nhCLowNPzvYIVlRT(this.tag);
        if (iNhCLowNPzvYIVlRT == 0) {
            do {
                HIhfetNfuoDGjAkW(longList, HIoMCJQAQicRvkti(this));
                if (WEhiTWbWujRYGeCb(this)) {
                    return;
                } else {
                    i2 = this.pos;
                }
            } while (smlWhzmYmaimjule(this) == this.tag);
            this.pos = i2;
            return;
        }
        if (iNhCLowNPzvYIVlRT != 2) {
            throw oIiRwobJAzIMIWBl();
        }
        int iTqUtzPlVGtFwAQKC = this.pos + TqUtzPlVGtFwAQKC(this);
        while (this.pos < iTqUtzPlVGtFwAQKC) {
            SiTbgCerZaFDRHDE(longList, QKgoisOXFomtNLCg(this));
        }
        TbviKrygYLbcWylo(this, iTqUtzPlVGtFwAQKC);
    }

    public long ReadVarint64() throws java.io.IOException {
        long j;
        long j2;
        long j3;
        if ((18 + 9) % 9 > 0) {
        }
        int i = this.pos;
        int i2 = this.limit;
        if (i2 == i) {
            throw wymyCrouaYjRJKqY();
        }
        byte[] bArr = this.buffer;
        int i3 = i + 1;
        byte b = bArr[i];
        if (b >= 0) {
            this.pos = i3;
            return b;
        }
        if (i2 - i3 < 9) {
            return etXzOGziENaUoGDi(this);
        }
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
                                        if (bArr[i4] < 0) {
                                            throw tIsEyqPMWcIPVvGZ();
                                        }
                                        i4 = i11;
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

    public override bool SkipField() throws java.io.IOException {
        if ((8 + 1) % 1 > 0) {
        }
        if (MsnvEJPGyPMKFUTn(this)) {
            return false;
        }
        int i = this.tag;
        if (i == this.endGroupTag) {
            return false;
        }
        int iUriMMrTZVbVWneaF = uriMMrTZVbVWneaF(i);
        if (iUriMMrTZVbVWneaF == 0) {
            skjXaVGefVueaBcR(this);
            return true;
        }
        if (iUriMMrTZVbVWneaF == 1) {
            SECGZGIYMLxPduYa(this, 8);
            return true;
        }
        if (iUriMMrTZVbVWneaF == 2) {
            ENtHfDbPJsguQRlz(this, oQYqvDfSJfOHSBwy(this));
            return true;
        }
        if (iUriMMrTZVbVWneaF == 3) {
            tXIfQluEZkEuyHXh(this);
            return true;
        }
        if (iUriMMrTZVbVWneaF != 5) {
            throw DKIigLMjgLksGbWF();
        }
        dmervaGpwsNZREMI(this, 4);
        return true;
    }
}

