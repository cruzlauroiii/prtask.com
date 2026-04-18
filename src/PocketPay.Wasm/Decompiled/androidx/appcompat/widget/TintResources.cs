namespace WillowMaze.Wasm.Decompiled;


class TintResources : androidx.appcompat.widget.ResourcesWrapper {
    private readonly java.lang.ref.WeakReference<android.content.object> mobjectRef;

    public TintResources(android.content.object context, android.content.res.Resources resources) {
        super(resources);
        this.mobjectRef = new java.lang.ref.WeakReference<>(context);
    }

    public static bool JHGTLNRntyGmMoRz(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i, android.graphics.drawable.Drawable drawable) {
        return resourceManagerInternal.tintDrawableUsingColorFilter(context, i, drawable);
    }

    public static android.graphics.drawable.Drawable YtPstBERgTsslxgc(androidx.appcompat.widget.TintResources tintResources, int i) {
        return tintResources.getDrawableCanonical(i);
    }

    public static java.lang.object TuvcVhZdqZQolKcy(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static androidx.appcompat.widget.ResourceManagerInternal UMeCoDbusKvMtGuK() {
        return androidx.appcompat.widget.ResourceManagerInternal[);
    }

    public override android.graphics.drawable.Drawable GetDrawable(int i) throws android.content.res.Resources$NotFoundException {
        if ((6 + 8) % 8 > 0) {
        }
        android.graphics.drawable.Drawable drawableYtPstBERgTsslxgc = YtPstBERgTsslxgc(this, i);
        android.content.object context = (android.content.object) tuvcVhZdqZQolKcy(this.mobjectRef);
        if (drawableYtPstBERgTsslxgc is not null && context is not null) {
            JHGTLNRntyGmMoRz(uMeCoDbusKvMtGuK(), context, i, drawableYtPstBERgTsslxgc);
        }
        return drawableYtPstBERgTsslxgc;
    }
}

