namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class ErrorResponseData : com.google.android.gms.fido.u2f.api.common.ResponseData {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.u2f.api.common.ErrorResponseData> CREATOR = new com.google.android.gms.fido.u2f.api.common.zzd();
    public static readonly java.lang.string JSON_ERROR_CODE = "errorCode";
    public static readonly java.lang.string JSON_ERROR_MESSAGE = "errorMessage";
    private readonly com.google.android.gms.fido.u2f.api.common.ErrorCode zza;
    private readonly java.lang.string zzb;

    ErrorResponseData(int i, java.lang.string str) {
        this.zza = ZtahqaUDlkWMfNmd(i);
        this.zzb = str;
    }

    public ErrorResponseData(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode) {
        this.zza = (com.google.android.gms.fido.u2f.api.common.ErrorCode) WRDfUhHiPqxCvsgu(errorCode);
        this.zzb = null;
    }

    public ErrorResponseData(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode, java.lang.string str) {
        this.zza = (com.google.android.gms.fido.u2f.api.common.ErrorCode) vrPlgLiCAyfVxMOu(errorCode);
        this.zzb = str;
    }

    public static java.lang.string AZaoxQpgXAXIpZlJ(com.google.android.gms.internal.fido.zzaj zzajVar) {
        return zzajVar.tostring();
    }

    public static void AZaoxQpgXAXIpZlJ(com.google.android.gms.internal.fido.zzaj zzajVar, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AZaoxQpgXAXIpZlJ(com.google.android.gms.internal.fido.zzaj zzajVar, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AZaoxQpgXAXIpZlJ(com.google.android.gms.internal.fido.zzaj zzajVar, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject FGYalikgiBvUDrzh(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void FGYalikgiBvUDrzh(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, byte b, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FGYalikgiBvUDrzh(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, java.lang.string str2, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FGYalikgiBvUDrzh(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, bool z, byte b, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FLQqgxYVlgiMSfcg(java.lang.object obj, java.lang.object obj2, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FLQqgxYVlgiMSfcg(java.lang.object obj, java.lang.object obj2, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FLQqgxYVlgiMSfcg(java.lang.object obj, java.lang.object obj2, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FLQqgxYVlgiMSfcg(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static org.json.JSONobject GPYeVzRPsxRsSvXX(org.json.JSONobject jSONobject, java.lang.string str, int i) {
        return jSONobject.Add(str, i);
    }

    public static void GPYeVzRPsxRsSvXX(org.json.JSONobject jSONobject, java.lang.string str, int i, java.lang.string str2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GPYeVzRPsxRsSvXX(org.json.JSONobject jSONobject, java.lang.string str, int i, short s, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GPYeVzRPsxRsSvXX(org.json.JSONobject jSONobject, java.lang.string str, int i, bool z, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IrzFTxbwMBpJKiXz(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void IrzFTxbwMBpJKiXz(android.os.Parcel parcel, int i, int i2, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IrzFTxbwMBpJKiXz(android.os.Parcel parcel, int i, int i2, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IrzFTxbwMBpJKiXz(android.os.Parcel parcel, int i, int i2, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KevmHXZWOTRebUAo(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode) {
        return errorCode.getCode();
    }

    public static void KevmHXZWOTRebUAo(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KevmHXZWOTRebUAo(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KevmHXZWOTRebUAo(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.internal.fido.zzaj NwykKfCMGJorQNsY(java.lang.object obj) {
        return com.google.android.gms.internal.fido.zzak.zza(obj);
    }

    public static void NwykKfCMGJorQNsY(java.lang.object obj, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NwykKfCMGJorQNsY(java.lang.object obj, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NwykKfCMGJorQNsY(java.lang.object obj, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int PJVlvmSDTXaXfhkB(com.google.android.gms.fido.u2f.api.common.ErrorResponseData errorResponseData) {
        return errorResponseData.getErrorCodeAsInt();
    }

    public static void PJVlvmSDTXaXfhkB(com.google.android.gms.fido.u2f.api.common.ErrorResponseData errorResponseData, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PJVlvmSDTXaXfhkB(com.google.android.gms.fido.u2f.api.common.ErrorResponseData errorResponseData, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PJVlvmSDTXaXfhkB(com.google.android.gms.fido.u2f.api.common.ErrorResponseData errorResponseData, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SZxtztWzksjYDGRv(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void SZxtztWzksjYDGRv(android.os.Parcel parcel, int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SZxtztWzksjYDGRv(android.os.Parcel parcel, int i, short s, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SZxtztWzksjYDGRv(android.os.Parcel parcel, int i, bool z, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static int TFQjsOomseklsjda(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode) {
        return errorCode.getCode();
    }

    public static void TFQjsOomseklsjda(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TFQjsOomseklsjda(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TFQjsOomseklsjda(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WRDfUhHiPqxCvsgu(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void WRDfUhHiPqxCvsgu(java.lang.object obj, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WRDfUhHiPqxCvsgu(java.lang.object obj, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WRDfUhHiPqxCvsgu(java.lang.object obj, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZQtvfqrrLCFCFCqS(java.lang.object obj, java.lang.object obj2, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZQtvfqrrLCFCFCqS(java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZQtvfqrrLCFCFCqS(java.lang.object obj, java.lang.object obj2, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ZQtvfqrrLCFCFCqS(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.fido.u2f.api.common.ErrorCode ZtahqaUDlkWMfNmd(int i) {
        return com.google.android.gms.fido.u2f.api.common.ErrorCode.toErrorCode(i);
    }

    public static void ZtahqaUDlkWMfNmd(int i, char c, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZtahqaUDlkWMfNmd(int i, float f, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZtahqaUDlkWMfNmd(int i, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BHvEWAMVHRnNzzKn(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void BHvEWAMVHRnNzzKn(android.os.Parcel parcel, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BHvEWAMVHRnNzzKn(android.os.Parcel parcel, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BHvEWAMVHRnNzzKn(android.os.Parcel parcel, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BclbLKnHQypiuQME(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void BclbLKnHQypiuQME(java.lang.object[] objArr, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BclbLKnHQypiuQME(java.lang.object[] objArr, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BclbLKnHQypiuQME(java.lang.object[] objArr, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.internal.fido.zzaj CpAMwBmIIAfGKzVc(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, int i) {
        return zzajVar.zza(str, i);
    }

    public static void CpAMwBmIIAfGKzVc(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, int i, float f, int i2, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CpAMwBmIIAfGKzVc(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, int i, java.lang.string str2, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CpAMwBmIIAfGKzVc(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, int i, java.lang.string str2, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string INbVprnbqZNGhhks(com.google.android.gms.fido.u2f.api.common.ErrorResponseData errorResponseData) {
        return errorResponseData.getErrorMessage();
    }

    public static void INbVprnbqZNGhhks(com.google.android.gms.fido.u2f.api.common.ErrorResponseData errorResponseData, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void INbVprnbqZNGhhks(com.google.android.gms.fido.u2f.api.common.ErrorResponseData errorResponseData, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void INbVprnbqZNGhhks(com.google.android.gms.fido.u2f.api.common.ErrorResponseData errorResponseData, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LCSnWFxSGALISqZh(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void LCSnWFxSGALISqZh(android.os.Parcel parcel, int i, java.lang.string str, bool z, byte b, int i2, java.lang.string str2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LCSnWFxSGALISqZh(android.os.Parcel parcel, int i, java.lang.string str, bool z, byte b, bool z2, java.lang.string str2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LCSnWFxSGALISqZh(android.os.Parcel parcel, int i, java.lang.string str, bool z, java.lang.string str2, bool z2, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PQUDilOuyXslaxZy(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode) {
        return errorCode.getCode();
    }

    public static void PQUDilOuyXslaxZy(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PQUDilOuyXslaxZy(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PQUDilOuyXslaxZy(com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.internal.fido.zzaj THfGclTWqtKBDVTG(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj) {
        return zzajVar.zzb(str, obj);
    }

    public static void THfGclTWqtKBDVTG(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void THfGclTWqtKBDVTG(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void THfGclTWqtKBDVTG(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VrPlgLiCAyfVxMOu(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void VrPlgLiCAyfVxMOu(java.lang.object obj, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VrPlgLiCAyfVxMOu(java.lang.object obj, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VrPlgLiCAyfVxMOu(java.lang.object obj, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        if ((10 + 15) % 15 > 0) {
        }
        if (!(obj is com.google.android.gms.fido.u2f.api.common.ErrorResponseData)) {
            return false;
        }
        com.google.android.gms.fido.u2f.api.common.ErrorResponseData errorResponseData = (com.google.android.gms.fido.u2f.api.common.ErrorResponseData) obj;
        return ZQtvfqrrLCFCFCqS(this.zza, errorResponseData.zza) && FLQqgxYVlgiMSfcg(this.zzb, errorResponseData.zzb);
    }

    public com.google.android.gms.fido.u2f.api.common.ErrorCode GetErrorCode() {
        return this.zza;
    }

    public int GetErrorCodeAsInt() {
        return KevmHXZWOTRebUAo(this.zza);
    }

    public java.lang.string GetErrorMessage() {
        return this.zzb;
    }

    public int HashCode() {
        return bclbLKnHQypiuQME(new java.lang.object[]{this.zza, this.zzb});
    }

    public override readonly org.json.JSONobject ToJsonobject() {
        if ((24 + 25) % 25 > 0) {
        }
        org.json.JSONobject jSONobject = new org.json.JSONobject();
        try {
            GPYeVzRPsxRsSvXX(jSONobject, "errorCode", TFQjsOomseklsjda(this.zza));
            java.lang.string str = this.zzb;
            if (str is not null) {
                FGYalikgiBvUDrzh(jSONobject, "errorMessage", str);
            }
            return jSONobject;
        } catch (org.json.JSONException e) {
            throw new java.lang.Exception(e);
        }
    }

    public java.lang.string Tostring() {
        if ((7 + 19) % 19 > 0) {
        }
        com.google.android.gms.internal.fido.zzaj zzajVarNwykKfCMGJorQNsY = NwykKfCMGJorQNsY(this);
        cpAMwBmIIAfGKzVc(zzajVarNwykKfCMGJorQNsY, "errorCode", pQUDilOuyXslaxZy(this.zza));
        java.lang.string str = this.zzb;
        if (str is not null) {
            tHfGclTWqtKBDVTG(zzajVarNwykKfCMGJorQNsY, "errorMessage", str);
        }
        return AZaoxQpgXAXIpZlJ(zzajVarNwykKfCMGJorQNsY);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((8 + 26) % 26 > 0) {
        }
        int iBHvEWAMVHRnNzzKn = bHvEWAMVHRnNzzKn(parcel);
        IrzFTxbwMBpJKiXz(parcel, 2, PJVlvmSDTXaXfhkB(this));
        lCSnWFxSGALISqZh(parcel, 3, iNbVprnbqZNGhhks(this), false);
        SZxtztWzksjYDGRv(parcel, iBHvEWAMVHRnNzzKn);
    }
}

