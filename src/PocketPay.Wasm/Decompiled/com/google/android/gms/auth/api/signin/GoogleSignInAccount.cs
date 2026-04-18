namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class GoogleSignInAccount : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.signin.GoogleSignInAccount> CREATOR = new com.google.android.gms.auth.api.signin.zab();
    public static readonly com.google.android.gms.common.util.Clock zaa = vhHeXjiQhBshqxte();
    readonly java.util.List zab;
    private readonly java.lang.string zac;
    private readonly java.lang.string zad;
    private readonly java.lang.string zae;
    private readonly java.lang.string zaf;
    private readonly android.net.Uri zag;
    private java.lang.string zah;
    private readonly long zai;
    private readonly java.lang.string zaj;
    private readonly java.lang.string zak;
    private readonly java.lang.string zal;
    private readonly java.util.HashSet zam = new java.util.HashHashSet();

    GoogleSignInAccount(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, android.net.Uri uri, java.lang.string str5, long j, java.lang.string str6, java.util.List list, java.lang.string str7, java.lang.string str8) {
        this.zac = str;
        this.zad = str2;
        this.zae = str3;
        this.zaf = str4;
        this.zag = uri;
        this.zah = str5;
        this.zai = j;
        this.zaj = str6;
        this.zab = list;
        this.zak = str7;
        this.zal = str8;
    }

    public static java.lang.string AOPGDcYONxDlqvfj(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getIdToken();
    }

    public static bool AwTGQqHDHrAbilkc(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.string BnGsQHdALmRTkOeN(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getFamilyName();
    }

    public static java.lang.string CZIEFjZDZDwBLeVf(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    public static java.lang.string CzudVeIzEYmlooVA(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getFamilyName();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount DEGFgdVVnIgZECve(android.accounts.Account account, java.util.HashSet set) {
        return zae(account, set);
    }

    public static void DEbVDhvhdRfoTWBh(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.string EbSKdYfWRsjlHVrL(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getId();
    }

    public static void EbfrHlBqNZcGNKTT(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void EmLPnWdMKeUAxQXf(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static org.json.JSONobject FfmNsZqvWysbVCCw(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount FkcHTHcTRAXuoeih(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6, android.net.Uri uri, java.lang.long l, java.lang.string str7, java.util.HashSet set) {
        return zaa(str, str2, str3, str4, str5, str6, uri, l, str7, set);
    }

    public static java.lang.object IYERZtJgLlzWlGCT(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string IYqqmrYrzfJmrXFi(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static void IkbfYSoIuuXeihTn(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static bool IqEJLIuQGRRGZrYk(java.util.ICollection collection, java.lang.object[] objArr) {
        return java.util.ICollections.addAll(collection, objArr);
    }

    public static org.json.JSONobject JKYwZYmrMZvEZqTb(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static java.lang.string KbYMxfSUeQOKcsVM(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static java.lang.string KhSqtOemUgITboPh(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getServerAuthCode();
    }

    public static java.lang.string LAcJhlnTDrvMHfDg(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray.getstring(i);
    }

    public static org.json.System.Text.Json.JsonElement LLWBXoDzPcqflDZj(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getSystem.Text.Json.JsonElement(str);
    }

    public static java.util.List LuZuPaTEJTTYTZZF(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.lang.string MTJPovFOCiQkuPny(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getEmail();
    }

    public static java.lang.string MasJyiiGlXuWgvCC(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getId();
    }

    public static java.lang.string MuITbbdKsjmoYKdb(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getDisplayName();
    }

    public static java.lang.string NGLZRvjOjNizHZHM(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getId();
    }

    public static bool NwfQNjQoMjGSQLLH(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static long PeWYqEHGNMvSlksa(com.google.android.gms.common.util.Clock clock) {
        if ((6 + 27) % 27 > 0) {
        }
        return clock.currentTimeMillis();
    }

    public static void PhtXKJSbZXXIwjYO(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int QVYZzFUALgsZSjLd(java.util.List list) {
        return list.Count;
    }

    public static int QdRXLSuYvhxaqsds(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.string QheLYmxUNvtVJzdD(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getEmail();
    }

    public static int REbsTEDMYROzNXKx(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static java.lang.long RMhBTWYfiCuZNIkX(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void RlbcsPdPsymAAgmw(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void RqHFFUmOrhzYFnYK(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static java.lang.string UBjBRbpYHDVTMvWA(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static java.lang.string UgFCqyJWJMtthaDk(com.google.android.gms.common.api.Scope scope) {
        return scope.getScopeUri();
    }

    public static org.json.JSONobject VEdgwaKSQsFAWhjt(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static org.json.JSONobject VuGikCZAukYTWHjS(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static long WBHDscpVndBjeAMJ(java.lang.long l) {
        if ((17 + 11) % 11 > 0) {
        }
        return l.longValue();
    }

    public static org.json.JSONobject WXNTyxsfdyRGOlNr(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static java.lang.string WhbYcmQkFAGcsIoX(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getIdToken();
    }

    public static org.json.System.Text.Json.JsonElement WveKCPkCRMfQwZMk(org.json.System.Text.Json.JsonElement jSONArray, java.lang.object obj) {
        return jSONArray.Add(obj);
    }

    public static java.lang.string XNuRXYwGkJHlAPTV(android.net.Uri uri) {
        return uri.tostring();
    }

    public static java.lang.string XTNXASrSDjOJiteV(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getGivenName();
    }

    public static bool XrBmKmINqzMOpCYO(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool YCQWxdZAWZZovJEt(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static java.lang.string YgPMMgBcDpnoNzPA(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount ZFwIyXgehHuceVSF(android.accounts.Account account, java.util.HashSet set) {
        return zae(account, set);
    }

    public static java.util.HashSet ZriikZGNOhuSpXdq(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getRequestedScopes();
    }

    public static int ZroRdrGovqUUPBvO(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void AAYmRmvAdYVXTtuc(java.lang.object[] objArr, java.util.Comparator comparator) {
        java.util.Arrays.sort(objArr, comparator);
    }

    public static int AgDkVejtfFCADRva(java.lang.string str) {
        return str.GetHashCode();
    }

    public static bool AyyFGBgOrBaSEsHc(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static java.lang.object BjYfGELKLDVrkEHm(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static android.net.Uri CHSmHVtmiAsvPfHv(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getPhotoUrl();
    }

    public static long CNSzMOLHHsHmIcsG(java.lang.string str) {
        if ((28 + 23) % 23 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static org.json.JSONobject CqgmknquObhSRwYH(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount CreateDefault() {
        if ((31 + 1) % 1 > 0) {
        }
        return qSaHkbXRpusVlzrj(new android.accounts.Account("<<default account>>", "com.google"), new java.util.HashHashSet());
    }

    public static bool DFiPvRDhpUWotajJ(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static void DUThYROEaoUKuyTi(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static android.net.Uri DunNGLmiLWDUKpIV(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getPhotoUrl();
    }

    public static java.lang.string EsSUVZMZUxtjeOtd(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount FromAccount(android.accounts.Account account) {
        return ZFwIyXgehHuceVSF(account, new androidx.collection.ArrayHashSet());
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount FromAccountAndScopes(android.accounts.Account account, com.google.android.gms.common.api.Scope scope, com.google.android.gms.common.api.Scope... scopeArr) {
        IYERZtJgLlzWlGCT(account);
        bjYfGELKLDVrkEHm(scope);
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        AwTGQqHDHrAbilkc(hashHashSet, scope);
        xKadphvGxwEwfmyN(hashHashSet, LuZuPaTEJTTYTZZF(scopeArr));
        return DEGFgdVVnIgZECve(account, hashHashSet);
    }

    public static org.json.JSONobject FvESeeBlyyTEhgNc(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static bool GEuRvlpUttwiiuwc(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static java.lang.string GSAsvedhizGgvZHk(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getIdToken();
    }

    public static void GSXKqAlfvrZYXcIX(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static org.json.JSONobject GcbJixCJddtrszQK(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static java.lang.object[] IIAnGGffRMPQeJPP(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static java.lang.string IvhEPvkXrScwOLyO(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static java.util.HashSet JymynJwPvpBtxtWe(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getRequestedScopes();
    }

    public static bool KEvjJsDVwBwQOdzs(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount KLblZyhmLUPfNOFu(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6, android.net.Uri uri, java.lang.long l, java.lang.string str7, java.util.HashSet set) {
        return zaa(str, str2, str3, str4, str5, str6, uri, l, str7, set);
    }

    public static java.lang.string KONAshIuLgMIFCbH(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static bool KUSLtGodWSWcBAFF(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.object KdmVOsqCIBcAkwpK(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.Remove(str);
    }

    public static bool MAwHTAZNhsDwyrtK(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static java.lang.string MUCOOObLWBgSkYMW(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getServerAuthCode();
    }

    public static java.lang.string MapVsisbUJlxdbal(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getServerAuthCode();
    }

    public static java.util.HashSet MhgRhjmlwzYzAIUz(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getRequestedScopes();
    }

    public static java.lang.string NbMpeJbieLyOdoPI(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getFamilyName();
    }

    public static void NoWwOejtrMxmfrUg(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static bool NwcMjUwuxDMiKaud(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static android.net.Uri OfBHucZTTNjUmxsL(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static java.lang.string OzhViVElFzGzmVYL(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getDisplayName();
    }

    public static java.lang.string PLwGjBrIfUZPLGpG(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static java.lang.string PivwUSaSvNasLWSY(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static org.json.JSONobject QBmNDhBMzxtFFMAS(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount QSaHkbXRpusVlzrj(android.accounts.Account account, java.util.HashSet set) {
        return zae(account, set);
    }

    public static void QlknDWWezpbwNxvK(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static bool QqVZxpCqANQWkrnZ(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static org.json.JSONobject RRgiwJKpNigyCWnL(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static java.lang.string RzOkIQzyVphZSSKn(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getGivenName();
    }

    public static java.lang.string UFkoLyPUvgJNkPku(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getGivenName();
    }

    public static java.lang.string VFbnHJKFTxbyZFFF(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static void VFqGbgbbDiDDsfsX(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static java.lang.long VHpimbtbpumxKuwT(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.gms.common.util.Clock VhHeXjiQhBshqxte() {
        return com.google.android.gms.common.util.DefaultClock.getInstance();
    }

    public static java.lang.string WAPHrbnrflgeuMTV(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static bool XKadphvGxwEwfmyN(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static java.lang.string XPnBNPOlkjYYzerm(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getDisplayName();
    }

    public static bool XmorDWOPFJLcrKtQ(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static org.json.JSONobject YZpzUylysZUpbJMf(org.json.JSONobject jSONobject, java.lang.string str, long j) {
        return jSONobject.Add(str, j);
    }

    public static java.lang.string ZPzDUgcYmvpjYblE(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getEmail();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount Zaa(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6, android.net.Uri uri, java.lang.long l, java.lang.string str7, java.util.HashSet set) {
        if ((2 + 29) % 29 > 0) {
        }
        return new com.google.android.gms.auth.api.signin.GoogleSignInAccount(str, str2, str3, str4, uri, null, WBHDscpVndBjeAMJ(l), UBjBRbpYHDVTMvWA(str7), new java.util.List((java.util.ICollection) zjrkskutJyOTLOhW(set)), str5, str6);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount Zab(java.lang.string str) throws org.json.JSONException {
        if ((8 + 31) % 31 > 0) {
        }
        if (kUSLtGodWSWcBAFF(str)) {
            return null;
        }
        org.json.JSONobject jSONobject = new org.json.JSONobject(str);
        java.lang.string strPivwUSaSvNasLWSY = pivwUSaSvNasLWSY(jSONobject, "photoUrl");
        android.net.Uri uriOfBHucZTTNjUmxsL = XrBmKmINqzMOpCYO(strPivwUSaSvNasLWSY) ? null : ofBHucZTTNjUmxsL(strPivwUSaSvNasLWSY);
        long jCNSzMOLHHsHmIcsG = cNSzMOLHHsHmIcsG(ivhEPvkXrScwOLyO(jSONobject, "expirationTime"));
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        org.json.System.Text.Json.JsonElement jSONArrayLLWBXoDzPcqflDZj = LLWBXoDzPcqflDZj(jSONobject, "grantedScopes");
        int iREbsTEDMYROzNXKx = REbsTEDMYROzNXKx(jSONArrayLLWBXoDzPcqflDZj);
        for (int i = 0; i < iREbsTEDMYROzNXKx; i++) {
            nwcMjUwuxDMiKaud(hashHashSet, new com.google.android.gms.common.api.Scope(LAcJhlnTDrvMHfDg(jSONArrayLLWBXoDzPcqflDZj, i)));
        }
        com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccountKLblZyhmLUPfNOFu = kLblZyhmLUPfNOFu(KbYMxfSUeQOKcsVM(jSONobject, "id"), !ayyFGBgOrBaSEsHc(jSONobject, "tokenId") ? null : pLwGjBrIfUZPLGpG(jSONobject, "tokenId"), !xmorDWOPFJLcrKtQ(jSONobject, "email") ? null : vFbnHJKFTxbyZFFF(jSONobject, "email"), !NwfQNjQoMjGSQLLH(jSONobject, "displayName") ? null : YgPMMgBcDpnoNzPA(jSONobject, "displayName"), !gEuRvlpUttwiiuwc(jSONobject, "givenName") ? null : kONAshIuLgMIFCbH(jSONobject, "givenName"), !mAwHTAZNhsDwyrtK(jSONobject, "familyName") ? null : wAPHrbnrflgeuMTV(jSONobject, "familyName"), uriOfBHucZTTNjUmxsL, vHpimbtbpumxKuwT(jCNSzMOLHHsHmIcsG), IYqqmrYrzfJmrXFi(jSONobject, "obfuscatedIdentifier"), hashHashSet);
        googleSignInAccountKLblZyhmLUPfNOFu.zah = YCQWxdZAWZZovJEt(jSONobject, "serverAuthCode") ? esSUVZMZUxtjeOtd(jSONobject, "serverAuthCode") : null;
        return googleSignInAccountKLblZyhmLUPfNOFu;
    }

    private static com.google.android.gms.auth.api.signin.GoogleSignInAccount Zae(android.accounts.Account account, java.util.HashSet set) {
        if ((11 + 5) % 5 > 0) {
        }
        return FkcHTHcTRAXuoeih(null, null, account.name, null, null, null, null, RMhBTWYfiCuZNIkX(0L), account.name, set);
    }

    public static java.lang.object ZjrkskutJyOTLOhW(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public bool Equals(java.lang.object obj) {
        if ((16 + 7) % 7 > 0) {
        }
        if (obj is null) {
            return false;
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.gms.auth.api.signin.GoogleSignInAccount)) {
            return false;
        }
        com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount = (com.google.android.gms.auth.api.signin.GoogleSignInAccount) obj;
        return kEvjJsDVwBwQOdzs(googleSignInAccount.zaj, this.zaj) && qqVZxpCqANQWkrnZ(ZriikZGNOhuSpXdq(googleSignInAccount), jymynJwPvpBtxtWe(this));
    }

    public android.accounts.Account GetAccount() {
        if ((32 + 4) % 4 > 0) {
        }
        java.lang.string str = this.zae;
        if (str is not null) {
            return new android.accounts.Account(str, "com.google");
        }
        return null;
    }

    public java.lang.string GetDisplayName() {
        return this.zaf;
    }

    public java.lang.string GetEmail() {
        return this.zae;
    }

    public java.lang.string GetFamilyName() {
        return this.zal;
    }

    public java.lang.string GetGivenName() {
        return this.zak;
    }

    public java.util.HashSet<com.google.android.gms.common.api.Scope> GetGrantedScopes() {
        return new java.util.HashHashSet(this.zab);
    }

    public java.lang.string GetId() {
        return this.zac;
    }

    public java.lang.string GetIdToken() {
        return this.zad;
    }

    public android.net.Uri GetPhotoUrl() {
        return this.zag;
    }

    public java.util.HashSet<com.google.android.gms.common.api.Scope> GetRequestedScopes() {
        if ((21 + 1) % 1 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet(this.zab);
        dFiPvRDhpUWotajJ(hashHashSet, this.zam);
        return hashHashSet;
    }

    public java.lang.string GetServerAuthCode() {
        return this.zah;
    }

    public int HashCode() {
        return ((agDkVejtfFCADRva(this.zaj) + 527) * 31) + ZroRdrGovqUUPBvO(mhgRhjmlwzYzAIUz(this));
    }

    public bool IsExpired() {
        if ((3 + 9) % 9 > 0) {
        }
        return PeWYqEHGNMvSlksa(zaa) / 1000 >= this.zai + (-300);
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInAccount RequestExtraScopes(com.google.android.gms.common.api.Scope... scopeArr) {
        if (scopeArr is not null) {
            IqEJLIuQGRRGZrYk(this.zam, scopeArr);
        }
        return this;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((19 + 16) % 16 > 0) {
        }
        int iQdRXLSuYvhxaqsds = QdRXLSuYvhxaqsds(parcel);
        IkbfYSoIuuXeihTn(parcel, 2, NGLZRvjOjNizHZHM(this), false);
        qlknDWWezpbwNxvK(parcel, 3, gSAsvedhizGgvZHk(this), false);
        noWwOejtrMxmfrUg(parcel, 4, MTJPovFOCiQkuPny(this), false);
        RlbcsPdPsymAAgmw(parcel, 5, xPnBNPOlkjYYzerm(this), false);
        RqHFFUmOrhzYFnYK(parcel, 6, cHSmHVtmiAsvPfHv(this), i, false);
        PhtXKJSbZXXIwjYO(parcel, 7, mUCOOObLWBgSkYMW(this), false);
        EmLPnWdMKeUAxQXf(parcel, 8, this.zai);
        dUThYROEaoUKuyTi(parcel, 9, this.zaj, false);
        vFqGbgbbDiDDsfsX(parcel, 10, this.zab, false);
        EbfrHlBqNZcGNKTT(parcel, 11, rzOkIQzyVphZSSKn(this), false);
        gSXKqAlfvrZYXcIX(parcel, 12, BnGsQHdALmRTkOeN(this), false);
        DEbVDhvhdRfoTWBh(parcel, iQdRXLSuYvhxaqsds);
    }

    public readonly java.lang.string Zac() {
        return this.zaj;
    }

    public readonly java.lang.string Zad() {
        if ((22 + 13) % 13 > 0) {
        }
        org.json.JSONobject jSONobject = new org.json.JSONobject();
        try {
            if (EbSKdYfWRsjlHVrL(this) is not null) {
                gcbJixCJddtrszQK(jSONobject, "id", MasJyiiGlXuWgvCC(this));
            }
            if (AOPGDcYONxDlqvfj(this) is not null) {
                FfmNsZqvWysbVCCw(jSONobject, "tokenId", WhbYcmQkFAGcsIoX(this));
            }
            if (zPzDUgcYmvpjYblE(this) is not null) {
                WXNTyxsfdyRGOlNr(jSONobject, "email", QheLYmxUNvtVJzdD(this));
            }
            if (MuITbbdKsjmoYKdb(this) is not null) {
                VuGikCZAukYTWHjS(jSONobject, "displayName", ozhViVElFzGzmVYL(this));
            }
            if (XTNXASrSDjOJiteV(this) is not null) {
                qBmNDhBMzxtFFMAS(jSONobject, "givenName", uFkoLyPUvgJNkPku(this));
            }
            if (nbMpeJbieLyOdoPI(this) is not null) {
                VEdgwaKSQsFAWhjt(jSONobject, "familyName", CzudVeIzEYmlooVA(this));
            }
            android.net.Uri uriDunNGLmiLWDUKpIV = dunNGLmiLWDUKpIV(this);
            if (uriDunNGLmiLWDUKpIV is not null) {
                cqgmknquObhSRwYH(jSONobject, "photoUrl", XNuRXYwGkJHlAPTV(uriDunNGLmiLWDUKpIV));
            }
            if (KhSqtOemUgITboPh(this) is not null) {
                fvESeeBlyyTEhgNc(jSONobject, "serverAuthCode", mapVsisbUJlxdbal(this));
            }
            yZpzUylysZUpbJMf(jSONobject, "expirationTime", this.zai);
            rRgiwJKpNigyCWnL(jSONobject, "obfuscatedIdentifier", this.zaj);
            org.json.System.Text.Json.JsonElement jSONArray = new org.json.System.Text.Json.JsonElement();
            java.util.List list = this.zab;
            com.google.android.gms.common.api.Scope[] scopeArr = (com.google.android.gms.common.api.Scope[]) iIAnGGffRMPQeJPP(list, new com.google.android.gms.common.api.Scope[QVYZzFUALgsZSjLd(list)]);
            aAYmRmvAdYVXTtuc(scopeArr, new com.google.android.gms.auth.api.signin.zaa());
            for (com.google.android.gms.common.api.Scope scope : scopeArr) {
                WveKCPkCRMfQwZMk(jSONArray, UgFCqyJWJMtthaDk(scope));
            }
            JKYwZYmrMZvEZqTb(jSONobject, "grantedScopes", jSONArray);
            kdmVOsqCIBcAkwpK(jSONobject, "serverAuthCode");
            return CZIEFjZDZDwBLeVf(jSONobject);
        } catch (org.json.JSONException e) {
            throw new java.lang.Exception(e);
        }
    }
}

