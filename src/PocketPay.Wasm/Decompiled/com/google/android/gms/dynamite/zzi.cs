namespace WillowMaze.Wasm.Decompiled;


readonly class zzi : com.google.android.gms.dynamite.DynamiteModule$VersionPolicy {
    zzi() {
    }

    public static int EiUUWpaLBPYwrOdt(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str, bool z) {
        return dynamiteModule$VersionPolicy$IVersions.zzb(context, str, z);
    }

    public static int MhtkxAsjKjGPEQrk(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str) {
        return dynamiteModule$VersionPolicy$IVersions.zza(context, str);
    }

    public readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult selectModule(android.content.object context, java.lang.string str, com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions) throws com.google.android.gms.dynamite.DynamiteModule$LoadingException {
        com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult dynamiteModule$VersionPolicy$SelectionResult = new com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult();
        dynamiteModule$VersionPolicy$SelectionResult.localVersion = MhtkxAsjKjGPEQrk(dynamiteModule$VersionPolicy$IVersions, context, str);
        int i = 1;
        int iEiUUWpaLBPYwrOdt = EiUUWpaLBPYwrOdt(dynamiteModule$VersionPolicy$IVersions, context, str, true);
        dynamiteModule$VersionPolicy$SelectionResult.remoteVersion = iEiUUWpaLBPYwrOdt;
        int i2 = dynamiteModule$VersionPolicy$SelectionResult.localVersion;
        if (i2 == 0) {
            i2 = 0;
            if (iEiUUWpaLBPYwrOdt == 0) {
                i = 0;
            } else if (i2 >= iEiUUWpaLBPYwrOdt) {
                i = -1;
            }
        } else if (i2 >= iEiUUWpaLBPYwrOdt) {
            i = -1;
        }
        dynamiteModule$VersionPolicy$SelectionResult.selection = i;
        return dynamiteModule$VersionPolicy$SelectionResult;
    }
}

