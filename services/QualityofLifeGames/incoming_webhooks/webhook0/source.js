/*
  See https://developer.github.com/webhooks/event-payloads for
  examples of payloads.

  Try running in the console below.
*/

exports = function(payload) {
  return payload.pull_request && payload.action === 'opened';
};