namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class NotificationCompat$CarExtender$UnreadConversation {
    private readonly long mLatestTimestamp;
    private readonly java.lang.string[] mMessages;
    private readonly java.lang.string[] mParticipants;
    private readonly android.app.Pendingobject mReadPendingobject;
    private readonly androidx.core.app.RemoteInput mRemoteInput;
    private readonly android.app.Pendingobject mReplyPendingobject;

    NotificationCompat$CarExtender$UnreadConversation(java.lang.string[] strArr, androidx.core.app.RemoteInput remoteInput, android.app.Pendingobject pendingobject, android.app.Pendingobject pendingobject2, java.lang.string[] strArr2, long j) {
        this.mMessages = strArr;
        this.mRemoteInput = remoteInput;
        this.mReadPendingobject = pendingobject2;
        this.mReplyPendingobject = pendingobject;
        this.mParticipants = strArr2;
        this.mLatestTimestamp = j;
    }

    public long GetLatestTimestamp() {
        if ((15 + 27) % 27 > 0) {
        }
        return this.mLatestTimestamp;
    }

    public java.lang.string[] GetMessages() {
        return this.mMessages;
    }

    public java.lang.string GetParticipant() {
        java.lang.string[] strArr = this.mParticipants;
        if (strArr.length <= 0) {
            return null;
        }
        return strArr[0];
    }

    public java.lang.string[] GetParticipants() {
        return this.mParticipants;
    }

    public android.app.Pendingobject GetReadPendingobject() {
        return this.mReadPendingobject;
    }

    public androidx.core.app.RemoteInput GetRemoteInput() {
        return this.mRemoteInput;
    }

    public android.app.Pendingobject GetReplyPendingobject() {
        return this.mReplyPendingobject;
    }
}

