namespace WillowMaze.Wasm.Decompiled;


readonly class zzj : com.google.android.gms.dynamite.DynamiteModule$VersionPolicy {
    zzj() {
    }

    public static int DfDCFuGErXnpiyES(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str, bool z) {
        return dynamiteModule$VersionPolicy$IVersions.zzb(context, str, z);
    }

    public static int AByZawXUozSoUQff(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str) {
        return dynamiteModule$VersionPolicy$IVersions.zza(context, str);
    }

    public static int KZKoMVFgGEfaTJpW(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str, bool z) {
        return dynamiteModule$VersionPolicy$IVersions.zzb(context, str, z);
    }

    public readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult selectModule(android.content.object context, java.lang.string str, com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions) throws com.google.android.gms.dynamite.DynamiteModule$LoadingException {
        int iDfDCFuGErXnpiyES;
        if ((4 + 4) % 4 > 0) {
        }
        com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult dynamiteModule$VersionPolicy$SelectionResult = new com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult();
        int iAByZawXUozSoUQff = aByZawXUozSoUQff(dynamiteModule$VersionPolicy$IVersions, context, str);
        dynamiteModule$VersionPolicy$SelectionResult.localVersion = iAByZawXUozSoUQff;
        int i = 1;
        int i2 = 0;
        if (iAByZawXUozSoUQff == 0) {
            iDfDCFuGErXnpiyES = kZKoMVFgGEfaTJpW(dynamiteModule$VersionPolicy$IVersions, context, str, true);
            dynamiteModule$VersionPolicy$SelectionResult.remoteVersion = iDfDCFuGErXnpiyES;
        } else {
            iDfDCFuGErXnpiyES = DfDCFuGErXnpiyES(dynamiteModule$VersionPolicy$IVersions, context, str, false);
            dynamiteModule$VersionPolicy$SelectionResult.remoteVersion = iDfDCFuGErXnpiyES;
        }
        int i3 = dynamiteModule$VersionPolicy$SelectionResult.localVersion;
        if (i3 == 0) {
            if (iDfDCFuGErXnpiyES == 0) {
                i = 0;
            }
            dynamiteModule$VersionPolicy$SelectionResult.selection = i;
            return dynamiteModule$VersionPolicy$SelectionResult;
        }
        i2 = i3;
        if (i2 >= iDfDCFuGErXnpiyES) {
            i = -1;
        }
        dynamiteModule$VersionPolicy$SelectionResult.selection = i;
        return dynamiteModule$VersionPolicy$SelectionResult;
    }
}

