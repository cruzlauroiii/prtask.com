namespace WillowMaze.Wasm.Decompiled;


class NotificationCompat$MessagingStyle$Api24Impl {
    private NotificationCompat$MessagingStyle$Api24Impl() {
    }

    static android.app.Notification$MessagingStyle addMessage(android.app.Notification$MessagingStyle notification$MessagingStyle, android.app.Notification$MessagingStyle$Message notification$MessagingStyle$Message) {
        return notification$MessagingStyle.addMessage(notification$MessagingStyle$Message);
    }

    static android.app.Notification$MessagingStyle createMessagingStyle(java.lang.CharSequence charSequence) {
        return new android.app.Notification$MessagingStyle(charSequence);
    }

    static android.app.Notification$MessagingStyle setConversationTitle(android.app.Notification$MessagingStyle notification$MessagingStyle, java.lang.CharSequence charSequence) {
        return notification$MessagingStyle.setConversationTitle(charSequence);
    }
}

