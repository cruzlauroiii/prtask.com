importScripts('service-worker-assets.js');

var CacheName = 'prtask-cache-v1';
var OfflineFallbackUrl = '/';

self.addEventListener('install', function (event) {
    event.waitUntil(
        caches.open(CacheName).then(function (cache) {
            var assets = self.assetsManifest.assets
                .filter(function (a) { return a.url.match(/\.(js|css|wasm|dll|dat|blat|json|png|jpg|svg|ico|woff2?)$/i); })
                .map(function (a) { return new Request(a.url, { integrity: a.hash, cache: 'no-cache' }); });
            return cache.addAll(assets);
        })
    );
});

self.addEventListener('activate', function (event) {
    event.waitUntil(
        caches.keys().then(function (keys) {
            return Promise.all(
                keys.filter(function (k) { return k !== CacheName; })
                    .map(function (k) { return caches.delete(k); })
            );
        })
    );
});

self.addEventListener('fetch', function (event) {
    var url = new URL(event.request.url);

    if (url.pathname.startsWith('/api/') || url.pathname.startsWith('/ws')) {
        event.respondWith(
            fetch(event.request).catch(function () {
                return caches.match(event.request);
            })
        );
        return;
    }

    if (event.request.method === 'GET') {
        event.respondWith(
            caches.match(event.request).then(function (cached) {
                return cached || fetch(event.request).then(function (response) {
                    var clone = response.clone();
                    caches.open(CacheName).then(function (cache) {
                        cache.put(event.request, clone);
                    });
                    return response;
                });
            }).catch(function () {
                return caches.match(OfflineFallbackUrl);
            })
        );
        return;
    }

    event.respondWith(fetch(event.request));
});

self.addEventListener('message', function (event) {
    if (event.data && event.data.type === 'SKIP_WAITING') {
        self.skipWaiting();
    }
});
