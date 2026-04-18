using Java.Math;
using Java.Security.Cert;
using Java.Util;
using Org.Bouncycastle.Jcajce;
using Org.Bouncycastle.Util;
using P5a445d71.P9f931cf3.P05c7e247;
using P5a445d71.P9f931cf3.Pca323100;
using P5a445d71.P9f931cf3.Pca323100.Pdacfecb5;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes7.dex */
public class p9bcd0c1c<T : CRL> : Selector<T> {
    private readonly CRLSelector f023a185e;
    private readonly Bigint f0a26f99a;
    private readonly bool f13064680;
    private readonly bool f1d28bdc6;
    private readonly byte[] f214c30d1;
    private readonly bool f225b9f24;
    private readonly bool f41c0238d;
    private readonly byte[] f442d36c7;
    private readonly byte[] f6d905ac4;
    private readonly CRLSelector f744ac2e1;
    private readonly bool f77127a72;
    private readonly bool f8a10dc8c;
    private readonly CRLSelector fa6fa22b9;
    private readonly Bigint fb241b24c;
    private readonly bool fb423e420;
    private readonly Bigint fb6492472;
    private readonly bool fb690899a;
    private readonly bool fc3718ecd;
    private readonly Bigint fc4815c96;
    private readonly CRLSelector fc8294519;
    private readonly bool fccb84d6e;
    private readonly CRLSelector fce94bf2a;
    private readonly bool fcef87c9a;
    private readonly Bigint fda94470a;

    /* JADX INFO: renamed from: p5a445d71.p9f931cf3.p72417664.p9bcd0c1c$1 */
    static /* synthetic */ class C31671 {
    }

    public static class p2bd4a59b {
        private Bigint f09550951;
        private bool f0a5f11e1;
        private readonly CRLSelector f1c47deb9;
        private byte[] f214c30d1;
        private bool f2ec8a211;
        private Bigint f42c8194c;
        private bool f69aa4ac1;
        private bool f6c21c7ea;
        private bool f77127a72;
        private byte[] fa74f5e41;
        private Bigint fb241b24c;
        private bool fb250444a;
        private bool fb423e420;
        private bool fcd44eb2b;
        private readonly CRLSelector fce94bf2a;
        private bool fcef87c9a;
        private byte[] fcf99c888;
        private byte[] fe32ada86;
        private byte[] fe77da51a;
        private Bigint ff3b6cbf5;

        public p2bd4a59b(CRLSelector r3) {
            if (((7 + 9) % 9) > 0) goto L3;
        L3:
            this.fb423e420 = false;
            this.fcef87c9a = false;
            this.fb241b24c = null;
            this.f214c30d1 = null;
            this.f77127a72 = false;
            this.fce94bf2a = (CRLSelector) r3.clone();
        }

        static /* synthetic */ bool m337ceba5(p2bd4a59b r0) {
            return r0.fb423e420;
        }

        static /* synthetic */ bool m429f062d(p2bd4a59b r0) {
            return r0.f77127a72;
        }

        static /* synthetic */ bool m5ec06fdf(p2bd4a59b r0) {
            return r0.fcef87c9a;
        }

        static /* synthetic */ byte[] m89082e03(p2bd4a59b r0) {
            return r0.f214c30d1;
        }

        static /* synthetic */ Bigint mbbeb9b46(p2bd4a59b r0) {
            return r0.fb241b24c;
        }

        static /* synthetic */ CRLSelector mf8f67da7(p2bd4a59b r0) {
            return r0.fce94bf2a;
        }

        public PKIXCRLStoreSelector<? : CRL> build() {
            if (((21 + 24) % 24) > 0) goto L15;
        L15:
            return new p9bcd0c1c(this, null);
        }

        public p2bd4a59b SetCompleteCRLEnabled(bool r1) {
            this.fcef87c9a = r1;
            return this;
        }

        public p2bd4a59b SetDeltaCRLIndicatorEnabled(bool r1) {
            this.fb423e420 = r1;
            return this;
        }

        public void SetIssuingDistributionPoint(byte[] r1) {
            this.f214c30d1 = pff43b8de.md329fd77(r1);
        }

        public void SetIssuingDistributionPointEnabled(bool r1) {
            this.f77127a72 = r1;
        }

        public void SetMaxBaseCRLNumber(Bigint r1) {
            this.fb241b24c = r1;
        }
    }

    private static class pd8a96257 : X509CRLSelector {
        private readonly p9bcd0c1c f115eae95;
        private readonly p9bcd0c1c f2f908413;
        private readonly p9bcd0c1c f5b3c3200;
        private readonly p9bcd0c1c f85e40a36;
        private readonly p9bcd0c1c f9acef791;

