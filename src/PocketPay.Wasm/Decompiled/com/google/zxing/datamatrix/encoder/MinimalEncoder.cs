namespace WillowMaze.Wasm.Decompiled;


public readonly class MinimalEncoder {
    static readonly char[] C40_SHIFT2_CHARS = {'!', '\"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_'};

    private MinimalEncoder() {
    }

    public static int AbPZJcNnFWxsBEBw(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }

    public static int BiCcTyncbQrkSWyC(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.access$300(minimalEncoder$Edge);
    }

    public static char CAPyEkyHZujrkYfB(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static void CDnfSoksrPzOUtBo(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][] minimalEncoder$EdgeArr, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        addEdge(minimalEncoder$EdgeArr, minimalEncoder$Edge);
    }

    public static java.lang.stringBuilder DadmtanulTPAfLKf(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool DdwPfXJZDZTZeIpr(char c, int i) {
        return isExtendedASCII(c, i);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode DoStgkTlpiuMbcgA(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getEndMode();
    }

    public static java.lang.string EFNWPVjKdKuqGmyu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool EGzryColFzmUQaSl(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isNativeX12(c);
    }

    public static void GJyuUBaxYENDZxIs(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][] minimalEncoder$EdgeArr, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        addEdge(minimalEncoder$EdgeArr, minimalEncoder$Edge);
    }

    public static char GbNstHRrumDPMYrL(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static char HetaSBdzeAQUxXLC(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static java.lang.string IBGqSIXeISKkBSpS(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static int ISyjcZVtTjOXyspa(java.lang.string str) {
        return str.Length;
    }

    public static bool IsBxAOUBBZxnnXDD(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i, int i2) {
        return minimalEncoder$Input.haveNchars(i, i2);
    }

    public static java.lang.object JmppXDysEZlObxvC(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static bool KDrQdpxhjMBvHaQl(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isNativeEDIFACT(c);
    }

    public static byte[] KOTrfwIEpwNDJwRy(java.lang.string str, java.nio.charset.Charset charset, int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, int i2) {
        return encode(str, charset, i, symbolShapeHint, i2);
    }

    public static char KqNLoKSzRjtGHafK(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static int LHyqejLqclYxlnue(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i, bool z, int[] iArr) {
        return getNumberOfC40Words(minimalEncoder$Input, i, z, iArr);
    }

    public static bool MWglhltVlyHhVgVn(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static int MYejShIwvdHngxDV(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }

    public static bool OFdMdcYVKqKgOreL(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i, int i2) {
        return minimalEncoder$Input.haveNchars(i, i2);
    }

    public static bool PsFQPuXDacUUwKph(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isNativeText(c);
    }

    public static bool QtWwcxEdHeEdeyln(java.lang.string str, java.lang.string str2) {
        return str.EndsWith(str2);
    }

    public static bool SCOEjQuqrEodcbHS(char c) {
        return isInC40Shift1HashSet(c);
    }

    public static char SDfDWcKNmcFxltkr(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static int SFLHUHCJLDhTQJrF(java.lang.string str) {
        return str.Length;
    }

    public static bool TWysznbyROgAxYph(char c) {
        return isInC40Shift1HashSet(c);
    }

    public static bool TixPmtDPuhBzVPfl(char c) {
        return isInTextShift1HashSet(c);
    }

    public static void TjHlfYPkzpDuLWSr(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][] minimalEncoder$EdgeArr, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        addEdge(minimalEncoder$EdgeArr, minimalEncoder$Edge);
    }

    public static int UByVfQnwIEVNnIkn(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.access$300(minimalEncoder$Edge);
    }

    public static int VJOFTKLbXfVeXMqu(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.Length;
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode VPIeqFvFuMnbUCcB(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getEndMode();
    }

    public static char WUiiJBsWBVaTpXEM(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static java.lang.string XJfZKPFvLNZxhrpw(java.lang.string str, java.nio.charset.Charset charset, int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint) {
        return encodeHighLevel(str, charset, i, symbolShapeHint);
    }

    public static void XLUFIKmfTEDPnpsj(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][] minimalEncoder$EdgeArr, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        addEdge(minimalEncoder$EdgeArr, minimalEncoder$Edge);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode YBCyKEVtmzxrGVhm(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getEndMode();
    }

    public static bool ZWuQfquPmhcPDqCA(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isNativeEDIFACT(c);
    }

    public static void ZgqgytNQdQTCrHIq(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][] minimalEncoder$EdgeArr, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        addEdge(minimalEncoder$EdgeArr, minimalEncoder$Edge);
    }

    public static void ZxVEgaNMcaLNqpBF(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][] minimalEncoder$EdgeArr, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        addEdge(minimalEncoder$EdgeArr, minimalEncoder$Edge);
    }

    static bool access$600(char c) {
        return TWysznbyROgAxYph(c);
    }

    static bool access$700(char c) {
        return TixPmtDPuhBzVPfl(c);
    }

    static bool access$800(char c, int i) {
        return lIEiyWwcnTnCcifp(c, i);
    }

    static bool access$900(char c, int i) {
        return koCWArUlvszVYRUr(c, i);
    }

    static void AddEdge(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][] minimalEncoder$EdgeArr, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        if ((5 + 1) % 1 > 0) {
        }
        int iCIPtBLePflcjkLbC = cIPtBLePflcjkLbC(minimalEncoder$Edge) + xUAXiTCqmziSKZhR(minimalEncoder$Edge);
        if (minimalEncoder$EdgeArr[iCIPtBLePflcjkLbC][AbPZJcNnFWxsBEBw(VPIeqFvFuMnbUCcB(minimalEncoder$Edge))] is not null && gtTLUjHUqenjmlbF(minimalEncoder$EdgeArr[iCIPtBLePflcjkLbC][nsOdgYcaPSGjAJbK(DoStgkTlpiuMbcgA(minimalEncoder$Edge))]) <= UByVfQnwIEVNnIkn(minimalEncoder$Edge)) {
            return;
        }
        minimalEncoder$EdgeArr[iCIPtBLePflcjkLbC][MYejShIwvdHngxDV(YBCyKEVtmzxrGVhm(minimalEncoder$Edge))] = minimalEncoder$Edge;
    }

    static void AddEdges(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][] minimalEncoder$EdgeArr, int i, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        if ((25 + 9) % 9 > 0) {
        }
        if (cyEETFzmBknOpEjf(minimalEncoder$Input, i)) {
            ZxVEgaNMcaLNqpBF(minimalEncoder$EdgeArr, new com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge(minimalEncoder$Input, com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII, i, 1, minimalEncoder$Edge, null));
            return;
        }
        char cGUlDjlbkYTAipwJH = gUlDjlbkYTAipwJH(minimalEncoder$Input, i);
        int i2 = 0;
        if (minimalEncoder$Edge is null || mnCJqoDjxPwHgVJl(minimalEncoder$Edge) != com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.EDF) {
            if (fuyKiVgTEOqzZeAz(cGUlDjlbkYTAipwJH) && IsBxAOUBBZxnnXDD(minimalEncoder$Input, i, 2) && sliQJbPvJgkSuOAJ(SDfDWcKNmcFxltkr(minimalEncoder$Input, i + 1))) {
                TjHlfYPkzpDuLWSr(minimalEncoder$EdgeArr, new com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge(minimalEncoder$Input, com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII, i, 2, minimalEncoder$Edge, null));
            } else {
                XLUFIKmfTEDPnpsj(minimalEncoder$EdgeArr, new com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge(minimalEncoder$Input, com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII, i, 1, minimalEncoder$Edge, null));
            }
            com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode[] minimalEncoder$ModeArr = new com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode[2];
            minimalEncoder$ModeArr[0] = com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.C40;
            minimalEncoder$ModeArr[1] = com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.TEXT;
            for (int i3 = 0; i3 < 2; i3++) {
                com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode = minimalEncoder$ModeArr[i3];
                int[] iArr = new int[1];
                if (LHyqejLqclYxlnue(minimalEncoder$Input, i, minimalEncoder$Mode == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.C40, iArr) > 0) {
                    eurYZORbvyRuEIcp(minimalEncoder$EdgeArr, new com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge(minimalEncoder$Input, minimalEncoder$Mode, i, iArr[0], minimalEncoder$Edge, null));
                }
            }
            if (iNwBThCfrxrRPsTg(minimalEncoder$Input, i, 3) && xIEYsBHXoKntkUAy(KqNLoKSzRjtGHafK(minimalEncoder$Input, i)) && EGzryColFzmUQaSl(GbNstHRrumDPMYrL(minimalEncoder$Input, i + 1)) && oYZAKgZVjinCarQW(cihnNrGDWxuvolpt(minimalEncoder$Input, i + 2))) {
                ZgqgytNQdQTCrHIq(minimalEncoder$EdgeArr, new com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge(minimalEncoder$Input, com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.X12, i, 3, minimalEncoder$Edge, null));
            }
            hfTNJCCCTPsjUwLl(minimalEncoder$EdgeArr, new com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge(minimalEncoder$Input, com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.B256, i, 1, minimalEncoder$Edge, null));
        }
        while (i2 < 3) {
            int i4 = i + i2;
            if (!OFdMdcYVKqKgOreL(minimalEncoder$Input, i4, 1) || !ZWuQfquPmhcPDqCA(CAPyEkyHZujrkYfB(minimalEncoder$Input, i4))) {
                break;
            }
            int i5 = i2 + 1;
            CDnfSoksrPzOUtBo(minimalEncoder$EdgeArr, new com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge(minimalEncoder$Input, com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.EDF, i, i5, minimalEncoder$Edge, null));
            i2 = i5;
        }
        if (i2 == 3 && lRWHNstfQNDkXrhp(minimalEncoder$Input, i, 4) && KDrQdpxhjMBvHaQl(HetaSBdzeAQUxXLC(minimalEncoder$Input, i + 3))) {
            GJyuUBaxYENDZxIs(minimalEncoder$EdgeArr, new com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge(minimalEncoder$Input, com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.EDF, i, 4, minimalEncoder$Edge, null));
        }
    }

    public static int CIPtBLePflcjkLbC(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.access$100(minimalEncoder$Edge);
    }

    public static char CihnNrGDWxuvolpt(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static bool CyEETFzmBknOpEjf(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input.isECI(i);
    }

    public static bool DYZYgYsueEwKdeYt(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isNativeText(c);
    }

    public static int ERONMQNLhdNjjDaB(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.getFNC1char();
    }

    static byte[] Encode(java.lang.string str, java.nio.charset.Charset charset, int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, int i2) {
        if ((1 + 21) % 21 > 0) {
        }
        return vkxHDXSQjkKEXMgJ(mGNmGnrvQOXfCXnb(new com.google.zxing.datamatrix.encoder.MinimalEncoder$Input(str, charset, i, symbolShapeHint, i2, null)));
    }

    public static java.lang.string EncodeHighLevel(java.lang.string str) {
        if ((32 + 2) % 2 > 0) {
        }
        return XJfZKPFvLNZxhrpw(str, null, -1, com.google.zxing.datamatrix.encoder.SymbolShapeHint.FORCE_NONE);
    }

    public static java.lang.string EncodeHighLevel(java.lang.string str, java.nio.charset.Charset charset, int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint) {
        int i2;
        if ((25 + 31) % 31 > 0) {
        }
        if (MWglhltVlyHhVgVn(str, "[)>\u001e05\u001d") && QtWwcxEdHeEdeyln(str, "\u001e\u0004")) {
            str = IBGqSIXeISKkBSpS(str, zoKJduRCBcCoFJHW("[)>\u001e05\u001d"), ISyjcZVtTjOXyspa(str) - 2);
            i2 = 5;
        } else if (kOCTmHlGhWRJEJuQ(str, "[)>\u001e06\u001d") && kPMCzdOlDhrJRPqv(str, "\u001e\u0004")) {
            str = noBnVXdNdIwQOIuo(str, jSEjgGRlUgKVKoGu("[)>\u001e06\u001d"), SFLHUHCJLDhTQJrF(str) - 2);
            i2 = 6;
        } else {
            i2 = 0;
        }
        return new java.lang.string(KOTrfwIEpwNDJwRy(str, charset, i, symbolShapeHint, i2), java.nio.charset.StandardCharsets.ISO_8859_1);
    }

    static com.google.zxing.datamatrix.encoder.MinimalEncoder$Result encodeMinimally(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        if ((3 + 24) % 24 > 0) {
        }
        int iXayusoBaaomZJfYC = xayusoBaaomZJfYC(minimalEncoder$Input);
        int i = iXayusoBaaomZJfYC + 1;
        int[] iArr = new int[2];
        iArr[1] = 6;
        int i2 = 0;
        iArr[0] = i;
        com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][] minimalEncoder$EdgeArr = (com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][]) JmppXDysEZlObxvC(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.class, iArr);
        xbigusChqaymTPeI(minimalEncoder$Input, minimalEncoder$EdgeArr, 0, null);
        for (int i3 = 1; i3 <= iXayusoBaaomZJfYC; i3++) {
            for (int i4 = 0; i4 < 6; i4++) {
                com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge = minimalEncoder$EdgeArr[i3][i4];
                if (minimalEncoder$Edge is not null && i3 < iXayusoBaaomZJfYC) {
                    ycYLyHjXumoYCwfk(minimalEncoder$Input, minimalEncoder$EdgeArr, i3, minimalEncoder$Edge);
                }
            }
            for (int i5 = 0; i5 < 6; i5++) {
                minimalEncoder$EdgeArr[i3 - 1][i5] = null;
            }
        }
        int i6 = -1;
        int i7 = int.MAX_VALUE;
        while (i2 < 6) {
            com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge2 = minimalEncoder$EdgeArr[iXayusoBaaomZJfYC][i2];
            if (minimalEncoder$Edge2 is not null) {
                int iBiCcTyncbQrkSWyC = (i2 >= 1 && i2 <= 3) ? BiCcTyncbQrkSWyC(minimalEncoder$Edge2) + 1 : wQDImYvGzIzJQQHZ(minimalEncoder$Edge2);
                if (iBiCcTyncbQrkSWyC < i7) {
                    i6 = i2;
                    i7 = iBiCcTyncbQrkSWyC;
                }
            }
            i2++;
        }
        if (i6 < 0) {
            throw new java.lang.Exception(EFNWPVjKdKuqGmyu(fovMjAFZebjTIjQe(DadmtanulTPAfLKf(new java.lang.stringBuilder("Internal error: failed to encode \""), minimalEncoder$Input), "\"")));
        }
        return new com.google.zxing.datamatrix.encoder.MinimalEncoder$Result(minimalEncoder$EdgeArr[iXayusoBaaomZJfYC][i6]);
    }

    public static void EurYZORbvyRuEIcp(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][] minimalEncoder$EdgeArr, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        addEdge(minimalEncoder$EdgeArr, minimalEncoder$Edge);
    }

    public static java.lang.stringBuilder FovMjAFZebjTIjQe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool FuyKiVgTEOqzZeAz(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static char GUlDjlbkYTAipwJH(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    static int GetNumberOfC40Words(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i, bool z, int[] iArr) {
        if ((7 + 9) % 9 > 0) {
        }
        int i2 = 0;
        for (int i3 = i; i3 < VJOFTKLbXfVeXMqu(minimalEncoder$Input); i3++) {
            if (jDdhenHFLKndmYnE(minimalEncoder$Input, i3)) {
                iArr[0] = 0;
                return 0;
            }
            char cWUiiJBsWBVaTpXEM = WUiiJBsWBVaTpXEM(minimalEncoder$Input, i3);
            if ((z && nUYIqFFgPCfaYMAc(cWUiiJBsWBVaTpXEM)) || (!z && PsFQPuXDacUUwKph(cWUiiJBsWBVaTpXEM))) {
                i2++;
            } else if (DdwPfXJZDZTZeIpr(cWUiiJBsWBVaTpXEM, eRONMQNLhdNjjDaB(minimalEncoder$Input))) {
                int i4 = cWUiiJBsWBVaTpXEM & 255;
                i2 = (i4 >= 128 && ((z && jRnlLcTsYcgxhdAg((char) (i4 + (-128)))) || (!z && dYZYgYsueEwKdeYt((char) (i4 + (-128)))))) ? i2 + 3 : i2 + 4;
            } else {
                i2 += 2;
            }
            if (i2 % 3 == 0 || ((i2 - 2) % 3 == 0 && i3 + 1 == mvNslRZmRliDCbZV(minimalEncoder$Input))) {
                iArr[0] = (i3 - i) + 1;
                return (int) sVIwqcReiQnyXjUj(((double) i2) / 3.0d);
            }
        }
        iArr[0] = 0;
        return 0;
    }

    public static int GtTLUjHUqenjmlbF(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.access$300(minimalEncoder$Edge);
    }

    public static void HfTNJCCCTPsjUwLl(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][] minimalEncoder$EdgeArr, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        addEdge(minimalEncoder$EdgeArr, minimalEncoder$Edge);
    }

    public static bool INwBThCfrxrRPsTg(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i, int i2) {
        return minimalEncoder$Input.haveNchars(i, i2);
    }

    static bool IsExtendedASCII(char c, int i) {
        return c != i && c >= 128 && c <= 255;
    }

    private static bool IsInC40Shift1HashSet(char c) {
        return c <= 31;
    }

    private static bool IsInC40Shift2HashSet(char c, int i) {
        if ((3 + 5) % 5 > 0) {
        }
        foreach (char C2 in C40_SHIFT2_CHARS) {
            if (c2 == c) {
                return true;
            }
        }
        return c == i;
    }

    private static bool IsInTextShift1HashSet(char c) {
        return SCOEjQuqrEodcbHS(c);
    }

    private static bool IsInTextShift2HashSet(char c, int i) {
        return yGPnPvDzEtuLcAym(c, i);
    }

    public static bool JDdhenHFLKndmYnE(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input.isECI(i);
    }

    public static bool JRnlLcTsYcgxhdAg(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isNativeC40(c);
    }

    public static int JSEjgGRlUgKVKoGu(java.lang.string str) {
        return str.Length;
    }

    public static bool KOCTmHlGhWRJEJuQ(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool KPMCzdOlDhrJRPqv(java.lang.string str, java.lang.string str2) {
        return str.EndsWith(str2);
    }

    public static bool KoCWArUlvszVYRUr(char c, int i) {
        return isInTextShift2HashSet(c, i);
    }

    public static bool LIEiyWwcnTnCcifp(char c, int i) {
        return isInC40Shift2HashSet(c, i);
    }

    public static bool LRWHNstfQNDkXrhp(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i, int i2) {
        return minimalEncoder$Input.haveNchars(i, i2);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Result mGNmGnrvQOXfCXnb(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return encodeMinimally(minimalEncoder$Input);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode mnCJqoDjxPwHgVJl(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getEndMode();
    }

    public static int MvNslRZmRliDCbZV(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.Length;
    }

    public static bool NUYIqFFgPCfaYMAc(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isNativeC40(c);
    }

    public static java.lang.string NoBnVXdNdIwQOIuo(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static int NsOdgYcaPSGjAJbK(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }

    public static bool OYZAKgZVjinCarQW(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isNativeX12(c);
    }

    public static double SVIwqcReiQnyXjUj(double d) {
        if ((13 + 13) % 13 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static bool SliQJbPvJgkSuOAJ(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static byte[] VkxHDXSQjkKEXMgJ(com.google.zxing.datamatrix.encoder.MinimalEncoder$Result minimalEncoder$Result) {
        return minimalEncoder$Result.getbytes();
    }

    public static int WQDImYvGzIzJQQHZ(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.access$300(minimalEncoder$Edge);
    }

    public static bool XIEYsBHXoKntkUAy(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isNativeX12(c);
    }

    public static int XUAXiTCqmziSKZhR(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.access$200(minimalEncoder$Edge);
    }

    public static int XayusoBaaomZJfYC(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.Length;
    }

    public static void XbigusChqaymTPeI(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][] minimalEncoder$EdgeArr, int i, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        addEdges(minimalEncoder$Input, minimalEncoder$EdgeArr, i, minimalEncoder$Edge);
    }

    public static bool YGPnPvDzEtuLcAym(char c, int i) {
        return isInC40Shift2HashSet(c, i);
    }

    public static void YcYLyHjXumoYCwfk(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge[][] minimalEncoder$EdgeArr, int i, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        addEdges(minimalEncoder$Input, minimalEncoder$EdgeArr, i, minimalEncoder$Edge);
    }

    public static int ZoKJduRCBcCoFJHW(java.lang.string str) {
        return str.Length;
    }
}

