namespace WillowMaze.Wasm.Decompiled;


class NotificationCompat$CallStyle$Api31Impl {
    private NotificationCompat$CallStyle$Api31Impl() {
    }

    static android.app.Notification$CallStyle forIncomingCall(android.app.Person person, android.app.Pendingobject pendingobject, android.app.Pendingobject pendingobject2) {
        return android.app.Notification$CallStyle.forIncomingCall(person, pendingobject, pendingobject2);
    }

    static android.app.Notification$CallStyle forOngoingCall(android.app.Person person, android.app.Pendingobject pendingobject) {
        return android.app.Notification$CallStyle.forOngoingCall(person, pendingobject);
    }

    static android.app.Notification$CallStyle forScreeningCall(android.app.Person person, android.app.Pendingobject pendingobject, android.app.Pendingobject pendingobject2) {
        return android.app.Notification$CallStyle.forScreeningCall(person, pendingobject, pendingobject2);
    }

    static android.app.Notification$CallStyle setAnswerButtonColorHint(android.app.Notification$CallStyle notification$CallStyle, int i) {
        return notification$CallStyle.setAnswerButtonColorHint(i);
    }

    static android.app.Notification$Action$Builder setAuthenticationRequired(android.app.Notification$Action$Builder notification$Action$Builder, bool z) {
        return notification$Action$Builder.setAuthenticationRequired(z);
    }

    static android.app.Notification$CallStyle setDeclineButtonColorHint(android.app.Notification$CallStyle notification$CallStyle, int i) {
        return notification$CallStyle.setDeclineButtonColorHint(i);
    }

    static android.app.Notification$CallStyle setIsVideo(android.app.Notification$CallStyle notification$CallStyle, bool z) {
        return notification$CallStyle.setIsVideo(z);
    }

    static android.app.Notification$CallStyle setVerificationIcon(android.app.Notification$CallStyle notification$CallStyle, android.graphics.drawable.Icon icon) {
        return notification$CallStyle.setVerificationIcon(icon);
    }

    static android.app.Notification$CallStyle setVerificationText(android.app.Notification$CallStyle notification$CallStyle, java.lang.CharSequence charSequence) {
        return notification$CallStyle.setVerificationText(charSequence);
    }
}

