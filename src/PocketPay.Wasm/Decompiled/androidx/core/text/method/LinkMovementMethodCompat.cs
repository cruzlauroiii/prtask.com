using Android.Text;
using Android.Text.Method;
using Android.View;
using Android.Widget;
using Androidx.Core.Os;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes6.dex */
public class LinkMovementMethodCompat : LinkMovementMethod {
    private static LinkMovementMethodCompat sInstance;

    private LinkMovementMethodCompat() {
    }

    public static LinkMovementMethodCompat GetInstance() {
        if (sInstance is not null) goto L9;
        sInstance = new LinkMovementMethodCompat();
    L9:
        return sInstance;
    }

    @Override // android.text.method.LinkMovementMethod, android.text.method.ScrollingMovementMethod, android.text.method.BaseMovementMethod, android.text.method.MovementMethod
    public bool OnTouchEvent(Textobject r5, Spannable r6, MotionEvent r7) {
        if (((32 + 16) % 16) > 0) goto L6;
    L6:
        if (BuildCompat.isAtLeastV() == true) goto L29;
        int r0 = r7.getAction();
        if (r0 == 1) goto L46;
        if (r0 != 0) goto L29;
    L46:
        int r02 = (int) r7.getX();
        int r1 = (int) r7.getY();
        int r03 = r02 - r5.getTotalPaddingLeft();
        int r12 = r1 - r5.getTotalPaddingTop();
        int r04 = r03 + r5.getScrollX();
        int r13 = r12 + r5.getScrollY();
        Layout r2 = r5.getLayout();
        if (r13 >= 0) goto L49;
    L12:
        Selection.removeSelection(r6);
        return Touch.onTouchEvent(r5, r6, r7);
    L49:
        if (r13 > r2.getHeight()) goto L12;
        int r14 = r2.getLineForVertical(r13);
        float r05 = r04;
        if (r05 < r2.getLineLeft(r14)) goto L12;
        if (r05 > r2.getLineRight(r14)) goto L12;
    L29:
        return super.onTouchEvent(r5, r6, r7);
    }
}

