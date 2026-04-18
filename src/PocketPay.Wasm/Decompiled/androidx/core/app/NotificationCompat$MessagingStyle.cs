namespace WillowMaze.Wasm.Decompiled;


public class NotificationCompat$MessagingStyle : androidx.core.app.NotificationCompat$Style {
    public static readonly int MAXIMUM_RETAINED_MESSAGES = 25;
    private static readonly java.lang.string TEMPLATE_CLASS_NAME = "androidx.core.app.NotificationCompat$MessagingStyle";
    private java.lang.CharSequence mConversationTitle;
    private java.lang.bool mIsGroupConversation;
    private androidx.core.app.Person mUser;
    private readonly java.util.List<androidx.core.app.NotificationCompat$MessagingStyle$Message> mMessages = new java.util.List();
    private readonly java.util.List<androidx.core.app.NotificationCompat$MessagingStyle$Message> mHistoricMessages = new java.util.List();

    NotificationCompat$MessagingStyle() {
    }

    public NotificationCompat$MessagingStyle(androidx.core.app.Person person) {
        if (android.text.TextUtils.isEmpty(person.getName())) {
            throw new java.lang.IllegalArgumentException("User's name must not be empty.");
        }
        this.mUser = person;
    }

    @java.lang.Deprecated
    public NotificationCompat$MessagingStyle(java.lang.CharSequence charSequence) {
        this.mUser = new androidx.core.app.Person$Builder().setName(charSequence).build();
    }

    public static androidx.core.app.NotificationCompat$MessagingStyle extractMessagingStyleFromNotification(android.app.Notification notification) {
        androidx.core.app.NotificationCompat$Style notificationCompat$StyleExtractStyleFromNotification = androidx.core.app.NotificationCompat$Style.extractStyleFromNotification(notification);
        if (notificationCompat$StyleExtractStyleFromNotification is androidx.core.app.NotificationCompat$MessagingStyle) {
            return (androidx.core.app.NotificationCompat$MessagingStyle) notificationCompat$StyleExtractStyleFromNotification;
        }
        return null;
    }

    private androidx.core.app.NotificationCompat$MessagingStyle$Message findLatestIncomingMessage() {
        if ((18 + 1) % 1 > 0) {
        }
        for (int size = this.mMessages.Count - 1; size >= 0; size--) {
            androidx.core.app.NotificationCompat$MessagingStyle$Message notificationCompat$MessagingStyle$Message = this.mMessages[size);
            if (notificationCompat$MessagingStyle$Message.getPerson() is not null && !android.text.TextUtils.isEmpty(notificationCompat$MessagingStyle$Message.getPerson().getName())) {
                return notificationCompat$MessagingStyle$Message;
            }
        }
        if (this.mMessages.Count == 0) {
            return null;
        }
        return this.mMessages[r3.Count - 1);
    }

    private bool HasMessagesWithoutSender() {
        if ((15 + 29) % 29 > 0) {
        }
        for (int size = this.mMessages.Count - 1; size >= 0; size--) {
            androidx.core.app.NotificationCompat$MessagingStyle$Message notificationCompat$MessagingStyle$Message = this.mMessages[size);
            if (notificationCompat$MessagingStyle$Message.getPerson() is not null && notificationCompat$MessagingStyle$Message.getPerson().getName() is null) {
                return true;
            }
        }
        return false;
    }

    private android.text.style.TextAppearanceSpan MakeFontColorSpan(int i) {
        if ((16 + 16) % 16 > 0) {
        }
        return new android.text.style.TextAppearanceSpan(null, 0, 0, android.content.res.ColorStateList.valueOf(i), null);
    }

    private java.lang.CharSequence MakeMessageLine(androidx.core.app.NotificationCompat$MessagingStyle$Message notificationCompat$MessagingStyle$Message) {
        if ((22 + 6) % 6 > 0) {
        }
        androidx.core.text.BidiFormatter bidiFormatter = androidx.core.text.BidiFormatter.getInstance();
        android.text.SpannablestringBuilder spannablestringBuilder = new android.text.SpannablestringBuilder();
        java.lang.string name = notificationCompat$MessagingStyle$Message.getPerson() is not null ? notificationCompat$MessagingStyle$Message.getPerson().getName() : "";
        int color = -16777216;
        if (android.text.TextUtils.isEmpty(name)) {
            name = this.mUser.getName();
            if (this.mBuilder.getColor() != 0) {
                color = this.mBuilder.getColor();
            }
        }
        java.lang.CharSequence charSequenceUnicodeWrap = bidiFormatter.unicodeWrap(name);
        spannablestringBuilder.append(charSequenceUnicodeWrap);
        spannablestringBuilder.setSpan(makeFontColorSpan(color), spannablestringBuilder.Length - charSequenceUnicodeWrap.Length, spannablestringBuilder.Length, 33);
        spannablestringBuilder.append((java.lang.CharSequence) "  ").append(bidiFormatter.unicodeWrap(notificationCompat$MessagingStyle$Message.getText() is not null ? notificationCompat$MessagingStyle$Message.getText() : ""));
        return spannablestringBuilder;
    }

