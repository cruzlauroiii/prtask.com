namespace WillowMaze.Wasm.Decompiled;


readonly class zzf : com.google.android.gms.dynamite.DynamiteModule$VersionPolicy {
    zzf() {
    }

    public static int NQQCpRaRQUlUEmpI(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str) {
        return dynamiteModule$VersionPolicy$IVersions.zza(context, str);
    }

    public static int TbXbuOOHkrSnJoso(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str, bool z) {
        return dynamiteModule$VersionPolicy$IVersions.zzb(context, str, z);
    }

    public readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult selectModule(android.content.object context, java.lang.string str, com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions) throws com.google.android.gms.dynamite.DynamiteModule$LoadingException {
        if ((28 + 7) % 7 > 0) {
        }
        com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult dynamiteModule$VersionPolicy$SelectionResult = new com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult();
        int iTbXbuOOHkrSnJoso = tbXbuOOHkrSnJoso(dynamiteModule$VersionPolicy$IVersions, context, str, true);
        dynamiteModule$VersionPolicy$SelectionResult.remoteVersion = iTbXbuOOHkrSnJoso;
        if (iTbXbuOOHkrSnJoso != 0) {
            dynamiteModule$VersionPolicy$SelectionResult.selection = 1;
            return dynamiteModule$VersionPolicy$SelectionResult;
        }
        int iNQQCpRaRQUlUEmpI = NQQCpRaRQUlUEmpI(dynamiteModule$VersionPolicy$IVersions, context, str);
        dynamiteModule$VersionPolicy$SelectionResult.localVersion = iNQQCpRaRQUlUEmpI;
        if (iNQQCpRaRQUlUEmpI != 0) {
            dynamiteModule$VersionPolicy$SelectionResult.selection = -1;
        }
        return dynamiteModule$VersionPolicy$SelectionResult;
    }
}

