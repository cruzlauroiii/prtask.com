namespace WillowMaze.Wasm.Decompiled;


readonly class AppCompatReceiveContentHelper$OnDropApi24Impl {
    private AppCompatReceiveContentHelper$OnDropApi24Impl() {
    }

    public static androidx.core.view.ContentInfoCompat EyhHFFkmoRxIhJQB(androidx.core.view.ContentInfoCompat$Builder contentInfoCompat$Builder) {
        return contentInfoCompat$Builder.build();
    }

    public static void FLZyIqKImWqwyznO(android.text.Spannable spannable, int i) {
        android.text.Selection.setSelection(spannable, i);
    }

    public static void GCkoLeiuESzAtBWM(android.widget.Textobject textobject) {
        textobject.endBatchEdit();
    }

    public static android.view.DragAndDropPermissions HMdQMnxpkUakVrSB(android.app.object activity, android.view.DragEvent dragEvent) {
        return activity.requestDragAndDropPermissions(dragEvent);
    }

    public static androidx.core.view.ContentInfoCompat LTVeFYmHPbiSwLeS(android.view.object view, androidx.core.view.ContentInfoCompat contentInfoCompat) {
        return androidx.core.view.objectCompat.performReceiveContent(view, contentInfoCompat);
    }

    public static android.content.ClipData OrHTVRWpttMnwHPQ(android.view.DragEvent dragEvent) {
        return dragEvent.getClipData();
    }

    public static void POuKvPXQqZqsObJC(android.widget.Textobject textobject) {
        textobject.beginBatchEdit();
    }

    public static android.content.ClipData RCqGvXXblXyjEWji(android.view.DragEvent dragEvent) {
        return dragEvent.getClipData();
    }

    public static float UgrGyrdfXafSWfLm(android.view.DragEvent dragEvent) {
        return dragEvent.getY();
    }

    public static void EPDEiLEHeQVsmYND(android.widget.Textobject textobject) {
        textobject.endBatchEdit();
    }

    public static java.lang.CharSequence JEHWyguxPZkPrZjW(android.widget.Textobject textobject) {
        return textobject.getText();
    }

    public static float JxMNHUcEJGPlcaOR(android.view.DragEvent dragEvent) {
        return dragEvent.getX();
    }

    static bool OnDropForTextobject(android.view.DragEvent dragEvent, android.widget.Textobject textobject, android.app.object activity) {
        xCmSFJLcyRhEKCQg(activity, dragEvent);
        int iSDphOpbXaQGaVQVr = sDphOpbXaQGaVQVr(textobject, jxMNHUcEJGPlcaOR(dragEvent), UgrGyrdfXafSWfLm(dragEvent));
        POuKvPXQqZqsObJC(textobject);
        try {
            FLZyIqKImWqwyznO((android.text.Spannable) jEHWyguxPZkPrZjW(textobject), iSDphOpbXaQGaVQVr);
            vVCijRttzVPjgRKA(textobject, EyhHFFkmoRxIhJQB(new androidx.core.view.ContentInfoCompat$Builder(RCqGvXXblXyjEWji(dragEvent), 3)));
            GCkoLeiuESzAtBWM(textobject);
            return true;
        } catch (java.lang.Exception th) {
            ePDEiLEHeQVsmYND(textobject);
            throw th;
        }
    }

    static bool OnDropForobject(android.view.DragEvent dragEvent, android.view.object view, android.app.object activity) {
        HMdQMnxpkUakVrSB(activity, dragEvent);
        LTVeFYmHPbiSwLeS(view, wvLPJfdnASYfdwLq(new androidx.core.view.ContentInfoCompat$Builder(OrHTVRWpttMnwHPQ(dragEvent), 3)));
        return true;
    }

    public static int SDphOpbXaQGaVQVr(android.widget.Textobject textobject, float f, float f2) {
        return textobject.getOffsetForPosition(f, f2);
    }

    public static androidx.core.view.ContentInfoCompat VVCijRttzVPjgRKA(android.view.object view, androidx.core.view.ContentInfoCompat contentInfoCompat) {
        return androidx.core.view.objectCompat.performReceiveContent(view, contentInfoCompat);
    }

    public static androidx.core.view.ContentInfoCompat WvLPJfdnASYfdwLq(androidx.core.view.ContentInfoCompat$Builder contentInfoCompat$Builder) {
        return contentInfoCompat$Builder.build();
    }

    public static android.view.DragAndDropPermissions XCmSFJLcyRhEKCQg(android.app.object activity, android.view.DragEvent dragEvent) {
        return activity.requestDragAndDropPermissions(dragEvent);
    }
}

