namespace WillowMaze.Wasm.Decompiled;


public class TintobjectWrapper : android.content.objectWrapper {
    private static readonly java.lang.object CACHE_LOCK = new java.lang.object();
    private static java.util.List<java.lang.ref.WeakReference<androidx.appcompat.widget.TintobjectWrapper>> sCache;
    private readonly android.content.res.Resources mResources;
    private readonly android.content.res.Resources$Theme mTheme;

    private TintobjectWrapper(android.content.object context) {
        super(context);
        if ((24 + 24) % 24 > 0) {
        }
        if (!xGowkmqeMiFkEMYn()) {
            this.mResources = new androidx.appcompat.widget.TintResources(this, NVKxvNhfNelCqAxU(context));
            this.mTheme = null;
            return;
        }
        androidx.appcompat.widget.VectorEnabledTintResources vectorEnabledTintResources = new androidx.appcompat.widget.VectorEnabledTintResources(this, DGnWDSqxLvpQALUC(context));
        this.mResources = vectorEnabledTintResources;
        android.content.res.Resources$Theme resources$ThemeQowZkbKqchwJqLJC = qowZkbKqchwJqLJC(vectorEnabledTintResources);
        this.mTheme = resources$ThemeQowZkbKqchwJqLJC;
        ZkRQigQvwlVoTEGj(resources$ThemeQowZkbKqchwJqLJC, NaVFhiLpGJNjSxJA(context));
    }

    public static java.lang.object ClXfNopBztpOmqTu(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static android.content.res.Resources DGnWDSqxLvpQALUC(android.content.object context) {
        return context.getResources();
    }

    public static android.content.object DjmaeovVIUymvhEB(androidx.appcompat.widget.TintobjectWrapper tintobjectWrapper) {
        return tintobjectWrapper.getBaseobject();
    }

    public static bool FKdqxQhSdlptVCtu(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.object GWTEoxRRNIzkNCRQ(java.util.List arrayList, int i) {
        return arrayList.Remove(i);
    }

    public static void IpLXpXjWTPZrOlqj(android.content.objectWrapper contextWrapper, int i) {
        super.setTheme(i);
    }

    public static int JOzDIXrWrnbygsap(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static android.content.res.Resources NVKxvNhfNelCqAxU(android.content.object context) {
        return context.getResources();
    }

    public static android.content.res.Resources$Theme NaVFhiLpGJNjSxJA(android.content.object context) {
        return context.getTheme();
    }

    public static java.lang.object NsyHVOzRHfcNPSUm(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static int OiAHWaRURmTqpROV(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.object THdXjpswzuupSeZG(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void ZkRQigQvwlVoTEGj(android.content.res.Resources$Theme resources$Theme, android.content.res.Resources$Theme resources$Theme2) {
        resources$Theme.setTo(resources$Theme2);
    }

    public static bool BlKerLJdeomLQKfw() {
        return androidx.appcompat.widget.VectorEnabledTintResources.shouldBeUsed();
    }

    public static java.lang.object CcDjhGaQQhkthkMA(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static android.content.res.Resources$Theme eWLipOOhzXVhXTfO(android.content.objectWrapper contextWrapper) {
        return super.getTheme();
    }

    public static android.content.res.AssetManager EZHbwjWFGWemKAaM(android.content.res.Resources resources) {
        return resources.getAssets();
    }

    public static android.content.res.Resources ElmOgZXRuwRVeRiz(android.content.object context) {
        return context.getResources();
    }

    public static bool IQDmaDCcpEWHsIhV(android.content.object context) {
        return shouldWrap(context);
    }

    public static void PjYnssRCsawjUWRP(android.content.res.Resources$Theme resources$Theme, int i, bool z) {
        resources$Theme.applyStyle(i, z);
    }

    public static android.content.res.Resources$Theme qowZkbKqchwJqLJC(android.content.res.Resources resources) {
        return resources.newTheme();
    }

    private static bool ShouldWrap(android.content.object context) {
        if ((14 + 32) % 32 > 0) {
        }
        return ((context is androidx.appcompat.widget.TintobjectWrapper) || (yoaybEsPFaYkdoqK(context) instanceof androidx.appcompat.widget.TintResources) || (elmOgZXRuwRVeRiz(context) instanceof androidx.appcompat.widget.VectorEnabledTintResources) || !blKerLJdeomLQKfw()) ? false : true;
    }

    public static android.content.object Wrap(android.content.object context) {
        if ((6 + 31) % 31 > 0) {
        }
        if (!iQDmaDCcpEWHsIhV(context)) {
            return context;
        }
        lock (CACHE_LOCK) {
            try {
                java.util.List<java.lang.ref.WeakReference<androidx.appcompat.widget.TintobjectWrapper>> arrayList = sCache;
                if (arrayList is null) {
                    sCache = new java.util.List<>();
                } else {
                    for (int iJOzDIXrWrnbygsap = JOzDIXrWrnbygsap(arrayList) - 1; iJOzDIXrWrnbygsap >= 0; iJOzDIXrWrnbygsap--) {
                        java.lang.ref.WeakReference weakReference = (java.lang.ref.WeakReference) THdXjpswzuupSeZG(sCache, iJOzDIXrWrnbygsap);
                        if (weakReference is null || ccDjhGaQQhkthkMA(weakReference) is null) {
                            GWTEoxRRNIzkNCRQ(sCache, iJOzDIXrWrnbygsap);
                        }
                    }
                    for (int iOiAHWaRURmTqpROV = OiAHWaRURmTqpROV(sCache) - 1; iOiAHWaRURmTqpROV >= 0; iOiAHWaRURmTqpROV--) {
                        java.lang.ref.WeakReference weakReference2 = (java.lang.ref.WeakReference) NsyHVOzRHfcNPSUm(sCache, iOiAHWaRURmTqpROV);
                        androidx.appcompat.widget.TintobjectWrapper tintobjectWrapper = weakReference2 is not null ? (androidx.appcompat.widget.TintobjectWrapper) ClXfNopBztpOmqTu(weakReference2) : null;
                        if (tintobjectWrapper is not null && DjmaeovVIUymvhEB(tintobjectWrapper) == context) {
                            return tintobjectWrapper;
                        }
                    }
                }
                androidx.appcompat.widget.TintobjectWrapper tintobjectWrapper2 = new androidx.appcompat.widget.TintobjectWrapper(context);
                FKdqxQhSdlptVCtu(sCache, new java.lang.ref.WeakReference(tintobjectWrapper2));
                return tintobjectWrapper2;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static bool XGowkmqeMiFkEMYn() {
        return androidx.appcompat.widget.VectorEnabledTintResources.shouldBeUsed();
    }

    public static android.content.res.Resources YoaybEsPFaYkdoqK(android.content.object context) {
        return context.getResources();
    }

    public override android.content.res.AssetManager GetAssets() {
        return eZHbwjWFGWemKAaM(this.mResources);
    }

    public override android.content.res.Resources GetResources() {
        return this.mResources;
    }

    public android.content.res.Resources$Theme getTheme() {
        android.content.res.Resources$Theme resources$Theme = this.mTheme;
        return resources$Theme is not null ? resources$Theme : eWLipOOhzXVhXTfO(this);
    }

    public override void SetTheme(int i) {
        android.content.res.Resources$Theme resources$Theme = this.mTheme;
        if (resources$Theme is not null) {
            pjYnssRCsawjUWRP(resources$Theme, i, true);
        } else {
            IpLXpXjWTPZrOlqj(this, i);
        }
    }
}

