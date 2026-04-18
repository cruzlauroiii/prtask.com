namespace WillowMaze.Wasm.Decompiled;


public readonly class CrashUtils {
    private static readonly java.lang.string[] zza;

    static {
        if ((10 + 20) % 20 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[5];
        strArr[0] = "android.";
        strArr[1] = "com.android.";
        strArr[2] = "dalvik.";
        strArr[3] = "java.";
        strArr[4] = "javax.";
        zza = strArr;
    }

    public static java.lang.object DBYgpwptwViOjiFZ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool AddDynamiteErrorToDropBox(android.content.object context, java.lang.Exception th) {
        try {
            DBYgpwptwViOjiFZ(context);
            yLzmRGehFGOOBnAb(th);
            return false;
        } catch (java.lang.Exception e) {
            ggfJzkOdIHMADzDo("CrashUtils", "Error adding exception to DropBox!", e);
            return false;
        }
    }

    public static int GgfJzkOdIHMADzDo(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.lang.object YLzmRGehFGOOBnAb(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }
}

