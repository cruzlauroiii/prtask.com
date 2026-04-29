//! Licensed to the .NET Foundation under one or more agreements.
//! The .NET Foundation licenses this file to you under the MIT license.

const e=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,4,1,96,0,0,3,2,1,0,10,8,1,6,0,6,64,25,11,11])),o=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,5,1,96,0,1,123,3,2,1,0,10,15,1,13,0,65,1,253,15,65,2,253,15,253,128,2,11])),t=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,5,1,96,0,1,123,3,2,1,0,10,10,1,8,0,65,0,253,15,253,98,11])),n=Symbol.for("wasm promise_control");function r(e,o){let t=null;const r=new Promise(function(n,r){t={isDone:!1,promise:null,resolve:o=>{t.isDone||(t.isDone=!0,n(o),e&&e())},reject:e=>{t.isDone||(t.isDone=!0,r(e),o&&o())}}});t.promise=r;const i=r;return i[n]=t,{promise:i,promise_control:t}}function i(e){return e[n]}function s(e){e&&function(e){return void 0!==e[n]}(e)||Be(!1,"Promise is not controllable")}const a="__mono_message__",l=["debug","log","trace","warn","info","error"],c="MONO_WASM: ";let d,u,f,m,g,p;function h(e){m=e}function b(e){if(Pe.diagnosticTracing){const o="function"==typeof e?e():e;console.debug(c+o)}}function w(e,...o){console.info(c+e,...o)}function y(e,...o){console.info(e,...o)}function v(e,...o){console.warn(c+e,...o)}function _(e,...o){if(o&&o.length>0&&o[0]&&"object"==typeof o[0]){if(o[0].silent)return;if(o[0].toString)return void console.error(c+e,o[0].toString())}console.error(c+e,...o)}function E(e,o,t){return function(...n){try{let r=n[0];if(void 0===r)r="undefined";else if(null===r)r="null";else if("function"==typeof r)r=r.toString();else if("string"!=typeof r)try{r=JSON.stringify(r)}catch(e){r=r.toString()}o(t?JSON.stringify({method:e,payload:r,arguments:n.slice(1)}):[e+r,...n.slice(1)])}catch(e){f.error(`proxyConsole failed: ${e}`)}}}function R(e,o,t){u=o,m=e,f={...o};const n=`${t}/console`.replace("https://","wss://").replace("http://","ws://");d=new WebSocket(n),d.addEventListener("error",x),d.addEventListener("close",A),function(){for(const e of l)u[e]=E(`console.${e}`,T,!0)}()}function j(e){let o=30;const t=()=>{d?0==d.bufferedAmount||0==o?(e&&y(e),function(){for(const e of l)u[e]=E(`console.${e}`,f.log,!1)}(),d.removeEventListener("error",x),d.removeEventListener("close",A),d.close(1e3,e),d=void 0):(o--,globalThis.setTimeout(t,100)):e&&f&&f.log(e)};t()}function T(e){d&&d.readyState===WebSocket.OPEN?d.send(e):f.log(e)}function x(e){f.error(`[${m}] proxy console websocket error: ${e}`,e)}function A(e){f.debug(`[${m}] proxy console websocket closed: ${e}`,e)}function D(){Pe.preferredIcuAsset=S(Pe.config);let e="invariant"==Pe.config.globalizationMode;if(!e)if(Pe.preferredIcuAsset)Pe.diagnosticTracing&&b("ICU data archive(s) available, disabling invariant mode");else{if("custom"===Pe.config.globalizationMode||"all"===Pe.config.globalizationMode||"sharded"===Pe.config.globalizationMode){const e="invariant globalization mode is inactive and no ICU data archives are available";throw _(`ERROR: ${e}`),new Error(e)}Pe.diagnosticTracing&&b("ICU data archive(s) not available, using invariant globalization mode"),e=!0,Pe.preferredIcuAsset=null}const o="DOTNET_SYSTEM_GLOBALIZATION_INVARIANT",t=Pe.config.environmentVariables;if(void 0===t[o]&&e&&(t[o]="1"),void 0===t.TZ)try{const e=Intl.DateTimeFormat().resolvedOptions().timeZone||null;e&&(t.TZ=e)}catch(e){w("failed to detect timezone, will fallback to UTC")}}function S(e){var o;if((null===(o=e.resources)||void 0===o?void 0:o.icu)&&"invariant"!=e.globalizationMode){const o=e.applicationCulture||(ke?globalThis.navigator&&globalThis.navigator.languages&&globalThis.navigator.languages[0]:Intl.DateTimeFormat().resolvedOptions().locale);e.applicationCulture||(e.applicationCulture=o);const t=e.resources.icu;let n=null;if("custom"===e.globalizationMode){if(t.length>=1)return t[0].name}else o&&"all"!==e.globalizationMode?"sharded"===e.globalizationMode&&(n=function(e){const o=e.split("-")[0];return"en"===o||["fr","fr-FR","it","it-IT","de","de-DE","es","es-ES"].includes(e)?"icudt_EFIGS.dat":["zh","ko","ja"].includes(o)?"icudt_CJK.dat":"icudt_no_CJK.dat"}(o)):n="icudt.dat";if(n)for(let e=0;e<t.length;e++){const o=t[e];if(o.virtualPath===n)return o.name}}return e.globalizationMode="invariant",null}(new Date).valueOf();const M=class{constructor(e){this.url=e}toString(){return this.url}};async function k(e,o){try{const t="function"==typeof globalThis.fetch;if(Ae){const n=e.startsWith("file://");if(!n&&t)return globalThis.fetch(e,o||{credentials:"same-origin"});g||(p=await import(/*! webpackIgnore: true */"url"),g=await import(/*! webpackIgnore: true */"fs")),n&&(e=p.fileURLToPath(e));const r=await g.promises.readFile(e);return{ok:!0,headers:{length:0,get:()=>null},url:e,arrayBuffer:()=>r,json:()=>JSON.parse(r),text:()=>{throw new Error("NotImplementedException")}}}if(t)return globalThis.fetch(e,o||{credentials:"same-origin"});if("function"==typeof read)return{ok:!0,url:e,headers:{length:0,get:()=>null},arrayBuffer:()=>new Uint8Array(read(e,"binary")),json:()=>JSON.parse(read(e,"utf8")),text:()=>read(e,"utf8")}}catch(o){return{ok:!1,url:e,status:500,headers:{length:0,get:()=>null},statusText:"ERR28: "+o,arrayBuffer:()=>{throw o},json:()=>{throw o},text:()=>{throw o}}}throw new Error("No fetch implementation available")}function C(e){return"string"!=typeof e&&Be(!1,"url must be a string"),!P(e)&&0!==e.indexOf("./")&&0!==e.indexOf("../")&&globalThis.URL&&globalThis.document&&globalThis.document.baseURI&&(e=new URL(e,globalThis.document.baseURI).toString()),e}const I=/^[a-zA-Z][a-zA-Z\d+\-.]*?:\/\//,O=/[a-zA-Z]:[\\/]/;function P(e){return Ae||Ce?e.startsWith("/")||e.startsWith("\\")||-1!==e.indexOf("///")||O.test(e):I.test(e)}let U,L=0;const N=[],$=[],z=new Map,W={"js-module-threads":!0,"js-module-runtime":!0,"js-module-dotnet":!0,"js-module-native":!0,"js-module-diagnostics":!0},F={...W,"js-module-library-initializer":!0},B={...W,dotnetwasm:!0,heap:!0,manifest:!0},V={...F,manifest:!0},H={...F,dotnetwasm:!0},J={dotnetwasm:!0,symbols:!0},q={...F,dotnetwasm:!0,symbols:!0},Q={symbols:!0};function G(e){return!("icu"==e.behavior&&e.name!=Pe.preferredIcuAsset)}function Z(e,o,t){null!=o||(o=[]),Be(1==o.length,`Expect to have one ${t} asset in resources`);const n=o[0];return n.behavior=t,K(n),e.push(n),n}function K(e){B[e.behavior]&&z.set(e.behavior,e)}function X(e){Be(B[e],`Unknown single asset behavior ${e}`);const o=z.get(e);if(o&&!o.resolvedUrl)if(o.resolvedUrl=Pe.locateFile(o.name),W[o.behavior]){const e=me(o);e?("string"!=typeof e&&Be(!1,"loadBootResource response for 'dotnetjs' type should be a URL string"),o.resolvedUrl=e):o.resolvedUrl=le(o.resolvedUrl,o.behavior)}else if("dotnetwasm"!==o.behavior)throw new Error(`Unknown single asset behavior ${e}`);return o}function Y(e){const o=X(e);return Be(o,`Single asset for ${e} not found`),o}let ee=!1;async function oe(){if(!ee){ee=!0,Pe.diagnosticTracing&&b("mono_download_assets");try{const e=[],o=[],t=(e,o)=>{!q[e.behavior]&&G(e)&&Pe.expected_instantiated_assets_count++,!H[e.behavior]&&G(e)&&(Pe.expected_downloaded_assets_count++,o.push(ie(e)))};for(const o of N)t(o,e);for(const e of $)t(e,o);Pe.allDownloadsQueued.promise_control.resolve(),Promise.all([...e,...o]).then(()=>{Pe.allDownloadsFinished.promise_control.resolve()}).catch(e=>{throw Pe.err("Error in mono_download_assets: "+e),Xe(1,e),e}),await Pe.runtimeModuleLoaded.promise;const n=async e=>{const o=await e;if(o.buffer){if(!q[o.behavior]){o.buffer&&"object"==typeof o.buffer||Be(!1,"asset buffer must be array-like or buffer-like or promise of these"),"string"!=typeof o.resolvedUrl&&Be(!1,"resolvedUrl must be string");const e=o.resolvedUrl,t=await o.buffer,n=new Uint8Array(t);ge(o),await Oe.beforeOnRuntimeInitialized.promise,await Oe.afterInstantiateWasm.promise,Oe.instantiate_asset(o,e,n)}}else J[o.behavior]?("symbols"===o.behavior&&(await Oe.instantiate_symbols_asset(o),ge(o)),J[o.behavior]&&++Pe.actual_downloaded_assets_count):(o.isOptional||Be(!1,"Expected asset to have the downloaded buffer"),!H[o.behavior]&&G(o)&&Pe.expected_downloaded_assets_count--,!q[o.behavior]&&G(o)&&Pe.expected_instantiated_assets_count--)},r=[],i=[];for(const o of e)r.push(n(o));for(const e of o)i.push(n(e));Promise.all(r).then(()=>{Me||Oe.coreAssetsInMemory.promise_control.resolve()}).catch(e=>{throw Pe.err("Error in mono_download_assets: "+e),Xe(1,e),e}),Promise.all(i).then(async()=>{Me||(await Oe.coreAssetsInMemory.promise,Oe.allAssetsInMemory.promise_control.resolve())}).catch(e=>{throw Pe.err("Error in mono_download_assets: "+e),Xe(1,e),e})}catch(e){throw Pe.err("Error in mono_download_assets: "+e),e}}}let te=!1;function ne(){if(te)return;te=!0;const e=Pe.config,o=[];if(e.assets)for(const o of e.assets)"object"!=typeof o&&Be(!1,`asset must be object, it was ${typeof o} : ${o}`),"string"!=typeof o.behavior&&Be(!1,"asset behavior must be known string"),"string"!=typeof o.name&&Be(!1,"asset name must be string"),o.resolvedUrl&&"string"!=typeof o.resolvedUrl&&Be(!1,"asset resolvedUrl could be string"),o.hash&&"string"!=typeof o.hash&&Be(!1,"asset resolvedUrl could be string"),o.pendingDownload&&"object"!=typeof o.pendingDownload&&Be(!1,"asset pendingDownload could be object"),o.isCore?N.push(o):$.push(o),K(o);else if(e.resources){const t=e.resources;t.wasmNative||Be(!1,"resources.wasmNative must be defined"),t.jsModuleNative||Be(!1,"resources.jsModuleNative must be defined"),t.jsModuleRuntime||Be(!1,"resources.jsModuleRuntime must be defined"),Z($,t.wasmNative,"dotnetwasm"),Z(o,t.jsModuleNative,"js-module-native"),Z(o,t.jsModuleRuntime,"js-module-runtime"),t.jsModuleDiagnostics&&Z(o,t.jsModuleDiagnostics,"js-module-diagnostics");const n=(e,o,t)=>{const n=e;n.behavior=o,t?(n.isCore=!0,N.push(n)):$.push(n)};if(t.coreAssembly)for(let e=0;e<t.coreAssembly.length;e++)n(t.coreAssembly[e],"assembly",!0);if(t.assembly)for(let e=0;e<t.assembly.length;e++)n(t.assembly[e],"assembly",!t.coreAssembly);if(0!=e.debugLevel&&Pe.isDebuggingSupported()){if(t.corePdb)for(let e=0;e<t.corePdb.length;e++)n(t.corePdb[e],"pdb",!0);if(t.pdb)for(let e=0;e<t.pdb.length;e++)n(t.pdb[e],"pdb",!t.corePdb)}if(e.loadAllSatelliteResources&&t.satelliteResources)for(const e in t.satelliteResources)for(let o=0;o<t.satelliteResources[e].length;o++){const r=t.satelliteResources[e][o];r.culture=e,n(r,"resource",!t.coreAssembly)}if(t.coreVfs)for(let e=0;e<t.coreVfs.length;e++)n(t.coreVfs[e],"vfs",!0);if(t.vfs)for(let e=0;e<t.vfs.length;e++)n(t.vfs[e],"vfs",!t.coreVfs);const r=S(e);if(r&&t.icu)for(let e=0;e<t.icu.length;e++){const o=t.icu[e];o.name===r&&n(o,"icu",!1)}if(t.wasmSymbols)for(let e=0;e<t.wasmSymbols.length;e++)n(t.wasmSymbols[e],"symbols",!1)}if(e.appsettings)for(let o=0;o<e.appsettings.length;o++){const t=e.appsettings[o],n=pe(t);"appsettings.json"!==n&&n!==`appsettings.${e.applicationEnvironment}.json`||$.push({name:t,behavior:"vfs",cache:"no-cache",useCredentials:!0})}e.assets=[...N,...$,...o]}async function re(e){const o=await ie(e);return await o.pendingDownloadInternal.response,o.buffer}async function ie(e){try{return await se(e)}catch(o){if(!Pe.enableDownloadRetry)throw o;if(Ce||Ae)throw o;if(e.pendingDownload&&e.pendingDownloadInternal==e.pendingDownload)throw o;if(e.resolvedUrl&&-1!=e.resolvedUrl.indexOf("file://"))throw o;if(o&&404==o.status)throw o;e.pendingDownloadInternal=void 0,await Pe.allDownloadsQueued.promise;try{return Pe.diagnosticTracing&&b(`Retrying download '${e.name}'`),await se(e)}catch(o){return e.pendingDownloadInternal=void 0,await new Promise(e=>globalThis.setTimeout(e,100)),Pe.diagnosticTracing&&b(`Retrying download (2) '${e.name}' after delay`),await se(e)}}}async function se(e){for(;U;)await U.promise;try{++L,L==Pe.maxParallelDownloads&&(Pe.diagnosticTracing&&b("Throttling further parallel downloads"),U=r());const o=await async function(e){if(e.pendingDownload&&(e.pendingDownloadInternal=e.pendingDownload),e.pendingDownloadInternal&&e.pendingDownloadInternal.response)return e.pendingDownloadInternal.response;if(e.buffer){const o=await e.buffer;return e.resolvedUrl||(e.resolvedUrl="undefined://"+e.name),e.pendingDownloadInternal={url:e.resolvedUrl,name:e.name,response:Promise.resolve({ok:!0,arrayBuffer:()=>o,json:()=>JSON.parse(new TextDecoder("utf-8").decode(o)),text:()=>{throw new Error("NotImplementedException")},headers:{get:()=>{}}})},e.pendingDownloadInternal.response}const o=e.loadRemote&&Pe.config.remoteSources?Pe.config.remoteSources:[""];let t;for(let n of o){n=n.trim(),"./"===n&&(n="");const o=ae(e,n);e.name===o?Pe.diagnosticTracing&&b(`Attempting to download '${o}'`):Pe.diagnosticTracing&&b(`Attempting to download '${o}' for ${e.name}`);try{e.resolvedUrl=o;const n=ue(e);if(e.pendingDownloadInternal=n,t=await n.response,!t||!t.ok)continue;return t}catch(e){t||(t={ok:!1,url:o,status:0,statusText:""+e});continue}}const n=e.isOptional||e.name.match(/\.pdb$/)&&Pe.config.ignorePdbLoadErrors;if(t||Be(!1,`Response undefined ${e.name}`),!n){const o=new Error(`download '${t.url}' for ${e.name} failed ${t.status} ${t.statusText}`);throw o.status=t.status,o}w(`optional download '${t.url}' for ${e.name} failed ${t.status} ${t.statusText}`)}(e);return o?(J[e.behavior]||(e.buffer=await o.arrayBuffer(),++Pe.actual_downloaded_assets_count),e):e}finally{if(--L,U&&L==Pe.maxParallelDownloads-1){Pe.diagnosticTracing&&b("Resuming more parallel downloads");const e=U;U=void 0,e.promise_control.resolve()}}}function ae(e,o){let t;return null==o&&Be(!1,`sourcePrefix must be provided for ${e.name}`),e.resolvedUrl?t=e.resolvedUrl:(t=""===o?"assembly"===e.behavior||"pdb"===e.behavior?e.name:"resource"===e.behavior&&e.culture&&""!==e.culture?`${e.culture}/${e.name}`:e.name:o+e.name,t=le(Pe.locateFile(t),e.behavior)),t&&"string"==typeof t||Be(!1,"attemptUrl need to be path or url string"),t}function le(e,o){return Pe.modulesUniqueQuery&&V[o]&&(e+=Pe.modulesUniqueQuery),e}let ce=0;const de=new Set;function ue(e){try{e.resolvedUrl||Be(!1,"Request's resolvedUrl must be set");const o=function(e){let o=e.resolvedUrl;if(Pe.loadBootResource){const t=me(e);if(t instanceof Promise)return t;"string"==typeof t&&(o=t)}const t={};return e.cache?t.cache=e.cache:Pe.config.disableNoCacheFetch||(t.cache="no-cache"),e.useCredentials?t.credentials="include":!Pe.config.disableIntegrityCheck&&e.hash&&(t.integrity=e.hash),Pe.fetch_like(o,t)}(e),t={name:e.name,url:e.resolvedUrl,response:o};return de.add(e.name),t.response.then(()=>{"assembly"==e.behavior&&Pe.loadedAssemblies.push(e.name),ce++,Pe.onDownloadResourceProgress&&Pe.onDownloadResourceProgress(ce,de.size)}),t}catch(o){const t={ok:!1,url:e.resolvedUrl,status:500,statusText:"ERR29: "+o,arrayBuffer:()=>{throw o},json:()=>{throw o}};return{name:e.name,url:e.resolvedUrl,response:Promise.resolve(t)}}}const fe={resource:"assembly",assembly:"assembly",pdb:"pdb",icu:"globalization",vfs:"configuration",manifest:"manifest",dotnetwasm:"dotnetwasm","js-module-dotnet":"dotnetjs","js-module-native":"dotnetjs","js-module-runtime":"dotnetjs","js-module-threads":"dotnetjs"};function me(e){var o;if(Pe.loadBootResource){const t=null!==(o=e.hash)&&void 0!==o?o:"",n=e.resolvedUrl,r=fe[e.behavior];if(r){const o=Pe.loadBootResource(r,e.name,n,t,e.behavior);return"string"==typeof o?C(o):o}}}function ge(e){e.pendingDownloadInternal=null,e.pendingDownload=null,e.buffer=null,e.moduleExports=null}function pe(e){let o=e.lastIndexOf("/");return o>=0&&o++,e.substring(o)}async function he(e){e&&await Promise.all((null!=e?e:[]).map(e=>async function(e){try{const o=e.name;if(!e.moduleExports){const t=le(Pe.locateFile(o),"js-module-library-initializer");Pe.diagnosticTracing&&b(`Attempting to import '${t}' for ${e}`),e.moduleExports=await import(/*! webpackIgnore: true */t)}Pe.libraryInitializers.push({scriptName:o,exports:e.moduleExports})}catch(o){v(`Failed to import library initializer '${e}': ${o}`)}}(e)))}async function be(e,o){if(!Pe.libraryInitializers)return;const t=[];for(let n=0;n<Pe.libraryInitializers.length;n++){const r=Pe.libraryInitializers[n];r.exports[e]&&t.push(we(r.scriptName,e,()=>r.exports[e](...o)))}await Promise.all(t)}async function we(e,o,t){try{await t()}catch(t){throw v(`Failed to invoke '${o}' on library initializer '${e}': ${t}`),Xe(1,t),t}}function ye(e,o){if(e===o)return e;const t={...o};return void 0!==t.assets&&t.assets!==e.assets&&(t.assets=[...e.assets||[],...t.assets||[]]),void 0!==t.resources&&(t.resources=_e(e.resources||{assembly:[],jsModuleNative:[],jsModuleRuntime:[],wasmNative:[]},t.resources)),void 0!==t.environmentVariables&&(t.environmentVariables={...e.environmentVariables||{},...t.environmentVariables||{}}),void 0!==t.runtimeOptions&&t.runtimeOptions!==e.runtimeOptions&&(t.runtimeOptions=[...e.runtimeOptions||[],...t.runtimeOptions||[]]),Object.assign(e,t)}function ve(e,o){if(e===o)return e;const t={...o};return t.config&&(e.config||(e.config={}),t.config=ye(e.config,t.config)),Object.assign(e,t)}function _e(e,o){if(e===o)return e;const t={...o};return void 0!==t.coreAssembly&&(t.coreAssembly=[...e.coreAssembly||[],...t.coreAssembly||[]]),void 0!==t.assembly&&(t.assembly=[...e.assembly||[],...t.assembly||[]]),void 0!==t.lazyAssembly&&(t.lazyAssembly=[...e.lazyAssembly||[],...t.lazyAssembly||[]]),void 0!==t.corePdb&&(t.corePdb=[...e.corePdb||[],...t.corePdb||[]]),void 0!==t.pdb&&(t.pdb=[...e.pdb||[],...t.pdb||[]]),void 0!==t.jsModuleWorker&&(t.jsModuleWorker=[...e.jsModuleWorker||[],...t.jsModuleWorker||[]]),void 0!==t.jsModuleNative&&(t.jsModuleNative=[...e.jsModuleNative||[],...t.jsModuleNative||[]]),void 0!==t.jsModuleDiagnostics&&(t.jsModuleDiagnostics=[...e.jsModuleDiagnostics||[],...t.jsModuleDiagnostics||[]]),void 0!==t.jsModuleRuntime&&(t.jsModuleRuntime=[...e.jsModuleRuntime||[],...t.jsModuleRuntime||[]]),void 0!==t.wasmSymbols&&(t.wasmSymbols=[...e.wasmSymbols||[],...t.wasmSymbols||[]]),void 0!==t.wasmNative&&(t.wasmNative=[...e.wasmNative||[],...t.wasmNative||[]]),void 0!==t.icu&&(t.icu=[...e.icu||[],...t.icu||[]]),void 0!==t.satelliteResources&&(t.satelliteResources=function(e,o){if(e===o)return e;for(const t in o)e[t]=[...e[t]||[],...o[t]||[]];return e}(e.satelliteResources||{},t.satelliteResources||{})),void 0!==t.modulesAfterConfigLoaded&&(t.modulesAfterConfigLoaded=[...e.modulesAfterConfigLoaded||[],...t.modulesAfterConfigLoaded||[]]),void 0!==t.modulesAfterRuntimeReady&&(t.modulesAfterRuntimeReady=[...e.modulesAfterRuntimeReady||[],...t.modulesAfterRuntimeReady||[]]),void 0!==t.extensions&&(t.extensions={...e.extensions||{},...t.extensions||{}}),void 0!==t.vfs&&(t.vfs=[...e.vfs||[],...t.vfs||[]]),Object.assign(e,t)}function Ee(){const e=Pe.config;if(e.environmentVariables=e.environmentVariables||{},e.runtimeOptions=e.runtimeOptions||[],e.resources=e.resources||{assembly:[],jsModuleNative:[],jsModuleWorker:[],jsModuleRuntime:[],wasmNative:[],vfs:[],satelliteResources:{}},e.assets){Pe.diagnosticTracing&&b("config.assets is deprecated, use config.resources instead");for(const o of e.assets){const t={};switch(o.behavior){case"assembly":t.assembly=[o];break;case"pdb":t.pdb=[o];break;case"resource":t.satelliteResources={},t.satelliteResources[o.culture]=[o];break;case"icu":t.icu=[o];break;case"symbols":t.wasmSymbols=[o];break;case"vfs":t.vfs=[o];break;case"dotnetwasm":t.wasmNative=[o];break;case"js-module-threads":t.jsModuleWorker=[o];break;case"js-module-runtime":t.jsModuleRuntime=[o];break;case"js-module-native":t.jsModuleNative=[o];break;case"js-module-diagnostics":t.jsModuleDiagnostics=[o];break;case"js-module-dotnet":break;default:throw new Error(`Unexpected behavior ${o.behavior} of asset ${o.name}`)}_e(e.resources,t)}}e.debugLevel,void 0===e.virtualWorkingDirectory&&(e.virtualWorkingDirectory=Ie),e.applicationEnvironment||(e.applicationEnvironment="Production"),e.applicationCulture&&(e.environmentVariables.LANG=`${e.applicationCulture}.UTF-8`),Oe.diagnosticTracing=Pe.diagnosticTracing=!!e.diagnosticTracing,Oe.waitForDebugger=e.waitForDebugger,Pe.maxParallelDownloads=e.maxParallelDownloads||Pe.maxParallelDownloads,Pe.enableDownloadRetry=void 0!==e.enableDownloadRetry?e.enableDownloadRetry:Pe.enableDownloadRetry}let Re=!1;async function je(e){var o;if(Re)return void await Pe.afterConfigLoaded.promise;let t;try{if(e.configSrc||Pe.config&&0!==Object.keys(Pe.config).length&&(Pe.config.assets||Pe.config.resources)||(e.configSrc="dotnet.boot.js"),t=e.configSrc,Re=!0,t&&(Pe.diagnosticTracing&&b("mono_wasm_load_config"),await async function(e){const o=e.configSrc,t=Pe.locateFile(o);let n=null;void 0!==Pe.loadBootResource&&(n=Pe.loadBootResource("manifest",o,t,"","manifest"));let r,i=null;if(n)if("string"==typeof n)n.includes(".json")?(i=await s(C(n)),r=await xe(i)):r=(await import(C(n))).config;else{const e=await n;"function"==typeof e.json?(i=e,r=await xe(i)):r=e.config}else t.includes(".json")?(i=await s(le(t,"manifest")),r=await xe(i)):r=(await import(le(t,"manifest"))).config;function s(e){return Pe.fetch_like(e,{method:"GET",credentials:"include",cache:"no-cache"})}Pe.config.applicationEnvironment&&(r.applicationEnvironment=Pe.config.applicationEnvironment),ye(Pe.config,r)}(e)),Ee(),await he(null===(o=Pe.config.resources)||void 0===o?void 0:o.modulesAfterConfigLoaded),await be("onRuntimeConfigLoaded",[Pe.config]),e.onConfigLoaded)try{await e.onConfigLoaded(Pe.config,Le),Ee()}catch(e){throw _("onConfigLoaded() failed",e),e}Ee(),Pe.afterConfigLoaded.promise_control.resolve(Pe.config)}catch(o){const n=`Failed to load config file ${t} ${o} ${null==o?void 0:o.stack}`;throw Pe.config=e.config=Object.assign(Pe.config,{message:n,error:o,isError:!0}),Xe(1,new Error(n)),o}}function Te(){return!!globalThis.navigator&&(Pe.isChromium||Pe.isFirefox)}async function xe(e){const o=Pe.config,t=await e.json();o.applicationEnvironment||t.applicationEnvironment||(t.applicationEnvironment=e.headers.get("Blazor-Environment")||e.headers.get("DotNet-Environment")||void 0),t.environmentVariables||(t.environmentVariables={});const n=e.headers.get("DOTNET-MODIFIABLE-ASSEMBLIES");n&&(t.environmentVariables.DOTNET_MODIFIABLE_ASSEMBLIES=n);const r=e.headers.get("ASPNETCORE-BROWSER-TOOLS");return r&&(t.environmentVariables.__ASPNETCORE_BROWSER_TOOLS=r),t}"function"==typeof importScripts&&(globalThis.dotnetSidecar=!0);const Ae="object"==typeof process&&"object"==typeof process.versions&&"string"==typeof process.versions.node,De="function"==typeof importScripts,Se=De&&"undefined"!=typeof dotnetSidecar,Me=De&&!Se,ke="object"==typeof window||De&&!Ae,Ce=!ke&&!Ae,Ie="/";let Oe={},Pe={},Ue={},Le={},Ne={},$e=!1;const ze={},We={config:ze},Fe={mono:{},binding:{},internal:Ne,module:We,loaderHelpers:Pe,runtimeHelpers:Oe,diagnosticHelpers:Ue,api:Le};function Be(e,o){if(e)return;const t="Assert failed: "+("function"==typeof o?o():o),n=new Error(t);_(t,n),Oe.nativeAbort(n)}function Ve(){return void 0!==Pe.exitCode}function He(){return Oe.runtimeReady&&!Ve()}function Je(){Ve()&&Be(!1,`.NET runtime already exited with ${Pe.exitCode} ${Pe.exitReason}. You can use dotnet.runMain() which doesn't exit the runtime.`),Oe.runtimeReady||Be(!1,".NET runtime didn't start yet. Please call dotnet.create() first.")}function qe(){ke&&(globalThis.addEventListener("unhandledrejection",eo),globalThis.addEventListener("error",oo))}let Qe,Ge;function Ze(e){Ge&&Ge(e),Xe(e,Pe.exitReason)}function Ke(e){Qe&&Qe(e||Pe.exitReason),Xe(1,e||Pe.exitReason)}function Xe(e,o){var t;const n=o&&"object"==typeof o;e=n&&"number"==typeof o.status?o.status:void 0===e?-1:e;const r=n&&"string"==typeof o.message?o.message:""+o;(o=n?o:Oe.ExitStatus?function(e,o){const t=new Oe.ExitStatus(e);return t.message=o,t.toString=()=>o,t}(e,r):new Error("Exit with code "+e+" "+r)).status=e,o.message||(o.message=r);const i=""+(o.stack||(new Error).stack);try{Object.defineProperty(o,"stack",{get:()=>i})}catch(e){}const s=!!o.silent;if(o.silent=!0,Ve())Pe.diagnosticTracing&&b("mono_exit called after exit");else{try{We.onAbort==Ke&&(We.onAbort=Qe),We.onExit==Ze&&(We.onExit=Ge),ke&&(globalThis.removeEventListener("unhandledrejection",eo),globalThis.removeEventListener("error",oo)),Oe.runtimeReady?(Oe.jiterpreter_dump_stats&&Oe.jiterpreter_dump_stats(!1),0===e&&(null===(t=Pe.config)||void 0===t?void 0:t.interopCleanupOnExit)&&Oe.forceDisposeProxies(!0,!0)):(Pe.diagnosticTracing&&b(`abort_startup, reason: ${o}`),function(e){Pe.allDownloadsQueued.promise_control.reject(e),Pe.allDownloadsFinished.promise_control.reject(e),Pe.afterConfigLoaded.promise_control.reject(e),Pe.wasmCompilePromise.promise_control.reject(e),Pe.runtimeModuleLoaded.promise_control.reject(e),Oe.dotnetReady&&(Oe.dotnetReady.promise_control.reject(e),Oe.afterInstantiateWasm.promise_control.reject(e),Oe.afterPreRun.promise_control.reject(e),Oe.beforeOnRuntimeInitialized.promise_control.reject(e),Oe.afterOnRuntimeInitialized.promise_control.reject(e),Oe.afterPostRun.promise_control.reject(e))}(o))}catch(e){v("mono_exit A failed",e)}try{s||(function(e,o){if(0!==e&&o){const e=Oe.ExitStatus&&o instanceof Oe.ExitStatus?b:_;"string"==typeof o?e(o):(void 0===o.stack&&(o.stack=(new Error).stack+""),o.message?e(Oe.stringify_as_error_with_stack?Oe.stringify_as_error_with_stack(o.message+"\n"+o.stack):o.message+"\n"+o.stack):e(JSON.stringify(o)))}!Me&&Pe.config&&(Pe.config.logExitCode?Pe.config.forwardConsole?j("WASM EXIT "+e):y("WASM EXIT "+e):Pe.config.forwardConsole&&j())}(e,o),function(e){if(ke&&!Me&&Pe.config&&Pe.config.appendElementOnExit&&document){const o=document.createElement("label");o.id="tests_done",0!==e&&(o.style.background="red"),o.innerHTML=""+e,document.body.appendChild(o)}}(e))}catch(e){v("mono_exit B failed",e)}Pe.exitCode=e,Pe.exitReason||(Pe.exitReason=o),!Me&&Oe.runtimeReady&&We.runtimeKeepalivePop()}if(Pe.config&&Pe.config.asyncFlushOnExit&&0===e)throw(async()=>{try{await async function(){try{const e=await import(/*! webpackIgnore: true */"process"),o=e=>new Promise((o,t)=>{e.on("error",t),e.end("","utf8",o)}),t=o(e.stderr),n=o(e.stdout);let r;const i=new Promise(e=>{r=setTimeout(()=>e("timeout"),1e3)});await Promise.race([Promise.all([n,t]),i]),clearTimeout(r)}catch(e){_(`flushing std* streams failed: ${e}`)}}()}finally{Ye(e,o)}})(),o;Ye(e,o)}function Ye(e,o){if(Oe.runtimeReady&&Oe.nativeExit)try{Oe.nativeExit(e)}catch(e){!Oe.ExitStatus||e instanceof Oe.ExitStatus||v("set_exit_code_and_quit_now failed: "+e.toString())}if(0!==e||!ke)throw Ae?process.exit(e):Oe.quit&&Oe.quit(e,o),o}function eo(e){to(e,e.reason,"rejection")}function oo(e){to(e,e.error,"error")}function to(e,o,t){e.preventDefault();try{o||(o=new Error("Unhandled "+t)),void 0===o.stack&&(o.stack=(new Error).stack),o.stack=o.stack+"",o.silent||(_("Unhandled error:",o),Xe(1,o))}catch(e){}}!function(n){if($e)throw new Error("Loader module already loaded");$e=!0,Oe=n.runtimeHelpers,Pe=n.loaderHelpers,Ue=n.diagnosticHelpers,Le=n.api,Ne=n.internal,Object.assign(Le,{INTERNAL:Ne,invokeLibraryInitializers:be}),Object.assign(n.module,{config:ye(ze,{environmentVariables:{}})});const a={mono_wasm_bindings_is_ready:!1,config:n.module.config,diagnosticTracing:!1,nativeAbort:e=>{throw e||new Error("abort")},nativeExit:e=>{throw new Error("exit:"+e)}},l={gitHash:"a8b33e7593686eaee701cd124daaabff2311634f",config:n.module.config,diagnosticTracing:!1,maxParallelDownloads:16,enableDownloadRetry:!0,_loaded_files:[],loadedFiles:[],loadedAssemblies:[],libraryInitializers:[],workerNextNumber:1,actual_downloaded_assets_count:0,actual_instantiated_assets_count:0,expected_downloaded_assets_count:0,expected_instantiated_assets_count:0,afterConfigLoaded:r(),allDownloadsQueued:r(),allDownloadsFinished:r(),wasmCompilePromise:r(),runtimeModuleLoaded:r(),loadingWorkers:r(),is_exited:Ve,is_runtime_running:He,assert_runtime_running:Je,mono_exit:Xe,createPromiseController:r,getPromiseController:i,assertIsControllablePromise:s,mono_download_assets:oe,resolve_single_asset_path:Y,setup_proxy_console:R,set_thread_prefix:h,installUnhandledErrorHandler:qe,retrieve_asset_download:re,invokeLibraryInitializers:be,isDebuggingSupported:Te,exceptions:e,simd:t,relaxedSimd:o};Object.assign(Oe,a),Object.assign(Pe,l)}(Fe);let no,ro,io,so=!1,ao=!1;async function lo(e){if(!ao){if(ao=!0,ke&&Pe.config.forwardConsole&&void 0!==globalThis.WebSocket&&R("main",globalThis.console,globalThis.location.origin),We||Be(!1,"Null moduleConfig"),Pe.config||Be(!1,"Null moduleConfig.config"),"function"==typeof e){const o=e(Fe.api);if(o.ready)throw new Error("Module.ready couldn't be redefined.");Object.assign(We,o),ve(We,o)}else{if("object"!=typeof e)throw new Error("Can't use moduleFactory callback of createDotnetRuntime function.");ve(We,e)}await async function(e){if(Ae){const e=await import(/*! webpackIgnore: true */"process"),o=14;if(e.versions.node.split(".")[0]<o)throw new Error(`NodeJS at '${e.execPath}' has too low version '${e.versions.node}', please use at least ${o}.`)}const o=/*! webpackIgnore: true */import.meta.url,t=o.indexOf("?");var n;if(t>0&&(Pe.modulesUniqueQuery=o.substring(t)),Pe.scriptUrl=o.replace(/\\/g,"/").replace(/[?#].*/,""),Pe.scriptDirectory=(n=Pe.scriptUrl).slice(0,n.lastIndexOf("/"))+"/",Pe.locateFile=e=>"URL"in globalThis&&globalThis.URL!==M?new URL(e,Pe.scriptDirectory).toString():P(e)?e:Pe.scriptDirectory+e,Pe.fetch_like=k,Pe.out=console.log,Pe.err=console.error,Pe.onDownloadResourceProgress=e.onDownloadResourceProgress,ke&&globalThis.navigator){const e=globalThis.navigator,o=e.userAgentData&&e.userAgentData.brands;o&&o.length>0?Pe.isChromium=o.some(e=>"Google Chrome"===e.brand||"Microsoft Edge"===e.brand||"Chromium"===e.brand):e.userAgent&&(Pe.isChromium=e.userAgent.includes("Chrome"),Pe.isFirefox=e.userAgent.includes("Firefox"))}void 0===globalThis.URL&&(globalThis.URL=M)}(We)}}async function co(e){return await lo(e),Pe.config.exitOnUnhandledError&&qe(),Qe=We.onAbort,Ge=We.onExit,We.onAbort=Ke,We.onExit=Ze,We.ENVIRONMENT_IS_PTHREAD?async function(){(function(){const e=new MessageChannel,o=e.port1,t=e.port2;o.addEventListener("message",e=>{var n,r;n=JSON.parse(e.data.config),r=JSON.parse(e.data.monoThreadInfo),so?Pe.diagnosticTracing&&b("mono config already received"):(ye(Pe.config,n),Oe.monoThreadInfo=r,Ee(),Pe.diagnosticTracing&&b("mono config received"),so=!0,Pe.afterConfigLoaded.promise_control.resolve(Pe.config),ke&&n.forwardConsole&&void 0!==globalThis.WebSocket&&Pe.setup_proxy_console("worker-idle",console,globalThis.location.origin)),o.close(),t.close()},{once:!0}),o.start(),self.postMessage({[a]:{monoCmd:"preload",port:t}},[t])})(),await Pe.afterConfigLoaded.promise,function(){const e=Pe.config;e.assets||Be(!1,"config.assets must be defined");for(const o of e.assets)K(o),Q[o.behavior]&&$.push(o)}(),setTimeout(async()=>{try{await oe()}catch(e){Xe(1,e)}},0);const e=uo(),o=await Promise.all(e);return await fo(o),We}():async function(){var e;await je(We),ne();const o=uo();(async function(){try{const e=Y("dotnetwasm");await ie(e),e&&e.pendingDownloadInternal&&e.pendingDownloadInternal.response||Be(!1,"Can't load dotnet.native.wasm");const o=await e.pendingDownloadInternal.response,t=o.headers&&o.headers.get?o.headers.get("Content-Type"):void 0;let n;if("function"==typeof WebAssembly.compileStreaming&&"application/wasm"===t)n=await WebAssembly.compileStreaming(o);else{ke&&"application/wasm"!==t&&v('WebAssembly resource does not have the expected content type "application/wasm", so falling back to slower ArrayBuffer instantiation.');const e=await o.arrayBuffer();Pe.diagnosticTracing&&b("instantiate_wasm_module buffered"),n=Ce?await Promise.resolve(new WebAssembly.Module(e)):await WebAssembly.compile(e)}e.pendingDownloadInternal=null,e.pendingDownload=null,e.buffer=null,e.moduleExports=null,Pe.wasmCompilePromise.promise_control.resolve(n)}catch(e){Pe.wasmCompilePromise.promise_control.reject(e)}})(),setTimeout(async()=>{try{D(),await oe()}catch(e){Xe(1,e)}},0);const t=await Promise.all(o);return await fo(t),await Oe.dotnetReady.promise,await he(null===(e=Pe.config.resources)||void 0===e?void 0:e.modulesAfterRuntimeReady),await be("onRuntimeReady",[Fe.api]),Le}()}function uo(){const e=Y("js-module-runtime"),o=Y("js-module-native");if(no&&ro)return[no,ro,io];"object"==typeof e.moduleExports?no=e.moduleExports:(Pe.diagnosticTracing&&b(`Attempting to import '${e.resolvedUrl}' for ${e.name}`),no=import(/*! webpackIgnore: true */e.resolvedUrl)),"object"==typeof o.moduleExports?ro=o.moduleExports:(Pe.diagnosticTracing&&b(`Attempting to import '${o.resolvedUrl}' for ${o.name}`),ro=import(/*! webpackIgnore: true */o.resolvedUrl));const t=X("js-module-diagnostics");return t&&("object"==typeof t.moduleExports?io=t.moduleExports:(Pe.diagnosticTracing&&b(`Attempting to import '${t.resolvedUrl}' for ${t.name}`),io=import(/*! webpackIgnore: true */t.resolvedUrl))),[no,ro,io]}async function fo(e){const{initializeExports:o,initializeReplacements:t,configureRuntimeStartup:n,configureEmscriptenStartup:r,configureWorkerStartup:i,setRuntimeGlobals:s,passEmscriptenInternals:a}=e[0],{default:l}=e[1],c=e[2];s(Fe),o(Fe),c&&c.setRuntimeGlobals(Fe),await n(We),Pe.runtimeModuleLoaded.promise_control.resolve(),l(()=>(Object.assign(We,{__dotnet_runtime:{initializeReplacements:t,configureEmscriptenStartup:r,configureWorkerStartup:i,passEmscriptenInternals:a}}),We)).catch(e=>{if(e.message&&e.message.toLowerCase().includes("out of memory"))throw new Error(".NET runtime has failed to start, because too much memory was requested. Please decrease the memory by adjusting EmccMaximumHeapSize.");throw e})}const mo=new class{withModuleConfig(e){try{return ve(We,e),this}catch(e){throw Xe(1,e),e}}withInterpreterPgo(e,o){try{return ye(ze,{interpreterPgo:e,interpreterPgoSaveDelay:o}),ze.runtimeOptions?ze.runtimeOptions.push("--interp-pgo-recording"):ze.runtimeOptions=["--interp-pgo-recording"],this}catch(e){throw Xe(1,e),e}}withConfig(e){try{return ye(ze,e),this}catch(e){throw Xe(1,e),e}}withConfigSrc(e){try{return e&&"string"==typeof e||Be(!1,"must be file path or URL"),ve(We,{configSrc:e}),this}catch(e){throw Xe(1,e),e}}withVirtualWorkingDirectory(e){try{return e&&"string"==typeof e||Be(!1,"must be directory path"),ye(ze,{virtualWorkingDirectory:e}),this}catch(e){throw Xe(1,e),e}}withEnvironmentVariable(e,o){try{const t={};return t[e]=o,ye(ze,{environmentVariables:t}),this}catch(e){throw Xe(1,e),e}}withEnvironmentVariables(e){try{return e&&"object"==typeof e||Be(!1,"must be dictionary object"),ye(ze,{environmentVariables:e}),this}catch(e){throw Xe(1,e),e}}withDiagnosticTracing(e){try{return"boolean"!=typeof e&&Be(!1,"must be boolean"),ye(ze,{diagnosticTracing:e}),this}catch(e){throw Xe(1,e),e}}withDebugging(e){try{return null!=e&&"number"==typeof e||Be(!1,"must be number"),ye(ze,{debugLevel:e}),this}catch(e){throw Xe(1,e),e}}withApplicationArguments(...e){try{return e&&Array.isArray(e)||Be(!1,"must be array of strings"),ye(ze,{applicationArguments:e}),this}catch(e){throw Xe(1,e),e}}withRuntimeOptions(e){try{return e&&Array.isArray(e)||Be(!1,"must be array of strings"),ze.runtimeOptions?ze.runtimeOptions.push(...e):ze.runtimeOptions=e,this}catch(e){throw Xe(1,e),e}}withMainAssembly(e){try{return ye(ze,{mainAssemblyName:e}),this}catch(e){throw Xe(1,e),e}}withApplicationArgumentsFromQuery(){try{if(!globalThis.window)throw new Error("Missing window to the query parameters from");if(void 0===globalThis.URLSearchParams)throw new Error("URLSearchParams is supported");const e=new URLSearchParams(globalThis.window.location.search).getAll("arg");return this.withApplicationArguments(...e)}catch(e){throw Xe(1,e),e}}withApplicationEnvironment(e){try{return ye(ze,{applicationEnvironment:e}),this}catch(e){throw Xe(1,e),e}}withApplicationCulture(e){try{return ye(ze,{applicationCulture:e}),this}catch(e){throw Xe(1,e),e}}withResourceLoader(e){try{return Pe.loadBootResource=e,this}catch(e){throw Xe(1,e),e}}async download(){try{await async function(){lo(We),await je(We),ne(),D(),oe(),await Pe.allDownloadsFinished.promise}()}catch(e){throw Xe(1,e),e}}async create(){try{return this.instance||(this.instance=await async function(){return await co(We),Fe.api}()),this.instance}catch(e){throw Xe(1,e),e}}run(){return this.runMainAndExit()}async runMainAndExit(){try{return We.config||Be(!1,"Null moduleConfig.config"),this.instance||await this.create(),this.instance.runMainAndExit()}catch(e){throw Xe(1,e),e}}async runMain(){try{return We.config||Be(!1,"Null moduleConfig.config"),this.instance||await this.create(),this.instance.runMain()}catch(e){throw Xe(1,e),e}}},go=Xe,po=co;Ce||"function"==typeof globalThis.URL||Be(!1,"This browser/engine doesn't support URL API. Please use a modern version."),"function"!=typeof globalThis.BigInt64Array&&Be(!1,"This browser/engine doesn't support BigInt64Array API. Please use a modern version. See also https://learn.microsoft.com/aspnet/core/blazor/supported-platforms"),globalThis.performance&&"function"==typeof globalThis.performance.now||Be(!1,"This browser/engine doesn't support performance.now. Please use a modern version."),Ce||globalThis.crypto&&"object"==typeof globalThis.crypto.subtle||Be(!1,"This engine doesn't support crypto.subtle. Please use a modern version."),Ce||globalThis.crypto&&"function"==typeof globalThis.crypto.getRandomValues||Be(!1,"This engine doesn't support crypto.getRandomValues. Please use a modern version."),Ae&&"function"!=typeof process.exit&&Be(!1,"This engine doesn't support process.exit. Please use a modern version."),mo.withConfig(/*json-start*/{
  "mainAssemblyName": "PrTask.Client",
  "applicationEnvironment": "Development",
  "resources": {
    "hash": "sha256-efU5HygNAkL1MKVsIP4zfbUvJ+Yzt6VbNNdKGGB3fpM=",
    "jsModuleNative": [
      {
        "name": "dotnet.native.5qh83ajnrn.js"
      }
    ],
    "jsModuleRuntime": [
      {
        "name": "dotnet.runtime.td1jw5cbij.js"
      }
    ],
    "wasmNative": [
      {
        "name": "dotnet.native.hidtrmasco.wasm",
        "hash": "sha256-qZxkV2UultYy99BR1+jsqZXzdc9YOPnRV2p/bS2TqRY=",
        "cache": "force-cache"
      }
    ],
    "icu": [
      {
        "virtualPath": "icudt.dat",
        "name": "icudt.g3en5r9teb.dat",
        "hash": "sha256-5BfhzgOGQRjWj996AOsK8ZD97vgGxXD5Ucoy9h+kBH8=",
        "cache": "force-cache"
      }
    ],
    "coreAssembly": [
      {
        "virtualPath": "System.Runtime.InteropServices.JavaScript.wasm",
        "name": "System.Runtime.InteropServices.JavaScript.g52e82cnr4.wasm",
        "hash": "sha256-nC3cN6vGSJGTUkhIIhsKtjXWDBO7BYHOfOKOpaFFcDY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.CoreLib.wasm",
        "name": "System.Private.CoreLib.9yt78osvmw.wasm",
        "hash": "sha256-n4SoC2Xg8IvADygnnMVtkMph8pJ+ZxBRgKsL0UWSjtQ=",
        "cache": "force-cache"
      }
    ],
    "assembly": [
      {
        "virtualPath": "AspNetCore.SassCompiler.wasm",
        "name": "AspNetCore.SassCompiler.306anl4h83.wasm",
        "hash": "sha256-46cmFGfNPREL7BPZXq6uyzoeaG16L5d29yiAAtmQPZk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Authorization.wasm",
        "name": "Microsoft.AspNetCore.Authorization.jtuigu1xf2.wasm",
        "hash": "sha256-hwSDjwAzpGkklIy0DMG6Y+c3l4ik+v0ICuM9CPVZ0qk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.wasm",
        "name": "Microsoft.AspNetCore.Components.nxxw2y30mg.wasm",
        "hash": "sha256-NVKoo1NXpovVxVMnVc+jWabNXC2NPt7+vlE4qvkZIAo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.Forms.wasm",
        "name": "Microsoft.AspNetCore.Components.Forms.xa59aob7lm.wasm",
        "hash": "sha256-GZ1sNuik5+hgR7pIpuQ7DdoUum6Q8gx+Vve5wSNJXgQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.Web.wasm",
        "name": "Microsoft.AspNetCore.Components.Web.tlepq0642w.wasm",
        "hash": "sha256-zy/OhU4C4P69a3RYOF5zJGDXBTT8AZPGxaSvXlF4CtM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.WebAssembly.wasm",
        "name": "Microsoft.AspNetCore.Components.WebAssembly.nh6k734qwa.wasm",
        "hash": "sha256-23Do3YAOnYwSWdzLsK4DCkjxnxaARz0xbDVSYQCrFc0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Metadata.wasm",
        "name": "Microsoft.AspNetCore.Metadata.rgjg7mdns1.wasm",
        "hash": "sha256-dSqr730XzCrlxBJ+BFWxuF6frB8yIocrxOKE8akLFsw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.wasm",
        "name": "Microsoft.Extensions.Configuration.76hc94umrm.wasm",
        "hash": "sha256-73pqokutkGQj7JwH3SV5mVzzlarSPXf07KNb4emMpNs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Abstractions.wasm",
        "name": "Microsoft.Extensions.Configuration.Abstractions.smcq32xx4y.wasm",
        "hash": "sha256-dD1oSevqZL8P8m2tN+Meo99THggHF7bOTcfGxcXQqJM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Binder.wasm",
        "name": "Microsoft.Extensions.Configuration.Binder.pbxa7c4vn8.wasm",
        "hash": "sha256-Nd4XpcWYN1VUa1tdarleQpFOrMre6bEYn3Oj/RRh3QE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.EnvironmentVariables.wasm",
        "name": "Microsoft.Extensions.Configuration.EnvironmentVariables.3x4apr4ifu.wasm",
        "hash": "sha256-mQNlTEWAqNiSxexH5SR4beZ9fCkiKYjODNxyYk/f8lw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.FileExtensions.wasm",
        "name": "Microsoft.Extensions.Configuration.FileExtensions.fxethilq1h.wasm",
        "hash": "sha256-LQZEkEcHagOICrSRahoe4P7I8AfgXjkUrMBRniQV7ww=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Json.wasm",
        "name": "Microsoft.Extensions.Configuration.Json.4wiiartkiz.wasm",
        "hash": "sha256-JJZsava7HNBOLAisdGLKqChaFHDfWstt4jRz0Bt1x/4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.DependencyInjection.wasm",
        "name": "Microsoft.Extensions.DependencyInjection.pl38xq405r.wasm",
        "hash": "sha256-PW2V21yeJSFtal6N14O+foCXSYLLuSlSX6xQa09Pjxs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.DependencyInjection.Abstractions.wasm",
        "name": "Microsoft.Extensions.DependencyInjection.Abstractions.i6fq3nleou.wasm",
        "hash": "sha256-Wj6ohmGuwQlRM9SlZ2Nx84hwYybpP2KDyumIjtwucJw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Diagnostics.wasm",
        "name": "Microsoft.Extensions.Diagnostics.r2q8j1rinz.wasm",
        "hash": "sha256-/QIOo1nNmDv8qveLqiR11dVTKqfG9NjB2ns05RA8ggo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Diagnostics.Abstractions.wasm",
        "name": "Microsoft.Extensions.Diagnostics.Abstractions.86uce2fnuz.wasm",
        "hash": "sha256-wOkIdsSrKThDI1GdV2tFCpKCv1R9vQ0uR3XPojqDRFc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.FileProviders.Abstractions.wasm",
        "name": "Microsoft.Extensions.FileProviders.Abstractions.nbt8m0kgop.wasm",
        "hash": "sha256-c1zn8D3r8IxksuKpM5t8iNn9oNinKcFSwo76W0a8N/4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.FileProviders.Physical.wasm",
        "name": "Microsoft.Extensions.FileProviders.Physical.8pllxfvrgv.wasm",
        "hash": "sha256-HG4sv/fL6pw02Tc4PpuFWNQmIamYgr8j+M0ImCXaq8M=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.FileSystemGlobbing.wasm",
        "name": "Microsoft.Extensions.FileSystemGlobbing.pprirb7nr9.wasm",
        "hash": "sha256-M2x5BImEd7rMjW/3HkplCsIrXf06fXNy3OloetGhZzA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Hosting.Abstractions.wasm",
        "name": "Microsoft.Extensions.Hosting.Abstractions.m16k2kwp6b.wasm",
        "hash": "sha256-ZlKBwoKy5nTMwIbdV2zUsqD+sc51ucSgKn7Vjhz+Wf8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Http.wasm",
        "name": "Microsoft.Extensions.Http.mwayy5w8f0.wasm",
        "hash": "sha256-Sv7H7O7ABRbKvuI27PQL32DlvpQbQ/rEKC98kC4i0fU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Localization.wasm",
        "name": "Microsoft.Extensions.Localization.pd1il3j6hp.wasm",
        "hash": "sha256-g1fwtWbXaMiBByFJq5NvaRgeG34v/GvOu4RHYQFbMRQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Localization.Abstractions.wasm",
        "name": "Microsoft.Extensions.Localization.Abstractions.2u758r9fl0.wasm",
        "hash": "sha256-FqVNdDVXPmPpBSgDp2zWBqqVZXqUemB3N1VC4R9W+bY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Logging.wasm",
        "name": "Microsoft.Extensions.Logging.baaom1ig4g.wasm",
        "hash": "sha256-7RvZ8XxdmwH4ThhRllcKxz5mbZWhGNTTne/TH40ZKB8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Logging.Abstractions.wasm",
        "name": "Microsoft.Extensions.Logging.Abstractions.txivenj2ke.wasm",
        "hash": "sha256-X1TnLC6U0DfJmnJPXrvYTiDIPLI0dL3b0YZlOMPzZmM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Options.wasm",
        "name": "Microsoft.Extensions.Options.vunuix6lam.wasm",
        "hash": "sha256-R+pZj1Vf5ewZTeWvSd37nwX7pTXePl3KevNx94Huz0k=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Options.ConfigurationExtensions.wasm",
        "name": "Microsoft.Extensions.Options.ConfigurationExtensions.lh0c9ljoib.wasm",
        "hash": "sha256-hyW/KrzT0tzJddykUKSyjVWtFZk46jk1ALg0V6ZN6Q4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Primitives.wasm",
        "name": "Microsoft.Extensions.Primitives.9jf76avg2i.wasm",
        "hash": "sha256-m5eFaN1VkMe0mgr9617sITah7/FQ2Vy/wPpwzQdywvc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Validation.wasm",
        "name": "Microsoft.Extensions.Validation.nlnnj0tmti.wasm",
        "hash": "sha256-xeV0qWLkksDN3LmzAL3g9TAX29jZugjzHEmwR7AhR6Y=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.JSInterop.wasm",
        "name": "Microsoft.JSInterop.wfyq9t08zg.wasm",
        "hash": "sha256-JJI8uIlwUCD6SePPenw0RaQdhHU4r8vdxXksquhBkOo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.JSInterop.WebAssembly.wasm",
        "name": "Microsoft.JSInterop.WebAssembly.6fidtwut2x.wasm",
        "hash": "sha256-foSjCKTxOgLNXwvGHX8BldO2WsW10jc6WduVptQcO+8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reactive.wasm",
        "name": "System.Reactive.jhmjxjnu89.wasm",
        "hash": "sha256-aSrYy1gxSueQkX9lh/7jh1ytW2bzw7EgPZb/IHFq3lw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.CSharp.wasm",
        "name": "Microsoft.CSharp.zw5h4ptyla.wasm",
        "hash": "sha256-ze+8JyvfA0PzYMljkJ4lyRm/OXoOW9CoUqxpkKP/tJQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.VisualBasic.Core.wasm",
        "name": "Microsoft.VisualBasic.Core.gesx06xew2.wasm",
        "hash": "sha256-CHaoSdNYicRe1TKRzMwPZBdgKT/Vw5N1QeeCpYN0l+M=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.VisualBasic.wasm",
        "name": "Microsoft.VisualBasic.kce9ke2wkv.wasm",
        "hash": "sha256-5FwiCox2p7lXTQwiCsjXNc9TjBSpM//bHGyf3pwOyx0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Win32.Primitives.wasm",
        "name": "Microsoft.Win32.Primitives.xan2daizox.wasm",
        "hash": "sha256-h6joNwe8nVWWVMiSrjJGYKKCDc6eD3j2u4DgdnVHK7Q=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Win32.Registry.wasm",
        "name": "Microsoft.Win32.Registry.e934wcwh3t.wasm",
        "hash": "sha256-gvnBKm1Ci6N1S0vM/BSrGGoRcfLt7vD49nRx1tTuwbY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.AppContext.wasm",
        "name": "System.AppContext.6ki49ofbyk.wasm",
        "hash": "sha256-ChAWlV8Z7GqSFGecibGuP2Q3mTYUAWAr1wSHVUCiFTs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Buffers.wasm",
        "name": "System.Buffers.wet54snv3q.wasm",
        "hash": "sha256-2Des+px0ULDvD50UEtSEJ60Kn5lkEKWlclZ362NuILg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.Concurrent.wasm",
        "name": "System.Collections.Concurrent.trnmm19sit.wasm",
        "hash": "sha256-J9Qk4FPNhMPHgosrpWJkITm3PS8I70A5J8LqRCsyzw8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.Immutable.wasm",
        "name": "System.Collections.Immutable.liuaw9sggd.wasm",
        "hash": "sha256-/Vzp6Pq8iepk0W8RZR3Tdvmd+xbL+AHKBa+/iGzqL3Q=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.NonGeneric.wasm",
        "name": "System.Collections.NonGeneric.6ibjf77ix0.wasm",
        "hash": "sha256-AmRMq76mwuvlG9+RBLZ0SbLOKbwlGKkOpXkihanb8ug=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.Specialized.wasm",
        "name": "System.Collections.Specialized.syqotvan66.wasm",
        "hash": "sha256-hBdPO2ICNN8+JpuAqgr/C61GV/Q/elUslMNWXrnU/qI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.wasm",
        "name": "System.Collections.i8jb2r8g1q.wasm",
        "hash": "sha256-3rt/DYWeYF24GtNIW/2lILFDlMBJOZY5UteVlsX7fqQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.Annotations.wasm",
        "name": "System.ComponentModel.Annotations.btcx96bte1.wasm",
        "hash": "sha256-HzBzfAU7Zzxj6gbmTindupUMKD0seBrO7PcUTOL2uf4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.DataAnnotations.wasm",
        "name": "System.ComponentModel.DataAnnotations.rc3wa5w0va.wasm",
        "hash": "sha256-BamaiEnGXRnwUwIh3hbUmio58dfNZXN75IQP++nc1m8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.EventBasedAsync.wasm",
        "name": "System.ComponentModel.EventBasedAsync.2z530nx6ei.wasm",
        "hash": "sha256-/ozDkGceMp1gev/KhroQGLT1N7RrwrAW8dBTEhzdFcM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.Primitives.wasm",
        "name": "System.ComponentModel.Primitives.znqex9gyzi.wasm",
        "hash": "sha256-f4MosFKIokBHAPKjyXoLtv7oMYBiGB+zMC44KhzOZ6U=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.TypeConverter.wasm",
        "name": "System.ComponentModel.TypeConverter.ss3t8s2nhz.wasm",
        "hash": "sha256-fJDet8ogyDEhHp3iaNK375gp0f4QzrB4clI0mbJ6/a8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.wasm",
        "name": "System.ComponentModel.h05cml4xs4.wasm",
        "hash": "sha256-YW56ymuPpyxI7ZOZkQt70EjY8Ak4E55XpRDKijEJSco=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Configuration.wasm",
        "name": "System.Configuration.ox480yrrio.wasm",
        "hash": "sha256-/AIJIAcS4aMhCzoYzsMFArlME4Iz0qiQ0lSp+Qi1jcw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Console.wasm",
        "name": "System.Console.0fptv0km10.wasm",
        "hash": "sha256-FJsYlAq+V+SWa4xlz0s2Jnv/zE/bu4sSp7g5Mz5BtJM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Core.wasm",
        "name": "System.Core.ebeyl1vpso.wasm",
        "hash": "sha256-+oWQes0RMO4Yk1ImhEFlxj4fcp2+I4HlGlF2VvMwi+o=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Data.Common.wasm",
        "name": "System.Data.Common.8zztrbmy99.wasm",
        "hash": "sha256-nL1ElXSsTrChw+0zUQ+tA6cRq4vetDXuXANIg8C2wfc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Data.DataSetExtensions.wasm",
        "name": "System.Data.DataSetExtensions.up0lvd3pxh.wasm",
        "hash": "sha256-4jkqhtci6HoV+oTYz6EN6z/tJjeizGKJ7AMu0VQy9EI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Data.wasm",
        "name": "System.Data.0nk4xhr3fp.wasm",
        "hash": "sha256-fFaKrWaeUHwjTkduJ3u8cC6aJr+dwhhd7b6ccLYFuOI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.Contracts.wasm",
        "name": "System.Diagnostics.Contracts.9dlvll2h9r.wasm",
        "hash": "sha256-E3kqB8cuHkyFcxiBWjKpOoe/6xSjGQEozLAHErB+p8k=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.Debug.wasm",
        "name": "System.Diagnostics.Debug.yvncp8eqii.wasm",
        "hash": "sha256-EsOR5DeAYavr5yvFOH3sTJqlQXC8qZEwQ/CG05aexdI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.DiagnosticSource.wasm",
        "name": "System.Diagnostics.DiagnosticSource.z1jmepcrf1.wasm",
        "hash": "sha256-CaS2yBVj82H3dcIUaIe7p/DLyWBEiIdtylTvSMcYyrY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.FileVersionInfo.wasm",
        "name": "System.Diagnostics.FileVersionInfo.6h1zdvu3ka.wasm",
        "hash": "sha256-xmTVEHlkvl/MTcHDeXdLUgIuuP2WrbtcOD3AOj9TmoY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.Process.wasm",
        "name": "System.Diagnostics.Process.f83s3q1c79.wasm",
        "hash": "sha256-oWVVtrENFayaqwUGAOUx1Sur+V3lM9xjTGDhvJPVBIA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.StackTrace.wasm",
        "name": "System.Diagnostics.StackTrace.5jfyrnlrx6.wasm",
        "hash": "sha256-IUon/bcz8/Uzqaa+ISzMdNuyKbYtzTZ7Fyw3PV+D6ZE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.TextWriterTraceListener.wasm",
        "name": "System.Diagnostics.TextWriterTraceListener.8znosn2264.wasm",
        "hash": "sha256-nHjbfamYaaaSEJQONFihsYcS7kS42AA3dNtquhdmh5g=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.Tools.wasm",
        "name": "System.Diagnostics.Tools.glmow3q0z7.wasm",
        "hash": "sha256-nMszUz97E3iaUfGwMLLmDv1H/Pm1ahvb2XolevUkLM0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.TraceSource.wasm",
        "name": "System.Diagnostics.TraceSource.a170pdt1m3.wasm",
        "hash": "sha256-Yr9/UK2m0l+icLUoS6g8ue5LX+BStL29YXU0CwHqCQQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.Tracing.wasm",
        "name": "System.Diagnostics.Tracing.q0ocqsyoaz.wasm",
        "hash": "sha256-mm45B1oWhoAXrXII7iByGw3Kt43Bxgj/lGJpsGp8T3s=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Drawing.Primitives.wasm",
        "name": "System.Drawing.Primitives.ft30j65bzv.wasm",
        "hash": "sha256-U+5dC+w2YGI20JFiDKMD6Se/qyebSNGCzDeHHc0V19Q=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Drawing.wasm",
        "name": "System.Drawing.u2l3il6cyw.wasm",
        "hash": "sha256-ikwpJcJZacSpr0ybUwXFrwiRpW02W22jQgMyrQMkzl8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Dynamic.Runtime.wasm",
        "name": "System.Dynamic.Runtime.hmruy6i6s9.wasm",
        "hash": "sha256-WcGBeeRrtXUTbQza/BAMJdfsOErONis4nbU+zC9PzPA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Formats.Asn1.wasm",
        "name": "System.Formats.Asn1.9e2jiuwyow.wasm",
        "hash": "sha256-4ZyYAR9g/ZQtEUZHReLo63IfJNHcqjJMaNhlV80y8Hg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Formats.Tar.wasm",
        "name": "System.Formats.Tar.li9ndjn5m9.wasm",
        "hash": "sha256-E2esflgCedvVdFVJ9FBaOE93NWk4yS5OPrSoLKhPYYk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Globalization.Calendars.wasm",
        "name": "System.Globalization.Calendars.n35bxrur8g.wasm",
        "hash": "sha256-bWT+60emJpfbdqAuv/ZZoCyLEfIJLBn9XxPe1tJipn8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Globalization.Extensions.wasm",
        "name": "System.Globalization.Extensions.6qvvvq3szi.wasm",
        "hash": "sha256-ovaiX/G9I2vPb7ruqgrBYsYWL85h8rznmepTdo1gDII=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Globalization.wasm",
        "name": "System.Globalization.7hewh3xbhy.wasm",
        "hash": "sha256-S37RZWRqelVqodSPhehxmcVA3y+nmZzM1j8Ctd9GzgU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Compression.Brotli.wasm",
        "name": "System.IO.Compression.Brotli.knq89s6g1i.wasm",
        "hash": "sha256-EM5BiQExppadjlkEKRMeYawf+VWYAL4VI7py/IaOUMA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Compression.FileSystem.wasm",
        "name": "System.IO.Compression.FileSystem.nj1gi0vlog.wasm",
        "hash": "sha256-LRKhQ0i7ACyV8jiLyXtHbd/CMsLwrVnMlmaAz77BgIg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Compression.ZipFile.wasm",
        "name": "System.IO.Compression.ZipFile.16ff89wbmm.wasm",
        "hash": "sha256-iYYEoejkTeJEglSaIFah/nUsGK6r8qjzIlX+5n9Bp/I=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Compression.wasm",
        "name": "System.IO.Compression.58995y5kc0.wasm",
        "hash": "sha256-9dPkzMlBKF5qJzfNE/ky83CILCwvVp5XP/8UyjSrBMA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.FileSystem.AccessControl.wasm",
        "name": "System.IO.FileSystem.AccessControl.e7lmpwlfg1.wasm",
        "hash": "sha256-2l3reSpNIWAOcwGwth9rNFNySJHcRkjvFB/3rn+DA9c=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.FileSystem.DriveInfo.wasm",
        "name": "System.IO.FileSystem.DriveInfo.4220prtvz7.wasm",
        "hash": "sha256-lGDS8ENJnkiOwWalppa4KNy9wR5xO1KPAXaRnJ4Lp7M=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.FileSystem.Primitives.wasm",
        "name": "System.IO.FileSystem.Primitives.y57kfywpqt.wasm",
        "hash": "sha256-uiej9+Fod7T8I0cLnwb8f+DTU94UKqcBM+KZ1cky+Ng=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.FileSystem.Watcher.wasm",
        "name": "System.IO.FileSystem.Watcher.kd2afnkcfi.wasm",
        "hash": "sha256-eGrExPJgoUT4qroSP/Mzm4TW//m1jQMnOEr4mb5rpV0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.FileSystem.wasm",
        "name": "System.IO.FileSystem.uem9gvg2tr.wasm",
        "hash": "sha256-SrreDVvA533rmSbCDMqfZ+S9JcM63t7UlQYgJDu6e3Y=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.IsolatedStorage.wasm",
        "name": "System.IO.IsolatedStorage.y7yabq49mz.wasm",
        "hash": "sha256-vt4kVUY1/59ZU0v+1RSJIvxyE9y2ShXHkJED9mO4fFg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.MemoryMappedFiles.wasm",
        "name": "System.IO.MemoryMappedFiles.q56505rncb.wasm",
        "hash": "sha256-kq1QCTp+lNrHvGbxDmIi9yQHD9lIuXqauNLY5b3STq0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Pipelines.wasm",
        "name": "System.IO.Pipelines.hk76iawatg.wasm",
        "hash": "sha256-0aUJKuBmAk9qoqOg4vog0Yj1o1gd5Y4lB1PNlAG7BP4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Pipes.AccessControl.wasm",
        "name": "System.IO.Pipes.AccessControl.okh5vx8obt.wasm",
        "hash": "sha256-OAvraKuObmwCPtPguPiBrym+/htIgVhw1SUTBNh8tO0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Pipes.wasm",
        "name": "System.IO.Pipes.z39zjvw8m0.wasm",
        "hash": "sha256-3+cz4PC2PA0atQD+HDBDgfRAsJ01MAqsuOp/iaJui1I=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.UnmanagedMemoryStream.wasm",
        "name": "System.IO.UnmanagedMemoryStream.lsiosxs3ce.wasm",
        "hash": "sha256-20oN7YUgCr3Pbxqb3L2QrYvMNKeG5HhZlaCTjzSZ0Tw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.wasm",
        "name": "System.IO.e6varcnezq.wasm",
        "hash": "sha256-qqi3BmbszzTG6FHagt8TBO90CY5amXsX8b5lMHv0cjQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.AsyncEnumerable.wasm",
        "name": "System.Linq.AsyncEnumerable.7kmnms64he.wasm",
        "hash": "sha256-9/cacqYNa/Iep7Ef17K9x3JwwwgwIyJkuMiqYfSszTc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.Expressions.wasm",
        "name": "System.Linq.Expressions.z5is3wy4je.wasm",
        "hash": "sha256-CTIWmnXx3/b7zEBRHDqieSos+NWjAcLAMpQIJjF8Ld4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.Parallel.wasm",
        "name": "System.Linq.Parallel.2tez8pnlwe.wasm",
        "hash": "sha256-tvGt3qISWx4sxxyJeBJLqwjEH5f4ijVmaVz6oFxSOXc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.Queryable.wasm",
        "name": "System.Linq.Queryable.s06cemysxt.wasm",
        "hash": "sha256-fK/N6TV6pMEl5wsWUWEF2mya2EwU1NVumjIdzZl+HAE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.wasm",
        "name": "System.Linq.avbxq3r487.wasm",
        "hash": "sha256-qk/a6Q1gfj2HadY9hJ6D88Q6CT7xYqmv0wPSh5pt9Is=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Memory.wasm",
        "name": "System.Memory.j4b57qbg4f.wasm",
        "hash": "sha256-bXlaqEduxxXLcV48fh8T4ldLvuzjMTBZuiX+7GYgc18=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Http.Json.wasm",
        "name": "System.Net.Http.Json.idijv8xvxz.wasm",
        "hash": "sha256-Oq1KoyY/gcuxB3rJzqIftRfX7EhHR3Mgw97NqeBIj1g=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Http.wasm",
        "name": "System.Net.Http.2r3qy2q34j.wasm",
        "hash": "sha256-fp9hP8bSbBMe7iNkk+J8Ys9OqmmYJCnYDSlPJmFcNjY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.HttpListener.wasm",
        "name": "System.Net.HttpListener.lzap6u9e52.wasm",
        "hash": "sha256-4RE3pNuxq8BhYcVpklfZwoJQ0B6hHsr78JaC4Ngh1Ww=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Mail.wasm",
        "name": "System.Net.Mail.pft9qxzemc.wasm",
        "hash": "sha256-RSu9qkGxrcpcWtPT0ZdjkNFV5EFxGn0jsvw7qqQZ4kI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.NameResolution.wasm",
        "name": "System.Net.NameResolution.d3bdixk7i6.wasm",
        "hash": "sha256-ae+Ag449X9NThlmzVJNi2HdnEmrNJQNAA8vddGlzFQg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.NetworkInformation.wasm",
        "name": "System.Net.NetworkInformation.zhcm2rl0a3.wasm",
        "hash": "sha256-x8Z07kjGqVUUSphspyW1Jnsab3cS4DgYd5sEdnWFPxg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Ping.wasm",
        "name": "System.Net.Ping.dj4o79388i.wasm",
        "hash": "sha256-+YdzswvpILEE3m2WSAbbILK4YoRX3pH5sYUZhY8umek=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Primitives.wasm",
        "name": "System.Net.Primitives.743fcvlcvu.wasm",
        "hash": "sha256-h3V2ADOvD353aamgrxNw5rzIovtuxMP4FHhf3Qlbk8w=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Quic.wasm",
        "name": "System.Net.Quic.a1yel5zn35.wasm",
        "hash": "sha256-MgPIWuhvQHH9TstIFSmS5yRSgZW5aRoPkwkhrCE/i1s=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Requests.wasm",
        "name": "System.Net.Requests.3er6xbwdlt.wasm",
        "hash": "sha256-K93LccPYPFhP/tX7jfjldMnuUsHbFoQYuKMlWgLO+dI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Security.wasm",
        "name": "System.Net.Security.xgzv0ko52k.wasm",
        "hash": "sha256-UVVOZZLziANF8wJvpMOE8I7XFxHTxclxW1vRJF24bDQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.ServerSentEvents.wasm",
        "name": "System.Net.ServerSentEvents.c9body95gy.wasm",
        "hash": "sha256-AOywf9y+QESrFYKM7q1P//fSw+62rfpcE1Mbvnu+eHg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.ServicePoint.wasm",
        "name": "System.Net.ServicePoint.p0ucovj5h2.wasm",
        "hash": "sha256-B3nHW/STmReehGYS7aBEZqeHwuNS5j6wRfskkcAAgYA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Sockets.wasm",
        "name": "System.Net.Sockets.byj019u1s8.wasm",
        "hash": "sha256-/RWoZefLFZuaBoYH8gQTQZ6COhtzf/optIBvAXYJb6c=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.WebClient.wasm",
        "name": "System.Net.WebClient.4dp32j95um.wasm",
        "hash": "sha256-2B4rvA5YQ8XtoVqiH5gm17NXa1nfvahGyqC20fkIwXI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.WebHeaderCollection.wasm",
        "name": "System.Net.WebHeaderCollection.icvdbglb63.wasm",
        "hash": "sha256-8hoJOATRLUlKZ0w3f759MIWxXMw14OvKh70fagG2O4g=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.WebProxy.wasm",
        "name": "System.Net.WebProxy.5ka76dmwsd.wasm",
        "hash": "sha256-y1RTLOcKHDeq+ihYS7cr293ZvZILMwOoX2hNAOerhuI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.WebSockets.Client.wasm",
        "name": "System.Net.WebSockets.Client.rcxncnv07r.wasm",
        "hash": "sha256-m0DfN25Z5JhtYvPr0uHazF+1LNKkevjLZ3WQxFCJWeQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.WebSockets.wasm",
        "name": "System.Net.WebSockets.npjnbrqn9a.wasm",
        "hash": "sha256-i1oKUtk7L4BSkrvo+8R6ZTXklyy3xiyZVr/1auhkZgY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.wasm",
        "name": "System.Net.wwoxzmjw6f.wasm",
        "hash": "sha256-oLiEPIYRKAvjNVWEjYmMyFrQTpVrl7O6kMKxNUd4ZUc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Numerics.Vectors.wasm",
        "name": "System.Numerics.Vectors.sb4uolkred.wasm",
        "hash": "sha256-aP2bndfOz65sS1OpA6NiqrbbiFUB5dqcmM/QeKrQy4Y=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Numerics.wasm",
        "name": "System.Numerics.68zjqpn6op.wasm",
        "hash": "sha256-6niRSvTjk2SuQ1FBA4DiunMX5SHgbBXdcbKq52ag+rU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ObjectModel.wasm",
        "name": "System.ObjectModel.ri8oc7vij6.wasm",
        "hash": "sha256-3UbiMcU3g6iERMjd1AY+QaEKwFwOt2qWyGcfqUNp6qU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.DataContractSerialization.wasm",
        "name": "System.Private.DataContractSerialization.0e4075f7bn.wasm",
        "hash": "sha256-OGFl9mcrCB54I23r82Wnf0lIQM7iF34+BewJV8IZ3us=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.Uri.wasm",
        "name": "System.Private.Uri.ovg2yo57sw.wasm",
        "hash": "sha256-9JMzR7pds65zms68emsfV3qKEYNI8UuEa2PK2PXktEY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.Xml.Linq.wasm",
        "name": "System.Private.Xml.Linq.eynu0xtshr.wasm",
        "hash": "sha256-OjdK3XzJqYeB4NgUB/Vhntw6TxraTCE32vYZ56rHQJc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.Xml.wasm",
        "name": "System.Private.Xml.rfx19rrwxv.wasm",
        "hash": "sha256-eft8f6CG2wea5zu/Im1pXCTs9D0IfGh3NlE8Xm2r79s=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.DispatchProxy.wasm",
        "name": "System.Reflection.DispatchProxy.apouv6e8ty.wasm",
        "hash": "sha256-jg96IlFuUd8e8sE6N04xC4pzTrw0mYqsp2L/Gisvc/U=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Emit.ILGeneration.wasm",
        "name": "System.Reflection.Emit.ILGeneration.mgj60fsc5g.wasm",
        "hash": "sha256-BgRaN41GfHks7F/qxNbuyio520O5MbpE0FPJjBFcGqo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Emit.Lightweight.wasm",
        "name": "System.Reflection.Emit.Lightweight.ydpccrboaw.wasm",
        "hash": "sha256-hpPxW8Id3EYYxkEm38uT/Yme+4RD6rMsGkusJsAE+zA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Emit.wasm",
        "name": "System.Reflection.Emit.9ibhjba2w9.wasm",
        "hash": "sha256-f4xg0FPPTvueVNQvwl6ILVHe5axwrfds4vuHbhvfJho=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Extensions.wasm",
        "name": "System.Reflection.Extensions.3ot270saw1.wasm",
        "hash": "sha256-s6mNNuFkFx8L1E7Co9yh/D10b7I18zfcJki2oOpuUUQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Metadata.wasm",
        "name": "System.Reflection.Metadata.so2615940o.wasm",
        "hash": "sha256-HLiTk8EtXMghNruCL8pgJm+e+6uiUnW3iTRI1hvFDB8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Primitives.wasm",
        "name": "System.Reflection.Primitives.4op3e2d83d.wasm",
        "hash": "sha256-THVk2aIzwFvdfbZqD0eGvMRXDyFSM2Clp085oao8jog=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.TypeExtensions.wasm",
        "name": "System.Reflection.TypeExtensions.v9ou6wv7wn.wasm",
        "hash": "sha256-Y8xW1+tOluFHEzutvWE7pv44bhEzeh/UsTk8KeyiENc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.wasm",
        "name": "System.Reflection.mqr3d761jx.wasm",
        "hash": "sha256-Lvgp4SEnDAJjciq4VjNtoVwt/cfTVRB0TYFqksbTfK4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Resources.Reader.wasm",
        "name": "System.Resources.Reader.ng3m9bu42w.wasm",
        "hash": "sha256-+a81Y8fS+hXhrARzVJIMBNe1QQsjr3WZxQpsvGlIAxU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Resources.ResourceManager.wasm",
        "name": "System.Resources.ResourceManager.1lynjgmf8j.wasm",
        "hash": "sha256-1WHXzIt35QRxtMDRbfaEJAakpb4r1Vm+o+/TQUbHF9k=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Resources.Writer.wasm",
        "name": "System.Resources.Writer.1zd91zpufu.wasm",
        "hash": "sha256-AzRQsA7mi8HWSuRp2glI8VzCyCyX7F9hxuUXAyZ3Vw0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.CompilerServices.Unsafe.wasm",
        "name": "System.Runtime.CompilerServices.Unsafe.1afk96dqcd.wasm",
        "hash": "sha256-WVs7msdTcNs/dljbMgEaPVpTMO3TbTOCYf9uuRyyb5E=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.CompilerServices.VisualC.wasm",
        "name": "System.Runtime.CompilerServices.VisualC.vxqnk34gpy.wasm",
        "hash": "sha256-I6gi253cFRJo3oVVfX7JYRgvtLj14TVieHkwcpiTeCk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Extensions.wasm",
        "name": "System.Runtime.Extensions.mddwnsj9fx.wasm",
        "hash": "sha256-Rh1A42rO+JOjIp9We6MrH/TkoNpoEUQJt1D421cAKLs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Handles.wasm",
        "name": "System.Runtime.Handles.xj8vrqt3s8.wasm",
        "hash": "sha256-DXAaR0yAKlxPVSmsyYtz7ID/PREagVUnQoKDVxfYGnc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.InteropServices.RuntimeInformation.wasm",
        "name": "System.Runtime.InteropServices.RuntimeInformation.2ju2hl2p1y.wasm",
        "hash": "sha256-DoxgDa5BcBVyOVoQDWzMkRmZtj0pa/PWXvEYN44F584=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.InteropServices.wasm",
        "name": "System.Runtime.InteropServices.ovzh6ydk1t.wasm",
        "hash": "sha256-5C2m3iXH/NI/dvX5C2Xuf9eIWpAgOYPhSmeFbSIpryc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Intrinsics.wasm",
        "name": "System.Runtime.Intrinsics.ynyc05zgt5.wasm",
        "hash": "sha256-gmFN4XG8spuacbNoL5vs9zzXkwu+NBKzH4+DiuGKm/E=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Loader.wasm",
        "name": "System.Runtime.Loader.qxxk2jz7j5.wasm",
        "hash": "sha256-Mrm5uJQOeNHOX9e2DEY5NeUOWU0ovNig0BtAwlEe2lA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Numerics.wasm",
        "name": "System.Runtime.Numerics.lc01ukjecs.wasm",
        "hash": "sha256-BRZ4XKDzmz5cbZkJP2ZIPUFrqJa/Cyrvh74kkmFTC7c=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.Formatters.wasm",
        "name": "System.Runtime.Serialization.Formatters.ihzpa2pqe1.wasm",
        "hash": "sha256-5iF1nVZh8U5is0rgdLQtzPtsK8CPP6L4w8zoA+8YCjk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.Json.wasm",
        "name": "System.Runtime.Serialization.Json.h3uhphxpy3.wasm",
        "hash": "sha256-Y2DKBPukJTzlZPsO7b3RESJmNG7bIn/xNJ1m/opEq5g=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.Primitives.wasm",
        "name": "System.Runtime.Serialization.Primitives.1f360ltmbg.wasm",
        "hash": "sha256-zRpt3C2t9URlXttwJOlSFXzHiGVsuP4tpqCIZ4XPoMk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.Xml.wasm",
        "name": "System.Runtime.Serialization.Xml.7nr3brz7kn.wasm",
        "hash": "sha256-s9WuHIXkBRJJCneP5gVuIEX6NNnKb7oevvwhwmvzslU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.wasm",
        "name": "System.Runtime.Serialization.x2wtlvas9l.wasm",
        "hash": "sha256-VwckfF08KqiAwaQdsDWJqH/2OMKdXHJCjds6o2L0VMA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.wasm",
        "name": "System.Runtime.d422ca20bk.wasm",
        "hash": "sha256-w3T3dlsouVyz6o/GVT1ZTSzoKTE0bx4jM2aJR+2GBm0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.AccessControl.wasm",
        "name": "System.Security.AccessControl.tzvbwas9v4.wasm",
        "hash": "sha256-uf6LWFVxFSdcUKbuCdIaYyRz6Oc1KeMt6jDGgdPdfbo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Claims.wasm",
        "name": "System.Security.Claims.kmr0c9f5hf.wasm",
        "hash": "sha256-3At61IMT8JJEuevA7Bj0vx+iMWjIWmZddoDOY6oJL8s=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.Algorithms.wasm",
        "name": "System.Security.Cryptography.Algorithms.hq9pyjcll6.wasm",
        "hash": "sha256-iYuAu8qnPAgPMdsiDK9k5awcZtqfgZfFfDbEHUVl76c=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.Cng.wasm",
        "name": "System.Security.Cryptography.Cng.floxc03bhp.wasm",
        "hash": "sha256-PYkl7QY4rgfhpBB/bxEoi3DgaCk8hsZhYVxu7A2CaQw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.Csp.wasm",
        "name": "System.Security.Cryptography.Csp.kmmb3hk1f5.wasm",
        "hash": "sha256-TI44e4YK8eED0SFe8akvyovlVJW8KtPTBDz/0RlpgkY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.Encoding.wasm",
        "name": "System.Security.Cryptography.Encoding.zxypy2zgbl.wasm",
        "hash": "sha256-J1fBbKh+UV9NDVcepuBrPr6tNFwAGm/fWt2ctFyd+2o=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.OpenSsl.wasm",
        "name": "System.Security.Cryptography.OpenSsl.ai6b8tgs3s.wasm",
        "hash": "sha256-spG8jDlF+w8m7QvVUkwMAHiAnG0n8uS1uKKpwEqIums=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.Primitives.wasm",
        "name": "System.Security.Cryptography.Primitives.qos5xw1np4.wasm",
        "hash": "sha256-ejGmgcpuefkY3dbSE+/OpOdB4F3KZzbG0fIP0AWK4QA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.X509Certificates.wasm",
        "name": "System.Security.Cryptography.X509Certificates.6t6blxotr2.wasm",
        "hash": "sha256-OhAr14NL65oPMRmFgBpiCELJOdUshRYcubXMNWTwT/I=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.wasm",
        "name": "System.Security.Cryptography.0q0f18i923.wasm",
        "hash": "sha256-aNJGXx9Qb0ZpOO/d2y+2Gjf1OAQbwdshAzLrINb9loo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Principal.Windows.wasm",
        "name": "System.Security.Principal.Windows.i48hm719ow.wasm",
        "hash": "sha256-nhr+Xf1evVGAiiWTvKb1Vt1fFA6iyXUSDtkbeIqly6Q=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Principal.wasm",
        "name": "System.Security.Principal.hx0z2fp4df.wasm",
        "hash": "sha256-i6LZEXVZRc75HUDpTv1AY6N2HGzkF6XqqkApTGj69nw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.SecureString.wasm",
        "name": "System.Security.SecureString.gtu1uy604b.wasm",
        "hash": "sha256-vKe5pefi4YnDKxMvIRnCQEBSxQGSRGbj3HlEWJx96mQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.wasm",
        "name": "System.Security.9o5v7zhnyl.wasm",
        "hash": "sha256-edGr+7E3RXhvj7K8FhhPn9/DrRDMfGIodWej6QaM3j0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ServiceModel.Web.wasm",
        "name": "System.ServiceModel.Web.srqyoxf6b0.wasm",
        "hash": "sha256-+JeeFYLPrF6Xrx1QBcjUd+++WVNzuAlxFvF4NqtYGfc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ServiceProcess.wasm",
        "name": "System.ServiceProcess.fl043kwf6v.wasm",
        "hash": "sha256-A09O3i4MVrsZZ77XXKMHnPeP1+GXGYyzaQbOizqD6LA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Encoding.CodePages.wasm",
        "name": "System.Text.Encoding.CodePages.atz1iv9lsj.wasm",
        "hash": "sha256-jmkTpjWVC85rxqdlH2bk2A2u1HryW1Zi304KCGOJgmw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Encoding.Extensions.wasm",
        "name": "System.Text.Encoding.Extensions.8gyyo2cw0j.wasm",
        "hash": "sha256-6AL+rgIfS183Kop+zdaMvUmrqg+WJio4HXvWiKRyx3A=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Encoding.wasm",
        "name": "System.Text.Encoding.4xkhzde4gg.wasm",
        "hash": "sha256-2ESsfWgANKbhPzvu7DJPJtspkx8QaRDVzzZ6pVfl64U=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Encodings.Web.wasm",
        "name": "System.Text.Encodings.Web.0uypcz31t5.wasm",
        "hash": "sha256-mOR2G6drP5hjJkyxb03I6mEc16edmatU6Kw/egWsuRg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Json.wasm",
        "name": "System.Text.Json.9g2geqmwno.wasm",
        "hash": "sha256-l7le9OOTs2L7JkwO/TJZdXRg3oTambbw3B5TahQgTJ4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.RegularExpressions.wasm",
        "name": "System.Text.RegularExpressions.lg5wvx9zgq.wasm",
        "hash": "sha256-WyndaUv2HdfEYjpAYm8yDYDSU048yTE9EBmszR6Dcf8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.AccessControl.wasm",
        "name": "System.Threading.AccessControl.twctvo4j43.wasm",
        "hash": "sha256-Yzr24S0zOV7Pd64NBPePIMkAMxi+iFEy1x5MBzkdQzw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Channels.wasm",
        "name": "System.Threading.Channels.4wlo17hcwr.wasm",
        "hash": "sha256-LE5DKLJEE2XI8LQGrcjYC9kZ9yfy6qkP9ecmwYByWeU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Overlapped.wasm",
        "name": "System.Threading.Overlapped.4mkd9ntvjg.wasm",
        "hash": "sha256-ZGHJv0zb0O6wjf9pGw6W67pj3ltg4GL0I2pguPEyXyU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Tasks.Dataflow.wasm",
        "name": "System.Threading.Tasks.Dataflow.m0mmgg1yio.wasm",
        "hash": "sha256-9vhZR/Nigf5m0jPgtN2otXC9bCNiNJf+pyYi7phZFnk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Tasks.Extensions.wasm",
        "name": "System.Threading.Tasks.Extensions.ss31z7cho1.wasm",
        "hash": "sha256-hLfQ2zX4/ljc+GHcJmepRIW0a5CW+qHnPnozR5tq//M=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Tasks.Parallel.wasm",
        "name": "System.Threading.Tasks.Parallel.w1xi8klrsi.wasm",
        "hash": "sha256-1F/gZ2lgsqdbpY+npV6/8qQpzu+FR/1Bh5x2E9G0YFc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Tasks.wasm",
        "name": "System.Threading.Tasks.xm6zjndxb4.wasm",
        "hash": "sha256-WcuZaI+J+qMGRfpz9nBZdLCmNRZr4yUWgNhlwQ8UrSA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Thread.wasm",
        "name": "System.Threading.Thread.cj5r5c2ymv.wasm",
        "hash": "sha256-yMmHRUJA5ggyNNlfZZpxxrt/+u19GoFduhQG1BKPBfI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.ThreadPool.wasm",
        "name": "System.Threading.ThreadPool.wlycuryumo.wasm",
        "hash": "sha256-NASbfak3N2MLjY+SqSM9yi49LsfylgbArIAcFd3yo/k=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Timer.wasm",
        "name": "System.Threading.Timer.wbhfr63m87.wasm",
        "hash": "sha256-fIgpqp5gwaohbyitnftRmf8MUYZQX7Gu2hrgGykgspo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.wasm",
        "name": "System.Threading.emmnrcg8bm.wasm",
        "hash": "sha256-uoL1jq9U3+jZm5wMPanYsMwZ4i65HBL+xC0tUpzvmTU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Transactions.Local.wasm",
        "name": "System.Transactions.Local.1rbe0xv9uu.wasm",
        "hash": "sha256-A3ktgvahes+cFphfmwnU8fJb9yXPYad4NjGtaAmxK1A=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Transactions.wasm",
        "name": "System.Transactions.awzcmtwgtx.wasm",
        "hash": "sha256-uqqIdacYjctdHLfIL/Bhi7qwZ7I08pBmxBy2NpDPEuM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ValueTuple.wasm",
        "name": "System.ValueTuple.p0q9lsys4x.wasm",
        "hash": "sha256-B8/tvfkCV372tppptDF1GtjRMotS5LA9oOghWr7LR58=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Web.HttpUtility.wasm",
        "name": "System.Web.HttpUtility.f01wh20ygk.wasm",
        "hash": "sha256-H0YkPdTwl20jGMeoh+YWF7ZbnKGFDVPfx0xTZsYiYcU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Web.wasm",
        "name": "System.Web.tnwie12ywv.wasm",
        "hash": "sha256-J3jSRthPTvCcppD/mIHJ98cCyLn9idJiCDdf7n+nF+E=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Windows.wasm",
        "name": "System.Windows.e0cswcp3l5.wasm",
        "hash": "sha256-zkuEmrDq/Zp/1d14bc3aOxz3hQRXAku7dBO6QxtmQ1U=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.Linq.wasm",
        "name": "System.Xml.Linq.lvgajsjprf.wasm",
        "hash": "sha256-DzmeHtKx2tP+/EZD2DUj8vJMjd3/fQWlYgijSlpL3fo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.ReaderWriter.wasm",
        "name": "System.Xml.ReaderWriter.c3rlcvf2s2.wasm",
        "hash": "sha256-mKsAz+EYJPbCtkucAVt/XX4CH3IP+mPJHamKW/Vf8Xw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.Serialization.wasm",
        "name": "System.Xml.Serialization.c2vhd6jg5y.wasm",
        "hash": "sha256-hOxo3Biz6v1MahkhFlkC9TEqVRXbGLdX2CP4wbwbqks=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XDocument.wasm",
        "name": "System.Xml.XDocument.opd422j48j.wasm",
        "hash": "sha256-lCcJmk4FwN60pASkZmshbk6cicd+yfVf7QgbygHlEP0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XPath.XDocument.wasm",
        "name": "System.Xml.XPath.XDocument.3vem9ngb2a.wasm",
        "hash": "sha256-QeYcva4BNnX6YvJgwUBfS6Y7Eklmms46MDzeSKqh0PM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XPath.wasm",
        "name": "System.Xml.XPath.97gkeyz3b5.wasm",
        "hash": "sha256-BRVIL0KCsSAmIVs43LruqUKzUSEaJZLurVoow2OK/wA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XmlDocument.wasm",
        "name": "System.Xml.XmlDocument.87zgatjrgm.wasm",
        "hash": "sha256-zBvIxyeEkAjbHM80xEBIj09PbI/YM4IGKGndP89DBCM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XmlSerializer.wasm",
        "name": "System.Xml.XmlSerializer.9lx5s6l1au.wasm",
        "hash": "sha256-s8JxRHk0Vhbzj7w/0FKpfiS6bEO0ntUTHIxqvu+C/CU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.wasm",
        "name": "System.Xml.qc3c9bbnhl.wasm",
        "hash": "sha256-Bj+ZKtCko2y+AnBl0VjCBI9fPDsjl8Y14+wAMfVnBYQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.wasm",
        "name": "System.2ke8p6r14i.wasm",
        "hash": "sha256-snwnVfRtdcYDHEcuvJu/GSbDJyE2wQDqzycJIGzuB3E=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "WindowsBase.wasm",
        "name": "WindowsBase.hdjsp0hu8y.wasm",
        "hash": "sha256-FZqQM7cLbxNANKv4NZlf/ly18rLNlsrAVurKGsP5zH4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "mscorlib.wasm",
        "name": "mscorlib.0wlz4jreot.wasm",
        "hash": "sha256-cMY7vMiDdV6TOoSgHf0GpruGUtviYLC6b1rJNKO7aIQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "netstandard.wasm",
        "name": "netstandard.m9srzb511g.wasm",
        "hash": "sha256-Jpkb2VSJfYTd3IoxetRquQkg46YS3HvtAPsY7INsqec=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.Application.wasm",
        "name": "PrTask.Application.ia7gcb4tpx.wasm",
        "hash": "sha256-6qAKEM15Wed3gz9qA/DjLPlJzetdfJrjaKv9pI9C7CE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.Domain.wasm",
        "name": "PrTask.Domain.11ukvkvy0g.wasm",
        "hash": "sha256-BZSVGIs8egtd1mvaa/H/WPrTu+fhrIy0wrOngkQCOHY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.SharedUI.wasm",
        "name": "PrTask.SharedUI.n0bmi5tn5e.wasm",
        "hash": "sha256-uQg00VjouNj0BDcDbzRHyTSmG7XWf+PBRcngQ8dfuNU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.Client.wasm",
        "name": "PrTask.Client.su7fos524t.wasm",
        "hash": "sha256-fFLkPQXu3lSBu5uoQXQFRYZBAhiQI9pzJkpDfotbXLs=",
        "cache": "force-cache"
      }
    ],
    "pdb": [
      {
        "virtualPath": "PrTask.Application.pdb",
        "name": "PrTask.Application.9tou3ofreb.pdb",
        "hash": "sha256-4zNBsh69JoeukGG1Tqxc575MWGkl26SbKdN8VLbuVFw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.Domain.pdb",
        "name": "PrTask.Domain.83fvto0n9k.pdb",
        "hash": "sha256-JLudDgQRT8x7smlQJIIPqoIKC2N28R8+1Tib1ojUiaU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.SharedUI.pdb",
        "name": "PrTask.SharedUI.gz9vsf5qhn.pdb",
        "hash": "sha256-TEx+0yHwH0xTTJ6bxPCrm3IKTMwQXeXlT8ioSuwkav0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.Client.pdb",
        "name": "PrTask.Client.ba1pzazj3n.pdb",
        "hash": "sha256-PdIV0mnx4GrzpvJtQ0m4nUrI69Vkzj4u6dUgT87xREM=",
        "cache": "force-cache"
      }
    ],
    "satelliteResources": {
      "ar": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.g1hxn8d01w.wasm",
          "hash": "sha256-hDuPI3HlR0lembs219XKk7C8cDF4Z3IaSsos1t0njpU=",
          "cache": "force-cache"
        }
      ],
      "de": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.ob36zezlhr.wasm",
          "hash": "sha256-rD6uLcoONaHSQHb39zoUUUczfoMxH4I+ziBbt4UqtuQ=",
          "cache": "force-cache"
        }
      ],
      "es": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.30zgv6gwl4.wasm",
          "hash": "sha256-M2xE45wQ6T5vGRa0/ZcmxOngpB4nLged13Cjn7WYskk=",
          "cache": "force-cache"
        }
      ],
      "fil": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.j4y5ocnh5s.wasm",
          "hash": "sha256-/UuD/O89BKWhQQWVHzps5Bfym3gCDTdwYgmSnHDNgic=",
          "cache": "force-cache"
        }
      ],
      "fr": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.8v29unfuvg.wasm",
          "hash": "sha256-xIBYu61nlapWn7Y7PoXvgthi1t951oPk+BHymfUBxSw=",
          "cache": "force-cache"
        }
      ],
      "hi": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.bsiyv83m67.wasm",
          "hash": "sha256-m+JwUh9wESAVIRqTAccrrfp7Ykn9ceyFDnrFATNdUVI=",
          "cache": "force-cache"
        }
      ],
      "id": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.fvhlupllep.wasm",
          "hash": "sha256-RUDsRooT2J6o3x3TiGl7Z+gVCB1dyPh3DuhWz9dPwvk=",
          "cache": "force-cache"
        }
      ],
      "it": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.p8sgzafrfn.wasm",
          "hash": "sha256-+Q0lHDmNHX8BBhQUS4ytG+TSRyWIthVKpYe5+DN2yFM=",
          "cache": "force-cache"
        }
      ],
      "ja": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.5fjp880nj4.wasm",
          "hash": "sha256-b+lQuTCUhcT1oEo83rx0CP0GPstfI42ro0AEAlBpaXI=",
          "cache": "force-cache"
        }
      ],
      "ko": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.08lsb3efmn.wasm",
          "hash": "sha256-cNF42ryKoypq/PlOqGTD6EY/Gvu6LBknp/D6hLpV+PM=",
          "cache": "force-cache"
        }
      ],
      "nl": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.dwnwjpi1zi.wasm",
          "hash": "sha256-/Zew4F2fp4YMG44QoWklvwNXyfL1cloARuBITzHKA74=",
          "cache": "force-cache"
        }
      ],
      "pt": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.mch481cxaf.wasm",
          "hash": "sha256-1tzbyhOGdbJvGpU/RaP9wcgWi9gGT4Z3lGxLPcxuk00=",
          "cache": "force-cache"
        }
      ],
      "ru": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.o6l8b59zpx.wasm",
          "hash": "sha256-wHNjmtP9SQeLkwZLmL8gwTuMndnanJe1hULzw2bV4fo=",
          "cache": "force-cache"
        }
      ],
      "tr": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.n2xkx35vua.wasm",
          "hash": "sha256-kV6YLOEHUESQY8T8YoVzMP6qWoI2E5E05QLp8a68FfA=",
          "cache": "force-cache"
        }
      ],
      "zh": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.n6n2iuncl4.wasm",
          "hash": "sha256-39tYbvWYl0svAX1+70vD4CyeWNQFrvvAD5iF+1QKZkM=",
          "cache": "force-cache"
        }
      ]
    }
  },
  "debugLevel": -1,
  "appsettings": [
    "../appsettings.json"
  ],
  "globalizationMode": "all",
  "extensions": {
    "blazor": {}
  },
  "runtimeConfig": {
    "runtimeOptions": {
      "configProperties": {
        "Microsoft.AspNetCore.Components.Routing.RegexConstraintSupport": false,
        "Microsoft.Extensions.DependencyInjection.VerifyOpenGenericServiceTrimmability": true,
        "System.ComponentModel.DefaultValueAttribute.IsSupported": false,
        "System.ComponentModel.Design.IDesignerHost.IsSupported": false,
        "System.ComponentModel.TypeConverter.EnableUnsafeBinaryFormatterInDesigntimeLicenseContextSerialization": false,
        "System.ComponentModel.TypeDescriptor.IsComObjectDescriptorSupported": false,
        "System.Data.DataSet.XmlSerializationIsSupported": false,
        "System.Diagnostics.Debugger.IsSupported": false,
        "System.Diagnostics.Metrics.Meter.IsSupported": false,
        "System.Diagnostics.Tracing.EventSource.IsSupported": false,
        "System.GC.Server": true,
        "System.Globalization.Invariant": false,
        "System.TimeZoneInfo.Invariant": false,
        "System.Linq.Enumerable.IsSizeOptimized": true,
        "System.Net.Http.EnableActivityPropagation": false,
        "System.Net.Http.WasmEnableStreamingResponse": true,
        "System.Net.SocketsHttpHandler.Http3Support": false,
        "System.Reflection.Metadata.MetadataUpdater.IsSupported": false,
        "System.Resources.ResourceManager.AllowCustomResourceTypes": false,
        "System.Resources.UseSystemResourceKeys": true,
        "System.Runtime.CompilerServices.RuntimeFeature.IsDynamicCodeSupported": true,
        "System.Runtime.InteropServices.BuiltInComInterop.IsSupported": false,
        "System.Runtime.InteropServices.EnableConsumingManagedCodeFromNativeHosting": false,
        "System.Runtime.InteropServices.EnableCppCLIHostActivation": false,
        "System.Runtime.InteropServices.Marshalling.EnableGeneratedComInterfaceComImportInterop": false,
        "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization": false,
        "System.StartupHookProvider.IsSupported": false,
        "System.Text.Encoding.EnableUnsafeUTF7Encoding": false,
        "System.Text.Json.JsonSerializer.IsReflectionEnabledByDefault": true,
        "System.Threading.Thread.EnableAutoreleasePool": false,
        "Microsoft.AspNetCore.Components.Endpoints.NavigationManager.DisableThrowNavigationException": false,
        "System.Diagnostics.StackTrace.IsLineNumberSupported": false,
        "System.Runtime.CompilerServices.RuntimeFeature.IsMultithreadingSupported": false
      }
    }
  }
}/*json-end*/);export{po as default,mo as dotnet,go as exit};
