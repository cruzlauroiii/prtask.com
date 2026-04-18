namespace WillowMaze.Wasm.Decompiled;


readonly class JsonValueobjectEncoderobject : com.google.firebase.encoders.objectEncoderobject, com.google.firebase.encoders.ValueEncoderobject {
    private readonly com.google.firebase.encoders.objectEncoder<java.lang.object> fallbackEncoder;
    private readonly bool ignoreNullValues;
    private readonly android.util.JsonWriter jsonWriter;
    private readonly java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.objectEncoder<object>> objectEncoders;
    private readonly java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.ValueEncoder<object>> valueEncoders;
    private com.google.firebase.encoders.json.JsonValueobjectEncoderobject childobject = null;
    private bool active = true;

    private JsonValueobjectEncoderobject(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) {
        this.jsonWriter = jsonValueobjectEncoderobject.jsonWriter;
        this.objectEncoders = jsonValueobjectEncoderobject.objectEncoders;
        this.valueEncoders = jsonValueobjectEncoderobject.valueEncoders;
        this.fallbackEncoder = jsonValueobjectEncoderobject.fallbackEncoder;
        this.ignoreNullValues = jsonValueobjectEncoderobject.ignoreNullValues;
    }

    JsonValueobjectEncoderobject(java.io.Writer writer, java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.objectEncoder<object>> map, java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.ValueEncoder<object>> map2, com.google.firebase.encoders.objectEncoder<java.lang.object> objectEncoder, bool z) {
        this.jsonWriter = new android.util.JsonWriter(writer);
        this.objectEncoders = map;
        this.valueEncoders = map2;
        this.fallbackEncoder = objectEncoder;
        this.ignoreNullValues = z;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject AvPmsToNnLXIOHhZ(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, bool z) {
        return jsonValueobjectEncoderobject.Add(str, z);
    }

    public static void AvPmsToNnLXIOHhZ(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, bool z, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AvPmsToNnLXIOHhZ(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, bool z, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AvPmsToNnLXIOHhZ(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, bool z, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject BGODSqpVuEyhkvpt(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z) {
        return jsonValueobjectEncoderobject.Add(obj, z);
    }

    public static void BGODSqpVuEyhkvpt(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, int i, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void BGODSqpVuEyhkvpt(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, short s, byte b, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BGODSqpVuEyhkvpt(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, short s, bool z2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BtHUTNFSRPQfXWbh(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void BtHUTNFSRPQfXWbh(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BtHUTNFSRPQfXWbh(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BtHUTNFSRPQfXWbh(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject CFcOFwSvMHPgkYnB(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte[] bArr) {
        return jsonValueobjectEncoderobject.Add(bArr);
    }

    public static void CFcOFwSvMHPgkYnB(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte[] bArr, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CFcOFwSvMHPgkYnB(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte[] bArr, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CFcOFwSvMHPgkYnB(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte[] bArr, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter CGkTPSdjcLqKFvPE(android.util.JsonWriter jsonWriter) {
        return jsonWriter.beginobject();
    }

    public static void CGkTPSdjcLqKFvPE(android.util.JsonWriter jsonWriter, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CGkTPSdjcLqKFvPE(android.util.JsonWriter jsonWriter, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CGkTPSdjcLqKFvPE(android.util.JsonWriter jsonWriter, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter DFGKwLUHfitMLAvB(android.util.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static void DFGKwLUHfitMLAvB(android.util.JsonWriter jsonWriter, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DFGKwLUHfitMLAvB(android.util.JsonWriter jsonWriter, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DFGKwLUHfitMLAvB(android.util.JsonWriter jsonWriter, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter EFbdMKgRkWzpzCkJ(android.util.JsonWriter jsonWriter) {
        return jsonWriter.beginArray();
    }

    public static void EFbdMKgRkWzpzCkJ(android.util.JsonWriter jsonWriter, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EFbdMKgRkWzpzCkJ(android.util.JsonWriter jsonWriter, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EFbdMKgRkWzpzCkJ(android.util.JsonWriter jsonWriter, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject EKKuDwSmOBDdEgJP(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, long j) {
        return jsonValueobjectEncoderobject.Add(j);
    }

    public static void EKKuDwSmOBDdEgJP(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, long j, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EKKuDwSmOBDdEgJP(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, long j, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EKKuDwSmOBDdEgJP(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, long j, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject FOqfjAokqZmayJmm(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z) {
        return jsonValueobjectEncoderobject.Add(obj, z);
    }

    public static void FOqfjAokqZmayJmm(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FOqfjAokqZmayJmm(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FOqfjAokqZmayJmm(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject FQZuFvzAOzEbGMyK(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, bool z) {
        return jsonValueobjectEncoderobject.doEncode(objectEncoder, obj, z);
    }

    public static void FQZuFvzAOzEbGMyK(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, bool z, int i, char c, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FQZuFvzAOzEbGMyK(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, bool z, int i, java.lang.string str, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FQZuFvzAOzEbGMyK(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, bool z, bool z2, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter FfAWAmcGZGjRyaMb(android.util.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.name(str);
    }

    public static void FfAWAmcGZGjRyaMb(android.util.JsonWriter jsonWriter, java.lang.string str, int i, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FfAWAmcGZGjRyaMb(android.util.JsonWriter jsonWriter, java.lang.string str, int i, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FfAWAmcGZGjRyaMb(android.util.JsonWriter jsonWriter, java.lang.string str, short s, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FxxbUcvvBgMirxLU(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void FxxbUcvvBgMirxLU(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FxxbUcvvBgMirxLU(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FxxbUcvvBgMirxLU(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GEMfEwHlwJsUuetG(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void GEMfEwHlwJsUuetG(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GEMfEwHlwJsUuetG(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GEMfEwHlwJsUuetG(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject HXyAIyrzUIQqVIeg(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, long j) {
        return jsonValueobjectEncoderobject.Add(j);
    }

    public static void HXyAIyrzUIQqVIeg(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, long j, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HXyAIyrzUIQqVIeg(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, long j, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HXyAIyrzUIQqVIeg(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, long j, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HYLCaToDEeMBUyqc(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void HYLCaToDEeMBUyqc(java.util.Dictionary$Entry map$Entry, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HYLCaToDEeMBUyqc(java.util.Dictionary$Entry map$Entry, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HYLCaToDEeMBUyqc(java.util.Dictionary$Entry map$Entry, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HhfkMOSxmjGGGBJr(java.lang.Class cls, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HhfkMOSxmjGGGBJr(java.lang.Class cls, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HhfkMOSxmjGGGBJr(java.lang.Class cls, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool HhfkMOSxmjGGGBJr(java.lang.Class cls) {
        return cls.isArray();
    }

    public static java.lang.string HvLboVkfMWvrcCvj(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static void HvLboVkfMWvrcCvj(byte[] bArr, int i, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HvLboVkfMWvrcCvj(byte[] bArr, int i, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HvLboVkfMWvrcCvj(byte[] bArr, int i, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter IoHApofushrDrxFC(android.util.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static void IoHApofushrDrxFC(android.util.JsonWriter jsonWriter, java.lang.string str, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IoHApofushrDrxFC(android.util.JsonWriter jsonWriter, java.lang.string str, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IoHApofushrDrxFC(android.util.JsonWriter jsonWriter, java.lang.string str, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject IyfWLHulWhNRkahF(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z) {
        return jsonValueobjectEncoderobject.Add(obj, z);
    }

    public static void IyfWLHulWhNRkahF(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, byte b, int i, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void IyfWLHulWhNRkahF(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, float f, byte b, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IyfWLHulWhNRkahF(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, int i, bool z2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LMUcdlyALZOPaFhz(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void LMUcdlyALZOPaFhz(java.util.Dictionary map, java.lang.object obj, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LMUcdlyALZOPaFhz(java.util.Dictionary map, java.lang.object obj, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LMUcdlyALZOPaFhz(java.util.Dictionary map, java.lang.object obj, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject MEKOSfPIiQyPHwVD(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str) {
        return jsonValueobjectEncoderobject.Add(str);
    }

    public static void MEKOSfPIiQyPHwVD(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, char c, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MEKOSfPIiQyPHwVD(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, float f, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MEKOSfPIiQyPHwVD(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.string str2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject MJyBckZCHNpciLmT(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, bool z) {
        return jsonValueobjectEncoderobject.doEncode(objectEncoder, obj, z);
    }

    public static void MJyBckZCHNpciLmT(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, bool z, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MJyBckZCHNpciLmT(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, bool z, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MJyBckZCHNpciLmT(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, bool z, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MKuuDGHLELmTzZmh(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return fieldDescriptor.getName();
    }

    public static void MKuuDGHLELmTzZmh(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MKuuDGHLELmTzZmh(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MKuuDGHLELmTzZmh(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MPoEvIqlXgmUtzfP(java.lang.Enum r1) {
        return r1.name();
    }

    public static void MPoEvIqlXgmUtzfP(java.lang.Enum r0, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MPoEvIqlXgmUtzfP(java.lang.Enum r0, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MPoEvIqlXgmUtzfP(java.lang.Enum r0, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter NKYYQLLpUKRpnoUr(android.util.JsonWriter jsonWriter, double d) {
        return jsonWriter.value(d);
    }

    public static void NKYYQLLpUKRpnoUr(android.util.JsonWriter jsonWriter, double d, char c, int i, short s, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void NKYYQLLpUKRpnoUr(android.util.JsonWriter jsonWriter, double d, int i, short s, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void NKYYQLLpUKRpnoUr(android.util.JsonWriter jsonWriter, double d, java.lang.string str, short s, int i, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static android.util.JsonWriter NdmglnnrIrEkQUVv(android.util.JsonWriter jsonWriter) {
        return jsonWriter.endArray();
    }

    public static void NdmglnnrIrEkQUVv(android.util.JsonWriter jsonWriter, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NdmglnnrIrEkQUVv(android.util.JsonWriter jsonWriter, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NdmglnnrIrEkQUVv(android.util.JsonWriter jsonWriter, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NecnIBmETzsYfJMB(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return fieldDescriptor.getName();
    }

    public static void NecnIBmETzsYfJMB(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NecnIBmETzsYfJMB(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NecnIBmETzsYfJMB(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int NfcoODTJrEmgbPIl(com.google.firebase.encoders.json.NumberedEnum numberedEnum) {
        return numberedEnum.getNumber();
    }

    public static void NfcoODTJrEmgbPIl(com.google.firebase.encoders.json.NumberedEnum numberedEnum, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NfcoODTJrEmgbPIl(com.google.firebase.encoders.json.NumberedEnum numberedEnum, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NfcoODTJrEmgbPIl(com.google.firebase.encoders.json.NumberedEnum numberedEnum, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject OGGCUWMflzBaGZjr(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, long j) {
        return jsonValueobjectEncoderobject.Add(str, j);
    }

    public static void OGGCUWMflzBaGZjr(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, long j, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OGGCUWMflzBaGZjr(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, long j, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OGGCUWMflzBaGZjr(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, long j, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class OojGVkoqaYMDGxcR(java.lang.object obj) {
        return obj.GetType();
    }

    public static void OojGVkoqaYMDGxcR(java.lang.object obj, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OojGVkoqaYMDGxcR(java.lang.object obj, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OojGVkoqaYMDGxcR(java.lang.object obj, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PlBcrctxEWLWYFlh(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void PlBcrctxEWLWYFlh(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PlBcrctxEWLWYFlh(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PlBcrctxEWLWYFlh(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject QFijMzqbTgwNpeTv(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z) {
        return jsonValueobjectEncoderobject.Add(obj, z);
    }

    public static void QFijMzqbTgwNpeTv(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QFijMzqbTgwNpeTv(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QFijMzqbTgwNpeTv(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject QxLflhnjIGrmDylQ(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, long j) {
        return jsonValueobjectEncoderobject.Add(j);
    }

    public static void QxLflhnjIGrmDylQ(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, long j, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QxLflhnjIGrmDylQ(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, long j, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QxLflhnjIGrmDylQ(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, long j, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject RgcyUuxqujZFMpiM(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str) {
        return jsonValueobjectEncoderobject.Add(str);
    }

    public static void RgcyUuxqujZFMpiM(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, int i, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RgcyUuxqujZFMpiM(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.string str2, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RgcyUuxqujZFMpiM(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.string str2, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RycelghzAImQymWP(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void RycelghzAImQymWP(java.util.Dictionary map, java.lang.object obj, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RycelghzAImQymWP(java.util.Dictionary map, java.lang.object obj, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RycelghzAImQymWP(java.util.Dictionary map, java.lang.object obj, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator SJmjxwxEWxOpnCrX(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void SJmjxwxEWxOpnCrX(java.util.HashSet set, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SJmjxwxEWxOpnCrX(java.util.HashSet set, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SJmjxwxEWxOpnCrX(java.util.HashSet set, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject SLsDdvAFglkrEYiX(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj) {
        return jsonValueobjectEncoderobject.Add(str, obj);
    }

    public static void SLsDdvAFglkrEYiX(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, float f, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SLsDdvAFglkrEYiX(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, java.lang.string str2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SLsDdvAFglkrEYiX(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, java.lang.string str2, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class SaphGgxJhDxgPNqe(java.lang.object obj) {
        return obj.GetType();
    }

    public static void SaphGgxJhDxgPNqe(java.lang.object obj, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SaphGgxJhDxgPNqe(java.lang.object obj, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SaphGgxJhDxgPNqe(java.lang.object obj, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class TdoHpgSoqRsYEoyQ(java.lang.object obj) {
        return obj.GetType();
    }

    public static void TdoHpgSoqRsYEoyQ(java.lang.object obj, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TdoHpgSoqRsYEoyQ(java.lang.object obj, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TdoHpgSoqRsYEoyQ(java.lang.object obj, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TtbKDZCFRVZMlREZ(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void TtbKDZCFRVZMlREZ(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TtbKDZCFRVZMlREZ(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TtbKDZCFRVZMlREZ(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class UMarBrdOwCvqOWCx(java.lang.object obj) {
        return obj.GetType();
    }

    public static void UMarBrdOwCvqOWCx(java.lang.object obj, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UMarBrdOwCvqOWCx(java.lang.object obj, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UMarBrdOwCvqOWCx(java.lang.object obj, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UWMXZqHDUwbpGATp(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void UWMXZqHDUwbpGATp(java.util.IEnumerator it, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UWMXZqHDUwbpGATp(java.util.IEnumerator it, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UWMXZqHDUwbpGATp(java.util.IEnumerator it, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class UennHIXkxLMnRxns(java.lang.object obj) {
        return obj.GetType();
    }

    public static void UennHIXkxLMnRxns(java.lang.object obj, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UennHIXkxLMnRxns(java.lang.object obj, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UennHIXkxLMnRxns(java.lang.object obj, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WAjynJzzbaaUPSdC(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void WAjynJzzbaaUPSdC(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WAjynJzzbaaUPSdC(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WAjynJzzbaaUPSdC(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter WIFOylVDLqRgFAuw(android.util.JsonWriter jsonWriter, long j) {
        return jsonWriter.value(j);
    }

    public static void WIFOylVDLqRgFAuw(android.util.JsonWriter jsonWriter, long j, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WIFOylVDLqRgFAuw(android.util.JsonWriter jsonWriter, long j, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WIFOylVDLqRgFAuw(android.util.JsonWriter jsonWriter, long j, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter XVfDEYdIwLvXBDhq(android.util.JsonWriter jsonWriter, double d) {
        return jsonWriter.value(d);
    }

    public static void XVfDEYdIwLvXBDhq(android.util.JsonWriter jsonWriter, double d, java.lang.string str, int i, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void XVfDEYdIwLvXBDhq(android.util.JsonWriter jsonWriter, double d, java.lang.string str, bool z, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void XVfDEYdIwLvXBDhq(android.util.JsonWriter jsonWriter, double d, bool z, byte b, int i, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static android.util.JsonWriter XcrjdLCrWtRflmEX(android.util.JsonWriter jsonWriter, long j) {
        return jsonWriter.value(j);
    }

    public static void XcrjdLCrWtRflmEX(android.util.JsonWriter jsonWriter, long j, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XcrjdLCrWtRflmEX(android.util.JsonWriter jsonWriter, long j, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XcrjdLCrWtRflmEX(android.util.JsonWriter jsonWriter, long j, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter XtQHVZUdFtaDFaIa(android.util.JsonWriter jsonWriter, bool z) {
        return jsonWriter.value(z);
    }

    public static void XtQHVZUdFtaDFaIa(android.util.JsonWriter jsonWriter, bool z, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XtQHVZUdFtaDFaIa(android.util.JsonWriter jsonWriter, bool z, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XtQHVZUdFtaDFaIa(android.util.JsonWriter jsonWriter, bool z, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject YRdPKfAKbjmcADwl(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj) {
        return jsonValueobjectEncoderobject.Add(str, obj);
    }

    public static void YRdPKfAKbjmcADwl(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, char c, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YRdPKfAKbjmcADwl(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, char c, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YRdPKfAKbjmcADwl(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, java.lang.string str2, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter ZESlqNytoltPOIaa(android.util.JsonWriter jsonWriter, java.lang.Number number) {
        return jsonWriter.value(number);
    }

    public static void ZESlqNytoltPOIaa(android.util.JsonWriter jsonWriter, java.lang.Number number, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZESlqNytoltPOIaa(android.util.JsonWriter jsonWriter, java.lang.Number number, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZESlqNytoltPOIaa(android.util.JsonWriter jsonWriter, java.lang.Number number, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter ZSSmShwzLzfONKyr(android.util.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.name(str);
    }

    public static void ZSSmShwzLzfONKyr(android.util.JsonWriter jsonWriter, java.lang.string str, int i, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZSSmShwzLzfONKyr(android.util.JsonWriter jsonWriter, java.lang.string str, int i, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZSSmShwzLzfONKyr(android.util.JsonWriter jsonWriter, java.lang.string str, java.lang.string str2, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject AZDEZkkxaYuLyiEL(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj) {
        return jsonValueobjectEncoderobject.internalAddIgnoreNullValues(str, obj);
    }

    public static void AZDEZkkxaYuLyiEL(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AZDEZkkxaYuLyiEL(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AZDEZkkxaYuLyiEL(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AhuLxolIzYtaoKoL(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return fieldDescriptor.getName();
    }

    public static void AhuLxolIzYtaoKoL(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AhuLxolIzYtaoKoL(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AhuLxolIzYtaoKoL(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter BkmJEvrnRQbGKzrP(android.util.JsonWriter jsonWriter, long j) {
        return jsonWriter.value(j);
    }

    public static void BkmJEvrnRQbGKzrP(android.util.JsonWriter jsonWriter, long j, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BkmJEvrnRQbGKzrP(android.util.JsonWriter jsonWriter, long j, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BkmJEvrnRQbGKzrP(android.util.JsonWriter jsonWriter, long j, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject CMVqgxTOzrLdvYSj(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj) {
        return jsonValueobjectEncoderobject.internalAdd(str, obj);
    }

    public static void CMVqgxTOzrLdvYSj(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CMVqgxTOzrLdvYSj(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CMVqgxTOzrLdvYSj(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CRvIyfHvCANWwrei(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void CRvIyfHvCANWwrei(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CRvIyfHvCANWwrei(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CRvIyfHvCANWwrei(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void CannotBeInline(java.lang.object obj, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void CannotBeInline(java.lang.object obj, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void CannotBeInline(java.lang.object obj, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private bool CannotBeInline(java.lang.object obj) {
        return obj is null || HhfkMOSxmjGGGBJr(TdoHpgSoqRsYEoyQ(obj)) || (obj is java.util.ICollection) || (obj is java.util.DateTime) || (obj is java.lang.Enum) || (obj is java.lang.Number);
    }

    public static android.util.JsonWriter CbEhFKSyjZLVTePu(android.util.JsonWriter jsonWriter) {
        return jsonWriter.endArray();
    }

    public static void CbEhFKSyjZLVTePu(android.util.JsonWriter jsonWriter, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CbEhFKSyjZLVTePu(android.util.JsonWriter jsonWriter, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CbEhFKSyjZLVTePu(android.util.JsonWriter jsonWriter, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter CsmDAfukyJyjHpjv(android.util.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static void CsmDAfukyJyjHpjv(android.util.JsonWriter jsonWriter, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CsmDAfukyJyjHpjv(android.util.JsonWriter jsonWriter, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CsmDAfukyJyjHpjv(android.util.JsonWriter jsonWriter, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject DRqAQzQZAVIVldHn(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i) {
        return jsonValueobjectEncoderobject.Add(i);
    }

    public static void DRqAQzQZAVIVldHn(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, byte b, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DRqAQzQZAVIVldHn(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DRqAQzQZAVIVldHn(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, java.lang.string str, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject DtBTqVPYHaisFCRY(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f) {
        return jsonValueobjectEncoderobject.Add(f);
    }

    public static void DtBTqVPYHaisFCRY(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, byte b, char c, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void DtBTqVPYHaisFCRY(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, float f2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DtBTqVPYHaisFCRY(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, bool z, char c, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter DzhZJiZlfHvCVDLc(android.util.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.name(str);
    }

    public static void DzhZJiZlfHvCVDLc(android.util.JsonWriter jsonWriter, java.lang.string str, char c, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DzhZJiZlfHvCVDLc(android.util.JsonWriter jsonWriter, java.lang.string str, java.lang.string str2, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DzhZJiZlfHvCVDLc(android.util.JsonWriter jsonWriter, java.lang.string str, bool z, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ECKzshzBtTjbbCxo(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ECKzshzBtTjbbCxo(java.util.IEnumerator it, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ECKzshzBtTjbbCxo(java.util.IEnumerator it, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ECKzshzBtTjbbCxo(java.util.IEnumerator it, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject EzafPMfyblZMNhBu(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i) {
        return jsonValueobjectEncoderobject.Add(i);
    }

    public static void EzafPMfyblZMNhBu(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, byte b, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EzafPMfyblZMNhBu(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, int i2, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EzafPMfyblZMNhBu(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, bool z, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject FQyxyNjXlCbPkIhE(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte[] bArr) {
        return jsonValueobjectEncoderobject.Add(bArr);
    }

    public static void FQyxyNjXlCbPkIhE(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte[] bArr, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FQyxyNjXlCbPkIhE(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte[] bArr, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FQyxyNjXlCbPkIhE(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte[] bArr, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter FgUrWswGKXJndYZB(android.util.JsonWriter jsonWriter) {
        return jsonWriter.endobject();
    }

    public static void FgUrWswGKXJndYZB(android.util.JsonWriter jsonWriter, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FgUrWswGKXJndYZB(android.util.JsonWriter jsonWriter, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FgUrWswGKXJndYZB(android.util.JsonWriter jsonWriter, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject GArleXGqVmppvSFK(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, double d) {
        return jsonValueobjectEncoderobject.Add(d);
    }

    public static void GArleXGqVmppvSFK(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, double d, byte b, int i, short s, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void GArleXGqVmppvSFK(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, double d, int i, short s, java.lang.string str, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void GArleXGqVmppvSFK(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, double d, short s, byte b, int i, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void GRDxVImEKnXIoqWK(android.util.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.flush();
    }

    public static void GRDxVImEKnXIoqWK(android.util.JsonWriter jsonWriter, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GRDxVImEKnXIoqWK(android.util.JsonWriter jsonWriter, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GRDxVImEKnXIoqWK(android.util.JsonWriter jsonWriter, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject HKvKILQjwxGSbqHq(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, bool z) {
        return jsonValueobjectEncoderobject.Add(z);
    }

    public static void HKvKILQjwxGSbqHq(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, bool z, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HKvKILQjwxGSbqHq(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, bool z, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HKvKILQjwxGSbqHq(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, bool z, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject IKDMoUQenCDTltMB(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, int i) {
        return jsonValueobjectEncoderobject.Add(str, i);
    }

    public static void IKDMoUQenCDTltMB(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, int i, byte b, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IKDMoUQenCDTltMB(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, int i, short s, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IKDMoUQenCDTltMB(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, int i, short s, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IULcuiqvmodVZnQO(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2) {
        objectEncoder.encode(obj, obj2);
    }

    public static void IULcuiqvmodVZnQO(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IULcuiqvmodVZnQO(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IULcuiqvmodVZnQO(com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.object obj, java.lang.object obj2, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IUXofmiWUgaVPPXS(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void IUXofmiWUgaVPPXS(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IUXofmiWUgaVPPXS(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IUXofmiWUgaVPPXS(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.encoders.json.JsonValueobjectEncoderobject InternalAdd(java.lang.string str, java.lang.object obj) throws com.google.firebase.encoders.EncodingException, java.io.IOException {
        yOSkNafOaiyHjOrU(this);
        yjRInBGLdQqBQJoj(this.jsonWriter, str);
        if (obj is not null) {
            return IyfWLHulWhNRkahF(this, obj, false);
        }
        nLqfUhfOpyQLqiMT(this.jsonWriter);
        return this;
    }

    private void InternalAdd(java.lang.string str, java.lang.object obj, char c, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void InternalAdd(java.lang.string str, java.lang.object obj, int i, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void InternalAdd(java.lang.string str, java.lang.object obj, bool z, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.encoders.json.JsonValueobjectEncoderobject InternalAddIgnoreNullValues(java.lang.string str, java.lang.object obj) throws com.google.firebase.encoders.EncodingException, java.io.IOException {
        if (obj is null) {
            return this;
        }
        cRvIyfHvCANWwrei(this);
        ZSSmShwzLzfONKyr(this.jsonWriter, str);
        return pKTBRiKSNzOsGWXN(this, obj, false);
    }

    private void InternalAddIgnoreNullValues(java.lang.string str, java.lang.object obj, char c, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void InternalAddIgnoreNullValues(java.lang.string str, java.lang.object obj, float f, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void InternalAddIgnoreNullValues(java.lang.string str, java.lang.object obj, int i, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter IwxsoJKQflEPXTRD(android.util.JsonWriter jsonWriter) {
        return jsonWriter.endobject();
    }

    public static void IwxsoJKQflEPXTRD(android.util.JsonWriter jsonWriter, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IwxsoJKQflEPXTRD(android.util.JsonWriter jsonWriter, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IwxsoJKQflEPXTRD(android.util.JsonWriter jsonWriter, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter JHJmsGyhjRTgCbwu(android.util.JsonWriter jsonWriter, bool z) {
        return jsonWriter.value(z);
    }

    public static void JHJmsGyhjRTgCbwu(android.util.JsonWriter jsonWriter, bool z, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JHJmsGyhjRTgCbwu(android.util.JsonWriter jsonWriter, bool z, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JHJmsGyhjRTgCbwu(android.util.JsonWriter jsonWriter, bool z, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter JQnIydCdscMggfba(android.util.JsonWriter jsonWriter) {
        return jsonWriter.beginArray();
    }

    public static void JQnIydCdscMggfba(android.util.JsonWriter jsonWriter, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JQnIydCdscMggfba(android.util.JsonWriter jsonWriter, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JQnIydCdscMggfba(android.util.JsonWriter jsonWriter, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter JekNmQvqzZqaTzxL(android.util.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static void JekNmQvqzZqaTzxL(android.util.JsonWriter jsonWriter, java.lang.string str, byte b, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JekNmQvqzZqaTzxL(android.util.JsonWriter jsonWriter, java.lang.string str, java.lang.string str2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JekNmQvqzZqaTzxL(android.util.JsonWriter jsonWriter, java.lang.string str, bool z, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter JfmlKELgsKWBJHji(android.util.JsonWriter jsonWriter) {
        return jsonWriter.endobject();
    }

    public static void JfmlKELgsKWBJHji(android.util.JsonWriter jsonWriter, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JfmlKELgsKWBJHji(android.util.JsonWriter jsonWriter, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JfmlKELgsKWBJHji(android.util.JsonWriter jsonWriter, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JhoeucHXwUSKbaxP(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void JhoeucHXwUSKbaxP(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JhoeucHXwUSKbaxP(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JhoeucHXwUSKbaxP(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject KRRKOpniwDSaQJHR(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i) {
        return jsonValueobjectEncoderobject.Add(i);
    }

    public static void KRRKOpniwDSaQJHR(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KRRKOpniwDSaQJHR(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KRRKOpniwDSaQJHR(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KkBjbaHHZowhxzJp(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return fieldDescriptor.getName();
    }

    public static void KkBjbaHHZowhxzJp(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KkBjbaHHZowhxzJp(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KkBjbaHHZowhxzJp(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KtSitxkawHEzczIi(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void KtSitxkawHEzczIi(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KtSitxkawHEzczIi(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KtSitxkawHEzczIi(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KuxMihtJHRTLxcXQ(java.util.IEnumerator it, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KuxMihtJHRTLxcXQ(java.util.IEnumerator it, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KuxMihtJHRTLxcXQ(java.util.IEnumerator it, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KuxMihtJHRTLxcXQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string LGrFQCAGwrEbNkjL(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void LGrFQCAGwrEbNkjL(java.lang.string str, java.lang.object[] objArr, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LGrFQCAGwrEbNkjL(java.lang.string str, java.lang.object[] objArr, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LGrFQCAGwrEbNkjL(java.lang.string str, java.lang.object[] objArr, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LhKvdiNuhuBShotq(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void LhKvdiNuhuBShotq(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LhKvdiNuhuBShotq(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LhKvdiNuhuBShotq(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUnNest() throws java.io.IOException {
        if ((31 + 11) % 11 > 0) {
        }
        if (!this.active) {
            throw new java.lang.IllegalStateException("Parent context used since this context was created. Cannot use this context anymore.");
        }
        com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject = this.childobject;
        if (jsonValueobjectEncoderobject is null) {
            return;
        }
        TtbKDZCFRVZMlREZ(jsonValueobjectEncoderobject);
        this.childobject.active = false;
        this.childobject = null;
        jfmlKELgsKWBJHji(this.jsonWriter);
    }

    private void MaybeUnNest(byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUnNest(byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUnNest(java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject MmRQhgbXoxrOlFtB(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, int i) {
        return jsonValueobjectEncoderobject.Add(str, i);
    }

    public static void MmRQhgbXoxrOlFtB(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, int i, float f, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MmRQhgbXoxrOlFtB(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, int i, java.lang.string str2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MmRQhgbXoxrOlFtB(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, int i, short s, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject NFXTEfKVRiJOKgBP(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, bool z) {
        return jsonValueobjectEncoderobject.Add(str, z);
    }

    public static void NFXTEfKVRiJOKgBP(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, bool z, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NFXTEfKVRiJOKgBP(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, bool z, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NFXTEfKVRiJOKgBP(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, bool z, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter NLqfUhfOpyQLqiMT(android.util.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static void NLqfUhfOpyQLqiMT(android.util.JsonWriter jsonWriter, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NLqfUhfOpyQLqiMT(android.util.JsonWriter jsonWriter, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NLqfUhfOpyQLqiMT(android.util.JsonWriter jsonWriter, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject NmqGmOgKtUUFtCjY(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, double d) {
        return jsonValueobjectEncoderobject.Add(str, d);
    }

    public static void NmqGmOgKtUUFtCjY(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, double d, char c, byte b, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void NmqGmOgKtUUFtCjY(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, double d, char c, bool z, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void NmqGmOgKtUUFtCjY(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, double d, bool z, byte b, int i, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static java.util.IEnumerator NzkFliIzVVvsRdib(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static void NzkFliIzVVvsRdib(java.util.ICollection collection, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NzkFliIzVVvsRdib(java.util.ICollection collection, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NzkFliIzVVvsRdib(java.util.ICollection collection, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject OXDEWFdJbtvsofKS(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, bool z) {
        return jsonValueobjectEncoderobject.Add(z);
    }

    public static void OXDEWFdJbtvsofKS(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, bool z, byte b, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OXDEWFdJbtvsofKS(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, bool z, float f, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OXDEWFdJbtvsofKS(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, bool z, bool z2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PDiCirXELDuQIChO(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return fieldDescriptor.getName();
    }

    public static void PDiCirXELDuQIChO(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PDiCirXELDuQIChO(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PDiCirXELDuQIChO(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject PKTBRiKSNzOsGWXN(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z) {
        return jsonValueobjectEncoderobject.Add(obj, z);
    }

    public static void PKTBRiKSNzOsGWXN(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PKTBRiKSNzOsGWXN(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PKTBRiKSNzOsGWXN(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject PXAIeVfvBjuiVSor(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, double d) {
        return jsonValueobjectEncoderobject.Add(str, d);
    }

    public static void PXAIeVfvBjuiVSor(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, double d, byte b, char c, float f, java.lang.string str2) {
        double d2 = (42 * 210) + 210;
    }

    public static void PXAIeVfvBjuiVSor(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, double d, byte b, java.lang.string str2, float f, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void PXAIeVfvBjuiVSor(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, double d, java.lang.string str2, float f, char c, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static android.util.JsonWriter QJrorgHunlgSgrqX(android.util.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.name(str);
    }

    public static void QJrorgHunlgSgrqX(android.util.JsonWriter jsonWriter, java.lang.string str, byte b, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QJrorgHunlgSgrqX(android.util.JsonWriter jsonWriter, java.lang.string str, char c, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QJrorgHunlgSgrqX(android.util.JsonWriter jsonWriter, java.lang.string str, java.lang.string str2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject QUJQCynpjJBTXbgc(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, double d) {
        return jsonValueobjectEncoderobject.Add(str, d);
    }

    public static void QUJQCynpjJBTXbgc(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, double d, char c, float f, int i, java.lang.string str2) {
        double d2 = (42 * 210) + 210;
    }

    public static void QUJQCynpjJBTXbgc(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, double d, float f, char c, int i, java.lang.string str2) {
        double d2 = (42 * 210) + 210;
    }

    public static void QUJQCynpjJBTXbgc(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, double d, int i, char c, float f, java.lang.string str2) {
        double d2 = (42 * 210) + 210;
    }

    public static void QWmKaPzVRKdyrahy(java.util.IEnumerator it, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QWmKaPzVRKdyrahy(java.util.IEnumerator it, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QWmKaPzVRKdyrahy(java.util.IEnumerator it, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool QWmKaPzVRKdyrahy(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.util.JsonWriter RrCKbFYpTvzogZQl(android.util.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.name(str);
    }

    public static void RrCKbFYpTvzogZQl(android.util.JsonWriter jsonWriter, java.lang.string str, java.lang.string str2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RrCKbFYpTvzogZQl(android.util.JsonWriter jsonWriter, java.lang.string str, java.lang.string str2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RrCKbFYpTvzogZQl(android.util.JsonWriter jsonWriter, java.lang.string str, bool z, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter RvUQNmmbExBAYMmm(android.util.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.name(str);
    }

    public static void RvUQNmmbExBAYMmm(android.util.JsonWriter jsonWriter, java.lang.string str, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RvUQNmmbExBAYMmm(android.util.JsonWriter jsonWriter, java.lang.string str, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RvUQNmmbExBAYMmm(android.util.JsonWriter jsonWriter, java.lang.string str, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class SQJaHUlLLZoKalmO(java.lang.object obj) {
        return obj.GetType();
    }

    public static void SQJaHUlLLZoKalmO(java.lang.object obj, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SQJaHUlLLZoKalmO(java.lang.object obj, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SQJaHUlLLZoKalmO(java.lang.object obj, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SRJlsKJIwHtDfgkz(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void SRJlsKJIwHtDfgkz(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SRJlsKJIwHtDfgkz(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SRJlsKJIwHtDfgkz(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject SjFTixrvsDKLALLt(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, double d) {
        return jsonValueobjectEncoderobject.Add(d);
    }

    public static void SjFTixrvsDKLALLt(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, double d, char c, bool z, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void SjFTixrvsDKLALLt(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, double d, java.lang.string str, bool z, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void SjFTixrvsDKLALLt(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, double d, bool z, float f, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void StlSeLjDFtKtUVHw(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void StlSeLjDFtKtUVHw(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void StlSeLjDFtKtUVHw(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool StlSeLjDFtKtUVHw(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj) {
        return jsonValueobjectEncoderobject.cannotBeInline(obj);
    }

    public static void SzYnDGDXfCdMBQFi(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void SzYnDGDXfCdMBQFi(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SzYnDGDXfCdMBQFi(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SzYnDGDXfCdMBQFi(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter TFCPgPzekyoLrvcU(android.util.JsonWriter jsonWriter) {
        return jsonWriter.beginobject();
    }

    public static void TFCPgPzekyoLrvcU(android.util.JsonWriter jsonWriter, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TFCPgPzekyoLrvcU(android.util.JsonWriter jsonWriter, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TFCPgPzekyoLrvcU(android.util.JsonWriter jsonWriter, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TIXvRIADuHLWdgxM(java.lang.Class cls, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TIXvRIADuHLWdgxM(java.lang.Class cls, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TIXvRIADuHLWdgxM(java.lang.Class cls, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool TIXvRIADuHLWdgxM(java.lang.Class cls) {
        return cls.isArray();
    }

    public static void TIfTlmyGdoGHZzig(com.google.firebase.encoders.ValueEncoder valueEncoder, java.lang.object obj, java.lang.object obj2) {
        valueEncoder.encode(obj, obj2);
    }

    public static void TIfTlmyGdoGHZzig(com.google.firebase.encoders.ValueEncoder valueEncoder, java.lang.object obj, java.lang.object obj2, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TIfTlmyGdoGHZzig(com.google.firebase.encoders.ValueEncoder valueEncoder, java.lang.object obj, java.lang.object obj2, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TIfTlmyGdoGHZzig(com.google.firebase.encoders.ValueEncoder valueEncoder, java.lang.object obj, java.lang.object obj2, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject TXclMoYgExmHSLBU(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z) {
        return jsonValueobjectEncoderobject.Add(obj, z);
    }

    public static void TXclMoYgExmHSLBU(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, char c, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void TXclMoYgExmHSLBU(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, char c, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void TXclMoYgExmHSLBU(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.object obj, bool z, bool z2, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TodGegXVtRaEYXBd(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void TodGegXVtRaEYXBd(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TodGegXVtRaEYXBd(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TodGegXVtRaEYXBd(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject TzRegEcqxEmaAndy(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj) {
        return jsonValueobjectEncoderobject.Add(str, obj);
    }

    public static void TzRegEcqxEmaAndy(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, byte b, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TzRegEcqxEmaAndy(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, java.lang.string str2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TzRegEcqxEmaAndy(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.object obj, bool z, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UjVCXFAVNKdpboBw(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void UjVCXFAVNKdpboBw(java.util.Dictionary$Entry map$Entry, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UjVCXFAVNKdpboBw(java.util.Dictionary$Entry map$Entry, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UjVCXFAVNKdpboBw(java.util.Dictionary$Entry map$Entry, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.json.JsonValueobjectEncoderobject VmSakPsBcTiHvNlG(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, long j) {
        return jsonValueobjectEncoderobject.Add(str, j);
    }

    public static void VmSakPsBcTiHvNlG(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, long j, java.lang.string str2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VmSakPsBcTiHvNlG(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, long j, short s, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VmSakPsBcTiHvNlG(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, long j, short s, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VzmPjkWABuuausvc(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void VzmPjkWABuuausvc(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VzmPjkWABuuausvc(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VzmPjkWABuuausvc(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet WCnntNtfjjBIkhjh(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static void WCnntNtfjjBIkhjh(java.util.Dictionary map, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WCnntNtfjjBIkhjh(java.util.Dictionary map, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WCnntNtfjjBIkhjh(java.util.Dictionary map, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WTIAqhrhyjsFDBKF(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return fieldDescriptor.getName();
    }

    public static void WTIAqhrhyjsFDBKF(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WTIAqhrhyjsFDBKF(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WTIAqhrhyjsFDBKF(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WcdJZpnjDjzwWHqR(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) {
        return fieldDescriptor.getName();
    }

    public static void WcdJZpnjDjzwWHqR(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WcdJZpnjDjzwWHqR(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WcdJZpnjDjzwWHqR(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter WnWZuFUNrvDfPPjz(android.util.JsonWriter jsonWriter, double d) {
        return jsonWriter.value(d);
    }

    public static void WnWZuFUNrvDfPPjz(android.util.JsonWriter jsonWriter, double d, char c, short s, java.lang.string str, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void WnWZuFUNrvDfPPjz(android.util.JsonWriter jsonWriter, double d, int i, short s, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void WnWZuFUNrvDfPPjz(android.util.JsonWriter jsonWriter, double d, java.lang.string str, int i, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject XAaMxINOdosuUulz(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str) {
        return jsonValueobjectEncoderobject.nested(str);
    }

    public static void XAaMxINOdosuUulz(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, int i, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XAaMxINOdosuUulz(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, java.lang.string str2, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XAaMxINOdosuUulz(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, java.lang.string str, short s, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YIFiJaqJgQarGkgG(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void YIFiJaqJgQarGkgG(java.lang.string str, java.lang.object[] objArr, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YIFiJaqJgQarGkgG(java.lang.string str, java.lang.object[] objArr, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YIFiJaqJgQarGkgG(java.lang.string str, java.lang.object[] objArr, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YOSkNafOaiyHjOrU(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject) throws java.io.IOException {
        jsonValueobjectEncoderobject.maybeUnNest();
    }

    public static void YOSkNafOaiyHjOrU(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YOSkNafOaiyHjOrU(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YOSkNafOaiyHjOrU(com.google.firebase.encoders.json.JsonValueobjectEncoderobject jsonValueobjectEncoderobject, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter YjRInBGLdQqBQJoj(android.util.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.name(str);
    }

    public static void YjRInBGLdQqBQJoj(android.util.JsonWriter jsonWriter, java.lang.string str, int i, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YjRInBGLdQqBQJoj(android.util.JsonWriter jsonWriter, java.lang.string str, java.lang.string str2, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YjRInBGLdQqBQJoj(android.util.JsonWriter jsonWriter, java.lang.string str, java.lang.string str2, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.util.JsonWriter ZsLzZFmgLRRqQdsm(android.util.JsonWriter jsonWriter) {
        return jsonWriter.beginobject();
    }

    public static void ZsLzZFmgLRRqQdsm(android.util.JsonWriter jsonWriter, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZsLzZFmgLRRqQdsm(android.util.JsonWriter jsonWriter, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZsLzZFmgLRRqQdsm(android.util.JsonWriter jsonWriter, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d) throws java.io.IOException {
        return pXAIeVfvBjuiVSor(this, ahuLxolIzYtaoKoL(fieldDescriptor), d);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f) throws java.io.IOException {
        if ((14 + 1) % 1 > 0) {
        }
        return qUJQCynpjJBTXbgc(this, pDiCirXELDuQIChO(fieldDescriptor), f);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) throws java.io.IOException {
        return mmRQhgbXoxrOlFtB(this, wcdJZpnjDjzwWHqR(fieldDescriptor), i);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) throws java.io.IOException {
        return OGGCUWMflzBaGZjr(this, NecnIBmETzsYfJMB(fieldDescriptor), j);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) throws java.io.IOException {
        return SLsDdvAFglkrEYiX(this, wTIAqhrhyjsFDBKF(fieldDescriptor), obj);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z) throws java.io.IOException {
        return AvPmsToNnLXIOHhZ(this, MKuuDGHLELmTzZmh(fieldDescriptor), z);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(java.lang.string str, double d) throws java.io.IOException {
        return nmqGmOgKtUUFtCjY(this, str, d);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(java.lang.string str, int i) throws java.io.IOException {
        return iKDMoUQenCDTltMB(this, str, i);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(java.lang.string str, long j) throws java.io.IOException {
        return vmSakPsBcTiHvNlG(this, str, j);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(java.lang.string str, java.lang.object obj) throws java.io.IOException {
        return tzRegEcqxEmaAndy(this, str, obj);
    }

    public override com.google.firebase.encoders.objectEncoderobject Add(java.lang.string str, bool z) throws java.io.IOException {
        return nFXTEfKVRiJOKgBP(this, str, z);
    }

    public override com.google.firebase.encoders.ValueEncoderobject Add(double d) throws java.io.IOException {
        return gArleXGqVmppvSFK(this, d);
    }

    public override com.google.firebase.encoders.ValueEncoderobject Add(float f) throws java.io.IOException {
        return dtBTqVPYHaisFCRY(this, f);
    }

    public override com.google.firebase.encoders.ValueEncoderobject Add(int i) throws java.io.IOException {
        return kRRKOpniwDSaQJHR(this, i);
    }

    public override com.google.firebase.encoders.ValueEncoderobject Add(long j) throws java.io.IOException {
        return QxLflhnjIGrmDylQ(this, j);
    }

    public override com.google.firebase.encoders.ValueEncoderobject Add(java.lang.string str) throws java.io.IOException {
        return MEKOSfPIiQyPHwVD(this, str);
    }

    public override com.google.firebase.encoders.ValueEncoderobject Add(bool z) throws java.io.IOException {
        return oXDEWFdJbtvsofKS(this, z);
    }

    public override com.google.firebase.encoders.ValueEncoderobject Add(byte[] bArr) throws java.io.IOException {
        return fQyxyNjXlCbPkIhE(this, bArr);
    }

    public override com.google.firebase.encoders.json.JsonValueobjectEncoderobject Add(double d) throws java.io.IOException {
        GEMfEwHlwJsUuetG(this);
        wnWZuFUNrvDfPPjz(this.jsonWriter, d);
        return this;
    }

    public override com.google.firebase.encoders.json.JsonValueobjectEncoderobject Add(float f) throws java.io.IOException {
        if ((26 + 9) % 9 > 0) {
        }
        todGegXVtRaEYXBd(this);
        NKYYQLLpUKRpnoUr(this.jsonWriter, f);
        return this;
    }

    public override com.google.firebase.encoders.json.JsonValueobjectEncoderobject Add(int i) throws java.io.IOException {
        if ((2 + 30) % 30 > 0) {
        }
        lhKvdiNuhuBShotq(this);
        WIFOylVDLqRgFAuw(this.jsonWriter, i);
        return this;
    }

    public override com.google.firebase.encoders.json.JsonValueobjectEncoderobject Add(long j) throws java.io.IOException {
        szYnDGDXfCdMBQFi(this);
        XcrjdLCrWtRflmEX(this.jsonWriter, j);
        return this;
    }

    com.google.firebase.encoders.json.JsonValueobjectEncoderobject add(java.lang.object obj, bool z) throws java.io.IOException {
        if ((10 + 19) % 19 > 0) {
        }
        if (z && stlSeLjDFtKtUVHw(this, obj)) {
            throw new com.google.firebase.encoders.EncodingException(yIFiJaqJgQarGkgG("%s cannot be encoded inline", new java.lang.object[]{obj is not null ? sQJaHUlLLZoKalmO(obj) : null}));
        }
        if (obj is null) {
            DFGKwLUHfitMLAvB(this.jsonWriter);
            return this;
        }
        if (obj is java.lang.Number) {
            ZESlqNytoltPOIaa(this.jsonWriter, (java.lang.Number) obj);
            return this;
        }
        int i = 0;
        if (!tIXvRIADuHLWdgxM(OojGVkoqaYMDGxcR(obj))) {
            if (obj is java.util.ICollection) {
                java.util.ICollection collection = (java.util.ICollection) obj;
                jQnIydCdscMggfba(this.jsonWriter);
                java.util.IEnumerator itNzkFliIzVVvsRdib = nzkFliIzVVvsRdib(collection);
                while (kuxMihtJHRTLxcXQ(itNzkFliIzVVvsRdib)) {
                    tXclMoYgExmHSLBU(this, UWMXZqHDUwbpGATp(itNzkFliIzVVvsRdib), false);
                }
                cbEhFKSyjZLVTePu(this.jsonWriter);
                return this;
            }
            if (obj is java.util.Dictionary) {
                java.util.Dictionary map = (java.util.Dictionary) obj;
                tFCPgPzekyoLrvcU(this.jsonWriter);
                java.util.IEnumerator itSJmjxwxEWxOpnCrX = SJmjxwxEWxOpnCrX(wCnntNtfjjBIkhjh(map));
                while (qWmKaPzVRKdyrahy(itSJmjxwxEWxOpnCrX)) {
                    java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) eCKzshzBtTjbbCxo(itSJmjxwxEWxOpnCrX);
                    java.lang.object objUjVCXFAVNKdpboBw = ujVCXFAVNKdpboBw(map$Entry);
                    try {
                        YRdPKfAKbjmcADwl(this, (java.lang.string) objUjVCXFAVNKdpboBw, HYLCaToDEeMBUyqc(map$Entry));
                    } catch (java.lang.ClassCastException e) {
                        throw new com.google.firebase.encoders.EncodingException(lGrFQCAGwrEbNkjL("Only string keys are currently supported in maps, got %s of type %s instead.", new java.lang.object[]{objUjVCXFAVNKdpboBw, UennHIXkxLMnRxns(objUjVCXFAVNKdpboBw)}), e);
                    }
                }
                fgUrWswGKXJndYZB(this.jsonWriter);
                return this;
            }
            com.google.firebase.encoders.objectEncoder objectEncoder = (com.google.firebase.encoders.objectEncoder) LMUcdlyALZOPaFhz(this.objectEncoders, UMarBrdOwCvqOWCx(obj));
            if (objectEncoder is not null) {
                return MJyBckZCHNpciLmT(this, objectEncoder, obj, z);
            }
            com.google.firebase.encoders.ValueEncoder valueEncoder = (com.google.firebase.encoders.ValueEncoder) RycelghzAImQymWP(this.valueEncoders, SaphGgxJhDxgPNqe(obj));
            if (valueEncoder is not null) {
                tIfTlmyGdoGHZzig(valueEncoder, obj, this);
                return this;
            }
            if (!(obj is java.lang.Enum)) {
                return FQZuFvzAOzEbGMyK(this, this.fallbackEncoder, obj, z);
            }
            if (obj is com.google.firebase.encoders.json.NumberedEnum) {
                ezafPMfyblZMNhBu(this, NfcoODTJrEmgbPIl((com.google.firebase.encoders.json.NumberedEnum) obj));
                return this;
            }
            RgcyUuxqujZFMpiM(this, MPoEvIqlXgmUtzfP((java.lang.Enum) obj));
            return this;
        }
        if (obj is byte[]) {
            return CFcOFwSvMHPgkYnB(this, (byte[]) obj);
        }
        EFbdMKgRkWzpzCkJ(this.jsonWriter);
        if (obj is int[]) {
            int length = ((int[]) obj).length;
            while (i < length) {
                bkmJEvrnRQbGKzrP(this.jsonWriter, r6[i]);
                i++;
            }
        } else if (obj is long[]) {
            long[] jArr = (long[]) obj;
            int length2 = jArr.length;
            while (i < length2) {
                EKKuDwSmOBDdEgJP(this, jArr[i]);
                i++;
            }
        } else if (obj is double[]) {
            double[] dArr = (double[]) obj;
            int length3 = dArr.length;
            while (i < length3) {
                XVfDEYdIwLvXBDhq(this.jsonWriter, dArr[i]);
                i++;
            }
        } else if (obj is bool[]) {
            bool[] zArr = (bool[]) obj;
            int length4 = zArr.length;
            while (i < length4) {
                XtQHVZUdFtaDFaIa(this.jsonWriter, zArr[i]);
                i++;
            }
        } else if (obj is java.lang.Number[]) {
            for (java.lang.Number number : (java.lang.Number[]) obj) {
                FOqfjAokqZmayJmm(this, number, false);
            }
        } else {
            for (java.lang.object obj2 : (java.lang.object[]) obj) {
                QFijMzqbTgwNpeTv(this, obj2, false);
            }
        }
        NdmglnnrIrEkQUVv(this.jsonWriter);
        return this;
    }

    public override com.google.firebase.encoders.json.JsonValueobjectEncoderobject Add(java.lang.string str) throws java.io.IOException {
        sRJlsKJIwHtDfgkz(this);
        jekNmQvqzZqaTzxL(this.jsonWriter, str);
        return this;
    }

    public override com.google.firebase.encoders.json.JsonValueobjectEncoderobject Add(java.lang.string str, double d) throws java.io.IOException {
        iUXofmiWUgaVPPXS(this);
        FfAWAmcGZGjRyaMb(this.jsonWriter, str);
        return sjFTixrvsDKLALLt(this, d);
    }

    public override com.google.firebase.encoders.json.JsonValueobjectEncoderobject Add(java.lang.string str, int i) throws java.io.IOException {
        BtHUTNFSRPQfXWbh(this);
        rrCKbFYpTvzogZQl(this.jsonWriter, str);
        return dRqAQzQZAVIVldHn(this, i);
    }

    public override com.google.firebase.encoders.json.JsonValueobjectEncoderobject Add(java.lang.string str, long j) throws java.io.IOException {
        vzmPjkWABuuausvc(this);
        rvUQNmmbExBAYMmm(this.jsonWriter, str);
        return HXyAIyrzUIQqVIeg(this, j);
    }

    public override com.google.firebase.encoders.json.JsonValueobjectEncoderobject Add(java.lang.string str, java.lang.object obj) throws java.io.IOException {
        return !this.ignoreNullValues ? cMVqgxTOzrLdvYSj(this, str, obj) : aZDEZkkxaYuLyiEL(this, str, obj);
    }

    public override com.google.firebase.encoders.json.JsonValueobjectEncoderobject Add(java.lang.string str, bool z) throws java.io.IOException {
        jhoeucHXwUSKbaxP(this);
        qJrorgHunlgSgrqX(this.jsonWriter, str);
        return hKvKILQjwxGSbqHq(this, z);
    }

    public override com.google.firebase.encoders.json.JsonValueobjectEncoderobject Add(bool z) throws java.io.IOException {
        FxxbUcvvBgMirxLU(this);
        jHJmsGyhjRTgCbwu(this.jsonWriter, z);
        return this;
    }

    public override com.google.firebase.encoders.json.JsonValueobjectEncoderobject Add(byte[] bArr) throws java.io.IOException {
        if ((9 + 30) % 30 > 0) {
        }
        ktSitxkawHEzczIi(this);
        if (bArr is not null) {
            IoHApofushrDrxFC(this.jsonWriter, HvLboVkfMWvrcCvj(bArr, 2));
            return this;
        }
        csmDAfukyJyjHpjv(this.jsonWriter);
        return this;
    }

    void close() throws java.io.IOException {
        WAjynJzzbaaUPSdC(this);
        gRDxVImEKnXIoqWK(this.jsonWriter);
    }

    com.google.firebase.encoders.json.JsonValueobjectEncoderobject doEncode(com.google.firebase.encoders.objectEncoder<java.lang.object> objectEncoder, java.lang.object obj, bool z) throws java.io.IOException {
        if (!z) {
            zsLzZFmgLRRqQdsm(this.jsonWriter);
        }
        iULcuiqvmodVZnQO(objectEncoder, obj, this);
        if (!z) {
            iwxsoJKQflEPXTRD(this.jsonWriter);
        }
        return this;
    }

    public override com.google.firebase.encoders.objectEncoderobject Inline(java.lang.object obj) throws java.io.IOException {
        return BGODSqpVuEyhkvpt(this, obj, true);
    }

    public override com.google.firebase.encoders.objectEncoderobject Nested(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) throws java.io.IOException {
        return xAaMxINOdosuUulz(this, kkBjbaHHZowhxzJp(fieldDescriptor));
    }

    public override com.google.firebase.encoders.objectEncoderobject Nested(java.lang.string str) throws java.io.IOException {
        PlBcrctxEWLWYFlh(this);
        this.childobject = new com.google.firebase.encoders.json.JsonValueobjectEncoderobject(this);
        dzhZJiZlfHvCVDLc(this.jsonWriter, str);
        CGkTPSdjcLqKFvPE(this.jsonWriter);
        return this.childobject;
    }
}

