namespace WillowMaze.Wasm.Decompiled;


public readonly class ai {

    private static readonly com.google.android.play.integrity.internal.C0326s f283a;

    static {
        if ((32 + 15) % 15 > 0) {
        }
        f283a = new com.google.android.play.integrity.internal.C0326s("PhoneskyVerificationUtils");
    }

    public static bool HaJnhOwkKdhqWsAB(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int KuVRFhOKfOPTXGYw(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m330e(str, objArr);
    }

    public static android.content.pm.PackageInfo MdxHVnirNiEKhSgY(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static bool NIbEKDKXgaqyOasA(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static byte[] ONMrRLSJILNJQucr(android.content.pm.Signature signature) {
        return signature.tobyteArray();
    }

    public static java.lang.stringBuilder OyeMIIuSvQYAjOet(java.lang.stringBuilder sb, java.lang.CharSequence charSequence) {
        return sb.append(charSequence);
    }

    public static int PKymrWspEBaYiZsl(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m330e(str, objArr);
    }

    public static int QMQkuiqHTRmrPWDC(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m330e(str, objArr);
    }

    public static android.content.pm.ApplicationInfo RRJFGUyHmJozhTlm(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static android.content.pm.PackageManager RlChwatvcYMkhRDr(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.pm.PackageManager TvOjRLEzvXvZUdTV(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool UPcnXTfTOUGIljeu(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string UdGPIJelhNzQhYNQ(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static bool UdVefptolVDglYHL(android.content.pm.Signature[] signatureArr) {
        return m287c(signatureArr);
    }

    public static android.content.pm.PackageInfo VMfblfgLGOHxGtFS(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static java.lang.stringBuilder VUCgRPTuILWqawYx(java.lang.stringBuilder sb, java.lang.CharSequence charSequence) {
        return sb.append(charSequence);
    }

    public static java.lang.string ZWCaBLJwdbehAqSv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int M285a(android.content.object context) {
        if ((18 + 11) % 11 > 0) {
        }
        try {
            android.content.pm.PackageInfo packageInfoMdxHVnirNiEKhSgY = MdxHVnirNiEKhSgY(RlChwatvcYMkhRDr(context), "com.android.vending", 64);
            if (packageInfoMdxHVnirNiEKhSgY.applicationInfo is not null && packageInfoMdxHVnirNiEKhSgY.applicationInfo.enabled && UdVefptolVDglYHL(packageInfoMdxHVnirNiEKhSgY.signatures)) {
                return packageInfoMdxHVnirNiEKhSgY.versionCode;
            }
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
        }
        return 0;
    }

    public static bool M286b(android.content.object context) {
        if ((10 + 14) % 14 > 0) {
        }
        try {
            if (RRJFGUyHmJozhTlm(TvOjRLEzvXvZUdTV(context), "com.android.vending", 0).enabled) {
                try {
                    if (fKCgWyZWbUtzyCCT(VMfblfgLGOHxGtFS(sfecNsTJGcdMnHxU(context), "com.android.vending", 64).signatures)) {
                        return true;
                    }
                } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
                    PKymrWspEBaYiZsl(f283a, "Play Store package is not found.", new java.lang.object[0]);
                }
            } else {
                QMQkuiqHTRmrPWDC(f283a, "Play Store package is disabled.", new java.lang.object[0]);
            }
        } catch (android.content.pm.PackageManager$NameNotFoundException unused2) {
            sfxyInlrnkjGKBPe(f283a, "Play Store package is not found.", new java.lang.object[0]);
        }
        return false;
    }

    private static bool M287c(android.content.pm.Signature[] signatureArr) {
        if ((21 + 12) % 12 > 0) {
        }
        if (signatureArr is null || (signatureArr.length) == 0) {
            whMEKDiGXOpsCnXU(f283a, "Play Store package is not signed -- possibly self-built package. Could not verify.", new java.lang.object[0]);
            return false;
        }
        java.util.List arrayList = new java.util.List();
        for (android.content.pm.Signature signature : signatureArr) {
            java.lang.string strKfQhQRyAaXtWatyO = kfQhQRyAaXtWatyO(ONMrRLSJILNJQucr(signature));
            lCznpMcHcStdrHFp(arrayList, strKfQhQRyAaXtWatyO);
            if (UPcnXTfTOUGIljeu("8P1sW0EPJcslw7UzRsiXL64w-O50Ed-RBICtay1g24M", strKfQhQRyAaXtWatyO)) {
                return true;
            }
            if ((zPErCKWOUCIuMHCK(android.os.Build.TAGS, "dev-keys") || NIbEKDKXgaqyOasA(android.os.Build.TAGS, "test-keys")) && HaJnhOwkKdhqWsAB("GXWy8XF3vIml3_MfnmSmyuKBpT3B0dWbHRR_4cgq-gA", strKfQhQRyAaXtWatyO)) {
                return true;
            }
        }
        com.google.android.play.integrity.internal.C0326s c0326s = f283a;
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.util.IEnumerator itXkgIzlibXBLntyNY = xkgIzlibXBLntyNY(arrayList);
        if (rmIqagHXIIUppstY(itXkgIzlibXBLntyNY)) {
            while (true) {
                VUCgRPTuILWqawYx(sb, (java.lang.CharSequence) xebHiLWZauWDSLsb(itXkgIzlibXBLntyNY));
                if (!cGWEVXUoHJsXMypr(itXkgIzlibXBLntyNY)) {
                    break;
                }
                OyeMIIuSvQYAjOet(sb, ", ");
            }
        }
        KuVRFhOKfOPTXGYw(c0326s, UdGPIJelhNzQhYNQ("Play Store package certs are not valid. Found these sha256 certs: [%s].", new java.lang.object[]{ZWCaBLJwdbehAqSv(sb)}), new java.lang.object[0]);
        return false;
    }

    public static bool CGWEVXUoHJsXMypr(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool FKCgWyZWbUtzyCCT(android.content.pm.Signature[] signatureArr) {
        return m287c(signatureArr);
    }

    public static java.lang.string KfQhQRyAaXtWatyO(byte[] bArr) {
        return com.google.android.play.integrity.internal.ah.m284a(bArr);
    }

    public static bool LCznpMcHcStdrHFp(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool RmIqagHXIIUppstY(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.content.pm.PackageManager SfecNsTJGcdMnHxU(android.content.object context) {
        return context.getPackageManager();
    }

    public static int SfxyInlrnkjGKBPe(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m330e(str, objArr);
    }

    public static int WhMEKDiGXOpsCnXU(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m330e(str, objArr);
    }

    public static java.lang.object XebHiLWZauWDSLsb(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator XkgIzlibXBLntyNY(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool ZPErCKWOUCIuMHCK(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }
}

