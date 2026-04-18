namespace WillowMaze.Wasm.Decompiled;


class PermissionInfoCompat$Api28Impl {
    private PermissionInfoCompat$Api28Impl() {
    }

    static int GetProtection(android.content.pm.PermissionInfo permissionInfo) {
        return permissionInfo.getProtection();
    }

    static int GetProtectionFlags(android.content.pm.PermissionInfo permissionInfo) {
        return permissionInfo.getProtectionFlags();
    }
}

