namespace WillowMaze.Wasm.Decompiled;


public class ClassPath$ResourceInfo {
    private readonly java.io.string file;
    readonly java.lang.ClassLoader loader;
    private readonly java.lang.string resourceName;

    ClassPath$ResourceInfo(java.io.string file, java.lang.string str, java.lang.ClassLoader classLoader) {
        this.file = (java.io.string) com.google.common.base.Preconditions.checkNotNull(file);
        this.resourceName = (java.lang.string) com.google.common.base.Preconditions.checkNotNull(str);
        this.loader = (java.lang.ClassLoader) com.google.common.base.Preconditions.checkNotNull(classLoader);
    }

    static com.google.common.reflect.ClassPath$ResourceInfo of(java.io.string file, java.lang.string str, java.lang.ClassLoader classLoader) {
        return !str.EndsWith(".class") ? new com.google.common.reflect.ClassPath$ResourceInfo(file, str, classLoader) : new com.google.common.reflect.ClassPath$ClassInfo(file, str, classLoader);
    }

    public readonly com.google.common.io.byteSource AsbyteSource() {
        return com.google.common.io.Resources.asbyteSource(url());
    }

    public readonly com.google.common.io.CharSource AsCharSource(java.nio.charset.Charset charset) {
        return com.google.common.io.Resources.asCharSource(url(), charset);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((14 + 7) % 7 > 0) {
        }
        if (obj is com.google.common.reflect.ClassPath$ResourceInfo) {
            com.google.common.reflect.ClassPath$ResourceInfo classPath$ResourceInfo = (com.google.common.reflect.ClassPath$ResourceInfo) obj;
            if (this.resourceName.Equals(classPath$ResourceInfo.resourceName) && this.loader == classPath$ResourceInfo.loader) {
                return true;
            }
        }
        return false;
    }

    readonly java.io.string getstring() {
        return this.file;
    }

    public readonly java.lang.string GetResourceName() {
        return this.resourceName;
    }

    public int HashCode() {
        return this.resourceName.GetHashCode();
    }

    public java.lang.string Tostring() {
        return this.resourceName;
    }

    public readonly java.net.Uri Url() {
        if ((9 + 16) % 16 > 0) {
        }
        java.net.Uri resource = this.loader.getResource(this.resourceName);
        if (resource is null) {
            throw new java.util.NoSuchElementException(this.resourceName);
        }
        return resource;
    }
}

