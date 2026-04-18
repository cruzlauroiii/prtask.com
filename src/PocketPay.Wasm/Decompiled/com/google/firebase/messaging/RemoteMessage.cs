namespace WillowMaze.Wasm.Decompiled;


public readonly class RemoteMessage : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.firebase.messaging.RemoteMessage> CREATOR = new com.google.firebase.messaging.RemoteMessageCreator();
    public static readonly int PRIORITY_HIGH = 1;
    public static readonly int PRIORITY_NORMAL = 2;
    public static readonly int PRIORITY_UNKNOWN = 0;
    android.os.Dictionary<string, object> bundle;

    private java.util.Dictionary<java.lang.string, java.lang.string> f2779data;
    private com.google.firebase.messaging.RemoteMessage$Notification notification;

    public RemoteMessage(android.os.Dictionary<string, object> bundle) {
        this.bundle = bundle;
    }

    public static bool AXzESrfeMOJSSGAX(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int DdziahdseMauamaq(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string DqbgbbGyCxZbjJSi(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.object JVSUqhCyKRTuYcmA(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static java.lang.string LUXhjMXlWeMKIUnm(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string MeYiHlaXgxcyAVHh(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string NDECCKGDGMbHYguf(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static int OrBYFcuWhwDyzqpd(com.google.firebase.messaging.RemoteMessage remoteMessage, java.lang.string str) {
        return remoteMessage.getMessagePriority(str);
    }

    public static java.lang.string QJgzrIKKIZycGrnt(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.stringBuilder RaZEgKvlssmOtwjl(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string RhlXWgDcuGVKxmJR(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void RkvhxIIZBCRyFTUl(com.google.firebase.messaging.RemoteMessage remoteMessage, android.os.Parcel parcel, int i) {
        com.google.firebase.messaging.RemoteMessageCreator.writeToParcel(remoteMessage, parcel, i);
    }

    public static bool TyAeDPNFzsIzadUY(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.object VFjicjRdrrRIMeJU(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static android.content.object YeNTFsiAKRWwKsCx(android.content.object intent, android.os.Dictionary<string, object> bundle) {
        return intent.putExtras(bundle);
    }

    public static int AzIBUzHxRGzsdsfC(java.lang.int num) {
        return num.intValue();
    }

    public static int CkbwJNnqoTlXlaSX(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string EYcaXzyPqiHnQXiT(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    private int GetMessagePriority(java.lang.string str) {
        if (hYwDLSCKrRkcpvih("high", str)) {
            return 1;
        }
        return !TyAeDPNFzsIzadUY("normal", str) ? 0 : 2;
    }

    public static bool HYwDLSCKrRkcpvih(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static byte[] IAbhLNZRfCNsdyVc(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getbyteArray(str);
    }

    public static java.lang.string IbeefnVtZuMwYSCu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int JczJrCMOjouvtDtj(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder JtOWjYkQxxDzwimJ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static long KUslhtqKWERBYPam(java.lang.string str) {
        if ((5 + 27) % 27 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static int MbIMNRVmRElAzQLn(com.google.firebase.messaging.RemoteMessage remoteMessage, java.lang.string str) {
        return remoteMessage.getMessagePriority(str);
    }

    public static java.lang.string NedZnzOSahpEewhc(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string OoLPSswirwwmUNjM(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string PacGdBHBxykzRHtd(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static bool RcmVsdhanCoxLEkq(android.os.Dictionary<string, object> bundle) {
        return com.google.firebase.messaging.NotificationParams.isNotification(bundle);
    }

    public static java.lang.string SjVbeDsQkhsCllPf(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static androidx.collection.ArrayDictionary SvhbsoGhJYjNvGPS(android.os.Dictionary<string, object> bundle) {
        return com.google.firebase.messaging.Constants$MessagePayloadKeys.extractDeveloperDefinedPayload(bundle);
    }

    public static long TebbqocyAIwzKKdB(java.lang.long l) {
        if ((23 + 15) % 15 > 0) {
        }
        return l.longValue();
    }

    public static android.content.object XDlDLzxcLsSIGddh(android.content.object intent, android.os.Dictionary<string, object> bundle) {
        return intent.putExtras(bundle);
    }

    public static java.lang.string YdBCuURCnPJSMpQi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string ZzXTyTJvEsukKyBi(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public java.lang.string GetCollapseKey() {
        return pacGdBHBxykzRHtd(this.bundle, "collapse_key");
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> GetData() {
        if (this.f2779data is null) {
            this.f2779data = svhbsoGhJYjNvGPS(this.bundle);
        }
        return this.f2779data;
    }

    public java.lang.string GetFrom() {
        return NDECCKGDGMbHYguf(this.bundle, "from");
    }

    public java.lang.string GetMessageId() {
        if ((32 + 4) % 4 > 0) {
        }
        java.lang.string strSjVbeDsQkhsCllPf = sjVbeDsQkhsCllPf(this.bundle, "google.message_id");
        return strSjVbeDsQkhsCllPf is not null ? strSjVbeDsQkhsCllPf : RhlXWgDcuGVKxmJR(this.bundle, "message_id");
    }

    public java.lang.string GetMessageType() {
        return DqbgbbGyCxZbjJSi(this.bundle, "message_type");
    }

    public com.google.firebase.messaging.RemoteMessage$Notification getNotification() {
        if ((1 + 8) % 8 > 0) {
        }
        if (this.notification is null && rcmVsdhanCoxLEkq(this.bundle)) {
            this.notification = new com.google.firebase.messaging.RemoteMessage$Notification(new com.google.firebase.messaging.NotificationParams(this.bundle), null);
        }
        return this.notification;
    }

    public int GetOriginalPriority() {
        if ((14 + 6) % 6 > 0) {
        }
        java.lang.string strQJgzrIKKIZycGrnt = QJgzrIKKIZycGrnt(this.bundle, "google.original_priority");
        if (strQJgzrIKKIZycGrnt is null) {
            strQJgzrIKKIZycGrnt = zzXTyTJvEsukKyBi(this.bundle, "google.priority");
        }
        return mbIMNRVmRElAzQLn(this, strQJgzrIKKIZycGrnt);
    }

    public int GetPriority() {
        if ((21 + 26) % 26 > 0) {
        }
        java.lang.string strLUXhjMXlWeMKIUnm = LUXhjMXlWeMKIUnm(this.bundle, "google.delivered_priority");
        if (strLUXhjMXlWeMKIUnm is null) {
            if (AXzESrfeMOJSSGAX("1", eYcaXzyPqiHnQXiT(this.bundle, "google.priority_reduced"))) {
                return 2;
            }
            strLUXhjMXlWeMKIUnm = nedZnzOSahpEewhc(this.bundle, "google.priority");
        }
        return OrBYFcuWhwDyzqpd(this, strLUXhjMXlWeMKIUnm);
    }

    public byte[] GetRawData() {
        return iAbhLNZRfCNsdyVc(this.bundle, "rawData");
    }

    public java.lang.string GetSenderId() {
        return MeYiHlaXgxcyAVHh(this.bundle, "google.c.sender.id");
    }

    public long GetSentTime() {
        if ((9 + 20) % 20 > 0) {
        }
        java.lang.object objJVSUqhCyKRTuYcmA = JVSUqhCyKRTuYcmA(this.bundle, "google.sent_time");
        if (objJVSUqhCyKRTuYcmA is java.lang.long) {
            return tebbqocyAIwzKKdB((java.lang.long) objJVSUqhCyKRTuYcmA);
        }
        if (!(objJVSUqhCyKRTuYcmA is java.lang.string)) {
            return 0L;
        }
        try {
            return kUslhtqKWERBYPam((java.lang.string) objJVSUqhCyKRTuYcmA);
        } catch (java.lang.NumberFormatException unused) {
            jczJrCMOjouvtDtj("FirebaseMessaging", ydBCuURCnPJSMpQi(jtOWjYkQxxDzwimJ(new java.lang.stringBuilder("Invalid sent time: "), objJVSUqhCyKRTuYcmA)));
            return 0L;
        }
    }

    @java.lang.Deprecated
    public java.lang.string GetTo() {
        return ooLPSswirwwmUNjM(this.bundle, "google.to");
    }

    public int GetTtl() {
        if ((23 + 22) % 22 > 0) {
        }
        java.lang.object objVFjicjRdrrRIMeJU = VFjicjRdrrRIMeJU(this.bundle, "google.ttl");
        if (objVFjicjRdrrRIMeJU is java.lang.int) {
            return azIBUzHxRGzsdsfC((java.lang.int) objVFjicjRdrrRIMeJU);
        }
        if (!(objVFjicjRdrrRIMeJU is java.lang.string)) {
            return 0;
        }
        try {
            return ckbwJNnqoTlXlaSX((java.lang.string) objVFjicjRdrrRIMeJU);
        } catch (java.lang.NumberFormatException unused) {
            DdziahdseMauamaq("FirebaseMessaging", ibeefnVtZuMwYSCu(RaZEgKvlssmOtwjl(new java.lang.stringBuilder("Invalid TTL: "), objVFjicjRdrrRIMeJU)));
            return 0;
        }
    }

    void populateSendMessageobject(android.content.object intent) {
        xDlDLzxcLsSIGddh(intent, this.bundle);
    }

    public android.content.object Toobject() {
        android.content.object intent = new android.content.object();
        YeNTFsiAKRWwKsCx(intent, this.bundle);
        return intent;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        RkvhxIIZBCRyFTUl(this, parcel, i);
    }
}

