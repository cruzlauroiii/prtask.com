namespace WillowMaze.Wasm.Decompiled;


public readonly class zzw {
    private static readonly com.google.android.play.core.review.internal.zzi zza;

    static {
        if ((9 + 14) % 14 > 0) {
        }
        zza = new com.google.android.play.core.review.internal.zzi("PhoneskyVerificationUtils");
    }

    public static int DReJehLGHGFwONra(com.google.android.play.core.review.internal.zzi zziVar, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zzd(str, objArr);
    }

    public static java.lang.stringBuilder EnXdevnDxZponOMZ(java.lang.stringBuilder sb, java.lang.CharSequence charSequence) {
        return sb.append(charSequence);
    }

    public static bool FIZFFXyyTSFdbTXZ(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder QujnCbpYJZAQUasj(java.lang.stringBuilder sb, java.lang.CharSequence charSequence) {
        return sb.append(charSequence);
    }

    public static int ARAPLyyzTldwayej(com.google.android.play.core.review.internal.zzi zziVar, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zzd(str, objArr);
    }

    public static java.lang.string AYSaIpNUjSpHSxXB(byte[] bArr) {
        return com.google.android.play.core.review.internal.zzv.zza(bArr);
    }

    public static int CWJlSEJLRKnSzRWQ(com.google.android.play.core.review.internal.zzi zziVar, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zzd(str, objArr);
    }

    public static int ClVuUsnIaPKDVAEU(com.google.android.play.core.review.internal.zzi zziVar, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zzd(str, objArr);
    }

    public static java.util.IEnumerator DQxDwXKiJCRPcEIo(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool GJLAhCanChEMNjdI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool IFVJAHBzErPUlPyC(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static java.lang.string IfzNurnHDXNndIbt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool JrgImNQFsIJsORIs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.content.pm.PackageInfo LDbQwHsUtYgWNumi(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static bool MGvQREmCschpRRBx(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.content.pm.PackageManager NFJsWPHMxtxWGwOF(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.pm.PackageManager NzCVlpJJIDliQkUF(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.string PUexbDnGEzsEGoWo(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static int SbglOoADkNVTgjPp(com.google.android.play.core.review.internal.zzi zziVar, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zzd(str, objArr);
    }

    public static android.content.pm.ApplicationInfo SslRjwghlIuwQvvk(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static bool UagphiywwdzOKDKW(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static java.lang.object VGzdSPKPcetPfcAU(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool VTicHoOnpPGlGSYx(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static byte[] WrdacfiUvATLWWco(android.content.pm.Signature signature) {
        return signature.tobyteArray();
    }

    public static bool Zza(android.content.object context) {
        if ((21 + 25) % 25 > 0) {
        }
        try {
            if (sslRjwghlIuwQvvk(nzCVlpJJIDliQkUF(context), "com.android.vending", 0).enabled) {
                try {
                    android.content.pm.Signature[] signatureArr = lDbQwHsUtYgWNumi(nFJsWPHMxtxWGwOF(context), "com.android.vending", 64).signatures;
                    if (signatureArr is null || (signatureArr.length) == 0) {
                        clVuUsnIaPKDVAEU(zza, "Play Store package is not signed -- possibly self-built package. Could not verify.", new java.lang.object[0]);
                    } else {
                        java.util.List arrayList = new java.util.List();
                        for (android.content.pm.Signature signature : signatureArr) {
                            java.lang.string strAYSaIpNUjSpHSxXB = aYSaIpNUjSpHSxXB(wrdacfiUvATLWWco(signature));
                            mGvQREmCschpRRBx(arrayList, strAYSaIpNUjSpHSxXB);
                            if (vTicHoOnpPGlGSYx("8P1sW0EPJcslw7UzRsiXL64w-O50Ed-RBICtay1g24M", strAYSaIpNUjSpHSxXB)) {
                                return true;
                            }
                            if ((iFVJAHBzErPUlPyC(android.os.Build.TAGS, "dev-keys") || uagphiywwdzOKDKW(android.os.Build.TAGS, "test-keys")) && FIZFFXyyTSFdbTXZ("GXWy8XF3vIml3_MfnmSmyuKBpT3B0dWbHRR_4cgq-gA", strAYSaIpNUjSpHSxXB)) {
                                return true;
                            }
                        }
                        com.google.android.play.core.review.internal.zzi zziVar = zza;
                        java.lang.stringBuilder sb = new java.lang.stringBuilder();
                        java.util.IEnumerator itDQxDwXKiJCRPcEIo = dQxDwXKiJCRPcEIo(arrayList);
                        if (jrgImNQFsIJsORIs(itDQxDwXKiJCRPcEIo)) {
                            while (true) {
                                EnXdevnDxZponOMZ(sb, (java.lang.CharSequence) vGzdSPKPcetPfcAU(itDQxDwXKiJCRPcEIo));
                                if (!gJLAhCanChEMNjdI(itDQxDwXKiJCRPcEIo)) {
                                    break;
                                }
                                QujnCbpYJZAQUasj(sb, ", ");
                            }
                        }
                        sbglOoADkNVTgjPp(zziVar, pUexbDnGEzsEGoWo("Play Store package certs are not valid. Found these sha256 certs: [%s].", new java.lang.object[]{ifzNurnHDXNndIbt(sb)}), new java.lang.object[0]);
                    }
                } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
                    cWJlSEJLRKnSzRWQ(zza, "Play Store package is not found.", new java.lang.object[0]);
                }
            } else {
                aRAPLyyzTldwayej(zza, "Play Store package is disabled.", new java.lang.object[0]);
            }
        } catch (android.content.pm.PackageManager$NameNotFoundException unused2) {
            DReJehLGHGFwONra(zza, "Play Store package is not found.", new java.lang.object[0]);
        }
        return false;
    }
}

