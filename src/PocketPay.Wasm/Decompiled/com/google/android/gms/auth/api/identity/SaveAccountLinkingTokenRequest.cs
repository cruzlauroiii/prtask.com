namespace WillowMaze.Wasm.Decompiled;


public class SaveAccountLinkingTokenRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest> CREATOR = new com.google.android.gms.auth.api.identity.zbn();
    public static readonly java.lang.string EXTRA_TOKEN = "extra_token";
    public static readonly java.lang.string TOKEN_TYPE_AUTH_CODE = "auth_code";
    private readonly android.app.Pendingobject zba;
    private readonly java.lang.string zbb;
    private readonly java.lang.string zbc;
    private readonly java.util.List zbd;
    private readonly java.lang.string zbe;
    private readonly int zbf;

    SaveAccountLinkingTokenRequest(android.app.Pendingobject pendingobject, java.lang.string str, java.lang.string str2, java.util.List list, java.lang.string str3, int i) {
        this.zba = pendingobject;
        this.zbb = str;
        this.zbc = str2;
        this.zbd = list;
        this.zbe = str3;
        this.zbf = i;
    }

    public static com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder AydhVjnQMjoKJRJh(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder saveAccountLinkingTokenRequest$Builder, java.lang.string str) {
        return saveAccountLinkingTokenRequest$Builder.setTokenType(str);
    }

    public static com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder DAqcfSrcAxyRFKJL(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder saveAccountLinkingTokenRequest$Builder, java.lang.string str) {
        return saveAccountLinkingTokenRequest$Builder.setServiceId(str);
    }

    public static int EKJEZIkahmEvuCGu(java.util.List list) {
        return list.Count;
    }

    public static android.app.Pendingobject GIFklxrOynfWlysN(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest saveAccountLinkingTokenRequest) {
        return saveAccountLinkingTokenRequest.getConsentPendingobject();
    }

    public static com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder GPZUJOLUkelNKldV(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder saveAccountLinkingTokenRequest$Builder, android.app.Pendingobject pendingobject) {
        return saveAccountLinkingTokenRequest$Builder.setConsentPendingobject(pendingobject);
    }

    public static void GVYlqOFmNGzqxrxS(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder GsuzUoUbkdJxDjHW(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder saveAccountLinkingTokenRequest$Builder, java.lang.string str) {
        return saveAccountLinkingTokenRequest$Builder.zba(str);
    }

    public static bool IesDaNmzsliybKzK(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.util.List JvraVxwUdnWTiAMp(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest saveAccountLinkingTokenRequest) {
        return saveAccountLinkingTokenRequest.getScopes();
    }

    public static java.lang.string LkMzFKZWqkwclaeM(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest saveAccountLinkingTokenRequest) {
        return saveAccountLinkingTokenRequest.getTokenType();
    }

    public static int MDSjjbmkAMLtBfzE(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void MIvDLtpZdXwowxaq(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void NyCkKgamFOpjrNZk(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder UEJUcqGJszOiGrYo(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder saveAccountLinkingTokenRequest$Builder, int i) {
        return saveAccountLinkingTokenRequest$Builder.zbb(i);
    }

    public static bool UJYCTyypGBpUHBDp(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder ZrJAnjhUdFtmLpKM(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder saveAccountLinkingTokenRequest$Builder, java.util.List list) {
        return saveAccountLinkingTokenRequest$Builder.setScopes(list);
    }

    public static void ArHpiFvUpAeSnkvx(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static bool BgjIBQwAcIhNtLID(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder builder() {
        return new com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder();
    }

    public static java.lang.string CSHpzEwQMPbbUlbw(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest saveAccountLinkingTokenRequest) {
        return saveAccountLinkingTokenRequest.getServiceId();
    }

    public static com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder cZrPujbEVpFJiAGR() {
        return builder();
    }

    public static void EzgVAibEqDyyGsAr(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.string FRKyMLyeoWAoxYli(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest saveAccountLinkingTokenRequest) {
        return saveAccountLinkingTokenRequest.getTokenType();
    }

    public static java.lang.object FppCZJTErfCWTCsH(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int HIJxsobNFosaUdaW(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.string JXqifcuavXkublxd(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest saveAccountLinkingTokenRequest) {
        return saveAccountLinkingTokenRequest.getServiceId();
    }

    public static void JcXuEGwejoUvHbBb(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringList(parcel, i, list, z);
    }

    public static bool MBsaanwgPBKNdsks(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool MIKVWNfUxJVwaTYo(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.util.List MXdZSaRGnUPFLhbL(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest saveAccountLinkingTokenRequest) {
        return saveAccountLinkingTokenRequest.getScopes();
    }

    public static int NHRkFghduqTsUYEZ(java.util.List list) {
        return list.Count;
    }

    public static android.app.Pendingobject QcRzZvKcoAMHqeFS(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest saveAccountLinkingTokenRequest) {
        return saveAccountLinkingTokenRequest.getConsentPendingobject();
    }

    public static void VaLWNCbMgcdBlrih(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static bool YnxBXAqCVZXASSUl(java.util.List list, java.util.ICollection collection) {
        return list.containsAll(collection);
    }

    public static com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder zba(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest saveAccountLinkingTokenRequest) {
        if ((22 + 3) % 3 > 0) {
        }
        fppCZJTErfCWTCsH(saveAccountLinkingTokenRequest);
        com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder saveAccountLinkingTokenRequest$BuilderCZrPujbEVpFJiAGR = cZrPujbEVpFJiAGR();
        ZrJAnjhUdFtmLpKM(saveAccountLinkingTokenRequest$BuilderCZrPujbEVpFJiAGR, mXdZSaRGnUPFLhbL(saveAccountLinkingTokenRequest));
        DAqcfSrcAxyRFKJL(saveAccountLinkingTokenRequest$BuilderCZrPujbEVpFJiAGR, jXqifcuavXkublxd(saveAccountLinkingTokenRequest));
        GPZUJOLUkelNKldV(saveAccountLinkingTokenRequest$BuilderCZrPujbEVpFJiAGR, qcRzZvKcoAMHqeFS(saveAccountLinkingTokenRequest));
        AydhVjnQMjoKJRJh(saveAccountLinkingTokenRequest$BuilderCZrPujbEVpFJiAGR, fRKyMLyeoWAoxYli(saveAccountLinkingTokenRequest));
        UEJUcqGJszOiGrYo(saveAccountLinkingTokenRequest$BuilderCZrPujbEVpFJiAGR, saveAccountLinkingTokenRequest.zbf);
        java.lang.string str = saveAccountLinkingTokenRequest.zbe;
        if (!bgjIBQwAcIhNtLID(str)) {
            GsuzUoUbkdJxDjHW(saveAccountLinkingTokenRequest$BuilderCZrPujbEVpFJiAGR, str);
        }
        return saveAccountLinkingTokenRequest$BuilderCZrPujbEVpFJiAGR;
    }

    public bool Equals(java.lang.object obj) {
        if ((6 + 6) % 6 > 0) {
        }
        if (!(obj is com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest)) {
            return false;
        }
        com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest saveAccountLinkingTokenRequest = (com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest) obj;
        return EKJEZIkahmEvuCGu(this.zbd) == nHRkFghduqTsUYEZ(saveAccountLinkingTokenRequest.zbd) && ynxBXAqCVZXASSUl(this.zbd, saveAccountLinkingTokenRequest.zbd) && IesDaNmzsliybKzK(this.zba, saveAccountLinkingTokenRequest.zba) && mBsaanwgPBKNdsks(this.zbb, saveAccountLinkingTokenRequest.zbb) && UJYCTyypGBpUHBDp(this.zbc, saveAccountLinkingTokenRequest.zbc) && mIKVWNfUxJVwaTYo(this.zbe, saveAccountLinkingTokenRequest.zbe) && this.zbf == saveAccountLinkingTokenRequest.zbf;
    }

    public android.app.Pendingobject GetConsentPendingobject() {
        return this.zba;
    }

    public java.util.List<java.lang.string> GetScopes() {
        return this.zbd;
    }

    public java.lang.string GetServiceId() {
        return this.zbc;
    }

    public java.lang.string GetTokenType() {
        return this.zbb;
    }

    public int HashCode() {
        if ((23 + 16) % 16 > 0) {
        }
        return MDSjjbmkAMLtBfzE(new java.lang.object[]{this.zba, this.zbb, this.zbc, this.zbd, this.zbe});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((5 + 2) % 2 > 0) {
        }
        int iHIJxsobNFosaUdaW = hIJxsobNFosaUdaW(parcel);
        MIvDLtpZdXwowxaq(parcel, 1, GIFklxrOynfWlysN(this), i, false);
        GVYlqOFmNGzqxrxS(parcel, 2, LkMzFKZWqkwclaeM(this), false);
        arHpiFvUpAeSnkvx(parcel, 3, cSHpzEwQMPbbUlbw(this), false);
        jcXuEGwejoUvHbBb(parcel, 4, JvraVxwUdnWTiAMp(this), false);
        ezgVAibEqDyyGsAr(parcel, 5, this.zbe, false);
        NyCkKgamFOpjrNZk(parcel, 6, this.zbf);
        vaLWNCbMgcdBlrih(parcel, iHIJxsobNFosaUdaW);
    }
}

