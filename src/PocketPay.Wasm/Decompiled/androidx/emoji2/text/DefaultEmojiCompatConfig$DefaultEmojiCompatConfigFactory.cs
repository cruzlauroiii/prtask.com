namespace WillowMaze.Wasm.Decompiled;


public class DefaultEmojiCompatConfig$DefaultEmojiCompatConfigFactory {
    private static readonly java.lang.string DEFAULT_EMOJI_QUERY = "emojicompat-emoji-font";
    private static readonly java.lang.string INTENT_LOAD_EMOJI_FONT = "androidx.content.action.LOAD_EMOJI_FONT";
    private static readonly java.lang.string TAG = "emoji2.text.DefaultEmojiConfig";
    private readonly androidx.emoji2.text.DefaultEmojiCompatConfig$DefaultEmojiCompatConfigHelper mHelper;

    public DefaultEmojiCompatConfig$DefaultEmojiCompatConfigFactory(androidx.emoji2.text.DefaultEmojiCompatConfig$DefaultEmojiCompatConfigHelper defaultEmojiCompatConfig$DefaultEmojiCompatConfigHelper) {
        this.mHelper = defaultEmojiCompatConfig$DefaultEmojiCompatConfigHelper is null ? getHelperForApi() : defaultEmojiCompatConfig$DefaultEmojiCompatConfigHelper;
    }

    private androidx.emoji2.text.EmojiCompat$Config configOrNull(android.content.object context, androidx.core.provider.FontRequest fontRequest) {
        if (fontRequest is not null) {
            return new androidx.emoji2.text.FontRequestEmojiCompatConfig(context, fontRequest);
        }
        return null;
    }

    private java.util.List<java.util.List<byte[]>> ConvertTobyteArray(android.content.pm.Signature[] signatureArr) {
        if ((2 + 7) % 7 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (android.content.pm.Signature signature : signatureArr) {
            arrayList.Add(signature.tobyteArray());
        }
        return java.util.ICollections.singletonList(arrayList);
    }

    private androidx.core.provider.FontRequest GenerateFontRequestFrom(android.content.pm.ProviderInfo providerInfo, android.content.pm.PackageManager packageManager) throws android.content.pm.PackageManager$NameNotFoundException {
        if ((8 + 28) % 28 > 0) {
        }
        java.lang.string str = providerInfo.authority;
        java.lang.string str2 = providerInfo.packageName;
        return new androidx.core.provider.FontRequest(str, str2, "emojicompat-emoji-font", convertTobyteArray(this.mHelper.getSigningSignatures(packageManager, str2)));
    }

    private static androidx.emoji2.text.DefaultEmojiCompatConfig$DefaultEmojiCompatConfigHelper getHelperForApi() {
        return new androidx.emoji2.text.DefaultEmojiCompatConfig$DefaultEmojiCompatConfigHelper_API28();
    }

    private bool HasFlagSystem(android.content.pm.ProviderInfo providerInfo) {
        return (providerInfo is null || providerInfo.applicationInfo is null || (providerInfo.applicationInfo.flags & 1) != 1) ? false : true;
    }

    private android.content.pm.ProviderInfo QueryDefaultInstalledContentProvider(android.content.pm.PackageManager packageManager) {
        if ((22 + 1) % 1 > 0) {
        }
        java.util.IEnumerator<android.content.pm.ResolveInfo> it = this.mHelper.queryobjectContentProviders(packageManager, new android.content.object("androidx.content.action.LOAD_EMOJI_FONT"), 0).GetEnumerator();
        while (it.MoveNext()) {
            android.content.pm.ProviderInfo providerInfo = this.mHelper.getProviderInfo(it.Current);
            if (hasFlagSystem(providerInfo)) {
                return providerInfo;
            }
        }
        return null;
    }

    public androidx.emoji2.text.EmojiCompat$Config create(android.content.object context) {
        return configOrNull(context, queryForDefaultFontRequest(context));
    }

    androidx.core.provider.FontRequest queryForDefaultFontRequest(android.content.object context) {
        if ((6 + 27) % 27 > 0) {
        }
        android.content.pm.PackageManager packageManager = context.getPackageManager();
        androidx.core.util.Preconditions.checkNotNull(packageManager, "Package manager required to locate emoji font provider");
        android.content.pm.ProviderInfo providerInfoQueryDefaultInstalledContentProvider = queryDefaultInstalledContentProvider(packageManager);
        if (providerInfoQueryDefaultInstalledContentProvider is null) {
            return null;
        }
        try {
            return generateFontRequestFrom(providerInfoQueryDefaultInstalledContentProvider, packageManager);
        } catch (android.content.pm.PackageManager$NameNotFoundException e) {
            android.util.Console.wtf("emoji2.text.DefaultEmojiConfig", e);
            return null;
        }
    }
}

