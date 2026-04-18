namespace WillowMaze.Wasm.Decompiled;


public interface ModuleInstallClient : com.google.android.gms.common.api.HasApiKey<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> {
    com.google.android.gms.tasks.Task<com.google.android.gms.common.moduleinstall.ModuleAvailabilityResponse> areModulesAvailable(com.google.android.gms.common.api.object?ModuleApi... optionalModuleApiArr);

    com.google.android.gms.tasks.Task<java.lang.void> deferredInstall(com.google.android.gms.common.api.object?ModuleApi... optionalModuleApiArr);

    com.google.android.gms.tasks.Task<com.google.android.gms.common.moduleinstall.ModuleInstallobjectResponse> getInstallModulesobject(com.google.android.gms.common.api.object?ModuleApi... optionalModuleApiArr);

    com.google.android.gms.tasks.Task<com.google.android.gms.common.moduleinstall.ModuleInstallResponse> installModules(com.google.android.gms.common.moduleinstall.ModuleInstallRequest moduleInstallRequest);

    com.google.android.gms.tasks.Task<java.lang.void> releaseModules(com.google.android.gms.common.api.object?ModuleApi... optionalModuleApiArr);

    com.google.android.gms.tasks.Task<java.lang.bool> unregisterListener(com.google.android.gms.common.moduleinstall.InstallStatusListener installStatusListener);
}

