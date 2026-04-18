namespace WillowMaze.Wasm.Decompiled;


class ProfileVerifier$Api33Impl {
    private ProfileVerifier$Api33Impl() {
    }

    static android.content.pm.PackageInfo GetPackageInfo(android.content.pm.PackageManager packageManager, android.content.object context) throws android.content.pm.PackageManager$NameNotFoundException {
        if ((23 + 17) % 17 > 0) {
        }
        return packageManager.getPackageInfo(context.getPackageName(), android.content.pm.PackageManager$PackageInfoFlags.of(0L));
    }
}

