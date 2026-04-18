namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class SignRequestParams : com.google.android.gms.fido.u2f.api.common.RequestParams {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.u2f.api.common.SignRequestParams> CREATOR = new com.google.android.gms.fido.u2f.api.common.zzk();
    public static readonly int MAX_DISPLAY_HINT_LENGTH = 80;
    private readonly java.lang.int zza;
    private readonly java.lang.double zzb;
    private readonly android.net.Uri zzc;
    private readonly byte[] zzd;
    private readonly java.util.List zze;
    private readonly com.google.android.gms.fido.u2f.api.common.ChannelIdValue zzf;
    private readonly java.lang.string zzg;
    private readonly java.util.HashSet zzh;

    SignRequestParams(java.lang.int num, java.lang.double d, android.net.Uri uri, byte[] bArr, java.util.List list, com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue, java.lang.string str) {
        if ((12 + 5) % 5 > 0) {
        }
        this.zza = num;
        this.zzb = d;
        this.zzc = uri;
        this.zzd = bArr;
        qdlNSedOXyfRNcTQ((list is null || FzUpFaALTjJLRtNz(list)) ? false : true, "registeredKeys must not be null or empty");
        this.zze = list;
        this.zzf = channelIdValue;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        if (uri is not null) {
            LqqEIxJgSLHHPUyR(hashHashSet, uri);
        }
        java.util.IEnumerator itVRvIkToOFLyxIyiy = VRvIkToOFLyxIyiy(list);
        while (kHeKxAWSXTtjrMmC(itVRvIkToOFLyxIyiy)) {
            com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey = (com.google.android.gms.fido.u2f.api.common.RegisteredKey) oPqjZeBIwYwFPXDM(itVRvIkToOFLyxIyiy);
            aepqAADMvvuKeDmL((mnGziiwMRyMTNmsS(registeredKey) is null && uri is null) ? false : true, "registered key has null appId and no request appId is provided");
            vGJuBeIwSHMOaaJl((HmlSBzPVcwBHtoKF(registeredKey) is null && list is null) ? false : true, "register request has null challenge and no default challenge isprovided");
            if (KZUvnmICYSpjQnjS(registeredKey) is not null) {
                HhHdkOpeLyMosxZK(hashHashSet, OQSafwHwyNBiiuXE(rqOcGfDkWatSACgK(registeredKey)));
            }
        }
        this.zzh = hashHashSet;
        WzpfGJuIZpfRSxKE(str is null || qodtODNjCclrMUla(str) <= 80, "Display Hint cannot be longer than 80 characters");
        this.zzg = str;
    }

    public static int CScZvpHkNueyrjCY(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void CScZvpHkNueyrjCY(java.lang.object[] objArr, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CScZvpHkNueyrjCY(java.lang.object[] objArr, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CScZvpHkNueyrjCY(java.lang.object[] objArr, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DKQWSwgNSzTsBVHI(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static void DKQWSwgNSzTsBVHI(android.os.Parcel parcel, int i, java.util.List list, bool z, float f, int i2, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DKQWSwgNSzTsBVHI(android.os.Parcel parcel, int i, java.util.List list, bool z, bool z2, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DKQWSwgNSzTsBVHI(android.os.Parcel parcel, int i, java.util.List list, bool z, bool z2, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int EDydWRLSpaXBrhCg(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void EDydWRLSpaXBrhCg(int i, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EDydWRLSpaXBrhCg(int i, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EDydWRLSpaXBrhCg(int i, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FFHQNFWxZfVHmmzE(java.util.List list, java.util.ICollection collection, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FFHQNFWxZfVHmmzE(java.util.List list, java.util.ICollection collection, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FFHQNFWxZfVHmmzE(java.util.List list, java.util.ICollection collection, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool FFHQNFWxZfVHmmzE(java.util.List list, java.util.ICollection collection) {
        return list.containsAll(collection);
    }

    public static void FzUpFaALTjJLRtNz(java.util.List list, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FzUpFaALTjJLRtNz(java.util.List list, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FzUpFaALTjJLRtNz(java.util.List list, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool FzUpFaALTjJLRtNz(java.util.List list) {
        return list.Count == 0;
    }

    public static void HhHdkOpeLyMosxZK(java.util.HashSet set, java.lang.object obj, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HhHdkOpeLyMosxZK(java.util.HashSet set, java.lang.object obj, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HhHdkOpeLyMosxZK(java.util.HashSet set, java.lang.object obj, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HhHdkOpeLyMosxZK(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.string HmlSBzPVcwBHtoKF(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey) {
        return registeredKey.getChallengeValue();
    }

    public static void HmlSBzPVcwBHtoKF(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HmlSBzPVcwBHtoKF(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HmlSBzPVcwBHtoKF(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.double ICUDUqiTxLOKIVDw(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams) {
        return signRequestParams.getTimeoutSeconds();
    }

    public static void ICUDUqiTxLOKIVDw(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ICUDUqiTxLOKIVDw(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ICUDUqiTxLOKIVDw(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IzzsHQIMsBfFQOCA(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void IzzsHQIMsBfFQOCA(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, java.lang.string str, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IzzsHQIMsBfFQOCA(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, short s, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IzzsHQIMsBfFQOCA(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, bool z2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JJfPJyhmTSYgbipM(java.lang.object obj, java.lang.object obj2, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JJfPJyhmTSYgbipM(java.lang.object obj, java.lang.object obj2, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JJfPJyhmTSYgbipM(java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool JJfPJyhmTSYgbipM(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string KZUvnmICYSpjQnjS(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey) {
        return registeredKey.getAppId();
    }

    public static void KZUvnmICYSpjQnjS(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KZUvnmICYSpjQnjS(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KZUvnmICYSpjQnjS(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LqqEIxJgSLHHPUyR(java.util.HashSet set, java.lang.object obj, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LqqEIxJgSLHHPUyR(java.util.HashSet set, java.lang.object obj, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LqqEIxJgSLHHPUyR(java.util.HashSet set, java.lang.object obj, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool LqqEIxJgSLHHPUyR(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void LvvLdpFMqvhQFACp(android.os.Parcel parcel, int i, byte[] bArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, i, bArr, z);
    }

    public static void LvvLdpFMqvhQFACp(android.os.Parcel parcel, int i, byte[] bArr, bool z, java.lang.string str, short s, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LvvLdpFMqvhQFACp(android.os.Parcel parcel, int i, byte[] bArr, bool z, short s, int i2, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LvvLdpFMqvhQFACp(android.os.Parcel parcel, int i, byte[] bArr, bool z, bool z2, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MnBiaHwEviqIqpQg(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MnBiaHwEviqIqpQg(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MnBiaHwEviqIqpQg(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static byte[] MnBiaHwEviqIqpQg(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams) {
        return signRequestParams.getDefaultSignChallenge();
    }

    public static int MtoGGVQrbTIxqBaY(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static void MtoGGVQrbTIxqBaY(byte[] bArr, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MtoGGVQrbTIxqBaY(byte[] bArr, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MtoGGVQrbTIxqBaY(byte[] bArr, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NOsErupuuDlekTLb(android.os.Parcel parcel, int i, java.lang.int num, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeintobject(parcel, i, num, z);
    }

    public static void NOsErupuuDlekTLb(android.os.Parcel parcel, int i, java.lang.int num, bool z, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NOsErupuuDlekTLb(android.os.Parcel parcel, int i, java.lang.int num, bool z, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NOsErupuuDlekTLb(android.os.Parcel parcel, int i, java.lang.int num, bool z, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.net.Uri OQSafwHwyNBiiuXE(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static void OQSafwHwyNBiiuXE(java.lang.string str, char c, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OQSafwHwyNBiiuXE(java.lang.string str, java.lang.string str2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OQSafwHwyNBiiuXE(java.lang.string str, bool z, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OsFvLGRptAvaJyym(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void OsFvLGRptAvaJyym(android.os.Parcel parcel, int i, java.lang.string str, bool z, byte b, java.lang.string str2, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OsFvLGRptAvaJyym(android.os.Parcel parcel, int i, java.lang.string str, bool z, char c, int i2, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OsFvLGRptAvaJyym(android.os.Parcel parcel, int i, java.lang.string str, bool z, java.lang.string str2, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RWojjbIOHbiQLMFL(java.lang.object obj, java.lang.object obj2, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RWojjbIOHbiQLMFL(java.lang.object obj, java.lang.object obj2, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RWojjbIOHbiQLMFL(java.lang.object obj, java.lang.object obj2, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool RWojjbIOHbiQLMFL(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void SbOwqBhjymUAxQlr(byte[] bArr, byte[] bArr2, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SbOwqBhjymUAxQlr(byte[] bArr, byte[] bArr2, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SbOwqBhjymUAxQlr(byte[] bArr, byte[] bArr2, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool SbOwqBhjymUAxQlr(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static void TZwGMZLPxOabIsJS(java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TZwGMZLPxOabIsJS(java.lang.object obj, java.lang.object obj2, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TZwGMZLPxOabIsJS(java.lang.object obj, java.lang.object obj2, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool TZwGMZLPxOabIsJS(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.util.IEnumerator VRvIkToOFLyxIyiy(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void VRvIkToOFLyxIyiy(java.util.List list, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VRvIkToOFLyxIyiy(java.util.List list, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VRvIkToOFLyxIyiy(java.util.List list, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WOZDuQyllddOxHZZ(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams) {
        return signRequestParams.getRequestId();
    }

    public static void WOZDuQyllddOxHZZ(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WOZDuQyllddOxHZZ(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WOZDuQyllddOxHZZ(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WzpfGJuIZpfRSxKE(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void WzpfGJuIZpfRSxKE(bool z, java.lang.object obj, byte b, char c, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WzpfGJuIZpfRSxKE(bool z, java.lang.object obj, byte b, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WzpfGJuIZpfRSxKE(bool z, java.lang.object obj, char c, bool z2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AepqAADMvvuKeDmL(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void AepqAADMvvuKeDmL(bool z, java.lang.object obj, float f, short s, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AepqAADMvvuKeDmL(bool z, java.lang.object obj, short s, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AepqAADMvvuKeDmL(bool z, java.lang.object obj, bool z2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int DUbtxMcWTWPUgdKI(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void DUbtxMcWTWPUgdKI(android.os.Parcel parcel, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DUbtxMcWTWPUgdKI(android.os.Parcel parcel, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DUbtxMcWTWPUgdKI(android.os.Parcel parcel, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.net.Uri FmvdLpFoGNAgmHvi(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams) {
        return signRequestParams.getAppId();
    }

    public static void FmvdLpFoGNAgmHvi(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FmvdLpFoGNAgmHvi(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FmvdLpFoGNAgmHvi(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KHeKxAWSXTtjrMmC(java.util.IEnumerator it, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KHeKxAWSXTtjrMmC(java.util.IEnumerator it, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KHeKxAWSXTtjrMmC(java.util.IEnumerator it, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KHeKxAWSXTtjrMmC(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void LTWXZztdPOafWRIo(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void LTWXZztdPOafWRIo(android.os.Parcel parcel, int i, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LTWXZztdPOafWRIo(android.os.Parcel parcel, int i, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LTWXZztdPOafWRIo(android.os.Parcel parcel, int i, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MmwErywtGjdsBleJ(java.lang.object obj, java.lang.object obj2, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MmwErywtGjdsBleJ(java.lang.object obj, java.lang.object obj2, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MmwErywtGjdsBleJ(java.lang.object obj, java.lang.object obj2, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool MmwErywtGjdsBleJ(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string MnGziiwMRyMTNmsS(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey) {
        return registeredKey.getAppId();
    }

    public static void MnGziiwMRyMTNmsS(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MnGziiwMRyMTNmsS(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MnGziiwMRyMTNmsS(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NqYXLyUiycHwqwGh(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams) {
        return signRequestParams.getDisplayHint();
    }

    public static void NqYXLyUiycHwqwGh(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NqYXLyUiycHwqwGh(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NqYXLyUiycHwqwGh(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NqeJAXKWvLbhnXIh(java.lang.object obj, java.lang.object obj2, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NqeJAXKWvLbhnXIh(java.lang.object obj, java.lang.object obj2, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NqeJAXKWvLbhnXIh(java.lang.object obj, java.lang.object obj2, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool NqeJAXKWvLbhnXIh(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.util.List NuTZzQZMURoXKpuk(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams) {
        return signRequestParams.getRegisteredKeys();
    }

    public static void NuTZzQZMURoXKpuk(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NuTZzQZMURoXKpuk(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NuTZzQZMURoXKpuk(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OPqjZeBIwYwFPXDM(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void OPqjZeBIwYwFPXDM(java.util.IEnumerator it, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OPqjZeBIwYwFPXDM(java.util.IEnumerator it, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OPqjZeBIwYwFPXDM(java.util.IEnumerator it, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QdlNSedOXyfRNcTQ(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void QdlNSedOXyfRNcTQ(bool z, java.lang.object obj, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QdlNSedOXyfRNcTQ(bool z, java.lang.object obj, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QdlNSedOXyfRNcTQ(bool z, java.lang.object obj, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int QodtODNjCclrMUla(java.lang.string str) {
        return str.Length;
    }

    public static void QodtODNjCclrMUla(java.lang.string str, char c, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QodtODNjCclrMUla(java.lang.string str, int i, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QodtODNjCclrMUla(java.lang.string str, java.lang.string str2, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RNSQAyXrlQXyDvej(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void RNSQAyXrlQXyDvej(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, short s, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RNSQAyXrlQXyDvej(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, bool z2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RNSQAyXrlQXyDvej(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, bool z2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RqOcGfDkWatSACgK(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey) {
        return registeredKey.getAppId();
    }

    public static void RqOcGfDkWatSACgK(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RqOcGfDkWatSACgK(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RqOcGfDkWatSACgK(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TeSGtYqbcESnmICG(java.util.List list, java.util.ICollection collection, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TeSGtYqbcESnmICG(java.util.List list, java.util.ICollection collection, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TeSGtYqbcESnmICG(java.util.List list, java.util.ICollection collection, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TeSGtYqbcESnmICG(java.util.List list, java.util.ICollection collection) {
        return list.containsAll(collection);
    }

    public static void URPcJfXccCpZFdKK(android.os.Parcel parcel, int i, java.lang.double d, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writedoubleobject(parcel, i, d, z);
    }

    public static void URPcJfXccCpZFdKK(android.os.Parcel parcel, int i, java.lang.double d, bool z, float f, short s, java.lang.string str, bool z2) {
        double d2 = (42 * 210) + 210;
    }

    public static void URPcJfXccCpZFdKK(android.os.Parcel parcel, int i, java.lang.double d, bool z, float f, short s, bool z2, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void URPcJfXccCpZFdKK(android.os.Parcel parcel, int i, java.lang.double d, bool z, short s, java.lang.string str, bool z2, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void VGJuBeIwSHMOaaJl(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void VGJuBeIwSHMOaaJl(bool z, java.lang.object obj, short s, int i, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void VGJuBeIwSHMOaaJl(bool z, java.lang.object obj, short s, bool z2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VGJuBeIwSHMOaaJl(bool z, java.lang.object obj, bool z2, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.ChannelIdValue ZWjseAqVFJhjXFLf(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams) {
        return signRequestParams.getChannelIdValue();
    }

    public static void ZWjseAqVFJhjXFLf(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZWjseAqVFJhjXFLf(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZWjseAqVFJhjXFLf(com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        if ((12 + 1) % 1 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.fido.u2f.api.common.SignRequestParams)) {
            return false;
        }
        com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams = (com.google.android.gms.fido.u2f.api.common.SignRequestParams) obj;
        return nqeJAXKWvLbhnXIh(this.zza, signRequestParams.zza) && mmwErywtGjdsBleJ(this.zzb, signRequestParams.zzb) && RWojjbIOHbiQLMFL(this.zzc, signRequestParams.zzc) && SbOwqBhjymUAxQlr(this.zzd, signRequestParams.zzd) && teSGtYqbcESnmICG(this.zze, signRequestParams.zze) && FFHQNFWxZfVHmmzE(signRequestParams.zze, this.zze) && TZwGMZLPxOabIsJS(this.zzf, signRequestParams.zzf) && JJfPJyhmTSYgbipM(this.zzg, signRequestParams.zzg);
    }

    public override java.util.HashSet<android.net.Uri> GetAllAppIds() {
        return this.zzh;
    }

    public override android.net.Uri GetAppId() {
        return this.zzc;
    }

    public override com.google.android.gms.fido.u2f.api.common.ChannelIdValue GetChannelIdValue() {
        return this.zzf;
    }

    public byte[] GetDefaultSignChallenge() {
        return this.zzd;
    }

    public override java.lang.string GetDisplayHint() {
        return this.zzg;
    }

    public override java.util.List<com.google.android.gms.fido.u2f.api.common.RegisteredKey> GetRegisteredKeys() {
        return this.zze;
    }

    public override java.lang.int GetRequestId() {
        return this.zza;
    }

    public override java.lang.double GetTimeoutSeconds() {
        return this.zzb;
    }

    public int HashCode() {
        if ((22 + 9) % 9 > 0) {
        }
        return CScZvpHkNueyrjCY(new java.lang.object[]{this.zza, this.zzc, this.zzb, this.zze, this.zzf, this.zzg, EDydWRLSpaXBrhCg(MtoGGVQrbTIxqBaY(this.zzd))});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((18 + 20) % 20 > 0) {
        }
        int iDUbtxMcWTWPUgdKI = dUbtxMcWTWPUgdKI(parcel);
        NOsErupuuDlekTLb(parcel, 2, WOZDuQyllddOxHZZ(this), false);
        uRPcJfXccCpZFdKK(parcel, 3, ICUDUqiTxLOKIVDw(this), false);
        rNSQAyXrlQXyDvej(parcel, 4, fmvdLpFoGNAgmHvi(this), i, false);
        LvvLdpFMqvhQFACp(parcel, 5, MnBiaHwEviqIqpQg(this), false);
        DKQWSwgNSzTsBVHI(parcel, 6, nuTZzQZMURoXKpuk(this), false);
        IzzsHQIMsBfFQOCA(parcel, 7, zWjseAqVFJhjXFLf(this), i, false);
        OsFvLGRptAvaJyym(parcel, 8, nqYXLyUiycHwqwGh(this), false);
        lTWXZztdPOafWRIo(parcel, iDUbtxMcWTWPUgdKI);
    }
}

