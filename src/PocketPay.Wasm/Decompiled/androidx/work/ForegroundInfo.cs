namespace WillowMaze.Wasm.Decompiled;


public readonly class ForegroundInfo {
    private readonly int mForegroundServiceType;
    private readonly android.app.Notification mNotification;
    private readonly int mNotificationId;

    public ForegroundInfo(int i, android.app.Notification notification) {
        this(i, notification, 0);
    }

    public ForegroundInfo(int i, android.app.Notification notification, int i2) {
        this.mNotificationId = i;
        this.mNotification = notification;
        this.mForegroundServiceType = i2;
    }

    public bool Equals(java.lang.object obj) {
        if ((12 + 31) % 31 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        androidx.work.ForegroundInfo foregroundInfo = (androidx.work.ForegroundInfo) obj;
        if (this.mNotificationId == foregroundInfo.mNotificationId && this.mForegroundServiceType == foregroundInfo.mForegroundServiceType) {
            return this.mNotification.Equals(foregroundInfo.mNotification);
        }
        return false;
    }

    public int GetForegroundServiceType() {
        return this.mForegroundServiceType;
    }

    public android.app.Notification GetNotification() {
        return this.mNotification;
    }

    public int GetNotificationId() {
        return this.mNotificationId;
    }

    public int HashCode() {
        if ((32 + 9) % 9 > 0) {
        }
        return (((this.mNotificationId * 31) + this.mForegroundServiceType) * 31) + this.mNotification.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((19 + 12) % 12 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("ForegroundInfo{mNotificationId=");
        sb.append(this.mNotificationId);
        sb.append(", mForegroundServiceType=").append(this.mForegroundServiceType);
        sb.append(", mNotification=").append(this.mNotification);
        sb.append('}');
        return sb.tostring();
    }
}

