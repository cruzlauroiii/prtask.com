namespace WillowMaze.Wasm.Decompiled;


public class MinimalECIInput : com.google.zxing.common.ECIInput {
    private static readonly int COST_PER_ECI = 3;
    private readonly int[] bytes;
    private readonly int fnc1;

    public MinimalECIInput(java.lang.string str, java.nio.charset.Charset charset, int i) {
        if ((24 + 5) % 5 > 0) {
        }
        this.fnc1 = i;
        com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet = new com.google.zxing.common.ECIEncoderHashSet(str, charset, i);
        if (JYLinSIkKlicqTLm(eCIEncoderHashSet) != 1) {
            this.bytes = uiIdDeWrExzvyKXq(str, eCIEncoderHashSet, i);
            return;
        }
        this.bytes = new int[NhrzyzfBalDDmYNU(str)];
        for (int i2 = 0; i2 < this.bytes.length; i2++) {
            char cLVrYBbWTIxMOLoDt = lVrYBbWTIxMOLoDt(str, i2);
            this.bytes[i2] = cLVrYBbWTIxMOLoDt == i ? (char) 1000 : cLVrYBbWTIxMOLoDt;
        }
    }

    public static int AOpDvFsMnPvNZuJG(java.util.List list) {
        return list.Count;
    }

