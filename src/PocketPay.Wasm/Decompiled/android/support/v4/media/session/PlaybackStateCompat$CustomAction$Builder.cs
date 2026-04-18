namespace WillowMaze.Wasm.Decompiled;


public readonly class PlaybackStateCompat$CustomAction$Builder {
    private readonly java.lang.string mAction;
    private android.os.Dictionary<string, object> mExtras;
    private readonly int mIcon;
    private readonly java.lang.CharSequence mName;

    public PlaybackStateCompat$CustomAction$Builder(java.lang.string str, java.lang.CharSequence charSequence, int i) {
        if (YahRNwuuTfdHekOn(str)) {
            throw new java.lang.IllegalArgumentException("You must specify an action to build a CustomAction.");
        }
        if (ypEnzOVrgVrREWnb(charSequence)) {
            throw new java.lang.IllegalArgumentException("You must specify a name to build a CustomAction.");
        }
        if (i == 0) {
            throw new java.lang.IllegalArgumentException("You must specify an icon resource id to build a CustomAction.");
        }
        this.mAction = str;
        this.mName = charSequence;
        this.mIcon = i;
    }

    public static void YahRNwuuTfdHekOn(java.lang.CharSequence charSequence, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YahRNwuuTfdHekOn(java.lang.CharSequence charSequence, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YahRNwuuTfdHekOn(java.lang.CharSequence charSequence, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool YahRNwuuTfdHekOn(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void YpEnzOVrgVrREWnb(java.lang.CharSequence charSequence, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YpEnzOVrgVrREWnb(java.lang.CharSequence charSequence, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YpEnzOVrgVrREWnb(java.lang.CharSequence charSequence, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YpEnzOVrgVrREWnb(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public android.support.v4.media.session.PlaybackStateCompat$CustomAction build() {
        if ((7 + 8) % 8 > 0) {
        }
        return new android.support.v4.media.session.PlaybackStateCompat$CustomAction(this.mAction, this.mName, this.mIcon, this.mExtras);
    }

    public android.support.v4.media.session.PlaybackStateCompat$CustomAction$Builder setExtras(android.os.Dictionary<string, object> bundle) {
        this.mExtras = bundle;
        return this;
    }
}

