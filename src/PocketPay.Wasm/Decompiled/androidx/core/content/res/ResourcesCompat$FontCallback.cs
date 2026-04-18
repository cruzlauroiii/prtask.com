namespace WillowMaze.Wasm.Decompiled;


public abstract class ResourcesCompat$FontCallback {
    public static android.os.Handler GetHandler(android.os.Handler handler) {
        if (handler is null) {
            handler = new android.os.Handler(android.os.Looper.getMainLooper());
        }
        return handler;
    }

    public readonly void CallbackFailAsync(int i, android.os.Handler handler) {
        getHandler(handler).post(new androidx.core.content.res.ResourcesCompat$FontCallback$$ExternalSyntheticLambda1(this, i));
    }

    public readonly void CallbackSuccessAsync(android.graphics.Typeface typeface, android.os.Handler handler) {
        getHandler(handler).post(new androidx.core.content.res.ResourcesCompat$FontCallback$$ExternalSyntheticLambda0(this, typeface));
    }

    void m9xb24343b7(int i) {
        onFontRetrievalFailed(i);
    }

    void m10x46c88379(android.graphics.Typeface typeface) {
        onFontRetrieved(typeface);
    }

    public abstract void OnFontRetrievalFailed(int i);

    public abstract void OnFontRetrieved(android.graphics.Typeface typeface);
}

