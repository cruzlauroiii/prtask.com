namespace WillowMaze.Wasm.Decompiled;


public class p6d1b1814 : android.view.Surfaceobject : android.view.SurfaceHolder$Callback {
    private static readonly java.lang.string f19caf29d = null;
    private static readonly java.lang.string f8d4c041b = null;
    private static readonly java.lang.string fe444f739 = jvnPRbdcKghepErW("3150b7bd5c43236898a388d1a505125f63acdefe274059099984356322136e3ac365dcca110c1e0225");
    private static readonly java.lang.string ffa055cb9 = null;
    private bool f07a6c928;
    private java.lang.Action f104f1468;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 f188d1c0a;
    private float f1b4f85d0;
    private android.hardware.Camera$PreviewCallback f21e9802d;
    private bool f21f5ee5e;
    private bool f2325077b;
    private android.hardware.Camera$PreviewCallback f2410430f;
    private float f2ddb609a;
    private android.os.Handler f3b734224;
    private bool f408ef937;
    android.hardware.Camera$AutoFocusCallback f4a38a2ac;
    private android.hardware.Camera$PreviewCallback f4b701667;
    private bool f55e8587f;
    private android.hardware.Camera$PreviewCallback f57cf25d4;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 f617a70e4;
    private bool f6a826f61;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 f7a2381de;
    private bool f823c1aaa;
    private java.lang.Action f86790df7;
    private android.os.Handler f8b252815;
    private bool f8e2b3b91;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 f90e20ac4;
    private bool f98a0101e;
    private float f98a2835d;
    private java.lang.Action fa76c14bd;
    private float fb112b279;
    private android.os.Handler fc430f033;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 fc50a9def;
    private bool fc628429c;
    private java.lang.Action fd2154ad4;
    private android.hardware.Camera$PreviewCallback fd422e199;
    private float fdfbc58b5;
    private bool fe332ea9c;
    android.hardware.Camera$AutoFocusCallback ffc031a2a;
    private bool fff2ae9dc;

    public p6d1b1814(android.content.object context, android.util.AttributeHashSet attributeHashSet, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var, android.hardware.Camera$PreviewCallback camera$PreviewCallback) {
        super(context, attributeHashSet);
        this.f823c1aaa = true;
        this.f21f5ee5e = true;
        this.f6a826f61 = false;
        this.fc628429c = true;
        this.fdfbc58b5 = 0.1f;
        this.fa76c14bd = new pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814$1(this);
        this.ffc031a2a = new pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814$2(this);
        LWwFffvsqxQEkkKi(this, p2e5a0d59Var, camera$PreviewCallback);
    }

    public p6d1b1814(android.content.object context, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var, android.hardware.Camera$PreviewCallback camera$PreviewCallback) {
        super(context);
        this.f823c1aaa = true;
        this.f21f5ee5e = true;
        this.f6a826f61 = false;
        this.fc628429c = true;
        this.fdfbc58b5 = 0.1f;
        this.fa76c14bd = new pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814$1(this);
        this.ffc031a2a = new pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814$2(this);
        jmPlHjFrnEeKBGXP(this, p2e5a0d59Var, camera$PreviewCallback);
    }

    public static int ADEXDbDLUJFXNvIm(int i) {
        return java.lang.Math.abs(i);
    }

    public static java.util.List AWiElllMObFvjIRJ(android.hardware.Camera$Parameters camera$Parameters) {
        return camera$Parameters.getSupportedPreviewSizes();
    }

    public static int AuXrOpsPvqluqtDv(int i) {
        return java.lang.Math.abs(i);
    }

    public static void BepnYOgwFawxzngh(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        p6d1b1814Var.m56ba9b69();
    }

    public static android.view.objectGroup$LayoutParams BzyOPbVMPXwVCFhF(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getLayoutParams();
    }

    public static void CYsFCBRoAJoMHPga(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        p6d1b1814Var.m56ba9b69();
    }

