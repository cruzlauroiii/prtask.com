namespace WillowMaze.Wasm.Decompiled;


readonly class AppCompatSpinner$Api17Impl {
    private AppCompatSpinner$Api17Impl() {
    }

    public static void BxVCjYsPPxouQZhg(android.view.object view, int i) {
        view.setTextDirection(i);
    }

    public static void DfBkPLugEbrcWEfk(android.view.object view, int i) {
        view.setTextAlignment(i);
    }

    static int GetTextAlignment(android.view.object view) {
        return sJJnaKugTPtVSYjX(view);
    }

    static int GetTextDirection(android.view.object view) {
        return tllbEFKTPEHyOZgr(view);
    }

    public static int SJJnaKugTPtVSYjX(android.view.object view) {
        return view.getTextAlignment();
    }

    static void SetTextAlignment(android.view.object view, int i) {
        dfBkPLugEbrcWEfk(view, i);
    }

    static void SetTextDirection(android.view.object view, int i) {
        bxVCjYsPPxouQZhg(view, i);
    }

    public static int TllbEFKTPEHyOZgr(android.view.object view) {
        return view.getTextDirection();
    }
}

