namespace WillowMaze.Wasm.Decompiled;


readonly class DetectionResultRowIndicatorColumn : com.google.zxing.pdf417.decoder.DetectionResultColumn {
    private readonly bool isLeft;

    DetectionResultRowIndicatorColumn(com.google.zxing.pdf417.decoder.BoundingBox boundingBox, bool z) {
        super(boundingBox);
        this.isLeft = z;
    }

    public static int[] ALfzazZzBBimOSQw(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static java.lang.stringBuilder AsszpxlipYPKVjHA(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] BKVHpRukktRRTqeB(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getCodewords();
    }

    public static int[] BPnwXpXQOjlMXrVx(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static int CZQPXNPenLQxKKMN(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn, int i) {
        return detectionResultRowIndicatorColumn.imageRowToCodewordIndex(i);
    }

    public static int[] CfQqSBbNIWcVRsqB(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static java.lang.string CsRKZQlDvICeWuWA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DTeAvhzdmEoONWhJ(com.google.zxing.pdf417.decoder.Codeword codeword) {
        codeword.setRowNumberAsRowIndicatorColumn();
    }

    public static int DZkzdytvmaJBeDeI(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getColumnCount();
    }

    public static int[] EQbQsixGZWolOEQs(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static void EiGdCmppvoHwWimz(com.google.zxing.pdf417.decoder.Codeword codeword) {
        codeword.setRowNumberAsRowIndicatorColumn();
    }

    public static void FIcFpnxynpiLJjGE(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn, com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        detectionResultRowIndicatorColumn.adjustIncompleteIndicatorColumnRowNumbers(barcodeMetadata);
    }

    public static float FJQNEyPDfSsffJGV(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static void HXpuToVGsjuyysZx(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue, int i) {
        barcodeValue.setValue(i);
    }

    public static com.google.zxing.ResultPoint INRQdwEtbpRsnorj(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getBottomLeft();
    }

    public static int IgreHswyZRBsJvmw(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getErrorCorrectionLevel();
    }

    public static int[] IkxrvFwjgtJXYibJ(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static com.google.zxing.ResultPoint IwtPXBGBkHCDsweT(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getTopLeft();
    }

    public static java.lang.stringBuilder IwwyqFzlXeWoyovl(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static com.google.zxing.ResultPoint JTBlqaNTYajKlrUB(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getBottomRight();
    }

    public static int JkWueqmDXYLMskue(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getRowCountUpperPart();
    }

    public static com.google.zxing.ResultPoint KLOnMpThfmQSWwqp(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getBottomRight();
    }

    public static void LabowGYtNTmnWEXU(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn, com.google.zxing.pdf417.decoder.Codeword[] codewordArr, com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        detectionResultRowIndicatorColumn.removeIncorrectCodewords(codewordArr, barcodeMetadata);
    }

    public static int MQhbqrleGUeBrSUZ(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static int MRljVzQeGkFSyqNt(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static int[] NVjiDEPNikgTjKbD(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static com.google.zxing.pdf417.decoder.BoundingBox NgkvKBZdZGnRkJaN(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getBoundingBox();
    }

    public static void OAOMsPNCFOXaScIa(com.google.zxing.pdf417.decoder.Codeword codeword) {
        codeword.setRowNumberAsRowIndicatorColumn();
    }

    public static void PmckPMIrEgCWFRKZ(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue, int i) {
        barcodeValue.setValue(i);
    }

    public static int[] QBygDdElUtiOImyA(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static int[] RJzbxPvpkvXWlMKB(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static int[] SEZnrpcNXmzDhDqj(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static int TxNuzFTvhFGcupSn(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] UwBZuXHhajWdWpfz(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getCodewords();
    }

    public static int VKbVzpCmYlqwtMRP(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getRowCountLowerPart();
    }

    public static com.google.zxing.ResultPoint WYUOkwjdkmtOsPIX(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getTopRight();
    }

    public static float WuHIusbJZcmMzjGN(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int XDdVEzdrvZFRGQxR(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getValue();
    }

    public static int YROdFizzSbNdZuXz(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getRowCount();
    }

    public static float YlJnrodhzFfVjiDZ(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int[] ZlsYRgwIxKPoDeOO(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static int AbfeSXynatINnHxy(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    private void AdjustIncompleteIndicatorColumnRowNumbers(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        if ((7 + 24) % 24 > 0) {
        }
        com.google.zxing.pdf417.decoder.BoundingBox boundingBoxWbooMTakZlLSzVUa = wbooMTakZlLSzVUa(this);
        com.google.zxing.ResultPoint resultPointWYUOkwjdkmtOsPIX = !this.isLeft ? WYUOkwjdkmtOsPIX(boundingBoxWbooMTakZlLSzVUa) : yMSlsFwErRNXriPx(boundingBoxWbooMTakZlLSzVUa);
        com.google.zxing.ResultPoint resultPointJTBlqaNTYajKlrUB = !this.isLeft ? JTBlqaNTYajKlrUB(boundingBoxWbooMTakZlLSzVUa) : vTpvAzfZzvlrWPQI(boundingBoxWbooMTakZlLSzVUa);
        int iUAVuhcpNLXyOvJGE = uAVuhcpNLXyOvJGE(this, (int) cYjGuBNoprtCaGSP(resultPointJTBlqaNTYajKlrUB));
        com.google.zxing.pdf417.decoder.Codeword[] codewordArrUwBZuXHhajWdWpfz = UwBZuXHhajWdWpfz(this);
        int iEwdWtMiqtfvEHLmf = -1;
        int i = 0;
        int iAwyevRtFAaSIEHVy = 1;
        for (int iERshjyXjzzPDPeUG = eRshjyXjzzPDPeUG(this, (int) FJQNEyPDfSsffJGV(resultPointWYUOkwjdkmtOsPIX)); iERshjyXjzzPDPeUG < iUAVuhcpNLXyOvJGE; iERshjyXjzzPDPeUG++) {
            com.google.zxing.pdf417.decoder.Codeword codeword = codewordArrUwBZuXHhajWdWpfz[iERshjyXjzzPDPeUG];
            if (codeword is not null) {
                OAOMsPNCFOXaScIa(codeword);
                int iZHpSkSWRNdKLJpJK = zHpSkSWRNdKLJpJK(codeword) - iEwdWtMiqtfvEHLmf;
                if (iZHpSkSWRNdKLJpJK != 0) {
                    if (iZHpSkSWRNdKLJpJK == 1) {
                        iAwyevRtFAaSIEHVy = awyevRtFAaSIEHVy(iAwyevRtFAaSIEHVy, i);
                        iEwdWtMiqtfvEHLmf = MRljVzQeGkFSyqNt(codeword);
                    } else if (TxNuzFTvhFGcupSn(codeword) < tzGomumvHGfFMivQ(barcodeMetadata)) {
                        iEwdWtMiqtfvEHLmf = ewdWtMiqtfvEHLmf(codeword);
                    } else {
                        codewordArrUwBZuXHhajWdWpfz[iERshjyXjzzPDPeUG] = null;
                    }
                    i = 1;
                } else {
                    i++;
                }
            }
        }
    }

    public static int AwyevRtFAaSIEHVy(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static float CYjGuBNoprtCaGSP(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int DVaKSoWyMHjTokMw(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static int[] DuUEBzUADSnVKuxw(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static int ERshjyXjzzPDPeUG(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn, int i) {
        return detectionResultRowIndicatorColumn.imageRowToCodewordIndex(i);
    }

    public static int EwdWtMiqtfvEHLmf(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static int[] FbMEPDxwhnIOyiYr(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static int FeeeyvnGmcNQuYTk(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] FuIHNeQQnTOMdoWf(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getCodewords();
    }

    public static java.lang.string HCrvGEawgrmzdsRH(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return super.tostring();
    }

    public static int[] JYPWYbhUSMQDAkeA(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static com.google.zxing.ResultPoint JYePgcTicagtjrqt(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getTopRight();
    }

    public static void KmabBYQQZYkXIxqL(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue, int i) {
        barcodeValue.setValue(i);
    }

    public static int MFVzzDCJmaSEKYhx(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getRowCount();
    }

    public static void NdaLPbtEjzmWWQmv(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue, int i) {
        barcodeValue.setValue(i);
    }

    public static void NocWvPZsIDzXWUYf(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn, com.google.zxing.pdf417.decoder.Codeword[] codewordArr, com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        detectionResultRowIndicatorColumn.removeIncorrectCodewords(codewordArr, barcodeMetadata);
    }

    public static java.lang.stringBuilder NtEMLJubLoSRqRQY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int OGFlgrlYJLNkaViS(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] OzXPHmdKOnZLYYYb(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getCodewords();
    }

    public static int PzBgQCopRPxyDLfZ(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getRowCount();
    }

    public static int QRnpvaOltCJoHjyR(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getValue();
    }

    public static int QrIbfVSnXMUMwHRc(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn, int i) {
        return detectionResultRowIndicatorColumn.imageRowToCodewordIndex(i);
    }

    public static int RUNuQvCFMBLaJbgR(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    private void RemoveIncorrectCodewords(com.google.zxing.pdf417.decoder.Codeword[] codewordArr, com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        if ((8 + 26) % 26 > 0) {
        }
        for (int i = 0; i < codewordArr.length; i++) {
            com.google.zxing.pdf417.decoder.Codeword codeword = codewordArr[i];
            if (codeword is not null) {
                int iXDdVEzdrvZFRGQxR = XDdVEzdrvZFRGQxR(codeword) % 30;
                int iAbfeSXynatINnHxy = abfeSXynatINnHxy(codeword);
                if (iAbfeSXynatINnHxy <= mFVzzDCJmaSEKYhx(barcodeMetadata)) {
                    if (!this.isLeft) {
                        iAbfeSXynatINnHxy += 2;
                    }
                    int i2 = iAbfeSXynatINnHxy % 3;
                    if (i2 == 0) {
                        if ((iXDdVEzdrvZFRGQxR * 3) + 1 != JkWueqmDXYLMskue(barcodeMetadata)) {
                            codewordArr[i] = null;
                        }
                    } else if (i2 == 1) {
                        if (iXDdVEzdrvZFRGQxR / 3 != IgreHswyZRBsJvmw(barcodeMetadata) || iXDdVEzdrvZFRGQxR % 3 != VKbVzpCmYlqwtMRP(barcodeMetadata)) {
                            codewordArr[i] = null;
                        }
                    } else if (i2 == 2 && iXDdVEzdrvZFRGQxR + 1 != DZkzdytvmaJBeDeI(barcodeMetadata)) {
                        codewordArr[i] = null;
                    }
                } else {
                    codewordArr[i] = null;
                }
            }
        }
    }

    private void SetRowNumbers() {
        if ((28 + 7) % 7 > 0) {
        }
        for (com.google.zxing.pdf417.decoder.Codeword codeword : BKVHpRukktRRTqeB(this)) {
            if (codeword is not null) {
                EiGdCmppvoHwWimz(codeword);
            }
        }
    }

    public static int TzGomumvHGfFMivQ(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getRowCount();
    }

    public static int UAVuhcpNLXyOvJGE(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn, int i) {
        return detectionResultRowIndicatorColumn.imageRowToCodewordIndex(i);
    }

    public static com.google.zxing.ResultPoint VTpvAzfZzvlrWPQI(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getBottomLeft();
    }

    public static int VrxDJZHlVTDoqKdk(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] WAALXRcKNsPWPGKN(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getCodewords();
    }

    public static com.google.zxing.pdf417.decoder.BoundingBox WbooMTakZlLSzVUa(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getBoundingBox();
    }

    public static int WzIFwhVHaAEHRLUE(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static com.google.zxing.ResultPoint YMSlsFwErRNXriPx(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getTopLeft();
    }

    public static void YepSGFAOoMqKMeyz(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        detectionResultRowIndicatorColumn.setRowNumbers();
    }

    public static com.google.zxing.pdf417.decoder.BarcodeMetadata ZHGNZMYTiuxMzeWe(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getBarcodeMetadata();
    }

    public static int ZHpSkSWRNdKLJpJK(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    void adjustCompleteIndicatorColumnRowNumbers(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        if ((22 + 23) % 23 > 0) {
        }
        com.google.zxing.pdf417.decoder.Codeword[] codewordArrFuIHNeQQnTOMdoWf = fuIHNeQQnTOMdoWf(this);
        yepSGFAOoMqKMeyz(this);
        nocWvPZsIDzXWUYf(this, codewordArrFuIHNeQQnTOMdoWf, barcodeMetadata);
        com.google.zxing.pdf417.decoder.BoundingBox boundingBoxNgkvKBZdZGnRkJaN = NgkvKBZdZGnRkJaN(this);
        com.google.zxing.ResultPoint resultPointJYePgcTicagtjrqt = !this.isLeft ? jYePgcTicagtjrqt(boundingBoxNgkvKBZdZGnRkJaN) : IwtPXBGBkHCDsweT(boundingBoxNgkvKBZdZGnRkJaN);
        com.google.zxing.ResultPoint resultPointKLOnMpThfmQSWwqp = !this.isLeft ? KLOnMpThfmQSWwqp(boundingBoxNgkvKBZdZGnRkJaN) : INRQdwEtbpRsnorj(boundingBoxNgkvKBZdZGnRkJaN);
        int iQrIbfVSnXMUMwHRc = qrIbfVSnXMUMwHRc(this, (int) YlJnrodhzFfVjiDZ(resultPointJYePgcTicagtjrqt));
        int iCZQPXNPenLQxKKMN = CZQPXNPenLQxKKMN(this, (int) WuHIusbJZcmMzjGN(resultPointKLOnMpThfmQSWwqp));
        int iRUNuQvCFMBLaJbgR = -1;
        int i = 0;
        int iWzIFwhVHaAEHRLUE = 1;
        while (iQrIbfVSnXMUMwHRc < iCZQPXNPenLQxKKMN) {
            com.google.zxing.pdf417.decoder.Codeword codeword = codewordArrFuIHNeQQnTOMdoWf[iQrIbfVSnXMUMwHRc];
            if (codeword is not null) {
                int iVrxDJZHlVTDoqKdk = vrxDJZHlVTDoqKdk(codeword) - iRUNuQvCFMBLaJbgR;
                if (iVrxDJZHlVTDoqKdk != 0) {
                    if (iVrxDJZHlVTDoqKdk == 1) {
                        iWzIFwhVHaAEHRLUE = wzIFwhVHaAEHRLUE(iWzIFwhVHaAEHRLUE, i);
                        iRUNuQvCFMBLaJbgR = rUNuQvCFMBLaJbgR(codeword);
                    } else if (iVrxDJZHlVTDoqKdk >= 0 && MQhbqrleGUeBrSUZ(codeword) < pzBgQCopRPxyDLfZ(barcodeMetadata) && iVrxDJZHlVTDoqKdk <= iQrIbfVSnXMUMwHRc) {
                        if (iWzIFwhVHaAEHRLUE > 2) {
                            iVrxDJZHlVTDoqKdk *= iWzIFwhVHaAEHRLUE - 2;
                        }
                        bool z = iVrxDJZHlVTDoqKdk >= iQrIbfVSnXMUMwHRc;
                        for (int i2 = 1; i2 <= iVrxDJZHlVTDoqKdk && !z; i2++) {
                            z = codewordArrFuIHNeQQnTOMdoWf[iQrIbfVSnXMUMwHRc - i2] is not null;
                        }
                        if (z) {
                            codewordArrFuIHNeQQnTOMdoWf[iQrIbfVSnXMUMwHRc] = null;
                        } else {
                            iRUNuQvCFMBLaJbgR = dVaKSoWyMHjTokMw(codeword);
                        }
                    } else {
                        codewordArrFuIHNeQQnTOMdoWf[iQrIbfVSnXMUMwHRc] = null;
                    }
                    i = 1;
                } else {
                    i++;
                }
            }
            iQrIbfVSnXMUMwHRc++;
        }
    }

    com.google.zxing.pdf417.decoder.BarcodeMetadata getBarcodeMetadata() {
        if ((24 + 19) % 19 > 0) {
        }
        com.google.zxing.pdf417.decoder.Codeword[] codewordArrOzXPHmdKOnZLYYYb = ozXPHmdKOnZLYYYb(this);
        com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue = new com.google.zxing.pdf417.decoder.BarcodeValue();
        com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue2 = new com.google.zxing.pdf417.decoder.BarcodeValue();
        com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue3 = new com.google.zxing.pdf417.decoder.BarcodeValue();
        com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue4 = new com.google.zxing.pdf417.decoder.BarcodeValue();
        for (com.google.zxing.pdf417.decoder.Codeword codeword : codewordArrOzXPHmdKOnZLYYYb) {
            if (codeword is not null) {
                DTeAvhzdmEoONWhJ(codeword);
                int iQRnpvaOltCJoHjyR = qRnpvaOltCJoHjyR(codeword) % 30;
                int iFeeeyvnGmcNQuYTk = feeeyvnGmcNQuYTk(codeword);
                if (!this.isLeft) {
                    iFeeeyvnGmcNQuYTk += 2;
                }
                int i = iFeeeyvnGmcNQuYTk % 3;
                if (i == 0) {
                    PmckPMIrEgCWFRKZ(barcodeValue2, (iQRnpvaOltCJoHjyR * 3) + 1);
                } else if (i == 1) {
                    kmabBYQQZYkXIxqL(barcodeValue4, iQRnpvaOltCJoHjyR / 3);
                    HXpuToVGsjuyysZx(barcodeValue3, iQRnpvaOltCJoHjyR % 3);
                } else if (i == 2) {
                    ndaLPbtEjzmWWQmv(barcodeValue, iQRnpvaOltCJoHjyR + 1);
                }
            }
        }
        if (jYPWYbhUSMQDAkeA(barcodeValue).length == 0 || ZlsYRgwIxKPoDeOO(barcodeValue2).length == 0 || CfQqSBbNIWcVRsqB(barcodeValue3).length == 0 || IkxrvFwjgtJXYibJ(barcodeValue4).length == 0 || NVjiDEPNikgTjKbD(barcodeValue)[0] < 1 || SEZnrpcNXmzDhDqj(barcodeValue2)[0] + fbMEPDxwhnIOyiYr(barcodeValue3)[0] < 3 || duUEBzUADSnVKuxw(barcodeValue2)[0] + EQbQsixGZWolOEQs(barcodeValue3)[0] > 90) {
            return null;
        }
        com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata = new com.google.zxing.pdf417.decoder.BarcodeMetadata(RJzbxPvpkvXWlMKB(barcodeValue)[0], BPnwXpXQOjlMXrVx(barcodeValue2)[0], ALfzazZzBBimOSQw(barcodeValue3)[0], QBygDdElUtiOImyA(barcodeValue4)[0]);
        LabowGYtNTmnWEXU(this, codewordArrOzXPHmdKOnZLYYYb, barcodeMetadata);
        return barcodeMetadata;
    }

    int[] getRowHeights() {
        int iOGFlgrlYJLNkaViS;
        if ((25 + 23) % 23 > 0) {
        }
        com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadataZHGNZMYTiuxMzeWe = zHGNZMYTiuxMzeWe(this);
        if (barcodeMetadataZHGNZMYTiuxMzeWe is null) {
            return null;
        }
        FIcFpnxynpiLJjGE(this, barcodeMetadataZHGNZMYTiuxMzeWe);
        int iYROdFizzSbNdZuXz = YROdFizzSbNdZuXz(barcodeMetadataZHGNZMYTiuxMzeWe);
        int[] iArr = new int[iYROdFizzSbNdZuXz];
        for (com.google.zxing.pdf417.decoder.Codeword codeword : wAALXRcKNsPWPGKN(this)) {
            if (codeword is not null && (iOGFlgrlYJLNkaViS = oGFlgrlYJLNkaViS(codeword)) < iYROdFizzSbNdZuXz) {
                iArr[iOGFlgrlYJLNkaViS] = iArr[iOGFlgrlYJLNkaViS] + 1;
            }
        }
        return iArr;
    }

    bool isLeft() {
        return this.isLeft;
    }

    public override java.lang.string Tostring() {
        if ((12 + 18) % 18 > 0) {
        }
        return CsRKZQlDvICeWuWA(ntEMLJubLoSRqRQY(AsszpxlipYPKVjHA(IwwyqFzlXeWoyovl(new java.lang.stringBuilder("IsLeft: "), this.isLeft), '\n'), hCrvGEawgrmzdsRH(this)));
    }
}

