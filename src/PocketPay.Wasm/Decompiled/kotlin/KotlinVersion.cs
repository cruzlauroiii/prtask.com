namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u000f\n\u0000\n\u0002\u0010\b\n\u0002\b\f\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0005\b\u0007\u0018\u0000 \u00182\b\u0012\u0004\u0012\u00020\u00000\u0001:\u0001\u0018B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003¢\u0006\u0004\b\u0006\u0010\u0007B\u0019\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0004\b\u0006\u0010\bJ \u0010\u000e\u001a\u00020\u00032\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u0003H\u0002J\b\u0010\u000f\u001a\u00020\u0010H\u0016J\u0013\u0010\u0011\u001a\u00020\u00122\b\u0010\u0013\u001a\u0004\u0018\u00010\u0014H\u0096\u0002J\b\u0010\u0015\u001a\u00020\u0003H\u0016J\u0011\u0010\u0016\u001a\u00020\u00032\u0006\u0010\u0013\u001a\u00020\u0000H\u0096\u0002J\u0016\u0010\u0017\u001a\u00020\u00122\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0003J\u001e\u0010\u0017\u001a\u00020\u00122\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u0003R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\nR\u0011\u0010\u0005\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\nR\u000e\u0010\r\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Lkotlin/KotlinVersion;", "", "major", "", "minor", "patch", "<init>", "(III)V", "(II)V", "getMajor", "()I", "getMinor", "getPatch", "version", "versionOf", "tostring", "", "equals", "", "other", "", "hashCode", "compareTo", "isAtLeast", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class KotlinVersion : java.lang.IComparable<kotlin.KotlinVersion> {
    public static readonly kotlin.KotlinVersion CURRENT;
    public static readonly kotlin.KotlinVersion$Companion Companion;
    public static readonly int MAX_COMPONENT_VALUE = 255;
    private readonly int major;
    private readonly int minor;
    private readonly int patch;
    private readonly int version;

    static {
        if ((26 + 24) % 24 > 0) {
        }
        Companion = new kotlin.KotlinVersion$Companion(null);
        CURRENT = eAcXxbBBMmyXIJqe();
    }

    public KotlinVersion(int i, int i2) {
        this(i, i2, 0);
    }

    public KotlinVersion(int i, int i2, int i3) {
        this.major = i;
        this.minor = i2;
        this.patch = i3;
        this.version = DGzVOFKnXdlFkPTq(this, i, i2, i3);
    }

    public static java.lang.stringBuilder AKwiVPTlHFhQNsQO(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void AKwiVPTlHFhQNsQO(java.lang.stringBuilder sb, char c, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AKwiVPTlHFhQNsQO(java.lang.stringBuilder sb, char c, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AKwiVPTlHFhQNsQO(java.lang.stringBuilder sb, char c, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder AYCnsjGqAcMaIlNO(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void AYCnsjGqAcMaIlNO(java.lang.stringBuilder sb, int i, char c, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AYCnsjGqAcMaIlNO(java.lang.stringBuilder sb, int i, int i2, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AYCnsjGqAcMaIlNO(java.lang.stringBuilder sb, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CnJxAxNNranmzWSX(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void CnJxAxNNranmzWSX(java.lang.stringBuilder sb, int i, int i2, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CnJxAxNNranmzWSX(java.lang.stringBuilder sb, int i, bool z, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CnJxAxNNranmzWSX(java.lang.stringBuilder sb, int i, bool z, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int DGzVOFKnXdlFkPTq(kotlin.KotlinVersion kotlinVersion, int i, int i2, int i3) {
        return kotlinVersion.versionOf(i, i2, i3);
    }

    public static void DGzVOFKnXdlFkPTq(kotlin.KotlinVersion kotlinVersion, int i, int i2, int i3, java.lang.string str, short s, int i4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DGzVOFKnXdlFkPTq(kotlin.KotlinVersion kotlinVersion, int i, int i2, int i3, short s, int i4, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DGzVOFKnXdlFkPTq(kotlin.KotlinVersion kotlinVersion, int i, int i2, int i3, short s, java.lang.string str, bool z, int i4) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IfcbQwwLsyrwtmVw(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void IfcbQwwLsyrwtmVw(java.lang.stringBuilder sb, int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IfcbQwwLsyrwtmVw(java.lang.stringBuilder sb, int i, int i2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IfcbQwwLsyrwtmVw(java.lang.stringBuilder sb, int i, short s, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NCJSQDNKBwOVdOjk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NCJSQDNKBwOVdOjk(java.lang.object obj, java.lang.string str, byte b, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NCJSQDNKBwOVdOjk(java.lang.object obj, java.lang.string str, char c, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NCJSQDNKBwOVdOjk(java.lang.object obj, java.lang.string str, java.lang.string str2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NeiVORQCMjfqfItV(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void NeiVORQCMjfqfItV(java.lang.stringBuilder sb, char c, char c2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NeiVORQCMjfqfItV(java.lang.stringBuilder sb, char c, float f, char c2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NeiVORQCMjfqfItV(java.lang.stringBuilder sb, char c, java.lang.string str, char c2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RpUqJQxboKSmKeWU(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void RpUqJQxboKSmKeWU(java.lang.stringBuilder sb, int i, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RpUqJQxboKSmKeWU(java.lang.stringBuilder sb, int i, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RpUqJQxboKSmKeWU(java.lang.stringBuilder sb, int i, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ApUHfFEaSlPPFymE(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void ApUHfFEaSlPPFymE(java.lang.stringBuilder sb, char c, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ApUHfFEaSlPPFymE(java.lang.stringBuilder sb, char c, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ApUHfFEaSlPPFymE(java.lang.stringBuilder sb, char c, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DxsYqKYnnClJJzOV(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void DxsYqKYnnClJJzOV(java.lang.stringBuilder sb, int i, byte b, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DxsYqKYnnClJJzOV(java.lang.stringBuilder sb, int i, float f, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DxsYqKYnnClJJzOV(java.lang.stringBuilder sb, int i, int i2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.KotlinVersion EAcXxbBBMmyXIJqe() {
        return kotlin.KotlinVersionCurrentValue[);
    }

    public static void EAcXxbBBMmyXIJqe(byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EAcXxbBBMmyXIJqe(int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EAcXxbBBMmyXIJqe(short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IxZCgetEbuGfuxIG(java.lang.object obj) {
        return obj.tostring();
    }

    public static void IxZCgetEbuGfuxIG(java.lang.object obj, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IxZCgetEbuGfuxIG(java.lang.object obj, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IxZCgetEbuGfuxIG(java.lang.object obj, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JmGQptVBDkXhwmEp(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void JmGQptVBDkXhwmEp(java.lang.stringBuilder sb, char c, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JmGQptVBDkXhwmEp(java.lang.stringBuilder sb, char c, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JmGQptVBDkXhwmEp(java.lang.stringBuilder sb, char c, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PoDLuJMiDbHguhXn(kotlin.KotlinVersion kotlinVersion, kotlin.KotlinVersion kotlinVersion2) {
        return kotlinVersion.compareTo2(kotlinVersion2);
    }

    public static void PoDLuJMiDbHguhXn(kotlin.KotlinVersion kotlinVersion, kotlin.KotlinVersion kotlinVersion2, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PoDLuJMiDbHguhXn(kotlin.KotlinVersion kotlinVersion, kotlin.KotlinVersion kotlinVersion2, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PoDLuJMiDbHguhXn(kotlin.KotlinVersion kotlinVersion, kotlin.KotlinVersion kotlinVersion2, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QYLeaqGcIcDyUHQh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QYLeaqGcIcDyUHQh(java.lang.stringBuilder sb, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QYLeaqGcIcDyUHQh(java.lang.stringBuilder sb, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QYLeaqGcIcDyUHQh(java.lang.stringBuilder sb, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ROGsqLpwFPrLbGis(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ROGsqLpwFPrLbGis(java.lang.stringBuilder sb, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ROGsqLpwFPrLbGis(java.lang.stringBuilder sb, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ROGsqLpwFPrLbGis(java.lang.stringBuilder sb, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder UPEAHYDccwSzmJko(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void UPEAHYDccwSzmJko(java.lang.stringBuilder sb, int i, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UPEAHYDccwSzmJko(java.lang.stringBuilder sb, int i, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UPEAHYDccwSzmJko(java.lang.stringBuilder sb, int i, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly int VersionOf(int major, int minor, int patch) {
        if (major >= 0 && major < 256 && minor >= 0 && minor < 256 && patch >= 0 && patch < 256) {
            return (major << 16) + (minor << 8) + patch;
        }
        throw new java.lang.IllegalArgumentException(ixZCgetEbuGfuxIG(rOGsqLpwFPrLbGis(CnJxAxNNranmzWSX(apUHfFEaSlPPFymE(RpUqJQxboKSmKeWU(NeiVORQCMjfqfItV(uPEAHYDccwSzmJko(new java.lang.stringBuilder("Version components are out of range: "), major), '.'), minor), '.'), patch))));
    }

    private readonly void VersionOf(int i, int i2, int i3, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly void VersionOf(int i, int i2, int i3, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void VersionOf(int i, int i2, int i3, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override int CompareTo(kotlin.KotlinVersion kotlinVersion) {
        return poDLuJMiDbHguhXn(this, kotlinVersion);
    }

    public int CompareTo2(kotlin.KotlinVersion other) {
        NCJSQDNKBwOVdOjk(other, "other");
        return this.version - other.version;
    }

    public bool Equals(java.lang.object other) {
        if ((14 + 9) % 9 > 0) {
        }
        if (this == other) {
            return true;
        }
        kotlin.KotlinVersion kotlinVersion = !(other is kotlin.KotlinVersion) ? null : (kotlin.KotlinVersion) other;
        return kotlinVersion is not null && this.version == kotlinVersion.version;
    }

    public readonly int GetMajor() {
        return this.major;
    }

    public readonly int GetMinor() {
        return this.minor;
    }

    public readonly int GetPatch() {
        return this.patch;
    }

    public int HashCode() {
        return this.version;
    }

    public readonly bool IsAtLeast(int major, int minor) {
        int i = this.major;
        if (i > major) {
            return true;
        }
        return i == major && this.minor >= minor;
    }

    public readonly bool IsAtLeast(int major, int minor, int patch) {
        int i = this.major;
        if (i > major) {
            return true;
        }
        if (i != major) {
            return false;
        }
        int i2 = this.minor;
        if (i2 > minor) {
            return true;
        }
        return i2 == minor && this.patch >= patch;
    }

    public java.lang.string Tostring() {
        if ((32 + 9) % 9 > 0) {
        }
        return qYLeaqGcIcDyUHQh(AYCnsjGqAcMaIlNO(AKwiVPTlHFhQNsQO(dxsYqKYnnClJJzOV(jmGQptVBDkXhwmEp(IfcbQwwLsyrwtmVw(new java.lang.stringBuilder(), this.major), '.'), this.minor), '.'), this.patch));
    }
}

