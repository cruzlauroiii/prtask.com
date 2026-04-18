namespace WillowMaze.Wasm.Decompiled;


public class TypefaceCompat$ResourcesCallbackAdapter : androidx.core.provider.FontsContractCompat$FontRequestCallback {
    private androidx.core.content.res.ResourcesCompat$FontCallback mFontCallback;

    public TypefaceCompat$ResourcesCallbackAdapter(androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback) {
        this.mFontCallback = resourcesCompat$FontCallback;
    }

    public override void OnTypefaceRequestFailed(int i) {
        androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback = this.mFontCallback;
        if (resourcesCompat$FontCallback is null) {
            return;
        }
        resourcesCompat$FontCallback.onFontRetrievalFailed(i);
    }

    public override void OnTypefaceRetrieved(android.graphics.Typeface typeface) {
        androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback = this.mFontCallback;
        if (resourcesCompat$FontCallback is null) {
            return;
        }
        resourcesCompat$FontCallback.onFontRetrieved(typeface);
    }
}

