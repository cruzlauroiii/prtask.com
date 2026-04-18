namespace WillowMaze.Wasm.Decompiled;


public class p781134c3 {
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f21ffce5b;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e f22cd2809;
    private java.security.SecureRandom f3a72a73b;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e f41fb8a65;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f4649c470;
    private java.security.SecureRandom f663c9148;
    private java.security.SecureRandom f6935bb93;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 f71eb1738;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e f7b31dcb6;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f8101695a;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f8b8bc6f2;
    private java.security.SecureRandom f98b78168;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 fb42ebc07;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e fb6dd0702;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 fbd0c8e3b;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e fc36853ea;
    private java.security.SecureRandom fc43fb241;

    public p781134c3(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var, java.security.SecureRandom secureRandom) {
        if (pf62ef2d9Var is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        this.f21ffce5b = pf62ef2d9Var;
        this.f8b8bc6f2 = bQbGnPCvQyhQuIKC(pf62ef2d9Var);
        this.fc43fb241 = secureRandom;
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b AOsRnxImodJCcxiO(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, byte[] bArr) {
        return p823c49a3_p2bd4a59b.withPublicSeed(bArr);
    }

    public static byte[] BDvoksnyOAETyIfR(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVar) {
        return pe1225d2eVar.getPublicSeed();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 CIEtXfZRIAAzzJbN(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3 p781134c3Var) {
        return p781134c3Var.getParams();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 DjkpJnkXAQDNSoAn(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b) {
        return p823c49a3_p2bd4a59b.build();
    }

    public static void DoWpocsNBLNeQIhJ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, byte[] bArr, byte[] bArr2) {
        p893af95bVar.importKeys(bArr, bArr2);
    }

    public static byte[] FklFUtFfPsTeMewo(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3 p781134c3Var) {
        return p781134c3Var.getPublicSeed();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a GTPfxhTsahmGwvzX(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getBDSState();
    }

    public static void GoATAVqSghcFqYBa(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525 pac63e525Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pac63e525Var.init(z, pc9ef6b45Var);
    }

    public static bool HSaCZneefFxqekEv(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525 pac63e525Var, byte[] bArr, byte[] bArr2) {
        return pac63e525Var.verifySignature(bArr, bArr2);
    }

    public static int HiloQCNLbgJUYzjD(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getDigestSize();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b HmgiYduPBPzMsvfk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, byte[] bArr) {
        return p823c49a3_p2bd4a59b.withRoot(bArr);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b IOZIZvTFkNgOFdLu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b, byte[] bArr) {
        return pe1225d2e_p2bd4a59b.withRoot(bArr);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b JUckynUGNrKvDXre(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, byte[] bArr) {
        return p823c49a3_p2bd4a59b.withSecretKeyPRF(bArr);
    }

    public static byte[] KyELPcnUGmLqloNs(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVar) {
        return pe1225d2eVar.tobyteArray();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 LXalScHoPNZmtbtR(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b) {
        return p823c49a3_p2bd4a59b.build();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 MFpJwJOCOdZSiCtc(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3 p781134c3Var) {
        return p781134c3Var.getParams();
    }

    public static byte[] MIeEilDLqfFWXUJD(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVar) {
        return pe1225d2eVar.getPublicSeed();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e MXYYNnAZaKOWHYbi(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b) {
        return pe1225d2e_p2bd4a59b.build();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b NPrZlvbRvhfeCfiZ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, byte[] bArr) {
        return p823c49a3_p2bd4a59b.withSecretKeyPRF(bArr);
    }

    public static int NRamjMqegHpicGvk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getDigestSize();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a OVJpmmagIxWWWxWl(p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 pd255ec94Var) {
        return pd255ec94Var.getPrivate();
    }

    public static byte[] OWvBaduPdVeDlEzN(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.tobyteArray();
    }

    public static int QjrsPTXDJGNXpSYA(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getDigestSize();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b QvavxqhwVIAbFVbC(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b, byte[] bArr) {
        return pe1225d2e_p2bd4a59b.withPublicKey(bArr);
    }

    public static byte[] RWapiAgAHRtDAqyu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, byte[] bArr, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return p893af95bVar.getWOTSPlusSecretKey(bArr, pd57771baVar);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b RtWmMAIKEaOFjxrn(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, byte[] bArr) {
        return p823c49a3_p2bd4a59b.withPublicSeed(bArr);
    }

    public static bool SKRSZybCquEePrzG(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static void SMYzcVzfvBwLQHGF(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, byte[] bArr, byte[] bArr2) {
        p893af95bVar.importKeys(bArr, bArr2);
    }

    public static byte[] TMuVcLgPlgkXxbEu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getSecretKeyPRF();
    }

    public static byte[] UrKzERHSPdGmLZKS(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVar) {
        return pe1225d2eVar.getRoot();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a VIkLyyyRTqTQcTYT(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525 pac63e525Var) {
        return pac63e525Var.getUpdatedPrivateKey();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b VPWrEOVSnLdsLUXr(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b, byte[] bArr) {
        return pe1225d2e_p2bd4a59b.withRoot(bArr);
    }

    public static byte[] VdHUtUJjFRVwCQio(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getPublicSeed();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a WOjrUYhZhDomPAzV(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getBDSState();
    }

    public static byte[] WaOcerhNYsmTglHq(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getSecretKeySeed();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b WfOtasZELTnRkeev(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, byte[] bArr, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return p823c49a3_p2bd4a59b.withPrivateKey(bArr, pf62ef2d9Var);
    }

    public static byte[] WzziiwjFyWVzzTlo(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getPublicSeed();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e BDcPXxCUAYDDIcFa(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b) {
        return pe1225d2e_p2bd4a59b.build();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b BQbGnPCvQyhQuIKC(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getWOTSPlus();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 BjqaOnCOymXInIwY(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b) {
        return p823c49a3_p2bd4a59b.build();
    }

    public static byte[] CKtcQOaTVjgfXevj(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getSecretKeyPRF();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b clGKkmFoEezLBIBz(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, byte[] bArr) {
        return p823c49a3_p2bd4a59b.withPublicSeed(bArr);
    }

    public static byte[] DDcBmPfTRuJrbqSg(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3 p781134c3Var) {
        return p781134c3Var.getPublicSeed();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b duOwperMyEZefsDf(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, byte[] bArr) {
        return p823c49a3_p2bd4a59b.withSecretKeyPRF(bArr);
    }

    public static byte[] EcJhEzjAHnkTJVyc(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getRoot();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b eyacfaZbRHZXPJnE(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b, byte[] bArr) {
        return pe1225d2e_p2bd4a59b.withPublicKey(bArr);
    }

    public static byte[] FAsNEYocoXTUYQMu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getSecretKeySeed();
    }

    public static byte[] FfOiFAtIwmsfzJqU(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getPublicSeed();
    }

    public static int FpFpGTnwzbwLNEay(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getDigestSize();
    }

    public static void FsOVcTvdfGONXRLW(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2dd6c2e6 p2dd6c2e6Var, p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        p2dd6c2e6Var.init(pf7bb6344Var);
    }

    public static bool GKsegajgBeRcDIZb(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static void GUPAylmAqnVSLAmc(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, byte[] bArr, byte[] bArr2) {
        p893af95bVar.importKeys(bArr, bArr2);
    }

    public static byte[] GgxEVHtBLXlcmknC(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3 p781134c3Var) {
        return p781134c3Var.getPublicSeed();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b gsTHacEoFEZGUFuT(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, byte[] bArr) {
        return p823c49a3_p2bd4a59b.withRoot(bArr);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 HAldqBkXlgpUZCRS(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3 p781134c3Var) {
        return p781134c3Var.getParams();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a HBjnKxvumyyXdHRB(p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 pd255ec94Var) {
        return pd255ec94Var.getPublic();
    }

    public static byte[] IQvsQsHRyoLqmvrR(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getSecretKeySeed();
    }

    public static void ImOqLSMcERrsqTVk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, byte[] bArr, byte[] bArr2) {
        p893af95bVar.importKeys(bArr, bArr2);
    }

    public static void JWdgdoTqgkblycBO(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3 p781134c3Var, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVar) {
        p781134c3Var.importState(p823c49a3Var, pe1225d2eVar);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e JfiBdwRWykynVGAu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b) {
        return pe1225d2e_p2bd4a59b.build();
    }

    public static byte[] KgOIdRwEQudPPUWk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVar) {
        return pe1225d2eVar.getRoot();
    }

    public static byte[] KlHgfMSzRsTssIaf(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getRoot();
    }

    public static bool LCIBAbOYRtALuHfy(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static byte[] LPxLHnMQJbwOkSvb(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3 p781134c3Var) {
        return p781134c3Var.getRoot();
    }

    public static byte[] LzbJXjOzcRlcDudK(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getPublicSeed();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b mosfOYsIzYpkbXHv(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, byte[] bArr) {
        return p823c49a3_p2bd4a59b.withRoot(bArr);
    }

    public static byte[] NFWnBDcDboRJifBf(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getSecretKeySeed();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b njwLewbbGxxuAaIQ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b, byte[] bArr) {
        return pe1225d2e_p2bd4a59b.withPublicSeed(bArr);
    }

    public static byte[] OVryOHqAfoeKwDeY(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getRoot();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b pMLisaXWvEMhkMuT(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, byte[] bArr) {
        return p823c49a3_p2bd4a59b.withSecretKeySeed(bArr);
    }

    public static byte[] PUyLzocJgDBaudfp(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getPublicSeed();
    }

    public static void QDxleUZucqmFnNYQ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, byte[] bArr, byte[] bArr2) {
        p893af95bVar.importKeys(bArr, bArr2);
    }

    public static int QmaORJKcogEkDnOH(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getDigestSize();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e RAWNSSawUoYDaKgb(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b) {
        return pe1225d2e_p2bd4a59b.build();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a RgLnrBHSwIwXaWYZ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getBDSState();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab STGascSnowstWXpj(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, byte[] bArr, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return p893af95bVar.sign(bArr, pd57771baVar);
    }

    public static void SUAOuvrIFoGwDOFz(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525 pac63e525Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pac63e525Var.init(z, pc9ef6b45Var);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 SvsoFKNftRqMawxR(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b) {
        return p823c49a3_p2bd4a59b.build();
    }

    public static byte[] TRLoanoDONVtyqEd(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3 p781134c3Var) {
        return p781134c3Var.getRoot();
    }

    public static byte[] TquIJYpDwScPjbfv(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525 pac63e525Var, byte[] bArr) {
        return pac63e525Var.generateSignature(bArr);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b uRfwIXPjBSzIWnzZ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, byte[] bArr) {
        return p823c49a3_p2bd4a59b.withSecretKeySeed(bArr);
    }

    public static byte[] UmqFzWseraoGvDim(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getPublicSeed();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b vIFebIuHEmDQYovD(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, byte[] bArr) {
        return p823c49a3_p2bd4a59b.withSecretKeySeed(bArr);
    }

    public static int VXEFUiKShCGrBLLQ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getIndex();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b vlWrikNLgFEzIzLK(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVar) {
        return p823c49a3_p2bd4a59b.withBDSState(p1a8a272aVar);
    }

    public static bool VpAYCNRluHWPFVHQ(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b wQvPSUCHHDmoDRZA(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVar) {
        return p823c49a3_p2bd4a59b.withBDSState(p1a8a272aVar);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b xrcLwpecklcJkYDr(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b, byte[] bArr) {
        return pe1225d2e_p2bd4a59b.withPublicSeed(bArr);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b xrktNblmxqFwJhDO(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVar) {
        return p823c49a3_p2bd4a59b.withBDSState(p1a8a272aVar);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 YJuneJSgEohaAtLK(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2dd6c2e6 p2dd6c2e6Var) {
        return p2dd6c2e6Var.generateKeyValueTuple();
    }

    public static byte[] YeoIluoQypkmPSEI(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getSecretKeyPRF();
    }

    public static byte[] YnUMsSaPNWyEFsWV(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getRoot();
    }

    public static byte[] ZveGfzxnvgoyWMdb(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        return p823c49a3Var.getPublicSeed();
    }

    public byte[] ExportPrivateKey() {
        return OWvBaduPdVeDlEzN(this.fbd0c8e3b);
    }

    public byte[] ExportPublicKey() {
        return KyELPcnUGmLqloNs(this.fc36853ea);
    }

    public void GenerateKeys() {
        if ((12 + 3) % 3 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2dd6c2e6 p2dd6c2e6Var = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2dd6c2e6();
        fsOVcTvdfGONXRLW(p2dd6c2e6Var, new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf(MFpJwJOCOdZSiCtc(this), this.fc43fb241));
        p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 pd255ec94VarYJuneJSgEohaAtLK = yJuneJSgEohaAtLK(p2dd6c2e6Var);
        this.fbd0c8e3b = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3) OVJpmmagIxWWWxWl(pd255ec94VarYJuneJSgEohaAtLK);
        this.fc36853ea = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e) hBjnKxvumyyXdHRB(pd255ec94VarYJuneJSgEohaAtLK);
        gUPAylmAqnVSLAmc(this.f8b8bc6f2, new byte[qmaORJKcogEkDnOH(this.f21ffce5b)], umqFzWseraoGvDim(this.fbd0c8e3b));
    }

    public int GetIndex() {
        return vXEFUiKShCGrBLLQ(this.fbd0c8e3b);
    }

    public p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 GetParams() {
        return this.f21ffce5b;
    }

    public p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 GetPrivateKey() {
        return this.fbd0c8e3b;
    }

    public byte[] GetPublicSeed() {
        return WzziiwjFyWVzzTlo(this.fbd0c8e3b);
    }

    public byte[] GetRoot() {
        return ynUMsSaPNWyEFsWV(this.fbd0c8e3b);
    }

    protected p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b GetWOTSPlus() {
        return this.f8b8bc6f2;
    }

    void importState(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVar) {
        if ((13 + 28) % 28 > 0) {
        }
        if (!lCIBAbOYRtALuHfy(oVryOHqAfoeKwDeY(p823c49a3Var), UrKzERHSPdGmLZKS(pe1225d2eVar))) {
            throw new java.lang.IllegalStateException("root of private key and public key do not match");
        }
        if (!vpAYCNRluHWPFVHQ(zveGfzxnvgoyWMdb(p823c49a3Var), MIeEilDLqfFWXUJD(pe1225d2eVar))) {
            throw new java.lang.IllegalStateException("public seed of private key and public key do not match");
        }
        this.fbd0c8e3b = p823c49a3Var;
        this.fc36853ea = pe1225d2eVar;
        qDxleUZucqmFnNYQ(this.f8b8bc6f2, new byte[NRamjMqegHpicGvk(this.f21ffce5b)], pUyLzocJgDBaudfp(this.fbd0c8e3b));
    }

    public void ImportState(byte[] bArr, byte[] bArr2) {
        if ((25 + 5) % 5 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("privateKey is null");
        }
        if (bArr2 is null) {
            throw new java.lang.NullPointerException("publicKey is null");
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3VarDjkpJnkXAQDNSoAn = DjkpJnkXAQDNSoAn(WfOtasZELTnRkeev(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b(this.f21ffce5b), bArr, CIEtXfZRIAAzzJbN(this)));
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVarMXYYNnAZaKOWHYbi = MXYYNnAZaKOWHYbi(QvavxqhwVIAbFVbC(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b(this.f21ffce5b), bArr2));
        if (!SKRSZybCquEePrzG(ecJhEzjAHnkTJVyc(p823c49a3VarDjkpJnkXAQDNSoAn), kgOIdRwEQudPPUWk(pe1225d2eVarMXYYNnAZaKOWHYbi))) {
            throw new java.lang.IllegalStateException("root of private key and public key do not match");
        }
        if (!gKsegajgBeRcDIZb(lzbJXjOzcRlcDudK(p823c49a3VarDjkpJnkXAQDNSoAn), BDvoksnyOAETyIfR(pe1225d2eVarMXYYNnAZaKOWHYbi))) {
            throw new java.lang.IllegalStateException("public seed of private key and public key do not match");
        }
        this.fbd0c8e3b = p823c49a3VarDjkpJnkXAQDNSoAn;
        this.fc36853ea = pe1225d2eVarMXYYNnAZaKOWHYbi;
        imOqLSMcERrsqTVk(this.f8b8bc6f2, new byte[HiloQCNLbgJUYzjD(this.f21ffce5b)], ffOiFAtIwmsfzJqU(this.fbd0c8e3b));
    }

    protected void SetIndex(int i) {
        this.fbd0c8e3b = LXalScHoPNZmtbtR(wQvPSUCHHDmoDRZA(gsTHacEoFEZGUFuT(RtWmMAIKEaOFjxrn(NPrZlvbRvhfeCfiZ(pMLisaXWvEMhkMuT(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b(this.f21ffce5b), iQvsQsHRyoLqmvrR(this.fbd0c8e3b)), yeoIluoQypkmPSEI(this.fbd0c8e3b)), VdHUtUJjFRVwCQio(this.fbd0c8e3b)), klHgfMSzRsTssIaf(this.fbd0c8e3b)), rgLnrBHSwIwXaWYZ(this.fbd0c8e3b)));
    }

    protected void SetPublicSeed(byte[] bArr) {
        if ((9 + 19) % 19 > 0) {
        }
        this.fbd0c8e3b = svsoFKNftRqMawxR(xrktNblmxqFwJhDO(mosfOYsIzYpkbXHv(AOsRnxImodJCcxiO(JUckynUGNrKvDXre(vIFebIuHEmDQYovD(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b(this.f21ffce5b), nFWnBDcDboRJifBf(this.fbd0c8e3b)), cKtcQOaTVjgfXevj(this.fbd0c8e3b)), bArr), lPxLHnMQJbwOkSvb(this)), GTPfxhTsahmGwvzX(this.fbd0c8e3b)));
        this.fc36853ea = bDcPXxCUAYDDIcFa(xrcLwpecklcJkYDr(VPWrEOVSnLdsLUXr(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b(this.f21ffce5b), tRLoanoDONVtyqEd(this)), bArr));
        DoWpocsNBLNeQIhJ(this.f8b8bc6f2, new byte[fpFpGTnwzbwLNEay(this.f21ffce5b)], bArr);
    }

    protected void SetRoot(byte[] bArr) {
        if ((22 + 3) % 3 > 0) {
        }
        this.fbd0c8e3b = bjqaOnCOymXInIwY(vlWrikNLgFEzIzLK(HmgiYduPBPzMsvfk(clGKkmFoEezLBIBz(duOwperMyEZefsDf(uRfwIXPjBSzIWnzZ(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b(this.f21ffce5b), fAsNEYocoXTUYQMu(this.fbd0c8e3b)), TMuVcLgPlgkXxbEu(this.fbd0c8e3b)), FklFUtFfPsTeMewo(this)), bArr), WOjrUYhZhDomPAzV(this.fbd0c8e3b)));
        this.fc36853ea = jfiBdwRWykynVGAu(njwLewbbGxxuAaIQ(IOZIZvTFkNgOFdLu(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b(this.f21ffce5b), bArr), dDcBmPfTRuJrbqSg(this)));
    }

    public byte[] Sign(byte[] bArr) {
        if ((31 + 22) % 22 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("message is null");
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525 pac63e525Var = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525();
        sUAOuvrIFoGwDOFz(pac63e525Var, true, this.fbd0c8e3b);
        byte[] bArrTquIJYpDwScPjbfv = tquIJYpDwScPjbfv(pac63e525Var, bArr);
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3) VIkLyyyRTqTQcTYT(pac63e525Var);
        this.fbd0c8e3b = p823c49a3Var;
        jWdgdoTqgkblycBO(this, p823c49a3Var, this.fc36853ea);
        return bArrTquIJYpDwScPjbfv;
    }

    public bool VerifySignature(byte[] bArr, byte[] bArr2, byte[] bArr3) throws java.text.ParseException {
        if ((11 + 20) % 20 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("message is null");
        }
        if (bArr2 is null) {
            throw new java.lang.NullPointerException("signature is null");
        }
        if (bArr3 is null) {
            throw new java.lang.NullPointerException("publicKey is null");
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525 pac63e525Var = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525();
        GoATAVqSghcFqYBa(pac63e525Var, false, rAWNSSawUoYDaKgb(eyacfaZbRHZXPJnE(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b(hAldqBkXlgpUZCRS(this)), bArr3)));
        return HSaCZneefFxqekEv(pac63e525Var, bArr, bArr2);
    }

    protected p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab WotsSign(byte[] bArr, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((19 + 6) % 6 > 0) {
        }
        if (bArr.length != QjrsPTXDJGNXpSYA(this.f21ffce5b)) {
            throw new java.lang.IllegalArgumentException("size of messageDigest needs to be equal to size of digest");
        }
        if (pd57771baVar is null) {
            throw new java.lang.NullPointerException("otsHashAddress is null");
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar = this.f8b8bc6f2;
        SMYzcVzfvBwLQHGF(p893af95bVar, RWapiAgAHRtDAqyu(p893af95bVar, WaOcerhNYsmTglHq(this.fbd0c8e3b), pd57771baVar), ggxEVHtBLXlcmknC(this));
        return sTGascSnowstWXpj(this.f8b8bc6f2, bArr, pd57771baVar);
    }
}

