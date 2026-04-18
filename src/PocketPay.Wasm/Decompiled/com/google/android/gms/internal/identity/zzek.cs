namespace WillowMaze.Wasm.Decompiled;


public readonly class zzek : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.location.Geofence {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.internal.identity.zzek> CREATOR = new com.google.android.gms.internal.identity.zzel();
    private readonly java.lang.string zza;
    private readonly long zzb;
    private readonly short zzc;
    private readonly double zzd;
    private readonly double zze;
    private readonly float zzf;
    private readonly int zzg;
    private readonly int zzh;
    private readonly int zzi;

    public zzek(java.lang.string str, int i, short s, double d, double d2, float f, long j, int i2, int i3) {
        if ((31 + 14) % 14 > 0) {
        }
        if (str is null || ceIfvnTVymUQKWxA(str) > 100) {
            fAWyCvKviRrlaFoK(str);
            throw new java.lang.IllegalArgumentException(zaXIzszPgHGozstF("requestId is null or too long: ", oObOENnncJHXiESS(str)));
        }
        if (f <= 0.0f) {
            java.lang.stringBuilder sb = new java.lang.stringBuilder(zfmDEtWrJREOrsAh(yNNfsXKVcznHdnoU(f)) + 16);
            VutxqxjHqLQGchvM(sb, "invalid radius: ");
            kJEtpJhHQyQbGlDY(sb, f);
            throw new java.lang.IllegalArgumentException(EAJUxuBmrpdPTpiq(sb));
        }
        if (d > 90.0d || d < -90.0d) {
            java.lang.stringBuilder sb2 = new java.lang.stringBuilder(cmMXTRNgkWroBliX(iNMewPPdvBfkJIBE(d)) + 18);
            tZAiowgMfYpysZxd(sb2, "invalid latitude: ");
            vaiAycjyFxGLmhYA(sb2, d);
            throw new java.lang.IllegalArgumentException(VMpLhYKUAkIjAOrq(sb2));
        }
        if (d2 > 180.0d || d2 < -180.0d) {
            java.lang.stringBuilder sb3 = new java.lang.stringBuilder(dQJBxfQsAHbjtmxy(GlkkbnfBQlAQywGQ(d2)) + 19);
            JARvJnGrGZCDPmPA(sb3, "invalid longitude: ");
            anuZoCzqpoFrGvQs(sb3, d2);
            throw new java.lang.IllegalArgumentException(wTOvGcRoBWMhjIrq(sb3));
        }
        int i4 = i & 7;
        if (i4 == 0) {
            java.lang.stringBuilder sb4 = new java.lang.stringBuilder(BEWZSOEannCqFrEa(mRvlIuMkwvLRUKkI(i)) + 35);
            BorcGcZFuFKYIqMt(sb4, "No supported transition specified: ");
            yBVBeuKrnLaMMnHJ(sb4, i);
            throw new java.lang.IllegalArgumentException(uTfihzxzDlqDGGiG(sb4));
        }
        this.zzc = s;
        this.zza = str;
        this.zzd = d;
        this.zze = d2;
        this.zzf = f;
        this.zzb = j;
        this.zzg = i4;
        this.zzh = i2;
        this.zzi = i3;
    }

    public static int BEWZSOEannCqFrEa(java.lang.string str) {
        return str.Length;
    }

    public static void BEWZSOEannCqFrEa(java.lang.string str, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BEWZSOEannCqFrEa(java.lang.string str, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BEWZSOEannCqFrEa(java.lang.string str, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BHMdEGQemCXgAMZt(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static void BHMdEGQemCXgAMZt(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BHMdEGQemCXgAMZt(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BHMdEGQemCXgAMZt(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BorcGcZFuFKYIqMt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BorcGcZFuFKYIqMt(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BorcGcZFuFKYIqMt(java.lang.stringBuilder sb, java.lang.string str, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BorcGcZFuFKYIqMt(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.float CyQcOIhPxpKdyBPo(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void CyQcOIhPxpKdyBPo(float f, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CyQcOIhPxpKdyBPo(float f, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CyQcOIhPxpKdyBPo(float f, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EAJUxuBmrpdPTpiq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void EAJUxuBmrpdPTpiq(java.lang.stringBuilder sb, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EAJUxuBmrpdPTpiq(java.lang.stringBuilder sb, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EAJUxuBmrpdPTpiq(java.lang.stringBuilder sb, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static long ExUJZRfHLPSVTnrG(double d) {
        if ((11 + 10) % 10 > 0) {
        }
        return java.lang.double.doubleTolongBits(d);
    }

    public static void ExUJZRfHLPSVTnrG(double d, int i, java.lang.string str, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void ExUJZRfHLPSVTnrG(double d, short s, java.lang.string str, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void ExUJZRfHLPSVTnrG(double d, bool z, short s, java.lang.string str, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void FHgWfNQeRnqtxBQy(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void FHgWfNQeRnqtxBQy(android.os.Parcel parcel, int i, int i2, float f, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FHgWfNQeRnqtxBQy(android.os.Parcel parcel, int i, int i2, int i3, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FHgWfNQeRnqtxBQy(android.os.Parcel parcel, int i, int i2, java.lang.string str, float f, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void FmPAIFuhHjZkXbyl(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void FmPAIFuhHjZkXbyl(android.os.Parcel parcel, int i, java.lang.string str, bool z, int i2, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FmPAIFuhHjZkXbyl(android.os.Parcel parcel, int i, java.lang.string str, bool z, bool z2, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FmPAIFuhHjZkXbyl(android.os.Parcel parcel, int i, java.lang.string str, bool z, bool z2, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GlkkbnfBQlAQywGQ(double d) {
        return java.lang.string.valueOf(d);
    }

    public static void GlkkbnfBQlAQywGQ(double d, char c, bool z, byte b, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void GlkkbnfBQlAQywGQ(double d, java.lang.string str, byte b, bool z, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void GlkkbnfBQlAQywGQ(double d, bool z, java.lang.string str, char c, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JARvJnGrGZCDPmPA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JARvJnGrGZCDPmPA(java.lang.stringBuilder sb, java.lang.string str, char c, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JARvJnGrGZCDPmPA(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JARvJnGrGZCDPmPA(java.lang.stringBuilder sb, java.lang.string str, short s, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JxrkYpeZzbntMQuZ(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void JxrkYpeZzbntMQuZ(android.os.Parcel parcel, int i, int i2, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JxrkYpeZzbntMQuZ(android.os.Parcel parcel, int i, int i2, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JxrkYpeZzbntMQuZ(android.os.Parcel parcel, int i, int i2, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.long LiLaspThydOToQxX(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void LiLaspThydOToQxX(long j, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LiLaspThydOToQxX(long j, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LiLaspThydOToQxX(long j, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MUIxHXTTjyfilzfT(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void MUIxHXTTjyfilzfT(android.os.Parcel parcel, int i, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MUIxHXTTjyfilzfT(android.os.Parcel parcel, int i, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MUIxHXTTjyfilzfT(android.os.Parcel parcel, int i, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SFknmFUPumFyOseJ(android.os.Parcel parcel, int i, float f) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writefloat(parcel, i, f);
    }

    public static void SFknmFUPumFyOseJ(android.os.Parcel parcel, int i, float f, byte b, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SFknmFUPumFyOseJ(android.os.Parcel parcel, int i, float f, byte b, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SFknmFUPumFyOseJ(android.os.Parcel parcel, int i, float f, byte b, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VMpLhYKUAkIjAOrq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VMpLhYKUAkIjAOrq(java.lang.stringBuilder sb, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VMpLhYKUAkIjAOrq(java.lang.stringBuilder sb, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VMpLhYKUAkIjAOrq(java.lang.stringBuilder sb, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VutxqxjHqLQGchvM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VutxqxjHqLQGchvM(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VutxqxjHqLQGchvM(java.lang.stringBuilder sb, java.lang.string str, char c, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VutxqxjHqLQGchvM(java.lang.stringBuilder sb, java.lang.string str, char c, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WGhrSkjgVxxdCvLV(android.os.Parcel parcel, int i, double d) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writedouble(parcel, i, d);
    }

    public static void WGhrSkjgVxxdCvLV(android.os.Parcel parcel, int i, double d, char c, int i2, float f, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void WGhrSkjgVxxdCvLV(android.os.Parcel parcel, int i, double d, int i2, short s, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void WGhrSkjgVxxdCvLV(android.os.Parcel parcel, int i, double d, short s, char c, int i2, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void APAMHFAgHXpkLDOS(android.os.Parcel parcel, int i, double d) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writedouble(parcel, i, d);
    }

    public static void APAMHFAgHXpkLDOS(android.os.Parcel parcel, int i, double d, byte b, float f, java.lang.string str, int i2) {
        double d2 = (42 * 210) + 210;
    }

    public static void APAMHFAgHXpkLDOS(android.os.Parcel parcel, int i, double d, byte b, int i2, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void APAMHFAgHXpkLDOS(android.os.Parcel parcel, int i, double d, int i2, java.lang.string str, float f, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder AnuZoCzqpoFrGvQs(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static void AnuZoCzqpoFrGvQs(java.lang.stringBuilder sb, double d, byte b, java.lang.string str, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void AnuZoCzqpoFrGvQs(java.lang.stringBuilder sb, double d, java.lang.string str, byte b, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void AnuZoCzqpoFrGvQs(java.lang.stringBuilder sb, double d, bool z, java.lang.string str, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static java.lang.double BrTLocjAgxAzacBp(double d) {
        return java.lang.double.valueOf(d);
    }

    public static void BrTLocjAgxAzacBp(double d, int i, bool z, java.lang.string str, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void BrTLocjAgxAzacBp(double d, java.lang.string str, short s, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void BrTLocjAgxAzacBp(double d, bool z, java.lang.string str, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static int CeIfvnTVymUQKWxA(java.lang.string str) {
        return str.Length;
    }

    public static void CeIfvnTVymUQKWxA(java.lang.string str, byte b, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CeIfvnTVymUQKWxA(java.lang.string str, byte b, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CeIfvnTVymUQKWxA(java.lang.string str, int i, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static int CmMXTRNgkWroBliX(java.lang.string str) {
        return str.Length;
    }

    public static void CmMXTRNgkWroBliX(java.lang.string str, float f, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CmMXTRNgkWroBliX(java.lang.string str, java.lang.string str2, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CmMXTRNgkWroBliX(java.lang.string str, short s, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int DQJBxfQsAHbjtmxy(java.lang.string str) {
        return str.Length;
    }

    public static void DQJBxfQsAHbjtmxy(java.lang.string str, char c, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DQJBxfQsAHbjtmxy(java.lang.string str, short s, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DQJBxfQsAHbjtmxy(java.lang.string str, bool z, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static int DkBDMJcqcTqVSdOV(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void DkBDMJcqcTqVSdOV(android.os.Parcel parcel, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DkBDMJcqcTqVSdOV(android.os.Parcel parcel, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DkBDMJcqcTqVSdOV(android.os.Parcel parcel, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FAWyCvKviRrlaFoK(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void FAWyCvKviRrlaFoK(java.lang.object obj, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FAWyCvKviRrlaFoK(java.lang.object obj, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FAWyCvKviRrlaFoK(java.lang.object obj, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int GpSYVvwMYNewkTUY(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void GpSYVvwMYNewkTUY(int i, byte b, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GpSYVvwMYNewkTUY(int i, byte b, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GpSYVvwMYNewkTUY(int i, java.lang.string str, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int HkkRjExDMYuOqzHP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HkkRjExDMYuOqzHP(int i, int i2, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HkkRjExDMYuOqzHP(int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HkkRjExDMYuOqzHP(int i, bool z, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string INMewPPdvBfkJIBE(double d) {
        return java.lang.string.valueOf(d);
    }

    public static void INMewPPdvBfkJIBE(double d, int i, char c, float f, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void INMewPPdvBfkJIBE(double d, bool z, char c, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void INMewPPdvBfkJIBE(double d, bool z, float f, int i, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void JOjjcgouyeaQsXxt(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static void JOjjcgouyeaQsXxt(android.os.Parcel parcel, int i, long j, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JOjjcgouyeaQsXxt(android.os.Parcel parcel, int i, long j, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JOjjcgouyeaQsXxt(android.os.Parcel parcel, int i, long j, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KJEtpJhHQyQbGlDY(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static void KJEtpJhHQyQbGlDY(java.lang.stringBuilder sb, float f, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KJEtpJhHQyQbGlDY(java.lang.stringBuilder sb, float f, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KJEtpJhHQyQbGlDY(java.lang.stringBuilder sb, float f, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MRvlIuMkwvLRUKkI(int i) {
        return java.lang.string.valueOf(i);
    }

    public static void MRvlIuMkwvLRUKkI(int i, java.lang.string str, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MRvlIuMkwvLRUKkI(int i, java.lang.string str, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MRvlIuMkwvLRUKkI(int i, java.lang.string str, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OObOENnncJHXiESS(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void OObOENnncJHXiESS(java.lang.object obj, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OObOENnncJHXiESS(java.lang.object obj, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OObOENnncJHXiESS(java.lang.object obj, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PHAqcXtagyMgEJBW(android.os.Parcel parcel, int i, short s) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeshort(parcel, i, s);
    }

    public static void PHAqcXtagyMgEJBW(android.os.Parcel parcel, int i, short s, int i2, float f, short s2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PHAqcXtagyMgEJBW(android.os.Parcel parcel, int i, short s, bool z, float f, short s2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PHAqcXtagyMgEJBW(android.os.Parcel parcel, int i, short s, bool z, short s2, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static long RtNOaCZCmtLYEdDT(double d) {
        if ((8 + 22) % 22 > 0) {
        }
        return java.lang.double.doubleTolongBits(d);
    }

    public static void RtNOaCZCmtLYEdDT(double d, float f, int i, java.lang.string str, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void RtNOaCZCmtLYEdDT(double d, float f, short s, int i, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void RtNOaCZCmtLYEdDT(double d, short s, int i, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static int TXOqGaUeYWcKIzCr(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    public static void TXOqGaUeYWcKIzCr(float f, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TXOqGaUeYWcKIzCr(float f, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TXOqGaUeYWcKIzCr(float f, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TZAiowgMfYpysZxd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TZAiowgMfYpysZxd(java.lang.stringBuilder sb, java.lang.string str, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TZAiowgMfYpysZxd(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TZAiowgMfYpysZxd(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UTfihzxzDlqDGGiG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void UTfihzxzDlqDGGiG(java.lang.stringBuilder sb, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UTfihzxzDlqDGGiG(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UTfihzxzDlqDGGiG(java.lang.stringBuilder sb, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UlBPBmAOQlByUTTP(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static void UlBPBmAOQlByUTTP(java.lang.string str, java.lang.string str2, java.lang.string str3, char c, byte b, int i, java.lang.string str4) {
        double d = (42 * 210) + 210;
    }

    public static void UlBPBmAOQlByUTTP(java.lang.string str, java.lang.string str2, java.lang.string str3, char c, java.lang.string str4, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UlBPBmAOQlByUTTP(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UrYgarPAjLVkiJFB(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void UrYgarPAjLVkiJFB(android.os.Parcel parcel, int i, int i2, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UrYgarPAjLVkiJFB(android.os.Parcel parcel, int i, int i2, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UrYgarPAjLVkiJFB(android.os.Parcel parcel, int i, int i2, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VaiAycjyFxGLmhYA(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static void VaiAycjyFxGLmhYA(java.lang.stringBuilder sb, double d, float f, bool z, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void VaiAycjyFxGLmhYA(java.lang.stringBuilder sb, double d, java.lang.string str, bool z, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void VaiAycjyFxGLmhYA(java.lang.stringBuilder sb, double d, bool z, float f, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static java.lang.double VeRTrPkVwocqmQPh(double d) {
        return java.lang.double.valueOf(d);
    }

    public static void VeRTrPkVwocqmQPh(double d, byte b, int i, bool z, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void VeRTrPkVwocqmQPh(double d, int i, java.lang.string str, byte b, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void VeRTrPkVwocqmQPh(double d, int i, bool z, byte b, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static java.lang.string WTOvGcRoBWMhjIrq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WTOvGcRoBWMhjIrq(java.lang.stringBuilder sb, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WTOvGcRoBWMhjIrq(java.lang.stringBuilder sb, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WTOvGcRoBWMhjIrq(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WhbTnFlkRLyJuHGu(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void WhbTnFlkRLyJuHGu(int i, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WhbTnFlkRLyJuHGu(int i, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WhbTnFlkRLyJuHGu(int i, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YBVBeuKrnLaMMnHJ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void YBVBeuKrnLaMMnHJ(java.lang.stringBuilder sb, int i, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YBVBeuKrnLaMMnHJ(java.lang.stringBuilder sb, int i, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YBVBeuKrnLaMMnHJ(java.lang.stringBuilder sb, int i, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YNNfsXKVcznHdnoU(float f) {
        return java.lang.string.valueOf(f);
    }

    public static void YNNfsXKVcznHdnoU(float f, float f2, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YNNfsXKVcznHdnoU(float f, float f2, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YNNfsXKVcznHdnoU(float f, java.lang.string str, float f2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZaXIzszPgHGozstF(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static void ZaXIzszPgHGozstF(java.lang.string str, java.lang.string str2, int i, java.lang.string str3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZaXIzszPgHGozstF(java.lang.string str, java.lang.string str2, int i, bool z, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void ZaXIzszPgHGozstF(java.lang.string str, java.lang.string str2, short s, int i, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int ZfmDEtWrJREOrsAh(java.lang.string str) {
        return str.Length;
    }

    public static void ZfmDEtWrJREOrsAh(java.lang.string str, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZfmDEtWrJREOrsAh(java.lang.string str, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZfmDEtWrJREOrsAh(java.lang.string str, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((13 + 28) % 28 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is com.google.android.gms.internal.identity.zzek) {
            com.google.android.gms.internal.identity.zzek zzekVar = (com.google.android.gms.internal.identity.zzek) obj;
            if (this.zzf == zzekVar.zzf && this.zzd == zzekVar.zzd && this.zze == zzekVar.zze && this.zzc == zzekVar.zzc && this.zzg == zzekVar.zzg) {
                return true;
            }
        }
        return false;
    }

    public override readonly long GetExpirationTime() {
        if ((22 + 14) % 14 > 0) {
        }
        return this.zzb;
    }

    public override readonly double GetLatitude() {
        if ((31 + 18) % 18 > 0) {
        }
        return this.zzd;
    }

    public override readonly int GetLoiteringDelay() {
        return this.zzi;
    }

    public override readonly double Getlongitude() {
        if ((28 + 6) % 6 > 0) {
        }
        return this.zze;
    }

    public override readonly int GetNotificationResponsiveness() {
        return this.zzh;
    }

    public override readonly float GetRadius() {
        return this.zzf;
    }

    public override readonly java.lang.string GetRequestId() {
        return this.zza;
    }

    public override readonly int GetTransitionTypes() {
        return this.zzg;
    }

    public readonly int HashCode() {
        if ((21 + 19) % 19 > 0) {
        }
        long jExUJZRfHLPSVTnrG = ExUJZRfHLPSVTnrG(this.zzd);
        long j = jExUJZRfHLPSVTnrG ^ (jExUJZRfHLPSVTnrG >>> 32);
        long jRtNOaCZCmtLYEdDT = rtNOaCZCmtLYEdDT(this.zze);
        return ((((((((((int) j) + 31) * 31) + ((int) (jRtNOaCZCmtLYEdDT ^ (jRtNOaCZCmtLYEdDT >>> 32)))) * 31) + tXOqGaUeYWcKIzCr(this.zzf)) * 31) + this.zzc) * 31) + this.zzg;
    }

    public readonly java.lang.string Tostring() {
        if ((22 + 22) % 22 > 0) {
        }
        short s = this.zzc;
        return BHMdEGQemCXgAMZt(java.util.Locale.US, "Geofence[%s id:%s transitions:%d %.6f, %.6f %.0fm, resp=%ds, dwell=%dms, @%d]", new java.lang.object[]{s == -1 ? "INVALID" : s == 1 ? "CIRCLE" : "UNKNOWN", ulBPBmAOQlByUTTP(this.zza, "\\p{C}", "?"), whbTnFlkRLyJuHGu(this.zzg), brTLocjAgxAzacBp(this.zzd), veRTrPkVwocqmQPh(this.zze), CyQcOIhPxpKdyBPo(this.zzf), gpSYVvwMYNewkTUY(this.zzh / 1000), hkkRjExDMYuOqzHP(this.zzi), LiLaspThydOToQxX(this.zzb)});
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((8 + 26) % 26 > 0) {
        }
        java.lang.string str = this.zza;
        int iDkBDMJcqcTqVSdOV = dkBDMJcqcTqVSdOV(parcel);
        FmPAIFuhHjZkXbyl(parcel, 1, str, false);
        jOjjcgouyeaQsXxt(parcel, 2, this.zzb);
        pHAqcXtagyMgEJBW(parcel, 3, this.zzc);
        aPAMHFAgHXpkLDOS(parcel, 4, this.zzd);
        WGhrSkjgVxxdCvLV(parcel, 5, this.zze);
        SFknmFUPumFyOseJ(parcel, 6, this.zzf);
        FHgWfNQeRnqtxBQy(parcel, 7, this.zzg);
        urYgarPAjLVkiJFB(parcel, 8, this.zzh);
        JxrkYpeZzbntMQuZ(parcel, 9, this.zzi);
        MUIxHXTTjyfilzfT(parcel, iDkBDMJcqcTqVSdOV);
    }
}

