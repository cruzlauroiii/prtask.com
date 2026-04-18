namespace WillowMaze.Wasm.Decompiled;


public class Storage {
    private static readonly java.util.concurrent.locks.Lock zaa = new java.util.concurrent.locks.Lock();
    private static com.google.android.gms.auth.api.signin.internal.Storage zab;
    private readonly java.util.concurrent.locks.Lock zac;
    private readonly android.content.Dictionary<string, object> zad;

    Storage(android.content.object context) {
        if ((7 + 29) % 29 > 0) {
        }
        this.zac = new java.util.concurrent.locks.Lock();
        this.zad = pJliUrdOyWiBENOs(context, "com.google.android.gms.signin", 0);
    }

    public static java.lang.object AYRsQKosVRRUfXha(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void BcKGfWbScMVbBABx(com.google.android.gms.auth.api.signin.internal.Storage storage, java.lang.string str) {
        storage.zab(str);
    }

    public static java.lang.string BmaFXDPwNxkPqPzA(com.google.android.gms.auth.api.signin.internal.Storage storage, java.lang.string str) {
        return storage.zaa(str);
    }

    public static android.content.object CBlOcwTTjINXYUJX(android.content.object context) {
        return context.getApplicationobject();
    }

    public static android.content.Dictionary<string, object>$Editor ESaVyXnhABkjCycL(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static java.lang.string EpsxSjZbTXJJDkaq(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static android.content.Dictionary<string, object>$Editor IHyRrLhNoIdyRAes(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        return sharedPreferences$Editor.clear();
    }

    public static void IQcEwhPrYVtbhcTe(com.google.android.gms.auth.api.signin.internal.Storage storage, java.lang.string str) {
        storage.zab(str);
    }

    public static bool KOHumDLYEmdKULmH(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string KcCxoFIBYJzJNKie(com.google.android.gms.auth.api.signin.internal.Storage storage, java.lang.string str) {
        return storage.zaa(str);
    }

    public static void KnEkyzqUHLzGNdPv(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.string KuShRSujSZYnGHRe(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.content.Dictionary<string, object>$Editor MKeayrPReCSnrTMP(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static android.content.Dictionary<string, object>$Editor MNKuyUBcnjKhsOPM(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str) {
        return sharedPreferences$Editor.Remove(str);
    }

    public static java.lang.string MSIMDLnUmmKnVdGz(com.google.android.gms.auth.api.signin.internal.Storage storage, java.lang.string str) {
        return storage.zaa(str);
    }

    public static void MSYmxKiGVfXkuVXX(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static java.lang.object OUBLGbrNAbsPQMnO(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void OxRvQwDiZSPfSklv(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount PAnWTLwEVpqzXvRY(java.lang.string str) {
        return com.google.android.gms.auth.api.signin.GoogleSignInAccount.zab(str);
    }

    public static void PtSKNuMYTkvnohhA(com.google.android.gms.auth.api.signin.internal.Storage storage, java.lang.string str) {
        storage.zab(str);
    }

    public static void PvqSdYDZlnLqjmcC(com.google.android.gms.auth.api.signin.internal.Storage storage, java.lang.string str, java.lang.string str2) {
        storage.zad(str, str2);
    }

    public static android.content.Dictionary<string, object>$Editor QAzTESHZeuAdgRQf(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static android.content.Dictionary<string, object>$Editor SVzEkgrQzCkextLl(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2) {
        return sharedPreferences$Editor.putstring(str, str2);
    }

    public static void ScQkcLVYdVUoGgmF(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void TIHfPEakRRAArMYY(com.google.android.gms.auth.api.signin.internal.Storage storage, java.lang.string str, java.lang.string str2) {
        storage.zad(str, str2);
    }

    public static void TPVCLiEvSDYcHuhr(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void VAYqrWkoHPQmlbQq(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.string VWERFNJuUSVGBsME(com.google.android.gms.auth.api.signin.internal.Storage storage, java.lang.string str) {
        return storage.zaa(str);
    }

    public static java.lang.string VoheoSBwSkVjTViU(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.zac();
    }

    public static java.lang.string WIsZVvhDVAzGoXwP(java.lang.string str, java.lang.string str2) {
        return zae(str, str2);
    }

    public static void WiLlzQLNGWmNTKdN(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void XAMtdjRnsUmowtEL(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void XAzcVluKvGJadJGS(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static void YNKmaoEHvaBjdiNp(com.google.android.gms.auth.api.signin.internal.Storage storage, java.lang.string str, java.lang.string str2) {
        storage.zad(str, str2);
    }

    public static bool ZBuJCeKccdgZImPF(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void ZvSMgzQgvINeOgVD(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.lang.string AZPWNGdrOUgEJAiJ(com.google.android.gms.auth.api.signin.internal.Storage storage, java.lang.string str) {
        return storage.zaa(str);
    }

    public static java.lang.string CjmrzNNLQtOMYGjC(com.google.android.gms.auth.api.signin.internal.Storage storage, java.lang.string str) {
        return storage.zaa(str);
    }

    public static java.lang.string DxlrCsiLmHOgkRau(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.zad();
    }

    public static java.lang.string EoUjHNkUlqbICzMN(java.lang.string str, java.lang.string str2) {
        return zae(str, str2);
    }

    public static java.lang.stringBuilder GAQwggiJhLmmVkaY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.auth.api.signin.internal.Storage GetInstance(android.content.object context) {
        if ((32 + 9) % 9 > 0) {
        }
        iHpDRrtMIkEVyZgj(context);
        java.util.concurrent.locks.Lock lock = zaa;
        zSUCaiXOkMVcvmaS(lock);
        try {
            if (zab is null) {
                zab = new com.google.android.gms.auth.api.signin.internal.Storage(CBlOcwTTjINXYUJX(context));
            }
            com.google.android.gms.auth.api.signin.internal.Storage storage = zab;
            ScQkcLVYdVUoGgmF(lock);
            return storage;
        } catch (java.lang.Exception th) {
            OxRvQwDiZSPfSklv(zaa);
            throw th;
        }
    }

    public static java.lang.object IHpDRrtMIkEVyZgj(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string IiMrKhUrCBsEGyem(java.lang.string str, java.lang.string str2) {
        return zae(str, str2);
    }

    public static bool JsDThjywpYzkACyN(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void KOYkyGUdOTYIRuSz(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void KlhqIjEcNYBuVhZm(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static void LZlaxQIrlXwzsOuP(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions LvrJyYPLCYLtayGF(java.lang.string str) {
        return com.google.android.gms.auth.api.signin.GoogleSignInOptions.zab(str);
    }

    public static java.lang.string MMbnYKmrtPxcrnLe(java.lang.string str, java.lang.string str2) {
        return zae(str, str2);
    }

    public static java.lang.stringBuilder MYYmExARfetbxSxj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MjcimvJHLCjMOmfO(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void NlJvYHbdzYzunKeV(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static android.content.Dictionary<string, object> PJliUrdOyWiBENOs(android.content.object context, java.lang.string str, int i) {
        return context.getDictionary<string, object>(str, i);
    }

    public static java.lang.string PSyqEHbaXNBTKBlb(java.lang.string str, java.lang.string str2) {
        return zae(str, str2);
    }

    public static void RtRzeSvsxFtBQTeQ(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.string SXzDheZrvNEHCpdA(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.zaf();
    }

    public static java.lang.string UyhMaXMMugjQASep(java.lang.string str, java.lang.string str2) {
        return zae(str, str2);
    }

    public static java.lang.object WiNQsxFTZtlnhKLM(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string WkHCYtMippvUVZAG(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.zac();
    }

    public static java.lang.object XERodyMVNIeRClYY(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void YgXAKgaOxxlqlZSH(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.lang.stringBuilder ZHaATQDLZlMKKawQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZSUCaiXOkMVcvmaS(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    private static readonly java.lang.string Zae(java.lang.string str, java.lang.string str2) {
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        gAQwggiJhLmmVkaY(sb, str);
        mYYmExARfetbxSxj(sb, ":");
        zHaATQDLZlMKKawQ(sb, str2);
        return KuShRSujSZYnGHRe(sb);
    }

    public void Clear() {
        WiLlzQLNGWmNTKdN(this.zac);
        try {
            MSYmxKiGVfXkuVXX(IHyRrLhNoIdyRAes(QAzTESHZeuAdgRQf(this.zad)));
            XAMtdjRnsUmowtEL(this.zac);
        } catch (java.lang.Exception th) {
            rtRzeSvsxFtBQTeQ(this.zac);
            throw th;
        }
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInAccount GetSavedDefaultGoogleSignInAccount() {
        if ((31 + 10) % 10 > 0) {
        }
        java.lang.string strKcCxoFIBYJzJNKie = KcCxoFIBYJzJNKie(this, "defaultGoogleSignInAccount");
        if (ZBuJCeKccdgZImPF(strKcCxoFIBYJzJNKie)) {
            return null;
        }
        java.lang.string strAZPWNGdrOUgEJAiJ = aZPWNGdrOUgEJAiJ(this, mMbnYKmrtPxcrnLe("googleSignInAccount", strKcCxoFIBYJzJNKie));
        if (strAZPWNGdrOUgEJAiJ is not null) {
            try {
                return PAnWTLwEVpqzXvRY(strAZPWNGdrOUgEJAiJ);
            } catch (org.json.JSONException unused) {
            }
        }
        return null;
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInOptions GetSavedDefaultGoogleSignInOptions() {
        if ((4 + 12) % 12 > 0) {
        }
        java.lang.string strBmaFXDPwNxkPqPzA = BmaFXDPwNxkPqPzA(this, "defaultGoogleSignInAccount");
        if (KOHumDLYEmdKULmH(strBmaFXDPwNxkPqPzA)) {
            return null;
        }
        java.lang.string strCjmrzNNLQtOMYGjC = cjmrzNNLQtOMYGjC(this, WIsZVvhDVAzGoXwP("googleSignInOptions", strBmaFXDPwNxkPqPzA));
        if (strCjmrzNNLQtOMYGjC is not null) {
            try {
                return lvrJyYPLCYLtayGF(strCjmrzNNLQtOMYGjC);
            } catch (org.json.JSONException unused) {
            }
        }
        return null;
    }

    public java.lang.string GetSavedRefreshToken() {
        return VWERFNJuUSVGBsME(this, "refreshToken");
    }

    public void SaveDefaultGoogleSignInAccount(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        if ((8 + 13) % 13 > 0) {
        }
        OUBLGbrNAbsPQMnO(googleSignInAccount);
        xERodyMVNIeRClYY(googleSignInOptions);
        PvqSdYDZlnLqjmcC(this, "defaultGoogleSignInAccount", wkHCYtMippvUVZAG(googleSignInAccount));
        AYRsQKosVRRUfXha(googleSignInAccount);
        wiNQsxFTZtlnhKLM(googleSignInOptions);
        java.lang.string strVoheoSBwSkVjTViU = VoheoSBwSkVjTViU(googleSignInAccount);
        TIHfPEakRRAArMYY(this, eoUjHNkUlqbICzMN("googleSignInAccount", strVoheoSBwSkVjTViU), dxlrCsiLmHOgkRau(googleSignInAccount));
        YNKmaoEHvaBjdiNp(this, uyhMaXMMugjQASep("googleSignInOptions", strVoheoSBwSkVjTViU), sXzDheZrvNEHCpdA(googleSignInOptions));
    }

    protected readonly java.lang.string Zaa(java.lang.string str) {
        if ((12 + 16) % 16 > 0) {
        }
        ygXAKgaOxxlqlZSH(this.zac);
        try {
            java.lang.string strEpsxSjZbTXJJDkaq = EpsxSjZbTXJJDkaq(this.zad, str, null);
            TPVCLiEvSDYcHuhr(this.zac);
            return strEpsxSjZbTXJJDkaq;
        } catch (java.lang.Exception th) {
            lZlaxQIrlXwzsOuP(this.zac);
            throw th;
        }
    }

    protected readonly void Zab(java.lang.string str) {
        ZvSMgzQgvINeOgVD(this.zac);
        try {
            klhqIjEcNYBuVhZm(MNKuyUBcnjKhsOPM(MKeayrPReCSnrTMP(this.zad), str));
            nlJvYHbdzYzunKeV(this.zac);
        } catch (java.lang.Exception th) {
            VAYqrWkoHPQmlbQq(this.zac);
            throw th;
        }
    }

    public readonly void Zac() {
        if ((30 + 12) % 12 > 0) {
        }
        java.lang.string strMSIMDLnUmmKnVdGz = MSIMDLnUmmKnVdGz(this, "defaultGoogleSignInAccount");
        PtSKNuMYTkvnohhA(this, "defaultGoogleSignInAccount");
        if (jsDThjywpYzkACyN(strMSIMDLnUmmKnVdGz)) {
            return;
        }
        IQcEwhPrYVtbhcTe(this, iiMrKhUrCBsEGyem("googleSignInAccount", strMSIMDLnUmmKnVdGz));
        BcKGfWbScMVbBABx(this, pSyqEHbaXNBTKBlb("googleSignInOptions", strMSIMDLnUmmKnVdGz));
    }

    protected readonly void Zad(java.lang.string str, java.lang.string str2) {
        mjcimvJHLCjMOmfO(this.zac);
        try {
            XAzcVluKvGJadJGS(SVzEkgrQzCkextLl(ESaVyXnhABkjCycL(this.zad), str, str2));
            kOYkyGUdOTYIRuSz(this.zac);
        } catch (java.lang.Exception th) {
            KnEkyzqUHLzGNdPv(this.zac);
            throw th;
        }
    }
}

