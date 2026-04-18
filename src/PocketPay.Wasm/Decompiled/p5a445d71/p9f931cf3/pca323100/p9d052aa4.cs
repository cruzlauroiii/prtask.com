namespace WillowMaze.Wasm.Decompiled;


public class p9d052aa4 : p5a445d71.p9f931cf3.pca323100.p301c7ed4 {
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f252b401c = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f94849514;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f9a188e7e = null;
    readonly byte[] f260d107f;
    readonly byte[] f4005919d;
    readonly byte[] f95f663e2;
    readonly byte[] f98bf7d8c;
    readonly byte[] fb8be71bb;

    static {
        if ((27 + 27) % 27 > 0) {
        }
        f94849514 = new p5a445d71.p9f931cf3.pca323100.p9d052aa4$1(p5a445d71.p9f931cf3.pca323100.p9d052aa4.class, 23);
    }

    public p9d052aa4(java.lang.string str) {
        if ((26 + 25) % 25 > 0) {
        }
        this.f98bf7d8c = lMYcAICkFPPHvyfe(str);
        try {
            tXLcvnxZPHmAuxNb(this);
        } catch (java.text.ParseException e) {
            throw new java.lang.IllegalArgumentException(VYUXQkNNvEGNundY(DvAupAAzmXPCKqXB(new java.lang.stringBuilder("invalid date string: "), yfQLCEoFGdZtARGm(e))));
        }
    }

