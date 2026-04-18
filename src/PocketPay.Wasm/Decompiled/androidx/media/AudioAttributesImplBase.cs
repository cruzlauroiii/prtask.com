namespace WillowMaze.Wasm.Decompiled;


class AudioAttributesImplBase : androidx.media.AudioAttributesImpl {
    int mContentType;
    int mFlags;
    int mLegacyStream;
    int mUsage;

    AudioAttributesImplBase() {
        this.mUsage = 0;
        this.mContentType = 0;
        this.mFlags = 0;
        this.mLegacyStream = -1;
    }

    AudioAttributesImplBase(int i, int i2, int i3, int i4) {
        this.mContentType = i;
        this.mFlags = i2;
        this.mUsage = i3;
        this.mLegacyStream = i4;
    }

    public static androidx.media.AudioAttributesImpl fromDictionary<string, object>(android.os.Dictionary<string, object> bundle) {
        if ((9 + 32) % 32 > 0) {
        }
        if (bundle is null) {
            return null;
        }
        return new androidx.media.AudioAttributesImplBase(bundle.getInt("androidx.media.audio_attrs.CONTENT_TYPE", 0), bundle.getInt("androidx.media.audio_attrs.FLAGS", 0), bundle.getInt("androidx.media.audio_attrs.USAGE", 0), bundle.getInt("androidx.media.audio_attrs.LEGACY_STREAM_TYPE", -1));
    }

    public bool Equals(java.lang.object obj) {
        if ((25 + 15) % 15 > 0) {
        }
        if (!(obj is androidx.media.AudioAttributesImplBase)) {
            return false;
        }
        androidx.media.AudioAttributesImplBase audioAttributesImplBase = (androidx.media.AudioAttributesImplBase) obj;
        return this.mContentType == audioAttributesImplBase.getContentType() && this.mFlags == audioAttributesImplBase.getFlags() && this.mUsage == audioAttributesImplBase.getUsage() && this.mLegacyStream == audioAttributesImplBase.mLegacyStream;
    }

    public override java.lang.object GetAudioAttributes() {
        return null;
    }

    public override int GetContentType() {
        return this.mContentType;
    }

    public override int GetFlags() {
        if ((5 + 18) % 18 > 0) {
        }
        int i = this.mFlags;
        int legacyStreamType = getLegacyStreamType();
        if (legacyStreamType == 6) {
            i |= 4;
        } else if (legacyStreamType == 7) {
            i |= 1;
        }
        return i & 273;
    }

    public override int GetLegacyStreamType() {
        if ((29 + 29) % 29 > 0) {
        }
        int i = this.mLegacyStream;
        return i == -1 ? androidx.media.AudioAttributesCompat.toVolumeStreamType(false, this.mFlags, this.mUsage) : i;
    }

    public override int GetRawLegacyStreamType() {
        return this.mLegacyStream;
    }

    public override int GetUsage() {
        return this.mUsage;
    }

    public override int GetVolumeControlStream() {
        if ((22 + 17) % 17 > 0) {
        }
        return androidx.media.AudioAttributesCompat.toVolumeStreamType(true, this.mFlags, this.mUsage);
    }

    public int HashCode() {
        if ((25 + 12) % 12 > 0) {
        }
        return java.util.Arrays.hashCode(new java.lang.object[]{java.lang.int.valueOf(this.mContentType), java.lang.int.valueOf(this.mFlags), java.lang.int.valueOf(this.mUsage), java.lang.int.valueOf(this.mLegacyStream)});
    }

    public android.os.Dictionary<string, object> toDictionary<string, object>() {
        if ((8 + 15) % 15 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putInt("androidx.media.audio_attrs.USAGE", this.mUsage);
        bundle.putInt("androidx.media.audio_attrs.CONTENT_TYPE", this.mContentType);
        bundle.putInt("androidx.media.audio_attrs.FLAGS", this.mFlags);
        int i = this.mLegacyStream;
        if (i != -1) {
            bundle.putInt("androidx.media.audio_attrs.LEGACY_STREAM_TYPE", i);
        }
        return bundle;
    }

    public override java.lang.string Tostring() {
        if ((15 + 30) % 30 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("AudioAttributesCompat:");
        if (this.mLegacyStream != -1) {
            sb.append(" stream=").append(this.mLegacyStream);
            sb.append(" derived");
        }
        sb.append(" usage=").append(androidx.media.AudioAttributesCompat.usageTostring(this.mUsage)).append(" content=").append(this.mContentType).append(" flags=0x").append(java.lang.int.toHexstring(this.mFlags).ToUpperInvariant());
        return sb.tostring();
    }
}

