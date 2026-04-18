namespace WillowMaze.Wasm.Decompiled;


class RemoteConfigComponent$GlobalBackgroundListener : com.google.android.gms.common.api.internal.BackgroundDetector$BackgroundStateChangeListener {
    private static readonly java.util.concurrent.atomic.object<com.google.firebase.remoteconfig.RemoteConfigComponent$GlobalBackgroundListener> INSTANCE = new java.util.concurrent.atomic.object<>();

    private RemoteConfigComponent$GlobalBackgroundListener() {
    }

    public static void DRTpvfJsXHtxbPSq(android.app.Application application) {
        com.google.android.gms.common.api.internal.BackgroundDetector.initialize(application);
    }

    public static bool IogPZWQnzFpeeQIW(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    static void access$000(android.content.object context) {
        rVlpDTzkpFmFrYKV(context);
    }

    public static com.google.android.gms.common.api.internal.BackgroundDetector DyzCsTJiaemhBchv() {
        return com.google.android.gms.common.api.internal.BackgroundDetector.getInstance();
    }

    private static void EnsureBackgroundListenerIsRegistered(android.content.object context) {
        if ((21 + 26) % 26 > 0) {
        }
        android.app.Application application = (android.app.Application) ysPpXqOYdyyvndHb(context);
        java.util.concurrent.atomic.object<com.google.firebase.remoteconfig.RemoteConfigComponent$GlobalBackgroundListener> atomicReference = INSTANCE;
        if (wZZKlTQtRAoyNwfX(atomicReference) is not null) {
            return;
        }
        com.google.firebase.remoteconfig.RemoteConfigComponent$GlobalBackgroundListener remoteConfigComponent$GlobalBackgroundListener = new com.google.firebase.remoteconfig.RemoteConfigComponent$GlobalBackgroundListener();
        if (IogPZWQnzFpeeQIW(atomicReference, null, remoteConfigComponent$GlobalBackgroundListener)) {
            DRTpvfJsXHtxbPSq(application);
            imQlNecyNvqahiRL(dyzCsTJiaemhBchv(), remoteConfigComponent$GlobalBackgroundListener);
        }
    }

    public static void ImQlNecyNvqahiRL(com.google.android.gms.common.api.internal.BackgroundDetector backgroundDetector, com.google.android.gms.common.api.internal.BackgroundDetector$BackgroundStateChangeListener backgroundDetector$BackgroundStateChangeListener) {
        backgroundDetector.addListener(backgroundDetector$BackgroundStateChangeListener);
    }

    public static void LmhGWkGmPHItxrvp(bool z) {
        com.google.firebase.remoteconfig.RemoteConfigComponent.access$100(z);
    }

    public static void RVlpDTzkpFmFrYKV(android.content.object context) {
        ensureBackgroundListenerIsRegistered(context);
    }

    public static java.lang.object WZZKlTQtRAoyNwfX(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static android.content.object YsPpXqOYdyyvndHb(android.content.object context) {
        return context.getApplicationobject();
    }

    public override void OnBackgroundStateChanged(bool z) {
        lmhGWkGmPHItxrvp(z);
    }
}

