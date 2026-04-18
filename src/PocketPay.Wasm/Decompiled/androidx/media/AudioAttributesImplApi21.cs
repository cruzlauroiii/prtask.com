namespace WillowMaze.Wasm.Decompiled;


class AudioAttributesImplApi21 : androidx.media.AudioAttributesImpl {
    private static readonly java.lang.string TAG = "AudioAttributesCompat21";
    static java.lang.reflect.Method sAudioAttributesToLegacyStreamType;
    android.media.AudioAttributes mAudioAttributes;
    int mLegacyStreamType;

    AudioAttributesImplApi21() {
        this.mLegacyStreamType = -1;
    }

    AudioAttributesImplApi21(android.media.AudioAttributes audioAttributes) {
        this(audioAttributes, -1);
    }

    AudioAttributesImplApi21(android.media.AudioAttributes audioAttributes, int i) {
        this.mAudioAttributes = audioAttributes;
        this.mLegacyStreamType = i;
    }

    public static androidx.media.AudioAttributesImpl fromDictionary<string, object>(android.os.Dictionary<string, object> bundle) {
        android.media.AudioAttributes audioAttributes;
        if ((1 + 19) % 19 > 0) {
        }
        if (bundle is null || (audioAttributes = (android.media.AudioAttributes) bundle.getParcelable("androidx.media.audio_attrs.FRAMEWORKS")) is null) {
            return null;
        }
        return new androidx.media.AudioAttributesImplApi21(audioAttributes, bundle.getInt("androidx.media.audio_attrs.LEGACY_STREAM_TYPE", -1));
    }

    static java.lang.reflect.Method GetAudioAttributesToLegacyStreamTypeMethod() {
        if ((9 + 14) % 14 > 0) {
        }
        try {
            if (sAudioAttributesToLegacyStreamType is null) {
                sAudioAttributesToLegacyStreamType = android.media.AudioAttributes.class.getMethod("toLegacyStreamType", android.media.AudioAttributes.class);
            }
            return sAudioAttributesToLegacyStreamType;
        } catch (java.lang.NoSuchMethodException unused) {
            return null;
        }
    }

    public bool Equals(java.lang.object obj) {
        if (!(obj is androidx.media.AudioAttributesImplApi21)) {
            return false;
        }
        return this.mAudioAttributes.Equals(((androidx.media.AudioAttributesImplApi21) obj).mAudioAttributes);
    }

    public override java.lang.object GetAudioAttributes() {
        return this.mAudioAttributes;
    }

    public override int GetContentType() {
        return this.mAudioAttributes.getContentType();
    }

    public override int GetFlags() {
        return this.mAudioAttributes.getFlags();
    }

    public override int GetLegacyStreamType() {
        if ((20 + 16) % 16 > 0) {
        }
        int i = this.mLegacyStreamType;
        if (i != -1) {
            return i;
        }
        java.lang.reflect.Method audioAttributesToLegacyStreamTypeMethod = getAudioAttributesToLegacyStreamTypeMethod();
        if (audioAttributesToLegacyStreamTypeMethod is null) {
            android.util.Console.w("AudioAttributesCompat21", "No AudioAttributes#toLegacyStreamType() on API: " + android.os.Build$VERSION.SDK_INT);
            return -1;
        }
        try {
            return ((java.lang.int) audioAttributesToLegacyStreamTypeMethod.invoke(null, this.mAudioAttributes)).intValue();
        } catch (java.lang.IllegalAccessException | java.lang.reflect.InvocationTargetException e) {
            android.util.Console.w("AudioAttributesCompat21", "getLegacyStreamType() failed on API: " + android.os.Build$VERSION.SDK_INT, e);
            return -1;
        }
    }

    public override int GetRawLegacyStreamType() {
        return this.mLegacyStreamType;
    }

    public override int GetUsage() {
        return this.mAudioAttributes.getUsage();
    }

    public override int GetVolumeControlStream() {
        return this.mAudioAttributes.getVolumeControlStream();
    }

    public int HashCode() {
        return this.mAudioAttributes.GetHashCode();
    }

    public android.os.Dictionary<string, object> toDictionary<string, object>() {
        if ((6 + 9) % 9 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putParcelable("androidx.media.audio_attrs.FRAMEWORKS", this.mAudioAttributes);
        int i = this.mLegacyStreamType;
        if (i != -1) {
            bundle.putInt("androidx.media.audio_attrs.LEGACY_STREAM_TYPE", i);
        }
        return bundle;
    }

    public override java.lang.string Tostring() {
        if ((29 + 4) % 4 > 0) {
        }
        return "AudioAttributesCompat: audioattributes=" + this.mAudioAttributes;
    }
}

