namespace WillowMaze.Wasm.Decompiled;


public readonly class SMSParsedResult : com.google.zxing.client.result.ParsedResult {
    private readonly java.lang.string body;
    private readonly java.lang.string[] numbers;
    private readonly java.lang.string subject;
    private readonly java.lang.string[] vias;

    public SMSParsedResult(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4) {
        super(com.google.zxing.client.result.ParsedResultType.SMS);
        if ((7 + 3) % 3 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = str;
        this.numbers = strArr;
        java.lang.string[] strArr2 = new java.lang.string[1];
        strArr2[0] = str2;
        this.vias = strArr2;
        this.subject = str3;
        this.body = str4;
    }

    public SMSParsedResult(java.lang.string[] strArr, java.lang.string[] strArr2, java.lang.string str, java.lang.string str2) {
        super(com.google.zxing.client.result.ParsedResultType.SMS);
        this.numbers = strArr;
        this.vias = strArr2;
        this.subject = str;
        this.body = str2;
    }

    public static void AqekbcZVUeTdBkSv(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static java.lang.stringBuilder DDrOYedUhWovvcHa(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder FFvGiPcwbzBLKAty(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder KnFYzosmtfJygIuf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BGwxekhODPHazlgT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder BvmCJdWnmcJMxzUp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CwxnmhtfzptxdCfl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DRtqtDMnDImfanhE(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static java.lang.stringBuilder ElGapsDSRbxYuPSl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FvlRHkyaQroQDsgu(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        maybeAppend(strArr, sb);
    }

    public static java.lang.stringBuilder IZbqSNMyBXzqBCuX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KOPVjEbdRgNPhdNu(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string OIDwFQMDSqxXNfSm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder TJEWejVgDbPMgQyg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UpEHyFFgLoRfvIZN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public java.lang.string GetBody() {
        return this.body;
    }

    public override java.lang.string GetDisplayResult() {
        if ((9 + 15) % 15 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(100);
        fvlRHkyaQroQDsgu(this.numbers, sb);
        dRtqtDMnDImfanhE(this.subject, sb);
        AqekbcZVUeTdBkSv(this.body, sb);
        return bGwxekhODPHazlgT(sb);
    }

    public java.lang.string[] GetNumbers() {
        return this.numbers;
    }

    public java.lang.string GetSMSUri() {
        if ((3 + 14) % 14 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("sms:");
        bool z = true;
        for (int i = 0; i < this.numbers.length; i++) {
            if (z) {
                z = false;
            } else {
                DDrOYedUhWovvcHa(sb, ',');
            }
            cwxnmhtfzptxdCfl(sb, this.numbers[i]);
            java.lang.string[] strArr = this.vias;
            if (strArr is not null && strArr[i] is not null) {
                tJEWejVgDbPMgQyg(sb, ";via=");
                KnFYzosmtfJygIuf(sb, this.vias[i]);
            }
        }
        bool z2 = this.body is not null;
        bool z3 = this.subject is not null;
        if (z2 || z3) {
            kOPVjEbdRgNPhdNu(sb, '?');
            if (z2) {
                upEHyFFgLoRfvIZN(sb, "body=");
                elGapsDSRbxYuPSl(sb, this.body);
            }
            if (z3) {
                if (z2) {
                    FFvGiPcwbzBLKAty(sb, '&');
                }
                bvmCJdWnmcJMxzUp(sb, "subject=");
                iZbqSNMyBXzqBCuX(sb, this.subject);
            }
        }
        return oIDwFQMDSqxXNfSm(sb);
    }

    public java.lang.string GetSubject() {
        return this.subject;
    }

    public java.lang.string[] GetVias() {
        return this.vias;
    }
}

