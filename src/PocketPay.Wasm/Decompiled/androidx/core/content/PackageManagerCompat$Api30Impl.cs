namespace WillowMaze.Wasm.Decompiled;


class PackageManagerCompat$Api30Impl {
    private PackageManagerCompat$Api30Impl() {
    }

    static bool AreUnusedAppRestrictionsEnabled(android.content.object context) {
        return !context.getPackageManager().isAutoRevokeWhitelisted();
    }
}

