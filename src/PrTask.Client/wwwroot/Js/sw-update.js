function registerServiceWorkerUpdate() {
    if (!('serviceWorker' in navigator)) return;

    navigator.serviceWorker.ready.then(function (registration) {
        registration.addEventListener('updatefound', function () {
            var newWorker = registration.installing;
            if (!newWorker) return;

            newWorker.addEventListener('statechange', function () {
                if (newWorker.state === 'installed' && navigator.serviceWorker.controller) {
                    DotNet.invokeMethodAsync('PrTask.Client', 'OnServiceWorkerUpdateAvailable');
                }
            });
        });
    });
}

function skipWaitingAndReload() {
    if (!navigator.serviceWorker.controller) return;
    navigator.serviceWorker.controller.postMessage({ type: 'SKIP_WAITING' });
    navigator.serviceWorker.addEventListener('controllerchange', function () {
        window.location.reload();
    });
}

window.prtaskSwUpdate = {
    register: registerServiceWorkerUpdate,
    skipWaitingAndReload: skipWaitingAndReload
};
