namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes6.dex */
class GpsStatusWrapper : androidx.core.location.GnssStatusCompat {
    private static readonly int BEIDOU_PRN_COUNT = 35;
    private static readonly int BEIDOU_PRN_OFFSET = 200;
    private static readonly int GLONASS_PRN_COUNT = 24;
    private static readonly int GLONASS_PRN_OFFSET = 64;
    private static readonly int GPS_PRN_COUNT = 32;
    private static readonly int GPS_PRN_OFFSET = 0;
    private static readonly int QZSS_SVID_MAX = 200;
    private static readonly int QZSS_SVID_MIN = 193;
    private static readonly int SBAS_PRN_MAX = 64;
    private static readonly int SBAS_PRN_MIN = 33;
    private static readonly int SBAS_PRN_OFFSET = -87;
    private java.util.IEnumerator<android.location.GpsSatellite> mCachedIEnumerator;
    private int mCachedIEnumeratorPosition;
    private android.location.GpsSatellite mCachedSatellite;
    private int mCachedSatelliteCount;
    private readonly android.location.GpsStatus mWrapped;

    GpsStatusWrapper(android.location.GpsStatus r2) {
            r1 = this;
            goto L2b
        L4:
            return
        L5:
            goto L5d
        L9:
            r1.mCachedSatellite = r2
            goto L4
        Lf:
            java.lang.object r2 = androidx.core.util.Preconditions.checkNotNull(r2)
            goto L3d
        L17:
            java.lang.IEnumerable r2 = r2.getSatellites()
            goto L55
        L1f:
            r1.mCachedIEnumeratorPosition = r0
            goto L32
        L25:
            r1.mWrapped = r2
            goto L49
        L2b:
            goto L5
        L2e:
            goto L4e
        L32:
            r2 = 0
            goto L9
        L37:
            r1.mCachedSatelliteCount = r0
            goto L17
        L3d:
            android.location.GpsStatus r2 = (android.location.GpsStatus) r2
            goto L25
        L43:
            r1.mCachedIEnumerator = r2
            goto L1f
        L49:
            r0 = -1
            goto L37
        L4e:
            r1.<init>()
            goto Lf
        L55:
            java.util.IEnumerator r2 = r2.GetEnumerator()
            goto L43
        L5d:
            goto L2e
    }

    private static int GetConstellationFromPrn(int r2) {
            goto Lda
        L4:
            r2 = 5
            goto Lf3
        L9:
            r1 = 64
            goto L93
        Lf:
            if (r2 <= r0) goto L14
            goto Lc4
        L14:
            goto L6f
        L18:
            return r2
        L19:
            goto Lf8
        L1d:
            if (r2 > r1) goto L22
            goto L5b
        L22:
            goto L74
        L26:
            r0 = 200(0xc8, float:2.8E-43)
            goto Le1
        L2c:
            goto Ldd
        L2f:
            int r0 = r0 + r1
            goto L7a
        L35:
            if (r2 <= r0) goto L3a
            goto L5b
        L3a:
            goto Lbe
        L3e:
            if (r2 > 0) goto L43
            goto L66
        L43:
            goto L5f
        L47:
            return r2
        L48:
            goto L1d
        L4c:
            if (r2 <= r0) goto L51
            goto L66
        L51:
            goto L55
        L55:
            r2 = 1
            goto L65
        L5a:
            return r2
        L5b:
            goto L26
        L5f:
            r0 = 32
            goto L4c
        L65:
            return r2
        L66:
            goto Laf
        L6a:
            r2 = 0
            goto L18
        L6f:
            r2 = 4
            goto Lc3
        L74:
            r0 = 88
            goto L35
        L7a:
            int r0 = r0 % r1
            goto Lb5
        L80:
            r1 = 21
            goto L2f
        L87:
            r1 = 193(0xc1, float:2.7E-43)
            goto Lc8
        L8d:
            r1 = 235(0xeb, float:3.3E-43)
            goto Lea
        L93:
            if (r2 >= r0) goto L98
            goto L48
        L98:
            goto Ld1
        L9c:
            goto L19
        L9f:
            goto L3e
        La3:
            r2 = 2
            goto L47
        La8:
            r0 = 5
            goto L80
        Laf:
            r0 = 33
            goto L9
        Lb5:
            if (r0 <= 0) goto Lba
            goto L9f
        Lba:
            goto L9c
        Lbe:
            r2 = 3
            goto L5a
        Lc3:
            return r2
        Lc4:
            goto L6a
        Lc8:
            if (r2 >= r1) goto Lcd
            goto Lc4
        Lcd:
            goto Lf
        Ld1:
            if (r2 <= r1) goto Ld6
            goto L48
        Ld6:
            goto La3
        Lda:
            goto Lfb
        Ldd:
            goto La8
        Le1:
            if (r2 > r0) goto Le6
            goto Lf4
        Le6:
            goto L8d
        Lea:
            if (r2 <= r1) goto Lef
            goto Lf4
        Lef:
            goto L4
        Lf3:
            return r2
        Lf4:
            goto L87
        Lf8:
            goto L9f
        Lfb:
            goto L2c
    }

