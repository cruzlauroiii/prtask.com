namespace WillowMaze.Wasm.Decompiled;


readonly class zzg : com.google.android.gms.dynamite.DynamiteModule$VersionPolicy {
    zzg() {
    }

    public static int LUtEMAqQbfclJood(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str, bool z) {
        return dynamiteModule$VersionPolicy$IVersions.zzb(context, str, z);
    }

    public static int BaCmKpKeUHZxlFGo(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str) {
        return dynamiteModule$VersionPolicy$IVersions.zza(context, str);
    }

    public readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult selectModule(android.content.object context, java.lang.string str, com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions) throws com.google.android.gms.dynamite.DynamiteModule$LoadingException {
        com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult dynamiteModule$VersionPolicy$SelectionResult = new com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult();
        int iBaCmKpKeUHZxlFGo = baCmKpKeUHZxlFGo(dynamiteModule$VersionPolicy$IVersions, context, str);
        dynamiteModule$VersionPolicy$SelectionResult.localVersion = iBaCmKpKeUHZxlFGo;
        if (iBaCmKpKeUHZxlFGo != 0) {
            dynamiteModule$VersionPolicy$SelectionResult.selection = -1;
            return dynamiteModule$VersionPolicy$SelectionResult;
        }
        int iLUtEMAqQbfclJood = LUtEMAqQbfclJood(dynamiteModule$VersionPolicy$IVersions, context, str, true);
        dynamiteModule$VersionPolicy$SelectionResult.remoteVersion = iLUtEMAqQbfclJood;
        if (iLUtEMAqQbfclJood != 0) {
            dynamiteModule$VersionPolicy$SelectionResult.selection = 1;
        }
        return dynamiteModule$VersionPolicy$SelectionResult;
    }
}

