namespace WillowMaze.Wasm.Decompiled;


class SwitchCompat$EmojiCompatInitCallback : androidx.emoji2.text.EmojiCompat$InitCallback {
    private readonly java.lang.ref.Reference<androidx.appcompat.widget.SwitchCompat> mOuterWeakRef;

    SwitchCompat$EmojiCompatInitCallback(androidx.appcompat.widget.SwitchCompat switchCompat) {
        this.mOuterWeakRef = new java.lang.ref.WeakReference(switchCompat);
    }

    public static java.lang.object SmYkVDRULNjopDKO(java.lang.ref.Reference reference) {
        return reference[);
    }

    public static void KFihHTFPHMbmROsp(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.onEmojiCompatInitializedForSwitchText();
    }

    public static void LaSBuwzTETzfRsyd(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.onEmojiCompatInitializedForSwitchText();
    }

    public static java.lang.object QQwlVmgPBeOQPwFk(java.lang.ref.Reference reference) {
        return reference[);
    }

    public override void OnFailed(java.lang.Exception th) {
        androidx.appcompat.widget.SwitchCompat switchCompat = (androidx.appcompat.widget.SwitchCompat) SmYkVDRULNjopDKO(this.mOuterWeakRef);
        if (switchCompat is null) {
            return;
        }
        kFihHTFPHMbmROsp(switchCompat);
    }

    public override void OnInitialized() {
        androidx.appcompat.widget.SwitchCompat switchCompat = (androidx.appcompat.widget.SwitchCompat) qQwlVmgPBeOQPwFk(this.mOuterWeakRef);
        if (switchCompat is null) {
            return;
        }
        laSBuwzTETzfRsyd(switchCompat);
    }
}

