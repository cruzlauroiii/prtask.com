namespace WillowMaze.Wasm.Decompiled;


public readonly class Constants$MessagePayloadKeys {
    public static readonly java.lang.string COLLAPSE_KEY = "collapse_key";
    public static readonly java.lang.string DELIVERED_PRIORITY = "google.delivered_priority";
    public static readonly java.lang.string FROM = "from";
    public static readonly java.lang.string MESSAGE_TYPE = "message_type";
    public static readonly java.lang.string MSGID = "google.message_id";
    public static readonly java.lang.string MSGID_SERVER = "message_id";
    public static readonly java.lang.string ORIGINAL_PRIORITY = "google.original_priority";
    public static readonly java.lang.string PRIORITY_REDUCED_V19 = "google.priority_reduced";
    public static readonly java.lang.string PRIORITY_V19 = "google.priority";
    public static readonly java.lang.string PRODUCT_ID = "google.product_id";
    public static readonly java.lang.string RAW_DATA = "rawData";
    public static readonly java.lang.string RESERVED_CLIENT_LIB_PREFIX = "google.c.";
    public static readonly java.lang.string RESERVED_PREFIX = "google.";
    public static readonly java.lang.string SENDER_ID = "google.c.sender.id";
    public static readonly java.lang.string SENT_TIME = "google.sent_time";
    public static readonly java.lang.string TO = "google.to";
    public static readonly java.lang.string TTL = "google.ttl";

    private Constants$MessagePayloadKeys() {
    }

    public static java.lang.object CCqSnWucjKXTuHqj(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool HYHAvghavQjkBQra(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool IYbAynBPfhMIYbCK(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator SyVQwjJQBwFRuPnd(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static bool VYJdtwRRpVfhmgjv(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.object BYJIlfnDVfSXxdXb(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static java.util.HashSet CWPiRzETpabGpZvi(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static androidx.collection.ArrayDictionary<java.lang.string, java.lang.string> ExtractDeveloperDefinedPayload(android.os.Dictionary<string, object> bundle) {
        if ((16 + 30) % 30 > 0) {
        }
        androidx.collection.ArrayDictionary<java.lang.string, java.lang.string> arrayDictionary = new androidx.collection.ArrayDictionary<>();
        java.util.IEnumerator itSyVQwjJQBwFRuPnd = SyVQwjJQBwFRuPnd(cWPiRzETpabGpZvi(bundle));
        while (IYbAynBPfhMIYbCK(itSyVQwjJQBwFRuPnd)) {
            java.lang.string str = (java.lang.string) CCqSnWucjKXTuHqj(itSyVQwjJQBwFRuPnd);
            java.lang.object objFxLOQczxEIgmFMdx = fxLOQczxEIgmFMdx(bundle, str);
            if (objFxLOQczxEIgmFMdx is java.lang.string) {
                java.lang.string str2 = (java.lang.string) objFxLOQczxEIgmFMdx;
                if (!xTdhyYsgNdrRfsfX(str, "google.") && !VYJdtwRRpVfhmgjv(str, "gcm.") && !qHolIKbPafkSqjkC(str, "from") && !HYHAvghavQjkBQra(str, "message_type") && !lnOcoFMPVQamDYAx(str, "collapse_key")) {
                    bYJIlfnDVfSXxdXb(arrayDictionary, str, str2);
                }
            }
        }
        return arrayDictionary;
    }

    public static java.lang.object FxLOQczxEIgmFMdx(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static bool LnOcoFMPVQamDYAx(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool QHolIKbPafkSqjkC(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool XTdhyYsgNdrRfsfX(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }
}

