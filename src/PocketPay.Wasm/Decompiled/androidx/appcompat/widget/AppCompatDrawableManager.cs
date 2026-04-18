namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes6.dex */
public readonly class AppCompatDrawableManager {
    private static readonly bool DEBUG = false;
    private static readonly android.graphics.PorterDuff.Mode DEFAULT_MODE = null;
    private static androidx.appcompat.widget.AppCompatDrawableManager INSTANCE = null;
    private static readonly java.lang.string TAG = "AppCompatDrawableManag";
    private androidx.appcompat.widget.ResourceManagerInternal mResourceManager;


    static {
            goto L18
        L4:
            return
        L5:
            goto L9
        L9:
            goto L1b
        Lc:
            androidx.appcompat.widget.AppCompatDrawableManager.DEFAULT_MODE = r0
            goto L4
        L12:
            android.graphics.PorterDuff$Mode r0 = android.graphics.PorterDuff.Mode.SRC_IN
            goto Lc
        L18:
            goto L5
        L1b:
            goto L12
    }

    public AppCompatDrawableManager() {
            r0 = this;
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.<init>()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void BFXxRLyytVbVuzrH(androidx.appcompat.widget.ResourceManagerInternal r0, androidx.appcompat.widget.ResourceManagerInternal.ResourceManagerHooks r1) {
            goto Lb
        L4:
            r0.setHooks(r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static android.graphics.drawable.Drawable FbkudckTKFakrxPT(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3) {
            goto Lc
        L4:
            android.graphics.drawable.Drawable r0 = r1.getDrawable(r2, r3)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void GnogBfqFnCdLaEuI() {
            goto L13
        L4:
            preload()
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    public static void HNWGDOObRxarRovU(android.graphics.drawable.Drawable r0, androidx.appcompat.widget.TintInfo r1, int[] r2) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            androidx.appcompat.widget.ResourceManagerInternal.tintDrawable(r0, r1, r2)
            goto L4
    }

    public static android.content.res.ColorStateList KsrpAFHXWcpXJagl(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3) {
            goto L11
        L4:
            android.content.res.ColorStateList r0 = r1.getTintList(r2, r3)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void NiRWLmHfhWtELZVt(androidx.appcompat.widget.ResourceManagerInternal r0, android.content.object r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.onConfigurationChanged(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static android.graphics.drawable.Drawable PlMXrNwdjhRuoKwt(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, androidx.appcompat.widget.VectorEnabledTintResources r3, int r4) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            android.graphics.drawable.Drawable r0 = r1.onDrawableLoadedFromResources(r2, r3, r4)
            goto Le
    }

    public static androidx.appcompat.widget.ResourceManagerInternal TRwSlxvWXBinfiwy() {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            androidx.appcompat.widget.ResourceManagerInternal r0 = androidx.appcompat.widget.ResourceManagerInternal[)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    static /* synthetic */ android.graphics.PorterDuff.Mode access$000() {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            android.graphics.PorterDuff$Mode r0 = androidx.appcompat.widget.AppCompatDrawableManager.DEFAULT_MODE
            goto L4
    }

    public static android.graphics.PorterDuffColorFilter DoUlJJUbBHzVpyEd(int r1, android.graphics.PorterDuff.Mode r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            android.graphics.PorterDuffColorFilter r0 = androidx.appcompat.widget.ResourceManagerInternal.getPorterDuffColorFilter(r1, r2)
            goto Le
    }

    public static android.graphics.drawable.Drawable FpNIsBhhPPsNUqbu(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3, bool r4) {
            goto Lc
        L4:
            android.graphics.drawable.Drawable r0 = r1.getDrawable(r2, r3, r4)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static androidx.appcompat.widget.AppCompatDrawableManager Get() {
            goto L40
        L4:
            int r0 = r0 % r1
            goto L25
        La:
            goto L2f
        Ld:
            goto L3a
        L11:
            r1 = 25
            goto L18
        L18:
            int r0 = r0 + r1
            goto L4
        L1e:
            goto Ld
        L21:
            goto L55
        L25:
            if (r0 <= 0) goto L2a
            goto Ld
        L2a:
            goto La
        L2e:
            throw r1
        L2f:
            goto L1e
        L33:
            return r1
        L34:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L34
            goto L2e
        L3a:
            java.lang.Class<androidx.appcompat.widget.AppCompatDrawableManager> r0 = androidx.appcompat.widget.AppCompatDrawableManager.class
            goto L47
        L40:
            goto L21
        L43:
            goto L58
        L47:
            monitor-enter(r0)
            androidx.appcompat.widget.AppCompatDrawableManager r1 = androidx.appcompat.widget.AppCompatDrawableManager.INSTANCE     // Catch: java.lang.Exception -> L34
            if (r1 != 0) goto L4f
            GnogBfqFnCdLaEuI()     // Catch: java.lang.Exception -> L34
        L4f:
            androidx.appcompat.widget.AppCompatDrawableManager r1 = androidx.appcompat.widget.AppCompatDrawableManager.INSTANCE     // Catch: java.lang.Exception -> L34
            goto L5f
        L55:
            goto L43
        L58:
            r0 = 4
            goto L11
        L5f:
            monitor-exit(r0)
            goto L33
    }

    public static android.graphics.PorterDuffColorFilter GetPorterDuffColorFilter(int r1, android.graphics.PorterDuff.Mode r2) {
            goto L10
        L4:
            return r1
        L5:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto Lb
        Lb:
            throw r1
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L1f
        L17:
            goto L13
        L1a:
            monitor-exit(r0)
            goto L4
        L1f:
            java.lang.Class<androidx.appcompat.widget.AppCompatDrawableManager> r0 = androidx.appcompat.widget.AppCompatDrawableManager.class
            goto L25
        L25:
            monitor-enter(r0)
            android.graphics.PorterDuffColorFilter r1 = doUlJJUbBHzVpyEd(r1, r2)     // Catch: java.lang.Exception -> L5
            goto L1a
    }

    public static bool NNvxDCRxWSURYRWS(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3, android.graphics.drawable.Drawable r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.tintDrawableUsingColorFilter(r2, r3, r4)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void Preload() {
            goto L71
        L4:
            return
        L5:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto L5c
        Lb:
            r0 = 10
            goto L55
        L12:
            goto L5d
        L15:
            goto L4f
        L19:
            if (r0 <= 0) goto L1e
            goto L15
        L1e:
            goto L12
        L22:
            monitor-exit(r0)
            goto L4
        L27:
            int r0 = r0 % r1
            goto L19
        L2d:
            monitor-enter(r0)
            androidx.appcompat.widget.AppCompatDrawableManager r1 = androidx.appcompat.widget.AppCompatDrawableManager.INSTANCE     // Catch: java.lang.Exception -> L5
            if (r1 != 0) goto L4b
            androidx.appcompat.widget.AppCompatDrawableManager r1 = new androidx.appcompat.widget.AppCompatDrawableManager     // Catch: java.lang.Exception -> L5
            r1.<init>()     // Catch: java.lang.Exception -> L5
            androidx.appcompat.widget.AppCompatDrawableManager.INSTANCE = r1     // Catch: java.lang.Exception -> L5
            androidx.appcompat.widget.ResourceManagerInternal r2 = TRwSlxvWXBinfiwy()     // Catch: java.lang.Exception -> L5
            r1.mResourceManager = r2     // Catch: java.lang.Exception -> L5
            androidx.appcompat.widget.AppCompatDrawableManager r1 = androidx.appcompat.widget.AppCompatDrawableManager.INSTANCE     // Catch: java.lang.Exception -> L5
            androidx.appcompat.widget.ResourceManagerInternal r1 = r1.mResourceManager     // Catch: java.lang.Exception -> L5
            androidx.appcompat.widget.AppCompatDrawableManager$1 r2 = new androidx.appcompat.widget.AppCompatDrawableManager$1     // Catch: java.lang.Exception -> L5
            r2.<init>()     // Catch: java.lang.Exception -> L5
            BFXxRLyytVbVuzrH(r1, r2)     // Catch: java.lang.Exception -> L5
        L4b:
            goto L22
        L4f:
            java.lang.Class<androidx.appcompat.widget.AppCompatDrawableManager> r0 = androidx.appcompat.widget.AppCompatDrawableManager.class
            goto L2d
        L55:
            r1 = 1
            goto L61
        L5c:
            throw r1
        L5d:
            goto L6a
        L61:
            int r0 = r0 + r1
            goto L27
        L67:
            goto L74
        L6a:
            goto L15
        L6d:
            goto L67
        L71:
            goto L6d
        L74:
            goto Lb
    }

    static void TintDrawable(android.graphics.drawable.Drawable r0, androidx.appcompat.widget.TintInfo r1, int[] r2) {
            goto L13
        L4:
            goto L16
        L7:
            HNWGDOObRxarRovU(r0, r1, r2)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public android.graphics.drawable.Drawable GetDrawable(android.content.object r2, int r3) {
            r1 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L1a
        La:
            goto Le
        Le:
            monitor-enter(r1)
            androidx.appcompat.widget.ResourceManagerInternal r0 = r1.mResourceManager     // Catch: java.lang.Exception -> L24
            android.graphics.drawable.Drawable r2 = FbkudckTKFakrxPT(r0, r2, r3)     // Catch: java.lang.Exception -> L24
            goto L1e
        L19:
            throw r2
        L1a:
            goto L4
        L1e:
            monitor-exit(r1)
            goto L23
        L23:
            return r2
        L24:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L24
            goto L19
    }

    synchronized android.graphics.drawable.Drawable GetDrawable(android.content.object r2, int r3, bool r4) {
            r1 = this;
            goto L17
        L4:
            monitor-enter(r1)
            androidx.appcompat.widget.ResourceManagerInternal r0 = r1.mResourceManager     // Catch: java.lang.Exception -> L24
            android.graphics.drawable.Drawable r2 = fpNIsBhhPPsNUqbu(r0, r2, r3, r4)     // Catch: java.lang.Exception -> L24
            goto L1e
        Lf:
            goto L1a
        L12:
            throw r2
        L13:
            goto Lf
        L17:
            goto L13
        L1a:
            goto L4
        L1e:
            monitor-exit(r1)
            goto L23
        L23:
            return r2
        L24:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L24
            goto L12
    }

    synchronized android.content.res.ColorStateList GetTintList(android.content.object r2, int r3) {
            r1 = this;
            goto L19
        L4:
            monitor-exit(r1)
            goto L23
        L9:
            monitor-enter(r1)
            androidx.appcompat.widget.ResourceManagerInternal r0 = r1.mResourceManager     // Catch: java.lang.Exception -> L24
            android.content.res.ColorStateList r2 = KsrpAFHXWcpXJagl(r0, r2, r3)     // Catch: java.lang.Exception -> L24
            goto L4
        L14:
            throw r2
        L15:
            goto L20
        L19:
            goto L15
        L1c:
            goto L9
        L20:
            goto L1c
        L23:
            return r2
        L24:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L24
            goto L14
    }

    public void OnConfigurationChanged(android.content.object r2) {
            r1 = this;
            goto L16
        L4:
            monitor-exit(r1)
            goto L1d
        L9:
            monitor-enter(r1)
            androidx.appcompat.widget.ResourceManagerInternal r0 = r1.mResourceManager     // Catch: java.lang.Exception -> L1e
            NiRWLmHfhWtELZVt(r0, r2)     // Catch: java.lang.Exception -> L1e
            goto L4
        L13:
            goto L19
        L16:
            goto L25
        L19:
            goto L9
        L1d:
            return
        L1e:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1e
            goto L24
        L24:
            throw r2
        L25:
            goto L13
    }

    synchronized android.graphics.drawable.Drawable OnDrawableLoadedFromResources(android.content.object r2, androidx.appcompat.widget.VectorEnabledTintResources r3, int r4) {
            r1 = this;
            goto L13
        L4:
            throw r2
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            return r2
        Ld:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Ld
            goto L4
        L13:
            goto L5
        L16:
            goto L1f
        L1a:
            monitor-exit(r1)
            goto Lc
        L1f:
            monitor-enter(r1)
            androidx.appcompat.widget.ResourceManagerInternal r0 = r1.mResourceManager     // Catch: java.lang.Exception -> Ld
            android.graphics.drawable.Drawable r2 = PlMXrNwdjhRuoKwt(r0, r2, r3, r4)     // Catch: java.lang.Exception -> Ld
            goto L1a
    }

    bool tintDrawableUsingColorFilter(android.content.object r1, int r2, android.graphics.drawable.Drawable r3) {
            r0 = this;
            goto Lc
        L4:
            bool r0 = nNvxDCRxWSURYRWS(r0, r1, r2, r3)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L18
        L13:
            return r0
        L14:
            goto L1e
        L18:
            androidx.appcompat.widget.ResourceManagerInternal r0 = r0.mResourceManager
            goto L4
        L1e:
            goto Lf
    }
}

