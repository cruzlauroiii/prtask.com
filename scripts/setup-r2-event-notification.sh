#!/usr/bin/env bash
# Sets up R2 event notification to trigger prtask-r2-events queue
# when db/prtask.json is written to the prtask-data bucket.
#
# Prerequisites: wrangler authenticated, queue "prtask-r2-events" already created.

set -euo pipefail

BUCKET="prtask-data"
QUEUE="prtask-r2-events"
PREFIX="db/prtask.json"

echo "Creating R2 event notification rule..."
npx wrangler r2 bucket notification create "$BUCKET" \
  --event-type object-create \
  --prefix "$PREFIX" \
  --queue "$QUEUE"

echo "Done. R2 writes to ${BUCKET}/${PREFIX} will now enqueue to ${QUEUE}."
