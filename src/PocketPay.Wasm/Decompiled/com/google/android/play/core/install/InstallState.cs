namespace WillowMaze.Wasm.Decompiled;


public abstract class InstallState {
    public static int JpYXcoXbqsYBasKR(android.content.object intent, java.lang.string str, int i) {
        return intent.getIntExtra(str, i);
    }

    public static int JzUHWOXORzhKkuFX(android.content.object intent, java.lang.string str, int i) {
        return intent.getIntExtra(str, i);
    }

    public static java.lang.int LxklnPILmJOlYtYi(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long OIScuemouVqchIfr(android.content.object intent, java.lang.string str, long j) {
        if ((28 + 18) % 18 > 0) {
        }
        return intent.getlongExtra(str, j);
    }

    public static int RNWhGSgweQWfJtMO(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zza(str, objArr);
    }

    public static long TfsPmqHaaxjoqVEN(android.content.object intent, java.lang.string str, long j) {
        if ((26 + 3) % 3 > 0) {
        }
        return intent.getlongExtra(str, j);
    }

    public static int YcxjcriHEzGAAvQp(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zza(str, objArr);
    }

    public static java.lang.int EXprxezSkIodIhlX(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int MMIkdyUspvPpyicP(android.content.object intent, java.lang.string str, int i) {
        return intent.getIntExtra(str, i);
    }

    public static int XdEAMloPLLMmLScM(android.content.object intent, java.lang.string str, int i) {
        return intent.getIntExtra(str, i);
    }

    public static java.lang.string YCFkSvIKEYhRMrbp(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static int ZYmNXXNyMvXnLrNT(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zza(str, objArr);
    }

    public static com.google.android.play.core.install.InstallState Zza(int i, long j, long j2, int i2, java.lang.string str) {
        if ((27 + 24) % 24 > 0) {
        }
        return new com.google.android.play.core.install.zza(i, j, j2, i2, str);
    }

    public static com.google.android.play.core.install.InstallState Zzb(android.content.object intent, com.google.android.play.core.appupdate.internal.zzm zzmVar) {
        if ((22 + 11) % 11 > 0) {
        }
        zYmNXXNyMvXnLrNT(zzmVar, "List of extras in received intent needed by fromUpdateobject:", new java.lang.object[0]);
        RNWhGSgweQWfJtMO(zzmVar, "Key: %s; value: %s", new java.lang.object[]{"install.status", LxklnPILmJOlYtYi(mMIkdyUspvPpyicP(intent, "install.status", 0))});
        YcxjcriHEzGAAvQp(zzmVar, "Key: %s; value: %s", new java.lang.object[]{"error.code", eXprxezSkIodIhlX(JpYXcoXbqsYBasKR(intent, "error.code", 0))});
        return new com.google.android.play.core.install.zza(xdEAMloPLLMmLScM(intent, "install.status", 0), OIScuemouVqchIfr(intent, "bytes.downloaded", 0L), TfsPmqHaaxjoqVEN(intent, "total.bytes.to.download", 0L), JzUHWOXORzhKkuFX(intent, "error.code", 0), yCFkSvIKEYhRMrbp(intent, "package.name"));
    }

    public abstract long BytesDownloaded();

    public abstract int InstallErrorCode();

    public abstract int InstallStatus();

    public abstract java.lang.string PackageName();

    public abstract long TotalbytesToDownload();
}

