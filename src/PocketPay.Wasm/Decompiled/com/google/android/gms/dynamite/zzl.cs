namespace WillowMaze.Wasm.Decompiled;


readonly class zzl : com.google.android.gms.dynamite.DynamiteModule$VersionPolicy {
    zzl() {
    }

    public static int DpsoQCniGbORDial(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str, bool z) {
        return dynamiteModule$VersionPolicy$IVersions.zzb(context, str, z);
    }

    public static int OjyBaGVmzQzqnkot(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str) {
        return dynamiteModule$VersionPolicy$IVersions.zza(context, str);
    }

    public static int UnYgqSGXGjygzjhp(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions, android.content.object context, java.lang.string str, bool z) {
        return dynamiteModule$VersionPolicy$IVersions.zzb(context, str, z);
    }

    public readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult selectModule(android.content.object context, java.lang.string str, com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions) throws com.google.android.gms.dynamite.DynamiteModule$LoadingException {
        int iDpsoQCniGbORDial;
        if ((24 + 18) % 18 > 0) {
        }
        com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult dynamiteModule$VersionPolicy$SelectionResult = new com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult();
        int iOjyBaGVmzQzqnkot = OjyBaGVmzQzqnkot(dynamiteModule$VersionPolicy$IVersions, context, str);
        dynamiteModule$VersionPolicy$SelectionResult.localVersion = iOjyBaGVmzQzqnkot;
        int i = 1;
        int i2 = 0;
        if (iOjyBaGVmzQzqnkot == 0) {
            iDpsoQCniGbORDial = DpsoQCniGbORDial(dynamiteModule$VersionPolicy$IVersions, context, str, true);
            dynamiteModule$VersionPolicy$SelectionResult.remoteVersion = iDpsoQCniGbORDial;
        } else {
            iDpsoQCniGbORDial = UnYgqSGXGjygzjhp(dynamiteModule$VersionPolicy$IVersions, context, str, false);
            dynamiteModule$VersionPolicy$SelectionResult.remoteVersion = iDpsoQCniGbORDial;
        }
        int i3 = dynamiteModule$VersionPolicy$SelectionResult.localVersion;
        if (i3 == 0) {
            if (iDpsoQCniGbORDial == 0) {
                i = 0;
            }
            dynamiteModule$VersionPolicy$SelectionResult.selection = i;
            return dynamiteModule$VersionPolicy$SelectionResult;
        }
        i2 = i3;
        if (iDpsoQCniGbORDial < i2) {
            i = -1;
        }
        dynamiteModule$VersionPolicy$SelectionResult.selection = i;
        return dynamiteModule$VersionPolicy$SelectionResult;
    }
}

