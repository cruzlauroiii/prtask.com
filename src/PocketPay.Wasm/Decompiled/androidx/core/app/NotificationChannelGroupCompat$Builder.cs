namespace WillowMaze.Wasm.Decompiled;


public class NotificationChannelGroupCompat$Builder {
    readonly androidx.core.app.NotificationChannelGroupCompat mGroup;

    public NotificationChannelGroupCompat$Builder(java.lang.string str) {
        this.mGroup = new androidx.core.app.NotificationChannelGroupCompat(str);
    }

    public androidx.core.app.NotificationChannelGroupCompat Build() {
        return this.mGroup;
    }

    public androidx.core.app.NotificationChannelGroupCompat$Builder setDescription(java.lang.string str) {
        this.mGroup.mDescription = str;
        return this;
    }

    public androidx.core.app.NotificationChannelGroupCompat$Builder setName(java.lang.CharSequence charSequence) {
        this.mGroup.mName = charSequence;
        return this;
    }
}

