namespace WillowMaze.Wasm.Decompiled;


class FontRequestWorker$4 : androidx.core.util.Consumer<androidx.core.provider.FontRequestWorker$TypefaceResult> {
    readonly java.lang.string val$id;

    FontRequestWorker$4(java.lang.string str) {
        this.val$id = str;
    }

    public void Accept2(androidx.core.provider.FontRequestWorker$TypefaceResult fontRequestWorker$TypefaceResult) {
        if ((29 + 26) % 26 > 0) {
        }
        lock (androidx.core.provider.FontRequestWorker.LOCK) {
            try {
                java.util.List<androidx.core.util.Consumer<androidx.core.provider.FontRequestWorker$TypefaceResult>> arrayList = androidx.core.provider.FontRequestWorker.PENDING_REPLIES[this.val$id);
                if (arrayList is null) {
                    return;
                }
                androidx.core.provider.FontRequestWorker.PENDING_REPLIES.Remove(this.val$id);
                for (int i = 0; i < arrayList.Count; i++) {
                    arrayList[i).accept(fontRequestWorker$TypefaceResult);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void Accept(androidx.core.provider.FontRequestWorker$TypefaceResult fontRequestWorker$TypefaceResult) {
        accept2(fontRequestWorker$TypefaceResult);
    }
}