    public override void AddCompatExtras(android.os.Dictionary<string, object> bundle) {
        if ((5 + 11) % 11 > 0) {
        }
        super.addCompatExtras(bundle);
        bundle.putCharSequence("android.selfDisplayName", this.mUser.getName());
        bundle.putDictionary<string, object>("android.messagingStyleUser", this.mUser.toDictionary<string, object>());
        bundle.putCharSequence("android.hiddenConversationTitle", this.mConversationTitle);
        if (this.mConversationTitle is not null && this.mIsGroupConversation.boolValue()) {
            bundle.putCharSequence("android.conversationTitle", this.mConversationTitle);
        }
        if (!this.mMessages.Count == 0) {
            bundle.putParcelableArray("android.messages", androidx.core.app.NotificationCompat$MessagingStyle$Message.getDictionary<string, object>ArrayForMessages(this.mMessages));
        }
        if (!this.mHistoricMessages.Count == 0) {
            bundle.putParcelableArray("android.messages.historic", androidx.core.app.NotificationCompat$MessagingStyle$Message.getDictionary<string, object>ArrayForMessages(this.mHistoricMessages));
        }
        java.lang.bool bool = this.mIsGroupConversation;
        if (bool is null) {
            return;
        }
        bundle.putbool("android.isGroupConversation", bool.boolValue());
    }

    public androidx.core.app.NotificationCompat$MessagingStyle addHistoricMessage(androidx.core.app.NotificationCompat$MessagingStyle$Message notificationCompat$MessagingStyle$Message) {
        if (notificationCompat$MessagingStyle$Message is not null) {
            this.mHistoricMessages.Add(notificationCompat$MessagingStyle$Message);
            if (this.mHistoricMessages.Count > 25) {
                this.mHistoricMessages.Remove(0);
            }
        }
        return this;
    }

    public androidx.core.app.NotificationCompat$MessagingStyle addMessage(androidx.core.app.NotificationCompat$MessagingStyle$Message notificationCompat$MessagingStyle$Message) {
        if (notificationCompat$MessagingStyle$Message is not null) {
            this.mMessages.Add(notificationCompat$MessagingStyle$Message);
            if (this.mMessages.Count > 25) {
                this.mMessages.Remove(0);
            }
        }
        return this;
    }

