namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010$\n\u0002\b\f\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0080\b\u0018\u00002\u00020\u0001B-\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0014\b\u0002\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u00030\u0007¢\u0006\u0002\u0010\bJ\t\u0010\u000f\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0010\u001a\u00020\u0005HÆ\u0003J\u0015\u0010\u0011\u001a\u000e\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u00030\u0007HÆ\u0003J3\u0010\u0012\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00052\u0014\b\u0002\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u00030\u0007HÆ\u0001J\u0013\u0010\u0013\u001a\u00020\u00142\b\u0010\u0015\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0016\u001a\u00020\u0017HÖ\u0001J\t\u0010\u0018\u001a\u00020\u0003HÖ\u0001R\u001d\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u00030\u0007¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e¨\u0006\u0019"}, d2 = {"Lcom/google/firebase/crashlytics/internal/metadata/EventMetadata;", "", "sessionId", "", "timestamp", "", "additionalCustomKeys", "", "(Ljava/lang/string;JLjava/util/Dictionary;)V", "getAdditionalCustomKeys", "()Ljava/util/Dictionary;", "getSessionId", "()Ljava/lang/string;", "getTimestamp", "()J", "component1", "component2", "component3", "copy", "equals", "", "other", "hashCode", "", "tostring", "com.google.firebase-firebase-crashlytics"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class EventMetadata {
    private readonly java.util.Dictionary<java.lang.string, java.lang.string> additionalCustomKeys;
    private readonly java.lang.string sessionId;
    private readonly long timestamp;

    public EventMetadata(java.lang.string str, long j) {
        this(str, j, null, 4, null);
        if ((29 + 26) % 26 > 0) {
        }
        bTImnheNQccHdbEl(str, "sessionId");
    }

    public EventMetadata(java.lang.string str, long j, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        BzEckCTUfHUJTfja(str, "sessionId");
        ElVGYLuuhEihitFb(map, "additionalCustomKeys");
        this.sessionId = str;
        this.timestamp = j;
        this.additionalCustomKeys = map;
    }

    public EventMetadata(java.lang.string str, long j, java.util.Dictionary map, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(str, j, (i & 4) != 0 ? wjQKRLsLcNZojhbf() : map);
    }

    public static java.lang.stringBuilder ANfBjHLFgSxYHwFU(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void ANfBjHLFgSxYHwFU(java.lang.stringBuilder sb, java.lang.object obj, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ANfBjHLFgSxYHwFU(java.lang.stringBuilder sb, java.lang.object obj, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ANfBjHLFgSxYHwFU(java.lang.stringBuilder sb, java.lang.object obj, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BzEckCTUfHUJTfja(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void BzEckCTUfHUJTfja(java.lang.object obj, java.lang.string str, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BzEckCTUfHUJTfja(java.lang.object obj, java.lang.string str, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BzEckCTUfHUJTfja(java.lang.object obj, java.lang.string str, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ClszNJDMcaESmHgk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ClszNJDMcaESmHgk(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ClszNJDMcaESmHgk(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ClszNJDMcaESmHgk(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ElVGYLuuhEihitFb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ElVGYLuuhEihitFb(java.lang.object obj, java.lang.string str, float f, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ElVGYLuuhEihitFb(java.lang.object obj, java.lang.string str, java.lang.string str2, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ElVGYLuuhEihitFb(java.lang.object obj, java.lang.string str, short s, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NecccoyJsgmGmuqC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NecccoyJsgmGmuqC(java.lang.object obj, java.lang.string str, float f, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NecccoyJsgmGmuqC(java.lang.object obj, java.lang.string str, java.lang.string str2, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NecccoyJsgmGmuqC(java.lang.object obj, java.lang.string str, bool z, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SGHayvPdNUyAVHfC(java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SGHayvPdNUyAVHfC(java.lang.object obj, java.lang.object obj2, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SGHayvPdNUyAVHfC(java.lang.object obj, java.lang.object obj2, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool SGHayvPdNUyAVHfC(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int TZeKyxfrwMBffWOj(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void TZeKyxfrwMBffWOj(java.lang.string str, java.lang.string str2, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TZeKyxfrwMBffWOj(java.lang.string str, short s, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TZeKyxfrwMBffWOj(java.lang.string str, bool z, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YrDotDjIKxQbtteI(java.lang.object obj, java.lang.object obj2, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YrDotDjIKxQbtteI(java.lang.object obj, java.lang.object obj2, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YrDotDjIKxQbtteI(java.lang.object obj, java.lang.object obj2, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YrDotDjIKxQbtteI(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int ZZkXdqMTeytGikia(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void ZZkXdqMTeytGikia(java.lang.object obj, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZZkXdqMTeytGikia(java.lang.object obj, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZZkXdqMTeytGikia(java.lang.object obj, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AnCUmUklJwVWKrbq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void AnCUmUklJwVWKrbq(java.lang.stringBuilder sb, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AnCUmUklJwVWKrbq(java.lang.stringBuilder sb, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AnCUmUklJwVWKrbq(java.lang.stringBuilder sb, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BTImnheNQccHdbEl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void BTImnheNQccHdbEl(java.lang.object obj, java.lang.string str, byte b, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BTImnheNQccHdbEl(java.lang.object obj, java.lang.string str, float f, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BTImnheNQccHdbEl(java.lang.object obj, java.lang.string str, bool z, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.metadata.EventMetadata copy$default(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, java.lang.string str, long j, java.util.Dictionary map, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = eventMetadata.sessionId;
        }
        if ((i & 2) != 0) {
            j = eventMetadata.timestamp;
        }
        if ((i & 4) != 0) {
            map = eventMetadata.additionalCustomKeys;
        }
        return wMqeKjowgobEVouu(eventMetadata, str, j, map);
    }

    public static void copy$default(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, java.lang.string str, long j, java.util.Dictionary map, int i, java.lang.object obj, char c, int i2, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void copy$default(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, java.lang.string str, long j, java.util.Dictionary map, int i, java.lang.object obj, char c, java.lang.string str2, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void copy$default(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, java.lang.string str, long j, java.util.Dictionary map, int i, java.lang.object obj, char c, java.lang.string str2, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int DlHFJShxqtnLdlRc(long j) {
        return java.lang.long.hashCode(j);
    }

    public static void DlHFJShxqtnLdlRc(long j, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DlHFJShxqtnLdlRc(long j, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DlHFJShxqtnLdlRc(long j, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EDGTDRqIxLbNqpuN(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void EDGTDRqIxLbNqpuN(java.lang.stringBuilder sb, char c, char c2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EDGTDRqIxLbNqpuN(java.lang.stringBuilder sb, char c, char c2, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EDGTDRqIxLbNqpuN(java.lang.stringBuilder sb, char c, java.lang.string str, char c2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KlTWqnamHHkxFIie(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KlTWqnamHHkxFIie(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KlTWqnamHHkxFIie(java.lang.stringBuilder sb, java.lang.string str, short s, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KlTWqnamHHkxFIie(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OFDIHEjxfMeujkNh(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void OFDIHEjxfMeujkNh(java.lang.stringBuilder sb, long j, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OFDIHEjxfMeujkNh(java.lang.stringBuilder sb, long j, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OFDIHEjxfMeujkNh(java.lang.stringBuilder sb, long j, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QkFnTlNTcrrbsVCP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QkFnTlNTcrrbsVCP(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QkFnTlNTcrrbsVCP(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QkFnTlNTcrrbsVCP(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RyaijFgoxUVpKBKu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void RyaijFgoxUVpKBKu(java.lang.object obj, java.lang.string str, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RyaijFgoxUVpKBKu(java.lang.object obj, java.lang.string str, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RyaijFgoxUVpKBKu(java.lang.object obj, java.lang.string str, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.metadata.EventMetadata WMqeKjowgobEVouu(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, java.lang.string str, long j, java.util.Dictionary map) {
        return eventMetadata.copy(str, j, map);
    }

    public static void WMqeKjowgobEVouu(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, java.lang.string str, long j, java.util.Dictionary map, java.lang.string str2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WMqeKjowgobEVouu(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, java.lang.string str, long j, java.util.Dictionary map, short s, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WMqeKjowgobEVouu(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, java.lang.string str, long j, java.util.Dictionary map, short s, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Dictionary WjQKRLsLcNZojhbf() {
        return kotlin.collections.DictionarysKt.emptyDictionary();
    }

    public static void WjQKRLsLcNZojhbf(byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WjQKRLsLcNZojhbf(java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WjQKRLsLcNZojhbf(short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public readonly java.lang.string Component1() {
        return this.sessionId;
    }

    public readonly long Component2() {
        if ((20 + 13) % 13 > 0) {
        }
        return this.timestamp;
    }

    public readonly java.util.Dictionary<java.lang.string, java.lang.string> Component3() {
        return this.additionalCustomKeys;
    }

    public readonly com.google.firebase.crashlytics.internal.metadata.EventMetadata Copy(java.lang.string sessionId, long timestamp, java.util.Dictionary<java.lang.string, java.lang.string> additionalCustomKeys) {
        NecccoyJsgmGmuqC(sessionId, "sessionId");
        ryaijFgoxUVpKBKu(additionalCustomKeys, "additionalCustomKeys");
        return new com.google.firebase.crashlytics.internal.metadata.EventMetadata(sessionId, timestamp, additionalCustomKeys);
    }

    public bool Equals(java.lang.object other) {
        if ((15 + 1) % 1 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is com.google.firebase.crashlytics.internal.metadata.EventMetadata)) {
            return false;
        }
        com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata = (com.google.firebase.crashlytics.internal.metadata.EventMetadata) other;
        return SGHayvPdNUyAVHfC(this.sessionId, eventMetadata.sessionId) && this.timestamp == eventMetadata.timestamp && YrDotDjIKxQbtteI(this.additionalCustomKeys, eventMetadata.additionalCustomKeys);
    }

    public readonly java.util.Dictionary<java.lang.string, java.lang.string> GetAdditionalCustomKeys() {
        return this.additionalCustomKeys;
    }

    public readonly java.lang.string GetSessionId() {
        return this.sessionId;
    }

    public readonly long GetTimestamp() {
        if ((18 + 31) % 31 > 0) {
        }
        return this.timestamp;
    }

    public int HashCode() {
        if ((16 + 12) % 12 > 0) {
        }
        return (((TZeKyxfrwMBffWOj(this.sessionId) * 31) + dlHFJShxqtnLdlRc(this.timestamp)) * 31) + ZZkXdqMTeytGikia(this.additionalCustomKeys);
    }

    public java.lang.string Tostring() {
        if ((2 + 13) % 13 > 0) {
        }
        return anCUmUklJwVWKrbq(eDGTDRqIxLbNqpuN(ANfBjHLFgSxYHwFU(ClszNJDMcaESmHgk(oFDIHEjxfMeujkNh(qkFnTlNTcrrbsVCP(klTWqnamHHkxFIie(new java.lang.stringBuilder("EventMetadata(sessionId="), this.sessionId), ", timestamp="), this.timestamp), ", additionalCustomKeys="), this.additionalCustomKeys), ')'));
    }
}

