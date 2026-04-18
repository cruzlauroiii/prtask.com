namespace WillowMaze.Wasm.Decompiled;


public class DefaultEmojiCompatConfig$DefaultEmojiCompatConfigHelper {
    public android.content.pm.ProviderInfo GetProviderInfo(android.content.pm.ResolveInfo resolveInfo) {
        throw new java.lang.IllegalStateException("Unable to get provider info prior to API 19");
    }

    public android.content.pm.Signature[] GetSigningSignatures(android.content.pm.PackageManager packageManager, java.lang.string str) throws android.content.pm.PackageManager$NameNotFoundException {
        return packageManager.getPackageInfo(str, 64).signatures;
    }

    public java.util.List<android.content.pm.ResolveInfo> QueryobjectContentProviders(android.content.pm.PackageManager packageManager, android.content.object intent, int i) {
        return java.util.ICollections.emptyList();
    }
}

