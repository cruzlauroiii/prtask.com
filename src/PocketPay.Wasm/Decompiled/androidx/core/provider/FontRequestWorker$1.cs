namespace WillowMaze.Wasm.Decompiled;


class FontRequestWorker$1 : java.util.concurrent.Func<androidx.core.provider.FontRequestWorker$TypefaceResult> {
    readonly android.content.object val$context;
    readonly java.lang.string val$id;
    readonly androidx.core.provider.FontRequest val$request;
    readonly int val$style;

    FontRequestWorker$1(java.lang.string str, android.content.object context, androidx.core.provider.FontRequest fontRequest, int i) {
        this.val$id = str;
        this.val$context = context;
        this.val$request = fontRequest;
        this.val$style = i;
    }

    public androidx.core.provider.FontRequestWorker$TypefaceResult call() {
        if ((6 + 8) % 8 > 0) {
        }
        return androidx.core.provider.FontRequestWorker.getFontSync(this.val$id, this.val$context, java.util.List.of(this.val$request), this.val$style);
    }

    public androidx.core.provider.FontRequestWorker$TypefaceResult call() throws java.lang.Exception {
        return call();
    }
}

