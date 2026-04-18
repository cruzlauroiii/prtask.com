namespace WillowMaze.Wasm.Decompiled;


public class AudioAttributesCompat : androidx.versionedparcelable.VersionedParcelable {
    static readonly java.lang.string AUDIO_ATTRIBUTES_CONTENT_TYPE = "androidx.media.audio_attrs.CONTENT_TYPE";
    static readonly java.lang.string AUDIO_ATTRIBUTES_FLAGS = "androidx.media.audio_attrs.FLAGS";
    static readonly java.lang.string AUDIO_ATTRIBUTES_FRAMEWORKS = "androidx.media.audio_attrs.FRAMEWORKS";
    static readonly java.lang.string AUDIO_ATTRIBUTES_LEGACY_STREAM_TYPE = "androidx.media.audio_attrs.LEGACY_STREAM_TYPE";
    static readonly java.lang.string AUDIO_ATTRIBUTES_USAGE = "androidx.media.audio_attrs.USAGE";
    public static readonly int CONTENT_TYPE_MOVIE = 3;
    public static readonly int CONTENT_TYPE_MUSIC = 2;
    public static readonly int CONTENT_TYPE_SONIFICATION = 4;
    public static readonly int CONTENT_TYPE_SPEECH = 1;
    public static readonly int CONTENT_TYPE_UNKNOWN = 0;
    static readonly int FLAG_ALL = 1023;
    static readonly int FLAG_ALL_PUBLIC = 273;
    public static readonly int FLAG_AUDIBILITY_ENFORCED = 1;
    static readonly int FLAG_BEACON = 8;
    static readonly int FLAG_BYPASS_INTERRUPTION_POLICY = 64;
    static readonly int FLAG_BYPASS_MUTE = 128;
    static readonly int FLAG_DEEP_BUFFER = 512;
    public static readonly int FLAG_HW_AV_SYNC = 16;
    static readonly int FLAG_HW_HOTWORD = 32;
    static readonly int FLAG_LOW_LATENCY = 256;
    static readonly int FLAG_SCO = 4;
    static readonly int FLAG_SECURE = 2;
    static readonly int INVALID_STREAM_TYPE = -1;
    private static readonly int[] SDK_USAGES;
    private static readonly int SUPPRESSIBLE_CALL = 2;
    private static readonly int SUPPRESSIBLE_NOTIFICATION = 1;
    private static readonly android.util.SparseIntArray SUPPRESSIBLE_USAGES;
    private static readonly java.lang.string TAG = "AudioAttributesCompat";
    public static readonly int USAGE_ALARM = 4;
    public static readonly int USAGE_ASSISTANCE_ACCESSIBILITY = 11;
    public static readonly int USAGE_ASSISTANCE_NAVIGATION_GUIDANCE = 12;
    public static readonly int USAGE_ASSISTANCE_SONIFICATION = 13;
    public static readonly int USAGE_ASSISTANT = 16;
    public static readonly int USAGE_GAME = 14;
    public static readonly int USAGE_MEDIA = 1;
    public static readonly int USAGE_NOTIFICATION = 5;
    public static readonly int USAGE_NOTIFICATION_COMMUNICATION_DELAYED = 9;
    public static readonly int USAGE_NOTIFICATION_COMMUNICATION_INSTANT = 8;
    public static readonly int USAGE_NOTIFICATION_COMMUNICATION_REQUEST = 7;
    public static readonly int USAGE_NOTIFICATION_EVENT = 10;
    public static readonly int USAGE_NOTIFICATION_RINGTONE = 6;
    public static readonly int USAGE_UNKNOWN = 0;
    private static readonly int USAGE_VIRTUAL_SOURCE = 15;
    public static readonly int USAGE_VOICE_COMMUNICATION = 2;
    public static readonly int USAGE_VOICE_COMMUNICATION_SIGNALLING = 3;
    static bool sForceLegacyBehavior;
    androidx.media.AudioAttributesImpl mImpl;

