namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class RegisterRequestParams : com.google.android.gms.fido.u2f.api.common.RequestParams {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.u2f.api.common.RegisterRequestParams> CREATOR = new com.google.android.gms.fido.u2f.api.common.zzh();
    public static readonly int MAX_DISPLAY_HINT_LENGTH = 80;
    private readonly java.lang.int zza;
    private readonly java.lang.double zzb;
    private readonly android.net.Uri zzc;
    private readonly java.util.List zzd;
    private readonly java.util.List zze;
    private readonly com.google.android.gms.fido.u2f.api.common.ChannelIdValue zzf;
    private readonly java.lang.string zzg;
    private java.util.HashSet zzh;

    RegisterRequestParams(java.lang.int num, java.lang.double d, android.net.Uri uri, java.util.List list, java.util.List list2, com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue, java.lang.string str) {
        if ((9 + 15) % 15 > 0) {
        }
        this.zza = num;
        this.zzb = d;
        this.zzc = uri;
        YVdALlhZYxjBKUtk((list is null || bJEUndTTIWdaGDXJ(list)) ? false : true, "empty list of register requests is provided");
        this.zzd = list;
        this.zze = list2;
        this.zzf = channelIdValue;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        if (uri is not null) {
            yaqbfTGrJDERyEuC(hashHashSet, uri);
        }
        java.util.IEnumerator itTkYujtAaBIxWGKcN = tkYujtAaBIxWGKcN(list);
        while (PePPcVikCoNrfTvZ(itTkYujtAaBIxWGKcN)) {
            com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest = (com.google.android.gms.fido.u2f.api.common.RegisterRequest) UGYsBszObhjvDGXP(itTkYujtAaBIxWGKcN);
            rftGkfUDkpgXYMZL((uri is null && oeryTBhsSqANyYdB(registerRequest) is null) ? false : true, "register request has null appId and no request appId is provided");
            if (JJMLkxtODhaAiVyn(registerRequest) is not null) {
                laUTviziDRVGTdne(hashHashSet, IRUtjlFBPlUyDrLO(QyabcJVPKnBDxNXz(registerRequest)));
            }
        }
        java.util.IEnumerator itJKCfOByDvzxjtNjV = jKCfOByDvzxjtNjV(list2);
        while (bxQEruYtnPexUfKe(itJKCfOByDvzxjtNjV)) {
            com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey = (com.google.android.gms.fido.u2f.api.common.RegisteredKey) EAcfPYqXEgkQntnB(itJKCfOByDvzxjtNjV);
            dSQcaPYegCdexFUe((uri is null && davDBxNOkuangGKZ(registeredKey) is null) ? false : true, "registered key has null appId and no request appId is provided");
            if (rEsTydOEzCnQQkLt(registeredKey) is not null) {
                iyJNRqqQJssoAEym(hashHashSet, QPKajfJNSPZHTJLx(lduNzHfkYkifGOGq(registeredKey)));
            }
        }
        this.zzh = hashHashSet;
        NoRomnmyyEMMEWEQ(str is null || mPSOiXCvNyvQuWAM(str) <= 80, "Display Hint cannot be longer than 80 characters");
        this.zzg = str;
    }

    public static java.lang.object EAcfPYqXEgkQntnB(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void EAcfPYqXEgkQntnB(java.util.IEnumerator it, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EAcfPYqXEgkQntnB(java.util.IEnumerator it, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EAcfPYqXEgkQntnB(java.util.IEnumerator it, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EddbmzPvoDXdISAo(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static void EddbmzPvoDXdISAo(android.os.Parcel parcel, int i, java.util.List list, bool z, byte b, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void EddbmzPvoDXdISAo(android.os.Parcel parcel, int i, java.util.List list, bool z, float f, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EddbmzPvoDXdISAo(android.os.Parcel parcel, int i, java.util.List list, bool z, bool z2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FtLwoBRWgVvtteaT(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void FtLwoBRWgVvtteaT(android.os.Parcel parcel, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FtLwoBRWgVvtteaT(android.os.Parcel parcel, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FtLwoBRWgVvtteaT(android.os.Parcel parcel, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GllAzQkaUXzmrjma(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void GllAzQkaUXzmrjma(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, byte b, int i3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GllAzQkaUXzmrjma(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, int i3, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GllAzQkaUXzmrjma(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, java.lang.string str, int i3, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GmMrivpKhFbSulqa(java.lang.object obj, java.lang.object obj2, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GmMrivpKhFbSulqa(java.lang.object obj, java.lang.object obj2, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GmMrivpKhFbSulqa(java.lang.object obj, java.lang.object obj2, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool GmMrivpKhFbSulqa(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static android.net.Uri IRUtjlFBPlUyDrLO(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static void IRUtjlFBPlUyDrLO(java.lang.string str, short s, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IRUtjlFBPlUyDrLO(java.lang.string str, short s, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IRUtjlFBPlUyDrLO(java.lang.string str, bool z, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JJMLkxtODhaAiVyn(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest) {
        return registerRequest.getAppId();
    }

    public static void JJMLkxtODhaAiVyn(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JJMLkxtODhaAiVyn(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JJMLkxtODhaAiVyn(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KrgqrAQezOkEsSuz(java.util.List list, java.util.ICollection collection, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KrgqrAQezOkEsSuz(java.util.List list, java.util.ICollection collection, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KrgqrAQezOkEsSuz(java.util.List list, java.util.ICollection collection, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KrgqrAQezOkEsSuz(java.util.List list, java.util.ICollection collection) {
        return list.containsAll(collection);
    }

    public static void LGAldefJCUoxcSdX(java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LGAldefJCUoxcSdX(java.lang.object obj, java.lang.object obj2, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LGAldefJCUoxcSdX(java.lang.object obj, java.lang.object obj2, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool LGAldefJCUoxcSdX(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void LiSIbUGzqStzhbGE(java.lang.object obj, java.lang.object obj2, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LiSIbUGzqStzhbGE(java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LiSIbUGzqStzhbGE(java.lang.object obj, java.lang.object obj2, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LiSIbUGzqStzhbGE(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.double LqnYFdjzyfcozCin(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams) {
        return registerRequestParams.getTimeoutSeconds();
    }

    public static void LqnYFdjzyfcozCin(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LqnYFdjzyfcozCin(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LqnYFdjzyfcozCin(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NoRomnmyyEMMEWEQ(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void NoRomnmyyEMMEWEQ(bool z, java.lang.object obj, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NoRomnmyyEMMEWEQ(bool z, java.lang.object obj, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NoRomnmyyEMMEWEQ(bool z, java.lang.object obj, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ORfOZIHddfLGHcpo(java.lang.object obj, java.lang.object obj2, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ORfOZIHddfLGHcpo(java.lang.object obj, java.lang.object obj2, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ORfOZIHddfLGHcpo(java.lang.object obj, java.lang.object obj2, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ORfOZIHddfLGHcpo(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void PePPcVikCoNrfTvZ(java.util.IEnumerator it, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PePPcVikCoNrfTvZ(java.util.IEnumerator it, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PePPcVikCoNrfTvZ(java.util.IEnumerator it, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool PePPcVikCoNrfTvZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.net.Uri QPKajfJNSPZHTJLx(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static void QPKajfJNSPZHTJLx(java.lang.string str, float f, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QPKajfJNSPZHTJLx(java.lang.string str, short s, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QPKajfJNSPZHTJLx(java.lang.string str, short s, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QyabcJVPKnBDxNXz(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest) {
        return registerRequest.getAppId();
    }

    public static void QyabcJVPKnBDxNXz(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QyabcJVPKnBDxNXz(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QyabcJVPKnBDxNXz(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RrmZeVFxIgUcYlqC(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void RrmZeVFxIgUcYlqC(android.os.Parcel parcel, int i, byte b, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RrmZeVFxIgUcYlqC(android.os.Parcel parcel, int i, byte b, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RrmZeVFxIgUcYlqC(android.os.Parcel parcel, int i, byte b, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UGYsBszObhjvDGXP(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void UGYsBszObhjvDGXP(java.util.IEnumerator it, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UGYsBszObhjvDGXP(java.util.IEnumerator it, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UGYsBszObhjvDGXP(java.util.IEnumerator it, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UbqqMioQUQQINraK(android.os.Parcel parcel, int i, java.lang.int num, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeintobject(parcel, i, num, z);
    }

    public static void UbqqMioQUQQINraK(android.os.Parcel parcel, int i, java.lang.int num, bool z, byte b, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UbqqMioQUQQINraK(android.os.Parcel parcel, int i, java.lang.int num, bool z, int i2, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UbqqMioQUQQINraK(android.os.Parcel parcel, int i, java.lang.int num, bool z, int i2, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UceVLACNlhUCURKA(java.util.List list, java.util.ICollection collection, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UceVLACNlhUCURKA(java.util.List list, java.util.ICollection collection, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UceVLACNlhUCURKA(java.util.List list, java.util.ICollection collection, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UceVLACNlhUCURKA(java.util.List list, java.util.ICollection collection) {
        return list.containsAll(collection);
    }

    public static java.lang.string WGQJqxmCDLJTkZSl(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams) {
        return registerRequestParams.getDisplayHint();
    }

    public static void WGQJqxmCDLJTkZSl(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WGQJqxmCDLJTkZSl(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WGQJqxmCDLJTkZSl(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YVdALlhZYxjBKUtk(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void YVdALlhZYxjBKUtk(bool z, java.lang.object obj, char c, int i, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YVdALlhZYxjBKUtk(bool z, java.lang.object obj, char c, bool z2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YVdALlhZYxjBKUtk(bool z, java.lang.object obj, int i, char c, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int ZMFyKaYvADnWPFJY(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams) {
        return registerRequestParams.getRequestId();
    }

    public static void ZMFyKaYvADnWPFJY(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZMFyKaYvADnWPFJY(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZMFyKaYvADnWPFJY(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BJEUndTTIWdaGDXJ(java.util.List list, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BJEUndTTIWdaGDXJ(java.util.List list, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BJEUndTTIWdaGDXJ(java.util.List list, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool BJEUndTTIWdaGDXJ(java.util.List list) {
        return list.Count == 0;
    }

    public static void BxQEruYtnPexUfKe(java.util.IEnumerator it, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BxQEruYtnPexUfKe(java.util.IEnumerator it, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BxQEruYtnPexUfKe(java.util.IEnumerator it, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool BxQEruYtnPexUfKe(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.gms.fido.u2f.api.common.ChannelIdValue DKVeAeZYPNeACAUe(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams) {
        return registerRequestParams.getChannelIdValue();
    }

    public static void DKVeAeZYPNeACAUe(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DKVeAeZYPNeACAUe(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DKVeAeZYPNeACAUe(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DSQcaPYegCdexFUe(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void DSQcaPYegCdexFUe(bool z, java.lang.object obj, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DSQcaPYegCdexFUe(bool z, java.lang.object obj, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DSQcaPYegCdexFUe(bool z, java.lang.object obj, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DavDBxNOkuangGKZ(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey) {
        return registeredKey.getAppId();
    }

    public static void DavDBxNOkuangGKZ(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DavDBxNOkuangGKZ(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DavDBxNOkuangGKZ(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EAyjRTIJJBUDmylF(java.lang.object obj, java.lang.object obj2, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EAyjRTIJJBUDmylF(java.lang.object obj, java.lang.object obj2, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EAyjRTIJJBUDmylF(java.lang.object obj, java.lang.object obj2, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool EAyjRTIJJBUDmylF(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static int HbRhQMnsFbAYSQoC(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void HbRhQMnsFbAYSQoC(java.lang.object[] objArr, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HbRhQMnsFbAYSQoC(java.lang.object[] objArr, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HbRhQMnsFbAYSQoC(java.lang.object[] objArr, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IyJNRqqQJssoAEym(java.util.HashSet set, java.lang.object obj, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IyJNRqqQJssoAEym(java.util.HashSet set, java.lang.object obj, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IyJNRqqQJssoAEym(java.util.HashSet set, java.lang.object obj, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool IyJNRqqQJssoAEym(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.util.IEnumerator JKCfOByDvzxjtNjV(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void JKCfOByDvzxjtNjV(java.util.List list, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JKCfOByDvzxjtNjV(java.util.List list, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JKCfOByDvzxjtNjV(java.util.List list, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LaUTviziDRVGTdne(java.util.HashSet set, java.lang.object obj, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LaUTviziDRVGTdne(java.util.HashSet set, java.lang.object obj, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LaUTviziDRVGTdne(java.util.HashSet set, java.lang.object obj, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool LaUTviziDRVGTdne(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.string LduNzHfkYkifGOGq(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey) {
        return registeredKey.getAppId();
    }

    public static void LduNzHfkYkifGOGq(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LduNzHfkYkifGOGq(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LduNzHfkYkifGOGq(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.net.Uri LzajvubMVoRTAbfz(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams) {
        return registerRequestParams.getAppId();
    }

    public static void LzajvubMVoRTAbfz(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LzajvubMVoRTAbfz(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LzajvubMVoRTAbfz(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int MPSOiXCvNyvQuWAM(java.lang.string str) {
        return str.Length;
    }

    public static void MPSOiXCvNyvQuWAM(java.lang.string str, char c, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MPSOiXCvNyvQuWAM(java.lang.string str, java.lang.string str2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MPSOiXCvNyvQuWAM(java.lang.string str, java.lang.string str2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MlRmYlcYpXYYJTKM(java.lang.object obj, java.lang.object obj2, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MlRmYlcYpXYYJTKM(java.lang.object obj, java.lang.object obj2, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MlRmYlcYpXYYJTKM(java.lang.object obj, java.lang.object obj2, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool MlRmYlcYpXYYJTKM(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string OeryTBhsSqANyYdB(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest) {
        return registerRequest.getAppId();
    }

    public static void OeryTBhsSqANyYdB(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OeryTBhsSqANyYdB(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OeryTBhsSqANyYdB(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OxnLBMKgIbZrdyMi(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void OxnLBMKgIbZrdyMi(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, short s, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OxnLBMKgIbZrdyMi(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, bool z2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OxnLBMKgIbZrdyMi(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, bool z2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void POClvstWmrTLJrBI(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static void POClvstWmrTLJrBI(android.os.Parcel parcel, int i, java.util.List list, bool z, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void POClvstWmrTLJrBI(android.os.Parcel parcel, int i, java.util.List list, bool z, java.lang.string str, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void POClvstWmrTLJrBI(android.os.Parcel parcel, int i, java.util.List list, bool z, short s, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string REsTydOEzCnQQkLt(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey) {
        return registeredKey.getAppId();
    }

    public static void REsTydOEzCnQQkLt(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void REsTydOEzCnQQkLt(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void REsTydOEzCnQQkLt(com.google.android.gms.fido.u2f.api.common.RegisteredKey registeredKey, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RftGkfUDkpgXYMZL(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void RftGkfUDkpgXYMZL(bool z, java.lang.object obj, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RftGkfUDkpgXYMZL(bool z, java.lang.object obj, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RftGkfUDkpgXYMZL(bool z, java.lang.object obj, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SjWKWJnLpNcHLAhr(android.os.Parcel parcel, int i, java.lang.double d, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writedoubleobject(parcel, i, d, z);
    }

    public static void SjWKWJnLpNcHLAhr(android.os.Parcel parcel, int i, java.lang.double d, bool z, char c, int i2, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void SjWKWJnLpNcHLAhr(android.os.Parcel parcel, int i, java.lang.double d, bool z, float f, char c, int i2, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void SjWKWJnLpNcHLAhr(android.os.Parcel parcel, int i, java.lang.double d, bool z, float f, char c, java.lang.string str, int i2) {
        double d2 = (42 * 210) + 210;
    }

    public static java.util.List TZrgdLixhayjTOtM(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams) {
        return registerRequestParams.getRegisteredKeys();
    }

    public static void TZrgdLixhayjTOtM(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TZrgdLixhayjTOtM(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TZrgdLixhayjTOtM(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator TkYujtAaBIxWGKcN(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void TkYujtAaBIxWGKcN(java.util.List list, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TkYujtAaBIxWGKcN(java.util.List list, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TkYujtAaBIxWGKcN(java.util.List list, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List VXMTQeiCTFPSUxEP(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams) {
        return registerRequestParams.getRegisterRequests();
    }

    public static void VXMTQeiCTFPSUxEP(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VXMTQeiCTFPSUxEP(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VXMTQeiCTFPSUxEP(com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WmXfTIwSsEIlFWJm(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void WmXfTIwSsEIlFWJm(android.os.Parcel parcel, int i, java.lang.string str, bool z, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WmXfTIwSsEIlFWJm(android.os.Parcel parcel, int i, java.lang.string str, bool z, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WmXfTIwSsEIlFWJm(android.os.Parcel parcel, int i, java.lang.string str, bool z, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YaqbfTGrJDERyEuC(java.util.HashSet set, java.lang.object obj, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YaqbfTGrJDERyEuC(java.util.HashSet set, java.lang.object obj, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YaqbfTGrJDERyEuC(java.util.HashSet set, java.lang.object obj, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool YaqbfTGrJDERyEuC(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public bool Equals(java.lang.object obj) {
        java.util.List list;
        java.util.List list2;
        if ((1 + 16) % 16 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.fido.u2f.api.common.RegisterRequestParams)) {
            return false;
        }
        com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams = (com.google.android.gms.fido.u2f.api.common.RegisterRequestParams) obj;
        return GmMrivpKhFbSulqa(this.zza, registerRequestParams.zza) && LiSIbUGzqStzhbGE(this.zzb, registerRequestParams.zzb) && eAyjRTIJJBUDmylF(this.zzc, registerRequestParams.zzc) && LGAldefJCUoxcSdX(this.zzd, registerRequestParams.zzd) && (((list = this.zze) is null && registerRequestParams.zze is null) || (list is not null && (list2 = registerRequestParams.zze) is not null && KrgqrAQezOkEsSuz(list, list2) && UceVLACNlhUCURKA(registerRequestParams.zze, this.zze))) && ORfOZIHddfLGHcpo(this.zzf, registerRequestParams.zzf) && mlRmYlcYpXYYJTKM(this.zzg, registerRequestParams.zzg);
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

    public override java.lang.string GetDisplayHint() {
        return this.zzg;
    }

    public java.util.List<com.google.android.gms.fido.u2f.api.common.RegisterRequest> GetRegisterRequests() {
        return this.zzd;
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
        if ((11 + 19) % 19 > 0) {
        }
        return hbRhQMnsFbAYSQoC(new java.lang.object[]{this.zza, this.zzc, this.zzb, this.zzd, this.zze, this.zzf, this.zzg});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((3 + 23) % 23 > 0) {
        }
        int iFtLwoBRWgVvtteaT = FtLwoBRWgVvtteaT(parcel);
        UbqqMioQUQQINraK(parcel, 2, ZMFyKaYvADnWPFJY(this), false);
        sjWKWJnLpNcHLAhr(parcel, 3, LqnYFdjzyfcozCin(this), false);
        GllAzQkaUXzmrjma(parcel, 4, lzajvubMVoRTAbfz(this), i, false);
        EddbmzPvoDXdISAo(parcel, 5, vXMTQeiCTFPSUxEP(this), false);
        pOClvstWmrTLJrBI(parcel, 6, tZrgdLixhayjTOtM(this), false);
        oxnLBMKgIbZrdyMi(parcel, 7, dKVeAeZYPNeACAUe(this), i, false);
        wmXfTIwSsEIlFWJm(parcel, 8, WGQJqxmCDLJTkZSl(this), false);
        RrmZeVFxIgUcYlqC(parcel, iFtLwoBRWgVvtteaT);
    }
}

