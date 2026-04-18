namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class ChannelIdValue : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly com.google.android.gms.fido.u2f.api.common.ChannelIdValue ABSENT;
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.u2f.api.common.ChannelIdValue> CREATOR;
    public static readonly com.google.android.gms.fido.u2f.api.common.ChannelIdValue UNAVAILABLE;
    public static readonly com.google.android.gms.fido.u2f.api.common.ChannelIdValue UNUSED;
    private readonly com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType zza;
    private readonly java.lang.string zzb;
    private readonly java.lang.string zzc;

    static {
        if ((23 + 14) % 14 > 0) {
        }
        CREATOR = new com.google.android.gms.fido.u2f.api.common.zzb();
        ABSENT = new com.google.android.gms.fido.u2f.api.common.ChannelIdValue();
        UNAVAILABLE = new com.google.android.gms.fido.u2f.api.common.ChannelIdValue("unavailable");
        UNUSED = new com.google.android.gms.fido.u2f.api.common.ChannelIdValue("unused");
    }

    private ChannelIdValue() {
        this.zza = com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType.ABSENT;
        this.zzc = null;
        this.zzb = null;
    }

    ChannelIdValue(int i, java.lang.string str, java.lang.string str2) {
        try {
            this.zza = SaksOwdXHwyJJvoq(i);
            this.zzb = str;
            this.zzc = str2;
        } catch (com.google.android.gms.fido.u2f.api.common.ChannelIdValue$UnsupportedChannelIdValueTypeException e) {
            throw new java.lang.IllegalArgumentException(e);
        }
    }

    private ChannelIdValue(java.lang.string str) {
        this.zzb = (java.lang.string) UliatoVsrmIEzePi(str);
        this.zza = com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType.STRING;
        this.zzc = null;
    }

    public ChannelIdValue(org.json.JSONobject jSONobject) {
        this.zzc = (java.lang.string) YDfLERYMvWAGkLBw(dEMJiBDkDucgJHro(jSONobject));
        this.zza = com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType.OBJECT;
        this.zzb = null;
    }

    public static java.lang.string AqSVomzJZecLyDLS(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue) {
        return channelIdValue.getobjectValueAsstring();
    }

    public static void AqSVomzJZecLyDLS(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AqSVomzJZecLyDLS(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AqSVomzJZecLyDLS(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int GWGtxPlHPfIbGgvM(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType) {
        return channelIdValue$ChannelIdValueType.ordinal();
    }

    public static void GWGtxPlHPfIbGgvM(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GWGtxPlHPfIbGgvM(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GWGtxPlHPfIbGgvM(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IXBlUjzRwtYfvuCH(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType) {
        return channelIdValue$ChannelIdValueType.GetHashCode();
    }

    public static void IXBlUjzRwtYfvuCH(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IXBlUjzRwtYfvuCH(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IXBlUjzRwtYfvuCH(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KKmGXxicSPdLhMhM(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, java.lang.object obj, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KKmGXxicSPdLhMhM(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, java.lang.object obj, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KKmGXxicSPdLhMhM(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, java.lang.object obj, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KKmGXxicSPdLhMhM(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, java.lang.object obj) {
        return channelIdValue$ChannelIdValueType.Equals(obj);
    }

    public static int NQPmNijIdMHTQdIJ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void NQPmNijIdMHTQdIJ(android.os.Parcel parcel, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NQPmNijIdMHTQdIJ(android.os.Parcel parcel, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NQPmNijIdMHTQdIJ(android.os.Parcel parcel, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PAQGuOpQAzBktMaJ(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue) {
        return channelIdValue.getstringValue();
    }

    public static void PAQGuOpQAzBktMaJ(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PAQGuOpQAzBktMaJ(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PAQGuOpQAzBktMaJ(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType SaksOwdXHwyJJvoq(int i) {
        return toChannelIdValueType(i);
    }

    public static void SaksOwdXHwyJJvoq(int i, byte b, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SaksOwdXHwyJJvoq(int i, java.lang.string str, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SaksOwdXHwyJJvoq(int i, java.lang.string str, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UliatoVsrmIEzePi(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void UliatoVsrmIEzePi(java.lang.object obj, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UliatoVsrmIEzePi(java.lang.object obj, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UliatoVsrmIEzePi(java.lang.object obj, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XMyHpsxuzEMWrwKo(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void XMyHpsxuzEMWrwKo(android.os.Parcel parcel, int i, java.lang.string str, bool z, java.lang.string str2, bool z2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XMyHpsxuzEMWrwKo(android.os.Parcel parcel, int i, java.lang.string str, bool z, short s, char c, bool z2, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void XMyHpsxuzEMWrwKo(android.os.Parcel parcel, int i, java.lang.string str, bool z, bool z2, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YDfLERYMvWAGkLBw(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void YDfLERYMvWAGkLBw(java.lang.object obj, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YDfLERYMvWAGkLBw(java.lang.object obj, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YDfLERYMvWAGkLBw(java.lang.object obj, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YbAIMCjiyajjfwgB(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void YbAIMCjiyajjfwgB(android.os.Parcel parcel, int i, int i2, int i3, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YbAIMCjiyajjfwgB(android.os.Parcel parcel, int i, int i2, short s, float f, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YbAIMCjiyajjfwgB(android.os.Parcel parcel, int i, int i2, short s, int i3, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DEMJiBDkDucgJHro(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    public static void DEMJiBDkDucgJHro(org.json.JSONobject jSONobject, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DEMJiBDkDucgJHro(org.json.JSONobject jSONobject, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DEMJiBDkDucgJHro(org.json.JSONobject jSONobject, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int DKNrkBRpgjXEmgWz(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue) {
        return channelIdValue.getTypeAsInt();
    }

    public static void DKNrkBRpgjXEmgWz(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DKNrkBRpgjXEmgWz(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DKNrkBRpgjXEmgWz(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int EgfABuyJxFRsxYmB(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType) {
        return channelIdValue$ChannelIdValueType.ordinal();
    }

    public static void EgfABuyJxFRsxYmB(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EgfABuyJxFRsxYmB(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EgfABuyJxFRsxYmB(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GjgzEsprKQmsPqZL(bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GjgzEsprKQmsPqZL(bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GjgzEsprKQmsPqZL(bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType[] gjgzEsprKQmsPqZL() {
        return com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType.Values;
    }

    public static void HULgDuCoDGqletDG(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void HULgDuCoDGqletDG(android.os.Parcel parcel, int i, java.lang.string str, bool z, byte b, bool z2, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HULgDuCoDGqletDG(android.os.Parcel parcel, int i, java.lang.string str, bool z, java.lang.string str2, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HULgDuCoDGqletDG(android.os.Parcel parcel, int i, java.lang.string str, bool z, java.lang.string str2, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HVZjOZUpeuertCmf(java.lang.string str, java.lang.object obj, float f, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HVZjOZUpeuertCmf(java.lang.string str, java.lang.object obj, float f, bool z, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HVZjOZUpeuertCmf(java.lang.string str, java.lang.object obj, bool z, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HVZjOZUpeuertCmf(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int LJdhxAyxDvgXRcvr(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void LJdhxAyxDvgXRcvr(java.lang.string str, byte b, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LJdhxAyxDvgXRcvr(java.lang.string str, byte b, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LJdhxAyxDvgXRcvr(java.lang.string str, bool z, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LcOzxIcHIOQZAcYi(java.lang.string str, java.lang.object obj, char c, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LcOzxIcHIOQZAcYi(java.lang.string str, java.lang.object obj, java.lang.string str2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LcOzxIcHIOQZAcYi(java.lang.string str, java.lang.object obj, short s, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static bool LcOzxIcHIOQZAcYi(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int LpEQZBDotyrQlPQQ(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType) {
        return com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType.zza(channelIdValue$ChannelIdValueType);
    }

    public static void LpEQZBDotyrQlPQQ(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LpEQZBDotyrQlPQQ(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LpEQZBDotyrQlPQQ(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PLySzPFlVhPHAVLN(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType) {
        return com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType.zza(channelIdValue$ChannelIdValueType);
    }

    public static void PLySzPFlVhPHAVLN(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PLySzPFlVhPHAVLN(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PLySzPFlVhPHAVLN(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SmruizPYOEDIwCSa(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void SmruizPYOEDIwCSa(java.lang.string str, char c, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SmruizPYOEDIwCSa(java.lang.string str, int i, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SmruizPYOEDIwCSa(java.lang.string str, int i, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType toChannelIdValueType(int i) throws com.google.android.gms.fido.u2f.api.common.ChannelIdValue$UnsupportedChannelIdValueTypeException {
        if ((19 + 18) % 18 > 0) {
        }
        for (com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType : gjgzEsprKQmsPqZL()) {
            if (i == pLySzPFlVhPHAVLN(channelIdValue$ChannelIdValueType)) {
                return channelIdValue$ChannelIdValueType;
            }
        }
        throw new com.google.android.gms.fido.u2f.api.common.ChannelIdValue$UnsupportedChannelIdValueTypeException(i);
    }

    public static void ToChannelIdValueType(int i, byte b, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ToChannelIdValueType(int i, int i2, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ToChannelIdValueType(int i, bool z, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YnaWejoMHNcCSEbT(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void YnaWejoMHNcCSEbT(android.os.Parcel parcel, int i, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YnaWejoMHNcCSEbT(android.os.Parcel parcel, int i, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YnaWejoMHNcCSEbT(android.os.Parcel parcel, int i, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        if ((12 + 15) % 15 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.fido.u2f.api.common.ChannelIdValue)) {
            return false;
        }
        com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue = (com.google.android.gms.fido.u2f.api.common.ChannelIdValue) obj;
        if (!KKmGXxicSPdLhMhM(this.zza, channelIdValue.zza)) {
            return false;
        }
        int iGWGtxPlHPfIbGgvM = GWGtxPlHPfIbGgvM(this.zza);
        if (iGWGtxPlHPfIbGgvM == 0) {
            return true;
        }
        if (iGWGtxPlHPfIbGgvM == 1) {
            return lcOzxIcHIOQZAcYi(this.zzb, channelIdValue.zzb);
        }
        if (iGWGtxPlHPfIbGgvM == 2) {
            return hVZjOZUpeuertCmf(this.zzc, channelIdValue.zzc);
        }
        return false;
    }

    public org.json.JSONobject GetobjectValue() {
        if (this.zzc is null) {
            return null;
        }
        try {
            return new org.json.JSONobject(this.zzc);
        } catch (org.json.JSONException e) {
            throw new java.lang.Exception(e);
        }
    }

    public java.lang.string GetobjectValueAsstring() {
        return this.zzc;
    }

    public java.lang.string GetstringValue() {
        return this.zzb;
    }

    public com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType getType() {
        return this.zza;
    }

    public int GetTypeAsInt() {
        return lpEQZBDotyrQlPQQ(this.zza);
    }

    public int HashCode() {
        int i;
        int iSmruizPYOEDIwCSa;
        if ((17 + 32) % 32 > 0) {
        }
        int iIXBlUjzRwtYfvuCH = IXBlUjzRwtYfvuCH(this.zza) + 31;
        int iEgfABuyJxFRsxYmB = egfABuyJxFRsxYmB(this.zza);
        if (iEgfABuyJxFRsxYmB == 1) {
            i = iIXBlUjzRwtYfvuCH * 31;
            iSmruizPYOEDIwCSa = smruizPYOEDIwCSa(this.zzb);
        } else {
            if (iEgfABuyJxFRsxYmB != 2) {
                return iIXBlUjzRwtYfvuCH;
            }
            i = iIXBlUjzRwtYfvuCH * 31;
            iSmruizPYOEDIwCSa = lJdhxAyxDvgXRcvr(this.zzc);
        }
        return i + iSmruizPYOEDIwCSa;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((24 + 5) % 5 > 0) {
        }
        int iNQPmNijIdMHTQdIJ = NQPmNijIdMHTQdIJ(parcel);
        YbAIMCjiyajjfwgB(parcel, 2, dKNrkBRpgjXEmgWz(this));
        XMyHpsxuzEMWrwKo(parcel, 3, PAQGuOpQAzBktMaJ(this), false);
        hULgDuCoDGqletDG(parcel, 4, AqSVomzJZecLyDLS(this), false);
        ynaWejoMHNcCSEbT(parcel, iNQPmNijIdMHTQdIJ);
    }
}

