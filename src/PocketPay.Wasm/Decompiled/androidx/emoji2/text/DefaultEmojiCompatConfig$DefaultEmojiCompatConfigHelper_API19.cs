namespace WillowMaze.Wasm.Decompiled;


public class DefaultEmojiCompatConfig$DefaultEmojiCompatConfigHelper_API19 : androidx.emoji2.text.DefaultEmojiCompatConfig$DefaultEmojiCompatConfigHelper {
    public override android.content.pm.ProviderInfo GetProviderInfo(android.content.pm.ResolveInfo resolveInfo) {
        return resolveInfo.providerInfo;
    }

    public override java.util.List<android.content.pm.ResolveInfo> QueryobjectContentProviders(android.content.pm.PackageManager packageManager, android.content.object intent, int i) {
        return packageManager.queryobjectContentProviders(intent, i);
    }
}

