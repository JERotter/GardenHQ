/* eslint-env node */
require('@rushstack/eslint-patch/modern-module-resolution')

module.exports = {
  root: true,
  'extends': [
    'plugin:vue/vue3-essential',
    'eslint:recommended',
    '@vue/eslint-config-prettier/skip-formatting'
  ],
  // Eslint Rules
  "brace-style": "error",
  "nonblock-statement-body-position": ["error", "below"],
  "curly": ["error", "all"],
  "indent": ["error", 2],
  "no-else-return": "error",
  "object-curly-spacing": ["error", "always", {
    arraysInObjects: false,
    objectsInObjects: false
  }],
  "comma-dangle": ["error", "always-multiline"],
    "semi": ["error", "always"],
  parserOptions: {
    ecmaVersion: 'latest',
    parser: "babel-eslint"
  }
}
