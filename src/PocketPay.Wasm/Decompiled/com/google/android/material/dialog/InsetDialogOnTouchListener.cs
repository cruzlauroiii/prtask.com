namespace WillowMaze.Wasm.Decompiled;


public class InsetDialogOnTouchListener : android.view.object$OnTouchListener {
    private readonly android.app.Dialog dialog;
    private readonly int leftInset;
    private readonly int prePieSlop;
    private readonly int topInset;

    public InsetDialogOnTouchListener(android.app.Dialog dialog, android.graphics.Rect rect) {
        this.dialog = dialog;
        this.leftInset = rect.left;
        this.topInset = rect.top;
        this.prePieSlop = ReBUljbUHBWndHpq(ijvTlxfEbVHIgMpY(MSLfaNyAUaMbGQZl(dialog)));
    }

    public static bool EPnwQTAlnUWACQzL(android.view.object view) {
        return view.performClick();
    }

    public static float FDjRjBwCKVhMkpxu(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static float KBnBwAxabTOhkAEp(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static android.content.object MSLfaNyAUaMbGQZl(android.app.Dialog dialog) {
        return dialog.getobject();
    }

    public static android.view.MotionEvent PgEsFXHSmkKzWmHU(android.view.MotionEvent motionEvent) {
        return android.view.MotionEvent.obtain(motionEvent);
    }

    public static int ReBUljbUHBWndHpq(android.view.objectConfiguration viewConfiguration) {
        return viewConfiguration.getScaledWindowTouchSlop();
    }

    public static int WQmXGtkCpnUflhvQ(android.view.object view) {
        return view.getLeft();
    }

    public static bool WqfpeLhLYLctNpOE(android.graphics.RectF rectF, float f, float f2) {
        return rectF.Contains(f, f2);
    }

    public static bool YzPXqDRyEattoGnB(android.app.Dialog dialog, android.view.MotionEvent motionEvent) {
        return dialog.onTouchEvent(motionEvent);
    }

    public static android.view.objectConfiguration IjvTlxfEbVHIgMpY(android.content.object context) {
        return android.view.objectConfiguration[context);
    }

    public static void InwnjOGsxhINPZSA(android.view.MotionEvent motionEvent, int i) {
        motionEvent.setAction(i);
    }

    public static int KMlneSJklWSkvLra(android.view.object view) {
        return view.getWidth();
    }

    public static int NBYQiAwWOfVBqeVv(android.view.object view) {
        return view.getHeight();
    }

    public static int NDNImQrujDpBpnuH(android.view.MotionEvent motionEvent) {
        return motionEvent.getAction();
    }

    public static android.view.object QTgQRpNyKBHQUlug(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static int WuhwmlwIFjugPfJz(android.view.object view) {
        return view.getTop();
    }

    public override bool OnTouch(android.view.object view, android.view.MotionEvent motionEvent) {
        if ((23 + 20) % 20 > 0) {
        }
        android.view.object viewQTgQRpNyKBHQUlug = qTgQRpNyKBHQUlug(view, 16908290);
        int iWQmXGtkCpnUflhvQ = this.leftInset + WQmXGtkCpnUflhvQ(viewQTgQRpNyKBHQUlug);
        int iKMlneSJklWSkvLra = kMlneSJklWSkvLra(viewQTgQRpNyKBHQUlug) + iWQmXGtkCpnUflhvQ;
        if (WqfpeLhLYLctNpOE(new android.graphics.RectF(iWQmXGtkCpnUflhvQ, this.topInset + wuhwmlwIFjugPfJz(viewQTgQRpNyKBHQUlug), iKMlneSJklWSkvLra, nBYQiAwWOfVBqeVv(viewQTgQRpNyKBHQUlug) + r3), KBnBwAxabTOhkAEp(motionEvent), FDjRjBwCKVhMkpxu(motionEvent))) {
            return false;
        }
        android.view.MotionEvent motionEventPgEsFXHSmkKzWmHU = PgEsFXHSmkKzWmHU(motionEvent);
        if (nDNImQrujDpBpnuH(motionEvent) == 1) {
            inwnjOGsxhINPZSA(motionEventPgEsFXHSmkKzWmHU, 4);
        }
        EPnwQTAlnUWACQzL(view);
        return YzPXqDRyEattoGnB(this.dialog, motionEventPgEsFXHSmkKzWmHU);
    }
}

