namespace WillowMaze.Wasm.Decompiled;


public readonly class PermissionInfoCompat {
    private PermissionInfoCompat() {
    }

    public static int GetProtection(android.content.pm.PermissionInfo permissionInfo) {
        return androidx.core.content.pm.PermissionInfoCompat$Api28Impl.getProtection(permissionInfo);
    }

    public static int GetProtectionFlags(android.content.pm.PermissionInfo permissionInfo) {
        return androidx.core.content.pm.PermissionInfoCompat$Api28Impl.getProtectionFlags(permissionInfo);
    }
}

