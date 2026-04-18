importScripts('service-worker-assets.js');

var PagesCacheName = 'prtask-pages';
var AssetsCacheName = 'prtask-assets';
var OfflineFallbackPage = '<html><head><meta charset="utf-8"><title>Offline</title><style>body{font-family:sans-serif;display:flex;align-items:center;justify-content:center;height:100vh;margin:0;background:#1a1a2e;color:#e0e0e0}div{text-align:center}h1{font-size:2rem}p{color:#aaa}</style></head><body><div><h1>You are offline</h1><p>This page is not yet available offline. Connect to the internet and try again.</p></div></body></html>';

// ── Helpers ──

function IsNavigationRequest(event) {
    // mode=navigate is the standard check for page navigations
    if (event.request.mode === 'navigate') return true;

    // Fallback: check Accept header for text/html on GET requests
    var accept = event.request.headers.get('Accept');
    if (event.request.method === 'GET' && accept && accept.indexOf('text/html') !== -1) {
        var url = new URL(event.request.url);
        // Exclude files with known static extensions
        if (url.pathname.match(/\.(js|css|wasm|dll|dat|blat|json|png|jpg|jpeg|gif|svg|ico|woff2?|ttf|eot|map)$/i)) {
            return false;
        }
        return true;
    }

    return false;
}

function IsFrameworkRequest(pathname) {
    return pathname.startsWith('/_framework/') || pathname.startsWith('/_content/')
        || pathname.startsWith('/Framework/') || pathname.startsWith('/Content/')
        || pathname.indexOf('/Framework/') !== -1 || pathname.indexOf('/Content/') !== -1;
}

function IsStaticAsset(pathname) {
    return !!pathname.match(/\.(css|png|jpg|jpeg|gif|svg|ico|woff2?|ttf|eot|webp|avif|mp4|webm)$/i);
}

// ── Install: pre-cache Blazor framework assets ──

self.addEventListener('install', function (event) {
    event.waitUntil(
        caches.open(AssetsCacheName).then(function (cache) {
            var assets = self.assetsManifest.assets
                .filter(function (a) { return a.url.match(/\.(js|css|wasm|dll|dat|blat|json|png|jpg|svg|ico|woff2?)$/i); });
            // Use individual cache.add() calls so one failure doesn't cancel all others
            return Promise.all(assets.map(function (a) {
                return cache.add(new Request(a.url, { integrity: a.hash, cache: 'no-cache' }))
                    .catch(function (err) {
                        console.warn('SW: Failed to cache ' + a.url, err);
                    });
            }));
        })
    );
});

// ── Activate: clean old caches, keep only current named caches ──

self.addEventListener('activate', function (event) {
    var ValidCaches = [PagesCacheName, AssetsCacheName];
    event.waitUntil(
        caches.keys().then(function (keys) {
            return Promise.all(
                keys.filter(function (k) { return ValidCaches.indexOf(k) === -1; })
                    .map(function (k) { return caches.delete(k); })
            );
        })
    );
});

// ── Fetch: Cache-first for pages, cache-first for assets ──

self.addEventListener('fetch', function (event) {
    var url = new URL(event.request.url);

    // Only handle same-origin requests
    if (url.origin !== self.location.origin) return;

    // API and WebSocket: network-only passthrough
    if (url.pathname.startsWith('/Api/') || url.pathname.startsWith('/ws')) {
        event.respondWith(
            fetch(event.request).catch(function () {
                return caches.match(event.request);
            })
        );
        return;
    }

    // Navigation / HTML page requests → page cache first
    if (IsNavigationRequest(event)) {
        event.respondWith(HandleNavigationRequest(event.request, url));
        return;
    }

    // _framework/* and _content/* → asset cache first (Blazor WASM runtime)
    if (IsFrameworkRequest(url.pathname)) {
        event.respondWith(
            caches.open(AssetsCacheName).then(function (cache) {
                return cache.match(event.request).then(function (cached) {
                    return cached || fetch(event.request).then(function (response) {
                        cache.put(event.request, response.clone());
                        return response;
                    });
                });
            }).catch(function () {
                return caches.match(event.request);
            })
        );
        return;
    }

    // Static assets (CSS, images, fonts) → asset cache first with network fallback
    if (IsStaticAsset(url.pathname) && event.request.method === 'GET') {
        event.respondWith(
            caches.open(AssetsCacheName).then(function (cache) {
                return cache.match(event.request).then(function (cached) {
                    return cached || fetch(event.request).then(function (response) {
                        cache.put(event.request, response.clone());
                        return response;
                    });
                });
            }).catch(function () {
                return caches.match(event.request);
            })
        );
        return;
    }

    // All other GET requests → asset cache first
    if (event.request.method === 'GET') {
        event.respondWith(
            caches.open(AssetsCacheName).then(function (cache) {
                return cache.match(event.request).then(function (cached) {
                    return cached || fetch(event.request).then(function (response) {
                        cache.put(event.request, response.clone());
                        return response;
                    });
                });
            }).catch(function () {
                return caches.match(event.request);
            })
        );
        return;
    }

    // Non-GET → pass through
    event.respondWith(fetch(event.request));
});

