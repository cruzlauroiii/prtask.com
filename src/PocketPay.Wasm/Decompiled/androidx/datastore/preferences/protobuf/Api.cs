namespace WillowMaze.Wasm.Decompiled;


public readonly class Api : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.Api, androidx.datastore.preferences.protobuf.Api$Builder> : androidx.datastore.preferences.protobuf.ApiOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.Api DEFAULT_INSTANCE;
    public static readonly int METHODS_FIELD_NUMBER = 2;
    public static readonly int MIXINS_FIELD_NUMBER = 6;
    public static readonly int NAME_FIELD_NUMBER = 1;
    public static readonly int OPTIONS_FIELD_NUMBER = 3;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Api> PARSER = null;
    public static readonly int SOURCE_CONTEXT_FIELD_NUMBER = 5;
    public static readonly int SYNTAX_FIELD_NUMBER = 7;
    public static readonly int VERSION_FIELD_NUMBER = 4;
    private int bitField0_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Method> methods_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Mixin> mixins_;
    private java.lang.string name_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Option> options_;
    private androidx.datastore.preferences.protobuf.Sourceobject sourceobject_;
    private int syntax_;
    private java.lang.string version_;

    static {
        if ((26 + 15) % 15 > 0) {
        }
        androidx.datastore.preferences.protobuf.Api api = new androidx.datastore.preferences.protobuf.Api();
        DEFAULT_INSTANCE = api;
        qyEWiniTzyBMxvOL(androidx.datastore.preferences.protobuf.Api.class, api);
    }

    private Api() {
        if ((27 + 1) % 1 > 0) {
        }
        this.name_ = "";
        this.methods_ = bIuZQHAeKiJtiiPx();
        this.options_ = mVpWqKDzwviHtLZa();
        this.version_ = "";
        this.mixins_ = zFJnhDDTIpYNUvJZ();
    }

    public static void AqIjkJOpyypsdlAL(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.Method method) {
        api.addMethods(method);
    }

    public static androidx.datastore.preferences.protobuf.Syntax AzUpeYjVDFzVdeQX(int i) {
        return androidx.datastore.preferences.protobuf.Syntax.forNumber(i);
    }

    public static void BOCYjBehYAFGKfFV(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite BkVFlfOjSEzcbRuA(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject$Builder ByMiqMbzbxzcenCp(androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        return androidx.datastore.preferences.protobuf.Sourceobject.newBuilder(sourceobject);
    }

    public static void BzLMGmzhvqKCgoFE(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureOptionsIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList CIYhytTiownWCJBE(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static java.lang.Class CIdvdegtbvgcKpBt(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.Api CqWvHebXVXWIALaK() {
        return getDefaultInstance();
    }

    public static void DEEOQgivBZJdqYbs(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureMethodsIsMutable();
    }

    public static bool DUDVbVDAiGsKeJpY(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static java.lang.object EMBCPqCCjmSwEgQG(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static androidx.datastore.preferences.protobuf.bytestring EVlyxYWpiwDWYZYC(java.lang.string str) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(str);
    }

    public static java.lang.object EbIcovPjxODoMZro(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static void EuBqYykIsqzVFjSI(androidx.datastore.preferences.protobuf.Api api, java.lang.string str) {
        api.setVersion(str);
    }

    public static void FZfduKjfypEQCEEd(androidx.datastore.preferences.protobuf.Api api, int i) {
        api.removeMethods(i);
    }

    public static void GEDhAymBEUlVJNdH(androidx.datastore.preferences.protobuf.Api api, int i) {
        api.removeOptions(i);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite GORDNpaKFgoOUNHQ(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, byte[] bArr) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bArr);
    }

    public static void GZwReqzDFdHakHxy(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureMixinsIsMutable();
    }

    public static void GoChdOXjpoqghEQl(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureMixinsIsMutable();
    }

    public static bool HNUulCJhtWNEjzTF(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static java.lang.string IxbnhpvryKqGZFgf(androidx.datastore.preferences.protobuf.Api api) {
        return api.getVersion();
    }

    public static java.lang.object JPNCwkvPeVPyasUw(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static java.lang.object JTdzZeGvTozvikXY(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static java.lang.object JcGxcbyBLkStDceH(androidx.datastore.preferences.protobuf.MessageLite messageLite, java.lang.string str, java.lang.object[] objArr) {
        return newMessageInfo(messageLite, str, objArr);
    }

    public static void JtwfXfUJYTVRRGnX(androidx.datastore.preferences.protobuf.Api api) {
        api.clearSourceobject();
    }

    public static void JuVuCysNJwZumgQZ(androidx.datastore.preferences.protobuf.Api api, int i, androidx.datastore.preferences.protobuf.Method method) {
        api.setMethods(i, method);
    }

    public static bool KASUwwlSJMUnrcRG(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static void KUMdMBEEBgkUpOWK(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
    }

    public static java.lang.Class KYSbRfROapFssAEu(java.lang.object obj) {
        return obj.GetType();
    }

    public static void KuXBsbIDLqQkcxbF(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite LeZFzdMFHeHOHyRb(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, codedStream, extensionRegistryLite);
    }

    public static java.lang.object MLusxpEKlHAyccZT(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static int MOpvIKZtpAtIswKo(androidx.datastore.preferences.protobuf.Syntax syntax) {
        return syntax.getNumber();
    }

    public static java.lang.object MhtCsuRWwngSopeb(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static void MtKsuzMhnCUmRcKz(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static void NlUNsznSQhypKemU(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.Mixin mixin) {
        api.addMixins(mixin);
    }

    public static void NsAGaImhQhrLKpGi(androidx.datastore.preferences.protobuf.Api api, int i, androidx.datastore.preferences.protobuf.Method method) {
        api.addMethods(i, method);
    }

    public static void OFxSVhBKkFhHBulH(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    public static void OIRIHZnLRwInZjVp(androidx.datastore.preferences.protobuf.Api api) {
        api.clearOptions();
    }

    public static void OQcJZpDRBWJLMeQZ(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        api.setSourceobject(sourceobject);
    }

    public static java.lang.Class OUKVhEbutNNTxRVb(java.lang.object obj) {
        return obj.GetType();
    }

    public static void OYhFmRktUjioXBni(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        api.mergeSourceobject(sourceobject);
    }

    public static int RbuWVqfqcxNwLQzx(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite RumyLQokdMGxrcOU(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream) {
        return parseDelimitedFrom(generatedMessageLite, inputStream);
    }

    public static void SLdqVmxpdElegMGg(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureMethodsIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder SicanLljqbZslfki(androidx.datastore.preferences.protobuf.Api api) {
        return api.createBuilder();
    }

    public static void SjNdiHPDfPZFluaW(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureMethodsIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite SmWAUWsZgkuHARxL(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, codedStream);
    }

    public static java.lang.object TWgZTNvCETYMHqrc(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static bool UIJUrAogUyMhpFmx(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static void UTGGlyCHwEETciZD(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureOptionsIsMutable();
    }

    public static void UbZQiOvVVUEotqoR(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureMixinsIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite UirLWkqZPoIwtVzI(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, inputStream);
    }

    public static int UueLHmOJJlXtzFlC(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke) {
        return generatedMessageLite$MethodToInvoke.ordinal();
    }

    public static bool VYQuHnlbAqfrBqAs(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static java.lang.Class VafGevfqOMdpwEKV(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject VoykXRxNFUrwoCts() {
        return androidx.datastore.preferences.protobuf.Sourceobject.getDefaultInstance();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList VtHMEJTCoYlmDfkZ() {
        return emptyProtobufList();
    }

    public static void VyqNeiELAggWGChX(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureMethodsIsMutable();
    }

    public static void WXHuJgOpxeSPEiLa(androidx.datastore.preferences.protobuf.Api api, java.lang.IEnumerable iterable) {
        api.addAllMixins(iterable);
    }

    public static void WfYrVTMKwNGMhKtb(androidx.datastore.preferences.protobuf.Api api, int i) {
        api.setSyntaxValue(i);
    }

    public static java.lang.object WfZkXGzcsljDmiJb(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static java.lang.byte XAHxnwllEawqGbxg(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject XVQvdWXJXmQhTtUA() {
        return androidx.datastore.preferences.protobuf.Sourceobject.getDefaultInstance();
    }

    public static void YCkSXJpAlJdYOMIw(androidx.datastore.preferences.protobuf.Api api, java.lang.IEnumerable iterable) {
        api.addAllOptions(iterable);
    }

    public static void YaQXWBZWMtGtwmZR(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    public static void YnFijIqZElVXxupl(androidx.datastore.preferences.protobuf.Api api, int i, androidx.datastore.preferences.protobuf.Option option) {
        api.addOptions(i, option);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite YqUzxxIbZckIUhDm(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bytestring, extensionRegistryLite);
    }

    public static java.lang.Class ZAIylsuvyNEQhoHK(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string ZKaZIUeQroHfmSHS(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.tostringUtf8();
    }

    public static java.lang.Class ZhmWoiLrvHKCciGN(java.lang.object obj) {
        return obj.GetType();
    }

    public static void AObyEyowZBgakSMZ(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.Option option) {
        api.addOptions(option);
    }

    public static java.lang.string AasovzlWUJBVbFZW(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.tostringUtf8();
    }

    static androidx.datastore.preferences.protobuf.Api access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.Api api, java.lang.string str) {
        qiZPcTSSuOGUrJDq(api, str);
    }

    static void access$1000(androidx.datastore.preferences.protobuf.Api api, int i, androidx.datastore.preferences.protobuf.Option option) {
        bkljetlHxtFdJLkY(api, i, option);
    }

    static void access$1100(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.Option option) {
        aObyEyowZBgakSMZ(api, option);
    }

    static void access$1200(androidx.datastore.preferences.protobuf.Api api, int i, androidx.datastore.preferences.protobuf.Option option) {
        YnFijIqZElVXxupl(api, i, option);
    }

    static void access$1300(androidx.datastore.preferences.protobuf.Api api, java.lang.IEnumerable iterable) {
        YCkSXJpAlJdYOMIw(api, iterable);
    }

    static void access$1400(androidx.datastore.preferences.protobuf.Api api) {
        OIRIHZnLRwInZjVp(api);
    }

    static void access$1500(androidx.datastore.preferences.protobuf.Api api, int i) {
        GEDhAymBEUlVJNdH(api, i);
    }

    static void access$1600(androidx.datastore.preferences.protobuf.Api api, java.lang.string str) {
        EuBqYykIsqzVFjSI(api, str);
    }

    static void access$1700(androidx.datastore.preferences.protobuf.Api api) {
        eqgDoarXRMCrcVPd(api);
    }

    static void access$1800(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        jKmvVoZOPvBqzjes(api, bytestring);
    }

    static void access$1900(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        OQcJZpDRBWJLMeQZ(api, sourceobject);
    }

    static void access$200(androidx.datastore.preferences.protobuf.Api api) {
        gzsAagUQapmgkswm(api);
    }

    static void access$2000(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        OYhFmRktUjioXBni(api, sourceobject);
    }

    static void access$2100(androidx.datastore.preferences.protobuf.Api api) {
        JtwfXfUJYTVRRGnX(api);
    }

    static void access$2200(androidx.datastore.preferences.protobuf.Api api, int i, androidx.datastore.preferences.protobuf.Mixin mixin) {
        cRWjDSHVvHLlQKwq(api, i, mixin);
    }

    static void access$2300(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.Mixin mixin) {
        NlUNsznSQhypKemU(api, mixin);
    }

    static void access$2400(androidx.datastore.preferences.protobuf.Api api, int i, androidx.datastore.preferences.protobuf.Mixin mixin) {
        pUbYMoiYWmgUkBUa(api, i, mixin);
    }

    static void access$2500(androidx.datastore.preferences.protobuf.Api api, java.lang.IEnumerable iterable) {
        WXHuJgOpxeSPEiLa(api, iterable);
    }

    static void access$2600(androidx.datastore.preferences.protobuf.Api api) {
        wVLIPejJPJxRmlKe(api);
    }

    static void access$2700(androidx.datastore.preferences.protobuf.Api api, int i) {
        krcdvbSBDxaqcHLN(api, i);
    }

    static void access$2800(androidx.datastore.preferences.protobuf.Api api, int i) {
        WfYrVTMKwNGMhKtb(api, i);
    }

    static void access$2900(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.Syntax syntax) {
        usVJynFNuVvqduaI(api, syntax);
    }

    static void access$300(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        kPiVOPiaqRbNELKh(api, bytestring);
    }

    static void access$3000(androidx.datastore.preferences.protobuf.Api api) {
        uMhkVlYEdXaKZjPh(api);
    }

    static void access$400(androidx.datastore.preferences.protobuf.Api api, int i, androidx.datastore.preferences.protobuf.Method method) {
        JuVuCysNJwZumgQZ(api, i, method);
    }

    static void access$500(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.Method method) {
        AqIjkJOpyypsdlAL(api, method);
    }

    static void access$600(androidx.datastore.preferences.protobuf.Api api, int i, androidx.datastore.preferences.protobuf.Method method) {
        NsAGaImhQhrLKpGi(api, i, method);
    }

    static void access$700(androidx.datastore.preferences.protobuf.Api api, java.lang.IEnumerable iterable) {
        lzYtUmgsvqFhlRfD(api, iterable);
    }

    static void access$800(androidx.datastore.preferences.protobuf.Api api) {
        nGfdAqIDOtWblirn(api);
    }

    static void access$900(androidx.datastore.preferences.protobuf.Api api, int i) {
        FZfduKjfypEQCEEd(api, i);
    }

    private void AddAllMethods(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Method> iterable) {
        ysjzlknJVoUmIood(this);
        KuXBsbIDLqQkcxbF(iterable, this.methods_);
    }

    private void AddAllMixins(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Mixin> iterable) {
        kOIBsEYtvJIlrbwE(this);
        fjPoDgnqfAbKQcFk(iterable, this.mixins_);
    }

    private void AddAllOptions(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Option> iterable) {
        oGzQTqGZasABpvoq(this);
        MtKsuzMhnCUmRcKz(iterable, this.options_);
    }

    private void AddMethods(int i, androidx.datastore.preferences.protobuf.Method method) {
        fBwyqWSKSCdzEEOk(method);
        SLdqVmxpdElegMGg(this);
        OFxSVhBKkFhHBulH(this.methods_, i, method);
    }

    private void AddMethods(androidx.datastore.preferences.protobuf.Method method) {
        kVXwrRCAPXfFJhnT(method);
        DEEOQgivBZJdqYbs(this);
        DUDVbVDAiGsKeJpY(this.methods_, method);
    }

    private void AddMixins(int i, androidx.datastore.preferences.protobuf.Mixin mixin) {
        VafGevfqOMdpwEKV(mixin);
        UbZQiOvVVUEotqoR(this);
        lQSHYEihgtyiPJSw(this.mixins_, i, mixin);
    }

    private void AddMixins(androidx.datastore.preferences.protobuf.Mixin mixin) {
        pxjLBPsmGeLiZKMf(mixin);
        GoChdOXjpoqghEQl(this);
        KASUwwlSJMUnrcRG(this.mixins_, mixin);
    }

    private void AddOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        CIdvdegtbvgcKpBt(option);
        vLNxMmKjdCBTNGsu(this);
        YaQXWBZWMtGtwmZR(this.options_, i, option);
    }

    private void AddOptions(androidx.datastore.preferences.protobuf.Option option) {
        ZhmWoiLrvHKCciGN(option);
        BzLMGmzhvqKCgoFE(this);
        UIJUrAogUyMhpFmx(this.options_, option);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite BHbfucmoiHRbbzHc(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList bIuZQHAeKiJtiiPx() {
        return emptyProtobufList();
    }

    public static void BkljetlHxtFdJLkY(androidx.datastore.preferences.protobuf.Api api, int i, androidx.datastore.preferences.protobuf.Option option) {
        api.setOptions(i, option);
    }

    public static java.lang.Class BlglIDTdEAfYTzDf(java.lang.object obj) {
        return obj.GetType();
    }

    public static void CRWjDSHVvHLlQKwq(androidx.datastore.preferences.protobuf.Api api, int i, androidx.datastore.preferences.protobuf.Mixin mixin) {
        api.setMixins(i, mixin);
    }

    private void ClearMethods() {
        this.methods_ = kqfIgBXkSvxdTEuG();
    }

    private void ClearMixins() {
        this.mixins_ = VtHMEJTCoYlmDfkZ();
    }

    private void ClearName() {
        this.name_ = sFOASOnVvnvZTMMj(CqWvHebXVXWIALaK());
    }

    private void ClearOptions() {
        this.options_ = mvyhXLGGAfrJNLYm();
    }

    private void ClearSourceobject() {
        this.sourceobject_ = null;
        this.bitField0_ &= -2;
    }

    private void ClearSyntax() {
        this.syntax_ = 0;
    }

    private void ClearVersion() {
        this.version_ = IxbnhpvryKqGZFgf(dJidpAvrsBxtlGzH());
    }

    public static androidx.datastore.preferences.protobuf.Api DJidpAvrsBxtlGzH() {
        return getDefaultInstance();
    }

    public static java.lang.object DnLorIuozryBAlLE(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    private void EnsureMethodsIsMutable() {
        if ((19 + 23) % 23 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Method> internal$ProtobufList = this.methods_;
        if (VYQuHnlbAqfrBqAs(internal$ProtobufList)) {
            return;
        }
        this.methods_ = CIYhytTiownWCJBE(internal$ProtobufList);
    }

    private void EnsureMixinsIsMutable() {
        if ((17 + 20) % 20 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Mixin> internal$ProtobufList = this.mixins_;
        if (HNUulCJhtWNEjzTF(internal$ProtobufList)) {
            return;
        }
        this.mixins_ = tKTjkGxEcvIunMbD(internal$ProtobufList);
    }

    private void EnsureOptionsIsMutable() {
        if ((1 + 26) % 26 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Option> internal$ProtobufList = this.options_;
        if (upmVczdhOlkGqbcU(internal$ProtobufList)) {
            return;
        }
        this.options_ = ypfltPDAsuYQVHCY(internal$ProtobufList);
    }

    public static void EqgDoarXRMCrcVPd(androidx.datastore.preferences.protobuf.Api api) {
        api.clearVersion();
    }

    public static java.lang.Class FBwyqWSKSCdzEEOk(java.lang.object obj) {
        return obj.GetType();
    }

    public static void FjPoDgnqfAbKQcFk(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static androidx.datastore.preferences.protobuf.Parser FznDracXuzQQDqWk(androidx.datastore.preferences.protobuf.Api api) {
        return api.getParserForType();
    }

    public static androidx.datastore.preferences.protobuf.Api GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static java.lang.object GrfuuOIrHodCLQWt(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static void GzsAagUQapmgkswm(androidx.datastore.preferences.protobuf.Api api) {
        api.clearName();
    }

    public static java.lang.object IvFInOAHCxkEYdGM(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static void JKmvVoZOPvBqzjes(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        api.setVersionbytes(bytestring);
    }

    public static void KOIBsEYtvJIlrbwE(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureMixinsIsMutable();
    }

    public static void KPiVOPiaqRbNELKh(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        api.setNamebytes(bytestring);
    }

    public static java.lang.Class KVXwrRCAPXfFJhnT(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList kqfIgBXkSvxdTEuG() {
        return emptyProtobufList();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite KrXeKGGwstAUAliY(androidx.datastore.preferences.protobuf.Sourceobject$Builder sourceobject$Builder) {
        return sourceobject$Builder.buildPartial();
    }

    public static void KrcdvbSBDxaqcHLN(androidx.datastore.preferences.protobuf.Api api, int i) {
        api.removeMixins(i);
    }

    public static void LQSHYEihgtyiPJSw(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    public static void LoGtlDMlaiQVSikH(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureOptionsIsMutable();
    }

    public static void LzYtUmgsvqFhlRfD(androidx.datastore.preferences.protobuf.Api api, java.lang.IEnumerable iterable) {
        api.addAllMethods(iterable);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList mVpWqKDzwviHtLZa() {
        return emptyProtobufList();
    }

    public static int MYrKQoRTJXUVjiQL(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    private void MergeSourceobject(androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        if ((26 + 25) % 25 > 0) {
        }
        vIEaFkPCJszKZfRM(sourceobject);
        androidx.datastore.preferences.protobuf.Sourceobject sourceobject2 = this.sourceobject_;
        if (sourceobject2 is null || sourceobject2 == VoykXRxNFUrwoCts()) {
            this.sourceobject_ = sourceobject;
        } else {
            this.sourceobject_ = (androidx.datastore.preferences.protobuf.Sourceobject) krXeKGGwstAUAliY((androidx.datastore.preferences.protobuf.Sourceobject$Builder) pxQTNjsIkQhXTkxG(ByMiqMbzbxzcenCp(this.sourceobject_), sourceobject));
        }
        this.bitField0_ |= 1;
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList mvyhXLGGAfrJNLYm() {
        return emptyProtobufList();
    }

    public static void NGfdAqIDOtWblirn(androidx.datastore.preferences.protobuf.Api api) {
        api.clearMethods();
    }

    public static androidx.datastore.preferences.protobuf.Api$Builder newBuilder() {
        return (androidx.datastore.preferences.protobuf.Api$Builder) SicanLljqbZslfki(DEFAULT_INSTANCE);
    }

    public static androidx.datastore.preferences.protobuf.Api$Builder newBuilder(androidx.datastore.preferences.protobuf.Api api) {
        return (androidx.datastore.preferences.protobuf.Api$Builder) onoQDasUDAKLpYbC(DEFAULT_INSTANCE, api);
    }

    public static void OGzQTqGZasABpvoq(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureOptionsIsMutable();
    }

    public static void OVUccNEzBJWsNhQI(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureMixinsIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder onoQDasUDAKLpYbC(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        return api.createBuilder(generatedMessageLite);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite PCBAXtBYQneBOQVq(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bArr, extensionRegistryLite);
    }

    public static void PUbYMoiYWmgUkBUa(androidx.datastore.preferences.protobuf.Api api, int i, androidx.datastore.preferences.protobuf.Mixin mixin) {
        api.addMixins(i, mixin);
    }

    public static androidx.datastore.preferences.protobuf.Api ParseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Api) RumyLQokdMGxrcOU(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Api ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Api) ytYgciYPBGyterNj(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Api ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Api) sJkRoRHWIJXXerDz(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.Api ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Api) YqUzxxIbZckIUhDm(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Api ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Api) SmWAUWsZgkuHARxL(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.Api ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Api) LeZFzdMFHeHOHyRb(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Api ParseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Api) UirLWkqZPoIwtVzI(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Api ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Api) wyEbdfMLPnVBvCJx(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Api ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Api) bHbfucmoiHRbbzHc(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.Api ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Api) BkVFlfOjSEzcbRuA(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Api ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Api) GORDNpaKFgoOUNHQ(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.Api ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Api) pCBAXtBYQneBOQVq(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Api> Parser() {
        return fznDracXuzQQDqWk(DEFAULT_INSTANCE);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder pxQTNjsIkQhXTkxG(androidx.datastore.preferences.protobuf.Sourceobject$Builder sourceobject$Builder, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        return sourceobject$Builder.mergeFrom(generatedMessageLite);
    }

    public static java.lang.Class PxjLBPsmGeLiZKMf(java.lang.object obj) {
        return obj.GetType();
    }

    public static void QiZPcTSSuOGUrJDq(androidx.datastore.preferences.protobuf.Api api, java.lang.string str) {
        api.setName(str);
    }

    public static void QyEWiniTzyBMxvOL(java.lang.Class cls, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(cls, generatedMessageLite);
    }

    private void RemoveMethods(int i) {
        SjNdiHPDfPZFluaW(this);
        TWgZTNvCETYMHqrc(this.methods_, i);
    }

    private void RemoveMixins(int i) {
        GZwReqzDFdHakHxy(this);
        MLusxpEKlHAyccZT(this.mixins_, i);
    }

    private void RemoveOptions(int i) {
        loGtlDMlaiQVSikH(this);
        EbIcovPjxODoMZro(this.options_, i);
    }

    public static java.lang.Class SBKBCWtFHCvvnnqP(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.Class SCesIezWCasnnRqv(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string SFOASOnVvnvZTMMj(androidx.datastore.preferences.protobuf.Api api) {
        return api.getName();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite SJkRoRHWIJXXerDz(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bytestring);
    }

    private void SetMethods(int i, androidx.datastore.preferences.protobuf.Method method) {
        sBKBCWtFHCvvnnqP(method);
        VyqNeiELAggWGChX(this);
        WfZkXGzcsljDmiJb(this.methods_, i, method);
    }

    private void SetMixins(int i, androidx.datastore.preferences.protobuf.Mixin mixin) {
        blglIDTdEAfYTzDf(mixin);
        oVUccNEzBJWsNhQI(this);
        MhtCsuRWwngSopeb(this.mixins_, i, mixin);
    }

    private void SetName(java.lang.string str) {
        sCesIezWCasnnRqv(str);
        this.name_ = str;
    }

    private void SetNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        BOCYjBehYAFGKfFV(bytestring);
        this.name_ = aasovzlWUJBVbFZW(bytestring);
    }

    private void SetOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        ZAIylsuvyNEQhoHK(option);
        UTGGlyCHwEETciZD(this);
        ivFInOAHCxkEYdGM(this.options_, i, option);
    }

    private void SetSourceobject(androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        OUKVhEbutNNTxRVb(sourceobject);
        this.sourceobject_ = sourceobject;
        this.bitField0_ |= 1;
    }

    private void SetSyntax(androidx.datastore.preferences.protobuf.Syntax syntax) {
        this.syntax_ = MOpvIKZtpAtIswKo(syntax);
    }

    private void SetSyntaxValue(int i) {
        this.syntax_ = i;
    }

    private void SetVersion(java.lang.string str) {
        KYSbRfROapFssAEu(str);
        this.version_ = str;
    }

    private void SetVersionbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        KUMdMBEEBgkUpOWK(bytestring);
        this.version_ = ZKaZIUeQroHfmSHS(bytestring);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList tKTjkGxEcvIunMbD(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static void UMhkVlYEdXaKZjPh(androidx.datastore.preferences.protobuf.Api api) {
        api.clearSyntax();
    }

    public static bool UpmVczdhOlkGqbcU(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static void UsVJynFNuVvqduaI(androidx.datastore.preferences.protobuf.Api api, androidx.datastore.preferences.protobuf.Syntax syntax) {
        api.setSyntax(syntax);
    }

    public static java.lang.object UwIfqLFzoFfbHqnm(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static java.lang.Class VIEaFkPCJszKZfRM(java.lang.object obj) {
        return obj.GetType();
    }

    public static void VLNxMmKjdCBTNGsu(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureOptionsIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.bytestring WHcsmhnXUUruwgVX(java.lang.string str) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(str);
    }

    public static void WVLIPejJPJxRmlKe(androidx.datastore.preferences.protobuf.Api api) {
        api.clearMixins();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite WyEbdfMLPnVBvCJx(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, inputStream, extensionRegistryLite);
    }

    public static int XIdNzkSaWqTEmVKx(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList ypfltPDAsuYQVHCY(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static void YsjzlknJVoUmIood(androidx.datastore.preferences.protobuf.Api api) {
        api.ensureMethodsIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite YtYgciYPBGyterNj(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return parseDelimitedFrom(generatedMessageLite, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList zFJnhDDTIpYNUvJZ() {
        return emptyProtobufList();
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((20 + 30) % 30 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.Api$1.f16xa1df5c61[UueLHmOJJlXtzFlC(generatedMessageLite$MethodToInvoke)]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.Api();
            case 2:
                return new androidx.datastore.preferences.protobuf.Api$Builder(null);
            case 3:
                return JcGxcbyBLkStDceH(DEFAULT_INSTANCE, "\u0000\u0007\u0000\u0001\u0001\u0007\u0007\u0000\u0003\u0000\u0001Ȉ\u0002\u001b\u0003\u001b\u0004Ȉ\u0005ဉ\u0000\u0006\u001b\u0007\f", new java.lang.object[]{"bitField0_", "name_", "methods_", androidx.datastore.preferences.protobuf.Method.class, "options_", androidx.datastore.preferences.protobuf.Option.class, "version_", "sourceobject_", "mixins_", androidx.datastore.preferences.protobuf.Mixin.class, "syntax_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Api> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.Api.class) {
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
                return XAHxnwllEawqGbxg((byte) 1);
            case 7:
                return null;
            default:
                throw new java.lang.UnsupportedOperationException();
        }
    }

    public override androidx.datastore.preferences.protobuf.Method GetMethods(int i) {
        return (androidx.datastore.preferences.protobuf.Method) JTdzZeGvTozvikXY(this.methods_, i);
    }

    public override int GetMethodsCount() {
        return RbuWVqfqcxNwLQzx(this.methods_);
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.Method> GetMethodsList() {
        return this.methods_;
    }

    public androidx.datastore.preferences.protobuf.MethodOrBuilder GetMethodsOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.MethodOrBuilder) dnLorIuozryBAlLE(this.methods_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.MethodOrBuilder> getMethodsOrBuilderList() {
        return this.methods_;
    }

    public override androidx.datastore.preferences.protobuf.Mixin GetMixins(int i) {
        return (androidx.datastore.preferences.protobuf.Mixin) EMBCPqCCjmSwEgQG(this.mixins_, i);
    }

    public override int GetMixinsCount() {
        return xIdNzkSaWqTEmVKx(this.mixins_);
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.Mixin> GetMixinsList() {
        return this.mixins_;
    }

    public androidx.datastore.preferences.protobuf.MixinOrBuilder GetMixinsOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.MixinOrBuilder) grfuuOIrHodCLQWt(this.mixins_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.MixinOrBuilder> getMixinsOrBuilderList() {
        return this.mixins_;
    }

    public override java.lang.string GetName() {
        return this.name_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return EVlyxYWpiwDWYZYC(this.name_);
    }

    public override androidx.datastore.preferences.protobuf.Option GetOptions(int i) {
        return (androidx.datastore.preferences.protobuf.Option) uwIfqLFzoFfbHqnm(this.options_, i);
    }

    public override int GetOptionsCount() {
        return mYrKQoRTJXUVjiQL(this.options_);
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.Option> GetOptionsList() {
        return this.options_;
    }

    public androidx.datastore.preferences.protobuf.OptionOrBuilder GetOptionsOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.OptionOrBuilder) JPNCwkvPeVPyasUw(this.options_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.OptionOrBuilder> getOptionsOrBuilderList() {
        return this.options_;
    }

    public override androidx.datastore.preferences.protobuf.Sourceobject GetSourceobject() {
        androidx.datastore.preferences.protobuf.Sourceobject sourceobject = this.sourceobject_;
        return sourceobject is not null ? sourceobject : XVQvdWXJXmQhTtUA();
    }

    public override androidx.datastore.preferences.protobuf.Syntax GetSyntax() {
        androidx.datastore.preferences.protobuf.Syntax syntaxAzUpeYjVDFzVdeQX = AzUpeYjVDFzVdeQX(this.syntax_);
        return syntaxAzUpeYjVDFzVdeQX is not null ? syntaxAzUpeYjVDFzVdeQX : androidx.datastore.preferences.protobuf.Syntax.UNRECOGNIZED;
    }

    public override int GetSyntaxValue() {
        return this.syntax_;
    }

    public override java.lang.string GetVersion() {
        return this.version_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetVersionbytes() {
        return wHcsmhnXUUruwgVX(this.version_);
    }

    public override bool HasSourceobject() {
        return (this.bitField0_ & 1) != 0;
    }
}

