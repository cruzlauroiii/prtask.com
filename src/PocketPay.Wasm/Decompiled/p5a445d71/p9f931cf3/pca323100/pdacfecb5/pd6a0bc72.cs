namespace WillowMaze.Wasm.Decompiled;


public class pd6a0bc72 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    public static readonly int f19e88a40 = 0;
    public static readonly int f2a47a8f9 = 1;
    public static readonly int f4ca6d0e0 = 1;
    public static readonly int f897f2ea8 = 0;
    public static readonly int fa80cf476 = 0;
    public static readonly int fc15bed2a = 1;
    public static readonly int fe3a8c757 = 1;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb8b73df0 f035cd498;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.pcaf0afb6 f1b693453;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 f1bebf131;
    private int f1cb1e9c6;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb8b73df0 f2364da61;
    private int f2af72f10;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 f8ff1c90f;
    private int f9ebd1c54;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.pcaf0afb6 fc3c2ec65;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 fc8d71092;
    private int fd3911965;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 fe3ef0071;

    private pd6a0bc72(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        if ((24 + 21) % 21 > 0) {
        }
        this.f2af72f10 = 1;
        int iYKyBAQXYdEsjZtvu = YKyBAQXYdEsjZtvu(p582a4948Var);
        if (iYKyBAQXYdEsjZtvu == 0) {
            this.fc3c2ec65 = SEylLMJnsczvbPDb(p582a4948Var, true);
        } else {
            if (iYKyBAQXYdEsjZtvu != 1) {
                throw new java.lang.IllegalArgumentException("unknown tag in Holder");
            }
            this.f8ff1c90f = wsrsLVZIwqniFetM(p582a4948Var, true);
        }
        this.f2af72f10 = 0;
    }

    private pd6a0bc72(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((19 + 9) % 9 > 0) {
        }
        this.f2af72f10 = 1;
        if (PrZIYPcekEXPCQDJ(p80f8c729Var) > 3) {
            throw new java.lang.IllegalArgumentException(RFMqAWhKLWsnJvbn(knsaXnjDRdBdzHZi(new java.lang.stringBuilder("Bad sequence size: "), BmpBIhzFlxemfZPi(p80f8c729Var))));
        }
        for (int i = 0; i != rmhhTZXShwaYTodQ(p80f8c729Var); i++) {
            p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948VarEaMmqfJnmpKoanRj = eaMmqfJnmpKoanRj(TlGSUCpTdLZJYzlm(p80f8c729Var, i));
            int iNSENNQTrmRCUwUEp = nSENNQTrmRCUwUEp(p582a4948VarEaMmqfJnmpKoanRj);
            if (iNSENNQTrmRCUwUEp == 0) {
                this.fc3c2ec65 = BeTYtdLSJzPZtBmZ(p582a4948VarEaMmqfJnmpKoanRj, false);
            } else if (iNSENNQTrmRCUwUEp == 1) {
                this.f8ff1c90f = IyYfzRbmrztNfZPV(p582a4948VarEaMmqfJnmpKoanRj, false);
            } else {
                if (iNSENNQTrmRCUwUEp != 2) {
                    throw new java.lang.IllegalArgumentException("unknown tag in Holder");
                }
                this.f035cd498 = AqVFUILKhdhwAdHo(p582a4948VarEaMmqfJnmpKoanRj, false);
            }
        }
        this.f2af72f10 = 1;
    }

    public pd6a0bc72(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb8b73df0 pb8b73df0Var) {
        this.f2af72f10 = 1;
        this.f035cd498 = pb8b73df0Var;
    }

    public pd6a0bc72(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pcaf0afb6 pcaf0afb6Var) {
        this(pcaf0afb6Var, 1);
    }

    public pd6a0bc72(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pcaf0afb6 pcaf0afb6Var, int i) {
        this.fc3c2ec65 = pcaf0afb6Var;
        this.f2af72f10 = i;
    }

    public pd6a0bc72(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var) {
        this(pfb202cf8Var, 1);
    }

    public pd6a0bc72(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var, int i) {
        this.f8ff1c90f = pfb202cf8Var;
        this.f2af72f10 = i;
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb8b73df0 AqVFUILKhdhwAdHo(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb8b73df0.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pcaf0afb6 BeTYtdLSJzPZtBmZ(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pcaf0afb6.m8bab0102(p582a4948Var, z);
    }

    public static int BmpBIhzFlxemfZPi(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 IyYfzRbmrztNfZPV(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8.m8bab0102(p582a4948Var, z);
    }

    public static void KKQJhtetqpfkbkZF(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void OEttHsblBalOMydL(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int PrZIYPcekEXPCQDJ(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static java.lang.string RFMqAWhKLWsnJvbn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pcaf0afb6 SEylLMJnsczvbPDb(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pcaf0afb6.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 TlGSUCpTdLZJYzlm(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void UigriqEnBCjnKqud(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int YKyBAQXYdEsjZtvu(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 ETBSjWDhCDyCTWJN(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p582a4948 EaMmqfJnmpKoanRj(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p582a4948 EpWaAkmhyPecUiEn(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(obj);
    }

    public static java.lang.stringBuilder KnsaXnjDRdBdzHZi(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p582a4948) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72(epWaAkmhyPecUiEn(obj));
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72(eTBSjWDhCDyCTWJN(obj));
    }

    public static int NSENNQTrmRCUwUEp(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static int RmhhTZXShwaYTodQ(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 WsrsLVZIwqniFetM(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8.m8bab0102(p582a4948Var, z);
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pcaf0afb6 GetBaseCertificateID() {
        return this.fc3c2ec65;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 GetEntityName() {
        return this.f8ff1c90f;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb8b73df0 GetobjectDigestInfo() {
        return this.f035cd498;
    }

    public int GetVersion() {
        return this.f2af72f10;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((26 + 4) % 4 > 0) {
        }
        if (this.f2af72f10 != 1) {
            return this.f8ff1c90f is null ? new p5a445d71.p9f931cf3.pca323100.p87af127c(true, 0, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.fc3c2ec65) : new p5a445d71.p9f931cf3.pca323100.p87af127c(true, 1, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.f8ff1c90f);
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(3);
        if (this.fc3c2ec65 is not null) {
            KKQJhtetqpfkbkZF(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 0, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.fc3c2ec65));
        }
        if (this.f8ff1c90f is not null) {
            UigriqEnBCjnKqud(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 1, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.f8ff1c90f));
        }
        if (this.f035cd498 is not null) {
            OEttHsblBalOMydL(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 2, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.f035cd498));
        }
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

