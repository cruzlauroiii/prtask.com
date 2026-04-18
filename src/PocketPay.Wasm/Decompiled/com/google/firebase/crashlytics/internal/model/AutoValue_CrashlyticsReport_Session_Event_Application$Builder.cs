namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_CrashlyticsReport_Session_Event_Application$Builder : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder {
    private java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails> appProcessDetails;
    private java.lang.bool background;
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails currentProcessDetails;
    private java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute> customAttributes;
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution execution;
    private java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute> internalKeys;
    private byte set$0;
    private int uiOrientation;

    AutoValue_CrashlyticsReport_Session_Event_Application$Builder() {
    }

    private AutoValue_CrashlyticsReport_Session_Event_Application$Builder(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application) {
        this.execution = pDohxzUkdElbHpDl(crashlyticsReport$Session$Event$Application);
        this.customAttributes = CiUmyVfSQUNQZlYz(crashlyticsReport$Session$Event$Application);
        this.internalKeys = wIqcdpbeFcwChfjT(crashlyticsReport$Session$Event$Application);
        this.background = IxGkGWqPykpeipuF(crashlyticsReport$Session$Event$Application);
        this.currentProcessDetails = UeqSVzGjiqOEVtqO(crashlyticsReport$Session$Event$Application);
        this.appProcessDetails = mlnoeiuUJvQNUwXZ(crashlyticsReport$Session$Event$Application);
        this.uiOrientation = QKUDEzObUuxSfpau(crashlyticsReport$Session$Event$Application);
        this.set$0 = (byte) 1;
    }

    AutoValue_CrashlyticsReport_Session_Event_Application$Builder(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_Application$1 autoValue_CrashlyticsReport_Session_Event_Application$1) {
        this(crashlyticsReport$Session$Event$Application);
    }

    public static java.util.List CiUmyVfSQUNQZlYz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application) {
        return crashlyticsReport$Session$Event$Application.getCustomAttributes();
    }

    public static void CiUmyVfSQUNQZlYz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CiUmyVfSQUNQZlYz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CiUmyVfSQUNQZlYz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool IxGkGWqPykpeipuF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application) {
        return crashlyticsReport$Session$Event$Application.getBackground();
    }

    public static void IxGkGWqPykpeipuF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IxGkGWqPykpeipuF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IxGkGWqPykpeipuF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QKUDEzObUuxSfpau(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application) {
        return crashlyticsReport$Session$Event$Application.getUiOrientation();
    }

    public static void QKUDEzObUuxSfpau(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QKUDEzObUuxSfpau(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QKUDEzObUuxSfpau(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails UeqSVzGjiqOEVtqO(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application) {
        return crashlyticsReport$Session$Event$Application.getCurrentProcessDetails();
    }

    public static void UeqSVzGjiqOEVtqO(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UeqSVzGjiqOEVtqO(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UeqSVzGjiqOEVtqO(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List MlnoeiuUJvQNUwXZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application) {
        return crashlyticsReport$Session$Event$Application.getAppProcessDetails();
    }

    public static void MlnoeiuUJvQNUwXZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MlnoeiuUJvQNUwXZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MlnoeiuUJvQNUwXZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution pDohxzUkdElbHpDl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application) {
        return crashlyticsReport$Session$Event$Application.getExecution();
    }

    public static void PDohxzUkdElbHpDl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PDohxzUkdElbHpDl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PDohxzUkdElbHpDl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QRTEnCJDiWlsoUSg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QRTEnCJDiWlsoUSg(java.lang.stringBuilder sb, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QRTEnCJDiWlsoUSg(java.lang.stringBuilder sb, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QRTEnCJDiWlsoUSg(java.lang.stringBuilder sb, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QYgPMhLmXqPlNCIW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QYgPMhLmXqPlNCIW(java.lang.stringBuilder sb, java.lang.string str, float f, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QYgPMhLmXqPlNCIW(java.lang.stringBuilder sb, java.lang.string str, int i, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QYgPMhLmXqPlNCIW(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QaOBfcovkKcfeEos(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void QaOBfcovkKcfeEos(java.lang.stringBuilder sb, java.lang.object obj, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QaOBfcovkKcfeEos(java.lang.stringBuilder sb, java.lang.object obj, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QaOBfcovkKcfeEos(java.lang.stringBuilder sb, java.lang.object obj, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RHmOLljGkZpVBODb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RHmOLljGkZpVBODb(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RHmOLljGkZpVBODb(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RHmOLljGkZpVBODb(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List WIqcdpbeFcwChfjT(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application) {
        return crashlyticsReport$Session$Event$Application.getInternalKeys();
    }

    public static void WIqcdpbeFcwChfjT(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WIqcdpbeFcwChfjT(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WIqcdpbeFcwChfjT(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application build() {
        if ((12 + 8) % 8 > 0) {
        }
        if (this.set$0 == 1 && this.execution is not null) {
            return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_Application(this.execution, this.customAttributes, this.internalKeys, this.background, this.currentProcessDetails, this.appProcessDetails, this.uiOrientation, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.execution is null) {
            qYgPMhLmXqPlNCIW(sb, " execution");
        }
        if ((this.set$0 & 1) == 0) {
            rHmOLljGkZpVBODb(sb, " uiOrientation");
        }
        throw new java.lang.IllegalStateException(qRTEnCJDiWlsoUSg(qaOBfcovkKcfeEos(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder setAppProcessDetails(java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails> list) {
        this.appProcessDetails = list;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder setBackground(java.lang.bool bool) {
        this.background = bool;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder setCurrentProcessDetails(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails) {
        this.currentProcessDetails = crashlyticsReport$Session$Event$Application$ProcessDetails;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder setCustomAttributes(java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute> list) {
        this.customAttributes = list;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder setExecution(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution crashlyticsReport$Session$Event$Application$Execution) {
        if (crashlyticsReport$Session$Event$Application$Execution is null) {
            throw new java.lang.NullPointerException("Null execution");
        }
        this.execution = crashlyticsReport$Session$Event$Application$Execution;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder setInternalKeys(java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute> list) {
        this.internalKeys = list;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder setUiOrientation(int i) {
        this.uiOrientation = i;
        this.set$0 = (byte) (this.set$0 | 1);
        return this;
    }
}

