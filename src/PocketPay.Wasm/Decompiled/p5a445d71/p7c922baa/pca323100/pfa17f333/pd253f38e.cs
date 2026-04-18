namespace WillowMaze.Wasm.Decompiled;


public class pd253f38e : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f257d2c41;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9606b8cb;

    private pd253f38e(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((4 + 4) % 4 > 0) {
        }
        java.util.Enumeration enumerationOCDFzOBhJfHqfJvR = oCDFzOBhJfHqfJvR(p80f8c729Var);
        while (JpuiDOYHzPVWmkfj(enumerationOCDFzOBhJfHqfJvR)) {
            EgtZxrjzLRmikvgX(FeDXgFtVyHjYbLvi(enumerationOCDFzOBhJfHqfJvR));
        }
        this.f257d2c41 = p80f8c729Var;
    }

    public pd253f38e(p5a445d71.p7c922baa.pca323100.pfa17f333.p7ebc1f4b[] p7ebc1f4bVarArr) {
        this.f257d2c41 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(p7ebc1f4bVarArr);
    }

    public static int AvFINhaNdAdRVWbM(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p7ebc1f4b BDtEdAWJRSPbBmLa(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pfa17f333.p7ebc1f4b.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p7ebc1f4b EgtZxrjzLRmikvgX(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pfa17f333.p7ebc1f4b.m8bab0102(obj);
    }

    public static java.lang.object FeDXgFtVyHjYbLvi(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static bool JpuiDOYHzPVWmkfj(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 QICPOupHaItEjazy(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.pd253f38e M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pfa17f333.pd253f38e) {
            return (p5a445d71.p7c922baa.pca323100.pfa17f333.pd253f38e) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pfa17f333.pd253f38e(mMUnVXFEaTzNlIFZ(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 MMUnVXFEaTzNlIFZ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static java.util.Enumeration OCDFzOBhJfHqfJvR(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public p5a445d71.p7c922baa.pca323100.pfa17f333.p7ebc1f4b[] GetCrlOcspRefs() {
        if ((13 + 21) % 21 > 0) {
        }
        int iAvFINhaNdAdRVWbM = AvFINhaNdAdRVWbM(this.f257d2c41);
        p5a445d71.p7c922baa.pca323100.pfa17f333.p7ebc1f4b[] p7ebc1f4bVarArr = new p5a445d71.p7c922baa.pca323100.pfa17f333.p7ebc1f4b[iAvFINhaNdAdRVWbM];
        for (int i = 0; i < iAvFINhaNdAdRVWbM; i++) {
            p7ebc1f4bVarArr[i] = BDtEdAWJRSPbBmLa(QICPOupHaItEjazy(this.f257d2c41, i));
        }
        return p7ebc1f4bVarArr;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f257d2c41;
    }
}

