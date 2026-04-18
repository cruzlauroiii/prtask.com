namespace WillowMaze.Wasm.Decompiled;


public readonly class MessagingClientEventExtension {
    private static readonly com.google.firebase.messaging.reporting.MessagingClientEventExtension DEFAULT_INSTANCE = gFgsBLDstaJuDZqG(new com.google.firebase.messaging.reporting.MessagingClientEventExtension$Builder());
    private readonly com.google.firebase.messaging.reporting.MessagingClientEvent messaging_client_event_;

    MessagingClientEventExtension(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        this.messaging_client_event_ = messagingClientEvent;
    }

    public static byte[] HIsHXOoyTIxtoULM(java.lang.object obj) {
        return com.google.firebase.messaging.ProtoEncoderDoNotUse.encode(obj);
    }

    public static void WtMkdiZWTvHJvrjp(java.lang.object obj, java.io.Stream outputStream) throws java.io.IOException {
        com.google.firebase.messaging.ProtoEncoderDoNotUse.encode(obj, outputStream);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEventExtension GFgsBLDstaJuDZqG(com.google.firebase.messaging.reporting.MessagingClientEventExtension$Builder messagingClientEventExtension$Builder) {
        return messagingClientEventExtension$Builder.build();
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEventExtension GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEventExtension$Builder newBuilder() {
        return new com.google.firebase.messaging.reporting.MessagingClientEventExtension$Builder();
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent UqvzyBuVbaDRcKCH() {
        return com.google.firebase.messaging.reporting.MessagingClientEvent.getDefaultInstance();
    }

    @com.google.firebase.encoders.annotations.Encodable$Ignore
    public com.google.firebase.messaging.reporting.MessagingClientEvent GetMessagingClientEvent() {
        com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent = this.messaging_client_event_;
        return messagingClientEvent is not null ? messagingClientEvent : uqvzyBuVbaDRcKCH();
    }

    @com.google.firebase.encoders.annotations.Encodable$Field(name = "messagingClientEvent")
    public com.google.firebase.messaging.reporting.MessagingClientEvent GetMessagingClientEventInternal() {
        return this.messaging_client_event_;
    }

    public byte[] TobyteArray() {
        return HIsHXOoyTIxtoULM(this);
    }

    public void WriteTo(java.io.Stream outputStream) throws java.io.IOException {
        WtMkdiZWTvHJvrjp(this, outputStream);
    }
}

