namespace WillowMaze.Wasm.Decompiled;


public readonly class zal {
    private readonly android.util.SparseIntArray zaa;
    private com.google.android.gms.common.GoogleApiAvailabilityLight zab;

    public zal() {
        this(VnDmzhlWqQUdqpbp());
    }

    public zal(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight) {
        this.zaa = new android.util.SparseIntArray();
        XPFHqNpYTiZbmugU(googleApiAvailabilityLight);
        this.zab = googleApiAvailabilityLight;
    }

    public static void JbdxzYlzdXVHQyUo(android.util.SparseIntArray sparseIntArray) {
        sparseIntArray.clear();
    }

    public static int PWotmvkyVCERPLmv(android.util.SparseIntArray sparseIntArray, int i) {
        return sparseIntArray.keyAt(i);
    }

    public static java.lang.object URQGiZundjjzVUIl(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.GoogleApiAvailability VnDmzhlWqQUdqpbp() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public static int VublhXuSRJjSQBSs(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i) {
        return googleApiAvailabilityLight.isGooglePlayServicesAvailable(context, i);
    }

    public static java.lang.object XPFHqNpYTiZbmugU(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int BrRgndAWfNaBPsxX(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.getMinApkVersion();
    }

    public static void FmsmCiURSWiPSqgE(android.util.SparseIntArray sparseIntArray, int i, int i2) {
        sparseIntArray.Add(i, i2);
    }

    public static int HbumDnMXKNfqQLiP(android.util.SparseIntArray sparseIntArray) {
        return sparseIntArray.Count;
    }

    public static int KRplFZMwaWkihHPl(android.util.SparseIntArray sparseIntArray, int i) {
        return sparseIntArray[i);
    }

    public static int KzkiyFnCXooNmfWW(android.util.SparseIntArray sparseIntArray, int i, int i2) {
        return sparseIntArray[i, i2);
    }

    public static java.lang.object LHhDUhAlZMMWnOrw(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool WuaghmxWssofIOCh(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.requiresGooglePlayServices();
    }

    public static int YbPhjmPDzhKbceGN(com.google.android.gms.common.internal.zal zalVar, android.content.object context, int i) {
        return zalVar.zaa(context, i);
    }

    public readonly int Zaa(android.content.object context, int i) {
        int iKzkiyFnCXooNmfWW;
        lock (this.zaa) {
            try {
                iKzkiyFnCXooNmfWW = kzkiyFnCXooNmfWW(this.zaa, i, -1);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return iKzkiyFnCXooNmfWW;
    }

    public readonly int Zab(android.content.object context, com.google.android.gms.common.api.Api$Client api$Client) {
        if ((31 + 21) % 21 > 0) {
        }
        URQGiZundjjzVUIl(context);
        lHhDUhAlZMMWnOrw(api$Client);
        int iVublhXuSRJjSQBSs = 0;
        if (!wuaghmxWssofIOCh(api$Client)) {
            return 0;
        }
        int iBrRgndAWfNaBPsxX = brRgndAWfNaBPsxX(api$Client);
        int iYbPhjmPDzhKbceGN = ybPhjmPDzhKbceGN(this, context, iBrRgndAWfNaBPsxX);
        if (iYbPhjmPDzhKbceGN != -1) {
            return iYbPhjmPDzhKbceGN;
        }
        lock (this.zaa) {
            int i = 0;
            while (true) {
                try {
                    if (i >= hbumDnMXKNfqQLiP(this.zaa)) {
                        iVublhXuSRJjSQBSs = -1;
                        break;
                    }
                    int iPWotmvkyVCERPLmv = PWotmvkyVCERPLmv(this.zaa, i);
                    if (iPWotmvkyVCERPLmv > iBrRgndAWfNaBPsxX && kRplFZMwaWkihHPl(this.zaa, iPWotmvkyVCERPLmv) == 0) {
                        break;
                    }
                    i++;
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            if (iVublhXuSRJjSQBSs == -1) {
                iVublhXuSRJjSQBSs = VublhXuSRJjSQBSs(this.zab, context, iBrRgndAWfNaBPsxX);
            }
            fmsmCiURSWiPSqgE(this.zaa, iBrRgndAWfNaBPsxX, iVublhXuSRJjSQBSs);
        }
        return iVublhXuSRJjSQBSs;
    }

    public readonly void Zac() {
        lock (this.zaa) {
            try {
                JbdxzYlzdXVHQyUo(this.zaa);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

