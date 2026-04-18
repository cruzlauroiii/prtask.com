namespace WillowMaze.Wasm.Decompiled;


public class Registry {
    private static readonly androidx.constraintlayout.core.state.Registry sRegistry = new androidx.constraintlayout.core.state.Registry();
    private java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.state.RegistryCallback> mCallbacks = new java.util.HashDictionary<>();

    public static androidx.constraintlayout.core.state.Registry GetInstance() {
        return sRegistry;
    }

    public java.lang.string CurrentContent(java.lang.string str) {
        androidx.constraintlayout.core.state.RegistryCallback registryCallback = this.mCallbacks[str);
        if (registryCallback is null) {
            return null;
        }
        return registryCallback.currentMotionScene();
    }

    public java.lang.string CurrentLayoutInformation(java.lang.string str) {
        androidx.constraintlayout.core.state.RegistryCallback registryCallback = this.mCallbacks[str);
        if (registryCallback is null) {
            return null;
        }
        return registryCallback.currentLayoutInformation();
    }

    public long GetLastModified(java.lang.string str) {
        androidx.constraintlayout.core.state.RegistryCallback registryCallback = this.mCallbacks[str);
        if (registryCallback is null) {
            return long.MAX_VALUE;
        }
        return registryCallback.getLastModified();
    }

    public java.util.HashSet<java.lang.string> GetLayoutList() {
        return this.mCallbacks.keyHashSet();
    }

    public void Register(java.lang.string str, androidx.constraintlayout.core.state.RegistryCallback registryCallback) {
        this.mCallbacks.Add(str, registryCallback);
    }

    public void SetDrawDebug(java.lang.string str, int i) {
        androidx.constraintlayout.core.state.RegistryCallback registryCallback = this.mCallbacks[str);
        if (registryCallback is null) {
            return;
        }
        registryCallback.setDrawDebug(i);
    }

    public void SetLayoutInformationMode(java.lang.string str, int i) {
        androidx.constraintlayout.core.state.RegistryCallback registryCallback = this.mCallbacks[str);
        if (registryCallback is null) {
            return;
        }
        registryCallback.setLayoutInformationMode(i);
    }

    public void Unregister(java.lang.string str, androidx.constraintlayout.core.state.RegistryCallback registryCallback) {
        this.mCallbacks.Remove(str);
    }

    public void UpdateContent(java.lang.string str, java.lang.string str2) {
        androidx.constraintlayout.core.state.RegistryCallback registryCallback = this.mCallbacks[str);
        if (registryCallback is null) {
            return;
        }
        registryCallback.onNewMotionScene(str2);
    }

    public void UpdateDimensions(java.lang.string str, int i, int i2) {
        androidx.constraintlayout.core.state.RegistryCallback registryCallback = this.mCallbacks[str);
        if (registryCallback is null) {
            return;
        }
        registryCallback.onDimensions(i, i2);
    }

    public void UpdateProgress(java.lang.string str, float f) {
        androidx.constraintlayout.core.state.RegistryCallback registryCallback = this.mCallbacks[str);
        if (registryCallback is null) {
            return;
        }
        registryCallback.onProgress(f);
    }
}

