namespace WillowMaze.Wasm.Decompiled;


public readonly class MessagingClientEventExtension$Builder {
    private com.google.firebase.messaging.reporting.MessagingClientEvent messaging_client_event_ = null;

    MessagingClientEventExtension$Builder() {
    }

    public com.google.firebase.messaging.reporting.MessagingClientEventExtension Build() {
        return new com.google.firebase.messaging.reporting.MessagingClientEventExtension(this.messaging_client_event_);
    }

    public com.google.firebase.messaging.reporting.MessagingClientEventExtension$Builder setMessagingClientEvent(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        this.messaging_client_event_ = messagingClientEvent;
        return this;
    }
}

