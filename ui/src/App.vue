<template>
  <div id="app">
    <!-- <navbar /> -->
    <sidebar/>
    <router-view />
    <footbar />
  </div>
</template>

<script>
import navbar from '/src/components/Navbar.vue'
import footbar from './components/Footer.vue'
import sidebar from './components/Sidebar.vue'

export default {
   name: 'app',
  components: {
     navbar,
     footbar,
     sidebar
 } 
}
</script>
