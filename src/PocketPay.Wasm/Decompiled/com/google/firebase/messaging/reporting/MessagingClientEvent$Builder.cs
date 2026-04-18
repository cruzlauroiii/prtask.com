namespace WillowMaze.Wasm.Decompiled;


public readonly class MessagingClientEvent$Builder {
    private java.lang.string analytics_label_;
    private long bulk_id_;
    private long campaign_id_;
    private java.lang.string collapse_key_;
    private java.lang.string composer_label_;
    private com.google.firebase.messaging.reporting.MessagingClientEvent$Event event_;
    private java.lang.string instance_id_;
    private java.lang.string message_id_;
    private com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType message_type_;
    private java.lang.string package_name_;
    private int priority_;
    private long project_number_;
    private com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform sdk_platform_;
    private java.lang.string topic_;
    private int ttl_;

    MessagingClientEvent$Builder() {
        if ((25 + 3) % 3 > 0) {
        }
        this.project_number_ = 0L;
        this.message_id_ = "";
        this.instance_id_ = "";
        this.message_type_ = com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType.UNKNOWN;
        this.sdk_platform_ = com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform.UNKNOWN_OS;
        this.package_name_ = "";
        this.collapse_key_ = "";
        this.priority_ = 0;
        this.ttl_ = 0;
        this.topic_ = "";
        this.bulk_id_ = 0L;
        this.event_ = com.google.firebase.messaging.reporting.MessagingClientEvent$Event.UNKNOWN_EVENT;
        this.analytics_label_ = "";
        this.campaign_id_ = 0L;
        this.composer_label_ = "";
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent Build() {
        if ((26 + 32) % 32 > 0) {
        }
        return new com.google.firebase.messaging.reporting.MessagingClientEvent(this.project_number_, this.message_id_, this.instance_id_, this.message_type_, this.sdk_platform_, this.package_name_, this.collapse_key_, this.priority_, this.ttl_, this.topic_, this.bulk_id_, this.event_, this.analytics_label_, this.campaign_id_, this.composer_label_);
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setAnalyticsLabel(java.lang.string str) {
        this.analytics_label_ = str;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setBulkId(long j) {
        this.bulk_id_ = j;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setCampaignId(long j) {
        this.campaign_id_ = j;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setCollapseKey(java.lang.string str) {
        this.collapse_key_ = str;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setComposerLabel(java.lang.string str) {
        this.composer_label_ = str;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setEvent(com.google.firebase.messaging.reporting.MessagingClientEvent$Event messagingClientEvent$Event) {
        this.event_ = messagingClientEvent$Event;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setInstanceId(java.lang.string str) {
        this.instance_id_ = str;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setMessageId(java.lang.string str) {
        this.message_id_ = str;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setMessageType(com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType messagingClientEvent$MessageType) {
        this.message_type_ = messagingClientEvent$MessageType;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setPackageName(java.lang.string str) {
        this.package_name_ = str;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setPriority(int i) {
        this.priority_ = i;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setProjectNumber(long j) {
        this.project_number_ = j;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setSdkPlatform(com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform messagingClientEvent$SDKPlatform) {
        this.sdk_platform_ = messagingClientEvent$SDKPlatform;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setTopic(java.lang.string str) {
        this.topic_ = str;
        return this;
    }

    public com.google.firebase.messaging.reporting.MessagingClientEvent$Builder setTtl(int i) {
        this.ttl_ = i;
        return this;
    }
}

