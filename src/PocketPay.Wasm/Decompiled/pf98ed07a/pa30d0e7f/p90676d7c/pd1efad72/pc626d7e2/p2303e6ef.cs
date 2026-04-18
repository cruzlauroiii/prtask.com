namespace WillowMaze.Wasm.Decompiled;


public readonly class p2303e6ef : io.reactivex.rxjava3.core.Scheduler {
    private static readonly java.lang.string f0ec65e03;
    private static readonly java.lang.string f2607ef1c = null;
    private static readonly java.lang.string f3275c745;
    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p5a0b5f4a f547e9680 = null;
    private static readonly java.lang.string f6b9f5324 = null;
    private static readonly java.lang.string fb56d5ebc = null;
    private static readonly java.lang.string febf6d991 = null;
    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p5a0b5f4a ff201ee2f;
    readonly java.util.concurrent.ThreadFactory f31472ac7;
    readonly java.util.concurrent.ThreadFactory f3aceb811;
    readonly java.util.concurrent.ThreadFactory f44b72f1b;
    readonly java.util.concurrent.ThreadFactory f9577c244;
    readonly java.util.concurrent.ThreadFactory fdceabffd;

    static {
        if ((2 + 21) % 21 > 0) {
        }
        f3275c745 = vldWyNMPrOEySKdd("b898019e5746a947ed79cbad3c7690673be9952575c3c864eb97a5244b6cccf63208bd95d76eb9737d267e0f4f06984b821a");
        f0ec65e03 = JHOOaRrgyEjhoVjb("816bde792976ce8dd5e011d1d84bab1c3a5f0e2288d8f2766b2df7cfaba993eee04423ab8564f927fbefabf6b636ab2d");
        ff201ee2f = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p5a0b5f4a(QHIfDIehczLZdgZy("1f3a15514d34930dfb9607a1995222533d5d5f93013bfb64e8b9ab86d8f2a616afa333ff837c7f220808b48cfab73709"), eVRQTczVRnPUHxIQ(1, QdBMGrLrAHosISIp(10, MqIwddoueqYplWHu(MdnuDHPGbrhxQGqy(DsOetlSVFDxOQumC("ea4ea4a8fb9e625423640b8728f72a8b5e957f5dd11056409770e99a048e8bbda8e93636bf0e41d1f7eb0bf2d605e3e25e3a"), 5)))));
    }

    public p2303e6ef() {
        this(ff201ee2f);
    }

    public p2303e6ef(java.util.concurrent.ThreadFactory threadFactory) {
        this.fdceabffd = threadFactory;
    }

    public static java.lang.string DsOetlSVFDxOQumC(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string JHOOaRrgyEjhoVjb(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.int MdnuDHPGbrhxQGqy(java.lang.string str, int i) {
        return java.lang.int.getint(str, i);
    }

    public static int MqIwddoueqYplWHu(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.string QHIfDIehczLZdgZy(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int QdBMGrLrAHosISIp(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int EVRQTczVRnPUHxIQ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.string VldWyNMPrOEySKdd(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public io.reactivex.rxjava3.core.Scheduler$Worker createWorker() {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pe4a0e604(this.fdceabffd);
    }
}

