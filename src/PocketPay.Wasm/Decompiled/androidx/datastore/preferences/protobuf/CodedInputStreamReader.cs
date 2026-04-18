namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class CodedStreamReader : androidx.datastore.preferences.protobuf.Reader {
    private static readonly int FIXED32_MULTIPLE_MASK = 3;
    private static readonly int FIXED64_MULTIPLE_MASK = 7;
    private static readonly int NEXT_TAG_UNSET = 0;
    private int endGroupTag;
    private readonly androidx.datastore.preferences.protobuf.CodedStream input;
    private int nextTag = 0;
    private int tag;

    private CodedStreamReader(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        androidx.datastore.preferences.protobuf.CodedStream codedStream2 = (androidx.datastore.preferences.protobuf.CodedStream) cCbjCmNqUXNFjPcw(codedStream, "input");
        this.input = codedStream2;
        codedStream2.wrapper = this;
    }

    public static java.lang.long ABkVXjcSinbPcclf(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool APAzVlNXGXAkKZck(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static androidx.datastore.preferences.protobuf.Protobuf APjfImbkJwconqQa() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static java.lang.int AVwArvvbOKPOiAln(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool AWJWaWAntODkqnZJ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static double AYSdcXzKCLsyEdnl(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((18 + 11) % 11 > 0) {
        }
        return codedStream.readdouble();
    }

    public static java.lang.float AfqxNamvOpyhxlXf(float f) {
        return java.lang.float.valueOf(f);
    }

    public static int AiRPzxGmRpuYIYVu(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static int BAhtxPsQIkXLcTkc(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int BDqghtCHoXFVjsHV(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static double BGNWqEEGkhbqUyJf(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        if ((5 + 5) % 5 > 0) {
        }
        return codedStreamReader.readdouble();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException BInNGaKumhstNDQq() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int BJCXqxqrwTLptPiq(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readInt32();
    }

    public static bool BRrSixlgYqyXUwTY(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static int BcnnqivJmICWMjfu(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readFixed32();
    }

    public static java.lang.object BiTbfLNwSyvpKHcs(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return codedStreamReader.readMessage(schema, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException BmqoSdFPukgGyHcl() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static bool BnvZGysgJvRRdVGt(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static bool BoFdTPQpMkMRtHrD(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static long BreWvndhGhaPrUTA(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((13 + 24) % 24 > 0) {
        }
        return codedStream.readUInt64();
    }

    public static void CJlMfQwpEPlzjVpo(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static int CPijvGJYSuhSkPhN(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static void CPmQRoxgQuuaagGG(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static bool CTGPsuQJvXzkoQeJ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static int CXxrJWpjAxKyWGMl(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static java.lang.double CbESvYYQbGnAvFiD(double d) {
        return java.lang.double.valueOf(d);
    }

    public static int CcGXCtKuendGLpsU(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static bool CdfnuNOUMdxRcdrD(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int CoTUpMLSrqMkdPDy(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static long CtMTLviONJQanDXP(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((10 + 9) % 9 > 0) {
        }
        return codedStream.readSInt64();
    }

    public static int DJEJAmuGayZFbVyA(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int DJHULeKGFATOUsJB(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static java.lang.int DUvDOXFAOUUFuPPa(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int DZAwzfyJnzxwjmhq(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static void DgjhhLMULIrgZNKa(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        codedStreamReader.mergeMessageFieldInternal(obj, schema, extensionRegistryLite);
    }

    public static java.lang.int DhhlWzLyyeaTFhQO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool DlCOwdkuHnvDAbZE(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void DmboRVaqXyGWalQF(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static void DmgDajzpbzYuNWTl(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, java.util.List list, bool z) throws java.io.IOException {
        codedStreamReader.readstringListInternal(list, z);
    }

    public static void DsiVinlHVYIukMdq(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static int DupNYmqbZUBzvcIK(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readEnum();
    }

    public static void DwFwxViIgPbETMCx(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj) {
        schema.makeImmutable(obj);
    }

    public static androidx.datastore.preferences.protobuf.Schema EKHjAMXhcxKknQZM(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.Class cls) {
        return protobuf.schemaFor(cls);
    }

    public static java.lang.int ELokpYvAQfpKSiFB(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int EVHUyQpJnaVkCZik(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readEnum();
    }

    public static bool EdsgyDJPgooyaspj(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static void EhnPRLCIIbTcUEmJ(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static long EmCfgJdoHVZQhTTF(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((20 + 4) % 4 > 0) {
        }
        return codedStream.readFixed64();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException EmVRZImLnoVQHzHD() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static long EnTSoFkykDhRCtNp(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((6 + 29) % 29 > 0) {
        }
        return codedStream.readFixed64();
    }

    public static void FAGZCZrbvEzmDcnJ(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.verifyPackedFixed64Length(i);
    }

    public static bool FByHBHhCEFAJymmF(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readBool();
    }

    public static void FWSmbIbkQCfwNxQs(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static java.lang.int FdKrkLHTBrbKxVmC(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long FinRrVsjDvlDwjtL(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((30 + 20) % 20 > 0) {
        }
        return codedStream.readSInt64();
    }

    public static int FjBNIYSlgvOehabA(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static int FjnJtMcmtHqnqoLZ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int GJNREKgvrPlATrip(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readInt32();
    }

    public static bool GKlLyxFqjpXZTilZ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static void GLRhRYUaFoEtrexQ(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static bool GNpWQHbMMkxJcZIw(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static int GOQcVkCAlZRnxfpF(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static bool GUSezKvefmwNZmnf(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.shouldDiscardUnknownFields();
    }

    public static int GVmVujQlYlmpVazU(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException GWqXvaHpFLpuMzec() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static bool GzSJpqVqmoCSXdji(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static int HIECkZfxaLFbecgJ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readSInt32();
    }

    public static int HJowipcBObsnynSR(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int HNxamsUzlaftzlKr(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException HVRFFBwCaAzrdgKq() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int HXqofFfZBTGptkfa(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static void HfacuEJZPxrriTsJ(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static int HkzislMabUkZKsEF(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static int HoGpyaxQNabrTscw(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException HsLoZcTujoPjtiHz() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static bool IDdxGGliWaYQMlDW(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int IGiUxLxrtcFAvEqT(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static int IPBJIKAjqujZphak(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int ITZFbJOTCUWEDwpO(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int ITcQoGxLrxEObtye(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static java.lang.string IXlZSUItYKeinQJW(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readstring();
    }

    public static bool IYoabDkpDjcFKokE(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int IZkSHVCunGElCurO(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static java.lang.string IgTFozhLtlQwIKXq(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readstringRequireUtf8();
    }

    public static long ImQFrsxUFfXpmHDz(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((3 + 11) % 11 > 0) {
        }
        return codedStream.readSInt64();
    }

    public static int JMGvBgHLFElVziOZ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException JOiuPTsAwGQqwkuX() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void JSryihrQOrnZHsTN(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static void JZQBAxvRKhrOMyvX(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static java.lang.long JfgfKQURtQnQPgxW(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void JmiTPLzGcxjwcGYe(androidx.datastore.preferences.protobuf.floatList floatList, float f) {
        floatList.addfloat(f);
    }

    public static void JoGcxDlrvzkclRuU(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static bool JoYIrZemaZXqbyfV(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object JzplxOeODRfNfLFh(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, java.lang.Class cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return codedStreamReader.readField(wireFormat$FieldType, cls, extensionRegistryLite);
    }

    public static bool KFTSsGigSdnIRddv(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void KJTlyrmsUsiaoYLJ(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static void KPanpNjZWrObHmBL(androidx.datastore.preferences.protobuf.LazystringList lazystringList, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        lazystringList.Add(bytestring);
    }

    public static void KPedVGGvkbNvQGko(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.verifyPackedFixed32Length(i);
    }

    public static int KVEcTTXKrpiLcijS(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static java.lang.object KZafkEXimKAOEkRL(androidx.datastore.preferences.protobuf.Schema schema) {
        return schema.newInstance();
    }

    public static bool KdFFqOsYmdWsJMdp(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static double KdKWLlsAkhVjOTws(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((28 + 1) % 1 > 0) {
        }
        return codedStream.readdouble();
    }

    public static int KdyQcHiAKCqOFJFN(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException KlrmqVQsSiawxtfE() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static bool KntSHIHachvDdDsL(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException KqioWVEBtFWprOiH() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int KywXoXvawbmXsxYJ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static int LECuHDCisrkXJTqe(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static void LFcUiFfHwEyUaaqX(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.verifyPackedFixed64Length(i);
    }

    public static int LQKdYKWmGixyQwtz(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static bool LaBFxpcBukpHlytH(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) {
        return codedStream.skipField(i);
    }

    public static void LdGzvhutCSLzwbZp(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) {
        codedStream.popLimit(i);
    }

    public static long LfSLPwsOZjWWaxrv(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((14 + 13) % 13 > 0) {
        }
        return codedStream.readInt64();
    }

    public static bool LfddIltCtsmYkMTT(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static int LhJOAGygEgTnHgxh(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static int LmWecobEhvprAtFC(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException LuUWfQbbnHnjfEhU() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void LwmOFQuJRXQyyEln(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, java.util.List list, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        codedStreamReader.readGroupList(list, schema, extensionRegistryLite);
    }

    public static void MFPkCbmwoRNykPXE(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static long MJcqWYHuzqtOqxVq(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((28 + 2) % 2 > 0) {
        }
        return codedStream.readSInt64();
    }

    public static java.lang.int MLHomQGUjkKCJZvm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int MMlhYMvcJEhXjdiw(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int MaRkgDiwYFoyMUIA(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static androidx.datastore.preferences.protobuf.bytestring MeyZDUpWrXHJpNnz(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readbytes();
    }

    public static bool MhJHlQNBlSKOABTX(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static bool MhpOYMxidjrbVxIH(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int MpezDRLaCLNCuJYi(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static bool MrjcXxLxYOwwXGsl(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static int MwJUuJlbzEMIqDiD(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int MwYpuPUKOxIJFAkP(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int NAhfGMpfudQRbsDL(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException NIIIFSVIjATEfASK() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static long NJkybhtaqRXdzPPY(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((15 + 22) % 22 > 0) {
        }
        return codedStream.readFixed64();
    }

    public static int NMIqZjtwdVFxBPDt(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int NMNsAGwxHlqJnpWk(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int NoOPALDcBENQHWPJ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static java.lang.int NxAqhWsOlDYshcWV(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int OGTZgppBpTkQusSe(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static bool OIQBBTtPDyiiDHTr(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readBool();
    }

    public static void OIlESraTFtUbOQiu(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj) {
        schema.makeImmutable(obj);
    }

    public static int OVvfgescpjXtPATc(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int OXlEfLvFCWkksClX(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int OYnGrGeRceFUeCwD(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readSInt32();
    }

    public static int OdmfsPHTUFOajwqJ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static bool OrBbgtePOQymTiYT(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static void OsnVRxpErHqncXeR(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static long PMVROQQCwfLORoic(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((23 + 21) % 21 > 0) {
        }
        return codedStream.readUInt64();
    }

    public static int PNJcgmqzGgEJhAQI(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static java.lang.long POnbKixfwuyotryI(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void PUJqjiQbczvtxoLM(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, java.util.List list, bool z) throws java.io.IOException {
        codedStreamReader.readstringListInternal(list, z);
    }

    public static void PZrKkDDKDlFsaEVr(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static int PfsbeoeMvPuLeoHa(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readSFixed32();
    }

    public static int PjHOGCQyNvECdxCk(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readInt32();
    }

    public static long PpsyphAsDbbKgHpO(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((2 + 25) % 25 > 0) {
        }
        return codedStream.readUInt64();
    }

    public static bool PzzgJZpcVVmFuxyB(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException QFxzBFmusobPLort() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure();
    }

    public static int QTqjMqUIblmgIQOE(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException QUqszTthLqtfmOQi() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static long QWMaLCbIIaQuiiAY(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((13 + 28) % 28 > 0) {
        }
        return codedStream.readSFixed64();
    }

    public static int QbZTkKtIXsRwWhpT(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static java.lang.bool QdtCMqwkmJyjhRsu(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool QfFgFjDICrStWaNB(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void QkxDCkYeUHbrXRJp(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static int QxIcymCAzdKZPukM(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int QxPmHizidAalIvcP(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int RJbCBpcrPwsYMKil(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static void RNLHIuSMNuuOjGfO(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static int RUppcIzOCEqkEzIP(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int RdAXzyoUJohRHPuX(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int RnDYVooINWYkUBQD(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int RrekiwwnAzmrhInK(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static void SJPjKImlZbXMotCL(androidx.datastore.preferences.protobuf.boolList boolList, bool z) {
        boolList.addbool(z);
    }

    public static void SKipGnGBQDaKDwrj(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        codedStreamReader.mergeGroupFieldInternal(obj, schema, extensionRegistryLite);
    }

    public static void SScmJXVWSxfovWWU(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) {
        codedStream.popLimit(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException SdzVVZLiiJpifMXH() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void SeghpavrKWPWUeDu(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static int SlILPzezYwHEfSgW(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int SlbDYsDbjESlxqbC(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static bool SmDJCtICbkciiiqQ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static long SsjlTjwGrbgdMxsj(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        if ((14 + 15) % 15 > 0) {
        }
        return codedStreamReader.readUInt64();
    }

    public static int SyGUDkqCocmEmOzO(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readFixed32();
    }

    public static bool TAqIrgFvkiPinwWV(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool TBnmlEXWhWVAAfVV(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool TRxmWIzjiqYdIVVx(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int TfTqGFkKBSiQUTdE(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readEnum();
    }

    public static void TjbIpXknXMCFISWU(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static void TtCqmTWuBaQOpoyS(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static bool TtKrYOeMonhTSHMj(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException UCwvdzuQblKOmKos() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure();
    }

    public static int UODqzJkZooktrRtv(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int UcDblMzhMYCLtGDc(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException UiVECmQtjtjwkkPe() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure();
    }

    public static void UkjggIOtvxiBxIsV(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static void UtfJzSywvWXnhAUN(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.verifyPackedFixed32Length(i);
    }

    public static void UtgaDswZneHashSetXvC(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static int UxWrMAFfcVTlpddb(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static androidx.datastore.preferences.protobuf.Schema UzkNRGzsfmFZAwzY(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.Class cls) {
        return protobuf.schemaFor(cls);
    }

    public static void VGXuAXHkKEvfCheQ(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static int VNDZmJDUplSAbRsT(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readSInt32();
    }

    public static bool VPNSQAwMYzdcWagX(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void VPgliAOjgNxDBGpb(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static int VRwOYvjdoEkrdZvT(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readInt32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException VUKUdTWEAZxbpvdR() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static bool VdirBTGVfKIIOUvD(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int VfSEZgPVpAYfEzVl(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static bool VnQWqMhHVdYBuVzr(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool VoEhRlLAlQPueBun(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static int WKVzLnaCydpZbRkl(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static float WNaYvhXieXNJwCoh(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readfloat();
    }

    public static int WNybxmvpyOSsBMnN(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static java.lang.object WSEczYXliEdImjOy(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return codedStreamReader.readMessage(schema, extensionRegistryLite);
    }

    public static int WShUUkCGnrrJeDdh(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static void WbxrCsNYOjTScMbX(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static int WcrFUNTtTGnLLWUC(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int WgGhzfACJXYXeXBV(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int WmaYuyMSUXeQbXhp(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static float WuRREErjXGVBMlmY(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readfloat();
    }

    public static int WuwGRnTSRgkHQMcJ(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readSFixed32();
    }

    public static long XIpVWMCHESTOYQcD(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((32 + 23) % 23 > 0) {
        }
        return codedStream.readInt64();
    }

    public static java.lang.long XLOaTvQBlAkyBQpb(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void XMdltPHcIbQsmuWA(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.verifyPackedFixed32Length(i);
    }

    public static java.lang.long XOjKEfeRZymPOuHL(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int XZLZaozDtHGujZbh(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readEnum();
    }

    public static int XaLLmRyIjRowwiMa(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readEnum();
    }

    public static int XldXGfLhcEQyXgln(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static void XsDybKyKqBOkFOrD(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static bool XtNXguIukjZCtgFM(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readBool();
    }

    public static void XujXPJPwvjBSrxfA(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static bool YPAHqDHFWlHMtXcQ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static float YPkadNEjLzunMqsV(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readfloat();
    }

    public static java.lang.long YTfvJDcalhBNpLmA(long j) {
        return java.lang.long.valueOf(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException YZsVRiDwgLjmwBik() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int YhOywnfrpGwQyJfx(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static void YjTFqTVeuFjcmgXH(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static int YmSvzEPeENAnBMBG(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException YutYvcokxsEywJHL() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static bool YvCYVgMbaQSIwtho(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static int YviesBwloceTeQoz(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int ZEiOsEPgxIzMCLAJ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static int ZJtaRnKJVFJHUSOM(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static void ZUdVaNCFnBLjOqZs(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static int ZaGCeJQQyOFufqcg(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readSFixed32();
    }

    public static java.lang.long AGmWCsWuVfnhdeCc(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object AHZVGXwXaytVZqxF(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return codedStreamReader.readMessage(schema, extensionRegistryLite);
    }

    public static void AHvQHXRGoNAUhDWL(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, java.util.List list, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        codedStreamReader.readMessageList(list, schema, extensionRegistryLite);
    }

    public static bool ALmoLVmZUqwptMxL(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static bool AiZYQeECkWsZaqbS(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static void AkwaKHYCRoCSSVTf(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static int AtgkXyNqiERkvXUq(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static int AwZzwIycLzSlMnmC(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException bFLFLXWYuDaWxOgO() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int BKjFyoEDEgVDJCWb(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static long BMJNEohiQpbhqxKw(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((13 + 21) % 21 > 0) {
        }
        return codedStream.readFixed64();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException bNZGVeHGuOhdQDwT() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int BOrQRSxJxnSIoyft(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int BXblJAVcTrGjQgiW(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int BabJodScYNwpHXWI(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readUInt32();
    }

    public static double BkLkbvAaoUwlXBJz(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((14 + 10) % 10 > 0) {
        }
        return codedStream.readdouble();
    }

    public static androidx.datastore.preferences.protobuf.Schema BlisJSTOFRfVlqLW(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.Class cls) {
        return protobuf.schemaFor(cls);
    }

    public static float BrgkIhZnCrUHVorH(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readfloat();
    }

    public static void BsaHYDnDCcvtzbna(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static java.lang.string BvpRuCyIssbMFdmW(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readstring();
    }

    public static androidx.datastore.preferences.protobuf.Protobuf BxglbmyMmIQGVsLv() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static int CBiPtNzjIgfmwqfK(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static java.lang.object CCbjCmNqUXNFjPcw(java.lang.object obj, java.lang.string str) {
        return androidx.datastore.preferences.protobuf.Internal.checkNotNull(obj, str);
    }

    public static java.lang.object CGFiVQdqtnoJulir(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return codedStreamReader.readGroup(schema, extensionRegistryLite);
    }

    public static void CJzjGpbcoLSLvBTM(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static bool CNRXUuVsgxOFERJC(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool CYhCcmkQisKQBfiq(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static int CZzzmPPicAsuHtUA(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int CcKtfwIniyZurzzJ(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int CeUmALwaixXqRmbV(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int CjbkDluSRONJBnYa(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static java.lang.object CsEjhdviKNqpRvit(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return codedStreamReader.readGroup(schema, extensionRegistryLite);
    }

    public static int CtixXsvUBADRbLeD(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static bool CyGPyYeScOMIDpMk(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string DDuxMmuzjwQoYqMh(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readstringRequireUtf8();
    }

    public static int DJArQzsKPgpWMSAx(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static void DKRvhqTRUtVsvwDO(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream.checkLastTagWas(i);
    }

    public static int DVSSkQTEwaXAgGPQ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static long DdpGWxgULraixAmO(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        if ((24 + 5) % 5 > 0) {
        }
        return codedStreamReader.readSFixed64();
    }

    public static void DfWNDtbqbdLnUlFp(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static int DlNqIraKYbzXVvjM(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int DovjDMcFhVMIoTvU(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static bool EBQYZEPykJFdvVRZ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string EDDpaMjtPCNIViVD(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readstringRequireUtf8();
    }

    public static int EKemUTWzRiyizbBW(androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType) {
        return wireFormat$FieldType.ordinal();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException eUCZVwtlfWYnXWja() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static long EnQksFGstlpYRBMQ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((15 + 5) % 5 > 0) {
        }
        return codedStream.readFixed64();
    }

    public static long EpkukfCEhppgneCo(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        if ((14 + 8) % 8 > 0) {
        }
        return codedStreamReader.readSInt64();
    }

    public static java.lang.int EtzPBCGoTTtPelUm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException exTlZiOaXKZIxtqH() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static java.lang.long FAgAmzlPurCEVGxf(long j) {
        return java.lang.long.valueOf(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException FCVOnLalBWVncpcv() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.recursionLimitExceeded();
    }

    public static int FCZYZbRmABqLLokB(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) {
        return codedStream.pushLimit(i);
    }

    public static int FFjUeubCbHvLvqWY(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static bool FGxebhbIBgQtyHaJ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int FIDsnoaIJBNlhVYu(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException fUewdtAAbNZUpWxl() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int FVzAiCUhRQxPcNHe(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static void FWZjOVeKfPljtlMB(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static int FdstKhPvVvRIBiXj(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static androidx.datastore.preferences.protobuf.bytestring FnepuSqpjDKyHMsZ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readbytes();
    }

    public static androidx.datastore.preferences.protobuf.CodedStreamReader ForCodedInput(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.wrapper is null ? new androidx.datastore.preferences.protobuf.CodedStreamReader(codedStream) : codedStream.wrapper;
    }

    public static int FyyjvoIzkznhDFOI(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static bool GDGiJSQzOkrbCgvY(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool GEcsCzMRpuSCnbZu(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static long GHADIBTmdTWikvPp(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((28 + 9) % 9 > 0) {
        }
        return codedStream.readUInt64();
    }

    public static java.lang.double GOMtWQKBJpZTKjFJ(double d) {
        return java.lang.double.valueOf(d);
    }

    public static int GUibgZQConwdKulA(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static void GaMOVyVBuDPKoPXn(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static void GalZnvTFXDVEzdix(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.verifyPackedFixed32Length(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException gjEXiEGyHfWYSsJe() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int GkfeprePGCToVfvD(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.getFieldNumber();
    }

    public static int GkqcXfcYpeZxnuBk(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int GlAvQRHLUkoAttMv(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static int GuZoXjRpQVwkkeyv(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int HCtbYqgwKLrZLbTV(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static java.lang.int HPewJxGgGqsFgkZX(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int HTSsoabAHzdEJDOg(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int HWqZEVrvHTYDHgtE(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int HXJnDxercvIgugby(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readFixed32();
    }

    public static int HaWDZLFbrQuCpazE(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readFixed32();
    }

    public static void HiFmHFXBOOOAQGVD(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static int HiiZQnHiGZYLfMQV(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static bool HkaUQQIaMRrtYGde(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static float HpLLTxHJklCPEZgx(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readfloat();
    }

    public static void HwABsfZXrumUMzig(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.verifyPackedFixed32Length(i);
    }

    public static int IDvVCmLmTPOnJdvP(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int IHZWRvPAtNVqYwTE(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static java.lang.int IWdDLDmkRqeElZoJ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.Class IZeHWNIajyUFPJGv(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.bool IarsvkPeIzPxXLuT(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static int IiYfcpsPYMPqSCui(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static bool IjVvVeMMtqEYxOTa(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.long IkohmbQJmXGVEmhh(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long IpReGwXHqHbWPXxB(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((13 + 16) % 16 > 0) {
        }
        return codedStream.readSFixed64();
    }

    public static bool IxNqkWcLOxmNAPVT(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.skipField();
    }

    public static void JEpDpBXlYaHyHNnp(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Reader reader, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        schema.mergeFrom(obj, reader, extensionRegistryLite);
    }

    public static void JGRiwemlqUuZIsfQ(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static int JHyqsBPangmXgYEv(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static java.lang.int JOZRTxCfsNJUcJXx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int JSJsJdISRtvNbDfC(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int JbSiNCCVXRDCSsMf(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static double JdsuZVdxcpLVgAqQ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((27 + 30) % 30 > 0) {
        }
        return codedStream.readdouble();
    }

    public static int JeUHojbevKpcpzcf(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static long JkKgbnelcvLeqaMt(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((8 + 27) % 27 > 0) {
        }
        return codedStream.readSFixed64();
    }

    public static java.lang.int JllggADieaxATojy(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int JteEpGIASvPCoMZX(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int KFClOnFxQDrjaZFW(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int KJMaZpDtfHGjdcas(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static void KJvZLEEHaWqvXerw(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static int KPtEZdYuSuJRTGZg(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int KRqLMVFdvRUVcNOq(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static java.lang.float KUBTUZqIjIhdrUOY(float f) {
        return java.lang.float.valueOf(f);
    }

    public static bool KhBkEijgfdlSHiVb(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static long KhMAmOjOxfuqfNYZ(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        if ((25 + 23) % 23 > 0) {
        }
        return codedStreamReader.readInt64();
    }

    public static long KvYPgBJjvieNtwcB(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((8 + 12) % 12 > 0) {
        }
        return codedStream.readInt64();
    }

    public static int LFopAcUQwkEFPVSm(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readSFixed32();
    }

    public static bool LHzEvtyFjGstUjSB(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static int LYXtWPpJfeehrGFL(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static void LbCVvshAsHwPpWCf(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException ldEYNgbEPMXQgLhi() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int LeWFnYBdZkYxynhf(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readSFixed32();
    }

    public static bool LfPVCQebpJmUBncF(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static java.lang.int LmLVeQJdxiWFxjJb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int LpxCvgZtGEXlaHfm(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException lqUCVzaWOWexNxeu() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException lyvpydkUbbPBiUQw() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int MECNAfKggLlKcRKV(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException mECndvFooExIErUg() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static java.lang.long MGcvRosgrjaWTWek(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void MQyCCqJKKaheivcc(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static bool MSkWxGPVegarRTxv(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    private <T> void MergeGroupFieldInternal(T t, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((8 + 16) % 16 > 0) {
        }
        int i = this.endGroupTag;
        this.endGroupTag = HkzislMabUkZKsEF(DZAwzfyJnzxwjmhq(this.tag), 4);
        try {
            jEpDpBXlYaHyHNnp(schema, t, this, extensionRegistryLite);
            if (this.tag != this.endGroupTag) {
                throw QFxzBFmusobPLort();
            }
            this.endGroupTag = i;
        } catch (java.lang.Exception th) {
            this.endGroupTag = i;
            throw th;
        }
    }

    private <T> void MergeMessageFieldInternal(T t, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((28 + 14) % 14 > 0) {
        }
        int iFFjUeubCbHvLvqWY = fFjUeubCbHvLvqWY(this.input);
        if (this.input.recursionDepth >= this.input.recursionLimit) {
            throw fCVOnLalBWVncpcv();
        }
        int iNWwuEmNcoIaPnNnI = nWwuEmNcoIaPnNnI(this.input, iFFjUeubCbHvLvqWY);
        this.input.recursionDepth++;
        mztstwqZRVduhHal(schema, t, this, extensionRegistryLite);
        dKRvhqTRUtVsvwDO(this.input, 0);
        androidx.datastore.preferences.protobuf.CodedStream codedStream = this.input;
        codedStream.recursionDepth--;
        tniIjyrUHHzlpOZU(this.input, iNWwuEmNcoIaPnNnI);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException mhFUvZnnzzRQufwH() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void MmaZKzRFFvFfwTuV(androidx.datastore.preferences.protobuf.doubleList doubleList, double d) {
        doubleList.adddouble(d);
    }

    public static java.lang.int MnZjWtKLSzwhxPxx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int MoKBmEfZwAOHlcON(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readSInt32();
    }

    public static int MrTgbIzazunsYDni(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static void MzaUtnziThWkZAVF(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static void MztstwqZRVduhHal(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Reader reader, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        schema.mergeFrom(obj, reader, extensionRegistryLite);
    }

    public static java.lang.object NFBjveFngloXKESl(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, java.lang.Class cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return codedStreamReader.readField(wireFormat$FieldType, cls, extensionRegistryLite);
    }

    public static bool NNFkOEtIJMmUDNpW(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static int NWwuEmNcoIaPnNnI(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) {
        return codedStream.pushLimit(i);
    }

    public static void NbUCUfbpffbReclu(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static java.lang.int NbfmYpsCXVPReSwz(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int NijawlffmuzuGTrs(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static void NjvzVrQEMwhnbUtB(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.verifyPackedFixed64Length(i);
    }

    public static int NkdscTdRwkzjbaGb(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static bool NldMBKDinspenBwD(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static long NnFsmMiPoWKxoftT(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((30 + 8) % 8 > 0) {
        }
        return codedStream.readInt64();
    }

    public static java.lang.int NwGxWXsETmqiVybX(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void NxJBtireSjOuRtYQ(androidx.datastore.preferences.protobuf.boolList boolList, bool z) {
        boolList.addbool(z);
    }

    public static int ONnnOqfQAKJsPEOL(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static bool OPlicmWnIVzrCaza(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int OTIwYTQGReQoBUQD(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static void OTrhJApokOHPDgAL(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static void OUIZpfZPGUnclEyn(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException omgFdKbotZxQHVSD() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException ooUBjAILCMIkmqlx() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static java.lang.long OpxzroOCZwkBwcZp(long j) {
        return java.lang.long.valueOf(j);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException oyEImfDRBdoArQwW() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int OyVfiBKchcDZvnHc(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static java.lang.int OzdCurOUVNZdyNWU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int PDcMZGRnudqqRZsn(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static java.lang.long PKdnTTIKAHbfyFXM(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool PVdMOmgIzGbxDrQy(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static void PZRDdLnMsZXCCBVq(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static int PeFxgqrcoTpyUzfl(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int PkKsLhvfmcVRvgGa(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static int PpRiNFpCUQrlNCNY(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readEnum();
    }

    public static bool PpUaFNCwkqysNwWT(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readBool();
    }

    public static int PxwQKgoHCxOTSHLp(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int PydzmEHtlikquNhR(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readInt32();
    }

    public static bool QDRyDeQdtMpKUjlm(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readBool();
    }

    public static void QGwlkOJwIkSHZLLW(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        codedStreamReader.mergeGroupFieldInternal(obj, schema, extensionRegistryLite);
    }

    public static bool QGzYiUzhrhHdTVqX(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int QJBDXADToRgmaDsQ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static java.lang.int QMGMRvYxGeoUDLEc(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long QOjjZqOvhFzIbaUG(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((19 + 27) % 27 > 0) {
        }
        return codedStream.readInt64();
    }

    public static int QYrUKUoKLwGzQrnV(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static void QbgGHmJRaLycMsaw(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static bool QbvHJIncSVImWXvI(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.skipField();
    }

    public static int QfuFMJCmDuCIMCqC(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readFixed32();
    }

    public static int QjLhJpXCRHMiIVfz(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int QovjYRKlNyxPPsGV(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static bool QqGOcPITlWhqkkES(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int QqXfYxCRXqmheRqN(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int QwlBzWbRPkHAdNhm(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static void QyrepnhiaxWyGcCs(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static java.lang.long RBdmPREnPQkzmwzP(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object ROyQGThBvWxKmwDl(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, java.lang.Class cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return codedStreamReader.readMessage(cls, extensionRegistryLite);
    }

    public static void RRQTcmvzRKxSPGLl(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        codedStreamReader.mergeMessageFieldInternal(obj, schema, extensionRegistryLite);
    }

    public static int RbnCfBdgtAVhvVBr(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException reWdeuWEZzChmPRR() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    private java.lang.object ReadField(androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, java.lang.Class<object> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        switch (androidx.datastore.preferences.protobuf.CodedStreamReader$1.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType[eKemUTWzRiyizbBW(wireFormat$FieldType)]) {
            case 1:
                return vTevhBpZZTUULWdO(XtNXguIukjZCtgFM(this));
            case 2:
                return tCUwMlTLgNNqiroD(this);
            case 3:
                return CbESvYYQbGnAvFiD(BGNWqEEGkhbqUyJf(this));
            case 4:
                return qMGMRvYxGeoUDLEc(XaLLmRyIjRowwiMa(this));
            case 5:
                return MLHomQGUjkKCJZvm(BcnnqivJmICWMjfu(this));
            case 6:
                return POnbKixfwuyotryI(sfXenxBZfYHPVvEQ(this));
            case 7:
                return kUBTUZqIjIhdrUOY(WNaYvhXieXNJwCoh(this));
            case 8:
                return DhhlWzLyyeaTFhQO(VRwOYvjdoEkrdZvT(this));
            case 9:
                return YTfvJDcalhBNpLmA(khMAmOjOxfuqfNYZ(this));
            case 10:
                return rOyQGThBvWxKmwDl(this, cls, extensionRegistryLite);
            case 11:
                return lmLVeQJdxiWFxjJb(WuwGRnTSRgkHQMcJ(this));
            case 12:
                return vKsVRNNJfzQHLqyQ(ddpGWxgULraixAmO(this));
            case 13:
                return iWdDLDmkRqeElZoJ(moKBmEfZwAOHlcON(this));
            case 14:
                return opxzroOCZwkBwcZp(epkukfCEhppgneCo(this));
            case 15:
                return eDDpaMjtPCNIViVD(this);
            case 16:
                return nwGxWXsETmqiVybX(babJodScYNwpHXWI(this));
            case 17:
                return rBdmPREnPQkzmwzP(SsjlTjwGrbgdMxsj(this));
            default:
                throw new java.lang.IllegalArgumentException("unsupported field type.");
        }
    }

    private <T> T ReadGroup(androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        T t = (T) uOcoOlseLkKnlMGe(schema);
        qGwlkOJwIkSHZLLW(this, t, schema, extensionRegistryLite);
        DwFwxViIgPbETMCx(schema, t);
        return t;
    }

    private <T> T ReadMessage(androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        T t = (T) KZafkEXimKAOEkRL(schema);
        rRQTcmvzRKxSPGLl(this, t, schema, extensionRegistryLite);
        OIlESraTFtUbOQiu(schema, t);
        return t;
    }

    private void RequirePosition(int i) throws java.io.IOException {
        if (NoOPALDcBENQHWPJ(this.input) != i) {
            throw BmqoSdFPukgGyHcl();
        }
    }

    private void RequireWireType(int i) throws java.io.IOException {
        if (GOQcVkCAlZRnxfpF(this.tag) != i) {
            throw KqioWVEBtFWprOiH();
        }
    }

    public static int RgLYXWMAgHxVEKNd(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int RlHHxgFSmCVeSpsl(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static int RyhuMmqcVflhAwpS(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static void SCyDuvGouQWkfOFt(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static bool SDtPwqwZYoZLKUwm(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static void SKaEhPeQnXkIHasB(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.verifyPackedFixed64Length(i);
    }

    public static bool SKpQmuftjpmBdaXP(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static void SMXHMQenxaPlyLaE(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static java.lang.long SPgjcJXnNwhcTDMl(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int SawOZqbRbtQwkWsV(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readSFixed32();
    }

    public static long SfXenxBZfYHPVvEQ(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        if ((32 + 14) % 14 > 0) {
        }
        return codedStreamReader.readFixed64();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException sgQJfjjArFkkdaBw() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static long SnRhuzMiAWLpqWep(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((4 + 13) % 13 > 0) {
        }
        return codedStream.readSInt64();
    }

    public static bool SufmYvCAUPKDemEx(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static int SxTMTcAmoEIPfKoN(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int TBtVuwKIkIknCfqJ(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static androidx.datastore.preferences.protobuf.bytestring TCUwMlTLgNNqiroD(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readbytes();
    }

    public static int TFqqsibrMyypEqBw(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static int TJRbgAZjSUnQPrvN(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int TOlTsMbQYeupiBhg(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static double TXmHhexkeljtQrLs(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((4 + 3) % 3 > 0) {
        }
        return codedStream.readdouble();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException taMOBuwCCnnzrgPX() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static int TjIGcEZeESTAHrGg(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static void TniIjyrUHHzlpOZU(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) {
        codedStream.popLimit(i);
    }

    public static int TxsjacuqlNCKbGYg(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static bool UBVrUFQjexTnoQrn(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static void UEIHpPQyucmDITjS(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static int UIgtBpEwQqmcARgk(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static java.lang.object UOcoOlseLkKnlMGe(androidx.datastore.preferences.protobuf.Schema schema) {
        return schema.newInstance();
    }

    public static int UUQLMajfVsoyhUzX(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readSInt32();
    }

    public static void UcDGGmcxXapSMxli(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static int UfOBOMZPXjTGwKjN(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static java.lang.object UmYCquYsmHrGlvYh(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, androidx.datastore.preferences.protobuf.Schema schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return codedStreamReader.readGroup(schema, extensionRegistryLite);
    }

    public static int UwFHbvwymcgvfqka(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readFixed32();
    }

    public static void UxgZKthAmAEjVCeQ(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static int VKTGMVoMpMpcpHYr(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static java.lang.long VKsVRNNJfzQHLqyQ(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void VMdJGjpZHVnbWzFt(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static bool VSknCpHMFuHFmjRQ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readBool();
    }

    public static java.lang.bool VTevhBpZZTUULWdO(bool z) {
        return java.lang.bool.valueOf(z);
    }

    private void VerifyPackedFixed32Length(int i) throws java.io.IOException {
        if ((i & 3) != 0) {
            throw UCwvdzuQblKOmKos();
        }
    }

    private void VerifyPackedFixed64Length(int i) throws java.io.IOException {
        if ((i & 7) != 0) {
            throw UiVECmQtjtjwkkPe();
        }
    }

    public static void VkBcIviHTBHRHzxM(androidx.datastore.preferences.protobuf.longList longList, long j) {
        longList.addlong(j);
    }

    public static void VoyJLmmYflatCTfw(androidx.datastore.preferences.protobuf.doubleList doubleList, double d) {
        doubleList.adddouble(d);
    }

    public static void VvUQWULobayRBoqM(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException vvdZdclUIQBWgRLB() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
    }

    public static void VwQbghIOiTOWMkyC(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static int WBKKnlwlScOfxGyd(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static int WMQpcGaRsvOBewGp(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static bool WPitsnacNCxEapUX(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object WUskxBCeViQnJzIq(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static int WZevkZRtFCCgjkhR(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static bool WaDclIxyDdeNbkIb(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void WatgmpsuyaZKiRDh(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static long WdeilKZUpgRTEElN(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((2 + 22) % 22 > 0) {
        }
        return codedStream.readSFixed64();
    }

    public static bool WlUFfmsvZZHaufcF(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static bool WrpIEQYlMumDMzvD(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static androidx.datastore.preferences.protobuf.bytestring WtfyYzYRuJvvXSWD(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader) {
        return codedStreamReader.readbytes();
    }

    public static int WvgjCuHbnClpasSQ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static int WxskjfvrQqHkCKOp(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
    }

    public static void XARBfORBiVFAoqNc(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.verifyPackedFixed64Length(i);
    }

    public static int XARnEEDFzxPsHfKX(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static void XCtRguQGxYUTzRaP(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.verifyPackedFixed64Length(i);
    }

    public static long XEaSwcTpnVIbSGlP(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((16 + 12) % 12 > 0) {
        }
        return codedStream.readUInt64();
    }

    public static bool XXFLPZxPnNykTHTt(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isAtEnd();
    }

    public static java.lang.double XpgkXrRcQzpijBXo(double d) {
        return java.lang.double.valueOf(d);
    }

    public static void XrxPNffvSSzaqOSJ(androidx.datastore.preferences.protobuf.floatList floatList, float f) {
        floatList.addfloat(f);
    }

    public static int XtzlWdYbtKWOObRs(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static void YDtWjHbMnylELxPY(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.verifyPackedFixed32Length(i);
    }

    public static int YFkPVwKlLxyeHPCt(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static int YGBWHOzqRyvHsHQR(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static void YGkQNMvzmbaDeTxg(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requirePosition(i);
    }

    public static void YGmNwFTWMNLArzmy(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        intList.addInt(i);
    }

    public static int YKWkKsPegDEUjIti(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int YPISnAmYLOFtnool(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int YPPIbtCpgugoIgbD(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int YQdKvxUVjYgLVVbS(int i) {
        return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
    }

    public static androidx.datastore.preferences.protobuf.Schema YagmxEFLhsnKJWRV(androidx.datastore.preferences.protobuf.Protobuf protobuf, java.lang.Class cls) {
        return protobuf.schemaFor(cls);
    }

    public static void YkZnHcVZzCJiwQzo(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static int YmOjgDZWOgCkCuvX(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readInt32();
    }

    public static java.lang.float YrorUokYZzWxIqjk(float f) {
        return java.lang.float.valueOf(f);
    }

    public static int YsGSolptejssSvhK(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesRead();
    }

    public static bool ZCRuAkyGxpasVqku(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static long ZDVzyEoIcsBvevml(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        if ((13 + 16) % 16 > 0) {
        }
        return codedStream.readSFixed64();
    }

    public static int ZJlhfmmSNdIccpzT(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static float ZQZywBLFWFsELYIk(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readfloat();
    }

    public static androidx.datastore.preferences.protobuf.Protobuf ZSHpoIyrYtLLMMTb() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static void ZVAIpnwNCQvKZbEJ(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static int ZWjLeMySpcezLnzy(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readUInt32();
    }

    public static androidx.datastore.preferences.protobuf.Protobuf ZeXPgmLVlbYkAUUB() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance();
    }

    public static void ZqpGEgHtyJvzwOzI(androidx.datastore.preferences.protobuf.CodedStreamReader codedStreamReader, int i) throws java.io.IOException {
        codedStreamReader.requireWireType(i);
    }

    public static int ZsAceIiNggtNLVjz(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readSInt32();
    }

    public override int GetFieldNumber() throws java.io.IOException {
        int i = this.nextTag;
        if (i == 0) {
            this.tag = mECNAfKggLlKcRKV(this.input);
        } else {
            this.tag = i;
            this.nextTag = 0;
        }
        int i2 = this.tag;
        if (i2 == 0 || i2 == this.endGroupTag) {
            return int.MAX_VALUE;
        }
        return wxskjfvrQqHkCKOp(i2);
    }

    public override int GetTag() {
        return this.tag;
    }

    public override <T> void MergeGroupField(T t, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        YjTFqTVeuFjcmgXH(this, 3);
        SKipGnGBQDaKDwrj(this, t, schema, extensionRegistryLite);
    }

    public override <T> void MergeMessageField(T t, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        qyrepnhiaxWyGcCs(this, 2);
        DgjhhLMULIrgZNKa(this, t, schema, extensionRegistryLite);
    }

    public override bool ReadBool() throws java.io.IOException {
        GLRhRYUaFoEtrexQ(this, 0);
        return FByHBHhCEFAJymmF(this.input);
    }

    public override void ReadBoolList(java.util.List<java.lang.bool> list) throws java.io.IOException {
        int iJteEpGIASvPCoMZX;
        int iYKWkKsPegDEUjIti;
        if ((6 + 17) % 17 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.boolList)) {
            int iTBtVuwKIkIknCfqJ = tBtVuwKIkIknCfqJ(this.tag);
            if (iTBtVuwKIkIknCfqJ == 0) {
                do {
                    VdirBTGVfKIIOUvD(list, QdtCMqwkmJyjhRsu(qDRyDeQdtMpKUjlm(this.input)));
                    if (MrjcXxLxYOwwXGsl(this.input)) {
                        return;
                    } else {
                        iJteEpGIASvPCoMZX = jteEpGIASvPCoMZX(this.input);
                    }
                } while (iJteEpGIASvPCoMZX == this.tag);
                this.nextTag = iJteEpGIASvPCoMZX;
                return;
            }
            if (iTBtVuwKIkIknCfqJ != 2) {
                throw ooUBjAILCMIkmqlx();
            }
            int iUcDblMzhMYCLtGDc = UcDblMzhMYCLtGDc(this.input) + LQKdYKWmGixyQwtz(this.input);
            do {
                IDdxGGliWaYQMlDW(list, iarsvkPeIzPxXLuT(OIQBBTtPDyiiDHTr(this.input)));
            } while (HJowipcBObsnynSR(this.input) < iUcDblMzhMYCLtGDc);
            pZRDdLnMsZXCCBVq(this, iUcDblMzhMYCLtGDc);
            return;
        }
        androidx.datastore.preferences.protobuf.boolList boolList = (androidx.datastore.preferences.protobuf.boolList) list;
        int iUODqzJkZooktrRtv = UODqzJkZooktrRtv(this.tag);
        if (iUODqzJkZooktrRtv == 0) {
            do {
                nxJBtireSjOuRtYQ(boolList, ppUaFNCwkqysNwWT(this.input));
                if (YvCYVgMbaQSIwtho(this.input)) {
                    return;
                } else {
                    iYKWkKsPegDEUjIti = yKWkKsPegDEUjIti(this.input);
                }
            } while (iYKWkKsPegDEUjIti == this.tag);
            this.nextTag = iYKWkKsPegDEUjIti;
            return;
        }
        if (iUODqzJkZooktrRtv != 2) {
            throw lqUCVzaWOWexNxeu();
        }
        int iOdmfsPHTUFOajwqJ = OdmfsPHTUFOajwqJ(this.input) + awZzwIycLzSlMnmC(this.input);
        do {
            SJPjKImlZbXMotCL(boolList, vSknCpHMFuHFmjRQ(this.input));
        } while (ceUmALwaixXqRmbV(this.input) < iOdmfsPHTUFOajwqJ);
        mzaUtnziThWkZAVF(this, iOdmfsPHTUFOajwqJ);
    }

    public override androidx.datastore.preferences.protobuf.bytestring Readbytes() throws java.io.IOException {
        EhnPRLCIIbTcUEmJ(this, 2);
        return fnepuSqpjDKyHMsZ(this.input);
    }

    public override void ReadbytesList(java.util.List<androidx.datastore.preferences.protobuf.bytestring> list) throws java.io.IOException {
        int iFjnJtMcmtHqnqoLZ;
        if ((1 + 4) % 4 > 0) {
        }
        if (IZkSHVCunGElCurO(this.tag) != 2) {
            throw oyEImfDRBdoArQwW();
        }
        do {
            TAqIrgFvkiPinwWV(list, wtfyYzYRuJvvXSWD(this));
            if (GKlLyxFqjpXZTilZ(this.input)) {
                return;
            } else {
                iFjnJtMcmtHqnqoLZ = FjnJtMcmtHqnqoLZ(this.input);
            }
        } while (iFjnJtMcmtHqnqoLZ == this.tag);
        this.nextTag = iFjnJtMcmtHqnqoLZ;
    }

    public override double Readdouble() throws java.io.IOException {
        if ((28 + 9) % 9 > 0) {
        }
        vwQbghIOiTOWMkyC(this, 1);
        return KdKWLlsAkhVjOTws(this.input);
    }

    public override void ReaddoubleList(java.util.List<java.lang.double> list) throws java.io.IOException {
        int iTOlTsMbQYeupiBhg;
        int iQjLhJpXCRHMiIVfz;
        if ((24 + 22) % 22 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.doubleList)) {
            int iHiiZQnHiGZYLfMQV = hiiZQnHiGZYLfMQV(this.tag);
            if (iHiiZQnHiGZYLfMQV == 1) {
                do {
                    KFTSsGigSdnIRddv(list, xpgkXrRcQzpijBXo(bkLkbvAaoUwlXBJz(this.input)));
                    if (OrBbgtePOQymTiYT(this.input)) {
                        return;
                    } else {
                        iQjLhJpXCRHMiIVfz = qjLhJpXCRHMiIVfz(this.input);
                    }
                } while (iQjLhJpXCRHMiIVfz == this.tag);
                this.nextTag = iQjLhJpXCRHMiIVfz;
                return;
            }
            if (iHiiZQnHiGZYLfMQV != 2) {
                throw lyvpydkUbbPBiUQw();
            }
            int iKywXoXvawbmXsxYJ = KywXoXvawbmXsxYJ(this.input);
            LFcUiFfHwEyUaaqX(this, iKywXoXvawbmXsxYJ);
            int iGVmVujQlYlmpVazU = GVmVujQlYlmpVazU(this.input) + iKywXoXvawbmXsxYJ;
            do {
                MhpOYMxidjrbVxIH(list, gOMtWQKBJpZTKjFJ(tXmHhexkeljtQrLs(this.input)));
            } while (yGBWHOzqRyvHsHQR(this.input) < iGVmVujQlYlmpVazU);
            return;
        }
        androidx.datastore.preferences.protobuf.doubleList doubleList = (androidx.datastore.preferences.protobuf.doubleList) list;
        int iNMNsAGwxHlqJnpWk = NMNsAGwxHlqJnpWk(this.tag);
        if (iNMNsAGwxHlqJnpWk == 1) {
            do {
                mmaZKzRFFvFfwTuV(doubleList, jdsuZVdxcpLVgAqQ(this.input));
                if (APAzVlNXGXAkKZck(this.input)) {
                    return;
                } else {
                    iTOlTsMbQYeupiBhg = tOlTsMbQYeupiBhg(this.input);
                }
            } while (iTOlTsMbQYeupiBhg == this.tag);
            this.nextTag = iTOlTsMbQYeupiBhg;
            return;
        }
        if (iNMNsAGwxHlqJnpWk != 2) {
            throw YZsVRiDwgLjmwBik();
        }
        int iPkKsLhvfmcVRvgGa = pkKsLhvfmcVRvgGa(this.input);
        xARBfORBiVFAoqNc(this, iPkKsLhvfmcVRvgGa);
        int iYsGSolptejssSvhK = ysGSolptejssSvhK(this.input) + iPkKsLhvfmcVRvgGa;
        do {
            voyJLmmYflatCTfw(doubleList, AYSdcXzKCLsyEdnl(this.input));
        } while (guZoXjRpQVwkkeyv(this.input) < iYsGSolptejssSvhK);
    }

    public override int ReadEnum() throws java.io.IOException {
        zqpGEgHtyJvzwOzI(this, 0);
        return DupNYmqbZUBzvcIK(this.input);
    }

    public override void ReadEnumList(java.util.List<java.lang.int> list) throws java.io.IOException {
        int iRgLYXWMAgHxVEKNd;
        int iYPISnAmYLOFtnool;
        if ((24 + 31) % 31 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iBKjFyoEDEgVDJCWb = bKjFyoEDEgVDJCWb(this.tag);
            if (iBKjFyoEDEgVDJCWb == 0) {
                do {
                    oPlicmWnIVzrCaza(list, ozdCurOUVNZdyNWU(TfTqGFkKBSiQUTdE(this.input)));
                    if (BoFdTPQpMkMRtHrD(this.input)) {
                        return;
                    } else {
                        iYPISnAmYLOFtnool = yPISnAmYLOFtnool(this.input);
                    }
                } while (iYPISnAmYLOFtnool == this.tag);
                this.nextTag = iYPISnAmYLOFtnool;
                return;
            }
            if (iBKjFyoEDEgVDJCWb != 2) {
                throw KlrmqVQsSiawxtfE();
            }
            int iIPBJIKAjqujZphak = IPBJIKAjqujZphak(this.input) + atgkXyNqiERkvXUq(this.input);
            do {
                qGzYiUzhrhHdTVqX(list, mnZjWtKLSzwhxPxx(ppRiNFpCUQrlNCNY(this.input)));
            } while (WKVzLnaCydpZbRkl(this.input) < iIPBJIKAjqujZphak);
            HfacuEJZPxrriTsJ(this, iIPBJIKAjqujZphak);
            return;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iQbZTkKtIXsRwWhpT = QbZTkKtIXsRwWhpT(this.tag);
        if (iQbZTkKtIXsRwWhpT == 0) {
            do {
                CJlMfQwpEPlzjVpo(intList, EVHUyQpJnaVkCZik(this.input));
                if (TtKrYOeMonhTSHMj(this.input)) {
                    return;
                } else {
                    iRgLYXWMAgHxVEKNd = rgLYXWMAgHxVEKNd(this.input);
                }
            } while (iRgLYXWMAgHxVEKNd == this.tag);
            this.nextTag = iRgLYXWMAgHxVEKNd;
            return;
        }
        if (iQbZTkKtIXsRwWhpT != 2) {
            throw BInNGaKumhstNDQq();
        }
        int iLmWecobEhvprAtFC = LmWecobEhvprAtFC(this.input) + CoTUpMLSrqMkdPDy(this.input);
        do {
            dfWNDtbqbdLnUlFp(intList, XZLZaozDtHGujZbh(this.input));
        } while (ITcQoGxLrxEObtye(this.input) < iLmWecobEhvprAtFC);
        JZQBAxvRKhrOMyvX(this, iLmWecobEhvprAtFC);
    }

    public override int ReadFixed32() throws java.io.IOException {
        ZUdVaNCFnBLjOqZs(this, 5);
        return hXJnDxercvIgugby(this.input);
    }

    public override void ReadFixed32List(java.util.List<java.lang.int> list) throws java.io.IOException {
        int iRJbCBpcrPwsYMKil;
        int iKVEcTTXKrpiLcijS;
        if ((21 + 26) % 26 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iYviesBwloceTeQoz = YviesBwloceTeQoz(this.tag);
            if (iYviesBwloceTeQoz == 2) {
                int iKJMaZpDtfHGjdcas = kJMaZpDtfHGjdcas(this.input);
                galZnvTFXDVEzdix(this, iKJMaZpDtfHGjdcas);
                int iNMIqZjtwdVFxBPDt = NMIqZjtwdVFxBPDt(this.input) + iKJMaZpDtfHGjdcas;
                do {
                    QfFgFjDICrStWaNB(list, etzPBCGoTTtPelUm(uwFHbvwymcgvfqka(this.input)));
                } while (jSJsJdISRtvNbDfC(this.input) < iNMIqZjtwdVFxBPDt);
                return;
            }
            if (iYviesBwloceTeQoz != 5) {
                throw QUqszTthLqtfmOQi();
            }
            do {
                cyGPyYeScOMIDpMk(list, FdKrkLHTBrbKxVmC(SyGUDkqCocmEmOzO(this.input)));
                if (pVdMOmgIzGbxDrQy(this.input)) {
                    return;
                } else {
                    iRJbCBpcrPwsYMKil = RJbCBpcrPwsYMKil(this.input);
                }
            } while (iRJbCBpcrPwsYMKil == this.tag);
            this.nextTag = iRJbCBpcrPwsYMKil;
            return;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iYQdKvxUVjYgLVVbS = yQdKvxUVjYgLVVbS(this.tag);
        if (iYQdKvxUVjYgLVVbS == 2) {
            int iJeUHojbevKpcpzcf = jeUHojbevKpcpzcf(this.input);
            KPedVGGvkbNvQGko(this, iJeUHojbevKpcpzcf);
            int iYhOywnfrpGwQyJfx = YhOywnfrpGwQyJfx(this.input) + iJeUHojbevKpcpzcf;
            do {
                UtgaDswZneHashSetXvC(intList, haWDZLFbrQuCpazE(this.input));
            } while (WcrFUNTtTGnLLWUC(this.input) < iYhOywnfrpGwQyJfx);
            return;
        }
        if (iYQdKvxUVjYgLVVbS != 5) {
            throw EmVRZImLnoVQHzHD();
        }
        do {
            MFPkCbmwoRNykPXE(intList, qfuFMJCmDuCIMCqC(this.input));
            if (SmDJCtICbkciiiqQ(this.input)) {
                return;
            } else {
                iKVEcTTXKrpiLcijS = KVEcTTXKrpiLcijS(this.input);
            }
        } while (iKVEcTTXKrpiLcijS == this.tag);
        this.nextTag = iKVEcTTXKrpiLcijS;
    }

    public override long ReadFixed64() throws java.io.IOException {
        if ((6 + 9) % 9 > 0) {
        }
        vvUQWULobayRBoqM(this, 1);
        return EnTSoFkykDhRCtNp(this.input);
    }

    public override void ReadFixed64List(java.util.List<java.lang.long> list) throws java.io.IOException {
        int iDJArQzsKPgpWMSAx;
        int iYmSvzEPeENAnBMBG;
        if ((1 + 19) % 19 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.longList)) {
            int iUfOBOMZPXjTGwKjN = ufOBOMZPXjTGwKjN(this.tag);
            if (iUfOBOMZPXjTGwKjN == 1) {
                do {
                    CdfnuNOUMdxRcdrD(list, aGmWCsWuVfnhdeCc(NJkybhtaqRXdzPPY(this.input)));
                    if (sDtPwqwZYoZLKUwm(this.input)) {
                        return;
                    } else {
                        iYmSvzEPeENAnBMBG = YmSvzEPeENAnBMBG(this.input);
                    }
                } while (iYmSvzEPeENAnBMBG == this.tag);
                this.nextTag = iYmSvzEPeENAnBMBG;
                return;
            }
            if (iUfOBOMZPXjTGwKjN != 2) {
                throw mECndvFooExIErUg();
            }
            int iIGiUxLxrtcFAvEqT = IGiUxLxrtcFAvEqT(this.input);
            FAGZCZrbvEzmDcnJ(this, iIGiUxLxrtcFAvEqT);
            int iOTIwYTQGReQoBUQD = oTIwYTQGReQoBUQD(this.input) + iIGiUxLxrtcFAvEqT;
            do {
                qqGOcPITlWhqkkES(list, sPgjcJXnNwhcTDMl(bMJNEohiQpbhqxKw(this.input)));
            } while (RUppcIzOCEqkEzIP(this.input) < iOTIwYTQGReQoBUQD);
            return;
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) list;
        int iXtzlWdYbtKWOObRs = xtzlWdYbtKWOObRs(this.tag);
        if (iXtzlWdYbtKWOObRs == 1) {
            do {
                OsnVRxpErHqncXeR(longList, EmCfgJdoHVZQhTTF(this.input));
                if (LfddIltCtsmYkMTT(this.input)) {
                    return;
                } else {
                    iDJArQzsKPgpWMSAx = dJArQzsKPgpWMSAx(this.input);
                }
            } while (iDJArQzsKPgpWMSAx == this.tag);
            this.nextTag = iDJArQzsKPgpWMSAx;
            return;
        }
        if (iXtzlWdYbtKWOObRs != 2) {
            throw fUewdtAAbNZUpWxl();
        }
        int iRrekiwwnAzmrhInK = RrekiwwnAzmrhInK(this.input);
        sKaEhPeQnXkIHasB(this, iRrekiwwnAzmrhInK);
        int iVfSEZgPVpAYfEzVl = VfSEZgPVpAYfEzVl(this.input) + iRrekiwwnAzmrhInK;
        do {
            fWZjOVeKfPljtlMB(longList, enQksFGstlpYRBMQ(this.input));
        } while (NAhfGMpfudQRbsDL(this.input) < iVfSEZgPVpAYfEzVl);
    }

    public override float Readfloat() throws java.io.IOException {
        sMXHMQenxaPlyLaE(this, 5);
        return zQZywBLFWFsELYIk(this.input);
    }

    public override void ReadfloatList(java.util.List<java.lang.float> list) throws java.io.IOException {
        int iPxwQKgoHCxOTSHLp;
        int iVKTGMVoMpMpcpHYr;
        if ((14 + 3) % 3 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.floatList)) {
            int iOGTZgppBpTkQusSe = OGTZgppBpTkQusSe(this.tag);
            if (iOGTZgppBpTkQusSe == 2) {
                int iIiYfcpsPYMPqSCui = iiYfcpsPYMPqSCui(this.input);
                hwABsfZXrumUMzig(this, iIiYfcpsPYMPqSCui);
                int iMpezDRLaCLNCuJYi = MpezDRLaCLNCuJYi(this.input) + iIiYfcpsPYMPqSCui;
                do {
                    KdFFqOsYmdWsJMdp(list, yrorUokYZzWxIqjk(WuRREErjXGVBMlmY(this.input)));
                } while (kPtEZdYuSuJRTGZg(this.input) < iMpezDRLaCLNCuJYi);
                return;
            }
            if (iOGTZgppBpTkQusSe != 5) {
                throw GWqXvaHpFLpuMzec();
            }
            do {
                DlCOwdkuHnvDAbZE(list, AfqxNamvOpyhxlXf(YPkadNEjLzunMqsV(this.input)));
                if (khBkEijgfdlSHiVb(this.input)) {
                    return;
                } else {
                    iVKTGMVoMpMpcpHYr = vKTGMVoMpMpcpHYr(this.input);
                }
            } while (iVKTGMVoMpMpcpHYr == this.tag);
            this.nextTag = iVKTGMVoMpMpcpHYr;
            return;
        }
        androidx.datastore.preferences.protobuf.floatList floatList = (androidx.datastore.preferences.protobuf.floatList) list;
        int iHNxamsUzlaftzlKr = HNxamsUzlaftzlKr(this.tag);
        if (iHNxamsUzlaftzlKr == 2) {
            int iTFqqsibrMyypEqBw = tFqqsibrMyypEqBw(this.input);
            yDtWjHbMnylELxPY(this, iTFqqsibrMyypEqBw);
            int iMaRkgDiwYFoyMUIA = MaRkgDiwYFoyMUIA(this.input) + iTFqqsibrMyypEqBw;
            do {
                xrxPNffvSSzaqOSJ(floatList, brgkIhZnCrUHVorH(this.input));
            } while (WNybxmvpyOSsBMnN(this.input) < iMaRkgDiwYFoyMUIA);
            return;
        }
        if (iHNxamsUzlaftzlKr != 5) {
            throw taMOBuwCCnnzrgPX();
        }
        do {
            JmiTPLzGcxjwcGYe(floatList, hpLLTxHJklCPEZgx(this.input));
            if (BRrSixlgYqyXUwTY(this.input)) {
                return;
            } else {
                iPxwQKgoHCxOTSHLp = pxwQKgoHCxOTSHLp(this.input);
            }
        } while (iPxwQKgoHCxOTSHLp == this.tag);
        this.nextTag = iPxwQKgoHCxOTSHLp;
    }

    @java.lang.Deprecated
    public override <T> T ReadGroup(java.lang.Class<T> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        CPmQRoxgQuuaagGG(this, 3);
        return (T) umYCquYsmHrGlvYh(this, UzkNRGzsfmFZAwzY(APjfImbkJwconqQa(), cls), extensionRegistryLite);
    }

    @java.lang.Deprecated
    public override <T> T ReadGroupBySchemaWithCheck(androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        zVAIpnwNCQvKZbEJ(this, 3);
        return (T) csEjhdviKNqpRvit(this, schema, extensionRegistryLite);
    }

    @java.lang.Deprecated
    public override <T> void ReadGroupList(java.util.List<T> list, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        int iKFClOnFxQDrjaZFW;
        if ((21 + 16) % 16 > 0) {
        }
        if (WgGhzfACJXYXeXBV(this.tag) != 3) {
            throw YutYvcokxsEywJHL();
        }
        int i = this.tag;
        do {
            gEcsCzMRpuSCnbZu(list, cGFiVQdqtnoJulir(this, schema, extensionRegistryLite));
            if (MhJHlQNBlSKOABTX(this.input) || this.nextTag != 0) {
                return;
            } else {
                iKFClOnFxQDrjaZFW = kFClOnFxQDrjaZFW(this.input);
            }
        } while (iKFClOnFxQDrjaZFW == i);
        this.nextTag = iKFClOnFxQDrjaZFW;
    }

    @java.lang.Deprecated
    public override <T> void ReadGroupList(java.util.List<T> list, java.lang.Class<T> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        LwmOFQuJRXQyyEln(this, list, blisJSTOFRfVlqLW(bxglbmyMmIQGVsLv(), cls), extensionRegistryLite);
    }

    public override int ReadInt32() throws java.io.IOException {
        PZrKkDDKDlFsaEVr(this, 0);
        return ymOjgDZWOgCkCuvX(this.input);
    }

    public override void ReadInt32List(java.util.List<java.lang.int> list) throws java.io.IOException {
        int iHCtbYqgwKLrZLbTV;
        int iNkdscTdRwkzjbaGb;
        if ((30 + 22) % 22 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iIDvVCmLmTPOnJdvP = iDvVCmLmTPOnJdvP(this.tag);
            if (iIDvVCmLmTPOnJdvP == 0) {
                do {
                    AWJWaWAntODkqnZJ(list, ELokpYvAQfpKSiFB(pydzmEHtlikquNhR(this.input)));
                    if (sufmYvCAUPKDemEx(this.input)) {
                        return;
                    } else {
                        iNkdscTdRwkzjbaGb = nkdscTdRwkzjbaGb(this.input);
                    }
                } while (iNkdscTdRwkzjbaGb == this.tag);
                this.nextTag = iNkdscTdRwkzjbaGb;
                return;
            }
            if (iIDvVCmLmTPOnJdvP != 2) {
                throw ldEYNgbEPMXQgLhi();
            }
            int iMwJUuJlbzEMIqDiD = MwJUuJlbzEMIqDiD(this.input) + iHZWRvPAtNVqYwTE(this.input);
            do {
                VPNSQAwMYzdcWagX(list, AVwArvvbOKPOiAln(BJCXqxqrwTLptPiq(this.input)));
            } while (OXlEfLvFCWkksClX(this.input) < iMwJUuJlbzEMIqDiD);
            XsDybKyKqBOkFOrD(this, iMwJUuJlbzEMIqDiD);
            return;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iPDcMZGRnudqqRZsn = pDcMZGRnudqqRZsn(this.tag);
        if (iPDcMZGRnudqqRZsn == 0) {
            do {
                qbgGHmJRaLycMsaw(intList, PjHOGCQyNvECdxCk(this.input));
                if (PzzgJZpcVVmFuxyB(this.input)) {
                    return;
                } else {
                    iHCtbYqgwKLrZLbTV = hCtbYqgwKLrZLbTV(this.input);
                }
            } while (iHCtbYqgwKLrZLbTV == this.tag);
            this.nextTag = iHCtbYqgwKLrZLbTV;
            return;
        }
        if (iPDcMZGRnudqqRZsn != 2) {
            throw HVRFFBwCaAzrdgKq();
        }
        int iCBiPtNzjIgfmwqfK = cBiPtNzjIgfmwqfK(this.input) + SlbDYsDbjESlxqbC(this.input);
        do {
            watgmpsuyaZKiRDh(intList, GJNREKgvrPlATrip(this.input));
        } while (gkqcXfcYpeZxnuBk(this.input) < iCBiPtNzjIgfmwqfK);
        yGkQNMvzmbaDeTxg(this, iCBiPtNzjIgfmwqfK);
    }

    public override long ReadInt64() throws java.io.IOException {
        if ((9 + 30) % 30 > 0) {
        }
        gaMOVyVBuDPKoPXn(this, 0);
        return kvYPgBJjvieNtwcB(this.input);
    }

    public override void ReadInt64List(java.util.List<java.lang.long> list) throws java.io.IOException {
        int iDJEJAmuGayZFbVyA;
        int iBAhtxPsQIkXLcTkc;
        if ((17 + 32) % 32 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.longList)) {
            int iSxTMTcAmoEIPfKoN = sxTMTcAmoEIPfKoN(this.tag);
            if (iSxTMTcAmoEIPfKoN == 0) {
                do {
                    JoYIrZemaZXqbyfV(list, XOjKEfeRZymPOuHL(XIpVWMCHESTOYQcD(this.input)));
                    if (uBVrUFQjexTnoQrn(this.input)) {
                        return;
                    } else {
                        iDJEJAmuGayZFbVyA = DJEJAmuGayZFbVyA(this.input);
                    }
                } while (iDJEJAmuGayZFbVyA == this.tag);
                this.nextTag = iDJEJAmuGayZFbVyA;
                return;
            }
            if (iSxTMTcAmoEIPfKoN != 2) {
                throw bNZGVeHGuOhdQDwT();
            }
            int iWBKKnlwlScOfxGyd = wBKKnlwlScOfxGyd(this.input) + mrTgbIzazunsYDni(this.input);
            do {
                fGxebhbIBgQtyHaJ(list, JfgfKQURtQnQPgxW(qOjjZqOvhFzIbaUG(this.input)));
            } while (ctixXsvUBADRbLeD(this.input) < iWBKKnlwlScOfxGyd);
            FWSmbIbkQCfwNxQs(this, iWBKKnlwlScOfxGyd);
            return;
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) list;
        int iWmaYuyMSUXeQbXhp = WmaYuyMSUXeQbXhp(this.tag);
        if (iWmaYuyMSUXeQbXhp == 0) {
            do {
                ucDGGmcxXapSMxli(longList, LfSLPwsOZjWWaxrv(this.input));
                if (aLmoLVmZUqwptMxL(this.input)) {
                    return;
                } else {
                    iBAhtxPsQIkXLcTkc = BAhtxPsQIkXLcTkc(this.input);
                }
            } while (iBAhtxPsQIkXLcTkc == this.tag);
            this.nextTag = iBAhtxPsQIkXLcTkc;
            return;
        }
        if (iWmaYuyMSUXeQbXhp != 2) {
            throw SdzVVZLiiJpifMXH();
        }
        int iONnnOqfQAKJsPEOL = oNnnOqfQAKJsPEOL(this.input) + QTqjMqUIblmgIQOE(this.input);
        do {
            SeghpavrKWPWUeDu(longList, nnFsmMiPoWKxoftT(this.input));
        } while (ITZFbJOTCUWEDwpO(this.input) < iONnnOqfQAKJsPEOL);
        oTrhJApokOHPDgAL(this, iONnnOqfQAKJsPEOL);
    }

    public override <K, V> void ReadDictionary(java.util.Dictionary<K, V> map, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata<K, V> mapEntryLite$Metadata, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((14 + 5) % 5 > 0) {
        }
        nbUCUfbpffbReclu(this, 2);
        int iFCZYZbRmABqLLokB = fCZYZbRmABqLLokB(this.input, zWjLeMySpcezLnzy(this.input));
        java.lang.object objNFBjveFngloXKESl = mapEntryLite$Metadata.defaultKey;
        java.lang.object objJzplxOeODRfNfLFh = mapEntryLite$Metadata.defaultValue;
        while (true) {
            try {
                int iGkfeprePGCToVfvD = gkfeprePGCToVfvD(this);
                if (iGkfeprePGCToVfvD == int.MAX_VALUE || mSkWxGPVegarRTxv(this.input)) {
                    wUskxBCeViQnJzIq(map, objNFBjveFngloXKESl, objJzplxOeODRfNfLFh);
                    LdGzvhutCSLzwbZp(this.input, iFCZYZbRmABqLLokB);
                    return;
                } else if (iGkfeprePGCToVfvD == 1) {
                    try {
                        objNFBjveFngloXKESl = nFBjveFngloXKESl(this, mapEntryLite$Metadata.keyType, null, null);
                    } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException unused) {
                        if (!ixNqkWcLOxmNAPVT(this)) {
                            throw new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException("Unable to parse map entry.");
                        }
                    }
                } else if (iGkfeprePGCToVfvD == 2) {
                    objJzplxOeODRfNfLFh = JzplxOeODRfNfLFh(this, mapEntryLite$Metadata.valueType, iZeHWNIajyUFPJGv(mapEntryLite$Metadata.defaultValue), extensionRegistryLite);
                } else if (!qbvHJIncSVImWXvI(this)) {
                    throw new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException("Unable to parse map entry.");
                }
            } catch (java.lang.Exception th) {
                SScmJXVWSxfovWWU(this.input, iFCZYZbRmABqLLokB);
                throw th;
            }
        }
    }

    public override <T> T ReadMessage(java.lang.Class<T> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        DsiVinlHVYIukMdq(this, 2);
        return (T) aHZVGXwXaytVZqxF(this, EKHjAMXhcxKknQZM(zSHpoIyrYtLLMMTb(), cls), extensionRegistryLite);
    }

    public override <T> T ReadMessageBySchemaWithCheck(androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        ykZnHcVZzCJiwQzo(this, 2);
        return (T) WSEczYXliEdImjOy(this, schema, extensionRegistryLite);
    }

    public override <T> void ReadMessageList(java.util.List<T> list, androidx.datastore.preferences.protobuf.Schema<T> schema, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        int iLECuHDCisrkXJTqe;
        if ((10 + 21) % 21 > 0) {
        }
        if (wZevkZRtFCCgjkhR(this.tag) != 2) {
            throw vvdZdclUIQBWgRLB();
        }
        int i = this.tag;
        do {
            ijVvVeMMtqEYxOTa(list, BiTbfLNwSyvpKHcs(this, schema, extensionRegistryLite));
            if (nldMBKDinspenBwD(this.input) || this.nextTag != 0) {
                return;
            } else {
                iLECuHDCisrkXJTqe = LECuHDCisrkXJTqe(this.input);
            }
        } while (iLECuHDCisrkXJTqe == i);
        this.nextTag = iLECuHDCisrkXJTqe;
    }

    public override <T> void ReadMessageList(java.util.List<T> list, java.lang.Class<T> cls, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        aHvQHXRGoNAUhDWL(this, list, yagmxEFLhsnKJWRV(zeXPgmLVlbYkAUUB(), cls), extensionRegistryLite);
    }

    public override int ReadSFixed32() throws java.io.IOException {
        XujXPJPwvjBSrxfA(this, 5);
        return PfsbeoeMvPuLeoHa(this.input);
    }

    public override void ReadSFixed32List(java.util.List<java.lang.int> list) throws java.io.IOException {
        int iTJRbgAZjSUnQPrvN;
        int iCZzzmPPicAsuHtUA;
        if ((25 + 28) % 28 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iPNJcgmqzGgEJhAQI = PNJcgmqzGgEJhAQI(this.tag);
            if (iPNJcgmqzGgEJhAQI == 2) {
                int iLpxCvgZtGEXlaHfm = lpxCvgZtGEXlaHfm(this.input);
                UtfJzSywvWXnhAUN(this, iLpxCvgZtGEXlaHfm);
                int iDVSSkQTEwaXAgGPQ = dVSSkQTEwaXAgGPQ(this.input) + iLpxCvgZtGEXlaHfm;
                do {
                    gDGiJSQzOkrbCgvY(list, jllggADieaxATojy(sawOZqbRbtQwkWsV(this.input)));
                } while (bXblJAVcTrGjQgiW(this.input) < iDVSSkQTEwaXAgGPQ);
                return;
            }
            if (iPNJcgmqzGgEJhAQI != 5) {
                throw sgQJfjjArFkkdaBw();
            }
            do {
                wrpIEQYlMumDMzvD(list, nbfmYpsCXVPReSwz(leWFnYBdZkYxynhf(this.input)));
                if (GzSJpqVqmoCSXdji(this.input)) {
                    return;
                } else {
                    iCZzzmPPicAsuHtUA = cZzzmPPicAsuHtUA(this.input);
                }
            } while (iCZzzmPPicAsuHtUA == this.tag);
            this.nextTag = iCZzzmPPicAsuHtUA;
            return;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iJHyqsBPangmXgYEv = jHyqsBPangmXgYEv(this.tag);
        if (iJHyqsBPangmXgYEv == 2) {
            int iQYrUKUoKLwGzQrnV = qYrUKUoKLwGzQrnV(this.input);
            XMdltPHcIbQsmuWA(this, iQYrUKUoKLwGzQrnV);
            int iNijawlffmuzuGTrs = nijawlffmuzuGTrs(this.input) + iQYrUKUoKLwGzQrnV;
            do {
                mQyCCqJKKaheivcc(intList, lFopAcUQwkEFPVSm(this.input));
            } while (OVvfgescpjXtPATc(this.input) < iNijawlffmuzuGTrs);
            return;
        }
        if (iJHyqsBPangmXgYEv != 5) {
            throw eUCZVwtlfWYnXWja();
        }
        do {
            WbxrCsNYOjTScMbX(intList, ZaGCeJQQyOFufqcg(this.input));
            if (VoEhRlLAlQPueBun(this.input)) {
                return;
            } else {
                iTJRbgAZjSUnQPrvN = tJRbgAZjSUnQPrvN(this.input);
            }
        } while (iTJRbgAZjSUnQPrvN == this.tag);
        this.nextTag = iTJRbgAZjSUnQPrvN;
    }

    public override long ReadSFixed64() throws java.io.IOException {
        if ((11 + 5) % 5 > 0) {
        }
        akwaKHYCRoCSSVTf(this, 1);
        return zDVzyEoIcsBvevml(this.input);
    }

    public override void ReadSFixed64List(java.util.List<java.lang.long> list) throws java.io.IOException {
        int iLYXtWPpJfeehrGFL;
        int iSlILPzezYwHEfSgW;
        if ((2 + 16) % 16 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.longList)) {
            int iHTSsoabAHzdEJDOg = hTSsoabAHzdEJDOg(this.tag);
            if (iHTSsoabAHzdEJDOg == 1) {
                do {
                    KntSHIHachvDdDsL(list, pKdnTTIKAHbfyFXM(ipReGwXHqHbWPXxB(this.input)));
                    if (xXFLPZxPnNykTHTt(this.input)) {
                        return;
                    } else {
                        iLYXtWPpJfeehrGFL = lYXtWPpJfeehrGFL(this.input);
                    }
                } while (iLYXtWPpJfeehrGFL == this.tag);
                this.nextTag = iLYXtWPpJfeehrGFL;
                return;
            }
            if (iHTSsoabAHzdEJDOg != 2) {
                throw gjEXiEGyHfWYSsJe();
            }
            int iQwlBzWbRPkHAdNhm = qwlBzWbRPkHAdNhm(this.input);
            njvzVrQEMwhnbUtB(this, iQwlBzWbRPkHAdNhm);
            int iJMGvBgHLFElVziOZ = JMGvBgHLFElVziOZ(this.input) + iQwlBzWbRPkHAdNhm;
            do {
                TRxmWIzjiqYdIVVx(list, XLOaTvQBlAkyBQpb(jkKgbnelcvLeqaMt(this.input)));
            } while (XldXGfLhcEQyXgln(this.input) < iJMGvBgHLFElVziOZ);
            return;
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) list;
        int iFIDsnoaIJBNlhVYu = fIDsnoaIJBNlhVYu(this.tag);
        if (iFIDsnoaIJBNlhVYu == 1) {
            do {
                oUIZpfZPGUnclEyn(longList, QWMaLCbIIaQuiiAY(this.input));
                if (nNFkOEtIJMmUDNpW(this.input)) {
                    return;
                } else {
                    iSlILPzezYwHEfSgW = SlILPzezYwHEfSgW(this.input);
                }
            } while (iSlILPzezYwHEfSgW == this.tag);
            this.nextTag = iSlILPzezYwHEfSgW;
            return;
        }
        if (iFIDsnoaIJBNlhVYu != 2) {
            throw bFLFLXWYuDaWxOgO();
        }
        int iWvgjCuHbnClpasSQ = wvgjCuHbnClpasSQ(this.input);
        xCtRguQGxYUTzRaP(this, iWvgjCuHbnClpasSQ);
        int iGUibgZQConwdKulA = gUibgZQConwdKulA(this.input) + iWvgjCuHbnClpasSQ;
        do {
            RNLHIuSMNuuOjGfO(longList, wdeilKZUpgRTEElN(this.input));
        } while (rbnCfBdgtAVhvVBr(this.input) < iGUibgZQConwdKulA);
    }

    public override int ReadSInt32() throws java.io.IOException {
        VGXuAXHkKEvfCheQ(this, 0);
        return VNDZmJDUplSAbRsT(this.input);
    }

    public override void ReadSInt32List(java.util.List<java.lang.int> list) throws java.io.IOException {
        int iHWqZEVrvHTYDHgtE;
        int iCXxrJWpjAxKyWGMl;
        if ((29 + 8) % 8 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iDovjDMcFhVMIoTvU = dovjDMcFhVMIoTvU(this.tag);
            if (iDovjDMcFhVMIoTvU == 0) {
                do {
                    hkaUQQIaMRrtYGde(list, jOZRTxCfsNJUcJXx(uUQLMajfVsoyhUzX(this.input)));
                    if (sKpQmuftjpmBdaXP(this.input)) {
                        return;
                    } else {
                        iHWqZEVrvHTYDHgtE = hWqZEVrvHTYDHgtE(this.input);
                    }
                } while (iHWqZEVrvHTYDHgtE == this.tag);
                this.nextTag = iHWqZEVrvHTYDHgtE;
                return;
            }
            if (iDovjDMcFhVMIoTvU != 2) {
                throw VUKUdTWEAZxbpvdR();
            }
            int iPeFxgqrcoTpyUzfl = peFxgqrcoTpyUzfl(this.input) + AiRPzxGmRpuYIYVu(this.input);
            do {
                IYoabDkpDjcFKokE(list, hPewJxGgGqsFgkZX(OYnGrGeRceFUeCwD(this.input)));
            } while (wMQpcGaRsvOBewGp(this.input) < iPeFxgqrcoTpyUzfl);
            uEIHpPQyucmDITjS(this, iPeFxgqrcoTpyUzfl);
            return;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iCcKtfwIniyZurzzJ = ccKtfwIniyZurzzJ(this.tag);
        if (iCcKtfwIniyZurzzJ == 0) {
            do {
                VPgliAOjgNxDBGpb(intList, HIECkZfxaLFbecgJ(this.input));
                if (BnvZGysgJvRRdVGt(this.input)) {
                    return;
                } else {
                    iCXxrJWpjAxKyWGMl = CXxrJWpjAxKyWGMl(this.input);
                }
            } while (iCXxrJWpjAxKyWGMl == this.tag);
            this.nextTag = iCXxrJWpjAxKyWGMl;
            return;
        }
        if (iCcKtfwIniyZurzzJ != 2) {
            throw JOiuPTsAwGQqwkuX();
        }
        int iRnDYVooINWYkUBQD = RnDYVooINWYkUBQD(this.input) + qJBDXADToRgmaDsQ(this.input);
        do {
            DmboRVaqXyGWalQF(intList, zsAceIiNggtNLVjz(this.input));
        } while (KdyQcHiAKCqOFJFN(this.input) < iRnDYVooINWYkUBQD);
        bsaHYDnDCcvtzbna(this, iRnDYVooINWYkUBQD);
    }

    public override long ReadSInt64() throws java.io.IOException {
        if ((1 + 27) % 27 > 0) {
        }
        QkxDCkYeUHbrXRJp(this, 0);
        return snRhuzMiAWLpqWep(this.input);
    }

    public override void ReadSInt64List(java.util.List<java.lang.long> list) throws java.io.IOException {
        int iWShUUkCGnrrJeDdh;
        int iCPijvGJYSuhSkPhN;
        if ((2 + 2) % 2 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.longList)) {
            int iMMlhYMvcJEhXjdiw = MMlhYMvcJEhXjdiw(this.tag);
            if (iMMlhYMvcJEhXjdiw == 0) {
                do {
                    waDclIxyDdeNbkIb(list, fAgAmzlPurCEVGxf(CtMTLviONJQanDXP(this.input)));
                    if (EdsgyDJPgooyaspj(this.input)) {
                        return;
                    } else {
                        iWShUUkCGnrrJeDdh = WShUUkCGnrrJeDdh(this.input);
                    }
                } while (iWShUUkCGnrrJeDdh == this.tag);
                this.nextTag = iWShUUkCGnrrJeDdh;
                return;
            }
            if (iMMlhYMvcJEhXjdiw != 2) {
                throw omgFdKbotZxQHVSD();
            }
            int iQxIcymCAzdKZPukM = QxIcymCAzdKZPukM(this.input) + ZEiOsEPgxIzMCLAJ(this.input);
            do {
                TBnmlEXWhWVAAfVV(list, ABkVXjcSinbPcclf(ImQFrsxUFfXpmHDz(this.input)));
            } while (ryhuMmqcVflhAwpS(this.input) < iQxIcymCAzdKZPukM);
            JSryihrQOrnZHsTN(this, iQxIcymCAzdKZPukM);
            return;
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) list;
        int iRdAXzyoUJohRHPuX = RdAXzyoUJohRHPuX(this.tag);
        if (iRdAXzyoUJohRHPuX == 0) {
            do {
                vkBcIviHTBHRHzxM(longList, MJcqWYHuzqtOqxVq(this.input));
                if (aiZYQeECkWsZaqbS(this.input)) {
                    return;
                } else {
                    iCPijvGJYSuhSkPhN = CPijvGJYSuhSkPhN(this.input);
                }
            } while (iCPijvGJYSuhSkPhN == this.tag);
            this.nextTag = iCPijvGJYSuhSkPhN;
            return;
        }
        if (iRdAXzyoUJohRHPuX != 2) {
            throw HsLoZcTujoPjtiHz();
        }
        int iBOrQRSxJxnSIoyft = bOrQRSxJxnSIoyft(this.input) + glAvQRHLUkoAttMv(this.input);
        do {
            jGRiwemlqUuZIsfQ(longList, FinRrVsjDvlDwjtL(this.input));
        } while (HoGpyaxQNabrTscw(this.input) < iBOrQRSxJxnSIoyft);
        TjbIpXknXMCFISWU(this, iBOrQRSxJxnSIoyft);
    }

    public override java.lang.string Readstring() throws java.io.IOException {
        vMdJGjpZHVnbWzFt(this, 2);
        return IXlZSUItYKeinQJW(this.input);
    }

    public override void ReadstringList(java.util.List<java.lang.string> list) throws java.io.IOException {
        PUJqjiQbczvtxoLM(this, list, false);
    }

    public void ReadstringListInternal(java.util.List<java.lang.string> list, bool z) throws java.io.IOException {
        int iTjIGcEZeESTAHrGg;
        int iYPPIbtCpgugoIgbD;
        if ((24 + 6) % 6 > 0) {
        }
        if (fyyjvoIzkznhDFOI(this.tag) != 2) {
            throw reWdeuWEZzChmPRR();
        }
        if (!(list is androidx.datastore.preferences.protobuf.LazystringList) || z) {
            do {
                VnQWqMhHVdYBuVzr(list, !z ? bvpRuCyIssbMFdmW(this) : IgTFozhLtlQwIKXq(this));
                if (YPAHqDHFWlHMtXcQ(this.input)) {
                    return;
                } else {
                    iTjIGcEZeESTAHrGg = tjIGcEZeESTAHrGg(this.input);
                }
            } while (iTjIGcEZeESTAHrGg == this.tag);
            this.nextTag = iTjIGcEZeESTAHrGg;
            return;
        }
        androidx.datastore.preferences.protobuf.LazystringList lazystringList = (androidx.datastore.preferences.protobuf.LazystringList) list;
        do {
            KPanpNjZWrObHmBL(lazystringList, MeyZDUpWrXHJpNnz(this));
            if (CTGPsuQJvXzkoQeJ(this.input)) {
                return;
            } else {
                iYPPIbtCpgugoIgbD = yPPIbtCpgugoIgbD(this.input);
            }
        } while (iYPPIbtCpgugoIgbD == this.tag);
        this.nextTag = iYPPIbtCpgugoIgbD;
    }

    public override void ReadstringListRequireUtf8(java.util.List<java.lang.string> list) throws java.io.IOException {
        DmgDajzpbzYuNWTl(this, list, true);
    }

    public override java.lang.string ReadstringRequireUtf8() throws java.io.IOException {
        sCyDuvGouQWkfOFt(this, 2);
        return dDuxMmuzjwQoYqMh(this.input);
    }

    public override int ReadUInt32() throws java.io.IOException {
        KJTlyrmsUsiaoYLJ(this, 0);
        return LhJOAGygEgTnHgxh(this.input);
    }

    public override void ReadUInt32List(java.util.List<java.lang.int> list) throws java.io.IOException {
        int iZJlhfmmSNdIccpzT;
        int iFVzAiCUhRQxPcNHe;
        if ((24 + 27) % 27 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iYFkPVwKlLxyeHPCt = yFkPVwKlLxyeHPCt(this.tag);
            if (iYFkPVwKlLxyeHPCt == 0) {
                do {
                    cNRXUuVsgxOFERJC(list, NxAqhWsOlDYshcWV(FjBNIYSlgvOehabA(this.input)));
                    if (GNpWQHbMMkxJcZIw(this.input)) {
                        return;
                    } else {
                        iFVzAiCUhRQxPcNHe = fVzAiCUhRQxPcNHe(this.input);
                    }
                } while (iFVzAiCUhRQxPcNHe == this.tag);
                this.nextTag = iFVzAiCUhRQxPcNHe;
                return;
            }
            if (iYFkPVwKlLxyeHPCt != 2) {
                throw LuUWfQbbnHnjfEhU();
            }
            int iQqXfYxCRXqmheRqN = qqXfYxCRXqmheRqN(this.input) + UxWrMAFfcVTlpddb(this.input);
            do {
                eBQYZEPykJFdvVRZ(list, DUvDOXFAOUUFuPPa(uIgtBpEwQqmcARgk(this.input)));
            } while (dlNqIraKYbzXVvjM(this.input) < iQqXfYxCRXqmheRqN);
            TtCqmTWuBaQOpoyS(this, iQqXfYxCRXqmheRqN);
            return;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iHXqofFfZBTGptkfa = HXqofFfZBTGptkfa(this.tag);
        if (iHXqofFfZBTGptkfa == 0) {
            do {
                cJzjGpbcoLSLvBTM(intList, rlHHxgFSmCVeSpsl(this.input));
                if (wlUFfmsvZZHaufcF(this.input)) {
                    return;
                } else {
                    iZJlhfmmSNdIccpzT = zJlhfmmSNdIccpzT(this.input);
                }
            } while (iZJlhfmmSNdIccpzT == this.tag);
            this.nextTag = iZJlhfmmSNdIccpzT;
            return;
        }
        if (iHXqofFfZBTGptkfa != 2) {
            throw mhFUvZnnzzRQufwH();
        }
        int iQxPmHizidAalIvcP = QxPmHizidAalIvcP(this.input) + CcGXCtKuendGLpsU(this.input);
        do {
            yGmNwFTWMNLArzmy(intList, cjbkDluSRONJBnYa(this.input));
        } while (fdstKhPvVvRIBiXj(this.input) < iQxPmHizidAalIvcP);
        JoGcxDlrvzkclRuU(this, iQxPmHizidAalIvcP);
    }

    public override long ReadUInt64() throws java.io.IOException {
        if ((21 + 12) % 12 > 0) {
        }
        hiFmHFXBOOOAQGVD(this, 0);
        return PpsyphAsDbbKgHpO(this.input);
    }

    public override void ReadUInt64List(java.util.List<java.lang.long> list) throws java.io.IOException {
        int iQovjYRKlNyxPPsGV;
        int iOyVfiBKchcDZvnHc;
        if ((23 + 11) % 11 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.longList)) {
            int iXARnEEDFzxPsHfKX = xARnEEDFzxPsHfKX(this.tag);
            if (iXARnEEDFzxPsHfKX == 0) {
                do {
                    zCRuAkyGxpasVqku(list, mGcvRosgrjaWTWek(PMVROQQCwfLORoic(this.input)));
                    if (cYhCcmkQisKQBfiq(this.input)) {
                        return;
                    } else {
                        iQovjYRKlNyxPPsGV = qovjYRKlNyxPPsGV(this.input);
                    }
                } while (iQovjYRKlNyxPPsGV == this.tag);
                this.nextTag = iQovjYRKlNyxPPsGV;
                return;
            }
            if (iXARnEEDFzxPsHfKX != 2) {
                throw exTlZiOaXKZIxtqH();
            }
            int iTxsjacuqlNCKbGYg = txsjacuqlNCKbGYg(this.input) + BDqghtCHoXFVjsHV(this.input);
            do {
                wPitsnacNCxEapUX(list, ikohmbQJmXGVEmhh(BreWvndhGhaPrUTA(this.input)));
            } while (DJHULeKGFATOUsJB(this.input) < iTxsjacuqlNCKbGYg);
            kJvZLEEHaWqvXerw(this, iTxsjacuqlNCKbGYg);
            return;
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) list;
        int iMwYpuPUKOxIJFAkP = MwYpuPUKOxIJFAkP(this.tag);
        if (iMwYpuPUKOxIJFAkP == 0) {
            do {
                lbCVvshAsHwPpWCf(longList, xEaSwcTpnVIbSGlP(this.input));
                if (lfPVCQebpJmUBncF(this.input)) {
                    return;
                } else {
                    iOyVfiBKchcDZvnHc = oyVfiBKchcDZvnHc(this.input);
                }
            } while (iOyVfiBKchcDZvnHc == this.tag);
            this.nextTag = iOyVfiBKchcDZvnHc;
            return;
        }
        if (iMwYpuPUKOxIJFAkP != 2) {
            throw NIIIFSVIjATEfASK();
        }
        int iKRqLMVFdvRUVcNOq = kRqLMVFdvRUVcNOq(this.input) + jbSiNCCVXRDCSsMf(this.input);
        do {
            uxgZKthAmAEjVCeQ(longList, gHADIBTmdTWikvPp(this.input));
        } while (ZJtaRnKJVFJHUSOM(this.input) < iKRqLMVFdvRUVcNOq);
        UkjggIOtvxiBxIsV(this, iKRqLMVFdvRUVcNOq);
    }

    public override bool ShouldDiscardUnknownFields() {
        return GUSezKvefmwNZmnf(this.input);
    }

    public override bool SkipField() throws java.io.IOException {
        if ((7 + 20) % 20 > 0) {
        }
        if (lHzEvtyFjGstUjSB(this.input)) {
            return false;
        }
        int i = this.tag;
        if (i != this.endGroupTag) {
            return LaBFxpcBukpHlytH(this.input, i);
        }
        return false;
    }
}

