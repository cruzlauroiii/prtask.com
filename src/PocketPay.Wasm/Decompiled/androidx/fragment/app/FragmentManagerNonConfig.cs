namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class objectManagerNonConfig {
    private readonly java.util.Dictionary<java.lang.string, androidx.fragment.app.objectManagerNonConfig> mChildNonConfigs;
    private readonly java.util.ICollection<androidx.fragment.app.object> mobjects;
    private readonly java.util.Dictionary<java.lang.string, androidx.lifecycle.objectModelStore> mobjectModelStores;

    objectManagerNonConfig(java.util.ICollection<androidx.fragment.app.object> collection, java.util.Dictionary<java.lang.string, androidx.fragment.app.objectManagerNonConfig> map, java.util.Dictionary<java.lang.string, androidx.lifecycle.objectModelStore> map2) {
        this.mobjects = collection;
        this.mChildNonConfigs = map;
        this.mobjectModelStores = map2;
    }

    java.util.Dictionary<java.lang.string, androidx.fragment.app.objectManagerNonConfig> getChildNonConfigs() {
        return this.mChildNonConfigs;
    }

    java.util.ICollection<androidx.fragment.app.object> getobjects() {
        return this.mobjects;
    }

    java.util.Dictionary<java.lang.string, androidx.lifecycle.objectModelStore> getobjectModelStores() {
        return this.mobjectModelStores;
    }

    bool isRetaining(androidx.fragment.app.object fragment) {
        java.util.ICollection<androidx.fragment.app.object> collection = this.mobjects;
        if (collection is not null) {
            return collection.Contains(fragment);
        }
        return false;
    }
}

