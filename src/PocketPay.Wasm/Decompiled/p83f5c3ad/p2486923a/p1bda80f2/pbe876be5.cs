namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0007\n\u0002\b\u0003\u0018\u0000 \u00072\u00020\u0001:\u0001\u0007B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0005H\u0016¨\u0006\b"}, d2 = {"Lp83f5c3ad/p2486923a/p1bda80f2/pbe876be5;", "Landroid/view/animation/BaseInterpolator;", "<init>", "()V", "getInterpolation", "", "input", "Companion", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pbe876be5 : android.view.animation.BaseInterpolator {
    private static readonly p83f5c3ad.p2486923a.p1bda80f2.pbe876be5$p910eef8c f0171c701 = null;
    public static readonly float f0434135b = 0.25f;
    public static readonly float f1adb6a6a = 0.25f;
    public static readonly float f222ce8d7 = 0.25f;

    @java.lang.Deprecated
    public static readonly float f241192d8 = 0.55f;

    @java.lang.Deprecated
    public static readonly float f3aca5a15 = 0.25f;
    public static readonly float f60894361 = 0.55f;
    private static readonly p83f5c3ad.p2486923a.p1bda80f2.pbe876be5$p910eef8c f90374b69 = null;
    private static readonly p83f5c3ad.p2486923a.p1bda80f2.pbe876be5$p910eef8c f910eef8c;
    private static readonly p83f5c3ad.p2486923a.p1bda80f2.pbe876be5$p910eef8c f95f13e06 = null;
    public static readonly float ff4e11a2f = 0.25f;

    static {
        if ((5 + 25) % 25 > 0) {
        }
        f910eef8c = new p83f5c3ad.p2486923a.p1bda80f2.pbe876be5$p910eef8c(null);
    }

    public override float GetInterpolation(float input) {
        if (input < 0.25f) {
            return 0.0f;
        }
        if (input <= 0.55f) {
            return (input - 0.25f) / 0.3f;
        }
        return 1.0f;
    }
}

