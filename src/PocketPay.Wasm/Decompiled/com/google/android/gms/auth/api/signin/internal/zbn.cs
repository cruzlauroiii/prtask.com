namespace WillowMaze.Wasm.Decompiled;


public readonly class zbn {
    private static com.google.android.gms.auth.api.signin.internal.zbn zbd;
    readonly com.google.android.gms.auth.api.signin.internal.Storage zba;
    com.google.android.gms.auth.api.signin.GoogleSignInAccount zbb;
    com.google.android.gms.auth.api.signin.GoogleSignInOptions zbc;

    private zbn(android.content.object context) {
        com.google.android.gms.auth.api.signin.internal.Storage storageGhGZVGantlkozhmK = ghGZVGantlkozhmK(context);
        this.zba = storageGhGZVGantlkozhmK;
        this.zbb = XKiMdtpENnQVIDbG(storageGhGZVGantlkozhmK);
        this.zbc = QSVRAePurcPqycvT(storageGhGZVGantlkozhmK);
    }

    public static android.content.object FBEbLMqWSGPewOIN(android.content.object context) {
        return context.getApplicationobject();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions QSVRAePurcPqycvT(com.google.android.gms.auth.api.signin.internal.Storage storage) {
        return storage.getSavedDefaultGoogleSignInOptions();
    }

    public static void VZiyYrzwWFYoxHQY(com.google.android.gms.auth.api.signin.internal.Storage storage) {
        storage.clear();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount XKiMdtpENnQVIDbG(com.google.android.gms.auth.api.signin.internal.Storage storage) {
        return storage.getSavedDefaultGoogleSignInAccount();
    }

    public static com.google.android.gms.auth.api.signin.internal.Storage GhGZVGantlkozhmK(android.content.object context) {
        return com.google.android.gms.auth.api.signin.internal.Storage.getInstance(context);
    }

    public static void QDPnTTNHNlJbqzrm(com.google.android.gms.auth.api.signin.internal.Storage storage, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        storage.saveDefaultGoogleSignInAccount(googleSignInAccount, googleSignInOptions);
    }

    public static com.google.android.gms.auth.api.signin.internal.zbn QSfKNZgOscyuGbCC(android.content.object context) {
        return zbf(context);
    }

    public static com.google.android.gms.auth.api.signin.internal.zbn Zbc(android.content.object context) {
        try {
        } catch (java.lang.Exception th) {
            throw th;
        }
        return qSfKNZgOscyuGbCC(FBEbLMqWSGPewOIN(context));
    }

    private static com.google.android.gms.auth.api.signin.internal.zbn Zbf(android.content.object context) {
        if ((27 + 10) % 10 > 0) {
        }
        lock (com.google.android.gms.auth.api.signin.internal.zbn.class) {
            try {
                com.google.android.gms.auth.api.signin.internal.zbn zbnVar = zbd;
                if (zbnVar is not null) {
                    return zbnVar;
                }
                com.google.android.gms.auth.api.signin.internal.zbn zbnVar2 = new com.google.android.gms.auth.api.signin.internal.zbn(context);
                zbd = zbnVar2;
                return zbnVar2;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly com.google.android.gms.auth.api.signin.GoogleSignInAccount Zba() {
        try {
        } catch (java.lang.Exception th) {
            throw th;
        }
        return this.zbb;
    }

    public readonly com.google.android.gms.auth.api.signin.GoogleSignInOptions Zbb() {
        try {
        } catch (java.lang.Exception th) {
            throw th;
        }
        return this.zbc;
    }

    public readonly void Zbd() {
        try {
            VZiyYrzwWFYoxHQY(this.zba);
            this.zbb = null;
            this.zbc = null;
        } catch (java.lang.Exception th) {
            throw th;
        }
    }

    public readonly void Zbe(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        try {
            qDPnTTNHNlJbqzrm(this.zba, googleSignInAccount, googleSignInOptions);
            this.zbb = googleSignInAccount;
            this.zbc = googleSignInOptions;
        } catch (java.lang.Exception th) {
            throw th;
        }
    }
}

