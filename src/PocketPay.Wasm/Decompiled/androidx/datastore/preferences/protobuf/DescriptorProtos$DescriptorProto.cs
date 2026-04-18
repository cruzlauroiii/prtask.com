namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$DescriptorProto : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProtoOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto DEFAULT_INSTANCE;
    public static readonly int ENUM_TYPE_FIELD_NUMBER = 4;
    public static readonly int EXTENSION_FIELD_NUMBER = 6;
    public static readonly int EXTENSION_RANGE_FIELD_NUMBER = 5;
    public static readonly int FIELD_FIELD_NUMBER = 2;
    public static readonly int NAME_FIELD_NUMBER = 1;
    public static readonly int NESTED_TYPE_FIELD_NUMBER = 3;
    public static readonly int ONEOF_DECL_FIELD_NUMBER = 8;
    public static readonly int OPTIONS_FIELD_NUMBER = 7;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto> PARSER = null;
    public static readonly int RESERVED_NAME_FIELD_NUMBER = 10;
    public static readonly int RESERVED_RANGE_FIELD_NUMBER = 9;
    private int bitField0_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions options_;
    private byte memoizedIsInitialized = 2;
    private java.lang.string name_ = "";
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> field_ = bitklDjCXCGLwowE();
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> extension_ = ZmwrhfYglCACoXrf();
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto> nestedType_ = ubdXnggAHQHqLSaA();
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto> enumType_ = fEfbecGrzvtftxJP();
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange> extensionRange_ = ELmPOjKgyGRduDvp();
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto> oneofDecl_ = KwBCMFkQVijuPNnw();
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange> reservedRange_ = vbMzTAHROvgxvwxf();
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.string> reservedName_ = qWMlukyGKtNgTPiF();

    static {
        if ((12 + 6) % 6 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto = new androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto();
        DEFAULT_INSTANCE = descriptorProtos$DescriptorProto;
        hvXbRRSeqAdYzMAk(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto.class, descriptorProtos$DescriptorProto);
    }

    private DescriptorProtos$DescriptorProto() {
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList AKPVTPcWYuwefuWO(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static void AQIjZhaGXlINoKiL(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        descriptorProtos$DescriptorProto.removeReservedRange(i);
    }

    public static void AXoILBoFdytDJPde(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder AdRUaTsjbYaLtnGN(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        return descriptorProtos$DescriptorProto.createBuilder();
    }

    public static java.lang.object AeEVdsNNfffVEvDD(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList AgJdMhKnnUXspISM() {
        return emptyProtobufList();
    }

    public static void AiTKztccdZdRsGeG(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto2) {
        descriptorProtos$DescriptorProto.addNestedType(descriptorProtos$DescriptorProto2);
    }

    public static void AqwdMGGqrrgnyQPA(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureFieldIsMutable();
    }

    public static void ArGyOlfgrPjbwbvI(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureReservedRangeIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite BIPelRmqqEhAlUzJ(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bArr, extensionRegistryLite);
    }

    public static void BPnRQrvlqnDWBFzH(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureExtensionRangeIsMutable();
    }

    public static void BWBeRPnxmigNlwsI(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.clearField();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList BWaTrNfWUjFFHSlP(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static java.lang.Class BXgOsImAVzfkyRHO(java.lang.object obj) {
        return obj.GetType();
    }

    public static void BfRevnGpjhqFsmgC(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.clearOptions();
    }

    public static bool BsOsXSCxdYONCcma(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static bool BshTazuGKstVeyZL(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static void CkQuTGmOzkvrFUfo(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto2) {
        descriptorProtos$DescriptorProto.addNestedType(i, descriptorProtos$DescriptorProto2);
    }

    public static void CtcpLcbTmRxbXpeD(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureExtensionIsMutable();
    }

    public static void CvanOXpebInFKJKv(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureFieldIsMutable();
    }

    public static void DHlhchNxzUBMQfkT(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$DescriptorProto.addEnumType(descriptorProtos$EnumDescriptorProto);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions DOoLMSITnHqQBWJu() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions.getDefaultInstance();
    }

    public static bool DXaKTzbvSyAEjHOG(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static void DduFdKarNsqaztFy(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureExtensionRangeIsMutable();
    }

    public static void DtjHvBjLLXZiDUDQ(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$DescriptorProto.addAllExtension(iterable);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList ELmPOjKgyGRduDvp() {
        return emptyProtobufList();
    }

    public static bool ENLGvdjEPREgpwYN(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static void ElMOfhsDDIooNMVR(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.clearNestedType();
    }

    public static java.lang.string FKEqAknDaQhhAqCR(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.tostringUtf8();
    }

    public static bool FSZtopBArmKoUHTh(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static void FigPdUQVYiUAsyUt(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureExtensionRangeIsMutable();
    }

    public static int FjTUnWWgmqZqcQsR(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static java.lang.object FmgYDRGtjFLOGfUa(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static void FvRsznDCsIHdpPFp(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        descriptorProtos$DescriptorProto.mergeOptions(descriptorProtos$MessageOptions);
    }

    public static java.lang.object GItTSPGwvvJBNWHO(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static java.lang.object GLyfWvzgtykkdvOn(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static void GQXhufcWQDDWKLCn(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureFieldIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList GcCtvLzWycyygATF() {
        return emptyProtobufList();
    }

    public static bool GlBEOgKDkufzLQUl(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static void HAgSwAgzhmaZeuxq(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureExtensionRangeIsMutable();
    }

    public static void HKhjWtFWZUEBgKeQ(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        descriptorProtos$DescriptorProto.setOptions(descriptorProtos$MessageOptions);
    }

    public static void HRWspEuBGsYXhvZT(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.string str) {
        descriptorProtos$DescriptorProto.addReservedName(str);
    }

    public static void HWOHekkNPLUXdOdu(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto2) {
        descriptorProtos$DescriptorProto.setNestedType(i, descriptorProtos$DescriptorProto2);
    }

    public static void HhSRWjoNFcVTsEUM(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureOneofDeclIsMutable();
    }

    public static void HmUrGWsiwqgroPky(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureNestedTypeIsMutable();
    }

    public static java.lang.object HopOTygIajocnssc(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static void HrmHOXSlNprqcyQl(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureReservedRangeIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite HyTyAEeqWnswvMNu(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, byte[] bArr) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bArr);
    }

    public static int IVAisVvhYHKMzDtx(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke) {
        return generatedMessageLite$MethodToInvoke.ordinal();
    }

    public static void IdPhDllaznJkHGlW(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList IhPAMlZZwjrnNcwK(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static java.lang.Class JLCilqYHUFOMvNwb(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool JvThnEsSROFEPPkC(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static bool KWKPYJqDMBMAlIlS(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static java.lang.Class KYJtkvCojoLdctqQ(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool KidReSBkhxsfFNIr(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList KwBCMFkQVijuPNnw() {
        return emptyProtobufList();
    }

    public static bool LWknsSDwtoHUJDJt(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static void LYIpInLrHWarUmfj(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.clearExtensionRange();
    }

    public static void LjwBFeLfBytvHyKa(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$DescriptorProto.setEnumType(i, descriptorProtos$EnumDescriptorProto);
    }

    public static java.lang.object LqwmsUGBXjilkoOR(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList LtADkOguLRrewSeW(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static void MDMHccsIpqDPpHey(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureFieldIsMutable();
    }

    public static void MOgwxxVvPlsNDUQq(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList MSDZLvGQfFTwOcKX() {
        return emptyProtobufList();
    }

    public static java.lang.string MfZPttDEVDwVJwKe(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.tostringUtf8();
    }

    public static void MiOZDJRsiEjBJaWj(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureReservedNameIsMutable();
    }

    public static int MjyyxPHahzEfergF(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static void MyRMvDwLTZDpIoAI(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$DescriptorProto.addExtension(descriptorProtos$FieldDescriptorProto);
    }

    public static void MyeWpjzcfNIQUdae(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureReservedNameIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.bytestring MzKIPZoGrJOdpbPP(java.lang.string str) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(str);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite NZbXetphZXEzssqQ(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, inputStream);
    }

    public static void NjjHIiHAiLviXHZy(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.string str) {
        descriptorProtos$DescriptorProto.setName(str);
    }

    public static void NunyQEokrjGnlxSU(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$DescriptorProto.addEnumType(i, descriptorProtos$EnumDescriptorProto);
    }

    public static java.lang.object NvGRuaAhvXDpPGPQ(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite OJGVvxtKmzdoWHbe(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, byteBuffer);
    }

    public static java.lang.object PFxUTMKZlHpDwMce(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static void PPwsqMTkeSTCsoEA(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.clearEnumType();
    }

    public static void PcTZvBPZhWpMynrC(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static void PsCUEMwjffUQBQhC(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.clearReservedName();
    }

    public static java.lang.Class PvIXxvVfEUUJpciI(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object QDWWppBgSuOkVKsu(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static java.lang.Class QUhIVmVkBNxkIJiI(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.Parser QYLEakNuNrxqenSE(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        return descriptorProtos$DescriptorProto.getParserForType();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList QaJcnXPoygdbdBeZ() {
        return emptyProtobufList();
    }

    public static java.lang.object QqGuJqdCUXTezeLx(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static java.lang.object RIJXfqxyqDEuEDjD(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static bool RJlBxDLhlmuNidMr(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static java.lang.Class RcubHPnVRupbRiGK(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite RhAkNoaitNLmtOqF(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bytestring);
    }

    public static java.lang.Class SGQLhgcjcCchTGGm(java.lang.object obj) {
        return obj.GetType();
    }

    public static void SjrUKpbPSplJUygR(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureFieldIsMutable();
    }

    public static java.lang.object SqrVepqcurfVduPi(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static java.lang.Class TLxJSCFLSKXzCbyE(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList TRjwAZDWBGylwQji() {
        return emptyProtobufList();
    }

    public static void ToCJWBoJoEptEZgn(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureExtensionIsMutable();
    }

    public static void TzNPGGOfBUIGxwwM(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureOneofDeclIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList UGFYeDkSviEOFVgE() {
        return emptyProtobufList();
    }

    public static void ULlrmmebWDZCVvAv(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureExtensionIsMutable();
    }

    public static void UWkmimAVyMZxOIaq(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange descriptorProtos$DescriptorProto$ReservedRange) {
        descriptorProtos$DescriptorProto.setReservedRange(i, descriptorProtos$DescriptorProto$ReservedRange);
    }

    public static void UXYZtasYiUZdMNnE(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$DescriptorProto.addField(i, descriptorProtos$FieldDescriptorProto);
    }

    public static java.lang.Class UcNWYcxyKLWfLiTi(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.Class UunDvxPYySImdQAj(java.lang.object obj) {
        return obj.GetType();
    }

    public static void UvgSUmGixcQpOkBL(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$DescriptorProto.addAllNestedType(iterable);
    }

    public static java.lang.Class VHlrCGiQRsdNFEVK(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList VMjlRGIGBkMLxDiO(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static java.lang.object VhMuWoIcYxknSIPc(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static void VtexVXXRVqYvlMZN(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static void VxPyEsEPlEkAbrPB(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureEnumTypeIsMutable();
    }

    public static void WJqkbOZuBrltgAXU(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$DescriptorProto.addReservedNamebytes(bytestring);
    }

    public static java.lang.byte WSMamXURSdEYsGSw(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static void WSVDrpPDfSDTBCKC(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.clearExtension();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite WUmPfKAnDNKvnEYD(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, codedStream, extensionRegistryLite);
    }

    public static void WpLLXwNPuXyjKfHE(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static void XNVUhsiwTFfFNwjY(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureEnumTypeIsMutable();
    }

    public static java.lang.Class XrFJcJCETUMnVYNm(java.lang.object obj) {
        return obj.GetType();
    }

    public static void XzZwjlKyaRkCsUoo(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto) {
        descriptorProtos$DescriptorProto.addOneofDecl(descriptorProtos$OneofDescriptorProto);
    }

    public static java.lang.object YAafblKMWWjGkZVa(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static void YKwqOVaOjGsPVIFV(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto) {
        descriptorProtos$DescriptorProto.setOneofDecl(i, descriptorProtos$OneofDescriptorProto);
    }

    public static java.lang.Class YPfPCTSAKZJsIkMO(java.lang.object obj) {
        return obj.GetType();
    }

    public static int YUjXNyUmVQJuknzH(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static void YbqCYNVUTZLOTBBn(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureNestedTypeIsMutable();
    }

    public static void YkWwLNSPReieKHHk(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$DescriptorProto.setNamebytes(bytestring);
    }

    public static void YmOhJyjhjuPYowMX(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureNestedTypeIsMutable();
    }

    public static void ZBDdYFyezwqPKgUI(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$DescriptorProto.addAllReservedRange(iterable);
    }

    public static void ZGrIlcMDPuuGIUWK(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureExtensionIsMutable();
    }

    public static void ZgnnFHsDSArOoXTf(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureExtensionIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList ZkSuaKiCPuPUpqNs() {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.emptyProtobufList();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList ZmwrhfYglCACoXrf() {
        return emptyProtobufList();
    }

    public static java.lang.object ZovslyCHWeqgFJgm(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static void ZqDKyJzxjHlfrndX(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureReservedNameIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite ZrclFUIOOEpThTDq(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bytestring, extensionRegistryLite);
    }

    public static void AWMnSmzTqYezoaSr(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$DescriptorProto.addAllReservedName(iterable);
    }

    static void access$10000(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        xiYyZgoEQhXMeLYv(descriptorProtos$DescriptorProto, i);
    }

    static void access$10100(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        LjwBFeLfBytvHyKa(descriptorProtos$DescriptorProto, i, descriptorProtos$EnumDescriptorProto);
    }

    static void access$10200(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        DHlhchNxzUBMQfkT(descriptorProtos$DescriptorProto, descriptorProtos$EnumDescriptorProto);
    }

    static void access$10300(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        NunyQEokrjGnlxSU(descriptorProtos$DescriptorProto, i, descriptorProtos$EnumDescriptorProto);
    }

    static void access$10400(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        ceEtsYMRYaBigaio(descriptorProtos$DescriptorProto, iterable);
    }

    static void access$10500(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        PPwsqMTkeSTCsoEA(descriptorProtos$DescriptorProto);
    }

    static void access$10600(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        iSbKqijraCJQhRsW(descriptorProtos$DescriptorProto, i);
    }

    static void access$10700(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange descriptorProtos$DescriptorProto$ExtensionRange) {
        hEYlAismpRLHUSoq(descriptorProtos$DescriptorProto, i, descriptorProtos$DescriptorProto$ExtensionRange);
    }

    static void access$10800(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange descriptorProtos$DescriptorProto$ExtensionRange) {
        wbfAFUyrRBsfXvbJ(descriptorProtos$DescriptorProto, descriptorProtos$DescriptorProto$ExtensionRange);
    }

    static void access$10900(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange descriptorProtos$DescriptorProto$ExtensionRange) {
        okUnxwUiiTmSzhqE(descriptorProtos$DescriptorProto, i, descriptorProtos$DescriptorProto$ExtensionRange);
    }

    static void access$11000(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        rAFhoeFUHSAbyDhR(descriptorProtos$DescriptorProto, iterable);
    }

    static void access$11100(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        LYIpInLrHWarUmfj(descriptorProtos$DescriptorProto);
    }

    static void access$11200(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        mZkzlrIukRTZqOey(descriptorProtos$DescriptorProto, i);
    }

    static void access$11300(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto) {
        YKwqOVaOjGsPVIFV(descriptorProtos$DescriptorProto, i, descriptorProtos$OneofDescriptorProto);
    }

    static void access$11400(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto) {
        XzZwjlKyaRkCsUoo(descriptorProtos$DescriptorProto, descriptorProtos$OneofDescriptorProto);
    }

    static void access$11500(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto) {
        oEvPTjwEwkSazyHZ(descriptorProtos$DescriptorProto, i, descriptorProtos$OneofDescriptorProto);
    }

    static void access$11600(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        tnyRRHozRdyXkWIg(descriptorProtos$DescriptorProto, iterable);
    }

    static void access$11700(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        dYlCJFZBLfoXOqFV(descriptorProtos$DescriptorProto);
    }

    static void access$11800(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        eWwfCDRzXXoEXsqz(descriptorProtos$DescriptorProto, i);
    }

    static void access$11900(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        HKhjWtFWZUEBgKeQ(descriptorProtos$DescriptorProto, descriptorProtos$MessageOptions);
    }

    static void access$12000(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        FvRsznDCsIHdpPFp(descriptorProtos$DescriptorProto, descriptorProtos$MessageOptions);
    }

    static void access$12100(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        BfRevnGpjhqFsmgC(descriptorProtos$DescriptorProto);
    }

    static void access$12200(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange descriptorProtos$DescriptorProto$ReservedRange) {
        UWkmimAVyMZxOIaq(descriptorProtos$DescriptorProto, i, descriptorProtos$DescriptorProto$ReservedRange);
    }

    static void access$12300(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange descriptorProtos$DescriptorProto$ReservedRange) {
        vfyYeoKsFHqnQJQk(descriptorProtos$DescriptorProto, descriptorProtos$DescriptorProto$ReservedRange);
    }

    static void access$12400(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange descriptorProtos$DescriptorProto$ReservedRange) {
        kZVosqZnEuVqbONg(descriptorProtos$DescriptorProto, i, descriptorProtos$DescriptorProto$ReservedRange);
    }

    static void access$12500(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        ZBDdYFyezwqPKgUI(descriptorProtos$DescriptorProto, iterable);
    }

    static void access$12600(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        igGrcYOkFwUgZXLa(descriptorProtos$DescriptorProto);
    }

    static void access$12700(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        AQIjZhaGXlINoKiL(descriptorProtos$DescriptorProto, i);
    }

    static void access$12800(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, java.lang.string str) {
        sQmbdDhFpPwkwkLe(descriptorProtos$DescriptorProto, i, str);
    }

    static void access$12900(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.string str) {
        HRWspEuBGsYXhvZT(descriptorProtos$DescriptorProto, str);
    }

    static void access$13000(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        aWMnSmzTqYezoaSr(descriptorProtos$DescriptorProto, iterable);
    }

    static void access$13100(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        PsCUEMwjffUQBQhC(descriptorProtos$DescriptorProto);
    }

    static void access$13200(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        WJqkbOZuBrltgAXU(descriptorProtos$DescriptorProto, bytestring);
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto access$7900() {
        return DEFAULT_INSTANCE;
    }

    static void access$8000(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.string str) {
        NjjHIiHAiLviXHZy(descriptorProtos$DescriptorProto, str);
    }

    static void access$8100(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        mOpmirQHqadaThze(descriptorProtos$DescriptorProto);
    }

    static void access$8200(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        YkWwLNSPReieKHHk(descriptorProtos$DescriptorProto, bytestring);
    }

    static void access$8300(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        sKVOwOfMGNsECrJv(descriptorProtos$DescriptorProto, i, descriptorProtos$FieldDescriptorProto);
    }

    static void access$8400(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        mtTJgmKyiSnOMrDi(descriptorProtos$DescriptorProto, descriptorProtos$FieldDescriptorProto);
    }

    static void access$8500(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        UXYZtasYiUZdMNnE(descriptorProtos$DescriptorProto, i, descriptorProtos$FieldDescriptorProto);
    }

    static void access$8600(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        mDPElLUeCxFLEIUz(descriptorProtos$DescriptorProto, iterable);
    }

    static void access$8700(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        BWBeRPnxmigNlwsI(descriptorProtos$DescriptorProto);
    }

    static void access$8800(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        kNwGPwgzUxqbbfoC(descriptorProtos$DescriptorProto, i);
    }

    static void access$8900(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        fsryxbEAuMfoCZBA(descriptorProtos$DescriptorProto, i, descriptorProtos$FieldDescriptorProto);
    }

    static void access$9000(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        MyRMvDwLTZDpIoAI(descriptorProtos$DescriptorProto, descriptorProtos$FieldDescriptorProto);
    }

    static void access$9100(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        fsNyxLVJTjKHScwQ(descriptorProtos$DescriptorProto, i, descriptorProtos$FieldDescriptorProto);
    }

    static void access$9200(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        DtjHvBjLLXZiDUDQ(descriptorProtos$DescriptorProto, iterable);
    }

    static void access$9300(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        WSVDrpPDfSDTBCKC(descriptorProtos$DescriptorProto);
    }

    static void access$9400(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        aiOVluRapQeDSqJj(descriptorProtos$DescriptorProto, i);
    }

    static void access$9500(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto2) {
        HWOHekkNPLUXdOdu(descriptorProtos$DescriptorProto, i, descriptorProtos$DescriptorProto2);
    }

    static void access$9600(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto2) {
        AiTKztccdZdRsGeG(descriptorProtos$DescriptorProto, descriptorProtos$DescriptorProto2);
    }

    static void access$9700(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto2) {
        CkQuTGmOzkvrFUfo(descriptorProtos$DescriptorProto, i, descriptorProtos$DescriptorProto2);
    }

    static void access$9800(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        UvgSUmGixcQpOkBL(descriptorProtos$DescriptorProto, iterable);
    }

    static void access$9900(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        ElMOfhsDDIooNMVR(descriptorProtos$DescriptorProto);
    }

    private void AddAllEnumType(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto> iterable) {
        bARRcrZhibxoDnFN(this);
        ssDFYozfUXRAQIVS(iterable, this.enumType_);
    }

    private void AddAllExtension(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> iterable) {
        ZGrIlcMDPuuGIUWK(this);
        VtexVXXRVqYvlMZN(iterable, this.extension_);
    }

    private void AddAllExtensionRange(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange> iterable) {
        jcKERlXhieWqoUXa(this);
        MOgwxxVvPlsNDUQq(iterable, this.extensionRange_);
    }

    private void AddAllField(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> iterable) {
        AqwdMGGqrrgnyQPA(this);
        kpfcMZdGYMXZqKDX(iterable, this.field_);
    }

    private void AddAllNestedType(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto> iterable) {
        HmUrGWsiwqgroPky(this);
        WpLLXwNPuXyjKfHE(iterable, this.nestedType_);
    }

    private void AddAllOneofDecl(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto> iterable) {
        zhAEbnwQEUWzjmod(this);
        xVFuPTCMCElsbakt(iterable, this.oneofDecl_);
    }

    private void AddAllReservedName(java.lang.IEnumerable<java.lang.string> iterable) {
        xYvgxodoFTsrnbkC(this);
        sphDRFvdMSiRATHZ(iterable, this.reservedName_);
    }

    private void AddAllReservedRange(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange> iterable) {
        gtfQDwkeHZEoWZqn(this);
        PcTZvBPZhWpMynrC(iterable, this.reservedRange_);
    }

    private void AddEnumType(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        xGGOljhIcItShxdc(descriptorProtos$EnumDescriptorProto);
        pbCzyOmZTVMJcMbS(this);
        kxeHpOObzEOkNdsr(this.enumType_, i, descriptorProtos$EnumDescriptorProto);
    }

    private void AddEnumType(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        diYSHSgVvzjEZJqJ(descriptorProtos$EnumDescriptorProto);
        XNVUhsiwTFfFNwjY(this);
        DXaKTzbvSyAEjHOG(this.enumType_, descriptorProtos$EnumDescriptorProto);
    }

    private void AddExtension(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        XrFJcJCETUMnVYNm(descriptorProtos$FieldDescriptorProto);
        CtcpLcbTmRxbXpeD(this);
        pafRDtDEIBjnOkAw(this.extension_, i, descriptorProtos$FieldDescriptorProto);
    }

    private void AddExtension(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        heuFeEJTquxsbvfs(descriptorProtos$FieldDescriptorProto);
        ToCJWBoJoEptEZgn(this);
        RJlBxDLhlmuNidMr(this.extension_, descriptorProtos$FieldDescriptorProto);
    }

    private void AddExtensionRange(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange descriptorProtos$DescriptorProto$ExtensionRange) {
        quZkuDTPykGOrRwi(descriptorProtos$DescriptorProto$ExtensionRange);
        FigPdUQVYiUAsyUt(this);
        rydHdnWtJpljbfWC(this.extensionRange_, i, descriptorProtos$DescriptorProto$ExtensionRange);
    }

    private void AddExtensionRange(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange descriptorProtos$DescriptorProto$ExtensionRange) {
        YPfPCTSAKZJsIkMO(descriptorProtos$DescriptorProto$ExtensionRange);
        BPnRQrvlqnDWBFzH(this);
        ENLGvdjEPREgpwYN(this.extensionRange_, descriptorProtos$DescriptorProto$ExtensionRange);
    }

    private void AddField(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        oFsnIQJYYiKMxHLK(descriptorProtos$FieldDescriptorProto);
        GQXhufcWQDDWKLCn(this);
        oKdpIkuLdQYRwiZx(this.field_, i, descriptorProtos$FieldDescriptorProto);
    }

    private void AddField(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        SGQLhgcjcCchTGGm(descriptorProtos$FieldDescriptorProto);
        CvanOXpebInFKJKv(this);
        hoBFvMkVUKtxcQqW(this.field_, descriptorProtos$FieldDescriptorProto);
    }

    private void AddNestedType(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        QUhIVmVkBNxkIJiI(descriptorProtos$DescriptorProto);
        yCDXmIbKFgtDLnEN(this);
        IdPhDllaznJkHGlW(this.nestedType_, i, descriptorProtos$DescriptorProto);
    }

    private void AddNestedType(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        TLxJSCFLSKXzCbyE(descriptorProtos$DescriptorProto);
        nxxcYwUeujwvPstU(this);
        KWKPYJqDMBMAlIlS(this.nestedType_, descriptorProtos$DescriptorProto);
    }

    private void AddOneofDecl(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto) {
        fjVFTZIDSSPNPule(descriptorProtos$OneofDescriptorProto);
        HhSRWjoNFcVTsEUM(this);
        AXoILBoFdytDJPde(this.oneofDecl_, i, descriptorProtos$OneofDescriptorProto);
    }

    private void AddOneofDecl(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto) {
        vDujjHklDVUHyVnr(descriptorProtos$OneofDescriptorProto);
        fcXCpNzHqNeuuTHX(this);
        BsOsXSCxdYONCcma(this.oneofDecl_, descriptorProtos$OneofDescriptorProto);
    }

    private void AddReservedName(java.lang.string str) {
        oQUUJIZqmkPJvlYV(str);
        ZqDKyJzxjHlfrndX(this);
        FSZtopBArmKoUHTh(this.reservedName_, str);
    }

    private void AddReservedNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        MiOZDJRsiEjBJaWj(this);
        BshTazuGKstVeyZL(this.reservedName_, MfZPttDEVDwVJwKe(bytestring));
    }

    private void AddReservedRange(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange descriptorProtos$DescriptorProto$ReservedRange) {
        PvIXxvVfEUUJpciI(descriptorProtos$DescriptorProto$ReservedRange);
        ArGyOlfgrPjbwbvI(this);
        crfXAAKpoLjRlOCd(this.reservedRange_, i, descriptorProtos$DescriptorProto$ReservedRange);
    }

    private void AddReservedRange(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange descriptorProtos$DescriptorProto$ReservedRange) {
        kiqEzweEcSHafZLm(descriptorProtos$DescriptorProto$ReservedRange);
        jaZwNbXHuqPahsYx(this);
        GlBEOgKDkufzLQUl(this.reservedRange_, descriptorProtos$DescriptorProto$ReservedRange);
    }

    public static void AiOVluRapQeDSqJj(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        descriptorProtos$DescriptorProto.removeExtension(i);
    }

    public static void BARRcrZhibxoDnFN(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureEnumTypeIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList bVNdkWFFGddkWTOH(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static java.lang.object BhdkxxPQBepTIJgR(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList bitklDjCXCGLwowE() {
        return emptyProtobufList();
    }

    public static java.lang.object BjeKFddwVMhyUQpJ(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static int CeAPNvONAgfOeZen(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static void CeEtsYMRYaBigaio(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$DescriptorProto.addAllEnumType(iterable);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite CktnfecZiXNnyhNZ(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, codedStream);
    }

    private void ClearEnumType() {
        this.enumType_ = MSDZLvGQfFTwOcKX();
    }

    private void ClearExtension() {
        this.extension_ = TRjwAZDWBGylwQji();
    }

    private void ClearExtensionRange() {
        this.extensionRange_ = GcCtvLzWycyygATF();
    }

    private void ClearField() {
        this.field_ = uRqGPOYNgmtumkGm();
    }

    private void ClearName() {
        this.bitField0_ &= -2;
        this.name_ = knyHkupzMeItGiYw(tzzCsuaYkLAcrxIi());
    }

    private void ClearNestedType() {
        this.nestedType_ = QaJcnXPoygdbdBeZ();
    }

    private void ClearOneofDecl() {
        this.oneofDecl_ = UGFYeDkSviEOFVgE();
    }

    private void ClearOptions() {
        this.options_ = null;
        this.bitField0_ &= -3;
    }

    private void ClearReservedName() {
        this.reservedName_ = ZkSuaKiCPuPUpqNs();
    }

    private void ClearReservedRange() {
        this.reservedRange_ = AgJdMhKnnUXspISM();
    }

    public static void CrfXAAKpoLjRlOCd(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    public static java.lang.object CtSVwEKodnTeyoPA(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static int CwdstyxoAjodNdoa(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static java.lang.Class DCyehHPDrfmeeBrY(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.Class DGeQwMYYdWyqbZOE(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object DLLOfbkYkqNMBWfG(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList dNXbgwIyJUWRjeOt(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static void DYlCJFZBLfoXOqFV(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.clearOneofDecl();
    }

    public static java.lang.Class DiYSHSgVvzjEZJqJ(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite EHgXvzCabVnsQGtk(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return parseDelimitedFrom(generatedMessageLite, inputStream, extensionRegistryLite);
    }

    public static void EWwfCDRzXXoEXsqz(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        descriptorProtos$DescriptorProto.removeOneofDecl(i);
    }

    private void EnsureEnumTypeIsMutable() {
        if ((23 + 27) % 27 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto> internal$ProtobufList = this.enumType_;
        if (mRkQyfEcsIRGQDLY(internal$ProtobufList)) {
            return;
        }
        this.enumType_ = bVNdkWFFGddkWTOH(internal$ProtobufList);
    }

    private void EnsureExtensionIsMutable() {
        if ((28 + 16) % 16 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> internal$ProtobufList = this.extension_;
        if (KidReSBkhxsfFNIr(internal$ProtobufList)) {
            return;
        }
        this.extension_ = LtADkOguLRrewSeW(internal$ProtobufList);
    }

    private void EnsureExtensionRangeIsMutable() {
        if ((25 + 10) % 10 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange> internal$ProtobufList = this.extensionRange_;
        if (zeugMUPidSmJBqDe(internal$ProtobufList)) {
            return;
        }
        this.extensionRange_ = AKPVTPcWYuwefuWO(internal$ProtobufList);
    }

    private void EnsureFieldIsMutable() {
        if ((11 + 4) % 4 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> internal$ProtobufList = this.field_;
        if (yzFaAEzZBmuMnXrS(internal$ProtobufList)) {
            return;
        }
        this.field_ = gzMoWepGkSCFXrSi(internal$ProtobufList);
    }

    private void EnsureNestedTypeIsMutable() {
        if ((19 + 9) % 9 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto> internal$ProtobufList = this.nestedType_;
        if (oxtnLPpdRqrEXFQJ(internal$ProtobufList)) {
            return;
        }
        this.nestedType_ = dNXbgwIyJUWRjeOt(internal$ProtobufList);
    }

    private void EnsureOneofDeclIsMutable() {
        if ((14 + 18) % 18 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto> internal$ProtobufList = this.oneofDecl_;
        if (JvThnEsSROFEPPkC(internal$ProtobufList)) {
            return;
        }
        this.oneofDecl_ = IhPAMlZZwjrnNcwK(internal$ProtobufList);
    }

    private void EnsureReservedNameIsMutable() {
        if ((25 + 31) % 31 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.string> internal$ProtobufList = this.reservedName_;
        if (kGCfAqcInhSCueiT(internal$ProtobufList)) {
            return;
        }
        this.reservedName_ = VMjlRGIGBkMLxDiO(internal$ProtobufList);
    }

    private void EnsureReservedRangeIsMutable() {
        if ((13 + 6) % 6 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange> internal$ProtobufList = this.reservedRange_;
        if (LWknsSDwtoHUJDJt(internal$ProtobufList)) {
            return;
        }
        this.reservedRange_ = BWaTrNfWUjFFHSlP(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList fEfbecGrzvtftxJP() {
        return emptyProtobufList();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions$Builder fJFRgDBZibGwyFZb(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions.newBuilder(descriptorProtos$MessageOptions);
    }

    public static void FcXCpNzHqNeuuTHX(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureOneofDeclIsMutable();
    }

    public static java.lang.Class FjVFTZIDSSPNPule(java.lang.object obj) {
        return obj.GetType();
    }

    public static void FsNyxLVJTjKHScwQ(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$DescriptorProto.addExtension(i, descriptorProtos$FieldDescriptorProto);
    }

    public static void FsryxbEAuMfoCZBA(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$DescriptorProto.setExtension(i, descriptorProtos$FieldDescriptorProto);
    }

    public static java.lang.object GcJguaxgbSGFtfNr(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite GpMdsiExqISsOcQS(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream) {
        return parseDelimitedFrom(generatedMessageLite, inputStream);
    }

    public static void GtfQDwkeHZEoWZqn(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureReservedRangeIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage gyckSvMHuuKhdokI(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions$Builder descriptorProtos$MessageOptions$Builder) {
        return descriptorProtos$MessageOptions$Builder.buildPartial();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList gzMoWepGkSCFXrSi(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static void HEYlAismpRLHUSoq(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange descriptorProtos$DescriptorProto$ExtensionRange) {
        descriptorProtos$DescriptorProto.setExtensionRange(i, descriptorProtos$DescriptorProto$ExtensionRange);
    }

    public static java.lang.Class HeuFeEJTquxsbvfs(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool HoBFvMkVUKtxcQqW(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static void HvXbRRSeqAdYzMAk(java.lang.Class cls, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(cls, generatedMessageLite);
    }

    public static java.lang.object IEqRmaDaWZXpuXFT(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static void ISbKqijraCJQhRsW(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        descriptorProtos$DescriptorProto.removeEnumType(i);
    }

    public static java.lang.object IfguhQGPglUxnKiG(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static void IgGrcYOkFwUgZXLa(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.clearReservedRange();
    }

    public static java.lang.Class IgWPpZIDVLlpejcv(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object IwMDvHsysmDRpomO(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static java.lang.object JTmdVSqiofUIJrvq(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static void JaZwNbXHuqPahsYx(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureReservedRangeIsMutable();
    }

    public static void JcKERlXhieWqoUXa(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureExtensionRangeIsMutable();
    }

    public static bool KGCfAqcInhSCueiT(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static void KNwGPwgzUxqbbfoC(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        descriptorProtos$DescriptorProto.removeField(i);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder kVWgtNAvCYpWRjWk(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        return descriptorProtos$DescriptorProto.createBuilder(generatedMessageLite);
    }

    public static void KZVosqZnEuVqbONg(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange descriptorProtos$DescriptorProto$ReservedRange) {
        descriptorProtos$DescriptorProto.addReservedRange(i, descriptorProtos$DescriptorProto$ReservedRange);
    }

    public static java.lang.Class KiqEzweEcSHafZLm(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string KnyHkupzMeItGiYw(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        return descriptorProtos$DescriptorProto.getName();
    }

    public static void KpfcMZdGYMXZqKDX(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static void KxeHpOObzEOkNdsr(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    public static java.lang.Class LxYsnLSPXcMvMRFm(java.lang.object obj) {
        return obj.GetType();
    }

    public static void MDPElLUeCxFLEIUz(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$DescriptorProto.addAllField(iterable);
    }

    public static void MOpmirQHqadaThze(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.clearName();
    }

    public static bool MRkQyfEcsIRGQDLY(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static void MZkzlrIukRTZqOey(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        descriptorProtos$DescriptorProto.removeExtensionRange(i);
    }

    private void MergeOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        if ((1 + 17) % 17 > 0) {
        }
        lxYsnLSPXcMvMRFm(descriptorProtos$MessageOptions);
        androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions2 = this.options_;
        if (descriptorProtos$MessageOptions2 is null || descriptorProtos$MessageOptions2 == orHSkLEgNzlWAKMh()) {
            this.options_ = descriptorProtos$MessageOptions;
        } else {
            this.options_ = (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions) gyckSvMHuuKhdokI((androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions$Builder) vChpSnlLiuhBXAxM(fJFRgDBZibGwyFZb(this.options_), descriptorProtos$MessageOptions));
        }
        this.bitField0_ |= 2;
    }

    public static void MtTJgmKyiSnOMrDi(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$DescriptorProto.addField(descriptorProtos$FieldDescriptorProto);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$Builder newBuilder() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$Builder) AdRUaTsjbYaLtnGN(DEFAULT_INSTANCE);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$Builder) kVWgtNAvCYpWRjWk(DEFAULT_INSTANCE, descriptorProtos$DescriptorProto);
    }

    public static void NxxcYwUeujwvPstU(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureNestedTypeIsMutable();
    }

    public static void OEvPTjwEwkSazyHZ(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto) {
        descriptorProtos$DescriptorProto.addOneofDecl(i, descriptorProtos$OneofDescriptorProto);
    }

    public static java.lang.Class OFsnIQJYYiKMxHLK(java.lang.object obj) {
        return obj.GetType();
    }

    public static void OKdpIkuLdQYRwiZx(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    public static java.lang.object OKyZsxgiOTyEkwOV(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static java.lang.Class OQUUJIZqmkPJvlYV(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object OgfRmwfJnHDCcrlO(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static void OkUnxwUiiTmSzhqE(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange descriptorProtos$DescriptorProto$ExtensionRange) {
        descriptorProtos$DescriptorProto.addExtensionRange(i, descriptorProtos$DescriptorProto$ExtensionRange);
    }

    public static void OkVYfpbLaJkbrVOc(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureReservedRangeIsMutable();
    }

    public static java.lang.object OlsmkVUcPNsQHbFT(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions orHSkLEgNzlWAKMh() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions.getDefaultInstance();
    }

    public static bool OxtnLPpdRqrEXFQJ(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite PCRvoQaYwhkfYUkI(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, inputStream, extensionRegistryLite);
    }

    public static void PafRDtDEIBjnOkAw(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto) gpMdsiExqISsOcQS(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto) eHgXvzCabVnsQGtk(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto) RhAkNoaitNLmtOqF(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto) ZrclFUIOOEpThTDq(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto) cktnfecZiXNnyhNZ(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto) WUmPfKAnDNKvnEYD(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto) NZbXetphZXEzssqQ(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto) pCRvoQaYwhkfYUkI(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto) OJGVvxtKmzdoWHbe(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto) rEOzMWFSksTsGRwr(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto) HyTyAEeqWnswvMNu(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto) BIPelRmqqEhAlUzJ(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto> parser() {
        return QYLEakNuNrxqenSE(DEFAULT_INSTANCE);
    }

    public static void PbCzyOmZTVMJcMbS(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureEnumTypeIsMutable();
    }

    public static int PkAGbhYoegLwGqym(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static java.lang.object QTjUHcrQwYBEptwS(androidx.datastore.preferences.protobuf.MessageLite messageLite, java.lang.string str, java.lang.object[] objArr) {
        return newMessageInfo(messageLite, str, objArr);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList qWMlukyGKtNgTPiF() {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.emptyProtobufList();
    }

    public static java.lang.Class QuZkuDTPykGOrRwi(java.lang.object obj) {
        return obj.GetType();
    }

    public static void RAFhoeFUHSAbyDhR(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$DescriptorProto.addAllExtensionRange(iterable);
    }

    public static int RAMlzarJZKKABNgX(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite REOzMWFSksTsGRwr(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, byteBuffer, extensionRegistryLite);
    }

    public static java.lang.object RYzEyxlIRwrzObhZ(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    private void RemoveEnumType(int i) {
        VxPyEsEPlEkAbrPB(this);
        olsmkVUcPNsQHbFT(this.enumType_, i);
    }

    private void RemoveExtension(int i) {
        ZgnnFHsDSArOoXTf(this);
        jTmdVSqiofUIJrvq(this.extension_, i);
    }

    private void RemoveExtensionRange(int i) {
        HAgSwAgzhmaZeuxq(this);
        iEqRmaDaWZXpuXFT(this.extensionRange_, i);
    }

    private void RemoveField(int i) {
        MDMHccsIpqDPpHey(this);
        dLLOfbkYkqNMBWfG(this.field_, i);
    }

    private void RemoveNestedType(int i) {
        YbqCYNVUTZLOTBBn(this);
        PFxUTMKZlHpDwMce(this.nestedType_, i);
    }

    private void RemoveOneofDecl(int i) {
        vQWjOaYAYJbptNwU(this);
        ogfRmwfJnHDCcrlO(this.oneofDecl_, i);
    }

    private void RemoveReservedRange(int i) {
        HrmHOXSlNprqcyQl(this);
        iwMDvHsysmDRpomO(this.reservedRange_, i);
    }

    public static void RydHdnWtJpljbfWC(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    public static void SKVOwOfMGNsECrJv(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$DescriptorProto.setField(i, descriptorProtos$FieldDescriptorProto);
    }

    public static void SQmbdDhFpPwkwkLe(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i, java.lang.string str) {
        descriptorProtos$DescriptorProto.setReservedName(i, str);
    }

    private void SetEnumType(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        RcubHPnVRupbRiGK(descriptorProtos$EnumDescriptorProto);
        vhfDWlUNaZbVMemL(this);
        LqwmsUGBXjilkoOR(this.enumType_, i, descriptorProtos$EnumDescriptorProto);
    }

    private void SetExtension(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        dGeQwMYYdWyqbZOE(descriptorProtos$FieldDescriptorProto);
        ULlrmmebWDZCVvAv(this);
        AeEVdsNNfffVEvDD(this.extension_, i, descriptorProtos$FieldDescriptorProto);
    }

    private void SetExtensionRange(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange descriptorProtos$DescriptorProto$ExtensionRange) {
        KYJtkvCojoLdctqQ(descriptorProtos$DescriptorProto$ExtensionRange);
        DduFdKarNsqaztFy(this);
        GItTSPGwvvJBNWHO(this.extensionRange_, i, descriptorProtos$DescriptorProto$ExtensionRange);
    }

    private void SetField(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        VHlrCGiQRsdNFEVK(descriptorProtos$FieldDescriptorProto);
        SjrUKpbPSplJUygR(this);
        ifguhQGPglUxnKiG(this.field_, i, descriptorProtos$FieldDescriptorProto);
    }

    private void SetName(java.lang.string str) {
        igWPpZIDVLlpejcv(str);
        this.bitField0_ |= 1;
        this.name_ = str;
    }

    private void SetNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.name_ = FKEqAknDaQhhAqCR(bytestring);
        this.bitField0_ |= 1;
    }

    private void SetNestedType(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        UcNWYcxyKLWfLiTi(descriptorProtos$DescriptorProto);
        YmOhJyjhjuPYowMX(this);
        ctSVwEKodnTeyoPA(this.nestedType_, i, descriptorProtos$DescriptorProto);
    }

    private void SetOneofDecl(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto) {
        JLCilqYHUFOMvNwb(descriptorProtos$OneofDescriptorProto);
        TzNPGGOfBUIGxwwM(this);
        YAafblKMWWjGkZVa(this.oneofDecl_, i, descriptorProtos$OneofDescriptorProto);
    }

    private void SetOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        UunDvxPYySImdQAj(descriptorProtos$MessageOptions);
        this.options_ = descriptorProtos$MessageOptions;
        this.bitField0_ |= 2;
    }

    private void SetReservedName(int i, java.lang.string str) {
        dCyehHPDrfmeeBrY(str);
        MyeWpjzcfNIQUdae(this);
        VhMuWoIcYxknSIPc(this.reservedName_, i, str);
    }

    private void SetReservedRange(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange descriptorProtos$DescriptorProto$ReservedRange) {
        BXgOsImAVzfkyRHO(descriptorProtos$DescriptorProto$ReservedRange);
        okVYfpbLaJkbrVOc(this);
        uzDKjDEjRNIlYEJp(this.reservedRange_, i, descriptorProtos$DescriptorProto$ReservedRange);
    }

    public static void SphDRFvdMSiRATHZ(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static androidx.datastore.preferences.protobuf.bytestring SrXMKXIJrwOlmaKu(java.lang.string str) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(str);
    }

    public static void SsDFYozfUXRAQIVS(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static int TaBTXlzIAaUnwsKs(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static void TnyRRHozRdyXkWIg(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$DescriptorProto.addAllOneofDecl(iterable);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto tzzCsuaYkLAcrxIi() {
        return getDefaultInstance();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList uRqGPOYNgmtumkGm() {
        return emptyProtobufList();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList ubdXnggAHQHqLSaA() {
        return emptyProtobufList();
    }

    public static java.lang.object UzDKjDEjRNIlYEJp(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder vChpSnlLiuhBXAxM(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions$Builder descriptorProtos$MessageOptions$Builder, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        return descriptorProtos$MessageOptions$Builder.mergeFrom(generatedMessageLite);
    }

    public static java.lang.Class VDujjHklDVUHyVnr(java.lang.object obj) {
        return obj.GetType();
    }

    public static void VQWjOaYAYJbptNwU(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureOneofDeclIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList vbMzTAHROvgxvwxf() {
        return emptyProtobufList();
    }

    public static void VfyYeoKsFHqnQJQk(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange descriptorProtos$DescriptorProto$ReservedRange) {
        descriptorProtos$DescriptorProto.addReservedRange(descriptorProtos$DescriptorProto$ReservedRange);
    }

    public static void VhfDWlUNaZbVMemL(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureEnumTypeIsMutable();
    }

    public static java.lang.object WSGSqLlIpHMNwqFx(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static java.lang.object WWtWjYyDruCqsXRW(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static void WbfAFUyrRBsfXvbJ(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange descriptorProtos$DescriptorProto$ExtensionRange) {
        descriptorProtos$DescriptorProto.addExtensionRange(descriptorProtos$DescriptorProto$ExtensionRange);
    }

    public static java.lang.Class XGGOljhIcItShxdc(java.lang.object obj) {
        return obj.GetType();
    }

    public static void XVFuPTCMCElsbakt(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static void XYvgxodoFTsrnbkC(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureReservedNameIsMutable();
    }

    public static void XiYyZgoEQhXMeLYv(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto, int i) {
        descriptorProtos$DescriptorProto.removeNestedType(i);
    }

    public static void YCDXmIbKFgtDLnEN(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureNestedTypeIsMutable();
    }

    public static bool YzFaAEzZBmuMnXrS(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static bool ZeugMUPidSmJBqDe(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static void ZhAEbnwQEUWzjmod(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.ensureOneofDeclIsMutable();
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((16 + 13) % 13 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[IVAisVvhYHKMzDtx(generatedMessageLite$MethodToInvoke)]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$Builder(null);
            case 3:
                return qTjUHcrQwYBEptwS(DEFAULT_INSTANCE, "\u0001\n\u0000\u0001\u0001\n\n\u0000\b\u0007\u0001ဈ\u0000\u0002Л\u0003Л\u0004Л\u0005Л\u0006Л\u0007ᐉ\u0001\bЛ\t\u001b\n\u001a", new java.lang.object[]{"bitField0_", "name_", "field_", androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto.class, "nestedType_", androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto.class, "enumType_", androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto.class, "extensionRange_", androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange.class, "extension_", androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto.class, "options_", "oneofDecl_", androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto.class, "reservedRange_", androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange.class, "reservedName_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto.class) {
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
                return WSMamXURSdEYsGSw(this.memoizedIsInitialized);
            case 7:
                this.memoizedIsInitialized = (byte) (obj is not null ? 1 : 0);
                return null;
            default:
                throw new java.lang.UnsupportedOperationException();
        }
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto getEnumType(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto) NvGRuaAhvXDpPGPQ(this.enumType_, i);
    }

    public override int GetEnumTypeCount() {
        return FjTUnWWgmqZqcQsR(this.enumType_);
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto> getEnumTypeList() {
        return this.enumType_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProtoOrBuilder getEnumTypeOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProtoOrBuilder) GLyfWvzgtykkdvOn(this.enumType_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProtoOrBuilder> getEnumTypeOrBuilderList() {
        return this.enumType_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto getExtension(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) wWtWjYyDruCqsXRW(this.extension_, i);
    }

    public override int GetExtensionCount() {
        return taBTXlzIAaUnwsKs(this.extension_);
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> getExtensionList() {
        return this.extension_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProtoOrBuilder getExtensionOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProtoOrBuilder) FmgYDRGtjFLOGfUa(this.extension_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProtoOrBuilder> getExtensionOrBuilderList() {
        return this.extension_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange getExtensionRange(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange) wSGSqLlIpHMNwqFx(this.extensionRange_, i);
    }

    public override int GetExtensionRangeCount() {
        return ceAPNvONAgfOeZen(this.extensionRange_);
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRange> getExtensionRangeList() {
        return this.extensionRange_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRangeOrBuilder getExtensionRangeOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRangeOrBuilder) bhdkxxPQBepTIJgR(this.extensionRange_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ExtensionRangeOrBuilder> getExtensionRangeOrBuilderList() {
        return this.extensionRange_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto getField(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) RIJXfqxyqDEuEDjD(this.field_, i);
    }

    public override int GetFieldCount() {
        return YUjXNyUmVQJuknzH(this.field_);
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> getFieldList() {
        return this.field_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProtoOrBuilder getFieldOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProtoOrBuilder) bjeKFddwVMhyUQpJ(this.field_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProtoOrBuilder> getFieldOrBuilderList() {
        return this.field_;
    }

    public override java.lang.string GetName() {
        return this.name_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return MzKIPZoGrJOdpbPP(this.name_);
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto getNestedType(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto) rYzEyxlIRwrzObhZ(this.nestedType_, i);
    }

    public override int GetNestedTypeCount() {
        return MjyyxPHahzEfergF(this.nestedType_);
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto> getNestedTypeList() {
        return this.nestedType_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProtoOrBuilder getNestedTypeOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProtoOrBuilder) gcJguaxgbSGFtfNr(this.nestedType_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProtoOrBuilder> getNestedTypeOrBuilderList() {
        return this.nestedType_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto getOneofDecl(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) QDWWppBgSuOkVKsu(this.oneofDecl_, i);
    }

    public override int GetOneofDeclCount() {
        return cwdstyxoAjodNdoa(this.oneofDecl_);
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto> getOneofDeclList() {
        return this.oneofDecl_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProtoOrBuilder getOneofDeclOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProtoOrBuilder) oKyZsxgiOTyEkwOV(this.oneofDecl_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProtoOrBuilder> getOneofDeclOrBuilderList() {
        return this.oneofDecl_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions getOptions() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions = this.options_;
        return descriptorProtos$MessageOptions is not null ? descriptorProtos$MessageOptions : DOoLMSITnHqQBWJu();
    }

    public override java.lang.string GetReservedName(int i) {
        return (java.lang.string) HopOTygIajocnssc(this.reservedName_, i);
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetReservedNamebytes(int i) {
        return srXMKXIJrwOlmaKu((java.lang.string) QqGuJqdCUXTezeLx(this.reservedName_, i));
    }

    public override int GetReservedNameCount() {
        return rAMlzarJZKKABNgX(this.reservedName_);
    }

    public override java.util.List<java.lang.string> GetReservedNameList() {
        return this.reservedName_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange getReservedRange(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange) SqrVepqcurfVduPi(this.reservedRange_, i);
    }

    public override int GetReservedRangeCount() {
        return pkAGbhYoegLwGqym(this.reservedRange_);
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRange> getReservedRangeList() {
        return this.reservedRange_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRangeOrBuilder getReservedRangeOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRangeOrBuilder) ZovslyCHWeqgFJgm(this.reservedRange_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto$ReservedRangeOrBuilder> getReservedRangeOrBuilderList() {
        return this.reservedRange_;
    }

    public override bool HasName() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasOptions() {
        return (this.bitField0_ & 2) != 0;
    }
}

