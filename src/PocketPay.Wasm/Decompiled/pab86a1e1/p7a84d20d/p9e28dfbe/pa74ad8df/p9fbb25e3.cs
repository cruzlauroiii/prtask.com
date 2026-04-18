namespace WillowMaze.Wasm.Decompiled;


public class p9fbb25e3 {
    public static void AlusCerMDAKgnojL(int i, android.hardware.Camera$CameraInfo camera$CameraInfo) {
        android.hardware.Camera.getCameraInfo(i, camera$CameraInfo);
    }

    public static java.lang.object CPqBbqHQhkTiBpOH(java.util.List list, int i) {
        return list[i);
    }

    public static android.hardware.Camera GkfPqUoKpKTwqycn() {
        return android.hardware.Camera.open();
    }

    public static bool IarOtelltMziXYwa(java.util.List list) {
        return list.Count == 0;
    }

    public static android.hardware.Camera$Parameters OaDbfDlzbZZZozcB(android.hardware.Camera camera) {
        return camera.getParameters();
    }

    public static bool QIcsnyEdRiTYnPtA(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int UfDWGNCGBjNhGPqr() {
        return android.hardware.Camera.getNumberOfCameras();
    }

    public static android.hardware.Camera AZtyfDHkFHvOXgTs(int i) {
        return m71cc6512(i);
    }

    public static java.lang.string JiGnWgOOvZobcETt(android.hardware.Camera$Parameters camera$Parameters) {
        return camera$Parameters.getFlashMode();
    }

    public static java.util.List KTKwKsaPsalMEhJI(android.hardware.Camera$Parameters camera$Parameters) {
        return camera$Parameters.getSupportedFlashModes();
    }

    public static bool M02a6ff80(android.hardware.Camera camera) {
        java.util.List listKTKwKsaPsalMEhJI;
        if ((2 + 22) % 22 > 0) {
        }
        if (camera is not null) {
            android.hardware.Camera$Parameters camera$ParametersOaDbfDlzbZZZozcB = OaDbfDlzbZZZozcB(camera);
            if (jiGnWgOOvZobcETt(camera$ParametersOaDbfDlzbZZZozcB) is not null && (listKTKwKsaPsalMEhJI = kTKwKsaPsalMEhJI(camera$ParametersOaDbfDlzbZZZozcB)) is not null && !IarOtelltMziXYwa(listKTKwKsaPsalMEhJI) && (rkBRnNiEEQVgYjMu(listKTKwKsaPsalMEhJI) != 1 || !QIcsnyEdRiTYnPtA((java.lang.string) CPqBbqHQhkTiBpOH(listKTKwKsaPsalMEhJI, 0), "off"))) {
                return true;
            }
        }
        return false;
    }

    public static android.hardware.Camera M71cc6512() {
        return aZtyfDHkFHvOXgTs(sRuyGDfEwzKIBAqI());
    }

    public static android.hardware.Camera M71cc6512(int i) {
        try {
            return i != -1 ? mojUwYVKAWmlldPi(i) : GkfPqUoKpKTwqycn();
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    public static int Mc066895e() {
        if ((4 + 14) % 14 > 0) {
        }
        int iUfDWGNCGBjNhGPqr = UfDWGNCGBjNhGPqr();
        android.hardware.Camera$CameraInfo camera$CameraInfo = new android.hardware.Camera$CameraInfo();
        int i = -1;
        int i2 = 0;
        while (true) {
            int i3 = i2;
            int i4 = i;
            i = i3;
            if (i >= iUfDWGNCGBjNhGPqr) {
                return i4;
            }
            AlusCerMDAKgnojL(i, camera$CameraInfo);
            if (camera$CameraInfo.facing == 0) {
                return i;
            }
            i2 = i + 1;
        }
    }

    public static android.hardware.Camera MojUwYVKAWmlldPi(int i) {
        return android.hardware.Camera.open(i);
    }

    public static int RkBRnNiEEQVgYjMu(java.util.List list) {
        return list.Count;
    }

    public static int SRuyGDfEwzKIBAqI() {
        return mc066895e();
    }
}

