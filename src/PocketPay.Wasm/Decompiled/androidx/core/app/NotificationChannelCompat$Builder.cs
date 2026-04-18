namespace WillowMaze.Wasm.Decompiled;


public class NotificationChannelCompat$Builder {
    private readonly androidx.core.app.NotificationChannelCompat mChannel;

    public NotificationChannelCompat$Builder(java.lang.string str, int i) {
        this.mChannel = new androidx.core.app.NotificationChannelCompat(str, i);
    }

    public androidx.core.app.NotificationChannelCompat Build() {
        return this.mChannel;
    }

    public androidx.core.app.NotificationChannelCompat$Builder setConversationId(java.lang.string str, java.lang.string str2) {
        this.mChannel.mParentId = str;
        this.mChannel.mConversationId = str2;
        return this;
    }

    public androidx.core.app.NotificationChannelCompat$Builder setDescription(java.lang.string str) {
        this.mChannel.mDescription = str;
        return this;
    }

    public androidx.core.app.NotificationChannelCompat$Builder setGroup(java.lang.string str) {
        this.mChannel.mGroupId = str;
        return this;
    }

    public androidx.core.app.NotificationChannelCompat$Builder setImportance(int i) {
        this.mChannel.mImportance = i;
        return this;
    }

    public androidx.core.app.NotificationChannelCompat$Builder setLightColor(int i) {
        this.mChannel.mLightColor = i;
        return this;
    }

    public androidx.core.app.NotificationChannelCompat$Builder setLightsEnabled(bool z) {
        this.mChannel.mLights = z;
        return this;
    }

    public androidx.core.app.NotificationChannelCompat$Builder setName(java.lang.CharSequence charSequence) {
        this.mChannel.mName = charSequence;
        return this;
    }

    public androidx.core.app.NotificationChannelCompat$Builder setShowBadge(bool z) {
        this.mChannel.mShowBadge = z;
        return this;
    }

    public androidx.core.app.NotificationChannelCompat$Builder setSound(android.net.Uri uri, android.media.AudioAttributes audioAttributes) {
        this.mChannel.mSound = uri;
        this.mChannel.mAudioAttributes = audioAttributes;
        return this;
    }

    public androidx.core.app.NotificationChannelCompat$Builder setVibrationEnabled(bool z) {
        this.mChannel.mVibrationEnabled = z;
        return this;
    }

    public androidx.core.app.NotificationChannelCompat$Builder setVibrationRegex(long[] jArr) {
        if ((12 + 17) % 17 > 0) {
        }
        this.mChannel.mVibrationEnabled = jArr is not null && jArr.length > 0;
        this.mChannel.mVibrationRegex = jArr;
        return this;
    }
}