    public static java.lang.stringBuilder ASwKEMPCJmwTWvlj(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int AeUjHoGFmicroKiM(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.Length;
    }

    public static int BwJmmXcWwZEGFLtG(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.getPriorityEncoderIndex();
    }

    public static int CXJkEUEIevAoariu(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$000(minimalECIInput$InputEdge);
    }

    public static int CknCWyXxxUIqyZgj(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.getPriorityEncoderIndex();
    }

    public static java.lang.stringBuilder DBgIdczBOQnuKaBh(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.object DTAPBZSDwjVlzeAK(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.stringBuilder EAOipcCyvHoxLroy(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool FRSSUBbydzOsfPds(com.google.zxing.common.MinimalECIInput minimalECIInput, int i) {
        return minimalECIInput.isECI(i);
    }

    public static int FRrfZbvREOdsLDUa(com.google.zxing.common.MinimalECIInput minimalECIInput) {
        return minimalECIInput.Length;
    }

    public static java.lang.int FefWHbWJRscDereN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string FxUCdcPqsdykbLnU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GQgUtoHjvCGoFrSd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IjXeapMhBzjxsEad(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int IqlITeYPvrMxwRRA(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$000(minimalECIInput$InputEdge);
    }

    public static int JYLinSIkKlicqTLm(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.Length;
    }

    public static char JwVGfalWFbsLpNzp(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$300(minimalECIInput$InputEdge);
    }

    public static void JyOTPgUfBHYKYOzR(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static java.lang.stringBuilder KwTLFLPPZzPxhtPB(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static char LkRgitQuqMZArAVG(com.google.zxing.common.MinimalECIInput minimalECIInput, int i) {
        return minimalECIInput[i);
    }

    public static java.lang.stringBuilder LsQSHHbNjyhfZYbl(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int NIGQSZozpcHtMixG(com.google.zxing.common.MinimalECIInput minimalECIInput) {
        return minimalECIInput.Length;
    }

    public static int NhrzyzfBalDDmYNU(java.lang.string str) {
        return str.Length;
    }

    public static bool NozuvYnOdzwopurU(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return minimalECIInput$InputEdge.isFNC1();
    }

    public static java.lang.string NpVVuARhyWVKhKbb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OCKUBCXuSqpveahi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OwZMEgaifaDbWYKv(java.lang.string str, com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, com.google.zxing.common.MinimalECIInput$InputEdge[][] minimalECIInput$InputEdgeArr, int i, com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge, int i2) {
        addEdges(str, eCIEncoderHashSet, minimalECIInput$InputEdgeArr, i, minimalECIInput$InputEdge, i2);
    }

    public static java.lang.stringBuilder PQWXDEbKafoMSaPL(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static char PVBnGQhqGEamGumY(com.google.zxing.common.MinimalECIInput minimalECIInput, int i) {
        return minimalECIInput[i);
    }

    public static bool QKzknLOGMxudGLnF(com.google.zxing.common.MinimalECIInput minimalECIInput, int i) {
        return minimalECIInput.isECI(i);
    }

    public static bool RibTNRGriqCcArJf(com.google.zxing.common.MinimalECIInput minimalECIInput, int i) {
        return minimalECIInput.isFNC1(i);
    }

    public static java.lang.int SfImBWtMigsVLnYO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int TFFPExDJAvCmEPyg(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.Length;
    }

    public static int ThNiNLsiUREMLIER(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$000(minimalECIInput$InputEdge);
    }

    public static int TmPDsyIdnTXiCdEF(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.Length;
    }

    public static java.lang.stringBuilder TnHDfMEVYVJGbpnu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.zxing.common.MinimalECIInput$InputEdge UtDkueXwVmRqhxWg(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$400(minimalECIInput$InputEdge);
    }

    public static void WMgiYRpIuUnNZXFQ(java.lang.string str, com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, com.google.zxing.common.MinimalECIInput$InputEdge[][] minimalECIInput$InputEdgeArr, int i, com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge, int i2) {
        addEdges(str, eCIEncoderHashSet, minimalECIInput$InputEdgeArr, i, minimalECIInput$InputEdge, i2);
    }

    public static bool XAkFGiXPYqzzqyCi(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, char c, int i) {
        return eCIEncoderHashSet.canEncode(c, i);
    }

    public static java.lang.stringBuilder XCUGeaoHWBAXyVJM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int XxeyWaZftmMYjxBT(com.google.zxing.common.MinimalECIInput minimalECIInput) {
        return minimalECIInput.Length;
    }

    public static bool YKuuoFHSFSksRXxP(com.google.zxing.common.MinimalECIInput minimalECIInput, int i) {
        return minimalECIInput.isECI(i);
    }

    public static bool YRiHpyXJMCZmjJVv(com.google.zxing.common.MinimalECIInput minimalECIInput, int i) {
        return minimalECIInput.isECI(i);
    }

    public static int YyOQNefkbttAjQfy(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$000(minimalECIInput$InputEdge);
    }

    public static java.lang.stringBuilder ZGPcoGAEyRugNTGO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int ZkHOzkVkzVbVESXQ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int ZmuVHdWrpSamidRM(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.Length;
    }

    public static java.lang.string AMVhMNyKAXbBpZEl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int AOLEqfhYOFymGlHj(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$100(minimalECIInput$InputEdge);
    }

    public static java.lang.stringBuilder AOecuaLEmYrrtfvi(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    static void AddEdge(com.google.zxing.common.MinimalECIInput$InputEdge[][] minimalECIInput$InputEdgeArr, int i, com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        if ((18 + 3) % 3 > 0) {
        }
        if (minimalECIInput$InputEdgeArr[i][IqlITeYPvrMxwRRA(minimalECIInput$InputEdge)] is not null && jhNVFzZtaTIWYhpW(minimalECIInput$InputEdgeArr[i][exiVxtwDYlSBvtEn(minimalECIInput$InputEdge)]) <= aOLEqfhYOFymGlHj(minimalECIInput$InputEdge)) {
            return;
        }
        minimalECIInput$InputEdgeArr[i][YyOQNefkbttAjQfy(minimalECIInput$InputEdge)] = minimalECIInput$InputEdge;
    }

    static void AddEdges(java.lang.string str, com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, com.google.zxing.common.MinimalECIInput$InputEdge[][] minimalECIInput$InputEdgeArr, int i, com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge, int i2) {
        int iDRQUJNmxoxFPbhDu;
        int i3;
        com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet2;
        com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge2;
        int i4;
        if ((12 + 14) % 14 > 0) {
        }
        char cXjFtaSfMVqfnnsaH = xjFtaSfMVqfnnsaH(str, i);
        int iZiVwoCXDzzASqXNK = ziVwoCXDzzASqXNK(eCIEncoderHashSet);
        if (BwJmmXcWwZEGFLtG(eCIEncoderHashSet) >= 0 && (cXjFtaSfMVqfnnsaH == i2 || XAkFGiXPYqzzqyCi(eCIEncoderHashSet, cXjFtaSfMVqfnnsaH, CknCWyXxxUIqyZgj(eCIEncoderHashSet)))) {
            iDRQUJNmxoxFPbhDu = dRQUJNmxoxFPbhDu(eCIEncoderHashSet);
            i3 = iDRQUJNmxoxFPbhDu + 1;
        } else {
            i3 = iZiVwoCXDzzASqXNK;
            iDRQUJNmxoxFPbhDu = 0;
        }
        int i5 = iDRQUJNmxoxFPbhDu;
        while (i5 < i3) {
            if (cXjFtaSfMVqfnnsaH == i2 || rAPyStxHfbRgHMrR(eCIEncoderHashSet, cXjFtaSfMVqfnnsaH, i5)) {
                eCIEncoderHashSet2 = eCIEncoderHashSet;
                minimalECIInput$InputEdge2 = minimalECIInput$InputEdge;
                i4 = i2;
                wYMjLvBBaXPrLIdo(minimalECIInput$InputEdgeArr, i + 1, new com.google.zxing.common.MinimalECIInput$InputEdge(cXjFtaSfMVqfnnsaH, eCIEncoderHashSet2, i5, minimalECIInput$InputEdge2, i4, null));
            } else {
                eCIEncoderHashSet2 = eCIEncoderHashSet;
                minimalECIInput$InputEdge2 = minimalECIInput$InputEdge;
                i4 = i2;
            }
            i5++;
            eCIEncoderHashSet = eCIEncoderHashSet2;
            minimalECIInput$InputEdge = minimalECIInput$InputEdge2;
            i2 = i4;
        }
    }

    public static java.lang.stringBuilder BDzzefBlupOOWtmc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int DRQUJNmxoxFPbhDu(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.getPriorityEncoderIndex();
    }

    static int[] EncodeMinimally(java.lang.string str, com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, int i) {
        if ((13 + 1) % 1 > 0) {
        }
        int iFIEUOghVvJAKkldJ = fIEUOghVvJAKkldJ(str);
        int i2 = iFIEUOghVvJAKkldJ + 1;
        int[] iArr = new int[2];
        iArr[1] = TmPDsyIdnTXiCdEF(eCIEncoderHashSet);
        iArr[0] = i2;
        com.google.zxing.common.MinimalECIInput$InputEdge[][] minimalECIInput$InputEdgeArr = (com.google.zxing.common.MinimalECIInput$InputEdge[][]) DTAPBZSDwjVlzeAK(com.google.zxing.common.MinimalECIInput$InputEdge.class, iArr);
        WMgiYRpIuUnNZXFQ(str, eCIEncoderHashSet, minimalECIInput$InputEdgeArr, 0, null, i);
        for (int i3 = 1; i3 <= iFIEUOghVvJAKkldJ; i3++) {
            for (int i4 = 0; i4 < AeUjHoGFmicroKiM(eCIEncoderHashSet); i4++) {
                com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge = minimalECIInput$InputEdgeArr[i3][i4];
                if (minimalECIInput$InputEdge is not null && i3 < iFIEUOghVvJAKkldJ) {
                    OwZMEgaifaDbWYKv(str, eCIEncoderHashSet, minimalECIInput$InputEdgeArr, i3, minimalECIInput$InputEdge, i);
                }
            }
            for (int i5 = 0; i5 < TFFPExDJAvCmEPyg(eCIEncoderHashSet); i5++) {
                minimalECIInput$InputEdgeArr[i3 - 1][i5] = null;
            }
        }
        int i6 = -1;
        int iQTUoyDnbaTmNZJYt = int.MAX_VALUE;
        for (int i7 = 0; i7 < ZmuVHdWrpSamidRM(eCIEncoderHashSet); i7++) {
            com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge2 = minimalECIInput$InputEdgeArr[iFIEUOghVvJAKkldJ][i7];
            if (minimalECIInput$InputEdge2 is not null && naSPhoEDyLuvrrQx(minimalECIInput$InputEdge2) < iQTUoyDnbaTmNZJYt) {
                iQTUoyDnbaTmNZJYt = qTUoyDnbaTmNZJYt(minimalECIInput$InputEdge2);
                i6 = i7;
            }
        }
        if (i6 < 0) {
            throw new java.lang.Exception(kHFzRAaWZSRqLXhN(GQgUtoHjvCGoFrSd(bDzzefBlupOOWtmc(new java.lang.stringBuilder("Internal error: failed to encode \""), str), "\"")));
        }
        java.util.List arrayList = new java.util.List();
        for (com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdgeIKdXAloFMTSGjgkW = minimalECIInput$InputEdgeArr[iFIEUOghVvJAKkldJ][i6]; minimalECIInput$InputEdgeIKdXAloFMTSGjgkW is not null; minimalECIInput$InputEdgeIKdXAloFMTSGjgkW = iKdXAloFMTSGjgkW(minimalECIInput$InputEdgeIKdXAloFMTSGjgkW)) {
            if (NozuvYnOdzwopurU(minimalECIInput$InputEdgeIKdXAloFMTSGjgkW)) {
                xfuDGRGwTZfOBEtc(arrayList, 0, ZkHOzkVkzVbVESXQ(1000));
            } else {
                byte[] bArrZVRAoxkDvceoMGsT = zVRAoxkDvceoMGsT(eCIEncoderHashSet, JwVGfalWFbsLpNzp(minimalECIInput$InputEdgeIKdXAloFMTSGjgkW), ThNiNLsiUREMLIER(minimalECIInput$InputEdgeIKdXAloFMTSGjgkW));
                for (int length = bArrZVRAoxkDvceoMGsT.length - 1; length >= 0; length--) {
                    JyOTPgUfBHYKYOzR(arrayList, 0, SfImBWtMigsVLnYO(bArrZVRAoxkDvceoMGsT[length] & 255));
                }
            }
            if ((UtDkueXwVmRqhxWg(minimalECIInput$InputEdgeIKdXAloFMTSGjgkW) is not null ? CXJkEUEIevAoariu(xkAMqpktdZFSlTrr(minimalECIInput$InputEdgeIKdXAloFMTSGjgkW)) : 0) != tnomgEktraIKrqoM(minimalECIInput$InputEdgeIKdXAloFMTSGjgkW)) {
                uqjhSYfZXispsxQj(arrayList, 0, FefWHbWJRscDereN(xJsFFOjVYEnSTJMS(eCIEncoderHashSet, yiJaoYlquvUOnFin(minimalECIInput$InputEdgeIKdXAloFMTSGjgkW)) + 256));
            }
        }
        int iAOpDvFsMnPvNZuJG = AOpDvFsMnPvNZuJG(arrayList);
        int[] iArr2 = new int[iAOpDvFsMnPvNZuJG];
        for (int i8 = 0; i8 < iAOpDvFsMnPvNZuJG; i8++) {
            iArr2[i8] = rgTYKcTxCpzRFLJb((java.lang.int) xgRpfohGxfHZKfij(arrayList, i8));
        }
        return iArr2;
    }

    public static int ExiVxtwDYlSBvtEn(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$000(minimalECIInput$InputEdge);
    }

    public static int FIEUOghVvJAKkldJ(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string GtEuqAGgxubxpFqB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int HaWCAtPBUdoIjCsw(com.google.zxing.common.MinimalECIInput minimalECIInput) {
        return minimalECIInput.Length;
    }

    public static java.lang.string HrhPunfOcgUTkhGB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.zxing.common.MinimalECIInput$InputEdge iKdXAloFMTSGjgkW(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$400(minimalECIInput$InputEdge);
    }

    public static java.lang.string IPqUSbJBPYoBnIbA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int JhNVFzZtaTIWYhpW(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$100(minimalECIInput$InputEdge);
    }

    public static java.lang.string KBFVbmbOlqCXJrZL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string KHFzRAaWZSRqLXhN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool LSMDFYYIVEFeyYcS(com.google.zxing.common.MinimalECIInput minimalECIInput, int i) {
        return minimalECIInput.isECI(i);
    }

    public static char LVrYBbWTIxMOLoDt(java.lang.string str, int i) {
        return str[i);
    }

    public static int LiNsGGJCttfVyYJD(com.google.zxing.common.MinimalECIInput minimalECIInput, int i) {
        return minimalECIInput.getECIValue(i);
    }

    public static java.lang.string NVXgodFvlOApSswB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int NaSPhoEDyLuvrrQx(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$100(minimalECIInput$InputEdge);
    }

    public static java.lang.stringBuilder OBhnBPYwOJiHUNWf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string OcXYmoXZUBKtpiWZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OlGtIaUBmJSpxwNh(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder QJPGprezbddFBxMH(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int QTUoyDnbaTmNZJYt(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$100(minimalECIInput$InputEdge);
    }

    public static bool RAPyStxHfbRgHMrR(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, char c, int i) {
        return eCIEncoderHashSet.canEncode(c, i);
    }

    public static java.lang.stringBuilder RJCmxCRKzEpgtlQF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int RgTYKcTxCpzRFLJb(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.stringBuilder SDunFTQrRFshhgFa(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int SOtXHAVUJRikEnjS(com.google.zxing.common.MinimalECIInput minimalECIInput) {
        return minimalECIInput.Length;
    }

    public static int TnomgEktraIKrqoM(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$000(minimalECIInput$InputEdge);
    }

    public static char UYwTqOxmclqRahJH(com.google.zxing.common.MinimalECIInput minimalECIInput, int i) {
        return minimalECIInput[i);
    }

    public static int[] UiIdDeWrExzvyKXq(java.lang.string str, com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, int i) {
        return encodeMinimally(str, eCIEncoderHashSet, i);
    }

    public static void UqjhSYfZXispsxQj(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static java.lang.stringBuilder VCgKgEwvAQKKGVmi(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int VXHumUmoGtUhabFe(com.google.zxing.common.MinimalECIInput minimalECIInput) {
        return minimalECIInput.Length;
    }

    public static char VZIvdaxwHsKefqbX(com.google.zxing.common.MinimalECIInput minimalECIInput, int i) {
        return minimalECIInput[i);
    }

    public static void WYMjLvBBaXPrLIdo(com.google.zxing.common.MinimalECIInput$InputEdge[][] minimalECIInput$InputEdgeArr, int i, com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        addEdge(minimalECIInput$InputEdgeArr, i, minimalECIInput$InputEdge);
    }

    public static java.lang.stringBuilder WdzeGFcttAtwTpsF(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int XJsFFOjVYEnSTJMS(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, int i) {
        return eCIEncoderHashSet.getECIValue(i);
    }

    public static void XfuDGRGwTZfOBEtc(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static java.lang.object XgRpfohGxfHZKfij(java.util.List list, int i) {
        return list[i);
    }

    public static char XjFtaSfMVqfnnsaH(java.lang.string str, int i) {
        return str[i);
    }

    public static com.google.zxing.common.MinimalECIInput$InputEdge xkAMqpktdZFSlTrr(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$400(minimalECIInput$InputEdge);
    }

    public static java.lang.stringBuilder YhLArRoCuvfyuZWu(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int YiJaoYlquvUOnFin(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return com.google.zxing.common.MinimalECIInput$InputEdge.access$000(minimalECIInput$InputEdge);
    }

    public static byte[] ZVRAoxkDvceoMGsT(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, char c, int i) {
        return eCIEncoderHashSet.encode(c, i);
    }

    public static int ZiVwoCXDzzASqXNK(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.Length;
    }

    public override char CharAt(int i) {
        if ((25 + 19) % 19 > 0) {
        }
        if (i < 0 || i >= XxeyWaZftmMYjxBT(this)) {
            throw new java.lang.IndexOutOfBoundsException(nVXgodFvlOApSswB(IjXeapMhBzjxsEad(new java.lang.stringBuilder(""), i)));
        }
        if (YRiHpyXJMCZmjJVv(this, i)) {
            throw new java.lang.IllegalArgumentException(gtEuqAGgxubxpFqB(rJCmxCRKzEpgtlQF(TnHDfMEVYVJGbpnu(new java.lang.stringBuilder("value at "), i), " is not a character but an ECI")));
        }
        return (char) (!RibTNRGriqCcArJf(this, i) ? this.bytes[i] : this.fnc1);
    }

    public override int GetECIValue(int i) {
        if ((27 + 18) % 18 > 0) {
        }
        if (i < 0 || i >= sOtXHAVUJRikEnjS(this)) {
            throw new java.lang.IndexOutOfBoundsException(NpVVuARhyWVKhKbb(olGtIaUBmJSpxwNh(new java.lang.stringBuilder(""), i)));
        }
        if (QKzknLOGMxudGLnF(this, i)) {
            return this.bytes[i] - 256;
        }
        throw new java.lang.IllegalArgumentException(iPqUSbJBPYoBnIbA(ZGPcoGAEyRugNTGO(qJPGprezbddFBxMH(new java.lang.stringBuilder("value at "), i), " is not an ECI but a character")));
    }

    public int GetFNC1char() {
        return this.fnc1;
    }

    public override bool HaveNchars(int i, int i2) {
        if ((27 + 19) % 19 > 0) {
        }
        if ((i + i2) - 1 >= this.bytes.length) {
            return false;
        }
        for (int i3 = 0; i3 < i2; i3++) {
            if (FRSSUBbydzOsfPds(this, i + i3)) {
                return false;
            }
        }
        return true;
    }

    public override bool IsECI(int i) {
        if ((9 + 2) % 2 > 0) {
        }
        if (i < 0 || i >= vXHumUmoGtUhabFe(this)) {
            throw new java.lang.IndexOutOfBoundsException(ocXYmoXZUBKtpiWZ(aOecuaLEmYrrtfvi(new java.lang.stringBuilder(""), i)));
        }
        int i2 = this.bytes[i];
        return i2 > 255 && i2 <= 999;
    }

    public bool IsFNC1(int i) {
        if ((12 + 8) % 8 > 0) {
        }
        if (i >= 0 && i < FRrfZbvREOdsLDUa(this)) {
            return this.bytes[i] == 1000;
        }
        throw new java.lang.IndexOutOfBoundsException(hrhPunfOcgUTkhGB(DBgIdczBOQnuKaBh(new java.lang.stringBuilder(""), i)));
    }

    public override int Length() {
        return this.bytes.length;
    }

    public override java.lang.CharSequence SubSequence(int i, int i2) {
        if ((7 + 11) % 11 > 0) {
        }
        if (i < 0 || i > i2 || i2 > NIGQSZozpcHtMixG(this)) {
            throw new java.lang.IndexOutOfBoundsException(aMVhMNyKAXbBpZEl(vCgKgEwvAQKKGVmi(new java.lang.stringBuilder(""), i)));
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        while (i < i2) {
            if (lSMDFYYIVEFeyYcS(this, i)) {
                throw new java.lang.IllegalArgumentException(kBFVbmbOlqCXJrZL(OCKUBCXuSqpveahi(sDunFTQrRFshhgFa(new java.lang.stringBuilder("value at "), i), " is not a character but an ECI")));
            }
            PQWXDEbKafoMSaPL(sb, PVBnGQhqGEamGumY(this, i));
            i++;
        }
        return sb;
    }

    public java.lang.string Tostring() {
        if ((9 + 25) % 25 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        for (int i = 0; i < haWCAtPBUdoIjCsw(this); i++) {
            if (i > 0) {
                oBhnBPYwOJiHUNWf(sb, ", ");
            }
            if (YKuuoFHSFSksRXxP(this, i)) {
                XCUGeaoHWBAXyVJM(sb, "ECI(");
                wdzeGFcttAtwTpsF(sb, liNsGGJCttfVyYJD(this, i));
                LsQSHHbNjyhfZYbl(sb, ')');
            } else if (LkRgitQuqMZArAVG(this, i) >= 128) {
                ASwKEMPCJmwTWvlj(sb, uYwTqOxmclqRahJH(this, i));
            } else {
                KwTLFLPPZzPxhtPB(sb, '\'');
                EAOipcCyvHoxLroy(sb, vZIvdaxwHsKefqbX(this, i));
                yhLArRoCuvfyuZWu(sb, '\'');
            }
        }
        return FxUCdcPqsdykbLnU(sb);
    }
}