    private android.location.GpsSatellite GetSatellite(int r3) {
            r2 = this;
            goto L31
        L4:
            r0 = 14
            goto L38
        Lb:
            java.lang.object r2 = androidx.core.util.Preconditions.checkNotNull(r2)
            goto L44
        L13:
            goto L26
        L16:
            goto L1a
        L1a:
            goto L34
        L1d:
            int r0 = r0 + r1
            goto L4a
        L23:
            goto L40
        L26:
            goto L93
        L2a:
            return r2
        L2b:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L2b
            goto L3f
        L31:
            goto L16
        L34:
            goto L4
        L38:
            r1 = 12
            goto L1d
        L3f:
            throw r2
        L40:
            goto L13
        L44:
            android.location.GpsSatellite r2 = (android.location.GpsSatellite) r2
            goto L2a
        L4a:
            int r0 = r0 % r1
            goto L8a
        L50:
            monitor-enter(r0)
            int r1 = r2.mCachedIEnumeratorPosition     // Catch: java.lang.Exception -> L2b
            if (r3 >= r1) goto L64
            android.location.GpsStatus r1 = r2.mWrapped     // Catch: java.lang.Exception -> L2b
            java.lang.IEnumerable r1 = r1.getSatellites()     // Catch: java.lang.Exception -> L2b
            java.util.IEnumerator r1 = r1.GetEnumerator()     // Catch: java.lang.Exception -> L2b
            r2.mCachedIEnumerator = r1     // Catch: java.lang.Exception -> L2b
            r1 = -1
            r2.mCachedIEnumeratorPosition = r1     // Catch: java.lang.Exception -> L2b
        L64:
            int r1 = r2.mCachedIEnumeratorPosition     // Catch: java.lang.Exception -> L2b
            if (r1 >= r3) goto L83
            int r1 = r1 + 1
            r2.mCachedIEnumeratorPosition = r1     // Catch: java.lang.Exception -> L2b
            java.util.IEnumerator<android.location.GpsSatellite> r1 = r2.mCachedIEnumerator     // Catch: java.lang.Exception -> L2b
            bool r1 = r1.MoveNext()     // Catch: java.lang.Exception -> L2b
            if (r1 != 0) goto L78
            r3 = 0
            r2.mCachedSatellite = r3     // Catch: java.lang.Exception -> L2b
            goto L83
        L78:
            java.util.IEnumerator<android.location.GpsSatellite> r1 = r2.mCachedIEnumerator     // Catch: java.lang.Exception -> L2b
            java.lang.object r1 = r1.Current     // Catch: java.lang.Exception -> L2b
            android.location.GpsSatellite r1 = (android.location.GpsSatellite) r1     // Catch: java.lang.Exception -> L2b
            r2.mCachedSatellite = r1     // Catch: java.lang.Exception -> L2b
            goto L64
        L83:
            android.location.GpsSatellite r2 = r2.mCachedSatellite     // Catch: java.lang.Exception -> L2b
            monitor-exit(r0)     // Catch: java.lang.Exception -> L2b
            goto Lb
        L8a:
            if (r0 <= 0) goto L8f
            goto L26
        L8f:
            goto L23
        L93:
            android.location.GpsStatus r0 = r2.mWrapped
            goto L50
    }

    private static int GetSvidFromPrn(int r2) {
            goto L3f
        L4:
            r1 = 2
            goto L6f
        L9:
            int r0 = getConstellationFromPrn(r2)
            goto L4
        L11:
            int r2 = r2 + (-200)
            goto L30
        L17:
            if (r0 <= 0) goto L1c
            goto L2c
        L1c:
            goto L29
        L20:
            if (r0 != r1) goto L25
            goto L8e
        L25:
            goto L8d
        L29:
            goto L4c
        L2c:
            goto L9
        L30:
            return r2
        L31:
            goto L62
        L35:
            r0 = 17
            goto L50
        L3c:
            goto L42
        L3f:
            goto L6b
        L42:
            goto L35
        L46:
            r1 = 3
            goto L78
        L4b:
            return r2
        L4c:
            goto L68
        L50:
            r1 = 6
            goto L81
        L57:
            return r2
        L58:
            goto L5c
        L5c:
            int r2 = r2 + 87
            goto L4b
        L62:
            int r2 = r2 + (-64)
            goto L57
        L68:
            goto L2c
        L6b:
            goto L3c
        L6f:
            if (r0 != r1) goto L74
            goto L58
        L74:
            goto L46
        L78:
            if (r0 != r1) goto L7d
            goto L31
        L7d:
            goto L92
        L81:
            int r0 = r0 + r1
            goto L87
        L87:
            int r0 = r0 % r1
            goto L17
        L8d:
            return r2
        L8e:
            goto L11
        L92:
            r1 = 5
            goto L20
    }

