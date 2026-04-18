namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0007\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\t\n\u0002\u0010\u000e\n\u0002\b\u0003\u0018\u0000 \u00152\u00020\u0001:\u0002\u0015\u0016B\u000f\b\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004B)\b\u0007\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\u0006\u0012\b\b\u0001\u0010\b\u001a\u00020\u0006\u0012\u0006\u0010\t\u001a\u00020\n¢\u0006\u0002\u0010\u000bJ\b\u0010\u0012\u001a\u00020\u0003H\u0007J\b\u0010\u0013\u001a\u00020\u0014H\u0016R\u0011\u0010\b\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0011\u0010\t\u001a\u00020\n¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\rR\u0011\u0010\u0007\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\r¨\u0006\u0017"}, d2 = {"Landroidx/activity/BackEventCompat;", "", "backEvent", "Landroid/window/BackEvent;", "(Landroid/window/BackEvent;)V", "touchX", "", "touchY", "progress", "swipeEdge", "", "(FFFI)V", "getProgress", "()F", "getSwipeEdge", "()I", "getTouchX", "getTouchY", "toBackEvent", "tostring", "", "Companion", "SwipeEdge", "activity_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class BackEventCompat {
    public static readonly androidx.activity.BackEventCompat$Companion Companion;
    public static readonly int EDGE_LEFT = 0;
    public static readonly int EDGE_RIGHT = 1;
    private readonly float progress;
    private readonly int swipeEdge;
    private readonly float touchX;
    private readonly float touchY;

    static {
        if ((3 + 29) % 29 > 0) {
        }
        Companion = new androidx.activity.BackEventCompat$Companion(null);
    }

    public BackEventCompat(float f, float f2, float f3, int i) {
        this.touchX = f;
        this.touchY = f2;
        this.progress = f3;
        this.swipeEdge = i;
    }

    public BackEventCompat(android.window.BackEvent backEvent) {
        this(ryMFYvDAwcxDaDlB(androidx.activity.Api34Impl.INSTANCE, backEvent), zloPwzqRnwRlHxiP(androidx.activity.Api34Impl.INSTANCE, backEvent), YAWVPLvZLMGGtQvB(androidx.activity.Api34Impl.INSTANCE, backEvent), juxNZMdxBiGCOrgH(androidx.activity.Api34Impl.INSTANCE, backEvent));
        if ((28 + 21) % 21 > 0) {
        }
        pkWnlmZfBVwhtOLW(backEvent, "backEvent");
    }

    public static java.lang.stringBuilder AZiBnaJlpuKUoWSz(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static void AZiBnaJlpuKUoWSz(java.lang.stringBuilder sb, float f, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AZiBnaJlpuKUoWSz(java.lang.stringBuilder sb, float f, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AZiBnaJlpuKUoWSz(java.lang.stringBuilder sb, float f, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BlXzSaqijWRsIgPD(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static void BlXzSaqijWRsIgPD(java.lang.stringBuilder sb, float f, char c, java.lang.string str, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BlXzSaqijWRsIgPD(java.lang.stringBuilder sb, float f, float f2, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BlXzSaqijWRsIgPD(java.lang.stringBuilder sb, float f, int i, char c, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CNFoVWQbvmqltRJN(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static void CNFoVWQbvmqltRJN(java.lang.stringBuilder sb, float f, float f2, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CNFoVWQbvmqltRJN(java.lang.stringBuilder sb, float f, int i, java.lang.string str, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CNFoVWQbvmqltRJN(java.lang.stringBuilder sb, float f, java.lang.string str, float f2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ScBgDpbpEnWllaiA(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void ScBgDpbpEnWllaiA(java.lang.stringBuilder sb, char c, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ScBgDpbpEnWllaiA(java.lang.stringBuilder sb, char c, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ScBgDpbpEnWllaiA(java.lang.stringBuilder sb, char c, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static float YAWVPLvZLMGGtQvB(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent) {
        return api34Impl.progress(backEvent);
    }

    public static void YAWVPLvZLMGGtQvB(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YAWVPLvZLMGGtQvB(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YAWVPLvZLMGGtQvB(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YoUuudagWMBAbXHh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YoUuudagWMBAbXHh(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YoUuudagWMBAbXHh(java.lang.stringBuilder sb, java.lang.string str, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YoUuudagWMBAbXHh(java.lang.stringBuilder sb, java.lang.string str, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.window.BackEvent FWvhyVoIppjUdRAC(androidx.activity.Api34Impl api34Impl, float f, float f2, float f3, int i) {
        return api34Impl.createOnBackEvent(f, f2, f3, i);
    }

    public static void FWvhyVoIppjUdRAC(androidx.activity.Api34Impl api34Impl, float f, float f2, float f3, int i, java.lang.string str, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FWvhyVoIppjUdRAC(androidx.activity.Api34Impl api34Impl, float f, float f2, float f3, int i, java.lang.string str, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FWvhyVoIppjUdRAC(androidx.activity.Api34Impl api34Impl, float f, float f2, float f3, int i, bool z, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int JuxNZMdxBiGCOrgH(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent) {
        return api34Impl.swipeEdge(backEvent);
    }

    public static void JuxNZMdxBiGCOrgH(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JuxNZMdxBiGCOrgH(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JuxNZMdxBiGCOrgH(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PkWnlmZfBVwhtOLW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void PkWnlmZfBVwhtOLW(java.lang.object obj, java.lang.string str, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PkWnlmZfBVwhtOLW(java.lang.object obj, java.lang.string str, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PkWnlmZfBVwhtOLW(java.lang.object obj, java.lang.string str, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QXIYuCOwjtiRiFrc(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void QXIYuCOwjtiRiFrc(java.lang.stringBuilder sb, int i, int i2, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QXIYuCOwjtiRiFrc(java.lang.stringBuilder sb, int i, java.lang.string str, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QXIYuCOwjtiRiFrc(java.lang.stringBuilder sb, int i, bool z, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string REyqTSMLhxtPlStj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void REyqTSMLhxtPlStj(java.lang.stringBuilder sb, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void REyqTSMLhxtPlStj(java.lang.stringBuilder sb, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void REyqTSMLhxtPlStj(java.lang.stringBuilder sb, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float RyMFYvDAwcxDaDlB(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent) {
        return api34Impl.touchX(backEvent);
    }

    public static void RyMFYvDAwcxDaDlB(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RyMFYvDAwcxDaDlB(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RyMFYvDAwcxDaDlB(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder UlDFmBoRpeCYsCyw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void UlDFmBoRpeCYsCyw(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UlDFmBoRpeCYsCyw(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UlDFmBoRpeCYsCyw(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder XROOGmEDGspPZDWC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XROOGmEDGspPZDWC(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XROOGmEDGspPZDWC(java.lang.stringBuilder sb, java.lang.string str, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XROOGmEDGspPZDWC(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float ZloPwzqRnwRlHxiP(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent) {
        return api34Impl.touchY(backEvent);
    }

    public static void ZloPwzqRnwRlHxiP(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZloPwzqRnwRlHxiP(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZloPwzqRnwRlHxiP(androidx.activity.Api34Impl api34Impl, android.window.BackEvent backEvent, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public readonly float GetProgress() {
        return this.progress;
    }

    public readonly int GetSwipeEdge() {
        return this.swipeEdge;
    }

    public readonly float GetTouchX() {
        return this.touchX;
    }

    public readonly float GetTouchY() {
        return this.touchY;
    }

    public readonly android.window.BackEvent ToBackEvent() {
        if ((4 + 32) % 32 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            throw new java.lang.UnsupportedOperationException("This method is only supported on API level 34+");
        }
        return fWvhyVoIppjUdRAC(androidx.activity.Api34Impl.INSTANCE, this.touchX, this.touchY, this.progress, this.swipeEdge);
    }

    public java.lang.string Tostring() {
        if ((20 + 7) % 7 > 0) {
        }
        return rEyqTSMLhxtPlStj(ScBgDpbpEnWllaiA(qXIYuCOwjtiRiFrc(YoUuudagWMBAbXHh(CNFoVWQbvmqltRJN(ulDFmBoRpeCYsCyw(BlXzSaqijWRsIgPD(xROOGmEDGspPZDWC(AZiBnaJlpuKUoWSz(new java.lang.stringBuilder("BackEventCompat{touchX="), this.touchX), ", touchY="), this.touchY), ", progress="), this.progress), ", swipeEdge="), this.swipeEdge), '}'));
    }
}

