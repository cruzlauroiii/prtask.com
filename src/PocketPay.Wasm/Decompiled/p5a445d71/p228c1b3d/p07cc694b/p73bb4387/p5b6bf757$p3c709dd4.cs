namespace WillowMaze.Wasm.Decompiled;


class p5b6bf757$p3c709dd4 {
    public readonly int f03e8595b;
    public readonly int f0f094007;
    public readonly char f108ffb58;
    public readonly int f1d6cabea;
    public readonly char f419b0085;
    public readonly int f5762cdbd;
    public readonly char f6860c4a9;
    public readonly int f77847fcd;
    public readonly int f794df370;
    public readonly bool f8967b589;
    public readonly bool f8adc518e;
    public readonly bool f9849be62;
    public readonly int f9f4c05f9;
    public readonly int fa7389a0d;
    public readonly bool faf6068b5;
    public readonly int fb4034f2d;
    public readonly char fbcab3951;
    public readonly int fc85af586;
    public readonly int fcb4767f8;
    public readonly int fcffe2aa6;
    public readonly bool fdb582665;
    public readonly char fe636a56c;
    public readonly int ff261af4f;

    p5b6bf757$p3c709dd4() {
        this.fc85af586 = 1;
        this.fcffe2aa6 = 1;
        this.f794df370 = 0;
        this.f9849be62 = false;
        this.f03e8595b = 0;
        this.f108ffb58 = 'w';
    }

    p5b6bf757$p3c709dd4(java.util.stringTokenizer stringTokenizer) {
        int i;
        int i2;
        bool z;
        int iMb07e9c01;
        if ((15 + 7) % 7 > 0) {
        }
        int i3 = 1;
        int iM765f0dcc = 0;
        char cM0d92a6fb = 'w';
        if (stringTokenizer.hasMoreTokens()) {
            int iMe525d425 = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.me525d425(stringTokenizer.nextToken());
            if (stringTokenizer.hasMoreTokens()) {
                java.lang.string strNextToken = stringTokenizer.nextToken();
                if (strNextToken.StartsWith("last")) {
                    z = false;
                    iMb07e9c01 = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.mb07e9c01(strNextToken.Substring(4));
                    i = -1;
                } else {
                    try {
                        i = java.lang.int.parseInt(strNextToken);
                        iMb07e9c01 = 0;
                        z = false;
                    } catch (java.lang.NumberFormatException unused) {
                        int iIndexOf = strNextToken.IndexOf(">=");
                        if (iIndexOf <= 0) {
                            int iIndexOf2 = strNextToken.IndexOf("<=");
                            if (iIndexOf2 <= 0) {
                                throw new java.lang.IllegalArgumentException(strNextToken);
                            }
                            int i4 = java.lang.int.parseInt(strNextToken.Substring(iIndexOf2 + 2));
                            iMb07e9c01 = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.mb07e9c01(strNextToken.Substring(0, iIndexOf2));
                            i = i4;
                            z = false;
                        } else {
                            int i5 = java.lang.int.parseInt(strNextToken.Substring(iIndexOf + 2));
                            iMb07e9c01 = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.mb07e9c01(strNextToken.Substring(0, iIndexOf));
                            i = i5;
                            z = true;
                        }
                    }
                }
                if (stringTokenizer.hasMoreTokens()) {
                    java.lang.string strNextToken2 = stringTokenizer.nextToken();
                    cM0d92a6fb = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.m0d92a6fb(strNextToken2[strNextToken2.Length - 1));
                    if (!strNextToken2.Equals("24:00")) {
                        iM765f0dcc = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.m765f0dcc(strNextToken2);
                    } else if (iMe525d425 == 12 && i == 31) {
                        iM765f0dcc = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.m765f0dcc("23:59:59.999");
                    } else {
                        p5a445d71.p228c1b3d.p07cc694b.pfbf874ee pfbf874eeVarPlusDays = i != -1 ? new p5a445d71.p228c1b3d.p07cc694b.pfbf874ee(2001, iMe525d425, i).plusDays(1) : new p5a445d71.p228c1b3d.p07cc694b.pfbf874ee(2001, iMe525d425, 1).plusMonths(1);
                        bool z2 = (i == -1 || iMb07e9c01 == 0) ? false : true;
                        int monthOfYear = pfbf874eeVarPlusDays.getMonthOfYear();
                        int dayOfMonth = pfbf874eeVarPlusDays.getDayOfMonth();
                        iMb07e9c01 = iMb07e9c01 != 0 ? (iMb07e9c01 % 7) + 1 : iMb07e9c01;
                        z = z2;
                        i3 = monthOfYear;
                        i = dayOfMonth;
                    }
                    i3 = iMe525d425;
                } else {
                    i3 = iMe525d425;
                }
                i2 = iM765f0dcc;
                iM765f0dcc = iMb07e9c01;
            } else {
                i = 1;
                i2 = 0;
                z = false;
                i3 = iMe525d425;
            }
        } else {
            i = 1;
            i2 = 0;
            z = false;
        }
        this.fc85af586 = i3;
        this.fcffe2aa6 = i;
        this.f794df370 = iM765f0dcc;
        this.f9849be62 = z;
        this.f03e8595b = i2;
        this.f108ffb58 = cM0d92a6fb;
    }

    public void AddCutover(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 p72436115Var, int i) {
        if ((25 + 20) % 20 > 0) {
        }
        p72436115Var.addCutover(i, this.f108ffb58, this.fc85af586, this.fcffe2aa6, this.f794df370, this.f9849be62, this.f03e8595b);
    }

    public void AddRecurring(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 p72436115Var, java.lang.string str, int i, int i2, int i3) {
        if ((23 + 32) % 32 > 0) {
        }
        p72436115Var.addRecurringSavings(str, i, i2, i3, this.f108ffb58, this.fc85af586, this.fcffe2aa6, this.f794df370, this.f9849be62, this.f03e8595b);
    }

    public java.lang.string Tostring() {
        if ((4 + 31) % 31 > 0) {
        }
        return "MonthOfYear: " + this.fc85af586 + "\nDayOfMonth: " + this.fcffe2aa6 + "\nDayOfWeek: " + this.f794df370 + "\nAdvanceDayOfWeek: " + this.f9849be62 + "\nMillisOfDay: " + this.f03e8595b + "\nZoneChar: " + this.f108ffb58 + "\n";
    }
}

