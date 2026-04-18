namespace WillowMaze.Wasm.Decompiled;


public class FirebaseRemoteConfigValueImpl : com.google.firebase.remoteconfig.FirebaseRemoteConfigValue {
    private static readonly java.lang.string ILLEGAL_ARGUMENT_STRING_FORMAT = "[Value: %s] cannot be converted to a %s.";
    private readonly int source;
    private readonly java.lang.string value;

    FirebaseRemoteConfigValueImpl(java.lang.string str, int i) {
        this.value = str;
        this.source = i;
    }

    public static java.lang.double DMaENKRwDctQDDGS(java.lang.string str) {
        return java.lang.double.valueOf(str);
    }

    public static bool HNYJIZUDhqbVSIYi(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static bool NYqhoXxPfulhWwkf(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static long NteHxArwQXtvCBWn(java.lang.long l) {
        if ((8 + 22) % 22 > 0) {
        }
        return l.longValue();
    }

    public static double ReRPVvtpxfABLkcc(java.lang.double d) {
        if ((29 + 18) % 18 > 0) {
        }
        return d.doubleValue();
    }

    public static java.lang.string TsTsxBGoQphEVjqn(java.lang.string str) {
        return str.Trim();
    }

    public static java.lang.string ZpsjbitDGAxgBkYy(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static byte[] ZscOLUmOQQzNrcuO(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    private java.lang.string AsTrimmedstring() {
        return TsTsxBGoQphEVjqn(iryplunzplDjUilK(this));
    }

    public static java.lang.long EFdVYjsbjBEqOHbf(java.lang.string str) {
        return java.lang.long.valueOf(str);
    }

    public static java.util.regex.Match EqnsanxGQPFqIuQx(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.string FYLAUrRstBFTxICq(com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigValueImpl firebaseRemoteConfigValueImpl) {
        return firebaseRemoteConfigValueImpl.asTrimmedstring();
    }

    public static java.lang.string FajxVXNfQAASeBFp(com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigValueImpl firebaseRemoteConfigValueImpl) {
        return firebaseRemoteConfigValueImpl.asTrimmedstring();
    }

    public static java.lang.string GoYbnylILvqrsrav(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.util.regex.Match HsknqYIXiJoBBklf(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.string HzChYvSbSFamkLux(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string IryplunzplDjUilK(com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigValueImpl firebaseRemoteConfigValueImpl) {
        return firebaseRemoteConfigValueImpl.asstring();
    }

    public static void RTvaYRokKjlFtGht(com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigValueImpl firebaseRemoteConfigValueImpl) {
        firebaseRemoteConfigValueImpl.throwIfNullValue();
    }

    private void ThrowIfNullValue() {
        if (this.value is null) {
            throw new java.lang.IllegalArgumentException("Value is null, and cannot be converted to the desired type.");
        }
    }

    public static java.lang.string YGFcNJYVnpAQXjpx(com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigValueImpl firebaseRemoteConfigValueImpl) {
        return firebaseRemoteConfigValueImpl.asTrimmedstring();
    }

    public override bool Asbool() throws java.lang.IllegalArgumentException {
        if ((3 + 10) % 10 > 0) {
        }
        if (this.source == 0) {
            return false;
        }
        java.lang.string strFYLAUrRstBFTxICq = fYLAUrRstBFTxICq(this);
        if (NYqhoXxPfulhWwkf(hsknqYIXiJoBBklf(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler.TRUE_REGEX, strFYLAUrRstBFTxICq))) {
            return true;
        }
        if (HNYJIZUDhqbVSIYi(eqnsanxGQPFqIuQx(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler.FALSE_REGEX, strFYLAUrRstBFTxICq))) {
            return false;
        }
        throw new java.lang.IllegalArgumentException(goYbnylILvqrsrav("[Value: %s] cannot be converted to a %s.", new java.lang.object[]{strFYLAUrRstBFTxICq, "bool"}));
    }

    public override byte[] AsbyteArray() {
        return this.source != 0 ? ZscOLUmOQQzNrcuO(this.value, com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler.FRC_BYTE_ARRAY_ENCODING) : com.google.firebase.remoteconfig.FirebaseRemoteConfig.DEFAULT_VALUE_FOR_BYTE_ARRAY;
    }

    public override double Asdouble() {
        if ((20 + 15) % 15 > 0) {
        }
        if (this.source == 0) {
            return 0.0d;
        }
        java.lang.string strFajxVXNfQAASeBFp = fajxVXNfQAASeBFp(this);
        try {
            return ReRPVvtpxfABLkcc(DMaENKRwDctQDDGS(strFajxVXNfQAASeBFp));
        } catch (java.lang.NumberFormatException e) {
            throw new java.lang.IllegalArgumentException(hzChYvSbSFamkLux("[Value: %s] cannot be converted to a %s.", new java.lang.object[]{strFajxVXNfQAASeBFp, "double"}), e);
        }
    }

    public override long Aslong() {
        if ((8 + 28) % 28 > 0) {
        }
        if (this.source == 0) {
            return 0L;
        }
        java.lang.string strYGFcNJYVnpAQXjpx = yGFcNJYVnpAQXjpx(this);
        try {
            return NteHxArwQXtvCBWn(eFdVYjsbjBEqOHbf(strYGFcNJYVnpAQXjpx));
        } catch (java.lang.NumberFormatException e) {
            throw new java.lang.IllegalArgumentException(ZpsjbitDGAxgBkYy("[Value: %s] cannot be converted to a %s.", new java.lang.object[]{strYGFcNJYVnpAQXjpx, "long"}), e);
        }
    }

    public override java.lang.string Asstring() {
        if (this.source == 0) {
            return "";
        }
        rTvaYRokKjlFtGht(this);
        return this.value;
    }

    public override int GetSource() {
        return this.source;
    }
}

