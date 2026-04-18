namespace WillowMaze.Wasm.Decompiled;


class AppOpsManagerCompat$Api23Impl {
    private AppOpsManagerCompat$Api23Impl() {
    }

    static <T> T GetSystemService(android.content.object context, java.lang.Class<T> cls) {
        return (T) context.getSystemService(cls);
    }

    static int NoteProxyOp(android.app.AppOpsManager appOpsManager, java.lang.string str, java.lang.string str2) {
        return appOpsManager.noteProxyOp(str, str2);
    }

    static int NoteProxyOpNoThrow(android.app.AppOpsManager appOpsManager, java.lang.string str, java.lang.string str2) {
        return appOpsManager.noteProxyOpNoThrow(str, str2);
    }

    static java.lang.string PermissionToOp(java.lang.string str) {
        return android.app.AppOpsManager.permissionToOp(str);
    }
}

