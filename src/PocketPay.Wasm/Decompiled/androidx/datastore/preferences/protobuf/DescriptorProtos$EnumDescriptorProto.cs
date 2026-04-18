namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$EnumDescriptorProto : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProtoOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto DEFAULT_INSTANCE;
    public static readonly int NAME_FIELD_NUMBER = 1;
    public static readonly int OPTIONS_FIELD_NUMBER = 3;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto> PARSER = null;
    public static readonly int RESERVED_NAME_FIELD_NUMBER = 5;
    public static readonly int RESERVED_RANGE_FIELD_NUMBER = 4;
    public static readonly int VALUE_FIELD_NUMBER = 2;
    private int bitField0_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions options_;
    private byte memoizedIsInitialized = 2;
    private java.lang.string name_ = "";
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto> value_ = xIzzkZHAIcHUnSFu();
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange> reservedRange_ = XuEPFhtMWOEgpEHO();
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.string> reservedName_ = SXrvLduoxJzwqyOh();

    static {
        if ((6 + 15) % 15 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto = new androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto();
        DEFAULT_INSTANCE = descriptorProtos$EnumDescriptorProto;
        HxUpmZzPzXSwuaPJ(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto.class, descriptorProtos$EnumDescriptorProto);
    }

    private DescriptorProtos$EnumDescriptorProto() {
    }

    public static java.lang.Class ALBNcXquZrHpZvkL(java.lang.object obj) {
        return obj.GetType();
    }

    public static void AXxdHHwoapyrAVQi(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.clearReservedRange();
    }

    public static java.lang.Class AZCNFKALPmafqBcO(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.Class BBvYwGQNyvYnKfot(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.Class BkHwPeyRYNReIYVN(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions$Builder ByqcgoNenbHXPTLl(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions.newBuilder(descriptorProtos$EnumOptions);
    }

    public static void BzjYbVjREyHBZeFl(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.clearValue();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite CiGvGYHBRouNYjiJ(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, inputStream, extensionRegistryLite);
    }

    public static void CqHBwUNTlzxBgvtu(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureReservedRangeIsMutable();
    }

    public static void DDlLkZTDDhYdANpg(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange descriptorProtos$EnumDescriptorProto$EnumReservedRange) {
        descriptorProtos$EnumDescriptorProto.setReservedRange(i, descriptorProtos$EnumDescriptorProto$EnumReservedRange);
    }

    public static void DmZYFtoaizunvDvk(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite EUrrcxIYrhvCiQhY(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, codedStream);
    }

    public static void EzCKcnPtmKyDbVHH(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, java.lang.string str) {
        descriptorProtos$EnumDescriptorProto.setName(str);
    }

    public static void FYBzeEosvokiVAnU(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    public static void FbYnBLurmypWRCLC(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i, java.lang.string str) {
        descriptorProtos$EnumDescriptorProto.setReservedName(i, str);
    }

    public static java.lang.Class FnGnSDvCdoQCPCbQ(java.lang.object obj) {
        return obj.GetType();
    }

    public static void GtCbiTpmUZZZcNiu(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange descriptorProtos$EnumDescriptorProto$EnumReservedRange) {
        descriptorProtos$EnumDescriptorProto.addReservedRange(i, descriptorProtos$EnumDescriptorProto$EnumReservedRange);
    }

    public static void HDUMGlxYiBbJpBYw(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto descriptorProtos$EnumValueDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.addValue(descriptorProtos$EnumValueDescriptorProto);
    }

    public static void HxUpmZzPzXSwuaPJ(java.lang.Class cls, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(cls, generatedMessageLite);
    }

    public static void JYIPZUHYZoOBmcIo(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureReservedNameIsMutable();
    }

    public static bool KFDTIwlZthLnFEUC(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static bool KLWZNfWiIsTLtdvc(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static java.lang.string LJNDKirWWsXfffjn(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.tostringUtf8();
    }

    public static int LMXeKMWnTrebFcNG(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke) {
        return generatedMessageLite$MethodToInvoke.ordinal();
    }

    public static int LTsZhKfbbnUNhTyw(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static void LUCOwJpmdxvhykHv(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.clearName();
    }

    public static androidx.datastore.preferences.protobuf.bytestring LjOLsTbRnPUBfPAU(java.lang.string str) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(str);
    }

    public static java.lang.Class MHKKVIVkkZMlvkQi(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList MdxoyvTnbWTRVYBT() {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.emptyProtobufList();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite MgKvmHUjmaoronNo(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return parseDelimitedFrom(generatedMessageLite, inputStream, extensionRegistryLite);
    }

    public static java.lang.string MibMgnVrhLHkOaLn(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        return descriptorProtos$EnumDescriptorProto.getName();
    }

    public static java.lang.object MlEAqihYlUFkCCym(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions MmArBwLwJLtHaZco() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions.getDefaultInstance();
    }

    public static void OIHGYrpQaVzITrxR(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$EnumDescriptorProto.addAllReservedRange(iterable);
    }

    public static java.lang.object OLDPUqreUPxtFoQq(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static androidx.datastore.preferences.protobuf.Parser OlhSlwNsmWvdLESB(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        return descriptorProtos$EnumDescriptorProto.getParserForType();
    }

    public static void PPCkhieOFaoPOLeL(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureValueIsMutable();
    }

    public static void PbFrIVxmLxXxtfMO(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureReservedRangeIsMutable();
    }

    public static void QATvweBPrrnoJolw(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureValueIsMutable();
    }

    public static java.lang.Class QAnXMoSMDIjJzDIt(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite QHkJLnqElCTCrihb(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite RjjFONiBkQAtQHkJ(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions SHUGqpganORYTpSm() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions.getDefaultInstance();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList SXrvLduoxJzwqyOh() {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.emptyProtobufList();
    }

    public static void SvoZKxHwBijPfwjY(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i) {
        descriptorProtos$EnumDescriptorProto.removeReservedRange(i);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList TgixvCLJonInfRQS() {
        return emptyProtobufList();
    }

    public static void UuTqSIfdiEnRWtrb(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static void WUWGXDARTCrIdwOg(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.clearOptions();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite WqlbKHYgnkkudKhL(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList XImVhPkHhjdVFsjg(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite XMkLGsoTnWNUbUpW(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bytestring, extensionRegistryLite);
    }

    public static void XPdRjzJamXxRQJfa(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$EnumDescriptorProto.addReservedNamebytes(bytestring);
    }

    public static java.lang.byte XTTZpjfcjtsbvMEu(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList XuEPFhtMWOEgpEHO() {
        return emptyProtobufList();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList YHgcYFluAKdAzZNr(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static void ZMxoXahcfImSkzBK(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i) {
        descriptorProtos$EnumDescriptorProto.removeValue(i);
    }

    public static bool ZNPTGmmxLkHqVEvY(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static java.lang.object ZvFAGaMoBWSiTLAk(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static java.lang.Class AHOeIpBCqfolGmvM(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto aYJOOPaXDsdeaALn() {
        return getDefaultInstance();
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto access$21100() {
        return DEFAULT_INSTANCE;
    }

    static void access$21200(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, java.lang.string str) {
        EzCKcnPtmKyDbVHH(descriptorProtos$EnumDescriptorProto, str);
    }

    static void access$21300(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        LUCOwJpmdxvhykHv(descriptorProtos$EnumDescriptorProto);
    }

    static void access$21400(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        qvfxOYXNcKmdLoHg(descriptorProtos$EnumDescriptorProto, bytestring);
    }

    static void access$21500(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto descriptorProtos$EnumValueDescriptorProto) {
        toyKIullzjBerMNB(descriptorProtos$EnumDescriptorProto, i, descriptorProtos$EnumValueDescriptorProto);
    }

    static void access$21600(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto descriptorProtos$EnumValueDescriptorProto) {
        HDUMGlxYiBbJpBYw(descriptorProtos$EnumDescriptorProto, descriptorProtos$EnumValueDescriptorProto);
    }

    static void access$21700(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto descriptorProtos$EnumValueDescriptorProto) {
        hSqwknVtFblUDYFT(descriptorProtos$EnumDescriptorProto, i, descriptorProtos$EnumValueDescriptorProto);
    }

    static void access$21800(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, java.lang.IEnumerable iterable) {
        pyksgMUUrZfzsmXl(descriptorProtos$EnumDescriptorProto, iterable);
    }

    static void access$21900(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        BzjYbVjREyHBZeFl(descriptorProtos$EnumDescriptorProto);
    }

    static void access$22000(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i) {
        ZMxoXahcfImSkzBK(descriptorProtos$EnumDescriptorProto, i);
    }

    static void access$22100(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        vltwJDJpLYgglrXP(descriptorProtos$EnumDescriptorProto, descriptorProtos$EnumOptions);
    }

    static void access$22200(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        hLZBXaORhTtkcQvc(descriptorProtos$EnumDescriptorProto, descriptorProtos$EnumOptions);
    }

    static void access$22300(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        WUWGXDARTCrIdwOg(descriptorProtos$EnumDescriptorProto);
    }

    static void access$22400(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange descriptorProtos$EnumDescriptorProto$EnumReservedRange) {
        DDlLkZTDDhYdANpg(descriptorProtos$EnumDescriptorProto, i, descriptorProtos$EnumDescriptorProto$EnumReservedRange);
    }

    static void access$22500(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange descriptorProtos$EnumDescriptorProto$EnumReservedRange) {
        oJAXbkSQUNiDSvOl(descriptorProtos$EnumDescriptorProto, descriptorProtos$EnumDescriptorProto$EnumReservedRange);
    }

    static void access$22600(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange descriptorProtos$EnumDescriptorProto$EnumReservedRange) {
        GtCbiTpmUZZZcNiu(descriptorProtos$EnumDescriptorProto, i, descriptorProtos$EnumDescriptorProto$EnumReservedRange);
    }

    static void access$22700(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, java.lang.IEnumerable iterable) {
        OIHGYrpQaVzITrxR(descriptorProtos$EnumDescriptorProto, iterable);
    }

    static void access$22800(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        AXxdHHwoapyrAVQi(descriptorProtos$EnumDescriptorProto);
    }

    static void access$22900(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i) {
        SvoZKxHwBijPfwjY(descriptorProtos$EnumDescriptorProto, i);
    }

    static void access$23000(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i, java.lang.string str) {
        FbYnBLurmypWRCLC(descriptorProtos$EnumDescriptorProto, i, str);
    }

    static void access$23100(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, java.lang.string str) {
        hWTPohHTnmQyjmIK(descriptorProtos$EnumDescriptorProto, str);
    }

    static void access$23200(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, java.lang.IEnumerable iterable) {
        xZSEKAwYDNBDnFNS(descriptorProtos$EnumDescriptorProto, iterable);
    }

    static void access$23300(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        bevlVGqiHLTkRBQi(descriptorProtos$EnumDescriptorProto);
    }

    static void access$23400(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        XPdRjzJamXxRQJfa(descriptorProtos$EnumDescriptorProto, bytestring);
    }

    private void AddAllReservedName(java.lang.IEnumerable<java.lang.string> iterable) {
        iMNRJlheZDtBGecH(this);
        UuTqSIfdiEnRWtrb(iterable, this.reservedName_);
    }

    private void AddAllReservedRange(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange> iterable) {
        CqHBwUNTlzxBgvtu(this);
        gQhtqQrXucZYfjMI(iterable, this.reservedRange_);
    }

    private void AddAllValue(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto> iterable) {
        kosOuBgxHfDQQeHl(this);
        DmZYFtoaizunvDvk(iterable, this.value_);
    }

    private void AddReservedName(java.lang.string str) {
        ALBNcXquZrHpZvkL(str);
        yWDrpuTFzWtqtcmG(this);
        KFDTIwlZthLnFEUC(this.reservedName_, str);
    }

    private void AddReservedNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        JYIPZUHYZoOBmcIo(this);
        KLWZNfWiIsTLtdvc(this.reservedName_, gWwfTCcbZkCeZHoG(bytestring));
    }

    private void AddReservedRange(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange descriptorProtos$EnumDescriptorProto$EnumReservedRange) {
        nRJbZtZGXBGkjJaq(descriptorProtos$EnumDescriptorProto$EnumReservedRange);
        wOwFKRPAcsUjfVlF(this);
        FYBzeEosvokiVAnU(this.reservedRange_, i, descriptorProtos$EnumDescriptorProto$EnumReservedRange);
    }

    private void AddReservedRange(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange descriptorProtos$EnumDescriptorProto$EnumReservedRange) {
        aHOeIpBCqfolGmvM(descriptorProtos$EnumDescriptorProto$EnumReservedRange);
        vZTguePVWJREpzZX(this);
        kkEaKapJzeJQiiaC(this.reservedRange_, descriptorProtos$EnumDescriptorProto$EnumReservedRange);
    }

    private void AddValue(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto descriptorProtos$EnumValueDescriptorProto) {
        oLHRzyKmjcHmqErw(descriptorProtos$EnumValueDescriptorProto);
        dtfPxyUYWLTccIiw(this);
        eYFeWKWGlvTmwYOj(this.value_, i, descriptorProtos$EnumValueDescriptorProto);
    }

    private void AddValue(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto descriptorProtos$EnumValueDescriptorProto) {
        AZCNFKALPmafqBcO(descriptorProtos$EnumValueDescriptorProto);
        QATvweBPrrnoJolw(this);
        hoEhKnMaYqgRtyPt(this.value_, descriptorProtos$EnumValueDescriptorProto);
    }

    public static void BevlVGqiHLTkRBQi(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.clearReservedName();
    }

    public static java.lang.object BtnQjoIEPteJNgwv(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static void CdznlstaQupYwBMb(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureReservedRangeIsMutable();
    }

    private void ClearName() {
        this.bitField0_ &= -2;
        this.name_ = MibMgnVrhLHkOaLn(aYJOOPaXDsdeaALn());
    }

    private void ClearOptions() {
        this.options_ = null;
        this.bitField0_ &= -3;
    }

    private void ClearReservedName() {
        this.reservedName_ = MdxoyvTnbWTRVYBT();
    }

    private void ClearReservedRange() {
        this.reservedRange_ = vTZXeKBdqqtQKaNP();
    }

    private void ClearValue() {
        this.value_ = TgixvCLJonInfRQS();
    }

    public static java.lang.object DJCNtohGiDzkwkFt(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static java.lang.object DLhkAFQdbiogPPmu(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static void DtfPxyUYWLTccIiw(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureValueIsMutable();
    }

    public static void EYFeWKWGlvTmwYOj(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    private void EnsureReservedNameIsMutable() {
        if ((10 + 6) % 6 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.string> internal$ProtobufList = this.reservedName_;
        if (mBNavbOwlXslOLlW(internal$ProtobufList)) {
            return;
        }
        this.reservedName_ = yIlpYNWBdGacAzsx(internal$ProtobufList);
    }

    private void EnsureReservedRangeIsMutable() {
        if ((19 + 18) % 18 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange> internal$ProtobufList = this.reservedRange_;
        if (ptDJlKlTqxRcwbbw(internal$ProtobufList)) {
            return;
        }
        this.reservedRange_ = YHgcYFluAKdAzZNr(internal$ProtobufList);
    }

    private void EnsureValueIsMutable() {
        if ((4 + 26) % 26 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto> internal$ProtobufList = this.value_;
        if (ZNPTGmmxLkHqVEvY(internal$ProtobufList)) {
            return;
        }
        this.value_ = XImVhPkHhjdVFsjg(internal$ProtobufList);
    }

    public static java.lang.Class EsjvYEnyxJxZffuo(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder ezEwiWtdQDrHNCBL(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        return descriptorProtos$EnumDescriptorProto.createBuilder();
    }

    public static void GQhtqQrXucZYfjMI(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static java.lang.string GWwfTCcbZkCeZHoG(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.tostringUtf8();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static void HLZBXaORhTtkcQvc(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        descriptorProtos$EnumDescriptorProto.mergeOptions(descriptorProtos$EnumOptions);
    }

    public static void HSqwknVtFblUDYFT(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto descriptorProtos$EnumValueDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.addValue(i, descriptorProtos$EnumValueDescriptorProto);
    }

    public static void HWTPohHTnmQyjmIK(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, java.lang.string str) {
        descriptorProtos$EnumDescriptorProto.addReservedName(str);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite HguXVkzEVhVRmneo(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, byte[] bArr) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bArr);
    }

    public static bool HoEhKnMaYqgRtyPt(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static java.lang.object ICbYLLhDyoCkAXSc(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static void IMNRJlheZDtBGecH(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureReservedNameIsMutable();
    }

    public static java.lang.object IuaIsoGLkEMfonoe(androidx.datastore.preferences.protobuf.MessageLite messageLite, java.lang.string str, java.lang.object[] objArr) {
        return newMessageInfo(messageLite, str, objArr);
    }

    public static void JuJuBGDkprumwRwi(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureValueIsMutable();
    }

    public static bool KkEaKapJzeJQiiaC(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static void KosOuBgxHfDQQeHl(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureValueIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder lCHCxQOeUlXJmyxz(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        return descriptorProtos$EnumDescriptorProto.createBuilder(generatedMessageLite);
    }

    public static bool MBNavbOwlXslOLlW(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static java.lang.object MQXFxYAzoaapJCoD(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static java.lang.object MSnLDLMaWCaUDMxB(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    private void MergeOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        if ((4 + 25) % 25 > 0) {
        }
        BkHwPeyRYNReIYVN(descriptorProtos$EnumOptions);
        androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions2 = this.options_;
        if (descriptorProtos$EnumOptions2 is null || descriptorProtos$EnumOptions2 == SHUGqpganORYTpSm()) {
            this.options_ = descriptorProtos$EnumOptions;
        } else {
            this.options_ = (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions) odrjzUMLnUTTyYMZ((androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions$Builder) uEYgYraIrRkxSegI(ByqcgoNenbHXPTLl(this.options_), descriptorProtos$EnumOptions));
        }
        this.bitField0_ |= 2;
    }

    public static androidx.datastore.preferences.protobuf.bytestring MrAgLLitpGkdHQkR(java.lang.string str) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(str);
    }

    public static java.lang.Class NRJbZtZGXBGkjJaq(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$Builder newBuilder() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$Builder) ezEwiWtdQDrHNCBL(DEFAULT_INSTANCE);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$Builder) lCHCxQOeUlXJmyxz(DEFAULT_INSTANCE, descriptorProtos$EnumDescriptorProto);
    }

    public static java.lang.object NoLQzoWkXKztXEIL(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static java.lang.object NrYWogMNBaVZXtKW(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static void OJAXbkSQUNiDSvOl(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange descriptorProtos$EnumDescriptorProto$EnumReservedRange) {
        descriptorProtos$EnumDescriptorProto.addReservedRange(descriptorProtos$EnumDescriptorProto$EnumReservedRange);
    }

    public static java.lang.Class OLHRzyKmjcHmqErw(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage odrjzUMLnUTTyYMZ(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions$Builder descriptorProtos$EnumOptions$Builder) {
        return descriptorProtos$EnumOptions$Builder.buildPartial();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto) xQGOhRlzdVMYdZqY(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto) MgKvmHUjmaoronNo(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto) WqlbKHYgnkkudKhL(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto) XMkLGsoTnWNUbUpW(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto) EUrrcxIYrhvCiQhY(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto) RjjFONiBkQAtQHkJ(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto) rMoHKXtiQDgFYXxN(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto) CiGvGYHBRouNYjiJ(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto) QHkJLnqElCTCrihb(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto) zxCylpuuPfJwbWGM(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto) hguXVkzEVhVRmneo(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto) wuYKjlcAOaroQHja(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto> parser() {
        return OlhSlwNsmWvdLESB(DEFAULT_INSTANCE);
    }

    public static bool PtDJlKlTqxRcwbbw(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static void PyksgMUUrZfzsmXl(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$EnumDescriptorProto.addAllValue(iterable);
    }

    public static void QvfxOYXNcKmdLoHg(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$EnumDescriptorProto.setNamebytes(bytestring);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite RMoHKXtiQDgFYXxN(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, inputStream);
    }

    private void RemoveReservedRange(int i) {
        PbFrIVxmLxXxtfMO(this);
        nrYWogMNBaVZXtKW(this.reservedRange_, i);
    }

    private void RemoveValue(int i) {
        PPCkhieOFaoPOLeL(this);
        mSnLDLMaWCaUDMxB(this.value_, i);
    }

    private void SetName(java.lang.string str) {
        MHKKVIVkkZMlvkQi(str);
        this.bitField0_ |= 1;
        this.name_ = str;
    }

    private void SetNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.name_ = LJNDKirWWsXfffjn(bytestring);
        this.bitField0_ |= 1;
    }

    private void SetOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        QAnXMoSMDIjJzDIt(descriptorProtos$EnumOptions);
        this.options_ = descriptorProtos$EnumOptions;
        this.bitField0_ |= 2;
    }

    private void SetReservedName(int i, java.lang.string str) {
        BBvYwGQNyvYnKfot(str);
        xhVlUJphOfhHtira(this);
        mQXFxYAzoaapJCoD(this.reservedName_, i, str);
    }

    private void SetReservedRange(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange descriptorProtos$EnumDescriptorProto$EnumReservedRange) {
        esjvYEnyxJxZffuo(descriptorProtos$EnumDescriptorProto$EnumReservedRange);
        cdznlstaQupYwBMb(this);
        iCbYLLhDyoCkAXSc(this.reservedRange_, i, descriptorProtos$EnumDescriptorProto$EnumReservedRange);
    }

    private void SetValue(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto descriptorProtos$EnumValueDescriptorProto) {
        FnGnSDvCdoQCPCbQ(descriptorProtos$EnumValueDescriptorProto);
        juJuBGDkprumwRwi(this);
        OLDPUqreUPxtFoQq(this.value_, i, descriptorProtos$EnumValueDescriptorProto);
    }

    public static void ToyKIullzjBerMNB(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto descriptorProtos$EnumValueDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.setValue(i, descriptorProtos$EnumValueDescriptorProto);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder uEYgYraIrRkxSegI(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions$Builder descriptorProtos$EnumOptions$Builder, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        return descriptorProtos$EnumOptions$Builder.mergeFrom(generatedMessageLite);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList vTZXeKBdqqtQKaNP() {
        return emptyProtobufList();
    }

    public static void VZTguePVWJREpzZX(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureReservedRangeIsMutable();
    }

    public static void VltwJDJpLYgglrXP(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        descriptorProtos$EnumDescriptorProto.setOptions(descriptorProtos$EnumOptions);
    }

    public static void WOwFKRPAcsUjfVlF(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureReservedRangeIsMutable();
    }

    public static int WbRWDoDxdIEONEXc(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite WuYKjlcAOaroQHja(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList xIzzkZHAIcHUnSFu() {
        return emptyProtobufList();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite XQGOhRlzdVMYdZqY(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream) {
        return parseDelimitedFrom(generatedMessageLite, inputStream);
    }

    public static void XZSEKAwYDNBDnFNS(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$EnumDescriptorProto.addAllReservedName(iterable);
    }

    public static int XbHmallpmSPuxIID(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static void XhVlUJphOfhHtira(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureReservedNameIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList yIlpYNWBdGacAzsx(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static void YWDrpuTFzWtqtcmG(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.ensureReservedNameIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite ZxCylpuuPfJwbWGM(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, byteBuffer, extensionRegistryLite);
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((17 + 10) % 10 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[LMXeKMWnTrebFcNG(generatedMessageLite$MethodToInvoke)]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$Builder(null);
            case 3:
                return iuaIsoGLkEMfonoe(DEFAULT_INSTANCE, "\u0001\u0005\u0000\u0001\u0001\u0005\u0005\u0000\u0003\u0002\u0001ဈ\u0000\u0002Л\u0003ᐉ\u0001\u0004\u001b\u0005\u001a", new java.lang.object[]{"bitField0_", "name_", "value_", androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto.class, "options_", "reservedRange_", androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange.class, "reservedName_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto.class) {
                    try {
                        generatedMessageLite$DefaultInstanceBasedParser = PARSER;
                        if (generatedMessageLite$DefaultInstanceBasedParser is null) {
                            generatedMessageLite$DefaultInstanceBasedParser = new androidx.datastore.preferences.protobuf.GeneratedMessageLite$DefaultInstanceBasedParser(DEFAULT_INSTANCE);
                            PARSER = generatedMessageLite$DefaultInstanceBasedParser;
                        }
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                    break;
                }
                return generatedMessageLite$DefaultInstanceBasedParser;
            case 6:
                return XTTZpjfcjtsbvMEu(this.memoizedIsInitialized);
            case 7:
                this.memoizedIsInitialized = (byte) (obj is not null ? 1 : 0);
                return null;
            default:
                throw new java.lang.UnsupportedOperationException();
        }
    }

    public override java.lang.string GetName() {
        return this.name_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return mrAgLLitpGkdHQkR(this.name_);
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions getOptions() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions = this.options_;
        return descriptorProtos$EnumOptions is not null ? descriptorProtos$EnumOptions : MmArBwLwJLtHaZco();
    }

    public override java.lang.string GetReservedName(int i) {
        return (java.lang.string) btnQjoIEPteJNgwv(this.reservedName_, i);
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetReservedNamebytes(int i) {
        return LjOLsTbRnPUBfPAU((java.lang.string) MlEAqihYlUFkCCym(this.reservedName_, i));
    }

    public override int GetReservedNameCount() {
        return wbRWDoDxdIEONEXc(this.reservedName_);
    }

    public override java.util.List<java.lang.string> GetReservedNameList() {
        return this.reservedName_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange getReservedRange(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange) noLQzoWkXKztXEIL(this.reservedRange_, i);
    }

    public override int GetReservedRangeCount() {
        return xbHmallpmSPuxIID(this.reservedRange_);
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange> getReservedRangeList() {
        return this.reservedRange_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRangeOrBuilder getReservedRangeOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRangeOrBuilder) ZvFAGaMoBWSiTLAk(this.reservedRange_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRangeOrBuilder> getReservedRangeOrBuilderList() {
        return this.reservedRange_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto getValue(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto) dLhkAFQdbiogPPmu(this.value_, i);
    }

    public override int GetValueCount() {
        return LTsZhKfbbnUNhTyw(this.value_);
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto> getValueList() {
        return this.value_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProtoOrBuilder getValueOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProtoOrBuilder) dJCNtohGiDzkwkFt(this.value_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProtoOrBuilder> getValueOrBuilderList() {
        return this.value_;
    }

    public override bool HasName() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasOptions() {
        return (this.bitField0_ & 2) != 0;
    }
}

