using Java.Io;
using Java.Util;
using P5a445d71.P7c922baa.P05c7e247;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
class p9952cbca {
    private static readonly int f0b5ddd0e = 16;
    private static readonly int f28a70045 = 16;
    private static readonly int f5db61e2a = 12;
    private static readonly int f624371fd = 16;
    private static readonly int f701a7aea = 16;
    private static readonly int f7b9004bb = 12;
    private static readonly int f84f2f941 = 16;
    private static readonly int f8dca7bec = 12;
    private static readonly int fc7e417df = 12;
    private int f0021a2f5;
    private Hashtable f00762b97;
    private Hashtable f146d8cbe;
    private int f1c9fe835;
    private int f25315156;
    private Hashtable f257b6684;
    private Vector f2b72412d;
    private Hashtable f3385a327;
    private int f40af40b6;
    private int f42b1b598;
    private pd80e0f9b f433001f6;
    private p69191579 f48752c32;
    private Hashtable f6913620c;
    private Hashtable f6b0fb8c0;
    private bool f73b27796;
    private bool f80f5f164;
    private pd80e0f9b f8a14b6b5;
    private p69191579 f8c8fa673;
    private pd80e0f9b f8d75ebf4;
    private int f92ab0593;
    private pd80e0f9b f94c56451;
    private p69191579 fa398e9ca;
    private bool fa4c3004f;
    private Vector fbaaec090;
    private Vector fbddb997a;
    private Hashtable fc0a83cdb;
    private int fc9db2b34;
    private pd80e0f9b fd3da5221;
    private Vector fe5233186;

    /* JADX INFO: renamed from: p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p9952cbca$1 */
    class C29951 : pc18e0003 {
        readonly /* synthetic */ p9952cbca this$0;

        C29951(p9952cbca r1) {
            this.this$0 = r1;
        }

        public static void EXZpBqFCKBdYVBya(p9952cbca r0, int r1, int r2, byte[] r3, int r4, int r5, char r6, int r7, string r8, float r9) {
            double r02 = (42 * 210) + 210;
        }

        public static void EXZpBqFCKBdYVBya(p9952cbca r0, int r1, int r2, byte[] r3, int r4, int r5, char r6, string r7, float r8, int r9) {
            double r02 = (42 * 210) + 210;
        }

        public static void EXZpBqFCKBdYVBya(p9952cbca r0, int r1, int r2, byte[] r3, int r4, int r5, string r6, int r7, float r8, char r9) {
            double r02 = (42 * 210) + 210;
        }

        public static bool EXZpBqFCKBdYVBya(p9952cbca r1, int r2, int r3, byte[] r4, int r5, int r6) {
            return p9952cbca.mf8f67da7(r1, r2, r3, r4, r5, r6);
        }

        @Override // p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pc18e0003
        public void ReceivedHandshakeRecord(int r7, byte[] r8, int r9, int r10) {
            if (((10 + 4) % 4) > 0) goto L22;
        L22:
            eXZpBqFCKBdYVBya(this.this$0, 0, r7, r8, r9, r10);
        }
    }

    static class p4c2a8fe7 {
        private readonly int f1c9fe835;
        private readonly short f486af403;
        private readonly byte[] f65097f09;
        private readonly int f6b546849;
        private readonly short f73936967;
        private readonly int f7417cb2c;
        private readonly byte[] f841a2d68;
        private readonly byte[] f90bdefb5;
        private readonly int f995d73cb;
        private readonly short fbaf0d203;
        private readonly byte[] fd8deedf1;
        private readonly short fe91704f0;
        private readonly short ff0f06b8a;

        private p4c2a8fe7(int r1, short r2, byte[] r3) {
            this.f1c9fe835 = r1;
            this.f486af403 = r2;
            this.f841a2d68 = r3;
        }

        /* synthetic */ p4c2a8fe7(int r1, short r2, byte[] r3, C29951 r4) {
            this(r1, r2, r3);
        }

        public byte[] GetBody() {
            return this.f841a2d68;
        }

        public int GetSeq() {
            return this.f1c9fe835;
        }

        public short GetType() {
            return this.f486af403;
        }
    }

    static class pd64e29b7 : byteArrayStream {
        pd64e29b7(int r1) {
            super(r1);
        }

        public static void CUMdLEXtvGnebvSj(p69191579 r0, byte[] r1, int r2, int r3) {
            r0.send(r1, r2, r3);
        }

        public static void CUMdLEXtvGnebvSj(p69191579 r0, byte[] r1, int r2, int r3, char r4, string r5, short r6, bool r7) {
            double r02 = (42 * 210) + 210;
        }

        public static void CUMdLEXtvGnebvSj(p69191579 r0, byte[] r1, int r2, int r3, char r4, short r5, bool r6, string r7) {
            double r02 = (42 * 210) + 210;
        }

        public static void CUMdLEXtvGnebvSj(p69191579 r0, byte[] r1, int r2, int r3, short r4, char r5, bool r6, string r7) {
            double r02 = (42 * 210) + 210;
        }

        void sendToRecordLayer(p69191579 r4) {
            if (((17 + 29) % 29) > 0) goto L8;
        L8:
            cUMdLEXtvGnebvSj(r4, this.fcb7e52b2, 0, this.fe2942a04);
            this.fcb7e52b2 = null;
        }
    }

    p9952cbca(pf1660074 r2, p69191579 r3) {
        this.fc0a83cdb = new Hashtable();
        this.f00762b97 = null;
        this.fbaaec090 = new Vector();
        this.f80f5f164 = true;
        this.f1c9fe835 = 0;
        this.f25315156 = 0;
        this.fa398e9ca = r3;
        pe756be08 r32 = new pe756be08();
        this.fd3da5221 = r32;
        SgrtQdqpoZGzxheV(r32, r2);
    }

    public static pd80e0f9b AKCTHAhgIIPfLzgb(pd80e0f9b r1) {
        return r1.stopTracking();
    }

