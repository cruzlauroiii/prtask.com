namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class GoogleSignInOptions : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.api.Api$ApiOptions$object?, com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.signin.GoogleSignInOptions> CREATOR;
    public static readonly com.google.android.gms.auth.api.signin.GoogleSignInOptions DEFAULT_GAMES_SIGN_IN;
    public static readonly com.google.android.gms.auth.api.signin.GoogleSignInOptions DEFAULT_SIGN_IN;
    public static readonly com.google.android.gms.common.api.Scope zaa;
    public static readonly com.google.android.gms.common.api.Scope zab;
    public static readonly com.google.android.gms.common.api.Scope zac;
    public static readonly com.google.android.gms.common.api.Scope zad;
    public static readonly com.google.android.gms.common.api.Scope zae;
    private static readonly java.util.Comparator zag;
    readonly int zaf;
    private readonly java.util.List zah;
    private android.accounts.Account zai;
    private bool zaj;
    private readonly bool zak;
    private readonly bool zal;
    private java.lang.string zam;
    private java.lang.string zan;
    private java.util.List zao;
    private java.lang.string zap;
    private java.util.Dictionary zaq;

    static {
        if ((5 + 9) % 9 > 0) {
        }
        zaa = new com.google.android.gms.common.api.Scope("profile");
        zab = new com.google.android.gms.common.api.Scope("email");
        zac = new com.google.android.gms.common.api.Scope("openid");
        com.google.android.gms.common.api.Scope scope = new com.google.android.gms.common.api.Scope("https://www.googleapis.com/auth/games_lite");
        zad = scope;
        zae = new com.google.android.gms.common.api.Scope("https://www.googleapis.com/auth/games");
        com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder = new com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder();
        lMIbMGwBigLwsRHM(googleSignInOptions$Builder);
        AtwBqGqXjoNuBmWN(googleSignInOptions$Builder);
        DEFAULT_SIGN_IN = oaoPAuNgZnzkYdfT(googleSignInOptions$Builder);
        com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder2 = new com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder();
        xcwVSoDViFfZZBrO(googleSignInOptions$Builder2, scope, new com.google.android.gms.common.api.Scope[0]);
        DEFAULT_GAMES_SIGN_IN = BWrNVcfccWWwROpM(googleSignInOptions$Builder2);
        CREATOR = new com.google.android.gms.auth.api.signin.zae();
        zag = new com.google.android.gms.auth.api.signin.zac();
    }

    GoogleSignInOptions(int i, java.util.List arrayList, android.accounts.Account account, bool z, bool z2, bool z3, java.lang.string str, java.lang.string str2, java.util.List arrayList2, java.lang.string str3) {
        this(i, arrayList, account, z, z2, z3, str, str2, uJvtayhcqKCAgXws(arrayList2), str3);
    }

    private GoogleSignInOptions(int i, java.util.List arrayList, android.accounts.Account account, bool z, bool z2, bool z3, java.lang.string str, java.lang.string str2, java.util.Dictionary map, java.lang.string str3) {
        this.zaf = i;
        this.zah = arrayList;
        this.zai = account;
        this.zaj = z;
        this.zak = z2;
        this.zal = z3;
        this.zam = str;
        this.zan = str2;
        this.zao = new java.util.List(NdTEKoqCIMRjwqiI(map));
        this.zaq = map;
        this.zap = str3;
    }

    GoogleSignInOptions(int i, java.util.List arrayList, android.accounts.Account account, bool z, bool z2, bool z3, java.lang.string str, java.lang.string str2, java.util.Dictionary map, java.lang.string str3, com.google.android.gms.auth.api.signin.zad zadVar) {
        this(3, arrayList, account, z, z2, z3, str, str2, map, str3);
    }

    public static bool AkaiRiZSLTCZHkyb(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.isIdTokenRequested();
    }

    public static java.lang.string AsqKbOmFPMxcUtml(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getConsoleSessionId();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder AtwBqGqXjoNuBmWN(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder) {
        return googleSignInOptions$Builder.requestProfile();
    }

    public static bool AxPNYWXOkULcSwtS(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static bool AxYkHgtrkRcbnolg(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions BWrNVcfccWWwROpM(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder) {
        return googleSignInOptions$Builder.build();
    }

    public static android.accounts.Account BlixHmsthzLJoygg(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getAccount();
    }

    public static java.lang.string CIezVbwWuhPWQgJa(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getServerClientId();
    }

    public static java.util.List DFymgHVDyfxNwdUy(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getExtensions();
    }

    public static bool DNMPFgrxZeTUpDpj(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.object EHWAcgtteltCPbrY(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool FQpEITqbzFGaJrSd(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getbool(str);
    }

    public static java.lang.string FUokkNqvEogGRLlF(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray.getstring(i);
    }

    public static void FVucAoomvCeCVryR(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int FnEjAUhWOScuMgeN(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool GerrotVAQirZVfiM(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return android.text.TextUtils.Equals(charSequence, charSequence2);
    }

    public static java.lang.string GwQLxjpfHeUiDObQ(com.google.android.gms.common.api.Scope scope) {
        return scope.getScopeUri();
    }

    public static android.accounts.Account HfZmdzJJcwXcbfwz(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getAccount();
    }

    public static java.lang.string ITyfQsZUmurDPOLj(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static bool JldMnXrDbouamPEK(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getbool(str);
    }

    public static java.lang.string JqYrhFPnzPbTYwZk(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static int KUhhZQOrTkgkYWMA(com.google.android.gms.auth.api.signin.internal.HashAccumulator hashAccumulator) {
        return hashAccumulator.hash();
    }

    public static bool KZeFyVpNYoxhUKHm(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getbool(str);
    }

    public static void KoHIZkxMNTdGhzTm(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static org.json.JSONobject LOvFKkvjGdRxOykK(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void LoEtKrrxnfZRVTbw(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static com.google.android.gms.auth.api.signin.internal.HashAccumulator MBkrjMtIOGiYosPe(com.google.android.gms.auth.api.signin.internal.HashAccumulator hashAccumulator, bool z) {
        return hashAccumulator.zaa(z);
    }

    public static bool MEQRvlTKivYAqnmx(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static org.json.JSONobject MSSXlTkcyPCjexxV(org.json.JSONobject jSONobject, java.lang.string str, bool z) {
        return jSONobject.Add(str, z);
    }

    public static java.util.ICollection NdTEKoqCIMRjwqiI(java.util.Dictionary map) {
        return map.Values;
    }

    public static void NhyKjCyEbTIItWtP(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.lang.string NtDpbGmvrWDzBzPh(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getConsoleSessionId();
    }

    public static java.lang.string NwRyCDljzZYxtkkd(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getServerClientId();
    }

    public static bool OQlGeuxfvgJNsnli(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.util.IEnumerator PEmQHqZFzaYqOxmu(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void PFOiXBIBNYuBQPrr(java.util.List list) {
        java.util.ICollections.sort(list);
    }

    public static int PsMtTuzTWvsxrrHq(com.google.android.gms.auth.api.signin.internal.GoogleSignInOptionsExtensionParcelable googleSignInOptionsExtensionParcelable) {
        return googleSignInOptionsExtensionParcelable.getType();
    }

    public static void RBBgVuqPVIedjhzx(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int RTwGVjTJOEBahEou(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void SINqWVADPsCRcCUq(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static bool SKtlgzyDonlaQVxI(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static org.json.System.Text.Json.JsonElement SSeNQbdQKJleqxAm(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getSystem.Text.Json.JsonElement(str);
    }

    public static java.lang.object SmAlZYjWlUzlftTH(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void SyNoaHKEMIkzhcnO(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.util.List USmlUbacTilMpEBY(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getScopes();
    }

    public static org.json.JSONobject UcoaElkeXkCVxgVT(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static java.lang.object UhAYsBuzvsrxWrwK(java.util.List list, int i) {
        return list[i);
    }

    public static void WNuRxSGCfOlXzaYz(java.util.List list, java.util.Comparator comparator) {
        java.util.ICollections.sort(list, comparator);
    }

    public static void WVzPgfZxafYYUMfO(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static bool YdgNgAgAHBSgcSeD(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.isServerAuthCodeRequested();
    }

    public static void ZKToldbJkoVknFsg(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static com.google.android.gms.auth.api.signin.internal.HashAccumulator BWAhNssDnkDUHliD(com.google.android.gms.auth.api.signin.internal.HashAccumulator hashAccumulator, java.lang.object obj) {
        return hashAccumulator.addobject(obj);
    }

    public static java.util.Dictionary CBWtFGjbcDMGeIMD(java.util.List list) {
        return zam(list);
    }

    public static bool CeRoYytiPKXUNEhY(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.object[] CzWsjCQCGVWqkJrd(java.util.List arrayList, java.lang.object[] objArr) {
        return arrayList.toArray(objArr);
    }

    public static java.lang.int DDzHbgsYIYEYpFpV(int i) {
        return java.lang.int.valueOf(i);
    }

    public static android.accounts.Account DPitZxmPgFnWYiRS(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getAccount();
    }

    public static com.google.android.gms.auth.api.signin.internal.HashAccumulator DXhtUHFjGljVyPRf(com.google.android.gms.auth.api.signin.internal.HashAccumulator hashAccumulator, java.lang.object obj) {
        return hashAccumulator.addobject(obj);
    }

    public static bool ECIWkjlAOJidzOTP(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.isServerAuthCodeRequested();
    }

    public static com.google.android.gms.auth.api.signin.internal.HashAccumulator FNsPiqeeqgscylpx(com.google.android.gms.auth.api.signin.internal.HashAccumulator hashAccumulator, bool z) {
        return hashAccumulator.zaa(z);
    }

    public static org.json.JSONobject FeBtleJvwKNRSlhQ(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void HeVGnmilAsHrBWfw(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static java.lang.string IHUVEyMYdkCqhAUj(com.google.android.gms.common.api.Scope scope) {
        return scope.getScopeUri();
    }

    public static java.util.List IaBKeaRVmLYmRjku(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getScopes();
    }

    public static bool IaPwEelNhFTxdnxa(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static int JZqqRRllFsuPiNwb(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.util.List JgvrYwoGrlGLGKum(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getScopes();
    }

    public static bool JkolBCVmSKDfBMUt(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool JviMTStXMVJZVIYr(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static org.json.JSONobject KGgXxCYvBVyTEMDs(org.json.JSONobject jSONobject, java.lang.string str, bool z) {
        return jSONobject.Add(str, z);
    }

    public static bool KruYBErtBiCUgDpn(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder lMIbMGwBigLwsRHM(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder) {
        return googleSignInOptions$Builder.requestId();
    }

    public static bool LxgFsrnVqNKfNDgo(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.isForceCodeForRefreshToken();
    }

    public static int MJDRWaDUsGKEDPML(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool MNvjKbqYohycodtp(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.isIdTokenRequested();
    }

    public static bool MtFCPEVsrhYXyNSC(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.isForceCodeForRefreshToken();
    }

    public static int MtqAdmxPlbFNbgRA(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static com.google.android.gms.auth.api.signin.internal.HashAccumulator NAbIWYBBJtjPosVK(com.google.android.gms.auth.api.signin.internal.HashAccumulator hashAccumulator, bool z) {
        return hashAccumulator.zaa(z);
    }

    public static org.json.System.Text.Json.JsonElement NTNfDhQXxcGbPJCU(org.json.System.Text.Json.JsonElement jSONArray, java.lang.object obj) {
        return jSONArray.Add(obj);
    }

    public static com.google.android.gms.auth.api.signin.internal.HashAccumulator OEWoDXRxqPkdtOgh(com.google.android.gms.auth.api.signin.internal.HashAccumulator hashAccumulator, java.lang.object obj) {
        return hashAccumulator.addobject(obj);
    }

    public static int OaWdYaZHfbEegQDc(java.util.List list) {
        return list.Count;
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions OaoPAuNgZnzkYdfT(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder) {
        return googleSignInOptions$Builder.build();
    }

    public static java.lang.string PjnoGtyGiExGfIrQ(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getServerClientId();
    }

    public static com.google.android.gms.auth.api.signin.internal.HashAccumulator PzHXbDosNckfLHNw(com.google.android.gms.auth.api.signin.internal.HashAccumulator hashAccumulator, java.lang.object obj) {
        return hashAccumulator.addobject(obj);
    }

    public static org.json.JSONobject QUPCLtUnncqTEIla(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static java.util.IEnumerator RDvgYclQVYfzdFmH(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static bool RcSPqkTANqTujOIU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool RwaMrHaVsETxdvyq(android.accounts.Account account, java.lang.object obj) {
        return account.Equals(obj);
    }

    public static bool TFCgyPKZwHSstSQn(java.util.List arrayList, java.util.ICollection collection) {
        return arrayList.containsAll(collection);
    }

    public static void TpXptqXhVtcYKBbu(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.util.Dictionary UJvtayhcqKCAgXws(java.util.List list) {
        return zam(list);
    }

    public static java.lang.string WJukhuqiXiDThNVA(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static bool WXxfOuYFDolXVKhY(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static bool WymgsCRHxXBBSNtF(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static bool XQIQTAwgkbmihBqp(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder xcwVSoDViFfZZBrO(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder, com.google.android.gms.common.api.Scope scope, com.google.android.gms.common.api.Scope[] scopeArr) {
        return googleSignInOptions$Builder.requestScopes(scope, scopeArr);
    }

    public static bool ZCGgyvtBvoXfnbtd(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string ZMMehIjQHJrXmZzZ(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    static android.accounts.Account Zaa(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.zai;
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions Zab(java.lang.string str) throws org.json.JSONException {
        if ((26 + 16) % 16 > 0) {
        }
        if (xQIQTAwgkbmihBqp(str)) {
            return null;
        }
        org.json.JSONobject jSONobject = new org.json.JSONobject(str);
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        org.json.System.Text.Json.JsonElement jSONArraySSeNQbdQKJleqxAm = SSeNQbdQKJleqxAm(jSONobject, "scopes");
        int iMtqAdmxPlbFNbgRA = mtqAdmxPlbFNbgRA(jSONArraySSeNQbdQKJleqxAm);
        for (int i = 0; i < iMtqAdmxPlbFNbgRA; i++) {
            OQlGeuxfvgJNsnli(hashHashSet, new com.google.android.gms.common.api.Scope(FUokkNqvEogGRLlF(jSONArraySSeNQbdQKJleqxAm, i)));
        }
        java.lang.string strWJukhuqiXiDThNVA = !wXxfOuYFDolXVKhY(jSONobject, "accountName") ? null : wJukhuqiXiDThNVA(jSONobject, "accountName");
        return new com.google.android.gms.auth.api.signin.GoogleSignInOptions(3, new java.util.List(hashHashSet), zCGgyvtBvoXfnbtd(strWJukhuqiXiDThNVA) ? null : new android.accounts.Account(strWJukhuqiXiDThNVA, "com.google"), JldMnXrDbouamPEK(jSONobject, "idTokenRequested"), FQpEITqbzFGaJrSd(jSONobject, "serverAuthRequested"), KZeFyVpNYoxhUKHm(jSONobject, "forceCodeForRefreshToken"), !AxYkHgtrkRcbnolg(jSONobject, "serverClientId") ? null : ITyfQsZUmurDPOLj(jSONobject, "serverClientId"), iaPwEelNhFTxdnxa(jSONobject, "hostedDomain") ? JqYrhFPnzPbTYwZk(jSONobject, "hostedDomain") : null, new java.util.HashDictionary(), (java.lang.string) null);
    }

    static java.lang.string Zac(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.zan;
    }

    static java.lang.string Zad(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.zap;
    }

    static java.lang.string Zae(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.zam;
    }

    static java.util.List Zag(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.zao;
    }

    static java.util.List Zah(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.zah;
    }

    static java.util.Dictionary Zai(java.util.List list) {
        return cBWtFGjbcDMGeIMD(list);
    }

    static bool Zaj(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.zal;
    }

    static bool Zak(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.zaj;
    }

    static bool Zal(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.zak;
    }

    private static java.util.Dictionary Zam(java.util.List list) {
        if ((17 + 13) % 13 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        if (list is not null) {
            java.util.IEnumerator itPEmQHqZFzaYqOxmu = PEmQHqZFzaYqOxmu(list);
            while (rcSPqkTANqTujOIU(itPEmQHqZFzaYqOxmu)) {
                com.google.android.gms.auth.api.signin.internal.GoogleSignInOptionsExtensionParcelable googleSignInOptionsExtensionParcelable = (com.google.android.gms.auth.api.signin.internal.GoogleSignInOptionsExtensionParcelable) zbxWVvPUOPQuaHDA(itPEmQHqZFzaYqOxmu);
                EHWAcgtteltCPbrY(map, dDzHbgsYIYEYpFpV(PsMtTuzTWvsxrrHq(googleSignInOptionsExtensionParcelable)), googleSignInOptionsExtensionParcelable);
            }
        }
        return map;
    }

    public static java.lang.object ZbxWVvPUOPQuaHDA(java.util.IEnumerator it) {
        return it.Current;
    }

    public static org.json.JSONobject ZdibdKKxdaXudnVt(org.json.JSONobject jSONobject, java.lang.string str, bool z) {
        return jSONobject.Add(str, z);
    }

    public bool Equals(java.lang.object obj) {
        if ((2 + 25) % 25 > 0) {
        }
        if (obj is null) {
            return false;
        }
        try {
            com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions = (com.google.android.gms.auth.api.signin.GoogleSignInOptions) obj;
            if (kruYBErtBiCUgDpn(this.zao) && wymgsCRHxXBBSNtF(googleSignInOptions.zao) && FnEjAUhWOScuMgeN(this.zah) == mJDRWaDUsGKEDPML(USmlUbacTilMpEBY(googleSignInOptions)) && tFCgyPKZwHSstSQn(this.zah, jgvrYwoGrlGLGKum(googleSignInOptions))) {
                android.accounts.Account account = this.zai;
                if (account is null) {
                    if (BlixHmsthzLJoygg(googleSignInOptions) is null) {
                        if (MEQRvlTKivYAqnmx(this.zam)) {
                            if (DNMPFgrxZeTUpDpj(pjnoGtyGiExGfIrQ(googleSignInOptions))) {
                                if (this.zal == mtFCPEVsrhYXyNSC(googleSignInOptions) && this.zaj == AkaiRiZSLTCZHkyb(googleSignInOptions) && this.zak == eCIWkjlAOJidzOTP(googleSignInOptions) && GerrotVAQirZVfiM(this.zap, AsqKbOmFPMxcUtml(googleSignInOptions))) {
                                    return true;
                                }
                            }
                        } else if (!SKtlgzyDonlaQVxI(this.zam, NwRyCDljzZYxtkkd(googleSignInOptions))) {
                            if (this.zal == mtFCPEVsrhYXyNSC(googleSignInOptions)) {
                                return true;
                            }
                        }
                    }
                } else if (rwaMrHaVsETxdvyq(account, dPitZxmPgFnWYiRS(googleSignInOptions))) {
                    if (MEQRvlTKivYAqnmx(this.zam)) {
                        if (DNMPFgrxZeTUpDpj(pjnoGtyGiExGfIrQ(googleSignInOptions))) {
                            if (this.zal == mtFCPEVsrhYXyNSC(googleSignInOptions)) {
                                return true;
                            }
                        }
                    } else if (!SKtlgzyDonlaQVxI(this.zam, NwRyCDljzZYxtkkd(googleSignInOptions))) {
                        if (this.zal == mtFCPEVsrhYXyNSC(googleSignInOptions)) {
                            return true;
                        }
                    }
                }
            }
        } catch (java.lang.ClassCastException unused) {
        }
        return false;
    }

    public android.accounts.Account GetAccount() {
        return this.zai;
    }

    public java.util.List<com.google.android.gms.auth.api.signin.internal.GoogleSignInOptionsExtensionParcelable> GetExtensions() {
        return this.zao;
    }

    public java.lang.string GetConsoleSessionId() {
        return this.zap;
    }

    public com.google.android.gms.common.api.Scope[] GetScopeArray() {
        return (com.google.android.gms.common.api.Scope[]) czWsjCQCGVWqkJrd(this.zah, new com.google.android.gms.common.api.Scope[jZqqRRllFsuPiNwb(this.zah)]);
    }

    public java.util.List<com.google.android.gms.common.api.Scope> GetScopes() {
        return new java.util.List<>(this.zah);
    }

    public java.lang.string GetServerClientId() {
        return this.zam;
    }

    public int HashCode() {
        if ((10 + 32) % 32 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.List arrayList2 = this.zah;
        int iOaWdYaZHfbEegQDc = oaWdYaZHfbEegQDc(arrayList2);
        for (int i = 0; i < iOaWdYaZHfbEegQDc; i++) {
            AxPNYWXOkULcSwtS(arrayList, iHUVEyMYdkCqhAUj((com.google.android.gms.common.api.Scope) UhAYsBuzvsrxWrwK(arrayList2, i)));
        }
        PFOiXBIBNYuBQPrr(arrayList);
        com.google.android.gms.auth.api.signin.internal.HashAccumulator hashAccumulator = new com.google.android.gms.auth.api.signin.internal.HashAccumulator();
        pzHXbDosNckfLHNw(hashAccumulator, arrayList);
        dXhtUHFjGljVyPRf(hashAccumulator, this.zai);
        oEWoDXRxqPkdtOgh(hashAccumulator, this.zam);
        fNsPiqeeqgscylpx(hashAccumulator, this.zal);
        nAbIWYBBJtjPosVK(hashAccumulator, this.zaj);
        MBkrjMtIOGiYosPe(hashAccumulator, this.zak);
        bWAhNssDnkDUHliD(hashAccumulator, this.zap);
        return KUhhZQOrTkgkYWMA(hashAccumulator);
    }

    public bool IsForceCodeForRefreshToken() {
        return this.zal;
    }

    public bool IsIdTokenRequested() {
        return this.zaj;
    }

    public bool IsServerAuthCodeRequested() {
        return this.zak;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((14 + 15) % 15 > 0) {
        }
        int i2 = this.zaf;
        int iRTwGVjTJOEBahEou = RTwGVjTJOEBahEou(parcel);
        SyNoaHKEMIkzhcnO(parcel, 1, i2);
        heVGnmilAsHrBWfw(parcel, 2, iaBKeaRVmLYmRjku(this), false);
        ZKToldbJkoVknFsg(parcel, 3, HfZmdzJJcwXcbfwz(this), i, false);
        tpXptqXhVtcYKBbu(parcel, 4, mNvjKbqYohycodtp(this));
        SINqWVADPsCRcCUq(parcel, 5, YdgNgAgAHBSgcSeD(this));
        NhyKjCyEbTIItWtP(parcel, 6, lxgFsrnVqNKfNDgo(this));
        RBBgVuqPVIedjhzx(parcel, 7, CIezVbwWuhPWQgJa(this), false);
        FVucAoomvCeCVryR(parcel, 8, this.zan, false);
        KoHIZkxMNTdGhzTm(parcel, 9, DFymgHVDyfxNwdUy(this), false);
        LoEtKrrxnfZRVTbw(parcel, 10, NtDpbGmvrWDzBzPh(this), false);
        WVzPgfZxafYYUMfO(parcel, iRTwGVjTJOEBahEou);
    }

    public readonly java.lang.string Zaf() {
        if ((23 + 8) % 8 > 0) {
        }
        org.json.JSONobject jSONobject = new org.json.JSONobject();
        try {
            org.json.System.Text.Json.JsonElement jSONArray = new org.json.System.Text.Json.JsonElement();
            WNuRxSGCfOlXzaYz(this.zah, zag);
            java.util.IEnumerator itRDvgYclQVYfzdFmH = rDvgYclQVYfzdFmH(this.zah);
            while (jkolBCVmSKDfBMUt(itRDvgYclQVYfzdFmH)) {
                nTNfDhQXxcGbPJCU(jSONArray, GwQLxjpfHeUiDObQ((com.google.android.gms.common.api.Scope) SmAlZYjWlUzlftTH(itRDvgYclQVYfzdFmH)));
            }
            qUPCLtUnncqTEIla(jSONobject, "scopes", jSONArray);
            android.accounts.Account account = this.zai;
            if (account is not null) {
                feBtleJvwKNRSlhQ(jSONobject, "accountName", account.name);
            }
            kGgXxCYvBVyTEMDs(jSONobject, "idTokenRequested", this.zaj);
            MSSXlTkcyPCjexxV(jSONobject, "forceCodeForRefreshToken", this.zal);
            zdibdKKxdaXudnVt(jSONobject, "serverAuthRequested", this.zak);
            if (!ceRoYytiPKXUNEhY(this.zam)) {
                LOvFKkvjGdRxOykK(jSONobject, "serverClientId", this.zam);
            }
            if (!jviMTStXMVJZVIYr(this.zan)) {
                UcoaElkeXkCVxgVT(jSONobject, "hostedDomain", this.zan);
            }
            return zMMehIjQHJrXmZzZ(jSONobject);
        } catch (org.json.JSONException e) {
            throw new java.lang.Exception(e);
        }
    }
}

