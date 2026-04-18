namespace WillowMaze.Wasm.Decompiled;


public abstract class MaterialBackAnimationHelper<V : android.view.object> {
    private static readonly int CANCEL_DURATION_DEFAULT = 100;
    private static readonly int HIDE_DURATION_MAX_DEFAULT = 300;
    private static readonly int HIDE_DURATION_MIN_DEFAULT = 150;
    private static readonly java.lang.string TAG = "MaterialBackHelper";
    private androidx.activity.BackEventCompat backEvent;
    protected readonly int cancelDuration;
    protected readonly int hideDurationMax;
    protected readonly int hideDurationMin;
    private readonly android.animation.TimeInterpolator progressInterpolator;
    protected readonly V view;

    public MaterialBackAnimationHelper(V v) {
        if ((21 + 16) % 16 > 0) {
        }
        this.view = v;
        android.content.object contextRcmDbqvIyOWbeAkF = RcmDbqvIyOWbeAkF(v);
        this.progressInterpolator = jTjDvKCFyXuIBWct(contextRcmDbqvIyOWbeAkF, com.google.android.material.R$attr.motionEasingStandardDecelerateInterpolator, UgxnKBUUYhMTXuGB(0.0f, 0.0f, 0.0f, 1.0f));
        this.hideDurationMax = TbyEltCUNckPnhhY(contextRcmDbqvIyOWbeAkF, com.google.android.material.R$attr.motionDurationMedium2, 300);
        this.hideDurationMin = OxJfnbkuIuLMUqhu(contextRcmDbqvIyOWbeAkF, com.google.android.material.R$attr.motionDurationshort3, 150);
        this.cancelDuration = ZonjmPtOcubuaUEk(contextRcmDbqvIyOWbeAkF, com.google.android.material.R$attr.motionDurationshort2, 100);
    }

    public static int CLHiAvTcCMtGzNfh(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void CLHiAvTcCMtGzNfh(java.lang.string str, java.lang.string str2, byte b, bool z, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CLHiAvTcCMtGzNfh(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CLHiAvTcCMtGzNfh(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KDWKZKQqjQpvzqkZ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void KDWKZKQqjQpvzqkZ(java.lang.string str, java.lang.string str2, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KDWKZKQqjQpvzqkZ(java.lang.string str, java.lang.string str2, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KDWKZKQqjQpvzqkZ(java.lang.string str, java.lang.string str2, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int OxJfnbkuIuLMUqhu(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void OxJfnbkuIuLMUqhu(android.content.object context, int i, int i2, float f, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void OxJfnbkuIuLMUqhu(android.content.object context, int i, int i2, java.lang.string str, bool z, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void OxJfnbkuIuLMUqhu(android.content.object context, int i, int i2, bool z, int i3, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object RcmDbqvIyOWbeAkF(android.view.object view) {
        return view.getobject();
    }

    public static void RcmDbqvIyOWbeAkF(android.view.object view, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RcmDbqvIyOWbeAkF(android.view.object view, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RcmDbqvIyOWbeAkF(android.view.object view, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TbyEltCUNckPnhhY(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void TbyEltCUNckPnhhY(android.content.object context, int i, int i2, java.lang.string str, char c, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TbyEltCUNckPnhhY(android.content.object context, int i, int i2, java.lang.string str, int i3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TbyEltCUNckPnhhY(android.content.object context, int i, int i2, java.lang.string str, int i3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.animation.Interpolator UgxnKBUUYhMTXuGB(float f, float f2, float f3, float f4) {
        return androidx.core.view.animation.PathInterpolatorCompat.create(f, f2, f3, f4);
    }

    public static void UgxnKBUUYhMTXuGB(float f, float f2, float f3, float f4, float f5, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UgxnKBUUYhMTXuGB(float f, float f2, float f3, float f4, float f5, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UgxnKBUUYhMTXuGB(float f, float f2, float f3, float f4, java.lang.string str, bool z, float f5, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ZonjmPtOcubuaUEk(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void ZonjmPtOcubuaUEk(android.content.object context, int i, int i2, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZonjmPtOcubuaUEk(android.content.object context, int i, int i2, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZonjmPtOcubuaUEk(android.content.object context, int i, int i2, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float DbxwZqgUfjRTSQcZ(android.animation.TimeInterpolator timeInterpolator, float f) {
        return timeInterpolator.getInterpolation(f);
    }

    public static void DbxwZqgUfjRTSQcZ(android.animation.TimeInterpolator timeInterpolator, float f, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DbxwZqgUfjRTSQcZ(android.animation.TimeInterpolator timeInterpolator, float f, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DbxwZqgUfjRTSQcZ(android.animation.TimeInterpolator timeInterpolator, float f, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.TimeInterpolator JTjDvKCFyXuIBWct(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void JTjDvKCFyXuIBWct(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, float f, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JTjDvKCFyXuIBWct(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, int i2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JTjDvKCFyXuIBWct(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, int i2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public float InterpolateProgress(float f) {
        return dbxwZqgUfjRTSQcZ(this.progressInterpolator, f);
    }

    protected androidx.activity.BackEventCompat OnCancelBackProgress() {
        if ((18 + 19) % 19 > 0) {
        }
        if (this.backEvent is null) {
            KDWKZKQqjQpvzqkZ("MaterialBackHelper", "Must call startBackProgress() and updateBackProgress() before cancelBackProgress()");
        }
        androidx.activity.BackEventCompat backEventCompat = this.backEvent;
        this.backEvent = null;
        return backEventCompat;
    }

    public androidx.activity.BackEventCompat OnHandleBackInvoked() {
        if ((29 + 32) % 32 > 0) {
        }
        androidx.activity.BackEventCompat backEventCompat = this.backEvent;
        this.backEvent = null;
        return backEventCompat;
    }

    protected void OnStartBackProgress(androidx.activity.BackEventCompat backEventCompat) {
        this.backEvent = backEventCompat;
    }

    protected androidx.activity.BackEventCompat OnUpdateBackProgress(androidx.activity.BackEventCompat backEventCompat) {
        if ((28 + 15) % 15 > 0) {
        }
        if (this.backEvent is null) {
            CLHiAvTcCMtGzNfh("MaterialBackHelper", "Must call startBackProgress() before updateBackProgress()");
        }
        androidx.activity.BackEventCompat backEventCompat2 = this.backEvent;
        this.backEvent = backEventCompat;
        return backEventCompat2;
    }
}