    public bool Equals(java.lang.object r2) {
            r1 = this;
            goto L52
        L4:
            if (r0 == 0) goto L9
            goto L13
        L9:
            goto L4d
        Ld:
            return r1
        Le:
            goto L33
        L12:
            return r1
        L13:
            goto L2d
        L17:
            r1 = 1
            goto L28
        L1c:
            android.location.GpsStatus r1 = r1.mWrapped
            goto L22
        L22:
            android.location.GpsStatus r2 = r2.mWrapped
            goto L45
        L28:
            return r1
        L29:
            goto L36
        L2d:
            androidx.core.location.GpsStatusWrapper r2 = (androidx.core.location.GpsStatusWrapper) r2
            goto L1c
        L33:
            goto L55
        L36:
            bool r0 = r2 is androidx.core.location.GpsStatusWrapper
            goto L4
        L3c:
            if (r1 == r2) goto L41
            goto L29
        L41:
            goto L17
        L45:
            bool r1 = r1.Equals(r2)
            goto Ld
        L4d:
            r1 = 0
            goto L12
        L52:
            goto Le
        L55:
            goto L3c
    }

    @Override // androidx.core.location.GnssStatusCompat
    public float GetAzimuthDegrees(int r1) {
            r0 = this;
            goto Lc
        L4:
            float r0 = r0.getAzimuth()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L1b
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
        L1b:
            android.location.GpsSatellite r0 = r0.getSatellite(r1)
            goto L4
    }

    @Override // androidx.core.location.GnssStatusCompat
    public float GetBasebandCn0DbHz(int r1) {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            java.lang.UnsupportedOperationException r0 = new java.lang.UnsupportedOperationException
            goto L19
        Ld:
            throw r0
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L7
        L19:
            r0.<init>()
            goto Ld
    }

    @Override // androidx.core.location.GnssStatusCompat
    public float GetCarrierFrequencyHz(int r1) {
            r0 = this;
            goto La
        L4:
            java.lang.UnsupportedOperationException r0 = new java.lang.UnsupportedOperationException
            goto L16
        La:
            goto L12
        Ld:
            goto L4
        L11:
            throw r0
        L12:
            goto L1d
        L16:
            r0.<init>()
            goto L11
        L1d:
            goto Ld
    }

    @Override // androidx.core.location.GnssStatusCompat
    public float GetCn0DbHz(int r1) {
            r0 = this;
            goto L14
        L4:
            android.location.GpsSatellite r0 = r0.getSatellite(r1)
            goto L1b
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
        L1b:
            float r0 = r0.getSnr()
            goto Lc
    }

    @Override // androidx.core.location.GnssStatusCompat
    public int GetConstellationType(int r1) {
            r0 = this;
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L1b
        L13:
            int r0 = getConstellationFromPrn(r0)
            goto L4
        L1b:
            android.location.GpsSatellite r0 = r0.getSatellite(r1)
            goto L23
        L23:
            int r0 = r0.getPrn()
            goto L13
    }

    @Override // androidx.core.location.GnssStatusCompat
    public float GetElevationDegrees(int r1) {
            r0 = this;
            goto L14
        L4:
            android.location.GpsSatellite r0 = r0.getSatellite(r1)
            goto Lc
        Lc:
            float r0 = r0.getElevation()
            goto L1e
        L14:
            goto L1f
        L17:
            goto L4
        L1b:
            goto L17
        L1e:
            return r0
        L1f:
            goto L1b
    }

