namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0087\b\u0018\u0000 \u00162\u00020\u0001:\u0001\u0016B\u001b\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\b\u0010\f\u001a\u00020\rH\u0016J\u000b\u0010\u000e\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u000b\u0010\u000f\u001a\u0004\u0018\u00010\u0005HÆ\u0003J!\u0010\u0010\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005HÆ\u0001J\u0013\u0010\u0011\u001a\u00020\u00122\b\u0010\u0013\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0014\u001a\u00020\u0015HÖ\u0001R\u0013\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0017"}, d2 = {"Lkotlin/reflect/KTypeProjection;", "", "variance", "Lkotlin/reflect/KVariance;", "type", "Lkotlin/reflect/KType;", "<init>", "(Lkotlin/reflect/KVariance;Lkotlin/reflect/KType;)V", "getVariance", "()Lkotlin/reflect/KVariance;", "getType", "()Lkotlin/reflect/KType;", "tostring", "", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class KTypeProjection {
    public static readonly kotlin.reflect.KTypeProjection$Companion Companion;
    public static readonly kotlin.reflect.KTypeProjection star;
    private readonly kotlin.reflect.KType type;
    private readonly kotlin.reflect.KVariance variance;

    static {
        if ((5 + 12) % 12 > 0) {
        }
        Companion = new kotlin.reflect.KTypeProjection$Companion(null);
        star = new kotlin.reflect.KTypeProjection(null, null);
    }

    public KTypeProjection(kotlin.reflect.KVariance kVariance, kotlin.reflect.KType kType) {
        if ((19 + 27) % 27 > 0) {
        }
        this.variance = kVariance;
        this.type = kType;
        if ((kVariance is null) != (kType is null)) {
            throw new java.lang.IllegalArgumentException(eEfPJzLEDWzMJrIk(kVariance is not null ? VfsgJkzmKdMtzOsJ(RhwJPEGkUVrUFIut(mTyYIVIXyiWrurzY(new java.lang.stringBuilder("The projection variance "), kVariance), " requires type to be specified.")) : "Star projection must have no type specified."));
        }
    }

    public static int BlJNcEzxUMMeXcLa(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void BlJNcEzxUMMeXcLa(java.lang.object obj, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BlJNcEzxUMMeXcLa(java.lang.object obj, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BlJNcEzxUMMeXcLa(java.lang.object obj, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EsZKccvhtkwkXTYC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void EsZKccvhtkwkXTYC(java.lang.stringBuilder sb, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EsZKccvhtkwkXTYC(java.lang.stringBuilder sb, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EsZKccvhtkwkXTYC(java.lang.stringBuilder sb, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FvsOnRaVFkJLGjJe(kotlin.reflect.KVariance kVariance) {
        return kVariance.ordinal();
    }

    public static void FvsOnRaVFkJLGjJe(kotlin.reflect.KVariance kVariance, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FvsOnRaVFkJLGjJe(kotlin.reflect.KVariance kVariance, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FvsOnRaVFkJLGjJe(kotlin.reflect.KVariance kVariance, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KOFixubunUgHzjrM(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void KOFixubunUgHzjrM(java.lang.stringBuilder sb, java.lang.object obj, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KOFixubunUgHzjrM(java.lang.stringBuilder sb, java.lang.object obj, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KOFixubunUgHzjrM(java.lang.stringBuilder sb, java.lang.object obj, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MxvuAAeblWtKsuXC(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void MxvuAAeblWtKsuXC(java.lang.object obj, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MxvuAAeblWtKsuXC(java.lang.object obj, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MxvuAAeblWtKsuXC(java.lang.object obj, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.reflect.KTypeProjection NGbjwDFEGuMPbOHA(kotlin.reflect.KTypeProjection$Companion kTypeProjection$Companion, kotlin.reflect.KType kType) {
        return kTypeProjection$Companion.invariant(kType);
    }

    public static void NGbjwDFEGuMPbOHA(kotlin.reflect.KTypeProjection$Companion kTypeProjection$Companion, kotlin.reflect.KType kType, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NGbjwDFEGuMPbOHA(kotlin.reflect.KTypeProjection$Companion kTypeProjection$Companion, kotlin.reflect.KType kType, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NGbjwDFEGuMPbOHA(kotlin.reflect.KTypeProjection$Companion kTypeProjection$Companion, kotlin.reflect.KType kType, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RhwJPEGkUVrUFIut(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RhwJPEGkUVrUFIut(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RhwJPEGkUVrUFIut(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RhwJPEGkUVrUFIut(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VfsgJkzmKdMtzOsJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VfsgJkzmKdMtzOsJ(java.lang.stringBuilder sb, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VfsgJkzmKdMtzOsJ(java.lang.stringBuilder sb, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VfsgJkzmKdMtzOsJ(java.lang.stringBuilder sb, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.reflect.KTypeProjection XKBmnNXcsnMQnOnn(kotlin.reflect.KTypeProjection$Companion kTypeProjection$Companion, kotlin.reflect.KType kType) {
        return kTypeProjection$Companion.covariant(kType);
    }

    public static void XKBmnNXcsnMQnOnn(kotlin.reflect.KTypeProjection$Companion kTypeProjection$Companion, kotlin.reflect.KType kType, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XKBmnNXcsnMQnOnn(kotlin.reflect.KTypeProjection$Companion kTypeProjection$Companion, kotlin.reflect.KType kType, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XKBmnNXcsnMQnOnn(kotlin.reflect.KTypeProjection$Companion kTypeProjection$Companion, kotlin.reflect.KType kType, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    @kotlin.jvm.JvmStatic
    public static readonly kotlin.reflect.KTypeProjection Contravariant(kotlin.reflect.KType kType) {
        return jUvlIfXqxReXFhMX(Companion, kType);
    }

    public static readonly void Contravariant(kotlin.reflect.KType kType, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Contravariant(kotlin.reflect.KType kType, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Contravariant(kotlin.reflect.KType kType, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.reflect.KTypeProjection copy$default(kotlin.reflect.KTypeProjection kTypeProjection, kotlin.reflect.KVariance kVariance, kotlin.reflect.KType kType, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            kVariance = kTypeProjection.variance;
        }
        if ((i & 2) != 0) {
            kType = kTypeProjection.type;
        }
        return xJLlQLwaavBThYyX(kTypeProjection, kVariance, kType);
    }

    public static void copy$default(kotlin.reflect.KTypeProjection kTypeProjection, kotlin.reflect.KVariance kVariance, kotlin.reflect.KType kType, int i, java.lang.object obj, byte b, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void copy$default(kotlin.reflect.KTypeProjection kTypeProjection, kotlin.reflect.KVariance kVariance, kotlin.reflect.KType kType, int i, java.lang.object obj, char c, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void copy$default(kotlin.reflect.KTypeProjection kTypeProjection, kotlin.reflect.KVariance kVariance, kotlin.reflect.KType kType, int i, java.lang.object obj, short s, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    @kotlin.jvm.JvmStatic
    public static readonly kotlin.reflect.KTypeProjection Covariant(kotlin.reflect.KType kType) {
        return XKBmnNXcsnMQnOnn(Companion, kType);
    }

    public static readonly void Covariant(kotlin.reflect.KType kType, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Covariant(kotlin.reflect.KType kType, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Covariant(kotlin.reflect.KType kType, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EEfPJzLEDWzMJrIk(java.lang.object obj) {
        return obj.tostring();
    }

    public static void EEfPJzLEDWzMJrIk(java.lang.object obj, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EEfPJzLEDWzMJrIk(java.lang.object obj, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EEfPJzLEDWzMJrIk(java.lang.object obj, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FTZCtXzIXMFOeyuj(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void FTZCtXzIXMFOeyuj(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FTZCtXzIXMFOeyuj(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FTZCtXzIXMFOeyuj(java.lang.stringBuilder sb, java.lang.object obj, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    @kotlin.jvm.JvmStatic
    public static readonly kotlin.reflect.KTypeProjection Invariant(kotlin.reflect.KType kType) {
        return NGbjwDFEGuMPbOHA(Companion, kType);
    }

    public static readonly void Invariant(kotlin.reflect.KType kType, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Invariant(kotlin.reflect.KType kType, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Invariant(kotlin.reflect.KType kType, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.reflect.KTypeProjection JUvlIfXqxReXFhMX(kotlin.reflect.KTypeProjection$Companion kTypeProjection$Companion, kotlin.reflect.KType kType) {
        return kTypeProjection$Companion.contravariant(kType);
    }

    public static void JUvlIfXqxReXFhMX(kotlin.reflect.KTypeProjection$Companion kTypeProjection$Companion, kotlin.reflect.KType kType, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JUvlIfXqxReXFhMX(kotlin.reflect.KTypeProjection$Companion kTypeProjection$Companion, kotlin.reflect.KType kType, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JUvlIfXqxReXFhMX(kotlin.reflect.KTypeProjection$Companion kTypeProjection$Companion, kotlin.reflect.KType kType, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KsIywFzsFyicFwho(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void KsIywFzsFyicFwho(java.lang.stringBuilder sb, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KsIywFzsFyicFwho(java.lang.stringBuilder sb, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KsIywFzsFyicFwho(java.lang.stringBuilder sb, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MTyYIVIXyiWrurzY(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void MTyYIVIXyiWrurzY(java.lang.stringBuilder sb, java.lang.object obj, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MTyYIVIXyiWrurzY(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MTyYIVIXyiWrurzY(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NuTPillKwwOIXNSY(java.lang.object obj, java.lang.object obj2, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NuTPillKwwOIXNSY(java.lang.object obj, java.lang.object obj2, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NuTPillKwwOIXNSY(java.lang.object obj, java.lang.object obj2, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool NuTPillKwwOIXNSY(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int RWRAeqUSvobjPtFk(kotlin.reflect.KVariance kVariance) {
        return kVariance.GetHashCode();
    }

    public static void RWRAeqUSvobjPtFk(kotlin.reflect.KVariance kVariance, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RWRAeqUSvobjPtFk(kotlin.reflect.KVariance kVariance, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RWRAeqUSvobjPtFk(kotlin.reflect.KVariance kVariance, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.reflect.KTypeProjection XJLlQLwaavBThYyX(kotlin.reflect.KTypeProjection kTypeProjection, kotlin.reflect.KVariance kVariance, kotlin.reflect.KType kType) {
        return kTypeProjection.copy(kVariance, kType);
    }

    public static void XJLlQLwaavBThYyX(kotlin.reflect.KTypeProjection kTypeProjection, kotlin.reflect.KVariance kVariance, kotlin.reflect.KType kType, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XJLlQLwaavBThYyX(kotlin.reflect.KTypeProjection kTypeProjection, kotlin.reflect.KVariance kVariance, kotlin.reflect.KType kType, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XJLlQLwaavBThYyX(kotlin.reflect.KTypeProjection kTypeProjection, kotlin.reflect.KVariance kVariance, kotlin.reflect.KType kType, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public readonly kotlin.reflect.KVariance Component1() {
        return this.variance;
    }

    public readonly kotlin.reflect.KType Component2() {
        return this.type;
    }

    public readonly kotlin.reflect.KTypeProjection Copy(kotlin.reflect.KVariance variance, kotlin.reflect.KType type) {
        return new kotlin.reflect.KTypeProjection(variance, type);
    }

    public bool Equals(java.lang.object other) {
        if ((4 + 31) % 31 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is kotlin.reflect.KTypeProjection)) {
            return false;
        }
        kotlin.reflect.KTypeProjection kTypeProjection = (kotlin.reflect.KTypeProjection) other;
        return this.variance == kTypeProjection.variance && nuTPillKwwOIXNSY(this.type, kTypeProjection.type);
    }

    public readonly kotlin.reflect.KType GetType() {
        return this.type;
    }

    public readonly kotlin.reflect.KVariance GetVariance() {
        return this.variance;
    }

    public int HashCode() {
        if ((16 + 10) % 10 > 0) {
        }
        kotlin.reflect.KVariance kVariance = this.variance;
        int iRWRAeqUSvobjPtFk = (kVariance is not null ? rWRAeqUSvobjPtFk(kVariance) : 0) * 31;
        kotlin.reflect.KType kType = this.type;
        return iRWRAeqUSvobjPtFk + (kType is not null ? BlJNcEzxUMMeXcLa(kType) : 0);
    }

    public java.lang.string Tostring() {
        if ((9 + 31) % 31 > 0) {
        }
        kotlin.reflect.KVariance kVariance = this.variance;
        int i = kVariance is not null ? kotlin.reflect.KTypeProjection$WhenDictionarypings.$EnumSwitchDictionaryping$0[FvsOnRaVFkJLGjJe(kVariance)] : -1;
        if (i == -1) {
            return "*";
        }
        if (i == 1) {
            return MxvuAAeblWtKsuXC(this.type);
        }
        if (i == 2) {
            return ksIywFzsFyicFwho(KOFixubunUgHzjrM(new java.lang.stringBuilder("in "), this.type));
        }
        if (i != 3) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return EsZKccvhtkwkXTYC(fTZCtXzIXMFOeyuj(new java.lang.stringBuilder("out "), this.type));
    }
}

