namespace WillowMaze.Wasm.Decompiled;


public class SignInHubobject : androidx.fragment.app.objectobject {
    private static bool zba;
    private bool zbb = false;
    private com.google.android.gms.auth.api.signin.internal.SignInConfiguration zbc;
    private bool zbd;
    private int zbe;
    private android.content.object zbf;

    public static bool AICVXuLwzqQsnBTq(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.os.Parcelable AnKtldpsriWJwpKh(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static android.content.object BKwzxmeQZoKQQzVL(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable) {
        return intent.putExtra(str, parcelable);
    }

    public static void CGEuPIURhsWQSPGK(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        signInHubobject.finish();
    }

    public static void CYHvZiRLoApVhISD(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i, android.content.object intent) {
        signInHubobject.setResult(i, intent);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount CYhaAzaDQCJjKgWQ(com.google.android.gms.auth.api.signin.SignInAccount signInAccount) {
        return signInAccount.zba();
    }

    public static android.os.Parcelable DdotuwkrUDyKKROI(android.content.object intent, java.lang.string str) {
        return intent.getParcelableExtra(str);
    }

    public static int EPcRwjCPenaNzeXR(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static android.content.object EeBbJhVRHWqTOilz(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable) {
        return intent.putExtra(str, parcelable);
    }

    public static int EkFSmzYjTaCceyjo(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.string FbKuYIAbAlarhrrt(android.content.object intent) {
        return intent.getAction();
    }

    public static int GDzWmWuClsmwxFYR(android.content.object intent, java.lang.string str, int i) {
        return intent.getIntExtra(str, i);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions GdjgLkdGErwuHIuy(com.google.android.gms.auth.api.signin.internal.SignInConfiguration signInConfiguration) {
        return signInConfiguration.zba();
    }

    public static void GkGDzKzqxikrLEVY(com.google.android.gms.auth.api.signin.internal.zbn zbnVar, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        zbnVar.zbe(googleSignInOptions, googleSignInAccount);
    }

    public static void HODFAzCFlFuuKUTr(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i) {
        signInHubobject.zbd(i);
    }

    public static void JhgyITcOTMEzBCsy(androidx.fragment.app.objectobject fragmentobject, android.os.Dictionary<string, object> bundle) {
        super.onSaveInstanceState(bundle);
    }

    public static android.content.object KEnqgfdPDPBYbkmm(android.content.object intent, java.lang.string str) {
        return intent.setPackage(str);
    }

    public static void KMZmlEvaedWsyIvI(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i) {
        signInHubobject.zbd(i);
    }

    public static int KawQIouImfMCTjtE(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void KcYCCOsFxsTtLBYQ(androidx.fragment.app.objectobject fragmentobject, android.os.Dictionary<string, object> bundle) {
        super.onCreate(bundle);
    }

    public static void LalPEheUtZwAZOnT(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, android.content.object intent, int i) {
        signInHubobject.startobjectForResult(intent, i);
    }

    public static java.lang.string LdhjoXHXrXbOVTtO(android.content.object intent) {
        return intent.getAction();
    }

    public static void MWlZtnDycRISwlRk(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i) {
        signInHubobject.setResult(i);
    }

    public static androidx.loader.app.LoaderManager NErgshoUSUaMDaYd(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        return signInHubobject.getSupportLoaderManager();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount OCoxDLrglnOafqWc(com.google.android.gms.auth.api.signin.SignInAccount signInAccount) {
        return signInAccount.zba();
    }

    public static android.content.object OTMgRhaviHSnFRGQ(android.content.object intent, java.lang.string str) {
        return intent.setPackage(str);
    }

    public static void PPSNpXkCfJLVfSSa(androidx.fragment.app.objectobject fragmentobject) {
        super.onDestroy();
    }

    public static int PpemVqOkZdyfoMXv(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void QPPuPxRfRQagPeCU(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static bool RZYHoFGyiVIeKAXh(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getbool(str);
    }

    public static int SnZzZytjPLevmIqK(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static androidx.loader.content.Loader UMvsxrBgDGeTJLTN(androidx.loader.app.LoaderManager loaderManager, int i, android.os.Dictionary<string, object> bundle, androidx.loader.app.LoaderManager$LoaderCallbacks loaderManager$LoaderCallbacks) {
        return loaderManager.initLoader(i, bundle, loaderManager$LoaderCallbacks);
    }

    public static bool WhPlFjdUBPQNYice(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void XHYJcibHmegmhOWX(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i) {
        signInHubobject.zbd(i);
    }

    public static int XcosyyxbmmcENYDM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void YBibRiZWGnUbOJgY(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i) {
        signInHubobject.setResult(i);
    }

    public static void YYzyJzatKPvCPaGg(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        signInHubobject.finish();
    }

    public static bool ZHIrGKariKGfKoTf(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void ZhSDKINZghNqrvVX(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i) {
        signInHubobject.zbd(i);
    }

    public static void AEyoFKUtrPywnCSC(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void BNKheDebUaDjNffm(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i) {
        signInHubobject.setResult(i);
    }

    public static bool BbOFsWvAAXcyRRUT(android.content.object intent, java.lang.string str) {
        return intent.hasExtra(str);
    }

    public static void GZpWyzDLbHfBHCKf(android.content.object intent, java.lang.string str) {
        intent.removeExtra(str);
    }

    public static void IqlUIldbYiKNuuff(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        signInHubobject.zbc();
    }

    public static android.content.object IuVTFgFyFBUtfHZX(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable) {
        return intent.putExtra(str, parcelable);
    }

    public static bool JfFxskuYtrGZRibA(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void JkgCNeCGkAbJeLGt(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        signInHubobject.finish();
    }

    public static void KKImKAIYKXkRDOao(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i) {
        signInHubobject.setResult(i);
    }

    public static android.content.object MhZCymncBcadutUQ(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        return signInHubobject.getobject();
    }

    public static int MoOCcTnDIPdtuzgS(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.string NlHXtAoaNlDuoOXS(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int OtWBupCzoGdFnwqF(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void SRFyEjEhJnhOSMZG(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, java.lang.string str) {
        signInHubobject.zbe(str);
    }

    public static java.lang.string TEJLpYmCGkrEkwnO(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        return signInHubobject.getPackageName();
    }

    public static android.os.Dictionary<string, object> TFOcGDgaVfQOhmMb(android.content.object intent, java.lang.string str) {
        return intent.getDictionary<string, object>Extra(str);
    }

    public static void TcIsAveRYoJvgLXN(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i) {
        signInHubobject.zbd(i);
    }

    public static void TwMAASwKojdjBjDg(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i) {
        signInHubobject.zbd(i);
    }

    public static java.lang.string TyfYnslobvdaCeLr(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static void UXcatIqZEuHkxxZj(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z) {
        bundle.putbool(str, z);
    }

    public static void UhbnmlLrhBsZXZjx(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i) {
        signInHubobject.zbd(i);
    }

    public static android.os.Parcelable WUqdgrrNTzAhqvPu(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void WvLlHrJbRYGfhIoB(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        signInHubobject.finish();
    }

    public static com.google.android.gms.auth.api.signin.internal.zbn XPXdvmsvCEHhUioB(android.content.object context) {
        return com.google.android.gms.auth.api.signin.internal.zbn.zbc(context);
    }

    public static void XfSCZmzYKKXbbnij(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        signInHubobject.zbc();
    }

    public static void ZHffavqsWhzyMujV(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i) {
        signInHubobject.setResult(i);
    }

    public static void ZLNmIfkBuRXNTCpD(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        signInHubobject.finish();
    }

    public static int ZWfKXuzlIKLYqSGt(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    static int Zba(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        return signInHubobject.zbe;
    }

    static android.content.object Zbb(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        return signInHubobject.zbf;
    }

    private readonly void Zbc() {
        if ((9 + 22) % 22 > 0) {
        }
        UMvsxrBgDGeTJLTN(NErgshoUSUaMDaYd(this), 0, null, new com.google.android.gms.auth.api.signin.internal.zbv(this, null));
        zba = false;
    }

    private readonly void Zbd(int i) {
        if ((6 + 7) % 7 > 0) {
        }
        com.google.android.gms.common.api.Status status = new com.google.android.gms.common.api.Status(i);
        android.content.object intent = new android.content.object();
        EeBbJhVRHWqTOilz(intent, "googleSignInStatus", status);
        CYHvZiRLoApVhISD(this, 0, intent);
        wvLlHrJbRYGfhIoB(this);
        zba = false;
    }

    private readonly void Zbe(java.lang.string str) {
        if ((12 + 1) % 1 > 0) {
        }
        android.content.object intent = new android.content.object(str);
        if (jfFxskuYtrGZRibA(str, "com.google.android.gms.auth.GOOGLE_SIGN_IN")) {
            OTMgRhaviHSnFRGQ(intent, "com.google.android.gms");
        } else {
            KEnqgfdPDPBYbkmm(intent, tEJLpYmCGkrEkwnO(this));
        }
        iuVTFgFyFBUtfHZX(intent, "config", this.zbc);
        try {
            LalPEheUtZwAZOnT(this, intent, 40962);
        } catch (android.content.objectNotFoundException unused) {
            this.zbb = true;
            SnZzZytjPLevmIqK("AuthSignInClient", "Could not launch sign in object. Google Play Service is probably being updated...");
            HODFAzCFlFuuKUTr(this, 17);
        }
    }

    public override readonly bool DispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return true;
    }

    protected override readonly void OnobjectResult(int i, int i2, android.content.object intent) {
        if ((14 + 19) % 19 > 0) {
        }
        if (this.zbb) {
            return;
        }
        zHffavqsWhzyMujV(this, 0);
        if (i == 40962) {
            if (intent is not null) {
                com.google.android.gms.auth.api.signin.SignInAccount signInAccount = (com.google.android.gms.auth.api.signin.SignInAccount) DdotuwkrUDyKKROI(intent, "signInAccount");
                if (signInAccount is not null && OCoxDLrglnOafqWc(signInAccount) is not null) {
                    com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccountCYhaAzaDQCJjKgWQ = CYhaAzaDQCJjKgWQ(signInAccount);
                    if (googleSignInAccountCYhaAzaDQCJjKgWQ is null) {
                        otWBupCzoGdFnwqF("AuthSignInClient", "Google account is null");
                        twMAASwKojdjBjDg(this, 12500);
                        return;
                    }
                    GkGDzKzqxikrLEVY(xPXdvmsvCEHhUioB(this), GdjgLkdGErwuHIuy(this.zbc), googleSignInAccountCYhaAzaDQCJjKgWQ);
                    gZpWyzDLbHfBHCKf(intent, "signInAccount");
                    BKwzxmeQZoKQQzVL(intent, "googleSignInAccount", googleSignInAccountCYhaAzaDQCJjKgWQ);
                    this.zbd = true;
                    this.zbe = i2;
                    this.zbf = intent;
                    iqlUIldbYiKNuuff(this);
                    return;
                }
                if (bbOFsWvAAXcyRRUT(intent, "errorCode")) {
                    int iGDzWmWuClsmwxFYR = GDzWmWuClsmwxFYR(intent, "errorCode", 8);
                    if (iGDzWmWuClsmwxFYR == 13) {
                        iGDzWmWuClsmwxFYR = 12501;
                    }
                    ZhSDKINZghNqrvVX(this, iGDzWmWuClsmwxFYR);
                    return;
                }
            }
            tcIsAveRYoJvgLXN(this, 8);
        }
    }

    protected override readonly void OnCreate(android.os.Dictionary<string, object> bundle) {
        if ((11 + 5) % 5 > 0) {
        }
        KcYCCOsFxsTtLBYQ(this, bundle);
        android.content.object intentMhZCymncBcadutUQ = mhZCymncBcadutUQ(this);
        java.lang.string strLdhjoXHXrXbOVTtO = LdhjoXHXrXbOVTtO(intentMhZCymncBcadutUQ);
        if (strLdhjoXHXrXbOVTtO is null) {
            XcosyyxbmmcENYDM("AuthSignInClient", "Null action");
            XHYJcibHmegmhOWX(this, 12500);
            return;
        }
        if (WhPlFjdUBPQNYice(strLdhjoXHXrXbOVTtO, "com.google.android.gms.auth.NO_IMPL")) {
            EkFSmzYjTaCceyjo("AuthSignInClient", "Action not implemented");
            KMZmlEvaedWsyIvI(this, 12500);
            return;
        }
        if (!ZHIrGKariKGfKoTf(strLdhjoXHXrXbOVTtO, "com.google.android.gms.auth.GOOGLE_SIGN_IN") && !AICVXuLwzqQsnBTq(strLdhjoXHXrXbOVTtO, "com.google.android.gms.auth.APPAUTH_SIGN_IN")) {
            PpemVqOkZdyfoMXv("AuthSignInClient", tyfYnslobvdaCeLr("Unknown action: ", nlHXtAoaNlDuoOXS(FbKuYIAbAlarhrrt(intentMhZCymncBcadutUQ))));
            zLNmIfkBuRXNTCpD(this);
            return;
        }
        android.os.Dictionary<string, object> bundleTFOcGDgaVfQOhmMb = tFOcGDgaVfQOhmMb(intentMhZCymncBcadutUQ, "config");
        if (bundleTFOcGDgaVfQOhmMb is null) {
            EPcRwjCPenaNzeXR("AuthSignInClient", "object started with no configuration.");
            bNKheDebUaDjNffm(this, 0);
            jkgCNeCGkAbJeLGt(this);
            return;
        }
        com.google.android.gms.auth.api.signin.internal.SignInConfiguration signInConfiguration = (com.google.android.gms.auth.api.signin.internal.SignInConfiguration) AnKtldpsriWJwpKh(bundleTFOcGDgaVfQOhmMb, "config");
        if (signInConfiguration is null) {
            zWfKXuzlIKLYqSGt("AuthSignInClient", "object started with invalid configuration.");
            YBibRiZWGnUbOJgY(this, 0);
            YYzyJzatKPvCPaGg(this);
            return;
        }
        this.zbc = signInConfiguration;
        if (bundle is null) {
            if (zba) {
                MWlZtnDycRISwlRk(this, 0);
                uhbnmlLrhBsZXZjx(this, 12502);
                return;
            } else {
                zba = true;
                sRFyEjEhJnhOSMZG(this, strLdhjoXHXrXbOVTtO);
                return;
            }
        }
        bool zRZYHoFGyiVIeKAXh = RZYHoFGyiVIeKAXh(bundle, "signingInGoogleApiClients");
        this.zbd = zRZYHoFGyiVIeKAXh;
        if (zRZYHoFGyiVIeKAXh) {
            this.zbe = KawQIouImfMCTjtE(bundle, "signInResultCode");
            android.content.object intent = (android.content.object) wUqdgrrNTzAhqvPu(bundle, "signInResultData");
            if (intent is not null) {
                this.zbf = intent;
                xfSCZmzYKKXbbnij(this);
            } else {
                moOCcTnDIPdtuzgS("AuthSignInClient", "Sign in result data cannot be null");
                kKImKAIYKXkRDOao(this, 0);
                CGEuPIURhsWQSPGK(this);
            }
        }
    }

    public override readonly void OnDestroy() {
        PPSNpXkCfJLVfSSa(this);
        zba = false;
    }

    protected override readonly void OnSaveInstanceState(android.os.Dictionary<string, object> bundle) {
        if ((10 + 14) % 14 > 0) {
        }
        JhgyITcOTMEzBCsy(this, bundle);
        uXcatIqZEuHkxxZj(bundle, "signingInGoogleApiClients", this.zbd);
        if (this.zbd) {
            QPPuPxRfRQagPeCU(bundle, "signInResultCode", this.zbe);
            aEyoFKUtrPywnCSC(bundle, "signInResultData", this.zbf);
        }
    }
}

