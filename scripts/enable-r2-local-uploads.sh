#!/usr/bin/env bash
# Enable R2 Local Uploads on all prtask R2 buckets.
# Reduces cross-region write TTLB by up to 75% at no additional cost.
# Requires: npx wrangler (authenticated to Cloudflare account)
# Docs: https://developers.cloudflare.com/r2/buckets/local-uploads/

set -euo pipefail

BUCKETS=("prtask-diffs" "prtask-avatars" "prtask-data")

for bucket in "${BUCKETS[@]}"; do
  echo "Enabling Local Uploads on $bucket..."
  npx wrangler r2 bucket local-uploads enable "$bucket"
  echo "  Done: $bucket"
done

echo ""
echo "R2 Local Uploads enabled on all buckets."
