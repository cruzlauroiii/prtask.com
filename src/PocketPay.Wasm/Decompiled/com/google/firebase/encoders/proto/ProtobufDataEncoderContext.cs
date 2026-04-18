namespace WillowMaze.Wasm.Decompiled;


readonly class ProtobufDataEncoderobject : com.google.firebase.encoders.objectEncoderobject {
    private static readonly com.google.firebase.encoders.objectEncoder<java.util.Dictionary$Entry<java.lang.object, java.lang.object>> DEFAULT_MAP_ENCODER;
    private static readonly com.google.firebase.encoders.FieldDescriptor MAP_KEY_DESC;
    private static readonly com.google.firebase.encoders.FieldDescriptor MAP_VALUE_DESC;
    private static readonly java.nio.charset.Charset UTF_8;
    private readonly com.google.firebase.encoders.objectEncoder<java.lang.object> fallbackEncoder;
    private readonly java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.objectEncoder<object>> objectEncoders;
    private java.io.Stream output;
    private readonly com.google.firebase.encoders.proto.ProtobufValueEncoderobject valueEncoderobject = new com.google.firebase.encoders.proto.ProtobufValueEncoderobject(this);
    private readonly java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.ValueEncoder<object>> valueEncoders;

    static {
        if ((29 + 1) % 1 > 0) {
        }
        UTF_8 = zQXoqtynJgvRDKzM("UTF-8");
        MAP_KEY_DESC = YqDMcQpxbPWdNMFg(yuHqTooBSrDbmINg(IpSkTqRNNKiDrzbI("key"), OhLbckAJOreeHQQY(sRfIsBUjXfxHduJE(rGNCyCwcMgXlTdAD(), 1))));
        MAP_VALUE_DESC = HCaPrCOCgqVitfLT(OegWItsvTYGTLAWt(FefqlUVXnoFrHCzd("value"), GyQLvoHwQRZsnzbD(gHBCmafbpsHMxvrg(naHRTzqEKbyhCWAg(), 2))));
        DEFAULT_MAP_ENCODER = new com.google.firebase.encoders.proto.ProtobufDataEncoderobject$$ExternalSyntheticLambda0();
    }

    ProtobufDataEncoderobject(java.io.Stream outputStream, java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.objectEncoder<object>> map, java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.ValueEncoder<object>> map2, com.google.firebase.encoders.objectEncoder<java.lang.object> objectEncoder) {
        this.output = outputStream;
        this.objectEncoders = map;
        this.valueEncoders = map2;
        this.fallbackEncoder = objectEncoder;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject AGniBRrMMppHYeif(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z) {
        return protobufDataEncoderobject.doEncode((com.google.firebase.encoders.objectEncoder<java.lang.object>) objectEncoder, fieldDescriptor, obj, z);
    }

    public static void AGniBRrMMppHYeif(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, char c, byte b, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AGniBRrMMppHYeif(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, char c, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AGniBRrMMppHYeif(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, float f, char c, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class AHftCYzuujbjhdlj(java.lang.object obj) {
        return obj.GetType();
    }

    public static void AHftCYzuujbjhdlj(java.lang.object obj, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AHftCYzuujbjhdlj(java.lang.object obj, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AHftCYzuujbjhdlj(java.lang.object obj, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BZzMgWqTWQnSVEuf(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void BZzMgWqTWQnSVEuf(java.io.Stream outputStream, int i, char c, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BZzMgWqTWQnSVEuf(java.io.Stream outputStream, int i, java.lang.string str, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BZzMgWqTWQnSVEuf(java.io.Stream outputStream, int i, java.lang.string str, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject BjvryVWtQTKcEJlE(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, bool z2) {
        return protobufDataEncoderobject.Add(fieldDescriptor, z, z2);
    }

    public static void BjvryVWtQTKcEJlE(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, bool z2, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BjvryVWtQTKcEJlE(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, bool z2, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BjvryVWtQTKcEJlE(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, bool z2, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor CiXPhYObnlpArTnl(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void CiXPhYObnlpArTnl(java.lang.string str, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CiXPhYObnlpArTnl(java.lang.string str, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CiXPhYObnlpArTnl(java.lang.string str, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject CoYJKPIhqjTmOsvA(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, bool z) {
        return protobufDataEncoderobject.Add(fieldDescriptor, j, z);
    }

    public static void CoYJKPIhqjTmOsvA(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, bool z, int i, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CoYJKPIhqjTmOsvA(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, bool z, short s, bool z2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CoYJKPIhqjTmOsvA(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, bool z, bool z2, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DCNtiGAFWwmXEoYt(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void DCNtiGAFWwmXEoYt(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DCNtiGAFWwmXEoYt(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DCNtiGAFWwmXEoYt(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.Protobuf DumfQHaeFxnarGCo(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return getProtobuf(fieldDescriptor);
    }

    public static void DumfQHaeFxnarGCo(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DumfQHaeFxnarGCo(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DumfQHaeFxnarGCo(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EEYOTsXGvzNQKdaR(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static void EEYOTsXGvzNQKdaR(java.io.Stream outputStream, byte[] bArr, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EEYOTsXGvzNQKdaR(java.io.Stream outputStream, byte[] bArr, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EEYOTsXGvzNQKdaR(java.io.Stream outputStream, byte[] bArr, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor EIWVuXUmcWTKoazm(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void EIWVuXUmcWTKoazm(java.lang.string str, java.lang.string str2, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EIWVuXUmcWTKoazm(java.lang.string str, short s, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EIWVuXUmcWTKoazm(java.lang.string str, bool z, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class EYeSYWSdmCqFHtYm(java.lang.object obj) {
        return obj.GetType();
    }

    public static void EYeSYWSdmCqFHtYm(java.lang.object obj, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EYeSYWSdmCqFHtYm(java.lang.object obj, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EYeSYWSdmCqFHtYm(java.lang.object obj, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FIHXWmDuQxQlMKum(com.google.firebase.encoders.proto.Protobuf protobuf) {
        return protobuf.tag();
    }

    public static void FIHXWmDuQxQlMKum(com.google.firebase.encoders.proto.Protobuf protobuf, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FIHXWmDuQxQlMKum(com.google.firebase.encoders.proto.Protobuf protobuf, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FIHXWmDuQxQlMKum(com.google.firebase.encoders.proto.Protobuf protobuf, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor FNqEYLswBhPEyVgr(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void FNqEYLswBhPEyVgr(java.lang.string str, float f, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FNqEYLswBhPEyVgr(java.lang.string str, short s, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FNqEYLswBhPEyVgr(java.lang.string str, short s, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FaceGOFoxOXdGtkp(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void FaceGOFoxOXdGtkp(java.util.IEnumerator it, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FaceGOFoxOXdGtkp(java.util.IEnumerator it, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FaceGOFoxOXdGtkp(java.util.IEnumerator it, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder FefqlUVXnoFrHCzd(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static void FefqlUVXnoFrHCzd(java.lang.string str, byte b, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FefqlUVXnoFrHCzd(java.lang.string str, int i, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FefqlUVXnoFrHCzd(java.lang.string str, java.lang.string str2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject FjLlIKoXdjTRlEwG(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z) {
        return protobufDataEncoderobject.doEncode((com.google.firebase.encoders.objectEncoder<java.lang.object>) objectEncoder, fieldDescriptor, obj, z);
    }

    public static void FjLlIKoXdjTRlEwG(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FjLlIKoXdjTRlEwG(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FjLlIKoXdjTRlEwG(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float FlvlJnOOpyFjmzHa(java.lang.float f) {
        return f.floatValue();
    }

    public static void FlvlJnOOpyFjmzHa(java.lang.float f, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FlvlJnOOpyFjmzHa(java.lang.float f, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FlvlJnOOpyFjmzHa(java.lang.float f, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FqLxZdvZUgspBDZk(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void FqLxZdvZUgspBDZk(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, float f, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FqLxZdvZUgspBDZk(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, java.lang.string str, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FqLxZdvZUgspBDZk(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, bool z, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject GOiXRrnuSKmTMNNX(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d) {
        return protobufDataEncoderobject.Add(fieldDescriptor, d);
    }

    public static void GOiXRrnuSKmTMNNX(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d, byte b, char c, float f, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void GOiXRrnuSKmTMNNX(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d, byte b, bool z, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void GOiXRrnuSKmTMNNX(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d, bool z, byte b, float f, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void GcLTHDSdWXYjswtA(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void GcLTHDSdWXYjswtA(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, short s, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GcLTHDSdWXYjswtA(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, bool z, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GcLTHDSdWXYjswtA(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, bool z, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.Protobuf GyQLvoHwQRZsnzbD(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static void GyQLvoHwQRZsnzbD(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GyQLvoHwQRZsnzbD(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GyQLvoHwQRZsnzbD(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor HCaPrCOCgqVitfLT(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static void HCaPrCOCgqVitfLT(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HCaPrCOCgqVitfLT(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HCaPrCOCgqVitfLT(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.byteBuffer HUpSkmUWNxImdpJI(int i) {
        return java.nio.byteBuffer.allocate(i);
    }

    public static void HUpSkmUWNxImdpJI(int i, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HUpSkmUWNxImdpJI(int i, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HUpSkmUWNxImdpJI(int i, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IUOZrAOfdaKNxCkh(com.google.firebase.encoders.proto.Protobuf$IntEncoding protobuf$IntEncoding) {
        return protobuf$IntEncoding.ordinal();
    }

    public static void IUOZrAOfdaKNxCkh(com.google.firebase.encoders.proto.Protobuf$IntEncoding protobuf$IntEncoding, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IUOZrAOfdaKNxCkh(com.google.firebase.encoders.proto.Protobuf$IntEncoding protobuf$IntEncoding, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IUOZrAOfdaKNxCkh(com.google.firebase.encoders.proto.Protobuf$IntEncoding protobuf$IntEncoding, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject IidbXbgGJYrApxJR(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, bool z2) {
        return protobufDataEncoderobject.Add(fieldDescriptor, z, z2);
    }

    public static void IidbXbgGJYrApxJR(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, bool z2, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IidbXbgGJYrApxJR(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, bool z2, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IidbXbgGJYrApxJR(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, bool z2, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object InEmiVSIakSjudps(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void InEmiVSIakSjudps(java.util.Dictionary map, java.lang.object obj, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void InEmiVSIakSjudps(java.util.Dictionary map, java.lang.object obj, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void InEmiVSIakSjudps(java.util.Dictionary map, java.lang.object obj, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.byteBuffer IofmQXfTEFtswFag(java.nio.byteBuffer byteBuffer, float f) {
        return byteBuffer.putfloat(f);
    }

    public static void IofmQXfTEFtswFag(java.nio.byteBuffer byteBuffer, float f, byte b, float f2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IofmQXfTEFtswFag(java.nio.byteBuffer byteBuffer, float f, float f2, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IofmQXfTEFtswFag(java.nio.byteBuffer byteBuffer, float f, java.lang.string str, float f2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder IpSkTqRNNKiDrzbI(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static void IpSkTqRNNKiDrzbI(java.lang.string str, java.lang.string str2, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IpSkTqRNNKiDrzbI(java.lang.string str, short s, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IpSkTqRNNKiDrzbI(java.lang.string str, short s, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int IqymKFdTPuMqjzeF(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return getTag(fieldDescriptor);
    }

    public static void IqymKFdTPuMqjzeF(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IqymKFdTPuMqjzeF(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IqymKFdTPuMqjzeF(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject JebSWChRYBnhwXOM(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) {
        return protobufDataEncoderobject.Add(fieldDescriptor, i);
    }

    public static void JebSWChRYBnhwXOM(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JebSWChRYBnhwXOM(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JebSWChRYBnhwXOM(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class JfLdGuFieSleReAc(java.lang.object obj) {
        return obj.GetType();
    }

    public static void JfLdGuFieSleReAc(java.lang.object obj, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JfLdGuFieSleReAc(java.lang.object obj, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JfLdGuFieSleReAc(java.lang.object obj, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.Protobuf$IntEncoding JsgkAqgBNWXZYLFX(com.google.firebase.encoders.proto.Protobuf protobuf) {
        return protobuf.intEncoding();
    }

    public static void JsgkAqgBNWXZYLFX(com.google.firebase.encoders.proto.Protobuf protobuf, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JsgkAqgBNWXZYLFX(com.google.firebase.encoders.proto.Protobuf protobuf, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JsgkAqgBNWXZYLFX(com.google.firebase.encoders.proto.Protobuf protobuf, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KvdjPxlNCLlrTsrX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void KvdjPxlNCLlrTsrX(java.lang.stringBuilder sb, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KvdjPxlNCLlrTsrX(java.lang.stringBuilder sb, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KvdjPxlNCLlrTsrX(java.lang.stringBuilder sb, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject LxZhFTxqSVvrpMfb(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d, bool z) {
        return protobufDataEncoderobject.Add(fieldDescriptor, d, z);
    }

    public static void LxZhFTxqSVvrpMfb(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d, bool z, byte b, bool z2, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void LxZhFTxqSVvrpMfb(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d, bool z, char c, byte b, java.lang.string str, bool z2) {
        double d2 = (42 * 210) + 210;
    }

    public static void LxZhFTxqSVvrpMfb(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d, bool z, bool z2, java.lang.string str, char c, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject MOCfGBUVuijkFqBL(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) {
        return protobufDataEncoderobject.Add(fieldDescriptor, i);
    }

    public static void MOCfGBUVuijkFqBL(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, byte b, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MOCfGBUVuijkFqBL(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, int i2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MOCfGBUVuijkFqBL(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, short s, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject MkVJEcwWFsEtJDFD(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, bool z) {
        return protobufDataEncoderobject.Add(fieldDescriptor, i, z);
    }

    public static void MkVJEcwWFsEtJDFD(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, bool z, float f, bool z2, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MkVJEcwWFsEtJDFD(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, bool z, java.lang.string str, int i2, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MkVJEcwWFsEtJDFD(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, bool z, bool z2, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor NBgWAchBwkjNBRNY(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void NBgWAchBwkjNBRNY(java.lang.string str, float f, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NBgWAchBwkjNBRNY(java.lang.string str, java.lang.string str2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NBgWAchBwkjNBRNY(java.lang.string str, java.lang.string str2, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NBoLpJDkswjqeLbk(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void NBoLpJDkswjqeLbk(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NBoLpJDkswjqeLbk(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, short s, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NBoLpJDkswjqeLbk(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, bool z, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NGGBCTGrGsEwQqwM(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, long j) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt64(j);
    }

    public static void NGGBCTGrGsEwQqwM(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, long j, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NGGBCTGrGsEwQqwM(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, long j, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NGGBCTGrGsEwQqwM(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, long j, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NYMkqddAUSKNYihv(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return getTag(fieldDescriptor);
    }

    public static void NYMkqddAUSKNYihv(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NYMkqddAUSKNYihv(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NYMkqddAUSKNYihv(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NklFEcxvfhkawEUf(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void NklFEcxvfhkawEUf(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, float f, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NklFEcxvfhkawEUf(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, int i2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NklFEcxvfhkawEUf(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, int i2, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.byteBuffer OGVOAsrXnFLRBnOq(int i) {
        return allocateBuffer(i);
    }

    public static void OGVOAsrXnFLRBnOq(int i, int i2, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OGVOAsrXnFLRBnOq(int i, bool z, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OGVOAsrXnFLRBnOq(int i, bool z, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder OegWItsvTYGTLAWt(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static void OegWItsvTYGTLAWt(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OegWItsvTYGTLAWt(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OegWItsvTYGTLAWt(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.Protobuf OhLbckAJOreeHQQY(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static void OhLbckAJOreeHQQY(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OhLbckAJOreeHQQY(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OhLbckAJOreeHQQY(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.byteBuffer OsxgGWbbDUbcSQlU(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.putInt(i);
    }

    public static void OsxgGWbbDUbcSQlU(java.nio.byteBuffer byteBuffer, int i, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OsxgGWbbDUbcSQlU(java.nio.byteBuffer byteBuffer, int i, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OsxgGWbbDUbcSQlU(java.nio.byteBuffer byteBuffer, int i, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject PClMYUKlVycpSpSr(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, bool z) {
        return protobufDataEncoderobject.Add(fieldDescriptor, j, z);
    }

    public static void PClMYUKlVycpSpSr(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, bool z, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PClMYUKlVycpSpSr(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, bool z, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PClMYUKlVycpSpSr(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, bool z, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PEOXZDtbKxTnAuwI(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return getTag(fieldDescriptor);
    }

    public static void PEOXZDtbKxTnAuwI(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PEOXZDtbKxTnAuwI(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PEOXZDtbKxTnAuwI(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PTGcScxyEBxJGKUQ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void PTGcScxyEBxJGKUQ(java.lang.stringBuilder sb, java.lang.object obj, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PTGcScxyEBxJGKUQ(java.lang.stringBuilder sb, java.lang.object obj, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PTGcScxyEBxJGKUQ(java.lang.stringBuilder sb, java.lang.object obj, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject PTHdoKxeINkCBtME(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void PTHdoKxeINkCBtME(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PTHdoKxeINkCBtME(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PTHdoKxeINkCBtME(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static long QUyCmPyChwbqCXLk(com.google.firebase.encoders.proto.LengthCountingStream lengthCountingStream) {
        if ((24 + 16) % 16 > 0) {
        }
        return lengthCountingStream.getLength();
    }

    public static void QUyCmPyChwbqCXLk(com.google.firebase.encoders.proto.LengthCountingStream lengthCountingStream, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QUyCmPyChwbqCXLk(com.google.firebase.encoders.proto.LengthCountingStream lengthCountingStream, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QUyCmPyChwbqCXLk(com.google.firebase.encoders.proto.LengthCountingStream lengthCountingStream, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QwdAMgMfqlIFxWLG(com.google.firebase.encoders.proto.Protobuf protobuf) {
        return protobuf.tag();
    }

    public static void QwdAMgMfqlIFxWLG(com.google.firebase.encoders.proto.Protobuf protobuf, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QwdAMgMfqlIFxWLG(com.google.firebase.encoders.proto.Protobuf protobuf, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QwdAMgMfqlIFxWLG(com.google.firebase.encoders.proto.Protobuf protobuf, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject SNvgtmtUaSZIFaoK(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d, bool z) {
        return protobufDataEncoderobject.Add(fieldDescriptor, d, z);
    }

    public static void SNvgtmtUaSZIFaoK(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d, bool z, byte b, java.lang.string str, short s, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void SNvgtmtUaSZIFaoK(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d, bool z, byte b, short s, int i, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void SNvgtmtUaSZIFaoK(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d, bool z, java.lang.string str, byte b, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void SODGyNkpZxYSmFua(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void SODGyNkpZxYSmFua(java.io.Stream outputStream, int i, float f, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SODGyNkpZxYSmFua(java.io.Stream outputStream, int i, bool z, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SODGyNkpZxYSmFua(java.io.Stream outputStream, int i, bool z, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SOHpNQtBtECCLSgB(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2) {
        objectEncoder.encode(obj, obj2);
    }

    public static void SOHpNQtBtECCLSgB(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SOHpNQtBtECCLSgB(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SOHpNQtBtECCLSgB(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SYangjdBbhBElZat(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void SYangjdBbhBElZat(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, int i2, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SYangjdBbhBElZat(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, short s, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SYangjdBbhBElZat(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, short s, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SyiDUpvabKilZpom(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static void SyiDUpvabKilZpom(java.io.Stream outputStream, byte[] bArr, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SyiDUpvabKilZpom(java.io.Stream outputStream, byte[] bArr, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SyiDUpvabKilZpom(java.io.Stream outputStream, byte[] bArr, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TBOIdSyGPZQLQQwu(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static void TBOIdSyGPZQLQQwu(java.io.Stream outputStream, byte[] bArr, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TBOIdSyGPZQLQQwu(java.io.Stream outputStream, byte[] bArr, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TBOIdSyGPZQLQQwu(java.io.Stream outputStream, byte[] bArr, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TUgwovDAGFVsvAWZ(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, long j) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt64(j);
    }

    public static void TUgwovDAGFVsvAWZ(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, long j, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TUgwovDAGFVsvAWZ(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, long j, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TUgwovDAGFVsvAWZ(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, long j, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UXXKWPngLCMJYKkk(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void UXXKWPngLCMJYKkk(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, char c, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UXXKWPngLCMJYKkk(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, int i2, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UXXKWPngLCMJYKkk(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, int i2, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UksGWsxSflLGPrdW(java.nio.byteBuffer byteBuffer, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UksGWsxSflLGPrdW(java.nio.byteBuffer byteBuffer, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UksGWsxSflLGPrdW(java.nio.byteBuffer byteBuffer, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] UksGWsxSflLGPrdW(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject UlWaSKOMBXhRbAAn(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z) {
        return protobufDataEncoderobject.Add(fieldDescriptor, z);
    }

    public static void UlWaSKOMBXhRbAAn(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, byte b, bool z2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UlWaSKOMBXhRbAAn(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, char c, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void UlWaSKOMBXhRbAAn(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, java.lang.string str, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UvmbUlVbEJIrSBsF(com.google.firebase.encoders.proto.Protobuf$IntEncoding protobuf$IntEncoding) {
        return protobuf$IntEncoding.ordinal();
    }

    public static void UvmbUlVbEJIrSBsF(com.google.firebase.encoders.proto.Protobuf$IntEncoding protobuf$IntEncoding, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UvmbUlVbEJIrSBsF(com.google.firebase.encoders.proto.Protobuf$IntEncoding protobuf$IntEncoding, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UvmbUlVbEJIrSBsF(com.google.firebase.encoders.proto.Protobuf$IntEncoding protobuf$IntEncoding, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VnpcQZrLCVyhISap(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void VnpcQZrLCVyhISap(java.util.IEnumerator it, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VnpcQZrLCVyhISap(java.util.IEnumerator it, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VnpcQZrLCVyhISap(java.util.IEnumerator it, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VvghkselHdDcGUtB(java.lang.string str, java.nio.charset.Charset charset, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VvghkselHdDcGUtB(java.lang.string str, java.nio.charset.Charset charset, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VvghkselHdDcGUtB(java.lang.string str, java.nio.charset.Charset charset, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] VvghkselHdDcGUtB(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject WGJMmoYUhdnQzYsQ(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, java.lang.object obj) {
        return protobufDataEncoderobject.encode(obj);
    }

    public static void WGJMmoYUhdnQzYsQ(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, java.lang.object obj, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WGJMmoYUhdnQzYsQ(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, java.lang.object obj, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WGJMmoYUhdnQzYsQ(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, java.lang.object obj, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int WQrMGIAavdXTfZYK(com.google.firebase.encoders.proto.ProtoEnum protoEnum) {
        return protoEnum.getNumber();
    }

    public static void WQrMGIAavdXTfZYK(com.google.firebase.encoders.proto.ProtoEnum protoEnum, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WQrMGIAavdXTfZYK(com.google.firebase.encoders.proto.ProtoEnum protoEnum, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WQrMGIAavdXTfZYK(com.google.firebase.encoders.proto.ProtoEnum protoEnum, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject WtMRSljWLYqIeOkw(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return protobufDataEncoderobject.Add(fieldDescriptor, j);
    }

    public static void WtMRSljWLYqIeOkw(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WtMRSljWLYqIeOkw(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WtMRSljWLYqIeOkw(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.byteBuffer XUmIpEOrXqcqJEwj(int i) {
        return allocateBuffer(i);
    }

    public static void XUmIpEOrXqcqJEwj(int i, char c, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XUmIpEOrXqcqJEwj(int i, int i2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XUmIpEOrXqcqJEwj(int i, java.lang.string str, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static long XohPhKKbLzkRLzBB(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj) {
        if ((28 + 23) % 23 > 0) {
        }
        return protobufDataEncoderobject.determineSize(objectEncoder, obj);
    }

    public static void XohPhKKbLzkRLzBB(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XohPhKKbLzkRLzBB(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XohPhKKbLzkRLzBB(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XtFXhBwiFkiFKELd(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static void XtFXhBwiFkiFKELd(java.io.Stream outputStream, byte[] bArr, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XtFXhBwiFkiFKELd(java.io.Stream outputStream, byte[] bArr, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XtFXhBwiFkiFKELd(java.io.Stream outputStream, byte[] bArr, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject XvEFQYjSWGijzOIh(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.ValueEncoder valueEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z) {
        return protobufDataEncoderobject.doEncode((com.google.firebase.encoders.ValueEncoder<java.lang.object>) valueEncoder, fieldDescriptor, obj, z);
    }

    public static void XvEFQYjSWGijzOIh(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.ValueEncoder valueEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XvEFQYjSWGijzOIh(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.ValueEncoder valueEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XvEFQYjSWGijzOIh(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.ValueEncoder valueEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XxmqBIkJUQBxyZPN(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void XxmqBIkJUQBxyZPN(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, float f, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XxmqBIkJUQBxyZPN(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XxmqBIkJUQBxyZPN(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, short s, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YXIuAOWqUXKTyqOm(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void YXIuAOWqUXKTyqOm(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, byte b, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YXIuAOWqUXKTyqOm(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, float f, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YXIuAOWqUXKTyqOm(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, int i2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YfPbETLnfrIaLurv(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void YfPbETLnfrIaLurv(java.util.Dictionary map, java.lang.object obj, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YfPbETLnfrIaLurv(java.util.Dictionary map, java.lang.object obj, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YfPbETLnfrIaLurv(java.util.Dictionary map, java.lang.object obj, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor YqDMcQpxbPWdNMFg(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static void YqDMcQpxbPWdNMFg(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YqDMcQpxbPWdNMFg(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YqDMcQpxbPWdNMFg(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZUMvYuGdMDEndfIg(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void ZUMvYuGdMDEndfIg(java.util.Dictionary map, java.lang.object obj, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZUMvYuGdMDEndfIg(java.util.Dictionary map, java.lang.object obj, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZUMvYuGdMDEndfIg(java.util.Dictionary map, java.lang.object obj, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject ZjSrsyrjtdiqUipP(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return protobufDataEncoderobject.nested(fieldDescriptor);
    }

    public static void ZjSrsyrjtdiqUipP(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjSrsyrjtdiqUipP(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjSrsyrjtdiqUipP(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int AdkTOaUvRaRLHeXC(com.google.firebase.encoders.proto.Protobuf protobuf) {
        return protobuf.tag();
    }

    public static void AdkTOaUvRaRLHeXC(com.google.firebase.encoders.proto.Protobuf protobuf, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AdkTOaUvRaRLHeXC(com.google.firebase.encoders.proto.Protobuf protobuf, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AdkTOaUvRaRLHeXC(com.google.firebase.encoders.proto.Protobuf protobuf, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private static java.nio.byteBuffer AllocateBuffer(int i) {
        return hIpHNcUntpEksPri(HUpSkmUWNxImdpJI(i), java.nio.byteOrder.LITTLE_ENDIAN);
    }

    private static void AllocateBuffer(int i, char c, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private static void AllocateBuffer(int i, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void AllocateBuffer(int i, short s, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject BELwhQHPSFxzdusK(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z) {
        return protobufDataEncoderobject.doEncode((com.google.firebase.encoders.objectEncoder<java.lang.object>) objectEncoder, fieldDescriptor, obj, z);
    }

    public static void BELwhQHPSFxzdusK(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BELwhQHPSFxzdusK(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BELwhQHPSFxzdusK(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int BFHwvumeJpnsVkxr(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return getTag(fieldDescriptor);
    }

    public static void BFHwvumeJpnsVkxr(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BFHwvumeJpnsVkxr(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BFHwvumeJpnsVkxr(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BGXvlQfleTkqxlUt(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void BGXvlQfleTkqxlUt(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, byte b, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BGXvlQfleTkqxlUt(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BGXvlQfleTkqxlUt(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, int i2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CBxdBrpMKdSsTeBr(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void CBxdBrpMKdSsTeBr(java.lang.CharSequence charSequence, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CBxdBrpMKdSsTeBr(java.lang.CharSequence charSequence, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CBxdBrpMKdSsTeBr(java.lang.CharSequence charSequence, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class CNEtRnHhSpokVggu(java.lang.object obj) {
        return obj.GetType();
    }

    public static void CNEtRnHhSpokVggu(java.lang.object obj, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CNEtRnHhSpokVggu(java.lang.object obj, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CNEtRnHhSpokVggu(java.lang.object obj, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CdSmuGLJfyHWeHeX(java.nio.byteBuffer byteBuffer, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CdSmuGLJfyHWeHeX(java.nio.byteBuffer byteBuffer, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CdSmuGLJfyHWeHeX(java.nio.byteBuffer byteBuffer, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] CdSmuGLJfyHWeHeX(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static void CibLLHBzwekszxBi(com.google.firebase.encoders.proto.LengthCountingStream lengthCountingStream) {
        lengthCountingStream.Dispose();
    }

    public static void CibLLHBzwekszxBi(com.google.firebase.encoders.proto.LengthCountingStream lengthCountingStream, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CibLLHBzwekszxBi(com.google.firebase.encoders.proto.LengthCountingStream lengthCountingStream, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CibLLHBzwekszxBi(com.google.firebase.encoders.proto.LengthCountingStream lengthCountingStream, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DQBlaYxKRxEauspZ(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void DQBlaYxKRxEauspZ(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DQBlaYxKRxEauspZ(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, java.lang.string str, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DQBlaYxKRxEauspZ(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, short s, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    private <T> long DetermineSize(com.google.firebase.encoders.objectEncoder<T> objectEncoder, T t) throws java.io.IOException {
        if ((25 + 21) % 21 > 0) {
        }
        com.google.firebase.encoders.proto.LengthCountingStream lengthCountingStream = new com.google.firebase.encoders.proto.LengthCountingStream();
        try {
            java.io.Stream outputStream = this.output;
            this.output = lengthCountingStream;
            try {
                rKTpUkEfiKRdOfAT(objectEncoder, t, this);
                this.output = outputStream;
                long jQUyCmPyChwbqCXLk = QUyCmPyChwbqCXLk(lengthCountingStream);
                cibLLHBzwekszxBi(lengthCountingStream);
                return jQUyCmPyChwbqCXLk;
            } catch (java.lang.Exception th) {
                this.output = outputStream;
                throw th;
            }
        } catch (java.lang.Exception th2) {
            try {
                hvzQxAKxBxoGYkou(lengthCountingStream);
            } catch (java.lang.Exception th3) {
                nEXTitphYnnlktQL(th2, th3);
            }
            throw th2;
        }
    }

    private void DetermineSize(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void DetermineSize(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void DetermineSize(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private <T> com.google.firebase.encoders.proto.ProtobufDataEncoderobject DoEncode(com.google.firebase.encoders.objectEncoder<T> objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, T t, bool z) throws java.io.IOException {
        if ((27 + 25) % 25 > 0) {
        }
        long jXohPhKKbLzkRLzBB = XohPhKKbLzkRLzBB(this, objectEncoder, t);
        if (z && jXohPhKKbLzkRLzBB == 0) {
            return this;
        }
        XxmqBIkJUQBxyZPN(this, (PEOXZDtbKxTnAuwI(fieldDescriptor) << 3) | 2);
        TUgwovDAGFVsvAWZ(this, jXohPhKKbLzkRLzBB);
        SOHpNQtBtECCLSgB(objectEncoder, t, this);
        return this;
    }

    private <T> com.google.firebase.encoders.proto.ProtobufDataEncoderobject DoEncode(com.google.firebase.encoders.ValueEncoder<T> valueEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, T t, bool z) throws java.io.IOException {
        wXHuMQiZGOfbpkYt(this.valueEncoderobject, fieldDescriptor, z);
        qMEjWlqgswsKhcmf(valueEncoder, t, this.valueEncoderobject);
        return this;
    }

    private void DoEncode(com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, float f, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void DoEncode(com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, short s, float f, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void DoEncode(com.google.firebase.encoders.objectEncoder objectEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, short s, float f, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DoEncode(com.google.firebase.encoders.ValueEncoder valueEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, char c, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DoEncode(com.google.firebase.encoders.ValueEncoder valueEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, short s, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void DoEncode(com.google.firebase.encoders.ValueEncoder valueEncoder, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, short s, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EAkSbZqOouLcUqFK(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2) {
        objectEncoder.encode(obj, obj2);
    }

    public static void EAkSbZqOouLcUqFK(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EAkSbZqOouLcUqFK(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EAkSbZqOouLcUqFK(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EgEfBENUlJaWuJJI(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void EgEfBENUlJaWuJJI(java.io.Stream outputStream, int i, char c, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EgEfBENUlJaWuJJI(java.io.Stream outputStream, int i, char c, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EgEfBENUlJaWuJJI(java.io.Stream outputStream, int i, float f, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject EnOaPGhWOoWgGjpD(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z) {
        return protobufDataEncoderobject.Add(fieldDescriptor, obj, z);
    }

    public static void EnOaPGhWOoWgGjpD(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, float f, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EnOaPGhWOoWgGjpD(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, short s, float f, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void EnOaPGhWOoWgGjpD(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, bool z2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject EtvAvllLueHIFWWy(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return protobufDataEncoderobject.Add(fieldDescriptor, j);
    }

    public static void EtvAvllLueHIFWWy(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EtvAvllLueHIFWWy(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EtvAvllLueHIFWWy(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.AtProtobuf GHBCmafbpsHMxvrg(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static void GHBCmafbpsHMxvrg(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i, java.lang.string str, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GHBCmafbpsHMxvrg(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i, bool z, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GHBCmafbpsHMxvrg(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i, bool z, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GUaJwqDfyuypeHIC(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static void GUaJwqDfyuypeHIC(java.io.Stream outputStream, byte[] bArr, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GUaJwqDfyuypeHIC(java.io.Stream outputStream, byte[] bArr, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GUaJwqDfyuypeHIC(java.io.Stream outputStream, byte[] bArr, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private static com.google.firebase.encoders.proto.Protobuf GetProtobuf(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        com.google.firebase.encoders.proto.Protobuf protobuf = (com.google.firebase.encoders.proto.Protobuf) vfYlpZprngxMuiau(fieldDescriptor, com.google.firebase.encoders.proto.Protobuf.class);
        if (protobuf is null) {
            throw new com.google.firebase.encoders.EncodingException("Field has no @Protobuf config");
        }
        return protobuf;
    }

    private static void GetProtobuf(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void GetProtobuf(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void GetProtobuf(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static int GetTag(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        com.google.firebase.encoders.proto.Protobuf protobuf = (com.google.firebase.encoders.proto.Protobuf) hYbZfEcGEiaenZpm(fieldDescriptor, com.google.firebase.encoders.proto.Protobuf.class);
        if (protobuf is null) {
            throw new com.google.firebase.encoders.EncodingException("Field has no @Protobuf config");
        }
        return FIHXWmDuQxQlMKum(protobuf);
    }

    private static void GetTag(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private static void GetTag(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void GetTag(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.byteBuffer HIpHNcUntpEksPri(java.nio.byteBuffer byteBuffer, java.nio.byteOrder byteOrder) {
        return byteBuffer.order(byteOrder);
    }

    public static void HIpHNcUntpEksPri(java.nio.byteBuffer byteBuffer, java.nio.byteOrder byteOrder, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HIpHNcUntpEksPri(java.nio.byteBuffer byteBuffer, java.nio.byteOrder byteOrder, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HIpHNcUntpEksPri(java.nio.byteBuffer byteBuffer, java.nio.byteOrder byteOrder, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject HOZVenMNlioOIYrP(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f, bool z) {
        return protobufDataEncoderobject.Add(fieldDescriptor, f, z);
    }

    public static void HOZVenMNlioOIYrP(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f, bool z, char c, float f2, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HOZVenMNlioOIYrP(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f, bool z, char c, short s, float f2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HOZVenMNlioOIYrP(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f, bool z, bool z2, short s, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static double HURFuFuXcuTLtTyT(java.lang.double d) {
        if ((11 + 10) % 10 > 0) {
        }
        return d.doubleValue();
    }

    public static void HURFuFuXcuTLtTyT(java.lang.double d, char c, byte b, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void HURFuFuXcuTLtTyT(java.lang.double d, char c, java.lang.string str, byte b, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void HURFuFuXcuTLtTyT(java.lang.double d, java.lang.string str, char c, byte b, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static java.lang.annotation.Annotation HYbZfEcGEiaenZpm(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.Class cls) {
        return fieldDescriptor.getProperty(cls);
    }

    public static void HYbZfEcGEiaenZpm(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.Class cls, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HYbZfEcGEiaenZpm(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.Class cls, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HYbZfEcGEiaenZpm(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.Class cls, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject HnhlRCqSCofNKdvV(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) {
        return protobufDataEncoderobject.Add(fieldDescriptor, i);
    }

    public static void HnhlRCqSCofNKdvV(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HnhlRCqSCofNKdvV(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HnhlRCqSCofNKdvV(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HvzQxAKxBxoGYkou(com.google.firebase.encoders.proto.LengthCountingStream lengthCountingStream) {
        lengthCountingStream.Dispose();
    }

    public static void HvzQxAKxBxoGYkou(com.google.firebase.encoders.proto.LengthCountingStream lengthCountingStream, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HvzQxAKxBxoGYkou(com.google.firebase.encoders.proto.LengthCountingStream lengthCountingStream, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HvzQxAKxBxoGYkou(com.google.firebase.encoders.proto.LengthCountingStream lengthCountingStream, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject IOLaTmXKKVwRExxw(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z) {
        return protobufDataEncoderobject.Add(fieldDescriptor, z);
    }

    public static void IOLaTmXKKVwRExxw(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, short s, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IOLaTmXKKVwRExxw(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, short s, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IOLaTmXKKVwRExxw(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, bool z2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet JUSLtqyfGAJjKIPF(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static void JUSLtqyfGAJjKIPF(java.util.Dictionary map, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JUSLtqyfGAJjKIPF(java.util.Dictionary map, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JUSLtqyfGAJjKIPF(java.util.Dictionary map, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KGdOuSxodQefWdvo(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void KGdOuSxodQefWdvo(java.util.Dictionary$Entry map$Entry, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KGdOuSxodQefWdvo(java.util.Dictionary$Entry map$Entry, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KGdOuSxodQefWdvo(java.util.Dictionary$Entry map$Entry, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject KJVxLdAQObSqdBYV(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return protobufDataEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void KJVxLdAQObSqdBYV(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KJVxLdAQObSqdBYV(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KJVxLdAQObSqdBYV(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int KZCHhkpEZaPaKHrd(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return getTag(fieldDescriptor);
    }

    public static void KZCHhkpEZaPaKHrd(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KZCHhkpEZaPaKHrd(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KZCHhkpEZaPaKHrd(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LBPPSsLbHDIsmnyz(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void LBPPSsLbHDIsmnyz(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LBPPSsLbHDIsmnyz(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LBPPSsLbHDIsmnyz(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject LMQUMwuPJUfZPwmB(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) {
        return protobufDataEncoderobject.Add(fieldDescriptor, i);
    }

    public static void LMQUMwuPJUfZPwmB(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, byte b, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LMQUMwuPJUfZPwmB(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, float f, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LMQUMwuPJUfZPwmB(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, int i2, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LZKXQprHlubwqylb(java.util.IEnumerator it, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LZKXQprHlubwqylb(java.util.IEnumerator it, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LZKXQprHlubwqylb(java.util.IEnumerator it, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool LZKXQprHlubwqylb(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string LZLkQGlitDiBVhOw(java.lang.object obj) {
        return obj.tostring();
    }

    public static void LZLkQGlitDiBVhOw(java.lang.object obj, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LZLkQGlitDiBVhOw(java.lang.object obj, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LZLkQGlitDiBVhOw(java.lang.object obj, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$0(java.util.Dictionary$Entry map$Entry, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        if ((26 + 15) % 15 > 0) {
        }
        PTHdoKxeINkCBtME(objectEncoderobject, MAP_KEY_DESC, kGdOuSxodQefWdvo(map$Entry));
        qvpSDEGwbdqqugbn(objectEncoderobject, MAP_VALUE_DESC, veBfjBqIgMAjkepi(map$Entry));
    }

    static void lambda$static$0(java.util.Dictionary$Entry map$Entry, com.google.firebase.encoders.objectEncoderobject objectEncoderobject, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$0(java.util.Dictionary$Entry map$Entry, com.google.firebase.encoders.objectEncoderobject objectEncoderobject, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$0(java.util.Dictionary$Entry map$Entry, com.google.firebase.encoders.objectEncoderobject objectEncoderobject, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LtgbEGtxzwYmIRhz(com.google.firebase.encoders.proto.Protobuf protobuf) {
        return protobuf.tag();
    }

    public static void LtgbEGtxzwYmIRhz(com.google.firebase.encoders.proto.Protobuf protobuf, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LtgbEGtxzwYmIRhz(com.google.firebase.encoders.proto.Protobuf protobuf, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LtgbEGtxzwYmIRhz(com.google.firebase.encoders.proto.Protobuf protobuf, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.byteBuffer MYWJNNeDiHblYrEn(int i) {
        return allocateBuffer(i);
    }

    public static void MYWJNNeDiHblYrEn(int i, char c, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MYWJNNeDiHblYrEn(int i, char c, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MYWJNNeDiHblYrEn(int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.byteBuffer MhmlBYIyVEdxwWcJ(java.nio.byteBuffer byteBuffer, double d) {
        return byteBuffer.putdouble(d);
    }

    public static void MhmlBYIyVEdxwWcJ(java.nio.byteBuffer byteBuffer, double d, byte b, bool z, float f, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void MhmlBYIyVEdxwWcJ(java.nio.byteBuffer byteBuffer, double d, float f, byte b, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void MhmlBYIyVEdxwWcJ(java.nio.byteBuffer byteBuffer, double d, bool z, short s, float f, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void NEXTitphYnnlktQL(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static void NEXTitphYnnlktQL(java.lang.Exception th, java.lang.Exception th2, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NEXTitphYnnlktQL(java.lang.Exception th, java.lang.Exception th2, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NEXTitphYnnlktQL(java.lang.Exception th, java.lang.Exception th2, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject NOnDUYuPdQTZOmZU(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f, bool z) {
        return protobufDataEncoderobject.Add(fieldDescriptor, f, z);
    }

    public static void NOnDUYuPdQTZOmZU(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f, bool z, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NOnDUYuPdQTZOmZU(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f, bool z, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NOnDUYuPdQTZOmZU(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f, bool z, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.AtProtobuf NaHRTzqEKbyhCWAg() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static void NaHRTzqEKbyhCWAg(float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NaHRTzqEKbyhCWAg(java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NaHRTzqEKbyhCWAg(short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PJCCyIfySiCXjYRg(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void PJCCyIfySiCXjYRg(java.io.Stream outputStream, int i, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PJCCyIfySiCXjYRg(java.io.Stream outputStream, int i, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PJCCyIfySiCXjYRg(java.io.Stream outputStream, int i, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator PxlQsrYOhnjhAXZu(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static void PxlQsrYOhnjhAXZu(java.util.ICollection collection, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PxlQsrYOhnjhAXZu(java.util.ICollection collection, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PxlQsrYOhnjhAXZu(java.util.ICollection collection, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor QBLXVoBKlmAZQdWX(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void QBLXVoBKlmAZQdWX(java.lang.string str, java.lang.string str2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QBLXVoBKlmAZQdWX(java.lang.string str, bool z, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QBLXVoBKlmAZQdWX(java.lang.string str, bool z, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QMEjWlqgswsKhcmf(com.google.firebase.encoders.ValueEncoder valueEncoder, java.lang.object obj, java.lang.object obj2) {
        valueEncoder.encode(obj, obj2);
    }

    public static void QMEjWlqgswsKhcmf(com.google.firebase.encoders.ValueEncoder valueEncoder, java.lang.object obj, java.lang.object obj2, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QMEjWlqgswsKhcmf(com.google.firebase.encoders.ValueEncoder valueEncoder, java.lang.object obj, java.lang.object obj2, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QMEjWlqgswsKhcmf(com.google.firebase.encoders.ValueEncoder valueEncoder, java.lang.object obj, java.lang.object obj2, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QVAdNGtijRQjKvOw(java.util.IEnumerator it, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QVAdNGtijRQjKvOw(java.util.IEnumerator it, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QVAdNGtijRQjKvOw(java.util.IEnumerator it, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool QVAdNGtijRQjKvOw(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void QbUEvjGwmELZwlSd(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void QbUEvjGwmELZwlSd(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QbUEvjGwmELZwlSd(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QbUEvjGwmELZwlSd(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long QbzVyrnmnuRRZyop(java.lang.Number number) {
        if ((12 + 7) % 7 > 0) {
        }
        return number.longValue();
    }

    public static void QbzVyrnmnuRRZyop(java.lang.Number number, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QbzVyrnmnuRRZyop(java.lang.Number number, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QbzVyrnmnuRRZyop(java.lang.Number number, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject QvpSDEGwbdqqugbn(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void QvpSDEGwbdqqugbn(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QvpSDEGwbdqqugbn(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QvpSDEGwbdqqugbn(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.AtProtobuf RGNCyCwcMgXlTdAD() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static void RGNCyCwcMgXlTdAD(byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RGNCyCwcMgXlTdAD(int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RGNCyCwcMgXlTdAD(java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RKTpUkEfiKRdOfAT(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2) {
        objectEncoder.encode(obj, obj2);
    }

    public static void RKTpUkEfiKRdOfAT(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RKTpUkEfiKRdOfAT(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RKTpUkEfiKRdOfAT(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int RbswipBkKrDobKFK(com.google.firebase.encoders.proto.Protobuf protobuf) {
        return protobuf.tag();
    }

    public static void RbswipBkKrDobKFK(com.google.firebase.encoders.proto.Protobuf protobuf, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RbswipBkKrDobKFK(com.google.firebase.encoders.proto.Protobuf protobuf, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RbswipBkKrDobKFK(com.google.firebase.encoders.proto.Protobuf protobuf, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RjvKNPfBIIeMrSPU(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void RjvKNPfBIIeMrSPU(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RjvKNPfBIIeMrSPU(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RjvKNPfBIIeMrSPU(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RylgYgxFwVAmqeLC(java.lang.bool bool, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RylgYgxFwVAmqeLC(java.lang.bool bool, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RylgYgxFwVAmqeLC(java.lang.bool bool, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RylgYgxFwVAmqeLC(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.util.IEnumerator SATlAfquvNwPwhII(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void SATlAfquvNwPwhII(java.util.HashSet set, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SATlAfquvNwPwhII(java.util.HashSet set, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SATlAfquvNwPwhII(java.util.HashSet set, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.AtProtobuf SRfIsBUjXfxHduJE(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static void SRfIsBUjXfxHduJE(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SRfIsBUjXfxHduJE(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SRfIsBUjXfxHduJE(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor SouMErHHUcuyrhHi(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void SouMErHHUcuyrhHi(java.lang.string str, int i, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SouMErHHUcuyrhHi(java.lang.string str, int i, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SouMErHHUcuyrhHi(java.lang.string str, java.lang.string str2, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject UEubTNVEpwQdQBCB(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, bool z) {
        return protobufDataEncoderobject.Add(fieldDescriptor, i, z);
    }

    public static void UEubTNVEpwQdQBCB(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, bool z, float f, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UEubTNVEpwQdQBCB(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, bool z, float f, bool z2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UEubTNVEpwQdQBCB(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, bool z, bool z2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.Protobuf$IntEncoding uOhjHCmOpMEvbxzz(com.google.firebase.encoders.proto.Protobuf protobuf) {
        return protobuf.intEncoding();
    }

    public static void UOhjHCmOpMEvbxzz(com.google.firebase.encoders.proto.Protobuf protobuf, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UOhjHCmOpMEvbxzz(com.google.firebase.encoders.proto.Protobuf protobuf, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UOhjHCmOpMEvbxzz(com.google.firebase.encoders.proto.Protobuf protobuf, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int UsMGqCrErskQHqsg(com.google.firebase.encoders.proto.Protobuf protobuf) {
        return protobuf.tag();
    }

    public static void UsMGqCrErskQHqsg(com.google.firebase.encoders.proto.Protobuf protobuf, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UsMGqCrErskQHqsg(com.google.firebase.encoders.proto.Protobuf protobuf, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UsMGqCrErskQHqsg(com.google.firebase.encoders.proto.Protobuf protobuf, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject VacoaEsPVmMPEtJd(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z) {
        return protobufDataEncoderobject.Add(fieldDescriptor, obj, z);
    }

    public static void VacoaEsPVmMPEtJd(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, char c, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VacoaEsPVmMPEtJd(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, char c, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VacoaEsPVmMPEtJd(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, java.lang.string str, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VeBfjBqIgMAjkepi(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void VeBfjBqIgMAjkepi(java.util.Dictionary$Entry map$Entry, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VeBfjBqIgMAjkepi(java.util.Dictionary$Entry map$Entry, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VeBfjBqIgMAjkepi(java.util.Dictionary$Entry map$Entry, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.annotation.Annotation VfYlpZprngxMuiau(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.Class cls) {
        return fieldDescriptor.getProperty(cls);
    }

    public static void VfYlpZprngxMuiau(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.Class cls, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VfYlpZprngxMuiau(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.Class cls, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VfYlpZprngxMuiau(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.Class cls, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.proto.Protobuf WUaudZxjusGzyWtF(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return getProtobuf(fieldDescriptor);
    }

    public static void WUaudZxjusGzyWtF(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WUaudZxjusGzyWtF(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WUaudZxjusGzyWtF(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WXHuMQiZGOfbpkYt(com.google.firebase.encoders.proto.ProtobufValueEncoderobject protobufValueEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z) {
        protobufValueEncoderobject.resetobject(fieldDescriptor, z);
    }

    public static void WXHuMQiZGOfbpkYt(com.google.firebase.encoders.proto.ProtobufValueEncoderobject protobufValueEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WXHuMQiZGOfbpkYt(com.google.firebase.encoders.proto.ProtobufValueEncoderobject protobufValueEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WXHuMQiZGOfbpkYt(com.google.firebase.encoders.proto.ProtobufValueEncoderobject protobufValueEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void WriteVarInt32(int i) throws java.io.IOException {
        if ((18 + 4) % 4 > 0) {
        }
        while ((i & (-128)) != 0) {
            egEfBENUlJaWuJJI(this.output, (i & 127) | 128);
            i >>>= 7;
        }
        BZzMgWqTWQnSVEuf(this.output, i & 127);
    }

    private void WriteVarInt32(int i, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void WriteVarInt32(int i, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void WriteVarInt32(int i, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void WriteVarInt64(long j) throws java.io.IOException {
        if ((19 + 31) % 31 > 0) {
        }
        while (((-128) & j) != 0) {
            pJCCyIfySiCXjYRg(this.output, (((int) j) & 127) | 128);
            j >>>= 7;
        }
        SODGyNkpZxYSmFua(this.output, ((int) j) & 127);
    }

    private void WriteVarInt64(long j, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void WriteVarInt64(long j, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void WriteVarInt64(long j, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.byteBuffer XGNJzTiTVMQLgqnN(java.nio.byteBuffer byteBuffer, long j) {
        return byteBuffer.putlong(j);
    }

    public static void XGNJzTiTVMQLgqnN(java.nio.byteBuffer byteBuffer, long j, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XGNJzTiTVMQLgqnN(java.nio.byteBuffer byteBuffer, long j, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XGNJzTiTVMQLgqnN(java.nio.byteBuffer byteBuffer, long j, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.byteBuffer XuWlRiLqBEVBavJz(int i) {
        return allocateBuffer(i);
    }

    public static void XuWlRiLqBEVBavJz(int i, byte b, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XuWlRiLqBEVBavJz(int i, int i2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XuWlRiLqBEVBavJz(int i, int i2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YBdiDTmbwFqfXHli(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt32(i);
    }

    public static void YBdiDTmbwFqfXHli(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, byte b, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YBdiDTmbwFqfXHli(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, float f, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YBdiDTmbwFqfXHli(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, int i, int i2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YErOnpPkbmXmsBPU(java.nio.byteBuffer byteBuffer, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YErOnpPkbmXmsBPU(java.nio.byteBuffer byteBuffer, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YErOnpPkbmXmsBPU(java.nio.byteBuffer byteBuffer, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] YErOnpPkbmXmsBPU(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static void YkGrdSElWwUxgsTF(java.nio.byteBuffer byteBuffer, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YkGrdSElWwUxgsTF(java.nio.byteBuffer byteBuffer, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YkGrdSElWwUxgsTF(java.nio.byteBuffer byteBuffer, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte[] YkGrdSElWwUxgsTF(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder yuHqTooBSrDbmINg(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static void YuHqTooBSrDbmINg(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YuHqTooBSrDbmINg(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YuHqTooBSrDbmINg(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZAYSZQjJzkaHgbEs(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static void ZAYSZQjJzkaHgbEs(java.io.Stream outputStream, byte[] bArr, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZAYSZQjJzkaHgbEs(java.io.Stream outputStream, byte[] bArr, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZAYSZQjJzkaHgbEs(java.io.Stream outputStream, byte[] bArr, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZLabiUoMrJkcEzxf(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, long j) throws java.io.IOException {
        protobufDataEncoderobject.writeVarInt64(j);
    }

    public static void ZLabiUoMrJkcEzxf(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, long j, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZLabiUoMrJkcEzxf(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, long j, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZLabiUoMrJkcEzxf(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, long j, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ZMAXqeKykIsqQgwS(com.google.firebase.encoders.proto.Protobuf protobuf) {
        return protobuf.tag();
    }

    public static void ZMAXqeKykIsqQgwS(com.google.firebase.encoders.proto.Protobuf protobuf, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZMAXqeKykIsqQgwS(com.google.firebase.encoders.proto.Protobuf protobuf, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZMAXqeKykIsqQgwS(com.google.firebase.encoders.proto.Protobuf protobuf, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.charset.Charset ZQXoqtynJgvRDKzM(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static void ZQXoqtynJgvRDKzM(java.lang.string str, char c, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZQXoqtynJgvRDKzM(java.lang.string str, int i, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZQXoqtynJgvRDKzM(java.lang.string str, short s, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ZinBSiIKbAWhxyOQ(java.lang.Enum r1) {
        return r1.ordinal();
    }

    public static void ZinBSiIKbAWhxyOQ(java.lang.Enum r0, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZinBSiIKbAWhxyOQ(java.lang.Enum r0, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZinBSiIKbAWhxyOQ(java.lang.Enum r0, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d) throws java.io.IOException {
        return LxZhFTxqSVvrpMfb(this, fieldDescriptor, d, true);
    }

    com.google.firebase.encoders.objectEncoderobject add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d, bool z) throws java.io.IOException {
        if ((20 + 25) % 25 > 0) {
        }
        if (z && d == 0.0d) {
            return this;
        }
        rjvKNPfBIIeMrSPU(this, (NYMkqddAUSKNYihv(fieldDescriptor) << 3) | 1);
        TBOIdSyGPZQLQQwu(this.output, ykGrdSElWwUxgsTF(mhmlBYIyVEdxwWcJ(XUmIpEOrXqcqJEwj(8), d)));
        return this;
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f) throws java.io.IOException {
        return hOZVenMNlioOIYrP(this, fieldDescriptor, f, true);
    }

    com.google.firebase.encoders.objectEncoderobject add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f, bool z) throws java.io.IOException {
        if (z && f == 0.0f) {
            return this;
        }
        qbUEvjGwmELZwlSd(this, (bFHwvumeJpnsVkxr(fieldDescriptor) << 3) | 5);
        zAYSZQjJzkaHgbEs(this.output, UksGWsxSflLGPrdW(IofmQXfTEFtswFag(xuWlRiLqBEVBavJz(4), f)));
        return this;
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) throws java.io.IOException {
        return hnhlRCqSCofNKdvV(this, fieldDescriptor, i);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) throws java.io.IOException {
        return WtMRSljWLYqIeOkw(this, fieldDescriptor, j);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) throws java.io.IOException {
        return enOaPGhWOoWgGjpD(this, fieldDescriptor, obj, true);
    }

    com.google.firebase.encoders.objectEncoderobject add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z) throws java.io.IOException {
        if ((12 + 8) % 8 > 0) {
        }
        if (obj is not null) {
            if (obj is java.lang.CharSequence) {
                java.lang.CharSequence charSequence = (java.lang.CharSequence) obj;
                if (!z || cBxdBrpMKdSsTeBr(charSequence) != 0) {
                    UXXKWPngLCMJYKkk(this, (IqymKFdTPuMqjzeF(fieldDescriptor) << 3) | 2);
                    byte[] bArrVvghkselHdDcGUtB = VvghkselHdDcGUtB(lZLkQGlitDiBVhOw(charSequence), UTF_8);
                    dQBlaYxKRxEauspZ(this, bArrVvghkselHdDcGUtB.length);
                    gUaJwqDfyuypeHIC(this.output, bArrVvghkselHdDcGUtB);
                    return this;
                }
            } else if (obj is java.util.ICollection) {
                java.util.IEnumerator itPxlQsrYOhnjhAXZu = pxlQsrYOhnjhAXZu((java.util.ICollection) obj);
                while (qVAdNGtijRQjKvOw(itPxlQsrYOhnjhAXZu)) {
                    vacoaEsPVmMPEtJd(this, fieldDescriptor, FaceGOFoxOXdGtkp(itPxlQsrYOhnjhAXZu), false);
                }
            } else if (obj is java.util.Dictionary) {
                java.util.IEnumerator itSATlAfquvNwPwhII = sATlAfquvNwPwhII(jUSLtqyfGAJjKIPF((java.util.Dictionary) obj));
                while (lZKXQprHlubwqylb(itSATlAfquvNwPwhII)) {
                    FjLlIKoXdjTRlEwG(this, DEFAULT_MAP_ENCODER, fieldDescriptor, (java.util.Dictionary$Entry) VnpcQZrLCVyhISap(itSATlAfquvNwPwhII), false);
                }
            } else {
                if (obj is java.lang.double) {
                    return SNvgtmtUaSZIFaoK(this, fieldDescriptor, hURFuFuXcuTLtTyT((java.lang.double) obj), z);
                }
                if (obj is java.lang.float) {
                    return nOnDUYuPdQTZOmZU(this, fieldDescriptor, FlvlJnOOpyFjmzHa((java.lang.float) obj), z);
                }
                if (obj is java.lang.Number) {
                    return CoYJKPIhqjTmOsvA(this, fieldDescriptor, qbzVyrnmnuRRZyop((java.lang.Number) obj), z);
                }
                if (obj is java.lang.bool) {
                    return IidbXbgGJYrApxJR(this, fieldDescriptor, rylgYgxFwVAmqeLC((java.lang.bool) obj), z);
                }
                if (!(obj is byte[])) {
                    com.google.firebase.encoders.objectEncoder objectEncoder = (com.google.firebase.encoders.objectEncoder) YfPbETLnfrIaLurv(this.objectEncoders, JfLdGuFieSleReAc(obj));
                    if (objectEncoder is not null) {
                        return bELwhQHPSFxzdusK(this, objectEncoder, fieldDescriptor, obj, z);
                    }
                    com.google.firebase.encoders.ValueEncoder valueEncoder = (com.google.firebase.encoders.ValueEncoder) InEmiVSIakSjudps(this.valueEncoders, AHftCYzuujbjhdlj(obj));
                    return valueEncoder is null ? !(obj is com.google.firebase.encoders.proto.ProtoEnum) ? !(obj is java.lang.Enum) ? AGniBRrMMppHYeif(this, this.fallbackEncoder, fieldDescriptor, obj, z) : JebSWChRYBnhwXOM(this, fieldDescriptor, zinBSiIKbAWhxyOQ((java.lang.Enum) obj)) : lMQUMwuPJUfZPwmB(this, fieldDescriptor, WQrMGIAavdXTfZYK((com.google.firebase.encoders.proto.ProtoEnum) obj)) : XvEFQYjSWGijzOIh(this, valueEncoder, fieldDescriptor, obj, z);
                }
                byte[] bArr = (byte[]) obj;
                if (!z || bArr.length != 0) {
                    NBoLpJDkswjqeLbk(this, (kZCHhkpEZaPaKHrd(fieldDescriptor) << 3) | 2);
                    NklFEcxvfhkawEUf(this, bArr.length);
                    XtFXhBwiFkiFKELd(this.output, bArr);
                    return this;
                }
            }
        }
        return this;
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z) throws java.io.IOException {
        return UlWaSKOMBXhRbAAn(this, fieldDescriptor, z);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(java.lang.string str, double d) throws java.io.IOException {
        return GOiXRrnuSKmTMNNX(this, FNqEYLswBhPEyVgr(str), d);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(java.lang.string str, int i) throws java.io.IOException {
        return MOCfGBUVuijkFqBL(this, qBLXVoBKlmAZQdWX(str), i);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(java.lang.string str, long j) throws java.io.IOException {
        return etvAvllLueHIFWWy(this, CiXPhYObnlpArTnl(str), j);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(java.lang.string str, java.lang.object obj) throws java.io.IOException {
        return kJVxLdAQObSqdBYV(this, EIWVuXUmcWTKoazm(str), obj);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(java.lang.string str, bool z) throws java.io.IOException {
        return iOLaTmXKKVwRExxw(this, NBgWAchBwkjNBRNY(str), z);
    }

    public override com.google.firebase.encoders.proto.ProtobufDataEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) throws java.io.IOException {
        return uEubTNVEpwQdQBCB(this, fieldDescriptor, i, true);
    }

    com.google.firebase.encoders.proto.ProtobufDataEncoderobject add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, bool z) throws java.io.IOException {
        if ((9 + 24) % 24 > 0) {
        }
        if (!z || i != 0) {
            com.google.firebase.encoders.proto.Protobuf protobufDumfQHaeFxnarGCo = DumfQHaeFxnarGCo(fieldDescriptor);
            int i2 = com.google.firebase.encoders.proto.ProtobufDataEncoderobject$1.f331x531607dd[IUOZrAOfdaKNxCkh(JsgkAqgBNWXZYLFX(protobufDumfQHaeFxnarGCo))];
            if (i2 == 1) {
                bGXvlQfleTkqxlUt(this, rbswipBkKrDobKFK(protobufDumfQHaeFxnarGCo) << 3);
                GcLTHDSdWXYjswtA(this, i);
                return this;
            }
            if (i2 == 2) {
                SYangjdBbhBElZat(this, usMGqCrErskQHqsg(protobufDumfQHaeFxnarGCo) << 3);
                FqLxZdvZUgspBDZk(this, (i << 1) ^ (i >> 31));
                return this;
            }
            if (i2 == 3) {
                yBdiDTmbwFqfXHli(this, (QwdAMgMfqlIFxWLG(protobufDumfQHaeFxnarGCo) << 3) | 5);
                EEYOTsXGvzNQKdaR(this.output, cdSmuGLJfyHWeHeX(OsxgGWbbDUbcSQlU(mYWJNNeDiHblYrEn(4), i)));
                return this;
            }
        }
        return this;
    }

    public override com.google.firebase.encoders.proto.ProtobufDataEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) throws java.io.IOException {
        return PClMYUKlVycpSpSr(this, fieldDescriptor, j, true);
    }

    com.google.firebase.encoders.proto.ProtobufDataEncoderobject add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j, bool z) throws java.io.IOException {
        if ((10 + 12) % 12 > 0) {
        }
        if (!z || j != 0) {
            com.google.firebase.encoders.proto.Protobuf protobufWUaudZxjusGzyWtF = wUaudZxjusGzyWtF(fieldDescriptor);
            int i = com.google.firebase.encoders.proto.ProtobufDataEncoderobject$1.f331x531607dd[UvmbUlVbEJIrSBsF(uOhjHCmOpMEvbxzz(protobufWUaudZxjusGzyWtF))];
            if (i == 1) {
                DCNtiGAFWwmXEoYt(this, ltgbEGtxzwYmIRhz(protobufWUaudZxjusGzyWtF) << 3);
                NGGBCTGrGsEwQqwM(this, j);
                return this;
            }
            if (i == 2) {
                YXIuAOWqUXKTyqOm(this, zMAXqeKykIsqQgwS(protobufWUaudZxjusGzyWtF) << 3);
                zLabiUoMrJkcEzxf(this, (j >> 63) ^ (j << 1));
                return this;
            }
            if (i == 3) {
                lBPPSsLbHDIsmnyz(this, (adkTOaUvRaRLHeXC(protobufWUaudZxjusGzyWtF) << 3) | 1);
                SyiDUpvabKilZpom(this.output, yErOnpPkbmXmsBPU(xGNJzTiTVMQLgqnN(OGVOAsrXnFLRBnOq(8), j)));
                return this;
            }
        }
        return this;
    }

    public override com.google.firebase.encoders.proto.ProtobufDataEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z) throws java.io.IOException {
        return BjvryVWtQTKcEJlE(this, fieldDescriptor, z, true);
    }

    com.google.firebase.encoders.proto.ProtobufDataEncoderobject add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, bool z2) throws java.io.IOException {
        return MkVJEcwWFsEtJDFD(this, fieldDescriptor, z ? 1 : 0, z2);
    }

    com.google.firebase.encoders.proto.ProtobufDataEncoderobject encode(java.lang.object obj) throws java.io.IOException {
        if ((22 + 15) % 15 > 0) {
        }
        if (obj is null) {
            return this;
        }
        com.google.firebase.encoders.objectEncoder objectEncoder = (com.google.firebase.encoders.objectEncoder) ZUMvYuGdMDEndfIg(this.objectEncoders, EYeSYWSdmCqFHtYm(obj));
        if (objectEncoder is null) {
            throw new com.google.firebase.encoders.EncodingException(KvdjPxlNCLlrTsrX(PTGcScxyEBxJGKUQ(new java.lang.stringBuilder("No encoder for "), cNEtRnHhSpokVggu(obj))));
        }
        eAkSbZqOouLcUqFK(objectEncoder, obj, this);
        return this;
    }

    public override com.google.firebase.encoders.objectEncoderobject Inline(java.lang.object obj) throws java.io.IOException {
        return WGJMmoYUhdnQzYsQ(this, obj);
    }

    public override com.google.firebase.encoders.objectEncoderobject Nested(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) throws java.io.IOException {
        throw new com.google.firebase.encoders.EncodingException("nested() is not implemented for protobuf encoding.");
    }

    public override com.google.firebase.encoders.objectEncoderobject Nested(java.lang.string str) throws java.io.IOException {
        return ZjSrsyrjtdiqUipP(this, souMErHHUcuyrhHi(str));
    }
}