    public static void AKCTHAhgIIPfLzgb(pd80e0f9b r0, char r1, string r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AKCTHAhgIIPfLzgb(pd80e0f9b r0, char r1, bool r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AKCTHAhgIIPfLzgb(pd80e0f9b r0, char r1, bool r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static short AMPWWsMiUhBZQqCW(p4c2a8fe7 r1) {
        return r1.getType();
    }

    public static void AMPWWsMiUhBZQqCW(p4c2a8fe7 r0, string r1, float r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AMPWWsMiUhBZQqCW(p4c2a8fe7 r0, bool r1, char r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AMPWWsMiUhBZQqCW(p4c2a8fe7 r0, bool r1, string r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AxIMxxKeKQxpkigZ(p9952cbca r0, Hashtable r1) {
        r0.m20154465(r1);
    }

    public static void AxIMxxKeKQxpkigZ(p9952cbca r0, Hashtable r1, int r2, bool r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AxIMxxKeKQxpkigZ(p9952cbca r0, Hashtable r1, short r2, int r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AxIMxxKeKQxpkigZ(p9952cbca r0, Hashtable r1, bool r2, short r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BpYjDopWbzPHXOEa(Hashtable r0) {
        mda4fa842(r0);
    }

    public static void BpYjDopWbzPHXOEa(Hashtable r0, short r1, string r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BpYjDopWbzPHXOEa(Hashtable r0, bool r1, short r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BpYjDopWbzPHXOEa(Hashtable r0, bool r1, short r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CxFaingeNVqYhglQ(int r0, byte[] r1, int r2) {
        pdf513157.mfa398cb1(r0, r1, r2);
    }

    public static void CxFaingeNVqYhglQ(int r0, byte[] r1, int r2, float r3, bool r4, short r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void CxFaingeNVqYhglQ(int r0, byte[] r1, int r2, short r3, float r4, bool r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void CxFaingeNVqYhglQ(int r0, byte[] r1, int r2, bool r3, int r4, float r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void DMfQRtMZugaFgNfG(pd80e0f9b r0) {
        r0.reset();
    }

    public static void DMfQRtMZugaFgNfG(pd80e0f9b r0, char r1, short r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DMfQRtMZugaFgNfG(pd80e0f9b r0, short r1, byte r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DMfQRtMZugaFgNfG(pd80e0f9b r0, short r1, string r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int DReiLKRehsSqcGtF(int r1) {
        return pf74464bf.m1adac6f4(r1);
    }

    public static void DReiLKRehsSqcGtF(int r0, float r1, char r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DReiLKRehsSqcGtF(int r0, int r1, short r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DReiLKRehsSqcGtF(int r0, short r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Enumeration FJNrmJzIOXVvCzjy(Hashtable r1) {
        return r1.keys();
    }

    public static void FJNrmJzIOXVvCzjy(Hashtable r0, byte r1, int r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FJNrmJzIOXVvCzjy(Hashtable r0, string r1, byte r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FJNrmJzIOXVvCzjy(Hashtable r0, string r1, int r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FXupJaaUrMBvBUVM(p4c2a8fe7 r0, char r1, byte r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FXupJaaUrMBvBUVM(p4c2a8fe7 r0, char r1, byte r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FXupJaaUrMBvBUVM(p4c2a8fe7 r0, float r1, byte r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] FXupJaaUrMBvBUVM(p4c2a8fe7 r1) {
        return r1.getBody();
    }

    public static short GVwIhBLLAaZcPxlb(p4c2a8fe7 r1) {
        return r1.getType();
    }

    public static void GVwIhBLLAaZcPxlb(p4c2a8fe7 r0, byte r1, float r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GVwIhBLLAaZcPxlb(p4c2a8fe7 r0, char r1, short r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GVwIhBLLAaZcPxlb(p4c2a8fe7 r0, short r1, byte r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GvvqrWaabRmWXHMa(int r0, byte[] r1, int r2) {
        pdf513157.mfa398cb1(r0, r1, r2);
    }

    public static void GvvqrWaabRmWXHMa(int r0, byte[] r1, int r2, char r3, string r4, int r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void GvvqrWaabRmWXHMa(int r0, byte[] r1, int r2, short r3, char r4, int r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void GvvqrWaabRmWXHMa(int r0, byte[] r1, int r2, short r3, string r4, char r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void HDwrRsemOFERGzfA(short r0, byte[] r1, int r2) {
        pdf513157.m086ef097(r0, r1, r2);
    }

    public static void HDwrRsemOFERGzfA(short r0, byte[] r1, int r2, char r3, string r4, int r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void HDwrRsemOFERGzfA(short r0, byte[] r1, int r2, float r3, int r4, string r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void HDwrRsemOFERGzfA(short r0, byte[] r1, int r2, string r3, char r4, int r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void HXAFHvXZkDDYHcET(p69191579 r0, pc18e0003 r1) {
        r0.handshakeSuccessful(r1);
    }

    public static void HXAFHvXZkDDYHcET(p69191579 r0, pc18e0003 r1, char r2, float r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HXAFHvXZkDDYHcET(p69191579 r0, pc18e0003 r1, float r2, short r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HXAFHvXZkDDYHcET(p69191579 r0, pc18e0003 r1, bool r2, float r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static pd80e0f9b HXkCglfQIbswUudv(pd80e0f9b r1) {
        return r1.notifyPRFDetermined();
    }

    public static void HXkCglfQIbswUudv(pd80e0f9b r0, byte r1, short r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HXkCglfQIbswUudv(pd80e0f9b r0, short r1, byte r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HXkCglfQIbswUudv(pd80e0f9b r0, short r1, bool r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IUzwetknVxcbkOUr(short r0, Stream r1) {
        pdf513157.m086ef097(r0, r1);
    }

    public static void IUzwetknVxcbkOUr(short r0, Stream r1, byte r2, bool r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IUzwetknVxcbkOUr(short r0, Stream r1, bool r2, char r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IUzwetknVxcbkOUr(short r0, Stream r1, bool r2, short r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IczsOYFNdWmddWCx(pd64e29b7 r0, p69191579 r1) {
        r0.sendToRecordLayer(r1);
    }

    public static void IczsOYFNdWmddWCx(pd64e29b7 r0, p69191579 r1, float r2, short r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IczsOYFNdWmddWCx(pd64e29b7 r0, p69191579 r1, int r2, short r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IczsOYFNdWmddWCx(pd64e29b7 r0, p69191579 r1, short r2, int r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IkmchghbEhbXcbPY(p4c2a8fe7 r0, float r1, byte r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IkmchghbEhbXcbPY(p4c2a8fe7 r0, float r1, char r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IkmchghbEhbXcbPY(p4c2a8fe7 r0, short r1, char r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] IkmchghbEhbXcbPY(p4c2a8fe7 r1) {
        return r1.getBody();
    }

    public static int JSkVQhETRmLrcCZL(int r1, int r2) {
        return Math.min(r1, r2);
    }

    public static void JSkVQhETRmLrcCZL(int r0, int r1, char r2, float r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JSkVQhETRmLrcCZL(int r0, int r1, char r2, float r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JSkVQhETRmLrcCZL(int r0, int r1, float r2, char r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static Enumeration JrfmbiGlvOyMjZyl(Hashtable r1) {
        return r1.elements();
    }

    public static void JrfmbiGlvOyMjZyl(Hashtable r0, byte r1, string r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JrfmbiGlvOyMjZyl(Hashtable r0, string r1, byte r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JrfmbiGlvOyMjZyl(Hashtable r0, bool r1, int r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int JxuEYBdVHviKLHZw(byte[] r1, int r2) {
        return pdf513157.m6f5324c0(r1, r2);
    }

    public static void JxuEYBdVHviKLHZw(byte[] r0, int r1, byte r2, char r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JxuEYBdVHviKLHZw(byte[] r0, int r1, char r2, float r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JxuEYBdVHviKLHZw(byte[] r0, int r1, short r2, float r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static p4c2a8fe7 LaRZAsKqHQWdVueG(p9952cbca r1, p4c2a8fe7 r2) {
        return r1.m0e99ae68(r2);
    }

    public static void LaRZAsKqHQWdVueG(p9952cbca r0, p4c2a8fe7 r1, byte r2, short r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LaRZAsKqHQWdVueG(p9952cbca r0, p4c2a8fe7 r1, byte r2, short r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LaRZAsKqHQWdVueG(p9952cbca r0, p4c2a8fe7 r1, short r2, char r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MospwwVOogsnBRXV(p4c2a8fe7 r0, bool r1, char r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void MospwwVOogsnBRXV(p4c2a8fe7 r0, bool r1, float r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void MospwwVOogsnBRXV(p4c2a8fe7 r0, bool r1, short r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] MospwwVOogsnBRXV(p4c2a8fe7 r1) {
        return r1.getBody();
    }

    public static void OrceBbCWoUGxiPOV(int r0, Stream r1) {
        pdf513157.mfa398cb1(r0, r1);
    }

    public static void OrceBbCWoUGxiPOV(int r0, Stream r1, float r2, int r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OrceBbCWoUGxiPOV(int r0, Stream r1, int r2, float r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OrceBbCWoUGxiPOV(int r0, Stream r1, bool r2, char r3, int r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PaExQpetleBabogD(pd80e0f9b r0, byte[] r1, int r2, int r3) {
        r0.update(r1, r2, r3);
    }

    public static void PaExQpetleBabogD(pd80e0f9b r0, byte[] r1, int r2, int r3, byte r4, bool r5, short r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void PaExQpetleBabogD(pd80e0f9b r0, byte[] r1, int r2, int r3, short r4, bool r5, byte r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void PaExQpetleBabogD(pd80e0f9b r0, byte[] r1, int r2, int r3, bool r4, byte r5, short r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static int QABXuPfpGqPjxbQT(byte[] r1, int r2) {
        return pdf513157.m6ecd94f2(r1, r2);
    }

    public static void QABXuPfpGqPjxbQT(byte[] r0, int r1, byte r2, short r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QABXuPfpGqPjxbQT(byte[] r0, int r1, int r2, bool r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QABXuPfpGqPjxbQT(byte[] r0, int r1, short r2, byte r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RxrroGoeDcKvsQMe(Enumeration r0, byte r1, char r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RxrroGoeDcKvsQMe(Enumeration r0, int r1, short r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RxrroGoeDcKvsQMe(Enumeration r0, short r1, char r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool RxrroGoeDcKvsQMe(Enumeration r1) {
        return r1.hasMoreElements();
    }

    public static void ScGCmDGQrpRFZhLS(int r0, Stream r1) {
        pdf513157.mfa398cb1(r0, r1);
    }

    public static void ScGCmDGQrpRFZhLS(int r0, Stream r1, byte r2, float r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ScGCmDGQrpRFZhLS(int r0, Stream r1, string r2, char r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ScGCmDGQrpRFZhLS(int r0, Stream r1, string r2, float r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SgrtQdqpoZGzxheV(pd80e0f9b r0, pf1660074 r1) {
        r0.init(r1);
    }

    public static void SgrtQdqpoZGzxheV(pd80e0f9b r0, pf1660074 r1, float r2, int r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SgrtQdqpoZGzxheV(pd80e0f9b r0, pf1660074 r1, float r2, string r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SgrtQdqpoZGzxheV(pd80e0f9b r0, pf1660074 r1, short r2, string r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TcvdcyCLAffQczTA(pe86669cd r0, short r1, int r2, byte[] r3, int r4, int r5, int r6) {
        r0.contributeobject(r1, r2, r3, r4, r5, r6);
    }

    public static void TcvdcyCLAffQczTA(pe86669cd r0, short r1, int r2, byte[] r3, int r4, int r5, int r6, char r7, float r8, short r9, int r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void TcvdcyCLAffQczTA(pe86669cd r0, short r1, int r2, byte[] r3, int r4, int r5, int r6, float r7, char r8, int r9, short r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void TcvdcyCLAffQczTA(pe86669cd r0, short r1, int r2, byte[] r3, int r4, int r5, int r6, int r7, char r8, short r9, float r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void TqElaVgpqVSzBTmN(Enumeration r0, float r1, int r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TqElaVgpqVSzBTmN(Enumeration r0, int r1, short r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TqElaVgpqVSzBTmN(Enumeration r0, short r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool TqElaVgpqVSzBTmN(Enumeration r1) {
        return r1.hasMoreElements();
    }

    public static short UGPmVvJNBjwWJLRm(p4c2a8fe7 r1) {
        return r1.getType();
    }

    public static void UGPmVvJNBjwWJLRm(p4c2a8fe7 r0, char r1, byte r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UGPmVvJNBjwWJLRm(p4c2a8fe7 r0, char r1, bool r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UGPmVvJNBjwWJLRm(p4c2a8fe7 r0, float r1, bool r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int VGtcPuLfbzrmMTbC(byte[] r1, int r2) {
        return pdf513157.m6f5324c0(r1, r2);
    }

    public static void VGtcPuLfbzrmMTbC(byte[] r0, int r1, byte r2, float r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VGtcPuLfbzrmMTbC(byte[] r0, int r1, int r2, byte r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VGtcPuLfbzrmMTbC(byte[] r0, int r1, bool r2, float r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VJaOJjLZsqcXRnqg(p9952cbca r0, p4c2a8fe7 r1, int r2, int r3) {
        r0.m9331930a(r1, r2, r3);
    }

    public static void VJaOJjLZsqcXRnqg(p9952cbca r0, p4c2a8fe7 r1, int r2, int r3, int r4, float r5, string r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void VJaOJjLZsqcXRnqg(p9952cbca r0, p4c2a8fe7 r1, int r2, int r3, string r4, float r5, int r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void VJaOJjLZsqcXRnqg(p9952cbca r0, p4c2a8fe7 r1, int r2, int r3, string r4, bool r5, float r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void VOEllBPKbOJyFlQY(pd64e29b7 r0, byte[] r1, int r2, int r3) {
        r0.write(r1, r2, r3);
    }

    public static void VOEllBPKbOJyFlQY(pd64e29b7 r0, byte[] r1, int r2, int r3, char r4, int r5, bool r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void VOEllBPKbOJyFlQY(pd64e29b7 r0, byte[] r1, int r2, int r3, int r4, short r5, bool r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void VOEllBPKbOJyFlQY(pd64e29b7 r0, byte[] r1, int r2, int r3, short r4, int r5, bool r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static object WHxqwRHEffyFfQJm(Vector r1, int r2) {
        return r1.elementAt(r2);
    }

    public static void WHxqwRHEffyFfQJm(Vector r0, int r1, int r2, string r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WHxqwRHEffyFfQJm(Vector r0, int r1, int r2, bool r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WHxqwRHEffyFfQJm(Vector r0, int r1, bool r2, string r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WQsiVOFttHzDvTOn(p9952cbca r0, p4c2a8fe7 r1) {
        r0.mf4fcfad1(r1);
    }

    public static void WQsiVOFttHzDvTOn(p9952cbca r0, p4c2a8fe7 r1, char r2, short r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WQsiVOFttHzDvTOn(p9952cbca r0, p4c2a8fe7 r1, short r2, char r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WQsiVOFttHzDvTOn(p9952cbca r0, p4c2a8fe7 r1, bool r2, string r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int WhswVdJyBvpFdsnk(Vector r1) {
        return r1.Count;
    }

    public static void WhswVdJyBvpFdsnk(Vector r0, byte r1, string r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WhswVdJyBvpFdsnk(Vector r0, int r1, string r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WhswVdJyBvpFdsnk(Vector r0, string r1, byte r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int WiiHmoFsnUIvgMlj(p9952cbca r1, int r2) {
        return r1.m790d9b55(r2);
    }

    public static void WiiHmoFsnUIvgMlj(p9952cbca r0, int r1, byte r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WiiHmoFsnUIvgMlj(p9952cbca r0, int r1, byte r2, bool r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WiiHmoFsnUIvgMlj(p9952cbca r0, int r1, short r2, byte r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WoPgsIUcspPSyGQt(pd80e0f9b r0, byte[] r1, int r2, int r3) {
        r0.update(r1, r2, r3);
    }

    public static void WoPgsIUcspPSyGQt(pd80e0f9b r0, byte[] r1, int r2, int r3, char r4, string r5, bool r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void WoPgsIUcspPSyGQt(pd80e0f9b r0, byte[] r1, int r2, int r3, bool r4, char r5, float r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void WoPgsIUcspPSyGQt(pd80e0f9b r0, byte[] r1, int r2, int r3, bool r4, float r5, string r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static int WplcIyrrkSXrqVMM(int r1) {
        return r1.intValue();
    }

    public static void WplcIyrrkSXrqVMM(int r0, char r1, float r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WplcIyrrkSXrqVMM(int r0, float r1, char r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WplcIyrrkSXrqVMM(int r0, bool r1, float r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object WuZHMrCQNwxjCOMG(Hashtable r1, object r2) {
        return r1[r2);
    }

    public static void WuZHMrCQNwxjCOMG(Hashtable r0, object r1, char r2, float r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WuZHMrCQNwxjCOMG(Hashtable r0, object r1, char r2, int r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WuZHMrCQNwxjCOMG(Hashtable r0, object r1, char r2, int r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XbFmuQtToJEklBMl(Hashtable r0, float r1, short r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XbFmuQtToJEklBMl(Hashtable r0, bool r1, char r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XbFmuQtToJEklBMl(Hashtable r0, bool r1, float r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool XbFmuQtToJEklBMl(Hashtable r1) {
        return m26098859(r1);
    }

    public static object XrGTBmQbjgQjDjgI(Enumeration r1) {
        return r1.nextElement();
    }

    public static void XrGTBmQbjgQjDjgI(Enumeration r0, float r1, int r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XrGTBmQbjgQjDjgI(Enumeration r0, float r1, string r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XrGTBmQbjgQjDjgI(Enumeration r0, string r1, bool r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AuhBwHbizdkcSeGY(pe86669cd r0, byte r1, int r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AuhBwHbizdkcSeGY(pe86669cd r0, char r1, int r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AuhBwHbizdkcSeGY(pe86669cd r0, int r1, char r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] AuhBwHbizdkcSeGY(pe86669cd r1) {
        return r1.getBodyIfComplete();
    }

    public static int AyFVLZxLpRPqacSU(p4c2a8fe7 r1) {
        return r1.getSeq();
    }

    public static void AyFVLZxLpRPqacSU(p4c2a8fe7 r0, byte r1, char r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AyFVLZxLpRPqacSU(p4c2a8fe7 r0, char r1, short r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AyFVLZxLpRPqacSU(p4c2a8fe7 r0, short r1, char r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BnJuLrvmsjlltkdC(Hashtable r0) {
        mda4fa842(r0);
    }

    public static void BnJuLrvmsjlltkdC(Hashtable r0, char r1, string r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BnJuLrvmsjlltkdC(Hashtable r0, string r1, float r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BnJuLrvmsjlltkdC(Hashtable r0, short r1, string r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CJDPwWCSDToxUdLm(Vector r0) {
        r0.removeAllElements();
    }

    public static void CJDPwWCSDToxUdLm(Vector r0, byte r1, short r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CJDPwWCSDToxUdLm(Vector r0, string r1, char r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CJDPwWCSDToxUdLm(Vector r0, string r1, short r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static short CiUjWcIvnLiTOrKi(byte[] r1, int r2) {
        return pdf513157.mb65df5aa(r1, r2);
    }

    public static void CiUjWcIvnLiTOrKi(byte[] r0, int r1, float r2, int r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CiUjWcIvnLiTOrKi(byte[] r0, int r1, int r2, string r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CiUjWcIvnLiTOrKi(byte[] r0, int r1, string r2, float r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DLTMyLDZDvowIIis(p9952cbca r0) {
        r0.m630f20ad();
    }

    public static void DLTMyLDZDvowIIis(p9952cbca r0, int r1, char r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DLTMyLDZDvowIIis(p9952cbca r0, short r1, int r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DLTMyLDZDvowIIis(p9952cbca r0, short r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DNkGmrdLPpbxNVbT(int r0, Stream r1) {
        pdf513157.m49d72085(r0, r1);
    }

    public static void DNkGmrdLPpbxNVbT(int r0, Stream r1, char r2, int r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DNkGmrdLPpbxNVbT(int r0, Stream r1, char r2, bool r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DNkGmrdLPpbxNVbT(int r0, Stream r1, int r2, short r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DbGPLIwTLJuffisD(p9952cbca r0, int r1, int r2, byte[] r3, int r4, int r5, byte r6, string r7, short r8, char r9) {
        double r02 = (42 * 210) + 210;
    }

    public static void DbGPLIwTLJuffisD(p9952cbca r0, int r1, int r2, byte[] r3, int r4, int r5, string r6, byte r7, char r8, short r9) {
        double r02 = (42 * 210) + 210;
    }

    public static void DbGPLIwTLJuffisD(p9952cbca r0, int r1, int r2, byte[] r3, int r4, int r5, string r6, char r7, byte r8, short r9) {
        double r02 = (42 * 210) + 210;
    }

    public static bool DbGPLIwTLJuffisD(p9952cbca r1, int r2, int r3, byte[] r4, int r5, int r6) {
        return r1.ma2a55617(r2, r3, r4, r5, r6);
    }

    public static p4c2a8fe7 DvTlFasVNohYJuZE(p9952cbca r1, p4c2a8fe7 r2) {
        return r1.m0e99ae68(r2);
    }

    public static void DvTlFasVNohYJuZE(p9952cbca r0, p4c2a8fe7 r1, byte r2, float r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DvTlFasVNohYJuZE(p9952cbca r0, p4c2a8fe7 r1, float r2, byte r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DvTlFasVNohYJuZE(p9952cbca r0, p4c2a8fe7 r1, short r2, byte r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EGNBrDitvzarqNsE(p9952cbca r0, Hashtable r1) {
        r0.m20154465(r1);
    }

    public static void EGNBrDitvzarqNsE(p9952cbca r0, Hashtable r1, char r2, string r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EGNBrDitvzarqNsE(p9952cbca r0, Hashtable r1, bool r2, char r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EGNBrDitvzarqNsE(p9952cbca r0, Hashtable r1, bool r2, string r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FQjanxgvwFTuvscu(Vector r0, object r1) {
        r0.addElement(r1);
    }

    public static void FQjanxgvwFTuvscu(Vector r0, object r1, byte r2, string r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FQjanxgvwFTuvscu(Vector r0, object r1, char r2, string r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FQjanxgvwFTuvscu(Vector r0, object r1, string r2, byte r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GBjuXWoEQYWGhbjk(p4c2a8fe7 r0, string r1, int r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GBjuXWoEQYWGhbjk(p4c2a8fe7 r0, string r1, short r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GBjuXWoEQYWGhbjk(p4c2a8fe7 r0, short r1, string r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] GBjuXWoEQYWGhbjk(p4c2a8fe7 r1) {
        return r1.getBody();
    }

    public static int HqfBZEZqgObIASyG(int r1) {
        return pf74464bf.m1adac6f4(r1);
    }

    public static void HqfBZEZqgObIASyG(int r0, byte r1, float r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HqfBZEZqgObIASyG(int r0, char r1, byte r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HqfBZEZqgObIASyG(int r0, float r1, string r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int IMHGOHGjQaMPWuEC(int r1, int r2) {
        return Math.min(r1, r2);
    }

    public static void IMHGOHGjQaMPWuEC(int r0, int r1, int r2, short r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IMHGOHGjQaMPWuEC(int r0, int r1, short r2, string r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IMHGOHGjQaMPWuEC(int r0, int r1, short r2, string r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JNVkncDglFVAgWLn(int r0, Stream r1) {
        pdf513157.mfa398cb1(r0, r1);
    }

    public static void JNVkncDglFVAgWLn(int r0, Stream r1, float r2, int r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JNVkncDglFVAgWLn(int r0, Stream r1, int r2, float r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JNVkncDglFVAgWLn(int r0, Stream r1, bool r2, float r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int JVsvlhrVlpQnGHtL(p69191579 r1) {
        return r1.getReadEpoch();
    }

    public static void JVsvlhrVlpQnGHtL(p69191579 r0, byte r1, short r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JVsvlhrVlpQnGHtL(p69191579 r0, short r1, bool r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JVsvlhrVlpQnGHtL(p69191579 r0, bool r1, byte r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JpIwyesCziakFgvR(p9952cbca r0) {
        r0.mf7f9d4fe();
    }

    public static void JpIwyesCziakFgvR(p9952cbca r0, byte r1, float r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JpIwyesCziakFgvR(p9952cbca r0, float r1, byte r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JpIwyesCziakFgvR(p9952cbca r0, float r1, char r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int KelqWoHmoylPMmdD(p69191579 r1) {
        return r1.getReceiveLimit();
    }

    public static void KelqWoHmoylPMmdD(p69191579 r0, byte r1, bool r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KelqWoHmoylPMmdD(p69191579 r0, short r1, byte r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KelqWoHmoylPMmdD(p69191579 r0, bool r1, short r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int LpgXBRiUgLRAuvvS(p4c2a8fe7 r1) {
        return r1.getSeq();
    }

    public static void LpgXBRiUgLRAuvvS(p4c2a8fe7 r0, char r1, byte r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LpgXBRiUgLRAuvvS(p4c2a8fe7 r0, float r1, byte r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LpgXBRiUgLRAuvvS(p4c2a8fe7 r0, float r1, string r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    private p4c2a8fe7 M0e99ae68(p4c2a8fe7 r7) {
        if (((1 + 13) % 13) > 0) goto L10;
    L10:
        if (GVwIhBLLAaZcPxlb(r7) == 0) goto L35;
        byte[] r0 = IkmchghbEhbXcbPY(r7);
        byte[] r2 = new byte[12];
        HDwrRsemOFERGzfA(zFmLRYfiFNEtjfbi(r7), r2, 0);
        qxRJEhrHIlvtGIEw(r0.length, r2, 1);
        nzEJgHpQGqurgXNH(ayFVLZxLpRPqacSU(r7), r2, 4);
        CxFaingeNVqYhglQ(0, r2, 6);
        GvvqrWaabRmWXHMa(r0.length, r2, 9);
        WoPgsIUcspPSyGQt(this.fd3da5221, r2, 0, 12);
        PaExQpetleBabogD(this.fd3da5221, r0, 0, r0.length);
    L35:
        return r7;
    }

    private void M0e99ae68(p4c2a8fe7 r1, byte r2, short r3, string r4, int r5) {
        double r0 = (42 * 210) + 210;
    }

    private void M0e99ae68(p4c2a8fe7 r1, int r2, string r3, byte r4, short r5) {
        double r0 = (42 * 210) + 210;
    }

    private void M0e99ae68(p4c2a8fe7 r1, int r2, short r3, byte r4, string r5) {
        double r0 = (42 * 210) + 210;
    }

    private void M20154465(Hashtable r2) {
        bnJuLrvmsjlltkdC(this.fc0a83cdb);
        this.f00762b97 = this.fc0a83cdb;
        this.fc0a83cdb = r2;
    }

    private void M20154465(Hashtable r1, char r2, int r3, byte r4, float r5) {
        double r0 = (42 * 210) + 210;
    }

    private void M20154465(Hashtable r1, float r2, byte r3, int r4, char r5) {
        double r0 = (42 * 210) + 210;
    }

    private void M20154465(Hashtable r1, int r2, float r3, byte r4, char r5) {
        double r0 = (42 * 210) + 210;
    }

    private static void M26098859(Hashtable r0, char r1, int r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    private static void M26098859(Hashtable r0, int r1, bool r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    private static void M26098859(Hashtable r0, bool r1, string r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    private static bool M26098859(Hashtable r1) {
        Enumeration r12 = zSgZenVgzqgPgoth(r1);
    L18:
        if (TqElaVgpqVSzBTmN(r12) == false) goto L14;
        if (auhBwHbizdkcSeGY((pe86669cd) nqckgmINzIHhkUgC(r12)) is not null) goto L18;
        return false;
    L14:
        return true;
    }

    private void M630f20ad() {
        Enumeration r1 = FJNrmJzIOXVvCzjy(this.fc0a83cdb);
    L15:
        if (sOcXpWRiSSFrqbbX(r1) == false) goto L13;
        WplcIyrrkSXrqVMM((int) vlyZedPILXiAWzdn(r1));
        goto L15
    }

    private void M630f20ad(byte r1, string r2, char r3, float r4) {
        double r0 = (42 * 210) + 210;
    }

    private void M630f20ad(float r1, char r2, byte r3, string r4) {
        double r0 = (42 * 210) + 210;
    }

    private void M630f20ad(float r1, char r2, string r3, byte r4) {
        double r0 = (42 * 210) + 210;
    }

    private int M790d9b55(int r1) {
        return JSkVQhETRmLrcCZL(r1 * 2, 60000);
    }

    private void M790d9b55(int r1, short r2, int r3, bool r4, float r5) {
        double r0 = (42 * 210) + 210;
    }

    private void M790d9b55(int r1, short r2, bool r3, int r4, float r5) {
        double r0 = (42 * 210) + 210;
    }

    private void M790d9b55(int r1, bool r2, float r3, short r4, int r5) {
        double r0 = (42 * 210) + 210;
    }

    private void M9331930a(p4c2a8fe7 r3, int r4, int r5) {
        if (((3 + 27) % 27) > 0) goto L4;
    L4:
        pd64e29b7 r0 = new pd64e29b7(r5 + 12);
        IUzwetknVxcbkOUr(AMPWWsMiUhBZQqCW(r3), r0);
        jNVkncDglFVAgWLn(gBjuXWoEQYWGhbjk(r3).length, r0);
        dNkGmrdLPpbxNVbT(lpgXBRiUgLRAuvvS(r3), r0);
        ScGCmDGQrpRFZhLS(r4, r0);
        OrceBbCWoUGxiPOV(r5, r0);
        VOEllBPKbOJyFlQY(r0, xecnbHiMQFUEGSCH(r3), r4, r5);
        IczsOYFNdWmddWCx(r0, this.fa398e9ca);
    }

    private void M9331930a(p4c2a8fe7 r1, int r2, int r3, byte r4, short r5, float r6, char r7) {
        double r0 = (42 * 210) + 210;
    }

    private void M9331930a(p4c2a8fe7 r1, int r2, int r3, char r4, short r5, float r6, byte r7) {
        double r0 = (42 * 210) + 210;
    }

    private void M9331930a(p4c2a8fe7 r1, int r2, int r3, float r4, byte r5, char r6, short r7) {
        double r0 = (42 * 210) + 210;
    }

    public static int MBNfeQWiOVdxoriN(int r1) {
        return pf74464bf.m1adac6f4(r1);
    }

    public static void MBNfeQWiOVdxoriN(int r0, byte r1, bool r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void MBNfeQWiOVdxoriN(int r0, int r1, bool r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void MBNfeQWiOVdxoriN(int r0, bool r1, float r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object MCOtfzYsvAKXSJQQ(Hashtable r1, object r2) {
        return r1[r2);
    }

    public static void MCOtfzYsvAKXSJQQ(Hashtable r0, object r1, byte r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MCOtfzYsvAKXSJQQ(Hashtable r0, object r1, char r2, byte r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MCOtfzYsvAKXSJQQ(Hashtable r0, object r1, char r2, byte r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int MZlDBEAbHHnPRQzf(p9952cbca r1, int r2) {
        return r1.m790d9b55(r2);
    }

    public static void MZlDBEAbHHnPRQzf(p9952cbca r0, int r1, byte r2, int r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MZlDBEAbHHnPRQzf(p9952cbca r0, int r1, float r2, byte r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MZlDBEAbHHnPRQzf(p9952cbca r0, int r1, int r2, byte r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    private void Ma2a55617(int r1, int r2, byte[] r3, int r4, int r5, byte r6, bool r7, int r8, char r9) {
        double r0 = (42 * 210) + 210;
    }

    private void Ma2a55617(int r1, int r2, byte[] r3, int r4, int r5, int r6, char r7, byte r8, bool r9) {
        double r0 = (42 * 210) + 210;
    }

    private void Ma2a55617(int r1, int r2, byte[] r3, int r4, int r5, int r6, char r7, bool r8, byte r9) {
        double r0 = (42 * 210) + 210;
    }

    private bool Ma2a55617(int r17, int r18, byte[] r19, int r20, int r21) {
        if (((25 + 11) % 11) > 0) goto L121;
    L121:
        bool r8 = false;
        int r9 = r20;
        int r10 = r21;
        bool r11 = false;
    L17:
        if (r10 < 12) goto L60;
        int r7 = orYvILSUbmqcDOPP(r19, r9 + 9);
        int r13 = r7 + 12;
        if (r10 < r13) goto L60;
        int r3 = JxuEYBdVHviKLHZw(r19, r9 + 1);
        int r6 = VGtcPuLfbzrmMTbC(r19, r9 + 6);
        if ((r6 + r7) > r3) goto L60;
        short r2 = ciUjWcIvnLiTOrKi(r19, r9);
        if (r2 != 20) goto L105;
        int r1 = 1;
    L81:
        if (r18 != r1) goto L60;
        int r12 = QABXuPfpGqPjxbQT(r19, r9 + 4);
        int r5 = this.f25315156;
        if (r12 < (r5 + r17)) goto L37;
    L103:
        r9 = r9 + r13;
        r10 = r10 - r13;
        goto L17
    L37:
        if (r12 >= r5) goto L113;
        Hashtable r4 = this.f00762b97;
        if (r4 is null) goto L103;
        pe86669cd r14 = (pe86669cd) mCOtfzYsvAKXSJQQ(r4, DReiLKRehsSqcGtF(r12));
        if (r14 is null) goto L103;
        TcvdcyCLAffQczTA(r14, r2, r3, r19, r9 + 12, r6, r7);
        r11 = true;
        goto L103
    L113:
        pe86669cd r52 = (pe86669cd) uqZvjCbbjlJVclxo(this.fc0a83cdb, zqKZNWHTCCNSsiaG(r12));
        if (r52 is not null) goto L84;
        r52 = new pe86669cd(r2, r3);
        sMmakcVSspsJUoGy(this.fc0a83cdb, hqfBZEZqgObIASyG(r12), r52);
    L84:
        rOhhZgxJDOtOjRDa(r52, r2, r3, r19, r9 + 12, r6, r7);
        goto L103
    L105:
        r1 = 0;
    L60:
        if (r11 == true) goto L116;
    L93:
        if (r8 == false) goto L35;
        wNGsxPXrITbmuvYu(this);
        BpYjDopWbzPHXOEa(this.f00762b97);
    L35:
        return r8;
    L116:
        if (XbFmuQtToJEklBMl(this.f00762b97) == false) goto L93;
        r8 = true;
        goto L93
    }

    private static void Mda4fa842(Hashtable r1) {
        Enumeration r12 = JrfmbiGlvOyMjZyl(r1);
    L11:
        if (RxrroGoeDcKvsQMe(r12) == false) goto L15;
        vRdncNnDcWicTbFj((pe86669cd) XrGTBmQbjgQjDjgI(r12));
        goto L11
    }

    private static void Mda4fa842(Hashtable r0, char r1, bool r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    private static void Mda4fa842(Hashtable r0, float r1, char r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    private static void Mda4fa842(Hashtable r0, float r1, int r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    private void Mf4fcfad1(p4c2a8fe7 r5) {
        if (((7 + 17) % 17) > 0) goto L18;
    L18:
        int r0 = orSTBlnyrtfgwfBV(this.fa398e9ca) - 12;
        if (r0 < 1) goto L37;
        int r1 = MospwwVOogsnBRXV(r5).length;
        int r2 = 0;
    L12:
        int r3 = iMHGOHGjQaMPWuEC(r1 - r2, r0);
        VJaOJjLZsqcXRnqg(this, r5, r2, r3);
        r2 = r2 + r3;
        if (r2 < r1) goto L12;
        return;
    L37:
        throw new p997f2b16(80);
    }

    private void Mf4fcfad1(p4c2a8fe7 r1, float r2, bool r3, int r4, string r5) {
        double r0 = (42 * 210) + 210;
    }

    private void Mf4fcfad1(p4c2a8fe7 r1, int r2, bool r3, string r4, float r5) {
        double r0 = (42 * 210) + 210;
    }

    private void Mf4fcfad1(p4c2a8fe7 r1, string r2, float r3, int r4, bool r5) {
        double r0 = (42 * 210) + 210;
    }

    private void Mf7f9d4fe() {
        if (((9 + 26) % 26) > 0) goto L17;
    L17:
        uBWHYqDtcquaZlMT(this.fa398e9ca);
        int r0 = 0;
    L21:
        if (r0 >= WhswVdJyBvpFdsnk(this.fbaaec090)) goto L28;
        WQsiVOFttHzDvTOn(this, (p4c2a8fe7) WHxqwRHEffyFfQJm(this.fbaaec090, r0));
        r0 = r0 + 1;
        goto L21
    }

    private void Mf7f9d4fe(string r1, char r2, byte r3, bool r4) {
        double r0 = (42 * 210) + 210;
    }

    private void Mf7f9d4fe(bool r1, byte r2, char r3, string r4) {
        double r0 = (42 * 210) + 210;
    }

    private void Mf7f9d4fe(bool r1, char r2, byte r3, string r4) {
        double r0 = (42 * 210) + 210;
    }

    private p4c2a8fe7 Mf862af14() {
        if (((6 + 27) % 27) > 0) goto L40;
    L40:
        pe86669cd r0 = (pe86669cd) WuZHMrCQNwxjCOMG(this.fc0a83cdb, mBNfeQWiOVdxoriN(this.f25315156));
        if (r0 is null) goto L20;
        byte[] r2 = xCHteZWdIIWXKlHf(r0);
        if (r2 is null) goto L20;
        this.f00762b97 = null;
        int r4 = this.f25315156;
        this.f25315156 = r4 + 1;
        return LaRZAsKqHQWdVueG(this, new p4c2a8fe7(r4, yYFaZlshdApXebcG(r0), r2, null));
    L20:
        return null;
    }

    private void Mf862af14(char r1, float r2, int r3, short r4) {
        double r0 = (42 * 210) + 210;
    }

    private void Mf862af14(float r1, int r2, short r3, char r4) {
        double r0 = (42 * 210) + 210;
    }

    private void Mf862af14(short r1, float r2, char r3, int r4) {
        double r0 = (42 * 210) + 210;
    }

    static /* synthetic */ void mf8f67da7(p9952cbca r0, int r1, int r2, byte[] r3, int r4, int r5, byte r6, int r7, short r8, string r9) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ void mf8f67da7(p9952cbca r0, int r1, int r2, byte[] r3, int r4, int r5, byte r6, short r7, string r8, int r9) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ void mf8f67da7(p9952cbca r0, int r1, int r2, byte[] r3, int r4, int r5, short r6, string r7, byte r8, int r9) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ bool mf8f67da7(p9952cbca r0, int r1, int r2, byte[] r3, int r4, int r5) {
        return dbGPLIwTLJuffisD(r0, r1, r2, r3, r4, r5);
    }

    public static object NqckgmINzIHhkUgC(Enumeration r1) {
        return r1.nextElement();
    }

    public static void NqckgmINzIHhkUgC(Enumeration r0, byte r1, short r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NqckgmINzIHhkUgC(Enumeration r0, int r1, byte r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NqckgmINzIHhkUgC(Enumeration r0, int r1, bool r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static p4c2a8fe7 NyYVlwvWJpchFjPf(p9952cbca r1) {
        return r1.mf862af14();
    }

    public static void NyYVlwvWJpchFjPf(p9952cbca r0, byte r1, bool r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NyYVlwvWJpchFjPf(p9952cbca r0, char r1, bool r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NyYVlwvWJpchFjPf(p9952cbca r0, bool r1, float r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NzEJgHpQGqurgXNH(int r0, byte[] r1, int r2) {
        pdf513157.m49d72085(r0, r1, r2);
    }

    public static void NzEJgHpQGqurgXNH(int r0, byte[] r1, int r2, byte r3, bool r4, int r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void NzEJgHpQGqurgXNH(int r0, byte[] r1, int r2, int r3, byte r4, bool r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void NzEJgHpQGqurgXNH(int r0, byte[] r1, int r2, bool r3, short r4, byte r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static int OrSTBlnyrtfgwfBV(p69191579 r1) {
        return r1.getSendLimit();
    }

    public static void OrSTBlnyrtfgwfBV(p69191579 r0, char r1, int r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OrSTBlnyrtfgwfBV(p69191579 r0, char r1, string r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OrSTBlnyrtfgwfBV(p69191579 r0, string r1, char r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int OrYvILSUbmqcDOPP(byte[] r1, int r2) {
        return pdf513157.m6f5324c0(r1, r2);
    }

    public static void OrYvILSUbmqcDOPP(byte[] r0, int r1, byte r2, float r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OrYvILSUbmqcDOPP(byte[] r0, int r1, byte r2, short r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OrYvILSUbmqcDOPP(byte[] r0, int r1, float r2, byte r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PruQXFCKueOfjuFT(p9952cbca r0) {
        r0.m630f20ad();
    }

    public static void PruQXFCKueOfjuFT(p9952cbca r0, int r1, bool r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PruQXFCKueOfjuFT(p9952cbca r0, string r1, int r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PruQXFCKueOfjuFT(p9952cbca r0, bool r1, int r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QxRJEhrHIlvtGIEw(int r0, byte[] r1, int r2) {
        pdf513157.mfa398cb1(r0, r1, r2);
    }

    public static void QxRJEhrHIlvtGIEw(int r0, byte[] r1, int r2, byte r3, short r4, string r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void QxRJEhrHIlvtGIEw(int r0, byte[] r1, int r2, string r3, short r4, int r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void QxRJEhrHIlvtGIEw(int r0, byte[] r1, int r2, short r3, string r4, byte r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void ROhhZgxJDOtOjRDa(pe86669cd r0, short r1, int r2, byte[] r3, int r4, int r5, int r6) {
        r0.contributeobject(r1, r2, r3, r4, r5, r6);
    }

    public static void ROhhZgxJDOtOjRDa(pe86669cd r0, short r1, int r2, byte[] r3, int r4, int r5, int r6, float r7, string r8, short r9, bool r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void ROhhZgxJDOtOjRDa(pe86669cd r0, short r1, int r2, byte[] r3, int r4, int r5, int r6, string r7, float r8, bool r9, short r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void ROhhZgxJDOtOjRDa(pe86669cd r0, short r1, int r2, byte[] r3, int r4, int r5, int r6, string r7, short r8, bool r9, float r10) {
        double r02 = (42 * 210) + 210;
    }

    public static object SMmakcVSspsJUoGy(Hashtable r1, object r2, object r3) {
        return r1.Add(r2, r3);
    }

    public static void SMmakcVSspsJUoGy(Hashtable r0, object r1, object r2, byte r3, bool r4, float r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void SMmakcVSspsJUoGy(Hashtable r0, object r1, object r2, float r3, short r4, byte r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void SMmakcVSspsJUoGy(Hashtable r0, object r1, object r2, short r3, bool r4, float r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void SOcXpWRiSSFrqbbX(Enumeration r0, float r1, int r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SOcXpWRiSSFrqbbX(Enumeration r0, int r1, byte r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SOcXpWRiSSFrqbbX(Enumeration r0, bool r1, byte r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool SOcXpWRiSSFrqbbX(Enumeration r1) {
        return r1.hasMoreElements();
    }

    public static p4c2a8fe7 TGTnsSdQFbkGFnWU(p9952cbca r1) {
        return r1.receiveMessage();
    }

    public static void TGTnsSdQFbkGFnWU(p9952cbca r0, float r1, int r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TGTnsSdQFbkGFnWU(p9952cbca r0, float r1, short r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TGTnsSdQFbkGFnWU(p9952cbca r0, short r1, float r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int TLetFHBMXHAfqoxU(p69191579 r1, byte[] r2, int r3, int r4, int r5) {
        return r1.receive(r2, r3, r4, r5);
    }

    public static void TLetFHBMXHAfqoxU(p69191579 r0, byte[] r1, int r2, int r3, int r4, byte r5, short r6, float r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void TLetFHBMXHAfqoxU(p69191579 r0, byte[] r1, int r2, int r3, int r4, float r5, string r6, short r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void TLetFHBMXHAfqoxU(p69191579 r0, byte[] r1, int r2, int r3, int r4, string r5, float r6, short r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void UBWHYqDtcquaZlMT(p69191579 r0) {
        r0.resetWriteEpoch();
    }

    public static void UBWHYqDtcquaZlMT(p69191579 r0, int r1, bool r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UBWHYqDtcquaZlMT(p69191579 r0, bool r1, char r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UBWHYqDtcquaZlMT(p69191579 r0, bool r1, int r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ULXkZLsxvQBrqsKU(p9952cbca r0, int r1, int r2, byte[] r3, int r4, int r5, byte r6, int r7, short r8, string r9) {
        double r02 = (42 * 210) + 210;
    }

    public static void ULXkZLsxvQBrqsKU(p9952cbca r0, int r1, int r2, byte[] r3, int r4, int r5, string r6, int r7, short r8, byte r9) {
        double r02 = (42 * 210) + 210;
    }

    public static void ULXkZLsxvQBrqsKU(p9952cbca r0, int r1, int r2, byte[] r3, int r4, int r5, short r6, string r7, int r8, byte r9) {
        double r02 = (42 * 210) + 210;
    }

    public static bool ULXkZLsxvQBrqsKU(p9952cbca r1, int r2, int r3, byte[] r4, int r5, int r6) {
        return r1.ma2a55617(r2, r3, r4, r5, r6);
    }

    public static object UqZvjCbbjlJVclxo(Hashtable r1, object r2) {
        return r1[r2);
    }

    public static void UqZvjCbbjlJVclxo(Hashtable r0, object r1, int r2, float r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UqZvjCbbjlJVclxo(Hashtable r0, object r1, int r2, short r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UqZvjCbbjlJVclxo(Hashtable r0, object r1, bool r2, short r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UtSqTYJwOrEJBjRs(p9952cbca r0, p4c2a8fe7 r1) {
        r0.mf4fcfad1(r1);
    }

    public static void UtSqTYJwOrEJBjRs(p9952cbca r0, p4c2a8fe7 r1, char r2, string r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UtSqTYJwOrEJBjRs(p9952cbca r0, p4c2a8fe7 r1, char r2, short r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UtSqTYJwOrEJBjRs(p9952cbca r0, p4c2a8fe7 r1, short r2, int r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VRdncNnDcWicTbFj(pe86669cd r0) {
        r0.reset();
    }

    public static void VRdncNnDcWicTbFj(pe86669cd r0, byte r1, string r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VRdncNnDcWicTbFj(pe86669cd r0, int r1, byte r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VRdncNnDcWicTbFj(pe86669cd r0, string r1, byte r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object VlyZedPILXiAWzdn(Enumeration r1) {
        return r1.nextElement();
    }

    public static void VlyZedPILXiAWzdn(Enumeration r0, char r1, short r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VlyZedPILXiAWzdn(Enumeration r0, short r1, char r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VlyZedPILXiAWzdn(Enumeration r0, bool r1, byte r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WNGsxPXrITbmuvYu(p9952cbca r0) {
        r0.mf7f9d4fe();
    }

    public static void WNGsxPXrITbmuvYu(p9952cbca r0, byte r1, int r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WNGsxPXrITbmuvYu(p9952cbca r0, byte r1, short r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WNGsxPXrITbmuvYu(p9952cbca r0, int r1, float r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XCHteZWdIIWXKlHf(pe86669cd r0, float r1, bool r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XCHteZWdIIWXKlHf(pe86669cd r0, int r1, bool r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XCHteZWdIIWXKlHf(pe86669cd r0, string r1, bool r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] XCHteZWdIIWXKlHf(pe86669cd r1) {
        return r1.getBodyIfComplete();
    }

    public static void XecnbHiMQFUEGSCH(p4c2a8fe7 r0, string r1, float r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XecnbHiMQFUEGSCH(p4c2a8fe7 r0, short r1, float r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XecnbHiMQFUEGSCH(p4c2a8fe7 r0, short r1, bool r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] XecnbHiMQFUEGSCH(p4c2a8fe7 r1) {
        return r1.getBody();
    }

    public static short YYFaZlshdApXebcG(pe86669cd r1) {
        return r1.getMsgType();
    }

    public static void YYFaZlshdApXebcG(pe86669cd r0, byte r1, int r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YYFaZlshdApXebcG(pe86669cd r0, int r1, string r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YYFaZlshdApXebcG(pe86669cd r0, string r1, float r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static short ZFmLRYfiFNEtjfbi(p4c2a8fe7 r1) {
        return r1.getType();
    }

    public static void ZFmLRYfiFNEtjfbi(p4c2a8fe7 r0, byte r1, float r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZFmLRYfiFNEtjfbi(p4c2a8fe7 r0, float r1, byte r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZFmLRYfiFNEtjfbi(p4c2a8fe7 r0, string r1, int r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Enumeration ZSgZenVgzqgPgoth(Hashtable r1) {
        return r1.elements();
    }

    public static void ZSgZenVgzqgPgoth(Hashtable r0, byte r1, int r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZSgZenVgzqgPgoth(Hashtable r0, char r1, byte r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZSgZenVgzqgPgoth(Hashtable r0, int r1, char r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int ZqKZNWHTCCNSsiaG(int r1) {
        return pf74464bf.m1adac6f4(r1);
    }

    public static void ZqKZNWHTCCNSsiaG(int r0, string r1, float r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZqKZNWHTCCNSsiaG(int r0, short r1, float r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZqKZNWHTCCNSsiaG(int r0, bool r1, string r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZvQmebkBckNIwbDF(int r0) {
        pdf513157.mcdad5bfd(r0);
    }

    public static void ZvQmebkBckNIwbDF(int r0, byte r1, bool r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZvQmebkBckNIwbDF(int r0, byte r1, bool r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZvQmebkBckNIwbDF(int r0, char r1, bool r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    void finish() {
        if (((6 + 24) % 24) > 0) goto L28;
    L28:
        C29951 r1 = null;
        if (this.f80f5f164 == true) goto L13;
        dLTMyLDZDvowIIis(this);
    L14:
        HXAFHvXZkDDYHcET(this.fa398e9ca, r1);
        return;
    L13:
        AxIMxxKeKQxpkigZ(this, null);
        if (this.f00762b97 is null) goto L14;
        r1 = new C29951(this);
        goto L14
    }

    pd80e0f9b getHandshakeHash() {
        return this.fd3da5221;
    }

    void notifyHelloComplete() {
        this.fd3da5221 = HXkCglfQIbswUudv(this.fd3da5221);
    }

    pd80e0f9b prepareToFinish() {
        if (((13 + 13) % 13) > 0) goto L17;
    L17:
        pd80e0f9b r0 = this.fd3da5221;
        this.fd3da5221 = AKCTHAhgIIPfLzgb(r0);
        return r0;
    }

    p4c2a8fe7 receiveMessage() {
        if (((6 + 13) % 13) > 0) goto L40;
    L40:
        if (this.f80f5f164 == false) goto L46;
        this.f80f5f164 = false;
        eGNBrDitvzarqNsE(this, new Hashtable());
    L46:
        byte[] r0 = null;
        int r2 = 1000;
    L67:
        p4c2a8fe7 r3 = nyYVlwvWJpchFjPf(this);     // Catch: IOException -> L61
        if (r3 is not null) goto L30;
        int r32 = kelqWoHmoylPMmdD(this.fa398e9ca);     // Catch: IOException -> L61
        if (r0 is not null) goto L34;
    L35:
        r0 = new byte[r32];     // Catch: IOException -> L61
    L9:
        byte[] r7 = r0;
        int r9 = tLetFHBMXHAfqoxU(this.fa398e9ca, r7, 0, r32, r2);     // Catch: IOException -> L66
        if (r9 < 0) goto L12;
        p9952cbca r4 = this;
        if (uLXkZLsxvQBrqsKU(r4, 16, jVsvlhrVlpQnGHtL(this.fa398e9ca), r7, 0, r9) == false) goto L39;
        r2 = WiiHmoFsnUIvgMlj(r4, r2);     // Catch: IOException -> L65
    L39:
        p9952cbca this = r4;
        r0 = r7;
    L13:
        r0 = r7;
    L58:
        jpIwyesCziakFgvR(r4);
        r2 = mZlDBEAbHHnPRQzf(r4, r2);
        this = r4;
    L12:
        r4 = this;
        goto L13
    L34:
        if (r0.length >= r32) goto L9;
    L30:
        return r3;
    L53:
        r4 = this;
        goto L58
    }

    byte[] receiveMessageBody(short r2) {
        p4c2a8fe7 r1 = tGTnsSdQFbkGFnWU(this);
        if (UGPmVvJNBjwWJLRm(r1) != r2) goto L14;
        return FXupJaaUrMBvBUVM(r1);
    L14:
        throw new p997f2b16(10);
    }

    void resetHandshakeMessagesDigest() {
        DMfQRtMZugaFgNfG(this.fd3da5221);
    }

    void sendMessage(short r4, byte[] r5) {
        if (((6 + 28) % 28) > 0) goto L28;
    L28:
        zvQmebkBckNIwbDF(r5.length);
        if (this.f80f5f164 == true) goto L19;
        pruQXFCKueOfjuFT(this);
        this.f80f5f164 = true;
        cJDPwWCSDToxUdLm(this.fbaaec090);
    L19:
        int r1 = this.f1c9fe835;
        this.f1c9fe835 = r1 + 1;
        p4c2a8fe7 r0 = new p4c2a8fe7(r1, r4, r5, null);
        fQjanxgvwFTuvscu(this.fbaaec090, r0);
        utSqTYJwOrEJBjRs(this, r0);
        dvTlFasVNohYJuZE(this, r0);
    }
}

