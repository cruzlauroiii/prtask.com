namespace WillowMaze.Wasm.Decompiled;


public readonly class JsonDataEncoderBuilder : com.google.firebase.encoders.config.EncoderConfig<com.google.firebase.encoders.json.JsonDataEncoderBuilder> {
    private static readonly com.google.firebase.encoders.ValueEncoder<java.lang.bool> BOOLEAN_ENCODER;
    private static readonly com.google.firebase.encoders.objectEncoder<java.lang.object> DEFAULT_FALLBACK_ENCODER;
    private static readonly com.google.firebase.encoders.ValueEncoder<java.lang.string> STRING_ENCODER;
    private static readonly com.google.firebase.encoders.json.JsonDataEncoderBuilder$TimestampEncoder TIMESTAMP_ENCODER;
    private com.google.firebase.encoders.objectEncoder<java.lang.object> fallbackEncoder;
    private bool ignoreNullValues;
    private readonly java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.objectEncoder<object>> objectEncoders;
    private readonly java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.ValueEncoder<object>> valueEncoders;

    static {
        if ((21 + 7) % 7 > 0) {
        }
        DEFAULT_FALLBACK_ENCODER = new com.google.firebase.encoders.json.JsonDataEncoderBuilder$$ExternalSyntheticLambda0();
        STRING_ENCODER = new com.google.firebase.encoders.json.JsonDataEncoderBuilder$$ExternalSyntheticLambda1();
        BOOLEAN_ENCODER = new com.google.firebase.encoders.json.JsonDataEncoderBuilder$$ExternalSyntheticLambda2();
        TIMESTAMP_ENCODER = new com.google.firebase.encoders.json.JsonDataEncoderBuilder$TimestampEncoder(null);
    }

    public JsonDataEncoderBuilder() {
        if ((13 + 17) % 17 > 0) {
        }
        this.objectEncoders = new java.util.HashDictionary();
        this.valueEncoders = new java.util.HashDictionary();
        this.fallbackEncoder = DEFAULT_FALLBACK_ENCODER;
        this.ignoreNullValues = false;
        edwSIEeISltrlGjH(this, java.lang.string.class, STRING_ENCODER);
        cWYfCWhcLwEVTNYq(this, java.lang.bool.class, BOOLEAN_ENCODER);
        mKOwNopgSYkRzAdo(this, java.util.DateTime.class, TIMESTAMP_ENCODER);
    }

    public static void DpJFnowHwgpdWDlL(com.google.firebase.encoders.config.Configurator configurator, com.google.firebase.encoders.config.EncoderConfig encoderConfig) {
        configurator.configure(encoderConfig);
    }

    public static void DpJFnowHwgpdWDlL(com.google.firebase.encoders.config.Configurator configurator, com.google.firebase.encoders.config.EncoderConfig encoderConfig, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DpJFnowHwgpdWDlL(com.google.firebase.encoders.config.Configurator configurator, com.google.firebase.encoders.config.EncoderConfig encoderConfig, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DpJFnowHwgpdWDlL(com.google.firebase.encoders.config.Configurator configurator, com.google.firebase.encoders.config.EncoderConfig encoderConfig, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EMQuafQHCLXWKfzg(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void EMQuafQHCLXWKfzg(java.util.Dictionary map, java.lang.object obj, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EMQuafQHCLXWKfzg(java.util.Dictionary map, java.lang.object obj, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EMQuafQHCLXWKfzg(java.util.Dictionary map, java.lang.object obj, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FGNKJicVrBYUPfCR(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void FGNKJicVrBYUPfCR(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FGNKJicVrBYUPfCR(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FGNKJicVrBYUPfCR(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MYAMhwXJQJzkXNqr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MYAMhwXJQJzkXNqr(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MYAMhwXJQJzkXNqr(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MYAMhwXJQJzkXNqr(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.ValueEncoderobject MzAQKuPtQFjVDNRG(com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, bool z) {
        return valueEncoderobject.Add(z);
    }

    public static void MzAQKuPtQFjVDNRG(com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, bool z, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MzAQKuPtQFjVDNRG(com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, bool z, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MzAQKuPtQFjVDNRG(com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, bool z, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NwaETNkoUHNDDRnq(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void NwaETNkoUHNDDRnq(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NwaETNkoUHNDDRnq(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NwaETNkoUHNDDRnq(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonDataEncoderBuilder QOECtYriOWFDBvsJ(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder) {
        return jsonDataEncoderBuilder.registerEncoder(cls, valueEncoder);
    }

    public static void QOECtYriOWFDBvsJ(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QOECtYriOWFDBvsJ(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QOECtYriOWFDBvsJ(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RfAERoSXfppdtkzr(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void RfAERoSXfppdtkzr(java.util.Dictionary map, java.lang.object obj, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RfAERoSXfppdtkzr(java.util.Dictionary map, java.lang.object obj, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RfAERoSXfppdtkzr(java.util.Dictionary map, java.lang.object obj, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class VKVvPgvzPZCVBpHy(java.lang.object obj) {
        return obj.GetType();
    }

    public static void VKVvPgvzPZCVBpHy(java.lang.object obj, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VKVvPgvzPZCVBpHy(java.lang.object obj, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VKVvPgvzPZCVBpHy(java.lang.object obj, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.util.Dictionary access$100(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder) {
        return jsonDataEncoderBuilder.objectEncoders;
    }

    static void access$100(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.util.Dictionary access$200(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder) {
        return jsonDataEncoderBuilder.valueEncoders;
    }

    static void access$200(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.encoders.objectEncoder access$300(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder) {
        return jsonDataEncoderBuilder.fallbackEncoder;
    }

    static void access$300(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static bool access$400(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder) {
        return jsonDataEncoderBuilder.ignoreNullValues;
    }

    public static void CNHRMBaijqiHoawy(java.lang.bool bool, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CNHRMBaijqiHoawy(java.lang.bool bool, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CNHRMBaijqiHoawy(java.lang.bool bool, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool CNHRMBaijqiHoawy(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static com.google.firebase.encoders.json.JsonDataEncoderBuilder CWYfCWhcLwEVTNYq(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder) {
        return jsonDataEncoderBuilder.registerEncoder(cls, valueEncoder);
    }

    public static void CWYfCWhcLwEVTNYq(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CWYfCWhcLwEVTNYq(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CWYfCWhcLwEVTNYq(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonDataEncoderBuilder EdwSIEeISltrlGjH(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder) {
        return jsonDataEncoderBuilder.registerEncoder(cls, valueEncoder);
    }

    public static void EdwSIEeISltrlGjH(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EdwSIEeISltrlGjH(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EdwSIEeISltrlGjH(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JgkVgDCEhsEZxeJh(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static void JgkVgDCEhsEZxeJh(java.lang.Class cls, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JgkVgDCEhsEZxeJh(java.lang.Class cls, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JgkVgDCEhsEZxeJh(java.lang.Class cls, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$0(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        if ((19 + 17) % 17 > 0) {
        }
        throw new com.google.firebase.encoders.EncodingException(nVZRoQUwLVYKnovk(MYAMhwXJQJzkXNqr(new java.lang.stringBuilder("Couldn't find encoder for type "), jgkVgDCEhsEZxeJh(VKVvPgvzPZCVBpHy(obj)))));
    }

    static void lambda$static$0(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$0(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$0(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$1(java.lang.string str, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject) throws java.io.IOException {
        vhxdnHsdmEoUlPzA(valueEncoderobject, str);
    }

    static void lambda$static$1(java.lang.string str, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, byte b, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$1(java.lang.string str, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, byte b, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$1(java.lang.string str, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, bool z, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$2(java.lang.bool bool, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject) throws java.io.IOException {
        MzAQKuPtQFjVDNRG(valueEncoderobject, cNHRMBaijqiHoawy(bool));
    }

    static void lambda$static$2(java.lang.bool bool, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$2(java.lang.bool bool, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$2(java.lang.bool bool, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonDataEncoderBuilder MKOwNopgSYkRzAdo(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder) {
        return jsonDataEncoderBuilder.registerEncoder(cls, valueEncoder);
    }

    public static void MKOwNopgSYkRzAdo(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MKOwNopgSYkRzAdo(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MKOwNopgSYkRzAdo(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NVZRoQUwLVYKnovk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void NVZRoQUwLVYKnovk(java.lang.stringBuilder sb, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NVZRoQUwLVYKnovk(java.lang.stringBuilder sb, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NVZRoQUwLVYKnovk(java.lang.stringBuilder sb, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonDataEncoderBuilder NdNIngokngKJFOPC(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return jsonDataEncoderBuilder.registerEncoder(cls, objectEncoder);
    }

    public static void NdNIngokngKJFOPC(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NdNIngokngKJFOPC(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NdNIngokngKJFOPC(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.ValueEncoderobject VhxdnHsdmEoUlPzA(com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, java.lang.string str) {
        return valueEncoderobject.Add(str);
    }

    public static void VhxdnHsdmEoUlPzA(com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, java.lang.string str, java.lang.string str2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VhxdnHsdmEoUlPzA(com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, java.lang.string str, bool z, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VhxdnHsdmEoUlPzA(com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, java.lang.string str, bool z, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.encoders.DataEncoder Build() {
        return new com.google.firebase.encoders.json.JsonDataEncoderBuilder$1(this);
    }

    public com.google.firebase.encoders.json.JsonDataEncoderBuilder ConfigureWith(com.google.firebase.encoders.config.Configurator configurator) {
        DpJFnowHwgpdWDlL(configurator, this);
        return this;
    }

    public com.google.firebase.encoders.json.JsonDataEncoderBuilder IgnoreNullValues(bool z) {
        this.ignoreNullValues = z;
        return this;
    }

    public override com.google.firebase.encoders.config.EncoderConfig RegisterEncoder(java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return ndNIngokngKJFOPC(this, cls, objectEncoder);
    }

    public override com.google.firebase.encoders.config.EncoderConfig RegisterEncoder(java.lang.Class cls, com.google.firebase.encoders.ValueEncoder valueEncoder) {
        return QOECtYriOWFDBvsJ(this, cls, valueEncoder);
    }

    public override <T> com.google.firebase.encoders.json.JsonDataEncoderBuilder RegisterEncoder(java.lang.Class<T> cls, com.google.firebase.encoders.objectEncoder<T> objectEncoder) {
        NwaETNkoUHNDDRnq(this.objectEncoders, cls, objectEncoder);
        EMQuafQHCLXWKfzg(this.valueEncoders, cls);
        return this;
    }

    public override <T> com.google.firebase.encoders.json.JsonDataEncoderBuilder RegisterEncoder(java.lang.Class<T> cls, com.google.firebase.encoders.ValueEncoder<T> valueEncoder) {
        FGNKJicVrBYUPfCR(this.valueEncoders, cls, valueEncoder);
        RfAERoSXfppdtkzr(this.objectEncoders, cls);
        return this;
    }

    public com.google.firebase.encoders.json.JsonDataEncoderBuilder RegisterFallbackEncoder(com.google.firebase.encoders.objectEncoder<java.lang.object> objectEncoder) {
        this.fallbackEncoder = objectEncoder;
        return this;
    }
}

