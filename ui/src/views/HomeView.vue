<script setup>
// import TheWelcome from '../components/TheWelcome.vue'
</script>

<template>
  <main class="body"></main>
</template>

<style>
.body {
  min-height: 100vh;
  display: flex;
  align-items: center;
  background-position: center;
  background-size: cover;
  background-image: url('../assets/images/Garden HQ.png');
}

@media (min-width: 1024px) {
  .body {
    min-height: 100vh;
    display: flex;
    align-items: center;
  }
}
</style>
