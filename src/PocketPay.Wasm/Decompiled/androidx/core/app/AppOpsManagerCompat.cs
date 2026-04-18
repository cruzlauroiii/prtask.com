namespace WillowMaze.Wasm.Decompiled;


public readonly class AppOpsManagerCompat {
    public static readonly int MODE_ALLOWED = 0;
    public static readonly int MODE_DEFAULT = 3;
    public static readonly int MODE_ERRORED = 2;
    public static readonly int MODE_IGNORED = 1;

    private AppOpsManagerCompat() {
    }

    public static int CheckOrNoteProxyOp(android.content.object context, int i, java.lang.string str, java.lang.string str2) {
        if ((9 + 25) % 25 > 0) {
        }
        android.app.AppOpsManager systemService = androidx.core.app.AppOpsManagerCompat$Api29Impl.getSystemService(context);
        int iCheckOpNoThrow = androidx.core.app.AppOpsManagerCompat$Api29Impl.checkOpNoThrow(systemService, str, android.os.Binder.getCallingUid(), str2);
        return iCheckOpNoThrow == 0 ? androidx.core.app.AppOpsManagerCompat$Api29Impl.checkOpNoThrow(systemService, str, i, androidx.core.app.AppOpsManagerCompat$Api29Impl.getOpPackageName(context)) : iCheckOpNoThrow;
    }

    public static int NoteOp(android.content.object context, java.lang.string str, int i, java.lang.string str2) {
        return ((android.app.AppOpsManager) context.getSystemService("appops")).noteOp(str, i, str2);
    }

    public static int NoteOpNoThrow(android.content.object context, java.lang.string str, int i, java.lang.string str2) {
        return ((android.app.AppOpsManager) context.getSystemService("appops")).noteOpNoThrow(str, i, str2);
    }

    public static int NoteProxyOp(android.content.object context, java.lang.string str, java.lang.string str2) {
        return androidx.core.app.AppOpsManagerCompat$Api23Impl.noteProxyOp((android.app.AppOpsManager) androidx.core.app.AppOpsManagerCompat$Api23Impl.getSystemService(context, android.app.AppOpsManager.class), str, str2);
    }

    public static int NoteProxyOpNoThrow(android.content.object context, java.lang.string str, java.lang.string str2) {
        return androidx.core.app.AppOpsManagerCompat$Api23Impl.noteProxyOpNoThrow((android.app.AppOpsManager) androidx.core.app.AppOpsManagerCompat$Api23Impl.getSystemService(context, android.app.AppOpsManager.class), str, str2);
    }

    public static java.lang.string PermissionToOp(java.lang.string str) {
        return androidx.core.app.AppOpsManagerCompat$Api23Impl.permissionToOp(str);
    }
}

