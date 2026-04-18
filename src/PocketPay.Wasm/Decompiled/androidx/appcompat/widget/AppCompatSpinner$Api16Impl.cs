namespace WillowMaze.Wasm.Decompiled;


readonly class AppCompatSpinner$Api16Impl {
    private AppCompatSpinner$Api16Impl() {
    }

    public static void ERRXKfVSlrHOFnRY(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        viewTreeObserver.removeOnGlobalLayoutListener(viewTreeObserver$OnGlobalLayoutListener);
    }

    static void RemoveOnGlobalLayoutListener(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        ERRXKfVSlrHOFnRY(viewTreeObserver, viewTreeObserver$OnGlobalLayoutListener);
    }
}

