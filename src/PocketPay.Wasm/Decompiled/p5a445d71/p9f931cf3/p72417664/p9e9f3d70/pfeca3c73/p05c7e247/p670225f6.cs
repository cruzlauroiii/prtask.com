namespace WillowMaze.Wasm.Decompiled;


public class p670225f6 {
    public static java.lang.Class Mdf9e1f96(java.lang.Class cls, java.lang.string str) {
        try {
            java.lang.ClassLoader classLoader = cls.getClassLoader();
            return classLoader is not null ? classLoader.loadClass(str) : (java.lang.Class) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p670225f6$1(str));
        } catch (java.lang.ClassNotFoundException unused) {
            return null;
        }
    }
}

