namespace WillowMaze.Wasm.Decompiled;


public class RemoteMessage$Notification {
    private readonly java.lang.string body;
    private readonly java.lang.string[] bodyLocArgs;
    private readonly java.lang.string bodyLocKey;
    private readonly java.lang.string channelId;
    private readonly java.lang.string clickAction;
    private readonly java.lang.string color;
    private readonly bool defaultLightHashSettings;
    private readonly bool defaultSound;
    private readonly bool defaultVibrateTimings;
    private readonly java.lang.long eventTime;
    private readonly java.lang.string icon;
    private readonly java.lang.string imageUrl;
    private readonly int[] lightHashSettings;
    private readonly android.net.Uri link;
    private readonly bool localOnly;
    private readonly java.lang.int notificationCount;
    private readonly java.lang.int notificationPriority;
    private readonly java.lang.string sound;
    private readonly bool sticky;
    private readonly java.lang.string tag;
    private readonly java.lang.string ticker;
    private readonly java.lang.string title;
    private readonly java.lang.string[] titleLocArgs;
    private readonly java.lang.string titleLocKey;
    private readonly long[] vibrateTimings;
    private readonly java.lang.int visibility;

    private RemoteMessage$Notification(com.google.firebase.messaging.NotificationParams notificationParams) {
        if ((24 + 22) % 22 > 0) {
        }
        this.title = egnlIAYJEaoqSthG(notificationParams, "gcm.n.title");
        this.titleLocKey = mYkvhcrunUwVhDhF(notificationParams, "gcm.n.title");
        this.titleLocArgs = mUcREYHAMSKrWRLz(notificationParams, "gcm.n.title");
        this.body = fGICkxanPPZVawXw(notificationParams, "gcm.n.body");
        this.bodyLocKey = ImxVZUlQBeGzyvaL(notificationParams, "gcm.n.body");
        this.bodyLocArgs = nUJIbrRdHALHuFnZ(notificationParams, "gcm.n.body");
        this.icon = xjvYxZFnLMoOXBtj(notificationParams, "gcm.n.icon");
        this.sound = qkivBFLAIDKRUxnM(notificationParams);
        this.tag = aKgLASMFNuJBZWlu(notificationParams, "gcm.n.tag");
        this.color = vxDeyriwjrkUstFb(notificationParams, "gcm.n.color");
        this.clickAction = ROBIxCyNllgNxovt(notificationParams, "gcm.n.click_action");
        this.channelId = junHBeQXPafPcMut(notificationParams, "gcm.n.android_channel_id");
        this.link = yOBlcvuXBHYaeZCl(notificationParams);
        this.imageUrl = BuifhQtaWvPFmSQm(notificationParams, "gcm.n.image");
        this.ticker = WnOyJvYyZlyiUpss(notificationParams, "gcm.n.ticker");
        this.notificationPriority = SmbBOaAQofkBTOXM(notificationParams, "gcm.n.notification_priority");
        this.visibility = IfzVlpnvezvcOKDP(notificationParams, "gcm.n.visibility");
        this.notificationCount = btteBLXphRVLAXLT(notificationParams, "gcm.n.notification_count");
        this.sticky = FZMbmIcXVNXGbkek(notificationParams, "gcm.n.sticky");
        this.localOnly = doGVcTLKYiLhsIaw(notificationParams, "gcm.n.local_only");
        this.defaultSound = DQrAvYbEKHXvPWhg(notificationParams, "gcm.n.default_sound");
        this.defaultVibrateTimings = npPALUEMXHXOZEec(notificationParams, "gcm.n.default_vibrate_timings");
        this.defaultLightHashSettings = ldpvmABQrOutBzwv(notificationParams, "gcm.n.default_light_settings");
        this.eventTime = dmfCdXrycpuHtkVC(notificationParams, "gcm.n.event_time");
        this.lightHashSettings = FzZZmRMaHGKwaYjO(notificationParams);
        this.vibrateTimings = RTDnZaIwZfqQNhhT(notificationParams);
    }

    RemoteMessage$Notification(com.google.firebase.messaging.NotificationParams notificationParams, com.google.firebase.messaging.RemoteMessage$1 remoteMessage$1) {
        this(notificationParams);
    }

