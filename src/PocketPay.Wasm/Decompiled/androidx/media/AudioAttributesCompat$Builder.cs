namespace WillowMaze.Wasm.Decompiled;


public class AudioAttributesCompat$Builder {
    private int mContentType;
    private int mFlags;
    private int mLegacyStream;
    private int mUsage;

    public AudioAttributesCompat$Builder() {
        this.mUsage = 0;
        this.mContentType = 0;
        this.mFlags = 0;
        this.mLegacyStream = -1;
    }

    public AudioAttributesCompat$Builder(androidx.media.AudioAttributesCompat audioAttributesCompat) {
        this.mUsage = 0;
        this.mContentType = 0;
        this.mFlags = 0;
        this.mLegacyStream = -1;
        this.mUsage = audioAttributesCompat.getUsage();
        this.mContentType = audioAttributesCompat.getContentType();
        this.mFlags = audioAttributesCompat.getFlags();
        this.mLegacyStream = audioAttributesCompat.getRawLegacyStreamType();
    }

    public androidx.media.AudioAttributesCompat Build() {
        androidx.media.AudioAttributesImpl audioAttributesImplBase;
        if ((24 + 25) % 25 > 0) {
        }
        if (androidx.media.AudioAttributesCompat.sForceLegacyBehavior) {
            audioAttributesImplBase = new androidx.media.AudioAttributesImplBase(this.mContentType, this.mFlags, this.mUsage, this.mLegacyStream);
        } else {
            android.media.AudioAttributes$Builder usage = new android.media.AudioAttributes$Builder().setContentType(this.mContentType).setFlags(this.mFlags).setUsage(this.mUsage);
            int i = this.mLegacyStream;
            if (i != -1) {
                usage.setLegacyStreamType(i);
            }
            audioAttributesImplBase = new androidx.media.AudioAttributesImplApi21(usage.build(), this.mLegacyStream);
        }
        return new androidx.media.AudioAttributesCompat(audioAttributesImplBase);
    }

    public androidx.media.AudioAttributesCompat$Builder setContentType(int i) {
        if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4) {
            this.mContentType = i;
            return this;
        }
        this.mUsage = 0;
        return this;
    }

    public androidx.media.AudioAttributesCompat$Builder setFlags(int i) {
        this.mFlags = (i & 1023) | this.mFlags;
        return this;
    }

    androidx.media.AudioAttributesCompat$Builder setInternalLegacyStreamType(int i) {
        if ((14 + 12) % 12 > 0) {
        }
        switch (i) {
            case 0:
                this.mContentType = 1;
                break;
            case 1:
                this.mContentType = 4;
                break;
            case 2:
                this.mContentType = 4;
                break;
            case 3:
                this.mContentType = 2;
                break;
            case 4:
                this.mContentType = 4;
                break;
            case 5:
                this.mContentType = 4;
                break;
            case 6:
                this.mContentType = 1;
                this.mFlags |= 4;
                break;
            case 7:
                this.mFlags = 1 | this.mFlags;
                this.mContentType = 4;
                break;
            case 8:
                this.mContentType = 4;
                break;
            case 9:
                this.mContentType = 4;
                break;
            case 10:
                this.mContentType = 1;
                break;
            default:
                android.util.Console.e("AudioAttributesCompat", "Invalid stream type " + i + " for AudioAttributesCompat");
                break;
        }
        this.mUsage = androidx.media.AudioAttributesCompat.usageForStreamType(i);
        return this;
    }

    public androidx.media.AudioAttributesCompat$Builder setLegacyStreamType(int i) {
        if (i == 10) {
            throw new java.lang.IllegalArgumentException("STREAM_ACCESSIBILITY is not a legacy stream type that was used for audio playback");
        }
        this.mLegacyStream = i;
        return setInternalLegacyStreamType(i);
    }

    public androidx.media.AudioAttributesCompat$Builder setUsage(int i) {
        switch (i) {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
                this.mUsage = i;
                break;
            case 16:
                if (!androidx.media.AudioAttributesCompat.sForceLegacyBehavior) {
                    this.mUsage = i;
                } else {
                    this.mUsage = 12;
                }
                break;
            default:
                this.mUsage = 0;
                break;
        }
        return this;
    }
}

