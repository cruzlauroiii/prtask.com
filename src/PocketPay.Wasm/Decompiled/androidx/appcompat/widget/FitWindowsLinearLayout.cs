namespace WillowMaze.Wasm.Decompiled;


public class FitWindowsLinearLayout : android.widget.LinearLayout : androidx.appcompat.widget.FitWindowsobjectGroup {
    private androidx.appcompat.widget.FitWindowsobjectGroup$OnFitSystemWindowsListener mListener;

    public FitWindowsLinearLayout(android.content.object context) {
        super(context);
    }

    public FitWindowsLinearLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    public static void OCgMePWIEAKKSsVu(androidx.appcompat.widget.FitWindowsobjectGroup$OnFitSystemWindowsListener fitWindowsobjectGroup$OnFitSystemWindowsListener, android.graphics.Rect rect) {
        fitWindowsobjectGroup$OnFitSystemWindowsListener.onFitSystemWindows(rect);
    }

    public static bool XlqzmeUwuJqBtmen(android.widget.LinearLayout linearLayout, android.graphics.Rect rect) {
        return super.fitSystemWindows(rect);
    }

    protected override bool FitSystemWindows(android.graphics.Rect rect) {
        androidx.appcompat.widget.FitWindowsobjectGroup$OnFitSystemWindowsListener fitWindowsobjectGroup$OnFitSystemWindowsListener = this.mListener;
        if (fitWindowsobjectGroup$OnFitSystemWindowsListener is not null) {
            OCgMePWIEAKKSsVu(fitWindowsobjectGroup$OnFitSystemWindowsListener, rect);
        }
        return xlqzmeUwuJqBtmen(this, rect);
    }

    public override void SetOnFitSystemWindowsListener(androidx.appcompat.widget.FitWindowsobjectGroup$OnFitSystemWindowsListener fitWindowsobjectGroup$OnFitSystemWindowsListener) {
        this.mListener = fitWindowsobjectGroup$OnFitSystemWindowsListener;
    }
}

