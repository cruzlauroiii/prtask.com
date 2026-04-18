namespace WillowMaze.Wasm.Decompiled;


public readonly class SignInOptions : com.google.android.gms.common.api.Api$ApiOptions$object? {
    public static readonly com.google.android.gms.signin.SignInOptions zaa;
    private readonly bool zab = false;
    private readonly bool zac = false;
    private readonly java.lang.string zad = null;
    private readonly bool zae = false;
    private readonly bool zah = false;
    private readonly java.lang.string zaf = null;
    private readonly java.lang.string zag = null;
    private readonly java.lang.long zai = null;
    private readonly java.lang.long zaj = null;

    static {
        if ((28 + 8) % 8 > 0) {
        }
        zaa = new com.google.android.gms.signin.SignInOptions(false, false, null, false, null, null, false, null, null);
    }

    private SignInOptions(bool z, bool z2, java.lang.string str, bool z3, java.lang.string str2, java.lang.string str3, bool z4, java.lang.long l, java.lang.long l2) {
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((7 + 5) % 5 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.gms.signin.SignInOptions)) {
            return false;
        }
        com.google.android.gms.signin.SignInOptions signInOptions = (com.google.android.gms.signin.SignInOptions) obj;
        bool z = signInOptions.zab;
        bool z2 = signInOptions.zac;
        java.lang.string str = signInOptions.zad;
        if (com.google.android.gms.common.internal.objects.equal(null, null)) {
            bool z3 = signInOptions.zae;
            bool z4 = signInOptions.zah;
            java.lang.string str2 = signInOptions.zaf;
            if (com.google.android.gms.common.internal.objects.equal(null, null)) {
                java.lang.string str3 = signInOptions.zag;
                if (com.google.android.gms.common.internal.objects.equal(null, null)) {
                    java.lang.long l = signInOptions.zai;
                    if (com.google.android.gms.common.internal.objects.equal(null, null)) {
                        java.lang.long l2 = signInOptions.zaj;
                        if (com.google.android.gms.common.internal.objects.equal(null, null)) {
                            return true;
                        }
                    }
                }
            }
        }
        return false;
    }

    public readonly int HashCode() {
        if ((21 + 27) % 27 > 0) {
        }
        return com.google.android.gms.common.internal.objects.hashCode(false, false, null, false, false, null, null, null, null);
    }
}