// ── Navigation handler: Page Cache → network → offline fallback ──

async function HandleNavigationRequest(request, url) {
    try {
        // 1. Check page cache first (zero network)
        var PageCache = await caches.open(PagesCacheName);
        var CachedResponse = await PageCache.match(request);
        if (CachedResponse) {
            return CachedResponse;
        }
    } catch (e) {
        // Cache read failed, continue to network
    }

    try {
        // 2. Not in cache → fetch from network
        var NetworkResponse = await fetch(request);
        if (NetworkResponse.ok) {
            // Save to page cache for future offline use
            var PageCacheForWrite = await caches.open(PagesCacheName);
            await PageCacheForWrite.put(request, NetworkResponse.clone());
            return NetworkResponse;
        }
        return NetworkResponse;
    } catch (e) {
        // 3. Network failed + no cache → offline fallback
        return new Response(OfflineFallbackPage, {
            status: 503,
            headers: { 'Content-Type': 'text/html; charset=utf-8' }
        });
    }
}

// ── Message handler ──

self.addEventListener('message', function (event) {
    if (!event.data || !event.data.type) return;

    // Allow the main thread to trigger skipWaiting for SW updates
    if (event.data.type === 'SKIP_WAITING') {
        self.skipWaiting();
        return;
    }

    // Allow the main thread to push pages into the cache
    // (used by WSS sync flow when diffs arrive and pages are rebuilt)
    // Message shape: { type: 'CACHE_PAGE', Url: '/Settings', Html: '<html>...</html>' }
    if (event.data.type === 'CACHE_PAGE') {
        var PageUrl = event.data.Url;
        var PageHtml = event.data.Html;
        if (!PageUrl || !PageHtml) return;

        // Build a full URL so the cache key matches navigation requests
        var FullUrl = new URL(PageUrl, self.location.origin).href;

        event.waitUntil(
            caches.open(PagesCacheName).then(function (cache) {
                var CacheResponse = new Response(PageHtml, {
                    status: 200,
                    headers: { 'Content-Type': 'text/html; charset=utf-8' }
                });
                return cache.put(new Request(FullUrl), CacheResponse);
            })
        );
        return;
    }

    // Allow the main thread to remove a cached page
    // Message shape: { type: 'UNCACHE_PAGE', Url: '/Settings' }
    if (event.data.type === 'UNCACHE_PAGE') {
        var RemoveUrl = event.data.Url;
        if (!RemoveUrl) return;

        var RemoveFullUrl = new URL(RemoveUrl, self.location.origin).href;

        event.waitUntil(
            caches.open(PagesCacheName).then(function (cache) {
                return cache.delete(new Request(RemoveFullUrl));
            })
        );
        return;
    }

    // Re-cache pages from local directory after WASM git pull completes
    // Message shape: { type: 'GIT_PULL_COMPLETE', Urls: ['/Settings', '/tasks', ...] }
    if (event.data.type === 'GIT_PULL_COMPLETE') {
        event.waitUntil(
            caches.open(PagesCacheName).then(function (Cache) {
                return Cache.addAll(event.data.Urls || ['/']);
            })
        );
        return;
    }

    // Allow the main thread to cache multiple pages at once
    // Message shape: { type: 'CACHE_PAGES', Pages: [{ Url: '/', Html: '...' }, ...] }
    if (event.data.type === 'CACHE_PAGES') {
        var Pages = event.data.Pages;
        if (!Pages || !Pages.length) return;

        event.waitUntil(
            caches.open(PagesCacheName).then(function (cache) {
                return Promise.all(Pages.map(function (Page) {
                    if (!Page.Url || !Page.Html) return Promise.resolve();
                    var BatchFullUrl = new URL(Page.Url, self.location.origin).href;
                    var BatchResponse = new Response(Page.Html, {
                        status: 200,
                        headers: { 'Content-Type': 'text/html; charset=utf-8' }
                    });
                    return cache.put(new Request(BatchFullUrl), BatchResponse);
                }));
            })
        );
        return;
    }
});
