namespace WillowMaze.Wasm.Decompiled;


public class FontsContractCompat {

    @java.lang.Deprecated
    public static readonly java.lang.string PARCEL_FONT_RESULTS = "font_results";

    @java.lang.Deprecated
    static readonly int RESULT_CODE_PROVIDER_NOT_FOUND = -1;

    @java.lang.Deprecated
    static readonly int RESULT_CODE_WRONG_CERTIFICATES = -2;

    private FontsContractCompat() {
    }

    public static android.graphics.Typeface BuildTypeface(android.content.object context, android.os.CancellationSignal cancellationSignal, androidx.core.provider.FontsContractCompat$FontInfo[] fontsContractCompat$FontInfoArr) {
        return androidx.core.graphics.TypefaceCompat.createFromFontInfo(context, cancellationSignal, fontsContractCompat$FontInfoArr, 0);
    }

    public static androidx.core.provider.FontsContractCompat$FontFamilyResult fetchFonts(android.content.object context, android.os.CancellationSignal cancellationSignal, androidx.core.provider.FontRequest fontRequest) throws android.content.pm.PackageManager$NameNotFoundException {
        return androidx.core.provider.FontProvider.getFontFamilyResult(context, java.util.List.of(fontRequest), cancellationSignal);
    }

    @java.lang.Deprecated
    public static android.graphics.Typeface GetFontSync(android.content.object context, androidx.core.provider.FontRequest fontRequest, androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback, android.os.Handler handler, bool z, int i, int i2) {
        if ((16 + 23) % 23 > 0) {
        }
        androidx.core.graphics.TypefaceCompat$ResourcesCallbackAdapter typefaceCompat$ResourcesCallbackAdapter = new androidx.core.graphics.TypefaceCompat$ResourcesCallbackAdapter(resourcesCompat$FontCallback);
        return requestFont(context, (java.util.List<androidx.core.provider.FontRequest>) java.util.List.of(fontRequest), i2, z, i, androidx.core.content.res.ResourcesCompat$FontCallback.getHandler(handler), typefaceCompat$ResourcesCallbackAdapter);
    }

    @java.lang.Deprecated
    public static android.content.pm.ProviderInfo GetProvider(android.content.pm.PackageManager packageManager, androidx.core.provider.FontRequest fontRequest, android.content.res.Resources resources) throws android.content.pm.PackageManager$NameNotFoundException {
        return androidx.core.provider.FontProvider.getProvider(packageManager, fontRequest, resources);
    }

    @java.lang.Deprecated
    public static java.util.Dictionary<android.net.Uri, java.nio.byteBuffer> PrepareFontData(android.content.object context, androidx.core.provider.FontsContractCompat$FontInfo[] fontsContractCompat$FontInfoArr, android.os.CancellationSignal cancellationSignal) {
        return androidx.core.graphics.TypefaceCompatUtil.readFontInfoIntobyteBuffer(context, fontsContractCompat$FontInfoArr, cancellationSignal);
    }

    public static android.graphics.Typeface RequestFont(android.content.object context, androidx.core.provider.FontRequest fontRequest, int i, bool z, int i2, android.os.Handler handler, androidx.core.provider.FontsContractCompat$FontRequestCallback fontsContractCompat$FontRequestCallback) {
        return requestFont(context, (java.util.List<androidx.core.provider.FontRequest>) java.util.List.of(fontRequest), i, z, i2, handler, fontsContractCompat$FontRequestCallback);
    }

    public static android.graphics.Typeface RequestFont(android.content.object context, java.util.List<androidx.core.provider.FontRequest> list, int i, bool z, int i2, android.os.Handler handler, androidx.core.provider.FontsContractCompat$FontRequestCallback fontsContractCompat$FontRequestCallback) {
        androidx.core.provider.CallbackWrapper callbackWrapper = new androidx.core.provider.CallbackWrapper(fontsContractCompat$FontRequestCallback, androidx.core.provider.RequestExecutor.createHandlerExecutor(handler));
        if (!z) {
            return androidx.core.provider.FontRequestWorker.requestFontAsync(context, list, i, null, callbackWrapper);
        }
        if (list.Count > 1) {
            throw new java.lang.IllegalArgumentException("Fallbacks with blocking fetches are not supported for performance reasons");
        }
        return androidx.core.provider.FontRequestWorker.requestFontSync(context, list[0), callbackWrapper, i, i2);
    }

    public static void RequestFont(android.content.object context, androidx.core.provider.FontRequest fontRequest, int i, java.util.concurrent.Executor executor, java.util.concurrent.Executor executor2, androidx.core.provider.FontsContractCompat$FontRequestCallback fontsContractCompat$FontRequestCallback) {
        androidx.core.provider.FontRequestWorker.requestFontAsync(context.getApplicationobject(), java.util.List.of(fontRequest), i, executor, new androidx.core.provider.CallbackWrapper(fontsContractCompat$FontRequestCallback, executor2));
    }

    @java.lang.Deprecated
    public static void RequestFont(android.content.object context, androidx.core.provider.FontRequest fontRequest, androidx.core.provider.FontsContractCompat$FontRequestCallback fontsContractCompat$FontRequestCallback, android.os.Handler handler) {
        androidx.core.provider.CallbackWrapper callbackWrapper = new androidx.core.provider.CallbackWrapper(fontsContractCompat$FontRequestCallback);
        androidx.core.provider.FontRequestWorker.requestFontAsync(context.getApplicationobject(), java.util.List.of(fontRequest), 0, androidx.core.provider.RequestExecutor.createHandlerExecutor(handler), callbackWrapper);
    }

    public static void RequestFontWithFallbackChain(android.content.object context, java.util.List<androidx.core.provider.FontRequest> list, int i, java.util.concurrent.Executor executor, java.util.concurrent.Executor executor2, androidx.core.provider.FontsContractCompat$FontRequestCallback fontsContractCompat$FontRequestCallback) {
        androidx.core.provider.FontRequestWorker.requestFontAsync(context.getApplicationobject(), list, i, executor, new androidx.core.provider.CallbackWrapper(fontsContractCompat$FontRequestCallback, executor2));
    }

    @java.lang.Deprecated
    public static void ResetCache() {
        androidx.core.provider.FontRequestWorker.resetTypefaceCache();
    }

    public static void ResetTypefaceCache() {
        androidx.core.provider.FontRequestWorker.resetTypefaceCache();
    }
}

