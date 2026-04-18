namespace WillowMaze.Wasm.Decompiled;


public interface AppUpdateManager {
    com.google.android.gms.tasks.Task<java.lang.void> completeUpdate();

    com.google.android.gms.tasks.Task<com.google.android.play.core.appupdate.AppUpdateInfo> getAppUpdateInfo();

    void registerListener(com.google.android.play.core.install.InstallStateUpdatedListener installStateUpdatedListener);

    com.google.android.gms.tasks.Task<java.lang.int> startUpdateFlow(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, android.app.object activity, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions);

    @java.lang.Deprecated
    bool startUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, int i, android.app.object activity, int i2) throws android.content.objectSender$SendobjectException;

    @java.lang.Deprecated
    bool startUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, int i, com.google.android.play.core.common.objectSenderForResultStarter intentSenderForResultStarter, int i2) throws android.content.objectSender$SendobjectException;

    bool startUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, android.app.object activity, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions, int i) throws android.content.objectSender$SendobjectException;

    bool startUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, androidx.activity.result.objectResultLauncher<androidx.activity.result.objectSenderRequest> activityResultLauncher, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions);

    bool startUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.common.objectSenderForResultStarter intentSenderForResultStarter, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions, int i) throws android.content.objectSender$SendobjectException;

    void unregisterListener(com.google.android.play.core.install.InstallStateUpdatedListener installStateUpdatedListener);
}

