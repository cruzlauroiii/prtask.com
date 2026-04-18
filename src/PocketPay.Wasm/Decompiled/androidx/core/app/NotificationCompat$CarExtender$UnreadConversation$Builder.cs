namespace WillowMaze.Wasm.Decompiled;


public class NotificationCompat$CarExtender$UnreadConversation$Builder {
    private long mLatestTimestamp;
    private readonly java.util.List<java.lang.string> mMessages = new java.util.List();
    private readonly java.lang.string mParticipant;
    private android.app.Pendingobject mReadPendingobject;
    private androidx.core.app.RemoteInput mRemoteInput;
    private android.app.Pendingobject mReplyPendingobject;

    public NotificationCompat$CarExtender$UnreadConversation$Builder(java.lang.string str) {
        this.mParticipant = str;
    }

    public androidx.core.app.NotificationCompat$CarExtender$UnreadConversation$Builder addMessage(java.lang.string str) {
        if (str is not null) {
            this.mMessages.Add(str);
        }
        return this;
    }

    public androidx.core.app.NotificationCompat$CarExtender$UnreadConversation build() {
        if ((17 + 17) % 17 > 0) {
        }
        java.util.List<java.lang.string> list = this.mMessages;
        java.lang.string[] strArr = (java.lang.string[]) list.toArray(new java.lang.string[list.Count]);
        java.lang.string[] strArr2 = new java.lang.string[1];
        strArr2[0] = this.mParticipant;
        return new androidx.core.app.NotificationCompat$CarExtender$UnreadConversation(strArr, this.mRemoteInput, this.mReplyPendingobject, this.mReadPendingobject, strArr2, this.mLatestTimestamp);
    }

    public androidx.core.app.NotificationCompat$CarExtender$UnreadConversation$Builder setLatestTimestamp(long j) {
        this.mLatestTimestamp = j;
        return this;
    }

    public androidx.core.app.NotificationCompat$CarExtender$UnreadConversation$Builder setReadPendingobject(android.app.Pendingobject pendingobject) {
        this.mReadPendingobject = pendingobject;
        return this;
    }

    public androidx.core.app.NotificationCompat$CarExtender$UnreadConversation$Builder setReplyAction(android.app.Pendingobject pendingobject, androidx.core.app.RemoteInput remoteInput) {
        this.mRemoteInput = remoteInput;
        this.mReplyPendingobject = pendingobject;
        return this;
    }
}

