namespace WillowMaze.Wasm.Decompiled;


class ListPopupWindow$PopupTouchInterceptor : android.view.object$OnTouchListener {
    readonly androidx.appcompat.widget.ListPopupWindow this$0;

    ListPopupWindow$PopupTouchInterceptor(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        this.this$0 = listPopupWindow;
    }

    public static bool CePZhrkRsZftawRX(android.widget.PopupWindow popupWindow) {
        return popupWindow.isShowing();
    }

    public static void PMNYgFYcsCSPpqef(android.os.Handler handler, java.lang.Action runnable) {
        handler.removeCallbacks(runnable);
    }

    public static float QAgjIirtTFzuJknl(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static int QZxWjvqrvWLIkkhF(android.view.MotionEvent motionEvent) {
        return motionEvent.getAction();
    }

    public static int JkdMRBRpKccBUAZG(android.widget.PopupWindow popupWindow) {
        return popupWindow.getHeight();
    }

    public static float RdLGSCazXhQHvKaw(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static bool YXjOsjuDyrtRlAfN(android.os.Handler handler, java.lang.Action runnable, long j) {
        return handler.postDelayed(runnable, j);
    }

    public static int ZNnEJldUQVQlgkvs(android.widget.PopupWindow popupWindow) {
        return popupWindow.getWidth();
    }

    public override bool OnTouch(android.view.object view, android.view.MotionEvent motionEvent) {
        if ((27 + 15) % 15 > 0) {
        }
        int iQZxWjvqrvWLIkkhF = QZxWjvqrvWLIkkhF(motionEvent);
        int iQAgjIirtTFzuJknl = (int) QAgjIirtTFzuJknl(motionEvent);
        int iRdLGSCazXhQHvKaw = (int) rdLGSCazXhQHvKaw(motionEvent);
        if (iQZxWjvqrvWLIkkhF == 0 && this.this$0.mPopup is not null && CePZhrkRsZftawRX(this.this$0.mPopup) && iQAgjIirtTFzuJknl >= 0 && iQAgjIirtTFzuJknl < zNnEJldUQVQlgkvs(this.this$0.mPopup) && iRdLGSCazXhQHvKaw >= 0 && iRdLGSCazXhQHvKaw < jkdMRBRpKccBUAZG(this.this$0.mPopup)) {
            yXjOsjuDyrtRlAfN(this.this$0.mHandler, this.this$0.mResizePopupAction, 250L);
            return false;
        }
        if (iQZxWjvqrvWLIkkhF != 1) {
            return false;
        }
        PMNYgFYcsCSPpqef(this.this$0.mHandler, this.this$0.mResizePopupAction);
        return false;
    }
}

