namespace WillowMaze.Wasm.Decompiled;


readonly class EdifactEncoder : com.google.zxing.datamatrix.encoder.Encoder {
    EdifactEncoder() {
    }

    public static int ANPZjnEqRwubPVdM(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCodewordCount();
    }

    public static int BHqhujMZJPeTVokX(java.lang.CharSequence charSequence, int i, int i2) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.lookAheadTest(charSequence, i, i2);
    }

    public static int BzBsYrqHRptsVgHZ(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.string DHeCmoFcxixHnAMZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int EfzuYarAqJNYnDqb(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCodewordCount();
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo FPQaUjXwlMoHCRcq(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getSymbolInfo();
    }

    public static int HyBXNhXAIjeJFXde(com.google.zxing.datamatrix.encoder.EdifactEncoder edifactEncoder) {
        return edifactEncoder.getEncodingMode();
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo IMNnPoukjhffcdBW(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getSymbolInfo();
    }

    public static int KIuHkuqYLYtmpaVZ(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCodewordCount();
    }

    public static void KsyVtqADFlJnZyCW(char c) {
        com.google.zxing.datamatrix.encoder.HighLevelEncoder.illegalchar(c);
    }

    public static void LUQvZtsTkwzRRuqb(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, java.lang.string str) {
        encoderobject.writeCodewords(str);
    }

    public static char MfJbgabgHFthVoGb(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string MyEswOjBYDIRGnwd(java.lang.CharSequence charSequence) {
        return encodeToCodewords(charSequence);
    }

    public static void NTwKeyPyerJhJnWN(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.signalEncoderChange(i);
    }

    public static java.lang.stringBuilder NtNOBaMSakfdHBQH(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string RnmcySQoKYqDIxsH(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getMessage();
    }

    public static int TMKDUjKNlqLReelr(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCodewordCount();
    }

    public static void VXdphSZkoIbXyIAl(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, java.lang.string str) {
        encoderobject.writeCodewords(str);
    }

    public static bool WRWXbmiVpTexQprE(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.hasMorechars();
    }

    public static void WYAUzCGLJaHxRuSv(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        encoderobject.resetSymbolInfo();
    }

    public static java.lang.stringBuilder WuLSXzuZWcSkpymK(java.lang.stringBuilder sb, int i, int i2) {
        return sb.delete(i, i2);
    }

    public static int WwrGwrsdMbTqFaoF(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCodewordCount();
    }

    public static void ZKCdNCxplCLIthYU(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.signalEncoderChange(i);
    }

    public static void BLhGpBdwcoBAJdif(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.updateSymbolInfo(i);
    }

    public static int BSlUFutFuJIQdaux(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void BjJkimbAwhbHRdkY(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, java.lang.CharSequence charSequence) {
        handleEOD(encoderobject, charSequence);
    }

    public static java.lang.stringBuilder BxttPFNcoVyaofol(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static char CNbsTGnudUqagMNP(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static void CoFYOeANOJhFXkzD(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.updateSymbolInfo(i);
    }

    private static void EncodeChar(char c, java.lang.stringBuilder sb) {
        if ((28 + 30) % 30 > 0) {
        }
        if (c >= ' ' && c <= '?') {
            thwFGqctscaiKGKv(sb, c);
        } else if (c >= '@' && c <= '^') {
            gshvnZXotyUpWXvg(sb, (char) (c - '@'));
        } else {
            KsyVtqADFlJnZyCW(c);
        }
    }

    private static java.lang.string EncodeToCodewords(java.lang.CharSequence charSequence) {
        if ((25 + 5) % 5 > 0) {
        }
        int iBSlUFutFuJIQdaux = bSlUFutFuJIQdaux(charSequence);
        if (iBSlUFutFuJIQdaux == 0) {
            throw new java.lang.IllegalStateException("stringBuilder must not be empty");
        }
        int iMfJbgabgHFthVoGb = (MfJbgabgHFthVoGb(charSequence, 0) << 18) + ((iBSlUFutFuJIQdaux < 2 ? (char) 0 : cNbsTGnudUqagMNP(charSequence, 1)) << '\f') + ((iBSlUFutFuJIQdaux < 3 ? (char) 0 : oyyYXRRREtoVdJic(charSequence, 2)) << 6) + (iBSlUFutFuJIQdaux >= 4 ? rHivoFOkKzaCwrSI(charSequence, 3) : (char) 0);
        char c = (char) ((iMfJbgabgHFthVoGb >> 16) & 255);
        char c2 = (char) ((iMfJbgabgHFthVoGb >> 8) & 255);
        char c3 = (char) (iMfJbgabgHFthVoGb & 255);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(3);
        NtNOBaMSakfdHBQH(sb, c);
        if (iBSlUFutFuJIQdaux >= 2) {
            glpyUOyijwTapBTW(sb, c2);
        }
        if (iBSlUFutFuJIQdaux >= 3) {
            bxttPFNcoVyaofol(sb, c3);
        }
        return DHeCmoFcxixHnAMZ(sb);
    }

    public static void FEtqsOuAHFmPWRpR(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.signalEncoderChange(i);
    }

    public static java.lang.stringBuilder GlpyUOyijwTapBTW(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder GshvnZXotyUpWXvg(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int HRchClLtOdiqZGuA(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCodewordCount();
    }

    private static void HandleEOD(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, java.lang.CharSequence charSequence) {
        if ((21 + 26) % 26 > 0) {
        }
        try {
            int iBzBsYrqHRptsVgHZ = BzBsYrqHRptsVgHZ(charSequence);
            if (iBzBsYrqHRptsVgHZ == 0) {
                kqslLFFdvftQsEYy(encoderobject, 0);
                return;
            }
            bool z = true;
            if (iBzBsYrqHRptsVgHZ == 1) {
                jvZLJQqZufqQOfby(encoderobject);
                int iKWOiXOAVpPagiNwa = kWOiXOAVpPagiNwa(IMNnPoukjhffcdBW(encoderobject)) - TMKDUjKNlqLReelr(encoderobject);
                int iHqHTIFrYUNCGZzqS = hqHTIFrYUNCGZzqS(encoderobject);
                if (iHqHTIFrYUNCGZzqS > iKWOiXOAVpPagiNwa) {
                    coFYOeANOJhFXkzD(encoderobject, ANPZjnEqRwubPVdM(encoderobject) + 1);
                    iKWOiXOAVpPagiNwa = zUEOrBgCKhbOMdzz(FPQaUjXwlMoHCRcq(encoderobject)) - hRchClLtOdiqZGuA(encoderobject);
                }
                if (iHqHTIFrYUNCGZzqS <= iKWOiXOAVpPagiNwa && iKWOiXOAVpPagiNwa <= 2) {
                    fEtqsOuAHFmPWRpR(encoderobject, 0);
                    return;
                }
            }
            if (iBzBsYrqHRptsVgHZ > 4) {
                throw new java.lang.IllegalStateException("Count must not exceed 4");
            }
            int i = iBzBsYrqHRptsVgHZ - 1;
            java.lang.string strLzfKKSdMlRZAgYwO = lzfKKSdMlRZAgYwO(charSequence);
            if (knfQLUPPcAupKRBR(encoderobject) || i > 2) {
                z = false;
            }
            if (i <= 2) {
                bLhGpBdwcoBAJdif(encoderobject, KIuHkuqYLYtmpaVZ(encoderobject) + i);
                if (nRdGHlWDIXlStomX(wURuneIrKRdvhFkP(encoderobject)) - WwrGwrsdMbTqFaoF(encoderobject) >= 3) {
                    sMZMIIcguzeGRVsc(encoderobject, EfzuYarAqJNYnDqb(encoderobject) + qDrCObQzGJZzORkc(strLzfKKSdMlRZAgYwO));
                    z = false;
                }
            }
            if (z) {
                WYAUzCGLJaHxRuSv(encoderobject);
                encoderobject.pos -= i;
            } else {
                LUQvZtsTkwzRRuqb(encoderobject, strLzfKKSdMlRZAgYwO);
            }
            NTwKeyPyerJhJnWN(encoderobject, 0);
        } catch (java.lang.Exception th) {
            ZKCdNCxplCLIthYU(encoderobject, 0);
            throw th;
        }
    }

    public static int HqHTIFrYUNCGZzqS(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getRemainingchars();
    }

    public static void JvZLJQqZufqQOfby(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        encoderobject.updateSymbolInfo();
    }

    public static int KWOiXOAVpPagiNwa(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getDataCapacity();
    }

    public static bool KnfQLUPPcAupKRBR(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.hasMorechars();
    }

    public static void KqslLFFdvftQsEYy(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.signalEncoderChange(i);
    }

    public static java.lang.string LzfKKSdMlRZAgYwO(java.lang.CharSequence charSequence) {
        return encodeToCodewords(charSequence);
    }

    public static int NRdGHlWDIXlStomX(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getDataCapacity();
    }

    public static java.lang.stringBuilder NZXZepBwkmJioion(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static char OyyYXRRREtoVdJic(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int QDrCObQzGJZzORkc(java.lang.string str) {
        return str.Length;
    }

    public static char RHivoFOkKzaCwrSI(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static void SMZMIIcguzeGRVsc(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.updateSymbolInfo(i);
    }

    public static int STPHEdBUPQStsbud(com.google.zxing.datamatrix.encoder.EdifactEncoder edifactEncoder) {
        return edifactEncoder.getEncodingMode();
    }

    public static java.lang.stringBuilder ThwFGqctscaiKGKv(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void ULUyhmNeHcjvFoad(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.signalEncoderChange(i);
    }

    public static char WLsRoOxEpZGXRRyI(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCurrentChar();
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo WURuneIrKRdvhFkP(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getSymbolInfo();
    }

    public static void WkLLMVJHErGkTxxL(char c, java.lang.stringBuilder sb) {
        encodeChar(c, sb);
    }

    public static int XLEMSvopeoJdEaTq(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int ZUEOrBgCKhbOMdzz(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getDataCapacity();
    }

    public override void Encode(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        if ((3 + 28) % 28 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        while (WRWXbmiVpTexQprE(encoderobject)) {
            wkLLMVJHErGkTxxL(wLsRoOxEpZGXRRyI(encoderobject), sb);
            encoderobject.pos++;
            if (xLEMSvopeoJdEaTq(sb) >= 4) {
                VXdphSZkoIbXyIAl(encoderobject, MyEswOjBYDIRGnwd(sb));
                WuLSXzuZWcSkpymK(sb, 0, 4);
                if (BHqhujMZJPeTVokX(RnmcySQoKYqDIxsH(encoderobject), encoderobject.pos, HyBXNhXAIjeJFXde(this)) != sTPHEdBUPQStsbud(this)) {
                    uLUyhmNeHcjvFoad(encoderobject, 0);
                    break;
                }
            }
        }
        nZXZepBwkmJioion(sb, (char) 31);
        bjJkimbAwhbHRdkY(encoderobject, sb);
    }

    public override int GetEncodingMode() {
        return 4;
    }
}

