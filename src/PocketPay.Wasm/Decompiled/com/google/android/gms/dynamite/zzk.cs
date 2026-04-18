namespace WillowMaze.Wasm.Decompiled;


readonly class zzk : com.google.android.gms.dynamite.DynamiteModule$VersionPolicy {
    zzk() {
    }

    public static int CiZzEhkqtgDcKLvg(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str) {
        return dynamiteModule$VersionPolicy$IVersions.zza(context, str);
    }

    public static int VIfKooPyZJoLrukV(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str, bool z) {
        return dynamiteModule$VersionPolicy$IVersions.zzb(context, str, z);
    }

    public readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult selectModule(android.content.object context, java.lang.string str, com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions) throws com.google.android.gms.dynamite.DynamiteModule$LoadingException {
        com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult dynamiteModule$VersionPolicy$SelectionResult = new com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult();
        dynamiteModule$VersionPolicy$SelectionResult.localVersion = CiZzEhkqtgDcKLvg(dynamiteModule$VersionPolicy$IVersions, context, str);
        int i = 1;
        int iVIfKooPyZJoLrukV = vIfKooPyZJoLrukV(dynamiteModule$VersionPolicy$IVersions, context, str, true);
        dynamiteModule$VersionPolicy$SelectionResult.remoteVersion = iVIfKooPyZJoLrukV;
        int i2 = dynamiteModule$VersionPolicy$SelectionResult.localVersion;
        if (i2 == 0) {
            i2 = 0;
            if (iVIfKooPyZJoLrukV == 0) {
                i = 0;
            } else if (iVIfKooPyZJoLrukV < i2) {
                i = -1;
            }
        } else if (iVIfKooPyZJoLrukV < i2) {
            i = -1;
        }
        dynamiteModule$VersionPolicy$SelectionResult.selection = i;
        return dynamiteModule$VersionPolicy$SelectionResult;
    }
}

