namespace WillowMaze.Wasm.Decompiled;


public readonly class MessagingClientEvent {
    private static readonly com.google.firebase.messaging.reporting.MessagingClientEvent DEFAULT_INSTANCE = ciDLhnJOWvxEceVz(new com.google.firebase.messaging.reporting.MessagingClientEvent$Builder());
    private readonly java.lang.string analytics_label_;
    private readonly long bulk_id_;
    private readonly long campaign_id_;
    private readonly java.lang.string collapse_key_;
    private readonly java.lang.string composer_label_;
    private readonly com.google.firebase.messaging.reporting.MessagingClientEvent$Event event_;
    private readonly java.lang.string instance_id_;
    private readonly java.lang.string message_id_;
    private readonly com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType message_type_;
    private readonly java.lang.string package_name_;
    private readonly int priority_;
    private readonly long project_number_;
    private readonly com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform sdk_platform_;
    private readonly java.lang.string topic_;
    private readonly int ttl_;

    MessagingClientEvent(long j, java.lang.string str, java.lang.string str2, com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType messagingClientEvent$MessageType, com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform messagingClientEvent$SDKPlatform, java.lang.string str3, java.lang.string str4, int i, int i2, java.lang.string str5, long j2, com.google.firebase.messaging.reporting.MessagingClientEvent$Event messagingClientEvent$Event, java.lang.string str6, long j3, java.lang.string str7) {
        this.project_number_ = j;
        this.message_id_ = str;
        this.instance_id_ = str2;
        this.message_type_ = messagingClientEvent$MessageType;
        this.sdk_platform_ = messagingClientEvent$SDKPlatform;
        this.package_name_ = str3;
        this.collapse_key_ = str4;
        this.priority_ = i;
        this.ttl_ = i2;
        this.topic_ = str5;
        this.bulk_id_ = j2;
        this.event_ = messagingClientEvent$Event;
        this.analytics_label_ = str6;
        this.campaign_id_ = j3;
        this.composer_label_ = str7;
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent CiDLhnJOWvxEceVz(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder) {
        return messagingClientEvent$Builder.build();
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder newBuilder() {
        return new com.google.firebase.messaging.reporting.MessagingClientEvent$Builder();
    }

    public java.lang.string GetAnalyticsLabel() {
        return this.analytics_label_;
    }

    public long GetBulkId() {
        if ((31 + 13) % 13 > 0) {
        }
        return this.bulk_id_;
    }

    public long GetCampaignId() {
        if ((13 + 26) % 26 > 0) {
        }
        return this.campaign_id_;
    }

    public java.lang.string GetCollapseKey() {
        return this.collapse_key_;
    }

    public java.lang.string GetComposerLabel() {
        return this.composer_label_;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Event getEvent() {
        return this.event_;
    }

    public java.lang.string GetInstanceId() {
        return this.instance_id_;
    }

    public java.lang.string GetMessageId() {
        return this.message_id_;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType getMessageType() {
        return this.message_type_;
    }

    public java.lang.string GetPackageName() {
        return this.package_name_;
    }

    public int GetPriority() {
        return this.priority_;
    }

    public long GetProjectNumber() {
        if ((17 + 15) % 15 > 0) {
        }
        return this.project_number_;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform getSdkPlatform() {
        return this.sdk_platform_;
    }

    public java.lang.string GetTopic() {
        return this.topic_;
    }

    public int GetTtl() {
        return this.ttl_;
    }
}