    public static java.lang.object DVaLrBpZlLvqtsvV(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void DZpgyiLdvCRGkRfS(int i, android.hardware.Camera$CameraInfo camera$CameraInfo) {
        android.hardware.Camera.getCameraInfo(i, camera$CameraInfo);
    }

    public static int FJMjNADFOdYimaVo(android.view.object view) {
        return view.getHeight();
    }

    public static android.hardware.Camera$Size FVVQQoSRpxEBSBbB(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.m695feb14();
    }

    public static void FubZAXwxzDTBaoVO(int i, android.hardware.Camera$CameraInfo camera$CameraInfo) {
        android.hardware.Camera.getCameraInfo(i, camera$CameraInfo);
    }

    public static android.view.SurfaceHolder GlFKwXgGrsqgCMKz(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getHolder();
    }

    public static int GwwGSQZLanjzpMpR(int i) {
        return java.lang.Math.abs(i);
    }

    public static java.lang.object HZRcBLhBMHssCDKQ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void HmgPUfZfkHPFLnHS(android.view.SurfaceHolder surfaceHolder, int i) {
        surfaceHolder.setType(i);
    }

    public static bool IIapbxcCBpfSLDlo(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int IMXrxPPsJvwCQFCy(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getDisplayOrientation();
    }

    public static void KBOqEScRQpjqXwUl(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        p6d1b1814Var.m56ba9b69();
    }

    public static android.content.object KkXRDBrgqdIAoxmJ(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getobject();
    }

    public static int KtyrHJoqTpaWKZSJ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void LWwFffvsqxQEkkKi(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var, android.hardware.Camera$PreviewCallback camera$PreviewCallback) {
        p6d1b1814Var.init(p2e5a0d59Var, camera$PreviewCallback);
    }

    public static void LdHUEvWGFNlyHusn(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        p6d1b1814Var.showCameraPreview();
    }

    public static void MQavjUWxXhUQcDRm(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        p6d1b1814Var.safeAutoFocus();
    }

    public static void MQqzBAcyDamAjotD(android.hardware.Camera$Parameters camera$Parameters, int i, int i2) {
        camera$Parameters.setPreviewSize(i, i2);
    }

    public static int MWrncvuJKCXHKWpz(int i) {
        return java.lang.Math.abs(i);
    }

    public static void MsSNKKaQidvcwApB(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        p6d1b1814Var.setupCameraParameters();
    }

    public static void NSfacJWtlgpGAwSh(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        p6d1b1814Var.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void OgSWULmGeumSwjgp(android.hardware.Camera camera) {
        camera.stopPreview();
    }

    public static int PIMyKbptUvYlHWFE(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getDisplayOrientation();
    }

    public static java.lang.object PLwIsudXnFpoXAhE(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.view.objectParent PZOSuofOIFxxmEBG(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getParent();
    }

    public static android.view.Display PauLXSuphaJQFwmh(android.view.WindowManager windowManager) {
        return windowManager.getDefaultDisplay();
    }

    public static void QGBJmbBdoCMYgfqo(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var, int i, int i2) {
        p6d1b1814Var.mf661f960(i, i2);
    }

    public static int QkOxoVzgRvEPDXEj(float f) {
        return java.lang.Math.round(f);
    }

    public static void QyMDHwkcGFJDlQKc(android.hardware.Camera camera, android.hardware.Camera$Parameters camera$Parameters) {
        camera.setParameters(camera$Parameters);
    }

    public static void RmTwFkqSvaJNjfXx(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        p6d1b1814Var.m56ba9b69();
    }

    public static int RrtAIYDcYjvqdbvi(java.lang.string str, java.lang.string str2) {
        return android.util.Console.v(str, str2);
    }

    public static void RvAHBzdHlwjcQWoZ(android.hardware.Camera camera, android.hardware.Camera$AutoFocusCallback camera$AutoFocusCallback) {
        camera.autoFocus(camera$AutoFocusCallback);
    }

    public static bool SdUHWzSCYQsQnpso(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void SyaBhhgQOEUyHKrn(android.view.SurfaceHolder surfaceHolder, android.view.SurfaceHolder$Callback surfaceHolder$Callback) {
        surfaceHolder.addCallback(surfaceHolder$Callback);
    }

    public static void UXOdCIAVhCnTcIon(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var, int i, int i2) {
        p6d1b1814Var.mf661f960(i, i2);
    }

    public static android.view.SurfaceHolder UkweBxkNHaQOlEqM(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getHolder();
    }

    public static android.view.SurfaceHolder WkhNHBPccNhJKmYn(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getHolder();
    }

    public static java.lang.string XLskyCrQEaWtQTdt(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string XgHJDJxGYhlJNESf(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static int ZXyizVpRZOeeKeCn(android.view.Display display) {
        return display.getRotation();
    }

    public static android.graphics.Point ZbxftRcGpOsnPLjK(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var, android.graphics.Point point) {
        return p6d1b1814Var.m1f086567(point);
    }

    public static void EJFgvOnVOhgnYlcO(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        p6d1b1814Var.safeAutoFocus();
    }

    public static void FHFalJSJsnwNjCeE(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        p6d1b1814Var.stopCameraPreview();
    }

    public static void FeFpdsOpcfQkwANK(android.hardware.Camera camera) {
        camera.startPreview();
    }

    public static void FfVbWgJVYCBGLDaG(android.view.SurfaceHolder surfaceHolder, android.view.SurfaceHolder$Callback surfaceHolder$Callback) {
        surfaceHolder.addCallback(surfaceHolder$Callback);
    }

    public static void GbmOwEwdCAYPCEly(android.view.SurfaceHolder surfaceHolder, android.view.SurfaceHolder$Callback surfaceHolder$Callback) {
        surfaceHolder.removeCallback(surfaceHolder$Callback);
    }

    public static void GjJuDyurAaVUuKtB(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var, android.hardware.Camera$Size camera$Size) {
        p6d1b1814Var.mb768c4b8(camera$Size);
    }

    public static java.lang.string GwKrqPSKeSQhRVHK(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int HMoPRjqkemUiqoGH(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getHeight();
    }

    public static void HMyWggZeHhWHpNpL(android.hardware.Camera camera) {
        camera.cancelAutoFocus();
    }

    public static int HwMTIFWWISsRrgMh(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getDisplayOrientation();
    }

    public static java.util.IEnumerator IbpIZTOVxXZfNYKZ(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void JiPyewCfVmqMjsZV(android.hardware.Camera camera, int i) {
        camera.setDisplayOrientation(i);
    }

    public static void JmPlHjFrnEeKBGXP(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var, android.hardware.Camera$PreviewCallback camera$PreviewCallback) {
        p6d1b1814Var.init(p2e5a0d59Var, camera$PreviewCallback);
    }

    public static java.lang.string JvnPRbdcKghepErW(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void KuPQkfHQHxFMknfN(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        p6d1b1814Var.stopCameraPreview();
    }

    public static android.hardware.Camera$Parameters lBTVcRkNexsMIpVr(android.hardware.Camera camera) {
        return camera.getParameters();
    }

    public static android.view.Surface LFOVKFXHWnLaGBGi(android.view.SurfaceHolder surfaceHolder) {
        return surfaceHolder.getSurface();
    }

    public static void LGDpLgcSxApVNMvi(android.hardware.Camera camera, android.view.SurfaceHolder surfaceHolder) throws java.io.IOException {
        camera.setPreviewDisplay(surfaceHolder);
    }

    public static int LwQXLkjTBMvWWzKX(android.content.object context) {
        return pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p29726be6.m4c1bf7fa(context);
    }

    public static java.lang.string LzvvDwopDToHoBaU(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    private android.graphics.Point M1f086567(android.graphics.Point point) {
        return IMXrxPPsJvwCQFCy(this) % 180 != 0 ? new android.graphics.Point(point.y, point.x) : point;
    }

    static bool M337ceba5(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.f21f5ee5e;
    }

    private void M56ba9b69() {
        if ((17 + 13) % 13 > 0) {
        }
        vltsFKdIpUPWfIRd(this.fc430f033, this.fa76c14bd, 1000L);
    }

    static bool M5ec06fdf(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.f6a826f61;
    }

    private android.hardware.Camera$Size m695feb14() {
        if ((10 + 21) % 21 > 0) {
        }
        pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var = this.fc50a9def;
        android.hardware.Camera$Size camera$Size = null;
        if (p2e5a0d59Var is null) {
            return null;
        }
        java.util.List listAWiElllMObFvjIRJ = AWiElllMObFvjIRJ(lBTVcRkNexsMIpVr(p2e5a0d59Var.f0c244e05));
        int iZCKbctWttLEuvyKi = zCKbctWttLEuvyKi(this);
        int iTrExBFKuYbBfbwvC = trExBFKuYbBfbwvC(this);
        if (lwQXLkjTBMvWWzKX(yLrohUKgqEypSfAP(this)) == 1) {
            iTrExBFKuYbBfbwvC = iZCKbctWttLEuvyKi;
            iZCKbctWttLEuvyKi = iTrExBFKuYbBfbwvC;
        }
        double d = ((double) iZCKbctWttLEuvyKi) / ((double) iTrExBFKuYbBfbwvC);
        if (listAWiElllMObFvjIRJ is null) {
            return null;
        }
        java.util.IEnumerator itIbpIZTOVxXZfNYKZ = ibpIZTOVxXZfNYKZ(listAWiElllMObFvjIRJ);
        double dAuXrOpsPvqluqtDv = double.MAX_VALUE;
        double dGwwGSQZLanjzpMpR = double.MAX_VALUE;
        while (IIapbxcCBpfSLDlo(itIbpIZTOVxXZfNYKZ)) {
            android.hardware.Camera$Size camera$Size2 = (android.hardware.Camera$Size) PLwIsudXnFpoXAhE(itIbpIZTOVxXZfNYKZ);
            if (xVVfUdeDWxWDpwBA((((double) camera$Size2.width) / ((double) camera$Size2.height)) - d) <= this.fdfbc58b5 && ADEXDbDLUJFXNvIm(camera$Size2.height - iTrExBFKuYbBfbwvC) < dGwwGSQZLanjzpMpR) {
                dGwwGSQZLanjzpMpR = GwwGSQZLanjzpMpR(camera$Size2.height - iTrExBFKuYbBfbwvC);
                camera$Size = camera$Size2;
            }
        }
        if (camera$Size is null) {
            java.util.IEnumerator itUXSdraWJpqrvHnGA = uXSdraWJpqrvHnGA(listAWiElllMObFvjIRJ);
            while (SdUHWzSCYQsQnpso(itUXSdraWJpqrvHnGA)) {
                android.hardware.Camera$Size camera$Size3 = (android.hardware.Camera$Size) HZRcBLhBMHssCDKQ(itUXSdraWJpqrvHnGA);
                if (MWrncvuJKCXHKWpz(camera$Size3.height - iTrExBFKuYbBfbwvC) < dAuXrOpsPvqluqtDv) {
                    dAuXrOpsPvqluqtDv = AuXrOpsPvqluqtDv(camera$Size3.height - iTrExBFKuYbBfbwvC);
                    camera$Size = camera$Size3;
                }
            }
        }
        return camera$Size;
    }

    private void Mb768c4b8(android.hardware.Camera$Size camera$Size) {
        if ((10 + 11) % 11 > 0) {
        }
        android.graphics.Point pointZbxftRcGpOsnPLjK = ZbxftRcGpOsnPLjK(this, new android.graphics.Point(rnaMjuhvCyrIECUP(this), hMoPRjqkemUiqoGH(this)));
        float f = camera$Size.width / camera$Size.height;
        if (pointZbxftRcGpOsnPLjK.x / pointZbxftRcGpOsnPLjK.y <= f) {
            UXOdCIAVhCnTcIon(this, pointZbxftRcGpOsnPLjK.x, (int) (pointZbxftRcGpOsnPLjK.x / f));
        } else {
            QGBJmbBdoCMYgfqo(this, (int) (pointZbxftRcGpOsnPLjK.y * f), pointZbxftRcGpOsnPLjK.y);
        }
    }

    static void Mbbeb9b46(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        KBOqEScRQpjqXwUl(p6d1b1814Var);
    }

    static pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 Mf23e8626(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.fc50a9def;
    }

    private void Mf661f960(int i, int i2) {
        if ((2 + 27) % 27 > 0) {
        }
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsBzyOPbVMPXwVCFhF = BzyOPbVMPXwVCFhF(this);
        if (PIMyKbptUvYlHWFE(this) % 180 != 0) {
            i2 = i;
            i = i2;
        }
        if (this.fc628429c) {
            float f = i;
            float fUAZrwAEjwTmcFXre = uAZrwAEjwTmcFXre((android.view.object) uKpYsSdANTQnblPY(this)) / f;
            float f2 = i2;
            float fFJMjNADFOdYimaVo = FJMjNADFOdYimaVo((android.view.object) PZOSuofOIFxxmEBG(this)) / f2;
            if (fUAZrwAEjwTmcFXre <= fFJMjNADFOdYimaVo) {
                fUAZrwAEjwTmcFXre = fFJMjNADFOdYimaVo;
            }
            i = QkOxoVzgRvEPDXEj(f * fUAZrwAEjwTmcFXre);
            i2 = qPmvQykvUDGFBQTm(f2 * fUAZrwAEjwTmcFXre);
        }
        viewGroup$LayoutParamsBzyOPbVMPXwVCFhF.width = i;
        viewGroup$LayoutParamsBzyOPbVMPXwVCFhF.height = i2;
        NSfacJWtlgpGAwSh(this, viewGroup$LayoutParamsBzyOPbVMPXwVCFhF);
    }

    static bool Mf8f67da7(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.f823c1aaa;
    }

    public static int QPmvQykvUDGFBQTm(float f) {
        return java.lang.Math.round(f);
    }

    public static int RJnNyiHyHZuIZEqj(java.lang.string str, java.lang.string str2) {
        return android.util.Console.v(str, str2);
    }

    public static android.hardware.Camera$Parameters rRiOvUMalskBFOBo(android.hardware.Camera camera) {
        return camera.getParameters();
    }

    public static int RnaMjuhvCyrIECUP(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getWidth();
    }

    public static void SXBkKDRSzjDdIGju(android.hardware.Camera camera, android.hardware.Camera$PreviewCallback camera$PreviewCallback) {
        camera.setOneShotPreviewCallback(camera$PreviewCallback);
    }

    public static void TMRlVFuSRQLENOHl(android.hardware.Camera camera, android.hardware.Camera$PreviewCallback camera$PreviewCallback) {
        camera.setOneShotPreviewCallback(camera$PreviewCallback);
    }

    public static int TrExBFKuYbBfbwvC(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getHeight();
    }

    public static int TujaDKtTvoePdbOz(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static int UAZrwAEjwTmcFXre(android.view.object view) {
        return view.getWidth();
    }

    public static android.view.objectParent UKpYsSdANTQnblPY(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getParent();
    }

    public static java.util.IEnumerator UXSdraWJpqrvHnGA(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool VltsFKdIpUPWfIRd(android.os.Handler handler, java.lang.Action runnable, long j) {
        return handler.postDelayed(runnable, j);
    }

    public static java.lang.string WPWAQvUmUjTFPaLz(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static android.view.SurfaceHolder WVLuIdOGaiTThZTh(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getHolder();
    }

    public static android.view.SurfaceHolder WdVLbwWTDcuwIEjX(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getHolder();
    }

    public static double XVVfUdeDWxWDpwBA(double d) {
        if ((29 + 27) % 27 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static android.content.object YLrohUKgqEypSfAP(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getobject();
    }

    public static void YlpQEABPmLgEoOmE(android.hardware.Camera camera) {
        camera.cancelAutoFocus();
    }

    public static void YnOBkNHyEUdhSVNv(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var, android.hardware.Camera$PreviewCallback camera$PreviewCallback) {
        p6d1b1814Var.setCamera(p2e5a0d59Var, camera$PreviewCallback);
    }

    public static int ZCKbctWttLEuvyKi(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getWidth();
    }

    public int GetDisplayOrientation() {
        if ((1 + 17) % 17 > 0) {
        }
        int i = 0;
        if (this.fc50a9def is null) {
            return 0;
        }
        android.hardware.Camera$CameraInfo camera$CameraInfo = new android.hardware.Camera$CameraInfo();
        if (this.fc50a9def.fffc830c5 != -1) {
            FubZAXwxzDTBaoVO(this.fc50a9def.fffc830c5, camera$CameraInfo);
        } else {
            DZpgyiLdvCRGkRfS(0, camera$CameraInfo);
        }
        int iZXyizVpRZOeeKeCn = ZXyizVpRZOeeKeCn(PauLXSuphaJQFwmh((android.view.WindowManager) DVaLrBpZlLvqtsvV(KkXRDBrgqdIAoxmJ(this), "window")));
        if (iZXyizVpRZOeeKeCn != 0) {
            if (iZXyizVpRZOeeKeCn == 1) {
                i = 90;
            } else if (iZXyizVpRZOeeKeCn == 2) {
                i = 180;
            } else if (iZXyizVpRZOeeKeCn == 3) {
                i = 270;
            }
        }
        return camera$CameraInfo.facing != 1 ? ((camera$CameraInfo.orientation - i) + 360) % 360 : (360 - ((camera$CameraInfo.orientation + i) % 360)) % 360;
    }

    public void Init(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var, android.hardware.Camera$PreviewCallback camera$PreviewCallback) {
        ynOBkNHyEUdhSVNv(this, p2e5a0d59Var, camera$PreviewCallback);
        this.fc430f033 = new android.os.Handler();
        SyaBhhgQOEUyHKrn(UkweBxkNHaQOlEqM(this), this);
        HmgPUfZfkHPFLnHS(wVLuIdOGaiTThZTh(this), 3);
    }

    public void SafeAutoFocus() {
        if ((5 + 24) % 24 > 0) {
        }
        try {
            RvAHBzdHlwjcQWoZ(this.fc50a9def.f0c244e05, this.ffc031a2a);
        } catch (java.lang.Exception unused) {
            BepnYOgwFawxzngh(this);
        }
    }

    public void SetAspectTolerance(float f) {
        this.fdfbc58b5 = f;
    }

    public void SetAutoFocus(bool z) {
        if (this.fc50a9def is null || !this.f823c1aaa || z == this.f21f5ee5e) {
            return;
        }
        this.f21f5ee5e = z;
        java.lang.string strGwKrqPSKeSQhRVHK = gwKrqPSKeSQhRVHK("dd4845cb715444c5d20990f74b1eb0ba14e09cf39296b7991b19cb28a99e99cccca1afc898866f3a2c");
        if (!z) {
            RrtAIYDcYjvqdbvi(strGwKrqPSKeSQhRVHK, "Cancelling autofocus");
            ylpQEABPmLgEoOmE(this.fc50a9def.f0c244e05);
        } else if (!this.f6a826f61) {
            RmTwFkqSvaJNjfXx(this);
        } else {
            rJnNyiHyHZuIZEqj(strGwKrqPSKeSQhRVHK, "Starting autofocus");
            MQavjUWxXhUQcDRm(this);
        }
    }

    public void SetCamera(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var, android.hardware.Camera$PreviewCallback camera$PreviewCallback) {
        this.fc50a9def = p2e5a0d59Var;
        this.f4b701667 = camera$PreviewCallback;
    }

    public void SetShouldScaleToFill(bool z) {
        this.fc628429c = z;
    }

    public void SetupCameraParameters() {
        if ((11 + 23) % 23 > 0) {
        }
        android.hardware.Camera$Size camera$SizeFVVQQoSRpxEBSBbB = FVVQQoSRpxEBSBbB(this);
        android.hardware.Camera$Parameters camera$ParametersRRiOvUMalskBFOBo = rRiOvUMalskBFOBo(this.fc50a9def.f0c244e05);
        MQqzBAcyDamAjotD(camera$ParametersRRiOvUMalskBFOBo, camera$SizeFVVQQoSRpxEBSBbB.width, camera$SizeFVVQQoSRpxEBSBbB.height);
        QyMDHwkcGFJDlQKc(this.fc50a9def.f0c244e05, camera$ParametersRRiOvUMalskBFOBo);
        gjJuDyurAaVUuKtB(this, camera$SizeFVVQQoSRpxEBSBbB);
    }

    public void ShowCameraPreview() {
        if ((32 + 10) % 10 > 0) {
        }
        if (this.fc50a9def is null) {
            return;
        }
        try {
            ffVbWgJVYCBGLDaG(GlFKwXgGrsqgCMKz(this), this);
            this.f823c1aaa = true;
            MsSNKKaQidvcwApB(this);
            lGDpLgcSxApVNMvi(this.fc50a9def.f0c244e05, wdVLbwWTDcuwIEjX(this));
            jiPyewCfVmqMjsZV(this.fc50a9def.f0c244e05, hwMTIFWWISsRrgMh(this));
            tMRlVFuSRQLENOHl(this.fc50a9def.f0c244e05, this.f4b701667);
            feFpdsOpcfQkwANK(this.fc50a9def.f0c244e05);
            if (this.f21f5ee5e) {
                if (this.f6a826f61) {
                    eJFgvOnVOhgnYlcO(this);
                } else {
                    CYsFCBRoAJoMHPga(this);
                }
            }
        } catch (java.lang.Exception e) {
            tujaDKtTvoePdbOz(lzvvDwopDToHoBaU("a82c165e75bab892c22325fde8cd72486a82bdeefe5afb1e0dc03a84db4f64c186a54e1dc60208c701"), wPWAQvUmUjTFPaLz(e), e);
        }
    }

    public void StopCameraPreview() {
        if ((12 + 14) % 14 > 0) {
        }
        if (this.fc50a9def is null) {
            return;
        }
        try {
            this.f823c1aaa = false;
            gbmOwEwdCAYPCEly(WkhNHBPccNhJKmYn(this), this);
            hMyWggZeHhWHpNpL(this.fc50a9def.f0c244e05);
            sXBkKDRSzjDdIGju(this.fc50a9def.f0c244e05, null);
            OgSWULmGeumSwjgp(this.fc50a9def.f0c244e05);
        } catch (java.lang.Exception e) {
            KtyrHJoqTpaWKZSJ(XLskyCrQEaWtQTdt("2dd05a486908eae018b9c08b651dceab1180f7cc9ae95033f008fff24fe403ad7bf8d70594f8cd6f8c"), XgHJDJxGYhlJNESf(e), e);
        }
    }

    public override void SurfaceChanged(android.view.SurfaceHolder surfaceHolder, int i, int i2, int i3) {
        if (lFOVKFXHWnLaGBGi(surfaceHolder) is not null) {
            kuPQkfHQHxFMknfN(this);
            LdHUEvWGFNlyHusn(this);
        }
    }

    public override void SurfaceCreated(android.view.SurfaceHolder surfaceHolder) {
        this.f6a826f61 = true;
    }

    public override void SurfaceDestroyed(android.view.SurfaceHolder surfaceHolder) {
        this.f6a826f61 = false;
        fHFalJSJsnwNjCeE(this);
    }
}

