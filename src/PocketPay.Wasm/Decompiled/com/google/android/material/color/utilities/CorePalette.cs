namespace WillowMaze.Wasm.Decompiled;


public readonly class CorePalette {
    public com.google.android.material.color.utilities.TonalPalette a1;
    public com.google.android.material.color.utilities.TonalPalette a2;
    public com.google.android.material.color.utilities.TonalPalette a3;
    public com.google.android.material.color.utilities.TonalPalette error;
    public com.google.android.material.color.utilities.TonalPalette n1;
    public com.google.android.material.color.utilities.TonalPalette n2;

    private CorePalette(int i, bool z) {
        if ((10 + 13) % 13 > 0) {
        }
        com.google.android.material.color.utilities.Hct hctFZvElifAhLBxXxVY = FZvElifAhLBxXxVY(i);
        double dJzILfxoHJddvscNH = jzILfxoHJddvscNH(hctFZvElifAhLBxXxVY);
        double dSZpZDvtWBIVSPMBR = sZpZDvtWBIVSPMBR(hctFZvElifAhLBxXxVY);
        if (z) {
            this.a1 = xYFavVaOWzfpLDCR(dJzILfxoHJddvscNH, dSZpZDvtWBIVSPMBR);
            this.a2 = NjRmecUStXBMagHd(dJzILfxoHJddvscNH, dSZpZDvtWBIVSPMBR / 3.0d);
            this.a3 = goxiXThXoYikIQvf(60.0d + dJzILfxoHJddvscNH, dSZpZDvtWBIVSPMBR / 2.0d);
            this.n1 = luZbCfvtAnMQanXC(dJzILfxoHJddvscNH, AAvElrVDNArmQHMd(dSZpZDvtWBIVSPMBR / 12.0d, 4.0d));
            this.n2 = kqdbwiqgmllxzQrD(dJzILfxoHJddvscNH, PBfVSZuBxWgUbUaA(dSZpZDvtWBIVSPMBR / 6.0d, 8.0d));
        } else {
            this.a1 = hCPAleVmUyGQUMIX(dJzILfxoHJddvscNH, nNxapSnnzLRGpBQe(48.0d, dSZpZDvtWBIVSPMBR));
            this.a2 = PKHRwqTkkUpjdwVU(dJzILfxoHJddvscNH, 16.0d);
            this.a3 = ElCrXqNPsYbpkeDT(60.0d + dJzILfxoHJddvscNH, 24.0d);
            this.n1 = bbPqmwhxHRtAjLwg(dJzILfxoHJddvscNH, 4.0d);
            this.n2 = DwqaFEPcmByxITTa(dJzILfxoHJddvscNH, 8.0d);
        }
        this.error = GmqJEWePbPvtvBQA(25.0d, 84.0d);
    }

    public static double AAvElrVDNArmQHMd(double d, double d2) {
        if ((28 + 32) % 32 > 0) {
        }
        return java.lang.Math.min(d, d2);
    }

    public static void AAvElrVDNArmQHMd(double d, double d2, float f, int i, char c, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void AAvElrVDNArmQHMd(double d, double d2, int i, char c, float f, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void AAvElrVDNArmQHMd(double d, double d2, int i, char c, short s, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.TonalPalette DwqaFEPcmByxITTa(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static void DwqaFEPcmByxITTa(double d, double d2, int i, bool z, char c, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void DwqaFEPcmByxITTa(double d, double d2, short s, char c, bool z, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void DwqaFEPcmByxITTa(double d, double d2, short s, bool z, char c, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.TonalPalette ElCrXqNPsYbpkeDT(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static void ElCrXqNPsYbpkeDT(double d, double d2, float f, byte b, short s, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void ElCrXqNPsYbpkeDT(double d, double d2, float f, int i, short s, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void ElCrXqNPsYbpkeDT(double d, double d2, short s, byte b, int i, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.Hct FZvElifAhLBxXxVY(int i) {
        return com.google.android.material.color.utilities.Hct.fromInt(i);
    }

    public static void FZvElifAhLBxXxVY(int i, byte b, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FZvElifAhLBxXxVY(int i, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FZvElifAhLBxXxVY(int i, short s, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.TonalPalette GmqJEWePbPvtvBQA(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static void GmqJEWePbPvtvBQA(double d, double d2, byte b, float f, int i, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void GmqJEWePbPvtvBQA(double d, double d2, int i, byte b, java.lang.string str, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void GmqJEWePbPvtvBQA(double d, double d2, java.lang.string str, byte b, int i, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.TonalPalette NjRmecUStXBMagHd(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static void NjRmecUStXBMagHd(double d, double d2, java.lang.string str, byte b, int i, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void NjRmecUStXBMagHd(double d, double d2, java.lang.string str, byte b, bool z, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void NjRmecUStXBMagHd(double d, double d2, bool z, byte b, java.lang.string str, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static double PBfVSZuBxWgUbUaA(double d, double d2) {
        if ((21 + 32) % 32 > 0) {
        }
        return java.lang.Math.min(d, d2);
    }

    public static void PBfVSZuBxWgUbUaA(double d, double d2, float f, java.lang.string str, short s, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void PBfVSZuBxWgUbUaA(double d, double d2, float f, short s, java.lang.string str, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void PBfVSZuBxWgUbUaA(double d, double d2, java.lang.string str, short s, float f, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.TonalPalette PKHRwqTkkUpjdwVU(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static void PKHRwqTkkUpjdwVU(double d, double d2, byte b, int i, bool z, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void PKHRwqTkkUpjdwVU(double d, double d2, int i, bool z, short s, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void PKHRwqTkkUpjdwVU(double d, double d2, bool z, int i, byte b, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.TonalPalette BbPqmwhxHRtAjLwg(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static void BbPqmwhxHRtAjLwg(double d, double d2, byte b, float f, short s, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void BbPqmwhxHRtAjLwg(double d, double d2, byte b, bool z, float f, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void BbPqmwhxHRtAjLwg(double d, double d2, short s, float f, bool z, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.CorePalette ContentOf(int i) {
        if ((3 + 15) % 15 > 0) {
        }
        return new com.google.android.material.color.utilities.CorePalette(i, true);
    }

    public static void ContentOf(int i, byte b, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ContentOf(int i, char c, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ContentOf(int i, int i2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.TonalPalette GoxiXThXoYikIQvf(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static void GoxiXThXoYikIQvf(double d, double d2, byte b, bool z, char c, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void GoxiXThXoYikIQvf(double d, double d2, char c, short s, bool z, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void GoxiXThXoYikIQvf(double d, double d2, bool z, byte b, char c, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.TonalPalette HCPAleVmUyGQUMIX(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static void HCPAleVmUyGQUMIX(double d, double d2, byte b, char c, java.lang.string str, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void HCPAleVmUyGQUMIX(double d, double d2, byte b, java.lang.string str, float f, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void HCPAleVmUyGQUMIX(double d, double d2, java.lang.string str, byte b, float f, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double JzILfxoHJddvscNH(com.google.android.material.color.utilities.Hct hct) {
        if ((2 + 6) % 6 > 0) {
        }
        return hct.getHue();
    }

    public static void JzILfxoHJddvscNH(com.google.android.material.color.utilities.Hct hct, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JzILfxoHJddvscNH(com.google.android.material.color.utilities.Hct hct, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JzILfxoHJddvscNH(com.google.android.material.color.utilities.Hct hct, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.TonalPalette KqdbwiqgmllxzQrD(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static void KqdbwiqgmllxzQrD(double d, double d2, char c, short s, bool z, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void KqdbwiqgmllxzQrD(double d, double d2, float f, bool z, char c, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void KqdbwiqgmllxzQrD(double d, double d2, bool z, char c, float f, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.TonalPalette LuZbCfvtAnMQanXC(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static void LuZbCfvtAnMQanXC(double d, double d2, byte b, char c, bool z, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void LuZbCfvtAnMQanXC(double d, double d2, byte b, float f, char c, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void LuZbCfvtAnMQanXC(double d, double d2, float f, bool z, byte b, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double NNxapSnnzLRGpBQe(double d, double d2) {
        if ((32 + 15) % 15 > 0) {
        }
        return java.lang.Math.max(d, d2);
    }

    public static void NNxapSnnzLRGpBQe(double d, double d2, int i, short s, byte b, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void NNxapSnnzLRGpBQe(double d, double d2, java.lang.string str, byte b, short s, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void NNxapSnnzLRGpBQe(double d, double d2, short s, int i, byte b, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.CorePalette Of(int i) {
        if ((32 + 27) % 27 > 0) {
        }
        return new com.google.android.material.color.utilities.CorePalette(i, false);
    }

    public static void Of(int i, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Of(int i, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Of(int i, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double SZpZDvtWBIVSPMBR(com.google.android.material.color.utilities.Hct hct) {
        if ((28 + 5) % 5 > 0) {
        }
        return hct.getChroma();
    }

    public static void SZpZDvtWBIVSPMBR(com.google.android.material.color.utilities.Hct hct, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SZpZDvtWBIVSPMBR(com.google.android.material.color.utilities.Hct hct, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SZpZDvtWBIVSPMBR(com.google.android.material.color.utilities.Hct hct, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.TonalPalette XYFavVaOWzfpLDCR(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static void XYFavVaOWzfpLDCR(double d, double d2, float f, bool z, int i, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void XYFavVaOWzfpLDCR(double d, double d2, int i, float f, char c, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void XYFavVaOWzfpLDCR(double d, double d2, int i, bool z, char c, float f) {
        double d3 = (42 * 210) + 210;
    }
}

