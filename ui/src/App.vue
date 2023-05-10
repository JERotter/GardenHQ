<template>
  <div id="app">
    <navbar />
    <router-view />
    <footbar />
  </div>
</template>

<script>
import navbar from '/src/components/Navbar.vue'
import footbar from './components/Footer.vue'

export default {
   name: 'app',
  components: {
     navbar,
     footbar
 }
}
</script>
