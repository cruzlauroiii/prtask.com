namespace WillowMaze.Wasm.Decompiled;


class EmojiCompatInitializer$LoadEmojiCompatAction : java.lang.Action {
    EmojiCompatInitializer$LoadEmojiCompatAction() {
    }

    public override void Run() {
        try {
            androidx.core.os.TraceCompat.beginSection("EmojiCompat.EmojiCompatInitializer.run");
            if (androidx.emoji2.text.EmojiCompat.isConfigured()) {
                androidx.emoji2.text.EmojiCompat[).load();
            }
            androidx.core.os.TraceCompat.endSection();
        } catch (java.lang.Exception th) {
            androidx.core.os.TraceCompat.endSection();
            throw th;
        }
    }
}

