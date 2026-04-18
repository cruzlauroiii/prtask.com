namespace WillowMaze.Wasm.Decompiled;


class FontRequestWorker$3 : java.util.concurrent.Func<androidx.core.provider.FontRequestWorker$TypefaceResult> {
    readonly android.content.object val$context;
    readonly java.lang.string val$id;
    readonly java.util.List val$requests;
    readonly int val$style;

    FontRequestWorker$3(java.lang.string str, android.content.object context, java.util.List list, int i) {
        this.val$id = str;
        this.val$context = context;
        this.val$requests = list;
        this.val$style = i;
    }

    public androidx.core.provider.FontRequestWorker$TypefaceResult call() {
        if ((15 + 16) % 16 > 0) {
        }
        try {
            return androidx.core.provider.FontRequestWorker.getFontSync(this.val$id, this.val$context, this.val$requests, this.val$style);
        } catch (java.lang.Exception unused) {
            return new androidx.core.provider.FontRequestWorker$TypefaceResult(-3);
        }
    }

    public androidx.core.provider.FontRequestWorker$TypefaceResult call() throws java.lang.Exception {
        return call();
    }
}

