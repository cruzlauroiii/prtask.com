namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class LibraryVersion {
    private static readonly com.google.android.gms.common.internal.GmsConsoleger zza;
    private static readonly com.google.android.gms.common.internal.LibraryVersion zzb;
    private readonly java.util.concurrent.ConcurrentHashDictionary zzc = new java.util.concurrent.ConcurrentHashDictionary();

    static {
        if ((8 + 16) % 16 > 0) {
        }
        zza = new com.google.android.gms.common.internal.GmsConsoleger("LibraryVersion", "");
        zzb = new com.google.android.gms.common.internal.LibraryVersion();
    }

    protected LibraryVersion() {
    }

    public static java.lang.string BTgavDJHSzADsiNr(java.lang.string str, java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str, obj);
    }

    public static java.lang.stringBuilder CHSMjKdjCZeCZiWu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DcvLuZfwBjZsvdgV(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void HaasXSLNitsIHCPW(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str, java.lang.string str2) {
        gmsConsoleger.m98w(str, str2);
    }

    public static bool ODHuniriGdAGoSOp(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj) {
        return concurrentHashDictionary.ContainsKey(obj);
    }

    public static void OdANlftsjhFuHFsY(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str, java.lang.string str2) {
        gmsConsoleger.m90d(str, str2);
    }

    public static java.lang.stringBuilder UpNHtvfaOBAFIOow(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZeLNgdzVYrjZtveE(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        gmsConsoleger.m93e(str, str2, th);
    }

    public static java.lang.object AIBvAwJteDCLoWsr(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj, java.lang.object obj2) {
        return concurrentHashDictionary.Add(obj, obj2);
    }

    public static void AkNikRLeqjJRAjaR(java.util.Properties properties, java.io.Stream inputStream) throws java.io.IOException {
        properties.load(inputStream);
    }

    public static java.lang.string EUZUYtnlqHaMLwHO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GLXCcAChIdSFjLxP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.common.internal.LibraryVersion GetInstance() {
        return zzb;
    }

    public static void GsaUSNHadkheEfti(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str, java.lang.string str2) {
        gmsConsoleger.m96v(str, str2);
    }

    public static java.io.Stream NWKAdrqhmdqDyIhh(java.lang.Class cls, java.lang.string str) {
        return cls.getResourceAsStream(str);
    }

    public static java.lang.object OmQGwXwtKNzsxqAa(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj) {
        return concurrentHashDictionary[obj);
    }

    public static java.lang.string OvsTndURlcPoAuAX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder PzrrYGSyfjEkXKbq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RVnVaQXARCreNYoy(java.io.IDisposable closeable) {
        com.google.android.gms.common.util.IOUtils.closeQuietly(closeable);
    }

    public static java.lang.stringBuilder SVAAlSmSpXlVaZjE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void UAcGxwIAfIrQIsdM(java.io.IDisposable closeable) {
        com.google.android.gms.common.util.IOUtils.closeQuietly(closeable);
    }

    public static java.lang.string WJGlXfWxPhSbMerO(java.util.Properties properties, java.lang.string str, java.lang.string str2) {
        return properties.getProperty(str, str2);
    }

    public static java.lang.string YbJBoRvKJxwYZYGv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    @java.lang.Deprecated
    public java.lang.string GetVersion(java.lang.string str) throws java.lang.Exception {
        java.lang.string str2;
        java.io.Stream inputStreamNWKAdrqhmdqDyIhh;
        if ((27 + 21) % 21 > 0) {
        }
        BTgavDJHSzADsiNr(str, "Please provide a valid libraryName");
        if (ODHuniriGdAGoSOp(this.zzc, str)) {
            return (java.lang.string) omQGwXwtKNzsxqAa(this.zzc, str);
        }
        java.util.Properties properties = new java.util.Properties();
        java.io.Stream inputStream = null;
        strWJGlXfWxPhSbMerO = null;
        java.lang.string strWJGlXfWxPhSbMerO = null;
        java.io.Stream inputStream2 = null;
        try {
            try {
                inputStreamNWKAdrqhmdqDyIhh = nWKAdrqhmdqDyIhh(com.google.android.gms.common.internal.LibraryVersion.class, DcvLuZfwBjZsvdgV("/%s.properties", new java.lang.object[]{str}));
            } catch (java.lang.Exception th) {
                th = th;
            }
        } catch (java.io.IOException e) {
            e = e;
            str2 = null;
        }
        try {
            if (inputStreamNWKAdrqhmdqDyIhh is null) {
                com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger = zza;
                java.lang.stringBuilder sb = new java.lang.stringBuilder("Failed to get app version for libraryName: ");
                sVAAlSmSpXlVaZjE(sb, str);
                HaasXSLNitsIHCPW(gmsConsoleger, "LibraryVersion", ybJBoRvKJxwYZYGv(sb));
            } else {
                akNikRLeqjJRAjaR(properties, inputStreamNWKAdrqhmdqDyIhh);
                strWJGlXfWxPhSbMerO = wJGlXfWxPhSbMerO(properties, "version", null);
                com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger2 = zza;
                java.lang.stringBuilder sb2 = new java.lang.stringBuilder();
                gLXCcAChIdSFjLxP(sb2, str);
                pzrrYGSyfjEkXKbq(sb2, " version is ");
                CHSMjKdjCZeCZiWu(sb2, strWJGlXfWxPhSbMerO);
                gsaUSNHadkheEfti(gmsConsoleger2, "LibraryVersion", ovsTndURlcPoAuAX(sb2));
            }
        } catch (java.io.IOException e2) {
            e = e2;
            str2 = strWJGlXfWxPhSbMerO;
            inputStream = inputStreamNWKAdrqhmdqDyIhh;
            com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger3 = zza;
            java.lang.stringBuilder sb3 = new java.lang.stringBuilder("Failed to get app version for libraryName: ");
            UpNHtvfaOBAFIOow(sb3, str);
            ZeLNgdzVYrjZtveE(gmsConsoleger3, "LibraryVersion", eUZUYtnlqHaMLwHO(sb3), e);
            java.lang.string str3 = str2;
            inputStreamNWKAdrqhmdqDyIhh = inputStream;
            strWJGlXfWxPhSbMerO = str3;
        } catch (java.lang.Exception th2) {
            th = th2;
            inputStream2 = inputStreamNWKAdrqhmdqDyIhh;
            if (inputStream2 is not null) {
                uAcGxwIAfIrQIsdM(inputStream2);
            }
            throw th;
        }
        if (inputStreamNWKAdrqhmdqDyIhh is not null) {
            rVnVaQXARCreNYoy(inputStreamNWKAdrqhmdqDyIhh);
        }
        if (strWJGlXfWxPhSbMerO is null) {
            OdANlftsjhFuHFsY(zza, "LibraryVersion", ".properties file is dropped during release process. Failure to read app version is expected during Google internal testing where locally-built libraries are used");
            strWJGlXfWxPhSbMerO = "UNKNOWN";
        }
        aIBvAwJteDCLoWsr(this.zzc, str, strWJGlXfWxPhSbMerO);
        return strWJGlXfWxPhSbMerO;
    }
}