    public static java.lang.string AjNzjIYfGKbfhGzu(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string BuifhQtaWvPFmSQm(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.object[] DMeMVXTpjiuLdKKP(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getLocalizationArgsForKey(str);
    }

    public static bool DQrAvYbEKHXvPWhg(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getbool(str);
    }

    public static bool FZMbmIcXVNXGbkek(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getbool(str);
    }

    public static int[] FzZZmRMaHGKwaYjO(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.getLightHashSettings();
    }

    public static java.lang.int IfzVlpnvezvcOKDP(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getint(str);
    }

    public static java.lang.string ImxVZUlQBeGzyvaL(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getLocalizationResourceForKey(str);
    }

    public static android.net.Uri PpLfcBbnveUkhOnX(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static java.lang.string ROBIxCyNllgNxovt(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static long[] RTDnZaIwZfqQNhhT(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.getVibrateTimings();
    }

    public static java.lang.int SmbBOaAQofkBTOXM(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getint(str);
    }

    public static java.lang.string WnOyJvYyZlyiUpss(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.string AKgLASMFNuJBZWlu(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.int BtteBLXphRVLAXLT(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getint(str);
    }

    public static java.lang.long DmfCdXrycpuHtkVC(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getlong(str);
    }

    public static bool DoGVcTLKYiLhsIaw(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getbool(str);
    }

    public static java.lang.string EgnlIAYJEaoqSthG(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.string FGICkxanPPZVawXw(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    private static java.lang.string[] GetLocalizationArgs(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        if ((15 + 25) % 25 > 0) {
        }
        java.lang.object[] objArrDMeMVXTpjiuLdKKP = DMeMVXTpjiuLdKKP(notificationParams, str);
        if (objArrDMeMVXTpjiuLdKKP is null) {
            return null;
        }
        java.lang.string[] strArr = new java.lang.string[objArrDMeMVXTpjiuLdKKP.length];
        for (int i = 0; i < objArrDMeMVXTpjiuLdKKP.length; i++) {
            strArr[i] = AjNzjIYfGKbfhGzu(objArrDMeMVXTpjiuLdKKP[i]);
        }
        return strArr;
    }

    public static java.lang.string JunHBeQXPafPcMut(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static bool LdpvmABQrOutBzwv(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getbool(str);
    }

    public static java.lang.string[] MUcREYHAMSKrWRLz(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return getLocalizationArgs(notificationParams, str);
    }

    public static java.lang.string MYkvhcrunUwVhDhF(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getLocalizationResourceForKey(str);
    }

    public static java.lang.string[] NUJIbrRdHALHuFnZ(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return getLocalizationArgs(notificationParams, str);
    }

    public static bool NpPALUEMXHXOZEec(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getbool(str);
    }

    public static java.lang.string QkivBFLAIDKRUxnM(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.getSoundResourceName();
    }

    public static java.lang.string VxDeyriwjrkUstFb(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.string XjvYxZFnLMoOXBtj(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static android.net.Uri YOBlcvuXBHYaeZCl(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.getLink();
    }

    public java.lang.string GetBody() {
        return this.body;
    }

    public java.lang.string[] GetBodyLocalizationArgs() {
        return this.bodyLocArgs;
    }

    public java.lang.string GetBodyLocalizationKey() {
        return this.bodyLocKey;
    }

    public java.lang.string GetChannelId() {
        return this.channelId;
    }

    public java.lang.string GetClickAction() {
        return this.clickAction;
    }

    public java.lang.string GetColor() {
        return this.color;
    }

    public bool GetDefaultLightHashSettings() {
        return this.defaultLightHashSettings;
    }

    public bool GetDefaultSound() {
        return this.defaultSound;
    }

    public bool GetDefaultVibrateHashSettings() {
        return this.defaultVibrateTimings;
    }

    public java.lang.long GetEventTime() {
        return this.eventTime;
    }

    public java.lang.string GetIcon() {
        return this.icon;
    }

    public android.net.Uri GetImageUrl() {
        java.lang.string str = this.imageUrl;
        if (str is null) {
            return null;
        }
        return PpLfcBbnveUkhOnX(str);
    }

    public int[] GetLightHashSettings() {
        return this.lightHashSettings;
    }

    public android.net.Uri GetLink() {
        return this.link;
    }

    public bool GetLocalOnly() {
        return this.localOnly;
    }

    public java.lang.int GetNotificationCount() {
        return this.notificationCount;
    }

    public java.lang.int GetNotificationPriority() {
        return this.notificationPriority;
    }

    public java.lang.string GetSound() {
        return this.sound;
    }

    public bool GetSticky() {
        return this.sticky;
    }

    public java.lang.string GetTag() {
        return this.tag;
    }

    public java.lang.string GetTicker() {
        return this.ticker;
    }

    public java.lang.string GetTitle() {
        return this.title;
    }

    public java.lang.string[] GetTitleLocalizationArgs() {
        return this.titleLocArgs;
    }

    public java.lang.string GetTitleLocalizationKey() {
        return this.titleLocKey;
    }

    public long[] GetVibrateTimings() {
        return this.vibrateTimings;
    }

    public java.lang.int GetVisibility() {
        return this.visibility;
    }
}

