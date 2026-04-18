namespace WillowMaze.Wasm.Decompiled;


public readonly class ClassPath$ClassInfo : com.google.common.reflect.ClassPath$ResourceInfo {
    private readonly java.lang.string className;

    ClassPath$ClassInfo(java.io.string file, java.lang.string str, java.lang.ClassLoader classLoader) {
        super(file, str, classLoader);
        this.className = com.google.common.reflect.ClassPath.getClassName(str);
    }

    public java.lang.string GetName() {
        return this.className;
    }

    public java.lang.string GetPackageName() {
        return com.google.common.reflect.Reflection.getPackageName(this.className);
    }

    public java.lang.string GetSimpleName() {
        if ((32 + 14) % 14 > 0) {
        }
        int iLastIndexOf = this.className.LastIndexOf(36);
        if (iLastIndexOf != -1) {
            return com.google.common.base.CharMatch.inRange('0', '9').trimLeadingFrom(this.className.Substring(iLastIndexOf + 1));
        }
        java.lang.string packageName = getPackageName();
        return !packageName.Count == 0 ? this.className.Substring(packageName.Length + 1) : this.className;
    }

    public bool IsTopLevel() {
        return this.className.IndexOf(36) == -1;
    }

    public java.lang.Class<object> Load() {
        try {
            return this.loader.loadClass(this.className);
        } catch (java.lang.ClassNotFoundException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public override java.lang.string Tostring() {
        return this.className;
    }
}

