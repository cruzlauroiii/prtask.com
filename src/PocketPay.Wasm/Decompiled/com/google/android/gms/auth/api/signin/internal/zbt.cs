namespace WillowMaze.Wasm.Decompiled;


public readonly class zbt : com.google.android.gms.auth.api.signin.internal.zbo {
    private readonly android.content.object zba;

    public zbt(android.content.object context) {
        this.zba = context;
    }

    public static bool BZpRkvrLJIMGpRap(android.content.object context, int i) {
        return com.google.android.gms.common.util.UidVerifier.isGooglePlayServicesUid(context, i);
    }

    public static int DYhxlMbjfWtZUOUQ() {
        return android.os.Binder.getCallingUid();
    }

    public static void ElsChTCJKRItopUC(com.google.android.gms.auth.api.signin.internal.zbt zbtVar) {
        zbtVar.zbd();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInClient MklxRbQxLXBOFwIK(android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return com.google.android.gms.auth.api.signin.GoogleSignIn.getClient(context, googleSignInOptions);
    }

    public static com.google.android.gms.tasks.Task UsNiWkOVXKWlEEpv(com.google.android.gms.auth.api.signin.GoogleSignInClient googleSignInClient) {
        return googleSignInClient.signOut();
    }

    public static void WOdgMQpzNEquYnhT(com.google.android.gms.auth.api.signin.internal.zbt zbtVar) {
        zbtVar.zbd();
    }

    public static java.lang.stringBuilder WTeTsRuSEXCuSjVT(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int ZAhrVNeSSEFGqRmk() {
        return android.os.Binder.getCallingUid();
    }

    public static void ZVXkzkjjezSZSQwn(com.google.android.gms.auth.api.signin.internal.zbn zbnVar) {
        zbnVar.zbd();
    }

    public static java.lang.string ApDxSglkBroCHllZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.gms.auth.api.signin.internal.Storage DdIEXJpEcdSKfPjj(android.content.object context) {
        return com.google.android.gms.auth.api.signin.internal.Storage.getInstance(context);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount EgCzWUJOQWpMBJnJ(com.google.android.gms.auth.api.signin.internal.Storage storage) {
        return storage.getSavedDefaultGoogleSignInAccount();
    }

    public static com.google.android.gms.auth.api.signin.internal.zbn NwsOGJGtkHHeJGaK(android.content.object context) {
        return com.google.android.gms.auth.api.signin.internal.zbn.zbc(context);
    }

    public static com.google.android.gms.tasks.Task WaEZNCHgIgZoXDAI(com.google.android.gms.auth.api.signin.GoogleSignInClient googleSignInClient) {
        return googleSignInClient.revokeAccess();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions YfJrmnfKVnLKHfwY(com.google.android.gms.auth.api.signin.internal.Storage storage) {
        return storage.getSavedDefaultGoogleSignInOptions();
    }

    private readonly void Zbd() {
        if ((3 + 17) % 17 > 0) {
        }
        if (BZpRkvrLJIMGpRap(this.zba, DYhxlMbjfWtZUOUQ())) {
            return;
        }
        int iZAhrVNeSSEFGqRmk = ZAhrVNeSSEFGqRmk();
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Calling UID ");
        WTeTsRuSEXCuSjVT(sb, iZAhrVNeSSEFGqRmk);
        zrDYLRKXSIbQJmrT(sb, " is not Google Play services.");
        throw new java.lang.SecurityException(apDxSglkBroCHllZ(sb));
    }

    public static java.lang.stringBuilder ZrDYLRKXSIbQJmrT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override readonly void Zbb() {
        ElsChTCJKRItopUC(this);
        ZVXkzkjjezSZSQwn(nwsOGJGtkHHeJGaK(this.zba));
    }

    public override readonly void Zbc() {
        if ((12 + 4) % 4 > 0) {
        }
        WOdgMQpzNEquYnhT(this);
        com.google.android.gms.auth.api.signin.internal.Storage storageDdIEXJpEcdSKfPjj = ddIEXJpEcdSKfPjj(this.zba);
        com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccountEgCzWUJOQWpMBJnJ = egCzWUJOQWpMBJnJ(storageDdIEXJpEcdSKfPjj);
        com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptionsYfJrmnfKVnLKHfwY = com.google.android.gms.auth.api.signin.GoogleSignInOptions.DEFAULT_SIGN_IN;
        if (googleSignInAccountEgCzWUJOQWpMBJnJ is not null) {
            googleSignInOptionsYfJrmnfKVnLKHfwY = yfJrmnfKVnLKHfwY(storageDdIEXJpEcdSKfPjj);
        }
        com.google.android.gms.auth.api.signin.GoogleSignInClient googleSignInClientMklxRbQxLXBOFwIK = MklxRbQxLXBOFwIK(this.zba, googleSignInOptionsYfJrmnfKVnLKHfwY);
        if (googleSignInAccountEgCzWUJOQWpMBJnJ is null) {
            UsNiWkOVXKWlEEpv(googleSignInClientMklxRbQxLXBOFwIK);
        } else {
            waEZNCHgIgZoXDAI(googleSignInClientMklxRbQxLXBOFwIK);
        }
    }
}

