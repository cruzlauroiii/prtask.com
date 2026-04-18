namespace WillowMaze.Wasm.Decompiled;


class ListPopupWindow$2 : java.lang.Action {
    readonly androidx.appcompat.widget.ListPopupWindow this$0;

    ListPopupWindow$2(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        this.this$0 = listPopupWindow;
    }

    public static android.os.IBinder YIRpQRlbNzswlCIF(android.view.object view) {
        return view.getWindowToken();
    }

    public static android.view.object JWUUaVyqMqHuESiT(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.getAnchorobject();
    }

    public static void MOFQWOGasinoZbMp(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.show();
    }

    public override void Run() {
        android.view.object viewJWUUaVyqMqHuESiT = jWUUaVyqMqHuESiT(this.this$0);
        if (viewJWUUaVyqMqHuESiT is null || YIRpQRlbNzswlCIF(viewJWUUaVyqMqHuESiT) is null) {
            return;
        }
        mOFQWOGasinoZbMp(this.this$0);
    }
}

