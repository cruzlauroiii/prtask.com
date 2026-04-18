namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
public abstract class BaseProgressIndicator<S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec> : android.widget.ProgressBar {
    static readonly float DEFAULT_OPACITY = 0.2f;
    static readonly int DEF_STYLE_RES = 0;
    public static readonly int HIDE_ESCAPE = 3;
    public static readonly int HIDE_INWARD = 2;
    public static readonly int HIDE_NONE = 0;
    public static readonly int HIDE_OUTWARD = 1;
    static readonly int MAX_ALPHA = 255;
    static readonly int MAX_HIDE_DELAY = 1000;
    public static readonly int SHOW_INWARD = 2;
    public static readonly int SHOW_NONE = 0;
    public static readonly int SHOW_OUTWARD = 1;
    com.google.android.material.progressindicator.AnimatorDurationScaleProvider animatorDurationScaleProvider;
    private readonly java.lang.Action delayedHide;
    private readonly java.lang.Action delayedShow;
    private readonly androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback hideAnimationCallback;
    private bool isIndeterminateModeChangeRequested;
    private bool isParentDoneInitializing;
    private long lastShowStartTime;
    private readonly int minHideDelay;
    private readonly int showDelay;
    S spec;
    private int storedProgress;
    private bool storedProgressAnimated;
    private readonly androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback switchIndeterminateModeCallback;
    private int visibilityAfterHide;





