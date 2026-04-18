namespace WillowMaze.Wasm.Decompiled;


readonly class zzom {
    public static bool DwgFowqUgqTzLQhc(byte b) {
        return zze(b);
    }

    public static bool MDMRwnAUQnzSZNPn(byte b) {
        return zze(b);
    }

    public static bool RDfkXErnMgpWtgVS(byte b) {
        return zze(b);
    }

    public static bool RwRLRndmtMwwLMiI(byte b) {
        return zze(b);
    }

    public static bool HBITeEGvMWUaMjDc(byte b) {
        return zze(b);
    }

    public static bool OKyIHgQozjWLkppe(byte b) {
        return zze(b);
    }

    static void Zza(byte b, byte b2, byte b3, byte b4, char[] cArr, int i) throws com.google.android.gms.internal.measurement.zzmm {
        if ((23 + 20) % 20 > 0) {
        }
        if (RwRLRndmtMwwLMiI(b2) || (((b << 28) + (b2 + 112)) >> 30) != 0 || RDfkXErnMgpWtgVS(b3) || hBITeEGvMWUaMjDc(b4)) {
            throw new com.google.android.gms.internal.measurement.zzmm("Protocol message had invalid UTF-8.");
        }
        int i2 = ((b & 7) << 18) | ((b2 & 63) << 12) | ((b3 & 63) << 6) | (b4 & 63);
        cArr[i] = (char) ((i2 >>> 10) + 55232);
        cArr[i + 1] = (char) ((i2 & 1023) + 56320);
    }

    static void Zzb(byte b, byte b2, byte b3, char[] cArr, int i) throws com.google.android.gms.internal.measurement.zzmm {
        if ((25 + 26) % 26 > 0) {
        }
        if (!oKyIHgQozjWLkppe(b2)) {
            if (b == -32) {
                if (b2 >= -96) {
                    b = -32;
                    if (b == -19) {
                        if (b2 < -96) {
                            b = -19;
                            if (!DwgFowqUgqTzLQhc(b3)) {
                                cArr[i] = (char) (((b & 15) << 12) | ((b2 & 63) << 6) | (b3 & 63));
                                return;
                            }
                        }
                    } else if (!DwgFowqUgqTzLQhc(b3)) {
                        cArr[i] = (char) (((b & 15) << 12) | ((b2 & 63) << 6) | (b3 & 63));
                        return;
                    }
                }
            } else if (b == -19) {
                if (b2 < -96) {
                    b = -19;
                    if (!DwgFowqUgqTzLQhc(b3)) {
                        cArr[i] = (char) (((b & 15) << 12) | ((b2 & 63) << 6) | (b3 & 63));
                        return;
                    }
                }
            } else if (!DwgFowqUgqTzLQhc(b3)) {
                cArr[i] = (char) (((b & 15) << 12) | ((b2 & 63) << 6) | (b3 & 63));
                return;
            }
        }
        throw new com.google.android.gms.internal.measurement.zzmm("Protocol message had invalid UTF-8.");
    }

    static void Zzc(byte b, byte b2, char[] cArr, int i) throws com.google.android.gms.internal.measurement.zzmm {
        if (b < -62 || MDMRwnAUQnzSZNPn(b2)) {
            throw new com.google.android.gms.internal.measurement.zzmm("Protocol message had invalid UTF-8.");
        }
        cArr[i] = (char) (((b & 31) << 6) | (b2 & 63));
    }

    static bool Zzd(byte b) {
        return b >= 0;
    }

    private static bool Zze(byte b) {
        return b > -65;
    }
}

