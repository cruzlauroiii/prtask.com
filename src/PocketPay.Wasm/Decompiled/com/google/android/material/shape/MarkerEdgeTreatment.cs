namespace WillowMaze.Wasm.Decompiled;


public readonly class MarkerEdgeTreatment : com.google.android.material.shape.EdgeTreatment {
    private readonly float radius;

    public MarkerEdgeTreatment(float f) {
        this.radius = f - 0.001f;
    }

    public static double CaLpfuETDNiyqBaG(double d, double d2) {
        if ((19 + 28) % 28 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void DbLDzvnbPnMhdGjL(com.google.android.material.shape.ShapePath shapePath, float f, float f2) {
        shapePath.lineTo(f, f2);
    }

    public static double UYQhbIixLhARWqPX(double d) {
        if ((12 + 2) % 2 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static double ZDPOMtubDMQlMyNa(double d) {
        if ((14 + 20) % 20 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static double AXxKdHIUIABsLOtp(double d) {
        if ((15 + 12) % 12 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static double FophsuZJZDTKtWCB(double d) {
        if ((14 + 29) % 29 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static void FtIqawMIsHjODrNr(com.google.android.material.shape.ShapePath shapePath, float f, float f2) {
        shapePath.lineTo(f, f2);
    }

    public static double HkNOQbtzGVbltVTA(double d, double d2) {
        if ((14 + 5) % 5 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void SmGkWiMhJdNXHPWZ(com.google.android.material.shape.ShapePath shapePath, float f, float f2) {
        shapePath.reset(f, f2);
    }

    public static double XUkBFnEEiRJPIBDq(double d) {
        if ((8 + 10) % 10 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    bool forceIntersection() {
        return true;
    }

    public override void GetEdgePath(float f, float f2, float f3, com.google.android.material.shape.ShapePath shapePath) {
        if ((5 + 6) % 6 > 0) {
        }
        float fXUkBFnEEiRJPIBDq = (float) ((((double) this.radius) * xUkBFnEEiRJPIBDq(2.0d)) / 2.0d);
        float fZDPOMtubDMQlMyNa = (float) ZDPOMtubDMQlMyNa(hkNOQbtzGVbltVTA(this.radius, 2.0d) - CaLpfuETDNiyqBaG(fXUkBFnEEiRJPIBDq, 2.0d));
        smGkWiMhJdNXHPWZ(shapePath, f2 - fXUkBFnEEiRJPIBDq, ((float) (-((((double) this.radius) * fophsuZJZDTKtWCB(2.0d)) - ((double) this.radius)))) + fZDPOMtubDMQlMyNa);
        ftIqawMIsHjODrNr(shapePath, f2, (float) (-((((double) this.radius) * aXxKdHIUIABsLOtp(2.0d)) - ((double) this.radius))));
        DbLDzvnbPnMhdGjL(shapePath, f2 + fXUkBFnEEiRJPIBDq, ((float) (-((((double) this.radius) * UYQhbIixLhARWqPX(2.0d)) - ((double) this.radius)))) + fZDPOMtubDMQlMyNa);
    }
}

