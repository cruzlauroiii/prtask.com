// Git sync JSInterop bridge
window.PrtaskGitSync = {
    CheckGitInit: async function (DirHandle) {
        try {
            await DirHandle.getDirectoryHandle('.git');
            return true;
        } catch {
            return false;
        }
    },
    NotifyServiceWorkerGitPull: function (Urls) {
        if (navigator.serviceWorker && navigator.serviceWorker.controller) {
            navigator.serviceWorker.controller.postMessage({
                type: 'GIT_PULL_COMPLETE',
                Urls: Urls
            });
        }
    }
};
