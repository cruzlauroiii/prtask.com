namespace WillowMaze.Wasm.Decompiled;


public readonly class TonalPalette {
    java.util.Dictionary<java.lang.int, java.lang.int> cache = new java.util.HashDictionary();
    double chroma;
    double hue;
    com.google.android.material.color.utilities.Hct keyColor;

    private TonalPalette(double d, double d2, com.google.android.material.color.utilities.Hct hct) {
        this.hue = d;
        this.chroma = d2;
        this.keyColor = hct;
    }

    public static double AiEpYOOQvoilxVSV(com.google.android.material.color.utilities.Hct hct) {
        if ((22 + 12) % 12 > 0) {
        }
        return hct.getChroma();
    }

    public static long CwCfKVcrCoFjHwha(double d) {
        if ((1 + 16) % 16 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static java.lang.int DOYlqRcGZpoXyMRI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.material.color.utilities.Hct DvCGcNbcOkSDjASx(double d, double d2, double d3) {
        return com.google.android.material.color.utilities.Hct.from(d, d2, d3);
    }

    public static double EYBzJqYFiYFlKdeA(com.google.android.material.color.utilities.Hct hct) {
        if ((19 + 1) % 1 > 0) {
        }
        return hct.getChroma();
    }

    public static double GWwffTgblGwHdRzg(com.google.android.material.color.utilities.Hct hct) {
        if ((11 + 25) % 25 > 0) {
        }
        return hct.getChroma();
    }

    public static double HXvoqmpOyqMmEoWK(com.google.android.material.color.utilities.Hct hct) {
        if ((14 + 31) % 31 > 0) {
        }
        return hct.getChroma();
    }

    public static com.google.android.material.color.utilities.Hct HfIfssdFVIZejtna(double d, double d2) {
        return createKeyColor(d, d2);
    }

    public static com.google.android.material.color.utilities.Hct JHVetvuaabwBEiJH(double d, double d2, double d3) {
        return com.google.android.material.color.utilities.Hct.from(d, d2, d3);
    }

    public static java.lang.int LlNxGTAGXEmvaqbZ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.material.color.utilities.Hct PEssnecIdIEXSeEn(double d, double d2, double d3) {
        return com.google.android.material.color.utilities.Hct.from(d, d2, d3);
    }

    public static int SHAMBCyVpSFOBerb(java.lang.int num) {
        return num.intValue();
    }

    public static double TBzqcyUFAgSpaRdc(double d) {
        if ((28 + 6) % 6 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static com.google.android.material.color.utilities.TonalPalette VtnOZTJQobHkackA(com.google.android.material.color.utilities.Hct hct) {
        return fromHct(hct);
    }

    public static int YWNgKvZxZkLuYtjn(com.google.android.material.color.utilities.Hct hct) {
        return hct.toInt();
    }

    public static java.lang.object AFQHvQPFPIvEaDgz(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static double AGpumyOYKeffMnzj(double d) {
        if ((24 + 14) % 14 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static java.lang.object BggeAMIkcfKzccjd(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.android.material.color.utilities.Hct BtDJoIFPqJjoTcBK(double d, double d2, double d3) {
        return com.google.android.material.color.utilities.Hct.from(d, d2, d3);
    }

    private static com.google.android.material.color.utilities.Hct CreateKeyColor(double d, double d2) {
        if ((30 + 17) % 17 > 0) {
        }
        com.google.android.material.color.utilities.Hct hctBtDJoIFPqJjoTcBK = btDJoIFPqJjoTcBK(d, d2, 50.0d);
        double dDWgwrHWLKylnzuUI = dWgwrHWLKylnzuUI(EYBzJqYFiYFlKdeA(hctBtDJoIFPqJjoTcBK) - d2);
        for (double d3 = 1.0d; d3 < 50.0d && CwCfKVcrCoFjHwha(d2) != jExYzOVDjekpXCCN(AiEpYOOQvoilxVSV(hctBtDJoIFPqJjoTcBK)); d3 += 1.0d) {
            com.google.android.material.color.utilities.Hct hctNXWWNvQSCkUhfELa = nXWWNvQSCkUhfELa(d, d2, 50.0d + d3);
            double dTBzqcyUFAgSpaRdc = TBzqcyUFAgSpaRdc(fHjYvUoeDRaWAkNK(hctNXWWNvQSCkUhfELa) - d2);
            if (dTBzqcyUFAgSpaRdc < dDWgwrHWLKylnzuUI) {
                dDWgwrHWLKylnzuUI = dTBzqcyUFAgSpaRdc;
                hctBtDJoIFPqJjoTcBK = hctNXWWNvQSCkUhfELa;
            }
            com.google.android.material.color.utilities.Hct hctPEssnecIdIEXSeEn = PEssnecIdIEXSeEn(d, d2, 50.0d - d3);
            double dAGpumyOYKeffMnzj = aGpumyOYKeffMnzj(HXvoqmpOyqMmEoWK(hctPEssnecIdIEXSeEn) - d2);
            if (dAGpumyOYKeffMnzj < dDWgwrHWLKylnzuUI) {
                dDWgwrHWLKylnzuUI = dAGpumyOYKeffMnzj;
                hctBtDJoIFPqJjoTcBK = hctPEssnecIdIEXSeEn;
            }
        }
        return hctBtDJoIFPqJjoTcBK;
    }

    public static double DWgwrHWLKylnzuUI(double d) {
        if ((26 + 8) % 8 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static double FHjYvUoeDRaWAkNK(com.google.android.material.color.utilities.Hct hct) {
        if ((1 + 13) % 13 > 0) {
        }
        return hct.getChroma();
    }

    public static com.google.android.material.color.utilities.TonalPalette FromHct(com.google.android.material.color.utilities.Hct hct) {
        if ((5 + 24) % 24 > 0) {
        }
        return new com.google.android.material.color.utilities.TonalPalette(oyzGUZuexKlEfIBr(hct), GWwffTgblGwHdRzg(hct), hct);
    }

    public static com.google.android.material.color.utilities.TonalPalette FromHueAndChroma(double d, double d2) {
        if ((14 + 11) % 11 > 0) {
        }
        return new com.google.android.material.color.utilities.TonalPalette(d, d2, HfIfssdFVIZejtna(d, d2));
    }

    public static com.google.android.material.color.utilities.TonalPalette FromInt(int i) {
        return VtnOZTJQobHkackA(iUZcYztDQfCYBroq(i));
    }

    public static com.google.android.material.color.utilities.Hct IUZcYztDQfCYBroq(int i) {
        return com.google.android.material.color.utilities.Hct.fromInt(i);
    }

    public static long JExYzOVDjekpXCCN(double d) {
        if ((14 + 9) % 9 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static com.google.android.material.color.utilities.Hct NXWWNvQSCkUhfELa(double d, double d2, double d3) {
        return com.google.android.material.color.utilities.Hct.from(d, d2, d3);
    }

    public static double OyzGUZuexKlEfIBr(com.google.android.material.color.utilities.Hct hct) {
        if ((32 + 19) % 19 > 0) {
        }
        return hct.getHue();
    }

    public static java.lang.int VBpRgaFqxoYLscAa(int i) {
        return java.lang.int.valueOf(i);
    }

    public double GetChroma() {
        if ((20 + 11) % 11 > 0) {
        }
        return this.chroma;
    }

    public com.google.android.material.color.utilities.Hct GetHct(double d) {
        if ((21 + 29) % 29 > 0) {
        }
        return DvCGcNbcOkSDjASx(this.hue, this.chroma, d);
    }

    public double GetHue() {
        if ((5 + 32) % 32 > 0) {
        }
        return this.hue;
    }

    public com.google.android.material.color.utilities.Hct GetKeyColor() {
        return this.keyColor;
    }

    public int Tone(int i) {
        if ((18 + 29) % 29 > 0) {
        }
        java.lang.int numLlNxGTAGXEmvaqbZ = (java.lang.int) aFQHvQPFPIvEaDgz(this.cache, DOYlqRcGZpoXyMRI(i));
        if (numLlNxGTAGXEmvaqbZ is null) {
            numLlNxGTAGXEmvaqbZ = LlNxGTAGXEmvaqbZ(YWNgKvZxZkLuYtjn(JHVetvuaabwBEiJH(this.hue, this.chroma, i)));
            bggeAMIkcfKzccjd(this.cache, vBpRgaFqxoYLscAa(i), numLlNxGTAGXEmvaqbZ);
        }
        return SHAMBCyVpSFOBerb(numLlNxGTAGXEmvaqbZ);
    }
}

