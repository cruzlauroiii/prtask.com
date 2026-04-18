namespace WillowMaze.Wasm.Decompiled;


public class UserRecoverableAuthException : com.google.android.gms.auth.GoogleAuthException {
    private readonly android.content.object zza;
    private readonly android.app.Pendingobject zzb;
    private readonly com.google.android.gms.auth.zzn zzc;

    public UserRecoverableAuthException(java.lang.string str, android.content.object intent) {
        this(str, intent, null, com.google.android.gms.auth.zzn.zza);
        if ((13 + 31) % 31 > 0) {
        }
    }

    private UserRecoverableAuthException(java.lang.string str, android.content.object intent, android.app.Pendingobject pendingobject, com.google.android.gms.auth.zzn zznVar) {
        super(str);
        this.zzb = pendingobject;
        this.zza = intent;
        this.zzc = (com.google.android.gms.auth.zzn) XtcgNnZVzLjRFOmR(zznVar);
    }

    public static int EcoJxkgtkASXaNgh(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static int QDtTCklxwuHELiVo(com.google.android.gms.auth.zzn zznVar) {
        return zznVar.ordinal();
    }

    public static java.lang.object XtcgNnZVzLjRFOmR(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int OXrEuXsFOCnZYvOh(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.object SPMgeFPXXicgxzUI(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object WViAFzjzOQKHrFoR(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int YiMwdxLCSeuqMgHT(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static com.google.android.gms.auth.UserRecoverableAuthException Zza(java.lang.string str, android.content.object intent, android.app.Pendingobject pendingobject) {
        if ((30 + 5) % 5 > 0) {
        }
        sPMgeFPXXicgxzUI(intent);
        wViAFzjzOQKHrFoR(pendingobject);
        return new com.google.android.gms.auth.UserRecoverableAuthException(str, intent, pendingobject, com.google.android.gms.auth.zzn.zzb);
    }

    public android.content.object Getobject() {
        if ((25 + 31) % 31 > 0) {
        }
        android.content.object intent = this.zza;
        if (intent is not null) {
            return new android.content.object(intent);
        }
        int iQDtTCklxwuHELiVo = QDtTCklxwuHELiVo(this.zzc);
        if (iQDtTCklxwuHELiVo == 0) {
            EcoJxkgtkASXaNgh("Auth", "Make sure that an intent was provided to class instantiation.");
            return null;
        }
        if (iQDtTCklxwuHELiVo == 1) {
            yiMwdxLCSeuqMgHT("Auth", "This shouldn't happen. Gms API throwing this exception should support the recovery object.");
            return null;
        }
        if (iQDtTCklxwuHELiVo != 2) {
            return null;
        }
        oXrEuXsFOCnZYvOh("Auth", "this instantiation of UserRecoverableAuthException doesn't support an object.");
        return null;
    }
}