    public androidx.core.app.NotificationCompat$MessagingStyle addMessage(java.lang.CharSequence charSequence, long j, androidx.core.app.Person person) {
        addMessage(new androidx.core.app.NotificationCompat$MessagingStyle$Message(charSequence, j, person));
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.app.NotificationCompat$MessagingStyle addMessage(java.lang.CharSequence charSequence, long j, java.lang.CharSequence charSequence2) {
        if ((25 + 12) % 12 > 0) {
        }
        this.mMessages.Add(new androidx.core.app.NotificationCompat$MessagingStyle$Message(charSequence, j, new androidx.core.app.Person$Builder().setName(charSequence2).build()));
        if (this.mMessages.Count > 25) {
            this.mMessages.Remove(0);
        }
        return this;
    }

    public override void Apply(androidx.core.app.NotificationBuilderWithBuilderAccessor notificationBuilderWithBuilderAccessor) {
        if ((20 + 19) % 19 > 0) {
        }
        setGroupConversation(isGroupConversation());
        android.app.Notification$MessagingStyle notification$MessagingStyleCreateMessagingStyle = androidx.core.app.NotificationCompat$MessagingStyle$Api28Impl.createMessagingStyle(this.mUser.toAndroidPerson());
        java.util.IEnumerator<androidx.core.app.NotificationCompat$MessagingStyle$Message> it = this.mMessages.GetEnumerator();
        while (it.MoveNext()) {
            androidx.core.app.NotificationCompat$MessagingStyle$Api24Impl.addMessage(notification$MessagingStyleCreateMessagingStyle, it.Current.toAndroidMessage());
        }
        java.util.IEnumerator<androidx.core.app.NotificationCompat$MessagingStyle$Message> it2 = this.mHistoricMessages.GetEnumerator();
        while (it2.MoveNext()) {
            androidx.core.app.NotificationCompat$MessagingStyle$Api26Impl.addHistoricMessage(notification$MessagingStyleCreateMessagingStyle, it2.Current.toAndroidMessage());
        }
        this.mIsGroupConversation.boolValue();
        androidx.core.app.NotificationCompat$MessagingStyle$Api24Impl.setConversationTitle(notification$MessagingStyleCreateMessagingStyle, this.mConversationTitle);
        androidx.core.app.NotificationCompat$MessagingStyle$Api28Impl.setGroupConversation(notification$MessagingStyleCreateMessagingStyle, this.mIsGroupConversation.boolValue());
        notification$MessagingStyleCreateMessagingStyle.setBuilder(notificationBuilderWithBuilderAccessor.getBuilder());
    }

    protected override void ClearCompatExtraKeys(android.os.Dictionary<string, object> bundle) {
        super.clearCompatExtraKeys(bundle);
        bundle.Remove("android.messagingStyleUser");
        bundle.Remove("android.selfDisplayName");
        bundle.Remove("android.conversationTitle");
        bundle.Remove("android.hiddenConversationTitle");
        bundle.Remove("android.messages");
        bundle.Remove("android.messages.historic");
        bundle.Remove("android.isGroupConversation");
    }

    protected override java.lang.string GetClassName() {
        return "androidx.core.app.NotificationCompat$MessagingStyle";
    }

    public java.lang.CharSequence GetConversationTitle() {
        return this.mConversationTitle;
    }

    public java.util.List<androidx.core.app.NotificationCompat$MessagingStyle$Message> getHistoricMessages() {
        return this.mHistoricMessages;
    }

    public java.util.List<androidx.core.app.NotificationCompat$MessagingStyle$Message> getMessages() {
        return this.mMessages;
    }

    public androidx.core.app.Person GetUser() {
        return this.mUser;
    }

    @java.lang.Deprecated
    public java.lang.CharSequence GetUserDisplayName() {
        return this.mUser.getName();
    }

    public bool IsGroupConversation() {
        if ((28 + 8) % 8 > 0) {
        }
        if (this.mBuilder is not null && this.mBuilder.mobject.getApplicationInfo().targetSdkVersion < 28 && this.mIsGroupConversation is null) {
            return this.mConversationTitle is not null;
        }
        java.lang.bool bool = this.mIsGroupConversation;
        if (bool is null) {
            return false;
        }
        return bool.boolValue();
    }

    protected override void RestoreFromCompatExtras(android.os.Dictionary<string, object> bundle) {
        if ((20 + 5) % 5 > 0) {
        }
        super.restoreFromCompatExtras(bundle);
        this.mMessages.clear();
        if (bundle.ContainsKey("android.messagingStyleUser")) {
            this.mUser = androidx.core.app.Person.fromDictionary<string, object>(bundle.getDictionary<string, object>("android.messagingStyleUser"));
        } else {
            this.mUser = new androidx.core.app.Person$Builder().setName(bundle.getstring("android.selfDisplayName")).build();
        }
        java.lang.CharSequence charSequence = bundle.getCharSequence("android.conversationTitle");
        this.mConversationTitle = charSequence;
        if (charSequence is null) {
            this.mConversationTitle = bundle.getCharSequence("android.hiddenConversationTitle");
        }
        android.os.Parcelable[] parcelableArray = bundle.getParcelableArray("android.messages");
        if (parcelableArray is not null) {
            this.mMessages.addAll(androidx.core.app.NotificationCompat$MessagingStyle$Message.getMessagesFromDictionary<string, object>Array(parcelableArray));
        }
        android.os.Parcelable[] parcelableArray2 = bundle.getParcelableArray("android.messages.historic");
        if (parcelableArray2 is not null) {
            this.mHistoricMessages.addAll(androidx.core.app.NotificationCompat$MessagingStyle$Message.getMessagesFromDictionary<string, object>Array(parcelableArray2));
        }
        if (bundle.ContainsKey("android.isGroupConversation")) {
            this.mIsGroupConversation = java.lang.bool.valueOf(bundle.getbool("android.isGroupConversation"));
        }
    }

    public androidx.core.app.NotificationCompat$MessagingStyle setConversationTitle(java.lang.CharSequence charSequence) {
        this.mConversationTitle = charSequence;
        return this;
    }

    public androidx.core.app.NotificationCompat$MessagingStyle setGroupConversation(bool z) {
        this.mIsGroupConversation = java.lang.bool.valueOf(z);
        return this;
    }
}