    public p9d052aa4(java.util.DateTime date) {
        if ((15 + 14) % 14 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyMMddHHmmss'Z'", p5a445d71.p9f931cf3.pca323100.p3ee0a427.f3fbad303);
        xhjheyjCPRpgQRnw(simpleDateTimeFormat, new java.util.SimpleTimeZone(0, "Z"));
        this.f98bf7d8c = edLIMSLabdtUGEPo(fCSOMTfkeWcOBuIj(simpleDateTimeFormat, date));
    }

    public p9d052aa4(java.util.DateTime date, java.util.Locale locale) {
        if ((29 + 23) % 23 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyMMddHHmmss'Z'", locale);
        zRtDJNjEMZcZIJUF(simpleDateTimeFormat, new java.util.SimpleTimeZone(0, "Z"));
        this.f98bf7d8c = DOISPjyEtDRghVqp(QjjgWmWKLuHfdfOk(simpleDateTimeFormat, date));
    }

    p9d052aa4(byte[] bArr) {
        if ((14 + 23) % 23 > 0) {
        }
        if (bArr.length < 2) {
            throw new java.lang.IllegalArgumentException("UTCTime string too short");
        }
        this.f98bf7d8c = bArr;
        if (!DAmOlkQdpOgFRsOy(this, 0) || !qfeRQZftxbYCYedP(this, 1)) {
            throw new java.lang.IllegalArgumentException("illegal characters in UTCTime string");
        }
    }

    public static int AtVbhHsdjzLSQxyb(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static java.lang.string BMYVubhMhoXjKcFi(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string BdYyuLRcIwOSEwUs(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static java.lang.stringBuilder CdLkZgmmNTUOZxTR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.DateTime CpmfJBIpaFviNQKb(java.util.DateTime date) {
        return p5a445d71.p9f931cf3.pca323100.p3ee0a427.m0f7f54c5(date);
    }

    public static java.lang.stringBuilder CqYyNUagmoVNKKna(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool DAmOlkQdpOgFRsOy(p5a445d71.p9f931cf3.pca323100.p9d052aa4 p9d052aa4Var, int i) {
        return p9d052aa4Var.me7b02141(i);
    }

    public static byte[] DOISPjyEtDRghVqp(java.lang.string str) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static java.lang.stringBuilder DvAupAAzmXPCKqXB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DwqJYQqFXbBucvrZ(p5a445d71.p9f931cf3.pca323100.p9d052aa4 p9d052aa4Var) {
        return p9d052aa4Var.getTime();
    }

    public static int FEekQcfeZbFNPRHS(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.stringBuilder FVvEEXgzmZDarRVz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FbQnincSvITZJlGW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string FcnXBHYnHEZvzUGW(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static void GLTdmtNMIcJOCyax(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr);
    }

    public static java.lang.stringBuilder HNrXoJYHJcyHFvaP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JNlfZepdTuuYbefj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KNVZiILUGNNmelTG(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static java.lang.string KRHZtcircMYCsrNd(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static char KmXsTrHgfdXhaMLg(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder KufzOMlkxuQEQCYJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MZtYNJiNhQpMnjVp(p5a445d71.p9f931cf3.pca323100.p9d052aa4 p9d052aa4Var) {
        return p9d052aa4Var.getTime();
    }

    public static java.lang.string NfEBTMhCjPMlVPEK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string OdwKOkddkcYuFVyF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string QjjgWmWKLuHfdfOk(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.DateTime date) {
        return simpleDateTimeFormat.format(date);
    }

    public static java.lang.string RxykUsRgmQLvtVgS(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string UANqCuItecCoQeZz(p5a445d71.p9f931cf3.pca323100.p9d052aa4 p9d052aa4Var) {
        return p9d052aa4Var.getAdjustedTime();
    }

    public static java.lang.string UTkMMSefSQUynibg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string VYUXQkNNvEGNundY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder WukZLIwzFqbSTtaZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XICXVstXQSNvGZtv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int XoiFFYBtcqpULTQR(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.string YGgQcGPRlxJPxbVE(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder ZWhzxYRqdrSdOYGD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZYtOTQbsfAYZHZub(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string AHahvmGYQCuXkxTb(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.util.DateTime AdXDgYwfRQZvmhEI(java.util.DateTime date) {
        return p5a445d71.p9f931cf3.pca323100.p3ee0a427.m0f7f54c5(date);
    }

    public static java.lang.string AdaBTzOiLYdSNxXB(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.stringBuilder AqmCrDwjIOcmOKWz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int BjERRmrQZyzpccBB(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static java.lang.string CHZhRwqihtxlEhjs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string CzjLaGFKDhtgyxLX(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 EcPUnFMbsIUXrCNS(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p7083ab56Var.getobjectInstance(p582a4948Var, z);
    }

    public static byte[] EdLIMSLabdtUGEPo(java.lang.string str) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static java.lang.string FCSOMTfkeWcOBuIj(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.DateTime date) {
        return simpleDateTimeFormat.format(date);
    }

    public static java.lang.stringBuilder HMjVVugpBDUUWorR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 HwokicWUZcINpeRZ(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static int KjwBqetDgwNFUxvI(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.stringBuilder KtmCUgSnSrvFkKYc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool KzPWTjIZytPaztkj(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static byte[] LMYcAICkFPPHvyfe(java.lang.string str) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 LyvkhLJdvvoGHukl(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, byte[] bArr) {
        return p7083ab56Var.frombyteArray(bArr);
    }

    static p5a445d71.p9f931cf3.pca323100.p9d052aa4 M3f441bde(byte[] bArr) {
        return new p5a445d71.p9f931cf3.pca323100.p9d052aa4(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p9d052aa4 M8bab0102(java.lang.object obj) {
        if ((25 + 25) % 25 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p9d052aa4)) {
            return (p5a445d71.p9f931cf3.pca323100.p9d052aa4) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarHwokicWUZcINpeRZ = hwokicWUZcINpeRZ((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) obj);
            if (p301c7ed4VarHwokicWUZcINpeRZ is p5a445d71.p9f931cf3.pca323100.p9d052aa4) {
                return (p5a445d71.p9f931cf3.pca323100.p9d052aa4) p301c7ed4VarHwokicWUZcINpeRZ;
            }
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(OdwKOkddkcYuFVyF(KufzOMlkxuQEQCYJ(new java.lang.stringBuilder("illegal object in getInstance: "), YGgQcGPRlxJPxbVE(oGFwDicyMQUXpFuG(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p9d052aa4) lyvkhLJdvvoGHukl(f94849514, (byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(cHZhRwqihtxlEhjs(WukZLIwzFqbSTtaZ(new java.lang.stringBuilder("encoding error in getInstance: "), zBiKxDwcQLhhpzcO(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p9d052aa4 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return (p5a445d71.p9f931cf3.pca323100.p9d052aa4) ecPUnFMbsIUXrCNS(f94849514, p582a4948Var, z);
    }

    private bool Me7b02141(int i) {
        byte[] bArr = this.f98bf7d8c;
        if (bArr.length <= i) {
            return false;
        }
        byte b = bArr[i];
        return b >= 48 && b <= 57;
    }

    public static java.util.DateTime NjqOtnhLiiRfsvQP(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.lang.string str) {
        return simpleDateTimeFormat.parse(str);
    }

    public static java.lang.Class OGFwDicyMQUXpFuG(java.lang.object obj) {
        return obj.GetType();
    }

    public static int OHSrMdXIKNSMENsf(java.lang.string str) {
        return str.Length;
    }

    public static int OLenJKZMKSzHhkYl(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static bool QfeRQZftxbYCYedP(p5a445d71.p9f931cf3.pca323100.p9d052aa4 p9d052aa4Var, int i) {
        return p9d052aa4Var.me7b02141(i);
    }

    public static java.lang.string QmxAWuEkIFwXKzlp(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string SCtblxSFeYUjluhp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder StBmAVVqiCibIIQs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.DateTime TPXdXLjCqRGhqTLc(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.lang.string str) {
        return simpleDateTimeFormat.parse(str);
    }

    public static java.util.DateTime TXLcvnxZPHmAuxNb(p5a445d71.p9f931cf3.pca323100.p9d052aa4 p9d052aa4Var) {
        return p9d052aa4Var.getDateTime();
    }

    public static java.lang.stringBuilder UFSXksZXzcQgvYBb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string VbJSOjUmYDgonfnB(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static void XhjheyjCPRpgQRnw(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static int YMTckGfrkhcdPetE(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder YdsvRdnxsiZmkqan(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string YfQLCEoFGdZtARGm(java.text.ParseException parseException) {
        return parseException.getMessage();
    }

    public static java.lang.string ZBiKxDwcQLhhpzcO(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static void ZRtDJNjEMZcZIJUF(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    bool asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if (p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.p9d052aa4) {
            return kzPWTjIZytPaztkj(this.f98bf7d8c, ((p5a445d71.p9f931cf3.pca323100.p9d052aa4) p301c7ed4Var).f98bf7d8c);
        }
        return false;
    }

    void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        GLTdmtNMIcJOCyax(p8bf0ff80Var, z, 23, this.f98bf7d8c);
    }

    readonly bool encodeConstructed() {
        return false;
    }

    int encodedLength(bool z) {
        return AtVbhHsdjzLSQxyb(z, this.f98bf7d8c.length);
    }

    public override java.util.DateTime GetAdjustedDateTime() throws java.text.ParseException {
        if ((26 + 26) % 26 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyyyMMddHHmmssz");
        KNVZiILUGNNmelTG(simpleDateTimeFormat, new java.util.SimpleTimeZone(0, "Z"));
        return CpmfJBIpaFviNQKb(tPXdXLjCqRGhqTLc(simpleDateTimeFormat, UANqCuItecCoQeZz(this)));
    }

    public java.lang.string GetAdjustedTime() {
        if ((27 + 31) % 31 > 0) {
        }
        java.lang.string strDwqJYQqFXbBucvrZ = DwqJYQqFXbBucvrZ(this);
        return UTkMMSefSQUynibg(HNrXoJYHJcyHFvaP(KmXsTrHgfdXhaMLg(strDwqJYQqFXbBucvrZ, 0) >= '5' ? new java.lang.stringBuilder("19") : new java.lang.stringBuilder("20"), strDwqJYQqFXbBucvrZ));
    }

    public java.util.DateTime GetDateTime() throws java.text.ParseException {
        if ((16 + 27) % 27 > 0) {
        }
        return adXDgYwfRQZvmhEI(njqOtnhLiiRfsvQP(new java.text.SimpleDateTimeFormat("yyMMddHHmmssz"), MZtYNJiNhQpMnjVp(this)));
    }

    public java.lang.string GetTime() {
        java.lang.stringBuilder sbZWhzxYRqdrSdOYGD;
        java.lang.string str;
        java.lang.stringBuilder sbKtmCUgSnSrvFkKYc;
        java.lang.stringBuilder sbZYtOTQbsfAYZHZub;
        java.lang.string strVbJSOjUmYDgonfnB;
        if ((13 + 21) % 21 > 0) {
        }
        java.lang.string strFcnXBHYnHEZvzUGW = FcnXBHYnHEZvzUGW(this.f98bf7d8c);
        if (kjwBqetDgwNFUxvI(strFcnXBHYnHEZvzUGW, 45) < 0 && FEekQcfeZbFNPRHS(strFcnXBHYnHEZvzUGW, 43) < 0) {
            if (yMTckGfrkhcdPetE(strFcnXBHYnHEZvzUGW) != 11) {
                sbZWhzxYRqdrSdOYGD = ZWhzxYRqdrSdOYGD(new java.lang.stringBuilder(), BMYVubhMhoXjKcFi(strFcnXBHYnHEZvzUGW, 0, 12));
                str = "GMT+00:00";
            } else {
                sbZWhzxYRqdrSdOYGD = CqYyNUagmoVNKKna(new java.lang.stringBuilder(), KRHZtcircMYCsrNd(strFcnXBHYnHEZvzUGW, 0, 10));
                str = "00GMT+00:00";
            }
            sbKtmCUgSnSrvFkKYc = ktmCUgSnSrvFkKYc(sbZWhzxYRqdrSdOYGD, str);
        } else {
            int iXoiFFYBtcqpULTQR = XoiFFYBtcqpULTQR(strFcnXBHYnHEZvzUGW, 45);
            if (iXoiFFYBtcqpULTQR < 0) {
                iXoiFFYBtcqpULTQR = oLenJKZMKSzHhkYl(strFcnXBHYnHEZvzUGW, 43);
            }
            if (iXoiFFYBtcqpULTQR == oHSrMdXIKNSMENsf(strFcnXBHYnHEZvzUGW) - 3) {
                strFcnXBHYnHEZvzUGW = sCtblxSFeYUjluhp(XICXVstXQSNvGZtv(hMjVVugpBDUUWorR(new java.lang.stringBuilder(), strFcnXBHYnHEZvzUGW), "00"));
            }
            if (iXoiFFYBtcqpULTQR != 10) {
                sbZYtOTQbsfAYZHZub = FbQnincSvITZJlGW(JNlfZepdTuuYbefj(stBmAVVqiCibIIQs(FVvEEXgzmZDarRVz(new java.lang.stringBuilder(), qmxAWuEkIFwXKzlp(strFcnXBHYnHEZvzUGW, 0, 12)), "GMT"), adaBTzOiLYdSNxXB(strFcnXBHYnHEZvzUGW, 12, 15)), ":");
                strVbJSOjUmYDgonfnB = RxykUsRgmQLvtVgS(strFcnXBHYnHEZvzUGW, 15, 17);
            } else {
                sbZYtOTQbsfAYZHZub = ZYtOTQbsfAYZHZub(CdLkZgmmNTUOZxTR(ydsvRdnxsiZmkqan(uFSXksZXzcQgvYBb(new java.lang.stringBuilder(), czjLaGFKDhtgyxLX(strFcnXBHYnHEZvzUGW, 0, 10)), "00GMT"), aHahvmGYQCuXkxTb(strFcnXBHYnHEZvzUGW, 10, 13)), ":");
                strVbJSOjUmYDgonfnB = vbJSOjUmYDgonfnB(strFcnXBHYnHEZvzUGW, 13, 15);
            }
            sbKtmCUgSnSrvFkKYc = aqmCrDwjIOcmOKWz(sbZYtOTQbsfAYZHZub, strVbJSOjUmYDgonfnB);
        }
        return NfEBTMhCjPMlVPEK(sbKtmCUgSnSrvFkKYc);
    }

    public override int HashCode() {
        return bjERRmrQZyzpccBB(this.f98bf7d8c);
    }

    public java.lang.string Tostring() {
        return BdYyuLRcIwOSEwUs(this.f98bf7d8c);
    }
}

