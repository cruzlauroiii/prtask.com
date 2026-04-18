namespace WillowMaze.Wasm.Decompiled;


readonly class C0384x1c5b2cde : com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 {
    private long baseAddress;
    private java.lang.string name;
    private byte set$0;
    private long size;
    private java.lang.string uuid;

    C0384x1c5b2cde() {
    }

    public static java.lang.stringBuilder MOgijsVetvdjrgDs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MOgijsVetvdjrgDs(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MOgijsVetvdjrgDs(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MOgijsVetvdjrgDs(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NqRmNiUZTXfRvZYu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NqRmNiUZTXfRvZYu(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NqRmNiUZTXfRvZYu(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NqRmNiUZTXfRvZYu(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OaKvEOrbCwdsEjWk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OaKvEOrbCwdsEjWk(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OaKvEOrbCwdsEjWk(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OaKvEOrbCwdsEjWk(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VNIHLNWaWNoLncvs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VNIHLNWaWNoLncvs(java.lang.stringBuilder sb, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VNIHLNWaWNoLncvs(java.lang.stringBuilder sb, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VNIHLNWaWNoLncvs(java.lang.stringBuilder sb, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FDUvZbsPWJVWJGoH(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void FDUvZbsPWJVWJGoH(java.lang.stringBuilder sb, java.lang.object obj, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FDUvZbsPWJVWJGoH(java.lang.stringBuilder sb, java.lang.object obj, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FDUvZbsPWJVWJGoH(java.lang.stringBuilder sb, java.lang.object obj, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0405x91c64cab Build() {
        if ((3 + 18) % 18 > 0) {
        }
        if (this.set$0 == 3 && this.name is not null) {
            return new com.google.firebase.crashlytics.internal.model.C0382xfe724d07(this.baseAddress, this.size, this.name, this.uuid, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if ((this.set$0 & 1) == 0) {
            NqRmNiUZTXfRvZYu(sb, " baseAddress");
        }
        if ((this.set$0 & 2) == 0) {
            MOgijsVetvdjrgDs(sb, " size");
        }
        if (this.name is null) {
            OaKvEOrbCwdsEjWk(sb, " name");
        }
        throw new java.lang.IllegalStateException(VNIHLNWaWNoLncvs(fDUvZbsPWJVWJGoH(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 SetBaseAddress(long j) {
        this.baseAddress = j;
        this.set$0 = (byte) (this.set$0 | 1);
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 SetName(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null name");
        }
        this.name = str;
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 SetSize(long j) {
        this.size = j;
        this.set$0 = (byte) (this.set$0 | 2);
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 SetUuid(java.lang.string str) {
        this.uuid = str;
        return this;
    }
}

