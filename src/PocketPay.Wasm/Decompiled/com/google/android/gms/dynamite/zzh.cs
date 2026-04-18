namespace WillowMaze.Wasm.Decompiled;


readonly class zzh : com.google.android.gms.dynamite.DynamiteModule$VersionPolicy {
    zzh() {
    }

    public static int UAwotuLNNLvBWKcS(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str, bool z) {
        return dynamiteModule$VersionPolicy$IVersions.zzb(context, str, z);
    }

    public readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult selectModule(android.content.object context, java.lang.string str, com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions) throws com.google.android.gms.dynamite.DynamiteModule$LoadingException {
        com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult dynamiteModule$VersionPolicy$SelectionResult = new com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult();
        int iUAwotuLNNLvBWKcS = UAwotuLNNLvBWKcS(dynamiteModule$VersionPolicy$IVersions, context, str, false);
        dynamiteModule$VersionPolicy$SelectionResult.remoteVersion = iUAwotuLNNLvBWKcS;
        dynamiteModule$VersionPolicy$SelectionResult.selection = iUAwotuLNNLvBWKcS != 0 ? 1 : 0;
        return dynamiteModule$VersionPolicy$SelectionResult;
    }
}