    @java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.SOURCE)
    public interface HideAnimationBehavior {
    }

    @java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.SOURCE)
    public interface ShowAnimationBehavior {
    }

    static {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            int r0 = com.google.android.material.C1151R.style.Widget_MaterialComponents_ProgressIndicator
            goto L19
        L19:
            com.google.android.material.progressindicator.BaseProgressIndicator.DEF_STYLE_RES = r0
            goto Le
    }

    protected BaseProgressIndicator(android.content.object r8, android.util.AttributeHashSet r9, int r10, int r11) {
            r7 = this;
            goto L99
        L4:
            r8 = 0
            goto L64
        L9:
            r7.spec = r0
            goto L49
        Lf:
            r7.delayedShow = r0
            goto L85
        L15:
            int r0 = r0 + r1
            goto Lf6
        L1b:
            r5 = r11
            goto L130
        L20:
            r8.<init>()
            goto Lbd
        L27:
            r2 = r9
            goto Ld0
        L2c:
            r0 = -1
            goto L12a
        L32:
            r0.<init>(r7)
            goto Lb7
        L39:
            goto L9c
        L3c:
            r7.showDelay = r9
            goto Le3
        L42:
            r7.<init>(r8, r9, r10)
            goto L2c
        L49:
            int[] r3 = com.google.android.material.C1151R.styleable.BaseProgressIndicator
            goto L15a
        L4f:
            r10 = -1
            goto L91
        L54:
            goto L77
        L57:
            goto L8b
        L5b:
            if (r0 <= 0) goto L60
            goto L57
        L60:
            goto L54
        L64:
            r7.isIndeterminateModeChangeRequested = r8
            goto L7b
        L6a:
            r7.hideAnimationCallback = r0
            goto Lfc
        L70:
            com.google.android.material.progressindicator.AnimatorDurationScaleProvider r8 = new com.google.android.material.progressindicator.AnimatorDurationScaleProvider
            goto L20
        L76:
            return
        L77:
            goto L10a
        L7b:
            r0 = 4
            goto Ld5
        L80:
            r8 = 1
            goto L11e
        L85:
            com.google.android.material.progressindicator.BaseProgressIndicator$2 r0 = new com.google.android.material.progressindicator.BaseProgressIndicator$2
            goto L13e
        L8b:
            int r0 = com.google.android.material.progressindicator.BaseProgressIndicator.DEF_STYLE_RES
            goto La0
        L91:
            int r9 = eoVuwBnEQDRYgxZC(r8, r9, r10)
            goto L3c
        L99:
            goto L10d
        L9c:
            goto L111
        La0:
            android.content.object r8 = EdVZwRmctLqzxXeL(r8, r9, r10, r0)
            goto L42
        La8:
            int r9 = paAZRseRluznZWlU(r9, r10)
            goto L118
        Lb0:
            r0.<init>(r7)
            goto L6a
        Lb7:
            r7.switchIndeterminateModeCallback = r0
            goto Lca
        Lbd:
            r7.animatorDurationScaleProvider = r8
            goto L80
        Lc3:
            r1 = 32
            goto L15
        Lca:
            com.google.android.material.progressindicator.BaseProgressIndicator$4 r0 = new com.google.android.material.progressindicator.BaseProgressIndicator$4
            goto Lb0
        Ld0:
            r4 = r10
            goto L1b
        Ld5:
            r7.visibilityAfterHide = r0
            goto L124
        Ldb:
            int r9 = sxCmeKpnKdmcruXb(r8, r9, r10)
            goto L104
        Le3:
            int r9 = com.google.android.material.C1151R.styleable.BaseProgressIndicator_minHideDelay
            goto Ldb
        Le9:
            r7.delayedHide = r0
            goto L138
        Lef:
            r0.<init>(r7)
            goto Lf
        Lf6:
            int r0 = r0 % r1
            goto L5b
        Lfc:
            android.content.object r1 = iKwjvHPfTLAPxZpE(r7)
            goto L145
        L104:
            r10 = 1000(0x3e8, float:1.401E-42)
            goto La8
        L10a:
            goto L57
        L10d:
            goto L39
        L111:
            r0 = 22
            goto Lc3
        L118:
            r7.minHideDelay = r9
            goto L14d
        L11e:
            r7.isParentDoneInitializing = r8
            goto L76
        L124:
            com.google.android.material.progressindicator.BaseProgressIndicator$1 r0 = new com.google.android.material.progressindicator.BaseProgressIndicator$1
            goto Lef
        L12a:
            r7.lastShowStartTime = r0
            goto L4
        L130:
            android.content.res.TypedArray r8 = JBPxsqlcObDBhYAS(r1, r2, r3, r4, r5, r6)
            goto L154
        L138:
            com.google.android.material.progressindicator.BaseProgressIndicator$3 r0 = new com.google.android.material.progressindicator.BaseProgressIndicator$3
            goto L32
        L13e:
            r0.<init>(r7)
            goto Le9
        L145:
            com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = JBDfokHLTXtTJemy(r7, r1, r9)
            goto L9
        L14d:
            LtFvHSBPKexCrHcq(r8)
            goto L70
        L154:
            int r9 = com.google.android.material.C1151R.styleable.BaseProgressIndicator_showDelay
            goto L4f
        L15a:
            int[] r6 = new int[r8]
            goto L27
    }

    public static void AJgbyjTGNmdRykQI(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, short r2, char r3, java.lang.string r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L1b
        Ld:
            goto L1f
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L17:
            goto Ld
        L1a:
            return
        L1b:
            goto L17
        L1f:
            r0 = 42
            goto L11
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void AJgbyjTGNmdRykQI(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, int r2, char r3, java.lang.string r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L2c
        La:
            goto L25
        Le:
            double r0 = (double) r3
            goto L2b
        L13:
            int r2 = r0 * r1
            goto L19
        L19:
            int r3 = r2 + r1
            goto Le
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L25:
            r0 = 42
            goto L1f
        L2b:
            return
        L2c:
            goto L4
    }

    public static void AJgbyjTGNmdRykQI(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, java.lang.string r2, int r3, char r4) {
            goto L19
        L4:
            goto L1c
        L7:
            int r2 = r0 * r1
            goto L20
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L13:
            r0 = 42
            goto Ld
        L19:
            goto L27
        L1c:
            goto L13
        L20:
            int r3 = r2 + r1
            goto L2b
        L26:
            return
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static bool AJgbyjTGNmdRykQI(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
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
            bool r0 = r1.isIndeterminate()
            goto L4
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable AKTyPWbHCsFEnapt(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto Lb
        L18:
            goto L7
    }

    public static void AKTyPWbHCsFEnapt(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, byte r2, int r3, bool r4) {
            goto L29
        L4:
            return
        L5:
            goto L1a
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        Lf:
            int r3 = r2 + r1
            goto L15
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            goto L2c
        L1d:
            r0 = 42
            goto L9
        L23:
            int r2 = r0 * r1
            goto Lf
        L29:
            goto L5
        L2c:
            goto L1d
    }

    public static void AKTyPWbHCsFEnapt(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, byte r2, bool r3, int r4) {
            goto L1b
        L4:
            r0 = 42
            goto Lf
        La:
            return
        Lb:
            goto L28
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L15:
            int r3 = r2 + r1
            goto L2b
        L1b:
            goto Lb
        L1e:
            goto L4
        L22:
            int r2 = r0 * r1
            goto L15
        L28:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void AKTyPWbHCsFEnapt(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, byte r2, char r3, bool r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L23
        La:
            goto L29
        Ld:
            goto L17
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L17:
            r0 = 42
            goto L11
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable AOGBiwNyScQEEwNa(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
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
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto Le
    }

    public static void AOGBiwNyScQEEwNa(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, short r2, char r3, float r4) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            goto L26
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto Lf
        L22:
            goto L18
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void AOGBiwNyScQEEwNa(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, short r2, float r3, char r4) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L16
        Lb:
            int r3 = r2 + r1
            goto L11
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            r0 = 42
            goto L24
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L7
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto Lb
    }

    public static void AOGBiwNyScQEEwNa(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, short r2, float r3, byte r4) {
            goto L13
        L4:
            goto L16
        L7:
            int r3 = r2 + r1
            goto L2b
        Ld:
            int r2 = r0 * r1
            goto L7
        L13:
            goto L27
        L16:
            goto L20
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L20:
            r0 = 42
            goto L1a
        L26:
            return
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void AVYqpUHvLJFrXOyZ(com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.validateSpec()
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void AVYqpUHvLJFrXOyZ(com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0, java.lang.string r1, short r2, bool r3, int r4) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L1c
        L10:
            r0 = 42
            goto L27
        L16:
            int r3 = r2 + r1
            goto Lb
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r2 = r0 * r1
            goto L16
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L2d:
            goto L7
    }

    public static void AVYqpUHvLJFrXOyZ(com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0, short r1, int r2, bool r3, java.lang.string r4) {
            goto L21
        L4:
            return
        L5:
            goto L2d
        L9:
            int r2 = r0 * r1
            goto L15
        Lf:
            r0 = 42
            goto L1b
        L15:
            int r3 = r2 + r1
            goto L28
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L21:
            goto L5
        L24:
            goto Lf
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L24
    }

    public static void AVYqpUHvLJFrXOyZ(com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0, bool r1, short r2, java.lang.string r3, int r4) {
            goto L4
        L4:
            goto L11
        L7:
            goto L24
        Lb:
            double r0 = (double) r3
            goto L10
        L10:
            return
        L11:
            goto L21
        L15:
            int r3 = r2 + r1
            goto Lb
        L1b:
            int r2 = r0 * r1
            goto L15
        L21:
            goto L7
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
    }

    public static void AwtLJdaCNfDIZXpH(android.view.object r0, int r1, short r2, char r3, bool r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L24
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L10:
            return
        L11:
            goto L1b
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            goto L2c
        L1e:
            r0 = 42
            goto La
        L24:
            double r0 = (double) r3
            goto L10
        L29:
            goto L11
        L2c:
            goto L1e
    }

    public static void AwtLJdaCNfDIZXpH(android.view.object r0, int r1, bool r2, short r3, char r4) {
            goto L15
        L4:
            return
        L5:
            goto L21
        L9:
            int r3 = r2 + r1
            goto L1c
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            goto L5
        L18:
            goto L24
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            goto L18
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void AwtLJdaCNfDIZXpH(android.view.object r0, bool r1, int r2, char r3, short r4) {
            goto L1e
        L4:
            return
        L5:
            goto L1b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            int r3 = r2 + r1
            goto L25
        L15:
            r0 = 42
            goto L9
        L1b:
            goto L21
        L1e:
            goto L5
        L21:
            goto L15
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r2 = r0 * r1
            goto Lf
    }

    public static bool AwtLJdaCNfDIZXpH(android.view.object r1) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = androidx.core.view.objectCompat.isAttachedToWindow(r1)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static int BLCRMalVWAZYsxZG(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
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
            int r0 = r1.getPaddingRight()
            goto Le
    }

    public static void BLCRMalVWAZYsxZG(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2, byte r3, short r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        La:
            goto L2c
        Ld:
            goto L25
        L11:
            goto Ld
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L14
        L25:
            r0 = 42
            goto L4
        L2b:
            return
        L2c:
            goto L11
    }

    public static void BLCRMalVWAZYsxZG(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, byte r2, int r3, bool r4) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L15:
            goto L1b
        L18:
            goto L20
        L1b:
            goto L24
        L1f:
            return
        L20:
            goto L15
        L24:
            r0 = 42
            goto Lf
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void BLCRMalVWAZYsxZG(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, byte r2, bool r3, int r4) {
            goto L24
        L4:
            return
        L5:
            goto L15
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        Lf:
            r0 = 42
            goto L9
        L15:
            goto L27
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L2b
        L24:
            goto L5
        L27:
            goto Lf
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable BLPnDnlaHwjXpYqO(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void BLPnDnlaHwjXpYqO(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, float r2, bool r3, short r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            goto L20
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L19
        L16:
            goto Lc
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L1f:
            return
        L20:
            goto L16
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void BLPnDnlaHwjXpYqO(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, short r2, char r3, bool r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L10
        L9:
            goto L11
        Lc:
            goto L27
        L10:
            return
        L11:
            goto L2d
        L15:
            int r2 = r0 * r1
            goto L21
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L21:
            int r3 = r2 + r1
            goto L4
        L27:
            r0 = 42
            goto L1b
        L2d:
            goto Lc
    }

    public static void BLPnDnlaHwjXpYqO(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, float r2, char r3, short r4) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L17
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L10:
            goto L2c
        L13:
            goto L22
        L17:
            double r0 = (double) r3
            goto L2b
        L1c:
            int r2 = r0 * r1
            goto L4
        L22:
            r0 = 42
            goto La
        L28:
            goto L13
        L2b:
            return
        L2c:
            goto L28
    }

    public static int BMEkmrLUVuYxNlGr(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
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
            int r0 = r1.getPaddingLeft()
            goto Le
    }

    public static void BMEkmrLUVuYxNlGr(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, short r2, float r3, java.lang.string r4) {
            goto L16
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L22
        L16:
            goto L1e
        L19:
            goto L2a
        L1d:
            return
        L1e:
            goto L27
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            goto L19
        L2a:
            r0 = 42
            goto L4
    }

    public static void BMEkmrLUVuYxNlGr(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, float r2, byte r3, java.lang.string r4) {
            goto L19
        L4:
            r0 = 42
            goto L13
        La:
            goto L1c
        Ld:
            int r3 = r2 + r1
            goto L2b
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L19:
            goto L27
        L1c:
            goto L4
        L20:
            int r2 = r0 * r1
            goto Ld
        L26:
            return
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void BMEkmrLUVuYxNlGr(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, java.lang.string r2, byte r3, float r4) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L16
        Lb:
            int r3 = r2 + r1
            goto L11
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            r0 = 42
            goto L21
        L1c:
            return
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L27:
            goto L7
        L2a:
            int r2 = r0 * r1
            goto Lb
    }

    public static int BZdzluonJEJIBocu(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = r1.getWindowVisibility()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void BZdzluonJEJIBocu(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, short r2, bool r3, java.lang.string r4) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        La:
            r0 = 42
            goto L4
        L10:
            goto L27
        L13:
            double r0 = (double) r3
            goto L2b
        L18:
            int r3 = r2 + r1
            goto L13
        L1e:
            int r2 = r0 * r1
            goto L18
        L24:
            goto L2c
        L27:
            goto La
        L2b:
            return
        L2c:
            goto L10
    }

    public static void BZdzluonJEJIBocu(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, bool r2, char r3, java.lang.string r4) {
            goto Ld
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L10
        Ld:
            goto L26
        L10:
            goto L19
        L14:
            double r0 = (double) r3
            goto L25
        L19:
            r0 = 42
            goto L4
        L1f:
            int r3 = r2 + r1
            goto L14
        L25:
            return
        L26:
            goto La
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static void BZdzluonJEJIBocu(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, java.lang.string r2, short r3, char r4) {
            goto Ld
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L10
        Ld:
            goto L1b
        L10:
            goto L1f
        L14:
            int r2 = r0 * r1
            goto L4
        L1a:
            return
        L1b:
            goto La
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void BptdMFITmIeEemxa(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, java.lang.string r2, short r3, char r4) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r0 = 42
            goto L25
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L2c
        L18:
            goto La
        L1c:
            int r2 = r0 * r1
            goto L4
        L22:
            goto L18
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L2b:
            return
        L2c:
            goto L22
    }

    public static void BptdMFITmIeEemxa(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, char r2, short r3, int r4) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            goto L1b
        Lc:
            int r2 = r0 * r1
            goto L2a
        L12:
            r0 = 42
            goto L24
        L18:
            goto L20
        L1b:
            goto L12
        L1f:
            return
        L20:
            goto L9
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void BptdMFITmIeEemxa(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, char r2, int r3, java.lang.string r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto L24
        Le:
            int r2 = r0 * r1
            goto L2a
        L14:
            return
        L15:
            goto L4
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L1f:
            double r0 = (double) r3
            goto L14
        L24:
            r0 = 42
            goto L19
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static bool BptdMFITmIeEemxa(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
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
            bool r0 = r1.isIndeterminate()
            goto L4
    }

    public static android.graphics.drawable.Drawable CMqVIRFKwxxyoPyd(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            android.graphics.drawable.Drawable r0 = r1.getCurrentDrawable()
            goto L7
    }

    public static void CMqVIRFKwxxyoPyd(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, float r3, java.lang.string r4) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L1f
        L10:
            goto Lc
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L19:
            int r3 = r2 + r1
            goto L2b
        L1f:
            r0 = 42
            goto L13
        L25:
            int r2 = r0 * r1
            goto L19
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void CMqVIRFKwxxyoPyd(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, char r2, int r3, java.lang.string r4) {
            goto Ld
        L4:
            int r3 = r2 + r1
            goto L19
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L2a
        L14:
            return
        L15:
            goto La
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r0 = 42
            goto L1e
    }

    public static void CMqVIRFKwxxyoPyd(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, float r2, java.lang.string r3, char r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L14
        Ld:
            goto L20
        L10:
            goto L19
        L14:
            double r0 = (double) r3
            goto L1f
        L19:
            r0 = 42
            goto L2a
        L1f:
            return
        L20:
            goto L4
        L24:
            int r2 = r0 * r1
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable CbSIaToSDjBsXyvO(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void CbSIaToSDjBsXyvO(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, short r2, java.lang.string r3, char r4) {
            goto L20
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            return
        L16:
            goto L27
        L1a:
            r0 = 42
            goto L9
        L20:
            goto L16
        L23:
            goto L1a
        L27:
            goto L23
        L2a:
            int r2 = r0 * r1
            goto Lf
    }

    public static void CbSIaToSDjBsXyvO(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, short r2, java.lang.string r3, byte r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L24
        L10:
            return
        L11:
            goto L1b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            goto L2c
        L1e:
            r0 = 42
            goto L15
        L24:
            double r0 = (double) r3
            goto L10
        L29:
            goto L11
        L2c:
            goto L1e
    }

    public static void CbSIaToSDjBsXyvO(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, byte r2, char r3, short r4) {
            goto L24
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L4
        L1c:
            goto L27
        L1f:
            double r0 = (double) r3
            goto L2b
        L24:
            goto L2c
        L27:
            goto La
        L2b:
            return
        L2c:
            goto L1c
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable CjTAFPiOvoaYyUGb(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lf
        L4:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void CjTAFPiOvoaYyUGb(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, short r2, bool r3, byte r4) {
            goto L29
        L4:
            return
        L5:
            goto L9
        L9:
            goto L2c
        Lc:
            r0 = 42
            goto L1d
        L12:
            int r2 = r0 * r1
            goto L23
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L23:
            int r3 = r2 + r1
            goto L18
        L29:
            goto L5
        L2c:
            goto Lc
    }

    public static void CjTAFPiOvoaYyUGb(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, bool r2, short r3, byte r4) {
            goto L12
        L4:
            goto L15
        L7:
            int r3 = r2 + r1
            goto L19
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L2a
        L19:
            double r0 = (double) r3
            goto Ld
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L7
        L2a:
            r0 = 42
            goto L1e
    }

    public static void CjTAFPiOvoaYyUGb(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, java.lang.string r2, short r3, byte r4) {
            goto L11
        L4:
            goto L14
        L7:
            double r0 = (double) r3
            goto Lc
        Lc:
            return
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            goto L1e
        L18:
            int r2 = r0 * r1
            goto L2a
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L2a:
            int r3 = r2 + r1
            goto L7
    }

    public static int DjffsBLgiuXUpoDw(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            int r0 = r1.getMax()
            goto L4
        L18:
            goto Lc
    }

    public static void DjffsBLgiuXUpoDw(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, float r2, java.lang.string r3, bool r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L19
        Ld:
            goto L15
        L10:
            goto L24
        L14:
            return
        L15:
            goto L4
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            int r2 = r0 * r1
            goto L7
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void DjffsBLgiuXUpoDw(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, bool r2, float r3, java.lang.string r4) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        La:
            int r3 = r2 + r1
            goto L1a
        L10:
            goto L26
        L13:
            goto L2a
        L17:
            goto L13
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            int r2 = r0 * r1
            goto La
        L25:
            return
        L26:
            goto L17
        L2a:
            r0 = 42
            goto L4
    }

    public static void DjffsBLgiuXUpoDw(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, char r2, bool r3, java.lang.string r4) {
            goto Ld
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            goto L10
        Ld:
            goto L2c
        L10:
            goto L14
        L14:
            r0 = 42
            goto L20
        L1a:
            int r3 = r2 + r1
            goto L26
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto La
    }

    public static void EDYiYAKpmjxFSEsU(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1) {
            goto Le
        L4:
            super.setIndeterminateDrawable(r1)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void EDYiYAKpmjxFSEsU(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1, float r2, byte r3, short r4, int r5) {
            goto L24
        L4:
            return
        L5:
            goto L21
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L1b
        L1b:
            int r3 = r2 + r1
            goto L2b
        L21:
            goto L27
        L24:
            goto L5
        L27:
            goto L9
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void EDYiYAKpmjxFSEsU(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1, float r2, int r3, byte r4, short r5) {
            goto L24
        L4:
            goto L27
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L1e
        L13:
            double r0 = (double) r3
            goto L2b
        L18:
            r0 = 42
            goto L7
        L1e:
            int r3 = r2 + r1
            goto L13
        L24:
            goto L2c
        L27:
            goto L18
        L2b:
            return
        L2c:
            goto L4
    }

    public static void EDYiYAKpmjxFSEsU(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1, short r2, int r3, byte r4, float r5) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            return
        Lb:
            goto L21
        Lf:
            goto Lb
        L12:
            goto L24
        L16:
            double r0 = (double) r3
            goto La
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L21:
            goto L12
        L24:
            r0 = 42
            goto L1b
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static com.google.android.material.progressindicator.DrawingDelegate ENAAlGYxUUGAAfmH(com.google.android.material.progressindicator.IndeterminateDrawable r1) {
            goto L14
        L4:
            com.google.android.material.progressindicator.DrawingDelegate r0 = r1.getDrawingDelegate()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void ENAAlGYxUUGAAfmH(com.google.android.material.progressindicator.IndeterminateDrawable r0, int r1, short r2, float r3, java.lang.string r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L19
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L11:
            double r0 = (double) r3
            goto L25
        L16:
            goto L7
        L19:
            r0 = 42
            goto Lb
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            return
        L26:
            goto L16
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static void ENAAlGYxUUGAAfmH(com.google.android.material.progressindicator.IndeterminateDrawable r0, java.lang.string r1, short r2, int r3, float r4) {
            goto L4
        L4:
            goto L17
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L16
        L10:
            r0 = 42
            goto L21
        L16:
            return
        L17:
            goto L2d
        L1b:
            int r2 = r0 * r1
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L27:
            int r3 = r2 + r1
            goto Lb
        L2d:
            goto L7
    }

    public static void ENAAlGYxUUGAAfmH(com.google.android.material.progressindicator.IndeterminateDrawable r0, short r1, float r2, int r3, java.lang.string r4) {
            goto L26
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L2d
        Le:
            int r2 = r0 * r1
            goto L14
        L14:
            int r3 = r2 + r1
            goto L4
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L20:
            r0 = 42
            goto L1a
        L26:
            goto La
        L29:
            goto L20
        L2d:
            goto L29
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable EXBprsQRLFxeYKRW(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void EXBprsQRLFxeYKRW(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, int r2, short r3, bool r4) {
            goto L13
        L4:
            int r2 = r0 * r1
            goto Ld
        La:
            goto L16
        Ld:
            int r3 = r2 + r1
            goto L2b
        L13:
            goto L21
        L16:
            goto L25
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            return
        L21:
            goto La
        L25:
            r0 = 42
            goto L1a
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void EXBprsQRLFxeYKRW(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2, short r3, float r4) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            goto L27
        L12:
            r0 = 42
            goto L4
        L18:
            int r3 = r2 + r1
            goto La
        L1e:
            int r2 = r0 * r1
            goto L18
        L24:
            goto L2c
        L27:
            goto L12
        L2b:
            return
        L2c:
            goto Lf
    }

    public static void EXBprsQRLFxeYKRW(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, int r2, bool r3, float r4) {
            goto L24
        L4:
            goto L27
        L7:
            r0 = 42
            goto L1e
        Ld:
            int r3 = r2 + r1
            goto L13
        L13:
            double r0 = (double) r3
            goto L2b
        L18:
            int r2 = r0 * r1
            goto Ld
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L24:
            goto L2c
        L27:
            goto L7
        L2b:
            return
        L2c:
            goto L4
    }

    public static android.content.object EdVZwRmctLqzxXeL(android.content.object r1, android.util.AttributeHashSet r2, int r3, int r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            android.content.object r0 = com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(r1, r2, r3, r4)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void EdVZwRmctLqzxXeL(android.content.object r0, android.util.AttributeHashSet r1, int r2, int r3, char r4, float r5, bool r6, short r7) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            return
        L11:
            goto L15
        L15:
            goto L1b
        L18:
            goto L11
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto La
        L25:
            double r0 = (double) r3
            goto L10
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void EdVZwRmctLqzxXeL(android.content.object r0, android.util.AttributeHashSet r1, int r2, int r3, short r4, char r5, bool r6, float r7) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L13
        L10:
            goto L26
        L13:
            int r3 = r2 + r1
            goto L1e
        L19:
            return
        L1a:
            goto L10
        L1e:
            double r0 = (double) r3
            goto L19
        L23:
            goto L1a
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L4
    }

    public static void EdVZwRmctLqzxXeL(android.content.object r0, android.util.AttributeHashSet r1, int r2, int r3, bool r4, char r5, float r6, short r7) {
            goto L9
        L4:
            return
        L5:
            goto L1c
        L9:
            goto L5
        Lc:
            goto L24
        L10:
            int r2 = r0 * r1
            goto L16
        L16:
            int r3 = r2 + r1
            goto L1f
        L1c:
            goto Lc
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
    }

    public static android.content.ContentResolver EpwCtpUcIcxRCgJG(android.content.object r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.ContentResolver r0 = r1.getContentResolver()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void EpwCtpUcIcxRCgJG(android.content.object r0, char r1, bool r2, java.lang.string r3, short r4) {
            goto L12
        L4:
            int r3 = r2 + r1
            goto Ld
        La:
            goto L15
        Ld:
            double r0 = (double) r3
            goto L25
        L12:
            goto L26
        L15:
            goto L1f
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            r0 = 42
            goto L19
        L25:
            return
        L26:
            goto La
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void EpwCtpUcIcxRCgJG(android.content.object r0, java.lang.string r1, bool r2, char r3, short r4) {
            goto L1e
        L4:
            r0 = 42
            goto L15
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1b:
            goto L21
        L1e:
            goto L26
        L21:
            goto L4
        L25:
            return
        L26:
            goto L1b
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void EpwCtpUcIcxRCgJG(android.content.object r0, short r1, char r2, java.lang.string r3, bool r4) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        La:
            r0 = 42
            goto L4
        L10:
            goto L1e
        L13:
            goto La
        L17:
            int r3 = r2 + r1
            goto L2b
        L1d:
            return
        L1e:
            goto L28
        L22:
            int r2 = r0 * r1
            goto L17
        L28:
            goto L13
        L2b:
            double r0 = (double) r3
            goto L1d
    }

    public static void ExRaxhhZyQTcyTXr(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L13
        L4:
            r0.invalidate()
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static void ExRaxhhZyQTcyTXr(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, char r2, java.lang.string r3, float r4) {
            goto L1e
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            int r3 = r2 + r1
            goto L19
        L16:
            goto L21
        L19:
            double r0 = (double) r3
            goto L25
        L1e:
            goto L26
        L21:
            goto L4
        L25:
            return
        L26:
            goto L16
        L2a:
            int r2 = r0 * r1
            goto L10
    }

    public static void ExRaxhhZyQTcyTXr(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, float r2, java.lang.string r3, char r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L22
        La:
            goto L18
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L1c
        L17:
            return
        L18:
            goto L27
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L22:
            double r0 = (double) r3
            goto L17
        L27:
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void ExRaxhhZyQTcyTXr(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, java.lang.string r2, byte r3, float r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L28
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        Lf:
            goto L29
        L12:
            goto L16
        L16:
            r0 = 42
            goto L9
        L1c:
            int r3 = r2 + r1
            goto L4
        L22:
            int r2 = r0 * r1
            goto L1c
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L12
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable FqzpvzATWsaQNWvc(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void FqzpvzATWsaQNWvc(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, byte r2, int r3, bool r4) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L26
        L1d:
            r0 = 42
            goto La
        L23:
            goto L16
        L26:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void FqzpvzATWsaQNWvc(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, byte r2, char r3, bool r4) {
            goto L12
        L4:
            goto L15
        L7:
            int r3 = r2 + r1
            goto Ld
        Ld:
            double r0 = (double) r3
            goto L2b
        L12:
            goto L2c
        L15:
            goto L25
        L19:
            int r2 = r0 * r1
            goto L7
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            r0 = 42
            goto L1f
        L2b:
            return
        L2c:
            goto L4
    }

    public static void FqzpvzATWsaQNWvc(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, byte r2, bool r3, char r4) {
            goto L17
        L4:
            return
        L5:
            goto Le
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            goto L1a
        L11:
            r0 = 42
            goto L2a
        L17:
            goto L5
        L1a:
            goto L11
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L9
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void GPEBebvLfHYIABWs(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.applyNewVisibility(r1)
            goto Le
    }

    public static void GPEBebvLfHYIABWs(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, int r2, short r3, char r4, java.lang.string r5) {
            goto L20
        L4:
            int r2 = r0 * r1
            goto L27
        La:
            r0 = 42
            goto L1a
        L10:
            return
        L11:
            goto L2d
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            goto L11
        L23:
            goto La
        L27:
            int r3 = r2 + r1
            goto L15
        L2d:
            goto L23
    }

    public static void GPEBebvLfHYIABWs(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, int r2, short r3, java.lang.string r4, char r5) {
            goto L21
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            double r0 = (double) r3
            goto L2b
        L1b:
            r0 = 42
            goto L10
        L21:
            goto L2c
        L24:
            goto L1b
        L28:
            goto L24
        L2b:
            return
        L2c:
            goto L28
    }

    public static void GPEBebvLfHYIABWs(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, short r2, char r3, int r4, java.lang.string r5) {
            goto L18
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        La:
            goto L1b
        Ld:
            int r2 = r0 * r1
            goto L2a
        L13:
            return
        L14:
            goto La
        L18:
            goto L14
        L1b:
            goto L24
        L1f:
            double r0 = (double) r3
            goto L13
        L24:
            r0 = 42
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void GcFZHkzvMtFJUnSl(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto Le
        L4:
            goto L11
        L7:
            r0.unregisterAnimationCallbacks()
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static void GcFZHkzvMtFJUnSl(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, short r2, char r3, int r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L1a
        Ld:
            goto L26
        L10:
            goto L14
        L14:
            r0 = 42
            goto L2a
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            int r2 = r0 * r1
            goto L7
        L25:
            return
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void GcFZHkzvMtFJUnSl(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, byte r2, char r3, int r4) {
            goto L12
        L4:
            int r2 = r0 * r1
            goto L19
        La:
            goto L15
        Ld:
            double r0 = (double) r3
            goto L25
        L12:
            goto L26
        L15:
            goto L2a
        L19:
            int r3 = r2 + r1
            goto Ld
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            return
        L26:
            goto La
        L2a:
            r0 = 42
            goto L1f
    }

    public static void GcFZHkzvMtFJUnSl(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, int r2, byte r3, char r4) {
            goto L9
        L4:
            return
        L5:
            goto L27
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L16
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            int r2 = r0 * r1
            goto L2a
        L27:
            goto Lc
        L2a:
            int r3 = r2 + r1
            goto L1c
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable HzjKygDbqYVKAJJS(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void HzjKygDbqYVKAJJS(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, float r2, java.lang.string r3, short r4) {
            goto L10
        L4:
            r0 = 42
            goto L24
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            goto L1b
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            return
        L1b:
            goto L17
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void HzjKygDbqYVKAJJS(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, short r2, float r3, char r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            goto L18
        Ld:
            goto L1f
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto Ld
        L1f:
            r0 = 42
            goto L11
        L25:
            double r0 = (double) r3
            goto L17
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void HzjKygDbqYVKAJJS(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, java.lang.string r2, char r3, float r4) {
            goto L20
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        Lf:
            return
        L10:
            goto L27
        L14:
            int r2 = r0 * r1
            goto L2a
        L1a:
            r0 = 42
            goto L9
        L20:
            goto L10
        L23:
            goto L1a
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static int IHpwVQjjARKMxFSk(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            int r0 = r1.getWindowVisibility()
            goto Lb
        L18:
            goto L7
    }

    public static void IHpwVQjjARKMxFSk(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, float r2, java.lang.string r3, int r4) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            double r0 = (double) r3
            goto L1b
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L26
        L23:
            goto L1c
        L26:
            goto Lf
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void IHpwVQjjARKMxFSk(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, int r2, java.lang.string r3, char r4) {
            goto L18
        L4:
            goto L1b
        L7:
            int r2 = r0 * r1
            goto L12
        Ld:
            double r0 = (double) r3
            goto L25
        L12:
            int r3 = r2 + r1
            goto Ld
        L18:
            goto L26
        L1b:
            goto L2a
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L25:
            return
        L26:
            goto L4
        L2a:
            r0 = 42
            goto L1f
    }

    public static void IHpwVQjjARKMxFSk(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, java.lang.string r2, int r3, char r4) {
            goto Lf
        L4:
            r0 = 42
            goto L2a
        La:
            double r0 = (double) r3
            goto L25
        Lf:
            goto L26
        L12:
            goto L4
        L16:
            int r2 = r0 * r1
            goto L1c
        L1c:
            int r3 = r2 + r1
            goto La
        L22:
            goto L12
        L25:
            return
        L26:
            goto L22
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
    }

    public static void IPgkEVZrTSsgfgjT(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.invalidate()
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void IPgkEVZrTSsgfgjT(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, byte r2, int r3, float r4) {
            goto L9
        L4:
            return
        L5:
            goto L16
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L25
        L16:
            goto Lc
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void IPgkEVZrTSsgfgjT(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, int r2, byte r3, char r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L23
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L2c
        L1d:
            r0 = 42
            goto La
        L23:
            int r3 = r2 + r1
            goto L10
        L29:
            goto L16
        L2c:
            goto L1d
    }

    public static void IPgkEVZrTSsgfgjT(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, char r2, byte r3, float r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            r0 = 42
            goto L27
        Lf:
            int r2 = r0 * r1
            goto L21
        L15:
            return
        L16:
            goto L2d
        L1a:
            goto L16
        L1d:
            goto L9
        L21:
            int r3 = r2 + r1
            goto L4
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L2d:
            goto L1d
    }

    public static void IsdGeVGwRWqhjFIy(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, float r2, char r3, bool r4, int r5) {
            goto L29
        L4:
            goto L2c
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L12
        L12:
            double r0 = (double) r3
            goto L7
        L17:
            int r2 = r0 * r1
            goto Lc
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L23:
            r0 = 42
            goto L1d
        L29:
            goto L8
        L2c:
            goto L23
    }

    public static void IsdGeVGwRWqhjFIy(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, float r2, int r3, bool r4, char r5) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L20
        La:
            r0 = 42
            goto L17
        L10:
            goto L2c
        L13:
            goto La
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1d:
            goto L13
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            return
        L2c:
            goto L1d
    }

    public static void IsdGeVGwRWqhjFIy(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, int r2, bool r3, char r4, float r5) {
            goto L4
        L4:
            goto L12
        L7:
            goto L19
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L11:
            return
        L12:
            goto L16
        L16:
            goto L7
        L19:
            r0 = 42
            goto Lb
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L11
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static bool IsdGeVGwRWqhjFIy(com.google.android.material.progressindicator.BaseProgressIndicator r1, java.lang.Action r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            bool r0 = r1.removeCallbacks(r2)
            goto L7
    }

    public static com.google.android.material.progressindicator.DrawingDelegate IuLxUXpeXdzWXdmK(com.google.android.material.progressindicator.DeterminateDrawable r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.material.progressindicator.DrawingDelegate r0 = r1.getDrawingDelegate()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void IuLxUXpeXdzWXdmK(com.google.android.material.progressindicator.DeterminateDrawable r0, char r1, bool r2, java.lang.string r3, int r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto L19
        Le:
            int r3 = r2 + r1
            goto L2b
        L14:
            return
        L15:
            goto L4
        L19:
            r0 = 42
            goto L25
        L1f:
            int r2 = r0 * r1
            goto Le
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L14
    }

    public static void IuLxUXpeXdzWXdmK(com.google.android.material.progressindicator.DeterminateDrawable r0, int r1, char r2, bool r3, java.lang.string r4) {
            goto L16
        L4:
            int r3 = r2 + r1
            goto L23
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            goto L2c
        L19:
            goto L1d
        L1d:
            r0 = 42
            goto La
        L23:
            double r0 = (double) r3
            goto L2b
        L28:
            goto L19
        L2b:
            return
        L2c:
            goto L28
    }

    public static void IuLxUXpeXdzWXdmK(com.google.android.material.progressindicator.DeterminateDrawable r0, bool r1, char r2, int r3, java.lang.string r4) {
            goto L13
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        La:
            goto L16
        Ld:
            r0 = 42
            goto L4
        L13:
            goto L27
        L16:
            goto Ld
        L1a:
            int r2 = r0 * r1
            goto L20
        L20:
            int r3 = r2 + r1
            goto L2b
        L26:
            return
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static com.google.android.material.progressindicator.BaseProgressIndicatorSpec JBDfokHLTXtTJemy(com.google.android.material.progressindicator.BaseProgressIndicator r1, android.content.object r2, android.util.AttributeHashSet r3) {
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
            com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r1.createSpec(r2, r3)
            goto Le
    }

    public static void JBDfokHLTXtTJemy(com.google.android.material.progressindicator.BaseProgressIndicator r0, android.content.object r1, android.util.AttributeHashSet r2, short r3, char r4, bool r5, float r6) {
            goto L9
        L4:
            return
        L5:
            goto L1b
        L9:
            goto L5
        Lc:
            goto L24
        L10:
            double r0 = (double) r3
            goto L4
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            goto Lc
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            r0 = 42
            goto L1e
        L2a:
            int r2 = r0 * r1
            goto L15
    }

    public static void JBDfokHLTXtTJemy(com.google.android.material.progressindicator.BaseProgressIndicator r0, android.content.object r1, android.util.AttributeHashSet r2, short r3, bool r4, float r5, char r6) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L1b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L2c
        L23:
            r0 = 42
            goto L15
        L29:
            goto L1c
        L2c:
            goto L23
    }

    public static void JBDfokHLTXtTJemy(com.google.android.material.progressindicator.BaseProgressIndicator r0, android.content.object r1, android.util.AttributeHashSet r2, bool r3, float r4, short r5, char r6) {
            goto L9
        L4:
            return
        L5:
            goto L1c
        L9:
            goto L5
        Lc:
            goto L16
        L10:
            int r2 = r0 * r1
            goto L2a
        L16:
            r0 = 42
            goto L24
        L1c:
            goto Lc
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static android.content.res.TypedArray JBPxsqlcObDBhYAS(android.content.object r1, android.util.AttributeHashSet r2, int[] r3, int r4, int r5, int[] r6) {
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
            android.content.res.TypedArray r0 = com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(r1, r2, r3, r4, r5, r6)
            goto L4
    }

    public static void JBPxsqlcObDBhYAS(android.content.object r0, android.util.AttributeHashSet r1, int[] r2, int r3, int r4, int[] r5, char r6, byte r7, short r8, float r9) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L26
        L12:
            int r2 = r0 * r1
            goto L9
        L18:
            r0 = 42
            goto L2a
        L1e:
            return
        L1f:
            goto Lf
        L23:
            goto L1f
        L26:
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
    }

    public static void JBPxsqlcObDBhYAS(android.content.object r0, android.util.AttributeHashSet r1, int[] r2, int r3, int r4, int[] r5, float r6, char r7, byte r8, short r9) {
            goto L1c
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            int r3 = r2 + r1
            goto L23
        L1c:
            goto L29
        L1f:
            goto L4
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1f
    }

    public static void JBPxsqlcObDBhYAS(android.content.object r0, android.util.AttributeHashSet r1, int[] r2, int r3, int r4, int[] r5, short r6, float r7, byte r8, char r9) {
            goto L23
        L4:
            r0 = 42
            goto L2a
        La:
            goto L26
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto La
        L17:
            int r3 = r2 + r1
            goto Ld
        L1d:
            int r2 = r0 * r1
            goto L17
        L23:
            goto L13
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable JTusSMdjfWWgxBXS(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto Lb
        L18:
            goto L7
    }

    public static void JTusSMdjfWWgxBXS(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, short r2, bool r3, int r4) {
            goto L4
        L4:
            goto L15
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L19
        L11:
            goto L7
        L14:
            return
        L15:
            goto L11
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L14
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static void JTusSMdjfWWgxBXS(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2, float r3, short r4) {
            goto L4
        L4:
            goto L27
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L11
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L17:
            int r3 = r2 + r1
            goto L2b
        L1d:
            goto L7
        L20:
            int r2 = r0 * r1
            goto L17
        L26:
            return
        L27:
            goto L1d
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void JTusSMdjfWWgxBXS(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2, short r3, float r4) {
            goto L1a
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L2d
        L1a:
            goto L16
        L1d:
            goto L4
        L21:
            int r3 = r2 + r1
            goto L10
        L27:
            int r2 = r0 * r1
            goto L21
        L2d:
            goto L1d
    }

    public static android.graphics.drawable.Drawable JWwWuYbGVXfpNxzb(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lf
        L4:
            android.graphics.drawable.Drawable r0 = r1.getCurrentDrawable()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void JWwWuYbGVXfpNxzb(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, bool r2, java.lang.string r3, int r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L17
        La:
            r0 = 42
            goto L1d
        L10:
            goto L27
        L13:
            goto La
        L17:
            int r3 = r2 + r1
            goto L2b
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L23:
            goto L13
        L26:
            return
        L27:
            goto L23
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void JWwWuYbGVXfpNxzb(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, float r2, bool r3, java.lang.string r4) {
            goto L4
        L4:
            goto L1e
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L11
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L17:
            int r2 = r0 * r1
            goto L27
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            int r3 = r2 + r1
            goto L22
        L2d:
            goto L7
    }

    public static void JWwWuYbGVXfpNxzb(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, float r2, java.lang.string r3, int r4) {
            goto La
        L4:
            r0 = 42
            goto L21
        La:
            goto L1d
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            int r2 = r0 * r1
            goto L27
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L27:
            int r3 = r2 + r1
            goto L11
        L2d:
            goto Ld
    }

    public static void JiTbeplQtSZQjWoF(android.graphics.drawable.Drawable r0) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.invalidateSelf()
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void JiTbeplQtSZQjWoF(android.graphics.drawable.Drawable r0, byte r1, short r2, float r3, java.lang.string r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto Ld
        La:
            goto L26
        Ld:
            double r0 = (double) r3
            goto L1e
        L12:
            int r2 = r0 * r1
            goto L4
        L18:
            r0 = 42
            goto L2a
        L1e:
            return
        L1f:
            goto La
        L23:
            goto L1f
        L26:
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
    }

    public static void JiTbeplQtSZQjWoF(android.graphics.drawable.Drawable r0, float r1, byte r2, java.lang.string r3, short r4) {
            goto L23
        L4:
            goto L26
        L7:
            int r3 = r2 + r1
            goto L13
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L13:
            double r0 = (double) r3
            goto L1e
        L18:
            int r2 = r0 * r1
            goto L7
        L1e:
            return
        L1f:
            goto L4
        L23:
            goto L1f
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto Ld
    }

    public static void JiTbeplQtSZQjWoF(android.graphics.drawable.Drawable r0, short r1, java.lang.string r2, float r3, byte r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            r0 = 42
            goto L12
        Lf:
            goto L2c
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L18:
            return
        L19:
            goto Lf
        L1d:
            int r3 = r2 + r1
            goto L4
        L23:
            int r2 = r0 * r1
            goto L1d
        L29:
            goto L19
        L2c:
            goto L9
    }

    public static com.google.android.material.progressindicator.DrawingDelegate JniZBscvbdisrggg(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.material.progressindicator.DrawingDelegate r0 = r1.getCurrentDrawingDelegate()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void JniZBscvbdisrggg(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, bool r2, int r3, char r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto Lf
        La:
            return
        Lb:
            goto L20
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            int r2 = r0 * r1
            goto L4
        L1a:
            r0 = 42
            goto L2a
        L20:
            goto L26
        L23:
            goto Lb
        L26:
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    public static void JniZBscvbdisrggg(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, bool r2, byte r3, int r4) {
            goto L14
        L4:
            int r2 = r0 * r1
            goto L1b
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L27
        L14:
            goto L10
        L17:
            goto L21
        L1b:
            int r3 = r2 + r1
            goto La
        L21:
            r0 = 42
            goto L2a
        L27:
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void JniZBscvbdisrggg(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, byte r2, char r3, int r4) {
            goto L4
        L4:
            goto L20
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L24
        L11:
            int r3 = r2 + r1
            goto L1a
        L17:
            goto L7
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L17
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L11
    }

    public static void KAeuZOoyDGluCGjE(com.google.android.material.progressindicator.IndeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.registerAnimationCallback(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void KAeuZOoyDGluCGjE(com.google.android.material.progressindicator.IndeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, float r2, char r3, byte r4, short r5) {
            goto L24
        L4:
            goto L27
        L7:
            int r3 = r2 + r1
            goto L19
        Ld:
            r0 = 42
            goto L1e
        L13:
            int r2 = r0 * r1
            goto L7
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L24:
            goto L2c
        L27:
            goto Ld
        L2b:
            return
        L2c:
            goto L4
    }

    public static void KAeuZOoyDGluCGjE(com.google.android.material.progressindicator.IndeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, float r2, short r3, char r4, byte r5) {
            goto L4
        L4:
            goto L26
        L7:
            goto L2a
        Lb:
            int r2 = r0 * r1
            goto L1a
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L17:
            goto L7
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L17
        L2a:
            r0 = 42
            goto L11
    }

    public static void KAeuZOoyDGluCGjE(com.google.android.material.progressindicator.IndeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, short r2, byte r3, float r4, char r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto L2a
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L14:
            return
        L15:
            goto L4
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            int r2 = r0 * r1
            goto L1e
        L2a:
            r0 = 42
            goto Le
    }

    public static void KJsRebSfbwYKCEYA(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, char r1, int r2, java.lang.string r3, bool r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L24
        La:
            r0 = 42
            goto L15
        L10:
            return
        L11:
            goto L21
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L1b:
            int r2 = r0 * r1
            goto L4
        L21:
            goto L2c
        L24:
            double r0 = (double) r3
            goto L10
        L29:
            goto L11
        L2c:
            goto La
    }

    public static void KJsRebSfbwYKCEYA(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, int r1, java.lang.string r2, bool r3, char r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L16
        L9:
            int r2 = r0 * r1
            goto L24
        Lf:
            goto L17
        L12:
            goto L1e
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L12
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void KJsRebSfbwYKCEYA(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, bool r1, java.lang.string r2, char r3, int r4) {
            goto L4
        L4:
            goto L20
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L24
        L11:
            goto L7
        L14:
            int r3 = r2 + r1
            goto L1a
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L11
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L14
    }

    public static bool KJsRebSfbwYKCEYA(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            bool r0 = r1.hideNow()
            goto L7
    }

    public static void KPMyaohtWtrdEKgH(android.graphics.Canvas r0, int r1, int r2, int r3, int r4, char r5, byte r6, float r7, int r8) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L25
        L10:
            return
        L11:
            goto L1b
        L15:
            r0 = 42
            goto L4
        L1b:
            goto L21
        L1e:
            goto L11
        L21:
            goto L15
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void KPMyaohtWtrdEKgH(android.graphics.Canvas r0, int r1, int r2, int r3, int r4, char r5, int r6, float r7, byte r8) {
            goto L18
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        La:
            goto L1b
        Ld:
            double r0 = (double) r3
            goto L1f
        L12:
            int r2 = r0 * r1
            goto L24
        L18:
            goto L20
        L1b:
            goto L2a
        L1f:
            return
        L20:
            goto La
        L24:
            int r3 = r2 + r1
            goto Ld
        L2a:
            r0 = 42
            goto L4
    }

    public static void KPMyaohtWtrdEKgH(android.graphics.Canvas r0, int r1, int r2, int r3, int r4, float r5, byte r6, char r7, int r8) {
            goto L4
        L4:
            goto L20
        L7:
            goto L19
        Lb:
            int r3 = r2 + r1
            goto L14
        L11:
            goto L7
        L14:
            double r0 = (double) r3
            goto L1f
        L19:
            r0 = 42
            goto L24
        L1f:
            return
        L20:
            goto L11
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto Lb
    }

    public static bool KPMyaohtWtrdEKgH(android.graphics.Canvas r1, int r2, int r3, int r4, int r5) {
            goto L14
        L4:
            bool r0 = r1.clipRect(r2, r3, r4, r5)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable KWFQEVauzVZtvgAh(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            goto L17
        L7:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void KWFQEVauzVZtvgAh(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, char r2, java.lang.string r3, bool r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L27
        La:
            goto L1a
        Le:
            int r3 = r2 + r1
            goto L2b
        L14:
            int r2 = r0 * r1
            goto Le
        L1a:
            r0 = 42
            goto L20
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L26:
            return
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void KWFQEVauzVZtvgAh(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, java.lang.string r2, char r3, short r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        La:
            goto L12
        Ld:
            goto L2a
        L11:
            return
        L12:
            goto L16
        L16:
            goto Ld
        L19:
            int r2 = r0 * r1
            goto L24
        L1f:
            double r0 = (double) r3
            goto L11
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r0 = 42
            goto L4
    }

    public static void KWFQEVauzVZtvgAh(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, short r2, java.lang.string r3, char r4) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L25
        Le:
            return
        Lf:
            goto L4
        L13:
            int r3 = r2 + r1
            goto L2b
        L19:
            int r2 = r0 * r1
            goto L13
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            r0 = 42
            goto L1f
        L2b:
            double r0 = (double) r3
            goto Le
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable KvAoYGLiUTQAxbWc(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lc
        L4:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void KvAoYGLiUTQAxbWc(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, short r2, java.lang.string r3, bool r4) {
            goto L16
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L1d
        L10:
            r0 = 42
            goto L22
        L16:
            goto L29
        L19:
            goto L10
        L1d:
            double r0 = (double) r3
            goto L28
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L19
    }

    public static void KvAoYGLiUTQAxbWc(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, int r2, java.lang.string r3, short r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L11
        La:
            goto L20
        Ld:
            goto L24
        L11:
            double r0 = (double) r3
            goto L1f
        L16:
            int r2 = r0 * r1
            goto L4
        L1c:
            goto Ld
        L1f:
            return
        L20:
            goto L1c
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
    }

    public static void KvAoYGLiUTQAxbWc(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, short r2, int r3, java.lang.string r4) {
            goto L18
        L4:
            return
        L5:
            goto L15
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r3 = r2 + r1
            goto L25
        L15:
            goto L1b
        L18:
            goto L5
        L1b:
            goto L9
        L1f:
            int r2 = r0 * r1
            goto Lf
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static com.google.android.material.progressindicator.IndeterminateAnimatorDelegate LelmLDvryjpisrGw(com.google.android.material.progressindicator.IndeterminateDrawable r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0 = r1.getAnimatorDelegate()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void LelmLDvryjpisrGw(com.google.android.material.progressindicator.IndeterminateDrawable r0, byte r1, bool r2, java.lang.string r3, short r4) {
            goto L12
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            goto L15
        Lc:
            int r3 = r2 + r1
            goto L4
        L12:
            goto L20
        L15:
            goto L2a
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L1f:
            return
        L20:
            goto L9
        L24:
            int r2 = r0 * r1
            goto Lc
        L2a:
            r0 = 42
            goto L19
    }

    public static void LelmLDvryjpisrGw(com.google.android.material.progressindicator.IndeterminateDrawable r0, java.lang.string r1, short r2, byte r3, bool r4) {
            goto L17
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L1a
        L17:
            goto L10
        L1a:
            goto L1e
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void LelmLDvryjpisrGw(com.google.android.material.progressindicator.IndeterminateDrawable r0, java.lang.string r1, short r2, bool r3, byte r4) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L18
        Le:
            return
        Lf:
            goto L4
        L13:
            double r0 = (double) r3
            goto Le
        L18:
            r0 = 42
            goto L2a
        L1e:
            int r3 = r2 + r1
            goto L13
        L24:
            int r2 = r0 * r1
            goto L1e
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable LrvKRURzCvRytPVD(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void LrvKRURzCvRytPVD(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, int r2, char r3, java.lang.string r4) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto L15
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            return
        L11:
            goto L22
        L15:
            int r3 = r2 + r1
            goto L25
        L1b:
            goto L11
        L1e:
            goto L2a
        L22:
            goto L1e
        L25:
            double r0 = (double) r3
            goto L10
        L2a:
            r0 = 42
            goto La
    }

    public static void LrvKRURzCvRytPVD(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, char r2, byte r3, java.lang.string r4) {
            goto L19
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            r0 = 42
            goto La
        L16:
            goto L1c
        L19:
            goto L2c
        L1c:
            goto L10
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r3 = r2 + r1
            goto L20
        L2b:
            return
        L2c:
            goto L16
    }

    public static void LrvKRURzCvRytPVD(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, char r2, byte r3, int r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        La:
            goto L2c
        Ld:
            double r0 = (double) r3
            goto L1e
        L12:
            int r2 = r0 * r1
            goto L23
        L18:
            r0 = 42
            goto L4
        L1e:
            return
        L1f:
            goto La
        L23:
            int r3 = r2 + r1
            goto Ld
        L29:
            goto L1f
        L2c:
            goto L18
    }

    public static void LtFvHSBPKexCrHcq(android.content.res.TypedArray r0) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.recycle()
            goto L4
    }

    public static void LtFvHSBPKexCrHcq(android.content.res.TypedArray r0, int r1, java.lang.string r2, short r3, char r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L11
        La:
            goto L17
        Ld:
            goto L1b
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L27
        L1b:
            r0 = 42
            goto L21
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L27:
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void LtFvHSBPKexCrHcq(android.content.res.TypedArray r0, java.lang.string r1, short r2, char r3, int r4) {
            goto L10
        L4:
            r0 = 42
            goto L1a
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            goto L27
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L20:
            int r2 = r0 * r1
            goto La
        L26:
            return
        L27:
            goto L17
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void LtFvHSBPKexCrHcq(android.content.res.TypedArray r0, short r1, char r2, int r3, java.lang.string r4) {
            goto L29
        L4:
            goto L2c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        Ld:
            return
        Le:
            goto L4
        L12:
            int r3 = r2 + r1
            goto L24
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            r0 = 42
            goto L7
        L24:
            double r0 = (double) r3
            goto Ld
        L29:
            goto Le
        L2c:
            goto L1e
    }

    public static long MOKrTyKoZDIWflLP() {
            goto L11
        L4:
            int r0 = r0 % r1
            goto L43
        La:
            goto L32
        Ld:
            goto L1b
        L11:
            goto L3f
        L14:
            goto L23
        L18:
            goto L14
        L1b:
            long r0 = android.os.SystemClock.uptimeMillis()
            goto L31
        L23:
            r0 = 18
            goto L2a
        L2a:
            r1 = 25
            goto L36
        L31:
            return r0
        L32:
            goto L3c
        L36:
            int r0 = r0 + r1
            goto L4
        L3c:
            goto Ld
        L3f:
            goto L18
        L43:
            if (r0 <= 0) goto L48
            goto Ld
        L48:
            goto La
    }

    public static void MOKrTyKoZDIWflLP(int r0, byte r1, java.lang.string r2, short r3) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L10:
            goto L1e
        L13:
            goto L4
        L17:
            int r3 = r2 + r1
            goto L28
        L1d:
            return
        L1e:
            goto L2d
        L22:
            int r2 = r0 * r1
            goto L17
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto L13
    }

    public static void MOKrTyKoZDIWflLP(int r0, byte r1, short r2, java.lang.string r3) {
            goto L17
        L4:
            goto L1a
        L7:
            double r0 = (double) r3
            goto L12
        Lc:
            int r3 = r2 + r1
            goto L7
        L12:
            return
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            goto L2a
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto Lc
        L2a:
            r0 = 42
            goto L1e
    }

    public static void MOKrTyKoZDIWflLP(java.lang.string r0, short r1, byte r2, int r3) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L1e
        Ld:
            goto L15
        L10:
            goto L24
        L14:
            return
        L15:
            goto L4
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
    }

    public static void MpZfWAtQfISDOpTm(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, long r2, float r4, java.lang.string r5, int r6, short r7) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L17
        La:
            goto L24
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L1d
        L17:
            int r3 = r2 + r1
            goto L28
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L23:
            return
        L24:
            goto L2d
        L28:
            double r0 = (double) r3
            goto L23
        L2d:
            goto Ld
    }

    public static void MpZfWAtQfISDOpTm(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, long r2, int r4, float r5, java.lang.string r6, short r7) {
            goto L4
        L4:
            goto L2c
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L19
        L11:
            goto L7
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L14
        L2b:
            return
        L2c:
            goto L11
    }

    public static void MpZfWAtQfISDOpTm(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, long r2, short r4, int r5, float r6, java.lang.string r7) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L10:
            goto L1e
        L13:
            goto L4
        L17:
            int r2 = r0 * r1
            goto L22
        L1d:
            return
        L1e:
            goto L2d
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto L13
    }

    public static bool MpZfWAtQfISDOpTm(com.google.android.material.progressindicator.BaseProgressIndicator r1, java.lang.Action r2, long r3) {
            goto Lc
        L4:
            bool r0 = r1.postDelayed(r2, r3)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void NLuHoeDcFmUKhXVx(android.widget.ProgressBar r0) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            super.onDetachedFromWindow()
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void NLuHoeDcFmUKhXVx(android.widget.ProgressBar r0, char r1, bool r2, int r3, short r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L17
        Ld:
            goto L24
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L21
        L1b:
            int r3 = r2 + r1
            goto L11
        L21:
            goto Ld
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1b
    }

    public static void NLuHoeDcFmUKhXVx(android.widget.ProgressBar r0, short r1, bool r2, int r3, char r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L28
        L9:
            goto L29
        Lc:
            goto L16
        L10:
            int r3 = r2 + r1
            goto L4
        L16:
            r0 = 42
            goto L1c
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L22:
            int r2 = r0 * r1
            goto L10
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Lc
    }

    public static void NLuHoeDcFmUKhXVx(android.widget.ProgressBar r0, bool r1, short r2, int r3, char r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L2b
        L10:
            r0 = 42
            goto L19
        L16:
            goto L7
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1f:
            int r3 = r2 + r1
            goto Lb
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            return
        L2c:
            goto L16
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable NgMwktZZAQYodYPi(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void NgMwktZZAQYodYPi(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2, short r3, java.lang.string r4) {
            goto L29
        L4:
            goto L2c
        L7:
            int r2 = r0 * r1
            goto L1d
        Ld:
            return
        Le:
            goto L4
        L12:
            r0 = 42
            goto L23
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L29:
            goto Le
        L2c:
            goto L12
    }

    public static void NgMwktZZAQYodYPi(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, bool r2, short r3, int r4) {
            goto L24
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r0 = 42
            goto L1e
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            int r2 = r0 * r1
            goto Lf
        L1b:
            goto L27
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L24:
            goto L2c
        L27:
            goto L9
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void NgMwktZZAQYodYPi(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, bool r2, int r3, java.lang.string r4) {
            goto L24
        L4:
            goto L27
        L7:
            int r2 = r0 * r1
            goto L12
        Ld:
            double r0 = (double) r3
            goto L2b
        L12:
            int r3 = r2 + r1
            goto Ld
        L18:
            r0 = 42
            goto L1e
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L24:
            goto L2c
        L27:
            goto L18
        L2b:
            return
        L2c:
            goto L4
    }

    public static void OWOxCptDBlqjQjQg(android.widget.ProgressBar r0, bool r1) {
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
            super.setIndeterminate(r1)
            goto L4
    }

    public static void OWOxCptDBlqjQjQg(android.widget.ProgressBar r0, bool r1, float r2, short r3, int r4, java.lang.string r5) {
            goto L9
        L4:
            return
        L5:
            goto L27
        L9:
            goto L5
        Lc:
            goto L15
        L10:
            double r0 = (double) r3
            goto L4
        L15:
            r0 = 42
            goto L21
        L1b:
            int r3 = r2 + r1
            goto L10
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L27:
            goto Lc
        L2a:
            int r2 = r0 * r1
            goto L1b
    }

    public static void OWOxCptDBlqjQjQg(android.widget.ProgressBar r0, bool r1, java.lang.string r2, float r3, short r4, int r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L10
        L9:
            goto L11
        Lc:
            goto L1b
        L10:
            return
        L11:
            goto L2d
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L1b:
            r0 = 42
            goto L15
        L21:
            int r2 = r0 * r1
            goto L27
        L27:
            int r3 = r2 + r1
            goto L4
        L2d:
            goto Lc
    }

    public static void OWOxCptDBlqjQjQg(android.widget.ProgressBar r0, bool r1, short r2, int r3, java.lang.string r4, float r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            r0 = 42
            goto L23
        L10:
            goto L2c
        L13:
            double r0 = (double) r3
            goto L18
        L18:
            return
        L19:
            goto L10
        L1d:
            int r3 = r2 + r1
            goto L13
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto L19
        L2c:
            goto La
    }

    public static void PAtLDXqCOWjArzIE(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, bool r1, bool r2, bool r3, byte r4, char r5, float r6, int r7) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L19
        Lb:
            return
        Lc:
            goto L16
        L10:
            int r2 = r0 * r1
            goto L1f
        L16:
            goto L7
        L19:
            r0 = 42
            goto L2a
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto Lb
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
    }

    public static void PAtLDXqCOWjArzIE(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, bool r1, bool r2, bool r3, float r4, int r5, byte r6, char r7) {
            goto L14
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L1b
        Le:
            int r2 = r0 * r1
            goto L24
        L14:
            goto La
        L17:
            goto L1e
        L1b:
            goto L17
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
    }

    public static void PAtLDXqCOWjArzIE(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, bool r1, bool r2, bool r3, int r4, byte r5, char r6, float r7) {
            goto L20
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            double r0 = (double) r3
            goto L1b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            r0 = 42
            goto Lf
        L1b:
            return
        L1c:
            goto L27
        L20:
            goto L1c
        L23:
            goto L15
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static bool PAtLDXqCOWjArzIE(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r1, bool r2, bool r3, bool r4) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.setVisible(r2, r3, r4)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static com.google.android.material.progressindicator.IndeterminateAnimatorDelegate PLhhrPvHmahaRDIi(com.google.android.material.progressindicator.IndeterminateDrawable r1) {
            goto L14
        L4:
            goto L17
        L7:
            com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0 = r1.getAnimatorDelegate()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void PLhhrPvHmahaRDIi(com.google.android.material.progressindicator.IndeterminateDrawable r0, char r1, byte r2, short r3, java.lang.string r4) {
            goto L18
        L4:
            goto L1b
        L7:
            int r2 = r0 * r1
            goto L1f
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L13:
            return
        L14:
            goto L4
        L18:
            goto L14
        L1b:
            goto L2a
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            r0 = 42
            goto Ld
    }

    public static void PLhhrPvHmahaRDIi(com.google.android.material.progressindicator.IndeterminateDrawable r0, char r1, java.lang.string r2, short r3, byte r4) {
            goto L19
        L4:
            goto L1c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L13
        L13:
            int r3 = r2 + r1
            goto L26
        L19:
            goto L2c
        L1c:
            goto L20
        L20:
            r0 = 42
            goto L7
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L4
    }

    public static void PLhhrPvHmahaRDIi(com.google.android.material.progressindicator.IndeterminateDrawable r0, java.lang.string r1, byte r2, short r3, char r4) {
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
            goto L24
        L13:
            int r3 = r2 + r1
            goto L1f
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            r0 = 42
            goto L19
        L2a:
            int r2 = r0 * r1
            goto L13
    }

    public static void POpdCKUFNWXzzJaM(com.google.android.material.progressindicator.IndeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, char r2, bool r3, int r4, short r5) {
            goto Le
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L15
        Le:
            goto La
        L11:
            goto L1e
        L15:
            goto L11
        L18:
            int r2 = r0 * r1
            goto L2a
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void POpdCKUFNWXzzJaM(com.google.android.material.progressindicator.IndeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, int r2, char r3, short r4, bool r5) {
            goto L4
        L4:
            goto L20
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L24
        L11:
            double r0 = (double) r3
            goto L1f
        L16:
            int r2 = r0 * r1
            goto L2a
        L1c:
            goto L7
        L1f:
            return
        L20:
            goto L1c
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static void POpdCKUFNWXzzJaM(com.google.android.material.progressindicator.IndeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, int r2, short r3, bool r4, char r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L18
        Lb:
            return
        Lc:
            goto L15
        L10:
            double r0 = (double) r3
            goto Lb
        L15:
            goto L7
        L18:
            r0 = 42
            goto L1e
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static bool POpdCKUFNWXzzJaM(com.google.android.material.progressindicator.IndeterminateDrawable r1, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            bool r0 = r1.unregisterAnimationCallback(r2)
            goto L4
    }

    public static void QBVeCtubQplkwALW(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.invalidate()
            goto L4
        L17:
            goto Lc
    }

    public static void QBVeCtubQplkwALW(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, byte r2, short r3, float r4) {
            goto L12
        L4:
            goto L15
        L7:
            r0 = 42
            goto L1f
        Ld:
            double r0 = (double) r3
            goto L25
        L12:
            goto L26
        L15:
            goto L7
        L19:
            int r3 = r2 + r1
            goto Ld
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            return
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static void QBVeCtubQplkwALW(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, byte r2, short r3, char r4) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L1f
        L10:
            goto Lc
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L19:
            int r2 = r0 * r1
            goto L25
        L1f:
            r0 = 42
            goto L13
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void QBVeCtubQplkwALW(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, char r2, byte r3, float r4) {
            goto L29
        L4:
            goto L2c
        L7:
            int r3 = r2 + r1
            goto L13
        Ld:
            r0 = 42
            goto L1d
        L13:
            double r0 = (double) r3
            goto L18
        L18:
            return
        L19:
            goto L4
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L23:
            int r2 = r0 * r1
            goto L7
        L29:
            goto L19
        L2c:
            goto Ld
    }

    public static void QNjnSKGPPjzCzwLw(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, long r2, float r4, int r5, char r6, short r7) {
            goto L29
        L4:
            r0 = 42
            goto L20
        La:
            int r2 = r0 * r1
            goto L15
        L10:
            double r0 = (double) r3
            goto L1b
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            return
        L1c:
            goto L26
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L26:
            goto L2c
        L29:
            goto L1c
        L2c:
            goto L4
    }

    public static void QNjnSKGPPjzCzwLw(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, long r2, int r4, short r5, char r6, float r7) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            goto L21
        L13:
            r0 = 42
            goto La
        L19:
            return
        L1a:
            goto L10
        L1e:
            goto L1a
        L21:
            goto L13
        L25:
            double r0 = (double) r3
            goto L19
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void QNjnSKGPPjzCzwLw(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, long r2, short r4, int r5, float r6, char r7) {
            goto L12
        L4:
            goto L15
        L7:
            int r2 = r0 * r1
            goto L19
        Ld:
            double r0 = (double) r3
            goto L2b
        L12:
            goto L2c
        L15:
            goto L25
        L19:
            int r3 = r2 + r1
            goto Ld
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L25:
            r0 = 42
            goto L1f
        L2b:
            return
        L2c:
            goto L4
    }

    public static bool QNjnSKGPPjzCzwLw(com.google.android.material.progressindicator.BaseProgressIndicator r1, java.lang.Action r2, long r3) {
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
            bool r0 = r1.postDelayed(r2, r3)
            goto Le
    }

    public static void QRPLWfwIZxkExnbe(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, char r2, java.lang.string r3, short r4) {
            goto L9
        L4:
            return
        L5:
            goto L2d
        L9:
            goto L5
        Lc:
            goto L27
        L10:
            double r0 = (double) r3
            goto L4
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L1b:
            int r3 = r2 + r1
            goto L10
        L21:
            int r2 = r0 * r1
            goto L1b
        L27:
            r0 = 42
            goto L15
        L2d:
            goto Lc
    }

    public static void QRPLWfwIZxkExnbe(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, char r2, short r3, java.lang.string r4) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            goto L27
        Ld:
            return
        Le:
            goto La
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            r0 = 42
            goto L4
        L24:
            goto Le
        L27:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void QRPLWfwIZxkExnbe(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, java.lang.string r2, char r3, float r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            goto L12
        Ld:
            goto L22
        L11:
            return
        L12:
            goto L28
        L16:
            int r3 = r2 + r1
            goto L2b
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L22:
            r0 = 42
            goto L1c
        L28:
            goto Ld
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static bool QRPLWfwIZxkExnbe(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.visibleToUser()
            goto L4
        L18:
            goto Lc
    }

    public static void QVNpmwlcoqlmoqOz(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, char r2, bool r3, short r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L14
        La:
            goto L20
        Ld:
            goto L24
        L11:
            goto Ld
        L14:
            double r0 = (double) r3
            goto L1f
        L19:
            int r2 = r0 * r1
            goto L4
        L1f:
            return
        L20:
            goto L11
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
    }

    public static void QVNpmwlcoqlmoqOz(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, bool r2, short r3, byte r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L18
        La:
            goto L26
        Ld:
            int r2 = r0 * r1
            goto L4
        L13:
            return
        L14:
            goto La
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L23:
            goto L14
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L1d
    }

    public static void QVNpmwlcoqlmoqOz(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, byte r2, char r3, bool r4) {
            goto L26
        L4:
            r0 = 42
            goto L20
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L1b
        L15:
            int r2 = r0 * r1
            goto La
        L1b:
            return
        L1c:
            goto L2d
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L26:
            goto L1c
        L29:
            goto L4
        L2d:
            goto L29
    }

    public static bool QVNpmwlcoqlmoqOz(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            bool r0 = r1.isEffectivelyVisible()
            goto Lb
    }

    public static void QhbIRwvzYfNtWhCs(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L13
        L4:
            r0.internalHide()
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

    public static void QhbIRwvzYfNtWhCs(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, int r2, bool r3, short r4) {
            goto L1d
        L4:
            r0 = 42
            goto L2a
        La:
            int r3 = r2 + r1
            goto L18
        L10:
            goto L20
        L13:
            return
        L14:
            goto L10
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            goto L14
        L20:
            goto L4
        L24:
            int r2 = r0 * r1
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void QhbIRwvzYfNtWhCs(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, bool r2, int r3, java.lang.string r4) {
            goto L26
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            return
        Lb:
            goto L2d
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            int r2 = r0 * r1
            goto L4
        L20:
            r0 = 42
            goto Lf
        L26:
            goto Lb
        L29:
            goto L20
        L2d:
            goto L29
    }

    public static void QhbIRwvzYfNtWhCs(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, int r2, short r3, java.lang.string r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L14
        La:
            goto L1b
        Ld:
            goto L1f
        L11:
            goto Ld
        L14:
            int r3 = r2 + r1
            goto L25
        L1a:
            return
        L1b:
            goto L11
        L1f:
            r0 = 42
            goto L2a
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void QktExZxUReAtADqE(android.widget.ProgressBar r0, int r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            super.setProgress(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void QktExZxUReAtADqE(android.widget.ProgressBar r0, int r1, char r2, byte r3, bool r4, float r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L26
        Le:
            int r2 = r0 * r1
            goto L14
        L14:
            int r3 = r2 + r1
            goto L4
        L1a:
            r0 = 42
            goto L20
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L26:
            goto L2c
        L29:
            goto La
        L2c:
            goto L1a
    }

    public static void QktExZxUReAtADqE(android.widget.ProgressBar r0, int r1, char r2, float r3, bool r4, byte r5) {
            goto L9
        L4:
            return
        L5:
            goto L1c
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L16
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1c:
            goto Lc
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void QktExZxUReAtADqE(android.widget.ProgressBar r0, int r1, float r2, byte r3, char r4, bool r5) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            return
        Lb:
            goto L15
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            goto L21
        L18:
            r0 = 42
            goto L25
        L1e:
            goto Lb
        L21:
            goto L18
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable QtwmEHgFongMyeKn(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
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
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L4
    }

    public static void QtwmEHgFongMyeKn(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, java.lang.string r2, bool r3, int r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            int r2 = r0 * r1
            goto L16
        Lf:
            goto L1d
        L12:
            goto L2a
        L16:
            int r3 = r2 + r1
            goto L4
        L1c:
            return
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L27:
            goto L12
        L2a:
            r0 = 42
            goto L21
    }

    public static void QtwmEHgFongMyeKn(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, byte r2, bool r3, java.lang.string r4) {
            goto L4
        L4:
            goto L15
        L7:
            goto L24
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L11:
            goto L7
        L14:
            return
        L15:
            goto L11
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L14
        L24:
            r0 = 42
            goto Lb
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static void QtwmEHgFongMyeKn(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, byte r2, int r3, bool r4) {
            goto L29
        L4:
            r0 = 42
            goto L12
        La:
            double r0 = (double) r3
            goto L1e
        Lf:
            goto L2c
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L18:
            int r2 = r0 * r1
            goto L23
        L1e:
            return
        L1f:
            goto Lf
        L23:
            int r3 = r2 + r1
            goto La
        L29:
            goto L1f
        L2c:
            goto L4
    }

    public static android.graphics.drawable.Drawable RBwxMNxEOCgPaKIC(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            android.graphics.drawable.Drawable r0 = r1.getCurrentDrawable()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void RBwxMNxEOCgPaKIC(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, short r2, float r3, bool r4) {
            goto L14
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r0 = 42
            goto L21
        Lf:
            return
        L10:
            goto L27
        L14:
            goto L10
        L17:
            goto L9
        L1b:
            int r2 = r0 * r1
            goto L2a
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L27:
            goto L17
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void RBwxMNxEOCgPaKIC(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, java.lang.string r2, float r3, bool r4) {
            goto L29
        L4:
            r0 = 42
            goto L18
        La:
            goto L2c
        Ld:
            int r3 = r2 + r1
            goto L13
        L13:
            double r0 = (double) r3
            goto L24
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1e:
            int r2 = r0 * r1
            goto Ld
        L24:
            return
        L25:
            goto La
        L29:
            goto L25
        L2c:
            goto L4
    }

    public static void RBwxMNxEOCgPaKIC(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, java.lang.string r2, short r3, float r4) {
            goto L1c
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L10:
            int r3 = r2 + r1
            goto L23
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            goto L29
        L1f:
            goto L4
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1f
    }

    public static android.graphics.drawable.Drawable RJnpUHqAjDHexFlR(android.widget.ProgressBar r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            android.graphics.drawable.Drawable r0 = super.getIndeterminateDrawable()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void RJnpUHqAjDHexFlR(android.widget.ProgressBar r0, byte r1, int r2, float r3, java.lang.string r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L18
        La:
            r0 = 42
            goto L23
        L10:
            double r0 = (double) r3
            goto L1e
        L15:
            goto L2c
        L18:
            int r3 = r2 + r1
            goto L10
        L1e:
            return
        L1f:
            goto L15
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto L1f
        L2c:
            goto La
    }

    public static void RJnpUHqAjDHexFlR(android.widget.ProgressBar r0, float r1, int r2, byte r3, java.lang.string r4) {
            goto L13
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            goto L16
        Ld:
            int r2 = r0 * r1
            goto L4
        L13:
            goto L21
        L16:
            goto L1a
        L1a:
            r0 = 42
            goto L2a
        L20:
            return
        L21:
            goto La
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
    }

    public static void RJnpUHqAjDHexFlR(android.widget.ProgressBar r0, int r1, float r2, java.lang.string r3, byte r4) {
            goto L17
        L4:
            goto L1a
        L7:
            double r0 = (double) r3
            goto L12
        Lc:
            int r3 = r2 + r1
            goto L7
        L12:
            return
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            goto L2a
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto Lc
        L2a:
            r0 = 42
            goto L1e
    }

    public static void RTSqHpIyQLgKaFTu(android.graphics.drawable.Drawable r0, android.graphics.Canvas r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.draw(r1)
            goto L4
        L17:
            goto Lc
    }

    public static void RTSqHpIyQLgKaFTu(android.graphics.drawable.Drawable r0, android.graphics.Canvas r1, bool r2, byte r3, float r4, java.lang.string r5) {
            goto L20
        L4:
            r0 = 42
            goto L27
        La:
            int r3 = r2 + r1
            goto L15
        L10:
            return
        L11:
            goto L2d
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            int r2 = r0 * r1
            goto La
        L20:
            goto L11
        L23:
            goto L4
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L2d:
            goto L23
    }

    public static void RTSqHpIyQLgKaFTu(android.graphics.drawable.Drawable r0, android.graphics.Canvas r1, bool r2, float r3, java.lang.string r4, byte r5) {
            goto L18
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r0 = 42
            goto L24
        L10:
            double r0 = (double) r3
            goto L1f
        L15:
            goto L1b
        L18:
            goto L20
        L1b:
            goto La
        L1f:
            return
        L20:
            goto L15
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void RTSqHpIyQLgKaFTu(android.graphics.drawable.Drawable r0, android.graphics.Canvas r1, bool r2, java.lang.string r3, byte r4, float r5) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            goto L23
        L12:
            goto L2a
        L16:
            int r3 = r2 + r1
            goto La
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L22:
            return
        L23:
            goto L27
        L27:
            goto L12
        L2a:
            r0 = 42
            goto L1c
    }

    public static void RXORYeAeMuKTiwzO(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, java.lang.string r2, char r3, float r4) {
            goto L24
        L4:
            int r2 = r0 * r1
            goto L13
        La:
            goto L27
        Ld:
            r0 = 42
            goto L19
        L13:
            int r3 = r2 + r1
            goto L2b
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1f:
            return
        L20:
            goto La
        L24:
            goto L20
        L27:
            goto Ld
        L2b:
            double r0 = (double) r3
            goto L1f
    }

    public static void RXORYeAeMuKTiwzO(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, char r2, float r3, int r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L21
        La:
            goto Le
        Le:
            r0 = 42
            goto L2a
        L14:
            int r2 = r0 * r1
            goto L1a
        L1a:
            int r3 = r2 + r1
            goto L25
        L20:
            return
        L21:
            goto L4
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    public static void RXORYeAeMuKTiwzO(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, int r2, float r3, char r4) {
            goto L19
        L4:
            r0 = 42
            goto L2a
        La:
            int r3 = r2 + r1
            goto L25
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            goto L1c
        L19:
            goto L21
        L1c:
            goto L4
        L20:
            return
        L21:
            goto L16
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
    }

    public static bool RXORYeAeMuKTiwzO(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.isIndeterminate()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static int RuvIINUSjmYNRsVU(int r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = getDefaultSize(r1, r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void RuvIINUSjmYNRsVU(int r0, int r1, short r2, byte r3, bool r4, float r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L2c
        Lc:
            goto L1c
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L22
        L1c:
            r0 = 42
            goto L10
        L22:
            int r3 = r2 + r1
            goto L4
        L28:
            goto Lc
        L2b:
            return
        L2c:
            goto L28
    }

    public static void RuvIINUSjmYNRsVU(int r0, int r1, short r2, bool r3, byte r4, float r5) {
            goto L4
        L4:
            goto L12
        L7:
            goto L2a
        Lb:
            int r3 = r2 + r1
            goto L16
        L11:
            return
        L12:
            goto L21
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            int r2 = r0 * r1
            goto Lb
        L21:
            goto L7
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L2a:
            r0 = 42
            goto L24
    }

    public static void RuvIINUSjmYNRsVU(int r0, int r1, bool r2, byte r3, float r4, short r5) {
            goto L15
        L4:
            r0 = 42
            goto L21
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L1c
        L15:
            goto L1d
        L18:
            goto L4
        L1c:
            return
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L27:
            goto L18
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void STRAnHtijctUvjTg(com.google.android.material.progressindicator.DeterminateDrawable r0) {
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
            r0.jumpToCurrentState()
            goto L4
    }

    public static void STRAnHtijctUvjTg(com.google.android.material.progressindicator.DeterminateDrawable r0, float r1, short r2, java.lang.string r3, char r4) {
            goto L1b
        L4:
            r0 = 42
            goto L15
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1b:
            goto L26
        L1e:
            goto L4
        L22:
            goto L1e
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void STRAnHtijctUvjTg(com.google.android.material.progressindicator.DeterminateDrawable r0, java.lang.string r1, float r2, char r3, short r4) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L1b
        L12:
            int r2 = r0 * r1
            goto L4
        L18:
            goto Lb
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto L2a
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
    }

    public static void STRAnHtijctUvjTg(com.google.android.material.progressindicator.DeterminateDrawable r0, java.lang.string r1, short r2, char r3, float r4) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            r0 = 42
            goto L2a
        Lf:
            goto L21
        L12:
            int r2 = r0 * r1
            goto L18
        L18:
            int r3 = r2 + r1
            goto L4
        L1e:
            goto L26
        L21:
            goto L9
        L25:
            return
        L26:
            goto Lf
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
    }

    public static void SYSRIkyIcPngzqBs(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.requestLayout()
            goto Le
    }

    public static void SYSRIkyIcPngzqBs(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, java.lang.string r2, bool r3, short r4) {
            goto L1e
        L4:
            goto L21
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        Ld:
            r0 = 42
            goto L7
        L13:
            int r2 = r0 * r1
            goto L2a
        L19:
            return
        L1a:
            goto L4
        L1e:
            goto L1a
        L21:
            goto Ld
        L25:
            double r0 = (double) r3
            goto L19
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void SYSRIkyIcPngzqBs(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, short r2, bool r3, byte r4) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L19
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L19:
            r0 = 42
            goto L13
        L1f:
            double r0 = (double) r3
            goto Le
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void SYSRIkyIcPngzqBs(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, bool r2, byte r3, short r4) {
            goto L29
        L4:
            r0 = 42
            goto L1e
        La:
            int r3 = r2 + r1
            goto L24
        L10:
            return
        L11:
            goto L1b
        L15:
            int r2 = r0 * r1
            goto La
        L1b:
            goto L2c
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L24:
            double r0 = (double) r3
            goto L10
        L29:
            goto L11
        L2c:
            goto L4
    }

    public static int SiInCsqlIUfgaAjH(com.google.android.material.progressindicator.DrawingDelegate r1) {
            goto Lc
        L4:
            int r0 = r1.getPreferredWidth()
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

    public static void SiInCsqlIUfgaAjH(com.google.android.material.progressindicator.DrawingDelegate r0, byte r1, short r2, char r3, bool r4) {
            goto L24
        L4:
            int r2 = r0 * r1
            goto L1e
        La:
            goto L27
        Ld:
            return
        Le:
            goto La
        L12:
            r0 = 42
            goto L18
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1e:
            int r3 = r2 + r1
            goto L2b
        L24:
            goto Le
        L27:
            goto L12
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void SiInCsqlIUfgaAjH(com.google.android.material.progressindicator.DrawingDelegate r0, byte r1, bool r2, char r3, short r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L25
        Lb:
            goto L7
        Le:
            int r3 = r2 + r1
            goto L20
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L1a:
            int r2 = r0 * r1
            goto Le
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            r0 = 42
            goto L14
        L2b:
            return
        L2c:
            goto Lb
    }

    public static void SiInCsqlIUfgaAjH(com.google.android.material.progressindicator.DrawingDelegate r0, bool r1, char r2, byte r3, short r4) {
            goto La
        L4:
            r0 = 42
            goto L1e
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return
        L15:
            goto L11
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L19
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static int SkumJckPgaSOVCSx(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = r1.getPaddingRight()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void SkumJckPgaSOVCSx(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, java.lang.string r2, char r3, short r4) {
            goto La
        L4:
            r0 = 42
            goto L1b
        La:
            goto L17
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L21
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L21:
            goto Ld
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static void SkumJckPgaSOVCSx(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, float r2, short r3, char r4) {
            goto L24
        L4:
            r0 = 42
            goto L1e
        La:
            int r2 = r0 * r1
            goto L18
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L27
        L18:
            int r3 = r2 + r1
            goto L10
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L24:
            goto L2c
        L27:
            goto L4
        L2b:
            return
        L2c:
            goto L15
    }

    public static void SkumJckPgaSOVCSx(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, java.lang.string r2, float r3, char r4) {
            goto L12
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        Lf:
            goto L15
        L12:
            goto L26
        L15:
            goto L2a
        L19:
            int r3 = r2 + r1
            goto L4
        L1f:
            int r2 = r0 * r1
            goto L19
        L25:
            return
        L26:
            goto Lf
        L2a:
            r0 = 42
            goto L9
    }

    public static int SpJQEMaQBHTJSRrw(int r1, int r2) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = java.lang.Math.min(r1, r2)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void SpJQEMaQBHTJSRrw(int r0, int r1, byte r2, float r3, java.lang.string r4, bool r5) {
            goto L1d
        L4:
            goto L20
        L7:
            return
        L8:
            goto L4
        Lc:
            r0 = 42
            goto L2a
        L12:
            int r3 = r2 + r1
            goto L18
        L18:
            double r0 = (double) r3
            goto L7
        L1d:
            goto L8
        L20:
            goto Lc
        L24:
            int r2 = r0 * r1
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void SpJQEMaQBHTJSRrw(int r0, int r1, byte r2, float r3, bool r4, java.lang.string r5) {
            goto L18
        L4:
            goto L1b
        L7:
            r0 = 42
            goto Ld
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L13:
            double r0 = (double) r3
            goto L25
        L18:
            goto L26
        L1b:
            goto L7
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L13
    }

    public static void SpJQEMaQBHTJSRrw(int r0, int r1, float r2, byte r3, java.lang.string r4, bool r5) {
            goto L1e
        L4:
            goto L21
        L7:
            int r2 = r0 * r1
            goto L25
        Ld:
            return
        Le:
            goto L4
        L12:
            r0 = 42
            goto L18
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L1e:
            goto Le
        L21:
            goto L12
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static android.graphics.drawable.Drawable SpgNPdVHOgRdxZVT(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.graphics.drawable.Drawable r0 = r1.getCurrentDrawable()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void SpgNPdVHOgRdxZVT(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, float r2, short r3, bool r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L16
        L9:
            goto L17
        Lc:
            goto L27
        L10:
            int r3 = r2 + r1
            goto L4
        L16:
            return
        L17:
            goto L2d
        L1b:
            int r2 = r0 * r1
            goto L10
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L27:
            r0 = 42
            goto L21
        L2d:
            goto Lc
    }

    public static void SpgNPdVHOgRdxZVT(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, bool r2, short r3, float r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L16
        Lb:
            int r3 = r2 + r1
            goto L22
        L11:
            return
        L12:
            goto L2d
        L16:
            r0 = 42
            goto L27
        L1c:
            int r2 = r0 * r1
            goto Lb
        L22:
            double r0 = (double) r3
            goto L11
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L2d:
            goto L7
    }

    public static void SpgNPdVHOgRdxZVT(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, byte r2, bool r3, short r4) {
            goto L23
        L4:
            goto L26
        L7:
            return
        L8:
            goto L4
        Lc:
            double r0 = (double) r3
            goto L7
        L11:
            int r2 = r0 * r1
            goto L1d
        L17:
            r0 = 42
            goto L2a
        L1d:
            int r3 = r2 + r1
            goto Lc
        L23:
            goto L8
        L26:
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
    }

    public static int TFpqFLSwSRaobsAq(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = r1.getPaddingTop()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void TFpqFLSwSRaobsAq(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, short r3, byte r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L23
        Lf:
            return
        L10:
            goto L1a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1a:
            goto L2c
        L1d:
            r0 = 42
            goto L14
        L23:
            int r3 = r2 + r1
            goto L4
        L29:
            goto L10
        L2c:
            goto L1d
    }

    public static void TFpqFLSwSRaobsAq(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, short r2, int r3, byte r4) {
            goto L1d
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L20
        L12:
            r0 = 42
            goto L4
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            goto Lb
        L20:
            goto L12
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L18
    }

    public static void TFpqFLSwSRaobsAq(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, short r2, char r3, byte r4) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            goto L1d
        L18:
            goto L2a
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L18
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L2a:
            r0 = 42
            goto L24
    }

    public static int TLUCfRdMuTYrZxzX(com.google.android.material.progressindicator.DrawingDelegate r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = r1.getPreferredWidth()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void TLUCfRdMuTYrZxzX(com.google.android.material.progressindicator.DrawingDelegate r0, float r1, char r2, bool r3, java.lang.string r4) {
            goto L1a
        L4:
            return
        L5:
            goto L2d
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r3 = r2 + r1
            goto L9
        L14:
            int r2 = r0 * r1
            goto Le
        L1a:
            goto L5
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L1d
    }

    public static void TLUCfRdMuTYrZxzX(com.google.android.material.progressindicator.DrawingDelegate r0, float r1, bool r2, java.lang.string r3, char r4) {
            goto L1b
        L4:
            return
        L5:
            goto L2d
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L28
        L15:
            r0 = 42
            goto L22
        L1b:
            goto L5
        L1e:
            goto L15
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L1e
    }

    public static void TLUCfRdMuTYrZxzX(com.google.android.material.progressindicator.DrawingDelegate r0, java.lang.string r1, float r2, char r3, bool r4) {
            goto L16
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L1d
        L16:
            goto L2c
        L19:
            goto L25
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            goto L19
        L25:
            r0 = 42
            goto L4
        L2b:
            return
        L2c:
            goto L22
    }

    public static void TPkmHJVjhJopLsWZ(androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r0, android.graphics.drawable.Drawable r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.onAnimationEnd(r1)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void TPkmHJVjhJopLsWZ(androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r0, android.graphics.drawable.Drawable r1, char r2, short r3, int r4, bool r5) {
            goto L1b
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto L22
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto L28
        L1b:
            goto L5
        L1e:
            goto L9
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L1e
    }

    public static void TPkmHJVjhJopLsWZ(androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r0, android.graphics.drawable.Drawable r1, short r2, bool r3, int r4, char r5) {
            goto L13
        L4:
            goto L16
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        Ld:
            r0 = 42
            goto L7
        L13:
            goto L21
        L16:
            goto Ld
        L1a:
            int r3 = r2 + r1
            goto L2b
        L20:
            return
        L21:
            goto L4
        L25:
            int r2 = r0 * r1
            goto L1a
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void TPkmHJVjhJopLsWZ(androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r0, android.graphics.drawable.Drawable r1, bool r2, int r3, char r4, short r5) {
            goto L29
        L4:
            return
        L5:
            goto L21
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L24
        L15:
            r0 = 42
            goto L1b
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L21:
            goto L2c
        L24:
            double r0 = (double) r3
            goto L4
        L29:
            goto L5
        L2c:
            goto L15
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable TPrYmapYYGhfbCmD(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void TPrYmapYYGhfbCmD(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, char r2, int r3, short r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        La:
            goto L2c
        Ld:
            goto L19
        L11:
            goto Ld
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            r0 = 42
            goto L4
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L14
        L2b:
            return
        L2c:
            goto L11
    }

    public static void TPrYmapYYGhfbCmD(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, char r2, int r3, float r4) {
            goto L13
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            goto L16
        Ld:
            r0 = 42
            goto L20
        L13:
            goto L27
        L16:
            goto Ld
        L1a:
            int r3 = r2 + r1
            goto L2b
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L26:
            return
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void TPrYmapYYGhfbCmD(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, int r2, float r3, char r4) {
            goto Lf
        L4:
            return
        L5:
            goto L27
        L9:
            r0 = 42
            goto L21
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            int r2 = r0 * r1
            goto L2a
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L27:
            goto L12
        L2a:
            int r3 = r2 + r1
            goto L16
    }

    public static android.graphics.drawable.Drawable TlXzfYCsZeQmYfGg(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            android.graphics.drawable.Drawable r0 = r1.getCurrentDrawable()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void TlXzfYCsZeQmYfGg(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, char r2, bool r3, float r4) {
            goto Ld
        L4:
            goto L10
        L7:
            r0 = 42
            goto L1f
        Ld:
            goto L15
        L10:
            goto L7
        L14:
            return
        L15:
            goto L4
        L19:
            int r3 = r2 + r1
            goto L2b
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto L19
        L2b:
            double r0 = (double) r3
            goto L14
    }

    public static void TlXzfYCsZeQmYfGg(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, char r2, byte r3, bool r4) {
            goto L1d
        L4:
            goto L20
        L7:
            r0 = 42
            goto L24
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto L4
        L17:
            int r2 = r0 * r1
            goto L2a
        L1d:
            goto L13
        L20:
            goto L7
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L2a:
            int r3 = r2 + r1
            goto Ld
    }

    public static void TlXzfYCsZeQmYfGg(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, byte r2, char r3, float r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L26
        Le:
            int r3 = r2 + r1
            goto L4
        L14:
            r0 = 42
            goto L20
        L1a:
            int r2 = r0 * r1
            goto Le
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L26:
            goto L2c
        L29:
            goto La
        L2c:
            goto L14
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable TqoZlKonttqYCHji(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void TqoZlKonttqYCHji(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, byte r2, float r3, int r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            double r0 = (double) r3
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L2c
        L23:
            r0 = 42
            goto L4
        L29:
            goto L1c
        L2c:
            goto L23
    }

    public static void TqoZlKonttqYCHji(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, float r2, byte r3, int r4) {
            goto Ld
        L4:
            goto L10
        L7:
            r0 = 42
            goto L14
        Ld:
            goto L2c
        L10:
            goto L7
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L1a:
            int r3 = r2 + r1
            goto L26
        L20:
            int r2 = r0 * r1
            goto L1a
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L4
    }

    public static void TqoZlKonttqYCHji(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, float r2, int r3, byte r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L17
        Lb:
            int r3 = r2 + r1
            goto L20
        L11:
            int r2 = r0 * r1
            goto Lb
        L17:
            r0 = 42
            goto L2a
        L1d:
            goto L7
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L1d
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
    }

    public static void UPEmiypQJyGodrOI(android.graphics.Canvas r0, int r1) {
            goto Lb
        L4:
            r0.restoreToCount(r1)
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

    public static void UPEmiypQJyGodrOI(android.graphics.Canvas r0, int r1, int r2, short r3, bool r4, byte r5) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L25
        Ld:
            goto L21
        L10:
            goto L2a
        L14:
            int r2 = r0 * r1
            goto L7
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L20:
            return
        L21:
            goto L4
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r0 = 42
            goto L1a
    }

    public static void UPEmiypQJyGodrOI(android.graphics.Canvas r0, int r1, short r2, bool r3, byte r4, int r5) {
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
            goto L2a
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L19:
            int r2 = r0 * r1
            goto L24
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r0 = 42
            goto L13
    }

    public static void UPEmiypQJyGodrOI(android.graphics.Canvas r0, int r1, bool r2, byte r3, int r4, short r5) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L2a
        L13:
            int r3 = r2 + r1
            goto L25
        L19:
            int r2 = r0 * r1
            goto L13
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            double r0 = (double) r3
            goto L7
        L2a:
            r0 = 42
            goto L1f
    }

    public static void VBfmiThpwMljruef(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            super.setProgressDrawable(r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void VBfmiThpwMljruef(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1, char r2, java.lang.string r3, bool r4, float r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L24
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L10:
            goto L2c
        L13:
            return
        L14:
            goto L10
        L18:
            int r2 = r0 * r1
            goto L4
        L1e:
            r0 = 42
            goto La
        L24:
            double r0 = (double) r3
            goto L13
        L29:
            goto L14
        L2c:
            goto L1e
    }

    public static void VBfmiThpwMljruef(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1, bool r2, float r3, char r4, java.lang.string r5) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            goto L20
        Lc:
            int r3 = r2 + r1
            goto L4
        L12:
            return
        L13:
            goto L9
        L17:
            r0 = 42
            goto L2a
        L1d:
            goto L13
        L20:
            goto L17
        L24:
            int r2 = r0 * r1
            goto Lc
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void VBfmiThpwMljruef(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1, bool r2, float r3, java.lang.string r4, char r5) {
            goto L29
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L10:
            goto L2c
        L13:
            int r2 = r0 * r1
            goto L23
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto L10
        L23:
            int r3 = r2 + r1
            goto L19
        L29:
            goto L1f
        L2c:
            goto L4
    }

    public static void VGhdRiQKxTMRugxH(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, byte r2, float r3, char r4, short r5) {
            goto La
        L4:
            r0 = 42
            goto L11
        La:
            goto L21
        Ld:
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L17:
            int r3 = r2 + r1
            goto L25
        L1d:
            goto Ld
        L20:
            return
        L21:
            goto L1d
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r2 = r0 * r1
            goto L17
    }

    public static void VGhdRiQKxTMRugxH(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, char r2, short r3, float r4, byte r5) {
            goto L4
        L4:
            goto L27
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L1a
        L11:
            int r2 = r0 * r1
            goto L20
        L17:
            goto L7
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L20:
            int r3 = r2 + r1
            goto L2b
        L26:
            return
        L27:
            goto L17
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void VGhdRiQKxTMRugxH(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, short r2, float r3, byte r4, char r5) {
            goto L18
        L4:
            goto L1b
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L1f
        L13:
            double r0 = (double) r3
            goto L25
        L18:
            goto L26
        L1b:
            goto L2a
        L1f:
            int r3 = r2 + r1
            goto L13
        L25:
            return
        L26:
            goto L4
        L2a:
            r0 = 42
            goto L7
    }

    public static bool VGhdRiQKxTMRugxH(com.google.android.material.progressindicator.BaseProgressIndicator r1, java.lang.Action r2) {
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
            bool r0 = r1.removeCallbacks(r2)
            goto Le
    }

    public static int VKbQuVeQemkVFVBO(com.google.android.material.progressindicator.DrawingDelegate r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            int r0 = r1.getPreferredHeight()
            goto L4
        L18:
            goto Lc
    }

    public static void VKbQuVeQemkVFVBO(com.google.android.material.progressindicator.DrawingDelegate r0, char r1, byte r2, int r3, java.lang.string r4) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L2a
        L10:
            goto Lc
        L13:
            int r2 = r0 * r1
            goto L19
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L2a:
            r0 = 42
            goto L24
    }

    public static void VKbQuVeQemkVFVBO(com.google.android.material.progressindicator.DrawingDelegate r0, char r1, int r2, byte r3, java.lang.string r4) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L18
        L10:
            goto L26
        L13:
            double r0 = (double) r3
            goto L1e
        L18:
            int r3 = r2 + r1
            goto L13
        L1e:
            return
        L1f:
            goto L10
        L23:
            goto L1f
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L4
    }

    public static void VKbQuVeQemkVFVBO(com.google.android.material.progressindicator.DrawingDelegate r0, int r1, char r2, byte r3, java.lang.string r4) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            goto L20
        Lc:
            r0 = 42
            goto L17
        L12:
            return
        L13:
            goto L9
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L1d:
            goto L13
        L20:
            goto Lc
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void VPeiDeXdgBSBjZZw(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, float r2, byte r3, short r4, int r5) {
            goto L23
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L10:
            return
        L11:
            goto L20
        L15:
            int r2 = r0 * r1
            goto L2a
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            goto L26
        L23:
            goto L11
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L1b
    }

    public static void VPeiDeXdgBSBjZZw(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, float r2, short r3, int r4, byte r5) {
            goto L4
        L4:
            goto L26
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0 = 42
            goto L2a
        L14:
            double r0 = (double) r3
            goto L25
        L19:
            int r3 = r2 + r1
            goto L14
        L1f:
            int r2 = r0 * r1
            goto L19
        L25:
            return
        L26:
            goto Lb
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void VPeiDeXdgBSBjZZw(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, int r2, short r3, float r4, byte r5) {
            goto L4
        L4:
            goto L1e
        L7:
            goto L27
        Lb:
            int r2 = r0 * r1
            goto L17
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L17:
            int r3 = r2 + r1
            goto L22
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            r0 = 42
            goto L11
        L2d:
            goto L7
    }

    public static bool VPeiDeXdgBSBjZZw(com.google.android.material.progressindicator.BaseProgressIndicator r1, java.lang.Action r2) {
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
            bool r0 = r1.removeCallbacks(r2)
            goto Le
    }

    public static void VcdEsWEQEiKZNjOC(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, bool r1, bool r2, bool r3, byte r4, char r5, bool r6, java.lang.string r7) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            goto L2c
        Lc:
            int r2 = r0 * r1
            goto L1d
        L12:
            return
        L13:
            goto L9
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L1d:
            int r3 = r2 + r1
            goto L4
        L23:
            r0 = 42
            goto L17
        L29:
            goto L13
        L2c:
            goto L23
    }

    public static void VcdEsWEQEiKZNjOC(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, bool r1, bool r2, bool r3, java.lang.string r4, char r5, byte r6, bool r7) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            double r0 = (double) r3
            goto L25
        L1b:
            goto L26
        L1e:
            goto L2a
        L22:
            goto L1e
        L25:
            return
        L26:
            goto L22
        L2a:
            r0 = 42
            goto L10
    }

    public static void VcdEsWEQEiKZNjOC(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, bool r1, bool r2, bool r3, bool r4, char r5, byte r6, java.lang.string r7) {
            goto L7
        L4:
            goto La
        L7:
            goto L26
        La:
            goto Le
        Le:
            r0 = 42
            goto L2a
        L14:
            double r0 = (double) r3
            goto L25
        L19:
            int r3 = r2 + r1
            goto L14
        L1f:
            int r2 = r0 * r1
            goto L19
        L25:
            return
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static bool VcdEsWEQEiKZNjOC(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r1, bool r2, bool r3, bool r4) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.setVisible(r2, r3, r4)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void VcelPbTQrguyCCWc(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, int r2) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.setMeasuredDimension(r1, r2)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void VcelPbTQrguyCCWc(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, int r2, int r3, short r4, java.lang.string r5, bool r6) {
            goto L13
        L4:
            goto L16
        L7:
            int r3 = r2 + r1
            goto L1f
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L13:
            goto L1b
        L16:
            goto L24
        L1a:
            return
        L1b:
            goto L4
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            r0 = 42
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L7
    }

    public static void VcelPbTQrguyCCWc(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, int r2, short r3, java.lang.string r4, int r5, bool r6) {
            goto L14
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L2d
        Le:
            int r3 = r2 + r1
            goto L4
        L14:
            goto La
        L17:
            goto L1b
        L1b:
            r0 = 42
            goto L21
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L27:
            int r2 = r0 * r1
            goto Le
        L2d:
            goto L17
    }

    public static void VcelPbTQrguyCCWc(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, int r2, short r3, bool r4, int r5, java.lang.string r6) {
            goto L17
        L4:
            r0 = 42
            goto L1e
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L1a
        L17:
            goto L10
        L1a:
            goto L4
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static android.graphics.drawable.Drawable WIEADNjQkFRDkqei(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            goto L17
        L7:
            android.graphics.drawable.Drawable r0 = r1.getCurrentDrawable()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void WIEADNjQkFRDkqei(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, int r2, char r3, short r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L26
        Ld:
            goto L1f
        L11:
            int r3 = r2 + r1
            goto L1a
        L17:
            goto Ld
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto L4
        L25:
            return
        L26:
            goto L17
        L2a:
            int r2 = r0 * r1
            goto L11
    }

    public static void WIEADNjQkFRDkqei(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, byte r3, short r4) {
            goto L1e
        L4:
            goto L21
        L7:
            double r0 = (double) r3
            goto L2b
        Lc:
            int r2 = r0 * r1
            goto L25
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L18:
            r0 = 42
            goto L12
        L1e:
            goto L2c
        L21:
            goto L18
        L25:
            int r3 = r2 + r1
            goto L7
        L2b:
            return
        L2c:
            goto L4
    }

    public static void WIEADNjQkFRDkqei(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, int r2, char r3, byte r4) {
            goto Lf
        L4:
            return
        L5:
            goto L2d
        L9:
            int r3 = r2 + r1
            goto L28
        Lf:
            goto L5
        L12:
            goto L16
        L16:
            r0 = 42
            goto L1c
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L22:
            int r2 = r0 * r1
            goto L9
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L12
    }

    public static int WPmdQpZHVSFLbPqi(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lc
        L4:
            int r0 = r1.getSuggestedMinimumWidth()
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

    public static void WPmdQpZHVSFLbPqi(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, char r2, int r3, short r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        La:
            goto L2c
        Ld:
            goto L1d
        L11:
            int r2 = r0 * r1
            goto L17
        L17:
            int r3 = r2 + r1
            goto L23
        L1d:
            r0 = 42
            goto L4
        L23:
            double r0 = (double) r3
            goto L2b
        L28:
            goto Ld
        L2b:
            return
        L2c:
            goto L28
    }

    public static void WPmdQpZHVSFLbPqi(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, char r2, short r3, byte r4) {
            goto L10
        L4:
            r0 = 42
            goto L25
        La:
            int r3 = r2 + r1
            goto L1a
        L10:
            goto L2c
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            int r2 = r0 * r1
            goto La
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            return
        L2c:
            goto L17
    }

    public static void WPmdQpZHVSFLbPqi(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, int r2, char r3, byte r4) {
            goto L14
        L4:
            return
        L5:
            goto L21
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            r0 = 42
            goto L1b
        L14:
            goto L5
        L17:
            goto Le
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L21:
            goto L17
        L24:
            int r3 = r2 + r1
            goto L9
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static int WQFTMcoeWtRYmyfw(android.graphics.Canvas r1) {
            goto Lc
        L4:
            int r0 = r1.save()
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

    public static void WQFTMcoeWtRYmyfw(android.graphics.Canvas r0, int r1, byte r2, java.lang.string r3, float r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L25
        Ld:
            goto L2c
        L10:
            goto L19
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            r0 = 42
            goto L1f
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L25:
            int r3 = r2 + r1
            goto L14
        L2b:
            return
        L2c:
            goto L4
    }

    public static void WQFTMcoeWtRYmyfw(android.graphics.Canvas r0, int r1, float r2, java.lang.string r3, byte r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            return
        Lb:
            goto L20
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L20:
            goto L26
        L23:
            goto Lb
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L1a
    }

    public static void WQFTMcoeWtRYmyfw(android.graphics.Canvas r0, java.lang.string r1, float r2, byte r3, int r4) {
            goto L4
        L4:
            goto L23
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L22
        L10:
            r0 = 42
            goto L27
        L16:
            int r2 = r0 * r1
            goto L1c
        L1c:
            int r3 = r2 + r1
            goto Lb
        L22:
            return
        L23:
            goto L2d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2d:
            goto L7
    }

    public static void WphZNtUsPiBgRXUq(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.setVisibility(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void WphZNtUsPiBgRXUq(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, byte r2, float r3, bool r4, char r5) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L1f
        L10:
            goto Lc
        L13:
            int r3 = r2 + r1
            goto L2b
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1f:
            r0 = 42
            goto L19
        L25:
            int r2 = r0 * r1
            goto L13
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void WphZNtUsPiBgRXUq(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, byte r2, bool r3, float r4, char r5) {
            goto L1d
        L4:
            return
        L5:
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L12
        Lf:
            goto L20
        L12:
            int r3 = r2 + r1
            goto L18
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            goto L5
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2a:
            r0 = 42
            goto L24
    }

    public static void WphZNtUsPiBgRXUq(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2, byte r3, float r4, char r5) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L11
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L11:
            r0 = 42
            goto Lb
        L17:
            int r2 = r0 * r1
            goto L20
        L1d:
            goto L7
        L20:
            int r3 = r2 + r1
            goto L26
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L1d
    }

    public static android.graphics.drawable.Drawable XjlpCKLskKqwIIsU(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            android.graphics.drawable.Drawable r0 = r1.getCurrentDrawable()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void XjlpCKLskKqwIIsU(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, java.lang.string r3, float r4) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            goto L1b
        Ld:
            r0 = 42
            goto L24
        L13:
            return
        L14:
            goto La
        L18:
            goto L14
        L1b:
            goto Ld
        L1f:
            double r0 = (double) r3
            goto L13
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void XjlpCKLskKqwIIsU(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, char r2, float r3, java.lang.string r4) {
            goto L24
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L27
        L13:
            r0 = 42
            goto L19
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1f:
            double r0 = (double) r3
            goto L2b
        L24:
            goto L2c
        L27:
            goto L13
        L2b:
            return
        L2c:
            goto L10
    }

    public static void XjlpCKLskKqwIIsU(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, float r2, java.lang.string r3, char r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L2c
        Lc:
            goto L25
        L10:
            goto Lc
        L13:
            int r3 = r2 + r1
            goto L4
        L19:
            int r2 = r0 * r1
            goto L13
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            r0 = 42
            goto L1f
        L2b:
            return
        L2c:
            goto L10
    }

    public static void XnqeTsURmwFVfcDY(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto Lb
        L4:
            r0.invalidate()
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

    public static void XnqeTsURmwFVfcDY(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, int r2, float r3, bool r4) {
            goto L1d
        L4:
            return
        L5:
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L12
        Lf:
            goto L20
        L12:
            int r3 = r2 + r1
            goto L18
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            goto L5
        L20:
            goto L24
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void XnqeTsURmwFVfcDY(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, int r2, java.lang.string r3, float r4) {
            goto L20
        L4:
            return
        L5:
            goto L27
        L9:
            int r3 = r2 + r1
            goto L1b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L9
        L1b:
            double r0 = (double) r3
            goto L4
        L20:
            goto L5
        L23:
            goto L2a
        L27:
            goto L23
        L2a:
            r0 = 42
            goto Lf
    }

    public static void XnqeTsURmwFVfcDY(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, java.lang.string r2, float r3, int r4) {
            goto L29
        L4:
            r0 = 42
            goto L23
        La:
            double r0 = (double) r3
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L2c
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L29:
            goto L1c
        L2c:
            goto L4
    }

    public static android.graphics.drawable.Drawable YOavCgIthduyeCTm(android.widget.ProgressBar r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.graphics.drawable.Drawable r0 = super.getProgressDrawable()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void YOavCgIthduyeCTm(android.widget.ProgressBar r0, short r1, byte r2, bool r3, float r4) {
            goto L20
        L4:
            r0 = 42
            goto L2a
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L27
        L14:
            int r3 = r2 + r1
            goto La
        L1a:
            int r2 = r0 * r1
            goto L14
        L20:
            goto L10
        L23:
            goto L4
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
    }

    public static void YOavCgIthduyeCTm(android.widget.ProgressBar r0, bool r1, byte r2, short r3, float r4) {
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto L24
        Lc:
            r0 = 42
            goto L1e
        L12:
            int r2 = r0 * r1
            goto L18
        L18:
            int r3 = r2 + r1
            goto L7
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L24:
            return
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto Lc
    }

    public static void YOavCgIthduyeCTm(android.widget.ProgressBar r0, bool r1, short r2, float r3, byte r4) {
            goto L12
        L4:
            goto L15
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L19
        L19:
            r0 = 42
            goto L1f
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L25:
            double r0 = (double) r3
            goto Ld
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void YidqOhxTRlvlMcaf(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, java.lang.string r2, bool r3, float r4) {
            goto Ld
        L4:
            goto L10
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        Ld:
            goto L2c
        L10:
            goto L25
        L14:
            int r2 = r0 * r1
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            int r3 = r2 + r1
            goto L1a
        L25:
            r0 = 42
            goto L7
        L2b:
            return
        L2c:
            goto L4
    }

    public static void YidqOhxTRlvlMcaf(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, bool r2, float r3, char r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L16
        L9:
            r0 = 42
            goto L1b
        Lf:
            goto L17
        L12:
            goto L9
        L16:
            return
        L17:
            goto L2d
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L21:
            int r3 = r2 + r1
            goto L4
        L27:
            int r2 = r0 * r1
            goto L21
        L2d:
            goto L12
    }

    public static void YidqOhxTRlvlMcaf(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, char r2, float r3, java.lang.string r4) {
            goto L9
        L4:
            return
        L5:
            goto L15
        L9:
            goto L5
        Lc:
            goto L1e
        L10:
            double r0 = (double) r3
            goto L4
        L15:
            goto Lc
        L18:
            int r2 = r0 * r1
            goto L24
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L10
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
    }

    public static bool YidqOhxTRlvlMcaf(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.isIndeterminate()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static int YnixGhSOGZSwKHGC(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = r1.getSuggestedMinimumHeight()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void YnixGhSOGZSwKHGC(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, float r2, int r3, java.lang.string r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L11
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L11:
            r0 = 42
            goto Lb
        L17:
            int r3 = r2 + r1
            goto L1d
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            goto L7
        L25:
            int r2 = r0 * r1
            goto L17
        L2b:
            return
        L2c:
            goto L22
    }

    public static void YnixGhSOGZSwKHGC(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, java.lang.string r2, float r3, byte r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L25
        Lb:
            return
        Lc:
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L16:
            goto L7
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r0 = 42
            goto L10
        L2b:
            double r0 = (double) r3
            goto Lb
    }

    public static void YnixGhSOGZSwKHGC(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, int r2, byte r3, float r4) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L1f
        L10:
            goto Lc
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            r0 = 42
            goto L13
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable YpqxqZyAmSGttCMD(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lc
        L4:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void YpqxqZyAmSGttCMD(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, char r2, int r3, short r4) {
            goto L18
        L4:
            return
        L5:
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L25
        Lf:
            goto L1b
        L12:
            r0 = 42
            goto L2a
        L18:
            goto L5
        L1b:
            goto L12
        L1f:
            int r2 = r0 * r1
            goto L9
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void YpqxqZyAmSGttCMD(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, byte r2, char r3, short r4) {
            goto L21
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            r0 = 42
            goto L15
        L21:
            goto L2c
        L24:
            goto L1b
        L28:
            goto L24
        L2b:
            return
        L2c:
            goto L28
    }

    public static void YpqxqZyAmSGttCMD(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, char r2, short r3, byte r4) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L21
        Lc:
            r0 = 42
            goto L25
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            goto L2c
        L21:
            goto Lc
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L2b:
            return
        L2c:
            goto L9
    }

    public static void ZhdExNYQGaTUpZrG(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, short r2, char r3, byte r4, bool r5) {
            goto L16
        L4:
            r0 = 42
            goto L22
        La:
            int r3 = r2 + r1
            goto L1d
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            goto L2c
        L19:
            goto L4
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L28:
            goto L19
        L2b:
            return
        L2c:
            goto L28
    }

    public static void ZhdExNYQGaTUpZrG(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, short r2, bool r3, byte r4, char r5) {
            goto L13
        L4:
            goto L16
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        Ld:
            r0 = 42
            goto L7
        L13:
            goto L2c
        L16:
            goto Ld
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L1a
        L2b:
            return
        L2c:
            goto L4
    }

    public static void ZhdExNYQGaTUpZrG(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, bool r2, char r3, byte r4, short r5) {
            goto L1d
        L4:
            goto L20
        L7:
            double r0 = (double) r3
            goto L12
        Lc:
            r0 = 42
            goto L17
        L12:
            return
        L13:
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            goto L13
        L20:
            goto Lc
        L24:
            int r3 = r2 + r1
            goto L7
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static bool ZhdExNYQGaTUpZrG(com.google.android.material.progressindicator.BaseProgressIndicator r1, java.lang.Action r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.removeCallbacks(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int ZndHYZBCyMhfdmOF(android.content.object r1, int r2, int r3) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = com.google.android.material.color.MaterialColors.getColor(r1, r2, r3)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void ZndHYZBCyMhfdmOF(android.content.object r0, int r1, int r2, byte r3, float r4, java.lang.string r5, char r6) {
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto Lc
        Lc:
            return
        Ld:
            goto L4
        L11:
            int r2 = r0 * r1
            goto L1d
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L1d:
            int r3 = r2 + r1
            goto L7
        L23:
            r0 = 42
            goto L17
        L29:
            goto Ld
        L2c:
            goto L23
    }

    public static void ZndHYZBCyMhfdmOF(android.content.object r0, int r1, int r2, char r3, java.lang.string r4, byte r5, float r6) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L1c
        La:
            goto L18
        Ld:
            goto L2a
        L11:
            int r2 = r0 * r1
            goto L4
        L17:
            return
        L18:
            goto L21
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            goto Ld
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L2a:
            r0 = 42
            goto L24
    }

    public static void ZndHYZBCyMhfdmOF(android.content.object r0, int r1, int r2, java.lang.string r3, char r4, float r5, byte r6) {
            goto Lf
        L4:
            r0 = 42
            goto L1c
        La:
            return
        Lb:
            goto L22
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            int r3 = r2 + r1
            goto L2b
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L22:
            goto L12
        L25:
            int r2 = r0 * r1
            goto L16
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static com.google.android.material.progressindicator.IndeterminateAnimatorDelegate ABxIaNAsubFtpBky(com.google.android.material.progressindicator.IndeterminateDrawable r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0 = r1.getAnimatorDelegate()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void ABxIaNAsubFtpBky(com.google.android.material.progressindicator.IndeterminateDrawable r0, byte r1, bool r2, java.lang.string r3, short r4) {
            goto L9
        L4:
            return
        L5:
            goto L16
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L2a
        L16:
            goto Lc
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            int r2 = r0 * r1
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void ABxIaNAsubFtpBky(com.google.android.material.progressindicator.IndeterminateDrawable r0, bool r1, byte r2, short r3, java.lang.string r4) {
            goto Ld
        L4:
            goto L10
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        Ld:
            goto L2c
        L10:
            goto L14
        L14:
            r0 = 42
            goto L7
        L1a:
            int r3 = r2 + r1
            goto L26
        L20:
            int r2 = r0 * r1
            goto L1a
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L4
    }

    public static void ABxIaNAsubFtpBky(com.google.android.material.progressindicator.IndeterminateDrawable r0, bool r1, short r2, byte r3, java.lang.string r4) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0 = 42
            goto L1f
        L19:
            int r3 = r2 + r1
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            double r0 = (double) r3
            goto Le
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static void AKCSwykDSyOejKEk(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, byte r2, int r3, java.lang.string r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L17
        La:
            goto L1d
        Ld:
            goto L21
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r0 = 42
            goto L11
        L27:
            int r2 = r0 * r1
            goto L4
        L2d:
            goto Ld
    }

    public static void AKCSwykDSyOejKEk(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, byte r2, java.lang.string r3, char r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L2c
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L1f
        L16:
            int r2 = r0 * r1
            goto L25
        L1c:
            goto Lc
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L25:
            int r3 = r2 + r1
            goto L4
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void AKCSwykDSyOejKEk(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, char r2, byte r3, java.lang.string r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L1d
        L10:
            return
        L11:
            goto L1a
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            goto L2c
        L1d:
            int r3 = r2 + r1
            goto L15
        L23:
            r0 = 42
            goto L4
        L29:
            goto L11
        L2c:
            goto L23
    }

    public static bool AKCSwykDSyOejKEk(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            bool r0 = r1.visibleToUser()
            goto L7
    }

    public static int AapWVGWlfdIyoLtB(int r1, int r2) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = getDefaultSize(r1, r2)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void AapWVGWlfdIyoLtB(int r0, int r1, byte r2, int r3, short r4, char r5) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L18
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L26
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto La
        L23:
            goto Lb
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L12
    }

    public static void AapWVGWlfdIyoLtB(int r0, int r1, byte r2, short r3, int r4, char r5) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            r0 = 42
            goto L25
        L1b:
            goto L2c
        L1e:
            goto L15
        L22:
            goto L1e
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L2b:
            return
        L2c:
            goto L22
    }

    public static void AapWVGWlfdIyoLtB(int r0, int r1, int r2, char r3, byte r4, short r5) {
            goto L29
        L4:
            return
        L5:
            goto L1b
        L9:
            int r2 = r0 * r1
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            int r3 = r2 + r1
            goto L24
        L1b:
            goto L2c
        L1e:
            r0 = 42
            goto Lf
        L24:
            double r0 = (double) r3
            goto L4
        L29:
            goto L5
        L2c:
            goto L1e
    }

    static /* synthetic */ void access$000(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            rCqBnhAxfhmVJPpF(r0)
            goto Le
    }

    static /* synthetic */ void access$000(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, java.lang.string r3, float r4) {
            goto L16
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L1d
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            goto L23
        L19:
            goto L27
        L1d:
            double r0 = (double) r3
            goto L22
        L22:
            return
        L23:
            goto L2d
        L27:
            r0 = 42
            goto L4
        L2d:
            goto L19
    }

    static /* synthetic */ void access$000(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, char r2, java.lang.string r3, int r4) {
            goto L23
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L2a
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L26
        L1e:
            double r0 = (double) r3
            goto L16
        L23:
            goto L17
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L1e
    }

    static /* synthetic */ void access$000(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, java.lang.string r2, int r3, char r4) {
            goto L1d
        L4:
            r0 = 42
            goto L2a
        La:
            int r2 = r0 * r1
            goto L24
        L10:
            goto L20
        L13:
            return
        L14:
            goto L10
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            goto L14
        L20:
            goto L4
        L24:
            int r3 = r2 + r1
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    static /* synthetic */ void access$100(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            QhbIRwvzYfNtWhCs(r0)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    static /* synthetic */ void access$100(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, java.lang.string r2, short r3, bool r4) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L21
        L12:
            int r3 = r2 + r1
            goto L25
        L18:
            r0 = 42
            goto L4
        L1e:
            goto Lb
        L21:
            goto L18
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    static /* synthetic */ void access$100(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, float r2, short r3, bool r4) {
            goto L1a
        L4:
            return
        L5:
            goto L2d
        L9:
            int r3 = r2 + r1
            goto Lf
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L1a:
            goto L5
        L1d:
            goto L21
        L21:
            r0 = 42
            goto L14
        L27:
            int r2 = r0 * r1
            goto L9
        L2d:
            goto L1d
    }

    static /* synthetic */ void access$100(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, bool r2, float r3, short r4) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            return
        L16:
            goto L20
        L1a:
            int r3 = r2 + r1
            goto La
        L20:
            goto L26
        L23:
            goto L16
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto Lf
    }

    static /* synthetic */ long access$202(com.google.android.material.progressindicator.BaseProgressIndicator r0, long r1) {
            goto L9
        L4:
            return r1
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.lastShowStartTime = r1
            goto L4
    }

    static /* synthetic */ void access$202(com.google.android.material.progressindicator.BaseProgressIndicator r0, long r1, float r3, bool r4, java.lang.string r5, int r6) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        Lf:
            r0 = 42
            goto L9
        L15:
            int r3 = r2 + r1
            goto L4
        L1b:
            goto L2c
        L1e:
            goto Lf
        L22:
            goto L1e
        L25:
            int r2 = r0 * r1
            goto L15
        L2b:
            return
        L2c:
            goto L22
    }

    static /* synthetic */ void access$202(com.google.android.material.progressindicator.BaseProgressIndicator r0, long r1, java.lang.string r3, bool r4, int r5, float r6) {
            goto L4
        L4:
            goto L26
        L7:
            goto L16
        Lb:
            double r0 = (double) r3
            goto L25
        L10:
            int r3 = r2 + r1
            goto Lb
        L16:
            r0 = 42
            goto L2a
        L1c:
            int r2 = r0 * r1
            goto L10
        L22:
            goto L7
        L25:
            return
        L26:
            goto L22
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
    }

    static /* synthetic */ void access$202(com.google.android.material.progressindicator.BaseProgressIndicator r0, long r1, bool r3, float r4, java.lang.string r5, int r6) {
            goto L23
        L4:
            return
        L5:
            goto L15
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L18
        L15:
            goto L26
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L23:
            goto L5
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L1d
    }

    static /* synthetic */ int access$300(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L16
        L10:
            int r0 = r0.storedProgress
            goto Lb
        L16:
            goto L7
    }

    static /* synthetic */ void access$300(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, java.lang.string r3, float r4) {
            goto L1e
        L4:
            r0 = 42
            goto L18
        La:
            int r3 = r2 + r1
            goto L25
        L10:
            goto L21
        L13:
            return
        L14:
            goto L10
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1e:
            goto L14
        L21:
            goto L4
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            int r2 = r0 * r1
            goto La
    }

    static /* synthetic */ void access$300(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, int r2, char r3, java.lang.string r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L2a
        Lb:
            return
        Lc:
            goto L21
        L10:
            int r2 = r0 * r1
            goto L24
        L16:
            double r0 = (double) r3
            goto Lb
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L21:
            goto L7
        L24:
            int r3 = r2 + r1
            goto L16
        L2a:
            r0 = 42
            goto L1b
    }

    static /* synthetic */ void access$300(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, int r2, char r3, float r4) {
            goto L17
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L1a
        L17:
            goto L10
        L1a:
            goto L24
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            r0 = 42
            goto L9
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    static /* synthetic */ void access$400(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, int r2, java.lang.string r3, bool r4) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L10:
            goto L21
        L13:
            goto L4
        L17:
            int r2 = r0 * r1
            goto L25
        L1d:
            goto L13
        L20:
            return
        L21:
            goto L1d
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L20
    }

    static /* synthetic */ void access$400(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, byte r2, bool r3, int r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L20
        L1a:
            r0 = 42
            goto La
        L20:
            goto L2c
        L23:
            int r2 = r0 * r1
            goto L4
        L29:
            goto L16
        L2c:
            goto L1a
    }

    static /* synthetic */ void access$400(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, int r2, byte r3, bool r4) {
            goto L12
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L19
        L19:
            r0 = 42
            goto L4
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            double r0 = (double) r3
            goto La
    }

    static /* synthetic */ bool access$400(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L12
        L4:
            bool r0 = r0.storedProgressAnimated
            goto La
        La:
            return r0
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L4
    }

    static /* synthetic */ void access$500(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, short r2, int r3, bool r4) {
            goto La
        L4:
            r0 = 42
            goto L24
        La:
            goto L1a
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            double r0 = (double) r3
            goto L19
        L19:
            return
        L1a:
            goto L11
        L1e:
            int r3 = r2 + r1
            goto L14
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    static /* synthetic */ void access$500(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2, short r3, char r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            r0 = 42
            goto L21
        Lf:
            goto L1d
        L12:
            goto L9
        L16:
            int r2 = r0 * r1
            goto L27
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L27:
            int r3 = r2 + r1
            goto L4
        L2d:
            goto L12
    }

    static /* synthetic */ void access$500(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, int r2, short r3, char r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L1c
        Lb:
            double r0 = (double) r3
            goto L2b
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L16:
            int r3 = r2 + r1
            goto Lb
        L1c:
            r0 = 42
            goto L10
        L22:
            goto L7
        L25:
            int r2 = r0 * r1
            goto L16
        L2b:
            return
        L2c:
            goto L22
    }

    static /* synthetic */ bool access$500(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto La
        L4:
            bool r0 = r0.isIndeterminateModeChangeRequested
            goto L14
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return r0
        L15:
            goto L11
    }

    static /* synthetic */ int access$600(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            int r0 = r0.visibilityAfterHide
            goto Lb
    }

    static /* synthetic */ void access$600(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, int r2, short r3, float r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L27
        Lb:
            return
        Lc:
            goto L2d
        L10:
            int r3 = r2 + r1
            goto L22
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L1c:
            int r2 = r0 * r1
            goto L10
        L22:
            double r0 = (double) r3
            goto Lb
        L27:
            r0 = 42
            goto L16
        L2d:
            goto L7
    }

    static /* synthetic */ void access$600(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, short r2, float r3, int r4) {
            goto L18
        L4:
            r0 = 42
            goto L1f
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            goto L1b
        L13:
            return
        L14:
            goto L10
        L18:
            goto L14
        L1b:
            goto L4
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto La
        L2b:
            double r0 = (double) r3
            goto L13
    }

    static /* synthetic */ void access$600(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, byte r2, int r3, short r4) {
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto L1e
        Lc:
            int r2 = r0 * r1
            goto L23
        L12:
            r0 = 42
            goto L18
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L1e:
            return
        L1f:
            goto L4
        L23:
            int r3 = r2 + r1
            goto L7
        L29:
            goto L1f
        L2c:
            goto L12
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable AgjllOgFiinacgec(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lf
        L4:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void AgjllOgFiinacgec(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, float r2, java.lang.string r3, int r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto Le
        Le:
            goto L2c
        L11:
            r0 = 42
            goto L17
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1d:
            int r2 = r0 * r1
            goto L23
        L23:
            int r3 = r2 + r1
            goto L4
        L29:
            goto La
        L2c:
            goto L11
    }

    public static void AgjllOgFiinacgec(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, float r3, java.lang.string r4) {
            goto L16
        L4:
            r0 = 42
            goto L27
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L22
        L16:
            goto L1e
        L19:
            goto L4
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L2d:
            goto L19
    }

    public static void AgjllOgFiinacgec(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, char r2, int r3, java.lang.string r4) {
            goto L13
        L4:
            goto L16
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L2a
        L13:
            goto L26
        L16:
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto L7
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L1a
    }

    public static int AsJUFexcVmnMHPSx(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = r1.getHeight()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void AsJUFexcVmnMHPSx(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, float r2, java.lang.string r3, bool r4) {
            goto L1a
        L4:
            r0 = 42
            goto L21
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L27
        L1a:
            goto L16
        L1d:
            goto L4
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L27:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void AsJUFexcVmnMHPSx(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, byte r2, java.lang.string r3, bool r4) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L1e
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            double r0 = (double) r3
            goto Le
        L18:
            int r2 = r0 * r1
            goto L2a
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L2a:
            int r3 = r2 + r1
            goto L13
    }

    public static void AsJUFexcVmnMHPSx(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, byte r2, bool r3, java.lang.string r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L17
        La:
            goto L29
        Ld:
            goto L1c
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L17:
            double r0 = (double) r3
            goto L28
        L1c:
            r0 = 42
            goto L11
        L22:
            int r2 = r0 * r1
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static float AuWBOMxLhHClDaFR(com.google.android.material.progressindicator.AnimatorDurationScaleProvider r1, android.content.ContentResolver r2) {
            goto L14
        L4:
            float r0 = r1.getSystemAnimatorDurationScale(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void AuWBOMxLhHClDaFR(com.google.android.material.progressindicator.AnimatorDurationScaleProvider r0, android.content.ContentResolver r1, java.lang.string r2, byte r3, short r4, int r5) {
            goto L1f
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            r0 = 42
            goto L4
        L16:
            int r2 = r0 * r1
            goto La
        L1c:
            goto L22
        L1f:
            goto L27
        L22:
            goto L10
        L26:
            return
        L27:
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void AuWBOMxLhHClDaFR(com.google.android.material.progressindicator.AnimatorDurationScaleProvider r0, android.content.ContentResolver r1, java.lang.string r2, int r3, byte r4, short r5) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L17
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L10:
            goto L1d
        L13:
            goto L21
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r0 = 42
            goto La
        L27:
            int r2 = r0 * r1
            goto L4
        L2d:
            goto L13
    }

    public static void AuWBOMxLhHClDaFR(com.google.android.material.progressindicator.AnimatorDurationScaleProvider r0, android.content.ContentResolver r1, java.lang.string r2, int r3, short r4, byte r5) {
            goto L12
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L19
        Lf:
            goto L15
        L12:
            goto L1a
        L15:
            goto L24
        L19:
            return
        L1a:
            goto Lf
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            r0 = 42
            goto L1e
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static int BtHSElREyVOewudn(android.view.object r1) {
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
            int r0 = r1.getVisibility()
            goto L4
    }

    public static void BtHSElREyVOewudn(android.view.object r0, byte r1, char r2, float r3, short r4) {
            goto L1b
        L4:
            return
        L5:
            goto L22
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L2b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1b:
            goto L5
        L1e:
            goto L25
        L22:
            goto L1e
        L25:
            r0 = 42
            goto L15
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void BtHSElREyVOewudn(android.view.object r0, float r1, char r2, short r3, byte r4) {
            goto L23
        L4:
            r0 = 42
            goto L2a
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            return
        L16:
            goto L20
        L1a:
            int r2 = r0 * r1
            goto Lf
        L20:
            goto L26
        L23:
            goto L16
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
    }

    public static void BtHSElREyVOewudn(android.view.object r0, float r1, short r2, byte r3, char r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            goto L18
        L13:
            goto L25
        L17:
            return
        L18:
            goto L22
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L22:
            goto L13
        L25:
            r0 = 42
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L17
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable CSFfHCXqIPrbkPsy(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L11
        L4:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
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

    public static void CSFfHCXqIPrbkPsy(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, byte r2, char r3, short r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            int r2 = r0 * r1
            goto L20
        L15:
            return
        L16:
            goto L26
        L1a:
            r0 = 42
            goto L4
        L20:
            int r3 = r2 + r1
            goto La
        L26:
            goto L2c
        L29:
            goto L16
        L2c:
            goto L1a
    }

    public static void CSFfHCXqIPrbkPsy(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, byte r2, char r3, float r4) {
            goto L29
        L4:
            r0 = 42
            goto L1b
        La:
            double r0 = (double) r3
            goto L21
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            int r2 = r0 * r1
            goto Lf
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto L4
    }

    public static void CSFfHCXqIPrbkPsy(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, char r2, float r3, byte r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L16
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        Lf:
            goto L17
        L12:
            goto L21
        L16:
            return
        L17:
            goto L2d
        L1b:
            int r2 = r0 * r1
            goto L27
        L21:
            r0 = 42
            goto L9
        L27:
            int r3 = r2 + r1
            goto L4
        L2d:
            goto L12
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable CVCXFjsysLLVQNoq(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L4
    }

    public static void CVCXFjsysLLVQNoq(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, byte r2, short r3, bool r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            double r0 = (double) r3
            goto L24
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            r0 = 42
            goto L1e
        L1b:
            goto L2c
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L24:
            return
        L25:
            goto L1b
        L29:
            goto L25
        L2c:
            goto L15
    }

    public static void CVCXFjsysLLVQNoq(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, byte r2, short r3, float r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L2a
        Lb:
            int r3 = r2 + r1
            goto L20
        L11:
            goto L7
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L1a:
            int r2 = r0 * r1
            goto Lb
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L11
        L2a:
            r0 = 42
            goto L14
    }

    public static void CVCXFjsysLLVQNoq(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, short r2, float r3, byte r4) {
            goto L20
        L4:
            double r0 = (double) r3
            goto L1b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            int r2 = r0 * r1
            goto Lf
        L1b:
            return
        L1c:
            goto L2d
        L20:
            goto L1c
        L23:
            goto L27
        L27:
            r0 = 42
            goto L9
        L2d:
            goto L23
    }

    public static android.view.objectParent CaEjHJeJYSvmtQgG(android.view.object r1) {
            goto L14
        L4:
            android.view.objectParent r0 = r1.getParent()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void CaEjHJeJYSvmtQgG(android.view.object r0, float r1, java.lang.string r2, bool r3, int r4) {
            goto L4
        L4:
            goto L18
        L7:
            goto L11
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L11:
            r0 = 42
            goto Lb
        L17:
            return
        L18:
            goto L2d
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            int r3 = r2 + r1
            goto L1c
        L27:
            int r2 = r0 * r1
            goto L21
        L2d:
            goto L7
    }

    public static void CaEjHJeJYSvmtQgG(android.view.object r0, bool r1, float r2, java.lang.string r3, int r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r0 = 42
            goto L15
        L10:
            double r0 = (double) r3
            goto L24
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1b:
            goto L2c
        L1e:
            int r2 = r0 * r1
            goto L4
        L24:
            return
        L25:
            goto L1b
        L29:
            goto L25
        L2c:
            goto La
    }

    public static void CaEjHJeJYSvmtQgG(android.view.object r0, bool r1, java.lang.string r2, int r3, float r4) {
            goto L26
        L4:
            return
        L5:
            goto L2d
        L9:
            int r3 = r2 + r1
            goto Lf
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L1a:
            r0 = 42
            goto L14
        L20:
            int r2 = r0 * r1
            goto L9
        L26:
            goto L5
        L29:
            goto L1a
        L2d:
            goto L29
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable CeuepEhKscRJuIjn(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void CeuepEhKscRJuIjn(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, float r2, bool r3, short r4) {
            goto L23
        L4:
            return
        L5:
            goto L1b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            r0 = 42
            goto L9
        L15:
            int r3 = r2 + r1
            goto L1e
        L1b:
            goto L26
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            goto L5
        L26:
            goto Lf
        L2a:
            int r2 = r0 * r1
            goto L15
    }

    public static void CeuepEhKscRJuIjn(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, bool r2, byte r3, short r4) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0 = 42
            goto L19
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void CeuepEhKscRJuIjn(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, bool r2, short r3, byte r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L21
        L14:
            int r2 = r0 * r1
            goto L9
        L1a:
            goto L10
        L1d:
            goto L24
        L21:
            goto L1d
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    public static int DPpNcrCccbjHaxZx(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = r1.getPaddingLeft()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void DPpNcrCccbjHaxZx(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, short r2, java.lang.string r3, bool r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L2c
        La:
            goto L25
        Le:
            int r3 = r2 + r1
            goto L20
        L14:
            int r2 = r0 * r1
            goto Le
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            r0 = 42
            goto L1a
        L2b:
            return
        L2c:
            goto L4
    }

    public static void DPpNcrCccbjHaxZx(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, char r2, bool r3, java.lang.string r4) {
            goto L1b
        L4:
            return
        L5:
            goto L22
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        Lf:
            r0 = 42
            goto L9
        L15:
            int r3 = r2 + r1
            goto L2b
        L1b:
            goto L5
        L1e:
            goto Lf
        L22:
            goto L1e
        L25:
            int r2 = r0 * r1
            goto L15
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void DPpNcrCccbjHaxZx(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, char r2, java.lang.string r3, short r4) {
            goto L1a
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            return
        Lb:
            goto L21
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            r0 = 42
            goto L2a
        L1a:
            goto Lb
        L1d:
            goto L14
        L21:
            goto L1d
        L24:
            int r3 = r2 + r1
            goto Lf
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void DpsRgrmZFkCZWWrE(com.google.android.material.progressindicator.DeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.registerAnimationCallback(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void DpsRgrmZFkCZWWrE(com.google.android.material.progressindicator.DeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, int r2, bool r3, short r4, java.lang.string r5) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto Le
        Le:
            goto L20
        L11:
            r0 = 42
            goto L17
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            goto La
        L20:
            goto L11
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void DpsRgrmZFkCZWWrE(com.google.android.material.progressindicator.DeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, java.lang.string r2, bool r3, int r4, short r5) {
            goto L24
        L4:
            goto L27
        L7:
            r0 = 42
            goto L13
        Ld:
            int r3 = r2 + r1
            goto L19
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            int r2 = r0 * r1
            goto Ld
        L24:
            goto L2c
        L27:
            goto L7
        L2b:
            return
        L2c:
            goto L4
    }

    public static void DpsRgrmZFkCZWWrE(com.google.android.material.progressindicator.DeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, bool r2, int r3, java.lang.string r4, short r5) {
            goto L23
        L4:
            return
        L5:
            goto L9
        L9:
            goto L26
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L12:
            r0 = 42
            goto Lc
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            goto L5
        L26:
            goto L12
        L2a:
            int r2 = r0 * r1
            goto L18
    }

    public static com.google.android.material.progressindicator.IndeterminateAnimatorDelegate EBOHBzVsGiljMNrr(com.google.android.material.progressindicator.IndeterminateDrawable r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0 = r1.getAnimatorDelegate()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void EBOHBzVsGiljMNrr(com.google.android.material.progressindicator.IndeterminateDrawable r0, java.lang.string r1, byte r2, short r3, bool r4) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L21
        L13:
            r0 = 42
            goto La
        L19:
            return
        L1a:
            goto L10
        L1e:
            goto L1a
        L21:
            goto L13
        L25:
            double r0 = (double) r3
            goto L19
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void EBOHBzVsGiljMNrr(com.google.android.material.progressindicator.IndeterminateDrawable r0, java.lang.string r1, bool r2, byte r3, short r4) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L1a
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L14:
            r0 = 42
            goto Le
        L1a:
            goto L26
        L1d:
            int r2 = r0 * r1
            goto L2a
        L23:
            goto La
        L26:
            goto L14
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void EBOHBzVsGiljMNrr(com.google.android.material.progressindicator.IndeterminateDrawable r0, bool r1, byte r2, java.lang.string r3, short r4) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0 = 42
            goto L1f
        L19:
            int r2 = r0 * r1
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto Le
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable EVCEqMuQtwWNYxCk(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void EVCEqMuQtwWNYxCk(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, bool r2, int r3, byte r4) {
            goto L13
        L4:
            goto L16
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        Ld:
            r0 = 42
            goto L7
        L13:
            goto L2c
        L16:
            goto Ld
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            int r3 = r2 + r1
            goto L1a
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            return
        L2c:
            goto L4
    }

    public static void EVCEqMuQtwWNYxCk(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, char r2, byte r3, bool r4) {
            goto L20
        L4:
            r0 = 42
            goto L2a
        La:
            double r0 = (double) r3
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            return
        L1c:
            goto L27
        L20:
            goto L1c
        L23:
            goto L4
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void EVCEqMuQtwWNYxCk(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, byte r2, int r3, char r4) {
            goto L18
        L4:
            return
        L5:
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        Lf:
            goto L1b
        L12:
            r0 = 42
            goto L9
        L18:
            goto L5
        L1b:
            goto L12
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static int EoVuwBnEQDRYgxZC(android.content.res.TypedArray r1, int r2, int r3) {
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
            int r0 = r1.getInt(r2, r3)
            goto L4
    }

    public static void EoVuwBnEQDRYgxZC(android.content.res.TypedArray r0, int r1, int r2, short r3, float r4, java.lang.string r5, bool r6) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L24
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            double r0 = (double) r3
            goto Lb
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L13
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
    }

    public static void EoVuwBnEQDRYgxZC(android.content.res.TypedArray r0, int r1, int r2, bool r3, float r4, short r5, java.lang.string r6) {
            goto L4
        L4:
            goto L12
        L7:
            goto L1f
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L11:
            return
        L12:
            goto L16
        L16:
            goto L7
        L19:
            int r3 = r2 + r1
            goto L2b
        L1f:
            r0 = 42
            goto Lb
        L25:
            int r2 = r0 * r1
            goto L19
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static void EoVuwBnEQDRYgxZC(android.content.res.TypedArray r0, int r1, int r2, bool r3, short r4, java.lang.string r5, float r6) {
            goto L23
        L4:
            return
        L5:
            goto L9
        L9:
            goto L26
        Lc:
            int r2 = r0 * r1
            goto L1d
        L12:
            r0 = 42
            goto L2a
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            goto L5
        L26:
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable ExGUEYdBWugfpzWC(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void ExGUEYdBWugfpzWC(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, float r2, java.lang.string r3, bool r4) {
            goto L12
        L4:
            return
        L5:
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L24
        Lf:
            goto L15
        L12:
            goto L5
        L15:
            goto L19
        L19:
            r0 = 42
            goto L2a
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void ExGUEYdBWugfpzWC(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, java.lang.string r2, bool r3, float r4) {
            goto L4
        L4:
            goto L21
        L7:
            goto L25
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L11:
            goto L7
        L14:
            int r3 = r2 + r1
            goto L2b
        L1a:
            int r2 = r0 * r1
            goto L14
        L20:
            return
        L21:
            goto L11
        L25:
            r0 = 42
            goto Lb
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void ExGUEYdBWugfpzWC(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, float r2, bool r3, byte r4) {
            goto L1f
        L4:
            goto L22
        L7:
            int r3 = r2 + r1
            goto L2b
        Ld:
            r0 = 42
            goto L13
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L19:
            int r2 = r0 * r1
            goto L7
        L1f:
            goto L27
        L22:
            goto Ld
        L26:
            return
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable EzRDygkphIzNVSdL(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void EzRDygkphIzNVSdL(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, byte r2, java.lang.string r3, short r4) {
            goto Ld
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L2a
        L14:
            return
        L15:
            goto La
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1f:
            double r0 = (double) r3
            goto L14
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r0 = 42
            goto L19
    }

    public static void EzRDygkphIzNVSdL(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, byte r2, short r3, java.lang.string r4) {
            goto L29
        L4:
            return
        L5:
            goto L20
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L14:
            r0 = 42
            goto Le
        L1a:
            int r3 = r2 + r1
            goto L9
        L20:
            goto L2c
        L23:
            int r2 = r0 * r1
            goto L1a
        L29:
            goto L5
        L2c:
            goto L14
    }

    public static void EzRDygkphIzNVSdL(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, byte r2, float r3, short r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            r0 = 42
            goto L4
        L10:
            int r3 = r2 + r1
            goto L1c
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            double r0 = (double) r3
            goto L21
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto La
    }

    public static void FYYDRACaSByNvSeS(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, int r2, java.lang.string r3, short r4, float r5) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r0 = 42
            goto L24
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L20
        L17:
            int r3 = r2 + r1
            goto L4
        L1d:
            goto L10
        L20:
            goto L9
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L17
    }

    public static void FYYDRACaSByNvSeS(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, java.lang.string r2, float r3, int r4, short r5) {
            goto L1e
        L4:
            goto L21
        L7:
            int r2 = r0 * r1
            goto L18
        Ld:
            return
        Le:
            goto L4
        L12:
            r0 = 42
            goto L25
        L18:
            int r3 = r2 + r1
            goto L2b
        L1e:
            goto Le
        L21:
            goto L12
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void FYYDRACaSByNvSeS(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.Action r1, short r2, int r3, java.lang.string r4, float r5) {
            goto L29
        L4:
            return
        L5:
            goto L26
        L9:
            int r2 = r0 * r1
            goto L1a
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1a:
            int r3 = r2 + r1
            goto Lf
        L20:
            r0 = 42
            goto L14
        L26:
            goto L2c
        L29:
            goto L5
        L2c:
            goto L20
    }

    public static bool FYYDRACaSByNvSeS(com.google.android.material.progressindicator.BaseProgressIndicator r1, java.lang.Action r2) {
            goto L14
        L4:
            bool r0 = r1.removeCallbacks(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static int FsrHnUbDCGmCwYHm(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            int r0 = r1.getPaddingBottom()
            goto L7
    }

    public static void FsrHnUbDCGmCwYHm(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, bool r2, int r3, float r4) {
            goto L12
        L4:
            goto L15
        L7:
            int r3 = r2 + r1
            goto Ld
        Ld:
            double r0 = (double) r3
            goto L19
        L12:
            goto L1a
        L15:
            goto L24
        L19:
            return
        L1a:
            goto L4
        L1e:
            int r2 = r0 * r1
            goto L7
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void FsrHnUbDCGmCwYHm(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, bool r2, int r3, char r4) {
            goto L29
        L4:
            goto L2c
        L7:
            r0 = 42
            goto L18
        Ld:
            return
        Le:
            goto L4
        L12:
            int r2 = r0 * r1
            goto L23
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L1e:
            double r0 = (double) r3
            goto Ld
        L23:
            int r3 = r2 + r1
            goto L1e
        L29:
            goto Le
        L2c:
            goto L7
    }

    public static void FsrHnUbDCGmCwYHm(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2, float r3, char r4) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L18
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L21
        L12:
            r0 = 42
            goto L2a
        L18:
            int r3 = r2 + r1
            goto L25
        L1e:
            goto Lb
        L21:
            goto L12
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable GChVYyLzZNbCGpiF(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void GChVYyLzZNbCGpiF(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, short r2, byte r3, bool r4) {
            goto L9
        L4:
            return
        L5:
            goto L1b
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L1e
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            goto Lc
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L16
    }

    public static void GChVYyLzZNbCGpiF(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, byte r2, float r3, bool r4) {
            goto La
        L4:
            r0 = 42
            goto L21
        La:
            goto L1d
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L27:
            int r2 = r0 * r1
            goto L16
        L2d:
            goto Ld
    }

    public static void GChVYyLzZNbCGpiF(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, short r2, byte r3, float r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        La:
            goto L2c
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L4
        L17:
            int r2 = r0 * r1
            goto L22
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            int r3 = r2 + r1
            goto L1d
        L28:
            goto Ld
        L2b:
            return
        L2c:
            goto L28
    }

    public static int GFvHGbUzGCAoxxVY(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = r1.getPaddingTop()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void GFvHGbUzGCAoxxVY(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, short r2, float r3, int r4) {
            goto L13
        L4:
            goto L16
        L7:
            int r3 = r2 + r1
            goto L1a
        Ld:
            int r2 = r0 * r1
            goto L7
        L13:
            goto L20
        L16:
            goto L2a
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L2a:
            r0 = 42
            goto L24
    }

    public static void GFvHGbUzGCAoxxVY(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, float r2, short r3, byte r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L21
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L15:
            r0 = 42
            goto Lf
        L1b:
            int r2 = r0 * r1
            goto L9
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto L15
    }

    public static void GFvHGbUzGCAoxxVY(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, float r2, int r3, byte r4) {
            goto L1d
        L4:
            r0 = 42
            goto L2a
        La:
            goto L20
        Ld:
            int r2 = r0 * r1
            goto L24
        L13:
            double r0 = (double) r3
            goto L18
        L18:
            return
        L19:
            goto La
        L1d:
            goto L19
        L20:
            goto L4
        L24:
            int r3 = r2 + r1
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
    }

    public static void GKvGRBTdDadggDdp(com.google.android.material.progressindicator.DeterminateDrawable r0, float r1) {
            goto L13
        L4:
            r0.setLevelByFraction(r1)
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

    public static void GKvGRBTdDadggDdp(com.google.android.material.progressindicator.DeterminateDrawable r0, float r1, char r2, java.lang.string r3, int r4, bool r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L23
        La:
            return
        Lb:
            goto L15
        Lf:
            r0 = 42
            goto L1d
        L15:
            goto L2c
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L23:
            int r3 = r2 + r1
            goto L18
        L29:
            goto Lb
        L2c:
            goto Lf
    }

    public static void GKvGRBTdDadggDdp(com.google.android.material.progressindicator.DeterminateDrawable r0, float r1, char r2, bool r3, int r4, java.lang.string r5) {
            goto L1a
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        La:
            return
        Lb:
            goto L27
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            r0 = 42
            goto L4
        L1a:
            goto Lb
        L1d:
            goto L14
        L21:
            int r2 = r0 * r1
            goto L2a
        L27:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto Lf
    }

    public static void GKvGRBTdDadggDdp(com.google.android.material.progressindicator.DeterminateDrawable r0, float r1, bool r2, java.lang.string r3, int r4, char r5) {
            goto L13
        L4:
            goto L16
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            r0 = 42
            goto L1a
        L13:
            goto L26
        L16:
            goto Ld
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L20
    }

    public static void GQcMOqwkIdDjyhlE(com.google.android.material.progressindicator.DeterminateDrawable r0, char r1, byte r2, short r3, int r4) {
            goto L4
        L4:
            goto L1a
        L7:
            goto L1e
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L11:
            goto L7
        L14:
            double r0 = (double) r3
            goto L19
        L19:
            return
        L1a:
            goto L11
        L1e:
            r0 = 42
            goto Lb
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L14
    }

    public static void GQcMOqwkIdDjyhlE(com.google.android.material.progressindicator.DeterminateDrawable r0, char r1, int r2, short r3, byte r4) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto L21
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L12:
            r0 = 42
            goto Lc
        L18:
            int r2 = r0 * r1
            goto L2a
        L1e:
            goto L26
        L21:
            goto L12
        L25:
            return
        L26:
            goto L9
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void GQcMOqwkIdDjyhlE(com.google.android.material.progressindicator.DeterminateDrawable r0, short r1, char r2, int r3, byte r4) {
            goto L16
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L25
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            goto L21
        L19:
            goto L4
        L1d:
            goto L19
        L20:
            return
        L21:
            goto L1d
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static bool GQcMOqwkIdDjyhlE(com.google.android.material.progressindicator.DeterminateDrawable r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.hideNow()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    private com.google.android.material.progressindicator.DrawingDelegate<S> GetCurrentDrawingDelegate() {
            r2 = this;
            goto La4
        L4:
            com.google.android.material.progressindicator.IndeterminateDrawable r2 = YpqxqZyAmSGttCMD(r2)
            goto L23
        Lc:
            if (r0 <= 0) goto L11
            goto L73
        L11:
            goto L70
        L15:
            r1 = 31
            goto L65
        L1c:
            r0 = 2
            goto L15
        L23:
            com.google.android.material.progressindicator.DrawingDelegate r2 = ENAAlGYxUUGAAfmH(r2)
            goto L97
        L2b:
            if (r0 == 0) goto L30
            goto L51
        L30:
            goto L50
        L34:
            com.google.android.material.progressindicator.DrawingDelegate r2 = IuLxUXpeXdzWXdmK(r2)
            goto L3c
        L3c:
            return r2
        L3d:
            goto L8d
        L41:
            if (r0 == 0) goto L46
            goto L78
        L46:
            goto L77
        L4a:
            int r0 = r0 % r1
            goto Lc
        L50:
            return r1
        L51:
            goto L9c
        L55:
            bool r0 = BptdMFITmIeEemxa(r2)
            goto L6b
        L5d:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = ceuepEhKscRJuIjn(r2)
            goto L2b
        L65:
            int r0 = r0 + r1
            goto L4a
        L6b:
            r1 = 0
            goto L84
        L70:
            goto L3d
        L73:
            goto L55
        L77:
            return r1
        L78:
            goto L4
        L7c:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = AOGBiwNyScQEEwNa(r2)
            goto L41
        L84:
            if (r0 != 0) goto L89
            goto L98
        L89:
            goto L7c
        L8d:
            goto L73
        L90:
            goto L94
        L94:
            goto La7
        L97:
            return r2
        L98:
            goto L5d
        L9c:
            com.google.android.material.progressindicator.DeterminateDrawable r2 = HzjKygDbqYVKAJJS(r2)
            goto L34
        La4:
            goto L90
        La7:
            goto L1c
    }

    private void GetCurrentDrawingDelegate(int r1, bool r2, short r3, char r4) {
            r0 = this;
            goto L29
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            return
        L16:
            goto L26
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            r0 = 42
            goto L1a
        L26:
            goto L2c
        L29:
            goto L16
        L2c:
            goto L20
    }

    private void GetCurrentDrawingDelegate(short r1, bool r2, char r3, int r4) {
            r0 = this;
            goto L29
        L4:
            goto L2c
        L7:
            r0 = 42
            goto L18
        Ld:
            int r2 = r0 * r1
            goto L23
        L13:
            return
        L14:
            goto L4
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L1e:
            double r0 = (double) r3
            goto L13
        L23:
            int r3 = r2 + r1
            goto L1e
        L29:
            goto L14
        L2c:
            goto L7
    }

    private void GetCurrentDrawingDelegate(bool r1, int r2, char r3, short r4) {
            r0 = this;
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        La:
            int r3 = r2 + r1
            goto L22
        L10:
            goto L18
        L13:
            goto L2a
        L17:
            return
        L18:
            goto L27
        L1c:
            int r2 = r0 * r1
            goto La
        L22:
            double r0 = (double) r3
            goto L17
        L27:
            goto L13
        L2a:
            r0 = 42
            goto L4
    }

    public static void GmnDOYLyckvYdjpi(java.lang.Action r0) {
            goto L10
        L4:
            r0.run()
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void GmnDOYLyckvYdjpi(java.lang.Action r0, int r1, java.lang.string r2, char r3, short r4) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L16:
            double r0 = (double) r3
            goto L25
        L1b:
            goto L21
        L1e:
            goto L26
        L21:
            goto La
        L25:
            return
        L26:
            goto L1b
        L2a:
            int r3 = r2 + r1
            goto L16
    }

    public static void GmnDOYLyckvYdjpi(java.lang.Action r0, java.lang.string r1, short r2, int r3, char r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L1f
        Lb:
            int r2 = r0 * r1
            goto L11
        L11:
            int r3 = r2 + r1
            goto L17
        L17:
            double r0 = (double) r3
            goto L2b
        L1c:
            goto L7
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void GmnDOYLyckvYdjpi(java.lang.Action r0, short r1, int r2, java.lang.string r3, char r4) {
            goto Ld
        L4:
            goto L10
        L7:
            r0 = 42
            goto L1f
        Ld:
            goto L2c
        L10:
            goto L7
        L14:
            int r2 = r0 * r1
            goto L25
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L25:
            int r3 = r2 + r1
            goto L1a
        L2b:
            return
        L2c:
            goto L4
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable GsSvlqFNMfFmqQOY(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void GsSvlqFNMfFmqQOY(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, float r2, java.lang.string r3, char r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            goto L12
        Ld:
            goto L21
        L11:
            return
        L12:
            goto L27
        L16:
            int r3 = r2 + r1
            goto L1c
        L1c:
            double r0 = (double) r3
            goto L11
        L21:
            r0 = 42
            goto L2a
        L27:
            goto Ld
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void GsSvlqFNMfFmqQOY(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, byte r2, float r3, char r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L1f
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L19:
            int r3 = r2 + r1
            goto L2b
        L1f:
            r0 = 42
            goto L13
        L25:
            int r2 = r0 * r1
            goto L19
        L2b:
            double r0 = (double) r3
            goto Lb
    }

    public static void GsSvlqFNMfFmqQOY(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, float r2, char r3, byte r4) {
            goto L29
        L4:
            r0 = 42
            goto Lf
        La:
            double r0 = (double) r3
            goto L1e
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L23
        L1b:
            goto L2c
        L1e:
            return
        L1f:
            goto L1b
        L23:
            int r3 = r2 + r1
            goto La
        L29:
            goto L1f
        L2c:
            goto L4
    }

    public static void GsZKIgwZCGGTnrlF(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.startAnimator()
            goto L4
    }

    public static void GsZKIgwZCGGTnrlF(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, char r1, int r2, float r3, java.lang.string r4) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L10:
            double r0 = (double) r3
            goto L1c
        L15:
            goto L1d
        L18:
            goto L27
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r2 = r0 * r1
            goto L4
        L27:
            r0 = 42
            goto La
        L2d:
            goto L18
    }

    public static void GsZKIgwZCGGTnrlF(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, char r1, java.lang.string r2, float r3, int r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            goto L26
        Ld:
            goto L2a
        L11:
            goto Ld
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            int r3 = r2 + r1
            goto L1a
        L25:
            return
        L26:
            goto L11
        L2a:
            r0 = 42
            goto L14
    }

    public static void GsZKIgwZCGGTnrlF(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, int r1, float r2, char r3, java.lang.string r4) {
            goto L29
        L4:
            return
        L5:
            goto L9
        L9:
            goto L2c
        Lc:
            r0 = 42
            goto L1d
        L12:
            int r3 = r2 + r1
            goto L18
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L23:
            int r2 = r0 * r1
            goto L12
        L29:
            goto L5
        L2c:
            goto Lc
    }

    public static int GzFpFbHfgcSGCGmR(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            int r0 = r1.getPaddingRight()
            goto L4
        L18:
            goto Lc
    }

    public static void GzFpFbHfgcSGCGmR(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, bool r2, short r3, java.lang.string r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L2d
        Le:
            int r2 = r0 * r1
            goto L27
        L14:
            r0 = 42
            goto L21
        L1a:
            goto La
        L1d:
            goto L14
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L27:
            int r3 = r2 + r1
            goto L4
        L2d:
            goto L1d
    }

    public static void GzFpFbHfgcSGCGmR(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, float r2, short r3, bool r4) {
            goto L18
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            goto L1b
        L13:
            return
        L14:
            goto L10
        L18:
            goto L14
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto L4
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void GzFpFbHfgcSGCGmR(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, bool r2, float r3, short r4) {
            goto L20
        L4:
            return
        L5:
            goto L2d
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r3 = r2 + r1
            goto L9
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L1a:
            r0 = 42
            goto L14
        L20:
            goto L5
        L23:
            goto L1a
        L27:
            int r2 = r0 * r1
            goto Le
        L2d:
            goto L23
    }

    public static void HBZllDKfwaLLrzrD(com.google.android.material.progressindicator.IndeterminateDrawable r0, char r1, float r2, java.lang.string r3, short r4) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r0 = 42
            goto L21
        L15:
            goto L1d
        L18:
            goto Lf
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L27:
            int r2 = r0 * r1
            goto L9
        L2d:
            goto L18
    }

    public static void HBZllDKfwaLLrzrD(com.google.android.material.progressindicator.IndeterminateDrawable r0, char r1, java.lang.string r2, float r3, short r4) {
            goto L19
        L4:
            goto L1c
        L7:
            r0 = 42
            goto Ld
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L13:
            int r3 = r2 + r1
            goto L20
        L19:
            goto L26
        L1c:
            goto L7
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L13
    }

    public static void HBZllDKfwaLLrzrD(com.google.android.material.progressindicator.IndeterminateDrawable r0, java.lang.string r1, short r2, float r3, char r4) {
            goto La
        L4:
            r0 = 42
            goto L24
        La:
            goto L17
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto Ld
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static bool HBZllDKfwaLLrzrD(com.google.android.material.progressindicator.IndeterminateDrawable r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.isVisible()
            goto L4
        L18:
            goto Lc
    }

    public static android.content.object IKwjvHPfTLAPxZpE(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lf
        L4:
            goto L12
        L7:
            android.content.object r0 = r1.getobject()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void IKwjvHPfTLAPxZpE(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, short r2, byte r3, int r4) {
            goto L1e
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L10:
            goto L21
        L13:
            int r3 = r2 + r1
            goto L2b
        L19:
            return
        L1a:
            goto L10
        L1e:
            goto L1a
        L21:
            goto L4
        L25:
            int r2 = r0 * r1
            goto L13
        L2b:
            double r0 = (double) r3
            goto L19
    }

    public static void IKwjvHPfTLAPxZpE(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, short r2, int r3, byte r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L19
        La:
            goto L26
        Ld:
            goto L2a
        L11:
            goto Ld
        L14:
            double r0 = (double) r3
            goto L25
        L19:
            int r3 = r2 + r1
            goto L14
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            return
        L26:
            goto L11
        L2a:
            r0 = 42
            goto L1f
    }

    public static void IKwjvHPfTLAPxZpE(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, byte r2, int r3, java.lang.string r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        La:
            goto L23
        Ld:
            goto L2a
        L11:
            double r0 = (double) r3
            goto L22
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            return
        L23:
            goto L27
        L27:
            goto Ld
        L2a:
            r0 = 42
            goto L4
    }

    public static android.graphics.drawable.Drawable IkMjteYMcBwBmuNV(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
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
            android.graphics.drawable.Drawable r0 = r1.getCurrentDrawable()
            goto Le
    }

    public static void IkMjteYMcBwBmuNV(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, float r2, int r3, byte r4) {
            goto L13
        L4:
            r0 = 42
            goto L2a
        La:
            goto L16
        Ld:
            int r2 = r0 * r1
            goto L1f
        L13:
            goto L26
        L16:
            goto L4
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            int r3 = r2 + r1
            goto L1a
        L25:
            return
        L26:
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
    }

    public static void IkMjteYMcBwBmuNV(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, int r2, byte r3, char r4) {
            goto L26
        L4:
            r0 = 42
            goto L1a
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            return
        L16:
            goto L2d
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L20:
            int r2 = r0 * r1
            goto Lf
        L26:
            goto L16
        L29:
            goto L4
        L2d:
            goto L29
    }

    public static void IkMjteYMcBwBmuNV(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, char r2, float r3, byte r4) {
            goto L18
        L4:
            goto L1b
        L7:
            double r0 = (double) r3
            goto L25
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L12:
            r0 = 42
            goto Lc
        L18:
            goto L26
        L1b:
            goto L12
        L1f:
            int r3 = r2 + r1
            goto L7
        L25:
            return
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    private void InternalHide() {
            r3 = this;
            goto L56
        L4:
            wBKcwkiMSOyzUqSw(r3, r0)
        L7:
            goto L3c
        Lb:
            goto L3d
        Le:
            goto L6f
        L12:
            com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0 = (com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange) r0
            goto L63
        L18:
            goto L59
        L1b:
            goto Le
        L1e:
            goto L18
        L22:
            bool r0 = tviyraPZJzmxNSOq(r3)
            goto L4d
        L2a:
            int r0 = r0 % r1
            goto L77
        L30:
            r2 = 1
            goto L35
        L35:
            pmmewIoygGIPUHjA(r0, r1, r1, r2)
            goto L22
        L3c:
            return
        L3d:
            goto L1b
        L41:
            r0 = 4
            goto L4
        L46:
            r0 = 10
            goto L68
        L4d:
            if (r0 != 0) goto L52
            goto L7
        L52:
            goto L41
        L56:
            goto L1e
        L59:
            goto L46
        L5d:
            int r0 = r0 + r1
            goto L2a
        L63:
            r1 = 0
            goto L30
        L68:
            r1 = 5
            goto L5d
        L6f:
            android.graphics.drawable.Drawable r0 = ikMjteYMcBwBmuNV(r3)
            goto L12
        L77:
            if (r0 <= 0) goto L7c
            goto Le
        L7c:
            goto Lb
    }

    private void InternalHide(int r1, java.lang.string r2, bool r3, short r4) {
            r0 = this;
            goto L29
        L4:
            goto L2c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        Ld:
            return
        Le:
            goto L4
        L12:
            int r3 = r2 + r1
            goto L1e
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            double r0 = (double) r3
            goto Ld
        L23:
            r0 = 42
            goto L7
        L29:
            goto Le
        L2c:
            goto L23
    }

    private void InternalHide(int r1, bool r2, short r3, java.lang.string r4) {
            r0 = this;
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        La:
            goto L26
        Ld:
            goto L2a
        L11:
            double r0 = (double) r3
            goto L25
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            goto Ld
        L25:
            return
        L26:
            goto L22
        L2a:
            r0 = 42
            goto L4
    }

    private void InternalHide(bool r1, java.lang.string r2, int r3, short r4) {
            r0 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0 = 42
            goto L1f
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            double r0 = (double) r3
            goto Le
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    private void InternalShow() {
            r2 = this;
            goto L14
        L4:
            goto L29
        L7:
            goto Lb
        Lb:
            goto L17
        Le:
            int r0 = r0 + r1
            goto L1b
        L14:
            goto L7
        L17:
            goto L61
        L1b:
            int r0 = r0 % r1
            goto L3c
        L21:
            r0 = 0
            goto L45
        L26:
            goto L69
        L29:
            goto L2d
        L2d:
            int r0 = r2.minHideDelay
            goto L33
        L33:
            if (r0 > 0) goto L38
            goto L4e
        L38:
            goto L59
        L3c:
            if (r0 <= 0) goto L41
            goto L29
        L41:
            goto L26
        L45:
            WphZNtUsPiBgRXUq(r2, r0)
            goto L68
        L4c:
            r2.lastShowStartTime = r0
        L4e:
            goto L21
        L52:
            r1 = 17
            goto Le
        L59:
            long r0 = mMPaTeOjwwjwCgqe()
            goto L4c
        L61:
            r0 = 30
            goto L52
        L68:
            return
        L69:
            goto L4
    }

    private void InternalShow(int r1, short r2, byte r3, java.lang.string r4) {
            r0 = this;
            goto La
        L4:
            int r3 = r2 + r1
            goto L28
        La:
            goto L1e
        Ld:
            goto L17
        L11:
            int r2 = r0 * r1
            goto L4
        L17:
            r0 = 42
            goto L22
        L1d:
            return
        L1e:
            goto L2d
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto Ld
    }

    private void InternalShow(java.lang.string r1, int r2, short r3, byte r4) {
            r0 = this;
            goto La
        L4:
            int r3 = r2 + r1
            goto L1c
        La:
            goto L18
        Ld:
            goto L27
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L17:
            return
        L18:
            goto L2d
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            int r2 = r0 * r1
            goto L4
        L27:
            r0 = 42
            goto L11
        L2d:
            goto Ld
    }

    private void InternalShow(short r1, int r2, java.lang.string r3, byte r4) {
            r0 = this;
            goto La
        L4:
            int r3 = r2 + r1
            goto L1d
        La:
            goto L2c
        Ld:
            goto L17
        L11:
            int r2 = r0 * r1
            goto L4
        L17:
            r0 = 42
            goto L25
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            goto Ld
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L2b:
            return
        L2c:
            goto L22
    }

    public static void IqahmmplcgylBqOv(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.registerAnimatorsCompleteCallback(r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void IqahmmplcgylBqOv(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, char r2, java.lang.string r3, float r4, byte r5) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            goto L23
        L12:
            goto L27
        L16:
            int r3 = r2 + r1
            goto La
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            return
        L23:
            goto L2d
        L27:
            r0 = 42
            goto L4
        L2d:
            goto L12
    }

    public static void IqahmmplcgylBqOv(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, float r2, java.lang.string r3, byte r4, char r5) {
            goto L29
        L4:
            goto L2c
        L7:
            int r3 = r2 + r1
            goto L1f
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L13:
            int r2 = r0 * r1
            goto L7
        L19:
            r0 = 42
            goto Ld
        L1f:
            double r0 = (double) r3
            goto L24
        L24:
            return
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto L19
    }

    public static void IqahmmplcgylBqOv(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, java.lang.string r2, byte r3, float r4, char r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        La:
            r0 = 42
            goto L4
        L10:
            double r0 = (double) r3
            goto L1b
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            return
        L1c:
            goto L26
        L20:
            int r2 = r0 * r1
            goto L15
        L26:
            goto L2c
        L29:
            goto L1c
        L2c:
            goto La
    }

    private void IsNolongerNeedToBeVisible(byte r1, short r2, char r3, int r4) {
            r0 = this;
            goto L19
        L4:
            int r2 = r0 * r1
            goto L13
        La:
            goto L1c
        Ld:
            r0 = 42
            goto L25
        L13:
            int r3 = r2 + r1
            goto L20
        L19:
            goto L2c
        L1c:
            goto Ld
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2b:
            return
        L2c:
            goto La
    }

    private void IsNolongerNeedToBeVisible(int r1, byte r2, short r3, char r4) {
            r0 = this;
            goto L23
        L4:
            goto L26
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        Ld:
            double r0 = (double) r3
            goto L1e
        L12:
            r0 = 42
            goto L7
        L18:
            int r2 = r0 * r1
            goto L2a
        L1e:
            return
        L1f:
            goto L4
        L23:
            goto L1f
        L26:
            goto L12
        L2a:
            int r3 = r2 + r1
            goto Ld
    }

    private void IsNolongerNeedToBeVisible(short r1, char r2, int r3, byte r4) {
            r0 = this;
            goto L24
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L27
        Lc:
            int r2 = r0 * r1
            goto L12
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            r0 = 42
            goto L1e
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L24:
            goto L2c
        L27:
            goto L18
        L2b:
            return
        L2c:
            goto L9
    }

    private bool IsNolongerNeedToBeVisible() {
            r1 = this;
            goto L1f
        L4:
            if (r0 != 0) goto L9
            goto L66
        L9:
            goto L50
        Ld:
            if (r1 == 0) goto L12
            goto L44
        L12:
            goto L43
        L16:
            if (r0 == 0) goto L1b
            goto L44
        L1b:
            goto L3b
        L1f:
            goto L61
        L22:
            goto L6a
        L26:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = kszOGuoAzsxWAylV(r1)
            goto L58
        L2e:
            r1 = 1
            goto L60
        L33:
            bool r1 = hBZllDKfwaLLrzrD(r1)
            goto Ld
        L3b:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = ezRDygkphIzNVSdL(r1)
            goto L4
        L43:
            goto L66
        L44:
            goto L48
        L48:
            r1 = 0
            goto L65
        L4d:
            goto L22
        L50:
            com.google.android.material.progressindicator.IndeterminateDrawable r1 = TqoZlKonttqYCHji(r1)
            goto L33
        L58:
            bool r0 = yTocOmfrQPHRQXBL(r0)
            goto L16
        L60:
            return r1
        L61:
            goto L4d
        L65:
            return r1
        L66:
            goto L2e
        L6a:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = exGUEYdBWugfpzWC(r1)
            goto L72
        L72:
            if (r0 != 0) goto L77
            goto L1b
        L77:
            goto L26
    }

    public static void KSWvwUGBcIYYdCwx(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.setProgressCompat(r1, r2)
            goto L4
    }

    public static void KSWvwUGBcIYYdCwx(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2, java.lang.string r3, char r4, float r5, short r6) {
            goto L13
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        La:
            goto L16
        Ld:
            int r2 = r0 * r1
            goto L2a
        L13:
            goto L26
        L16:
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto L4
        L25:
            return
        L26:
            goto La
        L2a:
            int r3 = r2 + r1
            goto L1a
    }

    public static void KSWvwUGBcIYYdCwx(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2, java.lang.string r3, short r4, float r5, char r6) {
            goto L4
        L4:
            goto L29
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L11
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L17:
            int r3 = r2 + r1
            goto L1d
        L1d:
            double r0 = (double) r3
            goto L28
        L22:
            int r2 = r0 * r1
            goto L17
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L7
    }

    public static void KSWvwUGBcIYYdCwx(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2, short r3, java.lang.string r4, float r5, char r6) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            goto L23
        Lc:
            goto L27
        L10:
            int r2 = r0 * r1
            goto L16
        L16:
            int r3 = r2 + r1
            goto L4
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L22:
            return
        L23:
            goto L2d
        L27:
            r0 = 42
            goto L1c
        L2d:
            goto Lc
    }

    public static int KStYTjDMDXTYCgbg(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = r1.getPaddingTop()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void KStYTjDMDXTYCgbg(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, byte r3, bool r4) {
            goto L12
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L15
        Lc:
            int r2 = r0 * r1
            goto L1f
        L12:
            goto L2c
        L15:
            goto L19
        L19:
            r0 = 42
            goto L25
        L1f:
            int r3 = r2 + r1
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L2b:
            return
        L2c:
            goto L9
    }

    public static void KStYTjDMDXTYCgbg(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, char r2, byte r3, bool r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            r0 = 42
            goto L2a
        L10:
            goto L1d
        L13:
            goto La
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L13
        L24:
            int r3 = r2 + r1
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void KStYTjDMDXTYCgbg(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2, char r3, byte r4) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            r0 = 42
            goto L4
        L10:
            int r3 = r2 + r1
            goto L2b
        L16:
            return
        L17:
            goto L21
        L1b:
            int r2 = r0 * r1
            goto L10
        L21:
            goto L27
        L24:
            goto L17
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L16
    }

    public static void KeAQZdzCPzIAfqSP(android.widget.ProgressBar r0) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            super.invalidate()
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void KeAQZdzCPzIAfqSP(android.widget.ProgressBar r0, int r1, short r2, java.lang.string r3, bool r4) {
            goto L26
        L4:
            return
        L5:
            goto L2d
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r2 = r0 * r1
            goto L14
        L14:
            int r3 = r2 + r1
            goto L9
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L20:
            r0 = 42
            goto L1a
        L26:
            goto L5
        L29:
            goto L20
        L2d:
            goto L29
    }

    public static void KeAQZdzCPzIAfqSP(android.widget.ProgressBar r0, java.lang.string r1, bool r2, short r3, int r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L24
        L9:
            goto L2c
        Lc:
            int r2 = r0 * r1
            goto L12
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L1e:
            r0 = 42
            goto L18
        L24:
            return
        L25:
            goto L9
        L29:
            goto L25
        L2c:
            goto L1e
    }

    public static void KeAQZdzCPzIAfqSP(android.widget.ProgressBar r0, bool r1, int r2, short r3, java.lang.string r4) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        La:
            int r3 = r2 + r1
            goto L1c
        L10:
            return
        L11:
            goto L21
        L15:
            goto L11
        L18:
            goto L2a
        L1c:
            double r0 = (double) r3
            goto L10
        L21:
            goto L18
        L24:
            int r2 = r0 * r1
            goto La
        L2a:
            r0 = 42
            goto L4
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable KszOGuoAzsxWAylV(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
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
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto L4
    }

    public static void KszOGuoAzsxWAylV(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, short r2, bool r3, float r4) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            r0 = 42
            goto L4
        L10:
            double r0 = (double) r3
            goto L22
        L15:
            int r2 = r0 * r1
            goto L2a
        L1b:
            goto L23
        L1e:
            goto La
        L22:
            return
        L23:
            goto L27
        L27:
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void KszOGuoAzsxWAylV(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, float r2, byte r3, bool r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto L26
        Lc:
            goto L16
        L10:
            int r2 = r0 * r1
            goto L2a
        L16:
            r0 = 42
            goto L1f
        L1c:
            goto Lc
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L25:
            return
        L26:
            goto L1c
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void KszOGuoAzsxWAylV(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, bool r2, byte r3, float r4) {
            goto L12
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L15
        L12:
            goto L20
        L15:
            goto L24
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            return
        L20:
            goto Lf
        L24:
            r0 = 42
            goto L19
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static int KtdvsMtYmozworzE(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = r1.getPaddingLeft()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void KtdvsMtYmozworzE(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, float r2, byte r3, bool r4) {
            goto L12
        L4:
            r0 = 42
            goto L1f
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L4
        L19:
            int r3 = r2 + r1
            goto L2b
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto L19
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void KtdvsMtYmozworzE(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, char r2, byte r3, float r4) {
            goto L1d
        L4:
            goto L20
        L7:
            return
        L8:
            goto L4
        Lc:
            r0 = 42
            goto L12
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            double r0 = (double) r3
            goto L7
        L1d:
            goto L8
        L20:
            goto Lc
        L24:
            int r3 = r2 + r1
            goto L18
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void KtdvsMtYmozworzE(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, float r2, char r3, byte r4) {
            goto L1d
        L4:
            return
        L5:
            goto L9
        L9:
            goto L20
        Lc:
            int r2 = r0 * r1
            goto L17
        L12:
            double r0 = (double) r3
            goto L4
        L17:
            int r3 = r2 + r1
            goto L12
        L1d:
            goto L5
        L20:
            goto L24
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
    }

    public static void LlQWTpHLXQwTEExo(android.widget.ProgressBar r0) {
            goto L13
        L4:
            goto L16
        L7:
            super.onAttachedToWindow()
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

    public static void LlQWTpHLXQwTEExo(android.widget.ProgressBar r0, byte r1, float r2, bool r3, short r4) {
            goto Ld
        L4:
            int r3 = r2 + r1
            goto L14
        La:
            goto L10
        Ld:
            goto L20
        L10:
            goto L19
        L14:
            double r0 = (double) r3
            goto L1f
        L19:
            r0 = 42
            goto L2a
        L1f:
            return
        L20:
            goto La
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void LlQWTpHLXQwTEExo(android.widget.ProgressBar r0, float r1, short r2, bool r3, byte r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L12
        Ld:
            goto L24
        L11:
            return
        L12:
            goto L1c
        L16:
            int r3 = r2 + r1
            goto L1f
        L1c:
            goto Ld
        L1f:
            double r0 = (double) r3
            goto L11
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L16
    }

    public static void LlQWTpHLXQwTEExo(android.widget.ProgressBar r0, short r1, byte r2, float r3, bool r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            goto L1d
        Ld:
            goto L2a
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            int r2 = r0 * r1
            goto L21
        L1c:
            return
        L1d:
            goto L27
        L21:
            int r3 = r2 + r1
            goto L11
        L27:
            goto Ld
        L2a:
            r0 = 42
            goto L4
    }

    public static long MMPaTeOjwwjwCgqe() {
            goto L2b
        L4:
            goto L1f
        L7:
            goto L19
        Lb:
            if (r0 <= 0) goto L10
            goto L1f
        L10:
            goto L1c
        L14:
            return r0
        L15:
            goto L4
        L19:
            goto L2e
        L1c:
            goto L15
        L1f:
            goto L23
        L23:
            long r0 = android.os.SystemClock.uptimeMillis()
            goto L14
        L2b:
            goto L7
        L2e:
            goto L39
        L32:
            r1 = 2
            goto L46
        L39:
            r0 = 17
            goto L32
        L40:
            int r0 = r0 % r1
            goto Lb
        L46:
            int r0 = r0 + r1
            goto L40
    }

    public static void MMPaTeOjwwjwCgqe(char r0, java.lang.string r1, short r2, float r3) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L18
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L21
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L18:
            int r3 = r2 + r1
            goto L2b
        L1e:
            goto Lb
        L21:
            goto L25
        L25:
            r0 = 42
            goto L12
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void MMPaTeOjwwjwCgqe(float r0, java.lang.string r1, short r2, char r3) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            return
        Lb:
            goto L2d
        Lf:
            int r2 = r0 * r1
            goto L1c
        L15:
            goto Lb
        L18:
            goto L27
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto La
        L27:
            r0 = 42
            goto L4
        L2d:
            goto L18
    }

    public static void MMPaTeOjwwjwCgqe(float r0, short r1, char r2, java.lang.string r3) {
            goto L4
        L4:
            goto L26
        L7:
            goto L1f
        Lb:
            int r2 = r0 * r1
            goto L11
        L11:
            int r3 = r2 + r1
            goto L1a
        L17:
            goto L7
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto L2a
        L25:
            return
        L26:
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
    }

    public static int MbiHAuyWwoOtrheM(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = r1.getVisibility()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void MbiHAuyWwoOtrheM(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, bool r2, java.lang.string r3, float r4) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            r0 = 42
            goto L2a
        L10:
            return
        L11:
            goto L15
        L15:
            goto L26
        L18:
            double r0 = (double) r3
            goto L10
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            goto L11
        L26:
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void MbiHAuyWwoOtrheM(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, float r2, bool r3, char r4) {
            goto Lf
        L4:
            return
        L5:
            goto L22
        L9:
            int r3 = r2 + r1
            goto L25
        Lf:
            goto L5
        L12:
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1c:
            r0 = 42
            goto L16
        L22:
            goto L12
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static void MbiHAuyWwoOtrheM(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, java.lang.string r2, char r3, float r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            goto L17
        Ld:
            goto L1b
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L21
        L1b:
            r0 = 42
            goto L2a
        L21:
            goto Ld
        L24:
            int r3 = r2 + r1
            goto L11
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static int MoiTMHpQquPzrwYw(com.google.android.material.progressindicator.DrawingDelegate r1) {
            goto L14
        L4:
            int r0 = r1.getPreferredHeight()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void MoiTMHpQquPzrwYw(com.google.android.material.progressindicator.DrawingDelegate r0, byte r1, java.lang.string r2, int r3, bool r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L23
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L16:
            double r0 = (double) r3
            goto L1b
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L2c
        L23:
            int r3 = r2 + r1
            goto L16
        L29:
            goto L1c
        L2c:
            goto La
    }

    public static void MoiTMHpQquPzrwYw(com.google.android.material.progressindicator.DrawingDelegate r0, int r1, byte r2, bool r3, java.lang.string r4) {
            goto L1e
        L4:
            return
        L5:
            goto L1b
        L9:
            int r2 = r0 * r1
            goto L25
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1b:
            goto L21
        L1e:
            goto L5
        L21:
            goto Lf
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void MoiTMHpQquPzrwYw(com.google.android.material.progressindicator.DrawingDelegate r0, java.lang.string r1, bool r2, byte r3, int r4) {
            goto L29
        L4:
            return
        L5:
            goto L26
        L9:
            int r3 = r2 + r1
            goto L1b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L15:
            r0 = 42
            goto Lf
        L1b:
            double r0 = (double) r3
            goto L4
        L20:
            int r2 = r0 * r1
            goto L9
        L26:
            goto L2c
        L29:
            goto L5
        L2c:
            goto L15
    }

    public static void NRLShGzbIyqCENKj(com.google.android.material.progressindicator.IndeterminateDrawable r0, byte r1, java.lang.string r2, float r3, bool r4) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L1b
        L12:
            int r2 = r0 * r1
            goto L9
        L18:
            goto L2c
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L2b:
            return
        L2c:
            goto Lf
    }

    public static void NRLShGzbIyqCENKj(com.google.android.material.progressindicator.IndeterminateDrawable r0, float r1, bool r2, java.lang.string r3, byte r4) {
            goto L4
        L4:
            goto L18
        L7:
            goto L21
        Lb:
            int r3 = r2 + r1
            goto L1c
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L17:
            return
        L18:
            goto L27
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            r0 = 42
            goto L11
        L27:
            goto L7
        L2a:
            int r2 = r0 * r1
            goto Lb
    }

    public static void NRLShGzbIyqCENKj(com.google.android.material.progressindicator.IndeterminateDrawable r0, java.lang.string r1, byte r2, float r3, bool r4) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            goto L1b
        L12:
            r0 = 42
            goto L9
        L18:
            goto L20
        L1b:
            goto L12
        L1f:
            return
        L20:
            goto Lf
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static bool NRLShGzbIyqCENKj(com.google.android.material.progressindicator.IndeterminateDrawable r1) {
            goto Lf
        L4:
            bool r0 = r1.isVisible()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static int NcgkkMZHMEGEnzrH(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L11
        L4:
            int r0 = r1.getWidth()
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

    public static void NcgkkMZHMEGEnzrH(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, java.lang.string r2, short r3, int r4) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L16
        Lb:
            int r2 = r0 * r1
            goto L2a
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            r0 = 42
            goto L24
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L7
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static void NcgkkMZHMEGEnzrH(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, byte r2, short r3, int r4) {
            goto L23
        L4:
            goto L26
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L18
        L13:
            double r0 = (double) r3
            goto L1e
        L18:
            int r3 = r2 + r1
            goto L13
        L1e:
            return
        L1f:
            goto L4
        L23:
            goto L1f
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L7
    }

    public static void NcgkkMZHMEGEnzrH(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, java.lang.string r2, byte r3, int r4) {
            goto L23
        L4:
            return
        L5:
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L1e
        Lf:
            goto L26
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L18:
            int r2 = r0 * r1
            goto L9
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            goto L5
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L12
    }

    public static void NfmiXCHUHkIKQtgf(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.invalidate()
            goto L4
        L17:
            goto Lc
    }

    public static void NfmiXCHUHkIKQtgf(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, bool r2, float r3, int r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L15:
            return
        L16:
            goto L20
        L1a:
            int r2 = r0 * r1
            goto L4
        L20:
            goto L2c
        L23:
            r0 = 42
            goto Lf
        L29:
            goto L16
        L2c:
            goto L23
    }

    public static void NfmiXCHUHkIKQtgf(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, float r2, int r3, java.lang.string r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            goto L2c
        Ld:
            goto L1a
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            goto Ld
        L1a:
            r0 = 42
            goto L11
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r3 = r2 + r1
            goto L20
        L2b:
            return
        L2c:
            goto L17
    }

    public static void NfmiXCHUHkIKQtgf(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, int r2, float r3, java.lang.string r4) {
            goto L16
        L4:
            int r2 = r0 * r1
            goto L20
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            r0 = 42
            goto La
        L16:
            goto L27
        L19:
            goto L10
        L1d:
            goto L19
        L20:
            int r3 = r2 + r1
            goto L2b
        L26:
            return
        L27:
            goto L1d
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable NpXspKMlvDfveNKm(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void NpXspKMlvDfveNKm(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, java.lang.string r3, short r4) {
            goto La
        L4:
            r0 = 42
            goto L2a
        La:
            goto L17
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto Ld
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L11
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void NpXspKMlvDfveNKm(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, java.lang.string r2, short r3, char r4) {
            goto L21
        L4:
            int r3 = r2 + r1
            goto L1c
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            r0 = 42
            goto La
        L1c:
            double r0 = (double) r3
            goto L28
        L21:
            goto L29
        L24:
            goto L16
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L24
    }

    public static void NpXspKMlvDfveNKm(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, java.lang.string r2, char r3, int r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        La:
            goto L18
        Ld:
            goto L24
        L11:
            int r2 = r0 * r1
            goto L2a
        L17:
            return
        L18:
            goto L21
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            goto Ld
        L24:
            r0 = 42
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L1c
    }

    public static int OEkWtpevEmGfezyb(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = r1.getPaddingBottom()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void OEkWtpevEmGfezyb(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, bool r2, java.lang.string r3, byte r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L2a
        Lb:
            goto L7
        Le:
            int r3 = r2 + r1
            goto L20
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L1a:
            int r2 = r0 * r1
            goto Le
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto Lb
        L2a:
            r0 = 42
            goto L14
    }

    public static void OEkWtpevEmGfezyb(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, byte r2, java.lang.string r3, char r4) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L25
        L10:
            goto L21
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L19:
            return
        L1a:
            goto L10
        L1e:
            goto L1a
        L21:
            goto L2a
        L25:
            double r0 = (double) r3
            goto L19
        L2a:
            r0 = 42
            goto L13
    }

    public static void OEkWtpevEmGfezyb(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, char r2, byte r3, java.lang.string r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            goto L2c
        Ld:
            goto L17
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            r0 = 42
            goto L11
        L1d:
            goto Ld
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r3 = r2 + r1
            goto L20
        L2b:
            return
        L2c:
            goto L1d
    }

    public static int OGzmOqKthKBwHggS(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
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
            int r0 = r1.getPaddingBottom()
            goto Le
    }

    public static void OGzmOqKthKBwHggS(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, java.lang.string r3, bool r4) {
            goto L4
        L4:
            goto L20
        L7:
            goto L2a
        Lb:
            int r2 = r0 * r1
            goto L24
        L11:
            double r0 = (double) r3
            goto L1f
        L16:
            goto L7
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L1f:
            return
        L20:
            goto L16
        L24:
            int r3 = r2 + r1
            goto L11
        L2a:
            r0 = 42
            goto L19
    }

    public static void OGzmOqKthKBwHggS(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, java.lang.string r2, int r3, bool r4) {
            goto L12
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            goto L15
        Ld:
            double r0 = (double) r3
            goto L19
        L12:
            goto L1a
        L15:
            goto L1e
        L19:
            return
        L1a:
            goto La
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto Ld
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void OGzmOqKthKBwHggS(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, java.lang.string r2, int r3, char r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L14
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L11:
            goto L7
        L14:
            r0 = 42
            goto Lb
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L1a
        L2b:
            return
        L2c:
            goto L11
    }

    public static int OIvtwbonGmimJoiu(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = r1.getProgress()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void OIvtwbonGmimJoiu(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, float r2, java.lang.string r3, short r4) {
            goto L1c
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L16
        L10:
            r0 = 42
            goto L4
        L16:
            int r3 = r2 + r1
            goto L23
        L1c:
            goto L29
        L1f:
            goto L10
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1f
    }

    public static void OIvtwbonGmimJoiu(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, short r2, java.lang.string r3, float r4) {
            goto L1f
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        La:
            r0 = 42
            goto L4
        L10:
            goto L22
        L13:
            int r3 = r2 + r1
            goto L26
        L19:
            int r2 = r0 * r1
            goto L13
        L1f:
            goto L2c
        L22:
            goto La
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L10
    }

    public static void OIvtwbonGmimJoiu(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, byte r2, java.lang.string r3, float r4) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto Lc
        L9:
            goto L20
        Lc:
            return
        Ld:
            goto L9
        L11:
            int r3 = r2 + r1
            goto L4
        L17:
            int r2 = r0 * r1
            goto L11
        L1d:
            goto Ld
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L2a:
            r0 = 42
            goto L24
    }

    public static android.content.object ONkmSIYxQSAmZmRh(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            android.content.object r0 = r1.getobject()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void ONkmSIYxQSAmZmRh(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, java.lang.string r2, bool r3, short r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        La:
            goto L15
        Ld:
            goto L24
        L11:
            goto Ld
        L14:
            return
        L15:
            goto L11
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r0 = 42
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    public static void ONkmSIYxQSAmZmRh(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, bool r2, java.lang.string r3, short r4) {
            goto L12
        L4:
            goto L15
        L7:
            return
        L8:
            goto L4
        Lc:
            r0 = 42
            goto L19
        L12:
            goto L8
        L15:
            goto Lc
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L7
    }

    public static void ONkmSIYxQSAmZmRh(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, int r2, bool r3, java.lang.string r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L1e
        La:
            goto L26
        Ld:
            return
        Le:
            goto La
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L18:
            int r2 = r0 * r1
            goto L4
        L1e:
            double r0 = (double) r3
            goto Ld
        L23:
            goto Le
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L12
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable OsIxzfXkHMladAgF(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void OsIxzfXkHMladAgF(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, short r3, bool r4) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            goto L20
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto La
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1d:
            goto L13
        L20:
            goto L24
        L24:
            r0 = 42
            goto L17
        L2a:
            int r3 = r2 + r1
            goto Ld
    }

    public static void OsIxzfXkHMladAgF(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, bool r2, short r3, int r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            r0 = 42
            goto L12
        Lf:
            goto L2c
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L18:
            int r3 = r2 + r1
            goto L4
        L1e:
            return
        L1f:
            goto Lf
        L23:
            int r2 = r0 * r1
            goto L18
        L29:
            goto L1f
        L2c:
            goto L9
    }

    public static void OsIxzfXkHMladAgF(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, char r2, short r3, bool r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L2a
        Lb:
            double r0 = (double) r3
            goto L25
        L10:
            int r3 = r2 + r1
            goto Lb
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1c:
            goto L7
        L1f:
            int r2 = r0 * r1
            goto L10
        L25:
            return
        L26:
            goto L1c
        L2a:
            r0 = 42
            goto L16
    }

    public static int OxMwAyRaaxyQQSWR(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
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
            int r0 = r1.getPaddingTop()
            goto Le
    }

    public static void OxMwAyRaaxyQQSWR(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, float r3, java.lang.string r4) {
            goto L4
        L4:
            goto L1b
        L7:
            goto L2a
        Lb:
            int r3 = r2 + r1
            goto L1f
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L17:
            goto L7
        L1a:
            return
        L1b:
            goto L17
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            int r2 = r0 * r1
            goto Lb
        L2a:
            r0 = 42
            goto L11
    }

    public static void OxMwAyRaaxyQQSWR(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, java.lang.string r2, int r3, float r4) {
            goto L12
        L4:
            goto L15
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L2b
        L12:
            goto L8
        L15:
            goto L19
        L19:
            r0 = 42
            goto L25
        L1f:
            int r2 = r0 * r1
            goto Lc
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L7
    }

    public static void OxMwAyRaaxyQQSWR(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, int r2, java.lang.string r3, char r4) {
            goto L17
        L4:
            goto L1a
        L7:
            double r0 = (double) r3
            goto Lc
        Lc:
            return
        Ld:
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L17:
            goto Ld
        L1a:
            goto L2a
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L7
        L2a:
            r0 = 42
            goto L11
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable PWWUYfcJZAPSuPCC(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void PWWUYfcJZAPSuPCC(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, float r2, short r3, java.lang.string r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L1b
        L13:
            goto L24
        L17:
            goto L13
        L1a:
            return
        L1b:
            goto L17
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            r0 = 42
            goto La
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void PWWUYfcJZAPSuPCC(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, short r2, float r3, java.lang.string r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L11
        La:
            goto L1d
        Ld:
            goto L16
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            r0 = 42
            goto L21
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L27:
            int r2 = r0 * r1
            goto L4
        L2d:
            goto Ld
    }

    public static void PWWUYfcJZAPSuPCC(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, short r2, char r3, java.lang.string r4) {
            goto La
        L4:
            r0 = 42
            goto L1c
        La:
            goto L2c
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L2b
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L22:
            int r2 = r0 * r1
            goto L16
        L28:
            goto Ld
        L2b:
            return
        L2c:
            goto L28
    }

    public static int PaAZRseRluznZWlU(int r1, int r2) {
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
            int r0 = java.lang.Math.min(r1, r2)
            goto L4
    }

    public static void PaAZRseRluznZWlU(int r0, int r1, int r2, byte r3, java.lang.string r4, short r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L24
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L2c
        L12:
            r0 = 42
            goto L1e
        L18:
            int r2 = r0 * r1
            goto L4
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L24:
            double r0 = (double) r3
            goto La
        L29:
            goto Lb
        L2c:
            goto L12
    }

    public static void PaAZRseRluznZWlU(int r0, int r1, java.lang.string r2, int r3, byte r4, short r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L20
        La:
            goto L2c
        Ld:
            goto L14
        L11:
            goto Ld
        L14:
            r0 = 42
            goto L1a
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            return
        L2c:
            goto L11
    }

    public static void PaAZRseRluznZWlU(int r0, int r1, short r2, int r3, java.lang.string r4, byte r5) {
            goto L9
        L4:
            return
        L5:
            goto L21
        L9:
            goto L5
        Lc:
            goto L2a
        L10:
            int r2 = r0 * r1
            goto L24
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L21:
            goto Lc
        L24:
            int r3 = r2 + r1
            goto L16
        L2a:
            r0 = 42
            goto L1b
    }

    public static void PmmewIoygGIPUHjA(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, bool r1, bool r2, bool r3, byte r4, java.lang.string r5, bool r6, float r7) {
            goto L12
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L25
        Lf:
            goto L15
        L12:
            goto L26
        L15:
            goto L1f
        L19:
            int r2 = r0 * r1
            goto L4
        L1f:
            r0 = 42
            goto L2a
        L25:
            return
        L26:
            goto Lf
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
    }

    public static void PmmewIoygGIPUHjA(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, bool r1, bool r2, bool r3, java.lang.string r4, float r5, bool r6, byte r7) {
            goto L16
        L4:
            int r3 = r2 + r1
            goto L1d
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            goto L26
        L19:
            goto L2a
        L1d:
            double r0 = (double) r3
            goto L25
        L22:
            goto L19
        L25:
            return
        L26:
            goto L22
        L2a:
            r0 = 42
            goto L10
    }

    public static void PmmewIoygGIPUHjA(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, bool r1, bool r2, bool r3, java.lang.string r4, bool r5, float r6, byte r7) {
            goto L4
        L4:
            goto L26
        L7:
            goto L19
        Lb:
            goto L7
        Le:
            double r0 = (double) r3
            goto L25
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L19:
            r0 = 42
            goto L13
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            return
        L26:
            goto Lb
        L2a:
            int r3 = r2 + r1
            goto Le
    }

    public static bool PmmewIoygGIPUHjA(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r1, bool r2, bool r3, bool r4) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.setVisible(r2, r3, r4)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void QpGDgCxqYCmmQcmr(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.internalShow()
            goto L4
    }

    public static void QpGDgCxqYCmmQcmr(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, java.lang.string r2, short r3, int r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L14
        Ld:
            goto L20
        L10:
            goto L24
        L14:
            double r0 = (double) r3
            goto L1f
        L19:
            int r2 = r0 * r1
            goto L7
        L1f:
            return
        L20:
            goto L4
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
    }

    public static void QpGDgCxqYCmmQcmr(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, short r2, java.lang.string r3, byte r4) {
            goto L26
        L4:
            int r2 = r0 * r1
            goto L14
        La:
            return
        Lb:
            goto L2d
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            int r3 = r2 + r1
            goto Lf
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            r0 = 42
            goto L1a
        L26:
            goto Lb
        L29:
            goto L20
        L2d:
            goto L29
    }

    public static void QpGDgCxqYCmmQcmr(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, byte r2, int r3, short r4) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L1c
        La:
            return
        Lb:
            goto L22
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto Lb
        L18:
            goto L25
        L1c:
            int r3 = r2 + r1
            goto L2b
        L22:
            goto L18
        L25:
            r0 = 42
            goto Lf
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void RAWIVuUrVBoChuoX(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, bool r2, char r3, short r4) {
            goto L20
        L4:
            return
        L5:
            goto L2d
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        Lf:
            int r3 = r2 + r1
            goto L15
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            int r2 = r0 * r1
            goto Lf
        L20:
            goto L5
        L23:
            goto L27
        L27:
            r0 = 42
            goto L9
        L2d:
            goto L23
    }

    public static void RAWIVuUrVBoChuoX(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, bool r2, short r3, byte r4) {
            goto L11
        L4:
            double r0 = (double) r3
            goto Lc
        L9:
            goto L14
        Lc:
            return
        Ld:
            goto L9
        L11:
            goto Ld
        L14:
            goto L18
        L18:
            r0 = 42
            goto L1e
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void RAWIVuUrVBoChuoX(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, char r2, short r3, byte r4) {
            goto L1c
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            int r3 = r2 + r1
            goto L23
        L1c:
            goto L29
        L1f:
            goto L4
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1f
    }

    public static int[] RAWIVuUrVBoChuoX(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int[] r0 = r1.getIndicatorColor()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void RCqBnhAxfhmVJPpF(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.internalShow()
            goto Le
    }

    public static void RCqBnhAxfhmVJPpF(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, java.lang.string r2, short r3, int r4) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            return
        Lb:
            goto L1b
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            goto L21
        L1e:
            goto Lb
        L21:
            goto Lf
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void RCqBnhAxfhmVJPpF(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, short r2, int r3, java.lang.string r4) {
            goto L24
        L4:
            return
        L5:
            goto L21
        L9:
            r0 = 42
            goto L15
        Lf:
            int r3 = r2 + r1
            goto L2b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L1b:
            int r2 = r0 * r1
            goto Lf
        L21:
            goto L27
        L24:
            goto L5
        L27:
            goto L9
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void RCqBnhAxfhmVJPpF(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, short r2, char r3, java.lang.string r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        Lf:
            int r2 = r0 * r1
            goto L27
        L15:
            return
        L16:
            goto L2d
        L1a:
            goto L16
        L1d:
            goto L21
        L21:
            r0 = 42
            goto L9
        L27:
            int r3 = r2 + r1
            goto L4
        L2d:
            goto L1d
    }

    private void RegisterAnimationCallbacks() {
            r2 = this;
            goto L4
        L4:
            goto L9d
        L7:
            goto L14
        Lb:
            if (r0 != 0) goto L10
            goto L66
        L10:
            goto L8b
        L14:
            r0 = 25
            goto L93
        L1b:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = BLPnDnlaHwjXpYqO(r2)
            goto L3b
        L23:
            dpsRgrmZFkCZWWrE(r0, r1)
        L26:
            goto Lb7
        L2a:
            if (r0 != 0) goto L2f
            goto Lc8
        L2f:
            goto L44
        L33:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = TPrYmapYYGhfbCmD(r2)
            goto Lbf
        L3b:
            if (r0 != 0) goto L40
            goto Lc8
        L40:
            goto L7b
        L44:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = vLfhiEBQJUvVpvKH(r2)
            goto L6a
        L4c:
            return
        L4d:
            goto L9a
        L51:
            androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback r2 = r2.hideAnimationCallback
            goto L63
        L57:
            int r0 = r0 + r1
            goto La8
        L5d:
            androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback r1 = r2.switchIndeterminateModeCallback
            goto Lc5
        L63:
            KAeuZOoyDGluCGjE(r0, r2)
        L66:
            goto L4c
        L6a:
            com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0 = uqminccsZcDGEbqO(r0)
            goto L5d
        L72:
            if (r0 != 0) goto L77
            goto L26
        L77:
            goto L33
        L7b:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = gChVYyLzZNbCGpiF(r2)
            goto L2a
        L83:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = KWFQEVauzVZtvgAh(r2)
            goto L72
        L8b:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = JTusSMdjfWWgxBXS(r2)
            goto L51
        L93:
            r1 = 12
            goto L57
        L9a:
            goto La4
        L9d:
            goto Lcc
        La1:
            goto L4d
        La4:
            goto L1b
        La8:
            int r0 = r0 % r1
            goto Lae
        Lae:
            if (r0 <= 0) goto Lb3
            goto La4
        Lb3:
            goto La1
        Lb7:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = pWWUYfcJZAPSuPCC(r2)
            goto Lb
        Lbf:
            androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback r1 = r2.hideAnimationCallback
            goto L23
        Lc5:
            iqahmmplcgylBqOv(r0, r1)
        Lc8:
            goto L83
        Lcc:
            goto L7
    }

    private void RegisterAnimationCallbacks(int r1, bool r2, char r3, float r4) {
            r0 = this;
            goto L4
        L4:
            goto L27
        L7:
            goto L11
        Lb:
            int r3 = r2 + r1
            goto L2b
        L11:
            r0 = 42
            goto L17
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1d:
            int r2 = r0 * r1
            goto Lb
        L23:
            goto L7
        L26:
            return
        L27:
            goto L23
        L2b:
            double r0 = (double) r3
            goto L26
    }

    private void RegisterAnimationCallbacks(bool r1, int r2, char r3, float r4) {
            r0 = this;
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            int r2 = r0 * r1
            goto L21
        Lf:
            goto L1d
        L12:
            goto L16
        L16:
            r0 = 42
            goto L27
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r3 = r2 + r1
            goto L4
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2d:
            goto L12
    }

    private void RegisterAnimationCallbacks(bool r1, int r2, float r3, char r4) {
            r0 = this;
            goto L1a
        L4:
            return
        L5:
            goto L27
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        Lf:
            int r2 = r0 * r1
            goto L2a
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            goto L5
        L1d:
            goto L21
        L21:
            r0 = 42
            goto L9
        L27:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L15
    }

    public static void SGPnQwNUxjZSZhjR(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, short r2, int r3, java.lang.string r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L14
        Ld:
            goto L1b
        L10:
            goto L2a
        L14:
            int r3 = r2 + r1
            goto L1f
        L1a:
            return
        L1b:
            goto L4
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2a:
            r0 = 42
            goto L24
    }

    public static void SGPnQwNUxjZSZhjR(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, short r2, int r3, char r4) {
            goto L23
        L4:
            goto L26
        L7:
            int r3 = r2 + r1
            goto L1e
        Ld:
            return
        Le:
            goto L4
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            r0 = 42
            goto L12
        L1e:
            double r0 = (double) r3
            goto Ld
        L23:
            goto Le
        L26:
            goto L18
        L2a:
            int r2 = r0 * r1
            goto L7
    }

    public static void SGPnQwNUxjZSZhjR(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, java.lang.string r2, int r3, char r4) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            r0 = 42
            goto L4
        L10:
            goto L21
        L13:
            return
        L14:
            goto L10
        L18:
            int r3 = r2 + r1
            goto L25
        L1e:
            goto L14
        L21:
            goto La
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            int r2 = r0 * r1
            goto L18
    }

    public static bool SGPnQwNUxjZSZhjR(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            bool r0 = r1.isIndeterminate()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void SLtfASAqcfSJBbaZ(android.widget.ProgressBar r0, int r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            super.onWindowVisibilityChanged(r1)
            goto Le
    }

    public static void SLtfASAqcfSJBbaZ(android.widget.ProgressBar r0, int r1, byte r2, int r3, bool r4, float r5) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L1f
        Lb:
            double r0 = (double) r3
            goto L2b
        L10:
            goto L7
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L19:
            int r2 = r0 * r1
            goto L25
        L1f:
            r0 = 42
            goto L13
        L25:
            int r3 = r2 + r1
            goto Lb
        L2b:
            return
        L2c:
            goto L10
    }

    public static void SLtfASAqcfSJBbaZ(android.widget.ProgressBar r0, int r1, bool r2, int r3, byte r4, float r5) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            r0 = 42
            goto L4
        L10:
            return
        L11:
            goto L1c
        L15:
            goto L11
        L18:
            goto La
        L1c:
            goto L18
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L10
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static void SLtfASAqcfSJBbaZ(android.widget.ProgressBar r0, int r1, bool r2, int r3, float r4, byte r5) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L10:
            goto L1e
        L13:
            goto L4
        L17:
            int r3 = r2 + r1
            goto L28
        L1d:
            return
        L1e:
            goto L2d
        L22:
            int r2 = r0 * r1
            goto L17
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto L13
    }

    public static void ShdhWlTgXTjBLSTa(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1) {
            goto Lb
        L4:
            r0.applyNewVisibility(r1)
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

    public static void ShdhWlTgXTjBLSTa(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, float r2, byte r3, int r4, java.lang.string r5) {
            goto L1d
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L12
        Lf:
            goto L20
        L12:
            return
        L13:
            goto Lf
        L17:
            r0 = 42
            goto L2a
        L1d:
            goto L13
        L20:
            goto L17
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void ShdhWlTgXTjBLSTa(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, float r2, java.lang.string r3, byte r4, int r5) {
            goto Lc
        L4:
            double r0 = (double) r3
            goto L19
        L9:
            goto Lf
        Lc:
            goto L1a
        Lf:
            goto L13
        L13:
            r0 = 42
            goto L1e
        L19:
            return
        L1a:
            goto L9
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void ShdhWlTgXTjBLSTa(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, java.lang.string r2, byte r3, float r4, int r5) {
            goto L4
        L4:
            goto L18
        L7:
            goto L1c
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L11:
            int r3 = r2 + r1
            goto L25
        L17:
            return
        L18:
            goto L22
        L1c:
            r0 = 42
            goto Lb
        L22:
            goto L7
        L25:
            double r0 = (double) r3
            goto L17
        L2a:
            int r2 = r0 * r1
            goto L11
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable SvBKyYIQVAARJjFB(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lc
        L4:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void SvBKyYIQVAARJjFB(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, java.lang.string r2, bool r3, float r4) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            goto L26
        Lc:
            r0 = 42
            goto L18
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1e:
            return
        L1f:
            goto L9
        L23:
            goto L1f
        L26:
            goto Lc
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static void SvBKyYIQVAARJjFB(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, bool r2, float r3, java.lang.string r4) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        La:
            r0 = 42
            goto L4
        L10:
            goto L26
        L13:
            goto La
        L17:
            int r2 = r0 * r1
            goto L2a
        L1d:
            goto L13
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L20
    }

    public static void SvBKyYIQVAARJjFB(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, java.lang.string r2, bool r3, byte r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L22
        Lb:
            double r0 = (double) r3
            goto L2b
        L10:
            int r2 = r0 * r1
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L1c:
            int r3 = r2 + r1
            goto Lb
        L22:
            r0 = 42
            goto L16
        L28:
            goto L7
        L2b:
            return
        L2c:
            goto L28
    }

    public static int SxCmeKpnKdmcruXb(android.content.res.TypedArray r1, int r2, int r3) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = r1.getInt(r2, r3)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void SxCmeKpnKdmcruXb(android.content.res.TypedArray r0, int r1, int r2, byte r3, float r4, java.lang.string r5, char r6) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L10
        L9:
            goto L11
        Lc:
            goto L18
        L10:
            return
        L11:
            goto L15
        L15:
            goto Lc
        L18:
            r0 = 42
            goto L1e
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void SxCmeKpnKdmcruXb(android.content.res.TypedArray r0, int r1, int r2, float r3, byte r4, java.lang.string r5, char r6) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r2 = r0 * r1
            goto L1c
        Lf:
            r0 = 42
            goto L2a
        L15:
            goto L26
        L18:
            goto Lf
        L1c:
            int r3 = r2 + r1
            goto L4
        L22:
            goto L18
        L25:
            return
        L26:
            goto L22
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void SxCmeKpnKdmcruXb(android.content.res.TypedArray r0, int r1, int r2, float r3, char r4, byte r5, java.lang.string r6) {
            goto L15
        L4:
            return
        L5:
            goto L27
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        Lf:
            int r2 = r0 * r1
            goto L2a
        L15:
            goto L5
        L18:
            goto L21
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            r0 = 42
            goto L9
        L27:
            goto L18
        L2a:
            int r3 = r2 + r1
            goto L1c
    }

    public static void TAeVKcNXDXfdHcgl(com.google.android.material.progressindicator.DeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, byte r2, short r3, int r4, char r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        La:
            goto L2c
        Ld:
            goto L22
        L11:
            int r2 = r0 * r1
            goto L1c
        L17:
            double r0 = (double) r3
            goto L2b
        L1c:
            int r3 = r2 + r1
            goto L17
        L22:
            r0 = 42
            goto L4
        L28:
            goto Ld
        L2b:
            return
        L2c:
            goto L28
    }

    public static void TAeVKcNXDXfdHcgl(com.google.android.material.progressindicator.DeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, int r2, byte r3, short r4, char r5) {
            goto L18
        L4:
            r0 = 42
            goto L25
        La:
            return
        Lb:
            goto L15
        Lf:
            int r2 = r0 * r1
            goto L1f
        L15:
            goto L1b
        L18:
            goto Lb
        L1b:
            goto L4
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void TAeVKcNXDXfdHcgl(com.google.android.material.progressindicator.DeterminateDrawable r0, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r1, short r2, char r3, int r4, byte r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto L1f
        Le:
            int r2 = r0 * r1
            goto L19
        L14:
            return
        L15:
            goto L4
        L19:
            int r3 = r2 + r1
            goto L25
        L1f:
            r0 = 42
            goto L2a
        L25:
            double r0 = (double) r3
            goto L14
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
    }

    public static bool TAeVKcNXDXfdHcgl(com.google.android.material.progressindicator.DeterminateDrawable r1, androidx.vectordrawable.graphics.drawable.Animatable2Compat.AnimationCallback r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            bool r0 = r1.unregisterAnimationCallback(r2)
            goto L4
    }

    public static void TMGDWhblwIYnjNaw(int[] r0, int[] r1, int r2, byte r3, char r4, bool r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            goto L18
        Ld:
            goto L1c
        L11:
            int r2 = r0 * r1
            goto L4
        L17:
            return
        L18:
            goto L22
        L1c:
            r0 = 42
            goto L2a
        L22:
            goto Ld
        L25:
            double r0 = (double) r3
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
    }

    public static void TMGDWhblwIYnjNaw(int[] r0, int[] r1, int r2, char r3, byte r4, bool r5) {
            goto L29
        L4:
            return
        L5:
            goto L26
        L9:
            int r3 = r2 + r1
            goto L15
        Lf:
            r0 = 42
            goto L1a
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L20:
            int r2 = r0 * r1
            goto L9
        L26:
            goto L2c
        L29:
            goto L5
        L2c:
            goto Lf
    }

    public static void TMGDWhblwIYnjNaw(int[] r0, int[] r1, bool r2, char r3, byte r4, int r5) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L18
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L26
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto La
        L23:
            goto Lb
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L12
    }

    public static bool TMGDWhblwIYnjNaw(int[] r1, int[] r2) {
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
            bool r0 = java.util.Arrays.Equals(r1, r2)
            goto L4
    }

    public static void TjmnmVrSYqjSWRBZ(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1) {
            goto Le
        L4:
            goto L11
        L7:
            super.setProgressDrawable(r1)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static void TjmnmVrSYqjSWRBZ(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1, java.lang.string r2, byte r3, float r4, bool r5) {
            goto Ld
        L4:
            int r3 = r2 + r1
            goto L1a
        La:
            goto L10
        Ld:
            goto L2c
        L10:
            goto L1f
        L14:
            int r2 = r0 * r1
            goto L4
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L2b:
            return
        L2c:
            goto La
    }

    public static void TjmnmVrSYqjSWRBZ(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1, java.lang.string r2, float r3, bool r4, byte r5) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L1d
        L10:
            goto L29
        L13:
            goto L17
        L17:
            r0 = 42
            goto L22
        L1d:
            double r0 = (double) r3
            goto L28
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L13
    }

    public static void TjmnmVrSYqjSWRBZ(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1, bool r2, java.lang.string r3, float r4, byte r5) {
            goto L14
        L4:
            return
        L5:
            goto L21
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L14:
            goto L5
        L17:
            goto L1b
        L1b:
            r0 = 42
            goto Le
        L21:
            goto L17
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L9
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable TrKxBIdCNayxQlEM(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto Lb
    }

    public static void TrKxBIdCNayxQlEM(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, byte r2, bool r3, float r4) {
            goto L18
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            goto L1b
        L12:
            r0 = 42
            goto L1f
        L18:
            goto L2c
        L1b:
            goto L12
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            int r3 = r2 + r1
            goto La
        L2b:
            return
        L2c:
            goto Lf
    }

    public static void TrKxBIdCNayxQlEM(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, char r2, bool r3, byte r4) {
            goto L1e
        L4:
            return
        L5:
            goto L9
        L9:
            goto L21
        Lc:
            r0 = 42
            goto L2a
        L12:
            int r3 = r2 + r1
            goto L25
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            goto L5
        L21:
            goto Lc
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
    }

    public static void TrKxBIdCNayxQlEM(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, float r2, byte r3, char r4) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            r0 = 42
            goto La
        L16:
            double r0 = (double) r3
            goto L22
        L1b:
            goto L23
        L1e:
            goto L10
        L22:
            return
        L23:
            goto L27
        L27:
            goto L1e
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void TviyraPZJzmxNSOq(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, float r2, short r3, int r4) {
            goto L1a
        L4:
            return
        L5:
            goto L21
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r3 = r2 + r1
            goto L9
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1a:
            goto L5
        L1d:
            goto L24
        L21:
            goto L1d
        L24:
            r0 = 42
            goto L14
        L2a:
            int r2 = r0 * r1
            goto Le
    }

    public static void TviyraPZJzmxNSOq(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, byte r2, short r3, int r4) {
            goto L17
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L1a
        L17:
            goto L10
        L1a:
            goto L2a
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r0 = 42
            goto L9
    }

    public static void TviyraPZJzmxNSOq(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, short r2, byte r3, int r4) {
            goto L19
        L4:
            goto L1c
        L7:
            int r3 = r2 + r1
            goto L26
        Ld:
            r0 = 42
            goto L20
        L13:
            int r2 = r0 * r1
            goto L7
        L19:
            goto L2c
        L1c:
            goto Ld
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L4
    }

    public static bool TviyraPZJzmxNSOq(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.isNolongerNeedToBeVisible()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void UIbdBYHpvoZBWAoF(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, float r1, char r2, int r3, short r4) {
            goto L1d
        L4:
            r0 = 42
            goto L2a
        La:
            return
        Lb:
            goto L14
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto L20
        L17:
            int r3 = r2 + r1
            goto Lf
        L1d:
            goto Lb
        L20:
            goto L4
        L24:
            int r2 = r0 * r1
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void UIbdBYHpvoZBWAoF(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, short r1, char r2, float r3, int r4) {
            goto L20
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        La:
            double r0 = (double) r3
            goto L1b
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            r0 = 42
            goto L4
        L1b:
            return
        L1c:
            goto L2d
        L20:
            goto L1c
        L23:
            goto L15
        L27:
            int r2 = r0 * r1
            goto Lf
        L2d:
            goto L23
    }

    public static void UIbdBYHpvoZBWAoF(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, short r1, int r2, float r3, char r4) {
            goto L12
        L4:
            return
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            int r3 = r2 + r1
            goto L25
        L12:
            goto L5
        L15:
            goto L2a
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto Lc
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r0 = 42
            goto L19
    }

    public static bool UIbdBYHpvoZBWAoF(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r1.hideNow()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void UlRsFflmFMJhXofF(java.lang.Action r0) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.run()
            goto Le
    }

    public static void UlRsFflmFMJhXofF(java.lang.Action r0, float r1, java.lang.string r2, int r3, short r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        La:
            goto L2c
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L4
        L17:
            int r2 = r0 * r1
            goto L1d
        L1d:
            int r3 = r2 + r1
            goto L23
        L23:
            double r0 = (double) r3
            goto L2b
        L28:
            goto Ld
        L2b:
            return
        L2c:
            goto L28
    }

    public static void UlRsFflmFMJhXofF(java.lang.Action r0, int r1, float r2, short r3, java.lang.string r4) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L1b
        L12:
            int r2 = r0 * r1
            goto L4
        L18:
            goto Lb
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void UlRsFflmFMJhXofF(java.lang.Action r0, short r1, java.lang.string r2, int r3, float r4) {
            goto L26
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            int r3 = r2 + r1
            goto L21
        L10:
            return
        L11:
            goto L2d
        L15:
            int r2 = r0 * r1
            goto La
        L1b:
            r0 = 42
            goto L4
        L21:
            double r0 = (double) r3
            goto L10
        L26:
            goto L11
        L29:
            goto L1b
        L2d:
            goto L29
    }

    private void UnregisterAnimationCallbacks() {
            r2 = this;
            goto Lc
        L4:
            com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0 = PLhhrPvHmahaRDIi(r0)
            goto L13
        Lc:
            goto L50
        Lf:
            goto L82
        L13:
            zATypvhYVEwOoGES(r0)
        L16:
            goto L54
        L1a:
            POpdCKUFNWXzzJaM(r0, r1)
            goto L21
        L21:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = trKxBIdCNayxQlEM(r2)
            goto L4
        L29:
            androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback r2 = r2.hideAnimationCallback
            goto L5c
        L2f:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = agjllOgFiinacgec(r2)
            goto L29
        L37:
            return
        L38:
            goto L4d
        L3c:
            if (r0 <= 0) goto L41
            goto L9d
        L41:
            goto L9a
        L45:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = LrvKRURzCvRytPVD(r2)
            goto La1
        L4d:
            goto L9d
        L50:
            goto L79
        L54:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = yeKgPqRJaaBSwSAv(r2)
            goto L89
        L5c:
            tAeVKcNXDXfdHcgl(r0, r2)
        L5f:
            goto L37
        L63:
            if (r0 != 0) goto L68
            goto L16
        L68:
            goto L45
        L6c:
            int r0 = r0 % r1
            goto L3c
        L72:
            r1 = 27
            goto L7c
        L79:
            goto Lf
        L7c:
            int r0 = r0 + r1
            goto L6c
        L82:
            r0 = 15
            goto L72
        L89:
            if (r0 != 0) goto L8e
            goto L5f
        L8e:
            goto L2f
        L92:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = vAsVkqvOqIMWwyBq(r2)
            goto L63
        L9a:
            goto L38
        L9d:
            goto L92
        La1:
            androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback r1 = r2.hideAnimationCallback
            goto L1a
    }

    private void UnregisterAnimationCallbacks(byte r1, java.lang.string r2, float r3, short r4) {
            r0 = this;
            goto L15
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            int r2 = r0 * r1
            goto L24
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            goto L20
        L18:
            goto L2a
        L1c:
            goto L18
        L1f:
            return
        L20:
            goto L1c
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r0 = 42
            goto Lf
    }

    private void UnregisterAnimationCallbacks(float r1, short r2, java.lang.string r3, byte r4) {
            r0 = this;
            goto L29
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L26
        Le:
            int r3 = r2 + r1
            goto L4
        L14:
            r0 = 42
            goto L20
        L1a:
            int r2 = r0 * r1
            goto Le
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L26:
            goto L2c
        L29:
            goto La
        L2c:
            goto L14
    }

    private void UnregisterAnimationCallbacks(short r1, byte r2, java.lang.string r3, float r4) {
            r0 = this;
            goto L23
        L4:
            return
        L5:
            goto L1a
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r3 = r2 + r1
            goto L15
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            goto L26
        L1d:
            int r2 = r0 * r1
            goto Lf
        L23:
            goto L5
        L26:
            goto L9
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
    }

    public static com.google.android.material.progressindicator.IndeterminateAnimatorDelegate UqminccsZcDGEbqO(com.google.android.material.progressindicator.IndeterminateDrawable r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0 = r1.getAnimatorDelegate()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void UqminccsZcDGEbqO(com.google.android.material.progressindicator.IndeterminateDrawable r0, byte r1, bool r2, float r3, short r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L23
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L2c
        L1e:
            double r0 = (double) r3
            goto L16
        L23:
            int r3 = r2 + r1
            goto L1e
        L29:
            goto L17
        L2c:
            goto La
    }

    public static void UqminccsZcDGEbqO(com.google.android.material.progressindicator.IndeterminateDrawable r0, byte r1, bool r2, short r3, float r4) {
            goto L1b
        L4:
            return
        L5:
            goto L2d
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        Lf:
            int r3 = r2 + r1
            goto L22
        L15:
            int r2 = r0 * r1
            goto Lf
        L1b:
            goto L5
        L1e:
            goto L27
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            r0 = 42
            goto L9
        L2d:
            goto L1e
    }

    public static void UqminccsZcDGEbqO(com.google.android.material.progressindicator.IndeterminateDrawable r0, bool r1, float r2, short r3, byte r4) {
            goto L1e
        L4:
            goto L21
        L7:
            int r2 = r0 * r1
            goto L18
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L13:
            return
        L14:
            goto L4
        L18:
            int r3 = r2 + r1
            goto L25
        L1e:
            goto L14
        L21:
            goto L2a
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            r0 = 42
            goto Ld
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable VAsVkqvOqIMWwyBq(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lf
        L4:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void VAsVkqvOqIMWwyBq(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, char r2, bool r3, byte r4) {
            goto L4
        L4:
            goto L23
        L7:
            goto L1c
        Lb:
            double r0 = (double) r3
            goto L22
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L2a
        L1c:
            r0 = 42
            goto L10
        L22:
            return
        L23:
            goto L27
        L27:
            goto L7
        L2a:
            int r3 = r2 + r1
            goto Lb
    }

    public static void VAsVkqvOqIMWwyBq(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, byte r2, char r3, int r4) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            goto L26
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            r0 = 42
            goto Lc
        L1e:
            return
        L1f:
            goto L9
        L23:
            goto L1f
        L26:
            goto L18
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static void VAsVkqvOqIMWwyBq(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, int r2, byte r3, char r4) {
            goto L4
        L4:
            goto L29
        L7:
            goto L1c
        Lb:
            double r0 = (double) r3
            goto L28
        L10:
            int r3 = r2 + r1
            goto Lb
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L1c:
            r0 = 42
            goto L16
        L22:
            int r2 = r0 * r1
            goto L10
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L7
    }

    public static void VBcfItHSXXPsPUXc(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, java.lang.string r2, float r3, short r4) {
            goto L1d
        L4:
            goto L20
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L12
        L12:
            double r0 = (double) r3
            goto L7
        L17:
            int r2 = r0 * r1
            goto Lc
        L1d:
            goto L8
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L2a:
            r0 = 42
            goto L24
    }

    public static void VBcfItHSXXPsPUXc(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, java.lang.string r2, short r3, float r4) {
            goto L20
        L4:
            return
        L5:
            goto L27
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r2 = r0 * r1
            goto L1a
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            int r3 = r2 + r1
            goto L15
        L20:
            goto L5
        L23:
            goto L9
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void VBcfItHSXXPsPUXc(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, byte r2, short r3, float r4) {
            goto L26
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L10:
            return
        L11:
            goto L2d
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            int r2 = r0 * r1
            goto L4
        L20:
            r0 = 42
            goto La
        L26:
            goto L11
        L29:
            goto L20
        L2d:
            goto L29
    }

    public static bool VBcfItHSXXPsPUXc(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            bool r0 = r1.visibleToUser()
            goto L7
    }

    public static com.google.android.material.progressindicator.IndeterminateDrawable VLfhiEBQJUvVpvKH(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = r1.getIndeterminateDrawable()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void VLfhiEBQJUvVpvKH(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, float r2, short r3, bool r4) {
            goto L4
        L4:
            goto L23
        L7:
            goto L1c
        Lb:
            int r3 = r2 + r1
            goto L17
        L11:
            int r2 = r0 * r1
            goto Lb
        L17:
            double r0 = (double) r3
            goto L22
        L1c:
            r0 = 42
            goto L27
        L22:
            return
        L23:
            goto L2d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L2d:
            goto L7
    }

    public static void VLfhiEBQJUvVpvKH(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, short r2, bool r3, byte r4) {
            goto L4
        L4:
            goto L17
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L16
        L10:
            r0 = 42
            goto L1e
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L7
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            int r3 = r2 + r1
            goto Lb
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void VLfhiEBQJUvVpvKH(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, bool r2, byte r3, float r4) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r2 = r0 * r1
            goto L1f
        Lf:
            r0 = 42
            goto L25
        L15:
            goto L1b
        L18:
            goto L2c
        L1b:
            goto Lf
        L1f:
            int r3 = r2 + r1
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2b:
            return
        L2c:
            goto L15
    }

    public static void VNTxwQRyXHWrqJlZ(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, int r1, byte r2, java.lang.string r3, char r4) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L16:
            double r0 = (double) r3
            goto L28
        L1b:
            goto L29
        L1e:
            goto La
        L22:
            int r2 = r0 * r1
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1e
    }

    public static void VNTxwQRyXHWrqJlZ(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, java.lang.string r1, byte r2, int r3, char r4) {
            goto L4
        L4:
            goto L1b
        L7:
            goto L1f
        Lb:
            goto L7
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L14:
            int r3 = r2 + r1
            goto L2b
        L1a:
            return
        L1b:
            goto Lb
        L1f:
            r0 = 42
            goto Le
        L25:
            int r2 = r0 * r1
            goto L14
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void VNTxwQRyXHWrqJlZ(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0, java.lang.string r1, int r2, char r3, byte r4) {
            goto Lf
        L4:
            return
        L5:
            goto L16
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        Lf:
            goto L5
        L12:
            goto L19
        L16:
            goto L12
        L19:
            r0 = 42
            goto L9
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static bool VNTxwQRyXHWrqJlZ(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            bool r0 = r1.hideNow()
            goto L4
    }

    public static void VOJdfmCrOhovSNci(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, char r2, short r3, int r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L24
        La:
            r0 = 42
            goto L1e
        L10:
            return
        L11:
            goto L1b
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            goto L2c
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L24:
            double r0 = (double) r3
            goto L10
        L29:
            goto L11
        L2c:
            goto La
    }

    public static void VOJdfmCrOhovSNci(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, short r3, byte r4) {
            goto La
        L4:
            r0 = 42
            goto L11
        La:
            goto L1e
        Ld:
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L17:
            int r2 = r0 * r1
            goto L27
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            int r3 = r2 + r1
            goto L22
        L2d:
            goto Ld
    }

    public static void VOJdfmCrOhovSNci(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, short r2, int r3, byte r4) {
            goto L14
        L4:
            return
        L5:
            goto L27
        L9:
            r0 = 42
            goto L2a
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L5
        L17:
            goto L9
        L1b:
            int r3 = r2 + r1
            goto Lf
        L21:
            int r2 = r0 * r1
            goto L1b
        L27:
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
    }

    public static bool VOJdfmCrOhovSNci(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            bool r0 = r1.visibleToUser()
            goto L7
    }

    public static void VlTMrHqJPcVVEEsE(android.widget.ProgressBar r0, android.view.object r1, int r2) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            super.onVisibilityChanged(r1, r2)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void VlTMrHqJPcVVEEsE(android.widget.ProgressBar r0, android.view.object r1, int r2, byte r3, char r4, float r5, int r6) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto Le
        Le:
            goto L26
        L11:
            int r2 = r0 * r1
            goto L1d
        L17:
            r0 = 42
            goto L2a
        L1d:
            int r3 = r2 + r1
            goto L4
        L23:
            goto La
        L26:
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
    }

    public static void VlTMrHqJPcVVEEsE(android.widget.ProgressBar r0, android.view.object r1, int r2, char r3, float r4, byte r5, int r6) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        Lf:
            int r2 = r0 * r1
            goto L25
        L15:
            goto L21
        L18:
            r0 = 42
            goto L9
        L1e:
            goto L2c
        L21:
            goto L18
        L25:
            int r3 = r2 + r1
            goto L4
        L2b:
            return
        L2c:
            goto L15
    }

    public static void VlTMrHqJPcVVEEsE(android.widget.ProgressBar r0, android.view.object r1, int r2, float r3, char r4, int r5, byte r6) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L26
        Ld:
            r0 = 42
            goto L4
        L13:
            return
        L14:
            goto La
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            goto L14
        L26:
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L1d
    }

    public static void WBKcwkiMSOyzUqSw(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.setVisibility(r1)
            goto Le
    }

    public static void WBKcwkiMSOyzUqSw(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, byte r2, short r3, char r4, int r5) {
            goto L15
        L4:
            return
        L5:
            goto L27
        L9:
            int r3 = r2 + r1
            goto L1c
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            goto L5
        L18:
            goto L21
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            r0 = 42
            goto L2a
        L27:
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void WBKcwkiMSOyzUqSw(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, char r2, short r3, int r4, byte r5) {
            goto L1c
        L4:
            int r3 = r2 + r1
            goto L23
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            r0 = 42
            goto L10
        L1c:
            goto L29
        L1f:
            goto L16
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1f
    }

    public static void WBKcwkiMSOyzUqSw(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, short r2, char r3, int r4, byte r5) {
            goto L17
        L4:
            goto L1a
        L7:
            double r0 = (double) r3
            goto Lc
        Lc:
            return
        Ld:
            goto L4
        L11:
            int r3 = r2 + r1
            goto L7
        L17:
            goto Ld
        L1a:
            goto L2a
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L11
        L2a:
            r0 = 42
            goto L1e
    }

    public static void WCoIUyanIBQcrwYc(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.invalidate()
            goto L4
    }

    public static void WCoIUyanIBQcrwYc(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, int r2, short r3, java.lang.string r4) {
            goto L4
        L4:
            goto L20
        L7:
            goto L24
        Lb:
            int r3 = r2 + r1
            goto L1a
        L11:
            goto L7
        L14:
            int r2 = r0 * r1
            goto Lb
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L11
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    public static void WCoIUyanIBQcrwYc(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, short r2, char r3, java.lang.string r4) {
            goto L9
        L4:
            return
        L5:
            goto L1b
        L9:
            goto L5
        Lc:
            goto L24
        L10:
            double r0 = (double) r3
            goto L4
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            goto Lc
        L1e:
            int r2 = r0 * r1
            goto L15
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void WCoIUyanIBQcrwYc(com.google.android.material.progressindicator.BaseProgressIndicator r0, short r1, java.lang.string r2, int r3, char r4) {
            goto L20
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            r0 = 42
            goto L4
        L10:
            int r2 = r0 * r1
            goto L27
        L16:
            return
        L17:
            goto L2d
        L1b:
            double r0 = (double) r3
            goto L16
        L20:
            goto L17
        L23:
            goto La
        L27:
            int r3 = r2 + r1
            goto L1b
        L2d:
            goto L23
    }

    public static void WbaIoUQwUzPHzwDg(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0) {
            goto L13
        L4:
            r0.requestCancelAnimatorAfterCurrentCycle()
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

    public static void WbaIoUQwUzPHzwDg(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, char r1, float r2, byte r3, short r4) {
            goto L18
        L4:
            goto L1b
        L7:
            r0 = 42
            goto Ld
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L13:
            double r0 = (double) r3
            goto L1f
        L18:
            goto L20
        L1b:
            goto L7
        L1f:
            return
        L20:
            goto L4
        L24:
            int r3 = r2 + r1
            goto L13
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void WbaIoUQwUzPHzwDg(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, char r1, float r2, short r3, byte r4) {
            goto L23
        L4:
            goto L26
        L7:
            return
        L8:
            goto L4
        Lc:
            double r0 = (double) r3
            goto L7
        L11:
            int r2 = r0 * r1
            goto L17
        L17:
            int r3 = r2 + r1
            goto Lc
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L23:
            goto L8
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L1d
    }

    public static void WbaIoUQwUzPHzwDg(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, short r1, char r2, byte r3, float r4) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L1e
        L10:
            goto L27
        L13:
            r0 = 42
            goto L4
        L19:
            return
        L1a:
            goto L10
        L1e:
            int r3 = r2 + r1
            goto L2b
        L24:
            goto L1a
        L27:
            goto L13
        L2b:
            double r0 = (double) r3
            goto L19
    }

    public static android.content.object XGcjlFwgQhXbBRVU(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            android.content.object r0 = r1.getobject()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void XGcjlFwgQhXbBRVU(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, float r2, int r3, java.lang.string r4) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            goto L26
        Lc:
            r0 = 42
            goto L12
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            return
        L19:
            goto L9
        L1d:
            int r3 = r2 + r1
            goto L4
        L23:
            goto L19
        L26:
            goto Lc
        L2a:
            int r2 = r0 * r1
            goto L1d
    }

    public static void XGcjlFwgQhXbBRVU(com.google.android.material.progressindicator.BaseProgressIndicator r0, byte r1, int r2, java.lang.string r3, float r4) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            r0 = 42
            goto L4
        L10:
            return
        L11:
            goto L22
        L15:
            goto L11
        L18:
            goto La
        L1c:
            int r3 = r2 + r1
            goto L2b
        L22:
            goto L18
        L25:
            int r2 = r0 * r1
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void XGcjlFwgQhXbBRVU(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, int r2, float r3, byte r4) {
            goto L23
        L4:
            return
        L5:
            goto L1b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        Lf:
            r0 = 42
            goto L9
        L15:
            int r2 = r0 * r1
            goto L2a
        L1b:
            goto L26
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            goto L5
        L26:
            goto Lf
        L2a:
            int r3 = r2 + r1
            goto L1e
    }

    public static void XhqrKDMNpzMhSrAx(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            super.setIndeterminateDrawable(r1)
            goto L4
        L17:
            goto Lc
    }

    public static void XhqrKDMNpzMhSrAx(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1, byte r2, float r3, char r4, bool r5) {
            goto L23
        L4:
            return
        L5:
            goto L20
        L9:
            int r3 = r2 + r1
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            r0 = 42
            goto L2a
        L1b:
            double r0 = (double) r3
            goto L4
        L20:
            goto L26
        L23:
            goto L5
        L26:
            goto L15
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void XhqrKDMNpzMhSrAx(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1, byte r2, bool r3, float r4, char r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            goto L1d
        Lc:
            goto L2a
        L10:
            int r3 = r2 + r1
            goto L4
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            return
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L27:
            goto Lc
        L2a:
            r0 = 42
            goto L21
    }

    public static void XhqrKDMNpzMhSrAx(android.widget.ProgressBar r0, android.graphics.drawable.Drawable r1, float r2, byte r3, char r4, bool r5) {
            goto L12
        L4:
            double r0 = (double) r3
            goto L19
        L9:
            goto L15
        Lc:
            int r2 = r0 * r1
            goto L2a
        L12:
            goto L1a
        L15:
            goto L24
        L19:
            return
        L1a:
            goto L9
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L24:
            r0 = 42
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void YTocOmfrQPHRQXBL(com.google.android.material.progressindicator.DeterminateDrawable r0, bool r1, byte r2, short r3, int r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L20
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L2c
        L13:
            goto L1a
        L17:
            goto L13
        L1a:
            r0 = 42
            goto La
        L20:
            int r3 = r2 + r1
            goto L26
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L17
    }

    public static void YTocOmfrQPHRQXBL(com.google.android.material.progressindicator.DeterminateDrawable r0, bool r1, int r2, short r3, byte r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        Lf:
            return
        L10:
            goto L2d
        L14:
            int r2 = r0 * r1
            goto L27
        L1a:
            goto L10
        L1d:
            goto L21
        L21:
            r0 = 42
            goto L9
        L27:
            int r3 = r2 + r1
            goto L4
        L2d:
            goto L1d
    }

    public static void YTocOmfrQPHRQXBL(com.google.android.material.progressindicator.DeterminateDrawable r0, bool r1, short r2, int r3, byte r4) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            int r3 = r2 + r1
            goto L25
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L21
        L1e:
            goto L17
        L21:
            goto L2a
        L25:
            double r0 = (double) r3
            goto L16
        L2a:
            r0 = 42
            goto La
    }

    public static bool YTocOmfrQPHRQXBL(com.google.android.material.progressindicator.DeterminateDrawable r1) {
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
            bool r0 = r1.isVisible()
            goto Le
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable YeKgPqRJaaBSwSAv(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = r1.getProgressDrawable()
            goto Lb
        L18:
            goto L7
    }

    public static void YeKgPqRJaaBSwSAv(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, short r2, bool r3, java.lang.string r4) {
            goto L29
        L4:
            goto L2c
        L7:
            r0 = 42
            goto L23
        Ld:
            int r2 = r0 * r1
            goto L18
        L13:
            return
        L14:
            goto L4
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto L13
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L29:
            goto L14
        L2c:
            goto L7
    }

    public static void YeKgPqRJaaBSwSAv(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, short r2, float r3, bool r4) {
            goto L14
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L27
        L14:
            goto L10
        L17:
            goto L2a
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L21:
            int r2 = r0 * r1
            goto L9
        L27:
            goto L17
        L2a:
            r0 = 42
            goto L1b
    }

    public static void YeKgPqRJaaBSwSAv(com.google.android.material.progressindicator.BaseProgressIndicator r0, bool r1, short r2, float r3, java.lang.string r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L19
        Ld:
            goto L15
        L10:
            goto L2a
        L14:
            return
        L15:
            goto L4
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L14
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2a:
            r0 = 42
            goto L24
    }

    public static void YuAEnarVFNVQaMaX(android.graphics.Canvas r0, float r1, float r2) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.translate(r1, r2)
            goto L4
        L17:
            goto Lc
    }

    public static void YuAEnarVFNVQaMaX(android.graphics.Canvas r0, float r1, float r2, byte r3, char r4, java.lang.string r5, int r6) {
            goto L4
        L4:
            goto L12
        L7:
            goto L1b
        Lb:
            int r2 = r0 * r1
            goto L27
        L11:
            return
        L12:
            goto L2d
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            r0 = 42
            goto L21
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L27:
            int r3 = r2 + r1
            goto L16
        L2d:
            goto L7
    }

    public static void YuAEnarVFNVQaMaX(android.graphics.Canvas r0, float r1, float r2, int r3, char r4, java.lang.string r5, byte r6) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L2c
        L12:
            return
        L13:
            goto Lf
        L17:
            int r2 = r0 * r1
            goto L9
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L23:
            r0 = 42
            goto L1d
        L29:
            goto L13
        L2c:
            goto L23
    }

    public static void YuAEnarVFNVQaMaX(android.graphics.Canvas r0, float r1, float r2, java.lang.string r3, byte r4, int r5, char r6) {
            goto L18
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            return
        Lb:
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto L1b
        L18:
            goto Lb
        L1b:
            goto L2a
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            r0 = 42
            goto Lf
    }

    public static void ZATypvhYVEwOoGES(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.unregisterAnimatorsCompleteCallback()
            goto Lb
    }

    public static void ZATypvhYVEwOoGES(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, int r1, bool r2, float r3, java.lang.string r4) {
            goto L18
        L4:
            goto L1b
        L7:
            int r2 = r0 * r1
            goto L12
        Ld:
            return
        Le:
            goto L4
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            goto Le
        L1b:
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L25:
            r0 = 42
            goto L1f
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void ZATypvhYVEwOoGES(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, java.lang.string r1, float r2, bool r3, int r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L1c
        Lb:
            return
        Lc:
            goto L22
        L10:
            int r2 = r0 * r1
            goto L25
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L1c:
            r0 = 42
            goto L16
        L22:
            goto L7
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto Lb
    }

    public static void ZATypvhYVEwOoGES(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, java.lang.string r1, int r2, float r3, bool r4) {
            goto L24
        L4:
            return
        L5:
            goto L9
        L9:
            goto L27
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            r0 = 42
            goto Lc
        L24:
            goto L5
        L27:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void ZDTWVJUtHMzHFgFr(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0) {
            goto Le
        L4:
            goto L11
        L7:
            r0.invalidateSpecValues()
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static void ZDTWVJUtHMzHFgFr(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, java.lang.string r1, int r2, bool r3, float r4) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L2a
        Lb:
            int r3 = r2 + r1
            goto L17
        L11:
            int r2 = r0 * r1
            goto Lb
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L27:
            goto L7
        L2a:
            r0 = 42
            goto L21
    }

    public static void ZDTWVJUtHMzHFgFr(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, java.lang.string r1, bool r2, int r3, float r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            double r0 = (double) r3
            goto L24
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            r0 = 42
            goto L15
        L21:
            goto L2c
        L24:
            return
        L25:
            goto L21
        L29:
            goto L25
        L2c:
            goto L1b
    }

    public static void ZDTWVJUtHMzHFgFr(com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r0, bool r1, float r2, int r3, java.lang.string r4) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L22
        L15:
            goto L23
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L4
        L22:
            return
        L23:
            goto L2d
        L27:
            int r2 = r0 * r1
            goto La
        L2d:
            goto L18
    }

    public static void ZUHxOqSCMJtdnXGo(com.google.android.material.progressindicator.BaseProgressIndicator r0) {
            goto Lb
        L4:
            r0.registerAnimationCallbacks()
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

    public static void ZUHxOqSCMJtdnXGo(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, byte r2, bool r3, java.lang.string r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L11
        La:
            goto L23
        Ld:
            goto L16
        L11:
            double r0 = (double) r3
            goto L22
        L16:
            r0 = 42
            goto L2a
        L1c:
            int r2 = r0 * r1
            goto L4
        L22:
            return
        L23:
            goto L27
        L27:
            goto Ld
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
    }

    public static void ZUHxOqSCMJtdnXGo(com.google.android.material.progressindicator.BaseProgressIndicator r0, int r1, java.lang.string r2, bool r3, byte r4) {
            goto L13
        L4:
            goto L16
        L7:
            r0 = 42
            goto Ld
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L13:
            goto L26
        L16:
            goto L7
        L1a:
            int r2 = r0 * r1
            goto L2a
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L20
    }

    public static void ZUHxOqSCMJtdnXGo(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, byte r2, int r3, bool r4) {
            goto L1d
        L4:
            return
        L5:
            goto L9
        L9:
            goto L20
        Lc:
            int r3 = r2 + r1
            goto L18
        L12:
            int r2 = r0 * r1
            goto Lc
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            goto L5
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L2a:
            r0 = 42
            goto L24
    }

    public static int ZyYZvkOAMRhTpRmB(com.google.android.material.progressindicator.BaseProgressIndicator r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = r1.getPaddingLeft()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void ZyYZvkOAMRhTpRmB(com.google.android.material.progressindicator.BaseProgressIndicator r0, char r1, bool r2, java.lang.string r3, float r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L1d
        L13:
            goto L2a
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L13
        L24:
            int r3 = r2 + r1
            goto L17
        L2a:
            r0 = 42
            goto La
    }

    public static void ZyYZvkOAMRhTpRmB(com.google.android.material.progressindicator.BaseProgressIndicator r0, float r1, java.lang.string r2, char r3, bool r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L1e
        Ld:
            goto L1a
        L10:
            goto L2a
        L14:
            double r0 = (double) r3
            goto L19
        L19:
            return
        L1a:
            goto L4
        L1e:
            int r3 = r2 + r1
            goto L14
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2a:
            r0 = 42
            goto L24
    }

    public static void ZyYZvkOAMRhTpRmB(com.google.android.material.progressindicator.BaseProgressIndicator r0, java.lang.string r1, bool r2, float r3, char r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            goto L12
        Ld:
            goto L2a
        L11:
            return
        L12:
            goto L16
        L16:
            goto Ld
        L19:
            int r2 = r0 * r1
            goto L4
        L1f:
            double r0 = (double) r3
            goto L11
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L2a:
            r0 = 42
            goto L24
    }

    protected void ApplyNewVisibility(bool r3) {
            r2 = this;
            goto L4c
        L4:
            android.graphics.drawable.Drawable r0 = RBwxMNxEOCgPaKIC(r2)
            goto L36
        Lc:
            r0 = 20
            goto L59
        L13:
            if (r0 <= 0) goto L18
            goto L48
        L18:
            goto L45
        L1c:
            bool r2 = vOJdfmCrOhovSNci(r2)
            goto L60
        L24:
            return
        L25:
            goto L29
        L29:
            goto L48
        L2c:
            goto L3c
        L30:
            bool r0 = r2.isParentDoneInitializing
            goto L71
        L36:
            com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0 = (com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange) r0
            goto L1c
        L3c:
            goto L4f
        L3f:
            int r0 = r0 % r1
            goto L13
        L45:
            goto L25
        L48:
            goto L30
        L4c:
            goto L2c
        L4f:
            goto Lc
        L53:
            int r0 = r0 + r1
            goto L3f
        L59:
            r1 = 32
            goto L53
        L60:
            r1 = 0
            goto L6a
        L65:
            return
        L66:
            goto L4
        L6a:
            VcdEsWEQEiKZNjOC(r0, r2, r1, r3)
            goto L24
        L71:
            if (r0 == 0) goto L76
            goto L66
        L76:
            goto L65
    }

    abstract S CreateSpec(android.content.object r1, android.util.AttributeHashSet r2);

    @Override // android.widget.ProgressBar
    public android.graphics.drawable.Drawable GetCurrentDrawable() {
            r1 = this;
            goto L25
        L4:
            if (r0 != 0) goto L9
            goto L21
        L9:
            goto Ld
        Ld:
            com.google.android.material.progressindicator.IndeterminateDrawable r1 = cVCXFjsysLLVQNoq(r1)
            goto L20
        L15:
            bool r0 = sGPnQwNUxjZSZhjR(r1)
            goto L4
        L1d:
            goto L28
        L20:
            return r1
        L21:
            goto L31
        L25:
            goto L2d
        L28:
            goto L15
        L2c:
            return r1
        L2d:
            goto L1d
        L31:
            com.google.android.material.progressindicator.DeterminateDrawable r1 = KvAoYGLiUTQAxbWc(r1)
            goto L2c
    }

    public int GetHideAnimationBehavior() {
            r0 = this;
            goto L18
        L4:
            int r0 = r0.hideAnimationBehavior
            goto L10
        La:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r0.spec
            goto L4
        L10:
            return r0
        L11:
            goto L15
        L15:
            goto L1b
        L18:
            goto L11
        L1b:
            goto La
    }

    @Override // android.widget.ProgressBar
    public /* bridge */ /* synthetic */ android.graphics.drawable.Drawable getIndeterminateDrawable() {
            r0 = this;
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = FqzpvzATWsaQNWvc(r0)
            goto L4
    }

    @Override // android.widget.ProgressBar
    public com.google.android.material.progressindicator.IndeterminateDrawable<S> GetIndeterminateDrawable() {
            r0 = this;
            goto Lc
        L4:
            android.graphics.drawable.Drawable r0 = RJnpUHqAjDHexFlR(r0)
            goto L16
        Lc:
            goto L1d
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = (com.google.android.material.progressindicator.IndeterminateDrawable) r0
            goto L1c
        L1c:
            return r0
        L1d:
            goto L13
    }

    public int[] GetIndicatorColor() {
            r0 = this;
            goto La
        L4:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r0.spec
            goto L11
        La:
            goto L18
        Ld:
            goto L4
        L11:
            int[] r0 = r0.indicatorColors
            goto L17
        L17:
            return r0
        L18:
            goto L1c
        L1c:
            goto Ld
    }

    public int GetIndicatorTrackGapSize() {
            r0 = this;
            goto L18
        L4:
            int r0 = r0.indicatorTrackGapSize
            goto La
        La:
            return r0
        Lb:
            goto Lf
        Lf:
            goto L1b
        L12:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r0.spec
            goto L4
        L18:
            goto Lb
        L1b:
            goto L12
    }

    @Override // android.widget.ProgressBar
    public /* bridge */ /* synthetic */ android.graphics.drawable.Drawable getProgressDrawable() {
            r0 = this;
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = npXspKMlvDfveNKm(r0)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    @Override // android.widget.ProgressBar
    public com.google.android.material.progressindicator.DeterminateDrawable<S> GetProgressDrawable() {
            r0 = this;
            goto Lf
        L4:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = (com.google.android.material.progressindicator.DeterminateDrawable) r0
            goto La
        La:
            return r0
        Lb:
            goto L1e
        Lf:
            goto Lb
        L12:
            goto L16
        L16:
            android.graphics.drawable.Drawable r0 = YOavCgIthduyeCTm(r0)
            goto L4
        L1e:
            goto L12
    }

    public int GetShowAnimationBehavior() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L16
        L10:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r0.spec
            goto L19
        L16:
            goto L7
        L19:
            int r0 = r0.showAnimationBehavior
            goto Lb
    }

    public int GetTrackColor() {
            r0 = this;
            goto Ld
        L4:
            goto L10
        L7:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r0.spec
            goto L19
        Ld:
            goto L15
        L10:
            goto L7
        L14:
            return r0
        L15:
            goto L4
        L19:
            int r0 = r0.trackColor
            goto L14
    }

    public int GetTrackCornerRadius() {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto L19
        Le:
            int r0 = r0.trackCornerRadius
            goto L14
        L14:
            return r0
        L15:
            goto L4
        L19:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r0.spec
            goto Le
    }

    public int GetTrackThickness() {
            r0 = this;
            goto L18
        L4:
            return r0
        L5:
            goto L15
        L9:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r0.spec
            goto Lf
        Lf:
            int r0 = r0.trackThickness
            goto L4
        L15:
            goto L1b
        L18:
            goto L5
        L1b:
            goto L9
    }

    public void Hide() {
            r6 = this;
            goto L8b
        L4:
            long r0 = r0 - r2
            goto L92
        L9:
            if (r0 != 0) goto Le
            goto L44
        Le:
            goto L65
        L12:
            long r4 = r4 - r0
            goto L26
        L17:
            long r0 = MOKrTyKoZDIWflLP()
            goto Lb2
        L1f:
            ulRsFflmFMJhXofF(r6)
            goto L98
        L26:
            QNjnSKGPPjzCzwLw(r6, r3, r4)
            goto Lc5
        L2d:
            java.lang.Action r6 = r6.delayedHide
            goto L1f
        L33:
            long r3 = (long) r2
            goto La6
        L38:
            int r0 = r0 + r1
            goto Lac
        L3e:
            long r4 = (long) r2
            goto L12
        L43:
            return
        L44:
            goto L7c
        L48:
            goto L5a
        L4b:
            goto L6b
        L4f:
            int r0 = mbiHAuyWwoOtrheM(r6)
            goto L9
        L57:
            goto Lc6
        L5a:
            goto L4f
        L5e:
            r0 = 7
            goto Lbe
        L65:
            java.lang.Action r0 = r6.delayedShow
            goto L75
        L6b:
            goto L8e
        L6e:
            VPeiDeXdgBSBjZZw(r6, r0)
            goto L17
        L75:
            ZhdExNYQGaTUpZrG(r6, r0)
            goto L43
        L7c:
            java.lang.Action r0 = r6.delayedHide
            goto L6e
        L82:
            if (r0 <= 0) goto L87
            goto L5a
        L87:
            goto L57
        L8b:
            goto L4b
        L8e:
            goto L5e
        L92:
            int r2 = r6.minHideDelay
            goto L33
        L98:
            return
        L99:
            goto Lb8
        L9d:
            if (r3 >= 0) goto La2
            goto L99
        La2:
            goto L2d
        La6:
            int r3 = (r0 > r3 ? 1 : (r0 == r3 ? 0 : -1))
            goto L9d
        Lac:
            int r0 = r0 % r1
            goto L82
        Lb2:
            long r2 = r6.lastShowStartTime
            goto L4
        Lb8:
            java.lang.Action r3 = r6.delayedHide
            goto L3e
        Lbe:
            r1 = 16
            goto L38
        Lc5:
            return
        Lc6:
            goto L48
    }

    @Override // android.view.object
    public void Invalidate() {
            r1 = this;
            goto L1c
        L4:
            android.graphics.drawable.Drawable r1 = WIEADNjQkFRDkqei(r1)
            goto L33
        Lc:
            return
        Ld:
            goto L11
        L11:
            goto L1f
        L14:
            android.graphics.drawable.Drawable r0 = SpgNPdVHOgRdxZVT(r1)
            goto L23
        L1c:
            goto Ld
        L1f:
            goto L2c
        L23:
            if (r0 != 0) goto L28
            goto L36
        L28:
            goto L4
        L2c:
            keAQZdzCPzIAfqSP(r1)
            goto L14
        L33:
            JiTbeplQtSZQjWoF(r1)
        L36:
            goto Lc
    }

    bool isEffectivelyVisible() {
            r3 = this;
            goto L1d
        L4:
            android.view.object r0 = (android.view.object) r0
            goto L40
        La:
            int r0 = r0 % r1
            goto L45
        L10:
            android.view.objectParent r0 = caEjHJeJYSvmtQgG(r0)
            goto L53
        L18:
            r2 = 0
            goto L7e
        L1d:
            goto L63
        L20:
            goto L9a
        L24:
            if (r0 == 0) goto L29
            goto L7a
        L29:
            goto L58
        L2d:
            r0 = r3
        L2e:
            goto L32
        L32:
            int r1 = btHSElREyVOewudn(r0)
            goto L18
        L3a:
            bool r2 = r0 is android.view.object
            goto L67
        L40:
            goto L2e
        L41:
            goto L60
        L45:
            if (r0 <= 0) goto L4a
            goto L91
        L4a:
            goto L8e
        L4e:
            return r1
        L4f:
            goto L79
        L53:
            r1 = 1
            goto L24
        L58:
            int r3 = IHpwVQjjARKMxFSk(r3)
            goto La6
        L60:
            goto L91
        L63:
            goto L76
        L67:
            if (r2 == 0) goto L6c
            goto La2
        L6c:
            goto La1
        L70:
            int r0 = r0 + r1
            goto La
        L76:
            goto L20
        L79:
            return r2
        L7a:
            goto L3a
        L7e:
            if (r1 != 0) goto L83
            goto L96
        L83:
            goto L95
        L87:
            r1 = 7
            goto L70
        L8e:
            goto L41
        L91:
            goto L2d
        L95:
            return r2
        L96:
            goto L10
        L9a:
            r0 = 21
            goto L87
        La1:
            return r1
        La2:
            goto L4
        La6:
            if (r3 == 0) goto Lab
            goto L4f
        Lab:
            goto L4e
    }

    @Override // android.widget.ProgressBar, android.view.object
    protected void OnAttachedToWindow() {
            r1 = this;
            goto L28
        L4:
            zUHxOqSCMJtdnXGo(r1)
            goto L17
        Lb:
            llQWTpHLXQwTEExo(r1)
            goto L4
        L12:
            return
        L13:
            goto L36
        L17:
            bool r0 = aKCSwykDSyOejKEk(r1)
            goto L1f
        L1f:
            if (r0 != 0) goto L24
            goto L32
        L24:
            goto L2f
        L28:
            goto L13
        L2b:
            goto Lb
        L2f:
            qpGDgCxqYCmmQcmr(r1)
        L32:
            goto L12
        L36:
            goto L2b
    }

    @Override // android.widget.ProgressBar, android.view.object
    protected void OnDetachedFromWindow() {
            r1 = this;
            goto La
        L4:
            com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0 = (com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange) r0
            goto L2e
        La:
            goto L19
        Ld:
            goto L35
        L11:
            GcFZHkzvMtFJUnSl(r1)
            goto L49
        L18:
            return
        L19:
            goto L24
        L1d:
            IsdGeVGwRWqhjFIy(r1, r0)
            goto L3b
        L24:
            goto Ld
        L27:
            VGhdRiQKxTMRugxH(r1, r0)
            goto L43
        L2e:
            vNTxwQRyXHWrqJlZ(r0)
            goto L11
        L35:
            java.lang.Action r0 = r1.delayedHide
            goto L27
        L3b:
            android.graphics.drawable.Drawable r0 = CMqVIRFKwxxyoPyd(r1)
            goto L4
        L43:
            java.lang.Action r0 = r1.delayedShow
            goto L1d
        L49:
            NLuHoeDcFmUKhXVx(r1)
            goto L18
    }

    @Override // android.widget.ProgressBar, android.view.object
    protected void OnDraw(android.graphics.Canvas r6) {
            r5 = this;
            goto L10
        L4:
            throw r6
        L5:
            goto L27
        L9:
            r1 = 25
            goto L21
        L10:
            goto L2a
        L13:
            goto L98
        L17:
            goto L13
        L1a:
            goto L5
        L1d:
            goto L35
        L21:
            int r0 = r0 + r1
            goto L92
        L27:
            goto L1d
        L2a:
            goto L17
        L2e:
            return
        L2f:
            r6 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L2f
            goto L4
        L35:
            monitor-enter(r5)
            int r0 = WQFTMcoeWtRYmyfw(r6)     // Catch: java.lang.Exception -> L2f
            int r1 = ktdvsMtYmozworzE(r5)     // Catch: java.lang.Exception -> L2f
            if (r1 != 0) goto L46
            int r1 = kStYTjDMDXTYCgbg(r5)     // Catch: java.lang.Exception -> L2f
            if (r1 == 0) goto L53
        L46:
            int r1 = dPpNcrCccbjHaxZx(r5)     // Catch: java.lang.Exception -> L2f
            float r1 = (float) r1     // Catch: java.lang.Exception -> L2f
            int r2 = TFpqFLSwSRaobsAq(r5)     // Catch: java.lang.Exception -> L2f
            float r2 = (float) r2     // Catch: java.lang.Exception -> L2f
            yuAEnarVFNVQaMaX(r6, r1, r2)     // Catch: java.lang.Exception -> L2f
        L53:
            int r1 = BLCRMalVWAZYsxZG(r5)     // Catch: java.lang.Exception -> L2f
            if (r1 != 0) goto L5f
            int r1 = oEkWtpevEmGfezyb(r5)     // Catch: java.lang.Exception -> L2f
            if (r1 == 0) goto L7f
        L5f:
            int r1 = ncgkkMZHMEGEnzrH(r5)     // Catch: java.lang.Exception -> L2f
            int r2 = zyYZvkOAMRhTpRmB(r5)     // Catch: java.lang.Exception -> L2f
            int r3 = gzFpFbHfgcSGCGmR(r5)     // Catch: java.lang.Exception -> L2f
            int r2 = r2 + r3
            int r1 = r1 - r2
            int r2 = asJUFexcVmnMHPSx(r5)     // Catch: java.lang.Exception -> L2f
            int r3 = oxMwAyRaaxyQQSWR(r5)     // Catch: java.lang.Exception -> L2f
            int r4 = fsrHnUbDCGmCwYHm(r5)     // Catch: java.lang.Exception -> L2f
            int r3 = r3 + r4
            int r2 = r2 - r3
            r3 = 0
            KPMyaohtWtrdEKgH(r6, r3, r3, r1, r2)     // Catch: java.lang.Exception -> L2f
        L7f:
            android.graphics.drawable.Drawable r1 = XjlpCKLskKqwIIsU(r5)     // Catch: java.lang.Exception -> L2f
            RTSqHpIyQLgKaFTu(r1, r6)     // Catch: java.lang.Exception -> L2f
            UPEmiypQJyGodrOI(r6, r0)     // Catch: java.lang.Exception -> L2f
            goto L8d
        L8d:
            monitor-exit(r5)
            goto L2e
        L92:
            int r0 = r0 % r1
            goto L9f
        L98:
            r0 = 14
            goto L9
        L9f:
            if (r0 <= 0) goto La4
            goto L1d
        La4:
            goto L1a
    }

    @Override // android.widget.ProgressBar, android.view.object
    protected void OnMeasure(int r3, int r4) {
            r2 = this;
            goto L1f
        L4:
            if (r0 == 0) goto L9
            goto L27
        L9:
            goto Ld
        Ld:
            monitor-exit(r2)
            goto L26
        L12:
            int r0 = r0 + r1
            goto L8b
        L18:
            r0 = 32
            goto L6f
        L1f:
            goto L6b
        L22:
            goto L18
        L26:
            return
        L27:
            int r1 = TLUCfRdMuTYrZxzX(r0)     // Catch: java.lang.Exception -> L7c
            if (r1 >= 0) goto L36
            int r1 = WPmdQpZHVSFLbPqi(r2)     // Catch: java.lang.Exception -> L7c
            int r3 = RuvIINUSjmYNRsVU(r1, r3)     // Catch: java.lang.Exception -> L7c
            goto L44
        L36:
            int r3 = SiInCsqlIUfgaAjH(r0)     // Catch: java.lang.Exception -> L7c
            int r1 = BMEkmrLUVuYxNlGr(r2)     // Catch: java.lang.Exception -> L7c
            int r3 = r3 + r1
            int r1 = SkumJckPgaSOVCSx(r2)     // Catch: java.lang.Exception -> L7c
            int r3 = r3 + r1
        L44:
            int r1 = VKbQuVeQemkVFVBO(r0)     // Catch: java.lang.Exception -> L7c
            if (r1 >= 0) goto L53
            int r0 = YnixGhSOGZSwKHGC(r2)     // Catch: java.lang.Exception -> L7c
            int r4 = aapWVGWlfdIyoLtB(r0, r4)     // Catch: java.lang.Exception -> L7c
            goto L61
        L53:
            int r4 = moiTMHpQquPzrwYw(r0)     // Catch: java.lang.Exception -> L7c
            int r0 = gFvHGbUzGCAoxxVY(r2)     // Catch: java.lang.Exception -> L7c
            int r4 = r4 + r0
            int r0 = oGzmOqKthKBwHggS(r2)     // Catch: java.lang.Exception -> L7c
            int r4 = r4 + r0
        L61:
            VcelPbTQrguyCCWc(r2, r3, r4)     // Catch: java.lang.Exception -> L7c
            goto L76
        L68:
            goto La5
        L6b:
            goto L9a
        L6f:
            r1 = 13
            goto L12
        L76:
            monitor-exit(r2)
            goto L7b
        L7b:
            return
        L7c:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L7c
            goto L9d
        L82:
            monitor-enter(r2)
            com.google.android.material.progressindicator.DrawingDelegate r0 = JniZBscvbdisrggg(r2)     // Catch: java.lang.Exception -> L7c
            goto L4
        L8b:
            int r0 = r0 % r1
            goto L91
        L91:
            if (r0 <= 0) goto L96
            goto La5
        L96:
            goto La2
        L9a:
            goto L22
        L9d:
            throw r3
        L9e:
            goto L68
        La2:
            goto L9e
        La5:
            goto L82
    }

    @Override // android.view.object
    protected void OnVisibilityChanged(android.view.object r1, int r2) {
            r0 = this;
            goto L18
        L4:
            goto L1b
        L7:
            return
        L8:
            goto L4
        Lc:
            r1 = 1
            goto L2b
        L11:
            shdhWlTgXTjBLSTa(r0, r1)
            goto L7
        L18:
            goto L8
        L1b:
            goto L24
        L1f:
            r1 = 0
        L20:
            goto L11
        L24:
            vlTMrHqJPcVVEEsE(r0, r1, r2)
            goto L30
        L2b:
            goto L20
        L2c:
            goto L1f
        L30:
            if (r2 == 0) goto L35
            goto L2c
        L35:
            goto Lc
    }

    @Override // android.view.object
    protected void OnWindowVisibilityChanged(int r1) {
            r0 = this;
            goto L4
        L4:
            goto L18
        L7:
            goto L1c
        Lb:
            r1 = 0
            goto L10
        L10:
            GPEBebvLfHYIABWs(r0, r1)
            goto L17
        L17:
            return
        L18:
            goto L23
        L1c:
            sLtfASAqcfSJBbaZ(r0, r1)
            goto Lb
        L23:
            goto L7
    }

    public void SetAnimatorDurationScaleProvider(com.google.android.material.progressindicator.AnimatorDurationScaleProvider r2) {
            r1 = this;
            goto L4
        L4:
            goto L36
        L7:
            goto L1b
        Lb:
            com.google.android.material.progressindicator.IndeterminateDrawable r0 = osIxzfXkHMladAgF(r1)
            goto L46
        L13:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = NgMwktZZAQYodYPi(r1)
            goto L2f
        L1b:
            r1.animatorDurationScaleProvider = r2
            goto L21
        L21:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = gsSvlqFNMfFmqQOY(r1)
            goto L3d
        L29:
            r1.animatorDurationScaleProvider = r2
        L2b:
            goto L35
        L2f:
            r0.animatorDurationScaleProvider = r2
        L31:
            goto Lb
        L35:
            return
        L36:
            goto L3a
        L3a:
            goto L7
        L3d:
            if (r0 != 0) goto L42
            goto L31
        L42:
            goto L13
        L46:
            if (r0 != 0) goto L4b
            goto L2b
        L4b:
            goto L4f
        L4f:
            com.google.android.material.progressindicator.IndeterminateDrawable r1 = EXBprsQRLFxeYKRW(r1)
            goto L29
    }

    public void SetHideAnimationBehavior(int r2) {
            r1 = this;
            goto L14
        L4:
            r0.hideAnimationBehavior = r2
            goto La
        La:
            XnqeTsURmwFVfcDY(r1)
            goto L21
        L11:
            goto L17
        L14:
            goto L22
        L17:
            goto L1b
        L1b:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r1.spec
            goto L4
        L21:
            return
        L22:
            goto L11
    }

    @Override // android.widget.ProgressBar
    public void SetIndeterminate(bool r3) {
            r2 = this;
            goto L18
        L4:
            int r0 = r0 + r1
            goto L12
        La:
            goto L1b
        Ld:
            throw r3
        Le:
            goto L91
        L12:
            int r0 = r0 % r1
            goto L7a
        L18:
            goto L94
        L1b:
            goto L65
        L1f:
            monitor-enter(r2)
            bool r0 = RXORYeAeMuKTiwzO(r2)     // Catch: java.lang.Exception -> L6d
            goto L83
        L28:
            monitor-exit(r2)
            goto L2d
        L2d:
            return
        L2e:
            android.graphics.drawable.Drawable r0 = TlXzfYCsZeQmYfGg(r2)     // Catch: java.lang.Exception -> L6d
            com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0 = (com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange) r0     // Catch: java.lang.Exception -> L6d
            if (r0 == 0) goto L39
            KJsRebSfbwYKCEYA(r0)     // Catch: java.lang.Exception -> L6d
        L39:
            OWOxCptDBlqjQjQg(r2, r3)     // Catch: java.lang.Exception -> L6d
            android.graphics.drawable.Drawable r3 = JWwWuYbGVXfpNxzb(r2)     // Catch: java.lang.Exception -> L6d
            com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r3 = (com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange) r3     // Catch: java.lang.Exception -> L6d
            r0 = 0
            if (r3 == 0) goto L4c
            bool r1 = vBcfItHSXXPsPUXc(r2)     // Catch: java.lang.Exception -> L6d
            PAtLDXqCOWjArzIE(r3, r1, r0, r0)     // Catch: java.lang.Exception -> L6d
        L4c:
            bool r1 = r3 is com.google.android.material.progressindicator.IndeterminateDrawable     // Catch: java.lang.Exception -> L6d
            if (r1 == 0) goto L5f
            bool r1 = QRPLWfwIZxkExnbe(r2)     // Catch: java.lang.Exception -> L6d
            if (r1 == 0) goto L5f
            com.google.android.material.progressindicator.IndeterminateDrawable r3 = (com.google.android.material.progressindicator.IndeterminateDrawable) r3     // Catch: java.lang.Exception -> L6d
            com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r3 = aBxIaNAsubFtpBky(r3)     // Catch: java.lang.Exception -> L6d
            gsZKIgwZCGGTnrlF(r3)     // Catch: java.lang.Exception -> L6d
        L5f:
            r2.isIndeterminateModeChangeRequested = r0     // Catch: java.lang.Exception -> L6d
            goto L8c
        L65:
            r0 = 25
            goto L73
        L6c:
            return
        L6d:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L6d
            goto Ld
        L73:
            r1 = 1
            goto L4
        L7a:
            if (r0 <= 0) goto L7f
            goto L9b
        L7f:
            goto L98
        L83:
            if (r3 == r0) goto L88
            goto L2e
        L88:
            goto L28
        L8c:
            monitor-exit(r2)
            goto L6c
        L91:
            goto L9b
        L94:
            goto La
        L98:
            goto Le
        L9b:
            goto L1f
    }

    @Override // android.widget.ProgressBar
    public void SetIndeterminateDrawable(android.graphics.drawable.Drawable r2) {
            r1 = this;
            goto L1b
        L4:
            return
        L5:
            goto L4c
        L9:
            java.lang.string r2 = "Cannot set framework drawable as indeterminate drawable."
            goto L35
        Lf:
            bool r0 = r2 is com.google.android.material.progressindicator.IndeterminateDrawable
            goto L43
        L15:
            com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange r0 = (com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange) r0
            goto L61
        L1b:
            goto L31
        L1e:
            goto L22
        L22:
            if (r2 == 0) goto L27
            goto L69
        L27:
            goto L5c
        L2b:
            r0 = r2
            goto L15
        L30:
            throw r1
        L31:
            goto L59
        L35:
            r1.<init>(r2)
            goto L30
        L3c:
            EDYiYAKpmjxFSEsU(r1, r2)
            goto L4
        L43:
            if (r0 != 0) goto L48
            goto L5
        L48:
            goto L2b
        L4c:
            java.lang.IllegalArgumentException r1 = new java.lang.IllegalArgumentException
            goto L9
        L52:
            xhqrKDMNpzMhSrAx(r1, r2)
            goto L68
        L59:
            goto L1e
        L5c:
            r2 = 0
            goto L52
        L61:
            uIbdBYHpvoZBWAoF(r0)
            goto L3c
        L68:
            return
        L69:
            goto Lf
    }

    public void SetIndicatorColor(int... r4) {
            r3 = this;
            goto L4
        L4:
            goto L1b
        L7:
            goto L4b
        Lb:
            android.content.object r0 = oNkmSIYxQSAmZmRh(r3)
            goto La0
        L13:
            r4 = 1
            goto La6
        L18:
            goto L34
        L1b:
            goto Lac
        L1f:
            return
        L20:
            goto L18
        L24:
            r1 = 0
            goto L77
        L29:
            bool r0 = tMGDWhblwIYnjNaw(r0, r4)
            goto Lb4
        L31:
            goto L20
        L34:
            goto L63
        L38:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r3.spec
            goto L3e
        L3e:
            r0.indicatorColors = r4
            goto L7d
        L44:
            nfmiXCHUHkIKQtgf(r3)
        L47:
            goto L1f
        L4b:
            r0 = 25
            goto L85
        L52:
            int[] r0 = rAWIVuUrVBoChuoX(r3)
            goto L29
        L5a:
            if (r0 == 0) goto L5f
            goto L79
        L5f:
            goto L13
        L63:
            int r0 = r4.length
            goto L5a
        L68:
            int r0 = ZndHYZBCyMhfdmOF(r0, r1, r2)
            goto L24
        L70:
            zDTWVJUtHMzHFgFr(r4)
            goto L44
        L77:
            r4[r1] = r0
        L79:
            goto L52
        L7d:
            com.google.android.material.progressindicator.IndeterminateDrawable r4 = eVCEqMuQtwWNYxCk(r3)
            goto L98
        L85:
            r1 = 11
            goto L92
        L8c:
            int r0 = r0 % r1
            goto Lbd
        L92:
            int r0 = r0 + r1
            goto L8c
        L98:
            com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r4 = eBOHBzVsGiljMNrr(r4)
            goto L70
        La0:
            int r1 = com.google.android.material.C1151R.attr.colorPrimary
            goto Laf
        La6:
            int[] r4 = new int[r4]
            goto Lb
        Lac:
            goto L7
        Laf:
            r2 = -1
            goto L68
        Lb4:
            if (r0 == 0) goto Lb9
            goto L47
        Lb9:
            goto L38
        Lbd:
            if (r0 <= 0) goto Lc2
            goto L34
        Lc2:
            goto L31
    }

    public void SetIndicatorTrackGapSize(int r2) {
            r1 = this;
            goto L4
        L4:
            goto L32
        L7:
            goto L1e
        Lb:
            int r0 = r0.indicatorTrackGapSize
            goto L3f
        L11:
            r0.indicatorTrackGapSize = r2
            goto L36
        L17:
            AVYqpUHvLJFrXOyZ(r2)
            goto L2a
        L1e:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r1.spec
            goto Lb
        L24:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r1.spec
            goto L11
        L2a:
            IPgkEVZrTSsgfgjT(r1)
        L2d:
            goto L31
        L31:
            return
        L32:
            goto L3c
        L36:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r2 = r1.spec
            goto L17
        L3c:
            goto L7
        L3f:
            if (r0 != r2) goto L44
            goto L2d
        L44:
            goto L24
    }

    @Override // android.widget.ProgressBar
    public void SetProgress(int r2) {
            r1 = this;
            goto L26
        L4:
            monitor-exit(r1)
            goto L1a
        L9:
            if (r0 != 0) goto Le
            goto L2e
        Le:
            goto L12
        L12:
            monitor-exit(r1)
            goto L2d
        L17:
            goto L29
        L1a:
            return
        L1b:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1b
            goto L21
        L21:
            throw r2
        L22:
            goto L17
        L26:
            goto L22
        L29:
            goto L32
        L2d:
            return
        L2e:
            goto L3b
        L32:
            monitor-enter(r1)
            bool r0 = YidqOhxTRlvlMcaf(r1)     // Catch: java.lang.Exception -> L1b
            goto L9
        L3b:
            r0 = 0
            kSWvwUGBcIYYdCwx(r1, r2, r0)     // Catch: java.lang.Exception -> L1b
            goto L4
    }

    public void SetProgressCompat(int r2, bool r3) {
            r1 = this;
            goto L5e
        L4:
            com.google.android.material.progressindicator.DeterminateDrawable r1 = cSFfHCXqIPrbkPsy(r1)
            goto L6b
        Lc:
            if (r0 != 0) goto L11
            goto Lee
        L11:
            goto Ld1
        L15:
            return
        L16:
            goto L65
        L1a:
            if (r0 != 0) goto L1f
            goto L6e
        L1f:
            goto L43
        L23:
            if (r2 != 0) goto L28
            goto L6e
        L28:
            goto Lab
        L2c:
            if (r2 == 0) goto L31
            goto L7e
        L31:
            goto L7d
        L35:
            r1.isIndeterminateModeChangeRequested = r2
            goto L96
        L3b:
            com.google.android.material.progressindicator.IndeterminateDrawable r1 = QtwmEHgFongMyeKn(r1)
            goto L88
        L43:
            r1.storedProgress = r2
            goto Lcb
        L49:
            QktExZxUReAtADqE(r1, r2)
            goto Lf2
        L50:
            if (r2 != 0) goto L55
            goto L16
        L55:
            goto L82
        L59:
            r2 = 1
            goto L35
        L5e:
            goto L9f
        L61:
            goto Lb4
        L65:
            androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback r2 = r1.switchIndeterminateModeCallback
            goto Lfa
        L6b:
            STRAnHtijctUvjTg(r1)
        L6e:
            goto L9e
        L72:
            goto L61
        L75:
            android.content.ContentResolver r3 = EpwCtpUcIcxRCgJG(r3)
            goto Lbc
        L7d:
            goto L16
        L7e:
            goto L3b
        L82:
            com.google.android.material.progressindicator.AnimatorDurationScaleProvider r2 = r1.animatorDurationScaleProvider
            goto La3
        L88:
            com.google.android.material.progressindicator.IndeterminateAnimatorDelegate r1 = LelmLDvryjpisrGw(r1)
            goto Lc4
        L90:
            int r2 = (r2 > r3 ? 1 : (r2 == r3 ? 0 : -1))
            goto L2c
        L96:
            com.google.android.material.progressindicator.IndeterminateDrawable r2 = svBKyYIQVAARJjFB(r1)
            goto Lde
        L9e:
            return
        L9f:
            goto L72
        La3:
            android.content.object r3 = xGcjlFwgQhXbBRVU(r1)
            goto L75
        Lab:
            if (r3 == 0) goto Lb0
            goto L6e
        Lb0:
            goto L4
        Lb4:
            bool r0 = AJgbyjTGNmdRykQI(r1)
            goto Lc
        Lbc:
            float r2 = auWBOMxLhHClDaFR(r2, r3)
            goto Ld9
        Lc4:
            wbaIoUQwUzPHzwDg(r1)
            goto L15
        Lcb:
            r1.storedProgressAnimated = r3
            goto L59
        Ld1:
            com.google.android.material.progressindicator.DeterminateDrawable r0 = CbSIaToSDjBsXyvO(r1)
            goto L1a
        Ld9:
            r3 = 0
            goto L90
        Lde:
            bool r2 = nRLShGzbIyqCENKj(r2)
            goto L50
        Le6:
            TPkmHJVjhJopLsWZ(r2, r1)
            goto Led
        Led:
            return
        Lee:
            goto L49
        Lf2:
            com.google.android.material.progressindicator.DeterminateDrawable r2 = CjTAFPiOvoaYyUGb(r1)
            goto L23
        Lfa:
            com.google.android.material.progressindicator.IndeterminateDrawable r1 = AKTyPWbHCsFEnapt(r1)
            goto Le6
    }

    @Override // android.widget.ProgressBar
    public void SetProgressDrawable(android.graphics.drawable.Drawable r2) {
            r1 = this;
            goto L5a
        L4:
            com.google.android.material.progressindicator.DeterminateDrawable r2 = (com.google.android.material.progressindicator.DeterminateDrawable) r2
            goto L61
        La:
            tjmnmVrSYqjSWRBZ(r1, r2)
            goto L48
        L11:
            if (r2 == 0) goto L16
            goto L49
        L16:
            goto L1a
        L1a:
            r2 = 0
            goto La
        L1f:
            int r1 = DjffsBLgiuXUpoDw(r1)
            goto L82
        L27:
            if (r0 != 0) goto L2c
            goto L31
        L2c:
            goto L4
        L30:
            return
        L31:
            goto L3b
        L35:
            bool r0 = r2 is com.google.android.material.progressindicator.DeterminateDrawable
            goto L27
        L3b:
            java.lang.IllegalArgumentException r1 = new java.lang.IllegalArgumentException
            goto L74
        L41:
            r1.<init>(r2)
            goto L7a
        L48:
            return
        L49:
            goto L35
        L4d:
            int r0 = oIvtwbonGmimJoiu(r1)
            goto L68
        L55:
            float r0 = r0 / r1
            goto L6d
        L5a:
            goto L7b
        L5d:
            goto L11
        L61:
            gQcMOqwkIdDjyhlE(r2)
            goto L87
        L68:
            float r0 = (float) r0
            goto L1f
        L6d:
            gKvGRBTdDadggDdp(r2, r0)
            goto L30
        L74:
            java.lang.string r2 = "Cannot set framework drawable as progress drawable."
            goto L41
        L7a:
            throw r1
        L7b:
            goto L7f
        L7f:
            goto L5d
        L82:
            float r1 = (float) r1
            goto L55
        L87:
            VBfmiThpwMljruef(r1, r2)
            goto L4d
    }

    public void SetShowAnimationBehavior(int r2) {
            r1 = this;
            goto Le
        L4:
            goto L11
        L7:
            wCoIUyanIBQcrwYc(r1)
            goto L15
        Le:
            goto L16
        L11:
            goto L1a
        L15:
            return
        L16:
            goto L4
        L1a:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r1.spec
            goto L20
        L20:
            r0.showAnimationBehavior = r2
            goto L7
    }

    public void SetTrackColor(int r2) {
            r1 = this;
            goto L1c
        L4:
            return
        L5:
            goto L23
        L9:
            r0.trackColor = r2
            goto L15
        Lf:
            int r0 = r0.trackColor
            goto L32
        L15:
            ExRaxhhZyQTcyTXr(r1)
        L18:
            goto L4
        L1c:
            goto L5
        L1f:
            goto L26
        L23:
            goto L1f
        L26:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r1.spec
            goto Lf
        L2c:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r1.spec
            goto L9
        L32:
            if (r0 != r2) goto L37
            goto L18
        L37:
            goto L2c
    }

    public void SetTrackCornerRadius(int r3) {
            r2 = this;
            goto L72
        L4:
            if (r0 <= 0) goto L9
            goto L61
        L9:
            goto L5e
        Ld:
            r0.trackCornerRadius = r3
            goto L79
        L13:
            int r0 = r0 % r1
            goto L4
        L19:
            int r0 = r0 + r1
            goto L13
        L1f:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r2.spec
            goto L58
        L25:
            goto L75
        L28:
            int r0 = r0.trackCornerRadius
            goto L2e
        L2e:
            if (r0 != r3) goto L33
            goto L7c
        L33:
            goto L1f
        L37:
            r0 = 10
            goto L6b
        L3e:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r2.spec
            goto L28
        L44:
            int r3 = SpJQEMaQBHTJSRrw(r3, r1)
            goto Ld
        L4c:
            goto L61
        L4f:
            goto L25
        L53:
            return
        L54:
            goto L4c
        L58:
            int r1 = r0.trackThickness
            goto L65
        L5e:
            goto L54
        L61:
            goto L3e
        L65:
            int r1 = r1 / 2
            goto L44
        L6b:
            r1 = 2
            goto L19
        L72:
            goto L4f
        L75:
            goto L37
        L79:
            QBVeCtubQplkwALW(r2)
        L7c:
            goto L53
    }

    public void SetTrackThickness(int r2) {
            r1 = this;
            goto L34
        L4:
            r0.trackThickness = r2
            goto L2d
        La:
            goto L37
        Ld:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r1.spec
            goto L4
        L13:
            if (r0 != r2) goto L18
            goto L30
        L18:
            goto Ld
        L1c:
            S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec r0 = r1.spec
            goto L27
        L22:
            return
        L23:
            goto La
        L27:
            int r0 = r0.trackThickness
            goto L13
        L2d:
            SYSRIkyIcPngzqBs(r1)
        L30:
            goto L22
        L34:
            goto L23
        L37:
            goto L1c
    }

    public void SetVisibilityAfterHide(int r2) {
            r1 = this;
            goto L9
        L4:
            goto L46
        L5:
            goto L2b
        L9:
            goto L11
        Lc:
            goto L37
        L10:
            return
        L11:
            goto L4a
        L15:
            if (r2 == r0) goto L1a
            goto L5
        L1a:
            goto L4
        L1e:
            r1.<init>(r2)
            goto L45
        L25:
            r1.visibilityAfterHide = r2
            goto L10
        L2b:
            java.lang.IllegalArgumentException r1 = new java.lang.IllegalArgumentException
            goto L4d
        L31:
            r0 = 8
            goto L15
        L37:
            if (r2 != 0) goto L3c
            goto L46
        L3c:
            goto L40
        L40:
            r0 = 4
            goto L53
        L45:
            throw r1
        L46:
            goto L25
        L4a:
            goto Lc
        L4d:
            java.lang.string r2 = "The component's visibility must be one of VISIBLE, INVISIBLE, and GONE defined in object."
            goto L1e
        L53:
            if (r2 != r0) goto L58
            goto L46
        L58:
            goto L31
    }

    public void Show() {
            r3 = this;
            goto L54
        L4:
            if (r0 <= 0) goto L9
            goto L16
        L9:
            goto L13
        Ld:
            int r0 = r0 % r1
            goto L4
        L13:
            goto L44
        L16:
            goto L48
        L1a:
            MpZfWAtQfISDOpTm(r3, r0, r1)
            goto L75
        L21:
            r0 = 5
            goto L68
        L28:
            fYYDRACaSByNvSeS(r3, r0)
            goto L4e
        L2f:
            if (r0 > 0) goto L34
            goto L76
        L34:
            goto L6f
        L38:
            java.lang.Action r3 = r3.delayedShow
            goto L5b
        L3e:
            long r1 = (long) r1
            goto L1a
        L43:
            return
        L44:
            goto L80
        L48:
            int r0 = r3.showDelay
            goto L2f
        L4e:
            java.lang.Action r0 = r3.delayedShow
            goto L7a
        L54:
            goto L83
        L57:
            goto L21
        L5b:
            gmnDOYLyckvYdjpi(r3)
            goto L43
        L62:
            int r0 = r0 + r1
            goto Ld
        L68:
            r1 = 21
            goto L62
        L6f:
            java.lang.Action r0 = r3.delayedShow
            goto L28
        L75:
            return
        L76:
            goto L38
        L7a:
            int r1 = r3.showDelay
            goto L3e
        L80:
            goto L16
        L83:
            goto L87
        L87:
            goto L57
    }

    bool visibleToUser() {
            r1 = this;
            goto L4e
        L4:
            r1 = 1
            goto L33
        L9:
            if (r0 == 0) goto Le
            goto L34
        Le:
            goto L28
        L12:
            return r1
        L13:
            goto L30
        L17:
            int r0 = BZdzluonJEJIBocu(r1)
            goto L9
        L1f:
            if (r0 != 0) goto L24
            goto L34
        L24:
            goto L17
        L28:
            bool r1 = QVNpmwlcoqlmoqOz(r1)
            goto L3d
        L30:
            goto L51
        L33:
            return r1
        L34:
            goto L38
        L38:
            r1 = 0
            goto L12
        L3d:
            if (r1 != 0) goto L42
            goto L34
        L42:
            goto L4
        L46:
            bool r0 = AwtLJdaCNfDIZXpH(r1)
            goto L1f
        L4e:
            goto L13
        L51:
            goto L46
    }
}