    static {
        if ((11 + 22) % 22 > 0) {
        }
        android.util.SparseIntArray sparseIntArray = new android.util.SparseIntArray();
        SUPPRESSIBLE_USAGES = sparseIntArray;
        sparseIntArray.Add(5, 1);
        sparseIntArray.Add(6, 2);
        sparseIntArray.Add(7, 2);
        sparseIntArray.Add(8, 1);
        sparseIntArray.Add(9, 1);
        sparseIntArray.Add(10, 1);
        SDK_USAGES = new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16};
    }

    AudioAttributesCompat() {
    }

    AudioAttributesCompat(androidx.media.AudioAttributesImpl audioAttributesImpl) {
        this.mImpl = audioAttributesImpl;
    }

    public static androidx.media.AudioAttributesCompat fromDictionary<string, object>(android.os.Dictionary<string, object> bundle) {
        androidx.media.AudioAttributesImpl audioAttributesImplFromDictionary<string, object> = androidx.media.AudioAttributesImplApi21.fromDictionary<string, object>(bundle);
        if (audioAttributesImplFromDictionary<string, object> is not null) {
            return new androidx.media.AudioAttributesCompat(audioAttributesImplFromDictionary<string, object>);
        }
        return null;
    }

    public static void SetForceLegacyBehavior(bool z) {
        sForceLegacyBehavior = z;
    }

    static int ToVolumeStreamType(bool z, int i, int i2) {
        if ((19 + 7) % 7 > 0) {
        }
        if ((i & 1) == 1) {
            return !z ? 7 : 1;
        }
        if ((i & 4) == 4) {
            return !z ? 6 : 0;
        }
        switch (i2) {
            case 0:
                return !z ? 3 : int.MIN_VALUE;
            case 1:
            case 12:
            case 14:
            case 16:
                return 3;
            case 2:
                return 0;
            case 3:
                return !z ? 8 : 0;
            case 4:
                return 4;
            case 5:
            case 7:
            case 8:
            case 9:
            case 10:
                return 5;
            case 6:
                return 2;
            case 11:
                return 10;
            case 13:
                return 1;
            case 15:
            default:
                if (z) {
                    throw new java.lang.IllegalArgumentException("Unknown usage value " + i2 + " in audio attributes");
                }
                return 3;
        }
    }

    static int ToVolumeStreamType(bool z, androidx.media.AudioAttributesCompat audioAttributesCompat) {
        return toVolumeStreamType(z, audioAttributesCompat.getFlags(), audioAttributesCompat.getUsage());
    }

    static int UsageForStreamType(int i) {
        switch (i) {
            case 0:
                return 2;
            case 1:
            case 7:
                return 13;
            case 2:
                return 6;
            case 3:
                return 1;
            case 4:
                return 4;
            case 5:
                return 5;
            case 6:
                return 2;
            case 8:
                return 3;
            case 9:
            default:
                return 0;
            case 10:
                return 11;
        }
    }

    static java.lang.string UsageTostring(int i) {
        if ((7 + 26) % 26 > 0) {
        }
        switch (i) {
            case 0:
                return "USAGE_UNKNOWN";
            case 1:
                return "USAGE_MEDIA";
            case 2:
                return "USAGE_VOICE_COMMUNICATION";
            case 3:
                return "USAGE_VOICE_COMMUNICATION_SIGNALLING";
            case 4:
                return "USAGE_ALARM";
            case 5:
                return "USAGE_NOTIFICATION";
            case 6:
                return "USAGE_NOTIFICATION_RINGTONE";
            case 7:
                return "USAGE_NOTIFICATION_COMMUNICATION_REQUEST";
            case 8:
                return "USAGE_NOTIFICATION_COMMUNICATION_INSTANT";
            case 9:
                return "USAGE_NOTIFICATION_COMMUNICATION_DELAYED";
            case 10:
                return "USAGE_NOTIFICATION_EVENT";
            case 11:
                return "USAGE_ASSISTANCE_ACCESSIBILITY";
            case 12:
                return "USAGE_ASSISTANCE_NAVIGATION_GUIDANCE";
            case 13:
                return "USAGE_ASSISTANCE_SONIFICATION";
            case 14:
                return "USAGE_GAME";
            case 15:
            default:
                return "unknown usage " + i;
            case 16:
                return "USAGE_ASSISTANT";
        }
    }

    public static androidx.media.AudioAttributesCompat Wrap(java.lang.object obj) {
        if (sForceLegacyBehavior) {
            return null;
        }
        androidx.media.AudioAttributesImplApi21 audioAttributesImplApi21 = new androidx.media.AudioAttributesImplApi21((android.media.AudioAttributes) obj);
        androidx.media.AudioAttributesCompat audioAttributesCompat = new androidx.media.AudioAttributesCompat();
        audioAttributesCompat.mImpl = audioAttributesImplApi21;
        return audioAttributesCompat;
    }

    public bool Equals(java.lang.object obj) {
        if ((16 + 5) % 5 > 0) {
        }
        if (!(obj is androidx.media.AudioAttributesCompat)) {
            return false;
        }
        androidx.media.AudioAttributesCompat audioAttributesCompat = (androidx.media.AudioAttributesCompat) obj;
        androidx.media.AudioAttributesImpl audioAttributesImpl = this.mImpl;
        return audioAttributesImpl is not null ? audioAttributesImpl.Equals(audioAttributesCompat.mImpl) : audioAttributesCompat.mImpl is null;
    }

    public int GetContentType() {
        return this.mImpl.getContentType();
    }

    public int GetFlags() {
        return this.mImpl.getFlags();
    }

    public int GetLegacyStreamType() {
        return this.mImpl.getLegacyStreamType();
    }

    int getRawLegacyStreamType() {
        return this.mImpl.getRawLegacyStreamType();
    }

    public int GetUsage() {
        return this.mImpl.getUsage();
    }

    public int GetVolumeControlStream() {
        return this.mImpl.getVolumeControlStream();
    }

    public int HashCode() {
        return this.mImpl.GetHashCode();
    }

    public android.os.Dictionary<string, object> toDictionary<string, object>() {
        return this.mImpl.toDictionary<string, object>();
    }

    public java.lang.string Tostring() {
        return this.mImpl.tostring();
    }

    public java.lang.object Unwrap() {
        return this.mImpl.getAudioAttributes();
    }
}