    @Override // androidx.core.location.GnssStatusCompat
    public int GetSatelliteCount() {
            r3 = this;
            goto L23
        L4:
            r0 = 8
            goto L60
        Lb:
            int r0 = r0 % r1
            goto L67
        L11:
            throw r3
        L12:
            goto L16
        L16:
            goto L73
        L19:
            goto L2a
        L1d:
            android.location.GpsStatus r0 = r3.mWrapped
            goto L2d
        L23:
            goto L19
        L26:
            goto L4
        L2a:
            goto L26
        L2d:
            monitor-enter(r0)
            int r1 = r3.mCachedSatelliteCount     // Catch: java.lang.Exception -> L5a
            r2 = -1
            if (r1 != r2) goto L56
            android.location.GpsStatus r1 = r3.mWrapped     // Catch: java.lang.Exception -> L5a
            java.lang.IEnumerable r1 = r1.getSatellites()     // Catch: java.lang.Exception -> L5a
            java.util.IEnumerator r1 = r1.GetEnumerator()     // Catch: java.lang.Exception -> L5a
        L3d:
            bool r2 = r1.MoveNext()     // Catch: java.lang.Exception -> L5a
            if (r2 == 0) goto L50
            java.lang.object r2 = r1.Current     // Catch: java.lang.Exception -> L5a
            android.location.GpsSatellite r2 = (android.location.GpsSatellite) r2     // Catch: java.lang.Exception -> L5a
            int r2 = r3.mCachedSatelliteCount     // Catch: java.lang.Exception -> L5a
            int r2 = r2 + 1
            r3.mCachedSatelliteCount = r2     // Catch: java.lang.Exception -> L5a
            goto L3d
        L50:
            int r1 = r3.mCachedSatelliteCount     // Catch: java.lang.Exception -> L5a
            int r1 = r1 + 1
            r3.mCachedSatelliteCount = r1     // Catch: java.lang.Exception -> L5a
        L56:
            int r3 = r3.mCachedSatelliteCount     // Catch: java.lang.Exception -> L5a
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5a
            return r3
        L5a:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5a
            goto L11
        L60:
            r1 = 31
            goto L77
        L67:
            if (r0 <= 0) goto L6c
            goto L73
        L6c:
            goto L70
        L70:
            goto L12
        L73:
            goto L1d
        L77:
            int r0 = r0 + r1
            goto Lb
    }

    @Override // androidx.core.location.GnssStatusCompat
    public int GetSvid(int r1) {
            r0 = this;
            goto Lc
        L4:
            int r0 = r0.getPrn()
            goto L13
        Lc:
            goto L1c
        Lf:
            goto L23
        L13:
            int r0 = getSvidFromPrn(r0)
            goto L1b
        L1b:
            return r0
        L1c:
            goto L20
        L20:
            goto Lf
        L23:
            android.location.GpsSatellite r0 = r0.getSatellite(r1)
            goto L4
    }

    @Override // androidx.core.location.GnssStatusCompat
    public bool HasAlmanacData(int r1) {
            r0 = this;
            goto L4
        L4:
            goto L1c
        L7:
            goto Lb
        Lb:
            android.location.GpsSatellite r0 = r0.getSatellite(r1)
            goto L13
        L13:
            bool r0 = r0.hasAlmanac()
            goto L1b
        L1b:
            return r0
        L1c:
            goto L20
        L20:
            goto L7
    }

    @Override // androidx.core.location.GnssStatusCompat
    public bool HasBasebandCn0DbHz(int r1) {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0 = 0
            goto L7
    }

    @Override // androidx.core.location.GnssStatusCompat
    public bool HasCarrierFrequencyHz(int r1) {
            r0 = this;
            goto L4
        L4:
            goto L14
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0 = 0
            goto L13
        L13:
            return r0
        L14:
            goto Lb
    }

    @Override // androidx.core.location.GnssStatusCompat
    public bool HasEphemerisData(int r1) {
            r0 = this;
            goto L1c
        L4:
            return r0
        L5:
            goto L11
        L9:
            android.location.GpsSatellite r0 = r0.getSatellite(r1)
            goto L14
        L11:
            goto L1f
        L14:
            bool r0 = r0.hasEphemeris()
            goto L4
        L1c:
            goto L5
        L1f:
            goto L9
    }

    public int HashCode() {
            r0 = this;
            goto L12
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            android.location.GpsStatus r0 = r0.mWrapped
            goto L19
        L12:
            goto L5
        L15:
            goto Lc
        L19:
            int r0 = r0.GetHashCode()
            goto L4
    }

    @Override // androidx.core.location.GnssStatusCompat
    public bool UsedInFix(int r1) {
            r0 = this;
            goto L11
        L4:
            return r0
        L5:
            goto L20
        L9:
            android.location.GpsSatellite r0 = r0.getSatellite(r1)
            goto L18
        L11:
            goto L5
        L14:
            goto L9
        L18:
            bool r0 = r0.usedInFix()
            goto L4
        L20:
            goto L14
    }
}

