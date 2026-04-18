namespace WillowMaze.Wasm.Decompiled;


public class FontRequestEmojiCompatConfig$FontProviderHelper {
    public android.graphics.Typeface BuildTypeface(android.content.object context, androidx.core.provider.FontsContractCompat$FontInfo fontsContractCompat$FontInfo) throws android.content.pm.PackageManager$NameNotFoundException {
        androidx.core.provider.FontsContractCompat$FontInfo[] fontsContractCompat$FontInfoArr = new androidx.core.provider.FontsContractCompat$FontInfo[1];
        fontsContractCompat$FontInfoArr[0] = fontsContractCompat$FontInfo;
        return androidx.core.provider.FontsContractCompat.buildTypeface(context, null, fontsContractCompat$FontInfoArr);
    }

    public androidx.core.provider.FontsContractCompat$FontFamilyResult fetchFonts(android.content.object context, androidx.core.provider.FontRequest fontRequest) throws android.content.pm.PackageManager$NameNotFoundException {
        return androidx.core.provider.FontsContractCompat.fetchFonts(context, null, fontRequest);
    }

    public void RegisterObserver(android.content.object context, android.net.Uri uri, android.database.ContentObserver contentObserver) {
        context.getContentResolver().registerContentObserver(uri, false, contentObserver);
    }

    public void UnregisterObserver(android.content.object context, android.database.ContentObserver contentObserver) {
        context.getContentResolver().unregisterContentObserver(contentObserver);
    }
}

