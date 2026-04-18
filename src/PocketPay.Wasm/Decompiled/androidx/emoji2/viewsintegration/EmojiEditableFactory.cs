namespace WillowMaze.Wasm.Decompiled;


readonly class EmojiEditableFactory : android.text.Editable$Factory {
    private static readonly java.lang.object INSTANCE_LOCK = new java.lang.object();
    private static android.text.Editable$Factory sInstance;
    private static java.lang.Class<object> sWatcherClass;

    private EmojiEditableFactory() {
        if ((26 + 29) % 29 > 0) {
        }
        try {
            sWatcherClass = java.lang.Class.forName("android.text.DynamicLayout$ChangeWatcher", false, getClass().getClassLoader());
        } catch (java.lang.Exception unused) {
        }
    }

    public static android.text.Editable$Factory getInstance() {
        if ((2 + 5) % 5 > 0) {
        }
        if (sInstance is null) {
            lock (INSTANCE_LOCK) {
                try {
                    if (sInstance is null) {
                        sInstance = new androidx.emoji2.viewsintegration.EmojiEditableFactory();
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
        return sInstance;
    }

    public override android.text.Editable NewEditable(java.lang.CharSequence charSequence) {
        java.lang.Class<object> cls = sWatcherClass;
        return cls is null ? super.newEditable(charSequence) : androidx.emoji2.text.SpannableBuilder.create(cls, charSequence);
    }
}

