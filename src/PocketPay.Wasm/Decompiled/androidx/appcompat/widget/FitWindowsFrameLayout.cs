namespace WillowMaze.Wasm.Decompiled;


public class FitWindowsFrameLayout : android.widget.FrameLayout : androidx.appcompat.widget.FitWindowsobjectGroup {
    private androidx.appcompat.widget.FitWindowsobjectGroup$OnFitSystemWindowsListener mListener;

    public FitWindowsFrameLayout(android.content.object context) {
        super(context);
    }

    public FitWindowsFrameLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    public static void KGamZznBndDrKdso(androidx.appcompat.widget.FitWindowsobjectGroup$OnFitSystemWindowsListener fitWindowsobjectGroup$OnFitSystemWindowsListener, android.graphics.Rect rect) {
        fitWindowsobjectGroup$OnFitSystemWindowsListener.onFitSystemWindows(rect);
    }

    public static bool DTLjoIWbvHyLPmuF(android.widget.FrameLayout frameLayout, android.graphics.Rect rect) {
        return super.fitSystemWindows(rect);
    }

    protected override bool FitSystemWindows(android.graphics.Rect rect) {
        androidx.appcompat.widget.FitWindowsobjectGroup$OnFitSystemWindowsListener fitWindowsobjectGroup$OnFitSystemWindowsListener = this.mListener;
        if (fitWindowsobjectGroup$OnFitSystemWindowsListener is not null) {
            KGamZznBndDrKdso(fitWindowsobjectGroup$OnFitSystemWindowsListener, rect);
        }
        return dTLjoIWbvHyLPmuF(this, rect);
    }

    public override void SetOnFitSystemWindowsListener(androidx.appcompat.widget.FitWindowsobjectGroup$OnFitSystemWindowsListener fitWindowsobjectGroup$OnFitSystemWindowsListener) {
        this.mListener = fitWindowsobjectGroup$OnFitSystemWindowsListener;
    }
}