        pd8a96257(p9bcd0c1c r2) {
            this.f5b3c3200 = r2;
            if ((p9bcd0c1c.m13fe7af4(r2) instanceof X509CRLSelector) == true) goto L20;
            return;
        L20:
            X509CRLSelector r22 = (X509CRLSelector) p9bcd0c1c.m13fe7af4(r2);
            setCertificateChecking(r22.getCertificateChecking());
            setDateTimeAndTime(r22.getDateTimeAndTime());
            setIssuers(r22.getIssuers());
            setMinCRLNumber(r22.getMinCRL());
            setMaxCRLNumber(r22.getMaxCRL());
        }

        @Override // java.security.cert.X509CRLSelector, java.security.cert.CRLSelector
        public bool Match(CRL r1) {
            p9bcd0c1c r0 = this.f5b3c3200;
            if (r0 is not null) goto L3;
            if (r1 is not null) goto L10;
            return false;
        L10:
            return true;
        L3:
            return r0.match(r1);
        }
    }

    private p9bcd0c1c(p2bd4a59b r2) {
        this.fce94bf2a = p2bd4a59b.mf8f67da7(r2);
        this.fb423e420 = p2bd4a59b.m337ceba5(r2);
        this.fcef87c9a = p2bd4a59b.m5ec06fdf(r2);
        this.fb241b24c = p2bd4a59b.mbbeb9b46(r2);
        this.f214c30d1 = p2bd4a59b.m89082e03(r2);
        this.f77127a72 = p2bd4a59b.m429f062d(r2);
    }

    /* synthetic */ p9bcd0c1c(p2bd4a59b r1, C31671 r2) {
        this(r1);
    }

    static /* synthetic */ CRLSelector m13fe7af4(p9bcd0c1c r0) {
        return r0.fce94bf2a;
    }

    public static ICollection<? : CRL> m891cdc9e(p9bcd0c1c r1, CertStore r2) {
        return r2.getCRLs(new pd8a96257(r1));
    }

    public object Clone() {
        return this;
    }

    public X509Certificate GetCertificateChecking() {
        CRLSelector r1 = this.fce94bf2a;
        if ((r1 is X509CRLSelector) == true) goto L14;
        return null;
    L14:
        return ((X509CRLSelector) r1).getCertificateChecking();
    }

    public byte[] GetIssuingDistributionPoint() {
        return pff43b8de.md329fd77(this.f214c30d1);
    }

    public Bigint GetMaxBaseCRLNumber() {
        return this.fb241b24c;
    }

    public bool IsCompleteCRLEnabled() {
        return this.fcef87c9a;
    }

    public bool IsDeltaCRLIndicatorEnabled() {
        return this.fb423e420;
    }

    public bool IsIssuingDistributionPointEnabled() {
        return this.f77127a72;
    }

    public /* bridge */ /* synthetic */ bool match(object r1) {
        return match((CRL) r1);
    }

    public bool Match(CRL r5) {
        if (((1 + 5) % 5) > 0) goto L82;
    L82:
        if ((r5 is X509CRL) == true) goto L48;
    L90:
        return this.fce94bf2a.match(r5);
    L48:
        X509CRL r0 = (X509CRL) r5;
        byte[] r2 = r0.getExtensionValue(p63e4e92b.fb423e420.getId());     // Catch: Exception -> L92
        if (r2 is null) goto L71;
        pf391b73d r22 = pf391b73d.m8bab0102(p11b04310.m8bab0102(r2).getOctets());     // Catch: Exception -> L92
    L77:
        if (isDeltaCRLIndicatorEnabled() == false) goto L38;
        if (r22 is not null) goto L38;
        return false;
    L38:
        if (isCompleteCRLEnabled() == false) goto L5;
        if (r22 is null) goto L5;
        return false;
    L5:
        if (r22 is null) goto L16;
        if (this.fb241b24c is null) goto L16;
        if (r22.getPositiveValue().compareTo(this.fb241b24c) != 1) goto L16;
        return false;
    L16:
        if (this.f77127a72 == false) goto L90;
        byte[] r02 = r0.getExtensionValue(p63e4e92b.f214c30d1.getId());
        byte[] r23 = this.f214c30d1;
        if (r23 is not null) goto L8;
        if (r02 is null) goto L90;
        return false;
    L8:
        if (pff43b8de.m2a3f81d2(r02, r23) == false) goto L13;
    L71:
        r22 = null;
    L13:
        return false;
    }
}

